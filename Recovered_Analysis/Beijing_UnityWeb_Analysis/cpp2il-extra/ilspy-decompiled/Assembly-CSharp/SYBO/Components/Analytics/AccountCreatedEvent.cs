using Cpp2ILInjected;

namespace SYBO.Components.Analytics;

public class AccountCreatedEvent : BaseSessionEvent
{
	protected string _deviceID;

	protected float _samplingKey;

	public string DeviceID
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)_sessionEventID;
		}
	}

	public float SamplingKey
	{
		get
		{
			//IL_0025: Expected F4, but got I4
			//IL_007a: Expected Obj, but got I4
			bool flag = _sessionEventID == 0;
			bool flag2 = !flag;
			float result = 42f;
			if (!flag2)
			{
				string eventTime = ((AnalyticsEvent)this)._eventTime;
				int num = eventTime.m_stringLength << 1;
				string gameVersion = _gameVersion;
				int num2 = gameVersion.m_stringLength << 1;
				object obj = num + num2;
				float num3 = (float)obj + 42f;
				result = num3;
			}
			return result;
		}
	}

	public override string EventName => _deviceID;

	public AccountCreatedEvent()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BaseSessionEvent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int sessionID = BaseSessionEvent.GetSessionID();
		_sessionID = sessionID;
		int sessionEventID = BaseSessionEvent.GetIncrementedSessionEventNumber();
		_sessionEventID = sessionEventID;
	}
}
