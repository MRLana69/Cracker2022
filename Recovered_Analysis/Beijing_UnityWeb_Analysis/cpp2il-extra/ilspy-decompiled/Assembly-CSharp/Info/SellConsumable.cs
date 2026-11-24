using System;
using Cpp2ILInjected;
using Data.Save;
using UnityEngine;

namespace Info;

public static class SellConsumable
{
	private const string ONLINESETTINGS_SELL_CONSUMABLES_DURING_RUN_KEY = "consumables_sell_during_run";

	private const bool ONLINESETTINGS_SELL_CONSUMABLES_DURING_RUN_DEFAULT = true;

	private static SellableConsumable activeConsumable__BackingField;

	private static Action<UpgradeType, int> m_completed;

	public static bool allowSellConsumablesDuringRun
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (byte)(currentSkipForVideoMissionIndex + 1) != 0;
			if ((flag ? 1 : 0) < (true ? 1 : 0))
			{
				flag = true;
			}
			else if ((flag ? 1 : 0) > 30)
			{
				flag = true;
			}
			return flag;
		}
	}

	public unsafe static SellableConsumable activeConsumable
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			return (SellableConsumable)((OnlineSettings)(object)saveDataPath).TryGetValue("consumables_sell_during_run", out *(string*)1);
		}
		private set
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onScoreMultiplierChanged = ScoreMultiplierInfo.onScoreMultiplierChanged;
			Action onScoreMultiplierChanged2 = default;
			while (true)
			{
				Delegate obj2 = onScoreMultiplierChanged.RemoveImpl((Delegate)(object)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(ScoreMultiplierInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)ScoreMultiplierInfo.onScoreMultiplierChanged == onScoreMultiplierChanged)
				{
					ScoreMultiplierInfo.onScoreMultiplierChanged = onScoreMultiplierChanged2;
				}
				if ((object)ScoreMultiplierInfo.onScoreMultiplierChanged != onScoreMultiplierChanged)
				{
					onScoreMultiplierChanged = ScoreMultiplierInfo.onScoreMultiplierChanged;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<UpgradeType, int> completed
	{
		add
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00b4: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A07");
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v13 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag)._ActivateNextPopup("ConsumablesPopup");
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = SellConsumable.m_completed;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(SellConsumable);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Info.SellConsumable>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static void Sell(SellableConsumable consumable)
	{
		activeConsumable__BackingField = consumable;
	}

	public static void CompleteSelling(UpgradeType upgradeType, int amountPurchased)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		object obj = upgradeType + 24;
		obj = amountPurchased;
	}
}
