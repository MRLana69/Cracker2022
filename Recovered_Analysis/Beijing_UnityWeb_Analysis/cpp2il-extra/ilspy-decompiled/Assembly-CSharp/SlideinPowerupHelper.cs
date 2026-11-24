using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using UI;
using UnityEngine;

public class SlideinPowerupHelper : MonoBehaviour
{
	private enum SlideinPowerup
	{
		_notset,
		powerup1,
		powerup2
	}

	private sealed class _003CDelayResumeButtonsGlow_003Ed__58(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SlideinPowerupHelper _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected Obj, but got Unknown
				//IL_006b: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this.ShowPowerup1();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 1.5f;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
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

	private sealed class _003CAnimateButtonBackground_003Ed__69(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SlideinPowerupHelper _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Expected Obj, but got Unknown
				//IL_0149: Expected Obj, but got I4
				//IL_02db: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e0: Expected Obj, but got Unknown
				//IL_0457: Unknown result type (might be due to invalid IL or missing references)
				//IL_045c: Expected Obj, but got Unknown
				//IL_0478: Expected Obj, but got I4
				//IL_032c: Expected Obj, but got I4
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0164: Expected Obj, but got Unknown
				//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f0: Expected Obj, but got Unknown
				//IL_01b0: Expected Obj, but got I4
				//IL_043c: Expected Obj, but got I4
				//IL_0397: Unknown result type (might be due to invalid IL or missing references)
				//IL_039c: Expected Obj, but got Unknown
				//IL_03b8: Expected Obj, but got I4
				//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fb: Expected Obj, but got Unknown
				//IL_0217: Expected Obj, but got I4
				//IL_022d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Expected Obj, but got Unknown
				//IL_027e: Expected Obj, but got I4
				SlideinPowerupHelper slideinPowerupHelper = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.1f;
						object obj = this + 12;
						object obj2 = default;
						obj = obj2;
						_003C_003E1__state = 2;
						return 1;
					}
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						object obj3 = this + 12;
						Outfit[] routine = ((UICharacterThemeShifter)(object)_003C_003E4__this).SortThemes((List<Outfit>)(object)slideinPowerupHelper._powerup1ButtonGlow);
						Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)routine);
						obj3 = coroutine;
						_003C_003E1__state = 3;
						return 1;
					}
					if (_003C_003E1__state == 3)
					{
						_003C_003E1__state = -1;
						goto IL_0331;
					}
					if (_003C_003E1__state == 4)
					{
						_003C_003E1__state = -1;
						goto IL_03bd;
					}
					if (_003C_003E1__state == 5)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.1f;
						object obj4 = this + 12;
						object obj5 = default;
						obj4 = obj5;
						_003C_003E1__state = 6;
						return 1;
					}
					if (_003C_003E1__state == 6)
					{
						_003C_003E1__state = -1;
						object obj6 = this + 12;
						Outfit[] routine2 = ((UICharacterThemeShifter)(object)_003C_003E4__this).SortThemes((List<Outfit>)(object)slideinPowerupHelper._powerup2ButtonGlow);
						Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)routine2);
						obj6 = coroutine2;
						_003C_003E1__state = 7;
						return 1;
					}
					if (_003C_003E1__state == 7)
					{
						_003C_003E1__state = -1;
						goto IL_0441;
					}
					if (_003C_003E1__state != 8)
					{
						return null;
					}
				}
				_003C_003E1__state = -1;
				if (_003C_003E4__this.HeadstartButtonIsActive())
				{
					object obj7 = this + 12;
					Outfit[] routine3 = ((UICharacterThemeShifter)(object)_003C_003E4__this).SortThemes((List<Outfit>)(object)slideinPowerupHelper._powerup1ButtonGlow);
					Coroutine coroutine3 = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)routine3);
					obj7 = coroutine3;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_0331;
				IL_0331:
				if (_003C_003E4__this.HeadstartButtonIsActive() && ((SuperMysteryBoxEffect)(object)_003C_003E4__this).isRendering)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 0.5f;
					object obj8 = this + 12;
					object obj9 = default;
					obj8 = obj9;
					_003C_003E1__state = 4;
					return 1;
				}
				goto IL_03bd;
				IL_0441:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 1.4f;
				object obj10 = this + 12;
				object obj11 = default;
				obj10 = obj11;
				_003C_003E1__state = 8;
				return 1;
				IL_03bd:
				if (((SuperMysteryBoxEffect)(object)_003C_003E4__this).isRendering)
				{
					object obj12 = this + 12;
					Outfit[] routine4 = ((UICharacterThemeShifter)(object)_003C_003E4__this).SortThemes((List<Outfit>)(object)slideinPowerupHelper._powerup2ButtonGlow);
					Coroutine coroutine4 = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)routine4);
					obj12 = coroutine4;
					_003C_003E1__state = 5;
					return 1;
				}
				goto IL_0441;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
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

	private sealed class _003CAnimateButtonBackgrounGlow_003Ed__72(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SlideinPowerupHelper _003C_003E4__this;

		public UISprite sprite;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_016e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0173: Expected VT, but got Unknown
				//IL_017c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0181: Expected VT, but got Unknown
				//IL_018a: Unknown result type (might be due to invalid IL or missing references)
				//IL_018f: Expected Obj, but got Unknown
				//IL_0198: Unknown result type (might be due to invalid IL or missing references)
				//IL_019d: Expected Obj, but got Unknown
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ab: Expected Obj, but got Unknown
				//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Expected Obj, but got Unknown
				//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Expected Obj, but got Unknown
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_01ef: Expected Obj, but got VT
				//IL_01f8: Expected Obj, but got VT
				//IL_0215: Expected F4, but got Obj
				//IL_0210: Expected native int or pointer, but got VT
				//IL_0222: Expected F4, but got Obj
				//IL_021d: Expected native int or pointer, but got VT
				//IL_0228: Unknown result type (might be due to invalid IL or missing references)
				//IL_022d: Expected Obj, but got Unknown
				//IL_0279: Expected Obj, but got I4
				//IL_0083: Expected I, but got Obj
				//IL_00db: Expected I, but got Obj
				//IL_00f1: Expected Obj, but got I
				//IL_028c: Expected Obj, but got VT
				//IL_0295: Expected Obj, but got VT
				//IL_02b2: Expected F4, but got Obj
				//IL_02ad: Expected native int or pointer, but got VT
				//IL_02bf: Expected F4, but got Obj
				//IL_02ba: Expected native int or pointer, but got VT
				//IL_011c: Expected I, but got Obj
				object obj = default;
				Color color = (Color)(obj + 28);
				Color color2 = (Color)(obj + 24);
				object obj2 = obj + 20;
				object obj3 = obj + 8;
				object obj4 = obj + 16;
				object obj5 = obj + 12;
				object obj6 = obj + 4;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v55 (Il2CppClass<GlobalColors>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num2 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v68 (Il2CppClass<GlobalColors>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj2 = GlobalColors.FINAL_HEADSTART_BUTTON_GLOW_COLOR;
						obj3 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
						obj6 = obj2;
						obj = obj3;
						((Color*)(nint)color2)->r = (float)obj6;
						((Color*)(nint)color)->r = (float)obj;
						IEnumerator routine = ((AwardCellHelper)null).AnimateEffectColor(sprite, color2, color, 5f);
						Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto(routine);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				nint num3 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v31 (Il2CppClass<GlobalColors>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v45 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
				obj3 = GlobalColors.FINAL_HEADSTART_BUTTON_GLOW_COLOR;
				obj4 = obj2;
				obj5 = obj3;
				((Color*)(nint)color2)->r = (float)obj4;
				((Color*)(nint)color)->r = (float)obj5;
				object obj9 = this + 12;
				IEnumerator routine2 = ((AwardCellHelper)null).AnimateEffectColor(sprite, color2, color, 5f);
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto(routine2);
				obj9 = coroutine2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
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

	private sealed class _003CAnimateSpriteColor_003Ed__73(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float speedFactor;

		public UISprite spriteToAnimate;

		public Color32 startValue;

		public Color32 endValue;

		private float _003CanimationLerpFactor_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected VT, but got Unknown
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected I4, but got Unknown
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Expected Obj, but got Unknown
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0046: Expected Obj, but got Unknown
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Expected Obj, but got Unknown
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected Obj, but got Unknown
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Expected Obj, but got Unknown
				//IL_0151: Expected Obj, but got VT
				//IL_0166: Expected F4, but got Obj
				//IL_0161: Expected native int or pointer, but got VT
				//IL_0182: Expected Obj, but got VT
				//IL_0197: Expected F4, but got Obj
				//IL_0192: Expected native int or pointer, but got VT
				//IL_01b1: Expected I4, but got Obj
				//IL_01cb: Expected F4, but got Obj
				//IL_01c6: Expected native int or pointer, but got VT
				//IL_01e0: Expected F4, but got I
				//IL_01db: Expected native int or pointer, but got VT
				//IL_01f7: Expected I4, but got VT
				//IL_01f7: Expected Ref, but got VT
				//IL_0209: Expected native int or pointer, but got VT
				//IL_021b: Expected native int or pointer, but got VT
				//IL_022f: Expected I4, but got VT
				//IL_0235: Unknown result type (might be due to invalid IL or missing references)
				//IL_023a: Expected Obj, but got Unknown
				//IL_0243: Expected Obj, but got I4
				//IL_0257: Expected Obj, but got I4
				Matrix4x4 matrix4x2 = default;
				Matrix4x4 matrix4x = (Matrix4x4)(matrix4x2 + 80);
				int num = matrix4x2 - -64;
				object obj = matrix4x2 + 56;
				object obj2 = matrix4x2 + 40;
				object obj3 = matrix4x2 + 60;
				object obj4 = matrix4x2 + 32;
				object obj5 = matrix4x2 + 16;
				object obj6 = matrix4x2 + 36;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003CanimationLerpFactor_003E5__2 = 0f;
				}
				if (_003CanimationLerpFactor_003E5__2 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime * speedFactor;
					float num3 = _003CanimationLerpFactor_003E5__2 + num2;
					_003CanimationLerpFactor_003E5__2 = num3;
					obj = startValue;
					obj3 = obj;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
					Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
					obj4 = endValue;
					obj6 = obj4;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
					Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
					((int*)num)->m_value = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
					_ = 0;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					((Matrix4x4*)matrix4x2)->set_Item(num, (int)matrix4x, _003CanimationLerpFactor_003E5__2);
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
					spriteToAnimate.rawPivot = (UIWidget.Pivot)matrix4x;
					object obj7 = this + 12;
					obj7 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
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

	private SlideinPowerupButton powerup1Button;

	private SlideinPowerupButton powerup2Button;

	private UILabel powerup1AmountLabel;

	private UILabel powerup2AmountLabel;

	private UISprite _powerup1ButtonGlow;

	private UISprite _powerup2ButtonGlow;

	private SpringPosition powerup1Spring;

	private SpringPosition powerup2Spring;

	private Vector3 powerup1PositionOff;

	private Vector3 powerup2PositionOff;

	private Vector3 powerup1PositionOn;

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

	private static Action m_OnButtonsShow;

	private static Action m_OnButtonsHide;

	public float DELAY_AMOUNT_FOR_HIDING_THE_POWERUP_BUTTONS
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)_powerup1ButtonGlow;
		}
	}

	public static SlideinPowerupHelper Instance
	{
		get
		{
			bool flag = PurchaseHandler._instance == null;
			bool flag2 = !flag;
			SlideinPowerupHelper result = (SlideinPowerupHelper)(object)PurchaseHandler._instance;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				SlideinPowerupHelper slideinPowerupHelper = default;
				PurchaseHandler._instance = (PurchaseHandler)(object)slideinPowerupHelper;
				result = slideinPowerupHelper;
			}
			return result;
		}
	}

	public static event Action<int> OnHeadstartActivated
	{
		add
		{
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SlideinPowerupHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SlideinPowerupHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SlideinPowerupHelper.m_OnHeadstartActivated;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SlideinPowerupHelper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SlideinPowerupHelper);
				if (!flag)
				{
					nint num5 = (nint)typeof(SlideinPowerupHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SlideinPowerupHelper>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SlideinPowerupHelper);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SlideinPowerupHelper);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SlideinPowerupHelper>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<int> OnScoreBoostActivated
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SlideinPowerupHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SlideinPowerupHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SlideinPowerupHelper.m_OnHeadstartActivated;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SlideinPowerupHelper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SlideinPowerupHelper);
				if (!flag)
				{
					nint num5 = (nint)typeof(SlideinPowerupHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SlideinPowerupHelper>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SlideinPowerupHelper);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SlideinPowerupHelper);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SlideinPowerupHelper>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SlideinPowerupHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SlideinPowerupHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SlideinPowerupHelper.m_OnScoreBoostActivated;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SlideinPowerupHelper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SlideinPowerupHelper);
				if (!flag)
				{
					nint num5 = (nint)typeof(SlideinPowerupHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SlideinPowerupHelper>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SlideinPowerupHelper);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SlideinPowerupHelper);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SlideinPowerupHelper>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnButtonsShow
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SlideinPowerupHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SlideinPowerupHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SlideinPowerupHelper.m_OnScoreBoostActivated;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SlideinPowerupHelper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SlideinPowerupHelper);
				if (!flag)
				{
					nint num5 = (nint)typeof(SlideinPowerupHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SlideinPowerupHelper>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SlideinPowerupHelper);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SlideinPowerupHelper);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SlideinPowerupHelper>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SlideinPowerupHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SlideinPowerupHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SlideinPowerupHelper.m_OnButtonsShow;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SlideinPowerupHelper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SlideinPowerupHelper);
				if (!flag)
				{
					nint num5 = (nint)typeof(SlideinPowerupHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SlideinPowerupHelper>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SlideinPowerupHelper);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SlideinPowerupHelper);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SlideinPowerupHelper>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnButtonsHide
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SlideinPowerupHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SlideinPowerupHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SlideinPowerupHelper.m_OnButtonsShow;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SlideinPowerupHelper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SlideinPowerupHelper);
				if (!flag)
				{
					nint num5 = (nint)typeof(SlideinPowerupHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SlideinPowerupHelper>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SlideinPowerupHelper);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SlideinPowerupHelper);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SlideinPowerupHelper>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SlideinPowerupHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SlideinPowerupHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SlideinPowerupHelper.m_OnButtonsHide;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SlideinPowerupHelper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SlideinPowerupHelper);
				if (!flag)
				{
					nint num5 = (nint)typeof(SlideinPowerupHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SlideinPowerupHelper>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SlideinPowerupHelper);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SlideinPowerupHelper);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SlideinPowerupHelper>)+5C]");
				object obj5 = (nint)0 + (nint)16;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	private void Start()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = SlideinPowerupHelper.m_OnButtonsHide;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SlideinPowerupHelper>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(SlideinPowerupHelper);
			if (!flag)
			{
				nint num5 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SlideinPowerupHelper>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(SlideinPowerupHelper);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(SlideinPowerupHelper);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SlideinPowerupHelper>)+5C]");
			object obj5 = (nint)0 + (nint)16;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private unsafe void OnEnable()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_005d: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_009e: Expected I, but got Obj
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			OnGameReviveOffer();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(SlideinPowerupHelper.OnGameRevived);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v38 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameRevived -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(SlideinPowerupHelper.OnMenuScreenShown);
		object obj3 = action2 + 16;
		obj3 = this;
		Game.OnMenuScreenShown -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<UpgradeType, int> action3 = default;
		object obj4 = action3 + 16;
		obj4 = this;
		SellConsumable.completed -= action3;
	}

	private unsafe void OnDisable()
	{
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02bb: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I
		//IL_0305: Expected I, but got Obj
		//IL_031b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_00ad: Expected I, but got Obj
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		_initialButtonGlowHasStarted = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v70 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnChangedScreen -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(SlideinPowerupHelper.OnGameReviveOffer);
		object obj3 = action2 + 16;
		obj3 = this;
		nint num4 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v66 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameReviveOffer -= action2;
		nint num6 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v34 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v62 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj6 = default;
		obj6.method_ptr = method_ptr2;
		obj6.method = (nint)__ldftn(SlideinPowerupHelper.OnJetpackStart);
		object obj7 = obj6 + 16;
		obj7 = this;
		object obj8 = ex + 28;
		Delegate obj9 = ((Delegate)((Exception)ex)._stackTrace).CombineImpl(obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj10 = default;
		obj8 = obj10;
		bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex2 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Delegate obj11 = default;
		obj11.method_ptr = method_ptr3;
		obj11.method = (nint)__ldftn(SlideinPowerupHelper.OnPogostickStart);
		object obj12 = obj11 + 16;
		obj12 = this;
		object obj13 = ex2 + 36;
		Delegate obj14 = ((Delegate)(object)((Exception)ex2)._remoteStackTraceString).CombineImpl(obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj15 = default;
		obj13 = obj15;
	}

	private unsafe void ScreenDidChange(string screenOrPopupName)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected VT, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected VT, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_0200: Expected Obj, but got VT
		//IL_0209: Expected Obj, but got VT
		//IL_0226: Expected I4, but got Obj
		//IL_0221: Expected native int or pointer, but got VT
		//IL_0233: Expected F4, but got Obj
		//IL_022e: Expected native int or pointer, but got VT
		//IL_00a8: Expected I, but got Obj
		//IL_019a: Expected I4, but got VT
		//IL_0195: Expected native int or pointer, but got VT
		//IL_01a7: Expected Obj, but got I4
		//IL_01b4: Expected F4, but got Obj
		//IL_01af: Expected native int or pointer, but got VT
		//IL_01ce: Expected F4, but got Obj
		//IL_01c9: Expected native int or pointer, but got VT
		//IL_01e3: Expected F4, but got I
		//IL_01de: Expected native int or pointer, but got VT
		//IL_01f2: Expected I4, but got VT
		//IL_0037: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 40);
		Color32 color = (Color32)(obj + 32);
		object obj2 = obj + 8;
		object obj3 = obj + 28;
		object obj4 = obj + 24;
		object obj5 = obj + 4;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23 (Il2CppClass<GlobalColors>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag = obj6 == null;
		if (screenOrPopupName != null)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v57 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Color32*)(nint)color)->rgba = (int)GlobalColors.ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;
			obj3 = color.rgba;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_powerup1ButtonGlow.rawPivot = (UIWidget.Pivot)matrix4x;
			return;
		}
		if (!flag)
		{
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v41 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = GlobalColors.ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;
		obj = GlobalColors.INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;
		obj4 = obj2;
		obj5 = obj;
		((Color32*)(nint)color)->rgba = (int)obj4;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		IEnumerator routine = ((SlideinPowerupHelper)null).AnimateSpriteColor(_powerup1ButtonGlow, color, (Color32)matrix4x, 2f);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private unsafe void InitHelper()
	{
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0268: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02f1: Expected I, but got Obj
		//IL_0307: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v71 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnNavigatedToScreen += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(SlideinPowerupHelper.OnGameReviveOffer);
		object obj3 = action2 + 16;
		obj3 = this;
		nint num4 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v67 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameEnded += action2;
		ResetScoreboosterButtonGlowColor();
		ResetButtonGlowInvokes();
		nint num6 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v35 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v63 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj6 = default;
		obj6.method_ptr = method_ptr2;
		obj6.method = (nint)__ldftn(SlideinPowerupHelper.OnJetpackStart);
		object obj7 = obj6 + 16;
		obj7 = this;
		object obj8 = ex + 28;
		Delegate obj9 = ((Delegate)((Exception)ex)._stackTrace).RemoveImpl(obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj10 = default;
		obj8 = obj10;
		bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex2 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Delegate obj11 = default;
		obj11.method_ptr = method_ptr3;
		obj11.method = (nint)__ldftn(SlideinPowerupHelper.OnPogostickStart);
		object obj12 = obj11 + 16;
		obj12 = this;
		object obj13 = ex2 + 36;
		Delegate obj14 = ((Delegate)(object)((Exception)ex2)._remoteStackTraceString).RemoveImpl(obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj15 = default;
		obj13 = obj15;
	}

	private void OnPauseChange(bool pause)
	{
		//IL_001f: Expected Obj, but got I4
		if (string.Equals((string)pause, "SaveMePopup"))
		{
			OnJetpackStart();
		}
	}

	private void OnGameReviveOffer()
	{
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_010e: Expected I4, but got Obj
		//IL_0131: Expected I4, but got Obj
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0178: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02ec: Expected Obj, but got I4
		//IL_01b9: Expected I, but got Obj
		SlideinPowerupButton slideinPowerupButton = powerup1Button;
		object obj = powerup1Button + 16;
		obj = this;
		slideinPowerupButton._powerupNumber = 1;
		slideinPowerupButton._counter = 0;
		SlideinPowerupButton slideinPowerupButton2 = powerup2Button;
		object obj2 = powerup2Button + 16;
		obj2 = this;
		slideinPowerupButton2._powerupNumber = 2;
		slideinPowerupButton2._counter = 0;
		Collider component = powerup1Button.GetComponent<Collider>();
		component.isTrigger = false;
		Collider component2 = powerup2Button.GetComponent<Collider>();
		component2.isTrigger = false;
		GameObject gameObject = powerup1Button.gameObject;
		object obj4 = default;
		object obj3 = obj4 + 12;
		object obj5 = this + 44;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v5+8]");
		_ = 0;
		Transform transform = (Transform)(obj4 + 24);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v19+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject2 = powerup2Button.gameObject;
		object obj6 = this + 56;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S2_v16+8]");
		_ = 0;
		transform = (Transform)obj4;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform.eulerAngles;
		int tier = InventorySave.GetTier(UpgradeType.scorebooster);
		((SlideinPowerupHelper)null).LogPowerupActivated((int)powerup1AmountLabel, (byte)tier != 0);
		int tier2 = InventorySave.GetTier(UpgradeType.headstart2000);
		((SlideinPowerupHelper)null).LogPowerupActivated((int)powerup2AmountLabel, (byte)tier2 != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<UpgradeType, int> action = default;
		object obj7 = action + 16;
		obj7 = this;
		InventorySave.powerupsChanged -= action;
		nint num2 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v43 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v51 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<bool> action2 = default;
		object obj9 = action2 + 16;
		obj9 = this;
		((Game)isInstantiated).OnPauseChange -= action2;
		_hasInited = true;
	}

	private void OnGameRevived()
	{
		OnJetpackStart();
	}

	private void OnMenuScreenShown()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		_currentHeadstartGear = 0;
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v16 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		_ = 0;
		_ = 0;
		_ = 0;
	}

	private void OnDestroy()
	{
		OnJetpackStart();
		_currentScoreboosterGear = 0;
		_currentHeadstartGear = 0;
	}

	private void OnUpgradeUsed(UpgradeType upgradeType, int newAmount)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I4
		object obj = this + 16;
		obj = upgradeType;
		powerup1AmountLabel = (UILabel)newAmount;
		_powerup2ButtonGlow = null;
	}

	public unsafe void ShowPowerups()
	{
		//IL_0138: Expected Obj, but got I4
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		int num2 = default;
		object obj = num2 + 16;
		obj = this;
		InventorySave.SetKeys(num2);
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v46 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(SlideinPowerupHelper.OnPauseChange);
		object obj3 = action + 16;
		obj3 = this;
		((Game)isInstantiated).OnStageMenuSequence += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<bool> action2 = default;
		object obj4 = action2 + 16;
		obj4 = this;
		Game.OnPlayerDied += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(SlideinPowerupHelper.OnMenuScreenShown);
		object obj5 = action3 + 16;
		obj5 = this;
		Game.OnGameDestroyed += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<bool> action4 = default;
		object obj6 = action4 + 16;
		obj6 = this;
		Settings.onTopRunChallengerSettingChanged += action4;
	}

	private unsafe void HideScorebooster()
	{
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_0100: Expected I, but got Obj
		//IL_01c2: Expected I4, but got Obj
		//IL_01d2: Expected I4, but got Obj
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			OnGameReviveOffer();
		}
		ResetScoreboosterButtonGlowColor();
		ResetButtonGlowInvokes();
		_initialButtonGlowHasStarted = false;
		if (_currentScoreboosterGear < 3)
		{
			ShowPowerup2();
		}
		if (_currentHeadstartGear < 3)
		{
			FireHideEventIfNecessary();
		}
		StopCoroutine((IEnumerator)(object)"HideScorebooster");
		StopCoroutine((IEnumerator)(object)"HideHeadstart");
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v41 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(SlideinPowerupHelper.HideHeadstart);
		object obj3 = obj2 + 16;
		obj3 = this;
		object obj4 = ex + 132;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v29 (System.ArrayTypeMismatchException)+84]");
		Delegate obj5 = ((Delegate)0).CombineImpl(obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj4 = obj6;
		((RectTransform)(object)this).SetSizeWithCurrentAnchors((RectTransform.Axis)"HideScorebooster", 5f);
		((RectTransform)(object)this).SetSizeWithCurrentAnchors((RectTransform.Axis)"HideHeadstart", 5f);
	}

	private void HideHeadstart()
	{
		HidePowerup2();
	}

	private unsafe void ResetHeadstartButtonGlowColor()
	{
		//IL_00df: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(SlideinPowerupHelper.HideHeadstart);
		object obj3 = obj2 + 16;
		obj3 = this;
		object obj4 = ex + 132;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (System.ArrayTypeMismatchException)+84]");
		Delegate obj5 = ((Delegate)0).RemoveImpl(obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj4 = obj6;
		((SuperMysteryBoxEffect)this).isRendering = false;
	}

	private unsafe void ResetScoreboosterButtonGlowColor()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got VT
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected VT, but got Unknown
		//IL_00e6: Expected F4, but got Obj
		//IL_00e1: Expected native int or pointer, but got VT
		//IL_0100: Expected F4, but got Obj
		//IL_00fb: Expected native int or pointer, but got VT
		//IL_0115: Expected F4, but got I
		//IL_0110: Expected native int or pointer, but got VT
		//IL_0124: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		useGUILayout = (byte)(int)"AnimateButtonBackground" != 0;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (Il2CppClass<GlobalColors>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v20 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 20;
		obj2 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
		object obj4 = obj3 + 16;
		obj4 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_powerup2ButtonGlow.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private unsafe void ResetButtonGlowInvokes()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got VT
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected VT, but got Unknown
		//IL_00e6: Expected F4, but got Obj
		//IL_00e1: Expected native int or pointer, but got VT
		//IL_0100: Expected F4, but got Obj
		//IL_00fb: Expected native int or pointer, but got VT
		//IL_0115: Expected F4, but got I
		//IL_0110: Expected native int or pointer, but got VT
		//IL_0124: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		useGUILayout = (byte)(int)"AnimateButtonBackground" != 0;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (Il2CppClass<GlobalColors>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v20 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 20;
		obj2 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
		object obj4 = obj3 + 16;
		obj4 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_powerup1ButtonGlow.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private IEnumerator DelayResumeButtonsGlow()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void ResumeButtonsGlowColor()
	{
		//IL_0049: Expected I4, but got Obj
		useGUILayout = (byte)(int)"DelayResumeButtonsGlow" != 0;
		if (_currentScoreboosterGear <= 2 || _currentHeadstartGear < 3)
		{
			Coroutine coroutine = StartCoroutine((IEnumerator)(object)"DelayResumeButtonsGlow");
		}
	}

	public void SlideinPowerupClicked(int powerupAsInt)
	{
		if (powerupAsInt == 0)
		{
			ShowPowerup1();
		}
	}

	public unsafe void ShowPowerup1()
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected VT, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_0202: Expected Obj, but got VT
		//IL_0217: Expected F4, but got Obj
		//IL_0212: Expected native int or pointer, but got VT
		//IL_0231: Expected F4, but got Obj
		//IL_022c: Expected native int or pointer, but got VT
		//IL_0246: Expected F4, but got I
		//IL_0241: Expected native int or pointer, but got VT
		//IL_0255: Expected I4, but got VT
		//IL_025e: Expected Obj, but got VT
		//IL_0273: Expected F4, but got Obj
		//IL_026e: Expected native int or pointer, but got VT
		//IL_0142: Expected F4, but got Obj
		//IL_013d: Expected native int or pointer, but got VT
		//IL_0157: Expected F4, but got I
		//IL_0152: Expected native int or pointer, but got VT
		//IL_0166: Expected I4, but got VT
		//IL_00f6: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 48);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj + 44;
		object obj5 = obj + 16;
		object obj6 = obj + 20;
		Collider component = powerup2Button.GetComponent<Collider>();
		if (!component.isTrigger)
		{
			Collider component2 = powerup1Button.GetComponent<Collider>();
			if (!component2.isTrigger)
			{
				return;
			}
		}
		string text = tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 == null)
		{
			return;
		}
		string text3 = tag;
		if (!((GameObject)(object)text3).activeInHierarchy)
		{
			return;
		}
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v19 (Il2CppClass<GlobalColors>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v39 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
		obj4 = obj2;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_powerup2ButtonGlow.rawPivot = (UIWidget.Pivot)matrix4x;
		obj5 = GlobalColors.INITIAL_HEADSTART_BUTTON_GLOW_COLOR;
		obj6 = obj5;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_powerup1ButtonGlow.rawPivot = (UIWidget.Pivot)matrix4x;
		Coroutine coroutine = StartCoroutine((IEnumerator)(object)"AnimateButtonBackground");
	}

	public unsafe void ShowPowerup2()
	{
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01fc: Expected I, but got Obj
		//IL_0212: Expected Obj, but got I
		//IL_023d: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 24);
		object obj2 = obj + 12;
		powerup1Button._002Ector();
		int tier = InventorySave.GetTier(UpgradeType.scorebooster);
		if (tier < 1)
		{
			SellableConsumable activeConsumable = SellConsumable.activeConsumable;
			if (activeConsumable == null || !OnboardingSave.hasCollectedFromFriends)
			{
				return;
			}
		}
		GameObject gameObject = powerup1Button.gameObject;
		object obj3 = this + 44;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v3+8]");
		_ = 0;
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		string text = powerup1Button.tag;
		object obj4 = this + 68;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v17+8]");
		_ = 0;
		transform = (Transform)obj;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		object obj5 = this + 36;
		IEnumerator enumerator = ((SpawnPool)(object)text).DoDespawnAfterSeconds(transform, 10f);
		obj5 = enumerator;
		SpringPosition springPosition = powerup1Spring;
		springPosition.ignoreTimeScale = true;
		SpringPosition springPosition2 = powerup1Spring;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj6 = default;
		obj6.method_ptr = method_ptr;
		obj6.method = (nint)__ldftn(SlideinPowerupHelper.OnPowerupButtonAnimatedIn);
		object obj7 = obj6 + 16;
		obj7 = this;
		object obj8 = powerup1Spring + 32;
		Delegate obj9 = ((Delegate)springPosition2.onFinished).CombineImpl(obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj10 = default;
		obj8 = obj10;
		Collider component = powerup1Button.GetComponent<Collider>();
		component.isTrigger = true;
		OnboardingSave.hasCollectedFromFriends = true;
		nint num = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v50 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v57 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)SlideinPowerupHelper.m_OnButtonsShow);
	}

	public void HidePowerup1(bool instant = false)
	{
		//IL_0709: Expected I, but got Obj
		//IL_071f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_00f4: Expected I4, but got Obj
		//IL_03ee: Expected I4, but got Obj
		//IL_0278: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_02b9: Expected I, but got Obj
		//IL_0572: Expected I, but got Obj
		//IL_0588: Expected Obj, but got I
		//IL_01d9: Expected I, but got Obj
		//IL_0492: Expected I, but got Obj
		//IL_04a8: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I4
		//IL_0615: Expected I, but got Obj
		//IL_062b: Expected Obj, but got I
		//IL_05b3: Expected I, but got Obj
		//IL_082c: Expected Obj, but got I4
		//IL_04d3: Expected I, but got Obj
		//IL_06b6: Expected Obj, but got I4
		//IL_06b6: Expected Obj, but got I4
		//IL_06b6: Expected Obj, but got I4
		//IL_0656: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+C4]");
		if ((nint)0 != 0)
		{
			return;
		}
		object obj2 = (instant ? 1 : 0) - 1;
		int amountSold;
		if (!instant)
		{
			if ((nint)obj2 == 1)
			{
				Collider component = powerup2Button.GetComponent<Collider>();
				if (component.isTrigger)
				{
					StopCoroutine((IEnumerator)(object)"HideHeadstart");
					((RectTransform)(object)this).SetSizeWithCurrentAnchors((RectTransform.Axis)"HideHeadstart", 5f);
					ResetScoreboosterButtonGlowColor();
					ResumeButtonsGlowColor();
					int tier = InventorySave.GetTier(UpgradeType.headstart2000);
					if (tier < 1)
					{
						SellableConsumable activeConsumable = SellConsumable.activeConsumable;
						if (activeConsumable == null)
						{
							((SuperMysteryBoxEffect)this).isRendering = false;
							amountSold = 0;
						}
						else
						{
							nint num3 = (nint)typeof(SellableConsumable);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S2_v122 (Il2CppClass<Info.SellableConsumable>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							if (obj3 != null)
							{
								nint num4 = (nint)typeof(SellableConsumable);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S2_v130 (Il2CppClass<Info.SellableConsumable>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							SellConsumable.completed += (Action<UpgradeType, int>)(object)SellableConsumable.headstart;
							amountSold = 0;
						}
					}
					else
					{
						int currentHeadstartGear = _currentHeadstartGear + 1;
						_currentHeadstartGear = currentHeadstartGear;
						if (_currentHeadstartGear > 3)
						{
							amountSold = 0;
						}
						else
						{
							nint num5 = (nint)typeof(SlideinPowerupHelper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S2_v87 (Il2CppClass<SlideinPowerupHelper>)+BA]");
							object obj4 = (nint)0 & (nint)0x200;
							if (obj4 != null)
							{
								nint num6 = (nint)typeof(SlideinPowerupHelper);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S2_v111 (Il2CppClass<SlideinPowerupHelper>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (SlideinPowerupHelper.m_OnHeadstartActivated != null)
							{
								SlideinPowerupHelper.m_OnHeadstartActivated(_currentHeadstartGear);
							}
							nint num7 = (nint)typeof(Game);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S2_v96 (Il2CppClass<SYBO.Subway.Game>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num8 = (nint)typeof(Game);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v106 (Il2CppClass<SYBO.Subway.Game>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool isInstantiated2 = Game.IsInstantiated;
							((Game)isInstantiated2).Die();
							InventorySave.IncreaseTier(UpgradeType.headstart2000);
							StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
							((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)25, (PersistentAwardProgress)1, (Action<Award>)(-1));
							amountSold = 1;
						}
						if (_currentHeadstartGear >= 3)
						{
							((SuperMysteryBoxEffect)this).isRendering = false;
						}
					}
				}
				else
				{
					amountSold = 0;
				}
			}
			else
			{
				amountSold = 0;
			}
		}
		else
		{
			Collider component2 = powerup1Button.GetComponent<Collider>();
			if (component2.isTrigger)
			{
				StopCoroutine((IEnumerator)(object)"HideScorebooster");
				((RectTransform)(object)this).SetSizeWithCurrentAnchors((RectTransform.Axis)"HideScorebooster", 5f);
				ResetButtonGlowInvokes();
				ResumeButtonsGlowColor();
				int tier2 = InventorySave.GetTier(UpgradeType.scorebooster);
				if (tier2 < 1)
				{
					SellableConsumable activeConsumable2 = SellConsumable.activeConsumable;
					if (activeConsumable2 == null)
					{
						HidePowerup2();
						amountSold = 0;
					}
					else
					{
						nint num9 = (nint)typeof(SellableConsumable);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S2_v52 (Il2CppClass<Info.SellableConsumable>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num10 = (nint)typeof(SellableConsumable);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S2_v60 (Il2CppClass<Info.SellableConsumable>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						SellConsumable.completed += (Action<UpgradeType, int>)(object)SellableConsumable.scorebooster;
						amountSold = 0;
					}
				}
				else
				{
					int currentScoreboosterGear = _currentScoreboosterGear + 1;
					_currentScoreboosterGear = currentScoreboosterGear;
					if (_currentScoreboosterGear > 3)
					{
						amountSold = 0;
					}
					else
					{
						nint num11 = (nint)typeof(SlideinPowerupHelper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S2_v24 (Il2CppClass<SlideinPowerupHelper>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num12 = (nint)typeof(SlideinPowerupHelper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S2_v41 (Il2CppClass<SlideinPowerupHelper>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (SlideinPowerupHelper.m_OnScoreBoostActivated != null)
						{
							SlideinPowerupHelper.m_OnScoreBoostActivated(_currentScoreboosterGear);
						}
						string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
						_ = 1;
						string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
						((GameStats)(object)privacyPolicyUrl2).CalculateScore();
						InventorySave.IncreaseTier(UpgradeType.scorebooster);
						StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
						((OwnBoardsAward)(object)stayInOneLaneMission2)._002Ector((AwardStaticData)67, (PersistentAwardProgress)1, (Action<Award>)(-1));
						amountSold = 1;
					}
					if (_currentScoreboosterGear >= 3)
					{
						HidePowerup2();
					}
				}
			}
			else
			{
				amountSold = 0;
			}
		}
		((SlideinPowerupHelper)null).OnSellConsumableCompleted(instant ? UpgradeType.hoverboard : UpgradeType._notset, amountSold);
	}

	public unsafe void HidePowerup2(bool instant = false)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0215: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0095: Expected I, but got Obj
		Collider component = powerup1Button.GetComponent<Collider>();
		component.isTrigger = false;
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			OnGameReviveOffer();
		}
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		if (instant)
		{
			SpringPosition component2 = powerup1Button.GetComponent<SpringPosition>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				component2.tag = null;
			}
			GameObject gameObject = powerup1Button.gameObject;
			object obj3 = this + 44;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S2_v19+8]");
			_ = 0;
			transform = (Transform)obj;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform.localPosition;
			ResetButtonGlowInvokes();
		}
		else
		{
			string text = powerup1Button.tag;
			object obj4 = this + 44;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v4+8]");
			_ = 0;
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			IEnumerator enumerator = ((SpawnPool)(object)text).DoDespawnAfterSeconds(transform, 10f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Delegate obj5 = default;
			obj5.method_ptr = method_ptr;
			obj5.method = (nint)__ldftn(SlideinPowerupHelper.OnPowerup1ButtonAnimatedOut);
			object obj6 = obj5 + 16;
			obj6 = this;
			object obj7 = enumerator + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v25 (System.Collections.IEnumerator)+20]");
			Delegate obj8 = ((Delegate)0).CombineImpl(obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj9 = default;
			obj7 = obj9;
		}
		OnPowerup1ButtonAnimatedOut();
	}

	private unsafe void FireHideEventIfNecessary()
	{
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01fc: Expected I, but got Obj
		//IL_0212: Expected Obj, but got I
		//IL_023d: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 24);
		object obj2 = obj + 12;
		powerup2Button._002Ector();
		int tier = InventorySave.GetTier(UpgradeType.headstart2000);
		if (tier < 1)
		{
			SellableConsumable activeConsumable = SellConsumable.activeConsumable;
			if (activeConsumable == null || !OnboardingSave.allowSellScoreboosterDuringRun)
			{
				return;
			}
		}
		GameObject gameObject = powerup2Button.gameObject;
		object obj3 = this + 56;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v3+8]");
		_ = 0;
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		string text = powerup2Button.tag;
		object obj4 = this + 80;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v17+8]");
		_ = 0;
		transform = (Transform)obj;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		object obj5 = this + 40;
		IEnumerator enumerator = ((SpawnPool)(object)text).DoDespawnAfterSeconds(transform, 10f);
		obj5 = enumerator;
		SpringPosition springPosition = powerup2Spring;
		springPosition.ignoreTimeScale = true;
		SpringPosition springPosition2 = powerup2Spring;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj6 = default;
		obj6.method_ptr = method_ptr;
		obj6.method = (nint)__ldftn(SlideinPowerupHelper.OnPowerupButtonAnimatedIn);
		object obj7 = obj6 + 16;
		obj7 = this;
		object obj8 = powerup2Spring + 32;
		Delegate obj9 = ((Delegate)springPosition2.onFinished).CombineImpl(obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj10 = default;
		obj8 = obj10;
		Collider component = powerup2Button.GetComponent<Collider>();
		component.isTrigger = true;
		OnboardingSave.allowSellScoreboosterDuringRun = true;
		nint num = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v50 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v57 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)SlideinPowerupHelper.m_OnButtonsShow);
	}

	private void OnPowerup1ButtonAnimatedOut()
	{
		//IL_0058: Expected I, but got Obj
		//IL_006e: Expected Obj, but got I
		//IL_0099: Expected I, but got Obj
		Collider component = powerup2Button.GetComponent<Collider>();
		if (component.isTrigger)
		{
			return;
		}
		Collider component2 = powerup1Button.GetComponent<Collider>();
		if (component2.isTrigger)
		{
			return;
		}
		nint num = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v24 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)SlideinPowerupHelper.m_OnButtonsHide);
	}

	private void OnPowerup2ButtonAnimatedOut()
	{
		ResetButtonGlowInvokes();
	}

	private void OnPowerupButtonAnimatedIn()
	{
		ResetScoreboosterButtonGlowColor();
	}

	private IEnumerator AnimateButtonBackground()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public bool ScoreboosterButtonIsActive()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	public bool HeadstartButtonIsActive()
	{
		Collider component = powerup1Button.GetComponent<Collider>();
		return component.isTrigger;
	}

	private IEnumerator AnimateButtonBackgrounGlow(UISprite sprite)
	{
		//IL_0031: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		if ((nint)sprite == 2)
		{
			return (IEnumerator)1;
		}
		if ((nint)sprite == 5)
		{
			return (IEnumerator)2;
		}
		return null;
	}

	private IEnumerator AnimateSpriteColor(UISprite spriteToAnimate, Color32 startValue, Color32 endValue, float speedFactor)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = spriteToAnimate;
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = startValue.rgba;
		object obj4 = obj3 + 8;
		obj4 = obj2;
		obj3 = endValue.rgba;
		obj4 = obj3;
		return enumerator;
	}

	private void UpdateAmountLabel(UILabel label, int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0215: Expected I4, but got Obj
		//IL_019c: Expected I4, but got Obj
		object obj = label - 3;
		if ((nint)label != 3)
		{
			if ((nint)obj == 1 || (nint)obj == 2 || (nint)obj == 3 || (nint)obj == 4 || (nint)obj == 5 || (nint)obj == 6 || (nint)obj == 7 || (nint)obj == 8 || (nint)obj == 9 || (nint)obj == 10 || (nint)obj == 11 || (nint)obj != 12)
			{
				return;
			}
			((SlideinPowerupHelper)null).LogPowerupActivated((int)powerup1AmountLabel, (byte)amount != 0);
			if (amount == 0)
			{
				SellableConsumable activeConsumable = SellConsumable.activeConsumable;
				if (activeConsumable == null)
				{
					HidePowerup2();
				}
			}
			return;
		}
		((SlideinPowerupHelper)null).LogPowerupActivated((int)powerup2AmountLabel, (byte)amount != 0);
		if (amount == 0)
		{
			SellableConsumable activeConsumable2 = SellConsumable.activeConsumable;
			if (activeConsumable2 == null)
			{
				((SuperMysteryBoxEffect)this).isRendering = false;
			}
		}
	}

	private void ResetScoreboosterGear()
	{
		//IL_0025: Expected I4, but got Obj
		if (_currentHeadstartGear != 0 || _currentScoreboosterGear != 0)
		{
			useGUILayout = (byte)(int)"AnimateButtonBackground" != 0;
		}
		if (~(_initialButtonGlowHasStarted ? 1u : 0u) != 0)
		{
			Coroutine coroutine = StartCoroutine((IEnumerator)(object)"AnimateButtonBackground");
			_initialButtonGlowHasStarted = true;
		}
	}

	private void ResetHeadstartGear()
	{
		_currentScoreboosterGear = 0;
	}

	private void LogPowerupActivated(int powerup, bool success)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_004f: Expected I, but got Obj
		//IL_0065: Expected Obj, but got I
		//IL_013a: Expected I4, but got Obj
		//IL_013a: Expected Obj, but got I4
		//IL_0090: Expected I, but got Obj
		object obj = success;
		if ((success ? 1 : 0) < (true ? 1 : 0))
		{
			SellableConsumable activeConsumable = SellConsumable.activeConsumable;
			if (activeConsumable != null)
			{
				((UILabel)powerup).applyGradient = true;
				nint num = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v21 (Il2CppClass<Strings>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("CONSUMABLES_OWNED_AMOUNT_NONE");
				((UILabel)powerup).fontSize = (int)text;
				return;
			}
		}
		((UILabel)powerup).applyGradient = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		((UILabel)powerup).fontSize = fontSize;
	}

	private void OnSellConsumableCompleted(UpgradeType upgradeType, int amountSold)
	{
		//IL_0151: Expected Obj, but got I4
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_0076: Expected I, but got Obj
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_0104: Expected I, but got Obj
		object obj = upgradeType - 1;
		if (upgradeType != UpgradeType.hoverboard)
		{
			if ((nint)obj != 1)
			{
				return;
			}
			nint num = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v18 (Il2CppClass<Flurry>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return;
		}
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void HidePowerups()
	{
		_currentHeadstartGear = 0;
	}

	private void OnJetpackStart()
	{
		StopCoroutine((IEnumerator)(object)"HideScorebooster");
		StopCoroutine((IEnumerator)(object)"HideHeadstart");
		HidePowerup2();
		((SuperMysteryBoxEffect)this).isRendering = false;
	}

	private void OnPogostickStart()
	{
		((SuperMysteryBoxEffect)this).isRendering = false;
	}

	public SlideinPowerupHelper()
	{
		((SuperMysteryBoxEffect)this).isRendering = false;
	}

	static SlideinPowerupHelper()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got F4
		//IL_0045: Expected I, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0081: Expected VT, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got F4
		//IL_00ce: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got F4
		//IL_014e: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got F4
		//IL_01ce: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got F4
		//IL_024e: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02a5: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got F4
		//IL_02ce: Expected I, but got Obj
		//IL_02f9: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got F4
		//IL_034e: Expected I, but got Obj
		//IL_0379: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got F4
		//IL_03ce: Expected I, but got Obj
		//IL_03f9: Expected Obj, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got F4
		//IL_044e: Expected I, but got Obj
		//IL_0479: Expected Obj, but got I
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04a5: Expected Obj, but got I4
		//IL_04b4: Expected Obj, but got F4
		//IL_04ce: Expected I, but got Obj
		//IL_04f9: Expected Obj, but got I
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0525: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got F4
		//IL_054e: Expected I, but got Obj
		//IL_0579: Expected Obj, but got I
		//IL_0597: Expected Obj, but got I4
		//IL_05a6: Expected Obj, but got F4
		//IL_05c0: Expected I, but got Obj
		//IL_05eb: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 132;
		obj = 0;
		_ = 0;
		obj = -3f;
		_ = 5f;
		_ = 0f;
		nint num = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num2 = 0;
		object obj3 = obj2 + 144;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		SSEventsPopup.SPECIAL_POWER_BOARD_POSITION_OFFSET = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj4 = obj2 + 120;
		obj4 = 0;
		_ = 0;
		obj4 = 17.5f;
		_ = 124f;
		_ = -52.6f;
		nint num3 = (nint)typeof(SSEventsPopup);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj6 = obj2 + 108;
		obj6 = 0;
		_ = 0;
		obj6 = 8f;
		_ = 8f;
		_ = 8f;
		nint num4 = (nint)typeof(SSEventsPopup);
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v40 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj7 = (nint)0 + (nint)24;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj8 = obj2 + 96;
		obj8 = 0;
		_ = 0;
		obj8 = 0f;
		_ = -37f;
		_ = 0f;
		nint num5 = (nint)typeof(SSEventsPopup);
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v45+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v51 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj9 = (nint)0 + (nint)36;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj10 = obj2 + 84;
		obj10 = 0;
		_ = 0;
		obj10 = 13f;
		_ = -157f;
		_ = 3f;
		nint num6 = (nint)typeof(SSEventsPopup);
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v56+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v62 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj11 = (nint)0 + (nint)48;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj12 = obj2 + 72;
		obj12 = 0;
		_ = 0;
		obj12 = 8f;
		_ = 8f;
		_ = 8f;
		nint num7 = (nint)typeof(SSEventsPopup);
		obj3 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v67+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v73 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj13 = (nint)0 + (nint)60;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj14 = obj2 + 60;
		obj14 = 0;
		_ = 0;
		obj14 = -2f;
		_ = -37.5f;
		_ = 0f;
		nint num8 = (nint)typeof(SSEventsPopup);
		obj3 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v84 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj15 = (nint)0 + (nint)72;
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj16 = obj2 + 48;
		obj16 = 0;
		_ = 0;
		obj16 = 13f;
		_ = -157f;
		_ = 3f;
		nint num9 = (nint)typeof(SSEventsPopup);
		obj3 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v89+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v95 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj17 = (nint)0 + (nint)84;
		obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj18 = obj2 + 36;
		obj18 = 0;
		_ = 0;
		obj18 = 8f;
		_ = 8f;
		_ = 8f;
		nint num10 = (nint)typeof(SSEventsPopup);
		obj3 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v100+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v106 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj19 = (nint)0 + (nint)96;
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj20 = obj2 + 24;
		obj20 = 0;
		_ = 0;
		obj20 = 0f;
		_ = -35f;
		_ = 0f;
		nint num11 = (nint)typeof(SSEventsPopup);
		obj3 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v111+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v117 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj21 = (nint)0 + (nint)108;
		obj21 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj22 = obj2 + 12;
		obj22 = 0;
		_ = 0;
		obj22 = 10f;
		_ = 186f;
		_ = 0f;
		nint num12 = (nint)typeof(SSEventsPopup);
		obj3 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v122+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v128 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj23 = (nint)0 + (nint)120;
		obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 4.5f;
		_ = 4.5f;
		_ = 4.5f;
		nint num13 = (nint)typeof(SSEventsPopup);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v138 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj24 = (nint)0 + (nint)132;
		obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
	}
}
