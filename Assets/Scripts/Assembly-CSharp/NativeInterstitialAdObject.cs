using System;
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

	public bool Valid => _valid;

	public string Title => _title;

	public string Subtitle => _subtitle;

	public string Body => _body;

	public string SocialContext => _socialContext;

	public string CallToActionText => _callToActionText;

	public string IconImageURL => _iconImageURL;

	public string CoverImageURL => _coverImageURL;

	public Texture2D IconImage => _iconImage;

	public Texture2D CoverImage => _coverImage;

	public NativeInterstitialAdObject(string title, string subtitle, string body, string socialContext, string callToActionText, string iconImageURL, string coverImageURL, Texture2D iconImage, Texture2D coverImage, bool ignoreValidate = false)
	{
		_title = title;
		_subtitle = subtitle;
		_body = body;
		_socialContext = socialContext;
		_callToActionText = callToActionText;
		_iconImageURL = iconImageURL;
		_coverImageURL = coverImageURL;
		_iconImage = iconImage;
		_coverImage = coverImage;
		_valid = true;
		if (!ignoreValidate)
		{
			bool flag = Validate();
		}
	}

	public unsafe bool Validate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string title = _title;
		object obj3;
		if (_title != null)
		{
			obj3 = 0;
			if (title._stringLength != 0)
			{
				goto IL_01db;
			}
		}
		obj3 = 1;
		goto IL_01db;
		IL_01f7:
		object obj4;
		if (obj4 == null)
		{
			string callToActionText = _callToActionText;
			if (callToActionText._stringLength >= 26)
			{
				_ = 25;
				int num = obj + 12;
				string text = ((int*)num)->ToString();
				string text2 = "Call To Action text is over " + text + " characters";
				_valid = false;
			}
			if (_iconImage == null)
			{
				_valid = false;
			}
			if (!(_coverImage == null))
			{
				return _valid;
			}
		}
		goto IL_0193;
		IL_0193:
		_valid = false;
		return false;
		IL_01db:
		if (obj3 != null)
		{
			goto IL_0193;
		}
		string body = _body;
		object obj5;
		if (_body != null)
		{
			obj5 = 0;
			if (body._stringLength != 0)
			{
				goto IL_01e9;
			}
		}
		obj5 = 1;
		goto IL_01e9;
		IL_01e9:
		if (obj5 != null)
		{
			goto IL_0193;
		}
		string callToActionText2 = _callToActionText;
		if (_callToActionText != null)
		{
			obj4 = 0;
			if (callToActionText2._stringLength != 0)
			{
				goto IL_01f7;
			}
		}
		obj4 = 1;
		goto IL_01f7;
	}

	public void Dispose()
	{
		_title = null;
		_subtitle = null;
		_body = null;
		_socialContext = null;
		_callToActionText = null;
		_iconImageURL = null;
		_coverImageURL = null;
		UnityEngine.Object.Destroy(_iconImage);
		_iconImage = null;
		UnityEngine.Object.Destroy(_coverImage);
		_coverImage = null;
		_valid = false;
	}

	public override string ToString()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "Native Ad Object: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
