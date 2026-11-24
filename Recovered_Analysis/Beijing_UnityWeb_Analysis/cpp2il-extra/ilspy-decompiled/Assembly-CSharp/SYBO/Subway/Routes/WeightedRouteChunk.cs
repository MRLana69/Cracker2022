using System;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Pickups;

namespace SYBO.Subway.Routes;

[Serializable]
public class WeightedRouteChunk : WeightedPrefab<RouteChunk>
{
	public WeightedRouteChunk(RouteChunk prefab, int weight)
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0023: Expected Obj, but got I
		//IL_0023: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.WeightedRouteChunk)+10]");
		((RouteManager)val).PickupManager_OnPickupSpawnPointRegistered((PickupSpawnPoint)0);
	}
}
