//Type is in global namespace

public class AwardCollectibleHelper : MonoBehaviour
{
	private const string GLOW_LOOP_ANIMATION = "MainCanGlow"; //Field offset: 0x0
	private const string GLOW_SHORT_ANIMATION = "MainCanGlowShort"; //Field offset: 0x0
	private static readonly Color32 SOCIAL_LOCK_CAN_COLOR; //Field offset: 0x0
	private UISprite _itemIconSprite; //Field offset: 0xC
	private GameObject _completeIcon; //Field offset: 0x10
	private GameObject _glitterOverlay; //Field offset: 0x14
	private UISprite _background; //Field offset: 0x18
	private GameObject _socialLockOverlay; //Field offset: 0x1C
	private GameObject _glowElement; //Field offset: 0x20

	private static AwardCollectibleHelper() { }

	public AwardCollectibleHelper() { }

	public void ActivateCanGlow(bool active) { }

	public void AddSocialLockCanOverlay(bool socialLock) { }

	public void ChangeCanColorForSocialLock(bool socialLock) { }

	public void SetupAwardCollectible(string backgroundToUse, string itemIconName, bool useGlitter, bool isItemCollected = false, bool animateStars = false) { }

}

