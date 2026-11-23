using System;
using System.Collections.Generic;
using Cpp2ILInjected;

public class HoverboardManager
{
	public enum ScreenContext
	{
		BoardScreen,
		LimitedBoardPopup
	}

	private HoverboardCustomizationData _customizationData;

	private bool[] _displayCustomSets;

	private static HoverboardManager instance;

	private static Action m_OnBoardSelected;

	private static Action<Hoverboard.BoardAbility> m_OnThemeActiveStateChanged;

	public static HoverboardManager Instance
	{
		get
		{
			bool flag = instance == null;
			bool flag2 = !flag;
			HoverboardManager result = instance;
			if (!flag2)
			{
				HoverboardManager hoverboardManager = default;
				hoverboardManager._002Ector();
				instance = hoverboardManager;
				result = hoverboardManager;
			}
			return result;
		}
	}

	public static event Action OnBoardSelected
	{
		add
		{
			Delegate obj = HoverboardManager.m_OnBoardSelected;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == HoverboardManager.m_OnBoardSelected;
				Action onBoardSelected = action;
				if (!flag)
				{
					onBoardSelected = HoverboardManager.m_OnBoardSelected;
				}
				HoverboardManager.m_OnBoardSelected = onBoardSelected;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = HoverboardManager.m_OnBoardSelected;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = HoverboardManager.m_OnBoardSelected;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == HoverboardManager.m_OnBoardSelected;
				Action onBoardSelected = action;
				if (!flag)
				{
					onBoardSelected = HoverboardManager.m_OnBoardSelected;
				}
				HoverboardManager.m_OnBoardSelected = onBoardSelected;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = HoverboardManager.m_OnBoardSelected;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<Hoverboard.BoardAbility> OnThemeActiveStateChanged
	{
		add
		{
			Delegate obj = HoverboardManager.m_OnThemeActiveStateChanged;
			Action<Hoverboard.BoardAbility> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == HoverboardManager.m_OnThemeActiveStateChanged;
				Action<Hoverboard.BoardAbility> onThemeActiveStateChanged = action;
				if (!flag)
				{
					onThemeActiveStateChanged = HoverboardManager.m_OnThemeActiveStateChanged;
				}
				HoverboardManager.m_OnThemeActiveStateChanged = onThemeActiveStateChanged;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = HoverboardManager.m_OnThemeActiveStateChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = HoverboardManager.m_OnThemeActiveStateChanged;
			Action<Hoverboard.BoardAbility> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == HoverboardManager.m_OnThemeActiveStateChanged;
				Action<Hoverboard.BoardAbility> onThemeActiveStateChanged = action;
				if (!flag)
				{
					onThemeActiveStateChanged = HoverboardManager.m_OnThemeActiveStateChanged;
				}
				HoverboardManager.m_OnThemeActiveStateChanged = onThemeActiveStateChanged;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = HoverboardManager.m_OnThemeActiveStateChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public HoverboardManager()
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		_customizationData = playerInfo._hoverboardCustomizationData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		bool[] displayCustomSets = default;
		_displayCustomSets = displayCustomSets;
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		ResetDisplayedCustomSets(playerInfo2._currentHoverboard);
	}

	public Hoverboards.BoardType GetCurrentlyShownHoverboard(ScreenContext context)
	{
		switch (context)
		{
		default:
			return Hoverboards.BoardType.normal;
		case ScreenContext.BoardScreen:
		{
			BoardScreenManager boardScreenManager = BoardScreenManager.Instance;
			return boardScreenManager.currentlyShownBoard__BackingField;
		}
		case ScreenContext.LimitedBoardPopup:
		{
			LimitedBoardPopupManager limitedBoardPopupManager = LimitedBoardPopupManager.Instance;
			return limitedBoardPopupManager.currentBoardType;
		}
		}
	}

	public int GetCurrentlyShownHoverboardTheme(ScreenContext context)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_008d: Expected I4, but got Obj
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		object obj;
		switch (context)
		{
		default:
			return 0;
		case ScreenContext.BoardScreen:
		{
			BoardScreenManager boardScreenManager = BoardScreenManager.Instance;
			obj = boardScreenManager + 24;
			break;
		}
		case ScreenContext.LimitedBoardPopup:
		{
			LimitedBoardPopupManager limitedBoardPopupManager = LimitedBoardPopupManager.Instance;
			obj = limitedBoardPopupManager + 20;
			break;
		}
		}
		return (int)obj;
	}

	public void SelectCurrentlyShownBoard(ScreenContext context)
	{
		//IL_0051: Expected Obj, but got I4
		UIModelController uIModelController = UIModelController.Instance;
		Hoverboards.BoardType currentlyShownHoverboard = ((HoverboardManager)context).GetCurrentlyShownHoverboard(context);
		uIModelController.SelectCurrentlyShownBoard(currentlyShownHoverboard);
		Action onBoardSelected = HoverboardManager.m_OnBoardSelected;
		if (HoverboardManager.m_OnBoardSelected != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v21.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ChangeThemeActiveState(ScreenContext context, Hoverboard.BoardAbility boardAbility = Hoverboard.BoardAbility.None)
	{
		//IL_0048: Expected Obj, but got I4
		Hoverboards.BoardType currentlyShownHoverboard = ((HoverboardManager)context).GetCurrentlyShownHoverboard(context);
		BoardScreenManager boardScreenManager = BoardScreenManager.Instance;
		boardScreenManager.ChangedDisplayedHoverboard(currentlyShownHoverboard);
		Action<Hoverboard.BoardAbility> onThemeActiveStateChanged = HoverboardManager.m_OnThemeActiveStateChanged;
		if (HoverboardManager.m_OnThemeActiveStateChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S0_v12 (System.Action`1<Hoverboard+BoardAbility>)+C] (should have been resolved before IL gen)");
		}
	}

	public void ResetDisplayedCustomSets(Hoverboards.BoardType newBoard)
	{
		//IL_00b2: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		bool flag = obj4 == null;
		int num3 = 0;
		int num4 = 0;
		if (!flag)
		{
			while (num3 < 2)
			{
				object obj5 = num3 + _displayCustomSets;
				bool flag2 = IsThemeActiveForUIIndex(newBoard, num3);
				int num5 = num3 + 1;
				num3 = num5;
			}
		}
		else
		{
			while (num4 < 2)
			{
				object obj6 = num4 + _displayCustomSets;
				_ = 0;
				int num6 = num4 + 1;
				num4 = num6;
			}
		}
	}

	private bool IsThemeActiveForUIIndex(Hoverboards.BoardType board, int uiIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_033b: Expected Obj, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0270: Expected I4, but got Obj
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_0176: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 != null)
		{
			object obj7 = obj + 16;
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(board);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj8 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj10 = default;
			object obj14 = default;
			object obj15 = default;
			object obj16 = default;
			bool result;
			bool flag3 = default;
			bool flag5 = default;
			while (true)
			{
				_ = 0;
				object obj9 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj11;
				object obj12;
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj10 == null)
					{
						obj11 = 0;
						obj12 = 0;
						goto IL_024b;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj13 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v81+20]");
						if ((nint)0 != uiIndex)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag = (nint)0 != 1;
						obj11 = 1;
						obj12 = obj14;
						if (flag)
						{
							goto IL_024b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj15 != obj16;
				result = flag3;
				if (flag2)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 == 1;
				obj11 = 0;
				obj12 = 0;
				if (!flag4)
				{
					goto IL_024b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag5;
				break;
				IL_024b:
				object obj17 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
				return (byte)(obj11 & obj12) != 0;
			}
			_ = 0;
			object obj18 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		bool result2 = default;
		return result2;
	}

	public bool IsCustomSetEquippedForBoard(Hoverboards.BoardType boardType, int themeIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_033b: Expected Obj, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0270: Expected I4, but got Obj
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_0176: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 != null)
		{
			object obj7 = obj + 16;
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj8 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj10 = default;
			object obj14 = default;
			object obj15 = default;
			object obj16 = default;
			bool result;
			bool flag3 = default;
			bool flag5 = default;
			while (true)
			{
				_ = 0;
				object obj9 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj11;
				object obj12;
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj10 == null)
					{
						obj11 = 0;
						obj12 = 0;
						goto IL_024b;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj13 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v81+20]");
						if ((nint)0 != themeIndex)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag = (nint)0 != 1;
						obj11 = 1;
						obj12 = obj14;
						if (flag)
						{
							goto IL_024b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj15 != obj16;
				result = flag3;
				if (flag2)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 == 1;
				obj11 = 0;
				obj12 = 0;
				if (!flag4)
				{
					goto IL_024b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag5;
				break;
				IL_024b:
				object obj17 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
				return (byte)(obj11 & obj12) != 0;
			}
			_ = 0;
			object obj18 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		bool result2 = default;
		return result2;
	}

	public bool ShouldCustomSetBeDisplayed(int themeIndex)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = themeIndex + _displayCustomSets;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+10]");
		return false;
	}

	public void DisplayCustomSet(int themeIndex, bool display)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = themeIndex + _displayCustomSets;
	}

	public Hoverboards.BoardType? GetEventBoardType()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00ff: Expected VT, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00d2: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		SSEventsManagerController sSEventsManagerController = SSEventsManagerController.instance;
		IEventManager activeEventManager = sSEventsManagerController.GetActiveEventManager();
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = default;
			bool flag = (nint)obj4 != 6;
			if ((nint)obj4 == 1)
			{
				flag = false;
			}
			if (!flag)
			{
				object obj5 = obj + 31;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					return (Hoverboards.BoardType?)(object)0;
				}
			}
		}
		object obj6 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		return (Hoverboards.BoardType?)(object)0;
	}
}
