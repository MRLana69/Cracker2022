namespace Kiloo.Common.Utility;

public class StaticUpdater : MonoBehaviour
{
	private static StaticUpdater _instance; //Field offset: 0x0
	private Action<float> onUpdate; //Field offset: 0xC
	private Action<float> onLateUpdate; //Field offset: 0x10

	public event Action<float> onLateUpdate
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<float> onUpdate
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	public static StaticUpdater instance
	{
		 get { } //Length: 93
	}

	public StaticUpdater() { }

	public void add_onLateUpdate(Action<float> value) { }

	public void add_onUpdate(Action<float> value) { }

	private void Debug() { }

	public static StaticUpdater get_instance() { }

	private void LateUpdate() { }

	public void remove_onLateUpdate(Action<float> value) { }

	public void remove_onUpdate(Action<float> value) { }

	private void Update() { }

}

