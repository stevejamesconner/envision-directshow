using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Envision.DirectShow.Interfaces
{
    
    [ComImport, SuppressUnmanagedCodeSecurity, Guid("56a868fd-0ad4-11ce-b0a3-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAMFilterGraphCallback
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPin"></param>
        /// <returns></returns>
        [PreserveSig] uint UnableToRender([In] IntPtr pPin);
    }
}
