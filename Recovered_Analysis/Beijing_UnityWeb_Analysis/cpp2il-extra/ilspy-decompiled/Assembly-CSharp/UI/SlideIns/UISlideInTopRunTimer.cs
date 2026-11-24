using Cpp2ILInjected;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInTopRunTimer : UISlideIn
{
	private UILabel _topRunLabel;

	private UILabel _timerLabel;

	private Layout _layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_002c: Expected I4, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		_topRunLabel.fontSize = (int)slideIn;
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}

	public UISlideInTopRunTimer()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got F4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		object obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0f;
		_ = -45f;
		object obj2 = obj + 12;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj3 = this + 72;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		_ = 0;
		((UISlideInAdsRemoved)this)._002Ector();
	}
}
