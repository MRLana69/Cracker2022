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
			return IsCompleted__BackingField;
		}
		private set
		{
			IsCompleted__BackingField = value;
		}
	}

	public bool IsReadyToEnter
	{
		get
		{
			return IsReadyToEnter__BackingField;
		}
		private set
		{
			IsReadyToEnter__BackingField = value;
		}
	}

	public void Prepare(Route sourceRoute, RouteType targetRouteType)
	{
		_sourceRoute = sourceRoute;
		_targetRouteType = targetRouteType;
		IsCompleted__BackingField = false;
	}

	public virtual void Initialize()
	{
	}

	public virtual void Enter()
	{
		IsReadyToEnter__BackingField = false;
	}

	public virtual void UpdateState()
	{
	}

	public virtual void Exit()
	{
	}
}
