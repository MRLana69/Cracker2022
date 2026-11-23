using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemHuntPopupCell : MonoBehaviour
{
	public RectTransform itemTrans;

	public Image cellBackground;

	public GameObject activeLabels;

	public TMP_Text activePeriodTitle;

	public TMP_Text activeMainTitle;

	public GameObject inactiveLabels;

	public TMP_Text inactivePeriodTitle;

	public Image progressMask;

	public GameObject iconsGroup;

	public Image spriteCircleBg;

	public Image prizebgMaskSprite;

	public Image spriteCirclePrizeCompleted;

	public Image spriteCirclePrizeUnknown;

	public GameObject activeProgressSlider;

	public GameObject inactiveProgressSlider;

	public Image activeProgressBg;

	public Image activeProgressFg;

	public TMP_Text activeProgressText;

	public Image activeProgressIcon;

	public GameObject inactiveProgressGroup;

	public TMP_Text inactiveProgressText;

	public GameObject stickerGroup;

	public Image stickerSprite;

	public TMP_Text stickerTextTop;

	public TMP_Text stickerTextBot;

	[NonSerialized]
	public GameObject prizeIcon;

	[NonSerialized]
	public GameObject presentIcon;

	private bool stickerTopInitialized;

	private TimeSpan expireTime = TimeSpan.Zero;

	private int _totalSeconds = -1;

	public GameObject fail;

	public TMP_Text amountLable;

	public Image icon;

	public Sprite finish;

	public Sprite unfinish;

	public GameObject iconPrefab
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

	public void PlaceModel(Vector3 offset, Vector3 scale, Vector3 rotation, bool hidePrize = false)
	{
	}

	public void HidePrizeIcon()
	{
		if (prizeIcon != null)
		{
			prizeIcon.SetActive(value: false);
		}
		if (presentIcon != null)
		{
			presentIcon.SetActive(value: false);
		}
	}

	public void RefreshProgressBar(GameObject progress, TMP_Text ProgressText, int currentItemAmount, int totalItemAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007a: Expected F4, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_003f: Expected I, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		UISlider component = progress.GetComponent<UISlider>();
		int num = currentItemAmount / totalItemAmount;
		float value = num;
		if (totalItemAmount == 0)
		{
			value = 1f;
		}
		component.value = value;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		string text = $"{arg} / {arg2}";
		nint num2 = (nint)ProgressText;
		object obj5 = ProgressText + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S2_v8 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public void SetTheStickerContent(TimeSpan timeLeft)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a2: Expected Obj, but got I8
		//IL_0057: Expected Obj, but got I8
		//IL_00c4: Expected Obj, but got I8
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00ff: Expected I, but got Obj
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_013c: Expected I, but got Obj
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(stickerTopInitialized ? 1u : 0u) != 0)
		{
			stickerTopInitialized = true;
		}
		expireTime = timeLeft;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = 0 / 864000000000L;
		if ((nint)obj3 <= 0)
		{
			UpdateStickerCounter();
			return;
		}
		TMP_Text tMP_Text = stickerTextTop;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj4 = 0 / 864000000000L;
		if ((nint)obj4 == 1)
		{
			string text = Strings.Get(StringID.ITEM_HUNT_ONE_DAY);
		}
		else
		{
			string format = Strings.Get(StringID.ITEM_HUNT_N_DAYS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj5 = 0 / 864000000000L;
			object obj6 = obj + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			string text = string.Format(format, arg);
		}
		nint num = (nint)tMP_Text;
		object obj7 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = stickerTextBot;
		string text2 = Strings.Get(StringID.ITEM_HUNT_LEFT);
		nint num2 = (nint)tMP_Text2;
		object obj8 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	private void UpdateStickerCounter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_0083: Expected F8, but got I4
		//IL_02f4: Invalid comparison between F8 and I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01be: Expected I, but got Obj
		//IL_01ed: Expected I, but got Obj
		//IL_0257: Expected F8, but got I4
		//IL_0312: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 - 16;
		GameObject gameObject = stickerTextTop.gameObject;
		if (!gameObject.activeInHierarchy || !stickerTextTop.enabled)
		{
			return;
		}
		if (TimeSpan.Zero > expireTime)
		{
			expireTime = TimeSpan.Zero;
		}
		object obj3 = this + 128;
		double num = (double)obj3 * 1E-07;
		double num2 = Math.Abs(num);
		if (!(num2 < 2147483648.0))
		{
			num = -2147483648.0;
		}
		if (num != (double)_totalSeconds)
		{
			TMP_Text tMP_Text = stickerTextTop;
			object obj4 = obj3 / 36000000000L;
			object obj5 = obj4 / 24;
			object obj6 = obj5 * 24;
			object obj7 = obj4 - obj6;
			object obj8 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj9 = obj3 / 600000000;
			object obj10 = obj9 / 60;
			object obj11 = obj10 * 60;
			object obj12 = obj9 - obj11;
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj14 = obj3 / 10000000;
			object obj15 = obj14 / 60;
			object obj16 = obj15 * 60;
			object obj17 = obj14 - obj16;
			object obj18 = obj + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			object arg3 = default;
			string text = $"{arg:00}:{arg2:00}:{arg3:00}";
			nint num3 = (nint)tMP_Text;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ S2_v13 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text2 = stickerTextBot;
			string text2 = Strings.Get(StringID.ITEM_HUNT_LEFT);
			nint num4 = (nint)tMP_Text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ S2_v17 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			double num5 = (double)obj3 * 1E-07;
			double num6 = Math.Abs(num5);
			if (!(num6 < 2147483648.0))
			{
				num5 = -2147483648.0;
			}
			_totalSeconds = (int)num5;
		}
	}
}
