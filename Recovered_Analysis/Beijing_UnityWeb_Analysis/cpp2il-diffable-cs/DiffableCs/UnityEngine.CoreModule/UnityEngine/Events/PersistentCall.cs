namespace UnityEngine.Events;

internal class PersistentCall
{
	private Object m_Target; //Field offset: 0x8
	private string m_MethodName; //Field offset: 0xC
	private PersistentListenerMode m_Mode; //Field offset: 0x10
	private ArgumentCache m_Arguments; //Field offset: 0x14
	private UnityEventCallState m_CallState; //Field offset: 0x18

	public ArgumentCache arguments
	{
		 get { } //Length: 6
	}

	public string methodName
	{
		 get { } //Length: 6
	}

	public PersistentListenerMode mode
	{
		 get { } //Length: 6
	}

	public Object target
	{
		 get { } //Length: 116
	}

	public PersistentCall() { }

	public ArgumentCache get_arguments() { }

	public string get_methodName() { }

	public PersistentListenerMode get_mode() { }

	public Object get_target() { }

	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	public bool IsValid() { }

}

