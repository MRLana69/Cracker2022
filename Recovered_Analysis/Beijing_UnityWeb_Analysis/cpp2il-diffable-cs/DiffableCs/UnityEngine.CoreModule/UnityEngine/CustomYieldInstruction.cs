namespace UnityEngine;

public abstract class CustomYieldInstruction : IEnumerator
{

	public object Current
	{
		 get { } //Length: 15
	}

	public abstract bool keepWaiting
	{
		 get { } //Length: 0
	}

	protected CustomYieldInstruction() { }

	public object get_Current() { }

	public abstract bool get_keepWaiting() { }

	public bool MoveNext() { }

	public void Reset() { }

}

