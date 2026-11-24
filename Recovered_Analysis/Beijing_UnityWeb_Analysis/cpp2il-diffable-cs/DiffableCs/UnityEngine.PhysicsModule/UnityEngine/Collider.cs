namespace UnityEngine;

public class Collider : Component
{

	public Bounds bounds
	{
		 get { } //Length: 53
	}

	public bool enabled
	{
		 get { } //Length: 12
		 set { } //Length: 53
	}

	public bool isTrigger
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public Collider() { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_enabled() { }

	public bool get_isTrigger() { }

	public void set_enabled(bool value) { }

	public void set_isTrigger(bool value) { }

}

