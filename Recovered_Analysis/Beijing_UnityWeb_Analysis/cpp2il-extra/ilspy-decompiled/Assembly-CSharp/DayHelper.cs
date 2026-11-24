using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using WordHunt;

public class DayHelper : MonoBehaviour
{
	public enum DayType
	{
		NotSet,
		Regular,
		LastDay
	}

	private DayType _dayType;

	private UILabel _dayLabel;

	private UILabel _rewardLabel;

	private UILabel _checkBackLabel;

	private UISprite _checkMark;

	private UISprite _divider;

	private UISprite _backgroundInactive;

	private UISprite _backgroundActive;

	private UISprite _checkbackBackground;

	private UISprite[] _gradientEffectSprites;

	private UISprite _glowEffect;

	private bool _forceActive;

	private bool _unlockColors;

	private Color32 _inactiveDayColor;

	private Color32 _activeDayColor;

	private Color32 _inactiveDayShadowColor;

	private Color32 _activeDayShadowColor;

	private Color32 _inactiveRewardColor;

	private Color32 _activeRewardColor;

	private Color32 _inactiveRewardShadowColor;

	private Color32 _activeRewardShadowColor;

	private Color32 _inactiveLastDayDayColor;

	private Color32 _activeLastDayDayColor;

	private Color32 _inactiveLastDayDayShadowColor;

	private Color32 _activeLastDayDayShadowColor;

	private Color32 _inactiveLastDayRewardShadowColor;

	private Color32 _activeLastDayRewardShadowColor;

	private Color32 _activeLastDayBackgroundColor;

	private Color32 _inactiveLastDayBackgroundColor;

	private Color32 _activeLastDayGradientColor;

	private Color32 _inactiveLastDayGradientColor;

	private Color32 _activeLastDayGlow;

	private Color32 _inactiveLastDayGlow;

	private int _dayIndex;

	public void Init(int dayIndex)
	{
		//IL_000f: Expected VT, but got I4
		((Curve)(object)this).AddKey(3f, (Vector3)dayIndex);
	}

	public void RefreshDay()
	{
		CancelInvoke();
	}

	public unsafe DayHelper()
	{
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc4: Expected VT, but got Unknown
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Expected Obj, but got Unknown
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected Obj, but got Unknown
		//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Expected Obj, but got Unknown
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffc: Expected Obj, but got Unknown
		//IL_1005: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Expected Obj, but got Unknown
		//IL_1013: Unknown result type (might be due to invalid IL or missing references)
		//IL_1018: Expected Obj, but got Unknown
		//IL_1021: Unknown result type (might be due to invalid IL or missing references)
		//IL_1026: Expected Obj, but got Unknown
		//IL_102f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Expected Obj, but got Unknown
		//IL_103d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Expected Obj, but got Unknown
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Expected Obj, but got Unknown
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_105e: Expected Obj, but got Unknown
		//IL_1067: Unknown result type (might be due to invalid IL or missing references)
		//IL_106c: Expected Obj, but got Unknown
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Expected Obj, but got Unknown
		//IL_1083: Unknown result type (might be due to invalid IL or missing references)
		//IL_1088: Expected Obj, but got Unknown
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected Obj, but got Unknown
		//IL_109f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a4: Expected Obj, but got Unknown
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected Obj, but got Unknown
		//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c0: Expected Obj, but got Unknown
		//IL_10c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected Obj, but got Unknown
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Expected Obj, but got Unknown
		//IL_10e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ea: Expected Obj, but got Unknown
		//IL_10f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected Obj, but got Unknown
		//IL_1101: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Expected Obj, but got Unknown
		//IL_110f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected Obj, but got Unknown
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Expected Obj, but got Unknown
		//IL_112b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Expected Obj, but got Unknown
		//IL_1139: Unknown result type (might be due to invalid IL or missing references)
		//IL_113e: Expected Obj, but got Unknown
		//IL_1147: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Expected Obj, but got Unknown
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Expected Obj, but got Unknown
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Expected Obj, but got Unknown
		//IL_1171: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Expected Obj, but got Unknown
		//IL_117f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Expected Obj, but got Unknown
		//IL_118d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Expected Obj, but got Unknown
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a0: Expected Obj, but got Unknown
		//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Expected Obj, but got Unknown
		//IL_11b7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_11f6: Expected I, but got Obj
		//IL_120c: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_1364: Expected Obj, but got VT
		//IL_1379: Expected F4, but got Obj
		//IL_1374: Expected native int or pointer, but got VT
		//IL_1393: Expected F4, but got Obj
		//IL_138e: Expected native int or pointer, but got VT
		//IL_13a8: Expected F4, but got I
		//IL_13a3: Expected native int or pointer, but got VT
		//IL_13b7: Expected I4, but got VT
		//IL_13c5: Expected I, but got Obj
		//IL_13db: Expected Obj, but got I
		//IL_148a: Expected I4, but got Obj
		//IL_1494: Expected Obj, but got VT
		//IL_14a9: Expected F4, but got Obj
		//IL_14a4: Expected native int or pointer, but got VT
		//IL_0ca4: Expected F4, but got Obj
		//IL_0c9f: Expected native int or pointer, but got VT
		//IL_0cb9: Expected F4, but got I
		//IL_0cb4: Expected native int or pointer, but got VT
		//IL_0cc8: Expected I4, but got VT
		//IL_0cd2: Expected Obj, but got VT
		//IL_0ce7: Expected F4, but got Obj
		//IL_0ce2: Expected native int or pointer, but got VT
		//IL_0c58: Expected I, but got Obj
		//IL_0d06: Expected F4, but got Obj
		//IL_0d01: Expected native int or pointer, but got VT
		//IL_0d1b: Expected F4, but got I
		//IL_0d16: Expected native int or pointer, but got VT
		//IL_0d24: Expected Obj, but got VT
		//IL_0d32: Expected Obj, but got VT
		//IL_0d47: Expected F4, but got Obj
		//IL_0d42: Expected native int or pointer, but got VT
		//IL_090a: Expected Obj, but got VT
		//IL_091f: Expected F4, but got Obj
		//IL_091a: Expected native int or pointer, but got VT
		//IL_0939: Expected F4, but got Obj
		//IL_0934: Expected native int or pointer, but got VT
		//IL_094e: Expected F4, but got I
		//IL_0949: Expected native int or pointer, but got VT
		//IL_095d: Expected I4, but got VT
		//IL_042d: Expected Obj, but got I4
		//IL_043b: Expected I, but got Obj
		//IL_0451: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I4
		//IL_0d66: Expected F4, but got Obj
		//IL_0d61: Expected native int or pointer, but got VT
		//IL_0d7b: Expected F4, but got I
		//IL_0d76: Expected native int or pointer, but got VT
		//IL_0d8a: Expected I4, but got VT
		//IL_0d94: Expected Obj, but got VT
		//IL_0da9: Expected F4, but got Obj
		//IL_0da4: Expected native int or pointer, but got VT
		//IL_0970: Expected I, but got Obj
		//IL_0986: Expected Obj, but got I
		//IL_01f2: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_0dc8: Expected F4, but got Obj
		//IL_0dc3: Expected native int or pointer, but got VT
		//IL_0ddd: Expected F4, but got I
		//IL_0dd8: Expected native int or pointer, but got VT
		//IL_0de6: Expected Obj, but got VT
		//IL_1415: Expected I4, but got Obj
		//IL_141f: Expected Obj, but got VT
		//IL_1434: Expected F4, but got Obj
		//IL_142f: Expected native int or pointer, but got VT
		//IL_1332: Expected Obj, but got I4
		//IL_1294: Expected I4, but got Obj
		//IL_129a: Unknown result type (might be due to invalid IL or missing references)
		//IL_129f: Expected Obj, but got Unknown
		//IL_12bc: Expected F4, but got Obj
		//IL_12b7: Expected native int or pointer, but got VT
		//IL_09fd: Expected F4, but got Obj
		//IL_09f8: Expected native int or pointer, but got VT
		//IL_0a12: Expected F4, but got I
		//IL_0a0d: Expected native int or pointer, but got VT
		//IL_0a21: Expected I4, but got VT
		//IL_0a2b: Expected Obj, but got VT
		//IL_0a40: Expected F4, but got Obj
		//IL_0a3b: Expected native int or pointer, but got VT
		//IL_09b1: Expected I, but got Obj
		//IL_0713: Expected I4, but got Obj
		//IL_071d: Expected Obj, but got VT
		//IL_0732: Expected F4, but got Obj
		//IL_072d: Expected native int or pointer, but got VT
		//IL_06c5: Expected I, but got Obj
		//IL_12ec: Expected Obj, but got I4
		//IL_027f: Expected F4, but got Obj
		//IL_027a: Expected native int or pointer, but got VT
		//IL_0294: Expected F4, but got I
		//IL_028f: Expected native int or pointer, but got VT
		//IL_02a3: Expected I4, but got VT
		//IL_02ad: Expected Obj, but got VT
		//IL_02c2: Expected F4, but got Obj
		//IL_02bd: Expected native int or pointer, but got VT
		//IL_0233: Expected I, but got Obj
		//IL_0e7f: Expected Obj, but got I4
		//IL_0e17: Expected Obj, but got I4
		//IL_0e27: Expected Obj, but got I4
		//IL_0a5f: Expected F4, but got Obj
		//IL_0a5a: Expected native int or pointer, but got VT
		//IL_0a74: Expected F4, but got I
		//IL_0a6f: Expected native int or pointer, but got VT
		//IL_0a7d: Expected Obj, but got VT
		//IL_0a8b: Expected Obj, but got VT
		//IL_0aa0: Expected F4, but got Obj
		//IL_0a9b: Expected native int or pointer, but got VT
		//IL_0751: Expected F4, but got Obj
		//IL_074c: Expected native int or pointer, but got VT
		//IL_0766: Expected F4, but got I
		//IL_0761: Expected native int or pointer, but got VT
		//IL_0775: Expected I4, but got VT
		//IL_077f: Expected Obj, but got VT
		//IL_0794: Expected F4, but got Obj
		//IL_078f: Expected native int or pointer, but got VT
		//IL_04f9: Expected I4, but got Obj
		//IL_0503: Expected Obj, but got VT
		//IL_0518: Expected F4, but got Obj
		//IL_0513: Expected native int or pointer, but got VT
		//IL_04ab: Expected I, but got Obj
		//IL_02e1: Expected F4, but got Obj
		//IL_02dc: Expected native int or pointer, but got VT
		//IL_02f6: Expected F4, but got I
		//IL_02f1: Expected native int or pointer, but got VT
		//IL_02ff: Expected Obj, but got VT
		//IL_030d: Expected Obj, but got VT
		//IL_0322: Expected F4, but got Obj
		//IL_031d: Expected native int or pointer, but got VT
		//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea0: Expected Obj, but got Unknown
		//IL_0ea9: Expected Obj, but got I4
		//IL_0e48: Expected Obj, but got I4
		//IL_0abf: Expected F4, but got Obj
		//IL_0aba: Expected native int or pointer, but got VT
		//IL_0ad4: Expected F4, but got I
		//IL_0acf: Expected native int or pointer, but got VT
		//IL_0add: Expected Obj, but got VT
		//IL_07b3: Expected F4, but got Obj
		//IL_07ae: Expected native int or pointer, but got VT
		//IL_07c8: Expected F4, but got I
		//IL_07c3: Expected native int or pointer, but got VT
		//IL_07d1: Expected Obj, but got VT
		//IL_07df: Expected Obj, but got VT
		//IL_07f4: Expected F4, but got Obj
		//IL_07ef: Expected native int or pointer, but got VT
		//IL_0537: Expected F4, but got Obj
		//IL_0532: Expected native int or pointer, but got VT
		//IL_054c: Expected F4, but got I
		//IL_0547: Expected native int or pointer, but got VT
		//IL_055b: Expected I4, but got VT
		//IL_0565: Expected Obj, but got VT
		//IL_057a: Expected F4, but got Obj
		//IL_0575: Expected native int or pointer, but got VT
		//IL_0341: Expected F4, but got Obj
		//IL_033c: Expected native int or pointer, but got VT
		//IL_0356: Expected F4, but got I
		//IL_0351: Expected native int or pointer, but got VT
		//IL_0365: Expected I4, but got VT
		//IL_036f: Expected Obj, but got VT
		//IL_0384: Expected F4, but got Obj
		//IL_037f: Expected native int or pointer, but got VT
		//IL_0b0e: Expected Obj, but got I4
		//IL_0813: Expected F4, but got Obj
		//IL_080e: Expected native int or pointer, but got VT
		//IL_0828: Expected F4, but got I
		//IL_0823: Expected native int or pointer, but got VT
		//IL_0837: Expected I4, but got VT
		//IL_0841: Expected Obj, but got VT
		//IL_0856: Expected F4, but got Obj
		//IL_0851: Expected native int or pointer, but got VT
		//IL_0599: Expected F4, but got Obj
		//IL_0594: Expected native int or pointer, but got VT
		//IL_05ae: Expected F4, but got I
		//IL_05a9: Expected native int or pointer, but got VT
		//IL_05b7: Expected Obj, but got VT
		//IL_05c5: Expected Obj, but got VT
		//IL_05da: Expected F4, but got Obj
		//IL_05d5: Expected native int or pointer, but got VT
		//IL_03a3: Expected F4, but got Obj
		//IL_039e: Expected native int or pointer, but got VT
		//IL_03b8: Expected F4, but got I
		//IL_03b3: Expected native int or pointer, but got VT
		//IL_03c1: Expected Obj, but got VT
		//IL_03e6: Expected Obj, but got I4
		//IL_0f5e: Expected Obj, but got VT
		//IL_0f73: Expected F4, but got Obj
		//IL_0f6e: Expected native int or pointer, but got VT
		//IL_0f8d: Expected F4, but got Obj
		//IL_0f88: Expected native int or pointer, but got VT
		//IL_0fa2: Expected F4, but got I
		//IL_0f9d: Expected native int or pointer, but got VT
		//IL_0fb1: Expected I4, but got VT
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Expected Obj, but got Unknown
		//IL_0b38: Expected Obj, but got I4
		//IL_0875: Expected F4, but got Obj
		//IL_0870: Expected native int or pointer, but got VT
		//IL_088a: Expected F4, but got I
		//IL_0885: Expected native int or pointer, but got VT
		//IL_0893: Expected Obj, but got VT
		//IL_08a7: Expected Obj, but got I4
		//IL_05f9: Expected F4, but got Obj
		//IL_05f4: Expected native int or pointer, but got VT
		//IL_060e: Expected F4, but got I
		//IL_0609: Expected native int or pointer, but got VT
		//IL_061d: Expected I4, but got VT
		//IL_0627: Expected Obj, but got VT
		//IL_063c: Expected F4, but got Obj
		//IL_0637: Expected native int or pointer, but got VT
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected Obj, but got Unknown
		//IL_0ee3: Expected Obj, but got VT
		//IL_0ef8: Expected F4, but got Obj
		//IL_0ef3: Expected native int or pointer, but got VT
		//IL_0f12: Expected F4, but got Obj
		//IL_0f0d: Expected native int or pointer, but got VT
		//IL_0f27: Expected F4, but got I
		//IL_0f22: Expected native int or pointer, but got VT
		//IL_0f34: Expected I4, but got VT
		//IL_065b: Expected F4, but got Obj
		//IL_0656: Expected native int or pointer, but got VT
		//IL_0670: Expected F4, but got I
		//IL_066b: Expected native int or pointer, but got VT
		//IL_0679: Expected Obj, but got VT
		//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected Obj, but got Unknown
		//IL_0bed: Expected Obj, but got VT
		//IL_0c02: Expected F4, but got Obj
		//IL_0bfd: Expected native int or pointer, but got VT
		//IL_0c1c: Expected F4, but got Obj
		//IL_0c17: Expected native int or pointer, but got VT
		//IL_0c31: Expected F4, but got I
		//IL_0c2c: Expected native int or pointer, but got VT
		//IL_0c40: Expected I4, but got VT
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected Obj, but got Unknown
		//IL_0b72: Expected Obj, but got VT
		//IL_0b87: Expected F4, but got Obj
		//IL_0b82: Expected native int or pointer, but got VT
		//IL_0ba1: Expected F4, but got Obj
		//IL_0b9c: Expected native int or pointer, but got VT
		//IL_0bb6: Expected F4, but got I
		//IL_0bb1: Expected native int or pointer, but got VT
		//IL_0bc3: Expected I4, but got VT
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Expected Obj, but got Unknown
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 248);
		object obj2 = obj + 144;
		object obj3 = obj + 128;
		object obj4 = obj + 244;
		object obj5 = obj + 112;
		object obj6 = obj + 96;
		object obj7 = obj + 240;
		object obj8 = obj + 80;
		object obj9 = obj - -64;
		object obj10 = obj + 236;
		object obj11 = obj + 48;
		object obj12 = obj + 32;
		object obj13 = obj + 232;
		object obj14 = obj + 16;
		object obj15 = obj + 228;
		object obj16 = obj + 224;
		object obj17 = obj + 220;
		object obj18 = obj + 216;
		object obj19 = obj + 212;
		object obj20 = obj + 208;
		object obj21 = obj + 204;
		object obj22 = obj + 200;
		object obj23 = obj + 196;
		object obj24 = obj + 192;
		object obj25 = obj + 188;
		object obj26 = obj + 184;
		object obj27 = obj + 180;
		object obj28 = obj + 176;
		object obj29 = obj + 172;
		object obj30 = obj + 168;
		object obj31 = obj + 164;
		object obj32 = obj + 160;
		object obj33 = obj + 156;
		object obj34 = obj + 152;
		object obj35 = obj + 148;
		WordHuntManager wordHuntManager = (WordHuntManager)(obj + 264);
		wordHuntManager = (WordHuntManager)0;
		if (~(_unlockColors ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v86 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v276 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = wordHuntManager.GetDailyWordOffline();
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v93 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v272 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((nint)text < 0)
		{
			text = null;
		}
		else if ((nint)text > 5)
		{
			text = (string)5;
		}
		bool flag = wordHuntManager == null;
		string text2 = text;
		if (!flag)
		{
			string text3 = (string)(text - 1);
			text2 = text3;
		}
		if (_dayType != DayType.LastDay)
		{
			if (_dayType != DayType.Regular)
			{
				string args = tag;
				SDebug.LogFormat("Day was not set properly.", (object[])(object)args);
				return;
			}
			if ((nint)text2 == _dayIndex)
			{
				_divider.tag = (string)1;
				_backgroundActive.tag = (string)1;
				_backgroundInactive.tag = null;
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v286 (Il2CppClass<Strings>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S1_v324 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text4 = Strings.GetDefault("DAILY_CHALLENGE_TODAY_2");
				_dayLabel.fontSize = (int)text4;
				object obj39 = this - -64;
				obj2 = obj39;
				obj24 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj24;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_dayLabel.rawPivot = (UIWidget.Pivot)matrix4x;
				obj5 = _activeDayShadowColor;
				obj25 = obj5;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj25;
				Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Vector2 effectDistance = ((UILabel)matrix4x).effectDistance;
				obj8 = _activeRewardColor;
				obj26 = obj8;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj26;
				Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_rewardLabel.rawPivot = (UIWidget.Pivot)matrix4x;
				obj11 = _activeRewardShadowColor;
				obj27 = obj11;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj27;
				Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Vector2 effectDistance2 = ((UILabel)matrix4x).effectDistance;
				bool flag2 = wordHuntManager != null;
				_checkMark.tag = (string)flag2;
				return;
			}
			bool flag3 = (nint)text2 < _dayIndex;
			_divider.tag = null;
			_backgroundActive.tag = null;
			_backgroundInactive.tag = (string)1;
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S1_v207 (Il2CppClass<Strings>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			bool flag4 = obj40 == null;
			if (flag3)
			{
				if (!flag4)
				{
					nint num8 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S0_v239 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string format = Strings.GetDefault("DAILY_CHALLENGE_DAY");
				object obj41 = _dayIndex + 1;
				obj2 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args2 = default;
				string text5 = string.Format(format, args2);
				_dayLabel.fontSize = (int)text5;
				obj3 = _inactiveDayColor;
				obj28 = obj3;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj28;
				Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_dayLabel.rawPivot = (UIWidget.Pivot)matrix4x;
				obj6 = _inactiveDayShadowColor;
				obj29 = obj6;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj29;
				Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Vector2 effectDistance3 = ((UILabel)matrix4x).effectDistance;
				obj9 = _inactiveRewardColor;
				obj30 = obj9;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj30;
				Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_rewardLabel.rawPivot = (UIWidget.Pivot)matrix4x;
				obj12 = _inactiveRewardShadowColor;
				obj31 = obj12;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj31;
				Matrix4x4 matrix4x9 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Vector2 effectDistance4 = ((UILabel)matrix4x).effectDistance;
				_checkMark.tag = null;
				return;
			}
			if (!flag4)
			{
				nint num9 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v217 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format2 = Strings.GetDefault("DAILY_CHALLENGE_DAY");
			object obj42 = _dayIndex + 1;
			obj2 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args3 = default;
			string text6 = string.Format(format2, args3);
			_dayLabel.fontSize = (int)text6;
			obj3 = _inactiveDayColor;
			obj32 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj32;
			Matrix4x4 matrix4x10 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_dayLabel.rawPivot = (UIWidget.Pivot)matrix4x;
			obj6 = _inactiveDayShadowColor;
			obj33 = obj6;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj33;
			Matrix4x4 matrix4x11 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Vector2 effectDistance5 = ((UILabel)matrix4x).effectDistance;
			obj9 = _inactiveRewardColor;
			obj34 = obj9;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj34;
			Matrix4x4 matrix4x12 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_rewardLabel.rawPivot = (UIWidget.Pivot)matrix4x;
			obj12 = _inactiveRewardShadowColor;
			obj35 = obj12;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj35;
			Matrix4x4 matrix4x13 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Vector2 effectDistance6 = ((UILabel)matrix4x).effectDistance;
			_checkMark.tag = (string)1;
			return;
		}
		if ((nint)text2 <= 3 && ~(_forceActive ? 1u : 0u) != 0)
		{
			obj2 = _inactiveLastDayBackgroundColor;
			obj18 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
			Matrix4x4 matrix4x14 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_backgroundInactive.rawPivot = (UIWidget.Pivot)matrix4x;
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S1_v135 (Il2CppClass<Strings>)+BA]");
			object obj43 = (nint)0 & (nint)0x200;
			if (obj43 != null)
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S1_v189 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text7 = Strings.GetDefault("DAILY_CHALLENGE_DAY_5");
			_dayLabel.fontSize = (int)text7;
			obj5 = _inactiveLastDayDayColor;
			obj19 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
			Matrix4x4 matrix4x15 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_dayLabel.rawPivot = (UIWidget.Pivot)matrix4x;
			obj8 = _inactiveLastDayDayShadowColor;
			obj20 = obj8;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj20;
			Matrix4x4 matrix4x16 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Vector2 effectDistance7 = ((UILabel)matrix4x).effectDistance;
			obj11 = _inactiveLastDayRewardShadowColor;
			obj21 = obj11;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj21;
			Matrix4x4 matrix4x17 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Vector2 effectDistance8 = ((UILabel)matrix4x).effectDistance;
			_checkMark.tag = null;
			_checkbackBackground.tag = null;
			_rewardLabel.tag = (string)1;
			_checkBackLabel.tag = null;
			object obj44 = _gradientEffectSprites + 12;
			object obj45 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44))
			{
				object obj46 = _gradientEffectSprites + 16;
				object obj47 = obj45 << 2;
				object obj48 = obj46 + obj47;
				obj2 = _inactiveLastDayGradientColor;
				obj22 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj22;
				Matrix4x4 matrix4x18 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((UIWidget)obj48).rawPivot = (UIWidget.Pivot)matrix4x;
				object obj49 = obj45 + 1;
				obj45 = obj49;
			}
			obj2 = _inactiveLastDayGlow;
			obj23 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj23;
			Matrix4x4 matrix4x19 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_glowEffect.rawPivot = (UIWidget.Pivot)matrix4x;
			return;
		}
		obj2 = _activeLastDayBackgroundColor;
		obj4 = obj2;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x20 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_backgroundInactive.rawPivot = (UIWidget.Pivot)matrix4x;
		nint num12 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S1_v57 (Il2CppClass<Strings>)+BA]");
		object obj50 = (nint)0 & (nint)0x200;
		if (obj50 != null)
		{
			nint num13 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S1_v123 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text8 = Strings.GetDefault("DAILY_CHALLENGE_TODAY_1");
		_dayLabel.fontSize = (int)text8;
		obj5 = _activeLastDayDayColor;
		obj7 = obj5;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Matrix4x4 matrix4x21 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_dayLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		obj8 = _activeLastDayDayShadowColor;
		obj10 = obj8;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Matrix4x4 matrix4x22 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance9 = ((UILabel)matrix4x).effectDistance;
		obj11 = _activeLastDayDayColor;
		obj13 = obj11;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
		Matrix4x4 matrix4x23 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_rewardLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		obj14 = _activeLastDayRewardShadowColor;
		obj15 = obj14;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
		Matrix4x4 matrix4x24 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance10 = ((UILabel)matrix4x).effectDistance;
		if (wordHuntManager != null)
		{
			_checkMark.tag = (string)1;
			_checkbackBackground.tag = (string)1;
			_rewardLabel.tag = null;
			_checkBackLabel.tag = (string)1;
		}
		else
		{
			_checkMark.tag = null;
			_checkbackBackground.tag = null;
			_rewardLabel.tag = (string)1;
			_checkBackLabel.tag = null;
		}
		object obj51 = _gradientEffectSprites + 12;
		object obj52 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj52) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51))
		{
			object obj53 = _gradientEffectSprites + 16;
			object obj54 = obj52 << 2;
			object obj55 = obj53 + obj54;
			obj2 = _activeLastDayGradientColor;
			obj16 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
			Matrix4x4 matrix4x25 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)obj55).rawPivot = (UIWidget.Pivot)matrix4x;
			object obj56 = obj52 + 1;
			obj52 = obj56;
		}
		obj2 = _activeLastDayGlow;
		obj17 = obj2;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj17;
		Matrix4x4 matrix4x26 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_glowEffect.rawPivot = (UIWidget.Pivot)matrix4x;
	}
}
