using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class PropertyReference
{
	private Component mTarget;

	private string mName;

	private FieldInfo mField;

	private PropertyInfo mProperty;

	private static int s_Hash;

	public Component target
	{
		get
		{
			//IL_10e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e7: Expected Obj, but got Unknown
			if (this != null && (nint)this != 1 && (nint)this != 2 && (nint)this != 3 && (nint)this != 4 && (nint)this != 5 && (nint)this != 6 && (nint)this != 7)
			{
				if ((nint)this == 8)
				{
					return (Component)(object)"BS";
				}
				if ((nint)this == 9)
				{
					return (Component)(object)"Tab";
				}
				if ((nint)this != 10 && (nint)this != 11)
				{
					if ((nint)this == 12)
					{
						return (Component)(object)"Clr";
					}
					if ((nint)this == 13)
					{
						return (Component)(object)"NT";
					}
					if ((nint)this != 14 && (nint)this != 15 && (nint)this != 16 && (nint)this != 17 && (nint)this != 18)
					{
						if ((nint)this == 19)
						{
							return (Component)(object)"PS";
						}
						if ((nint)this != 20 && (nint)this != 21 && (nint)this != 22 && (nint)this != 23 && (nint)this != 24 && (nint)this != 25 && (nint)this != 26)
						{
							if ((nint)this == 27)
							{
								return (Component)(object)"Esc";
							}
							if ((nint)this != 28 && (nint)this != 29 && (nint)this != 30 && (nint)this != 31)
							{
								if ((nint)this == 32)
								{
									return (Component)(object)"SP";
								}
								if ((nint)this == 33)
								{
									return (Component)(object)"!";
								}
								if ((nint)this == 34)
								{
									return (Component)(object)"\"";
								}
								if ((nint)this == 35)
								{
									return (Component)(object)"#";
								}
								if ((nint)this == 36)
								{
									return (Component)(object)"$";
								}
								if ((nint)this != 37)
								{
									if ((nint)this == 38)
									{
										return (Component)(object)"&";
									}
									if ((nint)this == 39)
									{
										return (Component)(object)"'";
									}
									if ((nint)this == 40)
									{
										return (Component)(object)"(";
									}
									if ((nint)this == 41)
									{
										return (Component)(object)")";
									}
									if ((nint)this == 42)
									{
										return (Component)(object)"*";
									}
									if ((nint)this == 43)
									{
										return (Component)(object)"+";
									}
									if ((nint)this == 44)
									{
										return (Component)(object)",";
									}
									if ((nint)this == 45)
									{
										return (Component)(object)"-";
									}
									if ((nint)this == 46)
									{
										return (Component)(object)".";
									}
									if ((nint)this == 47)
									{
										return (Component)(object)"/";
									}
									if ((nint)this == 48)
									{
										return (Component)(object)"0";
									}
									if ((nint)this == 49)
									{
										return (Component)(object)"1";
									}
									if ((nint)this == 50)
									{
										return (Component)(object)"2";
									}
									if ((nint)this == 51)
									{
										return (Component)(object)"3";
									}
									if ((nint)this == 52)
									{
										return (Component)(object)"4";
									}
									if ((nint)this == 53)
									{
										return (Component)(object)"5";
									}
									if ((nint)this == 54)
									{
										return (Component)(object)"6";
									}
									if ((nint)this == 55)
									{
										return (Component)(object)"7";
									}
									if ((nint)this == 56)
									{
										return (Component)(object)"8";
									}
									if ((nint)this == 57)
									{
										return (Component)(object)"9";
									}
									if ((nint)this == 58)
									{
										return (Component)(object)":";
									}
									if ((nint)this == 59)
									{
										return (Component)(object)";";
									}
									if ((nint)this == 60)
									{
										return (Component)(object)"<";
									}
									if ((nint)this == 61)
									{
										return (Component)(object)"=";
									}
									if ((nint)this == 62)
									{
										return (Component)(object)">";
									}
									if ((nint)this == 63)
									{
										return (Component)(object)"?";
									}
									if ((nint)this == 64)
									{
										return (Component)(object)"@";
									}
									if ((nint)this != 65 && (nint)this != 66 && (nint)this != 67 && (nint)this != 68 && (nint)this != 69 && (nint)this != 70 && (nint)this != 71 && (nint)this != 72 && (nint)this != 73 && (nint)this != 74 && (nint)this != 75 && (nint)this != 76 && (nint)this != 77 && (nint)this != 78 && (nint)this != 79 && (nint)this != 80 && (nint)this != 81 && (nint)this != 82 && (nint)this != 83 && (nint)this != 84 && (nint)this != 85 && (nint)this != 86 && (nint)this != 87 && (nint)this != 88 && (nint)this != 89 && (nint)this != 90)
									{
										if ((nint)this == 91)
										{
											return (Component)(object)"[";
										}
										if ((nint)this == 92)
										{
											return (Component)(object)"\\";
										}
										if ((nint)this == 93)
										{
											return (Component)(object)"]";
										}
										if ((nint)this == 94)
										{
											return (Component)(object)"^";
										}
										if ((nint)this == 95)
										{
											return (Component)(object)"_";
										}
										if ((nint)this == 96)
										{
											return (Component)(object)"`";
										}
										if ((nint)this == 97)
										{
											return (Component)(object)"A";
										}
										if ((nint)this == 98)
										{
											return (Component)(object)"B";
										}
										if ((nint)this == 99)
										{
											return (Component)(object)"C";
										}
										if ((nint)this == 100)
										{
											return (Component)(object)"D";
										}
										if ((nint)this == 101)
										{
											return (Component)(object)"E";
										}
										if ((nint)this == 102)
										{
											return (Component)(object)"F";
										}
										if ((nint)this == 103)
										{
											return (Component)(object)"G";
										}
										if ((nint)this == 104)
										{
											return (Component)(object)"H";
										}
										if ((nint)this == 105)
										{
											return (Component)(object)"I";
										}
										if ((nint)this == 106)
										{
											return (Component)(object)"J";
										}
										if ((nint)this == 107)
										{
											return (Component)(object)"K";
										}
										if ((nint)this == 108)
										{
											return (Component)(object)"L";
										}
										if ((nint)this == 109)
										{
											return (Component)(object)"M";
										}
										if ((nint)this == 110)
										{
											return (Component)(object)"N0";
										}
										if ((nint)this == 111)
										{
											return (Component)(object)"O";
										}
										if ((nint)this == 112)
										{
											return (Component)(object)"P";
										}
										if ((nint)this == 113)
										{
											return (Component)(object)"Q";
										}
										if ((nint)this == 114)
										{
											return (Component)(object)"R";
										}
										if ((nint)this == 115)
										{
											return (Component)(object)"S";
										}
										if ((nint)this == 116)
										{
											return (Component)(object)"T";
										}
										if ((nint)this == 117)
										{
											return (Component)(object)"U";
										}
										if ((nint)this == 118)
										{
											return (Component)(object)"V";
										}
										if ((nint)this == 119)
										{
											return (Component)(object)"W";
										}
										if ((nint)this == 120)
										{
											return (Component)(object)"X";
										}
										if ((nint)this == 121)
										{
											return (Component)(object)"Y";
										}
										if ((nint)this == 122)
										{
											return (Component)(object)"Z";
										}
										if ((nint)this != 123 && (nint)this != 124 && (nint)this != 125 && (nint)this != 126)
										{
											if ((nint)this == 127)
											{
												return (Component)(object)"Del";
											}
											object obj = this - 256;
											if ((nint)this != 256)
											{
												if ((nint)obj != 1)
												{
													if ((nint)obj != 2)
													{
														if ((nint)obj != 3)
														{
															if ((nint)obj != 4)
															{
																if ((nint)obj != 5)
																{
																	if ((nint)obj != 6)
																	{
																		if ((nint)obj != 7)
																		{
																			if ((nint)obj != 8)
																			{
																				if ((nint)obj != 9)
																				{
																					if ((nint)obj != 10)
																					{
																						if ((nint)obj != 11)
																						{
																							if ((nint)obj != 12)
																							{
																								if ((nint)obj != 13)
																								{
																									if ((nint)obj != 14)
																									{
																										if ((nint)obj != 15)
																										{
																											if ((nint)obj != 16)
																											{
																												if ((nint)obj != 17)
																												{
																													if ((nint)obj != 18)
																													{
																														if ((nint)obj != 19)
																														{
																															if ((nint)obj != 20)
																															{
																																if ((nint)obj != 21)
																																{
																																	if ((nint)obj != 22)
																																	{
																																		if ((nint)obj != 23)
																																		{
																																			if ((nint)obj != 24)
																																			{
																																				if ((nint)obj != 25)
																																				{
																																					if ((nint)obj != 26)
																																					{
																																						if ((nint)obj != 27)
																																						{
																																							if ((nint)obj != 28)
																																							{
																																								if ((nint)obj != 29)
																																								{
																																									if ((nint)obj != 30)
																																									{
																																										if ((nint)obj != 31)
																																										{
																																											if ((nint)obj != 32)
																																											{
																																												if ((nint)obj != 33)
																																												{
																																													if ((nint)obj != 34)
																																													{
																																														if ((nint)obj != 35)
																																														{
																																															if ((nint)obj != 36)
																																															{
																																																if ((nint)obj != 37)
																																																{
																																																	if ((nint)obj != 38)
																																																	{
																																																		if ((nint)obj != 39)
																																																		{
																																																			if ((nint)obj != 40)
																																																			{
																																																				if ((nint)obj != 41 && (nint)obj != 42 && (nint)obj != 43)
																																																				{
																																																					if ((nint)obj == 44)
																																																					{
																																																						return (Component)(object)"Num";
																																																					}
																																																					if ((nint)obj == 45)
																																																					{
																																																						return (Component)(object)"Cap";
																																																					}
																																																					if ((nint)obj == 46)
																																																					{
																																																						return (Component)(object)"Scr";
																																																					}
																																																					if ((nint)obj == 47)
																																																					{
																																																						return (Component)(object)"RS";
																																																					}
																																																					if ((nint)obj == 48)
																																																					{
																																																						return (Component)(object)"LS";
																																																					}
																																																					if ((nint)obj == 49)
																																																					{
																																																						return (Component)(object)"RC";
																																																					}
																																																					if ((nint)obj == 50)
																																																					{
																																																						return (Component)(object)"LC";
																																																					}
																																																					if ((nint)obj == 51)
																																																					{
																																																						return (Component)(object)"RA";
																																																					}
																																																					if ((nint)obj == 52)
																																																					{
																																																						return (Component)(object)"LA";
																																																					}
																																																					if ((nint)obj != 53 && (nint)obj != 54 && (nint)obj != 55 && (nint)obj != 56 && (nint)obj != 57 && (nint)obj != 58 && (nint)obj != 59 && (nint)obj != 60 && (nint)obj != 61 && (nint)obj != 62 && (nint)obj != 63 && (nint)obj != 64 && (nint)obj != 65 && (nint)obj != 66)
																																																					{
																																																						if ((nint)obj == 67)
																																																						{
																																																							return (Component)(object)"M0";
																																																						}
																																																						if ((nint)obj == 68)
																																																						{
																																																							return (Component)(object)"M1";
																																																						}
																																																						if ((nint)obj == 69)
																																																						{
																																																							return (Component)(object)"M2";
																																																						}
																																																						if ((nint)obj == 70)
																																																						{
																																																							return (Component)(object)"M3";
																																																						}
																																																						if ((nint)obj == 71)
																																																						{
																																																							return (Component)(object)"M4";
																																																						}
																																																						if ((nint)obj == 72)
																																																						{
																																																							return (Component)(object)"M5";
																																																						}
																																																						if ((nint)obj == 73)
																																																						{
																																																							return (Component)(object)"M6";
																																																						}
																																																						if ((nint)obj == 74)
																																																						{
																																																							return (Component)(object)"(A)";
																																																						}
																																																						if ((nint)obj == 75)
																																																						{
																																																							return (Component)(object)"(B)";
																																																						}
																																																						if ((nint)obj == 76)
																																																						{
																																																							return (Component)(object)"(X)";
																																																						}
																																																						if ((nint)obj == 77)
																																																						{
																																																							return (Component)(object)"(Y)";
																																																						}
																																																						if ((nint)obj == 78)
																																																						{
																																																							return (Component)(object)"(RB)";
																																																						}
																																																						if ((nint)obj == 79)
																																																						{
																																																							return (Component)(object)"(LB)";
																																																						}
																																																						if ((nint)obj == 80)
																																																						{
																																																							return (Component)(object)"(Back)";
																																																						}
																																																						if ((nint)obj == 81)
																																																						{
																																																							return (Component)(object)"(Start)";
																																																						}
																																																						if ((nint)obj == 82)
																																																						{
																																																							return (Component)(object)"(LS)";
																																																						}
																																																						if ((nint)obj == 83)
																																																						{
																																																							return (Component)(object)"(RS)";
																																																						}
																																																						if ((nint)obj == 84)
																																																						{
																																																							return (Component)(object)"J10";
																																																						}
																																																						if ((nint)obj == 85)
																																																						{
																																																							return (Component)(object)"J11";
																																																						}
																																																						if ((nint)obj == 86)
																																																						{
																																																							return (Component)(object)"J12";
																																																						}
																																																						if ((nint)obj == 87)
																																																						{
																																																							return (Component)(object)"J13";
																																																						}
																																																						if ((nint)obj == 88)
																																																						{
																																																							return (Component)(object)"J14";
																																																						}
																																																						if ((nint)obj == 89)
																																																						{
																																																							return (Component)(object)"J15";
																																																						}
																																																						if ((nint)obj == 90)
																																																						{
																																																							return (Component)(object)"J16";
																																																						}
																																																						if ((nint)obj == 91)
																																																						{
																																																							return (Component)(object)"J17";
																																																						}
																																																						if ((nint)obj == 92)
																																																						{
																																																							return (Component)(object)"J18";
																																																						}
																																																						if ((nint)obj == 93)
																																																						{
																																																							return (Component)(object)"J19";
																																																						}
																																																					}
																																																				}
																																																				return null;
																																																			}
																																																			return (Component)(object)"F15";
																																																		}
																																																		return (Component)(object)"F14";
																																																	}
																																																	return (Component)(object)"F13";
																																																}
																																																return (Component)(object)"F12";
																																															}
																																															return (Component)(object)"F11";
																																														}
																																														return (Component)(object)"F10";
																																													}
																																													return (Component)(object)"F9";
																																												}
																																												return (Component)(object)"F8";
																																											}
																																											return (Component)(object)"F7";
																																										}
																																										return (Component)(object)"F6";
																																									}
																																									return (Component)(object)"F5";
																																								}
																																								return (Component)(object)"F4";
																																							}
																																							return (Component)(object)"F3";
																																						}
																																						return (Component)(object)"F2";
																																					}
																																					return (Component)(object)"F1";
																																				}
																																				return (Component)(object)"PD";
																																			}
																																			return (Component)(object)"PU";
																																		}
																																		return (Component)(object)"End";
																																	}
																																	return (Component)(object)"Home";
																																}
																																return (Component)(object)"Ins";
																															}
																															return (Component)(object)"RT";
																														}
																														return (Component)(object)"LT";
																													}
																													return (Component)(object)"DN";
																												}
																												return (Component)(object)"UP";
																											}
																											return (Component)(object)"=";
																										}
																										return (Component)(object)"NT";
																									}
																									return (Component)(object)"+";
																								}
																								return (Component)(object)"-";
																							}
																							return (Component)(object)"*";
																						}
																						return (Component)(object)"/";
																					}
																					return (Component)(object)".";
																				}
																				return (Component)(object)"K9";
																			}
																			return (Component)(object)"K8";
																		}
																		return (Component)(object)"K7";
																	}
																	return (Component)(object)"K6";
																}
																return (Component)(object)"K5";
															}
															return (Component)(object)"K4";
														}
														return (Component)(object)"K3";
													}
													return (Component)(object)"K2";
												}
												return (Component)(object)"K1";
											}
											return (Component)(object)"K0";
										}
									}
								}
							}
						}
					}
				}
			}
			return null;
		}
		set
		{
			//IL_025d: Expected I, but got Obj
			//IL_0273: Expected Obj, but got I
			//IL_0389: Expected I, but got Obj
			//IL_039f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Expected Obj, but got Unknown
			//IL_033f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Expected Obj, but got Unknown
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected Obj, but got Unknown
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_024a: Expected Obj, but got I
			//IL_00f7: Expected I, but got Obj
			//IL_0156: Expected I, but got Obj
			//IL_016c: Expected Obj, but got I
			//IL_00aa: Expected I, but got Obj
			//IL_02a7: Expected F4, but got Obj
			//IL_02ce: Expected F4, but got I
			//IL_02f5: Expected F4, but got I
			//IL_01f9: Expected F4, but got I
			//IL_0206: Expected Obj, but got I4
			//IL_0215: Expected Obj, but got F4
			//IL_0224: Expected Obj, but got F4
			//IL_022e: Expected Obj, but got F4
			//IL_0197: Expected I, but got Obj
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v84 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUITools.mColorSpace == ColorSpace.Uninitialized)
			{
				IntPtr intPtr = MaterialPropertyBlock.CreateImpl();
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v72 (Il2CppClass<NGUITools>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v78 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.mColorSpace = (ColorSpace)(nint)intPtr;
			}
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v19 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v63 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = default;
			object obj4 = obj5 + 48;
			object obj6 = obj5 + 32;
			object obj7 = obj5 + 16;
			if (NGUITools.mColorSpace == ColorSpace.Linear)
			{
				obj4 = value;
				_ = ((UnityEngine.Object)value).m_CachedPtr;
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v47 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num9 = Mathf.Sign((float)obj4);
				obj6 = value;
				_ = ((UnityEngine.Object)value).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v26+4]");
				float num10 = Mathf.Sign(0f);
				obj7 = value;
				_ = ((UnityEngine.Object)value).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v28+8]");
				float num11 = Mathf.Sign(0f);
				obj5 = value;
				_ = ((UnityEngine.Object)value).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
				float num12 = Mathf.Sign(0f);
				PropertyReference propertyReference = (PropertyReference)0;
				mTarget = null;
				propertyReference = (PropertyReference)num9;
				mTarget = (Component)num11;
				mName = (string)num12;
			}
			else
			{
				PropertyReference propertyReference = (PropertyReference)(object)value;
				mTarget = (Component)(nint)((UnityEngine.Object)value).m_CachedPtr;
			}
		}
	}

	public string name
	{
		get
		{
			return (string)(object)mTarget;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0027: Expected Obj, but got I4
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected Obj, but got Unknown
			//IL_003b: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
			object obj2 = this + 20;
			obj2 = 0;
			object obj3 = this + 16;
			obj3 = 0;
		}
	}

	public bool isValid
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)mName != 0;
		}
	}

	public bool isEnabled
	{
		get
		{
			//IL_00be: Expected I, but got Obj
			//IL_00d4: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mTarget).FindKernel((string)null) != 0)
			{
				string text = mName;
				bool flag = mName == null || text.m_stringLength == 0;
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			return false;
		}
	}

	public PropertyReference()
	{
		_ = 1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public PropertyReference(Component target, string fieldName)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Color color = NGUIText.ParseColor32((string)(object)target, (int)fieldName);
	}

	public Type GetPropertyType()
	{
		//IL_012a: Expected I, but got Obj
		//IL_0140: Expected Obj, but got I
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_00b5: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mTarget != null)
		{
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj3 = default;
		if (obj3 != null)
		{
			return (Type)1;
		}
		bool isActiveAndEnabled = ((Behaviour)obj3).isActiveAndEnabled;
		return (Type)isActiveAndEnabled;
	}

	public override bool Equals(object obj)
	{
		//IL_00e5: Expected I4, but got Obj
		//IL_002c: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_015a: Expected I4, but got Obj
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text = default;
			int num = text.LastIndexOfAny((char[])47);
			bool flag = num >= 1;
			bool flag2 = !flag;
			string text2 = text;
			if (!flag2)
			{
				char[] trimChars = (char[])(num + 1);
				string text3 = text.Trim(trimChars);
				text2 = text3;
			}
			bool flag3;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ L1 (System.Object)+8]");
				flag3 = (nint)0 == 0;
			}
			else
			{
				flag3 = true;
			}
			bool flag4 = !flag3;
			bool flag5 = !flag4;
			object obj2 = text2;
			if (!flag5)
			{
				object obj3 = ((IConvertible)text2).ToType((Type)(object)"/", (IFormatProvider)obj);
				obj2 = obj3;
			}
			return (byte)(int)obj2 != 0;
		}
		return (byte)(int)"<null>" != 0;
	}

	public unsafe override int GetHashCode()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected I, but got Unknown
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_01c2: Expected I4, but got Obj
		//IL_00f2: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
			object obj2 = default;
			if (obj2 != null && isEnabled)
			{
				SpringPanel springPanel = SpringPanel.Stop((GameObject)(object)this);
			}
		}
		object obj3 = default;
		nint num = (nint)(obj3 + 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
		object obj4 = default;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
			object obj5 = default;
			if (obj5 == null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v24 (Il2CppClass<System.Type>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num3 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v32 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = typeof(void);
				((IntPtr*)num)->m_value = (void*)(nint)obj3;
				Type type = Type.internal_from_handle((IntPtr)num);
				return (int)type;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		}
		int result = default;
		return result;
	}

	public void Set(Component target, string methodName)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = target;
		object obj2 = this + 12;
		obj2 = methodName;
	}

	public void Clear()
	{
	}

	public void Reset()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I4
		object obj = this + 8;
		obj = 0;
		object obj2 = this + 12;
		obj2 = 0;
	}

	public override string ToString()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PropertyReference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<PropertyReference>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PropertyReference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<PropertyReference>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)s_Hash;
	}

	public static string ToString(Component comp, string property)
	{
		//IL_0121: Expected Obj, but got I4
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		if (property != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v11 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				IntPtr cachedPtr = ((UnityEngine.Object)comp).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15+8]");
				if ((UnityEngine.Object)(nint)cachedPtr != (UnityEngine.Object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [comp @ L0 (UnityEngine.Component)+C]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15+C]");
					bool flag = (string)num3 == (string)0;
					return (string)flag;
				}
				return null;
			}
			return null;
		}
		bool flag2 = ((PropertyReference)(object)comp).isEnabled;
		return (string)((flag2 ? 1 : 0) ^ 1);
	}

	public object Get()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PropertyReference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppClass<PropertyReference>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PropertyReference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v7 (Il2CppClass<PropertyReference>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return ((PropertyReference)(object)mTarget).Set((object)mName);
	}

	public bool Set(object value)
	{
		//IL_0169: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_0143: Expected I4, but got Obj
		//IL_0114: Expected I4, but got Obj
		//IL_0120: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)this).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text = default;
			int num3 = text.LastIndexOfAny((char[])46);
			bool flag = num3 >= 1;
			bool flag2 = !flag;
			string text2 = text;
			if (!flag2)
			{
				char[] trimChars = (char[])(num3 + 1);
				string text3 = text.Trim(trimChars);
				text2 = text3;
			}
			bool flag3;
			if (value != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Object)+8]");
				flag3 = (nint)0 == 0;
			}
			else
			{
				flag3 = true;
			}
			if (flag3)
			{
				string text4 = string.ConcatArray((string[])(object)text2, (int)".[property]");
				return (byte)(int)text4 != 0;
			}
			object obj2 = ((IConvertible)text2).ToType((Type)(object)".", (IFormatProvider)value);
			return (byte)(int)obj2 != 0;
		}
		return false;
	}

	private bool Cache()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
			object obj2 = default;
			if (obj2 != null && isEnabled)
			{
				SpringPanel springPanel = SpringPanel.Stop((GameObject)(object)this);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
		object obj3 = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj4 = default;
			if (obj4 == null)
			{
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
			object obj5 = default;
			if (obj5 == null)
			{
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		}
		bool result = default;
		return result;
	}

	private unsafe bool Convert(ref object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got Ref
		//IL_02bf: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		Type type = (Type)(obj2 + 8);
		type = (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value);
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
		object obj3 = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
			object obj4 = default;
			if (obj4 != null && isEnabled)
			{
				SpringPanel springPanel = SpringPanel.Stop((GameObject)(object)this);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
		object obj5 = default;
		bool result;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
			object obj6 = default;
			if (obj6 != null)
			{
				result = false;
				goto IL_04e4;
			}
		}
		if ((object)type == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj8 = default;
			object obj7 = obj8;
			object obj10 = default;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj11 = default;
			if (obj9 == obj11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj13 = default;
				object obj12 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj15 = default;
				object obj14 = obj15;
			}
			else
			{
				object obj14 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		if (Convert((Type)(object)this, type))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
			object obj16 = default;
			if (obj16 != null)
			{
				mField.SetValueDirect((TypedReference)mTarget, type);
				result = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj17 = default;
				bool flag = obj17 == null;
				result = false;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
					result = true;
				}
			}
		}
		else
		{
			if (Application.platform != RuntimePlatform.OSXEditor)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			result = false;
		}
		goto IL_04e4;
		IL_04e4:
		return result;
	}

	public static bool Convert(Type from, Type to)
	{
		//IL_0135: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		//IL_0176: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_01f7: Expected I4, but got Obj
		//IL_00e8: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)from._impl != null)
		{
			return false;
		}
		int hashCode = ((PropertyReference)(object)from).GetHashCode();
		int vertexCount = default;
		if ((object)to != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		}
		else
		{
			if (!((Type)hashCode).IsInterface)
			{
				return false;
			}
			vertexCount = hashCode;
		}
		nint num3 = (nint)typeof(PropertyReference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v21 (Il2CppClass<PropertyReference>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(PropertyReference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27 (Il2CppClass<PropertyReference>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int[] array = ((UIDrawCall)(object)to).GenerateCachedIndexBuffer(vertexCount, hashCode);
		return (byte)(int)array != 0;
	}

	public static bool Convert(object value, Type to)
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00ad: Expected I4, but got Obj
		//IL_00ad: Expected I4, but got Obj
		//IL_00b1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		UIDrawCall uIDrawCall = (UIDrawCall)0;
		nint num = (nint)typeof(PropertyReference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<PropertyReference>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PropertyReference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v16 (Il2CppClass<PropertyReference>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)uIDrawCall.GenerateCachedIndexBuffer((int)value, (int)to) != 0;
	}

	public unsafe static bool Convert(ref object value, Type from, Type to)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1296: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Expected Obj, but got Unknown
		//IL_12a4: Expected Obj, but got I4
		//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b8: Expected Obj, but got Unknown
		//IL_12d4: Expected I, but got Obj
		//IL_12ea: Expected Obj, but got I
		//IL_18bc: Expected Obj, but got Ref
		//IL_0021: Expected I, but got Obj
		//IL_1327: Expected I, but got Obj
		//IL_133d: Expected Obj, but got I
		//IL_0069: Expected Obj, but got Ref
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_18e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18eb: Expected Obj, but got Unknown
		//IL_18f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f9: Expected Obj, but got Unknown
		//IL_0113: Expected I, but got Obj
		//IL_00bc: Expected I, but got Obj
		//IL_194b: Expected I, but got Obj
		//IL_1961: Expected Obj, but got I
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_0758: Expected I, but got Obj
		//IL_076e: Expected Obj, but got I
		//IL_04d6: Expected I, but got Obj
		//IL_01fb: Expected I, but got Obj
		//IL_0211: Expected Obj, but got I
		//IL_01a1: Expected I, but got Obj
		//IL_0523: Expected I, but got Obj
		//IL_0539: Expected Obj, but got I
		//IL_1516: Expected I, but got Obj
		//IL_152c: Expected Obj, but got I
		//IL_0799: Expected I, but got Obj
		//IL_023c: Expected I, but got Obj
		//IL_07f3: Expected I, but got Obj
		//IL_0809: Expected Obj, but got I
		//IL_0564: Expected I, but got Obj
		//IL_0a6c: Expected I, but got Obj
		//IL_0a82: Expected Obj, but got I
		//IL_08e9: Expected I, but got Obj
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0381: Expected Obj, but got I4
		//IL_0936: Expected I, but got Obj
		//IL_094c: Expected Obj, but got I
		//IL_0834: Expected I, but got Obj
		//IL_05b1: Expected I, but got Obj
		//IL_05c7: Expected Obj, but got I
		//IL_17cf: Expected I, but got Obj
		//IL_17e5: Expected Obj, but got I
		//IL_0aad: Expected I, but got Obj
		//IL_19f1: Expected Obj, but got Ref
		//IL_0afa: Expected I, but got Obj
		//IL_0b10: Expected Obj, but got I
		//IL_15e9: Expected I4, but got Obj
		//IL_0977: Expected I, but got Obj
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_05f2: Expected I, but got Obj
		//IL_0419: Expected Obj, but got I
		//IL_14dd: Expected I4, but got Obj
		//IL_0f70: Expected I, but got Obj
		//IL_165a: Unknown result type (might be due to invalid IL or missing references)
		//IL_165f: Expected Obj, but got Unknown
		//IL_0a3e: Expected I4, but got Obj
		//IL_09e6: Expected Obj, but got I4
		//IL_0fb8: Expected Obj, but got Ref
		//IL_0fca: Expected I, but got Obj
		//IL_0fe0: Expected Obj, but got I
		//IL_0b88: Expected Obj, but got I4
		//IL_0bb6: Expected Obj, but got I4
		//IL_0bbf: Expected Obj, but got I4
		//IL_0b3b: Expected I, but got Obj
		//IL_1614: Expected Obj, but got I4
		//IL_0a1d: Expected I4, but got Obj
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_0a0a: Expected Obj, but got I4
		//IL_06b7: Expected Obj, but got Ref
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_032c: Expected Obj, but got I4
		//IL_107f: Expected I, but got Obj
		//IL_1095: Expected Obj, but got I
		//IL_100b: Expected I, but got Obj
		//IL_0caf: Expected I, but got Obj
		//IL_0cc5: Expected Obj, but got I
		//IL_06ca: Expected I, but got Obj
		//IL_06e0: Expected Obj, but got I
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_183a: Expected Obj, but got Ref
		//IL_1053: Expected Obj, but got Ref
		//IL_1737: Expected VT, but got Obj
		//IL_1740: Expected Obj, but got VT
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd2: Expected Obj, but got Unknown
		//IL_14cb: Expected Obj, but got Ref
		//IL_1145: Expected Obj, but got Ref
		//IL_10c0: Expected I, but got Obj
		//IL_0cf0: Expected I, but got Obj
		//IL_0c4f: Expected Obj, but got I4
		//IL_070b: Expected I, but got Obj
		//IL_1158: Expected I, but got Obj
		//IL_116e: Expected Obj, but got I
		//IL_1108: Expected Obj, but got Ref
		//IL_0d63: Expected Obj, but got I4
		//IL_1699: Expected I, but got Obj
		//IL_16af: Expected Obj, but got I
		//IL_188a: Expected Obj, but got Ref
		//IL_1796: Expected I4, but got Obj
		//IL_1796: Expected Obj, but got VT
		//IL_0d55: Expected Obj, but got I4
		//IL_1199: Expected I, but got Obj
		//IL_0d75: Expected Obj, but got VT
		//IL_0d92: Expected Obj, but got VT
		//IL_19d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19da: Expected Obj, but got Unknown
		//IL_0c62: Expected I, but got Obj
		//IL_1227: Expected I, but got Obj
		//IL_123d: Expected Obj, but got I
		//IL_0e48: Expected Obj, but got VT
		//IL_0e56: Expected Obj, but got VT
		//IL_18a5: Expected Obj, but got I4
		//IL_0e69: Expected Obj, but got VT
		//IL_0e77: Expected Obj, but got VT
		//IL_0dc2: Expected Obj, but got VT
		//IL_0dd0: Expected Obj, but got VT
		//IL_1268: Expected I, but got Obj
		//IL_0e8a: Expected I, but got Obj
		//IL_0ea0: Expected Obj, but got I
		//IL_0dde: Expected Obj, but got VT
		//IL_0deb: Expected Obj, but got I4
		//IL_0dfa: Expected Obj, but got F4
		//IL_0f20: Expected Obj, but got VT
		//IL_0ecb: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v471 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref object reference = default;
		UIRoot uIRoot;
		if (((ComputeShader)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).FindKernel(null) != 0)
		{
			string tag = ((Component)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v251 (Il2CppClass<NGUITools>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v257 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uIRoot = NGUITools.FindInParents<UIRoot>((GameObject)(object)tag);
		}
		else
		{
			uIRoot = null;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v463 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 56);
		object obj8 = obj2 + 16;
		UIRoot uIRoot2 = default;
		Type type = default;
		if (uIRoot != null)
		{
			nint num7 = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v357 (Il2CppClass<UIRoot>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num8 = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v457 (Il2CppClass<UIRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<UIRoot> list = UIRoot.list;
			if (list._size < 1)
			{
				uIRoot2 = uIRoot;
			}
			else
			{
				nint num9 = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v370 (Il2CppClass<UIRoot>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num10 = (nint)typeof(UIRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v450 (Il2CppClass<UIRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
				obj3 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				object obj11 = default;
				object obj12 = default;
				UIRoot uIRoot3;
				UIRoot uIRoot4 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj12 == type)
						{
							object obj13 = obj4 + 4;
							object obj14 = obj13 + 1;
							obj13 = obj14;
							object obj15 = obj14 << 2;
							object obj16 = obj4 + obj15;
							obj16 = 110;
							uIRoot3 = uIRoot4;
							break;
						}
						continue;
					}
					object obj17 = obj4 + 4;
					object obj18 = obj17 + 1;
					obj17 = obj18;
					object obj19 = obj18 << 2;
					object obj20 = obj4 + obj19;
					obj20 = 110;
					uIRoot3 = uIRoot;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj21 = (nint)0 << 2;
					object obj22 = obj4 + obj21;
					if ((nint)obj22 == 110)
					{
						object obj23 = obj4 + 4;
						if ((nint)obj23 > -1)
						{
							object obj24 = obj23 + -1;
							obj23 = obj24;
						}
						uIRoot2 = uIRoot3;
						goto IL_193d;
					}
				}
				object obj25 = default;
				if (obj25 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				else
				{
					uIRoot2 = uIRoot3;
				}
			}
		}
		else
		{
			uIRoot2 = uIRoot;
		}
		goto IL_193d;
		IL_069d:
		UIPanel uIPanel;
		GameObject gameObject = uIPanel.gameObject;
		((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).parentInternal = (Transform)(object)gameObject;
		nint num11 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ S0_v326 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ S0_v335 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj8;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v33+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).parent = transform;
		UIPanel uIPanel2 = uIPanel;
		goto IL_14d8;
		IL_14d8:
		return (byte)(int)uIPanel2 != 0;
		IL_193d:
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v351 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uIRoot2 != null)
		{
			nint num15 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v292 (Il2CppClass<UIPanel>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num16 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v345 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<UIPanel> list2 = UIPanel.list;
			int num20;
			for (int num17 = 0; num17 < list2._size; num20 = num17 + 1, num17 = num20)
			{
				nint num18 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v307 (Il2CppClass<UIPanel>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num19 = (nint)typeof(UIPanel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v339 (Il2CppClass<UIPanel>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				uIPanel = UIPanel.list.get_Item(num17);
				string tag2 = uIPanel.tag;
				UnityEngine.Object obj30 = UnityEngine.Object.FindObjectOfType((Type)(object)tag2);
				if ((object)obj30 != null)
				{
					continue;
				}
				bool activeSelf = ((GameObject)(object)tag2).activeSelf;
				if ((activeSelf ? 1 : 0) != (nint)type)
				{
					continue;
				}
				goto IL_069d;
			}
		}
		nint num21 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num22 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v287 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIRoot2).FindKernel((string)null) != 0)
		{
			_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)uIRoot2).GetComponentsInChildren<T>();
			nint num23 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v267 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num24 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S0_v283 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)componentsInChildren).FindKernel((string)null) != 0)
			{
				Camera component = ((Component)(object)componentsInChildren).GetComponent<Camera>();
				TransparencySortMode transparencySortMode = component.transparencySortMode;
				object obj33 = transparencySortMode ^ from;
				if (obj33 == null)
				{
					uIRoot2 = null;
				}
				if (obj33 == null)
				{
					reference = ref *(object*)null;
				}
			}
		}
		nint num25 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num26 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S0_v260 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uIRoot2 != null)
		{
			nint num27 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S0_v231 (Il2CppClass<NGUITools>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num28 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S0_v256 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject gameObject2 = NGUITools.AddChild(null, null);
			UIRoot uIRoot5 = gameObject2.AddComponent<UIRoot>();
			if ((nint)type == -1)
			{
				bool flag = ((MonoBehaviour)(object)"UI").IsInvoking();
				bool flag2 = (flag ? 1 : 0) == -1;
				bool flag3 = !flag2;
				type = (Type)flag;
				if (!flag3)
				{
					bool flag4 = ((MonoBehaviour)(object)"2D UI").IsInvoking();
					type = (Type)flag4;
				}
			}
			gameObject2.SetActive((byte)(int)type != 0);
			if ((object)from != null)
			{
				UnityEngine.Object.DestroyImmediate(gameObject2, (byte)(int)"UI Root (3D)" != 0);
				uIRoot5.scalingStyle = UIRoot.Scaling.Constrained;
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(gameObject2, (byte)(int)"UI Root" != 0);
				uIRoot5.scalingStyle = UIRoot.Scaling.Flexible;
			}
			UIRoot.Broadcast((string)(object)uIRoot5, 1);
			uIRoot2 = uIRoot5;
		}
		_0021_00210[] array = (_0021_00210[])(object)((Component)uIRoot2).GetComponentsInChildren<T>();
		nint num29 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S0_v69 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num30 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S0_v226 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)array != null)
		{
			nint num31 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S0_v130 (Il2CppClass<NGUITools>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num32 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S0_v222 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string typeName = NGUITools.GetTypeName<T>();
			object obj38 = typeName + 12;
			string tag3 = uIRoot2.tag;
			bool activeSelf2 = ((GameObject)(object)tag3).activeSelf;
			object obj39 = (activeSelf2 ? 1 : 0) & 0x1F;
			int num33 = 1 << (int)obj39;
			int num34 = num33 ^ -1;
			float num35 = -1f;
			object obj40 = 0;
			object obj41 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38))
			{
				object obj42 = typeName + 16;
				object obj43 = obj41 << 2;
				object obj44 = obj42 + obj43;
				int pixelWidth = ((Camera)obj44).pixelWidth;
				if (pixelWidth != 2)
				{
					int pixelWidth2 = ((Camera)obj44).pixelWidth;
					if (pixelWidth2 != 1)
					{
						goto IL_167e;
					}
				}
				obj40 = 1;
				goto IL_167e;
				IL_167e:
				float aspect = ((Camera)obj44).aspect;
				nint num36 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ S0_v202 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj45 = (nint)0 & (nint)0x200;
				if (obj45 != null)
				{
					nint num37 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ S0_v214 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!(num35 > aspect))
				{
					num35 = aspect;
				}
				int eventMask = ((Camera)obj44).eventMask;
				int eventMask2 = eventMask & num34;
				((Camera)obj44).eventMask = eventMask2;
				object obj46 = obj41 + 1;
				obj41 = obj46;
			}
			string tag4 = uIRoot2.tag;
			nint num38 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ S1_v85 (Il2CppClass<NGUITools>)+BA]");
			object obj47 = (nint)0 & (nint)0x200;
			if (obj47 != null)
			{
				nint num39 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ S1_v130 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_0021_00210 val = (_0021_00210)NGUITools.AddWidget<T>((GameObject)(object)tag4, 0);
			string tag5 = ((Component)val).tag;
			UICamera uICamera = ((GameObject)(object)tag5).AddComponent<UICamera>();
			Camera camera = ((obj40 == null) ? ((Camera)2) : ((Camera)3));
			Rect rect = camera.rect;
			Color clear = Color.clear;
			transform = (Transform)obj8;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v33+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			((Camera)val).clearFlags = (CameraClearFlags)transform;
			((Camera)val).eventMask = num33;
			float aspect2 = num35 + 1f;
			((Camera)val).aspect = aspect2;
			if ((object)from != null)
			{
				((Camera)val).farClipPlane = 0.1f;
				((Camera)val).fieldOfView = 4f;
				GameObject gameObject3 = ((Component)val).gameObject;
				obj8 = 0;
				_ = 0;
				obj8 = 0f;
				_ = 0f;
				_ = -700f;
				transform = (Transform)obj8;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v33+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
			}
			else
			{
				((Camera)val).transparencySortMode = TransparencySortMode.Perspective;
				((Camera)val).depth = 1f;
				((Camera)val).farClipPlane = -10f;
				((Camera)val).fieldOfView = 10f;
			}
			nint num40 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ S0_v162 (Il2CppClass<NGUITools>)+BA]");
			object obj48 = (nint)0 & (nint)0x200;
			if (obj48 != null)
			{
				nint num41 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ S0_v181 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string typeName2 = NGUITools.GetTypeName<T>();
			if (typeName2 == null || typeName2.m_firstChar == '\0')
			{
				string tag6 = ((Component)val).tag;
				AudioListener audioListener = ((GameObject)(object)tag6).AddComponent<AudioListener>();
			}
			string tag7 = uIRoot2.tag;
			UIPanel uIPanel3 = ((GameObject)(object)tag7).AddComponent<UIPanel>();
			array = (_0021_00210[])(object)uIPanel3;
		}
		nint num42 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ S0_v77 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj49 = (nint)0 & (nint)0x200;
		if (obj49 != null)
		{
			nint num43 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ S0_v124 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num44 = ((ComputeShader)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).FindKernel(null);
		bool flag5 = num44 == 0;
		uIPanel2 = (UIPanel)(object)array;
		if (!flag5)
		{
			while (true)
			{
				Transform parentInternal = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).parentInternal;
				nint num45 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj50 = (nint)0 & (nint)0x200;
				if (obj50 != null)
				{
					nint num46 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)parentInternal).FindKernel((string)null) == 0)
				{
					break;
				}
				Transform parentInternal2 = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).parentInternal;
				reference = ref *(object*)parentInternal2;
			}
			GameObject gameObject4 = ((Component)(object)array).gameObject;
			nint num47 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ S0_v90 (Il2CppClass<NGUITools>)+BA]");
			object obj51 = (nint)0 & (nint)0x200;
			if (obj51 != null)
			{
				nint num48 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ S0_v118 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUITools.Save((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), (byte[])(object)gameObject4))
			{
				string tag8 = ((Component)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).tag;
				UIPanel uIPanel4 = ((GameObject)(object)tag8).AddComponent<UIPanel>();
				uIPanel2 = uIPanel4;
			}
			else
			{
				GameObject gameObject5 = ((Component)(object)array).gameObject;
				((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).parentInternal = (Transform)(object)gameObject5;
				nint num49 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ S0_v98 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj52 = (nint)0 & (nint)0x200;
				if (obj52 != null)
				{
					nint num50 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ S0_v112 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 forward2 = Vector3.forward;
				transform = (Transform)obj8;
				Transform transform5 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v33+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).parent = transform;
				Vector3 one = Vector3.one;
				transform = (Transform)obj2;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles2 = transform.eulerAngles;
				Camera anchorCamera = ((UIRect)(object)array).anchorCamera;
				Transform cachedTransform = ((UIRect)(object)array).cachedTransform;
				bool activeSelf3 = ((GameObject)(object)cachedTransform).activeSelf;
				nint num51 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ S2_v26 (Il2CppClass<NGUITools>)+BA]");
				object obj53 = (nint)0 & (nint)0x200;
				if (obj53 != null)
				{
					nint num52 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ S2_v31 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.Broadcast((string)(object)anchorCamera, activeSelf3);
				uIPanel2 = (UIPanel)(object)array;
			}
		}
		goto IL_14d8;
	}

	unsafe static PropertyReference()
	{
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_01b9: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_000b: Expected Obj, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		//IL_0026: Expected I4, but got Obj
		//IL_0041: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_00e6: Expected Obj, but got I
		NGUITools.mLoaded = false;
		NGUITools.mGlobalVolume = 1f;
		NGUITools.mLastTimestamp = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v21 (Il2CppClass<NGUITools>)+5C]");
		object obj6 = (nint)0 + (nint)24;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v28 (Il2CppClass<NGUITools>)+5C]");
		object obj8 = (nint)0 + (nint)28;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj10 = 0;
		CallingConvention callingConvention = (CallingConvention)(obj10 + 4);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj10;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		nint num4 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v39 (Il2CppClass<NGUITools>)+5C]");
		object obj11 = (nint)0 + (nint)32;
		obj11 = unmanagedFunctionPointerAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S3_v8+60]");
		object obj13 = 0;
		object obj14 = obj13;
		object obj15 = obj14 & 0x1FFF;
		object obj16 = obj15 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S4_v8 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v46 (Il2CppClass<NGUITools>)+5C]");
		object obj17 = (nint)0 + (nint)36;
		object obj18 = default;
		obj17 = obj18;
		NGUITools.mColorSpace = ColorSpace.Uninitialized;
	}
}
