using System;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class NotebookScreen : UIScreen
{
	private UITexture blurredBackground;

	private UISprite background;

	private UISprite decal;

	private UISprite spiral;

	private UIAnchor _topDecalAnchor;

	private UIAnchor _centerBackrenderAnchor;

	private const int _pixelsOutsideTheBackground = 84;

	private const int _pixelsOutsideTheDecal = 130;

	private bool isOnLoadScreen;

	public override void Show()
	{
		base.Show();
		ShowBackground();
	}

	public override void Hide()
	{
		base.Hide();
		HideBackground();
	}

	public override void AdjustToResolution()
	{
		//IL_0125: Expected Obj, but got I4
		//IL_015e: Expected I4, but got F8
		//IL_0344: Expected Obj, but got I4
		//IL_01a5: Expected I4, but got F8
		//IL_01ec: Expected I4, but got F8
		//IL_0233: Expected I4, but got F8
		UIScreenController instance = UIScreenController.Instance;
		UIRoot uIRoot;
		if (instance != null)
		{
			UIScreenController instance2 = UIScreenController.Instance;
			uIRoot = instance2.root;
		}
		else
		{
			isOnLoadScreen = true;
			uIRoot = null;
		}
		bool flag = uIRoot == null;
		bool flag2 = !flag;
		UIRoot uIRoot2 = uIRoot;
		if (!flag2)
		{
			GameObject go = gameObject;
			UIRoot uIRoot3 = NGUITools.FindInParents<UIRoot>(go);
			uIRoot2 = uIRoot3;
		}
		if (~(isOnLoadScreen ? 1u : 0u) != 0)
		{
			if (UIScreen.IsScreenHeightOutOfProportion() && background != null && decal != null)
			{
				UISprite uISprite = background;
				object obj = uIRoot2.manualHeight - 84;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num2 = default;
				double num = Math.Abs(num2);
				int width = ((!(num < 2147483648.0)) ? int.MinValue : ((int)num2));
				background.width = width;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num4 = default;
				double num3 = Math.Abs(num4);
				int height = ((!(num3 < 2147483648.0)) ? int.MinValue : ((int)num4));
				background.height = height;
				UISprite uISprite2 = decal;
				object obj2 = uIRoot2.manualHeight - 130;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num6 = default;
				double num5 = Math.Abs(num6);
				int width2 = ((!(num5 < 2147483648.0)) ? int.MinValue : ((int)num6));
				decal.width = width2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num8 = default;
				double num7 = Math.Abs(num8);
				int height2 = ((!(num7 < 2147483648.0)) ? int.MinValue : ((int)num8));
				decal.height = height2;
			}
			if (~(isOnLoadScreen ? 1u : 0u) != 0)
			{
				return;
			}
		}
		ScaleForLoadScene();
	}

	private unsafe void ScaleForLoadScene()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected VT, but got Unknown
		//IL_0112: Expected native int or pointer, but got VT
		//IL_0146: Expected F4, but got I
		//IL_0141: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Transform transform = _topDecalAnchor.transform;
		Transform transform2 = _topDecalAnchor.transform;
		Vector3 localPosition = transform2.localPosition;
		Transform transform3 = _topDecalAnchor.transform;
		Vector3 localPosition2 = transform3.localPosition;
		_ = 1131413504;
		_ = 1131413504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 localPosition3 = vector + 16;
		transform.localPosition = localPosition3;
		Transform transform4 = _centerBackrenderAnchor.transform;
		Transform transform5 = _centerBackrenderAnchor.transform;
		Vector3 localPosition4 = transform5.localPosition;
		Transform transform6 = _centerBackrenderAnchor.transform;
		Vector3 localPosition5 = transform6.localPosition;
		_ = 1131413504;
		((Vector3*)(nint)vector)->z = 240f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		transform4.localPosition = vector;
	}

	public void ShowBackground()
	{
		blurredBackground.enabled = true;
	}

	public void HideBackground()
	{
		blurredBackground.enabled = false;
	}
}
