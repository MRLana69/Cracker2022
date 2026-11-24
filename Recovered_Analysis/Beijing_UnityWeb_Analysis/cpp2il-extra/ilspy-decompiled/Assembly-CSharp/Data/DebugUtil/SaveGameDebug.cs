using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Data.Migration;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin;
using Kiloo.Serialization;
using SYBO.Subway.Info;
using UnityEngine;

namespace Data.DebugUtil;

public static class SaveGameDebug
{
	private static readonly string[] _saveFiles;

	private static string _lastLoadedSave;

	private static string debugSaveDirectory
	{
		get
		{
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0198: Expected I, but got Obj
			//IL_01ae: Expected Obj, but got I
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Expected Obj, but got Unknown
			//IL_01e1: Expected Obj, but got VT
			//IL_01e9: Expected Obj, but got VT
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected Obj, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected Obj, but got Unknown
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Expected Obj, but got Unknown
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0272: Expected Obj, but got I4
			//IL_027e: Expected Obj, but got I4
			//IL_00ee: Expected I, but got Obj
			DateTime lastKnownServerTime = UserSave.lastKnownServerTime;
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v51 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime lastDailyOnlineLog = UserSave.lastDailyOnlineLog;
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<System.DateTime>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v47 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = default;
			object obj3 = obj4 + 8;
			obj3 = lastKnownServerTime;
			obj4 = lastDailyOnlineLog;
			object obj5 = obj4 + 16;
			obj5 = obj3;
			object obj6 = obj4 + 24;
			obj6 = obj4;
			object obj7 = obj5 & 0x3FFFFFFFFFFFFFFFL;
			object obj8 = obj6 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
			{
				nint num5 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v36 (Il2CppClass<SocialManager>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num6 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v43 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
				bool flag = ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
				return (string)flag;
			}
			return null;
		}
	}

	private static string gameSaveDirectory => PathHandling.AbsoluteToRelativePath("..\\..\\tools\\OldPlayerInfoVersions");

	private static string saveInfoPath => PathHandling.AbsoluteToRelativePath("..\\EditorCache");

	public static string lastLoadedSave
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_010e: Expected I, but got Obj
			//IL_0124: Expected Obj, but got I
			//IL_00f2: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveGameDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string root = gameSaveDirectory;
			nint num3 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<System.IO.Path>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v10 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (string)Path.SameRoot(root, "active.txt");
		}
		private set
		{
			//IL_012c: Expected I, but got Obj
			//IL_0142: Expected Obj, but got I
			//IL_0253: Expected Obj, but got I
			//IL_0263: Expected Obj, but got I
			//IL_0273: Expected Obj, but got I
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Expected Obj, but got Unknown
			//IL_028a: Unknown result type (might be due to invalid IL or missing references)
			//IL_028f: Expected Obj, but got Unknown
			//IL_02b6: Expected I, but got Obj
			//IL_02cc: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01e9: Expected Obj, but got I
			//IL_01f9: Expected Obj, but got I
			//IL_0209: Expected Obj, but got I
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected Obj, but got Unknown
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Expected Obj, but got Unknown
			//IL_00df: Expected I, but got Obj
			//IL_017e: Expected Obj, but got I
			//IL_018e: Expected Obj, but got I
			//IL_019e: Expected Obj, but got I
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected Obj, but got Unknown
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected Obj, but got Unknown
			//IL_0079: Expected I, but got Obj
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Boards.BoardId, bool> hasBoardBeenSeen = UserSave.hasBoardBeenSeen;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v4+44]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S3_v4 (should have been resolved before IL gen)");
			object obj7 = default;
			bool flag = (nint)obj7 > -1;
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			bool flag2 = obj8 != null;
			if (flag)
			{
				if (flag2)
				{
					nint num5 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v29 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<Boards.BoardId, bool> hasBoardBeenSeen2 = UserSave.hasBoardBeenSeen;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v10 (Il2CppMethodInfo)+C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S4_v11+60]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v12+48]");
				object obj11 = 0;
				object obj12 = obj11 & 0x7FF;
				object obj13 = obj12 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S5_v9 (should have been resolved before IL gen)");
				return;
			}
			if (flag2)
			{
				nint num7 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v20 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Boards.BoardId, bool> hasBoardBeenSeen3 = UserSave.hasBoardBeenSeen;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v6+60]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v7+48]");
			object obj16 = 0;
			object obj17 = obj16 & 0x7FF;
			object obj18 = obj17 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v106 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	private static string tmpPlayerInfoPath
	{
		get
		{
			//IL_00a4: Expected I, but got Obj
			//IL_00ba: Expected Obj, but got I
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected Obj, but got Unknown
			//IL_0107: Expected Obj, but got I
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveGameDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v19 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = default;
			object obj2 = obj3 + 8;
			string text = gameSaveDirectory;
			obj2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			DirectoryInfo source = Directory.CreateDirectory((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			Func<string, string> func = default;
			object obj4 = func + 16;
			obj4 = obj3;
			return (string)(object)Enumerable.Select((IEnumerable<string>)(object)source, func);
		}
	}

	private static string tmpCloudPath
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ae: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string temp_path = Path.get_temp_path();
			return (string)Path.SameRoot(temp_path, "tmp_playerinfo.json");
		}
	}

	private static string tmpLocalPath
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ae: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string temp_path = Path.get_temp_path();
			return (string)Path.SameRoot(temp_path, "tmp_cloud.json");
		}
	}

	public static IEnumerable<string> GetPossibleSaves()
	{
		//IL_0258: Expected I, but got Obj
		//IL_026e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03ad: Expected I, but got Obj
		//IL_03c3: Expected Obj, but got I
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_020b: Expected I, but got Obj
		//IL_02c8: Expected I, but got Obj
		//IL_02de: Expected Obj, but got I
		//IL_0186: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_036a: Expected Obj, but got I
		//IL_01a2: Expected I, but got Obj
		//IL_01d2: Expected I, but got Obj
		//IL_0331: Expected I, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I4
		//IL_012e: Expected I, but got Obj
		//IL_01f8: Expected I, but got Obj
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v69 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = _lastLoadedSave;
		if (_lastLoadedSave == null || text.m_stringLength == 0)
		{
			nint num3 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v30 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SaveGameDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v61 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string path = lastLoadedSave;
			FileAttributes attributes = File.GetAttributes(path);
			nint num5 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v8 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 != null;
			if (attributes != 0)
			{
				if (flag)
				{
					nint num6 = (nint)typeof(SaveGameDebug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v57 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = lastLoadedSave;
				bool canRead = ((FileStream)(object)text2).CanRead;
				nint num7 = (nint)typeof(SaveGameDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v54 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+5C]");
				object obj4 = (nint)0 + (nint)4;
				obj4 = canRead;
			}
			else
			{
				bool flag2 = !flag;
				nint num8 = (nint)typeof(SaveGameDebug);
				if (!flag2)
				{
					nint num9 = (nint)typeof(SaveGameDebug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v42 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
					bool flag3 = (nint)0 == 0;
					bool flag4 = !flag3;
					num8 = (nint)typeof(SaveGameDebug);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num8 = (nint)typeof(SaveGameDebug);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ L0_v10 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				obj5 = "N/A";
			}
		}
		nint num10 = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v16 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num11 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v23 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IEnumerable<string>)(object)_lastLoadedSave;
	}

	private static void CopySaveFiles(string from, string to)
	{
		//IL_017d: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_0204: Expected I4, but got Obj
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_00d6: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		List<Characters.CharacterId> unlockedCharacters = InventorySave.unlockedCharacters;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 <= -1)
		{
			List<Characters.CharacterId> unlockedCharacters2 = InventorySave.unlockedCharacters;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<int> list = default;
			list._002Ector();
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S4_v8 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v9+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v10+48]");
			object obj9 = 0;
			object obj10 = obj9 & 0x7FF;
			object obj11 = obj10 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S5_v5 (should have been resolved before IL gen)");
		}
		List<Characters.CharacterId> unlockedCharacters3 = InventorySave.unlockedCharacters;
		List<int> list2 = ((Dictionary<Characters.CharacterId, List<int>>)(object)unlockedCharacters3).get_Item((Characters.CharacterId)from);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @104BC");
		nint num3 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v26 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (CharacterManager.outfitUnlocked != null)
		{
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S2_v12 (Il2CppMethodInfo)+18]");
			object obj13 = 0;
			object obj14 = obj13;
			object obj15 = obj14 & 0x3FFF;
			object obj16 = obj15 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v114 @ S3_v10 (should have been resolved before IL gen)");
		}
	}

	private static void MakeSureDirectoryExists(string folderPath, string filePath)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0420: Expected I, but got Obj
		//IL_0436: Expected Obj, but got I
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_02f4: Expected I, but got Obj
		//IL_030a: Expected Obj, but got I
		//IL_0335: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v151 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = _saveFiles + 12;
		object obj5 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		object obj17 = default;
		object obj20 = default;
		object obj22 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				return;
			}
			object obj6 = _saveFiles + 16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj9 = obj10;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj19;
			if (obj11 == obj13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object message = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj15 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				}
				else
				{
					object obj16 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
						object obj18 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						obj19 = obj20;
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					nint num3 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v76 (Il2CppClass<UnityEngine.Debug>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num4 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v81 (Il2CppClass<UnityEngine.Debug>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Debug.LogError(message);
				}
				obj5 = obj22 + 1;
				continue;
			}
			obj19 = obj9;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private static void DeleteExistingSaveFiles(string folder)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00f1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(SaveGameDebug);
		if (!flag)
		{
			nint num3 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(SaveGameDebug);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(SaveGameDebug);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = folder;
		string text = lastLoadedSave;
		((FileStream)(object)text).WriteByte((byte)(int)folder);
	}

	public static void SwitchSaveGame(string newSave)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_037b: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_0247: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_0288: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v131 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = _saveFiles + 12;
		object obj5 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		object obj17 = default;
		object obj19 = default;
		object obj22 = default;
		object obj25 = default;
		object obj26 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				return;
			}
			object obj6 = _saveFiles + 16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj9 = obj10;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj21;
			object obj24;
			if (obj11 == obj13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object message = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj15 == null)
				{
					object obj16 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj17 == null)
					{
						object obj18 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj19 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
							nint num3 = (nint)typeof(Debug);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v87 (Il2CppClass<UnityEngine.Debug>)+BA]");
							object obj20 = (nint)0 & (nint)0x200;
							if (obj20 != null)
							{
								nint num4 = (nint)typeof(Debug);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v92 (Il2CppClass<UnityEngine.Debug>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Debug.LogError(message);
							obj21 = obj22;
							goto IL_02c7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
						object obj23 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						obj24 = obj25;
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				obj21 = obj22;
				goto IL_02c7;
			}
			obj24 = obj9;
			break;
			IL_02c7:
			obj5 = obj26 + 1;
			obj22 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	public static void StoreSaveGame(string saveFolder)
	{
		//IL_0103: Expected I, but got Obj
		//IL_0119: Expected Obj, but got I
		//IL_0175: Expected I, but got Obj
		//IL_018b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ef: Expected Obj, but got I4
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string root = gameSaveDirectory;
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<System.IO.Path>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v15 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot(root, saveFolder);
		string text = saveInfoPath;
		SwitchSaveGame(text);
		MakeSureDirectoryExists((string)flag, text);
		DeleteExistingSaveFiles(saveFolder);
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			((BaseTransformValueResetter)3)._002Ector(SpaceType.World);
		}
	}

	public static void OpenDebugSaveDirectory()
	{
		//IL_0011: Expected Obj, but got VT
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		DateTime now = CDateTime.Now;
		object obj = now;
		Action<Stat, int> action = (Action<Stat, int>)(obj + 8);
		action = (Action<Stat, int>)obj;
		PlayerSave.statChanged += action;
	}

	public static void OpenGameSaveDirectory()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = gameSaveDirectory;
		((StaticUpdater)(object)text).Update();
	}

	private static void Log(string msg)
	{
		//IL_00c0: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_013f: Expected I, but got Obj
		//IL_0155: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string folderPath = saveInfoPath;
		string root = gameSaveDirectory;
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v2 (Il2CppClass<System.IO.Path>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v10 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot(root, msg);
		SwitchSaveGame((string)flag);
		MakeSureDirectoryExists(folderPath, (string)flag);
		string text = $"Stored save [{(object[])(object)msg}]";
	}

	public static void ExportPlayerInfoToExternal()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = saveInfoPath;
		((StaticUpdater)(object)text).Update();
	}

	public static void ImportPlayerInfoFromExternal()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0291: Expected I, but got Obj
		//IL_02a7: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v87 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		int androidApiLevel = DeviceUtility.GetAndroidApiLevel();
		nint num3 = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v80 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
	}

	public static void ExportToFiles()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0291: Expected I, but got Obj
		//IL_02a7: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v87 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		int androidApiLevel = DeviceUtility.GetAndroidApiLevel();
		nint num3 = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v80 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
	}

	public static void ImportFromFiles()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_032c: Expected I, but got Obj
		//IL_0342: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_01b5: Expected I, but got Obj
		//IL_01cb: Expected Obj, but got I
		//IL_0243: Expected I, but got Obj
		//IL_0259: Expected Obj, but got I
		//IL_01f6: Expected I, but got Obj
		//IL_0284: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string msg = default;
		FlurryVideoAds.LogError(msg, (UnityEngine.Object)null);
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v117 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		byte b = default;
		byte value = b;
		nint num3 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v35 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v62 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.DeleteFolderDebug();
		int overridePerformanceLevel = DebugSave.overridePerformanceLevel;
		int overridePerformanceLevel2 = DebugSave.overridePerformanceLevel;
		nint num5 = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v47 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v58 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = tmpCloudPath;
		((FileStream)(object)text).WriteByte(value);
		string text2 = tmpLocalPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v41 (System.Int32)+C]");
		((FileStream)(object)text2).WriteByte((byte)0);
		bool flag = FilesExist();
		bool flag2 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v44 (System.Int32)+8]");
		((FileStream)flag2).WriteByte(0);
	}

	public static bool FilesExist()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string temp_path = Path.get_temp_path();
		return Path.SameRoot(temp_path, "tmp_local.json");
	}

	public static void OpenFiles()
	{
		//IL_0227: Expected I, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I4
		//IL_0091: Invalid comparison between VT and I4
		//IL_014b: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_028f: Expected Obj, but got VT
		//IL_01c6: Expected I, but got Obj
		//IL_00f4: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v50 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = tmpCloudPath;
		bool canRead = ((FileStream)(object)text2).CanRead;
		_0021_00210 val = (_0021_00210)((KilooSerializer)(object)text).FromBson<T>((byte[])canRead);
		string text3 = tmpLocalPath;
		bool canRead2 = ((FileStream)(object)text3).CanRead;
		bool flag = FilesExist();
		bool canRead3 = ((FileStream)flag).CanRead;
		if (val != (_0021_00210)(object)0)
		{
			nint num3 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v41 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v46 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PlayerInfoMigrator.MigrateStatistics((string)val);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		int num5 = default;
		object obj3 = num5 + 12;
		obj3 = canRead2;
		object obj4 = num5 + 8;
		obj4 = canRead3;
		DebugSave.overridePerformanceLevel = num5;
		nint num6 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v31 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v36 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
	}

	static SaveGameDebug()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03b0: Expected I, but got Obj
		//IL_03c6: Expected Obj, but got I
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_04c4: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_03f1: Expected I, but got Obj
		//IL_0407: Expected Obj, but got I
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_053f: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_014c: Expected I, but got Obj
		//IL_0432: Expected I, but got Obj
		//IL_0448: Expected Obj, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_056e: Expected Obj, but got I4
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_05ba: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I
		//IL_0277: Expected I, but got Obj
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_030e: Expected Obj, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v121 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string startInfo = tmpCloudPath;
		Process process = Process.Start((ProcessStartInfo)(object)startInfo);
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 23;
		if (process != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj2 + obj8;
			if ((nint)obj9 == 23)
			{
				object obj10 = obj2 + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}
		nint num3 = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v36 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v106 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string startInfo2 = tmpLocalPath;
		Process process2 = Process.Start((ProcessStartInfo)(object)startInfo2);
		object obj13 = obj2 + 4;
		object obj14 = obj13 + 1;
		obj13 = obj14;
		object obj15 = obj14 << 2;
		object obj16 = obj2 + obj15;
		obj16 = 46;
		if (process2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj2 + obj17;
			if ((nint)obj18 == 46)
			{
				object obj19 = obj2 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
			}
		}
		nint num5 = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v58 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num6 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v91 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = FilesExist();
		Process process3 = Process.Start((ProcessStartInfo)flag);
		object obj22 = obj2 + 4;
		object obj23 = obj22 + 1;
		obj22 = obj23;
		object obj24 = obj23 << 2;
		object obj25 = obj2 + obj24;
		obj25 = 69;
		if (process3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 == -1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		object obj26 = (nint)0 << 2;
		object obj27 = obj2 + obj26;
		if ((nint)obj27 == 69)
		{
			object obj28 = obj2 + 4;
			if ((nint)obj28 > -1)
			{
				object obj29 = obj28 + -1;
				obj28 = obj29;
			}
		}
	}
}
