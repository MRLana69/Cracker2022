using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Builders;
using SYBO.Common.Data;
using SYBO.Common.Exceptions;
using UnityEngine;

namespace SYBO.Common.Components;

public class StackablePrefabBuilderComponent : MonoBehaviour
{
	private StackablePrefabData _stackablePrefabData;

	protected unsafe void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_014c: Expected F4, but got I
		//IL_0147: Expected native int or pointer, but got VT
		//IL_0188: Expected F4, but got I
		//IL_0183: Expected native int or pointer, but got VT
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		_ = 0;
		_ = 0;
		Transform transform = base.transform;
		Transform parent = transform.parent;
		Vector3 position = parent.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
		float num = 0f / 90f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		float num2 = num * 90f;
		StackablePrefabData stackablePrefabData = _stackablePrefabData;
		List<GameObject> prefabs = stackablePrefabData._prefabs;
		if (prefabs._size >= 1)
		{
			Transform transform2 = base.transform;
			Vector3 position2 = transform2.position;
			object obj2 = vector - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			StackablePrefabData stackablePrefabData2 = _stackablePrefabData;
			if (stackablePrefabData2._stackableBuildDirection == StackableBuildDirection.YDownToFloor)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				StackablePrefabBuilder stackablePrefabBuilder = default;
				stackablePrefabBuilder._stackablePrefabData = stackablePrefabData2;
				GameObject parentGameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				((Vector3*)(nint)vector)->x = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Vector3 startWorldPosition = vector + 16;
				GameObject gameObject = stackablePrefabBuilder.BuildAndAttach(parentGameObject, startWorldPosition, vector);
			}
			else
			{
				_ = stackablePrefabData2._stackableBuildDirection;
				Enum obj3 = (Enum)(vector + 48);
				_ = -1;
				obj3 = (Enum)(object)typeof(StackableBuildDirection);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+3C]");
				_ = 0;
				string missingSwitchValue = obj3.ToString();
				SwitchDefaultException.Throw(missingSwitchValue);
			}
		}
	}
}
