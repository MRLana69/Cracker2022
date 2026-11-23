using System;
using Cpp2ILInjected;

public class Achievements
{
	public const int NUMBER_OF_ACHIEVEMENTS = 41;

	private string[] _achievementIds;

	private Mission[] _achievementArray;

	private static Achievements _instance;

	public string[] achievementIds => _achievementIds;

	public Mission[] achievementArray => _achievementArray;

	public static Achievements Instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			Achievements result = _instance;
			if (!flag2)
			{
				Achievements achievements = default;
				achievements._002Ector();
				_instance = achievements;
				result = achievements;
			}
			return result;
		}
	}

	public int GetNumberOfHoverboardsUsed()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			Mission[] array = _achievementArray;
			if (array.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 3;
			object obj3 = (object)array + obj2;
			object obj4 = obj3 + 16;
			if ((nint)obj4 == 45)
			{
				PlayerInfo instance = PlayerInfo.Instance;
				object obj5 = obj << 2;
				object obj6 = (object)instance._achievementProgress + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23+10]");
				return 0;
			}
			object obj7 = obj + 1;
			obj = obj7;
		}
		return 0;
	}

	public int getAchievementIndexInArray(MissionType type)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		int num = 0;
		while (true)
		{
			if (num < 41)
			{
				int num2 = num << 3;
				object obj = _achievementArray + num2;
				object obj2 = obj + 16;
				if ((nint)obj2 == (nint)type)
				{
					break;
				}
				int num3 = num + 1;
				num = num3;
				continue;
			}
			num = -1;
			break;
		}
		return num;
	}

	public Achievements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
