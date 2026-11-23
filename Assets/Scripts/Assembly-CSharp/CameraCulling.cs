using Cpp2ILInjected;
using UnityEngine;

public class CameraCulling : MonoBehaviour
{
	private Camera _camera;

	private float[] _distances;

	public float TransparentFXCullingDistance
	{
		set
		{
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected Obj, but got Unknown
			if (_camera == null)
			{
				Camera component = GetComponent<Camera>();
				_camera = component;
			}
			int num = LayerMask.NameToLayer("TransparentFX");
			int num2 = num << 2;
			object obj = _distances + num2;
			_camera.layerCullDistances = _distances;
		}
	}

	private void Awake()
	{
		Camera component = GetComponent<Camera>();
		_camera = component;
	}

	public CameraCulling()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		float[] distances = default;
		_distances = distances;
		base._002Ector();
	}
}
