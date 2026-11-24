namespace UnityEngine.UI.CoroutineTween;

internal struct FloatTween : ITweenValue
{
	public class FloatTweenCallback
	{

		public FloatTweenCallback() { }

	}

	private FloatTweenCallback m_Target; //Field offset: 0x0
	private float m_StartValue; //Field offset: 0x4
	private float m_TargetValue; //Field offset: 0x8
	private float m_Duration; //Field offset: 0xC
	private bool m_IgnoreTimeScale; //Field offset: 0x10

	public float duration
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool ignoreTimeScale
	{
		 get { } //Length: 12
		 set { } //Length: 14
	}

	public float startValue
	{
		 get { } //Length: 9
		 set { } //Length: 14
	}

	public float targetValue
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public void AddOnChangedCallback(UnityAction<float> callback) { }

	public float get_duration() { }

	public bool get_ignoreTimeScale() { }

	public float get_startValue() { }

	public float get_targetValue() { }

	public float GetDuration() { }

	public bool GetIgnoreTimescale() { }

	public void set_duration(float value) { }

	public void set_ignoreTimeScale(bool value) { }

	public void set_startValue(float value) { }

	public void set_targetValue(float value) { }

	public void TweenValue(float floatPercentage) { }

	public bool ValidTarget() { }

}

