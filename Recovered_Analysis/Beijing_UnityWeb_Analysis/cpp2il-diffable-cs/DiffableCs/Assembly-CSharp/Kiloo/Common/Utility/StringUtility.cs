namespace Kiloo.Common.Utility;

public static class StringUtility
{
	public enum MatchType
	{
		Is = 0,
		EndsWith = 1,
		BeginsWith = 2,
		Contains = 3,
	}


	public static string ArrayToString(MyType[] array, string seperator = ", ") { }

	public static string FormatProperties(Dictionary<string, string> props) { }

	public static byte[] FromHexString(string hex) { }

	public static int GetNextKeyValuePair(string text, int startIndex, out string key, out string value) { }

	public static bool Match(string str, string pattern, MatchType matchType, bool ignoreCase) { }

	public static int NonEscapedIndexOf(string text, int startIndex, char ch) { }

	private static int ParseHexDigit(char c) { }

	public static Dictionary<string, string> ParseProperties(string text) { }

	public static string[][] ParseSets(string setsString) { }

	public static string ToHexString(byte[] bytes, bool lowerCase = false) { }

	public static void ValidateEnumValueString(Type enumType, string enumValueString, bool mayBeNullOrEmpty, string varName) { }

}

