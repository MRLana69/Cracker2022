using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

public class ByteReader
{
	private byte[] mBuffer;

	private int mOffset;

	private static BetterList<string> mTemp;

	public bool canRead
	{
		get
		{
			byte[] array = mBuffer;
			if (mBuffer == null)
			{
				return false;
			}
			return mOffset < array.Length;
		}
	}

	public ByteReader(byte[] bytes)
	{
		mBuffer = bytes;
	}

	public ByteReader(TextAsset asset)
	{
		byte[] bytes = asset.bytes;
		mBuffer = bytes;
	}

	public static ByteReader Open(string path)
	{
		//IL_000d: Expected I, but got Obj
		//IL_001f: Expected I, but got Obj
		//IL_005f: Expected I, but got Obj
		//IL_0071: Expected I, but got Obj
		//IL_0083: Expected I, but got Obj
		FileStream fileStream = File.OpenRead(path);
		ByteReader byteReader = default;
		if (fileStream != null)
		{
			nint num = (nint)fileStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v3 (Il2CppClass<System.IO.FileStream>)+1A4] (should have been resolved before IL gen)");
			nint num2 = (nint)fileStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S1_v6 (Il2CppClass<System.IO.FileStream>)+11C] (should have been resolved before IL gen)");
			object obj = default;
			if ((long)obj >= 2147483648L)
			{
				OverflowException result = new OverflowException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				return (ByteReader)(object)result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num3 = (nint)fileStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S3_v6 (Il2CppClass<System.IO.FileStream>)+1A4] (should have been resolved before IL gen)");
			nint num4 = (nint)fileStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S4_v7 (Il2CppClass<System.IO.FileStream>)+1B4] (should have been resolved before IL gen)");
			nint num5 = (nint)fileStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v108 @ S1_v15 (Il2CppClass<System.IO.FileStream>)+14C] (should have been resolved before IL gen)");
			byte[] array = default;
			byteReader.mBuffer = array;
		}
		return byteReader;
	}

	private static string ReadLine(byte[] buffer, int start, int count)
	{
		//IL_0011: Expected I, but got Obj
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		Encoding uTF = Encoding.UTF8;
		nint num = (nint)uTF;
		object obj = uTF + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S4_v2 (Il2CppClass<System.Text.Encoding>)+1F4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public string ReadLine()
	{
		return ReadLine(skipEmptyLines: true);
	}

	public string ReadLine(bool skipEmptyLines)
	{
		//IL_0212: Expected Obj, but got I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected I4, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		byte[] array = mBuffer;
		if (skipEmptyLines)
		{
			for (int num = mOffset; num < array.Length; num = ++mOffset)
			{
				object obj = num + mBuffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v44+10]");
				if ((nint)0 >= (nint)32)
				{
					break;
				}
			}
		}
		bool flag = array.Length <= mOffset;
		bool flag2 = !flag;
		int num2 = mOffset;
		int num3;
		string result = default;
		if (!flag2)
		{
			num3 = array.Length;
		}
		else
		{
			while (true)
			{
				if (num2 < array.Length)
				{
					object obj2 = num2 + mBuffer;
					int num4 = num2 + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v28+10]");
					object obj3 = -10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v28+10]");
					bool flag3 = (nint)0 == 10;
					num3 = num4;
					if (flag3)
					{
						break;
					}
					bool flag4 = (nint)obj3 == 1;
					num2 = num4;
					if (flag4)
					{
						continue;
					}
					bool flag5 = (nint)obj3 == 2;
					num2 = num4;
					if (!flag5)
					{
						bool flag6 = (nint)obj3 == 3;
						num3 = num4;
						if (flag6)
						{
							break;
						}
						num2 = num4;
					}
					continue;
				}
				int num5 = num2 + 1;
				num3 = num5;
				break;
			}
			object obj4 = num3 - mOffset;
			int count = obj4 - 1;
			result = ReadLine(mBuffer, mOffset, count);
		}
		mOffset = num3;
		return result;
	}

	public Dictionary<string, string> ReadDictionary()
	{
		//IL_0116: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		char[] array = default;
		array[0] = '=';
		while (true)
		{
			byte[] array2 = mBuffer;
			if (mBuffer == null || mOffset >= array2.Length)
			{
				break;
			}
			string text = ReadLine();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("//"))
			{
				string[] array3 = text.Split(array, 2, StringSplitOptions.RemoveEmptyEntries);
				if (array3.Length == 2)
				{
					string text2 = array3[0].Trim();
					string text3 = array3[1].Trim();
					string text4 = text3.Replace("\\n", "\n");
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S5_v6+4] (should have been resolved before IL gen)");
				}
			}
		}
		Dictionary<string, string> result = default;
		return result;
	}

	public BetterList<string> ReadCSV()
	{
		//IL_04e1: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I4
		//IL_050a: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_038a: Expected I4, but got Obj
		//IL_01f0: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		//IL_03cf: Expected I4, but got Obj
		BetterList<string> betterList = mTemp;
		betterList.size = 0;
		int num = 0;
		string text = string.Empty;
		BetterList<string> result;
		while (true)
		{
			byte[] array = mBuffer;
			bool flag = mBuffer != null && mOffset < array.Length;
			bool flag2 = !flag;
			result = null;
			if (flag2)
			{
				break;
			}
			int num3;
			if (true)
			{
				string text2 = ReadLine(skipEmptyLines: false);
				bool flag3 = text2 == null;
				result = null;
				if (flag3)
				{
					break;
				}
				string text3 = text2.Replace("\\n", "\n");
				string text4 = text + "\n" + text3;
				int num2 = 0;
				text = text4;
				num3 = num;
			}
			else
			{
				string text5 = ReadLine(skipEmptyLines: true);
				bool flag4 = text5 == null;
				result = null;
				if (flag4)
				{
					break;
				}
				string text6 = text5.Replace("\\n", "\n");
				int num2 = 0;
				num = 0;
				text = text6;
				num3 = 0;
			}
			int num4 = num3;
			object obj = 1;
			int num10;
			for (; num4 < text._stringLength; num10 = num4 + 1, num4 = num10)
			{
				char c = text.get_Chars(num4);
				if (c != '"')
				{
					if (c != ',')
					{
						continue;
					}
					if (obj == null)
					{
						int num2 = num4 - num;
						string item = text.Substring(num, num2);
						mTemp.Add(item);
						int num5 = num4 + 1;
						obj = 0;
						num = num5;
						continue;
					}
				}
				else
				{
					int num6 = num4 + 1;
					if (obj != null)
					{
						if (num6 >= text._stringLength)
						{
							goto IL_0255;
						}
						int index = num4 + 1;
						char c2 = text.get_Chars(index);
						if (c2 != '"')
						{
							int length = num4 - num;
							string text7 = text.Substring(num, length);
							string item2 = text7.Replace("\"\"", "\"");
							mTemp.Add(item2);
							int index2 = num4 + 1;
							char c3 = text.get_Chars(index2);
							bool flag5 = c3 != ',';
							obj = 0;
							int num2 = (int)"\"";
							if (!flag5)
							{
								int num7 = num4 + 1;
								int num8 = num7 + 1;
								num4 = num7;
								obj = 0;
								num2 = (int)"\"";
								num = num8;
							}
						}
						else
						{
							int num9 = num4 + 1;
							num4 = num9;
							obj = 1;
						}
						continue;
					}
					num = num6;
				}
				obj = 1;
			}
			if (num < text._stringLength)
			{
				if (obj != null)
				{
					continue;
				}
				int length2 = text._stringLength - num;
				string item3 = text.Substring(num, length2);
				mTemp.Add(item3);
			}
			goto IL_0471;
			IL_0471:
			result = mTemp;
			break;
			IL_0255:
			int length3 = num4 - num;
			string text8 = text.Substring(num, length3);
			string item4 = text8.Replace("\"\"", "\"");
			mTemp.Add(item4);
			goto IL_0471;
		}
		return result;
	}

	static ByteReader()
	{
		BetterList<string> betterList = default;
		mTemp = betterList;
	}
}
