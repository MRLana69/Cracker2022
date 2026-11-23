using System;
using Cpp2ILInjected;
using UnityEngine;

public class AnimatedWidget : MonoBehaviour
{
	public float width = 1f;

	public float height;

	private UIWidget mWidget;

	private void OnEnable()
	{
		UIWidget component = GetComponent<UIWidget>();
		mWidget = component;
		LateUpdate();
	}

	private void LateUpdate()
	{
		//IL_003e: Expected I4, but got F8
		//IL_0085: Expected I4, but got F8
		if (mWidget != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num2 = default;
			double num = Math.Abs(num2);
			int num3 = ((!(num < 2147483648.0)) ? int.MinValue : ((int)num2));
			mWidget.width = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num5 = default;
			double num4 = Math.Abs(num5);
			int num6 = ((!(num4 < 2147483648.0)) ? int.MinValue : ((int)num5));
			mWidget.height = num6;
		}
	}
}
