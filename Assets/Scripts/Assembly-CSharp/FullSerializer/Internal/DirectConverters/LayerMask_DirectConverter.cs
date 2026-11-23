using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class LayerMask_DirectConverter : fsDirectConverter<LayerMask>
{
	protected unsafe override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_007c: Expected native int or pointer, but got VT
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected VT, but got Unknown
		//IL_0028: Expected native int or pointer, but got VT
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 48);
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(fsResult2 + 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+28]");
		fsBaseConverter2.SerializeMember<int>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "value", 0);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+10]");
		((fsResult*)(nint)fsResult2)->_success = false;
		fsResult fsResult3 = fsResult2 + 8;
		fsResult fsResult4 = fsResult3 + fsResult2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+20]");
		fsResult fsResult5 = default;
		((fsResult*)(nint)fsResult5)->_success = false;
		return fsResult5;
	}

	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 48);
		_ = model;
		throw new NullReferenceException();
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object result = default;
		return result;
	}
}
