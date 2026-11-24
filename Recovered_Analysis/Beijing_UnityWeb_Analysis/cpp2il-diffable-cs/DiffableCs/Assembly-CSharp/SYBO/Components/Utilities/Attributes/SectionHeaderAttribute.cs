namespace SYBO.Components.Utilities.Attributes;

public class SectionHeaderAttribute : PropertyAttribute
{
	public const int SizeH1 = 18; //Field offset: 0x0
	public const int SizeH2 = 16; //Field offset: 0x0
	public const int SizeH3 = 12; //Field offset: 0x0
	public const int SizeDefault = 12; //Field offset: 0x0
	public string Text; //Field offset: 0x8
	public int Size; //Field offset: 0xC

	public SectionHeaderAttribute(string text, int size) { }

	public SectionHeaderAttribute(string text) { }

}

