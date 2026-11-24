//Type is in global namespace

public class SuperMysteryBoxEventManager : IEventManager
{
	private SSEventType _eventType; //Field offset: 0x8
	private long _eventID; //Field offset: 0x10

	public SuperMysteryBoxEventManager() { }

	public static SuperMysteryBoxEventManager Create(SSEventType eventType, long eventID) { }

	public long GetEventID() { }

	public SSEventType GetEventType() { }

	public T GetEventValue(out bool found) { }

	public void GetPopupDescription(out string firstTitle, out string secondTitle) { }

	public void GetPopupTitle(out string firstLine, out string secondLine) { }

	public void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine) { }

	private void Initialize(SSEventType eventType, long eventID) { }

	public bool IsEventActive() { }

	public void SaveProgress() { }

}

