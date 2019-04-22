using System;
using System.Runtime.InteropServices;

namespace Envision.DirectShow.Support
{
    /// <summary>
    /// The following globally unique identifiers (GUIDs) define different time formats.
    /// GUIDS taken from the uuids.h file (Windows 10 SDK)
    /// </summary>
    [ComVisible(false)]
    public static class TimeFormat
    {
        /// <summary>
        /// No format.
        /// </summary>
        public static readonly Guid TIME_FORMAT_NONE = Guid.Empty;

        /// <summary>
        /// Video frames.
        /// </summary>
        public static readonly Guid TIME_FORMAT_FRAME = new Guid(0x7b785570, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);

        /// <summary>
        /// Samples in the stream.
        /// </summary>
        public static readonly Guid TIME_FORMAT_SAMPLE = new Guid(0x7b785572, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);

        /// <summary>
        /// Interlaced video fields.
        /// </summary>
        public static readonly Guid TIME_FORMAT_FIELD = new Guid(0x7b785573, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);

        /// <summary>
        /// Byte offset within the stream.
        /// </summary>
        public static readonly Guid TIME_FORMAT_BYTE = new Guid(0x7b785571, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);

        /// <summary>
        /// Reference time (100-nanosecond units).
        /// </summary>
        public static readonly Guid TIME_FORMAT_MEDIA_TIME = new Guid(0x7b785574, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);        
    }
}