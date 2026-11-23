using UnityEngine;

public class TweenOrthoSize : UITweener
{
	public float from = 1f;

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

	public float orthoSize
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
			return camera.orthographicSize;
		}
		set
		{
			Camera camera = cachedCamera;
			camera.orthographicSize = value;
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

	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
	{
		TweenOrthoSize tweenOrthoSize = UITweener.Begin<TweenOrthoSize>(go, duration);
		float num = tweenOrthoSize.value;
		tweenOrthoSize.to = to;
		tweenOrthoSize.from = num;
		if (!(duration > 0f))
		{
			tweenOrthoSize.Sample(1f, isFinished: true);
			tweenOrthoSize.enabled = false;
		}
		return tweenOrthoSize;
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
}
