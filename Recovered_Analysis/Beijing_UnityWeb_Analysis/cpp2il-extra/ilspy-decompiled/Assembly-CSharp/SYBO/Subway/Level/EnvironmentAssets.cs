using System;
using Cpp2ILInjected;

namespace SYBO.Subway.Level;

[Serializable]
public class EnvironmentAssets
{
	public EnvironmentSequentialSegments station;

	public EnvironmentSequentialSegments tube;

	public EnvironmentSequentialSegments pillars;

	public EnvironmentAssets()
	{
		//IL_0011: Expected VT, but got I4
		_ = 1;
		tube = (EnvironmentSequentialSegments)2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
