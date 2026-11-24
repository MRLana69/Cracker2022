using System;
using System.Collections.Generic;
using System.IO;
using AppRefresh;
using Authentication;
using Cpp2ILInjected;
using Data.Managers;
using Data.Migration;
using Data.Save.Internal;
using Info;
using Kiloo;
using Kiloo.Common.Extensions;
using Kiloo.Common.HTTP;
using Kiloo.Google.Internal;
using Kiloo.Serialization;
using UnityEngine;
using UnityEngine.Rendering;

namespace Data.Save;

public static class SaveManager
{
	private const string LOCAL_FILE = "local";

	private const string CLOUD_FILE_PREFIX = "cloud";

	private const string SAVE_FOLDER_NAME = "Save";

	private const string LAST_USED_KILOOTAG_KEY = "CloudSaveLastUsedKilooTag";

	private static readonly string SAVE_PATH;

	private static readonly string LOCAL_FILE_PATH;

	private static Action m_saveGameChanged;

	private static SaveGame _activeSaveGame;

	private static bool _hasInited;

	public static event Action saveGameChanged
	{
		add
		{
			//IL_0074: Expected Obj, but got I
			//IL_0082: Expected Obj, but got I
			//IL_0090: Expected I, but got Obj
			//IL_00a6: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			((GoogleSignInBridgeRequest<>)(nint)((Delegate)value).method_ptr)._002Ector();
			((GoogleSignInBridgeRequest<>)(nint)((Delegate)value).invoke_impl)._002Ector();
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v20 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG ? 1u : 0u) == 0)
			{
				((GoogleSignInBridgeRequest<>)((Delegate)value).m_target)._002Ector();
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SaveManager.m_saveGameChanged;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Save.SaveManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SaveManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(SaveManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Save.SaveManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SaveManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SaveManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Save.SaveManager>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	static SaveManager()
	{
		PlayerSave.SetCurrentMissionProgress(0, 0);
		PlayerSave.SetCurrentMissionProgress(1, 0);
		PlayerSave.SetCurrentMissionProgress(2, 0);
	}

	private static void OnAppRefresh(RefreshType refreshType)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = SaveManager.m_saveGameChanged;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)refreshType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(SaveManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Save.SaveManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(SaveManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(SaveManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Save.SaveManager>)+5C]");
			object obj5 = (nint)0 + (nint)8;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private static string GetSavedKilooTag()
	{
		//IL_002a: Expected Obj, but got I4
		CloudData cloud = DataManager<>.cloud;
		bool flag = cloud.currentBoardId != Boards.BoardId.normal;
		return (string)flag;
	}

	public unsafe static void Init()
	{
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I4
		//IL_01b4: Expected I, but got Obj
		//IL_01ca: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0219: Expected Obj, but got I4
		//IL_00e4: Expected I, but got Obj
		string temporaryCachePath = Application.temporaryCachePath;
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v31 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot(temporaryCachePath, "Save");
		SAVE_PATH = (string)flag;
		bool flag2 = Path.SameRoot(SAVE_PATH, "local");
		nint num3 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v17 (Il2CppClass<Data.Save.SaveManager>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = flag2;
		DebugSaveGameChange(SAVE_PATH);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&OnAuthenticated);
		object obj3 = action + 16;
		obj3 = 0;
		nint num4 = (nint)typeof(Auth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31 (Il2CppClass<Authentication.Auth>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v48 (Il2CppClass<Authentication.Auth>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Auth.authenticated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<RefreshType> action2 = default;
		object obj5 = action2 + 16;
		obj5 = 0;
		AppRefreshHandler.refresh -= action2;
		CreateSaveFolderIfNeeded("");
	}

	private static void SaveKilooTag(string s)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = s;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (!obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			return;
		}
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnAuthenticated();
	}

	public static string GetCurrentCloudFilename()
	{
		//IL_0014: Expected I4, but got Obj
		//IL_0014: Expected I4, but got Obj
		//IL_0018: Expected Obj, but got I4
		return (string)UnityEngine.Random.Range((int)"CloudSaveLastUsedKilooTag", (int)string.Empty);
	}

	public static string GetCloudFolderFullPath()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string currentCloudFilename = GetCurrentCloudFilename();
		return string.ConcatArray((string[])(object)"cloud", (int)currentCloudFilename);
	}

	public static string GetCloudFileFullPath(string kilooTag = "")
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got VT
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I4
		//IL_000d: Expected Obj, but got VT
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_002c: Expected Obj, but got I
		//IL_0038: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		object obj = text + 8;
		_0021_00210 val = (_0021_00210)KilooSerializerHTTPExtensions.ParseJson<T>((IResponse)kilooTag.m_stringLength);
		obj = val;
		object obj2 = text + 12;
		_0021_00210 val2 = (_0021_00210)KilooSerializerHTTPExtensions.ParseJson<T>((IResponse)kilooTag.m_firstChar);
		obj2 = val2;
		object obj3 = text + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [kilooTag @ L0 (System.String)+10]");
		_0021_00210 val3 = (_0021_00210)KilooSerializerHTTPExtensions.ParseJson<T>((IResponse)0);
		obj3 = val3;
		return text;
	}

	private static void SetupSaveGame(string fakeTag = "")
	{
		((TooltipAttribute)(object)"CloudSaveLastUsedKilooTag")._002Ector(fakeTag);
		RenderPipelineManager.CleanupRenderPipeline();
	}

	public static string GetKilooTag()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return SAVE_PATH;
	}

	private static void MigrateCloudSave(string oldPath, string newPath)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		object obj = oldPath.m_firstChar + 8;
		obj = newPath;
		object obj2 = oldPath.m_firstChar + 20;
		obj2 = 0;
		((SaveData<CloudData>)oldPath.m_firstChar).Save();
	}

	private static void OnAuthenticated()
	{
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_03a0: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0298: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v72 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DeleteFolderDebug();
		_hasInited = true;
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v68 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string savePath = PlayerInfoMigrator.GetSavePath();
		if (savePath != null)
		{
			nint num5 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v59 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v64 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PlayerInfoMigrator._002Ecctor();
		}
		nint num7 = (nint)typeof(PlayerPrefsMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v23 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v54 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (BoardManager.CountBoardThemesUnlocked() != 0)
		{
			nint num9 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v45 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v50 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PlayerPrefsMigrator.TryCleanPlayerPrefsKeys();
		}
		nint num11 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v31 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v38 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)SaveManager.m_saveGameChanged);
	}

	private static void CreateSaveFolderIfNeeded(string basePath)
	{
		//IL_03c7: Expected I, but got Obj
		//IL_03dd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0408: Expected I, but got Obj
		//IL_041e: Expected Obj, but got I
		//IL_0087: Expected I, but got Obj
		//IL_0239: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I
		//IL_04f2: Expected I4, but got Obj
		//IL_02c7: Expected I, but got Obj
		//IL_02dd: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I4
		//IL_027a: Expected I, but got Obj
		//IL_02fd: Expected I, but got Obj
		//IL_0313: Expected Obj, but got I
		//IL_050d: Expected I4, but got Obj
		//IL_033e: Expected I, but got Obj
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_0496: Expected I, but got Obj
		//IL_04ac: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I4
		//IL_0592: Expected I4, but got Obj
		//IL_018d: Expected I, but got Obj
		//IL_01da: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v90 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, Friend.Status> friendStatus = SocialSave.friendStatus;
		bool flag = basePath == null || basePath.m_stringLength == 0;
		nint num3 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v4 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v40 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = !flag;
		bool flag3 = !flag2;
		string text = (string)(object)friendStatus;
		if (!flag3)
		{
			text = basePath;
		}
		string currentCloudFilename = GetCurrentCloudFilename();
		bool flag4 = currentCloudFilename == null || currentCloudFilename.m_stringLength == 0;
		if (flag4 && text != null && text.m_stringLength != 0)
		{
			nint num5 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v63 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v71 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num7 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v25 (Il2CppClass<System.IO.Path>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v36 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool deleteLocal = Path.SameRoot(SAVE_PATH, "cloud");
			string path = string.ConcatArray((string[])(object)"cloud", (int)text);
			bool deleteCloud = Path.SameRoot(SAVE_PATH, path);
			DeleteFilesDebug(deleteLocal, deleteCloud);
		}
		else
		{
			nint num9 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v37 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v54 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool active = PlayerInfoMigrator.MigrateInventorySave((Dictionary<Key, string>)(object)text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Boards.BoardId boardId = default;
			BoardManager.SetThemeActive(boardId, (HoverboardThemes.ThemeIdentifier)LOCAL_FILE_PATH, active);
			nint num11 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v50 (Il2CppClass<Data.Save.SaveManager>)+5C]");
			object obj6 = (nint)0 + (nint)12;
			obj6 = boardId;
			DeleteFolderDebug();
		}
		nint num12 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v22 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num13 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v31 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string currentCloudFilename2 = GetCurrentCloudFilename();
		char c = currentCloudFilename2.get_Chars((int)text);
		SetupSaveGame(text);
		TransformExtensions.Reset((Transform)(object)SaveManager.m_saveGameChanged);
		if (c != '\0')
		{
			((BaseTransformValueResetter)3)._002Ector(SpaceType.World);
		}
	}

	public static void Inject<T>(DataManager<T> manager) where T : DataManager<T>, new()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v4+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5+14]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S2_v4 (should have been resolved before IL gen)");
	}

	public static void Save()
	{
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_016d: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_00be: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, Friend.Status> friendStatus = SocialSave.friendStatus;
		string currentCloudFilename = GetCurrentCloudFilename();
		if (((string)(object)friendStatus).get_Chars((int)currentCloudFilename) == '\0')
		{
			return;
		}
		nint num3 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CreateSaveFolderIfNeeded("");
	}

	public static void Load()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_activeSaveGame.Load();
	}

	public static void DebugSaveGameChange(string fakeTag)
	{
		if (!Directory.IsRootDirectory(fakeTag))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal(fakeTag);
		}
	}

	public static void DeleteFolderDebug()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		saveGameChanged += (Action)(object)_activeSaveGame;
	}

	public static void DeleteFilesDebug(bool deleteLocal = true, bool deleteCloud = true)
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_01cb: Expected I4, but got Obj
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v55 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_activeSaveGame == null)
		{
			nint num3 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v34 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v49 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Boards.BoardId boardId = default;
			BoardManager.SetThemeActive(boardId, (HoverboardThemes.ThemeIdentifier)LOCAL_FILE_PATH, deleteLocal);
			nint num5 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v45 (Il2CppClass<Data.Save.SaveManager>)+5C]");
			object obj3 = (nint)0 + (nint)12;
			obj3 = boardId;
			DeleteFolderDebug();
		}
		nint num6 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v16 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_activeSaveGame.Load();
		MigrateCloudSave((string)(object)_activeSaveGame, (string)deleteCloud);
	}
}
