using System;
using System.Collections.Generic;
using System.Linq;
using Cloud;
using Cloud.Internal;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.GameCenter;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Popups.CloudSaveAdvancedComparisonPopupInternal;
using UI.Popups.CloudSaveComparisonPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CloudSaveComparisonPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CloudSaveComparisonRow, bool> _003C_003E9__9_0;

		public static Action _003C_003E9__9_3;

		public static Action _003C_003E9__9_7;

		public static Action _003C_003E9__9_6;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AgeRestrictionPopup._003C_003Ec obj = default;
			AgeRestrictionPopup._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_018b: Expected Obj, but got I
			//IL_0199: Expected I, but got Obj
			//IL_01af: Expected Obj, but got I
			//IL_01de: Expected Obj, but got I4
			//IL_01ec: Expected I, but got Obj
			//IL_0202: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected Obj, but got Unknown
			//IL_0285: Expected I, but got Obj
			//IL_029b: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveComparisonPopup+<>c)+8]");
			((CloudSaveConflictResolver)0).DetermineRecommendation();
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v71 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).DebugCloseAllPopups();
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v65 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_003C_003E9__9_7 == null)
			{
				nint num5 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v42 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v59 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num7 = 0;
				_ = 0;
				object obj5 = default;
				object obj4 = obj5 + 16;
				obj4 = _003C_003E9;
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v56 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+5C]");
				object obj6 = (nint)0 + (nint)12;
				obj6 = obj5;
			}
			throw new ArrayTypeMismatchException();
		}

		internal bool _003CSetupConflict_003Eb__9_0(CloudSaveComparisonRow r)
		{
			//IL_0015: Invalid comparison between F4 and I
			float localValue = r.localValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveComparisonPopup+<>c)+8]");
			return localValue == 0f;
		}

		internal void _003CSetupConflict_003Eb__9_3()
		{
		}

		internal void _003CSetupConflict_003Eb__9_7()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).DebugCloseAllPopups();
		}

		internal void _003CSetupConflict_003Eb__9_6()
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0141: Expected I, but got Obj
			//IL_0157: Expected Obj, but got I
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected Obj, but got Unknown
			//IL_0111: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 20;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v7 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v14 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = text + 12;
			string text2 = Strings.GetDefault("CLOUDSAVE_SLIDEIN_CONFLICT_RESOLVED_CLOUD");
			obj3 = text2;
			((UIScreenController)flag)._QueueMessage(text);
		}
	}

	private const float SLIDEIN_DELAY = 0.5f;

	private UILabel _headline;

	private UILabel _subline;

	private UILabel _subtext;

	private CloudSaveConflictBlock _conflictPrefab;

	private Layout _conflictLayout;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		ShowIfInactive();
		SetupConflict();
	}

	private void SetupBasic()
	{
		base.Hide();
		MoreInformationClicked();
	}

	private unsafe void SetupConflict()
	{
		//IL_01ef: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0277: Expected Obj, but got I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected I4, but got Unknown
		//IL_02a7: Expected I4, but got Obj
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_02df: Expected Obj, but got I4
		//IL_0301: Expected I4, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_0082: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_023f: Expected I4, but got Obj
		//IL_01a7: Expected I4, but got Obj
		//IL_0159: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_01c8: Expected I4, but got Obj
		//IL_01db: Expected I4, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v36 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 32;
		object obj4 = (flag ? 1 : 0) + 140;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 48);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_headline.rawPivot = pivot;
		object obj5 = obj3 + 16;
		object obj6 = (flag ? 1 : 0) + 92;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_subline.rawPivot = pivot;
		object obj7 = (flag ? 1 : 0) + 92;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S2_v25+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_subtext.rawPivot = pivot;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v24 (Il2CppClass<Strings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v40 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("CLOUDSAVE_COMPARISON_HEADER");
		_headline.fontSize = (int)text3;
		string text4 = Strings.GetDefault("CLOUDSAVE_COMPARISON_DESCRIPTION");
		_subline.fontSize = (int)text4;
		string text5 = Strings.GetDefault("CLOUDSAVE_COMPARISON_INFOBUTTON");
		string text6 = string.ConcatArray((string[])(object)"[u]", (int)text5);
		_subtext.fontSize = (int)text6;
	}

	public void MoreInformationClicked()
	{
		//IL_0a1b: Expected I, but got Obj
		//IL_0a31: Expected Obj, but got I
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected Obj, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected Obj, but got Unknown
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected Obj, but got Unknown
		//IL_0b79: Expected Obj, but got I
		//IL_0b8a: Invalid comparison between I and F4
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected Obj, but got Unknown
		//IL_0b1e: Expected I, but got Obj
		//IL_0b34: Expected Obj, but got I
		//IL_0246: Invalid comparison between I and F4
		//IL_01e8: Expected I, but got Obj
		//IL_015a: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_0be3: Expected I, but got Obj
		//IL_0bf9: Expected Obj, but got I
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0386: Expected I, but got Obj
		//IL_039c: Expected Obj, but got I
		//IL_0322: Expected I, but got Obj
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected Obj, but got Unknown
		//IL_0c75: Expected Obj, but got I
		//IL_0c86: Invalid comparison between I and F4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0425: Invalid comparison between I and F4
		//IL_03c7: Expected I, but got Obj
		//IL_045b: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got I4
		//IL_0cc1: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I4
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0491: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got VT
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_067a: Expected I, but got Obj
		//IL_0690: Expected Obj, but got I
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got Unknown
		//IL_071f: Expected I, but got Obj
		//IL_0735: Expected Obj, but got I
		//IL_06bb: Expected I, but got Obj
		//IL_05d3: Expected Obj, but got I4
		//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d47: Expected Obj, but got Unknown
		//IL_0d6d: Expected Obj, but got I
		//IL_0d7e: Invalid comparison between I and F4
		//IL_062b: Expected Obj, but got I4
		//IL_07be: Invalid comparison between I and F4
		//IL_0760: Expected I, but got Obj
		//IL_07f4: Expected Obj, but got I4
		//IL_07a8: Expected Obj, but got I4
		//IL_0db9: Expected Obj, but got I4
		//IL_07e6: Expected Obj, but got I4
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected Obj, but got Unknown
		//IL_082a: Expected Obj, but got I
		//IL_083b: Expected Obj, but got I8
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected Obj, but got Unknown
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected Obj, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected Obj, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected Obj, but got Unknown
		//IL_096c: Expected Obj, but got I4
		//IL_09c4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v64 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		UserData userData = (UserData)(obj2 + 16);
		object obj3 = obj2 + 8;
		object obj5 = default;
		object obj4 = obj5 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78EE");
		object obj6 = default;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		((CloudSaveConflictResolver)0).AttemptAutoResolution();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		string source = CloudSaveDecorator.GetName(CloudSaveComparisonElement.Multiplier);
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v13 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v184 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__9_0 == null;
		bool flag2 = !flag;
		Func<CloudSaveComparisonRow, bool> keySelector = _003C_003Ec._003C_003E9__9_0;
		if (!flag2)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v158 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v178 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			_ = 0;
			Func<CloudSaveComparisonRow, bool> func = default;
			object obj9 = func + 16;
			obj9 = _003C_003Ec._003C_003E9;
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v175 (Il2CppClass<UI.Popups.CloudSaveComparisonPopup+<>c>)+5C]");
			object obj10 = (nint)0 + (nint)4;
			obj10 = func;
			keySelector = func;
		}
		IOrderedEnumerable<CloudSaveComparisonRow> source2 = Enumerable.OrderByDescending((IEnumerable<CloudSaveComparisonRow>)(object)source, keySelector);
		List<CloudSaveComparisonRow> list = Enumerable.ToList(source2);
		GameObject obj11 = _conflictLayout.gameObject;
		nint num9 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v27 (Il2CppClass<NGUITools>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num10 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v153 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.DestroyImmediate(obj11);
		object obj13 = obj5 + 12;
		obj13 = string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v39+14]");
		object obj15;
		if (0f > 2f)
		{
			obj15 = 1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v39+14]");
			obj15 = ((!(0f < -2f)) ? ((object)0) : ((object)2));
		}
		if (obj15 != null)
		{
			if ((nint)obj15 != 1)
			{
				if ((nint)obj15 == 2)
				{
					object obj16 = obj5 + 12;
					obj16 = "FromComparisonRecommendingTheirs";
				}
			}
			else
			{
				object obj17 = obj5 + 12;
				obj17 = "FromComparisonRecommendingMine";
			}
		}
		else
		{
			object obj18 = obj5 + 12;
			obj18 = "FromComparisonRecommendingNone";
		}
		GameObject parent = _conflictLayout.gameObject;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S2_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S2_v142 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSaveConflictBlock cloudSaveConflictBlock = UnityEngine.Object.Instantiate(_conflictPrefab, (Transform)(object)parent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudSaveAdvancedComparisonRow.CloudSaveComparisonRowPayload cloudSaveComparisonRowPayload = default;
		cloudSaveComparisonRowPayload._002Ector();
		object obj20 = cloudSaveComparisonRowPayload + 12;
		obj20 = "ic_phone";
		nint num13 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v49 (Il2CppClass<Strings>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num14 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v139 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj22 = cloudSaveComparisonRowPayload + 8;
		string text = Strings.GetDefault("CLOUDSAVE_COMPARISON_KEEPLOCAL");
		obj22 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S2_v25+14]");
		object obj24;
		if (0f > 2f)
		{
			obj24 = 1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S2_v25+14]");
			obj24 = ((!(0f < -2f)) ? ((object)0) : ((object)2));
		}
		bool flag3 = (nint)obj24 == 1;
		cloudSaveComparisonRowPayload.onlineValue = (string)flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<CloudSaveProgressCell.CloudSaveProgressCellPayload> list2 = default;
		list2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudSaveProgressCell.CloudSaveProgressCellPayload cloudSaveProgressCellPayload = default;
		object obj25 = cloudSaveProgressCellPayload + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		object obj26 = default;
		obj25 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		DateTime lastModifiedTheirs = ((CloudSaveConflictResolver)0).lastModifiedTheirs;
		obj3 = lastModifiedTheirs;
		userData = (UserData)obj3;
		object obj27 = cloudSaveProgressCellPayload + 12;
		string text2 = userData.AsString();
		obj27 = text2;
		list2.Add(cloudSaveProgressCellPayload);
		object obj28 = cloudSaveComparisonRowPayload + 20;
		obj28 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num15 = 0;
		_ = 0;
		object obj30 = default;
		object obj29 = obj30 + 16;
		obj29 = obj5;
		object obj31 = cloudSaveComparisonRowPayload + 24;
		obj31 = obj30;
		int num16 = 0;
		CloudSaveProgressCell.CloudSaveProgressCellPayload cloudSaveProgressCellPayload2 = default;
		object obj33 = default;
		while (num16 <= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj32 = cloudSaveProgressCellPayload2 + 8;
			CloudSaveComparisonRow cloudSaveComparisonRow = list.get_Item(num16);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
			obj32 = obj33;
			object obj34 = cloudSaveProgressCellPayload2 + 12;
			CloudSaveComparisonRow cloudSaveComparisonRow2 = list.get_Item(num16);
			CloudSaveComparisonRow cloudSaveComparisonRow3 = list.get_Item(num16);
			IRequest request = RequestExtensions.WithTimeout((IRequest)cloudSaveComparisonRow2.id, cloudSaveComparisonRow3.localValue);
			obj34 = request;
			CloudSaveComparisonRow cloudSaveComparisonRow4 = list.get_Item(num16);
			bool isLocalImprovement = cloudSaveComparisonRow4.isLocalImprovement;
			cloudSaveProgressCellPayload2.isImprovement = isLocalImprovement;
			((List<CloudSaveProgressCell.CloudSaveProgressCellPayload>)cloudSaveComparisonRowPayload.showBackground).Add(cloudSaveProgressCellPayload2);
			int num17 = num16 + 1;
			num16 = num17;
		}
		((CloudSaveAdvancedComparisonRow)(object)cloudSaveConflictBlock).SetupRow(cloudSaveComparisonRowPayload);
		GameObject parent2 = _conflictLayout.gameObject;
		nint num18 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S2_v59 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S2_v123 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSaveConflictBlock cloudSaveConflictBlock2 = UnityEngine.Object.Instantiate(_conflictPrefab, (Transform)(object)parent2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudSaveAdvancedComparisonRow.CloudSaveComparisonRowPayload cloudSaveComparisonRowPayload2 = default;
		cloudSaveComparisonRowPayload2._002Ector();
		object obj36 = cloudSaveComparisonRowPayload2 + 12;
		obj36 = "ic_cloud";
		nint num20 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S1_v92 (Il2CppClass<Strings>)+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			nint num21 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S1_v131 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj38 = cloudSaveComparisonRowPayload2 + 8;
		string text3 = Strings.GetDefault("CLOUDSAVE_COMPARISON_KEEPCLOUD");
		obj38 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S2_v75+14]");
		object obj40;
		if (0f > 2f)
		{
			obj40 = 1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S2_v75+14]");
			obj40 = ((!(0f < -2f)) ? ((object)0) : ((object)2));
		}
		bool flag4 = (nint)obj40 == 2;
		cloudSaveComparisonRowPayload2.onlineValue = (string)flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<CloudSaveProgressCell.CloudSaveProgressCellPayload> list3 = default;
		list3._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudSaveProgressCell.CloudSaveProgressCellPayload cloudSaveProgressCellPayload3 = default;
		object obj41 = cloudSaveProgressCellPayload3 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		object obj42 = default;
		obj41 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		long scoreValue = ((GameCenterReportScoreRequest)0).scoreValue;
		obj2 = scoreValue;
		userData = (UserData)obj2;
		object obj43 = cloudSaveProgressCellPayload3 + 12;
		string text4 = userData.AsString();
		obj43 = text4;
		list3.Add(cloudSaveProgressCellPayload3);
		object obj44 = cloudSaveComparisonRowPayload2 + 20;
		obj44 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num22 = 0;
		_ = 0;
		object obj46 = default;
		object obj45 = obj46 + 16;
		obj45 = obj5;
		object obj47 = cloudSaveComparisonRowPayload2 + 24;
		obj47 = obj46;
		int num23 = 0;
		CloudSaveProgressCell.CloudSaveProgressCellPayload cloudSaveProgressCellPayload4 = default;
		object obj49 = default;
		while (num23 <= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj48 = cloudSaveProgressCellPayload4 + 8;
			CloudSaveComparisonRow cloudSaveComparisonRow5 = list.get_Item(num23);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
			obj48 = obj49;
			object obj50 = cloudSaveProgressCellPayload4 + 12;
			CloudSaveComparisonRow cloudSaveComparisonRow6 = list.get_Item(num23);
			CloudSaveComparisonRow cloudSaveComparisonRow7 = list.get_Item(num23);
			IRequest request2 = RequestExtensions.WithTimeout((IRequest)cloudSaveComparisonRow6.id, cloudSaveComparisonRow7.onlineValue);
			obj50 = request2;
			CloudSaveComparisonRow cloudSaveComparisonRow8 = list.get_Item(num23);
			bool isOnlineImprovement = cloudSaveComparisonRow8.isOnlineImprovement;
			cloudSaveProgressCellPayload4.isImprovement = isOnlineImprovement;
			((List<CloudSaveProgressCell.CloudSaveProgressCellPayload>)cloudSaveComparisonRowPayload2.showBackground).Add(cloudSaveProgressCellPayload4);
			int num24 = num23 + 1;
			num23 = num24;
		}
		((CloudSaveAdvancedComparisonRow)(object)cloudSaveConflictBlock2).SetupRow(cloudSaveComparisonRowPayload2);
		((RewardForVideoButton)(object)_conflictLayout).Init((VideoButtonPayload)null);
	}

	public CloudSaveComparisonPopup()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I4
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("CloudSaveAdvancedComparisonPopup");
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
