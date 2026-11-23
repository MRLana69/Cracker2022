using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BuyHoverboardButton : MonoBehaviour
{
	private HoverboardPopup HoverboardPopup;

	private TMP_Text amountLabel;

	private TMP_Text priceLabel;

	private bool _purchaseInProgress;

	private bool _amountLabelRepositioned;

	private Button BuyButton;

	private Button FreeButton;

	private unsafe void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_003b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		TMP_Text tMP_Text = priceLabel;
		Upgrade upgrade = Upgrades.upgrades.get_Item(PowerupType.hoverboard);
		int price = upgrade.getPrice(0);
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Button buyButton = BuyButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(BuyHoverboardButton._003CStart_003Eb__7_0));
		buyButton.m_OnClick.AddListener(unityAction);
		Button freeButton = FreeButton;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(BuyHoverboardButton._003CStart_003Eb__7_1));
		freeButton.m_OnClick.AddListener(unityAction2);
	}

	public void SetUp()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		GameObject gameObject = BuyButton.gameObject;
		gameObject.SetActive(instance._hasShownHoverboardPopup);
		GameObject gameObject2 = FreeButton.gameObject;
		bool active = (byte)(~(instance._hasShownHoverboardPopup ? 1u : 0u)) != 0;
		gameObject2.SetActive(active);
	}

	private void OnEnable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private unsafe void OnClick()
	{
		if (~(_purchaseInProgress ? 1u : 0u) != 0)
		{
			_purchaseInProgress = true;
			PurchaseHandler instance = PurchaseHandler.Instance;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(BuyHoverboardButton.OnPurchaseSuccessful));
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(BuyHoverboardButton.OnPurchaseFailure));
			instance.PurchaseUpgrade(PowerupType.hoverboard, action, action2);
		}
	}

	private unsafe void UpdateLabels(PowerupType powerupType, int newAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected I4, but got Unknown
		//IL_0045: Expected I, but got Obj
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0143: Expected F4, but got I
		//IL_013e: Expected native int or pointer, but got VT
		//IL_016a: Expected F4, but got I
		//IL_0165: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (powerupType == PowerupType.hoverboard)
		{
			TMP_Text tMP_Text = amountLabel;
			int num = (int)(vector + 44);
			string text = ((int*)num)->ToString();
			nint num2 = (nint)tMP_Text;
			object obj2 = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			DeviceInfo instance = DeviceInfo.Instance;
			if (~(instance.isHighres__BackingField ? 1u : 0u) == 0 && !_amountLabelRepositioned)
			{
				Transform transform = amountLabel.transform;
				Transform transform2 = amountLabel.transform;
				Vector3 localPosition = transform2.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				float num3 = 0f + 1f;
				Transform transform3 = amountLabel.transform;
				Vector3 localPosition2 = transform3.localPosition;
				Transform transform4 = amountLabel.transform;
				Vector3 localPosition3 = transform4.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				transform.localPosition = vector;
				_amountLabelRepositioned = true;
			}
		}
	}

	public void OnPurchaseSuccessful()
	{
		_purchaseInProgress = false;
	}

	public void OnPurchaseFailure()
	{
		_purchaseInProgress = false;
	}

	private void _003CStart_003Eb__7_0()
	{
		OnClick();
	}

	private void _003CStart_003Eb__7_1()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		instance.IncreaseUpgradeAmount(PowerupType.hoverboard, 3);
		PlayerInfo instance2 = PlayerInfo.Instance;
		int upgradeAmount = instance2.GetUpgradeAmount(PowerupType.hoverboard);
		UpdateLabels(PowerupType.hoverboard, upgradeAmount);
		PlayerInfo instance3 = PlayerInfo.Instance;
		if (!instance3._hasShownHoverboardPopup)
		{
			instance3._dirty = true;
			instance3._hasShownHoverboardPopup = true;
		}
		PlayerInfo instance4 = PlayerInfo.Instance;
		instance4.SaveIfDirty();
		SetUp();
	}
}
