using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Subway;
using UnityEngine;
using UnityEngine.UI;

public class SlideinPowerupButton : UIButtonSender
{
	public enum SlideInButtonType
	{
		scorebooster,
		headstart
	}

	private sealed class _003CAnimateSpriteColor_003Ed__18(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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

	private SlideinPowerupHelper _helper;

	private int _powerupNumber = -1;

	private Image _headstartModel;

	private Image _background;

	private int _counter;

	private const float FADE_OUT_ANIMATION_SPEED_FACTOR = 2f;

	public bool active;

	private SlideInButtonType buttonType;

	public void InitSlideinButton(SlideinPowerupHelper helper, int powerupNumber)
	{
		_helper = helper;
		_counter = 0;
		_powerupNumber = powerupNumber;
	}

	private void OnDisable()
	{
		ResetPowerupButtonColorToInitial();
	}

	protected override void Send(bool isPressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 128;
		if (_powerupNumber == -1)
		{
			string text = name;
			string text2 = text + " was used without being initialized";
			return;
		}
		if (isPressed)
		{
			_ = 1053345993;
			_ = 1053345993;
			_ = 4524086592360990921L;
			_ = 4524086592360990921L;
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			_ = 4565766963992723456L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			_ = 0;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
		else
		{
			_ = 1065353216;
			_ = 1065353216;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			object obj4 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			_ = 4539769715928596480L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			_ = 0;
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
		int counter = _counter;
		if ((_counter & 1) != 0)
		{
			_helper.SlideinPowerupClicked(_powerupNumber);
			counter = _counter;
		}
		int counter2 = counter + 1;
		_counter = counter2;
	}

	protected override void Send()
	{
		//IL_0042: Expected VT, but got Obj
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_ = 1;
		if (_powerupNumber == -1)
		{
			string text = name;
			string text2 = text + " was used without being initialized";
		}
		else
		{
			_helper.SlideinPowerupClicked(_powerupNumber);
		}
	}

	private void Update()
	{
		//IL_00cd: Expected I, but got Obj
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		if (~(active ? 1u : 0u) != 0)
		{
			return;
		}
		KeyCode keyCode;
		KeyCode key;
		if (buttonType != SlideInButtonType.scorebooster)
		{
			if (buttonType != SlideInButtonType.headstart)
			{
				return;
			}
			bool keyDown = Input.GetKeyDown(KeyCode.X);
			bool flag = !keyDown;
			keyCode = KeyCode.X;
			key = KeyCode.X;
			if (!flag)
			{
				goto IL_00c8;
			}
		}
		else
		{
			bool keyDown2 = Input.GetKeyDown(KeyCode.Z);
			keyCode = KeyCode.Z;
			if (keyDown2)
			{
				goto IL_00c8;
			}
			key = KeyCode.Z;
		}
		goto IL_00f0;
		IL_00f0:
		bool keyUp = Input.GetKeyUp(key);
		return;
		IL_00c8:
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S1_v6 (Il2CppClass<SlideinPowerupButton>)+EC] (should have been resolved before IL gen)");
		key = keyCode;
		goto IL_00f0;
	}

	public void OnPressButton()
	{
		Game instance = Game.Instance;
		if (instance._isPaused)
		{
			return;
		}
		if (buttonType != SlideInButtonType.scorebooster)
		{
			if (buttonType == SlideInButtonType.headstart)
			{
				SetPowerup2Color(animateIn: true);
			}
		}
		else
		{
			SetPowerup1Color(animateIn: true);
		}
	}

	public void OnReleaseButton()
	{
		Game instance = Game.Instance;
		if (instance._isPaused)
		{
			return;
		}
		if (buttonType != SlideInButtonType.scorebooster)
		{
			if (buttonType == SlideInButtonType.headstart)
			{
				SetPowerup2Color(animateIn: false);
			}
		}
		else
		{
			SetPowerup1Color(animateIn: false);
		}
	}

	private void SetPowerup2Color(bool animateIn)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0132: Expected I4, but got VT
		//IL_0140: Expected I4, but got VT
		//IL_014e: Expected Obj, but got VT
		//IL_015c: Expected Obj, but got VT
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected VT, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected VT, but got Unknown
		//IL_003b: Expected Obj, but got VT
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got VT
		//IL_0097: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got VT
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		object obj = default;
		SlideinPowerupButton slideinPowerupButton = (SlideinPowerupButton)(obj + -64);
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			if (animateIn)
			{
				object obj2 = GlobalColors.ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR >> 16;
				object obj3 = obj2 & 0xFF;
				float num = (float)obj3 / 255f;
				object obj4 = GlobalColors.ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR >> 24;
				float num2 = (float)obj4 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SlideinPowerupButton)+38]");
				slideinPowerupButton._helper = (SlideinPowerupHelper)0;
				object obj5 = GlobalColors.ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR & 0xFF;
				float num3 = (float)obj5 / 255f;
				object obj6 = GlobalColors.ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR >> 8;
				object obj7 = obj6 & 0xFF;
				float num4 = (float)obj7 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SlideinPowerupButton)+30]");
				((UnityEngine.Object)slideinPowerupButton).m_CachedPtr = (IntPtr)0;
				object obj8 = slideinPowerupButton + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			else
			{
				slideinPowerupButton._counter = (int)GlobalColors.INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;
				slideinPowerupButton.buttonType = (SlideInButtonType)GlobalColors.ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;
				slideinPowerupButton._background = (Image)GlobalColors.ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;
				slideinPowerupButton._headstartModel = (Image)GlobalColors.INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;
				Color32 startValue = (Color32)(slideinPowerupButton + 28);
				Color32 endValue = (Color32)(slideinPowerupButton + 24);
				IEnumerator routine = slideinPowerupButton.AnimateSpriteColor(_background, startValue, endValue, 2f);
				Coroutine coroutine = StartCoroutine(routine);
			}
		}
	}

	private void SetPowerup1Color(bool animateIn)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0132: Expected I4, but got VT
		//IL_0140: Expected I4, but got VT
		//IL_014e: Expected Obj, but got VT
		//IL_015c: Expected Obj, but got VT
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected VT, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected VT, but got Unknown
		//IL_003b: Expected Obj, but got VT
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got VT
		//IL_0097: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got VT
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		object obj = default;
		SlideinPowerupButton slideinPowerupButton = (SlideinPowerupButton)(obj + -64);
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			if (animateIn)
			{
				object obj2 = GlobalColors.ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR >> 16;
				object obj3 = obj2 & 0xFF;
				float num = (float)obj3 / 255f;
				object obj4 = GlobalColors.ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR >> 24;
				float num2 = (float)obj4 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SlideinPowerupButton)+38]");
				slideinPowerupButton._helper = (SlideinPowerupHelper)0;
				object obj5 = GlobalColors.ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR & 0xFF;
				float num3 = (float)obj5 / 255f;
				object obj6 = GlobalColors.ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR >> 8;
				object obj7 = obj6 & 0xFF;
				float num4 = (float)obj7 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SlideinPowerupButton)+30]");
				((UnityEngine.Object)slideinPowerupButton).m_CachedPtr = (IntPtr)0;
				object obj8 = slideinPowerupButton + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			else
			{
				slideinPowerupButton._counter = (int)GlobalColors.INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;
				slideinPowerupButton.buttonType = (SlideInButtonType)GlobalColors.ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;
				slideinPowerupButton._background = (Image)GlobalColors.ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;
				slideinPowerupButton._headstartModel = (Image)GlobalColors.INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;
				Color32 startValue = (Color32)(slideinPowerupButton + 28);
				Color32 endValue = (Color32)(slideinPowerupButton + 24);
				IEnumerator routine = slideinPowerupButton.AnimateSpriteColor(_background, startValue, endValue, 2f);
				Coroutine coroutine = StartCoroutine(routine);
			}
		}
	}

	private IEnumerator AnimateSpriteColor(Image spriteToAnimate, Color32 startValue, Color32 endValue, float speedFactor)
	{
		_ = 0;
		_ = startValue.rgba;
		_ = endValue.rgba;
		IEnumerator result = default;
		return result;
	}

	public void ResetPowerupButtonColorToInitial()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got VT
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got VT
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got VT
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I
		//IL_0123: Expected Obj, but got VT
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got VT
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01aa: Expected Obj, but got VT
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		if (buttonType != SlideInButtonType.scorebooster)
		{
			if (buttonType == SlideInButtonType.headstart)
			{
				object obj3 = GlobalColors.INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR >> 16;
				object obj4 = obj3 & 0xFF;
				float num = (float)obj4 / 255f;
				object obj5 = GlobalColors.INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR >> 24;
				float num2 = (float)obj5 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				object obj6 = GlobalColors.INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR & 0xFF;
				float num3 = (float)obj6 / 255f;
				object obj7 = GlobalColors.INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR >> 8;
				object obj8 = obj7 & 0xFF;
				float num4 = (float)obj8 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				object obj9 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
		}
		else
		{
			object obj10 = GlobalColors.INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR >> 16;
			object obj11 = obj10 & 0xFF;
			float num5 = (float)obj11 / 255f;
			object obj12 = GlobalColors.INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR >> 24;
			float num6 = (float)obj12 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			object obj13 = GlobalColors.INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR & 0xFF;
			float num7 = (float)obj13 / 255f;
			object obj14 = GlobalColors.INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR >> 8;
			object obj15 = obj14 & 0xFF;
			float num8 = (float)obj15 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
	}
}
