using Cpp2ILInjected;
using UnityEngine;

public class CurvePointTangent : MonoBehaviour
{
	public void OnDrawGizmosSelected()
	{
		_ = 1;
		_ = 50f;
		CancelInvoke();
	}

	public CurvePointTangent()
	{
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0084: Expected Obj, but got VT
		GameObject gameObject = base.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
		{
			((CurvePoint)((Component)((Transform)(object)base.gameObject).parentInternal).GetComponentInChildren<T>())._002Ector();
		}
	}
}
