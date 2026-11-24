using System;
using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UI.Pages;
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

	public bool useFixedUpdate;

	public List<EventDelegate> onFinished;

	public GameObject eventReceiver;

	public string callWhenFinished;

	[NonSerialized]
	public float timeScale;

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
			//IL_0092: Expected I, but got Obj
			//IL_00a8: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0063: Expected Obj, but got I
			UIWidget cachedWidget = ((TweenWidth)this).cachedWidget;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)cachedWidget).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITweener)+60]");
				return ((AudioSource)0).pitch;
			}
			return 0f;
		}
	}

	public float tweenFactor
	{
		get
		{
			//IL_005b: Expected I, but got Obj
			//IL_0071: Expected Obj, but got I
			//IL_009c: Expected I, but got Obj
			if (duration == 0f)
			{
				return 1000f;
			}
			if (mDuration != duration)
			{
				mDuration = duration;
				nint num = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v24 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float value = 1f / duration;
				float num3 = Math.Abs(value);
				float num4 = ((mAmountPerDelta < 0f) ? (-1f) : 1f);
				float num5 = num3 * num4;
				mAmountPerDelta = num5;
			}
			return mAmountPerDelta;
		}
		set
		{
			//IL_0085: Expected I, but got Obj
			//IL_009b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0067: Expected Obj, but got I
			UIWidget cachedWidget = ((TweenWidth)this).cachedWidget;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)cachedWidget).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITweener)+60]");
				((AudioSource)0).pitch = value;
			}
		}
	}

	public Direction direction
	{
		get
		{
			int width = ((TweenWidth)this).width;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+64]");
			return Direction.Toggle;
		}
	}

	private void Reset()
	{
		_ = 100;
		_ = 100;
		((UI2DSprite)this).OnUpdate();
	}

	protected virtual void Start()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected void Update()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		mDuration = duration;
		float num3;
		if (duration > 0f)
		{
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v20 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float value = 1f / duration;
			num3 = Math.Abs(value);
		}
		else
		{
			num3 = 1000f;
		}
		mAmountPerDelta = num3;
		OnDisable();
	}

	protected void FixedUpdate()
	{
		if (~(useFixedUpdate ? 1u : 0u) != 0)
		{
			OnDisable();
		}
	}

	protected void DoUpdate()
	{
		if (~(useFixedUpdate ? 1u : 0u) == 0)
		{
			OnDisable();
		}
	}

	public void SetOnFinished(EventDelegate.Callback del)
	{
		//IL_0017: Expected I4, but got Obj
		//IL_0017: Expected Obj, but got I4
		int width = ((TweenWidth)this).width;
		((UIWidget)width).height = (int)del;
	}

	public void SetOnFinished(EventDelegate del)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<EventDelegate>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventDelegate eventDelegate = EventDelegate.Add(onFinished, (EventDelegate.Callback)(object)del);
	}

	public void AddOnFinished(EventDelegate.Callback del)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<EventDelegate>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventDelegate.Add(onFinished, (EventDelegate)(object)del);
	}

	public void AddOnFinished(EventDelegate del)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<EventDelegate>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(onFinished, (EventDelegate.Callback)(object)del);
	}

	public void RemoveOnFinished(EventDelegate del)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<EventDelegate>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Localization.Set((string)(object)onFinished, (byte[])(object)del);
	}

	private void OnDisable()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_018d: Expected I, but got Obj
		//IL_01a3: Expected Obj, but got I
		//IL_026f: Expected I, but got Obj
		//IL_0285: Expected Obj, but got I
		//IL_049c: Expected I, but got Obj
		//IL_04b2: Expected Obj, but got I
		//IL_033c: Expected I, but got Obj
		//IL_0352: Expected Obj, but got I
		//IL_01ce: Expected I, but got Obj
		//IL_02b0: Expected I, but got Obj
		//IL_04dd: Expected I, but got Obj
		//IL_037d: Expected I, but got Obj
		//IL_0a3a: Expected Obj, but got I4
		//IL_0586: Expected I, but got Obj
		//IL_059c: Expected Obj, but got I
		//IL_05c7: Expected I, but got Obj
		//IL_0a7b: Expected I, but got Obj
		//IL_0a91: Expected Obj, but got I
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_07ee: Expected I, but got Obj
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected Obj, but got Unknown
		//IL_0679: Expected I, but got Obj
		//IL_068f: Expected Obj, but got I
		//IL_06ba: Expected I, but got Obj
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected Obj, but got Unknown
		//IL_07db: Expected Obj, but got I4
		//IL_0761: Expected I, but got Obj
		//IL_0777: Expected Obj, but got I
		//IL_0af5: Expected Obj, but got I4
		//IL_07a2: Expected I, but got Obj
		float num = ((~(ignoreTimeScale ? 1u : 0u) != 0 || useFixedUpdate) ? Time.unscaledTime : Time.fixedDeltaTime);
		float num2 = ((~(ignoreTimeScale ? 1u : 0u) != 0 || useFixedUpdate) ? Time.timeSinceLevelLoad : Time.unscaledDeltaTime);
		object obj = this - -64;
		bool flag = obj == null;
		bool flag2 = !flag;
		float num3 = num;
		if (!flag2)
		{
			object obj2 = this - -64;
			obj2 = 1;
			float num4 = num2 + delay;
			mStartTime = num4;
			num3 = 0f;
		}
		if (num2 < mStartTime)
		{
			return;
		}
		float num5 = mAmountPerDelta * num3;
		float num6 = num5 * timeScale;
		float num7 = mFactor + num6;
		mFactor = num7;
		if (style == Style.Loop)
		{
			if (mFactor > 1f)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v171 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v176 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				float num10 = mFactor - mFactor;
				mFactor = num10;
			}
		}
		else if (style == Style.PingPong)
		{
			if (mFactor > 1f)
			{
				nint num11 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v152 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num12 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v158 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				float num13 = mFactor - mFactor;
				float num14 = 1f - num13;
				mFactor = num14;
				float num15 = 0f - mAmountPerDelta;
				mAmountPerDelta = num15;
			}
			else if (mFactor < 0f)
			{
				float num16 = 0f - mFactor;
				mFactor = num16;
				nint num17 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v139 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num18 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v145 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				float num19 = mFactor - mFactor;
				mFactor = num19;
				float num20 = 0f - mAmountPerDelta;
				mAmountPerDelta = num20;
			}
		}
		if (style == Style.Once && (duration == 0f || mFactor > 1f || mFactor < 0f))
		{
			if (duration == 0f)
			{
				if (mAmountPerDelta > 0f)
				{
					float num21 = 1f;
				}
				else
				{
					float num21 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A9F");
			}
			else
			{
				nint num22 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v104 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num23 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v110 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num24;
				if (mFactor < 0f)
				{
					num24 = 0f;
				}
				else
				{
					num24 = ((!(mFactor > 1f)) ? mFactor : 1f);
				}
				mFactor = num24;
				((PageTop)this).Delay(mFactor, (Action)1);
			}
			tag = null;
			nint num25 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num26 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v80 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)current).FindKernel((string)(object)this) == 0)
			{
				return;
			}
			current = this;
			if (onFinished != null)
			{
				object obj8 = this + 84;
				obj8 = onFinished;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<EventDelegate> list = default;
				list._002Ector();
				object obj9 = this + 48;
				obj9 = list;
				nint num27 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v50 (Il2CppClass<EventDelegate>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num28 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v76 (Il2CppClass<EventDelegate>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Localization.dictionary = (Dictionary<string, string[]>)(object)mTemp;
				int num29 = 0;
				while (true)
				{
					List<EventDelegate> list2 = mTemp;
					if (num29 >= list2._size)
					{
						break;
					}
					EventDelegate eventDelegate = mTemp.get_Item(num29);
					if (eventDelegate != null && !eventDelegate.oneShot)
					{
						bool oneShot = eventDelegate.oneShot;
						nint num30 = (nint)typeof(EventDelegate);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S1_v68 (Il2CppClass<EventDelegate>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num31 = (nint)typeof(EventDelegate);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S1_v73 (Il2CppClass<EventDelegate>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Localization.AddCSV((BetterList<string>)(object)onFinished, (string[])(object)eventDelegate, (Dictionary<string, int>)oneShot);
					}
					int num32 = num29 + 1;
					num29 = num32;
				}
				object obj12 = this + 84;
				obj12 = 0;
			}
			nint num33 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num34 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)eventReceiver).FindKernel((string)null) != 0)
			{
				string text = callWhenFinished;
				if (callWhenFinished != null && text.m_stringLength != 0)
				{
					eventReceiver.BroadcastMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
				}
			}
			current = current;
		}
		else
		{
			((PageTop)this).Delay(mFactor, (Action)null);
		}
	}

	public void Sample(float factor, bool isFinished)
	{
		//IL_01de: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_0289: Expected I, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_0186: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v41 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = 1f - factor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITweener)+58]");
		float num4 = 0f * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITweener)+5C]");
		float num5 = 0f * factor;
		float width = num4 + num5;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		SetOnFinished((EventDelegate.Callback)(object)gUILayoutOption);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITweener)+60]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITweener)+68]");
		if ((UnityEngine.Object)0 != null)
		{
			string go = tag;
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v27 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num9 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v37 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = this + 104;
			UITable uITable = NGUITools.FindInParents<UITable>((GameObject)(object)go);
			obj4 = uITable;
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITweener)+68]");
			if ((UnityEngine.Object)0 != null)
			{
				_ = 0;
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITweener)+68]");
		((UITable)0).Sort((List<Transform>)1);
	}

	private float BounceLogic(float val)
	{
		//IL_000f: Expected Obj, but got I4
		return PlayerPrefs.GetFloat((string)ignoreTimeScale, val);
	}

	public void Play()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this - -64;
		obj = 0;
	}

	public void PlayForward()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public void PlayReverse()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public virtual void Play(bool forward)
	{
		//IL_0014: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		if (onFinished != null)
		{
			bool flag = onFinished.Remove((EventDelegate)forward);
		}
		if (mTemp != null)
		{
			bool flag2 = mTemp.Remove((EventDelegate)forward);
		}
	}

	public void ResetToBeginning()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public void Toggle()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this - -64;
		obj = 0;
		float num = tweenFactor;
		float num2 = ((!(num < 0f)) ? 0f : 1f);
		mFactor = num2;
		((PageTop)this).Delay(mFactor, (Action)null);
	}

	protected abstract void OnUpdate(float factor, bool isFinished);

	public static T Begin<T>(GameObject go, float duration, float delay = 0f) where T : UITweener
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		T val = default;
		object obj = val + 20;
		obj = go;
		return val;
	}

	public virtual void SetStartToCurrentValue()
	{
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_006c: Expected I, but got Obj
		bool flag = mFactor > 0f;
		float num = tweenFactor;
		if (flag)
		{
			float num2 = 0f - num;
			mAmountPerDelta = num2;
		}
		else
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num5 = Math.Abs(num);
			mAmountPerDelta = num5;
		}
		tag = (string)1;
	}

	public virtual void SetEndToCurrentValue()
	{
	}
}
