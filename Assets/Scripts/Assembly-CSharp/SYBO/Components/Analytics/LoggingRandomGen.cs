using System;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics;

public class LoggingRandomGen : IMTRandomGen, IRandomGen
{
	private IMTRandomGen _gen;

	public uint Seed
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			uint result = default;
			return result;
		}
	}

	public int SeedIncrement
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
	}

	public LoggingRandomGen(IMTRandomGen gen)
	{
		_gen = gen;
	}

	public uint NextUint()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}
}
