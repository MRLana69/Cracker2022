namespace NaughtyAttributes;

public class MinValueAttribute : ValidatorAttribute
{
	private float minValue;

	public float MinValue => minValue;

	public MinValueAttribute(float minValue)
	{
		this.minValue = minValue;
	}

	public MinValueAttribute(int minValue)
	{
		//IL_000a: Expected F4, but got I4
		this.minValue = minValue;
	}
}
