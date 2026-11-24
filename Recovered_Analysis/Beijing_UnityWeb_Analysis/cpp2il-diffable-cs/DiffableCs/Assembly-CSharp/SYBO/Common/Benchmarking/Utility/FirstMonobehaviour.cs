namespace SYBO.Common.Benchmarking.Utility;

public class FirstMonobehaviour : SubscribableMonobehaviour
{
	public Action OnOnGUI; //Field offset: 0x18
	public Action<bool> OnOnApplicationPause; //Field offset: 0x1C

	public FirstMonobehaviour() { }

	private void Awake() { }

	private void OnApplicationPause(bool pause) { }

	private void OnGUI() { }

}

