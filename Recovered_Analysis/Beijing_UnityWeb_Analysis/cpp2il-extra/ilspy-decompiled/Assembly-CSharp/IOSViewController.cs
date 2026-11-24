using Cpp2ILInjected;
using UnityEngine;

public static class IOSViewController
{
	private static void _ShowStatusBar(bool show)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InRunLogging>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InRunLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<InRunLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InRunLogging._headstartUsedInRun = (show ? 1 : 0);
	}

	private static void _SetStatusBarStyle(int style)
	{
	}

	private static void _SetStatusBarAnimation(int anim)
	{
	}

	private static void _SetEdgeProtection(int sides)
	{
	}

	private static void _SetHomeIndicator(bool show)
	{
	}

	private static bool _GetIsSimulator()
	{
		//IL_005a: Expected I4, but got Obj
		//IL_0026: Expected Obj, but got I4
		if (FPSLog._instance == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			int num = default;
			InRunLogging.OnScoreBoostActivated(num);
			FPSLog._instance = (FPSLog)num;
		}
		return (byte)(int)FPSLog._instance != 0;
	}

	private static int _GetTopInsetInPoints()
	{
		return 0;
	}

	private static int _GetBottomInsetInPoints()
	{
		int sleepTimeout = Screen.sleepTimeout;
		if (sleepTimeout == 2436)
		{
			int height = Screen.height;
			if (height == 1125)
			{
				goto IL_00bc;
			}
		}
		int sleepTimeout2 = Screen.sleepTimeout;
		if (sleepTimeout2 == 2688)
		{
			int height2 = Screen.height;
			if (height2 == 1242)
			{
				goto IL_00bc;
			}
		}
		return 0;
		IL_00bc:
		return 44;
	}

	private static int _GetDeviceHeightInPoints()
	{
		int sleepTimeout = Screen.sleepTimeout;
		if (sleepTimeout == 2436)
		{
			int height = Screen.height;
			if (height == 1125)
			{
				goto IL_00bc;
			}
		}
		int sleepTimeout2 = Screen.sleepTimeout;
		if (sleepTimeout2 == 2688)
		{
			int height2 = Screen.height;
			if (height2 == 1242)
			{
				goto IL_00bc;
			}
		}
		return 0;
		IL_00bc:
		return 34;
	}

	public static void ShowStatusBar(bool show)
	{
	}

	public static void SetStatusBarStyle(IOSStatusBarStyle style)
	{
	}

	public static void SetStatusBarAnimation(IOSStatusBarAnimation anim)
	{
	}

	public static void SetProtectedEdges(IOSUIRectEdge sides)
	{
	}

	public static void ShowHomeIndicator(bool show)
	{
	}

	public static bool IsSimulator()
	{
		int sleepTimeout = Screen.sleepTimeout;
		if (sleepTimeout == 2436)
		{
			int height = Screen.height;
			if (height == 1125)
			{
				return true;
			}
		}
		int sleepTimeout2 = Screen.sleepTimeout;
		if (sleepTimeout2 == 2688)
		{
			int height2 = Screen.height;
			if (height2 == 1242)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static int GetTopInsetInPoints()
	{
		return 0;
	}

	public static int GetBottomInsetInPoints()
	{
		return _GetBottomInsetInPoints();
	}

	public static int GetDeviceHeightInPoints()
	{
		return _GetDeviceHeightInPoints();
	}
}
