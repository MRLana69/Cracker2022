using System;
using Cpp2ILInjected;
using Kiloo.Plugins.AdColony.Internal;
using UnityEngine;

namespace Kiloo.Plugins.AdColony;

public static class AdColony
{
	private static IAdColonyPlatformBridge _platformBridge;

	private static Action _003C_003Ef__mg_0024cache0;

	private static Action<bool> _003C_003Ef__mg_0024cache1;

	private static Action _003C_003Ef__mg_0024cache2;

	private static Action _003C_003Ef__mg_0024cache3;

	private static Action _003C_003Ef__mg_0024cache4;

	private static Action _003C_003Ef__mg_0024cache5;

	private static Action<bool> m_onVideoReward;

	private static Action m_onAdAttemptFinished;

	private static Action m_onAdStarted;

	private static Action m_onCachingFailed;

	private static Action m_onCachingSuccess;

	private static Action m_onInitFinished;

	public static event Action<bool> onVideoReward
	{
		add
		{
			Delegate obj = AdColony.m_onVideoReward;
			Action<bool> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == AdColony.m_onVideoReward;
				Action<bool> action = action2;
				if (!flag)
				{
					action = AdColony.m_onVideoReward;
				}
				AdColony.m_onVideoReward = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onVideoReward;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = AdColony.m_onVideoReward;
			Action<bool> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == AdColony.m_onVideoReward;
				Action<bool> action = action2;
				if (!flag)
				{
					action = AdColony.m_onVideoReward;
				}
				AdColony.m_onVideoReward = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onVideoReward;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onAdAttemptFinished
	{
		add
		{
			Delegate obj = AdColony.m_onAdAttemptFinished;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onAdAttemptFinished;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onAdAttemptFinished;
				}
				AdColony.m_onAdAttemptFinished = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onAdAttemptFinished;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = AdColony.m_onAdAttemptFinished;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onAdAttemptFinished;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onAdAttemptFinished;
				}
				AdColony.m_onAdAttemptFinished = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onAdAttemptFinished;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onAdStarted
	{
		add
		{
			Delegate obj = AdColony.m_onAdStarted;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onAdStarted;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onAdStarted;
				}
				AdColony.m_onAdStarted = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onAdStarted;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = AdColony.m_onAdStarted;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onAdStarted;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onAdStarted;
				}
				AdColony.m_onAdStarted = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onAdStarted;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onCachingFailed
	{
		add
		{
			Delegate obj = AdColony.m_onCachingFailed;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onCachingFailed;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onCachingFailed;
				}
				AdColony.m_onCachingFailed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onCachingFailed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = AdColony.m_onCachingFailed;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onCachingFailed;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onCachingFailed;
				}
				AdColony.m_onCachingFailed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onCachingFailed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onCachingSuccess
	{
		add
		{
			Delegate obj = AdColony.m_onCachingSuccess;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onCachingSuccess;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onCachingSuccess;
				}
				AdColony.m_onCachingSuccess = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onCachingSuccess;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = AdColony.m_onCachingSuccess;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onCachingSuccess;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onCachingSuccess;
				}
				AdColony.m_onCachingSuccess = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onCachingSuccess;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onInitFinished
	{
		add
		{
			Delegate obj = AdColony.m_onInitFinished;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onInitFinished;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onInitFinished;
				}
				AdColony.m_onInitFinished = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onInitFinished;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = AdColony.m_onInitFinished;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AdColony.m_onInitFinished;
				Action action = action2;
				if (!flag)
				{
					action = AdColony.m_onInitFinished;
				}
				AdColony.m_onInitFinished = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AdColony.m_onInitFinished;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "AdColony: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private static void OnInitializationFinished()
	{
		Action action = AdColony.m_onInitFinished;
		if (AdColony.m_onInitFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnVideoRewardCallback(bool success)
	{
		//IL_0021: Expected Obj, but got I
		if (AdColony.m_onVideoReward != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private static void OnAdAttemptFinishedCallback()
	{
		Action action = AdColony.m_onAdAttemptFinished;
		if (AdColony.m_onAdAttemptFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnAdStartedCallback()
	{
		Action action = AdColony.m_onAdStarted;
		if (AdColony.m_onAdStarted != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnAdCachingFailedCallback()
	{
		Action action = AdColony.m_onCachingFailed;
		if (AdColony.m_onCachingFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnAdCachingSuccessCallback()
	{
		Action action = AdColony.m_onCachingSuccess;
		if (AdColony.m_onCachingSuccess != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static bool CheckConfigured()
	{
		if (_platformBridge == null)
		{
			LogError("AdColony must be configured before this call.");
		}
		return _platformBridge != null;
	}

	public static bool IsSupportedOnPlatform()
	{
		//IL_0034: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.OSXEditor)
		{
			object obj = platform - 7;
			if ((nint)obj >= 2)
			{
				return platform == RuntimePlatform.Android;
			}
		}
		return true;
	}

	public unsafe static void Configure(string appID, string[] zoneIDs)
	{
		//IL_0045: Expected Obj, but got I4
		if (_platformBridge != null)
		{
			LogError("AdColony has already been configured. Ignoring new parameters.");
			return;
		}
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.OSXEditor)
		{
			object obj = platform - 7;
			if (platform != RuntimePlatform.WindowsEditor)
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj == 2 || (nint)obj == 3 || (nint)obj != 4)
					{
						LogError("There's no platform bridge for the current platform.");
						return;
					}
					AdColonyAndroid platformBridge = AdColonyAndroid.CreatePlugin();
					_platformBridge = platformBridge;
				}
				else
				{
					AdColonyIOS platformBridge2 = AdColonyIOS.CreatePlugin();
					_platformBridge = platformBridge2;
				}
			}
		}
		Action action = default;
		action._002Ector(null, (nint)(delegate*<void>)(&OnInitializationFinished));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		throw new ArgumentException();
	}

	public static void LoadVideoAd(string zoneID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
	}

	public static void PlayVideoAd()
	{
		if (CheckConfigured())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static bool IsVideoAvailable()
	{
		if (CheckConfigured())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
		return false;
	}
}
