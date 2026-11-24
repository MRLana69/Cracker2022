using System.Text;
using Cpp2ILInjected;

public class ASCIIEncoding : Encoding
{
	public new static readonly Encoding ASCII;

	public override int GetMaxByteCount(int charCount)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 20;
		obj = this;
		object obj2 = num + 16;
		obj2 = charCount;
		return num;
	}

	public override int GetMaxCharCount(int byteCount)
	{
		return byteCount;
	}

	public override int GetByteCount(char[] chars, int index, int count)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 20;
		obj = this;
		object obj2 = num + 24;
		obj2 = chars;
		int num2 = index & 1;
		object obj3 = num + 28;
		obj3 = count;
		return num;
	}

	public override int GetCharCount(byte[] bytes)
	{
		//IL_0005: Expected I4, but got Obj
		return (int)bytes;
	}

	public unsafe override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
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
		obj = chars;
		object obj2 = num + 20;
		obj2 = charIndex;
		object obj3 = ((int*)charCount)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [charCount @ L3 (System.Int32)+8]");
		_ = 0;
		object obj4 = num + 24;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj3 = bytes;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bytes @ L4 (System.Byte[])+8]");
		_ = 0;
		object obj5 = num + 36;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj3 = ((int*)byteIndex)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [byteIndex @ L5 (System.Int32)+8]");
		_ = 0;
		object obj6 = num + 48;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return num;
	}

	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return count;
	}

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		object obj = 0;
		while ((nint)obj < byteCount)
		{
			object obj2 = chars + 16;
			object obj3 = obj + charIndex;
			object obj4 = obj2 + obj3;
			object obj5 = bytes + 16;
			object obj6 = obj + byteIndex;
			object obj7 = obj6 << 1;
			object obj8 = obj5 + obj7;
			obj4 = obj8;
			object obj9 = obj + 1;
			obj = obj9;
		}
		return byteCount;
	}

	public ASCIIEncoding()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	static ASCIIEncoding()
	{
		ShopFooterNavigation._selectedTab = 2;
	}
}
