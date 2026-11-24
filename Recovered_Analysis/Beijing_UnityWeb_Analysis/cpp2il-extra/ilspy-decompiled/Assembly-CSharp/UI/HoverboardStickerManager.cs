using System;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using UnityEngine;

namespace UI;

public static class HoverboardStickerManager
{
	public static bool ShouldShowHoverboardStickerFlow()
	{
		//IL_0196: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_0226: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_025f: Expected I4, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_0149: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (ColorData._instance != null)
		{
			_0021_00210[] instance = (_0021_00210[])(object)Resources.LoadAll<T>("Info/ColorData");
			nint num5 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppClass<UI.ColorData>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v39 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ColorData._instance = (ColorData)(object)instance;
		}
		nint num7 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v16 (Il2CppClass<UI.ColorData>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v23 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)ColorData._instance != 0;
	}

	public static bool IsAnyBoardOrAbilityFree()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9290");
		bool result = default;
		return result;
	}

	public static int GetNumberOfNewHoverboardsAndThemes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_101a: Unknown result type (might be due to invalid IL or missing references)
		//IL_101f: Expected Obj, but got Unknown
		//IL_1028: Expected Obj, but got I4
		//IL_1037: Unknown result type (might be due to invalid IL or missing references)
		//IL_103c: Expected Obj, but got Unknown
		//IL_1058: Expected I, but got Obj
		//IL_106e: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I4
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected Obj, but got Unknown
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_10a8: Expected I, but got Obj
		//IL_10be: Expected Obj, but got I
		//IL_027f: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_0426: Expected I, but got Obj
		//IL_0eb5: Expected Obj, but got I
		//IL_02c0: Expected I, but got Obj
		//IL_0f7c: Expected Obj, but got I
		//IL_04ac: Expected I, but got Obj
		//IL_04c2: Expected Obj, but got I
		//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef0: Expected Obj, but got Unknown
		//IL_0351: Expected I, but got Obj
		//IL_0367: Expected Obj, but got I
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Expected Obj, but got Unknown
		//IL_04ed: Expected I, but got Obj
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Expected Obj, but got Unknown
		//IL_0577: Expected Obj, but got I4
		//IL_0392: Expected I, but got Obj
		//IL_0ff0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff5: Expected Obj, but got Unknown
		//IL_0413: Expected Obj, but got I4
		//IL_05d4: Expected I, but got Obj
		//IL_05ea: Expected Obj, but got I
		//IL_0615: Expected I, but got Obj
		//IL_067e: Expected Obj, but got I4
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1f: Expected Obj, but got Unknown
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Expected Obj, but got Unknown
		//IL_0d59: Expected Obj, but got I4
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d98: Expected Obj, but got Unknown
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected Obj, but got Unknown
		//IL_0dd2: Expected Obj, but got I4
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected Obj, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected Obj, but got Unknown
		//IL_0e2d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<Info.Boards>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v299 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj11 = default;
		object obj13 = default;
		object obj15 = default;
		object obj17 = default;
		IntPtr method = default;
		object obj18 = default;
		object obj20 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				obj7 = 69;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S0_v129 (Il2CppClass<Info.Boards>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S0_v285 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S0_v142+14]");
			object obj9 = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S0_v142+14]");
			if ((nint)0 == 2 || ((nint)obj9 != 1 && (nint)obj9 != 2 && (nint)obj9 == 3))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S0_v142+10]");
				if ((nint)0 == 0)
				{
					nint num5 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S0_v249 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num6 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S0_v276 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj11 == null)
					{
						nint num7 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ S0_v260 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num8 = (nint)typeof(BoardManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S0_v268 (Il2CppClass<Data.Managers.BoardManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj13 != null)
						{
							obj7 = 34;
							break;
						}
					}
				}
			}
			nint num9 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S0_v150 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num10 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ S0_v233 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj15 == null)
			{
				continue;
			}
			nint num11 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v166 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num12 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v223 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			((Func<HoverboardThemes.HoverboardTheme, bool>)5463)._002Ector(obj17, method);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj18 == null)
			{
				continue;
			}
			nint num13 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ S0_v205 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num14 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S0_v213 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj20 != null)
			{
				obj7 = 63;
				break;
			}
		}
		object obj21 = obj7 - 14;
		int result = default;
		if ((nint)obj7 != 14 && (nint)obj21 != 1)
		{
			if ((nint)obj21 != 2 && (nint)obj21 != 3)
			{
				if ((nint)obj21 == 4)
				{
					goto IL_0e32;
				}
				if ((nint)obj21 != 5 && (nint)obj21 != 6 && (nint)obj21 != 7 && (nint)obj21 != 8)
				{
					if ((nint)obj21 == 9)
					{
						goto IL_0e32;
					}
					if ((nint)obj21 != 10 && (nint)obj21 != 11)
					{
						if ((nint)obj21 == 12)
						{
							goto IL_0e32;
						}
						if ((nint)obj21 != 13 && (nint)obj21 != 14 && (nint)obj21 != 15)
						{
							if ((nint)obj21 == 16)
							{
								goto IL_0e32;
							}
							if ((nint)obj21 != 17 && (nint)obj21 != 18)
							{
								if ((nint)obj21 == 19)
								{
									goto IL_0e32;
								}
								if ((nint)obj21 != 20)
								{
									if ((nint)obj21 == 21)
									{
										goto IL_0e32;
									}
									if ((nint)obj21 != 22 && (nint)obj21 != 23 && (nint)obj21 != 24 && (nint)obj21 != 25 && (nint)obj21 != 26 && (nint)obj21 != 27 && (nint)obj21 != 28)
									{
										if ((nint)obj21 == 29)
										{
											goto IL_0e32;
										}
										if ((nint)obj21 != 30 && (nint)obj21 != 31 && (nint)obj21 != 32 && (nint)obj21 != 33 && (nint)obj21 != 34 && (nint)obj21 != 35 && (nint)obj21 != 36 && (nint)obj21 != 37 && (nint)obj21 != 38)
										{
											if ((nint)obj21 == 39 || (nint)obj21 == 40 || (nint)obj21 == 41)
											{
												goto IL_0e32;
											}
											if ((nint)obj21 != 42 && (nint)obj21 != 43 && (nint)obj21 != 44)
											{
												if ((nint)obj21 == 45)
												{
													goto IL_0e32;
												}
												if ((nint)obj21 != 46 && (nint)obj21 != 47)
												{
													if ((nint)obj21 == 48)
													{
														goto IL_0e32;
													}
													if ((nint)obj21 != 49)
													{
														if ((nint)obj21 != 50 && (nint)obj21 != 51)
														{
															if ((nint)obj21 == 52)
															{
																goto IL_0e32;
															}
															if ((nint)obj21 != 53 && (nint)obj21 != 54 && (nint)obj21 == 55)
															{
																object obj22 = obj4 + 4;
																object obj23 = obj22 + 1;
																obj22 = obj23;
																object obj24 = obj23 << 2;
																object obj25 = obj4 + obj24;
																obj25 = 205;
															}
														}
													}
													else
													{
														object obj26 = obj4 + 4;
														object obj27 = obj26 + 1;
														obj26 = obj27;
														object obj28 = obj27 << 2;
														object obj29 = obj4 + obj28;
														obj29 = 207;
														result = 1;
													}
												}
											}
										}
									}
								}
								else
								{
									object obj30 = obj4 + 4;
									object obj31 = obj30 + 1;
									obj30 = obj31;
									object obj32 = obj31 << 2;
									object obj33 = obj4 + obj32;
									obj33 = 207;
									result = 1;
								}
							}
						}
					}
				}
			}
			goto IL_1121;
		}
		goto IL_0e32;
		IL_0e32:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj34 = default;
		object obj35 = default;
		if (obj34 == obj35)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_1121;
		IL_11af:
		return result;
		IL_1121:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj36 = (nint)0 << 2;
			object obj37 = obj4 + obj36;
			if ((nint)obj37 == 207)
			{
				object obj38 = obj4 + 4;
				if ((nint)obj38 > -1)
				{
					object obj39 = obj38 + -1;
					obj38 = obj39;
				}
				goto IL_11af;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj40 = (nint)0 << 2;
			object obj41 = obj4 + obj40;
			if ((nint)obj41 == 205)
			{
				object obj42 = obj4 + 4;
				if ((nint)obj42 > -1)
				{
					object obj43 = obj42 + -1;
					obj42 = obj43;
				}
				goto IL_11af;
			}
		}
		object obj44 = default;
		if (obj44 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_11af;
	}
}
