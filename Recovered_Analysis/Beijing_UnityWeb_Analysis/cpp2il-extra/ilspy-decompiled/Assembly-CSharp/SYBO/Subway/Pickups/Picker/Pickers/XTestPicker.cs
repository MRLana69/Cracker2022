using SYBO.Subway.Inputs;
using SYBO.Subway.Pickups.Pickers;
using UnityEngine;

namespace SYBO.Subway.Pickups.Picker.Pickers;

public class XTestPicker : BasePicker, IPicker
{
	private int _temp_totalSpawnByThisPicker;

	void IPicker.Add(PickupManager pickupManager)
	{
		//IL_000f: Expected I4, but got Obj
		((InputEventArgs)(object)this)._002Ector((InputType)pickupManager, KeyCode.Backspace);
	}

	bool IPicker.UpdatePicker()
	{
		MaybeChooseSpawnPoint();
		return true;
	}

	private bool MakeManyAndDontLetOtherPickersHaveATurn()
	{
		bool flag = TestToJustMake5();
		return false;
	}

	private bool TestToJustMake5()
	{
		MaybeChooseSpawnPoint();
		return false;
	}
}
