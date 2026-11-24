using System;
using Cpp2ILInjected;
using UnityEngine;

public class KUIScrollView : UIScrollView
{
	public ScrollView scrollView;

	public override Bounds bounds
	{
		get
		{
			//IL_0119: Expected I, but got Obj
			//IL_012f: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I4
			//IL_0086: Expected I, but got Obj
			//IL_009c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005d: Expected Obj, but got I4
			//IL_006e: Expected VT, but got Obj
			//IL_006e: Expected Obj, but got VT
			//IL_00c7: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Bounds bounds = default;
			if (((ComputeShader)iOSDragEmulation).FindKernel(null) != 0)
			{
				GameObject gameObject = ((Component)iOSDragEmulation).gameObject;
				((Transform)bounds).localPosition = (Vector3)gameObject;
			}
			else
			{
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 back = Vector3.back;
			}
			return bounds;
		}
	}

	protected override bool shouldMove
	{
		get
		{
			//IL_000f: Expected Obj, but got I4
			//IL_0030: Expected I4, but got Obj
			object obj = movement;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			return (byte)(int)("CurvePoint (" + text + ")") != 0;
		}
	}

	public override void MoveRelative(Vector3 relative)
	{
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got VT
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [relative @ L1 (UnityEngine.Vector3)+CC]");
		if ((UnityEngine.Object)0 != null)
		{
			Vector3 vector = ((UIScrollView)relative).currentMomentum;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [relative @ L1 (UnityEngine.Vector3)+CC]");
		object obj2 = (nint)0 + (nint)76;
		KUIScrollView kUIScrollView = (KUIScrollView)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v11+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v11+10]");
		dragEffect = DragEffect.None;
	}

	public KUIScrollView()
	{
		CancelInvoke();
	}
}
