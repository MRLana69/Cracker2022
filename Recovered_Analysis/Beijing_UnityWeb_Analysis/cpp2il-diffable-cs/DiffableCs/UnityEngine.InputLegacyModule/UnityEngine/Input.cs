namespace UnityEngine;

public class Input
{

	public static bool anyKeyDown
	{
		 get { } //Length: 47
	}

	public static Vector2 compositionCursorPos
	{
		 get { } //Length: 51
		 set { } //Length: 41
	}

	public static string compositionString
	{
		 get { } //Length: 47
	}

	public static IMECompositionMode imeCompositionMode
	{
		 get { } //Length: 47
		 set { } //Length: 41
	}

	public static string inputString
	{
		 get { } //Length: 47
	}

	public static Vector3 mousePosition
	{
		 get { } //Length: 2
	}

	public static bool mousePresent
	{
		 get { } //Length: 47
	}

	public static Vector2 mouseScrollDelta
	{
		 get { } //Length: 58
	}

	public static int touchCount
	{
		 get { } //Length: 47
	}

	public static Touch[] touches
	{
		 get { } //Length: 47
	}

	public static bool touchSupported
	{
		 get { } //Length: 47
	}

	public static bool get_anyKeyDown() { }

	public static Vector2 get_compositionCursorPos() { }

	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	public static string get_compositionString() { }

	public static IMECompositionMode get_imeCompositionMode() { }

	public static string get_inputString() { }

	public static Vector3 get_mousePosition() { }

	private static void get_mousePosition_Injected(out Vector3 ret) { }

	public static bool get_mousePresent() { }

	public static Vector2 get_mouseScrollDelta() { }

	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	public static int get_touchCount() { }

	public static Touch[] get_touches() { }

	public static bool get_touchSupported() { }

	public static float GetAxis(string axisName) { }

	public static float GetAxisRaw(string axisName) { }

	public static bool GetButtonDown(string buttonName) { }

	public static bool GetKey(KeyCode key) { }

	public static bool GetKeyDown(KeyCode key) { }

	public static bool GetKeyDown(string name) { }

	private static bool GetKeyDownInt(KeyCode key) { }

	private static bool GetKeyDownString(string name) { }

	private static bool GetKeyInt(KeyCode key) { }

	public static bool GetKeyUp(KeyCode key) { }

	private static bool GetKeyUpInt(KeyCode key) { }

	public static bool GetMouseButton(int button) { }

	public static bool GetMouseButtonDown(int button) { }

	public static bool GetMouseButtonUp(int button) { }

	public static Touch GetTouch(int index) { }

	private static void GetTouch_Injected(int index, out Touch ret) { }

	public static void set_compositionCursorPos(Vector2 value) { }

	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	public static void set_imeCompositionMode(IMECompositionMode value) { }

}

