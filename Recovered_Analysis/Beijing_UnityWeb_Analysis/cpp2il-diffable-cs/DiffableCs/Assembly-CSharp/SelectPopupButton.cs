//Type is in global namespace

public class SelectPopupButton : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<string, string> <>9__21_0; //Field offset: 0x4
		public static Func<string, string> <>9__21_1; //Field offset: 0x8
		public static Func<string, string> <>9__23_0; //Field offset: 0xC
		public static Func<string, string> <>9__23_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <SetItems>b__21_0(string x) { }

		internal string <SetItems>b__21_1(string x) { }

		internal string <SetSelected>b__23_0(string x) { }

		internal string <SetSelected>b__23_1(string x) { }

	}

	private List<string> _options; //Field offset: 0xC
	private Dictionary<string, string> _actualOptions; //Field offset: 0x10
	public bool multiSelect; //Field offset: 0x14
	private UILabel _currentSelectedLabel; //Field offset: 0x18
	private List<string> _selectedItems; //Field offset: 0x1C
	private bool <returningFromSelect>k__BackingField; //Field offset: 0x20
	private string <value>k__BackingField; //Field offset: 0x24
	private Dictionary<string, string> <multipleValues>k__BackingField; //Field offset: 0x28
	public List<EventDelegate> onChange; //Field offset: 0x2C

	public Dictionary<string, string> multipleValues
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public bool returningFromSelect
	{
		 get { } //Length: 774
		private set { } //Length: 40
	}

	public string value
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public SelectPopupButton() { }

	private void Awake() { }

	public Dictionary<string, string> get_multipleValues() { }

	public bool get_returningFromSelect() { }

	public string get_value() { }

	private void NotifyOnChange() { }

	private void OnButtonClick() { }

	private void OnSelectPopupClosed(Dictionary<string, string> selectedItems) { }

	private void set_multipleValues(Dictionary<string, string> value) { }

	private void set_returningFromSelect(bool value) { }

	private void set_value(string value) { }

	public void SetItems(List<string> items, int selectedIndex = 0) { }

	public void SetItems(Dictionary<string, string> items) { }

	public void SetSelected(List<string> selected) { }

	public void SetSelected(Dictionary<string, string> selected) { }

	private void Start() { }

}

