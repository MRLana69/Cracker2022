using Cpp2ILInjected;
using SYBO.Subway.Routes.Builders;

namespace SYBO.Subway.Routes;

public class DefaultRoute : Route
{
	private DefaultRouteBuilder _defaultRouteBuilder;

	public override RouteBuilder Builder
	{
		get
		{
			//IL_0030: Expected Obj, but got I
			//IL_004b: Expected Obj, but got I
			//IL_005b: Expected Obj, but got I
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			//IL_00a9: Expected Obj, but got I
			//IL_00b9: Expected Obj, but got I
			//IL_00c9: Expected Obj, but got I
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected Obj, but got Unknown
			//IL_012e: Expected Obj, but got I
			RouteManager routeManager = _routeManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.DefaultRoute)+100]");
			object obj = (nint)0 + (nint)1;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v5 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v6+60]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v5 (should have been resolved before IL gen)");
			RouteManager routeManager2 = _routeManager;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v7 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v8+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S3_v9+8]");
			object obj9 = 0;
			object obj10 = obj9 & 0x3FFF;
			object obj11 = obj10 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S4_v6 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.DefaultRoute)+100]");
			object obj12 = default;
			if (0 >= (nint)obj12)
			{
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v8+10]");
			return (RouteBuilder)0;
		}
	}

	public override RouteType Type
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (RouteType)_defaultRouteBuilder;
		}
	}

	public DefaultRoute()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
