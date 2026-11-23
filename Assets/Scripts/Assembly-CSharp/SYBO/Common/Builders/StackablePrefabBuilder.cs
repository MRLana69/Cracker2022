using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components;
using SYBO.Common.Data;
using SYBO.Common.Exceptions;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Common.Builders;

[Serializable]
public class StackablePrefabBuilder
{
	private static string _STACKABLE_PREFAB_BUILDER_NAME = "StackablePrefabBuilder";

	private StackablePrefabData _stackablePrefabData;

	public StackablePrefabData StackablePrefabData => _stackablePrefabData;

	public StackablePrefabBuilder(StackablePrefabData stackablePrefabData)
	{
		_stackablePrefabData = stackablePrefabData;
	}

	public unsafe GameObject BuildAndAttach(GameObject parentGameObject, Vector3 startWorldPosition, Vector3 endWorldPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected VT, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected I4, but got Unknown
		//IL_03d0: Expected Obj, but got F4
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected VT, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected VT, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_02b4: Expected Obj, but got F4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected VT, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected VT, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		object obj = default;
		StackablePrefabBuilder stackablePrefabBuilder = (StackablePrefabBuilder)(obj - 128);
		_ = 0;
		_ = 0;
		GameObject gameObject = default;
		gameObject._002Ector(_STACKABLE_PREFAB_BUILDER_NAME);
		DeselectMeComponent deselectMeComponent = gameObject.AddComponent<DeselectMeComponent>();
		deselectMeComponent._deselectMeMode = DeselectMeMode.EnabledRedirectToParent;
		Transform transform = gameObject.transform;
		Transform transform2 = parentGameObject.transform;
		Vector3 position = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Builders.StackablePrefabBuilder)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Builders.StackablePrefabBuilder)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Builders.StackablePrefabBuilder)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Builders.StackablePrefabBuilder)+68]");
		_ = 0;
		Vector3 position2 = (Vector3)(stackablePrefabBuilder + 72);
		transform.position = position2;
		Transform transform3 = gameObject.transform;
		Transform transform4 = parentGameObject.transform;
		HierarchyUtility.Reparent(transform3, transform4, worldPositionStays: true);
		StackablePrefabData stackablePrefabData = _stackablePrefabData;
		List<GameObject> prefabs = stackablePrefabData._prefabs;
		if (prefabs._size != 3)
		{
			StackablePrefabData stackablePrefabData2 = _stackablePrefabData;
			List<GameObject> prefabs2 = stackablePrefabData2._prefabs;
			_ = prefabs2._size;
			int num = stackablePrefabBuilder + 124;
			string text = ((int*)num)->ToString();
			string text2 = "Stackabel system CURRENTLY requires 3 Prefabs. Has : " + text;
		}
		StackablePrefabData stackablePrefabData3 = _stackablePrefabData;
		GameObject gameObject2 = stackablePrefabData3._prefabs.get_Item(0);
		StackablePrefabData stackablePrefabData4 = _stackablePrefabData;
		GameObject midPrefab = stackablePrefabData4._prefabs.get_Item(1);
		StackablePrefabData stackablePrefabData5 = _stackablePrefabData;
		GameObject gameObject3 = stackablePrefabData5._prefabs.get_Item(2);
		if (gameObject2 != null && gameObject3 != null)
		{
			StackablePrefabData stackablePrefabData6 = _stackablePrefabData;
			bool flag = stackablePrefabData6._stackableBuildDirection == StackableBuildDirection.ZOnly;
			GameObject startPrefab = gameObject2;
			if (!flag)
			{
				if (stackablePrefabData6._stackableBuildDirection == StackableBuildDirection.YDownToFloor)
				{
					object obj2 = stackablePrefabBuilder - -64;
					obj2 = startWorldPosition.z;
					_ = startWorldPosition.x;
					_ = endWorldPosition.z;
					_ = endWorldPosition.x;
					Vector3 startWorldPosition2 = (Vector3)(stackablePrefabBuilder + 56);
					Vector3 endWorldPosition2 = (Vector3)(stackablePrefabBuilder + 40);
					stackablePrefabBuilder.BuildYDirection(gameObject, startWorldPosition2, endWorldPosition2, gameObject2, midPrefab, gameObject3);
					goto IL_037c;
				}
				_ = stackablePrefabData6._stackableBuildDirection;
				Enum obj3 = (Enum)(stackablePrefabBuilder + 104);
				_ = -1;
				obj3 = (Enum)(object)typeof(StackableBuildDirection);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Builders.StackablePrefabBuilder)+78]");
				_ = 0;
				string missingSwitchValue = obj3.ToString();
				SwitchDefaultException.Throw(missingSwitchValue);
				startPrefab = (GameObject)(object)typeof(StackableBuildDirection);
			}
			_ = startWorldPosition.z;
			_ = startWorldPosition.x;
			_ = endWorldPosition.z;
			stackablePrefabBuilder._stackablePrefabData = (StackablePrefabData)endWorldPosition.x;
			Vector3 startWorldPosition3 = (Vector3)(stackablePrefabBuilder + 24);
			Vector3 endWorldPosition3 = (Vector3)(stackablePrefabBuilder + 8);
			stackablePrefabBuilder.BuildZDirection(gameObject, startWorldPosition3, endWorldPosition3, startPrefab, midPrefab, gameObject3);
		}
		goto IL_037c;
		IL_037c:
		return gameObject;
	}

	private unsafe void BuildZDirection(GameObject stackablePrefabBuilder, Vector3 startWorldPosition, Vector3 endWorldPosition, GameObject startPrefab, GameObject midPrefab, GameObject endPrefab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_076b: Expected I, but got Obj
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected VT, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected VT, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected VT, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected VT, but got Unknown
		//IL_0135: Expected Ref, but got VT
		//IL_015b: Expected Obj, but got I
		//IL_017c: Invalid comparison between Obj and F4
		//IL_05ef: Expected I, but got Obj
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected VT, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected VT, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected VT, but got Unknown
		//IL_020e: Expected Ref, but got VT
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected VT, but got Unknown
		//IL_03a2: Expected Obj, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected VT, but got Unknown
		//IL_03ff: Expected Ref, but got VT
		//IL_040c: Expected Obj, but got I4
		//IL_0696: Expected I, but got Obj
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected VT, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected VT, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected VT, but got Unknown
		//IL_049a: Expected Ref, but got VT
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_0500: Expected F4, but got I
		//IL_04fb: Expected native int or pointer, but got VT
		//IL_055d: Expected F4, but got I
		//IL_0558: Expected native int or pointer, but got VT
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 304);
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v8 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v9 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
		_ = 0;
		Vector3 position = vector + 128;
		Quaternion rotation = (Quaternion)(vector + 112);
		GameObject gameObject = UnityEngine.Object.Instantiate(startPrefab, position, rotation);
		Transform transform = gameObject.transform;
		float num3 = startWorldPosition.x - 0f;
		float num4 = startWorldPosition.y - 0f;
		float num5 = startWorldPosition.z - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
		_ = 0;
		Vector3 position2 = vector + 96;
		transform.position = position2;
		Transform transform2 = gameObject.transform;
		Transform transform3 = stackablePrefabBuilder.transform;
		HierarchyUtility.Reparent(transform2, transform3, worldPositionStays: true);
		nint num6 = 0;
		nint num7 = 0;
		IntPtr intPtr = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		Renderer renderer = default;
		Bounds bounds = renderer.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
		_ = 0;
		Bounds bounds2 = (Bounds)(vector + 280);
		Vector3 size = ((Bounds*)bounds2)->size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		object obj2 = num8 + 0;
		float num9 = endWorldPosition.z - startWorldPosition.z;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9);
		bool flag2 = !flag;
		UnityEngine.Object obj3 = null;
		if (!flag2)
		{
			nint num10 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v134 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v135 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
			_ = 0;
			Vector3 position3 = vector + 80;
			Quaternion rotation2 = (Quaternion)(vector - -64);
			GameObject gameObject2 = UnityEngine.Object.Instantiate(endPrefab, position3, rotation2);
			Transform transform4 = gameObject2.transform;
			nint num12 = 0;
			nint num13 = 0;
			IntPtr intPtr2 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v302 @ S4_v8 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			Renderer renderer2 = default;
			Bounds bounds3 = renderer2.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			_ = 0;
			Bounds bounds4 = (Bounds)(vector + 280);
			Vector3 size2 = ((Bounds*)bounds4)->size;
			float num14 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			float num15 = num14 - 0f;
			float num16 = endWorldPosition.z + num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
			_ = 0;
			float num17 = endWorldPosition.y + 0f;
			float num18 = endWorldPosition.x + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
			_ = 0;
			Vector3 position4 = vector + 48;
			transform4.position = position4;
			Transform transform5 = gameObject2.transform;
			Transform transform6 = stackablePrefabBuilder.transform;
			HierarchyUtility.Reparent(transform5, transform6, worldPositionStays: true);
			obj3 = gameObject2;
		}
		if (!(midPrefab != null) || !(obj3 != null))
		{
			return;
		}
		Transform transform7 = ((GameObject)obj3).transform;
		Vector3 position5 = transform7.position;
		Transform transform8 = gameObject.transform;
		Vector3 position6 = transform8.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		object obj4 = num19 - 0;
		Renderer component = midPrefab.GetComponent<Renderer>();
		Bounds bounds5 = component.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
		_ = 0;
		Bounds bounds6 = (Bounds)(vector + 280);
		Vector3 size3 = ((Bounds*)bounds6)->size;
		object obj5 = 0;
		object obj6 = obj4;
		while (true)
		{
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			if ((nint)obj7 <= 0)
			{
				break;
			}
			nint num20 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S1_v83 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S1_v84 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
			_ = 0;
			Vector3 position7 = vector + 32;
			Quaternion rotation3 = (Quaternion)(vector + 16);
			GameObject gameObject3 = UnityEngine.Object.Instantiate(midPrefab, position7, rotation3);
			Transform transform9 = gameObject3.transform;
			Transform transform10 = gameObject.transform;
			Vector3 position8 = transform10.position;
			Renderer component2 = gameObject3.GetComponent<Renderer>();
			Bounds bounds7 = component2.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			_ = 0;
			Bounds bounds8 = (Bounds)(vector + 280);
			Vector3 size4 = ((Bounds*)bounds8)->size;
			object obj8 = obj5 + 1;
			float num22 = (float)obj8 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			object obj9 = 0 * obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			object obj10 = 0 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			((Vector3*)(nint)vector)->z = 0f;
			float num23 = (float)obj8 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
			float num24 = 0f + num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			float num25 = 0f + num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			((Vector3*)(nint)vector)->x = 0f;
			transform9.position = vector;
			Transform transform11 = gameObject3.transform;
			Transform transform12 = stackablePrefabBuilder.transform;
			HierarchyUtility.Reparent(transform11, transform12, worldPositionStays: true);
			object obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			object obj12 = obj11 - 0;
			obj5 = obj8;
			obj6 = obj12;
		}
	}

	private unsafe void BuildYDirection(GameObject stackablePrefabBuilder, Vector3 startWorldPosition, Vector3 endWorldPosition, GameObject startPrefab, GameObject midPrefab, GameObject endPrefab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0530: Expected I, but got Obj
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected VT, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected VT, but got Unknown
		//IL_03bb: Expected I, but got Obj
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected VT, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected VT, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected VT, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected VT, but got Unknown
		//IL_01a3: Expected Ref, but got VT
		//IL_01ca: Expected Obj, but got I4
		//IL_0462: Expected I, but got Obj
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected VT, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected VT, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected VT, but got Unknown
		//IL_0250: Expected Ref, but got VT
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_02f1: Expected F4, but got I
		//IL_02ec: Expected native int or pointer, but got VT
		//IL_0327: Expected F4, but got I
		//IL_0322: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 240);
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v8 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v9 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		_ = startWorldPosition.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		_ = startWorldPosition.x;
		Vector3 position = vector + 112;
		Quaternion rotation = (Quaternion)(vector + 96);
		GameObject gameObject = UnityEngine.Object.Instantiate(startPrefab, position, rotation);
		Transform transform = gameObject.transform;
		Transform transform2 = stackablePrefabBuilder.transform;
		HierarchyUtility.Reparent(transform, transform2, worldPositionStays: true);
		bool flag = endPrefab != null;
		bool flag2 = !flag;
		UnityEngine.Object obj2 = null;
		if (!flag2)
		{
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v101 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v102 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
			_ = 0;
			Vector3 position2 = vector + 80;
			Quaternion rotation2 = (Quaternion)(vector - -64);
			GameObject gameObject2 = UnityEngine.Object.Instantiate(endPrefab, position2, rotation2);
			Transform transform3 = gameObject2.transform;
			_ = endWorldPosition.z;
			_ = endWorldPosition.x;
			Vector3 position3 = vector + 48;
			transform3.position = position3;
			Transform transform4 = gameObject2.transform;
			Transform transform5 = stackablePrefabBuilder.transform;
			HierarchyUtility.Reparent(transform4, transform5, worldPositionStays: true);
			obj2 = gameObject2;
		}
		if (midPrefab != null && obj2 != null)
		{
			float value = startWorldPosition.y - endWorldPosition.y;
			Renderer component = midPrefab.GetComponent<Renderer>();
			Bounds bounds = component.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
			_ = 0;
			Bounds bounds2 = (Bounds)(vector + 216);
			Vector3 size = ((Bounds*)bounds2)->size;
			float num5 = System.Math.Abs(value);
			float num6 = num5;
			object obj3 = 0;
			while (num6 > 0f)
			{
				nint num7 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S1_v48 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v49 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
				_ = 0;
				_ = Quaternion.identityQuaternion;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Vector3 position4 = vector + 32;
				Quaternion rotation3 = (Quaternion)(vector + 16);
				GameObject gameObject3 = UnityEngine.Object.Instantiate(midPrefab, position4, rotation3);
				Transform transform6 = gameObject3.transform;
				Transform transform7 = gameObject.transform;
				Vector3 position5 = transform7.position;
				Renderer component2 = gameObject3.GetComponent<Renderer>();
				Bounds bounds3 = component2.bounds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
				_ = 0;
				Bounds bounds4 = (Bounds)(vector + 216);
				Vector3 size2 = ((Bounds*)bounds4)->size;
				object obj4 = obj3 + 1;
				float num9 = (float)obj4 * 0f;
				float num10 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num11 = num10 - 0f;
				float num12 = num11 * (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num13 = 0f + num12;
				float num14 = (float)obj4 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				float num15 = 0f + num14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
				float num16 = 0f + num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				((Vector3*)(nint)vector)->x = 0f;
				transform6.position = vector;
				Transform transform8 = gameObject3.transform;
				Transform transform9 = stackablePrefabBuilder.transform;
				HierarchyUtility.Reparent(transform8, transform9, worldPositionStays: true);
				float num17 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num18 = num17 - 0f;
				num6 = num18;
				obj3 = obj4;
			}
		}
	}
}
