using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UnityEngine;

public class UIHoverboardThemeShifter : MonoBehaviour
{
	private const int MAX_NUMBER_OF_CUSTOM_THEMES = 3;

	private GameObject _defaultHoverboardThemeButton;

	private GameObject _customHoverboardThemeButton;

	private Vector3 _distanceBetweenButtons;

	private List<HoverboardThemeButton> _customButtons;

	private Hoverboards.BoardType _cachedBoard;

	private int _cachedThemeIndex;

	private List<HoverboardThemes.HoverboardTheme> _currentBoardThemes;

	private HoverboardThemes.HoverboardTheme[] _sortedThemes;

	private HoverboardManager.ScreenContext _context;

	private Action<int> m_OnClickedTheme;

	public event Action<int> OnClickedTheme
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_OnClickedTheme;
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
			object obj = this + 56;
			Delegate obj2 = this.m_OnClickedTheme;
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

	private unsafe void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002d: Expected VT, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = _defaultHoverboardThemeButton.transform;
		Vector3 localPosition = transform.localPosition;
		Transform transform2 = _customHoverboardThemeButton.transform;
		Vector3 localPosition2 = transform2.localPosition;
		Vector3 distanceBetweenButtons = (Vector3)(obj - obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		object obj3 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj4 = num2 - 0;
		_distanceBetweenButtons = distanceBetweenButtons;
		HoverboardThemeButton component = _customHoverboardThemeButton.GetComponent<HoverboardThemeButton>();
		_customButtons.Add(component);
		HoverboardThemeButton component2 = _defaultHoverboardThemeButton.GetComponent<HoverboardThemeButton>();
		HoverboardThemeButton.OnPressEvent onPressEvent = default;
		onPressEvent._002Ector(this, (nint)__ldftn(UIHoverboardThemeShifter.ClickedTheme));
		component2.OnPress += onPressEvent;
		HoverboardThemeButton hoverboardThemeButton = _customButtons.get_Item(0);
		HoverboardThemeButton.OnPressEvent onPressEvent2 = default;
		onPressEvent2._002Ector(this, (nint)__ldftn(UIHoverboardThemeShifter.ClickedTheme));
		hoverboardThemeButton.OnPress += onPressEvent2;
	}

	public void Init(HoverboardManager.ScreenContext context)
	{
		_context = context;
	}

	private HoverboardThemes.HoverboardTheme[] SortThemes(List<HoverboardThemes.HoverboardTheme> themes)
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
		List<HoverboardThemes.HoverboardTheme> list = default;
		list._002Ector();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S4_v3 (Il2CppRgctx<System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>)+3C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S4_v4+4] (should have been resolved before IL gen)");
		HoverboardThemes.HoverboardTheme hoverboardTheme = themes.get_Item(0);
		HoverboardThemes.HoverboardTheme hoverboardTheme2 = hoverboardTheme;
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
			HoverboardThemes.UIOrder uIOrder = (HoverboardThemes.UIOrder)int.MaxValue;
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
					HoverboardThemes.HoverboardTheme hoverboardTheme3 = (HoverboardThemes.HoverboardTheme)0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						bool flag = uIOrder > hoverboardTheme3.uiOrder;
						HoverboardThemes.UIOrder uIOrder2 = hoverboardTheme3.uiOrder;
						if (!flag)
						{
							uIOrder2 = uIOrder;
						}
						if (!flag)
						{
							hoverboardTheme3 = hoverboardTheme2;
						}
						hoverboardTheme2 = hoverboardTheme3;
						uIOrder = uIOrder2;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
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
				HoverboardThemes.HoverboardTheme[] result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		HoverboardThemes.HoverboardTheme[] result2 = default;
		return result2;
	}

	public unsafe void MakeCustomThemesAvailable(List<HoverboardThemes.HoverboardTheme> themes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected Obj, but got Unknown
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got Unknown
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I
		//IL_0acc: Expected Obj, but got VT
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Expected VT, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected VT, but got Unknown
		//IL_026c: Expected Obj, but got VT
		//IL_096d: Expected Obj, but got I
		//IL_0373: Expected Obj, but got VT
		//IL_037b: Expected VT, but got Obj
		//IL_0556: Expected VT, but got Obj
		//IL_055e: Expected Obj, but got VT
		//IL_03a4: Expected Obj, but got VT
		//IL_03ac: Expected VT, but got Obj
		//IL_05d1: Expected Obj, but got I
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03ea: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected I4, but got Unknown
		//IL_046e: Expected Obj, but got I
		//IL_046e: Expected Obj, but got I
		//IL_048a: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected VT, but got Unknown
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected VT, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected I4, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected Obj, but got Unknown
		//IL_0666: Expected Obj, but got I
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_0690: Expected Obj, but got I
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected Obj, but got Unknown
		//IL_06bf: Expected Obj, but got I
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected VT, but got Unknown
		//IL_0b16: Expected I, but got Obj
		//IL_0b3b: Expected Obj, but got I
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected VT, but got Unknown
		//IL_0b6a: Expected Obj, but got I4
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Expected I4, but got Unknown
		//IL_0922: Expected Obj, but got I
		//IL_0937: Expected VT, but got I
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected Obj, but got Unknown
		//IL_07ad: Expected Obj, but got I
		//IL_07ee: Expected Obj, but got I
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected I4, but got Unknown
		//IL_0830: Expected Obj, but got I
		//IL_0830: Expected Obj, but got I
		//IL_084c: Expected Obj, but got I
		//IL_087f: Expected VT, but got I
		//IL_0894: Expected Obj, but got I
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected VT, but got Unknown
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected VT, but got Unknown
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected I4, but got Unknown
		//IL_08eb: Expected I, but got Obj
		object obj = default;
		UIHoverboardThemeShifter uIHoverboardThemeShifter = (UIHoverboardThemeShifter)(obj - 176);
		_ = 0;
		_ = 0;
		_ = 0;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		_currentBoardThemes = themes;
		UIHoverboardThemeShifter uIHoverboardThemeShifter2 = default;
		if (themes._size >= 1)
		{
			HoverboardThemes.HoverboardTheme[] sortedThemes = uIHoverboardThemeShifter.SortThemes(themes);
			_sortedThemes = sortedThemes;
			uIHoverboardThemeShifter2 = uIHoverboardThemeShifter;
		}
		object obj2 = uIHoverboardThemeShifter + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+88]");
		_ = 0;
		object obj3 = uIHoverboardThemeShifter + 160;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+80]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		int num;
		int num2 = default;
		int num3 = default;
		UIHoverboardThemeShifter uIHoverboardThemeShifter3 = default;
		int num4 = default;
		Color32 color2 = default;
		while (true)
		{
			_ = 0;
			object obj4 = uIHoverboardThemeShifter + 160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_01cd;
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
						bool flag = (nint)0 != 1;
						uIHoverboardThemeShifter2 = null;
						if (flag)
						{
							continue;
						}
						uIHoverboardThemeShifter2 = null;
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
			bool flag2 = obj6 != obj7;
			num = num2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01cd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				num = num3;
			}
			_ = 0;
			object obj8 = uIHoverboardThemeShifter + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			uIHoverboardThemeShifter3 = (UIHoverboardThemeShifter)0;
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
			IL_01cd:
			object obj9 = uIHoverboardThemeShifter + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2369");
			bool flag3 = themes == null;
			num4 = 0;
			if (!flag3)
			{
				bool flag4 = themes._size > 3;
				num4 = 3;
				if (!flag4)
				{
					num4 = themes._size;
				}
			}
			HoverboardThemeButton component = _defaultHoverboardThemeButton.GetComponent<HoverboardThemeButton>();
			_ = GlobalColors.HOVERBOARD_CUSTOMIZATION_BASE_SKIN_ICON;
			_ = GlobalColors.HOVERBOARD_CUSTOMIZATION_BASE_SKIN_FILL;
			_ = GlobalColors.HOVERBOARD_CUSTOMIZATION_BASE_SKIN_FILL;
			uIHoverboardThemeShifter.m_OnClickedTheme = (Action<int>)GlobalColors.HOVERBOARD_CUSTOMIZATION_BASE_SKIN_ICON;
			Color32 bgColor = (Color32)(uIHoverboardThemeShifter + 60);
			Color32 color = (Color32)(uIHoverboardThemeShifter + 56);
			component.InitButton(string.Empty, bgColor, color, 0);
			int num5 = 0;
			color2 = GlobalColors.HOVERBOARD_CUSTOMIZATION_BASE_SKIN_ICON;
			num = 0;
			uIHoverboardThemeShifter2 = (UIHoverboardThemeShifter)color;
			break;
		}
		object obj12 = default;
		object obj14 = default;
		object obj24 = default;
		object obj26 = default;
		HoverboardThemeButton.OnPressEvent onPressEvent = default;
		while (num < num4)
		{
			List<HoverboardThemeButton> customButtons = uIHoverboardThemeShifter3._customButtons;
			if (num < customButtons._size)
			{
				HoverboardThemeButton hoverboardThemeButton = uIHoverboardThemeShifter3._customButtons.get_Item(num);
				HoverboardThemes.HoverboardTheme[] sortedThemes2 = uIHoverboardThemeShifter3._sortedThemes;
				bool flag5 = uIHoverboardThemeShifter3._sortedThemes == null;
				string text = (string)color2;
				Color32 color3 = (Color32)uIHoverboardThemeShifter2;
				if (!flag5)
				{
					bool flag6 = sortedThemes2.Length <= num;
					text = (string)color2;
					color3 = (Color32)uIHoverboardThemeShifter2;
					if (!flag6)
					{
						int num6 = num << 2;
						object obj10 = uIHoverboardThemeShifter3._sortedThemes + num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S2_v50+10]");
						HoverboardThemes.HoverboardTheme hoverboardTheme = (HoverboardThemes.HoverboardTheme)0;
						HoverboardManager instance = HoverboardManager.Instance;
						Hoverboards.BoardType currentlyShownHoverboard = instance.GetCurrentlyShownHoverboard(uIHoverboardThemeShifter3._context);
						nint num7 = 0;
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S9_v12 (Il2CppRgctx<System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>)+8C]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v482 @ S9_v13+4] (should have been resolved before IL gen)");
						int index = obj12 + 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S2_v50+10]");
						((UIHoverboardThemeShifter)num9).SetActiveBubbles(hoverboardThemeButton, (HoverboardThemes.HoverboardTheme)0, currentlyShownHoverboard, index);
						nint num10 = 0;
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S5_v22 (Il2CppRgctx<System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>)+8C]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v533 @ S5_v23+4] (should have been resolved before IL gen)");
						_ = hoverboardTheme.buttonIconColor;
						_ = hoverboardTheme.buttonBgColor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+68]");
						uIHoverboardThemeShifter._defaultHoverboardThemeButton = (GameObject)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+60]");
						((UnityEngine.Object)uIHoverboardThemeShifter).m_CachedPtr = (IntPtr)0;
						Color32 bgColor2 = (Color32)(uIHoverboardThemeShifter + 12);
						color3 = (Color32)(uIHoverboardThemeShifter + 8);
						int num5 = obj14 + 1;
						hoverboardThemeButton.InitButton(hoverboardTheme.iconName, bgColor2, color3, num5);
						text = hoverboardTheme.iconName;
					}
				}
				GameObject gameObject2 = hoverboardThemeButton.gameObject;
				gameObject2.SetActive(value: true);
				color2 = (Color32)text;
				uIHoverboardThemeShifter2 = (UIHoverboardThemeShifter)color3;
			}
			else
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate(uIHoverboardThemeShifter3._customHoverboardThemeButton);
				HoverboardThemeButton component2 = gameObject3.GetComponent<HoverboardThemeButton>();
				if (component2 != null)
				{
					Transform transform = component2.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					GameObject gameObject4 = ((Component)0).gameObject;
					Transform parent = gameObject4.transform;
					transform.parent = parent;
					Transform transform2 = component2.transform;
					Transform transform3 = uIHoverboardThemeShifter3._customHoverboardThemeButton.transform;
					Vector3 localPosition = transform3.localPosition;
					object obj15 = uIHoverboardThemeShifter3._distanceBetweenButtons * num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+88]");
					object obj16 = 0 + obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v183 (UIHoverboardThemeShifter)+18]");
					object obj17 = (nint)0 * (nint)num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+8C]");
					object obj18 = 0 + obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v183 (UIHoverboardThemeShifter)+1C]");
					object obj19 = (nint)0 * (nint)num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+90]");
					object obj20 = 0 + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+58]");
					uIHoverboardThemeShifter._sortedThemes = (HoverboardThemes.HoverboardTheme[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+50]");
					uIHoverboardThemeShifter._cachedThemeIndex = 0;
					Vector3 localPosition2 = (Vector3)(uIHoverboardThemeShifter + 40);
					transform2.localPosition = localPosition2;
					Transform transform4 = component2.transform;
					nint num12 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S1_v72 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S1_v73 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
					uIHoverboardThemeShifter._customButtons = (List<HoverboardThemeButton>)0;
					_ = Vector3.oneVector;
					Vector3 localScale = (Vector3)(uIHoverboardThemeShifter + 24);
					transform4.localScale = localScale;
					object obj21 = num + 1;
					int num14 = uIHoverboardThemeShifter + 156;
					string text2 = ((int*)num14)->ToString();
					string text3 = text2 + "BoardThemeBtn";
					component2.name = text3;
					HoverboardThemes.HoverboardTheme[] sortedThemes3 = uIHoverboardThemeShifter3._sortedThemes;
					bool flag7 = uIHoverboardThemeShifter3._sortedThemes == null;
					nint num15 = num13;
					if (!flag7)
					{
						bool flag8 = sortedThemes3.Length <= num;
						num15 = num13;
						if (!flag8)
						{
							int num16 = num << 2;
							object obj22 = uIHoverboardThemeShifter3._sortedThemes + num16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ S2_v40+10]");
							HoverboardThemes.HoverboardTheme hoverboardTheme2 = (HoverboardThemes.HoverboardTheme)0;
							HoverboardManager instance2 = HoverboardManager.Instance;
							Hoverboards.BoardType currentlyShownHoverboard2 = instance2.GetCurrentlyShownHoverboard(uIHoverboardThemeShifter3._context);
							nint num17 = 0;
							nint num18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ S9_v6 (Il2CppRgctx<System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>)+8C]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v713 @ S9_v7+4] (should have been resolved before IL gen)");
							int index2 = obj24 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							nint num19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ S2_v40+10]");
							((UIHoverboardThemeShifter)num19).SetActiveBubbles(component2, (HoverboardThemes.HoverboardTheme)0, currentlyShownHoverboard2, index2);
							nint num20 = 0;
							nint num21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S5_v10 (Il2CppRgctx<System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>)+8C]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v739 @ S5_v11+4] (should have been resolved before IL gen)");
							_ = hoverboardTheme2.buttonIconColor;
							_ = hoverboardTheme2.buttonBgColor;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+48]");
							uIHoverboardThemeShifter._distanceBetweenButtons = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIHoverboardThemeShifter)+40]");
							uIHoverboardThemeShifter._customHoverboardThemeButton = (GameObject)0;
							Color32 bgColor3 = (Color32)(uIHoverboardThemeShifter + 20);
							Color32 iconColor = (Color32)(uIHoverboardThemeShifter + 16);
							int num5 = obj26 + 1;
							component2.InitButton(hoverboardTheme2.iconName, bgColor3, iconColor, num5);
							num15 = (nint)hoverboardTheme2.iconName;
						}
					}
					uIHoverboardThemeShifter3._customButtons.Add(component2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					onPressEvent._002Ector(0, (nint)__ldftn(UIHoverboardThemeShifter.ClickedTheme));
					component2.OnPress += onPressEvent;
					color2 = (Color32)num15;
					uIHoverboardThemeShifter2 = null;
				}
			}
			int num22 = num + 1;
			num = num22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		((UIHoverboardThemeShifter)0).UpdateThemeStates();
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2369");
	}

	private void SetActiveBubbles(HoverboardThemeButton btn, HoverboardThemes.HoverboardTheme ht, Hoverboards.BoardType boardType, int index)
	{
		//IL_0198: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		bool enableGiftBuble;
		Hoverboards.Board board;
		if (index != 0)
		{
			object obj = ht.unlockType - 2;
			if (ht.unlockType == PurchaseData.UnlockType.Coins)
			{
				goto IL_00b1;
			}
			bool flag = (nint)obj == 1;
			enableGiftBuble = false;
			if (!flag)
			{
				bool flag2 = (nint)obj == 2;
				enableGiftBuble = false;
				if (!flag2)
				{
					if ((nint)obj == 3)
					{
						goto IL_00b1;
					}
					enableGiftBuble = false;
				}
			}
		}
		else
		{
			board = Hoverboards.boardData.get_Item(boardType);
			object obj2 = board.unlockType - 2;
			if (board.unlockType == PurchaseData.UnlockType.Coins)
			{
				goto IL_0231;
			}
			bool flag3 = (nint)obj2 == 1;
			enableGiftBuble = false;
			if (!flag3)
			{
				bool flag4 = (nint)obj2 == 2;
				enableGiftBuble = false;
				if (!flag4)
				{
					if ((nint)obj2 == 3)
					{
						goto IL_0231;
					}
					enableGiftBuble = false;
				}
			}
		}
		goto IL_0301;
		IL_0231:
		enableGiftBuble = false;
		if (board.price == 0)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			bool flag5 = instance.IsHoverboardUnlocked(boardType);
			bool flag6 = (byte)((flag5 ? 1u : 0u) ^ 1u) != 0;
			enableGiftBuble = flag6;
		}
		goto IL_0301;
		IL_00b1:
		enableGiftBuble = false;
		if (ht.price == 0)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			bool flag7 = instance2._hoverboardCustomizationData.IsThemeOwned(boardType, ht.identifier);
			enableGiftBuble = false;
			if (!flag7)
			{
				if (_cachedThemeIndex == 0)
				{
					enableGiftBuble = true;
				}
				else
				{
					bool flag8 = _cachedThemeIndex != btn._index;
					enableGiftBuble = flag8;
				}
			}
		}
		goto IL_0301;
		IL_0301:
		PlayerInfo instance3 = PlayerInfo.Instance;
		bool flag9 = instance3._hoverboardCustomizationData.HasThemeBeenSeen(boardType, ht.identifier);
		bool enableNewBuble = false;
		if (!flag9)
		{
			PlayerInfo instance4 = PlayerInfo.Instance;
			enableNewBuble = false;
			if (!instance4._isFreshInstall)
			{
				enableNewBuble = ht.isNewInThisUpdate;
			}
		}
		btn.setActiveBubles(enableGiftBuble, enableNewBuble);
	}

	private void UpdateSelector(int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2369");
	}

	public void DisableThemeShifter()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	public void UpdateThemeStates()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int num = 0;
		while (true)
		{
			List<HoverboardThemeButton> customButtons = _customButtons;
			if (num >= customButtons._size)
			{
				break;
			}
			HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(_cachedBoard, num);
			HoverboardThemeButton.ThemeState currentState;
			if (instance._hoverboardCustomizationData.IsThemeOwned(_cachedBoard, themeIdentifier))
			{
				HoverboardThemes.ThemeIdentifier themeIdentifier2 = HoverboardThemes.GetThemeIdentifier(_cachedBoard, num);
				bool flag = instance._hoverboardCustomizationData.IsThemeActive(_cachedBoard, themeIdentifier2);
				currentState = HoverboardThemeButton.ThemeState.OwnedAndActive;
				if (!flag)
				{
					currentState = HoverboardThemeButton.ThemeState.OwnedAndInactive;
				}
			}
			else
			{
				PlayerInfo instance2 = PlayerInfo.Instance;
				bool flag2 = instance2.IsHoverboardUnlocked(_cachedBoard);
				currentState = HoverboardThemeButton.ThemeState.NotOwned;
				if (!flag2)
				{
					currentState = HoverboardThemeButton.ThemeState.NotPurchaseable;
				}
			}
			HoverboardThemeButton hoverboardThemeButton = _customButtons.get_Item(num);
			hoverboardThemeButton.SetCurrentState(currentState);
			int num2 = num + 1;
			num = num2;
		}
	}

	public void ClickedTheme(int index)
	{
		//IL_00ae: Expected Obj, but got I
		HoverboardManager instance = HoverboardManager.Instance;
		Hoverboards.BoardType currentlyShownHoverboard = instance.GetCurrentlyShownHoverboard(_context);
		_cachedThemeIndex = index;
		_cachedBoard = currentlyShownHoverboard;
		UpdateSelector(index);
		if (index != 0)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			int tIndex = index - 1;
			HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(_cachedBoard, tIndex);
			instance2._hoverboardCustomizationData.SetThemeSeen(_cachedBoard, themeIdentifier);
		}
		if (this.m_OnClickedTheme != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S3_v4 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}

	public void ResetThemeSelection()
	{
		HoverboardManager instance = HoverboardManager.Instance;
		Hoverboards.BoardType currentlyShownHoverboard = instance.GetCurrentlyShownHoverboard(_context);
		_cachedThemeIndex = 0;
		_cachedBoard = currentlyShownHoverboard;
		UpdateSelector(0);
		UpdateThemeStates();
	}

	public UIHoverboardThemeShifter()
	{
		//IL_0037: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_distanceBetweenButtons = Vector3.zeroVector;
		List<HoverboardThemeButton> list = default;
		list._002Ector();
		_customButtons = list;
		List<HoverboardThemes.HoverboardTheme> list2 = default;
		list2._002Ector();
		_currentBoardThemes = list2;
		base._002Ector();
	}
}
