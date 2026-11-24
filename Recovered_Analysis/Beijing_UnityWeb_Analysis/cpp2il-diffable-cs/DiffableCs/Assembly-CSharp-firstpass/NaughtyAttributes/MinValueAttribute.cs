namespace NaughtyAttributes;

public class MinValueAttribute : ValidatorAttribute
{
	private float minValue; //Field offset: 0x8

	public float MinValue
	{
		 get { } //Length: 6
	}

	public MinValueAttribute(float minValue) { }

	public MinValueAttribute(int minValue) { }

	public float get_MinValue() { }

}

