using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class MeshContainer : SingletonMonoBehaviour<MeshContainer>
{
	private Dictionary<Mesh, ModelInfo> _combinedMeshes;

	private Dictionary<Mesh, Action<ModelInfo>> _combinedMeshCallbacks;

	private Dictionary<CombineableMeshGroup, ModelInfo> _combinedMeshesGroups;

	private Dictionary<CombineableMeshGroup, Action<ModelInfo>> _combinedMeshGroupCallbacks;

	protected override void SubclassInitialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void AddMesh(Mesh originalMesh, ModelInfo combinedMeshInfo)
	{
		//IL_0022: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got VT
		_0021_00210 componentInChildren = (_0021_00210)((Component)(object)combinedMeshInfo).GetComponentInChildren<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Visuals.MeshContainer)+C]");
		object obj = 0;
		ModelInfo modelInfo = (ModelInfo)(obj + 8);
		modelInfo = (ModelInfo)obj;
		((CombineableMesh)componentInChildren).UpdateToCombinedMesh(modelInfo);
	}

	public void RemoveMesh(Mesh originalMesh)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		Dictionary<CombineableMeshGroup, Action<ModelInfo>> combinedMeshGroupCallbacks = (Dictionary<CombineableMeshGroup, Action<ModelInfo>>)(originalMesh & 1);
		_combinedMeshGroupCallbacks = combinedMeshGroupCallbacks;
	}

	public unsafe bool TryGetMesh(Mesh originalMesh, out ModelInfo combinedMeshInfo)
	{
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected Obj, but got Unknown
		//IL_06ba: Expected Obj, but got I4
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected Obj, but got Unknown
		//IL_06d7: Expected Obj, but got I4
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got Unknown
		//IL_06f4: Expected Obj, but got I4
		//IL_0708: Expected I, but got Obj
		//IL_071e: Expected Obj, but got I
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected VT, but got Unknown
		//IL_0f5f: Expected Obj, but got F4
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f77: Expected VT, but got Unknown
		//IL_0f8d: Expected Obj, but got F4
		//IL_0fa5: Expected I, but got Obj
		//IL_0fbb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0fe1: Expected Obj, but got I4
		//IL_0ff4: Expected I, but got Obj
		//IL_100a: Expected Obj, but got I
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_0105: Expected I, but got Obj
		//IL_07fe: Expected Obj, but got I4
		//IL_081a: Expected I, but got Obj
		//IL_0830: Expected Obj, but got I
		//IL_07a2: Expected Obj, but got I
		//IL_07c2: Expected I, but got Obj
		//IL_07d8: Expected Obj, but got I
		//IL_018a: Expected I, but got Obj
		//IL_0121: Expected I, but got Obj
		//IL_0151: Expected I, but got Obj
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected VT, but got Unknown
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected VT, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected Obj, but got Unknown
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected Obj, but got Unknown
		//IL_09d4: Expected Obj, but got I4
		//IL_09e1: Expected F4, but got Obj
		//IL_09dc: Expected native int or pointer, but got VT
		//IL_09f3: Expected F4, but got I
		//IL_09ee: Expected native int or pointer, but got VT
		//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected Obj, but got Unknown
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected Obj, but got Unknown
		//IL_0a2a: Expected Obj, but got F4
		//IL_0a56: Expected Obj, but got I4
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected Obj, but got Unknown
		//IL_0a7a: Expected Obj, but got F4
		//IL_02ac: Expected Obj, but got I4
		//IL_0256: Expected I, but got Obj
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected Obj, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_0892: Expected F4, but got Obj
		//IL_088d: Expected native int or pointer, but got VT
		//IL_08a7: Expected F4, but got I
		//IL_08a2: Expected native int or pointer, but got VT
		//IL_08b4: Expected native int or pointer, but got VT
		//IL_08c6: Expected native int or pointer, but got VT
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got Unknown
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected Obj, but got Unknown
		//IL_0902: Expected Obj, but got F4
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected Obj, but got Unknown
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected Obj, but got Unknown
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected Obj, but got Unknown
		//IL_0177: Expected I, but got Obj
		//IL_0ebe: Expected I, but got Obj
		//IL_0ed4: Expected Obj, but got I
		//IL_01f0: Expected I, but got Obj
		//IL_0ad3: Expected Obj, but got I4
		//IL_05b3: Expected F4, but got Obj
		//IL_05ae: Expected native int or pointer, but got VT
		//IL_05c8: Expected F4, but got I
		//IL_05c3: Expected native int or pointer, but got VT
		//IL_05d6: Expected I, but got Obj
		//IL_05ec: Expected Obj, but got I
		//IL_02bf: Expected I, but got Obj
		//IL_0f08: Expected I, but got Obj
		//IL_0f1e: Expected Obj, but got I
		//IL_030c: Expected I, but got Obj
		//IL_0322: Expected Obj, but got I
		//IL_1143: Expected native int or pointer, but got VT
		//IL_1155: Expected native int or pointer, but got VT
		//IL_116b: Expected I4, but got VT
		//IL_116b: Expected Ref, but got VT
		//IL_1178: Expected Obj, but got F4
		//IL_119e: Expected Obj, but got I4
		//IL_11b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ba: Expected Obj, but got Unknown
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Expected Obj, but got Unknown
		//IL_11e5: Expected F4, but got Obj
		//IL_11e0: Expected native int or pointer, but got VT
		//IL_11fa: Expected F4, but got I
		//IL_11f5: Expected native int or pointer, but got VT
		//IL_120b: Expected I4, but got VT
		//IL_120b: Expected Ref, but got VT
		//IL_1218: Expected Obj, but got F4
		//IL_0617: Expected I, but got Obj
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected Obj, but got Unknown
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected Obj, but got Unknown
		//IL_0b29: Expected F4, but got Obj
		//IL_0b24: Expected native int or pointer, but got VT
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected Obj, but got Unknown
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected Obj, but got Unknown
		//IL_0b6d: Expected F4, but got Obj
		//IL_0b68: Expected native int or pointer, but got VT
		//IL_0b88: Expected I, but got Obj
		//IL_0b9e: Expected Obj, but got I
		//IL_0664: Expected I, but got Obj
		//IL_1034: Expected native int or pointer, but got VT
		//IL_104e: Expected F4, but got I
		//IL_1049: Expected native int or pointer, but got VT
		//IL_105b: Expected native int or pointer, but got VT
		//IL_1075: Expected F4, but got I
		//IL_1070: Expected native int or pointer, but got VT
		//IL_10c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c5: Expected Obj, but got Unknown
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Expected Obj, but got Unknown
		//IL_034d: Expected I, but got Obj
		//IL_039a: Expected I, but got Obj
		//IL_03e6: Expected F4, but got Obj
		//IL_03e1: Expected native int or pointer, but got VT
		//IL_0401: Expected I, but got Obj
		//IL_0417: Expected Obj, but got I
		//IL_0bcd: Expected native int or pointer, but got VT
		//IL_0be7: Expected F4, but got I
		//IL_0be2: Expected native int or pointer, but got VT
		//IL_0bf8: Expected I4, but got VT
		//IL_0bf8: Expected Ref, but got VT
		//IL_0c05: Expected Obj, but got F4
		//IL_0c20: Expected I, but got Obj
		//IL_0c36: Expected Obj, but got I
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Expected Obj, but got Unknown
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected Obj, but got Unknown
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected Obj, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected Obj, but got Unknown
		//IL_0cde: Expected F4, but got Obj
		//IL_0cd9: Expected native int or pointer, but got VT
		//IL_0cf3: Expected F4, but got I
		//IL_0cee: Expected native int or pointer, but got VT
		//IL_0d00: Expected F4, but got Obj
		//IL_0cfb: Expected native int or pointer, but got VT
		//IL_0d15: Expected F4, but got I
		//IL_0d10: Expected native int or pointer, but got VT
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Expected Obj, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Expected Obj, but got Unknown
		//IL_0442: Expected I, but got Obj
		//IL_048f: Expected I, but got Obj
		//IL_04db: Expected F4, but got Obj
		//IL_04d6: Expected native int or pointer, but got VT
		//IL_04f6: Expected I, but got Obj
		//IL_050c: Expected Obj, but got I
		//IL_0dd1: Expected native int or pointer, but got VT
		//IL_0deb: Expected F4, but got I
		//IL_0de6: Expected native int or pointer, but got VT
		//IL_0dfc: Expected I4, but got VT
		//IL_0dfc: Expected Ref, but got VT
		//IL_0e09: Expected native int or pointer, but got VT
		//IL_0e23: Expected F4, but got I
		//IL_0e1e: Expected native int or pointer, but got VT
		//IL_0e30: Expected F4, but got Obj
		//IL_0e2b: Expected native int or pointer, but got VT
		//IL_0e45: Expected F4, but got I
		//IL_0e40: Expected native int or pointer, but got VT
		//IL_0e63: Expected F4, but got Obj
		//IL_0e5e: Expected native int or pointer, but got VT
		//IL_0e78: Expected F4, but got I
		//IL_0e73: Expected native int or pointer, but got VT
		//IL_0e85: Expected F4, but got Obj
		//IL_0e80: Expected native int or pointer, but got VT
		//IL_0e9a: Expected F4, but got I
		//IL_0e95: Expected native int or pointer, but got VT
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_0537: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 84;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 72;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 60;
		obj4 = 0;
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v302 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 108);
		Vector3 one = Vector3.one;
		obj = vector.x;
		_ = vector.z;
		Vector3 vector2 = (Vector3)(obj2 + 96);
		Vector3 one2 = Vector3.one;
		MeshContainer meshContainer = (MeshContainer)vector2.x;
		_ = vector2.z;
		nint num3 = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v31 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v296 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref ModelInfo reference = ref (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref combinedMeshInfo) <= (nint)3 ? ref *(ModelInfo*)3 : ref combinedMeshInfo;
		if (Math3D.positionRegister == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			nint num5 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v274 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			bool flag = obj7 == null;
			nint num6 = (nint)typeof(Math3D);
			if (!flag)
			{
				nint num7 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v288 (Il2CppClass<SYBO.Common.Math3D>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num6 = (nint)typeof(Math3D);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num6 = (nint)typeof(Math3D);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ L2_v17 (Il2CppClass<SYBO.Common.Math3D>)+5C]");
			object obj8 = (nint)0 + (nint)8;
			object obj9 = default;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			nint num8 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v285 (Il2CppClass<SYBO.Common.Math3D>)+5C]");
			object obj10 = (nint)0 + (nint)12;
			object obj11 = default;
			obj10 = obj11;
		}
		object obj12 = 0;
		bool flag5;
		while (true)
		{
			nint num9 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v46 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num10 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v264 (Il2CppClass<SYBO.Common.Math3D>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3[] positionRegister = Math3D.positionRegister;
			object obj14 = positionRegister.Length - 1;
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
			nint num11 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v36 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			flag5 = obj15 != null;
			if (!flag4)
			{
				break;
			}
			if (flag5)
			{
				nint num12 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v258 (Il2CppClass<SYBO.Common.Math3D>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj16 = obj12 * 12;
			object obj17 = (object)Math3D.positionRegister + obj16;
			object obj18 = obj17 + 28;
			((Vector3*)(nint)vector2)->x = (float)obj18;
			Vector3 vector3 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S2_v68+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector)->x = vector2.x;
			((Vector3*)(nint)vector)->z = vector2.z;
			object obj19 = Math3D.positionRegister + 16;
			object obj20 = obj12 * 12;
			object obj21 = obj19 + obj20;
			obj21 = vector.x;
			_ = vector.z;
			object obj22 = Math3D.posTimeRegister + 16;
			object obj23 = obj12 << 2;
			object obj24 = obj22 + obj23;
			object obj25 = obj12 << 2;
			object obj26 = (object)Math3D.posTimeRegister + obj25;
			object obj27 = obj26 + 20;
			obj24 = obj27;
			object obj28 = obj12 + 1;
			obj12 = obj28;
		}
		if (flag5)
		{
			nint num13 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v236 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector4 = (Vector2)(obj2 + 48);
		Vector2 vector5 = (Vector2)(obj2 + 36);
		object obj29 = obj2 + 24;
		object obj30 = obj2 + 12;
		Vector3[] positionRegister2 = Math3D.positionRegister;
		object obj31 = positionRegister2.Length - 1;
		((Vector3*)(nint)vector)->x = (float)originalMesh;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)originalMesh).m_CachedPtr;
		object obj32 = Math3D.positionRegister + 16;
		object obj33 = obj31 * 12;
		object obj34 = obj32 + obj33;
		obj34 = vector.x;
		_ = vector.z;
		float[] posTimeRegister = Math3D.posTimeRegister;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		object obj35 = posTimeRegister.Length << 2;
		object obj36 = (object)Math3D.posTimeRegister + obj35;
		object obj37 = obj36 + 12;
		obj37 = timeSinceLevelLoad;
		int positionSamplesTaken = Math3D.positionSamplesTaken + 1;
		Math3D.positionSamplesTaken = positionSamplesTaken;
		bool result;
		if ((nint)Math3D.positionSamplesTaken < (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference))
		{
			result = false;
		}
		else
		{
			object obj38 = 0;
			while (true)
			{
				nint num14 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v87 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num15 = (nint)typeof(Math3D);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v229 (Il2CppClass<SYBO.Common.Math3D>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3[] positionRegister3 = Math3D.positionRegister;
				object obj40 = positionRegister3.Length - 2;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40))
				{
					nint num16 = (nint)typeof(Math3D);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v131 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
					object obj41 = (nint)0 & (nint)0x200;
					if (obj41 != null)
					{
						nint num17 = (nint)typeof(Math3D);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S0_v223 (Il2CppClass<SYBO.Common.Math3D>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj42 = obj38 * 12;
					object obj43 = (object)Math3D.positionRegister + obj42;
					object obj44 = obj43 + 28;
					((Vector2*)(nint)vector4)->x = (float)obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S1_v133+8]");
					_ = 0;
					object obj45 = Math3D.positionRegister + 16;
					object obj46 = obj38 * 12;
					object obj47 = obj45 + obj46;
					((Vector2*)(nint)vector5)->x = (float)obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S1_v142+8]");
					_ = 0;
					nint num18 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S0_v140 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj48 = (nint)0 & (nint)0x200;
					if (obj48 != null)
					{
						nint num19 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ S0_v219 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector2)->x = vector4.x;
					Vector3 vector6 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v56 (UnityEngine.Vector2)+8]");
					((Vector3*)(nint)vector6)->z = 0f;
					((Vector3*)(nint)vector)->x = vector5.x;
					Vector3 vector7 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v58 (UnityEngine.Vector2)+8]");
					((Vector3*)(nint)vector7)->z = 0f;
					Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
					obj3 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v60+8]");
					_ = 0;
					object obj49 = obj38 << 2;
					object obj50 = (object)Math3D.posTimeRegister + obj49;
					object obj51 = obj50 + 20;
					object obj52 = Math3D.posTimeRegister + 16;
					object obj53 = obj38 << 2;
					object obj54 = obj52 + obj53;
					float num20 = (float)obj51 - (float)obj54;
					bool flag6 = num20 == 0f;
					result = false;
					if (flag6)
					{
						break;
					}
					((Vector2*)(nint)vector4)->x = (float)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					nint num21 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ S0_v155 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj55 = (nint)0 & (nint)0x200;
					if (obj55 != null)
					{
						nint num22 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ S0_v215 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = vector4.x;
					Vector3 vector8 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v56 (UnityEngine.Vector2)+8]");
					((Vector3*)(nint)vector8)->z = 0f;
					((Vector2*)vector5)->set_Item((int)vector, num20);
					obj4 = vector5.x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v58 (UnityEngine.Vector2)+8]");
					_ = 0;
					nint num23 = (nint)typeof(Math3D);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S0_v165 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
					object obj56 = (nint)0 & (nint)0x200;
					if (obj56 != null)
					{
						nint num24 = (nint)typeof(Math3D);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ S0_v209 (Il2CppClass<SYBO.Common.Math3D>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj57 = obj38 * 12;
					object obj58 = (object)Math3D.positionRegister + obj57;
					object obj59 = obj58 + 40;
					obj29 = obj59;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S1_v188+8]");
					_ = 0;
					object obj60 = obj38 * 12;
					object obj61 = (object)Math3D.positionRegister + obj60;
					object obj62 = obj61 + 28;
					obj30 = obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ S1_v197+8]");
					_ = 0;
					((Vector3*)(nint)vector2)->x = (float)obj29;
					Vector3 vector9 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v60+8]");
					((Vector3*)(nint)vector9)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj30;
					Vector3 vector10 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v62+8]");
					((Vector3*)(nint)vector10)->z = 0f;
					Quaternion quaternion2 = Quaternion.FromToRotation(vector2, vector);
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					object obj63 = obj38 << 2;
					object obj64 = (object)Math3D.posTimeRegister + obj63;
					object obj65 = obj64 + 24;
					object obj66 = obj38 << 2;
					object obj67 = (object)Math3D.posTimeRegister + obj66;
					object obj68 = obj67 + 20;
					float num25 = (float)obj65 - (float)obj68;
					bool flag7 = num25 == 0f;
					result = false;
					if (flag7)
					{
						break;
					}
					((Vector2*)(nint)vector4)->x = (float)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					nint num26 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S0_v184 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj69 = (nint)0 & (nint)0x200;
					if (obj69 != null)
					{
						nint num27 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ S0_v205 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = vector4.x;
					Vector3 vector11 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v56 (UnityEngine.Vector2)+8]");
					((Vector3*)(nint)vector11)->z = 0f;
					((Vector2*)vector5)->set_Item((int)vector, num25);
					((Vector3*)(nint)vector2)->x = vector5.x;
					Vector3 vector12 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v58 (UnityEngine.Vector2)+8]");
					((Vector3*)(nint)vector12)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj4;
					Vector3 vector13 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
					((Vector3*)(nint)vector13)->z = 0f;
					Quaternion quaternion3 = Quaternion.FromToRotation(vector2, vector);
					((Vector3*)(nint)vector2)->x = (float)obj;
					Vector3 vector14 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((Vector3*)(nint)vector14)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj29;
					Vector3 vector15 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v60+8]");
					((Vector3*)(nint)vector15)->z = 0f;
					Vector3 vector16 = vector2 - vector;
					obj = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v62+8]");
					_ = 0;
					object obj70 = obj38 + 1;
					obj38 = obj70;
					continue;
				}
				((Vector3*)(nint)vector2)->x = (float)obj;
				Vector3 vector17 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Vector3*)(nint)vector17)->z = 0f;
				nint num28 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S0_v96 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
				object obj71 = (nint)0 & (nint)0x200;
				if (obj71 != null)
				{
					nint num29 = (nint)typeof(Math3D);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S0_v124 (Il2CppClass<SYBO.Common.Math3D>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3[] positionRegister4 = Math3D.positionRegister;
				nint num30 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S1_v88 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj72 = (nint)0 & (nint)0x200;
				if (obj72 != null)
				{
					nint num31 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S1_v124 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float value = (float)positionRegister4.Length - 2f;
				((Vector3*)(nint)vector)->x = vector2.x;
				((Vector3*)(nint)vector)->z = vector2.z;
				((Vector2*)vector4)->set_Item((int)vector, value);
				obj = vector4.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v56 (UnityEngine.Vector2)+8]");
				_ = 0;
				float[] posTimeRegister2 = Math3D.posTimeRegister;
				object obj73 = posTimeRegister2.Length << 2;
				object obj74 = (object)Math3D.posTimeRegister + obj73;
				object obj75 = obj74 + 12;
				object obj76 = Math3D.posTimeRegister + 16;
				float value2 = (float)obj75 - (float)obj76;
				((Vector3*)(nint)vector)->x = (float)obj;
				Vector3 vector18 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Vector3*)(nint)vector18)->z = 0f;
				((Vector2*)vector5)->set_Item((int)vector, value2);
				meshContainer = (MeshContainer)vector5.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v58 (UnityEngine.Vector2)+8]");
				_ = 0;
				result = true;
				break;
			}
		}
		return result;
	}

	public unsafe bool HasCombinedMesh(Mesh originalMesh)
	{
		//IL_005e: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Ref, but got Unknown
		//IL_0027: Expected I4, but got Obj
		//IL_0027: Expected Obj, but got I
		object obj = 0;
		ref bool reference = ref *(bool*)(obj + 4);
		reference = ref *(bool*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		object obj2 = default;
		if (obj2 != null)
		{
			reference = ref *(bool*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Visuals.MeshContainer)+C]");
			bool flag = ((Dictionary<QualityPlatformSupportWSA.WSAQualityCategory, bool>)0).TryGetValue((QualityPlatformSupportWSA.WSAQualityCategory)obj, out reference);
			return reference;
		}
		return false;
	}

	public void NotifyMeshCombineInProgress(Mesh mesh)
	{
		bool flag = _combinedMeshes.Remove(mesh);
	}

	public void NotifyMeshCombineFailed(Mesh mesh)
	{
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 <= -1)
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S4_v6+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S4_v7+48]");
			object obj9 = 0;
			object obj10 = obj9 & 0x7FF;
			object obj11 = obj10 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	public bool IsMeshCombineInProgress(Mesh mesh)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		return (nint)obj6 > -1;
	}

	public unsafe void AddMeshGroupCombinedCallback(Mesh mesh, Action<ModelInfo> meshReceiveCallback)
	{
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		ref Action<ModelInfo> reference = ref *(Action<ModelInfo>*)null;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S4_v4+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S5_v4 (should have been resolved before IL gen)");
		if (_combinedMeshCallbacks.TryGetValue(mesh, out reference))
		{
			if (reference != null)
			{
				reference((ModelInfo)(object)meshReceiveCallback);
			}
			bool flag = _combinedMeshCallbacks.Remove(mesh);
		}
	}

	public unsafe void RemoveMeshCombinedCallback(Mesh mesh, Action<ModelInfo> meshReceiveCallback)
	{
		//IL_011e: Expected Obj, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		ref Action<ModelInfo> reference = ref *(Action<ModelInfo>*)null;
		bool flag = _combinedMeshCallbacks.TryGetValue(mesh, out reference);
		object obj = (flag ? 1 : 0) ^ 1;
		bool flag2 = reference == null;
		object obj2 = flag2 | obj;
		if (obj2 != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v8 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S4_v9+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S4_v10+48]");
			object obj5 = 0;
			object obj6 = obj5 & 0x7FF;
			object obj7 = obj6 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S5_v9 (should have been resolved before IL gen)");
		}
		else
		{
			Delegate obj8 = ((Delegate)reference).CombineImpl((Delegate)meshReceiveCallback);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj9 = default;
			reference = ref *(Action<ModelInfo>*)obj9;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S4_v4+60]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S4_v5+48]");
			object obj12 = 0;
			object obj13 = obj12 & 0x7FF;
			object obj14 = obj13 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	public unsafe void AddGroup(CombineableMeshGroup combineableMeshGroup, ModelInfo combinedMeshInfo)
	{
		//IL_0061: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		ref Action<ModelInfo> reference = ref *(Action<ModelInfo>*)null;
		bool flag = _combinedMeshCallbacks.TryGetValue((Mesh)(object)combineableMeshGroup, out reference);
		object obj = (flag ? 1 : 0) ^ 1;
		bool flag2 = reference == null;
		object obj2 = flag2 | obj;
		if (obj2 == null)
		{
			Delegate obj3 = ((Delegate)reference).RemoveImpl((Delegate)(object)combinedMeshInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj4 = default;
			reference = ref *(Action<ModelInfo>*)obj4;
		}
	}

	public unsafe void RemoveGroup(CombineableMeshGroup combineableMeshGroup)
	{
		ref Action<ModelInfo> reference = ref *(Action<ModelInfo>*)null;
		if (_combinedMeshCallbacks.TryGetValue((Mesh)(object)combineableMeshGroup, out reference) && reference != null)
		{
			reference(null);
		}
	}

	public bool TryGetGroupMesh(CombineableMeshGroup combineableMeshGroup, out ModelInfo combinedMeshInfo)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		bool result = default;
		return result;
	}

	public bool HasGroupMesh(CombineableMeshGroup combineableMeshGroup)
	{
		//IL_0099: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			return false;
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v8 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S2_v9+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S2_v10+44]");
		object obj9 = 0;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S3_v9 (should have been resolved before IL gen)");
		object obj12 = default;
		return (nint)obj12 > -1;
	}

	public void NotifyMeshGroupCombineInProgress(CombineableMeshGroup meshGroup)
	{
		bool flag = _combinedMeshesGroups.Remove(meshGroup);
	}

	public void NotifyMeshGroupCombineCanceled(CombineableMeshGroup meshGroup)
	{
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 <= -1)
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S4_v6+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S4_v7+48]");
			object obj9 = 0;
			object obj10 = obj9 & 0x7FF;
			object obj11 = obj10 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	public bool IsMeshGroupCombineInProgress(CombineableMeshGroup meshGroup)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		return (nint)obj6 > -1;
	}

	public unsafe void AddMeshGroupCombinedCallback(CombineableMeshGroup meshGroup, Action<ModelInfo> meshReceiveCallback)
	{
		//IL_00cf: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		ref Action<ModelInfo> reference = ref *(Action<ModelInfo>*)null;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 <= -1)
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S4_v6+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S4_v7+48]");
			object obj9 = 0;
			object obj10 = obj9 & 0x7FF;
			object obj11 = obj10 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57 @ S5_v5 (should have been resolved before IL gen)");
		}
		if (_combinedMeshGroupCallbacks.TryGetValue(meshGroup, out reference))
		{
			if (reference != null)
			{
				reference((ModelInfo)(object)meshReceiveCallback);
			}
			bool flag = _combinedMeshGroupCallbacks.Remove(meshGroup);
		}
	}

	public unsafe void RemoveMeshGroupCombinedCallback(CombineableMeshGroup meshGroup, Action<ModelInfo> meshReceiveCallback)
	{
		//IL_011e: Expected Obj, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		ref Action<ModelInfo> reference = ref *(Action<ModelInfo>*)null;
		bool flag = _combinedMeshGroupCallbacks.TryGetValue(meshGroup, out reference);
		object obj = (flag ? 1 : 0) ^ 1;
		bool flag2 = reference == null;
		object obj2 = flag2 | obj;
		if (obj2 != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v8 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S4_v9+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S4_v10+48]");
			object obj5 = 0;
			object obj6 = obj5 & 0x7FF;
			object obj7 = obj6 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S5_v9 (should have been resolved before IL gen)");
		}
		else
		{
			Delegate obj8 = ((Delegate)reference).CombineImpl((Delegate)meshReceiveCallback);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj9 = default;
			reference = ref *(Action<ModelInfo>*)obj9;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S4_v4+60]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S4_v5+48]");
			object obj12 = 0;
			object obj13 = obj12 & 0x7FF;
			object obj14 = obj13 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	public MeshContainer()
	{
		//IL_001d: Expected VT, but got I4
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.DynamicManagers, (Vector3)0);
	}
}
