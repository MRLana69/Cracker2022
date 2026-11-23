using System;
using Cpp2ILInjected;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace UI;

public class UpgradeHelper : MonoBehaviour
{
	private enum AnimState
	{
		Closed,
		Opening,
		Open,
		Closing
	}

	public BoostScreen boostScreen;

	private Image iconBG;

	public Image powerupIcon;

	public TMP_Text titleLabel;

	public TMP_Text descLabel;

	public TMP_Text priceLabel;

	public TMP_Text amountLabel;

	public BoxCollider descriptionButtonCollider;

	public UITierHelper tierHelper;

	private BuyButtonIngame buyButtonIngame;

	private Button ViewprizesButton;

	public GameObject price;

	public GameObject full;

	public PowerupType _type;

	private UpgradeScreen _upgradeScreen;

	private bool _hasInited;

	private bool _fixCollider;

	private UIPanel _parentPanel;

	public ContentChange contentChanger;

	private AnimState _animState;

	private AnimState animState
	{
		get
		{
			return _animState;
		}
		set
		{
			_animState = value;
		}
	}

	private void OnEnable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	public unsafe void InitSingle(BoostScreen boostScreen, PowerupType type, UIPanel panel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0102: Expected I, but got Obj
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected I4, but got Unknown
		//IL_018c: Expected I, but got Obj
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_0455: Expected I, but got Obj
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_047f: Expected I, but got Obj
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got I4
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0767: Expected I4, but got Obj
		//IL_0785: Expected Obj, but got I
		//IL_02cb: Expected I, but got Obj
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_07b8: Expected I4, but got Obj
		//IL_07d6: Expected Obj, but got I
		//IL_036f: Expected I, but got Obj
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_07ee: Expected I4, but got Obj
		//IL_080c: Expected Obj, but got I
		//IL_0413: Expected I, but got Obj
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected I4, but got Unknown
		//IL_0555: Expected I, but got Obj
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		this.boostScreen = boostScreen;
		_parentPanel = panel;
		_type = type;
		Upgrade upgrade = Upgrades.upgrades.get_Item(type);
		string path = "UI/" + upgrade.iconName;
		Sprite sprite = Resources.Load<Sprite>(path);
		powerupIcon.sprite = sprite;
		TMP_Text tMP_Text = titleLabel;
		Upgrade upgrade2 = Upgrades.upgrades.get_Item(type);
		string text = Strings.Get(upgrade2.name);
		nint num = (nint)tMP_Text;
		object obj3 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S2_v12 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Upgrade upgrade3 = Upgrades.upgrades.get_Item(type);
		TMP_Text tMP_Text2 = descLabel;
		if (upgrade3.description == StringID.NULL)
		{
			string empty = string.Empty;
		}
		else
		{
			string empty = Strings.Get(upgrade3.description);
		}
		nint num2 = (nint)tMP_Text2;
		object obj4 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S2_v19 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text3 = priceLabel;
		Upgrade upgrade4 = Upgrades.upgrades.get_Item(type);
		int num3 = upgrade4.getPrice(0);
		int num4 = obj + 44;
		string text2 = ((int*)num4)->ToString();
		string text3 = string.Empty + text2;
		nint num5 = (nint)tMP_Text3;
		object obj5 = tMP_Text3 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v158 @ S2_v28 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		_animState = AnimState.Closed;
		if (type != PowerupType.mysterybox)
		{
			object obj6 = type - 11;
			if (type != PowerupType.skipmission1)
			{
				if ((nint)obj6 != 1)
				{
					if ((nint)obj6 == 2)
					{
						MissionsManager instance = MissionsManager.Instance;
						MissionInfo missionInfo = instance.GetMissionInfo(2);
						object obj7 = obj + 20;
						object obj8 = obj + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						if ((nint)0 != 1)
						{
							obj7 = obj8;
						}
						string format = Strings.Get((StringID)obj7);
						TMP_Text tMP_Text4 = amountLabel;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object arg = default;
						string text4 = string.Format(format, arg);
						nint num6 = (nint)tMP_Text4;
						object obj9 = tMP_Text4 + 528;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v427 @ S2_v89 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
					}
					else
					{
						TMP_Text tMP_Text5 = amountLabel;
						string text5 = Strings.Get(StringID.UPGRADES_HELPER_YOU_HAVE);
						PlayerInfo instance2 = PlayerInfo.Instance;
						int upgradeAmount = instance2.GetUpgradeAmount(type);
						int num7 = obj + 44;
						string text6 = ((int*)num7)->ToString();
						string text7 = text5 + " " + text6;
						nint num8 = (nint)tMP_Text5;
						object obj10 = tMP_Text5 + 528;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v441 @ S2_v96 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
					}
				}
				else
				{
					MissionsManager instance3 = MissionsManager.Instance;
					MissionInfo missionInfo2 = instance3.GetMissionInfo(1);
					object obj11 = obj + 20;
					object obj12 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					if ((nint)0 != 1)
					{
						obj11 = obj12;
					}
					string format2 = Strings.Get((StringID)obj11);
					TMP_Text tMP_Text6 = amountLabel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object arg2 = default;
					string text8 = string.Format(format2, arg2);
					nint num9 = (nint)tMP_Text6;
					object obj13 = tMP_Text6 + 528;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v410 @ S2_v77 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				}
			}
			else
			{
				MissionsManager instance4 = MissionsManager.Instance;
				MissionInfo missionInfo3 = instance4.GetMissionInfo(0);
				object obj14 = obj + 20;
				object obj15 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if ((nint)0 != 1)
				{
					obj14 = obj15;
				}
				string format3 = Strings.Get((StringID)obj14);
				TMP_Text tMP_Text7 = amountLabel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg3 = default;
				string text9 = string.Format(format3, arg3);
				nint num10 = (nint)tMP_Text7;
				object obj16 = tMP_Text7 + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v396 @ S2_v65 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			}
		}
		else
		{
			TMP_Text tMP_Text8 = descLabel;
			string text10 = Strings.Get(StringID.UPGRADES_HELPER_MYSTERY_BOX);
			nint num11 = (nint)tMP_Text8;
			object obj17 = tMP_Text8 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ S2_v48 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text9 = amountLabel;
			nint num12 = (nint)tMP_Text9;
			object obj18 = tMP_Text9 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v213 @ S2_v52 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			ContentChange contentChange = contentChanger;
			contentChange.powerupType = PowerupType.mysterybox;
			GameObject gameObject = ViewprizesButton.gameObject;
			gameObject.SetActive(value: true);
		}
		PlayerInfo instance5 = PlayerInfo.Instance;
		int amountOfCoins = instance5.amountOfCoins;
		Upgrade upgrade5 = Upgrades.upgrades.get_Item(type);
		BuyButtonIngame buyButtonIngame = this.buyButtonIngame;
		bool interactable = amountOfCoins >= upgrade5.coinmagnetRange;
		buyButtonIngame.PayButton.interactable = interactable;
		if (type != PowerupType.mysterybox)
		{
			ContentChange contentChange2 = contentChanger;
			if (contentChange2.descriptionButton != null)
			{
				ContentChange contentChange3 = contentChanger;
				UnityEngine.Object.Destroy(contentChange3.descriptionButton);
			}
		}
		_hasInited = true;
		PlayerInfo instance6 = PlayerInfo.Instance;
		if (instance6.IsUpgradeStackable(_type))
		{
			PlayerInfo instance7 = PlayerInfo.Instance;
			int upgradeAmount2 = instance7.GetUpgradeAmount(_type);
			RefreshUpgrade(_type, upgradeAmount2);
		}
		else
		{
			PlayerInfo instance8 = PlayerInfo.Instance;
			if (instance8.IsUpgradeTiered(_type))
			{
				RefreshUpgrade(_type, 0);
			}
		}
		_fixCollider = true;
	}

	public unsafe void InitPermanent(PowerupType type, UIPanel panel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0102: Expected I, but got Obj
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got I4
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected I4, but got Unknown
		//IL_02e2: Expected I, but got Obj
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_parentPanel = panel;
		_type = type;
		Upgrade upgrade = Upgrades.upgrades.get_Item(type);
		string path = "UI/" + upgrade.iconName;
		Sprite sprite = Resources.Load<Sprite>(path);
		powerupIcon.sprite = sprite;
		TMP_Text tMP_Text = titleLabel;
		Upgrade upgrade2 = Upgrades.upgrades.get_Item(type);
		string text = Strings.Get(upgrade2.name);
		nint num = (nint)tMP_Text;
		object obj3 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S2_v12 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Upgrade upgrade3 = Upgrades.upgrades.get_Item(type);
		TMP_Text tMP_Text2 = descLabel;
		if (upgrade3.description == StringID.NULL)
		{
			string empty = string.Empty;
		}
		else
		{
			string empty = Strings.Get(upgrade3.description);
		}
		nint num2 = (nint)tMP_Text2;
		object obj4 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S2_v19 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		if (tierHelper != null)
		{
			tierHelper.SetupTiers(type);
		}
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfCoins = instance.amountOfCoins;
		Upgrade upgrade4 = Upgrades.upgrades.get_Item(type);
		_animState = AnimState.Closed;
		PlayerInfo instance2 = PlayerInfo.Instance;
		int currentTier = instance2.GetCurrentTier(type);
		Upgrade upgrade5 = Upgrades.upgrades.get_Item(type);
		object obj5 = upgrade5.numberOfTiers - 1;
		bool interactable;
		if (currentTier >= (nint)obj5)
		{
			price.SetActive(value: false);
			full.SetActive(value: true);
			interactable = false;
		}
		else
		{
			TMP_Text tMP_Text3 = priceLabel;
			Upgrade upgrade6 = Upgrades.upgrades.get_Item(type);
			PlayerInfo instance3 = PlayerInfo.Instance;
			int currentTier2 = instance3.GetCurrentTier(type);
			int tier = currentTier2 + 1;
			int num3 = upgrade6.getPrice(tier);
			int num4 = obj + 12;
			string text2 = ((int*)num4)->ToString();
			string text3 = string.Empty + text2;
			nint num5 = (nint)tMP_Text3;
			object obj6 = tMP_Text3 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ S2_v48 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			interactable = amountOfCoins >= upgrade4.coinmagnetRange;
		}
		BuyButtonIngame buyButtonIngame = this.buyButtonIngame;
		buyButtonIngame.PayButton.interactable = interactable;
		_hasInited = true;
		PlayerInfo instance4 = PlayerInfo.Instance;
		if (instance4.IsUpgradeStackable(_type))
		{
			PlayerInfo instance5 = PlayerInfo.Instance;
			int upgradeAmount = instance5.GetUpgradeAmount(_type);
			RefreshUpgrade(_type, upgradeAmount);
		}
		else
		{
			PlayerInfo instance6 = PlayerInfo.Instance;
			if (instance6.IsUpgradeTiered(_type))
			{
				RefreshUpgrade(_type, 0);
			}
		}
		_fixCollider = true;
	}

	public unsafe void UpgradePurchased(PowerupType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I4
		//IL_05c8: Expected Obj, but got I4
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected I4, but got Unknown
		//IL_0291: Expected I, but got Obj
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected I4, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected I4, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected I4, but got Unknown
		//IL_03e2: Expected I, but got Obj
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected I4, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected I4, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected I4, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected I4, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected I4, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfCoins = instance.amountOfCoins;
		Upgrade upgrade = Upgrades.upgrades.get_Item(type);
		bool flag = amountOfCoins >= upgrade.coinmagnetRange;
		object obj3 = type - 1;
		bool interactable;
		if (type != PowerupType.hoverboard && (nint)obj3 != 1 && (nint)obj3 != 2)
		{
			if ((nint)obj3 != 3)
			{
				bool flag2 = (nint)obj3 == 4;
				interactable = flag;
				if (!flag2)
				{
					if ((nint)obj3 != 5 && (nint)obj3 != 6 && (nint)obj3 != 7 && (nint)obj3 != 8 && (nint)obj3 != 9)
					{
						if ((nint)obj3 != 10)
						{
							if ((nint)obj3 != 11)
							{
								if ((nint)obj3 != 12)
								{
									interactable = flag;
								}
								else
								{
									MissionsManager instance2 = MissionsManager.Instance;
									PlayerInfo playerinfo = instance2.playerinfo;
									_ = playerinfo._currentMissionSet;
									int num = obj + 12;
									string text = ((int*)num)->ToString();
									string text2 = text + "-2";
									MissionsManager instance3 = MissionsManager.Instance;
									instance3.SkipMission(2);
									interactable = flag;
								}
							}
							else
							{
								MissionsManager instance4 = MissionsManager.Instance;
								PlayerInfo playerinfo2 = instance4.playerinfo;
								_ = playerinfo2._currentMissionSet;
								int num2 = obj + 12;
								string text3 = ((int*)num2)->ToString();
								string text4 = text3 + "-1";
								MissionsManager instance5 = MissionsManager.Instance;
								instance5.SkipMission(1);
								interactable = flag;
							}
						}
						else
						{
							MissionsManager instance6 = MissionsManager.Instance;
							PlayerInfo playerinfo3 = instance6.playerinfo;
							_ = playerinfo3._currentMissionSet;
							int num3 = obj + 12;
							string text5 = ((int*)num3)->ToString();
							string text6 = text5 + "-0";
							MissionsManager instance7 = MissionsManager.Instance;
							instance7.SkipMission(0);
							interactable = flag;
						}
					}
					else if (tierHelper != null && tierHelper.ResetTiers())
					{
						price.SetActive(value: false);
						full.SetActive(value: true);
						interactable = false;
					}
					else
					{
						TMP_Text tMP_Text = priceLabel;
						Upgrade upgrade2 = Upgrades.upgrades.get_Item(type);
						PlayerInfo instance8 = PlayerInfo.Instance;
						int currentTier = instance8.GetCurrentTier(type);
						int tier = currentTier + 1;
						int num4 = upgrade2.getPrice(tier);
						int num5 = obj + 12;
						string text7 = ((int*)num5)->ToString();
						string text8 = string.Empty + text7;
						nint num6 = (nint)tMP_Text;
						object obj4 = tMP_Text + 528;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ S2_v30 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
						interactable = flag;
					}
				}
			}
			else
			{
				RewardManager.AddRewardToUnlock(CelebrationRewardOrigin.MysteryBox);
				UIScreenController instance9 = UIScreenController.Instance;
				instance9.QueueMysteryBox();
				interactable = flag;
			}
		}
		else
		{
			bool flag3 = amountLabel != null;
			bool flag4 = !flag3;
			interactable = flag;
			if (!flag4)
			{
				TMP_Text tMP_Text2 = amountLabel;
				string text9 = Strings.Get(StringID.UPGRADES_HELPER_YOU_HAVE);
				PlayerInfo instance10 = PlayerInfo.Instance;
				int upgradeAmount = instance10.GetUpgradeAmount(type);
				int num7 = obj + 12;
				string text10 = ((int*)num7)->ToString();
				string text11 = text9 + " " + text10;
				nint num8 = (nint)tMP_Text2;
				object obj5 = tMP_Text2 + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ S2_v15 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				interactable = flag;
			}
		}
		object obj6 = type - 1;
		if (type != PowerupType.hoverboard && (nint)obj6 != 1 && (nint)obj6 != 2 && (nint)obj6 != 3 && (nint)obj6 != 4)
		{
			if ((nint)obj6 != 5)
			{
				if ((nint)obj6 != 6)
				{
					if ((nint)obj6 != 7)
					{
						if ((nint)obj6 != 8)
						{
							if ((nint)obj6 != 9)
							{
								if ((nint)obj6 != 10 && (nint)obj6 != 11 && (nint)obj6 != 12 && (nint)obj6 != 13 && (nint)obj6 == 14)
								{
								}
							}
							else
							{
								PlayerInfo instance11 = PlayerInfo.Instance;
								int currentTier2 = instance11.GetCurrentTier(type);
								int num9 = obj + 12;
								string text12 = ((int*)num9)->ToString();
							}
						}
						else
						{
							PlayerInfo instance12 = PlayerInfo.Instance;
							int currentTier3 = instance12.GetCurrentTier(type);
							int num10 = obj + 12;
							string text13 = ((int*)num10)->ToString();
						}
					}
					else
					{
						PlayerInfo instance13 = PlayerInfo.Instance;
						int currentTier4 = instance13.GetCurrentTier(type);
						int num11 = obj + 12;
						string text14 = ((int*)num11)->ToString();
					}
				}
				else
				{
					PlayerInfo instance14 = PlayerInfo.Instance;
					int currentTier5 = instance14.GetCurrentTier(type);
					int num12 = obj + 12;
					string text15 = ((int*)num12)->ToString();
				}
			}
			else
			{
				PlayerInfo instance15 = PlayerInfo.Instance;
				int currentTier6 = instance15.GetCurrentTier(type);
				int num13 = obj + 12;
				string text16 = ((int*)num13)->ToString();
			}
		}
		BuyButtonIngame buyButtonIngame = this.buyButtonIngame;
		buyButtonIngame.PayButton.interactable = interactable;
		PlayerInfo instance16 = PlayerInfo.Instance;
		instance16.SaveIfDirty();
	}

	private unsafe void RefreshUpgrade(PowerupType type, int newAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected I4, but got Unknown
		//IL_0321: Expected I, but got Obj
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected I4, but got Unknown
		//IL_01cc: Expected I, but got Obj
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (~(_hasInited ? 1u : 0u) != 0 || _type != type)
		{
			return;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfCoins = instance.amountOfCoins;
		Upgrade upgrade = Upgrades.upgrades.get_Item(type);
		bool flag = amountOfCoins >= upgrade.coinmagnetRange;
		object obj3 = _type - 1;
		bool flag2 = (nint)obj3 > 14;
		bool interactable = flag;
		if (!flag2)
		{
			object obj4 = 1 << (int)obj3;
			object obj5 = obj4 & 0x3E0;
			if (obj5 == null)
			{
				object obj6 = 1 << (int)obj3;
				object obj7 = obj6 & 0x4007;
				bool flag3 = obj7 == null;
				interactable = flag;
				if (!flag3)
				{
					bool flag4 = amountLabel != null;
					bool flag5 = !flag4;
					interactable = flag;
					if (!flag5)
					{
						TMP_Text tMP_Text = amountLabel;
						string text = Strings.Get(StringID.UPGRADES_HELPER_YOU_HAVE);
						int num = obj + 12;
						string text2 = ((int*)num)->ToString();
						string text3 = text + " " + text2;
						nint num2 = (nint)tMP_Text;
						object obj8 = tMP_Text + 528;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v213 @ S2_v25 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
						interactable = flag;
					}
				}
			}
			else if (tierHelper != null && tierHelper.ResetTiers())
			{
				price.SetActive(value: false);
				full.SetActive(value: true);
				interactable = false;
			}
			else
			{
				TMP_Text tMP_Text2 = priceLabel;
				Upgrade upgrade2 = Upgrades.upgrades.get_Item(_type);
				PlayerInfo instance2 = PlayerInfo.Instance;
				int currentTier = instance2.GetCurrentTier(_type);
				int tier = currentTier + 1;
				int num3 = upgrade2.getPrice(tier);
				int num4 = obj + 8;
				string text4 = ((int*)num4)->ToString();
				string text5 = string.Empty + text4;
				nint num5 = (nint)tMP_Text2;
				object obj9 = tMP_Text2 + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ S2_v16 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				interactable = flag;
			}
		}
		BuyButtonIngame buyButtonIngame = this.buyButtonIngame;
		buyButtonIngame.PayButton.interactable = interactable;
	}

	public void AnimationStarted()
	{
	}

	public void AnimationEnded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		object obj3 = _animState - 1;
		if (_animState == AnimState.Opening || ((nint)obj3 != 1 && (nint)obj3 == 2))
		{
			GameObject go = gameObject;
			NGUITools.AddWidgetCollider(go);
			bool flag = _animState != AnimState.Closing;
			AnimState animState = (AnimState)((flag ? 1u : 0u) << 1);
			_animState = animState;
			contentChanger.TriggerContent();
		}
		else
		{
			_ = _animState;
			_ = -1;
			obj = (Enum)(object)typeof(AnimState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string text2 = "Unexpected anim state: " + text;
		}
	}
}
