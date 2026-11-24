namespace SYBO.Subway.Routes.Log;

public class RoutesLogData
{
	private float _timeStamp; //Field offset: 0x8
	private RoutesLogType _routesLogType; //Field offset: 0xC
	private object[] _args; //Field offset: 0x10
	protected string _message; //Field offset: 0x14

	public object[] Args
	{
		 get { } //Length: 6
	}

	public string Message
	{
		 get { } //Length: 6
	}

	public RoutesLogType RoutesLogType
	{
		 get { } //Length: 603
	}

	public float TimeStamp
	{
		 get { } //Length: 6
	}

	public RoutesLogData(RoutesLogType pickupLogType, object[] args) { }

	public object[] get_Args() { }

	public string get_Message() { }

	public RoutesLogType get_RoutesLogType() { }

	public float get_TimeStamp() { }

	public override string ToString() { }

}

