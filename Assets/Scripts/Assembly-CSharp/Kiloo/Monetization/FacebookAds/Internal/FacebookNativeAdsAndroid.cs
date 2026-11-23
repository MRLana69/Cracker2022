using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Monetization.FacebookAds.Internal;

public class FacebookNativeAdsAndroid : MonoBehaviour, IFacebookNativeAdsBridge
{
	private bool _bridgeInstantiated;

	private bool _adReady;

	private FBNativeDownloader _fbNativeDownloader;

	private NativeInterstitialAdObject _currentAdObject;

	private const string CALL_SOURCE = "FacebookNativeAdBridgeAndroid";

	private AndroidJavaObject _androidBridge;

	private AndroidJavaObject _workAroundBridge;

	private const string CALLBACK_RECEIVER_NAME = "FacebookAdAndroidReceiver";

	private Action<string> m_onInitialize;

	private Action<string> m_onNativeDidLoad;

	private Action<string> m_onNativeAdError;

	private Action<string> m_onNativeClicked;

	private Action<string> m_onNativeLoggingImpression;

	public event Action<string> onInitialize
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_onInitialize;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_onInitialize;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<string> onNativeDidLoad
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 36;
			Delegate obj2 = this.m_onNativeDidLoad;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 36;
			Delegate obj2 = this.m_onNativeDidLoad;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<string> onNativeAdError
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
			Delegate obj2 = this.m_onNativeAdError;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
			Delegate obj2 = this.m_onNativeAdError;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<string> onNativeClicked
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 44;
			Delegate obj2 = this.m_onNativeClicked;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 44;
			Delegate obj2 = this.m_onNativeClicked;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<string> onNativeLoggingImpression
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_onNativeLoggingImpression;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_onNativeLoggingImpression;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private bool IsBridgeInstantiated()
	{
		if (~(_bridgeInstantiated ? 1u : 0u) != 0)
		{
			_callback_onNativeAdError("FB Ad bridge not initialized");
		}
		return _bridgeInstantiated;
	}

	public void InitializeNative(string placementID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (~(_bridgeInstantiated ? 1u : 0u) == 0)
		{
			return;
		}
		AndroidJavaClass androidJavaClass = default;
		androidJavaClass._002Ector("com.kiloo.facebookadsbridge.FacebookAdsNativeBridge");
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				AndroidJavaObject androidBridge = default;
				_androidBridge = androidBridge;
				goto IL_0191;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0191;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj8 = default;
			obj6 = obj8;
		}
		_ = 0;
		object obj9 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		return;
		IL_0191:
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public bool IsNativeAdLoaded()
	{
		bool flag = IsBridgeInstantiated();
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S4_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
			object obj = default;
			bool flag3 = obj == null;
			result = false;
			if (!flag3)
			{
				bool adReady = _adReady;
				result = adReady;
			}
		}
		return result;
	}

	public void LoadNativeAd()
	{
		if (IsBridgeInstantiated() && !_adReady)
		{
			object[] args = Array.Empty<object>();
			_androidBridge.Call("LoadAd", args);
		}
	}

	public void DisposeNativeAd()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		_adReady = false;
		if (_currentAdObject != null)
		{
			_currentAdObject.Dispose();
			object obj = this + 20;
			obj = 0;
		}
	}

	public void LogExternalImpression()
	{
		if (_workAroundBridge != null)
		{
			object[] args = Array.Empty<object>();
			_workAroundBridge.Call("logExternalImpression", args);
		}
	}

	public void LogExternalClick()
	{
		if (_workAroundBridge != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
	}

	public NativeInterstitialAdObject GetNativeAdAssets()
	{
		if (IsNativeAdLoaded())
		{
			return _currentAdObject;
		}
		return null;
	}

	public void AddTestDevice(string deviceID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void SetDebugLogs(bool enableLogs)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	private void _callback_onNativeAdInitialise(string message)
	{
		//IL_0081: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		AndroidJavaObject workAroundBridge = default;
		_workAroundBridge = workAroundBridge;
		if (_workAroundBridge != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		if (this.m_onInitialize != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S3_v5 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ S3_v6+4] (should have been resolved before IL gen)");
		}
	}

	private void _callback_onNativeAdDidLoad(string placementID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S4_v7 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string iconImageURL = default;
		string coverImageURL = default;
		_fbNativeDownloader.DownloadImages(iconImageURL, coverImageURL);
	}

	private void _callback_onNativeAdError(string error)
	{
		//IL_0021: Expected Obj, but got I
		if (this.m_onNativeAdError != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void _callback_onNativeAdClicked(string placementID)
	{
		//IL_0021: Expected Obj, but got I
		if (this.m_onNativeClicked != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void _callback_onNativeLoggingImpression(string placementID)
	{
		//IL_0021: Expected Obj, but got I
		if (this.m_onNativeLoggingImpression != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void _callback_onImagesDownloaded(Texture2D iconImage, Texture2D coverImage)
	{
		//IL_01dd: Expected Obj, but got I
		Action<string> action;
		if ((bool)iconImage && (bool)coverImage)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S4_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num3 = 0;
			nint num4 = 0;
			IntPtr intPtr2 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ S4_v8 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num5 = 0;
			nint num6 = 0;
			IntPtr intPtr3 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ S4_v12 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num7 = 0;
			nint num8 = 0;
			IntPtr intPtr4 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ S4_v16 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num9 = 0;
			nint num10 = 0;
			IntPtr intPtr5 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ S4_v20 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num11 = 0;
			nint num12 = 0;
			IntPtr intPtr6 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v255 @ S4_v24 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num13 = 0;
			nint num14 = 0;
			IntPtr intPtr7 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v278 @ S4_v28 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
			NativeInterstitialAdObject nativeInterstitialAdObject = default;
			string title = default;
			string subtitle = default;
			string body = default;
			string socialContext = default;
			string callToActionText = default;
			string iconImageURL = default;
			string coverImageURL = default;
			nativeInterstitialAdObject._002Ector(title, subtitle, body, socialContext, callToActionText, iconImageURL, coverImageURL, iconImage, coverImage);
			_currentAdObject = nativeInterstitialAdObject;
			_adReady = true;
			action = this.m_onNativeDidLoad;
		}
		else
		{
			action = this.m_onNativeAdError;
		}
		if (action != null)
		{
			nint num15 = 0;
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S3_v4 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}

	public static FacebookNativeAdsAndroid CreatePlugin()
	{
		GameObject gameObject = default;
		gameObject._002Ector("FacebookAdAndroidReceiver");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		return gameObject.AddComponent<FacebookNativeAdsAndroid>();
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "FacebookNativeAdsAndroid: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
