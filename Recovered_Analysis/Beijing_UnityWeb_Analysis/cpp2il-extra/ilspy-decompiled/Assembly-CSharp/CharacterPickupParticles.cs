using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Cloud;
using SYBO.Common.Utilities;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Visuals;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CharacterPickupParticles : MonoBehaviour
{
	[Serializable]
	private class EffectDetails
	{
		public Transform target;

		public float duration;

		public AnimationCurve scaleCurve;

		private Renderer _renderer;

		private Material _materialInstance;

		public Renderer Renderer
		{
			get
			{
				//IL_0007: Expected Obj, but got F4
				return (Renderer)duration;
			}
		}

		public Material MaterialInstance
		{
			get
			{
				//IL_0132: Expected I, but got Obj
				//IL_0148: Expected Obj, but got I
				//IL_0013: Expected I, but got Obj
				//IL_0060: Expected I, but got Obj
				//IL_0076: Expected Obj, but got I
				//IL_00a1: Expected I, but got Obj
				//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Expected Obj, but got Unknown
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (_renderer != null)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
					{
						object obj3 = this + 20;
						Renderer component = target.GetComponent<Renderer>();
						obj3 = component;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
						UnityEngine.Object context = default;
						SDebug.LogAssertion("A EffectDetails.target of CharacterPickupParticles is null, please fix!", context);
					}
				}
				return (Material)(object)_renderer;
			}
		}

		public unsafe EffectDetails()
		{
			//IL_01ec: Expected Obj, but got I
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Expected Obj, but got Unknown
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Expected Obj, but got Unknown
			//IL_0293: Expected Obj, but got I
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected Obj, but got Unknown
			//IL_02c8: Expected Obj, but got I
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected Obj, but got Unknown
			//IL_02fd: Expected Obj, but got I
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected Obj, but got Unknown
			//IL_0332: Expected Obj, but got I
			//IL_038a: Expected Obj, but got I
			//IL_039f: Expected Obj, but got I
			//IL_001b: Expected Obj, but got I
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected Obj, but got Unknown
			//IL_0057: Expected I, but got Obj
			//IL_006d: Expected Obj, but got I
			//IL_0098: Expected I, but got Obj
			//IL_00ef: Expected I4, but got Obj
			//IL_0114: Expected VT, but got I4
			//IL_0114: Expected Obj, but got I4
			AnimationCurve animationCurve = scaleCurve;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UnityEngine.AnimationCurve)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7+17]");
			if ((nint)0 != 0)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v6 (Il2CppMethodInfo)+18]");
				object obj2 = 0;
				object obj3 = obj2;
				object obj4 = obj3 & 0x1FFF;
				object obj5 = obj4 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S3_v5 (should have been resolved before IL gen)");
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ComputeShader computeShader = default;
				if (computeShader.FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					GameObject gameObject = default;
					gameObject.layer = (int)"FocusPoint";
					int layer = gameObject.layer;
					HierarchyUtility.ReparentByHierarchyPathType((Transform)layer, HierarchyPathType.Dynamic, (Vector3)0);
					float num4 = duration;
					float num5 = duration;
					float num6 = duration;
					float num7 = duration;
					float num8 = duration;
					float num9 = duration;
					AnimationCurve animationCurve2 = scaleCurve;
					IntPtr ptr = animationCurve2.m_Ptr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S2_v13 (System.Single)+D4]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S3_v8 (System.Single)+E4]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S4_v5 (System.Single)+E0]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S5_v3 (System.Single)+DC]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S6_v3 (System.Single)+E8]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S7_v3 (System.Single)+8C]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S8_v4 (System.IntPtr)+14]");
					((SocialManager)(object)computeShader).FetchRegisterUserParams(out *(string*)gameObject, out *(string*)num10, out *(string*)num11, out *(string*)num12, out *(string*)num13, out *(string*)num14, out *(string*)num15, out *(string*)null);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CharacterModelPreviewFactory.ModelSetupObject modelSetupObject = default;
			object obj7 = modelSetupObject + 24;
			obj7 = target;
			object obj8 = modelSetupObject + 8;
			AnimationCurve animationCurve3 = scaleCurve;
			IntPtr ptr2 = animationCurve3.m_Ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v9 (System.IntPtr)+24]");
			obj8 = 0;
			object obj9 = modelSetupObject + 12;
			AnimationCurve animationCurve4 = scaleCurve;
			IntPtr ptr3 = animationCurve4.m_Ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v14 (System.IntPtr)+28]");
			obj9 = 0;
			object obj10 = modelSetupObject + 16;
			AnimationCurve animationCurve5 = scaleCurve;
			IntPtr ptr4 = animationCurve5.m_Ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v19 (System.IntPtr)+2C]");
			obj10 = 0;
			object obj11 = modelSetupObject + 20;
			AnimationCurve animationCurve6 = scaleCurve;
			IntPtr ptr5 = animationCurve6.m_Ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v24 (System.IntPtr)+30]");
			obj11 = 0;
			AnimationCurve animationCurve7 = scaleCurve;
			IntPtr ptr6 = animationCurve7.m_Ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v28 (System.IntPtr)+34]");
			bool useCustomEventScreenIdle = (nint)0 != 0;
			modelSetupObject.UseCustomEventScreenIdle = useCustomEventScreenIdle;
			AnimationCurve animationCurve8 = scaleCurve;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v24 (UnityEngine.AnimationCurve)+C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v25+18]");
			((Action<CharacterModelPreviewFactory.ModelSetupObject>)0)(modelSetupObject);
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public EffectDetails details;

		public Material material = (Material)0.05f;

		public _003C_003Ec__DisplayClass18_0()
		{
			//IL_000b: Expected Obj, but got F4
		}

		internal void _003CEffectCoroutine_003Eb__0(float t)
		{
			//IL_000a: Expected Obj, but got F4
			details = (EffectDetails)t;
		}
	}

	private sealed class _003CEffectCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EffectDetails details;

		public CharacterPickupParticles _003C_003E4__this;

		private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Expected Obj, but got Unknown
				//IL_00ef: Expected Obj, but got I4
				//IL_0127: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Expected Obj, but got Unknown
				//IL_013c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Expected Obj, but got Unknown
				//IL_017f: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003Ec__DisplayClass18_0 obj = _003C_003E8__1;
						Material materialInstance = obj.details.MaterialInstance;
						((Renderer)(object)materialInstance).shadowCastingMode = ShadowCastingMode.Off;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj2 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj3 = default;
				obj2 = obj3;
				object obj4 = _003C_003E8__1 + 8;
				obj4 = details;
				_003C_003Ec__DisplayClass18_0 obj5 = _003C_003E8__1;
				EffectDetails effectDetails = obj5.details;
				float end = ScrollRect.RubberDelta(0f, 360f);
				((Dropdown)(object)effectDetails.target).AlphaFadeList(0f, 0f, end);
				object obj6 = _003C_003E8__1 + 12;
				_003C_003Ec__DisplayClass18_0 obj7 = _003C_003E8__1;
				bool flag = ((_003CEffectCoroutine_003Ed__18)(object)obj7.details).MoveNext();
				obj6 = flag;
				_003C_003Ec__DisplayClass18_0 obj8 = _003C_003E8__1;
				EffectDetails effectDetails2 = obj8.details;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				object obj10 = default;
				object obj9 = obj10 + 16;
				obj9 = _003C_003E8__1;
				object obj11 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
				IEnumerator routine = default;
				Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto(routine);
				obj11 = coroutine;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public unsafe _003CEffectCoroutine_003Ed__18(int _003C_003E1__state)
		{
			//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ad: Expected Obj, but got Unknown
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c0: Expected Obj, but got Unknown
			//IL_04c8: Expected Obj, but got I4
			//IL_04d6: Expected I, but got Obj
			//IL_04ec: Expected Obj, but got I
			//IL_051b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_008a: Expected I, but got Obj
			//IL_00a0: Expected Obj, but got I
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Expected Obj, but got Unknown
			//IL_055b: Expected Obj, but got I
			//IL_0577: Expected Obj, but got I
			//IL_0588: Expected Obj, but got I
			//IL_059d: Expected Obj, but got I
			//IL_0117: Expected Obj, but got I4
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected Obj, but got Unknown
			//IL_013b: Expected Obj, but got I
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected Obj, but got Unknown
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected Obj, but got Unknown
			//IL_0181: Expected Obj, but got I
			//IL_0191: Expected Obj, but got I
			//IL_01a1: Expected Obj, but got I
			//IL_01be: Expected Obj, but got I
			//IL_00cb: Expected I, but got Obj
			//IL_01d3: Expected Obj, but got I
			//IL_01e3: Expected Obj, but got I
			//IL_01f5: Expected Obj, but got I
			//IL_0209: Expected Obj, but got I
			//IL_027e: Expected Obj, but got I
			//IL_0293: Expected Obj, but got I
			//IL_02a9: Expected Obj, but got I
			//IL_02b9: Expected Obj, but got I
			//IL_02cf: Expected Obj, but got I
			//IL_0236: Expected Obj, but got I
			//IL_0246: Expected Obj, but got I
			//IL_0263: Expected Obj, but got I
			//IL_02e4: Expected Obj, but got I
			//IL_02fa: Expected Obj, but got I
			//IL_030a: Expected Obj, but got I
			//IL_0320: Expected Obj, but got I
			//IL_0335: Expected Obj, but got I
			//IL_0345: Expected Obj, but got I
			//IL_0355: Expected Obj, but got I
			//IL_0365: Expected Obj, but got I
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e7: Expected Obj, but got Unknown
			//IL_0451: Expected Obj, but got I4
			//IL_0451: Expected Obj, but got I4
			//IL_0451: Expected Obj, but got I
			//IL_0451: Expected VT, but got I
			//IL_0451: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 12;
			obj = this;
			object obj3 = obj2 + 8;
			obj3 = _003C_003E1__state;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj6 = default;
				object obj5 = obj6 + 16;
				obj5 = obj2;
				int num3 = this._003C_003E1__state;
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj7 = obj6 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25 (System.Int32)+C]");
				GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)0);
				obj7 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+10]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v35+8]");
				GameObject gameObject2 = ((Component)0).gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+8]");
				int layer = ((GameObject)0).layer;
				((Transform)(object)gameObject2).parentInternal = (Transform)layer;
				object obj9 = obj6 + 12;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S3_v4 (Il2CppMethodInfo)+18]");
				object obj10 = (object)((object)0 & 0x1FFF) + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v173 @ S4_v5 (should have been resolved before IL gen)");
				object obj11 = default;
				obj9 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+10]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v32+8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v41+84]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v33+C]");
				((Mesh)num7).PrintErrorCantAccessChannel(VertexAttribute.Position);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+10]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v44+8]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v45+10]");
				int num8 = ((ComputeShader)0).FindKernel(null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj17 = 0;
				if (num8 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+10]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v48+8]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v37+8C]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v49+10]");
					((Mesh)num9).PrintErrorCantAccessChannel(VertexAttribute.Position);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v37+8C]");
					((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v50+88]");
				((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v53+98]");
				((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v56+90]");
				((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v59+94]");
				((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				object obj27 = 0;
				bool flag = (object)_003C_003E4__this != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterPickupParticles+<EffectCoroutine>d__18)+15]");
				bool flag2 = (nint)0 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterPickupParticles+<EffectCoroutine>d__18)+16]");
				bool bytesAreSaved = (nint)0 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				CloudWorkingCopy.LocalItem.GetDataStreamFunction getDataStreamFunction = default;
				((Delegate)getDataStreamFunction).method_ptr = (IntPtr)0;
				((Delegate)getDataStreamFunction).method = (nint)__ldftn(CharacterModelPreviewFactory._003C_003Ec__DisplayClass16_2._003CBuildCharacter_003Eb__1);
				object obj28 = getDataStreamFunction + 16;
				obj28 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v62+80]");
				nint num10 = 0;
				object name = _003C_003E2__current;
				EffectDetails revision = details;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S3_v8+84]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S4_v7+88]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S5_v5+8C]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+C]");
				((CloudWorkingCopy.LocalItem)num10)._002Ector((string)name, (string)(object)revision, (DateTime?)(object)num11, (byte)num12 != 0, (byte)num13 != 0, (string)0, (string)flag, 0, (ICloudUserData)flag2, bytesAreSaved, getDataStreamFunction);
			}
			else
			{
				object msg = ((IConvertible)"could not find preview character model for '").ToType((Type)_003C_003E2__current, (IFormatProvider)(object)"'.");
				SDebug.LogFormat((string)msg, null);
				_003C_003E8__1(null);
			}
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_013f: Expected I, but got Obj
			//IL_0155: Expected Obj, but got I
			//IL_0179: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0185: Expected Obj, but got I4
			//IL_00a1: Expected I, but got Obj
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)_003C_003E8__1 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)_003C_003E1__state).FindKernel(null) != 0)
				{
					object obj3 = this + 24;
					Material materialInstance = ((EffectDetails)this).MaterialInstance;
					Material sharedMaterial = ((Renderer)(object)materialInstance).sharedMaterial;
					obj3 = sharedMaterial;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
					UnityEngine.Object context = default;
					SDebug.LogAssertion("A EffectDetails.target of CharacterPickupParticles is null, please fix!", context);
				}
			}
			return (byte)(int)_003C_003E8__1 != 0;
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

	public static Vector3 coinEfxOffset;

	public GameObject CoinEFX;

	public GameObject PowerUpEFX;

	public Transform master;

	public AudioClipInfo CoinPickup;

	public AudioClipInfo PowerUpPickup;

	public float CoinDistanceForStairway;

	private int coinStairway;

	private int flyWay;

	private int[] pentatonicScale;

	public AnimationCurve compressCurve;

	private EffectDetails coinEffect;

	private EffectDetails powerupEffect;

	private HuntTokenCollectVFXManager huntTokenCollectVFXManager;

	private void Start()
	{
		//IL_000b: Expected I4, but got F4
		//IL_0016: Expected Obj, but got F4
		flyWay = 0;
		pentatonicScale = (int[])0.7f;
		CancelInvoke();
	}

	private unsafe void OnJetpackStop()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got VT
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(CharacterPickupParticles.OnJetpackStop);
		object obj3 = obj2 + 16;
		obj3 = this;
		object obj4 = ex + 32;
		Delegate obj5 = ((Delegate)(object)((Exception)ex)._stackTraceString).CombineImpl(obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj4 = obj6;
		object obj7 = this + 60;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj7 = componentInChildren;
	}

	public void PickedUpCoin(Transform trans)
	{
		//IL_01a4: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_0145: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterPickupParticles)+90]");
		if ((UnityEngine.Object)0 != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterPickupParticles)+EC]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterPickupParticles)+EC]");
			((AvatarAnimations)0).StartIdlePopupAnimations();
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterPickupParticles)+E8]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Vector3 focusPoint = ((AvatarEyeAnimation)(object)trans).GetFocusPoint();
		}
	}

	private IEnumerator EffectCoroutine(EffectDetails details)
	{
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(CharacterMaterial);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<CharacterMaterial>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterMaterial);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v22 (Il2CppClass<CharacterMaterial>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj3 = default;
		object obj2 = obj3 + 16;
		object obj4 = default;
		obj2 = obj4;
		return (IEnumerator)(((Exception)new NullReferenceException())?._data);
	}

	public void PickedUpPowerUp()
	{
		flyWay = 0;
	}

	public void PickedUpDefaultPowerUp()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<So>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)PowerUpPickup, false);
		PickedUpHuntToken();
	}

	public void PickedUpHuntToken()
	{
		List<Material> routine = ((ColorTeleboardMenuEffect)this).CollectMaterials((CharacterModel)(object)powerupEffect);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)routine);
	}

	public CharacterPickupParticles()
	{
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (huntTokenCollectVFXManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)"PickedUpHuntToken is called before the huntTokenCollectVFXManager is set!");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			huntTokenCollectVFXManager._002Ector();
		}
	}
}
