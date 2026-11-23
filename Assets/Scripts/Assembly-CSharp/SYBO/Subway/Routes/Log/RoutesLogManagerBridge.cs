namespace SYBO.Subway.Routes.Log;

public static class RoutesLogManagerBridge
{
	public static bool IsLogging
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public static int ForcedZBuildValue
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}
}
