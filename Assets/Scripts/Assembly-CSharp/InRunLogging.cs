using System;
using Cpp2ILInjected;
using Kiloo.Analytics;
using SYBO.Subway;

public static class InRunLogging
{
	private static int _headstartUsedInRun;

	private static int _scoreboostersUsedInRun;

	private static bool _isFirstShow = true;

	private static bool _isInitialized;

	private static Action _003C_003Ef__mg_0024cache0;

	private static Action _003C_003Ef__mg_0024cache1;

	private static Action<int> _003C_003Ef__mg_0024cache2;

	private static Action<int> _003C_003Ef__mg_0024cache3;

	public unsafe static void Init()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			Action action = default;
			action._002Ector(null, (nint)(delegate*<void>)(&OnGameStarted));
			Game.OnGameStarted += action;
			Action action2 = default;
			action2._002Ector(null, (nint)(delegate*<void>)(&OnMenuScreenShown));
			Game.OnMenuScreenShown += action2;
			throw new ArgumentException();
		}
	}

	private static void OnScoreBoostActivated(int tier)
	{
		_scoreboostersUsedInRun = tier;
	}

	private static void OnHeadstartActivated(int tier)
	{
		_headstartUsedInRun = tier;
	}

	private static void OnGameStarted()
	{
		_headstartUsedInRun = 0;
		_scoreboostersUsedInRun = 0;
	}

	private unsafe static void OnMenuScreenShown()
	{
		//IL_0041: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		if (~(_isFirstShow ? 1u : 0u) == 0)
		{
			_isFirstShow = false;
			return;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		nint num3 = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v17 (Il2CppClass<InRunLogging>)+5C]");
		string text = ((int*)null)->ToString();
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v23 (Il2CppClass<InRunLogging>)+5C]");
		int num7 = (int)((nint)0 + (nint)4);
		string text2 = ((int*)num7)->ToString();
		nint num8 = 0;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S5_v9+4] (should have been resolved before IL gen)");
		Manager.LogEvent(EventType.RunEnded);
	}
}
