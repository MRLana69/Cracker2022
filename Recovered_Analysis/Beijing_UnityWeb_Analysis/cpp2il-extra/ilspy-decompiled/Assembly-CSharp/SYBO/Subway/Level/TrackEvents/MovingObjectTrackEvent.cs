using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingObjectTrackEvent : TrackEvent, IMoveObjectActivityInitializer, IActivityInitializer
{
	private MovingObjectActivity _activityPrefab;

	private Transform _activityPrefabTransform;

	private float _speed;

	private bool _randomize;

	private float _speedMax;

	private RouteChunk _routeChunk;

	public RouteChunk RouteChunk
	{
		get
		{
			//IL_00ec: Expected I, but got Obj
			//IL_0102: Expected Obj, but got I
			//IL_0141: Expected Obj, but got I
			//IL_015e: Expected Obj, but got I
			//IL_0062: Expected Obj, but got I
			//IL_007b: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00d5: Expected Obj, but got I4
			float time = Time.time;
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v3 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v13 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			bool isInstantiated2 = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v3 (System.Boolean)+58]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v8 (System.Boolean)+44]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v4+8]");
			object obj3 = num3 - 0;
			bool isInstantiated3 = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S2_v7 (System.Boolean)+58]");
			object obj4 = 0;
			bool isInstantiated4 = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S3_v2 (System.Boolean)+58]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v8+C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v3+8]");
			object obj6 = num4 - 0;
			float defaultValue = (float)obj3 / (float)obj6;
			float num5 = PlayerPrefs.GetFloat((string)(object)_routeChunk, defaultValue);
			bool flag = !(num5 < time);
			return (RouteChunk)flag;
		}
	}

	public float Speed
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)base.Launching;
		}
	}

	Transform IMoveObjectActivityInitializer.Transform => (Transform)(object)_routeChunk;

	protected override void Initialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	protected override void Launch()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		Start();
		object obj = this + 40;
		GameObject gameObject = _activityPrefab.gameObject;
		obj = gameObject;
	}

	public MovingObjectTrackEvent()
	{
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v15 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool(_activityPrefabTransform);
		_0021_00210 componentInChildren = (_0021_00210)((Component)(object)prefabPool).GetComponentInChildren<T>();
		object obj2 = this + 56;
		RouteChunk componentInParent = GetComponentInParent<RouteChunk>();
		obj2 = componentInParent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		((Activity)componentInChildren).Stop();
	}
}
