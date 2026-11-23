using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Components.Json;
using UnityEngine;

namespace Kiloo.Common.Backend;

public class EventRemoteLogger : IEventRemoteLogger, IEventLogger
{
	private class Event
	{
		public string Name;

		public JsonDict Stats;

		public DateTime TimeStamp;
	}

	private class Session
	{
		public Guid SessionId;

		public string DeviceId;

		public DateTime StopTimeStamp;

		public List<Event> Events;

		public DateTime StartTimeStamp;

		public int Aborted;

		public Session()
		{
			List<Event> list = default;
			list._002Ector();
			Events = list;
		}
	}

	private struct SessionFileInfo
	{
		public string File;

		public Guid SessionId;
	}

	private sealed class _003CSendCoroutine_003Ed__40(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EventRemoteLogger _003C_003E4__this;

		public Action onComplete;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			EventRemoteLogger eventRemoteLogger = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_00e3;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (!eventRemoteLogger.isSending__BackingField)
				{
					eventRemoteLogger.Send(0f, 0f);
				}
			}
			if (!eventRemoteLogger.isSending__BackingField)
			{
				Action action = onComplete;
				if (onComplete != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				goto IL_00e3;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_00e3:
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

	public static readonly EventRemoteLogger instance;

	public bool isPartOfSample;

	public bool allowSending;

	public bool allowSaving;

	private const string FOLDER = "event_logs";

	private const string API_POST_EVENTS_ROUTE = "api/v2/log";

	private const int MAX_UNSENT_FILES = 25;

	private readonly TimeSpan _dataExpireTime;

	private Session _session;

	private byte[] _lastSavedData;

	private string _lastSavedFilename;

	private bool _didAddApplicationStateHandlers;

	private Uri _loggingServiceUri;

	private string _dataFolder;

	private int _maximumSessionPauseInSeconds;

	private bool _sendOnPause;

	private float _sendOnPauseMaximumSendTime;

	private float _sendOnPauseRequestTimeWindow;

	private bool isSending__BackingField;

	public bool isSending
	{
		get
		{
			return isSending__BackingField;
		}
		private set
		{
			isSending__BackingField = value;
		}
	}

	private EventRemoteLogger()
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		TimeSpan dataExpireTime = TimeSpan.FromDays(28.0);
		_maximumSessionPauseInSeconds = 600;
		_dataExpireTime = dataExpireTime;
		string userDataPath = DeviceUtility.GetUserDataPath();
		object obj;
		if (userDataPath != null)
		{
			obj = 0;
			if (userDataPath._stringLength != 0)
			{
				goto IL_00f3;
			}
		}
		obj = 1;
		goto IL_00f3;
		IL_00f3:
		if (obj == null)
		{
			string dataFolder = Path.Combine(userDataPath, "event_logs");
			_dataFolder = dataFolder;
			if (_dataFolder != null && !Directory.Exists(_dataFolder))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(_dataFolder);
			}
		}
	}

	public void SetServiceInfo(Uri baseUri, int maximumSessionPauseInSeconds = 600)
	{
		Uri uri = default;
		uri._002Ector(baseUri, "api/v2/log");
		_loggingServiceUri = uri;
		_maximumSessionPauseInSeconds = maximumSessionPauseInSeconds;
	}

	public void CheckSessionRemoval()
	{
		if (~(isPartOfSample ? 1u : 0u) == 0)
		{
			StartSession();
		}
		else
		{
			Save();
		}
	}

	private string GetSessionJSON()
	{
		//IL_009e: Expected VT, but got Obj
		InvalidOperationException ex = default;
		if (_session == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("EventLogger.GetSessionJSON: Session not started.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		JsonContext jsonContext = default;
		jsonContext._002Ector();
		jsonContext.RemoveWhitespace = false;
		return JsonApi.Serialize<T>((T)((EventRemoteLogger)(object)ex)._session, jsonContext);
	}

	public void LogEvent(string eventName, Dictionary<string, object> parameters = null)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		object obj;
		if (eventName != null)
		{
			obj = 0;
			if (eventName._stringLength != 0)
			{
				goto IL_013d;
			}
		}
		obj = 1;
		goto IL_013d;
		IL_013d:
		if (obj == null)
		{
			if (_session != null)
			{
				JsonDict stats = ((EventRemoteLogger)(object)parameters).ConvertFromDictionary(parameters);
				DateTime utcNow = DateTime.UtcNow;
				Event obj2 = default;
				obj2.Name = eventName;
				obj2.TimeStamp = utcNow;
				obj2.Stats = stats;
				Session session = _session;
				session.Events.Add(obj2);
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentException ex = default;
			ex._002Ector("name parameter cannot be null.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		InvalidOperationException ex2 = default;
		ex2._002Ector("EventLogger.LogEvent: Session not started.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	private JsonDict ConvertFromDictionary(Dictionary<string, object> dict)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		JsonDict jsonDict = default;
		jsonDict._002Ector();
		if (dict != null)
		{
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj4 = obj + 40;
			obj = obj4;
			_ = 0;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj10 = default;
			object obj11 = default;
			JsonDict result = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					obj = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj7 != obj8;
				object obj9 = obj10;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj9 = obj11;
				}
				_ = 0;
				object obj12 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return result;
			}
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDF");
		}
		return jsonDict;
	}

	public void Send(float maximumSendTime, float requestTimeWindow)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_0665: Invalid comparison between I and F4
		//IL_0122: Expected Obj, but got I4
		//IL_0482: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_0512: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (~(allowSending ? 1u : 0u) != 0)
		{
			return;
		}
		object obj4;
		if (!(_loggingServiceUri == null))
		{
			if (_dataFolder == null || isSending__BackingField)
			{
				return;
			}
			isSending__BackingField = true;
			DateTime utcNow = DateTime.UtcNow;
			_ = _lastSavedData;
			_ = _lastSavedFilename;
			string[] files = Directory.GetFiles(_dataFolder, "*");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
			Array.Sort((string[])0);
			string bundleVersion = DeviceUtility.GetBundleVersion();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+28]");
			if ((nint)0 != 0)
			{
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v141+8]");
				if ((nint)0 != 0)
				{
					goto IL_05e8;
				}
			}
			obj4 = 1;
			goto IL_05e8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		InvalidOperationException ex = default;
		ex._002Ector("EventLogger.Send: ServiceUri not initialized.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		InvalidOperationException ex2 = ex;
		goto IL_0645;
		IL_0654:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+C]");
		if (!(0f > 0f))
		{
			return;
		}
		while (((Exception)ex2).native_trace_ips != null)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(5.0);
			Utils.ThreadSleep(timeSpan);
			DateTime utcNow2 = DateTime.UtcNow;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+10]");
			TimeSpan timeSpan2 = utcNow2 - (DateTime)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num = 0.0 * 1E-07;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+C]");
			double num2 = 0.0 - num;
			if (!(num2 > 0.0))
			{
				((Exception)ex2).native_trace_ips = null;
				break;
			}
		}
		return;
		IL_05e8:
		if (obj4 != null)
		{
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+28]");
			string text = (string)0 + "-DBG";
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag = (nint)0 == 1;
		ex2 = (InvalidOperationException)(object)this;
		if (!flag)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			ex2 = (InvalidOperationException)(object)this;
			if (!flag2)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					ex2 = (InvalidOperationException)(object)this;
					goto IL_0275;
				}
				ex2 = (InvalidOperationException)(object)this;
				object obj5 = default;
				if (obj5 != null)
				{
					goto IL_0654;
				}
				ex2 = (InvalidOperationException)(object)this;
				goto IL_0684;
			}
		}
		goto IL_0645;
		IL_0275:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag3 = obj6 == obj7;
		bool flag4 = !flag3;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj11 = default;
				object obj10 = obj11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = default;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj + obj13;
						obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj16 = -1;
						goto IL_0684;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj17 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						return;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			ex2 = (InvalidOperationException)0;
			object obj18 = default;
			obj8 = obj18;
			if (flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0684;
		IL_0645:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0275;
		IL_0684:
		((Exception)ex2).native_trace_ips = null;
		goto IL_0654;
	}

	public Coroutine SendAsync(Action onComplete = null)
	{
		IEnumerator coroutine = SendCoroutine(onComplete);
		return CoroutineUtil.StartCoroutine(coroutine);
	}

	public void SendOnPause(bool enable, float maximumSendTime = 3f, float requestTimeWindow = 2f)
	{
		_sendOnPauseRequestTimeWindow = requestTimeWindow;
		_sendOnPauseMaximumSendTime = maximumSendTime;
		_sendOnPause = enable;
	}

	private void Save()
	{
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		//IL_00a4: Expected I, but got Obj
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		if (_session != null && _dataFolder != null)
		{
			DateTime utcNow = DateTime.UtcNow;
			Session session = _session;
			session.StopTimeStamp = utcNow;
			Session session2 = _session;
			bool aborted = (byte)(~(isPartOfSample ? 1u : 0u)) != 0;
			session2.Aborted = (aborted ? 1 : 0);
			if (~(allowSaving ? 1u : 0u) == 0)
			{
				string sessionJSON = GetSessionJSON();
				Encoding uTF = Encoding.UTF8;
				nint num = (nint)uTF;
				object obj = uTF + 152;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ S2_v4 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
				string text = TimeUtility.ToSortableNumber(utcNow);
				string path = Path.Combine(_dataFolder, text);
				byte[] array = default;
				FileUtil.Save(path, array);
				_lastSavedData = array;
				_lastSavedFilename = text;
			}
			Session session3 = _session;
			((List<T>)(object)session3.Events).Clear();
			if (!isPartOfSample)
			{
				object obj2 = this + 24;
				obj2 = 0;
			}
		}
	}

	private unsafe void StartSession()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_024a: Expected VT, but got I
		//IL_00b4: Invalid comparison between I4 and F8
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		Session session = _session;
		if (_session != null)
		{
			if (session.StopTimeStamp != DateTime.MinValue)
			{
				Session session2 = _session;
				session2.StopTimeStamp = DateTime.MinValue;
				DateTime utcNow = DateTime.UtcNow;
				TimeSpan timeSpan = utcNow - session2.StopTimeStamp;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				double num = 0.0 * 1E-07;
				if (!((double)_maximumSessionPauseInSeconds > num))
				{
					goto IL_01fb;
				}
			}
			goto IL_01d7;
		}
		Session session3 = default;
		session3._002Ector();
		_session = session3;
		goto IL_01fb;
		IL_01fb:
		Session session4 = _session;
		Guid guid = Guid.NewGuid();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		session4.SessionId = (Guid)0;
		Session session5 = _session;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		string flurryUserId = playerInfo.FlurryUserId;
		session5.DeviceId = flurryUserId;
		Session session6 = _session;
		DateTime utcNow2 = DateTime.UtcNow;
		session6.StartTimeStamp = utcNow2;
		goto IL_01d7;
		IL_01d7:
		if (~(_didAddApplicationStateHandlers ? 1u : 0u) != 0)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(EventRemoteLogger.OnApplicationQuit));
			ApplicationState.quit += action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(EventRemoteLogger.OnApplicationPause));
			ApplicationState.paused += action2;
			Action action3 = default;
			action3._002Ector(this, (nint)__ldftn(EventRemoteLogger.OnApplicationResume));
			ApplicationState.resumed += action3;
			_didAddApplicationStateHandlers = true;
		}
	}

	private void CleanAndSend()
	{
		CleanupOldUnsentFiles();
		Coroutine coroutine = SendAsync();
	}

	private unsafe void OnApplicationQuit()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(EventRemoteLogger.OnApplicationQuit));
		ApplicationState.quit -= action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(EventRemoteLogger.OnApplicationPause));
		ApplicationState.paused -= action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(EventRemoteLogger.OnApplicationResume));
		ApplicationState.resumed -= action3;
		_didAddApplicationStateHandlers = false;
		if (~(isPartOfSample ? 1u : 0u) == 0)
		{
			Save();
		}
	}

	private void OnApplicationResume()
	{
		if (~(isPartOfSample ? 1u : 0u) == 0)
		{
			CleanAndSend();
			StartSession();
		}
	}

	private void OnApplicationPause()
	{
		if (~(isPartOfSample ? 1u : 0u) == 0)
		{
			Save();
		}
		if (~(_sendOnPause ? 1u : 0u) == 0)
		{
			Send(_sendOnPauseMaximumSendTime, _sendOnPauseRequestTimeWindow);
		}
	}

	private IEnumerator SendCoroutine(Action onComplete)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void CleanupOldUnsentFiles()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b07: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1033: Expected Obj, but got Unknown
		//IL_103c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Expected Obj, but got Unknown
		//IL_104a: Unknown result type (might be due to invalid IL or missing references)
		//IL_104f: Expected Obj, but got Unknown
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Ref, but got Unknown
		//IL_1b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3b: Expected Obj, but got Unknown
		//IL_106b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_0179: Expected I, but got Obj
		//IL_10e2: Expected VT, but got I
		//IL_10ef: Expected I4, but got Obj
		//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fd: Expected Obj, but got Unknown
		//IL_1144: Unknown result type (might be due to invalid IL or missing references)
		//IL_1149: Expected Obj, but got Unknown
		//IL_1171: Expected Obj, but got I
		//IL_1181: Expected VT, but got I
		//IL_1b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b95: Expected Obj, but got Unknown
		//IL_01c4: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_01db: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I4
		//IL_18e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ea: Expected Obj, but got Unknown
		//IL_0542: Expected Obj, but got I
		//IL_194a: Unknown result type (might be due to invalid IL or missing references)
		//IL_194f: Expected Obj, but got Unknown
		//IL_1999: Expected Obj, but got I
		//IL_19f9: Expected Obj, but got I
		//IL_0d82: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I4
		//IL_0595: Expected Obj, but got I
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected VT, but got Unknown
		//IL_1264: Unknown result type (might be due to invalid IL or missing references)
		//IL_1269: Expected VT, but got Unknown
		//IL_12ac: Expected VT, but got Obj
		//IL_12bc: Expected Obj, but got I
		//IL_12cc: Expected Obj, but got I
		//IL_12d9: Expected VT, but got I4
		//IL_0f85: Expected Obj, but got I
		//IL_0dd5: Expected Obj, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected VT, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected VT, but got Unknown
		//IL_0375: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I
		//IL_0395: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I4
		//IL_1307: Expected VT, but got Obj
		//IL_1317: Expected Obj, but got I
		//IL_1327: Expected Obj, but got I
		//IL_1334: Expected VT, but got I4
		//IL_0feb: Expected Obj, but got I
		//IL_0783: Expected Obj, but got I
		//IL_0788: Expected I, but got Obj
		//IL_0798: Expected Obj, but got I
		//IL_07a5: Expected I, but got Obj
		//IL_07b5: Expected Obj, but got I
		//IL_05d6: Expected Obj, but got I
		//IL_0601: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I
		//IL_08e9: Expected Obj, but got I
		//IL_08f9: Expected Obj, but got I
		//IL_0902: Expected Obj, but got I4
		//IL_1387: Expected VT, but got Obj
		//IL_1397: Expected Obj, but got I
		//IL_13a7: Expected Obj, but got I
		//IL_13b4: Expected VT, but got I4
		//IL_0ed7: Expected Obj, but got I
		//IL_0edc: Expected I, but got Obj
		//IL_0eec: Expected Obj, but got I
		//IL_0f04: Expected Obj, but got I
		//IL_0f09: Expected I, but got Obj
		//IL_0e16: Expected Obj, but got I
		//IL_0e41: Expected Obj, but got I
		//IL_0e66: Expected Obj, but got I
		//IL_0e7b: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I
		//IL_041b: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_0444: Expected Obj, but got I4
		//IL_06c6: Expected Obj, but got I
		//IL_0963: Expected Obj, but got I
		//IL_0973: Expected Obj, but got I
		//IL_097c: Expected Obj, but got I4
		//IL_0981: Expected I, but got Obj
		//IL_0470: Expected Obj, but got I
		//IL_0480: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I
		//IL_0499: Expected Obj, but got I4
		//IL_1413: Expected VT, but got Obj
		//IL_1423: Expected Obj, but got I
		//IL_1441: Expected Obj, but got I
		//IL_144e: Expected VT, but got I4
		//IL_0702: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I
		//IL_0727: Expected Obj, but got I
		//IL_09de: Expected Obj, but got I
		//IL_09ee: Expected Obj, but got I
		//IL_09f7: Expected Obj, but got I4
		//IL_09fc: Expected I, but got Obj
		//IL_0a59: Expected Obj, but got I
		//IL_0a69: Expected Obj, but got I
		//IL_0a72: Expected Obj, but got I4
		//IL_0a77: Expected I, but got Obj
		//IL_179f: Expected VT, but got Obj
		//IL_17af: Expected Obj, but got I
		//IL_17c7: Expected Obj, but got I
		//IL_17d4: Expected VT, but got I4
		//IL_17f9: Expected VT, but got Obj
		//IL_1809: Expected Obj, but got I
		//IL_1849: Expected Obj, but got I
		//IL_1856: Expected VT, but got I4
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected Obj, but got Unknown
		//IL_0bce: Expected Obj, but got I
		//IL_0c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Expected Obj, but got Unknown
		//IL_0c5a: Expected Obj, but got I
		//IL_0c6a: Expected Obj, but got I
		//IL_0c73: Expected Obj, but got I4
		//IL_0c9b: Expected Obj, but got I
		//IL_0cab: Expected Obj, but got I
		//IL_0cbb: Expected Obj, but got I
		//IL_0cc4: Expected Obj, but got I4
		//IL_0af1: Expected Obj, but got I
		//IL_0b01: Expected Obj, but got I
		//IL_0b0a: Expected Obj, but got I4
		//IL_0b0f: Expected I, but got Obj
		//IL_0b59: Expected Obj, but got I
		//IL_0b69: Expected Obj, but got I
		//IL_0b79: Expected Obj, but got I
		//IL_0b82: Expected Obj, but got I4
		//IL_0b87: Expected I, but got Obj
		//IL_16b7: Expected I, but got Obj
		//IL_16dc: Expected VT, but got Obj
		//IL_16ec: Expected Obj, but got I
		//IL_1701: Expected I, but got Obj
		//IL_1711: Expected Obj, but got I
		//IL_1721: Expected Obj, but got I
		//IL_172e: Expected VT, but got I4
		//IL_1528: Expected Obj, but got I
		//IL_1553: Expected Obj, but got I
		//IL_159a: Expected VT, but got Obj
		//IL_15aa: Expected Obj, but got I
		//IL_15ba: Expected Obj, but got I
		//IL_15c7: Expected VT, but got I4
		//IL_15eb: Expected Obj, but got I
		//IL_1605: Expected VT, but got Obj
		//IL_1615: Expected Obj, but got I
		//IL_1625: Expected Obj, but got I
		//IL_1632: Expected VT, but got I4
		object obj2 = default;
		object obj = obj2 - 320;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 168;
		_ = 0;
		if (_dataFolder == null || isSending__BackingField)
		{
			return;
		}
		DateTime utcNow = DateTime.UtcNow;
		string[] files = Directory.GetFiles(_dataFolder, "*");
		Array.Sort(files);
		List<SessionFileInfo> list = default;
		list._002Ector();
		nint num = (nint)typeof(Guid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v28 (Il2CppClass<System.Guid>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v29 (Il2CppStaticFields<System.Guid>)+8]");
		_ = 0;
		_ = Guid.Empty;
		object obj4 = obj + 256;
		object obj5 = obj4 | 4;
		string[] array = files;
		DateTime dateTime = utcNow;
		object obj6 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		IntPtr intPtr = default;
		TimeSpan timeSpan2 = default;
		object obj16 = default;
		object obj18 = default;
		object obj19 = default;
		object obj22 = default;
		object obj23 = default;
		object obj25 = default;
		object obj27 = default;
		object obj28 = default;
		object obj36 = default;
		object obj37 = default;
		TimeSpan timeSpan4 = default;
		EventRemoteLogger eventRemoteLogger2 = default;
		object obj51 = default;
		object obj52 = default;
		object obj53 = default;
		object obj54 = default;
		object obj56 = default;
		object obj57 = default;
		object obj63 = default;
		object obj64 = default;
		object obj65 = default;
		object obj66 = default;
		object obj67 = default;
		object obj68 = default;
		object obj71 = default;
		object obj72 = default;
		object obj74 = default;
		object obj76 = default;
		object obj77 = default;
		object obj83 = default;
		while (true)
		{
			TimeSpan timeSpan;
			object obj12;
			object obj13;
			object obj14;
			object obj15;
			nint num4;
			object obj34;
			nint num5;
			object obj35;
			TimeSpan timeSpan3;
			object obj38;
			EventRemoteLogger eventRemoteLogger;
			TimeSpan timeSpan5;
			object obj39;
			object obj40;
			object obj41;
			object obj42;
			string[] array2;
			DateTime dateTime2;
			nint num3;
			object obj24;
			object obj17;
			if (array.Length > (nint)obj6)
			{
				object obj7 = obj6 << 2;
				object obj8 = (object)array + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v255+10]");
				string fileName = Path.GetFileName((string)0);
				if (!TimeUtility.TryParseSortableNumber(fileName, out *(DateTime*)(obj + 296)))
				{
					goto IL_1b2d;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 == 1;
				obj9 = 0;
				obj10 = 0;
				num3 = unchecked((nint)null);
				if (!flag)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj11 = 0;
					obj9 = 0;
					obj10 = 0;
					num3 = unchecked((nint)null);
					if (!flag2)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
						obj9 = 0;
						obj10 = 0;
						num3 = intPtr;
						if (!flag3)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
							obj9 = 0;
							obj10 = 0;
							num3 = 0;
							if (!flag4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v430+10]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+138]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v430+8]");
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+130]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v430+10]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v430+8]");
								_ = 0;
								Guid guid = (Guid)(obj + 48);
								Guid guid2 = (Guid)(obj + 32);
								bool flag5 = guid == guid2;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag6 = (nint)0 == 1;
								timeSpan = timeSpan2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v430+8]");
								obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
								obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
								obj14 = 0;
								obj15 = 0;
								num4 = 0;
								if (!flag6)
								{
									if (flag5)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag7 = (nint)0 != 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v430+8]");
										obj16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
										obj11 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										obj17 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
										obj9 = 0;
										obj10 = 0;
										num3 = 0;
										if (flag7)
										{
											goto IL_1b2d;
										}
										timeSpan = timeSpan2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v430+8]");
										obj12 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
										obj14 = 0;
										obj15 = 0;
										num4 = 0;
									}
									else
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag8 = (nint)0 == 1;
										timeSpan = timeSpan2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
										obj12 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
										obj14 = 0;
										obj15 = 0;
										num4 = 0;
										if (!flag8)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8B4");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag9 = (nint)0 == 1;
											timeSpan = timeSpan2;
											obj12 = obj18;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
											obj13 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
											obj14 = 0;
											obj15 = 0;
											num4 = unchecked((nint)null);
											if (!flag9)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag10 = (nint)0 == 1;
												timeSpan = _dataExpireTime;
												obj12 = obj18;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
												obj13 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
												obj14 = 0;
												obj15 = 0;
												num4 = unchecked((nint)null);
												if (!flag10)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DF");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag11 = (nint)0 == 1;
													timeSpan = _dataExpireTime;
													obj12 = obj18;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
													obj13 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
													obj14 = 0;
													obj15 = 0;
													num4 = unchecked((nint)null);
													if (!flag11)
													{
														if (obj19 != null)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag12 = (nint)0 == 1;
															timeSpan = _dataExpireTime;
															obj12 = obj18;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
															obj13 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
															obj14 = 0;
															obj15 = 0;
															num4 = unchecked((nint)null);
															if (!flag12)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
																_ = 0;
																timeSpan2 = _dataExpireTime;
																obj16 = obj18;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
																obj11 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																obj17 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
																obj9 = 0;
																obj10 = 0;
																num3 = unchecked((nint)null);
																goto IL_1b2d;
															}
														}
														else
														{
															object obj20 = obj + 256;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v255+10]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
															obj5 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+110]");
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
															_ = 0;
															object obj21 = obj + 8;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag13 = (nint)0 != 1;
															timeSpan = _dataExpireTime;
															obj12 = obj18;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
															obj13 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
															obj14 = 0;
															obj15 = 0;
															num4 = 0;
															timeSpan2 = _dataExpireTime;
															obj16 = obj18;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
															obj11 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															obj17 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v268 (Il2CppMethodInfo)+C]");
															obj9 = 0;
															obj10 = 0;
															num3 = 0;
															if (flag13)
															{
																goto IL_1b2d;
															}
														}
													}
												}
											}
										}
									}
								}
								goto IL_0cd8;
							}
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag14 = obj22 != obj23;
				obj17 = obj22;
				obj24 = obj25;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag15 = (nint)0 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj11 = 0;
					if (!flag15)
					{
						object obj26 = obj27;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag16 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj11 = 0;
						if (!flag16)
						{
							if (obj28 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
								object obj29 = (nint)0 << 2;
								object obj30 = obj3 + obj29;
								obj30 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
								object obj31 = (nint)0 + (nint)1;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag17 = (nint)0 == 1;
								timeSpan = timeSpan2;
								obj12 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								obj13 = 0;
								obj14 = obj9;
								obj15 = obj10;
								num4 = num3;
								if (!flag17)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag18 = (nint)0 == 1;
									timeSpan = timeSpan2;
									obj12 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									obj13 = 0;
									obj14 = obj9;
									obj15 = obj10;
									num4 = num3;
									if (!flag18)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
										object obj32 = -1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										obj11 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
										obj17 = 0;
										goto IL_1b2d;
									}
								}
								goto IL_0cd8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj33 = obj27;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag19 = (nint)0 != 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj11 = 0;
							num3 = unchecked((nint)null);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj34 = 0;
							obj17 = obj28;
							num5 = unchecked((nint)null);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj35 = 0;
							if (flag19)
							{
								goto IL_1a87;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag20 = (nint)0 != 1;
					obj17 = obj36;
					obj24 = obj37;
					if (!flag20)
					{
						timeSpan3 = timeSpan4;
						obj38 = obj6;
						eventRemoteLogger = this;
						timeSpan5 = timeSpan2;
						obj39 = obj16;
						obj34 = obj11;
						obj40 = obj36;
						obj41 = obj9;
						obj42 = obj10;
						num5 = num3;
						obj35 = obj37;
						array2 = array;
						dateTime2 = dateTime;
						goto IL_1a0f;
					}
				}
				goto IL_1b48;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v40 (System.Collections.Generic.List`1<Kiloo.Common.Backend.EventRemoteLogger+SessionFileInfo>)+C]");
			if ((nint)0 < (nint)26)
			{
				break;
			}
			object obj43 = obj + 112;
			object obj44 = obj43 | 4;
			object obj45 = obj + 144;
			object obj46 = obj45 | 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v40 (System.Collections.Generic.List`1<Kiloo.Common.Backend.EventRemoteLogger+SessionFileInfo>)+C]");
			if ((nint)0 <= (nint)25)
			{
				break;
			}
			object obj47 = obj + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EC2");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v70+8]");
			eventRemoteLogger2._dataExpireTime = (TimeSpan)0;
			eventRemoteLogger2.isPartOfSample = (byte)(int)obj46 != 0;
			object obj48 = obj + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A5E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			object obj49 = obj + 200;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			dateTime = (DateTime)0;
			EventRemoteLogger eventRemoteLogger3;
			while (true)
			{
				_ = 0;
				object obj50 = obj + 200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj51 == null)
					{
						goto IL_18dc;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+DC]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
						_ = 0;
						_ = eventRemoteLogger2._dataExpireTime;
						_ = eventRemoteLogger2._dataExpireTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
						_ = 0;
						_ = eventRemoteLogger2.isPartOfSample;
						_ = 0;
						_ = eventRemoteLogger2.isPartOfSample;
						Guid guid3 = (Guid)(obj + 80);
						Guid guid4 = (Guid)(obj - -64);
						bool flag21 = guid3 == guid4;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag22 = (nint)0 == 1;
						timeSpan4 = eventRemoteLogger2._dataExpireTime;
						timeSpan2 = (TimeSpan)obj44;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						array = (string[])0;
						dateTime = (DateTime)eventRemoteLogger2.isPartOfSample;
						if (!flag22)
						{
							bool flag23 = !flag21;
							timeSpan4 = eventRemoteLogger2._dataExpireTime;
							timeSpan2 = (TimeSpan)obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
							obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							array = (string[])0;
							dateTime = (DateTime)eventRemoteLogger2.isPartOfSample;
							if (flag23)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag24 = (nint)0 != 1;
							timeSpan4 = eventRemoteLogger2._dataExpireTime;
							timeSpan2 = (TimeSpan)obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
							obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							array = (string[])0;
							dateTime = (DateTime)eventRemoteLogger2.isPartOfSample;
							if (flag24)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							bool flag25 = obj52 != obj53;
							timeSpan4 = eventRemoteLogger2._dataExpireTime;
							obj6 = obj52;
							timeSpan2 = (TimeSpan)obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
							obj16 = 0;
							num3 = 0;
							obj24 = obj54;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							array = (string[])0;
							dateTime = (DateTime)eventRemoteLogger2.isPartOfSample;
							if (!flag25)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag26 = (nint)0 == 1;
								num3 = 0;
								if (!flag26)
								{
									object obj55 = obj56;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag27 = (nint)0 == 1;
									num3 = 0;
									if (!flag27)
									{
										if (obj57 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
											object obj58 = (nint)0 << 2;
											object obj59 = obj3 + obj58;
											obj59 = obj56;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
											object obj60 = (nint)0 + (nint)1;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag28 = (nint)0 == 1;
											timeSpan4 = eventRemoteLogger2._dataExpireTime;
											timeSpan2 = (TimeSpan)obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
											obj16 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											array = (string[])0;
											dateTime = (DateTime)eventRemoteLogger2.isPartOfSample;
											if (!flag28)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
												object obj61 = -1;
												timeSpan4 = eventRemoteLogger2._dataExpireTime;
												timeSpan2 = (TimeSpan)obj44;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
												obj16 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												array = (string[])0;
												dateTime = (DateTime)eventRemoteLogger2.isPartOfSample;
												continue;
											}
											goto IL_1637;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
										object obj62 = obj56;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag29 = (nint)0 != 1;
										num3 = unchecked((nint)null);
										timeSpan4 = eventRemoteLogger2._dataExpireTime;
										obj6 = obj62;
										eventRemoteLogger3 = eventRemoteLogger2;
										timeSpan2 = (TimeSpan)obj44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
										obj16 = 0;
										obj34 = obj11;
										obj17 = obj46;
										num5 = unchecked((nint)null);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										obj35 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										array = (string[])0;
										dateTime = (DateTime)eventRemoteLogger2.isPartOfSample;
										if (flag29)
										{
											break;
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag30 = (nint)0 == 1;
								timeSpan4 = eventRemoteLogger2._dataExpireTime;
								obj6 = obj63;
								timeSpan2 = (TimeSpan)obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
								obj16 = 0;
								obj24 = obj64;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								array = (string[])0;
								dateTime = (DateTime)eventRemoteLogger2.isPartOfSample;
								timeSpan3 = eventRemoteLogger2._dataExpireTime;
								obj38 = obj63;
								eventRemoteLogger = eventRemoteLogger2;
								timeSpan5 = (TimeSpan)obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67+8]");
								obj39 = 0;
								obj34 = obj11;
								obj40 = obj46;
								obj41 = obj9;
								obj42 = obj10;
								num5 = num3;
								obj35 = obj64;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								array2 = (string[])0;
								dateTime2 = (DateTime)eventRemoteLogger2.isPartOfSample;
								if (flag30)
								{
									goto IL_1a0f;
								}
							}
							goto IL_1864;
						}
					}
				}
				goto IL_1637;
				IL_1637:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj6 = obj65;
				num3 = 0;
				obj24 = obj66;
				goto IL_1864;
				IL_1864:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				if (obj67 == obj6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_18dc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj24 = obj68;
				}
				_ = 0;
				object obj69 = obj + 144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag31 = (nint)0 != 1;
				timeSpan3 = timeSpan4;
				obj38 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				eventRemoteLogger = (EventRemoteLogger)0;
				timeSpan5 = timeSpan2;
				obj39 = obj16;
				obj34 = obj11;
				obj40 = obj46;
				obj41 = obj9;
				obj42 = obj10;
				num5 = num3;
				obj35 = obj24;
				array2 = array;
				dateTime2 = dateTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				eventRemoteLogger3 = (EventRemoteLogger)0;
				obj17 = obj46;
				if (!flag31)
				{
					goto IL_1a0f;
				}
				goto IL_1b71;
				IL_18dc:
				object obj70 = obj + 144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AF5C");
				throw new ArgumentException();
			}
			goto IL_1a87;
			IL_1a87:
			obj11 = obj34;
			num3 = num5;
			obj24 = obj35;
			goto IL_1b71;
			IL_1b71:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_1b2d;
			IL_0cd8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			timeSpan2 = timeSpan;
			obj16 = obj12;
			obj11 = obj13;
			obj17 = obj71;
			obj9 = obj14;
			obj10 = obj15;
			num3 = num4;
			obj24 = obj72;
			goto IL_1b48;
			IL_1b2d:
			object obj73 = obj6 + 1;
			obj6 = obj73;
			continue;
			IL_1b48:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj74 == obj17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag32 = (nint)0 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj40 = 0;
				if (!flag32)
				{
					object obj75 = obj76;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag33 = (nint)0 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj40 = 0;
					if (!flag33)
					{
						if (obj77 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
							object obj78 = (nint)0 << 2;
							object obj79 = obj3 + obj78;
							obj79 = obj76;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
							object obj80 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+8]");
							object obj81 = -1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj17 = 0;
							goto IL_1b2d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj82 = obj76;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag34 = (nint)0 != 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj40 = 0;
						num3 = unchecked((nint)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						eventRemoteLogger3 = (EventRemoteLogger)0;
						obj34 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj17 = 0;
						num5 = unchecked((nint)null);
						obj35 = obj76;
						if (flag34)
						{
							goto IL_1a87;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag35 = (nint)0 == 1;
				timeSpan3 = timeSpan4;
				obj38 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				eventRemoteLogger = (EventRemoteLogger)0;
				timeSpan5 = timeSpan2;
				obj39 = obj16;
				obj34 = obj11;
				obj41 = obj9;
				obj42 = obj10;
				num5 = num3;
				obj35 = obj83;
				array2 = array;
				dateTime2 = dateTime;
				if (flag35)
				{
					goto IL_1a0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				eventRemoteLogger3 = (EventRemoteLogger)0;
				obj17 = obj40;
				obj24 = obj83;
			}
			goto IL_1b71;
			IL_1a0f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			timeSpan4 = timeSpan3;
			obj6 = obj38;
			eventRemoteLogger3 = eventRemoteLogger;
			timeSpan2 = timeSpan5;
			obj16 = obj39;
			obj17 = obj40;
			obj9 = obj41;
			obj10 = obj42;
			array = array2;
			dateTime = dateTime2;
			goto IL_1a87;
		}
	}

	private void LogError(string msg)
	{
	}

	private void LogWarning(string msg)
	{
	}

	private void Log(string msg)
	{
	}

	static EventRemoteLogger()
	{
		EventRemoteLogger eventRemoteLogger = default;
		eventRemoteLogger._002Ector();
		instance = eventRemoteLogger;
	}
}
