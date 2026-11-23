using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Cpp2ILInjected;

namespace SYBO.Components.Crypt;

public class CounterModeCryptoTransform : ICryptoTransform, IDisposable
{
	private readonly byte[] _counter;

	private readonly ICryptoTransform _counterEncryptor;

	private readonly Queue<byte> _xorMask;

	private readonly SymmetricAlgorithm _symmetricAlgorithm;

	private byte[] _counterModeBlock;

	private readonly byte[] _empty;

	public int InputBlockSize => 1;

	public int OutputBlockSize => 1;

	public bool CanTransformMultipleBlocks => true;

	public bool CanReuseTransform => false;

	public CounterModeCryptoTransform(SymmetricAlgorithm symmetricAlgorithm, byte[] key, byte[] counter)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0055: Expected I, but got Obj
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01f9: Expected I, but got Obj
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_00b4: Expected I, but got Obj
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00de: Expected I, but got Obj
		//IL_0104: Expected I, but got Obj
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Queue`1<System.Byte>>>)+4] (should have been resolved before IL gen)");
		Queue<byte> xorMask = default;
		_xorMask = xorMask;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] empty = default;
		_empty = empty;
		if (symmetricAlgorithm != null)
		{
			if (key != null)
			{
				if (counter != null)
				{
					nint num3 = (nint)symmetricAlgorithm;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S1_v23 (Il2CppClass<System.Security.Cryptography.SymmetricAlgorithm>)+EC] (should have been resolved before IL gen)");
					object obj4 = default;
					object obj3 = obj4 / 8;
					if (counter.Length == (nint)obj3)
					{
						_symmetricAlgorithm = symmetricAlgorithm;
						_counter = counter;
						nint num4 = (nint)_symmetricAlgorithm;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ S1_v42 (Il2CppClass<System.Security.Cryptography.SymmetricAlgorithm>)+EC] (should have been resolved before IL gen)");
						object obj6 = default;
						object obj5 = obj6 / 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						nint num5 = (nint)symmetricAlgorithm;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S4_v4 (Il2CppClass<System.Security.Cryptography.SymmetricAlgorithm>)+164] (should have been resolved before IL gen)");
						ICryptoTransform counterEncryptor = default;
						_counterEncryptor = counterEncryptor;
						nint num6 = (nint)_symmetricAlgorithm;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S1_v47 (Il2CppClass<System.Security.Cryptography.SymmetricAlgorithm>)+EC] (should have been resolved before IL gen)");
						object obj8 = default;
						object obj7 = obj8 / 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						byte[] counterModeBlock = default;
						_counterModeBlock = counterModeBlock;
						return;
					}
					_ = counter.Length;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					object obj9 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					nint num7 = (nint)symmetricAlgorithm;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ S2_v16 (Il2CppClass<System.Security.Cryptography.SymmetricAlgorithm>)+EC] (should have been resolved before IL gen)");
					object obj11 = default;
					object obj10 = obj11 / 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					object obj12 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object arg = default;
					object arg2 = default;
					string text = $"Counter size must be same as block size (actual: {arg}, expected: {arg2})";
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					ArgumentException ex = default;
					ex._002Ector(text);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
					ArgumentNullException ex2 = (ArgumentNullException)(object)text;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					ArgumentNullException ex3 = default;
					ex3._002Ector("counter");
					ArgumentNullException ex2 = ex3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ArgumentNullException ex4 = default;
				ex4._002Ector("key");
				ArgumentNullException ex2 = ex4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentNullException ex5 = default;
			ex5._002Ector("symmetricAlgorithm");
			ArgumentNullException ex2 = ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		if (inputCount == 0)
		{
			return _empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] array = default;
		int num = TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
		return array;
	}

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		//IL_00b9: Expected Obj, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		object obj = 0;
		while (inputCount > (nint)obj)
		{
			if (NeedMoreXorMaskBytes())
			{
				EncryptCounterThenIncrement();
			}
			object obj2 = outputOffset + obj;
			object obj3 = obj2 + (object)outputBuffer;
			byte b = _xorMask.Dequeue();
			object obj4 = inputOffset + obj;
			object obj5 = obj4 + (object)inputBuffer;
			byte b2 = b;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S2_v6+10]");
			int num = (int)((nint)(int)b2 ^ (nint)0);
			object obj6 = obj + 1;
			obj = obj6;
		}
		return inputCount;
	}

	private bool NeedMoreXorMaskBytes()
	{
		Queue<byte> xorMask = _xorMask;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (System.Collections.Generic.Queue`1<System.Byte>)+14]");
		return (nint)0 == 0;
	}

	private void EncryptCounterThenIncrement()
	{
		//IL_0072: Expected Obj, but got I4
		//IL_0029: Expected VT, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		byte[] counter = _counter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE6");
		IncrementCounter();
		byte[] counterModeBlock = _counterModeBlock;
		object obj = 0;
		while (counterModeBlock.Length > (nint)obj)
		{
			object obj2 = obj + (object)counterModeBlock;
			Queue<byte> xorMask = _xorMask;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v8+10]");
			((Queue<T>)(object)xorMask).Enqueue((T)0);
			object obj3 = obj + 1;
			obj = obj3;
		}
	}

	private void IncrementCounter()
	{
		//IL_0014: Expected Obj, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		byte[] counter = _counter;
		object obj = counter.Length;
		bool flag;
		do
		{
			object obj2 = obj - 1;
			if ((nint)obj2 >= 0)
			{
				object obj3 = obj2 + (object)_counter;
				object obj4 = obj3 + 16;
				object obj5 = obj4 + 1;
				obj4 = obj5;
				object obj6 = obj5 & 0xFF;
				flag = obj6 == null;
				obj = obj2;
				continue;
			}
			break;
		}
		while (flag);
	}

	public void Seek(long distance)
	{
		long num = default;
		while (true)
		{
			bool flag = num < 1;
			num--;
			if (!flag)
			{
				if (NeedMoreXorMaskBytes())
				{
					EncryptCounterThenIncrement();
				}
				byte b = _xorMask.Dequeue();
				continue;
			}
			break;
		}
	}

	public void Dispose()
	{
	}
}
