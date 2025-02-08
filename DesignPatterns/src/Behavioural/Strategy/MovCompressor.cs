using System;

namespace DesignPatterns.src.Behavioural.Strategy;

public class MovCompressor: ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Compressing video using mov.");

    }


}
