using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Missions;

namespace Info;

public class Upgrade
{
	public string name;

	public string nameTwoLines;

	public string description;

	public string mysteryBoxDescription;

	public int numberOfTiers;

	public float[] durations;

	public float speed;

	public float landSpeed;

	public int spawnProbability;

	public int[] pricesRaw;

	public string iconName;

	public int weight;

	public string GetName()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0105: Expected I4, but got Obj
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Trophies);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Trophies>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Trophies);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<Info.Trophies>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Trophies.ShouldSpawnTrophy((Trophies.Trophy)this);
		nint num3 = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v20 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance = MissionsManager.Instance;
		return (string)((CollectCoinsSingleRun)(object)instance).GetProgressForGoal((AwardGoal)flag);
	}

	public int GetPrice(int tier)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = tier;
		if (name != null)
		{
			string text = name;
			if (text.m_firstChar != '\0')
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				Func<_0021_00210, bool> func = default;
				object obj3 = func + 16;
				obj3 = obj2;
				return Enumerable.All<TSource>((IEnumerable<TSource>)(object)name, (Func<TSource, bool>)(object)func) ? 1 : 0;
			}
			return 0;
		}
		return 0;
	}
}
