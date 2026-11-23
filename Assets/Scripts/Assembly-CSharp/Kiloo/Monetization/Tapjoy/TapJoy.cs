using System;
using Cpp2ILInjected;
using Kiloo.Monetization.Tapjoy.Internal;
using UnityEngine;

namespace Kiloo.Monetization.Tapjoy;

public static class TapJoy
{
	private enum TapJoyConnectionState
	{
		Connecting,
		Connected,
		Disconnected
	}

	public const string INITIALIZE_SUCCESS_RETURN_VALUE = "success";

	private static TapJoyConnectionState _connectionState = TapJoyConnectionState.Disconnected;

	private static ITapjoyBridge _platformBridge;

	private static TapjoyConnectEvent _003C_003Ef__mg_0024cache0;

	private static TapjoyEarnedPointsEvent _003C_003Ef__mg_0024cache1;

	private static TapjoyGetFullScreenAdResponseEvent _003C_003Ef__mg_0024cache2;

	private static TapjoyGetPointsEvent _003C_003Ef__mg_0024cache3;

	private static TapjoyGetPointsErrorEvent _003C_003Ef__mg_0024cache4;

	private static TapjoySpendPointsEvent _003C_003Ef__mg_0024cache5;

	private static TapjoySpendPointsErrorEvent _003C_003Ef__mg_0024cache6;

	private static TapjoyViewWillDisappearEvent _003C_003Ef__mg_0024cache7;

	private static TapjoyViewDidDisappearEvent _003C_003Ef__mg_0024cache8;

	private static TapjoyViewWillAppearEvent _003C_003Ef__mg_0024cache9;

	private static TapjoyViewDidAppearEvent _003C_003Ef__mg_0024cacheA;

	private static TapjoyVideoStartEvent _003C_003Ef__mg_0024cacheB;

	private static TapjoyVideoErrorEvent _003C_003Ef__mg_0024cacheC;

	private static TapjoyVideoCompleteEvent _003C_003Ef__mg_0024cacheD;

	private static TapjoyConnectEvent m_onInitializeFinished;

	private static TapjoyGetFullScreenAdResponseEvent m_onFullScreenAdResponse;

	private static TapjoyEarnedPointsEvent m_onEarnPoints;

	private static TapjoyGetPointsEvent m_onGetPoints;

	private static TapjoyGetPointsErrorEvent m_onGetPointsError;

	private static TapjoySpendPointsEvent m_onSpendPoints;

	private static TapjoySpendPointsErrorEvent m_onSpendPointsError;

	private static TapjoyViewWillAppearEvent m_onViewWillAppear;

	private static TapjoyViewDidAppearEvent m_onViewDidAppear;

	private static TapjoyViewWillDisappearEvent m_onViewWillDisappear;

	private static TapjoyViewDidDisappearEvent m_onViewDidDisappear;

	private static TapjoyVideoStartEvent m_onVideoStart;

	private static TapjoyVideoErrorEvent m_onVideoError;

	private static TapjoyVideoCompleteEvent m_onVideoComplete;

	public static bool isInitialized
	{
		get
		{
			if (_platformBridge != null)
			{
				return _connectionState == TapJoyConnectionState.Connected;
			}
			return false;
		}
	}

	public static event TapjoyConnectEvent onInitializeFinished
	{
		add
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			Delegate obj = TapJoy.m_onInitializeFinished;
			Delegate obj5 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				nint num = (nint)typeof(TapJoy);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v7 (Il2CppClass<Kiloo.Monetization.Tapjoy.TapJoy>)+5C]");
				object obj3 = -(-64);
				bool flag = obj == obj3;
				Delegate obj4 = obj5;
				if (!flag)
				{
					obj4 = (Delegate)obj3;
				}
				obj3 = obj4;
				Delegate obj6 = obj;
				if (!flag)
				{
					obj6 = (Delegate)obj3;
				}
				flag2 = (object)obj != obj6;
				obj = obj6;
			}
			while (flag2);
		}
		remove
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			Delegate obj = TapJoy.m_onInitializeFinished;
			Delegate obj5 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				nint num = (nint)typeof(TapJoy);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v7 (Il2CppClass<Kiloo.Monetization.Tapjoy.TapJoy>)+5C]");
				object obj3 = -(-64);
				bool flag = obj == obj3;
				Delegate obj4 = obj5;
				if (!flag)
				{
					obj4 = (Delegate)obj3;
				}
				obj3 = obj4;
				Delegate obj6 = obj;
				if (!flag)
				{
					obj6 = (Delegate)obj3;
				}
				flag2 = (object)obj != obj6;
				obj = obj6;
			}
			while (flag2);
		}
	}

	public static event TapjoyGetFullScreenAdResponseEvent onFullScreenAdResponse
	{
		add
		{
			Delegate obj = TapJoy.m_onFullScreenAdResponse;
			TapjoyGetFullScreenAdResponseEvent tapjoyGetFullScreenAdResponseEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onFullScreenAdResponse;
				TapjoyGetFullScreenAdResponseEvent tapjoyGetFullScreenAdResponseEvent = tapjoyGetFullScreenAdResponseEvent2;
				if (!flag)
				{
					tapjoyGetFullScreenAdResponseEvent = TapJoy.m_onFullScreenAdResponse;
				}
				TapJoy.m_onFullScreenAdResponse = tapjoyGetFullScreenAdResponseEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onFullScreenAdResponse;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onFullScreenAdResponse;
			TapjoyGetFullScreenAdResponseEvent tapjoyGetFullScreenAdResponseEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onFullScreenAdResponse;
				TapjoyGetFullScreenAdResponseEvent tapjoyGetFullScreenAdResponseEvent = tapjoyGetFullScreenAdResponseEvent2;
				if (!flag)
				{
					tapjoyGetFullScreenAdResponseEvent = TapJoy.m_onFullScreenAdResponse;
				}
				TapJoy.m_onFullScreenAdResponse = tapjoyGetFullScreenAdResponseEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onFullScreenAdResponse;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyEarnedPointsEvent onEarnPoints
	{
		add
		{
			Delegate obj = TapJoy.m_onEarnPoints;
			TapjoyEarnedPointsEvent tapjoyEarnedPointsEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onEarnPoints;
				TapjoyEarnedPointsEvent tapjoyEarnedPointsEvent = tapjoyEarnedPointsEvent2;
				if (!flag)
				{
					tapjoyEarnedPointsEvent = TapJoy.m_onEarnPoints;
				}
				TapJoy.m_onEarnPoints = tapjoyEarnedPointsEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onEarnPoints;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onEarnPoints;
			TapjoyEarnedPointsEvent tapjoyEarnedPointsEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onEarnPoints;
				TapjoyEarnedPointsEvent tapjoyEarnedPointsEvent = tapjoyEarnedPointsEvent2;
				if (!flag)
				{
					tapjoyEarnedPointsEvent = TapJoy.m_onEarnPoints;
				}
				TapJoy.m_onEarnPoints = tapjoyEarnedPointsEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onEarnPoints;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyGetPointsEvent onGetPoints
	{
		add
		{
			Delegate obj = TapJoy.m_onGetPoints;
			TapjoyGetPointsEvent tapjoyGetPointsEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onGetPoints;
				TapjoyGetPointsEvent tapjoyGetPointsEvent = tapjoyGetPointsEvent2;
				if (!flag)
				{
					tapjoyGetPointsEvent = TapJoy.m_onGetPoints;
				}
				TapJoy.m_onGetPoints = tapjoyGetPointsEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onGetPoints;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onGetPoints;
			TapjoyGetPointsEvent tapjoyGetPointsEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onGetPoints;
				TapjoyGetPointsEvent tapjoyGetPointsEvent = tapjoyGetPointsEvent2;
				if (!flag)
				{
					tapjoyGetPointsEvent = TapJoy.m_onGetPoints;
				}
				TapJoy.m_onGetPoints = tapjoyGetPointsEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onGetPoints;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyGetPointsErrorEvent onGetPointsError
	{
		add
		{
			Delegate obj = TapJoy.m_onGetPointsError;
			TapjoyGetPointsErrorEvent tapjoyGetPointsErrorEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onGetPointsError;
				TapjoyGetPointsErrorEvent tapjoyGetPointsErrorEvent = tapjoyGetPointsErrorEvent2;
				if (!flag)
				{
					tapjoyGetPointsErrorEvent = TapJoy.m_onGetPointsError;
				}
				TapJoy.m_onGetPointsError = tapjoyGetPointsErrorEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onGetPointsError;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onGetPointsError;
			TapjoyGetPointsErrorEvent tapjoyGetPointsErrorEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onGetPointsError;
				TapjoyGetPointsErrorEvent tapjoyGetPointsErrorEvent = tapjoyGetPointsErrorEvent2;
				if (!flag)
				{
					tapjoyGetPointsErrorEvent = TapJoy.m_onGetPointsError;
				}
				TapJoy.m_onGetPointsError = tapjoyGetPointsErrorEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onGetPointsError;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoySpendPointsEvent onSpendPoints
	{
		add
		{
			Delegate obj = TapJoy.m_onSpendPoints;
			TapjoySpendPointsEvent tapjoySpendPointsEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onSpendPoints;
				TapjoySpendPointsEvent tapjoySpendPointsEvent = tapjoySpendPointsEvent2;
				if (!flag)
				{
					tapjoySpendPointsEvent = TapJoy.m_onSpendPoints;
				}
				TapJoy.m_onSpendPoints = tapjoySpendPointsEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onSpendPoints;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onSpendPoints;
			TapjoySpendPointsEvent tapjoySpendPointsEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onSpendPoints;
				TapjoySpendPointsEvent tapjoySpendPointsEvent = tapjoySpendPointsEvent2;
				if (!flag)
				{
					tapjoySpendPointsEvent = TapJoy.m_onSpendPoints;
				}
				TapJoy.m_onSpendPoints = tapjoySpendPointsEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onSpendPoints;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoySpendPointsErrorEvent onSpendPointsError
	{
		add
		{
			Delegate obj = TapJoy.m_onSpendPointsError;
			TapjoySpendPointsErrorEvent tapjoySpendPointsErrorEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onSpendPointsError;
				TapjoySpendPointsErrorEvent tapjoySpendPointsErrorEvent = tapjoySpendPointsErrorEvent2;
				if (!flag)
				{
					tapjoySpendPointsErrorEvent = TapJoy.m_onSpendPointsError;
				}
				TapJoy.m_onSpendPointsError = tapjoySpendPointsErrorEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onSpendPointsError;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onSpendPointsError;
			TapjoySpendPointsErrorEvent tapjoySpendPointsErrorEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onSpendPointsError;
				TapjoySpendPointsErrorEvent tapjoySpendPointsErrorEvent = tapjoySpendPointsErrorEvent2;
				if (!flag)
				{
					tapjoySpendPointsErrorEvent = TapJoy.m_onSpendPointsError;
				}
				TapJoy.m_onSpendPointsError = tapjoySpendPointsErrorEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onSpendPointsError;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyViewWillAppearEvent onViewWillAppear
	{
		add
		{
			Delegate obj = TapJoy.m_onViewWillAppear;
			TapjoyViewWillAppearEvent tapjoyViewWillAppearEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onViewWillAppear;
				TapjoyViewWillAppearEvent tapjoyViewWillAppearEvent = tapjoyViewWillAppearEvent2;
				if (!flag)
				{
					tapjoyViewWillAppearEvent = TapJoy.m_onViewWillAppear;
				}
				TapJoy.m_onViewWillAppear = tapjoyViewWillAppearEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onViewWillAppear;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onViewWillAppear;
			TapjoyViewWillAppearEvent tapjoyViewWillAppearEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onViewWillAppear;
				TapjoyViewWillAppearEvent tapjoyViewWillAppearEvent = tapjoyViewWillAppearEvent2;
				if (!flag)
				{
					tapjoyViewWillAppearEvent = TapJoy.m_onViewWillAppear;
				}
				TapJoy.m_onViewWillAppear = tapjoyViewWillAppearEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onViewWillAppear;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyViewDidAppearEvent onViewDidAppear
	{
		add
		{
			Delegate obj = TapJoy.m_onViewDidAppear;
			TapjoyViewDidAppearEvent tapjoyViewDidAppearEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onViewDidAppear;
				TapjoyViewDidAppearEvent tapjoyViewDidAppearEvent = tapjoyViewDidAppearEvent2;
				if (!flag)
				{
					tapjoyViewDidAppearEvent = TapJoy.m_onViewDidAppear;
				}
				TapJoy.m_onViewDidAppear = tapjoyViewDidAppearEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onViewDidAppear;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onViewDidAppear;
			TapjoyViewDidAppearEvent tapjoyViewDidAppearEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onViewDidAppear;
				TapjoyViewDidAppearEvent tapjoyViewDidAppearEvent = tapjoyViewDidAppearEvent2;
				if (!flag)
				{
					tapjoyViewDidAppearEvent = TapJoy.m_onViewDidAppear;
				}
				TapJoy.m_onViewDidAppear = tapjoyViewDidAppearEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onViewDidAppear;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyViewWillDisappearEvent onViewWillDisappear
	{
		add
		{
			Delegate obj = TapJoy.m_onViewWillDisappear;
			TapjoyViewWillDisappearEvent tapjoyViewWillDisappearEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onViewWillDisappear;
				TapjoyViewWillDisappearEvent tapjoyViewWillDisappearEvent = tapjoyViewWillDisappearEvent2;
				if (!flag)
				{
					tapjoyViewWillDisappearEvent = TapJoy.m_onViewWillDisappear;
				}
				TapJoy.m_onViewWillDisappear = tapjoyViewWillDisappearEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onViewWillDisappear;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onViewWillDisappear;
			TapjoyViewWillDisappearEvent tapjoyViewWillDisappearEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onViewWillDisappear;
				TapjoyViewWillDisappearEvent tapjoyViewWillDisappearEvent = tapjoyViewWillDisappearEvent2;
				if (!flag)
				{
					tapjoyViewWillDisappearEvent = TapJoy.m_onViewWillDisappear;
				}
				TapJoy.m_onViewWillDisappear = tapjoyViewWillDisappearEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onViewWillDisappear;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyViewDidDisappearEvent onViewDidDisappear
	{
		add
		{
			Delegate obj = TapJoy.m_onViewDidDisappear;
			TapjoyViewDidDisappearEvent tapjoyViewDidDisappearEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onViewDidDisappear;
				TapjoyViewDidDisappearEvent tapjoyViewDidDisappearEvent = tapjoyViewDidDisappearEvent2;
				if (!flag)
				{
					tapjoyViewDidDisappearEvent = TapJoy.m_onViewDidDisappear;
				}
				TapJoy.m_onViewDidDisappear = tapjoyViewDidDisappearEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onViewDidDisappear;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onViewDidDisappear;
			TapjoyViewDidDisappearEvent tapjoyViewDidDisappearEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onViewDidDisappear;
				TapjoyViewDidDisappearEvent tapjoyViewDidDisappearEvent = tapjoyViewDidDisappearEvent2;
				if (!flag)
				{
					tapjoyViewDidDisappearEvent = TapJoy.m_onViewDidDisappear;
				}
				TapJoy.m_onViewDidDisappear = tapjoyViewDidDisappearEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onViewDidDisappear;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyVideoStartEvent onVideoStart
	{
		add
		{
			Delegate obj = TapJoy.m_onVideoStart;
			TapjoyVideoStartEvent tapjoyVideoStartEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onVideoStart;
				TapjoyVideoStartEvent tapjoyVideoStartEvent = tapjoyVideoStartEvent2;
				if (!flag)
				{
					tapjoyVideoStartEvent = TapJoy.m_onVideoStart;
				}
				TapJoy.m_onVideoStart = tapjoyVideoStartEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onVideoStart;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onVideoStart;
			TapjoyVideoStartEvent tapjoyVideoStartEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onVideoStart;
				TapjoyVideoStartEvent tapjoyVideoStartEvent = tapjoyVideoStartEvent2;
				if (!flag)
				{
					tapjoyVideoStartEvent = TapJoy.m_onVideoStart;
				}
				TapJoy.m_onVideoStart = tapjoyVideoStartEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onVideoStart;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyVideoErrorEvent onVideoError
	{
		add
		{
			Delegate obj = TapJoy.m_onVideoError;
			TapjoyVideoErrorEvent tapjoyVideoErrorEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onVideoError;
				TapjoyVideoErrorEvent tapjoyVideoErrorEvent = tapjoyVideoErrorEvent2;
				if (!flag)
				{
					tapjoyVideoErrorEvent = TapJoy.m_onVideoError;
				}
				TapJoy.m_onVideoError = tapjoyVideoErrorEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onVideoError;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onVideoError;
			TapjoyVideoErrorEvent tapjoyVideoErrorEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onVideoError;
				TapjoyVideoErrorEvent tapjoyVideoErrorEvent = tapjoyVideoErrorEvent2;
				if (!flag)
				{
					tapjoyVideoErrorEvent = TapJoy.m_onVideoError;
				}
				TapJoy.m_onVideoError = tapjoyVideoErrorEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onVideoError;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event TapjoyVideoCompleteEvent onVideoComplete
	{
		add
		{
			Delegate obj = TapJoy.m_onVideoComplete;
			TapjoyVideoCompleteEvent tapjoyVideoCompleteEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onVideoComplete;
				TapjoyVideoCompleteEvent tapjoyVideoCompleteEvent = tapjoyVideoCompleteEvent2;
				if (!flag)
				{
					tapjoyVideoCompleteEvent = TapJoy.m_onVideoComplete;
				}
				TapJoy.m_onVideoComplete = tapjoyVideoCompleteEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onVideoComplete;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = TapJoy.m_onVideoComplete;
			TapjoyVideoCompleteEvent tapjoyVideoCompleteEvent2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == TapJoy.m_onVideoComplete;
				TapjoyVideoCompleteEvent tapjoyVideoCompleteEvent = tapjoyVideoCompleteEvent2;
				if (!flag)
				{
					tapjoyVideoCompleteEvent = TapJoy.m_onVideoComplete;
				}
				TapJoy.m_onVideoComplete = tapjoyVideoCompleteEvent;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = TapJoy.m_onVideoComplete;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static bool IsSupportedOnPlatform()
	{
		//IL_0034: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.OSXEditor)
		{
			object obj = platform - 7;
			bool flag = (nint)obj == 4;
			bool flag2 = (nint)obj == 1;
			return flag | flag2;
		}
		return false;
	}

	public unsafe static void Initialize(string appId, string appKey, string eventName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_ = 0;
		if (_connectionState == TapJoyConnectionState.Connecting || isInitialized)
		{
			LogError("TapJoy has already been configured. Ignoring new parameters.");
			return;
		}
		_connectionState = TapJoyConnectionState.Connecting;
		if (_platformBridge == null)
		{
			RuntimePlatform platform = Application.platform;
			object obj3 = platform - 8;
			TapjoyIOS platformBridge;
			if (platform != RuntimePlatform.IPhonePlayer)
			{
				if ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 != 3)
				{
					RuntimePlatform platform2 = Application.platform;
					_ = -1;
					obj = (Enum)(object)typeof(RuntimePlatform);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
					_ = 0;
					string text = obj.ToString();
					string msg = "There's no platform bridge for the current platform: " + text;
					LogError(msg);
					return;
				}
				TapjoyAndroid tapjoyAndroid = TapjoyAndroid.CreatePlugin();
				platformBridge = (TapjoyIOS)(object)tapjoyAndroid;
			}
			else
			{
				platformBridge = TapjoyIOS.CreatePlugin();
			}
			_platformBridge = platformBridge;
			TapjoyConnectEvent tapjoyConnectEvent = default;
			tapjoyConnectEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnInitializeFinished));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyEarnedPointsEvent tapjoyEarnedPointsEvent = default;
			tapjoyEarnedPointsEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnEarnPoints));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyGetFullScreenAdResponseEvent tapjoyGetFullScreenAdResponseEvent = default;
			tapjoyGetFullScreenAdResponseEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnFullScreenAdResponse));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyGetPointsEvent tapjoyGetPointsEvent = default;
			tapjoyGetPointsEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnGetPoints));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyGetPointsErrorEvent tapjoyGetPointsErrorEvent = default;
			tapjoyGetPointsErrorEvent._002Ector(null, (nint)(delegate*<void>)(&OnGetPointsError));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoySpendPointsEvent tapjoySpendPointsEvent = default;
			tapjoySpendPointsEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnSpendPoints));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoySpendPointsErrorEvent tapjoySpendPointsErrorEvent = default;
			tapjoySpendPointsErrorEvent._002Ector(null, (nint)(delegate*<void>)(&OnSpendPointsError));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyViewWillDisappearEvent tapjoyViewWillDisappearEvent = default;
			tapjoyViewWillDisappearEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnViewWillDisappear));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyViewDidDisappearEvent tapjoyViewDidDisappearEvent = default;
			tapjoyViewDidDisappearEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnViewDidDisappear));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyViewWillAppearEvent tapjoyViewWillAppearEvent = default;
			tapjoyViewWillAppearEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnViewWillAppear));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyViewDidAppearEvent tapjoyViewDidAppearEvent = default;
			tapjoyViewDidAppearEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnViewDidAppear));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyVideoStartEvent tapjoyVideoStartEvent = default;
			tapjoyVideoStartEvent._002Ector(null, (nint)(delegate*<void>)(&OnVideoStart));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyVideoErrorEvent tapjoyVideoErrorEvent = default;
			tapjoyVideoErrorEvent._002Ector(null, (nint)(delegate*<string, void>)(&OnVideoError));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			TapjoyVideoCompleteEvent tapjoyVideoCompleteEvent = default;
			tapjoyVideoCompleteEvent._002Ector(null, (nint)(delegate*<void>)(&OnVideoComplete));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @58D");
	}

	public static void GetFullScreenAd()
	{
		if (isInitialized)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void ShowFullScreenAd()
	{
		if (isInitialized)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void GetPoints()
	{
		if (isInitialized)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	public static void SpendPoints(int amount)
	{
		if (isInitialized)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	private static void OnInitializeFinished(string result)
	{
		bool flag = result != "success";
		TapJoyConnectionState connectionState = TapJoyConnectionState.Connected;
		if (flag)
		{
			connectionState = TapJoyConnectionState.Disconnected;
		}
		_connectionState = connectionState;
		if (TapJoy.m_onInitializeFinished != null)
		{
			TapjoyConnectEvent tapjoyConnectEvent = TapJoy.m_onInitializeFinished;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnFullScreenAdResponse(string result)
	{
		if (TapJoy.m_onFullScreenAdResponse != null)
		{
			TapjoyGetFullScreenAdResponseEvent tapjoyGetFullScreenAdResponseEvent = TapJoy.m_onFullScreenAdResponse;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnEarnPoints(string amount)
	{
		if (TapJoy.m_onEarnPoints != null)
		{
			TapjoyEarnedPointsEvent tapjoyEarnedPointsEvent = TapJoy.m_onEarnPoints;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnGetPoints(string amount)
	{
		if (TapJoy.m_onGetPoints != null)
		{
			TapjoyGetPointsEvent tapjoyGetPointsEvent = TapJoy.m_onGetPoints;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnGetPointsError()
	{
		if (TapJoy.m_onGetPointsError != null)
		{
			TapjoyGetPointsErrorEvent tapjoyGetPointsErrorEvent = TapJoy.m_onGetPointsError;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnSpendPoints(string amount)
	{
		if (TapJoy.m_onSpendPoints != null)
		{
			TapjoySpendPointsEvent tapjoySpendPointsEvent = TapJoy.m_onSpendPoints;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnSpendPointsError()
	{
		if (TapJoy.m_onSpendPointsError != null)
		{
			TapjoySpendPointsErrorEvent tapjoySpendPointsErrorEvent = TapJoy.m_onSpendPointsError;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnViewWillAppear(string viewType)
	{
		if (TapJoy.m_onViewWillAppear != null)
		{
			TapjoyViewWillAppearEvent tapjoyViewWillAppearEvent = TapJoy.m_onViewWillAppear;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnViewDidAppear(string viewType)
	{
		if (TapJoy.m_onViewDidAppear != null)
		{
			TapjoyViewDidAppearEvent tapjoyViewDidAppearEvent = TapJoy.m_onViewDidAppear;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnViewWillDisappear(string viewType)
	{
		if (TapJoy.m_onViewWillDisappear != null)
		{
			TapjoyViewWillDisappearEvent tapjoyViewWillDisappearEvent = TapJoy.m_onViewWillDisappear;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnViewDidDisappear(string viewType)
	{
		if (TapJoy.m_onViewDidDisappear != null)
		{
			TapjoyViewDidDisappearEvent tapjoyViewDidDisappearEvent = TapJoy.m_onViewDidDisappear;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnVideoStart()
	{
		if (TapJoy.m_onVideoStart != null)
		{
			TapjoyVideoStartEvent tapjoyVideoStartEvent = TapJoy.m_onVideoStart;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnVideoError(string error)
	{
		if (TapJoy.m_onVideoError != null)
		{
			TapjoyVideoErrorEvent tapjoyVideoErrorEvent = TapJoy.m_onVideoError;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void OnVideoComplete()
	{
		if (TapJoy.m_onVideoComplete != null)
		{
			TapjoyVideoCompleteEvent tapjoyVideoCompleteEvent = TapJoy.m_onVideoComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "TapJoy: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
