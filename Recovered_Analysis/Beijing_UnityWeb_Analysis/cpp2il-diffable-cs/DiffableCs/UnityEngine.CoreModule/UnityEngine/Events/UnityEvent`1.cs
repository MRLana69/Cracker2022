namespace UnityEngine.Events;

public abstract class UnityEvent`1 : UnityEventBase
{
	private object[] m_InvokeArray; //Field offset: 0x0

	public UnityEvent`1() { }

	public void AddListener(UnityAction<T0> call) { }

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }

	public void Invoke(T0 arg0) { }

	public void RemoveListener(UnityAction<T0> call) { }

}

