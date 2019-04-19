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
        /// The length of the AudioSpecificConfig() data is 2 bytes for AAC-LC or HE-AAC with implicit signaling of SBR/PS.It is more than 2 bytes for HE-AAC with explicit signaling of SBR/PS.
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



        #endregion
    }
}
