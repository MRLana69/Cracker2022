using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.LocalizationManager;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using UnityEngine;

public static class Strings
{
	public class StringsLanguage
	{
		public Locale locale;

		public string resourcesPath;

		public StringsLanguage()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<StringsLanguage> _003C_003E9__18_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			BoardsScreenNavigation._003C_003Ec obj = default;
			BoardsScreenNavigation._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003COnRefresh_003Eb__18_0(StringsLanguage x)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			return (object)x.resourcesPath == instance.jumperSignature;
		}
	}

	private static Dictionary<string, string> _currentLanguageMap;

	private static Dictionary<string, string> _defaultLanguageMap;

	public static bool gibberish;

	private static Action m_languageChanged;

	private static StringsLanguage _language;

	private static StringsLanguage defaultLanguage__BackingField;

	private const string LOCALE_FILE_ENDING = "_locale";

	private const string RESOURCE_FOLDER_PATH = "Kiloo/LocalizationManager/text";

	public static List<StringsLanguage> languages;

	private static bool _hasInited;

	private static readonly IJsonSerializer _jsonConverter;

	public static StringsLanguage defaultLanguage
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(StringComparer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.StringComparer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(StringComparer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.StringComparer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4FA");
			StringsLanguage result = default;
			return result;
		}
		private set
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Strings.m_languageChanged;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)(object)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Strings>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Strings);
				if (!flag)
				{
					nint num5 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Strings>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Strings);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Strings);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Strings>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static StringsLanguage language
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_08a1: Expected I, but got Obj
			//IL_08b7: Expected Obj, but got I
			//IL_004b: Expected I, but got Obj
			//IL_0061: Expected Obj, but got I
			//IL_012e: Expected Obj, but got I4
			//IL_00d9: Expected I, but got Obj
			//IL_088e: Expected I4, but got Obj
			//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e2: Expected Obj, but got Unknown
			//IL_0901: Expected I, but got Obj
			//IL_0917: Expected Obj, but got I
			//IL_008c: Expected I, but got Obj
			//IL_07eb: Expected I, but got Obj
			//IL_096a: Unknown result type (might be due to invalid IL or missing references)
			//IL_096f: Expected Obj, but got Unknown
			//IL_0165: Expected I, but got Obj
			//IL_01d4: Expected I, but got Obj
			//IL_01ea: Expected Obj, but got I
			//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ab: Expected Obj, but got Unknown
			//IL_0215: Expected I, but got Obj
			//IL_033f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Expected Obj, but got Unknown
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected Obj, but got Unknown
			//IL_037e: Expected Obj, but got I4
			//IL_0387: Expected Obj, but got I4
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected Obj, but got Unknown
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Expected Obj, but got Unknown
			//IL_02f2: Expected Obj, but got I4
			//IL_02fb: Expected Obj, but got I4
			//IL_0ae4: Expected I, but got Obj
			//IL_0afa: Expected Obj, but got I
			//IL_0436: Expected Obj, but got I
			//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a30: Expected Obj, but got Unknown
			//IL_04ee: Expected I, but got Obj
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0471: Expected Obj, but got Unknown
			//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a7: Expected Obj, but got Unknown
			//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ce: Expected Obj, but got Unknown
			//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dc: Expected Obj, but got Unknown
			//IL_0608: Expected Obj, but got I4
			//IL_056d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Expected Obj, but got Unknown
			//IL_057b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0580: Expected Obj, but got Unknown
			//IL_05ac: Expected Obj, but got I4
			//IL_06fb: Expected Obj, but got I
			//IL_0739: Unknown result type (might be due to invalid IL or missing references)
			//IL_073e: Expected Obj, but got Unknown
			//IL_076f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0774: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			bool flag = PreferencesSave.soundEffectsEnabled;
			bool flag2;
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v9 (System.Boolean)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				nint num = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v229 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v235 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string oSVersion = DeviceUtility.GetOSVersion();
				flag = (byte)(int)oSVersion != 0;
			}
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v11 (Il2CppClass<Globals>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v221 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Locale locale = (Locale)((!Globals.DEBUG_FORCE_SPECIFIC_LOCALE) ? ((object)(Locale)flag) : ((object)"pt-BR"));
			object obj5 = default;
			Locale locale2 = (Locale)(obj5 + 8);
			bool flag3 = locale == locale2;
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v22 (Il2CppClass<Strings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			bool flag4 = obj6 == null;
			NullReferenceException ex;
			object obj16;
			StringsLanguage result;
			if (flag3)
			{
				if (!flag4)
				{
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v215 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A374");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num7 = 0;
				_ = 0;
				object obj8 = default;
				object obj7 = obj8 + 16;
				obj7 = obj5;
				ex = new NullReferenceException();
				if (ex != null)
				{
					goto IL_07ac;
				}
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v51 (Il2CppClass<Strings>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num9 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v208 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num10 = 0;
				_ = 0;
				Func<StringsLanguage, bool> func = default;
				object obj10 = func + 16;
				obj10 = obj5;
				IEnumerable<StringsLanguage> enumerable = Enumerable.Where(languages, func);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj11 = default;
				if (obj11 == null)
				{
					object obj12 = obj2 + 4;
					object obj13 = obj12 + 1;
					obj12 = obj13;
					object obj14 = obj13 << 2;
					object obj15 = obj2 + obj14;
					obj15 = 168;
					obj16 = 0;
					StringsLanguage stringsLanguage = default;
					result = stringsLanguage;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj17 = obj2 + 4;
					object obj18 = obj17 + 1;
					obj17 = obj18;
					object obj19 = obj18 << 2;
					object obj20 = obj2 + obj19;
					obj20 = 168;
					obj16 = 0;
					StringsLanguage stringsLanguage2 = default;
					result = stringsLanguage2;
				}
				object obj21 = default;
				if (obj21 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj22 = (nint)0 << 2;
					object obj23 = obj2 + obj22;
					if ((nint)obj23 == 168)
					{
						object obj24 = obj2 + 4;
						if ((nint)obj24 > -1)
						{
							object obj25 = obj24 + -1;
							obj24 = obj25;
						}
						goto IL_0ad6;
					}
				}
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_0ad6;
			}
			if (!flag4)
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v35 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A374");
			StringsLanguage result2 = default;
			return result2;
			IL_0ad6:
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S0_v86 (Il2CppClass<Strings>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num13 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v153 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num14 = 0;
			_ = 0;
			Func<StringsLanguage, bool> func2 = default;
			object obj27 = func2 + 16;
			obj27 = obj5;
			IEnumerable<StringsLanguage> enumerable2 = Enumerable.Where(languages, func2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj28 = default;
			if (obj28 == null)
			{
				object obj29 = obj2 + 4;
				object obj30 = obj29 + 1;
				obj29 = obj30;
				object obj31 = obj30 << 2;
				object obj32 = obj2 + obj31;
				obj32 = 232;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj33 = obj2 + 4;
				object obj34 = obj33 + 1;
				obj33 = obj34;
				object obj35 = obj34 << 2;
				object obj36 = obj2 + obj35;
				obj36 = 232;
				StringsLanguage stringsLanguage3 = default;
				result = stringsLanguage3;
			}
			object obj37 = default;
			if (obj37 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj38 = (nint)0 << 2;
				object obj39 = obj2 + obj38;
				if ((nint)obj39 == 232)
				{
					object obj40 = obj2 + 4;
					if ((nint)obj40 > -1)
					{
						object obj41 = obj40 + -1;
						obj40 = obj41;
					}
					return result;
				}
			}
			if (obj16 == null)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			goto IL_07ac;
			IL_07ac:
			return (StringsLanguage)(object)ex;
		}
		set
		{
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected Obj, but got Unknown
			//IL_01fe: Expected Obj, but got I4
			//IL_002c: Expected I, but got Obj
			//IL_0042: Expected Obj, but got I
			//IL_022c: Expected I, but got Obj
			//IL_0242: Expected Obj, but got I
			//IL_006d: Expected I, but got Obj
			//IL_030d: Expected I, but got Obj
			//IL_0323: Expected Obj, but got I
			//IL_00ba: Expected I, but got Obj
			//IL_0107: Expected I, but got Obj
			//IL_011d: Expected Obj, but got I
			//IL_0195: Expected I, but got Obj
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Expected Obj, but got Unknown
			//IL_029c: Expected I, but got Obj
			//IL_02b2: Expected Obj, but got I
			//IL_0148: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 4;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Enum obj3 = default;
			IFormatProvider provider = default;
			if (!obj3.System_002EIConvertible_002EToBoolean(provider))
			{
				return;
			}
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v25 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v13 (Il2CppClass<Strings+<>c>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v60 (Il2CppClass<Strings+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_003C_003Ec._003C_003E9__18_0 == null)
			{
				nint num5 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v34 (Il2CppClass<Strings+<>c>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v54 (Il2CppClass<Strings+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num7 = 0;
				_ = 0;
				object obj8 = default;
				object obj7 = obj8 + 16;
				obj7 = _003C_003Ec._003C_003E9;
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v51 (Il2CppClass<Strings+<>c>)+5C]");
				object obj9 = (nint)0 + (nint)4;
				obj9 = obj8;
			}
			NullReferenceException ex = (NullReferenceException)(object)new KindlePurchaseProviderCallbackListener();
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v24 (Il2CppClass<Strings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v29 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((KindlePurchaseProviderCallbackListener)(object)ex)._002Ector();
		}
	}

	public static CultureInfo cultureInfo
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (CultureInfo)(object)_language;
		}
	}

	public static event Action languageChanged
	{
		add
		{
			((Encoding)(object)value).SetDefaultFallbacks();
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Strings.m_languageChanged;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Strings>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Strings);
				if (!flag)
				{
					nint num5 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Strings>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Strings);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Strings);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Strings>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static void Init(LocaleData data)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(Strings);
		if (!flag)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Strings>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(Strings);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(Strings);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<Strings>)+5C]");
		object obj2 = (nint)0 + (nint)20;
		obj2 = data;
	}

	private static void OnRefresh(RefreshType refreshType)
	{
		//IL_039c: Expected I, but got Obj
		//IL_03b2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I
		//IL_0416: Expected I, but got Obj
		//IL_042c: Expected Obj, but got I
		//IL_044a: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_02da: Expected I, but got Obj
		//IL_02f0: Expected Obj, but got I
		//IL_04d6: Expected Obj, but got I4
		//IL_04e8: Expected I, but got Obj
		//IL_04fe: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_037f: Expected Obj, but got I4
		//IL_031b: Expected I, but got Obj
		//IL_017e: Expected I, but got Obj
		//IL_0194: Expected Obj, but got I
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_01bf: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_024c: Expected I, but got Obj
		//IL_0262: Expected Obj, but got I
		//IL_028d: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v112 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_hasInited ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v106 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_hasInited = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [refreshType @ L0 (AppRefresh.RefreshType)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v23+C]");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)0);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v28 (Il2CppClass<Strings>)+5C]");
		object obj4 = (nint)0 + (nint)24;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [refreshType @ L0 (AppRefresh.RefreshType)+C]");
		object obj5 = (nint)0 + (nint)12;
		object obj6 = 0;
		object obj11 = default;
		object obj15 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [refreshType @ L0 (AppRefresh.RefreshType)+C]");
			object obj7 = (nint)0 + (nint)16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			Locale locale = (Locale)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj10 = obj11 + 8;
			obj10 = obj9;
			object obj12 = obj11 + 12;
			object obj13 = ((IConvertible)"Kiloo/LocalizationManager/text/").ToType((Type)(object)locale.combined, (IFormatProvider)(object)"_locale");
			obj12 = obj13;
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v75 (Il2CppClass<Strings>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num7 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v100 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A374");
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [refreshType @ L0 (AppRefresh.RefreshType)+C]");
				object obj16 = (nint)0 + (nint)16;
				if ((Locale)obj9 != (Locale)obj16)
				{
					nint num8 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v91 (Il2CppClass<Strings>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num9 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v96 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3B5");
				}
			}
			object obj18 = obj6 + 1;
			obj6 = obj18;
		}
		nint num10 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v39 (Il2CppClass<Strings>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num11 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v60 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A374");
		string key = default;
		string localizedOnlineSettings = GetLocalizedOnlineSettings(key, (string)1);
		nint num12 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v47 (Il2CppClass<Strings>)+5C]");
		object obj20 = (nint)0 + (nint)4;
		obj20 = localizedOnlineSettings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		_ = 0;
		Action<RefreshType> action = default;
		object obj21 = action + 16;
		obj21 = 0;
		AppRefreshHandler.refresh -= action;
	}

	public static StringsLanguage DetermineBestLanguage()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return defaultLanguage__BackingField;
	}

	private static void VerifyLocaleResources()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Action action = default;
		languageChanged += action;
		ASCIIEncoding.ASCII = (Encoding)(object)action;
	}

	public static string Get(string key)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = key;
		return text;
	}

	public static string GetDefault(string key)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)LoadLanguageMap((StringsLanguage)(object)key, (byte)(int)_currentLanguageMap != 0);
	}

	public static string GetLegal(string key)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)LoadLanguageMap((StringsLanguage)(object)key, (byte)(int)_defaultLanguageMap != 0);
	}

	private static string GetFromMap(string key, Dictionary<string, string> map)
	{
		//IL_000a: Expected Obj, but got I4
		return (string)((string)(object)map).m_firstChar;
	}

	public unsafe static bool IsMapped(string keyString)
	{
		LocaleData instance = LocaleData.instance;
		return Locale.TryParse((string)(object)instance, out *(Locale*)keyString);
	}

	private unsafe static Dictionary<string, string> LoadLanguageMap(StringsLanguage lang, bool forceLoad = false)
	{
		//IL_0047: Expected Obj, but got I4
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		ref string reference = ref *(string*)null;
		Dictionary<string, string> result;
		if (lang == null || (object)lang.locale == null)
		{
			result = null;
		}
		else if (!((Dictionary<string, string>)forceLoad).TryGetValue((string)(object)lang, out reference))
		{
			result = (Dictionary<string, string>)(object)"";
		}
		else
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v18 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = gibberish;
			bool flag2 = reference == null;
			string text = "";
			if (!flag2)
			{
				text = reference;
			}
			bool flag3 = !flag;
			result = (Dictionary<string, string>)(object)text;
			if (!flag3)
			{
				int num3 = ((StringComparer)null).Compare((object)120, (object)text.m_stringLength);
				result = (Dictionary<string, string>)num3;
			}
		}
		return result;
	}

	public static Dictionary<string, string> DeserializeObject(string s)
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_hasInited ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v25 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v3 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S2_v4+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v5+44]");
			object obj5 = 0;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v66 @ S3_v5 (should have been resolved before IL gen)");
			object obj8 = default;
			bool flag = (nint)obj8 > -1;
			return (Dictionary<string, string>)flag;
		}
		return null;
	}

	public static string SerializeObject(Dictionary<string, string> data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_029d: Expected Obj, but got I4
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02ea: Expected I, but got Obj
		//IL_0300: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I
		//IL_03dc: Expected Obj, but got I
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v125 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S3_v3+60]");
		object obj8 = 0;
		object obj9 = obj8;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v89 @ S4_v4 (should have been resolved before IL gen)");
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj13 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj13 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			object obj14 = obj5 + 4;
			object obj15 = obj14 + 1;
			obj14 = obj15;
			object obj16 = obj15 << 2;
			object obj17 = obj5 + obj16;
			obj17 = 101;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			string result = default;
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj18 = (nint)0 << 2;
				object obj19 = obj5 + obj18;
				if ((nint)obj19 == 101)
				{
					object obj20 = obj5 + 4;
					if ((nint)obj20 > -1)
					{
						object obj21 = obj20 + -1;
						obj20 = obj21;
					}
					return result;
				}
			}
			object obj22 = default;
			if (obj22 == null)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			SDebug.LogFormat("Deserialized JSon is null.", null);
		}
		string result2 = default;
		return result2;
	}

	private static void Log(string text, UnityEngine.Object context = null)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		bool hasChanged = ((Transform)context).hasChanged;
		nint num = (nint)typeof(MeFooter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<MeFooter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(MeFooter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v14 (Il2CppClass<MeFooter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int selectedTab = (hasChanged ? 1 : 0) + 1;
		MeFooter.selectedTab = selectedTab;
	}

	public static CultureInfo GetLegalCultureInfo()
	{
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12+18]");
		object obj3 = default;
		CultureInfo.CheckDomainSafetyObject(obj3, (object)0);
		return (CultureInfo)obj3;
	}

	private static string AddLocaleSuffix(string key)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		string result = default;
		return result;
	}

	public static bool HasLocalizedOnlineSettings(string key)
	{
		//IL_025a: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_030f: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v61 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
		object obj2 = default;
		string text = default;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v19 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v57 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A374");
			object obj4 = default;
			object obj5 = default;
			if (obj4 != obj5)
			{
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v27 (Il2CppClass<Strings>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v53 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v32+8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33+8]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33+10]");
						string arg = ((string)0).ToLowerInvariant();
						string format = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33+C]");
						string text2 = string.Format((IFormatProvider)(object)"{0}_{1}{2}", format, 0, arg);
						text = text2;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33+8]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						string text3 = default;
						string msg = "Unhandled localeType: " + text3;
						SDebug.LogFormat(msg, null);
					}
				}
				else
				{
					string format2 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33+C]");
					string text4 = string.Format((IFormatProvider)(object)"{0}_{1}", format2, 0);
					text = text4;
				}
			}
		}
		return (byte)(int)text != 0;
	}

	public static string GetLocalizedOnlineSettings(string key, string defaultValue)
	{
		//IL_012f: Expected Obj, but got I4
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0194: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		string result;
		if (defaultValue == null)
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v19 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v40 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A374");
			object obj2 = default;
			if (obj2 == key)
			{
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v27 (Il2CppClass<Strings>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v34 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				result = (string)(object)_defaultLanguageMap;
				goto IL_02c0;
			}
		}
		TextAsset textAsset = Resources.Load<TextAsset>((string)key.m_firstChar);
		byte[] bytes = textAsset.bytes;
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v8 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v14 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = SerializeObject((Dictionary<string, string>)(object)bytes);
		bool flag = text == null;
		bool flag2 = !flag;
		result = text;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S3_v3 (Il2CppMethodInfo)+C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S3_v4+60]");
			object obj6 = 0;
			object obj7 = obj6;
			object obj8 = obj7 & 0x1FFF;
			object obj9 = obj8 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S4_v5 (should have been resolved before IL gen)");
			string text2 = default;
			result = text2;
		}
		goto IL_02c0;
		IL_02c0:
		return result;
	}

	public unsafe static bool TryGetLocalizedOnlineSettings(string key, out string valueString)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HasLocalizedOnlineSettings(key);
		return ((OnlineSettings)(object)saveDataPath).GetValue((string)flag, (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref valueString) != 0);
	}

	static Strings()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected Obj, but got Unknown
		//IL_0914: Expected Obj, but got I4
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected Obj, but got Unknown
		//IL_0931: Expected Obj, but got I4
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected Obj, but got Unknown
		//IL_097c: Expected I, but got Obj
		//IL_0992: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I4
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_05c4: Expected Obj, but got I
		//IL_0abb: Expected I, but got Obj
		//IL_0ad1: Expected Obj, but got I
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_08a2: Expected I, but got Obj
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Obj, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected Obj, but got Unknown
		//IL_0750: Expected Obj, but got I4
		//IL_07ff: Expected Obj, but got I
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_0503: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		TextAsset[] source = Resources.LoadAll<TextAsset>("Kiloo/LocalizationManager/text");
		IEnumerable<_0021_00210> enumerable = (IEnumerable<_0021_00210>)Enumerable.OfType<TResult>((IEnumerable)source);
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v258 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = default;
		object obj9 = default;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj8 = obj9;
			while (true)
			{
				object obj10 = obj8 - 1;
				if ((nint)obj10 >= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v182+8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					bool flag = obj12 == null;
					obj8 = obj10;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						break;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v182+8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				break;
			}
		}
		object obj14 = 31;
		object obj15 = obj14 - 10;
		object obj20;
		if ((nint)obj14 != 10 && (nint)obj15 != 1)
		{
			if ((nint)obj15 != 2 && (nint)obj15 != 3 && (nint)obj15 != 4 && (nint)obj15 != 5 && (nint)obj15 != 6)
			{
				if ((nint)obj15 == 7 || (nint)obj15 == 8 || (nint)obj15 == 9 || (nint)obj15 == 10)
				{
					goto IL_0516;
				}
				if ((nint)obj15 != 11)
				{
					if ((nint)obj15 == 12)
					{
						goto IL_0516;
					}
					if ((nint)obj15 != 13 && (nint)obj15 != 14 && (nint)obj15 != 15 && (nint)obj15 != 16 && (nint)obj15 != 17 && (nint)obj15 != 18)
					{
						if ((nint)obj15 == 19 || (nint)obj15 == 20)
						{
							goto IL_0516;
						}
						if ((nint)obj15 == 21)
						{
							object obj16 = obj5 + 4;
							object obj17 = obj16 + 1;
							obj16 = obj17;
							object obj18 = obj17 << 2;
							object obj19 = obj5 + obj18;
							obj19 = 183;
							obj20 = 0;
							goto IL_0589;
						}
					}
				}
			}
			goto IL_08f2;
		}
		goto IL_0516;
		IL_0aad:
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S0_v57 (Il2CppClass<Strings>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v68 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A374");
		object obj22 = default;
		if (obj22 == null)
		{
			SDebug.LogFormat("Strings.Init(): defaultLanguage is null!", null);
		}
		return;
		IL_08f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		return;
		IL_0a48:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23 (System.Collections.Generic.IEnumerable`1<TResult>)+C]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder sb = default;
			System.Text.StringBuilderCache.Release(sb);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj23 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj23 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			}
			object obj24 = obj5 + 4;
			object obj25 = obj24 + 1;
			obj24 = obj25;
			object obj26 = obj25 << 2;
			object obj27 = obj5 + obj26;
			obj27 = 271;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj28 = (nint)0 << 2;
				object obj29 = obj5 + obj28;
				if ((nint)obj29 == 271)
				{
					object obj30 = obj5 + 4;
					if ((nint)obj30 > -1)
					{
						object obj31 = obj30 + -1;
						obj30 = obj31;
					}
					goto IL_0aad;
				}
			}
			if (obj20 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_0aad;
		IL_0589:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj32 = (nint)0 << 2;
			object obj33 = obj5 + obj32;
			if ((nint)obj33 == 183)
			{
				object obj34 = obj5 + 4;
				if ((nint)obj34 > -1)
				{
					object obj35 = obj34 + -1;
					obj34 = obj35;
				}
				goto IL_0a48;
			}
		}
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0a48;
		IL_0516:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj36 = default;
		object obj37 = default;
		if (obj36 == obj37)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj38 = default;
			obj20 = obj38;
			goto IL_0589;
		}
		object obj40 = default;
		object obj39 = obj40;
		goto IL_08f2;
	}
}
