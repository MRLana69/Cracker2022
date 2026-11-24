using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Common.Utilities;

public class WeightRandomizedContainer<T> where T : class
{
	private class WeightedEntry
	{
		public int AccumulatedWeight;

		public T WeightedObject;

		public WeightedEntry(T weightedObject, int accumulatedWeight)
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected Obj, but got Unknown
			//IL_0044: Expected Obj, but got I
			//IL_005c: Expected Obj, but got I
			//IL_008d: Expected Obj, but got I
			//IL_009d: Expected Obj, but got I
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected Obj, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected Obj, but got Unknown
			//IL_00db: Expected Obj, but got I
			//IL_00eb: Expected Obj, but got I
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected Obj, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected Obj, but got Unknown
			if (accumulatedWeight != 0)
			{
				T weightedObject2 = (T)(accumulatedWeight + WeightedObject);
				WeightedObject = weightedObject2;
				nint num = default;
				object obj = num + 12;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v8+60]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S4_v3+60]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S4_v4+8]");
				object obj6 = 0;
				object obj7 = obj6 & 0x1FFF;
				object obj8 = obj7 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S5_v5 (should have been resolved before IL gen)");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v7+60]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S2_v8+C]");
				object obj11 = 0;
				object obj12 = obj11 & 0x3FFF;
				object obj13 = obj12 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v39 @ S3_v6 (should have been resolved before IL gen)");
			}
		}
	}

	private List<WeightedEntry> _entries;

	private int _accumulatedWeight = 0;

	public bool IsEmpty
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.WeightRandomizedContainer`1<T>)+10]");
			return false;
		}
	}

	public int Count
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+14]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S2_v4 (should have been resolved before IL gen)");
			object obj6 = default;
			return (obj6 == null) ? 1 : 0;
		}
	}

	public void Clear()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01d6: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v3+60]");
		object obj5 = -(-64);
		object obj6 = obj5;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v23 @ S2_v5 (should have been resolved before IL gen)");
		object obj9 = this + 8;
		object obj10 = default;
		obj9 = obj10;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v11+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10+60]");
		object obj14 = -(-64);
		object obj15 = obj14;
		object obj16 = obj15 & 0x3FFF;
		object obj17 = obj16 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S2_v10 (should have been resolved before IL gen)");
		object obj18 = this + 12;
		object obj19 = default;
		obj18 = obj19;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v19+60]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v17+60]");
		object obj23 = -(-64);
		object obj24 = obj23;
		object obj25 = obj24 & 0x3FFF;
		object obj26 = obj25 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v74 @ S2_v15 (should have been resolved before IL gen)");
		object obj27 = this + 16;
		object obj28 = default;
		obj27 = obj28;
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v27+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v24+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v25+48]");
		object obj33 = 0;
		object obj34 = obj33 & 0x3FFF;
		object obj35 = obj34 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v97 @ S2_v19 (should have been resolved before IL gen)");
		object obj36 = this + 20;
		object obj37 = default;
		obj36 = obj37;
	}

	public void Add(T prefab, int weight)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v4+34]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19 @ S3_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v8+8]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v9 (should have been resolved before IL gen)");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S2_v11+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v12+38]");
		object obj14 = 0;
		object obj15 = obj14 & 0x3FFF;
		object obj16 = obj15 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S3_v13 (should have been resolved before IL gen)");
	}

	public T GetRandom(SyboRandom random)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		ref Material performanceRelative = default;
		return (T)((Theme)this).TryGetDevicePerformanceRelativeMaterial((Material)null, out performanceRelative);
	}

	public WeightRandomizedContainer()
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S2_v4 (should have been resolved before IL gen)");
	}
}
