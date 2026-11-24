using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Subway.Placeholders;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Common.Visuals;

public class AnimationPlaceholderInitializer : MonoBehaviour, IPlaceholderInitializer
{
	private AnimationInitializer.Config _config;

	public unsafe void Initialize(Placeholder parent, Transform spawnedObject)
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected I, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0200: Expected I4, but got Obj
		//IL_001d: Expected I4, but got Obj
		//IL_0038: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		//IL_0094: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I
		//IL_026d: Expected I, but got Obj
		//IL_0287: Expected VT, but got Obj
		//IL_0287: Expected VT, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0149: Expected VT, but got Obj
		//IL_0149: Expected VT, but got Obj
		//IL_00d5: Expected I, but got Obj
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		object obj = default;
		nint num = (nint)(obj + 8);
		object obj2 = obj + 4;
		string parentGO = tag;
		ModelInfo modelInfo = MeshUtil.CombineMeshes((GameObject)(object)parentGO, (byte)(int)spawnedObject != 0);
		if (modelInfo == null)
		{
			return;
		}
		UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		string text = string.ConcatArray((string[])(object)values, (int)"_combinedMesh");
		UnityEngine.Object.DestroyImmediate(modelInfo.Mesh, (byte)(int)text != 0);
		object obj3 = 0;
		object obj4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v53+8]");
			((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
			object obj5 = obj3 + 1;
			obj3 = obj5;
		}
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v26 (Il2CppClass<System.Type>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v48 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(MeshRenderer);
		((IntPtr*)num)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num);
		int num4 = GameObjectUtil.ComparePositionZ((Vector3)parent, (Vector3)type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		obj = typeof(MeshFilter);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type2 = Type.internal_from_handle((IntPtr)num);
		int num5 = GameObjectUtil.ComparePositionZ((Vector3)parent, (Vector3)type2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
		SkinnedMeshRenderer skinnedMeshRenderer;
		if (num5 != 0)
		{
			skinnedMeshRenderer = ((((int*)num5)->m_value != (nint)typeof(MeshFilter)) ? null : ((SkinnedMeshRenderer)num5));
		}
		else
		{
			skinnedMeshRenderer = null;
		}
		skinnedMeshRenderer.sharedMesh = modelInfo.Mesh;
	}

	public AnimationPlaceholderInitializer()
	{
		CancelInvoke();
	}
}
