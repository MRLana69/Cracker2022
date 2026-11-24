//Type is in global namespace

public static class NGUIMath
{

	public static int AdjustByDPI(float height) { }

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight) { }

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight) { }

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top) { }

	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans) { }

	public static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive) { }

	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content) { }

	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerChildren = true) { }

	private static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerChildren) { }

	public static Bounds CalculateRelativeWidgetBounds(Transform trans) { }

	public static int ClampIndex(int val, int max) { }

	public static int ColorToInt(Color c) { }

	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea) { }

	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round) { }

	public static Rect ConvertToTexCoords(Rect rect, int width, int height) { }

	public static string DecimalToHex24(int num) { }

	public static string DecimalToHex32(int num) { }

	public static string DecimalToHex8(int num) { }

	public static char DecimalToHexChar(int num) { }

	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b) { }

	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos) { }

	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam) { }

	public static Pivot GetPivot(Vector2 offset) { }

	public static Vector2 GetPivotOffset(Pivot pv) { }

	public static Color HexToColor(uint val) { }

	public static int HexToDecimal(char ch) { }

	public static string IntToBinary(int val, int bits) { }

	public static Color IntToColor(int val) { }

	public static float Lerp(float from, float to, float factor) { }

	public static Rect MakePixelPerfect(Rect rect, int width, int height) { }

	public static Rect MakePixelPerfect(Rect rect) { }

	public static void MoveRect(UIRect rect, float x, float y) { }

	public static void MoveWidget(UIRect w, float x, float y) { }

	public static void OverlayPosition(Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam) { }

	public static void OverlayPosition(Transform trans, Transform target) { }

	public static void OverlayPosition(Transform trans, Vector3 worldPos, Camera worldCam) { }

	public static int RepeatIndex(int val, int max) { }

	public static void ResizeWidget(UIWidget w, Pivot pivot, float x, float y, int minWidth, int minHeight) { }

	public static void ResizeWidget(UIWidget w, Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight) { }

	public static float RotateTowards(float from, float to, float maxAngle) { }

	public static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo) { }

	public static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo) { }

	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime) { }

	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime) { }

	public static float SpringLerp(float strength, float deltaTime) { }

	public static float SpringLerp(float from, float to, float strength, float deltaTime) { }

	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime) { }

	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime) { }

	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime) { }

	public static Vector3 WorldToLocalPoint(Vector3 worldPos, Camera worldCam, Camera uiCam, Transform relativeTo) { }

	public static float Wrap01(float val) { }

	public static float WrapAngle(float angle) { }

}

