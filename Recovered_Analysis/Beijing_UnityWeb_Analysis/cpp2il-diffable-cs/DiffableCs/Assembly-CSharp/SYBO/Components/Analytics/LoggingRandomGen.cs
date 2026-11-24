namespace SYBO.Components.Analytics;

public class LoggingRandomGen : IMTRandomGen, IRandomGen
{
	private IMTRandomGen _gen; //Field offset: 0x8

	public uint Seed
	{
		 get { } //Length: 185
	}

	public int SeedIncrement
	{
		 get { } //Length: 54
	}

	public LoggingRandomGen(IMTRandomGen gen) { }

	public uint get_Seed() { }

	public int get_SeedIncrement() { }

	public uint NextUint() { }

}

