using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Info;
using Missions;
using UnityEngine;
using WeeklyHunt;

public class UIExclusiveContainerHelper : MonoBehaviour
{
	private UILabel messageLabel;

	private UISprite messageBackground;

	public void SetupExclusiveMessage(string message, Color backgroundColor, Color textColor)
	{
		//IL_033f: Expected I, but got Obj
		//IL_0355: Expected Obj, but got I
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04fb: Expected I, but got Obj
		//IL_0511: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_022e: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_0254: Expected I, but got Obj
		//IL_026a: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I
		//IL_045e: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I
		//IL_03a1: Expected I, but got Obj
		//IL_03b7: Expected Obj, but got I
		//IL_049a: Expected I4, but got Obj
		//IL_0295: Expected I, but got Obj
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_0414: Expected I, but got Obj
		//IL_042a: Expected Obj, but got I
		//IL_0131: Expected I, but got Obj
		//IL_02e2: Expected I, but got Obj
		//IL_056f: Expected Obj, but got I
		//IL_0589: Expected Obj, but got I4
		//IL_0589: Expected I4, but got Obj
		//IL_017e: Expected I, but got Obj
		//IL_01cb: Expected I, but got Obj
		nint num = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v77 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = MissionsData.skipData + 16;
		object obj3 = (object)message << 2;
		object obj4 = obj2 + obj3;
		MissionsManager.VideoButtonTrackingState videoButtonState = ((MissionsManager)obj4).videoButtonState;
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<Globals>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v71 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_FREE_PURCHASES ? 1u : 0u) == 0)
		{
			int unrewardedCoins = InventorySave.unrewardedCoins;
			if (unrewardedCoins < (int)videoButtonState)
			{
				InventorySave.IncreaseKeys((int)videoButtonState, string.Empty);
			}
		}
		int unrewardedCoins2 = InventorySave.unrewardedCoins;
		if (unrewardedCoins2 < (int)videoButtonState)
		{
			nint num5 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v56 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v63 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			nint num7 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v21 (Il2CppClass<Missions.MissionsData>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(MissionsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v43 (Il2CppClass<Missions.MissionsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj8 = MissionsData.skipData + 16;
			object obj9 = (object)message << 2;
			object obj10 = obj8 + obj9;
			object obj11 = obj10;
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v33 (Il2CppClass<Strings>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v39 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v30+8]");
			string itemId = Strings.GetDefault((string)0);
			InventorySave.LogSpentEvent((int)activeInAppOffers, (InAppItemModel.ItemType)videoButtonState, itemId, (string)5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			return;
		}
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)2, (PersistentAwardProgress)videoButtonState, (Action<Award>)(object)message);
		InventorySave.DecreaseKeys((int)videoButtonState, "SkipMission");
		nint num11 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v34 (Il2CppClass<RewardManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num12 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v51 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime startChallengeDateTime = WeeklyHuntData.startChallengeDateTime;
		nint num13 = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v41 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num14 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v47 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string itemTitleId = ItemInfo.GetItemTitleId((MysteryBox.Type)message);
		int unrewardedCoins3 = InventorySave.unrewardedCoins;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D37");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
	}

	public void Disable()
	{
		CancelInvoke();
	}

	public void Enable()
	{
		string text = tag;
		((GameObject)(object)text).tag = null;
	}

	public UIExclusiveContainerHelper()
	{
		//IL_0018: Expected Obj, but got I4
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
	}
}
