namespace WeeklyHunt;

public class WeeklyHuntIconPositioning : MonoBehaviour
{
	public enum IconPlacement
	{
		NotSet = 0,
		FrontUIButton = 1,
		CelebrationPopup = 2,
		WeeklyHuntPopupActive = 3,
		WeeklyHuntPopupInactive = 4,
		SlideIn = 5,
		IngameCounter = 6,
		IngameCounterBackground = 7,
		WeeklyHuntPageProgress = 8,
	}

	private IconPlacement _placement; //Field offset: 0xC
	private bool RUN_ONCE; //Field offset: 0x10
	private int CELEBRATION_POPUP_ICON_PADDING; //Field offset: 0x14
	private float CELEBRATION_POPUP_ICON_Y_OFFSET; //Field offset: 0x18
	private Vector3 PAGE_ICON_POSITION; //Field offset: 0x1C
	private Vector3 INGAME_COUNTER_ICON_POSITION; //Field offset: 0x28
	private Vector3 INGAME_COUNTER_BACKGROUND_POSITION; //Field offset: 0x34
	private Vector3 SLIDEIN_ICON_POSITION; //Field offset: 0x40
	private int HEIGHT_PAGE_PROGRESS; //Field offset: 0x4C
	private int HEIGHT_INGAME; //Field offset: 0x50
	private int HEIGHT_SLIDE_IN; //Field offset: 0x54
	private int HEIGHT_CELEBRATION_POPUP; //Field offset: 0x58

	public WeeklyHuntIconPositioning() { }

	private void Awake() { }

	public void ForceUpdate() { }

	private void SetPosition() { }

	private void SetSize() { }

	private void Update() { }

}

