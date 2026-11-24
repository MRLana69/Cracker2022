using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Extensions;

public static class TransformExtensions
{
	public static void Reset(Transform t)
	{
		if ((object)t != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public static void SetLocalScaleX(Transform transform, float scaleX)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		float num = scaleX * 0.5f;
		object obj3 = obj2 + 24;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A8");
	}

	public static void SetLocalScaleY(Transform transform, float scaleY)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got F4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 24);
		transform2.localScale = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 12);
		transform3.localScale = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = scaleY;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		Transform transform4 = (Transform)(obj + 36);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		transform.parent = transform4;
	}

	public static void SetLocalScaleZ(Transform transform, float scaleZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 24);
		transform2.localScale = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 12);
		transform3.localScale = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = transform2;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		Transform transform4 = (Transform)(obj + 36);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		transform.parent = transform4;
	}

	public static void SetLocalPosX(Transform transform, float posX)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 24);
		transform2.localScale = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 12);
		transform3.localScale = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
		_ = 0;
		Transform transform4 = (Transform)(obj + 36);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		transform.parent = transform4;
	}

	public static void SetLocalPosY(Transform transform, float posY)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got F4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 24);
		transform2.localPosition = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 12);
		transform3.localPosition = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = posY;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		Transform transform4 = (Transform)(obj + 36);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform4.eulerAngles;
	}

	public static void SetLocalPosZ(Transform transform, float posZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 24);
		transform2.localPosition = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 12);
		transform3.localPosition = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = transform2;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		Transform transform4 = (Transform)(obj + 36);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform4.eulerAngles;
	}

	public static void OffsetLocalPosX(Transform transform, float value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 24);
		transform2.localPosition = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 12);
		transform3.localPosition = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
		_ = 0;
		Transform transform4 = (Transform)(obj + 36);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform4.eulerAngles;
	}

	public static void OffsetLocalPosY(Transform transform, float value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0056: Expected VT, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got F4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 36);
		transform2.localPosition = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 24);
		transform3.localPosition = (Vector3)transform;
		Transform transform4 = (Transform)(obj + 12);
		transform4.localPosition = (Vector3)transform;
		obj = 0;
		_ = 0;
		float num = (float)transform2 + value;
		obj = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		Transform transform5 = (Transform)(obj + 48);
		transform5 = (Transform)obj;
		Transform transform6 = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform5.eulerAngles;
	}

	public static void OffsetLocalPosZ(Transform transform, float value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0056: Expected VT, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 36);
		transform2.localPosition = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 24);
		transform3.localPosition = (Vector3)transform;
		Transform transform4 = (Transform)(obj + 12);
		transform4.localPosition = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
		float num = 0f + value;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		Transform transform5 = (Transform)(obj + 48);
		transform5 = (Transform)obj;
		Transform transform6 = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform5.eulerAngles;
	}

	public static void SetPosX(Transform transform, float posX)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0056: Expected VT, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 36);
		transform2.localPosition = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 24);
		transform3.localPosition = (Vector3)transform;
		Transform transform4 = (Transform)(obj + 12);
		transform4.localPosition = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
		_ = 0;
		float num = (float)(nint)((UnityEngine.Object)transform4).m_CachedPtr + posX;
		Transform transform5 = (Transform)(obj + 48);
		transform5 = (Transform)obj;
		Transform transform6 = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform5.eulerAngles;
	}

	public static void SetPosY(Transform transform, float posY)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got F4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 24);
		transform2.position = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 12);
		transform3.position = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = posY;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		Transform transform4 = (Transform)(obj + 36);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform4.localPosition;
	}

	public static void SetPosZ(Transform transform, float posZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0036: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		object obj = default;
		Transform transform2 = (Transform)(obj + 24);
		transform2.position = (Vector3)transform;
		Transform transform3 = (Transform)(obj + 12);
		transform3.position = (Vector3)transform;
		obj = 0;
		_ = 0;
		obj = transform2;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		Transform transform4 = (Transform)(obj + 36);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform4.localPosition;
	}
}
