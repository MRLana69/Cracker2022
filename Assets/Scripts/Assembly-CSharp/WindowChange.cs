using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WindowChange : UIBehaviour
{
	public enum WINDOW
	{
		NONE,
		CAMERA,
		CANVAS,
		ALL
	}

	private CanvasScaler CanvasScaler;

	private Vector2 lastScreenSize;

	private float[] scale;

	private float[] limit;

	private float[] camera_zoom;

	private WINDOW window;

	private float preSize;

	private new void OnEnable()
	{
		lastScreenSize = Vector2.zeroVector;
	}

	private void Update()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I
		//IL_00e0: Invalid comparison between Obj and F4
		//IL_0127: Expected VT, but got I4
		//IL_013a: Expected F4, but got I4
		//IL_013a: Expected F4, but got I4
		UIScreenController instance = UIScreenController.Instance;
		if (!(instance != null))
		{
			return;
		}
		UIScreenController instance2 = UIScreenController.Instance;
		if (instance2.Camera3D != null)
		{
			int width = Screen.width;
			int height = Screen.height;
			UIScreenController instance3 = UIScreenController.Instance;
			float fieldOfView = instance3.Camera3D.fieldOfView;
			object obj = lastScreenSize - width;
			object obj2 = obj * obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WindowChange)+14]");
			object obj3 = -height;
			object obj4 = obj3 * obj3;
			object obj5 = obj2 + obj4;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f) || fieldOfView != preSize)
			{
				lastScreenSize = (Vector2)width;
				Reponsive(width, height);
			}
		}
	}

	private void Reponsive(float width, float height)
	{
		//IL_003d: Expected Obj, but got I4
		//IL_0135: Expected F4, but got I
		//IL_0164: Expected F4, but got I
		//IL_0193: Expected F4, but got I
		//IL_00f8: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		float num = width / height;
		float[] array = limit;
		bool flag = !(num > array[0]);
		object obj = 0;
		if (!flag)
		{
			float[] array2 = limit;
			if (num > array2[0])
			{
				float[] array3 = limit;
				bool flag2 = num < array3[1];
				obj = 1;
				if (flag2)
				{
					goto IL_0106;
				}
			}
			float[] array4 = limit;
			bool flag3 = !(num < array4[1]);
			bool flag4 = !flag3;
			obj = 2;
			if (flag4)
			{
				return;
			}
		}
		goto IL_0106;
		IL_0106:
		object obj2 = obj << 2;
		object obj3 = (object)scale + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+10]");
		SetCanvas(0f);
		object obj4 = obj << 2;
		object obj5 = (object)camera_zoom + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v13+10]");
		preSize = 0f;
		object obj6 = obj << 2;
		object obj7 = (object)camera_zoom + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v17+10]");
		SetCamera(0f);
	}

	private void SetCanvas(float value)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		object obj = this + 12;
		if (CanvasScaler == null)
		{
			CanvasScaler component = GetComponent<CanvasScaler>();
			CanvasScaler = component;
		}
		if ((UnityEngine.Object)obj != null)
		{
			object obj2 = obj;
		}
	}

	private void SetCamera(float value)
	{
		if (window == WINDOW.CAMERA)
		{
			UIScreenController instance = UIScreenController.Instance;
			if (instance.Camera3D != null)
			{
				UIScreenController instance2 = UIScreenController.Instance;
				instance2.Camera3D.fieldOfView = value;
			}
		}
	}

	public WindowChange()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		float[] array = default;
		array[1] = 0.5f;
		array[2] = 1f;
		scale = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E.F007C283E5E64944C7F80E5E31C69C7EF1BE4C4C3D9654D48FC38FA720913DCA));
		limit = (float[])array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array3 = default;
		RuntimeHelpers.InitializeArray(array3, __ldtoken(_003CPrivateImplementationDetails_003E.B88BC810160A120FD5C63AD72A26BA9F26A9A0DAF7AD5C4964B4A82ACCF3FFA5));
		camera_zoom = (float[])array3;
		base._002Ector();
	}
}
