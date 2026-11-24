//Type is in global namespace

public class TableElementAlwaysVisible : MonoBehaviour
{
	private sealed class <MovePanelAfterFrames>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public int frames; //Field offset: 0x10
		public TableElementAlwaysVisible <>4__this; //Field offset: 0x14
		public float noOfPixels; //Field offset: 0x18
		private int <numberOfFrames>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 124
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <MovePanelAfterFrames>d__20(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private UIPanel _scrollPanel; //Field offset: 0xC
	private TweenHeight _largestTweenHeight; //Field offset: 0x10
	private float _scrollPanelStartY; //Field offset: 0x14
	private int _index; //Field offset: 0x18
	private UpgradeScreen _upgradeScreen; //Field offset: 0x1C

	public int index
	{
		 get { } //Length: 24
		 set { } //Length: 1242
	}

	public bool IsExpanded
	{
		 get { } //Length: 159
	}

	private UIPanel scrollPanel
	{
		 get { } //Length: 420
	}

	public float ScrollPanelStartY
	{
		 set { } //Length: 9
	}

	private UpgradeScreen upgradeScreen
	{
		 get { } //Length: 6
	}

	public TableElementAlwaysVisible() { }

	private bool AreAllClosed() { }

	public int get_index() { }

	public bool get_IsExpanded() { }

	private UIPanel get_scrollPanel() { }

	private UpgradeScreen get_upgradeScreen() { }

	private bool hasAnotherElementOpenOnBottom() { }

	private bool hasAnotherElementOpenOnTop() { }

	private static void Log(string msg, Object context = null) { }

	private IEnumerator MovePanelAfterFrames(float noOfPixels, int frames) { }

	private void MovePanelBy(float noOfPixels) { }

	private void OnClick() { }

	private void OnDestroy() { }

	public void set_index(int value) { }

	public void set_ScrollPanelStartY(float value) { }

	private void TheElementIsOnBottom(float bottomPointOnScreen, float bottomPointOfTable) { }

	private void TheElementIsOnTop(float topPointOnScreen, float topPointOfTable) { }

	public void ToggleButtonScale() { }

	private bool WillExpand() { }

}

