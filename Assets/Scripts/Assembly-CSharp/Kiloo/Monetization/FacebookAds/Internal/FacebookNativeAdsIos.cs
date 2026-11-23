using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Monetization.FacebookAds.Internal;

public class FacebookNativeAdsIos : MonoBehaviour, IFacebookNativeAdsBridge
{
	internal delegate void FBNativeAdBridgeExternalCallback(int uniqueId);

	internal delegate void FBNativeAdBridgeErrorExternalCallback(int uniqueId, string error);

	private bool _bridgeInstantiated;

	private bool _adReady;

	private FBNativeDownloader _fbNativeDownloader;

	private NativeInterstitialAdObject _currentAdObject;

	private int _uniqueID;

	private string _callSource = "FacebookNativeAdBridgeIOS";

	private bool _adObjectUsed = true;

	private string _lastPlacementID = string.Empty;

	private static FacebookNativeAdsIos _instance;

	private const string CALLBACK_RECEIVER_NAME = "FacebookIOSReceiver";

	private static FBNativeAdBridgeExternalCallback _003C_003Ef__mg_0024cache0;

	private static FBNativeAdBridgeExternalCallback _003C_003Ef__mg_0024cache1;

	private static FBNativeAdBridgeExternalCallback _003C_003Ef__mg_0024cache2;

	private static FBNativeAdBridgeErrorExternalCallback _003C_003Ef__mg_0024cache3;

	private static FBNativeAdBridgeExternalCallback _003C_003Ef__mg_0024cache4;

	private Action<string> m_onInitialize;

	private Action<string> m_onNativeDidLoad;

	private Action<string> m_onNativeAdError;

	private Action<string> m_onNativeClicked;

	private Action<string> m_onNativeLoggingImpression;

	private bool IsBridgeInstantiated => _bridgeInstantiated;

	public event Action<string> onInitialize
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
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
			object obj = this + 40;
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
			object obj = this + 44;
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
			object obj = this + 44;
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
			object obj = this + 48;
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
			object obj = this + 48;
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
			object obj = this + 52;
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
			object obj = this + 52;
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
			object obj = this + 56;
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
			object obj = this + 56;
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

	public unsafe void InitializeNative(string placementID)
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I
		if (_bridgeInstantiated)
		{
			return;
		}
		object obj;
		if (placementID != null)
		{
			obj = 0;
			if (placementID._stringLength != 0)
			{
				goto IL_01a4;
			}
		}
		obj = 1;
		goto IL_01a4;
		IL_01a4:
		if (obj == null)
		{
			_uniqueID = 0;
			FBNativeAdBridgeExternalCallback fBNativeAdBridgeExternalCallback = default;
			fBNativeAdBridgeExternalCallback._002Ector(null, (nint)(delegate*<int, void>)(&_callback_onNativeAdDidLoad));
			FBNativeAdBridgeExternalCallback fBNativeAdBridgeExternalCallback2 = default;
			fBNativeAdBridgeExternalCallback2._002Ector(null, (nint)(delegate*<int, void>)(&_callback_onImpression));
			FBNativeAdBridgeExternalCallback fBNativeAdBridgeExternalCallback3 = default;
			fBNativeAdBridgeExternalCallback3._002Ector(null, (nint)(delegate*<int, void>)(&_callback_onClick));
			FBNativeAdBridgeErrorExternalCallback fBNativeAdBridgeErrorExternalCallback = default;
			fBNativeAdBridgeErrorExternalCallback._002Ector(null, (nint)(delegate*<int, string, void>)(&_callback_onNativeAdError));
			FBNativeAdBridgeExternalCallback fBNativeAdBridgeExternalCallback4 = default;
			fBNativeAdBridgeExternalCallback4._002Ector(null, (nint)(delegate*<int, void>)(&_callback_onFinishedClick));
			if (_fbNativeDownloader == null)
			{
				FBNativeDownloader instance = FBNativeDownloader.instance;
				_fbNativeDownloader = instance;
				FBNativeDownloader.DidDownload didDownload = default;
				didDownload._002Ector(this, (nint)__ldftn(FacebookNativeAdsIos._callback_onImagesDownloaded));
				_fbNativeDownloader.onDownloaded += didDownload;
			}
			_lastPlacementID = placementID;
			_adObjectUsed = false;
			_bridgeInstantiated = true;
			if (this.m_onInitialize != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S3_v9 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ S3_v10+4] (should have been resolved before IL gen)");
			}
		}
	}

	private void ReInitializeNative()
	{
		if (~(_bridgeInstantiated ? 1u : 0u) == 0)
		{
			DisposeNativeAd();
			_bridgeInstantiated = false;
		}
		InitializeNative(_lastPlacementID);
	}

	public void DisposeNativeAd()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		if (_currentAdObject != null)
		{
			_currentAdObject.Dispose();
			object obj = this + 20;
			obj = 0;
		}
		_adReady = false;
	}

	public bool IsNativeAdLoaded()
	{
		return false;
	}

	public void LoadNativeAd()
	{
		if (~(_adObjectUsed ? 1u : 0u) == 0)
		{
			ReInitializeNative();
		}
		if (~(_bridgeInstantiated ? 1u : 0u) == 0 && !_adReady)
		{
			_adObjectUsed = true;
			_adReady = false;
		}
	}

	public void LogExternalImpression()
	{
	}

	public void LogExternalClick()
	{
	}

	public NativeInterstitialAdObject GetNativeAdAssets()
	{
		if (~(_adReady ? 1u : 0u) == 0)
		{
			return _currentAdObject;
		}
		return null;
	}

	public void AddTestDevice(string deviceID)
	{
	}

	public void SetDebugLogs(bool enableLogs)
	{
	}

	private static void _callback_onNativeAdDidLoad(int uniqueId)
	{
		FacebookNativeAdsIos instance = _instance;
		instance._fbNativeDownloader.DownloadImages(string.Empty, string.Empty);
	}

	private static void _callback_onClick(int uniqueId)
	{
		//IL_0021: Expected Obj, but got I
		FacebookNativeAdsIos instance = _instance;
		FacebookNativeAdsIos instance2 = _instance;
		if (instance2.m_onNativeClicked != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private static void _callback_onFinishedClick(int uniqueId)
	{
	}

	private static void _callback_onImpression(int uniqueId)
	{
		//IL_0021: Expected Obj, but got I
		FacebookNativeAdsIos instance = _instance;
		FacebookNativeAdsIos instance2 = _instance;
		if (instance2.m_onNativeLoggingImpression != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private static void _callback_onNativeAdError(int uniqueId, string error)
	{
		//IL_0021: Expected Obj, but got I
		FacebookNativeAdsIos instance = _instance;
		if (instance.m_onNativeAdError != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void _callback_onImagesDownloaded(Texture2D iconImage, Texture2D coverImage)
	{
		//IL_0069: Expected Obj, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		Action<string> action;
		if (!iconImage || !coverImage)
		{
			action = this.m_onNativeAdError;
			object obj = "Images failed to download";
		}
		else
		{
			NativeInterstitialAdObject nativeInterstitialAdObject = default;
			nativeInterstitialAdObject._002Ector(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, iconImage, coverImage);
			_currentAdObject = nativeInterstitialAdObject;
			_adReady = true;
			object obj = _instance + 36;
			action = this.m_onNativeDidLoad;
		}
		if (action != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S3_v4 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}

	private static int FBNativeAdBridgeCreate(string placementId)
	{
		return 0;
	}

	private static bool FBNativeAdBridgeIsValid(int uniqueId)
	{
		return false;
	}

	private static int FBNativeAdBridgeLoad(int uniqueId)
	{
		return 0;
	}

	private static void FBAdSettingsBridgeAddTestDevice(string deviceID)
	{
	}

	private static void FBNativeAdBridgeRelease(int uniqueId)
	{
	}

	private static string FBNativeAdBridgeGetBody(int uniqueId)
	{
		return string.Empty;
	}

	private static string FBNativeAdBridgeGetCallToAction(int uniqueId)
	{
		return string.Empty;
	}

	private static string FBNativeAdBridgeGetCoverImageURL(int uniqueId)
	{
		return string.Empty;
	}

	private static string FBNativeAdBridgeGetIconImageURL(int uniqueId)
	{
		return string.Empty;
	}

	private static string FBNativeAdBridgeGetTitle(int uniqueId)
	{
		return string.Empty;
	}

	private static string FBNativeAdBridgeGetSubtitle(int uniqueId)
	{
		return string.Empty;
	}

	private static string FBNativeAdBridgeGetSocialContext(int uniqueId)
	{
		return string.Empty;
	}

	private static void FBNativeAdBridgeExternalLogImpression(int uniqueId, string source)
	{
	}

	private static void FBNativeAdBridgeExternalClick(int uniqueId, string source)
	{
	}

	private static void FBNativeAdBridgeOnLoad(int uniqueId, FBNativeAdBridgeExternalCallback callback)
	{
	}

	private static void FBNativeAdBridgeOnImpression(int uniqueId, FBNativeAdBridgeExternalCallback callback)
	{
	}

	private static void FBNativeAdBridgeOnClick(int uniqueId, FBNativeAdBridgeExternalCallback callback)
	{
	}

	private static void FBNativeAdBridgeOnError(int uniqueId, FBNativeAdBridgeErrorExternalCallback callback)
	{
	}

	private static void FBNativeAdBridgeOnFinishedClick(int uniqueId, FBNativeAdBridgeExternalCallback callback)
	{
	}

	public static FacebookNativeAdsIos CreatePlugin()
	{
		GameObject gameObject = default;
		gameObject._002Ector("FacebookIOSReceiver");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		FacebookNativeAdsIos instance = gameObject.AddComponent<FacebookNativeAdsIos>();
		_instance = instance;
		return _instance;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "FacebookIOS: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
