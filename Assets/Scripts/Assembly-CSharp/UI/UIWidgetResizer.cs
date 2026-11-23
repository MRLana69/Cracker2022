using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class UIWidgetResizer : MonoBehaviour
{
	private UIWidget _anchorBackground;

	private const int PIXELS_OUTSIDE_THE_BACKGROUND = 84;

	private void OnEnable()
	{
		AdjustAnchorBackgroundToResolution();
	}

	public void AdjustAnchorBackgroundToResolution()
	{
		//IL_015d: Expected Obj, but got I
		//IL_00ae: Expected I4, but got F8
		//IL_00f5: Expected I4, but got F8
		UIScreenController instance = UIScreenController.Instance;
		bool flag = instance != null;
		bool flag2 = !flag;
		UnityEngine.Object obj = null;
		if (!flag2)
		{
			UIScreenController instance2 = UIScreenController.Instance;
			obj = instance2.root;
		}
		if (obj == null)
		{
			GameObject go = gameObject;
			UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(go);
			obj = uIRoot;
		}
		UIWidget anchorBackground = _anchorBackground;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ L1_v3 (UnityEngine.Object)+14]");
		object obj2 = -84;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		int width = ((!(num < 2147483648.0)) ? int.MinValue : ((int)num2));
		_anchorBackground.width = width;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num4 = default;
		double num3 = Math.Abs(num4);
		int height = ((!(num3 < 2147483648.0)) ? int.MinValue : ((int)num4));
		_anchorBackground.height = height;
	}
}
