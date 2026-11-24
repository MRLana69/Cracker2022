using UnityEngine;

namespace SYBO.Common.Utilities;

public class ObjectModelInfo
{
	public MeshRenderer MeshRenderer;

	public MeshFilter MeshFilter;

	public ObjectModelInfo(MeshRenderer meshRenderer, MeshFilter meshFilter)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = meshRenderer;
		object obj2 = this + 12;
		obj2 = meshFilter;
	}
}
