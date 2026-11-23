using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Monetization.Flurry.Internal;

public class FlurryVideoAdsAndroid : MonoBehaviour, IFlurryVideoAds
{
	private static AndroidJavaObject _plugin;

	private const string CALLBACK_RECEIVER_NAME = "FlurryAdsBridgeReceiver";

	private static bool _initialized;

	private static GameObject _callbackReceiver;

	private const string NATIVE_JAVA_CLASS = "com.kiloo.flurryads.FlurryAdsBridge";

	private const string NATIVE_INITIALIZE = "initialize";

	private const string NATIVE_FETCH = "fetchAd";

	private const string NATIVE_READY = "isReady";

	private const string NATIVE_DISPLAY = "displayAd";

	private const string NATIVE_ENABLETESTADS = "setEnableTestAds";

	private const string NATIVE_ENABLEDEBUG = "setDebugLogsEnabled";

	private FlurryAdsCallback m_onAdClosedEvent;

	private FlurryAdsCallback m_onApplicationExitEvent;

	private FlurryAdsCallback m_onRenderFailedEvent;

	private FlurryAdsCallback m_onSpaceDidFailToReceiveAdEvent;

	private FlurryAdsCallback m_onSpaceDidReceiveAdEvent;

	private FlurryAdsCallback m_onAdClickedEvent;

	private FlurryAdsCallback m_onAdOpenedEvent;

	private FlurryAdsCallback m_onVideoCompletedEvent;

	public event FlurryAdsCallback onAdClosedEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_onAdClosedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			object obj = this + 12;
			Delegate obj2 = this.m_onAdClosedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public event FlurryAdsCallback onApplicationExitEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_onApplicationExitEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			object obj = this + 16;
			Delegate obj2 = this.m_onApplicationExitEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public event FlurryAdsCallback onRenderFailedEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m_onRenderFailedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			object obj = this + 20;
			Delegate obj2 = this.m_onRenderFailedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public event FlurryAdsCallback onSpaceDidFailToReceiveAdEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_onSpaceDidFailToReceiveAdEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			object obj = this + 24;
			Delegate obj2 = this.m_onSpaceDidFailToReceiveAdEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public event FlurryAdsCallback onSpaceDidReceiveAdEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 28;
			Delegate obj2 = this.m_onSpaceDidReceiveAdEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			object obj = this + 28;
			Delegate obj2 = this.m_onSpaceDidReceiveAdEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public event FlurryAdsCallback onAdClickedEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_onAdClickedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			Delegate obj2 = this.m_onAdClickedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public event FlurryAdsCallback onAdOpenedEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 36;
			Delegate obj2 = this.m_onAdOpenedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			Delegate obj2 = this.m_onAdOpenedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public event FlurryAdsCallback onVideoCompletedEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
			Delegate obj2 = this.m_onVideoCompletedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			Delegate obj2 = this.m_onVideoCompletedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	private void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "FlurryVideoAdsAndroid: " + msg;
	}

	private void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public static FlurryVideoAdsAndroid CreatePlugin()
	{
		RuntimePlatform platform = Application.platform;
		bool flag = platform != RuntimePlatform.Android;
		FlurryVideoAdsAndroid result = null;
		if (!flag)
		{
			bool flag2 = _callbackReceiver == null;
			result = null;
			if (flag2)
			{
				if (_plugin == null)
				{
					object[] args = Array.Empty<object>();
					AndroidJavaObject androidJavaObject = default;
					androidJavaObject._002Ector("com.kiloo.flurryads.FlurryAdsBridge", args);
					_plugin = androidJavaObject;
				}
				GameObject gameObject = default;
				gameObject._002Ector("FlurryAdsBridgeReceiver");
				_callbackReceiver = gameObject;
				UnityEngine.Object.DontDestroyOnLoad(_callbackReceiver);
				FlurryVideoAdsAndroid flurryVideoAdsAndroid = _callbackReceiver.AddComponent<FlurryVideoAdsAndroid>();
				result = flurryVideoAdsAndroid;
			}
		}
		return result;
	}

	public void Initialize(string adSpace)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android && _callbackReceiver != null)
		{
			((FlurryVideoAdsAndroid)(object)adSpace).native_Initialize(adSpace);
			_initialized = true;
		}
	}

	public void FetchAd()
	{
		if (~(_initialized ? 1u : 0u) == 0 && !IsReady())
		{
			native_FetchAd();
		}
		else
		{
			LogError("ERROR: Calling FetchAd before initializing");
		}
	}

	public bool IsReady()
	{
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return ((FlurryVideoAdsAndroid)null).native_Ready();
		}
		((FlurryVideoAdsAndroid)null).LogError("ERROR: Calling IsReady before initializing", (UnityEngine.Object)null);
		return false;
	}

	public void DisplayAd()
	{
		if (~(_initialized ? 1u : 0u) == 0 && IsReady())
		{
			native_DisplayAd();
		}
		else
		{
			LogError("ERROR: Calling DisplayAd before initializing");
		}
	}

	public void EnableTestAds()
	{
		((FlurryVideoAdsAndroid)null).native_EnableTestAds(true);
	}

	public void EnableDebugLogs()
	{
		((FlurryVideoAdsAndroid)null).native_enableDebugLogs(true);
	}

	private void InvokeHandlerIfNotNull(FlurryAdsCallback handler, string message)
	{
		if (handler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: handler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void onAdClicked(string adSpace)
	{
		FlurryAdsCallback flurryAdsCallback = this.m_onAdClickedEvent;
		if (this.m_onAdClickedEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void onClose(string adSpace)
	{
		FlurryAdsCallback flurryAdsCallback = this.m_onAdClosedEvent;
		if (this.m_onAdClosedEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void onDisplay(string adSpace)
	{
		FlurryAdsCallback flurryAdsCallback = this.m_onAdOpenedEvent;
		if (this.m_onAdOpenedEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void onAppExit(string adSpace)
	{
		FlurryAdsCallback flurryAdsCallback = this.m_onApplicationExitEvent;
		if (this.m_onApplicationExitEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void onVideoCompleted(string adSpace)
	{
		FlurryAdsCallback flurryAdsCallback = this.m_onVideoCompletedEvent;
		if (this.m_onVideoCompletedEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void onFetched(string adSpace)
	{
		FlurryAdsCallback flurryAdsCallback = this.m_onSpaceDidReceiveAdEvent;
		if (this.m_onSpaceDidReceiveAdEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void onError(string error)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		string text = error.ToLower();
		object obj;
		if (text.Contains("render"))
		{
			obj = this + 20;
		}
		else
		{
			if (!text.Contains("fetch"))
			{
				return;
			}
			obj = this + 24;
		}
		object obj2 = obj;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S0_v10+C] (should have been resolved before IL gen)");
		}
	}

	private void native_Initialize(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void native_FetchAd()
	{
		object[] args = Array.Empty<object>();
		_plugin.Call("fetchAd", args);
	}

	private bool native_Ready()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	private void native_DisplayAd()
	{
		object[] args = Array.Empty<object>();
		_plugin.Call("displayAd", args);
	}

	private void native_EnableTestAds(bool enable)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	private void native_enableDebugLogs(bool enable)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}
}
