using Cpp2ILInjected;
using Data.Save.Internal;
using Kiloo.Common.Utility;

namespace Data.Save;

public class DebugSave : DataManager<DebugSave>
{
	public static SaveDataStrings debug_saveData
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+260]");
			return (SaveDataStrings)0;
		}
		set
		{
		}
	}

	public static int overridePerformanceLevel
	{
		get
		{
			//IL_001c: Expected Obj, but got I4
			//IL_0020: Expected I4, but got Obj
			LocalData localData = DataManager<>.local;
			return (int)SaveManager.GetCloudFileFullPath((string)localData.hasMigratedPlayerInfo);
		}
		set
		{
			//IL_0020: Expected Obj, but got I4
			//IL_0020: Expected Obj, but got I4
			LocalData localData = DataManager<>.local;
			((SaveGame)localData.hasMigratedPlayerInfo).MigrateToCloud((string)value);
		}
	}

	public DebugSave()
	{
		//IL_000e: Expected VT, but got Obj
		_00210 val = (_00210)UnityManager<>.instance;
	}
}
