using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics.Integration;

[Serializable]
public class AnalyticsSettings
{
	private const bool DebugDefaultEnabled = false;

	private const string DebugDefaultBaseURL = "https://subwaysurf.dev.bladesofbrim.com";

	private const string DebugDefaultApplicationID = "subwaysurf";

	private const string DebugDefaultUserAgentString = "subwaysurf/01.69.00";

	private const float DebugDefaultSamplingThreshold = 1f;

	private const int DebugDefaultMaxGamesWithoutFlush = 10;

	public const bool DefaultEnabled = false;

	public const bool DefaultFlushEnabled = true;

	public const string DefaultBaseURL = null;

	public const float DefaultSamplingThreshold = 0f;

	public const int DefaultMaxGamesWithoutFlush = 10;

	public const int DefaultGamesInSessionBeforeFirstFlush = 1;

	public const int UndefinedMaxGamesWithoutFlush = -1;

	public const int UndefinedGamesInSessionBeforeFirstFlush = -1;

	private const string DefaultApplicationID = "subwaysurf";

	private const string DefaultUserAgentString = null;

	private const string DefaultApiVersion = "4.0";

	private const float DefaultWebRequestTimeoutSeconds = 60f;

	private const int DefaultSessionTimeoutSeconds = 1800;

	private const int DefaultChunkSizeThresholdKB = 512;

	private const int DefaultChunkCountLimit = 4;

	private const int DefaultStorageLimitKB = 2048;

	private readonly byte[] DefaultKey;

	private const string DefaultFilename = "analytics.log";

	public bool Enabled;

	public bool FlushEnabled;

	public string BaseURL;

	public float SamplingThreshold;

	public int MaxGamesWithoutFlush;

	public int GamesInSessionBeforeFirstFlush;

	public string ApplicationID;

	public string ApiVersion;

	public float WebRequestTimeoutSeconds;

	public int SessionTimeoutSeconds;

	public int ChunkSizeThresholdKB;

	public int StorageLimitKB;

	public byte[] Key;

	public string UserAgentString;

	public void SetDefaults()
	{
		BaseURL = null;
		Enabled = false;
		ApplicationID = "subwaysurf";
		UserAgentString = null;
		GamesInSessionBeforeFirstFlush = 1;
		SamplingThreshold = 0f;
		SetCommonDefaults();
	}

	public void SetDebugDefaults()
	{
		Enabled = false;
		BaseURL = "https://subwaysurf.dev.bladesofbrim.com";
		ApplicationID = "subwaysurf";
		UserAgentString = "subwaysurf/01.69.00";
		GamesInSessionBeforeFirstFlush = 1;
		SamplingThreshold = 1f;
		SetCommonDefaults();
	}

	private void SetCommonDefaults()
	{
		//IL_001f: Expected I4, but got I8
		ApiVersion = "4.0";
		ChunkSizeThresholdKB = 512;
		WebRequestTimeoutSeconds = 60f;
		byte[] defaultKey = DefaultKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] key = default;
		Key = key;
		DefaultKey.CopyTo(Key, 0);
	}

	public void CopyFrom(AnalyticsSettings other)
	{
		Enabled = other.Enabled;
		FlushEnabled = other.FlushEnabled;
		BaseURL = other.BaseURL;
		ApplicationID = other.ApplicationID;
		UserAgentString = other.UserAgentString;
		SamplingThreshold = other.SamplingThreshold;
		MaxGamesWithoutFlush = other.MaxGamesWithoutFlush;
		GamesInSessionBeforeFirstFlush = other.GamesInSessionBeforeFirstFlush;
		WebRequestTimeoutSeconds = other.WebRequestTimeoutSeconds;
		SessionTimeoutSeconds = other.SessionTimeoutSeconds;
		ChunkSizeThresholdKB = other.ChunkSizeThresholdKB;
		StorageLimitKB = other.StorageLimitKB;
		Key = other.Key;
	}

	public AnalyticsSettings()
	{
		//IL_0036: Expected I4, but got I8
		//IL_0066: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E._9967560374628462F8C1B417FD82B7433E95C4D6E55E811F5980A9B3E51A05BB));
		DefaultKey = (byte[])array;
		MaxGamesWithoutFlush = 10;
		FlushEnabled = true;
		ApplicationID = "subwaysurf";
		ApiVersion = "4.0";
		ChunkSizeThresholdKB = 512;
		WebRequestTimeoutSeconds = 60f;
	}
}
