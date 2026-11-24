using System;
using Cpp2ILInjected;

namespace SYBO.Common.Utilities;

[Serializable]
public class WeightedObject<T> : IWeighted where T : class
{
	private int _weight;

	private T _object;

	public int Weight
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
			int result = default;
			return result;
		}
	}

	public T Object
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (T)_weight;
		}
	}

	public WeightedObject()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v3+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v4+1C]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v21 @ S2_v4 (should have been resolved before IL gen)");
		object obj9 = this + 8;
		object obj10 = default;
		obj9 = obj10;
	}

	public WeightedObject(T weightedObject, int weight)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = weightedObject;
		_weight = weight;
	}
}
