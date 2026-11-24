using System;
using System.Collections.Generic;
using System.Linq;
using Authentication;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Backend.Cloud;
using SYBO.Subway.Info;

namespace Cloud.Internal;

public class UserData
{
	public const string MULTIPLIER_KEY = "multiplier";

	public const string HIGHSCORE_KEY = "highscore";

	public const string KEYS_KEY = "keys";

	public const string UPGRADES_KEY = "upgrades";

	public const string AWARDS_KEY = "awards";

	public const string CHARACTERS_KEY = "characters";

	public const string BOARD_KEY = "board";

	public const string OUTFITS_KEY = "outfits";

	public const string BOARDTHEMES_KEY = "boardThemes";

	public int multiplier;

	public int highScore;

	public int keys;

	public int upgradeTiers;

	public int characters;

	public int outfits;

	public int boards;

	public int boardThemes;

	public float awardsPercentage;

	public UserData(ICloudUserData data)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UserData userData = default;
		Dictionary<string, string> data2 = default;
		userData.LoadUserData(data2);
		object obj2 = this + 12;
		obj2 = userData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UserData userData2 = default;
		Dictionary<string, string> data3 = default;
		userData2.LoadUserData(data3);
		object obj3 = this + 16;
		obj3 = userData2;
		CloudSaveConflictResolver.Log((string)(object)this);
		((CloudSaveConflictResolver)this).ResolveToMine();
	}

	public bool StrictlyBetterThan(UserData other)
	{
		//IL_0128: Expected Obj, but got I4
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v43 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ALL_CHARS ? 1u : 0u) == 0)
		{
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
		if ((nint)0 != 0)
		{
			List<Characters.CharacterId> unlockedCharacters = InventorySave.unlockedCharacters;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				_ = 0;
				Func<int, bool> func = default;
				object obj3 = func + 16;
				object obj4 = default;
				obj3 = obj4;
				return Enumerable.Any((IEnumerable<int>)obj, func);
			}
			return false;
		}
		return true;
	}

	private void LoadUserData(Dictionary<string, string> data)
	{
		if (data != null)
		{
			ICloudUserData value = CloudUserDataExtensions.ToUserData(data);
			((Auth)this).authenticatedEvent += (Action)(object)value;
		}
	}

	public unsafe string AsString()
	{
		//IL_0164: Expected I, but got Obj
		//IL_017a: Expected Obj, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0287: Expected Obj, but got VT
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected VT, but got Unknown
		//IL_02a2: Expected I8, but got Obj
		//IL_029d: Expected native int or pointer, but got VT
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01b3: Expected I, but got Obj
		//IL_01c9: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I8
		//IL_0209: Expected I8, but got Obj
		//IL_0204: Expected native int or pointer, but got VT
		//IL_021e: Expected Ref, but got VT
		//IL_022a: Expected Obj, but got I8
		//IL_00af: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v50 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		object obj4 = obj3 + 8;
		object obj5 = obj3 + 32;
		obj5 = this;
		object obj6 = obj3 + 24;
		obj6 = DateTime.MinValue;
		DateTime dateTime = (DateTime)(obj3 + 40);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj3 + 48);
		formatProvider = (IFormatProvider)obj6;
		long num3 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
		object obj7 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
		if (num3 == (long)obj7)
		{
			return "-";
		}
		nint num4 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v36 (Il2CppClass<Strings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v44 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("CLOUDSAVE_STATS_SAVED_DAYS_AGO");
		nint num6 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v25 (Il2CppClass<System.DateTime>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v37 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		obj2 = systemTimeAsFileTime;
		obj4 = this;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
		formatProvider = (IFormatProvider)obj4;
		long num8 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj3 = num8;
		formatProvider = (IFormatProvider)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A56A");
		object[] args = default;
		return string.Format(format, args);
	}

	private static string GetEntry(Dictionary<string, string> dict, string key)
	{
		//IL_0043: Expected Obj, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		bool flag = (nint)dict.buckets >= key.m_stringLength;
		bool flag2 = (nint)dict.entries >= (int)key.m_firstChar;
		object obj = flag & flag2;
		int count = dict.count;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L1 (System.String)+10]");
		bool flag3 = (nint)count >= (nint)0;
		object obj2 = obj & flag3;
		int version = dict.version;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L1 (System.String)+14]");
		bool flag4 = (nint)version >= (nint)0;
		object obj3 = obj2 & flag4;
		int freeList = dict.freeList;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L1 (System.String)+18]");
		bool flag5 = (nint)freeList >= (nint)0;
		object obj4 = obj3 & flag5;
		int freeCount = dict.freeCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L1 (System.String)+1C]");
		bool flag6 = (nint)freeCount >= (nint)0;
		object obj5 = obj4 & flag6;
		IEqualityComparer<string> comparer = dict.comparer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L1 (System.String)+20]");
		bool flag7 = (nint)comparer >= 0;
		object obj6 = obj5 & flag7;
		Dictionary<string, string>.KeyCollection keyCollection = dict.keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L1 (System.String)+24]");
		bool flag8 = (nint)keyCollection >= 0;
		return (string)(obj6 & flag8);
	}
}
