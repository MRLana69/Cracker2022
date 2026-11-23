using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;

public class ActiveAnimation : MonoBehaviour
{
	public static ActiveAnimation current;

	public List<EventDelegate> onFinished;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private Animation mAnim;

	private Direction mLastDirection;

	private Direction mDisableDirection;

	private bool mNotify;

	private Animator mAnimator;

	private string mClip;

	private float playbackTime
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			//IL_006d: Expected F4, but got I
			//IL_0087: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 - 80;
			object obj3 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
			AnimatorStateInfo currentAnimatorStateInfo = mAnimator.GetCurrentAnimatorStateInfo(0);
			object obj4 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
			float num = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
			bool flag = 0f < 0f;
			float result = 0f;
			if (!flag)
			{
				result = num;
			}
			return result;
		}
	}

	public bool isPlaying
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected Obj, but got Unknown
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected Obj, but got Unknown
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Expected Obj, but got Unknown
			//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d0: Expected Obj, but got Unknown
			//IL_0634: Expected Obj, but got I
			//IL_032b: Expected I4, but got Obj
			//IL_028a: Expected Obj, but got I4
			//IL_048a: Invalid comparison between Obj and F4
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			bool result;
			if (mAnim == null)
			{
				bool flag = mAnimator != null;
				bool flag2 = !flag;
				result = false;
				if (!flag2)
				{
					float num = playbackTime;
					if (mLastDirection == Direction.Reverse)
					{
						if (num != 0f)
						{
							goto IL_00d2;
						}
						result = false;
					}
					else
					{
						bool flag3 = num == 1f;
						result = false;
						if (!flag3)
						{
							goto IL_00d2;
						}
					}
				}
			}
			else
			{
				IEnumerator enumerator = mAnim.GetEnumerator();
				object obj3 = obj + 24;
				object obj4 = obj + 28;
				obj = obj4;
				_ = 0;
				bool flag4 = default;
				object obj5;
				bool flag6 = default;
				bool flag8 = default;
				object obj7 = default;
				object obj8 = default;
				object obj9 = default;
				object obj10 = default;
				object obj11 = default;
				object obj13 = default;
				object obj14 = default;
				while (true)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						result = flag4;
					}
					else
					{
						if (!flag4)
						{
							result = false;
							obj5 = obj;
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag5 = (nint)0 == 1;
						result = flag6;
						if (!flag5)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag7 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							result = false;
							if (!flag7)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										if (!flag8)
										{
											continue;
										}
										object obj6 = mLastDirection + 1;
										if (obj6 != null)
										{
											bool flag9 = (nint)obj6 == 1;
											result = true;
											obj5 = obj;
											if (flag9)
											{
												break;
											}
											if ((nint)obj6 != 2)
											{
												result = true;
												obj5 = obj;
												break;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
													{
														result = true;
														obj5 = obj;
														break;
													}
													continue;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												result = true;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												result = true;
											}
										}
										else
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
												{
													result = true;
													obj5 = obj;
													break;
												}
												continue;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											result = true;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										result = flag8;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									result = (byte)(int)mAnim != 0;
								}
								goto IL_04d7;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					goto IL_04d7;
					IL_04d7:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag10 = obj10 != obj11;
					object obj12 = obj13;
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							result = false;
							obj5 = obj;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						obj12 = obj14;
						result = false;
					}
					_ = 0;
					object obj15 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj5 = 0;
					break;
				}
				object obj16 = obj5 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			}
			goto IL_0639;
			IL_00d2:
			result = true;
			goto IL_0639;
			IL_0639:
			return result;
		}
	}

	public void Finish()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (mAnim != null)
		{
			IEnumerator enumerator = mAnim.GetEnumerator();
			object obj3 = obj + 24;
			object obj4 = obj + 28;
			obj = obj4;
			_ = 0;
			object obj5 = default;
			object obj8 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj5 == null)
					{
						goto IL_0358;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
							object obj6 = mLastDirection + 1;
							if (obj6 != null)
							{
								if ((nint)obj6 == 1 || (nint)obj6 != 2)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
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
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_02c9;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_02c9;
				IL_0358:
				object obj7 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
				mAnim.Sample();
				return;
				IL_02c9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj8 != obj9;
				object obj10 = obj11;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0358;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
				break;
			}
			_ = 0;
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		else if (mAnimator != null)
		{
			bool flag2 = mLastDirection == Direction.Forward;
			float normalizedTime = 1f;
			if (!flag2)
			{
				normalizedTime = 0f;
			}
			mAnimator.Play(mClip, 0, normalizedTime);
		}
	}

	public void Reset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		if (mAnim != null)
		{
			IEnumerator enumerator = mAnim.GetEnumerator();
			object obj3 = obj + 24;
			object obj4 = obj + 28;
			obj = obj4;
			_ = 0;
			object obj5 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					break;
				}
				if (obj5 != null)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
							object obj6 = mLastDirection + 1;
							if (obj6 != null)
							{
								if ((nint)obj6 != 1 && (nint)obj6 == 2)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										break;
									}
								}
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					break;
				}
				object obj7 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj8 = default;
			object obj9 = default;
			bool flag = obj8 != obj9;
			object obj11 = default;
			object obj10 = obj11;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
					goto IL_032b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj13 = default;
				obj10 = obj13;
			}
			_ = 0;
			object obj14 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
		}
		goto IL_032b;
		IL_032b:
		if (mAnimator != null)
		{
			bool flag2 = mLastDirection == Direction.Reverse;
			float normalizedTime = 1f;
			if (!flag2)
			{
				normalizedTime = 0f;
			}
			mAnimator.Play(mClip, 0, normalizedTime);
		}
	}

	private void Start()
	{
		if (eventReceiver != null && EventDelegate.IsValid(onFinished))
		{
			eventReceiver = null;
			callWhenFinished = null;
		}
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0907: Expected Obj, but got I
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected Obj, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got Unknown
		//IL_06dd: Expected Obj, but got I
		//IL_0778: Expected Obj, but got I
		//IL_087b: Expected Obj, but got I
		//IL_0810: Expected Obj, but got I4
		//IL_07f4: Expected Obj, but got I4
		//IL_0502: Invalid comparison between F4 and Obj
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		if (unscaledDeltaTime == 0f)
		{
			return;
		}
		ActiveAnimation activeAnimation = default;
		object obj3;
		if (mAnimator != null)
		{
			float deltaTime = 0f - unscaledDeltaTime;
			if (mLastDirection != Direction.Reverse)
			{
				deltaTime = unscaledDeltaTime;
			}
			mAnimator.Update(deltaTime);
			if (isPlaying)
			{
				return;
			}
			mAnimator.enabled = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			((Behaviour)0).enabled = false;
			if (~(activeAnimation.mNotify ? 1u : 0u) != 0)
			{
				return;
			}
			activeAnimation.mNotify = false;
			if (!(current == null))
			{
				goto IL_0994;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			current = (ActiveAnimation)0;
			EventDelegate.Execute(activeAnimation.onFinished);
			if (!(activeAnimation.eventReceiver != null))
			{
				goto IL_0836;
			}
			string text = activeAnimation.callWhenFinished;
			if (activeAnimation.callWhenFinished != null)
			{
				obj3 = 0;
				if (text._stringLength != 0)
				{
					goto IL_09b6;
				}
			}
			obj3 = 1;
			goto IL_09b6;
		}
		if (!(mAnim != null))
		{
			enabled = false;
			return;
		}
		IEnumerator enumerator = mAnim.GetEnumerator();
		object obj4 = obj + 24;
		object obj5 = obj + 28;
		obj = obj5;
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		float num2 = default;
		object obj8 = default;
		float num4 = default;
		float num5 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj7 == null)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										float num = num2 * unscaledDeltaTime;
										float num3 = (float)obj8 + num;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											if (num < 0f)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													if (num4 > 0f)
													{
														continue;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														continue;
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
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
														{
															continue;
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
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
											}
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
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_05ca;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_05ca;
			IL_05ca:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj10 != obj11;
			object obj12 = obj13;
			if (!flag)
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
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			activeAnimation = (ActiveAnimation)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		object obj16 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
		activeAnimation.mAnim.Sample();
		return;
		IL_0994:
		if (activeAnimation.mDisableDirection != Direction.Toggle && activeAnimation.mLastDirection == activeAnimation.mDisableDirection)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			GameObject go = ((Component)0).gameObject;
			NGUITools.SetActive(go, state: false);
		}
		return;
		IL_09b6:
		if (obj3 == null)
		{
			activeAnimation.eventReceiver.SendMessage(activeAnimation.callWhenFinished, SendMessageOptions.DontRequireReceiver);
		}
		goto IL_0836;
		IL_0836:
		current = null;
		goto IL_0994;
	}

	private void Play(string clipName, Direction playDirection)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected Obj, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I4
		//IL_04b0: Invalid comparison between Obj and F4
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Direction direction = default;
		Direction direction2 = default;
		if (direction == Direction.Toggle)
		{
			bool flag = mLastDirection == Direction.Forward;
			direction2 = Direction.Reverse;
			if (!flag)
			{
				direction2 = Direction.Forward;
			}
		}
		object obj3;
		if (mAnim != null)
		{
			enabled = true;
			mAnim.enabled = false;
			if (clipName != null)
			{
				obj3 = 0;
				if (clipName._stringLength != 0)
				{
					goto IL_0917;
				}
			}
			obj3 = 1;
			goto IL_0917;
		}
		if (!(mAnimator != null))
		{
			return;
		}
		if (enabled && isPlaying && mClip == clipName)
		{
			mLastDirection = direction2;
			return;
		}
		enabled = true;
		mClip = clipName;
		mLastDirection = direction2;
		mNotify = true;
		bool flag2 = direction2 == Direction.Forward;
		float normalizedTime = 0f;
		if (!flag2)
		{
			normalizedTime = 1f;
		}
		mAnimator.Play(mClip, 0, normalizedTime);
		return;
		IL_0917:
		if (obj3 != null)
		{
			if (!mAnim.isPlaying)
			{
				bool flag3 = mAnim.Play();
			}
		}
		else if (!mAnim.IsPlaying(clipName))
		{
			bool flag4 = mAnim.Play(clipName);
		}
		IEnumerator enumerator = mAnim.GetEnumerator();
		object obj4 = obj + 24;
		object obj5 = obj + 28;
		obj = obj5;
		_ = 0;
		object obj6 = default;
		float value = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		object obj16 = default;
		object obj17 = default;
		object obj18 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj7;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					goto IL_0808;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
						if (clipName != null)
						{
							obj7 = 0;
							if (clipName._stringLength != 0)
							{
								goto IL_0934;
							}
						}
						obj7 = 1;
						goto IL_0934;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0779;
			IL_0311:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				float num = Math.Abs(value);
				float num2 = num * (float)direction2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj8 = direction2 + 1;
					if (obj8 != null)
					{
						if ((nint)obj8 == 1 || (nint)obj8 != 2)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj9 != obj10)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
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
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj11 != (object)0f)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
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
			goto IL_0779;
			IL_0808:
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			mNotify = true;
			mLastDirection = direction2;
			mAnim.Sample();
			return;
			IL_0779:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag5 = obj13 != obj14;
			object obj15 = obj16;
			if (flag5)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0808;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj15 = obj17;
			break;
			IL_0934:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj7 != null)
				{
					goto IL_0311;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj18 == null)
						{
							continue;
						}
						goto IL_0311;
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
			goto IL_0779;
		}
		_ = 0;
		object obj19 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		//IL_00be: Expected Obj, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		GameObject go = anim.gameObject;
		ActiveAnimation activeAnimation;
		if (!NGUITools.GetActive(go))
		{
			bool flag = enableBeforePlay != EnableCondition.EnableThenPlay;
			activeAnimation = null;
			if (flag)
			{
				goto IL_01ae;
			}
			GameObject go2 = anim.gameObject;
			NGUITools.SetActive(go2, state: true);
			GameObject gameObject = anim.gameObject;
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ S3_v6 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			ActiveAnimation activeAnimation2 = null;
			object obj3 = default;
			while (true)
			{
				ActiveAnimation activeAnimation3 = activeAnimation2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v57+C]");
				if ((nint)activeAnimation3 >= 0)
				{
					break;
				}
				object obj = (object)activeAnimation2 << 2;
				object obj2 = obj3 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v63+10]");
				((UIPanel)0).Refresh();
				ActiveAnimation activeAnimation4 = (ActiveAnimation)(activeAnimation2 + 1);
				activeAnimation2 = activeAnimation4;
			}
		}
		ActiveAnimation component = anim.GetComponent<ActiveAnimation>();
		bool flag2 = component == null;
		bool flag3 = !flag2;
		activeAnimation = component;
		if (!flag3)
		{
			GameObject gameObject2 = anim.gameObject;
			ActiveAnimation activeAnimation5 = gameObject2.AddComponent<ActiveAnimation>();
			activeAnimation = activeAnimation5;
		}
		activeAnimation.mAnim = anim;
		activeAnimation.mDisableDirection = (Direction)disableCondition;
		((List<T>)(object)activeAnimation.onFinished).Clear();
		activeAnimation.Play(clipName, playDirection);
		if (activeAnimation.mAnim != null)
		{
			activeAnimation.mAnim.Sample();
			return activeAnimation;
		}
		if (activeAnimation.mAnimator != null)
		{
			activeAnimation.mAnimator.Update(0f);
		}
		goto IL_01ae;
		IL_01ae:
		return activeAnimation;
	}

	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		return Play(anim, clipName, playDirection, EnableCondition.DoNothing, DisableCondition.DoNotDisable);
	}

	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		return Play(anim, null, playDirection, EnableCondition.DoNothing, DisableCondition.DoNotDisable);
	}

	public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		//IL_00dd: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		ActiveAnimation activeAnimation;
		if (enableBeforePlay != EnableCondition.IgnoreDisabledState)
		{
			GameObject go = anim.gameObject;
			if (!NGUITools.GetActive(go))
			{
				bool flag = enableBeforePlay != EnableCondition.EnableThenPlay;
				activeAnimation = null;
				if (flag)
				{
					goto IL_01cd;
				}
				GameObject go2 = anim.gameObject;
				NGUITools.SetActive(go2, state: true);
				GameObject gameObject = anim.gameObject;
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ S3_v6 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
				ActiveAnimation activeAnimation2 = null;
				object obj3 = default;
				while (true)
				{
					ActiveAnimation activeAnimation3 = activeAnimation2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v59+C]");
					if ((nint)activeAnimation3 >= 0)
					{
						break;
					}
					object obj = (object)activeAnimation2 << 2;
					object obj2 = obj3 + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v65+10]");
					((UIPanel)0).Refresh();
					ActiveAnimation activeAnimation4 = (ActiveAnimation)(activeAnimation2 + 1);
					activeAnimation2 = activeAnimation4;
				}
			}
		}
		ActiveAnimation component = anim.GetComponent<ActiveAnimation>();
		bool flag2 = component == null;
		bool flag3 = !flag2;
		activeAnimation = component;
		if (!flag3)
		{
			GameObject gameObject2 = anim.gameObject;
			ActiveAnimation activeAnimation5 = gameObject2.AddComponent<ActiveAnimation>();
			activeAnimation = activeAnimation5;
		}
		activeAnimation.mAnimator = anim;
		activeAnimation.mDisableDirection = (Direction)disableCondition;
		((List<T>)(object)activeAnimation.onFinished).Clear();
		activeAnimation.Play(clipName, playDirection);
		if (activeAnimation.mAnim != null)
		{
			activeAnimation.mAnim.Sample();
			return activeAnimation;
		}
		if (activeAnimation.mAnimator != null)
		{
			activeAnimation.mAnimator.Update(0f);
		}
		goto IL_01cd;
		IL_01cd:
		return activeAnimation;
	}

	public ActiveAnimation()
	{
		List<EventDelegate> list = default;
		list._002Ector();
		onFinished = list;
		mClip = string.Empty;
		base._002Ector();
	}
}
