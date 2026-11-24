using Cpp2ILInjected;
using Data.Save;

public static class StatTools
{
	public static void SetValue(Stat stat, int value)
	{
	}

	public static int GetValue(Stat stat)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = stat;
		return num;
	}

	public static void IncrementValue(Stat stat)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public static void AddValue(Stat stat, int value)
	{
		PlayerSave.MigrateMysteryBoxOpened((MysteryBox.Type)stat, value);
	}
}
