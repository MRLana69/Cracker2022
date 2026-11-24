using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Migration;
using Data.Save;
using Data.Save.Internal;
using InApp;
using Info;
using Kiloo;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using SYBO.Subway.Promotion;
using UI.Popups.ConsumablesPopupInternal;
using UI.Popups.LimitedBoardPopupInternal;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.Rendering;
using WeeklyHunt;

namespace Data.Managers;

public static class BoardManager
{
	public enum ScreenContext
	{
		BoardScreen,
		LimitedBoardPopup,
		BoardPromotionPopup
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<HoverboardThemes.ThemeIdentifier, BoardThemeData>, bool> _003C_003E9__36_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InventorySave._003C_003Ec obj = default;
			InventorySave._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			PlayerInfoMigrator.JsonObjectWrapper.lastLoadedKey__BackingField = (string)(object)this;
		}

		internal bool _003CHasAllThemesBeenSeen_003Eb__36_0(KeyValuePair<HoverboardThemes.ThemeIdentifier, BoardThemeData> t)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ L1 (System.Collections.Generic.KeyValuePair`2<HoverboardThemes+ThemeIdentifier, Info.BoardThemeData>)+8]");
			return (nint)0 == 2;
		}
	}

	private static readonly CultureInfo ONLINESETTINGS_DATETIME_CULTUREINFO;

	private static bool[] _displayCustomSets;

	private static Action m_boardSelected;

	private static Action<Hoverboard.BoardAbility> m_themeActiveStateChanged;

	private static Action<Boards.BoardId> m_boardUnlocked;

	public const int MAX_THEMES_PER_BOARD = 2;

	public static event Action boardSelected
	{
		add
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00a6: Expected I4, but got Obj
			//IL_00b7: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			bool isInstanced = UIScreenController.IsInstanced;
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v10 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int currentlyShownHoverboardTheme = GetCurrentlyShownHoverboardTheme((ScreenContext)value);
			((UIModelController)isInstanced).ActivateModelScreen((UIModelController.ModelScreen)currentlyShownHoverboardTheme);
			TransformExtensions.Reset((Transform)(object)BoardManager.m_boardSelected);
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
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = BoardManager.m_boardSelected;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(BoardManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(BoardManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(BoardManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.BoardManager>)+5C]");
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

	public static event Action<Hoverboard.BoardAbility> themeActiveStateChanged
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
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = BoardManager.m_boardSelected;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(BoardManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(BoardManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(BoardManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.BoardManager>)+5C]");
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
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = BoardManager.m_themeActiveStateChanged;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(BoardManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(BoardManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(BoardManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.BoardManager>)+5C]");
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

	public static event Action<Boards.BoardId> boardUnlocked
	{
		add
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00b2: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I
			//IL_00d2: Expected Obj, but got I
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<EarnCoinsData.Id, string> earnCurrencyData = UserSave.earnCurrencyData;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S4_v2 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S4_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S4_v4+48]");
			object obj4 = 0;
			object obj5 = obj4 & 0x7FF;
			object obj6 = obj5 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42 @ S5_v4 (should have been resolved before IL gen)");
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
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = BoardManager.m_boardUnlocked;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(BoardManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(BoardManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(BoardManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.BoardManager>)+5C]");
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

	public unsafe static Boards.BoardId GetCurrentlyShownBoard(ScreenContext context)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PlayerPrefsMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PlayerPrefsMigrator._lastKeyRead = (string)context;
		return (Boards.BoardId)((LODParameters*)PlayerPrefsMigrator._lastKeyRead)->GetHashCode();
	}

	public static int GetCurrentlyShownHoverboardTheme(ScreenContext context)
	{
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_029c: Expected I4, but got Obj
		//IL_0093: Expected I, but got Obj
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_0121: Expected I, but got Obj
		//IL_016e: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I4
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_01af: Expected I, but got Obj
		//IL_01fc: Expected I, but got Obj
		switch (context)
		{
		case ScreenContext.BoardScreen:
		{
			nint num7 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			return (int)instance.jumperSignature;
		}
		case ScreenContext.LimitedBoardPopup:
		{
			nint num5 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v20 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v27 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
			return ((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts).currentlyShownThemeIndex;
		}
		case ScreenContext.BoardPromotionPopup:
		{
			nint num = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v32 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v54 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreen.IsScreenHeightOutOfProportion();
			BoardPromotion boardPromotion = ((PromotionManager)flag).TryGetCurrentPromotion<BoardPromotion>();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)boardPromotion).FindKernel((string)null) != 0)
			{
				return (int)boardPromotion._boardId;
			}
			return 0;
		}
		default:
			return 0;
		}
	}

	static BoardManager()
	{
		PlayerPrefsMigrator._lastKeyRead = "";
	}

	public static void SelectCurrentlyShownBoard(ScreenContext context)
	{
	}

	public unsafe static void ChangeThemeActiveState(ScreenContext context, Hoverboard.BoardAbility boardAbility = Hoverboard.BoardAbility.None)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_0517: Expected Obj, but got I4
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_053a: Expected Obj, but got I4
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_045b: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I4
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got I4
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03f4: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryWriter binaryWriter = default;
		binaryWriter.Dispose((byte)context != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		if (boardAbility == Hoverboard.BoardAbility.None)
		{
			goto IL_04f0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardAbility @ L1 (Hoverboard+BoardAbility)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardAbility @ L1 (Hoverboard+BoardAbility)+1C]");
		object obj6 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		KeyValuePair<_00210, _00211> current = (KeyValuePair<_00210, _00211>)((Dictionary<TKey, TValue>.Enumerator*)(int)boardAbility)->Current;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj8 = default;
		object obj10 = default;
		object obj12 = default;
		object obj14 = default;
		object obj17 = default;
		object obj20 = default;
		object obj7;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj7 = 28;
			bool flag = obj8 == null;
			obj7 = 29;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj7 = 19;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj7 = 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj7 = 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj7 = 22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj7 = 23;
			object obj9 = obj10 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
			object obj11 = obj12 << 32;
			object obj13 = obj14 | obj11;
			obj7 = 24;
			object obj15 = obj13 >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E8");
			obj7 = 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj7 = 25;
			object obj16 = obj17 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
			object obj18 = obj12 << 32;
			object obj19 = obj20 | obj18;
			obj7 = 26;
			object obj21 = obj19 >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E8");
		}
		object obj22 = obj7 - 19;
		object obj25;
		object obj23;
		if ((nint)obj7 != 19 && (nint)obj22 != 1 && (nint)obj22 != 2 && (nint)obj22 != 3 && (nint)obj22 != 4 && (nint)obj22 != 5 && (nint)obj22 != 6 && (nint)obj22 != 7)
		{
			if ((nint)obj22 != 8)
			{
				if ((nint)obj22 == 9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj24 = default;
					obj23 = obj24;
					obj25 = obj12;
					goto IL_05c4;
				}
				if ((nint)obj22 == 10)
				{
					object obj26 = obj5 + 4;
					object obj27 = obj26 + 1;
					obj26 = obj27;
					object obj28 = obj27 << 2;
					object obj29 = obj5 + obj28;
					obj29 = 158;
				}
			}
			goto IL_0617;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj30 = default;
		obj23 = obj30;
		obj25 = obj12;
		goto IL_05c4;
		IL_05c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj31 = default;
		if (obj25 == obj31)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0617;
		IL_04f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		return;
		IL_0617:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj32 = (nint)0 << 2;
			object obj33 = obj5 + obj32;
			if ((nint)obj33 == 158)
			{
				object obj34 = obj5 + 4;
				if ((nint)obj34 > -1)
				{
					object obj35 = obj34 + -1;
					obj34 = obj35;
				}
				return;
			}
		}
		object obj36 = default;
		if (obj36 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return;
		}
		goto IL_04f0;
	}

	public static void ResetDisplayedCustomSets(Boards.BoardId newBoard)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = BoardManager.m_themeActiveStateChanged;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)newBoard);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(BoardManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(BoardManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(BoardManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.BoardManager>)+5C]");
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

	private static bool IsThemeActiveForUIIndex(Boards.BoardId board, int uiIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_124b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1250: Expected Obj, but got Unknown
		//IL_1259: Unknown result type (might be due to invalid IL or missing references)
		//IL_125e: Expected Obj, but got Unknown
		//IL_1267: Expected Obj, but got I4
		//IL_1270: Unknown result type (might be due to invalid IL or missing references)
		//IL_1275: Expected Obj, but got Unknown
		//IL_127e: Expected Obj, but got I4
		//IL_1287: Unknown result type (might be due to invalid IL or missing references)
		//IL_128c: Expected Obj, but got Unknown
		//IL_1295: Expected Obj, but got I4
		//IL_129e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a3: Expected Obj, but got Unknown
		//IL_12ac: Expected Obj, but got I4
		//IL_12c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c6: Expected Obj, but got Unknown
		//IL_12cf: Expected Obj, but got I4
		//IL_12d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dd: Expected Obj, but got Unknown
		//IL_12e6: Expected Obj, but got I4
		//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Expected Obj, but got Unknown
		//IL_1310: Expected I, but got Obj
		//IL_1326: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_1351: Expected I, but got Obj
		//IL_1367: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_13b1: Expected I, but got Obj
		//IL_13c7: Expected Obj, but got I
		//IL_04ba: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 92;
		obj4 = 0;
		object obj5 = obj2 + 88;
		obj5 = 0;
		object obj6 = obj2 + 16;
		obj6 = 0;
		object obj7 = obj2 - -64;
		obj7 = 0;
		_ = 0;
		_ = 0;
		object obj8 = obj2 + 8;
		obj8 = 0;
		object obj9 = obj2 + 56;
		obj9 = 0;
		object obj10 = obj2 + 48;
		obj10 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v31 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v793 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj12 = default;
		if (obj12 != null)
		{
			bool flag = obj4 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v40 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S0_v687 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj14 = default;
		object obj15;
		object obj16 = default;
		object obj17;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj15 = obj16;
			object obj18 = default;
			obj17 = obj18;
		}
		else
		{
			nint num5 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S0_v52 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num6 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ S0_v534 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj20 = default;
			if (obj20 != null)
			{
				obj2 = obj6;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			if (uiIndex == 0)
			{
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj15 = obj16;
			object obj21 = default;
			obj17 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj22 = default;
		if (obj15 == obj22)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj24 = default;
			object obj23 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj26 = default;
			object obj25 = obj26;
		}
		else
		{
			object obj25 = obj17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		bool result = default;
		return result;
	}

	public static bool IsCustomSetEquippedForBoard(Boards.BoardId boardId, int themeIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0434: Expected Obj, but got I4
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0464: Expected I, but got Obj
		//IL_047a: Expected Obj, but got I
		//IL_055b: Expected Obj, but got I
		//IL_056b: Expected Obj, but got I
		//IL_057b: Expected Obj, but got I
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0264: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_0190: Expected I, but got Obj
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v126 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v3+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S2_v4+44]");
		object obj8 = 0;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S3_v4 (should have been resolved before IL gen)");
		object obj11 = default;
		if ((nint)obj11 > -1)
		{
			nint num4 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v31 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num5 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v120 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj13 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v102+20]");
					if ((nint)0 != themeIndex)
					{
						continue;
					}
					nint num6 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v106 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num7 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v113 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj15 = obj4 + 4;
					object obj16 = obj15 + 1;
					obj15 = obj16;
					object obj17 = obj16 << 2;
					object obj18 = obj4 + obj17;
					obj18 = 84;
					break;
				}
				object obj19 = obj4 + 4;
				object obj20 = obj19 + 1;
				obj19 = obj20;
				object obj21 = obj20 << 2;
				object obj22 = obj4 + obj21;
				obj22 = 82;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj23 = (nint)0 << 2;
				object obj24 = obj4 + obj23;
				if ((nint)obj24 == 84)
				{
					object obj25 = obj4 + 4;
					if ((nint)obj25 > -1)
					{
						object obj26 = obj25 + -1;
						obj25 = obj26;
					}
					goto IL_05fc;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj27 = (nint)0 << 2;
				object obj28 = obj4 + obj27;
				if ((nint)obj28 == 82)
				{
					object obj29 = obj4 + 4;
					if ((nint)obj29 > -1)
					{
						object obj30 = obj29 + -1;
						obj29 = obj30;
					}
					goto IL_05fc;
				}
			}
			object obj31 = default;
			if (obj31 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_05fc;
		IL_05fc:
		bool result = default;
		return result;
	}

	public static bool ShouldCustomSetBeDisplayed(int themeIndex)
	{
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_0184: Expected I4, but got Obj
		//IL_0076: Expected I, but got Obj
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_0104: Expected I, but got Obj
		switch (themeIndex)
		{
		case 0:
		{
			nint num3 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			return (byte)(int)instance.speederSignature != 0;
		}
		case 1:
		{
			nint num = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v20 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v27 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v25 (System.Collections.Generic.Dictionary`2<Info.UpgradeType, System.Int32>)+10]");
			return false;
		}
		default:
			return false;
		}
	}

	public static void DisplayCustomSet(int themeIndex, bool display)
	{
		//IL_00f6: Expected I, but got Obj
		//IL_010c: Expected Obj, but got I
		//IL_0179: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int currentlyShownHoverboardTheme = GetCurrentlyShownHoverboardTheme((ScreenContext)themeIndex);
		nint num3 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v27 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		((HoverboardBundle)(object)instance).Charactermodel = (CharacterModel)currentlyShownHoverboardTheme;
		if (BoardManager.m_themeActiveStateChanged != null)
		{
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v3 (Il2CppMethodInfo)+18]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4 & 0x3FFF;
			object obj6 = obj5 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	public static Boards.BoardId? GetEventBoardType()
	{
		//IL_01c3: Expected I, but got Obj
		//IL_01d9: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_0344: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_013e: Expected VT, but got Obj
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0224: Expected I4, but got VT
		//IL_0230: Expected Obj, but got I4
		//IL_015a: Expected I, but got Obj
		//IL_018a: Expected VT, but got Obj
		//IL_00be: Expected I, but got Obj
		//IL_01b0: Expected VT, but got Obj
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v59 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		Boards.BoardId? boardId = default;
		if ((nint)obj7 > -1)
		{
			int num4 = default;
			int num7 = default;
			while (num4 <= 1)
			{
				nint num5 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v42 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num6 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v53 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj9 = _displayCustomSets + 16;
				object obj10 = obj9 + num7;
				bool flag = IsCustomSetEquippedForBoard((Boards.BoardId)boardId, num7);
				obj10 = flag;
				num4 = num7 + 1;
			}
		}
		else
		{
			object obj11 = 0;
			while ((nint)obj11 <= 1)
			{
				nint num8 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v20 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				bool flag2 = obj12 == null;
				boardId = (Boards.BoardId?)(object)typeof(BoardManager);
				if (!flag2)
				{
					nint num9 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v31 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					bool flag3 = (nint)0 == 0;
					bool flag4 = !flag3;
					boardId = (Boards.BoardId?)(object)typeof(BoardManager);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						boardId = (Boards.BoardId?)(object)typeof(BoardManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+5C]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v25+4]");
				object obj14 = (nint)0 + (nint)16;
				object obj15 = obj14 + obj11;
				obj15 = 0;
				object obj16 = obj11 + 1;
				obj11 = obj16;
			}
		}
		return boardId;
	}

	public static bool IsBoardTrySpecialPowerBoard(Boards.BoardId boardId)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = _displayCustomSets + 16;
		object obj3 = obj2 + boardId;
		return obj3 != null;
	}

	public static bool IsBoardEventLimitedExpiredBoard(Boards.BoardId boardId)
	{
		//IL_00a5: Expected Obj, but got I4
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v24 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.tricky))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
			object obj3 = default;
			bool flag = (nint)obj3 == (nint)boardId;
			bool flag2 = obj != null;
			return flag & flag2;
		}
		return false;
	}

	public static bool IsBoardOwned(Boards.BoardId boardId)
	{
		//IL_00a5: Expected Obj, but got I4
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v24 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.frizzy))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
			object obj3 = default;
			bool flag = (nint)obj3 == (nint)boardId;
			bool flag2 = obj != null;
			return flag & flag2;
		}
		return false;
	}

	public static bool HasBoardBeenSeen(Boards.BoardId boardId)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return HasAllThemesBeenSeen(boardId);
	}

	public unsafe static void MarkHoverboardAsSeen(Boards.BoardId boardId)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01a9: Expected Obj, but got I4
		//IL_01c1: Expected I, but got Obj
		//IL_01d7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_016d: Expected I4, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0151: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		obj2 = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v40 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj6 = default;
			object obj5 = obj6 - 1;
			if ((nint)obj6 == 1 || ((nint)obj5 != 1 && (nint)obj5 != 2 && (nint)obj5 != 3 && (nint)obj5 != 4 && (nint)obj5 == 5))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
				_ = 1;
				object obj7 = default;
				obj = obj7;
			}
		}
		if (obj3 != null)
		{
			((Boards.BoardId*)(int)boardId)->value__ = (int)obj;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		((Boards.BoardId*)(int)boardId)->value__ = (int)obj2;
	}

	public static void UnlockBoard(Boards.BoardId boardId)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = BoardManager.m_boardUnlocked;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)boardId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(BoardManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(BoardManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(BoardManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.BoardManager>)+5C]");
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

	public static void LockBoard(Boards.BoardId boardId)
	{
		//IL_00fd: Expected Obj, but got I4
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		bool isInitialized = AdSystemManager.isInitialized;
		((ScoreCounterSoundPlayer)isInitialized).PlayCoinSound(1f);
		Dictionary<UpgradeType, int> upgrades = InventorySave.upgrades;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @104BC");
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v22 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (BoardManager.m_boardUnlocked != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v5 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	public static int CountBoardThemesUnlocked()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasPurchasedOrRestored = UserSave.hasPurchasedOrRestored;
		return (!hasPurchasedOrRestored) ? 1 : 0;
	}

	public unsafe static bool IsBoardUnlocked(Boards.BoardId boardId)
	{
		//IL_00b6: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_0150: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		ref bool reference = ref *(bool*)null;
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v35 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(boardId);
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v20 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v31 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<EarnCoinsData.Id, string> earnCurrencyData = UserSave.earnCurrencyData;
		bool flag = ((Dictionary<Boards.BoardId, bool>)(object)earnCurrencyData).TryGetValue(boardId, out reference);
		object obj3 = reference & flag;
		return obj3 != null;
	}

	public static bool IsThemeOwned(Boards.BoardId boardId, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0434: Expected Obj, but got I4
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0464: Expected I, but got Obj
		//IL_047a: Expected Obj, but got I
		//IL_055b: Expected Obj, but got I
		//IL_056b: Expected Obj, but got I
		//IL_057b: Expected Obj, but got I
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0264: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_0190: Expected I, but got Obj
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v131 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v3+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S2_v4+44]");
		object obj8 = 0;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S3_v4 (should have been resolved before IL gen)");
		object obj11 = default;
		if ((nint)obj11 > -1)
		{
			nint num4 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v31 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num5 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v125 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj13 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v102+20]");
					if ((nint)0 != (nint)themeId)
					{
						continue;
					}
					nint num6 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v111 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num7 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v118 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj15 = obj4 + 4;
					object obj16 = obj15 + 1;
					obj15 = obj16;
					object obj17 = obj16 << 2;
					object obj18 = obj4 + obj17;
					obj18 = 91;
					break;
				}
				object obj19 = obj4 + 4;
				object obj20 = obj19 + 1;
				obj19 = obj20;
				object obj21 = obj20 << 2;
				object obj22 = obj4 + obj21;
				obj22 = 89;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj23 = (nint)0 << 2;
				object obj24 = obj4 + obj23;
				if ((nint)obj24 == 91)
				{
					object obj25 = obj4 + 4;
					if ((nint)obj25 > -1)
					{
						object obj26 = obj25 + -1;
						obj25 = obj26;
					}
					goto IL_05fc;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj27 = (nint)0 << 2;
				object obj28 = obj4 + obj27;
				if ((nint)obj28 == 89)
				{
					object obj29 = obj4 + 4;
					if ((nint)obj29 > -1)
					{
						object obj30 = obj29 + -1;
						obj29 = obj30;
					}
					goto IL_05fc;
				}
			}
			object obj31 = default;
			if (obj31 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_05fc;
		IL_05fc:
		bool result = default;
		return result;
	}

	public static bool IsThemeActive(Boards.BoardId boardId, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_023d: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ALL_BOARDS ? 1u : 0u) == 0)
		{
			return true;
		}
		if (themeId != HoverboardThemes.ThemeIdentifier.none)
		{
			CelebrationReward lastAddedReward = InventorySave.lastAddedReward;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S2_v3 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v4+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v5+44]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v72 @ S3_v5 (should have been resolved before IL gen)");
			object obj7 = default;
			if ((nint)obj7 > -1)
			{
				CelebrationReward lastAddedReward2 = InventorySave.lastAddedReward;
				Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward2).get_Item(boardId);
				if (dictionary != null)
				{
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v12 (Il2CppMethodInfo)+C]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v13+60]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S2_v14+44]");
					object obj10 = 0;
					object obj11 = obj10 & 0x1FFF;
					object obj12 = obj11 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v106 @ S3_v11 (should have been resolved before IL gen)");
					object obj13 = default;
					if ((nint)obj13 > -1)
					{
						BoardThemeData boardThemeData = dictionary.get_Item(themeId);
						return boardThemeData.isOwned;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static bool HasThemeBeenSeen(Boards.BoardId boardId, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		if (themeId != HoverboardThemes.ThemeIdentifier.none)
		{
			CelebrationReward lastAddedReward = InventorySave.lastAddedReward;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v3 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v5+44]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S3_v5 (should have been resolved before IL gen)");
			object obj6 = default;
			if ((nint)obj6 > -1)
			{
				CelebrationReward lastAddedReward2 = InventorySave.lastAddedReward;
				Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward2).get_Item(boardId);
				if (dictionary != null)
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v12 (Il2CppMethodInfo)+C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S2_v13+60]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v14+44]");
					object obj9 = 0;
					object obj10 = obj9 & 0x1FFF;
					object obj11 = obj10 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S3_v11 (should have been resolved before IL gen)");
					object obj12 = default;
					if ((nint)obj12 > -1)
					{
						BoardThemeData boardThemeData = dictionary.get_Item(themeId);
						return boardThemeData.isActive;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static bool HasAllThemesBeenSeen(Boards.BoardId boardId)
	{
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v35 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ALL_BOARDS ? 1u : 0u) == 0)
		{
			return true;
		}
		nint num3 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<Info.Boards>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v28 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(boardId);
		if (board.unlockType != PurchaseData.UnlockType.AlwaysUnlocked)
		{
			Dictionary<UpgradeType, int> upgrades = InventorySave.upgrades;
			return ((List<Boards.BoardId>)(object)upgrades).Contains(boardId);
		}
		return true;
	}

	public static void SetThemeAcquired(Boards.BoardId boardId, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = _displayCustomSets + 16;
		object obj3 = obj2 + boardId;
		object obj4 = themeId & HoverboardThemes.ThemeIdentifier.heroboardTheme01;
		obj3 = obj4;
	}

	public static void SetThemeActive(Boards.BoardId boardId, HoverboardThemes.ThemeIdentifier themeId, bool active)
	{
		//IL_0089: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		//IL_0012: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0036: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SaveData<> saveData = default;
		saveData.ChangeSavePath((string)themeId);
		object obj = boardId + 8;
		obj = saveData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SaveData<> saveData2 = default;
		saveData2.ChangeSavePath((string)active);
		object obj2 = boardId + 12;
		obj2 = saveData2;
		string newSavePath = string.ConcatArray((string[])themeId, (int)"_debug");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SaveData<> saveData3 = default;
		saveData3.ChangeSavePath(newSavePath);
		object obj3 = boardId + 16;
		obj3 = saveData3;
	}

	public static void SetThemeSeen(Boards.BoardId boardId, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_03ad: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_034c: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		if (themeId != HoverboardThemes.ThemeIdentifier.none)
		{
			CelebrationReward lastAddedReward = InventorySave.lastAddedReward;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v4 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v5+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v6+44]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v5 (should have been resolved before IL gen)");
			object obj6 = default;
			if ((nint)obj6 <= -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S3_v14 (Il2CppMethodInfo)+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S3_v15+60]");
				object obj8 = 0;
				object obj9 = obj8;
				object obj10 = obj9 & 0x1FFF;
				object obj11 = obj10 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S4_v20 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 1;
				_ = 1;
				_ = 0;
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v22 (Il2CppMethodInfo)+C]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v23+60]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v24+48]");
				object obj14 = 0;
				object obj15 = obj14 & 0x7FF;
				object obj16 = obj15 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v136 @ S5_v15 (should have been resolved before IL gen)");
				CelebrationReward lastAddedReward2 = InventorySave.lastAddedReward;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v27 (Il2CppMethodInfo)+C]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S4_v28+60]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S4_v29+48]");
				object obj19 = 0;
				object obj20 = obj19 & 0x7FF;
				object obj21 = obj20 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S5_v19 (should have been resolved before IL gen)");
				return;
			}
			CelebrationReward lastAddedReward3 = InventorySave.lastAddedReward;
			Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward3).get_Item(boardId);
			if (dictionary != null)
			{
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S2_v15 (Il2CppMethodInfo)+C]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S2_v16+60]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v17+44]");
				object obj24 = 0;
				object obj25 = obj24 & 0x1FFF;
				object obj26 = obj25 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v163 @ S3_v11 (should have been resolved before IL gen)");
				object obj27 = default;
				if ((nint)obj27 > -1)
				{
					CelebrationReward lastAddedReward4 = InventorySave.lastAddedReward;
					Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary2 = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward4).get_Item(boardId);
					BoardThemeData boardThemeData = dictionary2.get_Item(themeId);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 1;
					bool isActive = boardThemeData.isActive;
					bool hasBeenSeen = boardThemeData.hasBeenSeen;
					CelebrationReward lastAddedReward5 = InventorySave.lastAddedReward;
					Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary3 = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward5).get_Item(boardId);
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S4_v13 (Il2CppMethodInfo)+C]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S4_v14+60]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S4_v15+48]");
					object obj30 = 0;
					object obj31 = obj30 & 0x7FF;
					object obj32 = obj31 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S5_v9 (should have been resolved before IL gen)");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 1;
			_ = 1;
			_ = 0;
			CelebrationReward lastAddedReward6 = InventorySave.lastAddedReward;
			Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary4 = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward6).get_Item(boardId);
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S4_v6 (Il2CppMethodInfo)+C]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S4_v7+60]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S4_v8+48]");
			object obj35 = 0;
			object obj36 = obj35 & 0x7FF;
			object obj37 = obj36 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v56 @ S5_v5 (should have been resolved before IL gen)");
		}
		else
		{
			SDebug.LogFormat("Trying to acquire an invalid theme.", null);
		}
	}

	public static bool DoesBoardHaveThemes(Boards.BoardId boardId)
	{
		//IL_01ff: Expected Obj, but got I4
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_0253: Expected VT, but got Obj
		//IL_0071: Expected I, but got Obj
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_029e: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got VT
		//IL_0300: Expected Obj, but got I
		//IL_00ff: Expected I, but got Obj
		//IL_018d: Expected I, but got Obj
		object obj = 0;
		CelebrationReward lastAddedReward = InventorySave.lastAddedReward;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		object obj2 = default;
		if (obj2 != null)
		{
			if (obj != null)
			{
				nint num = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v19 (Il2CppClass<Data.Managers.BoardManager+<>c>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v76 (Il2CppClass<Data.Managers.BoardManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = _003C_003Ec._003C_003E9__36_0 == null;
				bool flag2 = !flag;
				_00210 key = (_00210)_003C_003Ec._003C_003E9__36_0;
				if (!flag2)
				{
					nint num3 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v50 (Il2CppClass<Data.Managers.BoardManager+<>c>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v70 (Il2CppClass<Data.Managers.BoardManager+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					_ = 0;
					_00210 val = default;
					object obj5 = val + 16;
					obj5 = _003C_003Ec._003C_003E9;
					nint num6 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v67 (Il2CppClass<Data.Managers.BoardManager+<>c>)+5C]");
					object obj6 = (nint)0 + (nint)4;
					obj6 = val;
					key = val;
				}
				if (((Dictionary<TKey, TValue>)obj).ContainsKey((TKey)key))
				{
					nint num7 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v33 (Il2CppClass<HoverboardThemes>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num8 = (nint)typeof(HoverboardThemes);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v43 (Il2CppClass<HoverboardThemes>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardId);
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v19+10]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v19+1C]");
					object obj9 = num9 - 0;
					return list._size == (nint)obj9;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static bool AreAllNewThemesSeenForBoard(Boards.BoardId boardId)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		return (nint)obj7 > -1;
	}

	private static DateTime DefaultExpirationDateForHoverboard(Boards.BoardId bId)
	{
		//IL_000d: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bId @ L0 (Info.Boards+BoardId)+18]");
		return (DateTime)0;
	}

	public static DateTime BoardExpirationDate(Boards.BoardId boardId)
	{
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_02f1: Expected I, but got Obj
		//IL_0307: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got VT
		//IL_0220: Expected Obj, but got VT
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v74 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(boardId);
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v68 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 8;
		obj3 = board.defaultExpirationTime;
		obj4 = DateTime.MinValue;
		object obj5 = obj4 + 16;
		obj5 = obj3;
		object obj6 = obj4 + 24;
		obj6 = obj4;
		object obj7 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		object obj8 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		if (obj7 != obj8)
		{
			nint num5 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v53 (Il2CppClass<Info.Boards>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v62 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board2 = Boards.boardData.get_Item(boardId);
			return board2.defaultExpirationTime;
		}
		nint num7 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v39 (Il2CppClass<System.DateTime>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num8 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v46 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return DateTime.MaxValue;
	}

	public unsafe static DateTime BoardStartAvailabilityDate(Boards.BoardId boardId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected I4, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_0531: Expected Obj, but got I4
		//IL_055b: Expected I, but got Obj
		//IL_0571: Expected Obj, but got I
		//IL_059c: Expected I, but got Obj
		//IL_05b2: Expected Obj, but got I
		//IL_06d3: Expected I4, but got Obj
		//IL_06d3: Expected I4, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_0471: Expected I, but got Obj
		//IL_0487: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_04b2: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_014e: Expected I4, but got Obj
		//IL_014e: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_0238: Expected I, but got Obj
		//IL_024e: Expected Obj, but got I
		//IL_01be: Expected I, but got Obj
		//IL_065c: Expected VT, but got Obj
		//IL_0279: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		bool flag = (byte)(obj2 + 16) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		obj2 = boardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "hoverboard_expiretime_" + text2;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v171 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v32 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v167 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)text);
		if (outfitForCharacter != null)
		{
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v54 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v163 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath2).RestoreNonConsumablePurchases((string[])(object)text, flag))
			{
				if (((string)((bool*)(flag ? 1 : 0))->m_value).get_Chars((int)"disabled") != '\0')
				{
					nint num7 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v71 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num8 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v152 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					nint num9 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v127 (Il2CppClass<System.DateTime>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num10 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v142 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
					object obj10 = default;
					object obj9 = obj10 << 32;
					object obj11 = default;
					DateTime dateTime = (DateTime)(obj11 | obj9);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj13 = default;
					object obj12 = obj13;
					object obj14 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj15 = default;
					if (obj14 == obj15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj17 = default;
						object obj16 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj19 = default;
						object obj18 = obj19;
					}
					else
					{
						object obj18 = obj12;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					DateTime result = default;
					return result;
				}
				return DateTime.MinValue;
			}
			return DateTime.MinValue;
		}
		nint num11 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v43 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num12 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v49 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return BoardExpirationDate(boardId);
	}

	public static bool IsBoardActive(Boards.BoardId boardId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0329: Expected Obj, but got I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0359: Expected I, but got Obj
		//IL_036f: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I4
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0119: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v109 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		bool flag = true;
		object obj6 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v79+18]");
			if ((nint)0 == 0)
			{
				continue;
			}
			object obj8;
			if (flag)
			{
				nint num3 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v92 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v101 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj8 = obj9 & 1;
			}
			else
			{
				obj8 = 0;
			}
			bool flag2 = obj8 != null;
			flag = flag2;
		}
		object obj10 = obj4 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj4 + obj12;
		obj13 = 81;
		bool result = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj4 + obj14;
			if ((nint)obj15 == 81)
			{
				object obj16 = obj4 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_0441;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0441;
		IL_0441:
		return result;
	}

	public static bool IsBoardDisabled(Boards.BoardId boardId)
	{
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_0617: Expected Obj, but got I4
		//IL_0625: Expected I, but got Obj
		//IL_063b: Expected Obj, but got I
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected Obj, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected Obj, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected Obj, but got Unknown
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected Obj, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0690: Expected I, but got Obj
		//IL_06a6: Expected Obj, but got I
		//IL_014b: Expected I, but got Obj
		//IL_0198: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I4
		//IL_02b5: Expected I, but got Obj
		//IL_02cb: Expected Obj, but got I
		//IL_035f: Expected I, but got Obj
		//IL_0375: Expected Obj, but got I
		//IL_02f6: Expected I, but got Obj
		//IL_03a0: Expected I, but got Obj
		//IL_03ed: Expected I, but got Obj
		//IL_0403: Expected Obj, but got I
		//IL_047b: Expected I, but got Obj
		//IL_0491: Expected Obj, but got I
		//IL_042e: Expected I, but got Obj
		//IL_079e: Expected Obj, but got VT
		//IL_07a6: Expected Obj, but got VT
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected Obj, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_0525: Expected Obj, but got I4
		//IL_04bc: Expected I, but got Obj
		//IL_0504: Expected Obj, but got I4
		//IL_054f: Expected I, but got Obj
		//IL_0565: Expected Obj, but got I
		//IL_0834: Expected Obj, but got VT
		//IL_083c: Expected Obj, but got VT
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected Obj, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_05df: Expected Obj, but got I4
		//IL_0590: Expected I, but got Obj
		//IL_05be: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v164 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 40;
		object obj5 = obj2 + 32;
		object obj6 = obj2 + 24;
		object obj7 = obj2 + 16;
		object obj8 = obj2 + 8;
		bool result;
		if (~(Globals.DEBUG_ALL_BOARDS ? 1u : 0u) == 0)
		{
			result = true;
		}
		else
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v30 (Il2CppClass<Globals>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v157 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_DISPLAY_ALL_BOARDS ? 1u : 0u) == 0)
			{
				result = true;
			}
			else
			{
				nint num5 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v38 (Il2CppClass<Info.Boards>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(Boards);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v150 (Il2CppClass<Info.Boards>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Boards.Board board = Boards.boardData.get_Item(boardId);
				nint num7 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v47 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num8 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v146 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string flurryUserId = Flurry.flurryUserId;
				if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.frizzy))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
					object obj12 = default;
					bool flag = (nint)obj12 == (nint)boardId;
					bool flag2 = obj != null;
					object obj13 = flag & flag2;
					result = true;
					if (obj13 != null)
					{
						goto IL_06f7;
					}
				}
				if (board.unlockType == PurchaseData.UnlockType.HiddenUntilUnlocked)
				{
					bool isInitialized = AdSystemManager.isInitialized;
					result = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v68 (System.Boolean)+D]");
					if ((nint)0 != 0)
					{
						goto IL_06f7;
					}
				}
				if (board.unlockType == PurchaseData.UnlockType.WeeklyHunt)
				{
					nint num9 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v135 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num10 = (nint)typeof(WeeklyHuntManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v140 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num11 = WeeklyHuntManager.ItemsCollectedForBoardType(boardId);
					bool flag3 = num11 == 0;
					result = false;
					if (flag3)
					{
						goto IL_06f7;
					}
				}
				if (~(board.hasOnlineTimeLimit ? 1u : 0u) == 0)
				{
					nint num12 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v67 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num13 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v130 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!CharacterManager.IsCharacterOwned((Characters.CharacterId)boardId))
					{
						nint num14 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v77 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num15 = (nint)typeof(BoardManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v126 (Il2CppClass<Data.Managers.BoardManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						DateTime dateTime = BoardStartAvailabilityDate(boardId);
						TimeSpan timeSpan = BoardExpirationTimespan(boardId);
						DateTime utcNow = CDateTime.UtcNow;
						nint num16 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v88 (Il2CppClass<System.DateTime>)+BA]");
						object obj17 = (nint)0 & (nint)0x200;
						if (obj17 != null)
						{
							nint num17 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v122 (Il2CppClass<System.DateTime>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj6 = dateTime;
						obj7 = utcNow;
						obj5 = obj6;
						obj4 = obj7;
						object obj18 = obj5 & 0x3FFFFFFFFFFFFFFFL;
						object obj19 = obj4 & 0x3FFFFFFFFFFFFFFFL;
						object obj20;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
						{
							obj20 = 1;
						}
						else
						{
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
							object obj21 = (flag4 ? 1u : 0u) << 31;
							obj20 = obj21 >> 31;
						}
						if ((nint)obj20 >= 1)
						{
							DateTime utcNow2 = CDateTime.UtcNow;
							nint num18 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v105 (Il2CppClass<System.DateTime>)+BA]");
							object obj22 = (nint)0 & (nint)0x200;
							if (obj22 != null)
							{
								nint num19 = (nint)typeof(DateTime);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v114 (Il2CppClass<System.DateTime>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj8 = timeSpan;
							obj2 = utcNow2;
							obj5 = obj8;
							obj4 = obj2;
							object obj23 = obj5 & 0x3FFFFFFFFFFFFFFFL;
							object obj24 = obj4 & 0x3FFFFFFFFFFFFFFFL;
							object obj25;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
							{
								obj25 = 1;
							}
							else
							{
								bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
								object obj26 = (flag5 ? 1u : 0u) << 31;
								obj25 = obj26 >> 31;
							}
							bool flag6 = (nint)obj25 <= -1;
							result = true;
							if (flag6)
							{
								goto IL_06f7;
							}
						}
					}
					result = false;
				}
				else
				{
					result = true;
				}
			}
		}
		goto IL_06f7;
		IL_06f7:
		return result;
	}

	public unsafe static TimeSpan BoardExpirationTimespan(Boards.BoardId boardId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected I4, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Obj, but got Unknown
		//IL_0618: Expected Obj, but got I4
		//IL_0642: Expected I, but got Obj
		//IL_0658: Expected Obj, but got I
		//IL_0683: Expected I, but got Obj
		//IL_0699: Expected Obj, but got I
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected Obj, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected Obj, but got Unknown
		//IL_08a8: Expected I4, but got Obj
		//IL_08a8: Expected I4, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_03e1: Expected I, but got Obj
		//IL_03f7: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0790: Expected I, but got Obj
		//IL_07a6: Expected Obj, but got I
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got VT
		//IL_07d9: Expected Obj, but got VT
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got Unknown
		//IL_0422: Expected I, but got Obj
		//IL_054a: Expected I, but got Obj
		//IL_0560: Expected Obj, but got I
		//IL_046f: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_04bc: Expected I, but got Obj
		//IL_04d2: Expected Obj, but got I
		//IL_014e: Expected I4, but got Obj
		//IL_014e: Expected Obj, but got I4
		//IL_058b: Expected I, but got Obj
		//IL_04fd: Expected I, but got Obj
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_0238: Expected I, but got Obj
		//IL_024e: Expected Obj, but got I
		//IL_01be: Expected I, but got Obj
		//IL_0743: Expected VT, but got Obj
		//IL_0279: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		bool flag = (byte)(obj2 + 40) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		object obj3 = obj2 + 32;
		obj3 = obj;
		_ = -1;
		object obj4 = obj2 + 24;
		obj4 = boardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "hoverboard_starttime_" + text2;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v221 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v33 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v217 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 16;
		object obj8 = obj2 + 8;
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)text);
		if (outfitForCharacter != null)
		{
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v117 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v213 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath2).RestoreNonConsumablePurchases((string[])(object)text, flag))
			{
				if (((string)((bool*)(flag ? 1 : 0))->m_value).get_Chars((int)"disabled") != '\0')
				{
					nint num7 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v134 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num8 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v202 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					nint num9 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v177 (Il2CppClass<System.DateTime>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num10 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S0_v192 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
					object obj13 = default;
					object obj12 = obj13 << 32;
					object obj14 = default;
					TimeSpan timeSpan = (TimeSpan)(obj14 | obj12);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj16 = default;
					object obj15 = obj16;
					object obj17 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj18 = default;
					if (obj17 == obj18)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj20 = default;
						object obj19 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj22 = default;
						object obj21 = obj22;
					}
					else
					{
						object obj21 = obj15;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					TimeSpan result = default;
					return result;
				}
				return (TimeSpan)DateTime.MinValue;
			}
			return (TimeSpan)DateTime.MinValue;
		}
		nint num11 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48 (Il2CppClass<Info.Boards>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num12 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v110 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(boardId);
		nint num13 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v58 (Il2CppClass<System.DateTime>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num14 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v104 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj8 = board.defaultStartDate;
		obj2 = DateTime.MinValue;
		obj7 = obj8;
		obj4 = obj2;
		object obj25 = obj7 & 0x3FFFFFFFFFFFFFFFL;
		object obj26 = obj4 & 0x3FFFFFFFFFFFFFFFL;
		DateTime result2;
		if (obj25 != obj26)
		{
			nint num15 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v89 (Il2CppClass<Info.Boards>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num16 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v98 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board2 = Boards.boardData.get_Item(boardId);
			result2 = board2.defaultStartDate;
		}
		else
		{
			nint num17 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v75 (Il2CppClass<System.DateTime>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num18 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v82 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			result2 = DateTime.MinValue;
		}
		return (TimeSpan)result2;
	}
}
