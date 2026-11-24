using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway.Level;
using SYBO.Subway.Utilities;
using UnityEngine;

namespace SYBO.Subway.Managers;

public class DemoVideoModeManager
{
	public const string DEMO_VIDEO_MODE_IS_ENABLED = "DEMO_VIDEO_MODE_IS_ENABLED";

	public static bool IsEnabled
	{
		get
		{
			//IL_00d4: Expected Obj, but got I
			//IL_00e4: Expected Obj, but got I
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected Obj, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected Obj, but got Unknown
			//IL_0129: Expected Obj, but got I4
			//IL_0132: Expected Obj, but got I4
			//IL_0013: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I
			//IL_005e: Expected Obj, but got I
			//IL_006e: Expected Obj, but got I
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
			bool isQueueEnabled = DebugQueuedEnvironments.IsQueueEnabled;
			object obj6 = (isQueueEnabled ? 1 : 0) + 12;
			object obj7 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				object obj8 = (isQueueEnabled ? 1 : 0) + 16;
				object obj9 = obj7 << 2;
				object obj10 = obj8 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v8 (Il2CppMethodInfo)+C]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S4_v9+60]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v10+48]");
				object obj13 = 0;
				object obj14 = obj13 & 0x7FF;
				object obj15 = obj14 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S5_v7 (should have been resolved before IL gen)");
				object obj16 = obj7 + 1;
				obj7 = obj16;
			}
			bool result = default;
			return result;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			((Validator<>)value)._002Ector();
		}
	}

	public static void RefreshIsEnabled()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0200: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Queue<EnvironmentKind> queue = default;
		object obj = queue + 8;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0xFFF;
		object obj6 = obj5 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S2_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		obj = obj7;
		DebugQueuedEnvironments._environmentQueue = queue;
		nint num2 = (nint)typeof(DebugQueuedEnvironments);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v13 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+5C]");
		object obj8 = (nint)0 + (nint)4;
		obj8 = 0;
		DebugQueuedEnvironments._nextQueueShiftPosZ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		nint num3 = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v39 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item = default;
		list.Add(item);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item2 = default;
		list.Add(item2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item3 = default;
		list.Add(item3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item4 = default;
		list.Add(item4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item5 = default;
		list.Add(item5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item6 = default;
		list.Add(item6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item7 = default;
		list.Add(item7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item8 = default;
		list.Add(item8);
		nint num5 = (nint)typeof(DebugQueuedEnvironments);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v36 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+5C]");
		object obj10 = (nint)0 + (nint)12;
		obj10 = list;
	}

	public DemoVideoModeManager()
	{
		//IL_0073: Expected VT, but got Obj
		//IL_0086: Expected Obj, but got VT
		//IL_003e: Expected Obj, but got I4
		//IL_0047: Expected VT, but got Obj
		//IL_005a: Expected Obj, but got VT
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			SDebug.LogFormat("Demo Video Mode can be toggled in edit-mode only.", null);
		}
		else if (this != null)
		{
			PlayerPrefs.SetString("DEMO_VIDEO_MODE_IS_ENABLED", (string)1);
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((QualitySettingsManager)val).SetQualityLevel(1);
		}
		else
		{
			PlayerPrefs.SetString("DEMO_VIDEO_MODE_IS_ENABLED", null);
			_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((QualitySettingsManager)val2).SetQualityLevel(0);
		}
	}
}
