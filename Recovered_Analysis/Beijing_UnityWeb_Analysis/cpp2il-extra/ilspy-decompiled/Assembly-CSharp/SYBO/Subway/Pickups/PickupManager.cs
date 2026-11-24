using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using SYBO.Components.Utilities;
using SYBO.Subway.Coins;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Placeholders;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Placeholders.PrefabProviders;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.UI;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.U2D;

namespace SYBO.Subway.Pickups;

public class PickupManager : SingletonMonoBehaviour<PickupManager>
{
	private enum ReasonToResetHistory
	{
		SESSION_STARTED,
		GAME_STARTED,
		RUN_STARTED
	}

	public class PickupEventArgs : EventArgs
	{
		public readonly PickupSpawnPoint SpawnPoint;

		public readonly PickupData PickupData;

		public readonly SpawnPointMode SpawnPointMode;

		public PickupEventArgs(PickupSpawnPoint spawnPoint, PickupData pickupData, SpawnPointMode spawnPointMode)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = pickupData;
			object obj2 = this + 12;
			obj2 = spawnPoint;
			SpawnPointMode = spawnPointMode;
		}
	}

	private const int PickerTypeShortNameLength = 8;

	private const int PickupTypeShortNameLength = 9;

	private const int DelayBeforeUpdatingPickerCollectionCountMax = 60;

	public static readonly float SpawnDistanceMinToCharacter;

	private EventHandler<PickupEventArgs> m_OnPickupSpawned;

	private EventHandler<PickupEventArgs> m_OnPickupDespawned;

	private EventHandler<PickupEventArgs> m_OnPickupCollected;

	private Action<PickupSpawnPoint> m_OnPickupSpawnPointRegistered;

	private Action<PickupSpawnPoint> m_OnPickupSpawnPointDeregistered;

	private Action<PickerRemovedEventArgs> m_OnPickerRemoved;

	private bool _willDebugLogPickers;

	private bool _willDebugLogPickupData;

	internal GameObject _pickupSpawnPointPrefab;

	private float _spawnDistanceMinToGameStart;

	internal PickupData[] _pickupData;

	public PickerData[] _pickerData;

	private List<PickupSpawnPoint> _pickupSpawnPoints;

	internal PickerCollection _pickerCollection;

	private int _delayBeforeUpdatingPickerCollectionCount;

	public readonly Dictionary<int, float> PickupLastSpawnZGamePosition;

	public readonly Dictionary<int, float> PickerLastSpawnZGamePosition;

	public float SpawnDistanceMinToGameStart
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)this.m_OnPickerRemoved;
		}
	}

	internal List<PickupSpawnPoint> PickupSpawnPointList
	{
		get
		{
			//IL_00c2: Expected I, but got Obj
			//IL_00d8: Expected Obj, but got I
			//IL_0106: Expected Obj, but got I
			//IL_0071: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupManager)+C]");
			UnityEngine.Object arg;
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
			{
				arg = (UnityEngine.Object)(object)"NA";
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupManager)+C]");
				arg = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupManager)+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			return (List<PickupSpawnPoint>)(object)string.Format((IFormatProvider)(object)"[PickupData (PickupType={0},PickupIconPrefab={1})]", format, arg);
		}
	}

	public bool WillDebugLogPickers
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_pickupSpawnPoints != 0;
		}
	}

	public bool WillDebugLogPickupData => _willDebugLogPickers;

	public event EventHandler<PickupEventArgs> OnPickupSpawned
	{
		add
		{
			//IL_000e: Expected VT, but got Obj
			if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
			{
				_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
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

	public event EventHandler<PickupEventArgs> OnPickupDespawned
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupSpawned;
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

	public event EventHandler<PickupEventArgs> OnPickupCollected
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

	public event Action<PickupSpawnPoint> OnPickupSpawnPointRegistered
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
			Delegate obj = this.m_OnPickupSpawnPointRegistered;
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

	public event Action<PickupSpawnPoint> OnPickupSpawnPointDeregistered
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupSpawnPointRegistered;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupSpawnPointDeregistered;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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

	public event Action<PickerRemovedEventArgs> OnPickerRemoved
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickupSpawnPointDeregistered;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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
			Delegate obj = this.m_OnPickerRemoved;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 36;
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

	protected override void SubclassInitialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95E4");
	}

	protected override void OnDestroy()
	{
		//IL_10d4: Expected Obj, but got I4
		//IL_10f1: Expected VT, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_110a: Unknown result type (might be due to invalid IL or missing references)
		//IL_110f: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got I
		//IL_0f12: Expected Obj, but got I
		//IL_0f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Expected Obj, but got Unknown
		//IL_0fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd9: Expected Obj, but got Unknown
		//IL_112c: Expected Obj, but got I
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_100f: Expected Obj, but got Unknown
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_106d: Expected Obj, but got Unknown
		//IL_0e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e96: Expected Obj, but got Unknown
		//IL_0ec7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Expected Obj, but got Unknown
		object obj = 0;
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.DynamicManagers, (Vector3)0);
		ResetPickupLastSpawnPositions(ReasonToResetHistory.SESSION_STARTED);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<PickupSpawnPoint> list = default;
		list._002Ector();
		object obj2 = this + 60;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PickerCollection pickerCollection = default;
		pickerCollection.Add((IPicker)this);
		object obj3 = this - -64;
		obj3 = pickerCollection;
		object obj4 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<PickerRemoveRequestEventArgs> action = default;
		object obj5 = action + 16;
		obj5 = this;
		((PickerCollection)obj4).OnPickerRemoveRequest -= action;
		object obj6 = _pickerData + 12;
		object obj21;
		IPicker iPicker = default;
		IPicker iPicker2 = default;
		IPicker iPicker3 = default;
		IPicker iPicker4 = default;
		IPicker iPicker5 = default;
		IPicker iPicker6 = default;
		IPicker iPicker7 = default;
		for (object obj7 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6); obj21 = obj7 + 1, obj7 = obj21)
		{
			object obj8 = _pickerData + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+C]");
			if ((nint)0 != 0)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+8]");
			if ((nint)0 > (nint)8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+8]");
				object obj12 = -16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+8]");
				if ((nint)0 == 16)
				{
					object obj13 = this - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
					((PickerCollection)obj13).Remove(iPicker);
					continue;
				}
				if ((nint)obj12 != 1 && (nint)obj12 != 2 && (nint)obj12 != 3 && (nint)obj12 != 4 && (nint)obj12 != 5 && (nint)obj12 != 6 && (nint)obj12 != 7 && (nint)obj12 != 8 && (nint)obj12 != 9 && (nint)obj12 != 10 && (nint)obj12 != 11 && (nint)obj12 != 12 && (nint)obj12 != 13 && (nint)obj12 != 14 && (nint)obj12 != 15)
				{
					if ((nint)obj12 == 16)
					{
						object obj14 = this - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
						((PickerCollection)obj14).Remove(iPicker2);
						continue;
					}
					if ((nint)obj12 != 17 && (nint)obj12 != 18 && (nint)obj12 != 19 && (nint)obj12 != 20 && (nint)obj12 != 21 && (nint)obj12 != 22 && (nint)obj12 != 23 && (nint)obj12 != 24 && (nint)obj12 != 25 && (nint)obj12 != 26 && (nint)obj12 != 27 && (nint)obj12 != 28 && (nint)obj12 != 29 && (nint)obj12 != 30 && (nint)obj12 != 31 && (nint)obj12 != 32 && (nint)obj12 != 33 && (nint)obj12 != 34 && (nint)obj12 != 35 && (nint)obj12 != 36 && (nint)obj12 != 37 && (nint)obj12 != 38 && (nint)obj12 != 39 && (nint)obj12 != 40 && (nint)obj12 != 41 && (nint)obj12 != 42 && (nint)obj12 != 43 && (nint)obj12 != 44 && (nint)obj12 != 45 && (nint)obj12 != 46 && (nint)obj12 != 47 && (nint)obj12 != 48 && (nint)obj12 != 49 && (nint)obj12 != 50 && (nint)obj12 != 51 && (nint)obj12 != 52 && (nint)obj12 != 53 && (nint)obj12 != 54 && (nint)obj12 != 55 && (nint)obj12 != 56 && (nint)obj12 != 57 && (nint)obj12 != 58 && (nint)obj12 != 59 && (nint)obj12 != 60 && (nint)obj12 != 61 && (nint)obj12 != 62 && (nint)obj12 != 63 && (nint)obj12 != 64 && (nint)obj12 != 65 && (nint)obj12 != 66 && (nint)obj12 != 67 && (nint)obj12 != 68 && (nint)obj12 != 69 && (nint)obj12 != 70 && (nint)obj12 != 71 && (nint)obj12 != 72 && (nint)obj12 != 73 && (nint)obj12 != 74 && (nint)obj12 != 75 && (nint)obj12 != 76 && (nint)obj12 != 77 && (nint)obj12 != 78 && (nint)obj12 != 79 && (nint)obj12 != 80 && (nint)obj12 != 81 && (nint)obj12 != 82 && (nint)obj12 != 83 && (nint)obj12 != 84 && (nint)obj12 != 85 && (nint)obj12 != 86 && (nint)obj12 != 87 && (nint)obj12 != 88 && (nint)obj12 != 89 && (nint)obj12 != 90 && (nint)obj12 != 91 && (nint)obj12 != 92 && (nint)obj12 != 93 && (nint)obj12 != 94 && (nint)obj12 != 95 && (nint)obj12 != 96 && (nint)obj12 != 97 && (nint)obj12 != 98 && (nint)obj12 != 99 && (nint)obj12 != 100 && (nint)obj12 != 101 && (nint)obj12 != 102 && (nint)obj12 != 103 && (nint)obj12 != 104 && (nint)obj12 != 105 && (nint)obj12 != 106 && (nint)obj12 != 107 && (nint)obj12 != 108 && (nint)obj12 != 109 && (nint)obj12 != 110 && (nint)obj12 != 111 && (nint)obj12 == 112)
					{
						object obj15 = this - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
						((PickerCollection)obj15).Remove(iPicker3);
						continue;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+8]");
				object obj16 = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+8]");
				if ((nint)0 == 1)
				{
					object obj17 = this - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
					((PickerCollection)obj17).Remove(iPicker4);
					continue;
				}
				if ((nint)obj16 == 1)
				{
					object obj18 = this - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
					((PickerCollection)obj18).Remove(iPicker5);
					continue;
				}
				if ((nint)obj16 != 2)
				{
					if ((nint)obj16 == 3)
					{
						object obj19 = this - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
						((PickerCollection)obj19).Remove(iPicker6);
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+8]");
					if ((nint)0 == 8)
					{
						object obj20 = this - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
						((PickerCollection)obj20).Remove(iPicker7);
						continue;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
	}

	protected void FixedUpdate()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
		object obj = this - -64;
		if (obj != null)
		{
			object obj2 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			PickupManager pickupManager = default;
			pickupManager.m_OnPickupDespawned = (EventHandler<PickupEventArgs>)0;
			object obj3 = pickupManager + 16;
			obj3 = this;
			((PickerCollection)obj2)._002Ector(pickupManager);
		}
	}

	public PickupData GetPickupDataForPickupType(PickupType pickupType)
	{
		//IL_0212: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_02de: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_00ea: Expected VT, but got Obj
		//IL_016e: Invalid comparison between I and F4
		//IL_01ac: Invalid comparison between I and F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupManager)+8]");
		PickupData result;
		if ((nint)0 == 8)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pickupType @ L1 (SYBO.Subway.Pickups.PickupType)+6C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				int num3 = 0;
				RouteBuilder routeBuilder = default;
				Transform transform = default;
				ConstrainingRouteBuilder constrainingRouteBuilder2 = default;
				while (true)
				{
					List<IConstrainingRouteBuilder> constrainingBuilders = routeBuilder._constrainingBuilders;
					bool flag = num3 >= constrainingBuilders._size;
					result = (PickupData)1;
					if (flag)
					{
						break;
					}
					IConstrainingRouteBuilder constrainingRouteBuilder = routeBuilder._constrainingBuilders.get_Item(num3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
					GameObject gameObject = ((Component)pickupType).gameObject;
					transform.position = (Vector3)gameObject;
					if (((RouteBuilder)constrainingRouteBuilder2)._buildersBelow.Contains(routeBuilder))
					{
						int rangeEndZ;
						if (((UnityEngine.Object)transform).m_CachedPtr != ((UnityEngine.Object)transform).m_CachedPtr)
						{
							rangeEndZ = int.MinValue;
						}
						else if ((float)(nint)((UnityEngine.Object)transform).m_CachedPtr < 2.1474836E+09f)
						{
							rangeEndZ = (((float)(nint)((UnityEngine.Object)transform).m_CachedPtr > -2.1474836E+09f) ? ((int)(nint)((UnityEngine.Object)transform).m_CachedPtr) : int.MinValue);
						}
						else
						{
							rangeEndZ = int.MinValue;
						}
						bool flag2 = constrainingRouteBuilder2.IsConstrainingEndAt(rangeEndZ);
						result = null;
						if (flag2)
						{
							break;
						}
					}
					int num4 = num3 + 1;
					num3 = num4;
				}
			}
			else
			{
				result = (PickupData)1;
			}
		}
		else
		{
			result = (PickupData)1;
		}
		return result;
	}

	public bool HasPickupDataForPickupType(PickupType pickupType)
	{
		//IL_0028: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00e0: Expected I4, but got Obj
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		bool result;
		if (_pickupData != null)
		{
			object obj = 0;
			while (true)
			{
				PickupData[] pickupData = _pickupData;
				bool flag = (nint)obj >= pickupData.Length;
				result = false;
				if (flag)
				{
					break;
				}
				object obj2 = _pickupData + 16;
				object obj3 = obj << 2;
				object obj4 = obj2 + obj3;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v12+8]");
				if ((nint)0 != (nint)pickupType)
				{
					object obj6 = obj + 1;
					obj = obj6;
					continue;
				}
				object obj7 = _pickupData + 16;
				object obj8 = obj << 2;
				object obj9 = obj7 + obj8;
				result = (byte)(int)obj9 != 0;
				break;
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	internal PickerData GetPickerDataForPickerType(PickerType pickerType)
	{
		//IL_0025: Expected Obj, but got I4
		bool flag = HasPickupDataForPickupType((PickupType)pickerType);
		bool flag2 = flag;
		return (PickerData)flag2;
	}

	private void UpdatePickerCollection(bool isForcedUpdate)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnPickerRemoved;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)isForcedUpdate);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 36;
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

	public void UpdatePickerCollectionForced()
	{
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!MergeLevelStartHelp.IsValidLoadedLevelNameForGameplay())
		{
			return;
		}
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v36 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v19 (System.Boolean)+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v20+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v28 (System.Boolean)+C4]");
		if ((nint)0 == 0)
		{
			RegisterPickupSpawnPoint(null);
		}
	}

	public void SetPickerState(PickerType pickerType, PickerEnabledState state)
	{
		//IL_02e8: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_0061: Expected I, but got Obj
		//IL_00e5: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I4
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_0126: Expected I, but got Obj
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_01d5: Expected I, but got Obj
		if (state != PickerEnabledState.Enabled)
		{
			TrackObject component = ((Component)pickerType).GetComponent<TrackObject>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				((List<TrackObject>)(object)this.m_OnPickupDespawned).Add(component);
			}
		}
		Sprite sprite = null;
		while (true)
		{
			int siblingIndex = ((Transform)pickerType).GetSiblingIndex();
			if ((nint)sprite >= siblingIndex)
			{
				break;
			}
			bool flag = ((SpriteAtlas)pickerType).CanBindTo(sprite);
			TrackObject component2 = ((Component)flag).GetComponent<TrackObject>();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				((List<TrackObject>)(object)this.m_OnPickupDespawned).Add(component2);
			}
			Placeholder component3 = ((Component)flag).GetComponent<Placeholder>();
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (component3 != null)
			{
				SetPickerState(flag ? PickerType.Default : ((PickerType)0), PickerEnabledState.Enabled);
			}
			Sprite sprite2 = (Sprite)(sprite + 1);
			sprite = sprite2;
		}
	}

	public void RegisterPickupSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_028d: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if ((object)pickupSpawnPoint != null)
		{
			_delayBeforeUpdatingPickerCollectionCount = 60;
		}
		if (++_delayBeforeUpdatingPickerCollectionCount <= 59)
		{
			return;
		}
		_delayBeforeUpdatingPickerCollectionCount = 0;
		object obj5 = this - -64;
		((PickerData)obj5)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 113;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 113)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				return;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void DeregisterPickupSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		if (!_pickupSpawnPoints.Contains(pickupSpawnPoint))
		{
			pickupSpawnPoint.Update();
			_pickupSpawnPoints.Add(pickupSpawnPoint);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj2 = default;
			object obj = obj2 + 16;
			obj = 0;
			throw new NullReferenceException();
		}
	}

	public GameObject SpawnPickupSpawnPoint()
	{
		//IL_0019: Expected Obj, but got I4
		bool willDebugLogPickupData = _willDebugLogPickupData;
		return (GameObject)willDebugLogPickupData;
	}

	public void Despawn(Transform transformToDespawn)
	{
		if (_pickupSpawnPoints.Contains((PickupSpawnPoint)(object)transformToDespawn))
		{
			bool flag = _pickupSpawnPoints.Remove((PickupSpawnPoint)(object)transformToDespawn);
		}
		((PickupSpawnPoint)(object)transformToDespawn).SpawnExistingPlaceholders();
	}

	public bool IsSpawned(Transform transformToDespawn)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0077: Expected I4, but got Obj
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		object obj = default;
		bool result;
		object obj5 = default;
		while (true)
		{
			PickerData[] pickerData = _pickerData;
			if ((nint)obj >= pickerData.Length)
			{
				result = false;
				break;
			}
			object obj2 = _pickerData + 16;
			object obj3 = obj << 2;
			object obj4 = obj2 + obj3;
			bool flag = (byte)(int)obj4 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v10 (System.Boolean)+8]");
			bool flag2 = 0 != (nint)transformToDespawn;
			bool flag3 = !flag2;
			result = flag;
			if (flag3)
			{
				break;
			}
			obj = obj5 + 1;
		}
		return result;
	}

	public GameObject Spawn(Transform transformToSpawn, Vector3 position, Quaternion rotation)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got VT
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
		object obj = gameObject + 24;
		obj = this;
		object obj2 = gameObject + 20;
		obj2 = transformToSpawn;
		object obj3 = gameObject + 16;
		obj3 = position;
		object obj4 = gameObject + 28;
		obj4 = rotation;
		return gameObject;
	}

	private void ResetPickupAndPickerLastPositions(ReasonToResetHistory reasonToResetHistory)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.AddPool((PrefabPool)reasonToResetHistory);
	}

	private void ResetPickupLastSpawnPositions(ReasonToResetHistory reasonToResetHistory)
	{
		//IL_0014: Expected Obj, but got I4
		ResetPickerLastSpawnPositions(reasonToResetHistory);
		PickerCollection_OnPickerRemoveRequest((PickerRemoveRequestEventArgs)reasonToResetHistory);
	}

	private void ResetPickerLastSpawnPositions(ReasonToResetHistory reasonToResetHistory)
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		object obj = _pickupData + 12;
		object obj13;
		for (object obj2 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj); obj13 = obj2 + 1, obj2 = obj13)
		{
			object obj3 = _pickupData + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5;
			object obj7 = reasonToResetHistory - 1;
			if (reasonToResetHistory != ReasonToResetHistory.GAME_STARTED)
			{
				if ((nint)obj7 != 1)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v15+1C]");
				if ((nint)0 != 0)
				{
					continue;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v15+1C]");
				if ((nint)0 != 1)
				{
					continue;
				}
			}
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S4_v5+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S4_v6+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x1F;
			object obj12 = obj11 + 22619;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S5_v2 (should have been resolved before IL gen)");
		}
	}

	public void Game_OnGameStarted()
	{
		//IL_000b: Expected Obj, but got I4
		RegisterPickupSpawnPoint((PickupSpawnPoint)1);
	}

	public unsafe void Game_OnRunStarted(bool wasPlayerRevived, bool revivedWithAds = false, bool adsWasAvailable = true, bool adsFailed = false)
	{
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected I4, but got Unknown
		//IL_0400: Expected Obj, but got I
		//IL_0412: Expected I, but got Obj
		//IL_0428: Expected Obj, but got I
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected I, but got Unknown
		//IL_046e: Expected I, but got Obj
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_00b4: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I4
		//IL_0503: Expected Obj, but got I4
		//IL_0168: Expected I, but got Obj
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01c5: Expected Obj, but got F4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0260: Expected Obj, but got F4
		//IL_02eb: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02ca: Expected Obj, but got F4
		//IL_0241: Expected Obj, but got I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0386: Expected Obj, but got F4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03ac: Expected Obj, but got I4
		//IL_03b5: Expected VT, but got Obj
		//IL_03c4: Expected Obj, but got VT
		object obj = default;
		bool flag = (byte)(obj + 4) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [wasPlayerRevived @ L1 (System.Boolean)+14]");
		Transform transform = ((List<Transform>)0).get_Item(0);
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v85 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(CombineableMeshGroup);
		nint num3 = (nint)(obj + 8);
		((IntPtr*)num3)->m_value = (void*)(nint)obj;
		object obj3 = this - -64;
		Type t = Type.internal_from_handle((IntPtr)num3);
		Component componentInParent = transform.GetComponentInParent(t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj4 = default;
		obj3 = obj4;
		object obj5 = this - -64;
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)obj5 != null)
		{
			((ModelSelectionPlaceholderLifecycle)(object)this).SpawnInstances((PlaceholderPrefabProviderBase)wasPlayerRevived, revivedWithAds, adsWasAvailable, adsFailed);
			return;
		}
		object obj7 = this - -64;
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v80 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj7).FindKernel((string)null) != 0)
		{
			object type = this - -64;
			Component[] componentsInChildrenBFS = SYBO.Common.Utilities.GameObjectUtil.GetComponentsInChildrenBFS((Component)_spawnDistanceMinToGameStart, (Type)type, flag);
			if (componentsInChildrenBFS != null)
			{
				bool value = ((bool*)(flag ? 1 : 0))->m_value;
				PickupData[] pickupData = _pickupData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v50 (System.Boolean)+8]");
				((SkinnedMeshRenderer)(object)pickupData).sharedMesh = (Mesh)0;
				bool value2 = ((bool*)(flag ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
				((Renderer)(object)_pickerData).shadowCastingMode = ShadowCastingMode.On;
				_pickupSpawnPoints = (List<PickupSpawnPoint>)1;
			}
			else
			{
				object type2 = this - -64;
				Component component = SYBO.Common.Utilities.GameObjectUtil.AddComponentIfMissing((Component)_spawnDistanceMinToGameStart, (Type)type2);
				if ((object)component != null)
				{
					object meshGroup = this - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num8 = 0;
					_ = 0;
					Action<ModelInfo> action = default;
					object obj9 = action + 16;
					obj9 = this;
					((MeshContainer)_spawnDistanceMinToGameStart).RemoveMeshGroupCombinedCallback((CombineableMeshGroup)meshGroup, action);
				}
				else
				{
					((ModelSelectionPlaceholderLifecycle)(object)this).SpawnInstances((PlaceholderPrefabProviderBase)wasPlayerRevived, true, adsWasAvailable, adsFailed);
					CombineableMesh[] componentsInChildren = GetComponentsInChildren<CombineableMesh>(includeInactive: true);
					if (componentsInChildren.Length != 0)
					{
						if (!adsWasAvailable && (object)_pickupSpawnPointPrefab == null)
						{
							object meshGroup2 = this - -64;
							((MeshContainer)_spawnDistanceMinToGameStart).NotifyMeshGroupCombineCanceled((CombineableMeshGroup)meshGroup2);
							object obj10 = this + 72;
							bool flag2 = ((PickupData)(object)this).IsCompatibleWithSpawnPoint((PickupSpawnPoint)(object)componentsInChildren);
							obj10 = flag2;
							_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
							((WorkLoadQueue)val).CancelWork((IEnumerator)PickupLastSpawnZGamePosition);
						}
						else
						{
							((ModelSelectionPlaceholderLifecycle)(object)this).UpdateToCombinedMesh((ModelInfo)(object)componentsInChildren);
						}
					}
				}
			}
		}
		PickerLastSpawnZGamePosition = (Dictionary<int, float>)adsWasAvailable;
	}

	private void PickerCollection_OnPickerRemoveRequest(PickerRemoveRequestEventArgs pickerRemoveRequestEvent)
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		object obj = _pickerData + 12;
		object obj13;
		for (object obj2 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj); obj13 = obj2 + 1, obj2 = obj13)
		{
			object obj3 = _pickerData + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5;
			object obj7 = pickerRemoveRequestEvent - 1;
			if ((nint)pickerRemoveRequestEvent != 1)
			{
				if ((nint)obj7 != 1)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v15+14]");
				if ((nint)0 != 0)
				{
					continue;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v15+14]");
				if ((nint)0 != 1)
				{
					continue;
				}
			}
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S4_v5+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S4_v6+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x1F;
			object obj12 = obj11 + 22619;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S5_v2 (should have been resolved before IL gen)");
		}
	}

	private void PickupSpawnPoint_OnPickupSpawned(PickupSpawnPoint pickupSpawnPoint, PickerData pickerData)
	{
		bool flag = IsSpawned((Transform)(object)pickupSpawnPoint);
	}

	private void PickupSpawnPoint_OnPickupCollected(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0057: Expected Obj, but got I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I
		object obj = this - -64;
		((PickerCollection)obj).IPicker_OnRemoveRequest((PickerRemoveRequestEventArgs)(nint)((UnityEngine.Object)pickupSpawnPoint).m_CachedPtr);
		if (this.m_OnPickerRemoved != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj3 = default;
			object obj2 = obj3 + 8;
			obj2 = (nint)((UnityEngine.Object)pickupSpawnPoint).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	private void PickupSpawnPoint_OnPickupDespawned(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_002e: Expected VT, but got Obj
		if (this.m_OnPickupCollected != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Coin.CoinMagnetMovement coinMagnetMovement = default;
			coinMagnetMovement._002Ector((Transform)(object)pickupSpawnPoint, (Vector3)pickupSpawnPoint._pickupData, (byte)pickupSpawnPoint.__spawnPointMode != 0);
			this.m_OnPickupCollected(this, (PickupEventArgs)(object)coinMagnetMovement);
		}
	}

	private void PickupSpawnPoint_OnRegistered(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_002e: Expected VT, but got Obj
		if (this.m_OnPickupDespawned != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Coin.CoinMagnetMovement coinMagnetMovement = default;
			coinMagnetMovement._002Ector((Transform)(object)pickupSpawnPoint, (Vector3)pickupSpawnPoint._pickupData, (byte)pickupSpawnPoint.__spawnPointMode != 0);
			this.m_OnPickupDespawned(this, (PickupEventArgs)(object)coinMagnetMovement);
		}
	}

	private void PickupSpawnPoint_OnDeregistered(PickupSpawnPoint pickupSpawnPoint)
	{
		if (this.m_OnPickupSpawnPointRegistered != null)
		{
			this.m_OnPickupSpawnPointRegistered(pickupSpawnPoint);
		}
	}

	private static int SortSpawnPointsClosestFirst(PickupSpawnPoint left, PickupSpawnPoint right)
	{
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = PoolManager.Spawn((Transform)(object)right);
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (UnityEngine.Transform)+C]");
			return ((nint)0 != 0) ? 1 : 0;
		}
		return 0;
	}

	public PickupManager()
	{
		ResetPickupLastSpawnPositions(ReasonToResetHistory.GAME_STARTED);
	}

	static PickupManager()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		Dictionary<GameObject, GameObject> nonRepeatableToLastPrefabDict = default;
		MultiplePlaceholderPrefabProvider._nonRepeatableToLastPrefabDict = nonRepeatableToLastPrefabDict;
	}
}
