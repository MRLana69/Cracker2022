using System;
using Cpp2ILInjected;
using UnityEngine;

public class TweenAlpha : UITweener
{
	public float from = 1f;

	public float to;

	private bool mCached;

	private UIRect mRect;

	private Material mMat;

	private SpriteRenderer mSr;

	public float alpha
	{
		get
		{
			return value;
		}
		set
		{
			this.value = value;
		}
	}

	public unsafe float value
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_005e: Expected I, but got Obj
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected Obj, but got Unknown
			//IL_0118: Expected F4, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			if (~(mCached ? 1u : 0u) != 0)
			{
				Cache();
			}
			float result = default;
			if (mRect != null)
			{
				UIRect uIRect = mRect;
				nint num = (nint)uIRect;
				object obj3 = uIRect + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S1_v17 (Il2CppClass<UIRect>)+F4] (should have been resolved before IL gen)");
			}
			else
			{
				if (mSr != null)
				{
					Color color = mSr.color;
				}
				else
				{
					bool flag = mMat != null;
					bool flag2 = !flag;
					result = 1f;
					if (flag2)
					{
						goto IL_0141;
					}
					Color color2 = mMat.color;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				result = 0f;
			}
			goto IL_0141;
			IL_0141:
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			//IL_00f1: Expected F4, but got I
			//IL_00ec: Expected native int or pointer, but got VT
			//IL_0113: Expected F4, but got I
			//IL_010e: Expected native int or pointer, but got VT
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected VT, but got Unknown
			object obj = default;
			Color color = (Color)(obj - 96);
			if (~(mCached ? 1u : 0u) != 0)
			{
				Cache();
			}
			if (mRect != null)
			{
				UIRect uIRect = mRect;
				object obj2 = uIRect - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S2_v12+BC] (should have been resolved before IL gen)");
			}
			else if (mSr != null)
			{
				Color color2 = mSr.color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
				((Color*)(nint)color)->b = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
				((Color*)(nint)color)->r = 0f;
				mSr.color = color;
			}
			else if (mMat != null)
			{
				Color color3 = mMat.color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
				_ = 0;
				Color color4 = color + 16;
				mMat.color = color4;
			}
		}
	}

	private void Cache()
	{
		mCached = true;
		UIRect component = GetComponent<UIRect>();
		mRect = component;
		SpriteRenderer component2 = GetComponent<SpriteRenderer>();
		mSr = component2;
		if (mRect == null && mSr == null)
		{
			Renderer component3 = GetComponent<Renderer>();
			if (component3 != null)
			{
				Material material = component3.material;
				mMat = material;
			}
			if (mMat == null)
			{
				UIRect componentInChildren = GetComponentInChildren<UIRect>();
				mRect = componentInChildren;
			}
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		float num = to - from;
		float num2 = Math.Min(factor, 1f);
		bool flag = factor < 0f;
		float num3 = 0f;
		if (!flag)
		{
			num3 = num2;
		}
		float num4 = num * num3;
		float num5 = from + num4;
		value = num5;
	}

	public static TweenAlpha Begin(GameObject go, float duration, float alpha)
	{
		TweenAlpha tweenAlpha = UITweener.Begin<TweenAlpha>(go, duration);
		float num = tweenAlpha.value;
		tweenAlpha.to = alpha;
		tweenAlpha.from = num;
		if (!(duration > 0f))
		{
			tweenAlpha.Sample(1f, isFinished: true);
			tweenAlpha.enabled = false;
		}
		return tweenAlpha;
	}

	public override void SetStartToCurrentValue()
	{
		float num = value;
		from = num;
	}

	public override void SetEndToCurrentValue()
	{
		float num = value;
		to = num;
	}
}
