using System;
using Cpp2ILInjected;
using TopRun;

public class TopRunEventsHandler
{
	private static TopRunEventsHandler _instance;

	private EventHandler<TournamentChangedEventArgs> m_OnTopRunChangedEvent;

	public static TopRunEventsHandler instance
	{
		get
		{
			if (_instance == null)
			{
				TopRunEventsHandler topRunEventsHandler = default;
				_instance = topRunEventsHandler;
				TopRunEventsHandler topRunEventsHandler2 = instance;
				NullReferenceException ex = new NullReferenceException();
				throw new ArgumentException();
			}
			return _instance;
		}
	}

	public event EventHandler<TournamentChangedEventArgs> OnTopRunChangedEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 8;
			Delegate obj2 = this.m_OnTopRunChangedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 8;
			Delegate obj2 = this.m_OnTopRunChangedEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private TopRunEventsHandler()
	{
	}

	public virtual void TriggerOnTopRunChanged(object o, TournamentChangedEventArgs eventArg = null)
	{
		bool flag = eventArg == null;
		bool flag2 = !flag;
		TournamentChangedEventArgs e = eventArg;
		if (!flag2)
		{
			TournamentChangedEventArgs e2 = default;
			e2._002Ector();
			e2.tournamentWasUpdated__BackingField = true;
			e = e2;
		}
		EventHandler<TournamentChangedEventArgs> onTopRunChangedEvent = this.m_OnTopRunChangedEvent;
		if (this.m_OnTopRunChangedEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S0_v9 (System.EventHandler`1<TopRun.TournamentChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}
}
