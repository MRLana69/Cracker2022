using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Characters.States;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlideinPowerupHelper : MonoBehaviour
{
	private enum SlideinPowerup
	{
		_notset,
		powerup1,
		powerup2
	}

	private sealed class _003CDelayResumeButtonsGlow_003Ed__56(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SlideinPowerupHelper _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_003C_003E4__this.ResumeButtonsGlowColor();
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 1.5f;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
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

	private sealed class _003CAnimateButtonBackground_003Ed__66(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SlideinPowerupHelper _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			SlideinPowerupHelper slideinPowerupHelper = _003C_003E4__this;
			if (_003C_003E1__state == 0)
			{
				goto IL_0102;
			}
			int num;
			if (_003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 2)
				{
					if (_003C_003E1__state == 3)
					{
						_003C_003E1__state = -1;
						goto IL_0362;
					}
					if (_003C_003E1__state == 4)
					{
						_003C_003E1__state = -1;
						goto IL_0399;
					}
					if (_003C_003E1__state != 5)
					{
						if (_003C_003E1__state != 6)
						{
							if (_003C_003E1__state != 7)
							{
								if (_003C_003E1__state == 8)
								{
									goto IL_0102;
								}
								goto IL_035c;
							}
							_003C_003E1__state = -1;
							goto IL_03c1;
						}
						_003C_003E1__state = -1;
						IEnumerator routine = _003C_003E4__this.AnimateButtonBackgrounGlow(slideinPowerupHelper._powerup2ButtonGlow);
						Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
						_003C_003E2__current = coroutine;
						num = 7;
					}
					else
					{
						_003C_003E1__state = -1;
						_ = 0.1f;
						object obj = default;
						_003C_003E2__current = obj;
						num = 6;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					IEnumerator routine2 = _003C_003E4__this.AnimateButtonBackgrounGlow(slideinPowerupHelper._powerup1ButtonGlow);
					Coroutine coroutine2 = _003C_003E4__this.StartCoroutine(routine2);
					_003C_003E2__current = coroutine2;
					num = 3;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_ = 0.1f;
				object obj2 = default;
				_003C_003E2__current = obj2;
				num = 2;
			}
			goto IL_038a;
			IL_0399:
			if (_003C_003E4__this.HeadstartButtonIsActive())
			{
				IEnumerator routine3 = _003C_003E4__this.AnimateButtonBackgrounGlow(slideinPowerupHelper._powerup2ButtonGlow);
				Coroutine coroutine3 = _003C_003E4__this.StartCoroutine(routine3);
				_003C_003E2__current = coroutine3;
				num = 5;
				goto IL_038a;
			}
			goto IL_03c1;
			IL_035c:
			return true;
			IL_03c1:
			_ = 1.4f;
			object obj3 = default;
			_003C_003E2__current = obj3;
			num = 8;
			goto IL_038a;
			IL_0102:
			_003C_003E1__state = -1;
			if (!_003C_003E4__this.ScoreboosterButtonIsActive())
			{
				goto IL_0362;
			}
			IEnumerator routine4 = _003C_003E4__this.AnimateButtonBackgrounGlow(slideinPowerupHelper._powerup1ButtonGlow);
			Coroutine coroutine4 = _003C_003E4__this.StartCoroutine(routine4);
			_003C_003E2__current = coroutine4;
			num = 1;
			goto IL_038a;
			IL_0362:
			if (_003C_003E4__this.ScoreboosterButtonIsActive() && _003C_003E4__this.HeadstartButtonIsActive())
			{
				_ = 0.5f;
				object obj4 = default;
				_003C_003E2__current = obj4;
				num = 4;
				goto IL_038a;
			}
			goto IL_0399;
			IL_038a:
			_003C_003E1__state = num;
			goto IL_035c;
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

	private sealed class _003CAnimateButtonBackgrounGlow_003Ed__69(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SlideinPowerupHelper _003C_003E4__this;

		public Image sprite;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0050: Expected Obj, but got VT
			//IL_005e: Expected Obj, but got VT
			//IL_006d: Expected Obj, but got VT
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected VT, but got Unknown
			//IL_0097: Expected VT, but got Obj
			//IL_00e6: Expected Obj, but got VT
			//IL_00f4: Expected Obj, but got VT
			//IL_0102: Expected Obj, but got VT
			//IL_0110: Expected I, but got VT
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected VT, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected VT, but got Unknown
			object obj = default;
			SlideinPowerupHelper slideinPowerupHelper = (SlideinPowerupHelper)(obj - 48);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					slideinPowerupHelper.powerup2Button = (SlideinPowerupButton)GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
					slideinPowerupHelper.powerup1BuyLabel = (TMP_Text)GlobalColors.FINAL_HEADSTART_BUTTON_GLOW_COLOR;
					slideinPowerupHelper.powerup1Button = (SlideinPowerupButton)GlobalColors.FINAL_HEADSTART_BUTTON_GLOW_COLOR;
					((UnityEngine.Object)slideinPowerupHelper).m_CachedPtr = (IntPtr)GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
					Color32 startValue = (Color32)(slideinPowerupHelper + 12);
					Color32 endValue = (Color32)(slideinPowerupHelper + 8);
					IEnumerator routine = slideinPowerupHelper.AnimateSpriteColor(sprite, startValue, endValue, 5f);
					Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
				}
			}
			else
			{
				_003C_003E1__state = -1;
				slideinPowerupHelper.powerup2BuyLabel = (TMP_Text)GlobalColors.FINAL_HEADSTART_BUTTON_GLOW_COLOR;
				slideinPowerupHelper._powerup2ButtonGlow = (Image)GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
				_ = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
				slideinPowerupHelper = (SlideinPowerupHelper)GlobalColors.FINAL_HEADSTART_BUTTON_GLOW_COLOR;
				Color32 startValue2 = (Color32)(slideinPowerupHelper + 4);
				IEnumerator routine2 = slideinPowerupHelper.AnimateSpriteColor(sprite, startValue2, (Color32)slideinPowerupHelper, 5f);
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine(routine2);
				_003C_003E2__current = coroutine2;
				_003C_003E1__state = 1;
			}
			return true;
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

	private sealed class _003CAnimateSpriteColor_003Ed__70(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float speedFactor;

		public Image spriteToAnimate;

		public Color32 startValue;

		public Color32 endValue;

		private float _003CanimationLerpFactor_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00e6: Expected Obj, but got VT
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected Obj, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected Obj, but got Unknown
			//IL_01c3: Expected Obj, but got VT
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected Obj, but got Unknown
			//IL_01f1: Expected Obj, but got VT
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected Obj, but got Unknown
			//IL_0251: Expected Obj, but got VT
			//IL_02b0: Expected Obj, but got VT
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Expected Obj, but got Unknown
			//IL_02de: Expected Obj, but got VT
			//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ec: Expected Obj, but got Unknown
			//IL_0343: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003CanimationLerpFactor_003E5__2 < 1f)
					{
						goto IL_00a1;
					}
				}
				goto IL_018f;
			}
			_003CanimationLerpFactor_003E5__2 = 0f;
			_003C_003E1__state = -1;
			goto IL_00a1;
			IL_00a1:
			float deltaTime = Time.deltaTime;
			float num = deltaTime * speedFactor;
			float num2 = (_003CanimationLerpFactor_003E5__2 += num);
			object obj3 = startValue >> 24;
			float num3 = (float)obj3 / 255f;
			object obj4 = startValue & 0xFF;
			float num4 = (float)obj4 / 255f;
			object obj5 = endValue & 0xFF;
			float num5 = (float)obj5 / 255f;
			float num6 = num5 - num4;
			float num7 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num8 = 0f;
			if (!flag)
			{
				num8 = num7;
			}
			float num9 = num6 * num8;
			float num10 = num4 + num9;
			object obj6 = startValue >> 16;
			object obj7 = obj6 & 0xFF;
			float num11 = (float)obj7 / 255f;
			object obj8 = endValue >> 16;
			object obj9 = obj8 & 0xFF;
			float num12 = (float)obj9 / 255f;
			float num13 = num12 - num11;
			float num14 = num13 * num8;
			float num15 = num11 + num14;
			object obj10 = endValue >> 24;
			float num16 = (float)obj10 / 255f;
			float num17 = num16 - num3;
			float num18 = num17 * num8;
			float num19 = num3 + num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			object obj11 = startValue >> 8;
			object obj12 = obj11 & 0xFF;
			float num20 = (float)obj12 / 255f;
			object obj13 = endValue >> 8;
			object obj14 = obj13 & 0xFF;
			float num21 = (float)obj14 / 255f;
			float num22 = num21 - num20;
			float num23 = num22 * num8;
			float num24 = num20 + num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_018f;
			IL_018f:
			return true;
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

	private SlideinPowerupButton powerup1Button;

	private SlideinPowerupButton powerup2Button;

	private TMP_Text powerup1AmountLabel;

	private TMP_Text powerup1BuyLabel;

	private TMP_Text powerup2AmountLabel;

	private TMP_Text powerup2BuyLabel;

	private Image _powerup1ButtonGlow;

	private Image _powerup2ButtonGlow;

	private SpringPosition powerup1Spring;

	private SpringPosition powerup2Spring;

	private Vector3 powerup1PositionOff = (Vector3)4818288652452141466L;

	private Vector3 powerup2PositionOff;

	private Vector3 powerup1PositionOn = (Vector3)4818288654599625114L;

	private Vector3 powerup2PositionOn;

	private static SlideinPowerupHelper instance;

	private bool _hasInited;

	private bool _initialButtonGlowHasStarted;

	private int _currentHeadstartGear;

	private int _currentScoreboosterGear;

	private const float _DELAY_AMOUNT_FOR_HIDING_THE_POWERUP_BUTTONS = 5f;

	private const float ANIMATE_GLOW_SPEED = 5f;

	private const float SHORT_TIME_BETWEEN_ANIMATION = 0.1f;

	private const float LONG_TIME_BETWEEN_ANIMATION = 0.5f;

	private const float PAUSE_BETWEEN_ANIMATIONs = 1.4f;

	private const float DELAY_ANIMATION_AMOUNT_ON_PRESS_POWERUP_BUTTON = 1.5f;

	private const int MAX_AMOUNT_OF_SCOREBOOSTER_GEARS = 3;

	private const int MAX_AMOUNT_OF_HEADSTART_GEARS = 3;

	private const bool HIDE_ON_ZERO_PURCHASE = true;

	private static Action<int> m_OnHeadstartActivated;

	private static Action<int> m_OnScoreBoostActivated;

	public float DELAY_AMOUNT_FOR_HIDING_THE_POWERUP_BUTTONS => 5f;

	public static SlideinPowerupHelper Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			SlideinPowerupHelper result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SlideinPowerupHelper));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				SlideinPowerupHelper slideinPowerupHelper = default;
				instance = slideinPowerupHelper;
				result = slideinPowerupHelper;
			}
			return result;
		}
	}

	public static event Action<int> OnHeadstartActivated
	{
		add
		{
			Delegate obj = SlideinPowerupHelper.m_OnHeadstartActivated;
			Action<int> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == SlideinPowerupHelper.m_OnHeadstartActivated;
				Action<int> onHeadstartActivated = action;
				if (!flag)
				{
					onHeadstartActivated = SlideinPowerupHelper.m_OnHeadstartActivated;
				}
				SlideinPowerupHelper.m_OnHeadstartActivated = onHeadstartActivated;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SlideinPowerupHelper.m_OnHeadstartActivated;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = SlideinPowerupHelper.m_OnHeadstartActivated;
			Action<int> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == SlideinPowerupHelper.m_OnHeadstartActivated;
				Action<int> onHeadstartActivated = action;
				if (!flag)
				{
					onHeadstartActivated = SlideinPowerupHelper.m_OnHeadstartActivated;
				}
				SlideinPowerupHelper.m_OnHeadstartActivated = onHeadstartActivated;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SlideinPowerupHelper.m_OnHeadstartActivated;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<int> OnScoreBoostActivated
	{
		add
		{
			Delegate obj = SlideinPowerupHelper.m_OnScoreBoostActivated;
			Action<int> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == SlideinPowerupHelper.m_OnScoreBoostActivated;
				Action<int> onScoreBoostActivated = action;
				if (!flag)
				{
					onScoreBoostActivated = SlideinPowerupHelper.m_OnScoreBoostActivated;
				}
				SlideinPowerupHelper.m_OnScoreBoostActivated = onScoreBoostActivated;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SlideinPowerupHelper.m_OnScoreBoostActivated;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = SlideinPowerupHelper.m_OnScoreBoostActivated;
			Action<int> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == SlideinPowerupHelper.m_OnScoreBoostActivated;
				Action<int> onScoreBoostActivated = action;
				if (!flag)
				{
					onScoreBoostActivated = SlideinPowerupHelper.m_OnScoreBoostActivated;
				}
				SlideinPowerupHelper.m_OnScoreBoostActivated = onScoreBoostActivated;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = SlideinPowerupHelper.m_OnScoreBoostActivated;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private unsafe void Start()
	{
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			InitHelper();
		}
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SlideinPowerupHelper.OnGameRevived));
		Game.OnGameRevived += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(SlideinPowerupHelper.OnMenuScreenShown));
		Game.OnMenuScreenShown += action2;
		SellConsumablesHelper sellConsumablesHelper = SellConsumablesHelper.instance;
		throw new ArgumentException();
	}

	private void OnEnable()
	{
		_initialButtonGlowHasStarted = false;
		UIScreenController uIScreenController = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		UIScreenController uIScreenController = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void ScreenDidChange(string screenOrPopupName)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		object obj;
		if (screenOrPopupName != null)
		{
			obj = 0;
			if (screenOrPopupName._stringLength != 0)
			{
				goto IL_0093;
			}
		}
		obj = 1;
		goto IL_0093;
		IL_0093:
		if (obj == null && screenOrPopupName.Equals("SaveMePopup"))
		{
			HidePowerup1();
			HidePowerup2();
		}
	}

	private unsafe void InitHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected VT, but got Unknown
		//IL_00a5: Expected F4, but got I
		//IL_00a0: Expected native int or pointer, but got VT
		//IL_00b4: Expected F4, but got VT
		//IL_00af: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		SlideinPowerupButton slideinPowerupButton = powerup1Button;
		slideinPowerupButton._helper = this;
		slideinPowerupButton._counter = 0;
		slideinPowerupButton._powerupNumber = 1;
		SlideinPowerupButton slideinPowerupButton2 = powerup2Button;
		slideinPowerupButton2._helper = this;
		slideinPowerupButton2._counter = 0;
		slideinPowerupButton2._powerupNumber = 2;
		Collider component = powerup1Button.GetComponent<Collider>();
		component.enabled = false;
		SlideinPowerupButton slideinPowerupButton3 = powerup1Button;
		slideinPowerupButton3.active = false;
		Collider component2 = powerup2Button.GetComponent<Collider>();
		component2.enabled = false;
		SlideinPowerupButton slideinPowerupButton4 = powerup2Button;
		slideinPowerupButton4.active = false;
		Transform transform = powerup1Button.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+3C]");
		_ = 0;
		_ = powerup1PositionOff;
		Vector3 localPosition = vector + 16;
		transform.localPosition = localPosition;
		Transform transform2 = powerup2Button.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+48]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)powerup2PositionOff;
		transform2.localPosition = vector;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		int upgradeAmount = playerInfo.GetUpgradeAmount(PowerupType.scorebooster);
		UpdateAmountLabel(powerup1AmountLabel, powerup1BuyLabel, upgradeAmount);
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		int upgradeAmount2 = playerInfo2.GetUpgradeAmount(PowerupType.headstart2000);
		UpdateAmountLabel(powerup2AmountLabel, powerup2BuyLabel, upgradeAmount2);
		PlayerInfo playerInfo3 = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private void OnPauseChange(bool pause)
	{
		if (!pause)
		{
			ResumeButtonsGlowColor();
		}
	}

	private void OnGameReviveOffer()
	{
		CancelInvoke("HideScorebooster");
		CancelInvoke("HideHeadstart");
		HidePowerup1();
		HidePowerup2();
	}

	private void OnGameRevived()
	{
		_currentHeadstartGear = 0;
		JetpackState jetpackState = JetpackState.Instance;
		jetpackState._canActivateLongHeadstart = false;
		jetpackState._activateTurboHeadstart = false;
		jetpackState._turboHeadstart = 0;
	}

	private void OnMenuScreenShown()
	{
		HidePowerup1();
		HidePowerup2();
		_currentScoreboosterGear = 0;
		_currentHeadstartGear = 0;
	}

	private void OnDestroy()
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private void OnUpgradeUsed(PowerupType powerupType, int newAmount)
	{
		//IL_00ae: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		switch (powerupType)
		{
		case PowerupType.scorebooster:
			((SlideinPowerupHelper)powerupType).UpdateAmountLabel(powerup1AmountLabel, powerup1BuyLabel, newAmount);
			if (newAmount == 0 && !SellConsumablesHelper.allowSellConsumablesDuringRun)
			{
				HidePowerup1();
			}
			break;
		case PowerupType.headstart2000:
			((SlideinPowerupHelper)powerupType).UpdateAmountLabel(powerup2AmountLabel, powerup2BuyLabel, newAmount);
			if (newAmount == 0 && !SellConsumablesHelper.allowSellConsumablesDuringRun)
			{
				HidePowerup2();
			}
			break;
		}
	}

	public unsafe void ShowPowerups()
	{
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			InitHelper();
		}
		ResetHeadstartButtonGlowColor();
		ResetScoreboosterButtonGlowColor();
		_initialButtonGlowHasStarted = false;
		if (_currentScoreboosterGear <= 2)
		{
			ShowPowerup1();
		}
		if (_currentHeadstartGear <= 2)
		{
			ShowPowerup2();
		}
		CancelInvoke("HideScorebooster");
		CancelInvoke("HideHeadstart");
		JetpackState jetpackState = JetpackState.Instance;
		JetpackState.OnHidTurboHeadstartButtonsDelegate onHidTurboHeadstartButtonsDelegate = default;
		onHidTurboHeadstartButtonsDelegate._002Ector(this, (nint)__ldftn(SlideinPowerupHelper.HideHeadstart));
		jetpackState.OnHidTurboHeadstartButtons += onHidTurboHeadstartButtonsDelegate;
		Invoke("HideScorebooster", 5f);
		Invoke("HideHeadstart", 5f);
	}

	private void HideScorebooster()
	{
		HidePowerup1();
	}

	private unsafe void HideHeadstart()
	{
		JetpackState jetpackState = JetpackState.Instance;
		JetpackState.OnHidTurboHeadstartButtonsDelegate onHidTurboHeadstartButtonsDelegate = default;
		onHidTurboHeadstartButtonsDelegate._002Ector(this, (nint)__ldftn(SlideinPowerupHelper.HideHeadstart));
		jetpackState.OnHidTurboHeadstartButtons -= onHidTurboHeadstartButtonsDelegate;
		HidePowerup2();
	}

	private void ResetHeadstartButtonGlowColor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got VT
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got VT
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got VT
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		StopCoroutine("AnimateButtonBackground");
		object obj3 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 16;
		object obj4 = obj3 & 0xFF;
		float num = (float)obj4 / 255f;
		object obj5 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 24;
		float num2 = (float)obj5 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj6 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR & 0xFF;
		float num3 = (float)obj6 / 255f;
		object obj7 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 8;
		object obj8 = obj7 & 0xFF;
		float num4 = (float)obj8 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
	}

	private void ResetScoreboosterButtonGlowColor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got VT
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got VT
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got VT
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		StopCoroutine("AnimateButtonBackground");
		object obj3 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 16;
		object obj4 = obj3 & 0xFF;
		float num = (float)obj4 / 255f;
		object obj5 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 24;
		float num2 = (float)obj5 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj6 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR & 0xFF;
		float num3 = (float)obj6 / 255f;
		object obj7 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 8;
		object obj8 = obj7 & 0xFF;
		float num4 = (float)obj8 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
	}

	private void ResetButtonGlowInvokes()
	{
		StopCoroutine("DelayResumeButtonsGlow");
		if (_currentScoreboosterGear < 3 || _currentHeadstartGear <= 2)
		{
			Coroutine coroutine = StartCoroutine("DelayResumeButtonsGlow");
		}
	}

	private IEnumerator DelayResumeButtonsGlow()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void ResumeButtonsGlowColor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got VT
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got VT
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got VT
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01a9: Expected Obj, but got VT
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01db: Expected Obj, but got VT
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0230: Expected Obj, but got VT
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0263: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		Collider component = powerup2Button.GetComponent<Collider>();
		if (!component.enabled)
		{
			Collider component2 = powerup1Button.GetComponent<Collider>();
			if (!component2.enabled)
			{
				return;
			}
		}
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			GameObject gameObject2 = base.gameObject;
			if (gameObject2.activeSelf)
			{
				object obj3 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 16;
				object obj4 = obj3 & 0xFF;
				float num = (float)obj4 / 255f;
				object obj5 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 24;
				float num2 = (float)obj5 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				object obj6 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR & 0xFF;
				float num3 = (float)obj6 / 255f;
				object obj7 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 8;
				object obj8 = obj7 & 0xFF;
				float num4 = (float)obj8 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				_ = 0;
				object obj9 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				object obj10 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 16;
				object obj11 = obj10 & 0xFF;
				float num5 = (float)obj11 / 255f;
				object obj12 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 24;
				float num6 = (float)obj12 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				object obj13 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR & 0xFF;
				float num7 = (float)obj13 / 255f;
				object obj14 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR >> 8;
				object obj15 = obj14 & 0xFF;
				float num8 = (float)obj15 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				Coroutine coroutine = StartCoroutine("AnimateButtonBackground");
			}
		}
	}

	public void SlideinPowerupClicked(int powerupAsInt)
	{
		//IL_0013: Expected Obj, but got I4
		Game game = Game.Instance;
		if (~(game._isPaused ? 1u : 0u) == 0)
		{
			return;
		}
		object obj = powerupAsInt - 1;
		bool success;
		if (powerupAsInt != 1)
		{
			if ((nint)obj != 1)
			{
				success = false;
			}
			else
			{
				Collider component = powerup2Button.GetComponent<Collider>();
				bool flag = component.enabled;
				bool flag2 = !flag;
				success = false;
				if (!flag2)
				{
					CancelInvoke("HideHeadstart");
					Invoke("HideHeadstart", 5f);
					ResetHeadstartButtonGlowColor();
					ResetButtonGlowInvokes();
					PlayerInfo playerInfo = PlayerInfo.Instance;
					int upgradeAmount = playerInfo.GetUpgradeAmount(PowerupType.headstart2000);
					if (upgradeAmount >= 1)
					{
						int num = ++_currentHeadstartGear;
						if (num <= 3)
						{
							Action<int> onHeadstartActivated = SlideinPowerupHelper.m_OnHeadstartActivated;
							if (SlideinPowerupHelper.m_OnHeadstartActivated != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ S0_v101 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
							}
							Game game2 = Game.Instance;
							game2.Megaheadstart();
							PlayerInfo playerInfo2 = PlayerInfo.Instance;
							playerInfo2.UseUpgrade(PowerupType.headstart2000);
							MissionsManager missionsManager = MissionsManager.Instance;
							missionsManager.PlayerDidThis(MissionTarget.Headstart);
							bool flag3 = _currentHeadstartGear < 3;
							success = true;
							if (flag3)
							{
								goto IL_04cb;
							}
						}
						HidePowerup2();
						bool flag4 = num < 4;
						success = flag4;
					}
					else if (SellConsumablesHelper.allowSellConsumablesDuringRun)
					{
						SellConsumablesHelper sellConsumablesHelper = SellConsumablesHelper.instance;
						sellConsumablesHelper.Sell(SellableConsumable.headstart);
						SlideinPowerupHelper slideinPowerupHelper = (SlideinPowerupHelper)(object)sellConsumablesHelper;
						success = false;
					}
					else
					{
						HidePowerup2();
						success = false;
					}
				}
			}
		}
		else
		{
			Collider component2 = powerup1Button.GetComponent<Collider>();
			bool flag5 = component2.enabled;
			bool flag6 = !flag5;
			success = false;
			if (!flag6)
			{
				CancelInvoke("HideScorebooster");
				Invoke("HideScorebooster", 5f);
				ResetScoreboosterButtonGlowColor();
				ResetButtonGlowInvokes();
				PlayerInfo playerInfo3 = PlayerInfo.Instance;
				int upgradeAmount2 = playerInfo3.GetUpgradeAmount(PowerupType.scorebooster);
				if (upgradeAmount2 >= 1)
				{
					int num2 = ++_currentScoreboosterGear;
					if (num2 <= 3)
					{
						Action<int> onScoreBoostActivated = SlideinPowerupHelper.m_OnScoreBoostActivated;
						if (SlideinPowerupHelper.m_OnScoreBoostActivated != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ S0_v50 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
						}
						GameStats gameStats = GameStats.Instance;
						gameStats._scoreBoosterActivated = true;
						GameStats gameStats2 = GameStats.Instance;
						gameStats2.ScoreBoosterTierIncrement();
						PlayerInfo playerInfo4 = PlayerInfo.Instance;
						playerInfo4.UseUpgrade(PowerupType.scorebooster);
						MissionsManager missionsManager2 = MissionsManager.Instance;
						missionsManager2.PlayerDidThis(MissionTarget.ScoreBooster);
						bool flag7 = _currentScoreboosterGear < 3;
						success = true;
						if (flag7)
						{
							goto IL_04cb;
						}
					}
					HidePowerup1();
					bool flag8 = num2 < 4;
					success = flag8;
				}
				else if (SellConsumablesHelper.allowSellConsumablesDuringRun)
				{
					SellConsumablesHelper sellConsumablesHelper2 = SellConsumablesHelper.instance;
					sellConsumablesHelper2.Sell(SellableConsumable.scorebooster);
					SlideinPowerupHelper slideinPowerupHelper = (SlideinPowerupHelper)(object)sellConsumablesHelper2;
					success = false;
				}
				else
				{
					HidePowerup1();
					success = false;
				}
			}
		}
		goto IL_04cb;
		IL_04cb:
		LogPowerupActivated(powerupAsInt, success);
	}

	public unsafe void ShowPowerup1()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected VT, but got Unknown
		//IL_0103: Expected F4, but got I
		//IL_00fe: Expected native int or pointer, but got VT
		//IL_0112: Expected F4, but got VT
		//IL_010d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		powerup1Button.ResetPowerupButtonColorToInitial();
		PlayerInfo playerInfo = PlayerInfo.Instance;
		int upgradeAmount = playerInfo.GetUpgradeAmount(PowerupType.scorebooster);
		if (upgradeAmount <= 0)
		{
			if (!SellConsumablesHelper.allowSellConsumablesDuringRun)
			{
				return;
			}
			PlayerInfo playerInfo2 = PlayerInfo.Instance;
			if (~(playerInfo2._allowSellScoreboosterDuringRun ? 1u : 0u) != 0)
			{
				return;
			}
		}
		Transform transform = powerup1Button.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+3C]");
		_ = 0;
		_ = powerup1PositionOff;
		Vector3 localPosition = vector + 16;
		transform.localPosition = localPosition;
		GameObject go = powerup1Button.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+54]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)powerup1PositionOn;
		SpringPosition springPosition = SpringPosition.Begin(go, vector, 10f);
		SpringPosition.OnFinished onFinished = default;
		onFinished._002Ector(this, (nint)__ldftn(SlideinPowerupHelper.OnPowerupButtonAnimatedIn));
		Delegate obj2 = Delegate.Combine(springPosition.onFinished, onFinished);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		SpringPosition.OnFinished onFinished2 = default;
		springPosition.onFinished = onFinished2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Collider component = powerup1Button.GetComponent<Collider>();
		component.enabled = true;
		SlideinPowerupButton slideinPowerupButton = powerup1Button;
		slideinPowerupButton.active = true;
		PlayerInfo playerInfo3 = PlayerInfo.Instance;
		if (!playerInfo3._allowSellScoreboosterDuringRun)
		{
			playerInfo3._dirty = true;
			playerInfo3._allowSellScoreboosterDuringRun = true;
		}
	}

	public unsafe void ShowPowerup2()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected VT, but got Unknown
		//IL_0103: Expected F4, but got I
		//IL_00fe: Expected native int or pointer, but got VT
		//IL_0112: Expected F4, but got VT
		//IL_010d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		powerup2Button.ResetPowerupButtonColorToInitial();
		PlayerInfo playerInfo = PlayerInfo.Instance;
		int upgradeAmount = playerInfo.GetUpgradeAmount(PowerupType.headstart2000);
		if (upgradeAmount <= 0)
		{
			if (!SellConsumablesHelper.allowSellConsumablesDuringRun)
			{
				return;
			}
			PlayerInfo playerInfo2 = PlayerInfo.Instance;
			if (~(playerInfo2._allowSellHeadstartDuringRun ? 1u : 0u) != 0)
			{
				return;
			}
		}
		Transform transform = powerup2Button.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+48]");
		_ = 0;
		_ = powerup2PositionOff;
		Vector3 localPosition = vector + 16;
		transform.localPosition = localPosition;
		GameObject go = powerup2Button.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+60]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)powerup2PositionOn;
		SpringPosition springPosition = SpringPosition.Begin(go, vector, 10f);
		SpringPosition.OnFinished onFinished = default;
		onFinished._002Ector(this, (nint)__ldftn(SlideinPowerupHelper.OnPowerupButtonAnimatedIn));
		Delegate obj2 = Delegate.Combine(springPosition.onFinished, onFinished);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		SpringPosition.OnFinished onFinished2 = default;
		springPosition.onFinished = onFinished2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Collider component = powerup2Button.GetComponent<Collider>();
		component.enabled = true;
		SlideinPowerupButton slideinPowerupButton = powerup2Button;
		slideinPowerupButton.active = true;
		PlayerInfo playerInfo3 = PlayerInfo.Instance;
		if (!playerInfo3._allowSellHeadstartDuringRun)
		{
			playerInfo3._dirty = true;
			playerInfo3._allowSellHeadstartDuringRun = true;
		}
	}

	public unsafe void HidePowerup1(bool instant = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected VT, but got Unknown
		//IL_00a9: Expected F4, but got I
		//IL_00a4: Expected native int or pointer, but got VT
		//IL_00b8: Expected F4, but got VT
		//IL_00b3: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Collider component = powerup1Button.GetComponent<Collider>();
		component.enabled = false;
		SlideinPowerupButton slideinPowerupButton = powerup1Button;
		slideinPowerupButton.active = false;
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			InitHelper();
		}
		if (instant)
		{
			SpringPosition component2 = powerup2Button.GetComponent<SpringPosition>();
			if (component2 != null)
			{
				component2.enabled = false;
			}
			Transform transform = powerup1Button.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+3C]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)powerup1PositionOff;
			transform.position = vector;
			ResetScoreboosterButtonGlowColor();
		}
		else
		{
			GameObject go = powerup1Button.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+3C]");
			_ = 0;
			_ = powerup1PositionOff;
			Vector3 pos = vector + 16;
			SpringPosition springPosition = SpringPosition.Begin(go, pos, 10f);
			SpringPosition.OnFinished onFinished = default;
			onFinished._002Ector(this, (nint)__ldftn(SlideinPowerupHelper.OnPowerup1ButtonAnimatedOut));
			Delegate obj2 = Delegate.Combine(springPosition.onFinished, onFinished);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			SpringPosition.OnFinished onFinished2 = default;
			springPosition.onFinished = onFinished2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
	}

	public unsafe void HidePowerup2(bool instant = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected VT, but got Unknown
		//IL_00a9: Expected F4, but got I
		//IL_00a4: Expected native int or pointer, but got VT
		//IL_00b8: Expected F4, but got VT
		//IL_00b3: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Collider component = powerup2Button.GetComponent<Collider>();
		component.enabled = false;
		SlideinPowerupButton slideinPowerupButton = powerup2Button;
		slideinPowerupButton.active = false;
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			InitHelper();
		}
		if (instant)
		{
			SpringPosition component2 = powerup2Button.GetComponent<SpringPosition>();
			if (component2 != null)
			{
				component2.enabled = false;
			}
			Transform transform = powerup2Button.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+48]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)powerup2PositionOff;
			transform.position = vector;
			ResetHeadstartButtonGlowColor();
		}
		else
		{
			GameObject go = powerup2Button.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SlideinPowerupHelper)+48]");
			_ = 0;
			_ = powerup2PositionOff;
			Vector3 pos = vector + 16;
			SpringPosition springPosition = SpringPosition.Begin(go, pos, 10f);
			SpringPosition.OnFinished onFinished = default;
			onFinished._002Ector(this, (nint)__ldftn(SlideinPowerupHelper.OnPowerup2ButtonAnimatedOut));
			Delegate obj2 = Delegate.Combine(springPosition.onFinished, onFinished);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			SpringPosition.OnFinished onFinished2 = default;
			springPosition.onFinished = onFinished2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
	}

	private void OnPowerup1ButtonAnimatedOut()
	{
		ResetScoreboosterButtonGlowColor();
	}

	private void OnPowerup2ButtonAnimatedOut()
	{
		ResetHeadstartButtonGlowColor();
	}

	private void OnPowerupButtonAnimatedIn()
	{
		if (_currentHeadstartGear != 0 || _currentScoreboosterGear != 0)
		{
			StopCoroutine("AnimateButtonBackground");
		}
		if (~(_initialButtonGlowHasStarted ? 1u : 0u) != 0)
		{
			Coroutine coroutine = StartCoroutine("AnimateButtonBackground");
			_initialButtonGlowHasStarted = true;
		}
	}

	private IEnumerator AnimateButtonBackground()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public bool ScoreboosterButtonIsActive()
	{
		Collider component = powerup1Button.GetComponent<Collider>();
		return component.enabled;
	}

	public bool HeadstartButtonIsActive()
	{
		Collider component = powerup2Button.GetComponent<Collider>();
		return component.enabled;
	}

	private IEnumerator AnimateButtonBackgrounGlow(Image sprite)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateSpriteColor(Image spriteToAnimate, Color32 startValue, Color32 endValue, float speedFactor)
	{
		_ = 0;
		_ = startValue.rgba;
		_ = endValue.rgba;
		IEnumerator result = default;
		return result;
	}

	private unsafe void UpdateAmountLabel(TMP_Text amount_lable, TMP_Text buy_lable, int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected I4, but got Unknown
		//IL_0073: Expected I, but got Obj
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00cc: Expected I, but got Obj
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (amount > 0 || !SellConsumablesHelper.allowSellConsumablesDuringRun)
		{
			amount_lable.enabled = true;
			buy_lable.enabled = false;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			nint num2 = (nint)amount_lable;
			object obj3 = amount_lable + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else
		{
			amount_lable.enabled = false;
			buy_lable.enabled = true;
			string text2 = Strings.Get(StringID.CONSUMABLES_OWNED_AMOUNT_NONE);
			nint num3 = (nint)buy_lable;
			object obj4 = buy_lable + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S2_v14 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
	}

	private void ResetScoreboosterGear()
	{
		_currentScoreboosterGear = 0;
	}

	private void ResetHeadstartGear()
	{
		_currentHeadstartGear = 0;
	}

	private void LogPowerupActivated(int powerup, bool success)
	{
		//IL_0036: Expected Obj, but got I4
		object obj = powerup - 1;
		if ((powerup != 1 && (nint)obj != 1) || success)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Warning: 'this' local not found (operand: L0)");
		/*Error: End of method reached without returning.*/;
	}

	private void SellConsumablesHelper_OnPurchaseEnded(PowerupType powerupType, int amountSold)
	{
		if (amountSold == 0)
		{
			switch (powerupType)
			{
			case PowerupType.scorebooster:
				HidePowerup1(instant: true);
				break;
			case PowerupType.headstart2000:
				HidePowerup2(instant: true);
				break;
			}
		}
		IngameScreen.instance__BackingField.RestartHidingScoreboosterSpeedometer(5f);
	}

	private void OnJetpackStart(bool isHeadStart)
	{
		if (!isHeadStart)
		{
			HidePowerup2();
		}
	}

	private void OnPogostickStart()
	{
		HidePowerup2();
	}

	public SlideinPowerupHelper()
	{
		//IL_000f: Expected VT, but got I8
		//IL_001e: Expected VT, but got I8
		_ = 3269591040L;
		_ = -4416736447839600640L;
		_ = 3269591040L;
		_ = 4806635589015175168L;
		base._002Ector();
	}
}
