namespace SYBO.Subway.Pickups.Pickers;

public class PickerCollection
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<IPicker> <>9__10_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <UpdatePickers>b__10_0(IPicker a, IPicker b) { }

	}

	private Action<PickerRemoveRequestEventArgs> OnPickerRemoveRequest; //Field offset: 0x8
	private List<IPicker> _iPickerList; //Field offset: 0xC
	private PickupManager _pickupManager; //Field offset: 0x10

	public event Action<PickerRemoveRequestEventArgs> OnPickerRemoveRequest
	{
		 add { } //Length: 109
		 remove { } //Length: 111
	}

	public PickerCollection(PickupManager pickupManager) { }

	public void Add(IPicker iPicker) { }

	public void add_OnPickerRemoveRequest(Action<PickerRemoveRequestEventArgs> value) { }

	public IPicker GetItemAtIndex(int i) { }

	public bool HasPickerOfType() { }

	private void IPicker_OnRemoveRequest(PickerRemoveRequestEventArgs pickerRemoveRequestEvent) { }

	public void Remove(IPicker iPicker) { }

	public void remove_OnPickerRemoveRequest(Action<PickerRemoveRequestEventArgs> value) { }

	public void UpdatePickers() { }

}

