using Cpp2ILInjected;
using Debugging;
using UnityEngine;

namespace UI;

public class ColorData : ScriptableObject
{
	private static ColorData _instance;

	public Color cloud;

	public Color sky;

	public Color smurf;

	public Color push;

	public Color boston;

	public Color peacock;

	public Color ocean;

	public Color royale;

	public Color midnight;

	public Color scooter;

	public Color bulbasaur;

	public Color grape;

	public Color lime;

	public Color grass;

	public Color avocado;

	public Color glow;

	public Color sun;

	public Color yolk;

	public Color orange;

	public Color dutch;

	public Color fox;

	public Color ruby;

	public Color pigeon;

	public Color tuna;

	public Color storm;

	public Color oxford;

	public Color mint;

	public Color spring;

	public Color christi;

	public Color verdun;

	public Color sand;

	public Color desert;

	public Color pink;

	public Color peach;

	public Color safran;

	public Color mahogany;

	public Color bordeaux;

	public Color white;

	public Color stroking;

	public Color chrome;

	public Color slate;

	public Color iron;

	public Color rock;

	public Color smoke;

	public Color blueBlack;

	public Color shadow;

	public Color sliggo;

	public Color lavender;

	public Color amethyst;

	public Color stripeColor;

	public Color glowColor;

	public Color dailyLetterColorActiveShadow;

	public Color dailyLetterColorInactive;

	public Color dailyLetterColorInactiveShadow;

	public Color wordHuntCurrentDayGradientTop;

	public Color wordHuntCurrentDayGradientBottom;

	public Color wordHuntBubbleColor;

	public Color wordHuntBubbleShadowColor;

	public Color myTourFooterColorMain;

	public Color myTourFooterColorLight;

	public Color myTourFooterColorSelected;

	public static ColorData instance => (ColorData)(object)FreeMemoryStatus._instance;

	private void Save()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	static ColorData()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0075: Expected VT, but got Obj
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00d7: Expected VT, but got Obj
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0139: Expected VT, but got Obj
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_019b: Expected VT, but got Obj
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01fd: Expected VT, but got Obj
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_025f: Expected VT, but got Obj
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02c1: Expected VT, but got Obj
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0323: Expected VT, but got Obj
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0385: Expected VT, but got Obj
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03e7: Expected VT, but got Obj
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I4
		//IL_0410: Expected Obj, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_0449: Expected VT, but got Obj
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0460: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I4
		//IL_0472: Expected Obj, but got I4
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_04ab: Expected VT, but got Obj
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04c2: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got I4
		//IL_04ff: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 76;
		obj = 0;
		obj = 0;
		obj = 1;
		_ = 90;
		_ = 1;
		_ = -1;
		object obj3 = obj2 + 100;
		obj3 = obj;
		object obj4 = obj2 + 104;
		obj4 = obj3;
		AwardCellHelper.COMPLETED_TITLE_TEXT_COLOR = (Color32)obj4;
		object obj5 = obj2 + 68;
		obj5 = 0;
		obj5 = 0;
		obj5 = 0;
		_ = 74;
		_ = 125;
		_ = -1;
		object obj6 = obj2 + 96;
		obj6 = obj5;
		obj4 = obj6;
		AwardCellHelper.ACTIVE_TITLE_TEXT_COLOR = (Color32)obj4;
		object obj7 = obj2 - -64;
		obj7 = 0;
		obj7 = 0;
		obj7 = -27;
		_ = -22;
		_ = -18;
		_ = -1;
		object obj8 = obj2 + 92;
		obj8 = obj7;
		obj4 = obj8;
		AwardCellHelper.ACTIVE_TITLE_TEXT_SHADOW_COLOR = (Color32)obj4;
		object obj9 = obj2 + 60;
		obj9 = 0;
		obj9 = 0;
		obj9 = -24;
		_ = -8;
		_ = -28;
		_ = -1;
		object obj10 = obj2 + 88;
		obj10 = obj9;
		obj4 = obj10;
		AwardCellHelper.COMPLETED_TITLE_TEXT_SHADOW_COLOR = (Color32)obj4;
		object obj11 = obj2 + 52;
		obj11 = 0;
		obj11 = 0;
		obj11 = -114;
		_ = -50;
		_ = -14;
		_ = -76;
		object obj12 = obj2 + 84;
		obj12 = obj11;
		obj4 = obj12;
		AwardCellHelper.COLLECTIBLE_SEGMENT_BACKGROUND_COLOR = (Color32)obj4;
		object obj13 = obj2 + 48;
		obj13 = 0;
		obj13 = 0;
		obj13 = -86;
		_ = -66;
		_ = -52;
		_ = -76;
		object obj14 = obj2 + 80;
		obj14 = obj13;
		obj4 = obj14;
		AwardCellHelper.PROGRESS_SEGMENT_BACKGROUND_COLOR = (Color32)obj4;
		object obj15 = obj2 + 40;
		obj15 = 0;
		obj15 = 0;
		obj15 = -110;
		_ = -25;
		_ = 127;
		_ = -76;
		object obj16 = obj2 + 72;
		obj16 = obj15;
		obj4 = obj16;
		AwardCellHelper.COMPLETE_SEGMENT_BACKGROUND_COLOR = (Color32)obj4;
		object obj17 = obj2 + 32;
		obj17 = 0;
		obj17 = 0;
		obj17 = 90;
		_ = 124;
		_ = 90;
		_ = -1;
		object obj18 = obj2 + 56;
		obj18 = obj17;
		obj4 = obj18;
		AwardCellHelper.REWARD_BIG_BACKGROUND_FINISHED_COLOR = (Color32)obj4;
		object obj19 = obj2 + 28;
		obj19 = 0;
		obj19 = 0;
		obj19 = 99;
		_ = 116;
		_ = -128;
		_ = -1;
		object obj20 = obj2 + 44;
		obj20 = obj19;
		obj4 = obj20;
		AwardCellHelper.REWARD_BIG_BACKGROUND_IN_PROGRESS_COLOR = (Color32)obj4;
		object obj21 = obj2 + 20;
		obj21 = 0;
		obj21 = 0;
		obj21 = 91;
		_ = 116;
		_ = -122;
		_ = -1;
		object obj22 = obj2 + 36;
		obj22 = obj21;
		obj4 = obj22;
		AwardCellHelper.REWARD_BIG_BACKGROUND_COLLECTIBLE_COLOR = (Color32)obj4;
		object obj23 = obj2 + 16;
		obj23 = 0;
		obj23 = 0;
		obj23 = -1;
		_ = -1;
		_ = -1;
		_ = 0;
		object obj24 = obj2 + 24;
		obj24 = obj23;
		obj4 = obj24;
		AwardCellHelper.EFFECT_INITIAL_COLOR = (Color32)obj4;
		object obj25 = obj2 + 8;
		obj25 = 0;
		obj25 = 0;
		obj25 = 36;
		_ = -122;
		_ = -69;
		_ = -1;
		object obj26 = obj2 + 12;
		obj26 = obj25;
		obj4 = obj26;
		AwardCellHelper.MYSTERYBOX_BACKGROUND_PROGRESS_COLOR = (Color32)obj4;
		object obj27 = obj2 + 4;
		obj27 = 0;
		obj27 = 0;
		obj27 = 84;
		_ = -111;
		_ = 51;
		_ = -1;
		obj2 = obj27;
		obj4 = obj2;
		AwardCellHelper.MYSTERYBOX_BACKGROUND_FINISHED_COLOR = (Color32)obj4;
	}
}
