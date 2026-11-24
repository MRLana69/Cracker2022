using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Managers;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway;

public class RouteTransitionState : MonoBehaviour, IGameState
{
	protected Route _sourceRoute;

	protected RouteType _targetRouteType;

	private bool IsCompleted__BackingField;

	private bool IsReadyToEnter__BackingField;

	public bool IsCompleted
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.RouteTransitionState)+A4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+34]");
			((CharacterModel)0).StartIdleAnimations(UIModelController.ModelScreen.Character);
		}
	}

	public bool IsReadyToEnter
	{
		get
		{
			return IsCompleted__BackingField;
		}
		private set
		{
			IsCompleted__BackingField = value;
		}
	}

	public void Prepare(Route sourceRoute, RouteType targetRouteType)
	{
		((Game)this).ToggleSwipeLeftRight();
	}

	public virtual void Initialize()
	{
		//IL_0026: Expected VT, but got Obj
		//IL_000e: Expected VT, but got Obj
		//IL_0017: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (T)+14]");
		if ((nint)0 != 0)
		{
			_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((SceneViewWindowManager)val2).UpdatePropertiesOnSceneView();
		}
	}

	public virtual void Enter()
	{
	}

	public virtual void UpdateState()
	{
		IsReadyToEnter__BackingField = false;
	}

	public virtual void Exit()
	{
	}
}
