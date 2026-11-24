using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway;
using UnityEngine;

namespace SYBO.Common.Benchmarking;

public class InstantiatedObjectsMetric : BenchmarkMetric<int>
{
	private int _instantiatedObjectsCount;

	private bool _reportObjectNames;

	private StringBuilder _instantiatedObjectsString;

	private List<string> _stringEntries;

	public unsafe InstantiatedObjectsMetric(bool reportObjectNames = false)
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		base.Initialize(reportObjectNames ? 1 : 0);
		nint num = (nint)typeof(GC);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v7 (Il2CppClass<System.GC>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GC);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<System.GC>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool timeZoneName = System.DateTimeParse.GetTimeZoneName(ref *(System.__DTString*)null);
		_instantiatedObjectsCount = (timeZoneName ? 1 : 0);
	}

	public override void Initialize(int initialSampleCount)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj = this + 20;
		obj = stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj2 = this + 24;
		obj2 = list;
		int reportObjectNames = initialSampleCount & 1;
		_reportObjectNames = (byte)reportObjectNames != 0;
	}

	public override void Cleanup()
	{
	}

	private unsafe void PoolManager_OnObjectInstantiated(Transform transform)
	{
		//IL_0066: Expected I4, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		base.Initialize((int)transform);
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v7 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(InstantiatedObjectsMetric.PoolManager_OnObjectInstantiated);
		object obj3 = obj2 + 16;
		obj3 = this;
		Delegate obj4 = ((Delegate)PoolManager.OnObjectInstantiated).CombineImpl(obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action<Transform> onObjectInstantiated = default;
		PoolManager.OnObjectInstantiated = onObjectInstantiated;
	}

	public override void Update(float unscaledDeltaTime)
	{
	}

	public unsafe override void Sample()
	{
		//IL_0094: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5+8]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S2_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v8 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v24 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj7 = default;
		obj7.method_ptr = method_ptr;
		obj7.method = (nint)__ldftn(InstantiatedObjectsMetric.PoolManager_OnObjectInstantiated);
		object obj8 = obj7 + 16;
		obj8 = this;
		Delegate obj9 = ((Delegate)PoolManager.OnObjectInstantiated).RemoveImpl(obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action<Transform> onObjectInstantiated = default;
		PoolManager.OnObjectInstantiated = onObjectInstantiated;
		_instantiatedObjectsCount = 0;
		_instantiatedObjectsString.AppendHelper((string)null);
		throw new IndexOutOfRangeException();
	}

	public override List<string> Serialize()
	{
		//IL_026b: Expected Obj, but got F4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got F4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0299: Expected Obj, but got F4
		//IL_02bc: Expected Obj, but got I
		//IL_0158: Expected I4, but got Obj
		//IL_001a: Expected Obj, but got I
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_018e: Expected I4, but got Obj
		//IL_0081: Expected I, but got Obj
		//IL_02fe: Expected Obj, but got F4
		//IL_01ed: Expected Obj, but got I
		//IL_020c: Expected Obj, but got F4
		//IL_0337: Expected Obj, but got F4
		//IL_0367: Expected Obj, but got I
		//IL_0126: Expected I4, but got Obj
		object obj = 0f;
		object obj2 = obj + 8;
		obj2 = float.MaxValue;
		object obj3 = obj + 4;
		obj3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.InstantiatedObjectsMetric)+8]");
		object obj4 = 0;
		float num = float.MaxValue;
		int num3 = default;
		float num4 = default;
		int num9 = default;
		while (true)
		{
			int num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.InstantiatedObjectsMetric)+8]");
			FPSReportEntry fPSReportEntry = ((List<FPSReportEntry>)0).get_Item(num3);
			num4 += fPSReportEntry.AvgFPS;
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v50 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v65 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num7;
			if (num < fPSReportEntry.AvgFPS)
			{
				num7 = num;
			}
			else
			{
				num = fPSReportEntry.AvgFPS;
				num7 = fPSReportEntry.AvgFPS;
			}
			obj2 = num7;
			float num8 = ((!(fPSReportEntry.AvgFPS > fPSReportEntry.AvgFPS)) ? fPSReportEntry.AvgFPS : fPSReportEntry.AvgFPS);
			obj3 = num8;
			OverflowException value = new OverflowException();
			StringBuilder stringBuilder2 = stringBuilder.AppendLine((string)(object)value);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19+C]");
			object obj6 = -1;
			if (num3 < (nint)obj6)
			{
				CharacterController charactercontroller = Game.Charactercontroller;
				StringBuilder stringBuilder3 = stringBuilder.Append((int)charactercontroller);
			}
			num3 = num9 + 1;
		}
		CharacterController charactercontroller2 = Game.Charactercontroller;
		StringBuilder stringBuilder4 = stringBuilder.Append((int)charactercontroller2);
		StringBuilder stringBuilder5 = stringBuilder.AppendLine("0");
		CharacterController charactercontroller3 = Game.Charactercontroller;
		StringBuilder stringBuilder6 = stringBuilder.Append((int)charactercontroller3);
		StringBuilder stringBuilder7 = stringBuilder.AppendLine("60");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item = default;
		list.Add(item);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.InstantiatedObjectsMetric)+8]");
		object obj7 = 0;
		float num10 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S2_v10+C]");
		float num11 = num10 / 0f;
		obj = num11;
		OverflowException item2 = new OverflowException();
		list.Add((string)(object)item2);
		OverflowException item3 = new OverflowException();
		list.Add((string)(object)item3);
		OverflowException item4 = new OverflowException();
		list.Add((string)(object)item4);
		return list;
	}
}
