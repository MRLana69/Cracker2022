using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities.Flags;
using UnityEngine;

namespace SYBO.Subway.Pickups.Pickers;

[Serializable]
public class PickerData
{
	internal PickerType _pickerType;

	private PickerEnabledState _pickerEnabledState;

	internal PickupType _pickupType;

	private SpawnDistanceMinToPreviousMode _spawnDistanceMinToPreviousMode;

	private float _spawnDistanceMinToPrevious;

	internal float _probabilityToSpawn;

	protected int _executionOrder;

	public PickerType PickerType => _pickerType;

	public PickerEnabledState PickerEnabledState
	{
		get
		{
			return _pickerEnabledState;
		}
		set
		{
			_pickerEnabledState = value;
		}
	}

	public PickupType PickupType => _pickupType;

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

	public float ProbabilityToSpawn => _probabilityToSpawn;

	public int ExecutionOrder => _executionOrder;

	public unsafe PickerData()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		FlagsHelper.SetEverything<T>(ref *(T*)(this + 16));
		_probabilityToSpawn = 1f;
		_spawnDistanceMinToPreviousMode = SpawnDistanceMinToPreviousMode.ResetAtRunStart;
		_pickerType = PickerType.Default;
	}

	public unsafe bool IsCompatibleWithSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v17 (T)+30]");
			bool flag = ((Dictionary<int, float>)0).TryGetValue((int)_pickerType, out value);
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

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = _pickerType;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = _pickupType;
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		return $"[PickerData: PickerType={arg}, PickupType={arg2}]";
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
