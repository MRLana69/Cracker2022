using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo;

public class PositionValueResetter : BaseTransformValueResetter
{
	private Vector3 _startPosition;

	public PositionValueResetter(SpaceType spaceType)
	{
		if (_spaceType != SpaceType.World)
		{
			if (_spaceType == SpaceType.Local)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	protected override void OnInitLocalSpace(Transform transform)
	{
		//IL_000a: Expected I4, but got Obj
		_spaceType = (SpaceType)transform;
	}

	protected override void OnInitWorldSpace(Transform transform)
	{
		//IL_000d: Expected VT, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		Transform transform2 = default;
		transform2.position = (Vector3)transform;
		object obj = transform2 + 12;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj2 = this + 12;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+8]");
		_ = 0;
	}

	protected override void OnResetLocalSpace(Transform transform)
	{
		//IL_000d: Expected VT, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		Transform transform2 = default;
		transform2.localPosition = (Vector3)transform;
		object obj = transform2 + 12;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj2 = this + 12;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+8]");
		_ = 0;
	}

	protected override void OnResetWorldSpace(Transform transform)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		Transform transform2 = (Transform)(obj2 + 12);
		transform2 = (Transform)obj2;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform2.localPosition;
	}
}
