using Cpp2ILInjected;
using UnityEngine;

public class UIDragDropContainer : MonoBehaviour
{
	public Transform reparentTarget;

	protected virtual void Start()
	{
		CancelInvoke();
	}

	public UIDragDropContainer()
	{
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (reparentTarget != null)
		{
			object obj2 = this + 12;
			GameObject gameObject = base.gameObject;
			obj2 = gameObject;
		}
	}
}
