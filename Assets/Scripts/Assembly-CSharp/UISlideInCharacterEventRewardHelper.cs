using System;
using Cpp2ILInjected;
using UnityEngine;

public class UISlideInCharacterEventRewardHelper : UISlideIn
{
	private UILabel _label;

	private UISprite _slideInBackground;

	private UISprite _slideInBackgroundDark;

	private const int NOTIFICATION_EDGE_MARGIN = 90;

	private const int MINIMUM_SLIDE_IN_WIDTH = 170;

	public void SetupCharacterEventReward(string payload)
	{
		//IL_0037: Expected I, but got Obj
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		SetLabel(payload);
		AdjustSlideInNotificationWidth();
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S2_v4 (Il2CppClass<UISlideInCharacterEventRewardHelper>)+E4] (should have been resolved before IL gen)");
	}

	private unsafe void SetLabel(string payload)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string text = string.Empty;
		int num = default;
		int num2 = default;
		while (payload._stringLength > num)
		{
			char c = payload.get_Chars(num);
			char c2 = (char)(obj + 14);
			string text2 = ((char*)(ushort)c2)->ToString();
			string text3 = text + text2 + " ";
			num = num2 + 1;
			text = text3;
		}
		if (text._stringLength >= 1)
		{
			int length = text._stringLength - 1;
			string text4 = text.Substring(0, length);
		}
		string newLine = Environment.NewLine;
		string text5 = text + newLine + "complete";
		_label.text = text5;
	}

	private void AdjustSlideInNotificationWidth()
	{
		//IL_002b: Expected Obj, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		UISprite slideInBackgroundDark = _slideInBackgroundDark;
		UILabel label = _label;
		object obj = ((UIWidget)slideInBackgroundDark).mWidth + ((UIWidget)label).mWidth;
		int width = obj + 90;
		_slideInBackground.width = width;
		UILabel label2 = _label;
		int width2 = ((UIWidget)label2).mWidth + 90;
		_slideInBackground.width = width2;
		UISprite slideInBackground = _slideInBackground;
		if (((UIWidget)slideInBackground).mWidth <= 169)
		{
			slideInBackground.width = 170;
		}
	}
}
