using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Ionic.Crc;
using SYBO.Components.Json;
using SYBO.Components.Json.Internal;

namespace SYBO.Components.Crypt;

public class CounterModeCryptoTransform : ICryptoTransform, IDisposable
{
	private readonly byte[] _counter;

	private readonly ICryptoTransform _counterEncryptor;

	private readonly Queue<byte> _xorMask;

	private readonly SymmetricAlgorithm _symmetricAlgorithm;

	private byte[] _counterModeBlock;

	private readonly byte[] _empty;

	public int InputBlockSize
	{
		get
		{
			Queue<byte> xorMask = _xorMask;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (System.Collections.Generic.Queue`1<System.Byte>)+14]");
			return ((nint)0 == 0) ? 1 : 0;
		}
	}

	public int OutputBlockSize => 1;

	public bool CanTransformMultipleBlocks => true;

	public bool CanReuseTransform => true;

	public CounterModeCryptoTransform(SymmetricAlgorithm symmetricAlgorithm, byte[] key, byte[] counter)
	{
		//IL_0032: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string key2 = default;
		object value = JsonReflectionParser.DictionaryResolveKey(key2, (Type)(object)key, (JsonContext)(object)counter);
		((FieldInfo)(object)symmetricAlgorithm).SetValueDirect((TypedReference)this, value);
	}

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		//IL_0039: Expected I4, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_0046: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Crypt.CounterModeCryptoTransform)+30]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Crypt.CounterModeCryptoTransform)+2C]");
		EncryptedCTRStream encryptedCTRStream = default;
		encryptedCTRStream.Write((byte[])num, (int)inputBuffer, 0);
		encryptedCTRStream.Position = inputCount;
		return (byte[])(object)encryptedCTRStream;
	}

	public unsafe int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = inputBuffer;
		object obj2 = num + 20;
		obj2 = inputOffset;
		object obj3 = ((int*)inputCount)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [inputCount @ L3 (System.Int32)+8]");
		_ = 0;
		object obj4 = num + 24;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj3 = outputBuffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [outputBuffer @ L4 (System.Byte[])+8]");
		_ = 0;
		object obj5 = num + 36;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj3 = ((int*)outputOffset)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [outputOffset @ L5 (System.Int32)+8]");
		_ = 0;
		object obj6 = num + 48;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return num;
	}

	private bool NeedMoreXorMaskBytes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	private void EncryptCounterThenIncrement()
	{
	}

	private void IncrementCounter()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0031: Expected VT, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		byte[] counter = _counter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @900E");
		Dispose();
		object obj = _counterModeBlock + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _counterModeBlock + 16;
			object obj4 = obj3 + obj2;
			((Variable<>)(object)_xorMask).Value = (T)obj4;
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
	}

	public void Seek(long distance)
	{
		//IL_0027: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		((CrcCalculatorStream)(object)ex).SetLength(0L);
	}

	public void Dispose()
	{
		//IL_0014: Expected Obj, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		byte[] counter = _counter;
		object obj = counter.Length;
		bool flag;
		do
		{
			object obj2 = obj - 1;
			if ((nint)obj2 >= 0)
			{
				object obj3 = _counter + 16;
				object obj4 = obj3 + obj2;
				object obj5 = obj4 + 1;
				object obj6 = obj5 & 0xFF;
				obj4 = obj6;
				flag = obj6 == null;
				obj = obj2;
				continue;
			}
			break;
		}
		while (flag);
	}
}
