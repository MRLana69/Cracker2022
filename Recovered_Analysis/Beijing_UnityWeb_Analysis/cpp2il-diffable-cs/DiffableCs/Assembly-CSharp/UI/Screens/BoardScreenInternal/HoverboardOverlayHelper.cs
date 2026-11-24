namespace UI.Screens.BoardScreenInternal;

public class HoverboardOverlayHelper : MonoBehaviour
{
	private sealed class <>c__DisplayClass29_0
	{
		public BoardId boardId; //Field offset: 0x8

		public <>c__DisplayClass29_0() { }

		internal bool <BoardHasFreeThemes>b__0(HoverboardTheme ht) { }

	}

	public BoardId _cachedBoardId; //Field offset: 0xC
	private bool _currentlySelected; //Field offset: 0x10
	private int _placementIndex; //Field offset: 0x14
	private Transform _trackerTransform; //Field offset: 0x18
	private Camera _3DClipCam; //Field offset: 0x1C
	private Camera _2DOverlayCam; //Field offset: 0x20
	private Transform _cachedTransform; //Field offset: 0x24
	private float _topOverlayMinX; //Field offset: 0x28
	private float _topOverlayMaxX; //Field offset: 0x2C
	private float _currentDistFromCenter; //Field offset: 0x30
	private bool _dirtyDist; //Field offset: 0x34
	private bool _hasEventBeenTried; //Field offset: 0x35
	private Nullable<BoardId> _eventBoardId; //Field offset: 0x38
	private Transform _topOverlay; //Field offset: 0x40
	private UISprite _newBubble; //Field offset: 0x44
	private UISprite _limitedBubble; //Field offset: 0x48
	private UISprite _limitedIcon; //Field offset: 0x4C
	private UISprite _giftBubble; //Field offset: 0x50
	private UISprite _eventBubble; //Field offset: 0x54
	private Transform _bottomOverlay; //Field offset: 0x58
	private UISprite _ownedSprite; //Field offset: 0x5C
	private UISprite _selectedSprite; //Field offset: 0x60
	private UISprite _trialSprite; //Field offset: 0x64

	public float currentDistFromCenter
	{
		 set { } //Length: 8
	}

	public HoverboardOverlayHelper() { }

	private bool BoardHasFreeThemes(BoardId boardId) { }

	private Nullable<BoardId> EventBoard() { }

	public BoardId GetBoardType() { }

	public int GetIndex() { }

	public void Init(int index, BoardId id, Transform transformToTrack) { }

	private bool IsBoardFree(BoardId boardId) { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void RefreshBottomIndicators() { }

	private void RefreshEvent() { }

	public void RefreshSelected(bool selected) { }

	public void SelectedInMenu() { }

	public void set_currentDistFromCenter(float value) { }

	private void Update() { }

}

