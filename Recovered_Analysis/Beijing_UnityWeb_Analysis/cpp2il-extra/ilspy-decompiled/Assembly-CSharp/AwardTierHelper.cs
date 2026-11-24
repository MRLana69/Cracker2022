using Cpp2ILInjected;
using UnityEngine;

public class AwardTierHelper : MonoBehaviour
{
	private GameObject inactiveElementsParent;

	private GameObject activeElement;

	private GameObject inactiveHighlightElement;

	public void TierComplete(bool complete)
	{
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_022b: Expected I, but got Obj
		//IL_0287: Expected I, but got Obj
		//IL_029d: Expected Obj, but got I
		//IL_018e: Expected I, but got Obj
		//IL_02c8: Expected I, but got Obj
		if (complete)
		{
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v24 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v31 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.UpdateWidgetCollider(inactiveElementsParent);
			NGUITools.UpdateWidgetCollider(activeElement);
			return;
		}
		Collider component = inactiveElementsParent.GetComponent<Collider>();
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			Collider component2 = inactiveElementsParent.GetComponent<Collider>();
			nint num5 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Object.DestroyImmediate(component2);
		}
		Collider component3 = activeElement.GetComponent<Collider>();
		nint num7 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component3).FindKernel((string)null) == 0)
		{
			return;
		}
		Collider component4 = activeElement.GetComponent<Collider>();
		nint num9 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Object.DestroyImmediate(component4);
	}

	public void TierNextComplete()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		CancelInvoke();
	}

	public AwardTierHelper()
	{
		//IL_002d: Expected Obj, but got I4
		inactiveElementsParent.tag = null;
		activeElement.tag = null;
		inactiveHighlightElement.tag = (string)1;
	}
}
