using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class SmoothDampVector3
{
	private Vector3 _target;

	private float _smoothTime;

	private Vector3 _value;

	private Vector3 _velocity;

	public Vector3 Target
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009d: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = default;
			Debug.LogWarning(vector, (UnityEngine.Object)(object)this);
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got I
			object obj = value + 8;
			SmoothDampVector3 smoothDampVector = (SmoothDampVector3)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_target = (Vector3)0;
		}
	}

	public float SmoothTime
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+10]");
			return 0f;
		}
		set
		{
		}
	}

	public unsafe Vector3 Value
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = _target;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 8);
			((Vector3*)(nint)vector)->x = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got I
			object obj = value + 24;
			SmoothDampVector3 smoothDampVector = (SmoothDampVector3)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_target = (Vector3)0;
		}
	}

	public unsafe Vector3 Velocity
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = _target;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 24);
			((Vector3*)(nint)vector)->x = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got I
			object obj = value + 36;
			SmoothDampVector3 smoothDampVector = (SmoothDampVector3)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_target = (Vector3)0;
		}
	}

	public unsafe SmoothDampVector3(Vector3 value, float smoothTime)
	{
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected Obj, but got Unknown
		//IL_084c: Expected Obj, but got I4
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected Obj, but got Unknown
		//IL_0869: Expected Obj, but got I4
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected Obj, but got Unknown
		//IL_0886: Expected Obj, but got I4
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_08a3: Expected Obj, but got I4
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected Obj, but got Unknown
		//IL_08c0: Expected Obj, but got I4
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected Obj, but got Unknown
		//IL_08e9: Expected Obj, but got I4
		//IL_0918: Expected I, but got Obj
		//IL_092e: Expected Obj, but got I
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected Obj, but got Unknown
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected Obj, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdd: Expected Obj, but got Unknown
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Expected Obj, but got Unknown
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected Obj, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected Obj, but got Unknown
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Expected Obj, but got Unknown
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d23: Expected Obj, but got Unknown
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected VT, but got Unknown
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d48: Expected VT, but got Unknown
		//IL_0d55: Expected native int or pointer, but got VT
		//IL_0d67: Expected native int or pointer, but got VT
		//IL_0d79: Expected Obj, but got F4
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Expected Obj, but got Unknown
		//IL_0d9e: Expected Obj, but got F4
		//IL_0db5: Expected Obj, but got F4
		//IL_0df2: Expected Obj, but got I4
		//IL_095c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_09b9: Expected Obj, but got I
		//IL_09e3: Expected Obj, but got I
		//IL_0a1a: Expected Obj, but got I
		//IL_0a44: Expected Obj, but got I
		//IL_0a88: Expected Obj, but got I
		//IL_0ab2: Expected Obj, but got I
		//IL_0af6: Expected Obj, but got I
		//IL_0b20: Expected Obj, but got I
		//IL_0b43: Invalid comparison between Obj and F4
		//IL_0063: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0612: Expected I, but got Obj
		//IL_0628: Expected Obj, but got I
		//IL_0091: Expected Obj, but got F4
		//IL_00c6: Expected Obj, but got I
		//IL_0b7d: Expected F4, but got Obj
		//IL_0b78: Expected native int or pointer, but got VT
		//IL_0b92: Expected F4, but got I
		//IL_0b8d: Expected native int or pointer, but got VT
		//IL_0bf4: Expected F4, but got Obj
		//IL_0bef: Expected native int or pointer, but got VT
		//IL_0c09: Expected F4, but got I
		//IL_0c04: Expected native int or pointer, but got VT
		//IL_0c66: Expected F4, but got Obj
		//IL_0c61: Expected native int or pointer, but got VT
		//IL_0c7b: Expected F4, but got I
		//IL_0c76: Expected native int or pointer, but got VT
		//IL_0c88: Expected F4, but got Obj
		//IL_0c83: Expected native int or pointer, but got VT
		//IL_0c9d: Expected F4, but got I
		//IL_0c98: Expected native int or pointer, but got VT
		//IL_056f: Expected I, but got Obj
		//IL_0585: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got F4
		//IL_0112: Invalid comparison between Obj and F4
		//IL_06b4: Expected F4, but got Obj
		//IL_06af: Expected native int or pointer, but got VT
		//IL_06c9: Expected F4, but got I
		//IL_06c4: Expected native int or pointer, but got VT
		//IL_0716: Expected F4, but got Obj
		//IL_0711: Expected native int or pointer, but got VT
		//IL_072b: Expected F4, but got I
		//IL_0726: Expected native int or pointer, but got VT
		//IL_0738: Expected F4, but got Obj
		//IL_0733: Expected native int or pointer, but got VT
		//IL_074d: Expected F4, but got I
		//IL_0748: Expected native int or pointer, but got VT
		//IL_0653: Expected I, but got Obj
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0785: Expected F4, but got Obj
		//IL_0780: Expected native int or pointer, but got VT
		//IL_079a: Expected F4, but got I
		//IL_0795: Expected native int or pointer, but got VT
		//IL_07e7: Expected F4, but got Obj
		//IL_07e2: Expected native int or pointer, but got VT
		//IL_07fc: Expected F4, but got I
		//IL_07f7: Expected native int or pointer, but got VT
		//IL_0809: Expected F4, but got Obj
		//IL_0804: Expected native int or pointer, but got VT
		//IL_081e: Expected F4, but got I
		//IL_0819: Expected native int or pointer, but got VT
		//IL_05b0: Expected I, but got Obj
		//IL_013c: Invalid comparison between Obj and F4
		//IL_0186: Expected Obj, but got F4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0224: Expected Obj, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got F4
		//IL_0283: Expected Obj, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02ae: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_030a: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0357: Expected Obj, but got F4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_0394: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03f5: Expected Obj, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_043d: Expected Obj, but got F4
		//IL_0454: Expected Obj, but got I4
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_047f: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04db: Expected Obj, but got I
		//IL_04f2: Expected Obj, but got I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 212;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 200;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 188;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 176;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 148;
		obj6 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj7 = obj2 + 120;
		obj7 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		float num2 = default;
		float num = num2 * num2;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v33 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v175 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = obj2 + 96;
		object obj10 = obj2 + 84;
		object obj11 = obj2 + 72;
		object obj12 = obj2 + 60;
		object obj13 = obj2 + 48;
		object obj14 = obj2 + 36;
		object obj15 = obj2 + 24;
		object obj16 = obj2 + 12;
		Vector3 vector = (Vector3)(obj2 + 252);
		Vector3 one = Vector3.one;
		Vector3 vector2 = (Vector3)(obj2 + 224);
		((Vector3*)(nint)vector2)->x = vector.x;
		((Vector3*)(nint)vector2)->z = vector.z;
		obj5 = vector.x;
		_ = vector.z;
		object obj17 = obj2 + 108;
		obj17 = vector2.x;
		_ = vector2.z;
		obj4 = vector2.x;
		_ = vector2.z;
		obj = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v61+8]");
		_ = 0;
		obj3 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v61+8]");
		_ = 0;
		object obj18 = 1;
		float num6 = default;
		float num8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+10]");
			int length = ((AnimationCurve)0).length;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v66 (System.Int32)+C]");
			if ((nint)obj19 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+10]");
				int length2 = ((AnimationCurve)0).length;
				object obj20 = obj18 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7525");
				obj6 = vector.x;
				_ = vector.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v54 (UnityEngine.Vector3)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v54 (UnityEngine.Vector3)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+10]");
				int length3 = ((AnimationCurve)0).length;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7525");
				obj7 = vector2.x;
				_ = vector2.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v56 (UnityEngine.Vector3)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v56 (UnityEngine.Vector3)+18]");
				_ = 0;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2) || System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2))
				{
					object obj21 = obj18 + 1;
					obj18 = obj21;
					continue;
				}
				int length4 = ((AnimationCurve)value.z).length;
				object obj22 = obj18 * 28;
				object obj23 = length4 + obj22;
				object obj24 = obj23 + -12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S1_v199+4]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+C]");
				int length5 = ((AnimationCurve)0).length;
				object obj25 = obj18 * 28;
				object obj26 = length5 + obj25;
				object obj27 = obj26 + -12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S1_v205+4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+10]");
				int length6 = ((AnimationCurve)0).length;
				object obj28 = obj18 * 28;
				object obj29 = length6 + obj28;
				object obj30 = obj29 + -12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S1_v211+4]");
				_ = 0;
				int length7 = ((AnimationCurve)value.z).length;
				object obj31 = length7 + 16;
				object obj32 = obj18 * 28;
				object obj33 = obj31 + obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S1_v217+4]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+C]");
				int length8 = ((AnimationCurve)0).length;
				object obj34 = length8 + 16;
				object obj35 = obj18 * 28;
				object obj36 = obj34 + obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S1_v223+4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+10]");
				int length9 = ((AnimationCurve)0).length;
				object obj37 = length9 + 16;
				object obj38 = obj18 * 28;
				object obj39 = obj37 + obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S1_v229+4]");
				_ = 0;
				int length10 = ((AnimationCurve)value.z).length;
				object obj40 = obj18 * 28;
				object obj41 = length10 + obj40;
				object obj42 = obj41 + -12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S1_v235+C]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+C]");
				int length11 = ((AnimationCurve)0).length;
				object obj43 = obj18 * 28;
				object obj44 = length11 + obj43;
				object obj45 = obj44 + -12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S1_v241+C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+10]");
				int length12 = ((AnimationCurve)0).length;
				object obj46 = obj18 * 28;
				object obj47 = length12 + obj46;
				object obj48 = obj47 + -12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ S1_v247+C]");
				_ = 0;
				int length13 = ((AnimationCurve)value.z).length;
				object obj49 = length13 + 16;
				object obj50 = obj18 * 28;
				object obj51 = obj49 + obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S1_v253+8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+C]");
				int length14 = ((AnimationCurve)0).length;
				object obj52 = length14 + 16;
				object obj53 = obj18 * 28;
				object obj54 = obj52 + obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ S1_v259+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+10]");
				int length15 = ((AnimationCurve)0).length;
				object obj55 = length15 + 16;
				object obj56 = obj18 * 28;
				object obj57 = obj55 + obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S1_v265+8]");
				_ = 0;
				float num5 = num2 - (float)obj6;
				object obj58 = obj7 - obj6;
				num6 = num5 / (float)obj58;
				float num7 = num6 * num6;
				num8 = num7;
				break;
			}
			num8 = num;
			break;
		}
		object obj59 = obj * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj60 = num9 * 0;
		object obj61 = obj59 + obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		object obj62 = num10 * 0;
		object obj63 = obj61 + obj62;
		object obj64 = obj3 * obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		object obj65 = num11 * 0;
		object obj66 = obj64 + obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		object obj67 = num12 * 0;
		object obj68 = obj66 + obj67;
		object obj69 = obj63 + obj68;
		object obj70 = obj4 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+4]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+4]");
		object obj71 = num13 * 0;
		object obj72 = obj70 + obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		object obj73 = num14 * 0;
		object obj74 = obj72 + obj73;
		object obj75 = obj69 + obj74;
		object obj76 = obj5 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
		object obj77 = num15 * 0;
		object obj78 = obj76 + obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		object obj79 = num16 * 0;
		object obj80 = obj78 + obj79;
		object obj81 = obj75 + obj80;
		if (obj81 == (object)0f)
		{
			nint num17 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v130 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj82 = (nint)0 & (nint)0x200;
			if (obj82 != null)
			{
				nint num18 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v135 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one2 = Vector3.one;
			return;
		}
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num19 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v88 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj83 = (nint)0 & (nint)0x200;
		if (obj83 != null)
		{
			nint num20 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v125 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj17;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v61+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		float num21 = 6f * num8;
		float num22 = 6f * num6;
		float angle = num21 - num22;
		Quaternion quaternion = Quaternion.AngleAxis(angle, vector);
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		float num23 = 3f * num8;
		float num24 = 4f * num6;
		float num25 = num23 - num24;
		float angle2 = num25 + 1f;
		Quaternion quaternion2 = Quaternion.AngleAxis(angle2, vector);
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Vector3 vector5 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v38+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj11;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v42+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		Vector3 vector7 = vector2 - vector;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj13;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v46+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		float num26 = -6f * num8;
		float num27 = 6f * num6;
		float angle3 = num26 + num27;
		Quaternion quaternion3 = Quaternion.AngleAxis(angle3, vector);
		((Vector3*)(nint)vector2)->x = (float)obj12;
		Vector3 vector9 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v44+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj14;
		Vector3 vector10 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v48+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		Vector3 vector11 = vector2 - vector;
		obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj16;
		Vector3 vector12 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v52+8]");
		((Vector3*)(nint)vector12)->z = 0f;
		float num28 = 3f * num8;
		float num29 = 2f * num6;
		float angle4 = num28 - num29;
		Quaternion quaternion4 = Quaternion.AngleAxis(angle4, vector);
		((Vector3*)(nint)vector2)->x = (float)obj15;
		Vector3 vector13 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v50+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector14 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector14)->z = 0f;
		Vector3 vector15 = vector2 - vector;
	}

	public unsafe void Update()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Ref, but got Unknown
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00d0: Expected F4, but got I
		//IL_00d0: Expected F4, but got VT
		//IL_00d0: Expected F4, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		ref float currentVelocity = ref *(float*)(this + 20);
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v2 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S4_v7 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+10]");
		nint num3 = 0;
		Vector3 target = _target;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+C]");
		float num4 = Mathf.SmoothDampAngle(num3, (float)target, ref currentVelocity, 0f);
		object obj2 = num4 & 0x7FFFFFFF;
		if ((nint)obj2 > 2139095040)
		{
		}
	}

	public override string ToString()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got VT
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 8;
		obj = _target;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj3 = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+10]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+C]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		object arg = default;
		object arg2 = default;
		return string.Format((IFormatProvider)(object)"[SmoothDampFloat: t={0}, v={1}, time={2}]", format, arg, arg2);
	}
}
