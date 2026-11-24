namespace Kiloo.Common.Extensions;

public static class UIExtensions
{
	private sealed class <>c__DisplayClass18_0
	{
		public UIWidget w; //Field offset: 0x8

		public <>c__DisplayClass18_0() { }

		internal bool <SizeWidgetToChildren>b__0(UIWidget wid) { }

	}


	private static float AlignChildrenHorizontally(Transform[] children, float padding, Transform parent, bool leftAligned) { }

	public static float AlignChildrenHorizontally(Transform t, float padding, bool leftAligned) { }

	public static float AlignChildrenVertically(Transform t, float padding, bool downAlign) { }

	private static float AlignChildrenVertically(Transform[] children, float padding, Transform parent, bool downAlign) { }

	public static Bounds CalculateMeshBounds(Transform t) { }

	public static Bounds CalculateRendererBounds(Transform t) { }

	public static Bounds CalculateScreenBounds(Transform t, Camera modelCamera) { }

	public static Bounds CalculateViewportBounds(Transform t, Camera modelCamera) { }

	public static void CenterAlignOnZero(UIGrid grid) { }

	public static void CenterAlignOnZero(UITable table) { }

	public static float CenterChildrenHorizontally(Transform t, float padding) { }

	public static float CenterChildrenHorizontally(Transform[] children, float padding, Transform parent) { }

	private static float CenterChildrenVertically(Transform[] children, float padding, Transform parent) { }

	public static float CenterChildrenVertically(Transform t, float padding) { }

	public static void CenterInViewport(Transform t, Camera modelCamera, Vector2 offset) { }

	public static void CenterInViewport(Transform t, Camera modelCamera) { }

	public static void CenterOnWidget(Transform t, UIWidget widget, Camera modelCamera, Vector2 offset) { }

	public static void CenterOnWidget(Transform t, UIWidget widget) { }

	public static void CenterOnWidget(Transform t, UIWidget widget, Camera modelCamera) { }

	public static float CenterTransformsHorizontalFixedWidth(Transform[] transforms, float width, float padding) { }

	public static void DrawBounds(Bounds b, Color col) { }

	private static void EncapsulateScreenVertices(Vector3[] vertices, Transform transform, ref Bounds bounds, ref bool init, Camera modelCamera) { }

	private static void EncapsulateViewportVertices(Vector3[] vertices, Transform transform, ref Bounds bounds, ref bool init, Camera modelCamera) { }

	public static void FitHeightToWidget(Transform t, UIWidget widget, Camera modelCamera = null, float zoom = 1, int passes = 2) { }

	public static void FitToWidget(Transform t, UIWidget w, Camera modelCamera = null) { }

	public static void FitToWidget(Transform t, UIWidget w, Bounds b, Camera modelCamera = null) { }

	public static void FitToWidget(Transform t, Camera modelCamera, UIWidget widget, float zoom = 1, int passes = 2) { }

	public static void FitWidthToWidget(Transform t, UIWidget widget, Camera modelCamera = null, float zoom = 1, int passes = 2) { }

	public static Vector4 GetEndPositions(Transform transform, Renderer[] renderers = null) { }

	public static void OffsetToCenter(Transform t) { }

	public static void PositionOnWidget(Transform t, UIWidget w, Camera modelCamera = null, Camera widgetCamera = null, Pivot pivot = 4) { }

	public static void RepositionImmediately(UIGrid uiGrid) { }

	public static void SimpleFitToWidget(Transform transform, UIWidget widget, bool fitHorizontal = true) { }

	public static void SizeWidgetToChildren(UIWidget w) { }

}

