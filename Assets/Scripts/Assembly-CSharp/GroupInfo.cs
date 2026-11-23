using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class GroupInfo
{
	private const string INTERSTITIAL_GROUPS_ONLINESETTINGS_KEY = "interstitial_groups";

	private const string INTERSTITIAL_GROUPS_COUNTRY_CODES_ENDING = "country_codes";

	private const string INTERSTITIAL_GROUPS_PRIORITY_ENDING = "priority";

	private const string INTERSTITIAL_GROUPS_WEIGHT_ENDING = "weight";

	private const char SEPARATOR = ';';

	private static List<Group> _currentGroups;

	private static List<Group> _defaultGroups;

	unsafe static GroupInfo()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I
		//IL_01a1: Expected native int or pointer, but got VT
		//IL_01bb: Expected Obj, but got I
		//IL_01b6: Expected native int or pointer, but got VT
		object obj2 = default;
		Group obj = (Group)(obj2 - 32);
		_ = 0;
		_ = 0;
		List<Group> list = default;
		list._002Ector();
		_currentGroups = list;
		List<Group> list2 = default;
		list2._002Ector();
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		List<string> list3 = default;
		list3._002Ector();
		List<ProviderSettings> list4 = default;
		list4._002Ector();
		ProviderSettings providerSettings = default;
		providerSettings._id = "inmobi";
		providerSettings._priority = 1;
		providerSettings._weight = 100;
		list4.Add(providerSettings);
		ProviderSettings providerSettings2 = default;
		providerSettings2._id = "chartboost";
		providerSettings2._priority = 2;
		providerSettings2._weight = 100;
		list4.Add(providerSettings2);
		ProviderSettings providerSettings3 = default;
		providerSettings3._id = "supersonic";
		providerSettings3._priority = 3;
		providerSettings3._weight = 0;
		list4.Add(providerSettings3);
		ProviderSettings providerSettings4 = default;
		providerSettings4._id = "mdotm";
		providerSettings4._priority = 4;
		providerSettings4._weight = 0;
		list4.Add(providerSettings4);
		ProviderSettings providerSettings5 = default;
		providerSettings5._id = "facebook";
		providerSettings5._priority = 5;
		providerSettings5._weight = 100;
		list4.Add(providerSettings5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Group)+18]");
		System.Runtime.CompilerServices.Unsafe.Write(&((Group*)(nint)obj)->providerSettings, (List<ProviderSettings>)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Group)+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((Group*)(nint)obj)->id, (string)0);
		list2.Add(obj);
		_defaultGroups = list2;
	}

	public static List<ProviderSettings> GetProvidersForLocale(string deviceLocale, bool fromOnlineSettings)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e20: Expected Obj, but got Unknown
		//IL_0e29: Expected Obj, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5d: Expected Obj, but got Unknown
		//IL_0699: Expected Obj, but got I4
		//IL_067d: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected Obj, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d96: Expected Obj, but got Unknown
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected Obj, but got Unknown
		//IL_06e6: Expected Obj, but got I
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected Obj, but got Unknown
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Expected Obj, but got Unknown
		//IL_0d01: Expected Obj, but got I4
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got Unknown
		//IL_0959: Expected Obj, but got I
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_1031: Unknown result type (might be due to invalid IL or missing references)
		//IL_1036: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected Obj, but got Unknown
		//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Expected Obj, but got Unknown
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected Obj, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected Obj, but got Unknown
		//IL_0807: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0b50: Expected Obj, but got I4
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected Obj, but got Unknown
		//IL_0f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Expected Obj, but got Unknown
		//IL_0aa3: Expected Obj, but got I
		//IL_04ff: Expected Obj, but got I4
		//IL_059b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		List<ProviderSettings> list = default;
		list._002Ector();
		if (~(Globals.DEBUG_INTERSTITIAL_PROVIDERS ? 1u : 0u) == 0)
		{
			object obj4 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1101");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj5 = obj + 56;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj7 = default;
			object obj8 = default;
			while (true)
			{
				_ = 0;
				object obj6 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					break;
				}
				if (obj7 == null)
				{
					goto IL_00d4;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj8 == null)
						{
							continue;
						}
						goto IL_018a;
					}
					goto IL_05ea;
				}
				goto IL_0c89;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0c98;
		}
		string contryCodeFromLocale = Utils.GetContryCodeFromLocale(deviceLocale);
		if (!fromOnlineSettings)
		{
			List<Group> currentGroups = _currentGroups;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v240 (System.Collections.Generic.List`1<Group>)+C]");
			if ((nint)0 != 0)
			{
				goto IL_0f76;
			}
		}
		((List<T>)(object)_currentGroups).Clear();
		List<Group> currentGroups2 = GetCurrentGroups();
		_currentGroups = currentGroups2;
		goto IL_0f76;
		IL_00d4:
		object obj9 = 9;
		List<ProviderSettings> list2 = null;
		goto IL_0d14;
		IL_0d14:
		object obj10 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @161B");
		bool flag = (nint)obj9 != 8;
		List<ProviderSettings> list3 = list;
		if (!flag)
		{
			goto IL_0d54;
		}
		goto IL_1076;
		IL_0de3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		List<ProviderSettings> result = default;
		return result;
		IL_0f76:
		object obj11;
		if (contryCodeFromLocale != null)
		{
			obj11 = 0;
			if (contryCodeFromLocale._stringLength != 0)
			{
				goto IL_0f93;
			}
		}
		obj11 = 1;
		goto IL_0f93;
		IL_0c98:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		goto IL_0f4d;
		IL_1076:
		return list3;
		IL_0f93:
		if (obj11 != null)
		{
			goto IL_0904;
		}
		object obj16 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1101");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		object obj17 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj18 = obj + 56;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj20 = default;
		object obj21 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		while (true)
		{
			_ = 0;
			object obj19 = obj + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			List<ProviderSettings> list4;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj20 == null)
				{
					list4 = list;
					goto IL_0815;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						bool flag2 = obj21 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						list4 = (List<ProviderSettings>)0;
						if (flag2)
						{
							continue;
						}
						goto IL_0815;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj22 != obj23;
			obj12 = obj24;
			if (!flag3)
			{
				goto IL_0898;
			}
			goto IL_0c21;
			IL_0815:
			object obj25 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @161B");
			list3 = list4;
			break;
		}
		goto IL_100f;
		IL_05ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c98;
		IL_0f4d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj26 = default;
		if (obj26 == obj14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 == 1;
			obj9 = 0;
			list2 = null;
			if (!flag4)
			{
				goto IL_0d14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj27 = default;
			obj12 = obj27;
		}
		_ = 0;
		object obj28 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag5 = (nint)0 == 1;
		list3 = list;
		if (!flag5)
		{
			goto IL_0dd3;
		}
		goto IL_0de3;
		IL_0dd3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_1076;
		IL_05a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c98;
		IL_0904:
		list3 = list;
		goto IL_100f;
		IL_018a:
		_ = 0;
		object obj29 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj30 = obj + 40;
			obj = obj30;
			_ = 0;
			object obj32 = default;
			object obj34 = default;
			object obj35 = default;
			object obj36 = default;
			object obj37 = default;
			object obj38 = default;
			object obj39 = default;
			while (true)
			{
				_ = 0;
				object obj31 = obj + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj32 == null)
					{
						obj9 = 7;
						goto IL_050d;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					object obj33 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj34 == null)
									{
										continue;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ S0_v394+8]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ S0_v394+10]");
										_ = 0;
										_ = 100;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												continue;
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_046d;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_046d;
				IL_046d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag6 = obj35 != obj36;
				obj12 = obj37;
				obj14 = obj35;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag7 = (nint)0 == 1;
				obj9 = 0;
				if (!flag7)
				{
					goto IL_050d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj38;
				obj14 = obj39;
				break;
				IL_050d:
				_ = 0;
				object obj40 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0564;
				}
				goto IL_05a8;
			}
			_ = 0;
			object obj41 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0de3;
			}
			goto IL_0f4d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c98;
		IL_100f:
		if (list3._size == 0)
		{
			object obj42 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1101");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			object obj43 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj44 = obj + 56;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj46 = default;
			object obj48 = default;
			object obj49 = default;
			object obj50 = default;
			object obj51 = default;
			object obj52 = default;
			while (true)
			{
				_ = 0;
				object obj45 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj47;
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj46 == null)
					{
						obj47 = obj46;
						list2 = null;
						goto IL_0b63;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj48 == null)
							{
								continue;
							}
							obj47 = obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
							list2 = (List<ProviderSettings>)0;
							goto IL_0b63;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag8 = obj49 != obj50;
				obj12 = obj51;
				if (flag8)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag9 = (nint)0 == 1;
				obj47 = 0;
				list2 = null;
				if (!flag9)
				{
					goto IL_0b63;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj52;
				break;
				IL_0b63:
				object obj53 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @161B");
				if (obj47 != null)
				{
					goto IL_0d54;
				}
				goto IL_1076;
			}
			_ = 0;
			object obj54 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0dd3;
			}
			goto IL_0de3;
		}
		goto IL_1076;
		IL_0c21:
		_ = 0;
		object obj55 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag10 = (nint)0 != 1;
		list3 = list;
		if (flag10)
		{
			goto IL_0dd3;
		}
		goto IL_0de3;
		IL_0564:
		bool flag11 = (nint)obj9 != 7;
		if (obj9 == null)
		{
			flag11 = false;
		}
		list2 = null;
		if (!flag11)
		{
			obj9 = 8;
			list2 = list;
		}
		goto IL_0d14;
		IL_0c89:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c98;
		IL_0d54:
		list3 = list2;
		goto IL_1076;
		IL_0898:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			object obj56 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @161B");
			goto IL_0904;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj57 = default;
		obj12 = obj57;
		goto IL_0c21;
	}

	private unsafe static List<Group> GetCurrentGroups()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Ref, but got Unknown
		//IL_19cd: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got I4
		//IL_1a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a67: Expected Obj, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04fe: Expected Obj, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_1c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c92: Expected Obj, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Ref, but got Unknown
		//IL_0210: Expected Obj, but got I
		//IL_1aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acf: Expected Obj, but got Unknown
		//IL_1afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b01: Expected Obj, but got Unknown
		//IL_1b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1a: Expected Obj, but got Unknown
		//IL_0480: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I
		//IL_1b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b61: Expected Obj, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_059e: Expected Obj, but got I
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected VT, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected VT, but got Unknown
		//IL_02b5: Expected native int or pointer, but got VT
		//IL_02e7: Expected Obj, but got I
		//IL_0541: Expected Obj, but got I
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected Obj, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_031f: Expected Obj, but got I
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected Obj, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected Obj, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_07c1: Expected Obj, but got I4
		//IL_0850: Expected Obj, but got I
		//IL_1cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb5: Expected Obj, but got Unknown
		//IL_1888: Unknown result type (might be due to invalid IL or missing references)
		//IL_188d: Expected Obj, but got Unknown
		//IL_18a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a5: Expected Obj, but got Unknown
		//IL_193b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1940: Expected Obj, but got Unknown
		//IL_197a: Expected Obj, but got I
		//IL_18e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18eb: Expected VT, but got Unknown
		//IL_1901: Unknown result type (might be due to invalid IL or missing references)
		//IL_1906: Expected Obj, but got Unknown
		//IL_08c5: Expected Obj, but got I
		//IL_17f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fd: Expected Obj, but got Unknown
		//IL_0938: Expected Obj, but got I
		//IL_09ab: Expected Obj, but got I
		//IL_0a24: Expected Obj, but got I
		//IL_0a9c: Expected Obj, but got I
		//IL_0b1c: Expected Obj, but got I
		//IL_0b95: Expected Obj, but got I
		//IL_0c08: Expected Obj, but got I
		//IL_0c7b: Expected Obj, but got I
		//IL_0cf4: Expected Obj, but got I
		//IL_0d6c: Expected Obj, but got I
		//IL_0dec: Expected Obj, but got I
		//IL_0e65: Expected Obj, but got I
		//IL_0ece: Expected Obj, but got I
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Expected Obj, but got Unknown
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4d: Expected Obj, but got Unknown
		//IL_0fa4: Expected Obj, but got I
		//IL_0f1d: Expected Obj, but got I4
		//IL_0f26: Expected Obj, but got I4
		//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc6: Expected Obj, but got Unknown
		//IL_101d: Expected Obj, but got I
		//IL_13e6: Expected Obj, but got I
		//IL_1406: Expected Obj, but got I
		//IL_104e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Expected Obj, but got Unknown
		//IL_1451: Expected Obj, but got I
		//IL_1479: Expected Obj, but got I
		//IL_1ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1baa: Expected Obj, but got Unknown
		//IL_14c4: Expected Obj, but got I
		//IL_14d4: Expected Obj, but got I
		//IL_14f4: Expected Obj, but got I
		//IL_1bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf3: Expected Obj, but got Unknown
		//IL_1c4d: Expected Obj, but got I
		//IL_10ce: Expected Obj, but got I
		//IL_10f4: Expected Obj, but got I4
		//IL_153f: Expected Obj, but got I
		//IL_155f: Expected Obj, but got I
		//IL_156f: Expected Obj, but got I
		//IL_10a1: Expected Obj, but got I4
		//IL_10aa: Expected Obj, but got I4
		//IL_10b3: Expected Obj, but got I4
		//IL_1261: Expected Obj, but got I4
		//IL_126a: Expected Obj, but got I4
		//IL_1273: Expected Obj, but got I4
		//IL_113f: Expected Obj, but got I
		//IL_1148: Expected Obj, but got I4
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e9: Expected Obj, but got Unknown
		//IL_1320: Expected Obj, but got I
		//IL_1340: Expected Obj, but got I
		//IL_15ba: Expected Obj, but got I
		//IL_15da: Expected Obj, but got I
		//IL_15ea: Expected Obj, but got I
		//IL_1175: Expected Obj, but got I
		//IL_117e: Expected Obj, but got I4
		//IL_136d: Expected Obj, but got I
		//IL_1635: Expected Obj, but got I
		//IL_1655: Expected Obj, but got I
		//IL_1665: Expected Obj, but got I
		//IL_12aa: Expected Obj, but got I
		//IL_12b3: Expected Obj, but got I4
		//IL_1195: Expected Obj, but got I4
		//IL_11a5: Expected Obj, but got I
		//IL_11b5: Expected Obj, but got I
		//IL_138b: Expected Obj, but got I
		//IL_16bd: Expected Obj, but got I
		//IL_16dd: Expected Obj, but got I
		//IL_16ed: Expected Obj, but got I
		//IL_173b: Expected Obj, but got I
		//IL_175b: Expected Obj, but got I
		//IL_176b: Expected Obj, but got I
		//IL_177b: Expected Obj, but got I
		//IL_179b: Expected Obj, but got I
		//IL_17ab: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 192;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		List<Group> list = default;
		list._002Ector();
		_ = string.Empty;
		OnlineSettings instance = OnlineSettings.instance;
		bool flag = instance.TryGetValue("interstitial_groups", out *(string*)(obj + 188));
		bool flag2 = !flag;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
			string[] array = ((string)0).Split(';');
			object obj3 = default;
			List<string> list2 = default;
			List<ProviderSettings> list3 = default;
			object obj11 = default;
			string[] array2 = default;
			object obj12 = default;
			object obj14 = default;
			object obj15 = default;
			List<Group> list4 = default;
			object obj17 = default;
			List<Group> list5 = default;
			object obj27 = default;
			object obj29 = default;
			object obj31 = default;
			object obj33 = default;
			object obj34 = default;
			object obj35 = default;
			object obj36 = default;
			object obj44 = default;
			object obj46 = default;
			object obj47 = default;
			object obj48 = default;
			List<Group> list6 = default;
			object obj50 = default;
			List<Group> list7 = default;
			object obj52 = default;
			object obj53 = default;
			object obj54 = default;
			object obj55 = default;
			object obj57 = default;
			List<Group> list8 = default;
			object obj59 = default;
			List<Group> list9 = default;
			object obj62 = default;
			List<string> list10 = default;
			object obj75 = default;
			object obj76 = default;
			object obj77 = default;
			List<Group> list11 = default;
			List<Group> list12 = default;
			while ((nint)obj3 < array.Length)
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)array + obj4;
				list2._002Ector();
				list3._002Ector();
				object obj6 = obj + 168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v43+10]");
				string arg = ((string)0).Trim();
				object obj7 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1101");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				object obj8 = obj + 128;
				object obj9 = obj - -64;
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				while (true)
				{
					_ = 0;
					object obj10 = obj + 128;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						break;
					}
					if (obj11 != null)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						array2 = (string[])0;
						if (flag3)
						{
							break;
						}
						bool flag4 = obj12 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						array2 = (string[])0;
						if (flag4)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
						_ = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
						_ = 0;
						Group? obj13 = (Group?)(object)(obj + 72);
						Group value = (Group)(obj + 24);
						System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)obj13, new Group?(value));
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag5 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						array2 = (string[])0;
						if (flag5)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						array2 = (string[])0;
					}
					goto IL_03ce;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag6 = obj14 != obj15;
				List<Group> result = list4;
				if (!flag6)
				{
					object obj16 = obj - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					obj16 = obj17;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_03ce;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = list5;
				}
				_ = 0;
				object obj18 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag7 = (nint)0 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj19 = 0;
				if (flag7)
				{
					goto IL_1988;
				}
				goto IL_19dc;
				IL_12c8:
				obj19 = obj;
				goto IL_1988;
				IL_192c:
				_ = 0;
				object obj20 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag8 = (nint)0 != 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj19 = 0;
				if (!flag8)
				{
					goto IL_1988;
				}
				goto IL_19dc;
				IL_0748:
				object obj21 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
				object obj22 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				object obj23 = obj + 112;
				object obj24 = obj - -64;
				obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				while (true)
				{
					_ = 0;
					object obj25 = obj + 112;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag9 = (nint)0 == 1;
					object obj26 = obj27;
					object obj28 = obj29;
					object obj30 = obj31;
					object obj32 = obj33;
					string[] array3 = array2;
					bool flag10 = flag2;
					object obj49;
					object obj37;
					object obj38;
					if (!flag9)
					{
						if (obj34 == null)
						{
							break;
						}
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag11 = (nint)0 == 1;
						obj26 = obj27;
						obj28 = obj29;
						obj30 = obj31;
						obj32 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
						array3 = (string[])0;
						flag10 = flag2;
						if (!flag11)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag12 = (nint)0 == 1;
							obj26 = obj27;
							obj28 = obj29;
							obj30 = obj31;
							obj32 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
							array3 = (string[])0;
							flag10 = flag2;
							if (!flag12)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag13 = (nint)0 == 1;
								obj26 = obj27;
								obj28 = obj29;
								obj30 = obj31;
								obj32 = obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
								array3 = (string[])0;
								flag10 = flag2;
								if (!flag13)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag14 = (nint)0 == 1;
									obj26 = obj27;
									obj28 = obj29;
									obj30 = obj31;
									obj32 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
									array3 = (string[])0;
									flag10 = flag2;
									if (!flag14)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag15 = (nint)0 == 1;
										obj26 = obj27;
										obj28 = obj29;
										obj30 = obj31;
										obj32 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
										array3 = (string[])0;
										flag10 = flag2;
										if (!flag15)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag16 = (nint)0 == 1;
											obj26 = obj27;
											obj28 = obj29;
											obj30 = obj31;
											obj32 = obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
											array3 = (string[])0;
											flag10 = flag2;
											if (!flag16)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag17 = (nint)0 == 1;
												obj26 = obj27;
												obj28 = obj29;
												obj30 = obj31;
												obj32 = obj35;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
												array3 = (string[])0;
												flag10 = flag2;
												if (!flag17)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag18 = (nint)0 == 1;
													obj26 = obj27;
													obj28 = obj29;
													obj30 = obj31;
													obj32 = obj35;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
													array3 = (string[])0;
													flag10 = flag2;
													if (!flag18)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag19 = (nint)0 == 1;
														obj26 = obj27;
														obj28 = obj29;
														obj30 = obj31;
														obj32 = obj35;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
														array3 = (string[])0;
														flag10 = flag2;
														if (!flag19)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag20 = (nint)0 == 1;
															obj26 = obj27;
															obj28 = obj29;
															obj30 = obj31;
															obj32 = obj35;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
															array3 = (string[])0;
															flag10 = flag2;
															if (!flag20)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																bool flag21 = (nint)0 == 1;
																obj26 = obj27;
																obj28 = obj29;
																obj30 = obj31;
																obj32 = obj35;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
																array3 = (string[])0;
																flag10 = flag2;
																if (!flag21)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
																	_ = 0;
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	bool flag22 = (nint)0 == 1;
																	obj26 = obj27;
																	obj28 = obj29;
																	obj30 = obj31;
																	obj32 = obj35;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
																	array3 = (string[])0;
																	flag10 = flag2;
																	if (!flag22)
																	{
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		bool flag23 = (nint)0 == 1;
																		obj26 = obj27;
																		obj28 = obj29;
																		obj30 = obj36;
																		obj32 = obj35;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
																		array3 = (string[])0;
																		flag10 = flag2;
																		if (!flag23)
																		{
																			_ = 0;
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			bool flag24 = (nint)0 == 1;
																			obj26 = obj27;
																			obj28 = obj29;
																			obj30 = obj36;
																			obj32 = obj35;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
																			array3 = (string[])0;
																			flag10 = flag2;
																			if (!flag24)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
																				bool flag25 = (nint)0 == 0;
																				flag10 = !flag25;
																				if (!flag10)
																				{
																					obj37 = int.MaxValue;
																					obj38 = 0;
																					goto IL_13a1;
																				}
																				_ = 0;
																				object obj39 = obj + 72;
																				object obj40 = obj + 168;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				bool flag26 = (nint)0 == 1;
																				obj26 = obj27;
																				obj28 = obj29;
																				obj30 = obj36;
																				obj32 = obj35;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
																				array3 = (string[])0;
																				if (!flag26)
																				{
																					_ = 0;
																					object obj41 = obj + 72;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					bool flag27 = (nint)0 == 1;
																					obj26 = obj27;
																					obj28 = obj29;
																					obj30 = obj36;
																					obj32 = obj35;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
																					array3 = (string[])0;
																					if (!flag27)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
																						_ = 0;
																						object obj42 = obj + 96;
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
																						_ = 0;
																						while (true)
																						{
																							_ = 0;
																							object obj43 = obj + 96;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 == 1)
																							{
																								break;
																							}
																							bool flag28 = obj44 == null;
																							flag10 = !flag28;
																							if (!flag10)
																							{
																								goto IL_1098;
																							}
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
																							object obj45 = 0;
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							bool flag29 = (nint)0 == 1;
																							obj29 = 17;
																							if (flag29)
																							{
																								break;
																							}
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							bool flag30 = (nint)0 == 1;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							obj27 = 0;
																							obj29 = 17;
																							if (flag30)
																							{
																								break;
																							}
																							bool flag31 = obj46 == null;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							obj27 = 0;
																							obj29 = 17;
																							if (flag31)
																							{
																								continue;
																							}
																							goto IL_118c;
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
																						bool flag32 = obj47 == obj48;
																						flag10 = !flag32;
																						obj49 = obj47;
																						result = list6;
																						if (!flag10)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							bool flag33 = (nint)0 != 1;
																							obj28 = 0;
																							obj37 = int.MaxValue;
																							obj38 = 0;
																							if (flag33)
																							{
																								goto IL_12d5;
																							}
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							obj27 = 0;
																							obj29 = 0;
																							obj49 = obj50;
																							result = list7;
																						}
																						_ = 0;
																						object obj51 = obj + 72;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						bool flag34 = (nint)0 != 1;
																						obj26 = obj27;
																						obj28 = obj29;
																						obj30 = obj36;
																						obj32 = obj35;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						array3 = (string[])0;
																						if (!flag34)
																						{
																							goto IL_12c8;
																						}
																						goto IL_1c5b;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					goto IL_17c1;
					IL_13a1:
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag35 = (nint)0 == 1;
					obj26 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj28 = 0;
					obj30 = obj36;
					obj32 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
					array3 = (string[])0;
					if (!flag35)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag36 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj26 = 0;
						obj28 = obj52;
						obj30 = obj36;
						obj32 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
						array3 = (string[])0;
						if (!flag36)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag37 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj28 = 0;
							obj30 = obj36;
							obj32 = obj35;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
							array3 = (string[])0;
							if (!flag37)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag38 = (nint)0 == 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								obj26 = 0;
								obj28 = obj53;
								obj30 = obj36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								obj32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
								array3 = (string[])0;
								if (!flag38)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag39 = (nint)0 == 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									obj26 = 0;
									obj28 = obj54;
									obj30 = obj36;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									obj32 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
									array3 = (string[])0;
									if (!flag39)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag40 = (nint)0 == 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										obj26 = 0;
										obj28 = obj54;
										obj30 = obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										obj32 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
										array3 = (string[])0;
										if (!flag40)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag41 = (nint)0 == 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											obj26 = 0;
											obj28 = obj54;
											obj30 = obj36;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											obj32 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
											array3 = (string[])0;
											if (!flag41)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag42 = (nint)0 != 1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												obj26 = 0;
												obj28 = obj54;
												obj30 = obj36;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												obj32 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
												array3 = (string[])0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												obj27 = 0;
												obj29 = obj54;
												obj31 = obj36;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												obj33 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
												array2 = (string[])0;
												flag2 = flag10;
												if (flag42)
												{
													continue;
												}
											}
										}
									}
								}
							}
						}
					}
					goto IL_17c1;
					IL_1c5b:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					if (obj55 == obj49)
					{
						object obj56 = obj - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						obj56 = obj57;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag43 = (nint)0 == 1;
						obj27 = obj26;
						obj29 = obj28;
						obj31 = obj30;
						obj33 = obj32;
						array2 = array3;
						flag2 = flag10;
						if (!flag43)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						result = list8;
					}
					goto IL_192c;
					IL_12d5:
					_ = 0;
					object obj58 = obj + 72;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag44 = (nint)0 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj26 = 0;
					obj30 = obj36;
					obj32 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
					array3 = (string[])0;
					if (!flag44)
					{
						bool flag45 = (nint)obj28 == 17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj27 = 0;
						if (!flag45)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj27 = 0;
							obj19 = obj;
							if (obj28 != null)
							{
								goto IL_1c84;
							}
						}
						goto IL_13a1;
					}
					goto IL_17c1;
					IL_1098:
					obj28 = 17;
					obj37 = int.MaxValue;
					obj38 = 0;
					goto IL_12d5;
					IL_118c:
					obj28 = 17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ S0_v444+10]");
					obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ S0_v444+C]");
					obj38 = 0;
					goto IL_12d5;
					IL_17c1:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj49 = obj59;
					result = list9;
					goto IL_1c5b;
				}
				object obj60 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
				object obj61 = obj + 152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Group item = (Group)(obj + 8);
				list.Add(item);
				obj3 = obj62 + 1;
				continue;
				IL_19dc:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result;
				IL_03ce:
				object obj63 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @161B");
				string key = string.Format("{0}_{1}_{2}", "interstitial_groups", arg, "country_codes");
				list10._002Ector();
				_ = string.Empty;
				OnlineSettings instance2 = OnlineSettings.instance;
				if (instance2.TryGetValue(key, out *(string*)(obj + 164)))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A4]");
					string[] array4 = ((string)0).Split(';');
					object obj64 = 0;
					while (true)
					{
						bool flag46 = (nint)obj64 >= array4.Length;
						array2 = array4;
						if (flag46)
						{
							break;
						}
						object obj65 = obj64 << 2;
						object obj66 = (object)array4 + obj65;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S1_v353+10]");
						list10.Add((string)0);
						object obj67 = obj64 + 1;
						obj64 = obj67;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
					if ((nint)0 != 0)
					{
						object obj68 = obj + 72;
						object obj69 = obj + 168;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20F2");
						nint num = 0;
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S4_v21 (Il2CppRgctx<System.Collections.Generic.List`1<System.String>>)+3C]");
						object obj70 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v652 @ S4_v22+4] (should have been resolved before IL gen)");
					}
				}
				object obj71 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				object obj72 = obj + 112;
				_ = 0;
				object obj73 = obj - -64;
				while (true)
				{
					_ = 0;
					object obj74 = obj + 112;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						break;
					}
					if (obj75 != null)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						continue;
					}
					goto IL_0748;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag47 = obj76 != obj77;
				result = list11;
				if (!flag47)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_0748;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = list12;
				}
				_ = 0;
				object obj78 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj19 = 0;
					goto IL_1988;
				}
				goto IL_19dc;
				IL_1988:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_1c84;
				IL_1c84:
				object obj79 = obj19 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
				break;
			}
		}
		else
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v4 (Il2CppRgctx<System.Collections.Generic.List`1<Group>>)+3C]");
			object obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ S4_v5+4] (should have been resolved before IL gen)");
		}
		return list;
	}

	private static void LogError(string msg, Object context = null)
	{
	}

	private static void LogWarning(string msg, Object context = null)
	{
	}

	private static void Log(string msg, Object context = null)
	{
	}
}
