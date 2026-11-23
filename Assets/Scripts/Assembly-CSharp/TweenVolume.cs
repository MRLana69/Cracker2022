using UnityEngine;

public class TweenVolume : UITweener
{
	public float from = 1f;

	public float to;

	private AudioSource mSource;

	public AudioSource audioSource
	{
		get
		{
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected Obj, but got Unknown
			object result = this + 88;
			if (mSource == null)
			{
				AudioSource component = GetComponent<AudioSource>();
				mSource = component;
				if (mSource == null)
				{
					AudioSource component2 = GetComponent<AudioSource>();
					mSource = component2;
					if (mSource == null)
					{
						enabled = false;
					}
				}
			}
			return (AudioSource)result;
		}
	}

	public float volume
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
			AudioSource audioSource = this.audioSource;
			if (audioSource != null)
			{
				return mSource.volume;
			}
			return 0f;
		}
		set
		{
			AudioSource audioSource = this.audioSource;
			if (audioSource != null)
			{
				mSource.volume = value;
			}
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		float num = 1f - factor;
		float num2 = from * num;
		float num3 = to * factor;
		float num4 = num2 + num3;
		value = num4;
		float num5 = mSource.volume;
		bool flag = num5 > 0.01f;
		mSource.enabled = flag;
	}

	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		TweenVolume tweenVolume = UITweener.Begin<TweenVolume>(go, duration);
		float num = tweenVolume.value;
		tweenVolume.to = targetVolume;
		tweenVolume.from = num;
		if (targetVolume > 0f)
		{
			AudioSource audioSource = tweenVolume.audioSource;
			audioSource.enabled = true;
			AudioSource audioSource2 = tweenVolume.audioSource;
			audioSource2.Play();
		}
		return tweenVolume;
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
