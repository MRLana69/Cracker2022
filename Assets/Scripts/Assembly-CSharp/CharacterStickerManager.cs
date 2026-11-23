using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Info;

public static class CharacterStickerManager
{
	public static bool ShouldShowCharacterThemesStickerFlow()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = (byte)(~(instance._hasShownHoverboardPopup ? 1u : 0u)) != 0;
		bool result = false;
		if (!flag)
		{
			bool flag2 = (byte)(~(instance._hasShownFacebookPopup ? 1u : 0u)) != 0;
			result = false;
			if (!flag2)
			{
				bool hasShownMission1Popup = instance._hasShownMission1Popup;
				result = hasShownMission1Popup;
			}
		}
		return result;
	}

	public static bool IsAnyCharacterWithFreeTheme()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected Obj, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected Obj, but got Unknown
		//IL_0491: Expected Obj, but got I4
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Obj, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_05d0: Expected Obj, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected Obj, but got Unknown
		//IL_0450: Expected Obj, but got I4
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got I
		//IL_0442: Expected Obj, but got I4
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_0378: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj13 = default;
		object obj15 = default;
		object obj17 = default;
		object obj18 = default;
		bool flag3 = default;
		object obj20 = default;
		bool flag4 = default;
		object obj24 = default;
		bool flag6 = default;
		bool result;
		object obj25 = default;
		bool flag8 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj7;
			object obj19;
			bool flag2;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					obj7 = 8;
					goto IL_05de;
				}
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
							if (obj8 == null)
							{
								continue;
							}
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v95+C]");
								if ((nint)0 < (nint)1)
								{
									continue;
								}
								_ = 0;
								object obj9 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
									_ = 0;
									object obj10 = obj + 32;
									obj = obj10;
									_ = 0;
									object obj11 = 1;
									while (true)
									{
										_ = 0;
										object obj12 = obj + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											break;
										}
										if (obj13 != null)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
											object obj14 = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v188+8]");
											if ((nint)0 != 0)
											{
												goto IL_037d;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											if (obj15 != null)
											{
												goto IL_037d;
											}
											goto IL_036e;
										}
										goto IL_0447;
										IL_037d:
										object obj16 = obj11 + 1;
										obj11 = obj16;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
									bool flag = obj17 != obj18;
									obj19 = obj17;
									flag2 = flag3;
									if (!flag)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											obj7 = 0;
											goto IL_04a5;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
										obj19 = obj20;
										flag2 = flag4;
									}
									_ = 0;
									object obj21 = obj + 16;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_068d;
									}
									goto IL_0819;
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
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			goto IL_0567;
			IL_05de:
			object obj22 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BA");
			bool flag5 = (nint)obj7 == 7;
			return (byte)((flag5 ? 1u : 0u) & 1u) != 0;
			IL_04a5:
			_ = 0;
			object obj23 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj7 == null || ((nint)obj7 != 1 && (nint)obj7 == 2))
				{
					continue;
				}
				goto IL_05de;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0567;
			IL_0567:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj19 = obj24;
			flag2 = flag6;
			goto IL_0819;
			IL_036e:
			obj7 = 7;
			goto IL_04a5;
			IL_068d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			result = flag2;
			break;
			IL_0447:
			obj7 = 2;
			goto IL_04a5;
			IL_0819:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj25 == obj19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag7 = (nint)0 == 1;
				obj7 = 0;
				if (!flag7)
				{
					goto IL_05de;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				flag2 = flag8;
			}
			_ = 0;
			object obj26 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag9 = (nint)0 != 1;
			result = flag2;
			if (flag9)
			{
				break;
			}
			goto IL_068d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result;
	}

	public static bool HasCharacterFreeTheme(Characters.CharacterType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<CharacterTheme> list = CharacterThemes.TryGetCustomThemesForChar(type);
		bool result = default;
		if (list != null && list._size >= 1)
		{
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj5 = 1;
			bool flag2 = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			bool flag5 = default;
			bool flag7 = default;
			while (true)
			{
				_ = 0;
				object obj6 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					bool flag = !flag2;
					result = flag2;
					if (flag)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v78+8]");
						if ((nint)0 != 0)
						{
							goto IL_0213;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									bool flag3 = obj8 == null;
									result = flag2;
									if (flag3)
									{
										break;
									}
									goto IL_0213;
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
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj9 != obj10;
				bool result2 = flag5;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 == 1;
					result = false;
					if (!flag6)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result2 = flag7;
				}
				_ = 0;
				object obj11 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result2;
				IL_0213:
				object obj12 = obj5 + 1;
				obj5 = obj12;
			}
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @19C9");
		}
		return result;
	}

	public static bool HasCharacterNewTheme(Characters.CharacterType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<CharacterTheme> list = CharacterThemes.TryGetCustomThemesForChar(type);
		bool result = default;
		if (list != null && list._size >= 1)
		{
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj5 = 1;
			bool flag2 = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			bool flag5 = default;
			bool flag7 = default;
			while (true)
			{
				_ = 0;
				object obj6 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag = !flag2;
					result = flag2;
					if (flag)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v80+18]");
						if ((nint)0 == 0)
						{
							goto IL_0182;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							bool flag3 = obj8 == null;
							result = flag2;
							if (flag3)
							{
								break;
							}
							goto IL_0182;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj9 != obj10;
				bool result2 = flag5;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 == 1;
					result = false;
					if (!flag6)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result2 = flag7;
				}
				_ = 0;
				object obj11 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result2;
				IL_0182:
				object obj12 = obj5 + 1;
				obj5 = obj12;
			}
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @19C9");
		}
		return result;
	}

	public static int GetNumberOfNewCharactersOrThemes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected Obj, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af9: Expected Obj, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected Obj, but got Unknown
		//IL_06f4: Expected Obj, but got I4
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected Obj, but got Unknown
		//IL_050f: Expected Obj, but got I
		//IL_06e6: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		int num2 = default;
		if (~(instance._isFreshInstall ? 1u : 0u) != 0)
		{
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 48;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			int num4 = default;
			object obj10 = default;
			object obj12 = default;
			object obj16 = default;
			object obj18 = default;
			object obj19 = default;
			object obj20 = default;
			int num8 = default;
			int num9 = default;
			object obj21 = default;
			object obj24 = default;
			int num10 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						break;
					}
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
									if (obj7 == null)
									{
										continue;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_0829;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v136+28]");
										if ((nint)0 == 0)
										{
											goto IL_0a0d;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											goto IL_0829;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
												if (obj8 == null)
												{
													int num = num2 + 1;
													num2 = num;
												}
												goto IL_0a0d;
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
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_0838;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0838;
				IL_0ad5:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				int result;
				return result;
				IL_093d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				int num3;
				result = num3;
				goto IL_0ad5;
				IL_0838:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				num3 = num4;
				object obj9 = obj10;
				goto IL_0aac;
				IL_06eb:
				object obj11 = 3;
				goto IL_074a;
				IL_0a0d:
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
						if (obj12 == null)
						{
							continue;
						}
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S0_v159+C]");
							if ((nint)0 < (nint)1)
							{
								continue;
							}
							_ = 0;
							object obj13 = obj + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
								_ = 0;
								object obj14 = obj + 32;
								obj = obj14;
								_ = 0;
								nint num5 = 1;
								while (true)
								{
									_ = 0;
									object obj15 = obj + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										break;
									}
									if (obj16 != null)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
										object obj17 = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S0_v252+18]");
										if ((nint)0 != 0)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											if (obj18 == null)
											{
												int num6 = num2 + 1;
												num2 = num6;
											}
										}
										nint num7 = num5 + 1;
										num5 = num7;
										continue;
									}
									goto IL_06eb;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								bool flag = obj19 != obj20;
								num3 = num8;
								obj9 = obj19;
								if (!flag)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										obj11 = 0;
										goto IL_074a;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									num3 = num9;
									obj9 = obj21;
								}
								_ = 0;
								object obj22 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_093d;
								}
								goto IL_0aac;
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
				goto IL_0838;
				IL_0829:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0838;
				IL_074a:
				_ = 0;
				object obj23 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj11 != null && ((nint)obj11 == 1 || (nint)obj11 == 2 || (nint)obj11 != 3))
					{
						break;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0838;
				IL_0aac:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				if (obj24 == obj9)
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
					num3 = num10;
				}
				_ = 0;
				object obj25 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag2 = (nint)0 != 1;
				result = num3;
				if (!flag2)
				{
					goto IL_093d;
				}
				goto IL_0ad5;
			}
			object obj26 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BA");
		}
		return num2;
	}

	public static bool HasThemeBeenSeenForCharacter(Characters.CharacterType type, int index)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance.IsThemeSeenForCharacter(type, index);
	}

	public static bool IsThemeUnlockedForCharacter(Characters.CharacterType type, int index)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance.IsThemeUnlockedForCharacter(type, index);
	}

	public static bool HasCharacterBeenSeen(Characters.CharacterType type)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance.HasCharacterBeenSeen(type);
	}

	public static bool IsCharacterUnlocked(Characters.CharacterType type)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance.IsCharacterOwned(type);
	}
}
