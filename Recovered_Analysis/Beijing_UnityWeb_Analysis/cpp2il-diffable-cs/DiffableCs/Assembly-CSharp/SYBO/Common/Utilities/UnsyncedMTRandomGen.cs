namespace SYBO.Common.Utilities;

public class UnsyncedMTRandomGen : IMTRandomGen, IRandomGen
{
	private MTRandomGen _gen; //Field offset: 0x8

	public uint Seed
	{
		 get { } //Length: 54
	}

	public int SeedIncrement
	{
		 get { } //Length: 9
	}

	public UnsyncedMTRandomGen() { }

	public uint get_Seed() { }

	public int get_SeedIncrement() { }

	public uint NextUint() { }

}

