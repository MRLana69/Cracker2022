using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Components.ComponentsManager;
using SYBO.Components.Logging;
using UnityEngine;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
	}

	public override bool CanSeek
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool result = default;
			return result;
		}
	}

	public override bool CanWrite => false;

	public override long Length
	{
		get
		{
			//IL_0045: Expected I8, but got Obj
			//IL_0029: Expected I8, but got Obj
			if (_stream != null)
			{
				return (long)base._asyncActiveSemaphore;
			}
			AesManaged aes = _aes;
			return (long)((SymmetricAlgorithm)aes).LegalBlockSizesValue;
		}
	}

	public override long Position
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected I8, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
			object obj = default;
			return obj - 32;
		}
		set
		{
			long num = default;
			while (true)
			{
				num--;
				if (num >= 1)
				{
					if (((CounterModeCryptoTransform)(object)this).InputBlockSize != 0)
					{
						((CounterModeCryptoTransform)(object)this).IncrementCounter();
					}
					byte b = ((Queue<byte>)(object)base._asyncActiveSemaphore).Dequeue();
					continue;
				}
				break;
			}
		}
	}

	~EncryptedCTRStream()
	{
	}

	public static EncryptedCTRStream WriteStream(Stream stream)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		EncryptedCTRStream result = default;
		return result;
	}

	public static EncryptedCTRStream ReadStream(Stream stream)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ComponentsManagerSettings componentsManagerSettings = default;
		componentsManagerSettings._002Ector();
		((EncryptedCTRStream)(object)componentsManagerSettings).SetupRead(stream);
		return (EncryptedCTRStream)(object)componentsManagerSettings;
	}

	private void SetupWrite(Stream stream)
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((MarshalByRefObject)this)._identity = stream;
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		nint num4 = (nint)typeof(Log);
		if (!flag)
		{
			nint num5 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(Log);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(Log);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L1_v2 (Il2CppClass<SYBO.Components.Logging.Log>)+5C]");
		object obj3 = (nint)0 + (nint)16;
		obj3 = this;
		object obj4 = this + 12;
		obj4 = "Crypt";
	}

	private unsafe void SetupRead(Stream stream)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_00d4: Expected I4, but got Obj
		//IL_00d4: Expected I4, but got Obj
		//IL_0032: Expected I4, but got Obj
		//IL_0032: Expected Ref, but got VT
		//IL_0117: Expected I4, but got Obj
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		object obj = this + 32;
		obj = stream;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		object obj2 = default;
		if ((nint)obj2 < 32)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Array.SorterObjectArray sorterObjectArray = default;
			((Array.SorterObjectArray*)sorterObjectArray)->SwapIfGreaterWithItems((int)_counter, 16);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Array sourceArray = default;
			Array.ConstrainedCopy(sourceArray, 16, _key, 0, 16);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @770A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EncryptedCTRStream encryptedCTRStream = default;
		encryptedCTRStream.Write((byte[])(object)_aes, (int)_key, (int)_counter);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		long position = default;
		encryptedCTRStream.Position = position;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CryptoStream cryptoStream = default;
		cryptoStream.Write((byte[])(object)_stream, (int)encryptedCTRStream, 1);
		object obj3 = this + 36;
		obj3 = cryptoStream;
	}

	public new void Dispose()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = obj2;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		object obj3 = obj + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj + obj5;
		obj6 = 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj + obj7;
			if ((nint)obj8 == 15)
			{
				object obj9 = obj + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				return;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public override void Flush()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_005f: Expected I, but got Obj
		//IL_0075: Expected Obj, but got I
		//IL_00a0: Expected I, but got Obj
		if (_stream == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E4D3");
		_cryptoStream.InitializeBuffer();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E4D3");
		object obj = this + 36;
		obj = 0;
		object obj2 = this + 32;
		obj2 = 0;
		nint num = (nint)typeof(GC);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppClass<System.GC>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(GC);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23 (Il2CppClass<System.GC>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GC._ReRegisterForFinalize((object)this);
	}

	public unsafe override int Read(byte[] buffer, int offset, int count)
	{
		//IL_004a: Expected VT, but got Obj
		//IL_0071: Expected I4, but got VT
		//IL_002a: Expected VT, but got I4
		//IL_002a: Expected VT, but got I4
		//IL_002a: Expected VT, but got I4
		Vector3 vector2;
		if (count != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Vector3 vector = default;
			bool flag = Math3D.PlanePlaneIntersection(out *(Vector3*)this, out *(Vector3*)buffer, (Vector3)offset, (Vector3)count, vector, (Vector3)0);
			vector2 = vector;
		}
		else
		{
			vector2 = (Vector3)_aes;
		}
		return (int)vector2;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		//IL_000b: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return 0L;
	}

	public override void SetLength(long value)
	{
		//IL_0027: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		((EncryptedCTRStream)(object)ex).Position = 0L;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0295: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0xFFF;
		object obj7 = obj6 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S2_v4 (should have been resolved before IL gen)");
		object obj8 = default;
		obj = obj8;
		object obj9 = this + 16;
		obj9 = obj2;
		object obj10 = this + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj11 = default;
		obj10 = obj11;
		if (buffer == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex = default;
			ex._002Ector("symmetricAlgorithm");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (offset == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex2 = default;
			ex2._002Ector("key");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (count == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex3 = default;
			ex3._002Ector("counter");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		object obj13 = default;
		object obj12 = obj13 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj15 = default;
		object obj14 = obj15 / 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [count @ L3 (System.Int32)+C]");
		if (0 == (nint)obj14)
		{
			object obj16 = this + 20;
			obj16 = buffer;
			object obj17 = this + 8;
			obj17 = count;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj18 = this + 12;
			object obj20 = default;
			object obj19 = obj20 / 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
			object obj21 = default;
			obj18 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj22 = this + 24;
			object obj24 = default;
			object obj23 = obj24 / 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj25 = default;
			obj22 = obj25;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [count @ L3 (System.Int32)+C]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj27 = default;
			object obj26 = obj27 / 8;
			obj13 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			string paramName = string.Format((IFormatProvider)(object)"Counter size must be same as block size (actual: {0}, expected: {1})", format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentNullException ex4 = default;
			ex4._002Ector(paramName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public EncryptedCTRStream()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}
}
