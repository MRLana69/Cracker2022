using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class MinMaxSliderAttribute : PropertyAttribute
{
	public readonly float max;

	public readonly float min;

	public unsafe MinMaxSliderAttribute(float min, float max)
	{
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected VT, but got Unknown
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected VT, but got Unknown
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Expected Obj, but got Unknown
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1f: Expected Obj, but got Unknown
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Expected Obj, but got Unknown
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Expected Obj, but got Unknown
		//IL_0d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Expected Obj, but got Unknown
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected Obj, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Expected Obj, but got Unknown
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected Obj, but got Unknown
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Expected Obj, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Expected Obj, but got Unknown
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected Obj, but got Unknown
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dab: Expected Obj, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected Obj, but got Unknown
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc7: Expected Obj, but got Unknown
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Expected Obj, but got Unknown
		//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de3: Expected Obj, but got Unknown
		//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Expected Obj, but got Unknown
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Expected Obj, but got Unknown
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Expected Obj, but got Unknown
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1b: Expected Obj, but got Unknown
		//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e29: Expected Obj, but got Unknown
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e37: Expected Obj, but got Unknown
		//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected Obj, but got Unknown
		//IL_0e4e: Expected Obj, but got I4
		//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fde: Expected Obj, but got Unknown
		//IL_0b9c: Expected Obj, but got F4
		//IL_0018: Expected native int or pointer, but got VT
		//IL_0026: Expected native int or pointer, but got VT
		//IL_0c67: Expected I, but got Obj
		//IL_0c7d: Expected Obj, but got I
		//IL_0053: Expected native int or pointer, but got VT
		//IL_0065: Expected native int or pointer, but got VT
		//IL_0097: Expected Obj, but got I4
		//IL_0f4a: Expected F4, but got Obj
		//IL_0f45: Expected native int or pointer, but got VT
		//IL_0f5f: Expected F4, but got I
		//IL_0f5a: Expected native int or pointer, but got VT
		//IL_0f6c: Expected F4, but got Obj
		//IL_0f67: Expected native int or pointer, but got VT
		//IL_0f81: Expected F4, but got I
		//IL_0f7c: Expected native int or pointer, but got VT
		//IL_0bf5: Expected Obj, but got F4
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected Obj, but got Unknown
		//IL_0c1a: Expected Obj, but got F4
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected Obj, but got Unknown
		//IL_0c3f: Expected Obj, but got F4
		//IL_00c5: Expected F4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		//IL_00da: Expected F4, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_0107: Expected Obj, but got I4
		//IL_0e8a: Expected F4, but got Obj
		//IL_0e85: Expected native int or pointer, but got VT
		//IL_0e9f: Expected F4, but got I
		//IL_0e9a: Expected native int or pointer, but got VT
		//IL_0eac: Expected F4, but got Obj
		//IL_0ea7: Expected native int or pointer, but got VT
		//IL_0ec1: Expected F4, but got I
		//IL_0ebc: Expected native int or pointer, but got VT
		//IL_0edf: Expected Obj, but got I4
		//IL_0ef7: Expected Obj, but got F4
		//IL_0f13: Expected F4, but got I
		//IL_0ca8: Expected I, but got Obj
		//IL_0135: Expected F4, but got Obj
		//IL_0130: Expected native int or pointer, but got VT
		//IL_014a: Expected F4, but got I
		//IL_0145: Expected native int or pointer, but got VT
		//IL_0177: Expected Obj, but got I4
		//IL_01a5: Expected F4, but got Obj
		//IL_01a0: Expected native int or pointer, but got VT
		//IL_01ba: Expected F4, but got I
		//IL_01b5: Expected native int or pointer, but got VT
		//IL_01e7: Expected Obj, but got I4
		//IL_0215: Expected F4, but got Obj
		//IL_0210: Expected native int or pointer, but got VT
		//IL_022a: Expected F4, but got I
		//IL_0225: Expected native int or pointer, but got VT
		//IL_0257: Expected Obj, but got I4
		//IL_0285: Expected F4, but got Obj
		//IL_0280: Expected native int or pointer, but got VT
		//IL_029a: Expected F4, but got I
		//IL_0295: Expected native int or pointer, but got VT
		//IL_02c7: Expected Obj, but got I4
		//IL_02f5: Expected F4, but got Obj
		//IL_02f0: Expected native int or pointer, but got VT
		//IL_030a: Expected F4, but got I
		//IL_0305: Expected native int or pointer, but got VT
		//IL_0337: Expected Obj, but got I4
		//IL_0365: Expected F4, but got Obj
		//IL_0360: Expected native int or pointer, but got VT
		//IL_037a: Expected F4, but got I
		//IL_0375: Expected native int or pointer, but got VT
		//IL_03c8: Expected I, but got Obj
		//IL_03de: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I4
		//IL_0427: Expected F4, but got Obj
		//IL_0422: Expected native int or pointer, but got VT
		//IL_043c: Expected F4, but got I
		//IL_0437: Expected native int or pointer, but got VT
		//IL_046e: Expected Obj, but got I4
		//IL_0497: Expected F4, but got Obj
		//IL_0492: Expected native int or pointer, but got VT
		//IL_04ac: Expected F4, but got I
		//IL_04a7: Expected native int or pointer, but got VT
		//IL_04de: Expected Obj, but got I4
		//IL_0507: Expected F4, but got Obj
		//IL_0502: Expected native int or pointer, but got VT
		//IL_051c: Expected F4, but got I
		//IL_0517: Expected native int or pointer, but got VT
		//IL_054e: Expected Obj, but got I4
		//IL_0577: Expected F4, but got Obj
		//IL_0572: Expected native int or pointer, but got VT
		//IL_058c: Expected F4, but got I
		//IL_0587: Expected native int or pointer, but got VT
		//IL_05be: Expected Obj, but got I4
		//IL_05e7: Expected F4, but got Obj
		//IL_05e2: Expected native int or pointer, but got VT
		//IL_05fc: Expected F4, but got I
		//IL_05f7: Expected native int or pointer, but got VT
		//IL_062e: Expected Obj, but got I4
		//IL_0657: Expected F4, but got Obj
		//IL_0652: Expected native int or pointer, but got VT
		//IL_066c: Expected F4, but got I
		//IL_0667: Expected native int or pointer, but got VT
		//IL_069e: Expected Obj, but got I4
		//IL_06c7: Expected F4, but got Obj
		//IL_06c2: Expected native int or pointer, but got VT
		//IL_06dc: Expected F4, but got I
		//IL_06d7: Expected native int or pointer, but got VT
		//IL_070e: Expected Obj, but got I4
		//IL_0737: Expected F4, but got Obj
		//IL_0732: Expected native int or pointer, but got VT
		//IL_074c: Expected F4, but got I
		//IL_0747: Expected native int or pointer, but got VT
		//IL_079f: Expected I, but got Obj
		//IL_07b5: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got I4
		//IL_07fe: Expected F4, but got Obj
		//IL_07f9: Expected native int or pointer, but got VT
		//IL_0813: Expected F4, but got I
		//IL_080e: Expected native int or pointer, but got VT
		//IL_0840: Expected Obj, but got I4
		//IL_086e: Expected F4, but got Obj
		//IL_0869: Expected native int or pointer, but got VT
		//IL_0883: Expected F4, but got I
		//IL_087e: Expected native int or pointer, but got VT
		//IL_08b0: Expected Obj, but got I4
		//IL_08de: Expected F4, but got Obj
		//IL_08d9: Expected native int or pointer, but got VT
		//IL_08f3: Expected F4, but got I
		//IL_08ee: Expected native int or pointer, but got VT
		//IL_0920: Expected Obj, but got I4
		//IL_094e: Expected F4, but got Obj
		//IL_0949: Expected native int or pointer, but got VT
		//IL_0963: Expected F4, but got I
		//IL_095e: Expected native int or pointer, but got VT
		//IL_0990: Expected Obj, but got I4
		//IL_09be: Expected F4, but got Obj
		//IL_09b9: Expected native int or pointer, but got VT
		//IL_09d3: Expected F4, but got I
		//IL_09ce: Expected native int or pointer, but got VT
		//IL_0a00: Expected Obj, but got I4
		//IL_0a2e: Expected F4, but got Obj
		//IL_0a29: Expected native int or pointer, but got VT
		//IL_0a43: Expected F4, but got I
		//IL_0a3e: Expected native int or pointer, but got VT
		//IL_0a70: Expected Obj, but got I4
		//IL_0a9e: Expected F4, but got Obj
		//IL_0a99: Expected native int or pointer, but got VT
		//IL_0ab3: Expected F4, but got I
		//IL_0aae: Expected native int or pointer, but got VT
		//IL_0ae0: Expected Obj, but got I4
		//IL_0b0e: Expected F4, but got Obj
		//IL_0b09: Expected native int or pointer, but got VT
		//IL_0b23: Expected F4, but got I
		//IL_0b1e: Expected native int or pointer, but got VT
		//IL_0b71: Expected I, but got Obj
		//IL_0b87: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj + 696);
		Vector3 vector2 = (Vector3)(obj + 668);
		object obj2 = obj + 616;
		object obj3 = obj + 588;
		object obj4 = obj + 560;
		object obj5 = obj + 532;
		object obj6 = obj + 504;
		object obj7 = obj + 476;
		object obj8 = obj + 448;
		object obj9 = obj + 420;
		object obj10 = obj + 392;
		object obj11 = obj + 364;
		object obj12 = obj + 336;
		object obj13 = obj + 308;
		object obj14 = obj + 280;
		object obj15 = obj + 252;
		object obj16 = obj + 224;
		object obj17 = obj + 196;
		object obj18 = obj + 168;
		object obj19 = obj + 140;
		object obj20 = obj + 112;
		object obj21 = obj + 84;
		object obj22 = obj + 56;
		object obj23 = obj + 28;
		object obj24 = obj + 656;
		obj24 = 0;
		_ = 0;
		if (UIColorPicker.mRed == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			((Vector3*)(nint)vector2)->x = 0f;
			((Vector3*)(nint)vector2)->z = 0f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = vector2.x;
			((Vector3*)(nint)vector)->z = vector2.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj2 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj3 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj4 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj5 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj5;
			Vector3 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj6 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj6;
			Vector3 vector7 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj7 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj7;
			Vector3 vector8 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj8 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj8;
			Vector3 vector9 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((Vector3*)(nint)vector9)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AnimationCurve animationCurve = default;
			Keyframe[] keys = default;
			animationCurve.keys = keys;
			nint num = (nint)typeof(UIColorPicker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S0_v220 (Il2CppClass<UIColorPicker>)+5C]");
			object obj25 = (nint)0 + (nint)4;
			obj25 = animationCurve;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			obj9 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj9;
			Vector3 vector10 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj10 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj10;
			Vector3 vector11 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
			((Vector3*)(nint)vector11)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj11 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj11;
			Vector3 vector12 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			((Vector3*)(nint)vector12)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj12 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj12;
			Vector3 vector13 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
			((Vector3*)(nint)vector13)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj13 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj13;
			Vector3 vector14 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
			((Vector3*)(nint)vector14)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj14 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj14;
			Vector3 vector15 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
			((Vector3*)(nint)vector15)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj15 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj15;
			Vector3 vector16 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
			((Vector3*)(nint)vector16)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj16 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj16;
			Vector3 vector17 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+8]");
			((Vector3*)(nint)vector17)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AnimationCurve animationCurve2 = default;
			Keyframe[] keys2 = default;
			animationCurve2.keys = keys2;
			nint num2 = (nint)typeof(UIColorPicker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ S0_v310 (Il2CppClass<UIColorPicker>)+5C]");
			object obj26 = (nint)0 + (nint)8;
			obj26 = animationCurve2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			obj17 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj17;
			Vector3 vector18 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+8]");
			((Vector3*)(nint)vector18)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj18 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj18;
			Vector3 vector19 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+8]");
			((Vector3*)(nint)vector19)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj19 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj19;
			Vector3 vector20 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47+8]");
			((Vector3*)(nint)vector20)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj20 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj20;
			Vector3 vector21 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
			((Vector3*)(nint)vector21)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj21 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj21;
			Vector3 vector22 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v51+8]");
			((Vector3*)(nint)vector22)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v51+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v51+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj22 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj22;
			Vector3 vector23 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v53+8]");
			((Vector3*)(nint)vector23)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v53+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v53+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj23 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj23;
			Vector3 vector24 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v55+8]");
			((Vector3*)(nint)vector24)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v55+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v55+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			obj = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector25 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector25)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AnimationCurve animationCurve3 = default;
			Keyframe[] keys3 = default;
			animationCurve3.keys = keys3;
			nint num3 = (nint)typeof(UIColorPicker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ S0_v400 (Il2CppClass<UIColorPicker>)+5C]");
			object obj27 = (nint)0 + (nint)12;
			obj27 = animationCurve3;
		}
		object obj28 = obj + 644;
		float num4 = PlayerPrefs.GetFloat((string)(object)UIColorPicker.mRed, min);
		float num5 = PlayerPrefs.GetFloat((string)(object)UIColorPicker.mGreen, min);
		float num6 = PlayerPrefs.GetFloat((string)(object)UIColorPicker.mBlue, min);
		obj24 = num4;
		if (max < 0.5f)
		{
			float num7 = max * 2f;
			float num8 = (float)obj24 * num7;
			obj24 = num8;
			object obj29 = obj24 + 4;
			float num9 = (float)obj29 * num7;
			obj29 = num9;
			object obj30 = obj24 + 8;
			float num10 = (float)obj30 * num7;
			obj30 = num10;
		}
		else
		{
			obj2 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v57+8]");
			_ = 0;
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v110 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				nint num12 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v124 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 forward = Vector3.forward;
			obj28 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Vector3 vector26 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector26)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj28;
			Vector3 vector27 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v66+8]");
			((Vector3*)(nint)vector27)->z = 0f;
			float num13 = max * 2f;
			float t = num13 - 1f;
			Vector3 vector28 = Vector3.LerpUnclamped(vector2, vector, t);
			obj24 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			_ = 0;
		}
		((Vector3*)(nint)vector)->x = (float)obj24;
		Vector3 vector29 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v57+8]");
		((Vector3*)(nint)vector29)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj24;
		Vector3 vector30 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v57+8]");
		((Vector3*)(nint)vector30)->z = 0f;
		obj2 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v57+8]");
		_ = 0;
		MinMaxSliderAttribute minMaxSliderAttribute = (MinMaxSliderAttribute)0;
		this.max = 0f;
		minMaxSliderAttribute = (MinMaxSliderAttribute)vector.x;
		_ = vector2.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		this.max = 0f;
		this.min = 1f;
	}
}
