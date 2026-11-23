using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace SYBO.Common.Utilities;

public class SyboRandom
{
	private IRandomGen _randomGen;

	public SyboRandom()
	{
		IRandomGen randomGen = MakeRandomGen();
		_randomGen = randomGen;
	}

	public SyboRandom(IRandomGen randomGen)
	{
		_randomGen = randomGen;
	}

	public unsafe static IRandomGen MakeRandomGen()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected VT, but got Unknown
		//IL_0085: Expected Ref, but got VT
		//IL_0037: Expected Obj, but got I8
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime now = DateTime.Now;
		DateTime dateTime = (DateTime)(obj + 8);
		long ticks = ((DateTime*)dateTime)->Ticks;
		long num = ticks / 4294967295L;
		object obj3 = num * 4294967295L;
		uint seed = (uint)(int)(ticks - obj3);
		MTRandomGen mTRandomGen = default;
		mTRandomGen._002Ector(seed, 0);
		return mTRandomGen;
	}

	public void SetGenerator(IRandomGen randomGen)
	{
		_randomGen = randomGen;
	}

	public uint NextUint()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		uint result = default;
		return result;
	}

	public float NextFloat()
	{
		uint num = NextUint();
		return (float)(int)num * 2.3283064E-10f;
	}

	public float Value()
	{
		return NextFloat();
	}

	public bool Bool()
	{
		float num = NextFloat();
		return num > 0.5f;
	}

	public int Range(int min, int max)
	{
		//IL_0034: Expected Obj, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected I4, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected I4, but got Unknown
		if (min < max)
		{
			object obj = max - min;
			object obj2 = -1 / obj;
			object obj3 = obj2 * obj;
			object obj4 = -1 - obj3;
			object obj5 = -1 - obj4;
			uint num;
			do
			{
				num = NextUint();
			}
			while ((int)num > (nint)obj5);
			object obj6 = max - min;
			int num2 = (int)(num / obj6);
			object obj7 = num2 * obj6;
			object obj8 = num - obj7;
			return min + obj8;
		}
		return min;
	}

	public float Range(float min, float max)
	{
		if (!(min < max))
		{
			return min;
		}
		float num = NextFloat();
		float num2 = max - min;
		float num3 = num * num2;
		return num3 + min;
	}

	public T RandomElement<T>(T[] array)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_003d: Expected VT, but got I
		int num = Range(0, array.Length);
		int num2 = num << 2;
		object obj = array + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v2+10]");
		return (T)0;
	}

	public T RandomElementNoRepeats<T>(T[] array, T lastPickedElement) where T : class
	{
		//IL_0049: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I
		if (array.Length == 1)
		{
			return array[0];
		}
		object obj = array.Length << 1;
		object obj2 = 0;
		bool flag;
		do
		{
			int num = Range(0, array.Length);
			int num2 = num << 2;
			object obj3 = array + num2;
			object obj4 = obj2 + 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v9+10]");
			flag = lastPickedElement == null;
			obj2 = obj4;
		}
		while (flag);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v9+10]");
		return (T)0;
	}

	public T RandomElementNoRepeats<T>(IList<T> array, T lastPickedElement) where T : class
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		if ((nint)obj != 1)
		{
			int max = default;
			T val = default;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				int num = Range(0, max);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			}
			while (val == lastPickedElement);
			return val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		T result = default;
		return result;
	}

	public T RandomElement<T>(IList<T> array)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int max = default;
		int num = Range(0, max);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		T result = default;
		return result;
	}

	public int RandomElementIndex<T>(ICollection<T> array)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int max = default;
		return Range(0, max);
	}

	public void Shuffle<T>(IList<T> list)
	{
		//IL_006f: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int num2 = default;
		int num = num2;
		while (num > 1)
		{
			int num3 = Range(0, num);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj = num - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj2 = num - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			int num4 = num - 1;
			num = num4;
		}
	}
}
