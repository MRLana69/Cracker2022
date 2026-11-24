using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using SYBO.Common.StateSystem;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
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

	public PickerType PickerType
	{
		get
		{
			//IL_012d: Expected I, but got Obj
			//IL_0143: Expected Obj, but got I
			//IL_01a0: Expected Obj, but got I4
			//IL_01c8: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0185: Expected VT, but got Obj
			//IL_0185: Expected Obj, but got I4
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected Obj, but got Unknown
			//IL_00af: Expected I, but got Obj
			nint num = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v34 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
			FlyingState flyingState = ((StateMachine)useBenchmarkRoute).TryGetCurrentState<FlyingState>();
			bool flag = flyingState == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerData)+38]");
			object obj2 = (nint)0 | (nint)(flag ? 1 : 0);
			if (obj2 != null)
			{
				return PickerType.Default;
			}
			nint num3 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v29 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isRestricted = AgeRestriction.isRestricted;
			GameObject gameObject = ((Component)this).gameObject;
			Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
			object obj4 = flyingState - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			return (0 > (nint)obj4) ? PickerType.Default : ((PickerType)0);
		}
	}

	public PickerEnabledState PickerEnabledState
	{
		get
		{
			return (PickerEnabledState)_pickerType;
		}
		set
		{
			//IL_0014: Expected Obj, but got I4
			//IL_0014: Expected Obj, but got I4
			if (_pickerType != 0)
			{
				((Action<PickerRemoveRequestEventArgs>)_pickerType)((PickerRemoveRequestEventArgs)value);
			}
		}
	}

	public PickupType PickupType => (PickupType)_pickerEnabledState;

	public SpawnDistanceMinToPreviousMode SpawnDistanceMinToPreviousMode
	{
		get
		{
			return (SpawnDistanceMinToPreviousMode)_pickupType;
		}
		set
		{
			_pickerEnabledState = (PickerEnabledState)value;
		}
	}

	public float SpawnDistanceMinToPrevious
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerData)+30]");
			return 0f;
		}
	}

	public float ProbabilityToSpawn => _spawnDistanceMinToPrevious;

	public int ExecutionOrder => (int)_spawnDistanceMinToPreviousMode;

	public unsafe PickerData()
	{
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(PickerCollection._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<SYBO.Subway.Pickups.Pickers.PickerCollection+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PickerCollection._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v47 (Il2CppClass<SYBO.Subway.Pickups.Pickers.PickerCollection+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = PickerCollection._003C_003Ec._003C_003E9__10_0 == null;
		bool flag2 = !flag;
		Queue<_00210> q = (Queue<_00210>)(object)PickerCollection._003C_003Ec._003C_003E9__10_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(PickerCollection._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v21 (Il2CppClass<SYBO.Subway.Pickups.Pickers.PickerCollection+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PickerCollection._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v41 (Il2CppClass<SYBO.Subway.Pickups.Pickers.PickerCollection+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			Queue<_00210> queue = default;
			queue._array = (_00210[])num5;
			queue._size = 0;
			object obj3 = queue + 16;
			obj3 = PickerCollection._003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(PickerCollection._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v38 (Il2CppClass<SYBO.Subway.Pickups.Pickers.PickerCollection+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = queue;
			q = queue;
		}
		System.Runtime.CompilerServices.Unsafe.Write((void*)(int)_pickerEnabledState, new Queue<T>.Enumerator((Queue<T>)(object)q));
		PickerEnabledState pickerEnabledState = _pickerEnabledState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v10 (SYBO.Subway.Pickups.Pickers.PickerEnabledState)+C]");
		int num7 = 0;
		object obj5 = default;
		do
		{
			int num8 = num7 - 1;
			if (num8 >= 0)
			{
				IPicker picker = ((List<IPicker>)_pickerEnabledState).get_Item(num8);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				num7 = num8;
				continue;
			}
			break;
		}
		while (obj5 != null);
	}

	public bool IsCompatibleWithSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0014: Expected I4, but got Obj
		//IL_0014: Expected Obj, but got I4
		//IL_0018: Expected I4, but got Obj
		return (byte)(int)((List<IPicker>)_pickerEnabledState).get_Item((int)pickupSpawnPoint) != 0;
	}

	public override string ToString()
	{
		//IL_0007: Expected Obj, but got I4
		return (string)_executionOrder;
	}

	private void DebugLog(string message)
	{
		//IL_000a: Expected I4, but got Obj
		_spawnDistanceMinToPreviousMode = (SpawnDistanceMinToPreviousMode)message;
	}
}
