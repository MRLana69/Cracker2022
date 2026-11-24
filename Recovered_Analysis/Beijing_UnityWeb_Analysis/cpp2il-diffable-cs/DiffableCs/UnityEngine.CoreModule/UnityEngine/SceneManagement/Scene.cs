namespace UnityEngine.SceneManagement;

public struct Scene
{
	private int m_Handle; //Field offset: 0x0

	public int handle
	{
		 get { } //Length: 49
	}

	public string name
	{
		 get { } //Length: 9
	}

	public override bool Equals(object other) { }

	public int get_handle() { }

	public string get_name() { }

	public override int GetHashCode() { }

	private static string GetNameInternal(int sceneHandle) { }

}

