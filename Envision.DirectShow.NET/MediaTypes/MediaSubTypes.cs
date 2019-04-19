using System;
using System.Runtime.InteropServices;

namespace Envision.DirectShow.MediaTypes
{
    /// <summary>
    /// Media SubTypes for DirectShow. 
    /// GUIDS taken from the uuids.h and ksuuids.h files (Windows 10 SDK)
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/media-types
    /// </summary>
    [ComVisible(false)]
    public static class MediaSubTypes
    {
        public static readonly Guid MEDIASUBTYPE_None = Guid.Empty;

        #region Uncompressed Audio Types

        /// <summary>
        /// IEEE floating-point audio.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_IEEE_FLOAT = new Guid(0x00000003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// PCM audio.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_PCM = new Guid(0x00000001, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);

        #endregion

        #region MPEG-4 and AAC Audio Types



        #endregion
    }
}
