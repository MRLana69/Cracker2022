using Cpp2ILInjected;
using UnityEngine;

namespace UI.Pages.DailyChallengePageInternal;

public abstract class DayHelper : MonoBehaviour
{
	public abstract void Init();

	public abstract void RefreshDay();

	protected DayHelper()
	{
		//IL_0011: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.DailyChallengePageInternal.DayHelper)+1C]");
		string text = ((GameObject)0).tag;
		string text2 = (string)(text ^ 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.DailyChallengePageInternal.DayHelper)+1C]");
		((GameObject)0).tag = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.DailyChallengePageInternal.DayHelper)+18]");
		string text3 = ((GameObject)0).tag;
		string text4 = (string)(text3 ^ 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.DailyChallengePageInternal.DayHelper)+18]");
		((GameObject)0).tag = text4;
	}
}
