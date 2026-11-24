using System;
using UnityEngine;

namespace SYBO.Components.Utilities.Exceptions;

public class EnvironmentException : Exception
{
	public EnvironmentException()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		string temporaryCachePath = Application.temporaryCachePath;
		obj = temporaryCachePath;
	}
}
