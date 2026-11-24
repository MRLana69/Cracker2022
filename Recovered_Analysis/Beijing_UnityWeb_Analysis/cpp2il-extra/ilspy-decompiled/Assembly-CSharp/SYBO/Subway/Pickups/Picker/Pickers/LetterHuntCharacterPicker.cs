using SYBO.Subway.Inputs;
using SYBO.Subway.Pickups.Pickers;
using UnityEngine;

namespace SYBO.Subway.Pickups.Picker.Pickers;

public class LetterHuntCharacterPicker : BasePicker, IPicker
{
	void IPicker.Add(PickupManager pickupManager)
	{
		//IL_000f: Expected I4, but got Obj
		((InputEventArgs)(object)this)._002Ector((InputType)pickupManager, (KeyCode)1);
	}

	bool IPicker.UpdatePicker()
	{
		MaybeChooseSpawnPoint();
		return true;
	}
}
