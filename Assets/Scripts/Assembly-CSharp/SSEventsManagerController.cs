using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Missions;
using SYBO.Common.Utilities;
using UnityEngine;

public class SSEventsManagerController
{
	private sealed class _003CTimerToEventStart_003Ed__39(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public long timeLeft;

		public SSEventsManagerController _003C_003E4__this;

		private float _003CstartPoint_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0175: Invalid comparison between F4 and I8
			//IL_00cf: Expected F8, but got I8
			//IL_0196: Invalid comparison between F8 and I8
			//IL_00ef: Expected I8, but got F8
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0165;
				}
				_003C_003E1__state = -1;
				num = _003CstartPoint_003E5__2;
			}
			else
			{
				_003CstartPoint_003E5__2 = 0f;
				_003C_003E1__state = -1;
				num = 0f;
			}
			if (!(num < (float)timeLeft))
			{
				PlayerInfo instance = PlayerInfo.Instance;
				double num2 = GetUnixCurrentTimestamp();
				double num3 = Math.Abs(num2);
				if (!(num3 < 9.223372036854776E+18))
				{
					num2 = -9.223372036854776E+18;
				}
				if (num2 != (double)instance._lastTimeAnEventWasStarted)
				{
					instance._dirty = true;
					instance._lastTimeAnEventWasStarted = (long)num2;
				}
				_003C_003E4__this.SetCurrentEventManager();
				if (SSEventsManagerController.m_OnSSEventStartedHandler != null)
				{
					Action onSSEventStartedHandler = SSEventsManagerController.m_OnSSEventStartedHandler;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v118.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				goto IL_0165;
			}
			float deltaTime = RealTimeTracker.deltaTime;
			float num4 = num + deltaTime;
			_003C_003E2__current = null;
			_003CstartPoint_003E5__2 = num4;
			_003C_003E1__state = 1;
			return true;
			IL_0165:
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

	private sealed class _003CTimerToEventFinish_003Ed__40(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public long timeLeft;

		public SSEventsManagerController _003C_003E4__this;

		private float _003CstartPoint_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0111: Invalid comparison between F4 and I8
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0101;
				}
				_003C_003E1__state = -1;
				num = _003CstartPoint_003E5__2;
			}
			else
			{
				_003CstartPoint_003E5__2 = 0f;
				_003C_003E1__state = -1;
				num = 0f;
			}
			if (!(num < (float)timeLeft))
			{
				_003C_003E4__this.SetCurrentEventManager();
				if (SSEventsManagerController.m_OnSSEventFinishedHandler != null)
				{
					Action onSSEventFinishedHandler = SSEventsManagerController.m_OnSSEventFinishedHandler;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v80.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				goto IL_0101;
			}
			float deltaTime = RealTimeTracker.deltaTime;
			float num2 = num + deltaTime;
			_003C_003E2__current = null;
			_003CstartPoint_003E5__2 = num2;
			_003C_003E1__state = 1;
			return true;
			IL_0101:
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

	public static bool HasLoggedRouteEventWarning;

	public const string ONLINE_SETTING_EVENT_ID = "event_id";

	public const string ONLINE_SETTING_EVENT_START = "event_start";

	public const string ONLINE_SETTING_EVENT_END = "event_end";

	public const string ONLINE_SETTING_EVENT_VALUE = "event_value";

	public const string ONLINE_SETTING_EVENT_TYPE = "event_type";

	public const string ONLINE_SETTING_TITLE_FIRST = "event_popup_title_first";

	public const string ONLINE_SETTING_TITLE_SECOND = "event_popup_title_second";

	public const string ONLINE_SETTING_DESCRIPTION_FIRST = "event_popup_description_first";

	public const string ONLINE_SETTING_DESCRIPTION_SECOND = "event_popup_description_second";

	public const string ONLINE_SETTING_EVENT_CATEGORY = "event_category";

	public const string ONLINE_SETTING_EVENT_RIBBON_TEXT = "event_ribbon_text";

	public const string ONLINE_SETTING_EVENT_MEGA_JACKPOT_MB_VALUE = "event_jackpot_mysterybox_value";

	public const string ONLINE_SETTING_EVENT_MEGA_JACKPOT_SMB_VALUE = "event_jackpot_supermysterybox_value";

	private IEventManager _currentEventManager;

	private static GameObject _eventTimerGameObject;

	private static MonoBehaviour _eventTimerMono;

	private bool _isInitialized;

	private static SSEventsManagerController _instance;

	private static Action m_OnSSEventStartedHandler;

	private static Action m_OnSSEventFinishedHandler;

	private static Action m_OnSSEventChangedHandler;

	public static SSEventsManagerController instance
	{
		get
		{
			if (_instance == null)
			{
				SSEventsManagerController sSEventsManagerController = default;
				sSEventsManagerController._002Ector();
				_instance = sSEventsManagerController;
			}
			return _instance;
		}
	}

	public static event Action OnSSEventStartedHandler
	{
		add
		{
			Delegate obj = SSEventsManagerController.m_OnSSEventStartedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == SSEventsManagerController.m_OnSSEventStartedHandler;
				Action onSSEventStartedHandler = action;
				if (!flag)
				{
					onSSEventStartedHandler = SSEventsManagerController.m_OnSSEventStartedHandler;
				}
				SSEventsManagerController.m_OnSSEventStartedHandler = onSSEventStartedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SSEventsManagerController.m_OnSSEventStartedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = SSEventsManagerController.m_OnSSEventStartedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == SSEventsManagerController.m_OnSSEventStartedHandler;
				Action onSSEventStartedHandler = action;
				if (!flag)
				{
					onSSEventStartedHandler = SSEventsManagerController.m_OnSSEventStartedHandler;
				}
				SSEventsManagerController.m_OnSSEventStartedHandler = onSSEventStartedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SSEventsManagerController.m_OnSSEventStartedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnSSEventFinishedHandler
	{
		add
		{
			Delegate obj = SSEventsManagerController.m_OnSSEventFinishedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == SSEventsManagerController.m_OnSSEventFinishedHandler;
				Action onSSEventFinishedHandler = action;
				if (!flag)
				{
					onSSEventFinishedHandler = SSEventsManagerController.m_OnSSEventFinishedHandler;
				}
				SSEventsManagerController.m_OnSSEventFinishedHandler = onSSEventFinishedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SSEventsManagerController.m_OnSSEventFinishedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = SSEventsManagerController.m_OnSSEventFinishedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == SSEventsManagerController.m_OnSSEventFinishedHandler;
				Action onSSEventFinishedHandler = action;
				if (!flag)
				{
					onSSEventFinishedHandler = SSEventsManagerController.m_OnSSEventFinishedHandler;
				}
				SSEventsManagerController.m_OnSSEventFinishedHandler = onSSEventFinishedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SSEventsManagerController.m_OnSSEventFinishedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnSSEventChangedHandler
	{
		add
		{
			Delegate obj = SSEventsManagerController.m_OnSSEventChangedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == SSEventsManagerController.m_OnSSEventChangedHandler;
				Action onSSEventChangedHandler = action;
				if (!flag)
				{
					onSSEventChangedHandler = SSEventsManagerController.m_OnSSEventChangedHandler;
				}
				SSEventsManagerController.m_OnSSEventChangedHandler = onSSEventChangedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SSEventsManagerController.m_OnSSEventChangedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = SSEventsManagerController.m_OnSSEventChangedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == SSEventsManagerController.m_OnSSEventChangedHandler;
				Action onSSEventChangedHandler = action;
				if (!flag)
				{
					onSSEventChangedHandler = SSEventsManagerController.m_OnSSEventChangedHandler;
				}
				SSEventsManagerController.m_OnSSEventChangedHandler = onSSEventChangedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SSEventsManagerController.m_OnSSEventChangedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private SSEventsManagerController()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			Initialize();
		}
	}

	public unsafe void Initialize()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			OnlineSettings onlineSettings = OnlineSettings.instance;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(SSEventsManagerController.StartEventTimer));
			onlineSettings.AddOnFinishedDownloadingOnlineSettingsHandler(action);
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(SSEventsManagerController.StartEventTimer));
			UIScreenController.OnApplicationResumed += action2;
			Action action3 = default;
			action3._002Ector(this, (nint)__ldftn(SSEventsManagerController.StartEventTimer));
			AgeRestriction.restrictionChanged += action3;
			StartEventTimer();
			_isInitialized = true;
		}
	}

	public IEventManager GetActiveEventManager(SSEventType desiredEventType = SSEventType.None)
	{
		bool flag = _currentEventManager == null;
		IEventManager result = null;
		if (!flag)
		{
			if (desiredEventType != SSEventType.None)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj = default;
				bool flag2 = (nint)obj != (nint)desiredEventType;
				result = null;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj2 = default;
					if (obj2 != null)
					{
						goto IL_009e;
					}
					result = null;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj3 = default;
				bool flag3 = obj3 == null;
				result = null;
				if (!flag3)
				{
					goto IL_009e;
				}
			}
		}
		goto IL_00d1;
		IL_00d1:
		return result;
		IL_009e:
		result = _currentEventManager;
		goto IL_00d1;
	}

	public T GetTypeOfActiveEventManager<T>()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_0428: Expected VT, but got I
		//IL_032d: Expected VT, but got I4
		//IL_01db: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_0274: Expected VT, but got I
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0482: Expected Obj, but got I
		//IL_0497: Expected VT, but got I
		//IL_02b0: Expected I, but got Obj
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		T result;
		T result2 = default;
		if (_currentEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = default;
			if (obj4 != null)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 != 1;
					T val = default;
					result = val;
					if (flag)
					{
						goto IL_042d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj5 = default;
				object obj6 = default;
				bool flag2 = obj5 == obj6;
				bool flag3 = !flag2;
				object obj8 = default;
				object obj7 = obj8;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj10 = default;
						object obj9 = obj10;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj11 = default;
							if (obj11 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj12 = (nint)0 << 2;
								object obj13 = obj + obj12;
								obj13 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj14 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj15 = (nint)0 << 2;
								object obj16 = obj15 + obj;
								object obj17 = obj16 - 4;
								object obj18 = obj17;
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v99 (Il2CppMethodRgctx<SSEventsManagerController::GetTypeOfActiveEventManager>)+4]");
								Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
								bool flag4 = (object)typeFromHandle == null;
								string text = null;
								string text2 = "The type of specified manager could not be found: ";
								if (!flag4)
								{
									nint num2 = (nint)typeFromHandle;
									object obj19 = typeFromHandle + 24;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v309 @ S1_v62 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
									string text3 = default;
									text = text3;
									text2 = "The type of specified manager could not be found: ";
								}
								object obj20 = obj18;
								object obj21 = obj18 + 80;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ S1_v52+10C] (should have been resolved before IL gen)");
								string text5 = default;
								string text4 = text2 + text + ", stack trace: " + text5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj22 = -1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
								result = (T)0;
								goto IL_042d;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj23 = obj10;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag5 = (nint)0 != 1;
							result2 = (T)flag5;
							if (flag5)
							{
								goto IL_03cf;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 == 1;
					object obj24 = default;
					obj7 = obj24;
					if (flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						goto IL_03cf;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		result = (T)0;
		goto IL_042d;
		IL_03cf:
		return result2;
		IL_042d:
		return result;
	}

	public void RestoreBoardAfterEventIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I8
		//IL_0111: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_0125: Expected VT, but got Obj
		object obj = default;
		SSEventsManagerController sSEventsManagerController = (SSEventsManagerController)(obj - 16);
		PlayerInfo playerInfo = PlayerInfo.Instance;
		if (~(playerInfo._shouldRestoreAfterEvent ? 1u : 0u) != 0)
		{
			return;
		}
		long num = TimeLeftInSeconds();
		sSEventsManagerController._currentEventManager = (IEventManager)num;
		bool flag = (((nint)sSEventsManagerController._currentEventManager < 0) ? true : ((nint)sSEventsManagerController._currentEventManager > 0));
		if ((flag ? 1 : 0) >= (true ? 1 : 0))
		{
			PlayerInfo playerInfo2 = PlayerInfo.Instance;
			long currentEventID = sSEventsManagerController.GetCurrentEventID();
			if (playerInfo2._lastEventID == currentEventID)
			{
				return;
			}
		}
		string lastEventItemID = playerInfo._lastEventItemID;
		object obj2;
		if (playerInfo._lastEventItemID != null)
		{
			obj2 = 0;
			if (lastEventItemID._stringLength != 0)
			{
				goto IL_0238;
			}
		}
		obj2 = 1;
		goto IL_0238;
		IL_0238:
		if (obj2 == null)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Hoverboards.BoardType));
			object obj3 = Enum.Parse(typeFromHandle, playerInfo._lastEventItemID);
			throw new NullReferenceException();
		}
		if (~(playerInfo._shouldRestoreAfterEvent ? 1u : 0u) == 0)
		{
			playerInfo._dirty = true;
			playerInfo._shouldRestoreAfterEvent = false;
		}
	}

	public long TimeLeftInSeconds()
	{
		//IL_00de: Expected I8, but got F8
		//IL_00ab: Expected F8, but got I8
		double unixCurrentTimestamp = GetUnixCurrentTimestamp();
		double num4 = default;
		if (_currentEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			if (obj != null)
			{
				long num = ((SSEventsManagerController)_currentEventManager).EndTimestampForCurrentEventType();
				if (num >= 1)
				{
					double num2 = Math.Abs(unixCurrentTimestamp);
					double num3 = ((!(num2 < 9.223372036854776E+18)) ? (-9.223372036854776E+18) : unixCurrentTimestamp);
					num4 = (double)num - num3;
				}
			}
		}
		return (long)num4;
	}

	public void CurrentEventHasBeenTriedNow()
	{
		if (_currentEventManager != null)
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			long num = EndTimestampForCurrentEventType();
			if (num != playerInfo._lastTimeAnEventHasBeenTried)
			{
				playerInfo._dirty = true;
				playerInfo._lastTimeAnEventHasBeenTried = num;
			}
		}
	}

	public bool HasTheCurrentEventBeenTried()
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		if (_currentEventManager != null)
		{
			long num = ((SSEventsManagerController)null).EndTimestampForCurrentEventType();
			return playerInfo._lastTimeAnEventHasBeenTried == num;
		}
		return false;
	}

	private void StartEventTimer()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02fc: Expected Obj, but got I4
		//IL_005e: Expected F8, but got I8
		//IL_0117: Expected Obj, but got I8
		//IL_025e: Expected Obj, but got I
		//IL_0403: Expected I8, but got Obj
		//IL_01d2: Expected Obj, but got I8
		//IL_02d1: Expected I8, but got Obj
		object obj = default;
		SSEventsManagerController sSEventsManagerController = (SSEventsManagerController)(obj - 32);
		sSEventsManagerController = (SSEventsManagerController)0;
		long num = sSEventsManagerController.EndTimestampForCurrentEventType();
		long num2 = sSEventsManagerController.StartTimestampForCurrentEventType();
		double unixCurrentTimestamp = sSEventsManagerController.GetUnixCurrentTimestamp();
		double num3 = Math.Abs(unixCurrentTimestamp);
		if (!(num3 < 9.223372036854776E+18))
		{
			unixCurrentTimestamp = -9.223372036854776E+18;
		}
		sSEventsManagerController._currentEventManager = null;
		if (_eventTimerGameObject != null)
		{
			UnityEngine.Object.Destroy(_eventTimerGameObject);
		}
		GameObject gameObject = default;
		gameObject._002Ector("EventTimers");
		_eventTimerGameObject = gameObject;
		if (Application.isPlaying)
		{
			UnityEngine.Object.DontDestroyOnLoad(_eventTimerGameObject);
		}
		NewMonoBehaviour eventTimerMono = _eventTimerGameObject.AddComponent<NewMonoBehaviour>();
		_eventTimerMono = eventTimerMono;
		Transform transform = _eventTimerGameObject.transform;
		HierarchyUtility.ReparentByHierarchyPathType(transform, HierarchyPathType.DynamicManagers);
		PlayerInfo playerInfo = PlayerInfo.Instance;
		sSEventsManagerController = (SSEventsManagerController)playerInfo._lastTimeAnEventWasStarted;
		bool flag = ((num2 > (long)sSEventsManagerController) ? true : (num2 < (long)sSEventsManagerController));
		if ((flag ? 1 : 0) <= -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+10]");
			bool flag2;
			if (num2 <= 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+10]");
				flag2 = num2 < 0;
			}
			else
			{
				flag2 = true;
			}
			if ((flag2 ? 1 : 0) <= -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+10]");
				IEventManager currentEventManager = (IEventManager)(num2 - 0);
				sSEventsManagerController._currentEventManager = currentEventManager;
			}
			IEnumerator routine = TimerToEventStart((long)sSEventsManagerController._currentEventManager);
			Coroutine coroutine = _eventTimerMono.StartCoroutine(routine);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+18]");
		bool flag3;
		if ((nint)0 >= (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+18]");
			flag3 = (nint)0 > (nint)0;
		}
		else
		{
			flag3 = true;
		}
		if ((flag3 ? 1 : 0) >= (true ? 1 : 0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+18]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+10]");
			IEventManager currentEventManager2 = (IEventManager)(num4 - 0);
			sSEventsManagerController._currentEventManager = currentEventManager2;
			bool flag4 = (((nint)sSEventsManagerController._currentEventManager < 0) ? true : ((nint)sSEventsManagerController._currentEventManager > 0));
			if ((flag4 ? 1 : 0) >= (true ? 1 : 0))
			{
				IEnumerator routine2 = TimerToEventFinish((long)sSEventsManagerController._currentEventManager);
				Coroutine coroutine2 = _eventTimerMono.StartCoroutine(routine2);
			}
		}
		SetCurrentEventManager();
	}

	private IEnumerator TimerToEventStart(long timeLeft)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator TimerToEventFinish(long timeLeft)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe long GetCurrentEventID()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00d2: Expected I8, but got I4
		object obj = default;
		ref long reference = ref *(long*)(obj - 16);
		_ = 0;
		reference = ref *(long*)null;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			EventTesterManager eventTesterManager = EventTesterManager.Instance;
			return eventTesterManager.GetEventID();
		}
		_ = string.Empty;
		OnlineSettings onlineSettings = OnlineSettings.instance;
		if (onlineSettings.TryGetValue("event_id", out System.Runtime.CompilerServices.Unsafe.As<long, string>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 12))))
		{
			reference = ref *(long*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int64&)+C]");
			bool flag = long.TryParse((string)0, out reference);
			long result = reference;
			if (!flag)
			{
				result = 0L;
			}
			return result;
		}
		long result2 = default;
		return result2;
	}

	private unsafe long EndTimestampForCurrentEventType()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00d2: Expected I8, but got I4
		object obj = default;
		ref long reference = ref *(long*)(obj - 16);
		_ = 0;
		reference = ref *(long*)null;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			EventTesterManager eventTesterManager = EventTesterManager.Instance;
			return eventTesterManager.GetEventEndTime();
		}
		_ = string.Empty;
		OnlineSettings onlineSettings = OnlineSettings.instance;
		if (onlineSettings.TryGetValue("event_end", out System.Runtime.CompilerServices.Unsafe.As<long, string>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 12))))
		{
			reference = ref *(long*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int64&)+C]");
			bool flag = long.TryParse((string)0, out reference);
			long result = reference;
			if (!flag)
			{
				result = 0L;
			}
			return result;
		}
		long result2 = default;
		return result2;
	}

	private unsafe long StartTimestampForCurrentEventType()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00d2: Expected I8, but got I4
		object obj = default;
		ref long reference = ref *(long*)(obj - 16);
		_ = 0;
		reference = ref *(long*)null;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			EventTesterManager eventTesterManager = EventTesterManager.Instance;
			return eventTesterManager.GetEventStartTime();
		}
		_ = string.Empty;
		OnlineSettings onlineSettings = OnlineSettings.instance;
		if (onlineSettings.TryGetValue("event_start", out System.Runtime.CompilerServices.Unsafe.As<long, string>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 12))))
		{
			reference = ref *(long*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int64&)+C]");
			bool flag = long.TryParse((string)0, out reference);
			long result = reference;
			if (!flag)
			{
				result = 0L;
			}
			return result;
		}
		long result2 = default;
		return result2;
	}

	private unsafe double GetUnixCurrentTimestamp()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0071: Expected I8, but got I4
		//IL_006c: Expected native int or pointer, but got VT
		//IL_0084: Expected native int or pointer, but got VT
		//IL_0025: Expected VT, but got I8
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 16);
		_ = 0;
		DateTime utcNow = CDateTime.UtcNow;
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1);
		TimeSpan timeSpan = utcNow - (DateTime)dateTime._dateData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+8]");
		return 0.0 * 1E-07;
	}

	private bool IsAnyEventEnabled()
	{
		//IL_00bf: Invalid comparison between F8 and I8
		//IL_007c: Invalid comparison between F8 and I8
		//IL_00ac: Invalid comparison between F8 and I8
		long num = ((SSEventsManagerController)null).EndTimestampForCurrentEventType();
		bool flag = num < 1;
		bool result = false;
		if (!flag)
		{
			long num2 = ((SSEventsManagerController)null).StartTimestampForCurrentEventType();
			double unixCurrentTimestamp = ((SSEventsManagerController)null).GetUnixCurrentTimestamp();
			if (num2 >= 1)
			{
				bool flag2 = unixCurrentTimestamp > (double)num2;
				bool flag3 = !flag2;
				result = false;
				if (!flag3)
				{
					return unixCurrentTimestamp < (double)num;
				}
			}
			else
			{
				bool flag4 = unixCurrentTimestamp < (double)num;
				result = flag4;
			}
		}
		return result;
	}

	private unsafe SSEventType GetEnabledEventType()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0061: Expected I4, but got Obj
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Ref, but got Unknown
		//IL_04f1: Expected I4, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I
		object obj = default;
		SSEventsManagerController sSEventsManagerController = (SSEventsManagerController)(obj - 16);
		sSEventsManagerController._isInitialized = false;
		_ = 0;
		bool flag = sSEventsManagerController.IsAnyEventEnabled();
		bool flag2 = !flag;
		SSEventType result = SSEventType.None;
		object obj2;
		SSEventType result2 = default;
		if (!flag2)
		{
			if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
			{
				EventTesterManager eventTesterManager = EventTesterManager.Instance;
				SSEventType eventType = eventTesterManager.GetEventType();
				result = eventType;
			}
			else
			{
				sSEventsManagerController._isInitialized = (byte)(int)string.Empty != 0;
				OnlineSettings onlineSettings = OnlineSettings.instance;
				bool flag3 = onlineSettings.TryGetValue("event_type", out *(string*)(sSEventsManagerController + 12));
				bool flag4 = !flag3;
				result = SSEventType.None;
				if (!flag4)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag5 = (nint)0 != 1;
									object obj3 = default;
									obj2 = obj3;
									if (flag5)
									{
										goto IL_04e9;
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
					object obj4 = default;
					object obj5 = default;
					bool flag6 = obj4 == obj5;
					bool flag7 = !flag6;
					object obj6 = default;
					obj2 = obj6;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj8 = default;
							object obj7 = obj8;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj9 = default;
								if (obj9 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+4]");
									object obj10 = (nint)0 << 2;
									object obj11 = (object)sSEventsManagerController + obj10;
									obj11 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+4]");
									object obj12 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SSEventsManagerController)+4]");
									object obj13 = -1;
									result = SSEventType.None;
									goto IL_04e4;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
								object obj14 = obj8;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag8 = (nint)0 != 1;
								result2 = (flag8 ? SSEventType.SpecialPowerBoard : SSEventType.None);
								if (flag8)
								{
									goto IL_049b;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag9 = (nint)0 == 1;
						object obj15 = default;
						obj2 = obj15;
						if (flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
							goto IL_049b;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					goto IL_04e9;
				}
			}
		}
		goto IL_04e4;
		IL_04e4:
		return result;
		IL_049b:
		return result2;
		IL_04e9:
		result = (SSEventType)obj2;
		goto IL_04e4;
	}

	private void SetCurrentEventManager()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		if (_currentEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
		SSEventsManagerController sSEventsManagerController = (SSEventsManagerController)(this + 8);
		SSEventType enabledEventType = sSEventsManagerController.GetEnabledEventType();
		long currentEventID = sSEventsManagerController.GetCurrentEventID();
		if (sSEventsManagerController != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
			object obj = default;
			if ((long)obj == currentEventID)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj2 = default;
				if ((nint)obj2 == (nint)enabledEventType)
				{
					goto IL_013a;
				}
			}
		}
		if (enabledEventType != SSEventType.CharacterName)
		{
			AwardsData.ResetWordyWeekendChallengeOneWeekend();
		}
		CharacterNameEventManager characterNameEventManager = CharacterNameEventManager.Create(SSEventType.CharacterName, currentEventID);
		sSEventsManagerController = (SSEventsManagerController)(object)characterNameEventManager;
		goto IL_013a;
		IL_013a:
		if (SSEventsManagerController.m_OnSSEventChangedHandler != null)
		{
			Action onSSEventChangedHandler = SSEventsManagerController.m_OnSSEventChangedHandler;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
