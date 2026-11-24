using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using UnityEngine;

public class TopRunIdleAnimation : MonoBehaviour
{
	[Serializable]
	public class AnimationElement
	{
		public AnimationClip clip;

		public int propability;
	}

	[Serializable]
	public class TopRunAnimationSettings
	{
		public string name;

		public AnimationClip topRunStart = (AnimationClip)1;

		public List<AnimationClip> topRunIdles;

		public List<AnimationClip> topRunHandMiss;

		public List<AnimationElement> topRunHandHit;

		public TopRunAnimationSettings()
		{
			//IL_000b: Expected Obj, but got I4
		}
	}

	public delegate void AnimationFinishDelegate();

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public AnimationClip selectedClip;

		public _003C_003Ec__DisplayClass21_0()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_0380: Expected Obj, but got I
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_038e: Expected Obj, but got Unknown
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_02b7: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunIdleAnimation+<>c__DisplayClass21_0)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunIdleAnimation+<>c__DisplayClass21_0)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunIdleAnimation+<>c__DisplayClass21_0)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunIdleAnimation+<>c__DisplayClass21_0)+C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
							object obj19 = (nint)0 & (nint)3;
							bool flag3 = (nint)obj19 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag3)
							{
								if (obj20 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
								}
							}
							else if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
							}
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}

		internal bool _003CPlayTRIdles_003Eb__0(AnimationClip a)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)((ComputeShader)(object)a).FindKernel((string)(object)selectedClip) != 0;
		}
	}

	private sealed class _003CPlayTRIdles_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TopRunIdleAnimation _003C_003E4__this;

		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		private TopRunAnimationSettings _003CaSettings_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0454: Expected Obj, but got I4
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected Obj, but got Unknown
				//IL_0089: Expected Obj, but got I4
				//IL_009f: Expected Obj, but got I4
				//IL_01a5: Invalid comparison between Obj and F4
				//IL_022d: Expected Obj, but got I4
				//IL_0184: Expected Obj, but got I4
				//IL_01ee: Expected Obj, but got F4
				//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f9: Expected Obj, but got Unknown
				//IL_0202: Expected Obj, but got I4
				//IL_0216: Expected Obj, but got I4
				//IL_021f: Expected Obj, but got I4
				//IL_0192: Expected Obj, but got I4
				//IL_0240: Invalid comparison between Obj and F4
				//IL_02a2: Expected Obj, but got F4
				//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ad: Expected Obj, but got Unknown
				//IL_02b6: Expected Obj, but got I4
				//IL_02ca: Expected Obj, but got I4
				//IL_02d3: Expected Obj, but got I4
				//IL_0361: Unknown result type (might be due to invalid IL or missing references)
				//IL_0366: Expected Obj, but got Unknown
				//IL_0273: Expected Obj, but got I4
				//IL_033b: Expected Obj, but got I4
				//IL_0407: Expected Obj, but got F4
				//IL_0410: Expected Obj, but got I4
				//IL_0419: Expected F4, but got I4
				//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03be: Expected Obj, but got Unknown
				//IL_03d1: Expected I4, but got Obj
				object obj = 0;
				TopRunIdleAnimation topRunIdleAnimation = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					object obj2;
					object result = default;
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							obj2 = 13;
						}
						else
						{
							obj2 = 15;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						if (System.Runtime.CompilerServices.Unsafe.As<DoubleScoreMultiplier, UIntPtr>(ref ((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
						{
							float unscaledTime = Time.unscaledTime;
							float num = (float)((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier - unscaledTime;
							((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier = (DoubleScoreMultiplier)num;
							object obj3 = this + 12;
							obj3 = 0;
							_003C_003E1__state = 1;
							result = 1;
							obj2 = 15;
						}
						else
						{
							obj2 = 14;
						}
					}
					object obj4 = obj2;
					object obj7 = default;
					while (true)
					{
						if ((nint)obj4 == 13)
						{
							if (System.Runtime.CompilerServices.Unsafe.As<DoubleScoreMultiplier, UIntPtr>(ref ((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
							{
								obj4 = 14;
								continue;
							}
							float unscaledTime = Time.unscaledTime;
							float num2 = (float)((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier - unscaledTime;
							((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier = (DoubleScoreMultiplier)num2;
							object obj5 = this + 12;
							obj5 = 0;
							_003C_003E1__state = 2;
							result = 1;
							obj4 = 15;
						}
						else if ((nint)obj4 == 14)
						{
							if ((object)((CharacterModifierCollection)(object)topRunIdleAnimation).superSneakers == null)
							{
								result = null;
								obj4 = 15;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num3 = 0;
							_ = 0;
							object obj6 = obj7 + 16;
							obj6 = _003C_003E8__1;
							NullReferenceException ex = new NullReferenceException();
							if ((nint)((Exception)ex)._message >= 1)
							{
								object obj8 = _003C_003E8__1 + 8;
								int index = UnityEngine.Random.RandomRangeInt(0, (int)((Exception)ex)._message);
								AnimationClip animationClip = ((List<AnimationClip>)(object)ex).get_Item(index);
								obj8 = animationClip;
							}
							_003C_003Ec__DisplayClass21_0 obj9 = _003C_003E8__1;
							UnityEngine.Object animation = UnityEngine.Object.Instantiate((UnityEngine.Object)obj9.selectedClip);
							AnimationState animationState = ((Animation)(object)((CharacterModifierCollection)(object)topRunIdleAnimation).coinMagnet).CrossFadeQueued((string)(object)animation);
							_003C_003Ec__DisplayClass21_0 obj10 = _003C_003E8__1;
							float frameRate = obj10.selectedClip.frameRate;
							((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier = (DoubleScoreMultiplier)frameRate;
							obj4 = 13;
							float unscaledTime = 0f;
						}
						else if ((nint)obj4 == 15)
						{
							break;
						}
					}
					return result;
				}
				_003C_003E1__state = -1;
				object obj11 = this + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj12 = default;
				obj11 = obj12;
				object obj13 = _003C_003E8__1 + 8;
				obj13 = 0;
				Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
				obj = currentBoardId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CPlayTRIdles_003Ed__21(int _003C_003E1__state)
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

	private sealed class _003CPlayTRmiss_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TopRunIdleAnimation _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0205: Expected Obj, but got I4
				//IL_0045: Expected Obj, but got I4
				//IL_0141: Invalid comparison between Obj and F4
				//IL_018a: Expected Obj, but got F4
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_0195: Expected Obj, but got Unknown
				//IL_019e: Expected Obj, but got I4
				//IL_01b2: Expected Obj, but got I4
				object obj = 0;
				TopRunIdleAnimation topRunIdleAnimation = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						if (System.Runtime.CompilerServices.Unsafe.As<DoubleScoreMultiplier, UIntPtr>(ref ((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.25f))
						{
							float unscaledTime = Time.unscaledTime;
							float num = (float)((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier - unscaledTime;
							((CharacterModifierCollection)(object)topRunIdleAnimation).doubleScoreMultiplier = (DoubleScoreMultiplier)num;
							object obj2 = this + 12;
							obj2 = 0;
							_003C_003E1__state = 1;
							return 1;
						}
						((CharacterModifierCollection)(object)topRunIdleAnimation).superSneakers = null;
						if (((CharacterModifierCollection)(object)topRunIdleAnimation).modifiers != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
				obj = currentBoardId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
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

	private sealed class _003CPlayTRhit_003Ed__23(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TopRunIdleAnimation _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0132: Unknown result type (might be due to invalid IL or missing references)
				//IL_0137: Expected Obj, but got Unknown
				//IL_0140: Expected Obj, but got I4
				//IL_0154: Expected Obj, but got I4
				TopRunIdleAnimation topRunIdleAnimation = _003C_003E4__this;
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
					List<AnimationClip> topRunHandHitWeighted = topRunIdleAnimation.topRunHandHitWeighted;
					int index = UnityEngine.Random.RandomRangeInt(0, topRunHandHitWeighted._size);
					AnimationClip animationClip = topRunIdleAnimation.topRunHandHitWeighted.get_Item(index);
					UnityEngine.Object clip = UnityEngine.Object.Instantiate((UnityEngine.Object)animationClip);
					AudioSource.PlayOneShotHelper((AudioSource)(object)topRunIdleAnimation.Target, (AudioClip)clip, 0.1f);
					float frameRate = animationClip.frameRate;
					topRunIdleAnimation.nextAnimationTime = frameRate;
				}
				if (topRunIdleAnimation.nextAnimationTime > 0.25f)
				{
					float unscaledTime = Time.unscaledTime;
					float nextAnimationTime = topRunIdleAnimation.nextAnimationTime - unscaledTime;
					topRunIdleAnimation.nextAnimationTime = nextAnimationTime;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				topRunIdleAnimation.PlayIdleAnimations = false;
				if (topRunIdleAnimation.m_AnimationFinished != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
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

	private Animation Target;

	public bool PlayIdleAnimations;

	public bool paused;

	private IEnumerator animationRoutine;

	private float nextAnimationTime;

	public TopRunAnimationSettings[] animationSettings;

	private List<AnimationClip> topRunHandHitWeighted;

	private Dictionary<string, TopRunAnimationSettings> _characterToAnimationSettings;

	private AnimationFinishDelegate m_AnimationFinished;

	public event AnimationFinishDelegate AnimationFinished
	{
		add
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected Obj, but got Unknown
			//IL_00f7: Expected Obj, but got I
			//IL_0108: Expected VT, but got I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 8;
			obj = this;
			Transform transform = default;
			object obj3 = transform + 12;
			obj3 = value;
			_ = ((Delegate)value).method_ptr;
			object obj4 = obj2 + 24;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunIdleAnimation)+38]");
			int layer = ((GameObject)0).layer;
			transform.position = (Vector3)layer;
			obj3 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_AnimationFinished;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private void Awake()
	{
		//IL_000b: Expected Obj, but got F4
		//IL_0016: Expected I4, but got F4
		//IL_0021: Expected Obj, but got F4
		//IL_0037: Expected Obj, but got F4
		//IL_0042: Expected Obj, but got F4
		//IL_004d: Expected Obj, but got F4
		//IL_0056: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got F4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got F4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got F4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got F4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got F4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_025b: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got F4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		Target = (Animation)0.15f;
		PlayIdleAnimations = true;
		animationRoutine = (IEnumerator)0.4f;
		nextAnimationTime = 0.5f;
		animationSettings = (TopRunAnimationSettings[])0.5f;
		topRunHandHitWeighted = (List<AnimationClip>)0.1f;
		_characterToAnimationSettings = (Dictionary<string, TopRunAnimationSettings>)0.1f;
		object obj = 0;
		obj = 25f;
		_ = 20f;
		object obj2 = obj + 8;
		obj2 = obj;
		object obj3 = obj + 76;
		obj3 = obj2;
		object obj4 = obj - -64;
		obj4 = 0;
		_ = 0;
		obj4 = -40f;
		_ = -80f;
		_ = -200f;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
		_ = 0;
		object obj5 = this + 60;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
		_ = 0;
		object obj6 = obj + 52;
		obj6 = 0;
		_ = 0;
		obj6 = 40f;
		_ = -65f;
		_ = -200f;
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v31+8]");
		_ = 0;
		object obj7 = this + 72;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
		_ = 0;
		object obj8 = obj + 40;
		obj8 = 0;
		_ = 0;
		obj8 = 40f;
		_ = -90f;
		_ = -200f;
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v42+8]");
		_ = 0;
		object obj9 = this + 84;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
		_ = 0;
		object obj10 = obj + 28;
		obj10 = 0;
		_ = 0;
		obj10 = 10f;
		_ = -80f;
		_ = -200f;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v53+8]");
		_ = 0;
		object obj11 = this + 96;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
		_ = 0;
		_ = 0.04f;
		_ = 1f;
		_ = 0.1f;
		object obj12 = obj + 16;
		obj12 = 0;
		_ = 0;
		obj12 = -20f;
		_ = -80f;
		_ = -200f;
		obj3 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v67+8]");
		_ = 0;
		object obj13 = this + 164;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
		_ = 0;
		_ = 1;
		CancelInvoke();
	}

	private Animation FindAnimationInParent(GameObject current)
	{
		//IL_000e: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I4
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00bb: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I4
		//IL_0150: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		Animation component = default;
		string text = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			while (true)
			{
				int num2 = ((ComputeShader)(object)component).FindKernel((string)null);
				Animation result = component;
				if (num2 == 0)
				{
					int layer = ((GameObject)(object)text).layer;
					Transform parentInternal = ((Transform)layer).parentInternal;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
					{
						int layer2 = ((GameObject)(object)text).layer;
						Transform parentInternal2 = ((Transform)layer2).parentInternal;
						text = parentInternal2.tag;
						component = ((GameObject)(object)text).GetComponent<Animation>();
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							break;
						}
						continue;
					}
					result = null;
				}
				return result;
			}
		}
	}

	private void Update()
	{
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		object obj = this + 12;
		string text = tag;
		TopRunAnimationSettings annimationSettingsFor = GetAnnimationSettingsFor(text);
		obj = annimationSettingsFor;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Target != null)
		{
			SDebug.LogFormat("AvatarAnimations: No animation component for avatar animations", (object[])(object)this);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S3_v5 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S3_v6+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v64 @ S4_v5 (should have been resolved before IL gen)");
		object obj8 = this + 36;
		object obj9 = default;
		obj8 = obj9;
		object obj10 = 113696;
		object obj11 = 0;
		object obj21 = default;
		while (true)
		{
			TopRunAnimationSettings[] array = animationSettings;
			if ((nint)obj11 < array.Length)
			{
				object obj12 = animationSettings + 16;
				object obj13 = obj11 << 2;
				object obj14 = obj12 + obj13;
				object obj15 = obj14;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S2_v11 (Il2CppMethodInfo)+C]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v12+60]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v13+44]");
				object obj18 = 0;
				object obj19 = obj18 & 0x1FFF;
				object obj20 = obj19 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v135 @ S3_v14 (should have been resolved before IL gen)");
				if ((nint)obj21 <= -1)
				{
					object obj22 = animationSettings + 16;
					object obj23 = obj11 << 2;
					object obj24 = obj22 + obj23;
					object obj25 = obj24;
					object obj26 = animationSettings + 16;
					object obj27 = obj11 << 2;
					object obj28 = obj26 + obj27;
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v12 (Il2CppMethodInfo)+C]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v13+60]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S4_v14+48]");
					object obj31 = 0;
					object obj32 = obj31 & 0x7FF;
					obj10 = obj32 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98 @ S5_v5 (should have been resolved before IL gen)");
				}
				object obj33 = obj11 + 1;
				obj11 = obj33;
				continue;
			}
			break;
		}
	}

	public void TR_ActivateIdle()
	{
		if (~(PlayIdleAnimations ? 1u : 0u) == 0 && animationRoutine != null && ~(paused ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}
	}

	public void TR_PlayMiss()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Expected Obj, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02b9: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		object obj5 = obj2 + 40;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		obj5 = currentBoardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void TR_PlayHit()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		object obj5 = obj2 + 40;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		obj5 = currentBoardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private TopRunAnimationSettings GetAnnimationSettingsFor(string name)
	{
		//IL_000e: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I4
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00bb: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		ComputeShader computeShader = default;
		string text = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			while (true)
			{
				int num2 = computeShader.FindKernel(null);
				ComputeShader result = computeShader;
				if (num2 == 0)
				{
					int layer = ((GameObject)(object)text).layer;
					Transform parentInternal = ((Transform)layer).parentInternal;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
					{
						int layer2 = ((GameObject)(object)text).layer;
						Transform parentInternal2 = ((Transform)layer2).parentInternal;
						text = parentInternal2.tag;
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v3 (Il2CppMethodInfo)+18]");
						object obj2 = 0;
						object obj3 = obj2;
						object obj4 = obj3 & 0x1FFF;
						object obj5 = obj4 + 22691;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v11 @ S3_v5 (should have been resolved before IL gen)");
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							break;
						}
						continue;
					}
					result = null;
				}
				return (TopRunAnimationSettings)(object)result;
			}
		}
	}

	private IEnumerator PlayTRIdles()
	{
		//IL_0015: Expected VT, but got I
		//IL_0026: Invalid comparison between I and F4
		//IL_0031: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunIdleAnimation)+88]");
		Transform transform = default;
		transform.localPosition = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
		bool flag = 0f > 0.5f;
		return (IEnumerator)flag;
	}

	private IEnumerator PlayTRmiss()
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

	private IEnumerator PlayTRhit()
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

	public TopRunIdleAnimation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_042f: Expected Obj, but got I4
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_0446: Expected Obj, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_0463: Expected Obj, but got I4
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_0496: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		List<AnimationClip> list = (List<AnimationClip>)(obj2 + 56);
		list = (List<AnimationClip>)0;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		list = (List<AnimationClip>)currentBoardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}
}
