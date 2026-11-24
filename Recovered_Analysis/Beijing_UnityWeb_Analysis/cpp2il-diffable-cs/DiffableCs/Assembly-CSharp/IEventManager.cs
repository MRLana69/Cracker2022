//Type is in global namespace

public interface IEventManager
{

	public long GetEventID() { }

	public SSEventType GetEventType() { }

	public T GetEventValue(out bool found) { }

	public void GetPopupDescription(out string firstTitle, out string secondTitle) { }

	public void GetPopupTitle(out string firstLine, out string secondLine) { }

	public void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine) { }

	public bool IsEventActive() { }

	public void SaveProgress() { }

}

