using SYBO.Common.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Routes;

public abstract class AlternateRoute : Route
{
	protected Game _game;

	public abstract CharacterRendering.ICustomAnimationClipList AlternateRouteAnimationClipList { get; }

	public unsafe override void Initialize(RouteManager routeManager, Vector3 originPosition, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Expected native int or pointer, but got VT
		//IL_003d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		((Vector3*)(nint)vector)->z = originPosition.z;
		((Vector3*)(nint)vector)->x = originPosition.x;
		base.Initialize(routeManager, vector, sectionSpawnMode, chunkBuildMode, previousRouteType, randomGenerator);
		Game instance = Game.Instance;
		_game = instance;
	}
}
