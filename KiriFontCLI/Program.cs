using KirigiriLib;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "KiriFontCLI - Spike Chunsoft Font Utility";
        Console.WriteLine("=== KiriFontCLI Utility ===");

        if (args.Length < 3)
        {
            ShowUsage();
            return;
        }

        string mode = args[0].ToLower();
        Stopwatch sw = Stopwatch.StartNew();

        try
        {
            switch (mode)
            {
                case "-e": 
                    ExportMode(args[1], args[2]);
                    break;

                case "-i": 
                    ImportMode(args[1], args[2]);
                    break;

                case "-u": 
                    if (args.Length < 4) { Console.WriteLine("[-] Error: Missing output path."); return; }
                    UpdateMode(args[1], args[2], args[3]);
                    break;

                default:
                    Console.WriteLine($"[-] Unknown Mode: {mode}");
                    ShowUsage();
                    break;
            }

            sw.Stop();
            Console.WriteLine($"\n[+] Operation completed in {sw.ElapsedMilliseconds}ms.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[!] ERROR: {ex.Message}");
        }
    }

    private static void ExportMode(string fontIn, string txtOut)
    {
        Console.WriteLine($"[*] Extracting {fontIn} to {txtOut}...");
        var manager = new FontManager(fontIn);
        manager.ExportToTxt(txtOut);
        Console.WriteLine("[+] Done!");
    }

    private static void ImportMode(string txtIn, string fontOut)
    {
        Console.WriteLine($"[*] Building {fontOut} from {txtIn}...");
        var manager = new FontManager();
        manager.ImportFromTxt(txtIn);
        manager.Save(fontOut);
        Console.WriteLine("[+] Done!");
    }

    private static void UpdateMode(string fontIn, string txtIn, string fontOut)
    {
        Console.WriteLine($"[*] Merging {fontIn} with {txtIn}...");
        var manager = new FontManager(fontIn);
        manager.ImportFromTxt(txtIn); 
        manager.Save(fontOut);
        Console.WriteLine($"[+] Saved merged font to {fontOut}");
    }

    private static void ShowUsage()
    {
        Console.WriteLine("\nUsage:");
        Console.WriteLine("  -e <input.font> <output.txt>          | Extract .font to .txt");
        Console.WriteLine("  -i <input.txt> <output.font>          | Build new .font from .txt");
        Console.WriteLine("  -u <base.font> <patch.txt> <out.font> | Update/Merge font with txt data");
        Console.WriteLine("\nExample:");
        Console.WriteLine("  KiriFontCLI -e font-[0000].font metadata.txt");
    }
}