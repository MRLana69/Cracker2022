using System;
using System.Collections.Generic;
using System.IO;
using AppRefresh;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Timer;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Level.Environments;

public class DistantEnvironmentController : SingletonMonoBehaviour<DistantEnvironmentController>
{
	public enum EnvironmentSide
	{
		Left,
		Right,
		Both
	}

	[Serializable]
	public class DistantObjectGlobalConfig
	{
		private float _globalMinDistanceFirstSpawn;

		private float _globalMinDistanceBetween;

		public float GlobalMinDistanceFirstSpawn
		{
			get
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0018: Expected F4, but got I
				object obj = this + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				return 0f;
			}
		}

		public float GlobalMinDistanceBetween => _globalMinDistanceFirstSpawn;

		public DistantObjectGlobalConfig()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			//IL_002a: Expected Obj, but got I4
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected Obj, but got Unknown
			//IL_006b: Expected Obj, but got I4
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected Obj, but got Unknown
			//IL_00ac: Expected Obj, but got I4
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected Obj, but got Unknown
			//IL_00ed: Expected Obj, but got I4
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected Obj, but got Unknown
			//IL_012e: Expected Obj, but got I4
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected Obj, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected Obj, but got Unknown
			//IL_019a: Expected Obj, but got I4
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_01db: Expected Obj, but got I4
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected Obj, but got Unknown
			//IL_021c: Expected Obj, but got I4
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Expected Obj, but got Unknown
			//IL_025d: Expected Obj, but got I4
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected Obj, but got Unknown
			//IL_029e: Expected Obj, but got I4
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Expected Obj, but got Unknown
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Expected Obj, but got Unknown
			//IL_030a: Expected Obj, but got I4
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected Obj, but got Unknown
			//IL_034b: Expected Obj, but got I4
			//IL_037e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Expected Obj, but got Unknown
			//IL_038c: Expected Obj, but got I4
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Expected Obj, but got Unknown
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Expected Obj, but got Unknown
			//IL_03f8: Expected Obj, but got I4
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Expected Obj, but got Unknown
			//IL_0439: Expected Obj, but got I4
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0471: Expected Obj, but got Unknown
			//IL_047a: Expected Obj, but got I4
			//IL_048d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Expected Obj, but got Unknown
			//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dd: Expected Obj, but got Unknown
			//IL_04e6: Expected Obj, but got I4
			//IL_0519: Unknown result type (might be due to invalid IL or missing references)
			//IL_051e: Expected Obj, but got Unknown
			//IL_0527: Expected Obj, but got I4
			//IL_055a: Unknown result type (might be due to invalid IL or missing references)
			//IL_055f: Expected Obj, but got Unknown
			//IL_0568: Expected Obj, but got I4
			//IL_057b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0580: Expected Obj, but got Unknown
			//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cb: Expected Obj, but got Unknown
			//IL_05d4: Expected Obj, but got I4
			//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ec: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<LogicAssetsManager.BasicObstaclePrefab> list = default;
			list._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab = default;
			basicObstaclePrefab.Type = BasicObstacleType.LightSignal;
			object obj = basicObstaclePrefab + 12;
			obj = 0;
			list.Add(basicObstaclePrefab);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab2 = default;
			basicObstaclePrefab2.Type = BasicObstacleType.Bush;
			object obj2 = basicObstaclePrefab2 + 12;
			obj2 = 0;
			list.Add(basicObstaclePrefab2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab3 = default;
			basicObstaclePrefab3.Type = BasicObstacleType.BushMix;
			object obj3 = basicObstaclePrefab3 + 12;
			obj3 = 0;
			list.Add(basicObstaclePrefab3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab4 = default;
			basicObstaclePrefab4.Type = BasicObstacleType.BushAndPowerbox;
			object obj4 = basicObstaclePrefab4 + 12;
			obj4 = 0;
			list.Add(basicObstaclePrefab4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab5 = default;
			basicObstaclePrefab5.Type = BasicObstacleType.Dumpster;
			object obj5 = basicObstaclePrefab5 + 12;
			obj5 = 0;
			list.Add(basicObstaclePrefab5);
			object obj6 = this + 8;
			obj6 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<LogicAssetsManager.BasicObstaclePrefab> list2 = default;
			list2._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab6 = default;
			basicObstaclePrefab6.Type = BasicObstacleType.LightSignal;
			object obj7 = basicObstaclePrefab6 + 12;
			obj7 = 0;
			list2.Add(basicObstaclePrefab6);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab7 = default;
			basicObstaclePrefab7.Type = BasicObstacleType.Bush;
			object obj8 = basicObstaclePrefab7 + 12;
			obj8 = 0;
			list2.Add(basicObstaclePrefab7);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab8 = default;
			basicObstaclePrefab8.Type = BasicObstacleType.BushMix;
			object obj9 = basicObstaclePrefab8 + 12;
			obj9 = 0;
			list2.Add(basicObstaclePrefab8);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab9 = default;
			basicObstaclePrefab9.Type = BasicObstacleType.BushAndPowerbox;
			object obj10 = basicObstaclePrefab9 + 12;
			obj10 = 0;
			list2.Add(basicObstaclePrefab9);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BasicObstaclePrefab basicObstaclePrefab10 = default;
			basicObstaclePrefab10.Type = BasicObstacleType.Dumpster;
			object obj11 = basicObstaclePrefab10 + 12;
			obj11 = 0;
			list2.Add(basicObstaclePrefab10);
			object obj12 = this + 12;
			obj12 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<LogicAssetsManager.BlockerObstaclePrefab> list3 = default;
			list3._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BlockerObstaclePrefab blockerObstaclePrefab = default;
			blockerObstaclePrefab.Type = BlockerObstacleType.BlockerStandard;
			object obj13 = blockerObstaclePrefab + 12;
			obj13 = 0;
			list3.Add(blockerObstaclePrefab);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BlockerObstaclePrefab blockerObstaclePrefab2 = default;
			blockerObstaclePrefab2.Type = BlockerObstacleType.BlockerRoll;
			object obj14 = blockerObstaclePrefab2 + 12;
			obj14 = 0;
			list3.Add(blockerObstaclePrefab2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BlockerObstaclePrefab blockerObstaclePrefab3 = default;
			blockerObstaclePrefab3.Type = BlockerObstacleType.BlockerJump;
			object obj15 = blockerObstaclePrefab3 + 12;
			obj15 = 0;
			list3.Add(blockerObstaclePrefab3);
			object obj16 = this + 16;
			obj16 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<LogicAssetsManager.BlockerObstaclePrefab> list4 = default;
			list4._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BlockerObstaclePrefab blockerObstaclePrefab4 = default;
			blockerObstaclePrefab4.Type = BlockerObstacleType.BlockerStandard;
			object obj17 = blockerObstaclePrefab4 + 12;
			obj17 = 0;
			list4.Add(blockerObstaclePrefab4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BlockerObstaclePrefab blockerObstaclePrefab5 = default;
			blockerObstaclePrefab5.Type = BlockerObstacleType.BlockerRoll;
			object obj18 = blockerObstaclePrefab5 + 12;
			obj18 = 0;
			list4.Add(blockerObstaclePrefab5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.BlockerObstaclePrefab blockerObstaclePrefab6 = default;
			blockerObstaclePrefab6.Type = BlockerObstacleType.BlockerJump;
			object obj19 = blockerObstaclePrefab6 + 12;
			obj19 = 0;
			list4.Add(blockerObstaclePrefab6);
			object obj20 = this + 20;
			obj20 = list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<LogicAssetsManager.EnvironmentObstaclePrefab> list5 = default;
			list5._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.EnvironmentObstaclePrefab environmentObstaclePrefab = default;
			environmentObstaclePrefab.Type = EnvironmentObstacleType.Pillar;
			object obj21 = environmentObstaclePrefab + 12;
			obj21 = 0;
			list5.Add(environmentObstaclePrefab);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.EnvironmentObstaclePrefab environmentObstaclePrefab2 = default;
			environmentObstaclePrefab2.Type = EnvironmentObstacleType.Station;
			object obj22 = environmentObstaclePrefab2 + 12;
			obj22 = 0;
			list5.Add(environmentObstaclePrefab2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.EnvironmentObstaclePrefab environmentObstaclePrefab3 = default;
			environmentObstaclePrefab3.Type = EnvironmentObstacleType.Gates;
			object obj23 = environmentObstaclePrefab3 + 12;
			obj23 = 0;
			list5.Add(environmentObstaclePrefab3);
			object obj24 = this + 24;
			obj24 = list5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<LogicAssetsManager.EnvironmentObstaclePrefab> list6 = default;
			list6._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LogicAssetsManager.EnvironmentObstaclePrefab environmentObstaclePrefab4 = default;
			environmentObstaclePrefab4.Type = EnvironmentObstacleType.Station;
			object obj25 = environmentObstaclePrefab4 + 12;
			obj25 = 0;
			list6.Add(environmentObstaclePrefab4);
			object obj26 = this + 28;
			obj26 = list6;
		}
	}

	[Serializable]
	public class DistantObjectConfig
	{
		private string _name;

		private Transform[] _prefabs;

		private EnvironmentSide _environmentSide;

		private EnvironmentKind[] _environmentKind;

		private float _projectionSourceOffsetXMin;

		private float _projectionSourceOffsetXMax;

		private float _minDistanceFirstSpawn;

		private float _minDistanceBetween;

		private float _spawnProbability;

		public string Name => (string)(object)_environmentKind;

		public Transform[] Prefabs => (Transform[])(object)_name;

		public EnvironmentSide EnvironmentSide
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (EnvironmentSide)_prefabs;
			}
		}

		public EnvironmentKind[] EnvironmentKind
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (EnvironmentKind[])_environmentSide;
			}
		}

		public float ProjectionSourceOffsetXMin
		{
			get
			{
				//IL_0007: Expected F4, but got Obj
				return (float)_prefabs;
			}
		}

		public float ProjectionSourceOffsetXMax => _projectionSourceOffsetXMin;

		public float MinDistanceFirstSpawn => _projectionSourceOffsetXMax;

		public float MinDistanceBetween => _minDistanceFirstSpawn;

		public float SpawnProbability => _minDistanceBetween;

		public Transform GetRandomPrefab()
		{
			return (Transform)(object)_environmentKind;
		}
	}

	private class DistantObjectSpawner
	{
		private List<Transform> _spawnedTransforms;

		private float _lastSpawnGamePositionZ;

		private DistantObjectConfig Config__BackingField;

		public unsafe DistantObjectConfig Config
		{
			get
			{
				//IL_0057: Expected native int or pointer, but got F4
				//IL_005d: Expected Obj, but got F4
				float num = _lastSpawnGamePositionZ + 16f;
				float lastSpawnGamePositionZ = _lastSpawnGamePositionZ;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S2_v2 (System.Single)+C]");
				int num2 = UnityEngine.Random.RandomRangeInt(0, 0);
				int num3 = num2 << 2;
				float num4 = num + (float)num3;
				return (DistantObjectConfig)((float*)(nint)num4)->m_value;
			}
			private set
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Expected Obj, but got Unknown
				//IL_001e: Expected Obj, but got I4
				_spawnedTransforms = (List<Transform>)(object)value;
				object obj = this + 12;
				obj = 0;
			}
		}

		public DistantObjectSpawner(DistantObjectConfig config)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = config;
		}

		public void Reset()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = "";
			Config__BackingField = (DistantObjectConfig)2;
			object obj2 = this + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj3 = default;
			obj2 = obj3;
		}

		public bool CanSpawnAt(float gamePositionZ, EnvironmentKind environmentKind)
		{
			//IL_0028: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 20;
			obj = environmentKind;
			return flag;
		}

		private bool CanSpawnAtEnvironmentKind(EnvironmentKind environmentKind)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [environmentKind @ L1 (SYBO.Subway.Level.EnvironmentKind)+14]");
			return (UnityEngine.Object)0 != null;
		}

		public void Spawn(float spawnGamePositionZ, Vector3 cameraGamePosition, Transform parent)
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_027a: Expected I, but got Obj
			//IL_0290: Expected Obj, but got I
			//IL_031b: Expected I, but got Obj
			//IL_0331: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_02cb: Expected I, but got Obj
			//IL_02e1: Expected Obj, but got I
			//IL_0183: Expected I, but got Obj
			//IL_01d0: Expected I, but got Obj
			//IL_0112: Expected I, but got Obj
			string dataPath = Application.dataPath;
			if ((nint)dataPath == 8)
			{
				nint num = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v53 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num5 = ((ComputeShader)(object)GameCenterPlugin._instance).FindKernel((string)null);
				nint num6 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v14 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag = obj3 == null;
				if (num5 == 0)
				{
					if (!flag)
					{
						nint num7 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					GameCenterPlugin.LogWarning("ReportAchievement was called before Init");
					return;
				}
				if (!flag)
				{
					nint num8 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num9 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v28 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num10 = (nint)typeof(Depository);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v34 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num11 = FileUtil.CopyTo((Stream)(object)parent, (Stream)(object)GameCenterPlugin._instance);
			}
			else if ((object)parent != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
			}
		}

		public void CheckForDespawn(float cameraGamePositionZ)
		{
			//IL_00a1: Expected I, but got Obj
			//IL_00b7: Expected Obj, but got I
			//IL_0243: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00e2: Expected I, but got Obj
			//IL_01df: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			List<Transform> spawnedTransforms = _spawnedTransforms;
			if (cameraGamePositionZ < 0.5f)
			{
				nint num = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v37 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v42 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float b = _lastSpawnGamePositionZ * (float)Config__BackingField;
				float t = cameraGamePositionZ * 2f;
				float orthographicSize = Mathf.LerpUnclamped(_lastSpawnGamePositionZ, b, t);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Collections.Generic.List`1<UnityEngine.Transform>)+6C]");
				((Camera)0).orthographicSize = orthographicSize;
			}
			else
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float a = _lastSpawnGamePositionZ * (float)Config__BackingField;
				float num5 = cameraGamePositionZ * 2f;
				float t2 = num5 - 1f;
				float orthographicSize2 = Mathf.LerpUnclamped(a, _lastSpawnGamePositionZ, t2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Collections.Generic.List`1<UnityEngine.Transform>)+6C]");
				((Camera)0).orthographicSize = orthographicSize2;
			}
			if (cameraGamePositionZ == 1f)
			{
				List<Transform> spawnedTransforms2 = _spawnedTransforms;
				_ = 0;
			}
		}

		public bool HasSpawned(Transform instance)
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected Obj, but got Unknown
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_00b0: Expected I, but got Obj
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected Obj, but got Unknown
			DistantObjectConfig distantObjectConfig = Config__BackingField;
			EnvironmentKind[] environmentKind = distantObjectConfig._environmentKind;
			if (environmentKind.Length != 0)
			{
				object obj = 0;
				while (true)
				{
					DistantObjectConfig distantObjectConfig2 = Config__BackingField;
					EnvironmentKind[] environmentKind2 = distantObjectConfig2._environmentKind;
					if ((nint)obj >= environmentKind2.Length)
					{
						return false;
					}
					DistantObjectConfig distantObjectConfig3 = Config__BackingField;
					object obj2 = distantObjectConfig3._environmentKind + 16;
					object obj3 = obj << 2;
					object obj4 = obj2 + obj3;
					object obj5 = obj4;
					nint num = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v23 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num2 = (nint)typeof(EnvironmentKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v38 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v21+8]");
					bool flag;
					if ((IntPtr)0 == ((UnityEngine.Object)instance).m_CachedPtr)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v21+C]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [instance @ L1 (UnityEngine.Transform)+C]");
						flag = num3 == 0;
					}
					else
					{
						flag = false;
					}
					if (flag)
					{
						break;
					}
					object obj7 = obj + 1;
					obj = obj7;
				}
				return true;
			}
			return true;
		}
	}

	private const float SpawnDistance = 1260f;

	private const float SpawnCheckDistance = 90f;

	private const float DistantObjectDespawnDistance = -90f;

	private const float MinimumXOffset = 250f;

	private const float MaximumXOffset = 1500f;

	private const float MaximumProjectedX = 500f;

	private bool _distantEnvironmentActive;

	private DistantObjectGlobalConfig _distantObjectGlobalConfig;

	private DistantObjectSpawner[] _distantObjectSpawners;

	private float _lastCharacterGamePositionZ;

	private float _distanceSinceLastSpawnCheck;

	private float _lastSpawnGamePositionZ;

	private List<DistantObject> _activeDistantObjects;

	private List<DistantObjectSpawner> _spawnableSpawners;

	private void Start()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private unsafe void LateUpdate()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I4
		//IL_030b: Expected I, but got Obj
		//IL_0321: Expected Obj, but got I
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_05e9: Expected I, but got Obj
		//IL_05ff: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0131: Expected I4, but got Obj
		//IL_034c: Expected I, but got Obj
		//IL_0399: Expected I, but got Obj
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			return;
		}
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v9 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v85 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine instance = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v5 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v6+14]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v7+C]");
		bool distantEnvironmentActive = (nint)0 != 0;
		_distantEnvironmentActive = distantEnvironmentActive;
		if (~(_distantEnvironmentActive ? 1u : 0u) != 0)
		{
			return;
		}
		object obj4 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v6+10]");
		obj4 = 0;
		object obj5 = this + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v6+14]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = default;
		obj5 = obj7;
		object obj8 = 0;
		DistantObjectSpawner[] distantObjectSpawners = _distantObjectSpawners;
		if ((nint)obj8 < distantObjectSpawners.Length)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v6+14]");
			object obj9 = (nint)0 + (nint)16;
			object obj10 = obj8 << 2;
			object obj11 = obj9 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AgeRestriction._003C_003Ec obj12 = default;
			obj12._003C_002Ecctor_003Eb__25_0((RefreshType)obj11);
			throw new ArrayTypeMismatchException();
		}
		nint num3 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v25 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v46 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.BeginBalancing(null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(DistantEnvironmentController.Game_OnMenuScreenShown);
		object obj14 = action + 16;
		obj14 = this;
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v37 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v42 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnMenuScreenShown -= action;
	}

	private unsafe void Game_OnMenuScreenShown()
	{
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected I4, but got Unknown
		//IL_0296: Expected Obj, but got I4
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_005d: Expected I, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0304: Expected I4, but got Obj
		//IL_0338: Expected I, but got Obj
		//IL_034e: Expected Obj, but got I
		//IL_00eb: Expected I, but got Obj
		//IL_0184: Expected VT, but got Obj
		//IL_0184: Expected Obj, but got I4
		//IL_0138: Expected I, but got Obj
		//IL_03a1: Expected F4, but got I
		//IL_01bd: Expected I4, but got Obj
		//IL_0245: Expected I4, but got Obj
		//IL_025b: Expected Obj, but got I4
		object obj = default;
		bool flag = (byte)(obj + 12) != 0;
		obj = 0;
		_ = 0;
		if (~(_distantEnvironmentActive ? 1u : 0u) != 0)
		{
			return;
		}
		Camera current = Camera.current;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)current).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v20 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v64 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		object obj4 = instance + 236;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj4 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v16+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Boolean)+8]");
		float num5 = 0f - _lastCharacterGamePositionZ;
		nint num6 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v30 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v60 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		Camera current2 = Camera.current;
		GameObject gameObject = current2.gameObject;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
		if (num5 > 0f)
		{
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((BaseTimer)(object)this)._002Ector(num5, flag);
		}
		List<DistantObject> activeDistantObjects = _activeDistantObjects;
		if (activeDistantObjects._size >= 1)
		{
			int num8 = 0;
			while (true)
			{
				List<DistantObject> activeDistantObjects2 = _activeDistantObjects;
				if (num8 >= activeDistantObjects2._size)
				{
					break;
				}
				DistantObject distantObject = _activeDistantObjects.get_Item(num8);
				((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				SYBO.Subway.Info.Characters.CharacterId? characterTypeForName = SYBO.Subway.Info.Characters.GetCharacterTypeForName((string)flag);
				int num9 = num8 + 1;
				num8 = num9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Boolean)+8]");
		_lastCharacterGamePositionZ = 0f;
	}

	private void UpdateDistantEnvironment(float characterDeltaZ, Vector3 cameraGamePosition)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		obj = obj2;
		_ = 1;
		object obj3 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		float num = characterDeltaZ / (float)cameraGamePosition;
	}

	public int GetObjectSettingIndex(Transform instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = instance - 2;
		if ((nint)instance == 2 || ((nint)obj != 1 && (nint)obj == 2))
		{
			return 1;
		}
		return ((nint)instance == 16) ? 1 : 0;
	}

	public unsafe void RegisterDistantObject(DistantObject obj)
	{
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected Obj, but got Unknown
		//IL_0917: Expected Obj, but got I4
		//IL_0938: Expected I, but got Obj
		//IL_094e: Expected Obj, but got I
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected VT, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected VT, but got Unknown
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected Obj, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected Obj, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got Unknown
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Expected Obj, but got Unknown
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected Obj, but got Unknown
		//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Expected Obj, but got Unknown
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected Obj, but got Unknown
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Expected Obj, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected Obj, but got Unknown
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected Obj, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected Obj, but got Unknown
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected Obj, but got Unknown
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected Obj, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected Obj, but got Unknown
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Expected Obj, but got Unknown
		//IL_0a63: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0a93: Expected Obj, but got F4
		//IL_00a1: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I
		//IL_0152: Expected VT, but got F4
		//IL_015f: Expected F4, but got Obj
		//IL_015a: Expected native int or pointer, but got VT
		//IL_0171: Expected F4, but got I
		//IL_016c: Expected native int or pointer, but got VT
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got F4
		//IL_01a2: Expected VT, but got F4
		//IL_01b4: Expected F4, but got Obj
		//IL_01af: Expected native int or pointer, but got VT
		//IL_01c6: Expected F4, but got I
		//IL_01c1: Expected native int or pointer, but got VT
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01de: Expected Obj, but got F4
		//IL_01f3: Expected Obj, but got F4
		//IL_0204: Expected F4, but got Obj
		//IL_01ff: Expected native int or pointer, but got VT
		//IL_0219: Expected F4, but got I
		//IL_0214: Expected native int or pointer, but got VT
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0231: Expected Obj, but got F4
		//IL_024a: Expected VT, but got F4
		//IL_025c: Expected F4, but got Obj
		//IL_0257: Expected native int or pointer, but got VT
		//IL_026e: Expected F4, but got I
		//IL_0269: Expected native int or pointer, but got VT
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0286: Expected Obj, but got F4
		//IL_029f: Expected VT, but got F4
		//IL_02ae: Expected VT, but got F4
		//IL_02c1: Expected I, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_0ac8: Expected F4, but got Obj
		//IL_0ac3: Expected native int or pointer, but got VT
		//IL_0ada: Expected F4, but got I
		//IL_0ad5: Expected native int or pointer, but got VT
		//IL_0ae7: Expected F4, but got Obj
		//IL_0ae2: Expected native int or pointer, but got VT
		//IL_0af9: Expected F4, but got I
		//IL_0af4: Expected native int or pointer, but got VT
		//IL_0b17: Expected F4, but got Obj
		//IL_0b12: Expected native int or pointer, but got VT
		//IL_0b2c: Expected F4, but got I
		//IL_0b27: Expected native int or pointer, but got VT
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got Unknown
		//IL_0b44: Expected Obj, but got F4
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected Obj, but got Unknown
		//IL_0b70: Expected F4, but got Obj
		//IL_0b6b: Expected native int or pointer, but got VT
		//IL_0b85: Expected F4, but got I
		//IL_0b80: Expected native int or pointer, but got VT
		//IL_0b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Expected Obj, but got Unknown
		//IL_0b9d: Expected Obj, but got F4
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected Obj, but got Unknown
		//IL_0351: Expected Obj, but got F4
		//IL_0360: Expected Obj, but got F4
		//IL_0302: Expected I, but got Obj
		//IL_0376: Expected F4, but got Obj
		//IL_0371: Expected native int or pointer, but got VT
		//IL_038b: Expected F4, but got I
		//IL_0386: Expected native int or pointer, but got VT
		//IL_0398: Expected F4, but got Obj
		//IL_0393: Expected native int or pointer, but got VT
		//IL_03ad: Expected F4, but got I
		//IL_03a8: Expected native int or pointer, but got VT
		//IL_03ef: Expected F4, but got Obj
		//IL_03ea: Expected native int or pointer, but got VT
		//IL_0404: Expected F4, but got I
		//IL_03ff: Expected native int or pointer, but got VT
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_041c: Expected Obj, but got F4
		//IL_0435: Expected VT, but got F4
		//IL_0444: Expected VT, but got F4
		//IL_0457: Expected I, but got Obj
		//IL_046d: Expected Obj, but got I
		//IL_0bce: Expected F4, but got Obj
		//IL_0bc9: Expected native int or pointer, but got VT
		//IL_0be0: Expected F4, but got I
		//IL_0bdb: Expected native int or pointer, but got VT
		//IL_0bed: Expected F4, but got Obj
		//IL_0be8: Expected native int or pointer, but got VT
		//IL_0bff: Expected F4, but got I
		//IL_0bfa: Expected native int or pointer, but got VT
		//IL_0c0c: Expected I4, but got VT
		//IL_0c0c: Expected Ref, but got VT
		//IL_0c1b: Expected Obj, but got F4
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected Obj, but got Unknown
		//IL_04e4: Expected F4, but got Obj
		//IL_04df: Expected native int or pointer, but got VT
		//IL_04f9: Expected F4, but got I
		//IL_04f4: Expected native int or pointer, but got VT
		//IL_0506: Expected F4, but got Obj
		//IL_0501: Expected native int or pointer, but got VT
		//IL_051b: Expected F4, but got I
		//IL_0516: Expected native int or pointer, but got VT
		//IL_05af: Expected Obj, but got I4
		//IL_0498: Expected I, but got Obj
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected Obj, but got Unknown
		//IL_0769: Expected I, but got Obj
		//IL_077f: Expected Obj, but got I
		//IL_0cdf: Expected F4, but got Obj
		//IL_0cda: Expected native int or pointer, but got VT
		//IL_0cf1: Expected F4, but got I
		//IL_0cec: Expected native int or pointer, but got VT
		//IL_0d10: Expected F4, but got Obj
		//IL_0d0b: Expected native int or pointer, but got VT
		//IL_0d22: Expected F4, but got I
		//IL_0d1d: Expected native int or pointer, but got VT
		//IL_0d2f: Expected F4, but got Obj
		//IL_0d2a: Expected native int or pointer, but got VT
		//IL_0d44: Expected F4, but got I
		//IL_0d3f: Expected native int or pointer, but got VT
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_0601: Expected F4, but got Obj
		//IL_05fc: Expected native int or pointer, but got VT
		//IL_0613: Expected F4, but got I
		//IL_060e: Expected native int or pointer, but got VT
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected Obj, but got Unknown
		//IL_062b: Expected Obj, but got F4
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_068b: Expected I, but got Obj
		//IL_06a1: Expected Obj, but got I
		//IL_07f6: Expected F4, but got Obj
		//IL_07f1: Expected native int or pointer, but got VT
		//IL_0808: Expected F4, but got I
		//IL_0803: Expected native int or pointer, but got VT
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_0820: Expected Obj, but got F4
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected Obj, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected Obj, but got Unknown
		//IL_0880: Expected I, but got Obj
		//IL_0896: Expected Obj, but got I
		//IL_07aa: Expected I, but got Obj
		//IL_0c46: Expected F4, but got Obj
		//IL_0c41: Expected native int or pointer, but got VT
		//IL_0c58: Expected F4, but got I
		//IL_0c53: Expected native int or pointer, but got VT
		//IL_0c65: Expected F4, but got Obj
		//IL_0c60: Expected native int or pointer, but got VT
		//IL_0c7a: Expected F4, but got I
		//IL_0c75: Expected native int or pointer, but got VT
		//IL_0c98: Expected F4, but got Obj
		//IL_0c93: Expected native int or pointer, but got VT
		//IL_0caa: Expected F4, but got I
		//IL_0ca5: Expected native int or pointer, but got VT
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb5: Expected Obj, but got Unknown
		//IL_0cc2: Expected Obj, but got F4
		//IL_0d83: Expected F4, but got Obj
		//IL_0d7e: Expected native int or pointer, but got VT
		//IL_0d95: Expected F4, but got I
		//IL_0d90: Expected native int or pointer, but got VT
		//IL_0da2: Expected F4, but got Obj
		//IL_0d9d: Expected native int or pointer, but got VT
		//IL_0db7: Expected F4, but got I
		//IL_0db2: Expected native int or pointer, but got VT
		//IL_0dd5: Expected F4, but got Obj
		//IL_0dd0: Expected native int or pointer, but got VT
		//IL_0dea: Expected F4, but got I
		//IL_0de5: Expected native int or pointer, but got VT
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected Obj, but got Unknown
		//IL_0e02: Expected Obj, but got F4
		//IL_06cc: Expected I, but got Obj
		//IL_08c1: Expected I, but got Obj
		object obj3 = default;
		object obj2 = obj3 + 220;
		obj2 = 0;
		_ = 0;
		_0021_00210 componentInChildren = (_0021_00210)((Component)obj).GetComponentInChildren<T>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v236 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj3 + 248);
		Vector3 vector2 = (Vector3)(obj3 + 232);
		Transform transform = (Transform)(obj3 + 208);
		Transform transform2 = (Transform)(obj3 + 192);
		object obj5 = obj3 + 176;
		Transform transform3 = (Transform)(obj3 + 160);
		Transform transform4 = (Transform)(obj3 + 144);
		Transform transform5 = (Transform)(obj3 + 132);
		object obj6 = obj3 + 120;
		object obj7 = obj3 + 104;
		object obj8 = obj3 + 92;
		object obj9 = obj3 + 80;
		object obj10 = obj3 + 68;
		object obj11 = obj3 + 56;
		Transform transform6 = (Transform)(obj3 + 40);
		Transform transform7 = (Transform)(obj3 + 24);
		object obj12 = obj3 + 12;
		if (((ComputeShader)componentInChildren).FindKernel(null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v286 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)_distanceSinceLastSpawnCheck != obj || _distantObjectGlobalConfig != null)
		{
			return;
		}
		_distantObjectGlobalConfig = (DistantObjectGlobalConfig)1;
		object obj14 = this + 28;
		obj14 = obj;
		object obj15 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (T)+C]");
		obj15 = 0;
		transform.position = (Vector3)_lastCharacterGamePositionZ;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		object obj16 = this + 80;
		obj16 = vector.x;
		_ = vector.z;
		transform2.rotation = (Quaternion)_lastCharacterGamePositionZ;
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		object obj17 = this + 36;
		obj17 = vector.x;
		_ = vector.z;
		Quaternion rotation = ((Transform)_lastSpawnGamePositionZ).rotation;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj18 = this + 92;
		obj18 = vector.x;
		_ = vector.z;
		transform3.rotation = (Quaternion)_lastSpawnGamePositionZ;
		((Vector3*)(nint)vector)->x = (float)transform3;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
		object obj19 = this + 104;
		obj19 = vector.x;
		_ = vector.z;
		transform4.position = (Vector3)_lastSpawnGamePositionZ;
		transform5.position = (Vector3)_lastCharacterGamePositionZ;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v95 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v232 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform4;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform4).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)transform5;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform5).m_CachedPtr;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj21 = this + 56;
		obj21 = vector.x;
		_ = vector.z;
		object obj22 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v37+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj23 = this + 68;
		obj23 = vector.x;
		_ = vector.z;
		object obj24 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		Vector3 forward = ((Transform)_lastCharacterGamePositionZ).forward;
		Vector3 forward2 = ((Transform)_lastSpawnGamePositionZ).forward;
		((Vector3*)(nint)vector2)->x = (float)obj8;
		Vector3 vector6 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v39+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v41+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Vector3 vector8 = vector2 - vector;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v43+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		((Vector3*)(nint)vector)->x = (float)obj11;
		Vector3 vector9 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v45+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		object obj25 = this + 132;
		obj25 = vector.x;
		_ = vector.z;
		transform6.rotation = (Quaternion)_lastCharacterGamePositionZ;
		transform7.rotation = (Quaternion)_lastSpawnGamePositionZ;
		nint num7 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v134 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num8 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S0_v228 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform6;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform6).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)transform7;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform7).m_CachedPtr;
		float num9 = ((Vector2*)vector2)->get_Item((int)vector);
		Quaternion rotation2 = ((Transform)_lastCharacterGamePositionZ).rotation;
		object obj27 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		((Vector3*)(nint)vector2)->x = (float)obj12;
		Vector3 vector10 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v51+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector11 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector11)->z = 0f;
		bool flag = num9 > 90f;
		float num10 = vector2.x * vector.x;
		float num11 = vector2.y * vector.y;
		float num12 = num10 + num11;
		float num13 = vector2.z * vector.z;
		float num14 = num12 + num13;
		bool flag2 = num14 < 0f;
		object obj28 = flag & flag2;
		if (obj28 != null)
		{
			object obj29 = this + 68;
			transform = (Transform)obj29;
			Transform transform8 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S1_v244+8]");
			((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
			((Vector3*)(nint)vector)->x = (float)transform;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			object obj30 = this + 120;
			obj30 = vector.x;
			_ = vector.z;
			object obj31 = this + 120;
			transform2 = (Transform)obj31;
			Transform transform9 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S1_v258+8]");
			((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
			object obj32 = this + 132;
			obj5 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S1_v263+8]");
			_ = 0;
			nint num15 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S0_v210 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num16 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v224 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)transform2;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Vector3 vector12 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27+8]");
			((Vector3*)(nint)vector12)->z = 0f;
			Quaternion quaternion2 = (Quaternion)vector2 * (Quaternion)vector;
			((Vector3*)(nint)vector)->x = (float)transform3;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
			object obj34 = this + 144;
			obj34 = vector.x;
			_ = vector.z;
			return;
		}
		object obj35 = this + 68;
		transform = (Transform)obj35;
		Transform transform10 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S1_v176+8]");
		((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
		object obj36 = this + 92;
		transform2 = (Transform)obj36;
		Transform transform11 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S1_v181+8]");
		((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
		nint num17 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v151 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			nint num18 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S0_v194 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Quaternion quaternion3 = Quaternion.AngleAxis(0.2f, vector);
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector13 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		Quaternion quaternion4 = Quaternion.FromToRotation(vector2, vector);
		obj2 = transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		((Vector3*)(nint)vector)->x = (float)transform4;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform4).m_CachedPtr;
		object obj38 = this + 120;
		obj38 = vector.x;
		_ = vector.z;
		object obj39 = this + 120;
		transform5 = (Transform)obj39;
		Transform transform12 = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ S1_v215+8]");
		((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
		object obj40 = this + 132;
		obj6 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S1_v220+8]");
		_ = 0;
		nint num19 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S0_v176 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num20 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S0_v190 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform5;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform5).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector14 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+8]");
		((Vector3*)(nint)vector14)->z = 0f;
		Quaternion quaternion5 = (Quaternion)vector2 * (Quaternion)vector;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector15 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v37+8]");
		((Vector3*)(nint)vector15)->z = 0f;
		object obj42 = this + 144;
		obj42 = vector.x;
		_ = vector.z;
	}

	public void DeregisterDistantObject(DistantObject obj)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
	}

	public unsafe DistantEnvironmentController()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected I4, but got Unknown
		//IL_0147: Expected I4, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_00b1: Expected I, but got Obj
		object obj = default;
		object obj4 = default;
		while (true)
		{
			DistantObjectSpawner[] distantObjectSpawners = _distantObjectSpawners;
			if ((nint)obj >= distantObjectSpawners.Length)
			{
				break;
			}
			object obj2 = _distantObjectSpawners + 16;
			object obj3 = obj4 << 2;
			object obj5 = obj2 + obj3;
			((TransitionConfig.WeightRandomizedTransitionPrefabContainer)obj5)._002Ector();
			obj = obj4 + 1;
		}
		_lastSpawnGamePositionZ = 0f;
		_lastCharacterGamePositionZ = -1260f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj7 = default;
		bool flag = (byte)(obj7 + 12) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj7 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((BaseTimer)(object)this)._002Ector(1260f, flag);
		_lastCharacterGamePositionZ = 0f;
	}
}
