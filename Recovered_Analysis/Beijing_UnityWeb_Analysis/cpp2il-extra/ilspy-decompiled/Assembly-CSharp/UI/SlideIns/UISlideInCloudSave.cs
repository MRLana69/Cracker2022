using System;
using System.Collections.Generic;
using System.Linq;
using Cloud.Internal;
using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInCloudSave : UISlideIn
{
	protected UILabel _topLine;

	protected UILabel _bottomLine;

	protected HorizontalLayout _layout;

	protected UISprite _icon;

	protected UISprite _accentIcon;

	protected FitSpriteToWidget _fitter;

	protected SlideIn _payload;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I4
		//IL_0285: Expected I4, but got Obj
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_022c: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		bool flag = string.IsNullOrEmpty((string)(object)slideIn);
		nint num = (nint)typeof(UISlideInCharacterEventRewardHelper._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UI.SlideIns.UISlideInCharacterEventRewardHelper+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UISlideInCharacterEventRewardHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v17 (Il2CppClass<UI.SlideIns.UISlideInCharacterEventRewardHelper+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UISlideInCharacterEventRewardHelper._003C_003Ec._003C_003E9__3_0 == null;
		bool flag3 = !flag2;
		Func<char, string> selector = UISlideInCharacterEventRewardHelper._003C_003Ec._003C_003E9__3_0;
		if (!flag3)
		{
			nint num3 = (nint)typeof(UISlideInCharacterEventRewardHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v26 (Il2CppClass<UI.SlideIns.UISlideInCharacterEventRewardHelper+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UISlideInCharacterEventRewardHelper._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v46 (Il2CppClass<UI.SlideIns.UISlideInCharacterEventRewardHelper+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<char, string> func = default;
			object obj3 = func + 16;
			obj3 = UISlideInCharacterEventRewardHelper._003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(UISlideInCharacterEventRewardHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v43 (Il2CppClass<UI.SlideIns.UISlideInCharacterEventRewardHelper+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = func;
			selector = func;
		}
		IEnumerable<string> source = Enumerable.Select((IEnumerable<char>)flag, selector);
		string[] strB = Enumerable.ToArray(source);
		int num7 = string.CompareOrdinalIgnoreCaseHelper(" ", (string)(object)strB);
		nint num8 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v13 (Il2CppClass<Strings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v21 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("SLIDE_IN_CHARACTER_EVENT_COMPLETE");
		string text = string.Format(format, (object[])num7);
		_topLine.fontSize = (int)text;
	}

	private void SetupSlideIn(CloudSaveState state)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 84;
		obj = state;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (Cloud.Internal.CloudSaveState)+24]");
		SetupSpecific(CloudSaveState.Disabled);
	}

	protected virtual void SetupBasic()
	{
		((UISlideInAdsRemoved)this)._002Ector();
	}

	protected virtual void SetupSpecific(CloudSaveState state)
	{
		//IL_0054: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		_fitter.FitStretch();
		string text = _accentIcon.tag;
		bool flag = state < CloudSaveState.Error;
		((GameObject)(object)text).tag = (string)flag;
		string text2 = tag;
		((GameObject)(object)text2).tag = (string)1;
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)1);
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
		}
	}

	private unsafe void SetupOk()
	{
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected I4, but got Unknown
		//IL_0268: Expected I4, but got Obj
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0082: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I4
		//IL_00f3: Expected I4, but got Obj
		//IL_0129: Expected Obj, but got I4
		//IL_014b: Expected I4, but got Obj
		//IL_0161: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v39 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 48;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj4 = (flag ? 1 : 0) + 604;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v5+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 - -64);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+8]");
		_ = 0;
		_topLine.rawPivot = pivot;
		object obj5 = obj3 + 32;
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj6 = (flag2 ? 1 : 0) + 140;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v18+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v16+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		object obj7 = this - -64;
		object obj8 = obj3 + 16;
		bool flag3 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj9 = (flag3 ? 1 : 0) + 268;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v30+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v23+8]");
		_ = 0;
		((UIWidget)obj7).rawPivot = pivot;
		bool flag4 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj10 = (flag4 ? 1 : 0) + 140;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v41+8]");
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

	private void SetupError()
	{
		SetupSpecific(CloudSaveState.Ok);
	}

	private void SetupConflict()
	{
		SetupSpecific(CloudSaveState.Error);
	}

	private void SetupDisconnected()
	{
		SetupSpecific(CloudSaveState.Conflict);
	}

	public UISlideInCloudSave()
	{
		SetupSpecific(CloudSaveState.Disabled);
	}
}
