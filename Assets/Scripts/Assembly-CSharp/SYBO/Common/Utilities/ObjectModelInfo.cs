using UnityEngine;

namespace SYBO.Common.Utilities;

public class ObjectModelInfo(MeshRenderer meshRenderer, MeshFilter meshFilter)
{
	public MeshRenderer MeshRenderer = meshRenderer;

	public MeshFilter MeshFilter = meshFilter;
}
