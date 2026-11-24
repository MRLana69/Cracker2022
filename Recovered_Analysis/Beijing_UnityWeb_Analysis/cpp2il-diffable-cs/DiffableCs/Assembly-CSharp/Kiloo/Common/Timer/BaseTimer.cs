namespace Kiloo.Common.Timer;

public abstract class BaseTimer
{
	protected readonly bool singleShot; //Field offset: 0x8
	protected bool _running; //Field offset: 0x9
	private float <interval>k__BackingField; //Field offset: 0xC
	private Action intervalElapsed; //Field offset: 0x10

	public event Action intervalElapsed
	{
		 add { } //Length: 459
		 remove { } //Length: 111
	}

	public float interval
	{
		protected get { } //Length: 6
		 set { } //Length: 620
	}

	public bool isRunning
	{
		 get { } //Length: 59
	}

	protected BaseTimer(float timerInterval, bool oneShot = false) { }

	public BaseTimer() { }

	public void add_intervalElapsed(Action value) { }

	protected float get_interval() { }

	public bool get_isRunning() { }

	public void remove_intervalElapsed(Action value) { }

	public void set_interval(float value) { }

	public abstract void Start() { }

	public abstract void Stop() { }

	protected void TriggerIntervalElapsed() { }

}

