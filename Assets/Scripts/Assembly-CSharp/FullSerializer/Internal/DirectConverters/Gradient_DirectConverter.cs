using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class Gradient_DirectConverter : fsDirectConverter<Gradient>
{
	protected unsafe override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
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
		//IL_00fa: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 80;
		GradientAlphaKey[] alphaKeys = model.alphaKeys;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(obj + 56);
		fsBaseConverter2.SerializeMember<GradientAlphaKey[]>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "alphaKeys", alphaKeys);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj + 32);
		fsResult fsResult3 = (fsResult)(obj + 24);
		fsResult fsResult4 = fsResult2 + fsResult3;
		GradientColorKey[] colorKeys = model.colorKeys;
		fsBaseConverter fsBaseConverter3 = (fsBaseConverter)(obj + 40);
		fsBaseConverter3.SerializeMember<GradientColorKey[]>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "colorKeys", colorKeys);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		fsResult fsResult5 = (fsResult)(obj + 16);
		fsResult fsResult6 = (fsResult)(obj + 8);
		fsResult fsResult7 = fsResult5 + fsResult6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		fsResult fsResult8 = default;
		((fsResult*)(nint)fsResult8)->_success = false;
		return fsResult8;
	}

	protected unsafe override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Ref, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_006f: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Ref, but got Unknown
		//IL_00ea: Expected native int or pointer, but got VT
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected VT, but got Unknown
		//IL_011e: Expected native int or pointer, but got VT
		//IL_0139: Expected Obj, but got I
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 80);
		_ = 0;
		GradientAlphaKey[] alphaKeys = model.alphaKeys;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(fsResult2 + 48);
		fsBaseConverter2.DeserializeMember<GradientAlphaKey[]>((Dictionary<string, fsData>)(object)this, (Type)(object)data, "alphaKeys", out *(GradientAlphaKey[]*)(fsResult2 + 76));
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+30]");
		_ = 0;
		fsResult fsResult3 = fsResult2 + 24;
		fsResult fsResult4 = fsResult2 + 16;
		fsResult fsResult5 = fsResult3 + fsResult4;
		Gradient obj2 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+4C]");
		obj2.alphaKeys = (GradientAlphaKey[])0;
		GradientColorKey[] colorKeys = model.colorKeys;
		fsBaseConverter fsBaseConverter3 = (fsBaseConverter)(fsResult2 + 32);
		fsBaseConverter3.DeserializeMember<GradientColorKey[]>((Dictionary<string, fsData>)(object)this, (Type)(object)data, "colorKeys", out *(GradientColorKey[]*)(fsResult2 + 72));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+20]");
		((fsResult*)(nint)fsResult2)->_success = false;
		fsResult fsResult6 = fsResult2 + 8;
		fsResult fsResult7 = fsResult6 + fsResult2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
		fsResult fsResult8 = default;
		((fsResult*)(nint)fsResult8)->_success = false;
		Gradient obj3 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+48]");
		obj3.colorKeys = (GradientColorKey[])0;
		return fsResult8;
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		Gradient gradient = default;
		gradient._002Ector();
		return gradient;
	}
}
