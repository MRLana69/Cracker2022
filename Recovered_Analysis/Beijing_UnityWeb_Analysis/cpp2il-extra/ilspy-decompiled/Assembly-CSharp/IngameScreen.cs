using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Kiloo.Common.UI;
using Kiloo.Common.Utility;
using Missions;
using SYBO.Common.Managers;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using UI.Screens;
using UnityEngine;
using WeeklyHunt;

public class IngameScreen : UIScreen
{
	private enum PowerUpType
	{
		_notset,
		headstart,
		scorebooster
	}

	private enum SpeedometerState
	{
		inactive,
		active,
		hidden
	}

	private sealed class _003CAnimateSpeedoMeterPanel_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IngameScreen _003C_003E4__this;

		public float startValue;

		public float endValue;

		public UIPanel uiSpeedoMeterPanel;

		public SpeedometerState nextState;

		public PowerUpType type;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_0071: Expected I4, but got Obj
				//IL_00a3: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						if (nextState == SpeedometerState.hidden)
						{
							if (type == PowerUpType.headstart)
							{
								_003C_003E4__this.HideScoreboosterSpeedoMeter();
								return null;
							}
							if (type == PowerUpType.scorebooster)
							{
								_003C_003E4__this.AnimateHeadstartIndicator();
							}
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				IEnumerator list = FrontScreen.AnimateSlideInButton((Transform)null, startValue, endValue, (byte)(int)uiSpeedoMeterPanel != 0);
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
				obj = coroutine;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CAnimateSpeedoMeterPanel_003Ed__107(int _003C_003E1__state)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
			((Container)this).hasTransientState = false;
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

	private sealed class _003CAnimatePanelAlpha_003Ed__111(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float startValue;

		public float endValue;

		public UIPanel uiSpeedoMeterPanel;

		private float _003CanimationLerpFactor_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00ca: Expected I, but got Obj
				//IL_00e0: Expected Obj, but got I
				//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Expected Obj, but got Unknown
				//IL_01b1: Expected Obj, but got I4
				//IL_01c5: Expected Obj, but got I4
				//IL_010b: Expected I, but got Obj
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
					_003CanimationLerpFactor_003E5__2 = 0f;
				}
				if (_003CanimationLerpFactor_003E5__2 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime * 3f;
					float num2 = _003CanimationLerpFactor_003E5__2 + num;
					_003CanimationLerpFactor_003E5__2 = num2;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S3_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S3_v9 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num5 = Mathf.LerpUnclamped(startValue, endValue, _003CanimationLerpFactor_003E5__2);
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

	private sealed class _003CAnimateSpriteColor_003Ed__112(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float speedFactor;

		public UISprite spriteToAnimate;

		public Color32 startValue;

		public Color32 endValue;

		private float _003CanimationLerpFactor_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_024b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0250: Expected VT, but got Unknown
				//IL_0259: Unknown result type (might be due to invalid IL or missing references)
				//IL_025e: Expected I4, but got Unknown
				//IL_0267: Unknown result type (might be due to invalid IL or missing references)
				//IL_026c: Expected Obj, but got Unknown
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_027a: Expected Obj, but got Unknown
				//IL_0283: Unknown result type (might be due to invalid IL or missing references)
				//IL_0288: Expected Obj, but got Unknown
				//IL_0291: Unknown result type (might be due to invalid IL or missing references)
				//IL_0296: Expected Obj, but got Unknown
				//IL_029f: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a4: Expected Obj, but got Unknown
				//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b2: Expected Obj, but got Unknown
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Expected Obj, but got Unknown
				//IL_008a: Expected Obj, but got I4
				//IL_012d: Expected Obj, but got VT
				//IL_0142: Expected F4, but got Obj
				//IL_013d: Expected native int or pointer, but got VT
				//IL_015e: Expected Obj, but got VT
				//IL_0173: Expected F4, but got Obj
				//IL_016e: Expected native int or pointer, but got VT
				//IL_018d: Expected I4, but got Obj
				//IL_01a7: Expected F4, but got Obj
				//IL_01a2: Expected native int or pointer, but got VT
				//IL_01bc: Expected F4, but got I
				//IL_01b7: Expected native int or pointer, but got VT
				//IL_01d3: Expected I4, but got VT
				//IL_01d3: Expected Ref, but got VT
				//IL_01e5: Expected native int or pointer, but got VT
				//IL_01f7: Expected native int or pointer, but got VT
				//IL_020b: Expected I4, but got VT
				//IL_0211: Unknown result type (might be due to invalid IL or missing references)
				//IL_0216: Expected Obj, but got Unknown
				//IL_021f: Expected Obj, but got I4
				//IL_0233: Expected Obj, but got I4
				Matrix4x4 matrix4x2 = default;
				Matrix4x4 matrix4x = (Matrix4x4)(matrix4x2 + 80);
				int num = matrix4x2 - -64;
				object obj = matrix4x2 + 56;
				object obj2 = matrix4x2 + 40;
				object obj3 = matrix4x2 + 60;
				object obj4 = matrix4x2 + 32;
				object obj5 = matrix4x2 + 16;
				object obj6 = matrix4x2 + 36;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						_003CanimationLerpFactor_003E5__2 = 0f;
					}
					if (_003CanimationLerpFactor_003E5__2 < 1f)
					{
						float unscaledTime = Time.unscaledTime;
						float num2 = unscaledTime * speedFactor;
						float num3 = _003CanimationLerpFactor_003E5__2 + num2;
						_003CanimationLerpFactor_003E5__2 = num3;
						obj = startValue;
						obj3 = obj;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
						Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
						obj4 = endValue;
						obj6 = obj4;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
						Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
						((int*)num)->m_value = (int)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						_ = 0;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						((Matrix4x4*)matrix4x2)->set_Item(num, (int)matrix4x, _003CanimationLerpFactor_003E5__2);
						((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
						((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
						spriteToAnimate.rawPivot = (UIWidget.Pivot)matrix4x;
						object obj7 = this + 12;
						obj7 = 0;
						_003C_003E1__state = 2;
						return 1;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.2f;
				object obj8 = this + 12;
				object obj9 = default;
				obj8 = obj9;
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

	private sealed class _003CAnimateSpriteSize_003Ed__113(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float speedFactor;

		public UISprite spriteToAnimate;

		public int startWidthValue;

		public int endWidthValue;

		public int startHeightValue;

		public int endHeightValue;

		private float _003CanimationLerpFactor_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00cb: Expected I, but got Obj
				//IL_00e1: Expected Obj, but got I
				//IL_01f7: Expected F4, but got I4
				//IL_01f7: Expected F4, but got I4
				//IL_0162: Expected F4, but got I4
				//IL_0162: Expected F4, but got I4
				//IL_010c: Expected I, but got Obj
				//IL_0181: Expected Obj, but got I4
				//IL_018b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Expected Obj, but got Unknown
				//IL_0199: Expected Obj, but got I4
				//IL_01ad: Expected Obj, but got I4
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
					_003CanimationLerpFactor_003E5__2 = 0f;
				}
				if (_003CanimationLerpFactor_003E5__2 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime * speedFactor;
					float num2 = _003CanimationLerpFactor_003E5__2 + num;
					_003CanimationLerpFactor_003E5__2 = num2;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v21 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float f = Mathf.LerpUnclamped(startWidthValue, endWidthValue, _003CanimationLerpFactor_003E5__2);
					int height = Mathf.FloorToInt(f);
					spriteToAnimate.height = height;
					float f2 = Mathf.LerpUnclamped(startHeightValue, endHeightValue, _003CanimationLerpFactor_003E5__2);
					int num5 = Mathf.FloorToInt(f2);
					Color color = ((UIWidget)num5).color;
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

	private sealed class _003CAnimateHeadstartIndicatorGear_003Ed__123(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IngameScreen _003C_003E4__this;

		private float _003CstartIndicatorRotation_003E5__2;

		private float _003CendIndicatorRotation_003E5__3;

		private float _003CanimationLerpFactor_003E5__4;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0209: Expected Obj, but got Ref
				//IL_0217: Expected Obj, but got Ref
				//IL_0220: Expected Obj, but got I4
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Expected Obj, but got Unknown
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Expected Obj, but got Unknown
				//IL_0080: Expected F4, but got Obj
				//IL_0116: Expected I, but got Obj
				//IL_012c: Expected Obj, but got I
				//IL_02af: Expected Obj, but got F4
				//IL_02e2: Expected I, but got Obj
				//IL_02f8: Expected Obj, but got I
				//IL_0344: Expected Ref, but got VT
				//IL_035a: Expected Obj, but got Ref
				//IL_0364: Unknown result type (might be due to invalid IL or missing references)
				//IL_0369: Expected Obj, but got Unknown
				//IL_0372: Expected Obj, but got I4
				//IL_0386: Expected Obj, but got I4
				//IL_0157: Expected I, but got Obj
				//IL_01a4: Expected I, but got Obj
				ref Quaternion reference2 = default;
				ref Quaternion reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 40);
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 16));
				object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 28));
				obj2 = 0;
				_ = 0;
				IngameScreen ingameScreen = _003C_003E4__this;
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
					_003CstartIndicatorRotation_003E5__2 = ingameScreen._currentHeadstartIndicatorZRotation;
					object obj3 = ingameScreen._turboHeadstartGearZRotations + 16;
					int num = ingameScreen._currentHeadstartGear << 2;
					object obj4 = obj3 + num;
					_003CendIndicatorRotation_003E5__3 = (float)obj4;
					_003CanimationLerpFactor_003E5__4 = 0f;
				}
				if (_003CanimationLerpFactor_003E5__4 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime * 1.2f;
					float num3 = _003CanimationLerpFactor_003E5__4 + num2;
					_003CanimationLerpFactor_003E5__4 = num3;
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v33 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num5 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v49 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num6 = _003CanimationLerpFactor_003E5__4 * (float)Math.PI;
					float num7 = num6 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
					float t = default;
					float currentHeadstartIndicatorZRotation = Mathf.LerpUnclamped(_003CstartIndicatorRotation_003E5__2, _003CendIndicatorRotation_003E5__3, t);
					ingameScreen._currentHeadstartIndicatorZRotation = currentHeadstartIndicatorZRotation;
					obj2 = 0f;
					_ = 0f;
					_ = ingameScreen._currentHeadstartIndicatorZRotation;
					obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					nint num8 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v24 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num9 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v37 (Il2CppClass<UnityEngine.Quaternion>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					reference = ref *(Quaternion*)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Quaternion.Inverse_Injected(ref reference2, out reference);
					reference = ref *(Quaternion*)reference2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
					_ = 0;
					Vector3 localScale = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localScale;
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

	private sealed class _003CAnimateScoreboosterIndicatorGear_003Ed__126(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IngameScreen _003C_003E4__this;

		private float _003CstartIndicatorRotation_003E5__2;

		private float _003CendIndicatorRotation_003E5__3;

		private float _003CanimationLerpFactor_003E5__4;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0209: Expected Obj, but got Ref
				//IL_0217: Expected Obj, but got Ref
				//IL_0220: Expected Obj, but got I4
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Expected Obj, but got Unknown
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Expected Obj, but got Unknown
				//IL_0080: Expected F4, but got Obj
				//IL_0116: Expected I, but got Obj
				//IL_012c: Expected Obj, but got I
				//IL_02af: Expected Obj, but got F4
				//IL_02e2: Expected I, but got Obj
				//IL_02f8: Expected Obj, but got I
				//IL_0344: Expected Ref, but got VT
				//IL_035a: Expected Obj, but got Ref
				//IL_0364: Unknown result type (might be due to invalid IL or missing references)
				//IL_0369: Expected Obj, but got Unknown
				//IL_0372: Expected Obj, but got I4
				//IL_0386: Expected Obj, but got I4
				//IL_0157: Expected I, but got Obj
				//IL_01a4: Expected I, but got Obj
				ref Quaternion reference2 = default;
				ref Quaternion reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 40);
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 16));
				object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 28));
				obj2 = 0;
				_ = 0;
				IngameScreen ingameScreen = _003C_003E4__this;
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
					_003CstartIndicatorRotation_003E5__2 = ingameScreen._currentScoreBoosterIndicatorZRotation;
					object obj3 = ingameScreen._scoreBoosterGearZRotations + 16;
					int num = ingameScreen._currentScoreBoosterGear << 2;
					object obj4 = obj3 + num;
					_003CendIndicatorRotation_003E5__3 = (float)obj4;
					_003CanimationLerpFactor_003E5__4 = 0f;
				}
				if (_003CanimationLerpFactor_003E5__4 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime * 1.2f;
					float num3 = _003CanimationLerpFactor_003E5__4 + num2;
					_003CanimationLerpFactor_003E5__4 = num3;
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v33 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num5 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v49 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num6 = _003CanimationLerpFactor_003E5__4 * (float)Math.PI;
					float num7 = num6 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
					float t = default;
					float currentScoreBoosterIndicatorZRotation = Mathf.LerpUnclamped(_003CstartIndicatorRotation_003E5__2, _003CendIndicatorRotation_003E5__3, t);
					ingameScreen._currentScoreBoosterIndicatorZRotation = currentScoreBoosterIndicatorZRotation;
					obj2 = 0f;
					_ = 0f;
					_ = ingameScreen._currentScoreBoosterIndicatorZRotation;
					obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					nint num8 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v24 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num9 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v37 (Il2CppClass<UnityEngine.Quaternion>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					reference = ref *(Quaternion*)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Quaternion.Inverse_Injected(ref reference2, out reference);
					reference = ref *(Quaternion*)reference2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
					_ = 0;
					Vector3 localScale = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localScale;
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

	private const string ONLINESETTINGS_ALLOW_POWERUPS_ON_REVIVE_KEY = "consumables_allow_on_revive";

	private const bool ONLINESETTINGS_ALLOW_POWERUPS_ON_REVIVE_DEFAULT = true;

	private UILabel scoreLabel;

	private Vector3 _originalScoreLabelPosition;

	public UILabel multiplierLabel;

	public UIAnchor multiplierLabelAnchor;

	public UILabel coinLabel;

	public UISprite scoreBG;

	private int _originalWidthForScoreBG;

	private Transform _multiplier;

	private Vector3 _originalMultiplierPosition;

	public UISprite multiplierBG;

	public UISprite coinBG;

	public SlideinPowerupHelper slideinPowerupHelper;

	private bool _isMultiplierLabelUpdated;

	public Color SCOREBOOSTER_ACTIVE_COLOR;

	private Color SCOREBOOSTER_ELECTRICBLUE;

	private Color SCOREBOOSTER_WHITE;

	public Color MULTIPLIER_LABEL_ORIGINAL_COLOR;

	private UIWidget[] _widgetFrames;

	private GameObject _weeklyHuntCounter;

	private GameObject pauseButton;

	private GameObject debugPauseButton;

	private UILabel _huntAmountLabel;

	private UISprite _huntLabelBg;

	private Transform _huntIcon;

	private const float HUNT_BG_EXTRA_SCALE = -9f;

	private WeeklyHuntIconPositioning _huntBgPositioning;

	private GameObject _turboHeadstartUI;

	private Transform _turboHeadstartIndicator;

	private UISprite[] _turboHeadstartGearBackgrounds;

	private UILabel[] _turboHeadstartGearLabels;

	private UISprite[] _turboHeadstartGearsGlow;

	private UITexture _turboHeadstartBase;

	private UIPanel _turboHeadstartPanel;

	private int _currentHeadstartGear;

	private float _currentHeadstartIndicatorZRotation;

	private readonly int[] _turboHeadstartGearZRotations;

	private GameObject _scoreBoosterUI;

	private Transform _scoreBoosterIndicator;

	private UISprite[] _scoreBoosterGearBackgrounds;

	private UILabel[] _scoreBoosterGearLabels;

	private UISprite[] _scoreBoosterGearsGlow;

	private UITexture _scoreBoosterBase;

	private UIPanel _scoreBoosterPanel;

	private int _currentScoreBoosterGear;

	private float _currentScoreBoosterIndicatorZRotation;

	private readonly int[] _scoreBoosterGearZRotations;

	private bool _scoreboosterTimePeriodIsActive;

	private bool _jetpackIsActive;

	private const float ANIMATE_TO_NEXT_GEAR_SPEED_FACTOR = 1.2f;

	private const float ANIMATE_SPEEDOMETER_PANEL_ALPHA_SPEED_FACTOR = 3f;

	private const float ANIMATE_IN_SPEEDOMETER_GLOW_SPEED_FACTOR = 100f;

	private const float ANIMATE_OUT_SPEEDOMETER_GLOW_SPEED_FACTOR = 1.5f;

	private const float INACTIVE_SPEEDOMETER_ALPHA = 0.35f;

	private const float ACTIVE_SPEEDOMETER_ALPHA = 1f;

	private const float HIDDEN_SPEEDOMETER_ALPHA = 0f;

	private const int GEAR_GLOW_INITIAL_WIDTH = 40;

	private const int GEAR_GLOW_FINAL_WIDTH = 61;

	private const int GEAR_GLOW_INITIAL_HEIGHT = 46;

	private const int GEAR_GLOW_FINAL_HEIGHT = 70;

	private const int SCORE_ADJUST_GEAR_1_AMOUNT = 1000;

	private const int SCORE_ADJUST_GEAR_2_AMOUNT = 400;

	private const int SCORE_ADJUST_GEAR_3_AMOUNT = 250;

	private const float SCOREBOOSTER_TIMEPERIOD_THIRD_TIER = 3f;

	private int reviveCount__BackingField;

	private SpeedometerState _currentScoreboosterState;

	private SpeedometerState _currentHeadstartState;

	private static IngameScreen instance__BackingField;

	private WeeklyHuntData.WeeklyHuntPeriodData _currentWeekHuntPrize;

	private int _huntCollectedItems;

	private int _huntMaxItems;

	private bool _hasCalculatedHuntLabelOffsets;

	private float _huntLabelFrontOffset;

	private float _huntLabelBackOffset;

	private int score;

	private float lerpFactor;

	private float lerpFactorCoins;

	private bool doLastIteration;

	private int lastKnowDigits;

	private int digits;

	private const int DIGITS_THAT_FIT_WITHOUT_CHANGEING_THE_BOX_SIZE = 6;

	private const int DIST_PR_DIGIT = 11;

	private int _lastKnownMultiDigits;

	private int _multiDigits;

	public static bool allowPowerupsOnRevive
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<EventTesterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return EventTesterManager._instance != null;
		}
	}

	public unsafe int reviveCount
	{
		get
		{
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected Obj, but got Unknown
			//IL_02c1: Expected Obj, but got I4
			//IL_02cf: Expected I, but got Obj
			//IL_02e5: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected I, but got Unknown
			//IL_0395: Expected I, but got Obj
			//IL_03b0: Expected I, but got Obj
			//IL_03c6: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_032d: Expected I4, but got Obj
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 4;
			obj = 0;
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v55 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(SSEventType);
			nint num3 = (nint)(obj2 + 8);
			((IntPtr*)num3)->m_value = (void*)(nint)obj2;
			Type enumType = Type.internal_from_handle((IntPtr)num3);
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v12 (Il2CppClass<System.Enum>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v42 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			object obj5 = default;
			if (obj5 != null)
			{
				object obj6 = obj5 + 12;
				object obj7 = default;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
				{
					object obj8 = obj5 + 16;
					object obj9 = obj7 << 2;
					object obj10 = obj8 + obj9;
					obj = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					throw new NullReferenceException();
				}
			}
			return (int)list;
		}
		private set
		{
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_00e9: Expected Obj, but got I4
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected Obj, but got Unknown
			//IL_0100: Expected Obj, but got I4
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected Obj, but got Unknown
			//IL_0117: Expected Obj, but got I4
			//IL_012e: Expected I, but got Obj
			//IL_0144: Expected Obj, but got I
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected Obj, but got Unknown
			//IL_0177: Expected Obj, but got VT
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Expected Obj, but got Unknown
			//IL_01a2: Expected Obj, but got I8
			//IL_01b3: Expected Obj, but got VT
			//IL_0077: Expected Obj, but got I8
			//IL_0013: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 32;
			obj = 0;
			object obj3 = obj2 + 24;
			obj3 = 0;
			object obj4 = obj2 + 8;
			obj4 = 0;
			DateTime utcNow = CDateTime.UtcNow;
			nint num = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v40 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = obj2 + 16;
			obj6 = utcNow;
			string text = (string)(obj2 + 40);
			text = (string)obj6;
			long num3 = TimeUtility.RFC1123StringToUnixTime(text);
			obj = num3;
			DateTime utcNow2 = CDateTime.UtcNow;
			obj4 = utcNow2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9B");
			object obj7 = default;
			obj2 = obj7;
			text = (string)obj2;
			long num4 = TimeUtility.RFC1123StringToUnixTime(text);
			obj3 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D66F");
			string newValue = default;
			((EventTesterPopup)this).CheckDirty("event_start", newValue);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D66F");
			string newValue2 = default;
			((EventTesterPopup)this).CheckDirty("event_end", newValue2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D66F");
			string newValue3 = default;
			((EventTesterPopup)this).CheckDirty("event_id", newValue3);
		}
	}

	public unsafe static IngameScreen instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			return (IngameScreen)((OnlineSettings)(object)saveDataPath).TryGetValue("consumables_allow_on_revive", out *(string*)1);
		}
		private set
		{
			((UpgradeScreen)(object)value).Start();
		}
	}

	private int extraNumberOfChars
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			int num = default;
			object obj = num + 16;
			obj = this;
			return num;
		}
	}

	private void Awake()
	{
		instance__BackingField = this;
	}

	public override void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A44");
	}

	public unsafe void OnDestroy()
	{
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected Obj, but got Unknown
		//IL_0590: Expected Obj, but got I4
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_05e3: Expected I, but got Obj
		//IL_05f9: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00e6: Expected I, but got Obj
		//IL_00fc: Expected Obj, but got I
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_0127: Expected I, but got Obj
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected I4, but got Unknown
		//IL_0242: Expected I4, but got Obj
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I4
		//IL_02b2: Expected I4, but got Obj
		//IL_02db: Expected Obj, but got I
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0316: Expected VT, but got Obj
		//IL_0323: Expected I4, but got Obj
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got I4
		//IL_0373: Expected VT, but got Obj
		//IL_0380: Expected I4, but got Obj
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_03a2: Expected Obj, but got I4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_03e2: Expected F4, but got Obj
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03fc: Expected F4, but got Obj
		//IL_040a: Expected I, but got Obj
		//IL_0420: Expected Obj, but got I
		//IL_044b: Expected I, but got Obj
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04a3: Expected Obj, but got I4
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04eb: Expected Obj, but got I
		//IL_04f9: Expected I, but got Obj
		//IL_050f: Expected Obj, but got I
		//IL_06c7: Expected Obj, but got I4
		//IL_06dc: Expected Obj, but got I
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected Obj, but got Unknown
		//IL_053a: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 48;
		obj = 0;
		ShowIfInactive();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(IngameScreen.SetMultiplierLabel);
		object obj2 = action + 16;
		obj2 = this;
		nint num = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v111 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ScoreMultiplierInfo.onScoreMultiplierChanged -= action;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(IngameScreen.OnCoinsChanged);
		object obj4 = action2 + 16;
		obj4 = this;
		((GameStats)(object)privacyPolicyUrl).OnCoinsChanged -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(IngameScreen.OnGameStarted);
		object obj5 = action3 + 16;
		obj5 = this;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v107 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(IngameScreen.OnMenuScreenShown);
		object obj7 = action4 + 16;
		obj7 = this;
		Game.OnMenuScreenShown -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr5;
		((Delegate)action5).method = (nint)__ldftn(IngameScreen.OnGameRevived);
		object obj8 = action5 + 16;
		obj8 = this;
		Game.OnGameRevived -= action5;
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<bool> action6 = default;
		object obj9 = action6 + 16;
		obj9 = this;
		((Game)isInstantiated).OnPauseChange -= action6;
		object obj10 = transform + 32;
		object obj11 = this + 156;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S2_v17+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(transform + 56);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v54+8]");
		_ = 0;
		multiplierLabel.rawPivot = pivot;
		object obj12 = transform + 24;
		bool allowSellConsumablesDuringRun = SellConsumable.allowSellConsumablesDuringRun;
		obj12 = allowSellConsumablesDuringRun;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "x" + text2;
		multiplierLabel.fontSize = (int)text;
		FadeFromWhiteToDarkBlue();
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S2_v34 (System.String)+74]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		scoreLabel.fontSize = fontSize;
		Transform transform2 = (Transform)(transform + 12);
		transform2.localPosition = (Vector3)_multiplier;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj13 = this + 80;
		obj13 = ((UIWidget.Pivot*)(int)pivot)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v57 (UIWidget+Pivot)+8]");
		_ = 0;
		Camera anchorCamera = scoreLabel.anchorCamera;
		transform.localPosition = (Vector3)anchorCamera;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj14 = this + 44;
		obj14 = ((UIWidget.Pivot*)(int)pivot)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v57 (UIWidget+Pivot)+8]");
		_ = 0;
		UISprite uISprite = scoreBG;
		_originalWidthForScoreBG = ((UIWidget)uISprite).mWidth;
		object obj15 = _scoreBoosterGearZRotations + 16;
		_currentScoreBoosterIndicatorZRotation = (float)obj15;
		object obj16 = _turboHeadstartGearZRotations + 16;
		_currentHeadstartIndicatorZRotation = (float)obj16;
		nint num6 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v77 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num7 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v103 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			return;
		}
		object obj18 = _widgetFrames + 12;
		object obj19 = 0;
		while (true)
		{
			obj = obj19;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18))
			{
				break;
			}
			object obj20 = _widgetFrames + 16;
			object obj21 = obj19 << 2;
			object obj22 = obj20 + obj21;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v96+18]");
			object obj24 = 0;
			nint num8 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S1_v118 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num9 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S1_v129 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isiPhoneXDevice = IPhoneXSupport.IsiPhoneXDevice;
			object obj26 = 0 - (isiPhoneXDevice ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v96+14]");
			object obj27 = 0;
			_ = IPhoneXSupport.OFFSET_BOTTOM;
			object obj28 = obj + 1;
			obj19 = obj28;
		}
	}

	private void OnPauseChange(bool pause)
	{
		reviveCount__BackingField = (pause ? 1 : 0);
	}

	public unsafe override void Show()
	{
		//IL_01fa: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_021b: Expected I, but got Obj
		//IL_0231: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_00ff: Expected I, but got Obj
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		SellableConsumable sellableConsumable = default;
		sellableConsumable.upgradeType__BackingField = (UpgradeType)num;
		sellableConsumable.header__BackingField = (string)0;
		object obj = sellableConsumable + 16;
		obj = this;
		nint num2 = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v51 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SellConsumable.activeConsumable = sellableConsumable;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<int> action = default;
		object obj3 = action + 16;
		obj3 = this;
		((GameStats)(object)privacyPolicyUrl).OnCoinsIncreased += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<bool, bool, bool, bool> action2 = default;
		object obj4 = action2 + 16;
		obj4 = this;
		nint num6 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v26 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v47 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnRunStarted += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr;
		((Delegate)action3).method = (nint)__ldftn(IngameScreen.OnMenuScreenShown);
		object obj6 = action3 + 16;
		obj6 = this;
		Game.OnGameDestroyed += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<bool> action4 = default;
		object obj7 = action4 + 16;
		obj7 = this;
		Game.OnPlayerDied += action4;
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr2;
		((Delegate)action5).method = (nint)__ldftn(IngameScreen.OnPauseChange);
		object obj8 = action5 + 16;
		obj8 = this;
		((Game)isInstantiated).OnStageMenuSequence += action5;
	}

	public unsafe override void Hide()
	{
		//IL_081f: Expected I, but got Obj
		//IL_0835: Expected Obj, but got I
		//IL_0869: Expected I, but got Obj
		//IL_087f: Expected Obj, but got I
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected I4, but got Unknown
		//IL_08b4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_0971: Expected I, but got Obj
		//IL_0987: Expected Obj, but got I
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_0bbc: Expected Obj, but got I4
		//IL_04a6: Expected I, but got Obj
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_022b: Expected I4, but got Obj
		//IL_0255: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_018c: Expected I, but got Obj
		//IL_052a: Expected I, but got Obj
		//IL_0540: Expected Obj, but got I
		//IL_0a76: Expected Obj, but got I4
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Expected Obj, but got Unknown
		//IL_0aaf: Expected I, but got Obj
		//IL_0ac5: Expected Obj, but got I
		//IL_02e4: Expected I4, but got Obj
		//IL_02f2: Expected I, but got Obj
		//IL_0308: Expected Obj, but got I
		//IL_0296: Expected I, but got Obj
		//IL_0af9: Expected I, but got Obj
		//IL_0b0f: Expected Obj, but got I
		//IL_056b: Expected I, but got Obj
		//IL_05b8: Expected I, but got Obj
		//IL_0333: Expected I, but got Obj
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected Obj, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_069c: Expected Obj, but got I
		//IL_0605: Expected I, but got Obj
		//IL_0380: Expected I, but got Obj
		//IL_0396: Expected Obj, but got I
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_073d: Expected I, but got Obj
		//IL_0753: Expected Obj, but got I
		//IL_03c1: Expected I, but got Obj
		//IL_0b64: Expected I, but got Obj
		//IL_0b7a: Expected Obj, but got I
		//IL_040e: Expected I, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_077e: Expected I, but got Obj
		//IL_0a3b: Expected Obj, but got I4
		//IL_07cb: Expected I, but got Obj
		//IL_044f: Expected I, but got Obj
		base.Hide();
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v159 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v133 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 16);
		if ((UnityEngine.Object)isInstantiated != null)
		{
			SDebug.LogFormat("You must be running the wrong scene", null);
			return;
		}
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v20 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v153 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v25 (System.Boolean)+C4]");
		if ((nint)0 != 0)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v140 (Il2CppClass<UIScreenController>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v149 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v145 (System.Boolean)+58]");
			if ((nint)0 != 0)
			{
				DeviceInfo deviceInfo = DeviceInfo.Instance;
				((CountdownPopupManager)(object)deviceInfo).StopCountdown();
			}
		}
		DeviceInfo deviceInfo2 = DeviceInfo.Instance;
		if (deviceInfo2.deviceModel == null)
		{
			StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
			((MissionsManager)(object)stayInOneLaneMission).RemoveProgressForThis(MissionTarget.EarnCoin);
			object obj6 = this + 156;
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S2_v20+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			multiplierLabel.rawPivot = pivot;
			nint num9 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v81 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v126 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool allowSellConsumablesDuringRun = SellConsumable.allowSellConsumablesDuringRun;
			((UIWidget.Pivot*)(int)pivot)->value__ = (allowSellConsumablesDuringRun ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text = "x" + text2;
			multiplierLabel.fontSize = (int)text;
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S1_v122 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_weeklyHuntCounter).FindKernel((string)null) != 0)
			{
				nint num13 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S1_v99 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num14 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S1_v118 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text3;
				if (WeeklyHuntManager.CanSpawnToken())
				{
					nint num15 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S1_v108 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num16 = (nint)typeof(WeeklyHuntManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S1_v114 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag2 = WeeklyHuntManager.IsHuntStillActive();
					text3 = (string)flag2;
				}
				else
				{
					text3 = null;
				}
				_weeklyHuntCounter.tag = text3;
			}
		}
		nint num17 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v34 (Il2CppClass<SocialManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num18 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v124 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		((SocialManager)facebookDialogsSupported).UpdateRemoteNotificationControl(newValue: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
		OnHeadstartActivated(1);
		nint num19 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v22 (Il2CppClass<Globals>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num20 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S1_v66 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_TIMESCALE_PAUSE_BUTTON = Globals.DEBUG_USE_TIMESCALE_PAUSE_BUTTON;
		debugPauseButton.tag = (string)dEBUG_USE_TIMESCALE_PAUSE_BUTTON;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num21 = 0;
		_ = 0;
		Action<int> action = default;
		object obj14 = action + 16;
		obj14 = this;
		nint num22 = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v56 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num23 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v119 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SlideinPowerupHelper.OnHeadstartActivated -= action;
		nint num24 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v62 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num25 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v115 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj17 = default;
		obj17.method_ptr = method_ptr;
		obj17.method = (nint)__ldftn(IngameScreen.OnHeadstartDeactivated);
		object obj18 = obj17 + 16;
		obj18 = this;
		object obj19 = ex + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v68 (System.ArrayTypeMismatchException)+80]");
		Delegate obj20 = ((Delegate)0).CombineImpl(obj17);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj21 = default;
		obj19 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num26 = 0;
		_ = 0;
		Action<int> action2 = default;
		object obj22 = action2 + 16;
		obj22 = this;
		SlideinPowerupHelper.OnScoreBoostActivated -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(IngameScreen.OnGameReviveOffer);
		object obj23 = action3 + 16;
		obj23 = this;
		nint num27 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v95 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num28 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v111 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameReviveOffer -= action3;
		nint num29 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v101 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num30 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S0_v107 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = IPhoneXSupport.CheckIsiPhoneXDevice();
	}

	public void SetPauseButtonVisibility(bool isActive)
	{
		//IL_00cd: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		if (isActive)
		{
			return;
		}
		string text = tag;
		if (!((GameObject)(object)text).activeInHierarchy)
		{
			return;
		}
		string text2 = tag;
		string text3 = ((GameObject)(object)text2).tag;
		if (text3 != null)
		{
			if (_currentHeadstartState == SpeedometerState.active)
			{
				DeactivateGears((UISprite[])(object)_turboHeadstartPanel, (UILabel[])1);
			}
			if (_currentScoreboosterState == SpeedometerState.active)
			{
				DeactivateGears((UISprite[])(object)_scoreBoosterPanel, (UILabel[])2);
			}
		}
	}

	public unsafe void ToggleDebugPauseTimescale()
	{
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I4
		//IL_005d: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_047f: Expected I, but got Obj
		//IL_0495: Expected Obj, but got I
		//IL_04c9: Expected I, but got Obj
		//IL_04df: Expected Obj, but got I
		//IL_014a: Expected I, but got Obj
		//IL_0197: Expected I, but got Obj
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I
		//IL_01e4: Expected I, but got Obj
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0330: Expected I, but got Obj
		//IL_0346: Expected Obj, but got I
		//IL_0534: Expected I, but got Obj
		//IL_054a: Expected Obj, but got I
		//IL_0371: Expected I, but got Obj
		//IL_03be: Expected I, but got Obj
		base.LoseFocus();
		FadeFromWhiteToDarkBlue();
		DeviceInfo deviceInfo = DeviceInfo.Instance;
		((CountdownPopupManager)(object)deviceInfo).CountdownEnded();
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v113 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		((SocialManager)facebookDialogsSupported).UpdateRemoteNotificationControl(newValue: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj2 = default;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		WeeklyHuntProgressData weeklyHuntProgressData = default;
		weeklyHuntProgressData.huntStartVersion = (string)num3;
		_ = 0;
		object obj3 = weeklyHuntProgressData + 16;
		obj3 = this;
		nint num4 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v26 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v108 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		weeklyHuntProgressData._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<int> action = default;
		object obj5 = action + 16;
		obj5 = this;
		nint num7 = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v41 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v104 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SlideinPowerupHelper.OnScoreBoostActivated += action;
		nint num9 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v47 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v100 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj8 = default;
		obj8.method_ptr = method_ptr;
		obj8.method = (nint)__ldftn(IngameScreen.OnHeadstartDeactivated);
		object obj9 = obj8 + 16;
		obj9 = this;
		object obj10 = ex + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v53 (System.ArrayTypeMismatchException)+80]");
		Delegate obj11 = ((Delegate)0).RemoveImpl(obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj12 = default;
		obj10 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(IngameScreen.OnScoreboosterActivated);
		object obj13 = action2 + 16;
		obj13 = this;
		SlideinPowerupHelper.OnButtonsShow += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(IngameScreen.OnGameReviveOffer);
		object obj14 = action3 + 16;
		obj14 = this;
		nint num11 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v80 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num12 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v96 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameEnded += action3;
		nint num13 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v86 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num14 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v92 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = IPhoneXSupport.CheckIsiPhoneXDevice();
	}

	private void SetMultiplierLabel()
	{
		//IL_00b6: Expected VT, but got Obj
		//IL_00d7: Expected VT, but got Obj
		//IL_0052: Expected VT, but got Obj
		//IL_0060: Expected VT, but got Obj
		//IL_002c: Expected Obj, but got VT
		//IL_00a8: Expected F4, but got I
		//IL_00a8: Expected Obj, but got VT
		//IL_008e: Expected F4, but got I
		//IL_008e: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag = realtimeSinceStartup > 0f;
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		if (flag)
		{
			((TimeScaleManager)val2).TimeScaleInMenuDefault = 0f;
			return;
		}
		float realtimeSinceStartup2 = Time.realtimeSinceStartup;
		bool flag2 = realtimeSinceStartup2 == 0f;
		_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		_00210 val4 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v13 (T)+14]");
			((TimeScaleManager)val3).TimeScaleInMenuDefault = 0f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v13 (T)+10]");
			((TimeScaleManager)val3).TimeScaleInMenuDefault = 0f;
		}
	}

	private unsafe void FadeFromWhiteToDarkBlue()
	{
		//IL_02e1: Expected I, but got Obj
		//IL_02f7: Expected Obj, but got I
		//IL_04b6: Expected Obj, but got I4
		//IL_00f3: Expected I4, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_0370: Expected I4, but got Obj
		//IL_0322: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_004c: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_021b: Expected I, but got Obj
		//IL_0231: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_008d: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I4
		//IL_02aa: Expected I4, but got Obj
		//IL_025c: Expected I, but got Obj
		//IL_0433: Expected Obj, but got I4
		//IL_045e: Expected I4, but got Obj
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (System.String)+64]");
		if ((nint)0 == 0)
		{
			string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v55 (System.String)+70]");
			if ((nint)0 == 0)
			{
				nint num = (nint)typeof(PlusMultiplier);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v59 (Il2CppClass<PlusMultiplier>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(PlusMultiplier);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v67 (Il2CppClass<PlusMultiplier>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(PlusMultiplier.plusMultiplierEnabled ? 1u : 0u) != 0)
				{
					goto IL_02d3;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A02");
		object obj2 = default;
		if (obj2 != null)
		{
			goto IL_02d3;
		}
		UILabel uILabel = multiplierLabel;
		UILabel uILabel2 = multiplierLabel;
		int num3 = uILabel2.mText.LastIndexOf((char)(int)"x");
		char[] trimChars = (char[])(num3 + 1);
		string text = uILabel.mText.Trim(trimChars);
		TypeCode typeCode = ((int*)text)->GetTypeCode();
		nint num4 = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v21 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v44 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int rawMultiplier = ScoreMultiplierInfo.rawMultiplier;
		object obj4;
		if ((int)typeCode < rawMultiplier)
		{
			bool flag = lerpFactor > 1f;
			bool flag2 = !flag;
			TypeCode typeCode2 = typeCode;
			if (!flag2)
			{
				TypeCode typeCode3 = typeCode + 1;
				typeCode2 = typeCode3;
			}
			_isMultiplierLabelUpdated = false;
			doLastIteration = false;
			obj4 = typeCode2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text3 = default;
			string text2 = "x" + text3;
			multiplierLabel.fontSize = (int)text2;
		}
		else
		{
			nint num6 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v14 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num7 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v28 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int rawMultiplier2 = ScoreMultiplierInfo.rawMultiplier;
			obj4 = rawMultiplier2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text5 = default;
			string text4 = "x" + text5;
			multiplierLabel.fontSize = (int)text4;
			if (~(doLastIteration ? 1u : 0u) == 0)
			{
				_isMultiplierLabelUpdated = true;
			}
			doLastIteration = true;
		}
		goto IL_0375;
		IL_0375:
		SincronizeHuntData();
		return;
		IL_02d3:
		nint num8 = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v48 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v59 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int rawMultiplier3 = ScoreMultiplierInfo.rawMultiplier;
		obj4 = rawMultiplier3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text7 = default;
		string text6 = "x" + text7;
		multiplierLabel.fontSize = (int)text6;
		goto IL_0375;
	}

	public unsafe void ResetMultiplierLabelColour()
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected I4, but got Unknown
		//IL_01cd: Expected I4, but got Obj
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected I4, but got Unknown
		//IL_01f5: Expected I4, but got Obj
		//IL_0219: Expected Ref, but got VT
		//IL_022b: Expected I4, but got F4
		//IL_025c: Expected I, but got Obj
		//IL_0272: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00d1: Expected I4, but got Obj
		//IL_00eb: Expected I4, but got Obj
		//IL_010f: Expected Ref, but got VT
		//IL_0121: Expected I4, but got F4
		Matrix4x4 matrix4x = default;
		object obj = matrix4x + 48;
		obj = 0;
		object obj2 = matrix4x + 32;
		object obj3 = this + 140;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v3+8]");
		_ = 0;
		object obj4 = matrix4x + 16;
		object obj5 = this + 124;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v9+8]");
		_ = 0;
		int num = matrix4x + 56;
		((int*)num)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v6+8]");
		_ = 0;
		int num2 = matrix4x + 72;
		((int*)num2)->m_value = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v9+8]");
		_ = 0;
		((Matrix4x4*)matrix4x)->set_Item(num, num2, lerpFactor);
		((int*)num2)->m_value = (int)matrix4x.m00;
		_ = matrix4x.m20;
		multiplierLabel.rawPivot = (UIWidget.Pivot)num2;
		UILabel uILabel = multiplierLabel;
		nint num3 = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v24 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v46 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int rawMultiplier = ScoreMultiplierInfo.rawMultiplier;
		obj = rawMultiplier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string value = default;
		if (uILabel.mText.EndsWith(value) && ~(doLastIteration ? 1u : 0u) == 0)
		{
			object obj7 = this + 140;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S2_v36+8]");
			_ = 0;
			object obj8 = this + 108;
			obj4 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S2_v41+8]");
			_ = 0;
			((int*)num)->m_value = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v6+8]");
			_ = 0;
			((int*)num2)->m_value = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v9+8]");
			_ = 0;
			((Matrix4x4*)matrix4x)->set_Item(num, num2, lerpFactor);
			((int*)num2)->m_value = (int)matrix4x.m00;
			_ = matrix4x.m20;
			multiplierLabel.rawPivot = (UIWidget.Pivot)num2;
		}
	}

	private void OnHeadstartActivated(int headstartTier)
	{
		//IL_000f: Expected Obj, but got I4
		pauseButton.tag = (string)headstartTier;
	}

	private unsafe void OnHeadstartDeactivated()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_019b: Expected I4, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00d7: Expected I4, but got Obj
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0143: Expected I4, but got Obj
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 48);
		Gradient gradient = (Gradient)(obj + 32);
		object obj2 = obj + 16;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (System.String)+64]");
		if ((nint)0 == 0)
		{
			string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v19 (System.String)+70]");
			if ((nint)0 == 0)
			{
				object obj3 = multiplierLabel + 80;
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v13+8]");
				_ = 0;
				object obj4 = this + 156;
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v18+8]");
				_ = 0;
				gradient = (Gradient)obj2;
				Gradient gradient2 = gradient;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
				gradient2.m_Ptr = (IntPtr)0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				if (gradient.Internal_Equals((IntPtr)(nint)pivot))
				{
					object obj5 = this + 156;
					gradient = (Gradient)obj5;
					Gradient gradient3 = gradient;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S2_v17+8]");
					gradient3.m_Ptr = (IntPtr)0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)gradient;
					_ = gradient.m_Ptr;
					multiplierLabel.rawPivot = pivot;
				}
				return;
			}
		}
		object obj6 = this + 108;
		gradient = (Gradient)obj6;
		Gradient gradient4 = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v3+8]");
		gradient4.m_Ptr = (IntPtr)0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)gradient;
		_ = gradient.m_Ptr;
		multiplierLabel.rawPivot = pivot;
	}

	private void SetScoreboosterTimePeriodIsActive()
	{
		//IL_004b: Expected I4, but got Obj
		//IL_004b: Expected Obj, but got I4
		//IL_004b: Expected VT, but got I4
		//IL_004b: Expected VT, but got I4
		//IL_0067: Expected I4, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_0067: Expected VT, but got I4
		//IL_0067: Expected VT, but got I4
		_jetpackIsActive = false;
		if (~(_scoreboosterTimePeriodIsActive ? 1u : 0u) != 0)
		{
			PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentHeadstartState, (PrizePositionData.TransformValues?)(object)2, (UIWidget)1, (byte)(int)_turboHeadstartPanel != 0);
			PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentScoreboosterState, (PrizePositionData.TransformValues?)(object)2, (UIWidget)2, (byte)(int)_scoreBoosterPanel != 0);
		}
	}

	private void OnScoreboosterActivated(int scoreboosterTier)
	{
		//IL_0031: Expected I4, but got Obj
		//IL_0031: Expected Obj, but got I4
		//IL_0031: Expected VT, but got I4
		//IL_0031: Expected VT, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_018e: Expected I4, but got Obj
		//IL_018e: Expected Obj, but got I4
		//IL_018e: Expected VT, but got I4
		//IL_018e: Expected VT, but got I4
		_jetpackIsActive = true;
		_currentHeadstartGear = scoreboosterTier;
		PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentHeadstartState, (PrizePositionData.TransformValues?)(object)1, (UIWidget)1, (byte)(int)_turboHeadstartPanel != 0);
		AnimateScoreboosterIndicator();
		SetActiveGears(PowerUpType.headstart, _currentHeadstartGear, _turboHeadstartGearsGlow, _turboHeadstartGearBackgrounds, _turboHeadstartGearLabels);
		object obj = _currentHeadstartGear - 1;
		if (_currentHeadstartGear != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v24 (System.String)+80]");
					object obj2 = (nint)0 + (nint)250;
				}
			}
			else
			{
				string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v22 (System.String)+80]");
				object obj3 = (nint)0 + (nint)400;
			}
		}
		else
		{
			string privacyPolicyUrl3 = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v20 (System.String)+80]");
			object obj4 = (nint)0 + (nint)1000;
		}
		if (_currentScoreboosterState == SpeedometerState.hidden)
		{
			if (_currentScoreBoosterGear < 1)
			{
				PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentScoreboosterState, (PrizePositionData.TransformValues?)(object)0, (UIWidget)2, (byte)(int)_scoreBoosterPanel != 0);
			}
			else
			{
				this._002Ector();
			}
		}
	}

	private void DeactivateScoreboosterSpeedometer()
	{
		_scoreboosterTimePeriodIsActive = false;
	}

	private void ChangeSpeedometerState(SpeedometerState currentState, SpeedometerState nextState, PowerUpType powerUpType, UIPanel speedometerPanel)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_006c: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingsCell debugSettingsCell = default;
		debugSettingsCell.cellType = DebugSettingsCellType.Button;
		object obj = debugSettingsCell + 16;
		obj = currentState;
		object obj2 = debugSettingsCell + 20;
		obj2 = nextState;
		object obj3 = debugSettingsCell + 24;
		obj3 = powerUpType;
		debugSettingsCell.cellButtonIcon = (ButtonIcon)speedometerPanel;
		((List<DebugSettingsCell>)(object)coinBG).Add(debugSettingsCell);
	}

	private float GetCorrespondingAlphaValue(SpeedometerState state)
	{
		//IL_0119: Expected VT, but got Obj
		//IL_0121: Expected F4, but got Obj
		//IL_0135: Expected VT, but got Obj
		//IL_0145: Expected F4, but got I
		//IL_0159: Expected VT, but got Obj
		//IL_0166: Expected F4, but got I
		//IL_017a: Expected VT, but got Obj
		//IL_0182: Expected F4, but got Obj
		//IL_0196: Expected VT, but got Obj
		//IL_01a6: Expected F4, but got I
		//IL_01ba: Expected VT, but got Obj
		//IL_01c7: Expected F4, but got I
		//IL_01db: Expected VT, but got Obj
		//IL_01e3: Expected F4, but got Obj
		//IL_01f7: Expected VT, but got Obj
		//IL_0207: Expected F4, but got I
		//IL_021b: Expected VT, but got Obj
		//IL_0228: Expected F4, but got I
		Transform transform = default;
		switch (state)
		{
		case SpeedometerState.inactive:
			transform.localPosition = (Vector3)_footerPrefab;
			return (float)transform;
		case SpeedometerState.active:
			transform.localPosition = (Vector3)_footerPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			return 0f;
		case SpeedometerState.hidden:
			transform.localPosition = (Vector3)_footerPrefab;
			return (nint)((UnityEngine.Object)transform).m_CachedPtr;
		case (SpeedometerState)3:
			transform.localRotation = (Quaternion)_footerPrefab;
			return (float)transform;
		case (SpeedometerState)4:
			transform.localRotation = (Quaternion)_footerPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			return 0f;
		case (SpeedometerState)5:
			transform.localRotation = (Quaternion)_footerPrefab;
			return (nint)((UnityEngine.Object)transform).m_CachedPtr;
		case (SpeedometerState)6:
			transform.localScale = (Vector3)_footerPrefab;
			return (float)transform;
		case (SpeedometerState)7:
			transform.localScale = (Vector3)_footerPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			return 0f;
		case (SpeedometerState)8:
			transform.localScale = (Vector3)_footerPrefab;
			return (nint)((UnityEngine.Object)transform).m_CachedPtr;
		default:
			return 0f;
		}
	}

	private IEnumerator AnimateSpeedoMeterPanel(PowerUpType type, SpeedometerState nextState, float startValue, float endValue, UIPanel uiSpeedoMeterPanel)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private void ToggleSpeedoMeterActive(SpeedometerState state, PowerUpType type)
	{
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got VT
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0 && ((string)state).get_Chars((int)type) != '\0')
		{
			((GameObject)_originalMultiplierPosition).tag = (string)1;
			((GameObject)(object)_multiplier).tag = null;
		}
	}

	private void OnGameReviveOffer()
	{
		//IL_0098: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_0098: Expected VT, but got I4
		//IL_0098: Expected VT, but got I4
		//IL_00b4: Expected I4, but got Obj
		//IL_00b4: Expected Obj, but got I4
		//IL_00b4: Expected VT, but got I4
		//IL_00b4: Expected VT, but got I4
		string text = tag;
		if (((GameObject)(object)text).activeInHierarchy && ((_currentHeadstartState == SpeedometerState.active && !_jetpackIsActive) || _currentHeadstartState == SpeedometerState.inactive))
		{
			PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentHeadstartState, (PrizePositionData.TransformValues?)(object)2, (UIWidget)1, (byte)(int)_turboHeadstartPanel != 0);
			PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentScoreboosterState, (PrizePositionData.TransformValues?)(object)2, (UIWidget)2, (byte)(int)_scoreBoosterPanel != 0);
		}
	}

	private unsafe void SpeedometerPauseHandle(UIPanel uiPanel, PowerUpType powerUpType)
	{
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected VT, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_03f0: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I4
		//IL_043c: Expected F4, but got VT
		//IL_0437: Expected native int or pointer, but got VT
		//IL_0219: Expected Obj, but got I4
		//IL_0227: Expected I, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got F4
		//IL_04f1: Expected F4, but got Obj
		//IL_04ec: Expected native int or pointer, but got VT
		//IL_050b: Expected F4, but got Obj
		//IL_0506: Expected native int or pointer, but got VT
		//IL_0520: Expected F4, but got I
		//IL_051b: Expected native int or pointer, but got VT
		//IL_052f: Expected I4, but got VT
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0548: Expected Obj, but got I4
		//IL_0147: Expected I, but got Obj
		//IL_041c: Expected F4, but got VT
		//IL_0417: Expected native int or pointer, but got VT
		//IL_00d6: Expected I, but got Obj
		//IL_04a3: Expected F4, but got VT
		//IL_049e: Expected native int or pointer, but got VT
		//IL_0555: Expected Obj, but got F4
		//IL_0562: Expected F4, but got Obj
		//IL_055d: Expected native int or pointer, but got VT
		//IL_057c: Expected F4, but got Obj
		//IL_0577: Expected native int or pointer, but got VT
		//IL_0591: Expected F4, but got I
		//IL_058c: Expected native int or pointer, but got VT
		//IL_05a0: Expected I4, but got VT
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05b9: Expected Obj, but got I4
		//IL_0308: Expected I, but got Obj
		//IL_0483: Expected F4, but got VT
		//IL_047e: Expected native int or pointer, but got VT
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_0297: Expected I, but got Obj
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_037f: Expected Obj, but got I4
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 24);
		object obj2 = obj + 20;
		object obj3 = obj + 16;
		bool flag = (nint)uiPanel == 1;
		object obj4 = powerUpType - 1;
		if (powerUpType != PowerUpType.headstart)
		{
			if ((nint)obj4 != 1)
			{
				return;
			}
			_scoreBoosterUI.tag = (string)1;
			string text = _scoreBoosterIndicator.tag;
			((GameObject)(object)text).tag = (string)flag;
			nint num = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v37 (Il2CppClass<GlobalColors>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			bool flag2 = obj5 == null;
			float m;
			if (flag)
			{
				if (!flag2)
				{
					nint num2 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S2_v76 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.ACTIVE_SCOREBOOSTER_GEAR_COUNT_COLOR;
				m = matrix4x.m00;
			}
			else
			{
				if (!flag2)
				{
					nint num3 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S2_v64 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.INACTIVE_GEAR_BACKGROUND_COLOR;
				m = matrix4x.m00;
			}
			obj3 = m;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Matrix4x4 matrix4x3 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
			_scoreBoosterBase.rawPivot = (UIWidget.Pivot)matrix4x;
			object obj6 = _scoreBoosterGearLabels + 12;
			object obj7 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				object obj8 = _scoreBoosterGearLabels + 16;
				object obj9 = obj7 << 2;
				object obj10 = obj8 + obj9;
				((Component)obj10).tag = (string)flag;
				object obj11 = obj7 + 1;
				obj7 = obj11;
			}
			_currentScoreboosterState = (flag ? SpeedometerState.active : SpeedometerState.inactive);
			return;
		}
		_turboHeadstartUI.tag = (string)1;
		string text2 = _turboHeadstartIndicator.tag;
		((GameObject)(object)text2).tag = (string)flag;
		nint num4 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v13 (Il2CppClass<GlobalColors>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		bool flag3 = obj12 == null;
		float m2;
		if (flag)
		{
			if (!flag3)
			{
				nint num5 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S2_v36 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.ACTIVE_HEADSTART_GEAR_COUNT_COLOR;
			m2 = matrix4x.m00;
		}
		else
		{
			if (!flag3)
			{
				nint num6 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S2_v24 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.INACTIVE_GEAR_BACKGROUND_COLOR;
			m2 = matrix4x.m00;
		}
		obj2 = m2;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Matrix4x4 matrix4x5 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
		_turboHeadstartBase.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj13 = _turboHeadstartGearLabels + 12;
		object obj14 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
		{
			object obj15 = _turboHeadstartGearLabels + 16;
			object obj16 = obj14 << 2;
			object obj17 = obj15 + obj16;
			((Component)obj17).tag = (string)flag;
			object obj18 = obj14 + 1;
			obj14 = obj18;
		}
		_currentHeadstartState = (flag ? SpeedometerState.active : SpeedometerState.inactive);
	}

	private IEnumerator AnimatePanelAlpha(float startValue, float endValue, UIPanel uiSpeedoMeterPanel)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private IEnumerator AnimateSpriteColor(UISprite spriteToAnimate, Color32 startValue, Color32 endValue, float speedFactor)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 24;
		obj2 = spriteToAnimate;
		object obj3 = startValue.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startValue @ L2 (UnityEngine.Color32)+8]");
		_ = 0;
		object obj4 = enumerator + 28;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj3 = endValue.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [endValue @ L3 (UnityEngine.Color32)+8]");
		_ = 0;
		object obj5 = enumerator + 44;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return enumerator;
	}

	private IEnumerator AnimateSpriteSize(UISprite spriteToAnimate, int startHeightValue, int endHeightValue, int startWidthValue, int endWidthValue, float speedFactor)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private unsafe void AnimateGearAndGlow(PowerUpType type, int currentGear, UISprite[] gearGlows, UISprite[] gearBackgrounds, UILabel[] gearLabels)
	{
		//IL_0276: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected I, but got Unknown
		//IL_02a4: Expected I, but got Obj
		//IL_02bf: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		TypeCode typeCode = ((int*)gearLabels)->GetTypeCode();
		reviveCount = (int)typeCode;
		((EventTesterPopup)this).CheckDirty("event_type", (string)type);
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v55 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(SSEventType);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type type2 = Type.internal_from_handle((IntPtr)num3);
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v14 (Il2CppClass<System.Enum>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v29 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((Enum)(object)type2).ToString((string)type, (IFormatProvider)1);
		throw new NullReferenceException();
	}

	private unsafe void SetActiveGears(PowerUpType type, int currentGear, UISprite[] gearGlows, UISprite[] gearBackgrounds, UILabel[] gearLabels)
	{
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got VT
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected VT, but got Unknown
		//IL_0214: Expected F4, but got Obj
		//IL_020f: Expected native int or pointer, but got VT
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_023c: Expected F4, but got Obj
		//IL_0237: Expected native int or pointer, but got VT
		//IL_0251: Expected F4, but got I
		//IL_024c: Expected native int or pointer, but got VT
		//IL_025e: Expected I4, but got VT
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got VT
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got VT
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected VT, but got Unknown
		//IL_00e2: Expected I4, but got Obj
		//IL_00dd: Expected native int or pointer, but got VT
		//IL_00ef: Expected F4, but got Obj
		//IL_00ea: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		int num = currentGear << 2;
		object obj = gearGlows + num;
		object obj2 = obj + 12;
		nint num2 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<GlobalColors>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v53 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 36;
		obj4 = GlobalColors.FINAL_GEAR_GLOW_COLOR;
		object obj6 = obj5 + 32;
		obj6 = obj4;
		Matrix4x4 matrix4x = (Matrix4x4)(obj5 + 48);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		object obj7 = obj5 + 16;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v18+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)obj2).rawPivot = (UIWidget.Pivot)matrix4x;
		int num4 = currentGear << 2;
		object obj8 = gearBackgrounds + num4;
		object background = obj8 + 12;
		int num5 = currentGear << 2;
		object obj9 = gearLabels + num5;
		object count = obj9 + 12;
		((IngameScreen)null).ActivateGearNoAnimation(type, (UISprite)background, (UILabel)count);
		int num6 = currentGear << 2;
		object obj10 = gearGlows + num6;
		object spriteToAnimate = obj10 + 12;
		object obj11 = obj5 + 12;
		obj11 = GlobalColors.FINAL_GEAR_GLOW_COLOR;
		object obj12 = obj5 + 4;
		obj12 = GlobalColors.INITIAL_GEAR_GLOW_COLOR;
		object obj13 = obj5 + 8;
		obj13 = obj11;
		obj5 = obj12;
		Color32 color = (Color32)(obj5 + 40);
		((Color32*)(nint)color)->rgba = (int)obj13;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		IEnumerator list = ((SlideinPowerupButton)null).AnimateSpriteColor((UISprite)spriteToAnimate, color, (Color32)matrix4x, 1.5f);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
		int num7 = currentGear << 2;
		object obj14 = gearGlows + num7;
		object obj15 = obj14 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A5E");
		YieldInstruction[] list2 = default;
		Coroutine coroutine2 = CoroutineUtil.WaitForAll(list2);
	}

	private void HideTurboHeadstartSpeedoMeter()
	{
		//IL_0054: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I4
		//IL_0054: Expected VT, but got I4
		//IL_0054: Expected VT, but got I4
		//IL_00a2: Expected I4, but got Obj
		//IL_00a2: Expected Obj, but got I4
		//IL_00a2: Expected VT, but got I4
		//IL_00a2: Expected VT, but got I4
		OnHeadstartActivated(0);
		if (_currentScoreboosterState != SpeedometerState.hidden)
		{
			PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentScoreboosterState, (PrizePositionData.TransformValues?)(object)2, (UIWidget)2, (byte)(int)_scoreBoosterPanel != 0);
		}
		if (_currentHeadstartState != SpeedometerState.hidden)
		{
			PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentHeadstartState, (PrizePositionData.TransformValues?)(object)2, (UIWidget)1, (byte)(int)_turboHeadstartPanel != 0);
		}
	}

	private unsafe void HideScoreboosterSpeedoMeter()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00b0: Expected F4, but got Obj
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got Ref
		//IL_00d7: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got F4
		//IL_00ff: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I
		//IL_016f: Expected Ref, but got VT
		//IL_0185: Expected Obj, but got Ref
		//IL_005e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		_turboHeadstartUI.tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		_currentHeadstartGear = 0;
		object obj = _turboHeadstartGearZRotations + 16;
		_currentHeadstartIndicatorZRotation = (float)obj;
		object obj2 = _turboHeadstartGearZRotations + 16;
		ref Quaternion reference = default;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		obj3 = 0;
		_ = 0;
		obj3 = 0f;
		_ = 0f;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v22 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v39 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32);
		reference2 = ref *(Quaternion*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v16+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out reference2);
		reference2 = ref *(Quaternion*)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 localScale = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).localScale;
		((MysteryBoxDoubleUpButton)null).Log((string)(object)_turboHeadstartGearBackgrounds, (UnityEngine.Object)(object)_turboHeadstartGearLabels);
		((IngameScreen)null).SetScoreboosterIndicator((int)_turboHeadstartGearsGlow);
		_currentHeadstartState = SpeedometerState.hidden;
		_jetpackIsActive = false;
	}

	private void ResetGlow(UISprite[] gearGlows)
	{
		//IL_0064: Expected I4, but got Obj
		//IL_0080: Expected I4, but got Obj
		//IL_0080: Expected Obj, but got I4
		//IL_0080: Expected VT, but got I4
		//IL_0080: Expected VT, but got I4
		//IL_00f4: Expected I4, but got Obj
		//IL_00f4: Expected Obj, but got I4
		//IL_00f4: Expected VT, but got I4
		//IL_00f4: Expected VT, but got I4
		if (!slideinPowerupHelper.HeadstartButtonIsActive() && !((SuperMysteryBoxEffect)(object)slideinPowerupHelper).isRendering)
		{
			StartHidingScoreboosterSpeedometer(3f);
		}
		else
		{
			StartHidingScoreboosterSpeedometer(5f);
		}
		_currentScoreBoosterGear = (int)gearGlows;
		PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentScoreboosterState, (PrizePositionData.TransformValues?)(object)1, (UIWidget)2, (byte)(int)_scoreBoosterPanel != 0);
		Update();
		SetActiveGears(PowerUpType.scorebooster, _currentScoreBoosterGear, _scoreBoosterGearsGlow, _scoreBoosterGearBackgrounds, _scoreBoosterGearLabels);
		if (_currentHeadstartState == SpeedometerState.hidden)
		{
			PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentHeadstartState, (PrizePositionData.TransformValues?)(object)0, (UIWidget)1, (byte)(int)_turboHeadstartPanel != 0);
		}
	}

	private void ActivateGear(PowerUpType type, UISprite background, UILabel count)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0040: Expected I4, but got Obj
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingsCell debugSettingsCell = default;
		debugSettingsCell.cellType = DebugSettingsCellType.Expandable;
		object obj = debugSettingsCell + 16;
		obj = type;
		debugSettingsCell.settingType = (DebugSetting)background;
		bool multiSelect = (byte)(count & 1) != 0;
		debugSettingsCell.multiSelect = multiSelect;
		((List<DebugSettingsCell>)(object)coinBG).Add(debugSettingsCell);
	}

	private unsafe void ActivateGearNoAnimation(PowerUpType type, UISprite background, UILabel count)
	{
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected VT, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected I4, but got Unknown
		//IL_0333: Expected Obj, but got I4
		//IL_003d: Expected I4, but got Obj
		//IL_0053: Expected VT, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0359: Expected Obj, but got VT
		//IL_0376: Expected I4, but got Obj
		//IL_0371: Expected native int or pointer, but got VT
		//IL_0383: Expected I4, but got Obj
		//IL_039a: Expected VT, but got I4
		//IL_03b9: Expected I4, but got VT
		//IL_03b4: Expected native int or pointer, but got VT
		//IL_03c6: Expected Obj, but got I4
		//IL_03d3: Expected I4, but got Obj
		//IL_03dc: Expected VT, but got I4
		//IL_012c: Expected I4, but got Obj
		//IL_0142: Expected VT, but got I4
		//IL_00f7: Expected I4, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_0159: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got VT
		//IL_040b: Expected I4, but got Obj
		//IL_0406: Expected native int or pointer, but got VT
		//IL_0418: Expected I4, but got Obj
		//IL_042f: Expected VT, but got I4
		//IL_044e: Expected I4, but got VT
		//IL_0449: Expected native int or pointer, but got VT
		//IL_045b: Expected Obj, but got I4
		//IL_0468: Expected I4, but got Obj
		//IL_0471: Expected VT, but got I4
		//IL_01e6: Expected I4, but got Obj
		//IL_019a: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		object obj3 = obj2 + 20;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 60;
		object obj6 = obj2 + 56;
		object obj7 = obj2 + 52;
		object obj8 = obj2 + 48;
		object obj9 = obj2 + 44;
		object obj10 = obj2 + 40;
		Color32 color = (Color32)(obj2 - -64);
		Color black = Color.black;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 80);
		((UIWidget.Pivot*)(int)pivot)->value__ = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27 (UnityEngine.Color32)+8]");
		_ = 0;
		background.rawPivot = pivot;
		object obj11 = type - 1;
		if (type != PowerUpType.headstart)
		{
			if ((nint)obj11 == 1)
			{
				Color black2 = Color.black;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Color color2 = (Color32)pivot;
				nint num = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v77 (Il2CppClass<GlobalColors>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num2 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v96 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj4 = GlobalColors.ACTIVE_SCOREBOOSTER_GEAR_BACKGROUND_COLOR;
				obj8 = obj3;
				obj9 = obj4;
				((Color32*)(nint)color)->rgba = (int)obj8;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
				IEnumerator list = ((SlideinPowerupButton)null).AnimateSpriteColor(background, color, (Color32)pivot, 100f);
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
				((Color32*)(nint)color)->rgba = (int)GlobalColors.ACTIVE_SCOREBOOSTER_GEAR_COUNT_COLOR;
				obj10 = color.rgba;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj10;
				Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)pivot);
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				count.rawPivot = pivot;
			}
		}
		else
		{
			Color black3 = Color.black;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Color color3 = (Color32)pivot;
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v47 (Il2CppClass<GlobalColors>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num4 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v66 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = GlobalColors.ACTIVE_HEADSTART_GEAR_BACKGROUND_COLOR;
			obj5 = obj3;
			obj6 = obj4;
			((Color32*)(nint)color)->rgba = (int)obj5;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
			IEnumerator list2 = ((SlideinPowerupButton)null).AnimateSpriteColor(background, color, (Color32)pivot, 100f);
			Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list2);
			((Color32*)(nint)color)->rgba = (int)GlobalColors.ACTIVE_HEADSTART_GEAR_COUNT_COLOR;
			obj7 = color.rgba;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)pivot);
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			count.rawPivot = pivot;
		}
		if (count.mEffectStyle != UILabel.Effect.None)
		{
			count.mEffectStyle = UILabel.Effect.None;
			((UIRect)count).mChanged = true;
			count.mShouldBeProcessed = true;
		}
	}

	private void DeactivateGears(UISprite[] gearBackgrounds, UILabel[] gearLabels)
	{
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0065: Invalid comparison between Obj and F4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)gearBackgrounds).FindKernel((string)null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		object obj2 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
		{
			return;
		}
		string text = ((Component)(object)gearBackgrounds).tag;
		if (!((GameObject)(object)text).activeInHierarchy)
		{
			return;
		}
		object obj3 = gearLabels - 1;
		if ((nint)gearLabels != 1)
		{
			if ((nint)obj3 == 1)
			{
				Update();
			}
		}
		else
		{
			AnimateScoreboosterIndicator();
		}
	}

	private unsafe void AnimateHeadstartIndicator()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_009a: Expected F4, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got Ref
		//IL_00c1: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got F4
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_0159: Expected Ref, but got VT
		//IL_016f: Expected Obj, but got Ref
		//IL_005e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		_scoreBoosterUI.tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		object obj = _scoreBoosterGearZRotations + 16;
		_currentScoreBoosterIndicatorZRotation = (float)obj;
		object obj2 = _scoreBoosterGearZRotations + 16;
		ref Quaternion reference = default;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		obj3 = 0;
		_ = 0;
		obj3 = 0f;
		_ = 0f;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v21 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v37 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32);
		reference2 = ref *(Quaternion*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v15+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out reference2);
		reference2 = ref *(Quaternion*)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 localScale = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).localScale;
		((MysteryBoxDoubleUpButton)null).Log((string)(object)_scoreBoosterGearBackgrounds, (UnityEngine.Object)(object)_scoreBoosterGearLabels);
		((IngameScreen)null).SetScoreboosterIndicator((int)_scoreBoosterGearsGlow);
		_currentScoreboosterState = SpeedometerState.hidden;
	}

	private IEnumerator AnimateHeadstartIndicatorGear()
	{
		//IL_0007: Expected Obj, but got I4
		return (IEnumerator)reviveCount__BackingField;
	}

	private unsafe void SetScoreboosterIndicator(int gear)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected VT, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_005d: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_0124: Expected Obj, but got VT
		//IL_0139: Expected F4, but got Obj
		//IL_0134: Expected native int or pointer, but got VT
		//IL_0153: Expected F4, but got Obj
		//IL_014e: Expected native int or pointer, but got VT
		//IL_0168: Expected F4, but got I
		//IL_0163: Expected native int or pointer, but got VT
		//IL_0175: Expected I4, but got VT
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_009e: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 24);
		object obj2 = obj + 20;
		object obj3 = obj + 16;
		object obj4 = gear + 12;
		object obj5 = default;
		object obj10 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj6 = gear + 16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			Color color = ((UIWidget)46).color;
			((UIWidget)obj8).height = 40;
			nint num = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v26 (Il2CppClass<GlobalColors>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num2 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v39 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.INITIAL_GEAR_GLOW_COLOR;
			obj3 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)obj8).rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = obj10 + 1;
		}
	}

	private void AnimateScoreboosterIndicator()
	{
		//IL_0010: Expected I4, but got Obj
		useGUILayout = (byte)(int)"AnimateHeadstartIndicatorGear" != 0;
		Coroutine coroutine = StartCoroutine((IEnumerator)(object)"AnimateHeadstartIndicatorGear");
	}

	private IEnumerator AnimateScoreboosterIndicatorGear()
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

	private void Update()
	{
		//IL_0010: Expected I4, but got Obj
		useGUILayout = (byte)(int)"AnimateScoreboosterIndicatorGear" != 0;
		Coroutine coroutine = StartCoroutine((IEnumerator)(object)"AnimateScoreboosterIndicatorGear");
	}

	private void AnimateCoinsLabelIfDoubleCoins()
	{
		//IL_005b: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_012a: Expected I, but got Obj
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_01b8: Expected I, but got Obj
		OnCoinsChanged();
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		((GameStats)(object)privacyPolicyUrl).ResetAmountNeededToAdjustScoreBy();
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		int num = score;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (System.String)+74]");
		if ((nint)num != 0)
		{
			ResizeScoreBox();
		}
		nint num2 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v48 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (System.Boolean)+6D]");
		if ((nint)0 != 0)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v44 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated2 = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v28 (System.Boolean)+43]");
			if ((nint)0 == 0)
			{
				nint num6 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v40 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated3 = Game.IsInstantiated;
				_ = 0;
				slideinPowerupHelper.HideScorebooster();
			}
		}
		UpdateMultiplierLabel();
	}

	private unsafe void UpdateMultiplierLabel()
	{
		//IL_03eb: Expected I, but got Obj
		//IL_0401: Expected Obj, but got I
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected VT, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected I4, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected Obj, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_035d: Expected I, but got Obj
		//IL_0373: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0595: Expected I4, but got VT
		//IL_05a2: Expected Obj, but got I4
		//IL_05af: Expected F4, but got Obj
		//IL_05aa: Expected native int or pointer, but got VT
		//IL_05c9: Expected F4, but got Obj
		//IL_05c4: Expected native int or pointer, but got VT
		//IL_05de: Expected F4, but got I
		//IL_05d9: Expected native int or pointer, but got VT
		//IL_05eb: Expected I4, but got VT
		//IL_039e: Expected I, but got Obj
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02bf: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I
		//IL_01d9: Expected I, but got Obj
		//IL_0427: Expected Obj, but got VT
		//IL_043c: Expected F4, but got Obj
		//IL_0437: Expected native int or pointer, but got VT
		//IL_0452: Expected Obj, but got VT
		//IL_0467: Expected F4, but got Obj
		//IL_0462: Expected native int or pointer, but got VT
		//IL_0481: Expected I4, but got Obj
		//IL_049b: Expected F4, but got Obj
		//IL_0496: Expected native int or pointer, but got VT
		//IL_04b0: Expected F4, but got I
		//IL_04ab: Expected native int or pointer, but got VT
		//IL_04c7: Expected I4, but got VT
		//IL_04c7: Expected Ref, but got VT
		//IL_052c: Expected I4, but got VT
		//IL_0539: Expected Obj, but got I4
		//IL_0546: Expected F4, but got Obj
		//IL_0541: Expected native int or pointer, but got VT
		//IL_0560: Expected F4, but got Obj
		//IL_055b: Expected native int or pointer, but got VT
		//IL_0575: Expected F4, but got I
		//IL_0570: Expected native int or pointer, but got VT
		//IL_0582: Expected I4, but got VT
		//IL_0226: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_0161: Expected native int or pointer, but got VT
		//IL_0173: Expected native int or pointer, but got VT
		//IL_0185: Expected I4, but got VT
		//IL_0115: Expected I, but got Obj
		//IL_0300: Expected I, but got Obj
		//IL_0267: Expected I, but got Obj
		nint num = (nint)typeof(DoubleCoins);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<DoubleCoins>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DoubleCoins);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v84 (Il2CppClass<DoubleCoins>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Matrix4x4 matrix4x2 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(matrix4x2 + 112);
		int num3 = matrix4x2 + 88;
		object obj2 = matrix4x2 + 56;
		object obj3 = matrix4x2 + 104;
		object obj4 = matrix4x2 + 40;
		object obj5 = matrix4x2 + 80;
		object obj6 = matrix4x2 + 32;
		object obj7 = matrix4x2 + 16;
		object obj8 = matrix4x2 + 76;
		object obj9 = matrix4x2 + 72;
		if (~(DoubleCoins.HasDoubleCoinsModifier ? 1u : 0u) == 0)
		{
			float unscaledTime = Time.unscaledTime;
			float num4 = unscaledTime * 2f;
			float num5 = lerpFactorCoins + num4;
			lerpFactorCoins = num5;
			if (!(lerpFactorCoins > 1f))
			{
				object obj10 = this - -64;
				nint num6 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v69 (Il2CppClass<GlobalColors>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num7 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v91 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.COINS_LIGHT_PURPLE;
				obj5 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
				Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
				obj6 = GlobalColors.COINS_DARK_PURPLE;
				obj8 = obj6;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
				Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
				((int*)num3)->m_value = (int)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((Matrix4x4*)matrix4x2)->set_Item(num3, (int)matrix4x, lerpFactorCoins);
				((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
				((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
				((UIWidget)obj10).rawPivot = (UIWidget.Pivot)matrix4x;
				return;
			}
			nint num8 = (nint)typeof(DoubleCoins);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v48 (Il2CppClass<DoubleCoins>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num9 = (nint)typeof(DoubleCoins);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v75 (Il2CppClass<DoubleCoins>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (DoubleCoins.numberOfAnimationBlinks < 2)
			{
				nint num10 = (nint)typeof(DoubleCoins);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v61 (Il2CppClass<DoubleCoins>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num11 = (nint)typeof(DoubleCoins);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v69 (Il2CppClass<DoubleCoins>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int numberOfAnimationBlinks = DoubleCoins.numberOfAnimationBlinks + 1;
				DoubleCoins.numberOfAnimationBlinks = numberOfAnimationBlinks;
				lerpFactorCoins = 0f;
				return;
			}
			object obj14 = this - -64;
			nint num12 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v44 (Il2CppClass<GlobalColors>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num13 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S1_v55 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((int*)num3)->m_value = (int)GlobalColors.COINS_LIGHT_PURPLE;
			obj3 = ((int*)num3)->m_value;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)obj14).rawPivot = (UIWidget.Pivot)matrix4x;
			return;
		}
		object obj16 = this - -64;
		nint num14 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v17 (Il2CppClass<GlobalColors>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num15 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v29 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((int*)num3)->m_value = (int)GlobalColors.COINS_ORIGINAL_COLOR;
		obj9 = ((int*)num3)->m_value;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)obj16).rawPivot = (UIWidget.Pivot)matrix4x;
		lerpFactorCoins = 0f;
	}

	private unsafe void OnCoinsChanged()
	{
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected VT, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected I4, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_0032: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0073: Expected I, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_021f: Expected I, but got Obj
		//IL_0235: Expected Obj, but got I
		//IL_0260: Expected I, but got Obj
		//IL_02dc: Expected I, but got Obj
		//IL_02f2: Expected Obj, but got I
		//IL_04be: Expected Obj, but got VT
		//IL_04d3: Expected F4, but got Obj
		//IL_04ce: Expected native int or pointer, but got VT
		//IL_04e9: Expected Obj, but got VT
		//IL_04fe: Expected F4, but got Obj
		//IL_04f9: Expected native int or pointer, but got VT
		//IL_0518: Expected I4, but got Obj
		//IL_0532: Expected F4, but got Obj
		//IL_052d: Expected native int or pointer, but got VT
		//IL_0547: Expected F4, but got I
		//IL_0542: Expected native int or pointer, but got VT
		//IL_055e: Expected I4, but got VT
		//IL_055e: Expected Ref, but got VT
		//IL_0369: Expected native int or pointer, but got VT
		//IL_037b: Expected native int or pointer, but got VT
		//IL_038f: Expected I4, but got VT
		//IL_031d: Expected I, but got Obj
		Matrix4x4 matrix4x2 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(matrix4x2 + 80);
		int num = matrix4x2 - -64;
		object obj = matrix4x2 + 56;
		object obj2 = matrix4x2 + 40;
		object obj3 = matrix4x2 + 60;
		object obj4 = matrix4x2 + 32;
		object obj5 = matrix4x2 + 16;
		object obj6 = matrix4x2 + 36;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v25 (System.String)+64]");
		if ((nint)0 == 0)
		{
			string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v81 (System.String)+70]");
			if ((nint)0 == 0)
			{
				nint num2 = (nint)typeof(PlusMultiplier);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v84 (Il2CppClass<PlusMultiplier>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num3 = (nint)typeof(PlusMultiplier);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v91 (Il2CppClass<PlusMultiplier>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!PlusMultiplier.plusMultiplierEnabled)
				{
					return;
				}
			}
		}
		if (~(_isMultiplierLabelUpdated ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A02");
		object obj8 = default;
		if (obj8 != null)
		{
			return;
		}
		nint num4 = (nint)typeof(PlusMultiplier);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v37 (Il2CppClass<PlusMultiplier>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num5 = (nint)typeof(PlusMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v74 (Il2CppClass<PlusMultiplier>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool plusMultiplierEnabled = PlusMultiplier.plusMultiplierEnabled;
		float unscaledTime = Time.unscaledTime;
		if (plusMultiplierEnabled)
		{
			float num6 = unscaledTime * 4f;
			float num7 = lerpFactor + num6;
			lerpFactor = num7;
		}
		else
		{
			float num8 = unscaledTime * 2f;
			float num9 = lerpFactor + num8;
			lerpFactor = num9;
		}
		if (lerpFactor > 1f)
		{
			FadeFromWhiteToDarkBlue();
			lerpFactor = 0f;
			return;
		}
		nint num10 = (nint)typeof(PlusMultiplier);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v50 (Il2CppClass<PlusMultiplier>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num11 = (nint)typeof(PlusMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v64 (Il2CppClass<PlusMultiplier>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(PlusMultiplier.plusMultiplierEnabled ? 1u : 0u) != 0)
		{
			ResetMultiplierLabelColour();
		}
		else
		{
			if (~(doLastIteration ? 1u : 0u) == 0)
			{
				return;
			}
			nint num12 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v23 (Il2CppClass<GlobalColors>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num13 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S1_v45 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = GlobalColors.MULTIPLIER_DARK_PURPLE;
			obj3 = obj;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			obj4 = GlobalColors.MULTIPLIER_LIGHT_PURPLE;
			obj6 = obj4;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
			((int*)num)->m_value = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((Matrix4x4*)matrix4x2)->set_Item(num, (int)matrix4x, lerpFactor);
			((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
			((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
			multiplierLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		}
	}

	private void OnGameStarted()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		object obj = this - -64;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		int coinsCollectedRun = ((GameStats)(object)privacyPolicyUrl).CoinsCollectedRun;
		object obj2 = coinsCollectedRun;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		((UILabel)obj).fontSize = fontSize;
		ResizeMultiplierBox();
	}

	private void SetScoreLabel()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		lastKnowDigits = 0;
		digits = 0;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v23 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (System.Boolean)+6D]");
		if ((nint)0 == 0)
		{
			slideinPowerupHelper.HidePowerup2(instant: true);
			((SuperMysteryBoxEffect)(object)slideinPowerupHelper).isRendering = true;
		}
		HideScoreboosterSpeedoMeter();
		AnimateHeadstartIndicator();
	}

	private void ResizeScoreBox()
	{
		//IL_014b: Expected I4, but got Obj
		//IL_015b: Expected Obj, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_01af: Expected I4, but got Obj
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (System.String)+74]");
		score = 0;
		string text = Utility.NumberToStringFormat(score);
		digits = (int)text;
		object obj = digits - 1;
		object values;
		if (digits == 1)
		{
			values = "00000";
		}
		else if ((nint)obj == 1)
		{
			values = "0000";
		}
		else if ((nint)obj == 2)
		{
			values = "000";
		}
		else if ((nint)obj == 3)
		{
			values = "00";
		}
		else
		{
			values = (((nint)obj != 4) ? "" : "0");
		}
		object obj2 = this + 324;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int totalLength = default;
		string text2 = string.ConcatArray((string[])values, totalLength);
		scoreLabel.fontSize = (int)text2;
		if (lastKnowDigits != digits)
		{
			ResizeCoinBox();
			lastKnowDigits = digits;
		}
	}

	private void ResizeCoinBox()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00ed: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected I4, but got Unknown
		object obj = this + 80;
		int chance = ((MysteryBoxDoubleUpButton)(object)this).chance;
		object obj2 = this + 80;
		object obj4 = default;
		object obj3 = obj4 + 12;
		obj3 = 0;
		_ = 0;
		object obj5 = chance * 11;
		object obj6 = obj - obj5;
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8+4]");
		_ = 0;
		_ = 0f;
		Transform transform = (Transform)(obj4 + 24);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v11+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Camera anchorCamera = scoreLabel.anchorCamera;
		object obj7 = this + 44;
		int chance2 = ((MysteryBoxDoubleUpButton)(object)this).chance;
		object obj8 = this + 44;
		obj4 = 0;
		_ = 0;
		object obj9 = chance2 * 11;
		object obj10 = obj7 - obj9;
		obj4 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v27+4]");
		_ = 0;
		_ = 0f;
		transform = (Transform)obj4;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform.eulerAngles;
		int chance3 = ((MysteryBoxDoubleUpButton)(object)this).chance;
		object obj11 = chance3 * 11;
		int height = obj11 + _originalWidthForScoreBG;
		scoreBG.height = height;
	}

	private void ResizeMultiplierBox()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0145: Invalid comparison between F4 and I4
		//IL_005a: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_0183: Expected I4, but got Obj
		//IL_009b: Expected I, but got Obj
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7+12C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
		float num;
		if ((nint)0 < (nint)2)
		{
			num = 64f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
			object obj4 = -1;
			object obj5 = obj4 * 12;
			num = 64f + (float)obj5;
		}
		UISprite uISprite = coinBG;
		if (num == (float)((UIWidget)uISprite).mWidth)
		{
			return;
		}
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width(num);
		coinBG.height = (int)gUILayoutOption;
	}

	private void SincronizeHuntData()
	{
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0193: Expected I4, but got Obj
		//IL_01a3: Expected Obj, but got I4
		//IL_0091: Expected I, but got Obj
		UILabel uILabel = multiplierLabel;
		string mText = uILabel.mText;
		_multiDigits = mText.m_stringLength;
		if (_lastKnownMultiDigits == _multiDigits)
		{
			return;
		}
		float width;
		if (_multiDigits == 3)
		{
			width = 44f;
		}
		else
		{
			width = ((_multiDigits >= 4) ? 50f : 34f);
		}
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v21 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		multiplierBG.height = (int)gUILayoutOption;
		multiplierLabelAnchor.tag = (string)1;
		_lastKnownMultiDigits = _multiDigits;
	}

	private unsafe void OnApplicationPause(bool pause)
	{
		//IL_0060: Expected Obj, but got Ref
		//IL_0069: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_00a4: Expected F4, but got Obj
		//IL_00ad: Expected Obj, but got F4
		//IL_00c8: Expected Obj, but got Ref
		//IL_00eb: Expected I, but got Obj
		//IL_0101: Expected Obj, but got I
		//IL_015b: Expected Ref, but got VT
		//IL_0171: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		ref Quaternion reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 28));
		obj = 0;
		_ = 0;
		object obj2 = _scoreBoosterGearZRotations + 16;
		object obj3 = (pause ? 1u : 0u) << 2;
		object obj4 = obj2 + obj3;
		_currentScoreBoosterIndicatorZRotation = (float)obj4;
		obj = 0f;
		_ = 0f;
		_ = _currentScoreBoosterIndicatorZRotation;
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v18 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v29 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 40);
		reference2 = ref *(Quaternion*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v15+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out reference2);
		reference2 = ref *(Quaternion*)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 localScale = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).localScale;
	}

	public void UpdateHuntLabel()
	{
		//IL_00f9: Expected I, but got Obj
		//IL_010f: Expected Obj, but got I
		//IL_01c0: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool period = WeeklyHuntManager.IsAnyPeriodActive();
		nint num3 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v30 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 300;
		bool hiddenUntilUnlockedForPeriod = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(period ? WeeklyHuntData.PrizePeriodId.PeriodOne : WeeklyHuntData.PrizePeriodId.None);
		obj3 = hiddenUntilUnlockedForPeriod;
		WeeklyHuntData.WeeklyHuntPeriodData currentWeekHuntPrize = _currentWeekHuntPrize;
		_huntMaxItems = currentWeekHuntPrize.itemsToCollect;
		WeeklyHuntData.WeeklyHuntPeriodData currentWeekHuntPrize2 = _currentWeekHuntPrize;
		_huntCollectedItems = currentWeekHuntPrize2.itemsCollected;
		if (_huntCollectedItems < 0)
		{
			_huntCollectedItems = 0;
		}
		else if (_huntCollectedItems > _huntMaxItems)
		{
			_huntCollectedItems = _huntMaxItems;
		}
	}

	private void OnEnable()
	{
		//IL_028a: Expected I, but got Obj
		//IL_02a0: Expected Obj, but got I
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_034f: Expected I, but got Obj
		//IL_0365: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I4
		//IL_0275: Expected I4, but got Obj
		//IL_0227: Expected I, but got Obj
		//IL_0181: Expected VT, but got Obj
		//IL_00ea: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_01a2: Expected VT, but got Obj
		//IL_01ca: Expected VT, but got Obj
		//IL_011e: Expected I4, but got Obj
		//IL_01eb: Expected VT, but got Obj
		UpdateHuntLabel();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 36);
		Transform transform3 = (Transform)(transform2 + 24);
		if (((ComputeShader)(object)_huntAmountLabel).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v42 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v53 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = WeeklyHuntManager.CanSpawnToken();
			_huntAmountLabel.tag = (string)flag;
			transform = (Transform)_huntCollectedItems;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			transform3 = (Transform)_huntMaxItems;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text3 = default;
			string text = text2 + "/" + text3;
			_huntAmountLabel.fontSize = (int)text;
		}
		Transform transform4 = (Transform)(transform2 + 12);
		if (~(_hasCalculatedHuntLabelOffsets ? 1u : 0u) != 0)
		{
			_huntBgPositioning.Awake();
			GameObject gameObject = _huntLabelBg.gameObject;
			transform.localPosition = (Vector3)gameObject;
			GameObject gameObject2 = _huntAmountLabel.gameObject;
			transform3.localPosition = (Vector3)gameObject2;
			float huntLabelFrontOffset = (float)transform - (float)transform3;
			_huntLabelFrontOffset = huntLabelFrontOffset;
			transform4.localPosition = (Vector3)_huntIcon;
			GameObject gameObject3 = _huntAmountLabel.gameObject;
			transform2.localPosition = (Vector3)gameObject3;
			float huntLabelBackOffset = (float)transform4 - (float)transform2;
			_huntLabelBackOffset = huntLabelBackOffset;
			_hasCalculatedHuntLabelOffsets = true;
		}
		UILabel huntAmountLabel = _huntAmountLabel;
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S2_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S2_v22 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num7 = Math.Abs(_huntLabelFrontOffset);
		float num8 = (float)((UIWidget)huntAmountLabel).mWidth + num7;
		float num9 = Math.Abs(_huntLabelBackOffset);
		float num10 = num8 + num9;
		float width = num10 + -9f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		_huntLabelBg.height = (int)gUILayoutOption;
	}

	private unsafe void OnMenuScreenShown()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(IngameScreen.UpdateHuntLabel);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v18 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntManager.itemCountUpdated -= action;
		OnEnable();
	}

	private void ResetScoreboosterGear()
	{
		_currentScoreBoosterGear = 0;
		reviveCount__BackingField = 0;
	}

	private void OnGameRevived()
	{
		_currentScoreBoosterGear = 0;
	}

	private void ReenableActiveScoreboosters()
	{
		this._002Ector();
		int num = reviveCount__BackingField + 1;
		reviveCount__BackingField = num;
	}

	public void RestartHidingScoreboosterSpeedometer(float hideTime)
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0061: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)showOldFooterSection).FindKernel(null) != 0)
		{
			((UIEventListener)showOldFooterSection).OnScroll(hideTime);
		}
	}

	private void StartHidingScoreboosterSpeedometer(float time)
	{
		StopCoroutine((IEnumerator)(object)"SetScoreboosterTimePeriodIsActive");
		StopCoroutine((IEnumerator)(object)"DeactivateScoreboosterSpeedometer");
		_scoreboosterTimePeriodIsActive = true;
		((SaveMePopup)this).AnimTimeLeft = time;
	}

	public IngameScreen()
	{
		//IL_003b: Expected I4, but got Obj
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected VT, but got I4
		//IL_003b: Expected VT, but got I4
		//IL_005d: Expected VT, but got Obj
		//IL_005d: Expected VT, but got Obj
		//IL_005d: Expected VT, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_00b4: Expected I4, but got Obj
		//IL_00b4: Expected Obj, but got I4
		//IL_00b4: Expected VT, but got I4
		//IL_00b4: Expected VT, but got I4
		if (_currentScoreBoosterGear != 0)
		{
			PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentScoreboosterState, (PrizePositionData.TransformValues?)(object)1, (UIWidget)2, (byte)(int)_scoreBoosterPanel != 0);
			((SSEventsPopup)this).PositionModelOnSprite((UISprite)2, (GameObject)_currentScoreBoosterGear, (Vector3)0, (Vector3)_scoreBoosterGearBackgrounds, (Vector3)_scoreBoosterGearLabels);
			OnApplicationPause((byte)_currentScoreBoosterGear != 0);
			if (_currentHeadstartState == SpeedometerState.hidden)
			{
				PrizePositionData.FitAndApplyOffsets((Transform)(object)this, (Vector3)_currentHeadstartState, (PrizePositionData.TransformValues?)(object)0, (UIWidget)1, (byte)(int)_turboHeadstartPanel != 0);
			}
			StartHidingScoreboosterSpeedometer(5f);
		}
	}
}
