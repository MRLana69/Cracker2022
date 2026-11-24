using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Plugins.Facebook;
using SYBO.Subway.Info;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;

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

	private bool _purchaseInProgress;

	private bool _facebookLoginRunning;

	private CharacterPurchaseInitiator _characterPurchaseInitiator;

	private static Action<Characters.CharacterId, int> m_characterUnlocked;

	private static Action m_characterUnlockedFailure;

	private static Action m_onCharacterSelected;

	private static Action m_onFacebookStatusChanged;

	private Characters.CharacterId currentlyShownCharacter__BackingField;

	public Characters.CharacterId currentlyShownCharacter
	{
		get
		{
			return _facebookLoginRunning ? Characters.CharacterId.tricky : Characters.CharacterId.slick;
		}
		set
		{
			//IL_01e0: Expected I, but got Obj
			//IL_01f6: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006b: Expected I, but got Obj
			//IL_0081: Expected Obj, but got I
			//IL_022b: Expected I, but got Obj
			//IL_0241: Expected Obj, but got I
			//IL_00ac: Expected I, but got Obj
			//IL_02b9: Expected Obj, but got I4
			//IL_0193: Expected I, but got Obj
			//IL_029d: Expected Obj, but got I4
			//IL_011d: Expected I, but got Obj
			nint num = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v43 (Il2CppClass<HouseKeeper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HouseKeeper.DeleteSoundOptionBeforeVideoAds();
			if (value == Characters.CharacterId.slick)
			{
				return;
			}
			_facebookLoginRunning = false;
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v39 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool allAssetBundlesDownloaded = UserSave.allAssetBundlesDownloaded;
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v7 (Il2CppClass<UIScreenController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			if (allAssetBundlesDownloaded)
			{
				if (!flag)
				{
					nint num6 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v35 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text = default;
				text.m_stringLength = 13;
				_ = 1;
				((UIScreenController)flag2)._QueueMessage(text);
				return;
			}
			if (!flag)
			{
				nint num7 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v26 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag3).QueuePopup("FBPromotionPopup");
		}
	}

	public int currentlyShownThemeIndex
	{
		get
		{
			return (int)currentlyShownCharacter__BackingField;
		}
		set
		{
			currentlyShownCharacter__BackingField = (Characters.CharacterId)value;
		}
	}

	public static CharacterScreenManager Instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ChallengesScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (CharacterScreenManager)ChallengesScreen._currentlySelectedPageIndex;
		}
	}

	public static event Action<Characters.CharacterId, int> characterUnlocked
	{
		add
		{
			//IL_0152: Expected I, but got Obj
			//IL_0168: Expected Obj, but got I
			//IL_0024: Expected I, but got Obj
			//IL_0071: Expected I, but got Obj
			//IL_0087: Expected Obj, but got I
			//IL_00b2: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Action`2<SYBO.Subway.Info.Characters+CharacterId, System.Int32>)+8]");
			if ((nint)0 != 0)
			{
				_ = 0;
				_ = 0;
			}
			nint num = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v31 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (CharacterScreenManager.m_characterUnlockedFailure == null)
			{
				return;
			}
			nint num3 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterScreenManager.m_characterUnlocked;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterScreenManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterScreenManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterScreenManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CharacterScreenManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action characterUnlockedFailure
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterScreenManager.m_characterUnlocked;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterScreenManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterScreenManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterScreenManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CharacterScreenManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterScreenManager.m_characterUnlockedFailure;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterScreenManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterScreenManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterScreenManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CharacterScreenManager>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action onCharacterSelected
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterScreenManager.m_characterUnlockedFailure;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterScreenManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterScreenManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterScreenManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CharacterScreenManager>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterScreenManager.m_onCharacterSelected;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterScreenManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterScreenManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterScreenManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CharacterScreenManager>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action onFacebookStatusChanged
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterScreenManager.m_onCharacterSelected;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterScreenManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterScreenManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterScreenManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CharacterScreenManager>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterScreenManager.m_onFacebookStatusChanged;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterScreenManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterScreenManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterScreenManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CharacterScreenManager>)+5C]");
				object obj5 = (nint)0 + (nint)16;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public void PurchaseCharacter(CharacterPurchaseInitiator initiator, Characters.CharacterId characterId, int themeIndex, int priceOverride = -1)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0018: Expected Obj, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_002c: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		object obj = this + 12;
		obj = initiator;
		object obj2 = this + 8;
		int layer = ((GameObject)initiator).layer;
		obj2 = layer;
		object obj3 = this + 20;
		obj3 = characterId;
		object obj4 = this + 16;
		CharacterModel component = ((Component)_purchaseInProgress).GetComponent<CharacterModel>();
		obj4 = component;
	}

	public void PurchaseCharacterWithInapp(CharacterPurchaseInitiator initiator, Characters.CharacterId characterId)
	{
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_038b: Expected Obj, but got I
		//IL_039c: Expected VT, but got Obj
		//IL_03aa: Expected I, but got Obj
		//IL_03c0: Expected Obj, but got I
		//IL_0428: Expected I, but got Obj
		//IL_043e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0657: Expected F4, but got Obj
		//IL_046b: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected Obj, but got Unknown
		//IL_06cd: Expected Obj, but got I4
		//IL_00b9: Expected I, but got Obj
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0111: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_0152: Expected I, but got Obj
		//IL_0587: Expected I, but got Obj
		//IL_01e0: Expected I, but got Obj
		//IL_022d: Expected I, but got Obj
		//IL_0243: Expected Obj, but got I
		//IL_05c7: Expected I, but got Obj
		//IL_026e: Expected I, but got Obj
		//IL_02c2: Expected Obj, but got I
		//IL_02eb: Expected I, but got Obj
		//IL_0301: Expected Obj, but got I
		//IL_060a: Expected VT, but got Obj
		//IL_0638: Expected Obj, but got I4
		//IL_0647: Expected I, but got Obj
		//IL_032c: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenManager)+2C]");
		GameObject gameObject = ((Component)0).gameObject;
		transform.localPosition = (Vector3)gameObject;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v74 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int characterVisibilityCount = ((CharacterScreen)this).GetCharacterVisibilityCount();
		bool flag = characterVisibilityCount <= -1;
		bool flag2 = !flag;
		int num3 = characterVisibilityCount;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenManager)+BC]");
			num3 = 0;
		}
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v68 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num6 = Math.Abs((float)transform);
		nint num7 = num3 - 4;
		bool flag3 = 0 > num7;
		bool flag4 = !flag3;
		nint num8 = num7;
		if (!flag4)
		{
			num8 = unchecked((nint)null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenManager)+84]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v17+8]");
		object obj5 = 0;
		CharacterScrollListSlot characterScrollListSlot = (CharacterScrollListSlot)(num3 + 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v18+C]");
		bool flag5 = 0 >= (nint)characterScrollListSlot;
		bool flag6 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v18+C]");
		CharacterScrollListSlot characterScrollListSlot2 = (CharacterScrollListSlot)0;
		if (!flag6)
		{
			characterScrollListSlot2 = characterScrollListSlot;
		}
		object obj6 = obj + 12;
		float num9 = 1.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenManager)+90]");
		float num10 = num9 * 0f;
		object obj7 = initiator ^ CharacterPurchaseInitiator.characterScreen;
		Characters.CharacterId characterId2 = (Characters.CharacterId)num8;
		while ((nint)characterId2 < (nint)characterScrollListSlot2)
		{
			bool flag7 = characterId2 == characterId;
			object obj8 = flag7 | obj7;
			if (obj8 != null)
			{
				nint num11 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v42 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num12 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v70 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Characters.CharacterId characterId3 = characterId2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenManager)+90]");
				object obj10 = (nint)characterId3 * (nint)0;
				float value = num6 - (float)obj10;
				float num13 = Math.Abs(value);
				float value2 = num13 / num10;
				float num14 = Mathf.InverseLerp(10f, 7f, value2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenManager)+84]");
				CharacterScrollListSlot characterScrollListSlot3 = ((CharacterListManager)0).get_Item(characterId2);
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num16 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num17 = ((ComputeShader)(object)characterScrollListSlot3).FindKernel((string)null);
				bool flag8 = num17 == 0;
				num8 = (nint)typeof(UnityEngine.Object);
				if (!flag8)
				{
					nint num18 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num19 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num20 = ((ComputeShader)(object)characterScrollListSlot3.model).FindKernel((string)null);
					bool flag9 = num20 == 0;
					num8 = (nint)typeof(UnityEngine.Object);
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenManager)+84]");
						CharacterScrollListSlot characterScrollListSlot4 = ((CharacterListManager)0).get_Item(characterId2);
						int layer = characterScrollListSlot4.model.layer;
						nint num21 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v49 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num22 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 forward = Vector3.forward;
						transform = (Transform)obj6;
						Transform transform2 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v23+8]");
						((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
						Vector3 vector = (Vector3)transform / num14;
						transform = (Transform)obj;
						Transform transform3 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
						((Transform)layer).parent = transform;
						num8 = (nint)typeof(UnityEngine.Object);
					}
				}
			}
			Characters.CharacterId characterId4 = characterId2 + 1;
			characterId2 = characterId4;
		}
	}

	public void CharacterPurchaseSuccessful(Characters.CharacterId purchasedCharacter, int themeIndex)
	{
		//IL_004f: Expected I4, but got Obj
		if (~(_purchaseInProgress ? 1u : 0u) != 0)
		{
			_purchaseInProgress = true;
			_characterPurchaseInitiator = (CharacterPurchaseInitiator)purchasedCharacter;
			SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
			PurchaseHandler.CheckForDebugFreePurchases((PurchaseData.UnlockType)instance, themeIndex);
		}
	}

	public void CharacterPurchaseFailure()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got F4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got F4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = -20f;
		_ = 0f;
		object obj3 = obj2 + 24;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj4 = this + 100;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 53f;
		_ = 183f;
		_ = 360f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 112;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<KeyValuePair<Characters.CharacterId, Characters.Model>> list = default;
		list._002Ector();
		object obj6 = this + 128;
		obj6 = list;
		_ = 1f;
		_ = -1;
		_ = 1;
		_ = -1;
		((UpgradeScreen)this).Start();
	}

	private void OnCharacterUnlocked(Characters.CharacterId character, int outfit)
	{
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		//IL_02b2: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I4
		//IL_005d: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_0219: Expected I, but got Obj
		//IL_009e: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I4
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_018b: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I
		//IL_013e: Expected I, but got Obj
		//IL_01cc: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		if (~(_purchaseInProgress ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag = outfit == 0;
		bool flag2 = _characterPurchaseInitiator == CharacterPurchaseInitiator.characterNameEvent;
		object obj3 = flag & flag2;
		if (obj3 != null)
		{
			nint num = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v33 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v56 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Characters.Model model = Characters.characterData.get_Item(character);
			if (model.unlockType == PurchaseData.UnlockType.Coins)
			{
				obj = character;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				nint num3 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v20 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v31 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Characters.Model model2 = Characters.characterData.get_Item(character);
				obj2 = model2.Price;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text2 = default;
				string text3 = default;
				string text = text2 + ";" + text3;
				nint num5 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v49 (Il2CppClass<Flurry>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v52 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
		}
		_purchaseInProgress = false;
		_characterPurchaseInitiator = CharacterPurchaseInitiator.none;
		SelectCharacter(character, outfit);
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3).ShowUnlockAnimationForHoverboard((Boards.BoardId)character, (Hoverboard.BoardAbility)outfit);
	}

	public unsafe void SelectCharacter(Characters.CharacterId charId, int themeIndex)
	{
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (CharacterScreenManager.m_characterUnlocked == null)
		{
			return;
		}
		((CoinScreen)null).InsertEarner((int)charId, ref *(int*)themeIndex);
		nint num3 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v23 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
	}

	public void StartLoginToFacebook()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = CharacterScreenManager.m_onFacebookStatusChanged;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(CharacterScreenManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(CharacterScreenManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(CharacterScreenManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CharacterScreenManager>)+5C]");
			object obj5 = (nint)0 + (nint)16;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	public void OnFacebookLoginResult(bool loggedIn)
	{
		//IL_0010: Expected I4, but got Obj
		//IL_0021: Expected Obj, but got I4
		string msg = string.ConcatArray((string[])(object)"Character Screen: ", (int)this);
		SDebug.LogFormat(msg, (object[])loggedIn);
	}

	private void OnFacebookLoginStopped()
	{
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_01d6: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_0107: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		nint num2 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v45 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7855");
		_facebookLoginRunning = true;
		nint num4 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<SocialManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v41 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = this;
		if (!SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported, obj6))
		{
			return;
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v31 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v37 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueueMessage((string)1);
	}

	private void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		//IL_003b: Expected Obj, but got I4
		if (onFinishCallback != null)
		{
			_facebookLoginRunning = false;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		((CharacterScreenManager)null).FacebookStatusChanged(flag);
	}

	private void FacebookStatusChanged(bool success)
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 13;
		_ = 0;
		object obj2 = text + 24;
		obj2 = success;
		((UIScreenController)flag)._QueueMessage(text);
	}

	public void OnFacebookCharacterUnlocked()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		_facebookLoginRunning = false;
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v14 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)CharacterScreenManager.m_onFacebookStatusChanged);
	}

	public void OnFirstPurchaseCharacterUnlocked()
	{
	}

	public bool IsFacebookLoginRunning()
	{
		return true;
	}

	public void OnFacebookLogout()
	{
	}

	public void OnCharacterScreenHide()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)CharacterScreenManager.m_onFacebookStatusChanged);
	}

	public Characters.CharacterId? GetCharacterTypeActiveInEvent()
	{
		Characters.CharacterId? result = default;
		return result;
	}

	public int GetLastSelectedThemeForCharacterType(Characters.CharacterId charId)
	{
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		nint num = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CharacterNameEventManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<CharacterNameEventManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = CharacterNameEventManager.FILTERED_CHARACTERS + 12;
		object obj3 = 0;
		int result;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
			result = 0;
			if (flag)
			{
				break;
			}
			object obj4 = CharacterNameEventManager.FILTERED_CHARACTERS + 16;
			object obj5 = obj3 << 1;
			object obj6 = obj4 + obj5;
			object obj7 = charId & (Characters.CharacterId)0xFFFF;
			if (obj6 == obj7)
			{
				result = 1;
				break;
			}
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		return result;
	}

	private CharacterScreenManager()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (~(_facebookLoginRunning ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
	}

	static CharacterScreenManager()
	{
		//IL_002c: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got F4
		//IL_0055: Expected I, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_008e: Expected Obj, but got I
		CharacterScreen.forceRefreshOnCharacterScreen = false;
		CharacterScreen.forceCenterOnEventCharacter = false;
		CharacterScreen.forceCenterOnCurrentlySelectedCharacter = false;
		object obj = 0;
		_ = 0;
		obj = 62f;
		_ = 0f;
		_ = 0f;
		nint num = (nint)typeof(CharacterScreen);
		object obj2 = obj + 12;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v23 (Il2CppClass<UI.Screens.CharacterScreen>)+5C]");
		object obj3 = (nint)0 + (nint)4;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v12+8]");
		_ = 0;
	}
}
