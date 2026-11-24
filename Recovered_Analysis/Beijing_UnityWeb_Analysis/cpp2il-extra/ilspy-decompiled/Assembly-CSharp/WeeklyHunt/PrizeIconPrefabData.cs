using System;
using Cpp2ILInjected;
using Data.Save;
using UnityEngine;
using WordHunt;

namespace WeeklyHunt;

public class PrizeIconPrefabData : ScriptableObject
{
	private static PrizeIconPrefabData _instance;

	private GameObject _keyIconPrefab;

	private GameObject _superMysteryBoxIconPrefab;

	private GameObject _hoverboardIconPrefab;

	private GameObject _scoreBoosterIconPrefab;

	private GameObject _headstartIconPrefab;

	private GameObject _christmasBoardIconPrefab;

	private GameObject _rioBoard2IconPrefab;

	private GameObject _northpoleBoard2016IconPrefab;

	private GameObject _cherryBoardIconPrefab;

	public static PrizeIconPrefabData instance
	{
		get
		{
			//IL_00f3: Expected Obj, but got I4
			//IL_0101: Expected I, but got Obj
			//IL_0117: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0145: Expected Obj, but got VT
			//IL_0174: Expected Obj, but got I4
			//IL_00a1: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v32 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (WordHuntManager.HasTimeLeft())
			{
				nint num3 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v28 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime wordHuntExpireDeviceTime = EventsSave.wordHuntExpireDeviceTime;
				obj = wordHuntExpireDeviceTime;
				double num5 = (double)obj * 1E-07;
				bool flag = num5 > 0.0;
				return (PrizeIconPrefabData)flag;
			}
			return null;
		}
	}

	public GameObject GetPrefab(WeeklyHuntData.PrizeData prizeData)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RankException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		GameObject result = default;
		return result;
	}

	public PrizeIconPrefabData()
	{
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		int remainingSeconds = ((WordHuntManager)(object)this).GetRemainingSeconds();
		bool additionalOffset = WeeklyHuntData.ShouldResetChallengeData((string)null);
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v8 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.DebugJumpToWeek(remainingSeconds, additionalOffset ? 1 : 0);
	}
}
