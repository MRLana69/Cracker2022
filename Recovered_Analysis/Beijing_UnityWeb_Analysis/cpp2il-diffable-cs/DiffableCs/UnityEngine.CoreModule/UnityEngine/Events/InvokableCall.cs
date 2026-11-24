namespace UnityEngine.Events;

internal class InvokableCall : BaseInvokableCall
{
	private UnityAction Delegate; //Field offset: 0x8

	private event UnityAction Delegate
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	public InvokableCall(object target, MethodInfo theFunction) { }

	public InvokableCall(UnityAction action) { }

	private void add_Delegate(UnityAction value) { }

	public override bool Find(object targetObj, MethodInfo method) { }

	public override void Invoke(object[] args) { }

	public void Invoke() { }

	private void remove_Delegate(UnityAction value) { }

}

