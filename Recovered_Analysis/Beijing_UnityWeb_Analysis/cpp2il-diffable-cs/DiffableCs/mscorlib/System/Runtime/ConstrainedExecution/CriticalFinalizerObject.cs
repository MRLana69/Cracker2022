namespace System.Runtime.ConstrainedExecution;

public abstract class CriticalFinalizerObject
{

	protected CriticalFinalizerObject() { }

	protected override void Finalize() { }

}

