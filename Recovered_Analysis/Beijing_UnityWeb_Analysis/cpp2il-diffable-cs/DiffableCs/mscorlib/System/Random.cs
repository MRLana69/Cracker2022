namespace System;

public class Random
{
	private const int MBIG = 2147483647; //Field offset: 0x0
	private const int MSEED = 161803398; //Field offset: 0x0
	private const int MZ = 0; //Field offset: 0x0
	private int inext; //Field offset: 0x8
	private int inextp; //Field offset: 0xC
	private int[] SeedArray; //Field offset: 0x10

	public Random() { }

	public Random(int Seed) { }

	private double GetSampleForLargeRange() { }

	private int InternalSample() { }

	public virtual int Next(int minValue, int maxValue) { }

	public virtual int Next(int maxValue) { }

	public virtual double NextDouble() { }

	protected virtual double Sample() { }

}

