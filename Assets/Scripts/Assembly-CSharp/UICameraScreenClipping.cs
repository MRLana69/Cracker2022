using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class UICameraScreenClipping : MonoBehaviour
{
	private Camera _cam;

	private const int SCREEN_WIDTH = 300;

	private const int POPUP_WIDTH = 265;

	private void Awake()
	{
		GameObject gameObject = base.gameObject;
		Camera component = gameObject.GetComponent<Camera>();
		_cam = component;
	}

	private void Start()
	{
		if (!(_cam == null))
		{
			CalculateClipping(popupSizedClip: false);
		}
	}

	public unsafe void CalculateClipping(bool popupSizedClip)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01e6: Expected F4, but got I
		//IL_01e1: Expected native int or pointer, but got VT
		//IL_01fb: Expected F4, but got I
		//IL_01f6: Expected native int or pointer, but got VT
		//IL_0175: Expected Obj, but got I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected I4, but got Unknown
		object obj = default;
		Rect rect = (Rect)(obj - 48);
		_ = 0;
		_ = 0;
		UIScreenController instance = UIScreenController.Instance;
		if (instance.root == null || _cam == null)
		{
			GameObject gameObject = base.gameObject;
			Camera component = gameObject.GetComponent<Camera>();
			_cam = component;
		}
		Rect rect2 = _cam.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
		_ = 0;
		if (!UIScreen.IsScreenHeightOutOfProportion())
		{
			float num = 265f;
			if (!popupSizedClip)
			{
				num = 300f;
			}
			int width = Screen.width;
			object obj2 = width * 480;
			int height = Screen.height;
			int num2 = obj2 / height;
			float num3 = num / (float)num2;
			float num4 = num3 * 0.5f;
			float num5 = 0.5f - num4;
			float num6 = num3;
		}
		else
		{
			float num7 = 0.83f;
			if (!popupSizedClip)
			{
				num7 = 0.9f;
			}
			float num6 = num7;
			float num5 = 0.085f;
			if (!popupSizedClip)
			{
				num6 = num7;
				num5 = 0.05f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
		((Rect*)(nint)rect)->m_Width = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
		((Rect*)(nint)rect)->m_XMin = 0f;
		_cam.rect = rect;
	}
}
