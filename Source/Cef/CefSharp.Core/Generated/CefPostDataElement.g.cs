//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefSharp.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;
    using CefSharp.Core.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefPostDataElement : IDisposable
    {
        internal static CefPostDataElement FromNative(cef_post_data_element_t* ptr)
        {
            return new CefPostDataElement(ptr);
        }
        
        internal static CefPostDataElement FromNativeOrNull(cef_post_data_element_t* ptr)
        {
            if (ptr == null) return null;
            return new CefPostDataElement(ptr);
        }
        
        private cef_post_data_element_t* _self;
        private int _disposed = 0;
        
        private CefPostDataElement(cef_post_data_element_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
            CefObjectTracker.Track(this);
        }
        
        ~CefPostDataElement()
        {
            if (Interlocked.CompareExchange(ref _disposed, 1, 0) == 0)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (Interlocked.CompareExchange(ref _disposed, 1, 0) == 0)
            {
                Release();
                _self = null;
            }
            CefObjectTracker.Untrack(this);
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_post_data_element_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_post_data_element_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_post_data_element_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_post_data_element_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_post_data_element_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}