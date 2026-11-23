using Cpp2ILInjected;
using UnityEngine;

public class UISlideInTopRunTimer : UISlideIn
{
	private UILabel _timerLabel;

	private UISprite _slideInBackground;

	private UISprite _slideInBackgroundDark;

	private int _NotificationEdgeMargin = 35;

	public unsafe void SetupSlideTopRunTimer(int TimeLeftInTopRunWeekInMinutes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_00ed: Expected I, but got Obj
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		if (TimeLeftInTopRunWeekInMinutes >= 2)
		{
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			string text2 = text + " minutes left!";
			_timerLabel.text = text2;
		}
		else if (TimeLeftInTopRunWeekInMinutes == 1)
		{
			int num2 = obj + 12;
			string text3 = ((int*)num2)->ToString();
			string text4 = text3 + " minute left!";
			_timerLabel.text = text4;
		}
		else
		{
			_timerLabel.text = "Ending Soon!";
		}
		AdjustSlideInNotificationWidth((UILabel)(object)this);
		nint num3 = (nint)this;
		object obj3 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S2_v5 (Il2CppClass<UISlideInTopRunTimer>)+E4] (should have been resolved before IL gen)");
	}

	private void AdjustSlideInNotificationWidth(UILabel timeLabel)
	{
		//IL_002b: Expected Obj, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected I4, but got Unknown
		UISprite slideInBackgroundDark = _slideInBackgroundDark;
		UILabel timerLabel = _timerLabel;
		object obj = ((UIWidget)slideInBackgroundDark).mWidth + ((UIWidget)timerLabel).mWidth;
		int width = _NotificationEdgeMargin + obj;
		_slideInBackground.width = width;
	}
}
