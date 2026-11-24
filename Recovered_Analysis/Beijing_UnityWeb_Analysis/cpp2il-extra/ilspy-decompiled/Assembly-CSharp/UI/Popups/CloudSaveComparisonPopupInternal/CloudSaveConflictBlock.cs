using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UI.Generic;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.Popups.CloudSaveComparisonPopupInternal;

public class CloudSaveConflictBlock : MonoBehaviour
{
	public class ConflictBlockPayload
	{
		public string buttonText;

		public string topSpriteName;

		public bool isImprovement;

		public List<CloudSaveProgressCell.CloudSaveProgressCellPayload> cellPayloads;

		public Action onButtonClicked;

		public void OnButtonClicked()
		{
		}

		public ConflictBlockPayload()
		{
			TransformExtensions.Reset((Transform)(object)onButtonClicked);
		}
	}

	private CloudSaveProgressCell _cellPrefab;

	private UISprite _banner;

	private FitSpriteToWidget _topIconFitter;

	private UISprite _topIcon;

	private UILabel _bannerTopLabel;

	private UILabel _bannerBottomLabel;

	private UILabel _buttonLabel;

	private Layout _cellLayout;

	private ConflictBlockPayload _payload;

	public void Setup(ConflictBlockPayload payload)
	{
		//IL_0010: Expected I4, but got Obj
		string msg = string.ConcatArray((string[])(object)"[SellConsumablesHelper] ", (int)this);
		SDebug.LogFormat(msg, (object[])(object)payload);
	}

	private void SetupBasic()
	{
	}

	public unsafe void ButtonClicked()
	{
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_024f: Expected I, but got Obj
		//IL_0265: Expected Obj, but got I
		//IL_0225: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00ae: Expected I4, but got Obj
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected I4, but got Unknown
		//IL_00fa: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_0159: Expected I4, but got Obj
		//IL_0183: Expected Obj, but got I4
		//IL_01a5: Expected I4, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v26 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v33 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("CLOUDSAVE_COMPARISON_LABEL_HEADER");
		_bannerTopLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("CLOUDSAVE_COMPARISON_LABEL_SUBHEADER");
		_bannerBottomLabel.fontSize = (int)text2;
		object obj4 = default;
		object obj3 = obj4 + 32;
		object obj5 = (flag ? 1 : 0) + 220;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v8+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj4 + 48);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v16+8]");
		_ = 0;
		_banner.rawPivot = pivot;
		object obj6 = obj4 + 16;
		object obj7 = (flag ? 1 : 0) + 252;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S2_v20+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v23+8]");
		_ = 0;
		_bannerTopLabel.rawPivot = pivot;
		object obj8 = (flag ? 1 : 0) + 268;
		obj4 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v30+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_bannerBottomLabel.rawPivot = pivot;
	}

	public CloudSaveConflictBlock()
	{
		_payload._002Ector();
	}
}
