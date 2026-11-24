using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Pickups.Picker.Pickers;
using UnityEngine;

namespace SYBO.Subway.Utilities;

public class PlaceholderPrefab : MonoBehaviour, IPrefabBehaviour
{
	private TrackObject[] _trackObjects;

	private Selector[] _selectors;

	public TrackObject[] TrackObjects
	{
		get
		{
			//IL_000d: Expected Obj, but got I4
			((BasePicker)(object)this).MaybeChooseSpawnPoint((List<PickupSpawnPoint>)null);
			return (TrackObject[])1;
		}
	}

	public Selector[] Selectors => (Selector[])(object)_trackObjects;

	public void Initialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Expected Obj, but got I4
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_0488: Expected Obj, but got I4
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_00a8: Expected I, but got Obj
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_04aa: Expected I, but got Obj
		//IL_04c0: Expected Obj, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01b4: Expected I, but got Obj
		//IL_0515: Expected Obj, but got I4
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Selector[] selectors = _selectors;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Utilities.PlaceholderPrefab)+1C]");
		object obj5 = selectors - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Dictionary<string, string>.KeyCollection keys = ((Dictionary<string, string>)(object)this).Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @821F");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		object obj11 = default;
		object obj15 = default;
		DebugSettings debugSettings = default;
		object obj21 = default;
		object obj23 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v78 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v149 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			object obj8 = EnvironmentKind.All + 12;
			object obj9 = 0;
			object obj10;
			while (true)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
				{
					obj10 = obj11;
					break;
				}
				object obj12 = EnvironmentKind.All + 16;
				object obj13 = obj9 << 2;
				object obj14 = obj12 + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				bool flag = obj15 == null;
				bool flag2 = !flag;
				obj10 = obj14;
				if (flag2)
				{
					break;
				}
				object obj16 = obj9 + 1;
				obj9 = obj16;
			}
			nint num3 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v98 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num4 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v126 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ L0_v12+8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v104+8]");
			bool flag3;
			if (num5 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ L0_v12+C]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v104+C]");
				flag3 = num6 == 0;
			}
			else
			{
				flag3 = false;
			}
			object obj18 = (flag3 ? 1 : 0) ^ 1;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj19 = debugSettings + 16;
				object obj20 = obj21 << 2;
				object obj22 = obj19 + obj20;
				obj22 = obj10;
			}
			obj21 = obj23 + 1;
		}
		object obj24 = obj4 + 4;
		object obj25 = obj24 + 1;
		obj24 = obj25;
		object obj26 = obj25 << 2;
		object obj27 = obj4 + obj26;
		obj27 = 145;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj28 = (nint)0 << 2;
			object obj29 = obj4 + obj28;
			if ((nint)obj29 == 145)
			{
				object obj30 = obj4 + 4;
				if ((nint)obj30 > -1)
				{
					object obj31 = obj30 + -1;
					obj30 = obj31;
				}
				goto IL_058d;
			}
		}
		object obj32 = default;
		if (obj32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_058d;
		IL_058d:
		debugSettings.ValidateEnvironmentKinds();
	}

	public PlaceholderPrefab()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		object obj = this + 12;
		TrackObject[] componentsInChildren = GetComponentsInChildren<TrackObject>(includeInactive: true);
		obj = componentsInChildren;
		object obj2 = this + 16;
		Selector[] componentsInChildren2 = GetComponentsInChildren<Selector>(includeInactive: true);
		obj2 = componentsInChildren2;
	}
}
