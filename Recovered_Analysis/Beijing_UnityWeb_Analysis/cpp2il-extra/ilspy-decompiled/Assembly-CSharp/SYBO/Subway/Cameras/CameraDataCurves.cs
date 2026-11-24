using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Cameras;

public class CameraDataCurves : MonoBehaviour
{
	private CurveParent _targetPositionCurveParent;

	private CurveParent _cameraPositionCurveParent;

	protected void Awake()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01ef: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_025d: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v63 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Object)this).m_CachedPtr = (nint)CameraData.CAMERA_MODE_DEFAULT;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = CameraData.FIELD_OF_VIEW_SMOOTH_TIME_DEFAULT;
		_ = CameraData.FIELD_OF_VIEW_DEFAULT;
		_ = CameraData.FIELD_OF_VIEW_DEFAULT;
		object obj2 = this + 16;
		object obj3 = default;
		obj2 = obj3;
		object obj5 = default;
		object obj4 = obj5 + 36;
		nint num3 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v14 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		object obj6 = (nint)0 + (nint)8;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v16+8]");
		_ = 0;
		object obj7 = obj5 + 48;
		obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v30+8]");
		_ = 0;
		object obj8 = this + 20;
		obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v33+8]");
		_ = 0;
		object obj9 = obj5 + 24;
		nint num4 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v32 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		object obj10 = (nint)0 + (nint)32;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v34+8]");
		_ = 0;
		obj7 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v39+8]");
		_ = 0;
		object obj11 = this + 32;
		obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v33+8]");
		_ = 0;
		object obj12 = obj5 + 12;
		nint num5 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v49 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		object obj13 = (nint)0 + (nint)20;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v51+8]");
		_ = 0;
		obj7 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v47+8]");
		_ = 0;
		object obj14 = this + 44;
		obj14 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v33+8]");
		_ = 0;
		nint num6 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v65 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		object obj15 = (nint)0 + (nint)44;
		obj5 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v67+8]");
		_ = 0;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj16 = this + 56;
		obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v33+8]");
		_ = 0;
		_ = CameraData.TRANSFORM_TWEEN_DURATION;
	}

	protected void Start()
	{
	}

	protected void Update()
	{
	}
}
