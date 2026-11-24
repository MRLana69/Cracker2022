using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Utility;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups.Picker.Pickers;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Placeholders;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.Utilities;
using UnityEngine;
using WeeklyHunt;

namespace SYBO.Subway.Pickups;

public class PickupSpawnPoint : MonoBehaviour
{
	public const string PickupSpawnPointPrefabProjectPath = "Assets/Resources/Prefabs/Pickups/Refactored/PickupSpawnPoint.prefab";

	private Action<PickupSpawnPoint> m_OnRegistered;

	private Action<PickupSpawnPoint> m_OnDeregistered;

	private Action<PickupSpawnPoint> m_OnPickupDespawned;

	private Action<PickupSpawnPoint> m_OnPickupCollected;

	private Action<PickupSpawnPoint, PickerData> m_OnPickupSpawned;

	internal GameObject _pickupParent;

	internal SpawnPointMode __spawnPointMode;

	internal PickupType __forceSpawnPickupType;

	internal SpawnPointDifficulty _spawnPointDifficulty;

	internal SpawnPointHeight _spawnPointHeight;

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

	public SpawnPointMode SpawnPointMode
	{
		get
		{
			return (__forceSpawnPickupType != 0) ? SpawnPointMode.WillForcePickupType : SpawnPointMode.Normal;
		}
		internal set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupSpawned;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public bool WillIgnoreZPositionBeforeSpawn
	{
		get
		{
			return (byte)__spawnPointMode != 0;
		}
		internal set
		{
			__spawnPointMode = (value ? SpawnPointMode.WillForcePickupType : SpawnPointMode.Normal);
		}
	}

	public PickupType ForceSpawnPickupType
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this - -64;
			return (obj != null) ? PickupType.Key : ((PickupType)0);
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0019: Expected Obj, but got I4
			object obj = this - -64;
			object obj2 = value & PickupType.Key;
			obj = obj2;
		}
	}

	public SpawnPointState SpawnPointState
	{
		get
		{
			return (SpawnPointState)__forceSpawnPickupType;
		}
		private set
		{
			__forceSpawnPickupType = (PickupType)value;
		}
	}

	public SpawnPointDifficulty SpawnPointDifficulty => (SpawnPointDifficulty)__spawnPointState;

	public SpawnPointHeight SpawnPointHeight => (SpawnPointHeight)_spawnPointDifficulty;

	public bool CanTriggerCollisionWithCharacter => (byte)_spawnPointHeight != 0;

	public Route ContainingRoute
	{
		get
		{
			//IL_0016: Expected Obj, but got I4
			bool flag = __spawnPointState == SpawnPointState.Spawned;
			return (Route)flag;
		}
		private set
		{
			//IL_000a: Expected I4, but got Obj
			__spawnPointState = (SpawnPointState)value;
		}
	}

	public PickupData PickupData => (PickupData)(object)ContainingRoute__BackingField;

	private bool IsAvailableAsTrackObject
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_pickupData != 0;
		}
	}

	public GameObject SpawnedPickupIcon
	{
		get
		{
			//IL_0026: Expected Obj, but got I4
			TrackObject trackObject = _trackObject;
			bool active = trackObject._active;
			return (GameObject)active;
		}
	}

	private bool IsPositionAcceptableBeforeSpawn
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_spawnedPickupVisuals != 0;
		}
	}

	protected bool IsZPositionToGameStartAcceptableBeforeSpawn
	{
		get
		{
			//IL_01e1: Expected I, but got Obj
			//IL_01f7: Expected Obj, but got I
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_026d: Expected VT, but got Obj
			//IL_026d: Expected Obj, but got I4
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Expected Obj, but got Unknown
			//IL_02b0: Expected I, but got Obj
			//IL_02c6: Expected Obj, but got I
			//IL_0300: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			//IL_017c: Expected I, but got Obj
			string text = tag;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = default;
			object obj2 = obj3 + 12;
			if (((ComputeShader)(object)text).FindKernel((string)null) != 0)
			{
				nint num3 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v14 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(GamePositionRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v24 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isRestricted = AgeRestriction.isRestricted;
				GameObject gameObject = base.gameObject;
				Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
				nint num5 = (nint)typeof(Character);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num6 = (nint)typeof(Character);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v28 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterRendering instance = CharacterRendering.Instance;
				object obj6 = instance + 236;
				obj3 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S2_v10+8]");
				_ = 0;
				nint num7 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S2_v15 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num8 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v19 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10+8]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				object obj8 = num9 - 0;
				float num10 = (float)obj8 * 0.125f;
				return num10 > 0f;
			}
			return false;
		}
	}

	protected bool IsZAvailableToJetpackState
	{
		get
		{
			//IL_00c6: Expected VT, but got Obj
			//IL_00d7: Invalid comparison between I and F4
			//IL_001c: Expected VT, but got Obj
			//IL_002f: Expected I, but got Obj
			//IL_0045: Expected Obj, but got I
			//IL_0114: Expected VT, but got Obj
			//IL_0124: Invalid comparison between F4 and I
			//IL_0070: Expected I, but got Obj
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (T)+30]");
			if (0f > 0f)
			{
				GameObject gameObject = base.gameObject;
				Transform transform = default;
				transform.position = (Vector3)gameObject;
				nint num = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v9 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v18 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num3 = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr * 0.125f;
				_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v16 (T)+30]");
				return !(num3 < 0f);
			}
			return false;
		}
	}

	public unsafe event Action<PickupSpawnPoint> OnRegistered
	{
		add
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected I, but got Unknown
			//IL_0126: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0062: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v14 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v37 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object typeFromHandle = typeof(XTestPicker);
			nint num3 = (nint)(typeFromHandle + 4);
			((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
			Type type = Type.internal_from_handle((IntPtr)num3);
			string text = default;
			if ((object)text == type)
			{
				object obj2 = (nint)((UnityEngine.Object)this).m_CachedPtr - -64;
				SaveGame save = ((DataManager<>)obj2).save;
				return;
			}
			string message = "Type not yet expected. Add a case for " + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			MissingReferenceException ex = default;
			ex._002Ector(message);
			((PickupManagerController)(object)ex).PickupManager_OnPickerRemoved((PickerRemoveRequestEventArgs)null);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRegistered;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<PickupSpawnPoint> OnDeregistered
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRegistered;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnDeregistered;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<PickupSpawnPoint> OnPickupDespawned
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnDeregistered;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupDespawned;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<PickupSpawnPoint> OnPickupCollected
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupDespawned;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupCollected;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<PickupSpawnPoint, PickerData> OnPickupSpawned
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupCollected;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupSpawned;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	protected void Awake()
	{
		//IL_005d: Expected Obj, but got F4
		//IL_0068: Expected Obj, but got F4
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		this.m_OnDeregistered = (Action<PickupSpawnPoint>)180f;
		this.m_OnPickupDespawned = (Action<PickupSpawnPoint>)0.9f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 down = Vector3.down;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 28;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17+8]");
		_ = 0;
		__forceSpawnPickupType = PickupType.Key;
		CancelInvoke();
	}

	private unsafe void InitializeAllValues()
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		object obj = this + 100;
		TrackObject component = GetComponent<TrackObject>();
		obj = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(PickupSpawnPoint.TrackObject_OnActivate);
		object obj2 = action + 16;
		obj2 = this;
		_trackObject.OnActivate -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(PickupSpawnPoint.TrackObject_OnDeactivate);
		object obj3 = action2 + 16;
		obj3 = this;
		_trackObject.OnDeactivate -= action2;
		object obj4 = this + 96;
		Collider component2 = GetComponent<Collider>();
		obj4 = component2;
		_trigger.isTrigger = false;
		_spawnPointModeOriginal = __spawnPointMode;
		_forceSpawnPickupTypeOriginal = __forceSpawnPickupType;
		_spawnPointDifficultyOriginal = _spawnPointDifficulty;
		_spawnPointHeightOriginal = _spawnPointHeight;
		SetContainingRoute();
	}

	private void SetForceSpawnPickupTypeAndOriginalTo(PickupType pickupType, bool ignoreJetpackZ)
	{
		//IL_bf09: Expected Obj, but got I4
		//IL_bf17: Expected I, but got Obj
		//IL_bf2d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_bf61: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_b676: Expected Obj, but got I
		//IL_b37a: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I
		//IL_bc35: Expected I, but got Obj
		//IL_bc4b: Expected Obj, but got I
		//IL_b40f: Expected I4, but got Obj
		//IL_b183: Expected Obj, but got I
		//IL_b19e: Expected Obj, but got I
		//IL_b1b1: Expected I, but got Obj
		//IL_b1c7: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_c14c: Expected VT, but got I4
		//IL_c14c: Expected Obj, but got I4
		//IL_bf9e: Expected Obj, but got I
		//IL_bfae: Expected Obj, but got I
		//IL_c037: Expected I, but got Obj
		//IL_c04d: Expected Obj, but got I
		//IL_bc76: Expected I, but got Obj
		//IL_b44c: Expected Obj, but got I4
		//IL_b464: Expected I, but got Obj
		//IL_b47a: Expected Obj, but got I
		//IL_b1f2: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		//IL_0296: Expected I, but got Obj
		//IL_02ac: Expected Obj, but got I
		//IL_c0bf: Expected Obj, but got I
		//IL_c0dc: Expected Obj, but got I
		//IL_c0dc: Expected Obj, but got I
		//IL_b23f: Expected I, but got Obj
		//IL_c003: Expected Obj, but got VT
		//IL_b4a5: Expected I, but got Obj
		//IL_02d7: Expected I, but got Obj
		//IL_031f: Expected Obj, but got VT
		//IL_01de: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_b50e: Expected I, but got Obj
		//IL_b524: Expected Obj, but got I
		//IL_bfdd: Expected VT, but got I4
		//IL_bfdd: Expected Obj, but got I4
		//IL_c103: Expected Obj, but got I
		//IL_c120: Expected Obj, but got I
		//IL_c120: Expected Obj, but got I
		//IL_021f: Expected I, but got Obj
		//IL_b54f: Expected I, but got Obj
		//IL_b5e0: Expected I, but got Obj
		//IL_b5f6: Expected Obj, but got I
		//IL_c137: Expected Obj, but got I4
		//IL_b621: Expected I, but got Obj
		//IL_bcc8: Expected I, but got Obj
		//IL_bcde: Expected Obj, but got I
		//IL_c18e: Expected Obj, but got I
		//IL_c1ab: Expected Obj, but got I
		//IL_c1ab: Expected Obj, but got I
		//IL_bd09: Expected I, but got Obj
		//IL_bd72: Expected I, but got Obj
		//IL_bd88: Expected Obj, but got I
		//IL_c1cd: Expected I, but got Obj
		//IL_c1e3: Expected Obj, but got I
		//IL_c21e: Expected Obj, but got I
		//IL_bdb3: Expected I, but got Obj
		//IL_be00: Expected I, but got Obj
		//IL_be6a: Expected I, but got Obj
		//IL_be80: Expected Obj, but got I
		//IL_beab: Expected I, but got Obj
		//IL_b290: Expected Obj, but got I4
		//IL_b2ac: Expected I, but got Obj
		//IL_b2c2: Expected Obj, but got I
		//IL_c098: Expected Obj, but got I4
		//IL_b2ed: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v236 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (System.Boolean)+D8]");
		if ((nint)0 != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v232 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		object obj4 = (isInstantiated2 ? 1 : 0) - -64;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ignoreJetpackZ @ L2 (SYBO.Subway.Pickups.PickupType)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
		if ((nint)0 > (nint)64)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
			if ((nint)0 <= (nint)256)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
				object obj6 = -128;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
				if ((nint)0 == 128)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ignoreJetpackZ @ L2 (SYBO.Subway.Pickups.PickupType)+8]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v202+5C]");
					_0021_00210 componentInChildren = (_0021_00210)((GameObject)0).GetComponentInChildren<T>();
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ S0_v206 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1870 @ S0_v214 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
					{
						((CharacterLetterPickup)componentInChildren)._002Ector();
					}
					return;
				}
				if ((nint)obj6 == 128)
				{
					nint num7 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1828 @ S0_v221 (Il2CppClass<RewardManager>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num8 = (nint)typeof(RewardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1862 @ S0_v228 (Il2CppClass<RewardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 vector = ((SSEventsPopup)4).VerifySettingOnline((string)null, (Vector3)0);
					string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl).DoubleMultiplierPickupsCollectedIncrement();
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
				object obj10 = -512;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
				if ((nint)0 == 512)
				{
					string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v161 (System.String)+120]");
					object obj11 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v161 (System.String)+124]");
					object obj12 = (nint)0 + (nint)1;
					nint num9 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1750 @ S0_v164 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num10 = (nint)typeof(WeeklyHuntManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ S0_v181 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					WeeklyHuntManager.InitIfNeeded();
					nint num11 = (nint)typeof(Character);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1879 @ S0_v170 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num12 = (nint)typeof(Character);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1908 @ S0_v177 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CharacterRendering instance = CharacterRendering.Instance;
					((CharacterPickupParticles)(object)instance._characterModel)._002Ector();
					return;
				}
				if ((nint)obj10 != 1 && (nint)obj10 != 2 && (nint)obj10 != 3 && (nint)obj10 != 4 && (nint)obj10 != 5 && (nint)obj10 != 6 && (nint)obj10 != 7 && (nint)obj10 != 8 && (nint)obj10 != 9 && (nint)obj10 != 10 && (nint)obj10 != 11 && (nint)obj10 != 12 && (nint)obj10 != 13 && (nint)obj10 != 14 && (nint)obj10 != 15 && (nint)obj10 != 16 && (nint)obj10 != 17 && (nint)obj10 != 18 && (nint)obj10 != 19 && (nint)obj10 != 20 && (nint)obj10 != 21 && (nint)obj10 != 22 && (nint)obj10 != 23 && (nint)obj10 != 24 && (nint)obj10 != 25 && (nint)obj10 != 26 && (nint)obj10 != 27 && (nint)obj10 != 28 && (nint)obj10 != 29 && (nint)obj10 != 30 && (nint)obj10 != 31 && (nint)obj10 != 32 && (nint)obj10 != 33 && (nint)obj10 != 34 && (nint)obj10 != 35 && (nint)obj10 != 36 && (nint)obj10 != 37 && (nint)obj10 != 38 && (nint)obj10 != 39 && (nint)obj10 != 40 && (nint)obj10 != 41 && (nint)obj10 != 42 && (nint)obj10 != 43 && (nint)obj10 != 44 && (nint)obj10 != 45 && (nint)obj10 != 46 && (nint)obj10 != 47 && (nint)obj10 != 48 && (nint)obj10 != 49 && (nint)obj10 != 50 && (nint)obj10 != 51 && (nint)obj10 != 52 && (nint)obj10 != 53 && (nint)obj10 != 54 && (nint)obj10 != 55 && (nint)obj10 != 56 && (nint)obj10 != 57 && (nint)obj10 != 58 && (nint)obj10 != 59 && (nint)obj10 != 60 && (nint)obj10 != 61 && (nint)obj10 != 62 && (nint)obj10 != 63 && (nint)obj10 != 64 && (nint)obj10 != 65 && (nint)obj10 != 66 && (nint)obj10 != 67 && (nint)obj10 != 68 && (nint)obj10 != 69 && (nint)obj10 != 70 && (nint)obj10 != 71 && (nint)obj10 != 72 && (nint)obj10 != 73 && (nint)obj10 != 74 && (nint)obj10 != 75 && (nint)obj10 != 76 && (nint)obj10 != 77 && (nint)obj10 != 78 && (nint)obj10 != 79 && (nint)obj10 != 80 && (nint)obj10 != 81 && (nint)obj10 != 82 && (nint)obj10 != 83 && (nint)obj10 != 84 && (nint)obj10 != 85 && (nint)obj10 != 86 && (nint)obj10 != 87 && (nint)obj10 != 88 && (nint)obj10 != 89 && (nint)obj10 != 90 && (nint)obj10 != 91 && (nint)obj10 != 92 && (nint)obj10 != 93 && (nint)obj10 != 94 && (nint)obj10 != 95 && (nint)obj10 != 96 && (nint)obj10 != 97 && (nint)obj10 != 98 && (nint)obj10 != 99 && (nint)obj10 != 100 && (nint)obj10 != 101 && (nint)obj10 != 102 && (nint)obj10 != 103 && (nint)obj10 != 104 && (nint)obj10 != 105 && (nint)obj10 != 106 && (nint)obj10 != 107 && (nint)obj10 != 108 && (nint)obj10 != 109 && (nint)obj10 != 110 && (nint)obj10 != 111 && (nint)obj10 != 112 && (nint)obj10 != 113 && (nint)obj10 != 114 && (nint)obj10 != 115 && (nint)obj10 != 116 && (nint)obj10 != 117 && (nint)obj10 != 118 && (nint)obj10 != 119 && (nint)obj10 != 120 && (nint)obj10 != 121 && (nint)obj10 != 122 && (nint)obj10 != 123 && (nint)obj10 != 124 && (nint)obj10 != 125 && (nint)obj10 != 126 && (nint)obj10 != 127 && (nint)obj10 != 128 && (nint)obj10 != 129 && (nint)obj10 != 130 && (nint)obj10 != 131 && (nint)obj10 != 132 && (nint)obj10 != 133 && (nint)obj10 != 134 && (nint)obj10 != 135 && (nint)obj10 != 136 && (nint)obj10 != 137 && (nint)obj10 != 138 && (nint)obj10 != 139 && (nint)obj10 != 140 && (nint)obj10 != 141 && (nint)obj10 != 142 && (nint)obj10 != 143 && (nint)obj10 != 144 && (nint)obj10 != 145 && (nint)obj10 != 146 && (nint)obj10 != 147 && (nint)obj10 != 148 && (nint)obj10 != 149 && (nint)obj10 != 150 && (nint)obj10 != 151 && (nint)obj10 != 152 && (nint)obj10 != 153 && (nint)obj10 != 154 && (nint)obj10 != 155 && (nint)obj10 != 156 && (nint)obj10 != 157 && (nint)obj10 != 158 && (nint)obj10 != 159 && (nint)obj10 != 160 && (nint)obj10 != 161 && (nint)obj10 != 162 && (nint)obj10 != 163 && (nint)obj10 != 164 && (nint)obj10 != 165 && (nint)obj10 != 166 && (nint)obj10 != 167 && (nint)obj10 != 168 && (nint)obj10 != 169 && (nint)obj10 != 170 && (nint)obj10 != 171 && (nint)obj10 != 172 && (nint)obj10 != 173 && (nint)obj10 != 174 && (nint)obj10 != 175 && (nint)obj10 != 176 && (nint)obj10 != 177 && (nint)obj10 != 178 && (nint)obj10 != 179 && (nint)obj10 != 180 && (nint)obj10 != 181 && (nint)obj10 != 182 && (nint)obj10 != 183 && (nint)obj10 != 184 && (nint)obj10 != 185 && (nint)obj10 != 186 && (nint)obj10 != 187 && (nint)obj10 != 188 && (nint)obj10 != 189 && (nint)obj10 != 190 && (nint)obj10 != 191 && (nint)obj10 != 192 && (nint)obj10 != 193 && (nint)obj10 != 194 && (nint)obj10 != 195 && (nint)obj10 != 196 && (nint)obj10 != 197 && (nint)obj10 != 198 && (nint)obj10 != 199 && (nint)obj10 != 200 && (nint)obj10 != 201 && (nint)obj10 != 202 && (nint)obj10 != 203 && (nint)obj10 != 204 && (nint)obj10 != 205 && (nint)obj10 != 206 && (nint)obj10 != 207 && (nint)obj10 != 208 && (nint)obj10 != 209 && (nint)obj10 != 210 && (nint)obj10 != 211 && (nint)obj10 != 212 && (nint)obj10 != 213 && (nint)obj10 != 214 && (nint)obj10 != 215 && (nint)obj10 != 216 && (nint)obj10 != 217 && (nint)obj10 != 218 && (nint)obj10 != 219 && (nint)obj10 != 220 && (nint)obj10 != 221 && (nint)obj10 != 222 && (nint)obj10 != 223 && (nint)obj10 != 224 && (nint)obj10 != 225 && (nint)obj10 != 226 && (nint)obj10 != 227 && (nint)obj10 != 228 && (nint)obj10 != 229 && (nint)obj10 != 230 && (nint)obj10 != 231 && (nint)obj10 != 232 && (nint)obj10 != 233 && (nint)obj10 != 234 && (nint)obj10 != 235 && (nint)obj10 != 236 && (nint)obj10 != 237 && (nint)obj10 != 238 && (nint)obj10 != 239 && (nint)obj10 != 240 && (nint)obj10 != 241 && (nint)obj10 != 242 && (nint)obj10 != 243 && (nint)obj10 != 244 && (nint)obj10 != 245 && (nint)obj10 != 246 && (nint)obj10 != 247 && (nint)obj10 != 248 && (nint)obj10 != 249 && (nint)obj10 != 250 && (nint)obj10 != 251 && (nint)obj10 != 252 && (nint)obj10 != 253 && (nint)obj10 != 254 && (nint)obj10 != 255 && (nint)obj10 != 256 && (nint)obj10 != 257 && (nint)obj10 != 258 && (nint)obj10 != 259 && (nint)obj10 != 260 && (nint)obj10 != 261 && (nint)obj10 != 262 && (nint)obj10 != 263 && (nint)obj10 != 264 && (nint)obj10 != 265 && (nint)obj10 != 266 && (nint)obj10 != 267 && (nint)obj10 != 268 && (nint)obj10 != 269 && (nint)obj10 != 270 && (nint)obj10 != 271 && (nint)obj10 != 272 && (nint)obj10 != 273 && (nint)obj10 != 274 && (nint)obj10 != 275 && (nint)obj10 != 276 && (nint)obj10 != 277 && (nint)obj10 != 278 && (nint)obj10 != 279 && (nint)obj10 != 280 && (nint)obj10 != 281 && (nint)obj10 != 282 && (nint)obj10 != 283 && (nint)obj10 != 284 && (nint)obj10 != 285 && (nint)obj10 != 286 && (nint)obj10 != 287 && (nint)obj10 != 288 && (nint)obj10 != 289 && (nint)obj10 != 290 && (nint)obj10 != 291 && (nint)obj10 != 292 && (nint)obj10 != 293 && (nint)obj10 != 294 && (nint)obj10 != 295 && (nint)obj10 != 296 && (nint)obj10 != 297 && (nint)obj10 != 298 && (nint)obj10 != 299 && (nint)obj10 != 300 && (nint)obj10 != 301 && (nint)obj10 != 302 && (nint)obj10 != 303 && (nint)obj10 != 304 && (nint)obj10 != 305 && (nint)obj10 != 306 && (nint)obj10 != 307 && (nint)obj10 != 308 && (nint)obj10 != 309 && (nint)obj10 != 310 && (nint)obj10 != 311 && (nint)obj10 != 312 && (nint)obj10 != 313 && (nint)obj10 != 314 && (nint)obj10 != 315 && (nint)obj10 != 316 && (nint)obj10 != 317 && (nint)obj10 != 318 && (nint)obj10 != 319 && (nint)obj10 != 320 && (nint)obj10 != 321 && (nint)obj10 != 322 && (nint)obj10 != 323 && (nint)obj10 != 324 && (nint)obj10 != 325 && (nint)obj10 != 326 && (nint)obj10 != 327 && (nint)obj10 != 328 && (nint)obj10 != 329 && (nint)obj10 != 330 && (nint)obj10 != 331 && (nint)obj10 != 332 && (nint)obj10 != 333 && (nint)obj10 != 334 && (nint)obj10 != 335 && (nint)obj10 != 336 && (nint)obj10 != 337 && (nint)obj10 != 338 && (nint)obj10 != 339 && (nint)obj10 != 340 && (nint)obj10 != 341 && (nint)obj10 != 342 && (nint)obj10 != 343 && (nint)obj10 != 344 && (nint)obj10 != 345 && (nint)obj10 != 346 && (nint)obj10 != 347 && (nint)obj10 != 348 && (nint)obj10 != 349 && (nint)obj10 != 350 && (nint)obj10 != 351 && (nint)obj10 != 352 && (nint)obj10 != 353 && (nint)obj10 != 354 && (nint)obj10 != 355 && (nint)obj10 != 356 && (nint)obj10 != 357 && (nint)obj10 != 358 && (nint)obj10 != 359 && (nint)obj10 != 360 && (nint)obj10 != 361 && (nint)obj10 != 362 && (nint)obj10 != 363 && (nint)obj10 != 364 && (nint)obj10 != 365 && (nint)obj10 != 366 && (nint)obj10 != 367 && (nint)obj10 != 368 && (nint)obj10 != 369 && (nint)obj10 != 370 && (nint)obj10 != 371 && (nint)obj10 != 372 && (nint)obj10 != 373 && (nint)obj10 != 374 && (nint)obj10 != 375 && (nint)obj10 != 376 && (nint)obj10 != 377 && (nint)obj10 != 378 && (nint)obj10 != 379 && (nint)obj10 != 380 && (nint)obj10 != 381 && (nint)obj10 != 382 && (nint)obj10 != 383 && (nint)obj10 != 384 && (nint)obj10 != 385 && (nint)obj10 != 386 && (nint)obj10 != 387 && (nint)obj10 != 388 && (nint)obj10 != 389 && (nint)obj10 != 390 && (nint)obj10 != 391 && (nint)obj10 != 392 && (nint)obj10 != 393 && (nint)obj10 != 394 && (nint)obj10 != 395 && (nint)obj10 != 396 && (nint)obj10 != 397 && (nint)obj10 != 398 && (nint)obj10 != 399 && (nint)obj10 != 400 && (nint)obj10 != 401 && (nint)obj10 != 402 && (nint)obj10 != 403 && (nint)obj10 != 404 && (nint)obj10 != 405 && (nint)obj10 != 406 && (nint)obj10 != 407 && (nint)obj10 != 408 && (nint)obj10 != 409 && (nint)obj10 != 410 && (nint)obj10 != 411 && (nint)obj10 != 412 && (nint)obj10 != 413 && (nint)obj10 != 414 && (nint)obj10 != 415 && (nint)obj10 != 416 && (nint)obj10 != 417 && (nint)obj10 != 418 && (nint)obj10 != 419 && (nint)obj10 != 420 && (nint)obj10 != 421 && (nint)obj10 != 422 && (nint)obj10 != 423 && (nint)obj10 != 424 && (nint)obj10 != 425 && (nint)obj10 != 426 && (nint)obj10 != 427 && (nint)obj10 != 428 && (nint)obj10 != 429 && (nint)obj10 != 430 && (nint)obj10 != 431 && (nint)obj10 != 432 && (nint)obj10 != 433 && (nint)obj10 != 434 && (nint)obj10 != 435 && (nint)obj10 != 436 && (nint)obj10 != 437 && (nint)obj10 != 438 && (nint)obj10 != 439 && (nint)obj10 != 440 && (nint)obj10 != 441 && (nint)obj10 != 442 && (nint)obj10 != 443 && (nint)obj10 != 444 && (nint)obj10 != 445 && (nint)obj10 != 446 && (nint)obj10 != 447 && (nint)obj10 != 448 && (nint)obj10 != 449 && (nint)obj10 != 450 && (nint)obj10 != 451 && (nint)obj10 != 452 && (nint)obj10 != 453 && (nint)obj10 != 454 && (nint)obj10 != 455 && (nint)obj10 != 456 && (nint)obj10 != 457 && (nint)obj10 != 458 && (nint)obj10 != 459 && (nint)obj10 != 460 && (nint)obj10 != 461 && (nint)obj10 != 462 && (nint)obj10 != 463 && (nint)obj10 != 464 && (nint)obj10 != 465 && (nint)obj10 != 466 && (nint)obj10 != 467 && (nint)obj10 != 468 && (nint)obj10 != 469 && (nint)obj10 != 470 && (nint)obj10 != 471 && (nint)obj10 != 472 && (nint)obj10 != 473 && (nint)obj10 != 474 && (nint)obj10 != 475 && (nint)obj10 != 476 && (nint)obj10 != 477 && (nint)obj10 != 478 && (nint)obj10 != 479 && (nint)obj10 != 480 && (nint)obj10 != 481 && (nint)obj10 != 482 && (nint)obj10 != 483 && (nint)obj10 != 484 && (nint)obj10 != 485 && (nint)obj10 != 486 && (nint)obj10 != 487 && (nint)obj10 != 488 && (nint)obj10 != 489 && (nint)obj10 != 490 && (nint)obj10 != 491 && (nint)obj10 != 492 && (nint)obj10 != 493 && (nint)obj10 != 494 && (nint)obj10 != 495 && (nint)obj10 != 496 && (nint)obj10 != 497 && (nint)obj10 != 498 && (nint)obj10 != 499 && (nint)obj10 != 500 && (nint)obj10 != 501 && (nint)obj10 != 502 && (nint)obj10 != 503 && (nint)obj10 != 504 && (nint)obj10 != 505 && (nint)obj10 != 506 && (nint)obj10 != 507 && (nint)obj10 != 508 && (nint)obj10 != 509 && (nint)obj10 != 510 && (nint)obj10 != 511)
				{
					if ((nint)obj10 == 512)
					{
						bool isAllowed = DebugSettings.IsAllowed;
						Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])isAllowed);
						return;
					}
					if ((nint)obj10 != 513 && (nint)obj10 != 514 && (nint)obj10 != 515 && (nint)obj10 != 516 && (nint)obj10 != 517 && (nint)obj10 != 518 && (nint)obj10 != 519 && (nint)obj10 != 520 && (nint)obj10 != 521 && (nint)obj10 != 522 && (nint)obj10 != 523 && (nint)obj10 != 524 && (nint)obj10 != 525 && (nint)obj10 != 526 && (nint)obj10 != 527 && (nint)obj10 != 528 && (nint)obj10 != 529 && (nint)obj10 != 530 && (nint)obj10 != 531 && (nint)obj10 != 532 && (nint)obj10 != 533 && (nint)obj10 != 534 && (nint)obj10 != 535 && (nint)obj10 != 536 && (nint)obj10 != 537 && (nint)obj10 != 538 && (nint)obj10 != 539 && (nint)obj10 != 540 && (nint)obj10 != 541 && (nint)obj10 != 542 && (nint)obj10 != 543 && (nint)obj10 != 544 && (nint)obj10 != 545 && (nint)obj10 != 546 && (nint)obj10 != 547 && (nint)obj10 != 548 && (nint)obj10 != 549 && (nint)obj10 != 550 && (nint)obj10 != 551 && (nint)obj10 != 552 && (nint)obj10 != 553 && (nint)obj10 != 554 && (nint)obj10 != 555 && (nint)obj10 != 556 && (nint)obj10 != 557 && (nint)obj10 != 558 && (nint)obj10 != 559 && (nint)obj10 != 560 && (nint)obj10 != 561 && (nint)obj10 != 562 && (nint)obj10 != 563 && (nint)obj10 != 564 && (nint)obj10 != 565 && (nint)obj10 != 566 && (nint)obj10 != 567 && (nint)obj10 != 568 && (nint)obj10 != 569 && (nint)obj10 != 570 && (nint)obj10 != 571 && (nint)obj10 != 572 && (nint)obj10 != 573 && (nint)obj10 != 574 && (nint)obj10 != 575 && (nint)obj10 != 576 && (nint)obj10 != 577 && (nint)obj10 != 578 && (nint)obj10 != 579 && (nint)obj10 != 580 && (nint)obj10 != 581 && (nint)obj10 != 582 && (nint)obj10 != 583 && (nint)obj10 != 584 && (nint)obj10 != 585 && (nint)obj10 != 586 && (nint)obj10 != 587 && (nint)obj10 != 588 && (nint)obj10 != 589 && (nint)obj10 != 590 && (nint)obj10 != 591 && (nint)obj10 != 592 && (nint)obj10 != 593 && (nint)obj10 != 594 && (nint)obj10 != 595 && (nint)obj10 != 596 && (nint)obj10 != 597 && (nint)obj10 != 598 && (nint)obj10 != 599 && (nint)obj10 != 600 && (nint)obj10 != 601 && (nint)obj10 != 602 && (nint)obj10 != 603 && (nint)obj10 != 604 && (nint)obj10 != 605 && (nint)obj10 != 606 && (nint)obj10 != 607 && (nint)obj10 != 608 && (nint)obj10 != 609 && (nint)obj10 != 610 && (nint)obj10 != 611 && (nint)obj10 != 612 && (nint)obj10 != 613 && (nint)obj10 != 614 && (nint)obj10 != 615 && (nint)obj10 != 616 && (nint)obj10 != 617 && (nint)obj10 != 618 && (nint)obj10 != 619 && (nint)obj10 != 620 && (nint)obj10 != 621 && (nint)obj10 != 622 && (nint)obj10 != 623 && (nint)obj10 != 624 && (nint)obj10 != 625 && (nint)obj10 != 626 && (nint)obj10 != 627 && (nint)obj10 != 628 && (nint)obj10 != 629 && (nint)obj10 != 630 && (nint)obj10 != 631 && (nint)obj10 != 632 && (nint)obj10 != 633 && (nint)obj10 != 634 && (nint)obj10 != 635 && (nint)obj10 != 636 && (nint)obj10 != 637 && (nint)obj10 != 638 && (nint)obj10 != 639 && (nint)obj10 != 640 && (nint)obj10 != 641 && (nint)obj10 != 642 && (nint)obj10 != 643 && (nint)obj10 != 644 && (nint)obj10 != 645 && (nint)obj10 != 646 && (nint)obj10 != 647 && (nint)obj10 != 648 && (nint)obj10 != 649 && (nint)obj10 != 650 && (nint)obj10 != 651 && (nint)obj10 != 652 && (nint)obj10 != 653 && (nint)obj10 != 654 && (nint)obj10 != 655 && (nint)obj10 != 656 && (nint)obj10 != 657 && (nint)obj10 != 658 && (nint)obj10 != 659 && (nint)obj10 != 660 && (nint)obj10 != 661 && (nint)obj10 != 662 && (nint)obj10 != 663 && (nint)obj10 != 664 && (nint)obj10 != 665 && (nint)obj10 != 666 && (nint)obj10 != 667 && (nint)obj10 != 668 && (nint)obj10 != 669 && (nint)obj10 != 670 && (nint)obj10 != 671 && (nint)obj10 != 672 && (nint)obj10 != 673 && (nint)obj10 != 674 && (nint)obj10 != 675 && (nint)obj10 != 676 && (nint)obj10 != 677 && (nint)obj10 != 678 && (nint)obj10 != 679 && (nint)obj10 != 680 && (nint)obj10 != 681 && (nint)obj10 != 682 && (nint)obj10 != 683 && (nint)obj10 != 684 && (nint)obj10 != 685 && (nint)obj10 != 686 && (nint)obj10 != 687 && (nint)obj10 != 688 && (nint)obj10 != 689 && (nint)obj10 != 690 && (nint)obj10 != 691 && (nint)obj10 != 692 && (nint)obj10 != 693 && (nint)obj10 != 694 && (nint)obj10 != 695 && (nint)obj10 != 696 && (nint)obj10 != 697 && (nint)obj10 != 698 && (nint)obj10 != 699 && (nint)obj10 != 700 && (nint)obj10 != 701 && (nint)obj10 != 702 && (nint)obj10 != 703 && (nint)obj10 != 704 && (nint)obj10 != 705 && (nint)obj10 != 706 && (nint)obj10 != 707 && (nint)obj10 != 708 && (nint)obj10 != 709 && (nint)obj10 != 710 && (nint)obj10 != 711 && (nint)obj10 != 712 && (nint)obj10 != 713 && (nint)obj10 != 714 && (nint)obj10 != 715 && (nint)obj10 != 716 && (nint)obj10 != 717 && (nint)obj10 != 718 && (nint)obj10 != 719 && (nint)obj10 != 720 && (nint)obj10 != 721 && (nint)obj10 != 722 && (nint)obj10 != 723 && (nint)obj10 != 724 && (nint)obj10 != 725 && (nint)obj10 != 726 && (nint)obj10 != 727 && (nint)obj10 != 728 && (nint)obj10 != 729 && (nint)obj10 != 730 && (nint)obj10 != 731 && (nint)obj10 != 732 && (nint)obj10 != 733 && (nint)obj10 != 734 && (nint)obj10 != 735 && (nint)obj10 != 736 && (nint)obj10 != 737 && (nint)obj10 != 738 && (nint)obj10 != 739 && (nint)obj10 != 740 && (nint)obj10 != 741 && (nint)obj10 != 742 && (nint)obj10 != 743 && (nint)obj10 != 744 && (nint)obj10 != 745 && (nint)obj10 != 746 && (nint)obj10 != 747 && (nint)obj10 != 748 && (nint)obj10 != 749 && (nint)obj10 != 750 && (nint)obj10 != 751 && (nint)obj10 != 752 && (nint)obj10 != 753 && (nint)obj10 != 754 && (nint)obj10 != 755 && (nint)obj10 != 756 && (nint)obj10 != 757 && (nint)obj10 != 758 && (nint)obj10 != 759 && (nint)obj10 != 760 && (nint)obj10 != 761 && (nint)obj10 != 762 && (nint)obj10 != 763 && (nint)obj10 != 764 && (nint)obj10 != 765 && (nint)obj10 != 766 && (nint)obj10 != 767 && (nint)obj10 != 768 && (nint)obj10 != 769 && (nint)obj10 != 770 && (nint)obj10 != 771 && (nint)obj10 != 772 && (nint)obj10 != 773 && (nint)obj10 != 774 && (nint)obj10 != 775 && (nint)obj10 != 776 && (nint)obj10 != 777 && (nint)obj10 != 778 && (nint)obj10 != 779 && (nint)obj10 != 780 && (nint)obj10 != 781 && (nint)obj10 != 782 && (nint)obj10 != 783 && (nint)obj10 != 784 && (nint)obj10 != 785 && (nint)obj10 != 786 && (nint)obj10 != 787 && (nint)obj10 != 788 && (nint)obj10 != 789 && (nint)obj10 != 790 && (nint)obj10 != 791 && (nint)obj10 != 792 && (nint)obj10 != 793 && (nint)obj10 != 794 && (nint)obj10 != 795 && (nint)obj10 != 796 && (nint)obj10 != 797 && (nint)obj10 != 798 && (nint)obj10 != 799 && (nint)obj10 != 800 && (nint)obj10 != 801 && (nint)obj10 != 802 && (nint)obj10 != 803 && (nint)obj10 != 804 && (nint)obj10 != 805 && (nint)obj10 != 806 && (nint)obj10 != 807 && (nint)obj10 != 808 && (nint)obj10 != 809 && (nint)obj10 != 810 && (nint)obj10 != 811 && (nint)obj10 != 812 && (nint)obj10 != 813 && (nint)obj10 != 814 && (nint)obj10 != 815 && (nint)obj10 != 816 && (nint)obj10 != 817 && (nint)obj10 != 818 && (nint)obj10 != 819 && (nint)obj10 != 820 && (nint)obj10 != 821 && (nint)obj10 != 822 && (nint)obj10 != 823 && (nint)obj10 != 824 && (nint)obj10 != 825 && (nint)obj10 != 826 && (nint)obj10 != 827 && (nint)obj10 != 828 && (nint)obj10 != 829 && (nint)obj10 != 830 && (nint)obj10 != 831 && (nint)obj10 != 832 && (nint)obj10 != 833 && (nint)obj10 != 834 && (nint)obj10 != 835 && (nint)obj10 != 836 && (nint)obj10 != 837 && (nint)obj10 != 838 && (nint)obj10 != 839 && (nint)obj10 != 840 && (nint)obj10 != 841 && (nint)obj10 != 842 && (nint)obj10 != 843 && (nint)obj10 != 844 && (nint)obj10 != 845 && (nint)obj10 != 846 && (nint)obj10 != 847 && (nint)obj10 != 848 && (nint)obj10 != 849 && (nint)obj10 != 850 && (nint)obj10 != 851 && (nint)obj10 != 852 && (nint)obj10 != 853 && (nint)obj10 != 854 && (nint)obj10 != 855 && (nint)obj10 != 856 && (nint)obj10 != 857 && (nint)obj10 != 858 && (nint)obj10 != 859 && (nint)obj10 != 860 && (nint)obj10 != 861 && (nint)obj10 != 862 && (nint)obj10 != 863 && (nint)obj10 != 864 && (nint)obj10 != 865 && (nint)obj10 != 866 && (nint)obj10 != 867 && (nint)obj10 != 868 && (nint)obj10 != 869 && (nint)obj10 != 870 && (nint)obj10 != 871 && (nint)obj10 != 872 && (nint)obj10 != 873 && (nint)obj10 != 874 && (nint)obj10 != 875 && (nint)obj10 != 876 && (nint)obj10 != 877 && (nint)obj10 != 878 && (nint)obj10 != 879 && (nint)obj10 != 880 && (nint)obj10 != 881 && (nint)obj10 != 882 && (nint)obj10 != 883 && (nint)obj10 != 884 && (nint)obj10 != 885 && (nint)obj10 != 886 && (nint)obj10 != 887 && (nint)obj10 != 888 && (nint)obj10 != 889 && (nint)obj10 != 890 && (nint)obj10 != 891 && (nint)obj10 != 892 && (nint)obj10 != 893 && (nint)obj10 != 894 && (nint)obj10 != 895 && (nint)obj10 != 896 && (nint)obj10 != 897 && (nint)obj10 != 898 && (nint)obj10 != 899 && (nint)obj10 != 900 && (nint)obj10 != 901 && (nint)obj10 != 902 && (nint)obj10 != 903 && (nint)obj10 != 904 && (nint)obj10 != 905 && (nint)obj10 != 906 && (nint)obj10 != 907 && (nint)obj10 != 908 && (nint)obj10 != 909 && (nint)obj10 != 910 && (nint)obj10 != 911 && (nint)obj10 != 912 && (nint)obj10 != 913 && (nint)obj10 != 914 && (nint)obj10 != 915 && (nint)obj10 != 916 && (nint)obj10 != 917 && (nint)obj10 != 918 && (nint)obj10 != 919 && (nint)obj10 != 920 && (nint)obj10 != 921 && (nint)obj10 != 922 && (nint)obj10 != 923 && (nint)obj10 != 924 && (nint)obj10 != 925 && (nint)obj10 != 926 && (nint)obj10 != 927 && (nint)obj10 != 928 && (nint)obj10 != 929 && (nint)obj10 != 930 && (nint)obj10 != 931 && (nint)obj10 != 932 && (nint)obj10 != 933 && (nint)obj10 != 934 && (nint)obj10 != 935 && (nint)obj10 != 936 && (nint)obj10 != 937 && (nint)obj10 != 938 && (nint)obj10 != 939 && (nint)obj10 != 940 && (nint)obj10 != 941 && (nint)obj10 != 942 && (nint)obj10 != 943 && (nint)obj10 != 944 && (nint)obj10 != 945 && (nint)obj10 != 946 && (nint)obj10 != 947 && (nint)obj10 != 948 && (nint)obj10 != 949 && (nint)obj10 != 950 && (nint)obj10 != 951 && (nint)obj10 != 952 && (nint)obj10 != 953 && (nint)obj10 != 954 && (nint)obj10 != 955 && (nint)obj10 != 956 && (nint)obj10 != 957 && (nint)obj10 != 958 && (nint)obj10 != 959 && (nint)obj10 != 960 && (nint)obj10 != 961 && (nint)obj10 != 962 && (nint)obj10 != 963 && (nint)obj10 != 964 && (nint)obj10 != 965 && (nint)obj10 != 966 && (nint)obj10 != 967 && (nint)obj10 != 968 && (nint)obj10 != 969 && (nint)obj10 != 970 && (nint)obj10 != 971 && (nint)obj10 != 972 && (nint)obj10 != 973 && (nint)obj10 != 974 && (nint)obj10 != 975 && (nint)obj10 != 976 && (nint)obj10 != 977 && (nint)obj10 != 978 && (nint)obj10 != 979 && (nint)obj10 != 980 && (nint)obj10 != 981 && (nint)obj10 != 982 && (nint)obj10 != 983 && (nint)obj10 != 984 && (nint)obj10 != 985 && (nint)obj10 != 986 && (nint)obj10 != 987 && (nint)obj10 != 988 && (nint)obj10 != 989 && (nint)obj10 != 990 && (nint)obj10 != 991 && (nint)obj10 != 992 && (nint)obj10 != 993 && (nint)obj10 != 994 && (nint)obj10 != 995 && (nint)obj10 != 996 && (nint)obj10 != 997 && (nint)obj10 != 998 && (nint)obj10 != 999 && (nint)obj10 != 1000 && (nint)obj10 != 1001 && (nint)obj10 != 1002 && (nint)obj10 != 1003 && (nint)obj10 != 1004 && (nint)obj10 != 1005 && (nint)obj10 != 1006 && (nint)obj10 != 1007 && (nint)obj10 != 1008 && (nint)obj10 != 1009 && (nint)obj10 != 1010 && (nint)obj10 != 1011 && (nint)obj10 != 1012 && (nint)obj10 != 1013 && (nint)obj10 != 1014 && (nint)obj10 != 1015 && (nint)obj10 != 1016 && (nint)obj10 != 1017 && (nint)obj10 != 1018 && (nint)obj10 != 1019 && (nint)obj10 != 1020 && (nint)obj10 != 1021 && (nint)obj10 != 1022 && (nint)obj10 != 1023 && (nint)obj10 != 1024 && (nint)obj10 != 1025 && (nint)obj10 != 1026 && (nint)obj10 != 1027 && (nint)obj10 != 1028 && (nint)obj10 != 1029 && (nint)obj10 != 1030 && (nint)obj10 != 1031 && (nint)obj10 != 1032 && (nint)obj10 != 1033 && (nint)obj10 != 1034 && (nint)obj10 != 1035 && (nint)obj10 != 1036 && (nint)obj10 != 1037 && (nint)obj10 != 1038 && (nint)obj10 != 1039 && (nint)obj10 != 1040 && (nint)obj10 != 1041 && (nint)obj10 != 1042 && (nint)obj10 != 1043 && (nint)obj10 != 1044 && (nint)obj10 != 1045 && (nint)obj10 != 1046 && (nint)obj10 != 1047 && (nint)obj10 != 1048 && (nint)obj10 != 1049 && (nint)obj10 != 1050 && (nint)obj10 != 1051 && (nint)obj10 != 1052 && (nint)obj10 != 1053 && (nint)obj10 != 1054 && (nint)obj10 != 1055 && (nint)obj10 != 1056 && (nint)obj10 != 1057 && (nint)obj10 != 1058 && (nint)obj10 != 1059 && (nint)obj10 != 1060 && (nint)obj10 != 1061 && (nint)obj10 != 1062 && (nint)obj10 != 1063 && (nint)obj10 != 1064 && (nint)obj10 != 1065 && (nint)obj10 != 1066 && (nint)obj10 != 1067 && (nint)obj10 != 1068 && (nint)obj10 != 1069 && (nint)obj10 != 1070 && (nint)obj10 != 1071 && (nint)obj10 != 1072 && (nint)obj10 != 1073 && (nint)obj10 != 1074 && (nint)obj10 != 1075 && (nint)obj10 != 1076 && (nint)obj10 != 1077 && (nint)obj10 != 1078 && (nint)obj10 != 1079 && (nint)obj10 != 1080 && (nint)obj10 != 1081 && (nint)obj10 != 1082 && (nint)obj10 != 1083 && (nint)obj10 != 1084 && (nint)obj10 != 1085 && (nint)obj10 != 1086 && (nint)obj10 != 1087 && (nint)obj10 != 1088 && (nint)obj10 != 1089 && (nint)obj10 != 1090 && (nint)obj10 != 1091 && (nint)obj10 != 1092 && (nint)obj10 != 1093 && (nint)obj10 != 1094 && (nint)obj10 != 1095 && (nint)obj10 != 1096 && (nint)obj10 != 1097 && (nint)obj10 != 1098 && (nint)obj10 != 1099 && (nint)obj10 != 1100 && (nint)obj10 != 1101 && (nint)obj10 != 1102 && (nint)obj10 != 1103 && (nint)obj10 != 1104 && (nint)obj10 != 1105 && (nint)obj10 != 1106 && (nint)obj10 != 1107 && (nint)obj10 != 1108 && (nint)obj10 != 1109 && (nint)obj10 != 1110 && (nint)obj10 != 1111 && (nint)obj10 != 1112 && (nint)obj10 != 1113 && (nint)obj10 != 1114 && (nint)obj10 != 1115 && (nint)obj10 != 1116 && (nint)obj10 != 1117 && (nint)obj10 != 1118 && (nint)obj10 != 1119 && (nint)obj10 != 1120 && (nint)obj10 != 1121 && (nint)obj10 != 1122 && (nint)obj10 != 1123 && (nint)obj10 != 1124 && (nint)obj10 != 1125 && (nint)obj10 != 1126 && (nint)obj10 != 1127 && (nint)obj10 != 1128 && (nint)obj10 != 1129 && (nint)obj10 != 1130 && (nint)obj10 != 1131 && (nint)obj10 != 1132 && (nint)obj10 != 1133 && (nint)obj10 != 1134 && (nint)obj10 != 1135 && (nint)obj10 != 1136 && (nint)obj10 != 1137 && (nint)obj10 != 1138 && (nint)obj10 != 1139 && (nint)obj10 != 1140 && (nint)obj10 != 1141 && (nint)obj10 != 1142 && (nint)obj10 != 1143 && (nint)obj10 != 1144 && (nint)obj10 != 1145 && (nint)obj10 != 1146 && (nint)obj10 != 1147 && (nint)obj10 != 1148 && (nint)obj10 != 1149 && (nint)obj10 != 1150 && (nint)obj10 != 1151 && (nint)obj10 != 1152 && (nint)obj10 != 1153 && (nint)obj10 != 1154 && (nint)obj10 != 1155 && (nint)obj10 != 1156 && (nint)obj10 != 1157 && (nint)obj10 != 1158 && (nint)obj10 != 1159 && (nint)obj10 != 1160 && (nint)obj10 != 1161 && (nint)obj10 != 1162 && (nint)obj10 != 1163 && (nint)obj10 != 1164 && (nint)obj10 != 1165 && (nint)obj10 != 1166 && (nint)obj10 != 1167 && (nint)obj10 != 1168 && (nint)obj10 != 1169 && (nint)obj10 != 1170 && (nint)obj10 != 1171 && (nint)obj10 != 1172 && (nint)obj10 != 1173 && (nint)obj10 != 1174 && (nint)obj10 != 1175 && (nint)obj10 != 1176 && (nint)obj10 != 1177 && (nint)obj10 != 1178 && (nint)obj10 != 1179 && (nint)obj10 != 1180 && (nint)obj10 != 1181 && (nint)obj10 != 1182 && (nint)obj10 != 1183 && (nint)obj10 != 1184 && (nint)obj10 != 1185 && (nint)obj10 != 1186 && (nint)obj10 != 1187 && (nint)obj10 != 1188 && (nint)obj10 != 1189 && (nint)obj10 != 1190 && (nint)obj10 != 1191 && (nint)obj10 != 1192 && (nint)obj10 != 1193 && (nint)obj10 != 1194 && (nint)obj10 != 1195 && (nint)obj10 != 1196 && (nint)obj10 != 1197 && (nint)obj10 != 1198 && (nint)obj10 != 1199 && (nint)obj10 != 1200 && (nint)obj10 != 1201 && (nint)obj10 != 1202 && (nint)obj10 != 1203 && (nint)obj10 != 1204 && (nint)obj10 != 1205 && (nint)obj10 != 1206 && (nint)obj10 != 1207 && (nint)obj10 != 1208 && (nint)obj10 != 1209 && (nint)obj10 != 1210 && (nint)obj10 != 1211 && (nint)obj10 != 1212 && (nint)obj10 != 1213 && (nint)obj10 != 1214 && (nint)obj10 != 1215 && (nint)obj10 != 1216 && (nint)obj10 != 1217 && (nint)obj10 != 1218 && (nint)obj10 != 1219 && (nint)obj10 != 1220 && (nint)obj10 != 1221 && (nint)obj10 != 1222 && (nint)obj10 != 1223 && (nint)obj10 != 1224 && (nint)obj10 != 1225 && (nint)obj10 != 1226 && (nint)obj10 != 1227 && (nint)obj10 != 1228 && (nint)obj10 != 1229 && (nint)obj10 != 1230 && (nint)obj10 != 1231 && (nint)obj10 != 1232 && (nint)obj10 != 1233 && (nint)obj10 != 1234 && (nint)obj10 != 1235 && (nint)obj10 != 1236 && (nint)obj10 != 1237 && (nint)obj10 != 1238 && (nint)obj10 != 1239 && (nint)obj10 != 1240 && (nint)obj10 != 1241 && (nint)obj10 != 1242 && (nint)obj10 != 1243 && (nint)obj10 != 1244 && (nint)obj10 != 1245 && (nint)obj10 != 1246 && (nint)obj10 != 1247 && (nint)obj10 != 1248 && (nint)obj10 != 1249 && (nint)obj10 != 1250 && (nint)obj10 != 1251 && (nint)obj10 != 1252 && (nint)obj10 != 1253 && (nint)obj10 != 1254 && (nint)obj10 != 1255 && (nint)obj10 != 1256 && (nint)obj10 != 1257 && (nint)obj10 != 1258 && (nint)obj10 != 1259 && (nint)obj10 != 1260 && (nint)obj10 != 1261 && (nint)obj10 != 1262 && (nint)obj10 != 1263 && (nint)obj10 != 1264 && (nint)obj10 != 1265 && (nint)obj10 != 1266 && (nint)obj10 != 1267 && (nint)obj10 != 1268 && (nint)obj10 != 1269 && (nint)obj10 != 1270 && (nint)obj10 != 1271 && (nint)obj10 != 1272 && (nint)obj10 != 1273 && (nint)obj10 != 1274 && (nint)obj10 != 1275 && (nint)obj10 != 1276 && (nint)obj10 != 1277 && (nint)obj10 != 1278 && (nint)obj10 != 1279 && (nint)obj10 != 1280 && (nint)obj10 != 1281 && (nint)obj10 != 1282 && (nint)obj10 != 1283 && (nint)obj10 != 1284 && (nint)obj10 != 1285 && (nint)obj10 != 1286 && (nint)obj10 != 1287 && (nint)obj10 != 1288 && (nint)obj10 != 1289 && (nint)obj10 != 1290 && (nint)obj10 != 1291 && (nint)obj10 != 1292 && (nint)obj10 != 1293 && (nint)obj10 != 1294 && (nint)obj10 != 1295 && (nint)obj10 != 1296 && (nint)obj10 != 1297 && (nint)obj10 != 1298 && (nint)obj10 != 1299 && (nint)obj10 != 1300 && (nint)obj10 != 1301 && (nint)obj10 != 1302 && (nint)obj10 != 1303 && (nint)obj10 != 1304 && (nint)obj10 != 1305 && (nint)obj10 != 1306 && (nint)obj10 != 1307 && (nint)obj10 != 1308 && (nint)obj10 != 1309 && (nint)obj10 != 1310 && (nint)obj10 != 1311 && (nint)obj10 != 1312 && (nint)obj10 != 1313 && (nint)obj10 != 1314 && (nint)obj10 != 1315 && (nint)obj10 != 1316 && (nint)obj10 != 1317 && (nint)obj10 != 1318 && (nint)obj10 != 1319 && (nint)obj10 != 1320 && (nint)obj10 != 1321 && (nint)obj10 != 1322 && (nint)obj10 != 1323 && (nint)obj10 != 1324 && (nint)obj10 != 1325 && (nint)obj10 != 1326 && (nint)obj10 != 1327 && (nint)obj10 != 1328 && (nint)obj10 != 1329 && (nint)obj10 != 1330 && (nint)obj10 != 1331 && (nint)obj10 != 1332 && (nint)obj10 != 1333 && (nint)obj10 != 1334 && (nint)obj10 != 1335 && (nint)obj10 != 1336 && (nint)obj10 != 1337 && (nint)obj10 != 1338 && (nint)obj10 != 1339 && (nint)obj10 != 1340 && (nint)obj10 != 1341 && (nint)obj10 != 1342 && (nint)obj10 != 1343 && (nint)obj10 != 1344 && (nint)obj10 != 1345 && (nint)obj10 != 1346 && (nint)obj10 != 1347 && (nint)obj10 != 1348 && (nint)obj10 != 1349 && (nint)obj10 != 1350 && (nint)obj10 != 1351 && (nint)obj10 != 1352 && (nint)obj10 != 1353 && (nint)obj10 != 1354 && (nint)obj10 != 1355 && (nint)obj10 != 1356 && (nint)obj10 != 1357 && (nint)obj10 != 1358 && (nint)obj10 != 1359 && (nint)obj10 != 1360 && (nint)obj10 != 1361 && (nint)obj10 != 1362 && (nint)obj10 != 1363 && (nint)obj10 != 1364 && (nint)obj10 != 1365 && (nint)obj10 != 1366 && (nint)obj10 != 1367 && (nint)obj10 != 1368 && (nint)obj10 != 1369 && (nint)obj10 != 1370 && (nint)obj10 != 1371 && (nint)obj10 != 1372 && (nint)obj10 != 1373 && (nint)obj10 != 1374 && (nint)obj10 != 1375 && (nint)obj10 != 1376 && (nint)obj10 != 1377 && (nint)obj10 != 1378 && (nint)obj10 != 1379 && (nint)obj10 != 1380 && (nint)obj10 != 1381 && (nint)obj10 != 1382 && (nint)obj10 != 1383 && (nint)obj10 != 1384 && (nint)obj10 != 1385 && (nint)obj10 != 1386 && (nint)obj10 != 1387 && (nint)obj10 != 1388 && (nint)obj10 != 1389 && (nint)obj10 != 1390 && (nint)obj10 != 1391 && (nint)obj10 != 1392 && (nint)obj10 != 1393 && (nint)obj10 != 1394 && (nint)obj10 != 1395 && (nint)obj10 != 1396 && (nint)obj10 != 1397 && (nint)obj10 != 1398 && (nint)obj10 != 1399 && (nint)obj10 != 1400 && (nint)obj10 != 1401 && (nint)obj10 != 1402 && (nint)obj10 != 1403 && (nint)obj10 != 1404 && (nint)obj10 != 1405 && (nint)obj10 != 1406 && (nint)obj10 != 1407 && (nint)obj10 != 1408 && (nint)obj10 != 1409 && (nint)obj10 != 1410 && (nint)obj10 != 1411 && (nint)obj10 != 1412 && (nint)obj10 != 1413 && (nint)obj10 != 1414 && (nint)obj10 != 1415 && (nint)obj10 != 1416 && (nint)obj10 != 1417 && (nint)obj10 != 1418 && (nint)obj10 != 1419 && (nint)obj10 != 1420 && (nint)obj10 != 1421 && (nint)obj10 != 1422 && (nint)obj10 != 1423 && (nint)obj10 != 1424 && (nint)obj10 != 1425 && (nint)obj10 != 1426 && (nint)obj10 != 1427 && (nint)obj10 != 1428 && (nint)obj10 != 1429 && (nint)obj10 != 1430 && (nint)obj10 != 1431 && (nint)obj10 != 1432 && (nint)obj10 != 1433 && (nint)obj10 != 1434 && (nint)obj10 != 1435 && (nint)obj10 != 1436 && (nint)obj10 != 1437 && (nint)obj10 != 1438 && (nint)obj10 != 1439 && (nint)obj10 != 1440 && (nint)obj10 != 1441 && (nint)obj10 != 1442 && (nint)obj10 != 1443 && (nint)obj10 != 1444 && (nint)obj10 != 1445 && (nint)obj10 != 1446 && (nint)obj10 != 1447 && (nint)obj10 != 1448 && (nint)obj10 != 1449 && (nint)obj10 != 1450 && (nint)obj10 != 1451 && (nint)obj10 != 1452 && (nint)obj10 != 1453 && (nint)obj10 != 1454 && (nint)obj10 != 1455 && (nint)obj10 != 1456 && (nint)obj10 != 1457 && (nint)obj10 != 1458 && (nint)obj10 != 1459 && (nint)obj10 != 1460 && (nint)obj10 != 1461 && (nint)obj10 != 1462 && (nint)obj10 != 1463 && (nint)obj10 != 1464 && (nint)obj10 != 1465 && (nint)obj10 != 1466 && (nint)obj10 != 1467 && (nint)obj10 != 1468 && (nint)obj10 != 1469 && (nint)obj10 != 1470 && (nint)obj10 != 1471 && (nint)obj10 != 1472 && (nint)obj10 != 1473 && (nint)obj10 != 1474 && (nint)obj10 != 1475 && (nint)obj10 != 1476 && (nint)obj10 != 1477 && (nint)obj10 != 1478 && (nint)obj10 != 1479 && (nint)obj10 != 1480 && (nint)obj10 != 1481 && (nint)obj10 != 1482 && (nint)obj10 != 1483 && (nint)obj10 != 1484 && (nint)obj10 != 1485 && (nint)obj10 != 1486 && (nint)obj10 != 1487 && (nint)obj10 != 1488 && (nint)obj10 != 1489 && (nint)obj10 != 1490 && (nint)obj10 != 1491 && (nint)obj10 != 1492 && (nint)obj10 != 1493 && (nint)obj10 != 1494 && (nint)obj10 != 1495 && (nint)obj10 != 1496 && (nint)obj10 != 1497 && (nint)obj10 != 1498 && (nint)obj10 != 1499 && (nint)obj10 != 1500 && (nint)obj10 != 1501 && (nint)obj10 != 1502 && (nint)obj10 != 1503 && (nint)obj10 != 1504 && (nint)obj10 != 1505 && (nint)obj10 != 1506 && (nint)obj10 != 1507 && (nint)obj10 != 1508 && (nint)obj10 != 1509 && (nint)obj10 != 1510 && (nint)obj10 != 1511 && (nint)obj10 != 1512 && (nint)obj10 != 1513 && (nint)obj10 != 1514 && (nint)obj10 != 1515 && (nint)obj10 != 1516 && (nint)obj10 != 1517 && (nint)obj10 != 1518 && (nint)obj10 != 1519 && (nint)obj10 != 1520 && (nint)obj10 != 1521 && (nint)obj10 != 1522 && (nint)obj10 != 1523 && (nint)obj10 != 1524 && (nint)obj10 != 1525 && (nint)obj10 != 1526 && (nint)obj10 != 1527 && (nint)obj10 != 1528 && (nint)obj10 != 1529 && (nint)obj10 != 1530 && (nint)obj10 != 1531 && (nint)obj10 != 1532 && (nint)obj10 != 1533 && (nint)obj10 != 1534 && (nint)obj10 != 1535 && (nint)obj10 == 1536)
					{
						nint num13 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2023 @ S0_v189 (Il2CppClass<SYBO.Subway.Game>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num14 = (nint)typeof(Game);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2028 @ S0_v195 (Il2CppClass<SYBO.Subway.Game>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool isInstantiated3 = Game.IsInstantiated;
						((Game)isInstantiated3).StartPogostick();
						return;
					}
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
			if ((nint)0 <= (nint)8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
				object obj16 = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
				if ((nint)0 == 1)
				{
					InventorySave.IncreaseAmount(UpgradeType.hoverboard, (int)"InRun");
					string privacyPolicyUrl3 = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl3).RunCompleted();
					string privacyPolicyUrl4 = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl4).AddScoreForPickup(true);
					((NewMonoBehaviour)27)._002Ector();
					return;
				}
				if ((nint)obj16 == 1)
				{
					nint num15 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ S0_v116 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num16 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1847 @ S0_v125 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated4 = Game.IsInstantiated;
					bool isInstantiated5 = Game.IsInstantiated;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1892 @ S1_v49 (System.Boolean)+8C]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1854 @ S0_v121 (System.Boolean)+8C]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1925 @ S1_v50+C]");
					((CharacterModifierCollection)num17).RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)0);
					string privacyPolicyUrl5 = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl5).MysteryBoxPickupsCollectedInrement();
					return;
				}
				if ((nint)obj16 != 2)
				{
					if ((nint)obj16 == 3)
					{
						nint num18 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1885 @ S0_v130 (Il2CppClass<SYBO.Subway.Game>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num19 = (nint)typeof(Game);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1917 @ S0_v139 (Il2CppClass<SYBO.Subway.Game>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool isInstantiated6 = Game.IsInstantiated;
						bool isInstantiated7 = Game.IsInstantiated;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1937 @ S1_v55 (System.Boolean)+8C]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1924 @ S0_v135 (System.Boolean)+8C]");
						nint num20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1946 @ S1_v56+10]");
						((CharacterModifierCollection)num20).RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)0);
						string privacyPolicyUrl6 = Globals.GetPrivacyPolicyUrl();
						((GameStats)(object)privacyPolicyUrl6).PogoStickPickupsCollectedIncrement();
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
					if ((nint)0 == 8)
					{
						nint num21 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1930 @ S0_v146 (Il2CppClass<SYBO.Subway.Game>)+BA]");
						object obj21 = (nint)0 & (nint)0x200;
						if (obj21 != null)
						{
							nint num22 = (nint)typeof(Game);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1939 @ S0_v152 (Il2CppClass<SYBO.Subway.Game>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool isInstantiated8 = Game.IsInstantiated;
						((Game)isInstantiated8).StartJetpack();
						return;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
				object obj22 = -16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v9+8]");
				if ((nint)0 == 16)
				{
					string privacyPolicyUrl7 = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl7).SuperMysteryBoxPickupsCollectedIncrement();
					nint num23 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1857 @ S0_v44 (Il2CppClass<RewardManager>)+BA]");
					object obj23 = (nint)0 & (nint)0x200;
					if (obj23 != null)
					{
						nint num24 = (nint)typeof(RewardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1898 @ S0_v51 (Il2CppClass<RewardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 vector2 = ((SSEventsPopup)4).VerifySettingOnline((string)null, (Vector3)0);
					string privacyPolicyUrl8 = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl8).AddScoreForPickup(true);
					return;
				}
				if ((nint)obj22 != 1 && (nint)obj22 != 2 && (nint)obj22 != 3 && (nint)obj22 != 4 && (nint)obj22 != 5 && (nint)obj22 != 6 && (nint)obj22 != 7 && (nint)obj22 != 8 && (nint)obj22 != 9 && (nint)obj22 != 10 && (nint)obj22 != 11 && (nint)obj22 != 12 && (nint)obj22 != 13 && (nint)obj22 != 14 && (nint)obj22 != 15)
				{
					if ((nint)obj22 == 16)
					{
						nint num25 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1951 @ S0_v56 (Il2CppClass<SYBO.Subway.Game>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num26 = (nint)typeof(Game);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1956 @ S0_v65 (Il2CppClass<SYBO.Subway.Game>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool isInstantiated9 = Game.IsInstantiated;
						bool isInstantiated10 = Game.IsInstantiated;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1966 @ S1_v29 (System.Boolean)+8C]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1963 @ S0_v61 (System.Boolean)+8C]");
						nint num27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1967 @ S1_v30+18]");
						((CharacterModifierCollection)num27).RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)0);
						string privacyPolicyUrl9 = Globals.GetPrivacyPolicyUrl();
						((GameStats)(object)privacyPolicyUrl9).HuntTokensCollectedIncrement();
						return;
					}
					if ((nint)obj22 != 17 && (nint)obj22 != 18 && (nint)obj22 != 19 && (nint)obj22 != 20 && (nint)obj22 != 21 && (nint)obj22 != 22 && (nint)obj22 != 23 && (nint)obj22 != 24 && (nint)obj22 != 25 && (nint)obj22 != 26 && (nint)obj22 != 27 && (nint)obj22 != 28 && (nint)obj22 != 29 && (nint)obj22 != 30 && (nint)obj22 != 31 && (nint)obj22 != 32 && (nint)obj22 != 33 && (nint)obj22 != 34 && (nint)obj22 != 35 && (nint)obj22 != 36 && (nint)obj22 != 37 && (nint)obj22 != 38 && (nint)obj22 != 39 && (nint)obj22 != 40 && (nint)obj22 != 41 && (nint)obj22 != 42 && (nint)obj22 != 43 && (nint)obj22 != 44 && (nint)obj22 != 45 && (nint)obj22 != 46 && (nint)obj22 != 47 && (nint)obj22 == 48)
					{
						nint num28 = (nint)typeof(MysteryPowerup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1971 @ S0_v70 (Il2CppClass<MysteryPowerup>)+BA]");
						object obj26 = (nint)0 & (nint)0x200;
						if (obj26 != null)
						{
							nint num29 = (nint)typeof(MysteryPowerup);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1977 @ S0_v103 (Il2CppClass<MysteryPowerup>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						List<Boards.BoardId> randomBoardList = MysteryPowerup.GetRandomBoardList();
						_ = 1;
						nint num30 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1988 @ S0_v77 (Il2CppClass<SYBO.Subway.Game>)+BA]");
						object obj27 = (nint)0 & (nint)0x200;
						if (obj27 != null)
						{
							nint num31 = (nint)typeof(Game);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1993 @ S0_v99 (Il2CppClass<SYBO.Subway.Game>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool isInstantiated11 = Game.IsInstantiated;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2000 @ S0_v82 (System.Boolean)+8C]");
						((CharacterModifierCollection)0).RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)(object)randomBoardList);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
						object obj28 = default;
						if (obj28 == null)
						{
							return;
						}
						nint num32 = (nint)typeof(Character);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2007 @ S0_v88 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
						object obj29 = (nint)0 & (nint)0x200;
						if (obj29 != null)
						{
							nint num33 = (nint)typeof(Character);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2012 @ S0_v95 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CharacterRendering instance2 = CharacterRendering.Instance;
						((ParticleSystem)(object)instance2.characterModelPrefab).Stop();
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ignoreJetpackZ @ L2 (SYBO.Subway.Pickups.PickupType)+C]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1819 @ S1_v14+8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void SetSpawnPointModeAndOriginalTo(SpawnPointMode spawnPointMode)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 108;
		obj = spawnPointMode;
	}

	private void SetWillIgnoreZPositionBeforeSpawnAndOriginalTo(bool willIgnoreZPositionBeforeSpawn)
	{
		_spawnPointModeOriginal = (willIgnoreZPositionBeforeSpawn ? SpawnPointMode.WillForcePickupType : SpawnPointMode.Normal);
		__spawnPointMode = (willIgnoreZPositionBeforeSpawn ? SpawnPointMode.WillForcePickupType : SpawnPointMode.Normal);
	}

	public void SetContainingRoute()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		DeactivateChild();
		__spawnPointState = SpawnPointState.UnspawnedAndAvailable;
		__spawnPointMode = _spawnPointModeOriginal;
		__forceSpawnPickupType = _forceSpawnPickupTypeOriginal;
		if (__spawnPointMode == SpawnPointMode.WillForcePickupType)
		{
			_willIgnoreZPositionBeforeSpawnOriginal = true;
		}
		object obj = this - -64;
		bool willIgnoreZPositionBeforeSpawnOriginal = _willIgnoreZPositionBeforeSpawnOriginal;
		obj = willIgnoreZPositionBeforeSpawnOriginal;
		_spawnPointDifficulty = _spawnPointDifficultyOriginal;
		_spawnPointHeight = _spawnPointHeightOriginal;
		object obj2 = this + 60;
		obj2 = 0;
	}

	public bool IsAvailableForSpawning(bool willShowDebugLog = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0042: Expected VT, but got Obj
		//IL_0062: Expected Obj, but got I4
		//IL_0073: Expected VT, but got Obj
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		Transform transform = default;
		object obj = transform + 24;
		obj = 0;
		_ = 0;
		Transform transform2 = (Transform)(transform + 12);
		GameObject gameObject = base.gameObject;
		transform2.position = (Vector3)gameObject;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		GameObject gameObject2 = ((Component)willShowDebugLog).gameObject;
		transform.position = (Vector3)gameObject2;
		object obj2 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D9CC");
		bool result = default;
		return result;
	}

	private bool IsStateAvailableForSpawning(bool willShowDebugLog = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		if (obj != null)
		{
			PickerType result;
			if (__spawnPointState != SpawnPointState.UnspawnedAndAvailable)
			{
				result = (PickerType)0;
			}
			else
			{
				TrackObject trackObject = _trackObject;
				result = ((~(trackObject._active ? 1u : 0u) == 0) ? ((PickerData)(object)this).PickerType : ((PickerType)0));
			}
			return (byte)result != 0;
		}
		if (__spawnPointState != SpawnPointState.UnspawnedAndAvailable)
		{
			return false;
		}
		TrackObject trackObject2 = _trackObject;
		if (~(trackObject2._active ? 1u : 0u) == 0)
		{
			if (IsZPositionToGameStartAcceptableBeforeSpawn)
			{
				IPicker itemAtIndex = ((PickerCollection)(object)this).GetItemAtIndex(willShowDebugLog ? 1 : 0);
				if (itemAtIndex != null)
				{
					if (IsZAvailableToJetpackState)
					{
						return (byte)((PickerData)(object)this).PickerType != 0;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private bool IsDistanceToCharacterAcceptableBeforeSpawn(bool willShowDebugLog = false)
	{
		return __spawnPointState == SpawnPointState.UnspawnedAndAvailable;
	}

	private void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 108;
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>();
		obj = componentsInParent;
	}

	public unsafe void SetSpawnPointForced(PickupType pickupType, SpawnPointDifficulty spawnPointDifficulty, bool willOffsetYPosition, bool willIgnoreZPositionBeforeSpawn, bool willIgnoreJetpackZ)
	{
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected VT, but got Unknown
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected VT, but got Unknown
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Expected Obj, but got Unknown
		//IL_096f: Expected Obj, but got I4
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected Obj, but got Unknown
		//IL_0992: Expected Obj, but got I4
		//IL_09a6: Expected Obj, but got I4
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected Obj, but got Unknown
		//IL_09bc: Expected Obj, but got I4
		//IL_09db: Expected Obj, but got I
		//IL_0bdc: Expected Obj, but got I4
		//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Expected Obj, but got Unknown
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Expected Obj, but got Unknown
		//IL_0c14: Expected Obj, but got I4
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c21: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected VT, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_0042: Expected Obj, but got F4
		//IL_0066: Expected native int or pointer, but got VT
		//IL_0078: Expected native int or pointer, but got VT
		//IL_0097: Invalid comparison between F4 and I4
		//IL_029c: Invalid comparison between F4 and I4
		//IL_017a: Expected Obj, but got I4
		//IL_018c: Expected F4, but got I4
		//IL_0187: Expected native int or pointer, but got VT
		//IL_073c: Expected F4, but got Obj
		//IL_0737: Expected native int or pointer, but got VT
		//IL_0751: Expected F4, but got I
		//IL_074c: Expected native int or pointer, but got VT
		//IL_0773: Expected Obj, but got I
		//IL_0781: Expected I, but got Obj
		//IL_0797: Expected Obj, but got I
		//IL_01a8: Expected F4, but got Obj
		//IL_01a3: Expected native int or pointer, but got VT
		//IL_01bd: Expected F4, but got I
		//IL_01b8: Expected native int or pointer, but got VT
		//IL_00c1: Expected Obj, but got I4
		//IL_00d2: Expected F4, but got Obj
		//IL_00cd: Expected native int or pointer, but got VT
		//IL_00e7: Expected F4, but got I
		//IL_00e2: Expected native int or pointer, but got VT
		//IL_0b04: Expected F4, but got Obj
		//IL_0aff: Expected native int or pointer, but got VT
		//IL_0b19: Expected F4, but got I
		//IL_0b14: Expected native int or pointer, but got VT
		//IL_0b26: Expected F4, but got I4
		//IL_0202: Expected Obj, but got I4
		//IL_0110: Expected F4, but got Obj
		//IL_010b: Expected native int or pointer, but got VT
		//IL_0125: Expected F4, but got I
		//IL_0120: Expected native int or pointer, but got VT
		//IL_080e: Expected F4, but got Obj
		//IL_0809: Expected native int or pointer, but got VT
		//IL_0823: Expected F4, but got I
		//IL_081e: Expected native int or pointer, but got VT
		//IL_0842: Expected F4, but got Obj
		//IL_083d: Expected native int or pointer, but got VT
		//IL_0857: Expected F4, but got I
		//IL_0852: Expected native int or pointer, but got VT
		//IL_0864: Expected F4, but got Obj
		//IL_085f: Expected native int or pointer, but got VT
		//IL_0879: Expected F4, but got I
		//IL_0874: Expected native int or pointer, but got VT
		//IL_07c2: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I4
		//IL_08bb: Expected I, but got Obj
		//IL_08d1: Expected Obj, but got I
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_0580: Expected Obj, but got I
		//IL_05ab: Expected Obj, but got I
		//IL_0b5a: Expected F4, but got Obj
		//IL_0b55: Expected native int or pointer, but got VT
		//IL_0b6f: Expected F4, but got I
		//IL_0b6a: Expected native int or pointer, but got VT
		//IL_0b7c: Expected F4, but got Obj
		//IL_0b77: Expected native int or pointer, but got VT
		//IL_0b91: Expected F4, but got I
		//IL_0b8c: Expected native int or pointer, but got VT
		//IL_0b9e: Expected F4, but got Obj
		//IL_0b99: Expected native int or pointer, but got VT
		//IL_0bb3: Expected F4, but got I
		//IL_0bae: Expected native int or pointer, but got VT
		//IL_05dc: Invalid comparison between F4 and I4
		//IL_08fc: Expected I, but got Obj
		//IL_047e: Invalid comparison between F4 and I4
		//IL_031d: Expected Obj, but got I4
		//IL_0610: Expected Obj, but got I4
		//IL_0a10: Expected Obj, but got I
		//IL_0a3b: Expected Obj, but got I
		//IL_0a52: Expected Obj, but got I4
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected I4, but got Unknown
		//IL_0a7a: Expected Obj, but got I4
		//IL_0a8a: Expected Obj, but got I
		//IL_04c1: Expected Obj, but got I
		//IL_04e5: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I
		//IL_0526: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 172);
		Vector3 vector2 = (Vector3)(obj + 152);
		object obj2 = obj + 120;
		obj2 = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 100;
		obj3 = 0;
		_ = 0;
		_ = 0;
		obj2 = pickupType;
		object obj4 = obj2 + 8;
		obj4 = willIgnoreJetpackZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupSpawnPoint)+BC]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v29+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupSpawnPoint)+BC]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S2_v65+C]");
			object obj7 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F5");
			obj3 = vector.x;
			_ = vector.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3)+10]");
			_ = 0;
			((Vector3*)(nint)vector2)->x = vector.x;
			((Vector3*)(nint)vector2)->z = vector.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3)+10]");
			_ = 0;
			if (vector2.x > (float)pickupType)
			{
				UnityEngine.Object format = UnityEngine.Object.Instantiate((UnityEngine.Object)_spawnPointModeOriginal);
				((Vector3*)(nint)vector)->x = (float)obj3;
				Vector3 vector3 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				((Vector3*)(nint)vector2)->x = (float)obj2;
				Vector3 vector4 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector3*)(nint)vector4)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object arg = default;
				object arg2 = default;
				string msg = string.Format((IFormatProvider)(object)"{0} enqueuing a build directive before already existing one. Existing: [{0}] New: [{1}]", (string)(object)format, arg, arg2);
				SDebug.LogFormat(msg, (object[])_spawnPointModeOriginal);
			}
		}
		object obj8 = (int)pickupType / 180;
		object obj9 = obj8 * 180;
		object obj10 = pickupType - obj9;
		bool flag = obj10 == null;
		object obj11 = (willIgnoreZPositionBeforeSpawn ? 1 : 0) ^ 1;
		object obj12 = flag | obj11;
		if (obj12 == null)
		{
			UnityEngine.Object format2 = UnityEngine.Object.Instantiate((UnityEngine.Object)_spawnPointModeOriginal);
			((Vector3*)(nint)vector)->x = 180f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Vector3 vector5 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object arg3 = default;
			object arg4 = default;
			string msg2 = string.Format((IFormatProvider)(object)"{0} enqueuing a build directive with position not multiple of MIN_CHUNK_LENGTH ({1}) - [{2}] ", (string)(object)format2, arg3, arg4);
			SDebug.LogFormat(msg2, (object[])_spawnPointModeOriginal);
		}
		Vector3 vector6 = (Vector3)(obj + 140);
		object obj13 = obj + 88;
		object obj14 = obj + 76;
		object obj15 = obj - -64;
		object obj16 = obj + 52;
		object obj17 = obj + 40;
		object obj18 = obj + 28;
		object obj19 = obj + 16;
		List<RouteBuilder> buildersAbove = ((RouteBuilder)(object)this).BuildersAbove;
		float maxBoundsSizeX = ((EnvironmentBackground)null).GetMaxBoundsSizeX((IEnumerable<MeshRenderer>)buildersAbove);
		if (maxBoundsSizeX > (float)pickupType)
		{
			if (!willIgnoreZPositionBeforeSpawn)
			{
				int spawnedLeadingEdgeWorldPositionZ = ((RouteBuilder)(object)this).SpawnedLeadingEdgeWorldPositionZ;
				if (spawnedLeadingEdgeWorldPositionZ > (int)pickupType)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					UnityEngine.Object obj20 = UnityEngine.Object.Instantiate((UnityEngine.Object)_spawnPointModeOriginal);
					throw new ArrayTypeMismatchException();
				}
			}
			else
			{
				while (true)
				{
					List<RouteBuilder> buildersAbove2 = ((RouteBuilder)(object)this).BuildersAbove;
					bool flag2 = ((RouteSection)(object)buildersAbove2).HasChunk((RouteChunk)null);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v111 (System.Boolean)+6C]");
					if ((nint)0 != 0)
					{
						break;
					}
					List<RouteBuilder> buildersAbove3 = ((RouteBuilder)(object)this).BuildersAbove;
					float maxBoundsSizeX2 = ((EnvironmentBackground)null).GetMaxBoundsSizeX((IEnumerable<MeshRenderer>)buildersAbove3);
					if (!(maxBoundsSizeX2 > (float)pickupType))
					{
						break;
					}
					List<RouteBuilder> buildersAbove4 = ((RouteBuilder)(object)this).BuildersAbove;
					do
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v146 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder>)+74]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S1_v139+C]");
						int index = (int)(-1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v146 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder>)+74]");
						RouteChunk routeChunk = ((List<RouteChunk>)0).get_Item(index);
						object obj22 = routeChunk._blockCount * 90;
						bool ignoreJetpackZ = (byte)(_ignoreJetpackZ - obj22) != 0;
						_ignoreJetpackZ = ignoreJetpackZ;
						((RouteBuilder)(object)this).RouteBuilder_OnCompletedLayingSections((object)routeChunk, (EventArgs)1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v146 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder>)+74]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S0_v156+C]");
					}
					while ((nint)0 >= (nint)1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupSpawnPoint)+B8]");
					bool flag3 = ((List<RouteSection>)0).Remove((RouteSection)(object)buildersAbove4);
					GameObject prefabPool = ((Component)(object)buildersAbove4).gameObject;
					nint num = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ S1_v150 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num2 = (nint)typeof(PoolManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S1_v155 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					PoolManager.AddPool((PrefabPool)(object)prefabPool);
				}
				object obj25 = this + 180;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupSpawnPoint)+B8]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S2_v26+C]");
				int index2 = (int)(-1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupSpawnPoint)+B8]");
				RouteSection routeSection = ((List<RouteSection>)0).get_Item(index2);
				obj25 = routeSection;
				List<RouteBuilder> buildersAbove5 = ((RouteBuilder)(object)this).BuildersAbove;
				float maxBoundsSizeX3 = ((EnvironmentBackground)null).GetMaxBoundsSizeX((IEnumerable<MeshRenderer>)buildersAbove5);
				if (maxBoundsSizeX3 > (float)pickupType)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					UnityEngine.Object obj27 = UnityEngine.Object.Instantiate((UnityEngine.Object)_spawnPointModeOriginal);
					throw new ArrayTypeMismatchException();
				}
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupSpawnPoint)+BC]");
		((List<RouteBuilder.BuildDirective>)0).Add((RouteBuilder.BuildDirective)vector);
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v64 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v102 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 back = Vector3.back;
		((Vector3*)(nint)vector)->x = (float)obj13;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v41+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		Vector3 vector9 = vector / (float)pickupType;
		obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v43+8]");
		_ = 0;
		Vector3 down = Vector3.down;
		((Vector3*)(nint)vector)->x = (float)obj16;
		Vector3 vector10 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v47+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		Vector3 vector11 = vector / 300f;
		((Vector3*)(nint)vector2)->x = (float)obj15;
		Vector3 vector12 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v45+8]");
		((Vector3*)(nint)vector12)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj17;
		Vector3 vector13 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v49+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		Vector3 vector14 = vector2 - vector;
		obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v51+8]");
		_ = 0;
		Color green = Color.green;
		nint num5 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v87 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num6 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v98 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector6)->x = (float)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v45+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj19;
		Vector3 vector15 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v53+8]");
		((Vector3*)(nint)vector15)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector16 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector16)->z = 0f;
		Debug.DrawRay(vector6, vector2, (Color)vector, 3000f);
	}

	public void Register()
	{
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_pickupRotate).FindKernel((string)null) != 0)
		{
			PickupRotate pickupRotate = _pickupRotate;
			if (~(pickupRotate._willRotate ? 1u : 0u) == 0)
			{
				float timeSinceLevelLoad = Time.timeSinceLevelLoad;
				((Coin)(object)_pickupRotate).MoveToMagnet(timeSinceLevelLoad);
			}
		}
	}

	public void Deregister()
	{
		if (this.m_OnRegistered != null)
		{
			this.m_OnRegistered(this);
		}
	}

	public void SpawnPickup(PickupData pickupData, PickerData pickerData)
	{
		//IL_000a: Expected I4, but got Obj
		//IL_0014: Expected I4, but got Obj
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		_forceSpawnPickupTypeOriginal = (PickupType)pickupData;
		__forceSpawnPickupType = (PickupType)pickupData;
		bool ignoreJetpackZ = (byte)(pickerData & 1) != 0;
		_ignoreJetpackZ = ignoreJetpackZ;
	}

	private void SpawnExistingPlaceholders()
	{
		DeactivateChild();
		if (this.m_OnDeregistered != null)
		{
			this.m_OnDeregistered(this);
		}
	}

	private void DeactivateAndDespawnChild()
	{
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I4
		PlaceholderLifecycle component = _spawnedPickupVisuals.GetComponent<PlaceholderLifecycle>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			PickupType pickupType = ((PickupData)(object)component).PickupType;
			List<Component> themedComponents = ((SynchronizedThemeAsset)pickupType).ThemedComponents;
			if (themedComponents == null)
			{
				component.Despawn();
			}
		}
	}

	private void DeactivateChild()
	{
		DespawnChild();
		MarkAsUnavailable();
	}

	private void DespawnChild()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02a4: Expected I, but got Obj
		//IL_02ba: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0147: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_spawnedPickupVisuals).FindKernel((string)null) == 0)
		{
			return;
		}
		if (_visualsTrackObjects == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<> list = default;
			((List<T>)(object)list)._002Ector((IEnumerable<T>)1);
			object obj6 = this + 104;
			obj6 = list;
		}
		_spawnedPickupVisuals.GetComponentsInParent<T>(true, (List<T>)(object)_visualsTrackObjects);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 103;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 103)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0377;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		goto IL_0377;
		IL_0377:
		throw new IndexOutOfRangeException();
	}

	public void MarkAsUnavailable()
	{
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected VT, but got Obj
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_spawnedPickupVisuals).FindKernel((string)null) != 0)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			int layer = _spawnedPickupVisuals.layer;
			((PickupManager)null).ResetPickupAndPickerLastPositions((PickupManager.ReasonToResetHistory)layer);
			object obj2 = this + 92;
			obj2 = 0;
		}
		__spawnPointState = SpawnPointState.Despawned;
		if (this.m_OnPickupDespawned != null)
		{
			this.m_OnPickupDespawned(this);
		}
	}

	private void DebugLog(string message)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		bool willIgnoreZPositionBeforeSpawnOriginal = (byte)(message & 1) != 0;
		_willIgnoreZPositionBeforeSpawnOriginal = willIgnoreZPositionBeforeSpawnOriginal;
		object obj = this - -64;
		object obj2 = message & 1;
		obj = obj2;
	}

	private void TrackObject_OnActivate()
	{
		if (__spawnPointState != SpawnPointState.UnspawnedAndAvailable)
		{
			SDebug.LogFormat("New value not acceptable. Don't call method in this situation.", null);
		}
		else
		{
			__spawnPointState = SpawnPointState.UnspawnedAndUnavailable;
		}
	}

	private void TrackObject_OnDeactivate()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0018: Expected Obj, but got VT
		SetContainingRoute();
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((PickupManager)val).DeregisterPickupSpawnPoint(this);
		}
	}

	public void TriggerCollisionWithCharacter(CharacterPickupParticles characterPickupParticles)
	{
		//IL_000e: Expected VT, but got Obj
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		}
	}

	public PickupSpawnPoint()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0018: Expected Obj, but got VT
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((PickupManager)val).Despawn((Transform)(object)this);
		}
	}
}
