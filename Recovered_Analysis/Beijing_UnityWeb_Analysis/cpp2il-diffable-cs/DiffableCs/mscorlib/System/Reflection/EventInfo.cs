namespace System.Reflection;

public abstract class EventInfo : MemberInfo, _EventInfo
{
	private delegate AddEventAdapter
	{

		public AddEventAdapter(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(object _this, Delegate dele, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(object _this, Delegate dele) { }

	}

	private AddEventAdapter cached_add_event; //Field offset: 0x8

	public virtual Type EventHandlerType
	{
		 get { } //Length: 12
	}

	public override MemberTypes MemberType
	{
		 get { } //Length: 42
	}

	protected EventInfo() { }

	public override bool Equals(object obj) { }

	public virtual Type get_EventHandlerType() { }

	public override MemberTypes get_MemberType() { }

	public abstract MethodInfo GetAddMethod(bool nonPublic) { }

	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }

	public override int GetHashCode() { }

	public abstract MethodInfo GetRaiseMethod(bool nonPublic) { }

	public abstract MethodInfo GetRemoveMethod(bool nonPublic) { }

	private static EventInfo internal_from_handle_type(nint event_handle, nint type_handle) { }

	public static bool op_Equality(EventInfo left, EventInfo right) { }

	public static bool op_Inequality(EventInfo left, EventInfo right) { }

}

