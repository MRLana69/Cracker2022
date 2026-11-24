namespace System.Text.RegularExpressions;

public class Regex : ISerializable
{
	private static readonly TimeSpan MaximumMatchTimeout; //Field offset: 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; //Field offset: 0x8
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; //Field offset: 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; //Field offset: 0x18
	internal static LinkedList<CachedCodeEntry> livecode; //Field offset: 0x20
	internal static int cacheSize; //Field offset: 0x24
	protected internal string pattern; //Field offset: 0x8
	protected internal RegexRunnerFactory factory; //Field offset: 0xC
	protected internal RegexOptions roptions; //Field offset: 0x10
	protected internal TimeSpan internalMatchTimeout; //Field offset: 0x18
	protected internal Hashtable caps; //Field offset: 0x20
	protected internal Hashtable capnames; //Field offset: 0x24
	protected internal string[] capslist; //Field offset: 0x28
	protected internal int capsize; //Field offset: 0x2C
	internal ExclusiveReference runnerref; //Field offset: 0x30
	internal SharedReference replref; //Field offset: 0x34
	internal RegexCode code; //Field offset: 0x38
	internal bool refsInitialized; //Field offset: 0x3C

	public TimeSpan MatchTimeout
	{
		 get { } //Length: 11
	}

	public RegexOptions Options
	{
		 get { } //Length: 93
	}

	public bool RightToLeft
	{
		 get { } //Length: 6
	}

	private static Regex() { }

	protected Regex(SerializationInfo info, StreamingContext context) { }

	private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	protected Regex() { }

	public Regex(string pattern) { }

	public Regex(string pattern, RegexOptions options) { }

	private CachedCodeEntry CacheCode(string key) { }

	public TimeSpan get_MatchTimeout() { }

	public RegexOptions get_Options() { }

	public bool get_RightToLeft() { }

	public string GroupNameFromNumber(int i) { }

	private static TimeSpan InitDefaultMatchTimeout() { }

	protected void InitializeReferences() { }

	public bool IsMatch(string input) { }

	public bool IsMatch(string input, int startat) { }

	public static bool IsMatch(string input, string pattern) { }

	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	public Match Match(string input) { }

	public Match Match(string input, int startat) { }

	public static string Replace(string input, string pattern, string replacement) { }

	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	public string Replace(string input, string replacement) { }

	public string Replace(string input, string replacement, int count, int startat) { }

	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	public override string ToString() { }

	internal bool UseOptionInvariant() { }

	protected bool UseOptionR() { }

	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

}

