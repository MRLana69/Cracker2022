using System;

namespace SYBO.Components.Analytics;

public class UnsyncedMTRandomGen : IMTRandomGen, IRandomGen
{
	private MTRandomGen _gen;

	public uint Seed
	{
		get
		{
			MTRandomGen gen = _gen;
			return gen._initialSeed;
		}
	}

	public int SeedIncrement
	{
		get
		{
			MTRandomGen gen = _gen;
			return gen._randomIncrement;
		}
	}

	public uint NextUint()
	{
		object[] array = Array.Empty<object>();
		return _gen.NextUint();
	}

	public UnsyncedMTRandomGen()
	{
		MTRandomGen mTRandomGen = default;
		mTRandomGen._002Ector(666u, 0);
		_gen = mTRandomGen;
	}
}
