using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using UnityEngine;

namespace Kiloo.Common.LocalizationManager;

public class LocaleData : ScriptableObject
{
	[Serializable]
	private struct SerializableLocale
	{
		public string nativeName;

		public bool isEnabled;

		public string language;

		public string region;

		public string[] extraRegions;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<SerializableLocale> _003C_003E9__4_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LegalLanguage._003C_003Ec obj = default;
			LegalLanguage._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003CLoad_003Eb__4_0(SerializableLocale x)
		{
			//IL_0010: Expected Obj, but got I
			//IL_002a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.LocalizationManager.LocaleData+<>c)+8]");
			object obj = 0;
			string language = x.language;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			return language != (string)0;
		}
	}

	private const string RESOURCE_PATH = "Kiloo/LocalizationManager/LocaleData";

	private static LocaleData _instance;

	public Locale[] supportedLocales;

	public Dictionary<string, string> nativeNames;

	private List<SerializableLocale> _locales;

	public static LocaleData instance
	{
		get
		{
			//IL_008c: Expected I, but got Obj
			//IL_00a2: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (LegalTextData._instance != null)
			{
				_0021_00210[] array = (_0021_00210[])(object)Resources.LoadAll<T>("Kiloo/LocalizationManager/LegalTextData");
				LegalTextData._instance = (LegalTextData)(object)array;
				LegalTextData._instance.DetectLocale();
			}
			return (LocaleData)(object)LegalTextData._instance;
		}
	}

	public Locale defaultLocale
	{
		get
		{
			//IL_0037: Expected Obj, but got I4
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected Obj, but got Unknown
			//IL_0072: Expected Obj, but got I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected Obj, but got Unknown
			object obj = default;
			if (supportedLocales != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			}
			else
			{
				obj = 0;
			}
			object obj2 = obj * 397;
			object obj4;
			object obj5 = default;
			if (nativeNames != null)
			{
				object obj3 = obj * 397;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				obj4 = obj3;
			}
			else
			{
				obj4 = obj2;
				obj5 = 0;
			}
			return (Locale)(obj5 ^ obj4);
		}
	}

	private void Load()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)this);
	}

	public LocaleData()
	{
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02b4: Expected Obj, but got I4
		//IL_02ce: Expected I, but got Obj
		//IL_02e4: Expected Obj, but got I
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected Obj, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_0449: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_033e: Expected I, but got Obj
		//IL_0354: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 120;
		obj = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<Kiloo.Common.LocalizationManager.LocaleData+<>c>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v88 (Il2CppClass<Kiloo.Common.LocalizationManager.LocaleData+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__4_0 == null;
		bool flag2 = !flag;
		Predicate<_00210> match = (Predicate<_00210>)(object)_003C_003Ec._003C_003E9__4_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v62 (Il2CppClass<Kiloo.Common.LocalizationManager.LocaleData+<>c>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v82 (Il2CppClass<Kiloo.Common.LocalizationManager.LocaleData+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Predicate<_00210> predicate = default;
			object obj5 = predicate + 16;
			obj5 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v79 (Il2CppClass<Kiloo.Common.LocalizationManager.LocaleData+<>c>)+5C]");
			object obj6 = (nint)0 + (nint)4;
			obj6 = predicate;
			match = predicate;
		}
		object obj7 = obj2 + 100;
		object obj8 = obj2 + 80;
		object obj9 = obj2 + 60;
		object obj10 = obj2 + 40;
		object obj11 = obj2 + 20;
		int num7 = ((List<T>)(object)_locales).FindIndex((Predicate<T>)(object)match);
		object obj12 = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj13 = default;
		obj12 = obj13;
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v14 (System.Int32)+C]");
		if ((nint)obj14 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F5");
			obj = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v18+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v18+10]");
			_ = 0;
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v18+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v18+10]");
			_ = 0;
			obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v20+8]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v22+C]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v24+10]");
			IResponse response = HTTPFactory.CreateResponse((int)num8, (string)num9, (Headers)0, (byte[])obj11);
			throw new ArrayTypeMismatchException();
		}
	}
}
