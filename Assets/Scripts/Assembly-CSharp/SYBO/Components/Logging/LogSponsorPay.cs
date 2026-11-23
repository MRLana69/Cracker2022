using System;
using Cpp2ILInjected;

namespace SYBO.Components.Logging;

public class LogSponsorPay : LogCategory
{
	public LogSponsorPay(int categoryId)
	{
		CategoryId = categoryId;
		Log.SponsorPay = this;
		CategoryText = "SponsorPay";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
