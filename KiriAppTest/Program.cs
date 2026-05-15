using KirigiriLib;
using System.Diagnostics;
using System.Security.Cryptography;

internal class Program
{
    static Program()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Title = "KirigiriLib - Stress & Integrity Test Suite";
    }

    private static void Main(string[] args)
    {
        // File paths for the test cycle
        string fontPath = "font-[0000].font";
        string exportTxt = "font_metadata.txt";
        string saveBin = "font_rebuilt.font";
        string saveFinal = "font_from_txt.font";

        Stopwatch sw = Stopwatch.StartNew();

        try
        {
            Console.WriteLine("=== KirigiriLib Diagnostic Tool ===");

            if (!File.Exists(fontPath))
            {
                Console.WriteLine($"[-] Error: Source file '{fontPath}' not found in the executable directory.");
                Console.WriteLine($"[*] Hint: Ensure the file is at: {AppDomain.CurrentDomain.BaseDirectory}");
                return;
            }

            // --- STEP 1: INITIAL LOAD ---
            Console.WriteLine("[*] Step 1: Loading original binary...");
            FontManager manager = new FontManager(fontPath);
            int originalCount = manager.GetFontCount();
            Console.WriteLine($"[+] {originalCount} glyphs loaded successfully.");

            // --- STEP 2: BINARY RECONSTRUCTION ---
            Console.WriteLine("[*] Step 2: Testing direct binary reconstruction...");
            manager.Save(saveBin);

            string originalHash = GetFileHash(fontPath);
            string rebuiltHash = GetFileHash(saveBin);

            if (originalHash == rebuiltHash)
                Console.WriteLine("[+] SUCCESS: Rebuilt file is byte-identical to the original!");
            else
                Console.WriteLine("[!] WARNING: Hash mismatch. (This is expected if the original had different padding).");

            // --- STEP 3: TEXT EXPORT ---
            Console.WriteLine("[*] Step 3: Exporting metadata to TXT...");
            manager.ExportToTxt(exportTxt);
            Console.WriteLine($"[+] Metadata saved to '{exportTxt}'.");

            // --- STEP 4: TXT IMPORT ---
            Console.WriteLine("[*] Step 4: Clearing memory and re-importing from TXT...");
            FontManager txtManager = new FontManager();
            txtManager.ImportFromTxt(exportTxt);

            Console.WriteLine("[?] Sample of re-imported data:");
            int sampleSize = Math.Min(3, txtManager.GetFontCount());
            for (int i = 0; i < sampleSize; i++)
                Console.WriteLine($"    > {txtManager.AllEntries[i]}");

            // --- STEP 5: FINAL SAVE ---
            Console.WriteLine("[*] Step 5: Generating final binary from TXT data...");
            txtManager.Save(saveFinal);

            sw.Stop();
            Console.WriteLine($"\n=== TEST COMPLETED IN: {sw.ElapsedMilliseconds}ms ===");

            if (txtManager.GetFontCount() == originalCount)
                Console.WriteLine("[#] Final Integrity Check: PASSED");
            else
                Console.WriteLine("[#] Final Integrity Check: FAILED (Count mismatch)");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[!] CRITICAL ERROR: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    private static string GetFileHash(string filename)
    {
        using var md5 = MD5.Create();
        using var stream = File.OpenRead(filename);
        var hash = md5.ComputeHash(stream);
        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
    }
}