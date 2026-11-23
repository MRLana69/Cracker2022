using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve>
{
	protected unsafe override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
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
		//IL_0186: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 112;
		Keyframe[] keys = model.keys;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(obj + 88);
		fsBaseConverter2.SerializeMember<Keyframe[]>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "keys", keys);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj + 48);
		fsResult fsResult3 = (fsResult)(obj + 40);
		fsResult fsResult4 = fsResult2 + fsResult3;
		WrapMode preWrapMode = model.preWrapMode;
		fsBaseConverter fsBaseConverter3 = (fsBaseConverter)(obj + 72);
		fsBaseConverter3.SerializeMember<WrapMode>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "preWrapMode", preWrapMode);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		fsResult fsResult5 = (fsResult)(obj + 32);
		fsResult fsResult6 = (fsResult)(obj + 24);
		fsResult fsResult7 = fsResult5 + fsResult6;
		WrapMode postWrapMode = model.postWrapMode;
		fsBaseConverter fsBaseConverter4 = (fsBaseConverter)(obj + 56);
		fsBaseConverter4.SerializeMember<WrapMode>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "postWrapMode", postWrapMode);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		fsResult fsResult8 = (fsResult)(obj + 16);
		fsResult fsResult9 = (fsResult)(obj + 8);
		fsResult fsResult10 = fsResult8 + fsResult9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		fsResult fsResult11 = default;
		((fsResult*)(nint)fsResult11)->_success = false;
		return fsResult11;
	}

	protected unsafe override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Ref, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_006f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		Keyframe[] keys = model.keys;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(obj + 88);
		fsBaseConverter2.DeserializeMember<Keyframe[]>((Dictionary<string, fsData>)(object)this, (Type)(object)data, "keys", out *(Keyframe[]*)(obj + 124));
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj + 48);
		fsResult fsResult3 = (fsResult)(obj + 40);
		fsResult fsResult4 = fsResult2 + fsResult3;
		AnimationCurve obj3 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
		obj3.keys = (Keyframe[])0;
		WrapMode preWrapMode = model.preWrapMode;
		throw new NullReferenceException();
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		AnimationCurve animationCurve = default;
		animationCurve._002Ector();
		return animationCurve;
	}
}
