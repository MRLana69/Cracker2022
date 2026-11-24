using System;
using Cpp2ILInjected;
using Data.Save.Internal;

namespace Data.Save;

public class OnboardingSave : DataManager<OnboardingSave>
{
	public static bool allowSellHeadstartDuringRun
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+18]");
			return false;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			((DataManager<>)value).OnSaveGameChanged();
		}
	}

	public static bool allowSellScoreboosterDuringRun
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+20C]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool hasCollectedFromFriends
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+20D]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool hasShownCollectPopup
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+20E]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool hasShownFacebookPopup
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+20F]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool hasShownHoverboardPopup
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+210]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool hasShownMissionIntroPopup
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+211]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool hasShownEndGameMissionPopup
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+212]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool isTutorialCompleted
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+213]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int numberOfRunsSinceLastGuideline
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+214]");
			return ((nint)0 != 0) ? 1 : 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			int num = value & 1;
		}
	}

	public static bool shouldShowCollectPopup
	{
		get
		{
			//IL_0018: Expected I4, but got Obj
			CloudData cloudData = DataManager<>.cloud;
			return (byte)(int)cloudData.mysteryBoxesOpened != 0;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			CloudData cloudData = DataManager<>.cloud;
			cloudData.mysteryBoxesOpened = (int[])value;
		}
	}

	public static bool shouldShowFacebookPopup
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+215]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool shouldShowHoverboardPopup
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+216]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool shouldShowMissionIntroPopup
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+217]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool shouldShowEndGameMissionPopup
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+218]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int lastShownTopRunIntroPopupVersionNumber
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+219]");
			return ((nint)0 != 0) ? 1 : 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			int num = value & 1;
		}
	}

	public static DateTime lastShownCloudSaveIntroduction
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+F0]");
			return (DateTime)0;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public static bool ShouldShowStickersForCharacterThemes()
	{
		LocalDebugData localDebugData = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+21C]");
		return false;
	}

	public static bool ShouldShowStickersForHoverboards()
	{
		if (hasShownMissionIntroPopup)
		{
			return true;
		}
		if (hasShownFacebookPopup)
		{
			return true;
		}
		if (hasShownHoverboardPopup)
		{
			return true;
		}
		return hasShownEndGameMissionPopup;
	}

	public OnboardingSave()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0036: Expected I4, but got Obj
		CloudData cloudData = DataManager<>.cloud;
		object obj = this + 8;
		obj = this;
		cloudData.completedRunCount = (int)obj;
	}
}
