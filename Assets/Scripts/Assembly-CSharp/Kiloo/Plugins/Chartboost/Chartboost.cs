using System;
using Cpp2ILInjected;
using Kiloo.Plugins.Chartboost.Internal;
using UnityEngine;

namespace Kiloo.Plugins.Chartboost;

public static class Chartboost
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ChartboostLocationCallback _003C_003E9__49_0;

		public static ChartboostLocationCallback _003C_003E9__49_1;

		public static ChartboostLocationCallback _003C_003E9__49_2;

		public static ChartboostLocationCallback _003C_003E9__49_3;

		public static ChartboostLocationCallback _003C_003E9__49_4;

		public static ChartboostLocationCallback _003C_003E9__49_5;

		public static ChartboostLocationCallback _003C_003E9__49_6;

		public static ChartboostLocationCallback _003C_003E9__49_7;

		public static ChartboostLocationCallback _003C_003E9__49_8;

		public static ChartboostLocationCallback _003C_003E9__49_9;

		public static ChartboostLocationCallback _003C_003E9__49_10;

		public static ChartboostLocationCallback _003C_003E9__49_11;

		public static ChartboostLocationCallback _003C_003E9__49_12;

		public static ChartboostLocationCallback _003C_003E9__49_13;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CStartSession_003Eb__49_0(string obj)
		{
			ChartboostLocationCallback onCacheInterstitial = Chartboost.m_onCacheInterstitial;
			if (Chartboost.m_onCacheInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_1(string obj)
		{
			ChartboostLocationCallback onClickInterstitial = Chartboost.m_onClickInterstitial;
			if (Chartboost.m_onClickInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_2(string obj)
		{
			ChartboostLocationCallback onCloseInterstitial = Chartboost.m_onCloseInterstitial;
			if (Chartboost.m_onCloseInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_3(string obj)
		{
			ChartboostLocationCallback onDismissInterstitial = Chartboost.m_onDismissInterstitial;
			if (Chartboost.m_onDismissInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_4(string obj)
		{
			ChartboostLocationCallback onFailToLoadInterstitial = Chartboost.m_onFailToLoadInterstitial;
			if (Chartboost.m_onFailToLoadInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_5(string obj)
		{
			ChartboostLocationCallback onShowInterstitial = Chartboost.m_onShowInterstitial;
			if (Chartboost.m_onShowInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_6(string obj)
		{
			ChartboostLocationCallback onCacheRewardedVideo = Chartboost.m_onCacheRewardedVideo;
			if (Chartboost.m_onCacheRewardedVideo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_7(string obj)
		{
			ChartboostLocationCallback onFailToLoadRewardedVideo = Chartboost.m_onFailToLoadRewardedVideo;
			if (Chartboost.m_onFailToLoadRewardedVideo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_8(string obj)
		{
			ChartboostLocationCallback onDismissRewardedVideo = Chartboost.m_onDismissRewardedVideo;
			if (Chartboost.m_onDismissRewardedVideo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_9(string obj)
		{
			ChartboostLocationCallback onCloseRewardedVideo = Chartboost.m_onCloseRewardedVideo;
			if (Chartboost.m_onCloseRewardedVideo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_10(string obj)
		{
			ChartboostLocationCallback onClickRewardedVideo = Chartboost.m_onClickRewardedVideo;
			if (Chartboost.m_onClickRewardedVideo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_11(string obj)
		{
			ChartboostLocationCallback onCompleteRewardedVideo = Chartboost.m_onCompleteRewardedVideo;
			if (Chartboost.m_onCompleteRewardedVideo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_12(string obj)
		{
			ChartboostLocationCallback onDisplayRewardedVideo = Chartboost.m_onDisplayRewardedVideo;
			if (Chartboost.m_onDisplayRewardedVideo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__49_13(string obj)
		{
			ChartboostLocationCallback onWillDisplayVideo = Chartboost.m_onWillDisplayVideo;
			if (Chartboost.m_onWillDisplayVideo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private static IChartboostPlatformBridge _platformBridge;

	private static ChartboostLocationCallback m_onCacheInterstitial;

	private static ChartboostLocationCallback m_onFailToLoadInterstitial;

	private static ChartboostLocationCallback m_onDismissInterstitial;

	private static ChartboostLocationCallback m_onCloseInterstitial;

	private static ChartboostLocationCallback m_onClickInterstitial;

	private static ChartboostLocationCallback m_onShowInterstitial;

	private static ChartboostLocationCallback m_onCacheRewardedVideo;

	private static ChartboostLocationCallback m_onFailToLoadRewardedVideo;

	private static ChartboostLocationCallback m_onDismissRewardedVideo;

	private static ChartboostLocationCallback m_onCloseRewardedVideo;

	private static ChartboostLocationCallback m_onClickRewardedVideo;

	private static ChartboostLocationCallback m_onCompleteRewardedVideo;

	private static ChartboostLocationCallback m_onDisplayRewardedVideo;

	private static ChartboostLocationCallback m_onWillDisplayVideo;

	public static event ChartboostLocationCallback onCacheInterstitial
	{
		add
		{
			Delegate obj = Chartboost.m_onCacheInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCacheInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCacheInterstitial;
				}
				Chartboost.m_onCacheInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCacheInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onCacheInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCacheInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCacheInterstitial;
				}
				Chartboost.m_onCacheInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCacheInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onFailToLoadInterstitial
	{
		add
		{
			Delegate obj = Chartboost.m_onFailToLoadInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onFailToLoadInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onFailToLoadInterstitial;
				}
				Chartboost.m_onFailToLoadInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onFailToLoadInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onFailToLoadInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onFailToLoadInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onFailToLoadInterstitial;
				}
				Chartboost.m_onFailToLoadInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onFailToLoadInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onDismissInterstitial
	{
		add
		{
			Delegate obj = Chartboost.m_onDismissInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onDismissInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onDismissInterstitial;
				}
				Chartboost.m_onDismissInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onDismissInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onDismissInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onDismissInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onDismissInterstitial;
				}
				Chartboost.m_onDismissInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onDismissInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onCloseInterstitial
	{
		add
		{
			Delegate obj = Chartboost.m_onCloseInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCloseInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCloseInterstitial;
				}
				Chartboost.m_onCloseInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCloseInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onCloseInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCloseInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCloseInterstitial;
				}
				Chartboost.m_onCloseInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCloseInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onClickInterstitial
	{
		add
		{
			Delegate obj = Chartboost.m_onClickInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onClickInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onClickInterstitial;
				}
				Chartboost.m_onClickInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onClickInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onClickInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onClickInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onClickInterstitial;
				}
				Chartboost.m_onClickInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onClickInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onShowInterstitial
	{
		add
		{
			Delegate obj = Chartboost.m_onShowInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onShowInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onShowInterstitial;
				}
				Chartboost.m_onShowInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onShowInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onShowInterstitial;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onShowInterstitial;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onShowInterstitial;
				}
				Chartboost.m_onShowInterstitial = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onShowInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onCacheRewardedVideo
	{
		add
		{
			Delegate obj = Chartboost.m_onCacheRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCacheRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCacheRewardedVideo;
				}
				Chartboost.m_onCacheRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCacheRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onCacheRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCacheRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCacheRewardedVideo;
				}
				Chartboost.m_onCacheRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCacheRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onFailToLoadRewardedVideo
	{
		add
		{
			Delegate obj = Chartboost.m_onFailToLoadRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onFailToLoadRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onFailToLoadRewardedVideo;
				}
				Chartboost.m_onFailToLoadRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onFailToLoadRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onFailToLoadRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onFailToLoadRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onFailToLoadRewardedVideo;
				}
				Chartboost.m_onFailToLoadRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onFailToLoadRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onDismissRewardedVideo
	{
		add
		{
			Delegate obj = Chartboost.m_onDismissRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onDismissRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onDismissRewardedVideo;
				}
				Chartboost.m_onDismissRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onDismissRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onDismissRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onDismissRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onDismissRewardedVideo;
				}
				Chartboost.m_onDismissRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onDismissRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onCloseRewardedVideo
	{
		add
		{
			Delegate obj = Chartboost.m_onCloseRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCloseRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCloseRewardedVideo;
				}
				Chartboost.m_onCloseRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCloseRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onCloseRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCloseRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCloseRewardedVideo;
				}
				Chartboost.m_onCloseRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCloseRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onClickRewardedVideo
	{
		add
		{
			Delegate obj = Chartboost.m_onClickRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onClickRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onClickRewardedVideo;
				}
				Chartboost.m_onClickRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onClickRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onClickRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onClickRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onClickRewardedVideo;
				}
				Chartboost.m_onClickRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onClickRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onCompleteRewardedVideo
	{
		add
		{
			Delegate obj = Chartboost.m_onCompleteRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCompleteRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCompleteRewardedVideo;
				}
				Chartboost.m_onCompleteRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCompleteRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onCompleteRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onCompleteRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onCompleteRewardedVideo;
				}
				Chartboost.m_onCompleteRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onCompleteRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onDisplayRewardedVideo
	{
		add
		{
			Delegate obj = Chartboost.m_onDisplayRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onDisplayRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onDisplayRewardedVideo;
				}
				Chartboost.m_onDisplayRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onDisplayRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onDisplayRewardedVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onDisplayRewardedVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onDisplayRewardedVideo;
				}
				Chartboost.m_onDisplayRewardedVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onDisplayRewardedVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event ChartboostLocationCallback onWillDisplayVideo
	{
		add
		{
			Delegate obj = Chartboost.m_onWillDisplayVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onWillDisplayVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onWillDisplayVideo;
				}
				Chartboost.m_onWillDisplayVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onWillDisplayVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Chartboost.m_onWillDisplayVideo;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Chartboost.m_onWillDisplayVideo;
				ChartboostLocationCallback chartboostLocationCallback = chartboostLocationCallback2;
				if (!flag)
				{
					chartboostLocationCallback = Chartboost.m_onWillDisplayVideo;
				}
				Chartboost.m_onWillDisplayVideo = chartboostLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Chartboost.m_onWillDisplayVideo;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "Chartboost: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private static void TriggerEvent(ChartboostLocationCallback evt, string location)
	{
		if (evt != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: evt.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static bool IsInitialized()
	{
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

	public unsafe static void StartSession(string appId, string appSignature)
	{
		//IL_0039: Expected Obj, but got I4
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
					ChartboostAndroid platformBridge = ChartboostAndroid.CreatePlugin();
					_platformBridge = platformBridge;
				}
				else
				{
					ChartboostIOS platformBridge2 = ChartboostIOS.CreatePlugin();
					_platformBridge = platformBridge2;
				}
			}
		}
		if (_platformBridge != null)
		{
			bool flag = _003C_003Ec._003C_003E9__49_0 == null;
			bool flag2 = !flag;
			ChartboostLocationCallback chartboostLocationCallback = _003C_003Ec._003C_003E9__49_0;
			if (!flag2)
			{
				ChartboostLocationCallback chartboostLocationCallback2 = default;
				chartboostLocationCallback2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_0));
				_003C_003Ec._003C_003E9__49_0 = chartboostLocationCallback2;
				chartboostLocationCallback = chartboostLocationCallback2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag3 = _003C_003Ec._003C_003E9__49_1 == null;
			bool flag4 = !flag3;
			ChartboostLocationCallback chartboostLocationCallback3 = _003C_003Ec._003C_003E9__49_1;
			if (!flag4)
			{
				ChartboostLocationCallback chartboostLocationCallback4 = default;
				chartboostLocationCallback4._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_1));
				_003C_003Ec._003C_003E9__49_1 = chartboostLocationCallback4;
				chartboostLocationCallback3 = chartboostLocationCallback4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag5 = _003C_003Ec._003C_003E9__49_2 == null;
			bool flag6 = !flag5;
			ChartboostLocationCallback chartboostLocationCallback5 = _003C_003Ec._003C_003E9__49_2;
			if (!flag6)
			{
				ChartboostLocationCallback chartboostLocationCallback6 = default;
				chartboostLocationCallback6._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_2));
				_003C_003Ec._003C_003E9__49_2 = chartboostLocationCallback6;
				chartboostLocationCallback5 = chartboostLocationCallback6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag7 = _003C_003Ec._003C_003E9__49_3 == null;
			bool flag8 = !flag7;
			ChartboostLocationCallback chartboostLocationCallback7 = _003C_003Ec._003C_003E9__49_3;
			if (!flag8)
			{
				ChartboostLocationCallback chartboostLocationCallback8 = default;
				chartboostLocationCallback8._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_3));
				_003C_003Ec._003C_003E9__49_3 = chartboostLocationCallback8;
				chartboostLocationCallback7 = chartboostLocationCallback8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag9 = _003C_003Ec._003C_003E9__49_4 == null;
			bool flag10 = !flag9;
			ChartboostLocationCallback chartboostLocationCallback9 = _003C_003Ec._003C_003E9__49_4;
			if (!flag10)
			{
				ChartboostLocationCallback chartboostLocationCallback10 = default;
				chartboostLocationCallback10._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_4));
				_003C_003Ec._003C_003E9__49_4 = chartboostLocationCallback10;
				chartboostLocationCallback9 = chartboostLocationCallback10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag11 = _003C_003Ec._003C_003E9__49_5 == null;
			bool flag12 = !flag11;
			ChartboostLocationCallback chartboostLocationCallback11 = _003C_003Ec._003C_003E9__49_5;
			if (!flag12)
			{
				ChartboostLocationCallback chartboostLocationCallback12 = default;
				chartboostLocationCallback12._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_5));
				_003C_003Ec._003C_003E9__49_5 = chartboostLocationCallback12;
				chartboostLocationCallback11 = chartboostLocationCallback12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag13 = _003C_003Ec._003C_003E9__49_6 == null;
			bool flag14 = !flag13;
			ChartboostLocationCallback chartboostLocationCallback13 = _003C_003Ec._003C_003E9__49_6;
			if (!flag14)
			{
				ChartboostLocationCallback chartboostLocationCallback14 = default;
				chartboostLocationCallback14._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_6));
				_003C_003Ec._003C_003E9__49_6 = chartboostLocationCallback14;
				chartboostLocationCallback13 = chartboostLocationCallback14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag15 = _003C_003Ec._003C_003E9__49_7 == null;
			bool flag16 = !flag15;
			ChartboostLocationCallback chartboostLocationCallback15 = _003C_003Ec._003C_003E9__49_7;
			if (!flag16)
			{
				ChartboostLocationCallback chartboostLocationCallback16 = default;
				chartboostLocationCallback16._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_7));
				_003C_003Ec._003C_003E9__49_7 = chartboostLocationCallback16;
				chartboostLocationCallback15 = chartboostLocationCallback16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag17 = _003C_003Ec._003C_003E9__49_8 == null;
			bool flag18 = !flag17;
			ChartboostLocationCallback chartboostLocationCallback17 = _003C_003Ec._003C_003E9__49_8;
			if (!flag18)
			{
				ChartboostLocationCallback chartboostLocationCallback18 = default;
				chartboostLocationCallback18._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_8));
				_003C_003Ec._003C_003E9__49_8 = chartboostLocationCallback18;
				chartboostLocationCallback17 = chartboostLocationCallback18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag19 = _003C_003Ec._003C_003E9__49_9 == null;
			bool flag20 = !flag19;
			ChartboostLocationCallback chartboostLocationCallback19 = _003C_003Ec._003C_003E9__49_9;
			if (!flag20)
			{
				ChartboostLocationCallback chartboostLocationCallback20 = default;
				chartboostLocationCallback20._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_9));
				_003C_003Ec._003C_003E9__49_9 = chartboostLocationCallback20;
				chartboostLocationCallback19 = chartboostLocationCallback20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag21 = _003C_003Ec._003C_003E9__49_10 == null;
			bool flag22 = !flag21;
			ChartboostLocationCallback chartboostLocationCallback21 = _003C_003Ec._003C_003E9__49_10;
			if (!flag22)
			{
				ChartboostLocationCallback chartboostLocationCallback22 = default;
				chartboostLocationCallback22._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_10));
				_003C_003Ec._003C_003E9__49_10 = chartboostLocationCallback22;
				chartboostLocationCallback21 = chartboostLocationCallback22;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag23 = _003C_003Ec._003C_003E9__49_11 == null;
			bool flag24 = !flag23;
			ChartboostLocationCallback chartboostLocationCallback23 = _003C_003Ec._003C_003E9__49_11;
			if (!flag24)
			{
				ChartboostLocationCallback chartboostLocationCallback24 = default;
				chartboostLocationCallback24._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_11));
				_003C_003Ec._003C_003E9__49_11 = chartboostLocationCallback24;
				chartboostLocationCallback23 = chartboostLocationCallback24;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag25 = _003C_003Ec._003C_003E9__49_12 == null;
			bool flag26 = !flag25;
			ChartboostLocationCallback chartboostLocationCallback25 = _003C_003Ec._003C_003E9__49_12;
			if (!flag26)
			{
				ChartboostLocationCallback chartboostLocationCallback26 = default;
				chartboostLocationCallback26._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_12));
				_003C_003Ec._003C_003E9__49_12 = chartboostLocationCallback26;
				chartboostLocationCallback25 = chartboostLocationCallback26;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag27 = _003C_003Ec._003C_003E9__49_13 == null;
			bool flag28 = !flag27;
			ChartboostLocationCallback chartboostLocationCallback27 = _003C_003Ec._003C_003E9__49_13;
			if (!flag28)
			{
				ChartboostLocationCallback chartboostLocationCallback28 = default;
				chartboostLocationCallback28._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__49_13));
				_003C_003Ec._003C_003E9__49_13 = chartboostLocationCallback28;
				chartboostLocationCallback27 = chartboostLocationCallback28;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
		}
	}

	public static void CacheInterstitial(string location)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void ShowInterstitial(string location)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static bool HasCachedInterstitial(string location)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			bool result = default;
			return result;
		}
		return false;
	}

	public static void SetShouldRequestInterstitial(bool val)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void SetShouldDisplayInterstitial(bool val)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void SetShouldRequestInterstitialsInFirstSession(bool val)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void CacheRewardedVideo(string location)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void ShowRewardedVideo(string location)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static bool HasCachedRewardedVideo(string location)
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			bool result = default;
			return result;
		}
		return false;
	}
}
