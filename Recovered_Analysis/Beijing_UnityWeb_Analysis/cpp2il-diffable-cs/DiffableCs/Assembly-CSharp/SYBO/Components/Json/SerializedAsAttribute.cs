namespace SYBO.Components.Json;

public class SerializedAsAttribute : Attribute
{
	public readonly string SerializedAsName; //Field offset: 0x8

	public SerializedAsAttribute(string serializeAsName) { }

}

