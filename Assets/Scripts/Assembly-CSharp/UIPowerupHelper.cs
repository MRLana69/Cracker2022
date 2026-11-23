using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Characters.States;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPowerupHelper : MonoBehaviour
{
	private enum FadeTarget
	{
		white,
		green,
		darkgreen,
		none
	}

	private UISlider slider;

	private Image sliderBG;

	private Image icon;

	private Image iconBG;

	private TMP_Text amountLabel;

	private Image foreground;

	private GameObject container;

	private Color originalColor;

	private float sliderSteps;

	private bool _amountLabelRepositioned;

	private const float AMOUNT_LABEL_HIGH_RES_OFFSET = 0.5f;

	private const float COLOR_CHANGE_SPEED = 8.2343f;

	private IngameScreen _ingameScreen;

	private bool _inverse;

	private ActivePowerup _powerup;

	private Color32[] _colorTargets;

	private FadeTarget currentFadeTarget;

	private FadeTarget oldFadeTarget;

	private Color storedColor;

	private float lerpTime;

	private IngameScreen ingameScreen
	{
		get
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			object result = this - -64;
			if (_ingameScreen == null)
			{
				result = IngameScreen.instance__BackingField;
			}
			return (IngameScreen)result;
		}
	}

	private void Awake()
	{
		IngameScreen ingameScreen = this.ingameScreen;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (IngameScreen)+B8]");
		_ = 0;
		originalColor = ingameScreen.MULTIPLIER_LABEL_ORIGINAL_COLOR;
	}

	private void OnDisable()
	{
		ReturnToNormal();
	}

	private void OnEnable()
	{
		//IL_0070: Expected F8, but got I4
		UISlider uISlider = slider;
		Image img = ((UIProgressBar)uISlider).img;
		double num = img.m_FillAmount;
		double num2 = Math.Abs((double)img.m_FillAmount);
		if (!(num2 < 2147483648.0))
		{
			num = -2147483648.0;
		}
		sliderSteps = (float)num;
	}

	private void ReturnToNormal()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_0031: Expected Obj, but got VT
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got VT
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got VT
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01d4: Expected I, but got Obj
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I
		//IL_02be: Invalid comparison between Obj and F4
		//IL_02f3: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 80;
		_inverse = false;
		lerpTime = 1f;
		if (~(PlusMultiplier.plusMultiplierEnabled ? 1u : 0u) == 0)
		{
			IngameScreen ingameScreen = this.ingameScreen;
			object obj3 = GlobalColors.MULTIPLIER_LIGHT_PURPLE >> 16;
			object obj4 = obj3 & 0xFF;
			float num = (float)obj4 / 255f;
			object obj5 = GlobalColors.MULTIPLIER_LIGHT_PURPLE >> 24;
			float num2 = (float)obj5 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			object obj6 = GlobalColors.MULTIPLIER_LIGHT_PURPLE & 0xFF;
			float num3 = (float)obj6 / 255f;
			object obj7 = GlobalColors.MULTIPLIER_LIGHT_PURPLE >> 8;
			object obj8 = obj7 & 0xFF;
			float num4 = (float)obj8 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			object obj9 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			return;
		}
		GameStats instance = GameStats.Instance;
		if (~(instance._scoreBoosterActivated ? 1u : 0u) != 0)
		{
			GameStats instance2 = GameStats.Instance;
			if (~(instance2._characterDayEventActivated ? 1u : 0u) != 0)
			{
				object obj10 = obj + 48;
				IngameScreen ingameScreen2 = this.ingameScreen;
				TMP_Text multiplierLabel = ingameScreen2.multiplierLabel;
				nint num5 = (nint)multiplierLabel;
				object obj11 = multiplierLabel + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+16C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				object obj12 = 0 - originalColor;
				object obj13 = obj12 * obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+2C]");
				object obj14 = num6 - 0;
				object obj15 = obj14 * obj14;
				object obj16 = obj13 + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+30]");
				object obj17 = num7 - 0;
				object obj18 = obj17 * obj17;
				object obj19 = obj16 + obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+34]");
				object obj20 = num8 - 0;
				object obj21 = obj20 * obj20;
				object obj22 = obj19 + obj21;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
				{
					IngameScreen ingameScreen3 = this.ingameScreen;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+30]");
					_ = 0;
					obj = originalColor;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				}
				return;
			}
		}
		IngameScreen ingameScreen4 = this.ingameScreen;
		IngameScreen ingameScreen5 = this.ingameScreen;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v9 (IngameScreen)+88]");
		_ = 0;
		_ = ingameScreen5.SCOREBOOSTER_ACTIVE_COLOR;
		object obj23 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
	}

	public void HidePowerupSlot()
	{
		ActivePowerup powerup = _powerup;
		if (_powerup != null && powerup.type == PowerupType.doubleMultiplier)
		{
			ReturnToNormal();
		}
	}

	public unsafe void setContainerPosition(float x, float y, float z)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0037: Expected F4, but got I
		//IL_0032: Expected native int or pointer, but got VT
		//IL_0056: Expected F4, but got I
		//IL_0051: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Transform transform = container.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.localPosition = vector;
	}

	public unsafe void SetPowerupSlot(ActivePowerup powerup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected I4, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected Obj, but got Unknown
		//IL_0256: Expected I, but got Obj
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected Obj, but got Unknown
		//IL_08f7: Expected Obj, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 176;
		_ = 0;
		_powerup = powerup;
		string text;
		Image image;
		if (powerup.type == PowerupType.hoverboard)
		{
			Hoverboard instance = Hoverboard.Instance;
			if (~(instance._isARewardFromMysteryPowerup ? 1u : 0u) == 0)
			{
				text = MysteryPowerup.GetRandomBoardIconName();
				image = icon;
				goto IL_06c4;
			}
		}
		Upgrade upgrade = Upgrades.upgrades.get_Item(powerup.type);
		text = upgrade.iconName;
		image = icon;
		goto IL_06c4;
		IL_06c4:
		string path = "UI/" + text;
		Sprite sprite = Resources.Load<Sprite>(path);
		image.sprite = sprite;
		float value;
		if (powerup.type != PowerupType.headstart)
		{
			if (powerup.type == PowerupType.jetpack)
			{
				Game instance2 = Game.Instance;
				JetpackState jetpackState = instance2._jetpackState;
				value = powerup.timeLeft / jetpackState._powerupTimeLeftMax;
			}
			else
			{
				PlayerInfo instance3 = PlayerInfo.Instance;
				float powerupDuration = instance3.GetPowerupDuration(powerup.type);
				value = powerup.timeLeft / powerupDuration;
			}
		}
		else
		{
			JetpackState instance4 = JetpackState.Instance;
			value = instance4.GetTotalRemainingHeadstartRatio();
		}
		slider.value = value;
		if (sliderSteps == 0f)
		{
			UISlider uISlider = slider;
			Image img = ((UIProgressBar)uISlider).img;
			sliderSteps = img.m_FillAmount;
		}
		if (powerup.type == PowerupType.hoverboard)
		{
			Hoverboard instance5 = Hoverboard.Instance;
			if (!instance5._isARewardFromMysteryPowerup)
			{
				TMP_Text tMP_Text = amountLabel;
				PlayerInfo instance6 = PlayerInfo.Instance;
				int upgradeAmount = instance6.GetUpgradeAmount(powerup.type);
				int num = obj + 172;
				string text2 = ((int*)num)->ToString();
				nint num2 = (nint)tMP_Text;
				object obj3 = tMP_Text + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ S2_v57 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				GameObject gameObject = amountLabel.gameObject;
				gameObject.SetActive(value: true);
				DeviceInfo instance7 = DeviceInfo.Instance;
				if (~(instance7.isHighres__BackingField ? 1u : 0u) == 0 && !_amountLabelRepositioned)
				{
					Transform transform = amountLabel.transform;
					Transform transform2 = amountLabel.transform;
					Vector3 localPosition = transform2.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
					float num3 = 0f + 0.5f;
					Transform transform3 = amountLabel.transform;
					Vector3 localPosition2 = transform3.localPosition;
					Transform transform4 = amountLabel.transform;
					Vector3 localPosition3 = transform4.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					_ = 0;
					Vector3 localPosition4 = (Vector3)(obj - -64);
					transform.localPosition = localPosition4;
					_amountLabelRepositioned = true;
				}
				goto IL_03df;
			}
		}
		GameObject gameObject2 = amountLabel.gameObject;
		gameObject2.SetActive(value: false);
		goto IL_03df;
		IL_03df:
		if (powerup.type == PowerupType.doubleMultiplier)
		{
			FadingToWhiteToGreenToDarkGreen(_inverse);
		}
		GameObject gameObject3 = slider.gameObject;
		bool activeInHierarchy = gameObject3.activeInHierarchy;
		if (powerup.timeLeft < 0f)
		{
			if (activeInHierarchy)
			{
				GameObject go = slider.gameObject;
				NGUITools.SetActive(go, state: false);
				GameObject gameObject4 = slider.gameObject;
				gameObject4.SetActive(value: false);
			}
			float num4 = powerup.timeLeft * (float)Math.PI;
			float num5 = num4 * 4f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
			object obj4 = default;
			float num6 = (float)obj4 * 0.5f;
			float num7 = num6 + 0.5f;
			float num8 = Math.Min(num7, 1f);
			bool flag = num7 < 0f;
			float num9 = 0f;
			if (!flag)
			{
				num9 = num8;
			}
			float num10 = num9 * 0.5f;
			float num11 = num10 + 0.5f;
			float num12 = num9 * 0.5f;
			float num13 = num12 + 0.5f;
			float num14 = num9 * 0f;
			float num15 = num14 + 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			float num16 = num9 * 0.5f;
			float num17 = num16 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			object obj5 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			float num18 = powerup.timeLeft * (float)Math.PI;
			float num19 = num18 * 4f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
			object obj6 = default;
			float num20 = (float)obj6 * 0.5f;
			float num21 = num20 + 0.5f;
			float num22 = Math.Min(num21, 1f);
			bool flag2 = num21 < 0f;
			float num23 = 0f;
			if (!flag2)
			{
				num23 = num22;
			}
			float num24 = num23 * 0.5f;
			float num25 = num24 + 0.5f;
			float num26 = num23 * 0.5f;
			float num27 = num26 + 0.5f;
			float num28 = num23 * 0f;
			float num29 = num28 + 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			float num30 = num23 * 0.5f;
			float num31 = num30 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
		else
		{
			if (!activeInHierarchy)
			{
				GameObject go2 = slider.gameObject;
				NGUITools.SetActive(go2, state: true);
				GameObject gameObject5 = slider.gameObject;
				gameObject5.SetActive(value: true);
			}
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			object obj7 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			_ = 4575657222473777152L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			object obj8 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
	}

	private void FadingToWhiteToGreenToDarkGreen(bool sendInverse)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0949: Expected Obj, but got I4
		//IL_097b: Expected Obj, but got I
		//IL_0ba2: Expected Obj, but got I4
		//IL_0bd4: Expected Obj, but got I
		//IL_0a0e: Expected Obj, but got I
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected Obj, but got Unknown
		//IL_0a84: Expected Obj, but got I
		//IL_0af9: Expected Obj, but got I
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected Obj, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected Obj, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02bb: Expected I, but got Obj
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_030c: Expected VT, but got I
		//IL_0453: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got I
		//IL_0c75: Expected Obj, but got I
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c83: Expected Obj, but got Unknown
		//IL_0ceb: Expected Obj, but got I
		//IL_0d60: Expected Obj, but got I
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6e: Expected Obj, but got Unknown
		//IL_0ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de0: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03b0: Expected I, but got Obj
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_0401: Expected VT, but got I
		//IL_06ed: Expected Obj, but got I4
		//IL_071f: Expected Obj, but got I
		//IL_0518: Expected Obj, but got I
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_058e: Expected Obj, but got I
		//IL_0603: Expected Obj, but got I
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected Obj, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00b9: Expected I, but got Obj
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_010a: Expected VT, but got I
		//IL_07c0: Expected Obj, but got I
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected Obj, but got Unknown
		//IL_0836: Expected Obj, but got I
		//IL_08ab: Expected Obj, but got I
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected Obj, but got Unknown
		//IL_0920: Expected Obj, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_01a0: Expected I, but got Obj
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01f1: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 160;
		if (sendInverse)
		{
			if (!(lerpTime > 1f))
			{
				currentFadeTarget = FadeTarget.green;
				if (oldFadeTarget != FadeTarget.green)
				{
					object obj3 = obj + 128;
					IngameScreen ingameScreen = this.ingameScreen;
					TMP_Text multiplierLabel = ingameScreen.multiplierLabel;
					nint num = (nint)multiplierLabel;
					object obj4 = multiplierLabel + 176;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ S2_v137 (Il2CppClass<TMPro.TMP_Text>)+16C] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					storedColor = (Color)0;
				}
				IngameScreen ingameScreen2 = this.ingameScreen;
				object obj5 = (int)currentFadeTarget << 2;
				object obj6 = (object)_colorTargets + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v132+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				object obj7 = (nint)0 & (nint)0xFF;
				float num2 = (float)obj7 / 255f;
				float num3 = num2 - (float)storedColor;
				float num4 = Math.Min(lerpTime, 1f);
				bool flag = lerpTime < 0f;
				float num5 = 0f;
				if (!flag)
				{
					num5 = num4;
				}
				float num6 = num3 * num5;
				float num7 = (float)storedColor + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				object obj8 = (nint)0 >> 16;
				object obj9 = obj8 & 0xFF;
				float num8 = (float)obj9 / 255f;
				float num9 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+60]");
				float num10 = num9 - 0f;
				float num11 = num10 * num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+60]");
				float num12 = 0f + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				object obj10 = (nint)0 >> 24;
				float num13 = (float)obj10 / 255f;
				float num14 = num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+64]");
				float num15 = num14 - 0f;
				float num16 = num15 * num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+64]");
				float num17 = 0f + num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				object obj11 = (nint)0 >> 8;
				object obj12 = obj11 & 0xFF;
				float num18 = (float)obj12 / 255f;
				float num19 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+5C]");
				float num20 = num19 - 0f;
				float num21 = num20 * num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+5C]");
				float num22 = 0f + num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				_ = 0;
				object obj13 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			else if (!(lerpTime > 2f))
			{
				currentFadeTarget = FadeTarget.white;
				if (oldFadeTarget != FadeTarget.white)
				{
					object obj14 = obj + 128;
					IngameScreen ingameScreen3 = this.ingameScreen;
					TMP_Text multiplierLabel2 = ingameScreen3.multiplierLabel;
					nint num23 = (nint)multiplierLabel2;
					object obj15 = multiplierLabel2 + 176;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ S2_v103 (Il2CppClass<TMPro.TMP_Text>)+16C] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					storedColor = (Color)0;
				}
				IngameScreen ingameScreen4 = this.ingameScreen;
				object obj16 = (int)currentFadeTarget << 2;
				object obj17 = (object)_colorTargets + obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S1_v96+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				object obj18 = (nint)0 & (nint)0xFF;
				float num24 = (float)obj18 / 255f;
				float num25 = num24 - (float)storedColor;
				float num26 = lerpTime - 1f;
				float num27 = Math.Min(num26, 1f);
				bool flag2 = num26 < 0f;
				float num28 = 0f;
				if (!flag2)
				{
					num28 = num27;
				}
				float num29 = num25 * num28;
				float num30 = (float)storedColor + num29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				object obj19 = (nint)0 >> 16;
				object obj20 = obj19 & 0xFF;
				float num31 = (float)obj20 / 255f;
				float num32 = num31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+60]");
				float num33 = num32 - 0f;
				float num34 = num33 * num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+60]");
				float num35 = 0f + num34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				object obj21 = (nint)0 >> 24;
				float num36 = (float)obj21 / 255f;
				float num37 = num36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+64]");
				float num38 = num37 - 0f;
				float num39 = num38 * num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+64]");
				float num40 = 0f + num39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				object obj22 = (nint)0 >> 8;
				object obj23 = obj22 & 0xFF;
				float num41 = (float)obj23 / 255f;
				float num42 = num41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+5C]");
				float num43 = num42 - 0f;
				float num44 = num43 * num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+5C]");
				float num45 = 0f + num44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			else
			{
				lerpTime = 0f;
				_inverse = false;
				currentFadeTarget = FadeTarget.none;
			}
		}
		else if (!(lerpTime > 1f))
		{
			currentFadeTarget = FadeTarget.green;
			if (oldFadeTarget != FadeTarget.green)
			{
				object obj24 = obj + 128;
				IngameScreen ingameScreen5 = this.ingameScreen;
				TMP_Text multiplierLabel3 = ingameScreen5.multiplierLabel;
				nint num46 = (nint)multiplierLabel3;
				object obj25 = multiplierLabel3 + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v283 @ S2_v70 (Il2CppClass<TMPro.TMP_Text>)+16C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				storedColor = (Color)0;
			}
			IngameScreen ingameScreen6 = this.ingameScreen;
			object obj26 = (int)currentFadeTarget << 2;
			object obj27 = (object)_colorTargets + obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S1_v56+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			object obj28 = (nint)0 & (nint)0xFF;
			float num47 = (float)obj28 / 255f;
			float num48 = num47 - (float)storedColor;
			float num49 = Math.Min(lerpTime, 1f);
			bool flag3 = lerpTime < 0f;
			float num50 = 0f;
			if (!flag3)
			{
				num50 = num49;
			}
			float num51 = num48 * num50;
			float num52 = (float)storedColor + num51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			object obj29 = (nint)0 >> 16;
			object obj30 = obj29 & 0xFF;
			float num53 = (float)obj30 / 255f;
			float num54 = num53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+60]");
			float num55 = num54 - 0f;
			float num56 = num55 * num50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+60]");
			float num57 = 0f + num56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			object obj31 = (nint)0 >> 24;
			float num58 = (float)obj31 / 255f;
			float num59 = num58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+64]");
			float num60 = num59 - 0f;
			float num61 = num60 * num50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+64]");
			float num62 = 0f + num61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			object obj32 = (nint)0 >> 8;
			object obj33 = obj32 & 0xFF;
			float num63 = (float)obj33 / 255f;
			float num64 = num63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+5C]");
			float num65 = num64 - 0f;
			float num66 = num65 * num50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+5C]");
			float num67 = 0f + num66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
			_ = 0;
			object obj34 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
		else if (!(lerpTime > 2f))
		{
			currentFadeTarget = FadeTarget.darkgreen;
			if (oldFadeTarget != FadeTarget.darkgreen)
			{
				object obj35 = obj + 128;
				IngameScreen ingameScreen7 = this.ingameScreen;
				TMP_Text multiplierLabel4 = ingameScreen7.multiplierLabel;
				nint num68 = (nint)multiplierLabel4;
				object obj36 = multiplierLabel4 + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v417 @ S2_v36 (Il2CppClass<TMPro.TMP_Text>)+16C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				storedColor = (Color)0;
			}
			IngameScreen ingameScreen8 = this.ingameScreen;
			object obj37 = (int)currentFadeTarget << 2;
			object obj38 = (object)_colorTargets + obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S1_v20+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			object obj39 = (nint)0 & (nint)0xFF;
			float num69 = (float)obj39 / 255f;
			float num70 = num69 - (float)storedColor;
			float num71 = lerpTime - 1f;
			float num72 = Math.Min(num71, 1f);
			bool flag4 = num71 < 0f;
			float num73 = 0f;
			if (!flag4)
			{
				num73 = num72;
			}
			float num74 = num70 * num73;
			float num75 = (float)storedColor + num74;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			object obj40 = (nint)0 >> 16;
			object obj41 = obj40 & 0xFF;
			float num76 = (float)obj41 / 255f;
			float num77 = num76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+60]");
			float num78 = num77 - 0f;
			float num79 = num78 * num73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+60]");
			float num80 = 0f + num79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			object obj42 = (nint)0 >> 24;
			float num81 = (float)obj42 / 255f;
			float num82 = num81;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+64]");
			float num83 = num82 - 0f;
			float num84 = num83 * num73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+64]");
			float num85 = 0f + num84;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			object obj43 = (nint)0 >> 8;
			object obj44 = obj43 & 0xFF;
			float num86 = (float)obj44 / 255f;
			float num87 = num86;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+5C]");
			float num88 = num87 - 0f;
			float num89 = num88 * num73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHelper)+5C]");
			float num90 = 0f + num89;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			object obj45 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
		else
		{
			lerpTime = 0f;
			_inverse = true;
			currentFadeTarget = FadeTarget.none;
		}
		float deltaTime = Time.deltaTime;
		float num91 = deltaTime * 8.2343f;
		float num92 = lerpTime + num91;
		lerpTime = num92;
		oldFadeTarget = currentFadeTarget;
	}

	public UIPowerupHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008c: Expected I4, but got I8
		object obj2 = default;
		object obj = obj2 - 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = -1;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
		_ = 0;
		_ = -14499691;
		_ = -14499691;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		_ = -12552620;
		_ = -12552620;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		_ = 0;
		Color32[] colorTargets = default;
		_colorTargets = colorTargets;
		lerpTime = 1f;
		currentFadeTarget = FadeTarget.none;
		base._002Ector();
	}
}
