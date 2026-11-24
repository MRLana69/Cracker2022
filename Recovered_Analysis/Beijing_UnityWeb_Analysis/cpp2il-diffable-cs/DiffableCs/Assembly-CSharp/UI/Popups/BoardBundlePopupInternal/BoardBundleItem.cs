namespace UI.Popups.BoardBundlePopupInternal;

public class BoardBundleItem
{
	private sealed class <TeleboardEffect>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public BoardBundleItem <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 447
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TeleboardEffect>d__24(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float DEFAULT_SCALE_FACTOR = 11; //Field offset: 0x0
	private const float TRAIL_PARTICLE_SYSTEM_START_ROTATION = 150; //Field offset: 0x0
	private const float TRAIL_PARTICLE_SYSTEM_END_ROTATION = 210; //Field offset: 0x0
	private const float TRAIL_PARTICLE_SYSTEM_RATE_OVER_TIME = 3; //Field offset: 0x0
	private static readonly Vector3 MODEL_POSITION; //Field offset: 0x0
	private static readonly Vector3 MODEL_LOCAL_ROTATION; //Field offset: 0xC
	private static readonly Vector3 TRAIL_SCALE; //Field offset: 0x18
	private static readonly Quaternion TRAIL_ROTATION; //Field offset: 0x24
	private static readonly Vector3 TRAIL_PARTICLE_SYSTEM_POSITION; //Field offset: 0x34
	private Transform _boardAnchor; //Field offset: 0x8
	private Transform _boardBottomAnchor; //Field offset: 0xC
	private HorizontalLayout _boardLayouter; //Field offset: 0x10
	private BundleIcon _boardIcon; //Field offset: 0x14
	private UILabel _boardPriceLabel; //Field offset: 0x18
	private List<BundleIcon> _bundleIcons; //Field offset: 0x1C
	private BoardId _boardId; //Field offset: 0x20
	private ATeleboardMenuEffect _teleboardMenuEffect; //Field offset: 0x24
	private GameObject _boardRoot; //Field offset: 0x28

	private static BoardBundleItem() { }

	public BoardBundleItem() { }

	public void Align() { }

	public void GainFocus() { }

	public void Init(BoardId boardId, string price) { }

	public void LoseFocus() { }

	public void SetupBoard(List<int> themes) { }

	private void SetupBoard(Transform modelPosition, BoardId boardId, List<int> themes) { }

	public void SetupThemeInfo(int theme, int powerIndex) { }

	private void SetupThemeInfo(BoardId boardId, int theme, int powerIndex) { }

	private void SetupTrail(GameObject trail) { }

	private void SetupTrailParticleSystem(ParticleSystem trailParticleSystem) { }

	public void Show() { }

	private IEnumerator TeleboardEffect() { }

}

