using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Placeholders.Lifecycles;
using UnityEngine;

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

	private sealed class _003CResetCatchUpCoroutine_003Ed__61(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FollowingGuard _003C_003E4__this;

		public float duration;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_013b: Expected Obj, but got I
			FollowingGuard followingGuard = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					AudioSource component = followingGuard.GetComponent<AudioSource>();
					component.Stop();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (FollowingGuard)+90]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v39+28]");
					if ((nint)0 == 0)
					{
						followingGuard.ShowEnemies(vis: false);
					}
				}
			}
			else
			{
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (FollowingGuard)+68]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (FollowingGuard)+6C]");
					_ = 0;
					_ = 0;
					throw new ArgumentException();
				}
			}
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

	private sealed class _003CRollCoroutine_003Ed__68(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FollowingGuard _003C_003E4__this;

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
					FollowingGuard followingGuard = _003C_003E4__this;
					_003C_003E1__state = -1;
					float num = followingGuard.character.CalculateJumpVerticalSpeed();
					float verticalSpeed = 0f - num;
					followingGuard.verticalSpeed = verticalSpeed;
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

	private sealed class _003CJumpCoroutine_003Ed__71(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FollowingGuard _003C_003E4__this;

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
					FollowingGuard followingGuard = _003C_003E4__this;
					_003C_003E1__state = -1;
					_003C_003E4__this.JumpAnimation();
					float num = followingGuard.character.CalculateJumpVerticalSpeed();
					float verticalSpeed = num * 0.7f;
					followingGuard.verticalSpeed = verticalSpeed;
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

	private sealed class _003CHangtimeCoroutine_003Ed__74(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FollowingGuard _003C_003E4__this;

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
					FollowingGuard followingGuard = _003C_003E4__this;
					_003C_003E1__state = -1;
					DefaultAnimations defaultAnimations = followingGuard.defaultAnimations;
					string[] array = ReturnRandomAnimations(defaultAnimations.hangtimeGuard, defaultAnimations.hangtimeDog);
					followingGuard.guardAnimation.CrossFade(array[0], 0.1f);
					followingGuard.dogAnimation.CrossFade(array[1], 0.1f);
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

	private sealed class _003CLandingCoroutine_003Ed__76(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FollowingGuard _003C_003E4__this;

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
					FollowingGuard followingGuard = _003C_003E4__this;
					_003C_003E1__state = -1;
					DefaultAnimations defaultAnimations = followingGuard.defaultAnimations;
					string[] array = ReturnRandomAnimations(defaultAnimations.landingGuard, defaultAnimations.landingDog);
					followingGuard.guardAnimation.CrossFade(array[0], 0.1f);
					followingGuard.dogAnimation.CrossFade(array[1], 0.1f);
					DefaultAnimations defaultAnimations2 = followingGuard.defaultAnimations;
					string[] array2 = ((FollowingGuard)(object)array).ReturnRandomAnimations(defaultAnimations2.runGuard, defaultAnimations2.runDog);
					AnimationState animationState = followingGuard.guardAnimation.CrossFadeQueued(array2[0], 0.1f);
					AnimationState animationState2 = followingGuard.dogAnimation.CrossFadeQueued(array2[1], 0.1f);
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

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public FollowingGuard _003C_003E4__this;

		public Vector3 charPos;

		internal unsafe void _003CHitByTrainSequenceCoroutine_003Eb__0(float t)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00a9: Expected Obj, but got I
			//IL_00eb: Expected Obj, but got I
			//IL_012e: Expected Obj, but got I
			//IL_0171: Expected Obj, but got I
			//IL_01b1: Expected F4, but got I
			//IL_01ac: Expected native int or pointer, but got VT
			//IL_01d0: Expected F4, but got I
			//IL_01cb: Expected native int or pointer, but got VT
			//IL_01e5: Expected Obj, but got I
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Expected Obj, but got Unknown
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			float num = Math.Min(t, 1f);
			bool flag = t < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			object obj2 = default;
			object obj10 = default;
			while (true)
			{
				FollowingGuard followingGuard = _003C_003E4__this;
				Transform[] enemies = followingGuard.enemies;
				if (enemies.Length > (nint)obj2)
				{
					object obj3 = obj2 << 2;
					object obj4 = (object)enemies + obj3;
					FollowingGuard followingGuard2 = _003C_003E4__this;
					object obj5 = obj2 << 2;
					object obj6 = (object)followingGuard2.enemies + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v13+10]");
					Vector3 position = ((Transform)0).position;
					FollowingGuard followingGuard3 = _003C_003E4__this;
					Vector3 currentTransformPosition = followingGuard3.character.CurrentTransformPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					object obj7 = num3 - 0;
					float num4 = (float)obj7 * num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					float num5 = 0f + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					object obj8 = num6 - 0;
					float num7 = (float)obj8 * num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					float num8 = 0f + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					object obj9 = num9 - 0;
					float num10 = (float)obj9 * num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					float num11 = 0f + num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
					((Vector3*)(nint)vector)->x = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v14+10]");
					((Transform)0).position = vector;
					obj2 = obj10 + 1;
					continue;
				}
				break;
			}
		}

		internal unsafe void _003CHitByTrainSequenceCoroutine_003Eb__1(float t)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0029: Expected Obj, but got VT
			//IL_00ab: Expected Obj, but got I
			//IL_00eb: Expected F4, but got I
			//IL_00e6: Expected native int or pointer, but got VT
			//IL_0148: Expected F4, but got I
			//IL_0143: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 32);
			FollowingGuard followingGuard = _003C_003E4__this;
			object obj2 = charPos - charPos;
			float num = Math.Min(t, 1f);
			bool flag = t < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			float num3 = (float)obj2 * num2;
			float num4 = (float)charPos + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FollowingGuard+<>c__DisplayClass79_0)+14]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FollowingGuard+<>c__DisplayClass79_0)+14]");
			object obj3 = num5 - 0;
			float num6 = (float)obj3 * num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FollowingGuard+<>c__DisplayClass79_0)+14]");
			float num7 = 0f + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			float num8 = -5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FollowingGuard+<>c__DisplayClass79_0)+10]");
			float num9 = num8 - 0f;
			float num10 = num9 * num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FollowingGuard+<>c__DisplayClass79_0)+10]");
			float num11 = 0f + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			followingGuard.characterTransform.position = vector;
		}
	}

	private sealed class _003CHitByTrainSequenceCoroutine_003Ed__79(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FollowingGuard _003C_003E4__this;

		private _003C_003Ec__DisplayClass79_0 _003C_003E8__1;

		private string[] _003CdeathByTrainAnimations_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0116: Expected Obj, but got I
			//IL_0134: Expected Obj, but got I
			//IL_0134: Expected Obj, but got I
			//IL_016b: Expected Obj, but got I
			//IL_01c3: Expected Obj, but got I
			//IL_01f3: Expected VT, but got Obj
			//IL_028a: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
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
							string[] array = _003CdeathByTrainAnimations_003E5__2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (FollowingGuard)+48]");
							bool flag = ((Animation)0).Play(array[0]);
						}
						bool result = default;
						return result;
					}
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass79_0 obj3 = _003C_003E8__1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (FollowingGuard)+A0]");
					Vector3 position = ((Transform)0).position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					obj3.charPos = (Vector3)obj;
					throw new ArgumentException();
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (FollowingGuard)+C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v7+4C]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v7+50]");
				string[] array2 = ReturnRandomAnimations((AnimationClip[])num, (AnimationClip[])0);
				_003CdeathByTrainAnimations_003E5__2 = array2;
				string[] array3 = _003CdeathByTrainAnimations_003E5__2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (FollowingGuard)+4C]");
				bool flag2 = ((Animation)0).Play(array3[1]);
				_ = 0.4f;
				object obj5 = default;
				_003C_003E2__current = obj5;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			_003C_003Ec__DisplayClass79_0 obj6 = default;
			_003C_003E8__1 = obj6;
			_003C_003Ec__DisplayClass79_0 obj7 = _003C_003E8__1;
			obj7._003C_003E4__this = _003C_003E4__this;
			throw new ArgumentException();
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

	private DefaultAnimations defaultAnimations;

	private CatchAnimationSet[] caughtLeft;

	private CatchAnimationSet[] caughtRight;

	private float distanceToCharacterMin = 10f;

	private float distanceToCharacterMax;

	private float catchUpDuration = 0.7f;

	private float resetCatchUpDuration;

	private float lastGroundedSmoothTime = 0.3f;

	private float xSmoothTime;

	private float gravity = 200f;

	private Transform[] enemies;

	private int debugCatchAnimationToPlay = -1;

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

	private Transform characterTransform;

	private static FollowingGuard instance;

	public static FollowingGuard Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			FollowingGuard result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(FollowingGuard));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				FollowingGuard followingGuard = default;
				instance = followingGuard;
				result = followingGuard;
			}
			return result;
		}
	}

	public unsafe void Initialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I
		//IL_0147: Expected F4, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_017d: Expected I, but got F4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		object obj = default;
		FollowingGuard followingGuard = (FollowingGuard)(obj - 80);
		followingGuard.dogAnimation = null;
		followingGuard.guardAnimation = null;
		followingGuard._enemiesData = null;
		followingGuard._placeholderLifecycle = null;
		ReplaceSharedPrefab();
		Game game = Game.Instance;
		this.game = game;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FollowingGuard.Game_OnCharacterModelRecreated));
		this.game.OnCharacterModelRecreated += action;
		CharacterController charactercontroller = Game.Charactercontroller;
		characterController = charactercontroller;
		Character character = Character.Instance;
		this.character = character;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		this.characterRendering = characterRendering;
		Transform transform = this.character.transform;
		characterTransform = transform;
		GameObject gameObject = base.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		Renderer[] array = default;
		enemyRenderers = array;
		Transform[] array2 = enemies;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector3[] array3 = default;
		enemiesStartPos = array3;
		object obj2 = 0;
		while (true)
		{
			Transform[] array4 = enemies;
			if (array4.Length <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)array4 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v212+10]");
			Vector3 position = ((Transform)0).position;
			followingGuard.lastGroundedSmoothTime = followingGuard.debugCatchAnimationToPlay;
			followingGuard.caughtLeft = (CatchAnimationSet[])followingGuard.debugCatchAnimationToPlay;
			followingGuard.catchUpDuration = followingGuard.gravity;
			((UnityEngine.Object)followingGuard).m_CachedPtr = (IntPtr)followingGuard.gravity;
			object obj5 = obj2 * 12;
			object obj6 = (object)enemiesStartPos + obj5;
			_ = followingGuard.caughtLeft;
			_ = ((UnityEngine.Object)followingGuard).m_CachedPtr;
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
		SmoothDampFloat smoothDampFloat = default;
		smoothDampFloat._value = 0f;
		smoothDampFloat._smoothTime = xSmoothTime;
		smoothDampFloat._target = 0f;
		x = smoothDampFloat;
		AudioSource component = GetComponent<AudioSource>();
		component.volume = guardProximityLoopVolume;
		throw new ArgumentException();
	}

	private void ReplaceSharedPrefab()
	{
		_placeholderLifecycle.Spawn();
		GameObject gameObject = base.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		EnemiesRig enemiesData = default;
		_enemiesData = enemiesData;
		EnemiesRig enemiesData2 = _enemiesData;
		dogAnimation = enemiesData2._dogAnimation;
		EnemiesRig enemiesData3 = _enemiesData;
		guardAnimation = enemiesData3._guardAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Transform[] array = default;
		enemies = array;
		Transform[] array2 = enemies;
		Transform transform = dogAnimation.transform;
		throw new ArrayTypeMismatchException();
	}

	private Transform GetChildTransformByName(string name, Transform current)
	{
		string text = current.name;
		bool flag = text.Equals(name);
		bool flag2 = !flag;
		int num = 0;
		if (!flag2)
		{
			return current;
		}
		Transform result;
		while (true)
		{
			int childCount = current.childCount;
			if (childCount > num)
			{
				Transform child = current.GetChild(num);
				Transform childTransformByName = GetChildTransformByName(name, child);
				bool flag3 = childTransformByName == null;
				result = childTransformByName;
				if (!flag3)
				{
					break;
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			result = null;
			break;
		}
		return result;
	}

	private void Game_OnCharacterModelRecreated()
	{
		//IL_0056: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		CatchAnimationSet[] array = caughtLeft;
		FollowingGuard followingGuard = null;
		while (array.Length > (nint)followingGuard)
		{
			CharacterRendering characterRendering = this.characterRendering;
			SafeAnimation characterSafeAnimation = characterRendering._characterSafeAnimation;
			object obj = (object)followingGuard << 2;
			object obj2 = (object)array + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v8+10]");
			object obj3 = 0;
			FollowingGuard followingGuard2 = followingGuard;
			Animation animation = characterSafeAnimation._animation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S2_v9+8]");
			followingGuard2.SetupAvatarAnimationsStates(animation, (AnimationClip)0);
			FollowingGuard followingGuard3 = (FollowingGuard)(followingGuard + 1);
			followingGuard = followingGuard3;
		}
		CatchAnimationSet[] array2 = caughtRight;
		FollowingGuard followingGuard4 = null;
		while (array2.Length > (nint)followingGuard4)
		{
			CharacterRendering characterRendering2 = this.characterRendering;
			SafeAnimation characterSafeAnimation2 = characterRendering2._characterSafeAnimation;
			object obj4 = (object)followingGuard4 << 2;
			object obj5 = (object)array2 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S2_v4+10]");
			object obj6 = 0;
			FollowingGuard followingGuard5 = followingGuard4;
			Animation animation2 = characterSafeAnimation2._animation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v5+8]");
			followingGuard5.SetupAvatarAnimationsStates(animation2, (AnimationClip)0);
			FollowingGuard followingGuard6 = (FollowingGuard)(followingGuard4 + 1);
			followingGuard4 = followingGuard6;
		}
	}

	private void OnSfxSettingChanged()
	{
		bool optionSfx = Settings.optionSfx;
		AudioSource component = GetComponent<AudioSource>();
		float volume = ((!optionSfx) ? 0f : guardProximityLoopVolume);
		component.volume = volume;
	}

	private void InitializeClips(Animation animationComponent, List<AnimationClip> addedClips, AnimationClip[] clips)
	{
		//IL_00f3: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		object obj = 0;
		while (clips.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)clips + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v11+10]");
			if (!((UnityEngine.Object)0 == null))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v11+10]");
				if (!addedClips.Contains((AnimationClip)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v11+10]");
					addedClips.Add((AnimationClip)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v11+10]");
					string newName = ((UnityEngine.Object)0).name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v11+10]");
					animationComponent.AddClip((AnimationClip)0, newName);
				}
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	private void SetupAvatarAnimationsStates(Animation animation, AnimationClip animationClip)
	{
		string text = animationClip.name;
		AnimationClip clip = animation.GetClip(text);
		if (clip == null)
		{
			string newName = animationClip.name;
			animation.AddClip(animationClip, newName);
		}
		string text2 = animationClip.name;
		AnimationState animationState = animation.get_Item(text2);
		animationState.enabled = false;
		string text3 = animationClip.name;
		AnimationState animationState2 = animation.get_Item(text3);
		animationState2.layer = 4;
	}

	private void SetupDogGuardAnimationsStates(Animation animation, AnimationClip animationClip)
	{
		string text = animationClip.name;
		AnimationClip clip = animation.GetClip(text);
		if (clip == null)
		{
			string newName = animationClip.name;
			animation.AddClip(animationClip, newName);
		}
	}

	private void HandleOnPauseChange(bool pause)
	{
		if (pause)
		{
			AudioSource component = GetComponent<AudioSource>();
			if (component.isPlaying)
			{
				AudioSource component2 = GetComponent<AudioSource>();
				component2.Pause();
			}
		}
	}

	public unsafe void ResetModelRootPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected VT, but got Unknown
		//IL_00f9: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected VT, but got Unknown
		//IL_0184: Expected F4, but got I
		//IL_017f: Expected native int or pointer, but got VT
		//IL_01a6: Expected F4, but got I
		//IL_01a1: Expected native int or pointer, but got VT
		//IL_01bb: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 128);
		object obj2 = default;
		object obj9 = default;
		while (true)
		{
			Transform[] array = enemies;
			if (array.Length > (nint)obj2)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				object obj5 = obj2 * 12;
				object obj6 = (object)enemiesStartPos + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v9+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v9+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				float num = 0f + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+54]");
				float num2 = 0f + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				float num3 = 0f + 8f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
				_ = 0;
				Vector3 localPosition = (Vector3)(quaternion + 32);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v11+10]");
				((Transform)0).localPosition = localPosition;
				object obj7 = obj2 << 2;
				object obj8 = (object)enemies + obj7;
				_ = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
				_ = 0;
				_ = 0f;
				_ = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
				_ = 0;
				Vector3 euler = (Vector3)(quaternion + 16);
				Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+78]");
				((Quaternion*)(nint)quaternion)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+70]");
				((Quaternion*)(nint)quaternion)->x = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v29+10]");
				((Transform)0).rotation = quaternion;
				obj2 = obj9 + 1;
				continue;
			}
			break;
		}
	}

	public void Restart(bool closeToCharacter)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0049: Expected F4, but got Obj
		//IL_0030: Expected Obj, but got I4
		StopAllCoroutines();
		this.closeToCharacter = closeToCharacter;
		object obj = 24;
		if (!closeToCharacter)
		{
			obj = 28;
		}
		object obj2 = (object)this + obj;
		distanceToCharacter = (float)obj2;
	}

	public unsafe void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f0: Expected F4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Character character = this.character;
		lastGroundedVelocity = 0f;
		lastGroundedSmooth = character.LastGroundedY;
		y = character.LastGroundedY;
		SmoothDampFloat smoothDampFloat = x;
		Vector3 currentTransformPosition = character.CurrentTransformPosition;
		smoothDampFloat._value = (float)obj;
		verticalSpeed = 0f;
		closeToCharacter = true;
		distanceToCharacter = distanceToCharacterMin;
		Character.OnJumpDelegate onJumpDelegate = default;
		onJumpDelegate._002Ector(this, (nint)__ldftn(FollowingGuard.OnJump));
		this.character.OnJump += onJumpDelegate;
		Character.OnRollGuardDelegate onRollGuardDelegate = default;
		onRollGuardDelegate._002Ector(this, (nint)__ldftn(FollowingGuard.OnRoll));
		this.character.OnRollGuard += onRollGuardDelegate;
		Character.OnRollDelegate onRollDelegate = default;
		onRollDelegate._002Ector(this, (nint)__ldftn(FollowingGuard.OnRollNoAnimation));
		this.character.OnRoll += onRollDelegate;
		Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
		onChangeTrackDelegate._002Ector(this, (nint)__ldftn(FollowingGuard.OnChangeTrack));
		this.character.OnChangeTrack += onChangeTrackDelegate;
	}

	public unsafe void OnDisable()
	{
		Character.OnJumpDelegate onJumpDelegate = default;
		onJumpDelegate._002Ector(this, (nint)__ldftn(FollowingGuard.OnJump));
		character.OnJump -= onJumpDelegate;
		Character.OnRollGuardDelegate onRollGuardDelegate = default;
		onRollGuardDelegate._002Ector(this, (nint)__ldftn(FollowingGuard.OnRoll));
		character.OnRollGuard -= onRollGuardDelegate;
		Character.OnRollDelegate onRollDelegate = default;
		onRollDelegate._002Ector(this, (nint)__ldftn(FollowingGuard.OnRollNoAnimation));
		character.OnRoll -= onRollDelegate;
		Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
		onChangeTrackDelegate._002Ector(this, (nint)__ldftn(FollowingGuard.OnChangeTrack));
		character.OnChangeTrack += onChangeTrackDelegate;
	}

	public void CatchUp()
	{
		CatchUp(catchUpDuration);
	}

	public void CatchUp(float duration)
	{
		if (~(closeToCharacter ? 1u : 0u) != 0)
		{
			_ = distanceToCharacter;
			ShowEnemies(vis: true);
			StopAllCoroutines();
			DefaultAnimations defaultAnimations = this.defaultAnimations;
			string[] array = ReturnRandomAnimations(defaultAnimations.catchupGuard, null);
			bool flag = guardAnimation.Play(array[0]);
			AnimationState animationState = guardAnimation.PlayQueued("Guard_Run");
			AudioSource component = GetComponent<AudioSource>();
			AudioSource component2 = GetComponent<AudioSource>();
			int timeSamples = component2.timeSamples;
			int timeSamples2 = UnityEngine.Random.Range(0, timeSamples);
			component.timeSamples = timeSamples2;
			AudioSource component3 = GetComponent<AudioSource>();
			component3.Play();
			AudioSource component4 = GetComponent<AudioSource>();
			float pitch = UnityEngine.Random.Range(0.9f, 1.05f);
			component4.pitch = pitch;
			throw new ArgumentException();
		}
	}

	public void ResetCatchUp()
	{
		ResetCatchUp(resetCatchUpDuration);
	}

	public void ResetCatchUp(float duration)
	{
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			IEnumerator routine = ResetCatchUpCoroutine(duration);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	public IEnumerator ResetCatchUpCoroutine(float duration)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void MuteProximityLoop()
	{
		AudioSource component = GetComponent<AudioSource>();
		component.Stop();
	}

	public void PlayIntro()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected VT, but got Unknown
		//IL_0082: Expected Obj, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I
		//IL_00fb: Expected F4, but got Obj
		//IL_010d: Expected F4, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected VT, but got Unknown
		//IL_0130: Expected Obj, but got I
		//IL_015b: Expected Obj, but got F4
		//IL_016d: Expected F4, but got Obj
		//IL_019b: Expected Obj, but got F4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected VT, but got Unknown
		//IL_01df: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0213: Expected VT, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		object obj = default;
		FollowingGuard followingGuard = (FollowingGuard)(obj - 144);
		GameObject gameObject = base.gameObject;
		Transform transform = gameObject.transform;
		followingGuard.closeToCharacter = false;
		followingGuard.debugCatchAnimationToPlay = -1054867456;
		followingGuard.previusAvatarCaughtAnimRight = null;
		followingGuard.gravity = 0f;
		Vector3 position = (Vector3)(followingGuard + 48);
		transform.position = position;
		object obj2 = 0;
		while (true)
		{
			Transform[] array = enemies;
			if (array.Length <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)array + obj3;
			object obj5 = obj2 * 12;
			object obj6 = (object)enemiesStartPos + obj5;
			FollowingGuard followingGuard2 = followingGuard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v37+18]");
			followingGuard2.currentAvatarStumbleDeath = (string)0;
			FollowingGuard followingGuard3 = followingGuard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v37+10]");
			followingGuard3.isShowing = false;
			followingGuard.lastGroundedSmoothTime = (float)followingGuard.currentAvatarStumbleDeath;
			followingGuard.catchUpDuration = (followingGuard.isShowing ? 1 : 0);
			Vector3 position2 = (Vector3)(followingGuard + 32);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v42+10]");
			((Transform)0).position = position2;
			object obj7 = obj2 << 2;
			object obj8 = (object)enemies + obj7;
			followingGuard.previusAvatarStumbleDeath = (string)0f;
			followingGuard.distanceToCharacterMin = (float)followingGuard.previusAvatarStumbleDeath;
			followingGuard.lastGroundedVelocity = 0f;
			followingGuard.lastGroundedSmooth = 0f;
			followingGuard.caughtLeft = (CatchAnimationSet[])followingGuard.lastGroundedSmooth;
			Vector3 euler = (Vector3)(followingGuard + 16);
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
			followingGuard.guardAnimation = (Animation)(object)followingGuard.enemyRenderers;
			((UnityEngine.Object)followingGuard).m_CachedPtr = (IntPtr)followingGuard.enemyRenderers;
			followingGuard._placeholderLifecycle = (PlaceholderLifecycle)followingGuard.caught;
			followingGuard = (FollowingGuard)followingGuard.caught;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v51+10]");
			((Transform)0).rotation = (Quaternion)followingGuard;
			object obj9 = obj2 + 1;
			obj2 = obj9;
		}
		DefaultAnimations defaultAnimations = this.defaultAnimations;
		string[] array2 = followingGuard.ReturnRandomAnimations(defaultAnimations.introGuard, defaultAnimations.introDog);
		AnimationState animationState = guardAnimation.get_Item(array2[0]);
		animationState.time = 0f;
		bool flag = guardAnimation.Play(array2[0]);
		AnimationState animationState2 = dogAnimation.get_Item(array2[1]);
		animationState2.time = 0f;
		bool flag2 = dogAnimation.Play(array2[1]);
		DefaultAnimations defaultAnimations2 = this.defaultAnimations;
		string[] array3 = followingGuard.ReturnRandomAnimations(defaultAnimations2.runGuard, defaultAnimations2.runDog);
		AnimationState animationState3 = guardAnimation.CrossFadeQueued(array3[0], 0.2f);
		AnimationState animationState4 = dogAnimation.CrossFadeQueued(array3[1], 0.2f);
	}

	private string[] ReturnRandomAnimations(AnimationClip[] guardAnimations, AnimationClip[] dogAnimations)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		if (guardAnimations != null)
		{
			int num = UnityEngine.Random.Range(0, guardAnimations.Length);
			int num2 = num << 2;
			object obj = guardAnimations + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v22+10]");
			string text = ((UnityEngine.Object)0).name;
		}
		else
		{
			string text = string.Empty;
		}
		throw new ArrayTypeMismatchException();
	}

	private void OnChangeTrack(Character.OnChangeTrackDirection direction)
	{
		//IL_0041: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		if (caught)
		{
			return;
		}
		if (characterController.isGrounded)
		{
			object obj = 56;
			if (direction == Character.OnChangeTrackDirection.Left)
			{
				obj = 48;
			}
			object guardAnimations = (object)this.defaultAnimations + obj;
			object obj2 = 60;
			if (direction == Character.OnChangeTrackDirection.Left)
			{
				obj2 = 52;
			}
			object dogAnimations = (object)this.defaultAnimations + obj2;
			string[] array = ReturnRandomAnimations((AnimationClip[])guardAnimations, (AnimationClip[])dogAnimations);
			AnimationState animationState = guardAnimation.get_Item(array[0]);
			Game game = this.game;
			Game.SpeedInfo speed = game.speed;
			float speed2 = game.__currentSpeed / speed.min;
			animationState.speed = speed2;
			AnimationState animationState2 = dogAnimation.get_Item(array[1]);
			Game game2 = this.game;
			Game.SpeedInfo speed3 = game2.speed;
			float speed4 = game2.__currentSpeed / speed3.min;
			animationState2.speed = speed4;
			guardAnimation.CrossFade(array[0], 0.1f);
			dogAnimation.CrossFade(array[1], 0.1f);
		}
		Character character = this.character;
		if (!character.__isJumping)
		{
			DefaultAnimations defaultAnimations = this.defaultAnimations;
			string[] array2 = ReturnRandomAnimations(defaultAnimations.runGuard, defaultAnimations.runDog);
			AnimationState animationState3 = guardAnimation.CrossFadeQueued(array2[0], 0.1f);
			AnimationState animationState4 = dogAnimation.CrossFadeQueued(array2[1], 0.1f);
		}
	}

	private void OnRoll()
	{
		DefaultAnimations defaultAnimations = this.defaultAnimations;
		string[] array = ReturnRandomAnimations(defaultAnimations.rollGuard, defaultAnimations.rollDog);
		guardAnimation.CrossFade(array[0], 0.1f);
		dogAnimation.CrossFade(array[1], 0.1f);
		DefaultAnimations defaultAnimations2 = this.defaultAnimations;
		string[] array2 = ReturnRandomAnimations(defaultAnimations2.runGuard, defaultAnimations2.runDog);
		AnimationState animationState = guardAnimation.CrossFadeQueued(array2[0], 0.2f);
		AnimationState animationState2 = dogAnimation.CrossFadeQueued(array2[1], 0.2f);
	}

	private void OnRollNoAnimation()
	{
		Game game = this.game;
		float delay = distanceToCharacter / game.__currentSpeed;
		IEnumerator routine = RollCoroutine(delay);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator RollCoroutine(float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void OnJump(float jumpHeight, bool willPlaySound)
	{
		Game game = this.game;
		float delay = distanceToCharacter / game.__currentSpeed;
		Jump(delay);
	}

	public void Jump(float delay)
	{
		if (!(distanceToCharacter > distanceToCharacterMin))
		{
			MissionsManager missionsManager = MissionsManager.Instance;
			missionsManager.PlayerDidThis(MissionTarget.GuardJump);
		}
		IEnumerator routine = JumpCoroutine(delay);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator JumpCoroutine(float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void JumpAnimation()
	{
		DefaultAnimations defaultAnimations = this.defaultAnimations;
		string[] array = ReturnRandomAnimations(defaultAnimations.jumpGuard, defaultAnimations.jumpDog);
		bool flag = guardAnimation.Play(array[0]);
		bool flag2 = dogAnimation.Play(array[1]);
		DefaultAnimations defaultAnimations2 = this.defaultAnimations;
		string[] array2 = ReturnRandomAnimations(defaultAnimations2.runGuard, defaultAnimations2.runDog);
		AnimationState animationState = guardAnimation.CrossFadeQueued(array2[0], 0.3f);
		AnimationState animationState2 = dogAnimation.CrossFadeQueued(array2[1], 0.3f);
	}

	private void HandleOnHangtime()
	{
	}

	private IEnumerator HangtimeCoroutine(float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void HandleOnLanding(Transform characterTransform)
	{
		Game game = this.game;
		float delay = distanceToCharacter / game.__currentSpeed;
		IEnumerator routine = LandingCoroutine(delay);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator LandingCoroutine(float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void CatchPlayer(float pos)
	{
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02d1: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_032c: Expected Obj, but got I
		//IL_033d: Expected Obj, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0387: Expected Obj, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got I
		//IL_04b7: Expected Obj, but got I
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		//IL_04e6: Expected Obj, but got I
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		if (game.IsInPogostickMode)
		{
			return;
		}
		AudioSource component = GetComponent<AudioSource>();
		component.Stop();
		StopAllCoroutines();
		caught = true;
		CatchAnimationSet[] array = caughtLeft;
		int num;
		int num2;
		if (debugCatchAnimationToPlay >= 0)
		{
			bool flag = debugCatchAnimationToPlay < array.Length;
			num = debugCatchAnimationToPlay;
			num2 = debugCatchAnimationToPlay;
			if (flag)
			{
				goto IL_00ff;
			}
		}
		int num3 = UnityEngine.Random.Range(0, array.Length);
		bool flag2 = debugCatchAnimationToPlay > -1;
		num = debugCatchAnimationToPlay;
		num2 = num3;
		if (flag2)
		{
			goto IL_00ff;
		}
		CatchAnimationSet[] array2 = caughtRight;
		num2 = num3;
		int maxExclusive = array2.Length;
		goto IL_0139;
		IL_045f:
		throw new ArgumentException();
		IL_0437:
		int num5;
		object obj7;
		if (pos < 20f)
		{
			int num4 = num5 << 2;
			object obj = caughtLeft + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v39+10]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v40+C]");
			string animation = ((UnityEngine.Object)0).name;
			guardAnimation.CrossFade(animation, 0.2f);
			int num6 = num5 << 2;
			object obj3 = caughtLeft + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v45+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v46+10]");
			string animation2 = ((UnityEngine.Object)0).name;
			dogAnimation.CrossFade(animation2, 0.2f);
			int num7 = num5 << 2;
			object obj5 = caughtLeft + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v60+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v61+14]");
			float num8 = 0f / 25f;
			bool flag3 = OnCatchPlayer == null;
			float num9 = num8;
			if (flag3)
			{
				goto IL_045f;
			}
			obj7 = this + 16;
			num9 = num8;
			OnCatchPlayerDelegate onCatchPlayer = OnCatchPlayer;
		}
		else
		{
			int num10 = num << 2;
			object obj8 = caughtRight + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v23+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v24+C]");
			string animation3 = ((UnityEngine.Object)0).name;
			guardAnimation.CrossFade(animation3, 0.2f);
			int num11 = num << 2;
			object obj10 = caughtRight + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v29+10]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v30+10]");
			string animation4 = ((UnityEngine.Object)0).name;
			dogAnimation.CrossFade(animation4, 0.2f);
			int num12 = num << 2;
			object obj12 = caughtRight + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v45+10]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v46+14]");
			float num13 = 0f / 25f;
			bool flag4 = OnCatchPlayer == null;
			float num9 = num13;
			if (flag4)
			{
				goto IL_045f;
			}
			obj7 = this + 20;
			num9 = num13;
			num5 = num;
			OnCatchPlayerDelegate onCatchPlayer = OnCatchPlayer;
		}
		int num14 = num5 << 2;
		object obj14 = obj7 + num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v28+10]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v29+8]");
		string text = ((UnityEngine.Object)0).name;
		int num15 = num5 << 2;
		object obj16 = obj7 + num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S3_v5+10]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v229.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_045f;
		IL_0139:
		int num16 = UnityEngine.Random.Range(0, maxExclusive);
		num = num16;
		num5 = num2;
		goto IL_0437;
		IL_00ff:
		CatchAnimationSet[] array3 = caughtRight;
		bool flag5 = num < array3.Length;
		maxExclusive = array3.Length;
		num5 = num2;
		if (!flag5)
		{
			goto IL_0139;
		}
		goto IL_0437;
	}

	public void HitByTrainSequence()
	{
		AudioSource component = GetComponent<AudioSource>();
		component.Stop();
		IEnumerator routine = HitByTrainSequenceCoroutine();
		Coroutine coroutine = StartCoroutine(routine);
	}

	public IEnumerator HitByTrainSequenceCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void ShowEnemies(bool vis)
	{
		//IL_0028: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		caught = false;
		isShowing = vis;
		Renderer[] array = enemyRenderers;
		object obj = 0;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v11+10]");
			GameObject gameObject = ((Component)0).gameObject;
			gameObject.SetActive(vis);
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	public unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003c: Expected F4, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Ref, but got Unknown
		//IL_01b2: Expected I, but got Obj
		//IL_0220: Expected F4, but got I
		//IL_021b: Expected native int or pointer, but got VT
		//IL_0246: Expected F4, but got I
		//IL_0241: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		SmoothDampFloat smoothDampFloat = x;
		Vector3 currentTransformPosition = this.character.CurrentTransformPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		smoothDampFloat._target = 0f;
		x.Update();
		Character character = this.character;
		ref float currentVelocity = ref *(float*)(this + 116);
		float deltaTime = Time.deltaTime;
		float num3;
		float num4;
		if ((lastGroundedSmooth = Mathf.SmoothDamp(lastGroundedSmooth, character.LastGroundedY, ref currentVelocity, lastGroundedSmoothTime, float.PositiveInfinity, deltaTime)) < y)
		{
			float deltaTime2 = Time.deltaTime;
			float num = gravity * deltaTime2;
			float num2 = (verticalSpeed -= num);
			num3 = y;
			num4 = num2;
		}
		else
		{
			num4 = verticalSpeed;
			num3 = y;
		}
		float deltaTime3 = Time.deltaTime;
		float num5 = num4 * deltaTime3;
		float num6 = num3 + num5;
		if (!(num6 > lastGroundedSmooth))
		{
			num6 = lastGroundedSmooth;
		}
		y = num6;
		Vector3 position = characterTransform.position;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v27 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num8 = 0;
		SmoothDampFloat smoothDampFloat2 = x;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v28 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		float num9 = 0f * distanceToCharacter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num10 = 0f - num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = y;
		_ = smoothDampFloat2._value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.position = vector;
	}

	public void OnValidate()
	{
		PlaceholderLifecycle component = GetComponent<PlaceholderLifecycle>();
		_placeholderLifecycle = component;
	}

	public FollowingGuard()
	{
		//IL_000f: Expected I4, but got I8
	}

	private void _003CCatchUp_003Eb__58_1(float t)
	{
		AudioSource component = GetComponent<AudioSource>();
		float volume;
		if (Settings.optionSfx)
		{
			float num = Math.Min(t, 1f);
			bool flag = t < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			float num3 = num2 * -2f;
			float num4 = num3 * num2;
			float num5 = num4 * num2;
			float num6 = num2 * 3f;
			float num7 = num6 * num2;
			float num8 = num5 + num7;
			float num9 = guardProximityLoopVolume * num8;
			float num10 = 1f - num8;
			float num11 = num10 * 0f;
			volume = num9 + num11;
		}
		else
		{
			volume = 0f;
		}
		component.volume = volume;
	}

	private void _003CResetCatchUpCoroutine_003Eb__61_1(float t)
	{
		AudioSource component = GetComponent<AudioSource>();
		float volume;
		if (Settings.optionSfx)
		{
			float num = Math.Min(t, 1f);
			bool flag = t < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			float num3 = num2 * -2f;
			float num4 = num3 * num2;
			float num5 = num4 * num2;
			float num6 = num2 * 3f;
			float num7 = num6 * num2;
			float num8 = num5 + num7;
			float num9 = num8 * 0f;
			float num10 = 1f - num8;
			float num11 = guardProximityLoopVolume * num10;
			volume = num9 + num11;
		}
		else
		{
			volume = 0f;
		}
		component.volume = volume;
	}

	private unsafe void _003CCatchPlayer_003Eb__77_0(float t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_009c: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I
		//IL_0197: Expected F4, but got I
		//IL_0192: Expected native int or pointer, but got VT
		//IL_01b6: Expected F4, but got I
		//IL_01b1: Expected native int or pointer, but got VT
		//IL_01cb: Expected Obj, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		float num = Math.Min(t, 1f);
		bool flag = t < 0f;
		float num2 = 0f;
		if (!flag)
		{
			num2 = num;
		}
		object obj2 = default;
		object obj10 = default;
		while (true)
		{
			Transform[] array = enemies;
			if (array.Length > (nint)obj2)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				object obj5 = obj2 << 2;
				object obj6 = (object)enemies + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v12+10]");
				Vector3 position = ((Transform)0).position;
				Vector3 currentTransformPosition = character.CurrentTransformPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				object obj7 = num3 - 0;
				float num4 = (float)obj7 * num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				float num5 = 0f + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				object obj8 = num6 - 0;
				float num7 = (float)obj8 * num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				float num8 = 0f + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				object obj9 = num9 - 0;
				float num10 = (float)obj9 * num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				float num11 = 0f + num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v13+10]");
				((Transform)0).position = vector;
				obj2 = obj10 + 1;
				continue;
			}
			break;
		}
	}
}
