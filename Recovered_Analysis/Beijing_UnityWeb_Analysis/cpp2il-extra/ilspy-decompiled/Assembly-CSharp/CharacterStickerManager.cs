using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using Data.Migration;
using Data.Save;
using Info;
using SYBO.Subway.Info;
using UnityEngine;
using UnityEngine.U2D;

public static class CharacterStickerManager
{
	public static bool ShouldShowCharacterThemesStickerFlow()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(TopRunNotificationSlideInManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<TopRunNotificationSlideInManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TopRunNotificationSlideInManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<TopRunNotificationSlideInManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TopRunNotificationSlideInManager._002Ecctor();
		return (byte)(int)TopRunNotificationSlideInManager._instance != 0;
	}

	public static bool IsAnyCharacterWithFreeTheme()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9290");
		bool result = default;
		return result;
	}

	public static bool HasCharacterFreeTheme(Characters.CharacterId id)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = id;
		return flag;
	}

	public static bool HasCharacterNewTheme(Characters.CharacterId id)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I4
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0428: Expected I, but got Obj
		//IL_043e: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_0228: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_034c: Expected Obj, but got I
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0168: Expected I, but got Obj
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_04b2: Expected Obj, but got I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<Info.Outfits>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v131 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Outfits.HasCharacter(id))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23 (System.Boolean)+C]");
			if ((nint)0 > (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj6 = 1;
				object obj7 = default;
				object obj9 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v100+1C]");
						if ((nint)0 == 0)
						{
							nint num3 = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v107 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
							object obj8 = (nint)0 & (nint)0x200;
							if (obj8 != null)
							{
								nint num4 = (nint)typeof(CharacterManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v124 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							if (obj9 == null)
							{
								object obj10 = obj4 + 4;
								object obj11 = obj10 + 1;
								obj10 = obj11;
								object obj12 = obj11 << 2;
								object obj13 = obj4 + obj12;
								obj13 = 88;
								break;
							}
						}
						object obj14 = obj6 + 1;
						obj6 = obj14;
						continue;
					}
					object obj15 = obj4 + 4;
					object obj16 = obj15 + 1;
					obj15 = obj16;
					object obj17 = obj16 << 2;
					object obj18 = obj4 + obj17;
					obj18 = 86;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj19 = (nint)0 << 2;
					object obj20 = obj4 + obj19;
					if ((nint)obj20 == 88)
					{
						object obj21 = obj4 + 4;
						if ((nint)obj21 > -1)
						{
							object obj22 = obj21 + -1;
							obj21 = obj22;
						}
						goto IL_0579;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj23 = (nint)0 << 2;
					object obj24 = obj4 + obj23;
					if ((nint)obj24 == 86)
					{
						object obj25 = obj4 + 4;
						if ((nint)obj25 > -1)
						{
							object obj26 = obj25 + -1;
							obj25 = obj26;
						}
						goto IL_0579;
					}
				}
				object obj27 = default;
				if (obj27 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
		}
		goto IL_0579;
		IL_0579:
		return true;
	}

	public static int GetNumberOfNewCharactersOrThemes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5a: Expected Obj, but got Unknown
		//IL_0f63: Expected Obj, but got I4
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f77: Expected Obj, but got Unknown
		//IL_0f80: Expected Obj, but got I4
		//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f94: Expected Obj, but got Unknown
		//IL_0fb0: Expected I, but got Obj
		//IL_0fc6: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_0110: Expected I, but got Obj
		//IL_0b7b: Expected Obj, but got I4
		//IL_0bab: Expected Obj, but got I4
		//IL_0df0: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I4
		//IL_0eb7: Expected Obj, but got I
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2b: Expected Obj, but got Unknown
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_0376: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I4
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e61: Expected Obj, but got Unknown
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f30: Expected Obj, but got Unknown
		//IL_0bdb: Expected Obj, but got I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got I
		//IL_0275: Expected I, but got Obj
		//IL_028b: Expected Obj, but got I
		//IL_05c8: Expected Obj, but got I4
		//IL_050e: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I4
		//IL_02b6: Expected I, but got Obj
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Expected Obj, but got Unknown
		//IL_1027: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Expected Obj, but got Unknown
		//IL_1058: Expected Obj, but got I4
		//IL_1069: Expected Obj, but got I4
		//IL_0c0b: Expected Obj, but got I4
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_0c3b: Expected Obj, but got I4
		//IL_0c6b: Expected Obj, but got I4
		//IL_0c9b: Expected Obj, but got I4
		//IL_0cda: Expected Obj, but got I4
		//IL_0d0a: Expected Obj, but got I4
		//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1d: Expected Obj, but got Unknown
		//IL_0d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Expected Obj, but got Unknown
		//IL_0d57: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v307 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		int num3 = 0;
		object obj7 = default;
		object obj8;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj15 = default;
		object obj21 = default;
		int result = default;
		object obj29 = default;
		int num9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				obj8 = 58;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num4 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v154 (Il2CppClass<Info.Outfits>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num5 = (nint)typeof(Outfits);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v297 (Il2CppClass<Info.Outfits>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if ((nint)obj11 < 1)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj12 = 1;
			object obj20;
			int num8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S0_v262+1C]");
					if ((nint)0 == 0)
					{
						nint num6 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ S0_v269 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num7 = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S0_v288 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj15 == null)
						{
							object obj16 = obj5 + 4;
							object obj17 = obj16 + 1;
							obj16 = obj17;
							object obj18 = obj17 << 2;
							object obj19 = obj5 + obj18;
							obj19 = 136;
							obj20 = obj21;
							obj8 = 0;
							num8 = 1;
							break;
						}
					}
					object obj22 = obj12 + 1;
					obj12 = obj22;
					continue;
				}
				object obj23 = obj5 + 4;
				object obj24 = obj23 + 1;
				obj23 = obj24;
				object obj25 = obj24 << 2;
				object obj26 = obj5 + obj25;
				obj26 = 109;
				obj20 = obj21;
				obj8 = 0;
				num8 = num3;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj27 = (nint)0 << 2;
				object obj28 = obj5 + obj27;
				if ((nint)obj28 == 136)
				{
					result = num8;
					obj29 = obj20;
					num9 = num8;
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj30 = (nint)0 << 2;
				object obj31 = obj5 + obj30;
				if ((nint)obj31 == 109)
				{
					object obj32 = obj5 + 4;
					if ((nint)obj32 > -1)
					{
						object obj33 = obj32 + -1;
						obj32 = obj33;
					}
					obj21 = obj20;
					goto IL_1143;
				}
			}
			if (obj20 != null)
			{
				num9 = num8;
				obj8 = 51;
				break;
			}
			obj21 = 0;
			goto IL_1143;
			IL_1143:
			num9 = num8;
			num3 = num8;
		}
		object obj34 = obj8 - 11;
		object obj39 = default;
		object obj40 = default;
		int num10 = default;
		if ((nint)obj8 != 11)
		{
			if ((nint)obj34 != 1)
			{
				if ((nint)obj34 != 2 && (nint)obj34 != 3 && (nint)obj34 != 4)
				{
					if ((nint)obj34 != 5)
					{
						if ((nint)obj34 != 6 && (nint)obj34 != 7)
						{
							if ((nint)obj34 != 8)
							{
								if ((nint)obj34 != 9 && (nint)obj34 != 10)
								{
									if ((nint)obj34 != 11)
									{
										if ((nint)obj34 != 12 && (nint)obj34 != 13 && (nint)obj34 != 14 && (nint)obj34 != 15 && (nint)obj34 != 16 && (nint)obj34 != 17 && (nint)obj34 != 18 && (nint)obj34 != 19 && (nint)obj34 != 20 && (nint)obj34 != 21 && (nint)obj34 != 22 && (nint)obj34 != 23 && (nint)obj34 != 24 && (nint)obj34 != 25 && (nint)obj34 != 26 && (nint)obj34 != 27 && (nint)obj34 != 28 && (nint)obj34 != 29)
										{
											if ((nint)obj34 != 30)
											{
												if ((nint)obj34 != 31)
												{
													if ((nint)obj34 != 32)
													{
														if ((nint)obj34 != 33 && (nint)obj34 != 34 && (nint)obj34 != 35 && (nint)obj34 != 36 && (nint)obj34 != 37 && (nint)obj34 != 38 && (nint)obj34 != 39)
														{
															if ((nint)obj34 != 40)
															{
																if ((nint)obj34 != 41 && (nint)obj34 != 42 && (nint)obj34 != 43)
																{
																	if ((nint)obj34 != 44)
																	{
																		if ((nint)obj34 != 45 && (nint)obj34 != 46 && (nint)obj34 == 47)
																		{
																			object obj35 = obj5 + 4;
																			object obj36 = obj35 + 1;
																			obj35 = obj36;
																			object obj37 = obj36 << 2;
																			object obj38 = obj5 + obj37;
																			obj38 = 134;
																			result = num3;
																			obj29 = obj21;
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																		obj39 = obj40;
																		object obj42 = default;
																		object obj41 = obj42;
																		num10 = num3;
																		obj8 = 56;
																	}
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																obj39 = obj40;
																object obj43 = default;
																object obj41 = obj43;
																num10 = num9;
																obj8 = 56;
															}
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														obj39 = obj40;
														object obj44 = default;
														object obj41 = obj44;
														num10 = num9;
														obj8 = 56;
													}
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												obj39 = obj40;
												object obj45 = default;
												object obj41 = obj45;
												num10 = num3;
												obj8 = 56;
											}
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										obj39 = obj40;
										object obj46 = default;
										object obj41 = obj46;
										num10 = num3;
										obj8 = 56;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj39 = obj40;
								object obj47 = default;
								object obj41 = obj47;
								num10 = num3;
								obj8 = 56;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj39 = obj40;
						object obj48 = default;
						object obj41 = obj48;
						num10 = num3;
						obj8 = 56;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				obj39 = obj40;
				object obj49 = default;
				object obj41 = obj49;
				num10 = num3;
				obj8 = 56;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj39 = obj40;
			object obj50 = default;
			object obj41 = obj50;
			num10 = num3;
			obj8 = 56;
		}
		if ((nint)obj8 == 56)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj51 = default;
			if (obj39 == obj51)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				result = num10;
				object obj52 = default;
				obj29 = obj52;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj53 = (nint)0 << 2;
			object obj54 = obj5 + obj53;
			if ((nint)obj54 == 136)
			{
				object obj55 = obj5 + 4;
				if ((nint)obj55 > -1)
				{
					object obj56 = obj55 + -1;
					obj55 = obj56;
				}
				goto IL_117d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj57 = (nint)0 << 2;
			object obj58 = obj5 + obj57;
			if ((nint)obj58 == 134)
			{
				object obj59 = obj5 + 4;
				if ((nint)obj59 > -1)
				{
					object obj60 = obj59 + -1;
					obj59 = obj60;
				}
				goto IL_117d;
			}
		}
		if (obj29 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_117d;
		IL_117d:
		return result;
	}

	public unsafe static bool HasThemeBeenSeenForCharacter(Characters.CharacterId id, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cde: Expected Obj, but got Unknown
		//IL_0ce7: Expected Obj, but got I4
		//IL_0cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfb: Expected Obj, but got Unknown
		//IL_0d04: Expected Obj, but got I4
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Expected Obj, but got Unknown
		//IL_0d21: Expected Obj, but got I4
		//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d35: Expected Obj, but got Unknown
		//IL_0d3e: Expected Obj, but got I4
		//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Expected Obj, but got Unknown
		//IL_0d7f: Expected Obj, but got I4
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Expected Obj, but got Unknown
		//IL_0d96: Expected Obj, but got I4
		//IL_0da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Expected Obj, but got Unknown
		//IL_0db3: Expected Obj, but got I4
		//IL_0dc7: Expected I, but got Obj
		//IL_0ddd: Expected Obj, but got I
		//IL_14a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a9: Expected VT, but got Unknown
		//IL_14b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b7: Expected I4, but got Unknown
		//IL_14c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c5: Expected Obj, but got Unknown
		//IL_14ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d3: Expected Obj, but got Unknown
		//IL_14dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e1: Expected Obj, but got Unknown
		//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ef: Expected Obj, but got Unknown
		//IL_14f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fd: Expected Obj, but got Unknown
		//IL_1506: Unknown result type (might be due to invalid IL or missing references)
		//IL_150b: Expected Obj, but got Unknown
		//IL_151d: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01d4: Expected I, but got Obj
		//IL_01ea: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0ea4: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0215: Expected I, but got Obj
		//IL_0e08: Expected Obj, but got I4
		//IL_0e2b: Expected I, but got Obj
		//IL_0e41: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I
		//IL_0e70: Expected Obj, but got I
		//IL_00bc: Expected I, but got Obj
		//IL_02ca: Expected VT, but got Obj
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_0375: Expected F4, but got Obj
		//IL_0370: Expected native int or pointer, but got VT
		//IL_038a: Expected F4, but got I
		//IL_0385: Expected native int or pointer, but got VT
		//IL_03be: Expected I, but got Obj
		//IL_03d4: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_0ee7: Expected Obj, but got I4
		//IL_0ef4: Expected F4, but got Obj
		//IL_0eef: Expected native int or pointer, but got VT
		//IL_0f3b: Expected I, but got Obj
		//IL_0f51: Expected Obj, but got I
		//IL_03ff: Expected I, but got Obj
		//IL_044c: Expected I, but got Obj
		//IL_0fbe: Expected Obj, but got F4
		//IL_0fcb: Expected I4, but got Obj
		//IL_0fe6: Expected I, but got Obj
		//IL_0ffc: Expected Obj, but got I
		//IL_04c4: Expected I4, but got F4
		//IL_154c: Expected F4, but got I4
		//IL_1547: Expected native int or pointer, but got VT
		//IL_1561: Expected F4, but got I
		//IL_155c: Expected native int or pointer, but got VT
		//IL_1572: Expected F4, but got I4
		//IL_1572: Expected I4, but got VT
		//IL_1591: Expected F4, but got Obj
		//IL_158c: Expected native int or pointer, but got VT
		//IL_15a6: Expected F4, but got I
		//IL_15a1: Expected native int or pointer, but got VT
		//IL_1603: Expected Obj, but got F4
		//IL_1611: Expected I, but got Obj
		//IL_1627: Expected Obj, but got I
		//IL_102b: Expected Obj, but got I4
		//IL_04fc: Expected I, but got Obj
		//IL_0549: Expected I, but got Obj
		//IL_0841: Expected I, but got Obj
		//IL_0857: Expected Obj, but got I
		//IL_05be: Expected VT, but got I4
		//IL_05be: Expected Obj, but got VT
		//IL_0882: Expected I, but got Obj
		//IL_05d0: Expected I4, but got Obj
		//IL_05eb: Expected I, but got Obj
		//IL_0601: Expected Obj, but got I
		//IL_08dc: Expected I, but got Obj
		//IL_08f2: Expected Obj, but got I
		//IL_104e: Expected VT, but got I4
		//IL_120a: Expected Obj, but got I
		//IL_07bd: Expected Obj, but got F4
		//IL_062c: Expected I, but got Obj
		//IL_0a05: Expected Obj, but got I4
		//IL_0a0e: Expected Obj, but got I4
		//IL_0a21: Expected VT, but got Obj
		//IL_0a2e: Expected F4, but got Obj
		//IL_0a29: Expected native int or pointer, but got VT
		//IL_0a40: Expected F4, but got I
		//IL_0a3b: Expected native int or pointer, but got VT
		//IL_0a51: Expected Ref, but got VT
		//IL_091d: Expected I, but got Obj
		//IL_10c5: Expected F4, but got Obj
		//IL_10c0: Expected native int or pointer, but got VT
		//IL_10da: Expected F4, but got I
		//IL_10d5: Expected native int or pointer, but got VT
		//IL_10f9: Expected I, but got Obj
		//IL_110f: Expected Obj, but got I
		//IL_0682: Expected Obj, but got I4
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got Unknown
		//IL_06f9: Expected Obj, but got I4
		//IL_0711: Expected Obj, but got I
		//IL_0727: Expected I, but got Obj
		//IL_073d: Expected Obj, but got I
		//IL_0a63: Expected F4, but got Obj
		//IL_0a5e: Expected native int or pointer, but got VT
		//IL_0a78: Expected F4, but got I
		//IL_0a73: Expected native int or pointer, but got VT
		//IL_0a89: Expected Ref, but got VT
		//IL_0aa9: Expected I, but got Obj
		//IL_0abf: Expected Obj, but got I
		//IL_0977: Expected I, but got Obj
		//IL_098d: Expected Obj, but got I
		//IL_116e: Expected I4, but got Obj
		//IL_1094: Expected F4, but got Obj
		//IL_108f: Expected native int or pointer, but got VT
		//IL_1264: Expected I4, but got Obj
		//IL_127b: Expected F4, but got Obj
		//IL_1276: Expected native int or pointer, but got VT
		//IL_1290: Expected F4, but got I
		//IL_128b: Expected native int or pointer, but got VT
		//IL_129d: Expected VT, but got I4
		//IL_12c7: Expected Obj, but got I
		//IL_123c: Expected Obj, but got I
		//IL_1185: Unknown result type (might be due to invalid IL or missing references)
		//IL_118a: Expected Obj, but got Unknown
		//IL_07da: Expected I, but got Obj
		//IL_0768: Expected I, but got Obj
		//IL_1300: Expected Obj, but got I
		//IL_0aea: Expected I, but got Obj
		//IL_09b8: Expected I, but got Obj
		//IL_1654: Expected Obj, but got I4
		//IL_133f: Expected Obj, but got I
		//IL_1350: Expected VT, but got Obj
		//IL_137b: Expected I, but got Obj
		//IL_1391: Expected Obj, but got I
		//IL_0b32: Expected Obj, but got F4
		//IL_13bb: Expected I4, but got Obj
		//IL_13d2: Expected F4, but got Obj
		//IL_13cd: Expected native int or pointer, but got VT
		//IL_13e4: Expected F4, but got I
		//IL_13df: Expected native int or pointer, but got VT
		//IL_13f1: Expected VT, but got I4
		//IL_1402: Expected F4, but got Obj
		//IL_13fd: Expected native int or pointer, but got VT
		//IL_1414: Expected F4, but got I
		//IL_140f: Expected native int or pointer, but got VT
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Expected Obj, but got Unknown
		//IL_0b99: Expected Obj, but got I4
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Expected Obj, but got Unknown
		//IL_0bca: Expected I, but got Obj
		//IL_0be0: Expected Obj, but got I
		//IL_0b50: Expected I, but got Obj
		//IL_144e: Expected Obj, but got I
		//IL_0ccb: Expected I4, but got Obj
		//IL_0ccb: Expected Obj, but got I4
		//IL_0c0b: Expected I, but got Obj
		//IL_0c4b: Expected I, but got Obj
		//IL_0c61: Expected Obj, but got I
		//IL_1480: Expected Obj, but got I
		//IL_0c8c: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 320;
		object obj2 = transform + 208;
		obj2 = 0;
		_ = 0;
		object obj3 = transform + 192;
		obj3 = 0;
		_ = 0;
		object obj4 = transform + 180;
		obj4 = 0;
		_ = 0;
		object obj5 = transform + 112;
		obj5 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj5 - -64;
		obj6 = 0;
		object obj7 = transform + 100;
		obj7 = 0;
		_ = 0;
		object obj8 = transform + 88;
		obj8 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v317 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(transform + 296);
		int num3 = transform + 224;
		Transform transform2 = (Transform)(transform + 72);
		Transform transform3 = (Transform)(transform + 56);
		object obj10 = transform + 44;
		object obj11 = transform + 32;
		object obj12 = transform + 24;
		object obj13 = transform + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
		bool result;
		if ((UnityEngine.Object)0 != null)
		{
			string tag = ((Component)id).tag;
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v299 (Il2CppClass<NGUITools>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num5 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v313 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj15 = id + 20;
			UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>((GameObject)(object)tag);
			obj15 = uIScrollView;
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v290 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S1_v304 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
			if ((UnityEngine.Object)0 != null)
			{
				((Component)id).tag = null;
				result = false;
				goto IL_0e8d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num8 = 0;
			_ = 0;
			object obj18 = default;
			object obj17 = obj18 + 16;
			obj17 = id;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
			object obj19 = (nint)0 + (nint)68;
			obj19 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
		object obj20 = 0;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v280 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v63+68]");
		if (!((UnityEngine.Object)0 != null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v50+68]");
			Vector2 clipSoftness = ((UIPanel)0).clipSoftness;
			obj2 = ((int*)num3)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (System.Int32)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S1_v57+68]");
			Camera anchorCamera = ((UIRect)0).anchorCamera;
			transform.localPosition = (Vector3)anchorCamera;
			obj3 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			transform2 = (Transform)obj2;
			Transform transform4 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			object obj24 = obj3 + (object)transform2;
			obj3 = obj24;
			object obj25 = obj3 + 4;
			transform3 = (Transform)obj2;
			Transform transform5 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v48 (UnityEngine.Transform)+4]");
			object obj27 = obj26 + 0;
			obj25 = obj27;
			Transform parentInternal = ((Transform)(object)anchorCamera).parentInternal;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = parentInternal.InverseTransformPoint(vector);
			obj3 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v50+8]");
			_ = 0;
			nint num11 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v96 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num12 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v292 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj12 = ((int*)index)->m_value;
			((Vector3*)(nint)vector)->x = (float)obj12;
			Vector3 vector4 = (Vector4)vector;
			obj4 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v52+8]");
			_ = 0;
			int height = Screen.height;
			int num13 = height / 320;
			nint num14 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S1_v98 (Il2CppClass<DeviceInfo>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num15 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S1_v276 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S0_v109 (System.Int32)+14]");
			float num17;
			object obj30;
			int num18;
			if ((nint)0 == 1)
			{
				int height2 = Screen.height;
				float num16 = (float)height2 / 384f;
				num17 = 48f * num16;
				obj30 = obj4;
				num18 = (int)num16;
			}
			else
			{
				num17 = 16f * (float)num13;
				obj30 = obj4;
				num18 = num13;
			}
			float num19 = (float)obj30 - num17;
			object obj31 = num19;
			((int*)num3)->m_value = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			_ = 0;
			nint num20 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v117 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num21 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S0_v277 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = ((int*)num3)->m_value;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (System.Int32)+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			((Vector2*)transform)->set_Item((int)vector, (float)num18);
			obj4 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			transform2 = (Transform)obj2;
			Transform transform6 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			float num22 = (float)(nint)((UnityEngine.Object)transform2).m_CachedPtr * 0.5f;
			float num23 = vector.x - num22;
			float num24 = (float)obj4 + num23;
			obj4 = num24;
			nint num25 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S0_v136 (Il2CppClass<UICamera>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num26 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v273 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera eventHandler = UICamera.eventHandler;
			GameObject gameObject = ((Component)id).gameObject;
			int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
			Sprite sprite = null;
			ComputeShader computeShader = null;
			float num27 = float.MaxValue;
			while ((nint)sprite < siblingIndex)
			{
				bool flag = ((SpriteAtlas)(object)gameObject).CanBindTo(sprite);
				((Transform)vector).localPosition = (Vector3)flag;
				((int*)num3)->m_value = (int)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				_ = 0;
				nint num28 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ S0_v252 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj34 = (nint)0 & (nint)0x200;
				if (obj34 != null)
				{
					nint num29 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S0_v269 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				transform.position = (Vector3)flag;
				bool touchSupported = Input.touchSupported;
				if ((touchSupported ? 1 : 0) > (false ? 1 : 0))
				{
					Input.GetTouch_Injected(num3, out *(Touch*)null);
					obj5 = ((int*)num3)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (System.Int32)+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (System.Int32)+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (System.Int32)+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (System.Int32)+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (System.Int32)+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (System.Int32)+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (System.Int32)+38]");
					_ = 0;
					object obj35 = obj5 - -64;
					object obj36 = num3 - -64;
					obj35 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
					obj = 0;
					transform = (Transform)obj;
					nint num30 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ S1_v260 (Il2CppClass<UnityEngine.Vector2>)+BA]");
					object obj37 = (nint)0 & (nint)0x200;
					if (obj37 != null)
					{
						nint num31 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ S1_v269 (Il2CppClass<UnityEngine.Vector2>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj13 = transform;
					((Vector3*)(nint)vector)->x = (float)obj13;
					Vector3 vector7 = (Vector4)vector;
					obj8 = transform2;
					_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				}
				else
				{
					Vector2 mouseScrollDelta = Input.mouseScrollDelta;
					obj8 = vector.x;
					_ = vector.z;
				}
				((Vector3*)(nint)vector)->x = (float)obj8;
				Vector3 vector8 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v32+8]");
				((Vector3*)(nint)vector8)->z = 0f;
				Vector3 vector9 = ((Camera)(object)eventHandler).ScreenToViewportPoint(vector);
				nint num32 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ S2_v91 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num33 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ S2_v95 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float value = (float)transform - (float)((int*)num3)->m_value;
				float num34 = Math.Abs(value);
				bool flag2 = num34 < num27;
				bool flag3 = !flag2;
				bool flag4 = (byte)(int)computeShader != 0;
				if (!flag3)
				{
					flag4 = flag;
				}
				Sprite sprite2 = (Sprite)(sprite + 1);
				if (flag2)
				{
					num27 = num34;
				}
				sprite = sprite2;
				computeShader = (ComputeShader)flag4;
			}
			nint num35 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ S0_v152 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num36 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S0_v240 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (computeShader.FindKernel(null) != 0)
			{
				string tag2 = ((Component)(object)computeShader).tag;
				nint num37 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S2_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj40 = (nint)0 & (nint)0x200;
				if (obj40 != null)
				{
					nint num38 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S2_v76 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+1C]");
				if ((UnityEngine.Object)0 != (UnityEngine.Object)(object)tag2)
				{
					string tag3 = ((Component)(object)computeShader).tag;
					nint num39 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ S0_v231 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj41 = (nint)0 & (nint)0x200;
					if (obj41 != null)
					{
						nint num40 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ S0_v236 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+18]");
					bool flag5 = (UnityEngine.Object)0 == (UnityEngine.Object)(object)tag3;
					result = true;
					if (!flag5)
					{
						goto IL_0e8d;
					}
				}
				object obj42 = id + 24;
				obj42 = 0;
				_ = 1;
				transform.position = (Vector3)computeShader;
				((Vector3*)(nint)vector)->x = (float)transform;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				transform2.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref *(Vector3*)vector);
				((Vector3*)(nint)vector)->x = (float)obj3;
				Vector3 vector10 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((Vector3*)(nint)vector10)->z = 0f;
				transform3.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref *(Vector3*)vector);
				obj10 = transform3;
				_ = ((UnityEngine.Object)transform3).m_CachedPtr;
				nint num41 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ S0_v175 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj43 = (nint)0 & (nint)0x200;
				if (obj43 != null)
				{
					nint num42 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ S0_v222 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((int*)num3)->m_value = (int)transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj10;
				Vector3 vector11 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v50+8]");
				((Vector3*)(nint)vector11)->z = 0f;
				Quaternion quaternion = Quaternion.FromToRotation((Vector3)num3, vector);
				obj7 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v52+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
				if (!((UIScrollView)0).canMoveVertically)
				{
					obj7 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
				if (!((UIScrollView)0).shouldMoveHorizontally)
				{
					_ = 0f;
				}
				_ = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
				string tag4 = ((Component)0).tag;
				transform.localPosition = (Vector3)anchorCamera;
				transform2 = (Transform)obj7;
				Transform transform7 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29+8]");
				((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
				nint num43 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ S1_v182 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num44 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ S1_v211 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((int*)num3)->m_value = (int)transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)transform2;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Quaternion quaternion2 = Quaternion.FromToRotation((Vector3)num3, vector);
				((Vector3*)(nint)vector)->x = (float)transform3;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
				SpringPosition springPosition = SpringPosition.Begin((GameObject)(object)tag4, vector, 8f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num45 = 0;
				_ = 0;
				object obj46 = default;
				object obj45 = obj46 + 16;
				obj45 = id;
				object obj47 = springPosition + 28;
				obj47 = obj46;
				string tag5 = ((Component)(object)computeShader).tag;
				nint num46 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ S2_v63 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj48 = (nint)0 & (nint)0x200;
				if (obj48 != null)
				{
					nint num47 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ S2_v72 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+1C]");
				if ((UnityEngine.Object)0 != (UnityEngine.Object)(object)tag5)
				{
					string tag6 = ((Component)(object)computeShader).tag;
					nint num48 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ S0_v212 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj49 = (nint)0 & (nint)0x200;
					if (obj49 != null)
					{
						nint num49 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ S0_v217 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (SYBO.Subway.Info.Characters+CharacterId)+18]");
					int num50 = ((ComputeShader)0).FindKernel(tag6);
					result = true;
					if (num50 != 0)
					{
						goto IL_0e8d;
					}
				}
				string tag7 = ((Component)(object)computeShader).tag;
				((CoinBoxSizer)id).updateAutomatically = (byte)(int)tag7 != 0;
			}
		}
		result = false;
		goto IL_0e8d;
		IL_0e8d:
		return result;
	}

	public static bool IsThemeUnlockedForCharacter(Characters.CharacterId id, int index)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return PlayerInfoMigrator.MigrateAdsSave((Dictionary<Key, string>)id, (IDictionary<string, object>)index);
	}

	public static bool HasCharacterBeenSeen(Characters.CharacterId id)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_039e: Expected I, but got Obj
		//IL_03b4: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_02c2: Expected Obj, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_0419: Expected Obj, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<Info.Outfits>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v118 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Outfits.HasCharacter(id))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23 (System.Boolean)+C]");
			if ((nint)0 > (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj6 = 1;
				object obj7 = default;
				object obj8 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v100+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							if (obj8 == null)
							{
								object obj9 = obj4 + 4;
								object obj10 = obj9 + 1;
								obj9 = obj10;
								object obj11 = obj10 << 2;
								object obj12 = obj4 + obj11;
								obj12 = 88;
								break;
							}
						}
						object obj13 = obj6 + 1;
						obj6 = obj13;
						continue;
					}
					object obj14 = obj4 + 4;
					object obj15 = obj14 + 1;
					obj14 = obj15;
					object obj16 = obj15 << 2;
					object obj17 = obj4 + obj16;
					obj17 = 86;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj18 = (nint)0 << 2;
					object obj19 = obj4 + obj18;
					if ((nint)obj19 == 88)
					{
						object obj20 = obj4 + 4;
						if ((nint)obj20 > -1)
						{
							object obj21 = obj20 + -1;
							obj20 = obj21;
						}
						goto IL_04e0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj22 = (nint)0 << 2;
					object obj23 = obj4 + obj22;
					if ((nint)obj23 == 86)
					{
						object obj24 = obj4 + 4;
						if ((nint)obj24 > -1)
						{
							object obj25 = obj24 + -1;
							obj24 = obj25;
						}
						goto IL_04e0;
					}
				}
				object obj26 = default;
				if (obj26 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
		}
		goto IL_04e0;
		IL_04e0:
		return true;
	}

	public static bool IsCharacterUnlocked(Characters.CharacterId id)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return CharacterManager.IsCharacterAvailable(id);
	}
}
