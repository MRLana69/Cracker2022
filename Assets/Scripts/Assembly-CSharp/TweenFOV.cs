using UnityEngine;

public class TweenFOV : UITweener
{
	public float from = 45f;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 88;
			if (mCam == null)
			{
				Camera component = GetComponent<Camera>();
				mCam = component;
			}
			return (Camera)result;
		}
	}

	public float fov
	{
		get
		{
			return value;
		}
		set
		{
			this.value = value;
		}
	}

	public float value
	{
		get
		{
			Camera camera = cachedCamera;
			return camera.fieldOfView;
		}
		set
		{
			Camera camera = cachedCamera;
			camera.fieldOfView = value;
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		float num = 1f - factor;
		float num2 = from * num;
		float num3 = to * factor;
		float num4 = num2 + num3;
		value = num4;
	}

	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		TweenFOV tweenFOV = UITweener.Begin<TweenFOV>(go, duration);
		float num = tweenFOV.value;
		tweenFOV.to = to;
		tweenFOV.from = num;
		if (!(duration > 0f))
		{
			tweenFOV.Sample(1f, isFinished: true);
			tweenFOV.enabled = false;
		}
		return tweenFOV;
	}

	public override void SetStartToCurrentValue()
	{
		float num = value;
		from = num;
	}

	public override void SetEndToCurrentValue()
	{
		float num = value;
		to = num;
	}

	private void SetCurrentValueToStart()
	{
		value = from;
	}

	private void SetCurrentValueToEnd()
	{
		value = to;
	}
}
