using Cpp2ILInjected;
using UnityEngine;

public class UIButtonOverlayOff : MonoBehaviour
{
	public enum ButtonType
	{
		Custom,
		Primary,
		Secondary,
		Tertiary,
		Facebook,
		GameCenter,
		Primary_inactive,
		Tertiary_inactive,
		Footer_back,
		Footer_me,
		Footer_friends,
		Footer_shop,
		Seasonal,
		SocialGrey,
		WeeklyHunt,
		LimitedCharacterPopup,
		LimitedBoardPopup,
		Exit
	}

	public GameObject fillWithPrimeColor;

	private Color32 _originalFillColor;

	private float DURATION;

	public UISprite overlay;

	protected bool _initDone;

	private bool _buttonStateLocked;

	public ButtonType buttonType;

	private ButtonColorScheme buttonColorScheme;

	private void Awake()
	{
		if (~(_initDone ? 1u : 0u) != 0)
		{
			Init();
		}
	}

	private void OnDisable()
	{
	}

	public void SetButtonType(ButtonType type)
	{
		buttonType = type;
		Init();
		ButtonPressed(isPressed: false);
	}

	protected unsafe void Init()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0080: Expected VT, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I
		//IL_0190: Expected F4, but got I
		//IL_018b: Expected native int or pointer, but got VT
		//IL_01a6: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_0209: Expected F4, but got I
		//IL_0204: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 112);
		_ = 0;
		_ = 0;
		_initDone = true;
		GameObject gameObject = base.gameObject;
		ButtonColorScheme buttonColorScheme = GlobalColors.GetButtonColorScheme(buttonType, gameObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
		this.buttonColorScheme = (ButtonColorScheme)0;
		if (overlay != null)
		{
			overlay.enabled = true;
			_ = this.buttonColorScheme;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+68]");
			if ((nint)0 != 0)
			{
				_ = this.buttonColorScheme;
				object obj2 = color - -64;
				object obj3 = color + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @286F");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
				object obj4 = (nint)0 >> 16;
				object obj5 = obj4 & 0xFF;
				float num = (float)obj5 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
				object obj6 = (nint)0 >> 24;
				float num2 = (float)obj6 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
				((Color*)(nint)color)->b = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
				object obj7 = (nint)0 & (nint)0xFF;
				float num3 = (float)obj7 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
				object obj8 = (nint)0 >> 8;
				object obj9 = obj8 & 0xFF;
				float num4 = (float)obj9 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
				((Color*)(nint)color)->r = 0f;
				overlay.color = color;
			}
		}
	}

	public void GoToNormalState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		if (_buttonStateLocked)
		{
			return;
		}
		BoxCollider component = GetComponent<BoxCollider>();
		if ((bool)component)
		{
			BoxCollider component2 = GetComponent<BoxCollider>();
			component2.enabled = true;
		}
		if (overlay != null)
		{
			_ = buttonColorScheme;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			if ((nint)0 != 0)
			{
				_ = buttonColorScheme;
				object obj3 = obj + 40;
				object obj4 = obj + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @286F");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				object obj5 = (nint)0 >> 16;
				object obj6 = obj5 & 0xFF;
				float num = (float)obj6 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				object obj7 = (nint)0 >> 24;
				float num2 = (float)obj7 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				object obj8 = (nint)0 & (nint)0xFF;
				float num3 = (float)obj8 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				object obj9 = (nint)0 >> 8;
				object obj10 = obj9 & 0xFF;
				float num4 = (float)obj10 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Color color = (Color)(obj + 8);
				overlay.color = color;
			}
			overlay.enabled = true;
		}
	}

	public void GoToNotAvailableState()
	{
		if (!_buttonStateLocked)
		{
			BoxCollider component = GetComponent<BoxCollider>();
			if ((bool)component)
			{
				BoxCollider component2 = GetComponent<BoxCollider>();
				component2.enabled = false;
			}
			if (overlay != null)
			{
				overlay.enabled = false;
			}
		}
	}

	public void GoToSelectedState()
	{
		if (!_buttonStateLocked)
		{
			BoxCollider component = GetComponent<BoxCollider>();
			if ((bool)component)
			{
				BoxCollider component2 = GetComponent<BoxCollider>();
				component2.enabled = false;
			}
			if (overlay != null)
			{
				overlay.enabled = false;
			}
		}
	}

	public void LockState(bool locked)
	{
		_buttonStateLocked = locked;
	}

	protected virtual void OnPress(bool isPressed)
	{
		ButtonPressed(isPressed);
	}

	public void ButtonPressed(bool isPressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected VT, but got Unknown
		//IL_00e2: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		if (!enabled)
		{
			return;
		}
		if (overlay != null)
		{
			_ = buttonColorScheme;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			if ((nint)0 == 0)
			{
				GameObject gameObject = overlay.gameObject;
				if (isPressed)
				{
					gameObject.SetActive(value: false);
				}
				else
				{
					gameObject.SetActive(value: true);
				}
				return;
			}
			_ = buttonColorScheme;
			object obj3 = obj + 40;
			object obj4 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @286F");
			GameObject go = overlay.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			object obj5 = (nint)0 & (nint)0xFFFFFF;
			if (!isPressed)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				obj5 = 0;
			}
			object obj6 = obj5 >> 16;
			object obj7 = obj6 & 0xFF;
			float num = (float)obj7 / 255f;
			object obj8 = obj5 >> 24;
			float num2 = (float)obj8 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			object obj9 = obj5 & 0xFF;
			float num3 = (float)obj9 / 255f;
			object obj10 = obj5 >> 8;
			object obj11 = obj10 & 0xFF;
			float num4 = (float)obj11 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Color color = (Color)(obj + 8);
			TweenColor tweenColor = TweenColor.Begin(go, DURATION, color);
		}
		if (isPressed)
		{
		}
	}

	public void ResetTweens()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		if (enabled && overlay != null)
		{
			_ = buttonColorScheme;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			if ((nint)0 != 0)
			{
				GameObject go = overlay.gameObject;
				_ = buttonColorScheme;
				object obj3 = obj + 40;
				object obj4 = obj + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @286F");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				object obj5 = (nint)0 >> 16;
				object obj6 = obj5 & 0xFF;
				float num = (float)obj6 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				object obj7 = (nint)0 >> 24;
				float num2 = (float)obj7 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				object obj8 = (nint)0 & (nint)0xFF;
				float num3 = (float)obj8 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				object obj9 = (nint)0 >> 8;
				object obj10 = obj9 & 0xFF;
				float num4 = (float)obj10 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Color color = (Color)(obj + 8);
				TweenColor tweenColor = TweenColor.Begin(go, DURATION, color);
			}
		}
	}
}
