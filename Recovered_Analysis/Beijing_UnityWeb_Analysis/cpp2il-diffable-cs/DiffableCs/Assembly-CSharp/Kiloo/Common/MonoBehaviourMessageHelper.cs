namespace Kiloo.Common;

public class MonoBehaviourMessageHelper : MonoBehaviour
{
	private Action<bool> applicationPause; //Field offset: 0xC
	private Action<bool> applicationFocus; //Field offset: 0x10
	private Action applicationQuit; //Field offset: 0x14

	public event Action<bool> applicationFocus
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<bool> applicationPause
	{
		 add { } //Length: 56
		 remove { } //Length: 111
	}

	public event Action applicationQuit
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public MonoBehaviourMessageHelper() { }

	public void add_applicationFocus(Action<bool> value) { }

	public void add_applicationPause(Action<bool> value) { }

	public void add_applicationQuit(Action value) { }

	private void OnApplicationFocus(bool inFocus) { }

	private void OnApplicationPause(bool paused) { }

	private void OnApplicationQuit() { }

	public void remove_applicationFocus(Action<bool> value) { }

	public void remove_applicationPause(Action<bool> value) { }

	public void remove_applicationQuit(Action value) { }

}

