namespace SYBO.Components.Json;

public class SerializeFileAttribute : Attribute
{
	public string SerializedFilename; //Field offset: 0x8

	public SerializeFileAttribute(string serializedFilename) { }

}

