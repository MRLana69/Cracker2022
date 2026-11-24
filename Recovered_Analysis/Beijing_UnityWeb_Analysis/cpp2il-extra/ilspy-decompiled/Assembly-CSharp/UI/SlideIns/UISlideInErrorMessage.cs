using Cpp2ILInjected;
using UI.Generic.Layout;

namespace UI.SlideIns;

public class UISlideInErrorMessage : UISlideIn
{
	private UILabel _messageLabel;

	private Layout _layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		object obj = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInErrorMessage)+54]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+C]");
		((UILabel)obj).fontSize = 0;
	}

	public UISlideInErrorMessage()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A96");
	}
}
