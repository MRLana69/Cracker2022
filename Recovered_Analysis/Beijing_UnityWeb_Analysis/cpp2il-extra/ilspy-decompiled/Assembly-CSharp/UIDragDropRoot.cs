using Cpp2ILInjected;
using UnityEngine;

public class UIDragDropRoot : MonoBehaviour
{
	public static Transform root;

	private void OnEnable()
	{
		_ = 1f;
		_ = 1;
		CancelInvoke();
	}

	private void OnDisable()
	{
		GameObject gameObject = base.gameObject;
		root = (Transform)(object)gameObject;
	}

	public UIDragDropRoot()
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = base.gameObject;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v8 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (root != gameObject)
		{
			root = null;
		}
	}
}
