using System;

namespace SYBO.Components.Json;

public class SerializedSizeLimitAttribute : Attribute
{
	public readonly bool FailOnLimit;

	public readonly int Size;

	public SerializedSizeLimitAttribute(int size, bool failOnLimit = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		object obj = this + 8;
		obj = size;
		object obj2 = this + 12;
		obj2 = failOnLimit;
	}
}
