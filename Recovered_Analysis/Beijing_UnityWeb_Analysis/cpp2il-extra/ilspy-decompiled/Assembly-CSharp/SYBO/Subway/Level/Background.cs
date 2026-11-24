using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

[Serializable]
public class Background
{
	public float SkylineLeftLimit;

	public float SkylineRightLimit;

	public Shader LayerCommonMaterialShader;

	public float LayerSpacing;

	public BackgroundLayer[] Layers;

	public float GradientTop;

	public float GradientBottom;

	public Color GradientTopColor;

	public Color GradientBottomColor;

	public BackgroundCulling[] Culling;

	public Color BackgroundCullingColor;

	public Background()
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got F4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		object obj = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		object obj3 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<BackgroundObject> list = default;
		list._002Ector();
		object obj5 = this + 68;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<BackgroundObject> list2 = default;
		list2._002Ector();
		object obj6 = this + 72;
		obj6 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<BackgroundObject> list3 = default;
		list3._002Ector();
		object obj7 = this + 76;
		obj7 = list3;
		Layers = (BackgroundLayer[])1f;
		Color black = Color.black;
		object obj9 = default;
		object obj8 = obj9 + 16;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj10 = this + 52;
		obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v30+8]");
		_ = 0;
	}
}
