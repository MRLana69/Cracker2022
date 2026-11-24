using Cpp2ILInjected;
using Data.Save.Internal;
using Info;

namespace Data.Save;

public class PreferencesSave : DataManager<PreferencesSave>
{
	public static bool neverAskForRating
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+B0]");
			return (nint)0 != 0;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			((DataManager<>)value).OnSaveGameChanged();
		}
	}

	public static string language
	{
		get
		{
			//IL_002d: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+220]");
			bool flag = (nint)0 != 0;
			return (string)flag;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = value & 1;
		}
	}

	public static bool soundEffectsEnabled
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+224]");
			return false;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 548;
			obj = value;
		}
	}

	public static bool musicEnabled
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+228]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool topRunChallengersEnabled
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+229]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool remoteNotificationsEnabled
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+22A]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int localNotificationsEnabled
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+22B]");
			return ((nint)0 != 0) ? 1 : 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			int num = value & 1;
		}
	}

	public static bool cloudSaveOptedOut
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+22C]");
			return false;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public PreferencesSave()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		CloudData cloudData = DataManager<>.cloud;
		Boards.BoardId currentBoardId = (Boards.BoardId)(this & 1);
		cloudData.currentBoardId = currentBoardId;
	}
}
