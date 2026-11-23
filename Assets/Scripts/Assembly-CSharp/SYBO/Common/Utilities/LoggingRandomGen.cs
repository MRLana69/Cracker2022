using Cpp2ILInjected;

namespace SYBO.Common.Utilities;

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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		uint result = default;
		return result;
	}
}
