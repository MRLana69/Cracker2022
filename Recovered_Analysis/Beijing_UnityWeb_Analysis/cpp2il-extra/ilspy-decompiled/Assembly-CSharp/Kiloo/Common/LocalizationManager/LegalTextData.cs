using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;

namespace Kiloo.Common.LocalizationManager;

public class LegalTextData : ScriptableObject
{
	private const string RESOURCE_PATH = "Kiloo/LocalizationManager/LegalTextData";

	private static LegalTextData _instance;

	private LegalLanguage _currentLanguage;

	public TermKeys termKeys;

	private LegalLanguage _fallbackLanguage;

	public List<LegalLanguage> legalLanguages;

	public static LegalTextData instance
	{
		get
		{
			//IL_0066: Expected I4, but got Obj
			//IL_0066: Expected I4, but got Obj
			//IL_0034: Expected I4, but got Obj
			//IL_0038: Expected Obj, but got I4
			string graphicsDeviceVersion = SystemInfo.GetGraphicsDeviceVersion();
			string text = graphicsDeviceVersion.ToLowerInvariant();
			string text2 = text.Remove((int)"(tm)", (int)string.Empty);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.Text.RegularExpressions.ExclusiveReference exclusiveReference = default;
			exclusiveReference.Release((object)"[^a-z0-9]");
			return (LegalTextData)((System.Text.RegularExpressions.RegexBoyerMoore)(object)exclusiveReference).MatchPattern(text2, (int)"");
		}
	}

	private void Load()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)this);
	}

	public string GetLegalText(string key)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = key;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Func<LegalLanguage.Term, bool> func = default;
		object obj3 = func + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.LocalizationManager.LegalTextData)+20]");
		LegalLanguage.Term term = Enumerable.FirstOrDefault((IEnumerable<LegalLanguage.Term>)0, func);
		if (term != null)
		{
			return term.value;
		}
		return string.Empty;
	}

	public CultureInfo GetLegalCulture()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return CultureInfo.CreateSpecificCulture((string)(object)termKeys);
	}

	private void DetectLocale()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<RefreshType> action = default;
		object obj = action + 16;
		obj = this;
		AppRefreshHandler.hasRefreshed -= action;
		SyncLanguageKeys();
	}

	public void SetLocale(string localeString)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		_ = localeString.m_stringLength;
		object obj = this + 8;
		obj = localeString;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
	}

	private void SetLanguage(Locale locale)
	{
		//IL_0017: Expected Obj, but got I4
		int hashCode = locale.GetHashCode();
		SyncLanguage((LegalLanguage)hashCode);
	}

	private void SyncLanguageKeys()
	{
		//IL_00f6: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_003d: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_00c5: Expected I4, but got Obj
		//IL_014a: Expected I4, but got Obj
		//IL_007e: Expected I, but got Obj
		Locale locale = (Locale)0;
		bool soundEffectsEnabled = PreferencesSave.soundEffectsEnabled;
		bool flag;
		if (soundEffectsEnabled)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		bool flag2 = !flag;
		bool flag3 = soundEffectsEnabled;
		if (!flag2)
		{
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v22 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v28 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
			flag3 = (byte)(int)unfilteredLocale != 0;
		}
		int num3;
		if ((Locale)flag3 == locale)
		{
			num3 = (int)locale;
		}
		else
		{
			int hashCode = ((Locale)(object)"en-XX").GetHashCode();
			locale = (Locale)hashCode;
			num3 = hashCode;
		}
		SyncLanguage((LegalLanguage)num3);
	}

	private void SyncLanguage(LegalLanguage lang)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = lang;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		NullReferenceException ex = new NullReferenceException();
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)ex);
		bool flag2 = !flag;
		bool flag3 = !flag2;
		NullReferenceException ex2 = ex;
		if (!flag3)
		{
			ex2 = (NullReferenceException)(object)_fallbackLanguage;
		}
		object obj6 = this + 12;
		obj6 = ex2;
	}

	private void FillEmptyTermsWithFallback()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 54)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_0263;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0263;
		IL_0263:
		FillMissingLanguageWithFallback(_fallbackLanguage);
	}

	private void FillMissingLanguageWithFallback(LegalLanguage lang)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_04d9: Expected Obj, but got I4
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_052e: Expected Obj, but got I4
		//IL_0585: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_0418: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0390: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		TermKeys termKeys = this.termKeys;
		List<string> keys = termKeys.keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)keys._size);
		TermKeys termKeys2 = this.termKeys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		IntPtr method = default;
		object obj8 = default;
		object obj5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj5 = 27;
			bool flag = obj6 == null;
			obj5 = 28;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj5 = 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj5 = 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj5 = 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj5 = 17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj5 = 17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj5 = 18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj5 = 18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj5 = 19;
			((Func<LegalLanguage.Term, bool>)5527)._002Ector(obj7, method);
			obj5 = 19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj5 = 20;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				obj5 = 25;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj9 = obj5 - 15;
		if ((nint)obj5 != 15 && (nint)obj9 != 1 && (nint)obj9 != 2 && (nint)obj9 != 3 && (nint)obj9 != 4 && (nint)obj9 != 5)
		{
			if ((nint)obj9 != 6 && (nint)obj9 != 7 && (nint)obj9 != 8 && (nint)obj9 != 9)
			{
				if ((nint)obj9 == 10 || (nint)obj9 == 11 || (nint)obj9 == 12)
				{
					goto IL_0395;
				}
				if ((nint)obj9 == 13)
				{
					object obj10 = obj4 + 4;
					object obj11 = obj10 + 1;
					obj10 = obj11;
					object obj12 = obj11 << 2;
					object obj13 = obj4 + obj12;
					obj13 = 157;
				}
			}
			goto IL_0594;
		}
		goto IL_0395;
		IL_05b9:
		object obj14 = lang + 32;
		obj14 = list;
		return;
		IL_0594:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 157)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_05b9;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_05b9;
		IL_0395:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj20 = default;
		object obj21 = default;
		if (obj20 == obj21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0594;
	}

	public LegalTextData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 54)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void _003CLoad_003Eb__4_0(RefreshType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01d3: Expected Obj, but got I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0261: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 83;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 83)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				return;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
