using System;

namespace SYBO.Components.Json;

public class SizeLimitException : Exception
{
	public SizeLimitException(string message)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = message;
	}
}
