using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Missions;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Managers;
using SYBO.Subway.Info;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CelebrationPopup : UIScreen
{
	private sealed class _003CCharacterIdleAnimCoroutine_003Ed__147(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			bool flag = _003C_003E1__state >= 2;
			bool result = false;
			if (!flag)
			{
				_003C_003E1__state = -1;
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				result = false;
				if (!celebrationPopup.stopIdleAnim)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					result = true;
				}
			}
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

	private sealed class _003CBoxIdleAnimCoroutine_003Ed__148(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00a2: Expected Obj, but got I4
			//IL_0137: Expected VT, but got I
			//IL_03bf: Expected F4, but got I
			//IL_03ba: Expected native int or pointer, but got VT
			//IL_03ce: Expected F4, but got VT
			//IL_03c9: Expected native int or pointer, but got VT
			//IL_02c6: Expected F4, but got I
			//IL_04ad: Expected F4, but got I
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						if (~(_003CdoneResetting_003E5__5 ? 1u : 0u) != 0)
						{
							goto IL_0245;
						}
					}
					goto IL_0379;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				CelebrationReward celebrationReward = reward;
				object obj2 = celebrationReward.CelebrationRewardOrigin & (CelebrationRewardOrigin)(-2);
				if ((nint)obj2 == 4)
				{
					celebrationPopup.audioStateLoop.PlayUnlockSound();
				}
				Transform parent = rewardTrans.parent;
				Vector3 localPosition = parent.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				_003CbaseLocalPos_003E5__2 = (Vector3)0;
				celebrationPopup.stopIdleAnim = false;
				float num = UnityEngine.Random.Range(0f, 6f);
				_003Ct_003E5__3 = num;
				_003CnewLocalPos_003E5__4 = _003CbaseLocalPos_003E5__2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+24]");
				_ = 0;
			}
			if (~(celebrationPopup.stopIdleAnim ? 1u : 0u) == 0)
			{
				_003CdoneResetting_003E5__5 = false;
				goto IL_0245;
			}
			float deltaTime = Time.deltaTime;
			float num2 = (_003Ct_003E5__3 += deltaTime);
			float num3 = num2 + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
			object obj3 = default;
			float num4 = (float)obj3 * 10f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+20]");
			float num5 = 0f + num4;
			int num6 = 1;
			goto IL_039b;
			IL_0379:
			return true;
			IL_0245:
			float deltaTime2 = Time.deltaTime;
			float num7 = deltaTime2 * 20f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+20]");
			float num8 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+30]");
			float value = num8 - 0f;
			float num9 = Math.Abs(value);
			bool flag = !(num7 < num9);
			bool flag2 = !flag;
			bool flag3 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+20]");
			float num10 = 0f;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+20]");
				float num11 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+30]");
				float num12 = num11 - 0f;
				bool flag4 = !(num12 < 0f);
				float num13 = 1f;
				if (!flag4)
				{
					num13 = -1f;
				}
				float num14 = num13 * num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+30]");
				float num15 = 0f + num14;
				num10 = num15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+20]");
			float value2 = 0f - num10;
			float num16 = Math.Abs(value2);
			float num17 = Math.Abs(num10);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+20]");
			float num18 = Math.Abs(0f);
			if (!(num17 > num18))
			{
				num17 = num18;
			}
			float num19 = num17 * 1E-06f;
			float num20 = Mathf.Epsilon * 8f;
			if (!(num19 > num20))
			{
				num19 = num20;
			}
			bool flag5 = num16 < num19;
			bool flag6 = !flag5;
			num6 = 2;
			if (!flag6)
			{
				_003CdoneResetting_003E5__5 = true;
				num6 = 2;
			}
			goto IL_039b;
			IL_039b:
			Transform parent2 = rewardTrans.parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<BoxIdleAnimCoroutine>d__148)+34]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)_003CnewLocalPos_003E5__4;
			parent2.localPosition = vector;
			_003C_003E2__current = null;
			_003C_003E1__state = num6;
			goto IL_0379;
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

	private sealed class _003CStartIdleAnimationFor_003Ed__149(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform rewardTrans;

		public Vector3 baseLocalPos;

		private float _003Ct_003E5__2;

		private Vector3 _003CnewLocalPos_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0158: Expected F4, but got I
			//IL_0153: Expected native int or pointer, but got VT
			//IL_0167: Expected F4, but got VT
			//IL_0162: Expected native int or pointer, but got VT
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			object obj = default;
			Vector3 vector = (Vector3)(obj - 16);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_01ac;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (!(rewardTrans != null))
				{
					goto IL_01ac;
				}
				float num = UnityEngine.Random.Range(0f, 6f);
				_003Ct_003E5__2 = num;
				_003CnewLocalPos_003E5__3 = baseLocalPos;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<StartIdleAnimationFor>d__149)+1C]");
				_ = 0;
			}
			if (!(rewardTrans != null))
			{
				object obj2 = this + 36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			}
			else
			{
				float deltaTime = Time.deltaTime;
				float num2 = (_003Ct_003E5__2 += deltaTime);
				float num3 = num2 + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
				object obj3 = default;
				float num4 = (float)obj3 * 10f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<StartIdleAnimationFor>d__149)+18]");
				float num5 = 0f + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<StartIdleAnimationFor>d__149)+2C]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)_003CnewLocalPos_003E5__3;
				rewardTrans.localPosition = vector;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
			}
			goto IL_01ac;
			IL_01ac:
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

	private sealed class _003CAnimateScreenFlash_003Ed__153(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Image effectSprite;

		public CelebrationPopup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_007c: Expected Obj, but got I
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_00b5: Expected Obj, but got I
			//IL_00ed: Expected Obj, but got I
			//IL_0118: Expected Obj, but got I
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected Obj, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected Obj, but got Unknown
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected Obj, but got Unknown
			//IL_0180: Expected I, but got Obj
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected Obj, but got Unknown
			//IL_01b8: Expected native int or pointer, but got VT
			//IL_01ea: Expected native int or pointer, but got VT
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected VT, but got Unknown
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Expected Obj, but got Unknown
			//IL_0288: Expected I, but got Obj
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected Obj, but got Unknown
			//IL_02d0: Expected Obj, but got I
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Expected Obj, but got Unknown
			//IL_0316: Expected Obj, but got I
			//IL_034e: Expected Obj, but got I
			//IL_0379: Expected Obj, but got I
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Expected Obj, but got Unknown
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Expected VT, but got Unknown
			//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d2: Expected VT, but got Unknown
			object obj = default;
			Color color = (Color)(obj - 176);
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					object obj2 = color + 144;
					Image image = effectSprite;
					nint num = (nint)image;
					object obj3 = image + 176;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S2_v21 (Il2CppClass<UnityEngine.UI.Image>)+16C] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4 (CelebrationPopup)+2B4]");
					object obj4 = (nint)0 >> 16;
					object obj5 = obj4 & 0xFF;
					float num2 = (float)obj5 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4 (CelebrationPopup)+2B4]");
					object obj6 = (nint)0 >> 24;
					float num3 = (float)obj6 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4 (CelebrationPopup)+2B4]");
					object obj7 = (nint)0 & (nint)0xFF;
					float num4 = (float)obj7 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4 (CelebrationPopup)+2B4]");
					object obj8 = (nint)0 >> 8;
					object obj9 = obj8 & 0xFF;
					float num5 = (float)obj9 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+50]");
					_ = 0;
					Color color2 = color - -64;
					Color color3 = color + 48;
					IEnumerator routine = celebrationPopup.AnimateEffectColor(image, color2, color3, 10f);
					Coroutine coroutine = celebrationPopup.StartCoroutine(routine);
				}
			}
			else
			{
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4 (CelebrationPopup)+2B4]");
				object obj10 = (nint)0 >> 16;
				object obj11 = obj10 & 0xFF;
				float num6 = (float)obj11 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4 (CelebrationPopup)+2B4]");
				object obj12 = (nint)0 >> 24;
				float num7 = (float)obj12 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4 (CelebrationPopup)+2B4]");
				object obj13 = (nint)0 & (nint)0xFF;
				float num8 = (float)obj13 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4 (CelebrationPopup)+2B4]");
				object obj14 = (nint)0 >> 8;
				object obj15 = obj14 & 0xFF;
				float num9 = (float)obj15 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
				_ = 0;
				object obj16 = color + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				object obj17 = color + 144;
				Image image2 = effectSprite;
				nint num10 = (nint)image2;
				object obj18 = image2 + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ S2_v15 (Il2CppClass<UnityEngine.UI.Image>)+16C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
				_ = 0;
				_ = 4575657222473777152L;
				((Color*)(nint)color)->b = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
				_ = 0;
				_ = 4575657222473777152L;
				((Color*)(nint)color)->r = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
				_ = 0;
				Color color4 = color + 16;
				IEnumerator routine2 = celebrationPopup.AnimateEffectColor(image2, color4, color, 10f, instant: true);
				Coroutine coroutine2 = celebrationPopup.StartCoroutine(routine2);
				_003C_003E2__current = coroutine2;
				_003C_003E1__state = 1;
			}
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

	private sealed class _003C_ShowReward_003Ed__157(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public int currentRewardIndex;

		private CelebrationReward _003Creward_003E5__2;

		private GameObject _003CrewardGo_003E5__3;

		private GameObject _003ClabelGo_003E5__4;

		private Animation _003Canimation_003E5__5;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_015f: Expected Obj, but got I
			//IL_0171: Expected Obj, but got I
			//IL_018e: Expected Obj, but got I4
			//IL_0555: Expected Obj, but got I
			//IL_056b: Expected Obj, but got I
			//IL_2864: Expected Obj, but got I4
			//IL_0582: Expected Obj, but got I
			//IL_05d9: Expected Obj, but got I4
			//IL_05b0: Expected Obj, but got I
			//IL_038a: Expected Obj, but got I
			//IL_0672: Expected Obj, but got I
			//IL_19b5: Expected Obj, but got I4
			//IL_1a0a: Expected Obj, but got I
			//IL_03cb: Expected Obj, but got I
			//IL_1c31: Expected Obj, but got I
			//IL_06a0: Expected Obj, but got I
			//IL_06d0: Expected Obj, but got I
			//IL_1a51: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a56: Expected VT, but got Unknown
			//IL_12b7: Expected Obj, but got I4
			//IL_1a94: Expected Obj, but got I
			//IL_1ab9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1abe: Expected VT, but got Unknown
			//IL_0414: Expected Obj, but got I
			//IL_1c7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c81: Expected Obj, but got Unknown
			//IL_1c8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c8f: Expected Obj, but got Unknown
			//IL_1ca2: Expected Obj, but got I4
			//IL_06fe: Expected Obj, but got I
			//IL_132d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1332: Expected VT, but got Unknown
			//IL_2372: Expected Obj, but got I
			//IL_045b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0460: Expected VT, but got Unknown
			//IL_03fe: Expected Obj, but got I
			//IL_2937: Unknown result type (might be due to invalid IL or missing references)
			//IL_293c: Expected VT, but got Unknown
			//IL_2966: Expected Obj, but got I4
			//IL_073c: Expected Obj, but got I
			//IL_0790: Expected Obj, but got I
			//IL_1b01: Expected Obj, but got I
			//IL_049e: Expected Obj, but got I
			//IL_04b1: Expected native int or pointer, but got VT
			//IL_04c5: Expected native int or pointer, but got VT
			//IL_1d71: Expected Obj, but got I
			//IL_07aa: Expected Obj, but got I
			//IL_1396: Unknown result type (might be due to invalid IL or missing references)
			//IL_139b: Expected VT, but got Unknown
			//IL_126d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1272: Expected VT, but got Unknown
			//IL_1b48: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b4d: Expected VT, but got Unknown
			//IL_22a2: Expected Obj, but got I
			//IL_076a: Expected Obj, but got I
			//IL_14ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f2: Expected VT, but got Unknown
			//IL_1111: Unknown result type (might be due to invalid IL or missing references)
			//IL_1116: Expected VT, but got Unknown
			//IL_1b8b: Expected Obj, but got I
			//IL_1bb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bb5: Expected VT, but got Unknown
			//IL_2497: Expected Obj, but got I4
			//IL_24a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_24a5: Expected Obj, but got Unknown
			//IL_2a69: Expected Obj, but got I
			//IL_2a69: Expected Obj, but got I
			//IL_1d37: Expected Obj, but got I
			//IL_0943: Expected Obj, but got I4
			//IL_1551: Unknown result type (might be due to invalid IL or missing references)
			//IL_1556: Expected VT, but got Unknown
			//IL_142f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1434: Expected VT, but got Unknown
			//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_15bf: Expected VT, but got Unknown
			//IL_2430: Expected Obj, but got I
			//IL_29b3: Expected Obj, but got I4
			//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09be: Expected VT, but got Unknown
			//IL_081b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0820: Expected VT, but got Unknown
			//IL_1493: Unknown result type (might be due to invalid IL or missing references)
			//IL_1498: Expected VT, but got Unknown
			//IL_2aa6: Expected Obj, but got I4
			//IL_2aaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ab4: Expected Obj, but got Unknown
			//IL_230e: Expected Obj, but got I
			//IL_0a02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a07: Expected VT, but got Unknown
			//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c0: Expected VT, but got Unknown
			//IL_1642: Expected Obj, but got I
			//IL_1653: Expected Obj, but got I
			//IL_167a: Unknown result type (might be due to invalid IL or missing references)
			//IL_167f: Expected VT, but got Unknown
			//IL_2524: Expected Obj, but got I
			//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa7: Expected VT, but got Unknown
			//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b44: Expected VT, but got Unknown
			//IL_090f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0914: Expected VT, but got Unknown
			//IL_16ef: Expected Obj, but got I4
			//IL_2ad2: Expected Obj, but got I
			//IL_2b0e: Expected Obj, but got I
			//IL_2563: Unknown result type (might be due to invalid IL or missing references)
			//IL_2568: Expected VT, but got Unknown
			//IL_1d92: Expected Obj, but got I4
			//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afb: Expected VT, but got Unknown
			//IL_0ec6: Expected Obj, but got I
			//IL_176b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1770: Expected VT, but got Unknown
			//IL_2636: Expected VT, but got Obj
			//IL_1e81: Expected Obj, but got I
			//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d03: Expected VT, but got Unknown
			//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d52: Expected VT, but got Unknown
			//IL_0d9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da0: Expected VT, but got Unknown
			//IL_2644: Expected VT, but got Obj
			//IL_2659: Expected F4, but got I
			//IL_2659: Expected Obj, but got VT
			//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c1e: Expected VT, but got Unknown
			//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c6d: Expected VT, but got Unknown
			//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e40: Expected VT, but got Unknown
			//IL_0ef3: Expected Obj, but got I
			//IL_269d: Expected Obj, but got I
			//IL_1eb7: Expected Obj, but got I
			//IL_0e8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e94: Expected VT, but got Unknown
			//IL_18c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_18c8: Expected VT, but got Unknown
			//IL_1213: Unknown result type (might be due to invalid IL or missing references)
			//IL_1218: Expected VT, but got Unknown
			//IL_2688: Expected Obj, but got I4
			//IL_180a: Unknown result type (might be due to invalid IL or missing references)
			//IL_180f: Expected VT, but got Unknown
			//IL_192d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1932: Expected VT, but got Unknown
			//IL_1ed6: Expected Obj, but got I
			//IL_0fe6: Expected Obj, but got I
			//IL_186e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1873: Expected VT, but got Unknown
			//IL_26c5: Expected Obj, but got I4
			//IL_1f03: Expected Obj, but got I
			//IL_0f90: Expected Obj, but got I
			//IL_0f7a: Expected Obj, but got I
			//IL_2787: Expected Obj, but got I
			//IL_2798: Expected Obj, but got I
			//IL_1ff7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ffc: Expected Obj, but got Unknown
			//IL_27ae: Expected Obj, but got I
			//IL_2265: Expected Obj, but got I
			//IL_2076: Unknown result type (might be due to invalid IL or missing references)
			//IL_207b: Expected Obj, but got Unknown
			//IL_1fda: Expected Obj, but got I
			//IL_1f7a: Expected Obj, but got I
			//IL_2222: Expected Obj, but got I
			//IL_2162: Expected Obj, but got I
			object obj = default;
			Vector3 vector = (Vector3)(obj - 912);
			_ = 0;
			_ = 0;
			CelebrationPopup celebrationPopup = _003C_003E4__this;
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
									if (_003C_003E1__state != 6 && _003C_003E1__state != 7)
									{
										if (_003C_003E1__state != 8)
										{
											if (_003C_003E1__state == 9)
											{
												_003C_003E1__state = -1;
												goto IL_29f9;
											}
											bool result = default;
											return result;
										}
										_003C_003E1__state = -1;
										goto IL_2ac2;
									}
									_003C_003E1__state = -1;
								}
								else
								{
									_003C_003E1__state = -1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+80]");
									((GameObject)0).SetActive(value: false);
									PlayerInfo instance = PlayerInfo.Instance;
									int amountOfCoins = instance.amountOfCoins;
									celebrationPopup.PayoutReward(_003Creward_003E5__2);
									CelebrationReward celebrationReward = _003Creward_003E5__2;
									if (celebrationReward.rewardType == CelebrationRewardType.coins)
									{
										CelebrationReward celebrationReward2 = _003Creward_003E5__2;
										bool isMegaJackpot = celebrationReward.amount > MysteryBox.superMysteryBoxJackpotAmount;
										int amount = celebrationReward2.amount;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
										IEnumerator routine = celebrationPopup.CountUpCoins(amountOfCoins, amount, (CelebrationPopupLabelTemplate)0, isMegaJackpot);
										Coroutine coroutine = celebrationPopup.StartCoroutine(routine);
										_003C_003E2__current = coroutine;
										_003C_003E1__state = 6;
										return true;
									}
									bool flag = celebrationReward.CelebrationRewardOrigin <= CelebrationRewardOrigin.TopRun;
									object obj2 = 1 << (int)celebrationReward.CelebrationRewardOrigin;
									object obj3 = obj2 & 0xD80;
									if (obj3 == null)
									{
										flag = false;
									}
									if (!flag)
									{
										_ = 1f;
										object obj4 = default;
										_003C_003E2__current = obj4;
										_003C_003E1__state = 7;
										return true;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2F8]");
								nint num = 0;
								CelebrationReward rewardToDouble = _003Creward_003E5__2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+31C]");
								if (((MysteryBoxDoubleUpButton)num).TryEnable(rewardToDouble, (Dictionary<CelebrationRewardType, Action>)0))
								{
									_ = _003Creward_003E5__2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
									_ = 0;
								}
								CelebrationReward celebrationReward3 = _003Creward_003E5__2;
								object obj5 = celebrationReward3.CelebrationRewardOrigin & (CelebrationRewardOrigin)(-2);
								bool flag2 = (nint)obj5 != 10;
								bool flag3 = !flag2;
								CelebrationRewardOrigin celebrationRewardOrigin = celebrationReward3.CelebrationRewardOrigin;
								if (!flag3)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2B0]");
									MeshRenderer component = ((GameObject)0).GetComponent<MeshRenderer>();
									Material material = component.material;
									_ = 4575657221408423936L;
									_ = 4575657221408423936L;
									_ = 0;
									_ = 0;
									Color toColor = (Color)(vector + 608);
									IEnumerator routine2 = AnimateColor(material, 0.5f, toColor);
									Coroutine coroutine2 = celebrationPopup.StartCoroutine(routine2);
									CelebrationReward celebrationReward4 = _003Creward_003E5__2;
									celebrationRewardOrigin = celebrationReward4.CelebrationRewardOrigin;
								}
								bool flag4 = celebrationRewardOrigin <= CelebrationRewardOrigin.TopRun;
								object obj6 = 1 << (int)celebrationRewardOrigin;
								object obj7 = obj6 & 0xD80;
								if (obj7 == null)
								{
									flag4 = false;
								}
								if (!flag4)
								{
									IEnumerator routine3 = CoroutineUtil.WaitForRealSeconds(0.75f);
									Coroutine coroutine3 = celebrationPopup.StartCoroutine(routine3);
									_003C_003E2__current = coroutine3;
									_003C_003E1__state = 8;
									return true;
								}
								goto IL_2ac2;
							}
							_003C_003E1__state = -1;
							goto IL_2881;
						}
						_003C_003E1__state = -1;
						CelebrationReward celebrationReward5 = _003Creward_003E5__2;
						object obj8 = celebrationReward5.CelebrationRewardOrigin - 10;
						if (celebrationReward5.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
						{
							if ((nint)obj8 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2B0]");
								MeshRenderer component2 = ((GameObject)0).GetComponent<MeshRenderer>();
								Material material2 = component2.material;
								_ = 4575657222473777152L;
								_ = 4575657222473777152L;
								_ = 4575657222473777152L;
								_ = 4575657222473777152L;
								Color toColor2 = (Color)(vector + 560);
								IEnumerator routine4 = AnimateColor(material2, 1.5f, toColor2);
								Coroutine coroutine4 = celebrationPopup.StartCoroutine(routine4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2B0]");
								Transform transform = ((GameObject)0).transform;
								_ = -1014562816;
								_ = -1014562816;
								_ = 0;
								_ = 0;
								Vector3 angleToRotate = vector + 544;
								IEnumerator routine5 = RotateGameObject(transform, 3f, angleToRotate);
								Coroutine coroutine5 = celebrationPopup.StartCoroutine(routine5);
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2B0]");
							MeshRenderer component3 = ((GameObject)0).GetComponent<MeshRenderer>();
							Material material3 = component3.material;
							_ = 4575657222473777152L;
							_ = 4575657222473777152L;
							_ = 4575657222473777152L;
							_ = 4575657222473777152L;
							Color toColor3 = (Color)(vector + 592);
							IEnumerator routine6 = AnimateColor(material3, 1.5f, toColor3);
							Coroutine coroutine6 = celebrationPopup.StartCoroutine(routine6);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2B0]");
							Transform transform2 = ((GameObject)0).transform;
							_ = -930884096;
							_ = -930884096;
							_ = 0;
							_ = 0;
							Vector3 angleToRotate2 = vector + 576;
							IEnumerator routine7 = RotateGameObject(transform2, 3000f, angleToRotate2);
							Coroutine coroutine7 = celebrationPopup.StartCoroutine(routine7);
						}
						_ = 1.3f;
						object obj9 = default;
						_003C_003E2__current = obj9;
						_003C_003E1__state = 4;
						return true;
					}
					_003C_003E1__state = -1;
					goto IL_28de;
				}
				_003C_003E1__state = -1;
				int num2 = currentRewardIndex << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+148]");
				object obj10 = (nint)0 + (nint)num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v655+10]");
				((GameObject)0).SetActive(value: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2CC]");
				if ((UnityEngine.Object)0 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2CC]");
					((SuperMysteryBoxEffect)0).StartEffect();
				}
				goto IL_05b5;
			}
			_003C_003E1__state = -1;
			int num3 = currentRewardIndex << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2C4]");
			object obj11 = (nint)0 + (nint)num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v426+10]");
			_003Creward_003E5__2 = (CelebrationReward)0;
			CelebrationReward celebrationReward6 = _003Creward_003E5__2;
			object obj12 = celebrationReward6.CelebrationRewardOrigin - 1;
			if (celebrationReward6.CelebrationRewardOrigin == CelebrationRewardOrigin.MysteryBox)
			{
				goto IL_0233;
			}
			bool flag5 = (nint)obj12 == 1;
			CelebrationRewardOrigin celebrationRewardOrigin2 = celebrationReward6.CelebrationRewardOrigin;
			if (!flag5)
			{
				bool flag6 = (nint)obj12 == 2;
				celebrationRewardOrigin2 = celebrationReward6.CelebrationRewardOrigin;
				if (!flag6)
				{
					if ((nint)obj12 == 3)
					{
						goto IL_0233;
					}
					celebrationRewardOrigin2 = celebrationReward6.CelebrationRewardOrigin;
				}
			}
			goto IL_2856;
			IL_28a1:
			_ = 1;
			CelebrationReward celebrationReward7 = _003Creward_003E5__2;
			if (celebrationReward7.rewardType == CelebrationRewardType.coins)
			{
				bool flag7 = celebrationPopup.isJackpot(celebrationReward7);
				Transform transform3 = _003CrewardGo_003E5__3.transform;
				if (flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+23C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+234]");
					_ = 0;
					Vector3 toScale = vector + 144;
					IEnumerator routine8 = ScaleGameObject(transform3, 2f, toScale);
					Coroutine coroutine8 = celebrationPopup.StartCoroutine(routine8);
					nint num4 = 0;
					nint num5 = 0;
					IntPtr intPtr = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1056 @ S3_v25 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
					UnityEngine.Object obj13 = default;
					if (obj13 != null)
					{
						AnimationState animationState = ((Animation)obj13).get_Item("open_superJackpot");
						if ((bool)animationState)
						{
							bool flag8 = ((Animation)obj13).Play("open_superJackpot");
							Transform transform4 = _003CrewardGo_003E5__3.transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+50]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+48]");
							_ = 0;
							Vector3 toPos = vector + 128;
							IEnumerator routine9 = MoveGameObject(transform4, 1f, toPos);
							Coroutine coroutine9 = celebrationPopup.StartCoroutine(routine9);
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+230]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+228]");
					_ = 0;
					Vector3 toScale2 = vector + 160;
					IEnumerator routine10 = ScaleGameObject(transform3, 2f, toScale2);
					Coroutine coroutine10 = celebrationPopup.StartCoroutine(routine10);
				}
			}
			else
			{
				object obj14 = celebrationReward7.CelebrationRewardOrigin - 10;
				if (celebrationReward7.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
				{
					if ((nint)obj14 == 1)
					{
						Transform transform5 = _003CrewardGo_003E5__3.transform;
						if (celebrationReward7.rank >= 5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+260]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+258]");
							_ = 0;
							Vector3 toScale3 = vector + 272;
							IEnumerator routine11 = ScaleGameObject(transform5, 0.3f, toScale3);
							Coroutine coroutine11 = celebrationPopup.StartCoroutine(routine11);
							Transform transform6 = _003CrewardGo_003E5__3.transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+278]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+270]");
							_ = 0;
							Vector3 toPos2 = vector + 256;
							IEnumerator routine12 = MoveGameObject(transform6, 0.5f, toPos2);
							Coroutine coroutine12 = celebrationPopup.StartCoroutine(routine12);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+260]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+258]");
							_ = 0;
							Vector3 toScale4 = vector + 240;
							IEnumerator routine13 = ScaleGameObject(transform5, 1.5f, toScale4);
							Coroutine coroutine13 = celebrationPopup.StartCoroutine(routine13);
							Transform transform7 = _003CrewardGo_003E5__3.transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+284]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+27C]");
							_ = 0;
							Vector3 toPos3 = vector + 224;
							IEnumerator routine14 = MoveGameObject(transform7, 1.5f, toPos3);
							Coroutine coroutine14 = celebrationPopup.StartCoroutine(routine14);
						}
					}
					else
					{
						Transform transform8 = _003CrewardGo_003E5__3.transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+248]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+240]");
						_ = 0;
						Vector3 toScale5 = vector + 176;
						IEnumerator routine15 = ScaleGameObject(transform8, 2f, toScale5);
						Coroutine coroutine15 = celebrationPopup.StartCoroutine(routine15);
					}
				}
				else
				{
					Transform transform9 = _003CrewardGo_003E5__3.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+254]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+24C]");
					_ = 0;
					Vector3 toScale6 = vector + 208;
					IEnumerator routine16 = ScaleGameObject(transform9, 2f, toScale6);
					Coroutine coroutine16 = celebrationPopup.StartCoroutine(routine16);
					Transform transform10 = _003CrewardGo_003E5__3.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+26C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+264]");
					_ = 0;
					Vector3 toPos4 = vector + 192;
					IEnumerator routine17 = MoveGameObject(transform10, 2f, toPos4);
					Coroutine coroutine17 = celebrationPopup.StartCoroutine(routine17);
				}
			}
			if (celebrationPopup.IsTwoStepsCelebration(currentRewardIndex))
			{
				int num6 = currentRewardIndex << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+148]");
				object obj15 = (nint)0 + (nint)num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1275 @ S0_v89+10]");
				Transform transform11 = ((GameObject)0).transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+3C]");
				_ = 0;
				Vector3 toPos5 = vector + 112;
				IEnumerator routine18 = MoveGameObject(transform11, 0.7f, toPos5);
				Coroutine coroutine18 = celebrationPopup.StartCoroutine(routine18);
			}
			if (!celebrationPopup.isJackpot(_003Creward_003E5__2))
			{
				CelebrationReward celebrationReward8 = _003Creward_003E5__2;
				object obj16 = celebrationReward8.CelebrationRewardOrigin - 10;
				if (celebrationReward8.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
				{
					if ((nint)obj16 == 1)
					{
						Transform transform12 = _003CrewardGo_003E5__3.transform;
						if (celebrationReward8.rank <= 4)
						{
							_ = 0;
							_ = 0;
							_ = 4950581890387017728L;
							_ = 4950581890387017728L;
							Vector3 angleToRotate3 = vector + 96;
							IEnumerator routine19 = RotateGameObject(transform12, 2f, angleToRotate3);
							Coroutine coroutine19 = celebrationPopup.StartCoroutine(routine19);
							Transform transform13 = _003CrewardGo_003E5__3.transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+284]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+27C]");
							_ = 0;
							Vector3 baseLocalPos = vector + 80;
							IEnumerator routine20 = StartIdleAnimationFor(transform13, baseLocalPos);
							Coroutine coroutine20 = celebrationPopup.StartCoroutine(routine20);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+278]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+270]");
							_ = 0;
							Vector3 baseLocalPos2 = vector - -64;
							IEnumerator routine21 = StartIdleAnimationFor(transform12, baseLocalPos2);
							Coroutine coroutine21 = celebrationPopup.StartCoroutine(routine21);
						}
					}
					else
					{
						Transform transform14 = _003CrewardGo_003E5__3.transform;
						_ = 0;
						_ = 0;
						_ = 4952692952712347648L;
						_ = 4952692952712347648L;
						Vector3 angleToRotate4 = vector + 32;
						IEnumerator routine22 = RotateGameObject(transform14, 4f, angleToRotate4);
						Coroutine coroutine22 = celebrationPopup.StartCoroutine(routine22);
					}
				}
				else
				{
					Transform transform15 = _003CrewardGo_003E5__3.transform;
					_ = 0;
					_ = 0;
					_ = 4950581890387017728L;
					_ = 4950581890387017728L;
					Vector3 angleToRotate5 = vector + 48;
					IEnumerator routine23 = RotateGameObject(transform15, 2f, angleToRotate5);
					Coroutine coroutine23 = celebrationPopup.StartCoroutine(routine23);
				}
			}
			_ = 0.5f;
			object obj17 = default;
			_003C_003E2__current = obj17;
			_003C_003E1__state = 3;
			return true;
			IL_1d45:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
			CelebrationReward celebrationReward9;
			((CelebrationPopupLabelTemplate)0).SetupTopRun(celebrationReward9.score, celebrationReward9.rank, celebrationReward9.weekNumber);
			bool active = false;
			goto IL_2291;
			IL_2881:
			UIScreenController instance2 = UIScreenController.Instance;
			GameObject gameObject = instance2.CameraOverlay2d.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
			bool undo = (UnityEngine.Object)0;
			GameObject gameObject2 = NGUITools.AddChild(gameObject, undo);
			_003ClabelGo_003E5__4 = gameObject2;
			CelebrationReward celebrationReward10 = _003Creward_003E5__2;
			Transform transform16 = _003ClabelGo_003E5__4.transform;
			object obj18 = celebrationPopup + 660;
			object obj19 = celebrationPopup + 648;
			object obj20 = celebrationReward10.CelebrationRewardOrigin - 7;
			if ((nint)obj20 >= 2)
			{
				obj18 = obj19;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ S1_v157+8]");
			_ = 0;
			Vector3 localPosition = vector + 528;
			transform16.localPosition = localPosition;
			celebrationReward9 = _003Creward_003E5__2;
			object obj21 = celebrationReward9.CelebrationRewardOrigin - 9;
			if (celebrationReward9.CelebrationRewardOrigin == CelebrationRewardOrigin.NewHighScore)
			{
				goto IL_1d45;
			}
			if ((nint)obj21 != 1)
			{
				if ((nint)obj21 == 2)
				{
					goto IL_1d45;
				}
				object obj22 = celebrationReward9.rewardType - 1;
				if (celebrationReward9.rewardType != CelebrationRewardType.coins)
				{
					if ((nint)obj22 != 1)
					{
						if ((nint)obj22 != 2)
						{
							if ((nint)obj22 != 3)
							{
								if ((nint)obj22 != 4)
								{
									if ((nint)obj22 != 5)
									{
										if ((nint)obj22 != 6)
										{
											active = false;
										}
										else
										{
											_003ClabelGo_003E5__4.SetActive(value: false);
											active = false;
										}
									}
									else
									{
										CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(celebrationReward9.characterType, celebrationReward9.characterOutfitIndex);
										if (themeForCharacter != null)
										{
											string charName = Strings.Get(themeForCharacter.title);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
											((CelebrationPopupLabelTemplate)0).SetupCharacter(charName);
											active = false;
										}
										else
										{
											CelebrationReward celebrationReward11 = _003Creward_003E5__2;
											Characters.Model model = Characters.characterData.get_Item(celebrationReward11.characterType);
											string charName2 = Strings.Get(model.name);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
											((CelebrationPopupLabelTemplate)0).SetupCharacter(charName2);
											active = false;
										}
									}
								}
								else
								{
									_ = 0;
									object obj23 = vector + 864;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
									SSEventsManagerController instance3 = SSEventsManagerController.instance;
									IEventManager activeEventManager = instance3.GetActiveEventManager();
									if (activeEventManager != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
										object obj24 = default;
										if ((nint)obj24 == 1)
										{
											object obj25 = vector + 879;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
											_ = 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+36F]");
											if ((nint)0 != 0)
											{
												CelebrationReward celebrationReward12 = _003Creward_003E5__2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+364]");
												if ((nint)0 == (nint)celebrationReward12.boardType)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+360]");
													if ((nint)0 != 0)
													{
														CelebrationReward celebrationReward13 = _003Creward_003E5__2;
														Hoverboards.Board board = Hoverboards.boardData.get_Item(celebrationReward13.boardType);
														string boardName = Strings.Get(board.name);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
														((CelebrationPopupLabelTemplate)0).SetupEventSpecialBoard(boardName);
														active = false;
														goto IL_2291;
													}
												}
											}
										}
									}
									CelebrationReward celebrationReward14 = _003Creward_003E5__2;
									if (celebrationReward14.boardPower == Hoverboard.BoardAbility.None)
									{
										CelebrationReward celebrationReward15 = _003Creward_003E5__2;
										Hoverboards.Board board2 = Hoverboards.boardData.get_Item(celebrationReward15.boardType);
										string text = Strings.Get(board2.name);
										string text2 = Strings.Get(StringID.WEEKLYHUNT_PRIZE_CELEBRATIONSCREEN_BOARD);
										string boardName2 = text + " " + text2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
										((CelebrationPopupLabelTemplate)0).SetupSpecialBoard(boardName2);
										active = false;
									}
									else
									{
										string boardPowerName = HoverboardThemes.GetBoardPowerName(celebrationReward14.boardType, celebrationReward14.boardPower);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
										((CelebrationPopupLabelTemplate)0).SetupSpecialBoard(boardPowerName);
										active = false;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
								((CelebrationPopupLabelTemplate)0).SetupKeys(celebrationReward9.amount);
								active = false;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
							((CelebrationPopupLabelTemplate)0).SetupMedal();
							active = true;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
						((CelebrationPopupLabelTemplate)0).SetupPowerup(celebrationReward9.powerupType, celebrationReward9.amount);
						active = false;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
					((CelebrationPopupLabelTemplate)0).SetupCoins();
					active = false;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
				((CelebrationPopupLabelTemplate)0).SetupAward(celebrationReward9.awardTitle, celebrationReward9.amount, celebrationReward9.awardTierType);
				active = false;
			}
			goto IL_2291;
			IL_10a4:
			_003Canimation_003E5__5 = null;
			goto IL_28a1;
			IL_0233:
			PlayerInfo instance4 = PlayerInfo.Instance;
			Statistics stats = instance4._stats;
			int[] values = stats._values;
			int value = values[29] + 1;
			stats.set_Item(Stat.MysteryBoxesOpened, value);
			CelebrationReward celebrationReward16 = _003Creward_003E5__2;
			celebrationRewardOrigin2 = celebrationReward16.CelebrationRewardOrigin;
			goto IL_2856;
			IL_05b5:
			_003CrewardGo_003E5__3 = null;
			CelebrationReward celebrationReward17 = _003Creward_003E5__2;
			object obj26 = celebrationReward17.CelebrationRewardOrigin - 7;
			if (celebrationReward17.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterUnlock)
			{
				if ((nint)obj26 != 1)
				{
					if ((nint)obj26 != 2)
					{
						GameObject prefab = celebrationPopup.ChooseRewardPrefab(celebrationReward17);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+9C]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S0_v397+10]");
						GameObject gameObject3 = NGUITools.AddChild((GameObject)0, prefab);
						_003CrewardGo_003E5__3 = gameObject3;
						if (celebrationPopup.isJackpot(_003Creward_003E5__2))
						{
							Transform transform17 = _003CrewardGo_003E5__3.transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+224]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+21C]");
							_ = 0;
							Vector3 localScale = vector + 320;
							transform17.localScale = localScale;
							Transform transform18 = _003CrewardGo_003E5__3.transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1E0]");
							float num7 = 0f * ((float)Math.PI / 180f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1E4]");
							float num8 = 0f * ((float)Math.PI / 180f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1E8]");
							float num9 = 0f * ((float)Math.PI / 180f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+378]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+370]");
							_ = 0;
							Vector3 euler = vector + 304;
							Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
							_ = 0;
							Quaternion localRotation = (Quaternion)(vector + 288);
							transform18.localRotation = localRotation;
						}
						else
						{
							CelebrationReward celebrationReward18 = _003Creward_003E5__2;
							object obj28 = celebrationReward18.CelebrationRewardOrigin - 10;
							if (celebrationReward18.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
							{
								if ((nint)obj28 == 1)
								{
									Transform transform19 = _003CrewardGo_003E5__3.transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1D0]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1C8]");
									_ = 0;
									Vector3 localScale2 = vector + 512;
									transform19.localScale = localScale2;
									CelebrationReward celebrationReward19 = _003Creward_003E5__2;
									Transform transform20 = _003CrewardGo_003E5__3.transform;
									if (celebrationReward19.rank >= 5)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1F8]");
										float num10 = 0f * ((float)Math.PI / 180f);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1FC]");
										float num11 = 0f * ((float)Math.PI / 180f);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+200]");
										float num12 = 0f * ((float)Math.PI / 180f);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+378]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+370]");
										_ = 0;
										Vector3 euler2 = vector + 496;
										Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler2);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
										_ = 0;
										Quaternion localRotation2 = (Quaternion)(vector + 480);
										transform20.localRotation = localRotation2;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+204]");
										float num13 = 0f * ((float)Math.PI / 180f);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+208]");
										float num14 = 0f * ((float)Math.PI / 180f);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+20C]");
										float num15 = 0f * ((float)Math.PI / 180f);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+378]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+370]");
										_ = 0;
										Vector3 euler3 = vector + 464;
										Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(euler3);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
										_ = 0;
										Quaternion localRotation3 = (Quaternion)(vector + 448);
										transform20.localRotation = localRotation3;
									}
								}
								else
								{
									Transform transform21 = _003CrewardGo_003E5__3.transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1D0]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1C8]");
									_ = 0;
									Vector3 localScale3 = vector + 368;
									transform21.localScale = localScale3;
									Transform transform22 = _003CrewardGo_003E5__3.transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1BC]");
									float num16 = 0f * ((float)Math.PI / 180f);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1C0]");
									float num17 = 0f * ((float)Math.PI / 180f);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1C4]");
									float num18 = 0f * ((float)Math.PI / 180f);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+378]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+370]");
									_ = 0;
									Vector3 euler4 = vector + 352;
									Quaternion quaternion4 = Quaternion.Internal_FromEulerRad(euler4);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
									_ = 0;
									Quaternion localRotation4 = (Quaternion)(vector + 336);
									transform22.localRotation = localRotation4;
								}
							}
							else
							{
								Transform transform23 = _003CrewardGo_003E5__3.transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1DC]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1D4]");
								_ = 0;
								Vector3 localScale4 = vector + 432;
								transform23.localScale = localScale4;
								Transform transform24 = _003CrewardGo_003E5__3.transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+218]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+210]");
								_ = 0;
								Vector3 localPosition2 = vector + 416;
								transform24.localPosition = localPosition2;
								Transform transform25 = _003CrewardGo_003E5__3.transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1EC]");
								float num19 = 0f * ((float)Math.PI / 180f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1F0]");
								float num20 = 0f * ((float)Math.PI / 180f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+1F4]");
								float num21 = 0f * ((float)Math.PI / 180f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+378]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+370]");
								_ = 0;
								Vector3 euler5 = vector + 400;
								Quaternion quaternion5 = Quaternion.Internal_FromEulerRad(euler5);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+388]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+380]");
								_ = 0;
								Quaternion localRotation5 = (Quaternion)(vector + 384);
								transform25.localRotation = localRotation5;
							}
						}
						Transform transform26 = _003CrewardGo_003E5__3.transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+34]");
						int layer = ((GameObject)0).layer;
						Utility.SetLayerRecursively(transform26, layer);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
						if ((UnityEngine.Object)0 != null)
						{
							CelebrationReward celebrationReward20 = _003Creward_003E5__2;
							if (celebrationReward20.CelebrationRewardOrigin != CelebrationRewardOrigin.TopRun)
							{
								if (celebrationReward20.CelebrationRewardOrigin == CelebrationRewardOrigin.WeeklyChallengeNormal)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
									((AudioStateLoop)0).PlayUnlockSound();
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
									((AudioStateLoop)0).PlayCelebrationOpenSound();
								}
							}
						}
						if (celebrationPopup.IsTwoStepsCelebration(currentRewardIndex))
						{
							int num22 = currentRewardIndex << 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+148]");
							object obj29 = (nint)0 + (nint)num22;
							nint num23 = 0;
							nint num24 = 0;
							IntPtr intPtr2 = num24;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2067 @ S4_v53 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
							Animation animation = default;
							_003Canimation_003E5__5 = animation;
							if (_003Canimation_003E5__5 != null)
							{
								AnimationState animationState2 = _003Canimation_003E5__5.get_Item("up");
								if ((bool)animationState2)
								{
									bool flag9 = _003Canimation_003E5__5.Play("up");
									goto IL_28de;
								}
							}
							goto IL_10a4;
						}
						goto IL_28a1;
					}
					PlayerInfo instance5 = PlayerInfo.Instance;
					ShowBackgroundWithStripes(instance5._currentHoverboard, UIModelController.ModelScreen.CelebrationHighScore);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
					if ((UnityEngine.Object)0 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
						((AudioStateLoop)0).PlayUnlockSound();
					}
				}
				else
				{
					ShowBackgroundWithStripes(celebrationReward17.boardType, UIModelController.ModelScreen.CelebrationBoardUnlock);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
					if ((UnityEngine.Object)0 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
						((AudioStateLoop)0).PlayUnlockSound();
					}
				}
			}
			else
			{
				GameObject gameObject4 = ShowModel(celebrationReward17.characterType, celebrationReward17.characterOutfitIndex, UIModelController.ModelScreen.CelebrationCharacterUnlock);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
				if ((UnityEngine.Object)0 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
					((AudioStateLoop)0).PlayUnlockSound();
				}
			}
			goto IL_2881;
			IL_2856:
			object obj30 = celebrationRewardOrigin2 - 2;
			if (celebrationRewardOrigin2 == CelebrationRewardOrigin.SuperMysteryBox || ((nint)obj30 != 1 && (nint)obj30 != 2 && ((nint)obj30 == 3 || celebrationRewardOrigin2 == CelebrationRewardOrigin.CharacterEventSuperMysteryBox)))
			{
				PlayerInfo instance6 = PlayerInfo.Instance;
				Statistics stats2 = instance6._stats;
				int[] values2 = stats2._values;
				int value2 = values2[35] + 1;
				stats2.set_Item(Stat.SuperMysteryBoxesOpened, value2);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2B0]");
			((GameObject)0).SetActive(value: true);
			CelebrationReward celebrationReward21 = _003Creward_003E5__2;
			if (celebrationReward21.CelebrationRewardOrigin == CelebrationRewardOrigin.TopRun)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
				if ((UnityEngine.Object)0 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+140]");
					((AudioStateLoop)0).PlayRewardMysterySound();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2B0]");
				MeshRenderer component4 = ((GameObject)0).GetComponent<MeshRenderer>();
				Material material4 = component4.material;
				_ = 4575657222473777152L;
				_ = 4575657222473777152L;
				_ = 4575657222473777152L;
				_ = 4575657222473777152L;
				Color toColor4 = (Color)(vector + 16);
				IEnumerator routine24 = AnimateColor(material4, 1.5f, toColor4);
				Coroutine coroutine24 = celebrationPopup.StartCoroutine(routine24);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2B0]");
				Transform transform27 = ((GameObject)0).transform;
				_ = -930884096;
				((Vector3*)(nint)vector)->z = -270000f;
				_ = 0;
				((Vector3*)(nint)vector)->x = 0f;
				IEnumerator routine25 = RotateGameObject(transform27, 3000f, vector);
				Coroutine coroutine25 = celebrationPopup.StartCoroutine(routine25);
				_ = 0.4f;
				object obj31 = default;
				_003C_003E2__current = obj31;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_05b5;
			IL_29f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+325]");
			object obj32;
			if ((nint)0 != 0)
			{
				_ = 0;
				obj32 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+324]");
				obj32 = 0;
			}
			if (obj32 == null)
			{
				_ = 0;
				CelebrationReward celebrationReward22 = _003Creward_003E5__2;
				object obj33 = celebrationReward22.CelebrationRewardOrigin - 7;
				if (celebrationReward22.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterUnlock)
				{
					if ((nint)obj33 != 1)
					{
						if ((nint)obj33 == 2)
						{
							HideModel();
						}
					}
					else
					{
						HideModel();
					}
				}
				else
				{
					HideModel();
				}
				UnityEngine.Object.Destroy(_003CrewardGo_003E5__3);
				UnityEngine.Object.Destroy(_003ClabelGo_003E5__4);
				int num25 = currentRewardIndex << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+148]");
				object obj34 = (nint)0 + (nint)num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ S0_v788+10]");
				UnityEngine.Object.Destroy((UnityEngine.Object)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+2F4]");
				GameObject gameObject5 = ((Component)0).gameObject;
				gameObject5.SetActive(value: false);
				celebrationPopup._FinishOpening();
				return false;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 9;
			return true;
			IL_2ac2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+8C]");
			object obj35 = 0;
			string text3 = Strings.Get(StringID.CELEBRATION_POPUP_CONTINUE);
			object obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v792 @ S2_v188+2CC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+8C]");
			IEnumerator routine26 = AnimateAlpha((TMP_Text)0, 0.5f, 1f);
			Coroutine coroutine26 = celebrationPopup.StartCoroutine(routine26);
			_ = 0;
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ S1_v515 (T)+C]");
			((TimeScaleManager)val).TimeScale = 0f;
			_ = 1;
			goto IL_29f9;
			IL_2291:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+98]");
			GameObject gameObject6 = ((Component)0).gameObject;
			gameObject6.SetActive(active);
			CelebrationReward celebrationReward23 = _003Creward_003E5__2;
			if (celebrationReward23.rewardType != CelebrationRewardType.highscore)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (CelebrationPopup)+38]");
				IEnumerator routine27 = AnimateAlpha((CelebrationPopupLabelTemplate)0, 0.2f, 1f);
				Coroutine coroutine27 = celebrationPopup.StartCoroutine(routine27);
			}
			_ = 0.5f;
			object obj37 = default;
			_003C_003E2__current = obj37;
			_003C_003E1__state = 5;
			return true;
			IL_28de:
			AnimationState animationState3 = _003Canimation_003E5__5.get_Item("up");
			float normalizedTime = animationState3.normalizedTime;
			if (normalizedTime < 0.5f)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			goto IL_10a4;
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

	private sealed class _003CMoveNextBoxToFront_003Ed__160(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_004b: Expected VT, but got Obj
			//IL_0054: Expected VT, but got Obj
			//IL_006e: Expected F4, but got I
			//IL_006e: Expected Obj, but got VT
			//IL_00a1: Expected Obj, but got I4
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0401: Expected Obj, but got Unknown
			//IL_0416: Expected Obj, but got I
			//IL_0436: Unknown result type (might be due to invalid IL or missing references)
			//IL_043b: Expected Obj, but got Unknown
			//IL_044b: Expected Obj, but got I
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected VT, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected Obj, but got Unknown
			//IL_0165: Expected Obj, but got I
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected Obj, but got Unknown
			//IL_01f7: Expected Obj, but got I
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Expected Obj, but got Unknown
			//IL_0266: Expected Obj, but got I
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Expected Obj, but got Unknown
			//IL_029c: Expected Obj, but got I
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Expected Obj, but got Unknown
			//IL_04d0: Expected F4, but got I
			//IL_04cb: Expected native int or pointer, but got VT
			//IL_04dd: Expected F4, but got Obj
			//IL_04d8: Expected native int or pointer, but got VT
			//IL_0528: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Expected Obj, but got Unknown
			//IL_053e: Expected Obj, but got I
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Expected Obj, but got Unknown
			//IL_032e: Expected Obj, but got I
			//IL_0485: Expected I, but got Obj
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b6: Expected Obj, but got Unknown
			object obj = default;
			Vector3 vector = (Vector3)(obj + -64);
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				bool result = default;
				if (_003C_003E1__state != 1)
				{
					return result;
				}
				_003C_003E1__state = -1;
				celebrationPopup.openButtonCollider.SetActive(value: true);
			}
			else
			{
				_003C_003E1__state = -1;
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10 (T)+C]");
				((TimeScaleManager)val).TimeScale = 0f;
				int num = ++celebrationPopup._currentReward;
				object obj2 = celebrationPopup._numberOfRewards - 1;
				if (num >= (nint)obj2)
				{
					celebrationPopup.anotherReward = false;
				}
				int num2 = celebrationPopup._currentReward << 2;
				object obj3 = celebrationPopup.rewardsToUnlock + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v21+10]");
				celebrationPopup.UpdateGui((CelebrationReward)0);
				int num3 = celebrationPopup._currentReward << 2;
				object obj4 = celebrationPopup.rewardsToUnlock + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v25+10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v26+8]");
				celebrationPopup.TogglePrizeButtons(CelebrationRewardOrigin.Notset);
				MeshRenderer component = celebrationPopup.GlowEffect.GetComponent<MeshRenderer>();
				Material material = component.material;
				_ = 4575657221408423936L;
				_ = 4575657221408423936L;
				_ = 0;
				_ = 0;
				Color value = (Color)(vector + 16);
				material.SetColor("_MainColor", value);
				int num4 = celebrationPopup._currentReward << 2;
				object obj6 = celebrationPopup.rewardsToUnlock + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v39+10]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v40+8]");
				celebrationPopup.ToggleSuperMysteryBoxEffect(CelebrationRewardOrigin.Notset);
				celebrationPopup.openButtonCollider.SetActive(value: false);
				if (celebrationPopup.IsTwoStepsCelebration(celebrationPopup._currentReward))
				{
					int num5 = celebrationPopup._currentReward << 2;
					object obj8 = celebrationPopup._celebrationRewardContainer + num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v47+10]");
					Transform transform = ((GameObject)0).transform;
					GameObject[] slots = celebrationPopup.slots;
					Transform transform2 = slots[0].transform;
					transform.parent = transform2;
					int num6 = celebrationPopup._currentReward << 2;
					object obj9 = celebrationPopup.rewardsToUnlock + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v52+10]");
					object obj10 = 0;
					int num7 = celebrationPopup._currentReward << 2;
					object obj11 = celebrationPopup._celebrationRewardContainer + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v57+10]");
					Transform transform3 = ((GameObject)0).transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v53+8]");
					object obj12;
					if ((nint)0 == 11)
					{
						obj12 = celebrationPopup + 432;
					}
					else
					{
						nint num8 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v84 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v85 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
						_ = 0;
						_ = Vector3.zeroVector;
						obj12 = vector + 32;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S1_v63+8]");
					((Vector3*)(nint)vector)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj12;
					IEnumerator routine = celebrationPopup.MoveGameObject(transform3, 0.35f, vector);
					Coroutine coroutine = celebrationPopup.StartCoroutine(routine);
					int num10 = celebrationPopup._currentReward << 2;
					object obj13 = celebrationPopup._celebrationRewardContainer + num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v71+10]");
					Transform transform4 = ((GameObject)0).transform;
					int num11 = celebrationPopup._currentReward << 2;
					object obj14 = celebrationPopup.rewardsToUnlock + num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S2_v38+10]");
					celebrationPopup.StartIdleAnimCoroutine(transform4, (CelebrationReward)0);
					_ = 0.35f;
					object obj15 = default;
					_003C_003E2__current = obj15;
					_003C_003E1__state = 1;
					return true;
				}
				celebrationPopup.FingerReleased();
			}
			celebrationPopup.skipButtonCollider.SetActive(value: true);
			return false;
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

	private sealed class _003CRotateGameObject_003Ed__161(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public float duration;

		public Vector3 angleToRotate;

		private Quaternion _003CfromRotation_003E5__2;

		private float _003Cfactor2_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00b8: Expected VT, but got I
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected Obj, but got Unknown
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected VT, but got Unknown
			//IL_0211: Expected F4, but got I
			//IL_020c: Expected native int or pointer, but got VT
			//IL_0230: Expected F4, but got I
			//IL_022b: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 80);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003Cfactor2_003E5__3 < 1f)
					{
						goto IL_00fd;
					}
					goto IL_0120;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (trans != null)
				{
					Quaternion localRotation = trans.localRotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_003CfromRotation_003E5__2 = (Quaternion)0;
					_003Cfactor2_003E5__3 = 0f;
					goto IL_00fd;
				}
			}
			bool result = default;
			return result;
			IL_00fd:
			if (!(trans != null))
			{
				goto IL_0120;
			}
			float deltaTime = Time.deltaTime;
			float num = deltaTime / duration;
			float num2 = _003Cfactor2_003E5__3 + num;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			_003Cfactor2_003E5__3 = num4;
			float num5 = Math.Max(num4, 0f);
			float num6 = num5 * 1.5707965f;
			float num7 = num6 + 4.712389f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
			object obj2 = default;
			float num8 = (float)obj2 * 0.5f;
			float num9 = num8 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<RotateGameObject>d__161)+2C]");
			_ = 0;
			_ = _003CfromRotation_003E5__2;
			Quaternion localRotation2 = (Quaternion)(vector + 16);
			trans.localRotation = localRotation2;
			float num10 = (float)angleToRotate * num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<RotateGameObject>d__161)+1C]");
			float num11 = 0f * num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<RotateGameObject>d__161)+20]");
			float num12 = 0f * num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			trans.Rotate(vector, Space.World);
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0120:
			object obj3 = this + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			return false;
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

	private sealed class _003CCountUpCoins_003Ed__162(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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

		private int _003CcoinboxTo_003E5__4;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00c6: Expected Obj, but got I4
			//IL_0330: Expected Obj, but got I4
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_033f: Expected I4, but got Unknown
			//IL_0257: Expected I4, but got F8
			//IL_02b1: Expected F8, but got I4
			//IL_0528: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Expected I4, but got Unknown
			//IL_0542: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - 16;
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1 || _003C_003E1__state == 2)
				{
					_003C_003E1__state = -1;
					if (_003CcountFactor_003E5__2 < 1f)
					{
						float deltaTime = Time.deltaTime;
						float num = deltaTime / _003CcountTime_003E5__3;
						float num2 = (_003CcountFactor_003E5__2 += num);
						float num3 = Math.Min(num2, 1f);
						bool flag = num2 < 0f;
						float num4 = 0f;
						if (!flag)
						{
							num4 = num3;
						}
						float num5 = num4 * -2f;
						float num6 = num5 * num4;
						float num7 = num6 * num4;
						float num8 = num4 * 3f;
						float num9 = num8 * num4;
						float num10 = num7 + num9;
						float num11 = (float)toAmount * num10;
						float num12 = 1f - num10;
						float num13 = (float)fromAmount * num12;
						float num14 = num11 + num13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double num16 = default;
						double num15 = Math.Abs(num16);
						int amount = ((!(num15 < 2147483648.0)) ? int.MinValue : ((int)num16));
						rewardTemplate.UpdateCoins(amount, isMegaJackpot, doubled);
						TMP_Text coinboxLabel = celebrationPopup.coinboxLabel;
						float num17 = Math.Min(_003CcountFactor_003E5__2, 1f);
						bool flag2 = _003CcountFactor_003E5__2 < 0f;
						float num18 = 0f;
						if (!flag2)
						{
							num18 = num17;
						}
						float num19 = num18 * -2f;
						float num20 = num19 * num18;
						float num21 = num20 * num18;
						float num22 = num18 * 3f;
						float num23 = num22 * num18;
						float num24 = num21 + num23;
						float num25 = (float)_003CcoinboxTo_003E5__4 * num24;
						float num26 = 1f - num24;
						float num27 = (float)coinboxAmount * num26;
						float num28 = num25 + num27;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double value = default;
						double num29 = Math.Abs(value);
						if (!(num29 < 2147483648.0))
						{
							value = -2147483648.0;
						}
						int num30 = obj + 12;
						string text = ((int*)num30)->ToString();
						nint num31 = (nint)coinboxLabel;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v286 @ S2_v49 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
						_003C_003E2__current = null;
						_003C_003E1__state = 2;
						return true;
					}
					if (celebrationPopup.coinboxSizer != null)
					{
						celebrationPopup.coinboxSizer.updateAutomatically = true;
					}
				}
				bool result = default;
				return result;
			}
			_003C_003E1__state = -1;
			if (celebrationPopup.coinboxSizer != null)
			{
				celebrationPopup.coinboxSizer.updateAutomatically = false;
			}
			_003CcountFactor_003E5__2 = 0f;
			object obj3 = toAmount - fromAmount;
			float num32 = (float)obj3 / 100000f;
			float num33 = Math.Min(num32, 1f);
			bool flag3 = num32 < 0f;
			float num34 = 0f;
			if (!flag3)
			{
				num34 = num33;
			}
			float num35 = num34 * 2.5f;
			float num36 = num35 + 1.5f;
			float num37 = num36 * countTimeMultiplier;
			_003CcountTime_003E5__3 = num37;
			object obj4 = coinboxAmount + toAmount;
			int num38 = obj4 - fromAmount;
			_003CcoinboxTo_003E5__4 = num38;
			_ = 0.5f;
			object obj5 = default;
			_003C_003E2__current = obj5;
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

	private sealed class _003CAnimateAlpha_003Ed__164(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TMP_Text label;

		public float duration;

		public float toAlpha;

		private float _003CfromAlpha_003E5__2;

		private float _003Cfactor2_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0075: Expected F4, but got I
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					bool flag = _003Cfactor2_003E5__3 < 1f;
					num = _003Cfactor2_003E5__3;
					if (flag)
					{
						goto IL_00bd;
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			TMP_Text tMP_Text = label;
			_003Cfactor2_003E5__3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v12 (TMPro.TMP_Text)+C4]");
			_003CfromAlpha_003E5__2 = 0f;
			num = 0f;
			goto IL_00bd;
			IL_00bd:
			float deltaTime = Time.deltaTime;
			float num2 = deltaTime / duration;
			float num3 = num + num2;
			float num4 = Math.Min(num3, 1f);
			bool flag2 = num3 < 0f;
			float num5 = 0f;
			if (!flag2)
			{
				num5 = num4;
			}
			_003Cfactor2_003E5__3 = num5;
			float num6 = toAlpha - _003CfromAlpha_003E5__2;
			float num7 = Math.Max(num5, 0f);
			float num8 = num6 * num7;
			float alpha = _003CfromAlpha_003E5__2 + num8;
			label.alpha = alpha;
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

	private sealed class _003CAnimateAlpha_003Ed__165(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopupLabelTemplate template;

		public float duration;

		public float toAlpha;

		private float _003CfromAlpha_003E5__2;

		private float _003Cfactor2_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0082: Expected F4, but got I
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					bool flag = _003Cfactor2_003E5__3 < 1f;
					num = _003Cfactor2_003E5__3;
					if (flag)
					{
						goto IL_00ca;
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = template;
			TMP_Text bigLabel = celebrationPopupLabelTemplate.bigLabel;
			_003Cfactor2_003E5__3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v13 (TMPro.TMP_Text)+C4]");
			_003CfromAlpha_003E5__2 = 0f;
			num = 0f;
			goto IL_00ca;
			IL_00ca:
			float deltaTime = Time.deltaTime;
			float num2 = deltaTime / duration;
			float num3 = num + num2;
			float num4 = Math.Min(num3, 1f);
			bool flag2 = num3 < 0f;
			float num5 = 0f;
			if (!flag2)
			{
				num5 = num4;
			}
			_003Cfactor2_003E5__3 = num5;
			float num6 = toAlpha - _003CfromAlpha_003E5__2;
			float num7 = Math.Max(num5, 0f);
			float num8 = num6 * num7;
			float alpha = _003CfromAlpha_003E5__2 + num8;
			template.Alpha = alpha;
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

	private sealed class _003CAnimateColor_003Ed__166(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWidget widget;

		public float duration;

		public Color toColor;

		private Color _003CfromColor_003E5__2;

		private float _003Cfactor2_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_015d: Expected Obj, but got VT
			//IL_01ac: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I
			//IL_0232: Expected Obj, but got I
			//IL_0277: Expected F4, but got I
			//IL_0272: Expected native int or pointer, but got VT
			//IL_0296: Expected F4, but got I
			//IL_0291: Expected native int or pointer, but got VT
			object obj = default;
			Color color = (Color)(obj - 32);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003Cfactor2_003E5__3 < 1f)
					{
						goto IL_00c7;
					}
				}
				goto IL_013c;
			}
			_003C_003E1__state = -1;
			UIWidget uIWidget = widget;
			_003CfromColor_003E5__2 = uIWidget.mColor;
			_003Cfactor2_003E5__3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v34 (UIWidget)+54]");
			_ = 0;
			goto IL_00c7;
			IL_00c7:
			float deltaTime = Time.deltaTime;
			float num = deltaTime / duration;
			float num2 = _003Cfactor2_003E5__3 + num;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			_003Cfactor2_003E5__3 = num4;
			object obj2 = toColor - _003CfromColor_003E5__2;
			float num5 = Math.Max(num4, 0f);
			float num6 = (float)obj2 * num5;
			float num7 = (float)_003CfromColor_003E5__2 + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__166)+1C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__166)+2C]");
			object obj3 = num8 - 0;
			float num9 = (float)obj3 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__166)+2C]");
			float num10 = 0f + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__166)+24]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__166)+34]");
			object obj4 = num11 - 0;
			float num12 = (float)obj4 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__166)+34]");
			float num13 = 0f + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__166)+20]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__166)+30]");
			object obj5 = num14 - 0;
			float num15 = (float)obj5 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__166)+30]");
			float num16 = 0f + num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
			((Color*)(nint)color)->b = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
			((Color*)(nint)color)->r = 0f;
			widget.color = color;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_013c;
			IL_013c:
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

	private sealed class _003CAnimateColor_003Ed__167(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Material material;

		public float duration;

		public Color toColor;

		private Color _003CfromColor_003E5__2;

		private float _003Cfactor2_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_008f: Expected VT, but got I
			//IL_0189: Expected Obj, but got VT
			//IL_01d8: Expected Obj, but got I
			//IL_021b: Expected Obj, but got I
			//IL_025e: Expected Obj, but got I
			//IL_02a3: Expected F4, but got I
			//IL_029e: Expected native int or pointer, but got VT
			//IL_02c2: Expected F4, but got I
			//IL_02bd: Expected native int or pointer, but got VT
			object obj = default;
			Color color = (Color)(obj + -64);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003Cfactor2_003E5__3 < 1f)
					{
						goto IL_00d4;
					}
				}
				goto IL_0168;
			}
			_003C_003E1__state = -1;
			Color color2 = material.GetColor("_MainColor");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
			_003CfromColor_003E5__2 = (Color)0;
			_003Cfactor2_003E5__3 = 0f;
			goto IL_00d4;
			IL_00d4:
			float deltaTime = Time.deltaTime;
			float num = deltaTime / duration;
			float num2 = _003Cfactor2_003E5__3 + num;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			_003Cfactor2_003E5__3 = num4;
			object obj2 = toColor - _003CfromColor_003E5__2;
			float num5 = Math.Max(num4, 0f);
			float num6 = (float)obj2 * num5;
			float num7 = (float)_003CfromColor_003E5__2 + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__167)+1C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__167)+2C]");
			object obj3 = num8 - 0;
			float num9 = (float)obj3 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__167)+2C]");
			float num10 = 0f + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__167)+24]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__167)+34]");
			object obj4 = num11 - 0;
			float num12 = (float)obj4 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__167)+34]");
			float num13 = 0f + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__167)+20]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__167)+30]");
			object obj5 = num14 - 0;
			float num15 = (float)obj5 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateColor>d__167)+30]");
			float num16 = 0f + num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
			((Color*)(nint)color)->b = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
			((Color*)(nint)color)->r = 0f;
			material.SetColor("_MainColor", color);
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_0168;
			IL_0168:
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

	private sealed class _003CAnimateEffectColor_003Ed__168(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public bool instant;

		public Image spriteToAnimate;

		public Color color2;

		public CelebrationPopup _003C_003E4__this;

		public float speedFactor;

		public Color color1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0147: Expected Obj, but got VT
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected Obj, but got Unknown
			//IL_01d4: Expected Obj, but got I
			//IL_0217: Expected Obj, but got I
			//IL_025a: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 48;
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (celebrationPopup._animationLerpFactor < 1f)
					{
						goto IL_00fb;
					}
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (~(instant ? 1u : 0u) != 0)
				{
					celebrationPopup._animationLerpFactor = 0f;
					goto IL_00fb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+20]");
				_ = 0;
				_ = color2;
				object obj3 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			goto IL_0191;
			IL_00fb:
			float deltaTime = Time.deltaTime;
			float num = deltaTime * speedFactor;
			float num2 = (celebrationPopup._animationLerpFactor += num);
			object obj4 = color2 - color1;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			float num5 = (float)obj4 * num4;
			float num6 = (float)color1 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+1C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+34]");
			object obj5 = num7 - 0;
			float num8 = (float)obj5 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+34]");
			float num9 = 0f + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+24]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+3C]");
			object obj6 = num10 - 0;
			float num11 = (float)obj6 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+3C]");
			float num12 = 0f + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+20]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+38]");
			object obj7 = num13 - 0;
			float num14 = (float)obj7 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateEffectColor>d__168)+38]");
			float num15 = 0f + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_0191;
			IL_0191:
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

	private sealed class _003CMoveGameObject_003Ed__169(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public float duration;

		public Vector3 toPos;

		private Vector3 _003CfromPos_003E5__2;

		private float _003Cfactor2_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00b8: Expected VT, but got I
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected Obj, but got Unknown
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected VT, but got Unknown
			//IL_0268: Expected Obj, but got VT
			//IL_0327: Expected Obj, but got I
			//IL_0367: Expected F4, but got I
			//IL_0362: Expected native int or pointer, but got VT
			//IL_0384: Expected Obj, but got I
			//IL_03c9: Expected F4, but got I
			//IL_03c4: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 80);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003Cfactor2_003E5__3 < 1f)
					{
						goto IL_00fd;
					}
					goto IL_0120;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (trans != null)
				{
					Vector3 localPosition = trans.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_003CfromPos_003E5__2 = (Vector3)0;
					_003Cfactor2_003E5__3 = 0f;
					goto IL_00fd;
				}
			}
			bool result = default;
			return result;
			IL_00fd:
			if (!(trans != null))
			{
				goto IL_0120;
			}
			float deltaTime = Time.deltaTime;
			float num = deltaTime / duration;
			float num2 = _003Cfactor2_003E5__3 + num;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			_003Cfactor2_003E5__3 = num4;
			object obj2 = toPos - _003CfromPos_003E5__2;
			float num5 = num4 - 0.5f;
			float num6 = num5 * (float)Math.PI;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
			object obj3 = default;
			float num7 = (float)obj3 + 1f;
			float num8 = num7 * 0.5f;
			float num9 = Math.Min(num8, 1f);
			bool flag2 = num8 < 0f;
			float num10 = 0f;
			if (!flag2)
			{
				num10 = num9;
			}
			float num11 = (float)obj2 * num10;
			float num12 = (float)_003CfromPos_003E5__2 + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<MoveGameObject>d__169)+20]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<MoveGameObject>d__169)+2C]");
			object obj4 = num13 - 0;
			float num14 = (float)obj4 * num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<MoveGameObject>d__169)+2C]");
			float num15 = 0f + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<MoveGameObject>d__169)+1C]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<MoveGameObject>d__169)+28]");
			object obj5 = num16 - 0;
			float num17 = (float)obj5 * num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<MoveGameObject>d__169)+28]");
			float num18 = 0f + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			trans.localPosition = vector;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0120:
			if (trans != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<MoveGameObject>d__169)+20]");
				_ = 0;
				_ = toPos;
				Vector3 localPosition2 = vector + 16;
				trans.localPosition = localPosition2;
			}
			object obj6 = this + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			return false;
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

	private sealed class _003CScaleGameObject_003Ed__170(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public float duration;

		public Vector3 toScale;

		private float _003Cfactor2_003E5__2;

		private Vector3 _003CfromScale_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00c3: Expected VT, but got I
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected Obj, but got Unknown
			//IL_028b: Expected Obj, but got VT
			//IL_02df: Expected Obj, but got I
			//IL_0322: Expected Obj, but got I
			//IL_0362: Expected F4, but got I
			//IL_035d: Expected native int or pointer, but got VT
			//IL_0381: Expected F4, but got I
			//IL_037c: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj + -64);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_01e5;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (!(trans != null))
				{
					goto IL_01e5;
				}
				_003Cfactor2_003E5__2 = 0f;
				Vector3 localScale = trans.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_003CfromScale_003E5__3 = (Vector3)0;
			}
			if (!(_003Cfactor2_003E5__2 < 1f) || !(trans != null))
			{
				object obj2 = this + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				return false;
			}
			float deltaTime = Time.deltaTime;
			float num = deltaTime / duration;
			float num2 = _003Cfactor2_003E5__2 + num;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			_003Cfactor2_003E5__2 = num4;
			float num5 = Math.Max(num4, 0f);
			float num6 = num5 * (float)Math.PI;
			float num7 = num6 + (float)Math.PI;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
			object obj3 = default;
			float num8 = (float)obj3 * 0.5f;
			float num9 = num8 + 0.5f;
			object obj4 = toScale - _003CfromScale_003E5__3;
			float num10 = Math.Min(num9, 1f);
			bool flag2 = num9 < 0f;
			float num11 = 0f;
			if (!flag2)
			{
				num11 = num10;
			}
			float num12 = (float)obj4 * num11;
			float num13 = (float)_003CfromScale_003E5__3 + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<ScaleGameObject>d__170)+1C]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<ScaleGameObject>d__170)+2C]");
			object obj5 = num14 - 0;
			float num15 = (float)obj5 * num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<ScaleGameObject>d__170)+2C]");
			float num16 = 0f + num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<ScaleGameObject>d__170)+20]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<ScaleGameObject>d__170)+30]");
			object obj6 = num17 - 0;
			float num18 = (float)obj6 * num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<ScaleGameObject>d__170)+30]");
			float num19 = 0f + num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			trans.localScale = vector;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_01e5:
			bool result = default;
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

	private sealed class _003CAnimateStripes_003Ed__172(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0070: Expected VT, but got I8
			//IL_007f: Expected VT, but got I8
			//IL_00a4: Expected I4, but got I8
			//IL_08ea: Expected Obj, but got VT
			//IL_0904: Unknown result type (might be due to invalid IL or missing references)
			//IL_0909: Expected Obj, but got Unknown
			//IL_0928: Expected Obj, but got VT
			//IL_0931: Unknown result type (might be due to invalid IL or missing references)
			//IL_0936: Expected Obj, but got Unknown
			//IL_0955: Expected Obj, but got VT
			//IL_095e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0963: Expected Obj, but got Unknown
			//IL_097c: Expected Obj, but got I4
			//IL_0102: Expected Obj, but got I4
			//IL_0120: Expected Obj, but got I
			//IL_0145: Expected Obj, but got I4
			//IL_0168: Expected Obj, but got I
			//IL_0587: Expected Obj, but got I4
			//IL_05a5: Expected Obj, but got I
			//IL_05c9: Expected Obj, but got I4
			//IL_0631: Expected F4, but got I
			//IL_0649: Expected F4, but got I
			//IL_0bca: Expected Obj, but got I4
			//IL_0bed: Expected Obj, but got I
			//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3f: Expected VT, but got Unknown
			//IL_0668: Expected F4, but got VT
			//IL_0668: Expected F4, but got VT
			//IL_067a: Expected Obj, but got I4
			//IL_06b6: Expected Obj, but got I4
			//IL_06f3: Expected Obj, but got I4
			//IL_0715: Expected Obj, but got I
			//IL_0736: Expected Obj, but got I4
			//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c95: Expected Obj, but got Unknown
			//IL_0cad: Expected Obj, but got I4
			//IL_0ccf: Expected Obj, but got I
			//IL_0cef: Expected Obj, but got I4
			//IL_0d12: Expected Obj, but got I
			//IL_0d31: Expected Obj, but got I4
			//IL_0d54: Expected Obj, but got I
			//IL_07f7: Expected Obj, but got I4
			//IL_0d98: Expected Obj, but got I
			//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e54: Expected VT, but got Unknown
			object obj = default;
			Vector3 vector = (Vector3)(obj - 176);
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			bool flag = default;
			int num33;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1 && _003C_003E1__state != 2)
				{
					goto IL_08ab;
				}
				_003C_003E1__state = -1;
				while (true)
				{
					UITexture[] stripeTextures = celebrationPopup._stripeTextures;
					if (stripeTextures.Length <= (flag ? 1 : 0))
					{
						break;
					}
					object obj2 = (flag ? 1u : 0u) << 2;
					object obj3 = (object)stripeTextures + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v133+10]");
					Transform cachedTransform = ((UIRect)0).cachedTransform;
					Vector3 localPosition = cachedTransform.localPosition;
					object obj4 = (flag ? 1u : 0u) << 2;
					object obj5 = (object)_003CstripeSpeeds_003E5__10 + obj4;
					float deltaTime = Time.deltaTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v172+10]");
					float num = 0f * deltaTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateStripes>d__172)+38]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
					bool flag2 = num2 < 0;
					bool flag3 = !flag2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
					float num3 = 0f;
					float num4 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
					float num5 = 0f;
					if (!flag3)
					{
						float num6 = UnityEngine.Random.Range((float)_003CminimumThreshold_003E5__8, (float)_003CmaximumThreshold_003E5__9);
						object obj6 = (flag ? 1u : 0u) << 2;
						object obj7 = (object)_003CstripeSpeeds_003E5__10 + obj6;
						int num7 = UnityEngine.Random.Range(_003CminSpeed_003E5__2, _003CmaxSpeed_003E5__3);
						object obj8 = (flag ? 1u : 0u) << 2;
						object obj9 = (object)_003CstripeSpeeds_003E5__10 + obj8;
						float deltaTime2 = Time.deltaTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v200+10]");
						float num8 = 0f * deltaTime2;
						object obj10 = (flag ? 1u : 0u) << 2;
						object obj11 = (object)celebrationPopup._stripeTextures + obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S0_v205+10]");
						object obj12 = 0;
						float num9 = _003CmaxAlpha_003E5__5 - _003CminAlpha_003E5__4;
						object obj13 = (flag ? 1u : 0u) << 2;
						object obj14 = (object)_003CstripeSpeeds_003E5__10 + obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S4_v21+10]");
						float num10 = 0f / (float)_003CmaxSpeed_003E5__3;
						float num11 = Math.Min(num10, 1f);
						bool flag4 = num10 < 0f;
						float num12 = 0f;
						if (!flag4)
						{
							num12 = num11;
						}
						float num13 = num9 * num12;
						float num14 = _003CminAlpha_003E5__4 + num13;
						object obj15 = obj12 - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v566 @ S2_v89+BC] (should have been resolved before IL gen)");
						object obj16 = (flag ? 1u : 0u) << 2;
						object obj17 = (object)celebrationPopup._stripeTextures + obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S0_v209+10]");
						object obj18 = 0;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v581 @ S1_v175+1E4] (should have been resolved before IL gen)");
						object obj20 = (flag ? 1u : 0u) << 2;
						object obj21 = (object)celebrationPopup._stripeTextures + obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ S1_v180+10]");
						Transform cachedTransform2 = ((UIRect)0).cachedTransform;
						Vector3 localScale = cachedTransform2.localScale;
						object obj22 = (flag ? 1u : 0u) << 2;
						object obj23 = (object)celebrationPopup._stripeTextures + obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v221+10]");
						Transform cachedTransform3 = ((UIRect)0).cachedTransform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
						float num15 = 0f * _003CminScale_003E5__6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
						float num16 = 0f * _003CmaxScale_003E5__7;
						float num17 = num16 - num15;
						object obj24 = (flag ? 1u : 0u) << 2;
						object obj25 = (object)_003CstripeSpeeds_003E5__10 + obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S3_v41+10]");
						float num18 = 0f / (float)_003CmaxSpeed_003E5__3;
						float num19 = Math.Min(num18, 1f);
						bool flag5 = num18 < 0f;
						float num20 = 0f;
						if (!flag5)
						{
							num20 = num19;
						}
						float num21 = num17 * num20;
						float num22 = num15 + num21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
						nint num23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
						object obj26 = num23 - 0;
						float num24 = (float)obj26 * num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
						float num25 = 0f + num24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
						float num26 = 0f * _003CminScale_003E5__6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
						float num27 = 0f * _003CmaxScale_003E5__7;
						float num28 = num27 - num26;
						float num29 = num28 * num20;
						float num30 = num26 + num29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
						_ = 0;
						Vector3 localScale2 = vector - -64;
						cachedTransform3.localScale = localScale2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup+<AnimateStripes>d__172)+30]");
						float num31 = 0f - num8;
						num3 = num6;
						num4 = num8;
						num5 = num31;
					}
					object obj27 = (flag ? 1u : 0u) << 2;
					object obj28 = (object)celebrationPopup._stripeTextures + obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v181+10]");
					Transform cachedTransform4 = ((UIRect)0).cachedTransform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
					_ = 0;
					float num32 = num5 + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
					_ = 0;
					Vector3 localPosition2 = vector + 48;
					cachedTransform4.localPosition = localPosition2;
					bool flag6 = (byte)((flag ? 1u : 0u) + 1u) != 0;
					flag = flag6;
				}
				num33 = 2;
			}
			else
			{
				_003C_003E1__state = -1;
				_003CmaximumThreshold_003E5__9 = (Vector2)4913145719610015744L;
				_003CminimumThreshold_003E5__8 = (Vector2)(-4368210160299671552L);
				_003CminScale_003E5__6 = 0.5f;
				_003CminAlpha_003E5__4 = 0.3f;
				_003CminSpeed_003E5__2 = 600;
				bool flag7 = celebrationPopup._stripeTextures == null;
				UITexture[] stripeTextures2 = celebrationPopup._stripeTextures;
				if (!flag7)
				{
					while ((flag ? 1 : 0) < stripeTextures2.Length)
					{
						object obj29 = (flag ? 1u : 0u) << 2;
						object obj30 = (object)stripeTextures2 + obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v140+10]");
						GameObject gameObject = ((Component)0).gameObject;
						gameObject.SetActive(value: false);
						object obj31 = (flag ? 1u : 0u) << 2;
						object obj32 = (object)celebrationPopup._stripeTextures + obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v145+10]");
						GameObject gameObject2 = ((Component)0).gameObject;
						UnityEngine.Object.Destroy(gameObject2);
						bool flag8 = (byte)((flag ? 1u : 0u) + 1u) != 0;
						flag = flag8;
						stripeTextures2 = celebrationPopup._stripeTextures;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				UITexture[] stripeTextures3 = default;
				celebrationPopup._stripeTextures = stripeTextures3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				float[] array = default;
				_003CstripeSpeeds_003E5__10 = array;
				object obj33 = GlobalColorsGenerated.WEEKLYHUNT_CELEBRATION_STRIPE_COLOR >> 24;
				float num34 = (float)obj33 / 255f;
				object obj34 = GlobalColorsGenerated.WEEKLYHUNT_CELEBRATION_STRIPE_COLOR & 0xFF;
				float num35 = (float)obj34 / 255f;
				object obj35 = GlobalColorsGenerated.WEEKLYHUNT_CELEBRATION_STRIPE_COLOR >> 16;
				object obj36 = obj35 & 0xFF;
				float num36 = (float)obj36 / 255f;
				object obj37 = GlobalColorsGenerated.WEEKLYHUNT_CELEBRATION_STRIPE_COLOR >> 8;
				object obj38 = obj37 & 0xFF;
				float num37 = (float)obj38 / 255f;
				object obj39 = 0;
				bool flag9 = (nint)obj39 >= 12;
				num33 = 1;
				if (!flag9)
				{
					object obj40 = obj39 << 2;
					object obj41 = (object)_003CstripeSpeeds_003E5__10 + obj40;
					int num38 = UnityEngine.Random.Range(_003CminSpeed_003E5__2, _003CmaxSpeed_003E5__3);
					UITexture uITexture = NGUITools.AddWidget<UITexture>(celebrationPopup.stripePanel);
					throw new ArrayTypeMismatchException();
				}
			}
			_003C_003E2__current = null;
			_003C_003E1__state = num33;
			flag = true;
			goto IL_08ab;
			IL_08ab:
			return flag;
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

	private sealed class _003CInitial_Generic_DoubleUp_Routine_003Ed__191(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationPopupLabelTemplate template;

		public CelebrationReward reward;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00c5: Expected I, but got Obj
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected VT, but got Unknown
			//IL_01bd: Expected native int or pointer, but got VT
			//IL_01d1: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj + -64);
			int num;
			bool result;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				result = false;
				if (!flag)
				{
					result = false;
					goto IL_029a;
				}
			}
			else
			{
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				_003C_003E1__state = -1;
				_003C_003E4__this.ResetBackgroundToNormal();
				celebrationPopup.continueButtonCollider.SetActive(value: false);
				celebrationPopup.tapToStartLabel.alpha = 0f;
				TMP_Text tapToStartLabel = celebrationPopup.tapToStartLabel;
				string text = Strings.Get(StringID.CELEBRATION_POPUP_CONTINUE);
				nint num2 = (nint)tapToStartLabel;
				object obj2 = tapToStartLabel + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				template.SetupDoubleUp(reward);
				_003C_003E4__this.PayoutReward(reward, allowRemove: false);
				MeshRenderer component = celebrationPopup.GlowEffect.GetComponent<MeshRenderer>();
				Material material = component.material;
				_ = 4575657222473777152L;
				_ = 4575657222473777152L;
				_ = 4575657222473777152L;
				_ = 4575657222473777152L;
				Color toColor = (Color)(vector + 16);
				IEnumerator routine = _003C_003E4__this.AnimateColor(material, 1.5f, toColor);
				Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
				Transform transform = celebrationPopup.GlowEffect.transform;
				_ = -930884096;
				((Vector3*)(nint)vector)->z = -270000f;
				_ = 0;
				((Vector3*)(nint)vector)->x = 0f;
				IEnumerator routine2 = _003C_003E4__this.RotateGameObject(transform, 3000f, vector);
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine(routine2);
				if (celebrationPopup._superMysteryBoxEffect != null)
				{
					celebrationPopup._superMysteryBoxEffect.StartEffect();
				}
				_003C_003E2__current = null;
				num = 1;
				result = true;
			}
			_003C_003E1__state = num;
			goto IL_029a;
			IL_029a:
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

	private sealed class _003CDoubleCoins_Routine_003Ed__192(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationReward reward;

		public CelebrationPopupLabelTemplate template;

		private int _003CcoinboxCountFromAmount_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_011f: Expected Obj, but got I4
			//IL_034a: Expected Obj, but got I
			//IL_028a: Expected Obj, but got I
			//IL_02bc: Expected Obj, but got I
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
							CelebrationPopup celebrationPopup2 = _003C_003E4__this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+8C]");
							IEnumerator routine = celebrationPopup2.AnimateAlpha((TMP_Text)0, 0.5f, 1f);
							Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+84]");
							((GameObject)0).SetActive(value: true);
						}
						return false;
					}
					_003C_003E1__state = -1;
					CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = template;
					GameObject gameObject = celebrationPopupLabelTemplate.doubleUpItemLabel.gameObject;
					IEnumerator routine2 = _003C_003E4__this.TweenScaleUpDown(gameObject);
					Coroutine coroutine2 = _003C_003E4__this.StartCoroutine(routine2);
					_003C_003E2__current = coroutine2;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E1__state = -1;
				CelebrationReward celebrationReward = reward;
				int num = celebrationReward.amount << 1;
				object obj = num - celebrationReward.amount;
				float num2 = (float)obj / 100000f;
				float num3 = Math.Min(num2, 1f);
				bool flag = num2 < 0f;
				float num4 = 0f;
				if (!flag)
				{
					num4 = num3;
				}
				float num5 = num4 * 2.5f;
				float num6 = num5 + 1.5f;
				float delay = num6 * 0.5f;
				CelebrationReward celebrationReward2 = reward;
				CelebrationPopup celebrationPopup3 = _003C_003E4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+318]");
				IEnumerator routine3 = celebrationPopup3.PlaySoundDelayed((AudioClip)0, delay, 0.7f);
				Coroutine coroutine3 = _003C_003E4__this.StartCoroutine(routine3);
				bool isMegaJackpot = celebrationReward2.amount > MysteryBox.superMysteryBoxJackpotAmount;
				IEnumerator routine4 = _003C_003E4__this.CountUpCoins(_003CcoinboxCountFromAmount_003E5__2, num, template, isMegaJackpot, celebrationReward.amount, 0.5f, doubled: true);
				Coroutine coroutine4 = _003C_003E4__this.StartCoroutine(routine4);
				_003C_003E2__current = coroutine4;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			PlayerInfo instance = PlayerInfo.Instance;
			int amountOfCoins = instance.amountOfCoins;
			_003CcoinboxCountFromAmount_003E5__2 = amountOfCoins;
			IEnumerator routine5 = _003C_003E4__this.Initial_Generic_DoubleUp_Routine(reward, template);
			Coroutine coroutine5 = _003C_003E4__this.StartCoroutine(routine5);
			_003C_003E2__current = coroutine5;
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

	private sealed class _003CDoubleKeys_Routine_003Ed__194(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationReward reward;

		public CelebrationPopupLabelTemplate template;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00c2: Expected Obj, but got I
			//IL_0159: Expected Obj, but got I
			//IL_018b: Expected Obj, but got I
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						CelebrationPopup celebrationPopup2 = _003C_003E4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+8C]");
						IEnumerator routine = celebrationPopup2.AnimateAlpha((TMP_Text)0, 0.5f, 1f);
						Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+84]");
						((GameObject)0).SetActive(value: true);
					}
					return false;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+318]");
				AudioSource audioSource = NGUITools.PlaySound((AudioClip)0, 0.7f);
				CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = template;
				GameObject gameObject = celebrationPopupLabelTemplate.doubleUpItemLabel.gameObject;
				IEnumerator routine2 = _003C_003E4__this.TweenScaleUpDown(gameObject);
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine(routine2);
				_003C_003E2__current = coroutine2;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			IEnumerator routine3 = _003C_003E4__this.Initial_Generic_DoubleUp_Routine(reward, template);
			Coroutine coroutine3 = _003C_003E4__this.StartCoroutine(routine3);
			_003C_003E2__current = coroutine3;
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

	private sealed class _003CDoubleTokens_Routine_003Ed__196(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationReward reward;

		public CelebrationPopupLabelTemplate template;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0163: Expected Obj, but got I
			//IL_018d: Expected Obj, but got I
			//IL_01bf: Expected Obj, but got I
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+318]");
						AudioSource audioSource = NGUITools.PlaySound((AudioClip)0, 0.7f);
						CelebrationPopup celebrationPopup2 = _003C_003E4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+8C]");
						IEnumerator routine = celebrationPopup2.AnimateAlpha((TMP_Text)0, 0.5f, 1f);
						Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+84]");
						((GameObject)0).SetActive(value: true);
					}
					return false;
				}
				_003C_003E1__state = -1;
				MissionsManager instance = MissionsManager.Instance;
				CelebrationReward celebrationReward = reward;
				instance.PlayerDidThis(MissionTarget.Tokens, celebrationReward.amount);
				CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = template;
				GameObject gameObject = celebrationPopupLabelTemplate.doubleUpItemLabel.gameObject;
				IEnumerator routine2 = _003C_003E4__this.TweenScaleUpDown(gameObject);
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine(routine2);
				_003C_003E2__current = coroutine2;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			IEnumerator routine3 = _003C_003E4__this.Initial_Generic_DoubleUp_Routine(reward, template);
			Coroutine coroutine3 = _003C_003E4__this.StartCoroutine(routine3);
			_003C_003E2__current = coroutine3;
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

	private sealed class _003CDoublePowerups_Routine_003Ed__198(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public CelebrationReward reward;

		public CelebrationPopupLabelTemplate template;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00c2: Expected Obj, but got I
			//IL_0159: Expected Obj, but got I
			//IL_018b: Expected Obj, but got I
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						CelebrationPopup celebrationPopup2 = _003C_003E4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+8C]");
						IEnumerator routine = celebrationPopup2.AnimateAlpha((TMP_Text)0, 0.5f, 1f);
						Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+84]");
						((GameObject)0).SetActive(value: true);
					}
					return false;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (CelebrationPopup)+318]");
				AudioSource audioSource = NGUITools.PlaySound((AudioClip)0, 0.7f);
				CelebrationPopupLabelTemplate celebrationPopupLabelTemplate = template;
				GameObject gameObject = celebrationPopupLabelTemplate.doubleUpItemLabel.gameObject;
				IEnumerator routine2 = _003C_003E4__this.TweenScaleUpDown(gameObject);
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine(routine2);
				_003C_003E2__current = coroutine2;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			IEnumerator routine3 = _003C_003E4__this.Initial_Generic_DoubleUp_Routine(reward, template);
			Coroutine coroutine3 = _003C_003E4__this.StartCoroutine(routine3);
			_003C_003E2__current = coroutine3;
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

	private sealed class _003C_003Ec__DisplayClass199_0
	{
		public TweenScale tweenScale;

		public CelebrationPopup _003C_003E4__this;

		internal void _003CTweenScaleUpDown_003Eb__0()
		{
			TweenScale tweenScale = this.tweenScale;
			CelebrationPopup celebrationPopup = _003C_003E4__this;
			float duration = celebrationPopup._scaleUpDuration * celebrationPopup._scaleDownDurationFactor;
			tweenScale.duration = duration;
			TweenScale tweenScale2 = this.tweenScale;
			CelebrationPopup celebrationPopup2 = _003C_003E4__this;
			tweenScale2.method = celebrationPopup2._scaleDownMethod;
			tweenScale2.PlayReverse();
		}
	}

	private sealed class _003CTweenScaleUpDown_003Ed__199(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CelebrationPopup _003C_003E4__this;

		public GameObject go;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_007e: Expected Obj, but got I
			//IL_00f6: Expected Obj, but got I
			//IL_014b: Expected Obj, but got I
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected Obj, but got Unknown
			//IL_019e: Expected Obj, but got I
			//IL_01bb: Expected Obj, but got I
			//IL_01da: Expected Obj, but got I
			//IL_01ef: Expected F4, but got I
			//IL_022a: Expected Obj, but got I
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Expected Obj, but got Unknown
			//IL_00e1: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
				}
			}
			else
			{
				CelebrationPopup celebrationPopup = _003C_003E4__this;
				_003C_003E1__state = -1;
				_ = _003C_003E4__this;
				TweenScale component = go.GetComponent<TweenScale>();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v18 (System.Object)+8]");
				if ((UnityEngine.Object)0 == null)
				{
					TweenScale tweenScale = go.AddComponent<TweenScale>();
					EventDelegate.Callback callback = default;
					object obj3 = default;
					callback._002Ector(obj3, (nint)__ldftn(_003C_003Ec__DisplayClass199_0._003CTweenScaleUpDown_003Eb__0));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v18 (System.Object)+8]");
					((UITweener)0).AddOnFinished(callback);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v18 (System.Object)+8]");
				object obj4 = 0;
				Transform transform = go.transform;
				Vector3 localScale = transform.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v18 (System.Object)+8]");
				object obj5 = 0;
				Transform transform2 = _003C_003E4__this.transform;
				Vector3 localScale2 = transform2.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (CelebrationPopup)+2FC]");
				object obj6 = obj * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (CelebrationPopup)+300]");
				object obj7 = num * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (CelebrationPopup)+304]");
				object obj8 = num2 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v18 (System.Object)+8]");
				UITweener uITweener = (UITweener)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (CelebrationPopup)+310]");
				uITweener.duration = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (CelebrationPopup)+308]");
				uITweener.method = UITweener.Method.Linear;
				uITweener.Play();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (CelebrationPopup)+310]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (CelebrationPopup)+314]");
				object obj9 = num3 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (CelebrationPopup)+310]");
				object obj10 = 0 + obj9;
				object obj11 = default;
				_003C_003E2__current = obj11;
				_003C_003E1__state = 1;
			}
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

	private sealed class _003CPlaySoundDelayed_003Ed__200(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public AudioClip clip;

		public float volume;

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
					AudioSource audioSource = NGUITools.PlaySound(clip, volume);
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = delay;
			object obj = default;
			_003C_003E2__current = obj;
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

	private const float MOVE_IN_NEXT_CELEBRATION_DURATION = 0.35f;

	private const float REMOVE_CELEBRATION_POPUP_AFTER_OPEN = 0.7f;

	private const string POPUP_PATH = "Prefabs/Popups/";

	public GameObject boxParent;

	public CelebrationPopupLabelTemplate rewardLabelTemplate;

	private Vector3 _outOfScreenPosition = (Vector3)(-4317263192788041728L);

	private Vector3 _jackpotPosition;

	private GameObject prizeButtonNormal;

	private Button PrizeListNormalClickeds;

	private GameObject prizeButtonSuper;

	private GameObject prizeButtonMini;

	private readonly Vector3 _ShowPrizeButtonPosition = (Vector3)(-4451808228389158912L);

	private readonly Vector3 _HidePrizeButtonPosition;

	private GameObject openButtonCollider;

	private GameObject skipButtonCollider;

	private GameObject continueButtonCollider;

	private CanvasGroup tapToStart;

	private TMP_Text tapToStartLabel;

	private GameObject coinbox;

	private TMP_Text coinboxLabel;

	public TMP_Text newTrophyLabel;

	private static readonly Vector3 FIRST_SLOT_POSITION;

	private static readonly Vector3 OTHER_SLOT_OFFSET;

	private static readonly Vector3 SUPERBOX_EFFECT_POSITION;

	private GameObject[] slots;

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

	private GameObject rewardKey;

	private GameObject rewardBronzeCan;

	private GameObject rewardSilverCan;

	private GameObject rewardGoldCan;

	private GameObject[] rewardsTopRun;

	private GameObject _weeklyHuntTopTitle;

	private TMP_Text _weeklyHuntTopTitleLabel;

	private GameObject fleshEffectPrefab;

	private GameObject preOpenLabel;

	private GameObject flashEffectGO;

	public AudioStateLoop audioStateLoop;

	private int _currentReward;

	private GameObject[] _celebrationRewardContainer;

	private bool anotherReward;

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

	private Vector3 _rewardEndScale_coin;

	private Vector3 _rewardEndScale_coin_jackpot;

	private Vector3 _rewardEndScale;

	private Vector3 _rewardEndScaleCan;

	private Vector3 _rewardEndScaleTopRunRank;

	private Vector3 _rewardEndPositionCan;

	private Vector3 _rewardEndPositionTopRunRank;

	private Vector3 _rewardEndPositionTopRunMedal;

	private Vector3 _labelPosition;

	private Vector3 _labelPositionCelebration;

	private Vector3 _continueLabelPosition;

	private bool _maySetTimeScale;

	public GameObject GlowEffect;

	private Color32 EFFECT_INITIAL_COLOR;

	private bool stopIdleAnim;

	private int _numberOfRewards;

	private CoinBoxSizer coinboxSizer;

	private CelebrationReward[] rewardsToUnlock;

	private bool celebrationHasStarted;

	private bool _isFingerPressed;

	private SuperMysteryBoxEffect _superMysteryBoxEffect;

	private float _timeScaleBeforeCelebrationPopup;

	private Texture2D awardsBackground;

	private Texture2D normalBackground;

	private Texture2D _weeklyHuntBackground;

	private Texture2D _weeklyHuntStripe;

	private GameObject stripePanel;

	private Texture2D characterEventBackgroundTexture;

	private UITexture[] _stripeTextures;

	private bool _isRewardingJackpot;

	private BragCelebrationHandler _bragCelebrationHandler;

	private MysteryBoxDoubleUpButton _mysteryBoxDoubleUpButton;

	private Vector3 _scaleTargetFactor;

	private UITweener.Method _scaleUpMethod;

	private UITweener.Method _scaleDownMethod;

	private float _scaleUpDuration;

	private float _scaleDownDurationFactor;

	private AudioClip _doubleRewardClip;

	private Dictionary<CelebrationRewardType, Action> _doubleRewardCallbacks;

	private float _animationLerpFactor;

	private bool isWaitingForInput;

	private bool skipWaitBackButtonPressed;

	private CelebrationReward _rewardToDouble;

	private CelebrationPopupLabelTemplate _rewardTemplate;

	private GameObject Celebration;

	private GameObject _backgroundPanel;

	private ButtonEvent OpenButton;

	private ButtonEvent SkipButton;

	private ButtonEvent ContinueButton;

	private unsafe void Start()
	{
		ButtonEvent openButton = OpenButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(CelebrationPopup._003CStart_003Eb__136_0));
		openButton.OnPress.AddListener(unityAction);
		ButtonEvent openButton2 = OpenButton;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(CelebrationPopup._003CStart_003Eb__136_1));
		openButton2.OnRelease.AddListener(unityAction2);
		ButtonEvent skipButton = SkipButton;
		UnityAction unityAction3 = default;
		unityAction3._002Ector(this, (nint)__ldftn(CelebrationPopup._003CStart_003Eb__136_2));
		skipButton.OnPress.AddListener(unityAction3);
		ButtonEvent continueButton = ContinueButton;
		UnityAction unityAction4 = default;
		unityAction4._002Ector(this, (nint)__ldftn(CelebrationPopup._003CStart_003Eb__136_3));
		continueButton.OnRelease.AddListener(unityAction4);
		Button prizeListNormalClickeds = PrizeListNormalClickeds;
		UnityAction unityAction5 = default;
		unityAction5._002Ector(this, (nint)__ldftn(CelebrationPopup._003CStart_003Eb__136_4));
		prizeListNormalClickeds.m_OnClick.AddListener(unityAction5);
	}

	public unsafe override void Init()
	{
		//IL_015a: Expected I, but got Obj
		//IL_006c: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<CelebrationPopup>)+104] (should have been resolved before IL gen)");
		Celebration.SetActive(value: true);
		GameObject gameObject = _bragCelebrationHandler.gameObject;
		gameObject.SetActive(value: false);
		rewardLabelTemplate.Alpha = 0f;
		AudioStateLoop audioStateLoop = Utils.FindObject<AudioStateLoop>(this);
		this.audioStateLoop = audioStateLoop;
		CoinBoxSizer coinBoxSizer = coinboxSizer;
		coinboxLabel = coinBoxSizer.coinAmountLabel;
		TMP_Text weeklyHuntTopTitleLabel = _weeklyHuntTopTitleLabel;
		string text = Strings.Get(StringID.CELEBRATION_ITEM_HUNT_TOP_TITLE);
		nint num2 = (nint)weeklyHuntTopTitleLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<CelebrationRewardType, System.Action>>>)+4] (should have been resolved before IL gen)");
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CelebrationPopup.DoubleCoins));
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<CelebrationRewardType, System.Action>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v108 @ S5_v4+4] (should have been resolved before IL gen)");
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(CelebrationPopup.DoubleKeys));
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<CelebrationRewardType, System.Action>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S5_v9+4] (should have been resolved before IL gen)");
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(CelebrationPopup.DoublePowerups));
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<CelebrationRewardType, System.Action>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ S5_v14+4] (should have been resolved before IL gen)");
		Dictionary<CelebrationRewardType, Action> doubleRewardCallbacks = default;
		_doubleRewardCallbacks = doubleRewardCallbacks;
	}

	public override void Show()
	{
		base.Show();
		UIScreenController instance = UIScreenController.Instance;
		throw new ArgumentException();
	}

	public override void Hide()
	{
		base.Hide();
		UIScreenController instance = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private unsafe void SetupCelebrationScreen()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected VT, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_0329: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected I4, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected Obj, but got Unknown
		//IL_08d2: Expected Obj, but got I
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_0688: Expected Obj, but got I
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected Obj, but got Unknown
		//IL_06c1: Expected Obj, but got I
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_04cc: Expected Obj, but got I
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_088b: Expected Obj, but got I
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_0520: Expected Obj, but got I
		//IL_0585: Expected I, but got Obj
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected VT, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected Obj, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_0641: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		_ = 0;
		Transform transform = boxParent.transform;
		UIModelController instance = UIModelController.Instance;
		Transform transform2 = instance.CelebrationPopupAnchor.transform;
		Vector3 position = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Vector3 position2 = vector + 32;
		transform.position = position2;
		CelebrationReward[] rewardsToUnlockForCelebration = RewardManager.GetRewardsToUnlockForCelebration();
		rewardsToUnlock = rewardsToUnlockForCelebration;
		object obj2 = 0;
		CelebrationReward[] array;
		while (true)
		{
			array = rewardsToUnlock;
			if (array.Length <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)array + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v175+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v176+8]");
			if ((nint)0 != 1)
			{
				object obj6 = obj2 << 2;
				object obj7 = (object)rewardsToUnlock + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v184+10]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v185+8]");
				if ((nint)0 == 2)
				{
					_ = 0;
					PlayerInfo instance2 = PlayerInfo.Instance;
					if (~(instance2._willShowSMBAfterDailyChallenge ? 1u : 0u) == 0)
					{
						_ = 1;
						PlayerInfo instance3 = PlayerInfo.Instance;
						instance3._willShowSMBAfterDailyChallenge = false;
					}
					bool flag = (byte)(int)(vector + 95) != 0;
					string text = (flag ? ((bool*)1) : ((bool*)null))->ToString();
				}
			}
			object obj9 = obj2 + 1;
			obj2 = obj9;
		}
		_numberOfRewards = array.Length;
		if (array.Length <= 0)
		{
			anotherReward = false;
			UIScreenController instance4 = UIScreenController.Instance;
			instance4.CloseActivePopups(screenName);
			openButtonCollider.SetActive(value: false);
			return;
		}
		bool flag2 = array.Length != 1;
		anotherReward = flag2;
		CelebrationReward celebrationReward = array[0];
		TogglePrizeButtons(celebrationReward.CelebrationRewardOrigin);
		GameObject gameObject = newTrophyLabel.gameObject;
		gameObject.SetActive(value: false);
		GameObject[] array2 = slots;
		object obj10 = 0;
		while (array2.Length > (nint)obj10)
		{
			object obj11 = obj10 << 2;
			object obj12 = (object)array2 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v158+10]");
			UnityEngine.Object.Destroy((UnityEngine.Object)0);
			object obj13 = obj10 + 1;
			obj10 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] array3 = default;
		slots = array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] celebrationRewardContainer = default;
		_celebrationRewardContainer = celebrationRewardContainer;
		object obj14 = 0;
		if (_numberOfRewards > (nint)obj14)
		{
			GameObject gameObject2 = NGUITools.AddChild(boxParent);
			throw new ArrayTypeMismatchException();
		}
		FillOutAllTheSlotsWithRewardContainers();
		_currentReward = 0;
		object prefab;
		if (superMysteryBoxEffectPrefab != null && roundGlowEffectPrefab != null)
		{
			int num = _currentReward << 2;
			object obj15 = slots + num;
			int num2 = _currentReward << 2;
			object obj16 = rewardsToUnlock + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S0_v81+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v82+8]");
			if ((nint)0 != 10)
			{
				int num3 = _currentReward << 2;
				object obj18 = rewardsToUnlock + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v113+10]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S0_v114+8]");
				if ((nint)0 != 11)
				{
					prefab = this + 192;
					goto IL_0876;
				}
			}
			prefab = this + 196;
			goto IL_0876;
		}
		goto IL_08a1;
		IL_08a1:
		int num4 = _currentReward << 2;
		object obj20 = rewardsToUnlock + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v49+10]");
		UpdateGui((CelebrationReward)0);
		if (IsTwoStepsCelebration(_currentReward))
		{
			int num5 = _currentReward << 2;
			object obj21 = _celebrationRewardContainer + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S1_v56+10]");
			Transform rewardTrans = ((GameObject)0).transform;
			int num6 = _currentReward << 2;
			object obj22 = rewardsToUnlock + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S2_v29+10]");
			StartIdleAnimCoroutine(rewardTrans, (CelebrationReward)0);
		}
		else
		{
			StartOneStepUnlock();
		}
		return;
		IL_0876:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v77+10]");
		GameObject gameObject3 = NGUITools.AddChild((GameObject)0, (GameObject)prefab);
		Transform transform3 = gameObject3.transform;
		Transform transform4 = transform3.transform;
		nint num7 = (nint)typeof(CelebrationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S1_v73 (Il2CppClass<CelebrationPopup>)+5C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S1_v74 (Il2CppStaticFields<CelebrationPopup>)+20]");
		_ = 0;
		_ = SUPERBOX_EFFECT_POSITION;
		Vector3 localPosition = vector + 16;
		transform4.localPosition = localPosition;
		SuperMysteryBoxEffect component = gameObject3.GetComponent<SuperMysteryBoxEffect>();
		_superMysteryBoxEffect = component;
		if (!(_superMysteryBoxEffect == null))
		{
			int num9 = _currentReward << 2;
			object obj23 = rewardsToUnlock + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S1_v85+10]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S1_v86+8]");
			ToggleSuperMysteryBoxEffect(CelebrationRewardOrigin.Notset);
		}
		goto IL_08a1;
	}

	private unsafe void FillOutAllTheSlotsWithRewardContainers()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c04: Expected VT, but got Unknown
		//IL_0040: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_058b: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected VT, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected VT, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected VT, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Expected VT, but got Unknown
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected VT, but got Unknown
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected VT, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected VT, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected VT, but got Unknown
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected VT, but got Unknown
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected VT, but got Unknown
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected VT, but got Unknown
		//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Expected VT, but got Unknown
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected VT, but got Unknown
		//IL_0af3: Expected F4, but got I
		//IL_0aee: Expected native int or pointer, but got VT
		//IL_0b15: Expected F4, but got I
		//IL_0b10: Expected native int or pointer, but got VT
		//IL_0324: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I
		//IL_046e: Expected Obj, but got I
		//IL_0424: Expected Obj, but got I
		//IL_04b8: Expected Obj, but got I
		//IL_0512: Expected Obj, but got VT
		//IL_02a4: Expected Obj, but got I
		//IL_0556: Expected Obj, but got I
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 352);
		object obj2 = default;
		GameObject gameObject2;
		if (_numberOfRewards > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)rewardsToUnlock + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v23+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24+8]");
			object obj6 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24+8]");
			if ((nint)0 == 1)
			{
				goto IL_01dc;
			}
			if ((nint)obj6 != 1)
			{
				if ((nint)obj6 == 2)
				{
					goto IL_0b87;
				}
				if ((nint)obj6 == 3)
				{
					goto IL_01dc;
				}
				if ((nint)obj6 != 4)
				{
					if ((nint)obj6 != 5)
					{
						if ((nint)obj6 == 6 || (nint)obj6 == 7 || (nint)obj6 == 8)
						{
							goto IL_0b87;
						}
						if ((nint)obj6 != 9)
						{
							if ((nint)obj6 != 10)
							{
								if ((nint)obj6 != 11)
								{
									if ((nint)obj6 == 12)
									{
										goto IL_0226;
									}
									goto IL_0b87;
								}
								object obj7 = obj2 << 2;
								object obj8 = (object)slots + obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v248+10]");
								GameObject gameObject = NGUITools.AddChild((GameObject)0, miniMysteryBoxPrefab);
								gameObject2 = gameObject;
							}
							else
							{
								PlayerInfo instance = PlayerInfo.Instance;
								PlayerInfo instance2 = PlayerInfo.Instance;
								int currentThemeIndex = instance2.currentThemeIndex;
								GameObject gameObject3 = ((CelebrationPopup)quaternion).ShowModel((Characters.CharacterType)instance._currentCharacter, currentThemeIndex, UIModelController.ModelScreen.CelebrationTopRun);
								Transform transform = gameObject3.transform;
								object obj9 = obj2 << 2;
								object obj10 = (object)slots + obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ S1_v197+10]");
								Transform parent = ((GameObject)0).transform;
								transform.parent = parent;
								gameObject2 = gameObject3;
							}
						}
						else
						{
							object obj11 = obj2 << 2;
							object obj12 = (object)slots + obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S0_v233+10]");
							GameObject gameObject4 = NGUITools.AddChild((GameObject)0, achievementBagPrefab);
							gameObject2 = gameObject4;
						}
					}
					else
					{
						WeeklyHuntManager.PrizePeriodId activePeriode = WeeklyHuntManager.GetActivePeriode();
						if (activePeriode == WeeklyHuntManager.PrizePeriodId.PeriodOne)
						{
							object obj13 = obj2 << 2;
							object obj14 = (object)slots + obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v223+10]");
							GameObject gameObject5 = NGUITools.AddChild((GameObject)0, hiddenPrizePrefab_blue);
							gameObject2 = gameObject5;
						}
						else
						{
							WeeklyHuntManager.PrizePeriodId activePeriode2 = WeeklyHuntManager.GetActivePeriode();
							if (activePeriode2 == WeeklyHuntManager.PrizePeriodId.PeriodTwo)
							{
								object obj15 = obj2 << 2;
								object obj16 = (object)slots + obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S0_v213+10]");
								GameObject gameObject6 = NGUITools.AddChild((GameObject)0, hiddenPrizePrefab_green);
								gameObject2 = gameObject6;
							}
							else
							{
								WeeklyHuntManager.PrizePeriodId activePeriode3 = WeeklyHuntManager.GetActivePeriode();
								if (activePeriode3 == WeeklyHuntManager.PrizePeriodId.PeriodThree)
								{
									object obj17 = obj2 << 2;
									object obj18 = (object)slots + obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v203+10]");
									GameObject gameObject7 = NGUITools.AddChild((GameObject)0, hiddenPrizePrefab_red);
									gameObject2 = gameObject7;
								}
								else
								{
									object obj19 = obj2 << 2;
									object obj20 = (object)slots + obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v193+10]");
									GameObject gameObject8 = NGUITools.AddChild((GameObject)0, hiddenPrizePrefab_blue);
									gameObject2 = gameObject8;
								}
							}
						}
					}
					goto IL_0575;
				}
			}
			goto IL_0226;
		}
		MeshRenderer component = GlowEffect.GetComponent<MeshRenderer>();
		Material material = component.material;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 0;
		_ = 0;
		Color value = (Color)(quaternion + 224);
		material.SetColor("_MainColor", value);
		return;
		IL_01dc:
		object obj21 = obj2 << 2;
		object obj22 = (object)slots + obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v152+10]");
		GameObject gameObject9 = NGUITools.AddChild((GameObject)0, mysteryBoxPrefab);
		gameObject2 = gameObject9;
		goto IL_0575;
		IL_0575:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24+8]");
		object obj23 = -10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24+8]");
		if ((nint)0 != 10)
		{
			if ((nint)obj23 != 1)
			{
				if ((nint)obj23 == 2)
				{
					Transform transform2 = gameObject2.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+1A0]");
					_ = 0;
					_ = _miniboxScale;
					Vector3 localScale = (Vector3)(quaternion + 208);
					transform2.localScale = localScale;
					Transform transform3 = gameObject2.transform;
					float num = (float)_boxRotation * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+160]");
					float num2 = 0f * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+164]");
					float num3 = 0f * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+148]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+140]");
					_ = 0;
					Vector3 euler = (Vector3)(quaternion + 192);
					Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+158]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+158]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+150]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+150]");
					_ = 0;
					Quaternion localRotation = (Quaternion)(quaternion + 176);
					transform3.localRotation = localRotation;
				}
				else
				{
					Transform transform4 = gameObject2.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+158]");
					_ = 0;
					_ = _boxScale;
					Vector3 localScale2 = (Vector3)(quaternion + 32);
					transform4.localScale = localScale2;
					Transform transform5 = gameObject2.transform;
					float num4 = (float)_boxRotation * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+160]");
					float num5 = 0f * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+164]");
					float num6 = 0f * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+148]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+140]");
					_ = 0;
					Vector3 euler2 = (Vector3)(quaternion + 16);
					Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+158]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+158]");
					((Quaternion*)(nint)quaternion)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+150]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+150]");
					((Quaternion*)(nint)quaternion)->x = 0f;
					transform5.localRotation = quaternion;
				}
			}
			else
			{
				Transform transform6 = gameObject2.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+194]");
				_ = 0;
				_ = _boxScaleTopRun;
				Vector3 localScale3 = (Vector3)(quaternion + 160);
				transform6.localScale = localScale3;
				Transform transform7 = gameObject2.transform;
				float num7 = (float)_boxRotationTopRun * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+1A8]");
				float num8 = 0f * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+1AC]");
				float num9 = 0f * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+148]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+140]");
				_ = 0;
				Vector3 euler3 = (Vector3)(quaternion + 144);
				Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+158]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+158]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+150]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+150]");
				_ = 0;
				Quaternion localRotation2 = (Quaternion)(quaternion + 128);
				transform7.localRotation = localRotation2;
				Transform transform8 = gameObject2.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+1B8]");
				_ = 0;
				_ = _boxPositionTopRun;
				Vector3 localPosition = (Vector3)(quaternion + 112);
				transform8.localPosition = localPosition;
			}
		}
		else
		{
			Transform transform9 = gameObject2.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+170]");
			_ = 0;
			_ = _boxScaleAward;
			Vector3 localScale4 = (Vector3)(quaternion + 96);
			transform9.localScale = localScale4;
			Transform transform10 = gameObject2.transform;
			float num10 = (float)_boxRotationAward * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+178]");
			float num11 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+17C]");
			float num12 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+148]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+140]");
			_ = 0;
			Vector3 euler4 = (Vector3)(quaternion + 80);
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+150]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+150]");
			_ = 0;
			Quaternion localRotation3 = (Quaternion)(quaternion - -64);
			transform10.localRotation = localRotation3;
			Transform transform11 = gameObject2.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationPopup)+188]");
			_ = 0;
			_ = _boxPositionAward;
			Vector3 localPosition2 = (Vector3)(quaternion + 48);
			transform11.localPosition = localPosition2;
		}
		Transform t = gameObject2.transform;
		int layer = boxParent.layer;
		Utility.SetLayerRecursively(t, layer);
		throw new ArrayTypeMismatchException();
		IL_0b87:
		throw new ArrayTypeMismatchException();
		IL_0226:
		object obj24 = obj2 << 2;
		object obj25 = (object)slots + obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v162+10]");
		GameObject gameObject10 = NGUITools.AddChild((GameObject)0, superMysteryBoxPrefab);
		gameObject2 = gameObject10;
		goto IL_0575;
	}

	private void UpdateGui(CelebrationReward reward)
	{
		//IL_0339: Expected Obj, but got I4
		GameObject gameObject = newTrophyLabel.gameObject;
		gameObject.SetActive(value: false);
		object obj = reward.CelebrationRewardOrigin - 1;
		if (reward.CelebrationRewardOrigin == CelebrationRewardOrigin.MysteryBox)
		{
			goto IL_016f;
		}
		bool active;
		bool active2 = default;
		bool active3 = default;
		if ((nint)obj != 1)
		{
			if ((nint)obj != 2)
			{
				if ((nint)obj != 3 && (nint)obj != 4 && (nint)obj != 5)
				{
					if ((nint)obj == 6)
					{
						goto IL_029f;
					}
					if ((nint)obj != 7)
					{
						if ((nint)obj != 8)
						{
							if ((nint)obj != 9)
							{
								if ((nint)obj == 10)
								{
									goto IL_029f;
								}
								if ((nint)obj == 11)
								{
									goto IL_016f;
								}
								if ((nint)obj != 12)
								{
									active = false;
									goto IL_035b;
								}
								ResetBackgroundToNormal();
								SetPreOpenedCelebrationLabelTemplate(reward);
							}
							else
							{
								ResetBackgroundToNormal();
							}
							goto IL_0288;
						}
						ResetBackgroundToNormal();
						GameObject gameObject2 = _bragCelebrationHandler.gameObject;
						Transform t = gameObject2.transform;
						UIScreenController instance = UIScreenController.Instance;
						GameObject gameObject3 = instance.CameraOverlay2d.gameObject;
						int layer = gameObject3.layer;
						Utility.SetLayerRecursively(t, layer);
						GameObject gameObject4 = _bragCelebrationHandler.gameObject;
						gameObject4.SetActive(value: true);
						active = false;
					}
					else
					{
						ResetBackgroundToNormal();
						active = false;
					}
				}
				else
				{
					IEnumerator routine = AnimateStripes();
					Coroutine coroutine = StartCoroutine(routine);
					active2 = true;
					active3 = true;
					active = false;
				}
			}
			else
			{
				IEnumerator routine2 = AnimateStripes();
				Coroutine coroutine2 = StartCoroutine(routine2);
				active3 = true;
				active = false;
			}
			goto IL_035b;
		}
		ResetBackgroundToNormal();
		goto IL_0288;
		IL_029f:
		ResetBackgroundToNormal();
		active2 = true;
		active = false;
		goto IL_035b;
		IL_0288:
		active2 = true;
		active = true;
		goto IL_035b;
		IL_016f:
		ResetBackgroundToNormal();
		goto IL_0288;
		IL_035b:
		_backgroundPanel.SetActive(value: true);
		coinbox.SetActive(active);
		_weeklyHuntTopTitle.SetActive(active3);
		openButtonCollider.SetActive(active2);
	}

	private void SetPreOpenedCelebrationLabelTemplate(CelebrationReward reward)
	{
		if (reward.CelebrationRewardOrigin == CelebrationRewardOrigin.CharacterEventSuperMysteryBox)
		{
			rewardLabelTemplate.SetupCharacterWordEvent(reward.characterEventCompleted, reward.description);
		}
	}

	private void ToggleSuperMysteryBoxEffect(CelebrationRewardOrigin origin)
	{
		//IL_0013: Expected Obj, but got I4
		if (!(_superMysteryBoxEffect != null))
		{
			return;
		}
		object obj = origin - 2;
		if (origin != CelebrationRewardOrigin.SuperMysteryBox)
		{
			if ((nint)obj == 1)
			{
				goto IL_0174;
			}
			if ((nint)obj != 2 && (nint)obj != 3 && (nint)obj != 4)
			{
				if ((nint)obj == 5 || (nint)obj == 6 || (nint)obj == 7)
				{
					goto IL_0174;
				}
				if ((nint)obj != 8)
				{
					if ((nint)obj == 9)
					{
						return;
					}
					if ((nint)obj == 10 || (nint)obj != 11)
					{
						goto IL_0174;
					}
				}
			}
		}
		_superMysteryBoxEffect.FastForwardEffect(3);
		_superMysteryBoxEffect.StartEffect();
		return;
		IL_0174:
		_superMysteryBoxEffect.StopEffect();
	}

	private bool IsTwoStepsCelebration(int rewardIndex)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I
		int num = rewardIndex << 2;
		object obj = _celebrationRewardContainer + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7+10]");
		bool flag = (UnityEngine.Object)0 == null;
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	private void StartIdleAnimCoroutine(Transform rewardTrans, CelebrationReward reward)
	{
		//IL_006f: Expected I, but got Obj
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		TMP_Text tMP_Text = tapToStartLabel;
		IEnumerator routine;
		if (reward.CelebrationRewardOrigin == CelebrationRewardOrigin.TopRun)
		{
			string text = Strings.Get(StringID.CELEBRATION_POPUP_CONTINUE);
			nint num = (nint)tMP_Text;
			object obj = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S3_v11 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			tapToStart.alpha = 1f;
			routine = CharacterIdleAnimCoroutine((Transform)(object)this, (CelebrationReward)(object)this);
		}
		else
		{
			string text2 = Strings.Get(StringID.CELEBRATION_POPUP_OPEN);
			nint num2 = (nint)tMP_Text;
			object obj2 = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S3_v4 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			tapToStart.alpha = 1f;
			routine = BoxIdleAnimCoroutine(rewardTrans, reward);
		}
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator CharacterIdleAnimCoroutine(Transform rewardTrans, CelebrationReward reward)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator BoxIdleAnimCoroutine(Transform rewardTrans, CelebrationReward reward)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator StartIdleAnimationFor(Transform rewardTrans, Vector3 baseLocalPos)
	{
		_ = 0;
		_ = baseLocalPos.z;
		_ = baseLocalPos.x;
		IEnumerator result = default;
		return result;
	}

	private void OnApplicationPause(bool pause)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I
		int num = _currentReward << 2;
		object obj = rewardsToUnlock + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v3+10]");
		object obj2 = 0;
		if (!pause && ~(_isFingerPressed ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+8]");
			if ((nint)0 != 11)
			{
				FingerReleased();
			}
		}
	}

	private unsafe void PlayTopRunAnimation(bool didHighFive)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I
		if (celebrationHasStarted)
		{
			return;
		}
		celebrationHasStarted = true;
		openButtonCollider.SetActive(value: false);
		if (!IsTwoStepsCelebration(_currentReward))
		{
			return;
		}
		int num = _currentReward << 2;
		object obj = _celebrationRewardContainer + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v16+10]");
		CharacterModel component = ((GameObject)0).GetComponent<CharacterModel>();
		if (!(component != null) || !(component._topRunIdleAnimation != null))
		{
			return;
		}
		TopRunIdleAnimation.AnimationFinishDelegate animationFinishDelegate = default;
		animationFinishDelegate._002Ector(this, (nint)__ldftn(CelebrationPopup.OnTopRunAnimationFinished));
		component._topRunIdleAnimation.AnimationFinished += animationFinishDelegate;
		bool flag = audioStateLoop != null;
		if (didHighFive)
		{
			if (flag)
			{
				audioStateLoop.PlayUnlockSound();
			}
			if (_superMysteryBoxEffect != null)
			{
				_superMysteryBoxEffect.StartEffect();
			}
			component._topRunIdleAnimation.TR_PlayHit();
		}
		else
		{
			if (flag)
			{
				audioStateLoop.PlayCelebrationTapSound();
			}
			component._topRunIdleAnimation.TR_PlayMiss();
		}
	}

	public unsafe void OnTopRunAnimationFinished()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I
		int num = _currentReward << 2;
		object obj = _celebrationRewardContainer + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7+10]");
		CharacterModel component = ((GameObject)0).GetComponent<CharacterModel>();
		if (component != null && component._topRunIdleAnimation != null)
		{
			TopRunIdleAnimation.AnimationFinishDelegate animationFinishDelegate = default;
			animationFinishDelegate._002Ector(this, (nint)__ldftn(CelebrationPopup.OnTopRunAnimationFinished));
			component._topRunIdleAnimation.AnimationFinished -= animationFinishDelegate;
		}
		IEnumerator routine = _ShowReward(_currentReward);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator AnimateScreenFlash(Image effectSprite)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void FingerPressed()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		if (_isFingerPressed)
		{
			return;
		}
		stopIdleAnim = true;
		_isFingerPressed = true;
		if (!IsTwoStepsCelebration(_currentReward))
		{
			return;
		}
		int num = _currentReward << 2;
		object obj = _celebrationRewardContainer + num;
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		UnityEngine.Object obj2 = default;
		if (obj2 != null)
		{
			AnimationState animationState = ((Animation)obj2).get_Item("down");
			if ((bool)animationState)
			{
				bool flag = ((Animation)obj2).Play("down");
			}
		}
	}

	private void StartOneStepUnlock()
	{
		FingerReleased();
	}

	public void FingerReleased()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I
		if (preOpenLabel != null)
		{
			UnityEngine.Object.Destroy(preOpenLabel);
		}
		int num = _currentReward << 2;
		object obj = rewardsToUnlock + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v14+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15+8]");
		if ((nint)0 != 11)
		{
			if (celebrationHasStarted)
			{
				return;
			}
			openButtonCollider.SetActive(value: false);
			HidePrizeButtons();
			if (_superMysteryBoxEffect != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15+8]");
				if ((nint)0 != 10)
				{
					_superMysteryBoxEffect.StopEffect();
				}
			}
			IEnumerator routine = AnimateAlpha(tapToStartLabel, 0.5f, 0f);
			Coroutine coroutine = StartCoroutine(routine);
			IEnumerator routine2 = _ShowReward(_currentReward);
			Coroutine coroutine2 = StartCoroutine(routine2);
			celebrationHasStarted = true;
		}
		else
		{
			IEnumerator routine3 = AnimateAlpha(tapToStartLabel, 0.5f, 0f);
			Coroutine coroutine3 = StartCoroutine(routine3);
			PlayTopRunAnimation(didHighFive: true);
		}
	}

	private IEnumerator _ShowReward(int currentRewardIndex)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void PayoutReward(CelebrationReward reward, bool allowRemove = true)
	{
		//IL_0390: Expected Obj, but got I4
		object obj = reward.rewardType - 1;
		if (reward.rewardType != CelebrationRewardType.coins)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4 && (nint)obj != 5 && (nint)obj != 6 && (nint)obj == 7)
						{
							UIScreenController instance = UIScreenController.Instance;
							instance.justPaidOutTopRun = true;
							UIScreenController instance2 = UIScreenController.Instance;
							instance2.PayoutCelebrationReward(reward);
						}
					}
					else
					{
						PlayerInfo instance3 = PlayerInfo.Instance;
						int amountOfKeys = instance3.amountOfKeys;
						int amountOfKeys2 = amountOfKeys + reward.amount;
						instance3.amountOfKeys = amountOfKeys2;
					}
				}
			}
			else
			{
				PlayerInfo instance4 = PlayerInfo.Instance;
				instance4.IncreaseUpgradeAmount(reward.powerupType, reward.amount);
			}
		}
		else
		{
			if (coinboxSizer != null)
			{
				coinboxSizer.updateAutomatically = false;
			}
			PlayerInfo instance5 = PlayerInfo.Instance;
			int amountOfCoins = instance5.amountOfCoins;
			int amountOfCoins2 = amountOfCoins + reward.amount;
			instance5.amountOfCoins = amountOfCoins2;
			MissionsManager instance6 = MissionsManager.Instance;
			instance6.PlayerDidThis(MissionTarget.EarnCoin, reward.amount);
			if (isJackpot(reward))
			{
				PlayerInfo instance7 = PlayerInfo.Instance;
				Statistics stats = instance7._stats;
				int[] values = stats._values;
				int value = values[33] + 1;
				stats.set_Item(Stat.TotalJackpotsWon, value);
				SocialManager instance8 = SocialManager.instance;
				if (instance8.facebookIsLoggedIn)
				{
					PlayerInfo instance9 = PlayerInfo.Instance;
					Statistics stats2 = instance9._stats;
					int[] values2 = stats2._values;
					int value2 = values2[32] + 1;
					stats2.set_Item(Stat.JackpotsWon, value2);
				}
			}
		}
		if (allowRemove)
		{
			RewardManager.RewardPayedOut(reward);
		}
		PlayerInfo instance10 = PlayerInfo.Instance;
		instance10.SaveIfDirty();
		_isRewardingJackpot = false;
	}

	private void _FinishOpening()
	{
		//IL_005f: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		_rewardToDouble = null;
		_rewardTemplate = null;
		celebrationHasStarted = false;
		if (_superMysteryBoxEffect != null)
		{
			_superMysteryBoxEffect.StopEffect();
		}
		if (~(anotherReward ? 1u : 0u) == 0)
		{
			IEnumerator routine = MoveNextBoxToFront();
			Coroutine coroutine = StartCoroutine(routine);
			return;
		}
		GameObject[] array = slots;
		object obj = 0;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v57+10]");
			UnityEngine.Object.Destroy((UnityEngine.Object)0);
			object obj4 = obj + 1;
			obj = obj4;
		}
		ResetBackgroundToNormal();
		skipButtonCollider.SetActive(value: true);
		openButtonCollider.SetActive(value: false);
		NGUITools.SetActive(flashEffectGO, state: false);
		int rewardsToUnlockCount = RewardManager.rewardsToUnlockCount;
		if (rewardsToUnlockCount >= 1 && ~(RewardManager.canShowMultipleQueuedCelebrations ? 1u : 0u) == 0)
		{
			SetupCelebrationScreen();
			return;
		}
		if (~(RewardManager.canShowMultipleQueuedCelebrations ? 1u : 0u) == 0)
		{
			RewardManager.canShowMultipleQueuedCelebrations = false;
		}
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups("CelebrationPopup");
	}

	private IEnumerator MoveNextBoxToFront()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator RotateGameObject(Transform trans, float duration, Vector3 angleToRotate)
	{
		_ = 0;
		_ = angleToRotate.x;
		_ = angleToRotate.z;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator CountUpCoins(int coinboxAmount, int toAmount, CelebrationPopupLabelTemplate rewardTemplate, bool isMegaJackpot = false, int fromAmount = 0, float countTimeMultiplier = 1f, bool doubled = false)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private float CalcCoinCountTime(int toAmount, int fromAmount, float countTimeMultiplier)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = toAmount - fromAmount;
		float num = (float)obj / 100000f;
		float num2 = Math.Min(num, 1f);
		bool flag = num < 0f;
		float num3 = 0f;
		if (!flag)
		{
			num3 = num2;
		}
		float num4 = num3 * 2.5f;
		float num5 = num4 + 1.5f;
		return num5 * countTimeMultiplier;
	}

	private IEnumerator AnimateAlpha(TMP_Text label, float duration, float toAlpha)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateAlpha(CelebrationPopupLabelTemplate template, float duration, float toAlpha)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateColor(UIWidget widget, float duration, Color toColor)
	{
		_ = 0;
		_ = toColor.r;
		_ = toColor.b;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateColor(Material material, float duration, Color toColor)
	{
		_ = 0;
		_ = toColor.r;
		_ = toColor.b;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateEffectColor(Image spriteToAnimate, Color color1, Color color2, float speedFactor = 1f, bool instant = false)
	{
		_ = 0;
		_ = color1.b;
		_ = color1.r;
		_ = color2.r;
		_ = color2.b;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator MoveGameObject(Transform trans, float duration, Vector3 toPos)
	{
		_ = 0;
		_ = toPos.x;
		_ = toPos.z;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator ScaleGameObject(Transform trans, float duration, Vector3 toScale)
	{
		_ = 0;
		_ = toScale.x;
		_ = toScale.z;
		IEnumerator result = default;
		return result;
	}

	private GameObject ChooseRewardPrefab(CelebrationReward reward)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I4
		object obj = reward.CelebrationRewardOrigin - 10;
		GameObject result;
		if (reward.CelebrationRewardOrigin != CelebrationRewardOrigin.Award)
		{
			if ((nint)obj != 1)
			{
				result = rewardCoins;
			}
			else
			{
				object obj2 = reward.rank - 1;
				GameObject[] array = rewardsTopRun;
				if ((nint)obj2 <= array.Length)
				{
					object obj3 = obj2 << 2;
					object obj4 = (object)array + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v47+10]");
					return (GameObject)0;
				}
				object obj5 = array.Length - 1;
				object obj6 = obj5 << 2;
				object obj7 = (object)array + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v44+10]");
				result = (GameObject)0;
			}
			object obj8 = reward.rewardType - 1;
			if (reward.rewardType == CelebrationRewardType.coins)
			{
				bool flag = isJackpot(reward);
				object obj9 = 208;
				if (!flag)
				{
					obj9 = 204;
				}
				return (GameObject)(object)((object)this + obj9);
			}
			if ((nint)obj8 != 1)
			{
				if ((nint)obj8 != 2)
				{
					if ((nint)obj8 == 3)
					{
						return rewardKey;
					}
					if ((nint)obj8 == 4)
					{
						result = rewardSpecialBoard;
					}
				}
			}
			else
			{
				object obj10 = reward.powerupType - 1;
				if (reward.powerupType == PowerupType.hoverboard)
				{
					return rewardPowerupHoverboard;
				}
				if ((nint)obj10 != 1)
				{
					if ((nint)obj10 == 2)
					{
						return rewardPowerupHeadstart2000;
					}
					if (reward.powerupType == PowerupType.scorebooster)
					{
						return rewardPowerupScoreBooster;
					}
				}
			}
		}
		else
		{
			object obj11 = reward.awardTierType - 1;
			if (reward.awardTierType == AwardTierType.Bronze)
			{
				return rewardBronzeCan;
			}
			if ((nint)obj11 == 1)
			{
				return rewardSilverCan;
			}
			if ((nint)obj11 == 2)
			{
				return rewardGoldCan;
			}
			result = rewardCoins;
		}
		return result;
	}

	private IEnumerator AnimateStripes()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void ResetBackgroundToNormal()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		IEnumerator routine = AnimateStripes();
		StopCoroutine(routine);
		_backgroundPanel.SetActive(value: false);
		object obj = this + 748;
		if (_stripeTextures != null)
		{
			object obj2 = 0;
			UITexture[] array = _stripeTextures;
			while ((nint)obj2 < array.Length)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v20+10]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: false);
				object obj5 = obj2 << 2;
				object obj6 = obj + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v25+10]");
				GameObject obj7 = ((Component)0).gameObject;
				UnityEngine.Object.Destroy(obj7);
				object obj8 = obj2 + 1;
				obj2 = obj8;
				array = (UITexture[])obj;
			}
		}
		obj = 0;
	}

	private void HidePrizeButtons()
	{
		Transform toHide = prizeButtonNormal.transform;
		PrizeButtonHide(toHide);
		Transform toHide2 = prizeButtonSuper.transform;
		PrizeButtonHide(toHide2);
		Transform toHide3 = prizeButtonMini.transform;
		PrizeButtonHide(toHide3);
	}

	private void TogglePrizeButtons(CelebrationRewardOrigin origin)
	{
		//IL_0086: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		if (origin <= CelebrationRewardOrigin.SuperMysteryBox)
		{
			object obj = origin - 1;
			if (origin != CelebrationRewardOrigin.MysteryBox && (nint)obj != 1)
			{
				goto IL_00c5;
			}
		}
		else
		{
			object obj2 = origin - 12;
			if (origin != CelebrationRewardOrigin.MysteryBoxMini && (nint)obj2 != 1)
			{
				if (origin == CelebrationRewardOrigin.WeeklyChallengeHiddenPrize)
				{
					return;
				}
				goto IL_00c5;
			}
		}
		Transform toShow = prizeButtonNormal.transform;
		((CelebrationPopup)origin).PrizeButtonShow(toShow);
		return;
		IL_00c5:
		Transform toHide = prizeButtonNormal.transform;
		((CelebrationPopup)origin).PrizeButtonHide(toHide);
		Transform toHide2 = prizeButtonSuper.transform;
		((CelebrationPopup)origin).PrizeButtonHide(toHide2);
		Transform toHide3 = prizeButtonMini.transform;
		((CelebrationPopup)origin).PrizeButtonHide(toHide3);
	}

	private void PrizeButtonShow(Transform toShow)
	{
		GameObject gameObject = toShow.gameObject;
		gameObject.SetActive(value: true);
	}

	private void PrizeButtonHide(Transform toHide)
	{
		GameObject gameObject = toHide.gameObject;
		gameObject.SetActive(value: false);
	}

	private void ShowPrizeList(MysteryBox.Type type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		if (preOpenLabel != null)
		{
			preOpenLabel.SetActive(value: false);
		}
		bool flag = type == MysteryBox.Type.Normal;
		object obj3 = "PrizeMBPopup_Keys";
		if (!flag)
		{
			bool flag2 = type == MysteryBox.Type.Super;
			object obj4 = "PrizeSMBPopup_Keys";
			if (!flag2)
			{
				if (type != MysteryBox.Type.Mini)
				{
					_ = -1;
					obj = (Enum)(object)typeof(MysteryBox.Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
					_ = 0;
					string text = obj.ToString();
					string text2 = "Unhandeled mysterybox type " + text;
					return;
				}
				obj4 = "PrizeMMBPopup";
			}
			obj3 = obj4;
		}
		UIScreenController instance = UIScreenController.Instance;
		instance.PushPopup((string)obj3);
		object obj5 = 0;
		while (_numberOfRewards > (nint)obj5)
		{
			object obj6 = obj5 << 2;
			object obj7 = (object)_celebrationRewardContainer + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v49+10]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj8 = obj5 << 2;
				object obj9 = (object)_celebrationRewardContainer + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v60+10]");
				NGUITools.SetActive((GameObject)0, state: false);
			}
			object obj10 = obj5 + 1;
			obj5 = obj10;
		}
		if (_superMysteryBoxEffect != null)
		{
			_superMysteryBoxEffect.StopEffect();
			_superMysteryBoxEffect.SetVisible(visible: false);
		}
		openButtonCollider.SetActive(value: false);
		skipButtonCollider.SetActive(value: false);
		tapToStartLabel.enabled = false;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (openButtonCollider.activeInHierarchy)
			{
				FingerPressed();
				FingerReleased();
			}
			if (skipButtonCollider.activeInHierarchy)
			{
				SkipNow();
			}
			if (~(isWaitingForInput ? 1u : 0u) == 0)
			{
				skipWaitBackButtonPressed = true;
			}
		}
	}

	private bool ShouldWaitForInput()
	{
		if (~(skipWaitBackButtonPressed ? 1u : 0u) == 0)
		{
			skipWaitBackButtonPressed = false;
			return false;
		}
		return isWaitingForInput;
	}

	public void StopWaitingForInput()
	{
		if (~(isWaitingForInput ? 1u : 0u) == 0)
		{
			isWaitingForInput = false;
			_mysteryBoxDoubleUpButton.DisableButton();
		}
	}

	public void SkipNow()
	{
		//IL_001e: Expected VT, but got Obj
		//IL_002c: Expected Obj, but got VT
		if (~(_maySetTimeScale ? 1u : 0u) == 0 && !_isRewardingJackpot)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((TimeScaleManager)val).TimeScale = 4f;
		}
	}

	public void OnPopClosed(string popupName)
	{
		if (!(popupName != "PrizeMBPopup_Keys") || !(popupName != "PrizeMMBPopup") || popupName == "PrizeSMBPopup_Keys")
		{
			ClosePrizeList();
		}
	}

	public void ClosePrizeList()
	{
		//IL_01af: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I
		object obj = 0;
		while (_numberOfRewards > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)_celebrationRewardContainer + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v37+10]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj4 = obj << 2;
				object obj5 = (object)_celebrationRewardContainer + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v48+10]");
				NGUITools.SetActive((GameObject)0, state: true);
			}
			object obj6 = obj + 1;
			obj = obj6;
		}
		if (_superMysteryBoxEffect != null)
		{
			_superMysteryBoxEffect.SetVisible(visible: true);
			int num = _currentReward << 2;
			object obj7 = rewardsToUnlock + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v15+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v16+8]");
			ToggleSuperMysteryBoxEffect(CelebrationRewardOrigin.Notset);
		}
		openButtonCollider.SetActive(value: true);
		skipButtonCollider.SetActive(value: true);
		tapToStartLabel.enabled = true;
		if (preOpenLabel != null)
		{
			preOpenLabel.SetActive(value: true);
		}
	}

	private GameObject ShowModel(Characters.CharacterType charType, int themeIndex, UIModelController.ModelScreen modelScreen)
	{
		UIModelController instance = UIModelController.Instance;
		return instance.ShowCharacterInCelebration(charType, themeIndex, modelScreen);
	}

	private void HideModel()
	{
		UIModelController instance = UIModelController.Instance;
		instance.DeactivateCelebrationPopupModels();
	}

	private void ShowBackgroundWithStripes(Hoverboards.BoardType boardType, UIModelController.ModelScreen modelScreen)
	{
		UIModelController instance = UIModelController.Instance;
		GameObject gameObject = instance.ActivateCelebrationBoardWithStripes(boardType, modelScreen);
	}

	private void HideSpecialBoard()
	{
		UIModelController instance = UIModelController.Instance;
		instance.DeactivateCelebrationPopupModels();
	}

	private bool isJackpot(CelebrationReward reward)
	{
		//IL_0018: Expected Obj, but got I4
		bool flag = reward.rewardType != CelebrationRewardType.coins;
		bool result = false;
		if (!flag)
		{
			object obj = reward.CelebrationRewardOrigin - 1;
			if (reward.CelebrationRewardOrigin == CelebrationRewardOrigin.MysteryBox)
			{
				goto IL_00bc;
			}
			if ((nint)obj != 1)
			{
				bool flag2 = (nint)obj == 2;
				result = false;
				if (flag2)
				{
					goto IL_018f;
				}
				if ((nint)obj == 3)
				{
					goto IL_00bc;
				}
				if ((nint)obj != 4)
				{
					bool flag3 = reward.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterEventSuperMysteryBox;
					result = false;
					if (flag3)
					{
						goto IL_018f;
					}
				}
			}
			bool flag4 = reward.amount < MysteryBox.superMysteryBoxJackpotAmount;
			result = false;
			if (!flag4)
			{
				goto IL_0148;
			}
		}
		goto IL_018f;
		IL_0148:
		_isRewardingJackpot = true;
		result = true;
		goto IL_018f;
		IL_00bc:
		if (reward.amount >= MysteryBox.mysteryBoxJackpotAmount)
		{
			goto IL_0148;
		}
		result = false;
		goto IL_018f;
		IL_018f:
		return result;
	}

	private void DoubleCoins()
	{
		if (_rewardToDouble != null && _rewardTemplate != null)
		{
			IEnumerator routine = DoubleCoins_Routine(_rewardToDouble, _rewardTemplate);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator Initial_Generic_DoubleUp_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator DoubleCoins_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void DoubleKeys()
	{
		if (_rewardToDouble != null && _rewardTemplate != null)
		{
			IEnumerator routine = DoubleKeys_Routine(_rewardToDouble, _rewardTemplate);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator DoubleKeys_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void DoubleTokens()
	{
		if (_rewardToDouble != null && _rewardTemplate != null)
		{
			IEnumerator routine = DoubleTokens_Routine(_rewardToDouble, _rewardTemplate);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator DoubleTokens_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void DoublePowerups()
	{
		if (_rewardToDouble != null && _rewardTemplate != null)
		{
			IEnumerator routine = DoublePowerups_Routine(_rewardToDouble, _rewardTemplate);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator DoublePowerups_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator TweenScaleUpDown(GameObject go)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator PlaySoundDelayed(AudioClip clip, float delay = 0f, float volume = 1f)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public CelebrationPopup()
	{
		//IL_0014: Expected VT, but got I8
		//IL_0023: Expected VT, but got I8
		//IL_0076: Expected VT, but got I8
		//IL_0095: Expected VT, but got I8
		//IL_00b8: Expected VT, but got I8
		//IL_00db: Expected VT, but got I8
		//IL_00fa: Expected VT, but got I8
		//IL_0119: Expected VT, but got I4
		//IL_013c: Expected VT, but got I8
		//IL_015b: Expected VT, but got I8
		//IL_0181: Expected VT, but got I8
		//IL_01a4: Expected VT, but got I8
		//IL_01c7: Expected VT, but got I8
		//IL_01e6: Expected VT, but got I4
		//IL_01f7: Expected VT, but got I4
		//IL_021b: Expected VT, but got I8
		//IL_023a: Expected VT, but got I8
		//IL_025d: Expected VT, but got I8
		_ = 1110966272;
		_ = -4416905334543613952L;
		_ = 3267887104L;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] array = default;
		slots = array;
		_ = -1020002304;
		_ = -4530621225134718976L;
		_rewardStartRotationTopRunRank = (Vector3)(-4380876534284550144L);
		_ = 1127481344;
		_ = 4715268809856909312L;
		_rewardStartRotationJackpot = (Vector3)4842495499330125824L;
		_ = 4674736414298996736L;
		_ = 4674736414292705280L;
		_rewardStartScale = (Vector3)4647714816528482304L;
		_ = 3240624128L;
		_ = 4715268809856909312L;
		_boxPositionTopRun = (Vector3)(-4412964683785437184L);
		_ = 3274964992L;
		_ = 1147207680;
		_miniboxScale = (Vector3)4927219468467240960L;
		_ = 4726527810025816064L;
		_ = 4726527808925335552L;
		_boxPositionAward = (Vector3)0;
		_ = 4701758012104900608L;
		_ = 4728779609831636992L;
		_boxScaleAward = (Vector3)4692750812812673024L;
		_ = 4728779609871089664L;
		_ = 1150271488;
		_boxScale = (Vector3)4940378423631527936L;
		anotherReward = true;
		_ = 0;
		_ = 0;
		_rewardStartScaleJackpot = (Vector3)4927219468467240960L;
		_ = 4692750812867264512L;
		_ = 4692750812812673024L;
		_rewardEndScale_coin_jackpot = (Vector3)4945656079446081536L;
		_ = 4728779609890521088L;
		_ = 4728779609840025600L;
		_rewardEndScaleCan = (Vector3)4759178907331854336L;
		_ = 4710765211337621504L;
		_ = 4710765211326349312L;
		_rewardEndPositionCan = (Vector3)0;
		_ = 0;
		EFFECT_INITIAL_COLOR = (Color32)16777215;
		_scaleDownMethod = UITweener.Method.EaseIn;
		_ = 3251109888L;
		_rewardEndPositionTopRunMedal = (Vector3)4715268809856909312L;
		_ = 0;
		_ = -4566650018884485120L;
		_labelPositionCelebration = (Vector3)(-4386506037058863104L);
		_ = 3231711232L;
		_ = -4566650018876096512L;
		_scaleTargetFactor = (Vector3)4584664421729357005L;
		_scaleUpDuration = 0.0875f;
		_ = 9657384960L;
		_timeScaleBeforeCelebrationPopup = 1f;
		base._002Ector();
	}

	static CelebrationPopup()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0037: Expected VT, but got I8
		//IL_0045: Expected I, but got Obj
		//IL_0065: Expected VT, but got I4
		//IL_0073: Expected I, but got Obj
		//IL_0093: Expected VT, but got I4
		nint num = (nint)typeof(CelebrationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<CelebrationPopup>)+5C]");
		nint num2 = 0;
		_ = -1035468800;
		FIRST_SLOT_POSITION = (Vector3)4715268809856909312L;
		nint num3 = (nint)typeof(CelebrationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<CelebrationPopup>)+5C]");
		nint num4 = 0;
		_ = 1175611392;
		OTHER_SLOT_OFFSET = (Vector3)0;
		nint num5 = (nint)typeof(CelebrationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<CelebrationPopup>)+5C]");
		nint num6 = 0;
		_ = 1127481344;
		SUPERBOX_EFFECT_POSITION = (Vector3)0;
	}

	private void _003CStart_003Eb__136_0()
	{
		FingerPressed();
	}

	private void _003CStart_003Eb__136_1()
	{
		FingerReleased();
	}

	private void _003CStart_003Eb__136_2()
	{
		SkipNow();
	}

	private void _003CStart_003Eb__136_3()
	{
		StopWaitingForInput();
	}

	private void _003CStart_003Eb__136_4()
	{
		ShowPrizeList(MysteryBox.Type.Normal);
	}
}
