namespace UnityEngine;

public class Display
{
	public delegate DisplaysUpdatedDelegate
	{

		public DisplaysUpdatedDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public static Display[] displays; //Field offset: 0x0
	private static Display _mainDisplay; //Field offset: 0x4
	private static DisplaysUpdatedDelegate onDisplaysUpdated; //Field offset: 0x8
	internal nint nativeDisplay; //Field offset: 0x8

	public int renderingHeight
	{
		 get { } //Length: 125
	}

	public int renderingWidth
	{
		 get { } //Length: 49
	}

	public int systemHeight
	{
		 get { } //Length: 125
	}

	public int systemWidth
	{
		 get { } //Length: 125
	}

	private static Display() { }

	internal Display() { }

	internal Display(nint nativeDisplay) { }

	private static void FireDisplaysUpdated() { }

	public int get_renderingHeight() { }

	public int get_renderingWidth() { }

	public int get_systemHeight() { }

	public int get_systemWidth() { }

	private static void GetRenderingExtImpl(nint nativeDisplay, out int w, out int h) { }

	private static void GetSystemExtImpl(nint nativeDisplay, out int w, out int h) { }

	private static void RecreateDisplayList(nint[] nativeDisplay) { }

	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

}

