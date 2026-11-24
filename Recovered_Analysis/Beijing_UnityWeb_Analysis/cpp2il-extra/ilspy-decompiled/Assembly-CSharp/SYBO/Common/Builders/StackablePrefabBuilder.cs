using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Data;
using SYBO.Common.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders.Worker;
using UnityEngine;

namespace SYBO.Common.Builders;

[Serializable]
public class StackablePrefabBuilder
{
	private static string _STACKABLE_PREFAB_BUILDER_NAME;

	private StackablePrefabData _stackablePrefabData;

	public StackablePrefabData StackablePrefabData
	{
		get
		{
			//IL_001f: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Builders.StackablePrefabBuilder)+10]");
			bool flag = (nint)0 != 0;
			return (StackablePrefabData)flag;
		}
	}

	public StackablePrefabBuilder(StackablePrefabData stackablePrefabData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = stackablePrefabData & 1;
	}

	public GameObject BuildAndAttach(GameObject parentGameObject, Vector3 startWorldPosition, Vector3 endWorldPosition)
	{
		//IL_0017: Expected Obj, but got I4
		//IL_0017: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I4
		return (GameObject)((RouteChunk)this).CreateEnvironmentBase((int)parentGameObject, (EnvironmentBaseKind)startWorldPosition, (EnvironmentBaseKind)endWorldPosition, (EnvironmentKind)int.MaxValue);
	}

	private unsafe void BuildZDirection(GameObject stackablePrefabBuilder, Vector3 startWorldPosition, Vector3 endWorldPosition, GameObject startPrefab, GameObject midPrefab, GameObject endPrefab)
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got F4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected I4, but got Unknown
		//IL_0301: Expected I4, but got Obj
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected I4, but got Unknown
		//IL_0329: Expected I4, but got Obj
		//IL_0363: Expected I4, but got Obj
		//IL_037a: Expected VT, but got I4
		//IL_037a: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got F4
		//IL_0071: Expected I, but got F4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0213: Expected I4, but got Obj
		//IL_022a: Expected I4, but got Obj
		//IL_0244: Expected VT, but got I4
		//IL_0244: Expected VT, but got I4
		//IL_0274: Expected I4, but got Obj
		//IL_0293: Expected VT, but got I4
		//IL_0293: Expected Obj, but got I4
		//IL_00e3: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 60;
		obj3 = stackablePrefabBuilder;
		_ = ((UnityEngine.Object)stackablePrefabBuilder).m_CachedPtr;
		object obj4 = obj2 + 48;
		obj4 = startWorldPosition.x;
		_ = startWorldPosition.z;
		object obj5 = obj2 + 36;
		obj5 = startPrefab;
		_ = ((UnityEngine.Object)startPrefab).m_CachedPtr;
		object obj6 = obj2 + 24;
		obj6 = midPrefab;
		_ = ((UnityEngine.Object)midPrefab).m_CachedPtr;
		nint num = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v72 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RouteChunk routeChunk = (RouteChunk)(obj2 + 84);
		routeChunk = (RouteChunk)obj3;
		RouteChunk routeChunk2 = routeChunk;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((UnityEngine.Object)routeChunk2).m_CachedPtr = (IntPtr)0;
		IEnumerator enumerator = (IEnumerator)(obj2 + 96);
		enumerator = (IEnumerator)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		RouteBuilderWorker.WorkType workType = (RouteBuilderWorker.WorkType)(obj2 + 108);
		((RouteBuilderWorker.WorkType*)(int)workType)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18+8]");
		_ = 0;
		bool flag = (byte)(obj2 + 120) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj6 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21+8]");
		_ = 0;
		((RouteBuilderWorker)this).EnqueueWork(routeChunk, enumerator, workType, flag);
		int layer = ((GameObject)this).layer;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)endPrefab != 0;
		_ = ((UnityEngine.Object)endPrefab).m_CachedPtr;
		Vector3 vector = ((Transform)layer).InverseTransformPoint((Vector3)flag);
		routeChunk = (RouteChunk)endWorldPosition.x;
		((UnityEngine.Object)routeChunk).m_CachedPtr = (IntPtr)endWorldPosition.z;
		object obj8 = obj2 + 12;
		obj8 = enumerator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v32 (System.Collections.IEnumerator)+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v53 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v68 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((RouteBuilderWorker.WorkType*)(int)workType)->value__ = (int)routeChunk;
		_ = ((UnityEngine.Object)routeChunk).m_CachedPtr;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj8 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v50+8]");
		_ = 0;
		Quaternion quaternion = Quaternion.FromToRotation((Vector3)workType, (Vector3)flag);
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		int layer2 = ((GameObject)this).layer;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		((Transform)layer2).Rotate((Vector3)flag, Space.World);
	}

	private unsafe void BuildYDirection(GameObject stackablePrefabBuilder, Vector3 startWorldPosition, Vector3 endWorldPosition, GameObject startPrefab, GameObject midPrefab, GameObject endPrefab)
	{
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got Unknown
		//IL_0845: Expected Obj, but got I4
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_086c: Expected Obj, but got F4
		//IL_087e: Expected I, but got F4
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected Obj, but got Unknown
		//IL_0899: Expected Obj, but got F4
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_08ba: Expected Obj, but got I4
		//IL_08d1: Expected Obj, but got F4
		//IL_08e5: Expected I, but got F4
		//IL_08f3: Expected I, but got Obj
		//IL_0909: Expected Obj, but got I
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Expected Obj, but got Unknown
		//IL_0edc: Expected I, but got Obj
		//IL_0ef2: Expected Obj, but got I
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected VT, but got Unknown
		//IL_0941: Expected F4, but got Obj
		//IL_093c: Expected native int or pointer, but got VT
		//IL_0953: Expected F4, but got I
		//IL_094e: Expected native int or pointer, but got VT
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected VT, but got Unknown
		//IL_096e: Expected F4, but got Obj
		//IL_0969: Expected native int or pointer, but got VT
		//IL_0980: Expected F4, but got I
		//IL_097b: Expected native int or pointer, but got VT
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Obj, but got Unknown
		//IL_09bd: Expected Obj, but got F4
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected Obj, but got Unknown
		//IL_09de: Expected Obj, but got I4
		//IL_09ed: Expected Obj, but got F4
		//IL_0a07: Expected I, but got Obj
		//IL_0a1d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0a47: Expected F4, but got Obj
		//IL_0a42: Expected native int or pointer, but got VT
		//IL_0a5c: Expected F4, but got I
		//IL_0a57: Expected native int or pointer, but got VT
		//IL_0a69: Expected F4, but got Obj
		//IL_0a64: Expected native int or pointer, but got VT
		//IL_0a7e: Expected F4, but got I
		//IL_0a79: Expected native int or pointer, but got VT
		//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected Obj, but got Unknown
		//IL_0aaa: Expected F4, but got Obj
		//IL_0aa5: Expected native int or pointer, but got VT
		//IL_0abf: Expected F4, but got I
		//IL_0aba: Expected native int or pointer, but got VT
		//IL_0ac8: Expected Obj, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_010b: Expected VT, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0161: Expected Obj, but got VT
		//IL_016e: Expected Obj, but got F4
		//IL_01ae: Expected Obj, but got I
		//IL_01cb: Invalid comparison between Obj and F4
		//IL_0ca1: Expected I, but got Obj
		//IL_0cb7: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got F4
		//IL_021e: Expected I, but got F4
		//IL_022c: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I
		//IL_0af5: Expected I, but got Obj
		//IL_0b0b: Expected Obj, but got I
		//IL_042d: Expected I, but got Obj
		//IL_0b35: Expected F4, but got Obj
		//IL_0b30: Expected native int or pointer, but got VT
		//IL_0b47: Expected F4, but got I
		//IL_0b42: Expected native int or pointer, but got VT
		//IL_0b54: Expected F4, but got Obj
		//IL_0b4f: Expected native int or pointer, but got VT
		//IL_0b69: Expected F4, but got I
		//IL_0b64: Expected native int or pointer, but got VT
		//IL_0b98: Expected Obj, but got F4
		//IL_0baa: Expected I, but got F4
		//IL_0bc0: Expected Obj, but got I
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Expected Obj, but got Unknown
		//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected Obj, but got Unknown
		//IL_026d: Expected I, but got Obj
		//IL_047a: Expected I, but got Obj
		//IL_0490: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got F4
		//IL_0351: Expected Obj, but got I
		//IL_0364: Expected I, but got Obj
		//IL_037a: Expected Obj, but got I
		//IL_02ba: Expected I, but got Obj
		//IL_0c0d: Expected F4, but got Obj
		//IL_0c08: Expected native int or pointer, but got VT
		//IL_0c1f: Expected F4, but got I
		//IL_0c1a: Expected native int or pointer, but got VT
		//IL_0c2c: Expected F4, but got Obj
		//IL_0c27: Expected native int or pointer, but got VT
		//IL_0c41: Expected F4, but got I
		//IL_0c3c: Expected native int or pointer, but got VT
		//IL_0c5f: Expected F4, but got Obj
		//IL_0c5a: Expected native int or pointer, but got VT
		//IL_0c74: Expected F4, but got I
		//IL_0c6f: Expected native int or pointer, but got VT
		//IL_0c7d: Expected Obj, but got VT
		//IL_04bb: Expected I, but got Obj
		//IL_0403: Expected VT, but got I4
		//IL_0403: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got I4
		//IL_03a5: Expected I, but got Obj
		//IL_0514: Expected VT, but got I4
		//IL_0514: Expected Obj, but got VT
		//IL_0533: Expected VT, but got I4
		//IL_0533: Expected Obj, but got VT
		//IL_05aa: Expected F4, but got I4
		//IL_0e98: Invalid comparison between F4 and I
		//IL_05b8: Expected Obj, but got I4
		//IL_05cf: Expected Obj, but got F4
		//IL_05e3: Expected I, but got F4
		//IL_05f1: Expected I, but got Obj
		//IL_0607: Expected Obj, but got I
		//IL_0d17: Expected I, but got Obj
		//IL_0d2d: Expected Obj, but got I
		//IL_0d57: Expected F4, but got Obj
		//IL_0d52: Expected native int or pointer, but got VT
		//IL_0d69: Expected F4, but got I
		//IL_0d64: Expected native int or pointer, but got VT
		//IL_0d76: Expected F4, but got Obj
		//IL_0d71: Expected native int or pointer, but got VT
		//IL_0d8b: Expected F4, but got I
		//IL_0d86: Expected native int or pointer, but got VT
		//IL_0632: Expected I, but got Obj
		//IL_06cb: Expected VT, but got I4
		//IL_067f: Expected I, but got Obj
		//IL_0721: Expected Obj, but got I4
		//IL_0730: Expected Obj, but got F4
		//IL_0751: Expected I, but got Obj
		//IL_0767: Expected Obj, but got I
		//IL_0ddc: Expected F4, but got Obj
		//IL_0dd7: Expected native int or pointer, but got VT
		//IL_0df1: Expected F4, but got I
		//IL_0dec: Expected native int or pointer, but got VT
		//IL_0e0f: Expected F4, but got Obj
		//IL_0e0a: Expected native int or pointer, but got VT
		//IL_0e21: Expected F4, but got I
		//IL_0e1c: Expected native int or pointer, but got VT
		//IL_0e2e: Expected F4, but got Obj
		//IL_0e29: Expected native int or pointer, but got VT
		//IL_0e43: Expected F4, but got I
		//IL_0e3e: Expected native int or pointer, but got VT
		//IL_0e61: Expected F4, but got Obj
		//IL_0e5c: Expected native int or pointer, but got VT
		//IL_0e76: Expected F4, but got I
		//IL_0e71: Expected native int or pointer, but got VT
		//IL_0e7f: Expected Obj, but got VT
		//IL_0792: Expected I, but got Obj
		//IL_0802: Expected VT, but got I4
		//IL_0802: Expected Obj, but got I4
		//IL_0802: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 128;
		obj = 0;
		_ = 0;
		_ = 0;
		Renderer renderer = (Renderer)(obj2 + 104);
		renderer = (Renderer)endWorldPosition.x;
		((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)endWorldPosition.z;
		object obj3 = obj2 + 88;
		obj3 = startWorldPosition.x;
		_ = startWorldPosition.z;
		Transform transform = (Transform)(obj2 + 72);
		transform = (Transform)0;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		transform = (Transform)0f;
		_ = 0f;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0f;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v13 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v136 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Renderer renderer2 = (Renderer)(obj2 + 48);
		Vector2 zero = Vector2.zero;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S2_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v132 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 152);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj2 + 168);
		((Vector3*)(nint)vector2)->x = (float)renderer2;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)renderer2).m_CachedPtr;
		GameObject gameObject = UnityEngine.Object.Instantiate(startPrefab, vector, (Quaternion)vector2);
		int layer = gameObject.layer;
		object obj6 = obj2 + 36;
		obj6 = startWorldPosition.x;
		_ = startWorldPosition.z;
		object obj7 = obj2 + 24;
		obj7 = 0;
		_ = 0;
		obj7 = 0f;
		_ = 0f;
		_ = 0f;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S3_v33 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S3_v79 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S3_v24+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector4 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S3_v27+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj9 = obj2 + 12;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Vector3 vector5 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S3_v42+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		Vector3 localPosition = ((Transform)vector2).localPosition;
		int layer2 = gameObject.layer;
		int layer3 = stackablePrefabBuilder.layer;
		HierarchyUtility.Reparent((Transform)layer2, (Transform)layer3, (Vector3)1);
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S5_v5 (Il2CppMethodInfo)+18]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v214 @ S6_v5 (should have been resolved before IL gen)");
		Material material = default;
		((Renderer)vector2).SetMaterial(material);
		obj = vector2.x;
		_ = vector2.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v30 (UnityEngine.Vector3)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		IntPtr cachedPtr = ((UnityEngine.Object)renderer).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13+8]");
		object obj14 = (nint)cachedPtr - 0;
		float num8 = vector.z * 2f;
		ComputeShader computeShader;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num8))
		{
			renderer = (Renderer)0;
			((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)0;
			renderer = (Renderer)0f;
			_ = 0f;
			((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)0f;
			nint num9 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v107 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num10 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v132 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero2 = Vector2.zero;
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v113 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v128 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)renderer;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)renderer).m_CachedPtr;
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Vector3 vector6 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			GameObject gameObject2 = UnityEngine.Object.Instantiate(endPrefab, vector, (Quaternion)vector2);
			int layer4 = gameObject2.layer;
			transform = (Transform)endWorldPosition.x;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)endWorldPosition.z;
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S4_v40 (Il2CppMethodInfo)+18]");
			object obj17 = 0;
			object obj18 = obj17;
			object obj19 = obj18 & 0x1FFF;
			object obj20 = obj19 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v273 @ S5_v12 (should have been resolved before IL gen)");
			Material material2 = default;
			renderer2.SetMaterial(material2);
			obj = renderer2;
			_ = ((UnityEngine.Object)renderer2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S2_v18 (UnityEngine.Renderer)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			obj7 = 0;
			_ = 0;
			obj7 = 0f;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S3_v24+8]");
			object obj21 = -0;
			nint num14 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v131 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num15 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S1_v146 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)transform;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector2)->x = (float)obj7;
			Vector3 vector7 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S3_v27+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			Vector3 vector8 = vector - vector2;
			((Vector3*)(nint)vector2)->x = (float)obj9;
			Vector3 vector9 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S3_v42+8]");
			((Vector3*)(nint)vector9)->z = 0f;
			Vector3 localPosition2 = ((Transform)vector2).localPosition;
			int layer5 = gameObject2.layer;
			int layer6 = stackablePrefabBuilder.layer;
			HierarchyUtility.Reparent((Transform)layer5, (Transform)layer6, (Vector3)1);
			computeShader = (ComputeShader)(object)gameObject2;
		}
		else
		{
			computeShader = null;
		}
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v96 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)midPrefab).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num18 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) == 0)
		{
			return;
		}
		int layer7 = ((GameObject)(object)computeShader).layer;
		((Transform)vector2).position = (Vector3)layer7;
		int layer8 = gameObject.layer;
		((Transform)vector).position = (Vector3)layer8;
		float num20 = vector2.z - vector.z;
		Renderer component = midPrefab.GetComponent<Renderer>();
		renderer.SetMaterial((Material)(object)component);
		obj = renderer;
		_ = ((UnityEngine.Object)renderer).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (UnityEngine.Renderer)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		float num21 = num20;
		float num22 = 0f;
		while (true)
		{
			float num23 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13+8]");
			if (!(num23 > 0f))
			{
				break;
			}
			renderer = (Renderer)0;
			((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)0;
			renderer = (Renderer)0f;
			_ = 0f;
			((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)0f;
			nint num24 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v59 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num25 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S0_v88 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero3 = Vector2.zero;
			nint num26 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num27 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v84 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)renderer;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)renderer).m_CachedPtr;
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Vector3 vector10 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			float num28 = num22 + 1f;
			GameObject gameObject3 = UnityEngine.Object.Instantiate(midPrefab, vector, (Quaternion)vector2);
			int layer9 = gameObject3.layer;
			int layer10 = gameObject.layer;
			transform.position = (Vector3)layer10;
			Renderer component2 = gameObject3.GetComponent<Renderer>();
			renderer2.SetMaterial((Material)(object)component2);
			obj = renderer2;
			_ = ((UnityEngine.Object)renderer2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S2_v18 (UnityEngine.Renderer)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			obj7 = 0;
			_ = 0;
			obj7 = 0f;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S3_v24+8]");
			_ = 0;
			nint num29 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ S1_v75 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num30 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S1_v94 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj7;
			Vector3 vector11 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S3_v27+8]");
			((Vector3*)(nint)vector11)->z = 0f;
			Quaternion quaternion2 = Quaternion.AngleAxis(num28, vector2);
			((Vector3*)(nint)vector)->x = (float)transform;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector2)->x = (float)obj9;
			Vector3 vector12 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S3_v42+8]");
			((Vector3*)(nint)vector12)->z = 0f;
			Vector3 vector13 = vector - vector2;
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Vector3 vector14 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector14)->z = 0f;
			Vector3 localPosition3 = ((Transform)vector2).localPosition;
			int layer11 = gameObject3.layer;
			int layer12 = stackablePrefabBuilder.layer;
			HierarchyUtility.Reparent((Transform)layer11, (Transform)layer12, (Vector3)1);
			float num31 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13+8]");
			float num32 = num31 - 0f;
			num21 = num32;
			num22 = num28;
		}
	}

	static StackablePrefabBuilder()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		uint[] array = default;
		object obj = array + 20;
		obj = -1727483681;
		MTRandomGen.MAG01 = array;
	}
}
