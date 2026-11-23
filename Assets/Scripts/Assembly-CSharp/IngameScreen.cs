using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Managers;
using SYBO.Subway;
using SYBO.Subway.Characters;
using TMPro;
using TopRun;
using UI;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__83_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CAwake_003Eb__83_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushScreen("PauseUI");
		}
	}

	private sealed class _003CAnimateSpeedoMeterPanel_003Ed__105(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IngameScreen _003C_003E4__this;

		public float startValue;

		public float endValue;

		public CanvasGroup uiSpeedoMeterPanel;

		public SpeedometerState nextState;

		public PowerUpType type;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00d4: Expected Obj, but got I4
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (nextState == SpeedometerState.hidden)
					{
						object obj = type - 1;
						if (type == PowerUpType.headstart)
						{
							_003C_003E4__this.HideTurboHeadstartSpeedoMeter();
							return false;
						}
						if ((nint)obj == 1)
						{
							_003C_003E4__this.HideScoreboosterSpeedoMeter();
						}
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			IEnumerator coroutine = AnimatePanelAlpha(startValue, endValue, uiSpeedoMeterPanel);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 1;
			return true;
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

	private sealed class _003CAnimatePanelAlpha_003Ed__109(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CanvasGroup uiSpeedoMeterPanel;

		public float startValue;

		public float endValue;

		private float _003CanimationLerpFactor_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003CanimationLerpFactor_003E5__2 < 1f)
					{
						goto IL_008e;
					}
				}
				return false;
			}
			_003CanimationLerpFactor_003E5__2 = 0f;
			_003C_003E1__state = -1;
			goto IL_008e;
			IL_008e:
			float deltaTime = Time.deltaTime;
			float num = deltaTime * 3f;
			float num2 = (_003CanimationLerpFactor_003E5__2 += num);
			float num3 = endValue - startValue;
			float num4 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num5 = 0f;
			if (!flag)
			{
				num5 = num4;
			}
			float num6 = num3 * num5;
			float alpha = startValue + num6;
			uiSpeedoMeterPanel.alpha = alpha;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
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

	private sealed class _003CAnimateSpriteColor_003Ed__110(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float speedFactor;

		public Gear gear;

		private float _003CanimationLerpFactor_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						if (_003CanimationLerpFactor_003E5__2 < 1f)
						{
							goto IL_00e5;
						}
						Gear gear = this.gear;
						gear.background.sprite = gear.active;
					}
					return false;
				}
				_003CanimationLerpFactor_003E5__2 = 0f;
				_003C_003E1__state = -1;
				goto IL_00e5;
			}
			_003C_003E1__state = -1;
			_ = 0.2f;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
			IL_00e5:
			float deltaTime = Time.deltaTime;
			float num = deltaTime * speedFactor;
			float num2 = _003CanimationLerpFactor_003E5__2 + num;
			_003C_003E2__current = null;
			_003CanimationLerpFactor_003E5__2 = num2;
			_003C_003E1__state = 2;
			return true;
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

	private sealed class _003CAnimateHeadstartIndicatorGear_003Ed__120(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IngameScreen _003C_003E4__this;

		private float _003CstartIndicatorRotation_003E5__2;

		private float _003CendIndicatorRotation_003E5__3;

		private float _003CanimationLerpFactor_003E5__4;

		private Gear _003CcurrentGear_003E5__5;

		private Color _003CstartColor_003E5__6;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected Obj, but got Unknown
			//IL_00b7: Expected F4, but got I
			//IL_00ca: Expected Obj, but got I4
			//IL_00fc: Expected Obj, but got I
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected Obj, but got Unknown
			//IL_011f: Expected I, but got Obj
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected Obj, but got Unknown
			//IL_0170: Expected VT, but got I
			//IL_0206: Expected Obj, but got VT
			//IL_02cf: Expected Obj, but got I
			//IL_0312: Expected Obj, but got I
			//IL_035a: Expected Obj, but got I
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Expected Obj, but got Unknown
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Expected VT, but got Unknown
			//IL_0479: Expected F4, but got I
			//IL_0474: Expected native int or pointer, but got VT
			//IL_049b: Expected F4, but got I
			//IL_0496: Expected native int or pointer, but got VT
			object obj = default;
			Quaternion quaternion = (Quaternion)(obj - 112);
			IngameScreen ingameScreen = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0262;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				_003CstartIndicatorRotation_003E5__2 = ingameScreen._currentHeadstartIndicatorZRotation;
				int num = ingameScreen._currentHeadstartGear << 2;
				object obj2 = ingameScreen._turboHeadstartGearZRotations + num;
				_003CanimationLerpFactor_003E5__4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v63+10]");
				_003CendIndicatorRotation_003E5__3 = 0f;
				object obj3 = ingameScreen._currentHeadstartGear - 1;
				object obj4 = obj3 << 2;
				object obj5 = (object)ingameScreen.HeadstartSpeedometer + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v63+10]");
				_003CcurrentGear_003E5__5 = (Gear)0;
				object obj6 = quaternion + 80;
				Image indicatorHeadstart = ingameScreen.indicatorHeadstart;
				nint num2 = (nint)indicatorHeadstart;
				object obj7 = indicatorHeadstart + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S2_v35 (Il2CppClass<UnityEngine.UI.Image>)+16C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				_003CstartColor_003E5__6 = (Color)0;
			}
			if (_003CanimationLerpFactor_003E5__4 < 1f)
			{
				float deltaTime = Time.deltaTime;
				float num3 = deltaTime * 1.2f;
				float num4 = (_003CanimationLerpFactor_003E5__4 += num3) * (float)Math.PI;
				float num5 = num4 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
				Gear gear = _003CcurrentGear_003E5__5;
				object obj8 = gear.gearColor - _003CstartColor_003E5__6;
				float num7 = default;
				float num6 = Math.Min(num7, 1f);
				bool flag = num7 < 0f;
				float num8 = 0f;
				if (!flag)
				{
					num8 = num6;
				}
				float num9 = (float)obj8 * num8;
				float num10 = (float)_003CstartColor_003E5__6 + num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v20 (Gear)+24]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateHeadstartIndicatorGear>d__120)+28]");
				object obj9 = num11 - 0;
				float num12 = (float)obj9 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateHeadstartIndicatorGear>d__120)+28]");
				float num13 = 0f + num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v20 (Gear)+28]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateHeadstartIndicatorGear>d__120)+2C]");
				object obj10 = num14 - 0;
				float num15 = (float)obj10 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateHeadstartIndicatorGear>d__120)+2C]");
				float num16 = 0f + num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v20 (Gear)+2C]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateHeadstartIndicatorGear>d__120)+30]");
				object obj11 = num17 - 0;
				float num18 = (float)obj11 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateHeadstartIndicatorGear>d__120)+30]");
				float num19 = 0f + num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
				_ = 0;
				object obj12 = quaternion + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				float num20 = _003CendIndicatorRotation_003E5__3 - _003CstartIndicatorRotation_003E5__2;
				float num21 = num20 * num8;
				float num22 = (ingameScreen._currentHeadstartIndicatorZRotation = _003CstartIndicatorRotation_003E5__2 + num21) * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				_ = 0;
				_ = 0f;
				_ = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				_ = 0;
				Vector3 euler = (Vector3)(quaternion + 16);
				Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
				((Quaternion*)(nint)quaternion)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
				((Quaternion*)(nint)quaternion)->x = 0f;
				ingameScreen._turboHeadstartIndicator.localRotation = quaternion;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
			}
			goto IL_0262;
			IL_0262:
			return true;
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

	private sealed class _003CAnimateScoreboosterIndicatorGear_003Ed__123(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IngameScreen _003C_003E4__this;

		private float _003CstartIndicatorRotation_003E5__2;

		private float _003CendIndicatorRotation_003E5__3;

		private float _003CanimationLerpFactor_003E5__4;

		private Gear _003CcurrentGear_003E5__5;

		private Color _003CstartColor_003E5__6;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected Obj, but got Unknown
			//IL_00b7: Expected F4, but got I
			//IL_00ca: Expected Obj, but got I4
			//IL_00fc: Expected Obj, but got I
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected Obj, but got Unknown
			//IL_011f: Expected I, but got Obj
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected Obj, but got Unknown
			//IL_0170: Expected VT, but got I
			//IL_0206: Expected Obj, but got VT
			//IL_02cf: Expected Obj, but got I
			//IL_0312: Expected Obj, but got I
			//IL_035a: Expected Obj, but got I
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Expected Obj, but got Unknown
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Expected VT, but got Unknown
			//IL_0479: Expected F4, but got I
			//IL_0474: Expected native int or pointer, but got VT
			//IL_049b: Expected F4, but got I
			//IL_0496: Expected native int or pointer, but got VT
			object obj = default;
			Quaternion quaternion = (Quaternion)(obj - 112);
			IngameScreen ingameScreen = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0262;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				_003CstartIndicatorRotation_003E5__2 = ingameScreen._currentScoreBoosterIndicatorZRotation;
				int num = ingameScreen._currentScoreBoosterGear << 2;
				object obj2 = ingameScreen._scoreBoosterGearZRotations + num;
				_003CanimationLerpFactor_003E5__4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v63+10]");
				_003CendIndicatorRotation_003E5__3 = 0f;
				object obj3 = ingameScreen._currentScoreBoosterGear - 1;
				object obj4 = obj3 << 2;
				object obj5 = (object)ingameScreen.ScoreboosterSpeedometer + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v63+10]");
				_003CcurrentGear_003E5__5 = (Gear)0;
				object obj6 = quaternion + 80;
				Image indicatorScorebooster = ingameScreen.indicatorScorebooster;
				nint num2 = (nint)indicatorScorebooster;
				object obj7 = indicatorScorebooster + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S2_v35 (Il2CppClass<UnityEngine.UI.Image>)+16C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				_003CstartColor_003E5__6 = (Color)0;
			}
			if (_003CanimationLerpFactor_003E5__4 < 1f)
			{
				float deltaTime = Time.deltaTime;
				float num3 = deltaTime * 1.2f;
				float num4 = (_003CanimationLerpFactor_003E5__4 += num3) * (float)Math.PI;
				float num5 = num4 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
				Gear gear = _003CcurrentGear_003E5__5;
				object obj8 = gear.gearColor - _003CstartColor_003E5__6;
				float num7 = default;
				float num6 = Math.Min(num7, 1f);
				bool flag = num7 < 0f;
				float num8 = 0f;
				if (!flag)
				{
					num8 = num6;
				}
				float num9 = (float)obj8 * num8;
				float num10 = (float)_003CstartColor_003E5__6 + num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v20 (Gear)+24]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateScoreboosterIndicatorGear>d__123)+28]");
				object obj9 = num11 - 0;
				float num12 = (float)obj9 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateScoreboosterIndicatorGear>d__123)+28]");
				float num13 = 0f + num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v20 (Gear)+28]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateScoreboosterIndicatorGear>d__123)+2C]");
				object obj10 = num14 - 0;
				float num15 = (float)obj10 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateScoreboosterIndicatorGear>d__123)+2C]");
				float num16 = 0f + num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v20 (Gear)+2C]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateScoreboosterIndicatorGear>d__123)+30]");
				object obj11 = num17 - 0;
				float num18 = (float)obj11 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen+<AnimateScoreboosterIndicatorGear>d__123)+30]");
				float num19 = 0f + num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
				_ = 0;
				object obj12 = quaternion + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				float num20 = _003CendIndicatorRotation_003E5__3 - _003CstartIndicatorRotation_003E5__2;
				float num21 = num20 * num8;
				float num22 = (ingameScreen._currentScoreBoosterIndicatorZRotation = _003CstartIndicatorRotation_003E5__2 + num21) * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				_ = 0;
				_ = 0f;
				_ = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				_ = 0;
				Vector3 euler = (Vector3)(quaternion + 16);
				Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
				((Quaternion*)(nint)quaternion)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
				((Quaternion*)(nint)quaternion)->x = 0f;
				ingameScreen._scoreBoosterIndicator.localRotation = quaternion;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
			}
			goto IL_0262;
			IL_0262:
			return true;
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

	private const string ONLINESETTINGS_ALLOW_POWERUPS_ON_REVIVE_KEY = "consumables_allow_on_revive";

	private const bool ONLINESETTINGS_ALLOW_POWERUPS_ON_REVIVE_DEFAULT = true;

	private TMP_Text scoreLabel;

	public TMP_Text multiplierLabel;

	public TMP_Text coinLabel;

	public Image scoreBG;

	private Transform _multiplier;

	private Vector3 _originalMultiplierPosition;

	public Image multiplierBG;

	public Image coinBG;

	public SlideinPowerupHelper slideinPowerupHelper;

	public TMP_Text countdownStartingLabel;

	public TMP_Text countdownLabel;

	private float _countdownSeconds;

	private bool _countingDown;

	private Vector3 _cachedCountdownLabelScale;

	private bool _isMultiplierLabelUpdated;

	public Color SCOREBOOSTER_ACTIVE_COLOR;

	private Color SCOREBOOSTER_ELECTRICBLUE;

	private Color SCOREBOOSTER_WHITE;

	public Color MULTIPLIER_LABEL_ORIGINAL_COLOR;

	private GameObject _weeklyHuntCounter;

	private GameObject pauseButton;

	private TMP_Text _huntAmountLabel;

	private Image _huntLabelBg;

	private Transform _huntIcon;

	private const float HUNT_BG_EXTRA_SCALE = 3f;

	private WeeklyHuntIconPositioning _huntBgPositioning;

	private GameObject _turboHeadstartUI;

	private Transform _turboHeadstartIndicator;

	private Image _turboHeadstartBase;

	private CanvasGroup _turboHeadstartPanel;

	private Button PauseButton;

	private int _currentHeadstartGear;

	private float _currentHeadstartIndicatorZRotation;

	private readonly int[] _turboHeadstartGearZRotations;

	private GameObject _scoreBoosterUI;

	private Transform _scoreBoosterIndicator;

	private Image _scoreBoosterBase;

	private CanvasGroup _scoreBoosterPanel;

	private int _currentScoreBoosterGear;

	private float _currentScoreBoosterIndicatorZRotation;

	private readonly int[] _scoreBoosterGearZRotations;

	private bool _scoreboosterTimePeriodIsActive;

	private bool _jetpackIsActive;

	private SpeedometerState _currentScoreboosterState;

	private SpeedometerState _currentHeadstartState;

	private WeeklyHuntManager.WeeklyHuntPeriodData _currentWeekHuntPrize;

	private int _huntCollectedItems;

	private int _huntMaxItems;

	private bool _hasCalculatedHuntLabelOffsets;

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

	private float mTimeStart;

	private float mTimeDelta;

	private float mActual;

	private bool mTimeStarted;

	private Image indicatorHeadstart;

	private Image indicatorScorebooster;

	private Gear[] HeadstartSpeedometer;

	private Gear[] ScoreboosterSpeedometer;

	private int reviveCount__BackingField;

	private static IngameScreen instance__BackingField;

	private UIPopupIn UIPopupIn;

	public LayoutElement scoreBox;

	private float scoreWidth;

	public LayoutElement coinBox;

	private float coinWidth;

	public static bool allowPowerupsOnRevive
	{
		get
		{
			OnlineSettings onlineSettings = OnlineSettings.instance;
			return onlineSettings.GetValue("consumables_allow_on_revive", defaultValue: true);
		}
	}

	public int reviveCount
	{
		get
		{
			return reviveCount__BackingField;
		}
		private set
		{
			reviveCount__BackingField = value;
		}
	}

	public static IngameScreen instance
	{
		get
		{
			return instance__BackingField;
		}
		private set
		{
			instance__BackingField = value;
		}
	}

	private int extraNumberOfChars
	{
		get
		{
			int num = digits - 6;
			if (num >= 28)
			{
				num = 28;
			}
			if (num <= 0)
			{
				num = 0;
			}
			return num;
		}
	}

	private unsafe void Awake()
	{
		instance__BackingField = this;
		Button button = PauseButton;
		bool flag = _003C_003Ec._003C_003E9__83_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__83_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__83_0));
			_003C_003Ec._003C_003E9__83_0 = unityAction;
			call = unityAction;
		}
		button.m_OnClick.AddListener(call);
	}

	public unsafe override void Init()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v5 (Il2CppClass<IngameScreen>)+104] (should have been resolved before IL gen)");
		PlayerInfo playerInfo = PlayerInfo.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(IngameScreen.SetMultiplierLabel));
		Delegate obj3 = Delegate.Combine(playerInfo.onScoreMultiplierChanged, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onScoreMultiplierChanged = default;
		playerInfo.onScoreMultiplierChanged = onScoreMultiplierChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		GameStats gameStats = GameStats.Instance;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(IngameScreen.OnCoinsChanged));
		gameStats.OnCoinsChanged += action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(IngameScreen.OnGameStarted));
		Game.OnGameStarted += action3;
		Action action4 = default;
		action4._002Ector(this, (nint)__ldftn(IngameScreen.OnMenuScreenShown));
		Game.OnMenuScreenShown += action4;
		Action action5 = default;
		action5._002Ector(this, (nint)__ldftn(IngameScreen.OnGameRevived));
		Game.OnGameRevived += action5;
		Game game = Game.Instance;
		throw new ArgumentException();
	}

	public unsafe void OnDestroy()
	{
		UIScreenController uIScreenController = UIScreenController.Instance;
		if (~(uIScreenController.stoppingFromEditor ? 1u : 0u) != 0)
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(IngameScreen.SetMultiplierLabel));
			Delegate obj = Delegate.Remove(playerInfo.onScoreMultiplierChanged, action);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			Action onScoreMultiplierChanged = default;
			playerInfo.onScoreMultiplierChanged = onScoreMultiplierChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			GameStats gameStats = GameStats.Instance;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(IngameScreen.OnCoinsChanged));
			gameStats.OnCoinsChanged -= action2;
			Action action3 = default;
			action3._002Ector(this, (nint)__ldftn(IngameScreen.OnGameStarted));
			Game.OnGameStarted -= action3;
		}
	}

	private void OnPauseChange(bool pause)
	{
		if (pause)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeSelf)
		{
			return;
		}
		GameObject gameObject2 = base.gameObject;
		if (gameObject2.activeInHierarchy)
		{
			if (_currentHeadstartState == SpeedometerState.active)
			{
				SpeedometerPauseHandle(_turboHeadstartPanel, PowerUpType.headstart);
			}
			if (_currentScoreboosterState == SpeedometerState.active)
			{
				SpeedometerPauseHandle(_scoreBoosterPanel, PowerUpType.scorebooster);
			}
		}
	}

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_014b: Expected Obj, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected I4, but got Unknown
		//IL_033b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		base.Show();
		ShowPopUp();
		UIScreenController uIScreenController = UIScreenController.Instance;
		uIScreenController.screen_game = SCREEN_GAME.GAME;
		Game game = Game.Instance;
		if (game == null)
		{
			return;
		}
		Game game2 = Game.Instance;
		if (~(game2._isPaused ? 1u : 0u) == 0)
		{
			UIScreenController uIScreenController2 = UIScreenController.Instance;
			if (~(uIScreenController2._isApplicationFocused ? 1u : 0u) == 0)
			{
				_countingDown = true;
				_countdownSeconds = 3f;
			}
		}
		if (~(_countingDown ? 1u : 0u) != 0)
		{
			MissionsManager missionsManager = MissionsManager.Instance;
			missionsManager.inRun = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+B8]");
			_ = 0;
			_ = MULTIPLIER_LABEL_ORIGINAL_COLOR;
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			TMP_Text tMP_Text = multiplierLabel;
			PlayerInfo playerInfo = PlayerInfo.Instance;
			object obj4 = playerInfo._currentMissionSet + 1;
			if ((nint)obj4 >= 30)
			{
				obj4 = 30;
			}
			if ((nint)obj4 <= 1)
			{
				obj4 = 1;
			}
			int num = obj + 28;
			string text = ((int*)num)->ToString();
			string text2 = "x" + text;
			nint num2 = (nint)tMP_Text;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ S2_v28 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		SocialManager socialManager = SocialManager.instance;
		socialManager.pausePhotoDownloading = true;
		if (TopRunRoot.manager__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
		SetPauseButtonVisibility(isActive: true);
		if (_weeklyHuntCounter != null)
		{
			bool active = WeeklyHuntManager.IsHuntStillActive();
			_weeklyHuntCounter.SetActive(active);
		}
		throw new ArgumentException();
	}

	private void GetComponent()
	{
		if (UIPopupIn == null)
		{
			UIPopupIn componentInChildren = GetComponentInChildren<UIPopupIn>();
			UIPopupIn = componentInChildren;
		}
	}

	private void ShowPopUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN_INGAME);
	}

	public void HidePupUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT_INGAME);
	}

	public unsafe override void Hide()
	{
		//IL_0022: Expected I, but got Obj
		//IL_003e: Expected I, but got Obj
		base.Hide();
		HidePupUp();
		SetMultiplierLabel();
		_countingDown = false;
		TMP_Text tMP_Text = countdownStartingLabel;
		nint num = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S2_v2 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = countdownLabel;
		nint num2 = (nint)tMP_Text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		SocialManager socialManager = SocialManager.instance;
		socialManager.pausePhotoDownloading = false;
		if (TopRunRoot.manager__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
		Action action = default;
		action._002Ector(this, (nint)__ldftn(IngameScreen.UpdateHuntLabel));
		WeeklyHuntManager.ItemCountUpdated -= action;
		throw new ArgumentException();
	}

	public void SetPauseButtonVisibility(bool isActive)
	{
		pauseButton.SetActive(isActive);
	}

	public void ToggleDebugPauseTimescale()
	{
		//IL_00b9: Expected VT, but got Obj
		//IL_00cb: Expected VT, but got Obj
		//IL_004e: Expected VT, but got Obj
		//IL_005c: Expected VT, but got Obj
		//IL_003b: Expected Obj, but got VT
		//IL_00af: Expected F4, but got I
		//IL_00af: Expected Obj, but got VT
		//IL_0099: Expected F4, but got I
		//IL_0099: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		float timeScale = Time.timeScale;
		_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
		if (timeScale > 0f)
		{
			((TimeScaleManager)val2).TimeScale = 0f;
			return;
		}
		float timeScale2 = Time.timeScale;
		_00210 val3 = (_00210)SingletonMonobehavior<>.Instance;
		_00210 val4 = (_00210)SingletonMonobehavior<>.Instance;
		if (timeScale2 == 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22 (T)+10]");
			((TimeScaleManager)val3).TimeScale = 0f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22 (T)+C]");
			((TimeScaleManager)val3).TimeScale = 0f;
		}
	}

	private unsafe void SetMultiplierLabel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected I4, but got Unknown
		//IL_007a: Expected I, but got Obj
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00a4: Expected I, but got Obj
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_0289: Expected I, but got Obj
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected I4, but got Unknown
		//IL_01e4: Expected I, but got Obj
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected I4, but got Unknown
		//IL_0328: Expected I, but got Obj
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		GameStats gameStats = GameStats.Instance;
		if (!gameStats._scoreBoosterActivated)
		{
			GameStats gameStats2 = GameStats.Instance;
			if (!gameStats2._characterDayEventActivated && ~(PlusMultiplier.plusMultiplierEnabled ? 1u : 0u) != 0)
			{
				goto IL_0225;
			}
		}
		PlayerInfo playerInfo = PlayerInfo.Instance;
		if (playerInfo._doubleScore)
		{
			goto IL_0225;
		}
		TMP_Text tMP_Text = multiplierLabel;
		nint num = (nint)tMP_Text;
		object obj3 = tMP_Text + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S1_v17 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = multiplierLabel;
		nint num2 = (nint)tMP_Text2;
		object obj4 = tMP_Text2 + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S2_v12 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
		string text = default;
		int num3 = text.IndexOf("x");
		int startIndex = num3 + 1;
		string text2 = default;
		string s = text2.Substring(startIndex);
		int num4 = int.Parse(s);
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		int scoreMultiplier = playerInfo2.scoreMultiplier;
		if (scoreMultiplier > num4)
		{
			int num5 = num4 + 1;
			if (!(lerpFactor > 1f))
			{
				num5 = num4;
			}
			doLastIteration = false;
			_isMultiplierLabelUpdated = false;
			TMP_Text tMP_Text3 = multiplierLabel;
			int num6 = obj + 12;
			string text3 = ((int*)num6)->ToString();
			string text4 = "x" + text3;
			nint num7 = (nint)tMP_Text3;
			object obj5 = tMP_Text3 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v184 @ S2_v29 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else
		{
			TMP_Text tMP_Text4 = multiplierLabel;
			PlayerInfo playerInfo3 = PlayerInfo.Instance;
			int scoreMultiplier2 = playerInfo3.scoreMultiplier;
			int num8 = obj + 8;
			string text5 = ((int*)num8)->ToString();
			string text6 = "x" + text5;
			nint num9 = (nint)tMP_Text4;
			object obj6 = tMP_Text4 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ S2_v22 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			if (~(doLastIteration ? 1u : 0u) == 0)
			{
				_isMultiplierLabelUpdated = true;
			}
			doLastIteration = true;
		}
		goto IL_0345;
		IL_0225:
		TMP_Text tMP_Text5 = multiplierLabel;
		PlayerInfo playerInfo4 = PlayerInfo.Instance;
		int scoreMultiplier3 = playerInfo4.scoreMultiplier;
		int num10 = obj + 8;
		string text7 = ((int*)num10)->ToString();
		string text8 = "x" + text7;
		nint num11 = (nint)tMP_Text5;
		object obj7 = tMP_Text5 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		goto IL_0345;
		IL_0345:
		ResizeMultiplierBox();
	}

	private unsafe void FadeFromWhiteToDarkBlue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got VT
		//IL_0197: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I
		//IL_0259: Expected Obj, but got F4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02a4: Expected I, but got Obj
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		//IL_00bd: Expected Obj, but got VT
		//IL_0307: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = SCOREBOOSTER_ELECTRICBLUE - SCOREBOOSTER_WHITE;
		float num = Math.Min(lerpFactor, 1f);
		bool flag = lerpFactor < 0f;
		float num2 = 0f;
		if (!flag)
		{
			num2 = num;
		}
		float num3 = (float)obj3 * num2;
		float num4 = (float)SCOREBOOSTER_WHITE + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+94]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+A4]");
		object obj4 = num5 - 0;
		float num6 = (float)obj4 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+A4]");
		float num7 = 0f + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+9C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+AC]");
		object obj5 = num8 - 0;
		float num9 = (float)obj5 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+AC]");
		float num10 = 0f + num9;
		object obj6 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+98]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+A8]");
		object obj7 = num11 - 0;
		float num12 = (float)obj7 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+A8]");
		float num13 = 0f + num12;
		obj6 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		object obj8 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		TMP_Text tMP_Text = multiplierLabel;
		nint num14 = (nint)tMP_Text;
		object obj9 = tMP_Text + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S1_v29 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
		PlayerInfo playerInfo = PlayerInfo.Instance;
		int scoreMultiplier = playerInfo.scoreMultiplier;
		int num15 = obj + 76;
		string text = ((int*)num15)->ToString();
		string value = string.Empty + text;
		string text2 = default;
		if (text2.Contains(value) && ~(doLastIteration ? 1u : 0u) == 0)
		{
			object obj10 = SCOREBOOSTER_ACTIVE_COLOR - SCOREBOOSTER_WHITE;
			float num16 = Math.Min(lerpFactor, 1f);
			bool flag2 = lerpFactor < 0f;
			float num17 = 0f;
			if (!flag2)
			{
				num17 = num16;
			}
			float num18 = (float)obj10 * num17;
			float num19 = (float)SCOREBOOSTER_WHITE + num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+84]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+A4]");
			object obj11 = num20 - 0;
			float num21 = (float)obj11 * num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+A4]");
			float num22 = 0f + num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+8C]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+AC]");
			object obj12 = num23 - 0;
			float num24 = (float)obj12 * num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+AC]");
			float num25 = 0f + num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+88]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+A8]");
			object obj13 = num26 - 0;
			float num27 = (float)obj13 * num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+A8]");
			float num28 = 0f + num27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			object obj14 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
	}

	public void ResetMultiplierLabelColour()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b4: Expected I, but got Obj
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_019e: Invalid comparison between Obj and F4
		//IL_01c9: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 48;
		GameStats gameStats = GameStats.Instance;
		if (~(gameStats._scoreBoosterActivated ? 1u : 0u) != 0)
		{
			GameStats gameStats2 = GameStats.Instance;
			if (~(gameStats2._characterDayEventActivated ? 1u : 0u) != 0)
			{
				object obj3 = obj + 32;
				TMP_Text tMP_Text = multiplierLabel;
				nint num = (nint)tMP_Text;
				object obj4 = tMP_Text + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+16C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				object obj5 = 0 - MULTIPLIER_LABEL_ORIGINAL_COLOR;
				object obj6 = obj5 * obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+B4]");
				object obj7 = num2 - 0;
				object obj8 = obj7 * obj7;
				object obj9 = obj6 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+B8]");
				object obj10 = num3 - 0;
				object obj11 = obj10 * obj10;
				object obj12 = obj9 + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+BC]");
				object obj13 = num4 - 0;
				object obj14 = obj13 * obj13;
				object obj15 = obj12 + obj14;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+B8]");
					_ = 0;
					obj = MULTIPLIER_LABEL_ORIGINAL_COLOR;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				}
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+88]");
		_ = 0;
		_ = SCOREBOOSTER_ACTIVE_COLOR;
		object obj16 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
	}

	private void OnHeadstartActivated(int headstartTier)
	{
		//IL_004f: Expected I4, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected I4, but got Unknown
		_currentHeadstartGear = headstartTier;
		_jetpackIsActive = true;
		ChangeSpeedometerState(_currentHeadstartState, SpeedometerState.active, PowerUpType.headstart, _turboHeadstartPanel);
		AnimateHeadstartIndicator();
		AnimateGearAndGlow((PowerUpType)this, _currentHeadstartGear, HeadstartSpeedometer);
		object obj = _currentHeadstartGear - 1;
		if ((nint)obj <= 2)
		{
			GameStats gameStats = GameStats.Instance;
			object obj2 = obj << 2;
			object obj3 = obj2 + 2288280;
			int amountLeftToConsume = gameStats._amountLeftToConsume + obj3;
			gameStats._amountLeftToConsume = amountLeftToConsume;
		}
		if (_currentScoreboosterState == SpeedometerState.hidden)
		{
			if (_currentScoreBoosterGear >= 1)
			{
				ReenableActiveScoreboosters();
			}
			else
			{
				ChangeSpeedometerState(SpeedometerState.hidden, SpeedometerState.inactive, PowerUpType.scorebooster, _scoreBoosterPanel);
			}
		}
	}

	private void OnHeadstartDeactivated()
	{
		_jetpackIsActive = false;
		if (~(_scoreboosterTimePeriodIsActive ? 1u : 0u) != 0)
		{
			ChangeSpeedometerState(_currentHeadstartState, SpeedometerState.hidden, PowerUpType.headstart, _turboHeadstartPanel);
			ChangeSpeedometerState(_currentScoreboosterState, SpeedometerState.hidden, PowerUpType.scorebooster, _scoreBoosterPanel);
		}
	}

	private void SetScoreboosterTimePeriodIsActive()
	{
		_scoreboosterTimePeriodIsActive = false;
	}

	private void OnScoreboosterActivated(int scoreboosterTier)
	{
		//IL_0085: Expected I4, but got Obj
		float hideTime;
		if (!slideinPowerupHelper.ScoreboosterButtonIsActive())
		{
			bool flag = slideinPowerupHelper.HeadstartButtonIsActive();
			bool flag2 = !flag;
			hideTime = 3f;
			if (flag2)
			{
				goto IL_00d0;
			}
		}
		hideTime = 5f;
		goto IL_00d0;
		IL_00d0:
		RestartHidingScoreboosterSpeedometer(hideTime);
		_currentScoreBoosterGear = scoreboosterTier;
		ChangeSpeedometerState(_currentScoreboosterState, SpeedometerState.active, PowerUpType.scorebooster, _scoreBoosterPanel);
		AnimateScoreboosterIndicator();
		AnimateGearAndGlow((PowerUpType)this, _currentScoreBoosterGear, ScoreboosterSpeedometer);
		if (_currentHeadstartState == SpeedometerState.hidden)
		{
			ChangeSpeedometerState(SpeedometerState.hidden, SpeedometerState.inactive, PowerUpType.headstart, _turboHeadstartPanel);
		}
	}

	private void DeactivateScoreboosterSpeedometer()
	{
		GameObject gameObject = base.gameObject;
		if (gameObject.activeSelf)
		{
			if (_currentScoreboosterState == SpeedometerState.inactive || (_currentScoreboosterState == SpeedometerState.active && !_jetpackIsActive))
			{
				ChangeSpeedometerState(_currentScoreboosterState, SpeedometerState.hidden, PowerUpType.scorebooster, _scoreBoosterPanel);
			}
			if (_currentHeadstartState == SpeedometerState.inactive || (_currentHeadstartState == SpeedometerState.active && !_jetpackIsActive))
			{
				ChangeSpeedometerState(_currentHeadstartState, SpeedometerState.hidden, PowerUpType.headstart, _turboHeadstartPanel);
			}
		}
	}

	private void ChangeSpeedometerState(SpeedometerState currentState, SpeedometerState nextState, PowerUpType powerUpType, CanvasGroup speedometerPanel)
	{
		if (nextState != SpeedometerState.hidden)
		{
			ToggleSpeedoMeterActive(nextState, powerUpType);
		}
		bool flag = currentState == SpeedometerState.active;
		float startValue = 1f;
		if (!flag)
		{
			startValue = 0f;
		}
		if (currentState == SpeedometerState.inactive)
		{
			startValue = 0.35f;
		}
		bool flag2 = nextState == SpeedometerState.active;
		float endValue = 1f;
		if (!flag2)
		{
			endValue = 0f;
		}
		if (nextState == SpeedometerState.inactive)
		{
			endValue = 0.35f;
		}
		IEnumerator coroutine = AnimateSpeedoMeterPanel(powerUpType, nextState, startValue, endValue, speedometerPanel);
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	private float GetCorrespondingAlphaValue(SpeedometerState state)
	{
		bool flag = state == SpeedometerState.active;
		float result = 1f;
		if (!flag)
		{
			result = 0f;
		}
		if (state == SpeedometerState.inactive)
		{
			result = 0.35f;
		}
		return result;
	}

	private IEnumerator AnimateSpeedoMeterPanel(PowerUpType type, SpeedometerState nextState, float startValue, float endValue, CanvasGroup uiSpeedoMeterPanel)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void ToggleSpeedoMeterActive(SpeedometerState state, PowerUpType type)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		object obj = type - 1;
		if (type != PowerUpType.headstart)
		{
			if ((nint)obj == 1)
			{
				_scoreBoosterUI.SetActive(value: true);
				GameObject gameObject = _scoreBoosterIndicator.gameObject;
				bool active = state == SpeedometerState.active;
				gameObject.SetActive(active);
				Gear[] scoreboosterSpeedometer = ScoreboosterSpeedometer;
				object obj2 = 0;
				while (scoreboosterSpeedometer.Length > (nint)obj2)
				{
					object obj3 = obj2 << 2;
					object obj4 = (object)scoreboosterSpeedometer + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v37+10]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v38+1C]");
					((Behaviour)0).enabled = active;
					object obj6 = obj2 + 1;
					obj2 = obj6;
				}
				bool currentScoreboosterState = state == SpeedometerState.active;
				_currentScoreboosterState = (currentScoreboosterState ? SpeedometerState.active : SpeedometerState.inactive);
			}
		}
		else
		{
			_turboHeadstartUI.SetActive(value: true);
			GameObject gameObject2 = _turboHeadstartIndicator.gameObject;
			bool active2 = state == SpeedometerState.active;
			gameObject2.SetActive(active2);
			Gear[] headstartSpeedometer = HeadstartSpeedometer;
			object obj7 = 0;
			while (headstartSpeedometer.Length > (nint)obj7)
			{
				object obj8 = obj7 << 2;
				object obj9 = (object)headstartSpeedometer + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v17+10]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v18+1C]");
				((Behaviour)0).enabled = active2;
				object obj11 = obj7 + 1;
				obj7 = obj11;
			}
			bool currentHeadstartState = state == SpeedometerState.active;
			_currentHeadstartState = (currentHeadstartState ? SpeedometerState.active : SpeedometerState.inactive);
		}
	}

	private void OnGameReviveOffer()
	{
		if (_currentScoreboosterState != SpeedometerState.hidden)
		{
			ChangeSpeedometerState(_currentScoreboosterState, SpeedometerState.hidden, PowerUpType.scorebooster, _scoreBoosterPanel);
		}
		if (_currentHeadstartState != SpeedometerState.hidden)
		{
			ChangeSpeedometerState(_currentHeadstartState, SpeedometerState.hidden, PowerUpType.headstart, _turboHeadstartPanel);
		}
	}

	private void SpeedometerPauseHandle(CanvasGroup uiPanel, PowerUpType powerUpType)
	{
		//IL_0080: Expected Obj, but got I4
		if (!(uiPanel != null))
		{
			return;
		}
		float alpha = uiPanel.alpha;
		if (!(alpha > 0f))
		{
			return;
		}
		GameObject gameObject = uiPanel.gameObject;
		if (!gameObject.activeSelf)
		{
			return;
		}
		object obj = powerUpType - 1;
		if (powerUpType != PowerUpType.headstart)
		{
			if ((nint)obj == 1)
			{
				AnimateScoreboosterIndicator();
			}
		}
		else
		{
			AnimateHeadstartIndicator();
		}
	}

	private IEnumerator AnimatePanelAlpha(float startValue, float endValue, CanvasGroup uiSpeedoMeterPanel)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateSpriteColor(Gear gear, float speedFactor)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void AnimateGearAndGlow(PowerUpType type, int currentGear, Gear[] gears)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got VT
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00e0: Expected I4, but got F4
		//IL_00ef: Expected Obj, but got VT
		//IL_010c: Expected Obj, but got F4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_014a: Expected I4, but got F4
		//IL_0159: Expected Obj, but got VT
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got F4
		//IL_0191: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I
		object obj = default;
		IngameScreen ingameScreen = (IngameScreen)(obj - 32);
		object obj2 = currentGear - 1;
		object obj3 = obj2 << 2;
		object obj4 = (object)gears + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v8+10]");
		object obj5 = 0;
		object obj6 = GlobalColors.FINAL_GEAR_GLOW_COLOR >> 16;
		object obj7 = obj6 & 0xFF;
		float num = (float)obj7 / 255f;
		ingameScreen._selectedFooterButton = (int)num;
		object obj8 = GlobalColors.FINAL_GEAR_GLOW_COLOR >> 24;
		float num2 = (float)obj8 / 255f;
		ingameScreen._footerHandler = (UIFooterHandler)num2;
		((UnityEngine.Object)ingameScreen).m_CachedPtr = (IntPtr)ingameScreen._selectedFooterButton;
		object obj9 = GlobalColors.FINAL_GEAR_GLOW_COLOR & 0xFF;
		float num3 = (float)obj9 / 255f;
		((UIScreen)ingameScreen).addScreen = (byte)(int)num3 != 0;
		object obj10 = GlobalColors.FINAL_GEAR_GLOW_COLOR >> 8;
		object obj11 = obj10 & 0xFF;
		float num4 = (float)obj11 / 255f;
		ingameScreen._footerPrefab = (GameObject)num4;
		ingameScreen = (IngameScreen)((UIScreen)ingameScreen).addScreen;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		object obj12 = currentGear - 1;
		object obj13 = obj12 << 2;
		object obj14 = (object)gears + obj13;
		IngameScreen ingameScreen2 = ingameScreen;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v29+10]");
		ingameScreen2.ActivateGear((Gear)0);
		object obj15 = currentGear - 1;
		object obj16 = obj15 << 2;
		object obj17 = (object)gears + obj16;
		IngameScreen ingameScreen3 = ingameScreen;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v32+10]");
		IEnumerator coroutine = ingameScreen3.AnimateSpriteColor((Gear)0, 1.5f);
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	private void SetActiveGears(PowerUpType type, int currentGear, Gear[] gears)
	{
		//IL_003a: Expected Obj, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		IngameScreen ingameScreen = null;
		while ((nint)ingameScreen < currentGear)
		{
			object obj = (object)ingameScreen << 2;
			object obj2 = (object)gears + obj;
			IngameScreen ingameScreen2 = ingameScreen;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v4+10]");
			ingameScreen2.ActivateGearNoAnimation((Gear)0);
			IngameScreen ingameScreen3 = (IngameScreen)(ingameScreen + 1);
			ingameScreen = ingameScreen3;
		}
	}

	private unsafe void HideTurboHeadstartSpeedoMeter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005c: Expected F4, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected VT, but got Unknown
		//IL_00e8: Expected F4, but got I
		//IL_00e3: Expected native int or pointer, but got VT
		//IL_010a: Expected F4, but got I
		//IL_0105: Expected native int or pointer, but got VT
		//IL_012d: Expected Obj, but got VT
		//IL_013c: Expected Obj, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		_turboHeadstartUI.SetActive(value: false);
		_turboHeadstartPanel.alpha = 0f;
		_currentHeadstartGear = 0;
		int[] turboHeadstartGearZRotations = _turboHeadstartGearZRotations;
		_currentHeadstartIndicatorZRotation = turboHeadstartGearZRotations[0];
		int[] turboHeadstartGearZRotations2 = _turboHeadstartGearZRotations;
		float num = (float)turboHeadstartGearZRotations2[0] * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		_ = 0f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		_turboHeadstartIndicator.localRotation = quaternion;
		((IngameScreen)quaternion).DeactivateGears(HeadstartSpeedometer);
		((IngameScreen)quaternion).ResetGlow(HeadstartSpeedometer);
		_jetpackIsActive = false;
		_currentHeadstartState = SpeedometerState.hidden;
	}

	private unsafe void HideScoreboosterSpeedoMeter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0051: Expected F4, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected VT, but got Unknown
		//IL_00dd: Expected F4, but got I
		//IL_00d8: Expected native int or pointer, but got VT
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_0122: Expected Obj, but got VT
		//IL_0131: Expected Obj, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		_scoreBoosterUI.SetActive(value: false);
		_scoreBoosterPanel.alpha = 0f;
		int[] scoreBoosterGearZRotations = _scoreBoosterGearZRotations;
		_currentScoreBoosterIndicatorZRotation = scoreBoosterGearZRotations[0];
		int[] scoreBoosterGearZRotations2 = _scoreBoosterGearZRotations;
		float num = (float)scoreBoosterGearZRotations2[0] * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		_ = 0f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		_scoreBoosterIndicator.localRotation = quaternion;
		((IngameScreen)quaternion).DeactivateGears(ScoreboosterSpeedometer);
		((IngameScreen)quaternion).ResetGlow(ScoreboosterSpeedometer);
		_currentScoreboosterState = SpeedometerState.hidden;
	}

	private void ResetGlow(Gear[] gears)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_004d: Expected Obj, but got VT
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got VT
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got VT
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = 0;
		while (gears.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)gears + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15+10]");
			object obj6 = 0;
			object obj7 = GlobalColors.INITIAL_GEAR_GLOW_COLOR >> 16;
			object obj8 = obj7 & 0xFF;
			float num = (float)obj8 / 255f;
			object obj9 = GlobalColors.INITIAL_GEAR_GLOW_COLOR >> 24;
			float num2 = (float)obj9 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			object obj10 = GlobalColors.INITIAL_GEAR_GLOW_COLOR & 0xFF;
			float num3 = (float)obj10 / 255f;
			object obj11 = GlobalColors.INITIAL_GEAR_GLOW_COLOR >> 8;
			object obj12 = obj11 & 0xFF;
			float num4 = (float)obj12 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			object obj13 = obj3 + 1;
			obj3 = obj13;
		}
	}

	private void ActivateGear(Gear gear)
	{
		IEnumerator coroutine = ((IngameScreen)(object)gear).AnimateSpriteColor(gear, 100f);
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	private void ActivateGearNoAnimation(Gear gear)
	{
		gear.background.sprite = gear.active;
	}

	private void DeactivateGears(Gear[] gears)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		object obj = 0;
		while (gears.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)gears + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v7+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v8+C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v8+18]");
			((Image)num).sprite = (Sprite)0;
			object obj5 = obj + 1;
			obj = obj5;
		}
	}

	private void AnimateHeadstartIndicator()
	{
		IEnumerator routine = AnimateHeadstartIndicatorGear();
		StopCoroutine(routine);
		IEnumerator routine2 = AnimateHeadstartIndicatorGear();
		Coroutine coroutine = StartCoroutine(routine2);
	}

	private IEnumerator AnimateHeadstartIndicatorGear()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void SetScoreboosterIndicator(int gear)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003d: Expected F4, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected VT, but got Unknown
		//IL_00bd: Expected F4, but got I
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_00df: Expected F4, but got I
		//IL_00da: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		int num = gear << 2;
		object obj2 = _scoreBoosterGearZRotations + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v4+10]");
		_currentScoreBoosterIndicatorZRotation = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v4+10]");
		float num2 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		_ = 0f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		_scoreBoosterIndicator.localRotation = quaternion;
	}

	private void AnimateScoreboosterIndicator()
	{
		StopCoroutine("AnimateScoreboosterIndicatorGear");
		Coroutine coroutine = StartCoroutine("AnimateScoreboosterIndicatorGear");
	}

	private IEnumerator AnimateScoreboosterIndicatorGear()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			if (uIScreenController.CurrenScreen == SCREEN.InGame)
			{
				UIScreenController uIScreenController2 = UIScreenController.Instance;
				uIScreenController2.PushScreen("PauseUI");
			}
		}
		UpdateMultiplierLabel();
		GameStats gameStats = GameStats.Instance;
		gameStats.CalculateScore();
		GameStats gameStats2 = GameStats.Instance;
		if (score != gameStats2._score)
		{
			SetScoreLabel();
		}
		Game game = Game.Instance;
		if (~(game.isReadyForSlideinPowerups__BackingField ? 1u : 0u) == 0)
		{
			Game game2 = Game.Instance;
			if (!game2.IsRunningOnTutorialTrack__BackingField)
			{
				Game game3 = Game.Instance;
				game3.isReadyForSlideinPowerups__BackingField = false;
				slideinPowerupHelper.ShowPowerups();
			}
		}
		AnimateCoinsLabelIfDoubleCoins();
	}

	private void AnimateCoinsLabelIfDoubleCoins()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got VT
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_0286: Expected Obj, but got VT
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02db: Expected Obj, but got VT
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_030e: Expected Obj, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_0373: Expected Obj, but got VT
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_03a0: Expected Obj, but got VT
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_03ff: Expected Obj, but got VT
		//IL_041e: Expected Obj, but got VT
		//IL_047c: Expected Obj, but got VT
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_04a9: Expected Obj, but got VT
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got VT
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got VT
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got VT
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 96;
		if (~(DoubleCoins.HasDoubleCoinsModifier ? 1u : 0u) == 0)
		{
			float deltaTime = Time.deltaTime;
			float num = deltaTime + deltaTime;
			if ((lerpFactorCoins += num) > 1f)
			{
				if (DoubleCoins.numberOfAnimationBlinks <= 1)
				{
					int numberOfAnimationBlinks = DoubleCoins.numberOfAnimationBlinks + 1;
					DoubleCoins.numberOfAnimationBlinks = numberOfAnimationBlinks;
					lerpFactorCoins = 0f;
					return;
				}
				object obj3 = GlobalColors.COINS_LIGHT_PURPLE >> 16;
				object obj4 = obj3 & 0xFF;
				float num2 = (float)obj4 / 255f;
				object obj5 = GlobalColors.COINS_LIGHT_PURPLE >> 24;
				float num3 = (float)obj5 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				object obj6 = GlobalColors.COINS_LIGHT_PURPLE & 0xFF;
				float num4 = (float)obj6 / 255f;
				object obj7 = GlobalColors.COINS_LIGHT_PURPLE >> 8;
				object obj8 = obj7 & 0xFF;
				float num5 = (float)obj8 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				object obj9 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				return;
			}
			object obj10 = GlobalColors.COINS_LIGHT_PURPLE & 0xFF;
			float num6 = (float)obj10 / 255f;
			object obj11 = GlobalColors.COINS_DARK_PURPLE & 0xFF;
			float num7 = (float)obj11 / 255f;
			float num8 = num7 - num6;
			float num9 = Math.Min(lerpFactorCoins, 1f);
			bool flag = lerpFactorCoins < 0f;
			float num10 = 0f;
			if (!flag)
			{
				num10 = num9;
			}
			float num11 = num8 * num10;
			float num12 = num6 + num11;
			object obj12 = GlobalColors.COINS_LIGHT_PURPLE >> 16;
			object obj13 = obj12 & 0xFF;
			float num13 = (float)obj13 / 255f;
			object obj14 = GlobalColors.COINS_DARK_PURPLE >> 16;
			object obj15 = obj14 & 0xFF;
			float num14 = (float)obj15 / 255f;
			float num15 = num14 - num13;
			float num16 = num15 * num10;
			float num17 = num13 + num16;
			object obj16 = GlobalColors.COINS_LIGHT_PURPLE >> 24;
			float num18 = (float)obj16 / 255f;
			object obj17 = GlobalColors.COINS_DARK_PURPLE >> 24;
			float num19 = (float)obj17 / 255f;
			float num20 = num19 - num18;
			float num21 = num20 * num10;
			float num22 = num18 + num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			object obj18 = GlobalColors.COINS_LIGHT_PURPLE >> 8;
			object obj19 = obj18 & 0xFF;
			float num23 = (float)obj19 / 255f;
			object obj20 = GlobalColors.COINS_DARK_PURPLE >> 8;
			object obj21 = obj20 & 0xFF;
			float num24 = (float)obj21 / 255f;
			float num25 = num24 - num23;
			float num26 = num25 * num10;
			float num27 = num23 + num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			object obj22 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
		else
		{
			object obj23 = GlobalColors.COINS_ORIGINAL_COLOR >> 16;
			object obj24 = obj23 & 0xFF;
			float num28 = (float)obj24 / 255f;
			object obj25 = GlobalColors.COINS_ORIGINAL_COLOR >> 24;
			float num29 = (float)obj25 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			object obj26 = GlobalColors.COINS_ORIGINAL_COLOR & 0xFF;
			float num30 = (float)obj26 / 255f;
			object obj27 = GlobalColors.COINS_ORIGINAL_COLOR >> 8;
			object obj28 = obj27 & 0xFF;
			float num31 = (float)obj28 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			lerpFactorCoins = 0f;
		}
	}

	private unsafe void UpdateMultiplierLabel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0233: Expected I, but got Obj
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0272: Expected F8, but got I4
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected I4, but got Unknown
		//IL_06ef: Expected I, but got Obj
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0748: Expected I, but got Obj
		//IL_0768: Expected Obj, but got VT
		//IL_0792: Expected Obj, but got I
		//IL_07c9: Expected Obj, but got I
		//IL_07ec: Invalid comparison between Obj and F4
		//IL_04cc: Expected Obj, but got VT
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_04f9: Expected Obj, but got VT
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_0558: Expected Obj, but got VT
		//IL_0577: Expected Obj, but got VT
		//IL_05d5: Expected Obj, but got VT
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_0602: Expected Obj, but got VT
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Obj, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected VT, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02f9: Expected VT, but got I
		//IL_0345: Expected I, but got Obj
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_036f: Expected I, but got Obj
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 112;
		_ = 0;
		GameStats gameStats = GameStats.Instance;
		if (!gameStats._scoreBoosterActivated)
		{
			GameStats gameStats2 = GameStats.Instance;
			if (!gameStats2._characterDayEventActivated && ~(PlusMultiplier.plusMultiplierEnabled ? 1u : 0u) != 0)
			{
				goto IL_0196;
			}
		}
		if (!_isMultiplierLabelUpdated)
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			if (!playerInfo._doubleScore)
			{
				float deltaTime = Time.deltaTime;
				float num = 4f;
				if (!PlusMultiplier.plusMultiplierEnabled)
				{
					num = 2f;
				}
				float num2 = deltaTime * num;
				if ((lerpFactor += num2) > 1f)
				{
					SetMultiplierLabel();
					lerpFactor = 0f;
				}
				else if (~(PlusMultiplier.plusMultiplierEnabled ? 1u : 0u) != 0)
				{
					FadeFromWhiteToDarkBlue();
				}
				else if (!doLastIteration)
				{
					object obj3 = GlobalColors.MULTIPLIER_DARK_PURPLE & 0xFF;
					float num3 = (float)obj3 / 255f;
					object obj4 = GlobalColors.MULTIPLIER_LIGHT_PURPLE & 0xFF;
					float num4 = (float)obj4 / 255f;
					float num5 = num4 - num3;
					float num6 = Math.Min(lerpFactor, 1f);
					bool flag = lerpFactor < 0f;
					float num7 = 0f;
					if (!flag)
					{
						num7 = num6;
					}
					float num8 = num5 * num7;
					float num9 = num3 + num8;
					object obj5 = GlobalColors.MULTIPLIER_DARK_PURPLE >> 16;
					object obj6 = obj5 & 0xFF;
					float num10 = (float)obj6 / 255f;
					object obj7 = GlobalColors.MULTIPLIER_LIGHT_PURPLE >> 16;
					object obj8 = obj7 & 0xFF;
					float num11 = (float)obj8 / 255f;
					float num12 = num11 - num10;
					float num13 = num12 * num7;
					float num14 = num10 + num13;
					object obj9 = GlobalColors.MULTIPLIER_DARK_PURPLE >> 24;
					float num15 = (float)obj9 / 255f;
					object obj10 = GlobalColors.MULTIPLIER_LIGHT_PURPLE >> 24;
					float num16 = (float)obj10 / 255f;
					float num17 = num16 - num15;
					float num18 = num17 * num7;
					float num19 = num15 + num18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					object obj11 = GlobalColors.MULTIPLIER_DARK_PURPLE >> 8;
					object obj12 = obj11 & 0xFF;
					float num20 = (float)obj12 / 255f;
					object obj13 = GlobalColors.MULTIPLIER_LIGHT_PURPLE >> 8;
					object obj14 = obj13 & 0xFF;
					float num21 = (float)obj14 / 255f;
					float num22 = num21 - num20;
					float num23 = num22 * num7;
					float num24 = num20 + num23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
					_ = 0;
					object obj15 = obj + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				}
			}
		}
		goto IL_0196;
		IL_0196:
		if (~(_countingDown ? 1u : 0u) != 0)
		{
			return;
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if (~(uIScreenController._isApplicationFocused ? 1u : 0u) != 0)
		{
			return;
		}
		float num25 = UpdateRealTimeDelta();
		float num26 = num25 * 1.75f;
		float countdownSeconds = _countdownSeconds - num26;
		_countdownSeconds = countdownSeconds;
		TMP_Text tMP_Text = countdownStartingLabel;
		string text = Strings.Get(StringID.INGAME_UI_COUNTDOWN_STARTING);
		nint num27 = (nint)tMP_Text;
		object obj16 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v190 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = countdownLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
		double num28 = Math.Abs((double)_countdownSeconds);
		if (num28 < 2147483648.0)
		{
			double num29 = _countdownSeconds;
		}
		else
		{
			double num29 = -2147483648.0;
		}
		int num30 = obj + 108;
		string text2 = ((int*)num30)->ToString();
		nint num31 = (nint)tMP_Text2;
		object obj17 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v332 @ S2_v13 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		if (!countdownLabel.enabled)
		{
			countdownStartingLabel.enabled = true;
			countdownLabel.enabled = true;
		}
		nint num32 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num33 = 0;
		object obj18 = _cachedCountdownLabelScale - Vector3.zeroVector;
		object obj19 = obj18 * obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+74]");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v62 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
		object obj20 = num34 - 0;
		object obj21 = obj20 * obj20;
		object obj22 = obj19 + obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+78]");
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v62 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		object obj23 = num35 - 0;
		object obj24 = obj23 * obj23;
		object obj25 = obj22 + obj24;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
		{
			RectTransform rectTransform = countdownLabel.rectTransform;
			Vector3 localScale = rectTransform.localScale;
			object obj26 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_cachedCountdownLabelScale = (Vector3)0;
		}
		RectTransform rectTransform2 = countdownLabel.rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @440");
		object obj27 = default;
		float num36 = 1f - (float)obj27;
		float num37 = num36 * 0.5f;
		float num38 = num37 + 1f;
		float num39 = (float)_cachedCountdownLabelScale * num38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+78]");
		float num40 = 0f * num38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+74]");
		float num41 = 0f * num38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Vector3 localScale2 = (Vector3)(obj + 8);
		rectTransform2.localScale = localScale2;
		if (_countdownSeconds < 0f)
		{
			_countingDown = false;
			TMP_Text tMP_Text3 = countdownStartingLabel;
			nint num42 = (nint)tMP_Text3;
			object obj28 = tMP_Text3 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v485 @ S2_v33 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text4 = countdownLabel;
			nint num43 = (nint)tMP_Text4;
			object obj29 = tMP_Text4 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v501 @ S2_v37 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			countdownStartingLabel.enabled = false;
			countdownLabel.enabled = false;
			Game game = Game.Instance;
			if (game != null)
			{
				Game game2 = Game.Instance;
				game2.TriggerPause(pauseGame: false);
				Character character = Character.Instance;
				float time = Time.time;
				character.sameLaneTimeStamp = time;
			}
		}
	}

	private unsafe void OnCoinsChanged()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		//IL_005b: Expected I, but got Obj
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		TMP_Text tMP_Text = coinLabel;
		GameStats gameStats = GameStats.Instance;
		int coinsCollected = gameStats.CoinsCollected;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)tMP_Text;
		object obj3 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		ResizeCoinBox();
	}

	private void OnGameStarted()
	{
		lastKnowDigits = 0;
		Game game = Game.Instance;
		if (~(game.isReadyForSlideinPowerups__BackingField ? 1u : 0u) != 0)
		{
			slideinPowerupHelper.HidePowerup1(instant: true);
			slideinPowerupHelper.HidePowerup2(instant: true);
		}
		HideTurboHeadstartSpeedoMeter();
		HideScoreboosterSpeedoMeter();
	}

	private unsafe void SetScoreLabel()
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected I4, but got Unknown
		//IL_00e6: Expected Obj, but got I4
		//IL_0138: Expected I, but got Obj
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0162: Expected I, but got Obj
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I
		//IL_0044: Expected F8, but got I4
		//IL_01dd: Expected I, but got Obj
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01fd: Invalid comparison between Obj and F8
		//IL_005b: Expected I, but got Obj
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		GameStats gameStats = GameStats.Instance;
		score = gameStats._score;
		int num = (digits = Utility.NumberOfDigits(gameStats._score));
		int num2 = this + 304;
		TMP_Text tMP_Text = scoreLabel;
		object obj = num - 1;
		if ((nint)obj >= 5)
		{
		}
		string text = ((int*)num2)->ToString();
		string text2 = string.Empty + text;
		nint num3 = (nint)tMP_Text;
		object obj2 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S2_v8 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = scoreLabel;
		nint num4 = (nint)tMP_Text2;
		object obj3 = tMP_Text2 + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S1_v15 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v13+8]");
		object obj4 = (nint)0 + (nint)1;
		float num5 = (float)obj4 * 36.7f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num7 = default;
		double num6 = Math.Abs(num7);
		if (!(num6 < 2147483648.0))
		{
			num7 = -2147483648.0;
		}
		scoreWidth = (float)num7;
		LayoutElement layoutElement = scoreBox;
		nint num8 = (nint)layoutElement;
		object obj5 = layoutElement + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S1_v27 (Il2CppClass<UnityEngine.UI.LayoutElement>)+1D4] (should have been resolved before IL gen)");
		object obj6 = default;
		if (obj6 != (object)num7)
		{
			LayoutElement layoutElement2 = scoreBox;
			nint num9 = (nint)layoutElement2;
			object obj7 = layoutElement2 + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S2_v20 (Il2CppClass<UnityEngine.UI.LayoutElement>)+1DC] (should have been resolved before IL gen)");
		}
		if (lastKnowDigits != digits)
		{
			ResizeScoreBox();
			lastKnowDigits = digits;
		}
	}

	private unsafe void ResizeScoreBox()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001e: Expected Obj, but got I4
		//IL_0083: Expected native int or pointer, but got VT
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00cc: Expected F4, but got I
		//IL_00c7: Expected native int or pointer, but got VT
		//IL_0044: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		object obj2 = digits - 6;
		if ((nint)obj2 >= 28)
		{
			obj2 = 28;
		}
		if ((nint)obj2 <= 0)
		{
			obj2 = 0;
		}
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IngameScreen)+4C]");
		_ = 0;
		object obj3 = obj2 * 11;
		object obj4 = _originalMultiplierPosition - obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		_multiplier.localPosition = vector;
	}

	private void ResizeCoinBox()
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I
		//IL_007c: Expected I, but got Obj
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_009e: Invalid comparison between Obj and F4
		//IL_00d2: Expected I, but got Obj
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		TMP_Text tMP_Text = coinLabel;
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S2_v2 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v3+8]");
		object obj2 = (nint)0 + (nint)1;
		float num2 = (float)obj2 * 36.7f;
		float num3 = num2 + 40f;
		coinWidth = num3;
		LayoutElement layoutElement = coinBox;
		nint num4 = (nint)layoutElement;
		object obj3 = layoutElement + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S1_v9 (Il2CppClass<UnityEngine.UI.LayoutElement>)+1D4] (should have been resolved before IL gen)");
		object obj4 = default;
		if (obj4 != (object)coinWidth)
		{
			LayoutElement layoutElement2 = coinBox;
			nint num5 = (nint)layoutElement2;
			object obj5 = layoutElement2 + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S2_v13 (Il2CppClass<UnityEngine.UI.LayoutElement>)+1DC] (should have been resolved before IL gen)");
		}
	}

	private void ResizeMultiplierBox()
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		TMP_Text tMP_Text = multiplierLabel;
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S2_v2 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v3+8]");
		_multiDigits = 0;
		int lastKnownMultiDigits = _lastKnownMultiDigits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v3+8]");
		if ((nint)lastKnownMultiDigits != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v3+8]");
			_lastKnownMultiDigits = 0;
		}
	}

	private void SincronizeHuntData()
	{
		WeeklyHuntManager.PrizePeriodId activePeriode = WeeklyHuntManager.GetActivePeriode();
		WeeklyHuntManager.WeeklyHuntPeriodData prizeDataForPeriod = WeeklyHuntManager.GetPrizeDataForPeriod(activePeriode);
		_currentWeekHuntPrize = prizeDataForPeriod;
		WeeklyHuntManager.WeeklyHuntPeriodData currentWeekHuntPrize = _currentWeekHuntPrize;
		_huntMaxItems = currentWeekHuntPrize.itemsToColect;
		_huntCollectedItems = currentWeekHuntPrize.itemsCollected;
		bool flag = currentWeekHuntPrize.itemsCollected >= 0;
		bool flag2 = !flag;
		int huntCollectedItems = 0;
		if (!flag2)
		{
			bool flag3 = currentWeekHuntPrize.itemsCollected <= currentWeekHuntPrize.itemsToColect;
			huntCollectedItems = currentWeekHuntPrize.itemsToColect;
			if (flag3)
			{
				return;
			}
		}
		_huntCollectedItems = huntCollectedItems;
	}

	private void OnApplicationPause(bool pause)
	{
		if (!pause)
		{
			UpdateHuntLabel();
		}
	}

	public unsafe void UpdateHuntLabel()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected I4, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		//IL_009d: Expected I, but got Obj
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		SincronizeHuntData();
		if (_huntAmountLabel != null)
		{
			bool flag = WeeklyHuntManager.IsHuntStillActive();
			_huntAmountLabel.enabled = flag;
			TMP_Text huntAmountLabel = _huntAmountLabel;
			int num = this + 292;
			string text = ((int*)num)->ToString();
			int num2 = this + 296;
			string text2 = ((int*)num2)->ToString();
			string text3 = text + "/" + text2;
			nint num3 = (nint)huntAmountLabel;
			object obj = huntAmountLabel + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		if (~(_hasCalculatedHuntLabelOffsets ? 1u : 0u) != 0)
		{
			_huntBgPositioning.ForceUpdate();
			_hasCalculatedHuntLabelOffsets = true;
		}
	}

	private void OnEnable()
	{
		Reset();
	}

	public unsafe void Reset()
	{
		mTimeDelta = 0f;
		mTimeStarted = true;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		mTimeStart = realtimeSinceStartup;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(IngameScreen.UpdateHuntLabel));
		WeeklyHuntManager.ItemCountUpdated += action;
		UpdateHuntLabel();
	}

	private float UpdateRealTimeDelta()
	{
		if (~(mTimeStarted ? 1u : 0u) == 0)
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float val = realtimeSinceStartup - mTimeStart;
			float num = Math.Max(val, 0f);
			float num2 = (mActual += num) * 1000f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			object obj = default;
			float num3 = (mTimeDelta = (float)obj * 0.001f);
			float num4 = mActual - num3;
			mTimeStart = realtimeSinceStartup;
			mActual = num4;
			return mTimeDelta;
		}
		mTimeStarted = true;
		float realtimeSinceStartup2 = Time.realtimeSinceStartup;
		mTimeDelta = 0f;
		mTimeStart = realtimeSinceStartup2;
		return 0f;
	}

	private void OnMenuScreenShown()
	{
		_currentScoreBoosterGear = 0;
		reviveCount__BackingField = 0;
	}

	private void ResetScoreboosterGear()
	{
		_currentScoreBoosterGear = 0;
	}

	private void OnGameRevived()
	{
		ReenableActiveScoreboosters();
		int num = reviveCount__BackingField + 1;
		reviveCount__BackingField = num;
	}

	private void ReenableActiveScoreboosters()
	{
		//IL_004e: Expected I4, but got Obj
		if (_currentScoreBoosterGear != 0)
		{
			ChangeSpeedometerState(_currentScoreboosterState, SpeedometerState.active, PowerUpType.scorebooster, _scoreBoosterPanel);
			SetActiveGears((PowerUpType)this, _currentScoreBoosterGear, ScoreboosterSpeedometer);
			SetScoreboosterIndicator(_currentScoreBoosterGear);
			if (_currentHeadstartState == SpeedometerState.hidden)
			{
				ChangeSpeedometerState(SpeedometerState.hidden, SpeedometerState.inactive, PowerUpType.headstart, _turboHeadstartPanel);
			}
			RestartHidingScoreboosterSpeedometer(5f);
		}
	}

	public void RestartHidingScoreboosterSpeedometer(float hideTime)
	{
		CancelInvoke("SetScoreboosterTimePeriodIsActive");
		CancelInvoke("DeactivateScoreboosterSpeedometer");
		_scoreboosterTimePeriodIsActive = true;
		StartHidingScoreboosterSpeedometer(hideTime);
	}

	private void StartHidingScoreboosterSpeedometer(float time)
	{
		Invoke("SetScoreboosterTimePeriodIsActive", time);
		Invoke("DeactivateScoreboosterSpeedometer", time);
	}

	public IngameScreen()
	{
		//IL_0083: Expected I, but got Obj
		//IL_00c4: Expected VT, but got I8
		//IL_00dd: Expected VT, but got I8
		//IL_00f6: Expected VT, but got I8
		//IL_010f: Expected VT, but got I8
		//IL_0037: Expected I4, but got I8
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_cachedCountdownLabelScale = Vector3.zeroVector;
		_ = 4575657221408423936L;
		MULTIPLIER_LABEL_ORIGINAL_COLOR = (Color)4565484386274770944L;
		_ = 4575657222473777152L;
		SCOREBOOSTER_WHITE = (Color)4575657222473777152L;
		_ = 4575657222473777152L;
		SCOREBOOSTER_ELECTRICBLUE = (Color)4547681921861156864L;
		_ = 4575657222473645566L;
		SCOREBOOSTER_ACTIVE_COLOR = (Color)4569440489236840384L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E._8CE304CB6202A0A2279CF4849C2B1BD98A5266A3D022D90A7F43604892BE4313));
		_turboHeadstartGearZRotations = (int[])array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E._7255DB0B6387DE9A01A708E69A9CE8401FABB013F52AED15732DBBEF4FB56F77));
		_scoreBoosterGearZRotations = (int[])array2;
		score = -1;
		_currentScoreboosterState = SpeedometerState.hidden;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Gear[] headstartSpeedometer = default;
		HeadstartSpeedometer = headstartSpeedometer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Gear[] scoreboosterSpeedometer = default;
		ScoreboosterSpeedometer = scoreboosterSpeedometer;
		base._002Ector();
	}
}
