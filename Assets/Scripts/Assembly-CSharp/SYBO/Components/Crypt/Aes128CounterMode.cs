using System;
using System.Security.Cryptography;
using Cpp2ILInjected;

namespace SYBO.Components.Crypt;

public class Aes128CounterMode : SymmetricAlgorithm
{
	private readonly byte[] _counter;

	private readonly AesManaged _aes;

	public override byte[] Key
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			AesManaged aes = _aes;
			nint num = (nint)aes;
			object obj = aes + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.Security.Cryptography.AesManaged>)+114] (should have been resolved before IL gen)");
			byte[] result = default;
			return result;
		}
		set
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			AesManaged aes = _aes;
			nint num = (nint)aes;
			object obj = aes + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S2_v2 (Il2CppClass<System.Security.Cryptography.AesManaged>)+11C] (should have been resolved before IL gen)");
		}
	}

	public Aes128CounterMode(byte[] counter)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_013b: Expected I4, but got I8
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_004b: Expected I, but got Obj
		//IL_005d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		ModeValue = CipherMode.CBC;
		if (counter != null)
		{
			if (counter.Length == 16)
			{
				AesManaged aesManaged = default;
				aesManaged._002Ector();
				nint num = (nint)aesManaged;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S2_v8 (Il2CppClass<System.Security.Cryptography.AesManaged>)+144] (should have been resolved before IL gen)");
				nint num2 = (nint)aesManaged;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S2_v11 (Il2CppClass<System.Security.Cryptography.AesManaged>)+154] (should have been resolved before IL gen)");
				_aes = aesManaged;
				_counter = counter;
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentNullException ex = default;
			ex._002Ector("counter");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		_ = counter.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		string message = $"Counter size must be same as block size (actual: {arg}, expected: {arg2})";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ArgumentException ex2 = default;
		ex2._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] ignoredParameter)
	{
		CounterModeCryptoTransform counterModeCryptoTransform = default;
		counterModeCryptoTransform._002Ector(_aes, rgbKey, _counter);
		return counterModeCryptoTransform;
	}

	public ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] ignoredParameter, int position)
	{
		//IL_0030: Expected I8, but got I4
		CounterModeCryptoTransform counterModeCryptoTransform = default;
		counterModeCryptoTransform._002Ector(_aes, rgbKey, _counter);
		counterModeCryptoTransform.Seek(position);
		return counterModeCryptoTransform;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] ignoredParameter)
	{
		CounterModeCryptoTransform counterModeCryptoTransform = default;
		counterModeCryptoTransform._002Ector(_aes, rgbKey, _counter);
		return counterModeCryptoTransform;
	}

	public override void GenerateKey()
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		AesManaged aes = _aes;
		nint num = (nint)aes;
		object obj = aes + 192;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.Security.Cryptography.AesManaged>)+17C] (should have been resolved before IL gen)");
	}

	public override void GenerateIV()
	{
	}
}
