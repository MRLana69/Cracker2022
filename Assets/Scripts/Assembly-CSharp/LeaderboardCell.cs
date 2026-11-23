using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardCell : MonoBehaviour
{
	private TMP_Text rank;

	private Image avata;

	private TMP_Text cellName;

	private TMP_Text score;

	private Image bg;

	private Sprite color_1;

	private Sprite color_2;

	public unsafe void UpdateCell(int _rank, string _cellName, int _score, bool me)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected I4, but got Unknown
		//IL_00a4: Expected I, but got Obj
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00ce: Expected I, but got Obj
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected I4, but got Unknown
		//IL_0045: Expected I, but got Obj
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = 36;
		if (!me)
		{
			obj3 = 32;
		}
		object sprite = (object)this + obj3;
		bg.sprite = (Sprite)sprite;
		TMP_Text tMP_Text = rank;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)tMP_Text;
		object obj4 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = cellName;
		nint num3 = (nint)_cellName;
		object obj5 = _cellName + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v11 (Il2CppClass<System.String>)+D4] (should have been resolved before IL gen)");
		nint num4 = (nint)tMP_Text2;
		object obj6 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S2_v15 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text3 = score;
		int num5 = obj + 8;
		string text2 = ((int*)num5)->ToString();
		nint num6 = (nint)tMP_Text3;
		object obj7 = tMP_Text3 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S2_v21 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}
}
