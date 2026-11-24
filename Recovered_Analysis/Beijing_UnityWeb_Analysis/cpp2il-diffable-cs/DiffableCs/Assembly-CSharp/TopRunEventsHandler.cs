//Type is in global namespace

public class TopRunEventsHandler
{
	private static TopRunEventsHandler _instance; //Field offset: 0x0
	private EventHandler<TournamentChangedEventArgs> OnTopRunChangedEvent; //Field offset: 0x8

	public event EventHandler<TournamentChangedEventArgs> OnTopRunChangedEvent
	{
		 add { } //Length: 842
		 remove { } //Length: 111
	}

	public static TopRunEventsHandler instance
	{
		 get { } //Length: 97
	}

	private TopRunEventsHandler() { }

	public void add_OnTopRunChangedEvent(EventHandler<TournamentChangedEventArgs> value) { }

	public static TopRunEventsHandler get_instance() { }

	public void remove_OnTopRunChangedEvent(EventHandler<TournamentChangedEventArgs> value) { }

	public virtual void TriggerOnTopRunChanged(object o, TournamentChangedEventArgs eventArg = null) { }

}

