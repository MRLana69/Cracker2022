namespace NaughtyAttributes;

public class SliderAttribute : DrawerAttribute
{
	private float minValue; //Field offset: 0x8
	private float maxValue; //Field offset: 0xC

	public float MaxValue
	{
		 get { } //Length: 6
	}

	public float MinValue
	{
		 get { } //Length: 6
	}

	public SliderAttribute(float minValue, float maxValue) { }

	public SliderAttribute(int minValue, int maxValue) { }

	public float get_MaxValue() { }

	public float get_MinValue() { }

}

