using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.UI;
using UnityEngine;

namespace UI.Popups.AgeRestrictionPopupInternal;

public class ListContentElementAdapter : ListAdapter<ListContentElement>
{
	private readonly GameObject _ageCellPrefab;

	private readonly ScrollView _scrollView;

	private readonly CenterOnChild _centerOnChild;

	private readonly string _initialContent;

	public ListContentElementAdapter(List<ListContentElement> list, GameObject ageCell, ScrollView scrollView, CenterOnChild centerOnChild, string initialContent)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v4 (Il2CppClass<Il2CppRgctx<Kiloo.Common.UI.ListAdapter`1<UI.Popups.AgeRestrictionPopupInternal.ListContentElement>>>)+4] (should have been resolved before IL gen)");
		_ageCellPrefab = ageCell;
		_scrollView = scrollView;
		_centerOnChild = centerOnChild;
		_initialContent = initialContent;
	}

	public unsafe override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002f: Expected F4, but got VT
		//IL_002a: Expected native int or pointer, but got VT
		//IL_0099: Expected I, but got Obj
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		Container container2 = default;
		Container container3 = default;
		if (container2 == null)
		{
			ScrollView scrollView = _scrollView;
			((Vector2*)(nint)vector)->x = (float)scrollView.cellSize;
			_ = scrollView.cellSize;
			container3._002Ector(_ageCellPrefab, vector);
			ListElementHelper component = container3.model.GetComponent<ListElementHelper>();
			_ = _scrollView;
			_ = _centerOnChild;
			_ = _initialContent;
			object tag = default;
			container3.tag = tag;
		}
		if (!isMeasurePass)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S2_v4 (Il2CppClass<UI.Popups.AgeRestrictionPopupInternal.ListContentElementAdapter>)+104] (should have been resolved before IL gen)");
		}
		return container3;
	}
}
