using Cpp2ILInjected;
using UnityEngine;

public class UIDynamicContent : MonoBehaviour
{
	public GameObject[] PanelElements;

	private void Start()
	{
		InitElements();
	}

	public void InitElements()
	{
		//IL_006f: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			GameObject[] panelElements = PanelElements;
			if (panelElements.Length > (nint)obj)
			{
				GameObject parent = base.gameObject;
				object obj2 = obj << 2;
				object obj3 = (object)PanelElements + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15+10]");
				GameObject gameObject = NGUITools.AddChild(parent, (GameObject)0);
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			break;
		}
	}
}
