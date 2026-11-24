using System;
using Cpp2ILInjected;
using Kiloo;
using SYBO.Components.Analytics.Integration;
using TopRun.Internal;

namespace Data.Save.Internal;

public class LocalDebugData : DiskData
{
	public int overridePerformanceLevel;

	public override void Obfuscate()
	{
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_02fd: Expected Obj, but got VT
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_0397: Expected I, but got Obj
		//IL_03ad: Expected Obj, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got VT
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got VT
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got VT
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02c4: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got VT
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v85 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 40;
		obj2 = DateTime.MinValue;
		object obj4 = obj3 + 48;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S3_v3+60]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68 @ S4_v4 (should have been resolved before IL gen)");
		object obj10 = this + 24;
		object obj11 = default;
		obj10 = obj11;
		nint num4 = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v24 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num5 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v79 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_ = AnalyticsIntegration.GamesSinceFlushPersistedDefault;
		object obj13 = this + 36;
		obj13 = AnalyticsIntegration.PreviousClientVersionPersistedDefault;
		object obj14 = this + 40;
		obj14 = AnalyticsIntegration.OperatingSystemPersistedDefault;
		object obj15 = this + 44;
		obj15 = AnalyticsIntegration.DeviceIDPersistedDefault;
		object obj16 = this + 48;
		obj16 = AnalyticsIntegration.OSLanguagePersistedDefault;
		_ = AnalyticsIntegration.PerformanceLevelPersistedDefault;
		_ = AnalyticsIntegration.GpuScorePersistedDefault;
		object obj17 = this + 60;
		obj17 = AnalyticsIntegration.OnlineSettingsLocalePersistedDefault;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S3_v8+60]");
		object obj19 = 0;
		object obj20 = obj19;
		object obj21 = obj20 & 0x1FFF;
		object obj22 = obj21 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v158 @ S4_v8 (should have been resolved before IL gen)");
		object obj23 = this - -64;
		object obj24 = default;
		obj23 = obj24;
		object obj25 = obj3 + 32;
		obj25 = DateTime.MinValue;
		obj4 = obj25;
		object obj26 = this + 80;
		obj26 = string.Empty;
		object obj27 = obj3 + 24;
		DateTime today = CDateTime.Today;
		obj27 = today;
		obj4 = obj27;
		object obj28 = obj3 + 16;
		obj28 = DateTime.MinValue;
		obj4 = obj28;
		object obj29 = obj3 + 8;
		obj29 = DateTime.MinValue;
		obj4 = obj29;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RanksData ranksData = default;
		ranksData._002Ector();
		object obj30 = this + 140;
		obj30 = ranksData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TournamentData tournamentData = default;
		tournamentData._002Ector();
		object obj31 = this + 144;
		obj31 = tournamentData;
		obj3 = DateTime.MinValue;
		obj4 = obj3;
	}

	public override void Deobfuscate()
	{
	}
}
