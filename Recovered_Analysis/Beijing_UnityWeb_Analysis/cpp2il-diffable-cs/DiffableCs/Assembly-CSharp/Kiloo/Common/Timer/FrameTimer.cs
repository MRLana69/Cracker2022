namespace Kiloo.Common.Timer;

public class FrameTimer : BaseTimer
{
	private int _elapsedFrames; //Field offset: 0x14
	private int _framesToDelay; //Field offset: 0x18

	private FrameTimer(int framesToDelay, bool oneShot = false) { }

	public static void ExecuteWithDelay(int framesToDelay, Action action) { }

	public override void Start() { }

	public override void Stop() { }

	private void Update(float deltaTime) { }

}

