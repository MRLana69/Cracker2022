using System;
using Cpp2ILInjected;
using SYBO.Common.StateSystem;
using SYBO.Common.Utility;
using SYBO.Subway.StateSystem.States;

namespace SYBO.Subway.StateSystem;

public class MonobehaviourScheduler : SubscribableMonobehaviour, IScheduler
{
	public void RegisterUpdateHandler(Action handler)
	{
		InGameState inGameState = ((StateMachine)(object)this).TryGetCurrentState<InGameState>();
		if (inGameState != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	public void RegisterLateUpdateHandler(Action handler)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		Delegate obj2 = ((Delegate)OnUpdate).CombineImpl((Delegate)handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj3 = default;
		obj = obj3;
	}

	public MonobehaviourScheduler()
	{
		InGameState inGameState = ((StateMachine)(object)this).TryGetCurrentState<InGameState>();
		if (inGameState != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
