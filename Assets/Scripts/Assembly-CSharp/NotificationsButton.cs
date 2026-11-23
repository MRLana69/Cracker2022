using Cpp2ILInjected;
using UnityEngine;

public class NotificationsButton : MonoBehaviour
{
	private UISprite normalFillSprite;

	private UISprite iconOff;

	private UILabel reminderLabel;

	private Transform btnNotification;

	private GameObject buttonOverlayGO;

	private Color originalColor;

	private void Awake()
	{
		UISprite uISprite = normalFillSprite;
		originalColor = ((UIWidget)uISprite).mColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (UISprite)+54]");
		_ = 0;
	}

	private void OnEnable()
	{
		SetupButton();
	}

	public void Click()
	{
		bool optionMessages = Settings.optionMessages;
		bool optionMessages2 = (byte)((optionMessages ? 1u : 0u) ^ 1u) != 0;
		Settings.optionMessages = optionMessages2;
		SetupButton();
	}

	private unsafe void SetupButton()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01b9: Expected F4, but got I
		//IL_01b4: Expected native int or pointer, but got VT
		//IL_01c8: Expected F4, but got VT
		//IL_01c3: Expected native int or pointer, but got VT
		//IL_0098: Expected Obj, but got VT
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got VT
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got VT
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected VT, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 48);
		bool optionMessages = Settings.optionMessages;
		StringID key = StringID.SETTINGS_POPUP_MESSAGES_ON;
		if (!optionMessages)
		{
			key = StringID.SETTINGS_POPUP_MESSAGES_OFF;
		}
		string text = Strings.Get(key);
		reminderLabel.text = text;
		bool flag = (byte)((optionMessages ? 1u : 0u) ^ 1u) != 0;
		iconOff.enabled = flag;
		SocialManager instance = SocialManager.instance;
		bool flag2 = buttonOverlayGO != null;
		if (~(instance.requestInvolvingDevicetokenInProgress__BackingField ? 1u : 0u) == 0)
		{
			if (flag2)
			{
				buttonOverlayGO.SetActive(value: false);
			}
			object obj2 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE >> 16;
			object obj3 = obj2 & 0xFF;
			float num = (float)obj3 / 255f;
			object obj4 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE >> 24;
			float num2 = (float)obj4 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
			_ = 0;
			object obj5 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE & 0xFF;
			float num3 = (float)obj5 / 255f;
			object obj6 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE >> 8;
			object obj7 = obj6 & 0xFF;
			float num4 = (float)obj7 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
			_ = 0;
			Color color2 = color + 16;
			normalFillSprite.color = color2;
		}
		else
		{
			if (flag2)
			{
				buttonOverlayGO.SetActive(value: true);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NotificationsButton)+28]");
			((Color*)(nint)color)->b = 0f;
			((Color*)(nint)color)->r = (float)originalColor;
			normalFillSprite.color = color;
		}
		BoxCollider component = btnNotification.GetComponent<BoxCollider>();
		bool flag3 = (byte)(~(instance.requestInvolvingDevicetokenInProgress__BackingField ? 1u : 0u)) != 0;
		component.enabled = flag3;
	}

	private void OnDisable()
	{
		Settings.UpdateOptionMessagesIfNeeded();
	}
}
