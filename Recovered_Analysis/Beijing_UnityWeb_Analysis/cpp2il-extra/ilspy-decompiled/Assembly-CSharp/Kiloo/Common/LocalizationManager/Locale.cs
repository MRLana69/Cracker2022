using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.OnGUIWrappers;
using UnityEngine;

namespace Kiloo.Common.LocalizationManager;

public class Locale
{
	public enum LocaleType
	{
		Language,
		LanguageAndRegion
	}

	public readonly LocaleType localeType;

	public readonly string language;

	public readonly string region;

	public readonly string[] extraRegions;

	public readonly string combined;

	public readonly string nativeName;

	private bool IsValid()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		bool result = default;
		return result;
	}

	public static Locale Create(string language, string region = null, string[] extraRegions = null, string nativeName = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		object obj3 = region & 1;
		obj = obj3;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj4 = default;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		Locale result = default;
		return result;
	}

	private unsafe Locale(string language, string region, string[] extraRegions, string nativeName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected VT, but got Unknown
		//IL_0031: Expected F4, but got Obj
		//IL_002c: Expected native int or pointer, but got VT
		//IL_004a: Expected I4, but got Obj
		//IL_004a: Expected I4, but got Obj
		//IL_0057: Expected F4, but got Obj
		//IL_0052: Expected native int or pointer, but got VT
		//IL_0061: Expected Obj, but got VT
		GUIStyle gUIStyle = default;
		object obj = gUIStyle + 8;
		obj = language;
		Rect rect = (Rect)(gUIStyle + 16);
		((Rect*)(nint)rect)->m_XMin = (float)obj;
		gUIStyle.Internal_Draw2(rect, (GUIContent)(object)region, (int)extraRegions, (byte)(int)nativeName != 0);
		((Rect*)(nint)rect)->m_XMin = (float)gUIStyle;
		((GUIVertical)this)._002Ector((GUILayoutOption[])rect);
	}

	private string GetLanguageCode()
	{
		//IL_004f: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		if (localeType != LocaleType.Language)
		{
			if (localeType == LocaleType.LanguageAndRegion)
			{
				string text = language;
				if (text.m_stringLength > 0)
				{
					string text2 = region;
					bool flag = text2.m_stringLength > 0;
					return (string)flag;
				}
				return null;
			}
			object obj = localeType;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text3 = default;
			string msg = "Unhandled localeType: " + text3;
			SDebug.LogFormat(msg, null);
			return null;
		}
		string text4 = language;
		bool flag2 = text4.m_stringLength > 0;
		return (string)flag2;
	}

	public unsafe static bool TryParse(string input, out Locale locale)
	{
		//IL_0012: Expected Obj, but got Ref
		//IL_0012: Expected Obj, but got I4
		//IL_0016: Expected I4, but got Obj
		return (byte)(int)((LegalTextData)input.m_firstChar).GetLegalText((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref locale)) != 0;
	}

	public static Locale Parse(string input)
	{
		//IL_0039: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		if (input.m_stringLength != 0)
		{
			if (input.m_stringLength == 1)
			{
				char firstChar = input.m_firstChar;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [input @ L0 (System.String)+10]");
				return (Locale)(object)string.Format((IFormatProvider)(object)"{0}-{1}", (string)firstChar, 0);
			}
			object obj = input.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "Unhandled localeType: " + text;
			SDebug.LogFormat(msg, null);
			return (Locale)(object)string.Empty;
		}
		return (Locale)input.m_firstChar;
	}

	public static bool operator ==(Locale loc1, Locale loc2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj3 = default;
		Locale locale = (Locale)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj4 = default;
		if (obj4 == null)
		{
			locale = (Locale)0;
		}
		return true;
	}

	public static bool operator !=(Locale loc1, Locale loc2)
	{
		//IL_0060: Expected Obj, but got I4
		if ((object)loc1 == loc2)
		{
			return true;
		}
		bool flag = (object)loc1 == null;
		bool flag2 = (object)loc2 == null;
		object obj = flag | flag2;
		if (obj != null)
		{
			return false;
		}
		if (loc1.language == loc2.language)
		{
			return loc1.region == loc2.region;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		bool flag = this != (Locale)obj;
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public override int GetHashCode()
	{
		//IL_0122: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0042: Expected I4, but got Obj
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0073: Expected I4, but got Obj
		//IL_018a: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 45;
		object obj2 = num + 18;
		obj2 = 95;
		string text = ((string)this).Substring(num);
		object obj3 = text.m_firstChar - 1;
		Locale locale;
		string message;
		int status;
		if (text.m_firstChar != '\u0001')
		{
			if ((nint)obj3 != 1)
			{
				locale = null;
				goto IL_00a2;
			}
			object obj4 = text + 16;
			object obj5 = text + 20;
			message = (string)obj5;
			status = (int)obj4;
		}
		else
		{
			object obj6 = text + 16;
			message = null;
			status = (int)obj6;
		}
		IResponse response = HTTPFactory.CreateResponse(status, message, null, null);
		locale = (Locale)response;
		goto IL_00a2;
		IL_00a2:
		Locale locale2;
		if (locale.Equals(null))
		{
			string languageCode = locale.GetLanguageCode();
			if (languageCode != null)
			{
				locale2 = locale;
				goto IL_0185;
			}
		}
		locale2 = null;
		goto IL_0185;
		IL_0185:
		return (int)locale2;
	}
}
