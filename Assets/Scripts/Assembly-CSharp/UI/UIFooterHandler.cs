using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class UIFooterHandler : MonoBehaviour
{
	public UIButtonOverlayOff button0;

	public UIButtonOverlayOff button1;

	public UIButtonOverlayOff button2;

	public UIButtonOverlayOff button3;

	public GameObject boostDiscount;

	public GameObject coinshopDiscount;

	private UISprite[] discountStickers;

	private UILabel[] discountStickerLabels;

	public unsafe void HandleStickers()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_006c: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got VT
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got VT
		//IL_00f7: Expected F4, but got I
		//IL_00f2: Expected native int or pointer, but got VT
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got VT
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0162: Expected F4, but got I
		//IL_015d: Expected native int or pointer, but got VT
		//IL_0177: Expected Obj, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got VT
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got VT
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0260: Expected Obj, but got VT
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected VT, but got Unknown
		//IL_02b3: Expected Obj, but got I
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj + -64);
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		if (!(boostDiscount != null) || !(coinshopDiscount != null))
		{
			return;
		}
		UISprite[] array = discountStickers;
		object obj2 = 0;
		while (array.Length > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)array + obj3;
			object obj5 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR >> 16;
			object obj6 = obj5 & 0xFF;
			float num = (float)obj6 / 255f;
			object obj7 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR >> 24;
			float num2 = (float)obj7 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
			((Color*)(nint)color)->b = 0f;
			object obj8 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR & 0xFF;
			float num3 = (float)obj8 / 255f;
			object obj9 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR >> 8;
			object obj10 = obj9 & 0xFF;
			float num4 = (float)obj10 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
			((Color*)(nint)color)->r = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v91+10]");
			((UIWidget)0).color = color;
			object obj11 = obj2 + 1;
			obj2 = obj11;
		}
		UILabel[] array2 = discountStickerLabels;
		object obj12 = 0;
		while (array2.Length > (nint)obj12)
		{
			object obj13 = obj12 << 2;
			object obj14 = (object)array2 + obj13;
			object obj15 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 16;
			object obj16 = obj15 & 0xFF;
			float num5 = (float)obj16 / 255f;
			object obj17 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 24;
			float num6 = (float)obj17 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
			_ = 0;
			object obj18 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR & 0xFF;
			float num7 = (float)obj18 / 255f;
			object obj19 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR >> 8;
			object obj20 = obj19 & 0xFF;
			float num8 = (float)obj20 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
			_ = 0;
			Color color2 = color + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v77+10]");
			((UIWidget)0).color = color2;
			object obj21 = obj12 + 1;
			obj12 = obj21;
		}
		SSEventsManagerController instance2 = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance2.GetActiveEventManager();
		bool flag;
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj22 = default;
			flag = (nint)obj22 != 4;
		}
		else
		{
			flag = true;
		}
		if (!(topScreenName == "CoinsUI_shop"))
		{
			bool flag2 = topScreenName == "EarnCoinsScreen";
			flag = flag2 & flag;
		}
		bool flag3 = !flag;
		bool active = false;
		if (!flag3)
		{
			bool isDoubleCoinsDiscountActive = InAppManager.IsDoubleCoinsDiscountActive;
			active = isDoubleCoinsDiscountActive;
		}
		bool active2;
		if (!(topScreenName == "UpgradesUI_shop"))
		{
			bool flag4 = topScreenName == "EarnCoinsScreen";
			bool flag5 = !flag4;
			active2 = false;
			if (flag5)
			{
				goto IL_03c5;
			}
		}
		active2 = InAppManager.IsAnyCurrencyDiscountActive;
		goto IL_03c5;
		IL_03c5:
		boostDiscount.SetActive(active);
		coinshopDiscount.SetActive(active2);
	}
}
