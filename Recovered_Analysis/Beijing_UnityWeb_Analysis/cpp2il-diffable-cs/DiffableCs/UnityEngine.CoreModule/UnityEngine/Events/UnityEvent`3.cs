namespace UnityEngine.Events;

public abstract class UnityEvent`3 : UnityEventBase
{
	private object[] m_InvokeArray; //Field offset: 0x0

	public UnityEvent`3() { }

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

