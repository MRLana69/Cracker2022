//Type is in global namespace

public class ScrollView : MonoBehaviour
{
	private sealed class <>c__DisplayClass83_0
	{
		public int dataIndex; //Field offset: 0x8

		public <>c__DisplayClass83_0() { }

		internal bool <SmoothScrollToIndex>b__0(Container item) { }

	}

	private sealed class <>c__DisplayClass85_0
	{
		public ScrollView <>4__this; //Field offset: 0x8
		public Action onFinished; //Field offset: 0xC

		public <>c__DisplayClass85_0() { }

		internal void <SmoothScrollToOffset>b__0() { }

	}

	private sealed class <>c__DisplayClass86_0
	{
		public int dataPosition1; //Field offset: 0x8
		public int dataPosition2; //Field offset: 0xC

		public <>c__DisplayClass86_0() { }

		internal bool <AnimateSwapPositions>b__0(Container T) { }

		internal bool <AnimateSwapPositions>b__1(Container T) { }

	}

	private sealed class <AnimateSwapPositions>d__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public int dataPosition1; //Field offset: 0x10
		public int dataPosition2; //Field offset: 0x14
		public ScrollView <>4__this; //Field offset: 0x18
		public float time; //Field offset: 0x1C
		private <>c__DisplayClass86_0 <>8__1; //Field offset: 0x20
		public Action onComplete; //Field offset: 0x24
		private Container <item1>5__2; //Field offset: 0x28
		private Container <item2>5__3; //Field offset: 0x2C
		private Vector3 <origin1>5__4; //Field offset: 0x30
		private Vector3 <origin2>5__5; //Field offset: 0x3C
		private float <timePassed>5__6; //Field offset: 0x48

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1229
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateSwapPositions>d__86(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum Arrangement
	{
		Vertical = 0,
		Horizontal = 1,
	}

	private enum BoundsCalculationMode
	{
		FullSize = 0,
		Incremental = 1,
	}

	private enum Infinite
	{
		None = 0,
		BothWays = 1,
	}

	private enum PullDownToRefreshState
	{
		None = 0,
		PullDown = 1,
		Refreshing = 2,
	}

	private class RecycleBin
	{
		public readonly List<Container> activeContainers; //Field offset: 0x8
		private readonly Dictionary<int, List<Container>> _scrapViews; //Field offset: 0xC

		public RecycleBin() { }

		public void AddScrapContainer(Container container) { }

		public void AddToActiveContainers(Container container, bool endOfList) { }

		public void Clear() { }

		public Container GetActiveContainer(int position) { }

		public Container GetScrapContainer(int modelType) { }

		public static void Log(string msg) { }

		public void ScrapActiveContainers() { }

	}

	public enum ScrollDirection
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3,
		Stationary = 4,
	}

	private const int PULL_TO_REFRESH_CONTAINER = -100; //Field offset: 0x0
	private Arrangement _arrangement; //Field offset: 0xC
	public int cellSpaceY; //Field offset: 0x10
	public int cellSpaceX; //Field offset: 0x14
	public GameObject pullDownToRefreshPrefab; //Field offset: 0x18
	public bool pullDownToRefreshList; //Field offset: 0x1C
	private Infinite _infinite; //Field offset: 0x20
	private UICenterOnChild _centerOnChild; //Field offset: 0x24
	private Transform _rootTransform; //Field offset: 0x28
	private UIPanel _rootPanel; //Field offset: 0x2C
	private UIScrollView _uiScrollView; //Field offset: 0x30
	private Vector2 _nextAppendPosition; //Field offset: 0x34
	private Vector2 _nextPrependPosition; //Field offset: 0x3C
	private bool _dataChangedDelegatesAdded; //Field offset: 0x44
	private AbstractListAdapter _adapter; //Field offset: 0x48
	private Bounds _mListViewBounds; //Field offset: 0x4C
	private RecycleBin _recycleBin; //Field offset: 0x64
	private Container _bottomActiveContainer; //Field offset: 0x68
	private Container _topActiveContainer; //Field offset: 0x6C
	private int _endDataIndexCursor; //Field offset: 0x70
	private int _topDataIndexCursor; //Field offset: 0x74
	public Container pullDownToRefreshContainer; //Field offset: 0x78
	private bool _refreshingContainers; //Field offset: 0x7C
	public Action onTopReached; //Field offset: 0x80
	public Action onDraggingStoppped; //Field offset: 0x84
	private SpringPanel _springPanel; //Field offset: 0x88
	private Container _firstVisibleContainer; //Field offset: 0x8C
	private Container _lastVisibleContainer; //Field offset: 0x90
	public Action onPreLayout; //Field offset: 0x94
	public Action onPullDownRelease; //Field offset: 0x98
	public Action onPullDownToTriggerRefresh; //Field offset: 0x9C
	public Action<int> onPullDown; //Field offset: 0xA0
	private bool _refreshingContainerAdded; //Field offset: 0xA4
	private bool _refreshContainerEncapsulated; //Field offset: 0xA5
	public float scrollViewHeight; //Field offset: 0xA8
	public float scrollViewWidth; //Field offset: 0xAC
	private int _currentMaxListCount; //Field offset: 0xB0
	private int _currentMinListCount; //Field offset: 0xB4
	private PullDownToRefreshState _pullDownToRefreshState; //Field offset: 0xB8
	private BoundsCalculationMode boundsCalculationMode; //Field offset: 0xBC
	public float _currentPos; //Field offset: 0xC0
	private float _previousPos; //Field offset: 0xC4
	private ScrollDirection _scrollDirection; //Field offset: 0xC8
	private bool <animating>k__BackingField; //Field offset: 0xCC
	private bool press; //Field offset: 0xCD
	private float _movementDelta; //Field offset: 0xD0
	private float _cumulativeDelta; //Field offset: 0xD4

	public bool animating
	{
		 get { } //Length: 7
		private set { } //Length: 530
	}

	public bool infinite
	{
		 get { } //Length: 10
	}

	public Bounds listViewBounds
	{
		 get { } //Length: 12
	}

	public UIPanel rootPanel
	{
		 get { } //Length: 105
	}

	public Transform rootPanelTransform
	{
		 get { } //Length: 405
	}

	public ScrollDirection scrollDirection
	{
		 get { } //Length: 82
	}

	public UIScrollView uiScrollView
	{
		 get { } //Length: 82
	}

	public ScrollView() { }

	public IEnumerator AnimateSwapPositions(int dataPosition1, int dataPosition2, float time, Action onComplete = null) { }

	private void AppendContainer(int position, Container container, bool setPosition) { }

	private void CalculateVirtualRelativeWidgetBounds(BoundsCalculationMode mode) { }

	public void CancelLoading() { }

	private void CheckScrollState() { }

	private void ClearList() { }

	private void CreatePullDownToRefreshContainer() { }

	private void FillFromIndex(int i, float topOffset, ContainerPivot containerPivot = 3) { }

	public bool get_animating() { }

	public bool get_infinite() { }

	public Bounds get_listViewBounds() { }

	public UIPanel get_rootPanel() { }

	public Transform get_rootPanelTransform() { }

	public ScrollDirection get_scrollDirection() { }

	public UIScrollView get_uiScrollView() { }

	public List<Container> GetActiveContainers() { }

	public Container GetFirstVisibleContainerOnScreen() { }

	public Container GetLastVisibleContainerOnScreen() { }

	private void HandleScrollDown() { }

	private void HandleScrollUp() { }

	private void InitScrollView() { }

	public static void Log(string msg) { }

	private void OnClipMove(UIPanel panel) { }

	private void OnDataSetChanged(int selection) { }

	private void OnPress(GameObject go, bool state) { }

	private void PrependContainer(int position, Container container, bool setPosition) { }

	public void PrintActiveContainers() { }

	public void Recenter() { }

	private void set_animating(bool value) { }

	public void SetAdapter(AbstractListAdapter adapter) { }

	private void SetContainerPositions() { }

	public void SetSelection(int position, ContainerPivot containerPivot = 0, float offset = 0) { }

	private bool ShouldAppendContainer(Container container) { }

	private bool ShouldPrependContainer(Container container) { }

	private bool ShouldRecycleContainer(Container container) { }

	public void SmoothScrollToIndex(int dataIndex, ContainerPivot containerPivot = 1, Action onFinished = null) { }

	public void SmoothScrollToItem(Transform target, ContainerPivot containerPivot = 1, Action onFinished = null) { }

	private void SmoothScrollToOffset(Vector3 localOffset, Action onFinished, float strength = 8) { }

	private void Start() { }

	private void Update() { }

	private void UpdatePullDownToRefreshContainer() { }

}

