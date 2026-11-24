using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.Validators;

namespace SYBO.Subway.Managers;

public class AutomatedRunManager : SingletonMonoBehaviour<AutomatedRunManager>
{
	public const string AutomatedRunFinishedFileName = "sybo_automated_run_finished.txt";

	private int _gameAutoStartCount;

	private int _gameAutoRestartDelay;

	private int _gameAutoReviveCount;

	private float _hitsEnabledDelayedSeconds;

	private bool _enableBenchmarking;

	private int _numberOfFakeEvents;

	private float _flushDelay;

	private bool _editorEnabledEventTesting;

	public AutomatedRunManager()
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
		object obj2 = (object)((object)0 & 0x1FFF) + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj3 = this + 16;
		object obj4 = default;
		obj3 = obj4;
		((Validator<>)(object)this)._002Ector();
	}
}
