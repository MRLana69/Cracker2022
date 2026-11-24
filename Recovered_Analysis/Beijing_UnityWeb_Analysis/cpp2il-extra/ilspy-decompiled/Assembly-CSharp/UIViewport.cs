using Cpp2ILInjected;
using UnityEngine;

public class UIViewport : MonoBehaviour
{
	public Camera sourceCamera;

	public Transform topLeft;

	public Transform bottomRight;

	public float fullSize;

	private Camera mCam;

	private void Start()
	{
		//IL_005d: Expected Obj, but got F4
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		mCam = (Camera)10f;
		_ = 1;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this - -64;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17+8]");
		_ = 0;
		CancelInvoke();
	}

	private void LateUpdate()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_009e: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		object obj = this + 28;
		Camera component = GetComponent<Camera>();
		obj = component;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (sourceCamera != null)
		{
			object obj3 = this + 12;
			Camera current = Camera.current;
			obj3 = current;
		}
	}

	public unsafe UIViewport()
	{
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0473: Expected Obj, but got I4
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_0490: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_04ad: Expected Obj, but got I4
		//IL_04c1: Expected I, but got Obj
		//IL_04d7: Expected Obj, but got I
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected VT, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected VT, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected Obj, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0149: Expected VT, but got Obj
		//IL_0156: Expected F4, but got Obj
		//IL_0151: Expected native int or pointer, but got VT
		//IL_0168: Expected F4, but got I
		//IL_0163: Expected native int or pointer, but got VT
		//IL_01a4: Expected VT, but got Obj
		//IL_01b1: Expected F4, but got Obj
		//IL_01ac: Expected native int or pointer, but got VT
		//IL_01c3: Expected F4, but got I
		//IL_01be: Expected native int or pointer, but got VT
		//IL_02ab: Expected Obj, but got I
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected I4, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected I4, but got Unknown
		//IL_02db: Expected Obj, but got I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected I4, but got Unknown
		//IL_0356: Expected VT, but got Obj
		//IL_0363: Expected F4, but got Obj
		//IL_035e: Expected native int or pointer, but got VT
		//IL_0378: Expected F4, but got I
		//IL_0373: Expected native int or pointer, but got VT
		//IL_0385: Expected F4, but got Obj
		//IL_0380: Expected native int or pointer, but got VT
		//IL_0397: Expected F4, but got I
		//IL_0392: Expected native int or pointer, but got VT
		//IL_0457: Expected Obj, but got I4
		//IL_03d3: Expected F4, but got Obj
		//IL_03ce: Expected native int or pointer, but got VT
		//IL_03e8: Expected F4, but got I
		//IL_03e3: Expected native int or pointer, but got VT
		//IL_03f1: Expected Obj, but got VT
		Camera camera = default;
		object obj = camera + 180;
		obj = 0;
		_ = 0;
		object obj2 = camera + 168;
		obj2 = 0;
		_ = 0;
		object obj3 = camera + 152;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v136 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(camera + 208);
		Rect rect = (Rect)(camera + 192);
		Transform transform = (Transform)(camera + 140);
		object obj5 = camera + 128;
		Transform transform2 = (Transform)(camera + 116);
		object obj6 = camera + 104;
		object obj7 = camera + 92;
		object obj8 = camera + 80;
		object obj9 = camera + 68;
		object obj10 = camera + 56;
		object obj11 = camera + 44;
		object obj12 = camera + 32;
		object obj13 = camera + 16;
		if (((ComputeShader)(object)topLeft).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v119 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)bottomRight).FindKernel((string)null) == 0)
		{
			return;
		}
		string text = topLeft.tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 == null)
		{
			mCam.tag = null;
			return;
		}
		transform.position = (Vector3)topLeft;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((Object)transform).m_CachedPtr;
		Vector3 vector2 = sourceCamera.WorldToViewportPoint(vector);
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v31+8]");
		_ = 0;
		transform2.position = (Vector3)bottomRight;
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((Object)transform2).m_CachedPtr;
		Vector3 vector3 = sourceCamera.WorldToViewportPoint(vector);
		obj2 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+8]");
		_ = 0;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		int height = Screen.height;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		int sleepTimeout = Screen.sleepTimeout;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		int height2 = Screen.height;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v45+4]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47+4]");
		object obj15 = num5 - 0;
		int sleepTimeout2 = Screen.sleepTimeout;
		int num6 = obj15 / sleepTimeout2;
		int num7 = obj7 / height;
		obj3 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v39+4]");
		int num8 = (int)((nint)0 / (nint)sleepTimeout);
		object obj16 = obj9 - obj10;
		int num9 = obj16 / height2;
		float num10 = fullSize;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+C]");
		float num11 = num10 * 0f;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		camera.rect = (Rect)mCam;
		((Rect*)(nint)rect)->m_XMin = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v49+8]");
		((Rect*)(nint)rect)->m_Width = 0f;
		((Vector3*)(nint)vector)->x = (float)camera;
		((Vector3*)(nint)vector)->z = (nint)((Object)camera).m_CachedPtr;
		if (rect == (Rect)vector)
		{
			((Vector3*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Rect pixelRect = ((Camera)vector).pixelRect;
		}
		float depth = mCam.depth;
		if (depth != num11)
		{
			mCam.depth = num11;
		}
		mCam.tag = (string)1;
	}
}
