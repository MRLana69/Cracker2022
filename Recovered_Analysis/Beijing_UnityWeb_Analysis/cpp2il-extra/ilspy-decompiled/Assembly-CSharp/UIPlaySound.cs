using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIPlaySound : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease,
		Custom,
		OnEnable,
		OnDisable
	}

	public AudioClip audioClip;

	public Trigger trigger;

	public float volume;

	public float pitch;

	private bool mIsOver;

	private bool canPlay
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_0043: Invalid comparison between F4 and I4
			if (pitch == 2f)
			{
				return true;
			}
			return pitch == 1f;
		}
	}

	private void OnEnable()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		mIsOver = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj = this + 44;
		obj = list;
		CancelInvoke();
	}

	private void OnDisable()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (trigger != Trigger.OnEnable)
		{
			return;
		}
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v8 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TweenFill tweenFill = TweenFill.Begin((GameObject)(object)audioClip, volume, pitch);
	}

	private void OnHover(bool isOver)
	{
		//IL_000f: Expected Obj, but got I4
		((UIPlayTween)this).CustomHoverListener((GameObject)isOver, true);
	}

	private void OnPress(bool isPressed)
	{
		//IL_0026: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		if (trigger == Trigger.OnMouseOver)
		{
			bool flag = mIsOver;
			object obj = flag ^ isPressed;
			if (obj == null)
			{
				return;
			}
			mIsOver = isPressed;
		}
		Object ambigiousFont = ((UIPopupList)this).ambigiousFont;
		if ((object)ambigiousFont == null)
		{
			return;
		}
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
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S3_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v8 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TweenFill tweenFill = TweenFill.Begin((GameObject)(object)audioClip, volume, pitch);
	}

	private void OnClick()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (trigger != Trigger.OnDisable)
		{
			return;
		}
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v8 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TweenFill tweenFill = TweenFill.Begin((GameObject)(object)audioClip, volume, pitch);
	}

	private void OnSelect(bool isSelected)
	{
		//IL_0026: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		if (trigger == Trigger.OnPress)
		{
			bool flag = mIsOver;
			object obj = flag ^ isSelected;
			if (obj == null)
			{
				return;
			}
			mIsOver = isSelected;
		}
		Object ambigiousFont = ((UIPopupList)this).ambigiousFont;
		if ((object)ambigiousFont == null)
		{
			return;
		}
		if (isSelected)
		{
			if (trigger != Trigger.OnPress)
			{
				return;
			}
		}
		else if (trigger != Trigger.OnRelease)
		{
			return;
		}
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S3_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v8 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TweenFill tweenFill = TweenFill.Begin((GameObject)(object)audioClip, volume, pitch);
	}

	public void Play()
	{
		//IL_003d: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_007e: Expected I, but got Obj
		Object ambigiousFont = ((UIPopupList)this).ambigiousFont;
		if ((object)ambigiousFont == null || trigger != Trigger.OnClick)
		{
			return;
		}
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v8 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TweenFill tweenFill = TweenFill.Begin((GameObject)(object)audioClip, volume, pitch);
	}

	public UIPlaySound()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v2 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v7 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TweenFill tweenFill = TweenFill.Begin((GameObject)(object)audioClip, volume, pitch);
	}
}
