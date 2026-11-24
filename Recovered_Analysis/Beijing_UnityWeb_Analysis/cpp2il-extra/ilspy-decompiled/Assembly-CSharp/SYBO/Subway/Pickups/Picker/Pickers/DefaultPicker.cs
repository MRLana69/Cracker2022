using Cpp2ILInjected;
using SYBO.Subway.Pickups.Pickers;

namespace SYBO.Subway.Pickups.Picker.Pickers;

public class DefaultPicker : BasePicker, IPicker
{
	public DefaultPicker()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 20;
		object obj2 = default;
		obj = obj2;
	}

	void IPicker.Add(PickupManager pickupManager)
	{
		if (base._onRemoveRequest != null)
		{
			base._onRemoveRequest((PickerRemoveRequestEventArgs)(object)pickupManager);
		}
	}

	bool IPicker.UpdatePicker()
	{
		return true;
	}
}
