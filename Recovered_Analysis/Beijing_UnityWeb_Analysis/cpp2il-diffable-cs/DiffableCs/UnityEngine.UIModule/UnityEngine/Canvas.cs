namespace UnityEngine;

public sealed class Canvas : Behaviour
{
	public delegate WillRenderCanvases
	{

		public WillRenderCanvases(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	private static WillRenderCanvases willRenderCanvases; //Field offset: 0x0

	public static event WillRenderCanvases willRenderCanvases
	{
		 add { } //Length: 9
		 remove { } //Length: 132
	}

	public bool isRootCanvas
	{
		 get { } //Length: 49
	}

	public bool overrideSorting
	{
		 get { } //Length: 49
		 set { } //Length: 61
	}

	public bool pixelPerfect
	{
		 get { } //Length: 49
	}

	public float referencePixelsPerUnit
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public RenderMode renderMode
	{
		 get { } //Length: 49
	}

	public int renderOrder
	{
		 get { } //Length: 49
	}

	public Canvas rootCanvas
	{
		 get { } //Length: 49
	}

	public float scaleFactor
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public int sortingLayerID
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public int sortingOrder
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public int targetDisplay
	{
		 get { } //Length: 49
	}

	public Camera worldCamera
	{
		 get { } //Length: 49
	}

	public Canvas() { }

	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	public static void ForceUpdateCanvases() { }

	public bool get_isRootCanvas() { }

	public bool get_overrideSorting() { }

	public bool get_pixelPerfect() { }

	public float get_referencePixelsPerUnit() { }

	public RenderMode get_renderMode() { }

	public int get_renderOrder() { }

	public Canvas get_rootCanvas() { }

	public float get_scaleFactor() { }

	public int get_sortingLayerID() { }

	public int get_sortingOrder() { }

	public int get_targetDisplay() { }

	public Camera get_worldCamera() { }

	public static Material GetDefaultCanvasMaterial() { }

	public static Material GetETC1SupportedCanvasMaterial() { }

	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	private static void SendWillRenderCanvases() { }

	public void set_overrideSorting(bool value) { }

	public void set_referencePixelsPerUnit(float value) { }

	public void set_scaleFactor(float value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingOrder(int value) { }

}

