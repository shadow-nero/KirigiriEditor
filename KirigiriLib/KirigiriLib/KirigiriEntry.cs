using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace KirigiriLib.KiriEntry
{
    public class FontEntry
    {
        public char Char { get; set; }
        public short Xpos { get; set; }
        public short Ypos { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public sbyte AdvanceX { get; set; } // Padding - PSP ignores, PC might use
        public byte Unk1 {  get; set; }
        public sbyte MarginLeft { get; set; }
        public sbyte MarginRight { get; set; }
        public sbyte MarginVertical { get; set; }
        public byte Unk2 { get; set; } // Not used? Strange, the PSP defined it as 0x08 but it is never used

        public FontEntry(char character, short x, short y, short w, short h, sbyte advanceX, sbyte mLeft, sbyte mRight, sbyte mVert)
        {
            Char = character;
            Xpos = x;
            Ypos = y;
            Width = w;
            Height = h;
            AdvanceX = advanceX;
            MarginLeft = mLeft;
            MarginRight = mRight;
            MarginVertical = mVert;
            Unk1 = 0;
            Unk2 = 8; 
        }
        public FontEntry(BinaryReader reader)
        {
            Char = (char)reader.ReadUInt16();
            Xpos = reader.ReadInt16();
            Ypos = reader.ReadInt16();
            Width = reader.ReadInt16();
            Height = reader.ReadInt16();
            AdvanceX = reader.ReadSByte();
            Unk1 = reader.ReadByte();
            MarginLeft = reader.ReadSByte();
            MarginRight = reader.ReadSByte();
            MarginVertical = reader.ReadSByte();
            Unk2 = reader.ReadByte();
        }
        public byte[] CompileTo()
        {
            using var ms = new MemoryStream();
            using var writer = new BinaryWriter(ms);

            writer.Write((ushort)Char);
            writer.Write(Xpos);
            writer.Write(Ypos);
            writer.Write(Width);
            writer.Write(Height);
            writer.Write(AdvanceX);
            writer.Write(Unk1);
            writer.Write(MarginLeft);
            writer.Write(MarginRight);
            writer.Write(MarginVertical);
            writer.Write(Unk2);

            return ms.ToArray();
        }

        /// <summary>
        /// Converts a formatted line of text back into a FontEntry object.
        /// </summary>
        public static FontEntry Parse(string line)
        {
            var match = Regex.Match(line, @"0x([0-9A-Fa-f]+).*?X:\s*(-?\d+)\s+Y:\s*(-?\d+).*?W:\s*(\d+)\s+H:\s*(\d+).*?Adv:\s*(-?\d+).*?ML:\s*(-?\d+).*?MR:\s*(-?\d+).*?MV:\s*(-?\d+)");

            if (!match.Success) throw new FormatException($"The line is not in the expected format: {line}");

            char character = (char)Convert.ToInt32(match.Groups[1].Value, 16);
            short x = short.Parse(match.Groups[2].Value);
            short y = short.Parse(match.Groups[3].Value);
            short w = short.Parse(match.Groups[4].Value);
            short h = short.Parse(match.Groups[5].Value);
            sbyte adv = sbyte.Parse(match.Groups[6].Value);
            sbyte ml = sbyte.Parse(match.Groups[7].Value);
            sbyte mr = sbyte.Parse(match.Groups[8].Value);
            sbyte mv = sbyte.Parse(match.Groups[9].Value);

            return new FontEntry(character, x, y, w, h, adv, ml, mr, mv);
        }
        /// <summary>
        /// Updates all numerical values at once, except the character.
        /// </summary>
        public void Update(short x, short y, short w, short h, sbyte adv, sbyte ml, sbyte mr, sbyte mv)
        {
            this.Xpos = x;
            this.Ypos = y;
            this.Width = w;
            this.Height = h;
            this.AdvanceX = adv;
            this.MarginLeft = ml;
            this.MarginRight = mr;
            this.MarginVertical = mv;
        }
        public override string ToString() => $"Char: {Char} (0x{(int)Char:X4}) | X:{Xpos} Y:{Ypos} | W:{Width} H:{Height} | Adv:{AdvanceX} | ML:{MarginLeft} | MR:{MarginRight} | MV:{MarginVertical}";

    }
}

