using System;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Utility;

namespace Kiloo;

public static class CDateTime
{
	public static DateTime Now
	{
		get
		{
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected Obj, but got Unknown
			//IL_00a8: Expected Obj, but got I4
			//IL_00b6: Expected I, but got Obj
			//IL_00cc: Expected Obj, but got I
			//IL_00fa: Expected Obj, but got VT
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected Obj, but got Unknown
			//IL_011e: Expected Obj, but got I4
			//IL_012a: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected Obj, but got Unknown
			//IL_0082: Expected Obj, but got I4
			//IL_0091: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 + 8;
			obj = 0;
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v30 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime lastDailyOnlineLog = UserSave.lastDailyOnlineLog;
			obj2 = lastDailyOnlineLog;
			ObfuscatedMemory obfuscatedMemory = (ObfuscatedMemory)(obj2 + 24);
			obfuscatedMemory = (ObfuscatedMemory)obj2;
			DateTime dateTime = obfuscatedMemory.GetDateTime((string)6);
			obj = dateTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBF");
			object obj4 = obj2 + 16;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC87");
			return (DateTime)obj4;
		}
	}

	public static DateTime UtcNow
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.DateTime>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return DateTime.UtcNow;
		}
	}

	public static DateTime Today
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Expected VT, but got I8
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.DateTime>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (DateTime)DateTime.GetSystemTimeAsFileTime();
		}
	}
}
