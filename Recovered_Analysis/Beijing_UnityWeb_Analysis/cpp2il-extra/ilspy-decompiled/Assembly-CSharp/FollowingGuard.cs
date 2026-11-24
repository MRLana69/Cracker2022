using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Common;
using SYBO.Subway;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using SYBO.Subway.Placeholders.Lifecycles;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class FollowingGuard : MonoBehaviour
{
	[Serializable]
	public class CatchAnimationSet
	{
		public AnimationClip avatar;

		public AnimationClip guard;

		public AnimationClip dog;

		public float catchAvatarAnimationPlayOffset;

		public float waitTimeBeforeScreen;

		public CatchAnimationSet()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	[Serializable]
	public class DefaultAnimations
	{
		public AnimationClip[] introGuard;

		public AnimationClip[] introDog;

		public AnimationClip[] runGuard;

		public AnimationClip[] runDog;

		public AnimationClip[] jumpGuard;

		public AnimationClip[] jumpDog;

		public AnimationClip[] hangtimeGuard;

		public AnimationClip[] hangtimeDog;

		public AnimationClip[] landingGuard;

		public AnimationClip[] landingDog;

		public AnimationClip[] dodgeLeftGuard;

		public AnimationClip[] dodgeLeftDog;

		public AnimationClip[] dodgeRigthGuard;

		public AnimationClip[] dodgeRightDog;

		public AnimationClip[] rollGuard;

		public AnimationClip[] rollDog;

		public AnimationClip[] catchupGuard;

		public AnimationClip[] deathByTrainGuard;

		public AnimationClip[] deathByTrainDog;
	}

	public delegate void OnCatchPlayerDelegate(string currentChartacterCatch, float catchUpTime, float waitTimeBeforeScreen);

	private sealed class _003CResetCatchUpCoroutine_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FollowingGuard _003C_003E4__this;

		public float duration;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Expected Obj, but got Unknown
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Expected Obj, but got Unknown
				//IL_01b1: Expected Obj, but got I
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_0105: Expected Obj, but got Unknown
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Expected Obj, but got Unknown
				//IL_0166: Expected Obj, but got I4
				FollowingGuard followingGuard = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						AudioSource component = followingGuard.GetComponent<AudioSource>();
						component.Pause();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (FollowingGuard)+90]");
						object obj = -(-64);
						if (obj == null)
						{
							((HouseKeeper)(object)followingGuard).OnAppHasRefreshed((RefreshType)0);
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (FollowingGuard)+68]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj3 = default;
					object obj2 = obj3 + 12;
					obj2 = followingGuard;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (FollowingGuard)+6C]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num = 0;
					_ = 0;
					object obj5 = default;
					object obj4 = obj5 + 16;
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
					IEnumerator routine = default;
					Coroutine coroutine = followingGuard.StartCoroutine_Auto(routine);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num2 = 0;
					_ = 0;
					object obj7 = default;
					object obj6 = obj7 + 16;
					obj6 = followingGuard;
					object obj8 = this + 12;
					float num3 = duration * 2f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
					IEnumerator routine2 = default;
					Coroutine coroutine2 = followingGuard.StartCoroutine_Auto(routine2);
					obj8 = coroutine2;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CResetCatchUpCoroutine_003Ed__57(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
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

	private sealed class _003CRollCoroutine_003Ed__64(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FollowingGuard _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected Obj, but got Unknown
				//IL_006c: Expected Obj, but got I4
				FollowingGuard followingGuard = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						float transformTweenDuration = ((CameraData)(object)followingGuard.character).TransformTweenDuration;
						float verticalSpeed = 0f - transformTweenDuration;
						followingGuard.verticalSpeed = verticalSpeed;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
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

	private sealed class _003CJumpCoroutine_003Ed__67(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FollowingGuard _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected Obj, but got Unknown
				//IL_006c: Expected Obj, but got I4
				FollowingGuard followingGuard = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this.HandleOnHangtime();
						float transformTweenDuration = ((CameraData)(object)followingGuard.character).TransformTweenDuration;
						float verticalSpeed = transformTweenDuration * 0.7f;
						followingGuard.verticalSpeed = verticalSpeed;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
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

	private sealed class _003CHangtimeCoroutine_003Ed__70(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FollowingGuard _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected Obj, but got Unknown
				//IL_006c: Expected Obj, but got I4
				//IL_00ae: Expected I4, but got Obj
				//IL_00ae: Expected I4, but got Obj
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c0: Expected Obj, but got Unknown
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Expected Obj, but got Unknown
				FollowingGuard followingGuard = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						DefaultAnimations defaultAnimations = followingGuard.defaultAnimations;
						DefaultAnimations defaultAnimations2 = followingGuard.defaultAnimations;
						string text = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations.hangtimeGuard, (int)defaultAnimations2.hangtimeDog);
						object clip = text + 16;
						AudioSource.PlayOneShotHelper((AudioSource)(object)followingGuard.guardAnimation, (AudioClip)clip, 0.1f);
						object clip2 = text + 20;
						AudioSource.PlayOneShotHelper((AudioSource)(object)followingGuard.dogAnimation, (AudioClip)clip2, 0.1f);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
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

	private sealed class _003CLandingCoroutine_003Ed__72(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FollowingGuard _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected Obj, but got Unknown
				//IL_006c: Expected Obj, but got I4
				//IL_00ae: Expected I4, but got Obj
				//IL_00ae: Expected I4, but got Obj
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c0: Expected Obj, but got Unknown
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Expected Obj, but got Unknown
				//IL_0133: Expected I4, but got Obj
				//IL_0133: Expected I4, but got Obj
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Expected Obj, but got Unknown
				//IL_0161: Expected VT, but got Obj
				//IL_0161: Expected VT, but got Obj
				//IL_016e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0173: Expected Obj, but got Unknown
				//IL_018a: Expected VT, but got Obj
				//IL_018a: Expected VT, but got Obj
				FollowingGuard followingGuard = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						DefaultAnimations defaultAnimations = followingGuard.defaultAnimations;
						DefaultAnimations defaultAnimations2 = followingGuard.defaultAnimations;
						string text = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations.landingGuard, (int)defaultAnimations2.landingDog);
						object clip = text + 16;
						AudioSource.PlayOneShotHelper((AudioSource)(object)followingGuard.guardAnimation, (AudioClip)clip, 0.1f);
						object clip2 = text + 20;
						AudioSource.PlayOneShotHelper((AudioSource)(object)followingGuard.dogAnimation, (AudioClip)clip2, 0.1f);
						DefaultAnimations defaultAnimations3 = followingGuard.defaultAnimations;
						DefaultAnimations defaultAnimations4 = followingGuard.defaultAnimations;
						string text2 = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations3.runGuard, (int)defaultAnimations4.runDog);
						object obj = text2 + 16;
						bool flag = Physics.Raycast((Vector3)followingGuard.guardAnimation, (Vector3)obj, 0.1f);
						object obj2 = text2 + 20;
						bool flag2 = Physics.Raycast((Vector3)followingGuard.dogAnimation, (Vector3)obj2, 0.1f);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj3 = this + 12;
				object obj4 = default;
				obj3 = obj4;
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

	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public FollowingGuard _003C_003E4__this;

		public Vector3 charPos;

		public _003C_003Ec__DisplayClass75_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CHitByTrainSequenceCoroutine_003Eb__0(float t)
		{
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			//IL_00c2: Expected F4, but got I
			//IL_00c2: Expected F4, but got Obj
			//IL_0013: Expected I, but got Obj
			Vector3 vector = charPos;
			Vector3 vector2 = charPos;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S3_v2 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v7 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FollowingGuard followingGuard = _003C_003E4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (UnityEngine.Vector3)+1C]");
			float num3 = Mathf.InverseLerp((float)followingGuard, 0f, t);
		}

		internal unsafe void _003CHitByTrainSequenceCoroutine_003Eb__1(float t)
		{
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected VT, but got Unknown
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected VT, but got Unknown
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected Obj, but got Unknown
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected Obj, but got Unknown
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected Obj, but got Unknown
			//IL_004a: Expected VT, but got Obj
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected Obj, but got Unknown
			//IL_008a: Expected I, but got Obj
			//IL_00a0: Expected Obj, but got I
			//IL_0155: Expected F4, but got Obj
			//IL_0150: Expected native int or pointer, but got VT
			//IL_0167: Expected F4, but got I
			//IL_0162: Expected native int or pointer, but got VT
			//IL_0174: Expected F4, but got Obj
			//IL_016f: Expected native int or pointer, but got VT
			//IL_0189: Expected F4, but got I
			//IL_0184: Expected native int or pointer, but got VT
			//IL_01ab: Expected F4, but got Obj
			//IL_01a6: Expected native int or pointer, but got VT
			//IL_01c0: Expected F4, but got I
			//IL_01bb: Expected native int or pointer, but got VT
			//IL_01c9: Expected Obj, but got VT
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_00cb: Expected I, but got Obj
			object obj = default;
			Vector3 vector = (Vector3)(obj + 48);
			Vector3 vector2 = (Vector3)(obj + 36);
			Transform transform = (Transform)(obj + 24);
			object obj2 = obj + 12;
			object obj3 = default;
			object obj9 = default;
			while (true)
			{
				FollowingGuard followingGuard = _003C_003E4__this;
				Transform[] enemies = followingGuard.enemies;
				if ((nint)obj3 >= enemies.Length)
				{
					break;
				}
				FollowingGuard followingGuard2 = _003C_003E4__this;
				object obj4 = followingGuard2.enemies + 16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				transform.position = (Vector3)obj6;
				FollowingGuard followingGuard3 = _003C_003E4__this;
				object obj7 = followingGuard3.character + 248;
				obj2 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v12+8]");
				_ = 0;
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Vector3 vector3 = Vector3.LerpUnclamped(vector2, vector, t);
				((Vector3*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Vector3 localPosition = ((Transform)vector).localPosition;
				obj3 = obj9 + 1;
			}
		}
	}

	private sealed class _003CHitByTrainSequenceCoroutine_003Ed__75(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FollowingGuard _003C_003E4__this;

		private _003C_003Ec__DisplayClass75_0 _003C_003E8__1;

		private string[] _003CdeathByTrainAnimations_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_034a: Unknown result type (might be due to invalid IL or missing references)
				//IL_034f: Expected Obj, but got Unknown
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Expected Obj, but got Unknown
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Expected Obj, but got Unknown
				//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d4: Expected Obj, but got Unknown
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e9: Expected Obj, but got Unknown
				//IL_0127: Expected Obj, but got I4
				//IL_013d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0142: Expected Obj, but got Unknown
				//IL_0152: Expected Obj, but got I
				//IL_0162: Expected Obj, but got I
				//IL_0197: Unknown result type (might be due to invalid IL or missing references)
				//IL_019c: Expected Obj, but got Unknown
				//IL_01b1: Expected Obj, but got I
				//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d5: Expected Obj, but got Unknown
				//IL_01f1: Expected Obj, but got I4
				//IL_0217: Expected Obj, but got I
				//IL_024c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0251: Expected Obj, but got Unknown
				//IL_0287: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Expected Obj, but got Unknown
				//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d8: Expected Obj, but got Unknown
				//IL_02f4: Expected Obj, but got I4
				//IL_030f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0314: Expected Obj, but got Unknown
				//IL_0329: Expected Obj, but got I
				object obj2 = default;
				object obj = obj2 + 12;
				FollowingGuard followingGuard = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								object animation = _003CdeathByTrainAnimations_003E5__2 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (FollowingGuard)+48]");
								AnimationState animationState = ((Animation)0).CrossFadeQueued((string)animation);
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (FollowingGuard)+98]");
						object obj3 = (nint)0 + (nint)236;
						obj2 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v11+8]");
						_ = 0;
						obj = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						object obj4 = _003C_003E8__1 + 12;
						obj4 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num = 0;
						_ = 0;
						object obj6 = default;
						object obj5 = obj6 + 16;
						obj5 = _003C_003E8__1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
						IEnumerator routine = default;
						Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto(routine);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.2f;
						object obj7 = this + 12;
						object obj8 = default;
						obj7 = obj8;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					object obj9 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (FollowingGuard)+C]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (FollowingGuard)+C]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v5+4C]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S3_v5+50]");
					string text = ((HouseKeeper)null).RoundUpToTargetValue((int)num2, 0);
					obj9 = text;
					object animation2 = _003CdeathByTrainAnimations_003E5__2 + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (FollowingGuard)+4C]");
					AnimationState animationState2 = ((Animation)0).CrossFadeQueued((string)animation2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 0.4f;
					object obj12 = this + 12;
					object obj13 = default;
					obj12 = obj13;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj14 = this + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj15 = default;
				obj14 = obj15;
				object obj16 = _003C_003E8__1 + 8;
				obj16 = _003C_003E4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				_ = 0;
				object obj18 = default;
				object obj17 = obj18 + 16;
				obj17 = _003C_003E8__1;
				object obj19 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
				IEnumerator routine2 = default;
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto(routine2);
				obj19 = coroutine2;
				_003C_003E1__state = 1;
				return 1;
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

	private DefaultAnimations defaultAnimations;

	private CatchAnimationSet[] caughtLeft;

	private CatchAnimationSet[] caughtRight;

	private float distanceToCharacterMin;

	private float distanceToCharacterMax;

	private float catchUpDuration;

	private float resetCatchUpDuration;

	private float lastGroundedSmoothTime;

	private float xSmoothTime;

	private float gravity;

	private Transform[] enemies;

	private int debugCatchAnimationToPlay;

	private float guardProximityLoopVolume;

	private PlaceholderLifecycle _placeholderLifecycle;

	private EnemiesRig _enemiesData;

	private Animation guardAnimation;

	private Animation dogAnimation;

	public bool isShowing;

	public OnCatchPlayerDelegate OnCatchPlayer;

	private string currentAvatarStumbleDeath;

	private string previusAvatarCaughtAnimLeft;

	private string previusAvatarCaughtAnimRight;

	private float y;

	private bool closeToCharacter;

	private float distanceToCharacter;

	private float lastGroundedSmooth;

	private float lastGroundedVelocity;

	private string previusAvatarStumbleDeath;

	private float verticalSpeed;

	private bool caught;

	private SmoothDampFloat x;

	private Renderer[] enemyRenderers;

	private Vector3[] enemiesStartPos;

	private Game game;

	private CharacterController characterController;

	private Character character;

	private CharacterRendering characterRendering;

	private static FollowingGuard instance;

	public static FollowingGuard Instance => null;

	public void Initialize()
	{
	}

	private unsafe void ReplaceSharedPrefab()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected Obj, but got Unknown
		//IL_0b15: Expected I, but got Obj
		//IL_0b2b: Expected Obj, but got I
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected Obj, but got Unknown
		//IL_0b64: Expected Obj, but got I4
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected Obj, but got Unknown
		//IL_0be1: Expected I, but got Obj
		//IL_0bf7: Expected Obj, but got I
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected Obj, but got Unknown
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected Obj, but got Unknown
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Expected Obj, but got Unknown
		//IL_0c69: Expected Obj, but got I
		//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected Obj, but got Unknown
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Expected Obj, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected Obj, but got Unknown
		//IL_00cb: Expected I, but got Obj
		//IL_0118: Expected I, but got Obj
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_019c: Expected VT, but got Obj
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02e0: Expected I, but got Obj
		//IL_02f6: Expected Obj, but got I
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Expected Obj, but got Unknown
		//IL_0321: Expected I, but got Obj
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_0426: Expected Obj, but got I4
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_03c5: Expected Obj, but got I
		//IL_03dd: Expected I4, but got Obj
		//IL_03fa: Expected I4, but got Obj
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0490: Expected Obj, but got I
		//IL_04a8: Expected I4, but got Obj
		//IL_04c5: Expected I4, but got Obj
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_05b2: Expected Obj, but got I4
		//IL_05bb: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected Obj, but got Unknown
		//IL_08c1: Expected Obj, but got I4
		//IL_09a8: Expected Obj, but got I
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e3: Expected Obj, but got Unknown
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected Obj, but got Unknown
		Transform transform = default;
		object obj = transform + 48;
		object obj2 = transform + 16;
		obj2 = obj;
		_ = -1;
		Game_OnCharacterModelRecreated();
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v299 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 144;
		bool isInstantiated = Game.IsInstantiated;
		obj4 = isInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FollowingGuard.Game_OnCharacterModelRecreated);
		object obj5 = action + 16;
		obj5 = this;
		this.game.OnCharacterModelRecreated -= action;
		object obj6 = this + 148;
		Game game = Game.Instance;
		obj6 = game;
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v27 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v295 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = this + 152;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		obj8 = characterRendering;
		nint num5 = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v34 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v291 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = transform + 24;
		object obj11 = this + 156;
		CharacterCamera characterCamera = CharacterCamera.Instance;
		obj11 = characterCamera;
		object obj12 = this + 136;
		string text = tag;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj13 = 0;
		object obj14 = obj13;
		object obj15 = obj14 & 0x1FFF;
		object obj16 = obj15 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v136 @ S4_v4 (should have been resolved before IL gen)");
		object obj17 = default;
		obj12 = obj17;
		object obj18 = this + 140;
		Transform[] array = enemies;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj19 = default;
		obj18 = obj19;
		object obj20 = default;
		object obj23 = default;
		while (true)
		{
			Transform[] array2 = enemies;
			if ((nint)obj20 >= array2.Length)
			{
				break;
			}
			object obj21 = enemies + 16;
			object obj22 = obj23 << 2;
			object obj24 = obj21 + obj22;
			transform.position = (Vector3)obj24;
			obj10 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj25 = enemiesStartPos + 16;
			object obj26 = obj23 * 12;
			object obj27 = obj25 + obj26;
			obj27 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v39+8]");
			_ = 0;
			obj20 = obj23 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = xSmoothTime;
		_ = 0f;
		_ = 0f;
		object obj28 = this + 132;
		object obj29 = default;
		obj28 = obj29;
		AudioSource component = GetComponent<AudioSource>();
		component.pitch = guardProximityLoopVolume;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<bool> action2 = default;
		object obj30 = action2 + 16;
		obj30 = this;
		this.game.OnPauseChange -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(FollowingGuard.OnSfxSettingChanged);
		object obj31 = action3 + 16;
		obj31 = this;
		nint num9 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v69 (Il2CppClass<Info.Settings>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num10 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v280 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Settings.onSfxSettingChanged -= action3;
		ResetModelRootPosition();
		object obj33 = caughtLeft + 12;
		object obj34 = default;
		object obj39 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33))
		{
			CharacterRendering characterRendering2 = this.characterRendering;
			SafeAnimation characterSafeAnimation = characterRendering2._characterSafeAnimation;
			object obj35 = caughtLeft + 16;
			object obj36 = obj34 << 2;
			object obj37 = obj35 + obj36;
			object obj38 = obj37;
			Animation animation = characterSafeAnimation._animation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S2_v95+8]");
			((FollowingGuard)null).SetupDogGuardAnimationsStates(animation, (AnimationClip)0);
			Animation animation2 = guardAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S2_v95+C]");
			((HouseKeeper)null).IncrementOwnedOutfits((Characters.CharacterId)animation2, ref *(int*)null);
			Animation animation3 = dogAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S2_v95+10]");
			((HouseKeeper)null).IncrementOwnedOutfits((Characters.CharacterId)animation3, ref *(int*)null);
			obj34 = obj39 + 1;
		}
		object obj40 = caughtRight + 12;
		object obj41 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40))
		{
			CharacterRendering characterRendering3 = this.characterRendering;
			SafeAnimation characterSafeAnimation2 = characterRendering3._characterSafeAnimation;
			object obj42 = caughtRight + 16;
			object obj43 = obj41 << 2;
			object obj44 = obj42 + obj43;
			object obj45 = obj44;
			Animation animation4 = characterSafeAnimation2._animation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S2_v86+8]");
			((FollowingGuard)null).SetupDogGuardAnimationsStates(animation4, (AnimationClip)0);
			Animation animation5 = guardAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S2_v86+C]");
			((HouseKeeper)null).IncrementOwnedOutfits((Characters.CharacterId)animation5, ref *(int*)null);
			Animation animation6 = dogAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S2_v86+10]");
			((HouseKeeper)null).IncrementOwnedOutfits((Characters.CharacterId)animation6, ref *(int*)null);
			object obj46 = obj41 + 1;
			obj41 = obj46;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AnimationClip> list = default;
		list._002Ector();
		int stateCount = guardAnimation.GetStateCount();
		object obj47 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj47 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj48 = obj2 + 4;
		object obj49 = obj48 + 1;
		obj48 = obj49;
		object obj50 = obj49 << 2;
		object obj51 = obj2 + obj50;
		obj51 = 504;
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj53 = default;
		if (obj53 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj54 = (nint)0 << 2;
			object obj55 = obj2 + obj54;
			if ((nint)obj55 == 504)
			{
				object obj56 = obj2 + 4;
				if ((nint)obj56 > -1)
				{
					object obj57 = obj56 + -1;
					obj56 = obj57;
				}
				goto IL_0d90;
			}
		}
		if (obj52 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0d90;
		IL_0dd1:
		DefaultAnimations defaultAnimations = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations2 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations3 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations4 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations5 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations6 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations7 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations8 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations9 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		return;
		IL_0d90:
		DefaultAnimations defaultAnimations10 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations11 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations12 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations13 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations14 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations15 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations16 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		object obj58 = this.defaultAnimations - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations17 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		DefaultAnimations defaultAnimations18 = this.defaultAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8026");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AnimationClip> list2 = default;
		list2._002Ector();
		int stateCount2 = dogAnimation.GetStateCount();
		object obj59 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj59 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj60 = obj2 + 4;
		object obj61 = obj60 + 1;
		obj60 = obj61;
		object obj62 = obj61 << 2;
		object obj63 = obj2 + obj62;
		obj63 = 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj64 = default;
		if (obj64 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj65 = (nint)0 << 2;
			object obj66 = obj2 + obj65;
			if ((nint)obj66 == 824)
			{
				object obj67 = obj2 + 4;
				if ((nint)obj67 > -1)
				{
					object obj68 = obj67 + -1;
					obj67 = obj68;
				}
				goto IL_0dd1;
			}
		}
		if (obj52 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0dd1;
	}

	private unsafe Transform GetChildTransformByName(string name, Transform current)
	{
		//IL_01f1: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_0287: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I4
		string text = (string)0;
		Transform transform = (Transform)0;
		ref bool reference = ref *(bool*)null;
		int[] eventValue = ((CharacterNameEventManager)(object)this).GetEventValue<int[]>(out reference);
		object obj5;
		if (reference)
		{
			object obj = eventValue + 12;
			if ((nint)obj >= 1)
			{
				object obj2 = eventValue + 16;
				text = (string)obj2;
				List<Characters.CharacterId> list = ((CharacterNameEventManager)(object)this).CreateNewCharacterList();
				bool flag = (nint)name > -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v39 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
				bool flag2 = (nint)name < 0;
				object obj3 = flag & flag2;
				if (obj3 == null)
				{
					text = (string)0;
					SDebug.LogFormat("CharacterEventManager - Specified list was negative or does not exist! Reverting to default.", null);
				}
				if ((nint)obj >= 2)
				{
					object obj4 = eventValue + 20;
					transform = (Transform)obj4;
					float num = gravity;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v32 (System.Single)+C]");
					if ((nint)obj4 >= 0 || (nint)current <= -1)
					{
						transform = (Transform)0;
						SDebug.LogFormat("CharacterEventManager - LimitedCharacters list index number was negative or does not exist! Reverting to start.", null);
					}
				}
			}
			obj5 = reference;
			if (reference)
			{
				goto IL_0262;
			}
		}
		if (((CharacterNameEventManager)(object)this).GetEventCategory() != SSEventCategory.None)
		{
			reference = ref *(bool*)1;
			text = (string)0;
			transform = (Transform)0;
			obj5 = 1;
		}
		else
		{
			obj5 = reference;
		}
		goto IL_0262;
		IL_0262:
		object obj6 = obj5 & 0xFF;
		bool flag3 = obj6 != null;
		return (Transform)flag3;
	}

	private void Game_OnCharacterModelRecreated()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00b1: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		object obj = this - -64;
		((PlaceholderLifecycle)obj).Despawn();
		object obj2 = this + 68;
		string text = tag;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		obj2 = obj7;
		object obj8 = this + 76;
		EnemiesRig enemiesData = _enemiesData;
		obj8 = enemiesData._dogAnimation;
		object obj9 = this + 72;
		EnemiesRig enemiesData2 = _enemiesData;
		obj9 = enemiesData2._guardAnimation;
		object obj10 = this + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj11 = default;
		obj10 = obj11;
		GameObject gameObject = dogAnimation.gameObject;
		throw new ArrayTypeMismatchException();
	}

	private void OnSfxSettingChanged()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		object obj = caughtLeft + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			CharacterRendering characterRendering = this.characterRendering;
			SafeAnimation characterSafeAnimation = characterRendering._characterSafeAnimation;
			object obj3 = caughtLeft + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5;
			Animation animation = characterSafeAnimation._animation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v11+8]");
			((FollowingGuard)null).SetupDogGuardAnimationsStates(animation, (AnimationClip)0);
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
		object obj8 = caughtRight + 12;
		object obj9 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			CharacterRendering characterRendering2 = this.characterRendering;
			SafeAnimation characterSafeAnimation2 = characterRendering2._characterSafeAnimation;
			object obj10 = caughtRight + 16;
			object obj11 = obj9 << 2;
			object obj12 = obj10 + obj11;
			object obj13 = obj12;
			Animation animation2 = characterSafeAnimation2._animation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v6+8]");
			((FollowingGuard)null).SetupDogGuardAnimationsStates(animation2, (AnimationClip)0);
			object obj14 = obj9 + 1;
			obj9 = obj14;
		}
	}

	private void InitializeClips(Animation animationComponent, List<AnimationClip> addedClips, AnimationClip[] clips)
	{
		Animation empty = (Animation)(object)string.Empty;
		List<AnimationClip> empty2 = (List<AnimationClip>)(object)string.Empty;
		AnimationClip[] empty3 = (AnimationClip[])(object)string.Empty;
		SDebug.LogFormat("The Super Mystery Box Event does not contain information for a ribbon description", null);
	}

	private void SetupAvatarAnimationsStates(Animation animation, AnimationClip animationClip)
	{
		//IL_1f52: Expected Obj, but got I4
		//IL_001c: Expected I4, but got Obj
		//IL_1f8f: Expected I, but got Obj
		//IL_1fa5: Expected Obj, but got I
		//IL_000e: Expected I4, but got Obj
		//IL_002f: Expected I, but got Obj
		//IL_1279: Unknown result type (might be due to invalid IL or missing references)
		//IL_127e: Expected Obj, but got Unknown
		//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dd: Expected Obj, but got Unknown
		//IL_109a: Unknown result type (might be due to invalid IL or missing references)
		//IL_109f: Expected Obj, but got Unknown
		//IL_123b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1240: Expected Obj, but got Unknown
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Expected Obj, but got Unknown
		//IL_0fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd3: Expected Obj, but got Unknown
		//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2f: Expected Obj, but got Unknown
		//IL_0eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Expected Obj, but got Unknown
		//IL_0dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Expected Obj, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected Obj, but got Unknown
		//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected Obj, but got Unknown
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected Obj, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected Obj, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected Obj, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_0f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f95: Expected Obj, but got Unknown
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb3: Expected Obj, but got Unknown
		//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d87: Expected Obj, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected Obj, but got Unknown
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c17: Expected Obj, but got Unknown
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected Obj, but got Unknown
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected Obj, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected Obj, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected Obj, but got Unknown
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected Obj, but got Unknown
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected Obj, but got Unknown
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected Obj, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_2042: Unknown result type (might be due to invalid IL or missing references)
		//IL_2047: Expected Obj, but got Unknown
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd9: Expected Obj, but got Unknown
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected Obj, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_22d5: Expected Obj, but got I4
		//IL_1ca8: Expected I, but got Obj
		//IL_1cbe: Expected Obj, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_2401: Expected Obj, but got I4
		//IL_2233: Expected Obj, but got I4
		//IL_2307: Expected Obj, but got I4
		//IL_2339: Expected Obj, but got I4
		//IL_23cf: Expected Obj, but got I4
		//IL_239d: Expected Obj, but got I4
		//IL_22a3: Expected Obj, but got I4
		//IL_1309: Expected Obj, but got I4
		//IL_166a: Expected I, but got Obj
		//IL_1680: Expected Obj, but got I
		//IL_1420: Expected Obj, but got I4
		//IL_1ddc: Expected I, but got Obj
		//IL_1df2: Expected Obj, but got I
		//IL_1ce9: Expected I, but got Obj
		//IL_236b: Expected Obj, but got I4
		//IL_1c34: Expected I, but got Obj
		//IL_1c4a: Expected Obj, but got I
		//IL_11a4: Expected I, but got Obj
		//IL_11ba: Expected Obj, but got I
		//IL_1761: Expected I, but got Obj
		//IL_1777: Expected Obj, but got I
		//IL_1858: Expected I, but got Obj
		//IL_186e: Expected Obj, but got I
		//IL_1b3d: Expected I, but got Obj
		//IL_1b53: Expected Obj, but got I
		//IL_2453: Expected Obj, but got I4
		//IL_1a46: Expected I, but got Obj
		//IL_1a5c: Expected Obj, but got I
		//IL_1573: Expected I, but got Obj
		//IL_1589: Expected Obj, but got I
		//IL_05d1: Expected Obj, but got I4
		//IL_2078: Expected Obj, but got I4
		//IL_1365: Expected I, but got Obj
		//IL_137b: Expected Obj, but got I
		//IL_16ab: Expected I, but got Obj
		//IL_147c: Expected I, but got Obj
		//IL_1492: Expected Obj, but got I
		//IL_1e1d: Expected I, but got Obj
		//IL_1d50: Expected Obj, but got I4
		//IL_1d68: Expected I, but got Obj
		//IL_1d7e: Expected Obj, but got I
		//IL_194f: Expected I, but got Obj
		//IL_1965: Expected Obj, but got I
		//IL_1c75: Expected I, but got Obj
		//IL_11e5: Expected I, but got Obj
		//IL_17a2: Expected I, but got Obj
		//IL_1899: Expected I, but got Obj
		//IL_1b7e: Expected I, but got Obj
		//IL_1a87: Expected I, but got Obj
		//IL_15b4: Expected I, but got Obj
		//IL_062d: Expected I, but got Obj
		//IL_0643: Expected Obj, but got I
		//IL_0422: Expected I, but got Obj
		//IL_0438: Expected Obj, but got I
		//IL_13a6: Expected I, but got Obj
		//IL_14bd: Expected I, but got Obj
		//IL_1da9: Expected I, but got Obj
		//IL_1990: Expected I, but got Obj
		//IL_1ec5: Expected Obj, but got I4
		//IL_066e: Expected I, but got Obj
		//IL_0463: Expected I, but got Obj
		//IL_1ee2: Expected I, but got Obj
		//IL_1ef8: Expected Obj, but got I
		//IL_1f23: Expected I, but got Obj
		object obj = 0;
		int totalLength = (((object)animationClip == null) ? ((int)string.Empty) : ((int)" VALIDATED"));
		string text = string.ConcatArray((string[])(object)"InApp purchase completed", totalLength);
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v628 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C9E1");
		object obj3 = default;
		if ((nint)obj3 < -1179232015)
		{
			if ((nint)obj3 < 1570903698)
			{
				if ((nint)obj3 >= 288810086)
				{
					if ((nint)obj3 < 1089833458)
					{
						if ((nint)obj3 >= 1089833457)
						{
							object obj4 = obj3 - 1089833457;
							if (obj4 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier2specialdiscount"))
							{
								return;
							}
							goto IL_19b5;
						}
						object obj5 = obj3 - 433439728;
						if (obj5 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier3specialdiscount"))
						{
							return;
						}
					}
					else
					{
						if ((nint)obj3 >= 1474107074)
						{
							if ((nint)obj3 < 1570903697)
							{
								object obj6 = obj3 - 1474107074;
								if (obj6 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier1specialdiscount"))
								{
									return;
								}
								goto IL_17c7;
							}
							object obj7 = obj3 - 1570903697;
							if (obj7 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier2.5discount"))
							{
								return;
							}
							goto IL_201c;
						}
						object obj8 = obj3 - 1102479207;
						if (obj8 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier3discount"))
						{
							return;
						}
					}
					goto IL_1aac;
				}
				if ((nint)obj3 < 26209296)
				{
					bool flag2;
					if ((nint)obj3 < 26209295)
					{
						object obj9 = obj3 - 9431676;
						if (obj9 != null || !((string)(object)this != "com.kiloo.subwaysurfers.bundletier3"))
						{
							return;
						}
						bool flag = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
						string text2 = string.ConcatArray((string[])(object)"InApp Bundle 3 purchased", totalLength);
						flag2 = flag;
					}
					else
					{
						object obj10 = obj3 - 26209295;
						if (obj10 != null || !((string)(object)this != "com.kiloo.subwaysurfers.bundletier2"))
						{
							return;
						}
						bool flag3 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
						string text3 = string.ConcatArray((string[])(object)"InApp Bundle 2 purchased", totalLength);
						flag2 = flag3;
					}
					int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
					obj = currentSkipForVideoMissionIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					if (!flag2)
					{
						string text4 = default;
						object obj11 = ((IConvertible)text4).ToType((Type)(object)";", (IFormatProvider)(object)animation);
					}
					nint num3 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1133 @ S0_v527 (Il2CppClass<Flurry>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num4 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ S0_v531 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return;
				}
				if ((nint)obj3 < 163161875)
				{
					object obj13 = obj3 - 42986914;
					if (obj13 != null || !((string)(object)this != "com.kiloo.subwaysurfers.bundletier1"))
					{
						return;
					}
					bool flag4 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
					string text5 = string.ConcatArray((string[])(object)"InApp Bundle 1 purchased", totalLength);
					int currentSkipForVideoMissionIndex2 = PlayerSave.currentSkipForVideoMissionIndex;
					obj = currentSkipForVideoMissionIndex2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					if (!flag4)
					{
						string text6 = default;
						object obj14 = ((IConvertible)text6).ToType((Type)(object)";", (IFormatProvider)(object)animation);
					}
					nint num5 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ S0_v576 (Il2CppClass<Flurry>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num6 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ S0_v580 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return;
				}
				if ((nint)obj3 < 288810085)
				{
					object obj16 = obj3 - 163161875;
					if (obj16 != null || !((string)(object)this != "com.kiloo.subwaysurfers.doublecoinsdiscount"))
					{
						return;
					}
					goto IL_1c9a;
				}
				object obj17 = obj3 - 288810085;
				if (obj17 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier1.5specialdiscount"))
				{
					return;
				}
			}
			else
			{
				if ((nint)obj3 >= -1613189323)
				{
					if ((nint)obj3 < -1337614090)
					{
						if ((nint)obj3 >= -1337614091)
						{
							object obj18 = obj3 - -1337614091;
							if (obj18 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier5discount"))
							{
								return;
							}
							goto IL_16d0;
						}
						object obj19 = obj3 - -1573699914;
						if (obj19 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier2.5"))
						{
							return;
						}
					}
					else
					{
						if ((nint)obj3 < -1181669954)
						{
							object obj20 = obj3 - -1213681411;
							if (obj20 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier2specialdiscount"))
							{
								return;
							}
							goto IL_14e2;
						}
						if ((nint)obj3 >= -1179232016)
						{
							object obj21 = obj3 - -1179232016;
							if (obj21 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier2discount"))
							{
								return;
							}
							goto IL_19b5;
						}
						object obj22 = obj3 - -1181669954;
						if (obj22 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier2.5specialdiscount"))
						{
							return;
						}
					}
					goto IL_201c;
				}
				if ((nint)obj3 < 1943857004)
				{
					if ((nint)obj3 < 1943857003)
					{
						object obj23 = obj3 - 1714815570;
						if (obj23 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier4discount"))
						{
							return;
						}
						goto IL_1ba3;
					}
					object obj24 = obj3 - 1943857003;
					if (obj24 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier4specialdiscount"))
					{
						return;
					}
					goto IL_15d9;
				}
				if ((nint)obj3 < 2033740426)
				{
					object obj25 = obj3 - -1613189324;
					if (obj25 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier2discount"))
					{
						return;
					}
					goto IL_14e2;
				}
				if ((nint)obj3 < 2084453403)
				{
					object obj26 = obj3 - 2033740426;
					if (obj26 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier5specialdiscount"))
					{
						return;
					}
					goto IL_16d0;
				}
				object obj27 = obj3 - 2084453403;
				if (obj27 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier1.5"))
				{
					return;
				}
			}
			goto IL_18be;
		}
		bool flag6;
		if ((nint)obj3 < -182235519)
		{
			if ((nint)obj3 < -487227105)
			{
				if ((nint)obj3 >= -891774116)
				{
					if ((nint)obj3 < -600076276)
					{
						object obj28 = obj3 - -761690488;
						if (obj28 != null || !((string)(object)this != "com.kiloo.subwaysurfers.doublecoins"))
						{
							return;
						}
						goto IL_1c9a;
					}
					if ((nint)obj3 < -487227106)
					{
						object obj29 = obj3 - -600076276;
						if (obj29 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier1.5discount"))
						{
							return;
						}
						goto IL_18be;
					}
					object obj30 = obj3 - -487227106;
					if (obj30 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier4discount"))
					{
						return;
					}
					goto IL_15d9;
				}
				if ((nint)obj3 < -891774117)
				{
					object obj31 = obj3 - -1069562201;
					if (obj31 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier4specialdiscount"))
					{
						return;
					}
					goto IL_1ba3;
				}
				object obj32 = obj3 - -891774117;
				if (obj32 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier3discount"))
				{
					return;
				}
			}
			else
			{
				if ((nint)obj3 < -481812881)
				{
					if ((nint)obj3 < -481812882)
					{
						object obj33 = obj3 - -483609119;
						if (obj33 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier1discount"))
						{
							return;
						}
					}
					else
					{
						object obj34 = obj3 - -481812882;
						if (obj34 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier1specialdiscount"))
						{
							return;
						}
					}
					goto IL_13cb;
				}
				if ((nint)obj3 < -261527412)
				{
					object obj35 = obj3 - -269614755;
					if (obj35 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier1discount"))
					{
						return;
					}
					goto IL_17c7;
				}
				if ((nint)obj3 < -182235520)
				{
					object obj36 = obj3 - -261527412;
					if (obj36 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier3specialdiscount"))
					{
						return;
					}
				}
				else
				{
					object obj37 = obj3 - -182235520;
					if (obj37 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier3"))
					{
						return;
					}
				}
			}
			bool flag5 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
			string text7 = string.ConcatArray((string[])(object)"InApp Coin Pack 3 purchased", totalLength);
			flag6 = flag5;
		}
		else
		{
			if ((nint)obj3 < -89710261)
			{
				if ((nint)obj3 < -148680281)
				{
					if ((nint)obj3 < -148680282)
					{
						object obj38 = obj3 - -165457901;
						if (obj38 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier2"))
						{
							return;
						}
						goto IL_14e2;
					}
					object obj39 = obj3 - -148680282;
					if (obj39 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier1"))
					{
						return;
					}
					goto IL_13cb;
				}
				if ((nint)obj3 < -106487881)
				{
					object obj40 = obj3 - -123265500;
					if (obj40 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier3"))
					{
						return;
					}
					goto IL_1aac;
				}
				if ((nint)obj3 < -89710262)
				{
					object obj41 = obj3 - -106487881;
					if (obj41 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier2"))
					{
						return;
					}
					goto IL_19b5;
				}
				object obj42 = obj3 - -89710262;
				if (obj42 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier1"))
				{
					return;
				}
				goto IL_17c7;
			}
			if ((nint)obj3 < -64792186)
			{
				if ((nint)obj3 < -64792187)
				{
					object obj43 = obj3 - -81569806;
					if (obj43 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier5"))
					{
						return;
					}
					goto IL_16d0;
				}
				object obj44 = obj3 - -64792187;
				if (obj44 != null || !((string)(object)this != "com.kiloo.subwaysurfers.coinstier4"))
				{
					return;
				}
				goto IL_15d9;
			}
			if ((nint)obj3 < -22587972)
			{
				object obj45 = obj3 - -24123562;
				if (obj45 != null || !((string)(object)this != "com.kiloo.subwaysurfers.bundletier5"))
				{
					return;
				}
				bool flag7 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
				string text8 = string.ConcatArray((string[])(object)"InApp Bundle 5 purchased", totalLength);
				int currentSkipForVideoMissionIndex3 = PlayerSave.currentSkipForVideoMissionIndex;
				obj = currentSkipForVideoMissionIndex3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				if (!flag7)
				{
					string text9 = default;
					object obj46 = ((IConvertible)text9).ToType((Type)(object)";", (IFormatProvider)(object)animation);
				}
				nint num7 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ S0_v318 (Il2CppClass<Flurry>)+BA]");
				object obj47 = (nint)0 & (nint)0x200;
				if (obj47 != null)
				{
					nint num8 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ S0_v322 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return;
			}
			if ((nint)obj3 < -7345943)
			{
				object obj48 = obj3 - -22587972;
				if (obj48 != null || !((string)(object)this != "com.kiloo.subwaysurfers.keystier_4"))
				{
					return;
				}
				goto IL_1ba3;
			}
			object obj49 = obj3 - -7345943;
			if (obj49 != null || !((string)(object)this != "com.kiloo.subwaysurfers.bundletier4"))
			{
				return;
			}
			bool flag8 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
			string text10 = string.ConcatArray((string[])(object)"InApp Bundle 4 purchased", totalLength);
			flag6 = flag8;
		}
		int currentSkipForVideoMissionIndex4 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag6)
		{
			string text11 = default;
			object obj50 = ((IConvertible)text11).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num9 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ S0_v273 (Il2CppClass<Flurry>)+BA]");
		object obj51 = (nint)0 & (nint)0x200;
		if (obj51 != null)
		{
			nint num10 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S0_v277 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_1c9a:
		nint num11 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S0_v24 (Il2CppClass<UIScreenController>)+BA]");
		object obj52 = (nint)0 & (nint)0x200;
		if (obj52 != null)
		{
			nint num12 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ S0_v80 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController == null)
		{
			string text12 = string.ConcatArray((string[])(object)"Double Coin purchased", totalLength);
			int currentSkipForVideoMissionIndex5 = PlayerSave.currentSkipForVideoMissionIndex;
			obj = currentSkipForVideoMissionIndex5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			nint num13 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ S0_v73 (Il2CppClass<Flurry>)+BA]");
			object obj53 = (nint)0 & (nint)0x200;
			if (obj53 != null)
			{
				nint num14 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ S0_v77 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return;
		}
		nint num15 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
		object obj54 = (nint)0 & (nint)0x200;
		if (obj54 != null)
		{
			nint num16 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ S0_v62 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag9 = UIScreenController.ShouldShowOnlineScreen();
		bool flag10;
		if (((UIScreenController)flag9).isShowingPopup)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ S0_v38 (System.Boolean)+8]");
			flag10 = (nint)0 == 0;
		}
		else
		{
			flag10 = true;
		}
		if (flag10)
		{
			string text13 = string.ConcatArray((string[])(object)"Double Coin purchased", totalLength);
		}
		else
		{
			string text14 = string.ConcatArray((string[])(object)"Double Coin purchased GameOver", totalLength);
		}
		int currentSkipForVideoMissionIndex6 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num17 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ S0_v45 (Il2CppClass<Flurry>)+BA]");
		object obj55 = (nint)0 & (nint)0x200;
		if (obj55 != null)
		{
			nint num18 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1293 @ S0_v49 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_13cb:
		bool flag11 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text15 = string.ConcatArray((string[])(object)"InApp Coin Pack 1 purchased", totalLength);
		bool flag12 = flag11;
		goto IL_140f;
		IL_140f:
		int currentSkipForVideoMissionIndex7 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag12)
		{
			string text16 = default;
			object obj56 = ((IConvertible)text16).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num19 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ S0_v244 (Il2CppClass<Flurry>)+BA]");
		object obj57 = (nint)0 & (nint)0x200;
		if (obj57 != null)
		{
			nint num20 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1265 @ S0_v248 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_1ba3:
		bool flag13 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text17 = string.ConcatArray((string[])(object)"InApp Key Pack 4 purchased", totalLength);
		int currentSkipForVideoMissionIndex8 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag13)
		{
			string text18 = default;
			object obj58 = ((IConvertible)text18).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num21 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ S0_v90 (Il2CppClass<Flurry>)+BA]");
		object obj59 = (nint)0 & (nint)0x200;
		if (obj59 != null)
		{
			nint num22 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ S0_v94 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_17c7:
		bool flag14 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text19 = string.ConcatArray((string[])(object)"InApp Key Pack 1 purchased", totalLength);
		int currentSkipForVideoMissionIndex9 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag14)
		{
			string text20 = default;
			object obj60 = ((IConvertible)text20).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num23 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ S0_v166 (Il2CppClass<Flurry>)+BA]");
		object obj61 = (nint)0 & (nint)0x200;
		if (obj61 != null)
		{
			nint num24 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ S0_v170 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_1aac:
		bool flag15 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text21 = string.ConcatArray((string[])(object)"InApp Key Pack 3 purchased", totalLength);
		int currentSkipForVideoMissionIndex10 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag15)
		{
			string text22 = default;
			object obj62 = ((IConvertible)text22).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num25 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ S0_v109 (Il2CppClass<Flurry>)+BA]");
		object obj63 = (nint)0 & (nint)0x200;
		if (obj63 != null)
		{
			nint num26 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ S0_v113 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_16d0:
		bool flag16 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text23 = string.ConcatArray((string[])(object)"InApp Coin Pack 5 purchased", totalLength);
		int currentSkipForVideoMissionIndex11 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag16)
		{
			string text24 = default;
			object obj64 = ((IConvertible)text24).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num27 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ S0_v185 (Il2CppClass<Flurry>)+BA]");
		object obj65 = (nint)0 & (nint)0x200;
		if (obj65 != null)
		{
			nint num28 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ S0_v189 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_18be:
		bool flag17 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text25 = string.ConcatArray((string[])(object)"InApp Key Pack 1.5 purchased", totalLength);
		int currentSkipForVideoMissionIndex12 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag17)
		{
			string text26 = default;
			object obj66 = ((IConvertible)text26).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num29 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1239 @ S0_v147 (Il2CppClass<Flurry>)+BA]");
		object obj67 = (nint)0 & (nint)0x200;
		if (obj67 != null)
		{
			nint num30 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ S0_v151 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_201c:
		bool flag18 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text27 = string.ConcatArray((string[])(object)"InApp Coin Pack 2.5 purchased", totalLength);
		flag12 = flag18;
		goto IL_140f;
		IL_19b5:
		bool flag19 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text28 = string.ConcatArray((string[])(object)"InApp Key Pack 2 purchased", totalLength);
		int currentSkipForVideoMissionIndex13 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag19)
		{
			string text29 = default;
			object obj68 = ((IConvertible)text29).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num31 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ S0_v128 (Il2CppClass<Flurry>)+BA]");
		object obj69 = (nint)0 & (nint)0x200;
		if (obj69 != null)
		{
			nint num32 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ S0_v132 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_15d9:
		bool flag20 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text30 = string.ConcatArray((string[])(object)"InApp Coin Pack 4 purchased", totalLength);
		int currentSkipForVideoMissionIndex14 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag20)
		{
			string text31 = default;
			object obj70 = ((IConvertible)text31).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num33 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ S0_v204 (Il2CppClass<Flurry>)+BA]");
		object obj71 = (nint)0 & (nint)0x200;
		if (obj71 != null)
		{
			nint num34 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ S0_v208 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_14e2:
		bool flag21 = (object)animation == null || ((UnityEngine.Object)animation).m_CachedPtr == (IntPtr)0;
		string text32 = string.ConcatArray((string[])(object)"InApp Coin Pack 2 purchased", totalLength);
		int currentSkipForVideoMissionIndex15 = PlayerSave.currentSkipForVideoMissionIndex;
		obj = currentSkipForVideoMissionIndex15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		if (!flag21)
		{
			string text33 = default;
			object obj72 = ((IConvertible)text33).ToType((Type)(object)";", (IFormatProvider)(object)animation);
		}
		nint num35 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ S0_v223 (Il2CppClass<Flurry>)+BA]");
		object obj73 = (nint)0 & (nint)0x200;
		if (obj73 != null)
		{
			nint num36 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ S0_v227 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void SetupDogGuardAnimationsStates(Animation animation, AnimationClip animationClip)
	{
		//IL_00f7: Expected VT, but got Obj
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		//IL_008f: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00a6: Expected Obj, but got I4
		//IL_0070: Expected I4, but got Obj
		//IL_00c5: Expected I4, but got Obj
		//IL_00d7: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)animationClip);
		CollisionFlags collisionFlags = ((CharacterController)(object)animation).Move((Vector3)obj);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)collisionFlags != null)
		{
			UnityEngine.Object obj3 = UnityEngine.Object.Instantiate((UnityEngine.Object)animationClip);
			((AnimationState)(object)animation).AddMixingTransform((Transform)(object)animationClip, (byte)(int)obj3 != 0);
		}
		UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)animationClip);
		bool flag = animation.Play((PlayMode)obj4);
		((AnimationState)flag).wrapMode = WrapMode.Default;
		UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)animationClip);
		bool flag2 = animation.Play((PlayMode)obj5);
		((AnimationState)flag2).AddMixingTransform((Transform)4);
	}

	private void HandleOnPauseChange(bool pause)
	{
	}

	public void ResetModelRootPosition()
	{
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool musicEnabled = PreferencesSave.musicEnabled;
		AudioSource component = GetComponent<AudioSource>();
		if (musicEnabled)
		{
			component.pitch = guardProximityLoopVolume;
		}
		else
		{
			component.pitch = 0f;
		}
	}

	public void Restart(bool closeToCharacter)
	{
		if (closeToCharacter)
		{
			AudioSource component = GetComponent<AudioSource>();
			if (component.loop)
			{
				AudioSource component2 = GetComponent<AudioSource>();
				component2.UnPause();
			}
		}
	}

	public unsafe void OnEnable()
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected VT, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected VT, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got F4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_018f: Expected F4, but got Obj
		//IL_018a: Expected native int or pointer, but got VT
		//IL_01a4: Expected F4, but got I
		//IL_019f: Expected native int or pointer, but got VT
		//IL_01b1: Expected F4, but got Obj
		//IL_01ac: Expected native int or pointer, but got VT
		//IL_01c6: Expected F4, but got I
		//IL_01c1: Expected native int or pointer, but got VT
		//IL_01e4: Expected F4, but got Obj
		//IL_01df: Expected native int or pointer, but got VT
		//IL_01f9: Expected F4, but got I
		//IL_01f4: Expected native int or pointer, but got VT
		//IL_0202: Expected Obj, but got VT
		//IL_0214: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I
		//IL_025f: Expected Obj, but got VT
		//IL_026c: Expected native int or pointer, but got VT
		//IL_027e: Expected native int or pointer, but got VT
		//IL_028c: Expected Obj, but got VT
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_00b8: Expected I, but got Obj
		//IL_0105: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 56);
		Vector3 vector2 = (Vector3)(obj + 40);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		object obj4 = default;
		object obj10 = default;
		while (true)
		{
			Transform[] array = enemies;
			if ((nint)obj4 >= array.Length)
			{
				break;
			}
			object obj5 = enemiesStartPos + 16;
			object obj6 = obj4 * 12;
			object obj7 = obj5 + obj6;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S2_v6+8]");
			_ = 0;
			obj3 = 0;
			_ = 0;
			obj3 = 0f;
			_ = 0f;
			_ = 8f;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v22 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v51 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Vector3 vector3 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector4 = vector2 - vector;
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 eulerAngles = ((Transform)vector).eulerAngles;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v38 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v47 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Transform)vector2).Rotate(0f, 0f, 0f);
			((Vector3*)(nint)vector)->x = vector2.x;
			((Vector3*)(nint)vector)->z = vector2.z;
			Quaternion localRotation = ((Transform)vector).localRotation;
			obj4 = obj10 + 1;
		}
	}

	public unsafe void OnDisable()
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0169: Expected F4, but got Obj
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		Character character = this.character;
		lastGroundedSmooth = character.LastGroundedY;
		lastGroundedVelocity = 0f;
		Character character2 = this.character;
		y = character2.LastGroundedY;
		SmoothDampFloat smoothDampFloat = x;
		object obj = this.character + 248;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+8]");
		_ = 0;
		smoothDampFloat._value = (float)obj2;
		distanceToCharacter = distanceToCharacterMin;
		closeToCharacter = true;
		verticalSpeed = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnJumpDelegate onJumpDelegate = default;
		((Delegate)onJumpDelegate).method_ptr = method_ptr;
		((Delegate)onJumpDelegate).method = (nint)__ldftn(FollowingGuard.OnJump);
		object obj3 = onJumpDelegate + 16;
		obj3 = this;
		this.character.OnJump -= onJumpDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Character.OnRollGuardDelegate onRollGuardDelegate = default;
		((Delegate)onRollGuardDelegate).method_ptr = method_ptr2;
		((Delegate)onRollGuardDelegate).method = (nint)__ldftn(FollowingGuard.OnRoll);
		object obj4 = onRollGuardDelegate + 16;
		obj4 = this;
		this.character.OnRollGuard -= onRollGuardDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Character.OnRollDelegate onRollDelegate = default;
		((Delegate)onRollDelegate).method_ptr = method_ptr3;
		((Delegate)onRollDelegate).method = (nint)__ldftn(FollowingGuard.OnRollNoAnimation);
		object obj5 = onRollDelegate + 16;
		obj5 = this;
		this.character.OnRoll -= onRollDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
		((Delegate)onChangeTrackDelegate).method_ptr = method_ptr4;
		((Delegate)onChangeTrackDelegate).method = (nint)__ldftn(FollowingGuard.OnChangeTrack);
		object obj6 = onChangeTrackDelegate + 16;
		obj6 = this;
		this.character.OnChangeTrack -= onChangeTrackDelegate;
	}

	public unsafe void CatchUp()
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnDoubleJumpDelegate onDoubleJumpDelegate = default;
		((Delegate)onDoubleJumpDelegate).method_ptr = method_ptr;
		((Delegate)onDoubleJumpDelegate).method = (nint)__ldftn(FollowingGuard.OnJump);
		object obj = onDoubleJumpDelegate + 16;
		obj = this;
		character.OnDoubleJump += onDoubleJumpDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Character.OnHitByTrainDelegate onHitByTrainDelegate = default;
		((Delegate)onHitByTrainDelegate).method_ptr = method_ptr2;
		((Delegate)onHitByTrainDelegate).method = (nint)__ldftn(FollowingGuard.OnRoll);
		object obj2 = onHitByTrainDelegate + 16;
		obj2 = this;
		character.OnHitByTrain += onHitByTrainDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Character.OnRollGuardDelegate onRollGuardDelegate = default;
		((Delegate)onRollGuardDelegate).method_ptr = method_ptr3;
		((Delegate)onRollGuardDelegate).method = (nint)__ldftn(FollowingGuard.OnRollNoAnimation);
		object obj3 = onRollGuardDelegate + 16;
		obj3 = this;
		character.OnRollGuard += onRollGuardDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
		((Delegate)onChangeTrackDelegate).method_ptr = method_ptr4;
		((Delegate)onChangeTrackDelegate).method = (nint)__ldftn(FollowingGuard.OnChangeTrack);
		object obj4 = onChangeTrackDelegate + 16;
		obj4 = this;
		character.OnChangeTrack -= onChangeTrackDelegate;
	}

	public void CatchUp(float duration)
	{
		if (duration == 1f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FollowingGuard)+B5]");
			if ((nint)0 != 0)
			{
				((HoverboardModelPreviewFactory)this).OpenGlider();
			}
		}
	}

	public void ResetCatchUp()
	{
		ResetCatchUp(catchUpDuration);
	}

	public void ResetCatchUp(float duration)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0097: Expected I4, but got Obj
		//IL_00d4: Expected I4, but got Obj
		//IL_00ea: Expected Obj, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		if (~(closeToCharacter ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 12;
			obj = this;
			_ = distanceToCharacter;
			((HouseKeeper)this).OnAppHasRefreshed(RefreshType.UI);
			MonoBehaviour.print(this);
			DefaultAnimations defaultAnimations = this.defaultAnimations;
			string text = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations.catchupGuard, 0);
			object animation = text + 16;
			AnimationState animationState = guardAnimation.CrossFadeQueued((string)animation);
			bool flag = guardAnimation.PlayDefaultAnimation((PlayMode)"Guard_Run");
			AudioSource component = GetComponent<AudioSource>();
			AudioSource component2 = GetComponent<AudioSource>();
			AudioClip clip = component2.clip;
			int num = UnityEngine.Random.RandomRangeInt(0, (int)clip);
			component.clip = (AudioClip)num;
			AudioSource component3 = GetComponent<AudioSource>();
			component3.Stop();
			AudioSource component4 = GetComponent<AudioSource>();
			float time = ScrollRect.RubberDelta(0.9f, 1.05f);
			component4.time = time;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num2 = 0;
			_ = 0;
			object obj4 = default;
			object obj3 = obj4 + 16;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
			IEnumerator routine = default;
			Coroutine coroutine = StartCoroutine_Auto(routine);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			object obj6 = default;
			object obj5 = obj6 + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
			IEnumerator routine2 = default;
			Coroutine coroutine2 = StartCoroutine_Auto(routine2);
			closeToCharacter = true;
		}
	}

	public IEnumerator ResetCatchUpCoroutine(float duration)
	{
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0101: Expected VT, but got Obj
		//IL_0130: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)this).FindKernel((string)null) != 0)
		{
			GameObject gameObject = base.gameObject;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)gameObject).FindKernel((string)null) != 0)
			{
				GameObject gameObject2 = base.gameObject;
				Transform transform = default;
				transform.position = (Vector3)gameObject2;
				float z = duration - (float)(nint)((UnityEngine.Object)transform).m_CachedPtr;
				bool flag = ((CurveParent)this).HasTimeForWorldZ(z);
				return (IEnumerator)flag;
			}
			return null;
		}
		return null;
	}

	public void MuteProximityLoop()
	{
		Jump(resetCatchUpDuration);
	}

	public void PlayIntro()
	{
		AudioSource component = GetComponent<AudioSource>();
		component.Pause();
	}

	private string[] ReturnRandomAnimations(AnimationClip[] guardAnimations, AnimationClip[] dogAnimations)
	{
		//IL_0065: Expected Obj, but got I4
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_00bd: Expected I, but got Obj
		AnimationClip[] array = default;
		UnityEngine.Object a = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)array);
		if (!string.Equals((string)(object)a, (string)(object)guardAnimations))
		{
			Sprite sprite = default;
			string[] array2;
			Sprite sprite2 = default;
			while (true)
			{
				int siblingIndex = ((Transform)(object)array).GetSiblingIndex();
				if ((nint)sprite >= siblingIndex)
				{
					return null;
				}
				bool flag = ((SpriteAtlas)(object)array).CanBindTo(sprite);
				array2 = ReturnRandomAnimations(guardAnimations, (AnimationClip[])flag);
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)array2).FindKernel((string)null) != 0)
				{
					break;
				}
				sprite = (Sprite)(sprite2 + 1);
			}
			return array2;
		}
		return (string[])(object)array;
	}

	private void OnChangeTrack(Character.OnChangeTrackDirection direction)
	{
		MonoBehaviour.print(this);
		bool flag = (byte)(direction & Character.OnChangeTrackDirection.Right) != 0;
		closeToCharacter = flag;
		float num = ((direction == Character.OnChangeTrackDirection.Left) ? distanceToCharacterMax : distanceToCharacterMin);
		distanceToCharacter = num;
	}

	private void OnRoll()
	{
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got F4
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_0137: Expected I4, but got Obj
		//IL_0137: Expected I4, but got Obj
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0158: Expected I4, but got Obj
		//IL_016f: Expected Obj, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01b2: Expected I4, but got Obj
		//IL_01c4: Expected Obj, but got I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0216: Expected I4, but got Obj
		//IL_0216: Expected I4, but got Obj
		//IL_00cc: Expected I, but got Obj
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0241: Expected VT, but got Obj
		//IL_0241: Expected VT, but got Obj
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0267: Expected VT, but got Obj
		//IL_0267: Expected VT, but got Obj
		string text = tag;
		int layer = ((GameObject)(object)text).layer;
		Transform transform = default;
		object obj = transform + 16;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0f;
		_ = -10f;
		Transform transform2 = (Transform)(transform + 32);
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform2.localPosition;
		object obj2 = 0;
		while (true)
		{
			Transform[] array = enemies;
			if ((nint)obj2 >= array.Length)
			{
				break;
			}
			object obj3 = enemiesStartPos + 16;
			object obj4 = obj2 * 12;
			object obj5 = obj3 + obj4;
			obj = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S2_v38+8]");
			_ = 0;
			transform2 = (Transform)obj;
			Transform transform4 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition2 = transform2.localPosition;
			nint num = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v57 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v66 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform.Rotate(0f, 0f, 0f);
			transform2 = transform;
			((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
			Quaternion localRotation = transform2.localRotation;
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
		DefaultAnimations defaultAnimations = this.defaultAnimations;
		DefaultAnimations defaultAnimations2 = this.defaultAnimations;
		string text2 = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations.introGuard, (int)defaultAnimations2.introDog);
		object obj8 = text2 + 16;
		bool flag = guardAnimation.Play((PlayMode)obj8);
		((AnimationState)flag).normalizedTime = 0f;
		object animation = text2 + 16;
		AnimationState animationState = guardAnimation.CrossFadeQueued((string)animation);
		object obj9 = text2 + 20;
		bool flag2 = dogAnimation.Play((PlayMode)obj9);
		((AnimationState)flag2).normalizedTime = 0f;
		object animation2 = text2 + 20;
		AnimationState animationState2 = dogAnimation.CrossFadeQueued((string)animation2);
		DefaultAnimations defaultAnimations3 = this.defaultAnimations;
		DefaultAnimations defaultAnimations4 = this.defaultAnimations;
		string text3 = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations3.runGuard, (int)defaultAnimations4.runDog);
		object obj10 = text3 + 16;
		bool flag3 = Physics.Raycast((Vector3)guardAnimation, (Vector3)obj10, 0.2f);
		object obj11 = text3 + 20;
		bool flag4 = Physics.Raycast((Vector3)dogAnimation, (Vector3)obj11, 0.2f);
	}

	private void OnRollNoAnimation()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002d: Expected I4, but got Obj
		//IL_002d: Expected I4, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_00a6: Expected I4, but got Obj
		//IL_00a6: Expected I4, but got Obj
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00d1: Expected VT, but got Obj
		//IL_00d1: Expected VT, but got Obj
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f7: Expected VT, but got Obj
		//IL_00f7: Expected VT, but got Obj
		object obj = this.defaultAnimations - -64;
		DefaultAnimations defaultAnimations = this.defaultAnimations;
		string text = ((HouseKeeper)null).RoundUpToTargetValue((int)obj, (int)defaultAnimations.rollDog);
		object clip = text + 16;
		AudioSource.PlayOneShotHelper((AudioSource)(object)guardAnimation, (AudioClip)clip, 0.1f);
		object clip2 = text + 20;
		AudioSource.PlayOneShotHelper((AudioSource)(object)dogAnimation, (AudioClip)clip2, 0.1f);
		DefaultAnimations defaultAnimations2 = this.defaultAnimations;
		DefaultAnimations defaultAnimations3 = this.defaultAnimations;
		string text2 = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations2.runGuard, (int)defaultAnimations3.runDog);
		object obj2 = text2 + 16;
		bool flag = Physics.Raycast((Vector3)guardAnimation, (Vector3)obj2, 0.2f);
		object obj3 = text2 + 20;
		bool flag2 = Physics.Raycast((Vector3)dogAnimation, (Vector3)obj3, 0.2f);
	}

	private IEnumerator RollCoroutine(float delay)
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

	private unsafe void OnJump(float jumpHeight, bool willPlaySound)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ca: Expected VT, but got Obj
		//IL_00ca: Expected Obj, but got F4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		Material material = default;
		object obj3 = material + 16;
		obj3 = ((bool*)(willPlaySound ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [willPlaySound @ L2 (System.Boolean)+8]");
		_ = 0;
		object obj4 = obj2 + 28;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		_enemiesData = null;
		material.SetTextureOffset((string)lastGroundedSmoothTime, (Vector2)"_MainColor");
		obj3 = material;
		_ = ((UnityEngine.Object)material).m_CachedPtr;
		object obj5 = obj2 + 12;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj7 = default;
		object obj6 = obj7 + 16;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine = default;
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public void Jump(float delay)
	{
		string text = tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 != null)
		{
			IEnumerator routine = RollCoroutine(delay);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	private IEnumerator JumpCoroutine(float delay)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	private void JumpAnimation()
	{
		Game game = this.game;
		float delay = distanceToCharacter / game.__currentSpeed;
		IEnumerator routine = JumpCoroutine(delay);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private void HandleOnHangtime()
	{
		//IL_002c: Expected I4, but got Obj
		//IL_002c: Expected I4, but got Obj
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_00a3: Expected I4, but got Obj
		//IL_00a3: Expected I4, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00ce: Expected VT, but got Obj
		//IL_00ce: Expected VT, but got Obj
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00f4: Expected VT, but got Obj
		//IL_00f4: Expected VT, but got Obj
		DefaultAnimations defaultAnimations = this.defaultAnimations;
		DefaultAnimations defaultAnimations2 = this.defaultAnimations;
		string text = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations.jumpGuard, (int)defaultAnimations2.jumpDog);
		object animation = text + 16;
		AnimationState animationState = guardAnimation.CrossFadeQueued((string)animation);
		object animation2 = text + 20;
		AnimationState animationState2 = dogAnimation.CrossFadeQueued((string)animation2);
		DefaultAnimations defaultAnimations3 = this.defaultAnimations;
		DefaultAnimations defaultAnimations4 = this.defaultAnimations;
		string text2 = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations3.runGuard, (int)defaultAnimations4.runDog);
		object obj = text2 + 16;
		bool flag = Physics.Raycast((Vector3)guardAnimation, (Vector3)obj, 0.3f);
		object obj2 = text2 + 20;
		bool flag2 = Physics.Raycast((Vector3)dogAnimation, (Vector3)obj2, 0.3f);
	}

	private IEnumerator HangtimeCoroutine(float delay)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	private unsafe void HandleOnLanding(Transform characterTransform)
	{
		//IL_0239: Expected I4, but got Obj
		//IL_0239: Expected I4, but got Obj
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_025f: Expected VT, but got Obj
		//IL_025f: Expected VT, but got Obj
		//IL_00c4: Expected I4, but got Obj
		//IL_00c4: Expected I4, but got Obj
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_028a: Expected VT, but got Obj
		//IL_028a: Expected VT, but got Obj
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00ea: Expected I4, but got Obj
		//IL_012b: Expected Obj, but got I4
		//IL_0099: Expected I4, but got Obj
		//IL_0099: Expected I4, but got Obj
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_014d: Expected I4, but got Obj
		//IL_018e: Expected Obj, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		if (~(caught ? 1u : 0u) == 0)
		{
			return;
		}
		string text = ((PhysicsScene*)characterController)->ToString();
		if (text != null)
		{
			DefaultAnimations defaultAnimations = this.defaultAnimations;
			string text2;
			if ((object)characterTransform != null)
			{
				DefaultAnimations defaultAnimations2 = this.defaultAnimations;
				text2 = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations.dodgeRigthGuard, (int)defaultAnimations2.dodgeRightDog);
			}
			else
			{
				DefaultAnimations defaultAnimations3 = this.defaultAnimations;
				text2 = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations.dodgeLeftGuard, (int)defaultAnimations3.dodgeLeftDog);
			}
			object obj = text2 + 16;
			bool flag = guardAnimation.Play((PlayMode)obj);
			Game game = this.game;
			Game.SpeedInfo speed = game.speed;
			float height = game.__currentSpeed / speed.min;
			((CharacterController)flag).height = height;
			object obj2 = text2 + 20;
			bool flag2 = dogAnimation.Play((PlayMode)obj2);
			Game game2 = this.game;
			Game.SpeedInfo speed2 = game2.speed;
			float height2 = game2.__currentSpeed / speed2.min;
			((CharacterController)flag2).height = height2;
			object clip = text2 + 16;
			AudioSource.PlayOneShotHelper((AudioSource)(object)guardAnimation, (AudioClip)clip, 0.1f);
			object clip2 = text2 + 20;
			AudioSource.PlayOneShotHelper((AudioSource)(object)dogAnimation, (AudioClip)clip2, 0.1f);
		}
		Character character = this.character;
		if (~(character.__isJumping ? 1u : 0u) != 0)
		{
			DefaultAnimations defaultAnimations4 = this.defaultAnimations;
			DefaultAnimations defaultAnimations5 = this.defaultAnimations;
			string text3 = ((HouseKeeper)null).RoundUpToTargetValue((int)defaultAnimations4.runGuard, (int)defaultAnimations5.runDog);
			object obj3 = text3 + 16;
			bool flag3 = Physics.Raycast((Vector3)guardAnimation, (Vector3)obj3, 0.1f);
			object obj4 = text3 + 20;
			bool flag4 = Physics.Raycast((Vector3)dogAnimation, (Vector3)obj4, 0.1f);
		}
	}

	private IEnumerator LandingCoroutine(float delay)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	public void CatchPlayer(float pos)
	{
		//IL_004f: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		if (!(distanceToCharacter > distanceToCharacterMin))
		{
			StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)40, (PersistentAwardProgress)1, (Action<Award>)(-1));
		}
		IEnumerator routine = HangtimeCoroutine(pos);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public void HitByTrainSequence()
	{
	}

	public unsafe IEnumerator HitByTrainSequenceCoroutine()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Ref, but got Unknown
		//IL_00c4: Expected Obj, but got VT
		//IL_00d9: Expected I4, but got Obj
		//IL_0048: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		object obj = default;
		ref int reference = ref *(int*)(obj + 8);
		reference = ref *(int*)null;
		DateTime utcNow = CDateTime.UtcNow;
		obj = utcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC2");
		string key = string.ConcatArray((string[])(object)"socflurdaily", (int)this);
		SaveDataStrings debug_saveData = DebugSave.debug_saveData;
		bool flag = ((Dictionary<string, int>)(object)debug_saveData).TryGetValue(key, out reference);
		int num = default;
		bool flag2 = num == reference;
		object obj2 = flag & flag2;
		if (obj2 != null)
		{
			return null;
		}
		SaveDataStrings debug_saveData2 = DebugSave.debug_saveData;
		Kiloo.Common.Extensions.CollectionExtensions.AddOrSet((Dictionary<string, int>)(object)debug_saveData2, key, num);
		return (IEnumerator)1;
	}

	public void ShowEnemies(bool vis)
	{
		Game game = this.game;
		float seconds = distanceToCharacter / game.__currentSpeed;
		IEnumerator routine = ((TopRunOnlineGameOverScreen)this).AnimateMedalAfterSeconds(seconds);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public void LateUpdate()
	{
		AudioSource component = GetComponent<AudioSource>();
		component.Pause();
		IEnumerator routine = ((HouseKeeper)this).Start();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public unsafe void OnValidate()
	{
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01ea: Expected Obj, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected VT, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0225: Expected F4, but got Obj
		//IL_0220: Expected native int or pointer, but got VT
		//IL_023a: Expected F4, but got I
		//IL_0235: Expected native int or pointer, but got VT
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Ref, but got Unknown
		//IL_027a: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0389: Expected I, but got Obj
		//IL_039f: Expected Obj, but got I
		//IL_00b7: Expected I, but got Obj
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_0407: Expected I, but got Obj
		//IL_041d: Expected Obj, but got I
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_0489: Expected F4, but got Obj
		//IL_0484: Expected native int or pointer, but got VT
		//IL_049e: Expected F4, but got I
		//IL_0499: Expected native int or pointer, but got VT
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected VT, but got Unknown
		//IL_04da: Expected F4, but got Obj
		//IL_04d5: Expected native int or pointer, but got VT
		//IL_04ef: Expected F4, but got I
		//IL_04ea: Expected native int or pointer, but got VT
		//IL_04fc: Expected F4, but got Obj
		//IL_04f7: Expected native int or pointer, but got VT
		//IL_0511: Expected F4, but got I
		//IL_050c: Expected native int or pointer, but got VT
		//IL_0194: Expected Obj, but got F4
		//IL_01ab: Expected F4, but got Obj
		//IL_01a6: Expected native int or pointer, but got VT
		//IL_01c0: Expected F4, but got I
		//IL_01bb: Expected native int or pointer, but got VT
		//IL_01c9: Expected Obj, but got VT
		//IL_0122: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		_ = 0;
		SmoothDampFloat smoothDampFloat = x;
		Vector3 vector = (Vector3)(obj2 + 72);
		object obj3 = this.character + 248;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		smoothDampFloat._target = vector.x;
		((SmoothDampVector3)(object)x).Update();
		Character character = this.character;
		ref float currentVelocity = ref *(float*)(this + 116);
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v84 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Mathf.SmoothDampAngle(lastGroundedSmooth, character.LastGroundedY, ref currentVelocity, lastGroundedSmoothTime);
		lastGroundedSmooth = num3;
		if (y > lastGroundedSmooth)
		{
			float unscaledTime = Time.unscaledTime;
			float num4 = gravity * unscaledTime;
			float num5 = verticalSpeed - num4;
			verticalSpeed = num5;
		}
		float unscaledTime2 = Time.unscaledTime;
		float num6 = verticalSpeed * unscaledTime2;
		float num7 = y + num6;
		y = num7;
		object obj5 = lastGroundedSmooth & 0x7FFFFFFF;
		float num8 = (((nint)obj5 <= 2139095040) ? lastGroundedSmooth : 0f);
		lastGroundedSmooth = num8;
		nint num9 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v41 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v79 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num11 = ((!(y > lastGroundedSmooth)) ? lastGroundedSmooth : y);
		y = num11;
		object obj7 = obj2 + 36;
		object obj8 = this.character + 248;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v34+8]");
		_ = 0;
		nint num12 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v50 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num13 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v75 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = obj2 + 24;
		Vector3 back = Vector3.back;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v55+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj11 = obj2 + 12;
		Vector3 vector4 = vector / distanceToCharacter;
		Vector3 vector5 = (Vector3)(obj2 + 60);
		((Vector3*)(nint)vector5)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v47+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj11;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v61+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector5, vector);
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_ = y;
		SmoothDampFloat smoothDampFloat2 = x;
		obj = smoothDampFloat2._value;
		GameObject gameObject = base.gameObject;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Vector3 localPosition = ((Transform)vector).localPosition;
	}

	public FollowingGuard()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this - -64;
		PlaceholderLifecycle component = GetComponent<PlaceholderLifecycle>();
		obj = component;
	}

	unsafe static FollowingGuard()
	{
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected I4, but got Unknown
		//IL_0220: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj2 + 20);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		throw new ArrayTypeMismatchException();
	}

	private void _003CCatchUp_003Eb__54_1(float t)
	{
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03cf: Expected Obj, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0196: Expected Obj, but got I
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got I
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_04f8: Expected F4, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02c2: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_0318: Expected F4, but got I
		if (game.HasSuperSneakers)
		{
			return;
		}
		AudioSource component = GetComponent<AudioSource>();
		component.Pause();
		MonoBehaviour.print(this);
		caught = true;
		int num;
		if (debugCatchAnimationToPlay >= 0)
		{
			CatchAnimationSet[] array = caughtLeft;
			if (debugCatchAnimationToPlay < array.Length)
			{
				num = debugCatchAnimationToPlay;
				goto IL_00ac;
			}
		}
		CatchAnimationSet[] array2 = caughtLeft;
		num = UnityEngine.Random.RandomRangeInt(0, array2.Length);
		goto IL_00ac;
		IL_012a:
		int num10;
		if (t < 20f)
		{
			object obj = caughtLeft + 16;
			int num2 = num << 2;
			object obj2 = obj + num2;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v52+C]");
			UnityEngine.Object clip = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
			AudioSource.PlayOneShotHelper((AudioSource)(object)guardAnimation, (AudioClip)clip, 0.2f);
			object obj4 = caughtLeft + 16;
			int num3 = num << 2;
			object obj5 = obj4 + num3;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v59+10]");
			UnityEngine.Object clip2 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
			AudioSource.PlayOneShotHelper((AudioSource)(object)dogAnimation, (AudioClip)clip2, 0.2f);
			object obj7 = caughtLeft + 16;
			int num4 = num << 2;
			object obj8 = obj7 + num4;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v59+14]");
			float num5 = 0f / 25f;
			if (OnCatchPlayer != null)
			{
				object obj10 = caughtLeft + 16;
				int num6 = num << 2;
				object obj11 = obj10 + num6;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v71+8]");
				UnityEngine.Object target = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
				object obj13 = caughtLeft + 16;
				int num7 = num << 2;
				object obj14 = obj13 + num7;
				object obj15 = obj14;
				OnCatchPlayerDelegate onCatchPlayer = OnCatchPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S3_v25+18]");
				((UIRect.AnchorPoint)(object)onCatchPlayer).Set((Transform)target, num5, 0f);
			}
			float num8 = num5;
		}
		else
		{
			object obj16 = caughtRight + 16;
			int num9 = num10 << 2;
			object obj17 = obj16 + num9;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v27+C]");
			UnityEngine.Object clip3 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
			AudioSource.PlayOneShotHelper((AudioSource)(object)guardAnimation, (AudioClip)clip3, 0.2f);
			object obj19 = caughtRight + 16;
			int num11 = num10 << 2;
			object obj20 = obj19 + num11;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v34+10]");
			UnityEngine.Object clip4 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
			AudioSource.PlayOneShotHelper((AudioSource)(object)dogAnimation, (AudioClip)clip4, 0.2f);
			object obj22 = caughtRight + 16;
			int num12 = num10 << 2;
			object obj23 = obj22 + num12;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v45+14]");
			float num13 = 0f / 25f;
			bool flag = OnCatchPlayer == null;
			float num8 = num13;
			if (!flag)
			{
				object obj25 = caughtRight + 16;
				int num14 = num10 << 2;
				object obj26 = obj25 + num14;
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v45+8]");
				UnityEngine.Object target2 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
				object obj28 = caughtRight + 16;
				int num15 = num10 << 2;
				object obj29 = obj28 + num15;
				object obj30 = obj29;
				OnCatchPlayerDelegate onCatchPlayer2 = OnCatchPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S3_v13+18]");
				((UIRect.AnchorPoint)(object)onCatchPlayer2).Set((Transform)target2, num13, 0f);
				num8 = num13;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num16 = 0;
		_ = 0;
		object obj32 = default;
		object obj31 = obj32 + 16;
		obj31 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine = default;
		Coroutine coroutine = StartCoroutine_Auto(routine);
		return;
		IL_00ac:
		if (debugCatchAnimationToPlay >= 0)
		{
			CatchAnimationSet[] array3 = caughtRight;
			if (debugCatchAnimationToPlay < array3.Length)
			{
				num10 = debugCatchAnimationToPlay;
				goto IL_012a;
			}
		}
		CatchAnimationSet[] array4 = caughtRight;
		num10 = UnityEngine.Random.RandomRangeInt(0, array4.Length);
		goto IL_012a;
	}

	private void _003CResetCatchUpCoroutine_003Eb__57_1(float t)
	{
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		AudioSource component = GetComponent<AudioSource>();
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v26 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float pitch;
		if (PreferencesSave.musicEnabled)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v16 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v22 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			pitch = Mathf.InverseLerp(0f, guardProximityLoopVolume, t);
		}
		else
		{
			pitch = 0f;
		}
		component.pitch = pitch;
	}

	private void _003CCatchPlayer_003Eb__73_0(float t)
	{
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		AudioSource component = GetComponent<AudioSource>();
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v16 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float pitch;
		if (PreferencesSave.musicEnabled)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v10 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			pitch = Mathf.InverseLerp(guardProximityLoopVolume, 0f, t);
		}
		else
		{
			pitch = 0f;
		}
		component.pitch = pitch;
	}
}
