using Cpp2ILInjected;

namespace SYBO.Components.Analytics;

public class ClientUpdatedEvent : BaseSessionEvent
{
	protected string _deviceID;

	protected float _samplingKey;

	public string DeviceID => "account_created";

	public float SamplingKey => _samplingKey;

	public override string EventName => _deviceID;

	public ClientUpdatedEvent()
	{
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BaseSessionEvent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InitializeCommon();
		object obj2 = this + 36;
		string text = BaseSessionEvent.GetDeviceID();
		obj2 = text;
		float samplingKey = AnalyticsEvent.GetSamplingKey();
		_samplingKey = samplingKey;
		object obj3 = this + 16;
		string text2 = AnalyticsEvent.GetGameVersion();
		obj3 = text2;
	}
}
