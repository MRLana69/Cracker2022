using Cpp2ILInjected;
using Data.Save;

namespace InApp;

public class InAppManagerPopupData
{
	public string popupTitle;

	public string popupDescription;

	public string popupName;

	public bool canMakePurchase;

	public bool isCoinsPack;

	public bool isErrorMessage;

	public int currencyMissing;

	public InAppItemModel bestOffer;

	public InAppManagerPopupData()
	{
		//IL_04f7: Expected I, but got Obj
		//IL_050d: Expected Obj, but got I
		//IL_00f6: Expected I, but got Obj
		//IL_010c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0137: Expected I, but got Obj
		//IL_0184: Expected I, but got Obj
		//IL_019a: Expected Obj, but got I
		//IL_01c5: Expected I, but got Obj
		//IL_0212: Expected I, but got Obj
		//IL_0228: Expected Obj, but got I
		//IL_0253: Expected I, but got Obj
		//IL_02a0: Expected I, but got Obj
		//IL_02b6: Expected Obj, but got I
		//IL_02e1: Expected I, but got Obj
		//IL_032e: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_036f: Expected I, but got Obj
		//IL_03bc: Expected I, but got Obj
		//IL_03d2: Expected Obj, but got I
		//IL_0586: Expected Obj, but got I4
		//IL_03fd: Expected I, but got Obj
		//IL_0459: Expected I, but got Obj
		//IL_046f: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I4
		//IL_049a: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v99 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6;
		switch (UserSave.hasPaidOutFacebookReward)
		{
		case false:
		{
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UserSave.hasPaidOutFacebookReward = true;
			return;
		}
		case true:
		{
			nint num11 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v28 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num12 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UserSave.hasPaidOutFacebookReward = true;
			return;
		}
		case true:
		{
			nint num7 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v38 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v43 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UserSave.hasPaidOutFacebookReward = true;
			return;
		}
		case true:
		{
			nint num13 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v48 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num14 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v53 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UserSave.hasPaidOutFacebookReward = true;
			return;
		}
		case true:
		{
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v63 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UserSave.hasPaidOutFacebookReward = true;
			return;
		}
		case true:
		{
			nint num9 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v68 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v79 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool hasPaidOutFacebookReward = UserSave.hasPaidOutFacebookReward;
			obj6 = hasPaidOutFacebookReward;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "Trying to update last purchased bundle when there are no more tiers. Last purchased bundle is " + text;
			SDebug.LogFormat(msg, null);
			return;
		}
		}
		nint num15 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v84 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num16 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v95 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasPaidOutFacebookReward2 = UserSave.hasPaidOutFacebookReward;
		obj6 = hasPaidOutFacebookReward2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string msg2 = "No know bundle tier: " + text2;
		SDebug.LogFormat(msg2, null);
	}
}
