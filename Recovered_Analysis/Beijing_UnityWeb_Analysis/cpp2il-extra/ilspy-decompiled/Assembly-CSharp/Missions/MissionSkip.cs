using System;
using Cpp2ILInjected;
using WordHunt;

namespace Missions;

public class MissionSkip
{
	private string name__BackingField;

	private int rawPrice__BackingField;

	private int priceIncrease__BackingField;

	public string name
	{
		get
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			WordHuntManager wordHuntManager = (WordHuntManager)0;
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v16 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return wordHuntManager.GetDailyWordOffline();
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.MissionSkip)+2C]");
			object obj = value + 0;
		}
	}

	public int rawPrice
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)name__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}

	public int priceIncrease
	{
		get
		{
			return rawPrice__BackingField;
		}
		private set
		{
			rawPrice__BackingField = value;
		}
	}

	public MissionSkip(string name, int rawPrice, int priceIncrease)
	{
		throw new ArrayTypeMismatchException();
	}

	public int GetPrice()
	{
		return priceIncrease__BackingField;
	}
}
