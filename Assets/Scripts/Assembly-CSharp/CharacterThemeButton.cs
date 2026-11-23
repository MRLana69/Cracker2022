using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CharacterThemeButton : MonoBehaviour
{
	private Image _background;

	private Image _icon;

	private GameObject giftBuble;

	private GameObject newBuble;

	private GameObject _lockIcon;

	public GameObject selectedSprite;

	private Button PressButton;

	private int themeIndex__BackingField;

	private Action<int> m_OnPress;

	public int themeIndex
	{
		get
		{
			return themeIndex__BackingField;
		}
		private set
		{
			themeIndex__BackingField = value;
		}
	}

	public event Action<int> OnPress
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 44;
			Delegate obj2 = this.m_OnPress;
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
			object obj = this + 44;
			Delegate obj2 = this.m_OnPress;
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

	private unsafe void Start()
	{
		Button pressButton = PressButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(CharacterThemeButton._003CStart_003Eb__11_0));
		pressButton.m_OnClick.AddListener(unityAction);
	}

	public void SetColors(Color32 bgColor, Color32 iconColor, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		int num = bgColor.rgba >> 16;
		int num2 = num & 0xFF;
		float num3 = (float)num2 / 255f;
		int num4 = bgColor.rgba >> 24;
		float num5 = (float)num4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		int num6 = bgColor.rgba & 0xFF;
		float num7 = (float)num6 / 255f;
		int num8 = bgColor.rgba >> 8;
		int num9 = num8 & 0xFF;
		float num10 = (float)num9 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		int num11 = iconColor.rgba >> 16;
		int num12 = num11 & 0xFF;
		float num13 = (float)num12 / 255f;
		int num14 = iconColor.rgba >> 24;
		float num15 = (float)num14 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		int num16 = iconColor.rgba & 0xFF;
		float num17 = (float)num16 / 255f;
		int num18 = iconColor.rgba >> 8;
		int num19 = num18 & 0xFF;
		float num20 = (float)num19 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		themeIndex__BackingField = index;
	}

	public void SetActiveBubbles(bool enableGiftBuble, bool enableNewBuble)
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

	public void SetLockIconEnabled(bool state)
	{
		if (_lockIcon != null)
		{
			_lockIcon.SetActive(state);
		}
	}

	private void ButtonPressed()
	{
		//IL_007d: Expected Obj, but got I
		if (newBuble != null && newBuble.activeSelf)
		{
			newBuble.SetActive(value: false);
		}
		if (this.m_OnPress != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void _003CStart_003Eb__11_0()
	{
		ButtonPressed();
	}
}
