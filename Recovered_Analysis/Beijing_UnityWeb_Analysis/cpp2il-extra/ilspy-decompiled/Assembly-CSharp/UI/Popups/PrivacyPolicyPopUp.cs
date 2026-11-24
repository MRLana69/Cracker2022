using System;
using Cpp2ILInjected;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Timer;
using UI.FreeStuff;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class PrivacyPolicyPopUp : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__7_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotEnoughCurrencyPopup._003C_003Ec obj = default;
			NotEnoughCurrencyPopup._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected Obj, but got Unknown
			//IL_012b: Expected Obj, but got I4
			//IL_0143: Expected I, but got Obj
			//IL_0159: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01c4: Expected Obj, but got I
			//IL_01d4: Expected Obj, but got I
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Expected Obj, but got Unknown
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_0218: Expected Obj, but got I
			//IL_0228: Expected Obj, but got I
			//IL_0238: Expected Obj, but got I
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected Obj, but got Unknown
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Expected Obj, but got Unknown
			//IL_0274: Expected Obj, but got I
			//IL_0284: Expected Obj, but got I
			//IL_0294: Expected Obj, but got I
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Expected Obj, but got Unknown
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected Obj, but got Unknown
			//IL_02d0: Expected Obj, but got I
			//IL_02e0: Expected Obj, but got I
			//IL_02f0: Expected Obj, but got I
			//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Expected Obj, but got Unknown
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Expected Obj, but got Unknown
			//IL_032c: Expected Obj, but got I
			//IL_033c: Expected Obj, but got I
			//IL_034c: Expected Obj, but got I
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Expected Obj, but got Unknown
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Expected Obj, but got Unknown
			//IL_0380: Expected I, but got Obj
			//IL_0396: Expected Obj, but got I
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected Obj, but got Unknown
			//IL_00d5: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 4;
			obj = 0;
			((Cooldowns)(object)"coins")._002Ector();
			nint num = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(NotEnoughCurrencyPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v55 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			VideoButtonPayload videoButtonPayload = NotEnoughCurrencyPopup.CreateButtonPayload();
			obj = videoButtonPayload;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string text = ((Cooldowns)(object)"coins").AsString();
			if ((nint)text != 1)
			{
				obj2 = ((Cooldowns)(object)"coins").AsString() - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args = default;
				string text2 = $"Cooldown_{args}_watched";
			}
			else
			{
				string text2 = "No Cooldown";
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S3_v3+60]");
			object obj5 = 0;
			object obj6 = obj5;
			object obj7 = obj6 & 0x1FFF;
			object obj8 = obj7 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v95 @ S4_v4 (should have been resolved before IL gen)");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S4_v6 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S4_v7+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S4_v8+48]");
			object obj11 = 0;
			object obj12 = obj11 & 0x7FF;
			object obj13 = obj12 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v114 @ S5_v6 (should have been resolved before IL gen)");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S4_v11 (Il2CppMethodInfo)+C]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S4_v12+60]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S4_v13+48]");
			object obj16 = 0;
			object obj17 = obj16 & 0x7FF;
			object obj18 = obj17 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v133 @ S5_v10 (should have been resolved before IL gen)");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S4_v16 (Il2CppMethodInfo)+C]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S4_v17+60]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v18+48]");
			object obj21 = 0;
			object obj22 = obj21 & 0x7FF;
			object obj23 = obj22 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v151 @ S5_v14 (should have been resolved before IL gen)");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S4_v21 (Il2CppMethodInfo)+C]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S4_v22+60]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S4_v23+48]");
			object obj26 = 0;
			object obj27 = obj26 & 0x7FF;
			object obj28 = obj27 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v169 @ S5_v18 (should have been resolved before IL gen)");
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v37 (Il2CppClass<Flurry>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num9 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v42 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}

		internal void _003CYesClicked_003Eb__7_0()
		{
		}
	}

	private UILabel _title;

	private UILabel _description;

	private UILabel _subDescription;

	private UILabel _yesLabel;

	private UILabel _noLabel;

	public override void Init()
	{
		//IL_0012: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.PrivacyPolicyPopUp)+44]");
		((RewardForVideoButton)0).Init(null);
	}

	public void NoClicked()
	{
		//IL_00dc: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_012c: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected I4, but got Obj
		//IL_00a5: Expected I4, but got Obj
		//IL_00c7: Expected I4, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v23 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("PRIVACY_POLICY_POPUP_TITLE");
		_title.fontSize = (int)text;
		string text2 = Strings.GetDefault("PRIVACY_POLICY_POPUP_DESCRIPTION");
		_description.fontSize = (int)text2;
		string text3 = Strings.GetDefault("PRIVACY_POLICY_POPUP_DESCRIPTION_SUB");
		_subDescription.fontSize = (int)text3;
		string text4 = Strings.GetDefault("PRIVACY_POLICY_POPUP_NO");
		_noLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("PRIVACY_POLICY_POPUP_YES");
		_yesLabel.fontSize = (int)text5;
	}

	public void YesClicked()
	{
		//IL_0111: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_014d: Expected I4, but got Obj
		//IL_015f: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I4
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		string original = tag;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		nint num = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<UIScreens>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v23 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Utility.NumberOfDigits((int)obj);
		nint num4 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v11 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v19 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.StartSession((string)num3);
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v10 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v16 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
	}

	private void Update()
	{
		//IL_01ec: Expected I, but got Obj
		//IL_0202: Expected Obj, but got I
		//IL_0228: Expected I4, but got Obj
		//IL_023a: Expected I, but got Obj
		//IL_0250: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I4
		//IL_0284: Expected I, but got Obj
		//IL_029a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0389: Expected I, but got Obj
		//IL_039f: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_0371: Expected Obj, but got I4
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_032e: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		string original = tag;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		nint num = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<UIScreens>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v35 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Utility.NumberOfDigits((int)obj);
		nint num4 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v11 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v31 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.LogClosePressedOnPopup((string)num3);
		nint num6 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v10 (Il2CppClass<UI.Popups.PrivacyPolicyPopUp+<>c>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v55 (Il2CppClass<UI.Popups.PrivacyPolicyPopUp+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__7_0 == null;
		bool flag2 = !flag;
		string message = (string)(object)_003C_003Ec._003C_003E9__7_0;
		if (!flag2)
		{
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32 (Il2CppClass<UI.Popups.PrivacyPolicyPopUp+<>c>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v49 (Il2CppClass<UI.Popups.PrivacyPolicyPopUp+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num10 = 0;
			string text = default;
			text.m_stringLength = (int)num10;
			_ = 0;
			object obj6 = text + 16;
			obj6 = _003C_003Ec._003C_003E9;
			nint num11 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v46 (Il2CppClass<UI.Popups.PrivacyPolicyPopUp+<>c>)+5C]");
			object obj7 = (nint)0 + (nint)4;
			obj7 = text;
			message = text;
		}
		Timer.Log(message);
		nint num12 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v21 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num13 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3).ClosePopup((GameObject)(object)screenName);
	}

	public PrivacyPolicyPopUp()
	{
		//IL_000a: Expected Obj, but got I4
		if (Input.GetKeyDown((string)27))
		{
			YesClicked();
		}
	}
}
