namespace SYBO.Components.Base;

public class BaseEnvironment
{
	private static bool _isRunningUnitTests; //Field offset: 0x0

	public static bool IsRunningUnitTests
	{
		 get { } //Length: 89
	}

	private static BaseEnvironment() { }

	public BaseEnvironment() { }

	public static bool get_IsRunningUnitTests() { }

}

