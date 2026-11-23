using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteCollection
{
	private List<Route> _routes;

	private bool _hasAddedRouteSinceUpdate;

	public List<Route> Routes => _routes;

	public RouteCollection(RouteManager routeManager)
	{
		List<Route> list = default;
		list._002Ector();
		_routes = list;
	}

	public void Add(Route route)
	{
		_routes.Add(route);
		_hasAddedRouteSinceUpdate = true;
	}

	private int SortRoutes(Route aRoute, Route bRoute)
	{
		//IL_01bd: Expected I, but got Obj
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01dd: Expected I, but got Obj
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected I4, but got Unknown
		//IL_00d8: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0189: Expected I, but got Obj
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		nint num = (nint)aRoute;
		object obj = aRoute + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v3 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		nint num2 = (nint)bRoute;
		object obj2 = bRoute + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S1_v7 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		RouteBuilder routeBuilder = default;
		bool isDone = routeBuilder.IsDone;
		int result = 1;
		RouteBuilder routeBuilder2 = default;
		object obj4;
		int num4;
		if (!isDone)
		{
			bool isDone2 = routeBuilder2.IsDone;
			result = -1;
			if (!isDone2)
			{
				int spawnedLeadingEdgeWorldZ = routeBuilder.SpawnedLeadingEdgeWorldZ;
				int spawnedLeadingEdgeWorldZ2 = routeBuilder2.SpawnedLeadingEdgeWorldZ;
				object obj3 = spawnedLeadingEdgeWorldZ - spawnedLeadingEdgeWorldZ2;
				int num3 = 0 - obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
				IConstrainingRouteBuilder constrainingRouteBuilder = default;
				if (constrainingRouteBuilder != null)
				{
					bool flag = routeBuilder2._constrainingBuilders.Contains(constrainingRouteBuilder);
					obj4 = 1;
					num4 = 1;
					if (flag)
					{
						goto IL_0219;
					}
				}
				obj4 = 0;
				num4 = num3;
				goto IL_0219;
			}
		}
		goto IL_01b0;
		IL_01b0:
		return result;
		IL_0219:
		IConstrainingRouteBuilder constrainingRouteBuilder2 = default;
		object obj5;
		if (constrainingRouteBuilder2 != null)
		{
			bool flag2 = routeBuilder._constrainingBuilders.Contains(constrainingRouteBuilder2);
			int num5 = -1;
			if (!flag2)
			{
				num5 = num4;
			}
			obj5 = flag2 & obj4;
			result = num5;
		}
		else
		{
			result = num4;
			obj5 = 0;
		}
		if (obj5 != null)
		{
			string text = default;
			if (routeBuilder != null)
			{
				nint num6 = (nint)routeBuilder;
				object obj6 = routeBuilder + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S2_v17 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string text2 = default;
			if (routeBuilder2 != null)
			{
				nint num7 = (nint)routeBuilder2;
				object obj7 = routeBuilder2 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ S4_v6 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text2 = null;
			}
			string text3 = "Got builders constraining each other: " + text + " AND " + text2;
			result = 0;
		}
		goto IL_01b0;
	}

	public void Remove(Route route)
	{
		//IL_0020: Expected I, but got Obj
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		if (_routes.Contains(route))
		{
			bool flag = _routes.Remove(route);
			nint num = (nint)route;
			object obj = route + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S1_v6 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3;
			object obj4 = obj3 + 120;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S1_v10+134] (should have been resolved before IL gen)");
			GameObject gameObject = route.gameObject;
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public void RemoveAll()
	{
		List<Route> routes = _routes;
		int num = routes._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 > -1)
			{
				Route route = _routes.get_Item(num2);
				Remove(route);
				num = num2;
				continue;
			}
			break;
		}
	}

	public unsafe Route GetRouteContainingPoint(Vector3 point)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected VT, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected VT, but got Unknown
		//IL_00aa: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		int num = default;
		Route result;
		int num3 = default;
		while (true)
		{
			List<Route> routes = _routes;
			bool flag = num >= routes._size;
			result = null;
			if (flag)
			{
				break;
			}
			Route route = _routes.get_Item(num);
			nint num2 = (nint)route;
			object obj3 = route + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S2_v5 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v15+54]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v15+4C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v15+44]");
			_ = 0;
			_ = point.z;
			_ = point.x;
			Bounds bounds = (Bounds)(obj + 24);
			Vector3 point2 = (Vector3)(obj + 8);
			bool flag2 = ((Bounds*)bounds)->Contains(point2);
			result = route;
			if (flag2)
			{
				break;
			}
			num = num3 + 1;
		}
		return result;
	}

	public unsafe Route GetRouteContainingBounds(Bounds bounds)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_033d: Expected Obj, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected VT, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected VT, but got Unknown
		//IL_014b: Expected Ref, but got VT
		//IL_01a3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		object obj4 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		object obj5 = obj + 80;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			Route result;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj7 == null)
				{
					result = null;
					goto IL_0269;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v80+54]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v80+4C]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v80+44]");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+10]");
						_ = 0;
						_ = bounds.m_Center;
						Bounds bounds2 = (Bounds)(obj + 56);
						Bounds bounds3 = (Bounds)(obj + 8);
						bool flag = ((Bounds*)bounds2)->Intersects(bounds3);
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (!flag)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+5C]");
							result = (Route)0;
							goto IL_0269;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 != obj9;
			object obj10 = obj11;
			if (flag2)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 == 1;
			result = null;
			if (!flag3)
			{
				goto IL_0269;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_0269:
			object obj13 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A426");
			return result;
		}
		_ = 0;
		object obj14 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		Route result2 = default;
		return result2;
	}

	public void Update(float characterWorldZ, SyboRandom random)
	{
		//IL_0090: Expected I, but got Obj
		if (~(_hasAddedRouteSinceUpdate ? 1u : 0u) == 0)
		{
			throw new ArgumentException();
		}
		List<Route> routes = _routes;
		int num = routes._size;
		List<Route> routes2;
		while (true)
		{
			routes2 = _routes;
			int num2 = num - 1;
			if (num2 <= -1)
			{
				break;
			}
			Route route = routes2.get_Item(num2);
			route.UpdateRoute(characterWorldZ, random);
			num = num2;
		}
		int num3 = routes2._size;
		RouteBuilder routeBuilder = default;
		while (true)
		{
			int num4 = num3 - 1;
			if (num4 <= -1)
			{
				break;
			}
			Route route2 = _routes.get_Item(num4);
			nint num5 = (nint)route2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S1_v11 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
			bool isDone = routeBuilder.IsDone;
			bool flag = !isDone;
			num3 = num4;
			if (!flag)
			{
				bool isCleanedUp = routeBuilder.IsCleanedUp;
				bool flag2 = !isCleanedUp;
				num3 = num4;
				if (!flag2)
				{
					Route route3 = _routes.get_Item(num4);
					Remove(route3);
					num3 = num4;
				}
			}
		}
	}

	private void DrawBounds(Bounds bounds)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005a: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected VT, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected VT, but got Unknown
		object obj = default;
		RouteCollection routeCollection = (RouteCollection)(obj + -64);
		_ = 4575657221408423936L;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+10]");
		_ = 0;
		_ = 4575657221408423936L;
		_ = bounds.m_Center;
		routeCollection._routes = (List<Route>)1065353216;
		Bounds bounds2 = (Bounds)(routeCollection + 24);
		Color color = (Color)(routeCollection + 8);
		routeCollection.DrawBoundsInternal(bounds2, null, color, 0.25f);
	}

	private void DrawBounds(Bounds bounds, Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got F4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected VT, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected VT, but got Unknown
		object obj = default;
		RouteCollection routeCollection = (RouteCollection)(obj - 48);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+8]");
		_ = 0;
		_ = bounds.m_Center;
		_ = color.b;
		routeCollection._routes = (List<Route>)color.r;
		Bounds bounds2 = (Bounds)(routeCollection + 24);
		Color color2 = (Color)(routeCollection + 8);
		routeCollection.DrawBoundsInternal(bounds2, null, color2, 0.25f);
	}

	private void DrawBounds(Bounds bounds, Color color, float duration)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got F4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected VT, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected VT, but got Unknown
		object obj = default;
		RouteCollection routeCollection = (RouteCollection)(obj - 48);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+8]");
		_ = 0;
		_ = bounds.m_Center;
		_ = color.b;
		routeCollection._routes = (List<Route>)color.r;
		Bounds bounds2 = (Bounds)(routeCollection + 24);
		Color color2 = (Color)(routeCollection + 8);
		routeCollection.DrawBoundsInternal(bounds2, null, color2, duration);
	}

	private void DrawBounds(Bounds bounds, Transform theTransform, Color color, float duration = 0f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got F4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected VT, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected VT, but got Unknown
		object obj = default;
		RouteCollection routeCollection = (RouteCollection)(obj - 48);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+8]");
		_ = 0;
		_ = bounds.m_Center;
		_ = color.b;
		routeCollection._routes = (List<Route>)color.r;
		Bounds bounds2 = (Bounds)(routeCollection + 24);
		Color color2 = (Color)(routeCollection + 8);
		routeCollection.DrawBoundsInternal(bounds2, theTransform, color2, duration);
	}

	private unsafe void DrawBoundsInternal(Bounds bounds, Transform theTransform, Color color, float duration = 0f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected Obj, but got Unknown
		//IL_0add: Expected Obj, but got VT
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected Obj, but got Unknown
		//IL_0b05: Expected Obj, but got VT
		//IL_0b2f: Expected Obj, but got I
		//IL_0b4c: Expected Obj, but got I
		//IL_0b69: Expected Obj, but got I
		//IL_0b86: Expected Obj, but got I
		//IL_0ba3: Expected Obj, but got I
		//IL_0bc0: Expected Obj, but got I
		//IL_0bdd: Expected Obj, but got I
		//IL_0bfa: Expected Obj, but got I
		//IL_0c17: Expected Obj, but got I
		//IL_0c34: Expected Obj, but got I
		//IL_0c51: Expected Obj, but got I
		//IL_0c6e: Expected Obj, but got I
		//IL_0c8b: Expected Obj, but got I
		//IL_0ca8: Expected Obj, but got I
		//IL_0cc5: Expected Obj, but got I
		//IL_0ce2: Expected Obj, but got I
		//IL_0cff: Expected Obj, but got I
		//IL_0d1c: Expected Obj, but got I
		//IL_0d39: Expected Obj, but got I
		//IL_0d56: Expected Obj, but got I
		//IL_0d73: Expected Obj, but got I
		//IL_0d90: Expected Obj, but got I
		//IL_0dad: Expected Obj, but got I
		//IL_0dca: Expected Obj, but got I
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebf: Expected Obj, but got Unknown
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Expected Obj, but got Unknown
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Expected VT, but got Unknown
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected VT, but got Unknown
		//IL_0f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f53: Expected VT, but got Unknown
		//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f76: Expected Obj, but got Unknown
		//IL_0f87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8c: Expected Obj, but got Unknown
		//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Expected VT, but got Unknown
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffc: Expected VT, but got Unknown
		//IL_1005: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Expected VT, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected VT, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected VT, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected VT, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected VT, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected VT, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected VT, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected VT, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected VT, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected VT, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected VT, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected VT, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected VT, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected VT, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected VT, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected VT, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected VT, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected VT, but got Unknown
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected VT, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected VT, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected VT, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected VT, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected VT, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected VT, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected VT, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected VT, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected VT, but got Unknown
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected VT, but got Unknown
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected VT, but got Unknown
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected VT, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected VT, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected VT, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected VT, but got Unknown
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected VT, but got Unknown
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected VT, but got Unknown
		//IL_0a74: Expected native int or pointer, but got VT
		//IL_0a86: Expected native int or pointer, but got VT
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected VT, but got Unknown
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Expected VT, but got Unknown
		//IL_02bf: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_035f: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I
		//IL_038f: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I
		//IL_03bf: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_040f: Expected Obj, but got I
		//IL_041f: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I
		object obj = default;
		Color color2 = (Color)(obj - 1232);
		object obj2 = color2 + 1216;
		obj2 = bounds.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+14]");
		_ = 0;
		object obj3 = color2 + 1216;
		obj3 = bounds.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		object obj4 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		object obj5 = num2 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		object obj6 = num3 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		object obj7 = num4 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		object obj8 = num5 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		object obj9 = num6 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		object obj10 = num7 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		object obj11 = num8 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		object obj12 = num9 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		object obj13 = num10 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		object obj14 = num11 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		object obj15 = num12 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		object obj16 = num13 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		object obj17 = num14 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		object obj18 = num15 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		object obj19 = num16 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		object obj20 = num17 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		object obj21 = num18 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		object obj22 = num19 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		object obj23 = num20 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		object obj24 = num21 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
		object obj25 = num22 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
		object obj26 = num23 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
		object obj27 = num24 + 0;
		bool flag = theTransform != null;
		bool flag2 = !flag;
		object obj28 = obj27;
		object obj29 = obj25;
		object obj30 = obj26;
		object obj31 = obj22;
		object obj32 = obj23;
		object obj33 = obj24;
		object obj34 = obj19;
		object obj35 = obj20;
		object obj36 = obj21;
		object obj37 = obj16;
		object obj38 = obj17;
		object obj39 = obj18;
		object obj40 = obj13;
		object obj41 = obj14;
		object obj42 = obj15;
		object obj43 = obj10;
		object obj44 = obj11;
		object obj45 = obj12;
		object obj46 = obj7;
		object obj47 = obj8;
		object obj48 = obj9;
		object obj49 = obj4;
		object obj50 = obj5;
		object obj51 = obj6;
		if (!flag2)
		{
			object obj52 = color2 + 1208;
			obj52 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4B0]");
			_ = 0;
			Vector3 position = (Vector3)(color2 + 688);
			Vector3 vector = theTransform.TransformPoint(position);
			object obj53 = color2 + 1192;
			obj53 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4A0]");
			_ = 0;
			Vector3 position2 = (Vector3)(color2 + 672);
			Vector3 vector2 = theTransform.TransformPoint(position2);
			object obj54 = color2 + 1176;
			obj54 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+490]");
			_ = 0;
			Vector3 position3 = (Vector3)(color2 + 656);
			Vector3 vector3 = theTransform.TransformPoint(position3);
			object obj55 = color2 + 1160;
			obj55 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+480]");
			_ = 0;
			Vector3 position4 = (Vector3)(color2 + 640);
			Vector3 vector4 = theTransform.TransformPoint(position4);
			object obj56 = color2 + 1144;
			obj56 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+470]");
			_ = 0;
			Vector3 position5 = (Vector3)(color2 + 624);
			Vector3 vector5 = theTransform.TransformPoint(position5);
			object obj57 = color2 + 1128;
			obj57 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+460]");
			_ = 0;
			Vector3 position6 = (Vector3)(color2 + 608);
			Vector3 vector6 = theTransform.TransformPoint(position6);
			object obj58 = color2 + 1112;
			obj58 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+450]");
			_ = 0;
			Vector3 position7 = (Vector3)(color2 + 592);
			Vector3 vector7 = theTransform.TransformPoint(position7);
			object obj59 = color2 + 1096;
			obj59 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+440]");
			_ = 0;
			Vector3 position8 = (Vector3)(color2 + 576);
			Vector3 vector8 = theTransform.TransformPoint(position8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
			obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
			obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
			obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
			obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
			obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
			obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
			obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C0]");
			obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C4]");
			obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+4C8]");
			obj51 = 0;
		}
		object obj60 = color2 + 1080;
		obj60 = obj51;
		object obj61 = color2 + 1064;
		obj61 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+430]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+420]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start = (Vector3)(color2 + 560);
		Vector3 end = (Vector3)(color2 + 544);
		Color color3 = color2 + 528;
		Debug.DrawLine(start, end, color3, duration);
		object obj62 = color2 + 1048;
		obj62 = obj48;
		object obj63 = color2 + 1032;
		obj63 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+410]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+400]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start2 = (Vector3)(color2 + 512);
		Vector3 end2 = (Vector3)(color2 + 496);
		Color color4 = color2 + 480;
		Debug.DrawLine(start2, end2, color4, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3E0]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start3 = (Vector3)(color2 + 464);
		Vector3 end3 = (Vector3)(color2 + 448);
		Color color5 = color2 + 432;
		Debug.DrawLine(start3, end3, color5, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3C0]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start4 = (Vector3)(color2 + 416);
		Vector3 end4 = (Vector3)(color2 + 400);
		Color color6 = color2 + 384;
		Debug.DrawLine(start4, end4, color6, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+3A0]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start5 = (Vector3)(color2 + 368);
		Vector3 end5 = (Vector3)(color2 + 352);
		Color color7 = color2 + 336;
		Debug.DrawLine(start5, end5, color7, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+398]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+388]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+390]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+380]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start6 = (Vector3)(color2 + 320);
		Vector3 end6 = (Vector3)(color2 + 304);
		Color color8 = color2 + 288;
		Debug.DrawLine(start6, end6, color8, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+378]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+368]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+370]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+360]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start7 = (Vector3)(color2 + 272);
		Vector3 end7 = (Vector3)(color2 + 256);
		Color color9 = color2 + 240;
		Debug.DrawLine(start7, end7, color9, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+348]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+350]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+340]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start8 = (Vector3)(color2 + 224);
		Vector3 end8 = (Vector3)(color2 + 208);
		Color color10 = color2 + 192;
		Debug.DrawLine(start8, end8, color10, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+338]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+328]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+330]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+320]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start9 = (Vector3)(color2 + 176);
		Vector3 end9 = (Vector3)(color2 + 160);
		Color color11 = color2 + 144;
		Debug.DrawLine(start9, end9, color11, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+318]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+308]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+310]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+300]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start10 = (Vector3)(color2 + 128);
		Vector3 end10 = (Vector3)(color2 + 112);
		Color color12 = color2 + 96;
		Debug.DrawLine(start10, end10, color12, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2E0]");
		_ = 0;
		_ = color.b;
		_ = color.r;
		Vector3 start11 = (Vector3)(color2 + 80);
		Vector3 end11 = (Vector3)(color2 - -64);
		Color color13 = color2 + 48;
		Debug.DrawLine(start11, end11, color13, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2C0]");
		_ = 0;
		((Color*)(nint)color2)->b = color.b;
		((Color*)(nint)color2)->r = color.r;
		Vector3 start12 = (Vector3)(color2 + 32);
		Vector3 end12 = (Vector3)(color2 + 16);
		Debug.DrawLine(start12, end12, color2, duration);
	}
}
