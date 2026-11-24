namespace SYBO.Components.Json;

public class SerializedSizeLimitAttribute : Attribute
{
	public readonly bool FailOnLimit; //Field offset: 0x8
	public readonly int Size; //Field offset: 0xC

	public SerializedSizeLimitAttribute(int size, bool failOnLimit = false) { }

}

