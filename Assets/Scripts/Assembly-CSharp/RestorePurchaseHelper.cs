using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RestorePurchaseHelper : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__3_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CStart_003Eb__3_0()
		{
			InAppManager instance = InAppManager.instance;
			string[] allProductIds = InAppData.GetAllProductIds();
			bool flag = instance.RestoreNonConsumablePurchases(allProductIds);
		}
	}

	private TMP_Text titleLabel;

	private TMP_Text descriptionLabel;

	private Button BuyButton;

	private unsafe void Start()
	{
		Button buyButton = BuyButton;
		bool flag = _003C_003Ec._003C_003E9__3_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__3_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__3_0));
			_003C_003Ec._003C_003E9__3_0 = unityAction;
			call = unityAction;
		}
		buyButton.m_OnClick.AddListener(call);
	}

	public void setOnClickDelegate(Action onFinishDelegate)
	{
	}

	private void Awake()
	{
		//IL_0046: Expected I, but got Obj
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		TMP_Text tMP_Text = titleLabel;
		string text = Strings.Get(StringID.RESTORE_BUTTON_TITLE);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S2_v3 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = descriptionLabel;
		string text2 = Strings.Get(StringID.RESTORE_BUTTON_DESCRIPTION);
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S2_v8 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}
}
