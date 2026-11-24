using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

[Serializable]
public class TargetWeightPair
{
	private GameObject _target;

	private float _weight;

	public GameObject Target
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TargetWeightPair)+4C]");
			return (GameObject)0;
		}
	}

	public float Weight
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TargetWeightPair)+18]");
			return 0f;
		}
	}

	public TargetWeightPair()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
