using Cpp2ILInjected;
using SYBO.Subway.Inputs;
using SYBO.Subway.Pickups.Pickers;
using UnityEngine;

namespace SYBO.Subway.Pickups.Picker.Pickers;

public class MysteryPowerupPicker : BasePicker, IPicker
{
	void IPicker.Add(PickupManager pickupManager)
	{
		//IL_000f: Expected I4, but got Obj
		((InputEventArgs)(object)this)._002Ector((InputType)pickupManager, (KeyCode)2);
	}

	bool IPicker.UpdatePicker()
	{
		bool flag = _pickupManager.HasPickupDataForPickupType(PickupType.LetterHuntDaily);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3 (System.Boolean)+10]");
		if ((nint)0 != 0)
		{
			return true;
		}
		MaybeChooseSpawnPoint();
		return false;
	}
}
