using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kiloo.Plugins.Facebook;

public class FacebookError
{
	public enum Category
	{
		INVALID,
		AUTHENTICATION_RETRY,
		AUTHENTICATION_REOPEN_SESSION,
		PERMISSION,
		SERVER,
		THROTTLING,
		CANCELED,
		OTHER,
		BAD_REQUEST,
		CLIENT
	}

	public const int INVALID_ERROR_CODE = -1;

	public const int INVALID_HTTP_STATUS_CODE = -1;

	public Category category;

	public int requestStatusCode;

	public int errorCode;

	public int subErrorCode;

	public string errorType;

	public string errorMessage;

	public bool shouldNotifyUser;

	public string userActionMessage;

	public string exceptionType;

	public string exceptionMessage;

	public FacebookError()
	{
		subErrorCode = -1;
		requestStatusCode = -1;
	}

	public FacebookError(IDictionary<string, object> error)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Obj, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected Obj, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_03ee: Expected Obj, but got I
		//IL_0437: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I
		//IL_018d: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		subErrorCode = -1;
		requestStatusCode = -1;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj4 = default;
		if (obj4 == null)
		{
			goto IL_0679;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj5 = default;
								category = (Category)obj5;
								goto IL_0679;
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
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag = obj6 != obj7;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			FacebookError facebookError;
			if ((nint)0 != 1)
			{
				object obj11 = default;
				object obj10 = obj11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = default;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj + obj13;
						obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj16 = -1;
						goto IL_0679;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj17 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					facebookError = (FacebookError)0;
					obj8 = obj11;
					if (flag2)
					{
						goto IL_06ae;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			facebookError = (FacebookError)0;
			object obj18 = default;
			obj8 = obj18;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				facebookError = (FacebookError)0;
				obj8 = obj18;
			}
		}
		goto IL_06ae;
		IL_0679:
		object obj19 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj20 = default;
		if (obj20 != null)
		{
			throw new NullReferenceException();
		}
		object obj21 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj22 = default;
		if (obj22 != null)
		{
			throw new NullReferenceException();
		}
		object obj23 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj24 = default;
		if (obj24 != null)
		{
			throw new NullReferenceException();
		}
		object obj25 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj26 = default;
		if (obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			string text = default;
			errorType = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
		object obj27 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj28 = default;
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			string text2 = default;
			errorMessage = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
		object obj29 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj30 = default;
		if (obj30 != null)
		{
			throw new NullReferenceException();
		}
		object obj31 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj32 = default;
		if (obj32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			string text3 = default;
			userActionMessage = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
		object obj33 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj34 = default;
		if (obj34 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			string text4 = default;
			exceptionType = text4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
		object obj35 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj36 = default;
		if (obj36 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			string text5 = default;
			exceptionMessage = text5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
		return;
		IL_06ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0679;
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = category;
		object obj3 = obj + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}
}
