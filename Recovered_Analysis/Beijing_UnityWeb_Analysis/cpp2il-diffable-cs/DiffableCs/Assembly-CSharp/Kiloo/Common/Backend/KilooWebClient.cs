namespace Kiloo.Common.Backend;

public static class KilooWebClient
{
	private static float <defaultRequestTimeout>k__BackingField; //Field offset: 0x0
	private const string TAGS_PLAYERPREFS_KEY = "kiloowebclient_tags"; //Field offset: 0x0
	private static float <defaultKeepAlive>k__BackingField; //Field offset: 0x4
	private static float <defaultMinBackOffTime>k__BackingField; //Field offset: 0x8
	private static float <defaultMaxBackOffTime>k__BackingField; //Field offset: 0xC
	private static Dictionary<string, string> _clientInfoHeaders; //Field offset: 0x10
	private static IDictionary<string, object> _tags; //Field offset: 0x14

	public static float defaultKeepAlive
	{
		 get { } //Length: 89
		 set { } //Length: 91
	}

	public static float defaultMaxBackOffTime
	{
		 get { } //Length: 89
		 set { } //Length: 91
	}

	public static float defaultMinBackOffTime
	{
		 get { } //Length: 89
		 set { } //Length: 91
	}

	public static float defaultRequestTimeout
	{
		 get { } //Length: 89
		 set { } //Length: 91
	}

	private static KilooWebClient() { }

	public static void AddTags(string[] tags) { }

	public static IRequest CreateDelete(Uri uri) { }

	public static IRequest CreateGet(Uri uri) { }

	public static IRequest CreatePost(Uri uri) { }

	public static IRequest CreatePut(Uri uri) { }

	private static IRequest CreateRequest(string method, Uri uri) { }

	public static float get_defaultKeepAlive() { }

	public static float get_defaultMaxBackOffTime() { }

	public static float get_defaultMinBackOffTime() { }

	public static float get_defaultRequestTimeout() { }

	private static void GetLanguageAndCountry(out string language, out string country) { }

	private static string GetOsIdentifier() { }

	private static string GetOsVersion() { }

	private static string GetPlatformIdentifier() { }

	public static string GetTags() { }

	public static bool HasTag(string tag) { }

	public static void InitAutomatically(string appId) { }

	public static void InitWithClientInfo(string appId, string appVersion, string platformId, string deviceModel, string osId, string osVersion, string deviceLanguage, string deviceCountry, float deviceTimeZone) { }

	private static bool IsKindleDevice() { }

	private static IDictionary<string, object> LoadTags() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	public static void RemoveTags(string[] tags) { }

	private static void SaveTags() { }

	public static void set_defaultKeepAlive(float value) { }

	public static void set_defaultMaxBackOffTime(float value) { }

	public static void set_defaultMinBackOffTime(float value) { }

	public static void set_defaultRequestTimeout(float value) { }

	public static IRequest WithKilooAntiCheat(IRequest request) { }

	public static IRequest WithKilooDeviceId(IRequest request) { }

	public static IRequest WithKilooTags(IRequest request) { }

}

