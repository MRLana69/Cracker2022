using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Utilities;

public class MTRandomGen : IMTRandomGen, IRandomGen
{
	private Action<int> m_OnRandomIncrementChanged;

	private const int N = 624;

	private const int M = 397;

	private const uint UPPER_MASK = 2147483648u;

	private const uint LOWER_MASK = 2147483647u;

	private static readonly uint[] MAG01;

	private uint[] _mt;

	private int _mti;

	private uint _initialSeed;

	private int _randomIncrement;

	public uint Seed => (uint)UnityEngine.Random.RandomRangeInt(int.MinValue, int.MaxValue);

	public int SeedIncrement => (int)_initialSeed;

	public event Action<int> OnRandomIncrementChanged
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRandomIncrementChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public MTRandomGen(uint seed, int increment)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		object obj = this + 8;
		obj = seed;
		object obj2 = this + 12;
		obj2 = increment;
	}

	private void Twist()
	{
	}

	public uint NextUint()
	{
		return (uint)_randomIncrement;
	}
}
