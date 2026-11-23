using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class RectOffset_DirectConverter : fsDirectConverter<RectOffset>
{
	protected unsafe override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected VT, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected VT, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected VT, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected VT, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected VT, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected VT, but got Unknown
		//IL_0217: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 144;
		int bottom = model.bottom;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(obj + 120);
		fsBaseConverter2.SerializeMember<int>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "bottom", bottom);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj - -64);
		fsResult fsResult3 = (fsResult)(obj + 56);
		fsResult fsResult4 = fsResult2 + fsResult3;
		int left = model.left;
		fsBaseConverter fsBaseConverter3 = (fsBaseConverter)(obj + 104);
		fsBaseConverter3.SerializeMember<int>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "left", left);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		fsResult fsResult5 = (fsResult)(obj + 48);
		fsResult fsResult6 = (fsResult)(obj + 40);
		fsResult fsResult7 = fsResult5 + fsResult6;
		int right = model.right;
		fsBaseConverter fsBaseConverter4 = (fsBaseConverter)(obj + 88);
		fsBaseConverter4.SerializeMember<int>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "right", right);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		fsResult fsResult8 = (fsResult)(obj + 32);
		fsResult fsResult9 = (fsResult)(obj + 24);
		fsResult fsResult10 = fsResult8 + fsResult9;
		int top = model.top;
		fsBaseConverter fsBaseConverter5 = (fsBaseConverter)(obj + 72);
		fsBaseConverter5.SerializeMember<int>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "top", top);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		fsResult fsResult11 = (fsResult)(obj + 16);
		fsResult fsResult12 = (fsResult)(obj + 8);
		fsResult fsResult13 = fsResult11 + fsResult12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		fsResult fsResult14 = default;
		((fsResult*)(nint)fsResult14)->_success = false;
		return fsResult14;
	}

	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 160;
		_ = 0;
		_ = 0;
		_ = 0;
		int bottom = model.bottom;
		throw new NullReferenceException();
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		RectOffset rectOffset = default;
		rectOffset._002Ector();
		return rectOffset;
	}
}
