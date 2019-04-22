using System;
using System.Runtime.InteropServices;

namespace Envision.DirectShow.Support
{
    /// <summary>
    /// The following GUIDs are used for event tracing in DirectShow.
    /// GUIDS taken from the perfstruct.h file (Windows 10 SDK)
    /// </summary>
    [ComVisible(false)]
    public static class TraceEvent
    {
        /// <summary>
        /// Audio break event. Events of this type use the PERFINFO_DSHOW_AUDIOBREAK structure for event data.
        /// </summary>
        public static readonly Guid GUID_AUDIOBREAK = new Guid(0x56d29065, 0xefbe, 0x42dc, 0x8c, 0x29, 0xe3, 0x25, 0xdc, 0x9c, 0x27, 0xd5);

        /// <summary>
        /// DirectShow event provider.
        /// </summary>
        public static readonly Guid GUID_DSHOW_CTL = new Guid(0x28cf047a, 0x2437, 0x4b24, 0xb6, 0x53, 0xb9, 0x44, 0x6a, 0x41, 0x9a, 0x69);

        /// <summary>
        /// General streaming event. Events of this type use the PERFINFO_DSHOW_STREAMTRACE structure for event data.
        /// </summary>
        public static readonly Guid GUID_STREAMTRACE = new Guid(0x3d7e7d93, 0x2fc8, 0x4a07, 0xa7, 0x19, 0xe0, 0x92, 0x2f, 0xf2, 0x89, 0x9e);

        /// <summary>
        /// Video rendering event. Events of this type use the PERFINFO_DSHOW_AVREND structure for event data.
        /// </summary>
        public static readonly Guid GUID_VIDEOREND = new Guid(0xd0da7ad6, 0xae80, 0x4de5, 0xaa, 0xfc, 0xc1, 0x26, 0x71, 0x1e, 0x75, 0x93);        
    }
}
