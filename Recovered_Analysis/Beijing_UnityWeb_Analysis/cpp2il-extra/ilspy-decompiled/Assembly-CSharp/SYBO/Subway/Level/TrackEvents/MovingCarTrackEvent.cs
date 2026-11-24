using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingCarTrackEvent : CharacterTriggeredTrackEvent, IMoveObjectActivityInitializer, IActivityInitializer
{
	private MovingCarActivity _activityPrefab;

	private Transform _activityPrefabTransform;

	private float _speed;

	private bool _randomize;

	private AnimationCurve spawnProbability;

	private float _speedMax;

	private List<Collider> _collidersInSpawnArea;

	private RouteChunk RouteChunk__BackingField;

	public RouteChunk RouteChunk
	{
		get
		{
			//IL_0007: Expected Obj, but got F4
			return (RouteChunk)((TrackEvent)this)._probability;
		}
		private set
		{
			//IL_01a2: Expected I, but got Obj
			//IL_01b8: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)value).GetComponentsInParent<T>();
			MovingCarActivity componentInParent = value.GetComponentInParent<MovingCarActivity>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)(object)componentsInParent != null))
			{
				return;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)componentInParent).FindKernel((string)(object)this) == 0)
			{
				return;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)componentInParent).FindKernel((string)null) != 0)
			{
				spawnProbability = null;
			}
		}
	}

	public float Speed
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)_activityPrefab;
		}
	}

	Transform IMoveObjectActivityInitializer.Transform => (Transform)(object)RouteChunk__BackingField;

	protected override void Initialize()
	{
		CancelInvoke();
	}

	private void OnTriggerEnter(Collider otherCollider)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 68;
		obj = otherCollider;
	}

	private void OnTriggerExit(Collider otherCollider)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this - -64;
		((List<Collider>)obj).Add(otherCollider);
	}

	protected override void Launch()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		base.OnDestroy();
		object obj = this + 44;
		GameObject gameObject = _activityPrefab.gameObject;
		obj = gameObject;
	}

	protected override void TrackObject_OnActivate()
	{
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_0151: Expected Obj, but got VT
		//IL_0109: Expected I, but got Obj
		object obj = this + 68;
		RouteChunk componentInParent = GetComponentInParent<RouteChunk>();
		obj = componentInParent;
		object obj2 = this - -64;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11+C]");
		if ((nint)0 >= (nint)1)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (RouteChunk__BackingField != null)
		{
			return;
		}
		RouteChunk routeChunk = ((MovingObjectTrackEvent)(object)this).RouteChunk;
		if ((object)routeChunk == null)
		{
			return;
		}
		nint num3 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v24 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v30 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool(_activityPrefabTransform);
		_0021_00210 componentInChildren = (_0021_00210)((Component)(object)prefabPool).GetComponentInChildren<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		((Activity)componentInChildren).Stop();
	}

	private bool ShouldSpawn()
	{
		//IL_0007: Expected I4, but got Obj
		return (byte)(int)_transform != 0;
	}

	public MovingCarTrackEvent()
	{
		throw new IndexOutOfRangeException();
	}
}
