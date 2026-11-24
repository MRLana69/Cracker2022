using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway.Info;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.Screens.UpgradeScreenInternal;

public class UpgradeHelper : MonoBehaviour
{
	private enum AnimState
	{
		Closed,
		Opening,
		Open,
		Closing
	}

	private UISprite _powerupIcon;

	private UILabel _titleLabel;

	private UILabel _descriptionLabel;

	private UILabel _amountLabel;

	private UILabel _priceLabel;

	private Layout _priceLayout;

	private BuyButtonIngame _buyButton;

	private UILabel _buttonPriceLabel;

	private Layout _buttonPriceLayout;

	private GameObject _expandedContent;

	private UISprite _openButtonSprite;

	private UISprite _fullBgCollapsed;

	private UISprite _fullBgExpanded;

	private UITierHelper _tierHelper;

	private GameObject _descriptionButton;

	private UILabel _descButtonLabel;

	private TableElementAlwaysVisible _tableElement;

	private UpgradeType _type;

	private UpgradeScreen _upgradeScreen;

	private bool _hasInited;

	private UIPanel _parentPanel;

	private bool _foldedOut;

	private UIPlayTween[] _tweens;

	private bool _wasForceOpened;

	private AnimState _animState;

	private AnimState animState
	{
		get
		{
			//IL_007b: Expected I, but got Obj
			//IL_0091: Expected Obj, but got I
			//IL_00be: Expected I4, but got Obj
			//IL_00d5: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			((UITierHelper)this).AddActiveIndicator((UISprite)(object)_titleLabel);
			CollectCoinsDummy[] array = MigrationSave.ParseDummyData((string)(object)_titleLabel);
			nint num = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v6 (Il2CppClass<Info.Upgrades>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v16 (Il2CppClass<Info.Upgrades>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Upgrade upgrade = Upgrades.upgrades.get_Item((UpgradeType)_titleLabel);
			object obj2 = upgrade.numberOfTiers - 1;
			return (System.Runtime.CompilerServices.Unsafe.As<CollectCoinsDummy[], UIntPtr>(ref array) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2)) ? AnimState.Opening : AnimState.Closed;
		}
		set
		{
			//IL_0861: Expected Obj, but got I4
			//IL_00ee: Expected Obj, but got I4
			//IL_02b4: Expected I, but got Obj
			//IL_02ca: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0899: Expected VT, but got I4
			//IL_0899: Expected Obj, but got I4
			//IL_08ab: Expected I, but got Obj
			//IL_08c1: Expected Obj, but got I
			//IL_02f5: Expected I, but got Obj
			//IL_08f0: Expected Obj, but got I4
			//IL_0054: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_03d0: Expected I, but got Obj
			//IL_03e6: Expected Obj, but got I
			//IL_0411: Expected I, but got Obj
			//IL_045e: Expected I, but got Obj
			//IL_0474: Expected Obj, but got I
			//IL_049f: Expected I, but got Obj
			//IL_0599: Expected Obj, but got I4
			//IL_05c2: Expected I, but got Obj
			//IL_05d8: Expected Obj, but got I
			//IL_064b: Expected Obj, but got I4
			//IL_0603: Expected I, but got Obj
			//IL_0674: Expected I, but got Obj
			//IL_068a: Expected Obj, but got I
			//IL_06fd: Expected Obj, but got I4
			//IL_06b5: Expected I, but got Obj
			//IL_0726: Expected I, but got Obj
			//IL_073c: Expected Obj, but got I
			//IL_07af: Expected Obj, but got I4
			//IL_0767: Expected I, but got Obj
			//IL_07d8: Expected I, but got Obj
			//IL_07ee: Expected Obj, but got I
			//IL_04e7: Expected Obj, but got I4
			//IL_0819: Expected I, but got Obj
			//IL_0510: Expected I, but got Obj
			//IL_0526: Expected Obj, but got I
			//IL_0551: Expected I, but got Obj
			//IL_0342: Expected I, but got Obj
			//IL_0358: Expected Obj, but got I
			//IL_0383: Expected I, but got Obj
			object obj = 0;
			if (value == (AnimState)4)
			{
				nint num = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v113 (Il2CppClass<RewardManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v129 (Il2CppClass<RewardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 vector = ((SSEventsPopup)2).VerifySettingOnline((string)null, (Vector3)0);
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v119 (Il2CppClass<UIScreenController>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v125 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag).ClosePopup();
			}
			object obj4 = value - 1;
			if (value != AnimState.Opening)
			{
				if ((nint)obj4 != 1)
				{
					if ((nint)obj4 != 2)
					{
						if ((nint)obj4 != 3)
						{
							if ((nint)obj4 != 4)
							{
								if ((nint)obj4 != 5)
								{
									if ((nint)obj4 != 6)
									{
										if ((nint)obj4 != 7)
										{
											if ((nint)obj4 != 8)
											{
												if ((nint)obj4 != 9)
												{
													if ((nint)obj4 != 10 && (nint)obj4 != 11 && (nint)obj4 != 12 && (nint)obj4 != 13 && (nint)obj4 == 14)
													{
														nint num5 = (nint)typeof(Flurry);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v104 (Il2CppClass<Flurry>)+BA]");
														object obj5 = (nint)0 & (nint)0x200;
														if (obj5 != null)
														{
															nint num6 = (nint)typeof(Flurry);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v108 (Il2CppClass<Flurry>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
													}
												}
												else
												{
													CollectCoinsDummy[] array = MigrationSave.ParseDummyData((string)value);
													obj = array;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
													nint num7 = (nint)typeof(Flurry);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v95 (Il2CppClass<Flurry>)+BA]");
													object obj6 = (nint)0 & (nint)0x200;
													if (obj6 != null)
													{
														nint num8 = (nint)typeof(Flurry);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v99 (Il2CppClass<Flurry>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
												}
											}
											else
											{
												CollectCoinsDummy[] array2 = MigrationSave.ParseDummyData((string)value);
												obj = array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
												nint num9 = (nint)typeof(Flurry);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v84 (Il2CppClass<Flurry>)+BA]");
												object obj7 = (nint)0 & (nint)0x200;
												if (obj7 != null)
												{
													nint num10 = (nint)typeof(Flurry);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v87 (Il2CppClass<Flurry>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
											}
										}
										else
										{
											CollectCoinsDummy[] array3 = MigrationSave.ParseDummyData((string)value);
											obj = array3;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
											nint num11 = (nint)typeof(Flurry);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v72 (Il2CppClass<Flurry>)+BA]");
											object obj8 = (nint)0 & (nint)0x200;
											if (obj8 != null)
											{
												nint num12 = (nint)typeof(Flurry);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v76 (Il2CppClass<Flurry>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
										}
									}
									else
									{
										CollectCoinsDummy[] array4 = MigrationSave.ParseDummyData((string)value);
										obj = array4;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
										nint num13 = (nint)typeof(Flurry);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v60 (Il2CppClass<Flurry>)+BA]");
										object obj9 = (nint)0 & (nint)0x200;
										if (obj9 != null)
										{
											nint num14 = (nint)typeof(Flurry);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v64 (Il2CppClass<Flurry>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
									}
								}
								else
								{
									CollectCoinsDummy[] array5 = MigrationSave.ParseDummyData((string)value);
									obj = array5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
									nint num15 = (nint)typeof(Flurry);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v48 (Il2CppClass<Flurry>)+BA]");
									object obj10 = (nint)0 & (nint)0x200;
									if (obj10 != null)
									{
										nint num16 = (nint)typeof(Flurry);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v52 (Il2CppClass<Flurry>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
								}
							}
						}
						else
						{
							nint num17 = (nint)typeof(Flurry);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v36 (Il2CppClass<Flurry>)+BA]");
							object obj11 = (nint)0 & (nint)0x200;
							if (obj11 != null)
							{
								nint num18 = (nint)typeof(Flurry);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v40 (Il2CppClass<Flurry>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
						}
					}
					else
					{
						nint num19 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v27 (Il2CppClass<Flurry>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num20 = (nint)typeof(Flurry);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v31 (Il2CppClass<Flurry>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
					}
				}
			}
			else
			{
				nint num21 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v18 (Il2CppClass<Flurry>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num22 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v22 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
			OnClick();
		}
	}

	private void OnEnable()
	{
		//IL_000b: Expected Obj, but got I4
		_descriptionLabel = (UILabel)int.MinValue;
		CancelInvoke();
	}

	private void OnDisable()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<UpgradeType, int> action = default;
		object obj = action + 16;
		obj = this;
		InventorySave.powerupsChanged -= action;
		SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<UpgradeType, int> action2 = default;
		object obj2 = action2 + 16;
		obj2 = this;
		((PurchaseHandler)(object)instance).onUpgradePurchase -= action2;
		OnClick();
		if (~(_hasInited ? 1u : 0u) == 0)
		{
			TriggerContent();
		}
	}

	public void InitSingle(UpgradeType type, UIPanel panel)
	{
		//IL_006d: Expected Obj, but got I4
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected I4, but got Obj
		TableElementAlwaysVisible component = ((GameObject)type).GetComponent<TableElementAlwaysVisible>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component._index = (int)panel;
		}
	}

	public void InitPermanent(UpgradeType type, UIPanel panel)
	{
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_0487: Expected I, but got Obj
		//IL_049d: Expected Obj, but got I
		//IL_063a: Expected I4, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04db: Expected I4, but got Obj
		//IL_00b5: Expected I, but got Obj
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_050e: Expected I4, but got Obj
		//IL_012d: Expected I4, but got Obj
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_0181: Expected I, but got Obj
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0286: Expected Obj, but got I4
		//IL_021e: Expected I, but got Obj
		//IL_0585: Expected I4, but got Obj
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I4
		//IL_05b8: Expected I4, but got Obj
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_034e: Expected I, but got Obj
		//IL_0364: Expected Obj, but got I
		//IL_038f: Expected I, but got Obj
		//IL_03dc: Expected I, but got Obj
		//IL_03f2: Expected Obj, but got I
		//IL_041d: Expected I, but got Obj
		_type = type;
		object obj = this + 92;
		obj = panel;
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v7 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v93 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Upgrade upgrade = Upgrades.upgrades.get_Item(_type);
		_powerupIcon.fillCenter = (byte)(int)upgrade.iconName != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Upgrade upgrade2 = Upgrades.upgrades.get_Item(_type);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v8 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v57 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(upgrade2.name);
		_titleLabel.fontSize = (int)text;
		Upgrade upgrade3 = Upgrades.upgrades.get_Item(_type);
		int fontSize;
		if (upgrade3.description != "")
		{
			fontSize = (int)"";
		}
		else
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v81 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v87 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault(upgrade3.description);
			fontSize = (int)text2;
		}
		_descriptionLabel.fontSize = fontSize;
		nint num7 = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v31 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v74 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = default;
		object obj6 = obj7 + 4;
		Upgrade upgrade4 = Upgrades.upgrades.get_Item(_type);
		object obj9;
		if (upgrade4.pricesRaw != null)
		{
			object obj8 = upgrade4.pricesRaw + 16;
			obj9 = obj8;
		}
		else
		{
			obj9 = -1;
		}
		obj6 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array = default;
		string text3 = string.Concat(array);
		_priceLabel.fontSize = (int)text3;
		Upgrade upgrade5 = Upgrades.upgrades.get_Item(_type);
		object obj11;
		if (upgrade5.pricesRaw != null)
		{
			object obj10 = upgrade5.pricesRaw + 16;
			obj11 = obj10;
		}
		else
		{
			obj11 = -1;
		}
		obj7 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array2 = default;
		string text4 = string.Concat(array2);
		_buttonPriceLabel.fontSize = (int)text4;
		_animState = AnimState.Closed;
		BuyButtonIngame buyButton = _buyButton;
		buyButton._type = _type;
		if (_type != UpgradeType.mysterybox)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_descriptionButton).FindKernel((string)null) != 0)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate(_descriptionButton);
			}
		}
		_hasInited = true;
		OnClick();
		TriggerContent();
	}

	public void UpgradePurchased(UpgradeType type)
	{
		//IL_00f9: Expected Obj, but got I4
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0169: Expected I4, but got Obj
		//IL_0068: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got F4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		string panel = ((Component)type).tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v2 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v24 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIDrawCall uIDrawCall = UIDrawCall.Create((UIPanel)(object)panel, (Material)(object)_powerupIcon, (Texture)(object)"progressbar_bar_on", (Shader)int.MaxValue);
		UnityEngine.Object.DestroyImmediate(uIDrawCall, (byte)(int)"Active" != 0);
		((UIWidget)(object)uIDrawCall).depth = 6;
		GameObject gameObject = uIDrawCall.gameObject;
		object obj2 = 0;
		_ = 0;
		obj2 = -1f;
		_ = 0f;
		_ = 0f;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		((UIWidget)(object)uIDrawCall).height = 18;
		Color color = ((UIWidget)9).color;
		Vector2 localSize = ((UIWidget)13).localSize;
	}

	private void RefreshEvent(UpgradeType type, int amount)
	{
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_035b: Expected Obj, but got I4
		//IL_0369: Expected I, but got Obj
		//IL_037f: Expected Obj, but got I
		//IL_048d: Expected I4, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03bd: Expected I4, but got Obj
		//IL_00b5: Expected I, but got Obj
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_03f0: Expected I4, but got Obj
		//IL_012d: Expected I4, but got Obj
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_0181: Expected I, but got Obj
		//IL_02a0: Expected I, but got Obj
		//IL_02b6: Expected Obj, but got I
		//IL_0229: Expected I, but got Obj
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I4
		//IL_02e1: Expected I, but got Obj
		_type = type;
		object obj = this + 92;
		obj = amount;
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v74 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Upgrade upgrade = Upgrades.upgrades.get_Item(_type);
		_powerupIcon.fillCenter = (byte)(int)upgrade.iconName != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Upgrade upgrade2 = Upgrades.upgrades.get_Item(_type);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v8 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v28 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(upgrade2.name);
		_titleLabel.fontSize = (int)text;
		Upgrade upgrade3 = Upgrades.upgrades.get_Item(_type);
		int fontSize;
		if (upgrade3.description != "")
		{
			fontSize = (int)"";
		}
		else
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v62 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v68 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault(upgrade3.description);
			fontSize = (int)text2;
		}
		_descriptionLabel.fontSize = fontSize;
		object obj5 = this - -64;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj5).FindKernel((string)null) != 0)
		{
			object obj7 = this - -64;
			((UITierHelper)obj7).AddActiveIndicator((UISprite)_type);
		}
		_animState = AnimState.Closed;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v50 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_buyButton).FindKernel((string)null) != 0)
		{
			BuyButtonIngame buyButton = _buyButton;
			buyButton._type = _type;
		}
		_hasInited = true;
		OnClick();
		TriggerContent();
	}

	private void RefreshUpgrade()
	{
		//IL_0069: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		int num2 = default;
		object obj = num2 + 16;
		obj = this;
		InventorySave.SetKeys(num2);
		SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<Characters.CharacterId, int> action = default;
		object obj2 = action + 16;
		obj2 = this;
		((PurchaseHandler)(object)instance).characterPurchased += action;
	}

	private void OnClick()
	{
		//IL_0015: Expected Obj, but got I4
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I4
		//IL_021e: Expected I, but got Obj
		//IL_026b: Expected I, but got Obj
		//IL_0281: Expected Obj, but got I
		//IL_07ff: Expected Obj, but got I4
		//IL_06f8: Expected Obj, but got I4
		//IL_030b: Expected I4, but got Obj
		//IL_02ac: Expected I, but got Obj
		//IL_074b: Expected Obj, but got I4
		//IL_0366: Expected I, but got Obj
		//IL_037c: Expected Obj, but got I
		//IL_082b: Expected I4, but got Obj
		//IL_03f5: Expected I4, but got Obj
		//IL_03a7: Expected I, but got Obj
		//IL_042b: Expected Obj, but got I4
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0460: Expected Obj, but got I4
		//IL_0477: Expected I, but got Obj
		//IL_048d: Expected Obj, but got I
		//IL_0865: Expected Obj, but got I4
		//IL_08a7: Expected Obj, but got I4
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_0527: Expected Obj, but got I4
		//IL_04b8: Expected I, but got Obj
		//IL_0556: Expected Obj, but got I4
		//IL_0578: Expected Obj, but got I4
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_060b: Expected I, but got Obj
		//IL_0621: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I4
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected Obj, but got Unknown
		//IL_06cf: Expected Obj, but got I4
		//IL_064c: Expected I, but got Obj
		//IL_0947: Expected I4, but got Obj
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_06e3: Expected I4, but got Obj
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			return;
		}
		object obj = _type - 1;
		if (_type == UpgradeType.hoverboard)
		{
			goto IL_01cf;
		}
		if ((nint)obj != 1)
		{
			if ((nint)obj == 2)
			{
				goto IL_01cf;
			}
			if ((nint)obj != 3)
			{
				if ((nint)obj != 4)
				{
					if ((nint)obj != 5 && (nint)obj != 6 && (nint)obj != 7 && (nint)obj != 8 && (nint)obj != 9)
					{
						if ((nint)obj != 10 && (nint)obj != 11 && (nint)obj != 12 && (nint)obj != 13 && (nint)obj == 14)
						{
							goto IL_01cf;
						}
					}
					else
					{
						object obj2 = this - -64;
						AnimState animState = ((UpgradeHelper)obj2).animState;
						CollectCoinsDummy[] array = MigrationSave.ParseDummyData((string)_type);
						nint num = (nint)typeof(Upgrades);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v67 (Il2CppClass<Info.Upgrades>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num2 = (nint)typeof(Upgrades);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v110 (Il2CppClass<Info.Upgrades>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Upgrade upgrade = Upgrades.upgrades.get_Item(_type);
						object obj4 = upgrade.numberOfTiers - 1;
						bool flag = System.Runtime.CompilerServices.Unsafe.As<CollectCoinsDummy[], UIntPtr>(ref array) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
						string text = _fullBgCollapsed.tag;
						bool foldedOut = _foldedOut;
						object obj5 = (foldedOut ? 1 : 0) ^ 1;
						string text2 = (string)(flag & obj5);
						((GameObject)(object)text).tag = text2;
						string text3 = _fullBgExpanded.tag;
						bool foldedOut2 = _foldedOut;
						string text4 = (string)(flag & foldedOut2);
						((GameObject)(object)text3).tag = text4;
						string text5 = _priceLayout.tag;
						object obj6 = (flag ? 1 : 0) ^ 1;
						bool foldedOut3 = _foldedOut;
						object obj7 = (foldedOut3 ? 1 : 0) ^ 1;
						string text6 = (string)(obj6 & obj7);
						((GameObject)(object)text5).tag = text6;
						string text7 = _buyButton.tag;
						bool foldedOut4 = _foldedOut;
						string text8 = (string)(foldedOut4 & obj6);
						((GameObject)(object)text7).tag = text8;
						if (!flag)
						{
							nint num3 = (nint)typeof(Upgrades);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v70 (Il2CppClass<Info.Upgrades>)+BA]");
							object obj8 = (nint)0 & (nint)0x200;
							if (obj8 != null)
							{
								nint num4 = (nint)typeof(Upgrades);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v91 (Il2CppClass<Info.Upgrades>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Upgrade upgrade2 = Upgrades.upgrades.get_Item(_type);
							CollectCoinsDummy[] array2 = MigrationSave.ParseDummyData((string)_type);
							object obj9 = array2 + 1;
							object obj13;
							if (upgrade2.pricesRaw != null)
							{
								object obj10 = upgrade2.pricesRaw + 16;
								object obj11 = obj9 << 2;
								object obj12 = obj10 + obj11;
								obj13 = obj12;
							}
							else
							{
								obj13 = -1;
							}
							object obj14 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							object[] array3 = default;
							string text9 = string.Concat(array3);
							_priceLabel.fontSize = (int)text9;
							_buttonPriceLabel.fontSize = (int)text9;
						}
					}
				}
			}
			else
			{
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v44 (Il2CppClass<Strings>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v59 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text10 = Strings.GetDefault("UPGRADES_HELPER_MYSTERY_BOX");
				_amountLabel.fontSize = (int)text10;
				string text11 = Strings.GetDefault("UPGRADES_MYSTERYBOX_VIEW_PRIZES");
				_descButtonLabel.fontSize = (int)text11;
				string text12 = _priceLayout.tag;
				bool foldedOut5 = _foldedOut;
				string text13 = (string)((foldedOut5 ? 1 : 0) ^ 1);
				((GameObject)(object)text12).tag = text13;
			}
		}
		goto IL_0774;
		IL_0774:
		string text14 = _priceLayout.tag;
		string text15 = ((GameObject)(object)text14).tag;
		if (text15 != null)
		{
			((RewardForVideoButton)(object)_priceLayout).Init((VideoButtonPayload)1);
		}
		string text16 = _buttonPriceLayout.tag;
		string text17 = ((GameObject)(object)text16).tag;
		if (text17 != null)
		{
			((RewardForVideoButton)(object)_buttonPriceLayout).Init((VideoButtonPayload)1);
			_descriptionLabel.ResetAnchors();
		}
		return;
		IL_01cf:
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_amountLabel).FindKernel((string)null) != 0)
		{
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v27 (Il2CppClass<Strings>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v35 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault("UPGRADES_HELPER_YOU_HAVE");
			int tier = InventorySave.GetTier(_type);
			object obj14 = tier;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text18 = string.Format(format, args);
			_amountLabel.fontSize = (int)text18;
		}
		string text19 = _priceLayout.tag;
		bool foldedOut6 = _foldedOut;
		string text20 = (string)((foldedOut6 ? 1 : 0) ^ 1);
		((GameObject)(object)text19).tag = text20;
		goto IL_0774;
	}

	private void AnimationStarted()
	{
		AnimationEnded();
	}

	public void AnimationEnded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got I4
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_004e: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_008f: Expected I, but got Obj
		//IL_00e6: Expected I, but got Obj
		//IL_00fc: Expected Obj, but got I
		//IL_062a: Expected I, but got Obj
		//IL_0640: Expected Obj, but got I
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected Obj, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05db: Expected Obj, but got I4
		//IL_0127: Expected I, but got Obj
		//IL_03b2: Expected I, but got Obj
		//IL_042b: Expected I, but got Obj
		//IL_0441: Expected Obj, but got I
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_046c: Expected I, but got Obj
		//IL_01e1: Expected I, but got Obj
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (_animState == AnimState.Closed || _animState == AnimState.Closing)
		{
			_animState = AnimState.Opening;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v96 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_upgradeScreen != null)
			{
				string go = tag;
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v135 (Il2CppClass<NGUITools>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v141 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj7 = this + 84;
				UpgradeScreen upgradeScreen = NGUITools.FindInParents<UpgradeScreen>((GameObject)(object)go);
				obj7 = upgradeScreen;
			}
			UpgradeScreen upgradeScreen2 = _upgradeScreen;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj8 = default;
			object obj10 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj8 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v108 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v125 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v104+6C]");
					if ((nint)0 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					}
				}
			}
			object obj11 = obj4 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj4 + obj13;
			obj14 = 143;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj15 = (nint)0 << 2;
				object obj16 = obj4 + obj15;
				if ((nint)obj16 == 143)
				{
					object obj17 = obj4 + 4;
					if ((nint)obj17 > -1)
					{
						object obj18 = obj17 + -1;
						obj17 = obj18;
					}
					goto IL_0616;
				}
			}
			object obj19 = default;
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				goto IL_0616;
			}
		}
		_animState = AnimState.Closing;
		goto IL_0616;
		IL_0616:
		this._002Ector();
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_parentPanel).FindKernel((string)null) != 0)
		{
			_parentPanel._002Ector();
		}
		string text = tag;
		Collider component = ((GameObject)(object)text).GetComponent<Collider>();
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component.isTrigger = false;
		}
	}

	private void ForceExpandContent(bool expand)
	{
		_animState = (expand ? AnimState.Opening : AnimState.Closed);
	}

	private void SetFoldout()
	{
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_00c9: Expected I, but got Obj
		//IL_002e: Expected Obj, but got I4
		if (_animState != AnimState.Closing && _animState != AnimState.Opening)
		{
			object obj = _animState;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "Unexpected anim state: " + text;
			SDebug.LogFormat(msg, (object[])(object)this);
			return;
		}
		string text2 = tag;
		Collider component = ((GameObject)(object)text2).GetComponent<Collider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component.isTrigger = true;
		}
		AnimState animState = ((_animState != AnimState.Closing) ? AnimState.Open : AnimState.Closed);
		_animState = animState;
		FoldClicked();
	}

	private void TriggerContent()
	{
		//IL_00e5: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I4
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.yutani);
		bool flag2 = !flag;
		bool flag3 = _type != UpgradeType.mysterybox;
		object obj2 = flag2 | flag3;
		if (obj2 != null)
		{
			if (~(_wasForceOpened ? 1u : 0u) == 0)
			{
				ContentActivation(foldedOut: false);
				return;
			}
			bool foldedOut = _foldedOut;
			((CelebrationReward)(object)this).PopulateFromString((string)foldedOut);
		}
		else if (~(_foldedOut ? 1u : 0u) != 0)
		{
			ContentActivation(foldedOut: true);
		}
	}

	private void FoldClicked()
	{
		//IL_0037: Expected Obj, but got I4
		if (~(_foldedOut ? 1u : 0u) == 0)
		{
			bool foldedOut = _foldedOut;
			((CelebrationReward)(object)this).PopulateFromString((string)foldedOut);
		}
	}

	private void ContentActivation(bool foldedOut)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		_wasForceOpened = foldedOut;
		object obj = this + 76;
		string text = tag;
		TableElementAlwaysVisible component = ((GameObject)(object)text).GetComponent<TableElementAlwaysVisible>();
		obj = component;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_tableElement).FindKernel((string)null) != 0)
		{
			_tableElement.OnDestroy();
		}
		if (_tweens == null)
		{
			object obj3 = this + 100;
			string text2 = tag;
			_0021_00210[] componentsInChildren = (_0021_00210[])(object)((GameObject)(object)text2).GetComponentsInChildren<T>();
			obj3 = componentsInChildren;
		}
		if (_tweens != null)
		{
			object obj4 = _tweens + 12;
			object obj5 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				object obj6 = _tweens + 16;
				object obj7 = obj5 << 2;
				object obj8 = obj6 + obj7;
				((UIPopupList)obj8).ambigiousFont = (UnityEngine.Object)foldedOut;
				object obj9 = obj5 + 1;
				obj5 = obj9;
			}
		}
		AnimationEnded();
	}

	public UpgradeHelper()
	{
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		if (~(_foldedOut ? 1u : 0u) == 0)
		{
			_foldedOut = false;
			((CelebrationReward)(object)this).PopulateFromString((string)null);
			return;
		}
		_foldedOut = true;
		string text = _openButtonSprite.tag;
		((GameObject)(object)text).tag = null;
		string text2 = _priceLayout.tag;
		((GameObject)(object)text2).tag = null;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_fullBgCollapsed).FindKernel((string)null) != 0)
		{
			string text3 = _fullBgCollapsed.tag;
			((GameObject)(object)text3).tag = null;
		}
	}
}
