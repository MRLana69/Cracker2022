using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Visuals;
using UnityEngine;

namespace SYBO.Common.Utilities;

public struct GameObjectPositionWrapper
{
	public GameObject GameObject;

	public Vector3 Position;

	public bool ParentIsSelector;

	public unsafe GameObjectPositionWrapper(GameObject gameObject, bool parentIsSelector = false)
	{
		//IL_0055: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		ref Action<ModelInfo> reference = ref *(Action<ModelInfo>*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.GameObjectPositionWrapper)+1C]");
		bool flag = ((Dictionary<CombineableMeshGroup, Action<ModelInfo>>)0).TryGetValue((CombineableMeshGroup)(object)gameObject, out reference);
		object obj = (flag ? 1 : 0) ^ 1;
		bool flag2 = reference == null;
		object obj2 = flag2 | obj;
		if (obj2 == null)
		{
			Delegate obj3 = ((Delegate)reference).RemoveImpl((Delegate)parentIsSelector);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj4 = default;
			reference = ref *(Action<ModelInfo>*)obj4;
		}
	}

	public unsafe GameObjectPositionWrapper(Component component, bool parentIsSelector = false)
	{
		//IL_000b: Expected Obj, but got Ref
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9541");
	}
}
