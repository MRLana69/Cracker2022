using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class UICharacterThemeShifter : MonoBehaviour
{
	private const int MAX_NUMBER_OF_CUSTOM_THEMES = 3;

	private CharacterThemeButton defaultCharacterThemeButton;

	private CharacterThemeButton customCharacterThemeButton;

	private List<CharacterThemeButton> customButtons;

	private int _activeTheme;

	private Characters.CharacterType _cachedCharacter;

	private List<CharacterTheme> _currentCharacterThemes;

	private CharacterTheme[] _sortedThemes;

	private Action<int> m_OnThemeButtonPressed;

	public event Action<int> OnThemeButtonPressed
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
			Delegate obj2 = this.m_OnThemeButtonPressed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
			Delegate obj2 = this.m_OnThemeButtonPressed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public void InitValues(Characters.CharacterType charType, int index)
	{
		_activeTheme = index;
		_cachedCharacter = charType;
	}

	private void Awake()
	{
		customButtons.Add(customCharacterThemeButton);
		throw new ArgumentException();
	}

	private void OnDestroy()
	{
		throw new ArgumentException();
	}

	private CharacterTheme[] SortThemes(List<CharacterTheme> themes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		List<CharacterTheme> list = default;
		list._002Ector();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S4_v3 (Il2CppRgctx<System.Collections.Generic.List`1<CharacterTheme>>)+3C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S4_v4+4] (should have been resolved before IL gen)");
		CharacterTheme characterTheme = themes.get_Item(0);
		CharacterTheme characterTheme2 = characterTheme;
		object obj4 = default;
		if ((nint)obj4 < themes._size)
		{
			object obj5 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj6 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			int num3 = int.MaxValue;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			object obj12 = default;
			object obj13 = default;
			while (true)
			{
				_ = 0;
				object obj7 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj8 == null)
					{
						goto IL_01fd;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					CharacterTheme characterTheme3 = (CharacterTheme)0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						bool flag = num3 > characterTheme3.uiPriority;
						int num4 = characterTheme3.uiPriority;
						if (!flag)
						{
							num4 = num3;
						}
						if (!flag)
						{
							characterTheme3 = characterTheme2;
						}
						characterTheme2 = characterTheme3;
						num3 = num4;
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj9 != obj10;
				object obj11 = obj12;
				if (flag2)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01fd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj11 = obj13;
				break;
				IL_01fd:
				object obj14 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @19C9");
				throw new ArrayTypeMismatchException();
			}
			_ = 0;
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				CharacterTheme[] result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		CharacterTheme[] result2 = default;
		return result2;
	}

	public unsafe void MakeCustomThemesAvailable(List<CharacterTheme> themes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_0652: Expected Obj, but got I4
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Expected Obj, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected Obj, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_0297: Expected Obj, but got I
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected VT, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected VT, but got Unknown
		//IL_035f: Expected Obj, but got I
		//IL_03c0: Expected Obj, but got I4
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected I4, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_04ed: Expected Obj, but got I
		//IL_0509: Expected Obj, but got I
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected I4, but got Unknown
		//IL_059c: Expected Obj, but got I
		//IL_059c: Expected Obj, but got I
		//IL_05d1: Expected I4, but got VT
		//IL_05cc: Expected native int or pointer, but got VT
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected VT, but got Unknown
		object obj = default;
		Color32 color = (Color32)(obj - 96);
		UICharacterThemeShifter uICharacterThemeShifter = (UICharacterThemeShifter)(color + 88);
		uICharacterThemeShifter = (UICharacterThemeShifter)0;
		_ = 0;
		_ = 0;
		_currentCharacterThemes = themes;
		if (themes._size >= 1)
		{
			CharacterTheme[] sortedThemes = uICharacterThemeShifter.SortThemes(themes);
			_sortedThemes = sortedThemes;
		}
		object obj2 = color + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		object obj3 = color - -64;
		uICharacterThemeShifter = (UICharacterThemeShifter)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+38]");
		_ = 0;
		object obj4 = color + 80;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+30]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		int num;
		int num2 = default;
		int num3 = default;
		UICharacterThemeShifter uICharacterThemeShifter2 = default;
		int num4 = default;
		while (true)
		{
			_ = 0;
			object obj5 = color + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_01bd;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 != obj8;
			num = num2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01bd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				num = num3;
			}
			_ = 0;
			object obj9 = color + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			uICharacterThemeShifter2 = (UICharacterThemeShifter)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_01bd:
			object obj10 = color + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D0");
			bool flag2 = themes == null;
			num4 = 0;
			if (!flag2)
			{
				bool flag3 = themes._size > 3;
				num4 = 3;
				if (!flag3)
				{
					num4 = themes._size;
				}
			}
			CharacterThemeButton component = defaultCharacterThemeButton.GetComponent<CharacterThemeButton>();
			_ = GlobalColors.CHARACTERS_CUSTOMIZATION_BASE_SKIN_ICON;
			_ = GlobalColors.CHARACTERS_CUSTOMIZATION_BASE_SKIN_FILL;
			_ = GlobalColors.CHARACTERS_CUSTOMIZATION_BASE_SKIN_FILL;
			_ = GlobalColors.CHARACTERS_CUSTOMIZATION_BASE_SKIN_ICON;
			Color32 bgColor = (Color32)(color + 12);
			Color32 iconColor = (Color32)(color + 8);
			component.SetColors(bgColor, iconColor, 0);
			num = 0;
			break;
		}
		object obj14 = default;
		while (num < num4)
		{
			List<CharacterThemeButton> list = uICharacterThemeShifter2.customButtons;
			CharacterThemeButton characterThemeButton2;
			if (num < list._size)
			{
				CharacterThemeButton characterThemeButton = uICharacterThemeShifter2.customButtons.get_Item(num);
				GameObject gameObject = characterThemeButton.gameObject;
				gameObject.SetActive(value: true);
				characterThemeButton2 = characterThemeButton;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				Transform parent = ((Component)0).transform;
				CharacterThemeButton characterThemeButton3 = UnityEngine.Object.Instantiate(uICharacterThemeShifter2.customCharacterThemeButton, parent);
				bool flag4 = characterThemeButton3 != null;
				bool flag5 = !flag4;
				characterThemeButton2 = characterThemeButton3;
				if (!flag5)
				{
					object obj11 = num + 1;
					int num5 = color + 76;
					string text = ((int*)num5)->ToString();
					string text2 = text + "CharThemeBtn";
					characterThemeButton3.name = text2;
					uICharacterThemeShifter2.customButtons.Add(characterThemeButton3);
					throw new ArgumentException();
				}
			}
			if (characterThemeButton2 != null)
			{
				CharacterTheme[] sortedThemes2 = uICharacterThemeShifter2._sortedThemes;
				if (uICharacterThemeShifter2._sortedThemes != null && sortedThemes2.Length > num)
				{
					int num6 = num << 2;
					object obj12 = uICharacterThemeShifter2._sortedThemes + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S1_v41+10]");
					CharacterTheme characterTheme = (CharacterTheme)0;
					nint num7 = 0;
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.List`1<CharacterTheme>>)+8C]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v452 @ S5_v6+4] (should have been resolved before IL gen)");
					int index = obj14 + 1;
					UIModelController instance = UIModelController.Instance;
					PlayerInfo instance2 = PlayerInfo.Instance;
					bool flag6 = instance2.IsCharacterOwned(instance._currentlyShownModel);
					bool lockIconEnabled = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
					characterThemeButton2.SetLockIconEnabled(lockIconEnabled);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					nint num9 = 0;
					CharacterThemeButton btn = characterThemeButton2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S1_v41+10]");
					((UICharacterThemeShifter)num9).SetActiveBubbles(btn, (CharacterTheme)0, instance._currentlyShownModel, index);
					_ = characterTheme.buttonIconColor;
					_ = characterTheme.buttonBgColor;
					_ = characterTheme.buttonBgColor;
					((Color32*)(nint)color)->rgba = (int)characterTheme.buttonIconColor;
					Color32 bgColor2 = (Color32)(color + 4);
					characterThemeButton2.SetColors(bgColor2, color, index);
				}
			}
			int num10 = num + 1;
			num = num10;
		}
	}

	private void OnDisable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0257: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D0");
	}

	private void SetActiveBubbles(CharacterThemeButton btn, CharacterTheme ct, Characters.CharacterType type, int index)
	{
		bool enableNewBuble;
		bool enableGiftBuble;
		if (!CharacterStickerManager.HasThemeBeenSeenForCharacter(type, index))
		{
			PlayerInfo instance = PlayerInfo.Instance;
			if (!instance._isFreshInstall && ~(ct.isNewInThisUpdate ? 1u : 0u) == 0 && ct.price != 0)
			{
				enableNewBuble = true;
				enableGiftBuble = false;
				goto IL_0109;
			}
		}
		if (!CharacterStickerManager.IsThemeUnlockedForCharacter(type, index) && ct.price == 0)
		{
			enableGiftBuble = _activeTheme != btn.themeIndex__BackingField;
			enableNewBuble = false;
		}
		else
		{
			enableNewBuble = false;
			enableGiftBuble = false;
		}
		goto IL_0109;
		IL_0109:
		btn.SetActiveBubbles(enableGiftBuble, enableNewBuble);
	}

	private void SelectButton(int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		CharacterThemeButton characterThemeButton = defaultCharacterThemeButton;
		bool active = index == 0;
		characterThemeButton.selectedSprite.SetActive(active);
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (index == 0)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						object obj8 = index - 1;
						object obj9 = obj8 << 2;
						object obj10 = (object)_sortedThemes + obj9;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_028b;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_028b;
			IL_028b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj11 == obj12;
			bool flag2 = !flag;
			object obj13 = obj14;
			if (!flag2)
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
				obj13 = obj15;
			}
			_ = 0;
			object obj16 = obj + 16;
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
			break;
		}
		object obj17 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D0");
	}

	public void DisableCharacterCustomizator()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	private void ThemeButtonPressed(int index)
	{
		//IL_0021: Expected Obj, but got I
		UIModelController instance = UIModelController.Instance;
		UpdateUIForCharacter(instance._currentlyShownModel, index);
		if (this.m_OnThemeButtonPressed != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v4 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}

	public void UpdateUIForCharacter(Characters.CharacterType charType, int outfitIndex)
	{
		if (outfitIndex != _activeTheme || _cachedCharacter != charType)
		{
			_activeTheme = outfitIndex;
			_cachedCharacter = charType;
			PlayerInfo instance = PlayerInfo.Instance;
			instance.ThemeSeen(_cachedCharacter, outfitIndex);
			SelectButton(outfitIndex);
		}
	}

	public UICharacterThemeShifter()
	{
		List<CharacterThemeButton> list = default;
		list._002Ector();
		customButtons = list;
		List<CharacterTheme> list2 = default;
		list2._002Ector();
		_currentCharacterThemes = list2;
		base._002Ector();
	}
}
