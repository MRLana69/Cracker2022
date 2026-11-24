using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Ionic.Zlib;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using Missions;
using SYBO.Common.Managers;
using SYBO.Components.Utilities;
using SYBO.Subway.Info;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UI.Screens.NotEnoughCurrencyPopupInternal;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using WeeklyHunt;

namespace UI.Screens;

public class CelebrationPopup : UIScreen
{
	private sealed class _003CBoxIdleAnimCoroutine_003Ed__164(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationReward reward;

		public CelebrationPopup _003C_003E4__this;

		public Transform rewardTrans;

		private Vector3 _003CbaseLocalPos_003E5__2;

		private float _003Ct_003E5__3;

		private Vector3 _003CnewLocalPos_003E5__4;

		private bool _003CdoneResetting_003E5__5;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e9: Expected Obj, but got Unknown
				//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f7: Expected Obj, but got Unknown
				//IL_00df: Expected VT, but got Obj
				//IL_0104: Unknown result type (might be due to invalid IL or missing references)
				//IL_0109: Expected Obj, but got Unknown
				//IL_014c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Expected Obj, but got Unknown
				//IL_0189: Unknown result type (might be due to invalid IL or missing references)
				//IL_018e: Expected Obj, but got Unknown
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022a: Expected Obj, but got Unknown
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_0235: Expected Obj, but got Unknown
				//IL_0243: Expected I, but got Obj
				//IL_0259: Expected Obj, but got I
				//IL_0482: Unknown result type (might be due to invalid IL or missing references)
				//IL_0487: Expected Obj, but got Unknown
				//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ce: Expected Obj, but got Unknown
				//IL_02d7: Expected Obj, but got I4
				//IL_02eb: Expected Obj, but got I4
				//IL_0284: Expected I, but got Obj
				//IL_0319: Unknown result type (might be due to invalid IL or missing references)
				//IL_031e: Expected Obj, but got Unknown
				//IL_0324: Unknown result type (might be due to invalid IL or missing references)
				//IL_0329: Expected Obj, but got Unknown
				//IL_032f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0334: Expected Obj, but got Unknown
				//IL_034b: Expected I, but got Obj
				//IL_0361: Expected Obj, but got I
				//IL_0501: Expected F4, but got I
				//IL_0501: Expected F4, but got I
				//IL_0510: Unknown result type (might be due to invalid IL or missing references)
				//IL_0515: Expected Obj, but got Unknown
				//IL_051b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0520: Expected Obj, but got Unknown
				//IL_053d: Expected F4, but got I
				//IL_053d: Expected F4, but got I
				//IL_0573: Unknown result type (might be due to invalid IL or missing references)
				//IL_0578: Expected Obj, but got Unknown
				//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_05c7: Expected Obj, but got Unknown
				//IL_05d0: Expected Obj, but got I4
				//IL_05e4: Expected Obj, but got I4
				//IL_038c: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 24);
				Transform transform2 = (Transform)(obj + 12);
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							goto IL_02f0;
						}
						return null;
					}
					_003C_003E1__state = -1;
					goto IL_01cf;
				}
				_003C_003E1__state = -1;
				CelebrationReward celebrationReward = reward;
				if (celebrationReward.CelebrationRewardOrigin != CelebrationRewardOrigin.WeeklyChallengeMysteryBox)
				{
					CelebrationReward celebrationReward2 = reward;
					if (celebrationReward2.CelebrationRewardOrigin != CelebrationRewardOrigin.WeeklyChallengeSuperMysteryBox)
					{
						goto IL_00c3;
					}
				}
				celebrationPopup.audioStateLoop.PlayReviveSound();
				goto IL_00c3;
				IL_00c3:
				Transform parentInternal = rewardTrans.parentInternal;
				transform2.localPosition = (Vector3)parentInternal;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				object obj2 = this + 28;
				obj2 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				celebrationPopup._stopIdleAnim = false;
				float num = NumberExtensions.MRound(0f, 6f);
				_003Ct_003E5__3 = num;
				object obj3 = this + 28;
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v66+8]");
				_ = 0;
				transform = (Transform)obj;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				object obj4 = this + 44;
				obj4 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				goto IL_01cf;
				IL_02f0:
				if (~(_003CdoneResetting_003E5__5 ? 1u : 0u) == 0)
				{
					return null;
				}
				object obj5 = this + 44;
				object obj6 = this + 44;
				object obj7 = this + 28;
				float unscaledTime = Time.unscaledTime;
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S4_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S4_v9 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float t = unscaledTime * 20f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v10+4]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S2_v5+4]");
				float num5 = Mathf.SmoothStep(num4, 0f, t);
				object obj9 = this + 44;
				object obj10 = this + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v23+4]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v15+4]");
				if (BaseInputModule.DetermineMoveDirection((float)num6, 0f) != MoveDirection.Left)
				{
					_003CdoneResetting_003E5__5 = true;
				}
				Transform parentInternal2 = rewardTrans.parentInternal;
				object obj11 = this + 44;
				transform2 = (Transform)obj11;
				Transform transform4 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S2_v10+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				Vector3 eulerAngles = transform.eulerAngles;
				object obj12 = this + 12;
				obj12 = 0;
				_003C_003E1__state = 2;
				return 1;
				IL_01cf:
				if (~(celebrationPopup._stopIdleAnim ? 1u : 0u) == 0)
				{
					_003CdoneResetting_003E5__5 = false;
					goto IL_02f0;
				}
				float unscaledTime2 = Time.unscaledTime;
				float num7 = _003Ct_003E5__3 + unscaledTime2;
				_003Ct_003E5__3 = num7;
				object obj13 = this + 44;
				object obj14 = this + 28;
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S3_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S3_v17 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num10 = _003Ct_003E5__3 * 2f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
				object obj16 = default;
				float num11 = (float)obj16 * 10f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v34+4]");
				float num12 = 0f + num11;
				Transform parentInternal3 = rewardTrans.parentInternal;
				object obj17 = this + 44;
				transform2 = (Transform)obj17;
				Transform transform5 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S2_v29+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				Vector3 eulerAngles2 = transform.eulerAngles;
				object obj18 = this + 12;
				obj18 = 0;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CStartIdleAnimationFor_003Ed__165(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform rewardTrans;

		public Vector3 baseLocalPos;

		private float _003Ct_003E5__2;

		private Vector3 _003CnewLocalPos_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e5: Expected Obj, but got Unknown
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_0083: Expected I, but got Obj
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Expected Obj, but got Unknown
				//IL_0122: Unknown result type (might be due to invalid IL or missing references)
				//IL_0127: Expected Obj, but got Unknown
				//IL_0170: Expected I, but got Obj
				//IL_0186: Expected Obj, but got I
				//IL_0239: Unknown result type (might be due to invalid IL or missing references)
				//IL_023e: Expected Obj, but got Unknown
				//IL_0244: Unknown result type (might be due to invalid IL or missing references)
				//IL_0249: Expected Obj, but got Unknown
				//IL_0257: Expected I, but got Obj
				//IL_026d: Expected Obj, but got I
				//IL_01b1: Expected I, but got Obj
				//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c1: Expected Obj, but got Unknown
				//IL_0406: Unknown result type (might be due to invalid IL or missing references)
				//IL_040b: Expected Obj, but got Unknown
				//IL_0414: Expected Obj, but got I4
				//IL_0428: Expected Obj, but got I4
				//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fb: Expected Obj, but got Unknown
				//IL_0298: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 12);
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)rewardTrans).FindKernel((string)null) == 0)
					{
						return null;
					}
					float num3 = NumberExtensions.MRound(0f, 6f);
					_003Ct_003E5__2 = num3;
					object obj3 = this + 20;
					obj = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v45+8]");
					_ = 0;
					transform = (Transform)obj;
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					object obj4 = this + 36;
					obj4 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
				}
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)rewardTrans).FindKernel((string)null) == 0)
				{
					object obj6 = this + 36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					return null;
				}
				float unscaledTime = Time.unscaledTime;
				float num6 = _003Ct_003E5__2 + unscaledTime;
				_003Ct_003E5__2 = num6;
				object obj7 = this + 36;
				object obj8 = this + 20;
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S3_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S3_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num9 = _003Ct_003E5__2 * 2f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
				object obj10 = default;
				float num10 = (float)obj10 * 10f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v18+4]");
				float num11 = 0f + num10;
				object obj11 = this + 36;
				obj = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S2_v14+8]");
				_ = 0;
				transform = (Transform)obj;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
				object obj12 = this + 12;
				obj12 = 0;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CAnimateScreenFlash_003Ed__169(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite effectSprite;

		public CelebrationPopup _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected VT, but got Unknown
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected Obj, but got Unknown
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Expected Obj, but got Unknown
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0046: Expected Obj, but got Unknown
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Expected Obj, but got Unknown
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected Obj, but got Unknown
				//IL_00ca: Expected Obj, but got I
				//IL_00df: Expected F4, but got Obj
				//IL_00da: Expected native int or pointer, but got VT
				//IL_00f9: Expected F4, but got Obj
				//IL_00f4: Expected native int or pointer, but got VT
				//IL_010e: Expected F4, but got I
				//IL_0109: Expected native int or pointer, but got VT
				//IL_011d: Expected I4, but got VT
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Expected Obj, but got Unknown
				//IL_0172: Expected F4, but got Obj
				//IL_016d: Expected native int or pointer, but got VT
				//IL_0187: Expected F4, but got I
				//IL_0182: Expected native int or pointer, but got VT
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Expected Obj, but got Unknown
				//IL_01ce: Expected Obj, but got I4
				//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ee: Expected Obj, but got Unknown
				//IL_0213: Expected Obj, but got I
				//IL_0228: Expected F4, but got Obj
				//IL_0223: Expected native int or pointer, but got VT
				//IL_0257: Expected F4, but got Obj
				//IL_0252: Expected native int or pointer, but got VT
				//IL_026c: Expected F4, but got I
				//IL_0267: Expected native int or pointer, but got VT
				object obj = default;
				Matrix4x4 matrix4x = (Matrix4x4)(obj + 88);
				object obj2 = obj + 72;
				object obj3 = obj + 48;
				object obj4 = obj + 32;
				object obj5 = obj + 68;
				object obj6 = obj + 16;
				object obj7 = obj - -64;
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						object obj8 = effectSprite + 80;
						obj3 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v41+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (UI.Screens.CelebrationPopup)+2E8]");
						obj4 = 0;
						obj7 = obj4;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
						Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
						obj2 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
						_ = 0;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC2");
						IEnumerator routine = default;
						Coroutine coroutine = celebrationPopup.StartCoroutine_Auto(routine);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (UI.Screens.CelebrationPopup)+2E8]");
				obj3 = 0;
				obj5 = obj3;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
				Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				effectSprite.rawPivot = (UIWidget.Pivot)matrix4x;
				object obj9 = effectSprite + 80;
				obj6 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v21+8]");
				_ = 0;
				Color black = Color.black;
				obj2 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				object obj10 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC2");
				IEnumerator routine2 = default;
				Coroutine coroutine2 = celebrationPopup.StartCoroutine_Auto(routine2);
				obj10 = coroutine2;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass173_0
	{
		public CelebrationReward reward;

		public _003C_003Ec__DisplayClass173_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal bool _003C_ShowReward_003Eb__0(HoverboardThemes.HoverboardTheme x)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			bool result = (((nint)0 != 2) ? true : true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			if ((nint)0 == 0)
			{
				result = false;
			}
			return result;
		}

		internal bool _003C_ShowReward_003Eb__1(HoverboardThemes.HoverboardTheme x)
		{
			CelebrationReward celebrationReward = reward;
			HoverboardThemes.ThemeIdentifier themeIdentifier = celebrationReward.bundledThemes.get_Item(0);
			return themeIdentifier == x.identifier;
		}
	}

	private sealed class _003C_ShowReward_003Ed__173(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public int currentRewardIndex;

		private _003C_003Ec__DisplayClass173_0 _003C_003E8__1;

		private GameObject _003CrewardGo_003E5__2;

		private GameObject _003ClabelGo_003E5__3;

		private CelebrationPopupLabelTemplate _003Ctemplate_003E5__4;

		private Animation _003Canim_003E5__5;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_4686: Unknown result type (might be due to invalid IL or missing references)
				//IL_468b: Expected VT, but got Unknown
				//IL_4694: Unknown result type (might be due to invalid IL or missing references)
				//IL_4699: Expected Ref, but got Unknown
				//IL_46a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_46a7: Expected Ref, but got Unknown
				//IL_46b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_46b5: Expected Ref, but got Unknown
				//IL_46be: Unknown result type (might be due to invalid IL or missing references)
				//IL_46c3: Expected Obj, but got Unknown
				//IL_46cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_46d1: Expected Ref, but got Unknown
				//IL_46da: Unknown result type (might be due to invalid IL or missing references)
				//IL_46df: Expected Obj, but got Unknown
				//IL_46e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_46ed: Expected Obj, but got Unknown
				//IL_46f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_46fb: Expected Obj, but got Unknown
				//IL_4704: Unknown result type (might be due to invalid IL or missing references)
				//IL_4709: Expected Obj, but got Unknown
				//IL_4712: Unknown result type (might be due to invalid IL or missing references)
				//IL_4717: Expected Obj, but got Unknown
				//IL_4720: Unknown result type (might be due to invalid IL or missing references)
				//IL_4725: Expected Obj, but got Unknown
				//IL_472e: Unknown result type (might be due to invalid IL or missing references)
				//IL_4733: Expected Obj, but got Unknown
				//IL_473c: Unknown result type (might be due to invalid IL or missing references)
				//IL_4741: Expected Obj, but got Unknown
				//IL_474a: Unknown result type (might be due to invalid IL or missing references)
				//IL_474f: Expected Obj, but got Unknown
				//IL_4758: Unknown result type (might be due to invalid IL or missing references)
				//IL_475d: Expected Obj, but got Unknown
				//IL_4766: Unknown result type (might be due to invalid IL or missing references)
				//IL_476b: Expected Obj, but got Unknown
				//IL_4774: Unknown result type (might be due to invalid IL or missing references)
				//IL_4779: Expected Obj, but got Unknown
				//IL_4782: Unknown result type (might be due to invalid IL or missing references)
				//IL_4787: Expected Obj, but got Unknown
				//IL_4790: Unknown result type (might be due to invalid IL or missing references)
				//IL_4795: Expected Obj, but got Unknown
				//IL_479e: Expected Obj, but got I4
				//IL_47ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_47b2: Expected Obj, but got Unknown
				//IL_47bb: Expected Obj, but got I4
				//IL_47c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_47c9: Expected Obj, but got Unknown
				//IL_47d2: Expected Obj, but got I4
				//IL_47db: Expected Obj, but got I4
				//IL_47e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_47e9: Expected Obj, but got Unknown
				//IL_47f2: Expected Obj, but got I4
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0156: Expected Obj, but got Unknown
				//IL_0173: Unknown result type (might be due to invalid IL or missing references)
				//IL_0178: Expected Obj, but got Unknown
				//IL_018e: Expected Obj, but got I
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ab: Expected Obj, but got Unknown
				//IL_01dd: Expected Obj, but got I4
				//IL_0282: Expected Obj, but got I4
				//IL_02d8: Expected Obj, but got I
				//IL_0549: Expected Obj, but got VT
				//IL_0556: Expected F4, but got Obj
				//IL_0551: Expected native int or pointer, but got VT
				//IL_0575: Expected F4, but got VT
				//IL_0570: Expected native int or pointer, but got VT
				//IL_058a: Expected F4, but got I
				//IL_0585: Expected native int or pointer, but got VT
				//IL_059f: Expected I4, but got VT
				//IL_059f: Expected Obj, but got I
				//IL_05ba: Expected Obj, but got I
				//IL_05e5: Expected Ref, but got VT
				//IL_05ff: Expected F4, but got Obj
				//IL_05fa: Expected native int or pointer, but got VT
				//IL_0614: Expected F4, but got I
				//IL_060f: Expected native int or pointer, but got VT
				//IL_061a: Unknown result type (might be due to invalid IL or missing references)
				//IL_061f: Expected Obj, but got Unknown
				//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e5a: Expected Obj, but got Unknown
				//IL_0e63: Expected Obj, but got I4
				//IL_0e8d: Expected Obj, but got I4
				//IL_02c2: Expected Obj, but got I4
				//IL_065b: Expected Obj, but got I4
				//IL_0681: Expected Obj, but got I
				//IL_0699: Unknown result type (might be due to invalid IL or missing references)
				//IL_069e: Expected Obj, but got Unknown
				//IL_06b6: Expected I, but got Obj
				//IL_06cc: Expected Obj, but got I
				//IL_0f3e: Expected Obj, but got I4
				//IL_0f3e: Expected Obj, but got I4
				//IL_0f3e: Expected Obj, but got I4
				//IL_0f50: Expected I, but got Obj
				//IL_0f66: Expected Obj, but got I
				//IL_0339: Expected I, but got Obj
				//IL_034f: Expected Obj, but got I
				//IL_486b: Expected Obj, but got I
				//IL_48da: Expected Obj, but got I
				//IL_4833: Expected Obj, but got I
				//IL_0762: Expected Obj, but got I
				//IL_0794: Expected Obj, but got VT
				//IL_07a1: Expected F4, but got Obj
				//IL_079c: Expected native int or pointer, but got VT
				//IL_07bb: Expected Ref, but got VT
				//IL_07da: Expected F4, but got VT
				//IL_07d5: Expected native int or pointer, but got VT
				//IL_07ef: Expected F4, but got I
				//IL_07ea: Expected native int or pointer, but got VT
				//IL_06f7: Expected I, but got Obj
				//IL_210d: Expected I, but got Obj
				//IL_2123: Expected Obj, but got I
				//IL_0f91: Expected I, but got Obj
				//IL_03e0: Expected Obj, but got I
				//IL_037a: Expected I, but got Obj
				//IL_0747: Expected Obj, but got I
				//IL_2094: Expected I4, but got Obj
				//IL_20a1: Expected Obj, but got I4
				//IL_4f95: Expected Obj, but got I
				//IL_4fa7: Expected I, but got Obj
				//IL_4fbd: Expected Obj, but got I
				//IL_0fe1: Expected Obj, but got I
				//IL_4934: Expected I, but got Obj
				//IL_494a: Expected Obj, but got I
				//IL_0411: Expected F4, but got VT
				//IL_040c: Expected native int or pointer, but got VT
				//IL_0426: Expected F4, but got I
				//IL_0421: Expected native int or pointer, but got VT
				//IL_03ca: Expected Obj, but got I
				//IL_0859: Expected Obj, but got I4
				//IL_4fe0: Unknown result type (might be due to invalid IL or missing references)
				//IL_4fe5: Expected Obj, but got Unknown
				//IL_5006: Expected Obj, but got I4
				//IL_214e: Expected I, but got Obj
				//IL_4f13: Expected Obj, but got I
				//IL_0ffc: Expected Obj, but got I
				//IL_0464: Expected Obj, but got I
				//IL_3552: Unknown result type (might be due to invalid IL or missing references)
				//IL_3557: Expected Obj, but got Unknown
				//IL_3560: Expected Obj, but got I4
				//IL_08ae: Expected Obj, but got I
				//IL_219b: Expected I, but got Obj
				//IL_1d98: Expected I, but got Obj
				//IL_105c: Expected Obj, but got I4
				//IL_0485: Expected Ref, but got F4
				//IL_04a3: Expected F4, but got VT
				//IL_049e: Expected native int or pointer, but got VT
				//IL_04b8: Expected F4, but got I
				//IL_04b3: Expected native int or pointer, but got VT
				//IL_04cb: Expected Obj, but got I4
				//IL_20d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_20dd: Expected Obj, but got Unknown
				//IL_20e6: Expected Obj, but got I4
				//IL_20fa: Expected Obj, but got I4
				//IL_08df: Expected F4, but got VT
				//IL_08da: Expected native int or pointer, but got VT
				//IL_08f4: Expected F4, but got I
				//IL_08ef: Expected native int or pointer, but got VT
				//IL_50e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_50ee: Expected Obj, but got Unknown
				//IL_1de8: Expected Obj, but got I
				//IL_106f: Expected I, but got Obj
				//IL_1085: Expected Obj, but got I
				//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0500: Expected Obj, but got Unknown
				//IL_051c: Expected Obj, but got I4
				//IL_0932: Expected Obj, but got I
				//IL_5061: Expected F4, but got VT
				//IL_505c: Expected native int or pointer, but got VT
				//IL_5076: Expected F4, but got I
				//IL_5071: Expected native int or pointer, but got VT
				//IL_507f: Expected Obj, but got VT
				//IL_5089: Unknown result type (might be due to invalid IL or missing references)
				//IL_508e: Expected Obj, but got Unknown
				//IL_50b5: Expected Obj, but got I
				//IL_4979: Expected Obj, but got I
				//IL_0953: Expected Ref, but got F4
				//IL_0971: Expected F4, but got VT
				//IL_096c: Expected native int or pointer, but got VT
				//IL_0986: Expected F4, but got I
				//IL_0981: Expected native int or pointer, but got VT
				//IL_0999: Expected Obj, but got I4
				//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0aee: Expected Obj, but got Unknown
				//IL_0b0a: Expected Obj, but got I4
				//IL_0b40: Expected Obj, but got I
				//IL_2374: Expected I, but got Obj
				//IL_238a: Expected Obj, but got I
				//IL_223b: Unknown result type (might be due to invalid IL or missing references)
				//IL_2240: Expected Obj, but got Unknown
				//IL_10b0: Expected I, but got Obj
				//IL_116b: Expected Obj, but got I
				//IL_1179: Expected I, but got Obj
				//IL_118f: Expected Obj, but got I
				//IL_3ce3: Unknown result type (might be due to invalid IL or missing references)
				//IL_3ce8: Expected Obj, but got Unknown
				//IL_3d0f: Expected F4, but got VT
				//IL_3d0a: Expected native int or pointer, but got VT
				//IL_3d24: Expected F4, but got I
				//IL_3d1f: Expected native int or pointer, but got VT
				//IL_3bd3: Expected I, but got Obj
				//IL_3be9: Expected Obj, but got I
				//IL_09ce: Expected Obj, but got I
				//IL_0b70: Expected VT, but got I4
				//IL_0b70: Expected Obj, but got I4
				//IL_1100: Expected Obj, but got I
				//IL_49a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_49a5: Expected Obj, but got Unknown
				//IL_49be: Expected Obj, but got I4
				//IL_40cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_40d0: Expected Obj, but got Unknown
				//IL_3e38: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e3d: Expected Obj, but got Unknown
				//IL_39af: Unknown result type (might be due to invalid IL or missing references)
				//IL_39b4: Expected Obj, but got Unknown
				//IL_39db: Expected F4, but got VT
				//IL_39d6: Expected native int or pointer, but got VT
				//IL_39f0: Expected F4, but got I
				//IL_39eb: Expected native int or pointer, but got VT
				//IL_09ff: Expected F4, but got VT
				//IL_09fa: Expected native int or pointer, but got VT
				//IL_0a14: Expected F4, but got I
				//IL_0a0f: Expected native int or pointer, but got VT
				//IL_52b9: Expected Ref, but got VT
				//IL_52c6: Expected Obj, but got VT
				//IL_52d3: Expected F4, but got Obj
				//IL_52ce: Expected native int or pointer, but got VT
				//IL_52f2: Expected F4, but got VT
				//IL_52ed: Expected native int or pointer, but got VT
				//IL_5307: Expected F4, but got I
				//IL_5302: Expected native int or pointer, but got VT
				//IL_5319: Expected I4, but got VT
				//IL_532c: Expected Ref, but got VT
				//IL_5339: Expected Obj, but got VT
				//IL_5346: Expected F4, but got Obj
				//IL_5341: Expected native int or pointer, but got VT
				//IL_134e: Expected Obj, but got I4
				//IL_11ba: Expected I, but got Obj
				//IL_5b31: Expected F4, but got VT
				//IL_5b2c: Expected native int or pointer, but got VT
				//IL_5b46: Expected F4, but got I
				//IL_5b41: Expected native int or pointer, but got VT
				//IL_40a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_40ad: Expected Obj, but got Unknown
				//IL_3f72: Unknown result type (might be due to invalid IL or missing references)
				//IL_3f77: Expected Obj, but got Unknown
				//IL_3f9e: Expected F4, but got VT
				//IL_3f99: Expected native int or pointer, but got VT
				//IL_3fb3: Expected F4, but got I
				//IL_3fae: Expected native int or pointer, but got VT
				//IL_3d61: Unknown result type (might be due to invalid IL or missing references)
				//IL_3d66: Expected Obj, but got Unknown
				//IL_3d8d: Expected F4, but got VT
				//IL_3d88: Expected native int or pointer, but got VT
				//IL_3da2: Expected F4, but got I
				//IL_3d9d: Expected native int or pointer, but got VT
				//IL_3db5: Expected Obj, but got I4
				//IL_3c7f: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c84: Expected Obj, but got Unknown
				//IL_3c14: Expected I, but got Obj
				//IL_3a26: Expected Obj, but got I
				//IL_3a37: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a3c: Expected Obj, but got Unknown
				//IL_3a45: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a4a: Expected Obj, but got Unknown
				//IL_3a62: Expected I, but got Obj
				//IL_3a78: Expected Obj, but got I
				//IL_0a52: Expected Obj, but got I
				//IL_1e1d: Expected VT, but got I
				//IL_1e1d: Expected Obj, but got I
				//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bda: Expected Obj, but got Unknown
				//IL_2579: Expected F4, but got VT
				//IL_2574: Expected native int or pointer, but got VT
				//IL_258e: Expected F4, but got I
				//IL_2589: Expected native int or pointer, but got VT
				//IL_25a0: Expected I4, but got VT
				//IL_25a9: Expected Obj, but got VT
				//IL_25be: Expected F4, but got Obj
				//IL_25b9: Expected native int or pointer, but got VT
				//IL_2528: Expected I, but got Obj
				//IL_510c: Expected Ref, but got VT
				//IL_5119: Expected Obj, but got VT
				//IL_5126: Expected F4, but got Obj
				//IL_5121: Expected native int or pointer, but got VT
				//IL_5145: Expected F4, but got VT
				//IL_5140: Expected native int or pointer, but got VT
				//IL_515a: Expected F4, but got I
				//IL_5155: Expected native int or pointer, but got VT
				//IL_516c: Expected I4, but got VT
				//IL_517f: Expected Ref, but got VT
				//IL_518c: Expected Obj, but got VT
				//IL_5199: Expected F4, but got Obj
				//IL_5194: Expected native int or pointer, but got VT
				//IL_2342: Unknown result type (might be due to invalid IL or missing references)
				//IL_2347: Expected Obj, but got Unknown
				//IL_13e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_13e9: Expected Obj, but got Unknown
				//IL_1410: Expected F4, but got VT
				//IL_140b: Expected native int or pointer, but got VT
				//IL_1425: Expected F4, but got I
				//IL_1420: Expected native int or pointer, but got VT
				//IL_1432: Expected Obj, but got VT
				//IL_1432: Expected Obj, but got I4
				//IL_1211: Unknown result type (might be due to invalid IL or missing references)
				//IL_1216: Expected Obj, but got Unknown
				//IL_123d: Expected F4, but got VT
				//IL_1238: Expected native int or pointer, but got VT
				//IL_1252: Expected F4, but got I
				//IL_124d: Expected native int or pointer, but got VT
				//IL_125f: Expected Obj, but got VT
				//IL_125f: Expected Obj, but got I4
				//IL_5a6c: Expected Obj, but got I4
				//IL_3feb: Unknown result type (might be due to invalid IL or missing references)
				//IL_3ff0: Expected Obj, but got Unknown
				//IL_4017: Expected F4, but got VT
				//IL_4012: Expected native int or pointer, but got VT
				//IL_402c: Expected F4, but got I
				//IL_4027: Expected native int or pointer, but got VT
				//IL_403f: Expected Obj, but got I4
				//IL_3e7d: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e82: Expected Obj, but got Unknown
				//IL_3ea9: Expected F4, but got VT
				//IL_3ea4: Expected native int or pointer, but got VT
				//IL_3ebe: Expected F4, but got I
				//IL_3eb9: Expected native int or pointer, but got VT
				//IL_5add: Expected F4, but got VT
				//IL_5ad8: Expected native int or pointer, but got VT
				//IL_5af2: Expected F4, but got I
				//IL_5aed: Expected native int or pointer, but got VT
				//IL_3c5c: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c61: Expected Obj, but got Unknown
				//IL_0a73: Expected Ref, but got F4
				//IL_0a91: Expected F4, but got VT
				//IL_0a8c: Expected native int or pointer, but got VT
				//IL_0aa6: Expected F4, but got I
				//IL_0aa1: Expected native int or pointer, but got VT
				//IL_0ab9: Expected Obj, but got I4
				//IL_25dd: Expected F4, but got Obj
				//IL_25d8: Expected native int or pointer, but got VT
				//IL_25f2: Expected F4, but got I
				//IL_25ed: Expected native int or pointer, but got VT
				//IL_25fb: Expected Obj, but got VT
				//IL_2608: Expected Obj, but got VT
				//IL_261d: Expected F4, but got Obj
				//IL_2618: Expected native int or pointer, but got VT
				//IL_2441: Expected F4, but got VT
				//IL_243c: Expected native int or pointer, but got VT
				//IL_2456: Expected F4, but got I
				//IL_2451: Expected native int or pointer, but got VT
				//IL_2468: Expected I4, but got VT
				//IL_2476: Expected I, but got Obj
				//IL_248c: Expected Obj, but got I
				//IL_23f0: Expected I, but got Obj
				//IL_127c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1281: Expected Obj, but got Unknown
				//IL_12a4: Expected I, but got Obj
				//IL_12ba: Expected Obj, but got I
				//IL_3ef6: Unknown result type (might be due to invalid IL or missing references)
				//IL_3efb: Expected Obj, but got Unknown
				//IL_3f22: Expected F4, but got VT
				//IL_3f1d: Expected native int or pointer, but got VT
				//IL_3f37: Expected F4, but got I
				//IL_3f32: Expected native int or pointer, but got VT
				//IL_3f4a: Expected Obj, but got I4
				//IL_3aa3: Expected I, but got Obj
				//IL_1e47: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e4c: Expected Obj, but got Unknown
				//IL_1e6c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e71: Expected Obj, but got Unknown
				//IL_48c3: Expected Obj, but got I4
				//IL_5242: Expected F4, but got Obj
				//IL_523d: Expected native int or pointer, but got VT
				//IL_5257: Expected F4, but got I
				//IL_5252: Expected native int or pointer, but got VT
				//IL_5260: Expected Obj, but got VT
				//IL_528e: Expected Obj, but got I4
				//IL_51b4: Expected Obj, but got VT
				//IL_51c9: Expected F4, but got Obj
				//IL_51c4: Expected native int or pointer, but got VT
				//IL_51e3: Expected F4, but got Obj
				//IL_51de: Expected native int or pointer, but got VT
				//IL_51f8: Expected F4, but got I
				//IL_51f3: Expected native int or pointer, but got VT
				//IL_5201: Expected Obj, but got VT
				//IL_520e: Expected Obj, but got VT
				//IL_5223: Expected F4, but got Obj
				//IL_521e: Expected native int or pointer, but got VT
				//IL_146b: Expected I, but got Obj
				//IL_1481: Expected Obj, but got I
				//IL_1886: Unknown result type (might be due to invalid IL or missing references)
				//IL_188b: Expected Obj, but got Unknown
				//IL_18b2: Expected F4, but got VT
				//IL_18ad: Expected native int or pointer, but got VT
				//IL_18c7: Expected F4, but got I
				//IL_18c2: Expected native int or pointer, but got VT
				//IL_18d4: Expected Obj, but got VT
				//IL_18d4: Expected Obj, but got I4
				//IL_4a0d: Expected F4, but got VT
				//IL_4a08: Expected native int or pointer, but got VT
				//IL_4a22: Expected F4, but got I
				//IL_4a1d: Expected native int or pointer, but got VT
				//IL_4a2f: Expected Ref, but got VT
				//IL_4a41: Expected F4, but got VT
				//IL_4a3c: Expected native int or pointer, but got VT
				//IL_4a56: Expected F4, but got I
				//IL_4a51: Expected native int or pointer, but got VT
				//IL_4a5f: Expected Obj, but got VT
				//IL_5b7c: Unknown result type (might be due to invalid IL or missing references)
				//IL_5b81: Expected Obj, but got Unknown
				//IL_5b9d: Expected Obj, but got I4
				//IL_40fb: Expected Obj, but got I
				//IL_4113: Unknown result type (might be due to invalid IL or missing references)
				//IL_4118: Expected Obj, but got Unknown
				//IL_412e: Unknown result type (might be due to invalid IL or missing references)
				//IL_4133: Expected Obj, but got Unknown
				//IL_415a: Expected F4, but got VT
				//IL_4155: Expected native int or pointer, but got VT
				//IL_416f: Expected F4, but got I
				//IL_416a: Expected native int or pointer, but got VT
				//IL_4182: Expected Obj, but got I4
				//IL_3af0: Expected I4, but got Obj
				//IL_3afd: Expected Obj, but got I4
				//IL_3479: Expected I, but got Obj
				//IL_348f: Expected Obj, but got I
				//IL_26af: Expected I4, but got Obj
				//IL_24b7: Expected I, but got Obj
				//IL_4a80: Expected Ref, but got F4
				//IL_4c05: Expected Obj, but got I
				//IL_4c16: Expected Obj, but got I4
				//IL_4c16: Expected Obj, but got I4
				//IL_12e5: Expected I, but got Obj
				//IL_4213: Expected Obj, but got I4
				//IL_595a: Expected I4, but got Obj
				//IL_595a: Expected Obj, but got I
				//IL_597d: Expected F4, but got I
				//IL_597d: Expected Obj, but got I
				//IL_5369: Expected Obj, but got I
				//IL_14ac: Expected I, but got Obj
				//IL_190d: Expected I, but got Obj
				//IL_1923: Expected Obj, but got I
				//IL_16f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_16f5: Expected Obj, but got Unknown
				//IL_171c: Expected F4, but got VT
				//IL_1717: Expected native int or pointer, but got VT
				//IL_1731: Expected F4, but got I
				//IL_172c: Expected native int or pointer, but got VT
				//IL_173e: Expected Obj, but got VT
				//IL_173e: Expected Obj, but got I4
				//IL_1a2c: Expected I, but got Obj
				//IL_1a42: Expected Obj, but got I
				//IL_427e: Expected Ref, but got F4
				//IL_429c: Expected F4, but got VT
				//IL_4297: Expected native int or pointer, but got VT
				//IL_42b1: Expected F4, but got I
				//IL_42ac: Expected native int or pointer, but got VT
				//IL_42c4: Expected Obj, but got I4
				//IL_3519: Expected VT, but got Obj
				//IL_34ba: Expected I, but got Obj
				//IL_1ed8: Expected Obj, but got I
				//IL_3445: Unknown result type (might be due to invalid IL or missing references)
				//IL_344a: Expected Obj, but got Unknown
				//IL_3466: Expected Obj, but got I4
				//IL_26e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_26ed: Expected Obj, but got Unknown
				//IL_2725: Expected Obj, but got I4
				//IL_2725: Expected Obj, but got I4
				//IL_4ae2: Expected F4, but got VT
				//IL_4add: Expected native int or pointer, but got VT
				//IL_4af7: Expected F4, but got I
				//IL_4af2: Expected native int or pointer, but got VT
				//IL_4b00: Expected Obj, but got VT
				//IL_4b2b: Expected Ref, but got F4
				//IL_4b45: Expected I, but got Obj
				//IL_4b5b: Expected Obj, but got I
				//IL_4d0d: Expected Ref, but got F4
				//IL_175b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1760: Expected Obj, but got Unknown
				//IL_1787: Expected F4, but got VT
				//IL_1782: Expected native int or pointer, but got VT
				//IL_179c: Expected F4, but got I
				//IL_1797: Expected native int or pointer, but got VT
				//IL_17a5: Expected Obj, but got VT
				//IL_4e83: Expected Obj, but got I
				//IL_3527: Expected VT, but got Obj
				//IL_353c: Expected F4, but got I
				//IL_353c: Expected Obj, but got VT
				//IL_1f09: Expected F4, but got VT
				//IL_1f04: Expected native int or pointer, but got VT
				//IL_1f1e: Expected F4, but got I
				//IL_1f19: Expected native int or pointer, but got VT
				//IL_4b8a: Expected F4, but got VT
				//IL_4b85: Expected native int or pointer, but got VT
				//IL_4b9f: Expected F4, but got I
				//IL_4b9a: Expected native int or pointer, but got VT
				//IL_4bac: Expected Ref, but got VT
				//IL_4bbe: Expected F4, but got VT
				//IL_4bb9: Expected native int or pointer, but got VT
				//IL_4bd3: Expected F4, but got I
				//IL_4bce: Expected native int or pointer, but got VT
				//IL_4bdc: Expected Obj, but got VT
				//IL_194e: Expected I, but got Obj
				//IL_17c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_17cb: Expected Obj, but got Unknown
				//IL_17ee: Expected I, but got Obj
				//IL_1804: Expected Obj, but got I
				//IL_1594: Unknown result type (might be due to invalid IL or missing references)
				//IL_1599: Expected Obj, but got Unknown
				//IL_15c0: Expected F4, but got VT
				//IL_15bb: Expected native int or pointer, but got VT
				//IL_15d5: Expected F4, but got I
				//IL_15d0: Expected native int or pointer, but got VT
				//IL_15e2: Expected Obj, but got VT
				//IL_15e2: Expected Obj, but got I4
				//IL_4eb3: Expected Obj, but got I4
				//IL_1a6d: Expected I, but got Obj
				//IL_42fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_4300: Expected Obj, but got Unknown
				//IL_3b52: Unknown result type (might be due to invalid IL or missing references)
				//IL_3b57: Expected Obj, but got Unknown
				//IL_3b7e: Expected F4, but got VT
				//IL_3b79: Expected native int or pointer, but got VT
				//IL_3b93: Expected F4, but got I
				//IL_3b8e: Expected native int or pointer, but got VT
				//IL_3ba6: Expected Obj, but got I4
				//IL_35ae: Expected Obj, but got I
				//IL_2759: Expected Obj, but got I4
				//IL_153d: Expected I, but got Obj
				//IL_4d6f: Expected F4, but got VT
				//IL_4d6a: Expected native int or pointer, but got VT
				//IL_4d84: Expected F4, but got I
				//IL_4d7f: Expected native int or pointer, but got VT
				//IL_4d8d: Expected Obj, but got VT
				//IL_4da9: Unknown result type (might be due to invalid IL or missing references)
				//IL_4dae: Expected Obj, but got Unknown
				//IL_4dd1: Expected I, but got Obj
				//IL_4de7: Expected Obj, but got I
				//IL_4c9a: Expected F4, but got VT
				//IL_4c95: Expected native int or pointer, but got VT
				//IL_4caf: Expected F4, but got I
				//IL_4caa: Expected native int or pointer, but got VT
				//IL_4cbc: Expected Ref, but got VT
				//IL_4cce: Expected F4, but got VT
				//IL_4cc9: Expected native int or pointer, but got VT
				//IL_4ce3: Expected F4, but got I
				//IL_4cde: Expected native int or pointer, but got VT
				//IL_4cec: Expected Obj, but got VT
				//IL_160e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1613: Expected Obj, but got Unknown
				//IL_1ad6: Expected Obj, but got I4
				//IL_43a6: Expected Ref, but got F4
				//IL_43c4: Expected F4, but got VT
				//IL_43bf: Expected native int or pointer, but got VT
				//IL_43d9: Expected F4, but got I
				//IL_43d4: Expected native int or pointer, but got VT
				//IL_43ec: Expected Obj, but got I4
				//IL_3599: Expected Obj, but got I4
				//IL_4e16: Expected F4, but got VT
				//IL_4e11: Expected native int or pointer, but got VT
				//IL_4e2b: Expected F4, but got I
				//IL_4e26: Expected native int or pointer, but got VT
				//IL_4e38: Expected Ref, but got VT
				//IL_4e4a: Expected F4, but got VT
				//IL_4e45: Expected native int or pointer, but got VT
				//IL_4e5f: Expected F4, but got I
				//IL_4e5a: Expected native int or pointer, but got VT
				//IL_4e68: Expected Obj, but got VT
				//IL_182f: Expected I, but got Obj
				//IL_166c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1671: Expected Obj, but got Unknown
				//IL_167e: Expected F4, but got Obj
				//IL_1679: Expected native int or pointer, but got VT
				//IL_1c1c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c21: Expected Obj, but got Unknown
				//IL_1c37: Expected Obj, but got I
				//IL_1c4f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c54: Expected Obj, but got Unknown
				//IL_1c6a: Expected Obj, but got I
				//IL_1c7b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c80: Expected Obj, but got Unknown
				//IL_1c89: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c8e: Expected Obj, but got Unknown
				//IL_1cae: Expected I, but got Obj
				//IL_1cc4: Expected Obj, but got I
				//IL_1bfb: Expected Obj, but got I
				//IL_441e: Unknown result type (might be due to invalid IL or missing references)
				//IL_4423: Expected Obj, but got Unknown
				//IL_444a: Expected F4, but got VT
				//IL_4445: Expected native int or pointer, but got VT
				//IL_445f: Expected F4, but got I
				//IL_445a: Expected native int or pointer, but got VT
				//IL_4340: Unknown result type (might be due to invalid IL or missing references)
				//IL_4345: Expected Obj, but got Unknown
				//IL_436c: Expected F4, but got VT
				//IL_4367: Expected native int or pointer, but got VT
				//IL_4381: Expected F4, but got I
				//IL_437c: Expected native int or pointer, but got VT
				//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0de4: Expected Obj, but got Unknown
				//IL_0e00: Expected Obj, but got I4
				//IL_35f7: Expected Obj, but got I
				//IL_3621: Expected Obj, but got I4
				//IL_19df: Expected I, but got Obj
				//IL_4c30: Expected F4, but got I
				//IL_4c2b: Expected native int or pointer, but got VT
				//IL_4c3d: Expected Obj, but got F4
				//IL_4c55: Expected I, but got Obj
				//IL_4c6b: Expected Obj, but got I
				//IL_1644: Unknown result type (might be due to invalid IL or missing references)
				//IL_1649: Expected Obj, but got Unknown
				//IL_1656: Expected F4, but got Obj
				//IL_1651: Expected native int or pointer, but got VT
				//IL_5bb0: Expected Obj, but got VT
				//IL_5bb0: Expected Obj, but got I4
				//IL_4557: Expected Ref, but got F4
				//IL_4571: Expected I, but got Obj
				//IL_4587: Expected Obj, but got I
				//IL_35b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_35be: Expected Obj, but got Unknown
				//IL_35c7: Expected Obj, but got I4
				//IL_35db: Expected Obj, but got I4
				//IL_5c68: Expected F4, but got Obj
				//IL_5c63: Expected native int or pointer, but got VT
				//IL_5c7d: Expected F4, but got I
				//IL_5c78: Expected native int or pointer, but got VT
				//IL_5c8a: Expected Ref, but got VT
				//IL_5c9c: Expected F4, but got VT
				//IL_5c97: Expected native int or pointer, but got VT
				//IL_5cb1: Expected F4, but got I
				//IL_5cac: Expected native int or pointer, but got VT
				//IL_5cba: Expected Obj, but got VT
				//IL_1cef: Expected I, but got Obj
				//IL_1c11: Expected Obj, but got I
				//IL_5bdc: Expected F4, but got VT
				//IL_5bd7: Expected native int or pointer, but got VT
				//IL_5bf1: Expected F4, but got I
				//IL_5bec: Expected native int or pointer, but got VT
				//IL_5bfe: Expected Ref, but got VT
				//IL_5c0b: Expected Obj, but got VT
				//IL_5c34: Expected F4, but got Obj
				//IL_5c2f: Expected native int or pointer, but got VT
				//IL_5c49: Expected F4, but got I
				//IL_5c44: Expected native int or pointer, but got VT
				//IL_5c52: Expected Obj, but got VT
				//IL_44da: Expected Ref, but got F4
				//IL_44f8: Expected F4, but got VT
				//IL_44f3: Expected native int or pointer, but got VT
				//IL_450d: Expected F4, but got I
				//IL_4508: Expected native int or pointer, but got VT
				//IL_4520: Expected Obj, but got I4
				//IL_3735: Expected Obj, but got I4
				//IL_1699: Expected I, but got Obj
				//IL_1d3e: Expected I4, but got Obj
				//IL_1d4b: Expected Obj, but got I4
				//IL_4618: Expected Ref, but got F4
				//IL_4636: Expected F4, but got VT
				//IL_4631: Expected native int or pointer, but got VT
				//IL_464b: Expected F4, but got I
				//IL_4646: Expected native int or pointer, but got VT
				//IL_465e: Expected Obj, but got I4
				//IL_45b2: Expected I, but got Obj
				//IL_203a: Unknown result type (might be due to invalid IL or missing references)
				//IL_203f: Expected Obj, but got Unknown
				//IL_205a: Expected Obj, but got VT
				//IL_37b2: Expected I, but got Obj
				//IL_37c8: Expected Obj, but got I
				//IL_293c: Expected I, but got Obj
				//IL_2952: Expected Obj, but got I
				//IL_207f: Expected Obj, but got I4
				//IL_59cf: Expected Obj, but got I
				//IL_59e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_59ec: Expected Obj, but got Unknown
				//IL_375c: Expected Obj, but got I4
				//IL_5414: Expected I, but got Obj
				//IL_542a: Expected Obj, but got I
				//IL_3844: Expected Obj, but got I
				//IL_37f3: Expected I, but got Obj
				//IL_5499: Expected Obj, but got I4
				//IL_54bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_54c2: Expected Obj, but got Unknown
				//IL_54e8: Expected Obj, but got I4
				//IL_54e8: Expected Obj, but got I4
				//IL_297d: Expected I, but got Obj
				//IL_2a71: Expected Obj, but got I4
				//IL_2a7a: Expected Obj, but got I4
				//IL_3783: Expected Obj, but got I4
				//IL_2a3c: Expected Obj, but got I4
				//IL_2a3c: Expected Obj, but got I4
				//IL_2a3c: Expected Obj, but got I4
				//IL_29ca: Expected I, but got Obj
				//IL_3876: Expected Obj, but got I
				//IL_3888: Expected I, but got Obj
				//IL_389e: Expected Obj, but got I
				//IL_2a93: Expected Obj, but got I4
				//IL_5a1f: Unknown result type (might be due to invalid IL or missing references)
				//IL_5a24: Expected Obj, but got Unknown
				//IL_5a2d: Expected Obj, but got I4
				//IL_38c9: Expected I, but got Obj
				//IL_379f: Expected Obj, but got I4
				//IL_2ad7: Expected Obj, but got I4
				//IL_2aef: Expected I, but got Obj
				//IL_2b05: Expected Obj, but got I
				//IL_2b30: Expected I, but got Obj
				//IL_2efb: Expected I, but got Obj
				//IL_2f11: Expected Obj, but got I
				//IL_56d1: Expected Obj, but got I4
				//IL_56d1: Expected Obj, but got I4
				//IL_2dd9: Expected I, but got Obj
				//IL_2def: Expected Obj, but got I
				//IL_2c17: Expected Obj, but got I4
				//IL_3017: Expected I, but got Obj
				//IL_302d: Expected Obj, but got I
				//IL_2f3c: Expected I, but got Obj
				//IL_5631: Expected I, but got Obj
				//IL_5647: Expected Obj, but got I
				//IL_2d4b: Expected I, but got Obj
				//IL_2d61: Expected Obj, but got I
				//IL_5758: Expected I, but got Obj
				//IL_576e: Expected Obj, but got I
				//IL_2f89: Expected I, but got Obj
				//IL_2f9f: Expected Obj, but got I
				//IL_2e1a: Expected I, but got Obj
				//IL_560b: Expected Obj, but got I4
				//IL_2c42: Expected I, but got Obj
				//IL_2c58: Expected Obj, but got I
				//IL_3058: Expected I, but got Obj
				//IL_56ff: Expected Obj, but got I
				//IL_2e67: Expected I, but got Obj
				//IL_2d8c: Expected I, but got Obj
				//IL_5583: Expected I, but got Obj
				//IL_5599: Expected Obj, but got I
				//IL_30a5: Expected I, but got Obj
				//IL_2fca: Expected I, but got Obj
				//IL_2c83: Expected I, but got Obj
				//IL_2cd0: Expected I, but got Obj
				//IL_3166: Expected I, but got Obj
				//IL_317c: Expected Obj, but got I
				//IL_5805: Unknown result type (might be due to invalid IL or missing references)
				//IL_580a: Expected Obj, but got Unknown
				//IL_31a7: Expected I, but got Obj
				//IL_3256: Expected I, but got Obj
				//IL_326c: Expected Obj, but got I
				//IL_58b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_58b7: Expected Obj, but got Unknown
				//IL_32f2: Expected Obj, but got I4
				//IL_3314: Expected I4, but got Obj
				//IL_3297: Expected I, but got Obj
				//IL_5830: Expected I, but got Obj
				//IL_5846: Expected Obj, but got I
				//IL_5d51: Expected I, but got Obj
				//IL_5d67: Expected Obj, but got I
				//IL_3335: Expected I4, but got Obj
				//IL_3348: Expected I, but got Obj
				//IL_33eb: Expected I4, but got Obj
				//IL_3395: Expected I, but got Obj
				object obj = default;
				Matrix4x4 matrix4x = (Matrix4x4)(obj + 208);
				ref Quaternion reference = ref *(Quaternion*)(obj + 152);
				ref Quaternion reference2 = ref *(Quaternion*)(obj + 104);
				ref Quaternion reference3 = ref *(Quaternion*)(obj + 88);
				object obj2 = obj + 204;
				ref Quaternion reference4 = ref *(Quaternion*)(obj + 72);
				object obj3 = obj + 56;
				object obj4 = obj + 200;
				object obj5 = obj + 196;
				object obj6 = obj + 192;
				object obj7 = obj + 40;
				object obj8 = obj + 188;
				object obj9 = obj + 32;
				object obj10 = obj + 16;
				object obj11 = obj + 184;
				object obj12 = obj + 180;
				object obj13 = obj + 176;
				object obj14 = obj + 172;
				object obj15 = obj + 168;
				object obj16 = obj + 136;
				obj16 = 0;
				_ = 0;
				object obj17 = obj + 224;
				obj17 = 0;
				object obj18 = obj + 8;
				obj18 = 0;
				obj = 0;
				object obj19 = obj + 120;
				obj19 = 0;
				_ = 0;
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				object obj23;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								if (_003C_003E1__state != 4)
								{
									if (_003C_003E1__state != 5)
									{
										if (_003C_003E1__state != 6)
										{
											if (_003C_003E1__state != 7)
											{
												if (_003C_003E1__state != 8)
												{
													if (_003C_003E1__state != 9)
													{
														if (_003C_003E1__state == 10)
														{
															_003C_003E1__state = -1;
															goto IL_3565;
														}
														return null;
													}
													_003C_003E1__state = -1;
													goto IL_346b;
												}
												_003C_003E1__state = -1;
											}
											else
											{
												_003C_003E1__state = -1;
											}
										}
										else
										{
											_003C_003E1__state = -1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+64]");
											((Collider)0).isTrigger = false;
											int unrewardedCoins = InventorySave.unrewardedCoins;
											_003C_003Ec__DisplayClass173_0 obj20 = _003C_003E8__1;
											Vector3 vector = ((CharacterNameEventPopup)(object)obj20.reward).VerifySettingOnline((string)1, (Vector3)0);
											_003C_003Ec__DisplayClass173_0 obj21 = _003C_003E8__1;
											CelebrationReward reward = obj21.reward;
											_003C_003Ec__DisplayClass173_0 obj22 = _003C_003E8__1;
											CelebrationReward reward2 = obj22.reward;
											if (reward2.rewardType == CelebrationRewardType.coins)
											{
												obj23 = this + 12;
												_003C_003Ec__DisplayClass173_0 obj24 = _003C_003E8__1;
												CelebrationReward reward3 = obj24.reward;
												bool flag;
												if (reward.CelebrationRewardOrigin != CelebrationRewardOrigin.SuperMysteryBox)
												{
													_003C_003Ec__DisplayClass173_0 obj25 = _003C_003E8__1;
													CelebrationReward reward4 = obj25.reward;
													if (reward4.CelebrationRewardOrigin != CelebrationRewardOrigin.WeeklyChallengeSuperMysteryBox)
													{
														_003C_003Ec__DisplayClass173_0 obj26 = _003C_003E8__1;
														CelebrationReward reward5 = obj26.reward;
														if (reward5.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterEventSuperMysteryBox)
														{
															flag = false;
															goto IL_488c;
														}
													}
												}
												_003C_003Ec__DisplayClass173_0 obj27 = _003C_003E8__1;
												CelebrationReward reward6 = obj27.reward;
												flag = reward6.amount > 300000;
												goto IL_488c;
											}
											if (reward.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterUnlock)
											{
												_003C_003Ec__DisplayClass173_0 obj28 = _003C_003E8__1;
												CelebrationReward reward7 = obj28.reward;
												if (reward7.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardUnlock)
												{
													_003C_003Ec__DisplayClass173_0 obj29 = _003C_003E8__1;
													CelebrationReward reward8 = obj29.reward;
													if (reward8.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardBundleUnlock)
													{
														_003C_003Ec__DisplayClass173_0 obj30 = _003C_003E8__1;
														CelebrationReward reward9 = obj30.reward;
														if (reward9.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
														{
															_003C_003Ec__DisplayClass173_0 obj31 = _003C_003E8__1;
															CelebrationReward reward10 = obj31.reward;
															if (reward10.CelebrationRewardOrigin != CelebrationRewardOrigin.TopRun)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																_ = 1f;
																object obj32 = this + 12;
																object obj33 = default;
																obj32 = obj33;
																_003C_003E1__state = 8;
																return 1;
															}
														}
													}
												}
											}
										}
										_003C_003Ec__DisplayClass173_0 obj34 = _003C_003E8__1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+348]");
										nint num = 0;
										CelebrationReward reward11 = obj34.reward;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+36C]");
										TutorialMultilineLabelsHelper tutorialMultilineLabelsHelper = TutorialMultilineLabelsHelper.AddToGameObject((GameObject)num, (GameObject)(object)reward11, (Vector3?)(object)0);
										if ((object)tutorialMultilineLabelsHelper != null)
										{
											object obj35 = celebrationPopup + 888;
											_003C_003Ec__DisplayClass173_0 obj36 = _003C_003E8__1;
											obj35 = obj36.reward;
											object obj37 = celebrationPopup + 892;
											obj37 = _003Ctemplate_003E5__4;
										}
										_003C_003Ec__DisplayClass173_0 obj38 = _003C_003E8__1;
										CelebrationReward reward12 = obj38.reward;
										if (reward12.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
										{
											_003C_003Ec__DisplayClass173_0 obj39 = _003C_003E8__1;
											CelebrationReward reward13 = obj39.reward;
											if (reward13.CelebrationRewardOrigin != CelebrationRewardOrigin.TopRun)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E4]");
												MeshRenderer component = ((GameObject)0).GetComponent<MeshRenderer>();
												Material sharedMaterial = component.sharedMaterial;
												Color yellow = Color.yellow;
												((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
												Matrix4x4 matrix4x2 = matrix4x;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
												((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
												IEnumerator routine = ((CelebrationPopup)null).MoveGameObject((Transform)(object)sharedMaterial, 0.5f, (Vector3)matrix4x);
												Coroutine coroutine = celebrationPopup.StartCoroutine_Auto(routine);
											}
										}
										_003C_003Ec__DisplayClass173_0 obj40 = _003C_003E8__1;
										CelebrationReward reward14 = obj40.reward;
										if (reward14.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterUnlock)
										{
											_003C_003Ec__DisplayClass173_0 obj41 = _003C_003E8__1;
											CelebrationReward reward15 = obj41.reward;
											if (reward15.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardUnlock)
											{
												_003C_003Ec__DisplayClass173_0 obj42 = _003C_003E8__1;
												CelebrationReward reward16 = obj42.reward;
												if (reward16.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardBundleUnlock)
												{
													_003C_003Ec__DisplayClass173_0 obj43 = _003C_003E8__1;
													CelebrationReward reward17 = obj43.reward;
													if (reward17.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
													{
														_003C_003Ec__DisplayClass173_0 obj44 = _003C_003E8__1;
														CelebrationReward reward18 = obj44.reward;
														if (reward18.CelebrationRewardOrigin != CelebrationRewardOrigin.TopRun)
														{
															object obj45 = this + 12;
															Wait.Config.TimeConfig timeConfig = Wait.For(0.75f);
															Coroutine coroutine2 = celebrationPopup.StartCoroutine_Auto((IEnumerator)timeConfig);
															obj45 = coroutine2;
															_003C_003E1__state = 9;
															return 1;
														}
													}
												}
											}
										}
										goto IL_346b;
									}
									_003C_003E1__state = -1;
									goto IL_20ff;
								}
								_003C_003E1__state = -1;
								_003C_003Ec__DisplayClass173_0 obj46 = _003C_003E8__1;
								CelebrationReward reward19 = obj46.reward;
								object obj47 = reward19.CelebrationRewardOrigin - 10;
								if (reward19.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
								{
									if ((nint)obj47 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E4]");
										MeshRenderer component2 = ((GameObject)0).GetComponent<MeshRenderer>();
										Material sharedMaterial2 = component2.sharedMaterial;
										Color black = Color.black;
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
										Matrix4x4 matrix4x3 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
										((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
										IEnumerator routine2 = ((CelebrationPopup)null).MoveGameObject((Transform)(object)sharedMaterial2, 1.5f, (Vector3)matrix4x);
										Coroutine coroutine3 = celebrationPopup.StartCoroutine_Auto(routine2);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E4]");
										int layer = ((GameObject)0).layer;
										reference2 = ref *(Quaternion*)null;
										_ = 0;
										reference2 = ref *(Quaternion*)0f;
										_ = 0f;
										_ = -270f;
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
										Matrix4x4 matrix4x4 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
										((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
										IEnumerator routine3 = ((CelebrationPopup)null).AnimateColor((UIWidget)layer, 3f, (Color)matrix4x);
										Coroutine coroutine4 = celebrationPopup.StartCoroutine_Auto(routine3);
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E4]");
									MeshRenderer component3 = ((GameObject)0).GetComponent<MeshRenderer>();
									Material sharedMaterial3 = component3.sharedMaterial;
									Color black2 = Color.black;
									((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
									Matrix4x4 matrix4x5 = matrix4x;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
									((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
									IEnumerator routine4 = ((CelebrationPopup)null).MoveGameObject((Transform)(object)sharedMaterial3, 1.5f, (Vector3)matrix4x);
									Coroutine coroutine5 = celebrationPopup.StartCoroutine_Auto(routine4);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E4]");
									int layer2 = ((GameObject)0).layer;
									reference2 = ref *(Quaternion*)null;
									_ = 0;
									reference2 = ref *(Quaternion*)0f;
									_ = 0f;
									_ = -270000f;
									((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
									Matrix4x4 matrix4x6 = matrix4x;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
									((Matrix4x4*)(nint)matrix4x6)->m20 = 0f;
									IEnumerator routine5 = ((CelebrationPopup)null).AnimateColor((UIWidget)layer2, 3000f, (Color)matrix4x);
									Coroutine coroutine6 = celebrationPopup.StartCoroutine_Auto(routine5);
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								_ = 1.3f;
								object obj48 = this + 12;
								object obj49 = default;
								obj48 = obj49;
								_003C_003E1__state = 5;
								return 1;
							}
							_003C_003E1__state = -1;
							goto IL_2084;
						}
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+140]");
						object obj50 = (nint)0 + (nint)16;
						int num2 = currentRewardIndex << 2;
						object obj51 = obj50 + num2;
						((GameObject)obj51).tag = null;
						nint num3 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v1005 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj52 = (nint)0 & (nint)0x200;
						if (obj52 != null)
						{
							nint num4 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S1_v1035 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+304]");
						if (((ComputeShader)0).FindKernel(null) != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+304]");
							((SuperMysteryBoxEffect)0).StopEffect();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+130]");
						object obj53 = (nint)0 + (nint)80;
						reference2 = ref *(Quaternion*)obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S1_v1013+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E8]");
						reference3 = ref *(Quaternion*)null;
						obj4 = reference3;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
						Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
						reference = ref *(Quaternion*)reference2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
						_ = 0;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference4;
						Matrix4x4 matrix4x8 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UnityEngine.Quaternion&)+8]");
						((Matrix4x4*)(nint)matrix4x8)->m20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC2");
						IEnumerator routine6 = default;
						Coroutine coroutine7 = celebrationPopup.StartCoroutine_Auto(routine6);
						goto IL_0e4f;
					}
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E8]");
					obj2 = *(Quaternion*)null;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
					Matrix4x4 matrix4x9 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference3;
					Matrix4x4 matrix4x10 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x10)->m20 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+130]");
					((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+130]");
					object obj54 = (nint)0 + (nint)80;
					reference4 = ref *(Quaternion*)obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S1_v981+8]");
					_ = 0;
					Color black3 = Color.black;
					reference = ref *(Quaternion*)reference4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UnityEngine.Quaternion&)+8]");
					_ = 0;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
					Matrix4x4 matrix4x11 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
					((Matrix4x4*)(nint)matrix4x11)->m20 = 0f;
					object obj55 = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC2");
					IEnumerator routine7 = default;
					Coroutine coroutine8 = celebrationPopup.StartCoroutine_Auto(routine7);
					obj55 = coroutine8;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj56 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj57 = default;
				obj56 = obj57;
				object obj58 = _003C_003E8__1 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2FC]");
				object obj59 = (nint)0 + (nint)16;
				int num5 = currentRewardIndex << 2;
				object obj60 = obj59 + num5;
				obj58 = obj60;
				_003C_003Ec__DisplayClass173_0 obj61 = _003C_003E8__1;
				CelebrationReward reward20 = obj61.reward;
				object obj62 = reward20.CelebrationRewardOrigin - 1;
				if (reward20.CelebrationRewardOrigin == CelebrationRewardOrigin.MysteryBox)
				{
					goto IL_0278;
				}
				if ((nint)obj62 != 1)
				{
					if ((nint)obj62 != 2)
					{
						if ((nint)obj62 == 3)
						{
							goto IL_0278;
						}
						if ((nint)obj62 == 4 || reward20.CelebrationRewardOrigin == CelebrationRewardOrigin.CharacterEventSuperMysteryBox)
						{
							goto IL_02b8;
						}
					}
					goto IL_02c7;
				}
				goto IL_02b8;
				IL_0e4f:
				object obj63 = this + 28;
				obj63 = 0;
				_003C_003Ec__DisplayClass173_0 obj64 = _003C_003E8__1;
				CelebrationReward reward21 = obj64.reward;
				object obj65 = reward21.CelebrationRewardOrigin - 7;
				if (reward21.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterUnlock)
				{
					if ((nint)obj65 != 1)
					{
						if ((nint)obj65 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+344]");
							IEnumerator enumerator = ((BragCelebrationHandler)0).UpdateUI();
							if ((nint)enumerator == 1)
							{
								Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
								((ChallengesScreen)null).ActivatePage((int)previousBoardId, true);
							}
							else
							{
								bool isInstanced = UIScreenController.IsInstanced;
								((UIModelController)isInstanced).ActivateCelebrationTunnel();
							}
							nint num6 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ S1_v668 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj66 = (nint)0 & (nint)0x200;
							if (obj66 != null)
							{
								nint num7 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ S1_v674 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
							if (((ComputeShader)0).FindKernel(null) != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
								((AudioStateLoop)0).PlayReviveSound();
							}
							goto IL_20ff;
						}
						if (reward21.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardBundleUnlock)
						{
							_003C_003Ec__DisplayClass173_0 obj67 = _003C_003E8__1;
							bool ignoreChildrenWithColliders = celebrationPopup.IsJackpot(obj67.reward);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+7C]");
							object go = (nint)0 + (nint)16;
							nint num8 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ S0_v796 (Il2CppClass<NGUITools>)+BA]");
							object obj68 = (nint)0 & (nint)0x200;
							if (obj68 != null)
							{
								nint num9 = (nint)typeof(NGUITools);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1562 @ S0_v892 (Il2CppClass<NGUITools>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj69 = this + 28;
							int num10 = NGUITools.CalculateNextDepth((GameObject)go, ignoreChildrenWithColliders);
							obj69 = num10;
							_003C_003Ec__DisplayClass173_0 obj70 = _003C_003E8__1;
							IEnumerator enumerator2 = celebrationPopup.TweenScaleUpDown((GameObject)(object)obj70.reward);
							if (enumerator2 != null)
							{
								int layer3 = _003CrewardGo_003E5__2.layer;
								object obj71 = celebrationPopup + 532;
								reference = ref *(Quaternion*)obj71;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1955 @ S2_v489+8]");
								_ = 0;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
								Matrix4x4 matrix4x12 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x12)->m20 = 0f;
								((Transform)layer3).parent = (Transform)matrix4x;
								int layer4 = _003CrewardGo_003E5__2.layer;
								object obj72 = celebrationPopup + 472;
								reference2 = ref *(Quaternion*)obj72;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2167 @ S2_v499+8]");
								_ = 0;
								nint num11 = (nint)typeof(Quaternion);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2174 @ S1_v898 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
								object obj73 = (nint)0 & (nint)0x200;
								if (obj73 != null)
								{
									nint num12 = (nint)typeof(Quaternion);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2243 @ S1_v908 (Il2CppClass<UnityEngine.Quaternion>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
								Matrix4x4 matrix4x13 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x13)->m20 = 0f;
								Quaternion.Inverse_Injected(ref reference3, out *(Quaternion*)matrix4x);
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference3;
								Matrix4x4 matrix4x14 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x14)->m20 = 0f;
								Vector3 localScale = ((Transform)matrix4x).localScale;
							}
							else
							{
								_003C_003Ec__DisplayClass173_0 obj74 = _003C_003E8__1;
								CelebrationReward reward22 = obj74.reward;
								object obj75 = reward22.CelebrationRewardOrigin - 8;
								if (reward22.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardUnlock)
								{
									if ((nint)obj75 == 1)
									{
										goto IL_186e;
									}
									if ((nint)obj75 != 2)
									{
										if ((nint)obj75 != 3)
										{
											goto IL_186e;
										}
										int layer5 = _003CrewardGo_003E5__2.layer;
										object obj76 = celebrationPopup + 448;
										reference = ref *(Quaternion*)obj76;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2395 @ S2_v453+8]");
										_ = 0;
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
										Matrix4x4 matrix4x15 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
										((Matrix4x4*)(nint)matrix4x15)->m20 = 0f;
										((Transform)layer5).parent = (Transform)matrix4x;
										int layer6 = _003CrewardGo_003E5__2.layer;
										_003C_003Ec__DisplayClass173_0 obj77 = _003C_003E8__1;
										object obj78 = obj77.reward - -64;
										if ((nint)obj78 > 4)
										{
											object obj79 = celebrationPopup + 496;
											((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj79;
											object obj80 = obj79;
										}
										else
										{
											object obj81 = celebrationPopup + 508;
											((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj81;
											object obj80 = obj81;
										}
										Matrix4x4 matrix4x16 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2844 @ L6_v33+8]");
										((Matrix4x4*)(nint)matrix4x16)->m20 = 0f;
										obj19 = matrix4x.m00;
										_ = matrix4x.m20;
										nint num13 = (nint)typeof(Quaternion);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2858 @ S1_v872 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
										object obj82 = (nint)0 & (nint)0x200;
										if (obj82 != null)
										{
											nint num14 = (nint)typeof(Quaternion);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2959 @ S1_v882 (Il2CppClass<UnityEngine.Quaternion>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
										Matrix4x4 matrix4x17 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v55+8]");
										((Matrix4x4*)(nint)matrix4x17)->m20 = 0f;
										Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)matrix4x);
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
										Matrix4x4 matrix4x18 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
										((Matrix4x4*)(nint)matrix4x18)->m20 = 0f;
										Vector3 localScale2 = ((Transform)matrix4x).localScale;
									}
									else
									{
										int layer7 = _003CrewardGo_003E5__2.layer;
										object obj83 = celebrationPopup + 460;
										reference = ref *(Quaternion*)obj83;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2266 @ S2_v417+8]");
										_ = 0;
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
										Matrix4x4 matrix4x19 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
										((Matrix4x4*)(nint)matrix4x19)->m20 = 0f;
										((Transform)layer7).parent = (Transform)matrix4x;
										int layer8 = _003CrewardGo_003E5__2.layer;
										object obj84 = celebrationPopup + 520;
										reference2 = ref *(Quaternion*)obj84;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2453 @ S2_v427+8]");
										_ = 0;
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
										Matrix4x4 matrix4x20 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
										((Matrix4x4*)(nint)matrix4x20)->m20 = 0f;
										Vector3 eulerAngles = ((Transform)matrix4x).eulerAngles;
										int layer9 = _003CrewardGo_003E5__2.layer;
										object obj85 = celebrationPopup + 484;
										reference3 = ref *(Quaternion*)obj85;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2760 @ S2_v437+8]");
										_ = 0;
										nint num15 = (nint)typeof(Quaternion);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2767 @ S1_v840 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
										object obj86 = (nint)0 & (nint)0x200;
										if (obj86 != null)
										{
											nint num16 = (nint)typeof(Quaternion);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2863 @ S1_v850 (Il2CppClass<UnityEngine.Quaternion>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference3;
										Matrix4x4 matrix4x21 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
										((Matrix4x4*)(nint)matrix4x21)->m20 = 0f;
										Quaternion.Inverse_Injected(ref reference4, out *(Quaternion*)matrix4x);
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference4;
										Matrix4x4 matrix4x22 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UnityEngine.Quaternion&)+8]");
										((Matrix4x4*)(nint)matrix4x22)->m20 = 0f;
										Vector3 localScale3 = ((Transform)matrix4x).localScale;
									}
								}
								else
								{
									int layer10 = _003CrewardGo_003E5__2.layer;
									object obj87 = celebrationPopup + 448;
									reference = ref *(Quaternion*)obj87;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2043 @ S2_v325+8]");
									_ = 0;
									((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
									Matrix4x4 matrix4x23 = matrix4x;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
									((Matrix4x4*)(nint)matrix4x23)->m20 = 0f;
									((Transform)layer10).parent = (Transform)matrix4x;
									int layer11 = _003CrewardGo_003E5__2.layer;
									int sleepTimeout = Screen.sleepTimeout;
									int height = Screen.height;
									nint num17 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2473 @ S1_v741 (Il2CppClass<UnityEngine.Mathf>)+BA]");
									object obj88 = (nint)0 & (nint)0x200;
									if (obj88 != null)
									{
										nint num18 = (nint)typeof(Mathf);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2626 @ S1_v774 (Il2CppClass<UnityEngine.Mathf>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									reference2 = ref *(Quaternion*)null;
									_ = 0;
									reference2 = ref *(Quaternion*)0f;
									int num19 = sleepTimeout / height;
									float num20 = (float)num19 * 3.5f;
									if (num20 < 0f)
									{
										num20 = 0f;
									}
									else if (num20 > 9f)
									{
										num20 = 9f;
									}
									_ = 0f;
									((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
									Matrix4x4 matrix4x24 = matrix4x;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
									((Matrix4x4*)(nint)matrix4x24)->m20 = 0f;
									Vector3 eulerAngles2 = ((Transform)matrix4x).eulerAngles;
									int layer12 = _003CrewardGo_003E5__2.layer;
									reference3 = ref *(Quaternion*)null;
									_ = 0;
									reference3 = ref *(Quaternion*)(-30f);
									_ = -10f;
									_ = 30f;
									nint num21 = (nint)typeof(Quaternion);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3044 @ S1_v760 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
									object obj89 = (nint)0 & (nint)0x200;
									if (obj89 != null)
									{
										nint num22 = (nint)typeof(Quaternion);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3091 @ S1_v770 (Il2CppClass<UnityEngine.Quaternion>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference3;
									Matrix4x4 matrix4x25 = matrix4x;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
									((Matrix4x4*)(nint)matrix4x25)->m20 = 0f;
									Quaternion.Inverse_Injected(ref reference4, out *(Quaternion*)matrix4x);
									((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference4;
									Matrix4x4 matrix4x26 = matrix4x;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UnityEngine.Quaternion&)+8]");
									((Matrix4x4*)(nint)matrix4x26)->m20 = 0f;
									Vector3 localScale4 = ((Transform)matrix4x).localScale;
								}
							}
							goto IL_4be5;
						}
					}
					_003C_003Ec__DisplayClass173_0 obj90 = _003C_003E8__1;
					CelebrationReward reward23 = obj90.reward;
					((ChallengesScreen)null).ActivatePage((int)reward23.boardId, true);
					nint num23 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ S1_v654 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj91 = (nint)0 & (nint)0x200;
					if (obj91 != null)
					{
						nint num24 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ S1_v660 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
						((AudioStateLoop)0).PlayReviveSound();
					}
				}
				else
				{
					_003C_003Ec__DisplayClass173_0 obj92 = _003C_003E8__1;
					CelebrationReward reward24 = obj92.reward;
					_003C_003Ec__DisplayClass173_0 obj93 = _003C_003E8__1;
					CelebrationReward reward25 = obj93.reward;
					IAsyncResult asyncResult = ((OnActivatedPrefab)null).BeginInvoke((GameObject)reward24.characterId, (byte)reward25.characterOutfitIndex != 0, (AsyncCallback)5, (object)1);
					nint num25 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ S1_v638 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj94 = (nint)0 & (nint)0x200;
					if (obj94 != null)
					{
						nint num26 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ S1_v644 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
						((AudioStateLoop)0).PlayReviveSound();
					}
				}
				goto IL_20ff;
				IL_346b:
				nint num27 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ S1_v1143 (Il2CppClass<Strings>)+BA]");
				object obj95 = (nint)0 & (nint)0x200;
				if (obj95 != null)
				{
					nint num28 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ S1_v1158 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("CELEBRATION_POPUP_CONTINUE");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+134]");
				((UILabel)0).fontSize = (int)text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+134]");
				nint num29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2EC]");
				IEnumerator routine8 = ((CelebrationPopup)null).AnimateAlpha((CelebrationPopupLabelTemplate)num29, 0.5f, 0f);
				Coroutine coroutine9 = celebrationPopup.StartCoroutine_Auto(routine8);
				_ = 0;
				_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
				_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ S1_v1155 (T)+10]");
				((TimeScaleManager)val).TimeScaleInMenuDefault = 0f;
				_ = 1;
				goto IL_3565;
				IL_488c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EBD");
				IEnumerator routine9 = default;
				Coroutine coroutine10 = celebrationPopup.StartCoroutine_Auto(routine9);
				obj23 = coroutine10;
				_003C_003E1__state = 7;
				return 1;
				IL_2ace:
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				nint num30 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3482 @ S0_v462 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj96 = (nint)0 & (nint)0x200;
				if (obj96 != null)
				{
					nint num31 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3502 @ S0_v510 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string flurryUserId = Flurry.flurryUserId;
				if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj97 = default;
					if ((nint)obj97 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
						_ = 1;
						object obj98 = default;
						obj18 = obj98;
					}
				}
				string tag;
				if (obj17 != null)
				{
					obj = obj18;
					_003C_003Ec__DisplayClass173_0 obj99 = _003C_003E8__1;
					CelebrationReward reward26 = obj99.reward;
					bool flag2 = (nint)obj == (nint)reward26.boardId;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					bool flag3 = (nint)0 != 0;
					object obj100 = flag2 & flag3;
					if (obj100 != null)
					{
						nint num32 = (nint)typeof(Boards);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3720 @ S1_v434 (Il2CppClass<Info.Boards>)+BA]");
						object obj101 = (nint)0 & (nint)0x200;
						if (obj101 != null)
						{
							nint num33 = (nint)typeof(Boards);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3814 @ S1_v444 (Il2CppClass<Info.Boards>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						_003C_003Ec__DisplayClass173_0 obj102 = _003C_003E8__1;
						CelebrationReward reward27 = obj102.reward;
						Boards.Board board = Boards.boardData.get_Item(reward27.boardId);
						nint num34 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3873 @ S2_v163 (Il2CppClass<Strings>)+BA]");
						object obj103 = (nint)0 & (nint)0x200;
						if (obj103 != null)
						{
							nint num35 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3913 @ S2_v169 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string reward28 = Strings.GetDefault(board.name);
						_003Ctemplate_003E5__4.SetupDoubleUp((CelebrationReward)(object)reward28);
						tag = null;
						goto IL_5358;
					}
				}
				_003C_003Ec__DisplayClass173_0 obj104 = _003C_003E8__1;
				CelebrationReward reward29 = obj104.reward;
				if (reward29.boardPower != Hoverboard.BoardAbility.None)
				{
					_003C_003Ec__DisplayClass173_0 obj105 = _003C_003E8__1;
					CelebrationReward reward30 = obj105.reward;
					_003C_003Ec__DisplayClass173_0 obj106 = _003C_003E8__1;
					CelebrationReward reward31 = obj106.reward;
					nint num36 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3735 @ S2_v146 (Il2CppClass<HoverboardThemes>)+BA]");
					object obj107 = (nint)0 & (nint)0x200;
					if (obj107 != null)
					{
						nint num37 = (nint)typeof(HoverboardThemes);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3833 @ S2_v152 (Il2CppClass<HoverboardThemes>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int indexForTheme = HoverboardThemes.GetIndexForTheme(reward30.boardId, (HoverboardThemes.ThemeIdentifier)reward31.boardPower);
					_003Ctemplate_003E5__4.SetupEventSpecialBoard((string)indexForTheme);
					tag = null;
				}
				else
				{
					nint num38 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3743 @ S1_v407 (Il2CppClass<Strings>)+BA]");
					object obj108 = (nint)0 & (nint)0x200;
					if (obj108 != null)
					{
						nint num39 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3841 @ S1_v415 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string format = Strings.GetDefault("BOARD_DISPLAY_NAME_WITH_SUFFIX");
					nint num40 = (nint)typeof(Boards);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3880 @ S2_v128 (Il2CppClass<Info.Boards>)+BA]");
					object obj109 = (nint)0 & (nint)0x200;
					if (obj109 != null)
					{
						nint num41 = (nint)typeof(Boards);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3920 @ S2_v139 (Il2CppClass<Info.Boards>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					_003C_003Ec__DisplayClass173_0 obj110 = _003C_003E8__1;
					CelebrationReward reward32 = obj110.reward;
					Boards.Board board2 = Boards.boardData.get_Item(reward32.boardId);
					string args = Strings.GetDefault(board2.name);
					string boardName = string.Format(format, (object[])(object)args);
					_003Ctemplate_003E5__4.SetupEventSpecialBoard(boardName);
					tag = null;
				}
				goto IL_5358;
				IL_0278:
				((NewMonoBehaviour)29)._002Ector();
				goto IL_02c7;
				IL_20ff:
				nint num42 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v337 (Il2CppClass<UIScreenController>)+BA]");
				object obj111 = (nint)0 & (nint)0x200;
				if (obj111 != null)
				{
					nint num43 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S0_v734 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag4 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v342 (System.Boolean)+28]");
				string tag2 = ((Component)0).tag;
				nint num44 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ S0_v348 (Il2CppClass<NGUITools>)+BA]");
				object obj112 = (nint)0 & (nint)0x200;
				if (obj112 != null)
				{
					nint num45 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ S0_v730 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj113 = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2C]");
				int num46 = NGUITools.CalculateNextDepth((GameObject)(object)tag2, ignoreChildrenWithColliders: false);
				obj113 = num46;
				_003C_003Ec__DisplayClass173_0 obj114 = _003C_003E8__1;
				CelebrationReward reward33 = obj114.reward;
				object obj117;
				if (reward33.CelebrationRewardOrigin == CelebrationRewardOrigin.BoardBundleUnlock)
				{
					_003C_003Ec__DisplayClass173_0 obj115 = _003C_003E8__1;
					CelebrationReward reward34 = obj115.reward;
					List<HoverboardThemes.ThemeIdentifier> bundledThemes = reward34.bundledThemes;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ S0_v723 (System.Collections.Generic.List`1<HoverboardThemes+ThemeIdentifier>)+C]");
					if ((nint)0 >= (nint)1)
					{
						int layer13 = _003ClabelGo_003E5__3.layer;
						object obj116 = celebrationPopup + 712;
						reference = ref *(Quaternion*)obj116;
						obj117 = obj116;
						goto IL_5042;
					}
				}
				_003C_003Ec__DisplayClass173_0 obj118 = _003C_003E8__1;
				CelebrationReward reward35 = obj118.reward;
				if (reward35.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardUnlock)
				{
					_003C_003Ec__DisplayClass173_0 obj119 = _003C_003E8__1;
					CelebrationReward reward36 = obj119.reward;
					if (reward36.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterUnlock)
					{
						_003C_003Ec__DisplayClass173_0 obj120 = _003C_003E8__1;
						CelebrationReward reward37 = obj120.reward;
						if (reward37.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardBundleUnlock)
						{
							int layer14 = _003ClabelGo_003E5__3.layer;
							object obj121 = celebrationPopup + 688;
							reference = ref *(Quaternion*)obj121;
							obj117 = obj121;
							goto IL_5042;
						}
					}
				}
				int layer15 = _003ClabelGo_003E5__3.layer;
				object obj122 = celebrationPopup + 700;
				reference = ref *(Quaternion*)obj122;
				obj117 = obj122;
				goto IL_5042;
				IL_373a:
				((CelebrationPopup)null).HideSpecialBoard();
				bool isInstanced2 = UIScreenController.IsInstanced;
				((UIModelController)isInstanced2).ClearScreenAnchor(UIModelController.ModelScreen.CelebrationBoardUnlock);
				goto IL_37a4;
				IL_02b8:
				((NewMonoBehaviour)35)._002Ector();
				goto IL_02c7;
				IL_02c7:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E4]");
				MeshRenderer component4 = ((GameObject)0).GetComponent<MeshRenderer>();
				component4.shadowCastingMode = ShadowCastingMode.On;
				_003C_003Ec__DisplayClass173_0 obj123 = _003C_003E8__1;
				CelebrationReward reward38 = obj123.reward;
				if (reward38.CelebrationRewardOrigin == CelebrationRewardOrigin.TopRun)
				{
					nint num47 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S1_v930 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj124 = (nint)0 & (nint)0x200;
					if (obj124 != null)
					{
						nint num48 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ S1_v963 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
						((AudioStateLoop)0).PlayCelebrationTapSound();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E4]");
					MeshRenderer component5 = ((GameObject)0).GetComponent<MeshRenderer>();
					Material sharedMaterial4 = component5.sharedMaterial;
					Color black4 = Color.black;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
					Matrix4x4 matrix4x27 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x27)->m20 = 0f;
					IEnumerator routine10 = ((CelebrationPopup)null).MoveGameObject((Transform)(object)sharedMaterial4, 1.5f, (Vector3)matrix4x);
					Coroutine coroutine11 = celebrationPopup.StartCoroutine_Auto(routine10);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+2E4]");
					int layer16 = ((GameObject)0).layer;
					reference2 = ref *(Quaternion*)null;
					_ = 0;
					reference2 = ref *(Quaternion*)0f;
					_ = 0f;
					_ = -270000f;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
					Matrix4x4 matrix4x28 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x28)->m20 = 0f;
					IEnumerator routine11 = ((CelebrationPopup)null).AnimateColor((UIWidget)layer16, 3000f, (Color)matrix4x);
					Coroutine coroutine12 = celebrationPopup.StartCoroutine_Auto(routine11);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 0.4f;
					object obj125 = this + 12;
					object obj126 = default;
					obj125 = obj126;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_0e4f;
				IL_186e:
				int layer17 = _003CrewardGo_003E5__2.layer;
				object obj127 = celebrationPopup + 448;
				reference = ref *(Quaternion*)obj127;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2187 @ S2_v371+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
				Matrix4x4 matrix4x29 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
				((Matrix4x4*)(nint)matrix4x29)->m20 = 0f;
				((Transform)layer17).parent = (Transform)matrix4x;
				int layer18 = _003CrewardGo_003E5__2.layer;
				int sleepTimeout2 = Screen.sleepTimeout;
				int height2 = Screen.height;
				nint num49 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2620 @ S1_v790 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj128 = (nint)0 & (nint)0x200;
				if (obj128 != null)
				{
					nint num50 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2772 @ S1_v820 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				reference2 = ref *(Quaternion*)null;
				_ = 0;
				reference2 = ref *(Quaternion*)0f;
				int num51 = sleepTimeout2 / height2;
				float num52 = (float)num51 * 3.5f;
				if (num52 < 0f)
				{
					num52 = 0f;
				}
				else if (num52 > 9f)
				{
					num52 = 9f;
				}
				_ = 0f;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
				Matrix4x4 matrix4x30 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
				((Matrix4x4*)(nint)matrix4x30)->m20 = 0f;
				Vector3 eulerAngles3 = ((Transform)matrix4x).eulerAngles;
				int layer19 = _003CrewardGo_003E5__2.layer;
				object obj129 = celebrationPopup + 436;
				reference3 = ref *(Quaternion*)obj129;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3079 @ S2_v396+8]");
				_ = 0;
				nint num53 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3086 @ S1_v806 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
				object obj130 = (nint)0 & (nint)0x200;
				if (obj130 != null)
				{
					nint num54 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3139 @ S1_v816 (Il2CppClass<UnityEngine.Quaternion>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference3;
				Matrix4x4 matrix4x31 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
				((Matrix4x4*)(nint)matrix4x31)->m20 = 0f;
				Quaternion.Inverse_Injected(ref reference4, out *(Quaternion*)matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference4;
				Matrix4x4 matrix4x32 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UnityEngine.Quaternion&)+8]");
				((Matrix4x4*)(nint)matrix4x32)->m20 = 0f;
				Vector3 localScale5 = ((Transform)matrix4x).localScale;
				goto IL_4be5;
				IL_354c:
				object obj131 = this + 40;
				obj131 = 0;
				goto IL_3908;
				IL_4be5:
				int layer20 = _003CrewardGo_003E5__2.layer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+28]");
				bool activeSelf = ((GameObject)0).activeSelf;
				((AssignTextureAndMaterial)layer20)._003CAwake_003Eb__3_0((Material)activeSelf);
				nint num55 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2954 @ S0_v811 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj132 = (nint)0 & (nint)0x200;
				if (obj132 != null)
				{
					nint num56 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3013 @ S0_v844 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					_003C_003Ec__DisplayClass173_0 obj133 = _003C_003E8__1;
					CelebrationReward reward39 = obj133.reward;
					object obj134 = reward39.CelebrationRewardOrigin - 3;
					if (reward39.CelebrationRewardOrigin != CelebrationRewardOrigin.WeeklyChallengeNormal)
					{
						if ((nint)obj134 == 1 || (nint)obj134 == 2 || (nint)obj134 == 3 || (nint)obj134 == 4 || (nint)obj134 == 5 || (nint)obj134 == 6 || (nint)obj134 == 7 || (nint)obj134 != 8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
							((AudioStateLoop)0).PlayRewardMysterySound();
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+138]");
						((AudioStateLoop)0).PlayReviveSound();
					}
				}
				IEnumerator enumerator3 = celebrationPopup.AnimateScreenFlash((UISprite)currentRewardIndex);
				if (enumerator3 != null)
				{
					object obj135 = this + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+140]");
					object obj136 = (nint)0 + (nint)16;
					int num57 = currentRewardIndex << 2;
					object obj137 = obj136 + num57;
					nint num58 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3308 @ S3_v88 (Il2CppMethodInfo)+18]");
					object obj138 = 0;
					object obj139 = obj138;
					object obj140 = obj139 & 0x1FFF;
					object obj141 = obj140 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v270 @ S4_v53 (should have been resolved before IL gen)");
					object obj142 = default;
					obj135 = obj142;
					nint num59 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3319 @ S1_v711 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj143 = (nint)0 & (nint)0x200;
					if (obj143 != null)
					{
						nint num60 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3328 @ S1_v721 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)_003Canim_003E5__5).FindKernel((string)null) != 0)
					{
						bool flag5 = _003Canim_003E5__5.Play((PlayMode)"up");
						if (((UnityEngine.Object)flag5).GetInstanceID() != 0)
						{
							AnimationState animationState = _003Canim_003E5__5.CrossFadeQueued("up");
							goto IL_2084;
						}
					}
					goto IL_354c;
				}
				goto IL_3908;
				IL_5358:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+78]");
				string tag3 = ((Component)0).tag;
				((GameObject)(object)tag3).tag = tag;
				_003C_003Ec__DisplayClass173_0 obj144 = _003C_003E8__1;
				CelebrationReward reward40 = obj144.reward;
				if (reward40.rewardType != CelebrationRewardType.highscore)
				{
					IEnumerator routine12 = ((CelebrationPopup)null).PlaySoundDelayed((AudioClip)(object)_003Ctemplate_003E5__4, 0.2f, 1f);
					Coroutine coroutine13 = celebrationPopup.StartCoroutine_Auto(routine12);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.5f;
				object obj145 = this + 12;
				object obj146 = default;
				obj145 = obj146;
				_003C_003E1__state = 6;
				return 1;
				IL_3565:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+375]");
				object obj147;
				if ((nint)0 != 0)
				{
					_ = 0;
					obj147 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+374]");
					obj147 = 0;
				}
				if (obj147 != null)
				{
					object obj148 = this + 12;
					obj148 = 0;
					_003C_003E1__state = 10;
					return 1;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+348]");
				((MysteryBoxDoubleUpButton)0).OnClick();
				_003C_003Ec__DisplayClass173_0 obj149 = _003C_003E8__1;
				CelebrationReward reward41 = obj149.reward;
				object obj150 = reward41.CelebrationRewardOrigin - 7;
				if (reward41.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterUnlock)
				{
					if ((nint)obj150 == 1)
					{
						goto IL_373a;
					}
					if ((nint)obj150 != 2)
					{
						if ((nint)obj150 != 3)
						{
							if ((nint)obj150 != 4)
							{
								if ((nint)obj150 != 5 && (nint)obj150 != 6 && (nint)obj150 == 7)
								{
									goto IL_373a;
								}
							}
							else
							{
								bool isInstanced3 = UIScreenController.IsInstanced;
								((UIModelController)isInstanced3).ClearScreenAnchor(UIModelController.ModelScreen.CelebrationTopRun);
							}
						}
					}
					else
					{
						((CelebrationPopup)null).HideSpecialBoard();
						bool isInstanced4 = UIScreenController.IsInstanced;
						((UIModelController)isInstanced4).ClearScreenAnchor(UIModelController.ModelScreen.CelebrationHighScore);
					}
				}
				else
				{
					((CelebrationPopup)null).HideSpecialBoard();
					bool isInstanced5 = UIScreenController.IsInstanced;
					((UIModelController)isInstanced5).ClearScreenAnchor(UIModelController.ModelScreen.CelebrationCharacterUnlock);
				}
				goto IL_37a4;
				IL_2084:
				bool flag6 = _003Canim_003E5__5.Play((PlayMode)"up");
				float speed = ((AnimationState)flag6).speed;
				if (speed < 0.5f)
				{
					object obj151 = this + 12;
					obj151 = 0;
					_003C_003E1__state = 3;
					return 1;
				}
				goto IL_354c;
				IL_37a4:
				nint num61 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1992 @ S1_v1099 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj152 = (nint)0 & (nint)0x200;
				if (obj152 != null)
				{
					nint num62 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2058 @ S1_v1126 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate(_003CrewardGo_003E5__2);
				UnityEngine.Object.DestroyImmediate(_003ClabelGo_003E5__3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+140]");
				object obj153 = (nint)0 + (nint)16;
				int num63 = currentRewardIndex << 2;
				object obj154 = obj153 + num63;
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)obj154);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+344]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+344]");
					string tag4 = ((Component)0).tag;
					nint num64 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2800 @ S1_v1115 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj155 = (nint)0 & (nint)0x200;
					if (obj155 != null)
					{
						nint num65 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2898 @ S1_v1122 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag4);
					object obj156 = celebrationPopup + 836;
					obj156 = 0;
				}
				celebrationPopup.ResetBackgroundToNormal();
				return null;
				IL_3908:
				_ = 1;
				_003C_003Ec__DisplayClass173_0 obj157 = _003C_003E8__1;
				GameObject reward42 = (GameObject)(object)obj157.reward;
				_003C_003Ec__DisplayClass173_0 obj158 = _003C_003E8__1;
				CelebrationReward reward43 = obj158.reward;
				if (reward43.rewardType == CelebrationRewardType.coins)
				{
					IEnumerator enumerator4 = celebrationPopup.TweenScaleUpDown(reward42);
					if (enumerator4 != null)
					{
						int layer21 = _003CrewardGo_003E5__2.layer;
						object obj159 = celebrationPopup + 568;
						reference = ref *(Quaternion*)obj159;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ S1_v281+8]");
						_ = 0;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
						Matrix4x4 matrix4x33 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
						((Matrix4x4*)(nint)matrix4x33)->m20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC4");
						IEnumerator routine13 = default;
						Coroutine coroutine14 = celebrationPopup.StartCoroutine_Auto(routine13);
						nint num66 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1492 @ S2_v70 (Il2CppMethodInfo)+18]");
						object obj160 = 0;
						object obj161 = obj160;
						object obj162 = obj161 & 0x1FFF;
						object obj163 = obj162 + 22691;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1501 @ S3_v27 (should have been resolved before IL gen)");
						nint num67 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ S0_v306 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj164 = (nint)0 & (nint)0x200;
						if (obj164 != null)
						{
							nint num68 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1644 @ S0_v328 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						ComputeShader computeShader = default;
						if (computeShader.FindKernel(null) != 0)
						{
							bool flag7 = ((Animation)(object)computeShader).Play((PlayMode)"open_superJackpot");
							if (((UnityEngine.Object)flag7).GetInstanceID() != 0)
							{
								AnimationState animationState2 = ((Animation)(object)computeShader).CrossFadeQueued("open_superJackpot");
								int layer22 = _003CrewardGo_003E5__2.layer;
								object obj165 = celebrationPopup + 580;
								reference = ref *(Quaternion*)obj165;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2338 @ S1_v301+8]");
								_ = 0;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
								Matrix4x4 matrix4x34 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x34)->m20 = 0f;
								IEnumerator routine14 = ((CelebrationPopup)null).ScaleGameObject((Transform)layer22, 1f, (Vector3)matrix4x);
								Coroutine coroutine15 = celebrationPopup.StartCoroutine_Auto(routine14);
							}
						}
					}
					else
					{
						nint num69 = (nint)typeof(IPhoneXSupport);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ S0_v275 (Il2CppClass<IPhoneXSupport>)+BA]");
						object obj166 = (nint)0 & (nint)0x200;
						if (obj166 != null)
						{
							nint num70 = (nint)typeof(IPhoneXSupport);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ S0_v289 (Il2CppClass<IPhoneXSupport>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag8 = IPhoneXSupport.CheckIsiPhoneXDevice();
						int layer23 = _003CrewardGo_003E5__2.layer;
						if (flag8)
						{
							object obj167 = celebrationPopup + 556;
							reference = ref *(Quaternion*)obj167;
							object obj168 = obj167;
						}
						else
						{
							object obj169 = celebrationPopup + 544;
							reference = ref *(Quaternion*)obj169;
							object obj168 = obj169;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1725 @ L6_v18+8]");
						_ = 0;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
						Matrix4x4 matrix4x35 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
						((Matrix4x4*)(nint)matrix4x35)->m20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC4");
						IEnumerator routine15 = default;
						Coroutine coroutine16 = celebrationPopup.StartCoroutine_Auto(routine15);
					}
				}
				else if (((UnityEngine.Object)reward42).m_CachedPtr == (IntPtr)10)
				{
					int layer24 = _003CrewardGo_003E5__2.layer;
					object obj170 = celebrationPopup + 616;
					reference = ref *(Quaternion*)obj170;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ S1_v236+8]");
					_ = 0;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
					Matrix4x4 matrix4x36 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x36)->m20 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC4");
					IEnumerator routine16 = default;
					Coroutine coroutine17 = celebrationPopup.StartCoroutine_Auto(routine16);
					int layer25 = _003CrewardGo_003E5__2.layer;
					object obj171 = celebrationPopup + 640;
					reference2 = ref *(Quaternion*)obj171;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ S1_v248+8]");
					_ = 0;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
					Matrix4x4 matrix4x37 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x37)->m20 = 0f;
					IEnumerator routine17 = ((CelebrationPopup)null).ScaleGameObject((Transform)layer25, 2f, (Vector3)matrix4x);
					Coroutine coroutine18 = celebrationPopup.StartCoroutine_Auto(routine17);
				}
				else
				{
					_003C_003Ec__DisplayClass173_0 obj172 = _003C_003E8__1;
					CelebrationReward reward44 = obj172.reward;
					_003C_003Ec__DisplayClass173_0 obj173 = _003C_003E8__1;
					CelebrationReward reward45 = obj173.reward;
					if (reward45.CelebrationRewardOrigin == CelebrationRewardOrigin.TopRun)
					{
						object obj174 = reward44 - -64;
						bool flag9 = (nint)obj174 < 5;
						int layer26 = _003CrewardGo_003E5__2.layer;
						if (flag9)
						{
							object obj175 = celebrationPopup + 628;
							reference = ref *(Quaternion*)obj175;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1364 @ S1_v212+8]");
							_ = 0;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
							Matrix4x4 matrix4x38 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
							((Matrix4x4*)(nint)matrix4x38)->m20 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC4");
							IEnumerator routine18 = default;
							Coroutine coroutine19 = celebrationPopup.StartCoroutine_Auto(routine18);
							int layer27 = _003CrewardGo_003E5__2.layer;
							object obj176 = celebrationPopup + 664;
							reference2 = ref *(Quaternion*)obj176;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1749 @ S1_v224+8]");
							_ = 0;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
							Matrix4x4 matrix4x39 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
							((Matrix4x4*)(nint)matrix4x39)->m20 = 0f;
							IEnumerator routine19 = ((CelebrationPopup)null).ScaleGameObject((Transform)layer27, 1.5f, (Vector3)matrix4x);
							Coroutine coroutine20 = celebrationPopup.StartCoroutine_Auto(routine19);
						}
						else
						{
							object obj177 = celebrationPopup + 628;
							reference = ref *(Quaternion*)obj177;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ S1_v189+8]");
							_ = 0;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
							Matrix4x4 matrix4x40 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
							((Matrix4x4*)(nint)matrix4x40)->m20 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC4");
							IEnumerator routine20 = default;
							Coroutine coroutine21 = celebrationPopup.StartCoroutine_Auto(routine20);
							int layer28 = _003CrewardGo_003E5__2.layer;
							object obj178 = celebrationPopup + 652;
							reference2 = ref *(Quaternion*)obj178;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1772 @ S1_v201+8]");
							_ = 0;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
							Matrix4x4 matrix4x41 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
							((Matrix4x4*)(nint)matrix4x41)->m20 = 0f;
							IEnumerator routine21 = ((CelebrationPopup)null).ScaleGameObject((Transform)layer28, 0.5f, (Vector3)matrix4x);
							Coroutine coroutine22 = celebrationPopup.StartCoroutine_Auto(routine21);
						}
					}
					else
					{
						bool flag10 = reward44.rewardType == CelebrationRewardType.token;
						int layer29 = _003CrewardGo_003E5__2.layer;
						if (flag10)
						{
							object obj179 = celebrationPopup + 604;
							reference = ref *(Quaternion*)obj179;
							object obj180 = obj179;
						}
						else
						{
							object obj181 = celebrationPopup + 592;
							reference = ref *(Quaternion*)obj181;
							object obj180 = obj181;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1540 @ L6_v7+8]");
						_ = 0;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
						Matrix4x4 matrix4x42 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
						((Matrix4x4*)(nint)matrix4x42)->m20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC4");
						IEnumerator routine22 = default;
						Coroutine coroutine23 = celebrationPopup.StartCoroutine_Auto(routine22);
					}
				}
				IEnumerator enumerator5 = celebrationPopup.AnimateScreenFlash((UISprite)currentRewardIndex);
				if (enumerator5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+140]");
					object obj182 = (nint)0 + (nint)16;
					int num71 = currentRewardIndex << 2;
					object obj183 = obj182 + num71;
					int layer30 = ((GameObject)obj183).layer;
					object obj184 = celebrationPopup + 48;
					reference = ref *(Quaternion*)obj184;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2007 @ S1_v151+8]");
					_ = 0;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
					Matrix4x4 matrix4x43 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x43)->m20 = 0f;
					IEnumerator routine23 = ((CelebrationPopup)null).ScaleGameObject((Transform)layer30, 0.7f, (Vector3)matrix4x);
					Coroutine coroutine24 = celebrationPopup.StartCoroutine_Auto(routine23);
				}
				_003C_003Ec__DisplayClass173_0 obj185 = _003C_003E8__1;
				IEnumerator enumerator6 = celebrationPopup.TweenScaleUpDown((GameObject)(object)obj185.reward);
				if (enumerator6 == null)
				{
					_003C_003Ec__DisplayClass173_0 obj186 = _003C_003E8__1;
					CelebrationReward reward46 = obj186.reward;
					object obj187 = reward46.CelebrationRewardOrigin - 10;
					if (reward46.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
					{
						if ((nint)obj187 == 1)
						{
							_003C_003Ec__DisplayClass173_0 obj188 = _003C_003E8__1;
							object obj189 = obj188.reward - -64;
							bool flag11 = (nint)obj189 > 4;
							int layer31 = _003CrewardGo_003E5__2.layer;
							int num72;
							if (flag11)
							{
								object obj190 = celebrationPopup + 652;
								reference = ref *(Quaternion*)obj190;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2532 @ S1_v93+8]");
								_ = 0;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
								Matrix4x4 matrix4x44 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x44)->m20 = 0f;
								num72 = layer31;
							}
							else
							{
								reference = ref *(Quaternion*)null;
								_ = 0;
								reference = ref *(Quaternion*)0f;
								_ = 1440f;
								_ = 0f;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
								Matrix4x4 matrix4x45 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x45)->m20 = 0f;
								IEnumerator routine24 = ((CelebrationPopup)null).AnimateColor((UIWidget)layer31, 2f, (Color)matrix4x);
								Coroutine coroutine25 = celebrationPopup.StartCoroutine_Auto(routine24);
								int layer32 = _003CrewardGo_003E5__2.layer;
								object obj191 = celebrationPopup + 664;
								reference2 = ref *(Quaternion*)obj191;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ S1_v84+8]");
								_ = 0;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
								Matrix4x4 matrix4x46 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x46)->m20 = 0f;
								num72 = layer32;
							}
							IEnumerator routine25 = ((CelebrationPopup)null).Initial_Generic_DoubleUp_Routine((CelebrationReward)num72, (CelebrationPopupLabelTemplate)matrix4x);
							Coroutine coroutine26 = celebrationPopup.StartCoroutine_Auto(routine25);
						}
						else
						{
							_003C_003Ec__DisplayClass173_0 obj192 = _003C_003E8__1;
							CelebrationReward reward47 = obj192.reward;
							if (reward47.rewardType != CelebrationRewardType.specialBoard)
							{
								int layer33 = _003CrewardGo_003E5__2.layer;
								reference = ref *(Quaternion*)null;
								_ = 0;
								reference = ref *(Quaternion*)0f;
								_ = 1500f;
								_ = 0f;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
								Matrix4x4 matrix4x47 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x47)->m20 = 0f;
								IEnumerator routine26 = ((CelebrationPopup)null).AnimateColor((UIWidget)layer33, 4f, (Color)matrix4x);
								Coroutine coroutine27 = celebrationPopup.StartCoroutine_Auto(routine26);
							}
							else
							{
								reference = ref *(Quaternion*)null;
								_ = 0;
								reference = ref *(Quaternion*)(-30f);
								_ = -10f;
								_ = 30f;
								nint num73 = (nint)typeof(Quaternion);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2523 @ S0_v144 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
								object obj193 = (nint)0 & (nint)0x200;
								if (obj193 != null)
								{
									nint num74 = (nint)typeof(Quaternion);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2711 @ S0_v168 (Il2CppClass<UnityEngine.Quaternion>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
								Matrix4x4 matrix4x48 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x48)->m20 = 0f;
								Quaternion.Inverse_Injected(ref reference2, out *(Quaternion*)matrix4x);
								obj16 = reference2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
								_ = 0;
								int layer34 = _003CrewardGo_003E5__2.layer;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
								Matrix4x4 matrix4x49 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47+8]");
								((Matrix4x4*)(nint)matrix4x49)->m20 = 0f;
								Vector3 localScale6 = ((Transform)matrix4x).localScale;
								int layer35 = _003CrewardGo_003E5__2.layer;
								reference3 = ref *(Quaternion*)null;
								_ = 0;
								reference3 = ref *(Quaternion*)0f;
								_ = 1450f;
								_ = 0f;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference3;
								Matrix4x4 matrix4x50 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
								((Matrix4x4*)(nint)matrix4x50)->m20 = 0f;
								IEnumerator routine27 = ((CelebrationPopup)null).AnimateColor((UIWidget)layer35, 4f, (Color)matrix4x);
								Coroutine coroutine28 = celebrationPopup.StartCoroutine_Auto(routine27);
							}
						}
					}
					else
					{
						int layer36 = _003CrewardGo_003E5__2.layer;
						reference = ref *(Quaternion*)null;
						_ = 0;
						reference = ref *(Quaternion*)0f;
						_ = 1440f;
						_ = 0f;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
						Matrix4x4 matrix4x51 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
						((Matrix4x4*)(nint)matrix4x51)->m20 = 0f;
						IEnumerator routine28 = ((CelebrationPopup)null).AnimateColor((UIWidget)layer36, 2f, (Color)matrix4x);
						Coroutine coroutine29 = celebrationPopup.StartCoroutine_Auto(routine28);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.5f;
				object obj194 = this + 12;
				object obj195 = default;
				obj194 = obj195;
				_003C_003E1__state = 4;
				return 1;
				IL_5042:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1616 @ L9_v7+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference;
				Matrix4x4 matrix4x52 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Quaternion&)+8]");
				((Matrix4x4*)(nint)matrix4x52)->m20 = 0f;
				Vector3 eulerAngles4 = ((Transform)matrix4x).eulerAngles;
				object obj196 = this + 36;
				CelebrationPopupLabelTemplate component6 = _003ClabelGo_003E5__3.GetComponent<CelebrationPopupLabelTemplate>();
				obj196 = component6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+32C]");
				object obj197 = 0;
				CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = _003Ctemplate_003E5__4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1859 @ S1_v335+F4]");
				celebrationPopupLabelTemplate.SetupTrophy(Trophies.Trophy.diamond);
				CelebrationPopupLabelTemplate celebrationPopupLabelTemplate2 = _003Ctemplate_003E5__4;
				nint num75 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1898 @ S0_v372 (Il2CppClass<GlobalColors>)+BA]");
				object obj198 = (nint)0 & (nint)0x200;
				bool flag12 = obj198 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v58 (UI.Screens.CelebrationPopup)+334]");
				if ((nint)0 != 0)
				{
					if (!flag12)
					{
						nint num76 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2066 @ S0_v687 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj5 = *(Quaternion*)GlobalColors.WEEKLYHUNT_CELEBRATION_TEXT_COLOR_STRIPED_BACKGROUND;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
					Matrix4x4 matrix4x53 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
					Matrix4x4 matrix4x54 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x54)->m20 = 0f;
					celebrationPopupLabelTemplate2.bigLabel.rawPivot = (UIWidget.Pivot)matrix4x;
					CelebrationPopupLabelTemplate celebrationPopupLabelTemplate3 = _003Ctemplate_003E5__4;
					obj6 = *(Quaternion*)GlobalColors.WEEKLYHUNT_CELEBRATION_TEXT_COLOR_STRIPED_BACKGROUND;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
					Matrix4x4 matrix4x55 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference4;
					Matrix4x4 matrix4x56 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x56)->m20 = 0f;
					celebrationPopupLabelTemplate3.subLabel.rawPivot = (UIWidget.Pivot)matrix4x;
					nint num77 = (nint)typeof(GlobalColorsGenerated);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2484 @ S1_v578 (Il2CppClass<GlobalColorsGenerated>)+BA]");
					object obj199 = (nint)0 & (nint)0x200;
					if (obj199 != null)
					{
						nint num78 = (nint)typeof(GlobalColorsGenerated);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2660 @ S1_v597 (Il2CppClass<GlobalColorsGenerated>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj3 = GlobalColorsGenerated.WEEKLYHUNT_CELEBRATION_TEXT_SHADOW_COLOR_STRIPED_BACKGROUND;
					obj8 = obj3;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
					Matrix4x4 matrix4x57 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
					Matrix4x4 matrix4x58 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
					((Matrix4x4*)(nint)matrix4x58)->m20 = 0f;
					Vector2 effectDistance = ((UILabel)matrix4x).effectDistance;
					obj9 = GlobalColorsGenerated.WEEKLYHUNT_CELEBRATION_TEXT_SHADOW_COLOR_STRIPED_BACKGROUND;
					obj11 = obj9;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
				}
				else
				{
					if (!flag12)
					{
						nint num79 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2089 @ S0_v659 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj12 = *(Quaternion*)GlobalColors.WEEKLYHUNT_CELEBRATION_TEXT_COLOR;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
					Matrix4x4 matrix4x59 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference2;
					Matrix4x4 matrix4x60 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x60)->m20 = 0f;
					celebrationPopupLabelTemplate2.bigLabel.rawPivot = (UIWidget.Pivot)matrix4x;
					CelebrationPopupLabelTemplate celebrationPopupLabelTemplate4 = _003Ctemplate_003E5__4;
					obj13 = *(Quaternion*)GlobalColors.WEEKLYHUNT_CELEBRATION_TEXT_COLOR;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
					Matrix4x4 matrix4x61 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)reference4;
					Matrix4x4 matrix4x62 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UnityEngine.Quaternion&)+8]");
					((Matrix4x4*)(nint)matrix4x62)->m20 = 0f;
					celebrationPopupLabelTemplate4.subLabel.rawPivot = (UIWidget.Pivot)matrix4x;
					obj3 = GlobalColors.WEEKLYHUNT_CELEBRATION_TEXT_SHADOW_COLOR;
					obj14 = obj3;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
					Matrix4x4 matrix4x63 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
					Matrix4x4 matrix4x64 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
					((Matrix4x4*)(nint)matrix4x64)->m20 = 0f;
					Vector2 effectDistance2 = ((UILabel)matrix4x).effectDistance;
					obj9 = GlobalColors.WEEKLYHUNT_CELEBRATION_TEXT_SHADOW_COLOR;
					obj15 = obj9;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
				}
				Matrix4x4 matrix4x65 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
				Matrix4x4 matrix4x66 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
				((Matrix4x4*)(nint)matrix4x66)->m20 = 0f;
				Vector2 effectDistance3 = ((UILabel)matrix4x).effectDistance;
				_003C_003Ec__DisplayClass173_0 obj200 = _003C_003E8__1;
				CelebrationReward reward48 = obj200.reward;
				object obj201 = reward48.CelebrationRewardOrigin - 10;
				if (reward48.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
				{
					if ((nint)obj201 == 1)
					{
						_003C_003Ec__DisplayClass173_0 obj202 = _003C_003E8__1;
						CelebrationReward reward49 = obj202.reward;
						_003C_003Ec__DisplayClass173_0 obj203 = _003C_003E8__1;
						object backupDescription = obj203.reward - -64;
						_003C_003Ec__DisplayClass173_0 obj204 = _003C_003E8__1;
						CelebrationReward reward50 = obj204.reward;
						((DiscountButton)(object)_003Ctemplate_003E5__4).ShowOnPromotion((string)reward49.score, (string)backupDescription, (string)reward50.weekNumber);
						tag = null;
					}
					else
					{
						_003C_003Ec__DisplayClass173_0 obj205 = _003C_003E8__1;
						CelebrationReward reward51 = obj205.reward;
						object obj206 = reward51.rewardType - 1;
						if (reward51.rewardType != CelebrationRewardType.coins)
						{
							if ((nint)obj206 != 1)
							{
								if ((nint)obj206 != 2)
								{
									if ((nint)obj206 != 3)
									{
										if ((nint)obj206 != 4)
										{
											if ((nint)obj206 != 5)
											{
												if ((nint)obj206 == 6)
												{
													goto IL_2ace;
												}
												if ((nint)obj206 != 7)
												{
													if ((nint)obj206 != 8)
													{
														if ((nint)obj206 != 9)
														{
															if ((nint)obj206 == 10)
															{
																_003C_003Ec__DisplayClass173_0 obj207 = _003C_003E8__1;
																CelebrationReward reward52 = obj207.reward;
																List<HoverboardThemes.ThemeIdentifier> bundledThemes2 = reward52.bundledThemes;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3528 @ S0_v571 (System.Collections.Generic.List`1<HoverboardThemes+ThemeIdentifier>)+C]");
																NullReferenceException ex;
																if ((nint)0 < (nint)1)
																{
																	ex = null;
																}
																else
																{
																	nint num80 = (nint)typeof(HoverboardThemes);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3552 @ S0_v621 (Il2CppClass<HoverboardThemes>)+BA]");
																	object obj208 = (nint)0 & (nint)0x200;
																	if (obj208 != null)
																	{
																		nint num81 = (nint)typeof(HoverboardThemes);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3634 @ S0_v630 (Il2CppClass<HoverboardThemes>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	_003C_003Ec__DisplayClass173_0 obj209 = _003C_003E8__1;
																	CelebrationReward reward53 = obj209.reward;
																	List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(reward53.boardId);
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																	nint num82 = 0;
																	_ = 0;
																	object obj211 = default;
																	object obj210 = obj211 + 16;
																	obj210 = _003C_003E8__1;
																	ex = new NullReferenceException();
																}
																_003C_003Ec__DisplayClass173_0 obj212 = _003C_003E8__1;
																CelebrationReward reward54 = obj212.reward;
																List<HoverboardThemes.ThemeIdentifier> bundledThemes3 = reward54.bundledThemes;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3629 @ S0_v580 (System.Collections.Generic.List`1<HoverboardThemes+ThemeIdentifier>)+C]");
																AwardTierType type;
																if ((nint)0 < (nint)2)
																{
																	type = AwardTierType.None;
																}
																else
																{
																	nint num83 = (nint)typeof(HoverboardThemes);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3691 @ S0_v588 (Il2CppClass<HoverboardThemes>)+BA]");
																	object obj213 = (nint)0 & (nint)0x200;
																	if (obj213 != null)
																	{
																		nint num84 = (nint)typeof(HoverboardThemes);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3777 @ S0_v613 (Il2CppClass<HoverboardThemes>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	_003C_003Ec__DisplayClass173_0 obj214 = _003C_003E8__1;
																	CelebrationReward reward55 = obj214.reward;
																	List<HoverboardThemes.HoverboardTheme> list2 = HoverboardThemes.hoverboardCustomThemes.get_Item(reward55.boardId);
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																	nint num85 = 0;
																	_ = 0;
																	object obj216 = default;
																	object obj215 = obj216 + 16;
																	obj215 = _003C_003E8__1;
																	bool flag13 = ex != null;
																	NullReferenceException ex2 = new NullReferenceException();
																	bool flag14 = ex2 == null;
																	object obj217 = flag13 | flag14;
																	bool flag15 = obj217 == null;
																	bool flag16 = !flag15;
																	type = (AwardTierType)ex2;
																	if (!flag16)
																	{
																		SDebug.LogFormat("It shouldn't happen, but theme 2 is set while theme 1 is not", null);
																		type = (AwardTierType)ex2;
																	}
																}
																nint num86 = (nint)typeof(Strings);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3771 @ S1_v477 (Il2CppClass<Strings>)+BA]");
																object obj218 = (nint)0 & (nint)0x200;
																if (obj218 != null)
																{
																	nint num87 = (nint)typeof(Strings);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3852 @ S1_v485 (Il2CppClass<Strings>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	}
																}
																string format2 = Strings.GetDefault("BOARD_DISPLAY_NAME_WITH_SUFFIX");
																nint num88 = (nint)typeof(Boards);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3887 @ S2_v197 (Il2CppClass<Info.Boards>)+BA]");
																object obj219 = (nint)0 & (nint)0x200;
																if (obj219 != null)
																{
																	nint num89 = (nint)typeof(Boards);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3936 @ S2_v208 (Il2CppClass<Info.Boards>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	}
																}
																_003C_003Ec__DisplayClass173_0 obj220 = _003C_003E8__1;
																CelebrationReward reward56 = obj220.reward;
																Boards.Board board3 = Boards.boardData.get_Item(reward56.boardId);
																string args2 = Strings.GetDefault(board3.name);
																string awardTitle = string.Format(format2, (object[])(object)args2);
																_003Ctemplate_003E5__4.SetupAward(awardTitle, (int)ex, type);
																tag = null;
																goto IL_5358;
															}
															if ((nint)obj206 == 11)
															{
																goto IL_2ace;
															}
														}
														tag = null;
													}
													else
													{
														_003ClabelGo_003E5__3.tag = null;
														tag = null;
													}
												}
												else
												{
													_003C_003Ec__DisplayClass173_0 obj221 = _003C_003E8__1;
													CelebrationReward reward57 = obj221.reward;
													_003C_003Ec__DisplayClass173_0 obj222 = _003C_003E8__1;
													CelebrationReward reward58 = obj222.reward;
													nint num90 = (nint)typeof(Outfits);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3476 @ S2_v176 (Il2CppClass<Info.Outfits>)+BA]");
													object obj223 = (nint)0 & (nint)0x200;
													if (obj223 != null)
													{
														nint num91 = (nint)typeof(Outfits);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3493 @ S2_v187 (Il2CppClass<Info.Outfits>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													if (((OutfitSet)reward57.characterId).HasOutfitWithName((string)reward58.characterOutfitIndex))
													{
														nint num92 = (nint)typeof(Strings);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3536 @ S0_v552 (Il2CppClass<Strings>)+BA]");
														object obj224 = (nint)0 & (nint)0x200;
														if (obj224 != null)
														{
															nint num93 = (nint)typeof(Strings);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3558 @ S0_v558 (Il2CppClass<Strings>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3501 @ S0_v518 (System.Boolean)+20]");
														string boardName2 = Strings.GetDefault((string)0);
														_003Ctemplate_003E5__4.SetupSpecialBoard(boardName2);
														tag = null;
													}
													else
													{
														nint num94 = (nint)typeof(Characters);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3542 @ S0_v523 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
														object obj225 = (nint)0 & (nint)0x200;
														if (obj225 != null)
														{
															nint num95 = (nint)typeof(Characters);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3567 @ S0_v543 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														_003C_003Ec__DisplayClass173_0 obj226 = _003C_003E8__1;
														CelebrationReward reward59 = obj226.reward;
														Characters.Model model = Characters.characterData.get_Item(reward59.characterId);
														nint num96 = (nint)typeof(Strings);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3654 @ S0_v533 (Il2CppClass<Strings>)+BA]");
														object obj227 = (nint)0 & (nint)0x200;
														if (obj227 != null)
														{
															nint num97 = (nint)typeof(Strings);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3704 @ S0_v539 (Il2CppClass<Strings>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														string boardName3 = Strings.GetDefault(model.name);
														_003Ctemplate_003E5__4.SetupSpecialBoard(boardName3);
														tag = null;
													}
												}
											}
											else
											{
												_003C_003Ec__DisplayClass173_0 obj228 = _003C_003E8__1;
												CelebrationReward reward60 = obj228.reward;
												_003Ctemplate_003E5__4.SetupCharacterWordEvent(reward60.amount, null);
												tag = null;
											}
										}
										else
										{
											_003Ctemplate_003E5__4._002Ector();
											tag = (string)1;
										}
									}
									else
									{
										_003C_003Ec__DisplayClass173_0 obj229 = _003C_003E8__1;
										CelebrationReward reward61 = obj229.reward;
										_003Ctemplate_003E5__4.SetupCharacter((string)reward61.trophyType);
										tag = (string)1;
									}
								}
								else
								{
									nint num98 = (nint)typeof(Characters);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3351 @ S0_v425 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
									object obj230 = (nint)0 & (nint)0x200;
									if (obj230 != null)
									{
										nint num99 = (nint)typeof(Characters);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3382 @ S0_v444 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									_003C_003Ec__DisplayClass173_0 obj231 = _003C_003E8__1;
									CelebrationReward reward62 = obj231.reward;
									Characters.Model model2 = Characters.characterData.get_Item(reward62.characterId);
									_003C_003Ec__DisplayClass173_0 obj232 = _003C_003E8__1;
									CelebrationReward reward63 = obj232.reward;
									nint num100 = (nint)typeof(CharacterManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3417 @ S1_v377 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
									object obj233 = (nint)0 & (nint)0x200;
									if (obj233 != null)
									{
										nint num101 = (nint)typeof(CharacterManager);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3430 @ S1_v387 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									int outfitIndex = CharacterManager.GetOutfitIndex(reward63.characterId);
									_003C_003Ec__DisplayClass173_0 obj234 = _003C_003E8__1;
									CelebrationReward reward64 = obj234.reward;
									_003C_003Ec__DisplayClass173_0 obj235 = _003C_003E8__1;
									CelebrationReward reward65 = obj235.reward;
									object obj236 = model2.Price - outfitIndex;
									_003C_003Ec__DisplayClass173_0 obj237 = _003C_003E8__1;
									CelebrationReward reward66 = obj237.reward;
									string screenName = (string)(obj236 - reward66.amount);
									((CoinButtonHelper)(object)_003Ctemplate_003E5__4).Init((InAppItemModel)reward64.characterId, (Transform)reward65.amount, screenName, false);
									StayInOneLaneMission instance = StayInOneLaneMission.instance;
									_003C_003Ec__DisplayClass173_0 obj238 = _003C_003E8__1;
									CelebrationReward reward67 = obj238.reward;
									((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)20, (PersistentAwardProgress)reward67.amount, (Action<Award>)(-1));
									tag = null;
								}
							}
							else
							{
								_003C_003Ec__DisplayClass173_0 obj239 = _003C_003E8__1;
								CelebrationReward reward68 = obj239.reward;
								_003C_003Ec__DisplayClass173_0 obj240 = _003C_003E8__1;
								CelebrationReward reward69 = obj240.reward;
								_003Ctemplate_003E5__4.UpdateCoins((int)reward68.upgradeType, (byte)reward69.amount != 0);
								tag = null;
							}
						}
						else
						{
							_003Ctemplate_003E5__4.SetupMedal();
							tag = null;
						}
					}
				}
				else
				{
					_003C_003Ec__DisplayClass173_0 obj241 = _003C_003E8__1;
					CelebrationReward reward70 = obj241.reward;
					_003C_003Ec__DisplayClass173_0 obj242 = _003C_003E8__1;
					CelebrationReward reward71 = obj242.reward;
					_003C_003Ec__DisplayClass173_0 obj243 = _003C_003E8__1;
					CelebrationReward reward72 = obj243.reward;
					_003Ctemplate_003E5__4.SetupTopRun((int)reward70.awardTitle, reward71.amount, (int)reward72.awardTierType);
					tag = null;
				}
				goto IL_5358;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

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

	private sealed class _003CMoveNextBoxToFront_003Ed__177(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_051c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0521: Expected VT, but got Unknown
				//IL_003d: Expected VT, but got Obj
				//IL_0046: Expected VT, but got Obj
				//IL_0060: Expected F4, but got I
				//IL_0060: Expected Obj, but got VT
				//IL_0093: Expected Obj, but got I4
				//IL_0558: Unknown result type (might be due to invalid IL or missing references)
				//IL_055d: Expected Obj, but got Unknown
				//IL_0578: Unknown result type (might be due to invalid IL or missing references)
				//IL_057d: Expected Obj, but got Unknown
				//IL_0598: Unknown result type (might be due to invalid IL or missing references)
				//IL_059d: Expected Obj, but got Unknown
				//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05bd: Expected Obj, but got Unknown
				//IL_00fd: Expected F4, but got Obj
				//IL_00f8: Expected native int or pointer, but got VT
				//IL_0112: Expected F4, but got I
				//IL_010d: Expected native int or pointer, but got VT
				//IL_0132: Unknown result type (might be due to invalid IL or missing references)
				//IL_0137: Expected Obj, but got Unknown
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Expected Obj, but got Unknown
				//IL_019e: Expected Obj, but got I4
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f0: Expected Obj, but got Unknown
				//IL_020b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0210: Expected Obj, but got Unknown
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Expected Obj, but got Unknown
				//IL_024f: Expected Obj, but got I4
				//IL_024f: Expected Obj, but got I4
				//IL_025d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0262: Expected Obj, but got Unknown
				//IL_027d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0282: Expected Obj, but got Unknown
				//IL_02af: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b4: Expected Obj, but got Unknown
				//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d4: Expected Obj, but got Unknown
				//IL_0335: Expected I, but got Obj
				//IL_034b: Expected Obj, but got I
				//IL_0308: Unknown result type (might be due to invalid IL or missing references)
				//IL_030d: Expected Obj, but got Unknown
				//IL_03c2: Expected F4, but got Obj
				//IL_03bd: Expected native int or pointer, but got VT
				//IL_03d7: Expected F4, but got I
				//IL_03d2: Expected native int or pointer, but got VT
				//IL_03ea: Expected Obj, but got I4
				//IL_0376: Expected I, but got Obj
				//IL_0412: Unknown result type (might be due to invalid IL or missing references)
				//IL_0417: Expected Obj, but got Unknown
				//IL_0432: Unknown result type (might be due to invalid IL or missing references)
				//IL_0437: Expected Obj, but got Unknown
				//IL_0452: Unknown result type (might be due to invalid IL or missing references)
				//IL_0457: Expected Obj, but got Unknown
				//IL_0472: Unknown result type (might be due to invalid IL or missing references)
				//IL_0477: Expected Obj, but got Unknown
				//IL_0488: Expected I4, but got Obj
				//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a8: Expected Obj, but got Unknown
				//IL_04c4: Expected Obj, but got I4
				object obj = default;
				Vector4 vector = (Vector4)(obj + 16);
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					celebrationPopup.openButtonCollider.isTrigger = true;
				}
				else
				{
					_003C_003E1__state = -1;
					_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
					_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11 (T)+10]");
					((TimeScaleManager)val).TimeScaleInMenuDefault = 0f;
					int currentReward = celebrationPopup._currentReward + 1;
					celebrationPopup._currentReward = currentReward;
					object obj2 = celebrationPopup._numberOfRewards - 1;
					if (celebrationPopup._currentReward >= (nint)obj2)
					{
						celebrationPopup._anotherReward = false;
					}
					object obj3 = celebrationPopup._rewardsToUnlock + 16;
					int num = celebrationPopup._currentReward << 2;
					object preOpenedCelebrationLabelTemplate = obj3 + num;
					celebrationPopup.SetPreOpenedCelebrationLabelTemplate((CelebrationReward)preOpenedCelebrationLabelTemplate);
					object obj4 = celebrationPopup._rewardsToUnlock + 16;
					int num2 = celebrationPopup._currentReward << 2;
					object obj5 = obj4 + num2;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v29+8]");
					celebrationPopup.ShowPrizeList(MysteryBox.Type.Normal);
					MeshRenderer component = celebrationPopup.GlowEffect.GetComponent<MeshRenderer>();
					Material sharedMaterial = component.sharedMaterial;
					Color yellow = Color.yellow;
					((Vector4*)(nint)vector)->x = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector4*)(nint)vector)->z = 0f;
					sharedMaterial.SetVector("_MainColor", vector);
					object obj7 = celebrationPopup._rewardsToUnlock + 16;
					int num3 = celebrationPopup._currentReward << 2;
					object obj8 = obj7 + num3;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v41+8]");
					celebrationPopup.OnApplicationPause(pause: false);
					celebrationPopup.openButtonCollider.isTrigger = false;
					IEnumerator enumerator = celebrationPopup.AnimateScreenFlash((UISprite)celebrationPopup._currentReward);
					if (enumerator != null)
					{
						object obj10 = celebrationPopup._celebrationRewardContainer + 16;
						int num4 = celebrationPopup._currentReward << 2;
						object obj11 = obj10 + num4;
						int layer = ((GameObject)obj11).layer;
						object obj12 = celebrationPopup._slots + 16;
						int layer2 = ((GameObject)obj12).layer;
						((Transform)layer).parentInternal = (Transform)layer2;
						object obj13 = celebrationPopup._rewardsToUnlock + 16;
						int num5 = celebrationPopup._currentReward << 2;
						object obj14 = obj13 + num5;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v50+8]");
						bool flag = (nint)0 == 11;
						object obj16 = celebrationPopup._celebrationRewardContainer + 16;
						int num6 = celebrationPopup._currentReward << 2;
						object obj17 = obj16 + num6;
						int layer3 = ((GameObject)obj17).layer;
						if (flag)
						{
							object obj18 = celebrationPopup + 424;
							obj = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S2_v54+8]");
							_ = 0;
						}
						else
						{
							nint num7 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v83 (Il2CppClass<UnityEngine.Vector3>)+BA]");
							object obj19 = (nint)0 & (nint)0x200;
							if (obj19 != null)
							{
								nint num8 = (nint)typeof(Vector3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v88 (Il2CppClass<UnityEngine.Vector3>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Vector3 one = Vector3.one;
						}
						((Vector4*)(nint)vector)->x = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector4*)(nint)vector)->z = 0f;
						IEnumerator routine = ((CelebrationPopup)null).ScaleGameObject((Transform)layer3, 0.35f, (Vector3)vector);
						Coroutine coroutine = celebrationPopup.StartCoroutine_Auto(routine);
						object obj20 = celebrationPopup._celebrationRewardContainer + 16;
						int num9 = celebrationPopup._currentReward << 2;
						object obj21 = obj20 + num9;
						int layer4 = ((GameObject)obj21).layer;
						object obj22 = celebrationPopup._rewardsToUnlock + 16;
						int num10 = celebrationPopup._currentReward << 2;
						object obj23 = obj22 + num10;
						celebrationPopup.ShowBackgroundWithStripes((Boards.BoardId)layer4, (UIModelController.ModelScreen)obj23);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.35f;
						object obj24 = this + 12;
						object obj25 = default;
						obj24 = obj25;
						_003C_003E1__state = 1;
						return 1;
					}
					celebrationPopup._FinishOpening();
				}
				celebrationPopup.skipButtonCollider.isTrigger = true;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CRotateGameObject_003Ed__178(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public float duration;

		public Vector3 angleToRotate;

		private Quaternion _003CfromRotation_003E5__2;

		private float _003Cfactor_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c8: Expected Obj, but got Unknown
				//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d6: Expected Obj, but got Unknown
				//IL_03df: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e4: Expected Obj, but got Unknown
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_0083: Expected I, but got Obj
				//IL_00d1: Expected VT, but got Obj
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Expected Obj, but got Unknown
				//IL_043b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0440: Expected Obj, but got Unknown
				//IL_0174: Expected I, but got Obj
				//IL_018a: Expected Obj, but got I
				//IL_01b5: Expected I, but got Obj
				//IL_0237: Expected I, but got Obj
				//IL_024d: Expected Obj, but got I
				//IL_0278: Expected I, but got Obj
				//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0503: Expected Obj, but got Unknown
				//IL_0312: Unknown result type (might be due to invalid IL or missing references)
				//IL_0317: Expected Obj, but got Unknown
				//IL_033a: Expected I, but got Obj
				//IL_0350: Expected Obj, but got I
				//IL_0576: Expected VT, but got Obj
				//IL_05ab: Expected VT, but got I4
				//IL_05ab: Expected VT, but got Obj
				//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_05b6: Expected Obj, but got Unknown
				//IL_05bf: Expected Obj, but got I4
				//IL_05d3: Expected Obj, but got I4
				//IL_037b: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 40);
				Transform transform2 = (Transform)(obj + 24);
				object obj2 = obj + 12;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v82 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)trans).FindKernel((string)null) == 0)
					{
						return null;
					}
					transform2.localRotation = (Quaternion)trans;
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					object obj4 = this + 36;
					obj4 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					_003Cfactor_003E5__3 = 0f;
				}
				if (_003Cfactor_003E5__3 < 1f)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)trans).FindKernel((string)null) != 0)
					{
						float unscaledTime = Time.unscaledTime;
						float num5 = unscaledTime / duration;
						float num6 = _003Cfactor_003E5__3 + num5;
						_003Cfactor_003E5__3 = num6;
						nint num7 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v32 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num8 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v50 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num9;
						if (_003Cfactor_003E5__3 < 0f)
						{
							num9 = 0f;
						}
						else
						{
							num9 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
						}
						_003Cfactor_003E5__3 = num9;
						float num10 = Mathf.LerpUnclamped(4.712389f, (float)Math.PI * 2f, _003Cfactor_003E5__3);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
						object obj7 = default;
						float num11 = (float)obj7 * 0.5f;
						float num12 = num11 + 0.5f;
						object obj8 = this + 36;
						transform2 = (Transform)obj8;
						Transform transform3 = transform2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S2_v14+8]");
						((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
						transform = transform2;
						((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
						Vector3 localScale = transform.localScale;
						object obj9 = this + 24;
						obj2 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S2_v24+8]");
						_ = 0;
						nint num13 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v37 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num14 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v50 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						transform = (Transform)obj2;
						Transform transform4 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						Vector3 vector = (Vector3)transform / num12;
						transform = (Transform)obj;
						Transform transform5 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
						trans.LookAt((Vector3)transform, (Vector3)0);
						object obj11 = this + 12;
						obj11 = 0;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				object obj12 = this + 36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCountUpCoins_003Ed__179(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public int toAmount;

		public int fromAmount;

		public float countTimeMultiplier;

		public int coinboxAmount;

		public CelebrationPopupLabelTemplate rewardTemplate;

		public bool isMegaJackpot;

		public bool doubled;

		private float _003CcountFactor_003E5__2;

		private float _003CcountTime_003E5__3;

		private int _003CcoinboxFrom_003E5__4;

		private int _003CcoinboxTo_003E5__5;

		private int _003CrewardLabelFrom_003E5__6;

		private int _003CrewardLabelTo_003E5__7;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_02f2: Expected Obj, but got I4
				//IL_00a3: Expected Obj, but got I4
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b2: Expected I4, but got Unknown
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d3: Expected Obj, but got Unknown
				//IL_00dd: Expected Obj, but got I4
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Expected Obj, but got Unknown
				//IL_0114: Expected Obj, but got I4
				//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ca: Expected Obj, but got Unknown
				//IL_01d8: Expected I, but got Obj
				//IL_01ee: Expected Obj, but got I
				//IL_0335: Expected F4, but got Obj
				//IL_0335: Expected F4, but got I4
				//IL_0385: Expected Obj, but got I4
				//IL_0385: Expected Obj, but got I4
				//IL_0180: Expected Obj, but got I4
				//IL_026f: Expected F4, but got I4
				//IL_026f: Expected F4, but got I4
				//IL_0219: Expected I, but got Obj
				//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c7: Expected Obj, but got Unknown
				//IL_02d0: Expected Obj, but got I4
				//IL_02e4: Expected Obj, but got I4
				object obj = 0;
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1 && _003C_003E1__state != 2)
					{
						return null;
					}
					_003C_003E1__state = -1;
					if (!(_003CcountFactor_003E5__2 < 1f))
					{
						((CoinEarnerLoadingOffer)(object)celebrationPopup._coinboxSizer).Init((Action)1);
						return null;
					}
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime / _003CcountTime_003E5__3;
					float num2 = _003CcountFactor_003E5__2 + num;
					_003CcountFactor_003E5__2 = num2;
					object obj2 = this - -64;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S2_v18 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S2_v33 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float width = Mathf.InverseLerp(_003CrewardLabelFrom_003E5__6, (float)obj2, _003CcountFactor_003E5__2);
					GUILayoutOption boardName = GUILayout.Width(width);
					bool flag = isMegaJackpot;
					bool flag2 = doubled;
					rewardTemplate.SetupBoardBundle((string)(object)boardName, (HoverboardThemes.HoverboardTheme)flag, (HoverboardThemes.HoverboardTheme)flag2);
					float width2 = Mathf.InverseLerp(_003CcoinboxFrom_003E5__4, _003CcoinboxTo_003E5__5, _003CcountFactor_003E5__2);
					GUILayoutOption gUILayoutOption = GUILayout.Width(width2);
					obj = gUILayoutOption;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					int fontSize = default;
					celebrationPopup._coinboxLabel.fontSize = fontSize;
					celebrationPopup._coinboxSizer._AdjustKeysSegmentSize();
					object obj4 = this + 12;
					obj4 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				((CoinEarnerLoadingOffer)(object)celebrationPopup._coinboxSizer).Init((Action)null);
				_003CcountFactor_003E5__2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EBE");
				float num5 = default;
				_003CcountTime_003E5__3 = num5;
				_003CcoinboxFrom_003E5__4 = coinboxAmount;
				object obj5 = toAmount + _003CcoinboxFrom_003E5__4;
				int num6 = obj5 - fromAmount;
				_003CcoinboxTo_003E5__5 = num6;
				_003CrewardLabelFrom_003E5__6 = fromAmount;
				object obj6 = this - -64;
				obj6 = toAmount;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.5f;
				object obj7 = this + 12;
				object obj8 = default;
				obj7 = obj8;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CAnimateAlpha_003Ed__181(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UILabel label;

		public float duration;

		public float toAlpha;

		private float _003CfromAlpha_003E5__2;

		private float _003Cfactor_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00df: Expected I, but got Obj
				//IL_00f5: Expected Obj, but got I
				//IL_0120: Expected I, but got Obj
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Expected Obj, but got Unknown
				//IL_024f: Expected Obj, but got I4
				//IL_0263: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
					float num = default;
					_003CfromAlpha_003E5__2 = num;
					_003Cfactor_003E5__3 = 0f;
				}
				if (_003Cfactor_003E5__3 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime / duration;
					float num3 = _003Cfactor_003E5__3 + num2;
					_003Cfactor_003E5__3 = num3;
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num5 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num6;
					if (_003Cfactor_003E5__3 < 0f)
					{
						num6 = 0f;
					}
					else
					{
						num6 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
					}
					_003Cfactor_003E5__3 = num6;
					float num7 = Mathf.LerpUnclamped(_003CfromAlpha_003E5__2, toAlpha, _003Cfactor_003E5__3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CAnimateAlpha_003Ed__182(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopupLabelTemplate template;

		public float duration;

		public float toAlpha;

		private float _003CfromAlpha_003E5__2;

		private float _003Cfactor_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00e4: Expected I, but got Obj
				//IL_00fa: Expected Obj, but got I
				//IL_0125: Expected I, but got Obj
				//IL_024b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0250: Expected Obj, but got Unknown
				//IL_0259: Expected Obj, but got I4
				//IL_026d: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					float nearClipPlane = ((CameraSettings)(object)template).nearClipPlane;
					_003CfromAlpha_003E5__2 = nearClipPlane;
					_003Cfactor_003E5__3 = 0f;
				}
				if (_003Cfactor_003E5__3 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime / duration;
					float num2 = _003Cfactor_003E5__3 + num;
					_003Cfactor_003E5__3 = num2;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num5;
					if (_003Cfactor_003E5__3 < 0f)
					{
						num5 = 0f;
					}
					else
					{
						num5 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
					}
					_003Cfactor_003E5__3 = num5;
					float nearClipPlane2 = Mathf.LerpUnclamped(_003CfromAlpha_003E5__2, toAlpha, _003Cfactor_003E5__3);
					((CameraSettings)(object)template).nearClipPlane = nearClipPlane2;
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CAnimateColor_003Ed__183(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWidget widget;

		public float duration;

		public Color toColor;

		private Color _003CfromColor_003E5__2;

		private float _003Cfactor_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0221: Unknown result type (might be due to invalid IL or missing references)
				//IL_0226: Expected I4, but got Unknown
				//IL_022f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0234: Expected I4, but got Unknown
				//IL_023d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0242: Expected Obj, but got Unknown
				//IL_024b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0250: Expected Obj, but got Unknown
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Expected Obj, but got Unknown
				//IL_0051: Expected I4, but got Obj
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Expected Obj, but got Unknown
				//IL_0095: Expected Obj, but got I4
				//IL_0139: Expected I, but got Obj
				//IL_014f: Expected Obj, but got I
				//IL_017a: Expected I, but got Obj
				//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b3: Expected Obj, but got Unknown
				//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d3: Expected Obj, but got Unknown
				//IL_02f5: Expected I4, but got Obj
				//IL_030f: Expected I4, but got Obj
				//IL_0333: Expected Ref, but got VT
				//IL_0345: Expected I4, but got F4
				//IL_0364: Unknown result type (might be due to invalid IL or missing references)
				//IL_0369: Expected Obj, but got Unknown
				//IL_0372: Expected Obj, but got I4
				//IL_0386: Expected Obj, but got I4
				Matrix4x4 matrix4x = default;
				int num = matrix4x - -64;
				int num2 = matrix4x + 48;
				object obj = matrix4x + 32;
				object obj2 = matrix4x + 16;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj3 = widget + 80;
					((int*)num2)->m_value = (int)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v43+8]");
					_ = 0;
					((int*)num)->m_value = ((int*)num2)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (System.Int32)+8]");
					_ = 0;
					object obj4 = this + 40;
					obj4 = ((int*)num)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
					_ = 0;
					_003Cfactor_003E5__3 = 0f;
				}
				if (_003Cfactor_003E5__3 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num3 = unscaledTime / duration;
					float num4 = _003Cfactor_003E5__3 + num3;
					_003Cfactor_003E5__3 = num4;
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num6 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v39 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num7;
					if (_003Cfactor_003E5__3 < 0f)
					{
						num7 = 0f;
					}
					else
					{
						num7 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
					}
					_003Cfactor_003E5__3 = num7;
					object obj6 = this + 40;
					obj = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S2_v9+8]");
					_ = 0;
					object obj7 = this + 24;
					obj2 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S2_v14+8]");
					_ = 0;
					((int*)num2)->m_value = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					((int*)num)->m_value = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					_ = 0;
					((Matrix4x4*)matrix4x)->set_Item(num2, num, _003Cfactor_003E5__3);
					((int*)num)->m_value = (int)matrix4x.m00;
					_ = matrix4x.m20;
					widget.rawPivot = (UIWidget.Pivot)num;
					object obj8 = this + 12;
					obj8 = 0;
					_003C_003E1__state = 1;
					return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CAnimateColor_003Ed__184(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Material material;

		public float duration;

		public Color toColor;

		private Color _003CfromColor_003E5__2;

		private float _003Cfactor_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0203: Unknown result type (might be due to invalid IL or missing references)
				//IL_0208: Expected I4, but got Unknown
				//IL_0211: Unknown result type (might be due to invalid IL or missing references)
				//IL_0216: Expected Obj, but got Unknown
				//IL_021f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0224: Expected Obj, but got Unknown
				//IL_022d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Expected Obj, but got Unknown
				//IL_0048: Expected VT, but got Obj
				//IL_0055: Expected I4, but got Obj
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Expected Obj, but got Unknown
				//IL_0077: Expected Obj, but got I4
				//IL_011b: Expected I, but got Obj
				//IL_0131: Expected Obj, but got I
				//IL_015c: Expected I, but got Obj
				//IL_0290: Unknown result type (might be due to invalid IL or missing references)
				//IL_0295: Expected Obj, but got Unknown
				//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b5: Expected Obj, but got Unknown
				//IL_02f4: Expected I4, but got Obj
				//IL_0318: Expected I4, but got Obj
				//IL_0318: Expected Ref, but got VT
				//IL_032a: Expected I4, but got F4
				//IL_0348: Expected VT, but got I4
				//IL_034e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0353: Expected Obj, but got Unknown
				//IL_035c: Expected Obj, but got I4
				//IL_0370: Expected Obj, but got I4
				Matrix4x4 matrix4x = default;
				int num = matrix4x - -64;
				Material material = (Material)(matrix4x + 48);
				object obj = matrix4x + 32;
				object obj2 = matrix4x + 16;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					material.SetTextureOffset((string)(object)this.material, (Vector2)"_MainColor");
					((int*)num)->m_value = (int)material;
					_ = ((UnityEngine.Object)material).m_CachedPtr;
					object obj3 = this + 40;
					obj3 = ((int*)num)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
					_ = 0;
					_003Cfactor_003E5__3 = 0f;
				}
				if (_003Cfactor_003E5__3 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime / duration;
					float num3 = _003Cfactor_003E5__3 + num2;
					_003Cfactor_003E5__3 = num3;
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num5 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v39 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num6;
					if (_003Cfactor_003E5__3 < 0f)
					{
						num6 = 0f;
					}
					else
					{
						num6 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
					}
					_003Cfactor_003E5__3 = num6;
					object obj5 = this + 40;
					obj = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S2_v9+8]");
					_ = 0;
					object obj6 = this + 24;
					obj2 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S2_v14+8]");
					_ = 0;
					material = (Material)obj;
					Material material2 = material;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((UnityEngine.Object)material2).m_CachedPtr = (IntPtr)0;
					((int*)num)->m_value = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					_ = 0;
					((Matrix4x4*)matrix4x)->set_Item((int)material, num, _003Cfactor_003E5__3);
					((int*)num)->m_value = (int)matrix4x.m00;
					_ = matrix4x.m20;
					this.material.SetVector("_MainColor", (Vector4)num);
					object obj7 = this + 12;
					obj7 = 0;
					_003C_003E1__state = 1;
					return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CAnimateEffectColor_003Ed__186(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public bool instant;

		public UISprite spriteToAnimate;

		public Color color2;

		public CelebrationPopup _003C_003E4__this;

		public float speedFactor;

		public Color color1;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected I4, but got Unknown
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected I4, but got Unknown
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Expected Obj, but got Unknown
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Expected Obj, but got Unknown
				//IL_00c1: Expected I4, but got Obj
				//IL_0191: Unknown result type (might be due to invalid IL or missing references)
				//IL_0196: Expected Obj, but got Unknown
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Expected Obj, but got Unknown
				//IL_01d8: Expected I4, but got Obj
				//IL_01f2: Expected I4, but got Obj
				//IL_0219: Expected Ref, but got VT
				//IL_0230: Expected I4, but got F4
				//IL_024f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0254: Expected Obj, but got Unknown
				//IL_025d: Expected Obj, but got I4
				//IL_0271: Expected Obj, but got I4
				Matrix4x4 matrix4x = default;
				UIWidget.Pivot pivot = (UIWidget.Pivot)(matrix4x - -64);
				int num = matrix4x + 48;
				object obj = matrix4x + 32;
				object obj2 = matrix4x + 16;
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (~(instant ? 1u : 0u) == 0)
					{
						object obj3 = this + 24;
						((int*)num)->m_value = (int)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v30+8]");
						_ = 0;
						((UIWidget.Pivot*)(int)pivot)->value__ = ((int*)num)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (System.Int32)+8]");
						_ = 0;
						spriteToAnimate.rawPivot = pivot;
						return null;
					}
					celebrationPopup._animationLerpFactor = 0f;
				}
				if (celebrationPopup._animationLerpFactor < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime * speedFactor;
					float animationLerpFactor = celebrationPopup._animationLerpFactor + num2;
					celebrationPopup._animationLerpFactor = animationLerpFactor;
					object obj4 = this + 48;
					obj = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S2_v6+8]");
					_ = 0;
					object obj5 = this + 24;
					obj2 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S2_v11+8]");
					_ = 0;
					((int*)num)->m_value = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
					_ = 0;
					((Matrix4x4*)matrix4x)->set_Item(num, (int)pivot, celebrationPopup._animationLerpFactor);
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)matrix4x.m00;
					_ = matrix4x.m20;
					spriteToAnimate.rawPivot = pivot;
					object obj6 = this + 12;
					obj6 = 0;
					_003C_003E1__state = 1;
					return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CMoveGameObject_003Ed__187(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public float duration;

		public Vector3 toPos;

		private Vector3 _003CfromPos_003E5__2;

		private float _003Cfactor_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0422: Unknown result type (might be due to invalid IL or missing references)
				//IL_0427: Expected Obj, but got Unknown
				//IL_0430: Unknown result type (might be due to invalid IL or missing references)
				//IL_0435: Expected Obj, but got Unknown
				//IL_043e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0443: Expected Obj, but got Unknown
				//IL_044c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0451: Expected Obj, but got Unknown
				//IL_045a: Unknown result type (might be due to invalid IL or missing references)
				//IL_045f: Expected Obj, but got Unknown
				//IL_0468: Unknown result type (might be due to invalid IL or missing references)
				//IL_046d: Expected Obj, but got Unknown
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_0083: Expected I, but got Obj
				//IL_00d1: Expected VT, but got Obj
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Expected Obj, but got Unknown
				//IL_04cc: Expected I, but got Obj
				//IL_04e2: Expected Obj, but got I
				//IL_0174: Expected I, but got Obj
				//IL_018a: Expected Obj, but got I
				//IL_0400: Unknown result type (might be due to invalid IL or missing references)
				//IL_0405: Expected Obj, but got Unknown
				//IL_0367: Expected I, but got Obj
				//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b1: Expected Obj, but got Unknown
				//IL_01b5: Expected I, but got Obj
				//IL_0237: Expected I, but got Obj
				//IL_024d: Expected Obj, but got I
				//IL_0278: Expected I, but got Obj
				//IL_0566: Unknown result type (might be due to invalid IL or missing references)
				//IL_056b: Expected Obj, but got Unknown
				//IL_0586: Unknown result type (might be due to invalid IL or missing references)
				//IL_058b: Expected Obj, but got Unknown
				//IL_05da: Expected I, but got Obj
				//IL_05f0: Expected Obj, but got I
				//IL_06a2: Expected VT, but got Obj
				//IL_06a2: Expected VT, but got Obj
				//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_06db: Expected Obj, but got Unknown
				//IL_06e4: Expected Obj, but got I4
				//IL_06f8: Expected Obj, but got I4
				//IL_031a: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 72);
				Transform transform2 = (Transform)(obj + 60);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
				object obj4 = obj + 48;
				object obj5 = obj + 36;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v89 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v106 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)trans).FindKernel((string)null) == 0)
					{
						return null;
					}
					transform2.localPosition = (Vector3)trans;
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					object obj7 = this + 36;
					obj7 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					_003Cfactor_003E5__3 = 0f;
				}
				if (_003Cfactor_003E5__3 < 1f)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v83 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)trans).FindKernel((string)null) != 0)
					{
						float unscaledTime = Time.unscaledTime;
						float num5 = unscaledTime / duration;
						float num6 = _003Cfactor_003E5__3 + num5;
						_003Cfactor_003E5__3 = num6;
						nint num7 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v44 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num8 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v55 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num9;
						if (_003Cfactor_003E5__3 < 0f)
						{
							num9 = 0f;
						}
						else
						{
							num9 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
						}
						_003Cfactor_003E5__3 = num9;
						object obj10 = this + 36;
						obj2 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S2_v25+8]");
						_ = 0;
						object obj11 = this + 24;
						obj3 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S2_v30+8]");
						_ = 0;
						float num10 = _003Cfactor_003E5__3 - 0.5f;
						float num11 = num10 * (float)Math.PI;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
						nint num12 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S1_v55 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num13 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v74 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj4 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						_ = 0;
						obj5 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						_ = 0;
						transform2 = (Transform)obj4;
						Transform transform3 = transform2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
						transform = (Transform)obj5;
						Transform transform4 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						object obj13 = default;
						float num14 = (float)obj13 + 1f;
						float t = 0.5f * num14;
						Vector3 vector = Vector3.LerpUnclamped((Vector3)transform2, (Vector3)transform, t);
						transform = (Transform)obj;
						Transform transform5 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
						Vector3 eulerAngles = transform.eulerAngles;
						object obj14 = this + 12;
						obj14 = 0;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num16 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)trans).FindKernel((string)null) != 0)
				{
					object obj16 = this + 24;
					transform2 = (Transform)obj16;
					Transform transform6 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S2_v8+8]");
					((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					Vector3 eulerAngles2 = transform.eulerAngles;
				}
				object obj17 = this + 36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CScaleGameObject_003Ed__188(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public float duration;

		public Vector3 toScale;

		private float _003Cfactor_003E5__2;

		private Vector3 _003CfromScale_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_036c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0371: Expected VT, but got Unknown
				//IL_037a: Unknown result type (might be due to invalid IL or missing references)
				//IL_037f: Expected Obj, but got Unknown
				//IL_0388: Unknown result type (might be due to invalid IL or missing references)
				//IL_038d: Expected Obj, but got Unknown
				//IL_0396: Unknown result type (might be due to invalid IL or missing references)
				//IL_039b: Expected Obj, but got Unknown
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_0083: Expected I, but got Obj
				//IL_00dc: Expected VT, but got Obj
				//IL_00e9: Expected F4, but got Obj
				//IL_00e4: Expected native int or pointer, but got VT
				//IL_00fb: Expected F4, but got I
				//IL_00f6: Expected native int or pointer, but got VT
				//IL_0101: Unknown result type (might be due to invalid IL or missing references)
				//IL_0106: Expected Obj, but got Unknown
				//IL_0113: Expected Obj, but got F4
				//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f7: Expected Obj, but got Unknown
				//IL_017e: Expected I, but got Obj
				//IL_0194: Expected Obj, but got I
				//IL_01bf: Expected I, but got Obj
				//IL_0241: Expected I, but got Obj
				//IL_0257: Expected Obj, but got I
				//IL_0282: Expected I, but got Obj
				//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ba: Expected Obj, but got Unknown
				//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_04da: Expected Obj, but got Unknown
				//IL_04fd: Expected I, but got Obj
				//IL_0513: Expected Obj, but got I
				//IL_055a: Expected F4, but got Obj
				//IL_0555: Expected native int or pointer, but got VT
				//IL_056f: Expected F4, but got I
				//IL_056a: Expected native int or pointer, but got VT
				//IL_0580: Expected VT, but got Obj
				//IL_0591: Expected F4, but got Obj
				//IL_058c: Expected native int or pointer, but got VT
				//IL_05a6: Expected F4, but got I
				//IL_05a1: Expected native int or pointer, but got VT
				//IL_05b5: Expected Obj, but got VT
				//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_05c0: Expected Obj, but got Unknown
				//IL_05c9: Expected Obj, but got I4
				//IL_05dd: Expected Obj, but got I4
				//IL_0324: Expected I, but got Obj
				object obj = default;
				Vector3 vector = (Vector3)(obj + 48);
				Transform transform = (Transform)(obj + 36);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v82 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)trans).FindKernel((string)null) == 0)
					{
						return null;
					}
					_003Cfactor_003E5__2 = 0f;
					transform.localScale = (Vector3)trans;
					((Vector3*)(nint)vector)->x = (float)transform;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
					object obj5 = this + 40;
					obj5 = vector.x;
					_ = vector.z;
				}
				if (_003Cfactor_003E5__2 < 1f)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)trans).FindKernel((string)null) != 0)
					{
						float unscaledTime = Time.unscaledTime;
						float num5 = unscaledTime / duration;
						float num6 = _003Cfactor_003E5__2 + num5;
						_003Cfactor_003E5__2 = num6;
						nint num7 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v34 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num8 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v50 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num9;
						if (_003Cfactor_003E5__2 < 0f)
						{
							num9 = 0f;
						}
						else
						{
							num9 = ((!(_003Cfactor_003E5__2 > 1f)) ? _003Cfactor_003E5__2 : 1f);
						}
						_003Cfactor_003E5__2 = num9;
						float num10 = Mathf.LerpUnclamped((float)Math.PI, (float)Math.PI * 2f, _003Cfactor_003E5__2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
						object obj8 = default;
						float num11 = (float)obj8 * 0.5f;
						float t = num11 + 0.5f;
						object obj9 = this + 40;
						obj2 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S2_v14+8]");
						_ = 0;
						object obj10 = this + 24;
						obj3 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S2_v19+8]");
						_ = 0;
						nint num12 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v35 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num13 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v50 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						transform = (Transform)obj2;
						Transform transform2 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
						((Vector3*)(nint)vector)->x = (float)obj3;
						Vector3 vector2 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						((Vector3*)(nint)vector2)->z = 0f;
						Vector3 vector3 = Vector3.LerpUnclamped((Vector3)transform, vector, t);
						((Vector3*)(nint)vector)->x = (float)obj;
						Vector3 vector4 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector3*)(nint)vector4)->z = 0f;
						trans.parent = (Transform)vector;
						object obj12 = this + 12;
						obj12 = 0;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				object obj13 = this + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CAnimateStripes_003Ed__190(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		private int _003CminSpeed_003E5__2;

		private int _003CmaxSpeed_003E5__3;

		private float _003CminAlpha_003E5__4;

		private float _003CmaxAlpha_003E5__5;

		private float _003CminScale_003E5__6;

		private float _003CmaxScale_003E5__7;

		private Vector2 _003CminimumThreshold_003E5__8;

		private Vector2 _003CmaximumThreshold_003E5__9;

		private float[] _003CstripeSpeeds_003E5__10;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dab: Expected Obj, but got Unknown
				//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0db9: Expected VT, but got Unknown
				//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dc7: Expected Obj, but got Unknown
				//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dd5: Expected I, but got Unknown
				//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
				//IL_0de3: Expected Obj, but got Unknown
				//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
				//IL_0df1: Expected Obj, but got Unknown
				//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dff: Expected Obj, but got Unknown
				//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e0d: Expected Obj, but got Unknown
				//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e1b: Expected Obj, but got Unknown
				//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e29: Expected Obj, but got Unknown
				//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e37: Expected Obj, but got Unknown
				//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e45: Expected Obj, but got Unknown
				//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e53: Expected Obj, but got Unknown
				//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e61: Expected Obj, but got Unknown
				//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e6f: Expected Obj, but got Unknown
				//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e7d: Expected Obj, but got Unknown
				//IL_0e86: Expected Obj, but got I4
				//IL_0e95: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e9a: Expected Obj, but got Unknown
				//IL_0ea3: Expected Obj, but got I4
				//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0eb7: Expected Obj, but got Unknown
				//IL_0ec0: Expected Obj, but got I4
				//IL_006f: Expected I, but got Obj
				//IL_0085: Expected Obj, but got I
				//IL_0efd: Expected F4, but got VT
				//IL_0ef8: Expected native int or pointer, but got VT
				//IL_0f52: Expected Obj, but got I4
				//IL_0f5b: Expected Obj, but got F4
				//IL_0f69: Expected I, but got Obj
				//IL_0f71: Expected Obj, but got I
				//IL_0f7b: Expected VT, but got Obj
				//IL_0f84: Expected Obj, but got I4
				//IL_0f8d: Expected Obj, but got F4
				//IL_0fad: Expected VT, but got Obj
				//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fdd: Expected Obj, but got Unknown
				//IL_0ff5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ffa: Expected Obj, but got Unknown
				//IL_1015: Expected Obj, but got I4
				//IL_00b0: Expected I, but got Obj
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Expected Obj, but got Unknown
				//IL_010b: Expected Obj, but got I4
				//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_07fa: Expected Obj, but got Unknown
				//IL_0803: Expected Obj, but got I4
				//IL_0817: Expected Obj, but got I4
				//IL_0200: Unknown result type (might be due to invalid IL or missing references)
				//IL_0205: Expected Obj, but got Unknown
				//IL_0231: Expected Obj, but got I4
				//IL_0231: Expected Obj, but got I4
				//IL_023d: Expected Obj, but got I4
				//IL_024b: Expected I, but got Obj
				//IL_0261: Expected Obj, but got I
				//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d7b: Expected Obj, but got Unknown
				//IL_0d84: Expected Obj, but got I4
				//IL_0d98: Expected Obj, but got I4
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0123: Expected Obj, but got Unknown
				//IL_084e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0853: Expected Obj, but got Unknown
				//IL_0888: Expected VT, but got Obj
				//IL_028c: Expected I, but got Obj
				//IL_0175: Expected I, but got Obj
				//IL_018b: Expected Obj, but got I
				//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_08af: Expected Obj, but got Unknown
				//IL_08ef: Expected F4, but got Obj
				//IL_08ea: Expected native int or pointer, but got VT
				//IL_0904: Expected F4, but got I
				//IL_08ff: Expected native int or pointer, but got VT
				//IL_090a: Unknown result type (might be due to invalid IL or missing references)
				//IL_090f: Expected Obj, but got Unknown
				//IL_0924: Invalid comparison between F4 and I
				//IL_102c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1031: Expected Obj, but got Unknown
				//IL_124c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1251: Expected Obj, but got Unknown
				//IL_1286: Expected F4, but got Obj
				//IL_1281: Expected native int or pointer, but got VT
				//IL_129b: Expected F4, but got I
				//IL_1296: Expected native int or pointer, but got VT
				//IL_12de: Expected Obj, but got I4
				//IL_12f1: Expected Obj, but got F4
				//IL_134a: Unknown result type (might be due to invalid IL or missing references)
				//IL_134f: Expected Obj, but got Unknown
				//IL_01b6: Expected I, but got Obj
				//IL_0951: Unknown result type (might be due to invalid IL or missing references)
				//IL_0956: Expected Obj, but got Unknown
				//IL_095c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0961: Expected Obj, but got Unknown
				//IL_096e: Expected F4, but got Obj
				//IL_096e: Expected F4, but got Obj
				//IL_097a: Expected Obj, but got F4
				//IL_0985: Unknown result type (might be due to invalid IL or missing references)
				//IL_098a: Expected Obj, but got Unknown
				//IL_09b6: Expected Obj, but got I4
				//IL_09b6: Expected Obj, but got I4
				//IL_09c7: Expected Obj, but got I4
				//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_09d7: Expected Obj, but got Unknown
				//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a1d: Expected Obj, but got Unknown
				//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a48: Expected Obj, but got Unknown
				//IL_0a71: Expected I, but got Obj
				//IL_0a87: Expected Obj, but got I
				//IL_1396: Unknown result type (might be due to invalid IL or missing references)
				//IL_139b: Expected Obj, but got Unknown
				//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b04: Expected Obj, but got Unknown
				//IL_0b39: Expected VT, but got Obj
				//IL_0ab2: Expected I, but got Obj
				//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b63: Expected Obj, but got Unknown
				//IL_0bdb: Expected Obj, but got I4
				//IL_0bfa: Expected Obj, but got F4
				//IL_0c6d: Expected Obj, but got I4
				//IL_0c8c: Expected Obj, but got F4
				//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cc7: Expected Obj, but got Unknown
				//IL_0cf0: Expected I, but got Obj
				//IL_0d06: Expected Obj, but got I
				//IL_13d2: Expected F4, but got Obj
				//IL_13cd: Expected native int or pointer, but got VT
				//IL_13e7: Expected F4, but got I
				//IL_13e2: Expected native int or pointer, but got VT
				//IL_1426: Expected VT, but got Obj
				//IL_145a: Unknown result type (might be due to invalid IL or missing references)
				//IL_145f: Expected Obj, but got Unknown
				//IL_0d31: Expected I, but got Obj
				Transform transform2 = default;
				Transform transform = (Transform)(transform2 + 208);
				Vector3 vector = (Vector3)(transform2 + 196);
				Transform transform3 = (Transform)(transform2 + 16);
				nint num = (nint)(transform2 + 40);
				object obj = transform2 + 32;
				object obj2 = transform2 + 192;
				object obj3 = transform2 + 144;
				object obj4 = transform2 + 132;
				object obj5 = transform2 + 120;
				object obj6 = transform2 + 108;
				object obj7 = transform2 + 96;
				object obj8 = transform2 + 84;
				object obj9 = transform2 + 72;
				object obj10 = transform2 + 60;
				object obj11 = transform2 + 48;
				object obj12 = transform2 + 180;
				obj12 = 0;
				_ = 0;
				object obj13 = transform2 + 168;
				obj13 = 0;
				_ = 0;
				object obj14 = transform2 + 156;
				obj14 = 0;
				_ = 0;
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1 && _003C_003E1__state != 2)
					{
						return null;
					}
					_003C_003E1__state = -1;
					object obj15 = default;
					object obj54 = default;
					while (true)
					{
						UITexture[] stripeTextures = celebrationPopup._stripeTextures;
						if ((nint)obj15 >= stripeTextures.Length)
						{
							break;
						}
						object obj16 = celebrationPopup._stripeTextures + 16;
						object obj17 = obj15 << 2;
						object obj18 = obj16 + obj17;
						Camera anchorCamera = ((UIRect)obj18).anchorCamera;
						transform.localPosition = (Vector3)anchorCamera;
						obj13 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						object obj19 = _003CstripeSpeeds_003E5__10 + 16;
						object obj20 = obj15 << 2;
						object obj21 = obj19 + obj20;
						float unscaledTime = Time.unscaledTime;
						float num2 = (float)obj21 * unscaledTime;
						((Vector3*)(nint)vector)->x = (float)obj13;
						Vector3 vector2 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v42+8]");
						((Vector3*)(nint)vector2)->z = 0f;
						object obj22 = this + 52;
						float y = vector.y;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v270+4]");
						bool flag = y > 0f;
						bool flag2 = !flag;
						float num3 = num2;
						if (!flag2)
						{
							object obj23 = this + 44;
							object obj24 = this + 52;
							float num4 = NumberExtensions.MRound((float)obj23, (float)obj24);
							obj13 = num4;
							object obj25 = _003CstripeSpeeds_003E5__10 + 16;
							object obj26 = obj15 << 2;
							object obj27 = obj25 + obj26;
							bool boolean = ((ObfuscatedMemory)_003CminSpeed_003E5__2).GetBoolean((string)_003CmaxSpeed_003E5__3);
							obj27 = boolean;
							object obj28 = _003CstripeSpeeds_003E5__10 + 16;
							object obj29 = obj15 << 2;
							object obj30 = obj28 + obj29;
							float unscaledTime2 = Time.unscaledTime;
							float num5 = (float)obj30 * unscaledTime2;
							object obj31 = celebrationPopup._stripeTextures + 16;
							object obj32 = obj15 << 2;
							object obj33 = obj31 + obj32;
							object obj34 = _003CstripeSpeeds_003E5__10 + 16;
							object obj35 = obj15 << 2;
							object obj36 = obj34 + obj35;
							nint num6 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v257 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj37 = (nint)0 & (nint)0x200;
							if (obj37 != null)
							{
								nint num7 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v273 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float t = (float)obj36 / (float)_003CmaxSpeed_003E5__3;
							float num8 = Mathf.LerpUnclamped(_003CminAlpha_003E5__4, _003CmaxAlpha_003E5__5, t);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
							object obj38 = celebrationPopup._stripeTextures + 16;
							object obj39 = obj15 << 2;
							object obj40 = obj38 + obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
							object obj41 = celebrationPopup._stripeTextures + 16;
							object obj42 = obj15 << 2;
							object obj43 = obj41 + obj42;
							Camera anchorCamera2 = ((UIRect)obj43).anchorCamera;
							transform3.localScale = (Vector3)anchorCamera2;
							obj14 = transform3;
							_ = ((UnityEngine.Object)transform3).m_CachedPtr;
							object obj44 = celebrationPopup._stripeTextures + 16;
							object obj45 = obj15 << 2;
							object obj46 = obj44 + obj45;
							Camera anchorCamera3 = ((UIRect)obj46).anchorCamera;
							transform2 = (Transform)obj14;
							Transform transform4 = transform2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v45+8]");
							((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
							obj3 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v45+8]");
							_ = 0;
							obj4 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v45+8]");
							_ = 0;
							obj5 = 0;
							_ = 0;
							float num9 = (float)transform2 * _003CminScale_003E5__6;
							obj5 = num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+4]");
							float num10 = 0f * _003CminScale_003E5__6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
							_ = 0;
							obj6 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v45+8]");
							_ = 0;
							obj7 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v45+8]");
							_ = 0;
							obj8 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v45+8]");
							_ = 0;
							obj9 = 0;
							_ = 0;
							float num11 = (float)obj6 * _003CmaxScale_003E5__7;
							obj9 = num11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+4]");
							float num12 = 0f * _003CmaxScale_003E5__7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
							_ = 0;
							object obj47 = _003CstripeSpeeds_003E5__10 + 16;
							object obj48 = obj15 << 2;
							object obj49 = obj47 + obj48;
							nint num13 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ S1_v390 (Il2CppClass<UnityEngine.Vector3>)+BA]");
							object obj50 = (nint)0 & (nint)0x200;
							if (obj50 != null)
							{
								nint num14 = (nint)typeof(Vector3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ S1_v406 (Il2CppClass<UnityEngine.Vector3>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							((Vector3*)(nint)vector)->x = (float)obj5;
							Vector3 vector3 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
							((Vector3*)(nint)vector3)->z = 0f;
							transform = (Transform)obj9;
							Transform transform5 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
							((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
							float t2 = (float)obj49 / (float)_003CmaxSpeed_003E5__3;
							Vector3 vector4 = Vector3.LerpUnclamped(vector, (Vector3)transform, t2);
							transform = (Transform)obj10;
							Transform transform6 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
							((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
							((Transform)(object)anchorCamera3).parent = transform;
							object obj51 = this + 44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ S1_v403+4]");
							float num15 = 0f - num5;
							num3 = num5;
						}
						object obj52 = celebrationPopup._stripeTextures + 16;
						object obj53 = obj54 << 2;
						object obj55 = obj52 + obj53;
						Camera anchorCamera4 = ((UIRect)obj55).anchorCamera;
						((Vector3*)(nint)vector)->x = (float)obj13;
						Vector3 vector5 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v42+8]");
						((Vector3*)(nint)vector5)->z = 0f;
						transform3 = (Transform)obj13;
						Transform transform7 = transform3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v42+8]");
						((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
						transform2 = (Transform)obj13;
						Transform transform8 = transform2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v42+8]");
						((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
						obj3 = 0;
						_ = 0;
						obj3 = vector.x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Transform)+4]");
						float num16 = 0f + num3;
						_ = ((UnityEngine.Object)transform2).m_CachedPtr;
						transform = (Transform)obj3;
						Transform transform9 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
						((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
						Vector3 eulerAngles = transform.eulerAngles;
						obj15 = obj54 + 1;
					}
					object obj56 = this + 12;
					obj56 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				celebrationPopup._stripeCoroutineRunning = true;
				nint num17 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v55 (Il2CppClass<GlobalColorsGenerated>)+BA]");
				object obj57 = (nint)0 & (nint)0x200;
				if (obj57 != null)
				{
					nint num18 = (nint)typeof(GlobalColorsGenerated);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v192 (Il2CppClass<GlobalColorsGenerated>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)GlobalColorsGenerated.WEEKLYHUNT_CELEBRATION_STRIPE_COLOR;
				_003CminSpeed_003E5__2 = 600;
				_003CmaxSpeed_003E5__3 = 2000;
				_003CminAlpha_003E5__4 = 0.3f;
				_003CmaxAlpha_003E5__5 = 0.9f;
				_003CminScale_003E5__6 = 0.5f;
				_003CmaxScale_003E5__7 = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				transform3 = (Transform)0;
				transform3 = (Transform)(-150f);
				_ = -225f;
				num = (nint)transform3;
				transform = (Transform)num;
				_003CminimumThreshold_003E5__8 = (Vector2)transform;
				transform2 = (Transform)0;
				transform2 = (Transform)150f;
				_ = 700f;
				obj = transform2;
				transform = (Transform)obj;
				_003CmaximumThreshold_003E5__9 = (Vector2)transform;
				if (celebrationPopup._stripeTextures != null)
				{
					object obj58 = celebrationPopup._stripeTextures + 12;
					object obj59 = 0;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj59) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58))
					{
						object obj60 = celebrationPopup._stripeTextures + 16;
						object obj61 = obj59 << 2;
						object obj62 = obj60 + obj61;
						string tag = ((Component)obj62).tag;
						((GameObject)(object)tag).tag = null;
						string tag2 = ((Component)obj62).tag;
						nint num19 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S1_v232 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj63 = (nint)0 & (nint)0x200;
						if (obj63 != null)
						{
							nint num20 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S1_v238 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag2);
						object obj64 = obj59 + 1;
						obj59 = obj64;
					}
				}
				object obj65 = celebrationPopup + 816;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj66 = default;
				obj65 = obj66;
				object obj67 = this + 60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj68 = default;
				obj67 = obj68;
				object obj69 = 0;
				if ((nint)obj69 <= 11)
				{
					object obj70 = _003CstripeSpeeds_003E5__10 + 16;
					object obj71 = obj69 << 2;
					object obj72 = obj70 + obj71;
					bool boolean2 = ((ObfuscatedMemory)_003CminSpeed_003E5__2).GetBoolean((string)_003CmaxSpeed_003E5__3);
					obj72 = boolean2;
					nint num21 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S0_v105 (Il2CppClass<NGUITools>)+BA]");
					object obj73 = (nint)0 & (nint)0x200;
					if (obj73 != null)
					{
						nint num22 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ S0_v172 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NullReferenceException ex = new NullReferenceException();
					throw new ArrayTypeMismatchException();
				}
				object obj74 = this + 12;
				obj74 = 0;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CInitial_Generic_DoubleUp_Routine_003Ed__217(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationPopupLabelTemplate template;

		public CelebrationReward reward;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_05da: Unknown result type (might be due to invalid IL or missing references)
				//IL_05df: Expected VT, but got Unknown
				//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05ed: Expected Obj, but got Unknown
				//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_05fb: Expected Obj, but got Unknown
				//IL_0604: Unknown result type (might be due to invalid IL or missing references)
				//IL_0609: Expected Obj, but got Unknown
				//IL_0612: Unknown result type (might be due to invalid IL or missing references)
				//IL_0617: Expected Obj, but got Unknown
				//IL_0620: Unknown result type (might be due to invalid IL or missing references)
				//IL_0625: Expected Obj, but got Unknown
				//IL_062e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0633: Expected Obj, but got Unknown
				//IL_005e: Expected Obj, but got VT
				//IL_0073: Expected F4, but got Obj
				//IL_006e: Expected native int or pointer, but got VT
				//IL_008d: Expected F4, but got Obj
				//IL_0088: Expected native int or pointer, but got VT
				//IL_00a2: Expected F4, but got I
				//IL_009d: Expected native int or pointer, but got VT
				//IL_00b4: Expected I4, but got VT
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Expected Obj, but got Unknown
				//IL_010c: Expected F4, but got Obj
				//IL_0107: Expected native int or pointer, but got VT
				//IL_0121: Expected F4, but got I
				//IL_011c: Expected native int or pointer, but got VT
				//IL_0127: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Expected Obj, but got Unknown
				//IL_0168: Expected Obj, but got I4
				//IL_01a8: Expected I, but got Obj
				//IL_01be: Expected Obj, but got I
				//IL_0681: Expected I4, but got Obj
				//IL_0692: Expected I4, but got Obj
				//IL_0243: Expected VT, but got I4
				//IL_01e9: Expected I, but got Obj
				//IL_025a: Expected I, but got Obj
				//IL_0270: Expected Obj, but got I
				//IL_029b: Expected I, but got Obj
				//IL_03a2: Expected F4, but got Obj
				//IL_039d: Expected native int or pointer, but got VT
				//IL_03b7: Expected F4, but got I
				//IL_03b2: Expected native int or pointer, but got VT
				//IL_02e8: Expected I, but got Obj
				//IL_02fe: Expected Obj, but got I
				//IL_0404: Expected Obj, but got I4
				//IL_0413: Expected Obj, but got F4
				//IL_042c: Expected F4, but got Obj
				//IL_0427: Expected native int or pointer, but got VT
				//IL_0441: Expected F4, but got I
				//IL_043c: Expected native int or pointer, but got VT
				//IL_0454: Expected Obj, but got I4
				//IL_0329: Expected I, but got Obj
				//IL_047c: Expected I, but got Obj
				//IL_0492: Expected Obj, but got I
				//IL_051d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0522: Expected Obj, but got Unknown
				//IL_0544: Expected Obj, but got VT
				//IL_0559: Expected F4, but got Obj
				//IL_0554: Expected native int or pointer, but got VT
				//IL_0588: Expected F4, but got Obj
				//IL_0583: Expected native int or pointer, but got VT
				//IL_059d: Expected F4, but got I
				//IL_0598: Expected native int or pointer, but got VT
				//IL_04bd: Expected I, but got Obj
				object obj = default;
				Matrix4x4 matrix4x = (Matrix4x4)(obj + 88);
				object obj2 = obj + 72;
				object obj3 = obj + 48;
				object obj4 = obj + 32;
				object obj5 = obj + 68;
				object obj6 = obj + 16;
				object obj7 = obj - -64;
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						celebrationPopup.continueButtonCollider.isTrigger = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
						nint num = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v46 (Il2CppClass<Strings>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num2 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v121 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text = Strings.GetDefault("CELEBRATION_POPUP_CONTINUE");
						celebrationPopup._tapToStartLabel.fontSize = (int)text;
						((CharacterSelectButton)(object)template).SetButtonState((CharacterSelectButton.ButtonStates)reward);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						Vector3 vector = ((CharacterNameEventPopup)(object)reward).VerifySettingOnline((string)null, (Vector3)1);
						nint num3 = (nint)typeof(CelebrationPopup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v57 (Il2CppClass<UI.Screens.CelebrationPopup>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num4 = (nint)typeof(CelebrationPopup);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v121 (Il2CppClass<UI.Screens.CelebrationPopup>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (CelebrationPopup.m_OnRewardDoubleUp != null)
						{
							nint num5 = (nint)typeof(CelebrationPopup);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v108 (Il2CppClass<UI.Screens.CelebrationPopup>)+BA]");
							object obj10 = (nint)0 & (nint)0x200;
							if (obj10 != null)
							{
								nint num6 = (nint)typeof(CelebrationPopup);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v115 (Il2CppClass<UI.Screens.CelebrationPopup>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							CelebrationPopup.m_OnRewardDoubleUp(reward);
						}
						MeshRenderer component = celebrationPopup.GlowEffect.GetComponent<MeshRenderer>();
						Material sharedMaterial = component.sharedMaterial;
						Color black = Color.black;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						IEnumerator routine = ((CelebrationPopup)null).MoveGameObject((Transform)(object)sharedMaterial, 1.5f, (Vector3)matrix4x);
						Coroutine coroutine = celebrationPopup.StartCoroutine_Auto(routine);
						int layer = celebrationPopup.GlowEffect.layer;
						obj3 = 0;
						_ = 0;
						obj3 = 0f;
						_ = 0f;
						_ = -270000f;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						IEnumerator routine2 = ((CelebrationPopup)null).AnimateColor((UIWidget)layer, 3000f, (Color)matrix4x);
						Coroutine coroutine2 = celebrationPopup.StartCoroutine_Auto(routine2);
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S1_v84 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num8 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S1_v114 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)celebrationPopup._superMysteryBoxEffect).FindKernel((string)null) != 0)
						{
							celebrationPopup._superMysteryBoxEffect.StopEffect();
						}
						object obj12 = celebrationPopup._flashEffectSprite + 80;
						obj3 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v92+8]");
						_ = 0;
						obj4 = celebrationPopup.EFFECT_INITIAL_COLOR;
						obj7 = obj4;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
						Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
						obj2 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						_ = 0;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC2");
						IEnumerator routine3 = default;
						Coroutine coroutine3 = celebrationPopup.StartCoroutine_Auto(routine3);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				celebrationPopup._weeklyHuntTopTitle.tag = null;
				celebrationPopup.HidePrizeButtons();
				obj3 = celebrationPopup.EFFECT_INITIAL_COLOR;
				obj5 = obj3;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
				Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				celebrationPopup._flashEffectSprite.rawPivot = (UIWidget.Pivot)matrix4x;
				object obj13 = celebrationPopup._flashEffectSprite + 80;
				obj6 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v24+8]");
				_ = 0;
				Color black2 = Color.black;
				obj2 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				object obj14 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EC2");
				IEnumerator routine4 = default;
				Coroutine coroutine4 = celebrationPopup.StartCoroutine_Auto(routine4);
				obj14 = coroutine4;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDoubleCoins_Routine_003Ed__218(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationReward reward;

		public CelebrationPopupLabelTemplate template;

		private int _003CcoinboxCountFromAmount_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Expected Obj, but got Unknown
				//IL_0103: Expected Obj, but got I4
				//IL_035c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0361: Expected Obj, but got Unknown
				//IL_023e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0243: Expected Obj, but got Unknown
				//IL_026e: Expected I4, but got Obj
				//IL_0228: Expected Obj, but got I4
				//IL_02a6: Expected Obj, but got I4
				//IL_02d9: Expected F4, but got I
				//IL_02d9: Expected Obj, but got I
				//IL_030b: Expected Obj, but got I
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (UI.Screens.CelebrationPopup)+134]");
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (UI.Screens.CelebrationPopup)+2EC]");
								IEnumerator routine = ((CelebrationPopup)null).AnimateAlpha((CelebrationPopupLabelTemplate)num, 0.5f, 0f);
								Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto(routine);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (UI.Screens.CelebrationPopup)+68]");
								((Collider)0).isTrigger = true;
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						object obj = this + 12;
						CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = template;
						string tag = celebrationPopupLabelTemplate.doubleUpItemLabel.tag;
						string buttonName = ((ChallengesScreen)(object)_003C_003E4__this).GetButtonName((ChallengesScreen.PageIndex)tag);
						Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)buttonName);
						obj = coroutine2;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					CelebrationReward celebrationReward = reward;
					int num2 = celebrationReward.amount << 1;
					CelebrationReward celebrationReward2 = reward;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EBE");
					CelebrationReward celebrationReward3 = reward;
					bool flag;
					if (celebrationReward3.CelebrationRewardOrigin != CelebrationRewardOrigin.SuperMysteryBox)
					{
						CelebrationReward celebrationReward4 = reward;
						if (celebrationReward4.CelebrationRewardOrigin != CelebrationRewardOrigin.WeeklyChallengeSuperMysteryBox)
						{
							CelebrationReward celebrationReward5 = reward;
							if (celebrationReward5.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterEventSuperMysteryBox)
							{
								flag = false;
								goto IL_0324;
							}
						}
					}
					CelebrationReward celebrationReward6 = reward;
					flag = celebrationReward6.amount > 300000;
					goto IL_0324;
				}
				_003C_003E1__state = -1;
				int unrewardedCoins = InventorySave.unrewardedCoins;
				_003CcoinboxCountFromAmount_003E5__2 = unrewardedCoins;
				object obj2 = this + 12;
				IEnumerator routine2 = _003C_003E4__this.DoubleCoins_Routine(reward, template);
				Coroutine coroutine3 = _003C_003E4__this.StartCoroutine_Auto(routine2);
				obj2 = coroutine3;
				_003C_003E1__state = 1;
				return 1;
				IL_0324:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (UI.Screens.CelebrationPopup)+368]");
				float amount = default;
				IEnumerator routine3 = ((CharacterNameEventPopup)null).AnimateScrollBar((CharacterNameEventPopup.HorizontalScrollDirections)0, amount, 0.7f);
				Coroutine coroutine4 = _003C_003E4__this.StartCoroutine_Auto(routine3);
				object obj3 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7EBD");
				IEnumerator routine4 = default;
				Coroutine coroutine5 = _003C_003E4__this.StartCoroutine_Auto(routine4);
				obj3 = coroutine5;
				_003C_003E1__state = 2;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDoubleKeys_Routine_003Ed__220(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationReward reward;

		public CelebrationPopupLabelTemplate template;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_00ad: Expected Obj, but got I4
				//IL_00cb: Expected I, but got Obj
				//IL_00e1: Expected Obj, but got I
				//IL_0237: Expected Obj, but got I
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Expected Obj, but got Unknown
				//IL_0271: Expected I4, but got Obj
				//IL_017a: Expected Obj, but got I4
				//IL_010c: Expected I, but got Obj
				//IL_01ad: Expected F4, but got I
				//IL_01ad: Expected Obj, but got I
				//IL_01df: Expected Obj, but got I
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+134]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+2EC]");
							IEnumerator routine = ((CelebrationPopup)null).AnimateAlpha((CelebrationPopupLabelTemplate)num, 0.5f, 0f);
							Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto(routine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+68]");
							((Collider)0).isTrigger = true;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					nint num2 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10 (Il2CppClass<NGUITools>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num3 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v19 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+368]");
					Vector3[] sides = NGUITools.GetSides((Camera)0, 0.7f);
					object obj2 = this + 12;
					CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = template;
					string tag = celebrationPopupLabelTemplate.doubleUpItemLabel.tag;
					string buttonName = ((ChallengesScreen)(object)_003C_003E4__this).GetButtonName((ChallengesScreen.PageIndex)tag);
					Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)buttonName);
					obj2 = coroutine2;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 12;
				IEnumerator routine2 = _003C_003E4__this.DoubleCoins_Routine(reward, template);
				Coroutine coroutine3 = _003C_003E4__this.StartCoroutine_Auto(routine2);
				obj3 = coroutine3;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDoubleTokens_Routine_003Ed__222(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationReward reward;

		public CelebrationPopupLabelTemplate template;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_00ad: Expected Obj, but got I4
				//IL_00ec: Expected Obj, but got I4
				//IL_00ec: Expected Obj, but got I4
				//IL_00ec: Expected Obj, but got I4
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fc: Expected Obj, but got Unknown
				//IL_0127: Expected I4, but got Obj
				//IL_015f: Expected Obj, but got I4
				//IL_017d: Expected I, but got Obj
				//IL_0193: Expected Obj, but got I
				//IL_026b: Expected Obj, but got I
				//IL_0292: Expected F4, but got I
				//IL_0292: Expected Obj, but got I
				//IL_0213: Expected Obj, but got I
				//IL_01be: Expected I, but got Obj
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							nint num = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v16 (Il2CppClass<NGUITools>)+BA]");
							object obj = (nint)0 & (nint)0x200;
							if (obj != null)
							{
								nint num2 = (nint)typeof(NGUITools);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v24 (Il2CppClass<NGUITools>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+368]");
							Vector3[] sides = NGUITools.GetSides((Camera)0, 0.7f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+134]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+2EC]");
							IEnumerator routine = ((CelebrationPopup)null).AnimateAlpha((CelebrationPopupLabelTemplate)num3, 0.5f, 0f);
							Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto(routine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+68]");
							((Collider)0).isTrigger = true;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					StayInOneLaneMission instance = StayInOneLaneMission.instance;
					CelebrationReward celebrationReward = reward;
					((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)20, (PersistentAwardProgress)celebrationReward.amount, (Action<Award>)(-1));
					object obj2 = this + 12;
					CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = template;
					string tag = celebrationPopupLabelTemplate.doubleUpItemLabel.tag;
					string buttonName = ((ChallengesScreen)(object)_003C_003E4__this).GetButtonName((ChallengesScreen.PageIndex)tag);
					Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)buttonName);
					obj2 = coroutine2;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 12;
				IEnumerator routine2 = _003C_003E4__this.DoubleCoins_Routine(reward, template);
				Coroutine coroutine3 = _003C_003E4__this.StartCoroutine_Auto(routine2);
				obj3 = coroutine3;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDoublePowerups_Routine_003Ed__224(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationReward reward;

		public CelebrationPopupLabelTemplate template;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_00ad: Expected Obj, but got I4
				//IL_00cb: Expected I, but got Obj
				//IL_00e1: Expected Obj, but got I
				//IL_0237: Expected Obj, but got I
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Expected Obj, but got Unknown
				//IL_0271: Expected I4, but got Obj
				//IL_017a: Expected Obj, but got I4
				//IL_010c: Expected I, but got Obj
				//IL_01ad: Expected F4, but got I
				//IL_01ad: Expected Obj, but got I
				//IL_01df: Expected Obj, but got I
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+134]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+2EC]");
							IEnumerator routine = ((CelebrationPopup)null).AnimateAlpha((CelebrationPopupLabelTemplate)num, 0.5f, 0f);
							Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto(routine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+68]");
							((Collider)0).isTrigger = true;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					nint num2 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10 (Il2CppClass<NGUITools>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num3 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v19 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.CelebrationPopup)+368]");
					Vector3[] sides = NGUITools.GetSides((Camera)0, 0.7f);
					object obj2 = this + 12;
					CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = template;
					string tag = celebrationPopupLabelTemplate.doubleUpItemLabel.tag;
					string buttonName = ((ChallengesScreen)(object)_003C_003E4__this).GetButtonName((ChallengesScreen.PageIndex)tag);
					Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)buttonName);
					obj2 = coroutine2;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 12;
				IEnumerator routine2 = _003C_003E4__this.DoubleCoins_Routine(reward, template);
				Coroutine coroutine3 = _003C_003E4__this.StartCoroutine_Auto(routine2);
				obj3 = coroutine3;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CTweenScaleUpDown_003Ed__225(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public GameObject go;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_032a: Unknown result type (might be due to invalid IL or missing references)
				//IL_032f: Expected VT, but got Unknown
				//IL_0338: Unknown result type (might be due to invalid IL or missing references)
				//IL_033d: Expected VT, but got Unknown
				//IL_0346: Unknown result type (might be due to invalid IL or missing references)
				//IL_034b: Expected Obj, but got Unknown
				//IL_0354: Unknown result type (might be due to invalid IL or missing references)
				//IL_0359: Expected Obj, but got Unknown
				//IL_0362: Unknown result type (might be due to invalid IL or missing references)
				//IL_0367: Expected Obj, but got Unknown
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected Obj, but got Unknown
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected Obj, but got Unknown
				//IL_008e: Expected I, but got Obj
				//IL_00a4: Expected Obj, but got I
				//IL_03a2: Expected Obj, but got I
				//IL_01ac: Expected VT, but got I4
				//IL_00cf: Expected I, but got Obj
				//IL_01be: Expected F4, but got Obj
				//IL_01b9: Expected native int or pointer, but got VT
				//IL_01d0: Expected F4, but got I
				//IL_01cb: Expected native int or pointer, but got VT
				//IL_01e6: Expected Obj, but got I
				//IL_01f3: Expected Obj, but got F4
				//IL_0219: Expected VT, but got Obj
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Expected Obj, but got Unknown
				//IL_0229: Unknown result type (might be due to invalid IL or missing references)
				//IL_022e: Expected Obj, but got Unknown
				//IL_0251: Expected I, but got Obj
				//IL_0267: Expected Obj, but got I
				//IL_0155: Expected Obj, but got I
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_016e: Expected Obj, but got Unknown
				//IL_018b: Expected Obj, but got I
				//IL_03cc: Expected F4, but got Obj
				//IL_03c7: Expected native int or pointer, but got VT
				//IL_03de: Expected F4, but got I
				//IL_03d9: Expected native int or pointer, but got VT
				//IL_03eb: Expected F4, but got Obj
				//IL_03e6: Expected native int or pointer, but got VT
				//IL_0400: Expected F4, but got I
				//IL_03fb: Expected native int or pointer, but got VT
				//IL_041e: Expected F4, but got Obj
				//IL_0419: Expected native int or pointer, but got VT
				//IL_0433: Expected F4, but got I
				//IL_042e: Expected native int or pointer, but got VT
				//IL_0449: Expected Obj, but got I
				//IL_0456: Expected Obj, but got F4
				//IL_0470: Expected Obj, but got I
				//IL_048d: Expected Obj, but got I
				//IL_04c1: Expected Obj, but got I
				//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d6: Expected Obj, but got Unknown
				//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e1: Expected Obj, but got Unknown
				//IL_02fd: Expected Obj, but got I4
				//IL_0292: Expected I, but got Obj
				object obj = default;
				Vector3 vector = (Vector3)(obj + 60);
				Vector3 vector2 = (Vector3)(obj + 48);
				Transform transform = (Transform)(obj + 36);
				Transform transform2 = (Transform)(obj + 24);
				object obj2 = obj + 12;
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj4 = default;
				object obj3 = obj4 + 12;
				obj3 = _003C_003E4__this;
				object obj5 = obj4 + 8;
				TweenScale component = go.GetComponent<TweenScale>();
				obj5 = component;
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v80 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v26+8]");
				if ((UnityEngine.Object)0 != null)
				{
					object obj7 = obj4 + 8;
					TweenScale tweenScale = go.AddComponent<TweenScale>();
					obj7 = tweenScale;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num3 = 0;
					EventDelegate eventDelegate = default;
					eventDelegate.mTarget = (MonoBehaviour)num3;
					eventDelegate.oneShot = false;
					object obj8 = eventDelegate + 16;
					obj8 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v26+8]");
					((UITweener)0).AddOnFinished(eventDelegate);
				}
				int layer = go.layer;
				transform.localScale = (Vector3)layer;
				((Vector3*)(nint)vector)->x = (float)transform;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v26+8]");
				object obj9 = (nint)0 + (nint)88;
				obj9 = vector.x;
				_ = vector.z;
				GameObject gameObject = _003C_003E4__this.gameObject;
				transform2.localScale = (Vector3)gameObject;
				object obj10 = _003C_003E4__this + 844;
				obj2 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S2_v17+8]");
				_ = 0;
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v37 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v65 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform2;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector3 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				Vector3 vector4 = Vector3.Cross(vector2, vector);
				((Vector3*)(nint)vector)->x = (float)obj;
				Vector3 vector5 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector5)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v26+8]");
				object obj12 = (nint)0 + (nint)100;
				obj12 = vector.x;
				_ = vector.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v26+8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UI.Screens.CelebrationPopup)+360]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v26+8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UI.Screens.CelebrationPopup)+358]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A709");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UI.Screens.CelebrationPopup)+360]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UI.Screens.CelebrationPopup)+364]");
				object obj15 = num6 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UI.Screens.CelebrationPopup)+360]");
				object obj16 = 0 + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj17 = this + 12;
				object obj18 = default;
				obj17 = obj18;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_003b: Expected Obj, but got I
			//IL_006c: Expected Obj, but got I4
			int num = _003C_003E1__state;
			object obj = _003C_003E2__current;
			object obj2 = _003C_003E2__current;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2 (System.Object)+360]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S2_v2 (System.Object)+364]");
			object obj3 = num2 * 0;
			int num3 = _003C_003E1__state;
			object obj4 = _003C_003E2__current;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v6 (System.Object)+35C]");
			_ = 0;
			((UITweener)_003C_003E1__state).ResetToBeginning();
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

	private sealed class _003CPlaySoundDelayed_003Ed__226(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public AudioClip clip;

		public float volume;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected Obj, but got Unknown
				//IL_006c: Expected Obj, but got I4
				//IL_008a: Expected I, but got Obj
				//IL_00a0: Expected Obj, but got I
				//IL_00cb: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v3 (Il2CppClass<NGUITools>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v8 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3[] sides = NGUITools.GetSides((Camera)(object)clip, volume);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj2 = this + 12;
				object obj3 = default;
				obj2 = obj3;
				_003C_003E1__state = 1;
				return 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	private const float MOVE_IN_NEXT_CELEBRATION_DURATION = 0.35f;

	private const float REMOVE_CELEBRATION_POPUP_AFTER_OPEN = 0.7f;

	private const float SHOW_PRIZE_BUTTON_POSITION = -46f;

	public GameObject boxParent;

	public GameObject rewardLabelTemplate;

	private Vector3 _outOfScreenPosition;

	private GameObject _prizeButtonNormal;

	private GameObject _prizeButtonSuper;

	private GameObject _prizeButtonMini;

	private UILabel _prizeButtonNormalLabel;

	private UILabel _prizeButtonSuperLabel;

	private UILabel _prizeButtonMiniLabel;

	private Layout _prizeButtonNormalLayout;

	private Layout _prizeButtonSuperLayout;

	private Layout _prizeButtonMiniLayout;

	private Collider openButtonCollider;

	private Collider skipButtonCollider;

	private Collider continueButtonCollider;

	private GameObject tapToStartLabelPrefab;

	private GameObject _coinbox;

	private UILabel _coinboxLabel;

	public UILabel newTrophyLabel;

	private static readonly Vector3 FIRST_SLOT_POSITION;

	private static readonly Vector3 OTHER_SLOT_OFFSET;

	private static readonly Vector3 SUPERBOX_EFFECT_POSITION;

	private GameObject[] _slots;

	private GameObject achievementBagPrefab;

	private GameObject mysteryEggPrefab;

	private GameObject mysteryBoxPrefab;

	private GameObject superMysteryBoxPrefab;

	private GameObject miniMysteryBoxPrefab;

	private GameObject hiddenPrizePrefab_blue;

	private GameObject hiddenPrizePrefab_green;

	private GameObject hiddenPrizePrefab_red;

	private GameObject superMysteryBoxEffectPrefab;

	private GameObject roundGlowEffectPrefab;

	public GameObject testRewardPrefab;

	public GameObject rewardCoins;

	public GameObject rewardCoinsJackpot;

	private GameObject rewardTokenTricky;

	private GameObject rewardTokenFresh;

	private GameObject rewardTokenSpike;

	private GameObject rewardTokenYutani;

	private GameObject trophyDiamond;

	private GameObject trophyGoldBar;

	private GameObject trophyChainClock;

	private GameObject trophyChainDollar;

	private GameObject trophyGoldSkull;

	private GameObject trophyHeadphones;

	private GameObject trophyLPBlack;

	private GameObject trophyTapeBlack;

	private GameObject rewardPowerupHoverboard;

	private GameObject rewardPowerupHeadstart500;

	private GameObject rewardPowerupHeadstart2000;

	private GameObject rewardPowerupScoreBooster;

	private GameObject rewardSpecialBoard;

	private GameObject rewardWelcomePackBoard;

	private GameObject rewardKey;

	private GameObject rewardBronzeCan;

	private GameObject rewardSilverCan;

	private GameObject rewardGoldCan;

	private GameObject rewardDiamondCan;

	private GameObject[] rewardsTopRun;

	private GameObject _weeklyHuntTopTitle;

	private UILabel _weeklyHuntTopTitleLabel;

	private Layout _weeklyHuntTopLayout;

	private GameObject fleshEffectPrefab;

	private GameObject preOpenLabel;

	private UILabel _bonusTextLabel;

	private GameObject _flashEffectGO;

	private UISprite _flashEffectSprite;

	private UILabel _tapToStartLabel;

	public AudioStateLoop audioStateLoop;

	private int _currentReward;

	public GameObject[] _celebrationRewardContainer;

	private bool _anotherReward;

	private Vector3 _boxScale;

	private Vector3 _boxRotation;

	private Vector3 _boxScaleAward;

	private Vector3 _boxRotationAward;

	private Vector3 _boxPositionAward;

	private Vector3 _boxScaleTopRun;

	private Vector3 _miniboxScale;

	private Vector3 _boxRotationTopRun;

	private Vector3 _boxPositionTopRun;

	private Vector3 _rewardStartRotation;

	private Vector3 _rewardStartScale;

	private Vector3 _rewardStartScaleCans;

	private Vector3 _rewardStartRotationJackpot;

	private Vector3 _rewardStartRotationCans;

	private Vector3 _rewardStartRotationTopRunRank;

	private Vector3 _rewardStartRotationTopRunMedal;

	private Vector3 _rewardStartPositionCans;

	private Vector3 _rewardStartScaleJackpot;

	private Vector3 _rewardEndScaleCoin;

	private Vector3 _rewardEndScaleCoiniPhoneX;

	private Vector3 _rewardEndScaleCoinJackpot;

	private Vector3 _rewardEndPositionJackpot;

	private Vector3 _rewardEndScale;

	private Vector3 _rewardEndScaleToken;

	private Vector3 _rewardEndScaleCan;

	private Vector3 _rewardEndScaleTopRunRank;

	private Vector3 _rewardEndPositionCan;

	private Vector3 _rewardEndPositionTopRunRank;

	private Vector3 _rewardEndPositionTopRunMedal;

	private GameObject _rewardMain;

	private UILabel _labelSingle;

	private UILabel _labelDouble1;

	private Vector3 _labelPosition;

	private Vector3 _labelPositionCelebration;

	private Vector3 _labelPositionBoardBundleCelebration;

	private Vector3 _continueLabelPosition;

	private bool _maySetTimeScale;

	public GameObject GlowEffect;

	private Color32 EFFECT_INITIAL_COLOR;

	private float TAP_TO_START_ALPHA;

	private const float BOX_IDLE_ANIM_SPEED = 2f;

	private const float BOX_IDLE_ANIM_AMOUNT = 10f;

	private const float BOX_IDLE_ANIM_END_SPEED = 20f;

	private bool _stopIdleAnim;

	private int _numberOfRewards;

	private CoinBoxSizer _coinboxSizer;

	private CelebrationReward[] _rewardsToUnlock;

	private bool _celebrationHasStarted;

	private bool _isFingerPressed;

	private SuperMysteryBoxEffect _superMysteryBoxEffect;

	private SuperMysteryBoxEffect _roundGlowEffect;

	private float _timeScaleBeforeCelebrationPopup;

	private Texture2D awardsBackground;

	private Texture2D normalBackground;

	private Texture2D _weeklyHuntBackground;

	private Texture2D _weeklyHuntStripe;

	private GameObject stripePanel;

	private Texture2D characterEventBackgroundTexture;

	private UITexture backgroundTexture;

	private UIPanel _backgroundPanel;

	private UITexture[] _stripeTextures;

	private const string STRIPE_COROUTINE_NAME = "AnimateStripes";

	private bool _stripeCoroutineRunning;

	private GameObject _tapToStartGo;

	private bool _isRewardingJackpot;

	private BragCelebrationHandler _bragCelebrationHandlerPrefab;

	private BragCelebrationHandler _currentBragCelebrationHandler;

	private MysteryBoxDoubleUpButton _mysteryBoxDoubleUpButton;

	private Vector3 _scaleTargetFactor;

	private UITweener.Method _scaleUpMethod;

	private UITweener.Method _scaleDownMethod;

	private float _scaleUpDuration;

	private float _scaleDownDurationFactor;

	private AudioClip _doubleRewardClip;

	private Dictionary<CelebrationRewardType, Action> _doubleRewardCallbacks;

	private static Action<CelebrationReward> m_OnRewardDoubleUp;

	private float _animationLerpFactor;

	private bool _isWaitingForInput;

	private bool _skipWaitBackButtonPressed;

	private const float DOUBLE_UP_REWARD_DELAY = 0.5f;

	private const float DOUBLE_UP_SFX_VOLUME = 0.7f;

	private CelebrationReward _rewardToDouble;

	private CelebrationPopupLabelTemplate _rewardTemplate;

	public static event Action<CelebrationReward> OnRewardDoubleUp
	{
		add
		{
			//IL_012e: Expected Obj, but got I
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got Unknown
			//IL_0152: Expected I, but got Obj
			//IL_0168: Expected Obj, but got I
			//IL_0197: Expected VT, but got Obj
			//IL_01ac: Expected F4, but got I
			//IL_01ac: Expected Obj, but got VT
			//IL_0060: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_007d: Expected I, but got Obj
			//IL_0093: Expected Obj, but got I
			//IL_01c7: Expected Obj, but got I
			//IL_01dd: Expected Obj, but got I
			//IL_00be: Expected I, but got Obj
			((UIScreen)(object)value).LoseFocus();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			UIScreenController uIScreenController = default;
			((UnityEngine.Object)uIScreenController).m_CachedPtr = cachedPtr;
			uIScreenController.popupAnchor = (GameObject)0;
			object obj = uIScreenController + 16;
			obj = value;
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v30 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uIScreenController.Awake();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Action`1<UI.Screens.RewardManagement.CelebrationReward>)+30C]");
			((TimeScaleManager)val).TimeScaleInMenuDefault = 0f;
			((MonoBehaviour)(object)value).useGUILayout = (byte)(int)"AnimateStripes" != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v18 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v24 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Action`1<UI.Screens.RewardManagement.CelebrationReward>)+338]");
			NGUITools.SetActiveChildren((GameObject)0, state: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Action`1<UI.Screens.RewardManagement.CelebrationReward>)+12C]");
			NGUITools.SetActiveChildren((GameObject)0, state: false);
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CelebrationPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CelebrationPopup>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CelebrationPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CelebrationPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CelebrationPopup.m_OnRewardDoubleUp;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CelebrationPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CelebrationPopup>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CelebrationPopup);
				if (!flag)
				{
					nint num5 = (nint)typeof(CelebrationPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CelebrationPopup>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CelebrationPopup);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CelebrationPopup);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CelebrationPopup>)+5C]");
				object obj5 = (nint)0 + (nint)36;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public override void Init()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 188;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj3 = this + 192;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj5 = this + 196;
		object obj6 = default;
		obj5 = obj6;
		trophyGoldBar = (GameObject)1;
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		//IL_0674: Expected I, but got Obj
		//IL_068a: Expected Obj, but got I
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_06b8: Expected I4, but got Obj
		//IL_06bc: Expected VT, but got Obj
		//IL_06c4: Expected Obj, but got VT
		//IL_06d2: Expected I, but got Obj
		//IL_06e8: Expected Obj, but got I
		//IL_0705: Expected I, but got Obj
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_0734: Expected Obj, but got I
		//IL_0742: Expected I, but got Obj
		//IL_0758: Expected Obj, but got I
		//IL_0766: Expected I, but got Obj
		//IL_077c: Expected Obj, but got I
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_07af: Expected Obj, but got I
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected Obj, but got Unknown
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_0815: Expected I, but got Obj
		//IL_082b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0865: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_0117: Expected I4, but got Obj
		//IL_00c9: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01bb: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_00b6: Expected I, but got Obj
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0247: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02ce: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I
		//IL_02ee: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_035a: Expected Obj, but got I
		//IL_036a: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03cd: Expected Obj, but got I
		//IL_03e4: Expected I, but got Obj
		//IL_03fa: Expected Obj, but got I
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected Obj, but got Unknown
		//IL_0892: Expected I4, but got Obj
		//IL_089e: Expected Obj, but got I4
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_0485: Expected Obj, but got I
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_0425: Expected I, but got Obj
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_051e: Expected Obj, but got I
		//IL_0536: Expected I4, but got Obj
		//IL_0542: Expected Obj, but got I4
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_0563: Expected Obj, but got I
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected Obj, but got Unknown
		//IL_05f9: Expected I4, but got Obj
		//IL_061b: Expected I4, but got Obj
		//IL_063d: Expected I4, but got Obj
		//IL_065f: Expected I4, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<Utils>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v115 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 312;
		_0021_00210 val = (_0021_00210)Utils.FindObject<T>((byte)(int)this != 0);
		obj2 = val;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		nint num4 = (nint)typeof(UIScreenController);
		if (!flag)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v109 (Il2CppClass<UIScreenController>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(UIScreenController);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(UIScreenController);
			}
		}
		object obj4 = this + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ L1_v3 (Il2CppClass<UIScreenController>)+5C]");
		object obj5 = -(-64);
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S7_v3 (Il2CppClass<UIScreenController>)+5C]");
		object obj6 = -(-64);
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S8_v3 (Il2CppClass<UIScreenController>)+5C]");
		object obj7 = -(-64);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
		object obj8 = default;
		obj4 = obj8;
		object obj9 = this + 760;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S3_v3 (Il2CppMethodInfo)+18]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v101 @ S4_v5 (should have been resolved before IL gen)");
		object obj14 = default;
		obj9 = obj14;
		object obj15 = this + 116;
		CoinBoxSizer coinboxSizer = _coinboxSizer;
		obj15 = coinboxSizer.coinAmountLabel;
		nint num9 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v21 (Il2CppClass<Strings>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v112 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("CELEBRATION_ITEM_HUNT_TOP_TITLE");
		_weeklyHuntTopTitleLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("CELEBRATION_POPUP_NEW_TROPHY");
		newTrophyLabel.fontSize = (int)text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S3_v8+60]");
		object obj18 = 0;
		object obj19 = obj18;
		object obj20 = obj19 & 0x1FFF;
		object obj21 = obj20 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v155 @ S4_v9 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		_ = 0;
		object obj23 = default;
		object obj22 = obj23 + 16;
		obj22 = this;
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S4_v12+60]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S4_v13+48]");
		object obj26 = 0;
		object obj27 = obj26 & 0x7FF;
		object obj28 = obj27 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v187 @ S5_v9 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num14 = 0;
		_ = 0;
		object obj30 = default;
		object obj29 = obj30 + 16;
		obj29 = this;
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S4_v17+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S4_v18+48]");
		object obj33 = 0;
		object obj34 = obj33 & 0x7FF;
		object obj35 = obj34 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v219 @ S5_v13 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num16 = 0;
		_ = 0;
		object obj37 = default;
		object obj36 = obj37 + 16;
		obj36 = this;
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S4_v22+60]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S4_v23+48]");
		object obj40 = 0;
		object obj41 = obj40 & 0x7FF;
		object obj42 = obj41 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v251 @ S5_v17 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num18 = 0;
		_ = 0;
		object obj44 = default;
		object obj43 = obj44 + 16;
		obj43 = this;
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S4_v27+60]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S4_v28+48]");
		object obj47 = 0;
		object obj48 = obj47 & 0x7FF;
		object obj49 = obj48 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v283 @ S5_v21 (should have been resolved before IL gen)");
		object obj50 = this + 876;
		object obj51 = default;
		obj50 = obj51;
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v69 (System.Boolean)+28]");
		string go = ((Component)0).tag;
		nint num20 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v75 (Il2CppClass<NGUITools>)+BA]");
		object obj52 = (nint)0 & (nint)0x200;
		if (obj52 != null)
		{
			nint num21 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v105 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj53 = this + 824;
		int num22 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)tapToStartLabelPrefab != 0);
		obj53 = num22;
		int layer = _tapToStartGo.layer;
		object obj54 = this + 724;
		object obj55 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S2_v17+8]");
		_ = 0;
		Transform transform = (Transform)(obj55 + 12);
		transform = (Transform)obj55;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		object obj56 = this + 308;
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S3_v18 (Il2CppMethodInfo)+18]");
		object obj57 = 0;
		object obj58 = obj57;
		object obj59 = obj58 & 0x1FFF;
		object obj60 = obj59 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v360 @ S4_v33 (should have been resolved before IL gen)");
		object obj61 = default;
		obj56 = obj61;
		UIPanel component = _tapToStartGo.GetComponent<UIPanel>();
		UIPanel backgroundPanel = _backgroundPanel;
		int sortingOrder = backgroundPanel.mDepth + 1;
		component.sortingOrder = sortingOrder;
		object obj62 = this + 300;
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v86 (System.Boolean)+28]");
		string go2 = ((Component)0).tag;
		int num24 = NGUITools.CalculateNextDepth((GameObject)(object)go2, (byte)(int)fleshEffectPrefab != 0);
		obj62 = num24;
		object obj63 = this + 304;
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S3_v23 (Il2CppMethodInfo)+18]");
		object obj64 = 0;
		object obj65 = obj64;
		object obj66 = obj65 & 0x1FFF;
		object obj67 = obj66 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v401 @ S4_v37 (should have been resolved before IL gen)");
		object obj68 = default;
		obj63 = obj68;
		UIPanel component2 = _flashEffectGO.GetComponent<UIPanel>();
		UIPanel backgroundPanel2 = _backgroundPanel;
		int sortingOrder2 = backgroundPanel2.mDepth + 1;
		component2.sortingOrder = sortingOrder2;
		string text3 = Strings.GetDefault("PRIZE_POPUP_TITLE");
		_prizeButtonNormalLabel.fontSize = (int)text3;
		string text4 = Strings.GetDefault("PRIZE_POPUP_TITLE");
		_prizeButtonSuperLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("PRIZE_POPUP_TITLE");
		_prizeButtonMiniLabel.fontSize = (int)text5;
		string text6 = Strings.GetDefault("CELEBRATION_POPUP_STICKER_BONUS");
		_bonusTextLabel.fontSize = (int)text6;
	}

	public override void Hide()
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_013a: Expected VT, but got Obj
		//IL_0065: Expected VT, but got Obj
		//IL_006e: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0088: Expected F4, but got I
		//IL_0088: Expected Obj, but got VT
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v32 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupClosed -= action;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		_timeScaleBeforeCelebrationPopup = realtimeSinceStartup;
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v15 (T)+10]");
		((TimeScaleManager)val2).TimeScaleInMenuDefault = 0f;
		MeshRenderer component = GlowEffect.GetComponent<MeshRenderer>();
		component.shadowCastingMode = ShadowCastingMode.Off;
		FillOutAllTheSlotsWithRewardContainers();
	}

	private void SetupCelebrationScreen()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(CelebrationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CelebrationPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CelebrationPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.CelebrationPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = CelebrationPopup.m_OnRewardDoubleUp;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(CelebrationPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.CelebrationPopup>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(CelebrationPopup);
			if (!flag)
			{
				nint num5 = (nint)typeof(CelebrationPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CelebrationPopup>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(CelebrationPopup);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(CelebrationPopup);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.CelebrationPopup>)+5C]");
			object obj5 = (nint)0 + (nint)36;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private void FillOutAllTheSlotsWithRewardContainers()
	{
		//IL_107d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1082: Expected Obj, but got Unknown
		//IL_108b: Expected Obj, but got I4
		//IL_1094: Unknown result type (might be due to invalid IL or missing references)
		//IL_1099: Expected Obj, but got Unknown
		//IL_10a2: Expected Obj, but got I4
		//IL_10b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b6: Expected Obj, but got Unknown
		//IL_10bf: Expected Obj, but got I4
		//IL_10ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d3: Expected Obj, but got Unknown
		//IL_10dc: Expected Obj, but got I4
		//IL_10eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0: Expected Obj, but got Unknown
		//IL_10f9: Expected Obj, but got I4
		//IL_1108: Unknown result type (might be due to invalid IL or missing references)
		//IL_110d: Expected Obj, but got Unknown
		//IL_1116: Expected Obj, but got I4
		//IL_1125: Unknown result type (might be due to invalid IL or missing references)
		//IL_112a: Expected Obj, but got Unknown
		//IL_1133: Expected Obj, but got I4
		//IL_1151: Unknown result type (might be due to invalid IL or missing references)
		//IL_1156: Expected Obj, but got Unknown
		//IL_1170: Expected Obj, but got I
		//IL_0012: Expected VT, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_005a: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_1182: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Expected Obj, but got Unknown
		//IL_118d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Expected Obj, but got Unknown
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Expected Obj, but got Unknown
		//IL_009b: Expected I, but got Obj
		//IL_0fde: Expected I, but got Obj
		//IL_0ff4: Expected Obj, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I
		//IL_1641: Expected Obj, but got I4
		//IL_029a: Expected I, but got Obj
		//IL_02b0: Expected Obj, but got I
		//IL_101f: Expected I, but got Obj
		//IL_1218: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected Obj, but got Unknown
		//IL_1245: Expected I, but got Obj
		//IL_125b: Expected Obj, but got I
		//IL_11c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c6: Expected Obj, but got Unknown
		//IL_02db: Expected I, but got Obj
		//IL_0323: Expected Obj, but got I4
		//IL_0331: Expected I, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_0609: Expected I, but got Obj
		//IL_0460: Expected I, but got Obj
		//IL_0476: Expected Obj, but got I
		//IL_0372: Expected I, but got Obj
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected Obj, but got Unknown
		//IL_0689: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I4
		//IL_03c8: Expected I, but got Obj
		//IL_03de: Expected Obj, but got I
		//IL_04a1: Expected I, but got Obj
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected Obj, but got Unknown
		//IL_0409: Expected I, but got Obj
		//IL_078f: Expected Obj, but got I4
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_06c7: Expected I, but got Obj
		//IL_06dd: Expected Obj, but got I
		//IL_12b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12be: Expected Obj, but got Unknown
		//IL_09f5: Expected I, but got Obj
		//IL_0a0b: Expected Obj, but got I
		//IL_0708: Expected I, but got Obj
		//IL_07a2: Expected I, but got Obj
		//IL_07b8: Expected Obj, but got I
		//IL_0a36: Expected I, but got Obj
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Expected Obj, but got Unknown
		//IL_0eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Expected Obj, but got Unknown
		//IL_0f05: Expected Obj, but got I4
		//IL_0a83: Expected I, but got Obj
		//IL_0a99: Expected Obj, but got I
		//IL_07e3: Expected I, but got Obj
		//IL_0ac4: Expected I, but got Obj
		//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3b: Expected Obj, but got Unknown
		//IL_0f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Expected Obj, but got Unknown
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Expected Obj, but got Unknown
		//IL_0f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected Obj, but got Unknown
		//IL_0fa0: Expected I4, but got Obj
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected Obj, but got Unknown
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Expected Obj, but got Unknown
		//IL_0c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c82: Expected Obj, but got Unknown
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Expected Obj, but got Unknown
		//IL_0cad: Expected I, but got Obj
		//IL_0cc3: Expected Obj, but got I
		//IL_1525: Expected I4, but got Obj
		//IL_1531: Expected Obj, but got I4
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected Obj, but got Unknown
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected Obj, but got Unknown
		//IL_0d43: Expected Obj, but got I4
		//IL_0cee: Expected I, but got Obj
		//IL_0d5a: Expected I, but got Obj
		//IL_0d70: Expected Obj, but got I
		//IL_0d8d: Expected I, but got Obj
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected Obj, but got Unknown
		//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected Obj, but got Unknown
		//IL_0bf2: Expected I, but got Obj
		//IL_0c08: Expected Obj, but got I
		//IL_154c: Expected Obj, but got I
		//IL_1596: Unknown result type (might be due to invalid IL or missing references)
		//IL_159b: Expected Obj, but got Unknown
		//IL_15b0: Expected Obj, but got VT
		//IL_15be: Expected I, but got Obj
		//IL_15d4: Expected Obj, but got I
		//IL_1505: Expected I4, but got Obj
		//IL_1511: Expected Obj, but got I4
		//IL_0da9: Expected I, but got Obj
		//IL_0dd9: Expected I, but got Obj
		//IL_0c33: Expected I, but got Obj
		//IL_04ee: Expected I, but got Obj
		//IL_0504: Expected Obj, but got I
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Expected Obj, but got Unknown
		//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected Obj, but got Unknown
		//IL_0e12: Expected I, but got Obj
		//IL_0dff: Expected I, but got Obj
		//IL_0530: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 120;
		obj = 0;
		object obj3 = obj2 + 84;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 72;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 60;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 48;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 36;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 24;
		obj8 = 0;
		_ = 0;
		int layer = boxParent.layer;
		Transform transform = (Transform)(obj2 + 96);
		bool isInstanced = UIScreenController.IsInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v3 (System.Boolean)+14]");
		int layer2 = ((GameObject)0).layer;
		transform.position = (Vector3)layer2;
		Transform transform2 = (Transform)(obj2 + 108);
		transform2 = transform;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 localPosition = transform2.localPosition;
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v32 (Il2CppClass<RewardManager>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v262 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = obj2 + 12;
		object obj11 = this + 764;
		List<CelebrationReward> weeklyHuntRewardsToUnlock = RewardManager.GetWeeklyHuntRewardsToUnlock();
		obj11 = weeklyHuntRewardsToUnlock;
		object obj12 = _rewardsToUnlock + 12;
		object obj13 = default;
		object obj21 = default;
		object obj25 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
		{
			object obj14 = _rewardsToUnlock + 16;
			object obj15 = obj13 << 2;
			object obj16 = obj14 + obj15;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v204+8]");
			object obj18 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v204+8]");
			if ((nint)0 != 1)
			{
				if ((nint)obj18 != 1)
				{
					if ((nint)obj18 != 2 && (nint)obj18 != 3 && (nint)obj18 != 4 && (nint)obj18 != 5 && (nint)obj18 != 6 && (nint)obj18 != 7 && (nint)obj18 != 8 && (nint)obj18 != 9 && (nint)obj18 != 10 && (nint)obj18 == 11)
					{
						nint num3 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v255 (Il2CppClass<Flurry>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num4 = (nint)typeof(Flurry);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v258 (Il2CppClass<Flurry>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
					}
				}
				else
				{
					obj = 0;
					nint num5 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v221 (Il2CppClass<Data.Save.EventsSave>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num6 = (nint)typeof(EventsSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v250 (Il2CppClass<Data.Save.EventsSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E9D");
					if (obj21 != null)
					{
						obj = 1;
						nint num7 = (nint)typeof(EventsSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v241 (Il2CppClass<Data.Save.EventsSave>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							nint num8 = (nint)typeof(EventsSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v246 (Il2CppClass<Data.Save.EventsSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E9E");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
					nint num9 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v231 (Il2CppClass<Flurry>)+BA]");
					object obj23 = (nint)0 & (nint)0x200;
					if (obj23 != null)
					{
						nint num10 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v235 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
				}
			}
			else
			{
				nint num11 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v211 (Il2CppClass<Flurry>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num12 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v215 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
			obj13 = obj25 + 1;
		}
		CelebrationReward[] rewardsToUnlock = _rewardsToUnlock;
		_numberOfRewards = rewardsToUnlock.Length;
		GameObject gameObject;
		if (_numberOfRewards > 0)
		{
			if (_numberOfRewards == 1)
			{
				_anotherReward = false;
			}
			else
			{
				_anotherReward = true;
			}
			object obj26 = _rewardsToUnlock + 16;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v56+8]");
			ShowPrizeList(MysteryBox.Type.Normal);
			nint num13 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v59 (Il2CppClass<NGUITools>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num14 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S1_v263 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.SetActiveChildren(_tapToStartGo, state: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			NGUITools.SetActiveChildren(_flashEffectGO, state: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			string text = newTrophyLabel.tag;
			((GameObject)(object)text).tag = null;
			object obj29 = _slots + 12;
			object obj30 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29))
			{
				object obj31 = _slots + 16;
				object obj32 = obj30 << 2;
				object obj33 = obj31 + obj32;
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S1_v253 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj34 = (nint)0 & (nint)0x200;
				if (obj34 != null)
				{
					nint num16 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v259 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)obj33);
				object obj35 = obj30 + 1;
				obj30 = obj35;
			}
			object obj36 = this + 124;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj37 = default;
			obj36 = obj37;
			object obj38 = this + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj39 = default;
			obj38 = obj39;
			object obj40 = 0;
			if ((nint)obj40 < _numberOfRewards)
			{
				nint num17 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S0_v173 (Il2CppClass<NGUITools>)+BA]");
				object obj41 = (nint)0 & (nint)0x200;
				if (obj41 != null)
				{
					nint num18 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v189 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num19 = NGUITools.CalculateRaycastDepth(boxParent);
				throw new ArrayTypeMismatchException();
			}
			OnTopRunAnimationFinished();
			_currentReward = 0;
			nint num20 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S0_v104 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj42 = (nint)0 & (nint)0x200;
			if (obj42 != null)
			{
				nint num21 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v164 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)superMysteryBoxEffectPrefab).FindKernel((string)null) != 0)
			{
				nint num22 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S1_v109 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj43 = (nint)0 & (nint)0x200;
				if (obj43 != null)
				{
					nint num23 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S1_v177 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)roundGlowEffectPrefab).FindKernel((string)null) != 0)
				{
					object obj44 = _rewardsToUnlock + 16;
					int num24 = _currentReward << 2;
					object obj45 = obj44 + num24;
					object obj46 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ S0_v129+8]");
					if ((nint)0 != 10)
					{
						object obj47 = _rewardsToUnlock + 16;
						int num25 = _currentReward << 2;
						object obj48 = obj47 + num25;
						object obj49 = obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ S0_v155+8]");
						if ((nint)0 != 11)
						{
							object obj50 = _slots + 16;
							int num26 = _currentReward << 2;
							object go = obj50 + num26;
							nint num27 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ S2_v94 (Il2CppClass<NGUITools>)+BA]");
							object obj51 = (nint)0 & (nint)0x200;
							if (obj51 != null)
							{
								nint num28 = (nint)typeof(NGUITools);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ S2_v99 (Il2CppClass<NGUITools>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int num29 = NGUITools.CalculateNextDepth((GameObject)go, (byte)(int)superMysteryBoxEffectPrefab != 0);
							gameObject = (GameObject)num29;
							goto IL_0d2d;
						}
					}
					object obj52 = _slots + 16;
					int num30 = _currentReward << 2;
					object go2 = obj52 + num30;
					nint num31 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ S2_v82 (Il2CppClass<NGUITools>)+BA]");
					object obj53 = (nint)0 & (nint)0x200;
					if (obj53 != null)
					{
						nint num32 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ S2_v87 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num33 = NGUITools.CalculateNextDepth((GameObject)go2, (byte)(int)roundGlowEffectPrefab != 0);
					gameObject = (GameObject)num33;
					goto IL_0d2d;
				}
			}
			SDebug.LogFormat("CelebrationPopup ERROR: superMysteryBoxEffectPrefab is not assigned", (object[])(object)this);
			goto IL_0ec2;
		}
		_anotherReward = false;
		SDebug.LogFormat("You should not be here when have no celebration items", null);
		nint num34 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v56 (Il2CppClass<UIScreenController>)+BA]");
		object obj54 = (nint)0 & (nint)0x200;
		if (obj54 != null)
		{
			nint num35 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v66 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		_ = 1;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
		openButtonCollider.isTrigger = false;
		return;
		IL_0ec2:
		object obj55 = _rewardsToUnlock + 16;
		int num36 = _currentReward << 2;
		object preOpenedCelebrationLabelTemplate = obj55 + num36;
		SetPreOpenedCelebrationLabelTemplate((CelebrationReward)preOpenedCelebrationLabelTemplate);
		IEnumerator enumerator = AnimateScreenFlash((UISprite)_currentReward);
		if (enumerator != null)
		{
			object obj56 = _celebrationRewardContainer + 16;
			int num37 = _currentReward << 2;
			object obj57 = obj56 + num37;
			int layer3 = ((GameObject)obj57).layer;
			object obj58 = _rewardsToUnlock + 16;
			int num38 = _currentReward << 2;
			object obj59 = obj58 + num38;
			ShowBackgroundWithStripes((Boards.BoardId)layer3, (UIModelController.ModelScreen)obj59);
		}
		else
		{
			FingerReleased();
		}
		return;
		IL_0d2d:
		int layer4 = gameObject.layer;
		GameObject gameObject2 = ((Component)layer4).gameObject;
		nint num39 = (nint)typeof(CelebrationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ S1_v123 (Il2CppClass<UI.Screens.CelebrationPopup>)+BA]");
		object obj60 = (nint)0 & (nint)0x200;
		bool flag3 = obj60 == null;
		nint num40 = (nint)typeof(CelebrationPopup);
		if (!flag3)
		{
			nint num41 = (nint)typeof(CelebrationPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ S1_v153 (Il2CppClass<UI.Screens.CelebrationPopup>)+74]");
			bool flag4 = (nint)0 == 0;
			bool flag5 = !flag4;
			num40 = (nint)typeof(CelebrationPopup);
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num40 = (nint)typeof(CelebrationPopup);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ L1_v9 (Il2CppClass<UI.Screens.CelebrationPopup>)+5C]");
		object obj61 = (nint)0 + (nint)24;
		transform = (Transform)obj61;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ S2_v59+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		transform2 = transform;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 eulerAngles = transform2.eulerAngles;
		object obj62 = this + 772;
		_0021_00210 componentInChildren = (_0021_00210)gameObject.GetComponentInChildren<T>();
		obj62 = componentInChildren;
		nint num42 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ S1_v136 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj63 = (nint)0 & (nint)0x200;
		if (obj63 != null)
		{
			nint num43 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ S1_v149 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_superMysteryBoxEffect != null)
		{
			SDebug.LogFormat("CelebrationPopup ERROR: unable to find SuperMysteryBoxEffect component on superMysteryBoxEffectPrefab", (object[])(object)this);
		}
		else
		{
			object obj64 = _rewardsToUnlock + 16;
			int num44 = _currentReward << 2;
			object obj65 = obj64 + num44;
			object obj66 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ S1_v146+8]");
			OnApplicationPause(pause: false);
		}
		goto IL_0ec2;
	}

	private void UpdateGui(CelebrationReward reward)
	{
	}

	private void SetPreOpenedCelebrationLabelTemplate(CelebrationReward reward)
	{
		//IL_0609: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I4
		//IL_0315: Expected I, but got Obj
		//IL_032b: Expected Obj, but got I
		//IL_0487: Expected Obj, but got I4
		//IL_0645: Expected Obj, but got I
		//IL_03a3: Expected I, but got Obj
		//IL_03b9: Expected Obj, but got I
		//IL_0356: Expected I, but got Obj
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_0675: Expected I4, but got Obj
		//IL_0682: Expected Obj, but got I4
		//IL_068e: Expected Obj, but got VT
		//IL_03e4: Expected I, but got Obj
		//IL_044f: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I4
		//IL_0472: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got I4
		//IL_0559: Expected I4, but got Obj
		//IL_0573: Expected Obj, but got I4
		string text = newTrophyLabel.tag;
		((GameObject)(object)text).tag = null;
		object obj = reward.CelebrationRewardOrigin - 1;
		if (reward.CelebrationRewardOrigin == CelebrationRewardOrigin.MysteryBox || (nint)obj == 1)
		{
			goto IL_01bd;
		}
		if ((nint)obj != 2)
		{
			if ((nint)obj != 3 && (nint)obj != 4 && (nint)obj != 5)
			{
				if ((nint)obj == 6 || (nint)obj == 7)
				{
					goto IL_0292;
				}
				if ((nint)obj != 8)
				{
					if ((nint)obj != 9)
					{
						if ((nint)obj != 10)
						{
							if ((nint)obj == 11)
							{
								goto IL_01bd;
							}
							if ((nint)obj != 12)
							{
								if ((nint)obj == 13)
								{
									goto IL_0292;
								}
								if ((nint)obj != 14)
								{
									if ((nint)obj == 15)
									{
										goto IL_01bd;
									}
								}
								else
								{
									_coinbox.tag = (string)1;
									HidePrizeButtons();
									_weeklyHuntTopTitle.tag = null;
									openButtonCollider.isTrigger = true;
								}
							}
							else
							{
								_coinbox.tag = (string)1;
								HidePrizeButtons();
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
								_weeklyHuntTopTitle.tag = null;
								openButtonCollider.isTrigger = true;
								ToggleSuperMysteryBoxEffect((CelebrationRewardOrigin)reward);
							}
						}
						else
						{
							_coinbox.tag = null;
							HidePrizeButtons();
							_weeklyHuntTopTitle.tag = null;
							openButtonCollider.isTrigger = true;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						}
					}
					else
					{
						_coinbox.tag = (string)1;
						HidePrizeButtons();
						_weeklyHuntTopTitle.tag = null;
						openButtonCollider.isTrigger = true;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
					}
				}
				else
				{
					_coinbox.tag = null;
					HidePrizeButtons();
					_weeklyHuntTopTitle.tag = null;
					openButtonCollider.isTrigger = false;
					nint num = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v56 (Il2CppClass<UIScreenController>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v82 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = UIScreenController.ShouldShowOnlineScreen();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v61 (System.Boolean)+28]");
					string go = ((Component)0).tag;
					string text2 = _bragCelebrationHandlerPrefab.tag;
					nint num3 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v68 (Il2CppClass<NGUITools>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v78 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj4 = this + 836;
					int num5 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)text2 != 0);
					_0021_00210 componentInChildren = (_0021_00210)((GameObject)num5).GetComponentInChildren<T>();
					obj4 = componentInChildren;
					string text3 = _currentBragCelebrationHandler.tag;
					int layer = ((GameObject)(object)text3).layer;
					bool flag2 = UIScreenController.ShouldShowOnlineScreen();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S1_v42 (System.Boolean)+28]");
					string text4 = ((Component)0).tag;
					bool activeSelf = ((GameObject)(object)text4).activeSelf;
					((AssignTextureAndMaterial)layer)._003CAwake_003Eb__3_0((Material)activeSelf);
				}
			}
			else
			{
				_coinbox.tag = null;
				Coroutine coroutine = StartCoroutine((IEnumerator)(object)"AnimateStripes");
				_weeklyHuntTopTitle.tag = (string)1;
				openButtonCollider.isTrigger = true;
			}
		}
		else
		{
			_coinbox.tag = null;
			Coroutine coroutine2 = StartCoroutine((IEnumerator)(object)"AnimateStripes");
			_weeklyHuntTopTitle.tag = (string)1;
			openButtonCollider.isTrigger = false;
		}
		goto IL_059f;
		IL_0292:
		_coinbox.tag = null;
		HidePrizeButtons();
		_weeklyHuntTopTitle.tag = null;
		openButtonCollider.isTrigger = false;
		goto IL_059f;
		IL_059f:
		Transform transform = _weeklyHuntTopTitleLabel.transform;
		if ((object)transform != null)
		{
			((RewardForVideoButton)(object)_weeklyHuntTopLayout).Init((VideoButtonPayload)null);
		}
		return;
		IL_01bd:
		_coinbox.tag = (string)1;
		HidePrizeButtons();
		_weeklyHuntTopTitle.tag = null;
		openButtonCollider.isTrigger = true;
		goto IL_059f;
	}

	private void ToggleSuperMysteryBoxEffect(CelebrationRewardOrigin origin)
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01cd: Expected I4, but got Obj
		//IL_01d9: Expected Obj, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L1 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
		if ((nint)0 != 13)
		{
			return;
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v43 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v21 (System.Boolean)+28]");
		string go = ((Component)0).tag;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v39 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 292;
		int num5 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)rewardLabelTemplate != 0);
		obj4 = num5;
		int layer = preOpenLabel.layer;
		object obj5 = this + 688;
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S2_v4+8]");
		_ = 0;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		CelebrationPopupLabelTemplate component = preOpenLabel.GetComponent<CelebrationPopupLabelTemplate>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L1 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+50]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L1 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+54]");
		component.SetMaxLineCountNicely((UILabel)num6, 0);
	}

	private bool IsTwoStepsCelebration(int rewardIndex)
	{
		//IL_0034: Expected I4, but got Obj
		//IL_0013: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_001c: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"EmptyWidgetUsedForOffset";
		UIWidget uIWidget = gameObject.AddComponent<UIWidget>();
		Bounds bounds = ((UIWidget)310).CalculateBounds((Transform)rewardIndex);
		return (byte)(int)gameObject != 0;
	}

	private void StartIdleAnimCoroutine(Transform rewardTrans, CelebrationReward reward)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		string text = ((Component)(object)mysteryEggPrefab).tag;
		((GameObject)(object)text).tag = (string)(object)rewardTrans;
		if ((object)rewardTrans != null)
		{
			obj2 = reward;
			obj = obj2;
			throw new ArrayTypeMismatchException();
		}
		((TimerHelper)(object)mysteryEggPrefab).HideIcon();
	}

	private IEnumerator BoxIdleAnimCoroutine(Transform rewardTrans, CelebrationReward reward)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		bool flag = (nint)reward > 3;
		object obj = rewardTrans - 1;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<CelebrationReward, UIntPtr>(ref reward) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
		object obj2 = rewardTrans + 1;
		bool flag3 = System.Runtime.CompilerServices.Unsafe.As<CelebrationReward, UIntPtr>(ref reward) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
		object obj3 = flag2 & flag3;
		object obj4 = obj3 ^ 1;
		object obj5 = flag | obj4;
		bool flag4 = (nint)rewardTrans != 3;
		return (IEnumerator)(obj5 & flag4);
	}

	private IEnumerator StartIdleAnimationFor(Transform rewardTrans, Vector3 baseLocalPos)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = enumerator + 24;
		obj2 = rewardTrans;
		object obj3 = enumerator + 16;
		obj3 = baseLocalPos;
		return enumerator;
	}

	private void OnApplicationPause(bool pause)
	{
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_01a4: Expected VT, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_superMysteryBoxEffect).FindKernel((string)null) != 0)
		{
			object obj2 = (pause ? 1 : 0) - 2;
			if ((pause ? 1 : 0) == 2 || ((nint)obj2 != 1 && ((nint)obj2 == 2 || (nint)obj2 == 3 || (nint)obj2 == 4 || ((nint)obj2 != 5 && (nint)obj2 != 6 && (nint)obj2 != 7 && ((nint)obj2 == 8 || (pause ? 1 : 0) == 13)))))
			{
				((TutorialMultilineLabelsHelper)(object)_superMysteryBoxEffect).SetupPosition((Vector3)3);
				_superMysteryBoxEffect.StopEffect();
			}
			else
			{
				_superMysteryBoxEffect.ApplyGlowAniFactor();
			}
		}
	}

	private void PlayTopRunAnimation(bool didHighFive)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		object obj = _rewardsToUnlock + 16;
		int num = _currentReward << 2;
		object obj2 = obj + num;
		object obj3 = obj2;
		if (!didHighFive)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S0_v5+8]");
			bool flag = (nint)0 == 11;
			bool isFingerPressed = _isFingerPressed;
			object obj4 = (isFingerPressed ? 1 : 0) ^ 1;
			object obj5 = flag | obj4;
			if (obj5 == null)
			{
				_FinishOpening();
			}
		}
	}

	public unsafe void OnTopRunAnimationFinished()
	{
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Expected VT, but got Unknown
		//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de3: Expected Obj, but got Unknown
		//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Expected Obj, but got Unknown
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Expected Ref, but got Unknown
		//IL_0d9a: Expected F4, but got Obj
		//IL_0d95: Expected native int or pointer, but got VT
		//IL_0daf: Expected F4, but got I
		//IL_0daa: Expected native int or pointer, but got VT
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_020d: Expected I, but got Obj
		//IL_0223: Expected Obj, but got I
		//IL_0e13: Expected I4, but got Obj
		//IL_0774: Expected Obj, but got I
		//IL_024e: Expected I, but got Obj
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_07e1: Expected Obj, but got I4
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_0812: Expected F4, but got Obj
		//IL_080d: Expected native int or pointer, but got VT
		//IL_0827: Expected F4, but got I
		//IL_0822: Expected native int or pointer, but got VT
		//IL_0834: Expected Obj, but got VT
		//IL_0834: Expected Obj, but got I4
		//IL_0e33: Expected I4, but got Obj
		//IL_0842: Expected Obj, but got I4
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected Obj, but got Unknown
		//IL_0874: Expected I, but got Obj
		//IL_088a: Expected Obj, but got I
		//IL_0307: Expected I, but got Obj
		//IL_0ef6: Expected F4, but got Obj
		//IL_0ef1: Expected native int or pointer, but got VT
		//IL_0f0b: Expected F4, but got I
		//IL_0f06: Expected native int or pointer, but got VT
		//IL_0f18: Expected Ref, but got VT
		//IL_0f2a: Expected F4, but got VT
		//IL_0f25: Expected native int or pointer, but got VT
		//IL_0f3f: Expected F4, but got I
		//IL_0f3a: Expected native int or pointer, but got VT
		//IL_0f48: Expected Obj, but got VT
		//IL_0f55: Expected Obj, but got I4
		//IL_0952: Expected Obj, but got I4
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_0983: Expected F4, but got Obj
		//IL_097e: Expected native int or pointer, but got VT
		//IL_0998: Expected F4, but got I
		//IL_0993: Expected native int or pointer, but got VT
		//IL_09a5: Expected Obj, but got VT
		//IL_09a5: Expected Obj, but got I4
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_0921: Expected F4, but got Obj
		//IL_091c: Expected native int or pointer, but got VT
		//IL_0936: Expected F4, but got I
		//IL_0931: Expected native int or pointer, but got VT
		//IL_093f: Expected Obj, but got VT
		//IL_08b5: Expected I, but got Obj
		//IL_09b3: Expected Obj, but got I4
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected Obj, but got Unknown
		//IL_09e5: Expected I, but got Obj
		//IL_09fb: Expected Obj, but got I
		//IL_0cfb: Expected Obj, but got I4
		//IL_0f6b: Expected F4, but got Obj
		//IL_0f66: Expected native int or pointer, but got VT
		//IL_0f80: Expected F4, but got I
		//IL_0f7b: Expected native int or pointer, but got VT
		//IL_0f8d: Expected Ref, but got VT
		//IL_0f9f: Expected F4, but got VT
		//IL_0f9a: Expected native int or pointer, but got VT
		//IL_0fb4: Expected F4, but got I
		//IL_0faf: Expected native int or pointer, but got VT
		//IL_0fbd: Expected Obj, but got VT
		//IL_0fca: Expected Obj, but got I4
		//IL_0ac3: Expected Obj, but got I4
		//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected Obj, but got Unknown
		//IL_0af4: Expected F4, but got Obj
		//IL_0aef: Expected native int or pointer, but got VT
		//IL_0b09: Expected F4, but got I
		//IL_0b04: Expected native int or pointer, but got VT
		//IL_0b16: Expected Obj, but got VT
		//IL_0b16: Expected Obj, but got I4
		//IL_0d20: Expected Obj, but got I4
		//IL_0d20: Expected Obj, but got I4
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected Obj, but got Unknown
		//IL_0a92: Expected F4, but got Obj
		//IL_0a8d: Expected native int or pointer, but got VT
		//IL_0aa7: Expected F4, but got I
		//IL_0aa2: Expected native int or pointer, but got VT
		//IL_0ab0: Expected Obj, but got VT
		//IL_0a26: Expected I, but got Obj
		//IL_0b24: Expected Obj, but got I4
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected Obj, but got Unknown
		//IL_0b56: Expected I, but got Obj
		//IL_0b6c: Expected Obj, but got I
		//IL_0fe0: Expected F4, but got Obj
		//IL_0fdb: Expected native int or pointer, but got VT
		//IL_0ff5: Expected F4, but got I
		//IL_0ff0: Expected native int or pointer, but got VT
		//IL_1002: Expected Ref, but got VT
		//IL_1014: Expected F4, but got VT
		//IL_100f: Expected native int or pointer, but got VT
		//IL_1029: Expected F4, but got I
		//IL_1024: Expected native int or pointer, but got VT
		//IL_1032: Expected Obj, but got VT
		//IL_0bdf: Expected Obj, but got I4
		//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Expected Obj, but got Unknown
		//IL_0c10: Expected F4, but got Obj
		//IL_0c0b: Expected native int or pointer, but got VT
		//IL_0c25: Expected F4, but got I
		//IL_0c20: Expected native int or pointer, but got VT
		//IL_0c32: Expected Obj, but got VT
		//IL_0c32: Expected Obj, but got I4
		//IL_0b97: Expected I, but got Obj
		//IL_0c40: Expected Obj, but got I4
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected Obj, but got Unknown
		//IL_0c72: Expected I, but got Obj
		//IL_0c88: Expected Obj, but got I
		//IL_0354: Expected I, but got Obj
		//IL_036a: Expected Obj, but got I
		//IL_1049: Expected F4, but got Obj
		//IL_1044: Expected native int or pointer, but got VT
		//IL_105e: Expected F4, but got I
		//IL_1059: Expected native int or pointer, but got VT
		//IL_106b: Expected Ref, but got VT
		//IL_107d: Expected F4, but got VT
		//IL_1078: Expected native int or pointer, but got VT
		//IL_1092: Expected F4, but got I
		//IL_108d: Expected native int or pointer, but got VT
		//IL_109b: Expected Obj, but got VT
		//IL_0e5b: Expected Obj, but got I4
		//IL_0cb3: Expected I, but got Obj
		//IL_041d: Expected I4, but got Obj
		//IL_0395: Expected I, but got Obj
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0493: Expected I, but got Obj
		//IL_04a9: Expected Obj, but got I
		//IL_042c: Expected I4, but got Obj
		//IL_04d4: Expected I, but got Obj
		//IL_043b: Expected I4, but got Obj
		//IL_0455: Expected I4, but got Obj
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_069f: Expected I, but got Obj
		//IL_06b5: Expected Obj, but got I
		//IL_0ec5: Expected I4, but got Obj
		//IL_06e0: Expected I, but got Obj
		//IL_05f7: Expected Obj, but got I4
		//IL_05f7: Expected Obj, but got I4
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_0652: Expected Obj, but got I4
		//IL_0652: Expected Obj, but got I4
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_054c: Expected I, but got Obj
		//IL_0562: Expected Obj, but got I
		//IL_0661: Expected I4, but got Obj
		//IL_0ea5: Expected I4, but got Obj
		//IL_058d: Expected I, but got Obj
		object obj = default;
		Vector4 vector = (Vector4)(obj - -64);
		object obj2 = obj + 48;
		object obj3 = obj + 32;
		ref Quaternion reference = ref *(Quaternion*)(obj + 16);
		object obj4 = default;
		int num4;
		if ((nint)obj4 < _numberOfRewards)
		{
			object obj5 = _rewardsToUnlock + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28+8]");
			object obj9 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28+8]");
			if ((nint)0 == 1)
			{
				goto IL_01d4;
			}
			if ((nint)obj9 != 1)
			{
				if ((nint)obj9 == 2)
				{
					goto IL_071f;
				}
				if ((nint)obj9 == 3)
				{
					goto IL_01d4;
				}
				if ((nint)obj9 != 4)
				{
					if ((nint)obj9 != 5)
					{
						if ((nint)obj9 == 6 || (nint)obj9 == 7 || (nint)obj9 == 8)
						{
							goto IL_071f;
						}
						if ((nint)obj9 != 9)
						{
							if ((nint)obj9 != 10)
							{
								if ((nint)obj9 != 11)
								{
									if ((nint)obj9 == 12)
									{
										goto IL_028d;
									}
									goto IL_071f;
								}
								object obj10 = _slots + 16;
								object obj11 = obj4 << 2;
								object go = obj10 + obj11;
								nint num = (nint)typeof(NGUITools);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S2_v185 (Il2CppClass<NGUITools>)+BA]");
								object obj12 = (nint)0 & (nint)0x200;
								if (obj12 != null)
								{
									nint num2 = (nint)typeof(NGUITools);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ S2_v190 (Il2CppClass<NGUITools>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								int num3 = NGUITools.CalculateNextDepth((GameObject)go, (byte)(int)miniMysteryBoxPrefab != 0);
								num4 = num3;
							}
							else
							{
								Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
								Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
								IAsyncResult asyncResult = ((OnActivatedPrefab)null).BeginInvoke((GameObject)currentBoardId, (byte)currentCharacterId != 0, (AsyncCallback)9, (object)null);
								int layer = ((GameObject)(object)asyncResult).layer;
								object obj13 = _slots + 16;
								object obj14 = obj4 << 2;
								object obj15 = obj13 + obj14;
								int layer2 = ((GameObject)obj15).layer;
								((Transform)layer).parentInternal = (Transform)layer2;
								num4 = (int)asyncResult;
							}
						}
						else
						{
							object obj16 = _slots + 16;
							object obj17 = obj4 << 2;
							object go2 = obj16 + obj17;
							nint num5 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S2_v167 (Il2CppClass<NGUITools>)+BA]");
							object obj18 = (nint)0 & (nint)0x200;
							if (obj18 != null)
							{
								nint num6 = (nint)typeof(NGUITools);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S2_v172 (Il2CppClass<NGUITools>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int num7 = NGUITools.CalculateNextDepth((GameObject)go2, (byte)(int)achievementBagPrefab != 0);
							num4 = num7;
						}
					}
					else
					{
						nint num8 = (nint)typeof(WeeklyHuntData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v83 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num9 = (nint)typeof(WeeklyHuntData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v107 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = WeeklyHuntManager.IsAnyPeriodActive();
						object obj20 = (flag ? 1 : 0) - 1;
						bool ignoreChildrenWithColliders;
						if (!flag)
						{
							if ((nint)obj20 != 1)
							{
								if ((nint)obj20 == 2)
								{
									ignoreChildrenWithColliders = (byte)(int)hiddenPrizePrefab_red != 0;
								}
								else
								{
									SDebug.LogFormat("Weekly Hunt Period not available!", null);
									ignoreChildrenWithColliders = (byte)(int)hiddenPrizePrefab_blue != 0;
								}
							}
							else
							{
								ignoreChildrenWithColliders = (byte)(int)hiddenPrizePrefab_green != 0;
							}
						}
						else
						{
							ignoreChildrenWithColliders = (byte)(int)hiddenPrizePrefab_blue != 0;
						}
						object obj21 = _slots + 16;
						object obj22 = obj4 << 2;
						object go3 = obj21 + obj22;
						nint num10 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S1_v164 (Il2CppClass<NGUITools>)+BA]");
						object obj23 = (nint)0 & (nint)0x200;
						if (obj23 != null)
						{
							nint num11 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S1_v169 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num12 = NGUITools.CalculateNextDepth((GameObject)go3, ignoreChildrenWithColliders);
						num4 = num12;
					}
					goto IL_075e;
				}
			}
			goto IL_028d;
		}
		MeshRenderer component = GlowEffect.GetComponent<MeshRenderer>();
		Material sharedMaterial = component.sharedMaterial;
		Color yellow = Color.yellow;
		((Vector4*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Vector4*)(nint)vector)->z = 0f;
		sharedMaterial.SetVector("_MainColor", vector);
		return;
		IL_01d4:
		object obj24 = _slots + 16;
		object obj25 = obj4 << 2;
		object go4 = obj24 + obj25;
		nint num13 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S2_v139 (Il2CppClass<NGUITools>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num14 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v144 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num15 = NGUITools.CalculateNextDepth((GameObject)go4, (byte)(int)mysteryBoxPrefab != 0);
		num4 = num15;
		goto IL_075e;
		IL_028d:
		object obj27 = _slots + 16;
		object obj28 = obj4 << 2;
		object go5 = obj27 + obj28;
		nint num16 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v150 (Il2CppClass<NGUITools>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num17 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S2_v155 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num18 = NGUITools.CalculateNextDepth((GameObject)go5, (byte)(int)superMysteryBoxPrefab != 0);
		num4 = num18;
		goto IL_075e;
		IL_075e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28+8]");
		object obj30 = -10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28+8]");
		if ((nint)0 != 10)
		{
			if ((nint)obj30 != 1)
			{
				if ((nint)obj30 == 2)
				{
					int layer3 = ((GameObject)num4).layer;
					object obj31 = this + 400;
					obj2 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S2_v86+8]");
					_ = 0;
					((Vector4*)(nint)vector)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((Vector4*)(nint)vector)->z = 0f;
					((Transform)layer3).parent = (Transform)vector;
					int layer4 = ((GameObject)num4).layer;
					object obj32 = this + 340;
					obj3 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S2_v96+8]");
					_ = 0;
					nint num19 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S1_v104 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
					object obj33 = (nint)0 & (nint)0x200;
					if (obj33 != null)
					{
						nint num20 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S1_v114 (Il2CppClass<UnityEngine.Quaternion>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector4*)(nint)vector)->x = (float)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector4*)(nint)vector)->z = 0f;
					Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector);
					((Vector4*)(nint)vector)->x = (float)reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
					((Vector4*)(nint)vector)->z = 0f;
					Vector3 localScale = ((Transform)vector).localScale;
				}
				else
				{
					int layer5 = ((GameObject)num4).layer;
					object obj34 = this + 328;
					obj2 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S2_v112+8]");
					_ = 0;
					((Vector4*)(nint)vector)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((Vector4*)(nint)vector)->z = 0f;
					((Transform)layer5).parent = (Transform)vector;
					int layer6 = ((GameObject)num4).layer;
					object obj35 = this + 340;
					obj3 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S2_v122+8]");
					_ = 0;
					nint num21 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S1_v128 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
					object obj36 = (nint)0 & (nint)0x200;
					if (obj36 != null)
					{
						nint num22 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S1_v138 (Il2CppClass<UnityEngine.Quaternion>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector4*)(nint)vector)->x = (float)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector4*)(nint)vector)->z = 0f;
					Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector);
					((Vector4*)(nint)vector)->x = (float)reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
					((Vector4*)(nint)vector)->z = 0f;
					Vector3 localScale = ((Transform)vector).localScale;
				}
			}
			else
			{
				int layer7 = ((GameObject)num4).layer;
				object obj37 = this + 388;
				obj2 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S2_v50+8]");
				_ = 0;
				((Vector4*)(nint)vector)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((Vector4*)(nint)vector)->z = 0f;
				((Transform)layer7).parent = (Transform)vector;
				int layer8 = ((GameObject)num4).layer;
				object obj38 = this + 412;
				obj3 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S2_v60+8]");
				_ = 0;
				nint num23 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S1_v74 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num24 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S1_v90 (Il2CppClass<UnityEngine.Quaternion>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector4*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector4*)(nint)vector)->z = 0f;
				Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector);
				((Vector4*)(nint)vector)->x = (float)reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
				((Vector4*)(nint)vector)->z = 0f;
				Vector3 localScale2 = ((Transform)vector).localScale;
				int layer9 = ((GameObject)num4).layer;
				object obj40 = this + 424;
				obj = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S2_v76+8]");
				_ = 0;
				((Vector4*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector4*)(nint)vector)->z = 0f;
				Vector3 localScale = ((Transform)vector).eulerAngles;
			}
		}
		else
		{
			int layer10 = ((GameObject)num4).layer;
			object obj41 = this + 352;
			obj2 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S2_v14+8]");
			_ = 0;
			((Vector4*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Vector4*)(nint)vector)->z = 0f;
			((Transform)layer10).parent = (Transform)vector;
			int layer11 = ((GameObject)num4).layer;
			object obj42 = this + 364;
			obj3 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v24+8]");
			_ = 0;
			nint num25 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S1_v44 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj43 = (nint)0 & (nint)0x200;
			if (obj43 != null)
			{
				nint num26 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v60 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector4*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector4*)(nint)vector)->z = 0f;
			Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector);
			((Vector4*)(nint)vector)->x = (float)reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
			((Vector4*)(nint)vector)->z = 0f;
			Vector3 localScale3 = ((Transform)vector).localScale;
			int layer12 = ((GameObject)num4).layer;
			object obj44 = this + 376;
			obj = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S2_v40+8]");
			_ = 0;
			((Vector4*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector4*)(nint)vector)->z = 0f;
			Vector3 localScale = ((Transform)vector).eulerAngles;
		}
		int layer13 = ((GameObject)num4).layer;
		bool activeSelf = boxParent.activeSelf;
		((AssignTextureAndMaterial)layer13)._003CAwake_003Eb__3_0((Material)activeSelf);
		throw new ArrayTypeMismatchException();
		IL_071f:
		throw new ArrayTypeMismatchException();
	}

	private IEnumerator AnimateScreenFlash(UISprite effectSprite)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = _celebrationRewardContainer + 16;
		object obj2 = (object)effectSprite << 2;
		object obj3 = obj + obj2;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (UnityEngine.Object)obj3 != null;
		return (IEnumerator)((flag ? 1 : 0) ^ 1);
	}

	public void FingerPressed()
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_016a: Expected I, but got Obj
		//IL_0180: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I4
		object obj = _celebrationRewardContainer + 16;
		int num = _currentReward << 2;
		object obj2 = obj + num;
		CharacterModel component = ((GameObject)obj2).GetComponent<CharacterModel>();
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component._topRunIdleAnimation).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num6 = 0;
				_ = 0;
				bool flag = default;
				object obj5 = (flag ? 1 : 0) + 16;
				obj5 = this;
				((CharacterModifier)(object)component._topRunIdleAnimation).Paused = flag;
			}
		}
		string celebrationRewardSource = GetCelebrationRewardSource((CelebrationReward)_currentReward);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)celebrationRewardSource);
	}

	private void StartOneStepUnlock()
	{
		//IL_0027: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_0108: Expected I, but got Obj
		//IL_0155: Expected I4, but got Obj
		//IL_0162: Expected Obj, but got I4
		if (~(_isFingerPressed ? 1u : 0u) == 0)
		{
			return;
		}
		_isFingerPressed = true;
		_stopIdleAnim = true;
		IEnumerator enumerator = AnimateScreenFlash((UISprite)_currentReward);
		if (enumerator == null)
		{
			return;
		}
		object obj = _celebrationRewardContainer + 16;
		int num = _currentReward << 2;
		object obj2 = obj + num;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S2_v5 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35 @ S3_v5 (should have been resolved before IL gen)");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			bool flag = ((Animation)(object)computeShader).Play((PlayMode)"down");
			if (((UnityEngine.Object)flag).GetInstanceID() != 0)
			{
				AnimationState animationState = ((Animation)(object)computeShader).CrossFadeQueued("down");
			}
		}
	}

	public void FingerReleased()
	{
		_FinishOpening();
	}

	private IEnumerator _ShowReward(int currentRewardIndex)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = currentRewardIndex;
		return enumerator;
	}

	private unsafe void PayoutReward(CelebrationReward reward, bool allowRemove, bool isDoubledReward)
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00c9: Expected VT, but got Obj
		//IL_00c9: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		bool isInstanced = UIScreenController.IsInstanced;
		nint num = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v11 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		NGUITools.FitOnScreen((Camera)isInstanced, (Transform)(object)instance.jumperSignature, (Transform)4, (Vector3)reward, out *(allowRemove ? ((Bounds*)1) : ((Bounds*)null)), isDoubledReward);
		((BoardScreen)this).InitBoards();
	}

	private string GetCelebrationRewardSource(CelebrationReward reward)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = this;
		return text;
	}

	private void _FinishOpening()
	{
		//IL_02cd: Expected I, but got Obj
		//IL_02e3: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01cf: Expected I, but got Obj
		//IL_01e5: Expected Obj, but got I
		//IL_0210: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)preOpenLabel).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(preOpenLabel);
		}
		object obj3 = _rewardsToUnlock + 16;
		int num5 = _currentReward << 2;
		object obj4 = obj3 + num5;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v13+8]");
		if ((nint)0 == 11)
		{
			IEnumerator routine = ((CelebrationPopup)null).AnimateAlpha((CelebrationPopupLabelTemplate)(object)_tapToStartLabel, 0.5f, 0f);
			Coroutine coroutine = StartCoroutine_Auto(routine);
			TogglePrizeButtons(CelebrationRewardOrigin.MysteryBox);
		}
		else
		{
			if (~(_celebrationHasStarted ? 1u : 0u) == 0)
			{
				return;
			}
			openButtonCollider.isTrigger = false;
			Update();
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v13+8]");
			bool flag = (nint)0 == 10;
			int num8 = ((ComputeShader)(object)_superMysteryBoxEffect).FindKernel((string)null);
			int num9 = num8 ^ 1;
			if (((flag ? 1u : 0u) | (uint)num9) == 0)
			{
				_superMysteryBoxEffect.ApplyGlowAniFactor();
			}
			IEnumerator routine2 = ((CelebrationPopup)null).AnimateAlpha((CelebrationPopupLabelTemplate)(object)_tapToStartLabel, 0.5f, 0f);
			Coroutine coroutine2 = StartCoroutine_Auto(routine2);
			string celebrationRewardSource = GetCelebrationRewardSource((CelebrationReward)_currentReward);
			Coroutine coroutine3 = StartCoroutine_Auto((IEnumerator)(object)celebrationRewardSource);
			_celebrationHasStarted = true;
		}
	}

	private unsafe IEnumerator MoveNextBoxToFront()
	{
		//IL_0196: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_023b: Expected I, but got Obj
		//IL_0251: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_013b: Expected I, but got Obj
		Boards.BoardId boardId = default;
		((Boards.BoardId*)(int)boardId)->value__ = 0;
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v48 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.MarkHoverboardAsSeen(boardId);
		nint num3 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v44 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (HoverboardModelPreviewFactory)+A]");
		if ((nint)0 != 0)
		{
			return (IEnumerator)5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (Info.Boards+BoardId)+4]");
		if ((nint)0 != 0)
		{
			Boards.BoardId value = ((Boards.BoardId?*)(int)boardId)->Value;
			return (IEnumerator)value;
		}
		nint num5 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v29 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v37 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		((SSEventsManagerController)(object)flurryUserId).CurrentEventHasBeenTriedNow();
		Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
		return (IEnumerator)previousBoardId;
	}

	private IEnumerator RotateGameObject(Transform trans, float duration, Vector3 angleToRotate)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = trans;
		object obj3 = enumerator + 28;
		obj3 = angleToRotate;
		return enumerator;
	}

	private IEnumerator CountUpCoins(int coinboxAmount, int toAmount, CelebrationPopupLabelTemplate rewardTemplate, bool isMegaJackpot = false, int fromAmount = 0, float countTimeMultiplier = 1f, bool doubled = false)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private float CalcCoinCountTime(int toAmount, int fromAmount, float countTimeMultiplier)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	private unsafe IEnumerator AnimateAlpha(UILabel label, float duration, float toAlpha)
	{
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_051b: Expected Obj, but got I4
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected Obj, but got Unknown
		//IL_0538: Expected Obj, but got I4
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected VT, but got Unknown
		//IL_0563: Expected F4, but got Obj
		//IL_055e: Expected native int or pointer, but got VT
		//IL_0575: Expected F4, but got I
		//IL_0570: Expected native int or pointer, but got VT
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected VT, but got Unknown
		//IL_05a1: Expected Obj, but got F4
		//IL_05b3: Expected I, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Obj, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		//IL_0607: Expected I4, but got Obj
		//IL_0607: Expected Obj, but got VT
		//IL_0614: Expected Obj, but got F4
		//IL_0925: Expected I, but got Obj
		//IL_093b: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_06ac: Expected I, but got Obj
		//IL_06c2: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected Obj, but got Unknown
		//IL_017c: Expected I, but got Obj
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_02f1: Expected I, but got Obj
		//IL_0307: Expected Obj, but got I
		//IL_0270: Expected I, but got Obj
		//IL_072a: Expected I4, but got Obj
		//IL_074d: Expected I, but got Obj
		//IL_0763: Expected Obj, but got I
		//IL_02c2: Invalid comparison between Obj and F4
		//IL_078d: Expected F4, but got Obj
		//IL_0788: Expected native int or pointer, but got VT
		//IL_079f: Expected F4, but got I
		//IL_079a: Expected native int or pointer, but got VT
		//IL_07ac: Expected F4, but got Obj
		//IL_07a7: Expected native int or pointer, but got VT
		//IL_07c1: Expected F4, but got I
		//IL_07bc: Expected native int or pointer, but got VT
		//IL_0810: Expected F4, but got Obj
		//IL_080b: Expected native int or pointer, but got VT
		//IL_0825: Expected F4, but got I
		//IL_0820: Expected native int or pointer, but got VT
		//IL_0832: Expected F4, but got Obj
		//IL_082d: Expected native int or pointer, but got VT
		//IL_0847: Expected F4, but got I
		//IL_0842: Expected native int or pointer, but got VT
		//IL_0332: Expected I, but got Obj
		//IL_037f: Expected I, but got Obj
		//IL_03cb: Expected F4, but got Obj
		//IL_03c6: Expected native int or pointer, but got VT
		//IL_03e0: Expected F4, but got I
		//IL_03db: Expected native int or pointer, but got VT
		//IL_03fe: Expected Obj, but got F4
		//IL_041f: Expected Obj, but got F4
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_0444: Expected Obj, but got F4
		//IL_046e: Expected Obj, but got I
		//IL_0498: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 60;
		obj3 = 0;
		_ = 0;
		GameObject gameObject = base.gameObject;
		Vector3 vector = (Vector3)(obj2 + 96);
		((Vector3*)(nint)vector)->x = (float)label;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)label).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj2 + 84);
		Vector3 vector3 = ((Transform)(object)gameObject).InverseTransformDirection(vector);
		UILabel uILabel = (UILabel)vector2.x;
		((UnityEngine.Object)label).m_CachedPtr = (IntPtr)vector2.z;
		string text = tag;
		nint num = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v26 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v178 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIKeyNavigation uIKeyNavigation = (UIKeyNavigation)(obj2 + 48);
		object obj5 = obj2 + 36;
		object obj6 = obj2 + 24;
		object obj7 = obj2 + 12;
		((UIKeyNavigation)vector).OnNavigate((KeyCode)text);
		obj = vector.x;
		_ = vector.z;
		float num3 = float.MaxValue;
		IEnumerator result = null;
		object obj9 = default;
		object obj17 = default;
		object obj25 = default;
		while (true)
		{
			nint num4 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v45 (Il2CppClass<UIKeyNavigation>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(UIKeyNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v172 (Il2CppClass<UIKeyNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UIKeyNavigation> list = UIKeyNavigation.list;
			if ((nint)obj9 >= list.size)
			{
				break;
			}
			nint num6 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v54 (Il2CppClass<UIKeyNavigation>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num7 = (nint)typeof(UIKeyNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v166 (Il2CppClass<UIKeyNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UIKeyNavigation> list2 = UIKeyNavigation.list;
			object obj11 = list2.buffer + 16;
			object obj12 = obj9 << 2;
			object obj13 = obj11 + obj12;
			UnityEngine.Object obj14 = (UnityEngine.Object)obj13;
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v162 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)obj13 != this))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v66 (UnityEngine.Object)+C]");
				if ((nint)0 != 3 && UIKeyNavigation.IsActive((GameObject)obj13))
				{
					UIWidget component = ((Component)obj13).GetComponent<UIWidget>();
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v86 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num11 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v158 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
						if (obj17 == (object)0f)
						{
							goto IL_070a;
						}
					}
					string text2 = ((Component)obj13).tag;
					nint num12 = (nint)typeof(UIKeyNavigation);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v96 (Il2CppClass<UIKeyNavigation>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num13 = (nint)typeof(UIKeyNavigation);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v151 (Il2CppClass<UIKeyNavigation>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					uIKeyNavigation.OnNavigate((KeyCode)text2);
					obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					nint num14 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v104 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj19 = (nint)0 & (nint)0x200;
					if (obj19 != null)
					{
						nint num15 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v147 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector2)->x = (float)uIKeyNavigation;
					((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)uIKeyNavigation).m_CachedPtr;
					((Vector3*)(nint)vector)->x = (float)obj5;
					Vector3 vector4 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v33+8]");
					((Vector3*)(nint)vector4)->z = 0f;
					Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
					obj3 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v35+8]");
					_ = 0;
					obj7 = label;
					_ = ((UnityEngine.Object)label).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
					((Vector3*)(nint)vector2)->x = (float)obj7;
					Vector3 vector5 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v37+8]");
					((Vector3*)(nint)vector5)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj2;
					Vector3 vector6 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector3*)(nint)vector6)->z = 0f;
					float num16 = vector2.x * vector.x;
					float num17 = vector2.y * vector.y;
					float num18 = num16 + num17;
					float num19 = vector2.z * vector.z;
					float num20 = num18 + num19;
					if (!(num20 < 0.707f))
					{
						((Vector3*)(nint)vector)->x = (float)obj3;
						Vector3 vector7 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
						((Vector3*)(nint)vector7)->z = 0f;
						vector3 = ((Transform)(object)gameObject).TransformPoint(vector);
						obj3 = vector2.x;
						_ = vector2.z;
						float num21 = (float)obj3 * duration;
						obj3 = num21;
						object obj20 = obj3 + 4;
						float num22 = (float)obj20 * toAlpha;
						obj20 = num22;
						object obj21 = obj3 * obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
						nint num23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
						object obj22 = num23 * 0;
						object obj23 = obj21 + obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
						nint num24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
						object obj24 = num24 * 0;
						float num25 = (float)obj23 + (float)obj24;
						if (!(num25 > num3))
						{
							string text3 = ((Component)obj13).tag;
							num3 = num25;
							result = (IEnumerator)(object)text3;
						}
					}
				}
			}
			goto IL_070a;
			IL_070a:
			obj9 = obj25 + 1;
		}
		return result;
	}

	private IEnumerator AnimateAlpha(CelebrationPopupLabelTemplate template, float duration, float toAlpha)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = template;
		return enumerator;
	}

	private IEnumerator AnimateColor(UIWidget widget, float duration, Color toColor)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got F4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = widget;
		object obj2 = toColor.r;
		_ = toColor.b;
		object obj3 = enumerator + 24;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return enumerator;
	}

	private IEnumerator AnimateColor(Material material, float duration, Color toColor)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got F4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = material;
		object obj2 = toColor.r;
		_ = toColor.b;
		object obj3 = enumerator + 24;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return enumerator;
	}

	private IEnumerator AnimateEffectColor(UISprite spriteToAnimate, Color color1, Color color2, float speedFactor = 1f, bool instant = false)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private IEnumerator MoveGameObject(Transform trans, float duration, Vector3 toPos)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got F4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = trans;
		object obj2 = toPos.x;
		_ = toPos.z;
		object obj3 = enumerator + 24;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return enumerator;
	}

	private IEnumerator ScaleGameObject(Transform trans, float duration, Vector3 toScale)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got F4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = trans;
		object obj2 = toScale.x;
		_ = toScale.z;
		object obj3 = enumerator + 24;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return enumerator;
	}

	private GameObject ChooseRewardPrefab(CelebrationReward reward)
	{
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		object obj = reward + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private IEnumerator AnimateStripes()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void ResetBackgroundToNormal()
	{
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_044f: Expected Obj, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_0463: Expected Obj, but got I4
		//IL_0487: Expected I, but got Obj
		//IL_049d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_01ad: Expected I, but got Obj
		//IL_01c3: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0533: Expected I, but got Obj
		//IL_0549: Expected Obj, but got I
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_01ee: Expected I, but got Obj
		//IL_0135: Expected I, but got Obj
		//IL_05a8: Expected I, but got Obj
		//IL_05be: Expected Obj, but got I
		//IL_023b: Expected I, but got Obj
		//IL_0288: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_0682: Expected I, but got Obj
		//IL_0698: Expected Obj, but got I
		//IL_0321: Expected I, but got Obj
		//IL_066f: Expected Obj, but got I4
		//IL_036e: Expected I, but got Obj
		//IL_0384: Expected Obj, but got I
		//IL_02c9: Expected I, but got Obj
		//IL_03fc: Expected I, but got Obj
		//IL_03af: Expected I, but got Obj
		object obj = this + 888;
		obj = 0;
		object obj2 = this + 892;
		obj2 = 0;
		_celebrationHasStarted = false;
		_isFingerPressed = false;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_superMysteryBoxEffect).FindKernel((string)null) != 0)
		{
			_superMysteryBoxEffect.ApplyGlowAniFactor();
		}
		if (~(_anotherReward ? 1u : 0u) == 0)
		{
			IEnumerator routine = AnimateStripes();
			Coroutine coroutine = StartCoroutine_Auto(routine);
			return;
		}
		object obj4 = _slots + 12;
		object obj5 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj6 = _slots + 16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)obj8);
			object obj10 = obj5 + 1;
			obj5 = obj10;
		}
		HidePrizeButtons();
		skipButtonCollider.isTrigger = true;
		openButtonCollider.isTrigger = false;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v24 (Il2CppClass<NGUITools>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v43 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.SetActiveChildren(_tapToStartGo, state: false);
		NGUITools.SetActiveChildren(_flashEffectGO, state: false);
		nint num7 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v35 (Il2CppClass<RewardManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num8 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v99 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PurchaseHandler instance = PurchaseHandler.Instance;
		if ((nint)instance >= 1)
		{
			nint num9 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v85 (Il2CppClass<RewardManager>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num10 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v93 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(RewardManager.canShowMultipleQueuedCelebrations ? 1u : 0u) == 0)
			{
				FillOutAllTheSlotsWithRewardContainers();
				return;
			}
		}
		nint num11 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v44 (Il2CppClass<RewardManager>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num12 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v78 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(RewardManager.canShowMultipleQueuedCelebrations ? 1u : 0u) == 0)
		{
			nint num13 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v66 (Il2CppClass<RewardManager>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num14 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v72 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RewardManager.canShowMultipleQueuedCelebrations = false;
		}
		nint num15 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v53 (Il2CppClass<UIScreenController>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num16 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v61 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		_ = 1;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
	}

	private void HidePrizeButtons()
	{
		//IL_011b: Expected I4, but got Obj
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_001e: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		_stripeCoroutineRunning = false;
		useGUILayout = (byte)(int)"AnimateStripes" != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		if (_stripeTextures != null)
		{
			object obj = _stripeTextures + 12;
			object obj2 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = _stripeTextures + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				string text = ((Component)obj5).tag;
				((GameObject)(object)text).tag = null;
				string obj6 = ((Component)obj5).tag;
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj6);
				object obj8 = obj2 + 1;
				obj2 = obj8;
			}
		}
		object obj9 = this + 816;
		obj9 = 0;
	}

	private unsafe void TogglePrizeButtons(CelebrationRewardOrigin origin)
	{
		//IL_002c: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_0169: Expected I, but got Obj
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_020c: Expected I, but got Obj
		//IL_0222: Expected Obj, but got I
		//IL_037a: Expected I4, but got Obj
		//IL_031f: Expected I, but got Obj
		//IL_039f: Expected I, but got Obj
		//IL_03b5: Expected Obj, but got I
		//IL_028b: Expected I, but got Obj
		//IL_03e0: Expected I, but got Obj
		if (~(_celebrationHasStarted ? 1u : 0u) == 0)
		{
			return;
		}
		_celebrationHasStarted = true;
		openButtonCollider.isTrigger = false;
		IEnumerator enumerator = AnimateScreenFlash((UISprite)_currentReward);
		if (enumerator == null)
		{
			return;
		}
		object obj = _celebrationRewardContainer + 16;
		int num = _currentReward << 2;
		object obj2 = obj + num;
		CharacterModel component = ((GameObject)obj2).GetComponent<CharacterModel>();
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v90 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v86 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component._topRunIdleAnimation).FindKernel((string)null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		TopRunIdleAnimation.AnimationFinishDelegate animationFinishDelegate = default;
		((Delegate)animationFinishDelegate).method_ptr = method_ptr;
		((Delegate)animationFinishDelegate).method = (nint)__ldftn(CelebrationPopup.OnTopRunAnimationFinished);
		object obj5 = animationFinishDelegate + 16;
		obj5 = this;
		component._topRunIdleAnimation.AnimationFinished -= animationFinishDelegate;
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag = obj6 == null;
		if (origin == CelebrationRewardOrigin.Notset)
		{
			if (!flag)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v82 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)audioStateLoop).FindKernel((string)null) != 0)
			{
				audioStateLoop.PlayUnlockSound();
			}
			component._topRunIdleAnimation.TR_PlayHit();
			return;
		}
		if (!flag)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v69 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)audioStateLoop).FindKernel((string)null) != 0)
		{
			audioStateLoop.PlayReviveSound();
		}
		IEnumerator routine = _ShowReward((int)_flashEffectSprite);
		Coroutine coroutine = StartCoroutine_Auto(routine);
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_superMysteryBoxEffect).FindKernel((string)null) != 0)
		{
			_superMysteryBoxEffect.StopEffect();
		}
		component._topRunIdleAnimation._002Ector();
	}

	private void ShowPrizeList(MysteryBox.Type type)
	{
		//IL_0092: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0337: Expected I, but got Obj
		//IL_034d: Expected Obj, but got I
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_03df: Expected Obj, but got I4
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_0133: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I4
		//IL_01e4: Expected I, but got Obj
		//IL_01fa: Expected Obj, but got I
		//IL_0225: Expected I, but got Obj
		//IL_0425: Expected Obj, but got I4
		//IL_0272: Expected I, but got Obj
		//IL_0288: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I4
		//IL_02b3: Expected I, but got Obj
		UnityEngine.Object obj2;
		Layout layout;
		GameObject gameObject;
		if (type > MysteryBox.Type.Mini)
		{
			object obj = type - 12;
			if (type != (MysteryBox.Type)12)
			{
				if ((nint)obj == 1)
				{
					goto IL_0103;
				}
				obj2 = null;
				layout = null;
				goto IL_0329;
			}
			layout = _prizeButtonMiniLayout;
			gameObject = _prizeButtonMini;
		}
		else
		{
			object obj3 = type - 1;
			if (type != MysteryBox.Type.Super)
			{
				if ((nint)obj3 == 1)
				{
					goto IL_0103;
				}
				obj2 = null;
				layout = null;
				goto IL_0329;
			}
			layout = _prizeButtonNormalLayout;
			gameObject = _prizeButtonNormal;
		}
		obj2 = gameObject;
		goto IL_0329;
		IL_0329:
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v2 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _prizeButtonNormal != obj2;
		_prizeButtonNormal.tag = (string)flag;
		object obj5 = this - -64;
		object obj6 = this - -64;
		bool flag2 = (UnityEngine.Object)obj6 != obj2;
		((GameObject)obj5).tag = (string)flag2;
		bool flag3 = _prizeButtonMini != obj2;
		_prizeButtonMini.tag = (string)flag3;
		if (((ComputeShader)obj2).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v20 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v44 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float posZ;
		if (IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			nint num5 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v32 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v38 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = -IPhoneXSupport.OFFSET_TOP;
			posZ = -46f + (float)obj9;
		}
		else
		{
			posZ = -46f;
		}
		int layer = ((GameObject)obj2).layer;
		TransformExtensions.SetLocalPosZ((Transform)layer, posZ);
		((RewardForVideoButton)(object)layout).Init((VideoButtonPayload)null);
		return;
		IL_0103:
		object obj10 = this - -64;
		layout = _prizeButtonSuperLayout;
		obj2 = (UnityEngine.Object)obj10;
		goto IL_0329;
	}

	private void Update()
	{
		ShowPrizeList(MysteryBox.Type.Normal);
	}

	private bool ShouldWaitForInput()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	public void StopWaitingForInput()
	{
		//IL_000a: Expected Obj, but got I4
		if (Input.GetKeyDown((string)27))
		{
			if (openButtonCollider.isTrigger)
			{
				StartOneStepUnlock();
				_FinishOpening();
			}
			if (skipButtonCollider.isTrigger)
			{
				ClosePrizeList();
			}
			if (~(_isWaitingForInput ? 1u : 0u) == 0)
			{
				_skipWaitBackButtonPressed = true;
			}
		}
	}

	public void SkipNow()
	{
		if (~(_isWaitingForInput ? 1u : 0u) == 0)
		{
			_isWaitingForInput = false;
		}
	}

	private void OnPopClosed(string popupName)
	{
		//IL_0616: Expected I, but got Obj
		//IL_062c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00cd: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_0657: Expected I, but got Obj
		//IL_066d: Expected Obj, but got I
		//IL_07e4: Expected Obj, but got I4
		//IL_010e: Expected I, but got Obj
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I4
		//IL_015b: Expected I, but got Obj
		//IL_0698: Expected I, but got Obj
		//IL_06ae: Expected Obj, but got I
		//IL_0800: Expected Obj, but got I4
		//IL_01e9: Expected I, but got Obj
		//IL_0283: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_0531: Expected I, but got Obj
		//IL_0547: Expected Obj, but got I
		//IL_0236: Expected I, but got Obj
		//IL_06d9: Expected I, but got Obj
		//IL_06ef: Expected Obj, but got I
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03cf: Expected I, but got Obj
		//IL_03e5: Expected Obj, but got I
		//IL_081c: Expected Obj, but got I4
		//IL_02c4: Expected I, but got Obj
		//IL_0572: Expected I, but got Obj
		//IL_0311: Expected I, but got Obj
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_0410: Expected I, but got Obj
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0488: Expected I, but got Obj
		//IL_049e: Expected Obj, but got I
		//IL_04c9: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v76 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)preOpenLabel).FindKernel((string)null) != 0)
		{
			preOpenLabel.tag = null;
		}
		if (popupName != null)
		{
			if ((nint)popupName != 1)
			{
				if ((nint)popupName != 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					string text = default;
					string msg = "Unhandeled mysterybox type " + text;
					SDebug.LogFormat(msg, (object[])(object)this);
					return;
				}
				nint num3 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v89 (Il2CppClass<Flurry>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v104 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num5 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v94 (Il2CppClass<UIScreenController>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v100 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag).QueuePopup("PrizeMMBPopup");
			}
			else
			{
				nint num7 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v69 (Il2CppClass<Flurry>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v84 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num9 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v74 (Il2CppClass<UIScreenController>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v80 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag2).QueuePopup("PrizeSMBPopup_Keys");
			}
		}
		else
		{
			nint num11 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v49 (Il2CppClass<Flurry>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v64 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num13 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v54 (Il2CppClass<UIScreenController>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num14 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v60 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag3).QueuePopup("PrizeMBPopup_Keys");
		}
		object obj8 = 0;
		while ((nint)obj8 < _numberOfRewards)
		{
			object obj9 = _celebrationRewardContainer + 16;
			object obj10 = obj8 << 2;
			object obj11 = obj9 + obj10;
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num16 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj11).FindKernel((string)null) != 0)
			{
				object obj13 = _celebrationRewardContainer + 16;
				object obj14 = obj8 << 2;
				object go = obj13 + obj14;
				nint num17 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S1_v46 (Il2CppClass<NGUITools>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num18 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v51 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.SetActiveChildren((GameObject)go, state: false);
			}
			object obj16 = obj8 + 1;
			obj8 = obj16;
		}
		nint num19 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num20 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_superMysteryBoxEffect).FindKernel((string)null) != 0)
		{
			_superMysteryBoxEffect.ApplyGlowAniFactor();
			_superMysteryBoxEffect.FastForwardEffect(0);
		}
		openButtonCollider.isTrigger = false;
		skipButtonCollider.isTrigger = false;
		_tapToStartLabel.tag = null;
	}

	public void ClosePrizeList()
	{
		//IL_0032: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got VT
		if (~(_maySetTimeScale ? 1u : 0u) == 0 && ~(_isRewardingJackpot ? 1u : 0u) != 0)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((TimeScaleManager)val).TimeScaleInMenuDefault = 4f;
		}
	}

	public void PrizeListNormalClicked()
	{
		//IL_03f2: Expected Obj, but got I4
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_01e1: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I4
		//IL_02bf: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0300: Expected I, but got Obj
		//IL_034f: Expected Obj, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0138: Expected I, but got Obj
		//IL_03e4: Expected Obj, but got I
		object obj = 0;
		while ((nint)obj < _numberOfRewards)
		{
			object obj2 = _celebrationRewardContainer + 16;
			object obj3 = obj << 2;
			object obj4 = obj2 + obj3;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v71 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj4).FindKernel((string)null) != 0)
			{
				object obj6 = _celebrationRewardContainer + 16;
				object obj7 = obj << 2;
				object go = obj6 + obj7;
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v62 (Il2CppClass<NGUITools>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v67 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.SetActiveChildren((GameObject)go, state: true);
			}
			object obj9 = obj + 1;
			obj = obj9;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_superMysteryBoxEffect).FindKernel((string)null) != 0)
		{
			_superMysteryBoxEffect.FastForwardEffect(1);
			object obj11 = _rewardsToUnlock + 16;
			int num7 = _currentReward << 2;
			object obj12 = obj11 + num7;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v41+8]");
			OnApplicationPause(pause: false);
		}
		openButtonCollider.isTrigger = true;
		skipButtonCollider.isTrigger = true;
		_tapToStartLabel.tag = (string)1;
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)preOpenLabel).FindKernel((string)null) != 0)
		{
			preOpenLabel.tag = (string)1;
			object obj15 = _rewardsToUnlock + 16;
			int num10 = _currentReward << 2;
			object obj16 = obj15 + num10;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v29+8]");
			if ((nint)0 == 13)
			{
				CelebrationPopupLabelTemplate component = preOpenLabel.GetComponent<CelebrationPopupLabelTemplate>();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v29+50]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v29+54]");
				component.SetMaxLineCountNicely((UILabel)num11, 0);
			}
		}
	}

	public void PrizeListSuperClicked()
	{
		OnPopClosed(null);
	}

	public void PrizeListMiniClicked()
	{
		//IL_000b: Expected Obj, but got I4
		OnPopClosed((string)1);
	}

	private GameObject ShowModel(Characters.CharacterId charId, int themeIndex, UIModelController.ModelScreen modelScreen, bool cache)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I4
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = this + 16;
		obj = 9;
		object obj2 = charId + 16;
		obj2 = 5;
		nint num = (nint)typeof(InfTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10 (Il2CppClass<Ionic.Zlib.InfTree>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(InfTree);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v21 (Il2CppClass<Ionic.Zlib.InfTree>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		throw new ArrayTypeMismatchException();
	}

	private void HideModel()
	{
		//IL_000b: Expected Obj, but got I4
		OnPopClosed((string)2);
	}

	private void ShowBackgroundWithStripes(Boards.BoardId boardId, UIModelController.ModelScreen modelScreen)
	{
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_01be: Expected I4, but got Obj
		//IL_00fa: Expected VT, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_0192: Expected I4, but got Obj
		//IL_0037: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modelScreen @ L2 (UIModelController+ModelScreen)+8]");
		if ((nint)0 == 11)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v32 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("CELEBRATION_POPUP_CONTINUE");
			_tapToStartLabel.fontSize = (int)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			return;
		}
		if (!flag)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("CELEBRATION_POPUP_OPEN");
		_tapToStartLabel.fontSize = (int)text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		IEnumerator routine = StartIdleAnimationFor((Transform)boardId, (Vector3)modelScreen);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private void HideSpecialBoard()
	{
		//IL_0012: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SetDiscoLightBackground();
	}

	private void HideCelebrationTunnel()
	{
		//IL_0012: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SetDiscoLightBackground();
	}

	private bool IsJackpot(CelebrationReward reward)
	{
		//IL_08cb: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_00a0: Expected I4, but got Obj
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01d6: Expected I4, but got Obj
		//IL_08f5: Expected I4, but got Obj
		//IL_0388: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_00af: Expected I4, but got Obj
		//IL_054f: Expected I4, but got Obj
		//IL_0592: Expected Obj, but got I4
		//IL_00be: Expected I4, but got Obj
		//IL_057a: Expected I4, but got Obj
		//IL_061a: Expected I4, but got Obj
		//IL_00cd: Expected I4, but got Obj
		//IL_055e: Expected I4, but got Obj
		//IL_0629: Expected I4, but got Obj
		//IL_079e: Expected I4, but got Obj
		//IL_08b3: Expected I4, but got Obj
		//IL_0638: Expected I4, but got Obj
		//IL_07ad: Expected I4, but got Obj
		//IL_0865: Expected I4, but got Obj
		//IL_065e: Expected Obj, but got I4
		//IL_065e: Expected Obj, but got I4
		//IL_065e: Expected Obj, but got I4
		//IL_07bc: Expected I4, but got Obj
		//IL_066d: Expected I4, but got Obj
		//IL_0874: Expected I4, but got Obj
		//IL_067a: Expected I4, but got Obj
		//IL_07cb: Expected I4, but got Obj
		//IL_07da: Expected I4, but got Obj
		//IL_07e9: Expected I4, but got Obj
		//IL_07f8: Expected I4, but got Obj
		//IL_0807: Expected I4, but got Obj
		//IL_0856: Expected I4, but got Obj
		//IL_0819: Expected Obj, but got I4
		//IL_0847: Expected I4, but got Obj
		//IL_056d: Expected I4, but got Obj
		GameObject gameObject;
		if (reward.CelebrationRewardOrigin == CelebrationRewardOrigin.Award)
		{
			object obj = reward.awardTierType - 1;
			if (reward.awardTierType == AwardTierType.Bronze)
			{
				return (byte)(int)rewardBronzeCan != 0;
			}
			if ((nint)obj == 1)
			{
				return (byte)(int)rewardSilverCan != 0;
			}
			if ((nint)obj == 2)
			{
				return (byte)(int)rewardGoldCan != 0;
			}
			if ((nint)obj == 3)
			{
				return (byte)(int)rewardDiamondCan != 0;
			}
			gameObject = rewardCoins;
		}
		else
		{
			bool flag = reward.CelebrationRewardOrigin == CelebrationRewardOrigin.TopRun;
			bool flag2 = !flag;
			gameObject = rewardCoins;
			if (!flag2)
			{
				object obj2 = reward - -64;
				object obj3 = obj2 - 1;
				GameObject[] array = rewardsTopRun;
				if ((nint)obj3 <= array.Length)
				{
					object obj4 = rewardsTopRun + 16;
					object obj5 = obj3 << 2;
					object obj6 = obj4 + obj5;
					return (byte)(int)obj6 != 0;
				}
				GameObject[] array2 = rewardsTopRun;
				object obj7 = array2.Length << 2;
				object obj8 = (object)rewardsTopRun + obj7;
				object obj9 = obj8 + 12;
				gameObject = (GameObject)obj9;
			}
			object obj10 = reward.rewardType - 1;
			if (reward.rewardType == CelebrationRewardType.coins)
			{
				IEnumerator enumerator = TweenScaleUpDown((GameObject)(object)reward);
				GameObject gameObject2 = ((enumerator == null) ? rewardCoins : rewardCoinsJackpot);
				return (byte)(int)gameObject2 != 0;
			}
			if ((nint)obj10 == 1)
			{
				object obj11 = reward.upgradeType - 1;
				if (reward.upgradeType != UpgradeType.hoverboard)
				{
					if ((nint)obj11 != 1)
					{
						if ((nint)obj11 == 2)
						{
							return (byte)(int)rewardPowerupHeadstart2000 != 0;
						}
						if ((nint)obj11 != 3 && (nint)obj11 != 4 && (nint)obj11 != 5 && (nint)obj11 != 6 && (nint)obj11 != 7 && (nint)obj11 != 8 && (nint)obj11 != 9 && (nint)obj11 != 10 && (nint)obj11 != 11 && (nint)obj11 != 12 && (nint)obj11 != 13 && (nint)obj11 == 14)
						{
							return (byte)(int)rewardPowerupScoreBooster != 0;
						}
					}
					return (byte)(int)gameObject != 0;
				}
				return (byte)(int)rewardPowerupHoverboard != 0;
			}
			if ((nint)obj10 == 2)
			{
				object obj12 = reward.characterId - 1;
				if (reward.characterId != Characters.CharacterId.tricky)
				{
					if ((nint)obj12 != 1)
					{
						if ((nint)obj12 != 2)
						{
							if ((nint)obj12 == 3)
							{
								StayInOneLaneMission instance = StayInOneLaneMission.instance;
								((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)54, (PersistentAwardProgress)1, (Action<Award>)(-1));
								return (byte)(int)rewardTokenYutani != 0;
							}
							return (byte)(int)gameObject != 0;
						}
						return (byte)(int)rewardTokenSpike != 0;
					}
					return (byte)(int)rewardTokenFresh != 0;
				}
				return (byte)(int)rewardTokenTricky != 0;
			}
			if ((nint)obj10 == 3)
			{
				if (reward.trophyType != Trophies.Trophy.diamond)
				{
					if (reward.trophyType != Trophies.Trophy.goldbar)
					{
						if (reward.trophyType != Trophies.Trophy.goldChainClock)
						{
							if (reward.trophyType != Trophies.Trophy.goldChainDollar)
							{
								if (reward.trophyType != Trophies.Trophy.goldSkull)
								{
									if (reward.trophyType != Trophies.Trophy.headphones)
									{
										if (reward.trophyType != Trophies.Trophy.lpBlack)
										{
											if (reward.trophyType == Trophies.Trophy.tapeBlack)
											{
												return (byte)(int)trophyTapeBlack != 0;
											}
											object obj13 = reward.trophyType;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
											object[] array3 = default;
											string msg = string.Concat(array3);
											SDebug.LogFormat(msg, null);
											return (byte)(int)gameObject != 0;
										}
										return (byte)(int)trophyLPBlack != 0;
									}
									return (byte)(int)trophyHeadphones != 0;
								}
								return (byte)(int)trophyGoldSkull != 0;
							}
							return (byte)(int)trophyChainDollar != 0;
						}
						return (byte)(int)trophyChainClock != 0;
					}
					return (byte)(int)trophyGoldBar != 0;
				}
				return (byte)(int)trophyDiamond != 0;
			}
			if ((nint)obj10 != 4)
			{
				if ((nint)obj10 == 5)
				{
					return (byte)(int)rewardKey != 0;
				}
				if ((nint)obj10 == 6)
				{
					return (byte)(int)rewardSpecialBoard != 0;
				}
				if ((nint)obj10 != 7 && (nint)obj10 != 8 && (nint)obj10 != 9 && (nint)obj10 != 10 && (nint)obj10 == 11)
				{
					return (byte)(int)rewardWelcomePackBoard != 0;
				}
			}
		}
		return (byte)(int)gameObject != 0;
	}

	private void DoubleCoins()
	{
		//IL_0012: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		UIModelController.OnChangedCurrentlyShownCharacter += (Action)isInstanced;
	}

	private IEnumerator Initial_Generic_DoubleUp_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = reward;
		_ = ((UnityEngine.Object)template).m_CachedPtr;
		object obj2 = enumerator + 20;
		obj2 = template;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return enumerator;
	}

	private IEnumerator DoubleCoins_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 24;
		obj2 = reward;
		object obj3 = enumerator + 20;
		obj3 = template;
		return enumerator;
	}

	private void DoubleKeys()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (_rewardToDouble == null)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_rewardTemplate).FindKernel((string)null) != 0)
		{
			IEnumerator routine = DoubleKeys_Routine(_rewardToDouble, _rewardTemplate);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	private IEnumerator DoubleKeys_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = reward;
		object obj3 = enumerator + 24;
		obj3 = template;
		return enumerator;
	}

	private void DoubleTokens()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (_rewardToDouble == null)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_rewardTemplate).FindKernel((string)null) != 0)
		{
			IEnumerator routine = DoubleTokens_Routine(_rewardToDouble, _rewardTemplate);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	private IEnumerator DoubleTokens_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = reward;
		object obj3 = enumerator + 24;
		obj3 = template;
		return enumerator;
	}

	private void DoublePowerups()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (_rewardToDouble == null)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_rewardTemplate).FindKernel((string)null) != 0)
		{
			IEnumerator routine = DoublePowerups_Routine(_rewardToDouble, _rewardTemplate);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	private IEnumerator DoublePowerups_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = reward;
		object obj3 = enumerator + 24;
		obj3 = template;
		return enumerator;
	}

	private IEnumerator TweenScaleUpDown(GameObject go)
	{
		//IL_0043: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+C]");
		if ((nint)0 == 1)
		{
			object obj = (nint)((UnityEngine.Object)go).m_CachedPtr - 1;
			if (((UnityEngine.Object)go).m_CachedPtr == (IntPtr)1)
			{
				goto IL_01c6;
			}
			if ((nint)obj == 1)
			{
				goto IL_020c;
			}
			if ((nint)obj != 2)
			{
				if ((nint)obj == 3)
				{
					goto IL_01c6;
				}
				if ((nint)obj == 4 || ((nint)obj != 5 && (nint)obj != 6 && (nint)obj != 7 && (nint)obj != 8 && (nint)obj != 9 && (nint)obj != 10 && (nint)obj != 11 && (nint)obj == 12))
				{
					goto IL_020c;
				}
			}
		}
		IEnumerator result = null;
		goto IL_025c;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+14]");
		bool flag = (nint)0 <= (nint)99999;
		result = null;
		if (!flag)
		{
			_isRewardingJackpot = true;
			result = (IEnumerator)1;
		}
		goto IL_025c;
		IL_025c:
		return result;
		IL_020c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+14]");
		bool flag2 = (nint)0 <= (nint)299999;
		result = null;
		if (!flag2)
		{
			_isRewardingJackpot = true;
			result = (IEnumerator)1;
		}
		goto IL_025c;
	}

	private IEnumerator PlaySoundDelayed(AudioClip clip, float delay = 0f, float volume = 1f)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = clip;
		return enumerator;
	}

	public CelebrationPopup()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (_rewardToDouble == null)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_rewardTemplate).FindKernel((string)null) != 0)
		{
			IAsyncResult routine = ((FirstPurchaseBonusBecameInactive)(object)this).BeginInvoke((AsyncCallback)(object)_rewardToDouble, (object)_rewardTemplate);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)routine);
		}
	}
}
