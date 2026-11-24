using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Routes;

[Serializable]
public class DeterministicRouteBuilder : DefaultRouteBuilder
{
	private int _midSectionIndex;

	protected override RouteSection GetNextSectionPrefab()
	{
		return _fallbackSection;
	}

	protected override bool CanSpawnSection(RouteSection section)
	{
		return (nint)section == 32;
	}

	public DeterministicRouteBuilder()
	{
		//IL_005d: Expected Obj, but got F4
		//IL_0068: Expected Obj, but got F4
		//IL_0073: Expected I4, but got F4
		//IL_0089: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_009f: Expected I4, but got F4
		//IL_00aa: Expected I4, but got F4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got F4
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		OnAddedSection = (Action<Route, RouteSection, float>)95f;
		OnRouteChunkSpawned = (Action<Route, RouteChunk, float>)800f;
		_routeHeight = (RouteHeight)60;
		((RouteBuilder)this)._midSectionsCountTarget = 5;
		_startSectionPrefabs = (List<TransitionSectionInfo>)1;
		_midSectionPrefabs = (WeightRandomizedRouteSectionContainter)1;
		_length = 0;
		_secionSpawnMode = SectionSpawnMode.None;
		object obj = this - -64;
		obj = 0.05f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj4 = default;
		object obj3 = obj4 + 12;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 68;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v25+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724B");
	}
}
