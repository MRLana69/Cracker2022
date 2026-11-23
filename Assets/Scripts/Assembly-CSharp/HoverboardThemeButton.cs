using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class HoverboardThemeButton : MonoBehaviour
{
	public delegate void OnPressEvent(int index);

	public enum ThemeState
	{
		NotOwned,
		OwnedAndInactive,
		OwnedAndActive,
		NotPurchaseable
	}

	private Image _background;

	private Image _icon;

	private GameObject giftBuble;

	private GameObject newBuble;

	private GameObject selectedCircle;

	private GameObject ownedCircle;

	private GameObject _lockIcon;

	public GameObject selectedSprite;

	private int _index;

	private HoverboardThemes.ThemeIdentifier _identifier;

	private OnPressEvent m_OnPress;

	public int ThemeIndex => _index;

	public event OnPressEvent OnPress
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_OnPress;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			object obj = this + 52;
			Delegate obj2 = this.m_OnPress;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public void InitButton(string iconName, Color32 bgColor, Color32 iconColor, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		object obj3;
		if (iconName != null)
		{
			obj3 = 0;
			if (iconName._stringLength != 0)
			{
				goto IL_0273;
			}
		}
		obj3 = 1;
		goto IL_0273;
		IL_0273:
		if (obj3 == null)
		{
			string path = "UI/" + iconName;
			Sprite sprite = Resources.Load<Sprite>(path);
			_icon.sprite = sprite;
		}
		int num = iconColor.rgba >> 16;
		int num2 = num & 0xFF;
		float num3 = (float)num2 / 255f;
		int num4 = iconColor.rgba >> 24;
		float num5 = (float)num4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		int num6 = iconColor.rgba & 0xFF;
		float num7 = (float)num6 / 255f;
		int num8 = iconColor.rgba >> 8;
		int num9 = num8 & 0xFF;
		float num10 = (float)num9 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		object obj4 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		int num11 = bgColor.rgba >> 16;
		int num12 = num11 & 0xFF;
		float num13 = (float)num12 / 255f;
		int num14 = bgColor.rgba >> 24;
		float num15 = (float)num14 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		int num16 = bgColor.rgba & 0xFF;
		float num17 = (float)num16 / 255f;
		int num18 = bgColor.rgba >> 8;
		int num19 = num18 & 0xFF;
		float num20 = (float)num19 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		_index = index;
	}

	public void setActiveBubles(bool enableGiftBuble, bool enableNewBuble)
	{
		if (giftBuble != null)
		{
			giftBuble.SetActive(enableGiftBuble);
		}
		if (newBuble != null)
		{
			newBuble.SetActive(enableNewBuble);
		}
	}

	public void SetCurrentState(ThemeState newState)
	{
		bool active = newState == ThemeState.NotPurchaseable;
		_lockIcon.SetActive(active);
		bool active2 = newState == ThemeState.OwnedAndActive;
		selectedCircle.SetActive(active2);
		bool active3 = newState == ThemeState.OwnedAndInactive;
		ownedCircle.SetActive(active3);
	}

	private void ButtonPressed()
	{
		if (newBuble != null && newBuble.activeSelf)
		{
			newBuble.SetActive(value: false);
		}
		OnPressEvent onPress = this.m_OnPress;
		if (this.m_OnPress != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
