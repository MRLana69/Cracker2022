using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class Randomizer : Selector
{
	public unsafe override void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected VT, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0144: Expected I4, but got Obj
		//IL_013f: Expected native int or pointer, but got VT
		//IL_0077: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		object obj = default;
		BackgroundCulling.CullingBlock cullingBlock = (BackgroundCulling.CullingBlock)(obj + 16);
		object obj2 = obj + 8;
		obj2 = 0;
		Action<List<Selector>> performingSelection = base.PerformingSelection;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (System.Action`1<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+C]");
		if ((nint)0 != 0)
		{
			Action<List<Selector>> performingSelection2 = base.PerformingSelection;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v8 (System.Action`1<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v8 (System.Action`1<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v20+10]");
				object obj4 = 0;
			}
			else
			{
				object obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v10+14]");
			obj2 = 0;
			Action<List<Selector>> performingSelection3 = base.PerformingSelection;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (System.Action`1<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+8]");
			LinkedListNode<BackgroundCulling.CullingBlock> linkedListNode;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (System.Action`1<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+10]");
				linkedListNode = (LinkedListNode<BackgroundCulling.CullingBlock>)0;
			}
			else
			{
				linkedListNode = null;
			}
			obj = obj2;
			((BackgroundCulling.CullingBlock*)(nint)cullingBlock)->CullingStartGamePositionZ = (int)obj;
			linkedListNode.Value = cullingBlock;
		}
	}

	public Randomizer()
	{
		CancelInvoke();
	}
}
