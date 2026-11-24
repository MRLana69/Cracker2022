using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Kiloo;
using SYBO.Components.Analytics.Integration;
using SYBO.Components.Logging;
using SYBO.Components.Logging.Ftp;
using UnityEngine;

namespace SYBO.Components.Analytics;

public class AnalyticsManager
{
	private sealed class _003CWaitForResult_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AsyncRes res;

		public Action<byte[], int, string> receiver;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ba: Expected Obj, but got Unknown
				//IL_00c3: Expected Obj, but got I4
				//IL_00d7: Expected Obj, but got I4
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				AsyncRes asyncRes = res;
				if (~(asyncRes.IsReady ? 1u : 0u) == 0)
				{
					AsyncRes asyncRes2 = res;
					AsyncRes asyncRes3 = res;
					AsyncRes asyncRes4 = res;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
					return null;
				}
				object obj = this + 12;
				obj = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CWaitForResult_003Ed__44(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_004d: Expected Obj, but got I4
			//IL_006d: Expected I4, but got Obj
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected Obj, but got Unknown
			//IL_0042: Expected I4, but got Obj
			string text = ((string)this).Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)text, -1);
			string text2 = ((string)this).InternalSubString(0, 3);
			IFormatProvider provider = (IFormatProvider)(dataContainer + 68);
			bool flag = ((int*)text2)->System_002EIConvertible_002EToBoolean(provider);
			return (byte)(int)dataContainer != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public static readonly string DefaultUserID;

	private Action<string> m_OnEventPosted;

	private Action m_OnSendEventsChunkToServerStarted;

	private Action<ProcessAnalyticsEventsResponse> m_OnSendEventsChunkToServerFinished;

	private IPostAnalytics Endpoint__BackingField;

	private bool _validUser;

	private bool _inFlush;

	private ProcessAnalyticsEventsResponse _lastFlushServerResponse;

	private bool _flushDelayed;

	private bool _retryOnTimeoutOr5xxError;

	private DateTime _deviceStartupTime;

	private string _userID;

	private string _gameVersion;

	private PersistentAnalyticsEventLog _eventLog;

	private ICoroutineHandler _coroutineHost;

	private static long _tickOffset;

	private static long _lastTick;

	public IPostAnalytics Endpoint
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		set
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSendEventsChunkToServerFinished;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public bool InFlush
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)Endpoint__BackingField != 0;
		}
	}

	public ProcessAnalyticsEventsResponse LastFlushServerResponse => _inFlush ? ProcessAnalyticsEventsResponse.RequestError : ProcessAnalyticsEventsResponse.None;

	public bool HasValidUserID => (byte)_lastFlushServerResponse != 0;

	public string GameVersion
	{
		get
		{
			return _gameVersion;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	public event Action<string> OnEventPosted
	{
		add
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0113: Expected I, but got Obj
			//IL_0129: Expected Obj, but got I
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			this.m_OnEventPosted = value;
			nint num3 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v20 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Log.Analytics = (AnalyticsLogCategory)(object)this;
			object obj3 = this + 12;
			obj3 = "Analytics";
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnEventPosted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action OnSendEventsChunkToServerStarted
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnEventPosted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSendEventsChunkToServerStarted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<ProcessAnalyticsEventsResponse> OnSendEventsChunkToServerFinished
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSendEventsChunkToServerStarted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSendEventsChunkToServerFinished;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public AnalyticsManager(IPostAnalytics endpoint, PersistentAnalyticsEventLog eventLog, ICoroutineHandler coroutineHost)
	{
		//IL_001e: Expected I4, but got Obj
		//IL_002c: Expected I4, but got Obj
		//IL_0256: Expected I4, but got Obj
		//IL_0264: Expected I4, but got Obj
		//IL_0074: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_018c: Expected I4, but got Obj
		//IL_018c: Expected I4, but got Obj
		//IL_018c: Expected I4, but got Obj
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_0099: Expected I4, but got Obj
		//IL_02a0: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_01df: Expected I, but got Obj
		//IL_0166: Expected I4, but got Obj
		//IL_011d: Expected I4, but got Obj
		if (_userID == null)
		{
			((FtpClient)this).Close();
		}
		((AnalyticsLogCategory)this)._002Ector((int)string.ConcatArray((string[])(object)"RNFR ", (int)endpoint));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsManager)+2C]");
		if ((nint)0 != 350)
		{
			string text = ((string)_flushDelayed).Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)text, -1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (coroutineHost == null)
		{
			string mD5Hash = ((PersistentAnalyticsEventLog)this).GetMD5Hash((byte[])(object)eventLog);
			if (mD5Hash.m_firstChar != '\0')
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				AggregatedDataTracking.DataContainer dataContainer2 = default;
				dataContainer2._002Ector((AggregatedDataTracking.DataCompleteness)"File already exists", -1);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		string text2 = string.ConcatArray((string[])(object)"RNTO ", (int)eventLog);
		((AnalyticsLogCategory)this)._002Ector((int)text2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsManager)+2C]");
		if ((nint)0 != 250)
		{
			string text3 = ((string)_flushDelayed).Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer3 = default;
			dataContainer3._002Ector((AggregatedDataTracking.DataCompleteness)text3, -1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		int num = "[FtpClient] Renamed file ".IndexOf((char)(int)endpoint, (int)" to ", (int)eventLog);
		nint num2 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v16 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v21 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(num);
	}

	private string GetGameVersion()
	{
		//IL_0019: Expected Obj, but got I4
		bool validUser = _validUser;
		return (string)validUser;
	}

	public void Shutdown()
	{
	}

	public void PostEvent<T>(T eventData) where T : AnalyticsEvent
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009d: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Exception);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Exception)this).SetErrorCode((int)eventData);
	}

	public void SetUserID(string userID)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 52;
		obj = userID;
	}

	public void ChangeUserID(string userID)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		if (!(_userID != userID))
		{
			object obj = this + 48;
			obj = userID;
			_validUser = true;
			if (~(_flushDelayed ? 1u : 0u) == 0)
			{
				_flushDelayed = false;
				FlushInternal();
			}
		}
	}

	public void Flush()
	{
		_eventLog.ConsumeChunk();
	}

	private DateTime GetDeviceStartupTime()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		object obj = default;
		return (DateTime)(obj - 32);
	}

	private string GetUserID()
	{
		return _gameVersion;
	}

	private void PostEvent(string eventJson)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		if (!(_userID != eventJson))
		{
			((MTRandomGen)(object)_eventLog)._002Ector(0u, 0);
			object obj = this + 48;
			obj = eventJson;
			_validUser = true;
			if (~(_flushDelayed ? 1u : 0u) == 0)
			{
				_flushDelayed = false;
				FlushInternal();
			}
		}
	}

	private void FlushInternal()
	{
		if (~(_validUser ? 1u : 0u) == 0)
		{
			if (~(_inFlush ? 1u : 0u) != 0)
			{
				_retryOnTimeoutOr5xxError = true;
				((AnalyticsEvent)this)._002Ector();
			}
		}
		else
		{
			_flushDelayed = true;
		}
	}

	private unsafe IEnumerator WaitForResult(AsyncRes res, Action<byte[], int, string> receiver)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected VT, but got Unknown
		//IL_00f4: Expected F4, but got Obj
		//IL_00ef: Expected native int or pointer, but got VT
		//IL_0110: Expected Obj, but got F4
		//IL_013f: Expected I, but got Obj
		//IL_0155: Expected Obj, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected VT, but got Unknown
		//IL_01ab: Expected F4, but got Obj
		//IL_01a6: Expected native int or pointer, but got VT
		//IL_01b8: Expected F4, but got Obj
		//IL_01b3: Expected native int or pointer, but got VT
		//IL_006b: Invalid comparison between F4 and Obj
		//IL_0076: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		int height = Screen.height;
		int sleepTimeout = Screen.sleepTimeout;
		object obj3 = obj2 + 16;
		obj3 = 0;
		obj3 = height;
		object obj4 = obj2 + 24;
		obj4 = obj3;
		Vector2 vector = (Vector2)(obj2 + 48);
		((Vector2*)(nint)vector)->x = (float)obj4;
		float num = (float)receiver * vector.x;
		Action<byte[], int, string> action = (Action<byte[], int, string>)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [receiver @ L2 (System.Action`3<System.Byte[], System.Int32, System.String>)+4]");
		float num2 = 0f * vector.y;
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v44 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 8;
		obj6 = res;
		obj2 = receiver;
		Vector2 vector2 = (Vector2)(obj2 + 40);
		((Vector2*)(nint)vector2)->x = (float)obj6;
		((Vector2*)(nint)vector)->x = (float)obj2;
		Vector2 vector3 = vector2 * vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1143A");
		float value = UnityEngine.Random.value;
		object obj7 = default;
		float num5 = (float)obj7 / value;
		Action<ProcessAnalyticsEventsResponse> onSendEventsChunkToServerFinished = this.m_OnSendEventsChunkToServerFinished;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num5) < System.Runtime.CompilerServices.Unsafe.As<Action<ProcessAnalyticsEventsResponse>, UIntPtr>(ref onSendEventsChunkToServerFinished);
		return (IEnumerator)flag;
	}

	private void HandleJsonChunk(byte[] eventsJson, int uncompressedChunkLength, string uncompressedMD5Hash)
	{
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got I4
		//IL_01f0: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I8
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_026c: Expected VT, but got Obj
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		object obj3 = this + 48;
		obj3 = "";
		object obj4 = this + 52;
		obj4 = "";
		object obj5 = this + 20;
		obj5 = eventsJson;
		object obj6 = this + 56;
		obj6 = uncompressedChunkLength;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<System.DateTime>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v81 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		obj = systemTimeAsFileTime;
		nint num3 = (nint)typeof(AnalyticsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(AnalyticsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v77 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime eventTime = AnalyticsEvent.GetEventTime();
		object obj9 = 0 - eventTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9D");
		object obj10 = default;
		obj2 = obj10;
		object obj11 = obj2 + 16;
		obj11 = obj2;
		_deviceStartupTime = (DateTime)obj11;
		object obj12 = this + 48;
		obj12 = DefaultUserID;
		_validUser = false;
		object obj13 = this + 60;
		obj13 = uncompressedMD5Hash;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj15 = default;
		object obj14 = obj15 + 16;
		obj14 = this;
		nint num6 = (nint)typeof(AnalyticsEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v48 (Il2CppClass<SYBO.Components.Analytics.AnalyticsEvent>)+5C]");
		object obj16 = (nint)0 + (nint)4;
		obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		object obj18 = default;
		object obj17 = obj18 + 16;
		obj17 = this;
		nint num8 = (nint)typeof(AnalyticsEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v61 (Il2CppClass<SYBO.Components.Analytics.AnalyticsEvent>)+5C]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Func<string> func = default;
		object obj20 = func + 16;
		obj20 = this;
		AnalyticsEvent.GetGameVersion = func;
	}

	private void HandlePostAnalyticsReponse(ProcessAnalyticsEventsResponse response)
	{
		//IL_0029: Expected Obj, but got I4
		//IL_0014: Expected Obj, but got I4
		_eventLog.WorkerThreadLoop((object)response);
		if (this.m_OnEventPosted != null)
		{
			this.m_OnEventPosted((string)response);
		}
	}

	public unsafe static long GetMsTicksSinceDeviceStartup()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got VT
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected VT, but got Unknown
		//IL_0171: Expected I8, but got Obj
		//IL_016c: Expected native int or pointer, but got VT
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0194: Expected Ref, but got VT
		//IL_00a1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v38 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime latestSuccessfulCloudSaveSyncTime = UserSave.latestSuccessfulCloudSaveSyncTime;
		obj = latestSuccessfulCloudSaveSyncTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		DateTime today = CDateTime.Today;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v34 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 8;
		object obj6 = default;
		obj5 = obj6;
		obj2 = today;
		DateTime dateTime = (DateTime)(obj2 + 24);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
		formatProvider = (IFormatProvider)obj2;
		return ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
	}

	static AnalyticsManager()
	{
		AnalyticsIntegrationConstants.PrefsKeyLeavesForegroundTimeDefault = string.Empty;
	}
}
