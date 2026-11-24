//Type is in global namespace

public static class IPhoneXSupport
{
	private const int PADDING_MINIMIZATION = 11; //Field offset: 0x0
	public static int OFFSET_TOP; //Field offset: 0x0
	public static int OFFSET_BOTTOM; //Field offset: 0x4
	private static bool _isiPhoneXDevice; //Field offset: 0x8
	private static bool _hasCheckedOnce; //Field offset: 0x9

	public static bool IsiPhoneXDevice
	{
		 get { } //Length: 92
	}

	public static int OFFSET_TOP_EXTRA
	{
		 get { } //Length: 7
	}

	private static IPhoneXSupport() { }

	private static bool CheckIsiPhoneXDevice() { }

	public static bool get_IsiPhoneXDevice() { }

	public static int get_OFFSET_TOP_EXTRA() { }

	public static int GetPixelOffset(int offset) { }

	private static void SetOffsets(out bool insetsWereDetected) { }

}

