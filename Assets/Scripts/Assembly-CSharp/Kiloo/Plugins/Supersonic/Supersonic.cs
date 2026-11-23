using System;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using Kiloo.Plugins.Supersonic.Internal;
using UnityEngine;

namespace Kiloo.Plugins.Supersonic;

public static class Supersonic
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__63_0;

		public static Action<string> _003C_003E9__63_1;

		public static Action _003C_003E9__63_2;

		public static Action _003C_003E9__63_3;

		public static Action<string> _003C_003E9__63_4;

		public static Action _003C_003E9__63_5;

		public static Action _003C_003E9__63_6;

		public static Action<string> _003C_003E9__63_7;

		public static Action _003C_003E9__63_8;

		public static Action _003C_003E9__63_9;

		public static Action _003C_003E9__63_10;

		public static Action<string> _003C_003E9__63_11;

		public static Action<string> _003C_003E9__63_12;

		public static Action _003C_003E9__63_13;

		public static Action<string> _003C_003E9__63_14;

		public static Action<bool> _003C_003E9__63_15;

		public static Action _003C_003E9__63_16;

		public static Action _003C_003E9__63_17;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CSetupEvents_003Eb__63_0()
		{
			Action onInterstitialInitSuccess = Supersonic.m_onInterstitialInitSuccess;
			if (Supersonic.m_onInterstitialInitSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_1(string obj)
		{
			//IL_0021: Expected Obj, but got I
			if (Supersonic.m_onInterstitialInitFailed != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_2()
		{
			Action onInterstitialClick = Supersonic.m_onInterstitialClick;
			if (Supersonic.m_onInterstitialClick != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_3()
		{
			Action onInterstitialClose = Supersonic.m_onInterstitialClose;
			if (Supersonic.m_onInterstitialClose != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_4(string obj)
		{
			//IL_0021: Expected Obj, but got I
			if (Supersonic.m_onInterstitialLoadFailed != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_5()
		{
			Action onInterstitialOpen = Supersonic.m_onInterstitialOpen;
			if (Supersonic.m_onInterstitialOpen != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_6()
		{
			_interstitialIsAvailable = true;
			Action onInterstitialReady = Supersonic.m_onInterstitialReady;
			if (Supersonic.m_onInterstitialReady != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_7(string obj)
		{
			//IL_0021: Expected Obj, but got I
			if (Supersonic.m_onInterstitialShowFailed != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_8()
		{
			Action onInterstitialShowSuccess = Supersonic.m_onInterstitialShowSuccess;
			if (Supersonic.m_onInterstitialShowSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_9()
		{
			Action onRewardedVideoAdClosed = Supersonic.m_onRewardedVideoAdClosed;
			if (Supersonic.m_onRewardedVideoAdClosed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_10()
		{
			Action onRewardedVideoAdOpened = Supersonic.m_onRewardedVideoAdOpened;
			if (Supersonic.m_onRewardedVideoAdOpened != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_11(string obj)
		{
			//IL_0021: Expected Obj, but got I
			if (Supersonic.m_onRewardedVideoAdRewarded != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_12(string obj)
		{
			//IL_0021: Expected Obj, but got I
			if (Supersonic.m_onRewardedVideoInitFail != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_13()
		{
			Action onRewardedVideoInitSuccess = Supersonic.m_onRewardedVideoInitSuccess;
			if (Supersonic.m_onRewardedVideoInitSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_14(string obj)
		{
			//IL_0021: Expected Obj, but got I
			if (Supersonic.m_onRewardedVideoShowFail != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_15(bool obj)
		{
			//IL_0021: Expected Obj, but got I
			_rewardedVideoIsAvailable = obj;
			if (Supersonic.m_onVideoAvailabilityChanged != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S3_v4+4] (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_16()
		{
			Action onVideoStart = Supersonic.m_onVideoStart;
			if (Supersonic.m_onVideoStart != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CSetupEvents_003Eb__63_17()
		{
			Action onVideoEnd = Supersonic.m_onVideoEnd;
			if (Supersonic.m_onVideoEnd != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private static ISupersonicPlatformBridge _platformBridge;

	private static bool _rewardedVideoIsAvailable;

	private static bool _interstitialIsAvailable;

	private const int MINIMUM_SUPPORTED_ANDROID_API = 17;

	private static Action m_onRewardedVideoInitSuccess;

	private static Action<string> m_onRewardedVideoInitFail;

	private static Action<string> m_onRewardedVideoShowFail;

	private static Action m_onRewardedVideoAdOpened;

	private static Action m_onRewardedVideoAdClosed;

	private static Action<string> m_onRewardedVideoAdRewarded;

	private static Action<bool> m_onVideoAvailabilityChanged;

	private static Action m_onVideoStart;

	private static Action m_onVideoEnd;

	private static Action m_onInterstitialInitSuccess;

	private static Action<string> m_onInterstitialInitFailed;

	private static Action m_onInterstitialReady;

	private static Action<string> m_onInterstitialLoadFailed;

	private static Action m_onInterstitialOpen;

	private static Action m_onInterstitialClose;

	private static Action m_onInterstitialShowSuccess;

	private static Action<string> m_onInterstitialShowFailed;

	private static Action m_onInterstitialClick;

	public static event Action onRewardedVideoInitSuccess
	{
		add
		{
			Delegate obj = Supersonic.m_onRewardedVideoInitSuccess;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoInitSuccess;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoInitSuccess;
				}
				Supersonic.m_onRewardedVideoInitSuccess = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoInitSuccess;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onRewardedVideoInitSuccess;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoInitSuccess;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoInitSuccess;
				}
				Supersonic.m_onRewardedVideoInitSuccess = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoInitSuccess;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<string> onRewardedVideoInitFail
	{
		add
		{
			Delegate obj = Supersonic.m_onRewardedVideoInitFail;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoInitFail;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoInitFail;
				}
				Supersonic.m_onRewardedVideoInitFail = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoInitFail;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onRewardedVideoInitFail;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoInitFail;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoInitFail;
				}
				Supersonic.m_onRewardedVideoInitFail = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoInitFail;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<string> onRewardedVideoShowFail
	{
		add
		{
			Delegate obj = Supersonic.m_onRewardedVideoShowFail;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoShowFail;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoShowFail;
				}
				Supersonic.m_onRewardedVideoShowFail = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoShowFail;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onRewardedVideoShowFail;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoShowFail;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoShowFail;
				}
				Supersonic.m_onRewardedVideoShowFail = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoShowFail;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onRewardedVideoAdOpened
	{
		add
		{
			Delegate obj = Supersonic.m_onRewardedVideoAdOpened;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoAdOpened;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoAdOpened;
				}
				Supersonic.m_onRewardedVideoAdOpened = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoAdOpened;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onRewardedVideoAdOpened;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoAdOpened;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoAdOpened;
				}
				Supersonic.m_onRewardedVideoAdOpened = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoAdOpened;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onRewardedVideoAdClosed
	{
		add
		{
			Delegate obj = Supersonic.m_onRewardedVideoAdClosed;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoAdClosed;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoAdClosed;
				}
				Supersonic.m_onRewardedVideoAdClosed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoAdClosed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onRewardedVideoAdClosed;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoAdClosed;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoAdClosed;
				}
				Supersonic.m_onRewardedVideoAdClosed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoAdClosed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<string> onRewardedVideoAdRewarded
	{
		add
		{
			Delegate obj = Supersonic.m_onRewardedVideoAdRewarded;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoAdRewarded;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoAdRewarded;
				}
				Supersonic.m_onRewardedVideoAdRewarded = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoAdRewarded;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onRewardedVideoAdRewarded;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onRewardedVideoAdRewarded;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onRewardedVideoAdRewarded;
				}
				Supersonic.m_onRewardedVideoAdRewarded = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onRewardedVideoAdRewarded;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<bool> onVideoAvailabilityChanged
	{
		add
		{
			Delegate obj = Supersonic.m_onVideoAvailabilityChanged;
			Action<bool> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onVideoAvailabilityChanged;
				Action<bool> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onVideoAvailabilityChanged;
				}
				Supersonic.m_onVideoAvailabilityChanged = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onVideoAvailabilityChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onVideoAvailabilityChanged;
			Action<bool> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onVideoAvailabilityChanged;
				Action<bool> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onVideoAvailabilityChanged;
				}
				Supersonic.m_onVideoAvailabilityChanged = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onVideoAvailabilityChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onVideoStart
	{
		add
		{
			Delegate obj = Supersonic.m_onVideoStart;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onVideoStart;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onVideoStart;
				}
				Supersonic.m_onVideoStart = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onVideoStart;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onVideoStart;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onVideoStart;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onVideoStart;
				}
				Supersonic.m_onVideoStart = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onVideoStart;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onVideoEnd
	{
		add
		{
			Delegate obj = Supersonic.m_onVideoEnd;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onVideoEnd;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onVideoEnd;
				}
				Supersonic.m_onVideoEnd = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onVideoEnd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onVideoEnd;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onVideoEnd;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onVideoEnd;
				}
				Supersonic.m_onVideoEnd = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onVideoEnd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onInterstitialInitSuccess
	{
		add
		{
			Delegate obj = Supersonic.m_onInterstitialInitSuccess;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialInitSuccess;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialInitSuccess;
				}
				Supersonic.m_onInterstitialInitSuccess = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialInitSuccess;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onInterstitialInitSuccess;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialInitSuccess;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialInitSuccess;
				}
				Supersonic.m_onInterstitialInitSuccess = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialInitSuccess;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<string> onInterstitialInitFailed
	{
		add
		{
			Delegate obj = Supersonic.m_onInterstitialInitFailed;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onInterstitialInitFailed;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialInitFailed;
				}
				Supersonic.m_onInterstitialInitFailed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialInitFailed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onInterstitialInitFailed;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onInterstitialInitFailed;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialInitFailed;
				}
				Supersonic.m_onInterstitialInitFailed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialInitFailed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onInterstitialReady
	{
		add
		{
			Delegate obj = Supersonic.m_onInterstitialReady;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialReady;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialReady;
				}
				Supersonic.m_onInterstitialReady = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialReady;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onInterstitialReady;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialReady;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialReady;
				}
				Supersonic.m_onInterstitialReady = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialReady;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<string> onInterstitialLoadFailed
	{
		add
		{
			Delegate obj = Supersonic.m_onInterstitialLoadFailed;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onInterstitialLoadFailed;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialLoadFailed;
				}
				Supersonic.m_onInterstitialLoadFailed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialLoadFailed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onInterstitialLoadFailed;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onInterstitialLoadFailed;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialLoadFailed;
				}
				Supersonic.m_onInterstitialLoadFailed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialLoadFailed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onInterstitialOpen
	{
		add
		{
			Delegate obj = Supersonic.m_onInterstitialOpen;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialOpen;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialOpen;
				}
				Supersonic.m_onInterstitialOpen = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialOpen;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onInterstitialOpen;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialOpen;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialOpen;
				}
				Supersonic.m_onInterstitialOpen = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialOpen;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onInterstitialClose
	{
		add
		{
			//IL_0075: Expected I, but got Obj
			//IL_008b: Expected Obj, but got I
			Delegate obj = Supersonic.m_onInterstitialClose;
			Delegate obj5 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				nint num = (nint)typeof(Supersonic);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v7 (Il2CppClass<Kiloo.Plugins.Supersonic.Supersonic>)+5C]");
				object obj3 = -(-64);
				bool flag = obj == obj3;
				Delegate obj4 = obj5;
				if (!flag)
				{
					obj4 = (Delegate)obj3;
				}
				obj3 = obj4;
				Delegate obj6 = obj;
				if (!flag)
				{
					obj6 = (Delegate)obj3;
				}
				flag2 = (object)obj != obj6;
				obj = obj6;
			}
			while (flag2);
		}
		remove
		{
			//IL_0075: Expected I, but got Obj
			//IL_008b: Expected Obj, but got I
			Delegate obj = Supersonic.m_onInterstitialClose;
			Delegate obj5 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				nint num = (nint)typeof(Supersonic);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v7 (Il2CppClass<Kiloo.Plugins.Supersonic.Supersonic>)+5C]");
				object obj3 = -(-64);
				bool flag = obj == obj3;
				Delegate obj4 = obj5;
				if (!flag)
				{
					obj4 = (Delegate)obj3;
				}
				obj3 = obj4;
				Delegate obj6 = obj;
				if (!flag)
				{
					obj6 = (Delegate)obj3;
				}
				flag2 = (object)obj != obj6;
				obj = obj6;
			}
			while (flag2);
		}
	}

	public static event Action onInterstitialShowSuccess
	{
		add
		{
			Delegate obj = Supersonic.m_onInterstitialShowSuccess;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialShowSuccess;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialShowSuccess;
				}
				Supersonic.m_onInterstitialShowSuccess = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialShowSuccess;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onInterstitialShowSuccess;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialShowSuccess;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialShowSuccess;
				}
				Supersonic.m_onInterstitialShowSuccess = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialShowSuccess;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<string> onInterstitialShowFailed
	{
		add
		{
			Delegate obj = Supersonic.m_onInterstitialShowFailed;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onInterstitialShowFailed;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialShowFailed;
				}
				Supersonic.m_onInterstitialShowFailed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialShowFailed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onInterstitialShowFailed;
			Action<string> action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Supersonic.m_onInterstitialShowFailed;
				Action<string> action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialShowFailed;
				}
				Supersonic.m_onInterstitialShowFailed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialShowFailed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onInterstitialClick
	{
		add
		{
			Delegate obj = Supersonic.m_onInterstitialClick;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialClick;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialClick;
				}
				Supersonic.m_onInterstitialClick = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialClick;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Supersonic.m_onInterstitialClick;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Supersonic.m_onInterstitialClick;
				Action action = action2;
				if (!flag)
				{
					action = Supersonic.m_onInterstitialClick;
				}
				Supersonic.m_onInterstitialClick = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Supersonic.m_onInterstitialClick;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "Supersonic: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private static bool IsInitialized()
	{
		return _platformBridge != null;
	}

	public static bool IsSupportedOnPlatform()
	{
		//IL_003d: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		bool flag = platform == RuntimePlatform.OSXEditor;
		bool result = true;
		if (!flag)
		{
			object obj = platform - 7;
			bool flag2 = (nint)obj < 2;
			result = true;
			if (!flag2)
			{
				bool flag3 = platform != RuntimePlatform.Android;
				result = false;
				if (!flag3)
				{
					bool isKindleDevice = Kiloo.Plugins.DeviceUtility.DeviceUtility.isKindleDevice;
					result = false;
					if (!isKindleDevice)
					{
						int androidApiLevel = Kiloo.Plugins.DeviceUtility.DeviceUtility.GetAndroidApiLevel();
						bool flag4 = androidApiLevel > 16;
						result = flag4;
					}
				}
			}
		}
		return result;
	}

	private unsafe static void SetupEvents()
	{
		bool flag = _003C_003Ec._003C_003E9__63_0 == null;
		bool flag2 = !flag;
		Action action = _003C_003Ec._003C_003E9__63_0;
		if (!flag2)
		{
			Action action2 = default;
			action2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_0));
			_003C_003Ec._003C_003E9__63_0 = action2;
			action = action2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag3 = _003C_003Ec._003C_003E9__63_1 == null;
		bool flag4 = !flag3;
		Action<string> action3 = _003C_003Ec._003C_003E9__63_1;
		if (!flag4)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag5 = _003C_003Ec._003C_003E9__63_2 == null;
		bool flag6 = !flag5;
		Action action4 = _003C_003Ec._003C_003E9__63_2;
		if (!flag6)
		{
			Action action5 = default;
			action5._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_2));
			_003C_003Ec._003C_003E9__63_2 = action5;
			action4 = action5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag7 = _003C_003Ec._003C_003E9__63_3 == null;
		bool flag8 = !flag7;
		Action action6 = _003C_003Ec._003C_003E9__63_3;
		if (!flag8)
		{
			Action action7 = default;
			action7._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_3));
			_003C_003Ec._003C_003E9__63_3 = action7;
			action6 = action7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag9 = _003C_003Ec._003C_003E9__63_4 == null;
		bool flag10 = !flag9;
		Action<string> action8 = _003C_003Ec._003C_003E9__63_4;
		if (!flag10)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag11 = _003C_003Ec._003C_003E9__63_5 == null;
		bool flag12 = !flag11;
		Action action9 = _003C_003Ec._003C_003E9__63_5;
		if (!flag12)
		{
			Action action10 = default;
			action10._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_5));
			_003C_003Ec._003C_003E9__63_5 = action10;
			action9 = action10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag13 = _003C_003Ec._003C_003E9__63_6 == null;
		bool flag14 = !flag13;
		Action action11 = _003C_003Ec._003C_003E9__63_6;
		if (!flag14)
		{
			Action action12 = default;
			action12._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_6));
			_003C_003Ec._003C_003E9__63_6 = action12;
			action11 = action12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag15 = _003C_003Ec._003C_003E9__63_7 == null;
		bool flag16 = !flag15;
		Action<string> action13 = _003C_003Ec._003C_003E9__63_7;
		if (!flag16)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag17 = _003C_003Ec._003C_003E9__63_8 == null;
		bool flag18 = !flag17;
		Action action14 = _003C_003Ec._003C_003E9__63_8;
		if (!flag18)
		{
			Action action15 = default;
			action15._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_8));
			_003C_003Ec._003C_003E9__63_8 = action15;
			action14 = action15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag19 = _003C_003Ec._003C_003E9__63_9 == null;
		bool flag20 = !flag19;
		Action action16 = _003C_003Ec._003C_003E9__63_9;
		if (!flag20)
		{
			Action action17 = default;
			action17._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_9));
			_003C_003Ec._003C_003E9__63_9 = action17;
			action16 = action17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag21 = _003C_003Ec._003C_003E9__63_10 == null;
		bool flag22 = !flag21;
		Action action18 = _003C_003Ec._003C_003E9__63_10;
		if (!flag22)
		{
			Action action19 = default;
			action19._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_10));
			_003C_003Ec._003C_003E9__63_10 = action19;
			action18 = action19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag23 = _003C_003Ec._003C_003E9__63_11 == null;
		bool flag24 = !flag23;
		Action<string> action20 = _003C_003Ec._003C_003E9__63_11;
		if (!flag24)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag25 = _003C_003Ec._003C_003E9__63_12 == null;
		bool flag26 = !flag25;
		Action<string> action21 = _003C_003Ec._003C_003E9__63_12;
		if (!flag26)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag27 = _003C_003Ec._003C_003E9__63_13 == null;
		bool flag28 = !flag27;
		Action action22 = _003C_003Ec._003C_003E9__63_13;
		if (!flag28)
		{
			Action action23 = default;
			action23._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_13));
			_003C_003Ec._003C_003E9__63_13 = action23;
			action22 = action23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag29 = _003C_003Ec._003C_003E9__63_14 == null;
		bool flag30 = !flag29;
		Action<string> action24 = _003C_003Ec._003C_003E9__63_14;
		if (!flag30)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag31 = _003C_003Ec._003C_003E9__63_15 == null;
		bool flag32 = !flag31;
		Action<bool> action25 = _003C_003Ec._003C_003E9__63_15;
		if (!flag32)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag33 = _003C_003Ec._003C_003E9__63_16 == null;
		bool flag34 = !flag33;
		Action action26 = _003C_003Ec._003C_003E9__63_16;
		if (!flag34)
		{
			Action action27 = default;
			action27._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_16));
			_003C_003Ec._003C_003E9__63_16 = action27;
			action26 = action27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		bool flag35 = _003C_003Ec._003C_003E9__63_17 == null;
		bool flag36 = !flag35;
		Action action28 = _003C_003Ec._003C_003E9__63_17;
		if (!flag36)
		{
			Action action29 = default;
			action29._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CSetupEvents_003Eb__63_17));
			_003C_003Ec._003C_003E9__63_17 = action29;
			action28 = action29;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
	}

	public static void Init()
	{
		//IL_003a: Expected Obj, but got I4
		if (IsInitialized())
		{
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
					SupersonicAndroid platformBridge = SupersonicAndroid.CreatePlugin();
					_platformBridge = platformBridge;
				}
				else
				{
					SupersonicIOS platformBridge2 = SupersonicIOS.CreatePlugin();
					_platformBridge = platformBridge2;
				}
			}
		}
		if (_platformBridge != null)
		{
			SetupEvents();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void ShowInterstitial()
	{
		if (IsInitialized())
		{
			_interstitialIsAvailable = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void ShowInterstitial(string placementName)
	{
		if (IsInitialized())
		{
			_interstitialIsAvailable = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void InitInterstitial(string appKey, string userId)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
		}
	}

	public static void LoadInterstitial()
	{
		if (IsInitialized())
		{
			_interstitialIsAvailable = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static bool IsInterstitialReady()
	{
		if (IsInitialized())
		{
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.IPhonePlayer)
			{
				return _interstitialIsAvailable;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
		return false;
	}

	private static bool IsInterstitialPlacementCapped(string placementName)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			bool result = default;
			return result;
		}
		return false;
	}

	public static void ShowRewardedVideo()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void ShowRewardedVideo(string placementName)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static bool IsRewardedVideoAvailable()
	{
		bool flag = IsInitialized();
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			bool flag3 = (byte)(~(_rewardedVideoIsAvailable ? 1u : 0u)) != 0;
			result = false;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				bool flag4 = default;
				result = flag4;
			}
		}
		return result;
	}

	public static void InitRewardedVideo(string appKey, string userId)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
		}
	}

	public static void ValidateIntegration()
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void ShouldTrackNetworkState(bool shouldTrack)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}
}
