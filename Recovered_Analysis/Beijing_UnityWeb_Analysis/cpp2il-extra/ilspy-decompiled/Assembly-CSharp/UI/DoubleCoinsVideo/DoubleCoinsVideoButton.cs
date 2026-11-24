using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UI.Breadcrumbs;
using UnityEngine;

namespace UI.DoubleCoinsVideo;

public class DoubleCoinsVideoButton : DoubleCoinsVideo
{
	private UISprite _bigFill;

	private UISprite _smallFill;

	private UISprite _bigOverlay;

	private UISprite _smallOverlay;

	private UILabel _title;

	private UILabel _subtitle;

	public unsafe override void Setup(DoubleCoinsVideoPayload payload)
	{
		//IL_0186: Expected I4, but got Obj
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected VT, but got Unknown
		//IL_0218: Expected I4, but got Obj
		//IL_0213: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		_amount = (int)payload;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v35 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj2 = (flag ? 1 : 0) + 268;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v8+8]");
		_ = 0;
		Color32 color = (Color32)(obj3 + 16);
		((Color32*)(nint)color)->rgba = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		string text = MiscExtensions.ToHex(color);
		throw new ArrayTypeMismatchException();
	}

	private void SetupBasic()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<GameObject> list = default;
		list._002Ector();
		object obj = this + 52;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public override void SetCoinVisualValue(int coinValue)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I4
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0124: Expected I4, but got Obj
		object obj = this + 12;
		obj = coinValue;
		OnClick();
		DoubleCoinsVideoPayload payload = _payload;
		bool flag = Breadcrumb.CheckNewWeeklyHunt();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v6 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string key = ((payload.coinAmount != (flag ? 1 : 0)) ? "DOUBLE_COINS_VIDEO_UNCAPPED_TITLE" : "DOUBLE_COINS_VIDEO_CAPPED_TITLE");
		string text = Strings.GetDefault(key);
		_title.fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public unsafe void OnClick()
	{
		//IL_031d: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_0375: Expected Obj, but got I4
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected I4, but got Unknown
		//IL_03a5: Expected I4, but got Obj
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_03dd: Expected Obj, but got I4
		//IL_03ff: Expected I4, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0090: Expected I4, but got Obj
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_00ca: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_0126: Expected I4, but got Obj
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I4
		//IL_0180: Expected I4, but got Obj
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I4
		//IL_01df: Expected I4, but got Obj
		//IL_01f5: Expected Obj, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0215: Expected Obj, but got I4
		//IL_0237: Expected I4, but got Obj
		//IL_0266: Expected Obj, but got I4
		//IL_0288: Expected I4, but got Obj
		//IL_029e: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v40 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 128;
		object obj4 = (flag ? 1 : 0) + 108;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 144);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_bigFill.rawPivot = pivot;
		object obj5 = obj3 + 112;
		object obj6 = (flag ? 1 : 0) + 220;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_smallFill.rawPivot = pivot;
		object obj7 = obj3 + 96;
		object obj8 = (flag ? 1 : 0) + 28;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18+8]");
		_ = 0;
		UIEventListener.FloatDelegate floatDelegate = (UIEventListener.FloatDelegate)(obj3 + 80);
		floatDelegate((GameObject)pivot, 0.6f);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)floatDelegate;
		_ = ((Delegate)floatDelegate).method_ptr;
		_bigOverlay.rawPivot = pivot;
		object obj9 = obj3 - -64;
		object obj10 = (flag ? 1 : 0) + 444;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S2_v43+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v28+8]");
		_ = 0;
		_smallOverlay.rawPivot = pivot;
		object obj11 = obj3 + 48;
		object obj12 = (flag ? 1 : 0) + 268;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v54+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v34+8]");
		_ = 0;
		_title.rawPivot = pivot;
		object obj13 = obj3 + 32;
		object obj14 = (flag ? 1 : 0) + 732;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S2_v65+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v40+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		object obj15 = obj3 + 16;
		object obj16 = (flag ? 1 : 0) + 604;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S2_v76+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v46+8]");
		_ = 0;
		_subtitle.rawPivot = pivot;
		object obj17 = (flag ? 1 : 0) + 732;
		obj3 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S2_v86+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
	}

	private unsafe void commercialBreakComplete(bool withReward)
	{
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected VT, but got Unknown
		//IL_0218: Expected I4, but got Obj
		//IL_0213: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		_amount = (withReward ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v35 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj2 = (flag ? 1 : 0) + 268;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v8+8]");
		_ = 0;
		Color32 color = (Color32)(obj3 + 16);
		((Color32*)(nint)color)->rgba = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		string text = MiscExtensions.ToHex(color);
		throw new ArrayTypeMismatchException();
	}

	public override int GetHeight()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = this;
		return num;
	}

	public DoubleCoinsVideoButton()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		object obj3 = (isInitialized ? 1 : 0) + 20;
		obj3 = obj2;
		bool isInitialized2 = AdSystemManager.isInitialized;
		((PokiUnitySDK)isInitialized2).checkInit();
	}
}
