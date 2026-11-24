using System;
using Cpp2ILInjected;
using UnityEngine;

public class LanguageSelection : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__3_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Strings._003C_003Ec obj = default;
			Strings._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CStart_003Eb__3_0()
		{
		}
	}

	private UIPopupList mList;

	private bool mStarted;

	private void Awake()
	{
		_ = 1;
		CancelInvoke();
	}

	private void Start()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		UIPopupList component = GetComponent<UIPopupList>();
		obj = component;
	}

	private unsafe void OnEnable()
	{
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_025c: Expected I, but got Obj
		//IL_0272: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_020c: Expected I, but got Obj
		//IL_0222: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		mStarted = true;
		OnLocalize();
		UIPopupList uIPopupList = mList;
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<LanguageSelection+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v48 (Il2CppClass<LanguageSelection+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__3_0 == null;
		bool flag2 = !flag;
		EventDelegate.Callback callback = _003C_003Ec._003C_003E9__3_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v25 (Il2CppClass<LanguageSelection+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v42 (Il2CppClass<LanguageSelection+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			EventDelegate.Callback callback2 = default;
			((Delegate)callback2).method_ptr = method_ptr;
			((Delegate)callback2).method = (nint)__ldftn(_003C_003Ec._003CStart_003Eb__3_0);
			object obj3 = callback2 + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v39 (Il2CppClass<LanguageSelection+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = callback2;
			callback = callback2;
		}
		nint num6 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v15 (Il2CppClass<EventDelegate>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v20 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = EventDelegate.Remove(uIPopupList.onChange, callback);
	}

	public void Refresh()
	{
		if (~(mStarted ? 1u : 0u) == 0)
		{
			OnLocalize();
		}
	}

	private void OnLocalize()
	{
		//IL_02a2: Expected I, but got Obj
		//IL_02b8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I4
		//IL_0139: Expected I, but got Obj
		//IL_0214: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I
		//IL_0186: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_0255: Expected I, but got Obj
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_01c7: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mList).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v10 (Il2CppClass<Localization>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v49 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string language = Localization.language;
		if (language == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		nint num5 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v18 (Il2CppClass<Localization>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v45 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string language2 = Localization.language;
		object obj4 = 0;
		while (true)
		{
			UIPopupList uIPopupList = mList;
			if ((nint)obj4 >= (int)language2.m_firstChar)
			{
				break;
			}
			nint num7 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v18 (Il2CppClass<Localization>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v28 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string language3 = Localization.language;
			object obj6 = language3 + 16;
			object obj7 = obj4 << 2;
			object item = obj6 + obj7;
			uIPopupList.items.Add((string)item);
			object obj8 = obj4 + 1;
			obj4 = obj8;
		}
		nint num9 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v32 (Il2CppClass<Localization>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v37 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Localization.Reload();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public LanguageSelection()
	{
		OnLocalize();
	}
}
