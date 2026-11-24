//Type is in global namespace

public class AdSystemTesterCell : MonoBehaviour
{
	private const string MAIN_TEXT_COLOR = "[004A80FF]"; //Field offset: 0x0
	private const string SECONDARY_TEXT_COLOR = "[0374A5FF]"; //Field offset: 0x0
	private UILabel _statusLabel; //Field offset: 0xC
	private GameObject _successIcon; //Field offset: 0x10
	private AdLocationInfo _adLocation; //Field offset: 0x14

	public AdSystemTesterCell() { }

	public void Cache() { }

	private string GetProviderIDForLocation(string adLocationId) { }

	private void GiveDebugReward() { }

	public void Init(AdLocationInfo adLocation) { }

	private void OnCacheStateChanged(string location) { }

	private void OnCacheStateChanged(string location, bool wasAlreadyCached) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Show() { }

	private void UpdateStatusLabel(AdLocationInfo adLocation) { }

}

