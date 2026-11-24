using System;
using Cpp2ILInjected;
using Data.Save;
using Kiloo;
using Kiloo.Common.LocalizationManager;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class LanguageSelectionConfirmationPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__9_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudSaveStatusPopup._003C_003Ec obj = default;
			CloudSaveStatusPopup._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CYesClicked_003Eb__9_0()
		{
		}
	}

	public static Locale requestedLocale;

	private UILabel _title;

	private UILabel _description;

	private UILabel _yesLabel;

	private UILabel _noLabel;

	private const string COLOR_START = "[c][0374A5]";

	private const string COLOR_END = "[-][/c]";

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		//IL_0098: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_00e8: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected I4, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("LANGUAGE_SELECTION_CONFIRMATION_POPUP_TITLE");
		_title.fontSize = (int)text;
		string text2 = Strings.GetDefault("CANCEL");
		_noLabel.fontSize = (int)text2;
		string text3 = Strings.GetDefault("OK");
		_yesLabel.fontSize = (int)text3;
	}

	public void YesClicked()
	{
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0102: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_016d: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		base.Hide();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v12 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string provider = Strings.GetDefault("LANGUAGE_SELECTION_CONFIRMATION_POPUP_DESCRIPTION");
		nint num3 = (nint)typeof(LanguageSelectionConfirmationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(LanguageSelectionConfirmationPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v11 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Locale locale = requestedLocale;
		string text = string.Format((IFormatProvider)(object)provider, "[c][0374A5]", locale.nativeName, "[-][/c]");
		_description.fontSize = (int)text;
	}

	public LanguageSelectionConfirmationPopup()
	{
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_02b2: Expected I4, but got Obj
		//IL_02c0: Expected I, but got Obj
		//IL_02d6: Expected Obj, but got I
		//IL_01ce: Expected I, but got Obj
		//IL_01e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0225: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0301: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I4
		//IL_0270: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I4
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(LanguageSelectionConfirmationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(LanguageSelectionConfirmationPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v65 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PreferencesSave.soundEffectsEnabled = (byte)(int)requestedLocale.combined != 0;
		nint num3 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num4 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v61 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
		nint num5 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup+<>c>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v55 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__9_0 != null;
		SpaceType spaceType = (SpaceType)_003C_003Ec._003C_003E9__9_0;
		if (!flag)
		{
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v32 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup+<>c>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v49 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			_ = 0;
			SpaceType spaceType2 = default;
			object obj = spaceType2 + 16;
			obj = _003C_003Ec._003C_003E9;
			nint num10 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v46 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup+<>c>)+5C]");
			object obj2 = (nint)0 + (nint)4;
			obj2 = spaceType2;
			spaceType = spaceType2;
		}
		((BaseTransformValueResetter)1)._002Ector(spaceType);
	}

	static LanguageSelectionConfirmationPopup()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got F4
		//IL_0045: Expected I, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0081: Expected VT, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got F4
		//IL_00ce: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got F4
		//IL_014e: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got F4
		//IL_01ce: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got F4
		//IL_024e: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02a5: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got F4
		//IL_02ce: Expected I, but got Obj
		//IL_02f9: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got F4
		//IL_034e: Expected I, but got Obj
		//IL_0379: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got F4
		//IL_03ce: Expected I, but got Obj
		//IL_03f9: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got F4
		//IL_0440: Expected I, but got Obj
		//IL_046b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 96;
		obj = 0;
		_ = 0;
		obj = -91f;
		_ = -15f;
		_ = 0f;
		nint num = (nint)typeof(ConsumablesPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		nint num2 = 0;
		object obj3 = obj2 + 108;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		ConsumablesPopup.HOVERBOARD_POSITION_OFFSET = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj4 = obj2 + 84;
		obj4 = 0;
		_ = 0;
		obj4 = -35f;
		_ = -44f;
		_ = 26f;
		nint num3 = (nint)typeof(ConsumablesPopup);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj6 = obj2 + 72;
		obj6 = 0;
		_ = 0;
		obj6 = 22f;
		_ = 22f;
		_ = 22f;
		nint num4 = (nint)typeof(ConsumablesPopup);
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v40 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		object obj7 = (nint)0 + (nint)24;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj8 = obj2 + 60;
		obj8 = 0;
		_ = 0;
		obj8 = -91f;
		_ = -23f;
		_ = 0f;
		nint num5 = (nint)typeof(ConsumablesPopup);
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v45+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v51 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		object obj9 = (nint)0 + (nint)36;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj10 = obj2 + 48;
		obj10 = 0;
		_ = 0;
		obj10 = 0f;
		_ = -10f;
		_ = -51f;
		nint num6 = (nint)typeof(ConsumablesPopup);
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v56+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v62 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		object obj11 = (nint)0 + (nint)48;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj12 = obj2 + 36;
		obj12 = 0;
		_ = 0;
		obj12 = 17f;
		_ = 17f;
		_ = 17f;
		nint num7 = (nint)typeof(ConsumablesPopup);
		obj3 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v67+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v73 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		object obj13 = (nint)0 + (nint)60;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj14 = obj2 + 24;
		obj14 = 0;
		_ = 0;
		obj14 = -87f;
		_ = -10f;
		_ = 3f;
		nint num8 = (nint)typeof(ConsumablesPopup);
		obj3 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v84 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		object obj15 = (nint)0 + (nint)72;
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj16 = obj2 + 12;
		obj16 = 0;
		_ = 0;
		obj16 = 11f;
		_ = 8f;
		_ = -72f;
		nint num9 = (nint)typeof(ConsumablesPopup);
		obj3 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v89+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v95 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		object obj17 = (nint)0 + (nint)84;
		obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 16f;
		_ = 16f;
		_ = 16f;
		nint num10 = (nint)typeof(ConsumablesPopup);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v105 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		object obj18 = (nint)0 + (nint)96;
		obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
	}
}
