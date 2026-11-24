//Type is in global namespace

public class ProductPlacementManager
{
	private sealed class <DownloadProductPlacement>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SpriteContainer container; //Field offset: 0x10
		public ProductPlacementManager <>4__this; //Field offset: 0x14
		public int intent; //Field offset: 0x18
		private WWW <product>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 440
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DownloadProductPlacement>d__20(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public SpriteContainer tunnelContainer; //Field offset: 0x10
	public SpriteContainer billboardContainer; //Field offset: 0x14
	public SpriteContainer trainContainer; //Field offset: 0x18
	public Action OnProductPlacementDownloaded; //Field offset: 0x1C
	private int _onGoingRequests; //Field offset: 0x20
	private float <tunnelTimeInbetween>k__BackingField; //Field offset: 0x24
	private float <trainTimeInbetween>k__BackingField; //Field offset: 0x28
	private float <billboardTimeInbetween>k__BackingField; //Field offset: 0x2C

	public float billboardTimeInbetween
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float trainTimeInbetween
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float tunnelTimeInbetween
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public ProductPlacementManager() { }

	private IEnumerator DownloadProductPlacement(SpriteContainer container, int intent) { }

	public float get_billboardTimeInbetween() { }

	public float get_trainTimeInbetween() { }

	public float get_tunnelTimeInbetween() { }

	private void Init() { }

	public void set_billboardTimeInbetween(float value) { }

	public void set_trainTimeInbetween(float value) { }

	public void set_tunnelTimeInbetween(float value) { }

	private void Start() { }

	private void Update() { }

}

