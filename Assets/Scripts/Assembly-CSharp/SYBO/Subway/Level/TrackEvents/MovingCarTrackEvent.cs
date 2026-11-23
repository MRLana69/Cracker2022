using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingCarTrackEvent : CharacterTriggeredTrackEvent, IMoveObjectActivityInitializer, IActivityInitializer
{
	private MovingCarActivity _activityPrefab;

	private Transform _activityPrefabTransform;

	private float _speed = 200f;

	private bool _randomize;

	private float _speedMax = 400f;

	private List<Collider> _collidersInSpawnArea;

	private RouteChunk _routeChunk;

	Transform IMoveObjectActivityInitializer.Transform => _transform;

	public RouteChunk RouteChunk => _routeChunk;

	public float Speed
	{
		get
		{
			float num = _speed;
			if (~(_randomize ? 1u : 0u) == 0)
			{
				num = Random.Range(num, _speedMax);
			}
			return num;
		}
	}

	protected override void Initialize()
	{
		base.Initialize();
		Transform activityPrefabTransform = _activityPrefab.transform;
		_activityPrefabTransform = activityPrefabTransform;
	}

	private void OnTriggerEnter(Collider otherCollider)
	{
		_collidersInSpawnArea.Add(otherCollider);
	}

	private void OnTriggerExit(Collider otherCollider)
	{
		bool flag = _collidersInSpawnArea.Remove(otherCollider);
	}

	protected override void Launch()
	{
		//IL_0047: Expected I, but got Obj
		//IL_0080: Expected I, but got Obj
		List<Collider> collidersInSpawnArea = _collidersInSpawnArea;
		if (collidersInSpawnArea._size <= 0)
		{
			Transform transform = PoolManager.Spawn(_activityPrefabTransform);
			MovingCarActivity component = transform.GetComponent<MovingCarActivity>();
			RouteChunk componentInParent = GetComponentInParent<RouteChunk>();
			_routeChunk = componentInParent;
			nint num = (nint)component;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S2_v5 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingCarActivity>)+E4] (should have been resolved before IL gen)");
			if (~(((Activity)component)._initialized ? 1u : 0u) != 0)
			{
				nint num2 = (nint)component;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S1_v13 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingCarActivity>)+DC] (should have been resolved before IL gen)");
			}
			((Activity)component)._running = true;
		}
	}

	protected override void TrackObject_OnActivate()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		((List<T>)(object)_collidersInSpawnArea).Clear();
		Character instance = Character.Instance;
		if (instance != null)
		{
			float endPosition = _trigger.EndPosition;
			if (endPosition < instance.z && !_launched)
			{
				nint num = (nint)this;
				object obj = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S1_v10 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingCarTrackEvent>)+EC] (should have been resolved before IL gen)");
			}
		}
	}

	public MovingCarTrackEvent()
	{
		List<Collider> list = default;
		list._002Ector();
		_collidersInSpawnArea = list;
		base._002Ector();
	}
}
