using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class Rect_DirectConverter : fsDirectConverter<Rect>
{
	protected unsafe override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected VT, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected VT, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected VT, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected VT, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected VT, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected VT, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected VT, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01d7: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 144;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(obj + 120);
		fsBaseConverter2.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "xMin", model.m_XMin);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj - -64);
		fsResult fsResult3 = (fsResult)(obj + 56);
		fsResult fsResult4 = fsResult2 + fsResult3;
		fsBaseConverter fsBaseConverter3 = (fsBaseConverter)(obj + 104);
		fsBaseConverter3.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "yMin", model.m_YMin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		fsResult fsResult5 = (fsResult)(obj + 48);
		fsResult fsResult6 = (fsResult)(obj + 40);
		fsResult fsResult7 = fsResult5 + fsResult6;
		fsBaseConverter fsBaseConverter4 = (fsBaseConverter)(obj + 88);
		float value = model.m_Width + model.m_XMin;
		fsBaseConverter4.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "xMax", value);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		fsResult fsResult8 = (fsResult)(obj + 32);
		fsResult fsResult9 = (fsResult)(obj + 24);
		fsResult fsResult10 = fsResult8 + fsResult9;
		fsBaseConverter fsBaseConverter5 = (fsBaseConverter)(obj + 72);
		float value2 = model.m_Height + model.m_YMin;
		fsBaseConverter5.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "yMax", value2);
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

	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 160;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = model;
		throw new NullReferenceException();
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object result = default;
		return result;
	}
}
