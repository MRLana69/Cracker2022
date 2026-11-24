//Type is in global namespace

public class UIPowerupHelper : MonoBehaviour
{
	private enum FadeTarget
	{
		white = 0,
		green = 1,
		darkgreen = 2,
		none = 3,
	}

	private const float COLOR_CHANGE_SPEED = 8.2343; //Field offset: 0x0
	private const float AMOUNT_LABEL_HIGH_RES_OFFSET = 0.5; //Field offset: 0x0
	private UISlider slider; //Field offset: 0xC
	private UISprite sliderBG; //Field offset: 0x10
	private UISprite icon; //Field offset: 0x14
	private UISprite iconBG; //Field offset: 0x18
	private UISprite iconBGMystery; //Field offset: 0x1C
	private UILabel amountLabel; //Field offset: 0x20
	private UISprite foreground; //Field offset: 0x24
	private GameObject container; //Field offset: 0x28
	private Color originalColor; //Field offset: 0x2C
	private float sliderSteps; //Field offset: 0x3C
	private bool _amountLabelRepositioned; //Field offset: 0x40
	private IngameScreen _ingameScreen; //Field offset: 0x44
	private bool _inverse; //Field offset: 0x48
	private ActivePowerup _powerup; //Field offset: 0x4C
	private Color32[] _colorTargets; //Field offset: 0x50
	private FadeTarget currentFadeTarget; //Field offset: 0x54
	private FadeTarget oldFadeTarget; //Field offset: 0x58
	private Color storedColor; //Field offset: 0x5C
	private float lerpTime; //Field offset: 0x6C

	private IngameScreen ingameScreen
	{
		 get { } //Length: 126
	}

	public UIPowerupHelper() { }

	private void Awake() { }

	private void FadingToWhiteToGreenToDarkGreen(bool sendInverse) { }

	private IngameScreen get_ingameScreen() { }

	public float getSliderHeight() { }

	public int getSliderWidth() { }

	public void HidePowerupSlot() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void ReturnToNormal() { }

	public void setContainerPosition(float x, float y, float z) { }

	public void SetPowerupSlot(ActivePowerup powerup) { }

}

