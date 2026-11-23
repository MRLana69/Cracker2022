using System;

namespace SYBO.Components.Json;

public class SerializedSizeLimitAttribute(int size, bool failOnLimit = false) : Attribute
{
	public readonly bool FailOnLimit = failOnLimit;

	public readonly int Size = size;
}
