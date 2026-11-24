using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.MessageCenter;

public class UIBasicButton : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease
	}

	public Trigger trigger;

	protected void OnHover(bool isOver)
	{
		//IL_00c5: Expected I, but got Obj
		//IL_00db: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Texture texture = (Texture)(obj2 + 16);
		if (((ComputeShader)isOver).FindKernel(null) != 0)
		{
			UnityEngine.RenderTexture active = UnityEngine.RenderTexture.active;
			UnityEngine.RenderTexture.Internal_Create((UnityEngine.RenderTexture)isOver);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F52F");
			texture = (Texture)obj2;
			Texture texture2 = texture;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)texture2).m_CachedPtr = (IntPtr)0;
			((MaterialPropertyBlock)1).SetTextureImpl(1, texture);
			UnityEngine.RenderTexture.Internal_Create(active);
		}
	}

	protected void OnPress(bool isPressed)
	{
		if (isPressed)
		{
			if (trigger != Trigger.OnMouseOver)
			{
				return;
			}
		}
		else if (trigger != Trigger.OnMouseOut)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected void OnClick()
	{
		CancelInvoke();
	}

	public virtual void Send()
	{
		if (trigger == Trigger.OnClick)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
