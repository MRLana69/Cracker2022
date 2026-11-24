using System;
using Cpp2ILInjected;
using Info;
using Info.VideoRewardCooldowns;
using UI.Popups;
using UI.Screens.PauseScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.VideoAdPrizes;

public class VideoAdPrize
{
	private VideoAdPrizeType prizeType__BackingField;

	private int amount__BackingField;

	private bool hasBeenRewarded__BackingField;

	public VideoAdPrizeType prizeType
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.VideoAdPrizes.VideoAdPrize)+2C]");
			return VideoAdPrizeType.NotSet;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 44;
			obj = value;
		}
	}

	private int amount
	{
		get
		{
			return (int)prizeType__BackingField;
		}
		set
		{
			prizeType__BackingField = (VideoAdPrizeType)value;
		}
	}

	public bool hasBeenRewarded
	{
		get
		{
			return (byte)amount__BackingField != 0;
		}
		private set
		{
			amount__BackingField = (value ? 1 : 0);
		}
	}

	public unsafe VideoAdPrize(VideoAdPrizeType prizeType, int amount = 1)
	{
		//IL_01bc: Expected Obj, but got I4
		//IL_01d6: Expected I4, but got Obj
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		//IL_0061: Expected Obj, but got VT
		//IL_0080: Expected F4, but got Obj
		//IL_0080: Expected Obj, but got I4
		//IL_009b: Expected F4, but got Obj
		//IL_009b: Expected Obj, but got I4
		//IL_00b6: Expected F4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_00d1: Expected F4, but got Obj
		//IL_00d1: Expected Obj, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00f2: Expected Obj, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected I4, but got Unknown
		//IL_0173: Expected I4, but got Obj
		string tag = ((Component)prizeType).tag;
		NullReferenceException ex = new NullReferenceException();
		((GameObject)(object)tag).SetActive((byte)(int)ex != 0);
		NullReferenceException ex2 = new NullReferenceException();
		object obj = ex2 & 0x1F;
		int eventMask = 1 << (int)obj;
		((Camera)prizeType).eventMask = eventMask;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [amount @ L2 (System.Int32)+10]");
		_0021_00210 val = (_0021_00210)((AndroidJavaObject)this)._Call<ReturnType>((string)0, (object[])hasBeenRewarded__BackingField);
		Rect rect = ((Camera)val).rect;
		NullReferenceException ex3 = new NullReferenceException();
		((Camera)prizeType).fieldOfView = (float)ex3;
		NullReferenceException ex4 = new NullReferenceException();
		((Camera)prizeType).farClipPlane = (float)ex4;
		NullReferenceException ex5 = new NullReferenceException();
		((Camera)prizeType).orthographicSize = (float)ex5;
		NullReferenceException ex6 = new NullReferenceException();
		((Camera)prizeType).aspect = (float)ex6;
		object obj3 = default;
		object obj2 = obj3 + 32;
		object obj4 = amount + 28;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v20+8]");
		_ = 0;
		object obj5 = obj3 + 16;
		object obj6 = this + 28;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v26+8]");
		_ = 0;
		object obj7 = obj3 + 48;
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v17+8]");
		_ = 0;
		CameraClearFlags cameraClearFlags = (CameraClearFlags)(obj3 - -64);
		((CameraClearFlags*)(int)cameraClearFlags)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v20+8]");
		_ = 0;
		throw new NullReferenceException();
	}

	private CelebrationReward CreateCelebrationReward()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = hasBeenRewarded__BackingField;
		return (CelebrationReward)flag;
	}

	private CelebrationReward CreateMysteryBox(MysteryBox.Type mysteryBoxType, CelebrationRewardOrigin celebrationRewardOrigin)
	{
		//IL_00a7: Expected Obj, but got I4
		//IL_00d6: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0183: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj = celebrationRewardOrigin;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text = default;
		string values = "" + text + "x ";
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v7 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v18 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Upgrade upgrade = Upgrades.upgrades.get_Item((UpgradeType)mysteryBoxType);
		string id = ((Cooldown)(object)upgrade).id;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v7 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v13 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault(id);
		return (CelebrationReward)(object)string.ConcatArray((string[])(object)values, (int)text2);
	}

	private CelebrationReward CreateCurrencyReward(int amountOfCurrencyToGive, CelebrationRewardType celebrationRewardType)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<MysteryBox>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<MysteryBox>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int megaJackpotAmount = MysteryBox.GetMegaJackpotAmount((MysteryBox.Type)amountOfCurrencyToGive);
		_ = 13;
		return (CelebrationReward)megaJackpotAmount;
	}

	public void GiveReward(UnlockItemSource rewardSource)
	{
		bool flag = (byte)(rewardSource & UnlockItemSource.NotEnoughCurrencyPopup) != 0;
		hasBeenRewarded__BackingField = flag;
	}

	public string AsString()
	{
		//IL_01b6: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		object obj = prizeType__BackingField - 1;
		if (prizeType__BackingField != VideoAdPrizeType.SuperMysteryBox)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj == 4)
						{
							bool flag = ((AgeRestrictionPopup)null).IsValidDateTime(amount__BackingField, 1);
							return (string)flag;
						}
						if ((nint)obj != 5)
						{
							object obj2 = prizeType__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							string text = default;
							string msg = "The prize type " + text + " was out of range, of the defined prizes";
							SDebug.LogFormat(msg, null);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
							dailyChallengeRewardHelper.Refresh();
							return (string)(object)dailyChallengeRewardHelper;
						}
					}
					bool flag2 = ((AgeRestrictionPopup)null).IsValidDateTime(amount__BackingField, 6);
					return (string)flag2;
				}
				return (string)(object)((VideoAdPrize)null).CreateCurrencyReward(2, CelebrationRewardType.welcomePackBoard);
			}
			return (string)(object)((VideoAdPrize)null).CreateCurrencyReward(0, CelebrationRewardType.coins);
		}
		return (string)(object)((VideoAdPrize)null).CreateCurrencyReward(1, CelebrationRewardType.powerup);
	}

	private string GetPrizeTypeAsString()
	{
		//IL_0082: Expected Obj, but got I4
		//IL_000f: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_003c: Expected I4, but got Obj
		PrizePoolState prizePoolState = ((VideoAdPrizeManager)this).prizePoolState;
		bool flag = amount__BackingField > 1;
		bool flag2 = !flag;
		PrizePoolState prizePoolState2 = prizePoolState;
		if (!flag2)
		{
			object obj = amount__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text = (string)prizePoolState + "_" + text2;
			prizePoolState2 = (PrizePoolState)text;
		}
		return (string)prizePoolState2;
	}
}
