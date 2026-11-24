using System;
using Cpp2ILInjected;
using UI.Pages;
using UnityEngine;

public class TweenVolume : UITweener
{
	public float from;

	public float to;

	private AudioSource mSource;

	public AudioSource audioSource
	{
		get
		{
			//IL_0082: Expected I, but got Obj
			//IL_0098: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenVolume)+74]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj2 = this + 116;
				GameObject gameObject = base.gameObject;
				obj2 = gameObject;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenVolume)+74]");
			return (AudioSource)0;
		}
	}

	public float volume
	{
		get
		{
			Transform cachedTransform = ((TweenPosition)this).cachedTransform;
			return ((Camera)(object)cachedTransform).depth;
		}
		set
		{
			Transform cachedTransform = ((TweenPosition)this).cachedTransform;
			((Camera)(object)cachedTransform).depth = value;
		}
	}

	public float value
	{
		get
		{
			return amountPerDelta;
		}
		set
		{
			tweenFactor = value;
		}
	}

	protected unsafe override void OnUpdate(float factor, bool isFinished)
	{
		//IL_07ee: Expected I, but got Obj
		//IL_0804: Expected Obj, but got I
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected VT, but got Unknown
		//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected Obj, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af9: Expected Obj, but got Unknown
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected Obj, but got Unknown
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected Obj, but got Unknown
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected Obj, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected Obj, but got Unknown
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected Obj, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected Obj, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5b: Expected Obj, but got Unknown
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Expected Obj, but got Unknown
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected Obj, but got Unknown
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Expected Obj, but got Unknown
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b93: Expected Obj, but got Unknown
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected Obj, but got Unknown
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Expected Obj, but got Unknown
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected Obj, but got Unknown
		//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Expected Obj, but got Unknown
		//IL_0bd7: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0834: Expected Obj, but got I
		//IL_085f: Expected I, but got Obj
		//IL_0875: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0c04: Expected Obj, but got F4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0112: Expected VT, but got I
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_04fc: Expected I, but got Obj
		//IL_0512: Expected Obj, but got I
		//IL_021c: Expected I, but got Obj
		//IL_0124: Expected F4, but got Obj
		//IL_011f: Expected native int or pointer, but got VT
		//IL_0136: Expected F4, but got I
		//IL_0131: Expected native int or pointer, but got VT
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014e: Expected Obj, but got F4
		//IL_016d: Expected VT, but got I
		//IL_017a: Expected F4, but got Obj
		//IL_0175: Expected native int or pointer, but got VT
		//IL_018c: Expected F4, but got I
		//IL_0187: Expected native int or pointer, but got VT
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got F4
		//IL_01c3: Expected VT, but got I
		//IL_099a: Expected F4, but got Obj
		//IL_0995: Expected native int or pointer, but got VT
		//IL_09af: Expected F4, but got I
		//IL_09aa: Expected native int or pointer, but got VT
		//IL_09df: Expected VT, but got F4
		//IL_09ec: Expected F4, but got Obj
		//IL_09e7: Expected native int or pointer, but got VT
		//IL_09fe: Expected F4, but got I
		//IL_09f9: Expected native int or pointer, but got VT
		//IL_026a: Expected VT, but got F4
		//IL_0278: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_01d5: Expected F4, but got Obj
		//IL_01d0: Expected native int or pointer, but got VT
		//IL_01e7: Expected F4, but got I
		//IL_01e2: Expected native int or pointer, but got VT
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got F4
		//IL_05a3: Expected F4, but got Obj
		//IL_059e: Expected native int or pointer, but got VT
		//IL_05b8: Expected F4, but got I
		//IL_05b3: Expected native int or pointer, but got VT
		//IL_05c5: Expected VT, but got Obj
		//IL_05d6: Expected F4, but got Obj
		//IL_05d1: Expected native int or pointer, but got VT
		//IL_05eb: Expected F4, but got I
		//IL_05e6: Expected native int or pointer, but got VT
		//IL_05f4: Expected Obj, but got VT
		//IL_053d: Expected I, but got Obj
		//IL_08b1: Expected F4, but got Obj
		//IL_08ac: Expected native int or pointer, but got VT
		//IL_08c6: Expected F4, but got I
		//IL_08c1: Expected native int or pointer, but got VT
		//IL_08f6: Expected VT, but got F4
		//IL_0903: Expected F4, but got Obj
		//IL_08fe: Expected native int or pointer, but got VT
		//IL_0915: Expected F4, but got I
		//IL_0910: Expected native int or pointer, but got VT
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected Obj, but got Unknown
		//IL_0644: Expected F4, but got Obj
		//IL_063f: Expected native int or pointer, but got VT
		//IL_0659: Expected F4, but got I
		//IL_0654: Expected native int or pointer, but got VT
		//IL_0689: Expected VT, but got F4
		//IL_031f: Expected F4, but got Obj
		//IL_031a: Expected native int or pointer, but got VT
		//IL_0334: Expected F4, but got I
		//IL_032f: Expected native int or pointer, but got VT
		//IL_0341: Expected VT, but got Obj
		//IL_0352: Expected F4, but got Obj
		//IL_034d: Expected native int or pointer, but got VT
		//IL_0367: Expected F4, but got I
		//IL_0362: Expected native int or pointer, but got VT
		//IL_0370: Expected Obj, but got VT
		//IL_02b9: Expected I, but got Obj
		//IL_069b: Expected F4, but got Obj
		//IL_0696: Expected native int or pointer, but got VT
		//IL_06ad: Expected F4, but got I
		//IL_06a8: Expected native int or pointer, but got VT
		//IL_06e8: Expected F4, but got Obj
		//IL_06e3: Expected native int or pointer, but got VT
		//IL_06fd: Expected F4, but got I
		//IL_06f8: Expected native int or pointer, but got VT
		//IL_070a: Expected VT, but got Obj
		//IL_0388: Expected VT, but got F4
		//IL_03a7: Expected F4, but got Obj
		//IL_03a2: Expected native int or pointer, but got VT
		//IL_03bc: Expected F4, but got I
		//IL_03b7: Expected native int or pointer, but got VT
		//IL_0720: Expected F4, but got Obj
		//IL_071b: Expected native int or pointer, but got VT
		//IL_0735: Expected F4, but got I
		//IL_0730: Expected native int or pointer, but got VT
		//IL_074a: Expected Obj, but got VT
		//IL_074a: Expected Obj, but got I
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected Obj, but got Unknown
		//IL_03f1: Expected VT, but got F4
		//IL_03fe: Expected F4, but got Obj
		//IL_03f9: Expected native int or pointer, but got VT
		//IL_0410: Expected F4, but got I
		//IL_040b: Expected native int or pointer, but got VT
		//IL_093a: Expected VT, but got F4
		//IL_0948: Expected I, but got Obj
		//IL_095e: Expected Obj, but got I
		//IL_0450: Expected F4, but got Obj
		//IL_044b: Expected native int or pointer, but got VT
		//IL_0465: Expected F4, but got I
		//IL_0460: Expected native int or pointer, but got VT
		//IL_0472: Expected VT, but got Obj
		//IL_0483: Expected F4, but got Obj
		//IL_047e: Expected native int or pointer, but got VT
		//IL_0498: Expected F4, but got I
		//IL_0493: Expected native int or pointer, but got VT
		//IL_04ad: Expected Obj, but got VT
		//IL_04ad: Expected Obj, but got I
		//IL_0a3b: Expected F4, but got Obj
		//IL_0a36: Expected native int or pointer, but got VT
		//IL_0a4d: Expected F4, but got I
		//IL_0a48: Expected native int or pointer, but got VT
		//IL_0a5e: Expected VT, but got Obj
		//IL_0a6f: Expected F4, but got Obj
		//IL_0a6a: Expected native int or pointer, but got VT
		//IL_0a84: Expected F4, but got I
		//IL_0a7f: Expected native int or pointer, but got VT
		//IL_0a8d: Expected Obj, but got VT
		//IL_0ab2: Expected Obj, but got I4
		//IL_04c1: Expected VT, but got F4
		//IL_0785: Expected I, but got Obj
		//IL_07db: Expected Obj, but got F4
		//IL_07db: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v240 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Vector3 vector = (Vector3)(obj2 + 240);
		Transform transform = (Transform)(obj2 + 224);
		Transform transform2 = (Transform)(obj2 + 160);
		Transform transform3 = (Transform)(obj2 + 144);
		object obj3 = obj2 + 212;
		Transform transform4 = (Transform)(obj2 + 132);
		object obj4 = obj2 + 120;
		object obj5 = obj2 + 108;
		Transform transform5 = (Transform)(obj2 + 96);
		object obj6 = obj2 + 84;
		object obj7 = obj2 + 200;
		Transform transform6 = (Transform)(obj2 + 72);
		object obj8 = obj2 + 60;
		object obj9 = obj2 + 48;
		Transform transform7 = (Transform)(obj2 + 32);
		Transform transform8 = (Transform)(obj2 + 16);
		object obj10 = obj2 + 188;
		object obj11 = obj2 + 176;
		if (((ComputeShader)to).FindKernel(null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v236 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenVolume)+64]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj13 = this + 100;
			GameObject gameObject = base.gameObject;
			obj13 = gameObject;
			Transform transform9 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenVolume)+64]");
			transform9.position = (Vector3)0;
			((Vector3*)(nint)vector)->x = (float)transform;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			object obj14 = this + 104;
			obj14 = vector.x;
			_ = vector.z;
			Transform transform10 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenVolume)+64]");
			transform10.rotation = (Quaternion)0;
			((Vector3*)(nint)vector)->x = (float)transform2;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			object obj15 = this + 116;
			obj15 = vector.x;
			_ = vector.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenVolume)+64]");
			transform3.localScale = (Vector3)0;
			((Vector3*)(nint)vector)->x = (float)transform3;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
			object obj16 = this + 132;
			obj16 = vector.x;
			_ = vector.z;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v196 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)from).FindKernel(null) != 0)
		{
			transform2.position = (Vector3)from;
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v81 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v107 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			float num9 = 1f - factor;
			Vector3 vector3 = vector / num9;
			transform4.position = (Vector3)to;
			((Vector3*)(nint)vector)->x = (float)transform4;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform4).m_CachedPtr;
			Vector3 vector4 = vector / factor;
			transform = transform3;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v21+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			Vector3 vector6 = (Vector3)transform - vector;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Vector3 vector7 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v23+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			Vector3 localPosition = ((Transform)vector).localPosition;
			transform5.localScale = (Vector3)from;
			obj7 = transform5;
			_ = ((UnityEngine.Object)transform5).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj7;
			Vector3 vector8 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v29+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			float num10 = 1f - factor;
			Vector3 vector9 = vector / num10;
			transform6.localScale = (Vector3)to;
			((Vector3*)(nint)vector)->x = (float)transform6;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform6).m_CachedPtr;
			Vector3 vector10 = vector / factor;
			transform = (Transform)obj6;
			Transform transform11 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v27+8]");
			((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
			((Vector3*)(nint)vector)->x = (float)obj8;
			Vector3 vector11 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v33+8]");
			((Vector3*)(nint)vector11)->z = 0f;
			Vector3 vector12 = (Vector3)transform - vector;
			((Vector3*)(nint)vector)->x = (float)obj9;
			Vector3 vector13 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v35+8]");
			((Vector3*)(nint)vector13)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenVolume)+64]");
			((Transform)0).parent = (Transform)vector;
			transform7.rotation = (Quaternion)from;
		}
		else
		{
			object obj19 = this + 104;
			transform2 = (Transform)obj19;
			Transform transform12 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v84+8]");
			((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v48 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num12 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v75 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj10 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj10;
			Vector3 vector14 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v41+8]");
			((Vector3*)(nint)vector14)->z = 0f;
			float num13 = 1f - factor;
			Vector3 vector15 = vector / num13;
			transform4.position = (Vector3)to;
			((Vector3*)(nint)vector)->x = (float)transform4;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform4).m_CachedPtr;
			Vector3 vector16 = vector / factor;
			transform = transform3;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector17 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v21+8]");
			((Vector3*)(nint)vector17)->z = 0f;
			Vector3 vector18 = (Vector3)transform - vector;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Vector3 vector19 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v23+8]");
			((Vector3*)(nint)vector19)->z = 0f;
			Vector3 localPosition2 = ((Transform)vector).localPosition;
			object obj21 = this + 132;
			transform5 = (Transform)obj21;
			Transform transform13 = transform5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S2_v40+8]");
			((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
			obj11 = transform5;
			_ = ((UnityEngine.Object)transform5).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj11;
			Vector3 vector20 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v43+8]");
			((Vector3*)(nint)vector20)->z = 0f;
			float num14 = 1f - factor;
			Vector3 vector21 = vector / num14;
			transform6.localScale = (Vector3)to;
			((Vector3*)(nint)vector)->x = (float)transform6;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform6).m_CachedPtr;
			Vector3 vector22 = vector / factor;
			transform = (Transform)obj6;
			Transform transform14 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v27+8]");
			((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
			((Vector3*)(nint)vector)->x = (float)obj8;
			Vector3 vector23 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v33+8]");
			((Vector3*)(nint)vector23)->z = 0f;
			Vector3 vector24 = (Vector3)transform - vector;
			((Vector3*)(nint)vector)->x = (float)obj9;
			Vector3 vector25 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v35+8]");
			((Vector3*)(nint)vector25)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenVolume)+64]");
			((Transform)0).parent = (Transform)vector;
			object obj22 = this + 116;
			transform7 = (Transform)obj22;
			Transform transform15 = transform7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S1_v139+8]");
			((UnityEngine.Object)transform15).m_CachedPtr = (IntPtr)0;
		}
		transform8.rotation = (Quaternion)to;
		nint num15 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ S0_v23 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num16 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ S0_v41 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = transform7;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform7).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)transform8;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform8).m_CachedPtr;
		Quaternion quaternion = Quaternion.SlerpUnclamped((Quaternion)transform, (Quaternion)vector, factor);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector26 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector26)->z = 0f;
		Quaternion localRotation = ((Transform)vector).localRotation;
		bool flag = (object)mSource != null;
		object obj24 = flag & isFinished;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenVolume)+64]");
			((Transform)0).parentInternal = (Transform)to;
		}
	}

	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		//IL_0018: Expected Obj, but got I4
		TweenOrthoSize tweenOrthoSize = UITweener.Begin<TweenOrthoSize>(go, duration);
		float num = ((TweenVolume)(object)tweenOrthoSize).volume;
		tweenOrthoSize.from = num;
		tweenOrthoSize.to = targetVolume;
		if (!(duration > 0f))
		{
			((PageTop)(object)tweenOrthoSize).Delay(1f, (Action)1);
			tweenOrthoSize.tag = null;
		}
		return (TweenVolume)(object)tweenOrthoSize;
	}

	public override void SetStartToCurrentValue()
	{
		((UI2DSprite)(object)this).OnUpdate();
	}

	public override void SetEndToCurrentValue()
	{
		float num = amountPerDelta;
		from = num;
	}

	public TweenVolume()
	{
		float num = amountPerDelta;
		to = num;
	}
}
