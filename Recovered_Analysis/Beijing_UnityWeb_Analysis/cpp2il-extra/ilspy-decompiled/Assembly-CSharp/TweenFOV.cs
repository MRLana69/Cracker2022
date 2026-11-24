using System;
using Cpp2ILInjected;
using UI.Pages;
using UnityEngine;

public class TweenFOV : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (Camera)2;
		}
	}

	public float fov
	{
		get
		{
			//IL_001e: Expected I, but got Obj
			//IL_0034: Expected Obj, but got I
			//IL_010d: Expected Obj, but got I
			//IL_005f: Expected I, but got Obj
			//IL_00ae: Expected Obj, but got I
			//IL_00be: Expected F4, but got I
			if ((object)mCam == null)
			{
				((TweenFill)this).SetStartToCurrentValue();
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFOV)+64]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFOV)+64]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v15+128]");
				return 0f;
			}
			return 0f;
		}
		set
		{
			//IL_001e: Expected I, but got Obj
			//IL_0034: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I
			//IL_005f: Expected I, but got Obj
			//IL_00b3: Expected Obj, but got I
			if ((object)mCam == null)
			{
				((TweenFill)this).SetStartToCurrentValue();
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFOV)+64]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFOV)+64]");
				((UIEventListener)0).OnScroll(value);
			}
		}
	}

	public float value
	{
		get
		{
			return ((TweenOrthoSize)this).orthoSize;
		}
		set
		{
			((TweenOrthoSize)this).orthoSize = value;
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Mathf.LerpUnclamped(from, to, factor);
		fov = num3;
	}

	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		//IL_0018: Expected Obj, but got I4
		TweenFill tweenFill = UITweener.Begin<TweenFill>(go, duration);
		float num = ((TweenFOV)(object)tweenFill).fov;
		tweenFill.from = num;
		tweenFill.to = to;
		if (!(duration > 0f))
		{
			((PageTop)(object)tweenFill).Delay(1f, (Action)1);
			tweenFill.tag = null;
		}
		return (TweenFOV)(object)tweenFill;
	}

	public override void SetStartToCurrentValue()
	{
		from = 1f;
		to = 1f;
		((UI2DSprite)(object)this).OnUpdate();
	}

	public override void SetEndToCurrentValue()
	{
		float orthoSize = ((TweenOrthoSize)this).orthoSize;
		from = orthoSize;
	}

	private void SetCurrentValueToStart()
	{
		float orthoSize = ((TweenOrthoSize)this).orthoSize;
		to = orthoSize;
	}

	private void SetCurrentValueToEnd()
	{
		((TweenOrthoSize)this).orthoSize = from;
	}

	public TweenFOV()
	{
		((TweenOrthoSize)this).orthoSize = to;
	}
}
