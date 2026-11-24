namespace Kiloo.GameCenter;

public class GameCenterRequest
{
	private float <timeout>k__BackingField; //Field offset: 0x8
	private bool <didTimeout>k__BackingField; //Field offset: 0xC
	private bool <isDone>k__BackingField; //Field offset: 0xD
	private string <error>k__BackingField; //Field offset: 0x10

	public bool didTimeout
	{
		 get { } //Length: 168
		internal set { } //Length: 277
	}

	public string error
	{
		 get { } //Length: 9
		internal set { } //Length: 11
	}

	public bool isDone
	{
		 get { } //Length: 9
		internal set { } //Length: 11
	}

	public float timeout
	{
		 get { } //Length: 17
		 set { } //Length: 8
	}

	public GameCenterRequest() { }

	public bool get_didTimeout() { }

	public string get_error() { }

	public bool get_isDone() { }

	public float get_timeout() { }

	internal void set_didTimeout(bool value) { }

	internal void set_error(string value) { }

	internal void set_isDone(bool value) { }

	public void set_timeout(float value) { }

}

