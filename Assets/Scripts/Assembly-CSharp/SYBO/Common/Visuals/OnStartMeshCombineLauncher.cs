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
		//IL_0043: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshCombiner));
		Component component = GameObjectUtil.AddComponentIfMissing(this, typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		MeshCombiner meshCombiner = default;
		_meshCombiner = meshCombiner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		_meshCombiner.CombineInactive();
	}
}
