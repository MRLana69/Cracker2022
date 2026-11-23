using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Level.Environments;

public class DistantEnvironmentController : Singleton<DistantEnvironmentController>
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

		public float GlobalMinDistanceFirstSpawn => _globalMinDistanceFirstSpawn;

		public float GlobalMinDistanceBetween => _globalMinDistanceBetween;
	}

	[Serializable]
	public class DistantObjectConfig
	{
		private string _name = string.Empty;

		private Transform[] _prefabs;

		private EnvironmentSide _environmentSide = EnvironmentSide.Both;

		private EnvironmentKind[] _environmentKind;

		private float _projectionSourceOffsetXMin;

		private float _projectionSourceOffsetXMax;

		private float _minDistanceFirstSpawn;

		private float _minDistanceBetween;

		private float _spawnProbability;

		public string Name => _name;

		public Transform[] Prefabs => _prefabs;

		public EnvironmentSide EnvironmentSide => _environmentSide;

		public EnvironmentKind[] EnvironmentKind => _environmentKind;

		public float ProjectionSourceOffsetXMin => _projectionSourceOffsetXMin;

		public float ProjectionSourceOffsetXMax => _projectionSourceOffsetXMax;

		public float MinDistanceFirstSpawn => _minDistanceFirstSpawn;

		public float MinDistanceBetween => _minDistanceBetween;

		public float SpawnProbability => _spawnProbability;

		public Transform GetRandomPrefab()
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_0046: Expected Obj, but got I
			Transform[] prefabs = _prefabs;
			int num = UnityEngine.Random.Range(0, prefabs.Length);
			int num2 = num << 2;
			object obj = prefabs + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v4+10]");
			return (Transform)0;
		}

		public DistantObjectConfig()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			EnvironmentKind[] environmentKind = default;
			_environmentKind = environmentKind;
		}
	}

	private class DistantObjectSpawner
	{
		private List<Transform> _spawnedTransforms;

		private float _lastSpawnPositionZ;

		private DistantObjectConfig Config__BackingField;

		public DistantObjectConfig Config
		{
			get
			{
				return Config__BackingField;
			}
			private set
			{
				Config__BackingField = value;
			}
		}

		public DistantObjectSpawner(DistantObjectConfig config)
		{
			List<Transform> list = default;
			list._002Ector();
			_spawnedTransforms = list;
			_lastSpawnPositionZ = -1260f;
			Config__BackingField = config;
			Reset();
		}

		public void Reset()
		{
			int num = 0;
			while (true)
			{
				List<Transform> spawnedTransforms = _spawnedTransforms;
				if (spawnedTransforms._size <= num)
				{
					break;
				}
				Transform instance = _spawnedTransforms.get_Item(num);
				PoolManager.Despawn(instance);
				int num2 = num + 1;
				num = num2;
			}
			((List<T>)(object)_spawnedTransforms).Clear();
			_lastSpawnPositionZ = -1260f;
		}

		public bool CanSpawnAt(float positionZ, EnvironmentKind environmentKind)
		{
			bool result;
			if (CanSpawnAtEnvironmentKind(environmentKind))
			{
				DistantObjectConfig distantObjectConfig = Config__BackingField;
				if (!(distantObjectConfig._minDistanceFirstSpawn > positionZ))
				{
					float num = _lastSpawnPositionZ + distantObjectConfig._minDistanceBetween;
					bool flag = !(positionZ < num);
					result = true;
					if (flag)
					{
						goto IL_00ac;
					}
				}
			}
			result = false;
			goto IL_00ac;
			IL_00ac:
			return result;
		}

		private bool CanSpawnAtEnvironmentKind(EnvironmentKind environmentKind)
		{
			//IL_011e: Expected Obj, but got I4
			//IL_012f: Expected Obj, but got I4
			//IL_0036: Expected Obj, but got I
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected Obj, but got Unknown
			//IL_00c7: Expected Obj, but got I4
			DistantObjectConfig distantObjectConfig = Config__BackingField;
			EnvironmentKind[] environmentKind2 = distantObjectConfig._environmentKind;
			bool flag = environmentKind2.Length == 0;
			bool flag2 = !flag;
			object obj = environmentKind2.Length;
			EnvironmentKind[] array = environmentKind2;
			object obj2 = 0;
			if (!flag2)
			{
				return true;
			}
			bool flag3;
			while (true)
			{
				flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				if (!flag3)
				{
					break;
				}
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v18+10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v19+8]");
				bool flag4;
				if ((nint)0 == (nint)environmentKind._type)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v19+C]");
					flag4 = (nint)0 == (nint)environmentKind._density;
				}
				else
				{
					flag4 = false;
				}
				if (flag4)
				{
					break;
				}
				object obj6 = obj2 + 1;
				DistantObjectConfig distantObjectConfig2 = Config__BackingField;
				EnvironmentKind[] environmentKind3 = distantObjectConfig2._environmentKind;
				obj = environmentKind3.Length;
				array = environmentKind3;
				obj2 = obj6;
			}
			return flag3;
		}

		public unsafe void Spawn(float spawnPositionZ, Transform parent)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0297: Expected F4, but got I
			//IL_0292: Expected native int or pointer, but got VT
			//IL_02b7: Expected F4, but got I
			//IL_02b2: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			Transform randomPrefab = Config__BackingField.GetRandomPrefab();
			Transform transform = PoolManager.Spawn(randomPrefab);
			transform.parent = parent;
			Game instance = Game.Instance;
			DistantObjectConfig distantObjectConfig = Config__BackingField;
			float num = instance._randomGenerator.Range(distantObjectConfig._projectionSourceOffsetXMin, distantObjectConfig._projectionSourceOffsetXMax);
			DistantObjectConfig distantObjectConfig2 = Config__BackingField;
			if (distantObjectConfig2._environmentSide == EnvironmentSide.Left)
			{
				goto IL_0139;
			}
			bool flag = distantObjectConfig2._environmentSide == EnvironmentSide.Right;
			float value = num;
			if (!flag)
			{
				if (distantObjectConfig2._environmentSide != EnvironmentSide.Both)
				{
					value = num;
				}
				else
				{
					Game instance2 = Game.Instance;
					float num2 = instance2._randomGenerator.Value();
					bool flag2 = !(num2 < 0.5f);
					bool flag3 = !flag2;
					value = num;
					if (!flag3)
					{
						goto IL_0139;
					}
				}
			}
			goto IL_01f4;
			IL_01f4:
			float num3 = Math.Abs(value);
			float num4 = num3 - 250f;
			float num5 = num4 * (1f / 3f);
			float num6 = num5 + 250f;
			float num7 = num3 / num6;
			bool flag4 = num7 > 1f;
			bool flag5 = !flag4;
			float num8 = spawnPositionZ;
			if (!flag5)
			{
				Camera main = Camera.main;
				Transform transform2 = main.transform;
				Vector3 position = transform2.position;
				float num9 = spawnPositionZ;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				float num10 = num9 - 0f;
				float num11 = num10 * num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				float num12 = 0f + num11;
				num8 = num12;
			}
			DistantObject component = transform.GetComponent<DistantObject>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			component.Initialize(vector, num7);
			_spawnedTransforms.Add(transform);
			_lastSpawnPositionZ = spawnPositionZ;
			return;
			IL_0139:
			float num13 = -0f - num;
			value = num13;
			goto IL_01f4;
		}

		public void CheckForDespawn(float cameraPositionZ)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0058: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 - 16;
			int num = 0;
			while (true)
			{
				List<Transform> spawnedTransforms = _spawnedTransforms;
				if (num < spawnedTransforms._size)
				{
					Transform transform = _spawnedTransforms.get_Item(num);
					Vector3 position = transform.position;
					float num2 = cameraPositionZ - -90f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					if (0f < num2)
					{
						Transform instance = _spawnedTransforms.get_Item(num);
						PoolManager.Despawn(instance);
						_spawnedTransforms.RemoveAt(num);
					}
					else
					{
						int num3 = num + 1;
						num = num3;
					}
					continue;
				}
				break;
			}
		}

		public bool HasSpawned(Transform instance)
		{
			int num = 0;
			bool flag;
			while (true)
			{
				List<Transform> spawnedTransforms = _spawnedTransforms;
				flag = num < spawnedTransforms._size;
				if (!flag)
				{
					break;
				}
				Transform transform = _spawnedTransforms.get_Item(num);
				if (!(transform != instance))
				{
					break;
				}
				int num2 = num + 1;
				num = num2;
			}
			return flag;
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

	private float _lastCharacterZ;

	private float _distanceSinceLastSpawnCheck;

	private float _lastSpawnPositionZ;

	private List<DistantObject> _activeDistantObjects;

	private List<DistantObjectSpawner> _spawnableSpawners;

	private unsafe void Start()
	{
		//IL_009e: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I
		if (!Application.isPlaying)
		{
			return;
		}
		ThemeManager instance = ThemeManager.Instance;
		Theme theme = instance._theme;
		DistantObjectConfig[] distantObjectConfigs = theme._distantObjectConfigs;
		bool distantEnvironmentActive = distantObjectConfigs.Length != 0;
		_distantEnvironmentActive = distantEnvironmentActive;
		if (distantObjectConfigs.Length != 0)
		{
			_distantObjectGlobalConfig = theme._distantObjectGlobalConfig;
			DistantObjectConfig[] distantObjectConfigs2 = theme._distantObjectConfigs;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			DistantObjectSpawner[] distantObjectSpawners = default;
			_distantObjectSpawners = distantObjectSpawners;
			object obj = 0;
			DistantObjectSpawner[] distantObjectSpawners2 = _distantObjectSpawners;
			if (distantObjectSpawners2.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)theme._distantObjectConfigs + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v32+10]");
				DistantObjectSpawner distantObjectSpawner = default;
				distantObjectSpawner._002Ector((DistantObjectConfig)0);
				throw new ArrayTypeMismatchException();
			}
			PoolManager.TriggerPoolBalancing();
			Action action = default;
			action._002Ector(this, (nint)__ldftn(DistantEnvironmentController.Game_OnMenuScreenShown));
			Game.OnMenuScreenShown += action;
		}
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01e3: Expected F4, but got I
		//IL_00f4: Expected F4, but got I
		//IL_0168: Expected F4, but got I
		//IL_0163: Expected native int or pointer, but got VT
		//IL_018a: Expected F4, but got I
		//IL_0185: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (~(_distantEnvironmentActive ? 1u : 0u) != 0)
		{
			return;
		}
		Camera main = Camera.main;
		if (!(main != null))
		{
			return;
		}
		Character instance = Character.Instance;
		Transform transform = instance.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num = 0f - _lastCharacterZ;
		Camera main2 = Camera.main;
		Transform transform2 = main2.transform;
		Vector3 position2 = transform2.position;
		if (num > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			UpdateDistantEnvironment(num, 0f);
		}
		List<DistantObject> activeDistantObjects = _activeDistantObjects;
		if (activeDistantObjects._size >= 1)
		{
			int num2 = 0;
			while (true)
			{
				List<DistantObject> activeDistantObjects2 = _activeDistantObjects;
				if (num2 >= activeDistantObjects2._size)
				{
					break;
				}
				DistantObject distantObject = _activeDistantObjects.get_Item(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				distantObject.UpdateDistantObject(vector);
				int num3 = num2 + 1;
				num2 = num3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_lastCharacterZ = 0f;
	}

	private void Game_OnMenuScreenShown()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			DistantObjectSpawner[] distantObjectSpawners = _distantObjectSpawners;
			if (distantObjectSpawners.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)distantObjectSpawners + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12+10]");
			((DistantObjectSpawner)0).Reset();
			object obj4 = obj + 1;
			obj = obj4;
		}
		_lastCharacterZ = -1260f;
		_lastSpawnPositionZ = 0f;
		UpdateDistantEnvironment(1260f, 0f);
		_lastCharacterZ = 0f;
	}

	private void UpdateDistantEnvironment(float characterDeltaZ, float cameraZ)
	{
		//IL_02bb: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_00b7: Expected VT, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00ed: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_0176: Expected I, but got Obj
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got I
		//IL_01d7: Expected I, but got Obj
		//IL_01fc: Expected Obj, but got I
		float num = _distanceSinceLastSpawnCheck + characterDeltaZ;
		float num2 = num;
		RouteBuilder routeBuilder = default;
		while (true)
		{
			_distanceSinceLastSpawnCheck = num2;
			if (!(num2 > 90f))
			{
				break;
			}
			DistantObjectGlobalConfig distantObjectGlobalConfig = _distantObjectGlobalConfig;
			float num3 = _lastSpawnPositionZ + distantObjectGlobalConfig._globalMinDistanceBetween;
			float num4 = _lastCharacterZ + characterDeltaZ;
			float num5 = num4 - num2;
			float num6 = num5 + 1260f;
			if (!(num6 < distantObjectGlobalConfig._globalMinDistanceFirstSpawn) && !(num6 < num3))
			{
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v46 (T)+38]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v22+DC]");
				Transform transform = (Transform)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v137 @ S1_v22+DC] (should have been resolved before IL gen)");
				object obj4 = 0;
				int num7;
				while (true)
				{
					DistantObjectSpawner[] distantObjectSpawners = _distantObjectSpawners;
					bool flag = distantObjectSpawners.Length > (nint)obj4;
					bool flag2 = !flag;
					num7 = 0;
					if (flag2)
					{
						break;
					}
					object obj5 = obj4 << 2;
					object obj6 = (object)distantObjectSpawners + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v71+10]");
					DistantObjectSpawner distantObjectSpawner = (DistantObjectSpawner)0;
					EnvironmentKind environmentKindAt = routeBuilder.GetEnvironmentKindAt(num6);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v71+10]");
					bool flag3 = ((DistantObjectSpawner)0).CanSpawnAt(num6, environmentKindAt);
					bool flag4 = !flag3;
					nint num8 = (nint)environmentKindAt;
					if (!flag4)
					{
						Game instance = Game.Instance;
						float num9 = instance._randomGenerator.Value();
						DistantObjectConfig distantObjectConfig = distantObjectSpawner.Config__BackingField;
						bool flag5 = num9 < distantObjectConfig._spawnProbability;
						bool flag6 = !flag5;
						num8 = (nint)environmentKindAt;
						if (!flag6)
						{
							List<DistantObjectSpawner> spawnableSpawners = _spawnableSpawners;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v71+10]");
							spawnableSpawners.Add((DistantObjectSpawner)0);
							num8 = 0;
						}
					}
					object obj7 = obj4 + 1;
					transform = (Transform)num8;
					obj4 = obj7;
				}
				while (true)
				{
					List<DistantObjectSpawner> spawnableSpawners2 = _spawnableSpawners;
					if (spawnableSpawners2._size <= num7)
					{
						break;
					}
					DistantObjectSpawner distantObjectSpawner2 = _spawnableSpawners.get_Item(num7);
					transform = base.transform;
					distantObjectSpawner2.Spawn(num6, transform);
					_lastSpawnPositionZ = num6;
					int num10 = num7 + 1;
					num7 = num10;
				}
				((List<T>)(object)_spawnableSpawners).Clear();
			}
			float num11 = _distanceSinceLastSpawnCheck - 90f;
			num2 = num11;
		}
		object obj8 = 0;
		while (true)
		{
			DistantObjectSpawner[] distantObjectSpawners2 = _distantObjectSpawners;
			if (distantObjectSpawners2.Length > (nint)obj8)
			{
				object obj9 = obj8 << 2;
				object obj10 = (object)distantObjectSpawners2 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v19+10]");
				((DistantObjectSpawner)0).CheckForDespawn(cameraZ);
				object obj11 = obj8 + 1;
				obj8 = obj11;
				continue;
			}
			break;
		}
	}

	public int GetObjectSettingIndex(Transform instance)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I
		int num = 0;
		while (true)
		{
			DistantObjectSpawner[] distantObjectSpawners = _distantObjectSpawners;
			if (distantObjectSpawners.Length <= num)
			{
				break;
			}
			int num2 = num << 2;
			object obj = distantObjectSpawners + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v9+10]");
			if (((DistantObjectSpawner)0).HasSpawned(instance))
			{
				return num;
			}
			int num3 = num + 1;
			num = num3;
		}
		return 0;
	}

	public void RegisterDistantObject(DistantObject obj)
	{
		_activeDistantObjects.Add(obj);
	}

	public void DeregisterDistantObject(DistantObject obj)
	{
		bool flag = _activeDistantObjects.Remove(obj);
	}

	public DistantEnvironmentController()
	{
		List<DistantObject> list = default;
		list._002Ector();
		_activeDistantObjects = list;
		List<DistantObjectSpawner> list2 = default;
		list2._002Ector();
		_spawnableSpawners = list2;
		base._002Ector();
	}
}
