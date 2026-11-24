using Cpp2ILInjected;
using UnityEngine;

namespace UI.ModelCamera;

public class ModelScreenSetup
{
	private const int NOT_SET_INT_VALUE = -1;

	private Vector3 localPosition__BackingField;

	private Vector3 localScale__BackingField;

	private int localScaleOnAllAxes__BackingField;

	public Vector3 localPosition
	{
		get
		{
			Vector3 result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got I
			object obj = value + 8;
			ModelScreenSetup modelScreenSetup = (ModelScreenSetup)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			localPosition__BackingField = (Vector3)0;
		}
	}

	public unsafe Vector3 localScale
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = localPosition__BackingField;
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
			object obj = value + 20;
			ModelScreenSetup modelScreenSetup = (ModelScreenSetup)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			localPosition__BackingField = (Vector3)0;
		}
	}

	public unsafe Vector3 localRotation
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = localPosition__BackingField;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 20);
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
			object obj = value + 32;
			ModelScreenSetup modelScreenSetup = (ModelScreenSetup)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			localPosition__BackingField = (Vector3)0;
		}
	}

	public unsafe int localScaleOnAllAxes
	{
		get
		{
			//IL_000b: Expected Obj, but got VT
			string tag = ((Component)localScale__BackingField).tag;
			return ((GameObject)(object)tag).activeSelf ? 1 : 0;
		}
		set
		{
			//IL_000d: Expected Obj, but got I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			object obj = ((int*)value)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
			_ = 0;
			object obj2 = this + 32;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
	}

	public int modelGoLayer
	{
		get
		{
			return localScaleOnAllAxes__BackingField;
		}
		set
		{
			localScaleOnAllAxes__BackingField = value;
		}
	}

	public Vector3 cameraLocalPosition
	{
		get
		{
			Vector3 result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got I
			object obj = value + 52;
			ModelScreenSetup modelScreenSetup = (ModelScreenSetup)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			localPosition__BackingField = (Vector3)0;
		}
	}

	public unsafe Vector3 cameraLocalScale
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = localPosition__BackingField;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 52);
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
			object obj = value - -64;
			ModelScreenSetup modelScreenSetup = (ModelScreenSetup)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			localPosition__BackingField = (Vector3)0;
		}
	}

	public unsafe Vector3 cameraLocalRotation
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = localPosition__BackingField;
			object obj = default;
			Vector3 vector = (Vector3)(obj - -64);
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
			object obj = value + 76;
			ModelScreenSetup modelScreenSetup = (ModelScreenSetup)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			localPosition__BackingField = (Vector3)0;
		}
	}

	public ModelScreenSetup()
	{
		//IL_0011: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenSetup)+10]");
		string tag = ((Component)0).tag;
		((GameObject)(object)tag).tag = (string)1;
	}

	public unsafe void SetupScreen(Transform modelTransform, Transform cameraTransform, int cameraLayer)
	{
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01da: Expected VT, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected VT, but got Unknown
		//IL_0256: Expected F4, but got Obj
		//IL_0251: Expected native int or pointer, but got VT
		//IL_0268: Expected F4, but got I
		//IL_0263: Expected native int or pointer, but got VT
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected VT, but got Unknown
		//IL_0283: Expected F4, but got Obj
		//IL_027e: Expected native int or pointer, but got VT
		//IL_0298: Expected F4, but got I
		//IL_0293: Expected native int or pointer, but got VT
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02c4: Expected F4, but got Obj
		//IL_02bf: Expected native int or pointer, but got VT
		//IL_02d9: Expected F4, but got I
		//IL_02d4: Expected native int or pointer, but got VT
		//IL_02e2: Expected Obj, but got VT
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_0309: Expected VT, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_031b: Expected F4, but got Obj
		//IL_0316: Expected native int or pointer, but got VT
		//IL_0330: Expected F4, but got I
		//IL_032b: Expected native int or pointer, but got VT
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Ref, but got Unknown
		//IL_034b: Expected Ref, but got VT
		//IL_0358: Expected F4, but got Obj
		//IL_0353: Expected native int or pointer, but got VT
		//IL_036a: Expected F4, but got I
		//IL_0365: Expected native int or pointer, but got VT
		//IL_037c: Expected F4, but got VT
		//IL_0377: Expected native int or pointer, but got VT
		//IL_0391: Expected F4, but got I
		//IL_038c: Expected native int or pointer, but got VT
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03bd: Expected F4, but got Obj
		//IL_03b8: Expected native int or pointer, but got VT
		//IL_03d2: Expected F4, but got I
		//IL_03cd: Expected native int or pointer, but got VT
		//IL_03db: Expected Obj, but got VT
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0123: Expected VT, but got I
		//IL_0130: Expected F4, but got Obj
		//IL_012b: Expected native int or pointer, but got VT
		//IL_0142: Expected F4, but got I
		//IL_013d: Expected native int or pointer, but got VT
		//IL_0154: Expected F4, but got I4
		//IL_014f: Expected native int or pointer, but got VT
		//IL_0169: Expected F4, but got I
		//IL_0164: Expected native int or pointer, but got VT
		//IL_00c1: Expected I, but got Obj
		//IL_018c: Expected F4, but got Obj
		//IL_0187: Expected native int or pointer, but got VT
		//IL_01a1: Expected F4, but got I
		//IL_019c: Expected native int or pointer, but got VT
		//IL_01b6: Expected Obj, but got VT
		//IL_01b6: Expected Obj, but got I
		object obj = default;
		Transform transform = (Transform)(obj + 112);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenSetup)+80]");
		transform.localPosition = (Vector3)0;
		object obj2 = obj + 100;
		obj2 = modelTransform;
		_ = ((Object)modelTransform).m_CachedPtr;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v67 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj + 128);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj + 144);
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj4 = obj + 88;
		Vector3 vector3 = vector - vector2;
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v25+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector2).eulerAngles;
		Transform transform2 = (Transform)(obj + 72);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenSetup)+80]");
		transform2.localRotation = (Quaternion)0;
		object obj5 = obj + 56;
		obj5 = cameraTransform;
		_ = ((Object)cameraTransform).m_CachedPtr;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v35 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v63 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		ref Quaternion reference = ref *(Quaternion*)(obj + 40);
		Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector2);
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((Object)transform2).m_CachedPtr;
		((Vector3*)(nint)vector2)->x = (float)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v42 (UnityEngine.Quaternion&)+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj7 = obj + 24;
		Vector3 vector4 = (Quaternion)vector * vector2;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v48+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector5 = ((Transform)vector2).localScale;
		Transform transform3 = (Transform)(obj + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenSetup)+80]");
		transform3.localScale = (Vector3)0;
		((Vector3*)(nint)vector)->x = (float)transform3;
		((Vector3*)(nint)vector)->z = (nint)((Object)transform3).m_CachedPtr;
		((Vector3*)(nint)vector2)->x = ((int*)cameraLayer)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cameraLayer @ L3 (System.Int32)+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector6 = Vector3.Cross(vector, vector2);
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.ModelScreenSetup)+80]");
		((Transform)0).parent = (Transform)vector2;
	}

	private void SetLocalScale(Transform modelTransform)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		_ = ((Object)modelTransform).m_CachedPtr;
		object obj = this + 76;
		obj = modelTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
	}
}
