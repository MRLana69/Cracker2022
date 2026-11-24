using Cpp2ILInjected;
using UnityEngine;

public class UIDynamicContent : MonoBehaviour
{
	public GameObject[] PanelElements;

	private void Start()
	{
		CancelInvoke();
	}

	public void InitElements()
	{
		this._002Ector();
	}

	public UIDynamicContent()
	{
		//IL_00d2: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00e4: Expected I4, but got Obj
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		object obj = 0;
		while (true)
		{
			GameObject[] panelElements = PanelElements;
			if ((nint)obj >= panelElements.Length)
			{
				break;
			}
			string go = tag;
			object obj2 = PanelElements + 16;
			object obj3 = obj << 2;
			object obj4 = obj2 + obj3;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v6 (Il2CppClass<NGUITools>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v11 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)obj4 != 0);
			object obj6 = obj + 1;
			obj = obj6;
		}
	}
}
