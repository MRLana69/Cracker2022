using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class DailyChallengeColorChanger : MonoBehaviour
{
	public TMP_Text[] shadowLabel;

	public Color MyColorActive;

	public Color MyColorInactive;

	public TMP_Text[] _myLabel;

	private void OnEnable()
	{
		UpdateDailyWord();
	}

	private void HideCharacterShadow()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			TMP_Text[] array = shadowLabel;
			if (array.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v20+10]");
			GameObject gameObject = ((Component)0).gameObject;
			gameObject.SetActive(value: false);
			object obj4 = obj + 1;
			obj = obj4;
		}
		object obj5 = 0;
		while (true)
		{
			TMP_Text[] myLabel = _myLabel;
			if (myLabel.Length > (nint)obj5)
			{
				object obj6 = obj5 << 2;
				object obj7 = (object)myLabel + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v14+10]");
				GameObject gameObject2 = ((Component)0).gameObject;
				gameObject2.SetActive(value: false);
				object obj8 = obj5 + 1;
				obj5 = obj8;
				continue;
			}
			break;
		}
	}

	private unsafe void UpdateDailyWord()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected I4, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected I4, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_031e: Expected Obj, but got I
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		HideCharacterShadow();
		PlayerInfo instance = PlayerInfo.Instance;
		string dailyWord = instance._dailyWord;
		object obj3;
		if (instance._dailyWord != null)
		{
			obj3 = 0;
			if (dailyWord._stringLength != 0)
			{
				goto IL_029f;
			}
		}
		obj3 = 1;
		goto IL_029f;
		IL_029f:
		bool flag = obj3 == null;
		string text = instance._dailyWord;
		if (!flag)
		{
			text = string.Empty;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		_ = instance2._dailyWordUnlockedMask;
		int num = default;
		int num8 = default;
		while (num < text._stringLength)
		{
			int num2 = num << 2;
			object obj4 = shadowLabel + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v31+10]");
			object obj5 = 0;
			char c = text.get_Chars(num);
			char c2 = (char)(obj + 38);
			string text2 = ((char*)(ushort)c2)->ToString();
			object obj6 = obj5;
			object obj7 = obj5 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S2_v7+2CC] (should have been resolved before IL gen)");
			int num3 = num << 2;
			object obj8 = _myLabel + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v39+10]");
			object obj9 = 0;
			char c3 = text.get_Chars(num);
			char c4 = (char)(obj + 38);
			string text3 = ((char*)(ushort)c4)->ToString();
			object obj10 = obj9;
			object obj11 = obj9 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ S2_v15+2CC] (should have been resolved before IL gen)");
			int num4 = num << 2;
			object obj12 = _myLabel + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			int num5 = (int)((nint)0 >> num);
			if ((num5 & 1) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DailyChallengeColorChanger)+28]");
				_ = 0;
				_ = MyColorInactive;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DailyChallengeColorChanger)+18]");
				_ = 0;
				_ = MyColorActive;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			int num6 = num << 2;
			object obj13 = _myLabel + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v58+10]");
			GameObject gameObject = ((Component)0).gameObject;
			gameObject.SetActive(value: true);
			int num7 = num << 2;
			object obj14 = shadowLabel + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v63+10]");
			GameObject gameObject2 = ((Component)0).gameObject;
			gameObject2.SetActive(value: true);
			num = num8 + 1;
		}
	}
}
