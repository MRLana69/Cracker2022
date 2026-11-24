using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Missions;
using TopRun;
using TopRun.Internal;
using UnityEngine;
using UnityEngine.Rendering;

namespace Onboarding;

public static class OnboardingTracking
{
	public enum ScreenType
	{
		Gameover,
		FrontScreen
	}

	private const string PLAYER_PREF_ONBOARDING_GAMEOVER_LOG_KEY = "ShouldLogFrontScreenFlow";

	private const string PLAYER_PREF_ONBOARDING_FRONTSCREEN_LOG_KEY = "ShouldLogGameoverScreenFlow";

	private static List<string> listOfScreensAfterGameover;

	private static List<string> listOfScreensAfterFrontscreen;

	private const int LOG_LIMIT = 6;

	public static void LogScreenFlow(string screenName)
	{
		_ = -1;
		_ = -1;
	}

	private static bool IsTrackingActive()
	{
		//IL_000b: Expected I4, but got Obj
		return (byte)(int)TopRunRoot.manager__BackingField != 0;
	}

	private static bool IsTrackingActiveFor(ScreenType screenType)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenType @ L0 (Onboarding.OnboardingTracking+ScreenType)+C]");
		return false;
	}

	private static void DisableOnboardingTracking(ScreenType screenType)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AwardStaticData[] awards = AwardsData.awards;
		if (awards == null)
		{
			return;
		}
		nint num3 = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DispatchQueuedEventsIfNeeded(screenType);
	}

	public static void EnableOnboardingTracking(ScreenType screenType)
	{
		object obj = ((screenType != ScreenType.FrontScreen) ? "" : "ShouldLogGameoverScreenFlow");
		if (screenType == ScreenType.Gameover)
		{
			obj = "ShouldLogFrontScreenFlow";
		}
		PropertyAttribute propertyAttribute = (PropertyAttribute)obj;
		bool flag;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v10 (UnityEngine.PropertyAttribute)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			((PropertyAttribute)obj)._002Ector();
			RenderPipelineManager.CleanupRenderPipeline();
		}
	}

	private static void QueueOnboardingEvents(string screenName)
	{
		//IL_0069: Expected Obj, but got I4
		object obj = (((nint)screenName != 1) ? "" : "ShouldLogGameoverScreenFlow");
		if (screenName == null)
		{
			obj = "ShouldLogFrontScreenFlow";
		}
		string text = (string)obj;
		if (obj != null && text.m_stringLength != 0)
		{
			PlayerPrefs.SetString((string)obj, (string)1);
			RenderPipelineManager.CleanupRenderPipeline();
		}
	}

	private static void DispatchQueuedEventsIfNeeded(ScreenType screenType)
	{
		//IL_033b: Expected I, but got Obj
		//IL_0351: Expected Obj, but got I
		//IL_03b2: Expected I, but got Obj
		//IL_03c8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01f4: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_03f3: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_02ad: Expected I, but got Obj
		//IL_02c3: Expected Obj, but got I
		//IL_0235: Expected I, but got Obj
		//IL_015a: Expected I, but got Obj
		//IL_0447: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_02ee: Expected I, but got Obj
		nint num = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v99 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (LogLimitReached(ScreenType.FrontScreen))
		{
			nint num3 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v63 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(OnboardingTracking);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v93 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<string> list = listOfScreensAfterFrontscreen;
			if (list._size >= 1 || (string)screenType != "FrontScreen")
			{
				nint num5 = (nint)typeof(OnboardingTracking);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v76 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(OnboardingTracking);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v84 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				listOfScreensAfterFrontscreen.Add((string)screenType);
				DispatchEvents(ScreenType.FrontScreen);
			}
		}
		nint num7 = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v14 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v58 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!LogLimitReached(ScreenType.Gameover))
		{
			return;
		}
		nint num9 = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v22 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v52 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<string> list2 = listOfScreensAfterGameover;
		if (list2._size < 1 && !((string)screenType != "GameOverScreen"))
		{
			return;
		}
		nint num11 = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v35 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v43 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		listOfScreensAfterGameover.Add((string)screenType);
		DispatchEvents(ScreenType.Gameover);
	}

	private static void DispatchEvents(ScreenType screenType)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AwardStaticData awardsData = ((Award)screenType).awardsData;
		if (awardsData == null)
		{
			return;
		}
		nint num3 = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Award)screenType).Activate();
	}

	private static bool LogLimitReached(ScreenType screenType)
	{
		object obj = ((screenType != ScreenType.FrontScreen) ? "" : "ShouldLogGameoverScreenFlow");
		if (screenType == ScreenType.Gameover)
		{
			obj = "ShouldLogFrontScreenFlow";
		}
		string text = (string)obj;
		if (obj == null || text.m_stringLength == 0)
		{
			return false;
		}
		string text2 = PlayerPrefs.GetString((string)obj, null);
		return text2 != null;
	}

	public static void OnApplicationQuit()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RanksData ranksData = default;
		TopRunSave.ranksData = ranksData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RanksData ranksData2 = default;
		ranksData2._002Ector();
		TopRunSave.lastTopRunResultAwardedID = (string)(object)ranksData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TournamentData tournamentData = default;
		tournamentData._002Ector();
		TopRunSave.playerIdsData = (PlayerIdsData)(object)tournamentData;
	}

	static OnboardingTracking()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AwardStaticData[] awards = AwardsData.awards;
		if (awards == null)
		{
			return;
		}
		nint num3 = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Award)null).Activate();
		((Award)1).Activate();
	}
}
