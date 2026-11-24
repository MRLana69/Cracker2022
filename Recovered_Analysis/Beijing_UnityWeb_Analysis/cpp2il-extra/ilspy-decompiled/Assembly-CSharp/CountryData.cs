using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using UI.Generic.Layout;
using UI.Screens.PauseScreenInternal;
using UnityEngine;

public static class CountryData
{
	private static List<Country> _listOfCountries;

	public static Country GetMotherCountryForCountryID(string countryID)
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [countryID @ L0 (System.String)+10]");
		return (Country)0;
	}

	public static List<Country> GetListOfCountries()
	{
		//IL_0070: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		dailyChallengeRewardHelper.Refresh();
		((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)11;
		dailyChallengeRewardHelper._rewardLayout = (Layout)10;
		object obj = dailyChallengeRewardHelper - -64;
		int pendingTopRunResultsWeek = TopRunSave.pendingTopRunResultsWeek;
		object obj2 = pendingTopRunResultsWeek + 1;
		obj = obj2;
		int pendingTopRunResultsRank = TopRunSave.pendingTopRunResultsRank;
		int lastWeekMedalWasShown = TopRunSave.lastWeekMedalWasShown;
		return (List<Country>)(object)dailyChallengeRewardHelper;
	}

	public static Country GetCountryForID(string id)
	{
		//IL_1c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4c: Expected Obj, but got Unknown
		//IL_1c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c63: Expected Obj, but got Unknown
		//IL_1c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7a: Expected Obj, but got Unknown
		//IL_1a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9e: Expected Obj, but got Unknown
		//IL_1ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab5: Expected Obj, but got Unknown
		//IL_1ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acc: Expected Obj, but got Unknown
		//IL_19d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19db: Expected Obj, but got Unknown
		//IL_19ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f2: Expected Obj, but got Unknown
		//IL_1a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a09: Expected Obj, but got Unknown
		//IL_1828: Unknown result type (might be due to invalid IL or missing references)
		//IL_182d: Expected Obj, but got Unknown
		//IL_183f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1844: Expected Obj, but got Unknown
		//IL_1856: Unknown result type (might be due to invalid IL or missing references)
		//IL_185b: Expected Obj, but got Unknown
		//IL_1b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b89: Expected Obj, but got Unknown
		//IL_1b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba0: Expected Obj, but got Unknown
		//IL_1bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb7: Expected Obj, but got Unknown
		//IL_1913: Unknown result type (might be due to invalid IL or missing references)
		//IL_1918: Expected Obj, but got Unknown
		//IL_192a: Unknown result type (might be due to invalid IL or missing references)
		//IL_192f: Expected Obj, but got Unknown
		//IL_1941: Unknown result type (might be due to invalid IL or missing references)
		//IL_1946: Expected Obj, but got Unknown
		//IL_1765: Unknown result type (might be due to invalid IL or missing references)
		//IL_176a: Expected Obj, but got Unknown
		//IL_177c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1781: Expected Obj, but got Unknown
		//IL_1793: Unknown result type (might be due to invalid IL or missing references)
		//IL_1798: Expected Obj, but got Unknown
		//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a7: Expected Obj, but got Unknown
		//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16be: Expected Obj, but got Unknown
		//IL_16d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d5: Expected Obj, but got Unknown
		//IL_1e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e58: Expected Obj, but got Unknown
		//IL_1e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6f: Expected Obj, but got Unknown
		//IL_1e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e86: Expected Obj, but got Unknown
		//IL_13a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ae: Expected Obj, but got Unknown
		//IL_13c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c5: Expected Obj, but got Unknown
		//IL_13d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13dc: Expected Obj, but got Unknown
		//IL_12e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12eb: Expected Obj, but got Unknown
		//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1302: Expected Obj, but got Unknown
		//IL_1314: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected Obj, but got Unknown
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_113d: Expected Obj, but got Unknown
		//IL_114f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1154: Expected Obj, but got Unknown
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Expected Obj, but got Unknown
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Expected Obj, but got Unknown
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da8: Expected Obj, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Expected Obj, but got Unknown
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Expected Obj, but got Unknown
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected Obj, but got Unknown
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected Obj, but got Unknown
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Expected Obj, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got Unknown
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Expected Obj, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected Obj, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected Obj, but got Unknown
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected Obj, but got Unknown
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected Obj, but got Unknown
		//IL_15df: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e4: Expected Obj, but got Unknown
		//IL_15f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fb: Expected Obj, but got Unknown
		//IL_160d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1612: Expected Obj, but got Unknown
		//IL_1223: Unknown result type (might be due to invalid IL or missing references)
		//IL_1228: Expected Obj, but got Unknown
		//IL_123a: Unknown result type (might be due to invalid IL or missing references)
		//IL_123f: Expected Obj, but got Unknown
		//IL_1251: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Expected Obj, but got Unknown
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Expected Obj, but got Unknown
		//IL_108c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1091: Expected Obj, but got Unknown
		//IL_10a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a8: Expected Obj, but got Unknown
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Expected Obj, but got Unknown
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fce: Expected Obj, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe5: Expected Obj, but got Unknown
		//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Expected Obj, but got Unknown
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected Obj, but got Unknown
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected Obj, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected Obj, but got Unknown
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected Obj, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected Obj, but got Unknown
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected Obj, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected Obj, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected Obj, but got Unknown
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected Obj, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected Obj, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected Obj, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected Obj, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_1d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d57: Expected Obj, but got Unknown
		//IL_1d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6e: Expected Obj, but got Unknown
		//IL_1d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d85: Expected Obj, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected Obj, but got Unknown
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected Obj, but got Unknown
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected Obj, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected Obj, but got Unknown
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C9E1");
		object obj = default;
		if ((nint)obj < 1263423660)
		{
			if ((nint)obj < 1126201567)
			{
				if ((nint)obj < 1044726233)
				{
					if ((nint)obj < 958425377)
					{
						if ((nint)obj < 958425376)
						{
							if ((nint)obj != 910505280)
							{
								return null;
							}
							if (!(id != "tc"))
							{
								return null;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Country country = default;
							object obj2 = country + 8;
							obj2 = "COUNTRY_NAME_GB";
							object obj3 = country + 12;
							obj3 = "United-Kingdom";
							object obj4 = country + 16;
							obj4 = "gb";
							return country;
						}
						if ((nint)obj != 958425376)
						{
							return null;
						}
						if (!(id != "gf"))
						{
							return null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Country country2 = default;
						object obj5 = country2 + 8;
						obj5 = "COUNTRY_NAME_FR";
						object obj6 = country2 + 12;
						obj6 = "France";
						object obj7 = country2 + 16;
						obj7 = "fr";
						return country2;
					}
					if ((nint)obj < 1044726232)
					{
						if ((nint)obj != 1011465184)
						{
							return null;
						}
						if (!(id != "vi"))
						{
							return null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Country country3 = default;
						object obj8 = country3 + 8;
						obj8 = "COUNTRY_NAME_US";
						object obj9 = country3 + 12;
						obj9 = "United-States";
						object obj10 = country3 + 16;
						obj10 = "us";
						return country3;
					}
					if ((nint)obj != 1044726232)
					{
						return null;
					}
					if (!(id != "tk"))
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country4 = default;
					object obj11 = country4 + 8;
					obj11 = "COUNTRY_NAME_NZ";
					object obj12 = country4 + 12;
					obj12 = "New-Zealand";
					object obj13 = country4 + 16;
					obj13 = "nz";
					return country4;
				}
				if ((nint)obj < 1076604185)
				{
					if ((nint)obj < 1076604184)
					{
						if ((nint)obj != 1062342494)
						{
							return null;
						}
						if (!(id != "sh"))
						{
							return null;
						}
					}
					else
					{
						if ((nint)obj != 1076604184)
						{
							return null;
						}
						if (!(id != "bm"))
						{
							return null;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country5 = default;
					object obj14 = country5 + 8;
					obj14 = "COUNTRY_NAME_GB";
					object obj15 = country5 + 12;
					obj15 = "United-Kingdom";
					object obj16 = country5 + 16;
					obj16 = "gb";
					return country5;
				}
				if ((nint)obj < 1126201566)
				{
					if ((nint)obj != 1092940518)
					{
						return null;
					}
					if (!(id != "an"))
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country6 = default;
					object obj17 = country6 + 8;
					obj17 = "COUNTRY_NAME_NL";
					object obj18 = country6 + 12;
					obj18 = "Netherlands";
					object obj19 = country6 + 16;
					obj19 = "nl";
					return country6;
				}
				if ((nint)obj != 1126201566)
				{
					return null;
				}
				if (!(id != "gl"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country7 = default;
				object obj20 = country7 + 8;
				obj20 = "COUNTRY_NAME_DK";
				object obj21 = country7 + 12;
				obj21 = "Denmark";
				object obj22 = country7 + 16;
				obj22 = "dk";
				return country7;
			}
			if ((nint)obj < 1146230590)
			{
				if ((nint)obj < 1145686137)
				{
					if ((nint)obj < 1145686136)
					{
						if ((nint)obj != 1143273375)
						{
							return null;
						}
						if (!(id != "ai"))
						{
							return null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Country country8 = default;
						object obj23 = country8 + 8;
						obj23 = "COUNTRY_NAME_GB";
						object obj24 = country8 + 12;
						obj24 = "United-Kingdom";
						object obj25 = country8 + 16;
						obj25 = "gb";
						return country8;
					}
					if ((nint)obj != 1145686136)
					{
						return null;
					}
					if (!(id != "va"))
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country9 = default;
					object obj26 = country9 + 8;
					obj26 = "COUNTRY_NAME_IT";
					object obj27 = country9 + 12;
					obj27 = "Italy";
					object obj28 = country9 + 16;
					obj28 = "it";
					return country9;
				}
				if ((nint)obj < 1146230589)
				{
					if ((nint)obj != 1145980326)
					{
						return null;
					}
					if (!(id != "pm"))
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country10 = default;
					object obj29 = country10 + 8;
					obj29 = "COUNTRY_NAME_FR";
					object obj30 = country10 + 12;
					obj30 = "France";
					object obj31 = country10 + 16;
					obj31 = "fr";
					return country10;
				}
				if ((nint)obj != 1146230589)
				{
					return null;
				}
				if (!(id != "sm"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country11 = default;
				object obj32 = country11 + 8;
				obj32 = "COUNTRY_NAME_IT";
				object obj33 = country11 + 12;
				obj33 = "Italy";
				object obj34 = country11 + 16;
				obj34 = "it";
				return country11;
			}
			if ((nint)obj < 1210089662)
			{
				if ((nint)obj < 1210089661)
				{
					if ((nint)obj != 1197446016)
					{
						return null;
					}
					if (!(id != "yt"))
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country12 = default;
					object obj35 = country12 + 8;
					obj35 = "COUNTRY_NAME_FR";
					object obj36 = country12 + 12;
					obj36 = "France";
					object obj37 = country12 + 16;
					obj37 = "fr";
					return country12;
				}
				if ((nint)obj != 1210089661)
				{
					return null;
				}
				if (!(id != "gi"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country13 = default;
				object obj38 = country13 + 8;
				obj38 = "COUNTRY_NAME_GB";
				object obj39 = country13 + 12;
				obj39 = "United-Kingdom";
				object obj40 = country13 + 16;
				obj40 = "gb";
				return country13;
			}
			if ((nint)obj < 1246351850)
			{
				if ((nint)obj != 1211516684)
				{
					return null;
				}
				if (!(id != "nu"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country14 = default;
				object obj41 = country14 + 8;
				obj41 = "COUNTRY_NAME_NZ";
				object obj42 = country14 + 12;
				obj42 = "New-Zealand";
				object obj43 = country14 + 16;
				obj43 = "nz";
				return country14;
			}
			if ((nint)obj < 1263423659)
			{
				if ((nint)obj != 1246351850)
				{
					return null;
				}
				if (!(id != "vg"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country15 = default;
				object obj44 = country15 + 8;
				obj44 = "COUNTRY_NAME_GB";
				object obj45 = country15 + 12;
				obj45 = "United-Kingdom";
				object obj46 = country15 + 16;
				obj46 = "gb";
				return country15;
			}
			if ((nint)obj != 1263423659)
			{
				return null;
			}
			if (!(id != "pf"))
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Country country16 = default;
			object obj47 = country16 + 8;
			obj47 = "COUNTRY_NAME_FR";
			object obj48 = country16 + 12;
			obj48 = "France";
			object obj49 = country16 + 16;
			obj49 = "fr";
			return country16;
		}
		if ((nint)obj < 1481930065)
		{
			if ((nint)obj < 1346178922)
			{
				if ((nint)obj < 1327532995)
				{
					if ((nint)obj < 1327532994)
					{
						if ((nint)obj != 1277200137)
						{
							return null;
						}
						if (!(id != "gu"))
						{
							return null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Country country17 = default;
						object obj50 = country17 + 8;
						obj50 = "COUNTRY_NAME_US";
						object obj51 = country17 + 12;
						obj51 = "United-States";
						object obj52 = country17 + 16;
						obj52 = "us";
						return country17;
					}
					if ((nint)obj != 1327532994)
					{
						return null;
					}
					if (!(id != "gp"))
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country18 = default;
					object obj53 = country18 + 8;
					obj53 = "COUNTRY_NAME_FR";
					object obj54 = country18 + 12;
					obj54 = "France";
					object obj55 = country18 + 16;
					obj55 = "fr";
					return country18;
				}
				if ((nint)obj < 1346178921)
				{
					if ((nint)obj != 1330784398)
					{
						return null;
					}
					if (!(id != "sx"))
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country19 = default;
					object obj56 = country19 + 8;
					obj56 = "COUNTRY_NAME_NL";
					object obj57 = country19 + 12;
					obj57 = "Netherlands";
					object obj58 = country19 + 16;
					obj58 = "nl";
					return country19;
				}
				if ((nint)obj != 1346178921)
				{
					return null;
				}
				if (!(id != "ky"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country20 = default;
				object obj59 = country20 + 8;
				obj59 = "COUNTRY_NAME_GB";
				object obj60 = country20 + 12;
				obj60 = "United-Kingdom";
				object obj61 = country20 + 16;
				obj61 = "gb";
				return country20;
			}
			if ((nint)obj < 1412303660)
			{
				if ((nint)obj < 1412303659)
				{
					if ((nint)obj != 1395526040)
					{
						return null;
					}
					if (!(id != "mp"))
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country21 = default;
					object obj62 = country21 + 8;
					obj62 = "COUNTRY_NAME_US";
					object obj63 = country21 + 12;
					obj63 = "United-States";
					object obj64 = country21 + 16;
					obj64 = "us";
					return country21;
				}
				if ((nint)obj != 1412303659)
				{
					return null;
				}
				if (!(id != "mq"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country22 = default;
				object obj65 = country22 + 8;
				obj65 = "COUNTRY_NAME_FR";
				object obj66 = country22 + 12;
				obj66 = "France";
				object obj67 = country22 + 16;
				obj67 = "fr";
				return country22;
			}
			if ((nint)obj < 1446403350)
			{
				if ((nint)obj != 1445858897)
				{
					return null;
				}
				if (!(id != "ms"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country23 = default;
				object obj68 = country23 + 8;
				obj68 = "COUNTRY_NAME_GB";
				object obj69 = country23 + 12;
				obj69 = "United-Kingdom";
				object obj70 = country23 + 16;
				obj70 = "gb";
				return country23;
			}
			if ((nint)obj < 1481930064)
			{
				if ((nint)obj != 1446403350)
				{
					return null;
				}
				if (!(id != "nc"))
				{
					return null;
				}
			}
			else
			{
				if ((nint)obj != 1481930064)
				{
					return null;
				}
				if (!(id != "re"))
				{
					return null;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Country country24 = default;
			object obj71 = country24 + 8;
			obj71 = "COUNTRY_NAME_FR";
			object obj72 = country24 + 12;
			obj72 = "France";
			object obj73 = country24 + 16;
			obj73 = "fr";
			return country24;
		}
		if ((nint)obj < 1579491470)
		{
			if ((nint)obj < 1512380994)
			{
				if ((nint)obj < 1512380993)
				{
					if ((nint)obj != 1497869040)
					{
						return null;
					}
					if (!(id != "wf"))
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Country country25 = default;
					object obj74 = country25 + 8;
					obj74 = "COUNTRY_NAME_FR";
					object obj75 = country25 + 12;
					obj75 = "France";
					object obj76 = country25 + 16;
					obj76 = "fr";
					return country25;
				}
				if ((nint)obj != 1512380993)
				{
					return null;
				}
				if (!(id != "aw"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country26 = default;
				object obj77 = country26 + 8;
				obj77 = "COUNTRY_NAME_NL";
				object obj78 = country26 + 12;
				obj78 = "Netherlands";
				object obj79 = country26 + 16;
				obj79 = "nl";
				return country26;
			}
			if ((nint)obj < 1579491469)
			{
				if ((nint)obj != 1579344374)
				{
					return null;
				}
				if (!(id != "fk"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country27 = default;
				object obj80 = country27 + 8;
				obj80 = "COUNTRY_NAME_GB";
				object obj81 = country27 + 12;
				obj81 = "United-Kingdom";
				object obj82 = country27 + 16;
				obj82 = "gb";
				return country27;
			}
			if ((nint)obj != 1579491469)
			{
				return null;
			}
			if (!(id != "as"))
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Country country28 = default;
			object obj83 = country28 + 8;
			obj83 = "COUNTRY_NAME_US";
			object obj84 = country28 + 12;
			obj84 = "United-States";
			object obj85 = country28 + 16;
			obj85 = "us";
			return country28;
		}
		if ((nint)obj < 1598976040)
		{
			if ((nint)obj < 1598976039)
			{
				if ((nint)obj != 1579785659)
				{
					return null;
				}
				if (!(id != "ck"))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country29 = default;
				object obj86 = country29 + 8;
				obj86 = "COUNTRY_NAME_NZ";
				object obj87 = country29 + 12;
				obj87 = "New-Zealand";
				object obj88 = country29 + 16;
				obj88 = "nz";
				return country29;
			}
			if ((nint)obj != 1598976039)
			{
				return null;
			}
			if (!(id != "pr"))
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Country country30 = default;
			object obj89 = country30 + 8;
			obj89 = "COUNTRY_NAME_US";
			object obj90 = country30 + 12;
			obj90 = "United-States";
			object obj91 = country30 + 16;
			obj91 = "us";
			return country30;
		}
		if ((nint)obj < 1647190325)
		{
			if ((nint)obj != 1646454850)
			{
				return null;
			}
			if (!(id != "fo"))
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Country country31 = default;
			object obj92 = country31 + 8;
			obj92 = "COUNTRY_NAME_DK";
			object obj93 = country31 + 12;
			obj93 = "Denmark";
			object obj94 = country31 + 16;
			obj94 = "dk";
			return country31;
		}
		if ((nint)obj < 1714300801)
		{
			if ((nint)obj != 1647190325)
			{
				return null;
			}
			if (!(id != "mo"))
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Country country32 = default;
			object obj95 = country32 + 8;
			obj95 = "COUNTRY_NAME_CN";
			object obj96 = country32 + 12;
			obj96 = "China";
			object obj97 = country32 + 16;
			obj97 = "cn";
			return country32;
		}
		if ((nint)obj != 1714300801)
		{
			return null;
		}
		if (!(id != "mc"))
		{
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Country country33 = default;
		object obj98 = country33 + 8;
		obj98 = "COUNTRY_NAME_FR";
		object obj99 = country33 + 12;
		obj99 = "France";
		object obj100 = country33 + 16;
		obj100 = "fr";
		return country33;
	}
}
