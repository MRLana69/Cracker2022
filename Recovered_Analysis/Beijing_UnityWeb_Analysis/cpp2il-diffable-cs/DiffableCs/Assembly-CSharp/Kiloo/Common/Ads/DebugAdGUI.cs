namespace Kiloo.Common.Ads;

public class DebugAdGUI : MonoBehaviour
{
	private const int DEFAULT_CLOSE_BUTTON_SIZE = 60; //Field offset: 0x0
	private const int VIDEO_LENGTH = 5; //Field offset: 0x0
	private const int DEFAULT_TEXT_FONT_SIZE = 20; //Field offset: 0x0
	private bool _showVideo; //Field offset: 0xC
	private bool _showInterstitial; //Field offset: 0xD
	private string _adProvider; //Field offset: 0x10
	private float _timeLeftForVideo; //Field offset: 0x14
	private int _closeButtonSize; //Field offset: 0x18
	private GUIStyle _interstitialGuiStyle; //Field offset: 0x1C
	private GUIStyle _videoGuiStyle; //Field offset: 0x20
	private string <adLocationID>k__BackingField; //Field offset: 0x24
	private Action finishedWatchingVideo; //Field offset: 0x28
	private Action<AdType> dismissedAd; //Field offset: 0x2C

	public event Action<AdType> dismissedAd
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action finishedWatchingVideo
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	public string adLocationID
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public DebugAdGUI() { }

	public void add_dismissedAd(Action<AdType> value) { }

	public void add_finishedWatchingVideo(Action value) { }

	private void Awake() { }

	private bool CloseButton() { }

	public string get_adLocationID() { }

	private Texture2D MakeTexture(int width, int height, Color color) { }

	private void OnGUI() { }

	public void remove_dismissedAd(Action<AdType> value) { }

	public void remove_finishedWatchingVideo(Action value) { }

	private void set_adLocationID(string value) { }

	public void SetGuiProperties(int closeButtonSize, int textFontSize) { }

	private void SetupInterstitialGuiStyle(GUIStyle baseGuiStyle) { }

	private void SetupVideoGuiStyle(GUIStyle baseGuiStyle) { }

	public void ShowInterstitial(string location, string adProvider) { }

	public void ShowVideo(string location, string adProvider) { }

}

