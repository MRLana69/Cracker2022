using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class InGameCaptureWrapper : MonoBehaviour
{
	private int _width;

	private int _height;

	public unsafe int Width
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			int num = default;
			object obj = num + 16;
			obj = this;
			return num;
		}
		set
		{
			//IL_0011: Expected Obj, but got I
			//IL_001e: Expected Obj, but got I4
			//IL_003e: Expected Obj, but got I
			//IL_0065: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got F4
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected I4, but got Unknown
			//IL_009f: Expected I4, but got Obj
			//IL_00cb: Expected Obj, but got I
			//IL_00dc: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InGameCaptureWrapper)+18]");
			Matrix4x4 worldToCameraMatrix = ((Camera)0).worldToCameraMatrix;
			Camera.FireOnPreCull((Camera)value);
			Matrix4x4 worldToCameraMatrix2 = ((Camera)null).worldToCameraMatrix;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InGameCaptureWrapper)+18]");
			RenderTexture.Internal_Create((RenderTexture)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = 0;
			_ = 0;
			obj = 0f;
			_ = 0f;
			int num = obj + 16;
			((int*)num)->m_value = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InGameCaptureWrapper)+1C]");
			((Cubemap)0)._002Ector(num, DefaultFormat.LDR, TextureCreationFlags.None);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InGameCaptureWrapper)+1C]");
			((RenderTexture)0)._002Ector();
			RenderTexture.Internal_Create((RenderTexture)null);
		}
	}

	public int Height
	{
		get
		{
			return _width;
		}
		set
		{
			_width = value;
		}
	}

	public InGameCaptureWrapper()
	{
		//IL_00aa: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		((CaptureAnimation)(object)this).Cleanup();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InGameCaptureWrapper)+20]");
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)0).GetComponentInChildren<T>();
		MonoBehaviour.print(componentInChildren);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InGameCaptureWrapper)+20]");
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0);
		TouchScreenKeyboard.Internal_Destroy((IntPtr)0);
	}
}
