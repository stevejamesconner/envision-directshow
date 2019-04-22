using Envision.DirectShow.Interfaces;
using Envision.DirectShow.Support;
using System.Runtime.InteropServices;

namespace Envision.DirectShow.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    [ComVisible(false)]
    public struct PIN_INFO
    {
        [MarshalAs(UnmanagedType.Interface)] public IBaseFilter pFilter;
        public PIN_DIRECTION dir;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.MAX_PIN_NAME)] public string achName;
    }
}
