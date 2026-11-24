namespace Kiloo.Common.Timer;

public class RealTimer : BaseTimer
{
	private DateTime _startStamp; //Field offset: 0x18
	public bool multiTrigger; //Field offset: 0x20

	public RealTimer(float timerInterval, bool oneShot = false) { }

	public RealTimer() { }

	protected virtual DateTime GetCurrentTime() { }

	private static void Log(string message) { }

	public override void Start() { }

	public override void Stop() { }

	private void Update(float deltaTime) { }

}

