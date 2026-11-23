using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class DiscountButton : MonoBehaviour
{
	protected readonly Color32 titleColor = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR;

	protected readonly Color32 titleColorShadow = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR_SHADOW;

	protected readonly Color32 description1ColorInactive = GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_COLOR;

	protected readonly Color32 description1ColorShadowInactive = GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_SHADOW_COLOR;

	protected readonly Color32 description1ColorActive = GlobalColors.DISCOUNT_BUTTON_DESCRIPTION1_ACTIVE_COLOR;

	protected readonly Color32 description1ColorShadowActive = GlobalColors.DISCOUNT_BUTTON_DESCRIPTION1_ACTIVE_SHADOW_COLOR;

	protected readonly Color32 description2Color = GlobalColors.DISCOUNT_BUTTON_DESCRIPTION2_COLOR;

	protected readonly Color32 description2ColorShadow = GlobalColors.DISCOUNT_BUTTON_DESCRIPTION2_SHADOW_COLOR;

	protected readonly Color32 priceColor = GlobalColorsGenerated.DISCOUNT_BUTTON_PRICE_COLOR;

	protected readonly Color32 priceColorShadow = GlobalColorsGenerated.DISCOUNT_BUTTON_PRICE_SHADOW_COLOR;

	protected readonly Color32 limitedTimerColor = GlobalColorsGenerated.DISCOUNT_BUTTON_LIMITED_TIME_COLOR;

	protected readonly Color32 limitedTimerColorShadow = GlobalColorsGenerated.DISCOUNT_BUTTON_LIMITED_TIME_SHADOW_COLOR;

	protected const int SALE_BUTTON_GROWTH = 12;

	protected Color32 originalTitleColor;

	protected Color32 originalTitleColorShadow;

	protected Color32 originalDescriptionColor;

	protected Color32 originalDescriptionColorShadow;

	protected Vector3 originalDescriptionPosition;

	protected Vector3 originalPricePosition;

	protected Vector3 originalFillGrayScale;

	protected Vector3 originalFillColorScale;

	protected Vector3 originalOutlineScale;

	protected Vector3 originalContentPosition;

	protected Vector3 originalIconBgPosition;

	protected Vector3 originalIconPosition;

	protected Vector2 titleShadowPosition = (Vector2)4575657222473777152L;

	protected string originalFillColorSpirteName;

	protected string originalFillGraySpriteName;

	protected UISprite iconBG;

	protected UISprite icon;

	protected UILabel title;

	protected UILabel description1;

	protected UILabel description2;

	protected UISprite lineThrough;

	protected UISprite lineThroughShadow;

	protected UILabel price;

	protected UISprite fillGraySprite;

	protected UISprite fillColorSprite;

	protected UISprite outlineSprite;

	protected Transform content;

	protected UISprite discountSticker;

	protected UILabel discountLabel;

	protected UILabel discountLabelSingleLine;

	protected UILabel limitedTitle;

	protected UILabel limitedTime;

	protected static TimeSpan timeLeft;

	public virtual void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0069: Expected VT, but got I4
		//IL_0088: Expected VT, but got I4
		//IL_00b1: Expected VT, but got I4
		//IL_0103: Expected VT, but got I
		//IL_015d: Expected VT, but got I
		//IL_01a7: Expected VT, but got Obj
		//IL_01c4: Expected F4, but got VT
		//IL_01db: Invalid comparison between VT and F4
		//IL_061d: Expected F4, but got I
		//IL_0632: Invalid comparison between I and F4
		//IL_067f: Expected F4, but got I
		//IL_0694: Invalid comparison between I and F4
		//IL_06e1: Expected F4, but got I
		//IL_06f6: Invalid comparison between I and F4
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_02b2: Expected VT, but got Obj
		//IL_02d9: Expected F4, but got VT
		//IL_02eb: Invalid comparison between VT and F4
		//IL_0784: Expected F4, but got I
		//IL_0799: Invalid comparison between I and F4
		//IL_07e6: Expected F4, but got I
		//IL_07fb: Invalid comparison between I and F4
		//IL_0848: Expected F4, but got I
		//IL_085d: Invalid comparison between I and F4
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected Obj, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_03c2: Expected VT, but got Obj
		//IL_03e9: Expected F4, but got VT
		//IL_03fb: Invalid comparison between VT and F4
		//IL_08eb: Expected F4, but got I
		//IL_0900: Invalid comparison between I and F4
		//IL_094d: Expected F4, but got I
		//IL_0962: Invalid comparison between I and F4
		//IL_09af: Expected F4, but got I
		//IL_09c4: Invalid comparison between I and F4
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_04d2: Expected VT, but got Obj
		//IL_04f9: Expected F4, but got VT
		//IL_050b: Invalid comparison between VT and F4
		//IL_0a52: Expected F4, but got I
		//IL_0a67: Invalid comparison between I and F4
		//IL_0ab4: Expected F4, but got I
		//IL_0ac9: Invalid comparison between I and F4
		//IL_0b16: Expected F4, but got I
		//IL_0b2b: Invalid comparison between I and F4
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7a: Expected Obj, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_05e2: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + -64;
		UISprite uISprite = fillColorSprite;
		originalFillColorSpirteName = uISprite.mSpriteName;
		UISprite uISprite2 = fillGraySprite;
		originalFillGraySpriteName = uISprite2.mSpriteName;
		UISprite uISprite3 = fillGraySprite;
		_ = 1065353216;
		_ = ((UIWidget)uISprite3).mHeight;
		originalFillGrayScale = (Vector3)((UIWidget)uISprite3).mWidth;
		UISprite uISprite4 = fillColorSprite;
		_ = 1065353216;
		originalFillColorScale = (Vector3)((UIWidget)uISprite4).mWidth;
		_ = ((UIWidget)uISprite4).mHeight;
		UISprite uISprite5 = outlineSprite;
		_ = 1065353216;
		originalOutlineScale = (Vector3)((UIWidget)uISprite5).mWidth;
		_ = ((UIWidget)uISprite5).mHeight;
		Vector3 localPosition = content.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		originalContentPosition = (Vector3)0;
		Transform cachedTransform = description1.cachedTransform;
		Vector3 localPosition2 = cachedTransform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		originalDescriptionPosition = (Vector3)0;
		Transform cachedTransform2 = price.cachedTransform;
		Vector3 localPosition3 = cachedTransform2.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		originalPricePosition = (Vector3)obj;
		UILabel uILabel = title;
		float num = Math.Min((float)((UIWidget)uILabel).mColor, 1f);
		bool flag = ((UIWidget)uILabel).mColor < (object)0f;
		float num2 = 0f;
		if (!flag)
		{
			num2 = num;
		}
		float num3 = num2 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v47 (UILabel)+50]");
		float num4 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v47 (UILabel)+50]");
		bool flag2 = 0f < 0f;
		float num5 = 0f;
		if (!flag2)
		{
			num5 = num4;
		}
		float num6 = num5 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v47 (UILabel)+54]");
		float num7 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v47 (UILabel)+54]");
		bool flag3 = 0f < 0f;
		float num8 = 0f;
		if (!flag3)
		{
			num8 = num7;
		}
		float num9 = num8 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v47 (UILabel)+58]");
		float num10 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v47 (UILabel)+58]");
		bool flag4 = 0f < 0f;
		float num11 = 0f;
		if (!flag4)
		{
			num11 = num10;
		}
		float num12 = num11 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj4 = default;
		object obj3 = obj4 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj6 = default;
		object obj5 = obj6 << 8;
		object obj7 = obj5 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj9 = default;
		object obj8 = obj9 << 16;
		object obj10 = obj8 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj12 = default;
		object obj11 = obj12 << 24;
		object obj13 = obj10 | obj11;
		object obj14 = obj7 | obj13;
		Color32 color = (Color32)(obj3 | obj14);
		originalTitleColor = color;
		UILabel uILabel2 = title;
		float num13 = Math.Min((float)uILabel2.mEffectColor, 1f);
		bool flag5 = uILabel2.mEffectColor < (object)0f;
		float num14 = 0f;
		if (!flag5)
		{
			num14 = num13;
		}
		float num15 = num14 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v71 (UILabel)+144]");
		float num16 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v71 (UILabel)+144]");
		bool flag6 = 0f < 0f;
		float num17 = 0f;
		if (!flag6)
		{
			num17 = num16;
		}
		float num18 = num17 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v71 (UILabel)+148]");
		float num19 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v71 (UILabel)+148]");
		bool flag7 = 0f < 0f;
		float num20 = 0f;
		if (!flag7)
		{
			num20 = num19;
		}
		float num21 = num20 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v71 (UILabel)+14C]");
		float num22 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v71 (UILabel)+14C]");
		bool flag8 = 0f < 0f;
		float num23 = 0f;
		if (!flag8)
		{
			num23 = num22;
		}
		float num24 = num23 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj16 = default;
		object obj15 = obj16 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj18 = default;
		object obj17 = obj18 << 8;
		object obj19 = obj17 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj21 = default;
		object obj20 = obj21 << 16;
		object obj22 = obj20 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj24 = default;
		object obj23 = obj24 << 24;
		object obj25 = obj22 | obj23;
		object obj26 = obj19 | obj25;
		Color32 color2 = (Color32)(obj15 | obj26);
		originalTitleColorShadow = color2;
		UILabel uILabel3 = description1;
		float num25 = Math.Min((float)((UIWidget)uILabel3).mColor, 1f);
		bool flag9 = ((UIWidget)uILabel3).mColor < (object)0f;
		float num26 = 0f;
		if (!flag9)
		{
			num26 = num25;
		}
		float num27 = num26 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v95 (UILabel)+50]");
		float num28 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v95 (UILabel)+50]");
		bool flag10 = 0f < 0f;
		float num29 = 0f;
		if (!flag10)
		{
			num29 = num28;
		}
		float num30 = num29 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v95 (UILabel)+54]");
		float num31 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v95 (UILabel)+54]");
		bool flag11 = 0f < 0f;
		float num32 = 0f;
		if (!flag11)
		{
			num32 = num31;
		}
		float num33 = num32 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v95 (UILabel)+58]");
		float num34 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v95 (UILabel)+58]");
		bool flag12 = 0f < 0f;
		float num35 = 0f;
		if (!flag12)
		{
			num35 = num34;
		}
		float num36 = num35 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj28 = default;
		object obj27 = obj28 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj30 = default;
		object obj29 = obj30 << 8;
		object obj31 = obj29 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj33 = default;
		object obj32 = obj33 << 16;
		object obj34 = obj32 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj36 = default;
		object obj35 = obj36 << 24;
		object obj37 = obj34 | obj35;
		object obj38 = obj31 | obj37;
		Color32 color3 = (Color32)(obj27 | obj38);
		originalDescriptionColor = color3;
		UILabel uILabel4 = description1;
		float num37 = Math.Min((float)uILabel4.mEffectColor, 1f);
		bool flag13 = uILabel4.mEffectColor < (object)0f;
		float num38 = 0f;
		if (!flag13)
		{
			num38 = num37;
		}
		float num39 = num38 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v119 (UILabel)+144]");
		float num40 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v119 (UILabel)+144]");
		bool flag14 = 0f < 0f;
		float num41 = 0f;
		if (!flag14)
		{
			num41 = num40;
		}
		float num42 = num41 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v119 (UILabel)+148]");
		float num43 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v119 (UILabel)+148]");
		bool flag15 = 0f < 0f;
		float num44 = 0f;
		if (!flag15)
		{
			num44 = num43;
		}
		float num45 = num44 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v119 (UILabel)+14C]");
		float num46 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v119 (UILabel)+14C]");
		bool flag16 = 0f < 0f;
		float num47 = 0f;
		if (!flag16)
		{
			num47 = num46;
		}
		float num48 = num47 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj40 = default;
		object obj39 = obj40 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj42 = default;
		object obj41 = obj42 << 8;
		object obj43 = obj41 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj45 = default;
		object obj44 = obj45 << 16;
		object obj46 = obj44 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj48 = default;
		object obj47 = obj48 << 24;
		object obj49 = obj46 | obj47;
		object obj50 = obj43 | obj49;
		Color32 color4 = (Color32)(obj39 | obj50);
		originalDescriptionColorShadow = color4;
	}

	protected unsafe virtual void ShowOnPromotion(string productString, string sendDescription, string sendDescription2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0047: Expected I4, but got F8
		//IL_008e: Expected I4, but got F8
		//IL_00d5: Expected I4, but got F8
		//IL_011c: Expected I4, but got F8
		//IL_0163: Expected I4, but got F8
		//IL_171f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1724: Expected VT, but got Unknown
		//IL_01aa: Expected I4, but got F8
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected VT, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected VT, but got Unknown
		//IL_0431: Expected Obj, but got VT
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0464: Expected Obj, but got VT
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_04bb: Expected Obj, but got VT
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected VT, but got Unknown
		//IL_0518: Expected Obj, but got VT
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_054b: Expected Obj, but got VT
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected Obj, but got Unknown
		//IL_05a2: Expected Obj, but got VT
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected VT, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected VT, but got Unknown
		//IL_062f: Expected Obj, but got VT
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected Obj, but got Unknown
		//IL_0662: Expected Obj, but got VT
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected Obj, but got Unknown
		//IL_06b9: Expected Obj, but got VT
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected VT, but got Unknown
		//IL_071b: Expected Obj, but got VT
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_074e: Expected Obj, but got VT
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got Unknown
		//IL_07a5: Expected Obj, but got VT
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected VT, but got Unknown
		//IL_0802: Expected Obj, but got VT
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected Obj, but got Unknown
		//IL_0835: Expected Obj, but got VT
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected Obj, but got Unknown
		//IL_088c: Expected Obj, but got VT
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected VT, but got Unknown
		//IL_08ee: Expected Obj, but got VT
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected Obj, but got Unknown
		//IL_0921: Expected Obj, but got VT
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected Obj, but got Unknown
		//IL_0978: Expected Obj, but got VT
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected Obj, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected VT, but got Unknown
		//IL_09d5: Expected Obj, but got VT
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e3: Expected Obj, but got Unknown
		//IL_0a08: Expected Obj, but got VT
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected Obj, but got Unknown
		//IL_0a5f: Expected Obj, but got VT
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected Obj, but got Unknown
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected VT, but got Unknown
		//IL_0ac1: Expected Obj, but got VT
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Expected Obj, but got Unknown
		//IL_0af4: Expected Obj, but got VT
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected Obj, but got Unknown
		//IL_0b4b: Expected Obj, but got VT
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected Obj, but got Unknown
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Expected VT, but got Unknown
		//IL_0ba8: Expected Obj, but got VT
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected Obj, but got Unknown
		//IL_0bdb: Expected Obj, but got VT
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Expected Obj, but got Unknown
		//IL_0c32: Expected Obj, but got VT
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Expected Obj, but got Unknown
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Expected VT, but got Unknown
		//IL_0c94: Expected Obj, but got VT
		//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected Obj, but got Unknown
		//IL_0cc7: Expected Obj, but got VT
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected Obj, but got Unknown
		//IL_0d1e: Expected Obj, but got VT
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Expected Obj, but got Unknown
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Expected VT, but got Unknown
		//IL_0d7b: Expected Obj, but got VT
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected Obj, but got Unknown
		//IL_0dae: Expected Obj, but got VT
		//IL_0ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de0: Expected Obj, but got Unknown
		//IL_0e05: Expected Obj, but got VT
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected Obj, but got Unknown
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e43: Expected VT, but got Unknown
		//IL_0e67: Expected Obj, but got VT
		//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e75: Expected Obj, but got Unknown
		//IL_0e9a: Expected Obj, but got VT
		//IL_0ec7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Expected Obj, but got Unknown
		//IL_0ef1: Expected Obj, but got VT
		//IL_0efa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eff: Expected Obj, but got Unknown
		//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2f: Expected VT, but got Unknown
		//IL_0f52: Expected Obj, but got VT
		//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f60: Expected Obj, but got Unknown
		//IL_0f84: Expected Obj, but got VT
		//IL_0fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Expected Obj, but got Unknown
		//IL_0fd9: Expected Obj, but got VT
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Expected Obj, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Expected VT, but got Unknown
		//IL_1035: Expected Obj, but got VT
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1043: Expected Obj, but got Unknown
		//IL_1067: Expected Obj, but got VT
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_1098: Expected Obj, but got Unknown
		//IL_10bc: Expected Obj, but got VT
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ca: Expected Obj, but got Unknown
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Expected VT, but got Unknown
		//IL_111d: Expected Obj, but got VT
		//IL_1126: Unknown result type (might be due to invalid IL or missing references)
		//IL_112b: Expected Obj, but got Unknown
		//IL_114f: Expected Obj, but got VT
		//IL_117b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1180: Expected Obj, but got Unknown
		//IL_11a4: Expected Obj, but got VT
		//IL_11ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b2: Expected Obj, but got Unknown
		//IL_11dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e2: Expected VT, but got Unknown
		//IL_1281: Expected Obj, but got VT
		//IL_128a: Unknown result type (might be due to invalid IL or missing references)
		//IL_128f: Expected Obj, but got Unknown
		//IL_12b3: Expected Obj, but got VT
		//IL_12df: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e4: Expected Obj, but got Unknown
		//IL_1308: Expected Obj, but got VT
		//IL_1311: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Expected Obj, but got Unknown
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_1346: Expected VT, but got Unknown
		//IL_1369: Expected Obj, but got VT
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_1377: Expected Obj, but got Unknown
		//IL_139b: Expected Obj, but got VT
		//IL_13c5: Expected F4, but got I
		//IL_13c0: Expected native int or pointer, but got VT
		//IL_13cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d4: Expected Obj, but got Unknown
		//IL_13f8: Expected Obj, but got VT
		//IL_1401: Unknown result type (might be due to invalid IL or missing references)
		//IL_1406: Expected Obj, but got Unknown
		//IL_1430: Expected F4, but got I
		//IL_142b: Expected native int or pointer, but got VT
		//IL_145c: Expected Obj, but got I4
		//IL_1790: Expected Obj, but got I4
		//IL_1495: Expected I4, but got F8
		//IL_14dc: Expected I4, but got F8
		object obj = default;
		Color color = (Color)(obj - 640);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		int width = ((!(num < 2147483648.0)) ? int.MinValue : ((int)num2));
		fillGraySprite.width = width;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+68]");
		float num3 = 0f + 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num5 = default;
		double num4 = Math.Abs(num5);
		int height = ((!(num4 < 2147483648.0)) ? int.MinValue : ((int)num5));
		fillGraySprite.height = height;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num7 = default;
		double num6 = Math.Abs(num7);
		int width2 = ((!(num6 < 2147483648.0)) ? int.MinValue : ((int)num7));
		fillColorSprite.width = width2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+74]");
		float num8 = 0f + 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num10 = default;
		double num9 = Math.Abs(num10);
		int height2 = ((!(num9 < 2147483648.0)) ? int.MinValue : ((int)num10));
		fillColorSprite.height = height2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num12 = default;
		double num11 = Math.Abs(num12);
		int width3 = ((!(num11 < 2147483648.0)) ? int.MinValue : ((int)num12));
		outlineSprite.width = width3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+80]");
		float num13 = 0f + 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num15 = default;
		double num14 = Math.Abs(num15);
		int height3 = ((!(num14 < 2147483648.0)) ? int.MinValue : ((int)num15));
		outlineSprite.height = height3;
		float num16 = (float)originalContentPosition + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+8C]");
		float num17 = 0f + 6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+90]");
		float num18 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+278]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+270]");
		_ = 0;
		Vector3 localPosition = (Vector3)(color + 312);
		content.localPosition = localPosition;
		fillColorSprite.spriteName = "button_fill_shopItem_highlight_sale";
		fillGraySprite.spriteName = "button_fill_shopItem_main_sale";
		GameObject gameObject = limitedTitle.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = limitedTime.gameObject;
		gameObject2.SetActive(value: true);
		limitedTitle.enabled = true;
		limitedTime.enabled = true;
		discountSticker.enabled = true;
		GameObject gameObject3 = discountSticker.gameObject;
		gameObject3.SetActive(value: true);
		discountLabelSingleLine.enabled = true;
		GameObject gameObject4 = discountLabelSingleLine.gameObject;
		gameObject4.SetActive(value: true);
		string text = Strings.Get(StringID.DISCOUNT_BUTTON_COOL_DEAL_SINGLE_LINE);
		discountLabelSingleLine.text = text;
		Transform transform = price.transform;
		float num19 = (float)originalPricePosition + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+5C]");
		float num20 = 0f + 6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+60]");
		float num21 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+268]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+260]");
		_ = 0;
		Vector3 localPosition2 = (Vector3)(color + 296);
		transform.localPosition = localPosition2;
		OnlineSettings instance = OnlineSettings.instance;
		string defaultValue = Strings.Get(StringID.DISCOUNT_BUTTON_COOL_SPACIAL_DEAL);
		string value = instance.GetValue("discount_deal_name", defaultValue);
		title.text = value;
		description1.text = sendDescription;
		Transform cachedTransform = description1.cachedTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+54]");
		_ = 0;
		_ = originalDescriptionPosition;
		Vector3 localPosition3 = (Vector3)(color + 280);
		cachedTransform.localPosition = localPosition3;
		description2.enabled = true;
		description2.text = sendDescription2;
		object obj2 = titleColor >> 16;
		object obj3 = obj2 & 0xFF;
		float num22 = (float)obj3 / 255f;
		object obj4 = titleColor >> 24;
		float num23 = (float)obj4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+258]");
		_ = 0;
		object obj5 = titleColor & 0xFF;
		float num24 = (float)obj5 / 255f;
		object obj6 = titleColor >> 8;
		object obj7 = obj6 & 0xFF;
		float num25 = (float)obj7 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+250]");
		_ = 0;
		Color color2 = color + 264;
		title.color = color2;
		object obj8 = titleColorShadow >> 16;
		object obj9 = obj8 & 0xFF;
		float num26 = (float)obj9 / 255f;
		object obj10 = titleColorShadow >> 24;
		float num27 = (float)obj10 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+248]");
		_ = 0;
		object obj11 = titleColorShadow & 0xFF;
		float num28 = (float)obj11 / 255f;
		object obj12 = titleColorShadow >> 8;
		object obj13 = obj12 & 0xFF;
		float num29 = (float)obj13 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+240]");
		_ = 0;
		Color effectColor = color + 248;
		title.effectColor = effectColor;
		_ = titleShadowPosition;
		_ = titleShadowPosition;
		Vector2 effectDistance = (Vector2)(color + 240);
		title.effectDistance = effectDistance;
		object obj14 = description1ColorInactive >> 16;
		object obj15 = obj14 & 0xFF;
		float num30 = (float)obj15 / 255f;
		object obj16 = description1ColorInactive >> 24;
		float num31 = (float)obj16 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+230]");
		_ = 0;
		object obj17 = description1ColorInactive & 0xFF;
		float num32 = (float)obj17 / 255f;
		object obj18 = description1ColorInactive >> 8;
		object obj19 = obj18 & 0xFF;
		float num33 = (float)obj19 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+228]");
		_ = 0;
		Color color3 = color + 224;
		description1.color = color3;
		object obj20 = description1ColorShadowInactive >> 16;
		object obj21 = obj20 & 0xFF;
		float num34 = (float)obj21 / 255f;
		object obj22 = description1ColorShadowInactive >> 24;
		float num35 = (float)obj22 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+220]");
		_ = 0;
		object obj23 = description1ColorShadowInactive & 0xFF;
		float num36 = (float)obj23 / 255f;
		object obj24 = description1ColorShadowInactive >> 8;
		object obj25 = obj24 & 0xFF;
		float num37 = (float)obj25 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+218]");
		_ = 0;
		Color effectColor2 = color + 208;
		description1.effectColor = effectColor2;
		object obj26 = description2Color >> 16;
		object obj27 = obj26 & 0xFF;
		float num38 = (float)obj27 / 255f;
		object obj28 = description2Color >> 24;
		float num39 = (float)obj28 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+210]");
		_ = 0;
		object obj29 = description2Color & 0xFF;
		float num40 = (float)obj29 / 255f;
		object obj30 = description2Color >> 8;
		object obj31 = obj30 & 0xFF;
		float num41 = (float)obj31 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+208]");
		_ = 0;
		Color color4 = color + 192;
		description2.color = color4;
		object obj32 = description2ColorShadow >> 16;
		object obj33 = obj32 & 0xFF;
		float num42 = (float)obj33 / 255f;
		object obj34 = description2ColorShadow >> 24;
		float num43 = (float)obj34 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+200]");
		_ = 0;
		object obj35 = description2ColorShadow & 0xFF;
		float num44 = (float)obj35 / 255f;
		object obj36 = description2ColorShadow >> 8;
		object obj37 = obj36 & 0xFF;
		float num45 = (float)obj37 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1F8]");
		_ = 0;
		Color effectColor3 = color + 176;
		description2.effectColor = effectColor3;
		object obj38 = priceColor >> 16;
		object obj39 = obj38 & 0xFF;
		float num46 = (float)obj39 / 255f;
		object obj40 = priceColor >> 24;
		float num47 = (float)obj40 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1F0]");
		_ = 0;
		object obj41 = priceColor & 0xFF;
		float num48 = (float)obj41 / 255f;
		object obj42 = priceColor >> 8;
		object obj43 = obj42 & 0xFF;
		float num49 = (float)obj43 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1E8]");
		_ = 0;
		Color color5 = color + 160;
		price.color = color5;
		object obj44 = priceColorShadow >> 16;
		object obj45 = obj44 & 0xFF;
		float num50 = (float)obj45 / 255f;
		object obj46 = priceColorShadow >> 24;
		float num51 = (float)obj46 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1E0]");
		_ = 0;
		object obj47 = priceColorShadow & 0xFF;
		float num52 = (float)obj47 / 255f;
		object obj48 = priceColorShadow >> 8;
		object obj49 = obj48 & 0xFF;
		float num53 = (float)obj49 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1D8]");
		_ = 0;
		Color effectColor4 = color + 144;
		price.effectColor = effectColor4;
		object obj50 = limitedTimerColor >> 16;
		object obj51 = obj50 & 0xFF;
		float num54 = (float)obj51 / 255f;
		object obj52 = limitedTimerColor >> 24;
		float num55 = (float)obj52 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1D0]");
		_ = 0;
		object obj53 = limitedTimerColor & 0xFF;
		float num56 = (float)obj53 / 255f;
		object obj54 = limitedTimerColor >> 8;
		object obj55 = obj54 & 0xFF;
		float num57 = (float)obj55 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1C8]");
		_ = 0;
		Color color6 = color + 128;
		limitedTitle.color = color6;
		object obj56 = limitedTimerColorShadow >> 16;
		object obj57 = obj56 & 0xFF;
		float num58 = (float)obj57 / 255f;
		object obj58 = limitedTimerColorShadow >> 24;
		float num59 = (float)obj58 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1C0]");
		_ = 0;
		object obj59 = limitedTimerColorShadow & 0xFF;
		float num60 = (float)obj59 / 255f;
		object obj60 = limitedTimerColorShadow >> 8;
		object obj61 = obj60 & 0xFF;
		float num61 = (float)obj61 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1B8]");
		_ = 0;
		Color effectColor5 = color + 112;
		limitedTitle.effectColor = effectColor5;
		object obj62 = limitedTimerColor >> 16;
		object obj63 = obj62 & 0xFF;
		float num62 = (float)obj63 / 255f;
		object obj64 = limitedTimerColor >> 24;
		float num63 = (float)obj64 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1B0]");
		_ = 0;
		object obj65 = limitedTimerColor & 0xFF;
		float num64 = (float)obj65 / 255f;
		object obj66 = limitedTimerColor >> 8;
		object obj67 = obj66 & 0xFF;
		float num65 = (float)obj67 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1A8]");
		_ = 0;
		Color color7 = color + 96;
		limitedTime.color = color7;
		object obj68 = limitedTimerColorShadow >> 16;
		object obj69 = obj68 & 0xFF;
		float num66 = (float)obj69 / 255f;
		object obj70 = limitedTimerColorShadow >> 24;
		float num67 = (float)obj70 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1A0]");
		_ = 0;
		object obj71 = limitedTimerColorShadow & 0xFF;
		float num68 = (float)obj71 / 255f;
		object obj72 = limitedTimerColorShadow >> 8;
		object obj73 = obj72 & 0xFF;
		float num69 = (float)obj73 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+198]");
		_ = 0;
		Color effectColor6 = color + 80;
		limitedTime.effectColor = effectColor6;
		object obj74 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR >> 16;
		object obj75 = obj74 & 0xFF;
		float num70 = (float)obj75 / 255f;
		object obj76 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR >> 24;
		float num71 = (float)obj76 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+190]");
		_ = 0;
		object obj77 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR & 0xFF;
		float num72 = (float)obj77 / 255f;
		object obj78 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR >> 8;
		object obj79 = obj78 & 0xFF;
		float num73 = (float)obj79 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		Color color8 = color - -64;
		discountSticker.color = color8;
		object obj80 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 16;
		object obj81 = obj80 & 0xFF;
		float num74 = (float)obj81 / 255f;
		object obj82 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 24;
		float num75 = (float)obj82 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+180]");
		_ = 0;
		object obj83 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR & 0xFF;
		float num76 = (float)obj83 / 255f;
		object obj84 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 8;
		object obj85 = obj84 & 0xFF;
		float num77 = (float)obj85 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+178]");
		_ = 0;
		Color color9 = color + 48;
		discountLabel.color = color9;
		object obj86 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 16;
		object obj87 = obj86 & 0xFF;
		float num78 = (float)obj87 / 255f;
		object obj88 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 24;
		float num79 = (float)obj88 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+170]");
		_ = 0;
		object obj89 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR & 0xFF;
		float num80 = (float)obj89 / 255f;
		object obj90 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 8;
		object obj91 = obj90 & 0xFF;
		float num81 = (float)obj91 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+168]");
		_ = 0;
		Color color10 = color + 32;
		discountLabelSingleLine.color = color10;
		if (lineThrough != null && lineThroughShadow != null)
		{
			lineThrough.enabled = true;
			lineThroughShadow.enabled = true;
			object obj92 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_COLOR >> 16;
			object obj93 = obj92 & 0xFF;
			float num82 = (float)obj93 / 255f;
			object obj94 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_COLOR >> 24;
			float num83 = (float)obj94 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+160]");
			_ = 0;
			object obj95 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_COLOR & 0xFF;
			float num84 = (float)obj95 / 255f;
			object obj96 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_COLOR >> 8;
			object obj97 = obj96 & 0xFF;
			float num85 = (float)obj97 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+158]");
			_ = 0;
			Color color11 = color + 16;
			lineThrough.color = color11;
			object obj98 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_SHADOW_COLOR >> 16;
			object obj99 = obj98 & 0xFF;
			float num86 = (float)obj99 / 255f;
			object obj100 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_SHADOW_COLOR >> 24;
			float num87 = (float)obj100 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+150]");
			((Color*)(nint)color)->b = 0f;
			object obj101 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_SHADOW_COLOR & 0xFF;
			float num88 = (float)obj101 / 255f;
			object obj102 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_SHADOW_COLOR >> 8;
			object obj103 = obj102 & 0xFF;
			float num89 = (float)obj103 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
			((Color*)(nint)color)->r = 0f;
			lineThroughShadow.color = color;
			UILabel uILabel = description1;
			object obj104 = ((UIWidget)uILabel).mWidth + 6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num91 = default;
			double num90 = Math.Abs(num91);
			int width4 = ((!(num90 < 2147483648.0)) ? int.MinValue : ((int)num91));
			lineThrough.width = width4;
			UILabel uILabel2 = description1;
			object obj105 = ((UIWidget)uILabel2).mWidth + 6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num93 = default;
			double num92 = Math.Abs(num93);
			int width5 = ((!(num92 < 2147483648.0)) ? int.MinValue : ((int)num93));
			lineThroughShadow.width = width5;
			DeviceInfo instance2 = DeviceInfo.Instance;
			if (~(instance2.isHighres__BackingField ? 1u : 0u) == 0)
			{
				lineThrough.spriteName = "sale_strikeover_hi";
				lineThroughShadow.spriteName = "sale_strikeover_hi";
			}
			else
			{
				lineThrough.spriteName = "sale_strikeover_lo";
				lineThroughShadow.spriteName = "sale_strikeover_lo";
			}
		}
		iconBG.spriteName = "icon_background_theme";
		Common(productString);
	}

	protected unsafe virtual void ShowOnSale(string productString, string sendDescription = "")
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0047: Expected I4, but got F8
		//IL_008e: Expected I4, but got F8
		//IL_00d5: Expected I4, but got F8
		//IL_011c: Expected I4, but got F8
		//IL_0163: Expected I4, but got F8
		//IL_12a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ad: Expected VT, but got Unknown
		//IL_01aa: Expected I4, but got F8
		//IL_12ec: Expected Obj, but got I4
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Expected I4, but got Unknown
		//IL_1307: Unknown result type (might be due to invalid IL or missing references)
		//IL_130c: Expected I4, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected VT, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected VT, but got Unknown
		//IL_04ea: Expected Obj, but got I4
		//IL_04ce: Expected Obj, but got I4
		//IL_135a: Expected Obj, but got VT
		//IL_1363: Unknown result type (might be due to invalid IL or missing references)
		//IL_1368: Expected Obj, but got Unknown
		//IL_138d: Expected Obj, but got VT
		//IL_13ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bf: Expected Obj, but got Unknown
		//IL_13e4: Expected Obj, but got VT
		//IL_13ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f2: Expected Obj, but got Unknown
		//IL_141d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1422: Expected VT, but got Unknown
		//IL_1441: Expected Obj, but got VT
		//IL_144a: Unknown result type (might be due to invalid IL or missing references)
		//IL_144f: Expected Obj, but got Unknown
		//IL_1474: Expected Obj, but got VT
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a6: Expected Obj, but got Unknown
		//IL_14cb: Expected Obj, but got VT
		//IL_14d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d9: Expected Obj, but got Unknown
		//IL_1504: Unknown result type (might be due to invalid IL or missing references)
		//IL_1509: Expected VT, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected VT, but got Unknown
		//IL_0560: Expected Obj, but got VT
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_0593: Expected Obj, but got VT
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05ea: Expected Obj, but got VT
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected VT, but got Unknown
		//IL_064c: Expected Obj, but got VT
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_067f: Expected Obj, but got VT
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected Obj, but got Unknown
		//IL_06d6: Expected Obj, but got VT
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected Obj, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected VT, but got Unknown
		//IL_0733: Expected Obj, but got VT
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_0766: Expected Obj, but got VT
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected Obj, but got Unknown
		//IL_07bd: Expected Obj, but got VT
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected Obj, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected VT, but got Unknown
		//IL_081f: Expected Obj, but got VT
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected Obj, but got Unknown
		//IL_0852: Expected Obj, but got VT
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected Obj, but got Unknown
		//IL_08a9: Expected Obj, but got VT
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected Obj, but got Unknown
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected VT, but got Unknown
		//IL_0906: Expected Obj, but got VT
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_0939: Expected Obj, but got VT
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected Obj, but got Unknown
		//IL_0990: Expected Obj, but got VT
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected Obj, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected VT, but got Unknown
		//IL_09f2: Expected Obj, but got VT
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected Obj, but got Unknown
		//IL_0a25: Expected Obj, but got VT
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Expected Obj, but got Unknown
		//IL_0a7c: Expected Obj, but got VT
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected Obj, but got Unknown
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected VT, but got Unknown
		//IL_0ad9: Expected Obj, but got VT
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Expected Obj, but got Unknown
		//IL_0b0c: Expected Obj, but got VT
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected Obj, but got Unknown
		//IL_0b63: Expected Obj, but got VT
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected Obj, but got Unknown
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected VT, but got Unknown
		//IL_0bc5: Expected Obj, but got VT
		//IL_0bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Expected Obj, but got Unknown
		//IL_0bf8: Expected Obj, but got VT
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected Obj, but got Unknown
		//IL_0c4f: Expected Obj, but got VT
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5d: Expected Obj, but got Unknown
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Expected VT, but got Unknown
		//IL_0cac: Expected Obj, but got VT
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected Obj, but got Unknown
		//IL_0cdf: Expected Obj, but got VT
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Expected Obj, but got Unknown
		//IL_0d36: Expected Obj, but got VT
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected Obj, but got Unknown
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Expected VT, but got Unknown
		//IL_0d98: Expected Obj, but got VT
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected Obj, but got Unknown
		//IL_0dcb: Expected Obj, but got VT
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfd: Expected Obj, but got Unknown
		//IL_0e22: Expected Obj, but got VT
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Expected Obj, but got Unknown
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Expected VT, but got Unknown
		//IL_0e83: Expected Obj, but got VT
		//IL_0e8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e91: Expected Obj, but got Unknown
		//IL_0eb5: Expected Obj, but got VT
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee6: Expected Obj, but got Unknown
		//IL_0f0a: Expected Obj, but got VT
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f18: Expected Obj, but got Unknown
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected VT, but got Unknown
		//IL_0f66: Expected Obj, but got VT
		//IL_0f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f74: Expected Obj, but got Unknown
		//IL_0f98: Expected Obj, but got VT
		//IL_0fc2: Expected F4, but got I
		//IL_0fbd: Expected native int or pointer, but got VT
		//IL_0fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd1: Expected Obj, but got Unknown
		//IL_0ff5: Expected Obj, but got VT
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Expected Obj, but got Unknown
		//IL_102d: Expected F4, but got I
		//IL_1028: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 544);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		int width = ((!(num < 2147483648.0)) ? int.MinValue : ((int)num2));
		fillGraySprite.width = width;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+68]");
		float num3 = 0f + 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num5 = default;
		double num4 = Math.Abs(num5);
		int height = ((!(num4 < 2147483648.0)) ? int.MinValue : ((int)num5));
		fillGraySprite.height = height;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num7 = default;
		double num6 = Math.Abs(num7);
		int width2 = ((!(num6 < 2147483648.0)) ? int.MinValue : ((int)num7));
		fillColorSprite.width = width2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+74]");
		float num8 = 0f + 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num10 = default;
		double num9 = Math.Abs(num10);
		int height2 = ((!(num9 < 2147483648.0)) ? int.MinValue : ((int)num10));
		fillColorSprite.height = height2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num12 = default;
		double num11 = Math.Abs(num12);
		int width3 = ((!(num11 < 2147483648.0)) ? int.MinValue : ((int)num12));
		outlineSprite.width = width3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+80]");
		float num13 = 0f + 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num15 = default;
		double num14 = Math.Abs(num15);
		int height3 = ((!(num14 < 2147483648.0)) ? int.MinValue : ((int)num15));
		outlineSprite.height = height3;
		float num16 = (float)originalContentPosition + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+8C]");
		float num17 = 0f + 6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+90]");
		float num18 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+218]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+210]");
		_ = 0;
		Vector3 localPosition = (Vector3)(color + 264);
		content.localPosition = localPosition;
		fillColorSprite.spriteName = "button_fill_shopItem_highlight_sale";
		fillGraySprite.spriteName = "button_fill_shopItem_main_sale";
		GameObject gameObject = limitedTitle.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = limitedTime.gameObject;
		gameObject2.SetActive(value: true);
		limitedTitle.enabled = true;
		limitedTime.enabled = true;
		discountSticker.enabled = true;
		GameObject gameObject3 = discountSticker.gameObject;
		gameObject3.SetActive(value: true);
		discountLabel.enabled = true;
		GameObject gameObject4 = discountLabel.gameObject;
		gameObject4.SetActive(value: true);
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(productString);
		string inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId(inAppItemModel.NormalOfferId__BackingField);
		int discountValue = InAppManager.GetDiscountValue(inAppOnlineSettingsId, 0);
		int num19 = discountValue >> 31;
		object obj2 = discountValue + num19;
		int num20 = obj2 ^ num19;
		int num21 = (int)(color + 540);
		string text = ((int*)num21)->ToString();
		string text2 = Strings.Get(StringID.DISCOUNT_BUTTON_COOL_OFF);
		string text3 = text + text2;
		discountLabel.text = text3;
		Transform transform = price.transform;
		float num22 = (float)originalPricePosition + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+5C]");
		float num23 = 0f + 6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+60]");
		float num24 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+208]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+200]");
		_ = 0;
		Vector3 localPosition2 = (Vector3)(color + 248);
		transform.localPosition = localPosition2;
		OnlineSettings instance = OnlineSettings.instance;
		string defaultValue = Strings.Get(StringID.DISCOUNT_BUTTON_COOL_SPACIAL_DEAL);
		string value = instance.GetValue("discount_deal_name", defaultValue);
		title.text = value;
		InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item(productString);
		description1.text = inAppItemModel2.DisplayName__BackingField;
		Transform cachedTransform = description1.cachedTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+54]");
		_ = 0;
		_ = originalDescriptionPosition;
		Vector3 localPosition3 = (Vector3)(color + 232);
		cachedTransform.localPosition = localPosition3;
		description2.enabled = true;
		InAppItemModel inAppItemModel3 = InAppData.inAppData.get_Item(productString);
		string text4 = inAppItemModel3.DisplayText__BackingField;
		object obj3;
		if (inAppItemModel3.DisplayText__BackingField != null)
		{
			obj3 = 0;
			if (text4._stringLength != 0)
			{
				goto IL_131e;
			}
		}
		obj3 = 1;
		goto IL_131e;
		IL_131e:
		string text5;
		if (obj3 != null)
		{
			text5 = sendDescription;
		}
		else
		{
			InAppItemModel inAppItemModel4 = InAppData.inAppData.get_Item(productString);
			text5 = inAppItemModel4.DisplayText__BackingField;
		}
		description2.text = text5;
		object obj4 = titleColor >> 16;
		object obj5 = obj4 & 0xFF;
		float num25 = (float)obj5 / 255f;
		object obj6 = titleColor >> 24;
		float num26 = (float)obj6 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1F8]");
		_ = 0;
		object obj7 = titleColor & 0xFF;
		float num27 = (float)obj7 / 255f;
		object obj8 = titleColor >> 8;
		object obj9 = obj8 & 0xFF;
		float num28 = (float)obj9 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1F0]");
		_ = 0;
		Color color2 = color + 216;
		title.color = color2;
		object obj10 = titleColorShadow >> 16;
		object obj11 = obj10 & 0xFF;
		float num29 = (float)obj11 / 255f;
		object obj12 = titleColorShadow >> 24;
		float num30 = (float)obj12 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1E8]");
		_ = 0;
		object obj13 = titleColorShadow & 0xFF;
		float num31 = (float)obj13 / 255f;
		object obj14 = titleColorShadow >> 8;
		object obj15 = obj14 & 0xFF;
		float num32 = (float)obj15 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1E0]");
		_ = 0;
		Color effectColor = color + 200;
		title.effectColor = effectColor;
		_ = titleShadowPosition;
		_ = titleShadowPosition;
		Vector2 effectDistance = (Vector2)(color + 192);
		title.effectDistance = effectDistance;
		object obj16 = description1ColorActive >> 16;
		object obj17 = obj16 & 0xFF;
		float num33 = (float)obj17 / 255f;
		object obj18 = description1ColorActive >> 24;
		float num34 = (float)obj18 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1D0]");
		_ = 0;
		object obj19 = description1ColorActive & 0xFF;
		float num35 = (float)obj19 / 255f;
		object obj20 = description1ColorActive >> 8;
		object obj21 = obj20 & 0xFF;
		float num36 = (float)obj21 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1C8]");
		_ = 0;
		Color color3 = color + 176;
		description1.color = color3;
		object obj22 = description1ColorShadowActive >> 16;
		object obj23 = obj22 & 0xFF;
		float num37 = (float)obj23 / 255f;
		object obj24 = description1ColorShadowActive >> 24;
		float num38 = (float)obj24 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1C0]");
		_ = 0;
		object obj25 = description1ColorShadowActive & 0xFF;
		float num39 = (float)obj25 / 255f;
		object obj26 = description1ColorShadowActive >> 8;
		object obj27 = obj26 & 0xFF;
		float num40 = (float)obj27 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1B8]");
		_ = 0;
		Color effectColor2 = color + 160;
		description1.effectColor = effectColor2;
		object obj28 = description2Color >> 16;
		object obj29 = obj28 & 0xFF;
		float num41 = (float)obj29 / 255f;
		object obj30 = description2Color >> 24;
		float num42 = (float)obj30 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1B0]");
		_ = 0;
		object obj31 = description2Color & 0xFF;
		float num43 = (float)obj31 / 255f;
		object obj32 = description2Color >> 8;
		object obj33 = obj32 & 0xFF;
		float num44 = (float)obj33 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1A8]");
		_ = 0;
		Color color4 = color + 144;
		description2.color = color4;
		object obj34 = description2ColorShadow >> 16;
		object obj35 = obj34 & 0xFF;
		float num45 = (float)obj35 / 255f;
		object obj36 = description2ColorShadow >> 24;
		float num46 = (float)obj36 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+1A0]");
		_ = 0;
		object obj37 = description2ColorShadow & 0xFF;
		float num47 = (float)obj37 / 255f;
		object obj38 = description2ColorShadow >> 8;
		object obj39 = obj38 & 0xFF;
		float num48 = (float)obj39 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+198]");
		_ = 0;
		Color effectColor3 = color + 128;
		description2.effectColor = effectColor3;
		object obj40 = priceColor >> 16;
		object obj41 = obj40 & 0xFF;
		float num49 = (float)obj41 / 255f;
		object obj42 = priceColor >> 24;
		float num50 = (float)obj42 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+190]");
		_ = 0;
		object obj43 = priceColor & 0xFF;
		float num51 = (float)obj43 / 255f;
		object obj44 = priceColor >> 8;
		object obj45 = obj44 & 0xFF;
		float num52 = (float)obj45 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		Color color5 = color + 112;
		price.color = color5;
		object obj46 = priceColorShadow >> 16;
		object obj47 = obj46 & 0xFF;
		float num53 = (float)obj47 / 255f;
		object obj48 = priceColorShadow >> 24;
		float num54 = (float)obj48 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+180]");
		_ = 0;
		object obj49 = priceColorShadow & 0xFF;
		float num55 = (float)obj49 / 255f;
		object obj50 = priceColorShadow >> 8;
		object obj51 = obj50 & 0xFF;
		float num56 = (float)obj51 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+178]");
		_ = 0;
		Color effectColor4 = color + 96;
		price.effectColor = effectColor4;
		object obj52 = limitedTimerColor >> 16;
		object obj53 = obj52 & 0xFF;
		float num57 = (float)obj53 / 255f;
		object obj54 = limitedTimerColor >> 24;
		float num58 = (float)obj54 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+170]");
		_ = 0;
		object obj55 = limitedTimerColor & 0xFF;
		float num59 = (float)obj55 / 255f;
		object obj56 = limitedTimerColor >> 8;
		object obj57 = obj56 & 0xFF;
		float num60 = (float)obj57 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+168]");
		_ = 0;
		Color color6 = color + 80;
		limitedTitle.color = color6;
		object obj58 = limitedTimerColorShadow >> 16;
		object obj59 = obj58 & 0xFF;
		float num61 = (float)obj59 / 255f;
		object obj60 = limitedTimerColorShadow >> 24;
		float num62 = (float)obj60 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+160]");
		_ = 0;
		object obj61 = limitedTimerColorShadow & 0xFF;
		float num63 = (float)obj61 / 255f;
		object obj62 = limitedTimerColorShadow >> 8;
		object obj63 = obj62 & 0xFF;
		float num64 = (float)obj63 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+158]");
		_ = 0;
		Color effectColor5 = color - -64;
		limitedTitle.effectColor = effectColor5;
		object obj64 = limitedTimerColor >> 16;
		object obj65 = obj64 & 0xFF;
		float num65 = (float)obj65 / 255f;
		object obj66 = limitedTimerColor >> 24;
		float num66 = (float)obj66 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+150]");
		_ = 0;
		object obj67 = limitedTimerColor & 0xFF;
		float num67 = (float)obj67 / 255f;
		object obj68 = limitedTimerColor >> 8;
		object obj69 = obj68 & 0xFF;
		float num68 = (float)obj69 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Color color7 = color + 48;
		limitedTime.color = color7;
		object obj70 = limitedTimerColorShadow >> 16;
		object obj71 = obj70 & 0xFF;
		float num69 = (float)obj71 / 255f;
		object obj72 = limitedTimerColorShadow >> 24;
		float num70 = (float)obj72 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+140]");
		_ = 0;
		object obj73 = limitedTimerColorShadow & 0xFF;
		float num71 = (float)obj73 / 255f;
		object obj74 = limitedTimerColorShadow >> 8;
		object obj75 = obj74 & 0xFF;
		float num72 = (float)obj75 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+138]");
		_ = 0;
		Color effectColor6 = color + 32;
		limitedTime.effectColor = effectColor6;
		object obj76 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR >> 16;
		object obj77 = obj76 & 0xFF;
		float num73 = (float)obj77 / 255f;
		object obj78 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR >> 24;
		float num74 = (float)obj78 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+130]");
		_ = 0;
		object obj79 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR & 0xFF;
		float num75 = (float)obj79 / 255f;
		object obj80 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR >> 8;
		object obj81 = obj80 & 0xFF;
		float num76 = (float)obj81 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+128]");
		_ = 0;
		Color color8 = color + 16;
		discountSticker.color = color8;
		object obj82 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 16;
		object obj83 = obj82 & 0xFF;
		float num77 = (float)obj83 / 255f;
		object obj84 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 24;
		float num78 = (float)obj84 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+120]");
		((Color*)(nint)color)->b = 0f;
		object obj85 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR & 0xFF;
		float num79 = (float)obj85 / 255f;
		object obj86 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 8;
		object obj87 = obj86 & 0xFF;
		float num80 = (float)obj87 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+118]");
		((Color*)(nint)color)->r = 0f;
		discountLabel.color = color;
		if (lineThrough != null && lineThroughShadow != null)
		{
			lineThrough.enabled = false;
			lineThroughShadow.enabled = false;
		}
		iconBG.spriteName = "icon_background_theme";
		Common(productString);
	}

	protected unsafe virtual void ShowNoDiscount(string productString, string backupDescription = "")
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0047: Expected I4, but got F8
		//IL_008e: Expected I4, but got F8
		//IL_00d5: Expected I4, but got F8
		//IL_011c: Expected I4, but got F8
		//IL_0163: Expected I4, but got F8
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected VT, but got Unknown
		//IL_01aa: Expected I4, but got F8
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected VT, but got Unknown
		//IL_03b0: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got I4
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected VT, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected VT, but got Unknown
		//IL_0922: Expected Obj, but got VT
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_0955: Expected Obj, but got VT
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected Obj, but got Unknown
		//IL_09ac: Expected Obj, but got VT
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected Obj, but got Unknown
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected VT, but got Unknown
		//IL_0a09: Expected Obj, but got VT
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected Obj, but got Unknown
		//IL_0a3c: Expected Obj, but got VT
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected Obj, but got Unknown
		//IL_0a93: Expected Obj, but got VT
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Expected Obj, but got Unknown
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected VT, but got Unknown
		//IL_0560: Expected Obj, but got VT
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_0593: Expected Obj, but got VT
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05ea: Expected Obj, but got VT
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected VT, but got Unknown
		//IL_0647: Expected Obj, but got VT
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected Obj, but got Unknown
		//IL_067a: Expected Obj, but got VT
		//IL_06a4: Expected F4, but got I
		//IL_069f: Expected native int or pointer, but got VT
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected Obj, but got Unknown
		//IL_06d9: Expected Obj, but got VT
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_0711: Expected F4, but got I
		//IL_070c: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 208);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		int width = ((!(num < 2147483648.0)) ? int.MinValue : ((int)num2));
		fillGraySprite.width = width;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num4 = default;
		double num3 = Math.Abs(num4);
		int height = ((!(num3 < 2147483648.0)) ? int.MinValue : ((int)num4));
		fillGraySprite.height = height;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num6 = default;
		double num5 = Math.Abs(num6);
		int width2 = ((!(num5 < 2147483648.0)) ? int.MinValue : ((int)num6));
		fillColorSprite.width = width2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num8 = default;
		double num7 = Math.Abs(num8);
		int height2 = ((!(num7 < 2147483648.0)) ? int.MinValue : ((int)num8));
		fillColorSprite.height = height2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num10 = default;
		double num9 = Math.Abs(num10);
		int width3 = ((!(num9 < 2147483648.0)) ? int.MinValue : ((int)num10));
		outlineSprite.width = width3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num12 = default;
		double num11 = Math.Abs(num12);
		int height3 = ((!(num11 < 2147483648.0)) ? int.MinValue : ((int)num12));
		outlineSprite.height = height3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+90]");
		_ = 0;
		_ = originalContentPosition;
		Vector3 localPosition = (Vector3)(color + 112);
		content.localPosition = localPosition;
		fillColorSprite.spriteName = originalFillColorSpirteName;
		fillGraySprite.spriteName = originalFillGraySpriteName;
		GameObject gameObject = limitedTitle.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = limitedTime.gameObject;
		gameObject2.SetActive(value: false);
		limitedTitle.enabled = false;
		limitedTime.enabled = false;
		discountSticker.enabled = false;
		discountLabel.enabled = false;
		GameObject gameObject3 = discountSticker.gameObject;
		gameObject3.SetActive(value: false);
		GameObject gameObject4 = discountLabel.gameObject;
		gameObject4.SetActive(value: false);
		discountLabelSingleLine.enabled = false;
		GameObject gameObject5 = discountLabelSingleLine.gameObject;
		gameObject5.SetActive(value: false);
		Transform transform = price.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+60]");
		_ = 0;
		_ = originalPricePosition;
		Vector3 localPosition2 = (Vector3)(color + 96);
		transform.localPosition = localPosition2;
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(productString);
		title.text = inAppItemModel.DisplayName__BackingField;
		InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item(productString);
		string text = inAppItemModel2.DisplayText__BackingField;
		object obj2;
		if (inAppItemModel2.DisplayText__BackingField != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_087b;
			}
		}
		obj2 = 1;
		goto IL_087b;
		IL_087b:
		string text2;
		if (obj2 != null)
		{
			text2 = backupDescription;
		}
		else
		{
			InAppItemModel inAppItemModel3 = InAppData.inAppData.get_Item(productString);
			text2 = inAppItemModel3.DisplayText__BackingField;
		}
		description1.text = text2;
		_ = 4575657222473777152L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
		_ = 0;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		Color color2 = color + 80;
		description1.color = color2;
		Transform cachedTransform = description1.cachedTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+54]");
		_ = 0;
		_ = originalDescriptionPosition;
		Vector3 localPosition3 = (Vector3)(color - -64);
		cachedTransform.localPosition = localPosition3;
		description2.enabled = false;
		if (lineThrough != null && lineThroughShadow != null)
		{
			lineThrough.enabled = false;
			lineThroughShadow.enabled = false;
		}
		InAppItemModel inAppItemModel4 = InAppData.inAppData.get_Item(productString);
		bool flag = inAppItemModel4.InAppItemType__BackingField != InAppItemModel.ItemType.Coins;
		bool flag2 = !flag;
		object spriteName = "icon_background_normal";
		if (!flag2)
		{
			InAppItemModel inAppItemModel5 = InAppData.inAppData.get_Item(productString);
			bool flag3 = inAppItemModel5.InAppItemType__BackingField == InAppItemModel.ItemType.DoubleCoins;
			object obj3 = "icon_background_normal";
			if (!flag3)
			{
				obj3 = "icon_background_keys";
			}
			spriteName = obj3;
		}
		iconBG.spriteName = (string)spriteName;
		object obj4 = originalTitleColor >> 16;
		object obj5 = obj4 & 0xFF;
		float num13 = (float)obj5 / 255f;
		object obj6 = originalTitleColor >> 24;
		float num14 = (float)obj6 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
		_ = 0;
		object obj7 = originalTitleColor & 0xFF;
		float num15 = (float)obj7 / 255f;
		object obj8 = originalTitleColor >> 8;
		object obj9 = obj8 & 0xFF;
		float num16 = (float)obj9 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
		_ = 0;
		Color color3 = color + 48;
		title.color = color3;
		object obj10 = originalTitleColorShadow >> 16;
		object obj11 = obj10 & 0xFF;
		float num17 = (float)obj11 / 255f;
		object obj12 = originalTitleColorShadow >> 24;
		float num18 = (float)obj12 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
		_ = 0;
		object obj13 = originalTitleColorShadow & 0xFF;
		float num19 = (float)obj13 / 255f;
		object obj14 = originalTitleColorShadow >> 8;
		object obj15 = obj14 & 0xFF;
		float num20 = (float)obj15 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
		_ = 0;
		Color effectColor = color + 32;
		title.effectColor = effectColor;
		object obj16 = originalDescriptionColor >> 16;
		object obj17 = obj16 & 0xFF;
		float num21 = (float)obj17 / 255f;
		object obj18 = originalDescriptionColor >> 24;
		float num22 = (float)obj18 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
		_ = 0;
		object obj19 = originalDescriptionColor & 0xFF;
		float num23 = (float)obj19 / 255f;
		object obj20 = originalDescriptionColor >> 8;
		object obj21 = obj20 & 0xFF;
		float num24 = (float)obj21 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
		_ = 0;
		Color color4 = color + 16;
		description1.color = color4;
		object obj22 = originalDescriptionColorShadow >> 16;
		object obj23 = obj22 & 0xFF;
		float num25 = (float)obj23 / 255f;
		object obj24 = originalDescriptionColorShadow >> 24;
		float num26 = (float)obj24 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
		((Color*)(nint)color)->b = 0f;
		object obj25 = originalDescriptionColorShadow & 0xFF;
		float num27 = (float)obj25 / 255f;
		object obj26 = originalDescriptionColorShadow >> 8;
		object obj27 = obj26 & 0xFF;
		float num28 = (float)obj27 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
		((Color*)(nint)color)->r = 0f;
		description1.effectColor = color;
		Common(productString);
	}

	private void Common(string productString)
	{
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(productString);
		icon.spriteName = inAppItemModel.Icon__BackingField;
		InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item(productString);
		string localizedPrice = inAppItemModel2.LocalizedPrice;
		price.text = localizedPrice;
	}

	public DiscountButton()
	{
		//IL_008e: Expected VT, but got I8
	}
}
