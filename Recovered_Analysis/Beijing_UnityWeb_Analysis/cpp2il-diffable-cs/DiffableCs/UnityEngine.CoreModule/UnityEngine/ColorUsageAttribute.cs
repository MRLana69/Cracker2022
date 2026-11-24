namespace UnityEngine;

public sealed class ColorUsageAttribute : PropertyAttribute
{
	public readonly bool showAlpha; //Field offset: 0x8
	public readonly bool hdr; //Field offset: 0x9
	public readonly float minBrightness; //Field offset: 0xC
	public readonly float maxBrightness; //Field offset: 0x10
	public readonly float minExposureValue; //Field offset: 0x14
	public readonly float maxExposureValue; //Field offset: 0x18

	public ColorUsageAttribute(bool showAlpha) { }

}

