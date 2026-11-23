using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Screens;

public class SettingsPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__10_2;

		public static UnityAction _003C_003E9__10_3;

		public static UnityAction _003C_003E9__10_4;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CStart_003Eb__10_2()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushPopup("CountryPopup");
		}

		internal void _003CStart_003Eb__10_3()
		{
		}

		internal void _003CStart_003Eb__10_4()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("SettingsPopup");
		}
	}

	private TMP_Text music;

	private Image music_iconOff;

	private Button musicButton;

	private TMP_Text SFX;

	private Image SFX_iconOff;

	private Button SFXButton;

	private Button ContryButton;

	private Button MoreGameButton;

	private Button CloseButton;

	private TMP_InputField nickname;

	private UIPopupIn UIPopupIn;

	private unsafe void Start()
	{
		Button button = musicButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(SettingsPopup._003CStart_003Eb__10_0));
		button.m_OnClick.AddListener(unityAction);
		Button sFXButton = SFXButton;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(SettingsPopup._003CStart_003Eb__10_1));
		sFXButton.m_OnClick.AddListener(unityAction2);
		Button contryButton = ContryButton;
		bool flag = _003C_003Ec._003C_003E9__10_2 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__10_2;
		if (!flag2)
		{
			UnityAction unityAction3 = default;
			unityAction3._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__10_2));
			_003C_003Ec._003C_003E9__10_2 = unityAction3;
			call = unityAction3;
		}
		contryButton.m_OnClick.AddListener(call);
		Button moreGameButton = MoreGameButton;
		bool flag3 = _003C_003Ec._003C_003E9__10_3 == null;
		bool flag4 = !flag3;
		UnityAction call2 = _003C_003Ec._003C_003E9__10_3;
		if (!flag4)
		{
			UnityAction unityAction4 = default;
			unityAction4._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__10_3));
			_003C_003Ec._003C_003E9__10_3 = unityAction4;
			call2 = unityAction4;
		}
		moreGameButton.m_OnClick.AddListener(call2);
		Button closeButton = CloseButton;
		bool flag5 = _003C_003Ec._003C_003E9__10_4 == null;
		bool flag6 = !flag5;
		UnityAction call3 = _003C_003Ec._003C_003E9__10_4;
		if (!flag6)
		{
			UnityAction unityAction5 = default;
			unityAction5._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__10_4));
			_003C_003Ec._003C_003E9__10_4 = unityAction5;
			call3 = unityAction5;
		}
		closeButton.m_OnClick.AddListener(call3);
		UnityAction unityAction6 = default;
		unityAction6._002Ector(this, (nint)__ldftn(SettingsPopup._003CStart_003Eb__10_5));
		OutConplete.AddListener(unityAction6);
	}

	public override void Init()
	{
		//IL_001a: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Screens.SettingsPopup>)+104] (should have been resolved before IL gen)");
		PlayerInfo instance = PlayerInfo.Instance;
		string userName = instance.UserName;
		nickname.text = userName;
	}

	public override void Show()
	{
		bool optionMusic = Settings.optionMusic;
		SetupMusic(optionMusic);
		bool optionSfx = Settings.optionSfx;
		SetupSFX(optionSfx);
		base.Show();
		ShowPopUp();
	}

	private void GetComponent()
	{
		if (UIPopupIn == null)
		{
			UIPopupIn componentInChildren = GetComponentInChildren<UIPopupIn>();
			UIPopupIn = componentInChildren;
		}
	}

	private void ShowPopUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN);
	}

	public void HidePupUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT);
	}

	private void SetupMusic(bool enabled)
	{
		//IL_0049: Expected I, but got Obj
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		TMP_Text tMP_Text = music;
		StringID key = StringID.SETTINGS_POPUP_MUSIC_ON;
		if (!enabled)
		{
			key = StringID.SETTINGS_POPUP_MUSIC_OFF;
		}
		string text = Strings.Get(key);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S2_v4 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		bool flag = (byte)((enabled ? 1u : 0u) ^ 1u) != 0;
		music_iconOff.enabled = flag;
	}

	private void SetupSFX(bool enabled)
	{
		//IL_0049: Expected I, but got Obj
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		TMP_Text sFX = SFX;
		StringID key = StringID.SETTINGS_POPUP_SFX_ON;
		if (!enabled)
		{
			key = StringID.SETTINGS_POPUP_SFX_OFF;
		}
		string text = Strings.Get(key);
		nint num = (nint)sFX;
		object obj = sFX + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S2_v4 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		bool flag = (byte)((enabled ? 1u : 0u) ^ 1u) != 0;
		SFX_iconOff.enabled = flag;
	}

	public override void Hide()
	{
		base.Hide();
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	public void LoggedOutOfFacebook()
	{
	}

	public void ConnectedToFacebook()
	{
	}

	private void _003CStart_003Eb__10_0()
	{
		Settings.ToggleCurrentMusicOption();
		bool optionMusic = Settings.optionMusic;
		SetupMusic(optionMusic);
	}

	private void _003CStart_003Eb__10_1()
	{
		Settings.ToggleCurrentSfxOption();
		bool optionSfx = Settings.optionSfx;
		SetupSFX(optionSfx);
	}

	private void _003CStart_003Eb__10_5()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.SettingsPopup>)+EC] (should have been resolved before IL gen)");
	}
}
