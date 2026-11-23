using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UnityEngine;

public class LimitedCharacterPopupManager
{
	private sealed class _003CTimer_003Ed__25(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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

	private const Characters.CharacterType _currentCharacter = Characters.CharacterType.nick;

	private int _currentThemeIndex;

	private static LimitedCharacterPopupManager _instance;

	private bool _isInitialized;

	private IEnumerator _startTimerCoroutine;

	private IEnumerator _endTimerCoroutine;

	private static Action m_OnLimitedCharacterStartedHandler;

	private static Action m_OnLimitedCharacterExpiredHandler;

	public Characters.CharacterType currentCharacter
	{
		get
		{
			if (~(Globals.DEBUG_LIMITED_CHARACTER_POPUP ? 1u : 0u) != 0)
			{
				return Characters.CharacterType.nick;
			}
			return Globals.DEBUG_LIMITED_CHARACTER_POPUP_TYPE;
		}
	}

	public int currentThemeIndex
	{
		get
		{
			return _currentThemeIndex;
		}
		set
		{
			_currentThemeIndex = value;
		}
	}

	public static LimitedCharacterPopupManager Instance
	{
		get
		{
			if (_instance == null)
			{
				LimitedCharacterPopupManager limitedCharacterPopupManager = default;
				limitedCharacterPopupManager._002Ector();
				_instance = limitedCharacterPopupManager;
			}
			return _instance;
		}
	}

	public static event Action OnLimitedCharacterStartedHandler
	{
		add
		{
			Delegate obj = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
				Action onLimitedCharacterStartedHandler = action;
				if (!flag)
				{
					onLimitedCharacterStartedHandler = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
				}
				LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler = onLimitedCharacterStartedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
				Action onLimitedCharacterStartedHandler = action;
				if (!flag)
				{
					onLimitedCharacterStartedHandler = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
				}
				LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler = onLimitedCharacterStartedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnLimitedCharacterExpiredHandler
	{
		add
		{
			Delegate obj = LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
				Action onLimitedCharacterExpiredHandler = action;
				if (!flag)
				{
					onLimitedCharacterExpiredHandler = LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
				}
				LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler = onLimitedCharacterExpiredHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
				Action onLimitedCharacterExpiredHandler = action;
				if (!flag)
				{
					onLimitedCharacterExpiredHandler = LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
				}
				LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler = onLimitedCharacterExpiredHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private LimitedCharacterPopupManager()
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
			action._002Ector(this, (nint)__ldftn(LimitedCharacterPopupManager.StartTimer));
			UIScreenController.OnApplicationResumed += action;
			StartTimer();
			_isInitialized = true;
		}
	}

	public unsafe bool IsCharacterAvailable()
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
		LimitedCharacterPopupManager limitedCharacterPopupManager = (LimitedCharacterPopupManager)(obj - 16);
		int result = 1;
		if (!Globals.DEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			Characters.CharacterType characterType = limitedCharacterPopupManager.currentCharacter;
			DateTime value = instance.CharacterStartAvailabilityDate(characterType);
			PlayerInfo instance2 = PlayerInfo.Instance;
			Characters.CharacterType characterType2 = limitedCharacterPopupManager.currentCharacter;
			DateTime value2 = instance2.CharacterExpirationDate(characterType2);
			DateTime now = CDateTime.Now;
			limitedCharacterPopupManager._currentThemeIndex = (int)now;
			DateTime dateTime = (DateTime)(limitedCharacterPopupManager + 8);
			int num = ((DateTime*)dateTime)->CompareTo(value);
			bool flag = num < 1;
			result = 0;
			if (!flag)
			{
				DateTime dateTime2 = (DateTime)(limitedCharacterPopupManager + 8);
				int num2 = ((DateTime*)dateTime2)->CompareTo(value2);
				result = num2 >> 31;
			}
		}
		return (byte)result != 0;
	}

	public bool ShouldButtonBeVisible()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		Characters.CharacterType characterType = ((LimitedCharacterPopupManager)null).currentCharacter;
		if (instance.IsCharacterOwned(characterType))
		{
			return false;
		}
		return ((LimitedCharacterPopupManager)null).IsCharacterAvailable();
	}

	public bool CurrentlyShownCharacterMatchesEventItem()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_00e6: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		obj = 0;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		bool flag = activeEventManager == null;
		bool result = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			bool flag2 = (nint)obj3 != 3;
			result = false;
			if (!flag2)
			{
				_ = 0;
				object obj4 = obj + 15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
				obj = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
				bool flag3 = (nint)0 == 0;
				result = false;
				if (!flag3)
				{
					UIModelController instance2 = UIModelController.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					bool flag4 = (nint)0 != (nint)instance2._currentlyShownModel;
					result = false;
					if (!flag4)
					{
						result = (byte)(int)obj != 0;
					}
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
		LimitedCharacterPopupManager limitedCharacterPopupManager = (LimitedCharacterPopupManager)(obj - 16);
		limitedCharacterPopupManager = (LimitedCharacterPopupManager)0;
		PlayerInfo instance = PlayerInfo.Instance;
		Characters.CharacterType characterType = limitedCharacterPopupManager.currentCharacter;
		DateTime dateTime = instance.CharacterStartAvailabilityDate(characterType);
		PlayerInfo instance2 = PlayerInfo.Instance;
		Characters.CharacterType characterType2 = limitedCharacterPopupManager.currentCharacter;
		DateTime dateTime2 = instance2.CharacterExpirationDate(characterType2);
		DateTime now = CDateTime.Now;
		limitedCharacterPopupManager._currentThemeIndex = (int)now;
		CoroutineUtil.StopCoroutine(_startTimerCoroutine);
		CoroutineUtil.StopCoroutine(_endTimerCoroutine);
		DateTime dateTime3 = (DateTime)(limitedCharacterPopupManager + 8);
		int num = ((DateTime*)dateTime3)->CompareTo(dateTime);
		if (num <= -1)
		{
			TimeSpan timeSpan = dateTime - (DateTime)limitedCharacterPopupManager._currentThemeIndex;
			limitedCharacterPopupManager = (LimitedCharacterPopupManager)timeSpan;
			float timeLeft = (float)limitedCharacterPopupManager * 1E-07f;
			IEnumerator startTimerCoroutine = limitedCharacterPopupManager.Timer(timeLeft, LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler);
			_startTimerCoroutine = startTimerCoroutine;
			Coroutine coroutine = CoroutineUtil.StartCoroutine(_startTimerCoroutine);
		}
		DateTime dateTime4 = (DateTime)(limitedCharacterPopupManager + 8);
		int num2 = ((DateTime*)dateTime4)->CompareTo(dateTime2);
		if (num2 <= -1)
		{
			TimeSpan timeSpan2 = dateTime2 - (DateTime)limitedCharacterPopupManager._currentThemeIndex;
			limitedCharacterPopupManager = (LimitedCharacterPopupManager)timeSpan2;
			float timeLeft2 = (float)limitedCharacterPopupManager * 1E-07f;
			IEnumerator endTimerCoroutine = limitedCharacterPopupManager.Timer(timeLeft2, LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler);
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
