using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo;
using TopRun.Internal;

namespace TopRun;

public static class TopRunRoot
{
	public static IManager manager
	{
		get
		{
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Expected Obj, but got Unknown
			//IL_01a4: Expected Obj, but got I4
			//IL_01b2: Expected I, but got Obj
			//IL_01c8: Expected Obj, but got I
			//IL_02a1: Expected I4, but got Obj
			//IL_02b3: Expected I, but got Obj
			//IL_02c9: Expected Obj, but got I
			//IL_01f3: Expected I, but got Obj
			//IL_0209: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected Obj, but got Unknown
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Expected Obj, but got Unknown
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected Obj, but got Unknown
			//IL_0323: Expected Obj, but got I4
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_0103: Expected I, but got Obj
			//IL_0119: Expected Obj, but got I
			//IL_022e: Expected Obj, but got VT
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected Obj, but got Unknown
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Expected Obj, but got Unknown
			//IL_0280: Expected Obj, but got I4
			//IL_0144: Expected I, but got Obj
			object obj = default;
			CultureInfo cultureInfo = (CultureInfo)(obj + 16);
			cultureInfo = (CultureInfo)0;
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v42 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			bool value = ((OnlineSettings)(object)saveDataPath).GetValue("top_run_maintenance_timestamp_end", (byte)(int)string.Empty != 0);
			nint num3 = (nint)typeof(TopRunMaintenance);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v9 (Il2CppClass<TopRun.TopRunMaintenance>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(TopRunMaintenance);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v29 (Il2CppClass<TopRun.TopRunMaintenance>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v7 (Il2CppClass<System.DateTime>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v20 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = obj + 32;
			object obj6 = obj + 24;
			object obj7 = obj + 8;
			object obj8 = ((System.DefaultBinder)value).ChangeType(TopRunMaintenance._datetimeCultureinfo, null, cultureInfo);
			if (obj8 != null)
			{
				DateTime today = CDateTime.Today;
				nint num7 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v26 (Il2CppClass<System.DateTime>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num8 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v38 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj7 = today;
				obj = cultureInfo;
				obj6 = obj7;
				obj5 = obj;
				object obj10 = obj6 & 0x3FFFFFFFFFFFFFFFL;
				object obj11 = obj5 & 0x3FFFFFFFFFFFFFFFL;
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
				return (IManager)flag;
			}
			return null;
		}
		private set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
	}

	public static void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = default;
		CultureInfo.CheckDomainSafetyObject(obj, (object)"da-DK");
		TopRunMaintenance._datetimeCultureinfo = (CultureInfo)obj;
	}

	public static void ClearSavedData()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Manager manager = default;
			manager.InitializeCurrentTournamentPlayers();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E7D");
		}
	}
}
