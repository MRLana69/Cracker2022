using System;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics;

public class MTRandomGen : IMTRandomGen, IRandomGen
{
	private const int N = 624;

	private const int M = 397;

	private const uint UPPER_MASK = 2147483648u;

	private const uint LOWER_MASK = 2147483647u;

	private static readonly uint[] MAG01;

	private uint[] _mt;

	private int _mti;

	private uint _initialSeed;

	private int _randomIncrement;

	private Action<int> m_OnRandomIncrementChanged;

	public uint Seed => _initialSeed;

	public int SeedIncrement => _randomIncrement;

	public event Action<int> OnRandomIncrementChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_OnRandomIncrementChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_OnRandomIncrementChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public MTRandomGen(uint seed, int increment)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		uint num = seed;
		if (seed == 0)
		{
			num = 1337u;
		}
		_initialSeed = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		uint[] mt = default;
		_mt = mt;
		uint[] mt2 = _mt;
		mt2[0] = num;
		int num2 = 1;
		while (true)
		{
			_mti = num2;
			if (num2 >= 624)
			{
				break;
			}
			int num3 = num2 << 2;
			object obj = _mt + num3;
			object obj2 = num2 - 1;
			object obj3 = obj2 << 2;
			object obj4 = (object)_mt + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v21+10]");
			object obj5 = (nint)0 * (nint)69069;
			int num4 = _mti + 1;
			num2 = num4;
		}
		Twist();
		int num5 = increment;
		while (num5 > 623)
		{
			Twist();
			int num6 = num5 - 624;
			num5 = num6;
		}
		_randomIncrement = increment;
		_mti = num5;
	}

	private void Twist()
	{
		//IL_0362: Expected Obj, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_030e: Expected Obj, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected I4, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		object obj = 0;
		while ((nint)obj < 227)
		{
			object obj2 = obj << 2;
			object obj3 = (object)_mt + obj2;
			object obj4 = obj + 1;
			object obj5 = obj4 << 2;
			object obj6 = (object)_mt + obj5;
			object obj7 = obj + 397;
			object obj8 = obj7 << 2;
			object obj9 = (object)_mt + obj8;
			object obj10 = obj << 2;
			object obj11 = (object)_mt + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v47+10]");
			object obj12 = (nint)0 & (nint)1;
			object obj13 = obj12 << 2;
			object obj14 = (object)MAG01 + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v47+10]");
			object obj15 = (nint)0 & (nint)0x7FFFFFFE;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v43+10]");
			object obj16 = (nint)0 & (nint)int.MinValue;
			object obj17 = obj15 | obj16;
			object obj18 = obj17 >> 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v51+10]");
			object obj19 = 0 ^ obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v47+10]");
			object obj20 = 0 ^ obj19;
			object obj21 = obj + 1;
			obj = obj21;
		}
		uint[] mt;
		while (true)
		{
			object obj22 = obj << 2;
			object obj23 = (object)_mt + obj22;
			mt = _mt;
			if ((nint)obj >= 623)
			{
				break;
			}
			object obj24 = obj + 1;
			object obj25 = obj24 << 2;
			object obj26 = (object)mt + obj25;
			object obj27 = obj - 227;
			object obj28 = obj27 << 2;
			object obj29 = (object)_mt + obj28;
			object obj30 = obj << 2;
			object obj31 = (object)_mt + obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v29+10]");
			object obj32 = (nint)0 & (nint)1;
			object obj33 = obj32 << 2;
			object obj34 = (object)MAG01 + obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v29+10]");
			object obj35 = (nint)0 & (nint)0x7FFFFFFE;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v12+10]");
			object obj36 = (nint)0 & (nint)int.MinValue;
			object obj37 = obj35 | obj36;
			object obj38 = obj37 >> 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v33+10]");
			object obj39 = 0 ^ obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v29+10]");
			object obj40 = 0 ^ obj39;
			object obj41 = obj + 1;
			obj = obj41;
		}
		object obj42 = _mt + 1584;
		object obj43 = _mt + 2492;
		int num = (int)(mt[0] & 1);
		int num2 = num << 2;
		object obj44 = MAG01 + num2;
		int num3 = (int)(mt[0] & 0x7FFFFFFE);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v12+10]");
		object obj45 = (nint)0 & (nint)int.MinValue;
		int num4 = num3 | obj45;
		int num5 = num4 >> 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v22+10]");
		int num6 = (int)((nint)0 ^ (nint)num5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v14+10]");
		int num7 = (int)((nint)0 ^ (nint)num6);
	}

	public uint NextUint()
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0175: Expected I4, but got Obj
		bool flag = _mti >= 624;
		bool flag2 = !flag;
		int num = _mti;
		if (!flag2)
		{
			Twist();
			_mti = 0;
			num = 0;
		}
		int mti = num + 1;
		_mti = mti;
		int num2 = num << 2;
		object obj = _mt + num2;
		int randomIncrement = _randomIncrement + 1;
		_randomIncrement = randomIncrement;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v9+10]");
		object obj2 = (nint)0 >> 11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v9+10]");
		object obj3 = 0 ^ obj2;
		object obj4 = obj3 << 7;
		object obj5 = obj4 & -1658038656;
		object obj6 = obj5 ^ obj3;
		object obj7 = obj6 << 15;
		object obj8 = obj7 & -272236544;
		object obj9 = obj8 ^ obj6;
		Action<int> onRandomIncrementChanged = this.m_OnRandomIncrementChanged;
		if (this.m_OnRandomIncrementChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S0_v21 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
		}
		object obj10 = obj9 >> 18;
		return (uint)(obj10 ^ obj9);
	}

	static MTRandomGen()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		uint[] array = default;
		array[1] = 2567483615u;
		MAG01 = array;
	}
}
