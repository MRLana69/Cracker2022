using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.Notifications.Internal;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.LocalizationManager;

public class LegalLanguage : ScriptableObject
{
	[Serializable]
	public class Term
	{
		public string key;

		public string value;

		public Term()
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

		public static Func<string, bool> _003C_003E9__6_0;

		public static Func<string, bool> _003C_003E9__7_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PathHandling._003C_003Ec obj = default;
			PathHandling._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003CImportLocalePaste_003Eb__6_0(string l)
		{
			//IL_0017: Expected Obj, but got I4
			//IL_001b: Expected I4, but got Obj
			bool flag = ((DummyNotifications._003CGetEnumerator_003Ed__23)this).MoveNext();
			return (byte)(int)((MonoBehaviour)(object)l).StartCoroutine_Auto((IEnumerator)flag) != 0;
		}

		internal bool _003CImportValuePaste_003Eb__7_0(string v)
		{
			bool flag = v == null || v.m_stringLength == 0;
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
	}

	public string id;

	private string _localeId;

	public List<string> affectedLocales;

	private string _pasteLocaleList;

	private string _pasteTermValues;

	public List<Term> terms;

	// C# has no syntax for parameterized property 'Item'.
	public string get_Item(string key)
	{
		//IL_0043: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		if (System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref key) > System.Runtime.CompilerServices.Unsafe.As<LegalLanguage, UIntPtr>(ref this))
		{
			return (string)2;
		}
		return (string)4;
	}

	public CultureInfo GetCulture()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = ((UnityEngine.Object)this).m_CachedPtr != (IntPtr)0;
		return (CultureInfo)flag;
	}

	private void ImportLocalePaste()
	{
	}

	private void ImportValuePaste()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_004c: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_008d: Expected I, but got Obj
		//IL_00da: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0200: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_011b: Expected I, but got Obj
		string pasteLocaleList = _pasteLocaleList;
		if (pasteLocaleList.m_stringLength <= 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 32;
		string source = _pasteLocaleList.Substring(num);
		nint num2 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v10 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v53 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__6_0 == null;
		bool flag2 = !flag;
		Func<string, bool> predicate = _003C_003Ec._003C_003E9__6_0;
		if (!flag2)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v27 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v47 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num6 = 0;
			_ = 0;
			Func<string, bool> func = default;
			object obj4 = func + 16;
			obj4 = _003C_003Ec._003C_003E9;
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v44 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			obj5 = func;
			predicate = func;
		}
		IEnumerable<string> values = Enumerable.Where((IEnumerable<string>)(object)source, predicate);
		bool flag3 = Kiloo.Common.Extensions.CollectionExtensions.AddRangeDistinct(affectedLocales, values);
		object obj6 = this + 24;
		obj6 = string.Empty;
	}

	private void OnValidate()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_004c: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_008d: Expected I, but got Obj
		//IL_00da: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0273: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_011b: Expected I, but got Obj
		string pasteTermValues = _pasteTermValues;
		if (pasteTermValues.m_stringLength <= 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 10;
		string source = _pasteTermValues.Substring(num);
		nint num2 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v10 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v63 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__7_0 == null;
		bool flag2 = !flag;
		Func<string, bool> predicate = _003C_003Ec._003C_003E9__7_0;
		if (!flag2)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v37 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v57 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num6 = 0;
			_ = 0;
			Func<string, bool> func = default;
			object obj4 = func + 16;
			obj4 = _003C_003Ec._003C_003E9;
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v54 (Il2CppClass<Kiloo.Common.LocalizationManager.LegalLanguage+<>c>)+5C]");
			object obj5 = (nint)0 + (nint)8;
			obj5 = func;
			predicate = func;
		}
		IEnumerable<string> source2 = Enumerable.Where((IEnumerable<string>)(object)source, predicate);
		List<string> list = Enumerable.ToList(source2);
		int num8 = 0;
		while (true)
		{
			List<Term> list2 = terms;
			if (num8 >= list2._size)
			{
				break;
			}
			Term term = terms.get_Item(num8);
			object obj6 = term + 12;
			string text = list.get_Item(num8);
			obj6 = text;
			int num9 = num8 + 1;
			num8 = num9;
		}
		object obj7 = this + 28;
		obj7 = string.Empty;
	}

	public LegalLanguage()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 12;
		UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		obj = obj2;
	}
}
