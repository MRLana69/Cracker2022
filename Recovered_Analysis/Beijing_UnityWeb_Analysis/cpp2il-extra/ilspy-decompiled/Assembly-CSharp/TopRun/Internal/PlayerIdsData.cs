using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace TopRun.Internal;

public class PlayerIdsData
{
	public class PlayerIdData
	{
		public string publicKey;

		public string name;

		public DateTime? expiry;

		public PlayerIdData()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public Dictionary<string, PlayerIdData> players;
}
