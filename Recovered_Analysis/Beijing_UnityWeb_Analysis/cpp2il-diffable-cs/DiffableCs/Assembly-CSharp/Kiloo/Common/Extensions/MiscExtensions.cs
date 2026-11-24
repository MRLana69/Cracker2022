namespace Kiloo.Common.Extensions;

public static class MiscExtensions
{

	public static Texture2D Circle(Texture2D tex, int x, int y, int r, Color color) { }

	public static void Destroy(Object obj) { }

	public static string NicifyTimeString(TimeSpan ts) { }

	public static string NicifyTimeStringSubwayStyle(TimeSpan ts) { }

	public static Color NormalizeRGB(Color color) { }

	public static void SafeInvoke(Action<T1, T2, T3, T4> action, T1 argument1, T2 argument2, T3 argument3, T4 argument4) { }

	public static void SafeInvoke(Action<T1, T2, T3> action, T1 argument1, T2 argument2, T3 argument3) { }

	public static void SafeInvoke(Action<T1, T2> action, T1 argument1, T2 argument2) { }

	public static void SafeInvoke(Action<T> action, T argument) { }

	public static void SafeInvoke(Action action) { }

	public static T SafeInvoke(Func<T> f) { }

	public static Color ToColor(string s) { }

	public static TEnum ToEnum(string strEnumValue, TEnum defaultValue) { }

	public static string ToHex(Color32 color) { }

	public static string ToHex(Color color) { }

	public static string ToUIHex(Color32 color) { }

	public static string ToUIHex(Color color) { }

	public static bool TryParseHexToColor(string hexString, out Color color) { }

	public static string UnifyNewlines(string content) { }

	public static string UnifyNewlines(string content, string newline) { }

	public static Color WithAlpha(Color c, float a) { }

}

