namespace SYBO.Subway.Pickups.Pickers;

public class PickerRemoveRequestEventArgs
{
	public IPicker IPicker
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public PickerRemoveRequestEventArgs(IPicker iPicker)
	{
		IPicker__BackingField = iPicker;
	}
}
