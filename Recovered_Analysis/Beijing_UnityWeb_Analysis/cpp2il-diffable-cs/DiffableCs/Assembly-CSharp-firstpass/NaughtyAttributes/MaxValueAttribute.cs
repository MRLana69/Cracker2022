namespace NaughtyAttributes;

public class MaxValueAttribute : ValidatorAttribute
{
	private float maxValue; //Field offset: 0x8

	public float MaxValue
	{
		 get { } //Length: 6
	}

	public MaxValueAttribute(float maxValue) { }

	public MaxValueAttribute(int maxValue) { }

	public float get_MaxValue() { }

}

