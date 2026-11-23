using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Characters.States;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Pickups;

public class PickupSpawnPoint : MonoBehaviour
{
	public const string PickupSpawnPointPrefabProjectPath = "Assets/Resources/Prefabs/Pickups/Refactored/PickupSpawnPoint.prefab";

	internal GameObject _pickupParent;

	internal SpawnPointMode __spawnPointMode;

	internal PickupType __forceSpawnPickupType = PickupType.PogoStick;

	internal SpawnPointDifficulty _spawnPointDifficulty;

	internal SpawnPointHeight _spawnPointHeight = SpawnPointHeight.OnGround;

	private PickupRotate _pickupRotate;

	private bool _ignoreJetpackZ;

	private PickupData _pickupData;

	internal bool __willIgnoreZPositionBeforeSpawn;

	private SpawnPointMode _spawnPointModeOriginal;

	private bool _willIgnoreZPositionBeforeSpawnOriginal;

	private PickupType _forceSpawnPickupTypeOriginal;

	private SpawnPointState __spawnPointState;

	private SpawnPointDifficulty _spawnPointDifficultyOriginal;

	private SpawnPointHeight _spawnPointHeightOriginal;

	private GameObject _spawnedPickupVisuals;

	private Collider _trigger;

	private TrackObject _trackObject;

	private List<TrackObject> _visualsTrackObjects;

	private Route ContainingRoute__BackingField;

	private Action<PickupSpawnPoint> m_OnRegistered;

	private Action<PickupSpawnPoint> m_OnDeregistered;

	private Action<PickupSpawnPoint> m_OnPickupDespawned;

	private Action<PickupSpawnPoint> m_OnPickupCollected;

	private Action<PickupSpawnPoint, PickerData> m_OnPickupSpawned;

	public SpawnPointMode SpawnPointMode
	{
		get
		{
			return __spawnPointMode;
		}
		internal set
		{
			__spawnPointMode = value;
		}
	}

	public bool WillIgnoreZPositionBeforeSpawn
	{
		get
		{
			return __willIgnoreZPositionBeforeSpawn;
		}
		internal set
		{
			__willIgnoreZPositionBeforeSpawn = value;
		}
	}

	public PickupType ForceSpawnPickupType
	{
		get
		{
			return __forceSpawnPickupType;
		}
		internal set
		{
			__forceSpawnPickupType = value;
		}
	}

	public SpawnPointState SpawnPointState
	{
		get
		{
			return __spawnPointState;
		}
		private set
		{
			__spawnPointState = value;
		}
	}

	public SpawnPointDifficulty SpawnPointDifficulty => _spawnPointDifficulty;

	public SpawnPointHeight SpawnPointHeight => _spawnPointHeight;

	public bool CanTriggerCollisionWithCharacter => __spawnPointState == SpawnPointState.Spawned;

	public Route ContainingRoute
	{
		get
		{
			return ContainingRoute__BackingField;
		}
		private set
		{
			ContainingRoute__BackingField = value;
		}
	}

	public PickupData PickupData => _pickupData;

	private bool IsAvailableAsTrackObject
	{
		get
		{
			TrackObject trackObject = _trackObject;
			return trackObject._active;
		}
	}

	public GameObject SpawnedPickupIcon => _spawnedPickupVisuals;

	private bool IsWorldPositionAcceptableBeforeSpawn
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			float num2;
			do
			{
				GameObject gameObject = base.gameObject;
				if (!(gameObject != null))
				{
					break;
				}
				Transform transform = base.transform;
				Vector3 position = transform.position;
				Character instance = Character.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				float num = 0f - instance.z;
				num2 = num * 0.125f;
			}
			while (num2 > 0f);
			return true;
		}
	}

	protected bool IsZPositionToGameStartAcceptableBeforeSpawn
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_008b: Expected VT, but got Obj
			//IL_009c: Invalid comparison between I and F4
			//IL_0038: Expected VT, but got Obj
			//IL_0065: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 - 16;
			float num;
			do
			{
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (T)+14]");
				if (!(0f > 0f))
				{
					break;
				}
				Transform transform = base.transform;
				Vector3 position = transform.position;
				_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				num = 0f * 0.125f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24 (T)+14]");
			}
			while (!(0f > num));
			return true;
		}
	}

	protected bool IsZAvailableToJetpackState
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			while (!_ignoreJetpackZ)
			{
				Game instance = Game.Instance;
				if (!instance.IsInJetpackMode)
				{
					break;
				}
				Transform transform = base.transform;
				Vector3 position = transform.position;
				JetpackState instance2 = JetpackState.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				if ((nint)0 <= (nint)instance2._targetPosZ)
				{
					break;
				}
			}
			return true;
		}
	}

	public event Action<PickupSpawnPoint> OnRegistered
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 92;
			Delegate obj2 = this.m_OnRegistered;
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
			object obj = this + 92;
			Delegate obj2 = this.m_OnRegistered;
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

	public event Action<PickupSpawnPoint> OnDeregistered
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 96;
			Delegate obj2 = this.m_OnDeregistered;
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
			object obj = this + 96;
			Delegate obj2 = this.m_OnDeregistered;
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

	public event Action<PickupSpawnPoint> OnPickupDespawned
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 100;
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
			object obj = this + 100;
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

	public event Action<PickupSpawnPoint> OnPickupCollected
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 104;
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
			object obj = this + 104;
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

	public event Action<PickupSpawnPoint, PickerData> OnPickupSpawned
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 108;
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
			object obj = this + 108;
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

	protected unsafe void Awake()
	{
		TrackObject component = GetComponent<TrackObject>();
		_trackObject = component;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(PickupSpawnPoint.TrackObject_OnActivate));
		_trackObject.OnActivate += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(PickupSpawnPoint.TrackObject_OnDeactivate));
		_trackObject.OnDeactivate += action2;
		Collider component2 = GetComponent<Collider>();
		_trigger = component2;
		_trigger.enabled = false;
		_spawnPointModeOriginal = __spawnPointMode;
		_forceSpawnPickupTypeOriginal = __forceSpawnPickupType;
		_spawnPointDifficultyOriginal = _spawnPointDifficulty;
		InitializeAllValues();
	}

	private void InitializeAllValues()
	{
		DeactivateAndDespawnChild();
		__spawnPointState = SpawnPointState.UnspawnedAndAvailable;
		__spawnPointMode = _spawnPointModeOriginal;
		__forceSpawnPickupType = _forceSpawnPickupTypeOriginal;
		bool _willIgnoreZPositionBeforeSpawn;
		if (_spawnPointModeOriginal != SpawnPointMode.WillForcePickupType)
		{
			_willIgnoreZPositionBeforeSpawn = _willIgnoreZPositionBeforeSpawnOriginal;
		}
		else
		{
			_willIgnoreZPositionBeforeSpawnOriginal = true;
			_willIgnoreZPositionBeforeSpawn = true;
		}
		__willIgnoreZPositionBeforeSpawn = _willIgnoreZPositionBeforeSpawn;
		_pickupData = null;
		_spawnPointDifficulty = _spawnPointDifficultyOriginal;
	}

	private void SetForceSpawnPickupTypeAndOriginalTo(PickupType pickupType, bool ignoreJetpackZ)
	{
		_ignoreJetpackZ = ignoreJetpackZ;
		__forceSpawnPickupType = pickupType;
		_forceSpawnPickupTypeOriginal = pickupType;
	}

	private void SetSpawnPointModeAndOriginalTo(SpawnPointMode spawnPointMode)
	{
		__spawnPointMode = spawnPointMode;
		_spawnPointModeOriginal = spawnPointMode;
	}

	private void SetWillIgnoreZPositionBeforeSpawnAndOriginalTo(bool willIgnoreZPositionBeforeSpawn)
	{
		__willIgnoreZPositionBeforeSpawn = willIgnoreZPositionBeforeSpawn;
		_willIgnoreZPositionBeforeSpawnOriginal = willIgnoreZPositionBeforeSpawn;
	}

	public void SetContainingRoute()
	{
		Route componentInParent = GetComponentInParent<Route>();
		ContainingRoute__BackingField = componentInParent;
	}

	public bool IsAvailableForSpawning(bool willShowDebugLog = false)
	{
		bool result;
		if (~(__willIgnoreZPositionBeforeSpawn ? 1u : 0u) == 0)
		{
			result = false;
			if (__spawnPointState == SpawnPointState.UnspawnedAndAvailable)
			{
				TrackObject trackObject = _trackObject;
				if (trackObject._active)
				{
					goto IL_012d;
				}
				result = false;
			}
		}
		else
		{
			result = false;
			if (__spawnPointState == SpawnPointState.UnspawnedAndAvailable)
			{
				TrackObject trackObject2 = _trackObject;
				bool flag = (byte)(~(trackObject2._active ? 1u : 0u)) != 0;
				result = false;
				if (!flag)
				{
					bool isWorldPositionAcceptableBeforeSpawn = IsWorldPositionAcceptableBeforeSpawn;
					bool flag2 = !isWorldPositionAcceptableBeforeSpawn;
					result = false;
					if (!flag2)
					{
						bool flag3 = IsDistanceToCharacterAcceptableBeforeSpawn(willShowDebugLog);
						bool flag4 = !flag3;
						result = false;
						if (!flag4)
						{
							bool isZPositionToGameStartAcceptableBeforeSpawn = IsZPositionToGameStartAcceptableBeforeSpawn;
							bool flag5 = !isZPositionToGameStartAcceptableBeforeSpawn;
							result = false;
							if (!flag5)
							{
								goto IL_012d;
							}
						}
					}
				}
			}
		}
		goto IL_0144;
		IL_012d:
		bool isZAvailableToJetpackState = IsZAvailableToJetpackState;
		result = isZAvailableToJetpackState;
		goto IL_0144;
		IL_0144:
		return result;
	}

	private bool IsStateAvailableForSpawning(bool willShowDebugLog = false)
	{
		return __spawnPointState == SpawnPointState.UnspawnedAndAvailable;
	}

	private bool IsDistanceToCharacterAcceptableBeforeSpawn(bool willShowDebugLog = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004d: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		bool flag = !(PickupManager.SpawnDistanceMinToCharacter > 0f);
		bool result = false;
		if (!flag)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Character instance = Character.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			bool flag2 = 0f < instance.z;
			result = false;
			if (!flag2)
			{
				Transform transform2 = base.transform;
				Vector3 position2 = transform2.position;
				Character instance2 = Character.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				float num = 0f - instance2.z;
				float num2 = num * 0.125f;
				bool flag3 = !(PickupManager.SpawnDistanceMinToCharacter > num2);
				result = flag3;
			}
		}
		return result;
	}

	private void Update()
	{
		if (_pickupRotate != null)
		{
			PickupRotate pickupRotate = _pickupRotate;
			if (~(pickupRotate._willRotate ? 1u : 0u) == 0)
			{
				float time = Time.time;
				pickupRotate.PhasedRotate(time);
			}
		}
	}

	public void SetSpawnPointForced(PickupType pickupType, SpawnPointDifficulty spawnPointDifficulty, bool willOffsetYPosition, bool willIgnoreZPositionBeforeSpawn, bool willIgnoreJetpackZ)
	{
		_ignoreJetpackZ = false;
		InitializeAllValues();
		__willIgnoreZPositionBeforeSpawn = willIgnoreZPositionBeforeSpawn;
		_willIgnoreZPositionBeforeSpawnOriginal = willIgnoreZPositionBeforeSpawn;
		__spawnPointMode = SpawnPointMode.WillForcePickupType;
		_spawnPointModeOriginal = SpawnPointMode.WillForcePickupType;
		_ignoreJetpackZ = willIgnoreJetpackZ;
		__forceSpawnPickupType = pickupType;
		_forceSpawnPickupTypeOriginal = pickupType;
		_trackObject.Activate();
	}

	public void Register()
	{
		Action<PickupSpawnPoint> onRegistered = this.m_OnRegistered;
		if (this.m_OnRegistered != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<SYBO.Subway.Pickups.PickupSpawnPoint>)+C] (should have been resolved before IL gen)");
		}
	}

	public void Deregister()
	{
		DeactivateAndDespawnChild();
		Action<PickupSpawnPoint> onDeregistered = this.m_OnDeregistered;
		if (this.m_OnDeregistered != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<SYBO.Subway.Pickups.PickupSpawnPoint>)+C] (should have been resolved before IL gen)");
		}
	}

	public void SpawnPickup(PickupData pickupData, PickerData pickerData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0041: Expected VT, but got Obj
		//IL_00ef: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0122: Expected Obj, but got VT
		//IL_01b4: Expected I, but got Obj
		//IL_01d6: Expected I4, but got Obj
		//IL_01fd: Expected Obj, but got I
		//IL_020b: Expected Obj, but got VT
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected VT, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected VT, but got Unknown
		//IL_0135: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0172: Expected Obj, but got VT
		//IL_0190: Expected VT, but got Obj
		//IL_0080: Expected Obj, but got VT
		object obj = default;
		PickupManager pickupManager = (PickupManager)(obj - 80);
		if (IsAvailableForSpawning())
		{
			_trigger.enabled = true;
			_pickupData = pickupData;
			__spawnPointState = SpawnPointState.Spawned;
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Transform transformToSpawn = pickupData._pickupVisualsPrefab.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v12 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			PickupManager pickupManager2 = pickupManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			pickupManager2.OnPickerRemoved = (Action<PickerRemovedEventArgs>)0;
			pickupManager.OnPickupSpawnPointRegistered = (Action<PickupSpawnPoint>)Vector3.zeroVector;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v34 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			pickupManager._delayBeforeUpdatingPickerCollectionCount = (int)pickupManager.OnPickerRemoved;
			pickupManager._pickupSpawnPoints = (List<PickupSpawnPoint>)(object)pickupManager.OnPickupSpawnPointRegistered;
			PickupManager pickupManager3 = pickupManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v35 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			pickupManager3._pickupData = (PickupData[])0;
			pickupManager._pickupSpawnPointPrefab = (GameObject)Quaternion.identityQuaternion;
			Vector3 position = (Vector3)(pickupManager + 32);
			Quaternion rotation = (Quaternion)(pickupManager + 16);
			GameObject spawnedPickupVisuals = pickupManager.Spawn(transformToSpawn, position, rotation);
			_spawnedPickupVisuals = spawnedPickupVisuals;
			Transform childTransform = _spawnedPickupVisuals.transform;
			Transform parentTransform = _pickupParent.transform;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v52 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			PickupManager pickupManager4 = pickupManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v53 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			pickupManager4.OnPickupDespawned = (EventHandler<PickupManager.PickupEventArgs>)0;
			_ = pickupManager.OnPickupDespawned;
			pickupManager.PickerLastSpawnZPosition = (Dictionary<int, float>)Vector3.zeroVector;
			pickupManager = (PickupManager)(object)pickupManager.PickerLastSpawnZPosition;
			HierarchyUtility.Reparent(childTransform, parentTransform, (Vector3)pickupManager);
			SpawnExistingPlaceholders();
			_trackObject.Hack_PropagateActivationStateToChildrenImmediately();
			_0021_00210 componentInChildren = (_0021_00210)_spawnedPickupVisuals.GetComponentInChildren<T>(true);
			_pickupRotate = (PickupRotate)componentInChildren;
			Action<PickupSpawnPoint, PickerData> onPickupSpawned = this.m_OnPickupSpawned;
			if (this.m_OnPickupSpawned != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ S0_v65 (System.Action`2<SYBO.Subway.Pickups.PickupSpawnPoint, SYBO.Subway.Pickups.Pickers.PickerData>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void SpawnExistingPlaceholders()
	{
		//IL_0026: Expected I, but got Obj
		PlaceholderLifecycle component = _spawnedPickupVisuals.GetComponent<PlaceholderLifecycle>();
		if (component != null)
		{
			nint num = (nint)component;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S1_v7 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+DC] (should have been resolved before IL gen)");
			if (!component._placeholder.HasSpawnedInstances)
			{
				component.Spawn();
			}
		}
	}

	private void DeactivateAndDespawnChild()
	{
		DeactivateChild();
		DespawnChild();
	}

	private void DeactivateChild()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (!(_spawnedPickupVisuals != null))
		{
			return;
		}
		bool flag = _visualsTrackObjects == null;
		bool flag2 = !flag;
		List<_0021_00210> visualsTrackObjects = (List<_0021_00210>)(object)_visualsTrackObjects;
		if (!flag2)
		{
			List<TrackObject> list = default;
			list._002Ector(1);
			_visualsTrackObjects = list;
			visualsTrackObjects = (List<_0021_00210>)(object)_visualsTrackObjects;
		}
		_spawnedPickupVisuals.GetComponentsInChildren<T>(true, (List<T>)(object)visualsTrackObjects);
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
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_01b1;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj7 != obj8;
			object obj9 = obj10;
			if (flag3)
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
				goto IL_01b1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj9 = obj11;
			break;
			IL_01b1:
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B900");
			((List<T>)(object)_visualsTrackObjects).Clear();
			return;
		}
		_ = 0;
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private void DespawnChild()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		if (_spawnedPickupVisuals != null)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			object obj = this + 72;
			Transform transformToDespawn = ((GameObject)obj).transform;
			((PickupManager)this).Despawn(transformToDespawn);
			obj = 0;
		}
		__spawnPointState = SpawnPointState.Despawned;
		Action<PickupSpawnPoint> onPickupDespawned = this.m_OnPickupDespawned;
		if (this.m_OnPickupDespawned != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S0_v14 (System.Action`1<SYBO.Subway.Pickups.PickupSpawnPoint>)+C] (should have been resolved before IL gen)");
		}
	}

	public void MarkAsUnavailable()
	{
		if (__spawnPointState == SpawnPointState.UnspawnedAndAvailable)
		{
			__spawnPointState = SpawnPointState.UnspawnedAndUnavailable;
		}
	}

	private void DebugLog(string message)
	{
		//IL_000e: Expected VT, but got Obj
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		}
	}

	private void TrackObject_OnActivate()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0018: Expected Obj, but got VT
		InitializeAllValues();
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((PickupManager)val).RegisterPickupSpawnPoint(this);
		}
	}

	private void TrackObject_OnDeactivate()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0018: Expected Obj, but got VT
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((PickupManager)val).DeregisterPickupSpawnPoint(this);
		}
	}

	public void TriggerCollisionWithCharacter(CharacterPickupParticles characterPickupParticles)
	{
		if (__spawnPointState != SpawnPointState.SpawnedAndCollected)
		{
			__spawnPointState = SpawnPointState.SpawnedAndCollected;
			_trigger.enabled = false;
			characterPickupParticles.PickedUpPowerUp();
			Action<PickupSpawnPoint> onPickupCollected = this.m_OnPickupCollected;
			if (this.m_OnPickupCollected != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S0_v10 (System.Action`1<SYBO.Subway.Pickups.PickupSpawnPoint>)+C] (should have been resolved before IL gen)");
			}
			DeactivateAndDespawnChild();
		}
	}

	public PickupSpawnPoint()
	{
		//IL_001a: Expected I4, but got I8
	}
}
