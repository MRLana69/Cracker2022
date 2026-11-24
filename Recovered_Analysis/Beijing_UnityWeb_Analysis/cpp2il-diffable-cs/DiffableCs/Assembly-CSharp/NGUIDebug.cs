//Type is in global namespace

public class NGUIDebug : MonoBehaviour
{
	private static bool mRayDebug; //Field offset: 0x0
	private static List<string> mLines; //Field offset: 0x4
	private static NGUIDebug mInstance; //Field offset: 0x8

	public static bool debugRaycast
	{
		 get { } //Length: 3
		 set { } //Length: 115
	}

	private static NGUIDebug() { }

	public NGUIDebug() { }

	public static void Clear() { }

	public static void CreateInstance() { }

	public static void DrawBounds(Bounds b) { }

	public static bool get_debugRaycast() { }

	public static void Log(object[] objs) { }

	public static void Log(string s) { }

	private static void LogString(string text) { }

	private void OnGUI() { }

	public static void set_debugRaycast(bool value) { }

}

