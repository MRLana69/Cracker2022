using Cpp2ILInjected;

public class Upgrade
{
	public StringID name;

	public StringID nameTwoLines;

	public StringID description;

	public StringID mysteryBoxDescription;

	public int numberOfTiers;

	public float[] durations;

	public float speed;

	public float landSpeed;

	public int spawnProbability;

	public int minimumMeters;

	public int coinmagnetRange;

	public int[] pricesRaw;

	public int levelPriceMultiplyer;

	public string iconName;

	public int weight;

	public StringID GetName()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_008f: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I4
		string text = Strings.Get(nameTwoLines);
		object obj;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_0069;
			}
		}
		obj = 1;
		goto IL_0069;
		IL_0069:
		object obj2 = 8;
		if (obj == null)
		{
			obj2 = 12;
		}
		object obj3 = (object)this + obj2;
		return (StringID)obj3;
	}

	public int getPrice(int tier)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected I4, but got Unknown
		if (pricesRaw == null)
		{
			return -1;
		}
		int num = tier << 2;
		object obj = pricesRaw + num;
		MissionsManager instance = MissionsManager.Instance;
		PlayerInfo playerinfo = instance.playerinfo;
		MissionsManager instance2 = MissionsManager.Instance;
		int num2 = instance2.missionSetStoryCount;
		if (playerinfo._currentMissionSet <= num2)
		{
			num2 = playerinfo._currentMissionSet;
		}
		bool flag = playerinfo._currentMissionSet < 0;
		int num3 = 0;
		if (!flag)
		{
			num3 = num2;
		}
		object obj2 = num3 * levelPriceMultiplyer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v5+10]");
		return 0 + obj2;
	}
}
