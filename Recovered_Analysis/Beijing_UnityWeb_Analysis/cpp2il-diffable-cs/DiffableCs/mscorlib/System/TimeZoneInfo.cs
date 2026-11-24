namespace System;

public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<AdjustmentRule> <>9__19_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <CreateLocalUnity>b__19_0(AdjustmentRule rule1, AdjustmentRule rule2) { }

	}

	public sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
	{
		private DateTime m_dateStart; //Field offset: 0x8
		private DateTime m_dateEnd; //Field offset: 0x10
		private TimeSpan m_daylightDelta; //Field offset: 0x18
		private TransitionTime m_daylightTransitionStart; //Field offset: 0x20
		private TransitionTime m_daylightTransitionEnd; //Field offset: 0x38
		private TimeSpan m_baseUtcOffsetDelta; //Field offset: 0x50

		public DateTime DateEnd
		{
			 get { } //Length: 6
		}

		public DateTime DateStart
		{
			 get { } //Length: 6
		}

		public TimeSpan DaylightDelta
		{
			 get { } //Length: 6
		}

		public TransitionTime DaylightTransitionEnd
		{
			 get { } //Length: 36
		}

		public TransitionTime DaylightTransitionStart
		{
			 get { } //Length: 379
		}

		private AdjustmentRule() { }

		private AdjustmentRule(SerializationInfo info, StreamingContext context) { }

		public static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd) { }

		internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta) { }

		public bool Equals(AdjustmentRule other) { }

		public DateTime get_DateEnd() { }

		public DateTime get_DateStart() { }

		public TimeSpan get_DaylightDelta() { }

		public TransitionTime get_DaylightTransitionEnd() { }

		public TransitionTime get_DaylightTransitionStart() { }

		public override int GetHashCode() { }

		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd) { }

	}

	internal struct DYNAMIC_TIME_ZONE_INFORMATION
	{
		internal TIME_ZONE_INFORMATION TZI; //Field offset: 0x0
		internal string TimeZoneKeyName; //Field offset: 0x34
		internal byte DynamicDaylightTimeDisabled; //Field offset: 0x38

	}

	internal struct SYSTEMTIME
	{
		internal ushort wYear; //Field offset: 0x0
		internal ushort wMonth; //Field offset: 0x2
		internal ushort wDayOfWeek; //Field offset: 0x4
		internal ushort wDay; //Field offset: 0x6
		internal ushort wHour; //Field offset: 0x8
		internal ushort wMinute; //Field offset: 0xA
		internal ushort wSecond; //Field offset: 0xC
		internal ushort wMilliseconds; //Field offset: 0xE

	}

	internal struct TIME_ZONE_INFORMATION
	{
		internal int Bias; //Field offset: 0x0
		internal string StandardName; //Field offset: 0x4
		internal SYSTEMTIME StandardDate; //Field offset: 0x8
		internal int StandardBias; //Field offset: 0x18
		internal string DaylightName; //Field offset: 0x1C
		internal SYSTEMTIME DaylightDate; //Field offset: 0x20
		internal int DaylightBias; //Field offset: 0x30

	}

	public struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
	{
		private DateTime m_timeOfDay; //Field offset: 0x0
		private byte m_month; //Field offset: 0x8
		private byte m_week; //Field offset: 0x9
		private byte m_day; //Field offset: 0xA
		private DayOfWeek m_dayOfWeek; //Field offset: 0xC
		private bool m_isFixedDateRule; //Field offset: 0x10

		public int Day
		{
			 get { } //Length: 9
		}

		public DayOfWeek DayOfWeek
		{
			 get { } //Length: 9
		}

		public bool IsFixedDateRule
		{
			 get { } //Length: 9
		}

		public int Month
		{
			 get { } //Length: 29
		}

		public DateTime TimeOfDay
		{
			 get { } //Length: 6
		}

		public int Week
		{
			 get { } //Length: 9
		}

		private TransitionTime(SerializationInfo info, StreamingContext context) { }

		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

		private static TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

		public override bool Equals(object obj) { }

		public bool Equals(TransitionTime other) { }

		public int get_Day() { }

		public DayOfWeek get_DayOfWeek() { }

		public bool get_IsFixedDateRule() { }

		public int get_Month() { }

		public DateTime get_TimeOfDay() { }

		public int get_Week() { }

		public override int GetHashCode() { }

		public static bool op_Inequality(TransitionTime t1, TransitionTime t2) { }

		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	}

	private static TimeZoneInfo local; //Field offset: 0x0
	private static bool readlinkNotFound; //Field offset: 0x4
	private static TimeZoneInfo utc; //Field offset: 0x8
	private static string timeZoneDirectory; //Field offset: 0xC
	private static RegistryKey timeZoneKey; //Field offset: 0x10
	private static RegistryKey localZoneKey; //Field offset: 0x14
	private static ReadOnlyCollection<TimeZoneInfo> systemTimeZones; //Field offset: 0x18
	private TimeSpan baseUtcOffset; //Field offset: 0x8
	private string daylightDisplayName; //Field offset: 0x10
	private string displayName; //Field offset: 0x14
	private string id; //Field offset: 0x18
	private List<KeyValuePair<DateTime, TimeType>> transitions; //Field offset: 0x1C
	private string standardDisplayName; //Field offset: 0x20
	private bool supportsDaylightSavingTime; //Field offset: 0x24
	private AdjustmentRule[] adjustmentRules; //Field offset: 0x28

	public TimeSpan BaseUtcOffset
	{
		 get { } //Length: 12
	}

	public string DisplayName
	{
		 get { } //Length: 557
	}

	public string Id
	{
		 get { } //Length: 6
	}

	private static bool IsWindows
	{
		 get { } //Length: 92
	}

	public static TimeZoneInfo Local
	{
		 get { } //Length: 635
	}

	private static RegistryKey LocalZoneKey
	{
		 get { } //Length: 471
	}

	public bool SupportsDaylightSavingTime
	{
		 get { } //Length: 97
	}

	private static string TimeZoneDirectory
	{
		 get { } //Length: 175
	}

	private static RegistryKey TimeZoneKey
	{
		 get { } //Length: 33
	}

	public static TimeZoneInfo Utc
	{
		 get { } //Length: 1367
	}

	internal TimeZoneInfo() { }

	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	private TimeZoneInfo(SerializationInfo info, StreamingContext context) { }

	private static TimeZoneInfo BuildFromStream(string id, Stream stream) { }

	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone) { }

	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	private DateTime ConvertTimeFromUtc(DateTime dateTime) { }

	private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags) { }

	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) { }

	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	private static List<AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear) { }

	internal static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules) { }

	private static TimeZoneInfo CreateLocal() { }

	private static TimeZoneInfo CreateLocalUnity() { }

	private static DateTime DateTimeFromUnixTime(long unix_time) { }

	internal static uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	public bool Equals(TimeZoneInfo other) { }

	public override bool Equals(object obj) { }

	private static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath) { }

	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	private static TimeZoneInfo FindSystemTimeZoneByIdCore(string id) { }

	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	private static TimeZoneInfo FromRegistryKey(string id, RegistryKey key) { }

	public TimeSpan get_BaseUtcOffset() { }

	public string get_DisplayName() { }

	public string get_Id() { }

	private static bool get_IsWindows() { }

	public static TimeZoneInfo get_Local() { }

	private static RegistryKey get_LocalZoneKey() { }

	public bool get_SupportsDaylightSavingTime() { }

	private static string get_TimeZoneDirectory() { }

	private static RegistryKey get_TimeZoneKey() { }

	public static TimeZoneInfo get_Utc() { }

	public AdjustmentRule[] GetAdjustmentRules() { }

	private AdjustmentRule GetApplicableRule(DateTime dateTime) { }

	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	internal static uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	internal static uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	internal static uint GetDynamicTimeZoneInformationWin32(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	public override int GetHashCode() { }

	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	internal static string GetLocalTimeZoneKeyNameWin32Fallback() { }

	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	private static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones) { }

	internal static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback() { }

	internal static bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TIME_ZONE_INFORMATION ptzi) { }

	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST) { }

	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST) { }

	public bool HasSameRules(TimeZoneInfo other) { }

	public bool IsAmbiguousTime(DateTime dateTime) { }

	private bool IsInDST(AdjustmentRule rule, DateTime dateTime) { }

	private bool IsInDSTForYear(AdjustmentRule rule, DateTime dateTime, int year) { }

	public bool IsInvalidTime(DateTime dateTime) { }

	private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count) { }

	private static void ParseRegTzi(List<AdjustmentRule> adjustmentRules, int start_year, int end_year, byte[] buffer) { }

	private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations) { }

	private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, Dictionary<int, TimeType> time_types) { }

	private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length) { }

	private static int ReadBigEndianInt32(byte[] buffer, int start) { }

	private static int readlink(string path, byte[] buffer, int buflen) { }

	private static string readlink(string path) { }

	private static int SwapInt32(int i) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override string ToString() { }

	private static DateTime TransitionPoint(TransitionTime transition, int year) { }

	private static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) { }

	private static string TrimSpecial(string str) { }

	private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = 0) { }

	internal static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	private static bool TryGetNameFromPath(string path, out string name) { }

	private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst) { }

	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	private static void Validate(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules) { }

	private static AdjustmentRule[] ValidateRules(List<AdjustmentRule> adjustmentRules) { }

	private static bool ValidTZFile(byte[] buffer, int length) { }

}

