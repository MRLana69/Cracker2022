using Cpp2ILInjected;

public static class IPhoneXSupport
{
	private const int PADDING_MINIMIZATION = 11;

	public static int OFFSET_TOP;

	public static int OFFSET_BOTTOM;

	private static bool _isiPhoneXDevice;

	private static bool _hasCheckedOnce;

	public static int OFFSET_TOP_EXTRA => IOSViewController.IsSimulator() ? 1 : 0;

	public static bool IsiPhoneXDevice
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(OFFSET_TOP + 5) != 0;
		}
	}

	private static bool CheckIsiPhoneXDevice()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)StorageSizeLogging.DataSize != 0;
	}

	private static void SetOffsets(out bool insetsWereDetected)
	{
	}

	public static int GetPixelOffset(int offset)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Expected Obj, but got I4
		//IL_0016: Expected I4, but got Obj
		object obj = 0;
		obj = offset;
		return (int)obj;
	}

	static IPhoneXSupport()
	{
		InRunLogging._headstartUsedInRun = 0;
		InRunLogging._scoreboostersUsedInRun = 0;
		InRunLogging._isFirstShow = true;
		InRunLogging._isInitialized = false;
	}
}
