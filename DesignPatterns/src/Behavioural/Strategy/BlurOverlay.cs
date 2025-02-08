using System;

namespace DesignPatterns.src.Behavioural.Strategy;

public class BlurOverlay : IOverlay
{
    public void Filter()
    {
        Console.WriteLine("Filtering video using blur.");
    }
}
