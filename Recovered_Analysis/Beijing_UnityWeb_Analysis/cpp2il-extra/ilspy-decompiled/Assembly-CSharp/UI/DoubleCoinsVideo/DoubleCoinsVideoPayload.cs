using System;
using Cpp2ILInjected;

namespace UI.DoubleCoinsVideo;

public class DoubleCoinsVideoPayload
{
	public int coinAmount;

	public Action onWatchVideo;

	public DoubleCoinsVideoPayload()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
