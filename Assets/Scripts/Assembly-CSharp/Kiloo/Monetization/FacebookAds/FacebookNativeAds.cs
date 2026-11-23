using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Monetization.FacebookAds.Internal;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

namespace Kiloo.Monetization.FacebookAds;

public static class FacebookNativeAds
{
	private static IFacebookNativeAdsBridge _platformNativeBridge;

	private static bool _loading;

	private static bool _initialized;

	private static Action<string> _003C_003Ef__mg_0024cache0;

	private static Action<string> _003C_003Ef__mg_0024cache1;

	private static Action<string> _003C_003Ef__mg_0024cache2;

	private static Action<string> m_onNativeInitialise;

	private static Action<string> m_onNativeDidLoad;

	private static Action<string> m_onNativeAdError;

	public static bool IsNativeInitialized => _platformNativeBridge != null;

	public static event Action<string> onNativeInitialise
	{
		add
		{
			Delegate obj = FacebookNativeAds.m_onNativeInitialise;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == FacebookNativeAds.m_onNativeInitialise;
				Action<string> action = action2;
				if (!flag)
				{
					action = FacebookNativeAds.m_onNativeInitialise;
				}
				FacebookNativeAds.m_onNativeInitialise = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FacebookNativeAds.m_onNativeInitialise;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FacebookNativeAds.m_onNativeInitialise;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == FacebookNativeAds.m_onNativeInitialise;
				Action<string> action = action2;
				if (!flag)
				{
					action = FacebookNativeAds.m_onNativeInitialise;
				}
				FacebookNativeAds.m_onNativeInitialise = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FacebookNativeAds.m_onNativeInitialise;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<string> onNativeDidLoad
	{
		add
		{
			Delegate obj = FacebookNativeAds.m_onNativeDidLoad;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == FacebookNativeAds.m_onNativeDidLoad;
				Action<string> action = action2;
				if (!flag)
				{
					action = FacebookNativeAds.m_onNativeDidLoad;
				}
				FacebookNativeAds.m_onNativeDidLoad = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FacebookNativeAds.m_onNativeDidLoad;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FacebookNativeAds.m_onNativeDidLoad;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == FacebookNativeAds.m_onNativeDidLoad;
				Action<string> action = action2;
				if (!flag)
				{
					action = FacebookNativeAds.m_onNativeDidLoad;
				}
				FacebookNativeAds.m_onNativeDidLoad = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FacebookNativeAds.m_onNativeDidLoad;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<string> onNativeAdError
	{
		add
		{
			Delegate obj = FacebookNativeAds.m_onNativeAdError;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == FacebookNativeAds.m_onNativeAdError;
				Action<string> action = action2;
				if (!flag)
				{
					action = FacebookNativeAds.m_onNativeAdError;
				}
				FacebookNativeAds.m_onNativeAdError = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FacebookNativeAds.m_onNativeAdError;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FacebookNativeAds.m_onNativeAdError;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == FacebookNativeAds.m_onNativeAdError;
				Action<string> action = action2;
				if (!flag)
				{
					action = FacebookNativeAds.m_onNativeAdError;
				}
				FacebookNativeAds.m_onNativeAdError = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FacebookNativeAds.m_onNativeAdError;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static bool IsSupportedOnPlatform()
	{
		//IL_0034: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		bool result;
		if (platform != RuntimePlatform.OSXEditor)
		{
			object obj = platform - 7;
			if (platform != RuntimePlatform.WindowsEditor && (nint)obj != 1)
			{
				bool flag = (nint)obj == 2;
				result = false;
				if (!flag)
				{
					bool flag2 = (nint)obj == 3;
					result = false;
					if (!flag2)
					{
						if ((nint)obj == 4)
						{
							bool isKindleDevice = DeviceUtility.isKindleDevice;
							return (byte)((isKindleDevice ? 1u : 0u) ^ 1u) != 0;
						}
						result = false;
					}
				}
				goto IL_010f;
			}
		}
		result = true;
		goto IL_010f;
		IL_010f:
		return result;
	}

	private static void InstantiateNativeBridge()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.OSXEditor)
		{
			object obj3 = platform - 7;
			if (platform != RuntimePlatform.WindowsEditor)
			{
				if ((nint)obj3 != 1)
				{
					if ((nint)obj3 != 2 && (nint)obj3 != 3 && (nint)obj3 == 4)
					{
						FacebookNativeAdsAndroid platformNativeBridge = FacebookNativeAdsAndroid.CreatePlugin();
						_platformNativeBridge = platformNativeBridge;
						return;
					}
					RuntimePlatform platform2 = Application.platform;
					_ = -1;
					obj = (Enum)(object)typeof(RuntimePlatform);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
					_ = 0;
					string text = obj.ToString();
					string msg = "Facebook ads are not supported for: " + text;
					LogError(msg);
				}
				else
				{
					FacebookNativeAdsIos platformNativeBridge2 = FacebookNativeAdsIos.CreatePlugin();
					_platformNativeBridge = platformNativeBridge2;
				}
				return;
			}
		}
		FacebookNativeAdsSimulated platformNativeBridge3 = FacebookNativeAdsSimulated.CreatePlugin();
		_platformNativeBridge = platformNativeBridge3;
	}

	public static void AddTestDevices(List<string> deviceIDs)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_02f0: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			break;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
	}

	public static void AddTestDevice(string deviceID)
	{
		if (_platformNativeBridge == null)
		{
			InstantiateNativeBridge();
		}
		if (_platformNativeBridge != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void Initialize(string placementID)
	{
		if (_platformNativeBridge == null)
		{
			InstantiateNativeBridge();
		}
		if (_platformNativeBridge != null && !_initialized)
		{
			throw new ArgumentException();
		}
	}

	public static bool IsNativeAdLoaded()
	{
		if (IsNativeInitialized)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
		return false;
	}

	public static void LoadNativeAd()
	{
		if (IsNativeInitialized && !_loading)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			_loading = true;
		}
	}

	public static void DisposeNativeAd()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
	}

	public static void LogExternalClick()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
	}

	public static void LogExternalImpression()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
	}

	public static NativeInterstitialAdObject GetAdObject()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		NativeInterstitialAdObject result = default;
		return result;
	}

	private static void OnInitialize(string message)
	{
		//IL_0021: Expected Obj, but got I
		string text = "onInitialize " + message;
		if (FacebookNativeAds.m_onNativeInitialise != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private static void OnNativeDidLoad(string message)
	{
		//IL_0021: Expected Obj, but got I
		_loading = false;
		string text = "OnNativeDidLoad " + message;
		if (FacebookNativeAds.m_onNativeDidLoad != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v4+4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
	}

	private static void OnNativeAdError(string message)
	{
		//IL_0021: Expected Obj, but got I
		_loading = false;
		string text = "OnNativeAdError " + message;
		if (FacebookNativeAds.m_onNativeAdError != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "FacebookNativeAds: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
