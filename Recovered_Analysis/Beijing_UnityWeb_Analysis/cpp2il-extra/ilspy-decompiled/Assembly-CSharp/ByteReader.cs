using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
			//IL_00ad: Expected Obj, but got I4
			StreamReader streamReader = File.OpenText((string)(object)this);
			bool flag = default;
			if (streamReader != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @770A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
				object obj = default;
				if ((nint)obj > int.MaxValue)
				{
					OverflowException ex = new OverflowException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @770A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = (flag ? 1 : 0) + 8;
					object obj3 = default;
					obj2 = obj3;
				}
			}
			return flag;
		}
	}

	public ByteReader(byte[] bytes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I
		object obj = bytes + 48;
		ByteReader byteReader = (ByteReader)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
		mBuffer = (byte[])0;
	}

	public ByteReader(TextAsset asset)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = asset;
	}

	public static ByteReader Open(string path)
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [path @ L0 (System.String)+2C]");
		return (ByteReader)0;
	}

	private static string ReadLine(byte[] buffer, int start, int count)
	{
		//IL_0136: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected I4, but got Unknown
		//IL_00e2: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		object result = 0;
		byte b = buffer[16];
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (System.Byte)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (System.Byte)+1C]");
		object obj = num - 0;
		if (obj == null)
		{
			byte b2 = buffer[12];
			int num3 = default;
			int num4 = default;
			while (true)
			{
				int num2 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v35 (System.Byte)+C]");
				if ((nint)num2 >= (nint)0)
				{
					break;
				}
				BMGlyph bMGlyph = ((List<BMGlyph>)buffer[12]).get_Item(num4);
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v10 (Il2CppMethodInfo)+C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v11+60]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v12+48]");
				object obj4 = 0;
				object obj5 = obj4 & 0x7FF;
				object obj6 = obj5 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S5_v11 (should have been resolved before IL gen)");
				num3 = num4 + 1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		object obj8 = default;
		object obj7 = obj8 ^ 1;
		if ((obj7 & count) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj9 = default;
			result = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S4_v5+60]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S4_v6+48]");
			object obj12 = 0;
			object obj13 = obj12 & 0x7FF;
			object obj14 = obj13 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v106 @ S5_v6 (should have been resolved before IL gen)");
		}
		return (string)result;
	}

	public string ReadLine()
	{
		//IL_0043: Expected Obj, but got I4
		if (mBuffer != null)
		{
			byte[] array = mBuffer;
			bool flag = mOffset < array.Length;
			return (string)flag;
		}
		return null;
	}

	public unsafe string ReadLine(bool skipEmptyLines)
	{
		//IL_04b5: Expected I, but got Obj
		//IL_04cb: Expected Obj, but got I
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected VT, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_05e0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_050a: Expected Obj, but got I4
		//IL_00ed: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected Obj, but got Unknown
		//IL_0537: Expected Obj, but got I4
		//IL_012e: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_01aa: Expected I, but got Obj
		//IL_01c0: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I
		//IL_02d6: Expected F4, but got Obj
		//IL_02d1: Expected native int or pointer, but got VT
		//IL_02eb: Expected F4, but got I
		//IL_02e6: Expected native int or pointer, but got VT
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got F4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_01eb: Expected I, but got Obj
		//IL_0353: Expected F4, but got Obj
		//IL_034e: Expected native int or pointer, but got VT
		//IL_0368: Expected F4, but got I
		//IL_0363: Expected native int or pointer, but got VT
		//IL_038a: Expected F4, but got Obj
		//IL_0385: Expected native int or pointer, but got VT
		//IL_039f: Expected F4, but got I
		//IL_039a: Expected native int or pointer, but got VT
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got F4
		//IL_03d1: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		//IL_0445: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_023e: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v102 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Rect rect = (Rect)(obj2 + 48);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		string result;
		if ((UnityEngine.Object)skipEmptyLines != null)
		{
			result = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+14]");
			if ((nint)0 == 0)
			{
				int num3 = mOffset;
				bool flag;
				if (mOffset != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v13 (System.Int32)+8]");
					flag = (nint)0 == 0;
				}
				else
				{
					flag = true;
				}
				result = null;
				if (flag)
				{
					goto IL_05fd;
				}
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v97 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj6 = this + 16;
				string text = ((((ComputeShader)skipEmptyLines).FindKernel(null) == 0) ? null : ((UIAtlas)skipEmptyLines).GetRandomSprite((string)mOffset));
				obj6 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
				if ((nint)0 != 0)
				{
					UIAtlas replacement = ((UIAtlas)skipEmptyLines).replacement;
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v93 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (replacement != null)
					{
						object obj8 = this + 16;
						obj8 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj12 = 0;
						obj3 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v49+C]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v52+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v55+14]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v58+18]");
						_ = 0;
						((Rect*)(nint)rect)->m_XMin = (float)obj3;
						Rect rect2 = rect;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
						((Rect*)(nint)rect2)->m_Width = 0f;
						object obj13 = this + 48;
						obj13 = rect.m_XMin;
						_ = rect.m_Width;
						object obj14 = this + 48;
						obj4 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v39+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						((Rect*)(nint)rect)->m_XMin = (float)obj4;
						Rect rect3 = rect;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
						((Rect*)(nint)rect3)->m_Width = 0f;
						int width = default;
						int height = default;
						Rect rect4 = NGUIMath.MakePixelPerfect(rect, width, height);
						((Rect*)(nint)rect)->m_XMin = (float)obj2;
						Rect rect5 = rect;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Rect*)(nint)rect5)->m_Width = 0f;
						object obj15 = this + 48;
						obj15 = rect.m_XMin;
						_ = rect.m_Width;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S1_v60+2C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v63+34]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v66+14]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v69+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S1_v72+30]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S2_v10+2C]");
						object obj22 = num8 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S2_v13+14]");
						object obj24 = obj22 + 0;
						_ = 1;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ByteReader)+10]");
			bool flag2 = (nint)0 != 0;
			result = (string)flag2;
		}
		goto IL_05fd;
		IL_05fd:
		return result;
	}

	public Dictionary<string, string> ReadDictionary()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_000f: Expected Obj, but got I4
		return (Dictionary<string, string>)((EventDelegate)this).Equals((object)1);
	}

	public unsafe BetterList<string> ReadCSV()
	{
		//IL_01ce: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_01e6: Expected I4, but got Obj
		//IL_0207: Expected Obj, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_013a: Expected I4, but got Obj
		//IL_013a: Expected I4, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		StringSplitOptions stringSplitOptions = (StringSplitOptions)obj2;
		int num2 = ((StringSplitOptions*)(int)stringSplitOptions)->value__ & 0x1FFF;
		object obj3 = num2 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S4_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		char[] array = default;
		object obj4 = array + 16;
		obj4 = 61;
		object obj5 = 113696;
		while (true)
		{
			bool flag;
			if (mBuffer != null)
			{
				byte[] array2 = mBuffer;
				flag = mOffset < array2.Length;
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				break;
			}
			Dictionary<string, string> dictionary = ReadDictionary();
			if (dictionary == null)
			{
				break;
			}
			string text = ((string)(object)dictionary).ToLower((CultureInfo)(object)"//");
			if (text == null)
			{
				string[] array3 = ((string)(object)dictionary).SplitInternal(array, 2, StringSplitOptions.RemoveEmptyEntries);
				bool flag2 = array3.Length == 2;
				bool flag3 = !flag2;
				obj3 = 0;
				stringSplitOptions = StringSplitOptions.RemoveEmptyEntries;
				if (!flag3)
				{
					object str = array3 + 16;
					string text2 = string.Copy((string)str);
					object str2 = array3 + 20;
					string text3 = string.Copy((string)str2);
					string text4 = text3.Remove((int)"\\n", (int)"\n");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S4_v11 (Il2CppMethodInfo)+C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S4_v12+60]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S4_v13+48]");
					obj3 = 0;
					object obj8 = obj3 & 0x7FF;
					obj5 = obj8 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42 @ S5_v4 (should have been resolved before IL gen)");
					stringSplitOptions = StringSplitOptions.RemoveEmptyEntries;
				}
			}
		}
		BetterList<string> result = default;
		return result;
	}

	static ByteReader()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BetterList<UIToggle> list = default;
		UIToggle.list = list;
	}
}
