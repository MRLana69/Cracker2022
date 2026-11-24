using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Data.Save;
using InApp;

namespace Events;

public static class EventManagerUtils
{
	private static Dictionary<Type, Dictionary<string, object>> _cachedValues;

	public static Dictionary<string, object> GetCachedEventValueDict(Type type)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isFreshInstall = UserSave.isFreshInstall;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		bool flag = (nint)obj7 > -1;
		return (Dictionary<string, object>)flag;
	}

	unsafe static EventManagerUtils()
	{
		//IL_01e8: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0298: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02f4: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0350: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_03ac: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0464: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I
		//IL_0484: Expected Obj, but got I
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_04c0: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I
		//IL_04e0: Expected Obj, but got I
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_051c: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I
		//IL_053c: Expected Obj, but got I
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0578: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected Obj, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_0603: Expected Obj, but got I
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected I4, but got Unknown
		//IL_061e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I
		//IL_005c: Expected I4, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I
		//IL_00c5: Expected I4, but got Obj
		//IL_00e5: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I
		//IL_012e: Expected I4, but got Obj
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_0189: Expected I4, but got Obj
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v17+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v18+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S5_v14 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v22+60]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v23+48]");
		object obj23 = 0;
		object obj24 = obj23 & 0x7FF;
		object obj25 = obj24 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v106 @ S5_v18 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S4_v27+60]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S4_v28+48]");
		object obj28 = 0;
		object obj29 = obj28 & 0x7FF;
		object obj30 = obj29 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v124 @ S5_v22 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S4_v32+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S4_v33+48]");
		object obj33 = 0;
		object obj34 = obj33 & 0x7FF;
		object obj35 = obj34 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v142 @ S5_v26 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S4_v37+60]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S4_v38+48]");
		object obj38 = 0;
		object obj39 = obj38 & 0x7FF;
		object obj40 = obj39 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v160 @ S5_v30 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S4_v42+60]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S4_v43+48]");
		object obj43 = 0;
		object obj44 = obj43 & 0x7FF;
		object obj45 = obj44 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v178 @ S5_v34 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S4_v47+60]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S4_v48+48]");
		object obj48 = 0;
		object obj49 = obj48 & 0x7FF;
		object obj50 = obj49 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v196 @ S5_v38 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S4_v51 (Il2CppMethodInfo)+C]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S4_v52+60]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S4_v53+48]");
		object obj53 = 0;
		object obj54 = obj53 & 0x7FF;
		object obj55 = obj54 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v214 @ S5_v42 (should have been resolved before IL gen)");
		Dictionary<string, int> debugDiscount = default;
		InAppManager._debugDiscount = debugDiscount;
		InAppManager._isRestoredManually = false;
		InAppManager._hasSuccessfullyInitialized = false;
		InAppManager._applicationIsQuiting = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj57 = default;
		object obj56 = obj57 + 16;
		obj56 = 0;
		CallingConvention callingConvention = (CallingConvention)(obj57 + 20);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj56;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		nint num12 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v52 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj58 = (nint)0 + (nint)20;
		obj58 = unmanagedFunctionPointerAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj59 = obj57 + 12;
		obj59 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj59;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute2 = default;
		unmanagedFunctionPointerAttribute2._002Ector(callingConvention);
		nint num13 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v63 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj60 = (nint)0 + (nint)24;
		obj60 = unmanagedFunctionPointerAttribute2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj61 = obj57 + 8;
		obj61 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj61;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute3 = default;
		unmanagedFunctionPointerAttribute3._002Ector(callingConvention);
		nint num14 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v74 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj62 = (nint)0 + (nint)28;
		obj62 = unmanagedFunctionPointerAttribute3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj63 = obj57 + 4;
		obj63 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj63;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute4 = default;
		unmanagedFunctionPointerAttribute4._002Ector(callingConvention);
		nint num15 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v85 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj64 = (nint)0 + (nint)32;
		obj64 = unmanagedFunctionPointerAttribute4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj57 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj57;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute5 = default;
		unmanagedFunctionPointerAttribute5._002Ector(callingConvention);
		nint num16 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v95 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj65 = (nint)0 + (nint)36;
		obj65 = unmanagedFunctionPointerAttribute5;
	}
}
