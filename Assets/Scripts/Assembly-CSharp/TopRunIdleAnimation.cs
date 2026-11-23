using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class TopRunIdleAnimation : MonoBehaviour
{
	[Serializable]
	public class AnimationElement
	{
		public AnimationClip clip;

		public int propability = 1;
	}

	public delegate void AnimationFinishDelegate();

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public AnimationClip selectedClip;

		public Predicate<AnimationClip> _003C_003E9__0;

		internal bool _003CPlayTRIdles_003Eb__0(AnimationClip a)
		{
			return a != selectedClip;
		}
	}

	private sealed class _003CPlayTRIdles_003Ed__21(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TopRunIdleAnimation _003C_003E4__this;

		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_011b: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got I4
			//IL_0242: Expected Obj, but got I4
			//IL_0250: Expected Obj, but got I4
			TopRunIdleAnimation topRunIdleAnimation = _003C_003E4__this;
			float num;
			object obj;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						goto IL_0286;
					}
					_003C_003E1__state = -1;
					num = topRunIdleAnimation.nextAnimationTime;
					obj = 1;
					goto IL_02b2;
				}
				_003C_003E1__state = -1;
				num = topRunIdleAnimation.nextAnimationTime;
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003Ec__DisplayClass21_0 obj2 = default;
				_003C_003E8__1 = obj2;
				_003C_003Ec__DisplayClass21_0 obj3 = _003C_003E8__1;
				obj3.selectedClip = null;
				string name = topRunIdleAnimation.topRunStart.name;
				bool flag = topRunIdleAnimation.Target.Play(name);
				num = (topRunIdleAnimation.nextAnimationTime = topRunIdleAnimation.topRunStart.length);
			}
			bool flag2 = num > 0f;
			int num2 = 1;
			if (!flag2)
			{
				obj = 0;
				goto IL_02b2;
			}
			goto IL_0358;
			IL_0286:
			return true;
			IL_02b2:
			object obj4 = obj;
			while (true)
			{
				if (obj4 == null)
				{
					if (~(topRunIdleAnimation.PlayIdleAnimations ? 1u : 0u) != 0)
					{
						break;
					}
					_003C_003Ec__DisplayClass21_0 obj5 = _003C_003E8__1;
					bool flag3 = obj5._003C_003E9__0 == null;
					bool flag4 = !flag3;
					Predicate<AnimationClip> match = obj5._003C_003E9__0;
					if (!flag4)
					{
						throw new ArgumentException();
					}
					List<AnimationClip> list = topRunIdleAnimation.topRunIdles.FindAll(match);
					if (list._size >= 1)
					{
						_003C_003Ec__DisplayClass21_0 obj6 = _003C_003E8__1;
						int index = UnityEngine.Random.Range(0, list._size);
						AnimationClip selectedClip = list.get_Item(index);
						obj6.selectedClip = selectedClip;
					}
					_003C_003Ec__DisplayClass21_0 obj7 = _003C_003E8__1;
					string name2 = obj7.selectedClip.name;
					bool flag5 = topRunIdleAnimation.Target.Play(name2);
					_003C_003Ec__DisplayClass21_0 obj8 = _003C_003E8__1;
					float num3 = (topRunIdleAnimation.nextAnimationTime = obj8.selectedClip.length);
					obj4 = 1;
					num = num3;
					continue;
				}
				if (num > 0f)
				{
					goto IL_022b;
				}
				obj4 = 0;
			}
			goto IL_0286;
			IL_022b:
			num2 = 2;
			goto IL_0358;
			IL_0358:
			float deltaTime = Time.deltaTime;
			float nextAnimationTime = num - deltaTime;
			topRunIdleAnimation.nextAnimationTime = nextAnimationTime;
			_003C_003E2__current = null;
			_003C_003E1__state = num2;
			goto IL_0286;
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

	private sealed class _003CPlayTRmiss_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TopRunIdleAnimation _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			TopRunIdleAnimation topRunIdleAnimation = _003C_003E4__this;
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_018d;
				}
				_003C_003E1__state = -1;
				num = topRunIdleAnimation.nextAnimationTime;
			}
			else
			{
				_003C_003E1__state = -1;
				List<AnimationClip> topRunHandMiss = topRunIdleAnimation.topRunHandMiss;
				int index = UnityEngine.Random.Range(0, topRunHandMiss._size);
				AnimationClip animationClip = topRunHandMiss.get_Item(index);
				string name = animationClip.name;
				topRunIdleAnimation.Target.CrossFade(name, 0.1f);
				num = (topRunIdleAnimation.nextAnimationTime = animationClip.length);
			}
			if (!(num > 0.25f))
			{
				topRunIdleAnimation.PlayIdleAnimations = false;
				AnimationFinishDelegate animationFinished = topRunIdleAnimation.m_AnimationFinished;
				if (topRunIdleAnimation.m_AnimationFinished != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v96.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				goto IL_018d;
			}
			float deltaTime = Time.deltaTime;
			float nextAnimationTime = num - deltaTime;
			topRunIdleAnimation.nextAnimationTime = nextAnimationTime;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_018d:
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

	private sealed class _003CPlayTRhit_003Ed__23(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TopRunIdleAnimation _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			TopRunIdleAnimation topRunIdleAnimation = _003C_003E4__this;
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_018d;
				}
				_003C_003E1__state = -1;
				num = topRunIdleAnimation.nextAnimationTime;
			}
			else
			{
				_003C_003E1__state = -1;
				List<AnimationClip> topRunHandHitWeighted = topRunIdleAnimation.topRunHandHitWeighted;
				int index = UnityEngine.Random.Range(0, topRunHandHitWeighted._size);
				AnimationClip animationClip = topRunHandHitWeighted.get_Item(index);
				string name = animationClip.name;
				topRunIdleAnimation.Target.CrossFade(name, 0.1f);
				num = (topRunIdleAnimation.nextAnimationTime = animationClip.length);
			}
			if (!(num > 0.25f))
			{
				topRunIdleAnimation.PlayIdleAnimations = false;
				AnimationFinishDelegate animationFinished = topRunIdleAnimation.m_AnimationFinished;
				if (topRunIdleAnimation.m_AnimationFinished != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v96.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				goto IL_018d;
			}
			float deltaTime = Time.deltaTime;
			float nextAnimationTime = num - deltaTime;
			topRunIdleAnimation.nextAnimationTime = nextAnimationTime;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_018d:
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

	private Animation Target;

	public bool PlayIdleAnimations;

	public bool paused;

	private IEnumerator animationRoutine;

	private float nextAnimationTime;

	public AnimationClip topRunStart;

	public List<AnimationClip> topRunIdles;

	public List<AnimationClip> topRunHandMiss;

	public List<AnimationElement> topRunHandHit;

	private List<AnimationClip> topRunHandHitWeighted;

	private AnimationFinishDelegate m_AnimationFinished;

	public event AnimationFinishDelegate AnimationFinished
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_AnimationFinished;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_AnimationFinished;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private void Awake()
	{
		do
		{
			GameObject current = gameObject;
			Animation target = FindAnimationInParent(current);
			Target = target;
		}
		while (Target == null);
	}

	private Animation FindAnimationInParent(GameObject current)
	{
		UnityEngine.Object obj = default;
		UnityEngine.Object result;
		GameObject gameObject = default;
		while (true)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			bool flag = obj == null;
			result = obj;
			if (flag)
			{
				Transform transform = gameObject.transform;
				Transform parent = transform.parent;
				bool flag2 = parent != null;
				bool flag3 = !flag2;
				result = null;
				if (flag3)
				{
					break;
				}
				Transform transform2 = gameObject.transform;
				Transform parent2 = transform2.parent;
				gameObject = parent2.gameObject;
				continue;
			}
			break;
		}
		return (Animation)result;
	}

	private void Update()
	{
		if (~(PlayIdleAnimations ? 1u : 0u) == 0 && animationRoutine != null && !paused)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		}
	}

	public void TR_ActivateIdle()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_031f: Expected Obj, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		PlayIdleAnimations = true;
		string newName = topRunStart.name;
		Target.AddClip(topRunStart, newName);
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		TopRunIdleAnimation topRunIdleAnimation = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 == obj8;
			bool flag2 = !flag;
			object obj9 = obj10;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			topRunIdleAnimation = (TopRunIdleAnimation)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		IEnumerator enumerator = ((TopRunIdleAnimation)0).PlayTRIdles();
		topRunIdleAnimation.animationRoutine = enumerator;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
	}

	public void TR_PlayMiss()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02eb: Expected Obj, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		TopRunIdleAnimation topRunIdleAnimation = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 == obj8;
			bool flag2 = !flag;
			object obj9 = obj10;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			topRunIdleAnimation = (TopRunIdleAnimation)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		IEnumerator enumerator = ((TopRunIdleAnimation)0).PlayTRmiss();
		topRunIdleAnimation.animationRoutine = enumerator;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
	}

	public void TR_PlayHit()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0277: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Obj, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_04bf: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0442: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_0191;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj8 = 0;
					while (true)
					{
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v150+C]");
						if ((nint)obj9 >= 0)
						{
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj10 = obj8 + 1;
							obj8 = obj10;
							continue;
						}
						goto IL_00f3;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0102;
			IL_0102:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj11 != obj12;
			object obj13 = obj14;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0191;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj13 = obj15;
			}
			_ = 0;
			object obj16 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			TopRunIdleAnimation topRunIdleAnimation = (TopRunIdleAnimation)0;
			if (flag2)
			{
				goto IL_04d5;
			}
			object obj17 = obj13;
			goto IL_04ff;
			IL_04ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_0191:
			object obj18 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AE83");
			object obj19 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj20 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj21 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					bool flag3 = obj22 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj13 = 0;
					if (flag3)
					{
						break;
					}
					_ = 0;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj23 == obj24;
				bool flag5 = !flag4;
				obj13 = obj25;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj13 = 0;
					if (flag6)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj13 = obj26;
				}
				goto IL_0471;
			}
			break;
			IL_0471:
			_ = 0;
			object obj27 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			topRunIdleAnimation = (TopRunIdleAnimation)0;
			obj17 = obj13;
			if (!flag7)
			{
				goto IL_04d5;
			}
			goto IL_04ff;
			IL_00f3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0102;
			IL_04d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
		}
		object obj28 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD0");
		IEnumerator enumerator = PlayTRhit();
		animationRoutine = enumerator;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
	}

	private IEnumerator PlayTRIdles()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator PlayTRmiss()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator PlayTRhit()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public TopRunIdleAnimation()
	{
		List<AnimationClip> list = default;
		list._002Ector();
		topRunHandHitWeighted = list;
		base._002Ector();
	}
}
