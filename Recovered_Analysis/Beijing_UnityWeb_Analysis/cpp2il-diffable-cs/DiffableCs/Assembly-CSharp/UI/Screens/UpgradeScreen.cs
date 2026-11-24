namespace UI.Screens;

public class UpgradeScreen : UIScreen
{
	private sealed class <ReadYPanelPosAfterFrames>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public int numberofFrames; //Field offset: 0x10
		public UpgradeScreen <>4__this; //Field offset: 0x14
		private int <frames>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 163
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ReadYPanelPosAfterFrames>d__24(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RefreshTable>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UpgradeScreen <>4__this; //Field offset: 0x10
		public bool isReturningFromCelebration; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 191
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RefreshTable>d__28(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public static bool forceScrollRearange; //Field offset: 0x0
	private static char[] SPLIT_CHARACTER; //Field offset: 0x4
	public GameObject ConsumablePrefab; //Field offset: 0x28
	public GameObject PermanentPrefab; //Field offset: 0x2C
	private UITable _table; //Field offset: 0x30
	private UIPanel _panel; //Field offset: 0x34
	private UIScrollView _parentDragPanel; //Field offset: 0x38
	public UIScrollBar scrollbar; //Field offset: 0x3C
	private UIWidget _outline; //Field offset: 0x40
	private GameObject listTitleComponent; //Field offset: 0x44
	public List<UpgradeHelper> cachedUpgradeHelpers; //Field offset: 0x48
	private UIScreenController _screenController; //Field offset: 0x4C
	private GameObject _bundlesButton; //Field offset: 0x50
	private bool _isReturningFromCelebration; //Field offset: 0x54
	private bool _facebookLoginRunning; //Field offset: 0x55
	public UpgradeType[] upgradeSingleUse; //Field offset: 0x58
	public UpgradeType[] upgradePermanent; //Field offset: 0x5C
	private bool _isSubscribedToChangedScreen; //Field offset: 0x60
	private IEventManager _activeEventManager; //Field offset: 0x64
	private float _uiPanelBoundsOffset; //Field offset: 0x68
	private float _scrollPanelStartY; //Field offset: 0x6C
	private bool _hasRefreshedTable; //Field offset: 0x70
	private bool _subscribedToEvents; //Field offset: 0x71
	private int _numberOfObjects; //Field offset: 0x74
	private int _indexExpanded; //Field offset: 0x78

	public int indexExpanded
	{
		 get { } //Length: 79
		 set { } //Length: 61
	}

	private static UpgradeScreen() { }

	public UpgradeScreen() { }

	private void AdjustForUIPanelBoundsOffset(Vector3 offset) { }

	private bool BundlesActiveInThisLocale() { }

	private void FillTable() { }

	public int get_indexExpanded() { }

	public override void Hide() { }

	public override void Init() { }

	private bool IsJackpotEventActive() { }

	public bool IsLastElementOpen() { }

	private GameObject MakeBuyable(UpgradeType upgradeType, bool permanent) { }

	private void MakeTableElementAlwaysVisible(GameObject go, int index) { }

	private void OnDestroy() { }

	private void OnProductRequestDone() { }

	public void OnScreenChanged(string screen) { }

	private void PopupClosed(string popupName) { }

	private IEnumerator ReadYPanelPosAfterFrames(int numberofFrames) { }

	private IEnumerator RefreshTable(bool isReturningFromCelebration) { }

	public void SaleEnded() { }

	public void set_indexExpanded(int value) { }

	private void SetScrollPanelYForTableElements() { }

	public override void Show() { }

	private void Start() { }

}

