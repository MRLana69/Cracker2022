namespace SYBO.Subway.Routes.Prototypes;

public interface IRouteEffectGUISubject
{

	public event Action OnCharacterEntryStarted
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action OnEnteredSkatePark
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action OnEnteredTallyScreen
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action OnExitedSkatePark
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<int> OnGearChanged
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<int> OnTokenChanged
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public void add_OnCharacterEntryStarted(Action value) { }

	public void add_OnEnteredSkatePark(Action value) { }

	public void add_OnEnteredTallyScreen(Action value) { }

	public void add_OnExitedSkatePark(Action value) { }

	public void add_OnGearChanged(Action<int> value) { }

	public void add_OnTokenChanged(Action<int> value) { }

	public void remove_OnCharacterEntryStarted(Action value) { }

	public void remove_OnEnteredSkatePark(Action value) { }

	public void remove_OnEnteredTallyScreen(Action value) { }

	public void remove_OnExitedSkatePark(Action value) { }

	public void remove_OnGearChanged(Action<int> value) { }

	public void remove_OnTokenChanged(Action<int> value) { }

}

