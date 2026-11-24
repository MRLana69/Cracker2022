namespace UI.Pages.WeeklyHuntPageInternal;

public class WeekCell : MonoBehaviour
{
	public class WeekCellPayload
	{
		public Action<PrizePeriodId> clicked; //Field offset: 0x8
		public PrizePeriodId periodId; //Field offset: 0xC

		public WeekCellPayload() { }

	}

	private UISprite _cellBG; //Field offset: 0xC
	private UISprite _dottedLine; //Field offset: 0x10
	private UILabel _weekLabel; //Field offset: 0x14
	private UILabel _statusLabel; //Field offset: 0x18
	private Collider _collider; //Field offset: 0x1C
	private int _inactiveBottomAnchorOffset; //Field offset: 0x20
	private int _activeBottomAnchorOffset; //Field offset: 0x24
	private Action<PrizePeriodId> _clickedAction; //Field offset: 0x28
	private PrizePeriodId _periodId; //Field offset: 0x2C

	public PrizePeriodId periodId
	{
		 get { } //Length: 941
	}

	public WeekCell() { }

	public PrizePeriodId get_periodId() { }

	public void Init(WeekCellPayload payload) { }

	public void OnClicked() { }

	public void SetCellActive(bool active) { }

	public void UpdateStatus() { }

}

