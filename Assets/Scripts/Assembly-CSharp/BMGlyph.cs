using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
public class BMGlyph
{
	public int index;

	public int x;

	public int y;

	public int width;

	public int height;

	public int offsetX;

	public int offsetY;

	public int advance;

	public int channel;

	public List<int> kerning;

	public int GetKerning(int previousChar)
	{
		List<int> list = kerning;
		if (kerning != null && previousChar != 0)
		{
			int num = 0;
			while (true)
			{
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Collections.Generic.List`1<System.Int32>)+C]");
				if ((nint)num2 >= (nint)0)
				{
					break;
				}
				int num3 = kerning.get_Item(num);
				if (num3 == previousChar)
				{
					int num4 = num + 1;
					return kerning.get_Item(num4);
				}
				int num5 = num + 2;
				num = num5;
			}
		}
		return 0;
	}

	public void SetKerning(int previousChar, int amount)
	{
		if (kerning == null)
		{
			List<int> list = default;
			list._002Ector();
			kerning = list;
		}
		int num = 0;
		while (true)
		{
			List<int> list2 = kerning;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v16 (System.Collections.Generic.List`1<System.Int32>)+C]");
			if ((nint)0 <= (nint)num)
			{
				break;
			}
			int num2 = kerning.get_Item(num);
			if (num2 == previousChar)
			{
				int num3 = num + 1;
				kerning.set_Item(num3, amount);
				return;
			}
			int num4 = num + 2;
			num = num4;
		}
		kerning.Add(previousChar);
		kerning.Add(amount);
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
		//IL_0011: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected I4, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected I4, but got Unknown
		//IL_00b9: Expected Obj, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected I4, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected I4, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected I4, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected I4, but got Unknown
		object obj = x + width;
		object obj2 = y + height;
		if (xMin > x)
		{
			object obj3 = xMin - x;
			int num = obj3 + x;
			x = num;
			int num2 = width - obj3;
			width = num2;
			int num3 = obj3 + offsetX;
			offsetX = num3;
		}
		if (yMin > y)
		{
			object obj4 = yMin - y;
			int num4 = obj4 + y;
			y = num4;
			int num5 = height - obj4;
			height = num5;
			int num6 = obj4 + offsetY;
			offsetY = num6;
		}
		if (xMax < (nint)obj)
		{
			object obj5 = obj - xMax;
			int num7 = width - obj5;
			width = num7;
		}
		if (yMax < (nint)obj2)
		{
			object obj6 = obj2 - yMax;
			int num8 = height - obj6;
			height = num8;
		}
	}
}
