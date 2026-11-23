using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class CoinBoxSizer : MonoBehaviour
{
	public TMP_Text coinAmountLabel;

	public TMP_Text keyAmountLabel;

	private bool _updateAutomatically = true;

	private bool isInitialized;

	public unsafe bool updateAutomatically
	{
		get
		{
			return _updateAutomatically;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected I4, but got Unknown
			//IL_0065: Expected I, but got Obj
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_updateAutomatically = value;
			if (value)
			{
				TMP_Text tMP_Text = coinAmountLabel;
				PlayerInfo instance = PlayerInfo.Instance;
				int amountOfCoins = instance.amountOfCoins;
				int num = obj + 12;
				string text = ((int*)num)->ToString();
				nint num2 = (nint)tMP_Text;
				object obj3 = tMP_Text + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			}
		}
	}

	private unsafe void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected I4, but got Unknown
		//IL_012b: Expected I, but got Obj
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected I4, but got Unknown
		//IL_0179: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CoinBoxSizer._003COnEnable_003Eb__7_0));
		Delegate obj3 = Delegate.Combine(instance.onCoinsChanged, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onCoinsChanged = default;
		instance.onCoinsChanged = onCoinsChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		PlayerInfo instance2 = PlayerInfo.Instance;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(CoinBoxSizer._003COnEnable_003Eb__7_1));
		Delegate obj4 = Delegate.Combine(instance2.onKeysChanged, action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onKeysChanged = default;
		instance2.onKeysChanged = onKeysChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		if (~(isInitialized ? 1u : 0u) != 0)
		{
			TMP_Text tMP_Text = coinAmountLabel;
			int amountOfCoins = instance.amountOfCoins;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			nint num2 = (nint)tMP_Text;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S2_v16 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text2 = keyAmountLabel;
			int amountOfKeys = instance.amountOfKeys;
			int num3 = obj + 12;
			string text2 = ((int*)num3)->ToString();
			nint num4 = (nint)tMP_Text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S2_v22 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			isInitialized = true;
		}
	}

	private unsafe void OnDisable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CoinBoxSizer._003COnDisable_003Eb__8_0));
		Delegate obj = Delegate.Remove(instance.onCoinsChanged, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onCoinsChanged = default;
		instance.onCoinsChanged = onCoinsChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		PlayerInfo instance2 = PlayerInfo.Instance;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(CoinBoxSizer._003COnDisable_003Eb__8_1));
		Delegate obj2 = Delegate.Remove(instance2.onKeysChanged, action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onKeysChanged = default;
		instance2.onKeysChanged = onKeysChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private unsafe void _003COnEnable_003Eb__7_0()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_003b: Expected I, but got Obj
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		TMP_Text tMP_Text = coinAmountLabel;
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfCoins = instance.amountOfCoins;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)tMP_Text;
		object obj3 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	private unsafe void _003COnEnable_003Eb__7_1()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_003b: Expected I, but got Obj
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		TMP_Text tMP_Text = keyAmountLabel;
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfKeys = instance.amountOfKeys;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)tMP_Text;
		object obj3 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	private unsafe void _003COnDisable_003Eb__8_0()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_003b: Expected I, but got Obj
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		TMP_Text tMP_Text = coinAmountLabel;
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfCoins = instance.amountOfCoins;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)tMP_Text;
		object obj3 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	private unsafe void _003COnDisable_003Eb__8_1()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_003b: Expected I, but got Obj
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		TMP_Text tMP_Text = keyAmountLabel;
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfKeys = instance.amountOfKeys;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)tMP_Text;
		object obj3 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}
}
