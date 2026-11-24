using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Helpers;
using UI.Popups;
using UI.Screens;
using UnityEngine;

public class FrontScreenNavigation : MonoBehaviour
{
	private void Update()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj = this + 16;
		obj = list;
		_ = 2;
		CancelInvoke();
	}

	public unsafe FrontScreenNavigation()
	{
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected I, but got Unknown
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected Obj, but got Unknown
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Obj, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Obj, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected Obj, but got Unknown
		//IL_000f: Expected Obj, but got I4
		//IL_077c: Expected I, but got Obj
		//IL_0792: Expected Obj, but got I
		//IL_08f9: Expected I, but got Obj
		//IL_0914: Expected I, but got Obj
		//IL_092a: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I4
		//IL_07e2: Expected I, but got Obj
		//IL_0134: Expected I, but got Obj
		//IL_0181: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I4
		//IL_01f7: Expected I, but got Obj
		//IL_0231: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I4
		//IL_0275: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I4
		//IL_02be: Expected I, but got Obj
		//IL_0302: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I4
		//IL_0374: Expected I, but got Obj
		//IL_038a: Expected Obj, but got I
		//IL_03b5: Expected I, but got Obj
		//IL_0402: Expected I, but got Obj
		//IL_0418: Expected Obj, but got I
		//IL_0443: Expected I, but got Obj
		//IL_0490: Expected I, but got Obj
		//IL_04a6: Expected Obj, but got I
		//IL_04d1: Expected I, but got Obj
		//IL_051e: Expected I, but got Obj
		//IL_0534: Expected Obj, but got I
		//IL_055f: Expected I, but got Obj
		//IL_05ac: Expected I, but got Obj
		//IL_05c2: Expected Obj, but got I
		//IL_05ed: Expected I, but got Obj
		//IL_063a: Expected I, but got Obj
		//IL_0650: Expected Obj, but got I
		//IL_067b: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 28);
		object obj2 = obj + 24;
		object obj3 = obj + 20;
		object obj4 = obj + 16;
		object obj5 = obj + 12;
		object obj6 = obj + 8;
		object obj7 = obj + 4;
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23 (System.Boolean)+E]");
		if ((nint)0 != 0 || (!Input.GetKeyDown((string)32) && !Input.GetKeyDown((string)13) && !Input.GetKeyDown((string)274) && !Input.GetKeyDown((string)273) && !Input.GetKeyDown((string)276) && !Input.GetKeyDown((string)275)))
		{
			return;
		}
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v35 (Il2CppClass<System.Type>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v125 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(CelebrationPopup);
		((IntPtr*)num)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num);
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v81 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((UnityEngine.Object)(object)type).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		obj3 = typeof(ConsumablesPopup);
		((IntPtr*)num)->m_value = (void*)(nint)obj3;
		Type type2 = Type.internal_from_handle((IntPtr)num);
		string text2 = ((UnityEngine.Object)(object)type2).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		obj4 = typeof(SettingsPopup);
		((IntPtr*)num)->m_value = (void*)(nint)obj4;
		Type type3 = Type.internal_from_handle((IntPtr)num);
		string text3 = ((UnityEngine.Object)(object)type3).ToString();
		obj5 = typeof(ConsentPopup);
		((IntPtr*)num)->m_value = (void*)(nint)obj5;
		Type type4 = Type.internal_from_handle((IntPtr)num);
		string text4 = ((UnityEngine.Object)(object)type4).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		obj6 = typeof(AgeRestrictionPopup);
		((IntPtr*)num)->m_value = (void*)(nint)obj6;
		Type type5 = Type.internal_from_handle((IntPtr)num);
		string text5 = ((UnityEngine.Object)(object)type5).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		obj7 = typeof(FirstPurchaseBonusPopupScreen);
		((IntPtr*)num)->m_value = (void*)(nint)obj7;
		Type type6 = Type.internal_from_handle((IntPtr)num);
		string text6 = ((UnityEngine.Object)(object)type6).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		obj = typeof(TutorialHoverboardPopup);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type7 = Type.internal_from_handle((IntPtr)num);
		string text7 = ((UnityEngine.Object)(object)type7).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		UnityEngine.Object obj10 = default;
		if (!(obj10 != null))
		{
			return;
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v121 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj12 = default;
		if (!(obj12 != null))
		{
			return;
		}
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v117 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj14 = default;
		if (!(obj14 != null))
		{
			return;
		}
		nint num10 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v73 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v113 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj16 = default;
		if (!(obj16 != null))
		{
			return;
		}
		nint num12 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v80 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v109 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj18 = default;
		if (!(obj18 != null))
		{
			return;
		}
		nint num14 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v87 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v105 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj20 = default;
		if (!(obj20 != null))
		{
			return;
		}
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v94 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v101 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj22 = default;
		if (obj22 != null)
		{
			_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
