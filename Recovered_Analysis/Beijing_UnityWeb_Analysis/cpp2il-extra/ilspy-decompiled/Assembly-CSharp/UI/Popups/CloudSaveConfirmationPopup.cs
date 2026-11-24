using System;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Extensions;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Promotion;
using UI.Generic;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CloudSaveConfirmationPopup : UIScreen
{
	private UILabel _text;

	private UILabel _badButton;

	private UILabel _goodButton;

	private UISprite _cornerIcon;

	private UISprite _cornerAccentIcon;

	private UISprite _splat;

	private UISprite _splatShadow;

	private FitSpriteToWidget _fitCornerIcon;

	private FitSpriteToWidget _fitCornerAccentIcon;

	private CloudSaveConfirmationPopupPayload _payload;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		ShowIfInactive();
		BadButtonClicked();
	}

	private void SetupBasic()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		base.Hide();
		BadButtonClicked();
		nint num = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v13 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7AAD");
		string parameterValue = default;
		FlurryLogConfirmationPopup(parameterValue);
	}

	private void SetupConfirmation(CloudSaveConfirmationPopupPayload payload)
	{
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_038d: Expected I4, but got Obj
		//IL_039f: Expected I, but got Obj
		//IL_03b5: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I4
		//IL_02d0: Expected I, but got Obj
		//IL_02e6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_0368: Expected I4, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0217: Expected I4, but got Obj
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_01c9: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I8
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v64 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)payload);
		nint num3 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v60 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreen.IsScreenHeightOutOfProportion();
		BoardPromotion boardPromotion = ((PromotionManager)flag).TryGetCurrentPromotion<BoardPromotion>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 8;
		if (boardPromotion != null)
		{
			nint num7 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v46 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v52 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogException((Exception)(object)"Current promotion is of the wrong type.");
			return;
		}
		nint num9 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S2_v6 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v23 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(board.name);
		((UILabel)(object)_cornerAccentIcon).fontSize = (int)text;
		string text2 = Strings.GetDefault(board.limitedDescription);
		((UILabel)(object)_splat).fontSize = (int)text2;
		object obj8 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		long elapsedMilliseconds = ((FramerateTracker)(object)boardPromotion).ElapsedMilliseconds;
		obj5 = elapsedMilliseconds;
		obj4 = obj5;
		throw new ArrayTypeMismatchException();
	}

	public unsafe void BadButtonClicked()
	{
		//IL_01f3: Expected I, but got Obj
		//IL_0209: Expected Obj, but got I
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected I4, but got Unknown
		//IL_027b: Expected I4, but got Obj
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_02e0: Expected I4, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0090: Expected I4, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00ea: Expected I4, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_0139: Expected I4, but got Obj
		//IL_014f: Expected Obj, but got I4
		//IL_01cf: Expected I4, but got Obj
		//IL_01df: Expected I4, but got Obj
		//IL_01ba: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v39 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 - -64;
		object obj4 = (flag ? 1 : 0) + 44;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 80);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_splat.rawPivot = pivot;
		object obj5 = this - -64;
		object obj6 = obj3 + 48;
		object obj7 = (flag ? 1 : 0) + 124;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v13+8]");
		_ = 0;
		((UIWidget)obj5).rawPivot = pivot;
		object obj8 = obj3 + 32;
		object obj9 = (flag ? 1 : 0) + 92;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v19+8]");
		_ = 0;
		_text.rawPivot = pivot;
		object obj10 = obj3 + 16;
		object obj11 = (flag ? 1 : 0) + 140;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v37+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v25+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		object obj12 = (flag ? 1 : 0) + 140;
		obj3 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S2_v47+8]");
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
		_badButton.fontSize = (int)"Bad";
		_goodButton.fontSize = (int)"Good";
	}

	public void GoodButtonClicked()
	{
		CloudSaveConfirmationPopupPayload payload = _payload;
		TransformExtensions.Reset((Transform)(object)payload.badButtonClicked);
		((CloudSaveIntroductionPopup)this).FlurryLogPopupShown("Bad");
	}

	private void SetupDisconnect()
	{
		CloudSaveConfirmationPopupPayload payload = _payload;
		TransformExtensions.Reset((Transform)(object)payload.goodButtonClicked);
		((CloudSaveIntroductionPopup)this).FlurryLogPopupShown("Good");
	}

	private void SetupKeepLocal()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FlurryLogConfirmationPopup((string)(object)CloudSaveConfirmationPopupPayload.DISCONNECT_PAYLOAD);
	}

	private void SetupKeepOnline()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FlurryLogConfirmationPopup((string)(object)CloudSaveConfirmationPopupPayload.KEEP_LOCAL_PAYLOAD);
	}

	private void SetupLoadProgress()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FlurryLogConfirmationPopup((string)(object)CloudSaveConfirmationPopupPayload.KEEP_ONLINE_PAYLOAD);
	}

	private void FlurryLogConfirmationPopup(string parameterValue)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0031: Expected I4, but got Obj
		//IL_004f: Expected I4, but got Obj
		//IL_0072: Expected I4, but got Obj
		//IL_0090: Expected I4, but got Obj
		//IL_00b3: Expected I4, but got Obj
		object obj = this + 76;
		obj = parameterValue;
		CloudSaveConfirmationPopupPayload payload = _payload;
		_text.fontSize = (int)payload.text;
		CloudSaveConfirmationPopupPayload payload2 = _payload;
		_badButton.fontSize = (int)payload2.badButtonText;
		CloudSaveConfirmationPopupPayload payload3 = _payload;
		_goodButton.fontSize = (int)payload3.goodButtonText;
		CloudSaveConfirmationPopupPayload payload4 = _payload;
		_cornerIcon.fillCenter = (byte)(int)payload4.cornerIcon != 0;
		CloudSaveConfirmationPopupPayload payload5 = _payload;
		_cornerAccentIcon.fillCenter = (byte)(int)payload5.cornerAccentIcon != 0;
		_fitCornerIcon.FitStretch();
		_fitCornerAccentIcon.FitStretch();
	}

	public CloudSaveConfirmationPopup()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FlurryLogConfirmationPopup((string)(object)CloudSaveConfirmationPopupPayload.LOAD_PROGRESS_PAYLOAD);
	}
}
