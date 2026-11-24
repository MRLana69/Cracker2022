namespace UnityEngine.UI.CoroutineTween;

internal struct ColorTween : ITweenValue
{
	public class ColorTweenCallback
	{

		public ColorTweenCallback() { }

	}

	public enum ColorTweenMode
	{
		All = 0,
		RGB = 1,
		Alpha = 2,
	}

	private ColorTweenCallback m_Target; //Field offset: 0x0
	private Color m_StartColor; //Field offset: 0x4
	private Color m_TargetColor; //Field offset: 0x14
	private ColorTweenMode m_TweenMode; //Field offset: 0x24
	private float m_Duration; //Field offset: 0x28
	private bool m_IgnoreTimeScale; //Field offset: 0x2C

	public float duration
	{
		 get { } //Length: 6
		 set { } //Length: 41
	}

	public bool ignoreTimeScale
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Color startColor
	{
		 get { } //Length: 331
		 set { } //Length: 26
	}

	public Color targetColor
	{
		 get { } //Length: 49
		 set { } //Length: 26
	}

	public ColorTweenMode tweenMode
	{
		 get { } //Length: 9
		 set { } //Length: 49
	}

	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	public float get_duration() { }

	public bool get_ignoreTimeScale() { }

	public Color get_startColor() { }

	public Color get_targetColor() { }

	public ColorTweenMode get_tweenMode() { }

	public float GetDuration() { }

	public bool GetIgnoreTimescale() { }

	public void set_duration(float value) { }

	public void set_ignoreTimeScale(bool value) { }

	public void set_startColor(Color value) { }

	public void set_targetColor(Color value) { }

	public void set_tweenMode(ColorTweenMode value) { }

	public void TweenValue(float floatPercentage) { }

	public bool ValidTarget() { }

}

