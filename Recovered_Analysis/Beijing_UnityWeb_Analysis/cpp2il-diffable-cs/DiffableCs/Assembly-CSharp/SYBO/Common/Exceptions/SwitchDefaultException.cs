namespace SYBO.Common.Exceptions;

public class SwitchDefaultException : Exception
{

	public SwitchDefaultException(string missingSwitchValue) { }

	public static void Throw(string missingSwitchValue) { }

}

