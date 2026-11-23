using Cpp2ILInjected;
using TMPro;
using UnityEngine;

namespace UI.Popups.AgeRestrictionPopupInternal;

public class ListElementHelper : MonoBehaviour
{
	private TMP_Text _label;

	public int id;

	private Color _defaultColor;

	private Color _selectedColor;

	private ListContentElement _listContentElement;

	public ListContentElement listContentElement => _listContentElement;

	public void InitCell(ListContentElement lce)
	{
		//IL_0030: Expected I, but got Obj
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		_listContentElement = lce;
		ListContentElement listContentElement = _listContentElement;
		listContentElement.helper__BackingField = this;
		TMP_Text label = _label;
		nint num = (nint)label;
		object obj = label + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S2_v2 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		id = lce.id;
	}

	public void OnSelect(bool select)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = this + 36;
		object obj4 = this + 20;
		if (!select)
		{
			obj3 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v4+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v4+8]");
		_ = 0;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
	}
}
