using System;
using Cpp2ILInjected;
using SYBO.Subway.Routes.Builders;

namespace SYBO.Subway.Routes;

[Serializable]
public class DeterministicRouteBuilder : DefaultRouteBuilder
{
	private int _midSectionIndex;

	protected override RouteSection GetNextSectionPrefab()
	{
		//IL_0055: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		WeightRandomizedRouteSectionContainter midSectionPrefabs = _midSectionPrefabs;
		int midSectionIndex = _midSectionIndex + 1;
		_midSectionIndex = midSectionIndex;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v3 (Il2CppRgctx<SYBO.Subway.Routes.WeightRandomizedPrefabContainter`2<SYBO.Subway.Routes.WeightedRouteSection, SYBO.Subway.Routes.RouteSection>>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S3_v4+4] (should have been resolved before IL gen)");
		WeightRandomizedRouteSectionContainter midSectionPrefabs2 = _midSectionPrefabs;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S3_v8 (Il2CppRgctx<SYBO.Subway.Routes.WeightRandomizedPrefabContainter`2<SYBO.Subway.Routes.WeightedRouteSection, SYBO.Subway.Routes.RouteSection>>)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S3_v9+4] (should have been resolved before IL gen)");
		object obj3 = default;
		if (_midSectionIndex >= (nint)obj3)
		{
			_midSectionIndex = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v10+10]");
		return (RouteSection)0;
	}

	protected override bool CanSpawnSection(RouteSection section)
	{
		return true;
	}
}
