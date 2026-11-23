using System;
using System.Collections;
using Cpp2ILInjected;
using Kiloo.Plugins.Vungle.Internal;
using UnityEngine;

namespace Kiloo.Plugins.Vungle;

public class Vungle
{
	private static IVunglePlatformBridge _platformBridge;

	private static bool _initWasSuccessful;

	private static bool _hasSubscribedToEvents;

	private static VungleVideoViewFinishedEvent m_onVideoViewFinished;

	private static VungleAdStartEvent m_onAdStart;

	private static VungleCachedAdAvailableEvent m_onCachedAdAvailable;

	private static VungleAdUnavailableEvent m_onAdUnavailable;

	private static VungleWillCloseProductSheet m_onWillCloseProductSheet;

	public static event VungleVideoViewFinishedEvent onVideoViewFinished
	{
		add
		{
			Delegate obj = Vungle.m_onVideoViewFinished;
			VungleVideoViewFinishedEvent vungleVideoViewFinishedEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onVideoViewFinished;
				VungleVideoViewFinishedEvent vungleVideoViewFinishedEvent = vungleVideoViewFinishedEvent2;
				if (!flag)
				{
					vungleVideoViewFinishedEvent = Vungle.m_onVideoViewFinished;
				}
				Vungle.m_onVideoViewFinished = vungleVideoViewFinishedEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onVideoViewFinished;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Vungle.m_onVideoViewFinished;
			VungleVideoViewFinishedEvent vungleVideoViewFinishedEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onVideoViewFinished;
				VungleVideoViewFinishedEvent vungleVideoViewFinishedEvent = vungleVideoViewFinishedEvent2;
				if (!flag)
				{
					vungleVideoViewFinishedEvent = Vungle.m_onVideoViewFinished;
				}
				Vungle.m_onVideoViewFinished = vungleVideoViewFinishedEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onVideoViewFinished;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event VungleAdStartEvent onAdStart
	{
		add
		{
			Delegate obj = Vungle.m_onAdStart;
			VungleAdStartEvent vungleAdStartEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onAdStart;
				VungleAdStartEvent vungleAdStartEvent = vungleAdStartEvent2;
				if (!flag)
				{
					vungleAdStartEvent = Vungle.m_onAdStart;
				}
				Vungle.m_onAdStart = vungleAdStartEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onAdStart;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Vungle.m_onAdStart;
			VungleAdStartEvent vungleAdStartEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onAdStart;
				VungleAdStartEvent vungleAdStartEvent = vungleAdStartEvent2;
				if (!flag)
				{
					vungleAdStartEvent = Vungle.m_onAdStart;
				}
				Vungle.m_onAdStart = vungleAdStartEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onAdStart;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event VungleCachedAdAvailableEvent onCachedAdAvailable
	{
		add
		{
			Delegate obj = Vungle.m_onCachedAdAvailable;
			VungleCachedAdAvailableEvent vungleCachedAdAvailableEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onCachedAdAvailable;
				VungleCachedAdAvailableEvent vungleCachedAdAvailableEvent = vungleCachedAdAvailableEvent2;
				if (!flag)
				{
					vungleCachedAdAvailableEvent = Vungle.m_onCachedAdAvailable;
				}
				Vungle.m_onCachedAdAvailable = vungleCachedAdAvailableEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onCachedAdAvailable;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Vungle.m_onCachedAdAvailable;
			VungleCachedAdAvailableEvent vungleCachedAdAvailableEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onCachedAdAvailable;
				VungleCachedAdAvailableEvent vungleCachedAdAvailableEvent = vungleCachedAdAvailableEvent2;
				if (!flag)
				{
					vungleCachedAdAvailableEvent = Vungle.m_onCachedAdAvailable;
				}
				Vungle.m_onCachedAdAvailable = vungleCachedAdAvailableEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onCachedAdAvailable;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event VungleAdUnavailableEvent onAdUnavailable
	{
		add
		{
			Delegate obj = Vungle.m_onAdUnavailable;
			VungleAdUnavailableEvent vungleAdUnavailableEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onAdUnavailable;
				VungleAdUnavailableEvent vungleAdUnavailableEvent = vungleAdUnavailableEvent2;
				if (!flag)
				{
					vungleAdUnavailableEvent = Vungle.m_onAdUnavailable;
				}
				Vungle.m_onAdUnavailable = vungleAdUnavailableEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onAdUnavailable;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Vungle.m_onAdUnavailable;
			VungleAdUnavailableEvent vungleAdUnavailableEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onAdUnavailable;
				VungleAdUnavailableEvent vungleAdUnavailableEvent = vungleAdUnavailableEvent2;
				if (!flag)
				{
					vungleAdUnavailableEvent = Vungle.m_onAdUnavailable;
				}
				Vungle.m_onAdUnavailable = vungleAdUnavailableEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onAdUnavailable;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event VungleWillCloseProductSheet onWillCloseProductSheet
	{
		add
		{
			Delegate obj = Vungle.m_onWillCloseProductSheet;
			VungleWillCloseProductSheet vungleWillCloseProductSheet2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onWillCloseProductSheet;
				VungleWillCloseProductSheet vungleWillCloseProductSheet = vungleWillCloseProductSheet2;
				if (!flag)
				{
					vungleWillCloseProductSheet = Vungle.m_onWillCloseProductSheet;
				}
				Vungle.m_onWillCloseProductSheet = vungleWillCloseProductSheet;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onWillCloseProductSheet;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Vungle.m_onWillCloseProductSheet;
			VungleWillCloseProductSheet vungleWillCloseProductSheet2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Vungle.m_onWillCloseProductSheet;
				VungleWillCloseProductSheet vungleWillCloseProductSheet = vungleWillCloseProductSheet2;
				if (!flag)
				{
					vungleWillCloseProductSheet = Vungle.m_onWillCloseProductSheet;
				}
				Vungle.m_onWillCloseProductSheet = vungleWillCloseProductSheet;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Vungle.m_onWillCloseProductSheet;
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
			if (_initWasSuccessful)
			{
				goto IL_0054;
			}
		}
		LogError("Vungle Android is not initialized.");
		result = false;
		goto IL_0054;
		IL_0054:
		return result;
	}

	public static bool IsSupportedOnPlatform()
	{
		//IL_0034: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.OSXEditor)
		{
			object obj = platform - 7;
			bool flag = (nint)obj == 4;
			bool flag2 = (nint)obj == 1;
			return flag | flag2;
		}
		return false;
	}

	public static bool InitVungle(string appId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		if (_platformBridge == null)
		{
			RuntimePlatform platform = Application.platform;
			object obj3 = platform - 8;
			if (platform != RuntimePlatform.IPhonePlayer)
			{
				if ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 != 3)
				{
					RuntimePlatform platform2 = Application.platform;
					_ = -1;
					obj = (Enum)(object)typeof(RuntimePlatform);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
					_ = 0;
					string text = obj.ToString();
					string msg = "There's no platform bridge for the current platform: " + text;
					LogError(msg);
					bool result = default;
					return result;
				}
				VungleAndroid platformBridge = VungleAndroid.CreatePlugin();
				_platformBridge = platformBridge;
			}
			else
			{
				VungleiOS platformBridge2 = VungleiOS.CreatePlugin();
				_platformBridge = platformBridge2;
			}
		}
		if (_platformBridge != null && !_initWasSuccessful)
		{
			if (~(_hasSubscribedToEvents ? 1u : 0u) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
				_hasSubscribedToEvents = true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			bool initWasSuccessful = default;
			_initWasSuccessful = initWasSuccessful;
		}
		return _initWasSuccessful;
	}

	public static void PlayAd()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void PlayAdWithOptions(IDictionary optionsData)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static bool IsCachedAdAvailable()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
		return false;
	}

	public static void OnPause()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void OnResume()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "Vungle: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
