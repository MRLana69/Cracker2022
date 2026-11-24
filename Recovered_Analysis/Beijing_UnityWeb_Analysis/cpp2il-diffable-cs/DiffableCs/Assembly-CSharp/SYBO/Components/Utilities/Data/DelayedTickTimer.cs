namespace SYBO.Components.Utilities.Data;

public class DelayedTickTimer
{
	private const float UnsetFloat = -1; //Field offset: 0x0
	private float _targetFPS; //Field offset: 0x8
	private long _ticksLast; //Field offset: 0x10
	private long _ticksCurrent; //Field offset: 0x18
	private float _delayTarget; //Field offset: 0x20
	private float _deltaTime; //Field offset: 0x24

	public float DeltaTime
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float TargetFPS
	{
		 get { } //Length: 6
		 set { } //Length: 142
	}

	public DelayedTickTimer(float targetFPS) { }

	public float get_DeltaTime() { }

	public float get_TargetFPS() { }

	public void set_DeltaTime(float value) { }

	public void set_TargetFPS(float value) { }

	public bool Tick() { }

}

