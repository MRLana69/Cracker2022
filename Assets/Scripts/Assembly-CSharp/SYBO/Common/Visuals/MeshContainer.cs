using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class MeshContainer : SingletonMonobehavior<MeshContainer>
{
	private Dictionary<Mesh, ModelInfo> _combinedMeshes;

	private Dictionary<Mesh, Action<ModelInfo>> _combinedMeshCallbacks;

	private Dictionary<CombineableMeshGroup, ModelInfo> _combinedMeshesGroups;

	private Dictionary<CombineableMeshGroup, Action<ModelInfo>> _combinedMeshGroupCallbacks;

	protected override void Initialize()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
	}

	public unsafe void AddMesh(Mesh originalMesh, ModelInfo combinedMeshInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Ref, but got Unknown
		//IL_0023: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Mesh, SYBO.Common.Utilities.ModelInfo>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S5_v4+4] (should have been resolved before IL gen)");
		if (_combinedMeshCallbacks.TryGetValue(originalMesh, out *(Action<ModelInfo>*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S0_v18+C] (should have been resolved before IL gen)");
			}
			bool flag = _combinedMeshCallbacks.Remove(originalMesh);
		}
	}

	public void RemoveMesh(Mesh originalMesh)
	{
		bool flag = _combinedMeshes.Remove(originalMesh);
	}

	public bool TryGetMesh(Mesh originalMesh, out ModelInfo combinedMeshInfo)
	{
		return _combinedMeshes.TryGetValue(originalMesh, out combinedMeshInfo);
	}

	public bool HasCombinedMesh(Mesh originalMesh)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Mesh, SYBO.Common.Utilities.ModelInfo>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public void NotifyMeshCombineInProgress(Mesh mesh)
	{
		//IL_004c: Expected Obj, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Mesh, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 == null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Mesh, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S5_v5+4] (should have been resolved before IL gen)");
		}
	}

	public unsafe void NotifyMeshCombineFailed(Mesh mesh)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Ref, but got Unknown
		//IL_0023: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_combinedMeshCallbacks.TryGetValue(mesh, out *(Action<ModelInfo>*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S0_v16+C] (should have been resolved before IL gen)");
			}
		}
	}

	public bool IsMeshCombineInProgress(Mesh mesh)
	{
		//IL_0076: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0055: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Mesh, SYBO.Common.Utilities.ModelInfo>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return false;
		}
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Mesh, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>)+54]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S3_v10+4] (should have been resolved before IL gen)");
		object obj7 = default;
		object obj6 = obj7 ^ -1;
		return (byte)(obj6 >> 31) != 0;
	}

	public unsafe void AddMeshGroupCombinedCallback(Mesh mesh, Action<ModelInfo> meshReceiveCallback)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Ref, but got Unknown
		//IL_00ca: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_combinedMeshCallbacks.TryGetValue(mesh, out *(Action<ModelInfo>*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				Action<ModelInfo> b = default;
				Delegate obj3 = Delegate.Combine((Delegate)0, b);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			}
		}
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Mesh, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	public unsafe void RemoveMeshCombinedCallback(Mesh mesh, Action<ModelInfo> meshReceiveCallback)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Ref, but got Unknown
		//IL_004d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_combinedMeshCallbacks.TryGetValue(mesh, out *(Action<ModelInfo>*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				Delegate obj3 = Delegate.Remove((Delegate)0, meshReceiveCallback);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			}
		}
	}

	public unsafe void AddGroup(CombineableMeshGroup combineableMeshGroup, ModelInfo combinedMeshInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Ref, but got Unknown
		//IL_002f: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, SYBO.Common.Utilities.ModelInfo>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 == null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, SYBO.Common.Utilities.ModelInfo>>)+5C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		if (_combinedMeshGroupCallbacks.TryGetValue(combineableMeshGroup, out *(Action<ModelInfo>*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S0_v22+C] (should have been resolved before IL gen)");
			}
			bool flag = _combinedMeshGroupCallbacks.Remove(combineableMeshGroup);
		}
	}

	public void RemoveGroup(CombineableMeshGroup combineableMeshGroup)
	{
		bool flag = _combinedMeshesGroups.Remove(combineableMeshGroup);
	}

	public bool TryGetGroupMesh(CombineableMeshGroup combineableMeshGroup, out ModelInfo combinedMeshInfo)
	{
		return _combinedMeshesGroups.TryGetValue(combineableMeshGroup, out combinedMeshInfo);
	}

	public bool HasGroupMesh(CombineableMeshGroup combineableMeshGroup)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, SYBO.Common.Utilities.ModelInfo>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public void NotifyMeshGroupCombineInProgress(CombineableMeshGroup meshGroup)
	{
		//IL_004c: Expected Obj, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 == null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S5_v5+4] (should have been resolved before IL gen)");
		}
	}

	public unsafe void NotifyMeshGroupCombineCanceled(CombineableMeshGroup meshGroup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Ref, but got Unknown
		//IL_0023: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_combinedMeshGroupCallbacks.TryGetValue(meshGroup, out *(Action<ModelInfo>*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S0_v16+C] (should have been resolved before IL gen)");
				bool flag = _combinedMeshGroupCallbacks.Remove(meshGroup);
			}
		}
	}

	public bool IsMeshGroupCombineInProgress(CombineableMeshGroup meshGroup)
	{
		//IL_0076: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0055: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, SYBO.Common.Utilities.ModelInfo>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return false;
		}
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>)+54]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S3_v10+4] (should have been resolved before IL gen)");
		object obj7 = default;
		object obj6 = obj7 ^ -1;
		return (byte)(obj6 >> 31) != 0;
	}

	public unsafe void AddMeshGroupCombinedCallback(CombineableMeshGroup meshGroup, Action<ModelInfo> meshReceiveCallback)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Ref, but got Unknown
		//IL_00ca: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_combinedMeshGroupCallbacks.TryGetValue(meshGroup, out *(Action<ModelInfo>*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				Action<ModelInfo> b = default;
				Delegate obj3 = Delegate.Combine((Delegate)0, b);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			}
		}
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	public unsafe void RemoveMeshGroupCombinedCallback(CombineableMeshGroup meshGroup, Action<ModelInfo> meshReceiveCallback)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Ref, but got Unknown
		//IL_004d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_combinedMeshGroupCallbacks.TryGetValue(meshGroup, out *(Action<ModelInfo>*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				Delegate obj3 = Delegate.Remove((Delegate)0, meshReceiveCallback);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			}
		}
	}

	public MeshContainer()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Mesh, SYBO.Common.Utilities.ModelInfo>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Mesh, ModelInfo> combinedMeshes = default;
		_combinedMeshes = combinedMeshes;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Mesh, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Mesh, Action<ModelInfo>> combinedMeshCallbacks = default;
		_combinedMeshCallbacks = combinedMeshCallbacks;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S4_v14 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, SYBO.Common.Utilities.ModelInfo>>>)+4] (should have been resolved before IL gen)");
		Dictionary<CombineableMeshGroup, ModelInfo> combinedMeshesGroups = default;
		_combinedMeshesGroups = combinedMeshesGroups;
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S4_v19 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Common.Visuals.CombineableMeshGroup, System.Action`1<SYBO.Common.Utilities.ModelInfo>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<CombineableMeshGroup, Action<ModelInfo>> combinedMeshGroupCallbacks = default;
		_combinedMeshGroupCallbacks = combinedMeshGroupCallbacks;
		base._002Ector();
	}
}
