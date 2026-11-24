namespace SYBO.Components.Utilities.Exceptions;

public class SwitchDefaultException : Exception
{

	public SwitchDefaultException(string missingValue) { }

	public static void Throw(object missingValue) { }

}

