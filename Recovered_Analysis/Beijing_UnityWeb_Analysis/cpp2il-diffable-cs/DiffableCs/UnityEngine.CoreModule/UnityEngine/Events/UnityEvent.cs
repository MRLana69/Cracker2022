namespace UnityEngine.Events;

public class UnityEvent : UnityEventBase
{
	private object[] m_InvokeArray; //Field offset: 0x18

	public UnityEvent() { }

	public void AddListener(UnityAction call) { }

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	public void Invoke() { }

	public void RemoveListener(UnityAction call) { }

}

