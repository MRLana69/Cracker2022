namespace UnityEngine;

public class GUIUtility
{
	internal static int s_SkinMode; //Field offset: 0x0
	internal static int s_OriginalID; //Field offset: 0x4
	internal static Action takeCapture; //Field offset: 0x8
	internal static Action releaseCapture; //Field offset: 0xC
	internal static Func<int, nint, bool> processEvent; //Field offset: 0x10
	internal static Func<Exception, bool> endContainerGUIFromException; //Field offset: 0x14
	internal static Action guiChanged; //Field offset: 0x18
	private static bool <guiIsExiting>k__BackingField; //Field offset: 0x1C

	internal static Vector2 compositionCursorPos
	{
		 set { } //Length: 51
	}

	internal static string compositionString
	{
		 get { } //Length: 47
	}

	internal static int guiDepth
	{
		 get { } //Length: 180
	}

	internal static bool guiIsExiting
	{
		 set { } //Length: 51
	}

	public static int hotControl
	{
		 get { } //Length: 47
		 set { } //Length: 54
	}

	public static int keyboardControl
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	internal static bool mouseUsed
	{
		 set { } //Length: 358
	}

	internal static float pixelsPerPoint
	{
		 get { } //Length: 47
	}

	public static string systemCopyBuffer
	{
		 get { } //Length: 47
		 set { } //Length: 51
	}

	internal static bool textFieldInput
	{
		 set { } //Length: 51
	}

	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	internal static void CheckOnGUI() { }

	internal static bool EndContainerGUIFromException(Exception exception) { }

	internal static void EndGUI(int layoutType) { }

	internal static bool EndGUIFromException(Exception exception) { }

	internal static string get_compositionString() { }

	internal static int get_guiDepth() { }

	public static int get_hotControl() { }

	public static int get_keyboardControl() { }

	internal static float get_pixelsPerPoint() { }

	public static string get_systemCopyBuffer() { }

	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	public static int GetControlID(int hint, FocusType focus) { }

	public static int GetControlID(FocusType focus, Rect position) { }

	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	internal static GUISkin GetDefaultSkin() { }

	public static object GetStateObject(Type t, int controlID) { }

	private static void Internal_ExitGUI() { }

	private static object Internal_GetDefaultSkin(int skinMode) { }

	private static int Internal_GetHotControl() { }

	private static int Internal_GetKeyboardControl() { }

	private static void Internal_SetHotControl(int value) { }

	private static void Internal_SetKeyboardControl(int value) { }

	internal static bool IsExitGUIException(Exception exception) { }

	private static void MarkGUIChanged() { }

	internal static bool ProcessEvent(int instanceID, nint nativeEventPtr) { }

	internal static void RemoveCapture() { }

	internal static void ResetGlobalState() { }

	internal static void set_compositionCursorPos(Vector2 value) { }

	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	internal static void set_guiIsExiting(bool value) { }

	public static void set_hotControl(int value) { }

	public static void set_keyboardControl(int value) { }

	internal static void set_mouseUsed(bool value) { }

	public static void set_systemCopyBuffer(string value) { }

	internal static void set_textFieldInput(bool value) { }

	internal static bool ShouldRethrowException(Exception exception) { }

	internal static void TakeCapture() { }

}

