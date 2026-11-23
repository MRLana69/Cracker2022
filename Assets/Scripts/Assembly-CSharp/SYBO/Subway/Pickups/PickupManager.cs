using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters.States;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Pickups;

public class PickupManager : SingletonMonobehavior<PickupManager>
{
	private enum ReasonToResetHistory
	{
		SESSION_STARTED,
		GAME_STARTED,
		RUN_STARTED
	}

	public class PickupEventArgs(PickupSpawnPoint spawnPoint, PickupData pickupData, SpawnPointMode spawnPointMode) : EventArgs
	{
		public readonly PickupSpawnPoint SpawnPoint = spawnPoint;

		public readonly PickupData PickupData = pickupData;

		public readonly SpawnPointMode SpawnPointMode = spawnPointMode;
	}

	private const int PickerTypeShortNameLength = 8;

	private const int PickupTypeShortNameLength = 9;

	private const int DelayBeforeUpdatingPickerCollectionCountMax = 60;

	public static readonly float SpawnDistanceMinToCharacter = 112.5f;

	private bool _willDebugLogPickers;

	private bool _willDebugLogPickupData;

	internal GameObject _pickupSpawnPointPrefab;

	private float _spawnDistanceMinToGameStart = 360f;

	internal PickupData[] _pickupData;

	public PickerData[] _pickerData;

	private List<PickupSpawnPoint> _pickupSpawnPoints;

	internal PickerCollection _pickerCollection;

	private int _delayBeforeUpdatingPickerCollectionCount;

	public readonly Dictionary<int, float> PickupLastSpawnZPosition;

	public readonly Dictionary<int, float> PickerLastSpawnZPosition;

	private static Comparison<PickupSpawnPoint> _003C_003Ef__mg_0024cache0;

	private EventHandler<PickupEventArgs> m_OnPickupSpawned;

	private EventHandler<PickupEventArgs> m_OnPickupDespawned;

	private EventHandler<PickupEventArgs> m_OnPickupCollected;

	private Action<PickupSpawnPoint> m_OnPickupSpawnPointRegistered;

	private Action<PickupSpawnPoint> m_OnPickupSpawnPointDeregistered;

	private Action<PickerRemovedEventArgs> m_OnPickerRemoved;

	public float SpawnDistanceMinToGameStart => _spawnDistanceMinToGameStart;

	internal List<PickupSpawnPoint> PickupSpawnPointList => _pickupSpawnPoints;

	public bool WillDebugLogPickers => _willDebugLogPickers;

	public bool WillDebugLogPickupData => _willDebugLogPickupData;

	public event EventHandler<PickupEventArgs> OnPickupSpawned
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_OnPickupSpawned;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_OnPickupSpawned;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event EventHandler<PickupEventArgs> OnPickupDespawned
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_OnPickupDespawned;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_OnPickupDespawned;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event EventHandler<PickupEventArgs> OnPickupCollected
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 60;
			Delegate obj2 = this.m_OnPickupCollected;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 60;
			Delegate obj2 = this.m_OnPickupCollected;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<PickupSpawnPoint> OnPickupSpawnPointRegistered
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this - -64;
			Delegate obj2 = this.m_OnPickupSpawnPointRegistered;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this - -64;
			Delegate obj2 = this.m_OnPickupSpawnPointRegistered;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<PickupSpawnPoint> OnPickupSpawnPointDeregistered
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 68;
			Delegate obj2 = this.m_OnPickupSpawnPointDeregistered;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 68;
			Delegate obj2 = this.m_OnPickupSpawnPointDeregistered;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<PickerRemovedEventArgs> OnPickerRemoved
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 72;
			Delegate obj2 = this.m_OnPickerRemoved;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 72;
			Delegate obj2 = this.m_OnPickerRemoved;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	protected override void Initialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
		ResetPickupAndPickerLastPositions(ReasonToResetHistory.SESSION_STARTED);
		List<PickupSpawnPoint> list = default;
		list._002Ector();
		_pickupSpawnPoints = list;
		PickerCollection pickerCollection = default;
		pickerCollection._002Ector(this);
		_pickerCollection = pickerCollection;
		throw new ArgumentException();
	}

	protected void OnDestroy()
	{
		if (_pickerCollection != null)
		{
			throw new ArgumentException();
		}
	}

	protected void FixedUpdate()
	{
		if (!Game.IsInstantiated)
		{
			return;
		}
		Game instance = Game.Instance;
		Variable<bool> isInGame = instance.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			Game instance2 = Game.Instance;
			if (!instance2._isPaused)
			{
				UpdatePickerCollection(isForcedUpdate: false);
			}
		}
	}

	public PickupData GetPickupDataForPickupType(PickupType pickupType)
	{
		//IL_0035: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I
		if (_pickupData == null)
		{
			return null;
		}
		object obj = 0;
		PickupData[] pickupData = _pickupData;
		while (pickupData.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)pickupData + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v4+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v5+8]");
			if ((nint)pickupType == 0)
			{
				object obj5 = obj << 2;
				object obj6 = (object)_pickupData + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v18+10]");
				return (PickupData)0;
			}
			object obj7 = obj + 1;
			obj = obj7;
			pickupData = _pickupData;
		}
		return null;
	}

	public bool HasPickupDataForPickupType(PickupType pickupType)
	{
		PickupData pickupDataForPickupType = GetPickupDataForPickupType(pickupType);
		return pickupDataForPickupType != null;
	}

	internal PickerData GetPickerDataForPickerType(PickerType pickerType)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		object obj = 0;
		PickerData result;
		while (true)
		{
			PickerData[] pickerData = _pickerData;
			if (pickerData.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)pickerData + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11+10]");
				PickerData pickerData2 = (PickerData)0;
				bool flag = pickerData2._pickerType == pickerType;
				result = pickerData2;
				if (flag)
				{
					break;
				}
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			result = null;
			break;
		}
		return result;
	}

	private void UpdatePickerCollection(bool isForcedUpdate)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		int num;
		if (!isForcedUpdate)
		{
			num = _delayBeforeUpdatingPickerCollectionCount;
		}
		else
		{
			_delayBeforeUpdatingPickerCollectionCount = 60;
			num = 60;
		}
		if ((_delayBeforeUpdatingPickerCollectionCount = num + 1) < 60)
		{
			return;
		}
		_delayBeforeUpdatingPickerCollectionCount = 0;
		_pickerCollection.UpdatePickers();
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					goto IL_0262;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj7 == null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0262;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_0262:
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C55");
			return;
		}
		_ = 0;
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public void UpdatePickerCollectionForced()
	{
		UpdatePickerCollection(isForcedUpdate: true);
	}

	public void SetPickerState(PickerType pickerType, PickerEnabledState state)
	{
		PickerData pickerDataForPickerType = GetPickerDataForPickerType(pickerType);
		pickerDataForPickerType._pickerEnabledState = state;
	}

	public void RegisterPickupSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		if (!_pickupSpawnPoints.Contains(pickupSpawnPoint))
		{
			pickupSpawnPoint.SetContainingRoute();
			_pickupSpawnPoints.Add(pickupSpawnPoint);
			throw new ArgumentException();
		}
	}

	public void DeregisterPickupSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		if (_pickupSpawnPoints.Contains(pickupSpawnPoint))
		{
			bool flag = _pickupSpawnPoints.Remove(pickupSpawnPoint);
		}
		pickupSpawnPoint.Deregister();
	}

	public GameObject SpawnPickupSpawnPoint()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Expected I, but got Obj
		//IL_0063: Expected Obj, but got VT
		//IL_0076: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got VT
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected VT, but got Unknown
		//IL_00e3: Expected VT, but got Obj
		object obj = default;
		PickupManager pickupManager = (PickupManager)(obj - 48);
		Transform transformToSpawn = _pickupSpawnPointPrefab.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		PickupManager pickupManager2 = pickupManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v6 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		pickupManager2._delayBeforeUpdatingPickerCollectionCount = 0;
		pickupManager._pickupSpawnPoints = (List<PickupSpawnPoint>)Vector3.zeroVector;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		pickupManager._pickupData = (PickupData[])pickupManager._delayBeforeUpdatingPickerCollectionCount;
		pickupManager._pickupSpawnPointPrefab = (GameObject)(object)pickupManager._pickupSpawnPoints;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		pickupManager = (PickupManager)Quaternion.identityQuaternion;
		Vector3 position = (Vector3)(pickupManager + 16);
		return pickupManager.Spawn(transformToSpawn, position, (Quaternion)pickupManager);
	}

	public void Despawn(Transform transformToDespawn)
	{
		PoolManager.Despawn(transformToDespawn);
	}

	public bool IsSpawned(Transform transformToDespawn)
	{
		return PoolManager.GetInstanceData(transformToDespawn)?.inUse ?? false;
	}

	public GameObject Spawn(Transform transformToSpawn, Vector3 position, Quaternion rotation)
	{
		Transform transform = PoolManager.Spawn(transformToSpawn);
		return transform.gameObject;
	}

	private void ResetPickupAndPickerLastPositions(ReasonToResetHistory reasonToResetHistory)
	{
		ResetPickupLastSpawnPositions(reasonToResetHistory);
		ResetPickerLastSpawnPositions(reasonToResetHistory);
	}

	private void ResetPickupLastSpawnPositions(ReasonToResetHistory reasonToResetHistory)
	{
		//IL_00f4: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		PickupData[] pickupData = _pickupData;
		object obj = reasonToResetHistory - 1;
		object obj7;
		for (object obj2 = 0; pickupData.Length > (nint)obj2; obj7 = obj2 + 1, obj2 = obj7)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)pickupData + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15+10]");
			object obj5 = 0;
			if (obj != null)
			{
				if ((nint)obj != 1)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16+1C]");
				if ((nint)0 != 0)
				{
					continue;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16+1C]");
				if ((nint)0 != 1)
				{
					continue;
				}
			}
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S5_v6+4] (should have been resolved before IL gen)");
		}
	}

	private void ResetPickerLastSpawnPositions(ReasonToResetHistory reasonToResetHistory)
	{
		//IL_00f4: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		PickerData[] pickerData = _pickerData;
		object obj = reasonToResetHistory - 1;
		object obj7;
		for (object obj2 = 0; pickerData.Length > (nint)obj2; obj7 = obj2 + 1, obj2 = obj7)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)pickerData + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15+10]");
			object obj5 = 0;
			if (obj != null)
			{
				if ((nint)obj != 1)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16+14]");
				if ((nint)0 != 0)
				{
					continue;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16+14]");
				if ((nint)0 != 1)
				{
					continue;
				}
			}
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S5_v6+4] (should have been resolved before IL gen)");
		}
	}

	public void Game_OnGameStarted()
	{
		ResetPickupAndPickerLastPositions(ReasonToResetHistory.GAME_STARTED);
	}

	public void Game_OnRunStarted(bool wasPlayerRevived)
	{
		ResetPickupAndPickerLastPositions(ReasonToResetHistory.RUN_STARTED);
	}

	private void PickerCollection_OnPickerRemoveRequest(PickerRemoveRequestEventArgs pickerRemoveRequestEvent)
	{
		_pickerCollection.Remove(pickerRemoveRequestEvent.IPicker__BackingField);
		Action<PickerRemovedEventArgs> onPickerRemoved = this.m_OnPickerRemoved;
		if (this.m_OnPickerRemoved != null)
		{
			_ = pickerRemoveRequestEvent.IPicker__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S0_v8 (System.Action`1<SYBO.Subway.Pickups.Pickers.PickerRemovedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private void PickupSpawnPoint_OnPickupSpawned(PickupSpawnPoint pickupSpawnPoint, PickerData pickerData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_0140: Expected VT, but got Obj
		//IL_0150: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		PickupData pickupData = pickupSpawnPoint._pickupData;
		if (pickupData._spawnDistanceMinToPrevious > 0f)
		{
			Transform transform = pickupSpawnPoint.transform;
			Vector3 position = transform.position;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S5_v10 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+5C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S5_v11+4] (should have been resolved before IL gen)");
		}
		if (pickupSpawnPoint.__spawnPointMode != SpawnPointMode.WillForcePickupType && pickerData._spawnDistanceMinToPrevious > 0f)
		{
			Transform transform2 = pickupSpawnPoint.transform;
			Vector3 position2 = transform2.position;
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v183 @ S5_v6+4] (should have been resolved before IL gen)");
		}
		PickupData pickupData2 = pickupSpawnPoint._pickupData;
		if (pickupSpawnPoint._pickupData != null && pickupData2._pickupType == PickupType.JetPack)
		{
			bool flag = pickupSpawnPoint.ContainingRoute__BackingField == null;
			bool flag2 = !flag;
			UnityEngine.Object obj5 = pickupSpawnPoint.ContainingRoute__BackingField;
			if (!flag2)
			{
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v56 (T)+3C]");
				obj5 = (UnityEngine.Object)0;
			}
			if (obj5 != null)
			{
				nint num5 = (nint)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
				Transform transform3 = pickupSpawnPoint.transform;
				Vector3 position3 = transform3.position;
				JetpackState instance = JetpackState.Instance;
				float flightDistanceJetpack = instance.GetFlightDistanceJetpack();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				float z = 0f + flightDistanceJetpack;
				RouteBuilder routeBuilder = default;
				routeBuilder.SetMaxBuildLimitZ(z, pickupSpawnPoint);
			}
		}
		if (this.m_OnPickupSpawned != null)
		{
			PickupEventArgs e = default;
			e._002Ector(pickupSpawnPoint, pickupSpawnPoint._pickupData, pickupSpawnPoint.__spawnPointMode);
			EventHandler<PickupEventArgs> onPickupSpawned = this.m_OnPickupSpawned;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ S0_v33 (System.EventHandler`1<SYBO.Subway.Pickups.PickupManager+PickupEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private void PickupSpawnPoint_OnPickupCollected(PickupSpawnPoint pickupSpawnPoint)
	{
		if (this.m_OnPickupCollected != null)
		{
			PickupEventArgs e = default;
			e._002Ector(pickupSpawnPoint, pickupSpawnPoint._pickupData, pickupSpawnPoint.__spawnPointMode);
			EventHandler<PickupEventArgs> onPickupCollected = this.m_OnPickupCollected;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S0_v16 (System.EventHandler`1<SYBO.Subway.Pickups.PickupManager+PickupEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private void PickupSpawnPoint_OnPickupDespawned(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0071: Expected VT, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		PickupData pickupData = pickupSpawnPoint._pickupData;
		if (pickupSpawnPoint._pickupData != null && pickupData._pickupType == PickupType.JetPack)
		{
			bool flag = pickupSpawnPoint.ContainingRoute__BackingField == null;
			bool flag2 = !flag;
			UnityEngine.Object obj = pickupSpawnPoint.ContainingRoute__BackingField;
			if (!flag2)
			{
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v41 (T)+3C]");
				obj = (UnityEngine.Object)0;
			}
			if (obj != null)
			{
				nint num = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
				RouteBuilder routeBuilder = default;
				routeBuilder.SetMaxBuildLimitZ(-1f, pickupSpawnPoint);
			}
		}
		if (this.m_OnPickupDespawned != null)
		{
			PickupEventArgs e = default;
			e._002Ector(pickupSpawnPoint, pickupSpawnPoint._pickupData, pickupSpawnPoint.__spawnPointMode);
			EventHandler<PickupEventArgs> onPickupDespawned = this.m_OnPickupDespawned;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S0_v20 (System.EventHandler`1<SYBO.Subway.Pickups.PickupManager+PickupEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private void PickupSpawnPoint_OnRegistered(PickupSpawnPoint pickupSpawnPoint)
	{
		Action<PickupSpawnPoint> onPickupSpawnPointRegistered = this.m_OnPickupSpawnPointRegistered;
		if (this.m_OnPickupSpawnPointRegistered != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<SYBO.Subway.Pickups.PickupSpawnPoint>)+C] (should have been resolved before IL gen)");
		}
	}

	private void PickupSpawnPoint_OnDeregistered(PickupSpawnPoint pickupSpawnPoint)
	{
		throw new ArgumentException();
	}

	private unsafe static int SortSpawnPointsClosestFirst(PickupSpawnPoint left, PickupSpawnPoint right)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0027: Expected native int or pointer, but got F4
		//IL_0066: Expected F4, but got I
		//IL_0061: Expected native int or pointer, but got F4
		//IL_009f: Expected F4, but got I
		//IL_009f: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 32;
		float num = (float)obj + 24f;
		((float*)(nint)num)->m_value = 0f;
		_ = 0;
		Transform transform = left.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		((float*)(nint)num)->m_value = 0f;
		Transform transform2 = right.transform;
		Vector3 position2 = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		return ((float*)num)->CompareTo(0f);
	}

	public PickupManager()
	{
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, float> pickupLastSpawnZPosition = default;
		PickupLastSpawnZPosition = pickupLastSpawnZPosition;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Single>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, float> pickerLastSpawnZPosition = default;
		PickerLastSpawnZPosition = pickerLastSpawnZPosition;
		base._002Ector();
	}
}
