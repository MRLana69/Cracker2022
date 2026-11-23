using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DayHelper : MonoBehaviour
{
	public enum DayType
	{
		_notset,
		regular,
		lastDay
	}

	public DayType dayType;

	private Color32 InactiveDayColor = (Color32)(-11326967);

	private Color32 ActiveDayColor;

	private Color32 InactiveDayShadowColor = (Color32)(-63485689718636544L);

	private Color32 ActiveDayShadowColor;

	private Color32 InactiveRewardColor = (Color32)(-1);

	private Color32 ActiveRewardColor;

	private Color32 InactiveRewardShadowColor = (Color32)(-63485685435194368L);

	private Color32 ActiveRewardShadowColor;

	private Color32 InactiveLastDayDayColor = (Color32)(-16442499);

	private Color32 ActiveLastDayDayColor;

	private Color32 InactiveLastDayDayShadowColor = (Color32)(-63485689718636544L);

	private Color32 ActiveLastDayDayShadowColor;

	private Color32 InactiveLastDayRewardShadowColor = (Color32)(-63485685429179908L);

	private Color32 ActiveLastDayRewardShadowColor;

	private Color32 ActiveLastDayBackgroundColor = (Color32)(-54357685935150435L);

	private Color32 InactiveLastDayBackgroundColor;

	private Color32 ActiveLastDayGradientColor = (Color32)(-60611720959184282L);

	private Color32 InactiveLastDayGradientColor;

	private Color32 ActiveLastDayGlow = (Color32)(-1258291201);

	private Color32 InactiveLastDayGlow;

	private TMP_Text dayLabel;

	private TMP_Text rewardLabel;

	private TMP_Text checkBackLabel;

	private Image checkMark;

	private Image backgroundInactive;

	private Image backgroundActive;

	private Image checkbackBackground;

	private Image[] gradientEffectSprites;

	private bool ForceActive;

	private bool UnlockColors;

	private int _dayIndex = -1;

	public unsafe void Init(int dayIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		//IL_004e: Expected I, but got Obj
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		_dayIndex = dayIndex;
		DailyWord.DailyWordReward rewardForDay = DailyWord.GetRewardForDay(dayIndex);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		if (obj == null)
		{
			TMP_Text tMP_Text = rewardLabel;
			object obj3 = obj + 16;
			int num = obj3 | 4;
			string text = ((int*)num)->ToString();
			nint num2 = (nint)tMP_Text;
			object obj4 = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		ForceActive = false;
	}

	public unsafe void RefreshDay()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Ref, but got Unknown
		//IL_0951: Expected Obj, but got I4
		//IL_0719: Expected Obj, but got I4
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected I4, but got Unknown
		//IL_075c: Expected I, but got Obj
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected Obj, but got Unknown
		//IL_0784: Expected Obj, but got VT
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected Obj, but got Unknown
		//IL_07c4: Expected Obj, but got VT
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected Obj, but got Unknown
		//IL_07f2: Expected Obj, but got VT
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected Obj, but got Unknown
		//IL_059e: Expected I, but got Obj
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected Obj, but got Unknown
		//IL_05c6: Expected Obj, but got VT
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05f9: Expected Obj, but got VT
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_062c: Expected Obj, but got I
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_0661: Expected Obj, but got VT
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected Obj, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_0111: Expected I, but got Obj
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got VT
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got VT
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got VT
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected Obj, but got Unknown
		//IL_0990: Expected I, but got Obj
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected Obj, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected Obj, but got Unknown
		//IL_0289: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got I4
		//IL_02e4: Expected Obj, but got VT
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_0317: Expected Obj, but got VT
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got VT
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_046a: Expected Obj, but got VT
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_049d: Expected Obj, but got VT
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04f4: Expected Obj, but got VT
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 208;
		_ = 0;
		_ = 0;
		if (UnlockColors)
		{
			return;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		int num = instance.GetDailyWordDaysInARow(out *(bool*)(obj + 207));
		if (num >= 5)
		{
			num = 5;
		}
		if (num <= 0)
		{
			num = 0;
		}
		int num2 = num - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+CF]");
		if ((nint)0 == 0)
		{
			num2 = num;
		}
		object obj3 = dayType - 1;
		if (dayType != DayType.regular)
		{
			if ((nint)obj3 == 1)
			{
				if (num2 > 3 || ~(ForceActive ? 1u : 0u) == 0)
				{
					TMP_Text tMP_Text = dayLabel;
					string text = Strings.Get(StringID.DAILY_CHALLENGE_TODAY_1);
					nint num3 = (nint)tMP_Text;
					object obj4 = tMP_Text + 528;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ S2_v45 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
					object obj5 = ActiveLastDayDayColor >> 16;
					object obj6 = obj5 & 0xFF;
					float num4 = (float)obj6 / 255f;
					object obj7 = ActiveLastDayDayColor >> 24;
					float num5 = (float)obj7 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
					_ = 0;
					object obj8 = ActiveLastDayDayColor & 0xFF;
					float num6 = (float)obj8 / 255f;
					object obj9 = ActiveLastDayDayColor >> 8;
					object obj10 = obj9 & 0xFF;
					float num7 = (float)obj10 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
					_ = 0;
					object obj11 = obj + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
					Image image = checkMark;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+CF]");
					image.enabled = false;
					Image image2 = checkbackBackground;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+CF]");
					image2.enabled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+CF]");
					bool flag = (nint)0 == 0;
					rewardLabel.enabled = flag;
					TMP_Text tMP_Text2 = checkBackLabel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+CF]");
					tMP_Text2.enabled = false;
					object obj12 = 0;
					while (true)
					{
						Image[] array = gradientEffectSprites;
						if ((nint)obj12 < array.Length)
						{
							object obj13 = obj12 << 2;
							object obj14 = (object)array + obj13;
							object obj15 = ActiveLastDayGradientColor >> 16;
							object obj16 = obj15 & 0xFF;
							float num8 = (float)obj16 / 255f;
							object obj17 = ActiveLastDayGradientColor >> 24;
							float num9 = (float)obj17 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
							_ = 0;
							object obj18 = ActiveLastDayGradientColor & 0xFF;
							float num10 = (float)obj18 / 255f;
							object obj19 = ActiveLastDayGradientColor >> 8;
							object obj20 = obj19 & 0xFF;
							float num11 = (float)obj20 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
							_ = 0;
							object obj21 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
							object obj22 = obj12 + 1;
							obj12 = obj22;
							continue;
						}
						break;
					}
					return;
				}
				TMP_Text tMP_Text3 = dayLabel;
				string text2 = Strings.Get(StringID.DAILY_CHALLENGE_DAY_5);
				nint num12 = (nint)tMP_Text3;
				object obj23 = tMP_Text3 + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v261 @ S2_v80 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				checkMark.enabled = false;
				checkbackBackground.enabled = false;
				rewardLabel.enabled = true;
				checkBackLabel.enabled = false;
				object obj24 = 0;
				while (true)
				{
					Image[] array2 = gradientEffectSprites;
					if ((nint)obj24 < array2.Length)
					{
						object obj25 = obj24 << 2;
						object obj26 = (object)array2 + obj25;
						object obj27 = InactiveLastDayGradientColor >> 16;
						object obj28 = obj27 & 0xFF;
						float num13 = (float)obj28 / 255f;
						object obj29 = InactiveLastDayGradientColor >> 24;
						float num14 = (float)obj29 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
						_ = 0;
						object obj30 = InactiveLastDayGradientColor & 0xFF;
						float num15 = (float)obj30 / 255f;
						object obj31 = InactiveLastDayGradientColor >> 8;
						object obj32 = obj31 & 0xFF;
						float num16 = (float)obj32 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
						_ = 0;
						object obj33 = obj + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
						object obj34 = obj24 + 1;
						obj24 = obj34;
						continue;
					}
					break;
				}
			}
			else
			{
				GameObject gameObject = base.gameObject;
			}
		}
		else if (_dayIndex == num2)
		{
			GameObject gameObject2 = backgroundActive.gameObject;
			gameObject2.SetActive(value: true);
			TMP_Text tMP_Text4 = dayLabel;
			string text3 = Strings.Get(StringID.DAILY_CHALLENGE_TODAY_2);
			nint num17 = (nint)tMP_Text4;
			object obj35 = tMP_Text4 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v278 @ S2_v27 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			object obj36 = ActiveRewardColor >> 16;
			object obj37 = obj36 & 0xFF;
			float num18 = (float)obj37 / 255f;
			object obj38 = ActiveRewardColor >> 24;
			float num19 = (float)obj38 / 255f;
			object obj39 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			obj39 = 0;
			object obj40 = ActiveRewardColor & 0xFF;
			float num20 = (float)obj40 / 255f;
			object obj41 = ActiveRewardColor >> 8;
			object obj42 = obj41 & 0xFF;
			float num21 = (float)obj42 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			object obj43 = obj + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			Image image3 = checkMark;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+CF]");
			image3.enabled = false;
		}
		else
		{
			GameObject gameObject3 = backgroundActive.gameObject;
			gameObject3.SetActive(value: false);
			TMP_Text tMP_Text5 = dayLabel;
			string text4 = Strings.Get(StringID.DAILY_CHALLENGE_DAY);
			object obj44 = _dayIndex + 1;
			int num22 = obj + 200;
			string text5 = ((int*)num22)->ToString();
			string text6 = text4 + " " + text5;
			nint num23 = (nint)tMP_Text5;
			object obj45 = tMP_Text5 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v366 @ S2_v15 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			object obj46 = InactiveRewardColor >> 24;
			float num24 = (float)obj46 / 255f;
			object obj47 = InactiveRewardColor & 0xFF;
			float num25 = (float)obj47 / 255f;
			object obj48 = InactiveRewardColor >> 16;
			object obj49 = obj48 & 0xFF;
			float num26 = (float)obj49 / 255f;
			object obj50 = InactiveRewardColor >> 8;
			object obj51 = obj50 & 0xFF;
			float num27 = (float)obj51 / 255f;
			if (num2 < _dayIndex)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				object obj52 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				checkMark.enabled = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				object obj53 = obj + 88;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				checkMark.enabled = true;
			}
		}
	}

	public DayHelper()
	{
		//IL_0016: Expected VT, but got I4
		//IL_0025: Expected VT, but got I8
		//IL_0034: Expected VT, but got I8
		//IL_0043: Expected VT, but got I8
		//IL_0052: Expected VT, but got I8
		//IL_005d: Expected VT, but got I4
		//IL_006c: Expected VT, but got I8
		//IL_0077: Expected VT, but got I4
		//IL_0086: Expected VT, but got I8
		//IL_0091: Expected VT, but got I4
	}
}
