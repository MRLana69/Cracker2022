using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Extensions;

public static class ComponentExtensions
{
	public static T AddComponent<T>(Component component) where T : Component
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0389: Expected Obj, but got I4
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03bf: Expected Obj, but got I
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_0429: Expected Obj, but got I
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_0475: Expected Obj, but got I
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_0545: Expected Obj, but got I4
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 8;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		nint num = default;
		object obj6 = num + 24;
		object obj7 = obj6;
		object obj8 = obj7;
		object obj9 = obj8 & 0x3FFF;
		object obj10 = obj9 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S2_v5 (should have been resolved before IL gen)");
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v7+8]");
		object obj13 = 0;
		object obj14 = obj13 & 0x3FFF;
		object obj15 = obj14 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v78 @ S3_v6 (should have been resolved before IL gen)");
		object obj16 = obj2 + 48;
		object obj17 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S2_v10+C]");
		object obj18 = 0;
		object obj19 = obj18 & 0x3FFF;
		object obj20 = obj19 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v94 @ S3_v10 (should have been resolved before IL gen)");
		obj4 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v28+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v28+10]");
		_ = 0;
		object obj22 = default;
		while (true)
		{
			object obj21 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj22 == null)
			{
				break;
			}
			object obj23 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			object obj24 = obj6 + 20;
			object obj25 = obj24;
			obj3 = obj2;
			obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj26 = obj5 + 4;
		object obj27 = obj26 + 1;
		obj26 = obj27;
		object obj28 = obj27 << 2;
		object obj29 = obj5 + obj28;
		obj29 = 61;
		object obj30 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @91BB");
		object obj31 = obj16;
		object obj32 = obj16 + 88;
		object obj33 = 0;
		object obj45 = default;
		while (true)
		{
			object obj34 = obj33 & 0xFFFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v44+B2]");
			if ((nint)obj34 < 0)
			{
				object obj35 = obj33 + 1;
				object obj36 = obj35 << 16;
				object obj37 = obj36 >> 16;
				object obj38 = obj33 & 0xFFFF;
				object obj39 = obj38 << 3;
				object obj40 = obj32 + obj39;
				if (obj40 != typeof(IDisposable))
				{
					obj33 = obj37;
					continue;
				}
				object obj41 = obj16 + 188;
				object obj42 = obj38 << 3;
				object obj43 = obj32 + obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S2_v43+4]");
				object obj44 = (nint)0 << 3;
				obj45 = obj41 + obj44;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11C74");
			break;
		}
		object obj46 = obj45 & 0x3FFF;
		object obj47 = obj46 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v316 @ S2_v25 (should have been resolved before IL gen)");
		object obj48 = obj16 + 8;
		obj4 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v42+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v42+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+4]");
			object obj49 = (nint)0 << 2;
			object obj50 = obj5 + obj49;
			if ((nint)obj50 == 61)
			{
				object obj51 = obj5 + 4;
				if ((nint)obj51 > -1)
				{
					object obj52 = obj51 + -1;
					obj51 = obj52;
				}
				goto IL_0584;
			}
		}
		object obj53 = default;
		if (obj53 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0584;
		IL_0584:
		T result = default;
		return result;
	}

	public static T GetOrAdd<T>(Component c) where T : Component
	{
		//IL_001d: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		string tag = c.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x3FFF;
		object obj4 = obj3 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S2_v4 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}
}
