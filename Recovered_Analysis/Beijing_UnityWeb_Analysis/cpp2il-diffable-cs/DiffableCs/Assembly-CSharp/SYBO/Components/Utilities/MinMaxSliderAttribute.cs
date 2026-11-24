namespace SYBO.Components.Utilities;

public class MinMaxSliderAttribute : PropertyAttribute
{
	public readonly float max; //Field offset: 0x8
	public readonly float min; //Field offset: 0xC

	public MinMaxSliderAttribute(float min, float max) { }

}

