using System;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

namespace SYBO.Subway.Cameras;

public class MainCamera : MonoBehaviour
{
	private Transform _skyPlaneTransform;

	private Transform _reviveEffectTransform;

	private Transform _speedStripesTransform;

	private Camera _camera;

	public Transform SkyPlane
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CameraDataCurves cameraDataCurves = default;
			cameraDataCurves.Awake();
			return (Transform)(object)cameraDataCurves;
		}
	}

	public Transform ReviveEffectTransform => _skyPlaneTransform;

	protected void Awake()
	{
		//IL_005e: Expected Obj, but got F4
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_skyPlaneTransform = (Transform)(-20f);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 one = Vector3.one;
		object obj4 = obj3 + 24;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		object obj5 = this + 80;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17+8]");
		_ = 0;
		Vector3 one2 = Vector3.one;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = this + 92;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17+8]");
		_ = 0;
		_ = 0.5f;
		_ = 0.75f;
		CancelInvoke();
	}

	public MainCamera()
	{
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0277: Expected Obj, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got VT
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got VT
		//IL_00bd: Expected Obj, but got I4
		//IL_014d: Expected VT, but got Obj
		//IL_0197: Expected Obj, but got I4
		//IL_01f1: Expected VT, but got Obj
		//IL_0211: Expected Obj, but got F4
		Transform transform = default;
		object obj = transform + 72;
		obj = 0;
		_ = 0;
		object obj2 = transform + 60;
		obj2 = 0;
		_ = 0;
		object obj3 = this + 24;
		Camera component = GetComponent<Camera>();
		obj3 = component;
		string text = _skyPlaneTransform.tag;
		((GameObject)(object)text).tag = (string)1;
		string text2 = _reviveEffectTransform.tag;
		((GameObject)(object)text2).tag = (string)1;
		string text3 = _speedStripesTransform.tag;
		((GameObject)(object)text3).tag = (string)1;
		_0021_00210 componentInChildren = (_0021_00210)((Component)_skyPlaneTransform).GetComponentInChildren<T>();
		Material[] sharedMaterials = ((Renderer)componentInChildren).sharedMaterials;
		string[] shaderKeywords = ((Material)(object)sharedMaterials).GetShaderKeywords();
		if ((nint)shaderKeywords >= 1001)
		{
			Material[] sharedMaterials2 = ((Renderer)componentInChildren).sharedMaterials;
			((Material)(object)sharedMaterials2).EnableKeyword((string)1000);
		}
		Transform transform2 = (Transform)(transform + 84);
		Transform transform3 = (Transform)(transform + 48);
		object obj4 = transform + 36;
		object obj5 = transform + 24;
		object obj6 = transform + 12;
		Character instance = Character.Instance;
		if ((object)instance != null)
		{
			_camera.fieldOfView = 3000f;
			transform3.position = (Vector3)_skyPlaneTransform;
			obj = transform3;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			obj6 = 0;
			_ = 0;
			obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v39+4]");
			_ = 0;
			_ = 2900f;
			transform2 = (Transform)obj6;
			Transform transform4 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v41+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform2.localPosition;
			transform.localScale = (Vector3)_skyPlaneTransform;
			obj2 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj2 = 700f;
			transform2 = (Transform)obj2;
			Transform transform5 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			_skyPlaneTransform.parent = transform2;
		}
	}
}
