namespace SYBO.Components.Analytics.Integration;

public interface ISubwayBaseEvent
{

	public string EventId
	{
		 get { } //Length: 0
	}

	public int SessionEventId
	{
		 get { } //Length: 0
	}

	public int SessionId
	{
		 get { } //Length: 0
	}

	public string UserId
	{
		 get { } //Length: 0
	}

	public string get_EventId() { }

	public int get_SessionEventId() { }

	public int get_SessionId() { }

	public string get_UserId() { }

}

