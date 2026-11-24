namespace SYBO.Subway.Level.TrackEvents;

public abstract class TrackEvent : MonoBehaviour
{
	private float _probability; //Field offset: 0xC
	protected Transform _transform; //Field offset: 0x10
	private TrackObject _trackObject; //Field offset: 0x14
	protected bool _launched; //Field offset: 0x18
	private Action Launching; //Field offset: 0x1C
	private Action Stopped; //Field offset: 0x20

	public event Action Launching
	{
		 add { } //Length: 417
		 remove { } //Length: 111
	}

	public event Action Stopped
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	protected TrackEvent() { }

	public void add_Launching(Action value) { }

	public void add_Stopped(Action value) { }

	protected void EvaluateAndLaunchEvent() { }

	protected virtual void Initialize() { }

	protected abstract void Launch() { }

	protected virtual void OnDestroy() { }

	public void remove_Launching(Action value) { }

	public void remove_Stopped(Action value) { }

	private void Start() { }

	protected virtual void TrackObject_OnActivate() { }

	protected virtual void TrackObject_OnDeactivate() { }

}

