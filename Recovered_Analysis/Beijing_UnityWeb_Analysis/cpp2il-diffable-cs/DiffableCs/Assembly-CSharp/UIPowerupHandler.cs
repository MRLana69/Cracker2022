//Type is in global namespace

public class UIPowerupHandler : MonoBehaviour
{
	private const int MAX_SHOWABLE_PROGRESS_BARS = 8; //Field offset: 0x0
	public GameObject PowerupPrefab; //Field offset: 0xC
	private int _screenOffset; //Field offset: 0x10
	private int _bottomOffset; //Field offset: 0x14
	private List<UIPowerupHelper> _powerupSlots; //Field offset: 0x18
	private bool _isPowerupButtonsShowing; //Field offset: 0x1C
	private int previousSlotAmountLastFrame; //Field offset: 0x20

	public UIPowerupHandler() { }

	private void DisablePowerupSlot(UIPowerupHelper slot) { }

	public int getNumberOfSpaces(int i) { }

	public float getSliderHights(int i, int slotPosition) { }

	private void HandleSlideInPowerUpHide() { }

	private void HandleSlideInPowerUpShow() { }

	private void InstantiatePowerupSlots(int amount) { }

	private void OnDestroy() { }

	private void ReanchorPowerupSlots() { }

	private void SetPowerupSlotContent(ActivePowerup powerup, int i) { }

	private void SetPowerupSlotPosition(int i) { }

	private void Start() { }

	private void Update() { }

}

