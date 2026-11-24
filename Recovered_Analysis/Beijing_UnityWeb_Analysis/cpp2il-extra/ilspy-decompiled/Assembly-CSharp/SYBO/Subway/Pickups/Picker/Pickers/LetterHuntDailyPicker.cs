using Cpp2ILInjected;
using SYBO.Subway.Inputs;
using SYBO.Subway.Pickups.Pickers;
using UnityEngine;

namespace SYBO.Subway.Pickups.Picker.Pickers;

public class LetterHuntDailyPicker : BasePicker, IPicker
{
	void IPicker.Add(PickupManager pickupManager)
	{
		//IL_000f: Expected I4, but got Obj
		((InputEventArgs)(object)this)._002Ector((InputType)pickupManager, KeyCode.Space);
	}

	bool IPicker.UpdatePicker()
	{
		bool flag = _pickupManager.HasPickupDataForPickupType(PickupType.LetterHuntCharacter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3 (System.Boolean)+10]");
		if ((nint)0 == 0)
		{
			MaybeChooseSpawnPoint();
		}
		return true;
	}
}
