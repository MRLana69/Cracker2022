namespace SYBO.Subway.Level.TrackEvents;

public abstract class Activity : MonoBehaviour
{
	protected bool _initialized; //Field offset: 0xC
	protected Transform _transform; //Field offset: 0x10
	protected bool _running; //Field offset: 0x14

	public bool Running
	{
		 get { } //Length: 9
	}

	protected Activity() { }

	protected void CheckInitialize() { }

	protected abstract void Execute() { }

	public bool get_Running() { }

	protected virtual void Initialize() { }

	public virtual void Prepare(IActivityInitializer initializer) { }

	public void Run() { }

	private void Start() { }

	public virtual void Stop() { }

	private void Update() { }

}

