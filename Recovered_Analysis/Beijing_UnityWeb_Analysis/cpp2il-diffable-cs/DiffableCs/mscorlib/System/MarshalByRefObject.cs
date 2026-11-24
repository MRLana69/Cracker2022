namespace System;

public abstract class MarshalByRefObject
{
	private object _identity; //Field offset: 0x8

	internal ServerIdentity ObjectIdentity
	{
		 get { } //Length: 10
		 set { } //Length: 11
	}

	protected MarshalByRefObject() { }

	public virtual ObjRef CreateObjRef(Type requestedType) { }

	internal ServerIdentity get_ObjectIdentity() { }

	public virtual object InitializeLifetimeService() { }

	internal void set_ObjectIdentity(ServerIdentity value) { }

}

