//Type is in global namespace

public static class Utils
{
	private enum LocaleComponents
	{
		language = 0,
		countryCode = 1,
	}

	private static int randomNumber; //Field offset: 0x0

	public static string stackTrace
	{
		 get { } //Length: 219
	}

	public static StringComparer stringComparer
	{
		 get { } //Length: 3
	}

	public static StringComparer stringComparerIgnoreCase
	{
		 get { } //Length: 77
	}

	public static StringComparison stringComparison
	{
		 get { } //Length: 63
	}

	public static StringComparison stringComparisonIgnoreCase
	{
		 get { } //Length: 3
	}

	private static Utils() { }

	public static void Bar(string text, float ratio, int offset, Color color) { }

	public static Type BaseType(Type type) { }

	public static TOutput[] ConvertAll(TInput[] array, Converter<TInput, TOutput> converter) { }

	public static void DebugStar(Vector3 position, float radius, Color color, float duration) { }

	public static int EncryptDecryptXORValue(int value) { }

	public static T FindComponentInThisOrParents(Transform t) { }

	public static T FindComponentInThisOrParents(MonoBehaviour obj) { }

	public static T FindInParents(MonoBehaviour obj, Func<T, bool> predicate) { }

	public static T FindInThisOrParent(Transform t, Func<T, bool> predicate) { }

	public static T FindObject(bool warnIfNotFound = true) { }

	public static T FindObject(MonoBehaviour obj) { }

	public static string get_stackTrace() { }

	public static StringComparer get_stringComparer() { }

	public static StringComparer get_stringComparerIgnoreCase() { }

	public static StringComparison get_stringComparison() { }

	public static StringComparison get_stringComparisonIgnoreCase() { }

	public static float GetAspectRatio() { }

	public static string GetContryCodeFromLocale(string deviceLocale) { }

	public static Attribute GetCustomAttribute(Type type, Type attributeType) { }

	private static string GetIntBinaryString(int n) { }

	public static string GetLongName(Transform transform) { }

	public static string GetLongNameList(Component[] components) { }

	private static int GetXorRandomValueForThisSession() { }

	public static bool IsEnum(Type type) { }

	public static bool IsInterface(Type type) { }

	public static DateTime StringToDateTime(string value, DateTime defaultValue) { }

	public static void ThreadSleep(TimeSpan timeSpan) { }

}

