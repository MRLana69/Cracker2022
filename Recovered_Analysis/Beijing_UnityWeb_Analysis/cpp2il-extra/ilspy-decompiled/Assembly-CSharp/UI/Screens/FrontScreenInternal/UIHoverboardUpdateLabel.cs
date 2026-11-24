using System;
using Cpp2ILInjected;
using Data.Save;
using Info;
using UI.Screens.CharacterScreenInternal;
using UI.Screens.UpgradeScreenInternal;
using UnityEngine;

namespace UI.Screens.FrontScreenInternal;

public class UIHoverboardUpdateLabel : MonoBehaviour
{
	private UILabel _amountLabel;

	private void Awake()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 one = Vector3.one;
		object obj4 = obj3 + 24;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		_ = 0;
		object obj5 = this + 40;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		Vector3 forward = Vector3.forward;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = this + 52;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		CancelInvoke();
	}

	private void OnEnable()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		UILabel component = GetComponent<UILabel>();
		obj = component;
	}

	private void OnDisable()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<UpgradeType, int> action = default;
		object obj = action + 16;
		obj = this;
		InventorySave.powerupsChanged -= action;
		int tier = InventorySave.GetTier(UpgradeType.hoverboard);
		((CharacterListManager)(object)this)._002Ector(1, (CharacterScreen)tier);
	}

	private void UpdateLabels(UpgradeType upgradeType, int amount)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.UIHoverboardUpdateLabel)+50]");
		if ((nint)0 == (nint)upgradeType)
		{
			((UpgradeHelper)this).OnClick();
		}
	}

	public UIHoverboardUpdateLabel()
	{
		//IL_002b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		int num2 = default;
		object obj = num2 + 16;
		obj = this;
		InventorySave.SetKeys(num2);
	}
}
