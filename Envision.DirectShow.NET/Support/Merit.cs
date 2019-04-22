using System;
using System.Runtime.InteropServices;

namespace Envision.DirectShow.Support
{
    /// <summary>
    /// Merit values define the order in which the Filter Graph Manager tries to add filters during graph building.
    /// https://docs.microsoft.com/en-us/windows/desktop/directshow/merit
    /// </summary>
    [Flags]
    [ComVisible(false)]
    public enum Merit
    {
        NONE = 0x0,
        MERIT_PREFERRED = 0x800000,
        MERIT_NORMAL = 0x600000,
        MERIT_UNLIKELY = 0x400000,
        MERIT_DO_NOT_USE = 0x200000,
        MERIT_SW_COMPRESSOR = 0x100000,
        MERIT_HW_COMPRESSOR = 0x100050
    }
}
