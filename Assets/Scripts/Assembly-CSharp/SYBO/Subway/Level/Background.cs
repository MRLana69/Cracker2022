using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

[Serializable]
public class Background
{
	public float SkylineLeftLimit = -350f;

	public float SkylineRightLimit;

	public Shader LayerCommonMaterialShader;

	public float LayerSpacing = 5f;

	public BackgroundLayer[] Layers;

	public float GradientTop;

	public float GradientBottom;

	public Color GradientTopColor;

	public Color GradientBottomColor;

	public Background()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		BackgroundLayer[] layers = default;
		Layers = layers;
		GradientTop = 1f;
	}
}
