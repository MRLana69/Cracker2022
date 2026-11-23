using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIOrthoCamera : MonoBehaviour
{
	private Camera mCam;

	private Transform mTrans;

	private void Start()
	{
		Camera component = GetComponent<Camera>();
		mCam = component;
		Transform transform = base.transform;
		mTrans = transform;
		mCam.orthographic = true;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005e: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		Rect rect = mCam.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		int height = Screen.height;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
		object obj3 = (nint)0 * (nint)height;
		Rect rect2 = mCam.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
		object obj4 = num + 0;
		int height2 = Screen.height;
		Vector3 lossyScale = mTrans.lossyScale;
		object obj5 = obj4 * height2;
		object obj6 = obj5 - obj3;
		float num2 = (float)obj6 * 0.5f;
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num4 = num3 * 0f;
		float orthographicSize = mCam.orthographicSize;
		float value = num4 - orthographicSize;
		float num5 = Math.Abs(value);
		float num6 = Math.Abs(orthographicSize);
		float num7 = Math.Abs(num4);
		if (!(num6 > num7))
		{
			num6 = num7;
		}
		float num8 = num6 * 1E-06f;
		float num9 = Mathf.Epsilon * 8f;
		if (!(num8 > num9))
		{
			num8 = num9;
		}
		if (!(num5 < num8))
		{
			mCam.orthographicSize = num4;
		}
	}
}
