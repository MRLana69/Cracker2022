using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Visuals;
using UnityEngine;

namespace SYBO.Common.Utilities;

public static class MeshUtil
{
	private sealed class _003CCombineMeshesAsync_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

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

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0401: Expected Obj, but got I4
			//IL_00e4: Expected Obj, but got I4
			//IL_0441: Expected Obj, but got I4
			//IL_0112: Expected Obj, but got I
			//IL_075d: Expected Obj, but got I4
			//IL_0e12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e17: Expected Obj, but got Unknown
			//IL_079d: Expected Obj, but got I
			//IL_04af: Expected Obj, but got I
			//IL_0140: Expected Obj, but got I
			//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ec: Expected Obj, but got Unknown
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Expected Obj, but got Unknown
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Expected Obj, but got Unknown
			//IL_0318: Unknown result type (might be due to invalid IL or missing references)
			//IL_031d: Expected Obj, but got Unknown
			//IL_0e6a: Expected Obj, but got I4
			//IL_0809: Expected Obj, but got I
			//IL_04f7: Expected Obj, but got I
			//IL_0181: Expected Obj, but got I
			//IL_091f: Expected Obj, but got I
			//IL_0875: Expected Obj, but got I
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected Obj, but got Unknown
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected Obj, but got Unknown
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected Obj, but got Unknown
			//IL_094b: Expected Obj, but got I
			//IL_0954: Unknown result type (might be due to invalid IL or missing references)
			//IL_0959: Expected Obj, but got Unknown
			//IL_08e1: Expected Obj, but got I
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected Obj, but got Unknown
			//IL_020d: Expected VT, but got Obj
			//IL_020d: Expected Obj, but got I
			//IL_099d: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a2: Expected Obj, but got Unknown
			//IL_09bf: Expected I, but got Obj
			//IL_054d: Expected Obj, but got I
			//IL_0562: Expected Obj, but got I
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected Obj, but got Unknown
			//IL_0231: Expected Obj, but got I
			//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e83: Expected Obj, but got Unknown
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_0579: Expected Obj, but got Unknown
			//IL_058f: Expected Obj, but got I
			//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a7: Expected Obj, but got Unknown
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected Obj, but got Unknown
			//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c4: Expected Obj, but got Unknown
			//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d2: Expected Obj, but got Unknown
			//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ea: Expected Obj, but got Unknown
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f8: Expected Obj, but got Unknown
			//IL_0418: Expected Obj, but got I4
			//IL_0610: Unknown result type (might be due to invalid IL or missing references)
			//IL_0615: Expected Obj, but got Unknown
			//IL_061e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0623: Expected Obj, but got Unknown
			//IL_0636: Unknown result type (might be due to invalid IL or missing references)
			//IL_063b: Expected VT, but got Unknown
			//IL_0644: Unknown result type (might be due to invalid IL or missing references)
			//IL_0649: Expected VT, but got Unknown
			//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c99: Expected Obj, but got Unknown
			//IL_0cda: Expected Obj, but got I
			//IL_0668: Unknown result type (might be due to invalid IL or missing references)
			//IL_066d: Expected Obj, but got Unknown
			//IL_0676: Unknown result type (might be due to invalid IL or missing references)
			//IL_067b: Expected Obj, but got Unknown
			//IL_068e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0693: Expected Obj, but got Unknown
			//IL_069c: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a1: Expected Obj, but got Unknown
			//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d68: Expected Obj, but got Unknown
			//IL_0d82: Expected Obj, but got I
			//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06be: Expected VT, but got Unknown
			//IL_0a63: Expected Obj, but got I
			//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a78: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 592;
			_ = 0;
			_ = 0;
			object obj3;
			bool result;
			nint num6 = default;
			int num8 = default;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					obj3 = 0;
					goto IL_0e24;
				}
				result = false;
			}
			else
			{
				_003C_003E1__state = -1;
				if (meshReceiveCallback == null)
				{
					result = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj4 = default;
					bool flag = obj4 == null;
					result = false;
					if (!flag)
					{
						nint num = 0;
						nint num2 = 0;
						IntPtr intPtr = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v227 @ S4_v13 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.MeshFilter, UnityEngine.Matrix4x4>>>)+4] (should have been resolved before IL gen)");
						Dictionary<MeshFilter, Matrix4x4> dictionary = default;
						_003ClocalPosMapping_003E5__2 = dictionary;
						object obj5 = 0;
						object obj6 = obj;
						object obj7 = default;
						Mesh mesh = default;
						int num3 = default;
						int num4 = default;
						Mesh mesh2 = default;
						Mesh mesh3 = default;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v314+C]");
							if ((UnityEngine.Object)0 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v314+C]");
								Mesh sharedMesh = ((MeshFilter)0).sharedMesh;
								if (sharedMesh != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v314+C]");
									Transform transform = ((Component)0).transform;
									Matrix4x4 localToWorldMatrix = transform.localToWorldMatrix;
									object obj8 = obj + 448;
									object obj9 = obj + 512;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
									object obj10 = obj + 448;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
									object obj11 = obj6 + -64;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
									Dictionary<MeshFilter, Matrix4x4> dictionary2 = _003ClocalPosMapping_003E5__2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v314+C]");
									dictionary2.Add((MeshFilter)0, (Matrix4x4)mesh);
									object obj12 = mesh - -64;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v314+C]");
									Mesh sharedMesh2 = ((MeshFilter)0).sharedMesh;
									int vertexCount = sharedMesh2.vertexCount;
									num3 = vertexCount + num4;
									mesh2 = (Mesh)(mesh3 + 1);
									obj6 = obj12;
								}
							}
							object obj13 = obj5 + 1;
							obj5 = obj13;
						}
						bool flag2 = (object)mesh2 == null;
						result = false;
						if (!flag2)
						{
							bool flag3 = num3 > 65534;
							result = false;
							if (!flag3)
							{
								Transform transform2 = parentGO.transform;
								Matrix4x4 worldToLocalMatrix = transform2.worldToLocalMatrix;
								object obj14 = obj + 512;
								object obj15 = obj + 384;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								object obj16 = this + 32;
								object obj17 = obj + 512;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								List<Vector3> list = default;
								list._002Ector(num3);
								_003CcVertices_003E5__4 = list;
								List<Vector3> list2 = default;
								list2._002Ector(num3);
								_003CcNormals_003E5__5 = list2;
								List<Color32> list3 = default;
								list3._002Ector(num3);
								_003CcColors_003E5__6 = list3;
								List<Vector2> list4 = default;
								list4._002Ector(num3);
								_003CcUV1s_003E5__7 = list4;
								List<Vector2> list5 = default;
								list5._002Ector(num3);
								_003CcUV2s_003E5__8 = list5;
								nint num5 = 0;
								num6 = num5;
								nint num7 = 0;
								IntPtr intPtr2 = num7;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v795 @ S4_v19 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Material, System.Collections.Generic.List`1<System.Int32>>>>)+4] (should have been resolved before IL gen)");
								Dictionary<Material, List<int>> dictionary3 = default;
								_003CcSubMeshes_003E5__9 = dictionary3;
								num8 = 0;
								obj3 = 1;
								goto IL_0e24;
							}
						}
					}
				}
			}
			goto IL_0e04;
			IL_0e24:
			object obj18 = obj3;
			_003CCombineMeshesAsync_003Ed__6 obj19 = default;
			object obj20 = default;
			Mesh mesh4 = default;
			object obj38 = default;
			object obj41 = default;
			object obj42 = default;
			object obj44 = default;
			object obj45 = default;
			while (true)
			{
				if (obj18 == null)
				{
					int num9 = obj19._003Ci_003E5__10 + 1;
					num8 = num9;
					obj18 = 1;
					continue;
				}
				obj19._003Ci_003E5__10 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				nint num10;
				if ((nint)obj20 > num8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v194+C]");
					bool flag4 = (UnityEngine.Object)0 != null;
					bool flag5 = !flag4;
					num10 = num8;
					num6 = obj19._003Ci_003E5__10;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v194+C]");
						Mesh sharedMesh3 = ((MeshFilter)0).sharedMesh;
						bool flag6 = sharedMesh3 != null;
						bool flag7 = !flag6;
						num10 = num8;
						num6 = obj19._003Ci_003E5__10;
						if (!flag7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v194+C]");
							Mesh sharedMesh4 = ((MeshFilter)0).sharedMesh;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v191+8]");
							Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
							object obj21 = obj + 512;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							object obj22 = (nint)0 + (nint)32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							object obj23 = obj + 384;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7FB2");
							object obj24 = obj + 320;
							object obj25 = obj + 384;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							object obj26 = obj + 192;
							object obj27 = obj + 512;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							object obj28 = obj + 128;
							object obj29 = obj + 320;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							Matrix4x4 matrix4x = (Matrix4x4)(obj + 192);
							Matrix4x4 matrix4x2 = (Matrix4x4)(obj + 128);
							Matrix4x4 matrix4x3 = matrix4x * matrix4x2;
							object obj30 = obj + 256;
							object obj31 = obj + 384;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							object obj32 = obj - -64;
							object obj33 = obj + 256;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							Matrix4x4 transformMatrix = (Matrix4x4)(obj - -64);
							MergeMeshInto(sharedMesh4, sharedMaterials, transformMatrix, obj19._003CcVertices_003E5__4, obj19._003CcNormals_003E5__5, obj19._003CcColors_003E5__6, obj19._003CcUV1s_003E5__7, obj19._003CcUV2s_003E5__8, obj19._003CcSubMeshes_003E5__9);
							obj19._003C_003E2__current = null;
							obj19._003C_003E1__state = 1;
							result = true;
							break;
						}
					}
					goto IL_0e59;
				}
				mesh4._002Ector();
				Dictionary<Material, List<int>> dictionary4 = obj19._003CcSubMeshes_003E5__9;
				object obj34 = dictionary4._count - dictionary4._freeCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Vector3[] vertices = obj19._003CcVertices_003E5__4.ToArray();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v30+8]");
				((Mesh)0).vertices = vertices;
				List<Vector3> list6 = obj19._003CcNormals_003E5__5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v37 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
				if ((nint)0 >= (nint)1)
				{
					Vector3[] normals = obj19._003CcNormals_003E5__5.ToArray();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v30+8]");
					((Mesh)0).normals = normals;
				}
				List<Vector2> list7 = obj19._003CcUV1s_003E5__7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v44 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+C]");
				if ((nint)0 >= (nint)1)
				{
					Vector2[] uv = obj19._003CcUV1s_003E5__7.ToArray();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v30+8]");
					((Mesh)0).uv = uv;
				}
				List<Vector2> list8 = obj19._003CcUV2s_003E5__8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v51 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+C]");
				if ((nint)0 >= (nint)1)
				{
					Vector2[] uv2 = obj19._003CcUV2s_003E5__8.ToArray();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v30+8]");
					((Mesh)0).uv2 = uv2;
				}
				Dictionary<Material, List<int>> dictionary5 = obj19._003CcSubMeshes_003E5__9;
				int subMeshCount = dictionary5._count - dictionary5._freeCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v30+8]");
				((Mesh)0).subMeshCount = subMeshCount;
				Color32[] colors = obj19._003CcColors_003E5__6.ToArray();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v30+8]");
				((Mesh)0).colors32 = colors;
				object obj35 = obj + 512;
				Dictionary<Material, List<int>>.KeyCollection keys = obj19._003CcSubMeshes_003E5__9.Keys;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+208]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+200]");
				_ = 0;
				object obj36 = obj + 576;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
				_ = 0;
				nint num11 = unchecked((nint)null);
				nint num12 = num6;
				while (true)
				{
					_ = 0;
					object obj37 = obj + 576;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj38 == null)
						{
							goto IL_0c8b;
						}
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj39 = num11 << 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v30+C]");
								object obj40 = 0 + obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24C]");
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
										nint num13 = num11 + 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag8 = (nint)0 != 1;
										num11 = num13;
										num12 = num13;
										if (flag8)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										num10 = num13;
										num12 = num13;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										num10 = num11;
										num12 = 0;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									num10 = num11;
									num12 = 0;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								num10 = num11;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							num10 = num11;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						num10 = num11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag9 = obj41 != obj42;
					object obj43 = obj44;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_0c8b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						obj43 = obj45;
					}
					_ = 0;
					object obj46 = obj + 512;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj19 = (_003CCombineMeshesAsync_003Ed__6)0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					num6 = num12;
					goto IL_0e59;
					IL_0c8b:
					object obj47 = obj + 512;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AF2A");
					Action<ModelInfo> action = obj19.meshReceiveCallback;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v814 @ S0_v82 (System.Action`1<SYBO.Common.Utilities.ModelInfo>)+C] (should have been resolved before IL gen)");
					obj19._003ClocalPosMapping_003E5__2 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					object obj48 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					obj19._003CcVertices_003E5__4 = null;
					obj19._003CcNormals_003E5__5 = null;
					obj19._003CcColors_003E5__6 = null;
					obj19._003CcUV1s_003E5__7 = null;
					obj19._003CcUV2s_003E5__8 = null;
					obj19._003CcSubMeshes_003E5__9 = null;
					result = false;
					break;
				}
				break;
				IL_0e59:
				num8 = (int)num10;
				obj18 = 0;
			}
			goto IL_0e04;
			IL_0e04:
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
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

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0020: Expected Obj, but got I4
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected Obj, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			object obj3 = _003C_003E1__state + 3;
			if (obj3 == null || ((nint)obj3 != 1 && (nint)obj3 != 2 && (nint)obj3 != 3 && (nint)obj3 == 4))
			{
				object obj4 = obj + 28;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj5 = obj + 20;
				object obj6 = obj5;
				((_003CCombineMeshesAsync_003Ed__9)obj6)._003C_003Em__Finally1();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @254");
				}
			}
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_21d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_21dc: Expected Obj, but got Unknown
			//IL_21ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_21f4: Expected Obj, but got Unknown
			//IL_221c: Expected Obj, but got I
			//IL_0d95: Expected Obj, but got I4
			//IL_224a: Unknown result type (might be due to invalid IL or missing references)
			//IL_224f: Expected Obj, but got Unknown
			//IL_215a: Unknown result type (might be due to invalid IL or missing references)
			//IL_215f: Expected Obj, but got Unknown
			//IL_2403: Expected Obj, but got I
			//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e14: Expected Obj, but got Unknown
			//IL_0e73: Expected Obj, but got I
			//IL_0df3: Expected Obj, but got I
			//IL_1218: Expected Obj, but got I
			//IL_122d: Expected Obj, but got I
			//IL_013a: Expected I, but got Obj
			//IL_0143: Expected Obj, but got I4
			//IL_2418: Expected Obj, but got I
			//IL_1f97: Expected Obj, but got I
			//IL_1fb1: Expected Obj, but got I
			//IL_2329: Unknown result type (might be due to invalid IL or missing references)
			//IL_232e: Expected Obj, but got Unknown
			//IL_2348: Expected Obj, but got I
			//IL_235e: Expected Obj, but got I
			//IL_2374: Expected Obj, but got I
			//IL_238a: Expected Obj, but got I
			//IL_23a0: Expected Obj, but got I
			//IL_23b6: Expected Obj, but got I
			//IL_23cc: Expected Obj, but got I
			//IL_0eec: Expected Obj, but got I
			//IL_0f09: Expected Obj, but got I
			//IL_0f19: Expected Obj, but got I
			//IL_0f35: Expected Obj, but got I
			//IL_129d: Expected Obj, but got I
			//IL_0783: Expected Obj, but got I
			//IL_0f7b: Expected Obj, but got I
			//IL_0f8b: Expected Obj, but got I
			//IL_0fa7: Expected Obj, but got I
			//IL_2021: Expected Obj, but got I
			//IL_12f6: Expected Obj, but got I
			//IL_0fed: Expected Obj, but got I
			//IL_0ffd: Expected Obj, but got I
			//IL_1019: Expected Obj, but got I
			//IL_105f: Expected Obj, but got I
			//IL_106f: Expected Obj, but got I
			//IL_108b: Expected Obj, but got I
			//IL_1826: Expected Obj, but got I
			//IL_01de: Expected Obj, but got I
			//IL_10d1: Expected Obj, but got I
			//IL_10e1: Expected Obj, but got I
			//IL_10fd: Expected Obj, but got I
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected Obj, but got Unknown
			//IL_1149: Expected Obj, but got I
			//IL_1425: Unknown result type (might be due to invalid IL or missing references)
			//IL_142a: Expected Obj, but got Unknown
			//IL_1440: Expected Obj, but got I
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected Obj, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected Obj, but got Unknown
			//IL_029e: Expected Obj, but got I
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Expected Obj, but got Unknown
			//IL_13db: Expected Obj, but got I
			//IL_1184: Expected Obj, but got I
			//IL_119a: Expected Obj, but got I4
			//IL_205c: Expected Obj, but got I4
			//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ac: Expected Obj, but got Unknown
			//IL_191f: Expected Obj, but got I
			//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ef: Expected Obj, but got Unknown
			//IL_14f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_14fd: Expected Obj, but got Unknown
			//IL_1516: Unknown result type (might be due to invalid IL or missing references)
			//IL_151b: Expected Obj, but got Unknown
			//IL_1524: Unknown result type (might be due to invalid IL or missing references)
			//IL_1529: Expected Obj, but got Unknown
			//IL_0341: Expected Obj, but got I
			//IL_1541: Unknown result type (might be due to invalid IL or missing references)
			//IL_1546: Expected Obj, but got Unknown
			//IL_154f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1554: Expected Obj, but got Unknown
			//IL_1567: Unknown result type (might be due to invalid IL or missing references)
			//IL_156c: Expected VT, but got Unknown
			//IL_1575: Unknown result type (might be due to invalid IL or missing references)
			//IL_157a: Expected VT, but got Unknown
			//IL_19a5: Expected Obj, but got I
			//IL_19b5: Expected Obj, but got I
			//IL_15c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c9: Expected Obj, but got Unknown
			//IL_15d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_15d7: Expected Obj, but got Unknown
			//IL_03cc: Expected Obj, but got I
			//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a19: Expected Obj, but got Unknown
			//IL_1b1b: Expected Obj, but got I
			//IL_1b2b: Expected Obj, but got I
			//IL_1a1b: Expected Obj, but got I
			//IL_1631: Expected Obj, but got I
			//IL_1640: Unknown result type (might be due to invalid IL or missing references)
			//IL_1645: Expected Obj, but got Unknown
			//IL_164e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1653: Expected Obj, but got Unknown
			//IL_1666: Unknown result type (might be due to invalid IL or missing references)
			//IL_166b: Expected Obj, but got Unknown
			//IL_0a5d: Expected Obj, but got I4
			//IL_0457: Expected Obj, but got I
			//IL_1c25: Expected Obj, but got I
			//IL_1c35: Expected Obj, but got I
			//IL_1b9f: Expected Obj, but got I
			//IL_16b5: Expected Obj, but got I
			//IL_16f8: Expected Obj, but got I
			//IL_04e2: Expected Obj, but got I
			//IL_1c9b: Expected Obj, but got I
			//IL_1da8: Expected Obj, but got I
			//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4f: Expected Obj, but got Unknown
			//IL_056d: Expected Obj, but got I
			//IL_1e2e: Expected Obj, but got I
			//IL_1e3e: Expected Obj, but got I
			//IL_1e54: Expected Obj, but got I
			//IL_0bb2: Expected Obj, but got I
			//IL_1eaa: Expected Obj, but got I
			//IL_1eba: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ebf: Expected Obj, but got Unknown
			//IL_1ed4: Expected Obj, but got I
			//IL_1ef0: Expected Obj, but got I
			//IL_1f0b: Expected Obj, but got I
			//IL_1f14: Expected Obj, but got I4
			//IL_05f8: Expected Obj, but got I
			//IL_060d: Expected Obj, but got I
			//IL_0636: Expected Obj, but got I
			//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca7: Expected Obj, but got Unknown
			//IL_06ac: Expected Obj, but got I
			//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c5: Expected Obj, but got Unknown
			//IL_0731: Expected Obj, but got I
			//IL_0768: Expected Obj, but got I
			//IL_0dd8: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 496;
			_ = 0;
			object obj3 = obj + 424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
			object obj4 = obj + 492;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+160]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17+8]");
			bool result;
			object obj6;
			object obj7;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17+8]");
				if ((nint)0 != 1)
				{
					result = false;
					obj6 = obj;
					goto IL_2241;
				}
				_ = -3;
				obj7 = 0;
				goto IL_22e3;
			}
			_ = -1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj9;
			object obj17 = default;
			if ((nint)0 != 1)
			{
				object obj8 = default;
				bool flag = obj8 == null;
				result = false;
				obj6 = obj;
				if (flag)
				{
					goto IL_2241;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						nint num = unchecked((nint)null);
						obj9 = 0;
						object obj11 = default;
						object obj13 = default;
						object obj14 = default;
						object obj16 = default;
						object obj22 = default;
						object obj24 = default;
						object obj26 = default;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
							object obj10 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								break;
							}
							if ((nint)obj11 <= num)
							{
								goto IL_0172;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
							object obj12 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								goto IL_08f5;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								goto IL_0904;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj13 == null)
								{
									goto IL_225e;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											if (obj14 == null)
											{
												goto IL_225e;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												goto IL_0a62;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												goto IL_0a71;
											}
											object obj15 = obj9 + obj16;
											obj17++;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												object obj18 = 0;
												while (true)
												{
													object obj19 = obj18;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1833 @ S0_v824+C]");
													bool flag2 = (nint)obj19 >= 0;
													obj9 = obj15;
													if (flag2)
													{
														break;
													}
													object obj20 = obj18 << 2;
													object obj21 = obj22 + obj20;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ S0_v732+C]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1971 @ S0_v837+10]");
														_ = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															_ = 0;
															object obj23 = obj + 488;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 == 1)
															{
																goto IL_0bc6;
															}
															if (obj24 != null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E8]");
																object obj25 = 0;
																goto IL_2279;
															}
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 == 1)
																	{
																		goto IL_0cc3;
																	}
																	object obj25 = obj26;
																	goto IL_2279;
																}
															}
															goto IL_0cb4;
														}
													}
													goto IL_0bb7;
													IL_2279:
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														object obj27 = obj18 + 1;
														obj18 = obj27;
														continue;
													}
													goto IL_0cd2;
												}
												goto IL_225e;
											}
											goto IL_0a80;
										}
										goto IL_0da9;
									}
								}
								goto IL_08e6;
							}
							goto IL_0913;
							IL_225e:
							nint num2 = num + 1;
							num = num2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_207f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_207f;
			IL_1732:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1723:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_11bd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_22e3:
			object obj28 = obj5;
			object obj29 = obj7;
			object obj33 = default;
			object obj35 = default;
			object obj59 = default;
			while (true)
			{
				object obj31;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ L6_v2+A0]");
					object obj30 = (nint)0 + (nint)1;
					obj31 = obj30;
				}
				else
				{
					_ = 0;
					object obj32 = obj33 + 124;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj34 = 0;
					if (obj35 == null)
					{
						goto IL_1f46;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S0_v468+88]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_119f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+160]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ S0_v531+5C]");
					object obj38 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ S0_v532+10]");
					object obj39 = (nint)0 + (nint)1;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_11ae;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ S0_v549+60]");
					object obj41 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ S0_v550+10]");
					object obj42 = (nint)0 + (nint)1;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_11bd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ S0_v567+64]");
					object obj44 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ S0_v568+10]");
					object obj45 = (nint)0 + (nint)1;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_11cc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ S0_v585+68]");
					object obj47 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ S0_v586+10]");
					object obj48 = (nint)0 + (nint)1;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_11db;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ S0_v603+6C]");
					object obj50 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ S0_v604+10]");
					object obj51 = (nint)0 + (nint)1;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_11ea;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj52 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_11f9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj53 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ S0_v625+98]");
					_ = 0;
					obj31 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S0_v25+9C]");
				object obj55 = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj56 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S0_v27+C]");
					if ((nint)obj56 < 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
						object obj57 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_13e0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
						object obj58 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_13ef;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_13fe;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ S0_v334+C]");
							if ((nint)obj59 <= 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
								obj28 = 0;
							}
							else
							{
								object obj60 = obj + 352;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
								object obj61 = (nint)0 + (nint)28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_1714;
								}
								_ = 0;
								object obj62 = obj + 288;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_1723;
								}
								object obj63 = obj + 200;
								object obj64 = obj + 288;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								_ = 0;
								object obj65 = obj + 136;
								object obj66 = obj + 352;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								object obj67 = obj + 72;
								object obj68 = obj + 200;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								Matrix4x4 matrix4x = (Matrix4x4)(obj + 136);
								Matrix4x4 matrix4x2 = (Matrix4x4)(obj + 72);
								Matrix4x4 matrix4x3 = matrix4x * matrix4x2;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_1732;
								}
								object obj69 = obj + 424;
								object obj70 = obj + 288;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_1741;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
								object obj71 = 0;
								_ = 0;
								object obj72 = obj + 8;
								object obj73 = obj + 424;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								object obj74 = obj + 8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @41");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_1750;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
								object obj75 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1911 @ S0_v450+18]");
								bool flag3 = (nint)0 == 0;
								obj28 = obj75;
								if (!flag3)
								{
									goto IL_16e2;
								}
							}
							obj29 = 0;
							continue;
						}
						goto IL_140d;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								goto IL_1ac0;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
							object obj76 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ S0_v74+94]");
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
											object obj77 = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
													object obj78 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ S0_v135+60]");
													object obj79 = 0;
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														goto IL_1afc;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1491 @ S0_v136+C]");
													if ((nint)0 >= (nint)1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
														object obj80 = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																goto IL_1b0b;
															}
														}
														goto IL_1aa2;
													}
													goto IL_1b0b;
												}
											}
											goto IL_1aed;
										}
									}
									goto IL_1ade;
								}
							}
							goto IL_1acf;
						}
					}
					goto IL_1ab1;
				}
				goto IL_2035;
				IL_1c15:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj81 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1674 @ S0_v171+68]");
				object obj82 = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					goto IL_1d40;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1675 @ S0_v172+C]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj83 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_1d4f;
						}
					}
					goto IL_1d22;
				}
				goto IL_1d4f;
				IL_1b0b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj84 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1574 @ S0_v153+64]");
				object obj85 = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1575 @ S0_v154+C]");
					if ((nint)0 < (nint)1)
					{
						goto IL_1c15;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj86 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_1c15;
						}
					}
					goto IL_1d31;
				}
				goto IL_2044;
				IL_1d4f:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					goto IL_1f19;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj87 = 0;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
						object obj88 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
						object obj89 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2000 @ S0_v223+74]");
						object obj90 = (nint)0 + (nint)1;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2000 @ S0_v223+74]");
							object obj91 = (nint)0 << 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2000 @ S0_v223+78]");
							object obj92 = 0 + obj91;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
							object obj93 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
							object obj94 = (nint)0 + (nint)148;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
							obj33 = 0;
							obj29 = 1;
							continue;
						}
						goto IL_1f37;
					}
				}
				goto IL_1f28;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1f46:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj95 = (nint)0 + (nint)124;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj96 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S0_v486+18]");
				if ((nint)0 != 0)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_207f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					obj96 = 0;
				}
				object obj97 = obj96 + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj98 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj99 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj100 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj101 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj102 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj103 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
				object obj104 = 0;
				_ = 0;
				result = false;
				obj6 = obj;
				goto IL_2241;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_13fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_11ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_16e2:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
			object obj105 = 0;
			_ = 1;
			result = true;
			obj6 = obj;
			goto IL_2241;
			IL_11cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1acf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_140d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_08f5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_13e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0904:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1ac0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0913:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1741:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1ab1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_13ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1714:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0da9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1750:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_2035:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0a62:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_207f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj106 = default;
			object obj107 = default;
			bool flag4 = obj106 == obj107;
			bool flag5 = !flag4;
			bool flag6 = default;
			result = flag6;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag7 = (nint)0 != 1;
				result = false;
				obj6 = obj;
				if (flag7)
				{
					goto IL_2241;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				bool flag8 = default;
				result = flag8;
			}
			_ = 0;
			object obj108 = obj + 416;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			goto IL_2241;
			IL_0a71:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_2241:
			object obj109 = obj6 + 416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AF27");
			return result;
			IL_0a80:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_119f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_11db:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_11f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1d31:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1d40:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0bb7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1f28:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0bc6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1afc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1aed:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1f37:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0cb4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1f19:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0cc3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1ade:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_2044:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1d22:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0cd2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_1aa2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_08e6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
			IL_0172:
			bool flag9 = obj17 == null;
			result = false;
			obj6 = obj;
			if (!flag9)
			{
				bool flag10 = (nint)obj9 > 65534;
				result = false;
				obj6 = obj;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
					object obj110 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj111 = obj + 288;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj112 = obj + 352;
							object obj113 = obj + 288;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
							object obj114 = (nint)0 + (nint)28;
							object obj115 = obj + 352;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
									object obj116 = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
											object obj117 = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
													object obj118 = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
															object obj119 = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
																	object obj120 = 0;
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
																			object obj121 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
																			object obj122 = 0;
																			_ = 0;
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v693+10]");
																			nint num3 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v693+18]");
																			object obj123 = num3 - 0;
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
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
																					object obj124 = 0;
																					_ = 0;
																					object obj125 = obj + 264;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+110]");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
																						object obj126 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+110]");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1EC]");
																						object obj127 = 0;
																						_ = -3;
																						obj33 = obj127;
																						obj7 = 1;
																						goto IL_22e3;
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
																			goto IL_207f;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	goto IL_207f;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															goto IL_207f;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													goto IL_207f;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											goto IL_207f;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_207f;
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
					goto IL_207f;
				}
			}
			goto IL_2241;
			IL_11ae:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_207f;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public static IList<ObjectModelInfo> GetMeshInfos(IList<CombineableMesh> combineableMeshes)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		List<ObjectModelInfo> list = default;
		int capacity = default;
		list._002Ector(capacity);
		object obj = 0;
		object obj2 = default;
		CombineableMesh combineableMesh = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			ObjectModelInfo meshInfo = combineableMesh.MeshInfo;
			list.Add(meshInfo);
			object obj3 = obj + 1;
			obj = obj3;
		}
		return list;
	}

	public static IList<ObjectModelInfo> GetMeshInfos(IList<MeshRenderer> meshRenderers)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0031: Expected VT, but got Obj
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		List<ObjectModelInfo> list = default;
		int capacity = default;
		list._002Ector(capacity);
		object obj = 0;
		object obj2 = default;
		Component component2 = default;
		ObjectModelInfo objectModelInfo = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshFilter));
			Component component = component2.GetComponent(typeFromHandle);
			bool flag = (object)component == null;
			Component meshFilter = null;
			if (!flag)
			{
				bool flag2 = (object)component.GetType() == typeof(MeshFilter);
				meshFilter = component;
				if (!flag2)
				{
					meshFilter = null;
				}
			}
			objectModelInfo.MeshRenderer = (MeshRenderer)component2;
			objectModelInfo.MeshFilter = (MeshFilter)meshFilter;
			list.Add(objectModelInfo);
			object obj3 = obj + 1;
			obj = obj3;
		}
		return list;
	}

	public static ModelInfo CombineMeshes(GameObject parentGO, IList<MeshRenderer> meshRenderers)
	{
		IList<ObjectModelInfo> meshInfos = GetMeshInfos(meshRenderers);
		return CombineMeshes(parentGO, meshInfos);
	}

	public static ModelInfo CombineMeshes(GameObject parentGO, IList<CombineableMesh> combineableMeshes)
	{
		IList<ObjectModelInfo> meshInfos = GetMeshInfos(combineableMeshes);
		return CombineMeshes(parentGO, meshInfos);
	}

	public static ModelInfo CombineMeshes(GameObject parentGO, IList<ObjectModelInfo> meshInfos)
	{
		_ = 0;
		throw new ArgumentException();
	}

	public static ModelInfo CombineMeshes(GameObject parentGO, bool combineInactive)
	{
		CombineableMesh[] componentsInChildren = parentGO.GetComponentsInChildren<CombineableMesh>(combineInactive);
		return CombineMeshes(parentGO, componentsInChildren);
	}

	public static IEnumerator CombineMeshesAsync(GameObject parentGO, IList<ObjectModelInfo> meshInfos, Action<ModelInfo> meshReceiveCallback)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public static ModelInfo CombineMeshes(GameObject go)
	{
		//IL_00dc: Expected VT, but got Obj
		//IL_002e: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00a8: Expected Obj, but got I
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshRenderer));
		Component[] componentsInChildren = go.GetComponentsInChildren(typeFromHandle, includeInactive: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		IList<MeshRenderer> list = default;
		ModelInfo result = CombineMeshes(go, list);
		object obj = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v4 (System.Collections.Generic.IList`1<UnityEngine.MeshRenderer>)+C]");
			if (0 <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)list + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18+10]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject != go)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18+10]");
				((Renderer)0).enabled = false;
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
		return result;
	}

	private unsafe static void MergeMeshInto(Mesh mesh, Material[] materials, Matrix4x4 transformMatrix, List<Vector3> cVertices, List<Vector3> cNormals, List<Color32> cColors, List<Vector2> cUV1s, List<Vector2> cUV2s, Dictionary<Material, List<int>> cSubMeshes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I
		//IL_06d0: Expected Ref, but got VT
		//IL_06e2: Expected Ref, but got VT
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected VT, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected VT, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected VT, but got Unknown
		//IL_008f: Expected Ref, but got VT
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0191: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I4
		//IL_043c: Expected Obj, but got I
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected VT, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04c5: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_02fe: Expected Obj, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected VT, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected VT, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03c6: Expected Obj, but got I4
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Ref, but got Unknown
		//IL_0565: Expected Obj, but got I
		//IL_084c: Expected Obj, but got I4
		//IL_063f: Expected Obj, but got I
		//IL_065b: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_060f: Expected Obj, but got I
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 240;
		_ = 0;
		_ = 0;
		_ = 0;
		if (!(mesh != null))
		{
			return;
		}
		Vector3[] vertices = mesh.vertices;
		object obj3 = default;
		while (vertices.Length > (nint)obj3)
		{
			object obj4 = obj3 * 12;
			object obj5 = (object)vertices + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v122+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v122+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
			_ = 0;
			Vector3 point = (Vector3)(obj + 24);
			Vector3 vector = ((Matrix4x4*)transformMatrix)->MultiplyPoint3x4(point);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
			_ = 0;
			object obj6 = obj3 * 12;
			object obj7 = (object)vertices + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S4_v4 (Il2CppRgctx<System.Collections.Generic.List`1<UnityEngine.Vector3>>)+3C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v154 @ S4_v5+4] (should have been resolved before IL gen)");
		Color32[] colors = mesh.colors32;
		if (colors != null && colors.Length != 0)
		{
			object obj10 = colors.Length;
			obj3 = 0;
			List<Color32> list = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj11 = obj3 << 2;
				object obj12 = (object)colors + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v113+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				_ = 0;
				Color32 item = (Color32)(obj + 116);
				list.Add(item);
				object obj13 = obj3 + 1;
				obj10 = colors.Length;
				obj3 = obj13;
			}
		}
		Vector4 column = ((Matrix4x4*)transformMatrix)->GetColumn(2);
		Vector4 column2 = ((Matrix4x4*)transformMatrix)->GetColumn(1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Vector3 forward = (Vector3)(obj + 104);
		Vector3 upwards = (Vector3)(obj + 88);
		Quaternion quaternion = Quaternion.LookRotation(forward, upwards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Vector3[] normals = mesh.normals;
		if (normals != null && normals.Length != 0)
		{
			object obj14 = normals.Length;
			obj3 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj15 = obj3 * 12;
				object obj16 = (object)normals + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S1_v81+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S1_v81+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
				_ = 0;
				object obj17 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				_ = 0;
				Quaternion quaternion2 = (Quaternion)(obj + 72);
				Vector3 vector2 = (Vector3)(obj + 56);
				Vector3 vector3 = quaternion2 * vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
				_ = 0;
				object obj18 = obj3 * 12;
				object obj19 = (object)normals + obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				object obj20 = obj3 + 1;
				obj14 = normals.Length;
				obj3 = obj20;
			}
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S4_v35 (Il2CppRgctx<System.Collections.Generic.List`1<UnityEngine.Vector3>>)+3C]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v405 @ S4_v36+4] (should have been resolved before IL gen)");
		}
		Vector2[] uv = mesh.uv;
		if (uv != null && uv.Length != 0)
		{
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S4_v30 (Il2CppRgctx<System.Collections.Generic.List`1<UnityEngine.Vector2>>)+3C]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v415 @ S4_v31+4] (should have been resolved before IL gen)");
		}
		Vector2[] uv2 = mesh.uv2;
		if (uv2 != null && uv2.Length != 0)
		{
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S4_v25 (Il2CppRgctx<System.Collections.Generic.List`1<UnityEngine.Vector2>>)+3C]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v470 @ S4_v26+4] (should have been resolved before IL gen)");
		}
		int num9 = 0;
		List<int> list2 = default;
		while (num9 < materials.Length)
		{
			int num10 = num9 << 2;
			object obj24 = materials + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v69+10]");
			if ((UnityEngine.Object)0 != null)
			{
				int subMeshCount = mesh.subMeshCount;
				if (subMeshCount > num9)
				{
					int[] triangles = mesh.GetTriangles(num9);
					if (triangles.Length != 0)
					{
						_ = 0;
						ref List<int> value = ref *(List<int>*)(obj + 220);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v69+10]");
						bool flag = cSubMeshes.TryGetValue((Material)0, out value);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+DC]");
						if ((nint)0 == 0)
						{
							list2._002Ector();
							nint num11 = 0;
							nint num12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S5_v7 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Material, System.Collections.Generic.List`1<System.Int32>>>)+5C]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v587 @ S5_v8+4] (should have been resolved before IL gen)");
						}
						obj3 = 0;
						while (triangles.Length > (nint)obj3)
						{
							object obj26 = obj3 << 2;
							object obj27 = (object)triangles + obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cVertices @ L3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
							nint num13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S0_v100+10]");
							object obj28 = num13 + 0;
							object obj29 = obj3 + 1;
							obj3 = obj29;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+DC]");
						object obj30 = 0;
						nint num14 = 0;
						nint num15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S4_v15 (Il2CppRgctx<System.Collections.Generic.List`1<System.Int32>>)+3C]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v608 @ S4_v16+4] (should have been resolved before IL gen)");
					}
				}
			}
			int num16 = num9 + 1;
			num9 = num16;
		}
	}

	public static IEnumerator CombineMeshesAsync(GameObject parentGO, IList<ObjectModelInfo> meshInfos, Action<ModelInfo[]> meshReceiveCallback = null)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe static void MergeSubmeshInto(Mesh mesh, int submeshIndex, Matrix4x4 transformMatrix, List<Vector3> cVertices, List<Vector3> cNormals, List<Vector2> cUV1s, List<Vector2> cUV2s, List<int> cTriangles, Dictionary<int, int> oldToNewVertIDs)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0560: Expected Ref, but got VT
		//IL_0572: Expected Ref, but got VT
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected VT, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected VT, but got Unknown
		//IL_064c: Expected Obj, but got I4
		//IL_04e6: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Ref, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_017a: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected VT, but got Unknown
		//IL_01d6: Expected Ref, but got VT
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected VT, but got Unknown
		//IL_0244: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected VT, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected VT, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected VT, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected VT, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_0474: Expected F4, but got I
		//IL_046f: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 256);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (mesh == null)
		{
			return;
		}
		int[] triangles = mesh.GetTriangles(submeshIndex);
		Vector3[] vertices = mesh.vertices;
		Vector3[] normals = mesh.normals;
		bool flag = normals == null;
		bool flag2 = true;
		if (!flag)
		{
			bool flag3 = normals.Length == 0;
			flag2 = flag3;
		}
		Vector4 column = ((Matrix4x4*)transformMatrix)->GetColumn(2);
		Vector4 column2 = ((Matrix4x4*)transformMatrix)->GetColumn(1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
		_ = 0;
		Vector3 forward = (Vector3)(vector + 112);
		Vector3 upwards = (Vector3)(vector + 96);
		Quaternion quaternion = Quaternion.LookRotation(forward, upwards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
		_ = 0;
		Vector2[] uv = mesh.uv;
		bool flag4 = uv == null;
		bool flag5 = true;
		if (!flag4)
		{
			bool flag6 = uv.Length == 0;
			flag5 = flag6;
		}
		Vector2[] uv2 = mesh.uv2;
		bool flag7 = uv2 == null;
		bool flag8 = true;
		if (!flag7)
		{
			bool flag9 = uv2.Length == 0;
			flag8 = flag9;
		}
		object obj2 = 0;
		while (triangles.Length > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)triangles + obj3;
			ref int value = ref *(int*)(vector + 236);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v46+10]");
			if (!oldToNewVertIDs.TryGetValue(0, out value))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v46+10]");
				object obj5 = (nint)0 * (nint)12;
				object obj6 = (object)vertices + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v55+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v55+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
				_ = 0;
				Vector3 point = (Vector3)(vector + 80);
				Vector3 vector2 = ((Matrix4x4*)transformMatrix)->MultiplyPoint3x4(point);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+90]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+90]");
				_ = 0;
				Vector3 item = (Vector3)(vector - -64);
				cVertices.Add(item);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cVertices @ L3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
				object obj7 = -1;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S5_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>>)+5C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v346 @ S5_v7+4] (should have been resolved before IL gen)");
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v46+10]");
					object obj9 = (nint)0 * (nint)12;
					object obj10 = (object)normals + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v93+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v93+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
					_ = 0;
					Quaternion quaternion2 = (Quaternion)(vector + 48);
					Vector3 vector3 = (Vector3)(vector + 32);
					Vector3 vector4 = quaternion2 * vector3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+90]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+90]");
					_ = 0;
					Vector3 item2 = (Vector3)(vector + 16);
					cNormals.Add(item2);
				}
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v46+10]");
					int num3 = (int)((nint)0 << 3);
					object obj11 = uv + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S1_v85+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
					_ = 0;
					Vector2 item3 = vector + 8;
					cUV1s.Add(item3);
				}
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v46+10]");
					int num4 = (int)((nint)0 << 3);
					object obj12 = uv2 + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S1_v78+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
					((Vector2*)(nint)vector)->x = 0f;
					cUV2s.Add(vector);
				}
			}
			object obj13 = obj2 << 2;
			object obj14 = (object)triangles + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+EC]");
			_ = 0;
			object obj15 = obj2 + 1;
			obj2 = obj15;
		}
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S4_v5 (Il2CppRgctx<System.Collections.Generic.List`1<System.Int32>>)+3C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ S4_v6+4] (should have been resolved before IL gen)");
	}
}
