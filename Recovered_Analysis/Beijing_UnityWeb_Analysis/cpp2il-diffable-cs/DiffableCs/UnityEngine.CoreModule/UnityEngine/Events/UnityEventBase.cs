namespace UnityEngine.Events;

public abstract class UnityEventBase : ISerializationCallbackReceiver
{
	private InvokableCallList m_Calls; //Field offset: 0x8
	private PersistentCallGroup m_PersistentCalls; //Field offset: 0xC
	private string m_TypeName; //Field offset: 0x10
	private bool m_CallsDirty; //Field offset: 0x14

	protected UnityEventBase() { }

	internal void AddCall(BaseInvokableCall call) { }

	private void DirtyPersistentCalls() { }

	internal MethodInfo FindMethod(PersistentCall call) { }

	internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType) { }

	protected abstract MethodInfo FindMethod_Impl(string name, object targetObj) { }

	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes) { }

	internal List<BaseInvokableCall> PrepareInvoke() { }

	private void RebuildPersistentCallsIfNeeded() { }

	protected void RemoveListener(object targetObj, MethodInfo method) { }

	public override string ToString() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

