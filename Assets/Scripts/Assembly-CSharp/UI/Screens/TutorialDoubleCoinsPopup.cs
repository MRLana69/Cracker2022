using System;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

namespace UI.Screens;

public class TutorialDoubleCoinsPopup : CharacterPopup
{
	private UILabel topTitle;

	private UILabel centerTitle;

	private UILabel bottomTitle;

	private UILabel line1Big;

	private UILabel line1Small;

	private UILabel line2Big;

	private UILabel line2Small;

	private UILabel line3Big;

	private UILabel line3Small;

	private GameObject doubleCoinsPrefab;

	private GameObject doubleCoins;

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected VT, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected VT, but got Unknown
		//IL_01dd: Expected Obj, but got I4
		//IL_0200: Expected native int or pointer, but got VT
		//IL_0225: Expected F4, but got I
		//IL_0220: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		base.Show();
		object obj2 = vector + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		object obj3 = vector + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Vector2? offsetFromAnchor = (Vector2?)(object)(vector + 32);
		Vector3? rotationOffset = (Vector3?)(object)(vector + 16);
		SetCharacter(Characters.CharacterType.frizzy, offsetFromAnchor, rotationOffset);
		topTitle.text = "Double";
		centerTitle.text = "Your";
		bottomTitle.text = "Coins";
		line1Big.text = "Get the Double Coin BOOSTER!";
		line1Small.text = "Every Coin = 2 COINS";
		line2Big.text = "Permanent feature!";
		line2Small.text = "Get Upgrades and New Stuff FASTER";
		line3Big.text = "BOOST your game!";
		line3Small.text = "Collected Coins will be worth DOUBLE";
		if (doubleCoins == null)
		{
			GameObject parent = base.gameObject;
			GameObject gameObject = NGUITools.AddChild(parent, doubleCoinsPrefab);
			doubleCoins = gameObject;
			DoubleCoinUpgradeHelper component = doubleCoins.GetComponent<DoubleCoinUpgradeHelper>();
			component.Init();
			UIScreenController instance = UIScreenController.Instance;
			UIRoot root = instance.root;
			int num = root.manualHeight / 2;
			object obj4 = num - 180;
			Transform transform = doubleCoins.transform;
			_ = 0;
			((Vector3*)(nint)vector)->z = 0f;
			_ = 1073741824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.localPosition = vector;
			NGUITools.AddWidgetCollider(doubleCoins);
		}
		UIScreenController instance2 = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void OnNewPopupShown(string popupName)
	{
		if (popupName != "TutorialDoubleCoinsPopup")
		{
			HideCharacter();
		}
	}

	private void OnNewPopupClosed(string popupName)
	{
		ShowCharacter();
	}

	public override void Hide()
	{
		base.Hide();
		UIScreenController instance = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void CloseClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}
}
