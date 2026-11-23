using System;
using Cpp2ILInjected;
using Kiloo.Monetization.Inmobi.Internal;
using UnityEngine;

namespace Kiloo.Monetization.Inmobi;

public static class InmobiPlugin
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static InmobiCallback _003C_003E9__22_0;

		public static InmobiCallback _003C_003E9__22_1;

		public static InmobiCallback _003C_003E9__22_2;

		public static InmobiCallback _003C_003E9__22_3;

		public static InmobiCallback _003C_003E9__22_4;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CInitialize_003Eb__22_0(string obj)
		{
			InmobiCallback onCacheAd = InmobiPlugin.m_onCacheAd;
			if (InmobiPlugin.m_onCacheAd != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CInitialize_003Eb__22_1(string obj)
		{
			InmobiCallback onDismissAd = InmobiPlugin.m_onDismissAd;
			if (InmobiPlugin.m_onDismissAd != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CInitialize_003Eb__22_2(string obj)
		{
			InmobiCallback onFailToLoadAd = InmobiPlugin.m_onFailToLoadAd;
			if (InmobiPlugin.m_onFailToLoadAd != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CInitialize_003Eb__22_3(string obj)
		{
			InmobiCallback willShowAd = InmobiPlugin.m_willShowAd;
			if (InmobiPlugin.m_willShowAd != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void _003CInitialize_003Eb__22_4(string obj)
		{
			InmobiCallback onCompleteIncentive = InmobiPlugin.m_onCompleteIncentive;
			if (InmobiPlugin.m_onCompleteIncentive != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private static IInmobiPlatformBridge _platformBridge;

	private static InmobiCallback m_onCacheAd;

	private static InmobiCallback m_onFailToLoadAd;

	private static InmobiCallback m_onDismissAd;

	private static InmobiCallback m_willShowAd;

	private static InmobiCallback m_onCompleteIncentive;

	public static event InmobiCallback onCacheAd
	{
		add
		{
			Delegate obj = InmobiPlugin.m_onCacheAd;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_onCacheAd;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_onCacheAd;
				}
				InmobiPlugin.m_onCacheAd = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_onCacheAd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = InmobiPlugin.m_onCacheAd;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_onCacheAd;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_onCacheAd;
				}
				InmobiPlugin.m_onCacheAd = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_onCacheAd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event InmobiCallback onFailToLoadAd
	{
		add
		{
			Delegate obj = InmobiPlugin.m_onFailToLoadAd;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_onFailToLoadAd;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_onFailToLoadAd;
				}
				InmobiPlugin.m_onFailToLoadAd = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_onFailToLoadAd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = InmobiPlugin.m_onFailToLoadAd;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_onFailToLoadAd;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_onFailToLoadAd;
				}
				InmobiPlugin.m_onFailToLoadAd = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_onFailToLoadAd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event InmobiCallback onDismissAd
	{
		add
		{
			Delegate obj = InmobiPlugin.m_onDismissAd;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_onDismissAd;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_onDismissAd;
				}
				InmobiPlugin.m_onDismissAd = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_onDismissAd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = InmobiPlugin.m_onDismissAd;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_onDismissAd;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_onDismissAd;
				}
				InmobiPlugin.m_onDismissAd = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_onDismissAd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event InmobiCallback willShowAd
	{
		add
		{
			Delegate obj = InmobiPlugin.m_willShowAd;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_willShowAd;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_willShowAd;
				}
				InmobiPlugin.m_willShowAd = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_willShowAd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = InmobiPlugin.m_willShowAd;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_willShowAd;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_willShowAd;
				}
				InmobiPlugin.m_willShowAd = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_willShowAd;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event InmobiCallback onCompleteIncentive
	{
		add
		{
			Delegate obj = InmobiPlugin.m_onCompleteIncentive;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_onCompleteIncentive;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_onCompleteIncentive;
				}
				InmobiPlugin.m_onCompleteIncentive = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_onCompleteIncentive;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = InmobiPlugin.m_onCompleteIncentive;
			InmobiCallback inmobiCallback2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InmobiPlugin.m_onCompleteIncentive;
				InmobiCallback inmobiCallback = inmobiCallback2;
				if (!flag)
				{
					inmobiCallback = InmobiPlugin.m_onCompleteIncentive;
				}
				InmobiPlugin.m_onCompleteIncentive = inmobiCallback;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InmobiPlugin.m_onCompleteIncentive;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "[Inmobi] " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private static void TriggerEvent(InmobiCallback evt, string data)
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

	public unsafe static void Initialize(string appId)
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
					InmobiAndroid platformBridge = InmobiAndroid.CreatePlugin();
					_platformBridge = platformBridge;
				}
				else
				{
					InmobiIOS platformBridge2 = InmobiIOS.CreatePlugin();
					_platformBridge = platformBridge2;
				}
			}
		}
		if (_platformBridge != null)
		{
			bool flag = _003C_003Ec._003C_003E9__22_0 == null;
			bool flag2 = !flag;
			InmobiCallback inmobiCallback = _003C_003Ec._003C_003E9__22_0;
			if (!flag2)
			{
				InmobiCallback inmobiCallback2 = default;
				inmobiCallback2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CInitialize_003Eb__22_0));
				_003C_003Ec._003C_003E9__22_0 = inmobiCallback2;
				inmobiCallback = inmobiCallback2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag3 = _003C_003Ec._003C_003E9__22_1 == null;
			bool flag4 = !flag3;
			InmobiCallback inmobiCallback3 = _003C_003Ec._003C_003E9__22_1;
			if (!flag4)
			{
				InmobiCallback inmobiCallback4 = default;
				inmobiCallback4._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CInitialize_003Eb__22_1));
				_003C_003Ec._003C_003E9__22_1 = inmobiCallback4;
				inmobiCallback3 = inmobiCallback4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag5 = _003C_003Ec._003C_003E9__22_2 == null;
			bool flag6 = !flag5;
			InmobiCallback inmobiCallback5 = _003C_003Ec._003C_003E9__22_2;
			if (!flag6)
			{
				InmobiCallback inmobiCallback6 = default;
				inmobiCallback6._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CInitialize_003Eb__22_2));
				_003C_003Ec._003C_003E9__22_2 = inmobiCallback6;
				inmobiCallback5 = inmobiCallback6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag7 = _003C_003Ec._003C_003E9__22_3 == null;
			bool flag8 = !flag7;
			InmobiCallback inmobiCallback7 = _003C_003Ec._003C_003E9__22_3;
			if (!flag8)
			{
				InmobiCallback inmobiCallback8 = default;
				inmobiCallback8._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CInitialize_003Eb__22_3));
				_003C_003Ec._003C_003E9__22_3 = inmobiCallback8;
				inmobiCallback7 = inmobiCallback8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			bool flag9 = _003C_003Ec._003C_003E9__22_4 == null;
			bool flag10 = !flag9;
			InmobiCallback inmobiCallback9 = _003C_003Ec._003C_003E9__22_4;
			if (!flag10)
			{
				InmobiCallback inmobiCallback10 = default;
				inmobiCallback10._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CInitialize_003Eb__22_4));
				_003C_003Ec._003C_003E9__22_4 = inmobiCallback10;
				inmobiCallback9 = inmobiCallback10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static void CacheAd(string key, string appId = "")
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
		}
	}

	public static void ShowAd(string key, string appId = "")
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
		}
	}

	public static bool HasCachedAd(string key, string appId = "")
	{
		if (IsInitialized())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
			bool result = default;
			return result;
		}
		return false;
	}
}
