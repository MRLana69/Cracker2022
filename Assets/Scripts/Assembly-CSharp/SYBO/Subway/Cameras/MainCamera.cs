using Cpp2ILInjected;
using SYBO.Subway.Managers;
using UnityEngine;

namespace SYBO.Subway.Cameras;

public class MainCamera : MonoBehaviour
{
	private Transform _skyPlaneTransform;

	private Transform _reviveEffectTransform;

	private Transform _speedStripesTransform;

	private Camera _camera;

	public Transform SkyPlane => _skyPlaneTransform;

	public Transform ReviveEffectTransform => _reviveEffectTransform;

	protected unsafe void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected VT, but got Unknown
		//IL_0196: Expected F4, but got I
		//IL_0191: Expected native int or pointer, but got VT
		//IL_01b1: Expected F4, but got I
		//IL_01ac: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Camera component = GetComponent<Camera>();
		_camera = component;
		GameObject gameObject = _skyPlaneTransform.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = _reviveEffectTransform.gameObject;
		gameObject2.SetActive(value: true);
		GameObject gameObject3 = _speedStripesTransform.gameObject;
		gameObject3.SetActive(value: true);
		MeshRenderer component2 = _skyPlaneTransform.GetComponent<MeshRenderer>();
		Material sharedMaterial = component2.sharedMaterial;
		int renderQueue = sharedMaterial.renderQueue;
		if (renderQueue >= 1001)
		{
			Material sharedMaterial2 = component2.sharedMaterial;
			sharedMaterial2.renderQueue = 1000;
		}
		if (DemoVideoModeManager.IsEnabled)
		{
			_camera.farClipPlane = 3000f;
			Vector3 position = _skyPlaneTransform.position;
			_ = 1161117696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 position2 = vector + 16;
			_skyPlaneTransform.position = position2;
			Vector3 localScale = _skyPlaneTransform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = 1143930880;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			_skyPlaneTransform.localScale = vector;
		}
	}
}
