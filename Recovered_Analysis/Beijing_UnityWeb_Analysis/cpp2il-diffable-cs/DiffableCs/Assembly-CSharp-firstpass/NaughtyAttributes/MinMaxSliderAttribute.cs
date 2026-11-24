namespace NaughtyAttributes;

public class MinMaxSliderAttribute : DrawerAttribute
{
	private float minValue; //Field offset: 0x8
	private float maxValue; //Field offset: 0xC

	public float MaxValue
	{
		 get { } //Length: 6
	}

	public float MinValue
	{
		 get { } //Length: 49
	}

	public MinMaxSliderAttribute(float minValue, float maxValue) { }

	public float get_MaxValue() { }

	public float get_MinValue() { }

}

