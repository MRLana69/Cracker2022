//Type is in global namespace

public class MinMaxRangeAttribute : PropertyAttribute
{
	public float minLimit; //Field offset: 0x8
	public float maxLimit; //Field offset: 0xC

	public MinMaxRangeAttribute(float minLimit, float maxLimit) { }

}

