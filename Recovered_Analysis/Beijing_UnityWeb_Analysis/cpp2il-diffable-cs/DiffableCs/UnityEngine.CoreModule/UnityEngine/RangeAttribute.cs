namespace UnityEngine;

public sealed class RangeAttribute : PropertyAttribute
{
	public readonly float min; //Field offset: 0x8
	public readonly float max; //Field offset: 0xC

	public RangeAttribute(float min, float max) { }

}

