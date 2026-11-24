using System;
using Cpp2ILInjected;
using TopRun.UI;
using UnityEngine;

namespace TopRun.Internal;

public class Rank : IRank
{
	private int rank__BackingField;

	public int rank
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Rank)+14]");
			return 0;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 20;
			obj = value;
		}
	}

	public string country
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)rank__BackingField;
		}
		private set
		{
			//IL_000a: Expected I4, but got Obj
			rank__BackingField = (int)value;
		}
	}

	public Rank(string country, int rank)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Rank)+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			TopRunNormalStateHelper topRunNormalStateHelper = default;
			topRunNormalStateHelper.InitNormalState();
			object obj = country & 1;
			int num = rank & 1;
			((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr = (IntPtr)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Rank)+30]");
			((EventHandler<TournamentChangedEventArgs>)0)(this, (TournamentChangedEventArgs)(object)topRunNormalStateHelper);
		}
	}
}
