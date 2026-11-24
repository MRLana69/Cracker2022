using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class TypeListAttribute : Attribute
{
	public Type[] Types
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0d: Expected Obj, but got Unknown
			//IL_0d16: Expected Obj, but got I4
			//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d30: Expected Obj, but got Unknown
			//IL_0d39: Expected Obj, but got I4
			//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d47: Expected Obj, but got Unknown
			//IL_0d9b: Expected I4, but got Obj
			//IL_009d: Expected Obj, but got I4
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bb: Expected Obj, but got Unknown
			//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dbc: Expected Obj, but got Unknown
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Expected Obj, but got Unknown
			//IL_0bb4: Expected Obj, but got I
			//IL_0c97: Expected I4, but got Obj
			//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bef: Expected Obj, but got Unknown
			//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c25: Expected Obj, but got Unknown
			//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b03: Expected Obj, but got Unknown
			//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b11: Expected Obj, but got Unknown
			//IL_0b3d: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 40;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			object obj5 = obj2 + 32;
			obj5 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.TypeListAttribute)+10]");
			string format = (((nint)0 == 0) ? "[{0}...\n(\n" : "[{0} (");
			string text = string.Format(format, field);
			string text2 = string.ConcatArray((string[])(object)"", (int)text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			string text3 = text2;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			object obj12 = default;
			string text4 = default;
			string text5 = default;
			string text6 = default;
			string text7 = default;
			string text8 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj9 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							goto IL_0dae;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				goto IL_0dae;
				IL_0dae:
				obj10++;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj11 = obj12 - 1;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.TypeListAttribute)+10]");
					if ((nint)0 != 0)
					{
						text4 = text5;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					}
					text6 = text5;
				}
				else
				{
					text4 = text7;
				}
				text8 = text7;
				text3 = text4;
			}
			object obj13 = 50;
			object obj14 = obj13 - 7;
			object obj21;
			object obj22 = default;
			if ((nint)obj13 != 7 && (nint)obj14 != 1)
			{
				if ((nint)obj14 == 2 || (nint)obj14 == 3 || (nint)obj14 == 4)
				{
					goto IL_0de7;
				}
				if ((nint)obj14 != 5)
				{
					if ((nint)obj14 == 6 || (nint)obj14 == 7 || (nint)obj14 == 8 || (nint)obj14 == 9)
					{
						goto IL_0de7;
					}
					if ((nint)obj14 != 10)
					{
						if ((nint)obj14 != 11)
						{
							if ((nint)obj14 != 12)
							{
								if ((nint)obj14 == 13 || (nint)obj14 == 14 || (nint)obj14 == 15 || (nint)obj14 == 16)
								{
									goto IL_0de7;
								}
								if ((nint)obj14 != 17)
								{
									if ((nint)obj14 != 18)
									{
										if ((nint)obj14 != 19)
										{
											if ((nint)obj14 != 20)
											{
												if ((nint)obj14 == 21 || (nint)obj14 == 22 || (nint)obj14 == 23 || (nint)obj14 == 24 || (nint)obj14 == 25 || (nint)obj14 == 26)
												{
													goto IL_0de7;
												}
												if ((nint)obj14 != 27)
												{
													if ((nint)obj14 != 28)
													{
														if ((nint)obj14 != 29)
														{
															if ((nint)obj14 != 30)
															{
																if ((nint)obj14 != 31)
																{
																	if ((nint)obj14 == 32 || (nint)obj14 == 33)
																	{
																		goto IL_0de7;
																	}
																	if ((nint)obj14 != 34)
																	{
																		if ((nint)obj14 == 35 || (nint)obj14 == 36 || (nint)obj14 == 37 || (nint)obj14 == 38 || (nint)obj14 == 39)
																		{
																			goto IL_0de7;
																		}
																		if ((nint)obj14 != 40)
																		{
																			if ((nint)obj14 != 41)
																			{
																				if ((nint)obj14 != 42)
																				{
																					if ((nint)obj14 == 43)
																					{
																						object obj15 = obj5 + 4;
																						object obj16 = obj15 + 1;
																						obj15 = obj16;
																						object obj17 = obj16 << 2;
																						object obj18 = obj5 + obj17;
																						obj18 = 270;
																					}
																					goto IL_0de7;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																				object obj20 = default;
																				object obj19 = obj20;
																				obj21 = obj22;
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																				object obj23 = default;
																				object obj19 = obj23;
																				text3 = text6;
																				obj21 = obj22;
																			}
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																			object obj24 = default;
																			object obj19 = obj24;
																			text3 = text6;
																			obj21 = obj22;
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																		object obj25 = default;
																		object obj19 = obj25;
																		text3 = text8;
																		obj21 = obj22;
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj26 = default;
																	object obj19 = obj26;
																	text3 = text8;
																	obj21 = obj22;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																object obj27 = default;
																object obj19 = obj27;
																obj21 = obj22;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj28 = default;
															object obj19 = obj28;
															obj21 = obj22;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj29 = default;
														object obj19 = obj29;
														obj21 = obj22;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj30 = default;
													object obj19 = obj30;
													obj21 = obj22;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj31 = default;
												object obj19 = obj31;
												obj21 = obj22;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj32 = default;
											object obj19 = obj32;
											obj21 = obj22;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj33 = default;
										object obj19 = obj33;
										obj21 = obj22;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj34 = default;
									object obj19 = obj34;
									obj21 = obj22;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj35 = default;
								object obj19 = obj35;
								obj21 = obj22;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj36 = default;
							object obj19 = obj36;
							obj21 = obj22;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj37 = default;
						object obj19 = obj37;
						obj21 = obj22;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj38 = default;
					object obj19 = obj38;
					obj21 = obj22;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj39 = default;
				object obj19 = obj39;
				obj21 = obj22;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj40 = default;
			string[] values;
			if (obj21 == obj40)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				values = (string[])(object)text3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				string text9 = default;
				values = (string[])(object)text9;
			}
			goto IL_0e6f;
			IL_0de7:
			values = (string[])(object)text3;
			goto IL_0e6f;
			IL_0e94:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.TypeListAttribute)+10]");
			if ((nint)0 == 0)
			{
				PlatformID platform = Environment.Platform;
				string text10 = string.ConcatArray(values, (int)platform);
				values = (string[])(object)text10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object[] args = default;
			string text11 = string.Format(")]", args);
			string text12 = string.ConcatArray(values, (int)text11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.TypeListAttribute)+10]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			string result = text12;
			if (!flag2)
			{
				PlatformID platform2 = Environment.Platform;
				string text13 = string.ConcatArray((string[])(object)text12, (int)platform2);
				result = text13;
			}
			return (Type[])(object)result;
			IL_0e6f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj41 = (nint)0 << 2;
				object obj42 = obj5 + obj41;
				if ((nint)obj42 == 270)
				{
					object obj43 = obj5 + 4;
					if ((nint)obj43 > -1)
					{
						object obj44 = obj43 + -1;
						obj43 = obj44;
					}
					goto IL_0e94;
				}
			}
			object obj45 = default;
			if (obj45 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0e94;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	public TypeListAttribute(Type[] types)
	{
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
	}
}
