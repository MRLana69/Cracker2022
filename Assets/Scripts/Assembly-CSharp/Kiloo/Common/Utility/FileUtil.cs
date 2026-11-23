using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public static class FileUtil
{
	public static void ReadFully(Stream s, byte[] buffer)
	{
		//IL_0017: Expected I4, but got Obj
		ReadFully(s, buffer, (int)buffer, buffer.Length);
	}

	public static void ReadFully(Stream s, byte[] buffer, int offset, int count)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0016: Expected I, but got Obj
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I4, but got Unknown
		object obj = 0;
		int num = default;
		object obj2 = default;
		int num3 = default;
		EndOfStreamException ex = default;
		while (num >= 1)
		{
			nint num2 = (nint)s;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S4_v4 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
			if (obj2 != null)
			{
				object obj3 = obj + obj2;
				num = num3 - obj2;
				obj = obj3;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			break;
		}
	}

	public static void WriteAllBytes(string filename, byte[] bytes)
	{
		//IL_001f: Expected I, but got Obj
		//IL_0031: Expected I, but got Obj
		FileStream fileStream = default;
		fileStream._002Ector(filename, FileMode.Create);
		nint num = (nint)fileStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S4_v2 (Il2CppClass<System.IO.FileStream>)+1CC] (should have been resolved before IL gen)");
		nint num2 = (nint)fileStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S1_v5 (Il2CppClass<System.IO.FileStream>)+14C] (should have been resolved before IL gen)");
	}

	public static byte[] ReadAllBytes(string filename)
	{
		//IL_005a: Expected I, but got Obj
		FileInfo fileInfo = default;
		fileInfo._002Ector(filename);
		long length = fileInfo.Length;
		if (length >= 2147483648L)
		{
			OverflowException ex = new OverflowException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		FileStream fileStream = fileInfo.OpenRead();
		byte[] array = default;
		ReadFully(fileStream, array);
		nint num = (nint)fileStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S1_v10 (Il2CppClass<System.IO.FileStream>)+14C] (should have been resolved before IL gen)");
		return array;
	}

	public static void SetLastWriteTimeUtc(FileInfo fileInfo, DateTime time)
	{
		fileInfo.LastWriteTimeUtc = time;
	}

	public static DateTime GetLastWriteTimeUtc(FileInfo fileInfo)
	{
		return fileInfo.LastWriteTimeUtc;
	}

	public static bool ArraysAreEqual<T>(T[] a, T[] b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0193: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = (object)a | (object)b;
		bool flag = obj3 == null;
		bool flag2 = a == null;
		bool result = flag;
		if (!flag2)
		{
			bool flag3 = b == null;
			result = flag;
			if (!flag3)
			{
				bool flag4 = a.Length != b.Length;
				object obj4 = a.Length;
				bool flag5 = false;
				result = false;
				if (!flag4)
				{
					object obj9 = default;
					while ((flag5 ? 1 : 0) < (nint)obj4)
					{
						object obj5 = a + flag5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v12+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
						object obj6 = obj + 15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object obj7 = b + flag5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v18+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
						object obj8 = obj + 14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
						if (obj9 == null)
						{
							break;
						}
						bool flag6 = (byte)((flag5 ? 1u : 0u) + 1u) != 0;
						obj4 = a.Length;
						flag5 = flag6;
					}
					bool flag7 = (flag5 ? 1 : 0) >= (nint)obj4;
					result = flag7;
				}
			}
		}
		return result;
	}

	public static Dictionary<E, int> ReadEnumIntDictionary<E>(BinaryReader reader)
	{
		//IL_00ca: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0016: Expected VT, but got I
		//IL_0023: Expected Obj, but got I4
		//IL_0030: Expected I, but got Obj
		//IL_0042: Expected I, but got Obj
		nint num = (nint)reader;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<System.IO.BinaryReader>)+134] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v2 (Il2CppMethodRgctx<Kiloo.Common.Utility.FileUtil::ReadEnumIntDictionary>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S3_v3+4] (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v12 (Il2CppMethodRgctx<Kiloo.Common.Utility.FileUtil::ReadEnumIntDictionary>)+8]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		object obj2 = 0;
		object obj3 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			nint num5 = (nint)reader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S1_v11 (Il2CppClass<System.IO.BinaryReader>)+16C] (should have been resolved before IL gen)");
			nint num6 = (nint)reader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ S1_v14 (Il2CppClass<System.IO.BinaryReader>)+134] (should have been resolved before IL gen)");
			string value = default;
			object obj4 = Enum.Parse(typeFromHandle, value, ignoreCase: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			throw new NullReferenceException();
		}
		Dictionary<E, int> result = default;
		return result;
	}

	public static void WriteEnumIntDictionary<E>(BinaryWriter writer, IDictionary<E, int> dict)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0689: Expected I, but got Obj
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		nint num = (nint)writer;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S2_v5 (Il2CppClass<System.IO.BinaryWriter>)+13C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 28;
		obj = obj3;
		_ = 0;
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj4 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						nint num2 = 0;
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
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
									obj = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													if (obj5 == null)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				goto IL_06bb;
																			}
																		}
																	}
																}
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
													else
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	continue;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												goto IL_052b;
											}
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
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_052b;
					}
				}
				goto IL_06bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_052b;
			IL_06bb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_052b;
			IL_052b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 == obj7;
			bool flag2 = !flag;
			object obj8 = obj9;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	public static Dictionary<E, string> ReadEnumStringDictionary<E>(BinaryReader reader)
	{
		//IL_00e3: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_0016: Expected VT, but got I
		//IL_0023: Expected Obj, but got I4
		//IL_0030: Expected I, but got Obj
		//IL_0042: Expected I, but got Obj
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		nint num = (nint)reader;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<System.IO.BinaryReader>)+134] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v2 (Il2CppMethodRgctx<Kiloo.Common.Utility.FileUtil::ReadEnumStringDictionary>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S3_v3+4] (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v12 (Il2CppMethodRgctx<Kiloo.Common.Utility.FileUtil::ReadEnumStringDictionary>)+8]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		object obj2 = 0;
		object obj3 = default;
		object value = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			nint num5 = (nint)reader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S1_v11 (Il2CppClass<System.IO.BinaryReader>)+16C] (should have been resolved before IL gen)");
			nint num6 = (nint)reader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S1_v14 (Il2CppClass<System.IO.BinaryReader>)+16C] (should have been resolved before IL gen)");
			if (Enum.IsDefined(typeFromHandle, value))
			{
				object obj4 = Enum.Parse(typeFromHandle, (string)value, ignoreCase: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				throw new NullReferenceException();
			}
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
		Dictionary<E, string> result = default;
		return result;
	}

	public static void WriteEnumStringDictionary<E>(BinaryWriter writer, IDictionary<E, string> dict)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0689: Expected I, but got Obj
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		nint num = (nint)writer;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S2_v5 (Il2CppClass<System.IO.BinaryWriter>)+13C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 28;
		obj = obj3;
		_ = 0;
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj4 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						nint num2 = 0;
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
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
									obj = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													if (obj5 == null)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				goto IL_06bb;
																			}
																		}
																	}
																}
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
													else
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	continue;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												goto IL_052b;
											}
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
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_052b;
					}
				}
				goto IL_06bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_052b;
			IL_06bb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_052b;
			IL_052b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 == obj7;
			bool flag2 = !flag;
			object obj8 = obj9;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	public static Dictionary<string, string> ReadStringStringDictionary(BinaryReader reader)
	{
		//IL_0077: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I4
		//IL_000d: Expected I, but got Obj
		//IL_001f: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		nint num = (nint)reader;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<System.IO.BinaryReader>)+134] (should have been resolved before IL gen)");
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		object obj = 0;
		object obj2 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			nint num4 = (nint)reader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S2_v6 (Il2CppClass<System.IO.BinaryReader>)+16C] (should have been resolved before IL gen)");
			nint num5 = (nint)reader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S3_v10 (Il2CppClass<System.IO.BinaryReader>)+16C] (should have been resolved before IL gen)");
			nint num6 = 0;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S5_v5+4] (should have been resolved before IL gen)");
			object obj4 = obj + 1;
			obj = obj4;
		}
		Dictionary<string, string> result = default;
		return result;
	}

	public static void WriteStringStringDictionary(BinaryWriter writer, IDictionary<string, string> dict)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e0: Expected I, but got Obj
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		nint num = (nint)writer;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S2_v4 (Il2CppClass<System.IO.BinaryWriter>)+13C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 28;
		obj = obj3;
		_ = 0;
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj4 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_018c;
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
			goto IL_018c;
			IL_018c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj5 == obj6;
			bool flag2 = !flag;
			object obj7 = obj8;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj7 = obj9;
			}
			_ = 0;
			object obj10 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj11 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	private unsafe static int GetSlotForPath(string path)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string extension = Path.GetExtension(path);
		object obj3;
		if (extension != null)
		{
			obj3 = 0;
			if (extension._stringLength != 0)
			{
				goto IL_00cf;
			}
		}
		obj3 = 1;
		goto IL_00cf;
		IL_00cf:
		bool flag = obj3 == null;
		bool flag2 = !flag;
		int result = -1;
		if (!flag2)
		{
			string s = extension.Substring(1);
			bool flag3 = int.TryParse(s, out *(int*)(obj + 12));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			int num = 0;
			if (!flag3)
			{
				num = -1;
			}
			result = num;
		}
		return result;
	}

	public static FileInfo[] GetFilesForPath(string path, bool slotsOnly = false)
	{
		//IL_001f: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		string directoryName = Path.GetDirectoryName(path);
		DirectoryInfo directoryInfo = default;
		directoryInfo._002Ector(directoryName);
		nint num = (nint)directoryInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S1_v6 (Il2CppClass<System.IO.DirectoryInfo>)+10C] (should have been resolved before IL gen)");
		object obj = default;
		if (obj != null)
		{
			string fileName = Path.GetFileName(path);
			object obj2 = ".*";
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			if ((nint)0 == 0)
			{
				obj2 = "*";
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
			string searchPattern = (string)0 + (string)obj2;
			FileInfo[] files = directoryInfo.GetFiles(searchPattern);
			if (files.Length >= 1)
			{
				throw new ArgumentException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		FileInfo[] result = default;
		return result;
	}

	private static int GetMostRecentSlot(string path, bool fixTimestamps)
	{
		//IL_01b4: Expected I, but got Obj
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		string path2 = default;
		FileInfo[] filesForPath = GetFilesForPath(path2);
		if (filesForPath.Length < 1)
		{
			return -1;
		}
		FileInfo fileInfo = filesForPath[0];
		if (fixTimestamps)
		{
			DateTime utcNow = CDateTime.UtcNow;
			DateTime lastWriteTimeUtc = GetLastWriteTimeUtc(fileInfo);
			if (lastWriteTimeUtc > utcNow)
			{
				DateTime lastWriteTimeUtc2 = GetLastWriteTimeUtc(fileInfo);
				TimeSpan timeSpan = lastWriteTimeUtc2 - utcNow;
				TimeSpan timeSpan2 = TimeSpan.FromMinutes(1.0);
				TimeSpan timeSpan3 = timeSpan + timeSpan2;
				path2 = null;
				while ((nint)path2 < filesForPath.Length)
				{
					object obj = (object)path2 << 2;
					object obj2 = (object)filesForPath + obj;
					object obj3 = (object)path2 << 2;
					object obj4 = (object)filesForPath + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v44+10]");
					DateTime lastWriteTimeUtc3 = GetLastWriteTimeUtc((FileInfo)0);
					DateTime time = lastWriteTimeUtc3 - timeSpan3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v41+10]");
					SetLastWriteTimeUtc((FileInfo)0, time);
					string text = path2 + 1;
					path2 = text;
				}
			}
		}
		nint num = (nint)fileInfo;
		object obj5 = fileInfo + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S1_v6 (Il2CppClass<System.IO.FileInfo>)+104] (should have been resolved before IL gen)");
		string path3 = default;
		return GetSlotForPath(path3);
	}

	private static byte[] TryLoadFile(string path, byte[] secretBytes = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0291: Expected Obj, but got I4
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected Obj, but got Unknown
		//IL_06f9: Expected Obj, but got I
		//IL_0724: Expected Obj, but got I
		//IL_0749: Expected Obj, but got I
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected Obj, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_09ec: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I4
		//IL_04c3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		object obj3 = obj + 16;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		byte[] array;
		object obj7;
		object obj5;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj4 = obj + 28;
				obj = obj4;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								object obj6 = default;
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag = (nint)0 == 1;
									array = null;
									if (!flag)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag2 = (nint)0 == 1;
										byte[] array2 = default;
										array = array2;
										if (!flag2)
										{
											obj5 = obj6;
											array = array2;
											goto IL_0360;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									array = null;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								obj5 = obj6;
								object obj8 = default;
								obj7 = obj8;
								goto IL_02e0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							array = null;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							array = null;
						}
						goto IL_027e;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				array = null;
				goto IL_027e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_060a;
		IL_0360:
		_ = 0;
		object obj9 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		byte[] array3 = default;
		if ((nint)0 != 1)
		{
			bool flag3 = array3 == null;
			byte[] array4 = array;
			if (flag3)
			{
				goto IL_0538;
			}
			object obj10 = array3.Length + array.Length;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 != 1;
					byte[] array5 = default;
					array4 = array5;
					if (flag4)
					{
						goto IL_0538;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					array3 = (byte[])0;
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
		goto IL_060a;
		IL_09b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_09fb;
		IL_060a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj11 = default;
		obj7 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		goto IL_097f;
		IL_097f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj14 = default;
		byte[] array6;
		object obj26;
		if (obj14 == obj12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 == 1;
			byte[] array7 = default;
			array6 = array7;
			if (!flag5)
			{
				object obj16 = default;
				object obj15 = obj16;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 == 1;
				byte[] array8 = default;
				array6 = array8;
				if (!flag6)
				{
					if (array8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj17 = (nint)0 << 2;
						object obj18 = obj3 + obj17;
						obj18 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj19 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj20 = (nint)0 << 2;
						object obj21 = obj20 + obj3;
						object obj22 = obj21 - 4;
						object obj23 = obj22;
						bool flag7 = obj22 == null;
						string text = null;
						string text2 = "FileUtil.TryLoadFile: ";
						if (!flag7)
						{
							object obj24 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v627 @ S1_v52+D4] (should have been resolved before IL gen)");
							string text3 = default;
							text = text3;
							text2 = "FileUtil.TryLoadFile: ";
						}
						string text4 = text2 + text;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj25 = -1;
						array3 = null;
						goto IL_09fb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					byte[] array9 = (byte[])obj16;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag8 = (nint)0 != 1;
					array6 = array9;
					array3 = array9;
					obj26 = obj7;
					if (flag8)
					{
						goto IL_08d0;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag9 = (nint)0 != 1;
			object obj27 = default;
			obj26 = obj27;
			array3 = array6;
			obj7 = obj27;
			if (!flag9)
			{
				goto IL_08a0;
			}
		}
		goto IL_09b5;
		IL_0538:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			byte[] array11 = default;
			if ((nint)0 != 1)
			{
				byte[] array10 = array;
				if (array11 == null)
				{
					array10 = null;
				}
				array3 = array10;
				goto IL_09fb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			array3 = array11;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			byte[] array12 = default;
			array3 = array12;
		}
		goto IL_060a;
		IL_09fb:
		return array3;
		IL_08d0:
		obj7 = obj26;
		goto IL_09b5;
		IL_02e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj28 = default;
		object obj29 = default;
		bool flag10 = obj28 != obj29;
		obj12 = obj29;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0360;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj30 = default;
			obj7 = obj30;
			object obj31 = default;
			obj12 = obj31;
		}
		_ = 0;
		object obj32 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			array6 = array3;
			obj26 = obj7;
			goto IL_08a0;
		}
		goto IL_097f;
		IL_08a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		array3 = array6;
		goto IL_08d0;
		IL_027e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		obj5 = 0;
		object obj33 = default;
		obj7 = obj33;
		goto IL_02e0;
	}

	public static byte[] Load(string path, string secret = null, string alternatePath = null, bool useLastModifiedPathIfNoSlots = false)
	{
		//IL_0413: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I4
		//IL_0033: Expected I, but got Obj
		//IL_006d: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I4
		ArgumentNullException result2;
		if (path != null)
		{
			if (secret != null)
			{
				Encoding uTF = Encoding.UTF8;
				nint num = (nint)uTF;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S2_v43 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
			}
			bool flag = alternatePath != null;
			bool flag2 = flag & useLastModifiedPathIfNoSlots;
			FileInfo[] filesForPath = GetFilesForPath(path, flag2);
			object obj = 0;
			object obj2 = 0;
			string path2 = default;
			byte[] secretBytes = default;
			string path3 = default;
			while (true)
			{
				byte[] result;
				if (filesForPath.Length > (nint)obj2)
				{
					object obj3 = obj2 << 2;
					object obj4 = (object)filesForPath + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v126+10]");
					object obj5 = 0;
					object obj6 = obj5 - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S1_v62+BC] (should have been resolved before IL gen)");
					byte[] array = TryLoadFile(path2, secretBytes);
					result = array;
					if (array == null)
					{
						object obj7 = obj2 + 1;
						obj = 1;
						obj2 = obj7;
						continue;
					}
					goto IL_0340;
				}
				if (alternatePath == null)
				{
					break;
				}
				FileInfo[] filesForPath2 = GetFilesForPath(alternatePath, flag2);
				object obj8 = 0;
				while ((nint)obj8 < filesForPath2.Length)
				{
					object obj9 = obj8 << 2;
					object obj10 = (object)filesForPath2 + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v118+10]");
					object obj11 = 0;
					object obj12 = obj11 - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ S1_v54+BC] (should have been resolved before IL gen)");
					byte[] array2 = TryLoadFile(path3, secretBytes);
					result = array2;
					if (array2 == null)
					{
						object obj13 = obj8 + 1;
						obj = 1;
						obj8 = obj13;
						continue;
					}
					goto IL_0340;
				}
				break;
				IL_0340:
				return result;
			}
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				FileInfo fileInfo = default;
				fileInfo._002Ector(path);
				throw new ArrayTypeMismatchException();
			}
			object obj14 = obj & 1;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				FileNotFoundException ex = default;
				ex._002Ector();
				result2 = (ArgumentNullException)(object)ex;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				IOException ex2 = default;
				ex2._002Ector("File is corrupt along with all redundant files");
				result2 = (ArgumentNullException)(object)ex2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentNullException ex3 = default;
			ex3._002Ector("path");
			result2 = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte[])(object)result2;
	}

	public unsafe static void Save(string path, byte[] data, string secret = null, int offset = 0, int length = -1, int redundancy = 0, int slots = 0, string alternatePath = null, int alternateRedundancy = 0, int alternateSlots = 0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_013e: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_0d25: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got I
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected I4, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected Obj, but got Unknown
		//IL_0277: Expected Obj, but got I4
		//IL_032b: Expected Obj, but got I4
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_0346: Expected Obj, but got I
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Expected I4, but got Unknown
		//IL_0e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Expected Obj, but got Unknown
		//IL_036b: Expected Obj, but got I4
		//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df2: Expected Obj, but got Unknown
		//IL_08fd: Expected Obj, but got I
		//IL_0928: Expected Obj, but got I
		//IL_0968: Expected Obj, but got I
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected Obj, but got Unknown
		//IL_0d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9b: Expected Obj, but got Unknown
		//IL_09c1: Expected Obj, but got I4
		//IL_09c1: Expected Obj, but got I
		//IL_0630: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 24;
		_ = 0;
		int num = default;
		object obj5;
		ArgumentNullException ex2;
		if (data != null)
		{
			if (path != null)
			{
				if (offset > -1)
				{
					if (num == -1)
					{
						bool flag = offset < 1;
						num = data.Length;
						if (!flag)
						{
							int num2 = data.Length - offset;
							num = num2;
						}
					}
					if (num >= 0)
					{
						object obj4 = offset + num;
						if (data.Length >= (nint)obj4)
						{
							if (secret != null)
							{
								obj5 = 0;
								if (secret._stringLength != 0)
								{
									goto IL_0bec;
								}
							}
							obj5 = 1;
							goto IL_0bec;
						}
					}
					goto IL_0bdd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ArgumentOutOfRangeException ex = default;
				ex._002Ector("offset");
				ex2 = (ArgumentNullException)(object)ex;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ArgumentNullException ex3 = default;
				ex3._002Ector("path");
				ex2 = ex3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentNullException ex4 = default;
			ex4._002Ector("data");
			ex2 = ex4;
		}
		goto IL_0b62;
		IL_0bdd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ArgumentOutOfRangeException ex5 = default;
		ex5._002Ector("length");
		ex2 = (ArgumentNullException)(object)ex5;
		goto IL_0b62;
		IL_0b62:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return;
		IL_0bec:
		bool flag2 = obj5 == null;
		bool flag3 = !flag2;
		byte[] data2 = data;
		int num5 = default;
		if (!flag3)
		{
			Encoding uTF = Encoding.UTF8;
			nint num3 = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ S2_v73 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
			int num4 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v318 (System.Array)+C]");
			object obj6 = (nint)num4 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v318 (System.Array)+C]");
			Array sourceArray = default;
			Array array = default;
			Array.Copy(sourceArray, array, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v318 (System.Array)+C]");
			Array.Copy(data, offset, array, 0, num);
			num5 = 0;
			data2 = (byte[])array;
		}
		byte[] array2 = Checksum.ComputeSHA1(data2);
		int num6 = default;
		string text = (string)(num6 + 1);
		object obj7 = alternateRedundancy + 1;
		string text2 = text + obj7;
		string text3 = default;
		if (text3 == null)
		{
			text2 = text;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		bool flag4 = num6 <= 0;
		int num7 = default;
		if (num7 >= 1)
		{
			flag4 = false;
		}
		if (!flag4)
		{
			int mostRecentSlot = GetMostRecentSlot(path, fixTimestamps: true);
			string text4 = null;
			object obj8 = default;
			if (num6 >= (nint)obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj9 = (nint)0 + (nint)1;
				if (num7 <= (nint)obj9)
				{
					obj9 = 0;
				}
				int num8 = obj + 44;
				string text5 = ((int*)num8)->ToString();
				string text6 = path + "." + text5;
				throw new ArrayTypeMismatchException();
			}
			if (text3 != null)
			{
				bool flag5 = alternateRedundancy <= 0;
				if (alternateSlots >= 1)
				{
					flag5 = false;
				}
				if (flag5)
				{
					throw new ArrayTypeMismatchException();
				}
				int mostRecentSlot2 = GetMostRecentSlot(text3, fixTimestamps: true);
				obj8 = 0;
				if (alternateRedundancy >= (nint)obj8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					object obj10 = (nint)0 + (nint)1;
					if ((nint)obj10 >= alternateSlots)
					{
						obj10 = 0;
					}
					int num9 = obj + 40;
					string text7 = ((int*)num9)->ToString();
					string text8 = text3 + "." + text7;
					throw new ArrayTypeMismatchException();
				}
			}
			IOException ex6 = null;
			object obj11 = 0;
			object obj14 = default;
			object obj16 = default;
			object obj17 = default;
			object obj19 = default;
			object obj20 = default;
			object obj21 = default;
			object obj23 = default;
			object obj24 = default;
			IOException ex8 = default;
			object obj27 = default;
			object obj29 = default;
			object obj30 = default;
			int num11 = default;
			object obj42 = default;
			object obj44 = default;
			object obj45 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v48+C]");
				int num10;
				IOException ex7;
				object obj18;
				if (0 > (nint)obj11)
				{
					object obj12 = obj11 << 2;
					object obj13 = obj14 + obj12;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj15 = obj + 36;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag6 = (nint)0 == 1;
												num5 = num;
												if (!flag6)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag7 = (nint)0 != 1;
													num5 = num;
													num6 = 33;
													num10 = num;
													ex7 = (IOException)1;
													if (flag7)
													{
														goto IL_0d87;
													}
												}
											}
										}
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							bool flag8 = obj16 != obj17;
							obj18 = obj16;
							obj8 = obj19;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									num6 = 0;
									obj8 = obj19;
									num10 = num5;
									ex7 = ex6;
									goto IL_0d87;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								obj18 = obj20;
								obj8 = obj21;
							}
							_ = 0;
							object obj22 = obj + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_0e5f;
							}
							goto IL_0e88;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj18 = obj23;
					obj8 = obj24;
					goto IL_0e5f;
				}
				object obj25 = ex6 & 1;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					ex8._002Ector("All attempts to write failed");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
					ex6 = ex8;
					goto IL_0e27;
				}
				return;
				IL_0e88:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
				IL_0e27:
				if (num6 != 33)
				{
					return;
				}
				goto IL_0e44;
				IL_0e44:
				object obj26 = obj11 + 1;
				obj11 = obj26;
				continue;
				IL_0e5f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				if (obj27 == obj18)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj28 = obj29;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj30 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
								object obj31 = (nint)0 << 2;
								object obj32 = obj3 + obj31;
								obj32 = obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
								object obj33 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								object obj34 = obj11 << 2;
								object obj35 = obj14 + obj34;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
								object obj36 = (nint)0 << 2;
								object obj37 = obj36 + obj3;
								object obj38 = obj37 - 4;
								object obj39 = obj38;
								object obj40 = obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v882 @ S1_v95+E4] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ S0_v149+10]");
								string text9 = "Error saving file: " + (string)0 + ": " + (string)num11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
								int num12 = (int)(-1);
								num6 = num12;
								goto IL_0e44;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj41 = obj29;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								break;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag9 = (nint)0 == 1;
					obj8 = obj42;
					if (flag9)
					{
						goto IL_0e88;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				goto IL_0e88;
				IL_0d87:
				_ = 0;
				object obj43 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					ex6 = ex7;
					num5 = num10;
					if (num6 == 0)
					{
						ex6 = ex7;
						num5 = num10;
						goto IL_0e44;
					}
					goto IL_0e27;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj18 = obj44;
				ex6 = ex7;
				obj8 = obj45;
				num5 = num10;
				goto IL_0e5f;
			}
			goto IL_0bdd;
		}
		throw new ArrayTypeMismatchException();
	}

	public static void LogError(string msg)
	{
	}

	public static void LogWarning(string msg)
	{
	}

	public static void Log(string msg)
	{
	}
}
