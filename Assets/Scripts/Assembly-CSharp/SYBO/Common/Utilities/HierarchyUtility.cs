using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Debugging;
using UnityEngine;

namespace SYBO.Common.Utilities;

public class HierarchyUtility : MonoBehaviour
{
	public static GameObject GetGameObjectByHierarchyPathType(HierarchyPathType hierarchyPathType)
	{
		//IL_035d: Expected Obj, but got I4
		object obj = hierarchyPathType - 1;
		if (hierarchyPathType != HierarchyPathType.Root)
		{
			GameObject result;
			CommentComponent commentComponent3;
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							return null;
						}
						GameObject gameObject = _GetGameObjectByHierarchyPathString("_Root/Manual/Managers");
						Transform transform = gameObject.transform;
						GameObject gameObjectByHierarchyPathType = GetGameObjectByHierarchyPathType(HierarchyPathType.Manual);
						Transform parent = gameObjectByHierarchyPathType.transform;
						transform.parent = parent;
						CommentComponent commentComponent = _GetComponentOrAddComponent<CommentComponent>(gameObject);
						commentComponent.Comment = "The 'Managers' GameObject is created on-demand by HierarchyUtility. Manually drag in children as you like. Please do not remove it.";
						commentComponent._isCommentEditableInInspector = false;
						return gameObject;
					}
					GameObject gameObject2 = _GetGameObjectByHierarchyPathString("_Root/Manual");
					Transform transform2 = gameObject2.transform;
					GameObject gameObjectByHierarchyPathType2 = GetGameObjectByHierarchyPathType(HierarchyPathType.Root);
					Transform parent2 = gameObjectByHierarchyPathType2.transform;
					transform2.parent = parent2;
					Transform transform3 = gameObject2.transform;
					transform3.SetSiblingIndex(1);
					CommentComponent commentComponent2 = _GetComponentOrAddComponent<CommentComponent>(gameObject2);
					commentComponent2.Comment = "The 'Manual' GameObject is created on-demand by HierarchyUtility. Manually drag in children as you like. Please do not remove it.";
					result = gameObject2;
					commentComponent3 = commentComponent2;
				}
				else
				{
					GameObject gameObject3 = _GetGameObjectByHierarchyPathString("_Root/Dynamic/Managers");
					Transform transform4 = gameObject3.transform;
					GameObject gameObjectByHierarchyPathType3 = GetGameObjectByHierarchyPathType(HierarchyPathType.Dynamic);
					Transform parent3 = gameObjectByHierarchyPathType3.transform;
					transform4.parent = parent3;
					CommentComponent commentComponent4 = _GetComponentOrAddComponent<CommentComponent>(gameObject3);
					commentComponent4.Comment = "The 'Managers' GameObject is created on-demand by HierarchyUtility. It holds managers and other dynamic instances.\n Please do not remove it.";
					result = gameObject3;
					commentComponent3 = commentComponent4;
				}
			}
			else
			{
				GameObject gameObject4 = _GetGameObjectByHierarchyPathString("_Root/Dynamic");
				Transform transform5 = gameObject4.transform;
				GameObject gameObjectByHierarchyPathType4 = GetGameObjectByHierarchyPathType(HierarchyPathType.Root);
				Transform parent4 = gameObjectByHierarchyPathType4.transform;
				transform5.parent = parent4;
				Transform transform6 = gameObject4.transform;
				transform6.SetAsFirstSibling();
				CommentComponent commentComponent5 = _GetComponentOrAddComponent<CommentComponent>(gameObject4);
				commentComponent5.Comment = "The 'Dynamic' GameObject is created on-demand by HierarchyUtility. It holds managers and other dynamic instances.\n Please do not remove it.";
				result = gameObject4;
				commentComponent3 = commentComponent5;
			}
			commentComponent3._isCommentEditableInInspector = false;
			return result;
		}
		bool flag = _HasGameObjectByHierarchyPathString("_Root");
		GameObject gameObject5 = _GetGameObjectByHierarchyPathString("_Root");
		if (!flag)
		{
			CommentComponent commentComponent6 = _GetComponentOrAddComponent<CommentComponent>(gameObject5);
			commentComponent6.Comment = "The '_Root' GameObject is created on-demand by HierarchyUtility.";
			commentComponent6._isCommentEditableInInspector = false;
		}
		Transform transform7 = gameObject5.transform;
		transform7.SetAsFirstSibling();
		return gameObject5;
	}

	public static void ReparentByHierarchyPathType(Transform childTransform, HierarchyPathType hierarchyPathType, bool worldPositionStays = false)
	{
		GameObject gameObjectByHierarchyPathType = GetGameObjectByHierarchyPathType(hierarchyPathType);
		Transform parent = ((!(gameObjectByHierarchyPathType == null)) ? gameObjectByHierarchyPathType.transform : null);
		childTransform.SetParent(parent, worldPositionStays);
	}

	public unsafe static void ReparentByHierarchyPathType(Transform childTransform, HierarchyPathType hierarchyPathType, Vector3 newWorldPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002d: Expected native int or pointer, but got VT
		//IL_003f: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		ReparentByHierarchyPathType(childTransform, hierarchyPathType);
		((Vector3*)(nint)vector)->z = newWorldPosition.z;
		((Vector3*)(nint)vector)->x = newWorldPosition.x;
		childTransform.position = vector;
	}

	public static void Reparent(Transform childTransform, Transform parentTransform, bool worldPositionStays = false)
	{
		childTransform.SetParent(parentTransform, worldPositionStays);
	}

	public unsafe static void Reparent(Transform childTransform, Transform parentTransform, Vector3 newLocalPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0028: Expected native int or pointer, but got VT
		//IL_003a: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		childTransform.SetParent(parentTransform);
		((Vector3*)(nint)vector)->z = newLocalPosition.z;
		((Vector3*)(nint)vector)->x = newLocalPosition.x;
		childTransform.localPosition = vector;
	}

	public static void SetAsLastSibling(Transform transform)
	{
		transform.SetAsLastSibling();
	}

	public unsafe static void InstantiatePrefabList(List<GameObject> prefabGOs, Transform parentTransform, Vector3 paddingBetweenVector3)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected Obj, but got Unknown
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Unknown
		//IL_07a4: Expected Obj, but got I4
		//IL_07ba: Expected Obj, but got I4
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected Obj, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Expected Obj, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected VT, but got Unknown
		//IL_02cd: Expected Ref, but got VT
		//IL_030c: Expected F4, but got I
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 112;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		object obj4 = obj + 96;
		object obj5 = obj - -64;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		object obj6 = 0;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		object obj16 = default;
		object obj18 = default;
		object obj19 = default;
		while (true)
		{
			_ = 0;
			object obj7 = obj + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			float num;
			if ((nint)0 != 1)
			{
				if (obj8 == null)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											bool flag = obj9 == null;
											obj6 = obj10;
											if (flag)
											{
												continue;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												if (obj11 != null)
												{
													_ = 0;
													object obj12 = obj + 40;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
														_ = 0;
														_ = 0;
														Bounds bounds = (Bounds)(obj + 72);
														Vector3 size = ((Bounds*)bounds)->size;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
															num = 0f;
															goto IL_03b4;
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
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag2 = (nint)0 == 1;
													num = 0f;
													if (!flag2)
													{
														goto IL_03b4;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
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
										goto IL_05e1;
									}
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
						goto IL_05e1;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_05e1;
			IL_05e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj13 == obj14;
			bool flag4 = !flag3;
			object obj15 = obj16;
			if (!flag4)
			{
				object obj17 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				obj17 = obj18;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj15 = obj19;
			}
			_ = 0;
			object obj20 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
			IL_03b4:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
					_ = 0;
					object obj21 = obj + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
						float num2 = 0f + 0f;
						float num3 = num2 + paddingBetweenVector3.x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						float num4 = 0f + 0f;
						float num5 = num4 + paddingBetweenVector3.y;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
						float num6 = 0f + num;
						float num7 = num6 + paddingBetweenVector3.z;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						_ = 0;
						object obj22 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag5 = (nint)0 != 1;
						obj6 = obj10;
						if (flag5)
						{
							continue;
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
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_05e1;
		}
		object obj23 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EBE");
	}

	public unsafe static Bounds GetBounds(GameObject gameObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0073: Expected VT, but got Obj
		//IL_006e: Expected native int or pointer, but got VT
		//IL_00f2: Expected VT, but got I
		//IL_00ed: Expected native int or pointer, but got VT
		//IL_00d8: Expected VT, but got Obj
		//IL_00d3: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		Collider component = gameObject.GetComponent<Collider>();
		Renderer component2 = gameObject.GetComponent<Renderer>();
		object obj3 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Bounds bounds2 = default;
		if (component != null)
		{
			Bounds bounds = component.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			((Bounds*)(nint)bounds2)->m_Center = (Vector3)obj;
		}
		else if (component2 != null)
		{
			Bounds bounds3 = component2.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			((Bounds*)(nint)bounds2)->m_Center = (Vector3)obj;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			((Bounds*)(nint)bounds2)->m_Center = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
		}
		return bounds2;
	}

	public static bool HasBounds(GameObject gameObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00d0: Invalid comparison between Obj and F4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		Bounds bounds = GetBounds(gameObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj4 = num2 * 0;
		object obj5 = obj3 + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		object obj6 = num3 * 0;
		object obj7 = obj5 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return obj7 != (object)0f;
	}

	private static GameObject _GetGameObjectByHierarchyPathString(string hierarchyPathString)
	{
		GameObject gameObject = GameObject.Find(hierarchyPathString);
		bool flag = gameObject == null;
		bool flag2 = !flag;
		GameObject result = gameObject;
		if (!flag2)
		{
			GameObject gameObject2 = default;
			gameObject2._002Ector(hierarchyPathString);
			result = gameObject2;
		}
		return result;
	}

	private static T _GetComponentOrAddComponent<T>(GameObject go) where T : Component
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.HierarchyUtility::_GetComponentOrAddComponent>>)+4] (should have been resolved before IL gen)");
		UnityEngine.Object obj = default;
		if (obj == null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v8 (Il2CppMethodRgctx<SYBO.Common.Utilities.HierarchyUtility::_GetComponentOrAddComponent>)+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v9+4] (should have been resolved before IL gen)");
			T result = default;
			return result;
		}
		return (T)obj;
	}

	private static bool _HasGameObjectByHierarchyPathString(string hierarchyPathString)
	{
		GameObject gameObject = GameObject.Find(hierarchyPathString);
		bool flag = gameObject == null;
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}
}
