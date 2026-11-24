//Type is in global namespace

public class DebugSettingsHelper : MonoBehaviour
{
	private const string MOBVISTA_DISPLAY_TEXT = "MobVista"; //Field offset: 0x0
	private const string FACEBOOK_DISPLAY_TEXT = "Facebook"; //Field offset: 0x0
	private const string TAPJOY_DISPLAY_TEXT = "Tapjoy"; //Field offset: 0x0
	private const string INMOBI_DISPLAY_TEXT = "InMobi"; //Field offset: 0x0
	private const string VUNGLE_DISPLAY_TEXT = "Vungle"; //Field offset: 0x0
	private const string ADCOLONY_DISPLAY_TEXT = "AdColony"; //Field offset: 0x0
	private const string SUPERSONIC_DISPLAY_TEXT = "Supersonic"; //Field offset: 0x0
	private const string CHARTBOOST_DISPLAY_TEXT = "Chartboost"; //Field offset: 0x0
	private const string FLURRY_DISPLAY_TEXT = "Flurry"; //Field offset: 0x0
	private const string YEAH_MOBI_DISPLAY_TEXT = "YeahMobi"; //Field offset: 0x0
	public UILabel Title; //Field offset: 0xC
	public UILabel Description; //Field offset: 0x10
	public GameObject EventTesterIcon; //Field offset: 0x14
	public GameObject CelebrationTesterIcon; //Field offset: 0x18
	public GameObject SkipTutorialIcon; //Field offset: 0x1C
	public GameObject MemoryBenchmarkIcon; //Field offset: 0x20
	public GameObject FPSTestIcon; //Field offset: 0x24
	public GameObject WelcomePopupIcon; //Field offset: 0x28
	public GameObject WeeklyHuntIcon; //Field offset: 0x2C
	public GameObject AdSystemTesterIcon; //Field offset: 0x30
	public GameObject OffIcon; //Field offset: 0x34
	public GameObject OnIcon; //Field offset: 0x38
	public SelectPopupButton PopupList; //Field offset: 0x3C
	public UILabel PopupListTitle; //Field offset: 0x40
	private bool currentIconState; //Field offset: 0x44
	private DebugSetting _settingType; //Field offset: 0x48
	public bool multiSelect; //Field offset: 0x4C

	public DebugSettingsHelper() { }

	public void ExpandableListItemSelected() { }

	private List<string> GetCurrentlySelected() { }

	public void SetExpandableList(DebugSetting settingType) { }

	public void SetTesterIcon(ButtonIcon icon) { }

	public void SetToggleIcon(DebugSetting settingType) { }

	public void ToggleIcon() { }

	public void UpdateDescription(string description) { }

	public void UpdateTitle(string title) { }

}

