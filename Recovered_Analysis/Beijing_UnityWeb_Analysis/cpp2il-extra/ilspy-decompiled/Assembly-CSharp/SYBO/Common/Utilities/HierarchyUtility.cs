using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Debugging;
using SYBO.Common.Visuals;
using UnityEngine;
using UnityEngine.U2D;

namespace SYBO.Common.Utilities;

public class HierarchyUtility : MonoBehaviour
{
	public static GameObject GetGameObjectByHierarchyPathType(HierarchyPathType hierarchyPathType)
	{
		return null;
	}

	public static void ReparentByHierarchyPathType(Transform childTransform, HierarchyPathType hierarchyPathType, bool worldPositionStays = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = childTransform + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9543");
	}

	public static void ReparentByHierarchyPathType(Transform childTransform, HierarchyPathType hierarchyPathType, Vector3 newWorldPosition)
	{
		//IL_0096: Expected Obj, but got I4
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_0087: Expected I4, but got VT
		//IL_0087: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0064: Expected I4, but got VT
		//IL_0064: Expected VT, but got I4
		bool flag = HasBounds((GameObject)hierarchyPathType);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)flag != null)
		{
			childTransform.Translate((Vector3)0, (Space)newWorldPosition);
			return;
		}
		int layer = ((GameObject)flag).layer;
		childTransform.Translate((Vector3)layer, (Space)newWorldPosition);
	}

	public unsafe static void Reparent(Transform childTransform, Transform parentTransform, bool worldPositionStays = false)
	{
		//IL_0012: Expected VT, but got I4
		//IL_0012: Expected I4, but got Obj
		//IL_001f: Expected Obj, but got I4
		ReparentByHierarchyPathType(childTransform, (HierarchyPathType)parentTransform, (Vector3)0);
		Transform transform = (Transform)((bool*)(worldPositionStays ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [worldPositionStays @ L2 (System.Boolean)+8]");
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform.localPosition;
	}

	public static void Reparent(Transform childTransform, Transform parentTransform, Vector3 newLocalPosition)
	{
		//IL_0011: Expected I4, but got VT
		//IL_0011: Expected VT, but got Obj
		childTransform.Translate((Vector3)parentTransform, (Space)newLocalPosition);
	}

	public static void SetAsLastSibling(Transform transform)
	{
		//IL_0069: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		int layer = ((GameObject)(object)transform).layer;
		((Transform)layer).parentInternal = null;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(transform);
	}

	public static void InstantiatePrefabList(List<GameObject> prefabGOs, Transform parentTransform, Vector3 paddingBetweenVector3)
	{
		//IL_001a: Expected Obj, but got F4
		//IL_002c: Expected I, but got F4
		Matrix4x4 worldToLocalMatrix = parentTransform.worldToLocalMatrix;
		Transform transform = (Transform)paddingBetweenVector3.x;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)paddingBetweenVector3.z;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	public static Bounds GetBounds(GameObject gameObject)
	{
		//IL_00cc: Expected Obj, but got VT
		//IL_00ed: Expected Obj, but got VT
		//IL_0121: Expected Obj, but got VT
		//IL_0012: Expected Obj, but got VT
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		Bounds bounds = default;
		int siblingIndex = ((Transform)bounds).GetSiblingIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Sprite sprite = null;
		int siblingIndex2 = ((Transform)bounds).GetSiblingIndex();
		if ((nint)sprite < siblingIndex2)
		{
			bool flag = ((SpriteAtlas)bounds).CanBindTo(sprite);
			throw new ArrayTypeMismatchException();
		}
		_0021_00210[] keys = default;
		Array.Sort<TKey, TValue>((TKey[])(object)keys, (TValue[])(object)gameObject);
		Transform transform = null;
		while (true)
		{
			int siblingIndex3 = ((Transform)bounds).GetSiblingIndex();
			if ((nint)transform >= siblingIndex3)
			{
				break;
			}
			Vector3 lossyScale = transform.lossyScale;
			Bounds bounds2 = GetBounds(gameObject);
			Transform transform2 = (Transform)(transform + 1);
			transform = transform2;
		}
		return bounds;
	}

	public static bool HasBounds(GameObject gameObject)
	{
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_03ba: Expected Obj, but got I4
		//IL_03c7: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I4
		//IL_0310: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		object obj = gameObject - 1;
		if ((nint)gameObject != 1)
		{
			CommentComponent commentComponent2;
			bool result;
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							return false;
						}
						bool flag = _HasGameObjectByHierarchyPathString("_Root/Manual/Managers");
						int layer = ((GameObject)flag).layer;
						bool flag2 = HasBounds((GameObject)4);
						int layer2 = ((GameObject)flag2).layer;
						((Transform)layer).parentInternal = (Transform)layer2;
						CommentComponent commentComponent = _GetComponentOrAddComponent<CommentComponent>((GameObject)flag);
						object obj2 = commentComponent + 12;
						obj2 = "The 'Managers' GameObject is created on-demand by HierarchyUtility. Manually drag in children as you like. Please do not remove it.";
						commentComponent2 = commentComponent;
						result = flag;
					}
					else
					{
						bool flag3 = _HasGameObjectByHierarchyPathString("_Root/Manual");
						int layer3 = ((GameObject)flag3).layer;
						bool flag4 = HasBounds((GameObject)1);
						int layer4 = ((GameObject)flag4).layer;
						((Transform)layer3).parentInternal = (Transform)layer4;
						int layer5 = ((GameObject)flag3).layer;
						Vector3 lossyScale = ((Transform)1).lossyScale;
						CommentComponent commentComponent3 = _GetComponentOrAddComponent<CommentComponent>((GameObject)flag3);
						object obj3 = commentComponent3 + 12;
						obj3 = "The 'Manual' GameObject is created on-demand by HierarchyUtility. Manually drag in children as you like. Please do not remove it.";
						commentComponent2 = commentComponent3;
						result = flag3;
					}
				}
				else
				{
					bool flag5 = _HasGameObjectByHierarchyPathString("_Root/Dynamic/Managers");
					int layer6 = ((GameObject)flag5).layer;
					bool flag6 = HasBounds((GameObject)2);
					int layer7 = ((GameObject)flag6).layer;
					((Transform)layer6).parentInternal = (Transform)layer7;
					CommentComponent commentComponent4 = _GetComponentOrAddComponent<CommentComponent>((GameObject)flag5);
					object obj4 = commentComponent4 + 12;
					obj4 = "The 'Managers' GameObject is created on-demand by HierarchyUtility. It holds managers and other dynamic instances.\n Please do not remove it.";
					commentComponent2 = commentComponent4;
					result = flag5;
				}
			}
			else
			{
				bool flag7 = _HasGameObjectByHierarchyPathString("_Root/Dynamic");
				int layer8 = ((GameObject)flag7).layer;
				bool flag8 = HasBounds((GameObject)1);
				int layer9 = ((GameObject)flag8).layer;
				((Transform)layer8).parentInternal = (Transform)layer9;
				int layer10 = ((GameObject)flag7).layer;
				((Transform)layer10).SetAsLastSibling();
				CommentComponent commentComponent5 = _GetComponentOrAddComponent<CommentComponent>((GameObject)flag7);
				object obj5 = commentComponent5 + 12;
				obj5 = "The 'Dynamic' GameObject is created on-demand by HierarchyUtility. It holds managers and other dynamic instances.\n Please do not remove it.";
				commentComponent2 = commentComponent5;
				result = flag7;
			}
			commentComponent2._isCommentEditableInInspector = false;
			return result;
		}
		IList<ObjectModelInfo> meshInfos = MeshUtil.GetMeshInfos((IList<CombineableMesh>)(object)"_Root");
		bool flag9 = _HasGameObjectByHierarchyPathString("_Root");
		if (meshInfos == null)
		{
			CommentComponent commentComponent6 = _GetComponentOrAddComponent<CommentComponent>((GameObject)flag9);
			object obj6 = commentComponent6 + 12;
			obj6 = "The '_Root' GameObject is created on-demand by HierarchyUtility.";
			commentComponent6._isCommentEditableInInspector = false;
		}
		int layer11 = ((GameObject)flag9).layer;
		((Transform)layer11).SetAsLastSibling();
		return flag9;
	}

	private static GameObject _GetGameObjectByHierarchyPathString(string hierarchyPathString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_0088: Invalid comparison between Obj and F4
		//IL_0096: Expected Obj, but got I4
		object obj = default;
		SyboRandom syboRandom = (SyboRandom)(obj + 24);
		syboRandom = (SyboRandom)0;
		syboRandom._randomGen = null;
		_ = 0;
		object obj2 = obj + 12;
		obj2 = 0;
		_ = 0;
		syboRandom._002Ector((IRandomGen)(object)hierarchyPathString);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj3 = default;
		bool flag = obj3 != (object)0f;
		return (GameObject)flag;
	}

	private static T _GetComponentOrAddComponent<T>(GameObject go) where T : Component
	{
		//IL_001d: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		string text = ((Component)(object)go).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S4_v4 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	private static bool _HasGameObjectByHierarchyPathString(string hierarchyPathString)
	{
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_007b: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected I4, but got Obj
		GameObject gameObject = ((GameObject)(object)hierarchyPathString).gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = gameObject != null;
		bool flag2 = !flag;
		GameObject gameObject2 = gameObject;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject3 = default;
			gameObject3.layer = (int)hierarchyPathString;
			gameObject2 = gameObject3;
		}
		return (byte)(int)gameObject2 != 0;
	}

	public HierarchyUtility()
	{
		((Transform.Enumerator)(object)this).Reset();
	}
}
