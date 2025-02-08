using System;

namespace DesignPatterns.src.Behavioural.Strategy;

public class VideoStorage
{
    private ICompressor _compressor;
    private IOverlay _overlay;

    public VideoStorage(ICompressor compressor, IOverlay overlay)
    {
        _compressor = compressor;
        _overlay = overlay;
    }

    public void Store()
    {
        _compressor.Compress();
        _overlay.Filter();
    }
}
