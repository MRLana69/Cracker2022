using System;

namespace SYBO.Components.Json;

public class SerializedAsAttribute(string serializeAsName) : Attribute
{
	public readonly string SerializedAsName = serializeAsName;
}
