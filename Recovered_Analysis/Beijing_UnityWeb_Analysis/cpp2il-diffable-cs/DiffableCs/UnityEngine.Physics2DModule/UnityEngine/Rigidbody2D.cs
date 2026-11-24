namespace UnityEngine;

public sealed class Rigidbody2D : Component
{

	public float angularVelocity
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public RigidbodyType2D bodyType
	{
		 set { } //Length: 11
	}

	public bool isKinematic
	{
		 set { } //Length: 53
	}

	public Vector2 position
	{
		 get { } //Length: 39
		 set { } //Length: 43
	}

	public float rotation
	{
		 get { } //Length: 9
		 set { } //Length: 52
	}

	public Vector2 velocity
	{
		 get { } //Length: 11
		 set { } //Length: 43
	}

	public float get_angularVelocity() { }

	public Vector2 get_position() { }

	private void get_position_Injected(out Vector2 ret) { }

	public float get_rotation() { }

	public Vector2 get_velocity() { }

	private void get_velocity_Injected(out Vector2 ret) { }

	public void MoveRotation(float angle) { }

	private void MoveRotation_Angle(float angle) { }

	public void set_angularVelocity(float value) { }

	public void set_bodyType(RigidbodyType2D value) { }

	public void set_isKinematic(bool value) { }

	public void set_position(Vector2 value) { }

	private void set_position_Injected(ref Vector2 value) { }

	public void set_rotation(float value) { }

	public void set_velocity(Vector2 value) { }

	private void set_velocity_Injected(ref Vector2 value) { }

}

