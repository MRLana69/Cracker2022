using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Data;
using SYBO.Subway.Level;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Common.Components;

public class StackablePrefabBuilderComponent : MonoBehaviour
{
	private StackablePrefabData _stackablePrefabData;

	protected void Start()
	{
		_ = 1;
		CancelInvoke();
	}

	public StackablePrefabBuilderComponent()
	{
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0269: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02aa: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_00aa: Expected VT, but got Obj
		//IL_00e2: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 4;
		obj3 = 0;
		_ = 0;
		obj2 = 0;
		Transform transform = (Transform)(obj2 + 40);
		GameObject gameObject = base.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		transform.position = (Vector3)parentInternal;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v15 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v67 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<GameObject> list = (List<GameObject>)(obj2 + 28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (UnityEngine.Transform)+4]");
		float num3 = 0f / 90f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		float num4 = num3 * 90f;
		StackablePrefabData stackablePrefabData = _stackablePrefabData;
		List<GameObject> prefabs = stackablePrefabData._prefabs;
		if (prefabs._size > 0)
		{
			GameObject gameObject2 = base.gameObject;
			transform.position = (Vector3)gameObject2;
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			StackablePrefabData stackablePrefabData2 = _stackablePrefabData;
			obj2 = stackablePrefabData2._stackableBuildDirection;
			if (stackablePrefabData2._stackableBuildDirection != StackableBuildDirection.YDownToFloor)
			{
				StackablePrefabData stackablePrefabData3 = _stackablePrefabData;
				obj2 = stackablePrefabData3._stackableBuildDirection;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			transform = (Transform)obj;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			list = (List<GameObject>)obj;
			List<GameObject> list2 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			list2._items = (GameObject[])0;
			obj3 = transform;
			_ = list._items;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RouteBuilder routeBuilder = default;
			object obj5 = routeBuilder + 8;
			obj5 = _stackablePrefabData;
			string selectors = tag;
			list = (List<GameObject>)obj;
			List<GameObject> list3 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			list3._items = (GameObject[])0;
			transform = (Transform)obj3;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			IEnumerator enumerator = routeBuilder.RecursiveSelectionASync((List<Selector>)(object)selectors, list, (List<Selector>)(object)transform);
		}
	}
}
