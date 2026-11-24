namespace ABTest;

public class ABTest
{
	private const string ONLINESETTINGS_ABTEST_PREFIX = "abtest"; //Field offset: 0x0
	private static readonly Range[] KILOO_ANALYTICS_SAMPLING_KEY_TEST_RANGES; //Field offset: 0x0
	private const string DEBUG_PAYLOAD_PREFIX = "debug_payload_"; //Field offset: 0x0
	private const string DEFAULT_ABTEST_EXCLUDE_ANALYTICS_SAMPLING_RANGE = ""; //Field offset: 0x0
	private const string DEFAULT_ABTEST_INCLUDE_ANALYTICS_SAMPLING_RANGE = ""; //Field offset: 0x0
	private const string DEFAULT_ABTEST_SEGMENT_PAYLOAD = ""; //Field offset: 0x0
	private const string DEFAULT_ABTEST_SEGMENT_SIZE = ""; //Field offset: 0x0
	private const string DEFAULT_ABTEST_SEGMENT_OFFSET = ""; //Field offset: 0x0
	private const string DEFAULT_ABTEST_EXCLUDED_TAGS = ""; //Field offset: 0x0
	private const string DEFAULT_ABTEST_MIN_INSTALL_DATETIME = ""; //Field offset: 0x0
	private const string DEFAULT_ABTEST_DEFAULT = ""; //Field offset: 0x0
	private const bool DEFAULT_ABTEST_DEBUG_ENABLE_ANALYTICS_SAMPLING_KEY_CHECK = False; //Field offset: 0x0
	private const bool DEFAULT_ABTEST_ACTIVE = False; //Field offset: 0x0
	private const int DEFAULT_ABTEST_VERSION = 0; //Field offset: 0x0
	private const string DEFAULT_ABTEST_MAX_INSTALL_DATETIME = ""; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_EXCLUDE_ANALYTICS_SAMPLING_RANGE_KEY = "exclude_analytics_sampling_key_range"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_DEBUG_ENABLE_ANALYTICS_SAMPLING_KEY_CHECK = "debug_enable_analytics_sampling_key_range"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_DEFAULT_PAYLOAD_KEY = "default_payload_override"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_ACTIVE_KEY = "active"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_MIN_INSTALL_DATETIME_KEY = "min_install_datetime"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_MAX_INSTALL_DATETIME_KEY = "max_install_datetime"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_EXCLUDED_TAGS_KEY = "excluded_tags"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_VERSION_KEY = "version"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_SEGMENT_SIZE_KEY = "segment_size"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_SEGMENT_OFFSET_KEY = "segment_offset"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_SEGMENT_PAYLOAD_KEY = "segment_payload"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_TAG_KEY = "tag"; //Field offset: 0x0
	private const string ONLINESETTINGS_ABTEST_INCLUDE_ANALYTICS_SAMPLING_RANGE_KEY = "include_analytics_sampling_key_range"; //Field offset: 0x0
	private static readonly Range[] SYBO_ANALYTICS_SAMPLING_KEY_TEST_RANGES; //Field offset: 0x4
	private readonly string _identifier; //Field offset: 0x8
	private readonly float _sample; //Field offset: 0xC
	private readonly TestRange _analyticsSamplingKeyRange; //Field offset: 0x10
	private readonly float _analyticsSamplingKey; //Field offset: 0x14
	private int _version; //Field offset: 0x18
	private int _segmentIndex; //Field offset: 0x1C
	private bool <isForcedDisabled>k__BackingField; //Field offset: 0x20
	private bool <isActive>k__BackingField; //Field offset: 0x21
	private string <payload>k__BackingField; //Field offset: 0x24
	private string <defaultPayload>k__BackingField; //Field offset: 0x28
	private string <tag>k__BackingField; //Field offset: 0x2C

	public string defaultPayload
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public bool isActive
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public bool isForcedDisabled
	{
		 get { } //Length: 6
		private set { } //Length: 40
	}

	public string payload
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public int segmentIndex
	{
		 get { } //Length: 6
	}

	public string tag
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	private static ABTest() { }

	public ABTest(ABTestDataItem testDataItem) { }

	public void DisableDebugPayload() { }

	public void EnableDebugPayload(string value) { }

	public string get_defaultPayload() { }

	public bool get_isActive() { }

	public bool get_isForcedDisabled() { }

	public string get_payload() { }

	public int get_segmentIndex() { }

	public string get_tag() { }

	private IEnumerable<Range> GetAnalyticsSamplingKeyTestRanges() { }

	public string GetDebugPayload() { }

	private static string GetOnlineSettingsKey(string identifier, string key) { }

	public int GetPayload(int defaultValue) { }

	public bool GetPayload(bool defaultValue) { }

	public string GetPayload() { }

	public uint GetPayload(uint defaultValue) { }

	public bool HasDebugPayload() { }

	private bool IsCheckForAnalyticsSamplingKeyRangeEnabled() { }

	private bool IsExcludedByAnalyticsSamplingKeyTestRanges() { }

	private bool IsExcludedByExcludeAnalyticsSamplingKeyRange() { }

	private bool IsExcludedByIncludeAnalyticsSamplingKeyRange() { }

	private static void Log(string msg, string identifier, Object context = null) { }

	private static void LogErr(string msg, string identifier, Object context = null) { }

	private static void LogWarn(string msg, string identifier, Object context = null) { }

	private static List<float> ParseFloatList(string str, char separator) { }

	public Range ParseKeyRange(string str, char separator) { }

	private string RangesToText(IEnumerable<Range> ranges) { }

	private void set_defaultPayload(string value) { }

	private void set_isActive(bool value) { }

	private void set_isForcedDisabled(bool value) { }

	private void set_payload(string value) { }

	private void set_tag(string value) { }

	public void Update(List<string> tags) { }

}

