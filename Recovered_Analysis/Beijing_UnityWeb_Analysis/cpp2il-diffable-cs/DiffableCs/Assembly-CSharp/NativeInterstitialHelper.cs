//Type is in global namespace

public class NativeInterstitialHelper : MonoBehaviour
{
	private const float COVER_ASPECT_RATIO = 1.9; //Field offset: 0x0
	private const string ADCHOICE_ONLINESETTINGS_KEY = "fb_adchoice_link"; //Field offset: 0x0
	private const string LANGUAGES_WITH_HEIGHT_ISSUES_REGEX = "\p{IsThai}"; //Field offset: 0x0
	private const string RTL_ALIGNED_ONLINESETTINGS_KEY = "native_adview_rtl_regex"; //Field offset: 0x0
	private const string RTL_ALIGNED_LANGUAGES_REGEX = "\p{IsArabic}|\p{IsHebrew}|\p{IsSyriac}|\p{IsThaana}"; //Field offset: 0x0
	private const float COVER_ASPECT_RATIO_BUFFER = 0.1; //Field offset: 0x0
	private const float ICON_ASPECT_RATIO_BUFFER = 0.1; //Field offset: 0x0
	private const float ICON_ASPECT_RATIO = 1; //Field offset: 0x0
	private UILabel _callToActionLabel; //Field offset: 0xC
	private UILabel _titleLabel; //Field offset: 0x10
	private UILabel _descriptionLabel; //Field offset: 0x14
	private UILabel _sponsoredLabel; //Field offset: 0x18
	private UITexture _iconTexture; //Field offset: 0x1C
	private UITexture _coverTexture; //Field offset: 0x20
	private Texture2D _icon; //Field offset: 0x24
	private Texture2D _cover; //Field offset: 0x28
	private Action onActionClicked; //Field offset: 0x2C
	private Action onExitClicked; //Field offset: 0x30
	private Action onAdShown; //Field offset: 0x34
	private Action onAdHidden; //Field offset: 0x38
	private int _spacing; //Field offset: 0x3C
	private Vector2 _savedLabelSize; //Field offset: 0x40

	public event Action onActionClicked
	{
		 add { } //Length: 2
		 remove { } //Length: 111
	}

	public event Action onAdHidden
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action onAdShown
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action onExitClicked
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public NativeInterstitialHelper() { }

	public void add_onActionClicked(Action value) { }

	public void add_onAdHidden(Action value) { }

	public void add_onAdShown(Action value) { }

	public void add_onExitClicked(Action value) { }

	private bool AdjustTextForLabel(string text, UILabel label, out string result, int minimumShownCharacters = 0) { }

	private void Awake() { }

	public void Hide() { }

	private void Log(string message) { }

	private void LogError(string message) { }

	private void LogWarning(string message) { }

	public void OnActionClick() { }

	public void OnAdChoiceClick() { }

	public void OnExitClick() { }

	public void remove_onActionClicked(Action value) { }

	public void remove_onAdHidden(Action value) { }

	public void remove_onAdShown(Action value) { }

	public void remove_onExitClicked(Action value) { }

	public void Show() { }

	private void Update() { }

	public bool UpdateAdObject(NativeInterstitialAdObject adObject) { }

	private void UpdateLabelSpacing(NativeInterstitialAdObject adObject) { }

	private void UpdateRTLLabels(NativeInterstitialAdObject adObject) { }

	private bool ValidateAdObject(NativeInterstitialAdObject adObject) { }

}

