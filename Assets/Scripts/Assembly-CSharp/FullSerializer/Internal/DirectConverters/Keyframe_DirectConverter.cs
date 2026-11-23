using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class Keyframe_DirectConverter : fsDirectConverter<Keyframe>
{
	protected unsafe override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected VT, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected VT, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected VT, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected VT, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected VT, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected VT, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected VT, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected VT, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected VT, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected VT, but got Unknown
		//IL_022f: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 176;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(obj + 152);
		fsBaseConverter2.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "time", model.m_Time);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj + 80);
		fsResult fsResult3 = (fsResult)(obj + 72);
		fsResult fsResult4 = fsResult2 + fsResult3;
		fsBaseConverter fsBaseConverter3 = (fsBaseConverter)(obj + 136);
		fsBaseConverter3.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "value", model.m_Value);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		fsResult fsResult5 = (fsResult)(obj - -64);
		fsResult fsResult6 = (fsResult)(obj + 56);
		fsResult fsResult7 = fsResult5 + fsResult6;
		fsBaseConverter fsBaseConverter4 = (fsBaseConverter)(obj + 120);
		fsBaseConverter4.SerializeMember<int>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "tangentMode", 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		fsResult fsResult8 = (fsResult)(obj + 48);
		fsResult fsResult9 = (fsResult)(obj + 40);
		fsResult fsResult10 = fsResult8 + fsResult9;
		fsBaseConverter fsBaseConverter5 = (fsBaseConverter)(obj + 104);
		fsBaseConverter5.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "inTangent", model.m_InTangent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		fsResult fsResult11 = (fsResult)(obj + 32);
		fsResult fsResult12 = (fsResult)(obj + 24);
		fsResult fsResult13 = fsResult11 + fsResult12;
		fsBaseConverter fsBaseConverter6 = (fsBaseConverter)(obj + 88);
		fsBaseConverter6.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "outTangent", model.m_OutTangent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		fsResult fsResult14 = (fsResult)(obj + 16);
		fsResult fsResult15 = (fsResult)(obj + 8);
		fsResult fsResult16 = fsResult14 + fsResult15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		fsResult fsResult17 = default;
		((fsResult*)(nint)fsResult17)->_success = false;
		return fsResult17;
	}

	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 192);
		_ = 0;
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
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object result = default;
		return result;
	}
}
