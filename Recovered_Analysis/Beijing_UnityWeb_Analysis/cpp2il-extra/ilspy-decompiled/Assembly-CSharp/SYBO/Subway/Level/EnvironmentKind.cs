using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Cloud;
using SYBO.Common.Data;
using SYBO.Common.Events;

namespace SYBO.Subway.Level;

[Serializable]
public class EnvironmentKind
{
	public const string FieldPatternType = "_type";

	private EnvironmentType _type;

	private EnvironmentDensity _density;

	public static readonly EnvironmentKind Empty;

	public static readonly EnvironmentKind FillersLow;

	public static readonly EnvironmentKind FillersMedium;

	public static readonly EnvironmentKind FillersHigh;

	public static readonly EnvironmentKind Gates;

	public static readonly EnvironmentKind Tube;

	public static readonly EnvironmentKind Pillars;

	public static readonly EnvironmentKind Station;

	public static readonly EnvironmentKind Epic;

	public static readonly EnvironmentKind[] All;

	public static readonly EnvironmentKind[] AllUnconstrained;

	public static readonly EnvironmentKind[] AllWithSplitPieces;

	public EnvironmentType Type
	{
		get
		{
			//IL_02bc: Expected I, but got Obj
			//IL_02d2: Expected Obj, but got I
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c6: Expected I, but got Unknown
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Expected Obj, but got Unknown
			//IL_03de: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_0084: Expected I4, but got Obj
			//IL_0094: Expected Obj, but got I
			//IL_00a2: Expected I, but got Obj
			//IL_00b8: Expected Obj, but got I
			//IL_00e3: Expected I, but got Obj
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Expected Obj, but got Unknown
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Expected Obj, but got Unknown
			nint num = (nint)typeof(EnvironmentInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EnvironmentInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v81 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			object obj3 = EnvironmentInfo.All + 12;
			EnvironmentType result = (EnvironmentType)EnvironmentInfo.None;
			object obj4 = default;
			object obj10 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj5 = EnvironmentInfo.All + 16;
				object obj6 = obj4 << 2;
				object obj7 = obj5 + obj6;
				EnvironmentType environmentType = (EnvironmentType)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v63 (SYBO.Subway.Level.EnvironmentType)+8]");
				object obj8 = 0;
				nint num4 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v66 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num5 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v77 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v64+8]");
				bool flag;
				if ((nint)0 == (nint)_type)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v64+C]");
					flag = (nint)0 == (nint)_density;
				}
				else
				{
					flag = false;
				}
				obj10 |= flag;
				obj4++;
				if (flag)
				{
					result = environmentType;
				}
			}
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			return result;
		}
	}

	public EnvironmentDensity Density => (EnvironmentDensity)_type;

	public bool IsRepeatable => (byte)_density != 0;

	public static EnvironmentKind None
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a6: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(MovingTrain);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(MovingTrain);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HashSet<MovingTrain> activeTrains = MovingTrain._activeTrains;
			return (EnvironmentKind)activeTrains._count;
		}
	}

	public unsafe EnvironmentKind(EnvironmentType type, EnvironmentDensity density)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		object obj = ((EnvironmentType*)(int)type)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [type @ L1 (SYBO.Subway.Level.EnvironmentType)+8]");
		_ = 0;
		object obj2 = this + 8;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
	}

	public static bool operator ==(EnvironmentKind c1, EnvironmentKind c2)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		if (c1._density != EnvironmentDensity.Default)
		{
			object obj = c2 - 1;
			if ((nint)c2 == 1 || ((nint)obj != 1 && (nint)obj == 2))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c1 @ L0 (SYBO.Subway.Level.EnvironmentKind)+18]");
				return false;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c1 @ L0 (SYBO.Subway.Level.EnvironmentKind)+14]");
		return false;
	}

	public static bool operator !=(EnvironmentKind c1, EnvironmentKind c2)
	{
		if (c1._type == c2._type)
		{
			return c1._density == c2._density;
		}
		return false;
	}

	public override bool Equals(object other)
	{
		EnvironmentType type = _type;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ L1 (System.Object)+8]");
		bool flag;
		if ((nint)type == (nint)0)
		{
			EnvironmentDensity density = _density;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ L1 (System.Object)+C]");
			flag = (nint)density == (nint)0;
		}
		else
		{
			flag = false;
		}
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public bool Equals(EnvironmentKind other)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			EnvironmentType type = _type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10+8]");
			if ((nint)type == (nint)0)
			{
				EnvironmentDensity density = _density;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10+C]");
				return (nint)density == (nint)0;
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (_type == EnvironmentType.Fillers)
		{
			return 1;
		}
		return (_type == EnvironmentType.Tube) ? 1 : 0;
	}

	public override string ToString()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		object obj = this + 12;
		object obj2 = this + 8;
		object obj3 = obj2 + 493;
		object obj4 = obj3 * 29;
		return obj + obj4;
	}

	public EnvironmentKind GetValidated()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = _type;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = _density;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text = default;
		string text2 = default;
		return (EnvironmentKind)(object)(text + " " + text2);
	}

	public static bool IsValidDensity(EnvironmentKind envKind)
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_016f: Expected I4, but got Obj
		//IL_0126: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EnvironmentKind environmentKind = default;
		EnvironmentKind environmentKind2 = default;
		if (GetDefaultDensity((EnvironmentType)environmentKind) == EnvironmentDensity.Default)
		{
			nint num3 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v13 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int zDistanceTargetPosition = ((GamePositionRoot)environmentKind._type).GetZDistanceTargetPosition();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			environmentKind2._type = environmentKind._type;
			environmentKind2._density = (EnvironmentDensity)zDistanceTargetPosition;
		}
		return (byte)(int)environmentKind2 != 0;
	}

	public static EnvironmentDensity GetDefaultDensity(EnvironmentType envType)
	{
		//IL_0574: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+C]");
				bool result;
				if ((nint)0 == 1)
				{
					result = true;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+C]");
					if ((nint)0 == 2)
					{
						result = true;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+C]");
						result = (nint)0 == 4;
					}
				}
				return result ? EnvironmentDensity.Low : EnvironmentDensity.Default;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
				if ((nint)0 != 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
					if ((nint)0 == 4)
					{
						goto IL_04aa;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
					if ((nint)0 != 5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
						if ((nint)0 != 6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
							if ((nint)0 != 7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
								if ((nint)0 == 8)
								{
									goto IL_04aa;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
								if ((nint)0 != 9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
									if ((nint)0 != 10)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
										if ((nint)0 != 11)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
											if ((nint)0 != 12)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
												if ((nint)0 != 13)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
													if ((nint)0 != 14)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
														if ((nint)0 != 15)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
															if ((nint)0 == 16)
															{
																goto IL_04aa;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
															if ((nint)0 != 17)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																if ((nint)0 != 18)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																	if ((nint)0 != 19)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																		if ((nint)0 != 20)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																			if ((nint)0 != 21)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																				if ((nint)0 != 22)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																					if ((nint)0 != 23)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																						if ((nint)0 != 24)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																							if ((nint)0 != 25)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																								if ((nint)0 != 26)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																									if ((nint)0 != 27)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																										if ((nint)0 != 28)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																											if ((nint)0 != 29)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																												if ((nint)0 != 30)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																													if ((nint)0 != 31)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+8]");
																														if ((nint)0 == 32)
																														{
																															goto IL_04aa;
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				string value = "Missing switch case for " + (string)envType;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				GatedValue gatedValue = default;
				gatedValue.OnValueChanged += (EventHandler<ValueChangedEventArgs>)(object)value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				bool result2 = default;
				return result2 ? EnvironmentDensity.Low : EnvironmentDensity.Default;
			}
		}
		goto IL_04aa;
		IL_04aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L0 (SYBO.Subway.Level.EnvironmentType)+C]");
		return ((nint)0 == 0) ? EnvironmentDensity.Low : EnvironmentDensity.Default;
	}

	static EnvironmentKind()
	{
		//IL_056d: Expected I, but got Obj
		//IL_0583: Expected Obj, but got I
		//IL_05cf: Expected VT, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b8: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_0101: Expected VT, but got I4
		//IL_0114: Expected I, but got Obj
		//IL_012a: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_015d: Expected VT, but got I4
		//IL_0170: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_01b9: Expected VT, but got I4
		//IL_01cc: Expected I, but got Obj
		//IL_01e2: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I4
		//IL_0215: Expected VT, but got I4
		//IL_0228: Expected I, but got Obj
		//IL_023e: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_0275: Expected VT, but got I4
		//IL_0288: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I4
		//IL_02dd: Expected VT, but got I4
		//IL_02dd: Expected Obj, but got I4
		//IL_02f0: Expected I, but got Obj
		//IL_0306: Expected Obj, but got I
		//IL_0345: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_0345: Expected VT, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_0358: Expected I, but got Obj
		//IL_036e: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I4
		//IL_03ad: Expected VT, but got I4
		//IL_03ad: Expected Obj, but got I4
		//IL_03c0: Expected I, but got Obj
		//IL_03d6: Expected Obj, but got I
		EnvironmentInfo.DefaultMaxMidPieceCount = 100;
		EnvironmentInfo.DefaultMidPieceLengthInBlocks = 2;
		int defaultMaxMidLengthInBlocks = EnvironmentInfo.DefaultMaxMidPieceCount * EnvironmentInfo.DefaultMidPieceLengthInBlocks;
		EnvironmentInfo.DefaultMaxMidLengthInBlocks = defaultMaxMidLengthInBlocks;
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v188 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GamePositionRoot instance = GamePositionRoot.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item = default;
		item._002Ector((string)(object)instance, null, (DateTime?)(object)0, null, null, 0, null, null);
		nint num3 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v25 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item2 = default;
		item2._002Ector((string)(object)Empty, null, (DateTime?)(object)0, null, null, 0, null, null);
		nint num4 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v36 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj3 = (nint)0 + (nint)16;
		obj3 = item2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item3 = default;
		item3._002Ector((string)(object)FillersLow, null, (DateTime?)(object)1, null, null, EnvironmentInfo.DefaultMaxMidPieceCount, (ICloudUserData)2, null);
		nint num5 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v51 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj4 = (nint)0 + (nint)20;
		obj4 = item3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item4 = default;
		item4._002Ector((string)(object)FillersMedium, null, (DateTime?)(object)1, null, null, EnvironmentInfo.DefaultMaxMidPieceCount, (ICloudUserData)2, null);
		nint num6 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v66 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj5 = (nint)0 + (nint)24;
		obj5 = item4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item5 = default;
		item5._002Ector((string)(object)FillersHigh, null, (DateTime?)(object)1, null, null, EnvironmentInfo.DefaultMaxMidPieceCount, (ICloudUserData)2, null);
		nint num7 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v81 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj6 = (nint)0 + (nint)28;
		obj6 = item5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item6 = default;
		item6._002Ector((string)(object)Gates, null, (DateTime?)(object)0, null, null, 1, (ICloudUserData)4, null);
		nint num8 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v92 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj7 = (nint)0 + (nint)32;
		obj7 = item6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item7 = default;
		item7._002Ector((string)(object)Tube, null, (DateTime?)(object)0, (string)1, null, EnvironmentInfo.DefaultMaxMidPieceCount, (ICloudUserData)2, null);
		nint num9 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v107 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj8 = (nint)0 + (nint)36;
		obj8 = item7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item8 = default;
		item8._002Ector((string)(object)Pillars, (string)1, (DateTime?)(object)0, (string)1, null, EnvironmentInfo.DefaultMaxMidPieceCount, (ICloudUserData)2, (SimulatedCloudServer.Item.GetBytesFunction)1);
		nint num10 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v122 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj9 = (nint)0 + (nint)40;
		obj9 = item8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item9 = default;
		item9._002Ector((string)(object)Station, (string)1, (DateTime?)(object)0, (string)1, null, EnvironmentInfo.DefaultMaxMidPieceCount, (ICloudUserData)2, (SimulatedCloudServer.Item.GetBytesFunction)1);
		nint num11 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v137 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj10 = (nint)0 + (nint)44;
		obj10 = item9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SimulatedCloudServer.Item item10 = default;
		item10._002Ector((string)(object)Epic, (string)1, (DateTime?)(object)0, (string)1, null, EnvironmentInfo.DefaultMaxMidPieceCount, (ICloudUserData)4, (SimulatedCloudServer.Item.GetBytesFunction)4);
		nint num12 = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v152 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+5C]");
		object obj11 = (nint)0 + (nint)48;
		obj11 = item10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
