using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class OnStartMeshCombineLauncher : MonoBehaviour
{
	private MeshCombiner _meshCombiner;

	private void Start()
	{
		_ = 1f;
		CancelInvoke();
	}

	public unsafe OnStartMeshCombineLauncher()
	{
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v23 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(MeshCombiner);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		object obj2 = this + 12;
		Type type = Type.internal_from_handle((IntPtr)num3);
		Component component = GameObjectUtil.AddComponentIfMissing((GameObject)(object)this, type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj3 = default;
		obj2 = obj3;
		_meshCombiner.Combine();
	}
}
