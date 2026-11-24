using System;
using Cpp2ILInjected;
using UI.Pages;
using UnityEngine;

public class TweenOrthoSize : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		get
		{
			//IL_0017: Expected Obj, but got I
			int height = ((TweenHeight)this).height;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+68]");
			return (Camera)0;
		}
	}

	public float orthoSize
	{
		get
		{
			UIWidget cachedWidget = ((TweenHeight)this).cachedWidget;
			return ((Camera)(object)cachedWidget).orthographicSize;
		}
		set
		{
			UIWidget cachedWidget = ((TweenHeight)this).cachedWidget;
			((Camera)(object)cachedWidget).orthographicSize = value;
		}
	}

	public float value
	{
		get
		{
			return ((TweenVolume)this).volume;
		}
		set
		{
			((TweenVolume)this).volume = value;
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
	{
		//IL_0018: Expected Obj, but got I4
		TweenFOV tweenFOV = UITweener.Begin<TweenFOV>(go, duration);
		float num = ((TweenOrthoSize)(object)tweenFOV).orthoSize;
		tweenFOV.from = num;
		tweenFOV.to = to;
		if (!(duration > 0f))
		{
			((PageTop)(object)tweenFOV).Delay(1f, (Action)1);
			tweenFOV.tag = null;
		}
		return (TweenOrthoSize)(object)tweenFOV;
	}

	public override void SetStartToCurrentValue()
	{
		_ = -1;
		((UI2DSprite)(object)this).OnUpdate();
	}

	public override void SetEndToCurrentValue()
	{
		float volume = ((TweenVolume)this).volume;
		from = volume;
	}

	public TweenOrthoSize()
	{
		float volume = ((TweenVolume)this).volume;
		to = volume;
	}
}
