using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Validators;
using UnityEngine;

namespace SYBO.Components.Analytics.Integration;

[Serializable]
public class AnalyticsSettings
{
	private const bool DebugDefaultEnabled = false;

	private const string DebugDefaultBaseURL = "https://subwaysurf.dev.bladesofbrim.com";

	private const string DebugDefaultApplicationID = "subwaysurf";

	private const string DebugDefaultUserAgentString = "subwaysurf/01.69.00";

	private const float DebugDefaultSamplingThreshold = 1f;

	private const float MaxLiveSamplingThreshold = 0.1f;

	public const bool DefaultEnabled = false;

	public const bool DefaultFlushEnabled = true;

	public const string DefaultBaseURL = null;

	public const float DefaultSamplingThreshold = 0f;

	public const int DefaultMaxGamesWithoutFlush = 10;

	public const int DefaultGamesInSessionBeforeFirstFlush = 1;

	public const int UndefinedMaxGamesWithoutFlush = -1;

	public const int UndefinedGamesInSessionBeforeFirstFlush = -1;

	public const bool DefaultOnlyValidatedPurchases = true;

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

	private float _samplingThreshold;

	public int MaxGamesWithoutFlush;

	public int GamesInSessionBeforeFirstFlush;

	public bool OnlyValidatedPurchases;

	public string ApplicationID;

	public string ApiVersion;

	public float WebRequestTimeoutSeconds;

	public int SessionTimeoutSeconds;

	public int ChunkSizeThresholdKB;

	public int StorageLimitKB;

	public byte[] Key;

	public string UserAgentString;

	public float SamplingThreshold
	{
		get
		{
			return _samplingThreshold;
		}
		set
		{
			//IL_001e: Expected Obj, but got F4
			float num = value * 100f;
			object obj = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text = $"Progress: {args:0.00}%";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	public void SetDefaults()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_00b7: Expected VT, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Key = (byte[])AnalyticsIntegration.CurrentSessionPersistedDefault;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Queue<> queue = default;
		((Queue<T>)(object)queue).Enqueue((T)4);
		object obj2 = this + 80;
		obj2 = queue;
		_ = -1;
		((Validator<>)this)._002Ector();
	}

	public void SetDebugDefaults()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0057: Expected Obj, but got I4
		Enabled = false;
		FlushEnabled = true;
		object obj = this + 16;
		obj = 0;
		object obj2 = this + 36;
		obj2 = "subwaysurf";
		object obj3 = this - -64;
		obj3 = 0;
		_samplingThreshold = 0f;
		this._002Ector();
	}

	private void SetCommonDefaults()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		Enabled = false;
		FlushEnabled = true;
		object obj = this + 16;
		obj = "https://subwaysurf.dev.bladesofbrim.com";
		object obj2 = this + 36;
		obj2 = "subwaysurf";
		object obj3 = this - -64;
		obj3 = "subwaysurf/01.69.00";
		_samplingThreshold = 1f;
		this._002Ector();
	}

	public void CopyFrom(AnalyticsSettings other)
	{
		Coroutine coroutine = ((MonoBehaviour)this).StartCoroutine_Auto((IEnumerator)other);
	}

	public AnalyticsSettings()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0082: Expected I4, but got Obj
		object obj = this + 40;
		obj = "4.0";
		WebRequestTimeoutSeconds = 60f;
		SessionTimeoutSeconds = 1800;
		ChunkSizeThresholdKB = 512;
		StorageLimitKB = 2048;
		object obj2 = this + 60;
		byte[] defaultKey = DefaultKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = default;
		obj2 = obj3;
		Array.Reverse((Array)DefaultKey, (int)Key, 0);
		MaxGamesWithoutFlush = 10;
		GamesInSessionBeforeFirstFlush = 1;
		OnlyValidatedPurchases = true;
	}
}
