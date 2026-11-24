namespace Kiloo.Common.Timer;

public class Timer : BaseTimer
{
	private double _currentInterval; //Field offset: 0x18
	private string _name; //Field offset: 0x20

	public Timer(float timerInterval, bool oneShot = false) { }

	public Timer() { }

	public static void ExecuteNextFrame(Action action) { }

	public static void ExecuteWithDelay(float delay, Action action) { }

	private static void Log(string message) { }

	public void SetName(string name) { }

	public override void Start() { }

	public override void Stop() { }

	private void Update(float deltaTime) { }

}

