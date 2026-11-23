using System;
using Cpp2ILInjected;
using UnityEngine;

public class TweenWidth : UITweener
{
	public int from = 100;

	public int to;

	public bool updateTable;

	private UIWidget mWidget;

	private UITable mTable;

	public UIWidget cachedWidget
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 92;
			if (mWidget == null)
			{
				UIWidget component = GetComponent<UIWidget>();
				mWidget = component;
			}
			return (UIWidget)result;
		}
	}

	public int width
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

	public int value
	{
		get
		{
			UIWidget uIWidget = cachedWidget;
			return uIWidget.mWidth;
		}
		set
		{
			UIWidget uIWidget = cachedWidget;
			uIWidget.width = value;
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		//IL_0039: Expected I4, but got F8
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		float num = 1f - factor;
		float num2 = (float)from * num;
		float num3 = (float)to * factor;
		float num4 = num2 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num6 = default;
		double num5 = Math.Abs(num6);
		int num7 = ((!(num5 < 2147483648.0)) ? int.MinValue : ((int)num6));
		value = num7;
		if (~(updateTable ? 1u : 0u) != 0)
		{
			return;
		}
		object obj = this + 96;
		if (mTable == null)
		{
			GameObject go = gameObject;
			UITable uITable = NGUITools.FindInParents<UITable>(go);
			mTable = uITable;
			if (mTable == null)
			{
				updateTable = false;
				return;
			}
		}
		((UITable)obj).repositionNow = true;
	}

	public static TweenWidth Begin(UIWidget widget, float duration, int width)
	{
		GameObject go = widget.gameObject;
		TweenWidth tweenWidth = UITweener.Begin<TweenWidth>(go, duration);
		tweenWidth.to = width;
		tweenWidth.from = widget.mWidth;
		if (!(duration > 0f))
		{
			tweenWidth.Sample(1f, isFinished: true);
			tweenWidth.enabled = false;
		}
		return tweenWidth;
	}

	public override void SetStartToCurrentValue()
	{
		int num = value;
		from = num;
	}

	public override void SetEndToCurrentValue()
	{
		int num = value;
		to = num;
	}

	private void SetCurrentValueToStart()
	{
		value = from;
	}

	private void SetCurrentValueToEnd()
	{
		value = to;
	}

	public TweenWidth()
	{
		//IL_000f: Expected I4, but got I8
	}
}
