using Cpp2ILInjected;
using UnityEngine;

public class AnchorWidthResizerHelper : MonoBehaviour
{
	private UIWidget _myWidget;

	private UIWidget[] _allWidgets;

	private int _offset;

	private void Update()
	{
		CancelInvoke();
	}

	private void Reset()
	{
		//IL_016f: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected I4, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_myWidget != null)
		{
			return;
		}
		object obj2 = -1;
		object obj3 = 0;
		while (true)
		{
			UIWidget[] allWidgets = _allWidgets;
			if ((nint)obj3 >= allWidgets.Length)
			{
				break;
			}
			object obj4 = _allWidgets + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v23+64]");
			if (0 > (nint)obj2)
			{
				object obj8 = _allWidgets + 16;
				object obj9 = obj3 << 2;
				object obj10 = obj8 + obj9;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v33+64]");
				obj2 = 0;
			}
			object obj12 = obj3 + 1;
			obj3 = obj12;
		}
		if ((nint)obj2 != -1)
		{
			int height = _offset + obj2;
			_myWidget.height = height;
		}
	}

	public AnchorWidthResizerHelper()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		UIWidget component = GetComponent<UIWidget>();
		obj = component;
	}
}
