using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Serialization;

public static class BsonBinaryWriterExtensions
{
	private static readonly DateTime _epoch;

	private static bool CanBeBsonObject(object obj)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = obj;
		return flag;
	}

	public static void WriteBsonObject(BinaryWriter writer, object obj)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		object obj2 = writer + 12;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		Transform transform = (Transform)(obj3 + 12);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 right = transform.right;
	}

	private static void WriteBsonProperty(BinaryWriter writer, string name, object value)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		obj = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (obj3.System_002EIConvertible_002EToBoolean(provider) && writer != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v5 (Il2CppMethodInfo)+18]");
			object obj4 = 0;
			object obj5 = obj4;
			object obj6 = obj5 & 0x3FFF;
			object obj7 = obj6 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	private static void WriteBsonArray(BinaryWriter writer, IEnumerable array)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03e2: Expected I, but got Obj
		//IL_03f8: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00f9: Expected I4, but got Obj
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I4
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_02f8: Expected Obj, but got I
		//IL_016f: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_01b0: Expected I, but got Obj
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(BsonBinaryWriterExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v129 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IDictionary dictionary = ConversionHelper.ValueAsDictionary(array);
		if (dictionary == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector("Unsupported type.");
			WriteBsonObject((BinaryWriter)(object)ex, null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj4 = default;
		if (obj4 == null)
		{
			obj4 = ConversionHelper.GetDefault((Type)array);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryWriter binaryWriter = default;
		binaryWriter.Dispose((byte)(int)memoryStream != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			nint num3 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v106 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v115 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj7 = obj2 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj2 + obj9;
		obj10 = 122;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
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
			if ((nint)obj13 == 122)
			{
				object obj14 = obj2 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0494;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0494;
		IL_0494:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		object obj18 = default;
		object obj17 = obj18 + 4;
		object obj19 = obj17 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	private unsafe static void WriteBsonBinaryData(BinaryWriter writer, byte subType, byte[] buf)
	{
		//IL_123b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1240: Expected I, but got Unknown
		//IL_1249: Unknown result type (might be due to invalid IL or missing references)
		//IL_124e: Expected Obj, but got Unknown
		//IL_1257: Unknown result type (might be due to invalid IL or missing references)
		//IL_125c: Expected Obj, but got Unknown
		//IL_1265: Unknown result type (might be due to invalid IL or missing references)
		//IL_126a: Expected Obj, but got Unknown
		//IL_1273: Unknown result type (might be due to invalid IL or missing references)
		//IL_1278: Expected Obj, but got Unknown
		//IL_1281: Expected Obj, but got I4
		//IL_11b2: Expected I, but got Obj
		//IL_11c8: Expected Obj, but got I
		//IL_175d: Expected Obj, but got I4
		//IL_11f3: Expected I, but got Obj
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_12b1: Expected Obj, but got I4
		//IL_0085: Expected I, but got Obj
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_12d7: Expected Obj, but got I4
		//IL_018d: Expected I, but got Obj
		//IL_024a: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_1323: Expected I, but got Obj
		//IL_133e: Expected I, but got Obj
		//IL_1354: Expected Obj, but got I
		//IL_028b: Expected I, but got Obj
		//IL_037d: Expected I, but got Obj
		//IL_0393: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I4
		//IL_02d8: Expected I, but got Obj
		//IL_1399: Expected Obj, but got I4
		//IL_03be: Expected I, but got Obj
		//IL_0485: Expected I, but got Obj
		//IL_049b: Expected Obj, but got I
		//IL_0454: Expected Obj, but got I4
		//IL_13c0: Expected Obj, but got I4
		//IL_073c: Expected I, but got Obj
		//IL_0752: Expected Obj, but got I
		//IL_04c6: Expected I, but got Obj
		//IL_1422: Expected I, but got Obj
		//IL_143d: Expected I, but got Obj
		//IL_1453: Expected Obj, but got I
		//IL_055c: Expected Obj, but got I4
		//IL_147d: Expected Obj, but got I4
		//IL_077d: Expected I, but got Obj
		//IL_07ca: Expected I, but got Obj
		//IL_05c7: Expected Obj, but got I4
		//IL_087c: Expected I, but got Obj
		//IL_0892: Expected Obj, but got I
		//IL_14a0: Expected Obj, but got I4
		//IL_08bd: Expected I, but got Obj
		//IL_0632: Expected Obj, but got I4
		//IL_0983: Expected I, but got Obj
		//IL_0999: Expected Obj, but got I
		//IL_14ee: Expected I, but got Obj
		//IL_1509: Expected I, but got Obj
		//IL_151f: Expected Obj, but got I
		//IL_1549: Expected Obj, but got I4
		//IL_09c4: Expected I, but got Obj
		//IL_0ac3: Expected I, but got Obj
		//IL_0ad9: Expected Obj, but got I
		//IL_0a11: Expected I, but got Obj
		//IL_069d: Expected Obj, but got I4
		//IL_156c: Expected Obj, but got I4
		//IL_0b04: Expected I, but got Obj
		//IL_0bd4: Expected I, but got Obj
		//IL_0bea: Expected Obj, but got I
		//IL_159b: Expected Obj, but got I4
		//IL_0708: Expected Obj, but got I4
		//IL_0c15: Expected I, but got Obj
		//IL_0ce5: Expected I, but got Obj
		//IL_0cfb: Expected Obj, but got I
		//IL_15ca: Expected Obj, but got I4
		//IL_0d26: Expected I, but got Obj
		//IL_0df6: Expected I, but got Obj
		//IL_0e0c: Expected Obj, but got I
		//IL_1609: Expected Obj, but got I4
		//IL_161f: Expected I, but got Obj
		//IL_0fac: Expected I, but got Obj
		//IL_0fc2: Expected Obj, but got I
		//IL_0e37: Expected I, but got Obj
		//IL_168a: Expected I4, but got Obj
		//IL_168a: Expected Obj, but got I4
		//IL_0f07: Expected I, but got Obj
		//IL_0f1d: Expected Obj, but got I
		//IL_0fed: Expected I, but got Obj
		//IL_164a: Expected Obj, but got I4
		//IL_16df: Expected I, but got Obj
		//IL_16f5: Expected Obj, but got I
		//IL_1044: Expected I, but got Obj
		//IL_105a: Expected Obj, but got I
		//IL_0f99: Expected Obj, but got I4
		//IL_0f48: Expected I, but got Obj
		//IL_173e: Expected Obj, but got I4
		//IL_174b: Expected Obj, but got I4
		//IL_16b8: Expected Obj, but got I4
		//IL_1175: Expected I, but got Obj
		//IL_1085: Expected I, but got Obj
		//IL_1101: Expected I, but got Obj
		//IL_1117: Expected Obj, but got I
		//IL_171f: Expected Obj, but got I4
		//IL_1142: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 8);
		object obj2 = obj + 48;
		object obj3 = obj + 44;
		object obj4 = obj + 40;
		object obj5 = obj + 24;
		obj5 = 0;
		_ = 0;
		byte[] array = default;
		bool flag2;
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			BinaryWriter binaryWriter = default;
			if (binaryWriter != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				nint num2 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v458 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num3 = (nint)typeof(BsonBinaryWriterExtensions);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v464 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				WriteBsonString(writer, (string)subType);
				((KilooSerializer)(object)writer).ToBson((object)null, binaryWriter);
				return;
			}
			byte[] array2;
			if (array == null)
			{
				array2 = null;
			}
			else
			{
				array2 = (((object)array.GetType() != typeof(string)) ? null : array);
			}
			if (array2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				nint num4 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v439 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num5 = (nint)typeof(BsonBinaryWriterExtensions);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v445 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				WriteBsonString(writer, (string)subType);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E32");
				return;
			}
			byte[] array3;
			if (array == null)
			{
				array3 = null;
			}
			else
			{
				array3 = (((object)array.GetType() != typeof(float)) ? null : array);
			}
			bool flag = default;
			if (array3 != null)
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v407 (Il2CppClass<System.Type>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num7 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v426 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(double);
				((IntPtr*)num)->m_value = (void*)(nint)obj2;
				Type provider = Type.internal_from_handle((IntPtr)num);
				nint num8 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v416 (Il2CppClass<System.Convert>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num9 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v422 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				flag = Convert.ToBoolean(array, (IFormatProvider)provider);
			}
			byte[] array4;
			if (flag)
			{
				array4 = (((flag ? 1 : 0) != (nint)typeof(double)) ? null : ((byte[])flag));
			}
			else
			{
				array4 = null;
			}
			if (array4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				nint num10 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v387 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num11 = (nint)typeof(BsonBinaryWriterExtensions);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v393 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				WriteBsonString(writer, (string)subType);
				throw new NullReferenceException();
			}
			byte[] array5;
			if (flag)
			{
				array5 = (((flag ? 1 : 0) != (nint)typeof(bool)) ? null : ((byte[])flag));
			}
			else
			{
				array5 = null;
			}
			if (array5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				nint num12 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v368 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num13 = (nint)typeof(BsonBinaryWriterExtensions);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v374 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				WriteBsonString(writer, (string)subType);
				throw new NullReferenceException();
			}
			byte[] array6;
			if (flag)
			{
				array6 = (((flag ? 1 : 0) != (nint)typeof(char)) ? null : ((byte[])flag));
			}
			else
			{
				array6 = null;
			}
			if (array6 == null)
			{
				byte[] array7;
				if (flag)
				{
					array7 = (((flag ? 1 : 0) != (nint)typeof(sbyte)) ? null : ((byte[])flag));
				}
				else
				{
					array7 = null;
				}
				if (array7 == null)
				{
					byte[] array8;
					if (flag)
					{
						array8 = (((flag ? 1 : 0) != (nint)typeof(byte)) ? null : ((byte[])flag));
					}
					else
					{
						array8 = null;
					}
					if (array8 == null)
					{
						byte[] array9;
						if (flag)
						{
							array9 = (((flag ? 1 : 0) != (nint)typeof(short)) ? null : ((byte[])flag));
						}
						else
						{
							array9 = null;
						}
						if (array9 == null)
						{
							byte[] array10;
							if (flag)
							{
								array10 = (((flag ? 1 : 0) != (nint)typeof(ushort)) ? null : ((byte[])flag));
							}
							else
							{
								array10 = null;
							}
							if (array10 == null)
							{
								flag2 = flag;
								goto IL_13ee;
							}
						}
					}
				}
			}
			nint num14 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v292 (Il2CppClass<System.Type>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num15 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v311 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = typeof(int);
			((IntPtr*)num)->m_value = (void*)(nint)obj3;
			Type provider2 = Type.internal_from_handle((IntPtr)num);
			nint num16 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v301 (Il2CppClass<System.Convert>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num17 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S0_v307 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = Convert.ToBoolean(flag, (IFormatProvider)provider2);
			flag2 = flag3;
			goto IL_13ee;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		nint num18 = (nint)typeof(BsonBinaryWriterExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num19 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WriteBsonString(writer, (string)subType);
		return;
		IL_13ee:
		if (flag2 && (((bool*)(flag2 ? 1 : 0))->m_value ? 1 : 0) == (nint)typeof(int) && flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			nint num20 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v271 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num21 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S0_v277 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WriteBsonString(writer, (string)subType);
			throw new NullReferenceException();
		}
		if (flag2 && (((bool*)(flag2 ? 1 : 0))->m_value ? 1 : 0) == (nint)typeof(uint) && flag2)
		{
			nint num22 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S0_v239 (Il2CppClass<System.Type>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num23 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ S0_v258 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = typeof(long);
			((IntPtr*)num)->m_value = (void*)(nint)obj4;
			Type provider3 = Type.internal_from_handle((IntPtr)num);
			nint num24 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S0_v248 (Il2CppClass<System.Convert>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num25 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ S0_v254 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = Convert.ToBoolean(flag2, (IFormatProvider)provider3);
			flag2 = flag4;
		}
		if (flag2 && (((bool*)(flag2 ? 1 : 0))->m_value ? 1 : 0) == (nint)typeof(ulong) && flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			nint num26 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ S0_v219 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num27 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ S0_v225 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WriteBsonString(writer, (string)subType);
			throw new NullReferenceException();
		}
		if (flag2 && (((bool*)(flag2 ? 1 : 0))->m_value ? 1 : 0) == (nint)typeof(long) && flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			nint num28 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S0_v200 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num29 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ S0_v206 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WriteBsonString(writer, (string)subType);
			throw new NullReferenceException();
		}
		if (flag2 && (((bool*)(flag2 ? 1 : 0))->m_value ? 1 : 0) == (nint)typeof(DateTime) && flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			nint num30 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ S0_v179 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num31 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ S0_v187 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WriteBsonString(writer, (string)subType);
			throw new NullReferenceException();
		}
		if (flag2 && (((bool*)(flag2 ? 1 : 0))->m_value ? 1 : 0) == (nint)typeof(decimal) && flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			nint num32 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S0_v158 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num33 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ S0_v166 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WriteBsonString(writer, (string)subType);
			NullReferenceException ex = new NullReferenceException();
			((IntPtr*)num)->m_value = (void*)(nint)ex;
			_ = ((Exception)ex)._className;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E35");
			return;
		}
		if (flag2 && (((bool*)(flag2 ? 1 : 0))->m_value ? 1 : 0) == (nint)typeof(Guid) && flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			nint num34 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ S0_v137 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num35 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ S0_v145 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WriteBsonString(writer, (string)subType);
			NullReferenceException ex2 = new NullReferenceException();
			obj5 = ex2;
			_ = ((Exception)ex2)._className;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EF79");
			BinaryWriter writer2 = default;
			((KilooSerializer)(object)writer).ToBson((object)4, writer2);
			return;
		}
		nint num36 = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ S0_v87 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num37 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S0_v131 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		object obj24 = KilooJson.Deserialize((string)flag2, (byte)(int)currentCulture != 0);
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			nint num38 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ S0_v122 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num39 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ S0_v128 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WriteBsonString(writer, (string)subType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E32");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		string text = default;
		if (text != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj26 = default;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				nint num40 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S0_v111 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					nint num41 = (nint)typeof(BsonBinaryWriterExtensions);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ S0_v117 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				WriteBsonString(writer, (string)subType);
				WriteBsonCString(writer, text);
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		nint num42 = (nint)typeof(BsonBinaryWriterExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ S0_v98 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num43 = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ S0_v104 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WriteBsonString(writer, (string)subType);
		WriteBsonArray(writer, (IEnumerable)flag2);
	}

	private static void WriteBsonCString(BinaryWriter writer, string value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0020: Expected I4, but got Obj
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I4
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I4
		//IL_008f: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_01e1: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryWriter binaryWriter = default;
		binaryWriter.Dispose((byte)(int)memoryStream != 0);
		object obj3 = obj2 + 8;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj4 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(BsonBinaryWriterExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v87 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(BsonBinaryWriterExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v96 (Il2CppClass<Kiloo.Serialization.BsonBinaryWriterExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			object obj6 = obj3 + 1;
			obj3 = obj6;
		}
		object obj7 = obj2 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj2 + obj9;
		obj10 = 81;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
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
			if ((nint)obj13 == 81)
			{
				object obj14 = obj2 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0376;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0376;
		IL_0376:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		object obj18 = default;
		object obj17 = obj18 + 4;
		object obj19 = obj17 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	private static void WriteBsonString(BinaryWriter writer, string value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UTF8Encoding uTF8Encoding = default;
		uTF8Encoding.SetDefaultFallbacks();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	private static void WriteBsonDateTime(BinaryWriter writer, DateTime value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	static BsonBinaryWriterExtensions()
	{
		CompressionExtensions.DEBUG_TAG = "[CompressionExtension]";
	}
}
