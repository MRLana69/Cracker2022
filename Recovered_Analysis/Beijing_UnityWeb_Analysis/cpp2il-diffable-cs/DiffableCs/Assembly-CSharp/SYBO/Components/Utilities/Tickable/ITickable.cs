namespace SYBO.Components.Utilities.Tickable;

public interface ITickable
{

	public bool IsTickable
	{
		 get { } //Length: 0
	}

	public bool get_IsTickable() { }

	public void OnTick(bool isApplicationFocused, bool isApplicationPaused, float deltaTime) { }

}

