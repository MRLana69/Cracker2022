namespace UnityEngine;

public sealed class Light : Behaviour
{
	private int m_BakedIndex; //Field offset: 0xC

	public float bounceIntensity
	{
		 get { } //Length: 49
	}

	public Color color
	{
		 get { } //Length: 53
		 set { } //Length: 60
	}

	public float intensity
	{
		 get { } //Length: 49
		 set { } //Length: 17
	}

	public float range
	{
		 get { } //Length: 49
	}

	public LightShadows shadows
	{
		 get { } //Length: 49
	}

	public float spotAngle
	{
		 get { } //Length: 17
	}

	public LightType type
	{
		 get { } //Length: 9
	}

	public float get_bounceIntensity() { }

	public Color get_color() { }

	private void get_color_Injected(out Color ret) { }

	public float get_intensity() { }

	public float get_range() { }

	public LightShadows get_shadows() { }

	public float get_spotAngle() { }

	public LightType get_type() { }

	public void set_color(Color value) { }

	private void set_color_Injected(ref Color value) { }

	public void set_intensity(float value) { }

}

