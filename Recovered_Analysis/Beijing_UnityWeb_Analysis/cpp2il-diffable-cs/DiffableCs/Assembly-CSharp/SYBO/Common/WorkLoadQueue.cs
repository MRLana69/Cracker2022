namespace SYBO.Common;

public class WorkLoadQueue
{
	private List<IEnumerator> _workQueue; //Field offset: 0x10
	private Stack<IEnumerator> _jobStack; //Field offset: 0x14
	private bool _relaxOneFrame; //Field offset: 0x18

	public bool IsIdle
	{
		 get { } //Length: 84
	}

	public WorkLoadQueue() { }

	public void CancelWork(IEnumerator workItem) { }

	public void EnqueueWork(IEnumerator workItem) { }

	public bool get_IsIdle() { }

	protected override void SubclassInitialize() { }

	private void Update() { }

	private void Work() { }

	public void WorkUntilDone() { }

}

