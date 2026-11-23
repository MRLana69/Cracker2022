using System;
using Cpp2ILInjected;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ConsumablesPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__14_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CStart_003Eb__14_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("ConsumablesPopup");
		}
	}

	private Image _header;

	private Image icon;

	private TMP_Text _count;

	private TMP_Text hoverboardDescription;

	private TMP_Text _price;

	private Button ResumeButton;

	private Button BackButton;

	private Button BuyButton;

	private Sprite scorebooster;

	private Sprite heartstar;

	private Sprite hoverboard;

	private SellConsumablesHelper _consumablesHelper;

	private UIPopupIn UIPopupIn;

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<ConsumablesPopup>)+104] (should have been resolved before IL gen)");
		SellConsumablesHelper instance = SellConsumablesHelper.instance;
		_consumablesHelper = instance;
	}

	private void OnEnable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private unsafe void Start()
	{
		Button resumeButton = ResumeButton;
		bool flag = _003C_003Ec._003C_003E9__14_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__14_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__14_0));
			_003C_003Ec._003C_003E9__14_0 = unityAction;
			call = unityAction;
		}
		resumeButton.m_OnClick.AddListener(call);
		Button buyButton = BuyButton;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(ConsumablesPopup._003CStart_003Eb__14_1));
		buyButton.m_OnClick.AddListener(unityAction2);
		UnityAction unityAction3 = default;
		unityAction3._002Ector(this, (nint)__ldftn(ConsumablesPopup._003CStart_003Eb__14_2));
		OutConplete.AddListener(unityAction3);
	}

	private void OnDisable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
		SellConsumablesHelper consumablesHelper = _consumablesHelper;
		Setup(consumablesHelper._activeConsumable);
		_consumablesHelper.DidShowConsuamblesPopup();
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

	public override void Hide()
	{
		base.Hide();
		_consumablesHelper.DidHideConsumablesPopup();
	}

	private unsafe void Setup(SellableConsumable consumable)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0136: Expected I, but got Obj
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected I4, but got Unknown
		//IL_017b: Expected I, but got Obj
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected I4, but got Unknown
		//IL_01cf: Expected I, but got Obj
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (consumable == null)
		{
			return;
		}
		object obj3 = consumable.powerupType__BackingField - 1;
		object sprite;
		object path;
		StringID key;
		if (consumable.powerupType__BackingField != PowerupType.hoverboard)
		{
			if ((nint)obj3 == 1)
			{
				goto IL_0209;
			}
			if ((nint)obj3 == 2)
			{
				sprite = this + 88;
				path = "UI/icon_upgrades_headstart2000";
				key = StringID.HEADSTARTS_POPUP_DESCRIPTION_LONG;
			}
			else
			{
				if (consumable.powerupType__BackingField != PowerupType.scorebooster)
				{
					goto IL_0209;
				}
				sprite = this + 84;
				path = "UI/icon_upgrades_scorebooster";
				key = StringID.SCOREBOOSTERS_POPUP_DESCRIPTION_LONG;
			}
		}
		else
		{
			sprite = this + 92;
			path = "UI/icon_upgrades_hoverboard";
			key = StringID.HOVERBOARD_POPUP_DESCRIPTION_LONG;
		}
		_header.sprite = (Sprite)sprite;
		Sprite sprite2 = Resources.Load<Sprite>((string)path);
		icon.sprite = sprite2;
		TMP_Text tMP_Text = hoverboardDescription;
		string text = Strings.Get(key);
		nint num = (nint)tMP_Text;
		object obj4 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ S2_v8 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		goto IL_0209;
		IL_0209:
		TMP_Text count = _count;
		PlayerInfo instance = PlayerInfo.Instance;
		int upgradeAmount = instance.GetUpgradeAmount(consumable.powerupType__BackingField);
		int num2 = obj + 12;
		string text2 = ((int*)num2)->ToString();
		nint num3 = (nint)count;
		object obj5 = count + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ S2_v17 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text price = _price;
		_ = consumable.price__BackingField;
		int num4 = obj + 12;
		string text3 = ((int*)num4)->ToString();
		nint num5 = (nint)price;
		object obj6 = price + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v161 @ S2_v23 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	private unsafe void OnPowerupAmountChanged(PowerupType powerupType, int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected I4, but got Unknown
		//IL_0083: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		SellConsumablesHelper consumablesHelper = _consumablesHelper;
		SellableConsumable activeConsumable = consumablesHelper._activeConsumable;
		if (powerupType == activeConsumable.powerupType__BackingField)
		{
			TMP_Text count = _count;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			nint num2 = (nint)count;
			object obj3 = count + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "[SellConsumablesPopup] " + msg;
	}

	private void _003CStart_003Eb__14_1()
	{
		_consumablesHelper.MakePurchase();
	}

	private void _003CStart_003Eb__14_2()
	{
		//IL_000b: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<ConsumablesPopup>)+EC] (should have been resolved before IL gen)");
		UIScreenController instance = UIScreenController.Instance;
		instance.PushScreen("IngameUI");
	}
}
