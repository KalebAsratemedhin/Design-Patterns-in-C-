using System;

namespace DesignPatterns.src.Behavioural.Strategy;

public class MkvCompressor : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Compressing video using mkv.");
    }
}
