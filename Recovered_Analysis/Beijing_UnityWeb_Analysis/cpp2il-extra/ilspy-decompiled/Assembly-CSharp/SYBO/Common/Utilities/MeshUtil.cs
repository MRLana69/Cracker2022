using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Builders;
using SYBO.Common.Utilities.Flags;
using SYBO.Common.Visuals;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Common.Utilities;

public static class MeshUtil
{
	private sealed class _003CCombineMeshesAsync_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<ModelInfo> meshReceiveCallback;

		public GameObject parentGO;

		public IList<ObjectModelInfo> meshInfos;

		private Dictionary<MeshFilter, Matrix4x4> _003ClocalPosMapping_003E5__2;

		private Matrix4x4 _003CgoWorldToLocalMatrix_003E5__3;

		private List<Vector3> _003CcVertices_003E5__4;

		private List<Vector3> _003CcNormals_003E5__5;

		private List<Color32> _003CcColors_003E5__6;

		private List<Vector2> _003CcUV1s_003E5__7;

		private List<Vector2> _003CcUV2s_003E5__8;

		private Dictionary<Material, List<int>> _003CcSubMeshes_003E5__9;

		private int _003Ci_003E5__10;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d73: Expected Ref, but got Unknown
				//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d81: Expected Obj, but got Unknown
				//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d8f: Expected Obj, but got Unknown
				//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d9d: Expected Obj, but got Unknown
				//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dab: Expected Obj, but got Unknown
				//IL_0db4: Expected Obj, but got I4
				//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dc8: Expected Obj, but got Unknown
				//IL_05ca: Expected Obj, but got I4
				//IL_0086: Expected Obj, but got I4
				//IL_05e3: Expected Obj, but got I4
				//IL_00d2: Expected Obj, but got I
				//IL_00e2: Expected Obj, but got I
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Expected Obj, but got Unknown
				//IL_0101: Unknown result type (might be due to invalid IL or missing references)
				//IL_0106: Expected Obj, but got Unknown
				//IL_0116: Unknown result type (might be due to invalid IL or missing references)
				//IL_011b: Expected Obj, but got Unknown
				//IL_05f1: Expected Obj, but got I4
				//IL_038d: Expected Obj, but got I4
				//IL_05bc: Expected Obj, but got I4
				//IL_0149: Expected I, but got Obj
				//IL_015f: Expected Obj, but got I
				//IL_0619: Expected Obj, but got I4
				//IL_03c2: Expected Obj, but got I4
				//IL_0e14: Expected Obj, but got I
				//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e44: Expected Obj, but got Unknown
				//IL_018a: Expected I, but got Obj
				//IL_0457: Unknown result type (might be due to invalid IL or missing references)
				//IL_045c: Expected Obj, but got Unknown
				//IL_01da: Expected Obj, but got I
				//IL_01ec: Expected I, but got Obj
				//IL_0202: Expected Obj, but got I
				//IL_08f1: Expected Obj, but got I4
				//IL_0486: Unknown result type (might be due to invalid IL or missing references)
				//IL_048b: Expected Obj, but got Unknown
				//IL_0913: Unknown result type (might be due to invalid IL or missing references)
				//IL_0918: Expected Obj, but got Unknown
				//IL_0929: Unknown result type (might be due to invalid IL or missing references)
				//IL_092e: Expected Obj, but got Unknown
				//IL_06a1: Expected I, but got Obj
				//IL_06b7: Expected Obj, but got I
				//IL_04af: Expected Obj, but got I4
				//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ba: Expected Obj, but got Unknown
				//IL_022d: Expected I, but got Obj
				//IL_0e91: Expected Obj, but got I
				//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e9: Expected Obj, but got Unknown
				//IL_027d: Expected Obj, but got I
				//IL_028e: Expected VT, but got Obj
				//IL_0741: Expected Obj, but got I
				//IL_0753: Expected I, but got Obj
				//IL_0769: Expected Obj, but got I
				//IL_06e2: Expected I, but got Obj
				//IL_0513: Unknown result type (might be due to invalid IL or missing references)
				//IL_0518: Expected Obj, but got Unknown
				//IL_030e: Expected VT, but got Ref
				//IL_030e: Expected Obj, but got I
				//IL_031f: Expected Obj, but got I
				//IL_072a: Expected Obj, but got I4
				//IL_0545: Expected Obj, but got I
				//IL_0555: Expected Obj, but got I
				//IL_0566: Unknown result type (might be due to invalid IL or missing references)
				//IL_056b: Expected Obj, but got Unknown
				//IL_0574: Unknown result type (might be due to invalid IL or missing references)
				//IL_0579: Expected Obj, but got Unknown
				//IL_0589: Unknown result type (might be due to invalid IL or missing references)
				//IL_058e: Expected Obj, but got Unknown
				//IL_05ac: Expected Obj, but got I4
				//IL_034b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0350: Expected Obj, but got Unknown
				//IL_07f3: Expected Obj, but got I
				//IL_0808: Expected Obj, but got I
				//IL_0794: Expected I, but got Obj
				//IL_07dc: Expected Obj, but got I4
				//IL_0838: Expected I, but got Obj
				//IL_084e: Expected Obj, but got I
				//IL_0ff6: Expected VT, but got Ref
				//IL_0ff6: Expected VT, but got Obj
				//IL_1092: Expected VT, but got Ref
				//IL_1092: Expected I4, but got Obj
				//IL_1098: Unknown result type (might be due to invalid IL or missing references)
				//IL_109d: Expected Obj, but got Unknown
				//IL_10a6: Expected Obj, but got I4
				//IL_10ba: Expected Obj, but got I4
				//IL_10cd: Expected Obj, but got I4
				//IL_0879: Expected I, but got Obj
				//IL_10db: Unknown result type (might be due to invalid IL or missing references)
				//IL_10e0: Expected Obj, but got Unknown
				//IL_10e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_10ee: Expected Obj, but got Unknown
				//IL_111a: Expected Obj, but got I4
				//IL_1123: Expected Obj, but got I4
				//IL_0c78: Expected Obj, but got I
				//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b63: Expected Obj, but got Unknown
				//IL_0d21: Expected Obj, but got I4
				//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cb3: Expected Obj, but got Unknown
				//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bb4: Expected Obj, but got Unknown
				//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ce9: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 + 352;
				ref _0021_00210 reference = ref *(_0021_00210*)(obj2 + 280);
				Transform transform = (Transform)(obj2 + 216);
				object obj3 = obj2 + 128;
				object obj4 = obj2 - -64;
				object obj5 = obj2 + 200;
				obj5 = 0;
				_ = 0;
				object obj6 = obj2 + 192;
				obj6 = obj;
				_ = -1;
				object obj7;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						obj7 = 34;
					}
					else
					{
						obj7 = 65;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					if (meshReceiveCallback == null)
					{
						SDebug.LogFormat("No callback specified to receive combined mesh", (object[])(object)parentGO);
						obj7 = 65;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj8 = default;
						if (obj8 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S3_v25 (Il2CppMethodInfo)+C]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S3_v26+60]");
							object obj10 = 0;
							object obj11 = obj10;
							object obj12 = obj11 & 0x1FFF;
							List<Vector3> list = (List<Vector3>)(obj12 + 113696);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v163 @ S4_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>) (should have been resolved before IL gen)");
							object obj13 = this + 28;
							object obj14 = default;
							obj13 = obj14;
							int num2 = 0;
							List<Vector2> list2 = default;
							object obj15 = default;
							object obj18 = default;
							object obj19 = default;
							List<Vector2> list3 = default;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								if (System.Runtime.CompilerServices.Unsafe.As<List<Vector2>, UIntPtr>(ref list2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
								nint num3 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v307 (Il2CppClass<UnityEngine.Object>)+BA]");
								object obj16 = (nint)0 & (nint)0x200;
								if (obj16 != null)
								{
									nint num4 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v327 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v304+C]");
								if (((ComputeShader)0).FindKernel(null) != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v304+C]");
									Mesh mesh = ((MeshFilter)0).mesh;
									nint num5 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S1_v265 (Il2CppClass<UnityEngine.Object>)+BA]");
									object obj17 = (nint)0 & (nint)0x200;
									if (obj17 != null)
									{
										nint num6 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S1_v286 (Il2CppClass<UnityEngine.Object>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									if (((ComputeShader)(object)mesh).FindKernel((string)null) != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v304+C]");
										GameObject gameObject = ((Component)0).gameObject;
										transform.Rotate((Vector3)gameObject);
										reference = ref *(_0021_00210*)transform;
										_ = ((UnityEngine.Object)transform).m_CachedPtr;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+10]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+18]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+20]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+28]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+30]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+38]");
										_ = 0;
										Dictionary<MeshFilter, Matrix4x4> dictionary = _003ClocalPosMapping_003E5__2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v304+C]");
										dictionary.Add((MeshFilter)0, (Matrix4x4)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v304+C]");
										Mesh mesh2 = ((MeshFilter)0).mesh;
										int subMeshCount = mesh2.subMeshCount;
										int num7 = subMeshCount + num2;
										obj18 = obj19 + 1;
										num2 = num7;
									}
								}
								list2 = (List<Vector2>)(list3 + 1);
							}
							bool flag = obj18 != null;
							bool flag2 = num2 < 65535;
							object obj20 = flag & flag2;
							if (obj20 != null)
							{
								int layer = parentGO.layer;
								Matrix4x4 localToWorldMatrix = ((Transform)layer).localToWorldMatrix;
								reference = ref *(_0021_00210*)transform;
								_ = ((UnityEngine.Object)transform).m_CachedPtr;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+10]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+20]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+28]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+30]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+38]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @958B");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								List<Vector3> list4 = default;
								list4._002Ector(num2);
								object obj21 = this + 96;
								obj21 = list4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								List<Vector3> list5 = default;
								list5._002Ector(num2);
								object obj22 = this + 100;
								obj22 = list5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								List<> list6 = default;
								((List<T>)(object)list6)._002Ector((IEnumerable<T>)num2);
								object obj23 = this + 104;
								obj23 = list6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								List<Vector2> list7 = default;
								list7._002Ector(num2);
								object obj24 = this + 108;
								obj24 = list7;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								List<Vector2> list8 = default;
								list8._002Ector(num2);
								object obj25 = this + 112;
								obj25 = list8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ S3_v34 (Il2CppMethodInfo)+C]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ S3_v35+60]");
								object obj27 = 0;
								object obj28 = obj27;
								object obj29 = obj28 & 0x1FFF;
								list = (List<Vector3>)(obj29 + 113696);
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v163 @ S4_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>) (should have been resolved before IL gen)");
								object obj30 = this + 116;
								object obj31 = default;
								obj30 = obj31;
								_003Ci_003E5__10 = 0;
								obj7 = 35;
							}
							else
							{
								obj7 = 65;
							}
						}
						else
						{
							obj7 = 65;
						}
					}
				}
				object obj32 = obj7;
				object obj33 = default;
				object result = default;
				Mesh mesh5 = default;
				ModelInfo modelInfo = default;
				object obj41 = default;
				List<Vector3> vertices = default;
				_0021_00210 flag3 = default;
				object obj42 = default;
				object obj46 = default;
				while (true)
				{
					if ((nint)obj32 == 34)
					{
						int num9 = _003Ci_003E5__10 + 1;
						_003Ci_003E5__10 = num9;
						obj32 = 35;
						continue;
					}
					if ((nint)obj32 == 35)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						if (_003Ci_003E5__10 < (nint)obj33)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
							nint num10 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S1_v123 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj34 = (nint)0 & (nint)0x200;
							if (obj34 != null)
							{
								nint num11 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v196 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S1_v120+C]");
							if (((ComputeShader)0).FindKernel(null) == 0)
							{
								obj32 = 34;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S1_v120+C]");
							Mesh mesh3 = ((MeshFilter)0).mesh;
							nint num12 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S2_v65 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj35 = (nint)0 & (nint)0x200;
							if (obj35 != null)
							{
								nint num13 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ S2_v74 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)(object)mesh3).FindKernel((string)null) == 0)
							{
								obj32 = 34;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S1_v120+C]");
							Mesh mesh4 = ((MeshFilter)0).mesh;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v179+8]");
							Shader shader = Shader.Find((string)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @958C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10938");
							nint num14 = (nint)typeof(Matrix4x4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ S0_v185 (Il2CppClass<UnityEngine.Matrix4x4>)+BA]");
							object obj36 = (nint)0 & (nint)0x200;
							if (obj36 != null)
							{
								nint num15 = (nint)typeof(Matrix4x4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ S0_v232 (Il2CppClass<UnityEngine.Matrix4x4>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							transform = (Transform)obj3;
							Transform transform2 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
							((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+20]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+28]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+30]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+38]");
							_ = 0;
							reference = ref *(_0021_00210*)obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+20]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+28]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+30]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+38]");
							_ = 0;
							Vector4 vector = (Matrix4x4)transform * (Vector4)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
							reference = ref *(_0021_00210*)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+28]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+30]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+38]");
							_ = 0;
							MergeSubmeshInto(mesh4, (int)shader, (Matrix4x4)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), _003CcVertices_003E5__4, _003CcNormals_003E5__5, (List<Vector2>)(object)_003CcColors_003E5__6, _003CcUV1s_003E5__7, (List<int>)(object)_003CcUV2s_003E5__8, (Dictionary<int, int>)(object)_003CcSubMeshes_003E5__9);
							object obj37 = this + 12;
							obj37 = 0;
							_003C_003E1__state = 1;
							result = 1;
							List<Vector3> list = _003CcNormals_003E5__5;
							obj32 = 65;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Mesh.Internal_Create(mesh5);
						Dictionary<Material, List<int>> dictionary2 = _003CcSubMeshes_003E5__9;
						object obj38 = dictionary2.count - dictionary2.freeCount;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj39 = modelInfo + 8;
						obj39 = mesh5;
						object obj40 = modelInfo + 12;
						obj40 = obj41;
						Vector3[] normals = _003CcVertices_003E5__4.ToArray();
						modelInfo.Mesh.normals = normals;
						List<Vector3> list9 = _003CcNormals_003E5__5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v58 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
						if ((nint)0 >= (nint)1)
						{
							Vector3[] uv = _003CcNormals_003E5__5.ToArray();
							modelInfo.Mesh.uv = (Vector2[])(object)uv;
						}
						List<Vector2> list10 = _003CcUV1s_003E5__7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S0_v65 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+C]");
						if ((nint)0 >= (nint)1)
						{
							Vector2[] uv2 = _003CcUV1s_003E5__7.ToArray();
							modelInfo.Mesh.uv2 = uv2;
						}
						List<Vector2> list11 = _003CcUV2s_003E5__8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S0_v72 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+C]");
						if ((nint)0 >= (nint)1)
						{
							Vector2[] colors = _003CcUV2s_003E5__8.ToArray();
							modelInfo.Mesh.colors32 = (Color32[])(object)colors;
						}
						Dictionary<Material, List<int>> dictionary3 = _003CcSubMeshes_003E5__9;
						bool keepVertexLayout = (byte)(dictionary3.count - dictionary3.freeCount) != 0;
						modelInfo.Mesh.ClearImpl(keepVertexLayout);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
						modelInfo.Mesh.SetVertices(vertices);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
						FlagsHelper.Set<T>(ref System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (T)flag3);
						obj5 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (T&)+8]");
						_ = 0;
						List<Vector3> list12 = null;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if (obj42 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj43 = modelInfo.Materials + 16;
							object obj44 = (object)list12 << 2;
							object obj45 = obj43 + obj44;
							obj45 = obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							List<Vector3> list13 = (List<Vector3>)(list12 + 1);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
							List<Vector3> list = list12;
							list = list12;
							list12 = list13;
						}
						object obj47 = obj6 + 4;
						object obj48 = obj47 + 1;
						obj47 = obj48;
						object obj49 = obj48 << 2;
						object obj50 = obj6 + obj49;
						obj50 = 837;
						object obj51 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23+4]");
						if ((nint)0 != -1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23+4]");
							object obj52 = (nint)0 << 2;
							object obj53 = obj6 + obj52;
							if ((nint)obj53 == 837)
							{
								object obj54 = obj6 + 4;
								if ((nint)obj54 > -1)
								{
									object obj55 = obj54 + -1;
									obj54 = obj55;
								}
								goto IL_0d04;
							}
						}
						if (obj51 != null)
						{
							break;
						}
						goto IL_0d04;
					}
					if ((nint)obj32 == 65)
					{
						return result;
					}
					continue;
					IL_0d04:
					meshReceiveCallback(modelInfo);
					result = null;
					obj32 = 65;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CCombineMeshesAsync_003Ed__6(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCombineMeshesAsync_003Ed__9(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IList<ObjectModelInfo> meshInfos;

		public GameObject parentGO;

		public Action<ModelInfo[]> meshReceiveCallback;

		private Matrix4x4 _003CgoWorldToLocalMatrix_003E5__2;

		private List<Vector3> _003CcVertices_003E5__3;

		private List<Vector3> _003CcNormals_003E5__4;

		private List<Vector2> _003CcUV1s_003E5__5;

		private List<Vector2> _003CcUV2s_003E5__6;

		private List<int> _003CcTriangles_003E5__7;

		private Dictionary<int, int> _003ColdToNewVertsIDs_003E5__8;

		private int _003Ccmi_003E5__9;

		private ModelInfo[] _003CcombinedMeshes_003E5__10;

		private Dictionary<Material, List<SubMeshInfo>>.Enumerator _003C_003E7__wrap10;

		private KeyValuePair<Material, List<SubMeshInfo>> _003Ckvp_003E5__12;

		private List<SubMeshInfo> _003CsubMeshInfos_003E5__13;

		private int _003Ci_003E5__14;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_1c2a: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c2f: Expected VT, but got Unknown
				//IL_1c38: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c3d: Expected VT, but got Unknown
				//IL_1c46: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c4b: Expected Obj, but got Unknown
				//IL_1c54: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c59: Expected Obj, but got Unknown
				//IL_1c62: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c67: Expected Obj, but got Unknown
				//IL_1c70: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c75: Expected Obj, but got Unknown
				//IL_1c7e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c83: Expected Obj, but got Unknown
				//IL_1c8c: Expected Obj, but got I4
				//IL_1c95: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c9a: Expected Obj, but got Unknown
				//IL_1ca3: Expected Obj, but got I4
				//IL_1cd6: Unknown result type (might be due to invalid IL or missing references)
				//IL_1cdb: Expected Obj, but got Unknown
				//IL_0efe: Expected Obj, but got I4
				//IL_0f17: Expected Obj, but got I4
				//IL_1d38: Expected Obj, but got I4
				//IL_0f25: Expected Obj, but got I4
				//IL_0f77: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f7c: Expected Obj, but got Unknown
				//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_10b9: Expected Obj, but got Unknown
				//IL_10f4: Expected Obj, but got F4
				//IL_1101: Expected F4, but got Obj
				//IL_10fc: Expected native int or pointer, but got VT
				//IL_1107: Unknown result type (might be due to invalid IL or missing references)
				//IL_110c: Expected Obj, but got Unknown
				//IL_1119: Expected Obj, but got F4
				//IL_1f20: Expected Obj, but got I4
				//IL_1018: Unknown result type (might be due to invalid IL or missing references)
				//IL_101d: Expected Obj, but got Unknown
				//IL_12e7: Expected Obj, but got I4
				//IL_1099: Expected Obj, but got I4
				//IL_105f: Expected Obj, but got I4
				//IL_1205: Unknown result type (might be due to invalid IL or missing references)
				//IL_120a: Expected Obj, but got Unknown
				//IL_123e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1243: Expected Obj, but got Unknown
				//IL_1481: Expected Obj, but got I4
				//IL_1f00: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 480;
				Vector4 vector = (Vector4)(obj2 + 408);
				Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 8);
				object obj3 = obj2 + 264;
				object obj4 = obj2 + 200;
				object obj5 = obj2 + 136;
				object obj6 = obj2 + 72;
				object obj7 = obj2 + 400;
				obj7 = 0;
				object obj8 = obj2 + 336;
				obj8 = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				object obj9 = obj2 + 328;
				obj9 = obj;
				_ = -1;
				object obj10;
				object obj12 = default;
				object obj13 = default;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -3;
						obj10 = 128;
					}
					else
					{
						obj10 = 182;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj11 = default;
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						IList<ObjectModelInfo> list = meshInfos;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj12 = obj13;
						object obj15 = default;
						object obj14 = obj15;
						obj10 = 179;
					}
					else
					{
						obj10 = 182;
					}
				}
				object obj16 = obj10;
				object obj18 = default;
				object result = default;
				object obj20 = default;
				IList<ObjectModelInfo> list2 = default;
				object obj25 = default;
				object obj26 = default;
				object obj27 = default;
				object obj28 = default;
				object obj29 = default;
				object obj31 = default;
				while (true)
				{
					if ((nint)obj16 == 128)
					{
						int num = _003Ci_003E5__14 + 1;
						_003Ci_003E5__14 = num;
					}
					else if ((nint)obj16 == 168)
					{
						object obj17 = this + 124;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj19 = this + 124;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							if (meshReceiveCallback == null)
							{
								result = null;
								obj16 = 182;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							obj16 = 179;
							obj12 = obj13;
							object obj14 = obj20;
							continue;
						}
						object obj21 = this + 124;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						obj2 = matrix4x.m00;
						((Vector4*)(nint)vector)->x = (float)obj2;
						object obj22 = this + 148;
						obj22 = vector.x;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						object obj23 = this + 148;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						object obj24 = this + 156;
						obj24 = list2;
						_003Ci_003E5__14 = 0;
					}
					else
					{
						if ((nint)obj16 == 179)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
							if (obj12 == obj25)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
								_003C_003Em__Finally1();
								if (obj26 == null)
								{
									result = null;
									obj16 = 182;
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
							break;
						}
						if ((nint)obj16 == 182)
						{
							return result;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (_003Ci_003E5__14 < (nint)obj27)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ S0_v319+C]");
						if ((nint)obj28 <= 0)
						{
							obj16 = 128;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj14 = obj29;
						object obj30 = obj13;
						obj16 = 179;
						obj12 = obj30;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj16 = 179;
						obj12 = obj13;
						object obj14 = obj31;
					}
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -3;
			if (_003C_003E1__state != -3 && ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4))
			{
				return;
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 26;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 26)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
		}
	}

	public static IList<ObjectModelInfo> GetMeshInfos(IList<CombineableMesh> combineableMeshes)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = ((GameObject)(object)combineableMeshes).gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = gameObject != null;
		return (IList<ObjectModelInfo>)((flag ? 1 : 0) ^ 1);
	}

	public static IList<ObjectModelInfo> GetMeshInfos(IList<MeshRenderer> meshRenderers)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<ObjectModelInfo> list = default;
		int capacity = default;
		list._002Ector(capacity);
		object obj = 0;
		object obj2 = default;
		MeshCombiner meshCombiner = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			GameObject combinedMeshGO = meshCombiner.GetCombinedMeshGO();
			list.Add((ObjectModelInfo)(object)combinedMeshGO);
			object obj3 = obj + 1;
			obj = obj3;
		}
		return list;
	}

	public static ModelInfo CombineMeshes(GameObject parentGO, IList<MeshRenderer> meshRenderers)
	{
		//IL_0017: Expected VT, but got I4
		//IL_0017: Expected VT, but got I4
		return (ModelInfo)(object)((StackablePrefabBuilder)(object)parentGO).BuildAndAttach((GameObject)(object)meshRenderers, (Vector3)0, (Vector3)1);
	}

	public static ModelInfo CombineMeshes(GameObject parentGO, IList<CombineableMesh> combineableMeshes)
	{
		//IL_001a: Expected I4, but got Obj
		ModelInfo modelInfo = CombineMeshes((GameObject)(object)combineableMeshes);
		return CombineMeshes(parentGO, (byte)(int)modelInfo != 0);
	}

	public static ModelInfo CombineMeshes(GameObject parentGO, IList<ObjectModelInfo> meshInfos)
	{
		//IL_001a: Expected I4, but got Obj
		IList<ObjectModelInfo> meshInfos2 = GetMeshInfos((IList<MeshRenderer>)meshInfos);
		return CombineMeshes(parentGO, (byte)(int)meshInfos2 != 0);
	}

	public static ModelInfo CombineMeshes(GameObject parentGO, bool combineInactive)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_0012: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<ModelInfo[]> action = default;
		object obj3 = action + 16;
		obj3 = obj2;
		IEnumerator enumerator = CombineMeshesAsync(parentGO, (IList<ObjectModelInfo>)combineInactive, action);
		object obj4 = default;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}
		while (obj4 != null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		return (ModelInfo)0;
	}

	public static IEnumerator CombineMeshesAsync(GameObject parentGO, IList<ObjectModelInfo> meshInfos, Action<ModelInfo> meshReceiveCallback)
	{
		//IL_0016: Expected VT, but got I4
		//IL_0016: Expected VT, but got Obj
		return (IEnumerator)(object)((StackablePrefabBuilder)(object)parentGO).BuildAndAttach((GameObject)(object)meshInfos, (Vector3)meshReceiveCallback, (Vector3)1);
	}

	public unsafe static ModelInfo CombineMeshes(GameObject go)
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected I, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_014a: Expected I, but got Obj
		//IL_006c: Expected I, but got Obj
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		object obj = default;
		nint num = (nint)(obj + 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<ObjectModelInfo> list = default;
		int capacity = default;
		list._002Ector(capacity);
		object obj2 = 0;
		object obj3 = default;
		Component component2 = default;
		ObjectModelInfo objectModelInfo = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v26 (Il2CppClass<System.Type>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v54 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(MeshFilter);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type t = Type.internal_from_handle((IntPtr)num);
			Component component = component2.GetComponentInParent(t);
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj5 = objectModelInfo + 8;
			obj5 = component2;
			object obj6 = objectModelInfo + 12;
			obj6 = component;
			list.Add(objectModelInfo);
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
		return (ModelInfo)(object)list;
	}

	private unsafe static void MergeMeshInto(Mesh mesh, Material[] materials, Matrix4x4 transformMatrix, List<Vector3> cVertices, List<Vector3> cNormals, List<Color32> cColors, List<Vector2> cUV1s, List<Vector2> cUV2s, Dictionary<Material, List<int>> cSubMeshes)
	{
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_02be: Expected Obj, but got VT
		//IL_02e0: Expected I4, but got Obj
		//IL_02e0: Expected I4, but got Obj
		//IL_02e0: Expected Obj, but got I4
		//IL_02e9: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got VT
		//IL_00ae: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_01f0: Expected VT, but got I
		//IL_01f0: Expected VT, but got I
		//IL_0205: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		object obj = mesh + 36;
		obj = "";
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<System.IO.Path>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v56 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot((string)transformMatrix, (string)(object)cVertices);
		((AScreenCapture)(object)mesh)._002Ector((string)flag, (int)cNormals, (int)cColors, (Camera)(object)cUV2s, 8);
		TouchScreenKeyboard.Internal_Destroy((IntPtr)cUV1s);
		object obj3 = mesh + 32;
		obj3 = materials;
		object obj4 = mesh + 36;
		obj4 = cVertices;
		object obj5 = mesh + 40;
		obj5 = cSubMeshes;
		bool flag2 = Path.SameRoot((string)transformMatrix, (string)(object)cVertices);
		string[] directories = Directory.GetDirectories((string)flag2);
		object obj6 = directories + 12;
		object obj7 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj8 = directories + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			((FileStream)obj10).ExposeHandle();
			object obj11 = obj7 + 1;
			obj7 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
		object obj12 = mesh + 44;
		obj12 = stream;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mesh @ L0 (UnityEngine.Mesh)+2C]");
		UnityEngine.Object.CheckNullArgument((object)0, (string)61);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mesh @ L0 (UnityEngine.Mesh)+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mesh @ L0 (UnityEngine.Mesh)+24]");
		AnimationState animationState = ((Animation)num3).get_Item((string)0);
		if ((object)animationState != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mesh @ L0 (UnityEngine.Mesh)+20]");
			Animation.INTERNAL_CALL_Stop((Animation)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mesh @ L0 (UnityEngine.Mesh)+20]");
			Animation.INTERNAL_CALL_Rewind((Animation)0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mesh @ L0 (UnityEngine.Mesh)+20]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mesh @ L0 (UnityEngine.Mesh)+24]");
		bool flag3 = Physics.Raycast((Vector3)num4, (Vector3)0, out *(RaycastHit*)4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mesh @ L0 (UnityEngine.Mesh)+2C]");
		NewMonoBehaviour newMonoBehaviour = ((GameObject)0).AddComponent<NewMonoBehaviour>();
		IEnumerator routine = ((CaptureInGame)(object)mesh).CaptureAllFrames();
		Coroutine coroutine = newMonoBehaviour.StartCoroutine_Auto(routine);
	}

	public static IEnumerator CombineMeshesAsync(GameObject parentGO, IList<ObjectModelInfo> meshInfos, Action<ModelInfo[]> meshReceiveCallback = null)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = parentGO;
		object obj2 = enumerator + 24;
		obj2 = meshInfos;
		object obj3 = enumerator + 16;
		obj3 = meshReceiveCallback;
		return enumerator;
	}

	private unsafe static void MergeSubmeshInto(Mesh mesh, int submeshIndex, Matrix4x4 transformMatrix, List<Vector3> cVertices, List<Vector3> cNormals, List<Vector2> cUV1s, List<Vector2> cUV2s, List<int> cTriangles, Dictionary<int, int> oldToNewVertIDs)
	{
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got Unknown
		//IL_08e3: Expected Obj, but got I4
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected Obj, but got Unknown
		//IL_0900: Expected Obj, but got I4
		//IL_090e: Expected I, but got Obj
		//IL_0924: Expected Obj, but got I
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected VT, but got Unknown
		//IL_0cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Expected VT, but got Unknown
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Expected Obj, but got Unknown
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Expected Obj, but got Unknown
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected Obj, but got Unknown
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Expected VT, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_0980: Expected I, but got Obj
		//IL_0996: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00a8: Expected F4, but got Obj
		//IL_00a3: Expected native int or pointer, but got VT
		//IL_00bd: Expected F4, but got I
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_00ca: Expected native int or pointer, but got VT
		//IL_00f0: Expected F4, but got Obj
		//IL_00eb: Expected native int or pointer, but got VT
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got F4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_09df: Expected F4, but got Obj
		//IL_09da: Expected native int or pointer, but got VT
		//IL_0a10: Expected native int or pointer, but got VT
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_02f5: Expected I, but got Obj
		//IL_030b: Expected Obj, but got I
		//IL_02a8: Expected I, but got Obj
		//IL_0a3e: Expected F4, but got Obj
		//IL_0a39: Expected native int or pointer, but got VT
		//IL_0a53: Expected F4, but got I
		//IL_0a4e: Expected native int or pointer, but got VT
		//IL_0a60: Expected F4, but got Obj
		//IL_0a5b: Expected native int or pointer, but got VT
		//IL_0ab9: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I4
		//IL_0336: Expected I, but got Obj
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got I4
		//IL_0c1f: Expected Obj, but got I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0250: Expected F4, but got Obj
		//IL_024b: Expected native int or pointer, but got VT
		//IL_025d: Expected Obj, but got F4
		//IL_026a: Expected F4, but got Obj
		//IL_0265: Expected native int or pointer, but got VT
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_03bb: Expected Obj, but got I4
		//IL_0538: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected Obj, but got Unknown
		//IL_0613: Expected Obj, but got I4
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got Unknown
		//IL_063c: Expected I, but got Obj
		//IL_0652: Expected Obj, but got I
		//IL_05b9: Expected Obj, but got I
		//IL_05c9: Expected Obj, but got I
		//IL_05d9: Expected Obj, but got I
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_04b7: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected Obj, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_0421: Expected I, but got Obj
		//IL_0437: Expected Obj, but got I
		//IL_067d: Expected I, but got Obj
		//IL_0afe: Expected F4, but got Obj
		//IL_0af9: Expected native int or pointer, but got VT
		//IL_0b13: Expected F4, but got I
		//IL_0b0e: Expected native int or pointer, but got VT
		//IL_0b20: Expected F4, but got Obj
		//IL_0b1b: Expected native int or pointer, but got VT
		//IL_0b3e: Expected Ref, but got VT
		//IL_0b4b: Expected native int or pointer, but got VT
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected Obj, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected Obj, but got Unknown
		//IL_0b90: Expected Obj, but got F4
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected Obj, but got Unknown
		//IL_06c5: Expected I4, but got Obj
		//IL_0462: Expected I, but got Obj
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0735: Expected Obj, but got I4
		//IL_0c93: Expected Obj, but got I4
		//IL_0880: Expected Obj, but got I
		//IL_0890: Expected Obj, but got I
		//IL_08a0: Expected Obj, but got I
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected Obj, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected Obj, but got Unknown
		//IL_07a5: Expected Obj, but got I
		//IL_07b5: Expected Obj, but got I
		//IL_07c5: Expected Obj, but got I
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected Obj, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected Obj, but got Unknown
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got Unknown
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 88;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 80;
		obj3 = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v220 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 + 128);
		Quaternion quaternion = (Quaternion)(obj2 + 112);
		object obj5 = obj2 - -64;
		object obj6 = obj2 + 104;
		object obj7 = obj2 + 48;
		Quaternion quaternion2 = (Quaternion)(obj2 + 32);
		object obj8 = obj2 + 16;
		if (mesh != null)
		{
			return;
		}
		Vector3[] normals = mesh.normals;
		object obj9 = normals + 12;
		object obj10 = default;
		object obj13 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
		{
			object obj11 = normals + 16;
			object obj12 = obj13 * 12;
			object obj14 = obj11 + obj12;
			((Quaternion*)(nint)quaternion)->x = (float)obj14;
			Quaternion quaternion3 = quaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v149+8]");
			((Quaternion*)(nint)quaternion3)->z = 0f;
			((Vector2*)(nint)vector)->x = quaternion.x;
			_ = quaternion.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
			((Vector2*)(nint)vector)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23+8]");
			_ = 0;
			object obj15 = normals + 16;
			object obj16 = obj13 * 12;
			object obj17 = obj15 + obj16;
			obj17 = vector.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (UnityEngine.Vector2)+8]");
			_ = 0;
			obj10 = obj13 + 1;
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S3_v4 (Il2CppMethodInfo)+C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S3_v5+60]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S3_v6+38]");
		object obj20 = 0;
		object obj21 = obj20 & 0x1FFF;
		object obj22 = obj21 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v565 @ S4_v10 (should have been resolved before IL gen)");
		int[] triangles = mesh.triangles;
		if (triangles != null)
		{
			object obj23 = triangles + 12;
			if (obj23 != null)
			{
				object obj24 = obj23;
				object obj25 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
				{
					object obj26 = triangles + 16;
					object obj27 = obj25 << 2;
					object obj28 = obj26 + obj27;
					((Quaternion*)(nint)quaternion)->x = (float)obj28;
					obj6 = quaternion.x;
					((Vector2*)(nint)vector)->x = (float)obj6;
					((List<Color32>)(object)cUV1s).Add((Color32)vector);
					object obj29 = obj25 + 1;
					obj24 = obj23;
					obj25 = obj29;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D4");
		nint num4 = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v53 (Il2CppClass<UnityEngine.Vector4>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num5 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v186 (Il2CppClass<UnityEngine.Vector4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23+8]");
		_ = 0;
		Vector4 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D4");
		((Vector2*)(nint)vector)->x = quaternion2.x;
		_ = quaternion2.z;
		Vector4 vector3 = vector;
		nint num6 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v65 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num7 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v182 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Quaternion*)(nint)quaternion)->x = (float)obj7;
		Quaternion quaternion4 = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
		((Quaternion*)(nint)quaternion4)->z = 0f;
		((Vector2*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31+8]");
		_ = 0;
		Quaternion quaternion5 = quaternion * (Quaternion)vector;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector4[] tangents = mesh.tangents;
		bool flag = tangents == null;
		object obj32 = 0;
		if (!flag)
		{
			object obj33 = tangents + 12;
			bool flag2 = obj33 == null;
			obj32 = 0;
			if (!flag2)
			{
				object obj34 = obj33;
				object obj35 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34))
				{
					obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					object obj36 = tangents + 16;
					object obj37 = obj35 * 12;
					object obj38 = obj36 + obj37;
					obj7 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S1_v108+8]");
					_ = 0;
					nint num8 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S0_v159 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
					object obj39 = (nint)0 & (nint)0x200;
					if (obj39 != null)
					{
						nint num9 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v178 (Il2CppClass<UnityEngine.Quaternion>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Quaternion*)(nint)quaternion)->x = (float)obj5;
					Quaternion quaternion6 = quaternion;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23+8]");
					((Quaternion*)(nint)quaternion6)->z = 0f;
					((Vector2*)(nint)vector)->x = (float)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
					_ = 0;
					((Quaternion*)quaternion2)->SetLookRotation((Vector3)quaternion, vector);
					((Vector2*)(nint)vector)->x = quaternion2.x;
					_ = quaternion2.z;
					object obj40 = tangents + 16;
					object obj41 = obj35 * 12;
					object obj42 = obj40 + obj41;
					obj42 = vector.x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (UnityEngine.Vector2)+8]");
					_ = 0;
					object obj43 = obj35 + 1;
					obj34 = obj33;
					obj35 = obj43;
				}
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S3_v38 (Il2CppMethodInfo)+C]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S3_v39+60]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S3_v40+38]");
				obj32 = 0;
				object obj46 = obj32 & 0x1FFF;
				obj22 = obj46 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v565 @ S4_v10 (should have been resolved before IL gen)");
			}
		}
		Vector2[] uv = mesh.uv2;
		if (uv != null && uv.Length != 0)
		{
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S3_v32 (Il2CppMethodInfo)+C]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S3_v33+60]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S3_v34+38]");
			obj32 = 0;
			object obj49 = obj32 & 0x1FFF;
			obj22 = obj49 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v565 @ S4_v10 (should have been resolved before IL gen)");
		}
		Vector2[] uv2 = mesh.uv3;
		if (uv2 != null && uv2.Length != 0)
		{
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ S3_v27 (Il2CppMethodInfo)+C]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S3_v28+60]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S3_v29+38]");
			obj32 = 0;
			object obj52 = obj32 & 0x1FFF;
			obj22 = obj52 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v565 @ S4_v10 (should have been resolved before IL gen)");
		}
		object obj53 = submeshIndex + 12;
		Vector4[] array = tangents;
		int num13 = 0;
		List<int> list3 = default;
		while (num13 < (nint)obj53)
		{
			object obj54 = submeshIndex + 16;
			int num14 = num13 << 2;
			object obj55 = obj54 + num14;
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S0_v96 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj56 = (nint)0 & (nint)0x200;
			if (obj56 != null)
			{
				nint num16 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S0_v136 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)obj55 != null))
			{
				int num17 = Mesh.DefaultDimensionForChannel((VertexAttribute)mesh);
				if (num13 < num17)
				{
					int[] indices = mesh.GetIndices(num13);
					List<int> list = (List<int>)(indices + 12);
					if (list != null)
					{
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
						bool flag3 = obj3 == null;
						bool flag4 = !flag3;
						List<int> list2 = (List<int>)(object)array;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							list3._002Ector();
							obj3 = list3;
							nint num18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S4_v17 (Il2CppMethodInfo)+C]");
							object obj57 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S4_v18+60]");
							object obj58 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S4_v19+48]");
							object obj59 = 0;
							object obj60 = obj59 & 0x7FF;
							object obj61 = obj60 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v655 @ S5_v15 (should have been resolved before IL gen)");
							list2 = list3;
						}
						array = (Vector4[])(object)list2;
						object obj62 = 0;
						while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62) < System.Runtime.CompilerServices.Unsafe.As<List<int>, UIntPtr>(ref list))
						{
							object obj63 = indices + 16;
							object obj64 = obj62 << 2;
							Vector4[] array2 = (Vector4[])(object)(obj63 + obj64);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cVertices @ L3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
							object obj65 = 0 + array2;
							array2 = (Vector4[])obj65;
							object obj66 = obj62 + 1;
							array = array2;
							obj62 = obj66;
						}
						object obj67 = obj3;
						nint num19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ S3_v21 (Il2CppMethodInfo)+C]");
						object obj68 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ S3_v22+60]");
						object obj69 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ S3_v23+38]");
						obj32 = 0;
						object obj70 = obj32 & 0x1FFF;
						obj22 = obj70 + 113696;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v565 @ S4_v10 (should have been resolved before IL gen)");
					}
				}
			}
			int num20 = num13 + 1;
			num13 = num20;
		}
	}
}
