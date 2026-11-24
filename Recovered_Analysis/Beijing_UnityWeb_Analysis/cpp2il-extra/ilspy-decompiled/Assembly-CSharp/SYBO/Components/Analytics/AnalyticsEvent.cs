using System;
using System.IO;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Analytics;

public abstract class AnalyticsEvent
{
	protected string _userID;

	protected string _eventID;

	protected string _gameVersion;

	private string _eventTime;

	public static Func<string> GetGameVersion;

	public static Func<DateTime> GetDeviceStartupTime;

	public static Func<string> GetUserID;

	public static Func<float> GetSamplingKey;

	public string UserId
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsEvent)+30]");
			return (string)0;
		}
	}

	public string EventId => _userID;

	public string GameVersion => _eventID;

	public string EventTime => _gameVersion;

	public abstract string EventName { get; }

	public AnalyticsEvent()
	{
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I
		//IL_00c5: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I4
		//IL_005e: Expected I4, but got Obj
		if (_eventTime != null)
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsEvent)+38]");
			Stream chunkReader = ((PersistentAnalyticsEventLog)0).GetChunkReader();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			int num2 = default;
			object obj = num2 + 16;
			obj = this;
			int num3 = ((SyboRandom)null).Range((int)chunkReader, num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			return;
		}
		nint num4 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log.Analytics.LogException((Exception)(object)"AnalyticsManager: Tried to Flush, but Endpoint == null");
	}

	protected AnalyticsEvent(bool initializeValues)
	{
		//IL_0150: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I
		object obj = (initializeValues ? 1 : 0) + -3;
		if ((nint)obj < 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsEvent)+38]");
			((PersistentAnalyticsEventLog)0).UpdateChunkSizes();
		}
		if (_gameVersion != null)
		{
			_gameVersion(initializeValues ? ProcessAnalyticsEventsResponse.RequestError : ProcessAnalyticsEventsResponse.None);
		}
		if (initializeValues && !initializeValues)
		{
			if ((initializeValues ? 1 : 0) == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsEvent)+21]");
				bool flag = (nint)0 != 0;
				_ = 0;
				if (flag)
				{
					goto IL_0127;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsEvent)+38]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v23+50]");
				bool flag2 = (nint)0 != 0;
				_ = 1;
				if (flag2)
				{
					goto IL_0127;
				}
			}
		}
		_ = 0;
		return;
		IL_0127:
		this._002Ector();
	}

	protected AnalyticsEvent(bool initializeValues, DateTime eventTime)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0044: Expected I4, but got VT
		//IL_0022: Expected VT, but got Obj
		object obj = eventTime + 2147483648L;
		if ((long)obj > 4294967295L)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex = default;
			ex.GetObjectData((SerializationInfo)(object)"index", (StreamingContext)"Arrays larger than 2GB are not supported.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			Array.Reverse((Array)(object)this, initializeValues ? 1 : 0, (int)eventTime);
		}
	}

	public static DateTime GetEventTime()
	{
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_01cf: Expected I, but got Obj
		//IL_01e5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0219: Expected VT, but got I8
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A37");
		nint num = (nint)typeof(AnalyticsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AnalyticsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v45 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long num3 = default;
		if (AnalyticsManager._lastTick > num3)
		{
			nint num4 = (nint)typeof(AnalyticsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v32 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(AnalyticsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v39 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			long tickOffset = AnalyticsManager._tickOffset + 4294967295L;
			AnalyticsManager._tickOffset = tickOffset;
		}
		nint num6 = (nint)typeof(AnalyticsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v17 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(AnalyticsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v25 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AnalyticsManager._lastTick = num3;
		return (DateTime)(num3 + AnalyticsManager._tickOffset);
	}

	public static string GetTimeText(DateTime time)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public override string ToString()
	{
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
		object obj3 = default;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}
}
