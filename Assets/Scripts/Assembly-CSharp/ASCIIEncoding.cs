using System.Text;
using Cpp2ILInjected;

public class ASCIIEncoding : Encoding
{
	public new static readonly Encoding ASCII;

	public override int GetMaxByteCount(int charCount)
	{
		return charCount;
	}

	public override int GetMaxCharCount(int byteCount)
	{
		return byteCount;
	}

	public override int GetByteCount(char[] chars, int index, int count)
	{
		return count;
	}

	public override int GetCharCount(byte[] bytes)
	{
		return bytes.Length;
	}

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		object obj = 0;
		while ((nint)obj < charCount)
		{
			object obj2 = obj + byteIndex;
			object obj3 = obj2 + (object)bytes;
			object obj4 = obj + charIndex;
			object obj5 = obj4 << 1;
			object obj6 = (object)chars + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6+10]");
			_ = 0;
			object obj7 = obj + 1;
			obj = obj7;
		}
		return charCount;
	}

	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return count;
	}

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		object obj = 0;
		while ((nint)obj < byteCount)
		{
			object obj2 = obj + charIndex;
			object obj3 = obj2 << 1;
			object obj4 = (object)chars + obj3;
			object obj5 = obj + byteIndex;
			object obj6 = obj5 + (object)bytes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v8+10]");
			_ = 0;
			object obj7 = obj + 1;
			obj = obj7;
		}
		return byteCount;
	}

	static ASCIIEncoding()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D52");
		Encoding aSCII = default;
		ASCII = aSCII;
	}
}
