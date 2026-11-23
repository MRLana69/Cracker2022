using System;
using Cpp2ILInjected;
using Kiloo.Plugins.MdotM.Internal;
using UnityEngine;

namespace Kiloo.Plugins.MdotM;

public static class MdotM
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static MdotMLocationCallback _003C_003E9__25_0;

		public static MdotMLocationCallback _003C_003E9__25_1;

		public static MdotMLocationCallback _003C_003E9__25_2;

		public static MdotMLocationCallback _003C_003E9__25_3;

		public static MdotMLocationCallback _003C_003E9__25_4;

		public static MdotMLocationCallback _003C_003E9__25_5;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CStartSession_003Eb__25_0(string obj)
		{
			MdotMLocationCallback onCacheInterstitial = MdotM.m_onCacheInterstitial;
			if (MdotM.m_onCacheInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__25_1(string obj)
		{
			MdotMLocationCallback onClickInterstitial = MdotM.m_onClickInterstitial;
			if (MdotM.m_onClickInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__25_2(string obj)
		{
			MdotMLocationCallback onCloseInterstitial = MdotM.m_onCloseInterstitial;
			if (MdotM.m_onCloseInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__25_3(string obj)
		{
			MdotMLocationCallback onDismissInterstitial = MdotM.m_onDismissInterstitial;
			if (MdotM.m_onDismissInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__25_4(string obj)
		{
			MdotMLocationCallback onFailToLoadInterstitial = MdotM.m_onFailToLoadInterstitial;
			if (MdotM.m_onFailToLoadInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CStartSession_003Eb__25_5(string obj)
		{
			MdotMLocationCallback onShowInterstitial = MdotM.m_onShowInterstitial;
			if (MdotM.m_onShowInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private static IMdotMPlatformBridge _platformBridge;

	private static MdotMLocationCallback m_onCacheInterstitial;

	private static MdotMLocationCallback m_onFailToLoadInterstitial;

	private static MdotMLocationCallback m_onDismissInterstitial;

	private static MdotMLocationCallback m_onCloseInterstitial;

	private static MdotMLocationCallback m_onClickInterstitial;

	private static MdotMLocationCallback m_onShowInterstitial;

	public static event MdotMLocationCallback onCacheInterstitial
	{
		add
		{
			Delegate obj = MdotM.m_onCacheInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onCacheInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onCacheInterstitial;
				}
				MdotM.m_onCacheInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onCacheInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = MdotM.m_onCacheInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onCacheInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onCacheInterstitial;
				}
				MdotM.m_onCacheInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onCacheInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event MdotMLocationCallback onFailToLoadInterstitial
	{
		add
		{
			Delegate obj = MdotM.m_onFailToLoadInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onFailToLoadInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onFailToLoadInterstitial;
				}
				MdotM.m_onFailToLoadInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onFailToLoadInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = MdotM.m_onFailToLoadInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onFailToLoadInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onFailToLoadInterstitial;
				}
				MdotM.m_onFailToLoadInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onFailToLoadInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event MdotMLocationCallback onDismissInterstitial
	{
		add
		{
			Delegate obj = MdotM.m_onDismissInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onDismissInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onDismissInterstitial;
				}
				MdotM.m_onDismissInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onDismissInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = MdotM.m_onDismissInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onDismissInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onDismissInterstitial;
				}
				MdotM.m_onDismissInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onDismissInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event MdotMLocationCallback onCloseInterstitial
	{
		add
		{
			Delegate obj = MdotM.m_onCloseInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onCloseInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onCloseInterstitial;
				}
				MdotM.m_onCloseInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onCloseInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = MdotM.m_onCloseInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onCloseInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onCloseInterstitial;
				}
				MdotM.m_onCloseInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onCloseInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event MdotMLocationCallback onClickInterstitial
	{
		add
		{
			Delegate obj = MdotM.m_onClickInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onClickInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onClickInterstitial;
				}
				MdotM.m_onClickInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onClickInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = MdotM.m_onClickInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onClickInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onClickInterstitial;
				}
				MdotM.m_onClickInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onClickInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event MdotMLocationCallback onShowInterstitial
	{
		add
		{
			Delegate obj = MdotM.m_onShowInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onShowInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onShowInterstitial;
				}
				MdotM.m_onShowInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onShowInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = MdotM.m_onShowInterstitial;
			MdotMLocationCallback mdotMLocationCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == MdotM.m_onShowInterstitial;
				MdotMLocationCallback mdotMLocationCallback = mdotMLocationCallback2;
				if (!flag)
				{
					mdotMLocationCallback = MdotM.m_onShowInterstitial;
				}
				MdotM.m_onShowInterstitial = mdotMLocationCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = MdotM.m_onShowInterstitial;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "MdotM: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private static void TriggerEvent(MdotMLocationCallback evt, string location)
	{
		if (evt != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: evt.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static bool CheckSessionStarted()
	{
		return _platformBridge != null;
	}

	public static bool IsSupportedOnPlatform()
	{
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.OSXEditor)
		{
			return platform == RuntimePlatform.Android;
		}
		return false;
	}

	public unsafe static void StartSession(string appId)
	{
		//IL_0013: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.OSXEditor)
		{
			object obj = platform - 7;
			if ((nint)obj >= 2)
			{
				if (platform != RuntimePlatform.Android)
				{
					LogError("There's no platform bridge for the current platform.");
					return;
				}
				MdotMAndroid platformBridge = MdotMAndroid.CreatePlugin();
				_platformBridge = platformBridge;
			}
		}
		if (_platformBridge != null)
		{
			bool flag = _003C_003Ec._003C_003E9__25_0 == null;
			bool flag2 = !flag;
			MdotMLocationCallback mdotMLocationCallback = _003C_003Ec._003C_003E9__25_0;
			if (!flag2)
			{
				MdotMLocationCallback mdotMLocationCallback2 = default;
				mdotMLocationCallback2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__25_0));
				_003C_003Ec._003C_003E9__25_0 = mdotMLocationCallback2;
				mdotMLocationCallback = mdotMLocationCallback2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag3 = _003C_003Ec._003C_003E9__25_1 == null;
			bool flag4 = !flag3;
			MdotMLocationCallback mdotMLocationCallback3 = _003C_003Ec._003C_003E9__25_1;
			if (!flag4)
			{
				MdotMLocationCallback mdotMLocationCallback4 = default;
				mdotMLocationCallback4._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__25_1));
				_003C_003Ec._003C_003E9__25_1 = mdotMLocationCallback4;
				mdotMLocationCallback3 = mdotMLocationCallback4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag5 = _003C_003Ec._003C_003E9__25_2 == null;
			bool flag6 = !flag5;
			MdotMLocationCallback mdotMLocationCallback5 = _003C_003Ec._003C_003E9__25_2;
			if (!flag6)
			{
				MdotMLocationCallback mdotMLocationCallback6 = default;
				mdotMLocationCallback6._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__25_2));
				_003C_003Ec._003C_003E9__25_2 = mdotMLocationCallback6;
				mdotMLocationCallback5 = mdotMLocationCallback6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag7 = _003C_003Ec._003C_003E9__25_3 == null;
			bool flag8 = !flag7;
			MdotMLocationCallback mdotMLocationCallback7 = _003C_003Ec._003C_003E9__25_3;
			if (!flag8)
			{
				MdotMLocationCallback mdotMLocationCallback8 = default;
				mdotMLocationCallback8._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__25_3));
				_003C_003Ec._003C_003E9__25_3 = mdotMLocationCallback8;
				mdotMLocationCallback7 = mdotMLocationCallback8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag9 = _003C_003Ec._003C_003E9__25_4 == null;
			bool flag10 = !flag9;
			MdotMLocationCallback mdotMLocationCallback9 = _003C_003Ec._003C_003E9__25_4;
			if (!flag10)
			{
				MdotMLocationCallback mdotMLocationCallback10 = default;
				mdotMLocationCallback10._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__25_4));
				_003C_003Ec._003C_003E9__25_4 = mdotMLocationCallback10;
				mdotMLocationCallback9 = mdotMLocationCallback10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag11 = _003C_003Ec._003C_003E9__25_5 == null;
			bool flag12 = !flag11;
			MdotMLocationCallback mdotMLocationCallback11 = _003C_003Ec._003C_003E9__25_5;
			if (!flag12)
			{
				MdotMLocationCallback mdotMLocationCallback12 = default;
				mdotMLocationCallback12._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStartSession_003Eb__25_5));
				_003C_003Ec._003C_003E9__25_5 = mdotMLocationCallback12;
				mdotMLocationCallback11 = mdotMLocationCallback12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void CacheInterstitial()
	{
		if (CheckSessionStarted())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void ShowInterstitial()
	{
		if (CheckSessionStarted())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static bool HasCachedInterstitial()
	{
		if (CheckSessionStarted())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
		return false;
	}

	public static void SetShouldRequestInterstitial(bool val)
	{
		if (CheckSessionStarted())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void SetShouldDisplayInterstitial(bool val)
	{
		if (CheckSessionStarted())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void SetShouldRequestInterstitialsInFirstSession(bool val)
	{
		if (CheckSessionStarted())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}
}
