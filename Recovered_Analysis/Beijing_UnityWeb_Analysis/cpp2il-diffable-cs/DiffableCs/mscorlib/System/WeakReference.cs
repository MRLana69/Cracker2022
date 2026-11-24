namespace System;

public class WeakReference : ISerializable
{
	private bool isLongReference; //Field offset: 0x8
	private GCHandle gcHandle; //Field offset: 0xC

	public virtual bool IsAlive
	{
		 get { } //Length: 13
	}

	public virtual object Target
	{
		 get { } //Length: 12
		 set { } //Length: 13
	}

	public virtual bool TrackResurrection
	{
		 get { } //Length: 26
	}

	protected WeakReference() { }

	public WeakReference(object target) { }

	public WeakReference(object target, bool trackResurrection) { }

	protected WeakReference(SerializationInfo info, StreamingContext context) { }

	private void AllocateHandle(object target) { }

	protected override void Finalize() { }

	public virtual bool get_IsAlive() { }

	public virtual object get_Target() { }

	public virtual bool get_TrackResurrection() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual void set_Target(object value) { }

}

