using Envision.DirectShow.Structures;
using Envision.DirectShow.Support;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Envision.DirectShow.Interfaces
{
    /// <summary>
    /// This interface is exposed by all input and output pins.
    /// The filter graph manager uses this interface to connect pins and perform flushing operations.
    /// Applications can use this interface to query the pin for information.
    /// Applications should never call IPin methods that change a pin's state, such as Connect, Disconnect, BeginFlush, or EndFlush. 
    /// To connect pins, an application must use the methods in IGraphBuilder.
    /// </summary>
    [ComImport, SuppressUnmanagedCodeSecurity, Guid("56a86891-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPin
    {
        /// <summary>
        /// The BeginFlush method begins a flush operation.
        /// Applications should not call this method.
        /// This method is called by other filters, to flush data from the graph.
        /// </summary>
        /// <returns></returns>
        [PreserveSig] uint BeginFlush();

        /// <summary>
        /// The Connect method connects the pin to another pin.
        /// Applications should not call this method.
        /// Use IGraphBuilder methods instead. This method is called by the Filter Graph Manager to connect pins.
        /// </summary>
        /// <param name="pReceivePin">Pointer to the receiving pin's IPin interface.</param>
        /// <param name="pmt">Pointer to an AM_MEDIA_TYPE structure that specifies the media type for the connection. Can be NULL.</param>
        /// <returns>
        /// S_OK Success.
        /// VFW_E_ALREADY_CONNECTED The pin is already connected.
        /// VFW_E_NO_ACCEPTABLE_TYPES Cannot find an acceptable media type.
        /// VFW_E_NO_TRANSPORT Pins cannot agree on a transport, or there is no allocator for the connection.
        /// VFW_E_NOT_STOPPED The filter is active and the pin does not support dynamic reconnection.
        /// VFW_E_TYPE_NOT_ACCEPTED The specified media type is not acceptable.
        /// </returns>
        [PreserveSig] uint Connect([In] IntPtr pReceivePin, [In, MarshalAs(UnmanagedType.LPStruct)] AM_MEDIA_TYPE pmt);

        /// <summary>
        /// The ConnectedTo method retrieves a pointer to the connected pin, if any.
        /// </summary>
        /// <param name="ppPin">Receives a pointer to the IPin interface of the other pin. The caller must release the interface. This parameter cannot be NULL.</param>
        /// <returns>
        /// S_OK Success.
        /// E_POINTER NULL pointer argument.
        /// VFW_E_NOT_CONNECTED Pin is not connected.
        /// </returns>
        [PreserveSig] uint ConnectedTo([Out] IntPtr ppPin);

        /// <summary>
        /// The ConnectionMediaType method retrieves the media type for the current pin connection, if any.
        /// </summary>
        /// <param name="pmt">Pointer to an AM_MEDIA_TYPE structure that receives the media type.</param>
        /// <returns>
        /// S_OK Success.
        /// E_POINTER NULL pointer argument.
        /// VFW_E_NOT_CONNECTED Pin is not connected.
        /// </returns>
        [PreserveSig] uint ConnectionMediaType([Out, MarshalAs(UnmanagedType.LPStruct)] AM_MEDIA_TYPE pmt);

        /// <summary>
        /// The Disconnect method breaks the current pin connection.
        /// The Filter Graph Manager calls this method when it disconnects two filters. 
        /// Applications and filters should not call this method.
        /// Instead, call the IFilterGraph::Disconnect method on the Filter Graph Manager.
        /// </summary>
        /// <returns>
        /// S_FALSE The pin was not connected.
        /// S_OK Success.
        /// </returns>
        [PreserveSig] uint Disconnect();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [PreserveSig] uint EndFlush();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [PreserveSig] uint EndOfStream();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ppEnum"></param>
        /// <returns></returns>
        [PreserveSig] uint EnumMediaTypes([Out] out IntPtr ppEnum);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tStart"></param>
        /// <param name="tStop"></param>
        /// <param name="dRate"></param>
        /// <returns></returns>
        [PreserveSig] uint NewSegment([In] long tStart, [In] long tStop, [In] double dRate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmt"></param>
        /// <returns></returns>
        [PreserveSig] uint QueryAccept([In, MarshalAs(UnmanagedType.LPStruct)] AM_MEDIA_TYPE pmt);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPinDir"></param>
        /// <returns></returns>
        [PreserveSig] uint QueryDirection([Out] out PIN_DIRECTION pPinDir);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [PreserveSig] uint QueryId([Out, MarshalAs(UnmanagedType.LPWStr)] out string Id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apPin"></param>
        /// <param name="nPin"></param>
        /// <returns></returns>
        [PreserveSig] uint QueryInternalConnections([Out] IntPtr apPin, [In, Out] ref int nPin);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pInfo"></param>
        /// <returns></returns>
        [PreserveSig] uint QueryPinInfo([Out] out PIN_INFO pInfo);

        /// <summary>
        /// The ReceiveConnection method accepts a connection from another pin.
        /// Applications should not call this method.
        /// This method is called by other filters during the pin connection process.
        /// </summary>
        /// <param name="pConnector">Pointer to the connecting pin's IPin interface.</param>
        /// <param name="pmt">Pointer to an AM_MEDIA_TYPE structure that specifies the media type for the connection</param>
        /// <returns>Returns an HRESULT value. Possible values include the following.
        /// S_OK Success.
        /// E_POINTER NULL pointer argument.
        /// VFW_E_ALREADY_CONNECTED The pin is already connected.
        /// VFW_E_NOT_STOPPED Cannot connect while filter is active.
        /// VFW_E_TYPE_NOT_ACCEPTED The specified media type is not acceptable.
        /// </returns>
        [PreserveSig] uint ReceiveConnection([In] IntPtr pConnector, [In, MarshalAs(UnmanagedType.LPStruct] AM_MEDIA_TYPE pmt);
    }
}
