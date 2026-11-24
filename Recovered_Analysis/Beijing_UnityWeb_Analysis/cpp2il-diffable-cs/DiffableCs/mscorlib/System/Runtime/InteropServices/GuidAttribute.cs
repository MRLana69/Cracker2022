namespace System.Runtime.InteropServices;

public sealed class GuidAttribute : Attribute
{
	internal string _val; //Field offset: 0x8

	public GuidAttribute(string guid) { }

}

