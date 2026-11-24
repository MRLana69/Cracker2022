using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using SYBO.Common.Utilities;
using SYBO.Common.Utilities.Flags;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Level;
using SYBO.Subway.Managers;
using SYBO.Subway.Pickups.Pickers;
using UnityEngine;

namespace SYBO.Subway.Pickups.Picker.Pickers;

public abstract class BasePicker : IPicker
{
	private Action<PickerRemoveRequestEventArgs> m__onRemoveRequest;

	protected PickupManager _pickupManager;

	protected PickerData _pickerData;

	private List<PickupData> _filteredPickupDatas;

	public int ExecutionOrder
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)this.m__onRemoveRequest;
		}
	}

	public float SpawnDistanceMinToPrevious
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Picker.Pickers.BasePicker)+1C]");
			return 0f;
		}
	}

	public float ProbabilityToSpawn
	{
		get
		{
			PickerData pickerData = _pickerData;
			return pickerData._spawnDistanceMinToPrevious;
		}
	}

	public string Name
	{
		get
		{
			//IL_0014: Expected Obj, but got I4
			PickerData pickerData = _pickerData;
			return (string)pickerData._executionOrder;
		}
	}

	protected event Action<PickerRemoveRequestEventArgs> _onRemoveRequest
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m__onRemoveRequest;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
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

	event Action<PickerRemoveRequestEventArgs> IPicker.OnRemoveRequest
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m__onRemoveRequest;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
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
			_onRemoveRequest -= value;
		}
	}

	public void Add(PickupManager pickupManager)
	{
		SYBO_002ESubway_002EPickups_002EPickers_002EIPicker_002EOnRemoveRequest += (Action<PickerRemoveRequestEventArgs>)(object)pickupManager;
	}

	protected unsafe void AddProtected(PickupManager pickupManager, PickerType pickerType)
	{
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected I4, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_003d: Expected VT, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_0269: Expected I, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I
		//IL_02cf: Expected I4, but got Obj
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02f9: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_00a6: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_00f3: Expected I, but got Obj
		//IL_0162: Expected I4, but got Obj
		//IL_017d: Expected VT, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I
		object obj = default;
		int num = obj + 40;
		BackgroundLayer backgroundLayer = (BackgroundLayer)(obj + 28);
		object obj2 = obj + 16;
		if (!((PickupSpawnPoint)this).IsStateAvailableForSpawning(false))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Picker.Pickers.BasePicker)+60]");
		((Collider)0).isTrigger = true;
		_ = 2;
		object obj3 = this + 60;
		obj3 = pickupManager;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pickupManager @ L1 (SYBO.Subway.Pickups.PickupManager)+C]");
		int layer = ((GameObject)0).layer;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v63 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		nint num4 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v36 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v59 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		backgroundLayer = (BackgroundLayer)obj2;
		BackgroundLayer backgroundLayer2 = backgroundLayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		backgroundLayer2.Name = (string)0;
		((int*)num)->m_value = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = this + 92;
		int num6 = ((EnvironmentBackground)null).UpdateMovingSingleObjects((List<BackgroundObject>)layer, backgroundLayer, num);
		obj6 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Picker.Pickers.BasePicker)+5C]");
		int layer2 = ((GameObject)0).layer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Picker.Pickers.BasePicker)+20]");
		int layer3 = ((GameObject)0).layer;
		Vector3 one2 = Vector3.one;
		((int*)num)->m_value = (int)backgroundLayer;
		_ = backgroundLayer.Name;
		HierarchyUtility.InstantiatePrefabList((List<GameObject>)layer2, (Transform)layer3, (Vector3)num);
		((PickupSpawnPoint)this).DeactivateAndDespawnChild();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Picker.Pickers.BasePicker)+64]");
		((TrackObject)0).Awake();
		object obj7 = this + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Picker.Pickers.BasePicker)+5C]");
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((GameObject)0).GetComponentsInChildren<T>(true);
		obj7 = componentsInChildren;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Picker.Pickers.BasePicker)+1C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	public bool UpdatePicker()
	{
		//IL_0021: Expected Obj, but got I4
		PickerData pickerData = _pickerData;
		object obj = pickerData._pickerType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	protected void UpdatePickerProtected(List<PickupSpawnPoint> populatedSpawnedPoints = null)
	{
	}

	protected void MaybeChooseSpawnPoint(List<PickupSpawnPoint> populatedSpawnedPoints = null)
	{
		TriggerOnRequestRemoval((PickerRemoveRequestEventArgs)(object)populatedSpawnedPoints);
	}

	private unsafe PickupData MaybeChoosePickupDataForSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Ref, but got Unknown
		//IL_01e6: Expected Ref, but got F4
		//IL_000e: Expected VT, but got Obj
		//IL_0017: Expected Ref, but got F4
		//IL_0032: Expected I4, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_0092: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_022b: Expected I, but got Obj
		//IL_0241: Expected Obj, but got I
		//IL_028b: Expected VT, but got Obj
		//IL_028b: Expected Obj, but got I4
		//IL_00d3: Expected I, but got Obj
		//IL_0196: Invalid comparison between I and F4
		//IL_01a4: Expected Obj, but got I4
		//IL_0120: Expected I, but got Obj
		object obj = default;
		ref float reference = ref *(float*)(obj + 12);
		reference = ref *(float*)0f;
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			reference = ref *(float*)0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v17 (T)+4C]");
			if (((Dictionary<int, float>)0).TryGetValue((int)this.m__onRemoveRequest, out reference))
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Picker.Pickers.BasePicker)+18]");
					bool flag = 0f < num7;
					return (PickupData)flag;
				}
				return (PickupData)1;
			}
			return (PickupData)1;
		}
		return null;
	}

	protected PickupData ChoosePickupDataBasedUponWeight(List<PickupData> pickupDataList)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I4
		//IL_00cf: Invalid comparison between VT and I4
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0175: Expected I, but got Obj
		//IL_018b: Expected Obj, but got I
		//IL_01a8: Expected I, but got Obj
		//IL_030f: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_01f4: Expected I, but got Obj
		//IL_021a: Expected I, but got Obj
		float time = Time.time;
		PickerData pickerData = _pickerData;
		if (!(pickerData._probabilityToSpawn > time))
		{
			return null;
		}
		PickupData pickupData = ((BasePicker)(object)_pickerData).MaybeChoosePickupDataForSpawnPoint((PickupSpawnPoint)(object)pickupDataList);
		if (pickupData != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
			PickupManager pickupManager = _pickupManager;
			object obj = pickupManager._pickupData + 12;
			object obj2 = default;
			object obj8 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				PickerData pickerData2 = _pickerData;
				object obj3 = pickupManager._pickupData + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				PickupData pickupData2 = (PickupData)obj5;
				_0021_00210 val = (_0021_00210)Enumerable.ElementAt<TSource>((IEnumerable<TSource>)pickerData2._pickupType, (int)pickupData2._pickupType);
				if (val != (_0021_00210)(object)0 && pickupData2._spawnWeight > 0f && pickupData2._pickupEnabledState == PickupEnabledState.Enabled && pickupData2.IsCompatibleWithSpawnPointDifficulty((PickupSpawnPoint)(object)pickupDataList))
				{
					nint num = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v51 (Il2CppClass<Globals>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					bool flag = obj6 == null;
					nint num2 = (nint)typeof(Globals);
					if (!flag)
					{
						nint num3 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v64 (Il2CppClass<Globals>)+74]");
						bool flag2 = (nint)0 == 0;
						bool flag3 = !flag2;
						num2 = (nint)typeof(Globals);
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num2 = (nint)typeof(Globals);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ L2_v3 (Il2CppMethodInfo)+5C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v56+1C]");
					if ((nint)0 == 0 || pickupData2._pickupType != PickupType.JetPack)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
					}
				}
				obj2 = obj8 + 1;
			}
			List<PickupData> filteredPickupDatas = _filteredPickupDatas;
			if (filteredPickupDatas._size > 0)
			{
				return (PickupData)(object)((AssetManager)null).GetEnvironmentBaseModel((EnvironmentBaseInfo)(object)_filteredPickupDatas);
			}
			return null;
		}
		return null;
	}

	protected void TriggerOnRequestRemoval(PickerRemoveRequestEventArgs requestRemovalEvent)
	{
		//IL_00b6: Expected Obj, but got I4
		//IL_00fe: Expected I4, but got Obj
		Character instance = Character.Instance;
		if ((object)instance != null)
		{
			return;
		}
		bool flag = requestRemovalEvent == null;
		int num = default;
		int num2 = default;
		while (true)
		{
			PickupManager pickupManager = _pickupManager;
			List<PickupSpawnPoint> pickupSpawnPoints = pickupManager._pickupSpawnPoints;
			if (num >= pickupSpawnPoints._size)
			{
				break;
			}
			PickupManager pickupManager2 = _pickupManager;
			PickupSpawnPoint pickupSpawnPoint = pickupManager2._pickupSpawnPoints.get_Item(num);
			if (pickupSpawnPoint.IsStateAvailableForSpawning(false))
			{
				PickupData pickupData;
				if (pickupSpawnPoint.__spawnPointMode == SpawnPointMode.WillForcePickupType)
				{
					bool flag2 = _pickupManager.HasPickupDataForPickupType(pickupSpawnPoint.__forceSpawnPickupType);
					pickupData = (PickupData)flag2;
				}
				else
				{
					pickupData = ChoosePickupDataBasedUponWeight((List<PickupData>)(object)pickupSpawnPoint);
				}
				if (pickupData != null)
				{
					((BasePicker)(object)pickupSpawnPoint).AddProtected((PickupManager)(object)pickupData, (PickerType)_pickerData);
					if (!flag)
					{
						((List<PickupSpawnPoint>)(object)requestRemovalEvent).Add(pickupSpawnPoint);
					}
				}
			}
			num = num2 + 1;
		}
	}

	protected unsafe BasePicker()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		//IL_0030: Expected Obj, but got I4
		FlagsHelper.SetEverything(ref *(PickupType*)(this + 16));
		_ = 0;
		_ = 1f;
		this.m__onRemoveRequest = (Action<PickerRemoveRequestEventArgs>)1;
		_filteredPickupDatas = null;
		_ = 0f;
	}
}
