namespace UnityEngine.UI;

public class ToggleGroup : UIBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Toggle> <>9__12_0; //Field offset: 0x4
		public static Func<Toggle, bool> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ActiveToggles>b__13_0(Toggle x) { }

		internal bool <AnyTogglesOn>b__12_0(Toggle x) { }

	}

	private bool m_AllowSwitchOff; //Field offset: 0xC
	private List<Toggle> m_Toggles; //Field offset: 0x10

	public bool allowSwitchOff
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	protected ToggleGroup() { }

	public IEnumerable<Toggle> ActiveToggles() { }

	public bool AnyTogglesOn() { }

	public void EnsureValidState() { }

	public bool get_allowSwitchOff() { }

	public void NotifyToggleOn(Toggle toggle, bool sendCallback = true) { }

	public void RegisterToggle(Toggle toggle) { }

	public void set_allowSwitchOff(bool value) { }

	public void SetAllTogglesOff(bool sendCallback = true) { }

	protected override void Start() { }

	public void UnregisterToggle(Toggle toggle) { }

	private void ValidateToggleIsInGroup(Toggle toggle) { }

}

