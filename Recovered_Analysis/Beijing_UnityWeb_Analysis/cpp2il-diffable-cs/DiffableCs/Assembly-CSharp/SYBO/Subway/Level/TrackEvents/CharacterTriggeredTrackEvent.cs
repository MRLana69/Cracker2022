namespace SYBO.Subway.Level.TrackEvents;

public abstract class CharacterTriggeredTrackEvent : TrackEvent
{
	protected CharacterPassTrigger _trigger; //Field offset: 0x24

	public TrackEventTrigger Trigger
	{
		 get { } //Length: 9
	}

	protected CharacterTriggeredTrackEvent() { }

	private void CharacterPassTrigger_Triggered(object sender, EventArgs e) { }

	public TrackEventTrigger get_Trigger() { }

	protected override void Initialize() { }

	protected override void OnDestroy() { }

}

