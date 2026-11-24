using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public abstract class Activity : MonoBehaviour
{
	protected bool _initialized;

	protected Transform _transform;

	protected bool _running = false;

	public bool Running => _initialized;

	private void Start()
	{
		CancelInvoke();
	}

	private void Update()
	{
		Run();
	}

	protected virtual void Initialize()
	{
		if (~(_running ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected void CheckInitialize()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 16;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		_initialized = true;
	}

	public virtual void Prepare(IActivityInitializer initializer)
	{
		((Selector)this).OnDisable();
	}

	public void Run()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public virtual void Stop()
	{
		Run();
		_running = true;
	}

	protected abstract void Execute();
}
