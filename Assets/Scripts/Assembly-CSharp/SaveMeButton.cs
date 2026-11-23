using System;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SaveMeButton : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__6_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CStart_003Eb__6_0()
		{
			RevivePlayer();
		}
	}

	private TMP_Text saveMePrice;

	public SaveMePopup saveMePopup;

	private Button ClickButton;

	private Sprite active;

	private Sprite unActive;

	private unsafe void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected I4, but got Unknown
		//IL_0078: Expected I, but got Obj
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		UIClickable component = GetComponent<UIClickable>();
		component.enabled = false;
		_ = SaveMeManager._numberOfUsedKeysInCurrentRun;
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfKeys = instance.amountOfKeys;
		Image image = ClickButton.image;
		bool flag = SaveMeManager._numberOfUsedKeysInCurrentRun <= amountOfKeys;
		object obj3 = 24;
		if (!flag)
		{
			obj3 = 28;
		}
		object sprite = (object)this + obj3;
		image.sprite = (Sprite)sprite;
		ClickButton.interactable = flag;
		TMP_Text tMP_Text = saveMePrice;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)tMP_Text;
		object obj4 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S2_v9 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	private unsafe void Start()
	{
		Button clickButton = ClickButton;
		bool flag = _003C_003Ec._003C_003E9__6_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__6_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__6_0));
			_003C_003Ec._003C_003E9__6_0 = unityAction;
			call = unityAction;
		}
		clickButton.m_OnClick.AddListener(call);
	}

	private unsafe static void RevivePlayer()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_026d: Expected VT, but got Obj
		//IL_0286: Expected Obj, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected I4, but got Unknown
		//IL_0207: Expected I4, but got Obj
		object obj = default;
		PurchaseHandler purchaseHandler = (PurchaseHandler)(obj - 16);
		purchaseHandler.onUpgradePurchase = null;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_ = 1;
		purchaseHandler.onUpgradePurchase = (Action<PowerupType, int>)SaveMeManager._numberOfUsedKeysInCurrentRun;
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfKeys = instance.amountOfKeys;
		if (amountOfKeys >= SaveMeManager._numberOfUsedKeysInCurrentRun)
		{
			UIScreenController instance2 = UIScreenController.Instance;
			string topScreenName = instance2.GetTopScreenName();
			UIScreen screenFromCache = instance2.GetScreenFromCache(topScreenName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			UnityEngine.Object obj2 = default;
			if (!(obj2 == null))
			{
				((IngameScreen)obj2).SetPauseButtonVisibility(true);
			}
			PlayerInfo instance3 = PlayerInfo.Instance;
			int amountOfKeys2 = instance3.amountOfKeys;
			int amountOfKeys3 = amountOfKeys2 - SaveMeManager._numberOfUsedKeysInCurrentRun;
			instance3.amountOfKeys = amountOfKeys3;
			PlayerInfo instance4 = PlayerInfo.Instance;
			int amountOfKeys4 = instance4.amountOfKeys;
			if (amountOfKeys4 <= -1)
			{
				PlayerInfo instance5 = PlayerInfo.Instance;
				instance5.amountOfKeys = 0;
			}
			Revive instance6 = Revive.Instance;
			instance6.SendRevive();
			SaveMeManager.IncrementNumberOfUsedKeys();
			UIScreenController instance7 = UIScreenController.Instance;
			instance7.CloseActivePopups("SaveMePopup");
			SaveMeManager.IS_PURCHASE_MADE_FROM_INGAME = false;
			SaveMeManager.IS_PURCHASE_RUNNING_INGAME = false;
			int num = purchaseHandler + 12;
			string text = ((int*)num)->ToString();
			MissionsManager instance8 = MissionsManager.Instance;
			instance8.PlayerDidThis(MissionTarget.SpendKeys, (int)purchaseHandler.onUpgradePurchase);
		}
		else
		{
			SaveMeManager.IS_PURCHASE_MADE_FROM_INGAME = true;
			SaveMeManager.IS_PURCHASE_RUNNING_INGAME = true;
			UIScreenController instance9 = UIScreenController.Instance;
			instance9.ClosePopup();
			PurchaseHandler instance10 = PurchaseHandler.Instance;
			purchaseHandler.PurchaseKeysIfNeeded(SaveMeManager._numberOfUsedKeysInCurrentRun);
		}
	}

	public static void SimulateOnClick()
	{
		RevivePlayer();
	}
}
