using System;
using System.Runtime.InteropServices;

namespace Envision.DirectShow.Structures
{
    /// <summary>
    /// The AM_MEDIA_TYPE structure describes the format of a media sample.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [ComVisible(false)]
    public struct AM_MEDIA_TYPE
    {
        public Guid majorType;
        public Guid subtype;
        [MarshalAs(UnmanagedType.Bool)] public bool bFixedSizeSamples;
        [MarshalAs(UnmanagedType.Bool)] public bool bTemporalCompression;
        public uint lSampleSize;
        public Guid formattype;
        public IntPtr pUnk;
        public uint cbFormat;
        public IntPtr pbFormat;
    }
}
