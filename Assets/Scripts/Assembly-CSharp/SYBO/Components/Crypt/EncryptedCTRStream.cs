using System;
using System.IO;
using System.Security.Cryptography;
using Cpp2ILInjected;

namespace SYBO.Components.Crypt;

public class EncryptedCTRStream : Stream, IDisposable
{
	private const int KeySize = 16;

	private const int HeaderSize = 32;

	private byte[] _counter;

	private byte[] _key;

	private AesManaged _aes;

	private Stream _stream;

	private CryptoStream _cryptoStream;

	public override bool CanRead
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			CryptoStream cryptoStream = _cryptoStream;
			nint num = (nint)cryptoStream;
			object obj = cryptoStream + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.Security.Cryptography.CryptoStream>)+F4] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	public override bool CanSeek => false;

	public override bool CanWrite
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			CryptoStream cryptoStream = _cryptoStream;
			nint num = (nint)cryptoStream;
			object obj = cryptoStream + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.Security.Cryptography.CryptoStream>)+10C] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	public override long Length
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected I8, but got Unknown
			Stream stream = _stream;
			nint num = (nint)stream;
			object obj = stream + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.IO.Stream>)+114] (should have been resolved before IL gen)");
			object obj2 = default;
			return obj2 - 32;
		}
	}

	public override long Position
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected I8, but got Unknown
			Stream stream = _stream;
			nint num = (nint)stream;
			object obj = stream + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.IO.Stream>)+11C] (should have been resolved before IL gen)");
			object obj2 = default;
			return obj2 - 32;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	~EncryptedCTRStream()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_01c9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag = (nint)0 != 1;
		object obj4 = obj;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj5 = default;
			object obj6 = default;
			bool flag2 = obj5 == obj6;
			bool flag3 = !flag2;
			object obj8 = default;
			object obj7 = obj8;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj4 = obj;
				if (flag4)
				{
					goto IL_01da;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj9 = default;
				obj7 = obj9;
			}
			_ = 0;
			object obj10 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
		}
		goto IL_01da;
		IL_01da:
		object obj11 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36E");
	}

	public static EncryptedCTRStream WriteStream(Stream stream)
	{
		EncryptedCTRStream encryptedCTRStream = default;
		encryptedCTRStream._002Ector();
		encryptedCTRStream.SetupWrite(stream);
		return encryptedCTRStream;
	}

	public static EncryptedCTRStream ReadStream(Stream stream)
	{
		EncryptedCTRStream encryptedCTRStream = default;
		encryptedCTRStream._002Ector();
		encryptedCTRStream.SetupRead(stream);
		return encryptedCTRStream;
	}

	private void SetupWrite(Stream stream)
	{
		//IL_017c: Expected I, but got Obj
		//IL_0082: Expected I, but got Obj
		//IL_009e: Expected I, but got Obj
		//IL_00ce: Expected I, but got Obj
		//IL_010d: Expected I, but got Obj
		//IL_0129: Expected I, but got Obj
		//IL_0017: Expected I, but got Obj
		//IL_0033: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_0061: Expected I, but got Obj
		//IL_01d1: Expected I, but got Obj
		_stream = stream;
		Stream stream2 = _stream;
		nint num = (nint)stream2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v4 (Il2CppClass<System.IO.Stream>)+114] (should have been resolved before IL gen)");
		object obj = default;
		if ((nint)obj >= 32)
		{
			Stream stream3 = _stream;
			nint num2 = (nint)stream3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S4_v12 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
			Stream stream4 = _stream;
			nint num3 = (nint)stream4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S4_v15 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
			Stream stream5 = _stream;
			nint num4 = (nint)stream5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S2_v24 (Il2CppClass<System.IO.Stream>)+114] (should have been resolved before IL gen)");
			nint num5 = (nint)stream5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S3_v15 (Il2CppClass<System.IO.Stream>)+1A4] (should have been resolved before IL gen)");
		}
		else
		{
			AesManaged aes = _aes;
			nint num6 = (nint)aes;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S1_v14 (Il2CppClass<System.Security.Cryptography.AesManaged>)+17C] (should have been resolved before IL gen)");
			AesManaged aes2 = _aes;
			nint num7 = (nint)aes2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S1_v17 (Il2CppClass<System.Security.Cryptography.AesManaged>)+114] (should have been resolved before IL gen)");
			Array sourceArray = default;
			Array.Copy(sourceArray, _counter, 16);
			AesManaged aes3 = _aes;
			nint num8 = (nint)aes3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ S1_v22 (Il2CppClass<System.Security.Cryptography.AesManaged>)+114] (should have been resolved before IL gen)");
			Array sourceArray2 = default;
			Array.Copy(sourceArray2, 16, _key, 0, 16);
			Stream stream6 = _stream;
			nint num9 = (nint)stream6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ S4_v6 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
			Stream stream7 = _stream;
			nint num10 = (nint)stream7;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ S4_v9 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
		}
		CounterModeCryptoTransform counterModeCryptoTransform = default;
		counterModeCryptoTransform._002Ector(_aes, _key, _counter);
		nint num11 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ S2_v6 (Il2CppClass<SYBO.Components.Crypt.EncryptedCTRStream>)+11C] (should have been resolved before IL gen)");
		long distance = default;
		counterModeCryptoTransform.Seek(distance);
		CryptoStream cryptoStream = default;
		cryptoStream._002Ector(_stream, counterModeCryptoTransform, CryptoStreamMode.Write);
		_cryptoStream = cryptoStream;
	}

	private void SetupRead(Stream stream)
	{
		//IL_0044: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		_stream = stream;
		Stream stream2 = _stream;
		nint num = (nint)stream2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S4_v2 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
		Stream stream3 = _stream;
		nint num2 = (nint)stream3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S4_v5 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
		CounterModeCryptoTransform counterModeCryptoTransform = default;
		counterModeCryptoTransform._002Ector(_aes, _key, _counter);
		CryptoStream cryptoStream = default;
		cryptoStream._002Ector(_stream, counterModeCryptoTransform, CryptoStreamMode.Read);
		_cryptoStream = cryptoStream;
	}

	public new void Dispose()
	{
		//IL_000a: Expected I, but got Obj
		//IL_0026: Expected I, but got Obj
		//IL_0042: Expected I, but got Obj
		if (_stream != null)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v4 (Il2CppClass<SYBO.Components.Crypt.EncryptedCTRStream>)+14C] (should have been resolved before IL gen)");
			CryptoStream cryptoStream = _cryptoStream;
			nint num2 = (nint)cryptoStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v7 (Il2CppClass<System.Security.Cryptography.CryptoStream>)+14C] (should have been resolved before IL gen)");
			Stream stream = _stream;
			nint num3 = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S1_v10 (Il2CppClass<System.IO.Stream>)+14C] (should have been resolved before IL gen)");
			_cryptoStream = null;
			_stream = null;
			GC.SuppressFinalize(this);
		}
	}

	public override void Flush()
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_003c: Expected I, but got Obj
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		CryptoStream cryptoStream = _cryptoStream;
		nint num = (nint)cryptoStream;
		object obj = cryptoStream + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.Security.Cryptography.CryptoStream>)+15C] (should have been resolved before IL gen)");
		Stream stream = _stream;
		nint num2 = (nint)stream;
		object obj2 = stream + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v6 (Il2CppClass<System.IO.Stream>)+15C] (should have been resolved before IL gen)");
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		CryptoStream cryptoStream = _cryptoStream;
		nint num = (nint)cryptoStream;
		object obj = cryptoStream + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S4_v2 (Il2CppClass<System.Security.Cryptography.CryptoStream>)+1B4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		//IL_0037: Expected I8, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (long)ex;
	}

	public override void SetLength(long value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		CryptoStream cryptoStream = _cryptoStream;
		nint num = (nint)cryptoStream;
		object obj = cryptoStream + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S4_v2 (Il2CppClass<System.Security.Cryptography.CryptoStream>)+1CC] (should have been resolved before IL gen)");
	}

	public EncryptedCTRStream()
	{
		//IL_0016: Expected I, but got Obj
		//IL_0028: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] counter = default;
		_counter = counter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] key = default;
		_key = key;
		AesManaged aesManaged = default;
		aesManaged._002Ector();
		nint num = (nint)aesManaged;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S2_v4 (Il2CppClass<System.Security.Cryptography.AesManaged>)+144] (should have been resolved before IL gen)");
		nint num2 = (nint)aesManaged;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S2_v7 (Il2CppClass<System.Security.Cryptography.AesManaged>)+154] (should have been resolved before IL gen)");
		_aes = aesManaged;
	}
}
