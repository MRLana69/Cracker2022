namespace SYBO.Common.Utilities.Flags;

public static class FlagsHelper
{

	public static bool IsSet(T flags, T flag) { }

	public static void Set(ref T flags, T flag) { }

	public static void SetEverything(ref T flags) { }

	public static void SetNothing(ref T flags) { }

	public static void Unset(ref T flags, T flag) { }

}

