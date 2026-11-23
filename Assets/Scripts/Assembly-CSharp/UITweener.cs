using System;
using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;

public abstract class UITweener : MonoBehaviour
{
	public enum Method
	{
		Linear,
		EaseIn,
		EaseOut,
		EaseInOut,
		BounceIn,
		BounceOut
	}

	public enum Style
	{
		Once,
		Loop,
		PingPong
	}

	public static UITweener current;

	public Method method;

	public Style style;

	public AnimationCurve animationCurve;

	public bool ignoreTimeScale;

	public float delay;

	public float duration;

	public bool steeperCurves;

	public int tweenGroup;

	public List<EventDelegate> onFinished;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private bool mStarted;

	private float mStartTime;

	private float mDuration;

	private float mAmountPerDelta;

	private float mFactor;

	private List<EventDelegate> mTemp;

	public float amountPerDelta
	{
		get
		{
			if (duration == mDuration)
			{
				return mAmountPerDelta;
			}
			mDuration = duration;
			float value = 1f / duration;
			if (!(duration > 0f))
			{
				value = 1000f;
			}
			float num = Math.Abs(value);
			bool flag = !(mAmountPerDelta < 0f);
			float num2 = 1f;
			if (!flag)
			{
				num2 = -1f;
			}
			return mAmountPerDelta = num * num2;
		}
	}

	public float tweenFactor
	{
		get
		{
			return mFactor;
		}
		set
		{
			float num = Math.Min(value, 1f);
			bool flag = value < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			mFactor = num2;
		}
	}

	public Direction direction
	{
		get
		{
			float num = amountPerDelta;
			bool flag = num < 0f;
			Direction result = Direction.Reverse;
			if (!flag)
			{
				result = Direction.Forward;
			}
			return result;
		}
	}

	private void Reset()
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0043: Expected I, but got Obj
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		if (~(mStarted ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<UITweener>)+EC] (should have been resolved before IL gen)");
			nint num2 = (nint)this;
			object obj2 = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v7 (Il2CppClass<UITweener>)+F4] (should have been resolved before IL gen)");
		}
	}

	protected virtual void Start()
	{
		Update();
	}

	private void Update()
	{
		//IL_00f5: Expected Obj, but got I4
		//IL_04c5: Expected Obj, but got I4
		//IL_04a9: Expected Obj, but got I4
		float num = ((~(ignoreTimeScale ? 1u : 0u) != 0) ? Time.deltaTime : Time.unscaledDeltaTime);
		float num2 = ((~(ignoreTimeScale ? 1u : 0u) != 0) ? Time.time : Time.unscaledTime);
		float num3;
		if (~(mStarted ? 1u : 0u) == 0)
		{
			num3 = mStartTime;
		}
		else
		{
			mStarted = true;
			num3 = (mStartTime = num2 + delay);
		}
		if (num2 < num3)
		{
			return;
		}
		float num4 = amountPerDelta;
		float num5 = num4 * num;
		float num6 = (mFactor += num5);
		object obj = this.style - 1;
		Style style;
		float factor;
		if (this.style != Style.Loop)
		{
			if ((nint)obj != 1)
			{
				style = this.style;
				goto IL_053a;
			}
			if (num6 > 1f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				float num7 = num6 - num6;
				float num8 = 1f - num7;
				mFactor = num8;
				float num9 = 0f - mAmountPerDelta;
				mAmountPerDelta = num9;
			}
			else if (num6 < 0f)
			{
				float num10 = (mFactor = 0f - num6);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				float num11 = num10 - num10;
				mFactor = num11;
				float num12 = 0f - mAmountPerDelta;
				mAmountPerDelta = num12;
			}
		}
		else
		{
			bool flag = num6 > 1f;
			bool flag2 = !flag;
			factor = num6;
			if (flag2)
			{
				goto IL_04f5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
			float num13 = num6 - num6;
			mFactor = num13;
		}
		style = this.style;
		goto IL_053a;
		IL_04e6:
		current = current;
		return;
		IL_04f5:
		Sample(factor, isFinished: false);
		return;
		IL_053a:
		if (style != Style.Once)
		{
			factor = mFactor;
			goto IL_04f5;
		}
		if (duration != 0f && !(mFactor > 1f))
		{
			bool flag3 = mFactor < 0f;
			bool flag4 = !flag3;
			factor = mFactor;
			if (flag4)
			{
				goto IL_04f5;
			}
		}
		float num14 = Math.Min(mFactor, 1f);
		bool flag5 = mFactor < 0f;
		float factor2 = 0f;
		if (!flag5)
		{
			factor2 = num14;
		}
		mFactor = factor2;
		Sample(factor2, isFinished: true);
		enabled = false;
		if (!(current == null))
		{
			return;
		}
		current = this;
		if (onFinished != null)
		{
			mTemp = onFinished;
			List<EventDelegate> list = default;
			list._002Ector();
			onFinished = list;
			EventDelegate.Execute(mTemp);
			int num15 = 0;
			while (true)
			{
				List<EventDelegate> list2 = mTemp;
				if (num15 >= list2._size)
				{
					break;
				}
				EventDelegate eventDelegate = mTemp.get_Item(num15);
				if (eventDelegate != null && !eventDelegate.oneShot)
				{
					EventDelegate.Add(onFinished, eventDelegate, oneShot: false);
				}
				int num16 = num15 + 1;
				num15 = num16;
			}
			mTemp = null;
		}
		if (!(eventReceiver != null))
		{
			goto IL_04e6;
		}
		string text = callWhenFinished;
		object obj2;
		if (callWhenFinished != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_05ef;
			}
		}
		obj2 = 1;
		goto IL_05ef;
		IL_05ef:
		if (obj2 == null)
		{
			eventReceiver.SendMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		goto IL_04e6;
	}

	public void SetOnFinished(EventDelegate.Callback del)
	{
		EventDelegate eventDelegate = EventDelegate.Set(onFinished, del);
	}

	public void SetOnFinished(EventDelegate del)
	{
		EventDelegate.Set(onFinished, del);
	}

	public void AddOnFinished(EventDelegate.Callback del)
	{
		EventDelegate eventDelegate = EventDelegate.Add(onFinished, del);
	}

	public void AddOnFinished(EventDelegate del)
	{
		EventDelegate.Add(onFinished, del);
	}

	public void RemoveOnFinished(EventDelegate del)
	{
		if (onFinished != null)
		{
			bool flag = onFinished.Remove(del);
		}
		if (mTemp != null)
		{
			bool flag2 = mTemp.Remove(del);
		}
	}

	private void OnDisable()
	{
		mStarted = false;
	}

	public void Sample(float factor, bool isFinished)
	{
		//IL_02ef: Expected Obj, but got I4
		//IL_03aa: Expected I, but got Obj
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		float num = Math.Min(factor, 1f);
		bool flag = factor < 0f;
		float num2 = 0f;
		if (!flag)
		{
			num2 = num;
		}
		object obj = method - 1;
		float num3;
		if (method != Method.EaseIn)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							num3 = num2;
						}
						else
						{
							float val = 1f - num2;
							float num4 = BounceLogic(val);
							float num5 = 1f - num4;
							num3 = num5;
						}
					}
					else
					{
						float num6 = BounceLogic(num2);
						num3 = num6;
					}
				}
				else
				{
					float num7 = num2 * ((float)Math.PI * 2f);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
					object obj2 = default;
					float num8 = (float)obj2 / ((float)Math.PI * 2f);
					float num9 = num2 - num8;
					bool flag2 = (byte)(~(steeperCurves ? 1u : 0u)) != 0;
					num3 = num9;
					if (!flag2)
					{
						float num10 = num9 + num9;
						float num11 = num10 - 1f;
						bool flag3 = !(num11 < 0f);
						float num12 = 1f;
						if (!flag3)
						{
							num12 = -1f;
						}
						float num13 = Math.Abs(num11);
						float num14 = 1f - num13;
						float num15 = num14 * num14;
						float num16 = 1f - num15;
						float num17 = num12 * num16;
						float num18 = num17 * 0.5f;
						float num19 = num18 + 0.5f;
						num3 = num19;
					}
				}
			}
			else
			{
				float num20 = num2 * ((float)Math.PI / 2f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
				bool flag4 = (byte)(~(steeperCurves ? 1u : 0u)) != 0;
				float num21 = default;
				num3 = num21;
				if (!flag4)
				{
					float num22 = 1f - num21;
					float num23 = num22 * num22;
					float num24 = 1f - num23;
					num3 = num24;
				}
			}
		}
		else
		{
			float num25 = 1f - num2;
			float num26 = num25 * ((float)Math.PI / 2f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
			object obj3 = default;
			float num27 = 1f - (float)obj3;
			bool flag5 = (byte)(~(steeperCurves ? 1u : 0u)) != 0;
			num3 = num27;
			if (!flag5)
			{
				float num28 = num27 * num27;
				num3 = num28;
			}
		}
		if (animationCurve != null)
		{
			float num29 = animationCurve.Evaluate(num3);
		}
		else
		{
			float num29 = num3;
		}
		nint num30 = (nint)this;
		object obj4 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S3_v5 (Il2CppClass<UITweener>)+E4] (should have been resolved before IL gen)");
	}

	private float BounceLogic(float val)
	{
		if (!(val < 0.363636f))
		{
			if (!(val < 0.727272f))
			{
				if (val < 0.90909f)
				{
					float num = val - 0.818181f;
					float num2 = num * 7.5625f;
					float num3 = num2 * num;
					return num3 + 0.9375f;
				}
				float num4 = val - 0.9545454f;
				float num5 = num4 * 7.5625f;
				float num6 = num5 * num4;
				return num6 + 63f / 64f;
			}
			float num7 = val - 0.545454f;
			float num8 = num7 * 7.5625f;
			float num9 = num8 * num7;
			return num9 + 0.75f;
		}
		float num10 = val * 7.5685f;
		return num10 * val;
	}

	public void Play()
	{
		Play(forward: true);
	}

	public void PlayForward()
	{
		Play(forward: true);
	}

	public void PlayReverse()
	{
		Play(forward: false);
	}

	public void Play(bool forward)
	{
		float value = amountPerDelta;
		float num = (mAmountPerDelta = Math.Abs(value));
		if (!forward)
		{
			float num2 = 0f - num;
			mAmountPerDelta = num2;
		}
		enabled = true;
		Update();
	}

	public void ResetToBeginning()
	{
		mStarted = false;
		float num = amountPerDelta;
		bool flag = num < 0f;
		float factor = 1f;
		if (!flag)
		{
			factor = 0f;
		}
		mFactor = factor;
		Sample(factor, isFinished: false);
	}

	public void Toggle()
	{
		float num = amountPerDelta;
		float num2 = 0f - num;
		float num3 = Math.Abs(num);
		if (!(mFactor > 0f))
		{
			num2 = num3;
		}
		mAmountPerDelta = num2;
		enabled = true;
	}

	protected abstract void OnUpdate(float factor, bool isFinished);

	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0320: Expected Obj, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I
		//IL_0445: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I
		//IL_01ca: Expected VT, but got I
		//IL_0157: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I
		//IL_01fd: Expected I, but got Obj
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 144;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UITweener::Begin>>)+4] (should have been resolved before IL gen)");
		UnityEngine.Object obj3 = default;
		bool flag = obj3 != null;
		bool flag2 = !flag;
		UnityEngine.Object obj4 = obj3;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v5 (UnityEngine.Object)+28]");
			bool flag3 = (nint)0 == 0;
			obj4 = obj3;
			if (!flag3)
			{
				object obj5 = obj + 140;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v26 (Il2CppMethodRgctx<UITweener::Begin>)+8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S2_v27+4] (should have been resolved before IL gen)");
				object obj8 = default;
				object obj11 = default;
				object obj14 = default;
				while (true)
				{
					object obj7 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v114+C]");
					if ((nint)obj7 < 0)
					{
						object obj9 = obj8 << 2;
						object obj10 = obj11 + obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v84+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v84+10]");
						if ((UnityEngine.Object)0 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
							UnityEngine.Object obj12 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v132 (UnityEngine.Object)+28]");
							bool flag4 = (nint)0 == 0;
							obj4 = obj12;
							if (flag4)
							{
								break;
							}
						}
						object obj13 = obj + 140;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
						obj8 = obj14 + 1;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
					obj4 = (UnityEngine.Object)0;
					break;
				}
			}
		}
		if (obj4 == null)
		{
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S3_v11 (Il2CppMethodRgctx<UITweener::Begin>)+C]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S3_v12+4] (should have been resolved before IL gen)");
			UnityEngine.Object obj16 = default;
			if (obj16 == null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v85 (Il2CppMethodRgctx<UITweener::Begin>)+10]");
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
				bool flag5 = (object)typeFromHandle == null;
				string text = null;
				if (!flag5)
				{
					nint num8 = (nint)typeFromHandle;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ S1_v74 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
					string text2 = default;
					text = text2;
				}
				string hierarchy = NGUITools.GetHierarchy(go);
				string text3 = "Unable to add " + text + " to " + hierarchy;
				object obj17 = obj + 136;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				return (T)0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
		UITweener uITweener = (UITweener)0;
		uITweener.mFactor = 0f;
		uITweener.duration = duration;
		uITweener.mStarted = false;
		float value = uITweener.amountPerDelta;
		float num9 = Math.Abs(value);
		uITweener.mAmountPerDelta = num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
		object obj18 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 1f;
		_ = 0f;
		_ = 0f;
		_ = 0f;
		object obj19 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		object obj20 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0f;
		_ = 1f;
		_ = 1f;
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		object obj21 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
		AnimationCurve animationCurve = default;
		Keyframe[] keys = default;
		animationCurve._002Ector(keys);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
		object obj22 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
		object obj23 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
		((Behaviour)0).enabled = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
		return (T)0;
	}

	public virtual void SetStartToCurrentValue()
	{
	}

	public virtual void SetEndToCurrentValue()
	{
	}

	protected UITweener()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_014e: Expected Obj, but got F4
		//IL_0185: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 1f;
		_ = 0f;
		_ = 0f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		object obj3 = obj + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj - -64;
		_ = 0;
		_ = 0;
		_ = 0f;
		_ = 1f;
		_ = 1f;
		obj4 = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
		AnimationCurve animationCurve = default;
		Keyframe[] keys = default;
		animationCurve._002Ector(keys);
		this.animationCurve = animationCurve;
		duration = 1f;
		ignoreTimeScale = true;
		List<EventDelegate> list = default;
		list._002Ector();
		onFinished = list;
		mAmountPerDelta = 1000f;
		base._002Ector();
	}
}
