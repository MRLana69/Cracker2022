using System;
using Cpp2ILInjected;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Screens;

public class ShopScreen : UIScreen
{
	public enum Screen
	{
		Boost,
		Upgrade,
		Store,
		None
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__13_2;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003COnEnable_003Eb__13_2()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("ShopScreen");
		}
	}

	private Button CloseButton;

	private Button BoostButton;

	private Button UpgradeButton;

	private Button StoreButton;

	private BoostScreen BoostScreen;

	private UpgradeScreen UpgradeScreen;

	private CoinScreen CoinScreen;

	private Screen screen;

	public Screen CureentScreen;

	private UIClickable boost;

	private UIClickable store;

	private UIClickable upgrade;

	private UIPopupIn UIPopupIn;

	private unsafe void OnEnable()
	{
		UIClickable component = BoostButton.GetComponent<UIClickable>();
		boost = component;
		UIClickable component2 = StoreButton.GetComponent<UIClickable>();
		store = component2;
		UIClickable component3 = UpgradeButton.GetComponent<UIClickable>();
		upgrade = component3;
		Button boostButton = BoostButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(ShopScreen._003COnEnable_003Eb__13_0));
		boostButton.m_OnClick.AddListener(unityAction);
		Button upgradeButton = UpgradeButton;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(ShopScreen._003COnEnable_003Eb__13_1));
		upgradeButton.m_OnClick.AddListener(unityAction2);
		Button closeButton = CloseButton;
		bool flag = _003C_003Ec._003C_003E9__13_2 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__13_2;
		if (!flag2)
		{
			UnityAction unityAction3 = default;
			unityAction3._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003COnEnable_003Eb__13_2));
			_003C_003Ec._003C_003E9__13_2 = unityAction3;
			call = unityAction3;
		}
		closeButton.m_OnClick.AddListener(call);
		screen = Screen.None;
		ShowScreen(CureentScreen);
		UnityAction unityAction4 = default;
		unityAction4._002Ector(this, (nint)__ldftn(ShopScreen._003COnEnable_003Eb__13_3));
		OutConplete.AddListener(unityAction4);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.ShopScreen>)+104] (should have been resolved before IL gen)");
	}

	private void ShowScreen(Screen screen)
	{
		//IL_008d: Expected I, but got Obj
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00b7: Expected I, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00f1: Expected I, but got Obj
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_011b: Expected I, but got Obj
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		if (this.screen == screen)
		{
			return;
		}
		CureentScreen = screen;
		this.screen = screen;
		_003CShowScreen_003Eg__HidePopup_007C15_0();
		object obj3;
		if (this.screen != Screen.Boost)
		{
			if (this.screen != Screen.Upgrade)
			{
				return;
			}
			UpgradeScreen upgradeScreen = UpgradeScreen;
			nint num = (nint)upgradeScreen;
			object obj = upgradeScreen + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S1_v18 (Il2CppClass<UI.Screens.UpgradeScreen>)+DC] (should have been resolved before IL gen)");
			UpgradeScreen upgradeScreen2 = UpgradeScreen;
			nint num2 = (nint)upgradeScreen2;
			object obj2 = upgradeScreen2 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S1_v22 (Il2CppClass<UI.Screens.UpgradeScreen>)+E4] (should have been resolved before IL gen)");
			obj3 = this + 96;
		}
		else
		{
			BoostScreen boostScreen = BoostScreen;
			nint num3 = (nint)boostScreen;
			object obj4 = boostScreen + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S1_v9 (Il2CppClass<UI.Screens.BoostScreen>)+DC] (should have been resolved before IL gen)");
			BoostScreen boostScreen2 = BoostScreen;
			nint num4 = (nint)boostScreen2;
			object obj5 = boostScreen2 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S1_v13 (Il2CppClass<UI.Screens.BoostScreen>)+E4] (should have been resolved before IL gen)");
			obj3 = this + 88;
		}
		((UIClickable)obj3).SetUp(true);
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
	}

	public override void Hide()
	{
		base.Hide();
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

	private void _003COnEnable_003Eb__13_0()
	{
		ShowScreen(Screen.Boost);
	}

	private void _003COnEnable_003Eb__13_1()
	{
		ShowScreen(Screen.Upgrade);
	}

	private void _003COnEnable_003Eb__13_3()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.ShopScreen>)+EC] (should have been resolved before IL gen)");
	}

	private void _003CShowScreen_003Eg__HidePopup_007C15_0()
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_003c: Expected I, but got Obj
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0066: Expected I, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		BoostScreen boostScreen = BoostScreen;
		nint num = (nint)boostScreen;
		object obj = boostScreen + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<UI.Screens.BoostScreen>)+EC] (should have been resolved before IL gen)");
		UpgradeScreen upgradeScreen = UpgradeScreen;
		nint num2 = (nint)upgradeScreen;
		object obj2 = upgradeScreen + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v6 (Il2CppClass<UI.Screens.UpgradeScreen>)+EC] (should have been resolved before IL gen)");
		CoinScreen coinScreen = CoinScreen;
		nint num3 = (nint)coinScreen;
		object obj3 = coinScreen + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S1_v10 (Il2CppClass<UI.Screens.CoinScreen>)+EC] (should have been resolved before IL gen)");
		boost.SetUp(main: false);
		upgrade.SetUp(main: false);
		store.SetUp(main: false);
	}
}
