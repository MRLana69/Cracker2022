namespace SYBO.Common.Utilities;

public interface IMTRandomGen : IRandomGen
{

	public uint Seed
	{
		 get { } //Length: 0
	}

	public int SeedIncrement
	{
		 get { } //Length: 0
	}

	public uint get_Seed() { }

	public int get_SeedIncrement() { }

}

