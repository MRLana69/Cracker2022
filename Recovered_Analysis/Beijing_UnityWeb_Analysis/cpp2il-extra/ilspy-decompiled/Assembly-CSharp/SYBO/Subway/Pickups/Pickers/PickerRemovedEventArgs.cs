namespace SYBO.Subway.Pickups.Pickers;

public class PickerRemovedEventArgs : PickerRemoveRequestEventArgs
{
	public PickerRemovedEventArgs(IPicker iPicker)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = iPicker;
	}
}
