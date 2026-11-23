using Cpp2ILInjected;
using UnityEngine;

public class TopRunEmptyCell : MonoBehaviour
{
	private UISprite background;

	public unsafe void InitCell(int rank)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_06b7: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got VT
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got VT
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got VT
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected VT, but got Unknown
		//IL_0219: Expected Obj, but got VT
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got VT
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got VT
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected VT, but got Unknown
		//IL_0306: Expected Obj, but got VT
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got VT
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_038d: Expected Obj, but got VT
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected VT, but got Unknown
		//IL_03f3: Expected Obj, but got VT
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got VT
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_047a: Expected Obj, but got VT
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected VT, but got Unknown
		//IL_04e0: Expected Obj, but got VT
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_0512: Expected Obj, but got VT
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_0567: Expected Obj, but got VT
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected VT, but got Unknown
		//IL_05cd: Expected Obj, but got VT
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_05ff: Expected Obj, but got VT
		//IL_0629: Expected F4, but got I
		//IL_0624: Expected native int or pointer, but got VT
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_065c: Expected Obj, but got VT
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_0694: Expected F4, but got I
		//IL_068f: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 192);
		object obj2 = rank - 1;
		if (rank != 1)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 != 3)
					{
						if ((nint)obj2 == 4 || (nint)obj2 == 5 || (nint)obj2 == 6 || (nint)obj2 == 7 || (nint)obj2 == 8 || (nint)obj2 == 9)
						{
							object obj3 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 16;
							object obj4 = obj3 & 0xFF;
							float num = (float)obj4 / 255f;
							object obj5 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 24;
							float num2 = (float)obj5 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
							_ = 0;
							object obj6 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR & 0xFF;
							float num3 = (float)obj6 / 255f;
							object obj7 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 8;
							object obj8 = obj7 & 0xFF;
							float num4 = (float)obj8 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
							_ = 0;
							Color color2 = color + 80;
							background.color = color2;
						}
						else
						{
							object obj9 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 16;
							object obj10 = obj9 & 0xFF;
							float num5 = (float)obj10 / 255f;
							object obj11 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 24;
							float num6 = (float)obj11 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+68]");
							((Color*)(nint)color)->b = 0f;
							object obj12 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR & 0xFF;
							float num7 = (float)obj12 / 255f;
							object obj13 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 8;
							object obj14 = obj13 & 0xFF;
							float num8 = (float)obj14 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+60]");
							((Color*)(nint)color)->r = 0f;
							background.color = color;
						}
					}
					else
					{
						object obj15 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR >> 16;
						object obj16 = obj15 & 0xFF;
						float num9 = (float)obj16 / 255f;
						object obj17 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR >> 24;
						float num10 = (float)obj17 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
						_ = 0;
						object obj18 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR & 0xFF;
						float num11 = (float)obj18 / 255f;
						object obj19 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR >> 8;
						object obj20 = obj19 & 0xFF;
						float num12 = (float)obj20 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
						_ = 0;
						Color color3 = color - -64;
						background.color = color3;
					}
				}
				else
				{
					object obj21 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR >> 16;
					object obj22 = obj21 & 0xFF;
					float num13 = (float)obj22 / 255f;
					object obj23 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR >> 24;
					float num14 = (float)obj23 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
					_ = 0;
					object obj24 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR & 0xFF;
					float num15 = (float)obj24 / 255f;
					object obj25 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR >> 8;
					object obj26 = obj25 & 0xFF;
					float num16 = (float)obj26 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
					_ = 0;
					Color color4 = color + 48;
					background.color = color4;
				}
			}
			else
			{
				object obj27 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR >> 16;
				object obj28 = obj27 & 0xFF;
				float num17 = (float)obj28 / 255f;
				object obj29 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR >> 24;
				float num18 = (float)obj29 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
				_ = 0;
				object obj30 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR & 0xFF;
				float num19 = (float)obj30 / 255f;
				object obj31 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR >> 8;
				object obj32 = obj31 & 0xFF;
				float num20 = (float)obj32 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
				_ = 0;
				Color color5 = color + 32;
				background.color = color5;
			}
		}
		else
		{
			object obj33 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR >> 16;
			object obj34 = obj33 & 0xFF;
			float num21 = (float)obj34 / 255f;
			object obj35 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR >> 24;
			float num22 = (float)obj35 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
			_ = 0;
			object obj36 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR & 0xFF;
			float num23 = (float)obj36 / 255f;
			object obj37 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR >> 8;
			object obj38 = obj37 & 0xFF;
			float num24 = (float)obj38 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
			_ = 0;
			Color color6 = color + 16;
			background.color = color6;
		}
	}
}
