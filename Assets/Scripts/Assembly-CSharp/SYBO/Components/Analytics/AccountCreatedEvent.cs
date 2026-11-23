using System;
using Cpp2ILInjected;
using SYBO.Components.Native;
using UnityEngine;

namespace SYBO.Components.Analytics;

public class AccountCreatedEvent : BaseSessionEvent
{
	protected string deviceID;

	protected float SamplingKey;

	protected string deviceOS;

	protected string device;

	protected string Language;

	protected string EventTime;

	protected string GameVersion;

	public override string EventName => "account_created";

	public AccountCreatedEvent()
	{
		Func<string> getDeviceID = BaseSessionEvent.GetDeviceID;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v6 (System.Func`1<System.String>)+C] (should have been resolved before IL gen)");
		string text = default;
		deviceID = text;
		string deviceModel = SystemInfo.GetDeviceModel();
		device = deviceModel;
		deviceOS = SystemInfo.GetOperatingSystem();
		Func<float> getSamplingKey = AnalyticsEvent.GetSamplingKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S1_v16 (System.Func`1<System.Single>)+C] (should have been resolved before IL gen)");
		float samplingKey = default;
		SamplingKey = samplingKey;
		Language = Locale.GetISOThreeLetterLanguageCode();
		EventTime = GetEventTimeText();
		Func<string> getGameVersion = AnalyticsEvent.GetGameVersion;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S1_v26 (System.Func`1<System.String>)+C] (should have been resolved before IL gen)");
		string gameVersion = default;
		GameVersion = gameVersion;
	}
}
