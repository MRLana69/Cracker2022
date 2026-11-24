namespace UnityEngine;

public class Rigidbody : Component
{

	public Vector3 angularVelocity
	{
		 get { } //Length: 11
		 set { } //Length: 60
	}

	public bool isKinematic
	{
		 set { } //Length: 53
	}

	public Vector3 position
	{
		 get { } //Length: 53
		 set { } //Length: 60
	}

	public Quaternion rotation
	{
		 get { } //Length: 11
		 set { } //Length: 60
	}

	public bool useGravity
	{
		 set { } //Length: 11
	}

	public Vector3 velocity
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public Vector3 get_angularVelocity() { }

	private void get_angularVelocity_Injected(out Vector3 ret) { }

	public Vector3 get_position() { }

	private void get_position_Injected(out Vector3 ret) { }

	public Quaternion get_rotation() { }

	private void get_rotation_Injected(out Quaternion ret) { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public void MovePosition(Vector3 position) { }

	private void MovePosition_Injected(ref Vector3 position) { }

	public void MoveRotation(Quaternion rot) { }

	private void MoveRotation_Injected(ref Quaternion rot) { }

	public void set_angularVelocity(Vector3 value) { }

	private void set_angularVelocity_Injected(ref Vector3 value) { }

	public void set_isKinematic(bool value) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

	public void set_useGravity(bool value) { }

	public void set_velocity(Vector3 value) { }

	private void set_velocity_Injected(ref Vector3 value) { }

}

