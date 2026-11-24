using System;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.HTTP;
using UI.Generic;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CloudSaveProgressCell : MonoBehaviour
{
	public class CloudSaveProgressCellPayload
	{
		public string iconName;

		public string text;

		public bool isImprovement;

		public bool showBackground;

		public int backgroundWidth;

		public int contentLeftOffset;

		public int backgroundHeight;

		public CloudSaveProgressCellPayload()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private UISprite _background;

	private UISprite _icon;

	private UISprite _improvementIcon;

	private UILabel _label;

	private Layout _contentLayout;

	private FitSpriteToWidget _iconFitter;

	public void SetupCell(CloudSaveProgressCellPayload payload)
	{
		//IL_00c4: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_026a: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I
		//IL_002f: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveProgressCell)+48]");
		if ((nint)0 != 0)
		{
			object obj7 = "NativeLoggedIn";
		}
		else
		{
			object obj7 = "NativeLoggedOut";
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S4_v7+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S4_v8+48]");
		object obj10 = 0;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v66 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v19 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v38 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasUserRunAppBefore = UserSave.hasUserRunAppBefore;
		obj = hasUserRunAppBefore;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S4_v12+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v13+48]");
		object obj16 = 0;
		object obj17 = obj16 & 0x7FF;
		object obj18 = obj17 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S5_v10 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v29 (Il2CppClass<Flurry>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v34 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void SetAsMultiplier()
	{
		((UpgradeScreen)this).Start();
	}

	private void SetAsHighscore()
	{
		//IL_001e: Expected I4, but got Obj
		IRequest request = RequestExtensions.WithTimeout(null, 1f);
		_label.fontSize = (int)request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}

	private void SetAsKeys()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0022: Expected I4, but got Obj
		IRequest request = RequestExtensions.WithTimeout((IRequest)1, 100000f);
		_label.fontSize = (int)request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}

	private void SetAsUpgrades()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0022: Expected I4, but got Obj
		IRequest request = RequestExtensions.WithTimeout((IRequest)2, 5f);
		_label.fontSize = (int)request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}

	private void SetAsAwards()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0022: Expected I4, but got Obj
		IRequest request = RequestExtensions.WithTimeout((IRequest)3, 3f);
		_label.fontSize = (int)request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}

	private void SetAsCharacters()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0022: Expected I4, but got Obj
		IRequest request = RequestExtensions.WithTimeout((IRequest)4, 1f);
		_label.fontSize = (int)request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}

	private void SetAsBoards()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0022: Expected I4, but got Obj
		IRequest request = RequestExtensions.WithTimeout((IRequest)5, 1f);
		_label.fontSize = (int)request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}

	private void SetAsOutfits()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0022: Expected I4, but got Obj
		IRequest request = RequestExtensions.WithTimeout((IRequest)6, 1f);
		_label.fontSize = (int)request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}

	private void SetAsBoardThemes()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0022: Expected I4, but got Obj
		IRequest request = RequestExtensions.WithTimeout((IRequest)7, 1f);
		_label.fontSize = (int)request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}

	private void SetAsLastModifiedTime()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0022: Expected I4, but got Obj
		IRequest request = RequestExtensions.WithTimeout((IRequest)8, 1f);
		_label.fontSize = (int)request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}

	public CloudSaveProgressCell()
	{
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got VT
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0100: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v16 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime utcNow = DateTime.UtcNow;
		object obj2 = utcNow;
		UserData userData = (UserData)(obj2 + 8);
		userData = (UserData)obj2;
		string text = userData.AsString();
		_label.fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		bool fillCenter = default;
		_icon.fillCenter = fillCenter;
		_iconFitter.FitStretch();
	}
}
