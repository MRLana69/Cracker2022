using UnityEngine;

public class MinMaxRangeAttribute(float minLimit, float maxLimit) : PropertyAttribute
{
	public float minLimit = minLimit;

	public float maxLimit = maxLimit;
}
