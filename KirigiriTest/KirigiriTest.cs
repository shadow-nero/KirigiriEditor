using KirigiriLib;
using KirigiriLib.KiriEntry;
using System.IO;
using Xunit;

namespace KirigiriLib.Tests;

public class FontManagerTests
{
    [Fact]
    public void Add_ShouldKeepEntriesSorted()
    {
        var manager = new FontManager();
        var entryB = new FontEntry('B', 0, 0, 10, 10, 0, 0, 0, 0);
        var entryA = new FontEntry('A', 0, 0, 10, 10, 0, 0, 0, 0);

        manager.Add(entryB);
        manager.Add(entryA);

        Assert.Equal('A', manager.AllEntries[0].Char);
        Assert.Equal('B', manager.AllEntries[1].Char);
    }

    [Fact]
    public void Parse_ShouldCorrectlyReadFormattedLine()
    {
        string line = "Char: A (0x0041) | X:10 Y:20 | W:5 H:5 | Adv:0 | ML:1 | MR:1 | MV:2";

        var entry = FontEntry.Parse(line);

        Assert.Equal('A', entry.Char);
        Assert.Equal(10, entry.Xpos);
        Assert.Equal(1, entry.MarginLeft);
        Assert.Equal(2, entry.MarginVertical);
    }

    [Fact]
    public void CompileTo_ShouldProduceCorrectByteArray()
    {
        var entry = new FontEntry('A', 10, 20, 30, 40, 5, 1, 2, 3);
        byte[] data = entry.CompileTo();

        Assert.Equal(16, data.Length);
        Assert.Equal(0x41, data[0]);
        Assert.Equal(0x00, data[1]);
    }

    [Fact]
    public void Save_EmptyList_ShouldThrowException()
    {
        var manager = new FontManager();
        Assert.Throws<InvalidOperationException>(() => manager.Save("dummy.font"));
    }
}