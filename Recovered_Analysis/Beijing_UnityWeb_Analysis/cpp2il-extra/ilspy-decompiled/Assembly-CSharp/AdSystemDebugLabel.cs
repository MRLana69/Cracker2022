using System;
using Cpp2ILInjected;
using UnityEngine;

public class AdSystemDebugLabel : MonoBehaviour
{
	private UILabel _label;

	private UISprite _background;

	private int _originalBackgroundWidth;

	private string _originalLabelText;

	private void Awake()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
	}

	private void FinishedShowingAd(string adLocationID)
	{
		_ = 0;
		bool flag = adLocationID != "true";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CE4");
	}

	private void OnWillShowAd(string adLocationID)
	{
		//IL_0011: Expected I4, but got Obj
		_label.fontSize = (int)_originalLabelText;
		_background.height = _originalBackgroundWidth;
	}

	public AdSystemDebugLabel()
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		UISprite background = _background;
		_originalBackgroundWidth = ((UIWidget)background).mWidth;
		object obj = this + 24;
		UILabel label = _label;
		obj = label.mText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj2 = action + 16;
		obj2 = this;
		AdSystemManager.onWillShowInterstitial -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		AdSystemManager.onWillShowVideo -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj4 = action3 + 16;
		obj4 = this;
		AdSystemManager.onDismissedInterstitial -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj5 = action4 + 16;
		obj5 = this;
		AdSystemManager.onDismissedVideo -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action5 = default;
		object obj6 = action5 + 16;
		obj6 = this;
		AdSystemManager.onFinishedWatchingVideo -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<string> action6 = default;
		object obj7 = action6 + 16;
		obj7 = this;
		AdSystemManager.onFailedToShowVideo -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string> action7 = default;
		object obj8 = action7 + 16;
		obj8 = this;
		AdSystemManager.onFailedToShowInterstitial -= action7;
	}
}
