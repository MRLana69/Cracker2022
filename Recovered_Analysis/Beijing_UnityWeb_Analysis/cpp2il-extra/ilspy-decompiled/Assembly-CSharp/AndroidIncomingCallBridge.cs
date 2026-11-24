using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;
using UnityEngine.Rendering;
using WordHunt;

public class AndroidIncomingCallBridge : MonoBehaviour
{
	public delegate void IncomingCallEvent(string state);

	private IncomingCallEvent m_onPhoneStateChanged;

	private const string CALLBACK_RECEIVER_NAME = "IncomingCallReceiverBridge";

	public event IncomingCallEvent onPhoneStateChanged
	{
		add
		{
			//IL_01be: Expected I, but got Obj
			//IL_01d4: Expected Obj, but got I
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0203: Expected Obj, but got I
			//IL_0061: Expected I4, but got Obj
			//IL_00b5: Expected I, but got Obj
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected Obj, but got Unknown
			//IL_0109: Expected I4, but got Obj
			//IL_0109: Expected Obj, but got I
			//IL_0149: Expected Obj, but got I
			//IL_0152: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I
			//IL_0195: Expected I4, but got Obj
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)this.m_onPhoneStateChanged).FindKernel((string)null) != 0)
			{
				((Renderer)(object)this.m_onPhoneStateChanged).shadowCastingMode = (ShadowCastingMode)value;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AndroidIncomingCallBridge)+10]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AndroidIncomingCallBridge)+10]");
				((PickupDefault)0).IsActive = (byte)(int)value != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AndroidIncomingCallBridge)+14]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AndroidIncomingCallBridge)+14]");
				object obj3 = (nint)0 + (nint)12;
				object obj4 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AndroidIncomingCallBridge)+14]");
					object obj5 = (nint)0 + (nint)16;
					object obj6 = obj4 << 2;
					object obj7 = obj5 + obj6;
					((Renderer)obj7).shadowCastingMode = (ShadowCastingMode)value;
					object obj8 = obj4 + 1;
					obj4 = obj8;
				}
			}
			object obj9 = value & 1;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPhoneStateChanged;
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

	public static AndroidIncomingCallBridge CreatePlugin()
	{
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_01b4: Expected VT, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_00dd: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (DailyLetterPickupManager.instance != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"DailyLetterPickupManager";
			DailyLetterPickupManager instance = gameObject.AddComponent<DailyLetterPickupManager>();
			DailyLetterPickupManager.instance = instance;
			DailyLetterPickupManager instance2 = DailyLetterPickupManager.instance;
			nint num3 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v15 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v25 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool letter = WordHuntManager.IsDailyWordComplete();
			instance2.letter = (letter ? '\u0001' : '\0');
			int layer = gameObject.layer;
			HierarchyUtility.ReparentByHierarchyPathType((Transform)layer, HierarchyPathType.Dynamic, (Vector3)0);
			int layer2 = gameObject.layer;
			((HierarchyUtility)layer2)._002Ector();
		}
		return (AndroidIncomingCallBridge)(object)DailyLetterPickupManager.instance;
	}

	public void Init()
	{
		CancelInvoke();
	}

	private void _callback_onAudioStateChanged(string isModeNormal)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_onPhoneStateChanged;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)isModeNormal);
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

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		if (msg.m_firstChar != '\0')
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"AndroidIncomingCallBridge: ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
