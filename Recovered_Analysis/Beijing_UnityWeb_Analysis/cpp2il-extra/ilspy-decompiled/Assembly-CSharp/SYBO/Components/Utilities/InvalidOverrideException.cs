using System;

namespace SYBO.Components.Utilities;

public class InvalidOverrideException : Exception
{
	public InvalidOverrideException()
	{
	}

	public InvalidOverrideException(string message)
	{
		Environment.InternalSetEnvironmentVariable((string)(object)this, message);
	}
}
