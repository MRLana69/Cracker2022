public struct IntMask
{
	public int mask;

	// C# has no syntax for parameterized property 'Item'.
	public bool get_Item(int bit)
	{
		int num = mask >> bit;
		return (byte)(num & 1) != 0;
	}

	public void set_Item(int bit, bool value)
	{
		//IL_0039: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		int num = 1 << bit;
		int num2 = mask | num;
		int num3 = -2 << bit;
		object obj = 32 - bit;
		object obj2 = -2 >> (int)obj;
		int num4 = num3 | obj2;
		int num5 = mask & num4;
		if (!value)
		{
			num2 = num5;
		}
		mask = num2;
	}

	public IntMask(int i)
	{
		mask = i;
	}

	public static implicit operator int(IntMask i)
	{
		//IL_0005: Expected I4, but got VT
		return (int)i;
	}

	public static implicit operator IntMask(int i)
	{
		//IL_0005: Expected VT, but got I4
		return (IntMask)i;
	}
}
