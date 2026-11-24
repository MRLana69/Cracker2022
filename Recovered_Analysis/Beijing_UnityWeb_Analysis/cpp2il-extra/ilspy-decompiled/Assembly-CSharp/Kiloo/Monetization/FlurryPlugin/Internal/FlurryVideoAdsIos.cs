using System;
using Cpp2ILInjected;
using Kiloo.Monetization.FacebookAds;
using UnityEngine;

namespace Kiloo.Monetization.FlurryPlugin.Internal;

public class FlurryVideoAdsIos : MonoBehaviour, IFlurryVideoAds
{
	private const string BRIDGE_DELEGATE_GAMEOBJECT_NAME = "FlurryAdsBridgeReceiver";

	private static bool _initialized;

	private static GameObject _callbackReceiver;

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
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAdsIos);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
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
		if (msg != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	private void LogWarning(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"FlurryVideoAdsIOS: ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	private void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public static FlurryVideoAdsIos CreatePlugin()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_025a: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0102: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_0148: Expected I, but got Obj
		//IL_02a3: Expected Obj, but got I
		//IL_02b9: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I
		//IL_0164: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_01cd: Expected I, but got Obj
		//IL_01ba: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			nint num = (nint)typeof(FlurryVideoAdsAndroid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v11 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAdsAndroid);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v47 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)FlurryVideoAdsAndroid._callbackReceiver).FindKernel((string)null) != 0)
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"FlurryAdsBridgeReceiver";
			nint num5 = (nint)typeof(FlurryVideoAdsAndroid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v24 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			nint num6 = (nint)typeof(FlurryVideoAdsAndroid);
			if (!flag)
			{
				nint num7 = (nint)typeof(FlurryVideoAdsAndroid);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v40 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num6 = (nint)typeof(FlurryVideoAdsAndroid);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num6 = (nint)typeof(FlurryVideoAdsAndroid);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ L0_v7 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+5C]");
			object obj4 = (nint)0 + (nint)8;
			obj4 = gameObject;
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)FlurryVideoAdsAndroid._callbackReceiver).Exec();
			return (FlurryVideoAdsIos)(object)FlurryVideoAdsAndroid._callbackReceiver.AddComponent<FlurryVideoAdsAndroid>();
		}
		return null;
	}

	public void Initialize()
	{
		CancelInvoke();
	}

	public void FetchAd(string adSpace)
	{
	}

	public bool IsReady(string adSpace)
	{
		return false;
	}

	public void DisplayAd(string adSpace)
	{
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAdsIos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) == 0)
		{
			bool flag = Ready(adSpace);
			nint num3 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(FlurryVideoAdsIos);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v22 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		else
		{
			((FlurryVideoAdsIos)null).LogWarning("ERROR: Calling FetchAd before initializing", (UnityEngine.Object)null);
		}
	}

	public void EnableDebugLogs()
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
		if ((nint)dataPath != 8)
		{
			return;
		}
		nint num = (nint)typeof(FlurryVideoAdsIos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v32 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
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
		nint num5 = (nint)typeof(FlurryVideoAdsIos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v20 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v26 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_initialized = true;
	}

	public void EnableTestAds()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAdsIos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void InvokeHandlerIfNotNull(FlurryAdsCallback handler, string message)
	{
	}

	private bool Ready(string adSpace)
	{
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAdsIos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) == 0)
		{
			bool flag = ((FacebookAdProvider)null).HasCachedInterstitial(adSpace);
		}
		else
		{
			((FlurryVideoAdsIos)null).LogWarning("ERROR: Calling IsReady before initializing", (UnityEngine.Object)null);
		}
		return false;
	}

	private void PresentWithViewController(string adSpace)
	{
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAdsIos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) == 0)
		{
			bool flag = Ready(adSpace);
		}
		((FlurryVideoAdsIos)null).LogWarning("ERROR: Calling DisplayAd before initializing", (UnityEngine.Object)null);
	}

	private void callback_didFetchAd(string adSpace)
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

	private void callback_willPresent(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
	}

	private void callback_didRender(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
	}

	private void callback_willDismiss(string adSpace)
	{
	}

	private void callback_didDismiss(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9D9F");
	}

	private void callback_didRecieveClick(string adSpace)
	{
	}

	private void callback_willLeaveApplication(string adSpace)
	{
	}

	private void callback_videoDidFinish(string adSpace)
	{
	}

	private void callback_adError(string error)
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

	private static void _flurryadsplugin_initWithSpace()
	{
	}

	private static void _flurryadsplugin_fetchAd(string adSpace)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAdsIos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private static bool _flurryadsplugin_ready(string adSpace)
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (FlurryVideoAds.IsSupportedOnPlatform())
		{
			nint num3 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			bool result = default;
			return result;
		}
		return false;
	}

	private static void _flurryadsplugin_presentWithViewController(string adSpace)
	{
	}

	private static void _flurryadsplugin_enableTestAds(bool enable)
	{
	}

	private static void _flurryadsplugin_enableDebugLogs(bool enable)
	{
	}
}
