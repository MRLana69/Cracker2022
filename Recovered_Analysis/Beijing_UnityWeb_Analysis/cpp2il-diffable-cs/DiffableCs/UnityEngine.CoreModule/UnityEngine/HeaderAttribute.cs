namespace UnityEngine;

public class HeaderAttribute : PropertyAttribute
{
	public readonly string header; //Field offset: 0x8

	public HeaderAttribute(string header) { }

}

