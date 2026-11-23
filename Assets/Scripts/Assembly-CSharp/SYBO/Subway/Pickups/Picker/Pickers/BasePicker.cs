using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Managers;
using SYBO.Subway.Pickups.Pickers;
using UnityEngine;

namespace SYBO.Subway.Pickups.Picker.Pickers;

public abstract class BasePicker : IPicker
{
	protected PickupManager _pickupManager;

	protected PickerData _pickerData;

	private List<PickupData> _filteredPickupDatas;

	private Action<PickerRemoveRequestEventArgs> m__onRemoveRequest;

	public int ExecutionOrder
	{
		get
		{
			PickerData pickerData = _pickerData;
			return pickerData._executionOrder;
		}
	}

	public float SpawnDistanceMinToPrevious
	{
		get
		{
			PickerData pickerData = _pickerData;
			return pickerData._spawnDistanceMinToPrevious;
		}
	}

	public float ProbabilityToSpawn
	{
		get
		{
			PickerData pickerData = _pickerData;
			return pickerData._probabilityToSpawn;
		}
	}

	public string Name
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			Enum obj = (Enum)(obj2 - 16);
			PickerData pickerData = _pickerData;
			_ = pickerData._pickerType;
			_ = -1;
			obj = (Enum)(object)typeof(PickerType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			return obj.ToString();
		}
	}

	event Action<PickerRemoveRequestEventArgs> IPicker.OnRemoveRequest
	{
		add
		{
			_onRemoveRequest += value;
		}
		remove
		{
			_onRemoveRequest -= value;
		}
	}

	protected event Action<PickerRemoveRequestEventArgs> _onRemoveRequest
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m__onRemoveRequest;
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
			object obj = this + 20;
			Delegate obj2 = this.m__onRemoveRequest;
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

	public void Add(PickupManager pickupManager)
	{
	}

	protected void AddProtected(PickupManager pickupManager, PickerType pickerType)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		_pickupManager = pickupManager;
		PickerData pickerDataForPickerType = _pickupManager.GetPickerDataForPickerType(pickerType);
		_pickerData = pickerDataForPickerType;
		if (_pickerData == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj2 = default;
			object obj = obj2 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S1_v8+BC] (should have been resolved before IL gen)");
			string text = default;
			string message = text + ".pickerData must be not-null. Fix immediately";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			UnityException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public bool UpdatePicker()
	{
		return true;
	}

	protected void UpdatePickerProtected(List<PickupSpawnPoint> populatedSpawnedPoints = null)
	{
		MaybeChooseSpawnPoint(populatedSpawnedPoints);
	}

	protected void MaybeChooseSpawnPoint(List<PickupSpawnPoint> populatedSpawnedPoints = null)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [52E3AC]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		if (DemoVideoModeManager.IsEnabled)
		{
			return;
		}
		int num = 0;
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
			if (pickupSpawnPoint.IsAvailableForSpawning())
			{
				PickupData pickupData = ((pickupSpawnPoint.__spawnPointMode != SpawnPointMode.WillForcePickupType) ? MaybeChoosePickupDataForSpawnPoint(pickupSpawnPoint) : _pickupManager.GetPickupDataForPickupType(pickupSpawnPoint.__forceSpawnPickupType));
				if (pickupData != null)
				{
					pickupSpawnPoint.SpawnPickup(pickupData, _pickerData);
					populatedSpawnedPoints?.Add(pickupSpawnPoint);
				}
			}
			int num2 = num + 1;
			num = num2;
		}
	}

	private PickupData MaybeChoosePickupDataForSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_008b: Expected Obj, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		float value = UnityEngine.Random.value;
		PickerData pickerData = _pickerData;
		bool flag = !(value < pickerData._probabilityToSpawn);
		PickupData result = null;
		if (!flag)
		{
			bool flag2 = pickerData.IsCompatibleWithSpawnPoint(pickupSpawnPoint);
			bool flag3 = !flag2;
			result = null;
			if (!flag3)
			{
				((List<T>)(object)_filteredPickupDatas).Clear();
				PickupManager pickupManager = _pickupManager;
				PickupData[] pickupData = pickupManager._pickupData;
				PickupData pickupData2 = null;
				while (pickupData.Length > (nint)pickupData2)
				{
					object obj = (object)pickupData2 << 2;
					object obj2 = (object)pickupData + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v15+10]");
					PickupData pickupData3 = (PickupData)0;
					NullReferenceException ex = new NullReferenceException();
					if (ex != null && pickupData3._spawnWeight > 0f && pickupData3._pickupEnabledState == PickupEnabledState.Enabled && pickupData3.IsCompatibleWithSpawnPoint(pickupSpawnPoint) && (~(Globals.DEBUG_DISABLE_JETPACK ? 1u : 0u) != 0 || pickupData3._pickupType != PickupType.JetPack))
					{
						_filteredPickupDatas.Add(pickupData3);
					}
					PickupData pickupData4 = (PickupData)(pickupData2 + 1);
					pickupData2 = pickupData4;
				}
				List<PickupData> filteredPickupDatas = _filteredPickupDatas;
				bool flag4 = filteredPickupDatas._size < 1;
				result = null;
				if (!flag4)
				{
					PickupData pickupData5 = ((BasePicker)null).ChoosePickupDataBasedUponWeight(_filteredPickupDatas);
					result = pickupData5;
				}
			}
		}
		return result;
	}

	protected PickupData ChoosePickupDataBasedUponWeight(List<PickupData> pickupDataList)
	{
		int num = 0;
		float num2 = default;
		float num3 = default;
		while (num < pickupDataList._size)
		{
			PickupData pickupData = pickupDataList.get_Item(num);
			num2 = num3 + pickupData._spawnWeight;
			int num4 = num + 1;
			num = num4;
		}
		float value = UnityEngine.Random.value;
		float num5 = value * num2;
		int num6 = 0;
		float num7 = default;
		PickupData result;
		while (true)
		{
			if (num6 < pickupDataList._size)
			{
				PickupData pickupData2 = pickupDataList.get_Item(num6);
				num7 += pickupData2._spawnWeight;
				bool flag = !(num5 > num7);
				result = pickupData2;
				if (flag)
				{
					break;
				}
				int num8 = num6 + 1;
				num6 = num8;
				continue;
			}
			result = null;
			break;
		}
		return result;
	}

	protected void TriggerOnRequestRemoval(PickerRemoveRequestEventArgs requestRemovalEvent)
	{
		Action<PickerRemoveRequestEventArgs> onRemoveRequest = this.m__onRemoveRequest;
		if (this.m__onRemoveRequest != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<SYBO.Subway.Pickups.Pickers.PickerRemoveRequestEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	protected BasePicker()
	{
		List<PickupData> list = default;
		list._002Ector();
		_filteredPickupDatas = list;
	}
}
