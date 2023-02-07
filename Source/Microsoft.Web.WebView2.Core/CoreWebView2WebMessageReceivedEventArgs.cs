using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2WebMessageReceivedEventArgs : EventArgs
{
	internal ICoreWebView2WebMessageReceivedEventArgs _nativeICoreWebView2WebMessageReceivedEventArgsValue;

	internal object _rawNative;

	internal ICoreWebView2WebMessageReceivedEventArgs _nativeICoreWebView2WebMessageReceivedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2WebMessageReceivedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2WebMessageReceivedEventArgsValue = (ICoreWebView2WebMessageReceivedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2WebMessageReceivedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2WebMessageReceivedEventArgsValue = value;
		}
	}

	public string Source
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WebMessageReceivedEventArgs.Source;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	public string WebMessageAsJson
	{
		get
		{
			try
			{
				return _nativeICoreWebView2WebMessageReceivedEventArgs.WebMessageAsJson;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	internal CoreWebView2WebMessageReceivedEventArgs(object rawCoreWebView2WebMessageReceivedEventArgs)
	{
		_rawNative = rawCoreWebView2WebMessageReceivedEventArgs;
	}

	public string TryGetWebMessageAsString()
	{
		try
		{
			return _nativeICoreWebView2WebMessageReceivedEventArgs.TryGetWebMessageAsString();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
