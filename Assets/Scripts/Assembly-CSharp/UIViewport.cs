using Cpp2ILInjected;
using UnityEngine;

public class UIViewport : MonoBehaviour
{
	public Camera sourceCamera;

	public Transform topLeft;

	public Transform bottomRight;

	public float fullSize = 1f;

	private Camera mCam;

	private void Start()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		Camera component = GetComponent<Camera>();
		mCam = component;
		if (sourceCamera == null)
		{
			object obj = this + 12;
			Camera main = Camera.main;
			obj = main;
		}
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected VT, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected VT, but got Unknown
		//IL_018a: Expected Obj, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected I4, but got Unknown
		//IL_01c7: Expected Obj, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected I4, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected VT, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected VT, but got Unknown
		//IL_02fd: Expected F4, but got I
		//IL_02f8: Expected native int or pointer, but got VT
		//IL_0312: Expected F4, but got I
		//IL_030d: Expected native int or pointer, but got VT
		object obj = default;
		Rect rect = (Rect)(obj - 176);
		_ = 0;
		_ = 0;
		if (!(topLeft != null) || !(bottomRight != null))
		{
			return;
		}
		GameObject gameObject = topLeft.gameObject;
		if (gameObject.activeInHierarchy)
		{
			Vector3 position = topLeft.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+70]");
			_ = 0;
			Vector3 position2 = (Vector3)(rect - -64);
			Vector3 vector = sourceCamera.WorldToScreenPoint(position2);
			Vector3 position3 = bottomRight.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+70]");
			_ = 0;
			Vector3 position4 = (Vector3)(rect + 48);
			Vector3 vector2 = sourceCamera.WorldToScreenPoint(position4);
			int width = Screen.width;
			int height = Screen.height;
			int width2 = Screen.width;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+74]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+74]");
			object obj2 = num - 0;
			int height2 = Screen.height;
			int num2 = obj2 / height2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+70]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+70]");
			object obj3 = num3 - 0;
			int num4 = obj3 / width2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+74]");
			int num5 = (int)((nint)0 / (nint)height);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+70]");
			int num6 = (int)((nint)0 / (nint)width);
			float num7 = fullSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+AC]");
			float num8 = num7 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+A0]");
			_ = 0;
			Rect rect2 = mCam.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+60]");
			_ = 0;
			Rect rect3 = (Rect)(rect + 32);
			Rect rect4 = (Rect)(rect + 16);
			if (rect3 != rect4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+A8]");
				((Rect*)(nint)rect)->m_Width = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+A0]");
				((Rect*)(nint)rect)->m_XMin = 0f;
				mCam.rect = rect;
			}
			float orthographicSize = mCam.orthographicSize;
			if (orthographicSize != num8)
			{
				mCam.orthographicSize = num8;
			}
			mCam.enabled = true;
		}
		else
		{
			mCam.enabled = false;
		}
	}
}
