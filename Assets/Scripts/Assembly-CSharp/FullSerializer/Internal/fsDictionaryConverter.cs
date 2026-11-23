using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsDictionaryConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_0014: Expected VT, but got Obj
		//IL_0020: Expected I, but got Obj
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IDictionary));
		nint num = (nint)typeFromHandle;
		object obj = typeFromHandle + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v2 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		fsSerializer serializer = Serializer;
		fsMetaType fsMetaType2 = fsMetaType.Get(serializer.Config, storageType);
		return fsMetaType2.CreateInstance();
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Ref, but got Unknown
		//IL_0de9: Expected native int or pointer, but got VT
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_0f53: Expected VT, but got I
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected Obj, but got Unknown
		//IL_0eae: Expected I4, but got VT
		//IL_0ea9: Expected native int or pointer, but got VT
		//IL_0f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8b: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected VT, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected VT, but got Unknown
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Ref, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected VT, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected VT, but got Unknown
		//IL_015b: Expected native int or pointer, but got VT
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected Obj, but got Unknown
		//IL_0e42: Expected VT, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Ref, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected VT, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected VT, but got Unknown
		//IL_023d: Expected native int or pointer, but got VT
		//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fde: Expected Obj, but got Unknown
		//IL_0ff8: Expected native int or pointer, but got VT
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Ref, but got Unknown
		//IL_036a: Expected Obj, but got I
		//IL_036a: Expected Obj, but got I
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected VT, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected VT, but got Unknown
		//IL_031f: Expected native int or pointer, but got VT
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Ref, but got Unknown
		//IL_0460: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I
		//IL_04a0: Expected native int or pointer, but got VT
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected VT, but got Unknown
		//IL_04f8: Expected VT, but got I
		//IL_0421: Expected native int or pointer, but got VT
		//IL_052b: Expected Obj, but got I
		//IL_052b: Expected Obj, but got I
		//IL_052b: Expected Obj, but got VT
		//IL_0555: Expected VT, but got I
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected Obj, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected Obj, but got Unknown
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Obj, but got Unknown
		//IL_0a3f: Expected VT, but got I
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected Obj, but got Unknown
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected Obj, but got Unknown
		//IL_0c68: Expected VT, but got I
		//IL_0999: Expected VT, but got I
		//IL_0c87: Expected VT, but got I
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected Obj, but got Unknown
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected Obj, but got Unknown
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected Obj, but got Unknown
		//IL_0ca6: Expected VT, but got I
		//IL_0cc5: Expected VT, but got I
		//IL_0be2: Expected VT, but got I
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c04: Expected Obj, but got Unknown
		//IL_0d01: Expected VT, but got I
		//IL_0c49: Expected VT, but got I
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 336);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		Type dictionaryType = default;
		GetKeyValueTypes(dictionaryType, out *(Type*)(fsResult2 + 332), out *(Type*)(fsResult2 + 328));
		fsResult fsResult3;
		if (data.IsList)
		{
			List<fsData> asList = data.AsList;
			int num = 0;
			fsResult3 = fsResult.Success;
			IDictionary dictionary = default;
			while (num < asList._size)
			{
				fsData data2 = asList.get_Item(num);
				fsResult fsResult4 = CheckType(data2, fsDataType.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				fsResult fsResult5 = fsResult2 + 72;
				fsResult fsResult6 = (fsResult)(fsResult2 - -64);
				fsResult fsResult7 = fsResult5 + fsResult6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+130]");
				if ((nint)0 == 0)
				{
					goto IL_014b;
				}
				fsResult fsResult8 = CheckKey(data2, "Key", out *(fsData*)(fsResult2 + 324));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				fsResult fsResult9 = fsResult2 + 56;
				fsResult fsResult10 = fsResult2 + 48;
				fsResult fsResult11 = fsResult9 + fsResult10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+130]");
				if ((nint)0 == 0)
				{
					goto IL_022d;
				}
				fsResult fsResult12 = CheckKey(data2, "Value", out *(fsData*)(fsResult2 + 320));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				fsResult fsResult13 = fsResult2 + 40;
				fsResult fsResult14 = fsResult2 + 32;
				fsResult fsResult15 = fsResult13 + fsResult14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+130]");
				if ((nint)0 == 0)
				{
					goto IL_030f;
				}
				_ = 0;
				_ = 0;
				ref object result = ref *(object*)(fsResult2 + 316);
				fsSerializer serializer = Serializer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+144]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+14C]");
				fsResult fsResult16 = serializer.TryDeserialize((fsData)num2, (Type)0, ref result);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				fsResult fsResult17 = fsResult2 + 24;
				fsResult fsResult18 = fsResult2 + 16;
				fsResult fsResult19 = fsResult17 + fsResult18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+130]");
				if ((nint)0 == 0)
				{
					goto IL_0411;
				}
				ref object result2 = ref *(object*)(fsResult2 + 312);
				fsSerializer serializer2 = Serializer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+140]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+148]");
				fsResult fsResult20 = serializer2.TryDeserialize((fsData)num3, (Type)0, ref result2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				((fsResult*)(nint)fsResult2)->_success = false;
				fsResult fsResult21 = fsResult2 + 8;
				fsResult fsResult22 = fsResult21 + fsResult2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+130]");
				bool flag = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				fsResult3 = (fsResult)0;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+13C]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+138]");
				fsResult fsResult23 = ((fsDictionaryConverter)fsResult2).AddItemToDictionary(dictionary, num4, 0);
				int num5 = num + 1;
				num = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
				fsResult3 = (fsResult)0;
			}
		}
		else
		{
			if (!data.IsDictionary)
			{
				goto IL_0db2;
			}
			object obj2 = fsResult2 + 152;
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
			_ = 0;
			object obj3 = fsResult2 + 280;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
			_ = 0;
			fsResult3 = fsResult.Success;
			object obj5 = default;
			object obj6 = default;
			fsResult fsResult25 = default;
			object obj19 = default;
			object obj20 = default;
			object obj22 = default;
			object obj23 = default;
			while (true)
			{
				_ = 0;
				object obj4 = fsResult2 + 280;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj5 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+124]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
						_ = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj6 != null)
									{
										continue;
									}
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+110]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													_ = 0;
													_ = 0;
													object obj7 = fsResult2 + 144;
													object obj8 = fsResult2 + 268;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
															_ = 0;
															object obj9 = fsResult2 + 144;
															object obj10 = fsResult2 + 104;
															object obj11 = fsResult2 + 96;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																_ = 0;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+130]");
																bool flag2 = (nint)0 == 0;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	if (flag2)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																		fsResult3 = (fsResult)0;
																		goto IL_0fcb;
																	}
																	_ = 0;
																	object obj12 = fsResult2 + 144;
																	object obj13 = fsResult2 + 264;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																			_ = 0;
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																			_ = 0;
																			object obj14 = fsResult2 + 144;
																			object obj15 = fsResult2 + 88;
																			object obj16 = fsResult2 + 80;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																				_ = 0;
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+100]");
																				bool flag3 = (nint)0 == 0;
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																					fsResult3 = (fsResult)0;
																					if (flag3)
																					{
																						goto IL_0fcb;
																					}
																					_ = 0;
																					object obj17 = fsResult2 + 144;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																						fsResult3 = (fsResult)0;
																						continue;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																					fsResult3 = (fsResult)0;
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																					fsResult3 = (fsResult)0;
																				}
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																				fsResult3 = (fsResult)0;
																			}
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																			fsResult3 = (fsResult)0;
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																		fsResult3 = (fsResult)0;
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+90]");
																	fsResult3 = (fsResult)0;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												goto IL_0d06;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								goto IL_0d06;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				goto IL_0d06;
				IL_0fcb:
				object obj18 = fsResult2 + 152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1915");
				fsResult fsResult24 = fsResult25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+130]");
				((fsResult*)(nint)fsResult24)->_success = false;
				goto IL_0f46;
				IL_0d06:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj19 != obj20;
				object obj21 = obj22;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_0d95;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj21 = obj23;
				}
				_ = 0;
				object obj24 = fsResult2 + 152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				fsResult25 = (fsResult)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				goto IL_0fcb;
			}
			object obj25 = fsResult2 + 152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1915");
		}
		fsResult fsResult26 = default;
		((fsResult*)(nint)fsResult26)->_success = (byte)(int)fsResult3 != 0;
		goto IL_0f46;
		IL_0d95:
		object obj26 = fsResult2 + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1915");
		goto IL_0db2;
		IL_0db2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 1;
		fsDataType[] types = default;
		fsResult fsResult27 = FailExpectedType(data, types);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
		((fsResult*)(nint)fsResult26)->_success = false;
		goto IL_0f46;
		IL_030f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
		((fsResult*)(nint)fsResult26)->_success = false;
		goto IL_0f46;
		IL_014b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
		((fsResult*)(nint)fsResult26)->_success = false;
		goto IL_0f46;
		IL_0411:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
		((fsResult*)(nint)fsResult26)->_success = false;
		goto IL_0f46;
		IL_022d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+98]");
		((fsResult*)(nint)fsResult26)->_success = false;
		goto IL_0f46;
		IL_0f46:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		return (fsResult)0;
	}

	public unsafe override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Ref, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Ref, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Ref, but got Unknown
		//IL_00e4: Expected Obj, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected VT, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected VT, but got Unknown
		//IL_0177: Expected VT, but got I
		//IL_04c3: Expected I4, but got VT
		//IL_04be: Expected native int or pointer, but got VT
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Ref, but got Unknown
		//IL_01bc: Expected Obj, but got I
		//IL_0416: Expected Obj, but got I
		//IL_043c: Expected Obj, but got I
		//IL_01fc: Expected native int or pointer, but got VT
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected VT, but got Unknown
		//IL_0382: Expected Obj, but got I
		//IL_0259: Expected VT, but got I
		//IL_027c: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02d0: Expected VT, but got I
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 96);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		ref fsData reference = ref *(fsData*)fsData.Null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		Type dictionaryType = default;
		GetKeyValueTypes(dictionaryType, out *(Type*)(fsResult2 + 92), out *(Type*)(fsResult2 + 88));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		List<fsData> list = default;
		int capacity = default;
		list._002Ector(capacity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		List<fsData> list2 = default;
		int capacity2 = default;
		list2._002Ector(capacity2);
		object obj2 = 1;
		fsResult fsResult3 = fsResult.Success;
		object obj3 = default;
		object instance = default;
		object instance2 = default;
		fsData fsData8 = default;
		object value = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				ref fsData data = ref *(fsData*)(fsResult2 + 84);
				fsSerializer serializer = Serializer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+5C]");
				fsResult fsResult4 = serializer.TrySerialize((Type)0, instance, out data);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				_ = 0;
				fsResult fsResult5 = fsResult2 + 24;
				fsResult fsResult6 = fsResult2 + 16;
				fsResult fsResult7 = fsResult5 + fsResult6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+48]");
				bool flag = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				fsResult3 = (fsResult)0;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				ref fsData data2 = ref *(fsData*)(fsResult2 + 80);
				fsSerializer serializer2 = Serializer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+58]");
				fsResult fsResult8 = serializer2.TrySerialize((Type)0, instance2, out data2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				((fsResult*)(nint)fsResult2)->_success = false;
				fsResult fsResult9 = fsResult2 + 8;
				fsResult fsResult10 = fsResult9 + fsResult2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+48]");
				bool flag2 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				fsResult3 = (fsResult)0;
				if (flag2)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+54]");
				list.Add((fsData)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
				list2.Add((fsData)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+54]");
				bool isString = ((fsData)0).IsString;
				object obj4 = isString & obj2;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
				fsResult3 = (fsResult)0;
				continue;
			}
			object obj5 = obj2 & 1;
			if (obj5 != null)
			{
				fsData fsData2 = fsData.CreateDictionary();
				reference = ref *(fsData*)fsData2;
				Dictionary<string, fsData> asDictionary = serialized.AsDictionary;
				int num = 0;
				while (num < list._size)
				{
					fsData fsData3 = list.get_Item(num);
					fsData fsData4 = list2.get_Item(num);
					string asString = fsData3.AsString;
					nint num2 = 0;
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S5_v17 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v372 @ S5_v18+4] (should have been resolved before IL gen)");
					int num4 = num + 1;
					num = num4;
				}
				break;
			}
			fsData fsData5 = fsData.CreateList(list._size);
			reference = ref *(fsData*)fsData5;
			List<fsData> asList = serialized.AsList;
			int num5 = 0;
			while (num5 < list._size)
			{
				fsData fsData6 = list.get_Item(num5);
				fsData fsData7 = list2.get_Item(num5);
				nint num6 = 0;
				nint num7 = 0;
				IntPtr intPtr = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v385 @ S4_v7 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>>)+4] (should have been resolved before IL gen)");
				nint num8 = 0;
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S5_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v401 @ S5_v7+4] (should have been resolved before IL gen)");
				nint num10 = 0;
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S5_v11 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v416 @ S5_v12+4] (should have been resolved before IL gen)");
				fsData8._value = value;
				asList.Add(fsData8);
				int num12 = num5 + 1;
				num5 = num12;
			}
			break;
		}
		fsResult fsResult11 = default;
		((fsResult*)(nint)fsResult11)->_success = (byte)(int)fsResult3 != 0;
		return fsResult11;
	}

	private unsafe fsResult AddItemToDictionary(IDictionary dictionary, object key, object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01c1: Expected I4, but got VT
		//IL_01bc: Expected native int or pointer, but got VT
		//IL_003b: Expected VT, but got Obj
		//IL_00e7: Expected I, but got Obj
		//IL_00d5: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = key;
		if (value == null)
		{
			obj3 = null;
		}
		fsResult fsResult3 = default;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ICollection<>));
			Type type2 = default;
			Type type = fsReflectionUtility.GetInterface(type2, typeFromHandle);
			if ((object)type != null)
			{
				nint num = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S1_v15 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj4 = default;
			string text = default;
			if (obj4 != null)
			{
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S1_v41+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string warning = text + " does not extend ICollection";
			fsResult fsResult2 = fsResult.Warn(warning);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
		}
		return fsResult3;
	}

	private unsafe static void GetKeyValueTypes(Type dictionaryType, out Type keyStorageType, out Type valueStorageType)
	{
		//IL_00b7: Expected VT, but got Obj
		//IL_0076: Expected VT, but got Obj
		//IL_0096: Expected VT, but got Obj
		//IL_002a: Expected I, but got Obj
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IDictionary<, >));
		Type type = fsReflectionUtility.GetInterface(dictionaryType, typeFromHandle);
		Type type2;
		if ((object)type != null)
		{
			nint num = (nint)type;
			object obj = type + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S3_v6 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S2_v8+10]");
			ref Type reference = ref *(Type*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S2_v8+14]");
			type2 = (Type)0;
		}
		else
		{
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(object));
			ref Type reference = ref *(Type*)typeFromHandle2;
			type2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(object));
		}
		ref Type reference2 = ref *(Type*)type2;
	}
}
