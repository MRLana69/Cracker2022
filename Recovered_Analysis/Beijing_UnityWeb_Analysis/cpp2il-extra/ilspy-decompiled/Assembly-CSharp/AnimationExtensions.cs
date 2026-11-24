using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class AnimationExtensions : MonoBehaviour
{
	private sealed class _003CPlay_003Ed__0(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public bool useTimeScale;

		public Animation animation;

		public string clipName;

		public Action onComplete;

		private AnimationState _003C_currState_003E5__2;

		private bool _003CisPlaying_003E5__3;

		private float _003C_progressTime_003E5__4;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Expected Obj, but got Unknown
				//IL_00a7: Expected I4, but got Obj
				//IL_00b3: Expected Obj, but got I4
				//IL_0173: Unknown result type (might be due to invalid IL or missing references)
				//IL_0178: Expected Obj, but got Unknown
				//IL_0181: Expected Obj, but got I4
				//IL_0195: Expected Obj, but got I4
				//IL_0127: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Expected Obj, but got Unknown
				//IL_0135: Expected Obj, but got I4
				//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d3: Expected Obj, but got Unknown
				//IL_02f9: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							if (onComplete != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
							}
							object obj = this + 32;
							obj = 0;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (~(useTimeScale ? 1u : 0u) == 0)
					{
						AnimationState animationState = animation.CrossFadeQueued(clipName);
						return null;
					}
					object obj2 = this + 32;
					bool flag = animation.Play((PlayMode)clipName);
					obj2 = flag;
					_003CisPlaying_003E5__3 = true;
					_003C_progressTime_003E5__4 = 0f;
					AnimationState animationState2 = animation.CrossFadeQueued(clipName);
				}
				if (~(_003CisPlaying_003E5__3 ? 1u : 0u) != 0)
				{
					object obj3 = this + 12;
					obj3 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				float fixedDeltaTime = Time.fixedDeltaTime;
				float num = _003C_progressTime_003E5__4 + fixedDeltaTime;
				_003C_progressTime_003E5__4 = num;
				float distance = ((RaycastHit*)_003C_currState_003E5__2)->distance;
				float speed = _003C_progressTime_003E5__4 / distance;
				_003C_currState_003E5__2.speed = speed;
				Animation.INTERNAL_CALL_Sample(animation);
				float distance2 = ((RaycastHit*)_003C_currState_003E5__2)->distance;
				if (!(_003C_progressTime_003E5__4 < distance2))
				{
					AnimationClip clip = _003C_currState_003E5__2.clip;
					if ((nint)clip == 2)
					{
						_003C_progressTime_003E5__4 = 0f;
					}
					else
					{
						_003CisPlaying_003E5__3 = false;
					}
				}
				object obj4 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj5 = default;
				obj4 = obj5;
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

	public static IEnumerator Play(Animation animation, string clipName, bool useTimeScale, Action onComplete)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03e3: Expected Obj, but got I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0406: Expected Obj, but got I4
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected I, but got Unknown
		//IL_041c: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0209: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_0509: Expected Obj, but got I4
		//IL_0337: Expected Obj, but got I
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_02ab: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		nint num = (nint)(obj2 + 32);
		num = (nint)obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 != onComplete)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v109+18]");
				if (0 != (nint)clipName)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v109+1C]");
				if ((nint)0 == (useTimeScale ? 1 : 0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj7 != null)
					{
						object obj8 = num + 4;
						object obj9 = obj8 + 1;
						obj8 = obj9;
						object obj10 = obj9 << 2;
						object obj11 = num + obj10;
						obj11 = 108;
						break;
					}
				}
				continue;
			}
			object obj12 = num + 4;
			object obj13 = obj12 + 1;
			obj12 = obj13;
			object obj14 = obj13 << 2;
			object obj15 = num + obj14;
			obj15 = 106;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppMethodInfo)+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppMethodInfo)+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = num + obj16;
			if ((nint)obj17 == 108)
			{
				object obj18 = num + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_0503;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppMethodInfo)+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppMethodInfo)+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = num + obj20;
			if ((nint)obj21 == 106)
			{
				object obj22 = num + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0503;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0503;
		IL_0503:
		return (IEnumerator)1;
	}
}
