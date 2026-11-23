using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingObjectTrackEvent : TrackEvent, IMoveObjectActivityInitializer, IActivityInitializer
{
	private MovingObjectActivity _activityPrefab;

	private Transform _activityPrefabTransform;

	private float _speed = 200f;

	private bool _randomize;

	private float _speedMax = 400f;

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

	protected override void Launch()
	{
		//IL_0021: Expected I, but got Obj
		//IL_005a: Expected I, but got Obj
		Transform transform = PoolManager.Spawn(_activityPrefabTransform);
		MovingObjectActivity component = transform.GetComponent<MovingObjectActivity>();
		RouteChunk componentInParent = GetComponentInParent<RouteChunk>();
		_routeChunk = componentInParent;
		nint num = (nint)component;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v4 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingObjectActivity>)+E4] (should have been resolved before IL gen)");
		if (~(((Activity)component)._initialized ? 1u : 0u) != 0)
		{
			nint num2 = (nint)component;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S1_v11 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingObjectActivity>)+DC] (should have been resolved before IL gen)");
		}
		((Activity)component)._running = true;
	}
}
