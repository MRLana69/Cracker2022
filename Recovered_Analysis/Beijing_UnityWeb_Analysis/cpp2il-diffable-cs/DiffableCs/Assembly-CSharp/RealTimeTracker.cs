//Type is in global namespace

public class RealTimeTracker : MonoBehaviour
{
	private static RealTimeTracker mInst; //Field offset: 0x0
	private float mRealTime; //Field offset: 0xC
	private float mRealDelta; //Field offset: 0x10

	public static float deltaTime
	{
		 get { } //Length: 119
	}

	public static float time
	{
		 get { } //Length: 6
	}

	public RealTimeTracker() { }

	public static float get_deltaTime() { }

	public static float get_time() { }

	private static void Spawn() { }

	private void Update() { }

}

