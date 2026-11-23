using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;

namespace UI.Screens;

public class CharacterScreenManager
{
	public enum CharacterPurchaseInitiator
	{
		none,
		characterScreen,
		characterNameEvent,
		limitedCharacterPopup,
		BirthdayCharacterComeback
	}

	private static CharacterScreenManager _instance;

	private List<KeyValuePair<Characters.CharacterType, Characters.Model>> _characterList;

	private PlayerInfo _playerInfoInstance;

	private bool _purchaseInProgress;

	private bool _facebookLoginRunning;

	private CharacterPurchaseInitiator _characterPurchaseInitiator;

	private Action<Characters.CharacterType, int> _onCharacterUnlocked;

	public Action OnFacebookStatusChanged;

	private static Action m_onCharacterSelected;

	public Characters.CharacterType currentlyShownCharacter
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public int currentlyShownThemeIndex
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public static CharacterScreenManager Instance
	{
		get
		{
			if (_instance == null)
			{
				CharacterScreenManager characterScreenManager = default;
				characterScreenManager._002Ector();
				_instance = characterScreenManager;
			}
			return _instance;
		}
	}

	public static bool isInitialized => _instance != null;

	public static event Action onCharacterSelected
	{
		add
		{
			Delegate obj = CharacterScreenManager.m_onCharacterSelected;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == CharacterScreenManager.m_onCharacterSelected;
				Action action = action2;
				if (!flag)
				{
					action = CharacterScreenManager.m_onCharacterSelected;
				}
				CharacterScreenManager.m_onCharacterSelected = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = CharacterScreenManager.m_onCharacterSelected;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = CharacterScreenManager.m_onCharacterSelected;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == CharacterScreenManager.m_onCharacterSelected;
				Action action = action2;
				if (!flag)
				{
					action = CharacterScreenManager.m_onCharacterSelected;
				}
				CharacterScreenManager.m_onCharacterSelected = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = CharacterScreenManager.m_onCharacterSelected;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private CharacterScreenManager()
	{
		List<KeyValuePair<Characters.CharacterType, Characters.Model>> list = default;
		list._002Ector();
		_characterList = list;
		_playerInfoInstance = PlayerInfo.Instance;
	}

	public void PurchaseCharacter(CharacterPurchaseInitiator initiator, Characters.CharacterType characterType, int themeIndex, int priceOverride = -1)
	{
		if (~(_purchaseInProgress ? 1u : 0u) != 0)
		{
			_characterPurchaseInitiator = initiator;
			_purchaseInProgress = true;
			PurchaseHandler instance = PurchaseHandler.Instance;
			instance.PurchaseCharacter(characterType, themeIndex, priceOverride);
		}
	}

	public void PurchaseCharacterWithInapp(CharacterPurchaseInitiator initiator, Characters.CharacterType characterType)
	{
		if (~(_purchaseInProgress ? 1u : 0u) != 0)
		{
			_characterPurchaseInitiator = initiator;
			_purchaseInProgress = true;
			PurchaseHandler instance = PurchaseHandler.Instance;
			instance.StartPurchaseCharacterWithInapp(characterType);
		}
	}

	public unsafe void CharacterPurchaseSuccessful(Characters.CharacterType purchasedCharacter, int themeIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected I4, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (~(_purchaseInProgress ? 1u : 0u) != 0)
		{
			return;
		}
		if (themeIndex == 0 && _characterPurchaseInitiator == CharacterPurchaseInitiator.characterNameEvent)
		{
			Characters.CharacterType key = default;
			Characters.Model model = Characters.characterData.get_Item(key);
			if (model.unlockType == PurchaseData.UnlockType.Coins)
			{
				Enum obj3 = (Enum)(obj + 16);
				_ = -1;
				obj3 = (Enum)(object)typeof(Characters.CharacterType);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				_ = 0;
				string text = obj3.ToString();
				Dictionary<Characters.CharacterType, Characters.Model> characterData = Characters.characterData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				Characters.Model model2 = characterData.get_Item(Characters.CharacterType.slick);
				int num = model2 + 16;
				string text2 = ((int*)num)->ToString();
				string text3 = text + ";" + text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				_ = 0;
				object obj4 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg = default;
				string text4 = $"{arg} unlocked for Wordy Weekend";
			}
		}
		_characterPurchaseInitiator = CharacterPurchaseInitiator.none;
		_purchaseInProgress = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		OnCharacterUnlocked(Characters.CharacterType.slick, themeIndex);
		UIScreenController instance = UIScreenController.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		instance.ShowUnlockAnimationForCharacter(Characters.CharacterType.slick, themeIndex);
		PlayerInfo instance2 = PlayerInfo.Instance;
		instance2.SaveIfDirty();
	}

	public void CharacterPurchaseFailure()
	{
		if (~(_purchaseInProgress ? 1u : 0u) == 0)
		{
			_purchaseInProgress = false;
			_characterPurchaseInitiator = CharacterPurchaseInitiator.none;
		}
	}

	public void AddOnCharacterUnlockedListener(Action<Characters.CharacterType, int> handler)
	{
		if (handler != null)
		{
			Delegate obj = Delegate.Combine(_onCharacterUnlocked, handler);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			Action<Characters.CharacterType, int> onCharacterUnlocked = default;
			_onCharacterUnlocked = onCharacterUnlocked;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		}
	}

	public void RemoveOnCharacterUnlockedListener(Action<Characters.CharacterType, int> handler)
	{
		if (handler != null)
		{
			Delegate obj = Delegate.Remove(_onCharacterUnlocked, handler);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			Action<Characters.CharacterType, int> onCharacterUnlocked = default;
			_onCharacterUnlocked = onCharacterUnlocked;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		}
	}

	private void OnCharacterUnlocked(Characters.CharacterType character, int version)
	{
		if (_onCharacterUnlocked != null)
		{
			SelectCharacter(character, version);
			Action<Characters.CharacterType, int> onCharacterUnlocked = _onCharacterUnlocked;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S0_v6 (System.Action`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>)+C] (should have been resolved before IL gen)");
		}
	}

	public void SelectCharacter(Characters.CharacterType charType, int themeIndex)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = instance.IsCharacterOwned(charType);
		PlayerInfo instance2 = PlayerInfo.Instance;
		bool flag2 = instance2.IsThemeUnlockedForCharacter(charType, themeIndex);
		if (flag && flag2)
		{
			UIModelController instance3 = UIModelController.Instance;
			instance3.SelectCharacterForPlay(charType, themeIndex);
			CharacterScreen.forceCenterOnCurrentlySelectedCharacter = true;
			Action action = CharacterScreenManager.m_onCharacterSelected;
			if (CharacterScreenManager.m_onCharacterSelected != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public void StartLoginToFacebook()
	{
		throw new ArgumentException();
	}

	public unsafe void OnFacebookLoginResult(bool loggedIn)
	{
		if (!loggedIn)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(CharacterScreenManager.OnFacebookLoginStopped));
			QueueFacebookFailSlideIn(action);
		}
		else
		{
			_facebookLoginRunning = false;
		}
	}

	private void OnFacebookLoginStopped()
	{
		_facebookLoginRunning = false;
		Action onFacebookStatusChanged = OnFacebookStatusChanged;
		if (OnFacebookStatusChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		UIScreenController instance = UIScreenController.Instance;
		UIScreenController.SlideIn slideIn = default;
		slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectFailed, onFinishCallback);
		instance.QueueSlideIn(slideIn);
	}

	private void FacebookStatusChanged(bool success)
	{
		HouseKeeper.SetFacebookPayoutActionToDefault();
		if (success)
		{
			_facebookLoginRunning = false;
			if (!FacebookRewardsInfo.HasReceivedAllAvailableRewards())
			{
				UIScreenController instance = UIScreenController.Instance;
				instance.PushPopup("FacebookRewardsPopup");
				return;
			}
			OnFacebookCharacterUnlocked();
			UIScreenController instance2 = UIScreenController.Instance;
			UIScreenController.SlideIn slideIn = default;
			slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectSucceeded);
			instance2.QueueSlideIn(slideIn);
		}
	}

	public void OnFacebookCharacterUnlocked()
	{
		OnCharacterUnlocked(Characters.CharacterType.facebookRewardCharacter01, 0);
	}

	public bool isFacebookLoginRunning()
	{
		return _facebookLoginRunning;
	}

	public void OnFacebookLogout()
	{
		Action onFacebookStatusChanged = OnFacebookStatusChanged;
		if (OnFacebookStatusChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void OnCharacterScreenHide()
	{
		if (~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			HouseKeeper.SetFacebookPayoutActionToDefault();
		}
	}

	public Characters.CharacterType GetCurrentlySelectedCharacter()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return (Characters.CharacterType)instance._currentCharacter;
	}

	public Characters.CharacterType? GetCharacterTypeActiveInEvent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_0111: Expected VT, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = default;
			if ((nint)obj4 != 7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj5 = default;
				if ((nint)obj5 != 3)
				{
					goto IL_0101;
				}
			}
			_ = 0;
			object obj6 = obj + 7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
			_ = 1;
		}
		goto IL_0101;
		IL_0101:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		return (Characters.CharacterType?)(object)0;
	}

	public int GetLastSelectedThemeForCharacterType(Characters.CharacterType charType)
	{
		int indexForLastSelectedTheme = _playerInfoInstance.GetIndexForLastSelectedTheme(charType);
		CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(charType, indexForLastSelectedTheme);
		if (themeForCharacter != null)
		{
			return _playerInfoInstance.GetIndexForLastSelectedTheme(charType);
		}
		return 0;
	}

	public void InitCharacters()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		List<KeyValuePair<Characters.CharacterType, Characters.Model>> list = default;
		list._002Ector();
		_characterList = list;
		object obj3 = obj + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		object obj4 = obj - -64;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		object obj6 = default;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		object obj18 = default;
		object obj19 = default;
		object obj20 = default;
		object obj22 = default;
		object obj23 = default;
		object obj26 = default;
		object obj27 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj16;
			object obj17;
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				object obj7 = obj - -64;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							object obj8 = obj + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
								_ = 0;
								object obj9 = obj + 48;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
								_ = 0;
								object obj11;
								while (true)
								{
									_ = 0;
									object obj10 = obj + 48;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag = (nint)0 == 1;
									obj11 = obj12;
									if (flag)
									{
										break;
									}
									if (obj13 != null)
									{
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag2 = (nint)0 == 1;
										obj11 = obj12;
										if (flag2)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v82+C]");
										nint num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
										if (num == 0)
										{
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v82+C]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag3 = (nint)0 == 1;
											obj11 = obj12;
											if (flag3)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
											obj = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag4 = (nint)0 != 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
											obj11 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
											obj12 = 0;
											if (!flag4)
											{
												break;
											}
										}
										continue;
									}
									goto IL_03ca;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								bool flag5 = obj14 != obj15;
								obj16 = obj14;
								obj17 = obj18;
								if (!flag5)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag6 = (nint)0 == 1;
									obj12 = obj11;
									if (!flag6)
									{
										goto IL_03ca;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									obj16 = obj19;
									obj17 = obj20;
								}
								_ = 0;
								object obj21 = obj + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_0540;
								}
								goto IL_06a1;
							}
						}
					}
				}
			}
			goto IL_0453;
			IL_06a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj22 == obj16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj17 = obj23;
			}
			_ = 0;
			object obj24 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0540;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_03ca:
			_ = 0;
			object obj25 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				continue;
			}
			goto IL_0453;
			IL_0540:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
			IL_0453:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj16 = obj26;
			obj17 = obj27;
			goto IL_06a1;
		}
		object obj28 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BA");
	}

	public List<KeyValuePair<Characters.CharacterType, Characters.Model>> GetCharacterList()
	{
		List<KeyValuePair<Characters.CharacterType, Characters.Model>> characterList = _characterList;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+C]");
		if ((nint)0 == 0)
		{
			InitCharacters();
		}
		return _characterList;
	}
}
