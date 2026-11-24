using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Analytics;

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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.MTRandomGen)+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void Twist()
	{
	}

	public uint NextUint()
	{
		return (uint)_randomIncrement;
	}

	static MTRandomGen()
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I4
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0038: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0085: Expected Obj, but got I4
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num2 = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+5C]");
		object obj3 = (nint)0 + (nint)12;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = 0;
		nint num4 = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v28 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+5C]");
		object obj6 = (nint)0 + (nint)16;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj8 = default;
		object obj7 = obj8 + 16;
		obj7 = 0;
		nint num6 = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v41 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+5C]");
		object obj9 = (nint)0 + (nint)20;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		object obj11 = default;
		object obj10 = obj11 + 16;
		obj10 = 0;
		nint num8 = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v54 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+5C]");
		object obj12 = (nint)0 + (nint)24;
		obj12 = obj11;
	}
}
