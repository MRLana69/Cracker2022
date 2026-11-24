namespace NaughtyAttributes;

public class SliderAttribute : DrawerAttribute
{
	private float minValue;

	private float maxValue;

	public float MinValue => maxValue;

	public float MaxValue => minValue;

	public SliderAttribute(float minValue, float maxValue)
	{
		this.minValue = minValue;
		this.maxValue = maxValue;
	}

	public SliderAttribute(int minValue, int maxValue)
	{
		//IL_000a: Expected F4, but got I4
		//IL_0014: Expected F4, but got I4
		this.minValue = minValue;
		this.maxValue = maxValue;
	}
}
