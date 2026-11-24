using System;
using System.Collections;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Kiloo.Serialization;
using UnityEngine;

namespace Kiloo.Monetization.FlurryPlugin.Internal;

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

	private Action<bool> m_onInitFinished;

	public event FlurryAdsCallback onAdClosedEvent
	{
		add
		{
			//IL_0080: Expected I, but got Obj
			//IL_0096: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(FlurryVideoAdsAndroid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAdsAndroid);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(_initialized ? 1u : 0u) == 0)
			{
				bool flag = native_Ready((string)(object)value);
			}
			((FlurryVideoAdsAndroid)null).LogWarning("ERROR: Calling DisplayAd before initializing", (UnityEngine.Object)null);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onAdClosedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event FlurryAdsCallback onApplicationExitEvent
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onAdClosedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onApplicationExitEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event FlurryAdsCallback onRenderFailedEvent
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onApplicationExitEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onRenderFailedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event FlurryAdsCallback onSpaceDidFailToReceiveAdEvent
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onRenderFailedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onSpaceDidFailToReceiveAdEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event FlurryAdsCallback onSpaceDidReceiveAdEvent
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onSpaceDidFailToReceiveAdEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onSpaceDidReceiveAdEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event FlurryAdsCallback onAdClickedEvent
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onSpaceDidReceiveAdEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onAdClickedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event FlurryAdsCallback onAdOpenedEvent
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onAdClickedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onAdOpenedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 36;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event FlurryAdsCallback onVideoCompletedEvent
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onAdOpenedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 36;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onVideoCompletedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<bool> onInitFinished
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onVideoCompletedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onInitFinished;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 44;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BsonBinaryWriterExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BsonBinaryWriterExtensions.WriteBsonArray((BinaryWriter)(object)context, (IEnumerable)msg);
	}

	private void LogWarning(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"FlurryVideoAdsAndroid: ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	private void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public static FlurryVideoAdsAndroid CreatePlugin()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		string dataPath = Application.dataPath;
		object obj = dataPath - 8;
		if ((nint)dataPath == 8 || ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3))
		{
			return (FlurryVideoAdsAndroid)1;
		}
		return null;
	}

	public void Initialize()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = FlurryVideoAds.onInitFinished;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(FlurryVideoAds);
			if (!flag)
			{
				nint num5 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(FlurryVideoAds);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(FlurryVideoAds);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
			object obj5 = (nint)0 + (nint)36;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	public void FetchAd(string adSpace)
	{
	}

	public bool IsReady(string adSpace)
	{
		//IL_0030: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		object obj = ((KilooSerializer)(object)text).FromJson(adSpace);
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object jsonData = default;
		return (byte)(int)RequestExtensions.WithJsonContent((IRequest)this, jsonData, (IJsonSerializer)(object)"application/json") != 0;
	}

	public void DisplayAd(string adSpace)
	{
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAdsAndroid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsAndroid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) == 0)
		{
			bool flag = native_Ready(adSpace);
		}
		else
		{
			((FlurryVideoAdsAndroid)null).LogWarning("ERROR: Calling FetchAd before initializing", (UnityEngine.Object)null);
		}
	}

	public void EnableTestAds()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01ae: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath != 11)
		{
			return;
		}
		nint num = (nint)typeof(FlurryVideoAdsAndroid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsAndroid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v32 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_callbackReceiver != null)
		{
			return;
		}
		nint num5 = (nint)typeof(FlurryVideoAdsAndroid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v20 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(FlurryVideoAdsAndroid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v26 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_initialized = true;
	}

	public void EnableDebugLogs()
	{
	}

	private void InvokeHandlerIfNotNull(FlurryAdsCallback handler, string message)
	{
	}

	private void callback_onAdClicked(string adSpace)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_onInitFinished;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)adSpace);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 44;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private void callback_onClose(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
	}

	private void callback_onDisplay(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
	}

	private void callback_onAppExit(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
	}

	private void callback_onVideoCompleted(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
	}

	private void callback_onFetched(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
	}

	private void callback_onError(string error)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
	}

	private void callback_onInitFinished(string msg)
	{
		string text = msg.ToLowerInvariant();
		if (text.EndsWith("render"))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
		}
		else if (text.EndsWith("fetch"))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
		}
	}

	private void native_Initialize()
	{
	}

	private void native_FetchAd(string adSpace)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		bool flag = adSpace != "true";
		if (this.m_onInitFinished != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S2_v3 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	private bool native_Ready(string adSpace)
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAdsAndroid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsAndroid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) != 0)
		{
			((FlurryVideoAdsAndroid)null).LogWarning("ERROR: Calling IsReady before initializing", (UnityEngine.Object)null);
		}
		return false;
	}

	private void native_DisplayAd(string adSpace)
	{
	}

	private void native_EnableTestAds(bool enable)
	{
	}

	private void native_enableDebugLogs(bool enable)
	{
	}
}
