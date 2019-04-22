using System;
using System.Runtime.InteropServices;

namespace Envision.DirectShow.MediaType
{
    /// <summary>
    /// Media SubTypes for DirectShow. 
    /// GUIDS taken from the uuids.h, ksuuids.h and wmcodecdsp.h files (Windows 10 SDK)    
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/audio-subtypes
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/dvd-media-types
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/mpeg-1-media-types
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/mpeg-2-media-types
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/stream-subtypes
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/vbi-media-types
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/video-subtypes
    /// </summary>
    [ComVisible(false)]
    public static class MediaSubType
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

        /// <summary>
        /// Advanced Audio Coding (AAC) audio in Audio Data Transport Stream (ADTS) format.
        /// The format block is a WAVEFORMATEX structure with wFormatTag equal to WAVE_FORMAT_MPEG_ADTS_AAC.
        /// The WAVEFORMATEX structure specifies the core AAC-LC sample rate and number of channels, prior to applying spectral band replication (SBR) or parametric stereo (PS) tools, if present.
        /// No additional data is required after the WAVEFORMATEX structure.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG_ADTS_AAC = new Guid(0x00001600, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// High-Efficiency Advanced Audio Coding (HE-AAC) stream.
        /// The format block is an HEAACWAVEFORMAT structure.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG_HEAAC = new Guid(0x00001610, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// MPEG-4 audio transport stream with a synchronization layer (LOAS) and a multiplex layer (LATM).
        /// The format block is a WAVEFORMATEX structure with wFormatTag equal to WAVE_FORMAT_MPEG_LOAS.
        /// The WAVEFORMATEX structure specifies the core AAC-LC sample rate and number of channels, prior to applying spectral SBR or PS tools, if present.
        /// No additional data is required after the WAVEFORMATEX structure.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG_LOAS = new Guid(0x00001602, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Raw AAC.
        /// The format block is a WAVEFORMATEX structure with wFormatTag equal to WAVE_FORMAT_RAW_AAC1.
        /// The WAVEFORMATEX structure specifies the sample rate and number of channels in the decoded audio after applying SBR and PS tools, if present.
        /// The WAVEFORMATEX structure is followed by additional bytes that contain the AudioSpecificConfig() data, as defined by ISO/IEC 14496-3 (MPEG-4 Audio). 
        /// The length of the AudioSpecificConfig() data is 2 bytes for AAC-LC or HE-AAC with implicit signaling of SBR/PS.
        /// It is more than 2 bytes for HE-AAC with explicit signaling of SBR/PS.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RAW_AAC1 = new Guid(0x000000FF, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        #endregion

        #region Dolby Audio Types

        /// <summary>
        /// Dolby Digital Plus audio.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DOLBY_DDPLUS = new Guid(0xa7fb87af, 0x2d02, 0x42fb, 0xa4, 0xd4, 0x5, 0xcd, 0x93, 0x84, 0x3b, 0xdd);

        /// <summary>
        /// Dolby Digital (AC-3) audio.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DOLBY_AC3 = new Guid(0xe06d802c, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);

        /// <summary>
        /// Dolby AC-3 over S/PDIF.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DOLBY_AC3_SPDIF = new Guid(0x00000092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// DVM AC-3 codec. Used when playing an AVI files with Dolby Digital audio.
        /// The format block is a WAVEFORMATEX structure with the format tag equal to WAVE_FORMAT_DVM.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DVM = new Guid(0x00002000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// To specify padded AC-3, use the subtype MEDIASUBTYPE_DOLBY_AC3_SPDIF, 
        /// which corresponds to a format tag of 0x0092 (WAVE_FORMAT_DOLBY_AC3_SPDIF). 
        /// The values 0x240 and 0x241 have also been used to indicate padded AC-3, 
        /// but Microsoft encourages the use of 0x0092.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RAW_SPORT = new Guid(0x00000240, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// To specify padded AC-3, use the subtype MEDIASUBTYPE_DOLBY_AC3_SPDIF, 
        /// which corresponds to a format tag of 0x0092 (WAVE_FORMAT_DOLBY_AC3_SPDIF). 
        /// The values 0x240 and 0x241 have also been used to indicate padded AC-3, 
        /// but Microsoft encourages the use of 0x0092.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_SPDIF_TAG_241h = new Guid(0x00000241, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        #endregion

        #region Miscellaneous Audio Types

        /// <summary>
        /// Audio with digital rights management (DRM) protection.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DRM_Audio = new Guid(0x00000009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Digital Theater Systems (DTS) audio.
        /// The format block is a WAVEFORMATEX structure with the format tag equal to WAVE_FORMAT_UNKNOWN.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DTS = new Guid(0xe06d8033, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);

        /// <summary>
        /// Digital Theater Systems (DTS) audio.
        /// The format block is a WAVEFORMATEX structure with the format tag equal to WAVE_FORMAT_DTS2.
        /// This subtype is equivalent to MEDIASUBTYPE_DTS but uses a different format tag.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DTS2 = new Guid(0x00002001, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// DVD audio data.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DVD_LPCM_AUDIO = new Guid(0xe06d8032, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);

        /// <summary>
        /// MPEG-1 audio payload.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG1AudioPayload = new Guid(0x00000050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);

        /// <summary>
        /// MPEG1 audio packet.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG1Packet = new Guid(0xe436eb80, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// MPEG1 audio Payload.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG1Payload = new Guid(0xe436eb81, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// MPEG-2 audio data.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG2_AUDIO = new Guid(0xe06d802b, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);

        #endregion

        #region DVD Media Types

        /// <summary>
        /// DVD Subpicture
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DVD_SUBPICTURE = new Guid(0xe06d802d, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);

        /// <summary>
        /// MPEG-2 video
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG2_VIDEO = new Guid(0xe06d8026, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea);

        /// <summary>
        /// Sony Dynamic Digital Sound (SDDS) audio
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_SDDS = new Guid(0xe06d8034, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);

        #endregion

        #region Line 21 Media Types

        /// <summary>
        /// Line 21 data as byte pairs
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Line21_BytePair = new Guid(0x6e8d4a22, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

        /// <summary>
        /// Lines 21 data in DVD GOP Packet
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Line21_GOPPacket = new Guid(0x6e8d4a23, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

        /// <summary>
        /// Line 21 data in raw VBI format
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Line21_VBIRawData = new Guid(0x6e8d4a24, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

        #endregion

        #region MPEG-1 Media Types

        /// <summary>
        /// MPEG-1 System Stream
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG1System = new Guid(0xe436eb84, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// MPEG-1 System Stream from Video CD
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG1VideoCD = new Guid(0xe436eb85, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// MPEG-1 Native Video Stream
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG1Video = new Guid(0xe436eb86, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// MPEG-1 Native Audio Stream
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG1Audio = new Guid(0xe436eb87, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        #endregion

        #region MPEG-2 Media Type

        /// <summary>
        /// Program Stream
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG2_PROGRAM = new Guid(0xe06d8022, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);

        /// <summary>
        /// Transport stream (TS), with 188-byte packets
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG2_TRANSPORT = new Guid(0xe06d8023, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);

        /// <summary>
        /// Transport stream with "strided" packets. This subtype indicates that the TS packets may be padded with extra bytes. 
        /// For more information, see MPEG2_TRANSPORT_STRIDE.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG2_TRANSPORT_STRIDE = new Guid(0x138aa9a4, 0x1ee2, 0x4c5b, 0x98, 0x8e, 0x19, 0xab, 0xfd, 0xbc, 0x8a, 0x11);

        /// <summary>
        /// ATSC Service Information.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ATSC_SI = new Guid(0xb3c7397c, 0xd303, 0x414d, 0xb3, 0x3c, 0x4e, 0xd2, 0xc9, 0xd2, 0x97, 0x33);

        /// <summary>
        /// DVB Service Information.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DVB_SI = new Guid(0xe9dd31a3, 0x221d, 0x4adb, 0x85, 0x32, 0x9a, 0xf3, 0x9, 0xc1, 0xa4, 0x8);

        /// <summary>
        ///  Integrated Services Digital Broadcasting (ISDB) Service Information.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ISDB_SI = new Guid(0xe89ad298, 0x3601, 0x4b06, 0xaa, 0xec, 0x9d, 0xde, 0xed, 0xcc, 0x5b, 0xd0);

        /// <summary>
        /// MPEG-2 section data
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MPEG2DATA = new Guid(0xc892e55b, 0x252d, 0x42b5, 0xa3, 0x16, 0xd9, 0x97, 0xe7, 0xa5, 0xd9, 0x95);

        #endregion

        #region Stream Media Types

        /// <summary>
        /// Data from AIFF file
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AIFF = new Guid(0xe436eb8d, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// Advanced Systems Format (ASF)
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Asf = new Guid(0x3db80f90, 0x9412, 0x11d1, 0xad, 0xed, 0x0, 0x0, 0xf8, 0x75, 0x4b, 0x99);

        /// <summary>
        /// Data from AVI file
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Avi = new Guid(0xe436eb88, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// Data from AU file
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AU = new Guid(0xe436eb8c, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// Dss Audio
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DssAudio = new Guid(0xa0af4f82, 0xe163, 0x11d0, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

        /// <summary>
        /// Dss Video
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_DssVideo = new Guid(0xa0af4f81, 0xe163, 0x11d0, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

        /// <summary>
        /// MPEG-1 System Stream
        /// </summary>
        [Obsolete("Media Sub Type is obsolete.", true)]
        public static readonly Guid MEDIASUBTYPE_MPEG1SystemStream = new Guid(0xe436eb82, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// Data from WAV file
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_WAVE = new Guid(0xe436eb8b, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        #endregion

        #region VBI Media Types

        /// <summary>
        /// Teletext data
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_TELETEXT = new Guid(0xf72a76e3, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

        /// <summary>
        /// Video Programming System (VPS) data.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_VPS = new Guid(0xa1b3f620, 0x9792, 0x4d8d, 0x81, 0xa4, 0x86, 0xaf, 0x25, 0x77, 0x20, 0x90);

        /// <summary>
        /// Wide Screen Signaling (WSS) data.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_WSS = new Guid(0x2791D576, 0x8E7A, 0x466F, 0x9E, 0x90, 0x5D, 0x3F, 0x30, 0x83, 0x73, 0x8B);

        #endregion

        #region Video Media Types
        
        /// <summary>
        /// (M) NTSC
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_NTSC_M = new Guid(0x482dde2, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (B) PAL
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_B = new Guid(0x482dde5, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);
        
        /// <summary>
        /// (D) PAL
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_D = new Guid(0x482dde6, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);
        
        /// <summary>
        /// (G) PAL
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_G = new Guid(0x482dde7, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (H) PAL
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_H = new Guid(0x482dde8, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (I) PAL
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_I = new Guid(0x482dde9, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (M) PAL
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_M = new Guid(0x482ddea, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (N) PAL
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_N = new Guid(0x482ddeb, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (B) SECAM
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_B = new Guid(0x482ddf0, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (D) SECAM
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_D = new Guid(0x482ddf1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (G) SECAM
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_G = new Guid(0x482ddf2, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (H) SECAM
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_H = new Guid(0x482ddf3, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (K) SECAM
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_K = new Guid(0x482ddf4, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (K1) SECAM
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_K1 = new Guid(0x482ddf5, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// (L) SECAM
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_L = new Guid(0x482ddf6, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

        /// <summary>
        /// AI44 and IA44 are surfaces with a bits-per-pixel value of 8. There are 4 bits of I and 4 bits of A. 
        /// I represents an index into a 16-entry YUV palette. 
        /// A represents 4 bits of transparency information (also known as per-pixel-alpha). 
        /// Therefore, AI44 and IA44 surfaces allow for 16 different colors at 16 different transparency values, or 256 different pixel representations. 
        /// With AI44 the alpha is stored in the hi-nibble, in IA44 the alpha is stored in the lo-nibble. 
        /// Both formats are very useful for DVD sub-picture images and Line21 and Teletext images. 
        /// Microsoft prefers the AI44 version because it is slightly easier to generate text using this format.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AI44 = new Guid(0x34344941, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// AI44 and IA44 are surfaces with a bits-per-pixel value of 8. There are 4 bits of I and 4 bits of A. 
        /// I represents an index into a 16-entry YUV palette. 
        /// A represents 4 bits of transparency information (also known as per-pixel-alpha). 
        /// Therefore, AI44 and IA44 surfaces allow for 16 different colors at 16 different transparency values, or 256 different pixel representations. 
        /// With AI44 the alpha is stored in the hi-nibble, in IA44 the alpha is stored in the lo-nibble. 
        /// Both formats are very useful for DVD sub-picture images and Line21 and Teletext images. 
        /// Microsoft prefers the AI44 version because it is slightly easier to generate text using this format.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_IA44 = new Guid(0x34344149, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// SD-DVCR (525-60 or 625-50)
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_dvsl = new Guid(0x6c737664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// SDL-DVCR (525-60 or 625-50)
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_dvsd = new Guid(0x64737664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// HD-DVCR (1125-60 or 1250-50)
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_dvhd = new Guid(0x64687664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// DVCPRO 25 (525-60 or 625-50).
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_dv25 = new Guid(0x35327664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// DVCPRO 50 (525-60 or 625-50)
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_dv50 = new Guid(0x30357664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// DVCPRO 100 (1080/60i, 1080/50i, or 720/60P)
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_dvh1 = new Guid(0x31687664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// H.264 bitstream without start codes.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AVC1 = new Guid(0x31435641, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x7);

        /// <summary>
        /// H.264 bitstream with start codes.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_H264 = new Guid(0x34363248, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Equivalent to MEDIASUBTYPE_H264, with a different FOURCC.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_h264 = new Guid(0x34363268, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Equivalent to MEDIASUBTYPE_H264, with a different FOURCC.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_X264 = new Guid(0x34363258, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Equivalent to MEDIASUBTYPE_H264, with a different FOURCC.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_x264 = new Guid(0x34363278, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// RGB, 1 bit per pixel(bpp), palettized
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB1 = new Guid(0xe436eb78, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// RGB, 4 bpp, palettized
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB4 = new Guid(0xe436eb79, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// RGB, 8 bpp, palettized
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB8 = new Guid(0xe436eb7a, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// RGB 555, 16 bpp
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB555 = new Guid(0xe436eb7c, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// RGB 565, 16 bpp
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB565 = new Guid(0xe436eb7b, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// RGB, 24 bpp
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB24 = new Guid(0xe436eb7d, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// RGB, 32 bpp
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB32 = new Guid(0xe436eb7e, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// RGB 555 with alpha channel
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ARGB1555 = new Guid(0x297c55af, 0xe209, 0x4cb3, 0xb7, 0x57, 0xc7, 0x6d, 0x6b, 0x9c, 0x88, 0xa8);

        /// <summary>
        /// RGB 32 with alpha channel
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ARGB32 = new Guid(0x773c9ac0, 0x3274, 0x11d0, 0xb7, 0x24, 0x0, 0xaa, 0x0, 0x6c, 0x1a, 0x1);

        /// <summary>
        /// 16-bit RGB with alpha channel; 4 bits per channel
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ARGB4444 = new Guid(0x6e6415e6, 0x5c24, 0x425f, 0x93, 0xcd, 0x80, 0x10, 0x2b, 0x3d, 0x1c, 0xca);

        /// <summary>
        /// 32-bit RGB with alpha channel; 10 bits per RGB channel plus 2 bits for alpha.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_A2R10G10B10 = new Guid(0x2f8bb76d, 0xb644, 0x4550, 0xac, 0xf3, 0xd3, 0x0c, 0xaa, 0x65, 0xd5, 0xc5);

        /// <summary>
        /// 32-bit RGB with alpha channel; 10 bits per RGB channel plus 2 bits for alpha.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_A2B10G10R10 = new Guid(0x576f7893, 0xbdf6, 0x48c4, 0x87, 0x5f, 0xae, 0x7b, 0x81, 0x83, 0x45, 0x67);

        /// <summary>
        /// 32-bit RGB render target.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB32_D3D_DX7_RT = new Guid(0x32335237, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// 16-bit RGB render target.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB16_D3D_DX7_RT = new Guid(0x36315237, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// 32-bit ARGB render target.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ARGB32_D3D_DX7_RT = new Guid(0x38384137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// ARGB4444 render target. For subpicture graphics.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ARGB4444_D3D_DX7_RT = new Guid(0x34344137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// ARGB1555 render target. For subpicture graphics.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ARGB1555_D3D_DX7_RT = new Guid(0x35314137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// 32-bit RGB render target.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB32_D3D_DX9_RT = new Guid(0x32335239, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// 16-bit RGB render target.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_RGB16_D3D_DX9_RT = new Guid(0x36315239, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// 32-bit ARGB render target.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ARGB32_D3D_DX9_RT = new Guid(0x38384139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// ARGB4444 render target. For subpicture graphics.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ARGB4444_D3D_DX9_RT = new Guid(0x34344139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// ARGB1555 render target. For subpicture graphics.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_ARGB1555_D3D_DX9_RT = new Guid(0x35314139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: AYUV, Sampling 4:4:4, Packed, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_AYUV = new Guid(0x56555941, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: YUY2, Sampling 4:2:2, Packed, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_YUY2 = new Guid(0x32595559, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: UYVY, Sampling 4:2:2, Packed, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_UYVY = new Guid(0x59565955, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: IMC1, Sampling 4:2:0, Planar, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_IMC1 = new Guid(0x31434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: IMC2, Sampling 4:2:0, Planar, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_IMC3 = new Guid(0x33434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: IMC3, Sampling 4:2:0, Planar, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_IMC2 = new Guid(0x32434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: IMC4, Sampling 4:2:0, Planar, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_IMC4 = new Guid(0x34434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: YV12, Sampling 4:2:0, Planar, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_YV12 = new Guid(0x32315659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: NV12, Sampling 4:2:0, Planar, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_NV12 = new Guid(0x3231564E, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: I420, Sampling 4:2:0, Planar, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_I420 = new Guid(0x30323449, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: IYUV, Sampling 4:2:0, Planar, Bits per Channel: 8        
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_IYUV = new Guid(0x56555949, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: Y411, Sampling 4:1:1, Packed, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Y411 = new Guid(0x31313459, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: Y41P, Sampling 4:1:1, Packed, Bits per Channel: 8       
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Y41P = new Guid(0x50313459, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: YVYU, Sampling 4:2:2, Packed, Bits per Channel: 8
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_YVYU = new Guid(0x55595659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: YVU9
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_YVU9 = new Guid(0x39555659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Format: Y211
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Y211 = new Guid(0x31313259, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// No longer supported.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_IF09 = new Guid(0x39304649, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// MJPG format produced by some cards. (FOURCC 'CFCC') 
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_CFCC = new Guid(0x43434643, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Cirrus Logic CLJR format. (FOURCC 'CLJR')
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_CLJR = new Guid(0x524a4c43, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        ///Cinepak UYVY format. (FOURCC 'CPLA')
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_CPLA = new Guid(0x414c5043, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// A YUV format supported by some Cirrus Logic drivers. (FOURCC 'CLPL')
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_CLPL = new Guid(0x4C504C43, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Intergraph JPEG format. (FOURCC 'IJPG')
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_IJPG = new Guid(0x47504A49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// A DV encoding format. (FOURCC 'MDVF')
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MDVF = new Guid(0x4656444D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Motion JPEG(MJPG) compressed video. (FOURCC 'MJPG')
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_MJPG = new Guid(0x47504A4D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Video delivered using hardware overlay.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Overlay = new Guid(0xe436eb7f, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// Plum MJPG format. (FOURCC 'Plum')
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_Plum = new Guid(0x6D756C50, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// QuickTime JPEG compressed data.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_QTJpeg = new Guid(0x6765706a, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Apple® QuickTime® compression.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_QTMovie = new Guid(0xe436eb89, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        /// <summary>
        /// QuickTime RLE compressed data. 
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_QTRle = new Guid(0x20656c72, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// QuickTime RPZA compressed data.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_QTRpza = new Guid(0x617a7072, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// QuickTime SMC compressed data.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_QTSmc = new Guid(0x20636d73, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// TrueVision MJPG format. (FOURCC 'TVMJ')
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_TVMJ = new Guid(0x4A4D5654, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Video port vertical blanking interval(VBI) data.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_VPVBI = new Guid(0x5a9b6a41, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

        /// <summary>
        /// Video port video data.
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_VPVideo = new Guid(0x5a9b6a40, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

        /// <summary>
        /// MJPG format produced by some cards. (FOURCC 'WAKE')
        /// </summary>
        public static readonly Guid MEDIASUBTYPE_WAKE = new Guid(0x454B4157, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);        

        #endregion
    }
}
