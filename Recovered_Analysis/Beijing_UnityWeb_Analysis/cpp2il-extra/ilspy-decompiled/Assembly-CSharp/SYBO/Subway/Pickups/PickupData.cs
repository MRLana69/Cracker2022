using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Info;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Level;
using SYBO.Subway.Placeholders;
using SYBO.Subway.Placeholders.Lifecycles;
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

	public PickupType PickupType
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			return (PickupType)_spawnPointDifficulty;
		}
	}

	public GameObject PickupVisualsPrefab
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (GameObject)_pickupType;
		}
	}

	public PickupEnabledState PickupEnabledState
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (PickupEnabledState)_pickupVisualsPrefab;
		}
		set
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected Obj, but got Unknown
			//IL_0038: Expected Obj, but got I
			//IL_0092: Expected F4, but got I
			_spawnDistanceMinToPrevious = 400f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (SYBO.Subway.Pickups.PickupEnabledState)+8]");
			_pickupType = (PickupType)0;
			object obj = this + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (SYBO.Subway.Pickups.PickupEnabledState)+C]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (SYBO.Subway.Pickups.PickupEnabledState)+10]");
			_pickupEnabledState = PickupEnabledState.Enabled;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (SYBO.Subway.Pickups.PickupEnabledState)+18]");
			_spawnPointHeight = (SpawnPointHeight)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (SYBO.Subway.Pickups.PickupEnabledState)+14]");
			_spawnPointDifficulty = (SpawnPointDifficulty)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (SYBO.Subway.Pickups.PickupEnabledState)+1C]");
			_spawnDistanceMinToPreviousMode = SpawnDistanceMinToPreviousMode.ResetAtRunStart;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (SYBO.Subway.Pickups.PickupEnabledState)+20]");
			_spawnDistanceMinToPrevious = 0f;
		}
	}

	public SpawnPointDifficulty SpawnPointDifficulty => (SpawnPointDifficulty)_pickupEnabledState;

	public SpawnPointHeight SpawnPointHeight => (SpawnPointHeight)_spawnPointDifficulty;

	public SpawnDistanceMinToPreviousMode SpawnDistanceMinToPreviousMode
	{
		get
		{
			return (SpawnDistanceMinToPreviousMode)_spawnPointHeight;
		}
		set
		{
			_pickupEnabledState = (PickupEnabledState)value;
		}
	}

	public float SpawnDistanceMinToPrevious
	{
		get
		{
			//IL_0007: Expected F4, but got I4
			return (float)_spawnDistanceMinToPreviousMode;
		}
	}

	public float SpawnWeight
	{
		get
		{
			return _spawnDistanceMinToPrevious;
		}
		set
		{
			//IL_0093: Expected Obj, but got I
			//IL_001b: Expected Obj, but got I
			//IL_002d: Expected I4, but got Obj
			//IL_0069: Expected Obj, but got I
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupData)+74]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v8+C]");
				if ((nint)0 > (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupData)+74]");
					RouteChunk routeChunk = ((List<RouteChunk>)0).get_Item(0);
					IEnumerator enumerator = ((Character)this).ChangeTrackCoroutine((int)routeChunk, value);
					if (enumerator != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupData)+74]");
						RouteChunk sender = ((List<RouteChunk>)0).get_Item(0);
						((RouteBuilder)this).RouteBuilder_OnCompletedLayingSections((object)sender, (EventArgs)null);
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	public PickupData()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public PickupData(PickupType pickupType, GameObject pickupVisualsPrefab, PickupEnabledState pickupEnabledState, SpawnPointHeight spawnPointHeight, SpawnPointDifficulty spawnPointDifficulty, SpawnDistanceMinToPreviousMode spawnDistanceMinToPreviousMode, float spawnDistanceMinToPrevious)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public PickupData(PickupData other)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		((ModelSelectionPlaceholderLifecycle)this).GetSpawnedObjects((List<Selector>)(object)other);
		if (other != null)
		{
			object meshGroup = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupData)+30]");
			((MeshContainer)0).AddMeshGroupCombinedCallback((CombineableMeshGroup)meshGroup, (Action<ModelInfo>)(object)other);
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v3 (Il2CppMethodInfo)+18]");
			object obj = (object)((object)0 & 0x7FF) + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36 @ S5_v5 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v12+C]");
			object obj2 = 0;
			object obj5 = default;
			while (true)
			{
				object obj3 = obj2 - 1;
				if ((nint)obj3 < 0)
				{
					break;
				}
				object obj4 = obj5 + 16;
				object obj6 = obj3 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj5 + 16;
				object obj9 = obj3 << 2;
				object obj10 = obj8 + obj9;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v26+14]");
				if ((nint)0 != 0)
				{
					((TrackObject)obj7)._002Ector();
				}
				else
				{
					Placeholder component = ((Component)obj7).GetComponent<Placeholder>();
					component.Activate();
				}
				obj2 = obj3;
			}
			((PlaceholderLifecycle)this).Activate();
		}
		_ = 0;
	}

	public object Clone()
	{
		//IL_0007: Expected Obj, but got I4
		return _spawnDistanceMinToPreviousMode;
	}

	public override string ToString()
	{
		//IL_0019: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PickupData pickupData = default;
		pickupData.PickupEnabledState = (PickupEnabledState)this;
		return (string)(object)pickupData;
	}

	public bool IsCompatibleWithSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 20;
		obj2 = pickupSpawnPoint;
		return flag;
	}

	private bool IsCompatibleWithSpawnPointDifficulty(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_007f: Expected I4, but got Obj
		//IL_008b: Expected I4, but got Obj
		if (IsCompatibleWithConstrainingBuilder(pickupSpawnPoint))
		{
			if (IsCompatibleWithSpawnPointHeight(pickupSpawnPoint))
			{
				if (IsCompatibleWithSpawnPointZPosition(pickupSpawnPoint))
				{
					PickupData pickupDataForPickupType = ((PickupManager)this).GetPickupDataForPickupType((PickupType)pickupSpawnPoint);
					return (byte)(int)pickupDataForPickupType != 0;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private bool IsCompatibleWithSpawnPointHeight(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_001d: Expected I4, but got VT
		return (byte)(int)Enumerable.ElementAt<TSource>((IEnumerable<TSource>)_spawnPointDifficulty, (int)pickupSpawnPoint._spawnPointDifficulty) != 0;
	}

	private bool IsCompatibleWithSpawnPointZPosition(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_001d: Expected I4, but got VT
		return (byte)(int)Enumerable.ElementAt<TSource>((IEnumerable<TSource>)_spawnPointHeight, (int)pickupSpawnPoint._spawnPointHeight) != 0;
	}

	private unsafe bool IsCompatibleWithConstrainingBuilder(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Ref, but got Unknown
		//IL_01dc: Expected Ref, but got F4
		//IL_000e: Expected VT, but got Obj
		//IL_0017: Expected Ref, but got F4
		//IL_0032: Expected Obj, but got I
		//IL_0092: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_0221: Expected I, but got Obj
		//IL_0237: Expected Obj, but got I
		//IL_0281: Expected VT, but got Obj
		//IL_0281: Expected Obj, but got I4
		//IL_00d3: Expected I, but got Obj
		//IL_0120: Expected I, but got Obj
		object obj = default;
		ref float reference = ref *(float*)(obj + 12);
		reference = ref *(float*)0f;
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			reference = ref *(float*)0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v17 (T)+48]");
			if (((Dictionary<int, float>)0).TryGetValue((int)_pickupType, out reference))
			{
				if (reference != 0f)
				{
					nint num = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v47 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num3 = reference * 0.125f;
					nint num4 = (nint)typeof(GamePositionRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v35 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num5 = (nint)typeof(GamePositionRoot);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v43 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isRestricted = AgeRestriction.isRestricted;
					GameObject gameObject = pickupSpawnPoint.gameObject;
					Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					float num6 = 0f * 0.125f;
					float num7 = num6 - num3;
					return _spawnDistanceMinToPrevious < num7;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	private void DebugLog(string message)
	{
		//IL_000a: Expected I4, but got Obj
		_spawnDistanceMinToPreviousMode = (SpawnDistanceMinToPreviousMode)message;
	}
}
