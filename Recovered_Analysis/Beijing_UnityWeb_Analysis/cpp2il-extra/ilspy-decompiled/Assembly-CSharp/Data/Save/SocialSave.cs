using System.Collections.Generic;
using Authentication;
using Cpp2ILInjected;
using Data.Save.Internal;

namespace Data.Save;

public class SocialSave : DataManager<SocialSave>
{
	public static Dictionary<string, Friend.Status> friendStatus
	{
		get
		{
			//IL_0118: Expected I, but got Obj
			//IL_012e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01a9: Expected Obj, but got I4
			//IL_008a: Expected I, but got Obj
			//IL_00a0: Expected Obj, but got I
			//IL_017d: Expected I4, but got Obj
			//IL_00cb: Expected I, but got Obj
			nint num = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInitialized = Auth.isInitialized;
			bool flag;
			if (isInitialized)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			bool flag2 = !flag;
			bool flag3 = isInitialized;
			if (!flag2)
			{
				nint num3 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Il2CppClass<Data.Save.SaveManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(SaveManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<Data.Save.SaveManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string currentCloudFilename = SaveManager.GetCurrentCloudFilename();
				flag3 = (byte)(int)currentCloudFilename != 0;
			}
			return (Dictionary<string, Friend.Status>)flag3;
		}
		set
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveManager.CreateSaveFolderIfNeeded((string)(object)value);
			SaveManager.Save();
		}
	}

	public SocialSave()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = localDebugData + 520;
		obj = this;
	}
}
