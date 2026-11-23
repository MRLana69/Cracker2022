using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.Utility;
using UnityEngine;

public class LimitedBoardPopupManager
{
	private sealed class _003CTimer_003Ed__24(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float timeLeft;

		public Action handler;

		private float _003CstartPoint_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0090: Expected I4, but got I8
			//IL_00b0: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					float num;
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							goto IL_0171;
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
					if (!(num < timeLeft))
					{
						Action action = handler;
						if (handler != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						}
						goto IL_0171;
					}
					float deltaTime = RealTimeTracker.deltaTime;
					float num2 = num + deltaTime;
					_003C_003E2__current = null;
					_003CstartPoint_003E5__2 = num2;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E1__state = -1;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
			return true;
			IL_0171:
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

	private const Hoverboards.BoardType _currentBoardType = Hoverboards.BoardType.starboard;

	private static LimitedBoardPopupManager _instance;

	private bool _isInitialized;

	private IEnumerator _startTimerCoroutine;

	private IEnumerator _endTimerCoroutine;

	private static Action m_OnLimitedBoardStartedHandler;

	private static Action m_OnLimitedBoardExpiredHandler;

	public Hoverboards.BoardType currentBoardType
	{
		get
		{
			if (~(Globals.DEBUG_LIMITED_BOARD_POPUP ? 1u : 0u) != 0)
			{
				return Hoverboards.BoardType.starboard;
			}
			return Globals.DEBUG_LIMITED_BOARD_POPUP_TYPE;
		}
	}

	public int currentlyShownThemeIndex
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public static LimitedBoardPopupManager Instance
	{
		get
		{
			if (_instance == null)
			{
				LimitedBoardPopupManager limitedBoardPopupManager = default;
				limitedBoardPopupManager._002Ector();
				_instance = limitedBoardPopupManager;
			}
			return _instance;
		}
	}

	public static event Action OnLimitedBoardStartedHandler
	{
		add
		{
			Delegate obj = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
				Action onLimitedBoardStartedHandler = action;
				if (!flag)
				{
					onLimitedBoardStartedHandler = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
				}
				LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler = onLimitedBoardStartedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
				Action onLimitedBoardStartedHandler = action;
				if (!flag)
				{
					onLimitedBoardStartedHandler = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
				}
				LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler = onLimitedBoardStartedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnLimitedBoardExpiredHandler
	{
		add
		{
			Delegate obj = LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
				Action onLimitedBoardExpiredHandler = action;
				if (!flag)
				{
					onLimitedBoardExpiredHandler = LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
				}
				LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler = onLimitedBoardExpiredHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
				Action onLimitedBoardExpiredHandler = action;
				if (!flag)
				{
					onLimitedBoardExpiredHandler = LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
				}
				LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler = onLimitedBoardExpiredHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private LimitedBoardPopupManager()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			Initialize();
		}
	}

	private unsafe void Initialize()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(LimitedBoardPopupManager.StartTimer));
			UIScreenController.OnApplicationResumed += action;
			StartTimer();
			_isInitialized = true;
		}
	}

	public unsafe bool IsBoardAvailable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008b: Expected I4, but got VT
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected VT, but got Unknown
		//IL_00a6: Expected Ref, but got VT
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected VT, but got Unknown
		//IL_00f0: Expected Ref, but got VT
		object obj = default;
		LimitedBoardPopupManager limitedBoardPopupManager = (LimitedBoardPopupManager)(obj - 16);
		int result = 1;
		if (!Globals.DEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			Hoverboards.BoardType boardType = limitedBoardPopupManager.currentBoardType;
			DateTime value = instance.BoardExpirationDate(boardType);
			PlayerInfo instance2 = PlayerInfo.Instance;
			Hoverboards.BoardType boardType2 = limitedBoardPopupManager.currentBoardType;
			DateTime value2 = instance2.BoardStartAvailabilityDate(boardType2);
			DateTime now = CDateTime.Now;
			limitedBoardPopupManager._isInitialized = (byte)(int)now != 0;
			DateTime dateTime = (DateTime)(limitedBoardPopupManager + 8);
			int num = ((DateTime*)dateTime)->CompareTo(value2);
			bool flag = num < 1;
			result = 0;
			if (!flag)
			{
				DateTime dateTime2 = (DateTime)(limitedBoardPopupManager + 8);
				int num2 = ((DateTime*)dateTime2)->CompareTo(value);
				result = num2 >> 31;
			}
		}
		return (byte)result != 0;
	}

	public bool ShouldButtonBeVisible()
	{
		LimitedCharacterPopupManager instance = LimitedCharacterPopupManager.Instance;
		bool flag = instance.ShouldButtonBeVisible();
		UIScreenController instance2 = UIScreenController.Instance;
		string currentPopupName = instance2.GetCurrentPopupName();
		bool flag2 = currentPopupName != "LimitedCharacterPopup";
		PlayerInfo instance3 = PlayerInfo.Instance;
		Hoverboards.BoardType boardType = ((LimitedBoardPopupManager)null).currentBoardType;
		bool flag3 = instance3.IsHoverboardUnlocked(boardType);
		bool result = false;
		if (!flag)
		{
			result = false;
			if (flag2)
			{
				result = false;
				if (!flag3)
				{
					bool flag4 = ((LimitedBoardPopupManager)null).IsBoardAvailable();
					result = flag4;
				}
			}
		}
		return result;
	}

	private unsafe void StartTimer()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got I4
		//IL_006b: Expected I4, but got VT
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected VT, but got Unknown
		//IL_00a6: Expected Ref, but got VT
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected VT, but got Unknown
		//IL_0160: Expected Ref, but got VT
		//IL_00e7: Expected VT, but got I4
		//IL_00f8: Expected Obj, but got VT
		//IL_01a6: Expected VT, but got I4
		//IL_01b7: Expected Obj, but got VT
		object obj = default;
		LimitedBoardPopupManager limitedBoardPopupManager = (LimitedBoardPopupManager)(obj - 16);
		limitedBoardPopupManager = (LimitedBoardPopupManager)0;
		PlayerInfo instance = PlayerInfo.Instance;
		Hoverboards.BoardType boardType = limitedBoardPopupManager.currentBoardType;
		DateTime dateTime = instance.BoardStartAvailabilityDate(boardType);
		PlayerInfo instance2 = PlayerInfo.Instance;
		Hoverboards.BoardType boardType2 = limitedBoardPopupManager.currentBoardType;
		DateTime dateTime2 = instance2.BoardExpirationDate(boardType2);
		DateTime now = CDateTime.Now;
		limitedBoardPopupManager._isInitialized = (byte)(int)now != 0;
		CoroutineUtil.StopCoroutine(_startTimerCoroutine);
		CoroutineUtil.StopCoroutine(_endTimerCoroutine);
		DateTime dateTime3 = (DateTime)(limitedBoardPopupManager + 8);
		int num = ((DateTime*)dateTime3)->CompareTo(dateTime);
		if (num <= -1)
		{
			TimeSpan timeSpan = dateTime - (DateTime)limitedBoardPopupManager._isInitialized;
			limitedBoardPopupManager = (LimitedBoardPopupManager)timeSpan;
			float timeLeft = (float)limitedBoardPopupManager * 1E-07f;
			IEnumerator startTimerCoroutine = limitedBoardPopupManager.Timer(timeLeft, LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler);
			_startTimerCoroutine = startTimerCoroutine;
			Coroutine coroutine = CoroutineUtil.StartCoroutine(_startTimerCoroutine);
		}
		DateTime dateTime4 = (DateTime)(limitedBoardPopupManager + 8);
		int num2 = ((DateTime*)dateTime4)->CompareTo(dateTime2);
		if (num2 <= -1)
		{
			TimeSpan timeSpan2 = dateTime2 - (DateTime)limitedBoardPopupManager._isInitialized;
			limitedBoardPopupManager = (LimitedBoardPopupManager)timeSpan2;
			float timeLeft2 = (float)limitedBoardPopupManager * 1E-07f;
			IEnumerator endTimerCoroutine = limitedBoardPopupManager.Timer(timeLeft2, LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler);
			_endTimerCoroutine = endTimerCoroutine;
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(_endTimerCoroutine);
		}
	}

	private IEnumerator Timer(float timeLeft, Action handler)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
