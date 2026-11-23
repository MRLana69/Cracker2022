using Cpp2ILInjected;
using UnityEngine;

public class RankHeader : MonoBehaviour
{
	private UILabel _title;

	private UILabel _best;

	private UILabel _rankMedal;

	private UISprite _background;

	public void InitHeader(int rank, int bestScore)
	{
		setTextAndColours(rank, bestScore);
	}

	private unsafe void setTextAndColours(int rank, int score)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1a8b: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got VT
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_018a: Expected Obj, but got VT
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got VT
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected VT, but got Unknown
		//IL_023b: Expected Obj, but got VT
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got VT
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02d3: Expected Obj, but got VT
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected VT, but got Unknown
		//IL_0334: Expected Obj, but got VT
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0366: Expected Obj, but got VT
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_03bb: Expected Obj, but got VT
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected VT, but got Unknown
		//IL_0417: Expected Obj, but got VT
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_0449: Expected Obj, but got VT
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_049e: Expected Obj, but got VT
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected VT, but got Unknown
		//IL_04ff: Expected Obj, but got VT
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_0531: Expected Obj, but got VT
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_0586: Expected Obj, but got VT
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected VT, but got Unknown
		//IL_0642: Expected Obj, but got VT
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_0674: Expected Obj, but got VT
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected Obj, but got Unknown
		//IL_06c9: Expected Obj, but got VT
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected Obj, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected VT, but got Unknown
		//IL_0725: Expected Obj, but got VT
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected Obj, but got Unknown
		//IL_0757: Expected Obj, but got VT
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected Obj, but got Unknown
		//IL_07ac: Expected Obj, but got VT
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected Obj, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected VT, but got Unknown
		//IL_0607: Expected Obj, but got I4
		//IL_080d: Expected Obj, but got VT
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_083f: Expected Obj, but got VT
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_0894: Expected Obj, but got VT
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected Obj, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected VT, but got Unknown
		//IL_08f0: Expected Obj, but got VT
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected Obj, but got Unknown
		//IL_0922: Expected Obj, but got VT
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected Obj, but got Unknown
		//IL_0977: Expected Obj, but got VT
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected Obj, but got Unknown
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected VT, but got Unknown
		//IL_1abe: Expected Obj, but got I
		//IL_09d8: Expected Obj, but got VT
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected Obj, but got Unknown
		//IL_0a0a: Expected Obj, but got VT
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected Obj, but got Unknown
		//IL_0a5f: Expected Obj, but got VT
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected Obj, but got Unknown
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected VT, but got Unknown
		//IL_0b1b: Expected Obj, but got VT
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b4d: Expected Obj, but got VT
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected Obj, but got Unknown
		//IL_0ba2: Expected Obj, but got VT
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Expected Obj, but got Unknown
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected VT, but got Unknown
		//IL_0bfe: Expected Obj, but got VT
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Expected Obj, but got Unknown
		//IL_0c30: Expected Obj, but got VT
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Expected Obj, but got Unknown
		//IL_0c85: Expected Obj, but got VT
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected Obj, but got Unknown
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected VT, but got Unknown
		//IL_0ae0: Expected Obj, but got I4
		//IL_0ce6: Expected Obj, but got VT
		//IL_0cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf4: Expected Obj, but got Unknown
		//IL_0d18: Expected Obj, but got VT
		//IL_0d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Expected Obj, but got Unknown
		//IL_0d6d: Expected Obj, but got VT
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected Obj, but got Unknown
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dab: Expected VT, but got Unknown
		//IL_0dc9: Expected Obj, but got VT
		//IL_0dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd7: Expected Obj, but got Unknown
		//IL_0dfb: Expected Obj, but got VT
		//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2c: Expected Obj, but got Unknown
		//IL_0e50: Expected Obj, but got VT
		//IL_0e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Expected Obj, but got Unknown
		//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected VT, but got Unknown
		//IL_19db: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e0: Expected I4, but got Unknown
		//IL_0eb1: Expected Obj, but got VT
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebf: Expected Obj, but got Unknown
		//IL_0ee3: Expected Obj, but got VT
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f14: Expected Obj, but got Unknown
		//IL_0f38: Expected Obj, but got VT
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f46: Expected Obj, but got Unknown
		//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f76: Expected VT, but got Unknown
		//IL_0ff4: Expected Obj, but got VT
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected Obj, but got Unknown
		//IL_1026: Expected Obj, but got VT
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_1057: Expected Obj, but got Unknown
		//IL_107b: Expected Obj, but got VT
		//IL_1084: Unknown result type (might be due to invalid IL or missing references)
		//IL_1089: Expected Obj, but got Unknown
		//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b9: Expected VT, but got Unknown
		//IL_10d7: Expected Obj, but got VT
		//IL_10e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e5: Expected Obj, but got Unknown
		//IL_1109: Expected Obj, but got VT
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_113a: Expected Obj, but got Unknown
		//IL_115e: Expected Obj, but got VT
		//IL_1167: Unknown result type (might be due to invalid IL or missing references)
		//IL_116c: Expected Obj, but got Unknown
		//IL_1197: Unknown result type (might be due to invalid IL or missing references)
		//IL_119c: Expected VT, but got Unknown
		//IL_0fb9: Expected Obj, but got I4
		//IL_11bf: Expected Obj, but got VT
		//IL_11c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cd: Expected Obj, but got Unknown
		//IL_11f1: Expected Obj, but got VT
		//IL_121d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1222: Expected Obj, but got Unknown
		//IL_1246: Expected Obj, but got VT
		//IL_124f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254: Expected Obj, but got Unknown
		//IL_127f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1284: Expected VT, but got Unknown
		//IL_12a2: Expected Obj, but got VT
		//IL_12ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b0: Expected Obj, but got Unknown
		//IL_12d4: Expected Obj, but got VT
		//IL_1300: Unknown result type (might be due to invalid IL or missing references)
		//IL_1305: Expected Obj, but got Unknown
		//IL_1329: Expected Obj, but got VT
		//IL_1332: Unknown result type (might be due to invalid IL or missing references)
		//IL_1337: Expected Obj, but got Unknown
		//IL_1362: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected VT, but got Unknown
		//IL_14c8: Expected Obj, but got VT
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d6: Expected Obj, but got Unknown
		//IL_14fa: Expected Obj, but got VT
		//IL_1526: Unknown result type (might be due to invalid IL or missing references)
		//IL_152b: Expected Obj, but got Unknown
		//IL_154f: Expected Obj, but got VT
		//IL_1558: Unknown result type (might be due to invalid IL or missing references)
		//IL_155d: Expected Obj, but got Unknown
		//IL_1588: Unknown result type (might be due to invalid IL or missing references)
		//IL_158d: Expected VT, but got Unknown
		//IL_138a: Expected Obj, but got VT
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_1398: Expected Obj, but got Unknown
		//IL_13bc: Expected Obj, but got VT
		//IL_13e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ed: Expected Obj, but got Unknown
		//IL_1411: Expected Obj, but got VT
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected Obj, but got Unknown
		//IL_144a: Unknown result type (might be due to invalid IL or missing references)
		//IL_144f: Expected VT, but got Unknown
		//IL_15b0: Expected Obj, but got VT
		//IL_15b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15be: Expected Obj, but got Unknown
		//IL_15e2: Expected Obj, but got VT
		//IL_160e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1613: Expected Obj, but got Unknown
		//IL_1637: Expected Obj, but got VT
		//IL_1640: Unknown result type (might be due to invalid IL or missing references)
		//IL_1645: Expected Obj, but got Unknown
		//IL_1670: Unknown result type (might be due to invalid IL or missing references)
		//IL_1675: Expected VT, but got Unknown
		//IL_1693: Expected Obj, but got VT
		//IL_169c: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a1: Expected Obj, but got Unknown
		//IL_16c5: Expected Obj, but got VT
		//IL_16f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f6: Expected Obj, but got Unknown
		//IL_171a: Expected Obj, but got VT
		//IL_1723: Unknown result type (might be due to invalid IL or missing references)
		//IL_1728: Expected Obj, but got Unknown
		//IL_1753: Unknown result type (might be due to invalid IL or missing references)
		//IL_1758: Expected VT, but got Unknown
		//IL_1492: Expected Obj, but got I4
		//IL_177b: Expected Obj, but got VT
		//IL_1784: Unknown result type (might be due to invalid IL or missing references)
		//IL_1789: Expected Obj, but got Unknown
		//IL_17ad: Expected Obj, but got VT
		//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17de: Expected Obj, but got Unknown
		//IL_1802: Expected Obj, but got VT
		//IL_180b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1810: Expected Obj, but got Unknown
		//IL_183b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1840: Expected VT, but got Unknown
		//IL_185e: Expected Obj, but got VT
		//IL_1867: Unknown result type (might be due to invalid IL or missing references)
		//IL_186c: Expected Obj, but got Unknown
		//IL_1890: Expected Obj, but got VT
		//IL_18bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c1: Expected Obj, but got Unknown
		//IL_18e5: Expected Obj, but got VT
		//IL_18ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f3: Expected Obj, but got Unknown
		//IL_191e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1923: Expected VT, but got Unknown
		//IL_1959: Expected Obj, but got I4
		//IL_19a5: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 816;
		GameObject gameObject = _title.gameObject;
		gameObject.SetActive(value: true);
		object obj3 = rank - 1;
		bool active;
		object obj34;
		if (rank != 1)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 != 2)
				{
					if ((nint)obj3 != 3)
					{
						if ((nint)obj3 == 4 || (nint)obj3 == 5 || (nint)obj3 == 6 || (nint)obj3 == 7 || (nint)obj3 == 8 || (nint)obj3 == 9)
						{
							GameObject gameObject2 = _title.gameObject;
							gameObject2.SetActive(value: false);
							object obj4 = GlobalColors.TOPRUN_RANK_HEADER_40_BACKGROUND_COLOUR >> 16;
							object obj5 = obj4 & 0xFF;
							float num = (float)obj5 / 255f;
							object obj6 = GlobalColors.TOPRUN_RANK_HEADER_40_BACKGROUND_COLOUR >> 24;
							float num2 = (float)obj6 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E0]");
							_ = 0;
							object obj7 = GlobalColors.TOPRUN_RANK_HEADER_40_BACKGROUND_COLOUR & 0xFF;
							float num3 = (float)obj7 / 255f;
							object obj8 = GlobalColors.TOPRUN_RANK_HEADER_40_BACKGROUND_COLOUR >> 8;
							object obj9 = obj8 & 0xFF;
							float num4 = (float)obj9 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D8]");
							_ = 0;
							Color color = (Color)(obj + 392);
							_background.color = color;
							object obj10 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR >> 16;
							object obj11 = obj10 & 0xFF;
							float num5 = (float)obj11 / 255f;
							object obj12 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR >> 24;
							float num6 = (float)obj12 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D0]");
							_ = 0;
							object obj13 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR & 0xFF;
							float num7 = (float)obj13 / 255f;
							object obj14 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR >> 8;
							object obj15 = obj14 & 0xFF;
							float num8 = (float)obj15 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C8]");
							_ = 0;
							Color color2 = (Color)(obj + 376);
							_title.color = color2;
							object obj16 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR >> 16;
							object obj17 = obj16 & 0xFF;
							float num9 = (float)obj17 / 255f;
							object obj18 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR >> 24;
							float num10 = (float)obj18 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C0]");
							_ = 0;
							object obj19 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR & 0xFF;
							float num11 = (float)obj19 / 255f;
							object obj20 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR >> 8;
							object obj21 = obj20 & 0xFF;
							float num12 = (float)obj21 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B8]");
							_ = 0;
							Color color3 = (Color)(obj + 360);
							_best.color = color3;
							object obj22 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_SHADOW_COLOUR >> 16;
							object obj23 = obj22 & 0xFF;
							float num13 = (float)obj23 / 255f;
							object obj24 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_SHADOW_COLOUR >> 24;
							float num14 = (float)obj24 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
							_ = 0;
							object obj25 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_SHADOW_COLOUR & 0xFF;
							float num15 = (float)obj25 / 255f;
							object obj26 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_SHADOW_COLOUR >> 8;
							object obj27 = obj26 & 0xFF;
							float num16 = (float)obj27 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A8]");
							_ = 0;
							Color effectColor = (Color)(obj + 344);
							_title.effectColor = effectColor;
							object obj28 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR >> 16;
							object obj29 = obj28 & 0xFF;
							float num17 = (float)obj29 / 255f;
							object obj30 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR >> 24;
							float num18 = (float)obj30 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A0]");
							_ = 0;
							object obj31 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR & 0xFF;
							float num19 = (float)obj31 / 255f;
							object obj32 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR >> 8;
							object obj33 = obj32 & 0xFF;
							float num20 = (float)obj33 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+198]");
							_ = 0;
							Color color4 = (Color)(obj + 328);
							_rankMedal.color = color4;
							_rankMedal.text = string.Empty;
							active = true;
							obj34 = 0;
						}
						else
						{
							_title.text = string.Empty;
							_rankMedal.text = string.Empty;
							_best.text = string.Empty;
							active = true;
							obj34 = 0;
						}
					}
					else
					{
						string text = Strings.Get(StringID.TOPRUN_RANK_4_TITLE);
						_title.text = text;
						object obj35 = GlobalColors.TOPRUN_RANK_HEADER_30_BACKGROUND_COLOUR >> 16;
						object obj36 = obj35 & 0xFF;
						float num21 = (float)obj36 / 255f;
						object obj37 = GlobalColors.TOPRUN_RANK_HEADER_30_BACKGROUND_COLOUR >> 24;
						float num22 = (float)obj37 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
						_ = 0;
						object obj38 = GlobalColors.TOPRUN_RANK_HEADER_30_BACKGROUND_COLOUR & 0xFF;
						float num23 = (float)obj38 / 255f;
						object obj39 = GlobalColors.TOPRUN_RANK_HEADER_30_BACKGROUND_COLOUR >> 8;
						object obj40 = obj39 & 0xFF;
						float num24 = (float)obj40 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
						_ = 0;
						Color color5 = (Color)(obj + 312);
						_background.color = color5;
						object obj41 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR >> 16;
						object obj42 = obj41 & 0xFF;
						float num25 = (float)obj42 / 255f;
						object obj43 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR >> 24;
						float num26 = (float)obj43 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+220]");
						_ = 0;
						object obj44 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR & 0xFF;
						float num27 = (float)obj44 / 255f;
						object obj45 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR >> 8;
						object obj46 = obj45 & 0xFF;
						float num28 = (float)obj46 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+218]");
						_ = 0;
						Color color6 = (Color)(obj + 296);
						_title.color = color6;
						object obj47 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR >> 16;
						object obj48 = obj47 & 0xFF;
						float num29 = (float)obj48 / 255f;
						object obj49 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR >> 24;
						float num30 = (float)obj49 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+210]");
						_ = 0;
						object obj50 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR & 0xFF;
						float num31 = (float)obj50 / 255f;
						object obj51 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR >> 8;
						object obj52 = obj51 & 0xFF;
						float num32 = (float)obj52 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+208]");
						_ = 0;
						Color color7 = (Color)(obj + 280);
						_best.color = color7;
						object obj53 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_SHADOW_COLOUR >> 16;
						object obj54 = obj53 & 0xFF;
						float num33 = (float)obj54 / 255f;
						object obj55 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_SHADOW_COLOUR >> 24;
						float num34 = (float)obj55 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+200]");
						_ = 0;
						object obj56 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_SHADOW_COLOUR & 0xFF;
						float num35 = (float)obj56 / 255f;
						object obj57 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_SHADOW_COLOUR >> 8;
						object obj58 = obj57 & 0xFF;
						float num36 = (float)obj58 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F8]");
						_ = 0;
						Color effectColor2 = (Color)(obj + 264);
						_title.effectColor = effectColor2;
						object obj59 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR >> 16;
						object obj60 = obj59 & 0xFF;
						float num37 = (float)obj60 / 255f;
						object obj61 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR >> 24;
						float num38 = (float)obj61 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
						_ = 0;
						object obj62 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR & 0xFF;
						float num39 = (float)obj62 / 255f;
						object obj63 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR >> 8;
						object obj64 = obj63 & 0xFF;
						float num40 = (float)obj64 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E8]");
						_ = 0;
						Color color8 = (Color)(obj + 248);
						_rankMedal.color = color8;
						string text2 = Strings.Get(StringID.TOPRUN_RANK_3_MEDAL);
						_rankMedal.text = text2;
						active = true;
						obj34 = 0;
					}
				}
				else
				{
					string text3 = Strings.Get(StringID.TOPRUN_RANK_3_TITLE);
					_title.text = text3;
					object obj65 = GlobalColors.TOPRUN_RANK_HEADER_20_BACKGROUND_COLOUR >> 16;
					object obj66 = obj65 & 0xFF;
					float num41 = (float)obj66 / 255f;
					object obj67 = GlobalColors.TOPRUN_RANK_HEADER_20_BACKGROUND_COLOUR >> 24;
					float num42 = (float)obj67 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
					_ = 0;
					object obj68 = GlobalColors.TOPRUN_RANK_HEADER_20_BACKGROUND_COLOUR & 0xFF;
					float num43 = (float)obj68 / 255f;
					object obj69 = GlobalColors.TOPRUN_RANK_HEADER_20_BACKGROUND_COLOUR >> 8;
					object obj70 = obj69 & 0xFF;
					float num44 = (float)obj70 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
					_ = 0;
					Color color9 = (Color)(obj + 232);
					_background.color = color9;
					object obj71 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR >> 16;
					object obj72 = obj71 & 0xFF;
					float num45 = (float)obj72 / 255f;
					object obj73 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR >> 24;
					float num46 = (float)obj73 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
					_ = 0;
					object obj74 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR & 0xFF;
					float num47 = (float)obj74 / 255f;
					object obj75 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR >> 8;
					object obj76 = obj75 & 0xFF;
					float num48 = (float)obj76 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+268]");
					_ = 0;
					Color color10 = (Color)(obj + 216);
					_title.color = color10;
					object obj77 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR >> 16;
					object obj78 = obj77 & 0xFF;
					float num49 = (float)obj78 / 255f;
					object obj79 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR >> 24;
					float num50 = (float)obj79 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+260]");
					_ = 0;
					object obj80 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR & 0xFF;
					float num51 = (float)obj80 / 255f;
					object obj81 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR >> 8;
					object obj82 = obj81 & 0xFF;
					float num52 = (float)obj82 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+258]");
					_ = 0;
					Color color11 = (Color)(obj + 200);
					_best.color = color11;
					object obj83 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_SHADOW_COLOUR >> 16;
					object obj84 = obj83 & 0xFF;
					float num53 = (float)obj84 / 255f;
					object obj85 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_SHADOW_COLOUR >> 24;
					float num54 = (float)obj85 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+250]");
					_ = 0;
					object obj86 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_SHADOW_COLOUR & 0xFF;
					float num55 = (float)obj86 / 255f;
					object obj87 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_SHADOW_COLOUR >> 8;
					object obj88 = obj87 & 0xFF;
					float num56 = (float)obj88 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+248]");
					_ = 0;
					Color effectColor3 = (Color)(obj + 184);
					_title.effectColor = effectColor3;
					object obj89 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR >> 16;
					object obj90 = obj89 & 0xFF;
					float num57 = (float)obj90 / 255f;
					object obj91 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR >> 24;
					float num58 = (float)obj91 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+240]");
					_ = 0;
					object obj92 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR & 0xFF;
					float num59 = (float)obj92 / 255f;
					object obj93 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR >> 8;
					object obj94 = obj93 & 0xFF;
					float num60 = (float)obj94 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+238]");
					_ = 0;
					Color color12 = (Color)(obj + 168);
					_rankMedal.color = color12;
					string text4 = Strings.Get(StringID.TOPRUN_RANK_2_MEDAL);
					_rankMedal.text = text4;
					active = true;
					obj34 = 0;
				}
			}
			else
			{
				string text5 = Strings.Get(StringID.TOPRUN_RANK_2_TITLE);
				_title.text = text5;
				object obj95 = GlobalColors.TOPRUN_RANK_HEADER_10_BACKGROUND_COLOUR >> 16;
				object obj96 = obj95 & 0xFF;
				float num61 = (float)obj96 / 255f;
				object obj97 = GlobalColors.TOPRUN_RANK_HEADER_10_BACKGROUND_COLOUR >> 24;
				float num62 = (float)obj97 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2D0]");
				_ = 0;
				object obj98 = GlobalColors.TOPRUN_RANK_HEADER_10_BACKGROUND_COLOUR & 0xFF;
				float num63 = (float)obj98 / 255f;
				object obj99 = GlobalColors.TOPRUN_RANK_HEADER_10_BACKGROUND_COLOUR >> 8;
				object obj100 = obj99 & 0xFF;
				float num64 = (float)obj100 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C8]");
				_ = 0;
				Color color13 = (Color)(obj + 152);
				_background.color = color13;
				object obj101 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR >> 16;
				object obj102 = obj101 & 0xFF;
				float num65 = (float)obj102 / 255f;
				object obj103 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR >> 24;
				float num66 = (float)obj103 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C0]");
				_ = 0;
				object obj104 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR & 0xFF;
				float num67 = (float)obj104 / 255f;
				object obj105 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR >> 8;
				object obj106 = obj105 & 0xFF;
				float num68 = (float)obj106 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2B8]");
				_ = 0;
				Color color14 = (Color)(obj + 136);
				_title.color = color14;
				object obj107 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR >> 16;
				object obj108 = obj107 & 0xFF;
				float num69 = (float)obj108 / 255f;
				object obj109 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR >> 24;
				float num70 = (float)obj109 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2B0]");
				_ = 0;
				object obj110 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR & 0xFF;
				float num71 = (float)obj110 / 255f;
				object obj111 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR >> 8;
				object obj112 = obj111 & 0xFF;
				float num72 = (float)obj112 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A8]");
				_ = 0;
				Color color15 = (Color)(obj + 120);
				_best.color = color15;
				object obj113 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_SHADOW_COLOUR >> 16;
				object obj114 = obj113 & 0xFF;
				float num73 = (float)obj114 / 255f;
				object obj115 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_SHADOW_COLOUR >> 24;
				float num74 = (float)obj115 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A0]");
				_ = 0;
				object obj116 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_SHADOW_COLOUR & 0xFF;
				float num75 = (float)obj116 / 255f;
				object obj117 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_SHADOW_COLOUR >> 8;
				object obj118 = obj117 & 0xFF;
				float num76 = (float)obj118 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
				_ = 0;
				Color effectColor4 = (Color)(obj + 104);
				_title.effectColor = effectColor4;
				object obj119 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR >> 16;
				object obj120 = obj119 & 0xFF;
				float num77 = (float)obj120 / 255f;
				object obj121 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR >> 24;
				float num78 = (float)obj121 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
				_ = 0;
				object obj122 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR & 0xFF;
				float num79 = (float)obj122 / 255f;
				object obj123 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR >> 8;
				object obj124 = obj123 & 0xFF;
				float num80 = (float)obj124 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
				_ = 0;
				Color color16 = (Color)(obj + 88);
				_rankMedal.color = color16;
				string text6 = Strings.Get(StringID.TOPRUN_RANK_1_MEDAL);
				_rankMedal.text = text6;
				active = true;
				obj34 = 0;
			}
		}
		else
		{
			string text7 = Strings.Get(StringID.TOPRUN_RANK_1_TITLE);
			_title.text = text7;
			object obj125 = GlobalColors.TOPRUN_RANK_HEADER_00_BACKGROUND_COLOUR >> 16;
			object obj126 = obj125 & 0xFF;
			float num81 = (float)obj126 / 255f;
			object obj127 = GlobalColors.TOPRUN_RANK_HEADER_00_BACKGROUND_COLOUR >> 24;
			float num82 = (float)obj127 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+320]");
			_ = 0;
			object obj128 = GlobalColors.TOPRUN_RANK_HEADER_00_BACKGROUND_COLOUR & 0xFF;
			float num83 = (float)obj128 / 255f;
			object obj129 = GlobalColors.TOPRUN_RANK_HEADER_00_BACKGROUND_COLOUR >> 8;
			object obj130 = obj129 & 0xFF;
			float num84 = (float)obj130 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+318]");
			_ = 0;
			Color color17 = (Color)(obj + 72);
			_background.color = color17;
			object obj131 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR >> 16;
			object obj132 = obj131 & 0xFF;
			float num85 = (float)obj132 / 255f;
			object obj133 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR >> 24;
			float num86 = (float)obj133 / 255f;
			object obj134 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+310]");
			obj134 = 0;
			object obj135 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR & 0xFF;
			float num87 = (float)obj135 / 255f;
			object obj136 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR >> 8;
			object obj137 = obj136 & 0xFF;
			float num88 = (float)obj137 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+308]");
			_ = 0;
			Color color18 = (Color)(obj + 56);
			_title.color = color18;
			object obj138 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR >> 16;
			object obj139 = obj138 & 0xFF;
			float num89 = (float)obj139 / 255f;
			object obj140 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR >> 24;
			float num90 = (float)obj140 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+300]");
			_ = 0;
			object obj141 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR & 0xFF;
			float num91 = (float)obj141 / 255f;
			object obj142 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR >> 8;
			object obj143 = obj142 & 0xFF;
			float num92 = (float)obj143 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2F8]");
			_ = 0;
			Color color19 = (Color)(obj + 40);
			_best.color = color19;
			object obj144 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_SHADOW_COLOUR >> 16;
			object obj145 = obj144 & 0xFF;
			float num93 = (float)obj145 / 255f;
			object obj146 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_SHADOW_COLOUR >> 24;
			float num94 = (float)obj146 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2F0]");
			_ = 0;
			object obj147 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_SHADOW_COLOUR & 0xFF;
			float num95 = (float)obj147 / 255f;
			object obj148 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_SHADOW_COLOUR >> 8;
			object obj149 = obj148 & 0xFF;
			float num96 = (float)obj149 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2E8]");
			_ = 0;
			Color effectColor5 = (Color)(obj + 24);
			_title.effectColor = effectColor5;
			object obj150 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR >> 16;
			object obj151 = obj150 & 0xFF;
			float num97 = (float)obj151 / 255f;
			object obj152 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR >> 24;
			float num98 = (float)obj152 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2E0]");
			_ = 0;
			object obj153 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR & 0xFF;
			float num99 = (float)obj153 / 255f;
			object obj154 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR >> 8;
			object obj155 = obj154 & 0xFF;
			float num100 = (float)obj155 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2D8]");
			_ = 0;
			Color color20 = (Color)(obj + 8);
			_rankMedal.color = color20;
			string text8 = Strings.Get(StringID.TOPRUN_RANK_0_MEDAL);
			_rankMedal.text = text8;
			active = false;
			obj34 = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+32C]");
		object obj156 = (nint)0 >> 31;
		object obj157 = obj34 | obj156;
		if (obj157 != null)
		{
			_best.text = string.Empty;
		}
		else
		{
			string text9 = Strings.Get(StringID.TOPRUN_RANK_BEST);
			int num101 = obj + 812;
			string text10 = ((int*)num101)->ToString();
			string text11 = text9 + " " + text10;
			_best.text = text11;
		}
		GameObject gameObject3 = _best.gameObject;
		gameObject3.SetActive(active);
		GameObject gameObject4 = _rankMedal.gameObject;
		gameObject4.SetActive(value: false);
	}
}
