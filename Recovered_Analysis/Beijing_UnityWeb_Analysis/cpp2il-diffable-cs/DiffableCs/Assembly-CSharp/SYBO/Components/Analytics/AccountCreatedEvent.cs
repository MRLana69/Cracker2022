namespace SYBO.Components.Analytics;

public class AccountCreatedEvent : BaseSessionEvent
{
	protected string _deviceID; //Field offset: 0x24
	protected float _samplingKey; //Field offset: 0x28

	public string DeviceID
	{
		 get { } //Length: 6
	}

	public override string EventName
	{
		 get { } //Length: 6
	}

	public float SamplingKey
	{
		 get { } //Length: 45
	}

	public AccountCreatedEvent() { }

	public string get_DeviceID() { }

	public override string get_EventName() { }

	public float get_SamplingKey() { }

}

