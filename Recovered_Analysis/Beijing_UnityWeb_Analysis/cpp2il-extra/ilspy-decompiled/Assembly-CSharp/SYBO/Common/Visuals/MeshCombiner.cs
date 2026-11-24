using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Analytics.Integration;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.U2D;

namespace SYBO.Common.Visuals;

public class MeshCombiner : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ComponentPositionWrapper<CombineableMesh>> _003C_003E9__12_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AnalyticsHelper._003C_003Ec obj = default;
			AnalyticsHelper._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal int _003CSortCombineableMeshes_003Eb__12_0(ComponentPositionWrapper<CombineableMesh> x, ComponentPositionWrapper<CombineableMesh> y)
		{
			//IL_0009: Expected Obj, but got VT
			UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)x);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text = default;
			return ((string)(object)obj != text) ? 1 : 0;
		}
	}

	private const int MAX_MESH_VERTEX_COUNT = 65534;

	private const int MAX_BATCH_VERTEX_COUNT = 65534;

	private bool _initialized;

	private CombineableMesh[] combineableMeshes;

	private Transform _combinedMeshRootTransform;

	private int _combinedMeshesCount;

	private void Awake()
	{
		CancelInvoke();
	}

	private void InitializeCheck()
	{
		CombineInactive();
	}

	public void CombineInactive()
	{
		//IL_001d: Expected I4, but got Obj
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"combinedMeshes";
			object obj = this + 20;
			int layer = gameObject.layer;
			obj = layer;
			GameObject parentInternal = base.gameObject;
			_combinedMeshRootTransform.parentInternal = (Transform)(object)parentInternal;
			GameObjectUtil.ResetLocalRotation(_combinedMeshRootTransform);
			_initialized = true;
		}
	}

	public void Combine()
	{
		CombineInactive();
		((MeshMorpher)this).Animate = true;
	}

	public void DestroyCombined()
	{
		CombineInactive();
		((MeshMorpher)this).Animate = false;
	}

	private void Combine(bool combineInactive)
	{
		//IL_001c: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I4
		//IL_006d: Expected I4, but got Obj
		//IL_008b: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I
		if (combineInactive)
		{
			int combinedMeshesCount = _combinedMeshesCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [combineInactive @ L1 (System.Boolean)+8]");
			((SkinnedMeshRenderer)combinedMeshesCount).sharedMesh = (Mesh)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Visuals.MeshCombiner)+20]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)combineableMeshes);
				string text = string.ConcatArray((string[])(object)values, (int)"_combined");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [combineInactive @ L1 (System.Boolean)+8]");
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0, (byte)(int)text != 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Visuals.MeshCombiner)+1C]");
				((MeshContainer)0).AddMeshGroupCombinedCallback((Mesh)(object)combineableMeshes, (Action<ModelInfo>)combineInactive);
				_ = 0;
			}
		}
	}

	private unsafe void SortCombineableMeshes()
	{
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected I, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_030a: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_0130: Expected I, but got Obj
		//IL_03c9: Expected I, but got Obj
		//IL_03df: Expected Obj, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_01c8: Expected I, but got Obj
		//IL_0210: Expected I4, but got Obj
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I4
		//IL_0263: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		if (~(_initialized ? 1u : 0u) != 0)
		{
			return;
		}
		if (combineableMeshes != null)
		{
			object obj2 = default;
			object obj6 = default;
			while (true)
			{
				CombineableMesh[] array = combineableMeshes;
				if ((nint)obj2 >= array.Length)
				{
					break;
				}
				object obj3 = combineableMeshes + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				MeshFilter meshFilter = ((CombineableMesh)obj5).MeshFilter;
				((Renderer)(object)meshFilter).shadowCastingMode = ShadowCastingMode.On;
				obj2 = obj6 + 1;
			}
			object obj7 = this + 16;
			obj7 = 0;
		}
		Sprite sprite = null;
		while (true)
		{
			int siblingIndex = _combinedMeshRootTransform.GetSiblingIndex();
			if ((nint)sprite >= siblingIndex)
			{
				break;
			}
			bool flag = ((SpriteAtlas)(object)_combinedMeshRootTransform).CanBindTo(sprite);
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v14 (Il2CppClass<System.Type>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v40 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(MeshFilter);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type t = Type.internal_from_handle((IntPtr)num);
			Component component = ((Component)flag).GetComponentInParent(t);
			if ((object)component != null)
			{
				if ((object)component.GetType() != typeof(MeshFilter))
				{
					component = null;
				}
			}
			else
			{
				component = null;
			}
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				bool flag2 = GraphicsFormatUtility.IsSRGBFormat((GraphicsFormat)component);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)flag2);
				((SkinnedMeshRenderer)component).sharedMesh = null;
			}
			Sprite sprite2 = (Sprite)(sprite + 1);
			sprite = sprite2;
		}
	}

	private GameObject GetCombinedMeshGO()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I4
		((CombineableMesh)this).MergeSubmeshes();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		object obj = gameObject + 8;
		obj = _combinedMeshRootTransform;
		object obj2 = gameObject + 12;
		obj2 = _combinedMeshesCount;
		return gameObject;
	}

	private void Combine(GameObject combinedMeshAssignGO, IList<ObjectModelInfo> meshInfos)
	{
		//IL_001c: Expected I4, but got Obj
		string text = (string)(object)combinedMeshAssignGO + "() " + (string)(object)meshInfos;
		if (~(_initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CombineableMesh._003CCombineMeshesAsync_003Ed__17 obj = default;
			obj._002Ector((int)text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	public unsafe MeshCombiner()
	{
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I4
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0039: Expected VT, but got I4
		//IL_003e: Expected native int or pointer, but got VT
		//IL_004b: Expected native int or pointer, but got VT
		//IL_0058: Expected Obj, but got VT
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_039d: Expected Obj, but got I4
		//IL_010a: Expected I, but got Obj
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0327: Expected I, but got Obj
		//IL_033d: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0198: Expected I, but got Obj
		ComponentPositionWrapper<CombineableMesh> componentPositionWrapper = default;
		object obj = componentPositionWrapper + 16;
		CombineableMesh[] array = combineableMeshes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = 0;
		ComponentPositionWrapper<CombineableMesh>[] array3 = default;
		while (true)
		{
			CombineableMesh[] array2 = combineableMeshes;
			if ((nint)obj2 >= array2.Length)
			{
				break;
			}
			object obj3 = combineableMeshes + 16;
			object obj4 = obj2 << 2;
			object component = obj3 + obj4;
			componentPositionWrapper = (ComponentPositionWrapper<CombineableMesh>)0;
			System.Runtime.CompilerServices.Unsafe.Write(&((ComponentPositionWrapper<CombineableMesh>*)(nint)componentPositionWrapper)->Component, null);
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)componentPositionWrapper, new ComponentPositionWrapper<CombineableMesh>((CombineableMesh)component));
			obj = componentPositionWrapper;
			_ = componentPositionWrapper.Component;
			object obj5 = array3 + 16;
			object obj6 = obj2 << 4;
			object obj7 = obj5 + obj6;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj8 = obj2 + 1;
			obj2 = obj8;
		}
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v18 (Il2CppClass<SYBO.Common.Visuals.MeshCombiner+<>c>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v69 (Il2CppClass<SYBO.Common.Visuals.MeshCombiner+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__12_0 == null;
		bool flag2 = !flag;
		Comparison<ComponentPositionWrapper<CombineableMesh>> comparison = _003C_003Ec._003C_003E9__12_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v43 (Il2CppClass<SYBO.Common.Visuals.MeshCombiner+<>c>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v63 (Il2CppClass<SYBO.Common.Visuals.MeshCombiner+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Comparison<ComponentPositionWrapper<CombineableMesh>> comparison2 = default;
			object obj11 = comparison2 + 16;
			obj11 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v60 (Il2CppClass<SYBO.Common.Visuals.MeshCombiner+<>c>)+5C]");
			object obj12 = (nint)0 + (nint)4;
			obj12 = comparison2;
			comparison = comparison2;
		}
		Array.Sort(array3, comparison);
		object obj13 = array3 + 12;
		object obj14 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
		{
			object obj15 = array3 + 16;
			object obj16 = obj14 << 4;
			object obj17 = obj15 + obj16;
			throw new ArrayTypeMismatchException();
		}
	}
}
