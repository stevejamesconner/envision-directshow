using System;
using System.Runtime.InteropServices;

namespace Envision.DirectShow.MediaTypes
{
    /// <summary>
    /// Major Media Types for DirectShow. 
    /// GUIDS taken from the uuids.h and ksuuids.h files (Windows 10 SDK)
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/media-types
    /// </summary>
    [ComVisible(false)]
    public static class MediaType
    {
        /// <summary>
        /// Analog Audio
        /// </summary>
        public static readonly Guid MEDIATYPE_AnalogAudio = new Guid(0x482dee1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// Analog Video
        /// </summary>
        public static readonly Guid MEDIATYPE_AnalogVideo = new Guid(0x482dde1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// Audio. See Audio Subtypes.
        /// </summary>
        public static readonly Guid MEDIATYPE_Audio = new Guid(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Line 21 data. Used by closed captions. See Line 21 Media Types. 
        /// </summary>
        public static readonly Guid MEDIATYPE_AUXLine21Data = new Guid(0x670aea80, 0x3a82, 0x11d0, 0xb7, 0x9b, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

        /// <summary>
        /// File. (Obsolete) 
        /// </summary>
        [Obsolete("Media type is obsolete")]
        public static readonly Guid MEDIATYPE_File = new Guid(0x656c6966, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Interleaved audio and video. Used for Digital Video (DV).
        /// </summary>
        public static readonly Guid MEDIATYPE_Interleaved = new Guid(0x73766169, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Obsolete. Do not use.
        /// </summary>
        [Obsolete("Media type is obsolete.", true)] 
        public static readonly Guid MEDIATYPE_LMRT = new Guid(0x74726c6d, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// MIDI format.
        /// </summary>
        public static readonly Guid MEDIATYPE_Midi = new Guid(0x7364696D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// MPEG-2 PES packets. See MPEG-2 Media Types.
        /// </summary>
        public static readonly Guid MEDIATYPE_MPEG2_PES = new Guid(0xe06d8020, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea);

        /// <summary>
        /// MPEG-2 section data. See MPEG-2 Media Types.
        /// </summary>
        public static readonly Guid MEDIATYPE_MPEG2_SECTIONS = new Guid(0x455f176c, 0x4b06, 0x47ce, 0x9a, 0xef, 0x8c, 0xae, 0xf7, 0x3d, 0xf7, 0xb5);

        /// <summary>
        /// Data is a script command, used by closed captions.
        /// </summary>
        public static readonly Guid MEDIATYPE_ScriptCommand = new Guid(0x73636d64, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Byte stream with no time stamps. See Stream Subtypes.
        /// </summary>
        public static readonly Guid MEDIATYPE_Stream = new Guid(0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// Text.
        /// </summary>
        public static readonly Guid MEDIATYPE_Text = new Guid(0x73747874, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Timecode data. Note: DirectShow does not provide any filters that support this media type.
        /// </summary>
        public static readonly Guid MEDIATYPE_Timecode = new Guid(0x482dee3, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// Obsolete. Do not use.        
        /// </summary>
        [Obsolete("Media type is obsolete.", true)]
        public static readonly Guid MEDIATYPE_URL_STREAM = new Guid(0x736c7275, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Vertical blanking interval (VBI) data (for television). Same as KSDATAFORMAT_TYPE_VBI.
        /// </summary>
        public static readonly Guid MEDIATYPE_VBI = new Guid(0xf72a76e1, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

        /// <summary>
        /// Video. See Video Subtypes.
        /// </summary>
        public static readonly Guid MEDIATYPE_Video = new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
    }
}