using System;
using Cpp2ILInjected;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UnityEngine;

namespace UI.MessageCenter;

public class MessageCenter : MonoBehaviour
{
	private static MessageCenter _instance;

	public static MessageCenter instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (MessageCenter)(object)CloudSaveConfirmationPopupPayload.activePayload__BackingField;
		}
	}

	public unsafe static bool IsInstanced
	{
		get
		{
			//IL_0164: Expected I, but got Obj
			//IL_017a: Expected Obj, but got I
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Expected I, but got Unknown
			//IL_019d: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01b8: Expected I, but got Obj
			//IL_01d3: Expected I, but got Obj
			//IL_01e9: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			if (_instance != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v40 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(MessageCenter);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				MessageCenter messageCenter = default;
				_instance = messageCenter;
				if (_instance != null)
				{
					SDebug.LogFormat("MessageCenter not found in the scene.", null);
				}
			}
			return (byte)(int)_instance != 0;
		}
	}

	private void Awake()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = "";
		CancelInvoke();
	}

	public MessageCenter()
	{
		_instance = this;
	}
}
