using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public abstract class Activity : MonoBehaviour
{
	protected bool _initialized;

	protected Transform _transform;

	protected bool _running;

	public bool Running => _running;

	private void Start()
	{
		//IL_0029: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.TrackEvents.Activity>)+DC] (should have been resolved before IL gen)");
		}
	}

	private void Update()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		if (~(_running ? 1u : 0u) == 0)
		{
			nint num = (nint)this;
			object obj = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.TrackEvents.Activity>)+F4] (should have been resolved before IL gen)");
		}
	}

	protected virtual void Initialize()
	{
		Transform transform = base.transform;
		_transform = transform;
		_initialized = true;
	}

	protected void CheckInitialize()
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.TrackEvents.Activity>)+DC] (should have been resolved before IL gen)");
		}
	}

	public virtual void Prepare(IActivityInitializer initializer)
	{
		//IL_0029: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.TrackEvents.Activity>)+DC] (should have been resolved before IL gen)");
		}
	}

	public void Run()
	{
		//IL_0029: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v4 (Il2CppClass<SYBO.Subway.Level.TrackEvents.Activity>)+DC] (should have been resolved before IL gen)");
		}
		_running = true;
	}

	public virtual void Stop()
	{
		_running = false;
	}

	protected abstract void Execute();
}
