using KirigiriLib.Utils;
using KirigiriLib.KiriEntry;
using System;
using System.IO;

namespace KirigiriLib;

/// <summary>
/// Manages Spike Chunsoft's .font files, allowing for loading, editing, and saving glyph metadata.
/// </summary>
public class FontManager
{

    private const uint FONT_MAGIC = 0x53704674;
    private const uint FONT_VERSION = 4;
    public uint LetterSpacing = 0x00;
    private const uint DEFAULT_UNK2 = 0x01;
    private List<FontEntry> Entries { get; set; } = new();
    public FontManager() { }

    /// <summary>
    /// Initializes a new instance of FontManager and loads a .font file.
    /// </summary>
    /// <param name="filePath">Path to the .font file.</param>
    public FontManager(string filePath) => Load(filePath);

    /// <summary>
    /// Initializes a new instance of FontManager and loads a .font from a stream.
    /// </summary>
    public FontManager(Stream stream) => Load(stream);

    #region I/O Operations

    public List<FontEntry> AllEntries => Entries;

    /// <summary>
    /// Loads a .font file and parses its glyph table.
    /// </summary>

    public void Load(Stream stream) => ReaderFont(stream);
    public void Load(string filePath)
    {
        if (!File.Exists(filePath)) throw new FileNotFoundException("Source file not found.", filePath);
        using (FileStream fs = File.OpenRead(filePath))
        {
            ReaderFont(fs);
        }
    }

    private void ReaderFont(Stream stream)
    {
        using (BinaryReader reader = new BinaryReader(stream))
        {
            Entries.Clear();

            // V3 is Version 6.0
            if (reader.ReadUInt32() != FONT_MAGIC || reader.ReadUInt32() != FONT_VERSION) throw new InvalidDataException("Invalid .font header or unsupported version.");
            
            //reader.ReadUInt32();
            //reader.ReadUInt32();
            uint GlyphCount = reader.ReadUInt32();
            uint OffsetTable = reader.ReadUInt32();
            reader.ReadUInt32();
            reader.ReadUInt32();
            LetterSpacing = reader.ReadUInt32();

            reader.BaseStream.Seek(OffsetTable, SeekOrigin.Begin);

            for (int i = 0; i < GlyphCount; i++) Entries.Add(new FontEntry(reader));

        }
    }

    /// <summary>
    /// Saves the current glyph list to a .font file, rebuilding the mapping table.
    /// </summary>
    /// <param name="destPath">The destination path where the new .font file will be created.</param>
    public void Save(string destPath)
    {
        if (Entries.Count == 0) throw new InvalidOperationException("Cannot save an empty font list.");

        using (BinaryWriter writer = new BinaryWriter(File.Create(destPath)))
        {
            int glyphCount = Entries.Count;
            int mappingTableStart = 0x20;
            int entryChars = Entries.Max(f => (int)f.Char) + 1;
            int fontTableStart = (entryChars * 2) + mappingTableStart;

            writer.Write(FONT_MAGIC);
            writer.Write(FONT_VERSION);
            writer.Write(glyphCount);
            writer.Write(fontTableStart);
            writer.Write(entryChars);
            writer.Write(mappingTableStart);
            writer.Write(LetterSpacing);
            writer.Write(DEFAULT_UNK2);
            writer.Write(GenMappingTable());

            foreach (var entry in Entries) writer.Write(entry.CompileTo());

            long paddingNeeded = 16 - (writer.BaseStream.Length % 16);
            if (paddingNeeded > 0 && paddingNeeded < 16)
            {
                writer.Write(new byte[paddingNeeded]);
            }
        }
    }
    private byte[] GenMappingTable()
    {
        int maxChar = Entries.Max(f => f.Char);
        byte[] mappingTable = new byte[(maxChar + 1) * 2];

        for (int i = 0; i < mappingTable.Length; i += 2)
        {
            mappingTable[i] = 0xFF;
            mappingTable[i + 1] = 0xFF;
        }

        foreach (var entry in Entries)
        {
            int index = entry.Char * 2;
            short mapValue = (short)Entries.IndexOf(entry);
            byte[] entryValue = BitConverter.GetBytes(mapValue);

            if (BitConverter.IsLittleEndian)
            {
                mappingTable[index] = entryValue[0];
                mappingTable[index + 1] = entryValue[1];
            }
            else
            {
                mappingTable[index] = entryValue[1];
                mappingTable[index + 1] = entryValue[0];
            }
        }

        return mappingTable;
    }

    #endregion

    #region CRUD & Text Ops
    /// <summary>
    /// Adds a new glyph and keeps the list sorted by character code.
    /// </summary>
    /// <param name="newEntry">The FontEntry object representing the new glyph.</param>
    public void Add(FontEntry newEntry)
    {
        if (Entries.Any(e => e.Char == newEntry.Char)) return;
        Entries.Add(newEntry);
        Entries.Sort((a, b) => a.Char.CompareTo(b.Char));
    }
    /// <summary>
    /// Removes a specific character from the font.
    /// </summary>
    /// /// <param name="charToRemove">The character to be removed.</param>
    public void Remove(char charToRemove) => Entries.RemoveAll(e => e.Char == charToRemove);

    /// <summary>
    /// Adds a collection of glyphs to the font, handling duplicates and sorting.
    /// </summary>
    /// <param name="newEntries">An enumerable collection of FontEntry objects.</param>
    public void AddRange(IEnumerable<FontEntry> newEntries)
    {
        foreach (var entry in newEntries) Add(entry);
    }

    /// <summary>
    /// Removes multiple characters provided in a string.
    /// </summary>
    /// <param name="charsToRemove">A string containing all characters to be removed.</param>
    public void RemoveRange(string charsToRemove)
    {
        foreach (char c in charsToRemove) Remove(c);
    }

    /// <summary>
    /// Removes all characters starting from the first Japanese Hiragana (0x3041).
    /// </summary>
    public void RemoveAfterFirstJapaneseChar()
    {
        const int firstJapaneseCharCode = 0x3041;
        int index = Entries.FindIndex(e => (int)e.Char >= firstJapaneseCharCode);

        if (index != -1)
        {
            int countToRemove = Entries.Count - index;
            Entries.RemoveRange(index, countToRemove);
        }
    }

    /// <summary>
    /// Gets the total number of glyphs currently in the font manager.
    /// </summary>
    /// <returns>The count of font entries.</returns>
    public int GetFontCount() => Entries.Count;

    /// <summary>
    /// Exports all current font entries to a text file.
    /// </summary>
    /// <param name="filePath">The destination path for the .txt file.</param>
    public void ExportToTxt(string filePath)
    {
        var lines = Entries.Select(e => e.ToString());
        File.WriteAllLines(filePath, lines);
    }

    /// <summary>
    /// Loads glyph metadata from a text file and adds them to the current list.
    /// </summary>
    /// <param name="filePath">Path to the .txt file containing glyph data.</param>
    public void ImportFromTxt(string filePath)
    {
        if (!File.Exists(filePath)) throw new FileNotFoundException("TXT file not found: ", filePath);

        string[] lines = File.ReadAllLines(filePath);
        List<FontEntry> newEntries = new();

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;

            try
            {
                newEntries.Add(FontEntry.Parse(line));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Skip] Error processing line: {ex.Message}");
            }
        }
        AddRange(newEntries);
    }
    /// <summary>
    /// Prints all font entries and their metadata to the standard console output.
    /// Useful for debugging and verification.
    /// </summary>
    public void DumpToConsole()
    {
        Console.WriteLine($"--- Font Dump ({Entries.Count} chars) ---");
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
        Console.WriteLine("------------------------------------------");
    }
    #endregion

}

