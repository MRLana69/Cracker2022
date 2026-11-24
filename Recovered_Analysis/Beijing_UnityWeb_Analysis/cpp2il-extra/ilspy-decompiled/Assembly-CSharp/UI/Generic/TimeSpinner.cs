using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.Generic;

public class TimeSpinner : MonoBehaviour
{
	private enum SpinState
	{
		Zero,
		Three,
		Six,
		Nine,
		Twelve,
		Fifteen,
		Eighteen,
		TwentyOne
	}

	private sealed class _003CAnimate_003Ed__10(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TimeSpinner _003C_003E4__this;

		private float _003CanimationDuration_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_05f8: Expected Obj, but got Unknown
				//IL_0601: Expected Obj, but got I4
				//IL_0615: Expected Obj, but got I4
				//IL_0179: Expected Obj, but got I4
				//IL_0283: Expected Obj, but got I4
				//IL_0197: Expected Obj, but got I4
				//IL_0654: Expected Obj, but got I4
				//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_07f2: Expected Obj, but got Unknown
				//IL_0826: Expected Obj, but got I4
				//IL_01b5: Expected Obj, but got I4
				//IL_040b: Expected Obj, but got I4
				//IL_0699: Unknown result type (might be due to invalid IL or missing references)
				//IL_069e: Expected Obj, but got Unknown
				//IL_06d2: Expected Obj, but got I4
				//IL_01d3: Expected Obj, but got I4
				//IL_043f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0444: Expected Obj, but got Unknown
				//IL_0478: Expected Obj, but got I4
				//IL_01f1: Expected Obj, but got I4
				//IL_04b2: Expected Obj, but got I4
				//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_06e2: Expected Obj, but got Unknown
				//IL_0716: Expected Obj, but got I4
				//IL_020f: Expected Obj, but got I4
				//IL_0721: Unknown result type (might be due to invalid IL or missing references)
				//IL_0726: Expected Obj, but got Unknown
				//IL_075a: Expected Obj, but got I4
				//IL_022d: Expected Obj, but got I4
				//IL_0765: Unknown result type (might be due to invalid IL or missing references)
				//IL_076a: Expected Obj, but got Unknown
				//IL_079e: Expected Obj, but got I4
				//IL_056c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0571: Expected Obj, but got Unknown
				//IL_05a5: Expected Obj, but got I4
				//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_07ae: Expected Obj, but got Unknown
				//IL_07e2: Expected Obj, but got I4
				TimeSpinner timeSpinner = _003C_003E4__this;
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
													if (_003C_003E1__state == 9)
													{
														_003C_003E1__state = -1;
														((CharacterRendering)(object)timeSpinner).pogostickClips = null;
														return null;
													}
													return null;
												}
												_003C_003E1__state = -1;
												((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab = null;
											}
											else
											{
												_003C_003E1__state = -1;
												((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab = (GameObject)7;
											}
										}
										else
										{
											_003C_003E1__state = -1;
											((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab = (GameObject)6;
										}
									}
									else
									{
										_003C_003E1__state = -1;
										((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab = (GameObject)5;
									}
								}
								else
								{
									_003C_003E1__state = -1;
									((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab = (GameObject)4;
								}
							}
							else
							{
								_003C_003E1__state = -1;
								((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab = (GameObject)3;
							}
						}
						else
						{
							_003C_003E1__state = -1;
							((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab = (GameObject)2;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab = (GameObject)1;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					_003CanimationDuration_003E5__2 = 0.5f;
				}
				while (true)
				{
					if (((CharacterRendering)(object)timeSpinner).defaultAnimations != null)
					{
						((CharacterRendering)(object)timeSpinner).pogostickClips = (CharacterRendering.PogostickClips)1;
						if ((object)((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab != null)
						{
							if ((nint)((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab != 1)
							{
								if ((nint)((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab != 2)
								{
									if ((nint)((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab != 3)
									{
										if ((nint)((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab != 4)
										{
											if ((nint)((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab != 5)
											{
												if ((nint)((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab != 6)
												{
													if ((nint)((CharacterRendering)(object)timeSpinner).teleboardWarpPrefab != 7)
													{
														continue;
													}
													CharacterRendering.JetpackClips jetpackAnimations = ((CharacterRendering)(object)timeSpinner).jetpackAnimations;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v81 (SYBO.Subway.Characters.CharacterRendering+JetpackClips)+12C]");
													if ((nint)0 != 0)
													{
														_ = 0;
														_ = 1;
													}
													break;
												}
												object obj = this + 12;
												IEnumerator enumerator = ((CharacterRendering)(object)timeSpinner).TeleboardStartScale(0.25f, _003CanimationDuration_003E5__2);
												obj = enumerator;
												_003C_003E1__state = 7;
												return 1;
											}
											CharacterRendering.JetpackClips jetpackAnimations2 = ((CharacterRendering)(object)timeSpinner).jetpackAnimations;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67 (SYBO.Subway.Characters.CharacterRendering+JetpackClips)+12C]");
											if ((nint)0 != 0)
											{
												_ = 0;
												_ = 1;
											}
											object obj2 = this + 12;
											IEnumerator enumerator2 = ((CharacterRendering)(object)timeSpinner).TeleboardStartScale(0.5f, _003CanimationDuration_003E5__2);
											obj2 = enumerator2;
											_003C_003E1__state = 6;
											return 1;
										}
										CharacterRendering.JetpackClips jetpackAnimations3 = ((CharacterRendering)(object)timeSpinner).jetpackAnimations;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v57 (SYBO.Subway.Characters.CharacterRendering+JetpackClips)+12C]");
										if ((nint)0 != 0)
										{
											_ = 0;
											_ = 1;
										}
										object obj3 = this + 12;
										IEnumerator enumerator3 = ((CharacterRendering)(object)timeSpinner).TeleboardStartScale(0.75f, _003CanimationDuration_003E5__2);
										obj3 = enumerator3;
										_003C_003E1__state = 5;
										return 1;
									}
									CharacterRendering.JetpackClips jetpackAnimations4 = ((CharacterRendering)(object)timeSpinner).jetpackAnimations;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v45 (SYBO.Subway.Characters.CharacterRendering+JetpackClips)+12C]");
									bool flag = (nint)0 != 0;
									object obj4 = (flag ? 1 : 0) ^ 1;
									if (obj4 != null)
									{
										_ = 1;
										_ = 1;
									}
									object obj5 = this + 12;
									IEnumerator enumerator4 = ((CharacterRendering)(object)timeSpinner).TeleboardStartScale(1f, _003CanimationDuration_003E5__2);
									obj5 = enumerator4;
									_003C_003E1__state = 4;
									return 1;
								}
								object obj6 = this + 12;
								IEnumerator enumerator5 = ((CharacterRendering)(object)timeSpinner).TeleboardStartScale(0.75f, _003CanimationDuration_003E5__2);
								obj6 = enumerator5;
								_003C_003E1__state = 3;
								return 1;
							}
							CharacterRendering.JetpackClips jetpackAnimations5 = ((CharacterRendering)(object)timeSpinner).jetpackAnimations;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v29 (SYBO.Subway.Characters.CharacterRendering+JetpackClips)+12C]");
							bool flag2 = (nint)0 != 0;
							object obj7 = (flag2 ? 1 : 0) ^ 1;
							if (obj7 != null)
							{
								_ = 1;
								_ = 1;
							}
							object obj8 = this + 12;
							IEnumerator enumerator6 = ((CharacterRendering)(object)timeSpinner).TeleboardStartScale(0.5f, _003CanimationDuration_003E5__2);
							obj8 = enumerator6;
							_003C_003E1__state = 2;
							return 1;
						}
						CharacterRendering.JetpackClips jetpackAnimations6 = ((CharacterRendering)(object)timeSpinner).jetpackAnimations;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v17 (SYBO.Subway.Characters.CharacterRendering+JetpackClips)+12C]");
						bool flag3 = (nint)0 != 0;
						object obj9 = (flag3 ? 1 : 0) ^ 1;
						if (obj9 != null)
						{
							_ = 1;
							_ = 1;
						}
						object obj10 = this + 12;
						IEnumerator enumerator7 = ((CharacterRendering)(object)timeSpinner).TeleboardStartScale(0.25f, _003CanimationDuration_003E5__2);
						obj10 = enumerator7;
						_003C_003E1__state = 1;
						return 1;
					}
					object obj11 = this + 12;
					obj11 = 0;
					_003C_003E1__state = 9;
					return 1;
				}
				object obj12 = this + 12;
				IEnumerator enumerator8 = ((CharacterRendering)(object)timeSpinner).TeleboardStartScale(0f, _003CanimationDuration_003E5__2);
				obj12 = enumerator8;
				_003C_003E1__state = 8;
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

	private sealed class _003CAdvanceToTarget_003Ed__11(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TimeSpinner _003C_003E4__this;

		public float target;

		public float duration;

		private float _003CcurrentDuration_003E5__2;

		private float _003CstartFillAmount_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0175: Expected I, but got Obj
				//IL_018b: Expected Obj, but got I
				//IL_0249: Unknown result type (might be due to invalid IL or missing references)
				//IL_024e: Expected Obj, but got Unknown
				//IL_0257: Expected Obj, but got I4
				//IL_026b: Expected Obj, but got I4
				//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f8: Expected Obj, but got Unknown
				//IL_0301: Expected Obj, but got I4
				//IL_0315: Expected Obj, but got I4
				//IL_01b6: Expected I, but got Obj
				TimeSpinner timeSpinner = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							goto IL_01f5;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003CcurrentDuration_003E5__2 = 0f;
					UISprite sprite = timeSpinner._sprite;
					_003CstartFillAmount_003E5__3 = ((UIBasicSprite)sprite).mFillAmount;
				}
				if (_003CcurrentDuration_003E5__2 < duration)
				{
					float fixedDeltaTime = Time.fixedDeltaTime;
					float num = _003CcurrentDuration_003E5__2 + fixedDeltaTime;
					_003CcurrentDuration_003E5__2 = num;
					float num2 = _003CcurrentDuration_003E5__2 / duration;
					float num3 = num2 - 1f;
					float num4 = num3 * num3;
					float num5 = num4 * num3;
					float num6 = num5 * num3;
					float num7 = num6 * num3;
					float num8 = num7 + 1f;
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v31 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num10 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v40 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num11 = target - _003CstartFillAmount_003E5__3;
					float num12 = num11 * num8;
					float delta = _003CstartFillAmount_003E5__3 + num12;
					((UIEventListener)(object)timeSpinner._sprite).OnScroll(delta);
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_01f5;
				IL_01f5:
				if (_003CcurrentDuration_003E5__2 < 1f)
				{
					float fixedDeltaTime2 = Time.fixedDeltaTime;
					float num13 = _003CcurrentDuration_003E5__2 + fixedDeltaTime2;
					_003CcurrentDuration_003E5__2 = num13;
					object obj3 = this + 12;
					obj3 = 0;
					_003C_003E1__state = 2;
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

	private bool _animate;

	private UISprite _sprite;

	private Coroutine _cachedCoroutine;

	private bool _coroutineRunning = false;

	private SpinState _currentState;

	private void Awake()
	{
		CancelInvoke();
	}

	private void OnEnable()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 16;
		UISprite component = GetComponent<UISprite>();
		obj = component;
	}

	private void OnDisable()
	{
		if (~(_animate ? 1u : 0u) == 0)
		{
			((UI.Generic.Layout.Layout)this).Align(true);
		}
	}

	public unsafe void Animate(bool animateNow)
	{
		//IL_0167: Expected I, but got Obj
		//IL_017d: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01c4: Expected Obj, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01db: Expected Obj, but got VT
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		nint num = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v47 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		object obj4 = obj3 + 32;
		obj4 = ((bool*)(animateNow ? 1 : 0))->m_value;
		object obj5 = obj3 + 16;
		obj5 = TimeSpan.Zero;
		object obj6 = obj3 + 24;
		obj6 = obj4;
		object obj7 = obj3 + 40;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FB");
		object obj8 = default;
		if (obj8 != null)
		{
			((RewardForVideoButton)this).OnCachedVideo((string)null, false);
			obj2 = ((bool*)(animateNow ? 1 : 0))->m_value;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A56A");
			int fontSize = default;
			((UILabel)_coroutineRunning).fontSize = fontSize;
			((RewardForVideoButton)_currentState).Init((VideoButtonPayload)1);
			((RewardForVideoButton)this).OnCachedVideo((string)null, true);
			return;
		}
		obj3 = ((bool*)(animateNow ? 1 : 0))->m_value;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A56A");
		int fontSize2 = default;
		((UILabel)_coroutineRunning).fontSize = fontSize2;
		((RewardForVideoButton)this).OnCachedVideo((string)1, false);
		bool coroutineRunning = _coroutineRunning;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v36 (System.Boolean)+12C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v37+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Generic.TimeSpinner)+30]");
		if (num3 != 0)
		{
			((TimerHelper)this)._002Ector();
		}
	}

	private IEnumerator Animate()
	{
		//IL_0014: Expected Obj, but got I4
		UISprite sprite = _sprite;
		return (IEnumerator)((UIWidget)sprite).mHeight;
	}

	private IEnumerator AdvanceToTarget(float target, float duration)
	{
		//IL_0020: Expected Obj, but got I4
		TweenVolume tweenVolume = UITweener.Begin<TweenVolume>((GameObject)(object)this, target);
		float amountPerDelta = tweenVolume.amountPerDelta;
		tweenVolume.from = amountPerDelta;
		tweenVolume.to = duration;
		if (duration > 0f)
		{
			UIWidget cachedWidget = ((TweenWidth)(object)tweenVolume).cachedWidget;
			cachedWidget.tag = (string)1;
			((AudioSource)(object)cachedWidget).Stop();
		}
		return (IEnumerator)tweenVolume;
	}
}
