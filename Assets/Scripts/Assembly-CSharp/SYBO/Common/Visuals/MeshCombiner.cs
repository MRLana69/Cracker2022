using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

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
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal unsafe int _003CSortCombineableMeshes_003Eb__12_0(ComponentPositionWrapper<CombineableMesh> x, ComponentPositionWrapper<CombineableMesh> y)
		{
			//IL_0025: Expected F4, but got I
			//IL_0025: Expected Ref, but got F4
			float num = (float)x + 12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [y @ L2 (SYBO.Common.Utilities.ComponentPositionWrapper`1<SYBO.Common.Visuals.CombineableMesh>)+C]");
			return ((float*)num)->CompareTo(0f);
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
		InitializeCheck();
	}

	private void InitializeCheck()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			GameObject gameObject = default;
			gameObject._002Ector("combinedMeshes");
			Transform combinedMeshRootTransform = gameObject.transform;
			_combinedMeshRootTransform = combinedMeshRootTransform;
			Transform parent = transform;
			_combinedMeshRootTransform.parent = parent;
			GameObjectUtil.ResetLocalPosition(_combinedMeshRootTransform);
			_initialized = true;
		}
	}

	public void CombineInactive()
	{
		InitializeCheck();
		Combine(combineInactive: true);
	}

	public void Combine()
	{
		InitializeCheck();
		Combine(combineInactive: false);
	}

	public void DestroyCombined()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00e2: Expected VT, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			return;
		}
		if (combineableMeshes != null)
		{
			object obj = this + 16;
			object obj2 = 0;
			CombineableMesh[] array = combineableMeshes;
			while (array.Length > (nint)obj2)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v55+10]");
				MeshRenderer meshRenderer = ((CombineableMesh)0).MeshRenderer;
				meshRenderer.enabled = true;
				object obj5 = obj2 + 1;
				obj2 = obj5;
				array = (CombineableMesh[])obj;
			}
			obj = 0;
		}
		int num = 0;
		while (true)
		{
			int childCount = _combinedMeshRootTransform.childCount;
			if (childCount <= num)
			{
				break;
			}
			Transform child = _combinedMeshRootTransform.GetChild(num);
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshFilter));
			Component component = child.GetComponent(typeFromHandle);
			bool flag = (object)component == null;
			Component component2 = null;
			if (!flag)
			{
				bool flag2 = (object)component.GetType() == typeof(MeshFilter);
				component2 = component;
				if (!flag2)
				{
					component2 = null;
				}
			}
			if (component2 != null)
			{
				Mesh mesh = ((MeshFilter)component2).mesh;
				UnityEngine.Object.Destroy(mesh);
				((MeshFilter)component2).mesh = null;
			}
			int num2 = num + 1;
			num = num2;
		}
	}

	private void Combine(bool combineInactive)
	{
		//IL_0261: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected I4, but got Unknown
		//IL_02e9: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I4
		//IL_02fb: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I4
		InitializeCheck();
		CombineableMesh[] componentsInChildren = GetComponentsInChildren<CombineableMesh>(combineInactive);
		combineableMeshes = componentsInChildren;
		int num = 0;
		object obj = 0;
		while (true)
		{
			CombineableMesh[] array = combineableMeshes;
			if (array.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v62+10]");
			MeshFilter meshFilter = ((CombineableMesh)0).MeshFilter;
			Mesh sharedMesh = meshFilter.sharedMesh;
			int vertexCount = sharedMesh.vertexCount;
			int num2 = vertexCount + num;
			object obj4 = obj + 1;
			num = num2;
			obj = obj4;
		}
		if (num >= 65535)
		{
			SortCombineableMeshes();
		}
		bool flag = num < 65534;
		int capacity = num;
		if (!flag)
		{
			capacity = 65534;
		}
		List<ObjectModelInfo> list = default;
		list._002Ector(capacity);
		int num3 = num / 65534;
		object obj5 = num3 + 1;
		int num4 = num / obj5;
		CombineableMesh[] array2 = combineableMeshes;
		object obj6 = array2.Length - 1;
		object obj7 = 0;
		object obj8 = 0;
		ObjectModelInfo objectModelInfo = default;
		while (true)
		{
			CombineableMesh[] array3 = combineableMeshes;
			if (array3.Length > (nint)obj8)
			{
				object obj9 = obj8 << 2;
				object obj10 = (object)array3 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v34+10]");
				MeshRenderer meshRenderer = ((CombineableMesh)0).MeshRenderer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v34+10]");
				MeshFilter meshFilter2 = ((CombineableMesh)0).MeshFilter;
				objectModelInfo.MeshRenderer = meshRenderer;
				objectModelInfo.MeshFilter = meshFilter2;
				list.Add(objectModelInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v34+10]");
				MeshFilter meshFilter3 = ((CombineableMesh)0).MeshFilter;
				Mesh mesh = meshFilter3.mesh;
				int vertexCount2 = mesh.vertexCount;
				object obj11 = vertexCount2 + obj7;
				bool flag2 = (nint)obj11 <= num4;
				if (obj8 == obj6)
				{
					flag2 = false;
				}
				bool flag3 = !flag2;
				bool flag4 = !flag3;
				obj7 = obj11;
				if (!flag4)
				{
					GameObject combinedMeshGO = GetCombinedMeshGO();
					Combine(combinedMeshGO, list);
					int combinedMeshesCount = _combinedMeshesCount + 1;
					_combinedMeshesCount = combinedMeshesCount;
					((List<T>)(object)list).Clear();
					obj7 = 0;
				}
				object obj12 = obj8 + 1;
				obj8 = obj12;
				continue;
			}
			break;
		}
	}

	private unsafe void SortCombineableMeshes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_005d: Expected Obj, but got I
		//IL_0058: Expected native int or pointer, but got VT
		//IL_007a: Expected Obj, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		CombineableMesh[] array = combineableMeshes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = 0;
		_0021_00210[] array3 = default;
		while (true)
		{
			CombineableMesh[] array2 = combineableMeshes;
			if (array2.Length <= (nint)obj3)
			{
				break;
			}
			object obj4 = obj3 << 2;
			object obj5 = (object)array2 + obj4;
			_ = 0;
			_ = 0;
			ComponentPositionWrapper<> componentPositionWrapper = (ComponentPositionWrapper<>)(obj + 16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v54+10]");
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)componentPositionWrapper, new ComponentPositionWrapper<>((T)0));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			object obj6 = obj3 << 4;
			object obj7 = (object)array3 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		bool flag = _003C_003Ec._003C_003E9__12_0 == null;
		bool flag2 = !flag;
		Comparison<_0021_00210> comparison = (Comparison<_0021_00210>)(object)_003C_003Ec._003C_003E9__12_0;
		if (!flag2)
		{
			Comparison<> comparison2 = default;
			((Comparison<T>)(object)comparison2)._002Ector((object)_003C_003Ec._003C_003E9, (IntPtr)(nint)__ldftn(_003C_003Ec._003CSortCombineableMeshes_003Eb__12_0));
			_003C_003Ec._003C_003E9__12_0 = (Comparison<ComponentPositionWrapper<CombineableMesh>>)(object)comparison2;
			comparison = (Comparison<_0021_00210>)(object)comparison2;
		}
		Array.Sort<T>((T[])(object)array3, (Comparison<T>)(object)comparison);
		object obj9 = 0;
		if (array3.Length > (nint)obj9)
		{
			object obj10 = obj9 << 4;
			object obj11 = (object)array3 + obj10;
			throw new ArrayTypeMismatchException();
		}
	}

	private unsafe GameObject GetCombinedMeshGO()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int childCount = _combinedMeshRootTransform.childCount;
		if (childCount <= _combinedMeshesCount)
		{
			int childCount2 = _combinedMeshRootTransform.childCount;
			object obj3 = childCount2 + 1;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			string text2 = "combinedMeshes_" + text;
			GameObject gameObject = default;
			gameObject._002Ector(text2);
			Transform transform = gameObject.transform;
			transform.parent = _combinedMeshRootTransform;
			GameObjectUtil.ResetLocalPosition(transform);
			return transform.gameObject;
		}
		int index = _combinedMeshesCount - 1;
		Transform child = _combinedMeshRootTransform.GetChild(index);
		return child.gameObject;
	}

	private void Combine(GameObject combinedMeshAssignGO, IList<ObjectModelInfo> meshInfos)
	{
		//IL_0041: Expected Obj, but got I4
		//IL_0095: Expected VT, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_00cd: Expected VT, but got Obj
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		GameObject parentGO = gameObject;
		ModelInfo modelInfo = MeshUtil.CombineMeshes(parentGO, meshInfos);
		if (modelInfo == null)
		{
			return;
		}
		string text = name;
		string text2 = text + "_combinedMesh";
		modelInfo.Mesh.name = text2;
		object obj = 0;
		object obj2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v35+8]");
			((Renderer)0).enabled = false;
			object obj3 = obj + 1;
			obj = obj3;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshRenderer));
		Component component = GameObjectUtil.AddComponentIfMissing(combinedMeshAssignGO, typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshFilter));
		Component component2 = GameObjectUtil.AddComponentIfMissing(combinedMeshAssignGO, typeFromHandle2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
		bool flag = (object)component2 == null;
		MeshFilter meshFilter = null;
		if (!flag)
		{
			bool flag2 = (object)component2.GetType() == typeof(MeshFilter);
			meshFilter = (MeshFilter)component2;
			if (!flag2)
			{
				meshFilter = null;
			}
		}
		meshFilter.mesh = modelInfo.Mesh;
	}
}
