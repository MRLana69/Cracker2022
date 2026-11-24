namespace UnityEngine.Events;

internal class InvokableCall`1 : BaseInvokableCall
{
	private UnityAction<T1> Delegate; //Field offset: 0x0

	protected event UnityAction<T1> Delegate
	{
		 add { } //Length: 36
		 remove { } //Length: 91
	}

	public InvokableCall`1(object target, MethodInfo theFunction) { }

	public InvokableCall`1(UnityAction<T1> action) { }

	protected void add_Delegate(UnityAction<T1> value) { }

	public override bool Find(object targetObj, MethodInfo method) { }

	public override void Invoke(object[] args) { }

	public virtual void Invoke(T1 args0) { }

	protected void remove_Delegate(UnityAction<T1> value) { }

}

