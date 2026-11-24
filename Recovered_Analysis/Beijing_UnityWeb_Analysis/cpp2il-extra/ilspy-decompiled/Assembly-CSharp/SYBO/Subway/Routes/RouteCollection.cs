using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Utility;
using SYBO.Common.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Utilities;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteCollection
{
	private List<Route> _routes;

	private bool _hasAddedRouteSinceUpdate;

	public List<Route> Routes => (List<Route>)(object)((Component)this).GetComponentInParent<RouteChunk>();

	public RouteCollection(RouteManager routeManager)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = routeManager;
	}

	public void Add(Route route)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 8;
		object obj2 = default;
		obj = obj2;
	}

	private int SortRoutes(Route aRoute, Route bRoute)
	{
		//IL_02f2: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I
		//IL_000e: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_01b5: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_02a3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+A8]");
		int result;
		if (Enumerable.Count((IEnumerable<RouteEnvironmentModelAssets>)0) != 0)
		{
			object obj2 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+20]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v4+A8]");
				object obj4 = 0;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v5+C]");
				bool flag = (nint)obj5 >= 0;
				result = 0;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+20]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v15+A8]");
				object obj7 = (nint)0 + (nint)16;
				object obj8 = obj2 << 2;
				object obj9 = obj7 + obj8;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+8]");
				if (0 != (nint)aRoute)
				{
					object obj11 = obj2 + 1;
					obj2 = obj11;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+20]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v23+A8]");
				object obj13 = (nint)0 + (nint)16;
				object obj14 = obj2 << 2;
				object obj15 = obj13 + obj14;
				object obj16 = obj15;
				if (obj15 != null)
				{
					object obj17 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v27+C]");
						object obj18 = 0;
						object obj19 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S2_v12+C]");
						bool flag2 = (nint)obj19 >= 0;
						result = 0;
						if (flag2)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v27+C]");
						object obj20 = (nint)0 + (nint)16;
						object obj21 = obj17 << 2;
						object obj22 = obj20 + obj21;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v37+C]");
						object obj24 = 0;
						nint num = (nint)typeof(EnvironmentKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v40 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
						object obj25 = (nint)0 & (nint)0x200;
						if (obj25 != null)
						{
							nint num2 = (nint)typeof(EnvironmentKind);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v65 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v38+8]");
						bool flag3;
						if ((IntPtr)0 == ((UnityEngine.Object)bRoute).m_CachedPtr)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v38+C]");
							flag3 = 0 == (nint)bRoute.OnCharacterEntryStarted;
						}
						else
						{
							flag3 = false;
						}
						if (!flag3)
						{
							object obj26 = obj17 + 1;
							obj17 = obj26;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v27+C]");
						object obj27 = (nint)0 + (nint)16;
						object obj28 = obj17 << 2;
						object obj29 = obj27 + obj28;
						object obj30 = obj29;
						if (obj29 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v53+10]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v57+C]");
							result = 0;
						}
						else
						{
							result = 0;
						}
						break;
					}
				}
				else
				{
					result = 0;
				}
				break;
			}
		}
		else
		{
			result = 0;
		}
		return result;
	}

	public void Remove(Route route)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		_hasAddedRouteSinceUpdate = true;
	}

	public unsafe void RemoveAll()
	{
		//IL_017e: Expected I, but got Obj
		//IL_0194: Expected Obj, but got I
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected VT, but got Unknown
		//IL_01e3: Expected F4, but got Obj
		//IL_01de: Expected native int or pointer, but got VT
		//IL_01f8: Expected F4, but got I
		//IL_01f3: Expected native int or pointer, but got VT
		//IL_0217: Expected F4, but got Obj
		//IL_0212: Expected native int or pointer, but got VT
		//IL_022c: Expected F4, but got I
		//IL_0227: Expected native int or pointer, but got VT
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got F4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v54 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 down = Vector3.down;
		Vector3 vector = (Vector3)(obj3 + 24);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = vector / -1000f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj4 = this + 12;
		obj4 = vector.x;
		_ = vector.z;
		_ = 1;
		_ = 2;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<TrackObject> list = default;
		list._002Ector();
		object obj5 = this + 44;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<TrackObject> list2 = default;
		list2._002Ector();
		object obj6 = this + 48;
		obj6 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Selector> list3 = default;
		list3._002Ector();
		object obj7 = this + 60;
		obj7 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Selector> list4 = default;
		list4._002Ector();
		object obj8 = this - -64;
		obj8 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S3_v4+60]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v130 @ S4_v4 (should have been resolved before IL gen)");
		object obj14 = this + 112;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public unsafe Route GetRouteContainingPoint(Vector3 gamePosition)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected VT, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected VT, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_007d: Expected VT, but got Obj
		//IL_0097: Expected VT, but got I
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_01ce: Expected F4, but got Obj
		//IL_01c9: Expected native int or pointer, but got VT
		//IL_01e0: Expected F4, but got I
		//IL_01db: Expected native int or pointer, but got VT
		//IL_01ed: Expected F4, but got Obj
		//IL_01e8: Expected native int or pointer, but got VT
		//IL_01ff: Expected F4, but got I
		//IL_01fa: Expected native int or pointer, but got VT
		//IL_021d: Expected F4, but got Obj
		//IL_0218: Expected native int or pointer, but got VT
		//IL_0232: Expected F4, but got I
		//IL_022d: Expected native int or pointer, but got VT
		//IL_023b: Expected Obj, but got VT
		//IL_0247: Invalid comparison between I4 and VT
		//IL_0262: Expected Obj, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_0278: Invalid comparison between Obj and VT
		//IL_028b: Expected Obj, but got I4
		//IL_00e6: Expected I, but got Obj
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		Vector3 vector2 = (Vector3)(obj + 36);
		Transform transform = (Transform)(obj + 24);
		Transform transform2 = (Transform)(obj + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+34]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+34]");
			object obj3 = (nint)0 + (nint)12;
			object obj4 = default;
			object obj7;
			object obj12 = default;
			while (true)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+34]");
				object obj5 = (nint)0 + (nint)16;
				object obj6 = obj4 << 2;
				obj7 = obj5 + obj6;
				Component component = (Component)obj7;
				GameObject gameObject = ((Component)obj7).gameObject;
				transform.position = (Vector3)gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+58]");
				transform2.position = (Vector3)0;
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v49 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)transform2;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
				((Vector3*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector)->z = 0f;
				bool flag = RouteChunk.HasParentRouteChunk((Transform)vector);
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)flag) > System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref gamePosition);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v15 (UnityEngine.Component)+14]");
				object obj9 = (nint)0 + (nint)(flag ? 1 : 0);
				object obj10 = obj9 - 1;
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref gamePosition);
				object obj11 = flag2 | flag3;
				if (obj11 == null)
				{
					break;
				}
				obj4 = obj12 + 1;
			}
			return (Route)obj7;
		}
		return null;
	}

	public Route GetRouteContainingBounds(Bounds bounds)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		_ = 0;
		int num = default;
		Route result;
		object obj5 = default;
		object obj6 = default;
		int num2 = default;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj4 = obj5 + 72;
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v15+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v15+10]");
			_ = 0;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			obj = bounds.m_Center;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4BE");
			if (obj6 != null)
			{
				result = route;
				break;
			}
			num = num2 + 1;
		}
		return result;
	}

	public void Update(float characterGamePositionZ, SyboRandom random)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
	}

	private void DrawBounds(Bounds bounds)
	{
		//IL_00d8: Expected Obj, but got VT
		//IL_0031: Expected Obj, but got VT
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		if (!_routes.Contains((Route)bounds))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		string tag = ((Component)bounds).tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
	}

	private void DrawBounds(Bounds bounds, Color color)
	{
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_0164: Invalid comparison between VT and I4
		//IL_00ae: Expected I, but got Obj
		//IL_01d1: Expected Obj, but got VT
		//IL_01e3: Expected Obj, but got I
		//IL_001e: Expected I, but got Obj
		//IL_00ca: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_003a: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0120: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		nint num = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj != null;
		RouteCollection routeCollection;
		if (color == (Color)(object)1)
		{
			bool flag2 = !flag;
			nint num2 = (nint)typeof(EnvironmentBaseKind);
			if (!flag2)
			{
				nint num3 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v27 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
				bool flag3 = (nint)0 == 0;
				bool flag4 = !flag3;
				num2 = (nint)typeof(EnvironmentBaseKind);
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num2 = (nint)typeof(EnvironmentBaseKind);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ L1_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			object obj2 = (nint)0 + (nint)132;
			routeCollection = (RouteCollection)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v13+8]");
			_routes = (List<Route>)0;
			return;
		}
		bool flag5 = !flag;
		nint num4 = (nint)typeof(EnvironmentBaseKind);
		if (!flag5)
		{
			nint num5 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v17 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
			bool flag6 = (nint)0 == 0;
			bool flag7 = !flag6;
			num4 = (nint)typeof(EnvironmentBaseKind);
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(EnvironmentBaseKind);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ L1_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num6 = 0;
		routeCollection = (RouteCollection)EnvironmentBaseKind.None;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v7 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
		_routes = (List<Route>)0;
	}

	private unsafe void DrawBounds(Bounds bounds, Color color, float duration)
	{
		//IL_0317: Expected I4, but got VT
		//IL_0317: Expected Obj, but got VT
		//IL_0317: Expected Obj, but got I
		//IL_0329: Expected I, but got Obj
		//IL_033f: Expected Obj, but got I
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected VT, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_0382: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I4
		//IL_00ae: Expected I, but got Obj
		//IL_0265: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_03fd: Expected Obj, but got I
		//IL_03fd: Expected Obj, but got I4
		//IL_040b: Expected I, but got Obj
		//IL_0421: Expected Obj, but got I
		//IL_0454: Expected F4, but got Obj
		//IL_044f: Expected native int or pointer, but got VT
		//IL_0469: Expected F4, but got I
		//IL_0464: Expected native int or pointer, but got VT
		//IL_0487: Expected F4, but got Obj
		//IL_0482: Expected native int or pointer, but got VT
		//IL_049c: Expected F4, but got I
		//IL_0497: Expected native int or pointer, but got VT
		//IL_04a5: Expected Obj, but got VT
		//IL_02be: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+64]");
		int value = ((OnlineSettings)0).GetValue((string)bounds, (int)color);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Vector3 vector = (Vector3)(obj2 + 24);
		object obj3 = obj2 + 12;
		if ((UnityEngine.Object)value != null)
		{
			return;
		}
		PlaceholderPrefab component = ((Component)value).GetComponent<PlaceholderPrefab>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v63 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = ((ComputeShader)(object)component).FindKernel((string)null);
		object obj5 = this - -64;
		object obj6 = obj5;
		if (num5 != 0)
		{
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S3_v16 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S3_v17+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S3_v18+38]");
			object obj9 = 0;
			object obj10 = obj9 & 0x1FFF;
			object obj11 = obj10 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S4_v14 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+30]");
			object obj12 = 0;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S3_v21 (Il2CppMethodInfo)+C]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S3_v22+60]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S3_v23+38]");
			object obj15 = 0;
			object obj16 = obj15 & 0x1FFF;
			object obj17 = obj16 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v149 @ S4_v18 (should have been resolved before IL gen)");
		}
		else
		{
			Selector[] componentsInChildren = ((Component)value).GetComponentsInChildren<Selector>(includeInactive: true);
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S3_v6 (Il2CppMethodInfo)+C]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S3_v7+60]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S3_v8+38]");
			object obj20 = 0;
			object obj21 = obj20 & 0x1FFF;
			object obj22 = obj21 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v190 @ S4_v6 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+30]");
			object obj23 = 0;
			TrackObject[] componentsInChildren2 = ((Component)value).GetComponentsInChildren<TrackObject>(includeInactive: true);
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S3_v11 (Il2CppMethodInfo)+C]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S3_v12+60]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S3_v13+38]");
			object obj26 = 0;
			object obj27 = obj26 & 0x1FFF;
			object obj28 = obj27 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159 @ S4_v10 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+5C]");
		((Transform)value).parentInternal = (Transform)0;
		nint num10 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v48 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 back = Vector3.back;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = vector / duration;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
	}

	private unsafe void DrawBounds(Bounds bounds, Transform theTransform, Color color, float duration = 0f)
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01f2: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got F4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected VT, but got Unknown
		//IL_022c: Expected native int or pointer, but got VT
		//IL_0514: Expected native int or pointer, but got VT
		//IL_026c: Expected I, but got Obj
		//IL_0282: Expected Obj, but got I
		//IL_0012: Expected F4, but got Obj
		//IL_000d: Expected native int or pointer, but got VT
		//IL_0024: Expected F4, but got I
		//IL_001f: Expected native int or pointer, but got VT
		//IL_0031: Expected Obj, but got F4
		//IL_004d: Expected Obj, but got F4
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected Obj, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected Obj, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got Unknown
		//IL_05c9: Invalid comparison between I4 and VT
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0071: Expected F4, but got I
		//IL_006c: Expected native int or pointer, but got VT
		//IL_007e: Expected Obj, but got F4
		//IL_00b2: Expected I, but got Obj
		//IL_00ff: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02bc: Expected Obj, but got VT
		//IL_033e: Expected Obj, but got I4
		//IL_0348: Unsupported input type for neg.
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_037b: Expected Obj, but got I
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_03dc: Expected F4, but got Obj
		//IL_03d7: Expected native int or pointer, but got VT
		//IL_03f1: Expected F4, but got I
		//IL_03ec: Expected native int or pointer, but got VT
		//IL_040a: Expected Obj, but got I
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got VT
		//IL_0452: Expected I, but got Obj
		//IL_0468: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I4
		//IL_04d4: Expected F4, but got Obj
		//IL_04cf: Expected native int or pointer, but got VT
		//IL_04e9: Expected F4, but got I
		//IL_04e4: Expected native int or pointer, but got VT
		//IL_0502: Expected Obj, but got I
		//IL_0140: Expected I, but got Obj
		//IL_018d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 32;
		obj3 = 0;
		float num = duration * (-(float)Math.PI / 180f);
		obj3 = 1000f;
		_ = 1000f;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 40);
		((Matrix4x4*)(nint)matrix4x)->m00 = color.r;
		if (matrix4x.m00 > 0f)
		{
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)theTransform;
			((Matrix4x4*)(nint)matrix4x)->m20 = (nint)((UnityEngine.Object)theTransform).m_CachedPtr;
			obj = color.r;
			float num2 = matrix4x.m20 / (float)obj;
			obj3 = num2;
		}
		((Matrix4x4*)(nint)matrix4x)->m00 = color.r;
		if (matrix4x.m10 > 0f)
		{
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)theTransform;
			((Matrix4x4*)(nint)matrix4x)->m20 = (nint)((UnityEngine.Object)theTransform).m_CachedPtr;
			obj = color.r;
			float num3 = matrix4x.m30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num4 = num3 / 0f;
		}
		nint num5 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v28 (Il2CppClass<UIDrawCall>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v59 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 152;
		object obj6 = obj2 + 136;
		object obj7 = obj2 + 120;
		object obj8 = obj2 + 104;
		object obj9 = obj2 + 88;
		object obj10 = obj2 + 72;
		object obj11 = obj2 + 8;
		object obj12 = obj2 + 56;
		int[] clipRange = UIDrawCall.ClipRange;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)clipRange.Length) <= System.Runtime.CompilerServices.Unsafe.As<Bounds, UIntPtr>(ref bounds))
		{
			return;
		}
		nint num7 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v29 (Il2CppClass<UIDrawCall>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num8 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v46 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj14 = UIDrawCall.ClipRange + 16;
		object obj15 = bounds << 2;
		object name = obj14 + obj15;
		obj = theTransform;
		_ = ((UnityEngine.Object)theTransform).m_CachedPtr;
		obj5 = theTransform;
		_ = ((UnityEngine.Object)theTransform).m_CachedPtr;
		obj6 = theTransform;
		_ = ((UnityEngine.Object)theTransform).m_CachedPtr;
		obj7 = theTransform;
		_ = ((UnityEngine.Object)theTransform).m_CachedPtr;
		obj8 = theTransform;
		_ = ((UnityEngine.Object)theTransform).m_CachedPtr;
		obj9 = theTransform;
		_ = ((UnityEngine.Object)theTransform).m_CachedPtr;
		obj10 = 0;
		_ = 0;
		object obj16 = 0 - obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v33+8]");
		object obj17 = obj16 / 0;
		obj10 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v35+4]");
		object obj18 = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v37+C]");
		object obj19 = obj18 / 0;
		float num9 = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v39+8]");
		float num10 = num9 / 0f;
		float num11 = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v41+C]");
		float num12 = num11 / 0f;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Matrix4x4 matrix4x2 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v43+8]");
		((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+60]");
		((Material)0).SetMatrix((string)name, matrix4x);
		object obj20 = UIDrawCall.ClipArgs + 16;
		object obj21 = bounds << 2;
		object name2 = obj20 + obj21;
		obj11 = obj3;
		obj2 = obj3;
		nint num13 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S2_v51 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num14 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S2_v68 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
		obj12 = 0;
		_ = 0;
		obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
		Matrix4x4 matrix4x3 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v47+8]");
		((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteCollection)+60]");
		((Material)0).SetMatrix((string)name2, matrix4x);
	}

	private unsafe void DrawBoundsInternal(Bounds bounds, Transform theTransform, Color color, float duration = 0f)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0022: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I4, but got Unknown
		//IL_0057: Expected I4, but got F4
		Uri uri = (Uri)bounds.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+8]");
		uri.m_String = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ L1 (UnityEngine.Bounds)+10]");
		uri.m_Syntax = (UriParser)0;
		bool flag = (byte)(uri + 24) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)color.r != 0;
		_ = color.b;
		((PurchaseValidationServer)null)._002Ector(uri, (IJsonSerializer)theTransform, flag, duration);
	}
}
