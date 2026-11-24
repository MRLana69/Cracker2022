using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class NativeInterstitialAdObject
{
	private string _title;

	private string _subtitle;

	private string _body;

	private string _socialContext;

	private string _callToActionText;

	private string _iconImageURL;

	private string _coverImageURL;

	private Texture2D _iconImage;

	private Texture2D _coverImage;

	private bool _valid;

	public const int TITLE_MIN_LENGTH = 20;

	public const int BODY_MIN_LENGTH = 72;

	public const int CAT_MIN_LENGTH = 25;

	public bool Valid
	{
		get
		{
			//IL_002a: Expected I4, but got Obj
			if (_body != null)
			{
				string body = _body;
				return (byte)body.m_stringLength != 0;
			}
			return (byte)(int)string.Empty != 0;
		}
	}

	public string Title
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool valid = _valid;
			return (string)valid;
		}
	}

	public string Subtitle => _title;

	public string Body => _subtitle;

	public string SocialContext => _body;

	public string CallToActionText => _socialContext;

	public string IconImageURL => _callToActionText;

	public string CoverImageURL => _iconImageURL;

	public Texture2D IconImage => (Texture2D)(object)_coverImageURL;

	public Texture2D CoverImage => _iconImage;

	public NativeInterstitialAdObject(string title, string subtitle, string body, string socialContext, string callToActionText, string iconImageURL, string coverImageURL, Texture2D iconImage, Texture2D coverImage, bool ignoreValidate = false)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public bool Validate()
	{
		//IL_0007: Expected I4, but got Obj
		return (byte)(int)_coverImage != 0;
	}

	public unsafe void Dispose()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I4
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_03a2: Expected Obj, but got I4
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03d8: Expected I, but got Obj
		//IL_03ee: Expected Obj, but got I
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got VT
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected VT, but got Unknown
		//IL_0532: Expected I8, but got Obj
		//IL_052d: Expected native int or pointer, but got VT
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		//IL_0555: Expected Ref, but got VT
		//IL_0021: Expected I, but got Obj
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I4
		//IL_02c4: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_041b: Expected Obj, but got I8
		//IL_0428: Expected I8, but got Obj
		//IL_0423: Expected native int or pointer, but got VT
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 144;
		object obj3 = obj2 + 120;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 112;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<System.DateTime>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v162 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 32;
		object obj8 = obj2 + 24;
		DateTime utcNow = DateTime.UtcNow;
		object obj9 = obj2 + 72;
		obj9 = utcNow;
		object obj10 = obj2 + 40;
		obj10 = _callToActionText;
		DateTime dateTime = (DateTime)(obj2 + 80);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj9;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 88);
		formatProvider = (IFormatProvider)obj10;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		IEnumerable<string> collection = default;
		list._002Ector(collection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = formatProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v41 (System.IFormatProvider)+8]");
		_ = 0;
		object obj11 = default;
		object obj15 = default;
		object obj17 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj11 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj12 = obj4 + 16;
			nint num4 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v128 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num5 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v155 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj7 = obj12;
			obj8 = num3;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj7;
			formatProvider = (IFormatProvider)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
			object obj14 = obj15 << 32;
			object obj16 = obj17 | obj14;
			obj12 = obj16;
			formatProvider = (IFormatProvider)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj18 = obj5 + 4;
		object obj19 = obj18 + 1;
		obj18 = obj19;
		object obj20 = obj19 << 2;
		object obj21 = obj5 + obj20;
		obj21 = 124;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
			object obj22 = (nint)0 << 2;
			object obj23 = obj5 + obj22;
			if ((nint)obj23 == 124)
			{
				object obj24 = obj5 + 4;
				if ((nint)obj24 > -1)
				{
					object obj25 = obj24 + -1;
					obj24 = obj25;
				}
				return;
			}
		}
		object obj26 = default;
		if (obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public override string ToString()
	{
		//IL_0351: Expected Obj, but got I4
		//IL_026d: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_0150: Expected I, but got Obj
		//IL_01ad: Expected I, but got Obj
		string title = _title;
		if (_title != null && title.m_stringLength != 0)
		{
			string body = _body;
			if (_body != null && body.m_stringLength != 0)
			{
				string callToActionText = _callToActionText;
				if (_callToActionText != null && callToActionText.m_stringLength != 0)
				{
					string callToActionText2 = _callToActionText;
					if (callToActionText2.m_stringLength > 25)
					{
						object obj = 25;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						string text2 = default;
						string text = "Call To Action text is over " + text2 + " characters";
						_valid = false;
					}
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (_iconImage != null)
					{
						_valid = false;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (_coverImage != null)
					{
						_valid = false;
					}
					goto IL_0338;
				}
			}
		}
		_valid = false;
		goto IL_0338;
		IL_0338:
		bool valid = _valid;
		return (string)valid;
	}

	private unsafe static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_0092: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_0034: Expected I, but got Obj
		ref int reference = ref *(int*)null;
		bool flag = ((Dictionary<string, int>)msg.m_firstChar).TryGetValue((string)(object)context, out reference);
		object obj = reference + 1;
		reference = ref *(int*)obj;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S4_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S4_v4+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S5_v4 (should have been resolved before IL gen)");
		int stringLength = default;
		if (reference < 21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		}
		else
		{
			stringLength = msg.m_stringLength;
		}
		string text = string.Format((IFormatProvider)(object)"{0}_{1}", (string)(object)context, stringLength);
		nint num2 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v24 (Il2CppClass<Flurry>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num3 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"Native Ad Object: ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
