using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using SYBO.Components.Utilities;
using UnityEngine;

public class AvatarAnimations : MonoBehaviour
{
	private sealed class _003CPlayAnimationsInOrder_003Ed__38(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AvatarAnimations _003C_003E4__this;

		public AnimationClip[] animationClips;

		public bool useUnscaledTime;

		private AnimationClip _003CselectedClip_003E5__2;

		private int _003CanimationIndex_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0048: Expected Obj, but got I4
				//IL_006a: Expected Obj, but got I4
				//IL_0083: Expected Obj, but got I4
				//IL_0091: Expected Obj, but got I4
				//IL_04e3: Expected Obj, but got I4
				//IL_00ff: Expected Obj, but got I4
				//IL_04a7: Expected I, but got Obj
				//IL_04bd: Expected Obj, but got I
				//IL_0249: Expected Obj, but got I4
				//IL_0282: Unknown result type (might be due to invalid IL or missing references)
				//IL_0287: Expected Obj, but got Unknown
				//IL_0292: Unknown result type (might be due to invalid IL or missing references)
				//IL_0297: Expected Obj, but got Unknown
				//IL_02af: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b4: Expected Obj, but got Unknown
				//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e6: Expected Obj, but got Unknown
				//IL_03ef: Expected Obj, but got I4
				//IL_0403: Expected Obj, but got I4
				//IL_040c: Expected Obj, but got I4
				//IL_02d0: Expected I, but got Obj
				//IL_016c: Expected I4, but got Obj
				//IL_01a5: Expected Obj, but got I4
				//IL_035e: Expected Obj, but got I4
				AvatarAnimations avatarAnimations = _003C_003E4__this;
				object obj;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						obj = 17;
					}
					else
					{
						obj = 21;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					object obj2 = this + 28;
					obj2 = 0;
					_003CanimationIndex_003E5__3 = 0;
					Animation.INTERNAL_CALL_Stop(avatarAnimations._target);
					obj = 20;
				}
				object obj3 = obj;
				object result = default;
				while (true)
				{
					if ((nint)obj3 == 17)
					{
						if (avatarAnimations.nextAnimationTime > 0f)
						{
							float realtimeSinceStartup = Time.realtimeSinceStartup;
							bool flag = !(realtimeSinceStartup > 0f);
							bool flag2 = useUnscaledTime;
							object obj4 = flag | flag2;
							if (obj4 != null)
							{
								float fixedDeltaTime = Time.fixedDeltaTime;
								float nextAnimationTime = avatarAnimations.nextAnimationTime - fixedDeltaTime;
								avatarAnimations.nextAnimationTime = nextAnimationTime;
								UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)_003CselectedClip_003E5__2);
								bool flag3 = avatarAnimations._target.Play((PlayMode)obj5);
								float frameRate = _003CselectedClip_003E5__2.frameRate;
								float normalizedTime = frameRate - avatarAnimations.nextAnimationTime;
								((AnimationState)flag3).normalizedTime = normalizedTime;
								Animation.INTERNAL_CALL_Sample(avatarAnimations._target);
							}
							else
							{
								float unscaledTime = Time.unscaledTime;
								float nextAnimationTime2 = avatarAnimations.nextAnimationTime - unscaledTime;
								avatarAnimations.nextAnimationTime = nextAnimationTime2;
							}
							object obj6 = this + 12;
							obj6 = 0;
							_003C_003E1__state = 1;
							obj3 = 21;
							result = 1;
							continue;
						}
					}
					else if ((nint)obj3 == 20)
					{
						if (~(avatarAnimations.PlayIdleAnimations ? 1u : 0u) != 0)
						{
							obj3 = 21;
							result = null;
							continue;
						}
						AnimationClip[] array = animationClips;
						if (array.Length != 0)
						{
							object obj7 = this + 28;
							object obj8 = animationClips + 16;
							int num = _003CanimationIndex_003E5__3 << 2;
							object obj9 = obj8 + num;
							obj7 = obj9;
						}
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num3 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)_003CselectedClip_003E5__2).FindKernel((string)null) != 0)
						{
							UnityEngine.Object animation = UnityEngine.Object.Instantiate((UnityEngine.Object)_003CselectedClip_003E5__2);
							AnimationState animationState = avatarAnimations._target.CrossFadeQueued((string)(object)animation);
							float frameRate2 = _003CselectedClip_003E5__2.frameRate;
							avatarAnimations.nextAnimationTime = frameRate2;
							obj3 = 17;
							continue;
						}
					}
					else if ((nint)obj3 == 21)
					{
						break;
					}
					Animation.INTERNAL_CALL_Stop(avatarAnimations._target);
					int num4 = _003CanimationIndex_003E5__3 + 1;
					_003CanimationIndex_003E5__3 = num4;
					AnimationClip[] array2 = animationClips;
					if (_003CanimationIndex_003E5__3 >= array2.Length)
					{
						_003CanimationIndex_003E5__3 = 0;
					}
					obj3 = 20;
				}
				return result;
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

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public AnimationClip selectedClip;

		public Predicate<AnimationClip> _003C_003E9__0;

		public Predicate<AnimationClip> _003C_003E9__1;

		public _003C_003Ec__DisplayClass39_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal bool _003CPlay_003Eb__0(AnimationClip a)
		{
			//IL_000d: Expected I4, but got Obj
			return (byte)(int)((Renderer)(object)a).sharedMaterial != 0;
		}

		internal bool _003CPlay_003Eb__1(AnimationClip a)
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

	private sealed class _003CPlay_003Ed__39(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AvatarAnimations _003C_003E4__this;

		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

		private string _003CclipName_003E5__2;

		private int _003Ccount_003E5__3;

		private int _003Ci_003E5__4;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Expected Obj, but got Unknown
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Expected Obj, but got Unknown
				//IL_00a8: Expected Obj, but got I4
				//IL_0127: Expected Obj, but got I4
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e2: Expected Obj, but got Unknown
				//IL_0190: Expected I4, but got Obj
				//IL_019d: Expected Obj, but got I4
				//IL_01be: Expected F4, but got I4
				//IL_0150: Expected Obj, but got I4
				//IL_0908: Unknown result type (might be due to invalid IL or missing references)
				//IL_090d: Expected Obj, but got Unknown
				//IL_0916: Expected Obj, but got I4
				//IL_091f: Expected Obj, but got I4
				//IL_01e0: Expected I4, but got Obj
				//IL_01ed: Expected Obj, but got I4
				//IL_0169: Expected Obj, but got I4
				//IL_0222: Expected I4, but got Obj
				//IL_0407: Expected I4, but got F4
				//IL_0410: Expected F4, but got I4
				//IL_07ba: Expected F4, but got I4
				//IL_0306: Unknown result type (might be due to invalid IL or missing references)
				//IL_030b: Expected Obj, but got Unknown
				//IL_0314: Expected Obj, but got I4
				//IL_0328: Expected Obj, but got I4
				//IL_0331: Expected Obj, but got I4
				//IL_025b: Expected F4, but got I4
				//IL_0177: Expected Obj, but got I4
				//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c0: Expected Obj, but got Unknown
				//IL_03c9: Expected Obj, but got I4
				//IL_03dd: Expected Obj, but got I4
				//IL_03e6: Expected Obj, but got I4
				//IL_0777: Expected Obj, but got I4
				//IL_07db: Expected I, but got Obj
				//IL_07f1: Expected Obj, but got I
				//IL_046d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0472: Expected Obj, but got Unknown
				//IL_047b: Expected Obj, but got I4
				//IL_0484: Expected Obj, but got I4
				//IL_026f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0274: Expected Obj, but got Unknown
				//IL_027d: Expected Obj, but got I4
				//IL_0291: Expected Obj, but got I4
				//IL_029b: Expected F4, but got I4
				//IL_02a4: Expected Obj, but got I4
				//IL_07c8: Expected Obj, but got I4
				//IL_08b0: Expected Obj, but got I4
				//IL_08b9: Expected F4, but got I4
				//IL_081c: Expected I, but got Obj
				//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05ed: Expected Obj, but got Unknown
				//IL_0602: Unknown result type (might be due to invalid IL or missing references)
				//IL_0607: Expected Obj, but got Unknown
				//IL_0503: Unknown result type (might be due to invalid IL or missing references)
				//IL_0508: Expected Obj, but got Unknown
				//IL_051d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0522: Expected Obj, but got Unknown
				//IL_0a4b: Expected I, but got Obj
				//IL_0a61: Expected Obj, but got I
				//IL_09b1: Expected F4, but got I4
				//IL_0620: Unknown result type (might be due to invalid IL or missing references)
				//IL_0625: Expected Obj, but got Unknown
				//IL_0638: Expected I4, but got Obj
				//IL_066f: Expected I, but got Obj
				//IL_0717: Expected Obj, but got I4
				//IL_0720: Expected F4, but got I4
				AvatarAnimations avatarAnimations = _003C_003E4__this;
				object obj;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						goto IL_017c;
					}
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state == 3)
						{
							_003C_003E1__state = -1;
							obj = 40;
						}
						else
						{
							obj = 45;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						obj = 29;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					object obj2 = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj3 = default;
					obj2 = obj3;
					object obj4 = _003C_003E8__1 + 8;
					obj4 = 0;
					Animation.INTERNAL_CALL_Stop(avatarAnimations._target);
					if (~(avatarAnimations.useStartClip ? 1u : 0u) == 0)
					{
						object obj5 = this + 24;
						UnityEngine.Object obj6 = UnityEngine.Object.Instantiate((UnityEngine.Object)avatarAnimations.startClip);
						obj5 = obj6;
						AnimationState animationState = avatarAnimations._target.CrossFadeQueued(_003CclipName_003E5__2);
						goto IL_017c;
					}
					obj = 43;
				}
				goto IL_08e7;
				IL_017c:
				bool flag = avatarAnimations._target.Play((PlayMode)_003CclipName_003E5__2);
				WrapMode wrapMode = ((AnimationState)flag).wrapMode;
				bool flag2 = wrapMode == WrapMode.Default;
				float num = 0f;
				object result = default;
				if (!flag2)
				{
					bool flag3 = avatarAnimations._target.Play((PlayMode)_003CclipName_003E5__2);
					float normalizedTime = ((AnimationState)flag3).normalizedTime;
					float unscaledTime = Time.unscaledTime;
					float num2 = normalizedTime + unscaledTime;
					bool flag4 = avatarAnimations._target.Play((PlayMode)_003CclipName_003E5__2);
					float distance = (flag4 ? ((RaycastHit*)1) : ((RaycastHit*)null))->distance;
					bool flag5 = num2 < distance;
					bool flag6 = !flag5;
					num = 0f;
					if (!flag6)
					{
						object obj7 = this + 12;
						obj7 = 0;
						_003C_003E1__state = 1;
						result = 1;
						num = 0f;
						obj = 45;
						goto IL_08e7;
					}
				}
				avatarAnimations.useStartClip = false;
				object obj8 = this + 24;
				obj8 = 0;
				obj = 43;
				goto IL_08e7;
				IL_08e7:
				object obj9 = obj;
				object obj15 = default;
				List<AnimationClip> list = default;
				object obj19 = default;
				while (true)
				{
					if ((nint)obj9 == 29)
					{
						if (avatarAnimations.nextAnimationTime > 0f)
						{
							num = Time.unscaledTime;
							float nextAnimationTime = avatarAnimations.nextAnimationTime - num;
							avatarAnimations.nextAnimationTime = nextAnimationTime;
							object obj10 = this + 12;
							obj10 = 0;
							_003C_003E1__state = 2;
							obj9 = 45;
							result = 1;
							continue;
						}
						goto IL_0752;
					}
					NullReferenceException ex;
					if ((nint)obj9 == 40)
					{
						if (avatarAnimations.nextAnimationTime > 0f)
						{
							num = Time.unscaledTime;
							float nextAnimationTime2 = avatarAnimations.nextAnimationTime - num;
							avatarAnimations.nextAnimationTime = nextAnimationTime2;
							object obj11 = this + 12;
							obj11 = 0;
							_003C_003E1__state = 3;
							obj9 = 45;
							result = 1;
							continue;
						}
						float num3 = (float)_003Ci_003E5__4 + 1f;
						_003Ci_003E5__4 = (int)num3;
						num = 1f;
					}
					else
					{
						if ((nint)obj9 == 43)
						{
							if (~(avatarAnimations.PlayIdleAnimations ? 1u : 0u) != 0)
							{
								object obj12 = avatarAnimations + 56;
								obj12 = 0;
								obj9 = 45;
								result = null;
								continue;
							}
							if (~(avatarAnimations.usePopupIdles ? 1u : 0u) == 0)
							{
								_003C_003Ec__DisplayClass39_0 obj13 = _003C_003E8__1;
								if (obj13._003C_003E9__0 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									nint num4 = 0;
									_ = 0;
									object obj14 = obj15 + 16;
									obj14 = _003C_003E8__1;
									object obj16 = _003C_003E8__1 + 12;
									obj16 = obj15;
								}
							}
							else
							{
								List<AnimationClip> idles = avatarAnimations._idles;
								if (idles._size < 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									list._002Ector();
									ex = (NullReferenceException)(object)list;
									goto IL_0956;
								}
								_003C_003Ec__DisplayClass39_0 obj17 = _003C_003E8__1;
								if (obj17._003C_003E9__1 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									nint num5 = 0;
									_ = 0;
									object obj18 = obj19 + 16;
									obj18 = _003C_003E8__1;
									object obj20 = _003C_003E8__1 + 16;
									obj20 = obj19;
								}
							}
							NullReferenceException ex2 = new NullReferenceException();
							ex = ex2;
							goto IL_0956;
						}
						if ((nint)obj9 == 45)
						{
							break;
						}
					}
					goto IL_09ef;
					IL_0752:
					if (~(avatarAnimations.usePopupIdles ? 1u : 0u) == 0)
					{
						obj9 = 43;
						continue;
					}
					int num6 = UnityEngine.Random.RandomRangeInt(avatarAnimations.MinIdleTimes, avatarAnimations.MaxIdleTimes);
					_003Ccount_003E5__3 = num6;
					_003Ci_003E5__4 = 0;
					num = avatarAnimations.MaxIdleTimes;
					goto IL_09ef;
					IL_09ef:
					if (_003Ci_003E5__4 >= _003Ccount_003E5__3)
					{
						obj9 = 43;
						continue;
					}
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)avatarAnimations._target).FindKernel((string)null) != 0)
					{
						UnityEngine.Object animation = UnityEngine.Object.Instantiate((UnityEngine.Object)avatarAnimations._breath);
						AnimationState animationState2 = avatarAnimations._target.CrossFadeQueued((string)(object)animation);
					}
					float frameRate = avatarAnimations._breath.frameRate;
					avatarAnimations.nextAnimationTime = frameRate;
					obj9 = 40;
					num = 0f;
					continue;
					IL_0956:
					if ((nint)((Exception)ex)._message >= 1)
					{
						object obj22 = _003C_003E8__1 + 8;
						int index = UnityEngine.Random.RandomRangeInt(0, (int)((Exception)ex)._message);
						AnimationClip animationClip = ((List<AnimationClip>)(object)ex).get_Item(index);
						obj22 = animationClip;
					}
					_003C_003Ec__DisplayClass39_0 obj23 = _003C_003E8__1;
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num10 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num11 = ((ComputeShader)(object)obj23.selectedClip).FindKernel((string)null);
					bool flag7 = num11 == 0;
					num = 0f;
					if (!flag7)
					{
						_003C_003Ec__DisplayClass39_0 obj25 = _003C_003E8__1;
						UnityEngine.Object animation2 = UnityEngine.Object.Instantiate((UnityEngine.Object)obj25.selectedClip);
						AnimationState animationState3 = avatarAnimations._target.CrossFadeQueued((string)(object)animation2);
						_003C_003Ec__DisplayClass39_0 obj26 = _003C_003E8__1;
						float frameRate2 = obj26.selectedClip.frameRate;
						avatarAnimations.nextAnimationTime = frameRate2;
						obj9 = 29;
						num = 0f;
						continue;
					}
					goto IL_0752;
				}
				return result;
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

	private SkinnedMeshRenderer _head;

	private Transform _blendshapeController;

	private Animation _target;

	private List<AnimationClip> IdlesPopup;

	public bool Paused;

	public bool PlayIdleAnimations;

	private AnimationClip startClip;

	private List<AnimationClip> _idles;

	private AnimationClip _breath;

	private CharacterAssetsBundle currentCharacterBundle;

	private int _currentOutfitIndex;

	private bool usePopupIdles;

	private bool useStartClip;

	private IEnumerator animationRoutine;

	private float nextAnimationTime;

	private int _blendshapeCount;

	private int MinIdleTimes;

	private int MaxIdleTimes;

	private CharacterIdlesBundle _idlesBundle;

	public SkinnedMeshRenderer Head
	{
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected Obj, but got Unknown
			//IL_0261: Expected Obj, but got I4
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Expected Obj, but got Unknown
			//IL_0293: Expected Obj, but got I
			//IL_02a3: Expected Obj, but got I
			//IL_0023: Expected Obj, but got I
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Expected Obj, but got Unknown
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Expected Obj, but got Unknown
			//IL_031b: Expected Obj, but got I4
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			//IL_01b5: Expected Obj, but got I
			//IL_00c2: Expected I, but got Obj
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarAnimations)+B0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+48]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+C]");
			if ((nint)0 <= (nint)0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarAnimations)+B0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj8 = default;
			object obj10 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj8 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v81 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v93 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
			}
			object obj11 = obj4 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj4 + obj13;
			obj14 = 87;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj15 = (nint)0 << 2;
				object obj16 = obj4 + obj15;
				if ((nint)obj16 == 87)
				{
					object obj17 = obj4 + 4;
					if ((nint)obj17 > -1)
					{
						object obj18 = obj17 + -1;
						obj17 = obj18;
					}
					return;
				}
			}
			object obj19 = default;
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
	}

	public Transform BlendshapeController
	{
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public Animation Target
	{
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public unsafe void Initialize(CharacterAssetsBundle characterAssetsBundle, int outfitIndex)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Ref, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected VT, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Ref, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Ref, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_010b: Expected I, but got Obj
		//IL_021c: Expected F4, but got VT
		//IL_0217: Expected native int or pointer, but got VT
		//IL_0231: Expected F4, but got I
		//IL_022c: Expected native int or pointer, but got VT
		//IL_0250: Expected VT, but got Ref
		//IL_0078: Expected I, but got Obj
		Transform transform = default;
		ref Quaternion reference = ref *(Quaternion*)(transform - -64);
		Quaternion quaternion = (Quaternion)(transform + 48);
		object obj = transform + 32;
		ref Quaternion reference2 = ref *(Quaternion*)(transform + 16);
		ref HoverboardModelPreviewFactory.HoverboardModelSetup reference3 = ref *(HoverboardModelPreviewFactory.HoverboardModelSetup*)(transform + 44);
		reference3 = ref *(HoverboardModelPreviewFactory.HoverboardModelSetup*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterAssetsBundle @ L1 (CharacterAssetsBundle)+44]");
		if (((Dictionary<string, HoverboardModelPreviewFactory.HoverboardModelSetup>)0).TryGetValue((string)outfitIndex, out reference3))
		{
			object obj2 = reference3 + 12;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v15+8]");
			_ = 0;
			nint num = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v36 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v49 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			reference = ref *(Quaternion*)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			Quaternion.Inverse_Injected(ref reference2, out reference);
			transform.Rotate(0f, 180f, 0f);
			((Quaternion*)(nint)quaternion)->x = (float)reference2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			reference = ref *(Quaternion*)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Vector3 vector = quaternion * (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			return;
		}
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v24 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v29 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Transform)(object)this).Rotate(194f, 110.5f, 180f);
	}

	private Animation FindAnimationInParent(GameObject current)
	{
		//IL_0179: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007a: Expected Obj, but got I4
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		UnityEngine.Object obj = null;
		string text = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(obj != null))
			{
				break;
			}
			CharacterModel componentInParent = ((GameObject)(object)text).GetComponentInParent<CharacterModel>();
			int layer = ((GameObject)(object)text).layer;
			Transform parentInternal = ((Transform)layer).parentInternal;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(parentInternal != null))
			{
				text = parentInternal.tag;
				obj = componentInParent;
				continue;
			}
			obj = null;
			break;
		}
		return (Animation)obj;
	}

	public static float NormalizeBlendShape(float value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public float GetBlendShapeValue(int index)
	{
		//IL_0055: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00ac: Expected F4, but got Obj
		IntPtr intPtr = default;
		switch ((long)intPtr)
		{
		case 0L:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+2C]");
			object obj2 = (nint)0 + (nint)3288;
			if (obj2 != null)
			{
				return 1f;
			}
			return 0f;
		}
		case 1L:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+2C]");
			object obj = (nint)0 + (nint)3308;
			return (float)obj;
		}
		default:
			return 0f;
		}
	}

	private void Update()
	{
		//IL_0098: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got F4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 68;
		object obj7 = default;
		obj6 = obj7;
		string text = ((AnimatorControllerParameter)(object)"Base Layer.HoverboardMenuTeleport").name;
		string text2 = ((AnimatorControllerParameter)(object)"Base Layer.HoverboardMenuGlider").name;
		object obj8 = 0;
		_ = 0;
		obj8 = -1f;
		_ = -1f;
		_ = -1f;
		object obj9 = obj8 + 12;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj10 = this + 124;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v21+8]");
		_ = 0;
		CancelInvoke();
	}

	private void OnDestroy()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0094: Expected VT, but got Obj
		//IL_00a5: Expected F4, but got I
		//IL_00cc: Expected VT, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0112: Expected VT, but got Obj
		//IL_0120: Expected F4, but got I
		//IL_0147: Expected VT, but got I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_018d: Expected VT, but got Obj
		//IL_0196: Expected F4, but got Obj
		//IL_01bd: Expected VT, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_0203: Expected VT, but got Obj
		//IL_0214: Expected F4, but got I
		//IL_023b: Expected VT, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0281: Expected VT, but got Obj
		//IL_028f: Expected F4, but got I
		//IL_02b6: Expected VT, but got I4
		if (~(PlayIdleAnimations ? 1u : 0u) != 0 || animationRoutine == null || ~(Paused ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = this - -64;
		if ((nint)obj <= 1)
		{
			return;
		}
		Transform transform = default;
		transform.localPosition = (Vector3)_blendshapeController;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
		float num = PlanarRealtimeReflection.sgn(0f);
		float num2 = num * 100f;
		Color color = (Color)1 * num2;
		object obj2 = this - -64;
		if ((nint)obj2 <= 2)
		{
			return;
		}
		transform.localPosition = (Vector3)_blendshapeController;
		float num3 = PlanarRealtimeReflection.sgn((float)(nint)((UnityEngine.Object)transform).m_CachedPtr);
		float num4 = num3 * 100f;
		Color color2 = (Color)2 * num4;
		object obj3 = this - -64;
		if ((nint)obj3 <= 3)
		{
			return;
		}
		transform.localRotation = (Quaternion)_blendshapeController;
		float num5 = PlanarRealtimeReflection.sgn((float)transform);
		float num6 = num5 * 100f;
		Color color3 = (Color)3 * num6;
		object obj4 = this - -64;
		if ((nint)obj4 > 4)
		{
			transform.localRotation = (Quaternion)_blendshapeController;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			float num7 = PlanarRealtimeReflection.sgn(0f);
			float num8 = num7 * 100f;
			Color color4 = (Color)4 * num8;
			object obj5 = this - -64;
			if ((nint)obj5 > 5)
			{
				transform.localRotation = (Quaternion)_blendshapeController;
				float num9 = PlanarRealtimeReflection.sgn((float)(nint)((UnityEngine.Object)transform).m_CachedPtr);
				float num10 = num9 * 100f;
				Color color5 = (Color)5 * num10;
			}
		}
	}

	private void ClearBundleAnimation()
	{
		StartIdleAnimations();
	}

	public void StartIdleAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_0516: Expected Obj, but got I4
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_0546: Expected I, but got Obj
		//IL_055c: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_05ba: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_010c: Expected VT, but got Obj
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_0651: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I4
		//IL_0164: Expected I, but got Obj
		//IL_0200: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_0407: Expected Obj, but got I
		//IL_0241: Expected I, but got Obj
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_02c9: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I
		//IL_030a: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v124 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_idlesBundle).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v120 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)startClip).FindKernel((string)null) != 0)
		{
			UnityEngine.Object obj7 = UnityEngine.Object.Instantiate((UnityEngine.Object)startClip);
			CollisionFlags collisionFlags = ((CharacterController)(object)_target).Move((Vector3)obj7);
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v108 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v116 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)collisionFlags).FindKernel(null) != 0)
			{
				UnityEngine.Object clipName = UnityEngine.Object.Instantiate((UnityEngine.Object)startClip);
				_target.RemoveClip2((string)(object)clipName);
			}
		}
		object obj9 = this + 32;
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj10 = default;
		object obj12 = default;
		object obj14 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v89 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v135 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj12 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v110 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v128 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
		object obj15 = obj4 + 4;
		object obj16 = obj15 + 1;
		obj15 = obj16;
		object obj17 = obj16 << 2;
		object obj18 = obj4 + obj17;
		obj18 = 188;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 188)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_06ed;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_06ed;
		IL_06ed:
		throw new IndexOutOfRangeException();
	}

	public void StartCustomAnimations(AnimationClip[] animationClips, bool useUnscaledTime)
	{
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01e7: Expected I, but got Obj
		//IL_01fd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0262: Expected I, but got Obj
		//IL_0278: Expected Obj, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I4
		//IL_00cf: Expected I, but got Obj
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		object obj = this + 40;
		obj = animationClips[4];
		object obj2 = this + 44;
		obj2 = animationClips;
		_currentOutfitIndex = (useUnscaledTime ? 1 : 0);
		AnimationClip outfitStartClip = ((CharacterIdlesBundle)(object)animationClips).GetOutfitStartClip(_currentOutfitIndex);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)outfitStartClip).FindKernel((string)null) != 0)
		{
			object obj4 = this + 40;
			obj4 = outfitStartClip;
			_idles.Add(outfitStartClip);
		}
		if (~(PlayIdleAnimations ? 1u : 0u) == 0)
		{
			if (~(usePopupIdles ? 1u : 0u) == 0)
			{
				StopIdleAnimations();
			}
			else
			{
				StartIdlePopupAnimations();
			}
		}
		int blendShapeCount = ((Mesh)(object)_head).blendShapeCount;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)blendShapeCount).FindKernel(null) != 0)
		{
			string sortingLayerName = _head.sortingLayerName;
			if (sortingLayerName != null)
			{
				object obj6 = this - -64;
				int blendShapeCount2 = ((Mesh)(object)_head).blendShapeCount;
				bool canAccess = ((Mesh)blendShapeCount2).canAccess;
				obj6 = canAccess;
				return;
			}
		}
		object obj7 = this - -64;
		obj7 = 0;
	}

	public void StartIdlePopupAnimations()
	{
		//IL_0079: Expected VT, but got Obj
		//IL_0013: Expected I4, but got Obj
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I
		StartIdleAnimations();
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)currentCharacterBundle);
		string bundle = string.ConcatArray((string[])(object)values, (int)"_idles");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		string text = default;
		text.m_stringLength = (int)num;
		_ = 0;
		object obj = text + 16;
		obj = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (T)+18]");
		((AssetBundleFactory<>)0).LoadAssetFromBundles((AssetBundle)(object)bundle, text, (Action<T>)null);
	}

	public void StopIdleAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_027f: Expected I4, but got Obj
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		PlayIdleAnimations = true;
		Paused = false;
		usePopupIdles = true;
		useStartClip = false;
		UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)_breath);
		((AnimationState)(object)_target).AddMixingTransform((Transform)(object)_breath, (byte)(int)obj5 != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 121)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_02c7;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02c7;
		IL_02c7:
		object obj16 = this + 56;
		bool isEyeControlledByAnimation = ((AvatarEyeAnimation)this).IsEyeControlledByAnimation;
		obj16 = isEyeControlledByAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
	}

	public void PauseIdleAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		//IL_0566: Expected Obj, but got I4
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_059c: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0431: Expected Obj, but got I4
		//IL_04ba: Expected Obj, but got I
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected Obj, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected Obj, but got Unknown
		//IL_0631: Expected Obj, but got I4
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I4
		//IL_0132: Expected I, but got Obj
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		object obj5 = this + 56;
		obj5 = 0;
		PlayIdleAnimations = false;
		bool flag = (byte)(~(usePopupIdles ? 1u : 0u)) != 0;
		List<AnimationClip> list = _idles;
		if (!flag)
		{
			list = IdlesPopup;
		}
		if (list == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = 0;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj15 = default;
		object obj21 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj8 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S0_v194 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v208 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					}
				}
				object obj11 = obj4 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj4 + obj13;
				obj14 = 137;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj15 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj16 = (nint)0 << 2;
					object obj17 = obj4 + obj16;
					if ((nint)obj17 == 137)
					{
						object obj18 = obj4 + 4;
						if ((nint)obj18 > -1)
						{
							object obj19 = obj18 + -1;
							obj18 = obj19;
						}
						continue;
					}
				}
				if (obj6 == null)
				{
					obj6 = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj20 = obj21;
				object obj22 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj22 == obj24)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					obj25 = obj26;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				break;
			}
			object obj27 = obj4 + 4;
			object obj28 = obj27 + 1;
			obj27 = obj28;
			object obj29 = obj28 << 2;
			object obj30 = obj4 + obj29;
			obj30 = 162;
			obj25 = obj6;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj31 = (nint)0 << 2;
			object obj32 = obj4 + obj31;
			if ((nint)obj32 == 162)
			{
				object obj33 = obj4 + 4;
				if ((nint)obj33 > -1)
				{
					object obj34 = obj33 + -1;
					obj33 = obj34;
				}
				return;
			}
		}
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void ResumeIdleAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Paused = true;
		int stateCount = _target.GetStateCount();
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 69;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 69)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private unsafe IEnumerator PlayAnimationsInOrder(AnimationClip[] animationClips, bool useUnscaledTime)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected Ref, but got Unknown
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected VT, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected Obj, but got Unknown
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected Ref, but got Unknown
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected Obj, but got Unknown
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected Obj, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected Obj, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected Obj, but got Unknown
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected Ref, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected Obj, but got Unknown
		//IL_0a66: Expected Obj, but got I4
		//IL_0a7f: Expected Obj, but got I4
		//IL_0029: Expected I4, but got Obj
		//IL_0049: Expected I4, but got Obj
		//IL_0052: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 144;
		obj = useUnscaledTime;
		ref Quaternion reference = ref *(Quaternion*)(obj2 + 152);
		Quaternion quaternion = (Quaternion)(obj2 + 128);
		object obj3 = obj2 + 96;
		ref Quaternion reference2 = ref *(Quaternion*)(obj2 + 80);
		Transform transform = (Transform)(obj2 - -64);
		object obj4 = obj2 + 48;
		Transform transform2 = (Transform)(obj2 + 36);
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 12;
		ref HoverboardModelPreviewFactory.HoverboardModelSetup reference3 = ref *(HoverboardModelPreviewFactory.HoverboardModelSetup*)(obj2 + 120);
		reference3 = ref *(HoverboardModelPreviewFactory.HoverboardModelSetup*)null;
		object obj7 = obj2 + 108;
		obj7 = 0;
		_ = 0;
		if (((Dictionary<string, HoverboardModelPreviewFactory.HoverboardModelSetup>)MinIdleTimes).TryGetValue((string)(object)animationClips, out reference3))
		{
			string text = string.ConcatArray((string[])(object)"Hoverboard: ", (int)animationClips);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)text;
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		object msg = ((IConvertible)"GetHoverboardModelPreview() could not find preview board model for '").ToType((Type)(object)animationClips, (IFormatProvider)(object)"'.");
		SDebug.LogFormat((string)msg, null);
		return null;
	}

	private IEnumerator Play()
	{
		//IL_00d5: Expected Obj, but got I4
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(MysteryPowerup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<MysteryPowerup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(MysteryPowerup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v31 (Il2CppClass<MysteryPowerup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DoubleCoins instance = DoubleCoins.Instance;
		int index = UnityEngine.Random.RandomRangeInt(0, (int)((CharacterModifier)instance).stop);
		if (((CharacterModifier)instance).stop < CharacterModifier.StopSignal.STOP)
		{
			SDebug.LogFormat("The eligible board list is empty.", null);
			return null;
		}
		Boards.BoardId boardId = ((List<Boards.BoardId>)(object)instance).get_Item(index);
		obj = boardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public AvatarAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Paused = false;
		int stateCount = _target.GetStateCount();
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 69;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 69)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void _003CStartIdleAnimations_003Eb__32_0(CharacterIdlesBundle idlesBundle)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = idlesBundle;
	}
}
