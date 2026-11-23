using System;
using Cpp2ILInjected;
using Kiloo.Monetization.Flurry.Internal;
using UnityEngine;

namespace Kiloo.Monetization.Flurry;

public static class FlurryVideoAds
{
	private static IFlurryVideoAds _platformBridge;

	private static bool _initialized;

	private static FlurryAdsCallback m_onTakeoverWillDisplay;

	private static FlurryAdsCallback m_onTakeoverWillClose;

	private static FlurryAdsCallback m_onVideoDidFinish;

	private static FlurryAdsCallback m_onVideoDidNotFinish;

	private static FlurryAdsCallback m_onVideoAvailable;

	private static FlurryAdsCallback m_onVideoUnavailable;

	public static event FlurryAdsCallback onTakeoverWillDisplay
	{
		add
		{
			Delegate obj = FlurryVideoAds.m_onTakeoverWillDisplay;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onTakeoverWillDisplay;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onTakeoverWillDisplay;
				}
				FlurryVideoAds.m_onTakeoverWillDisplay = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onTakeoverWillDisplay;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FlurryVideoAds.m_onTakeoverWillDisplay;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onTakeoverWillDisplay;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onTakeoverWillDisplay;
				}
				FlurryVideoAds.m_onTakeoverWillDisplay = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onTakeoverWillDisplay;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event FlurryAdsCallback onTakeoverWillClose
	{
		add
		{
			Delegate obj = FlurryVideoAds.m_onTakeoverWillClose;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onTakeoverWillClose;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onTakeoverWillClose;
				}
				FlurryVideoAds.m_onTakeoverWillClose = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onTakeoverWillClose;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FlurryVideoAds.m_onTakeoverWillClose;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onTakeoverWillClose;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onTakeoverWillClose;
				}
				FlurryVideoAds.m_onTakeoverWillClose = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onTakeoverWillClose;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event FlurryAdsCallback onVideoDidFinish
	{
		add
		{
			Delegate obj = FlurryVideoAds.m_onVideoDidFinish;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onVideoDidFinish;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onVideoDidFinish;
				}
				FlurryVideoAds.m_onVideoDidFinish = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onVideoDidFinish;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FlurryVideoAds.m_onVideoDidFinish;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onVideoDidFinish;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onVideoDidFinish;
				}
				FlurryVideoAds.m_onVideoDidFinish = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onVideoDidFinish;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event FlurryAdsCallback onVideoDidNotFinish
	{
		add
		{
			Delegate obj = FlurryVideoAds.m_onVideoDidNotFinish;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onVideoDidNotFinish;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onVideoDidNotFinish;
				}
				FlurryVideoAds.m_onVideoDidNotFinish = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onVideoDidNotFinish;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FlurryVideoAds.m_onVideoDidNotFinish;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onVideoDidNotFinish;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onVideoDidNotFinish;
				}
				FlurryVideoAds.m_onVideoDidNotFinish = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onVideoDidNotFinish;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event FlurryAdsCallback onVideoAvailable
	{
		add
		{
			Delegate obj = FlurryVideoAds.m_onVideoAvailable;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onVideoAvailable;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onVideoAvailable;
				}
				FlurryVideoAds.m_onVideoAvailable = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onVideoAvailable;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FlurryVideoAds.m_onVideoAvailable;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onVideoAvailable;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onVideoAvailable;
				}
				FlurryVideoAds.m_onVideoAvailable = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onVideoAvailable;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event FlurryAdsCallback onVideoUnavailable
	{
		add
		{
			Delegate obj = FlurryVideoAds.m_onVideoUnavailable;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onVideoUnavailable;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onVideoUnavailable;
				}
				FlurryVideoAds.m_onVideoUnavailable = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onVideoUnavailable;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FlurryVideoAds.m_onVideoUnavailable;
			FlurryAdsCallback flurryAdsCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FlurryVideoAds.m_onVideoUnavailable;
				FlurryAdsCallback flurryAdsCallback = flurryAdsCallback2;
				if (!flag)
				{
					flurryAdsCallback = FlurryVideoAds.m_onVideoUnavailable;
				}
				FlurryVideoAds.m_onVideoUnavailable = flurryAdsCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FlurryVideoAds.m_onVideoUnavailable;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private static bool IsInitialized()
	{
		bool result;
		if (_platformBridge != null)
		{
			result = true;
			if (_initialized)
			{
				goto IL_0049;
			}
		}
		result = false;
		goto IL_0049;
		IL_0049:
		return result;
	}

	public static bool IsSupportedOnPlatform()
	{
		RuntimePlatform platform = Application.platform;
		bool flag = platform == RuntimePlatform.IPhonePlayer;
		bool flag2 = platform == RuntimePlatform.Android;
		return flag | flag2;
	}

	public static void Initialize(string adSpace)
	{
		if (_initialized || !IsSupportedOnPlatform())
		{
			return;
		}
		RuntimePlatform platform = Application.platform;
		FlurryVideoAdsAndroid platformBridge;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			FlurryVideoAdsIos flurryVideoAdsIos = FlurryVideoAdsIos.CreatePlugin();
			platformBridge = (FlurryVideoAdsAndroid)(object)flurryVideoAdsIos;
		}
		else
		{
			RuntimePlatform platform2 = Application.platform;
			if (platform2 != RuntimePlatform.Android)
			{
				LogError("There's no platform bridge for the current platform.");
				return;
			}
			platformBridge = FlurryVideoAdsAndroid.CreatePlugin();
		}
		_platformBridge = platformBridge;
		if (_platformBridge == null)
		{
			LogError("An error occured when creating Flurry bridge.");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
		_initialized = true;
	}

	public static void CacheAd()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void ShowAd()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static bool HasCachedAd()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
		return false;
	}

	public static void EnableDebugLogs()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void EnableTestAds()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "FlurryVideoAds: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
