using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Analytics;
using SYBO.Subway;

public static class InRunLogging
{
	private static int _headstartUsedInRun;

	private static int _scoreboostersUsedInRun;

	private static bool _isFirstShow;

	private static bool _isInitialized;

	public static void Init()
	{
	}

	private static void OnScoreBoostActivated(int tier)
	{
		//IL_00db: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		_ = 60.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj = tier + 56;
		obj = stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<float> list = default;
		list._002Ector();
		object obj2 = tier - -64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder2 = default;
		System.Text.StringBuilderCache.Release(stringBuilder2);
		object obj3 = tier + 68;
		obj3 = stringBuilder2;
		object obj4 = tier + 84;
		obj4 = "FPS_Data";
		_ = 600;
		_ = 60;
		_ = 1;
		_ = 1;
		object obj5 = tier + 108;
		obj5 = "Not Run";
		object obj6 = tier + 112;
		obj6 = "Not Run";
	}

	private static void OnHeadstartActivated(int tier)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InRunLogging>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InRunLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<InRunLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_scoreboostersUsedInRun = tier;
	}

	private unsafe static void OnGameStarted()
	{
		//IL_027c: Expected I, but got Obj
		//IL_0292: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02fb: Expected Obj, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_00e4: Expected I, but got Obj
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0341: Expected Obj, but got I4
		//IL_01ee: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		//IL_01a1: Expected I, but got Obj
		//IL_022f: Expected I, but got Obj
		nint num = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InRunLogging>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InRunLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v80 (Il2CppClass<InRunLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&OnGameStarted);
		object obj2 = action + 16;
		obj2 = 0;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v76 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)(delegate*<void>)(&OnMenuScreenShown);
		object obj4 = action2 + 16;
		obj4 = 0;
		Game.OnMenuScreenShown -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<int> action3 = default;
		object obj5 = action3 + 16;
		obj5 = 0;
		nint num6 = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v44 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v72 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SlideinPowerupHelper.OnHeadstartActivated -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<int> action4 = default;
		object obj7 = action4 + 16;
		obj7 = 0;
		SlideinPowerupHelper.OnScoreBoostActivated -= action4;
		nint num9 = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v60 (Il2CppClass<InRunLogging>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(InRunLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v66 (Il2CppClass<InRunLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_isInitialized = true;
	}

	private static void OnMenuScreenShown()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InRunLogging>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InRunLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<InRunLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_headstartUsedInRun = 0;
		_scoreboostersUsedInRun = 0;
	}

	static InRunLogging()
	{
		//IL_029f: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_017f: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0301: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0355: Expected I, but got Obj
		//IL_036b: Expected Obj, but got I
		//IL_038b: Expected Obj, but got I
		//IL_039b: Expected Obj, but got I
		//IL_03ab: Expected Obj, but got I
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_03df: Expected I, but got Obj
		//IL_03f5: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0420: Expected I, but got Obj
		//IL_0436: Expected Obj, but got I
		//IL_019b: Expected I, but got Obj
		//IL_01cb: Expected I, but got Obj
		//IL_0204: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0251: Expected I, but got Obj
		//IL_01f1: Expected I, but got Obj
		nint num = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InRunLogging>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InRunLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v72 (Il2CppClass<InRunLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_isFirstShow ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(InRunLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v60 (Il2CppClass<InRunLogging>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(InRunLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v66 (Il2CppClass<InRunLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_isFirstShow = false;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v4+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69 @ S4_v5 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v18 (Il2CppClass<InRunLogging>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		bool flag = obj8 == null;
		nint num7 = (nint)typeof(InRunLogging);
		if (!flag)
		{
			nint num8 = (nint)typeof(InRunLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v53 (Il2CppClass<InRunLogging>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num7 = (nint)typeof(InRunLogging);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num7 = (nint)typeof(InRunLogging);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v8+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S4_v9+48]");
		object obj11 = 0;
		object obj12 = obj11 & 0x7FF;
		object obj13 = obj12 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138 @ S5_v7 (should have been resolved before IL gen)");
		nint num10 = (nint)typeof(InRunLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v28 (Il2CppClass<InRunLogging>)+5C]");
		object obj14 = (nint)0 + (nint)4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S4_v12 (Il2CppMethodInfo)+C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S4_v13+60]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S4_v14+48]");
		object obj17 = 0;
		object obj18 = obj17 & 0x7FF;
		object obj19 = obj18 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v85 @ S5_v11 (should have been resolved before IL gen)");
		nint num12 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v35 (Il2CppClass<Flurry>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num13 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v49 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num14 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v40 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num15 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v45 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Tracker.CreateEvent(EventType.RunEnded, null);
	}
}
