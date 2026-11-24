using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Authentication.Internal;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using Kiloo.Google;
using Kiloo.Monetization.FlurryPlugin.Internal;
using SYBO.Common.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Level.Environments;
using SYBO.Subway.Routes;
using UnityEngine;

namespace Kiloo.Serialization;

public class KilooSerializer : IJsonSerializer, IBsonSerializer
{
	public class Options
	{
		public bool indent;

		public bool ignoreCase;

		public bool ignoreErrors;

		public IFormatProvider formatProvider;

		public static Options defaultOptions;

		public Options()
		{
			//IL_0057: Expected Obj, but got I4
			object obj = default;
			do
			{
				char nextChar = ((KilooJson.Parser)this).NextChar;
				int num = " \t\n\r".IndexOfAny((char[])nextChar);
				if (num != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					continue;
				}
				break;
			}
			while ((nint)obj != -1);
		}

		static Options()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GoogleLogin._003C_003Ec obj = default;
			GoogleLogin._003C_003Ec._003C_003E9 = obj;
		}
	}

	public readonly Options options;

	public unsafe KilooSerializer(Options options = null)
	{
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I4
		//IL_020c: Expected I, but got Obj
		//IL_0222: Expected Obj, but got I
		//IL_024d: Expected I, but got Obj
		//IL_0263: Expected Obj, but got I
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got VT
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected VT, but got Unknown
		//IL_0310: Expected I8, but got Obj
		//IL_030b: Expected native int or pointer, but got VT
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0333: Expected Ref, but got VT
		//IL_033f: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_00fd: Expected I, but got Obj
		//IL_0149: Expected F8, but got I8
		//IL_018a: Expected F8, but got I8
		//IL_01cb: Expected F8, but got I8
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
		nint num = (nint)typeof(BsonBinaryWriterExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v58 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v54 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 8;
		object obj6 = default;
		obj5 = obj6;
		obj2 = BsonBinaryWriterExtensions._epoch;
		DateTime dateTime = (DateTime)(obj2 + 24);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
		formatProvider = (IFormatProvider)obj2;
		long num5 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num5;
		double num6 = (double)obj * 0.0001;
		if (num6 > 922337203685477.0)
		{
			num6 = 922337203685477.0;
		}
		else if (num6 < -922337203685477.0)
		{
			num6 = -922337203685477.0;
		}
		nint num7 = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v39 (Il2CppClass<System.BitConverter>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v45 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (num6 != num6)
		{
			double num9 = -9.223372036854776E+18;
		}
		else if (!(num6 < 9.223372036854776E+18))
		{
			double num9 = -9.223372036854776E+18;
		}
		else if (!(num6 > -9.223372036854776E+18))
		{
			double num9 = -9.223372036854776E+18;
		}
		else
		{
			double num9 = num6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E22C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	public string ToJson(object obj)
	{
		//IL_000e: Expected Obj, but got I4
		return (string)((FileUtil._003C_003Ec__DisplayClass16_1)this)._003CGetFilesForPath_003Eb__0((FileInfo)obj);
	}

	public T FromJson<T>(string json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02dd: Expected VT, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected I4, but got Unknown
		//IL_02bc: Expected Obj, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		StringBuilder stringBuilder = default;
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.Text.StringBuilderCache.Release(stringBuilder);
			nint num = default;
			object obj3 = num + 24;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj5 == null)
				{
					break;
				}
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			}
			object obj7 = obj2 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj2 + obj9;
			obj10 = 77;
			object obj11 = default;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj12 = (nint)0 << 2;
				object obj13 = obj2 + obj12;
				if ((nint)obj13 == 77)
				{
					object obj14 = obj2 + 4;
					if ((nint)obj14 > -1)
					{
						object obj15 = obj14 + -1;
						obj14 = obj15;
					}
					goto IL_0340;
				}
			}
			object obj16 = default;
			if (obj16 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0340;
		}
		return (T)"<null>";
		IL_0340:
		object obj17 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
		if ((nint)obj17 >= 1)
		{
			object obj18 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
			int index = obj18 - json.m_stringLength;
			StringBuilder stringBuilder2 = stringBuilder.Insert(index, (string)json.m_stringLength);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		T result = default;
		return result;
	}

	public object FromJson(string json)
	{
		//IL_002e: Expected Obj, but got I4
		Options options = this.options;
		bool indent = options.indent;
		return ((KilooSerializer)(object)json).ToJson((object)indent);
	}

	public object FromJson(Type type, string json)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_000d: Expected I, but got Obj
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0024: Expected I4, but got Obj
		//IL_0024: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_004e: Expected I, but got Obj
		string text = default;
		object obj = text + 8;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj3 = default;
		object obj2 = obj3 - 4;
		object obj4 = json + 4;
		string text2 = (string)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<object> list = default;
		list._002Ector();
		nint num = (nint)json;
		while (true)
		{
			object obj5 = obj2 + json;
			object obj6 = obj5 - 1;
			if (num >= (nint)obj6)
			{
				break;
			}
			GameCenterPlugin._GameCenterLoadLeaderboardForIDs(text, (string)(object)this, (int)type, (int)json);
			obj = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			list.Add(0);
			num = (nint)json;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj7 = json + 1;
		text2 = (string)obj7;
		return list;
	}

	public void ToBson(object obj, BinaryWriter writer)
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b5: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.BitConverter>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = writer + 12;
		byte[] bytes = BitConverter.GetBytes((ushort)(int)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	public byte[] ToBson(object value)
	{
		if (value != null)
		{
			Options options = this.options;
			bool ignoreCase = options.ignoreCase;
			return (byte[])(object)KilooJson.Serialize(value, ignoreCase);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ArgumentOutOfRangeException ex = default;
		ex._002Ector("json");
		((KilooSerializer)(object)ex).FromJson((string)null);
		return null;
	}

	public unsafe T FromBson<T>(byte[] buffer)
	{
		//IL_006f: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected I, but got Unknown
		//IL_00db: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v23 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2;
		nint num4 = (nint)(obj4 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj4;
		Type type = Type.internal_from_handle((IntPtr)num4);
		object obj5 = FromBson(type, buffer);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		T result = default;
		return result;
	}

	public object FromBson(byte[] buffer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 50;
		object obj7 = 0;
		object obj9 = default;
		object obj8 = obj9;
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		object result = default;
		object obj14 = default;
		if ((nint)0 == -1)
		{
			if (obj7 == null)
			{
				result = obj8;
				goto IL_0420;
			}
		}
		else
		{
			bool flag = obj7 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj2 + obj11;
			bool flag2 = (nint)obj12 != 50;
			object obj13 = flag & flag2;
			if (obj13 == null)
			{
				obj14 = obj7;
				result = obj8;
				goto IL_0420;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj16 = default;
		object obj15 = obj16;
		object obj18 = default;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj19 = default;
		if (obj17 == obj19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj20 = default;
			obj14 = obj20;
			result = obj8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0420;
		IL_0420:
		if (memoryStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj2 + obj21;
			if ((nint)obj22 == 50)
			{
				object obj23 = obj2 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_049b;
			}
		}
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_049b;
		IL_049b:
		return result;
	}

	public T FromBson<T>(BinaryReader reader)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0224: Expected I4, but got Obj
		//IL_0020: Expected I4, but got Obj
		//IL_0030: Expected Obj, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.Dispose((byte)(int)reader != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryReader binaryReader = default;
		binaryReader.Dispose((byte)(int)memoryStream != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj5 = obj2 + 4;
		object obj6 = obj5 + 1;
		obj5 = obj6;
		object obj7 = obj6 << 2;
		object obj8 = obj2 + obj7;
		obj8 = 32;
		if (binaryReader != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 32)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				goto IL_0255;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0255;
		IL_0255:
		T result = default;
		return result;
	}

	public object FromBson(BinaryReader reader)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_020c: Expected I4, but got Obj
		//IL_0020: Expected I4, but got Obj
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.Dispose((byte)(int)reader != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryReader binaryReader = default;
		binaryReader.Dispose((byte)(int)memoryStream != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 32;
		if (binaryReader != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj2 + obj7;
			if ((nint)obj8 == 32)
			{
				object obj9 = obj2 + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				goto IL_023d;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_023d;
		IL_023d:
		object result = default;
		return result;
	}

	public object FromBson(Type type, byte[] buffer)
	{
		byte[] callback = ToBson(buffer);
		return ((FlurryAdsCallback)this).BeginInvoke((string)(object)type, (AsyncCallback)(object)callback, (object)null);
	}

	public object FromBson(Type type, BinaryReader reader)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_020c: Expected I4, but got Obj
		//IL_0020: Expected I4, but got Obj
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.Dispose((byte)(int)reader != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryReader binaryReader = default;
		binaryReader.Dispose((byte)(int)memoryStream != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 33;
		if (binaryReader != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj2 + obj7;
			if ((nint)obj8 == 33)
			{
				object obj9 = obj2 + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				goto IL_023d;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_023d;
		IL_023d:
		object result = default;
		return result;
	}

	public unsafe T ConvertValue<T>(object value)
	{
		//IL_006f: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected I, but got Unknown
		//IL_00db: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v23 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2;
		nint num4 = (nint)(obj4 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj4;
		Type type = Type.internal_from_handle((IntPtr)num4);
		object obj5 = ConvertValue(type, value);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		T result = default;
		return result;
	}

	public object ConvertValue(Type type, object value)
	{
		Type enumerableElementType = GetEnumerableElementType((Type)value);
		return ((FlurryAdsCallback)this).BeginInvoke((string)(object)type, (AsyncCallback)(object)enumerableElementType, (object)null);
	}

	private object ConvertValue(Type type, object value, string propertyName)
	{
		//IL_01b5: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_0154: Invalid comparison between F4 and I
		//IL_0192: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_004c: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_01fe: Invalid comparison between I and VT
		//IL_008d: Expected I, but got Obj
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Serialization.KilooSerializer)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7+1C]");
		object obj2 = (nint)0 + (nint)12;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7+1C]");
			object obj4 = (nint)0 + (nint)16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			object obj7 = obj6;
			nint num = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v28 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v43 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v26+8]");
			bool flag;
			if ((object)0 == (object)type._impl)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v26+C]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [type @ L1 (System.Type)+C]");
				flag = num3 == 0;
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				object obj9 = obj3 + 1;
				obj3 = obj9;
				continue;
			}
			return null;
		}
		float num4 = ((UnityRandomGen)value).NextFloat();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Serialization.KilooSerializer)+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v10+20]");
		object result;
		if (num4 > 0f)
		{
			result = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Serialization.KilooSerializer)+10]");
			Transform transform = ((WeightRandomizedPrefabContainter<TransitionConfig.WeightedTransitionPrefab, Transform>)0).PickSemiRandomlyOrderedPrefab((SyboRandom)value);
			text = (string)(object)transform;
			result = 1;
		}
		return result;
	}

	private static string GetDisplayValue(object value)
	{
		if (((Type)value).IsAbstract)
		{
			return ((ArgumentException)value).Message;
		}
		return null;
	}

	private static object GetDefault(Type type)
	{
		if ((object)type == null)
		{
			return "null";
		}
		Type type2;
		if ((object)type == null)
		{
			type2 = null;
		}
		else
		{
			type2 = (((object)((object)type).GetType() != typeof(string)) ? null : type);
		}
		if ((object)type2 != null)
		{
			return ((IConvertible)"\"").ToType(type2, (IFormatProvider)(object)"\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object result = default;
		return result;
	}

	private object ConvertToEnum(Type type, object value)
	{
		return ((FlurryAdsCallback)this).BeginInvoke((string)(object)type, (AsyncCallback)value, (object)null);
	}

	private Array ConvertToArray(Type type, IList jsonList)
	{
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I4
		//IL_015f: Expected I4, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I4
		//IL_008a: Expected I, but got Obj
		nint num = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Enum>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		IList list;
		if (jsonList == null)
		{
			list = null;
		}
		else
		{
			list = (((object)jsonList.GetType() != typeof(string)) ? null : jsonList);
		}
		if (list != null)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v35 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Array)(object)((Enum)(object)type).ToString((string)(object)list, (IFormatProvider)1);
		}
		if (!flag)
		{
			nint num3 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = Enum.IsDefined(type, jsonList);
		if (((Enum)(object)type).InternalHasFlag((Enum)flag2))
		{
			return (Array)flag2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Exception ex = default;
		ex.SetErrorCode((int)"Enum value not defined");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		string result = default;
		return (Array)(object)result;
	}

	private object ConvertToCollection(Type type, IEnumerable enumerable)
	{
		//IL_0046: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type type2 = default;
		int[] array2 = default;
		Array array = Array.CreateInstance(type2, array2);
		int num = 0;
		AsyncCallback callback = default;
		while (num < (nint)array2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			IAsyncResult asyncResult = ((FlurryAdsCallback)this).BeginInvoke((string)(object)type2, callback, (object)null);
			Array.Clear(array, (int)asyncResult, num);
			int num2 = num + 1;
			num = num2;
		}
		return array;
	}

	private unsafe Type GetEnumerableElementType(Type enumerableType)
	{
		if ((object)enumerableType != null)
		{
			Options options = this.options;
			bool ignoreCase = options.ignoreCase;
			return (Type)(object)BsonBinaryReaderExtensions.ReadBsonString((BinaryReader)(object)enumerableType, ref *(ignoreCase ? ((int*)1) : ((int*)null)));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ArgumentOutOfRangeException ex = default;
		ex._002Ector("reader");
		((KilooSerializer)(object)ex).FromBson((BinaryReader)null);
		return null;
	}

	private object ConvertToObject(Type type, IDictionary properties)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08d8: Expected Obj, but got I4
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0978: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0193: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I4
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_0416: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = 0;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj4 = default;
		if (obj4 != null)
		{
			bool isNested = type.IsNested;
			object obj5 = (isNested ? 1 : 0) + 12;
			object obj36;
			string text = default;
			object obj11 = default;
			object obj12 = default;
			object obj14 = default;
			object obj16 = default;
			object obj17 = default;
			object obj20 = default;
			object obj26 = default;
			object obj27 = default;
			object obj29 = default;
			object obj30 = default;
			object obj35 = default;
			for (object obj6 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5); obj36 = obj6 + 1, obj6 = obj36)
			{
				object obj7 = (isNested ? 1 : 0) + 16;
				object obj8 = obj6 << 2;
				object obj9 = obj7 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				if (!(text != "Add"))
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v138+C]");
				if ((nint)0 != 2)
				{
					continue;
				}
				string message = ((ArgumentException)(object)type).Message;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj10;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					obj10 = 29;
					bool flag = obj11 == null;
					obj10 = 30;
					if (flag)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					obj10 = 21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 21;
					obj2 = obj12;
					object obj13 = obj14 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
					obj10 = 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					obj10 = 24;
					object obj15 = obj16 + 16;
					obj15 = obj17;
					object obj18 = obj14 + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 25;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 26;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
					obj10 = 27;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					obj10 = 27;
					object obj19 = obj16 + 20;
					obj19 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				}
				object obj21 = obj10 - 21;
				if ((nint)obj10 != 21 && (nint)obj21 != 1 && (nint)obj21 != 2 && (nint)obj21 != 3 && (nint)obj21 != 4 && (nint)obj21 != 5 && (nint)obj21 != 6 && (nint)obj21 != 7 && (nint)obj21 != 8)
				{
					if ((nint)obj21 == 9)
					{
						object obj22 = obj3 + 4;
						object obj23 = obj22 + 1;
						obj22 = obj23;
						object obj24 = obj23 << 2;
						object obj25 = obj3 + obj24;
						obj25 = 209;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					bool flag2 = obj26 != obj27;
					object obj28 = obj29;
					if (flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
						goto IL_08cd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				if (obj30 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
				string result;
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
					object obj31 = (nint)0 << 2;
					object obj32 = obj3 + obj31;
					if ((nint)obj32 == 209)
					{
						object obj33 = obj3 + 4;
						if ((nint)obj33 > -1)
						{
							object obj34 = obj33 + -1;
							obj33 = obj34;
						}
						result = message;
						goto IL_08b9;
					}
				}
				bool flag3 = obj35 == null;
				result = message;
				if (flag3)
				{
					goto IL_08b9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				goto IL_08cd;
				IL_08b9:
				return result;
				IL_08cd:
				return null;
			}
		}
		IRequest request = KilooSerializerHTTPExtensions.WithJsonContent(null, type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private object TryConstruct(ConstructorInfo constructor, IDictionary properties)
	{
		//IL_03d3: Expected I, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_0521: Expected I, but got Obj
		//IL_0537: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_0474: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_02ad: Expected VT, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v98 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MethodInfo method = ((Type)(object)constructor).GetMethod((string)(object)Type.EmptyTypes);
		nint num3 = (nint)typeof(ConstructorInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v13 (Il2CppClass<System.Reflection.ConstructorInfo>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(ConstructorInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v94 (Il2CppClass<System.Reflection.ConstructorInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
		object obj3 = default;
		string text = default;
		if (obj3 != null)
		{
			string message = ((ArgumentException)(object)constructor).Message;
			text = message;
		}
		else
		{
			MethodInfo[] methods = ((Type)(object)constructor).GetMethods();
			object obj4 = methods + 12;
			object obj5 = 0;
			int totalLength = default;
			NullReferenceException ex = default;
			while (true)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					object obj6 = methods + 16;
					object obj7 = obj5 << 2;
					object request = obj6 + obj7;
					Coroutine coroutine = ((GoogleSignInPlugin)this).SignIn((GoogleSignInPluginRequest)request, (Action<GoogleSignInPluginRequest>)(object)properties);
					if (coroutine != null)
					{
						text = (string)(object)coroutine;
						break;
					}
					object obj8 = obj5 + 1;
					obj5 = obj8;
					continue;
				}
				if (((Type)(object)constructor).IsAbstract)
				{
					string message2 = ((ArgumentException)(object)constructor).Message;
					if (message2 != null)
					{
						text = message2;
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				string message3 = string.ConcatArray((string[])(object)"No suitable constructor for ", totalLength);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ex._002Ector(message3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				break;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj9 = default;
		string text2 = (string)(obj9 + 12);
		object obj10 = 0;
		object obj15 = default;
		object obj16 = default;
		string message4 = default;
		object obj17 = default;
		object obj18 = default;
		AsyncCallback callback = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref text2))
		{
			object obj11 = obj9 + 16;
			object obj12 = obj10 << 2;
			object obj13 = obj11 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj14 = obj15 & 0x80;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					IAsyncResult value = ((FlurryAdsCallback)this).BeginInvoke(message4, callback, obj17);
					((FieldInfo)obj13).SetValueDirect((TypedReference)text, (object)value);
					obj18 = null;
				}
			}
			object obj19 = obj10 + 1;
			obj10 = obj19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj21 = default;
		object obj20 = obj21 + 12;
		object obj22 = 0;
		object obj26 = default;
		object obj27 = default;
		string message5 = default;
		AsyncCallback callback2 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
		{
			object obj23 = obj21 + 16;
			object obj24 = obj22 << 2;
			object obj25 = obj23 + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			if (obj26 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				if (obj27 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					IAsyncResult asyncResult = ((FlurryAdsCallback)this).BeginInvoke(message5, callback2, obj18);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
					callback = null;
				}
			}
			object obj28 = obj22 + 1;
			obj22 = obj28;
		}
		return text;
	}
}
