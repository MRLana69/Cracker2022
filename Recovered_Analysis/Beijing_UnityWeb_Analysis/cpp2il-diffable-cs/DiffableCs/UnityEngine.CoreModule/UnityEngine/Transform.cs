namespace UnityEngine;

public class Transform : Component, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private Transform outer; //Field offset: 0x8
		private int currentIndex; //Field offset: 0xC

		public object Current
		{
			 get { } //Length: 68
		}

		internal Enumerator(Transform outer) { }

		public object get_Current() { }

		public bool MoveNext() { }

		public void Reset() { }

	}


	public int childCount
	{
		 get { } //Length: 49
	}

	public Vector3 eulerAngles
	{
		 get { } //Length: 11
		 set { } //Length: 89
	}

	public Vector3 forward
	{
		 get { } //Length: 247
	}

	public bool hasChanged
	{
		 get { } //Length: 49
		 set { } //Length: 60
	}

	public Vector3 localEulerAngles
	{
		 get { } //Length: 176
		 set { } //Length: 89
	}

	public Vector3 localPosition
	{
		 get { } //Length: 11
		 set { } //Length: 60
	}

	public Quaternion localRotation
	{
		 get { } //Length: 11
		 set { } //Length: 60
	}

	public Vector3 localScale
	{
		 get { } //Length: 11
		 set { } //Length: 60
	}

	public Matrix4x4 localToWorldMatrix
	{
		 get { } //Length: 162
	}

	public Vector3 lossyScale
	{
		 get { } //Length: 53
	}

	public Transform parent
	{
		 get { } //Length: 59
		 set { } //Length: 11
	}

	internal Transform parentInternal
	{
		 get { } //Length: 9
		 set { } //Length: 134
	}

	public Vector3 position
	{
		 get { } //Length: 10
		 set { } //Length: 60
	}

	public Vector3 right
	{
		 get { } //Length: 176
	}

	public Quaternion rotation
	{
		 get { } //Length: 247
		 set { } //Length: 60
	}

	public Vector3 up
	{
		 get { } //Length: 247
	}

	public Matrix4x4 worldToLocalMatrix
	{
		 get { } //Length: 13
	}

	protected Transform() { }

	public void DetachChildren() { }

	public Transform Find(string n) { }

	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	public int get_childCount() { }

	public Vector3 get_eulerAngles() { }

	public Vector3 get_forward() { }

	public bool get_hasChanged() { }

	public Vector3 get_localEulerAngles() { }

	public Vector3 get_localPosition() { }

	private void get_localPosition_Injected(out Vector3 ret) { }

	public Quaternion get_localRotation() { }

	private void get_localRotation_Injected(out Quaternion ret) { }

	public Vector3 get_localScale() { }

	private void get_localScale_Injected(out Vector3 ret) { }

	public Matrix4x4 get_localToWorldMatrix() { }

	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	public Vector3 get_lossyScale() { }

	private void get_lossyScale_Injected(out Vector3 ret) { }

	public Transform get_parent() { }

	internal Transform get_parentInternal() { }

	public Vector3 get_position() { }

	private void get_position_Injected(out Vector3 ret) { }

	public Vector3 get_right() { }

	public Quaternion get_rotation() { }

	private void get_rotation_Injected(out Quaternion ret) { }

	public Vector3 get_up() { }

	public Matrix4x4 get_worldToLocalMatrix() { }

	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	public Transform GetChild(int index) { }

	public IEnumerator GetEnumerator() { }

	private Transform GetParent() { }

	public int GetSiblingIndex() { }

	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	public Vector3 InverseTransformDirection(Vector3 direction) { }

	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	public Vector3 InverseTransformPoint(Vector3 position) { }

	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public bool IsChildOf(Transform parent) { }

	public void LookAt(Vector3 worldPosition) { }

	public void LookAt(Transform target) { }

	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	public void Rotate(Vector3 eulers, Space relativeTo) { }

	public void Rotate(Vector3 eulers) { }

	public void Rotate(Vector3 axis, float angle) { }

	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	public void RotateAround(Vector3 axis, float angle) { }

	private void RotateAround_Injected(ref Vector3 axis, float angle) { }

	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	public void set_eulerAngles(Vector3 value) { }

	public void set_hasChanged(bool value) { }

	public void set_localEulerAngles(Vector3 value) { }

	public void set_localPosition(Vector3 value) { }

	private void set_localPosition_Injected(ref Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	private void set_localRotation_Injected(ref Quaternion value) { }

	public void set_localScale(Vector3 value) { }

	private void set_localScale_Injected(ref Vector3 value) { }

	public void set_parent(Transform value) { }

	internal void set_parentInternal(Transform value) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

	public void SetAsFirstSibling() { }

	public void SetAsLastSibling() { }

	public void SetParent(Transform p) { }

	public void SetParent(Transform parent, bool worldPositionStays) { }

	public void SetSiblingIndex(int index) { }

	public Vector3 TransformDirection(Vector3 direction) { }

	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	public Vector3 TransformPoint(Vector3 position) { }

	public Vector3 TransformPoint(float x, float y, float z) { }

	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public void Translate(Vector3 translation, Space relativeTo) { }

}

