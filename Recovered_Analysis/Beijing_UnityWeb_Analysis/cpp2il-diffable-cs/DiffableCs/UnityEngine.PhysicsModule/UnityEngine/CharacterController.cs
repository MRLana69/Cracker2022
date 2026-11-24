namespace UnityEngine;

public class CharacterController : Collider
{

	public Vector3 center
	{
		 get { } //Length: 60
		 set { } //Length: 60
	}

	public bool detectCollisions
	{
		 set { } //Length: 11
	}

	public float height
	{
		 get { } //Length: 9
		 set { } //Length: 52
	}

	public bool isGrounded
	{
		 get { } //Length: 49
	}

	public float skinWidth
	{
		 get { } //Length: 49
	}

	public Vector3 velocity
	{
		 get { } //Length: 53
	}

	public Vector3 get_center() { }

	private void get_center_Injected(out Vector3 ret) { }

	public float get_height() { }

	public bool get_isGrounded() { }

	public float get_skinWidth() { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public CollisionFlags Move(Vector3 motion) { }

	private CollisionFlags Move_Injected(ref Vector3 motion) { }

	public void set_center(Vector3 value) { }

	private void set_center_Injected(ref Vector3 value) { }

	public void set_detectCollisions(bool value) { }

	public void set_height(float value) { }

}

