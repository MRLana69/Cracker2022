namespace UI.Screens.UpgradeScreenInternal;

public class UITierHelper : MonoBehaviour
{
	public UIAtlas usedAtlas; //Field offset: 0xC
	private UpgradeType _type; //Field offset: 0x10
	private int _currentTier; //Field offset: 0x14

	public UITierHelper() { }

	private void AddActiveIndicator(UISprite parentSprite) { }

	public bool ResetTiers() { }

	public void SetupTiers(UpgradeType type) { }

}

