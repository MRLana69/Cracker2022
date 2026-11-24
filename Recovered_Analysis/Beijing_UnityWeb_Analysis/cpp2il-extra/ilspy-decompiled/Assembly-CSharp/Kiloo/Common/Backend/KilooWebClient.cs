using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.HTTP;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Security;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Backend;

public static class KilooWebClient
{
	private static float defaultRequestTimeout__BackingField;

	private static float defaultKeepAlive__BackingField;

	private static float defaultMinBackOffTime__BackingField;

	private const string TAGS_PLAYERPREFS_KEY = "kiloowebclient_tags";

	private static Dictionary<string, string> _clientInfoHeaders;

	private static IDictionary<string, object> _tags;

	public static float defaultRequestTimeout
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return WebClient.timeout__BackingField;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WebClient.timeout__BackingField = value;
		}
	}

	public static float defaultKeepAlive
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return defaultRequestTimeout__BackingField;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			defaultRequestTimeout__BackingField = value;
		}
	}

	public static float defaultMinBackOffTime
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return defaultKeepAlive__BackingField;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			defaultKeepAlive__BackingField = value;
		}
	}

	public static float defaultMaxBackOffTime
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return defaultMinBackOffTime__BackingField;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			defaultMinBackOffTime__BackingField = value;
		}
	}

	public unsafe static void InitAutomatically(string appId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Expected Obj, but got Unknown
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Expected VT, but got Unknown
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected Obj, but got Unknown
		//IL_0deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Expected Obj, but got Unknown
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected Obj, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected Obj, but got Unknown
		//IL_0e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Expected Obj, but got Unknown
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected Obj, but got Unknown
		//IL_0e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e36: Expected Obj, but got Unknown
		//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e44: Expected Obj, but got Unknown
		//IL_0e4d: Expected Obj, but got I4
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e61: Expected Ref, but got Unknown
		//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Expected Obj, but got Unknown
		//IL_0e81: Expected Obj, but got I4
		//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e95: Expected Obj, but got Unknown
		//IL_0e9e: Expected Obj, but got I4
		//IL_0eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Expected Obj, but got Unknown
		//IL_0ec1: Expected Obj, but got I4
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Expected Obj, but got Unknown
		//IL_0eea: Expected Obj, but got I4
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f04: Expected I, but got Unknown
		//IL_0f0c: Expected I, but got Obj
		//IL_0051: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_0f56: Expected Obj, but got I
		//IL_0092: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_012b: Expected I, but got Obj
		//IL_0f81: Expected Obj, but got VT
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Expected Obj, but got Unknown
		//IL_0147: Expected I, but got Obj
		//IL_0177: Expected I, but got Obj
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_0856: Expected Obj, but got I4
		//IL_0fd6: Expected I, but got Obj
		//IL_0fec: Expected Obj, but got I
		//IL_021a: Expected I, but got Obj
		//IL_10de: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e3: Expected Obj, but got Unknown
		//IL_0267: Expected I, but got Obj
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected Obj, but got Unknown
		//IL_0b83: Expected Obj, but got I
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Expected Obj, but got Unknown
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected Obj, but got Unknown
		//IL_0bbd: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I
		//IL_0360: Expected I, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_1041: Expected I4, but got Obj
		//IL_103c: Expected native int or pointer, but got VT
		//IL_1051: Expected native int or pointer, but got VT
		//IL_1080: Expected Ref, but got VT
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected Obj, but got Unknown
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Obj, but got Unknown
		//IL_09d3: Expected I, but got Obj
		//IL_09e9: Expected Obj, but got I
		//IL_0442: Expected I, but got Obj
		//IL_0458: Expected Obj, but got I
		//IL_03a1: Expected I, but got Obj
		//IL_0c94: Expected Obj, but got I
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca1: Expected Obj, but got Unknown
		//IL_1201: Expected I4, but got Obj
		//IL_11fc: Expected native int or pointer, but got VT
		//IL_1211: Expected native int or pointer, but got VT
		//IL_1240: Expected Ref, but got VT
		//IL_10f0: Expected Obj, but got I8
		//IL_10fd: Expected Obj, but got VT
		//IL_110a: Expected I4, but got Obj
		//IL_1105: Expected native int or pointer, but got VT
		//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Expected Obj, but got Unknown
		//IL_0a14: Expected I, but got Obj
		//IL_04f8: Expected I, but got Obj
		//IL_050e: Expected Obj, but got I
		//IL_0483: Expected I, but got Obj
		//IL_0ccf: Expected Obj, but got I
		//IL_1154: Expected Obj, but got I
		//IL_1161: Expected I4, but got Obj
		//IL_115c: Expected native int or pointer, but got VT
		//IL_0539: Expected I, but got Obj
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected Obj, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 304;
		string text = (string)(obj2 - -64);
		Guid guid = (Guid)(obj2 + 40);
		object obj3 = obj2 + 152;
		object obj4 = obj2 + 136;
		object obj5 = obj2 + 32;
		object obj6 = obj2 + 24;
		object obj7 = obj2 + 8;
		object obj8 = obj2 + 112;
		object obj9 = obj2 + 96;
		object obj10 = obj2 + 280;
		obj10 = 0;
		_ = 0;
		ref DateTime reference = ref *(DateTime*)(obj2 + 16);
		reference = ref *(DateTime*)null;
		object obj11 = obj2 + 264;
		obj11 = 0;
		_ = 0;
		object obj12 = obj2 + 240;
		obj12 = 0;
		_ = 0;
		_ = 0;
		object obj13 = obj2 + 208;
		obj13 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj14 = obj2 + 184;
		obj14 = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)(obj2 + 176);
		num = (nint)obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [appId @ L0 (System.String)+34]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [appId @ L0 (System.String)+48]");
		if ((nint)0 != 0)
		{
			return;
		}
		nint num2 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v61 (Il2CppClass<System.DateTime>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v524 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [appId @ L0 (System.String)+34]");
		string[] directories = Directory.GetDirectories((string)0, "*");
		Array.Sort(directories);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		nint num4 = (nint)typeof(Guid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v74 (Il2CppClass<System.Guid>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		bool flag = obj16 == null;
		nint num5 = (nint)typeof(Guid);
		if (!flag)
		{
			nint num6 = (nint)typeof(Guid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v518 (Il2CppClass<System.Guid>)+74]");
			bool flag2 = (nint)0 == 0;
			flag = !flag2;
			num5 = (nint)typeof(Guid);
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num5 = (nint)typeof(Guid);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ L1_v5 (Il2CppClass<System.Guid>)+5C]");
		nint num7 = 0;
		text = (string)Guid.Empty;
		string text2 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v47 (Il2CppStaticFields<System.Guid>)+8]");
		text2.m_stringLength = 0;
		obj10 = text;
		_ = text.m_stringLength;
		object obj17 = directories + 12;
		object obj18 = default;
		nint num12 = default;
		object obj27 = default;
		object obj29 = default;
		object obj31 = default;
		object obj33 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
		{
			object obj19 = directories + 16;
			object obj20 = obj18 << 2;
			object path = obj19 + obj20;
			nint num8 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v266 (Il2CppClass<System.IO.Path>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num9 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v514 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string fullPath = Path.GetFullPath((string)path);
			nint num10 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v273 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num11 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v510 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (TimeUtility.TryParseRFC1123(fullPath, out reference))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj23 = num12 + 8;
				text = (string)obj23;
				string text3 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S1_v234+8]");
				text3.m_stringLength = 0;
				obj11 = text;
				_ = text.m_stringLength;
				obj3 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
				_ = 0;
				obj4 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v32+8]");
				_ = 0;
				nint num13 = (nint)typeof(Guid);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ S0_v393 (Il2CppClass<System.Guid>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num14 = (nint)typeof(Guid);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ S0_v499 (Il2CppClass<System.Guid>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				((Guid*)(nint)guid)->_a = (int)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Guid*)(nint)guid)->_d = 0;
				text = (string)obj4;
				string text4 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				text4.m_stringLength = 0;
				string text5 = ((Guid*)guid)->ToString(text);
				if (text5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				else
				{
					nint num15 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ S0_v406 (Il2CppClass<System.DateTime>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num16 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ S0_v481 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					obj5 = systemTimeAsFileTime;
					obj6 = reference;
					((Guid*)(nint)guid)->_a = (int)obj5;
					text = (string)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
					object obj26 = obj27 << 32;
					object obj28 = obj29 | obj26;
					nint num17 = (nint)typeof(TimeSpan);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ S0_v423 (Il2CppClass<System.TimeSpan>)+BA]");
					object obj30 = (nint)0 & (nint)0x200;
					if (obj30 != null)
					{
						nint num18 = (nint)typeof(TimeSpan);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ S0_v468 (Il2CppClass<System.TimeSpan>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					obj7 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [appId @ L0 (System.String)+10]");
					obj2 = 0;
					((Guid*)(nint)guid)->_a = (int)obj7;
					text = (string)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FD");
					if (obj31 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						obj10 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v32+8]");
						_ = 0;
						flag = true;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						text = (string)obj11;
						string text6 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v32+8]");
						text6.m_stringLength = 0;
						object obj32 = obj12 + 4;
						obj32 = text;
						_ = text.m_stringLength;
						text = (string)obj12;
						string text7 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v35+8]");
						text7.m_stringLength = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v35+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						flag = true;
					}
				}
			}
			obj18 = obj33 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v72 (System.Collections.Generic.List`1<Kiloo.Common.Backend.EventRemoteLogger+SessionFileInfo>)+C]");
		if ((nint)0 <= (nint)25)
		{
			return;
		}
		object obj34 = 0;
		object obj37 = default;
		object obj38 = default;
		Predicate<EventRemoteLogger.SessionFileInfo> predicate = default;
		List<EventRemoteLogger.SessionFileInfo> list = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v72 (System.Collections.Generic.List`1<Kiloo.Common.Backend.EventRemoteLogger+SessionFileInfo>)+C]");
			if ((nint)0 < (nint)26)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F5");
			object obj35 = guid + 4;
			obj3 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S1_v66+8]");
			_ = 0;
			text = (string)obj3;
			string text8 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			text8.m_stringLength = 0;
			object obj36 = obj37 + 8;
			obj36 = text;
			_ = text.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB94");
			obj13 = text;
			_ = text.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.String)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.String)+18]");
			_ = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj38 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj14 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
				_ = 0;
				object obj39 = obj37 + 8;
				obj4 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S1_v133+8]");
				_ = 0;
				obj8 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v44+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v44+10]");
				_ = 0;
				object obj40 = obj8 + 4;
				obj9 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ S1_v144+8]");
				_ = 0;
				nint num19 = (nint)typeof(Guid);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ S0_v197 (Il2CppClass<System.Guid>)+BA]");
				object obj41 = (nint)0 & (nint)0x200;
				if (obj41 != null)
				{
					nint num20 = (nint)typeof(Guid);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ S0_v254 (Il2CppClass<System.Guid>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				((Guid*)(nint)guid)->_a = (int)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Guid*)(nint)guid)->_d = 0;
				text = (string)obj9;
				string text9 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
				text9.m_stringLength = 0;
				string text10 = ((Guid*)guid)->ToString(text);
				if (text10 != null)
				{
					text = (string)obj14;
					string text11 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v44+8]");
					text11.m_stringLength = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v44+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
			}
			object obj42 = num + 4;
			object obj43 = obj42 + 1;
			obj42 = obj43;
			object obj44 = obj43 << 2;
			object obj45 = num + obj44;
			obj45 = 380;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v51 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v51 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+4]");
				object obj46 = (nint)0 << 2;
				object obj47 = num + obj46;
				if ((nint)obj47 == 380)
				{
					object obj48 = num + 4;
					if ((nint)obj48 > -1)
					{
						object obj49 = obj48 + -1;
						obj48 = obj49;
					}
					goto IL_0d20;
				}
			}
			if (obj34 != null)
			{
				break;
			}
			goto IL_0d20;
			IL_0d20:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num21 = 0;
			_ = 0;
			object obj50 = predicate + 16;
			obj50 = obj37;
			int num22 = list.RemoveAll(predicate);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public static void InitWithClientInfo(string appId, string appVersion, string platformId, string deviceModel, string osId, string osVersion, string deviceLanguage, string deviceCountry, float deviceTimeZone)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static IRequest CreatePost(Uri uri)
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [uri @ L0 (System.Uri)+44]");
		return (IRequest)0;
	}

	public static IRequest CreateGet(Uri uri)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IRequest)((CloudServer2)(object)"POST").ListItems((string)(object)uri);
	}

	public static IRequest CreatePut(Uri uri)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IRequest)((CloudServer2)(object)"GET").ListItems((string)(object)uri);
	}

	public static IRequest CreateDelete(Uri uri)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IRequest)((CloudServer2)(object)"PUT").ListItems((string)(object)uri);
	}

	public static IRequest WithKilooAntiCheat(IRequest request)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IRequest)((CloudServer2)(object)"DELETE").ListItems((string)(object)request);
	}

	public static IRequest WithKilooDeviceId(IRequest request)
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num = (nint)typeof(TOTP);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<Kiloo.Common.Security.TOTP>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TOTP);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v13 (Il2CppClass<Kiloo.Common.Security.TOTP>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string values = TOTP.Eius();
		Headers headers2 = default;
		Headers headers = headers2.SetAll("KAC-TOTP", (IEnumerable<string>)(object)values);
		return request;
	}

	public static IRequest WithKilooTags(IRequest request)
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v13 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleVersion = DeviceUtility.GetBundleVersion();
		Headers headers2 = default;
		Headers headers = headers2.SetAll("Kiloo-Device-Id", (IEnumerable<string>)(object)bundleVersion);
		return request;
	}

	public static bool HasTag(string tag)
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00c1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string osIdentifier = GetOsIdentifier();
		Headers headers2 = default;
		Headers headers = headers2.SetAll("Kiloo-Tags", (IEnumerable<string>)(object)osIdentifier);
		return (byte)(int)tag != 0;
	}

	public static string GetTags()
	{
		//IL_0313: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I
		//IL_0486: Expected I, but got Obj
		//IL_049c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02c6: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0141: Expected I, but got Obj
		//IL_0157: Expected Obj, but got I
		//IL_03a5: Expected I, but got Obj
		//IL_03bb: Expected Obj, but got I
		//IL_03d8: Expected I, but got Obj
		//IL_011f: Expected I4, but got Obj
		//IL_03fc: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I4
		//IL_0182: Expected I, but got Obj
		//IL_01cf: Expected I, but got Obj
		//IL_01ff: Expected I, but got Obj
		//IL_0238: Expected I, but got Obj
		//IL_024e: Expected Obj, but got I
		//IL_0225: Expected I, but got Obj
		//IL_0279: Expected I, but got Obj
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v96 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (WebClient._cachePath == null)
		{
			nint num3 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v30 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v92 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string deviceIdentifier = DeviceUtility.GetDeviceIdentifier();
			if (deviceIdentifier == null || deviceIdentifier.m_stringLength == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Exception ex = default;
				ex.SetErrorCode((int)"Unable to get cache path");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			nint num5 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v39 (Il2CppClass<System.IO.Path>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v80 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot(deviceIdentifier, "webclientcache");
			nint num7 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v46 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag2 = obj4 == null;
			nint num8 = (nint)typeof(WebClient);
			if (!flag2)
			{
				nint num9 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v74 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				bool flag3 = (nint)0 == 0;
				bool flag4 = !flag3;
				num8 = (nint)typeof(WebClient);
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num8 = (nint)typeof(WebClient);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ L0_v12 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			obj5 = flag;
			if (!Directory.IsRootDirectory(WebClient._cachePath))
			{
				nint num10 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v60 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v68 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal(WebClient._cachePath);
			}
		}
		nint num12 = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v16 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num13 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v23 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return WebClient._cachePath;
	}

	public static void AddTags(string[] tags)
	{
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0222: Expected Obj, but got I4
		//IL_0230: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I
		//IL_03bf: Expected I, but got Obj
		//IL_03d5: Expected Obj, but got I
		//IL_027a: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got VT
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02ff: Expected I, but got Obj
		//IL_0315: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0366: Expected I, but got Obj
		//IL_037c: Expected Obj, but got I
		//IL_016e: Expected I, but got Obj
		object obj = default;
		PurchaseValidationServer purchaseValidationServer = (PurchaseValidationServer)(obj + 28);
		purchaseValidationServer = (PurchaseValidationServer)0;
		Uri uri = (Uri)(obj + 24);
		uri = (Uri)0;
		object obj2 = obj + 8;
		obj2 = 0;
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v57 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		purchaseValidationServer.baseUri = uri;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v53 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime utcNow = DateTime.UtcNow;
		nint num5 = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v28 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v49 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = utcNow;
		object obj6 = obj + 16;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D775");
		object obj7 = default;
		obj2 = obj7;
		double num7 = (double)obj2 * 2.7777777777777777E-11;
		nint num8 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v21 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v47 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		bool flag = bundleIdentifier == null || bundleIdentifier.m_stringLength == 0;
		nint num10 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v31 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num11 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v39 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IDictionary<string, object> dictionary = LoadTags();
		string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
		string osVersion = GetOsVersion();
		bool flag2 = IsKindleDevice();
		if (flag)
		{
			bundleIdentifier = "0.0";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A51B");
	}

	public static void RemoveTags(string[] tags)
	{
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_0129: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_016a: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		System.Text.RegularExpressions.ExclusiveReference exclusiveReference = default;
		exclusiveReference.Release((object)"^\\w+$");
		object obj = tags + 12;
		object obj2 = default;
		object obj6 = default;
		ArgumentNullException ex = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = tags + 16;
			object obj4 = obj2 << 2;
			object input = obj3 + obj4;
			Match match = ((Regex)(object)exclusiveReference).Match((string)input);
			if (match != null)
			{
				nint num = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num2 = (nint)typeof(KilooWebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v39 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
				obj2 = obj6 + 1;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ex._002Ector("Invalid character in tag");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			break;
		}
		nint num3 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v15 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v20 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudServer2._002Ecctor();
	}

	static KilooWebClient()
	{
		//IL_015f: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I4
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v27 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string cachePath = DeviceUtility.GetCachePath();
			nint num5 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v7 (Il2CppClass<System.IO.Path>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v16 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot(cachePath, ".installationInfo");
			if (File.GetAttributes((string)flag) != 0)
			{
				((FileStream)flag).ExposeHandle();
			}
		}
		else
		{
			SDebug.LogFormat("DEBUG is not enabled - you cannot delete files with current project settings!", null);
		}
	}

	private unsafe static IRequest CreateRequest(string method, Uri uri)
	{
		//IL_006d: Expected VT, but got Obj
		//IL_009b: Expected Obj, but got I
		ref _0021_00210 reference = ref *(_0021_00210*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		if (obj != null)
		{
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		IResponse response = default;
		if (response != null)
		{
			if (ResponseExtensions.TryParseBson<T>(response, out System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (IBsonSerializer)uri))
			{
				_0021_00210 val = (_0021_00210)System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
				if (System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference) != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20 (T)+C]");
					return (IRequest)0;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	private unsafe static void GetLanguageAndCountry(out string language, out string country)
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got Ref
		//IL_00b8: Expected Obj, but got Ref
		//IL_00c0: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(Exception);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<System.Exception>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v15 (Il2CppClass<System.Exception>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int errorCode = default;
		((Exception)System.Runtime.CompilerServices.Unsafe.AsPointer(ref language)).SetErrorCode(errorCode);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref language, 68));
		obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref country);
	}

	private static string GetOsIdentifier()
	{
		//IL_012a: Expected I, but got Obj
		//IL_0140: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj2 = default;
		if ((nint)obj2 < 1)
		{
			return "";
		}
		nint num3 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v15 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
		string strB = default;
		int num5 = string.CompareOrdinalIgnoreCaseHelper(",", strB);
		return (string)num5;
	}

	private static string GetOsVersion()
	{
		return "other";
	}

	private static bool IsKindleDevice()
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0071: Expected I4, but got Obj
		OperatingSystemFamily operatingSystemFamily = SystemInfo.GetOperatingSystemFamily();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		System.Text.RegularExpressions.ExclusiveReference exclusiveReference = default;
		exclusiveReference.Release((object)"(?:\\s|^)(\\d+\\.\\d+(?:\\.\\d+)?)(?:\\s|$)");
		System.Text.RegularExpressions.CachedCodeEntry cachedCodeEntry = ((Regex)(object)exclusiveReference).CacheCode((string)operatingSystemFamily);
		if (cachedCodeEntry._capslist != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			GroupCollection groupCollection = default;
			Group obj = groupCollection.GetGroup(1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool result = default;
			return result;
		}
		return (byte)(int)"0.0" != 0;
	}

	private static string GetPlatformIdentifier()
	{
		return null;
	}

	private static IDictionary<string, object> LoadTags()
	{
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			nint num3 = (nint)typeof(KilooWebClient);
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				nint num4 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v22 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag3 = obj2 == null;
				num3 = (nint)typeof(KilooWebClient);
				if (flag3)
				{
					goto IL_012a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ L0_v3 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		goto IL_012a;
		IL_012a:
		return (IDictionary<string, object>)(object)GetOsVersion();
	}

	private static void SaveTags()
	{
		//IL_003f: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v9 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+5C]");
		object obj6 = (nint)0 + (nint)20;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A532");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A533");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A534");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A535");
	}

	private static void LogError(string msg)
	{
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_010b: Expected I, but got Obj
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_007d: Expected I, but got Obj
		object obj = msg + 12;
		object obj2 = default;
		object obj7 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = msg + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v33 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			obj2 = obj7 + 1;
		}
		nint num3 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v11 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v16 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudServer2._002Ecctor();
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[KilooWebClient] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}
}
