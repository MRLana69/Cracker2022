using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Pickups;

[Serializable]
public class PickupData : ICloneable
{
	private PickupType _pickupType;

	private GameObject _pickupVisualsPrefab;

	private PickupEnabledState _pickupEnabledState;

	private SpawnPointDifficulty _spawnPointDifficulty;

	private SpawnPointHeight _spawnPointHeight;

	private SpawnDistanceMinToPreviousMode _spawnDistanceMinToPreviousMode;

	private float _spawnDistanceMinToPrevious;

	private float _spawnWeight;

	public PickupType PickupType => _pickupType;

	public GameObject PickupVisualsPrefab => _pickupVisualsPrefab;

	public PickupEnabledState PickupEnabledState
	{
		get
		{
			return _pickupEnabledState;
		}
		set
		{
			_pickupEnabledState = value;
		}
	}

	public SpawnPointDifficulty SpawnPointDifficulty => _spawnPointDifficulty;

	public SpawnPointHeight SpawnPointHeight => _spawnPointHeight;

	public SpawnDistanceMinToPreviousMode SpawnDistanceMinToPreviousMode
	{
		get
		{
			return _spawnDistanceMinToPreviousMode;
		}
		set
		{
			_spawnDistanceMinToPreviousMode = value;
		}
	}

	public float SpawnDistanceMinToPrevious => _spawnDistanceMinToPrevious;

	public float SpawnWeight
	{
		get
		{
			return _spawnWeight;
		}
		set
		{
			_spawnWeight = value;
		}
	}

	public PickupData()
		: this(PickupType.CoinMagnet, null, PickupEnabledState.Enabled, (SpawnPointHeight)0, (SpawnPointDifficulty)0, SpawnDistanceMinToPreviousMode.ResetAtRunStart, 400f)
	{
	}

	public PickupData(PickupType pickupType, GameObject pickupVisualsPrefab, PickupEnabledState pickupEnabledState, SpawnPointHeight spawnPointHeight, SpawnPointDifficulty spawnPointDifficulty, SpawnDistanceMinToPreviousMode spawnDistanceMinToPreviousMode, float spawnDistanceMinToPrevious)
	{
		_spawnDistanceMinToPrevious = 400f;
		_pickupVisualsPrefab = pickupVisualsPrefab;
		_pickupType = pickupType;
		_spawnPointHeight = spawnPointHeight;
		_pickupEnabledState = pickupEnabledState;
		_spawnDistanceMinToPrevious = spawnDistanceMinToPrevious;
		_spawnDistanceMinToPreviousMode = spawnDistanceMinToPreviousMode;
		_spawnPointDifficulty = spawnPointDifficulty;
	}

	public PickupData(PickupData other)
	{
		_spawnDistanceMinToPrevious = 400f;
		_pickupType = other._pickupType;
		_pickupVisualsPrefab = other._pickupVisualsPrefab;
		_pickupEnabledState = other._pickupEnabledState;
		_spawnPointHeight = other._spawnPointHeight;
		_spawnPointDifficulty = other._spawnPointDifficulty;
		_spawnDistanceMinToPreviousMode = other._spawnDistanceMinToPreviousMode;
		_spawnDistanceMinToPrevious = other._spawnDistanceMinToPrevious;
	}

	public object Clone()
	{
		PickupData pickupData = default;
		pickupData._002Ector(this);
		return pickupData;
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		string arg = ((!_pickupVisualsPrefab) ? _pickupVisualsPrefab.name : "NA");
		_ = _pickupType;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg2 = default;
		return $"[PickupData (PickupType={arg2},PickupIconPrefab={arg})]";
	}

	public bool IsCompatibleWithSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		bool flag = IsCompatibleWithSpawnPointZPosition(pickupSpawnPoint);
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			bool flag3 = IsCompatibleWithSpawnPointDifficulty(pickupSpawnPoint);
			bool flag4 = !flag3;
			result = false;
			if (!flag4)
			{
				bool flag5 = IsCompatibleWithSpawnPointHeight(pickupSpawnPoint);
				bool flag6 = !flag5;
				result = false;
				if (!flag6)
				{
					bool flag7 = IsCompatibleWithConstrainingBuilder(pickupSpawnPoint);
					result = flag7;
				}
			}
		}
		return result;
	}

	private bool IsCompatibleWithSpawnPointDifficulty(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0013: Expected I4, but got Obj
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool IsCompatibleWithSpawnPointHeight(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0013: Expected I4, but got Obj
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe bool IsCompatibleWithSpawnPointZPosition(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Expected VT, but got Obj
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Ref, but got Unknown
		//IL_004b: Expected Obj, but got I
		//IL_0087: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		bool result = default;
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			_ = 0;
			ref float value = ref *(float*)(obj + 12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v17 (T)+2C]");
			bool flag = ((Dictionary<int, float>)0).TryGetValue((int)_pickupType, out value);
			bool flag2 = !flag;
			result = true;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				bool flag3 = 0f == 0f;
				result = true;
				if (!flag3)
				{
					Transform transform = pickupSpawnPoint.transform;
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					float num = 0f * 0.125f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					float num2 = 0f * 0.125f;
					float num3 = num - num2;
					bool flag4 = _spawnDistanceMinToPrevious < num3;
					result = flag4;
				}
			}
		}
		return result;
	}

	private bool IsCompatibleWithConstrainingBuilder(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0062: Expected I, but got Obj
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_00dc: Expected F8, but got I
		//IL_00ed: Expected F8, but got I
		//IL_012b: Expected F8, but got I4
		//IL_013d: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 - 16;
		bool flag = _pickupType != PickupType.JetPack;
		bool result = true;
		if (!flag)
		{
			bool flag2 = pickupSpawnPoint.ContainingRoute__BackingField != null;
			bool flag3 = !flag2;
			result = true;
			if (!flag3)
			{
				Route route = pickupSpawnPoint.ContainingRoute__BackingField;
				nint num = (nint)route;
				object obj3 = route + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S1_v8 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
				int num2 = 0;
				List<IConstrainingRouteBuilder> constrainingBuilders;
				RouteBuilder routeBuilder = default;
				ConstrainingRouteBuilder constrainingRouteBuilder2 = default;
				while (true)
				{
					constrainingBuilders = routeBuilder._constrainingBuilders;
					if (num2 >= constrainingBuilders._size)
					{
						break;
					}
					IConstrainingRouteBuilder constrainingRouteBuilder = routeBuilder._constrainingBuilders.get_Item(num2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
					Transform transform = pickupSpawnPoint.transform;
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					double num3 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					double num4 = Math.Abs(0.0);
					if (!(num4 < 2147483648.0))
					{
						num3 = -2147483648.0;
					}
					if (((RouteBuilder)constrainingRouteBuilder2)._buildersBelow.Contains(routeBuilder) && constrainingRouteBuilder2.IsConstrainingStartAt((int)num3))
					{
						break;
					}
					int num5 = num2 + 1;
					num2 = num5;
				}
				bool flag4 = num2 >= constrainingBuilders._size;
				result = flag4;
			}
		}
		return result;
	}

	private void DebugLog(string message)
	{
		//IL_000e: Expected VT, but got Obj
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		}
	}
}
