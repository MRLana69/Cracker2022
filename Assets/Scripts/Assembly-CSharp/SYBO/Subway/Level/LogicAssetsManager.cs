using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Subway.Level;

public class LogicAssetsManager : SingletonMonobehavior<LogicAssetsManager>
{
	[Serializable]
	public class BasicObstaclePrefab
	{
		public BasicObstacleType Type;

		public GameObject Prefab;

		internal BasicObstaclePrefab(BasicObstacleType type)
		{
			Prefab = null;
			Type = type;
		}
	}

	[Serializable]
	public class BlockerObstaclePrefab
	{
		public BlockerObstacleType Type;

		public GameObject Prefab;

		internal BlockerObstaclePrefab(BlockerObstacleType type)
		{
			Prefab = null;
			Type = type;
		}
	}

	[Serializable]
	public class EnvironmentObstaclePrefab
	{
		public EnvironmentObstacleType Type;

		public GameObject Prefab;

		internal EnvironmentObstaclePrefab(EnvironmentObstacleType type)
		{
			Prefab = null;
			Type = type;
		}
	}

	[Serializable]
	public class ObstacleAssets
	{
		public List<BasicObstaclePrefab> basicObstacles;

		public List<BasicObstaclePrefab> basicObstaclesWithCoins;

		public List<BlockerObstaclePrefab> blockerObstacles;

		public List<BlockerObstaclePrefab> blockerObstaclesWithCoins;

		public List<EnvironmentObstaclePrefab> environmentObstacles;

		public List<EnvironmentObstaclePrefab> environmentObstaclesExtended;

		internal ObstacleAssets()
		{
			List<BasicObstaclePrefab> list = default;
			list._002Ector();
			BasicObstaclePrefab basicObstaclePrefab = default;
			basicObstaclePrefab.Prefab = null;
			basicObstaclePrefab.Type = BasicObstacleType.LightSignal;
			list.Add(basicObstaclePrefab);
			BasicObstaclePrefab basicObstaclePrefab2 = default;
			basicObstaclePrefab2.Prefab = null;
			basicObstaclePrefab2.Type = BasicObstacleType.Bush;
			list.Add(basicObstaclePrefab2);
			BasicObstaclePrefab basicObstaclePrefab3 = default;
			basicObstaclePrefab3.Prefab = null;
			basicObstaclePrefab3.Type = BasicObstacleType.BushMix;
			list.Add(basicObstaclePrefab3);
			BasicObstaclePrefab basicObstaclePrefab4 = default;
			basicObstaclePrefab4.Prefab = null;
			basicObstaclePrefab4.Type = BasicObstacleType.BushAndPowerbox;
			list.Add(basicObstaclePrefab4);
			BasicObstaclePrefab basicObstaclePrefab5 = default;
			basicObstaclePrefab5.Prefab = null;
			basicObstaclePrefab5.Type = BasicObstacleType.Dumpster;
			list.Add(basicObstaclePrefab5);
			basicObstacles = list;
			List<BasicObstaclePrefab> list2 = default;
			list2._002Ector();
			BasicObstaclePrefab basicObstaclePrefab6 = default;
			basicObstaclePrefab6.Prefab = null;
			basicObstaclePrefab6.Type = BasicObstacleType.LightSignal;
			list2.Add(basicObstaclePrefab6);
			BasicObstaclePrefab basicObstaclePrefab7 = default;
			basicObstaclePrefab7.Prefab = null;
			basicObstaclePrefab7.Type = BasicObstacleType.Bush;
			list2.Add(basicObstaclePrefab7);
			BasicObstaclePrefab basicObstaclePrefab8 = default;
			basicObstaclePrefab8.Prefab = null;
			basicObstaclePrefab8.Type = BasicObstacleType.BushMix;
			list2.Add(basicObstaclePrefab8);
			BasicObstaclePrefab basicObstaclePrefab9 = default;
			basicObstaclePrefab9.Prefab = null;
			basicObstaclePrefab9.Type = BasicObstacleType.BushAndPowerbox;
			list2.Add(basicObstaclePrefab9);
			BasicObstaclePrefab basicObstaclePrefab10 = default;
			basicObstaclePrefab10.Prefab = null;
			basicObstaclePrefab10.Type = BasicObstacleType.Dumpster;
			list2.Add(basicObstaclePrefab10);
			basicObstaclesWithCoins = list2;
			List<BlockerObstaclePrefab> list3 = default;
			list3._002Ector();
			BlockerObstaclePrefab blockerObstaclePrefab = default;
			blockerObstaclePrefab.Prefab = null;
			blockerObstaclePrefab.Type = BlockerObstacleType.BlockerStandard;
			list3.Add(blockerObstaclePrefab);
			BlockerObstaclePrefab blockerObstaclePrefab2 = default;
			blockerObstaclePrefab2.Prefab = null;
			blockerObstaclePrefab2.Type = BlockerObstacleType.BlockerRoll;
			list3.Add(blockerObstaclePrefab2);
			BlockerObstaclePrefab blockerObstaclePrefab3 = default;
			blockerObstaclePrefab3.Prefab = null;
			blockerObstaclePrefab3.Type = BlockerObstacleType.BlockerJump;
			list3.Add(blockerObstaclePrefab3);
			blockerObstacles = list3;
			List<BlockerObstaclePrefab> list4 = default;
			list4._002Ector();
			BlockerObstaclePrefab blockerObstaclePrefab4 = default;
			blockerObstaclePrefab4.Prefab = null;
			blockerObstaclePrefab4.Type = BlockerObstacleType.BlockerStandard;
			list4.Add(blockerObstaclePrefab4);
			BlockerObstaclePrefab blockerObstaclePrefab5 = default;
			blockerObstaclePrefab5.Prefab = null;
			blockerObstaclePrefab5.Type = BlockerObstacleType.BlockerRoll;
			list4.Add(blockerObstaclePrefab5);
			BlockerObstaclePrefab blockerObstaclePrefab6 = default;
			blockerObstaclePrefab6.Prefab = null;
			blockerObstaclePrefab6.Type = BlockerObstacleType.BlockerJump;
			list4.Add(blockerObstaclePrefab6);
			blockerObstaclesWithCoins = list4;
			List<EnvironmentObstaclePrefab> list5 = default;
			list5._002Ector();
			EnvironmentObstaclePrefab environmentObstaclePrefab = default;
			environmentObstaclePrefab.Prefab = null;
			environmentObstaclePrefab.Type = EnvironmentObstacleType.Pillar;
			list5.Add(environmentObstaclePrefab);
			EnvironmentObstaclePrefab environmentObstaclePrefab2 = default;
			environmentObstaclePrefab2.Prefab = null;
			environmentObstaclePrefab2.Type = EnvironmentObstacleType.Station;
			list5.Add(environmentObstaclePrefab2);
			EnvironmentObstaclePrefab environmentObstaclePrefab3 = default;
			environmentObstaclePrefab3.Prefab = null;
			environmentObstaclePrefab3.Type = EnvironmentObstacleType.Gates;
			list5.Add(environmentObstaclePrefab3);
			environmentObstacles = list5;
			List<EnvironmentObstaclePrefab> list6 = default;
			list6._002Ector();
			EnvironmentObstaclePrefab environmentObstaclePrefab4 = default;
			environmentObstaclePrefab4.Prefab = null;
			environmentObstaclePrefab4.Type = EnvironmentObstacleType.Station;
			list6.Add(environmentObstaclePrefab4);
			environmentObstaclesExtended = list6;
		}
	}

	public ObstacleAssets obstacles;

	public EnvironmentAssets environment;

	protected override void Initialize()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
	}

	public bool HasEnvironmentSegmentLogic(EnvironmentType envType)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected I4, but got Unknown
		object obj = envType - 2;
		if ((nint)obj <= 14)
		{
			object obj2 = 16389 >> (int)obj;
			return (byte)(obj2 & 1) != 0;
		}
		return false;
	}

	public Transform SpawnEnvironmentSegmentLogic(EnvironmentType envType, EnvironmentSequence sequence)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_021a: Expected Obj, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		object obj3 = envType - 2;
		object obj6;
		object obj7;
		object obj8;
		if (envType != EnvironmentType.Tube)
		{
			if ((nint)obj3 == 1)
			{
				goto IL_00b9;
			}
			if ((nint)obj3 != 2)
			{
				if (envType != EnvironmentType.Station)
				{
					goto IL_00b9;
				}
				object obj4 = environment + 16;
				object obj5 = environment + 8;
				obj6 = environment + 12;
				obj7 = obj5;
				obj8 = obj4;
			}
			else
			{
				object obj9 = environment + 40;
				object obj10 = environment + 32;
				obj6 = environment + 36;
				obj7 = obj10;
				obj8 = obj9;
			}
		}
		else
		{
			object obj11 = environment + 28;
			object obj12 = environment + 20;
			obj6 = environment + 24;
			obj7 = obj12;
			obj8 = obj11;
		}
		object obj13 = sequence - 1;
		bool flag = sequence == EnvironmentSequence.Start;
		UnityEngine.Object obj14 = (UnityEngine.Object)obj7;
		if (!flag)
		{
			if ((nint)obj13 == 1)
			{
				obj14 = (UnityEngine.Object)obj6;
			}
			else
			{
				obj14 = (UnityEngine.Object)(((nint)obj13 == 2) ? obj8 : null);
			}
		}
		bool flag2 = obj14 != null;
		Transform result = null;
		if (flag2)
		{
			result = PoolManager.Spawn((Transform)obj14);
		}
		goto IL_0207;
		IL_0207:
		return result;
		IL_00b9:
		_ = -1;
		obj = (Enum)(object)typeof(EnvironmentType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		string text2 = "No logic defined for environment type " + text;
		result = null;
		goto IL_0207;
	}

	public void DespawnEnvironmentSegmentLogic(Transform segmentTransform)
	{
		PoolManager.Despawn(segmentTransform);
	}

	public LogicAssetsManager()
	{
		ObstacleAssets obstacleAssets = default;
		obstacleAssets._002Ector();
		obstacles = obstacleAssets;
		EnvironmentAssets environmentAssets = default;
		environment = environmentAssets;
		base._002Ector();
	}
}
