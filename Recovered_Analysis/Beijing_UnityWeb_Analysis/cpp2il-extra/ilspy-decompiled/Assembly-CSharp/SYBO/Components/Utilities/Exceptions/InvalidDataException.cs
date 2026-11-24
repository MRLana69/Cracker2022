using System;

namespace SYBO.Components.Utilities.Exceptions;

public class InvalidDataException : Exception
{
	public InvalidDataException(string message)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = message;
	}
}
