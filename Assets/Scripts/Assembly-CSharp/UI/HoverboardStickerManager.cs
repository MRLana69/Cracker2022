using Cpp2ILInjected;

namespace UI;

public static class HoverboardStickerManager
{
	public static bool ShouldShowHoverboardStickerFlow()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		bool result = true;
		if (!instance._hasShownHoverboardPopup)
		{
			result = true;
			if (!instance._hasShownCollectPopup)
			{
				result = true;
				if (!instance._hasShownFacebookPopup)
				{
					bool hasShownMission1Popup = instance._hasShownMission1Popup;
					result = hasShownMission1Popup;
				}
			}
		}
		return result;
	}

	public static bool IsAnyGiftBoard()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected Obj, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_0607: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		bool flag2 = default;
		bool result;
		object obj6;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		bool flag5 = default;
		bool flag7 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
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
				obj6 = obj;
				if (flag)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v90+14]");
							object obj7 = -2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v90+14]");
							if ((nint)0 != 2 && ((nint)obj7 == 1 || (nint)obj7 == 2 || (nint)obj7 != 3))
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v90+10]");
							if ((nint)0 != 0)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								goto IL_02c8;
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
									if (obj8 != null)
									{
										continue;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_02c8;
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
											if (obj9 != null)
											{
												result = flag2;
												obj6 = obj;
												break;
											}
											continue;
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
						goto IL_03c9;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_03c9;
			IL_02c8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_03c9;
			IL_03c9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj10 == obj11;
			bool flag4 = !flag3;
			result = flag5;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 != 1;
				result = false;
				obj6 = obj;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag7;
			}
			_ = 0;
			object obj12 = obj + 16;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			break;
		}
		object obj13 = obj6 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDC");
		return result;
	}

	public static int GetNumberOfNewHoverboardsAndThemes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b60: Expected I4, but got Obj
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8f: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_0498: Expected Obj, but got I4
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected Obj, but got Unknown
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Expected Obj, but got Unknown
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Expected Obj, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected Obj, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected Obj, but got Unknown
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected Obj, but got Unknown
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected Obj, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected Obj, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected Obj, but got Unknown
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db3: Expected Obj, but got Unknown
		//IL_0800: Expected Obj, but got I
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Expected Obj, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 112;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		object obj9 = default;
		int num;
		object obj17 = default;
		if (~(instance._isFreshInstall ? 1u : 0u) != 0)
		{
			object obj3 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			object obj4 = obj + 96;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj10 = default;
			object obj11 = default;
			object obj12 = default;
			int num2 = default;
			int num3 = default;
			object obj19 = default;
			object obj21 = default;
			object obj26 = default;
			object obj29 = default;
			object obj31 = default;
			object obj32 = default;
			int num4 = default;
			object obj34 = default;
			int num5 = default;
			object obj36 = default;
			int num6 = default;
			object obj38 = default;
			int num7 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						goto IL_040d;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v354+24]");
								if ((nint)0 == 0)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_036f;
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
											goto IL_036f;
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
													obj9 = obj10 + 1;
												}
												continue;
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
							goto IL_037e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_037e;
				IL_0c0b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				int result;
				return result;
				IL_037e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj11 != obj12;
				num = num2;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_040d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					num = num3;
				}
				_ = 0;
				object obj13 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					goto IL_0be2;
				}
				result = num;
				goto IL_0c0b;
				IL_0be2:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_0e1f;
				IL_036f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_037e;
				IL_040d:
				object obj14 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDC");
				object obj15 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				object obj16 = obj + 72;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				obj17 = 0;
				while (true)
				{
					_ = 0;
					object obj18 = obj + 72;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					object obj33;
					if ((nint)0 != 1)
					{
						if (obj19 == null)
						{
							goto IL_0b36;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
							_ = 0;
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
									object obj20 = obj - -64;
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
											if (obj21 == null)
											{
												continue;
											}
											_ = 0;
											object obj22 = obj - -64;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												object obj23 = obj + 24;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
													_ = 0;
													object obj24 = obj + 48;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
													_ = 0;
													while (true)
													{
														_ = 0;
														object obj25 = obj + 48;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 == 1)
														{
															break;
														}
														if (obj26 != null)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
															object obj27 = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 == 1)
															{
																break;
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
															object obj28 = obj - -64;
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
															if (obj29 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ S0_v252+18]");
																if ((nint)0 != 0)
																{
																	object obj30 = obj17 + 1;
																	obj17 = obj30;
																}
															}
															continue;
														}
														goto IL_0a1c;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
													bool flag2 = obj31 != obj32;
													obj33 = obj31;
													num = num4;
													if (!flag2)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															num = 0;
															goto IL_0d9f;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														obj33 = obj34;
														num = num5;
													}
													_ = 0;
													object obj35 = obj + 24;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														goto IL_0be2;
													}
													goto IL_0df6;
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
					goto IL_0ac8;
					IL_0a1c:
					num = 6;
					goto IL_0d9f;
					IL_0df6:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					if (obj36 == obj33)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_0b36;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						num = num6;
					}
					_ = 0;
					object obj37 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					result = num;
					if (!flag3)
					{
						goto IL_0be2;
					}
					goto IL_0c0b;
					IL_0ac8:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj33 = obj38;
					num = num7;
					goto IL_0df6;
					IL_0b36:
					object obj39 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1981");
					goto end_IL_0c7b;
					IL_0d9f:
					_ = 0;
					object obj40 = obj + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (num != 6 && num != 0)
						{
							break;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					goto IL_0ac8;
				}
				object obj41 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1981");
				goto IL_0e1f;
				continue;
				end_IL_0c7b:
				break;
			}
		}
		int num8 = (int)(obj17 + obj9);
		num = num8;
		goto IL_0e1f;
		IL_0e1f:
		return num;
	}

	public static bool HasHoverboardBeenSeen(Hoverboards.BoardType type)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance.HasHoverboardBeenSeen(type);
	}

	public static bool IsHoverboardUnlocked(Hoverboards.BoardType type)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance.IsHoverboardUnlocked(type);
	}
}
