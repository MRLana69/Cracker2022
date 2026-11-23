using System;
using UnityEngine;

namespace SYBO.Common.Utilities;

[Serializable]
public class ModelInfo(Mesh mesh, Material[] materials)
{
	public Mesh Mesh = mesh;

	public Material[] Materials = materials;
}
