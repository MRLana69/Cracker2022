using Cpp2ILInjected;

namespace SYBO.Common.StateSystem;

public class State
{
	public readonly int Id;

	public State(int id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 8;
		obj = id;
	}

	public virtual void Enter(State fromState)
	{
		//IL_000a: Expected I4, but got Obj
		Id = (int)fromState;
	}

	public virtual void Leave(State toState)
	{
	}

	public virtual void OnUpdate()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public virtual void OnLateUpdate()
	{
	}
}
