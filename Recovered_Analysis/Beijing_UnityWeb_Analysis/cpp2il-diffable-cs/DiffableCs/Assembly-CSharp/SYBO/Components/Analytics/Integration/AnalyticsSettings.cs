namespace SYBO.Components.Analytics.Integration;

public class AnalyticsSettings
{
	private const bool DebugDefaultEnabled = False; //Field offset: 0x0
	private const string DefaultFilename = "analytics.log"; //Field offset: 0x0
	private const int DefaultStorageLimitKB = 2048; //Field offset: 0x0
	private const int DefaultChunkCountLimit = 4; //Field offset: 0x0
	private const int DefaultChunkSizeThresholdKB = 512; //Field offset: 0x0
	private const float DefaultWebRequestTimeoutSeconds = 60; //Field offset: 0x0
	private const string DefaultApiVersion = "4.0"; //Field offset: 0x0
	private const string DefaultUserAgentString = null; //Field offset: 0x0
	private const string DefaultApplicationID = "subwaysurf"; //Field offset: 0x0
	public const bool DefaultOnlyValidatedPurchases = True; //Field offset: 0x0
	public const int UndefinedGamesInSessionBeforeFirstFlush = -1; //Field offset: 0x0
	public const int UndefinedMaxGamesWithoutFlush = -1; //Field offset: 0x0
	private const int DefaultSessionTimeoutSeconds = 1800; //Field offset: 0x0
	public const int DefaultMaxGamesWithoutFlush = 10; //Field offset: 0x0
	public const float DefaultSamplingThreshold = 0; //Field offset: 0x0
	public const string DefaultBaseURL = null; //Field offset: 0x0
	public const bool DefaultFlushEnabled = True; //Field offset: 0x0
	public const bool DefaultEnabled = False; //Field offset: 0x0
	private const float MaxLiveSamplingThreshold = 0.1; //Field offset: 0x0
	public const int DefaultGamesInSessionBeforeFirstFlush = 1; //Field offset: 0x0
	private const float DebugDefaultSamplingThreshold = 1; //Field offset: 0x0
	private const string DebugDefaultUserAgentString = "subwaysurf/01.69.00"; //Field offset: 0x0
	private const string DebugDefaultApplicationID = "subwaysurf"; //Field offset: 0x0
	private const string DebugDefaultBaseURL = "https://subwaysurf.dev.bladesofbrim.com"; //Field offset: 0x0
	private readonly byte[] DefaultKey; //Field offset: 0x8
	public bool Enabled; //Field offset: 0xC
	public bool FlushEnabled; //Field offset: 0xD
	public string BaseURL; //Field offset: 0x10
	private float _samplingThreshold; //Field offset: 0x14
	public int MaxGamesWithoutFlush; //Field offset: 0x18
	public int GamesInSessionBeforeFirstFlush; //Field offset: 0x1C
	public bool OnlyValidatedPurchases; //Field offset: 0x20
	public string ApplicationID; //Field offset: 0x24
	public string ApiVersion; //Field offset: 0x28
	public float WebRequestTimeoutSeconds; //Field offset: 0x2C
	public int SessionTimeoutSeconds; //Field offset: 0x30
	public int ChunkSizeThresholdKB; //Field offset: 0x34
	public int StorageLimitKB; //Field offset: 0x38
	public byte[] Key; //Field offset: 0x3C
	public string UserAgentString; //Field offset: 0x40

	public float SamplingThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 111
	}

	public AnalyticsSettings() { }

	public void CopyFrom(AnalyticsSettings other) { }

	public float get_SamplingThreshold() { }

	public void set_SamplingThreshold(float value) { }

	private void SetCommonDefaults() { }

	public void SetDebugDefaults() { }

	public void SetDefaults() { }

}

