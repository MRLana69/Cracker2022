using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Info.VideoRewardCooldowns;
using Kiloo;

namespace Info.Localization;

public class LocalizedOnlineSettings
{
	private readonly string _defaultLocale;

	private readonly string _combinedLocale;

	private readonly OnlineSettingsData _data;

	public string loadScreenTitle
	{
		get
		{
			//IL_00fd: Expected I, but got Obj
			//IL_0113: Expected Obj, but got I
			//IL_01fa: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected Obj, but got Unknown
			//IL_019f: Expected I, but got Obj
			//IL_01b5: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE18");
			nint num = (nint)typeof(Cooldowns._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<Info.VideoRewardCooldowns.Cooldowns+<>c>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Cooldowns._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v16 (Il2CppClass<Info.VideoRewardCooldowns.Cooldowns+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Cooldowns._003C_003Ec._003C_003E9__9_0 == null;
			bool flag2 = !flag;
			Func<Cooldown, string> selector = Cooldowns._003C_003Ec._003C_003E9__9_0;
			if (!flag2)
			{
				nint num3 = (nint)typeof(Cooldowns._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v14 (Il2CppClass<Info.VideoRewardCooldowns.Cooldowns+<>c>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Cooldowns._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v34 (Il2CppClass<Info.VideoRewardCooldowns.Cooldowns+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num5 = 0;
				_ = 0;
				Func<Cooldown, string> func = default;
				object obj3 = func + 16;
				obj3 = Cooldowns._003C_003Ec._003C_003E9;
				nint num6 = (nint)typeof(Cooldowns._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v31 (Il2CppClass<Info.VideoRewardCooldowns.Cooldowns+<>c>)+5C]");
				object obj4 = (nint)0 + (nint)4;
				obj4 = func;
				selector = func;
			}
			IEnumerable<Cooldown> source2 = default;
			IEnumerable<string> source = Enumerable.Select(source2, selector);
			string[] strB = Enumerable.ToArray(source);
			return (string)string.CompareOrdinalIgnoreCaseHelper(", ", (string)(object)strB);
		}
	}

	public UserTip[] userTips
	{
		get
		{
			OnlineSettingsData data = _data;
			return (UserTip[])(object)FetchOrDefault(data.loadScreenTitle);
		}
	}

	public string latestVersionChangelog
	{
		get
		{
			OnlineSettingsData data = _data;
			return CompressionExtensions.ToContentString<T>((IEnumerable<T>)this, (string)(object)data.userTips);
		}
	}

	public LocalizedOnlineSettings(OnlineSettingsData data)
	{
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got F4
		//IL_0041: Expected I4, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			Cooldown cooldown = ((Dictionary<string, Cooldown>)(object)_combinedLocale).get_Item((string)data.mysteryBoxDoubleRewardChance);
			cooldown.totalCharges__BackingField = (data.mysteryBoxDoubleRewardAllowKeys ? 1 : 0);
			cooldown.seconds__BackingField = (int)data.saveMeLocales;
			return;
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S4_v5 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S4_v6+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S4_v7+48]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S5_v5 (should have been resolved before IL gen)");
	}

	private T FetchOrDefault<T>(IDictionary<string, T> localizedFieldValue)
	{
		//IL_0006: Expected VT, but got I4
		return (T)1;
	}
}
