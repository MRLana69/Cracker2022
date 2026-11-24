using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIOrthoCamera : MonoBehaviour
{
	private Camera mCam;

	private Transform mTrans;

	private void Start()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 12;
		Camera component = GetComponent<Camera>();
		obj = component;
		object obj2 = this + 16;
		GameObject gameObject = base.gameObject;
		obj2 = gameObject;
		mCam.transparencySortMode = TransparencySortMode.Perspective;
	}

	public UIOrthoCamera()
	{
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_017e: Expected VT, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01cb: Expected VT, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_004c: Expected I4, but got Obj
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 48;
		obj = 0;
		_ = 0;
		Camera camera = (Camera)(transform + 32);
		camera.rect = (Rect)mCam;
		obj = camera;
		_ = ((Object)camera).m_CachedPtr;
		int sleepTimeout = Screen.sleepTimeout;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj2 = (nint)0 * (nint)sleepTimeout;
		Camera camera2 = (Camera)(transform + 16);
		camera2.rect = (Rect)mCam;
		obj = camera2;
		_ = ((Object)camera2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj3 = num + 0;
		int sleepTimeout2 = Screen.sleepTimeout;
		transform.hasChanged = (byte)(int)mTrans != 0;
		object obj4 = obj3 * sleepTimeout2;
		object obj5 = obj4 - obj2;
		float num2 = (float)obj5 * 0.5f;
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
		float num4 = num3 * 0f;
		float depth = mCam.depth;
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v32 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v39 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (BaseInputModule.DetermineMoveDirection(depth, num4) == MoveDirection.Left)
		{
			mCam.depth = num4;
		}
	}
}
