using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class Bounds_DirectConverter : fsDirectConverter<Bounds>
{
	protected unsafe override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected VT, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected VT, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected VT, but got Unknown
		//IL_001c: Expected Ref, but got VT
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected VT, but got Unknown
		//IL_00b7: Expected native int or pointer, but got VT
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected VT, but got Unknown
		//IL_00eb: Expected native int or pointer, but got VT
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 144);
		_ = model.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [model @ L2 (UnityEngine.Bounds)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+80]");
		_ = 0;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(fsResult2 + 96);
		Vector3 value = (Vector3)(fsResult2 + 48);
		fsBaseConverter2.SerializeMember<Vector3>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "center", value);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+60]");
		_ = 0;
		fsResult fsResult3 = fsResult2 + 40;
		fsResult fsResult4 = fsResult2 + 32;
		fsResult fsResult5 = fsResult3 + fsResult4;
		Vector3 size = ((Bounds*)model)->size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+80]");
		_ = 0;
		fsBaseConverter fsBaseConverter3 = (fsBaseConverter)(fsResult2 - -64);
		Vector3 value2 = (Vector3)(fsResult2 + 16);
		fsBaseConverter3.SerializeMember<Vector3>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "size", value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
		((fsResult*)(nint)fsResult2)->_success = false;
		fsResult fsResult6 = fsResult2 + 8;
		fsResult fsResult7 = fsResult6 + fsResult2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+80]");
		fsResult fsResult8 = default;
		((fsResult*)(nint)fsResult8)->_success = false;
		return fsResult8;
	}

	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [model @ L3 (UnityEngine.Bounds&)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		throw new NullReferenceException();
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object result = default;
		return result;
	}
}
