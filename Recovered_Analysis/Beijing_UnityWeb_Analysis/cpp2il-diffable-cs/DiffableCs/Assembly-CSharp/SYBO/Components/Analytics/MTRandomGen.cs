namespace SYBO.Components.Analytics;

public class MTRandomGen : IMTRandomGen, IRandomGen
{
	private const int N = 624; //Field offset: 0x0
	private const int M = 397; //Field offset: 0x0
	private const uint UPPER_MASK = 2147483648; //Field offset: 0x0
	private const uint LOWER_MASK = 2147483647; //Field offset: 0x0
	private static readonly uint[] MAG01; //Field offset: 0x0
	private Action<int> OnRandomIncrementChanged; //Field offset: 0x8
	private uint[] _mt; //Field offset: 0xC
	private int _mti; //Field offset: 0x10
	private uint _initialSeed; //Field offset: 0x14
	private int _randomIncrement; //Field offset: 0x18

	public event Action<int> OnRandomIncrementChanged
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	public uint Seed
	{
		 get { } //Length: 19
	}

	public int SeedIncrement
	{
		 get { } //Length: 6
	}

	private static MTRandomGen() { }

	public MTRandomGen(uint seed, int increment) { }

	public void add_OnRandomIncrementChanged(Action<int> value) { }

	public uint get_Seed() { }

	public int get_SeedIncrement() { }

	public uint NextUint() { }

	public void remove_OnRandomIncrementChanged(Action<int> value) { }

	private void Twist() { }

}

