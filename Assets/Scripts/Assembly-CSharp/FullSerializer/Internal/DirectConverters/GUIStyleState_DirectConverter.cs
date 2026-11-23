using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState>
{
	protected unsafe override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_010c: Expected native int or pointer, but got VT
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected VT, but got Unknown
		//IL_0145: Expected native int or pointer, but got VT
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 112);
		Texture2D background = model.background;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(fsResult2 + 96);
		fsBaseConverter2.SerializeMember<Texture2D>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "background", background);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+60]");
		_ = 0;
		fsResult fsResult3 = fsResult2 + 40;
		fsResult fsResult4 = fsResult2 + 32;
		fsResult fsResult5 = fsResult3 + fsResult4;
		Color textColor = model.textColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
		_ = 0;
		object obj2 = fsResult2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+10]");
		obj2 = 0;
		object obj3 = fsResult2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7360");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+30]");
		((fsResult*)(nint)fsResult2)->_success = false;
		fsResult fsResult6 = fsResult2 + 8;
		fsResult fsResult7 = fsResult6 + fsResult2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
		fsResult fsResult8 = default;
		((fsResult*)(nint)fsResult8)->_success = false;
		return fsResult8;
	}

	protected unsafe override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Ref, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_006f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		Texture2D background = model.background;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(obj + 88);
		fsBaseConverter2.DeserializeMember<Texture2D>((Dictionary<string, fsData>)(object)this, (Type)(object)data, "background", out *(Texture2D*)(obj + 124));
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj + 48);
		fsResult fsResult3 = (fsResult)(obj + 40);
		fsResult fsResult4 = fsResult2 + fsResult3;
		GUIStyleState obj3 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
		obj3.background = (Texture2D)0;
		Color textColor = model.textColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		throw new NullReferenceException();
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		GUIStyleState gUIStyleState = default;
		gUIStyleState._002Ector();
		return gUIStyleState;
	}
}
