namespace UnityEngine;

public sealed class TextAreaAttribute : PropertyAttribute
{
	public readonly int minLines; //Field offset: 0x8
	public readonly int maxLines; //Field offset: 0xC

	public TextAreaAttribute() { }

	public TextAreaAttribute(int minLines, int maxLines) { }

}

