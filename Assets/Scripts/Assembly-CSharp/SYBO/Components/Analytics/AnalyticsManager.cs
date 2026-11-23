using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Analytics;

public class AnalyticsManager
{
	private sealed class _003CWaitForResult_003Ed__41(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AsyncRes res;

		public Action<byte[], int, string> receiver;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected Obj, but got Unknown
			if (_003C_003E1__state < 2)
			{
				_003C_003E1__state = -1;
				AsyncRes asyncRes = res;
				object obj2 = default;
				object obj = obj2 - 16;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v15+F]");
				_ = 0;
				if (~(asyncRes.IsReady ? 1u : 0u) != 0)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				AsyncRes asyncRes2 = res;
				Action<byte[], int, string> action = receiver;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S0_v31 (System.Action`3<System.Byte[], System.Int32, System.String>)+C] (should have been resolved before IL gen)");
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public static readonly string DefaultUserID = "00000000-0000-f000-0000-000000000000";

	private bool _validUser;

	private bool _inFlush;

	private ProcessAnalyticEventsResponse _lastFlushServerResponse;

	private bool _flushDelayed;

	private bool _retryOnTimeoutOr5xxError;

	private DateTime _deviceStartupTime;

	private string _userId;

	private PersistentAnalyticsEventLog _eventLog;

	private ICoroutineHandler _coroutineHost;

	private static long _tickOffset;

	private static long _lastTick = -1L;

	private IPostAnalytics Endpoint__BackingField;

	private Action<string> m_OnEventPosted;

	private Action m_OnEventChunkSendingStarting;

	private Action<ProcessAnalyticEventsResponse> m_OnEventChunkSendingCompleted;

	public IPostAnalytics Endpoint
	{
		get
		{
			return Endpoint__BackingField;
		}
		set
		{
			Endpoint__BackingField = value;
		}
	}

	public bool InFlush => _inFlush;

	public ProcessAnalyticEventsResponse LastFlushServerResponse => _lastFlushServerResponse;

	public bool HasValidUserID => _validUser;

	public event Action<string> OnEventPosted
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_OnEventPosted;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_OnEventPosted;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action OnEventChunkSendingStarting
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_OnEventChunkSendingStarting;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_OnEventChunkSendingStarting;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<ProcessAnalyticEventsResponse> OnEventChunkSendingCompleted
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_OnEventChunkSendingCompleted;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_OnEventChunkSendingCompleted;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public unsafe AnalyticsManager(IPostAnalytics endpoint, PersistentAnalyticsEventLog eventLog, ICoroutineHandler coroutineHost)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_0047: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_userId = string.Empty;
		Endpoint__BackingField = endpoint;
		_eventLog = eventLog;
		DateTime utcNow = DateTime.UtcNow;
		DateTime dateTime = (DateTime)(obj + 8);
		long msTicksSinceDeviceStartup = GetMsTicksSinceDeviceStartup();
		double value = 0.0 - (double)msTicksSinceDeviceStartup;
		DateTime deviceStartupTime = ((DateTime*)dateTime)->AddMilliseconds(value);
		_deviceStartupTime = deviceStartupTime;
		_userId = DefaultUserID;
		_coroutineHost = coroutineHost;
		_validUser = false;
		throw new ArgumentException();
	}

	public void Shutdown()
	{
		_eventLog.Shutdown();
	}

	public void PostEvent<T>(T eventData) where T : AnalyticsEvent
	{
		//IL_000d: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		if (eventData != null)
		{
			nint num = (nint)eventData;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v4 (Il2CppClass<T>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			nint num2 = 0;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S4_v3 (Il2CppMethodRgctx<SYBO.Components.Analytics.AnalyticsManager::PostEvent>)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S4_v4+4] (should have been resolved before IL gen)");
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S3_v6 (Il2CppMethodRgctx<SYBO.Components.Analytics.AnalyticsManager::PostEvent>)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S3_v7+4] (should have been resolved before IL gen)");
			string text = default;
			LogManager.LogLongString(Log.Analytics, 2, text);
			PostEvent(text);
		}
	}

	public void SetUserID(string userID)
	{
		if (_userId != userID)
		{
			_userId = userID;
			_validUser = true;
			if (~(_flushDelayed ? 1u : 0u) == 0)
			{
				_flushDelayed = false;
				Flush();
			}
		}
	}

	public void ChangeUserID(string userID)
	{
		if (_userId != userID)
		{
			_eventLog.Replace((string)(object)this, (string)(object)this);
			_userId = userID;
			_validUser = true;
			if (~(_flushDelayed ? 1u : 0u) == 0)
			{
				_flushDelayed = false;
				Flush();
			}
		}
	}

	public void Flush()
	{
		if (~(_validUser ? 1u : 0u) != 0)
		{
			_flushDelayed = true;
		}
		else if (~(_inFlush ? 1u : 0u) != 0)
		{
			_retryOnTimeoutOr5xxError = true;
			FlushInternal();
		}
	}

	private DateTime GetDeviceStartupTime()
	{
		return _deviceStartupTime;
	}

	private string GetUserId()
	{
		return _userId;
	}

	private void PostEvent(string eventJson)
	{
		_eventLog.Append(eventJson);
		Action<string> onEventPosted = this.m_OnEventPosted;
		if (this.m_OnEventPosted != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S0_v4 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void FlushInternal()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (Endpoint__BackingField == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			float time = Time.time;
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
		_inFlush = true;
		AsyncRes nextChunkForServerAsync = _eventLog.GetNextChunkForServerAsync();
		throw new ArgumentException();
	}

	private IEnumerator WaitForResult(AsyncRes res, Action<byte[], int, string> receiver)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void HandleJsonChunk(byte[] eventsJson, int uncompressedChunkLength, string uncompressedMD5Hash)
	{
		if (eventsJson == null || eventsJson.Length <= 2)
		{
			_inFlush = false;
			return;
		}
		Action onEventChunkSendingStarting = this.m_OnEventChunkSendingStarting;
		if (this.m_OnEventChunkSendingStarting != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		throw new ArgumentException();
	}

	private void HandlePostAnalyticsReponse(ProcessAnalyticEventsResponse response)
	{
		//IL_0018: Expected Obj, but got I4
		_lastFlushServerResponse = response;
		object obj = response - 3;
		if ((nint)obj <= 1)
		{
			_eventLog.ConsumeChunk();
		}
		Action<ProcessAnalyticEventsResponse> onEventChunkSendingCompleted = this.m_OnEventChunkSendingCompleted;
		if (this.m_OnEventChunkSendingCompleted != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S0_v7 (System.Action`1<SYBO.Components.Analytics.ProcessAnalyticEventsResponse>)+C] (should have been resolved before IL gen)");
		}
		if (response >= ProcessAnalyticEventsResponse.BackendUnavailable)
		{
			if (response != ProcessAnalyticEventsResponse.BackendUnavailable)
			{
				PersistentAnalyticsEventLog eventLog = _eventLog;
				_retryOnTimeoutOr5xxError = true;
				if (eventLog.HasData__BackingField)
				{
					goto IL_0107;
				}
			}
			else
			{
				_retryOnTimeoutOr5xxError = false;
				if (~(_retryOnTimeoutOr5xxError ? 1u : 0u) == 0)
				{
					goto IL_0107;
				}
			}
		}
		_inFlush = false;
		return;
		IL_0107:
		FlushInternal();
	}

	public static long GetMsTicksSinceDeviceStartup()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CD");
		long num = default;
		if (num < _lastTick)
		{
			long tickOffset = _tickOffset + 4294967295L;
			_tickOffset = tickOffset;
		}
		_lastTick = num;
		return num + _tickOffset;
	}

	static AnalyticsManager()
	{
		//IL_0019: Expected I8, but got I4
	}
}
