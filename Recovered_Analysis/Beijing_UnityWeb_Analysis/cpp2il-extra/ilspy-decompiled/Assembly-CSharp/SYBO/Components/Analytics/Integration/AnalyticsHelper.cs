using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Data.Managers;
using Data.Migration;
using Data.Save;
using InApp;
using Info;
using SYBO.Components.Logging;
using SYBO.Components.Settings;
using SYBO.Subway.Info;
using UI.Generic.Layout;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace SYBO.Components.Analytics.Integration;

public class AnalyticsHelper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<char, bool> _003C_003E9__0_0;

		public static Func<char, bool> _003C_003E9__0_1;

		public static Func<char, bool> _003C_003E9__1_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CachingRootFileJsonSettingsParser._003C_003Ec obj = default;
			CachingRootFileJsonSettingsParser._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003CGetLocalCurrencyPriceAsFloat_003Eb__0_0(char c)
		{
			//IL_000e: Expected I4, but got Obj
			InvalidOperationException ex = new InvalidOperationException();
			return (byte)(int)ex != 0;
		}

		internal bool _003CGetLocalCurrencyPriceAsFloat_003Eb__0_1(char c)
		{
			int num = c & 0xFFFF;
			return num == 46;
		}

		internal bool _003CContainsDigits_003Eb__1_0(char c)
		{
			int num = c & 0xFFFF;
			return num == 44;
		}
	}

	private static Dictionary<string, string> AndroidOsVersionByApiVersion;

	private static List<KeyValuePair<string, string>> AndroidApiVersionByOsVersion;

	public unsafe static float GetLocalCurrencyPriceAsFloat(string localPriceWithCurrency, InAppItemModel.ItemType itemType, string itemTitleId)
	{
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got I4
		//IL_0350: Expected I, but got Obj
		//IL_0366: Expected Obj, but got I
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected Obj, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected Obj, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected Obj, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected Obj, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected Obj, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Obj, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Obj, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected Obj, but got Unknown
		//IL_072d: Expected Obj, but got I4
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected VT, but got Unknown
		//IL_0748: Expected F4, but got Obj
		//IL_0743: Expected native int or pointer, but got VT
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected VT, but got Unknown
		//IL_0763: Expected F4, but got Obj
		//IL_075e: Expected native int or pointer, but got VT
		//IL_0782: Expected I, but got Obj
		//IL_0798: Expected Obj, but got I
		//IL_07d1: Expected Obj, but got I
		//IL_07e7: Invalid comparison between Obj and F4
		//IL_0013: Expected I, but got Obj
		//IL_03cc: Expected Obj, but got I4
		//IL_03d9: Expected F4, but got Obj
		//IL_03d4: Expected native int or pointer, but got VT
		//IL_03e6: Expected F4, but got Obj
		//IL_03e1: Expected native int or pointer, but got VT
		//IL_040c: Expected Obj, but got I4
		//IL_0419: Expected F4, but got Obj
		//IL_0414: Expected native int or pointer, but got VT
		//IL_0426: Expected F4, but got Obj
		//IL_0421: Expected native int or pointer, but got VT
		//IL_044c: Expected F4, but got Obj
		//IL_0447: Expected native int or pointer, but got VT
		//IL_0459: Expected F4, but got Obj
		//IL_0454: Expected native int or pointer, but got VT
		//IL_01d0: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_0398: Expected Obj, but got I4
		//IL_03a5: Expected F4, but got Obj
		//IL_03a0: Expected native int or pointer, but got VT
		//IL_03b2: Expected F4, but got Obj
		//IL_03ad: Expected native int or pointer, but got VT
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_056c: Expected Obj, but got I4
		//IL_0579: Expected F4, but got Obj
		//IL_0574: Expected native int or pointer, but got VT
		//IL_0586: Expected F4, but got Obj
		//IL_0581: Expected native int or pointer, but got VT
		//IL_05a4: Expected F4, but got Obj
		//IL_059f: Expected native int or pointer, but got VT
		//IL_05b5: Expected I4, but got VT
		//IL_05c2: Expected Obj, but got I4
		//IL_05cf: Expected F4, but got Obj
		//IL_05ca: Expected native int or pointer, but got VT
		//IL_05dc: Expected F4, but got Obj
		//IL_05d7: Expected native int or pointer, but got VT
		//IL_04e6: Expected Obj, but got I4
		//IL_04f3: Expected F4, but got Obj
		//IL_04ee: Expected native int or pointer, but got VT
		//IL_0500: Expected F4, but got Obj
		//IL_04fb: Expected native int or pointer, but got VT
		//IL_0314: Expected F4, but got Obj
		//IL_030f: Expected native int or pointer, but got VT
		//IL_0321: Expected F4, but got Obj
		//IL_031c: Expected native int or pointer, but got VT
		//IL_02c0: Expected I, but got Obj
		//IL_0545: Expected F4, but got Obj
		//IL_0540: Expected native int or pointer, but got VT
		//IL_0552: Expected F4, but got Obj
		//IL_054d: Expected native int or pointer, but got VT
		//IL_0183: Expected I, but got Obj
		//IL_024f: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v177 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 160;
		object obj6 = obj2 + 152;
		object obj7 = obj2 + 144;
		object obj8 = obj2 + 136;
		object obj9 = obj2 + 128;
		object obj10 = obj2 + 120;
		object obj11 = obj2 + 112;
		object obj12 = obj2 + 104;
		object obj13 = obj2 + 96;
		object obj14 = obj2 + 88;
		object obj15 = obj2 + 80;
		object obj16 = obj2 + 72;
		object obj17 = obj2 - -64;
		object obj18 = obj2 + 56;
		object obj19 = obj2 + 48;
		object obj20 = obj2 + 32;
		Scrollbar scrollbar = (Scrollbar)(obj2 + 16);
		object obj21 = obj2 + 8;
		object obj22 = obj2 + 176;
		obj22 = itemTitleId;
		object obj23 = obj2 + 168;
		obj23 = ((InAppItemModel.ItemType*)(int)itemType)->value__;
		Vector2 vector = (Vector2)(obj2 + 184);
		((Vector2*)(nint)vector)->x = (float)obj22;
		Vector2 vector2 = (Vector2)(obj2 + 192);
		((Vector2*)(nint)vector2)->x = (float)obj23;
		Vector2 vector3 = vector * vector2;
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v69 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		bool flag = obj24 == null;
		object obj25 = obj * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj26 = num4 * 0;
		object obj27 = obj25 + obj26;
		if (obj27 == (object)0f)
		{
			if (!flag)
			{
				nint num5 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v173 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = localPriceWithCurrency;
			obj6 = ((InAppItemModel.ItemType*)(int)itemType)->value__;
			((Vector2*)(nint)vector)->x = (float)obj5;
			((Vector2*)(nint)vector2)->x = (float)obj6;
		}
		else
		{
			if (!flag)
			{
				nint num6 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v162 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj7 = localPriceWithCurrency;
			obj8 = ((InAppItemModel.ItemType*)(int)itemType)->value__;
			((Vector2*)(nint)vector)->x = (float)obj7;
			((Vector2*)(nint)vector2)->x = (float)obj8;
			Vector2 vector4 = vector * vector2;
			obj9 = itemTitleId;
			obj10 = ((InAppItemModel.ItemType*)(int)itemType)->value__;
			((Vector2*)(nint)vector)->x = (float)obj9;
			((Vector2*)(nint)vector2)->x = (float)obj10;
			Vector2 vector5 = vector * vector2;
			obj11 = obj4;
			((Vector2*)(nint)vector)->x = (float)obj11;
			((Vector2*)(nint)vector2)->x = (float)obj12;
			float num7 = vector.x * vector2.x;
			float num8 = vector.y * vector2.y;
			float num9 = num7 + num8;
			float num10 = num9 / (float)obj27;
			if (num10 < 0f)
			{
				nint num11 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v146 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num12 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v158 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj13 = localPriceWithCurrency;
				obj14 = ((InAppItemModel.ItemType*)(int)itemType)->value__;
				((Vector2*)(nint)vector)->x = (float)obj13;
				((Vector2*)(nint)vector2)->x = (float)obj14;
				Vector2 vector6 = vector * vector2;
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1143A");
				goto IL_0326;
			}
			nint num13 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v107 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			bool flag2 = obj29 == null;
			if (num10 > 1f)
			{
				if (!flag2)
				{
					nint num14 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v141 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj15 = localPriceWithCurrency;
				obj16 = itemTitleId;
				((Vector2*)(nint)vector)->x = (float)obj15;
				((Vector2*)(nint)vector2)->x = (float)obj16;
			}
			else
			{
				if (!flag2)
				{
					nint num15 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v130 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj17 = itemTitleId;
				obj18 = ((InAppItemModel.ItemType*)(int)itemType)->value__;
				((Vector2*)(nint)vector)->x = (float)obj17;
				((Vector2*)(nint)vector2)->x = (float)obj18;
				Vector2 vector7 = vector * vector2;
				((Vector2*)(nint)vector2)->x = (float)obj19;
				scrollbar.Set(num10, (byte)(int)vector2 != 0);
				obj20 = ((InAppItemModel.ItemType*)(int)itemType)->value__;
				((Vector2*)(nint)vector)->x = (float)obj20;
				((Vector2*)(nint)vector2)->x = (float)scrollbar;
				Vector2 vector8 = vector - vector2;
				obj21 = localPriceWithCurrency;
				((Vector2*)(nint)vector)->x = (float)obj21;
				((Vector2*)(nint)vector2)->x = (float)obj2;
			}
		}
		Vector2 vector9 = vector * vector2;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1143A");
		goto IL_0326;
		IL_0326:
		float result = default;
		return result;
	}

	private static bool ContainsDigits(string text)
	{
		return (byte)text.m_stringLength != 0;
	}

	public static InAppItemModel.ItemType ConvertFacebookRewardToItemType(FacebookRewardsInfo.FacebookRewardType rewardType)
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__1_0 == null;
		bool flag2 = !flag;
		Func<char, bool> predicate = _003C_003Ec._003C_003E9__1_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v19 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v39 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<char, bool> func = default;
			object obj3 = func + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v36 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)12;
			obj4 = func;
			predicate = func;
		}
		int num7 = Enumerable.Count((IEnumerable<char>)rewardType, predicate);
		return (num7 > 0) ? InAppItemModel.ItemType.Character : InAppItemModel.ItemType.Undefined;
	}

	public static bool IsRewardAnUnpurchasedItem(CelebrationReward reward)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (reward != null)
		{
			nint num = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v20 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			Log.Analytics.LogErrorFormat("Unhandled reward type {0} received when converting to item type.", args);
			return false;
		}
		return true;
	}

	public unsafe static void ConvertRewardToItemAddedParameters(CelebrationReward reward, out ObtainableItemSource itemSource, out long sourceId, out string sourceMeta, out string itemTitleId, out InAppItemModel.ItemType itemType, out long itemBalanceAfter, out long itemDelta)
	{
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0839: Expected Obj, but got I4
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected Obj, but got Unknown
		//IL_0856: Expected Obj, but got I4
		//IL_086a: Expected I, but got Obj
		//IL_0880: Expected Obj, but got I
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected Obj, but got Unknown
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_015c: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_02ab: Expected I, but got Obj
		//IL_02c1: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_0955: Expected I, but got Obj
		//IL_096b: Expected Obj, but got I
		//IL_02ec: Expected I, but got Obj
		//IL_021d: Expected I, but got Obj
		//IL_0233: Expected Obj, but got I
		//IL_0506: Expected I, but got Obj
		//IL_0360: Expected Obj, but got I4
		//IL_025e: Expected I, but got Obj
		//IL_0802: Expected Obj, but got I4
		//IL_0586: Expected I, but got Obj
		//IL_059c: Expected Obj, but got I
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected Obj, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_05c7: Expected I, but got Obj
		//IL_0619: Expected Obj, but got I4
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected Obj, but got Unknown
		//IL_0cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf4: Expected Obj, but got Unknown
		//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v243 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 48;
		object obj6 = obj2 + 12;
		if ((UnityEngine.Object)(object)reward != null)
		{
			return;
		}
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref itemSource) == null)
		{
			string tag = ((Component)(object)reward).tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v258 (Il2CppClass<NGUITools>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v263 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			byte[] array = NGUITools.Load(tag);
			if (array == null)
			{
				return;
			}
		}
		UIPanel uIPanel = ((System.Runtime.CompilerServices.Unsafe.AsPointer(ref sourceId) == null) ? ((Component)(object)reward).GetComponent<UIPanel>() : null);
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v232 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIPanel).FindKernel((string)null) != 0)
		{
			if (!uIPanel.isActiveAndEnabled)
			{
				return;
			}
			IgnoreLayout component = uIPanel.GetComponent<IgnoreLayout>();
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v245 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v250 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				return;
			}
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v222 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIPanel).FindKernel((string)null) != 0 && uIPanel.mClipping != UIDrawCall.Clipping.None)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj11 = 0;
			object obj13 = default;
			while ((nint)obj11 <= 3)
			{
				object obj12 = obj13 + 16;
				object obj14 = obj11 * 12;
				object obj15 = obj12 + obj14;
				obj6 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v148+8]");
				_ = 0;
				obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				if ((nint)obj5 > (nint)itemType)
				{
					obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					ref InAppItemModel.ItemType reference = ref *(InAppItemModel.ItemType*)obj5;
				}
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [itemType @ L5 (ItemType&)+4]");
				if (num11 > 0)
				{
					obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
					_ = 0;
				}
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [itemType @ L5 (ItemType&)+8]");
				if (num12 > 0)
				{
					obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
					_ = 0;
				}
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj16 = obj5;
				string obj17 = itemTitleId;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref obj17))
				{
					obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					ref string reference2 = ref *(string*)obj5;
				}
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [itemTitleId @ L4 (System.String&)+4]");
				if (num13 < 0)
				{
					obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
					_ = 0;
				}
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [itemTitleId @ L4 (System.String&)+8]");
				if (num14 < 0)
				{
					obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
					_ = 0;
				}
				ref long reference3 = ref *(long*)1;
				object obj18 = obj11 + 1;
				obj11 = obj18;
			}
			return;
		}
		UIWidget component2 = ((Component)(object)reward).GetComponent<UIWidget>();
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v146 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) != 0 && component2.isActiveAndEnabled)
		{
			IgnoreLayout component3 = component2.GetComponent<IgnoreLayout>();
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num18 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S1_v139 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component3).FindKernel((string)null) != 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj21 = 0;
			object obj23 = default;
			while ((nint)obj21 <= 3)
			{
				object obj22 = obj23 + 16;
				object obj24 = obj21 * 12;
				object obj25 = obj22 + obj24;
				obj6 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S1_v46+8]");
				_ = 0;
				obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				if ((nint)obj5 > (nint)itemType)
				{
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					ref InAppItemModel.ItemType reference = ref *(InAppItemModel.ItemType*)obj5;
				}
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
				nint num19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [itemType @ L5 (ItemType&)+4]");
				if (num19 > 0)
				{
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
					_ = 0;
				}
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [itemType @ L5 (ItemType&)+8]");
				if (num20 > 0)
				{
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
					_ = 0;
				}
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				object obj26 = obj5;
				string obj27 = itemTitleId;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref obj27))
				{
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					ref string reference2 = ref *(string*)obj5;
				}
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
				nint num21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [itemTitleId @ L4 (System.String&)+4]");
				if (num21 < 0)
				{
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
					_ = 0;
				}
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [itemTitleId @ L4 (System.String&)+8]");
				if (num22 < 0)
				{
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
					_ = 0;
				}
				ref long reference3 = ref *(long*)1;
				object obj28 = obj21 + 1;
				obj21 = obj28;
			}
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref itemDelta) == null)
			{
				return;
			}
		}
		int siblingIndex = ((Transform)(object)reward).GetSiblingIndex();
		Sprite sprite = null;
		while ((nint)sprite < siblingIndex)
		{
			bool flag = ((SpriteAtlas)(object)reward).CanBindTo(sprite);
			ConvertRewardToItemAddedParameters((CelebrationReward)flag, out itemSource, out *(long*)null, out sourceMeta, out itemTitleId, out itemType, out itemBalanceAfter, out *(long*)1);
			Sprite sprite2 = (Sprite)(sprite + 1);
			sprite = sprite2;
		}
	}

	private static bool IsVideoReward(CelebrationReward reward)
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		if (reward.CelebrationRewardOrigin != CelebrationRewardOrigin.NewHighScore && reward.CelebrationRewardOrigin != CelebrationRewardOrigin.TopRun)
		{
			if (reward.CelebrationRewardOrigin == CelebrationRewardOrigin.CharacterUnlock)
			{
				nint num = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v27 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v37 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Characters.Model model = Characters.characterData.get_Item(reward.characterId);
				if (model.unlockType != PurchaseData.UnlockType.Tokens)
				{
					goto IL_01d8;
				}
			}
			if (reward.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardUnlock && reward.CelebrationRewardOrigin != CelebrationRewardOrigin.BoardBundleUnlock)
			{
				return reward.CelebrationRewardOrigin != CelebrationRewardOrigin.BundleUnlock;
			}
		}
		goto IL_01d8;
		IL_01d8:
		return false;
	}

	public static int GetItemBalance(InAppItemModel.ItemType itemType, Characters.CharacterId characterId = Characters.CharacterId.fresh)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0034: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC2");
		object obj2 = default;
		object obj = obj2 * 366;
		object obj3 = default;
		return (int)(obj3 + obj);
	}

	public static int GetItemPayoutAmount(InAppItemModel item)
	{
		if ((nint)item.itemId == 3)
		{
			return 1;
		}
		if ((nint)item.itemId == 2)
		{
			return 1;
		}
		if ((nint)item.itemId == 8)
		{
			return 1;
		}
		if ((nint)item.itemId == 5)
		{
			return 1;
		}
		if ((nint)item.itemId == 1)
		{
			return 1;
		}
		if ((nint)item.itemId == 4)
		{
			return 1;
		}
		if ((nint)item.itemId == 6)
		{
			return 1;
		}
		return ((nint)item.itemId == 7) ? 1 : 0;
	}

	public static string GetSyboAnalyticsMissionSetString()
	{
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		object obj3 = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AggregatedDataTracking aggregatedDataTracking = default;
		aggregatedDataTracking.Initialize(hadUserInPlayerInfo: true, 0);
		object obj4 = 0;
		while ((nint)obj4 <= 9999)
		{
			uint seed = ((LoggingRandomGen)(object)aggregatedDataTracking).Seed;
			object obj5 = obj4 + 1;
			obj4 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AggregatedDataTracking aggregatedDataTracking2 = default;
		aggregatedDataTracking2.Initialize((byte)(int)aggregatedDataTracking._dataContainer != 0, aggregatedDataTracking._currentKeysAmount);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder sb = default;
		System.Text.StringBuilderCache.Release(sb);
		object obj6 = 0;
		object obj7 = default;
		object obj8 = default;
		while ((nint)obj7 <= 99)
		{
			uint seed2 = ((LoggingRandomGen)(object)aggregatedDataTracking).Seed;
			uint seed3 = ((LoggingRandomGen)(object)aggregatedDataTracking2).Seed;
			if (seed2 != seed3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			obj7 = obj8 + 1;
		}
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int totalLength = default;
			return string.ConcatArray((string[])(object)"MTRandomGenTest.TestIncrement: FAILED\n", totalLength);
		}
		return "MTRandomGenTest.TestIncrement: SUCCESS";
	}

	public unsafe static string GetAndroidDeviceOsString(string deviceOs)
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0290: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I4
		//IL_0132: Expected I, but got Obj
		//IL_01ba: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got F4
		//IL_030e: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I4
		//IL_01fb: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [deviceOs @ L0 (System.String)+28]");
		object obj3 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [deviceOs @ L0 (System.String)+28]");
		if ((nint)0 != 1 && (nint)obj3 != 1 && (nint)obj3 != 2 && (nint)obj3 != 3)
		{
			if ((nint)obj3 != 4 && (nint)obj3 != 5)
			{
				if ((nint)obj3 != 6)
				{
					if ((nint)obj3 == 7)
					{
						goto IL_00d5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [deviceOs @ L0 (System.String)+28]");
					if ((nint)0 == 20)
					{
						return (string)1;
					}
				}
				nint num = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v29 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num2 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v37 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float timeSinceLevelLoad = Time.timeSinceLevelLoad;
				obj = timeSinceLevelLoad;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj2 = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				AnalyticsLogCategory analytics = Log.Analytics;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [deviceOs @ L0 (System.String)+10]");
				object arg = default;
				object arg2 = default;
				analytics.LogErrorFormat((Enum)null, "[SYBO Analytics] - {0:0.00}s : Undefined purchased item count for product ID '{1}'. Returning '{2}'.", arg, (object)0, arg2);
				return (string)(-1);
			}
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v16 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v23 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [deviceOs @ L0 (System.String)+10]");
			bool flag = PlayerInfoMigrator.InterstitialStatsTryGetValueNotNull((IDictionary<string, object>)activeInAppOffers, (string)0, out *(object*)null);
			return (string)flag;
		}
		goto IL_00d5;
		IL_00d5:
		return (string)1;
	}

	private static string GetAndroidDeviceOsString(string osVersion, string apiVersion)
	{
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_0358: Expected I, but got Obj
		//IL_036e: Expected Obj, but got I
		//IL_0491: Expected Obj, but got F4
		//IL_03e1: Expected Obj, but got I4
		//IL_0399: Expected I, but got Obj
		//IL_0415: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I4
		//IL_02ca: Expected I, but got Obj
		//IL_02e0: Expected Obj, but got I
		//IL_046f: Expected I4, but got Obj
		//IL_047b: Expected Obj, but got I4
		//IL_030b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		object obj3 = obj2 + 4;
		object obj4 = osVersion - 1;
		if ((nint)osVersion == 1 || (nint)obj4 == 1 || (nint)obj4 == 2 || (nint)obj4 == 3)
		{
			goto IL_0231;
		}
		if ((nint)obj4 != 4)
		{
			if ((nint)obj4 != 5)
			{
				if ((nint)obj4 != 6)
				{
					if ((nint)obj4 == 7)
					{
						goto IL_023f;
					}
					if ((nint)obj4 == 8)
					{
						int tier = InventorySave.GetTier(UpgradeType.hoverboard);
						return (string)tier;
					}
					if ((nint)obj4 == 9)
					{
						int tier2 = InventorySave.GetTier(UpgradeType.headstart2000);
						return (string)tier2;
					}
					if ((nint)obj4 == 10)
					{
						int tier3 = InventorySave.GetTier(UpgradeType.scorebooster);
						return (string)tier3;
					}
					if ((nint)obj4 != 11 && (nint)obj4 != 12 && (nint)obj4 != 13 && (nint)obj4 != 14 && (nint)obj4 != 15 && (nint)obj4 != 16)
					{
						if ((nint)obj4 == 17)
						{
							nint num = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v42 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num2 = (nint)typeof(CharacterManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v48 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int outfitIndex = CharacterManager.GetOutfitIndex((Characters.CharacterId)apiVersion);
							return (string)outfitIndex;
						}
						if ((nint)obj4 == 18 || (nint)obj4 == 19)
						{
							goto IL_0231;
						}
					}
				}
				nint num3 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v29 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float timeSinceLevelLoad = Time.timeSinceLevelLoad;
				obj = timeSinceLevelLoad;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj3 = osVersion;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj2 = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object arg = default;
				object arg2 = default;
				object arg3 = default;
				Log.Analytics.LogErrorFormat((Enum)null, "[SYBO Analytics] - {0:0.00}s : Undefined item balance for item type '{1}'. Returning '{2}'.", arg, arg2, arg3);
				return (string)(-1);
			}
			int coins = InventorySave.coins;
			return (string)coins;
		}
		goto IL_023f;
		IL_0231:
		return (string)1;
		IL_023f:
		int unrewardedCoins = InventorySave.unrewardedCoins;
		return (string)unrewardedCoins;
	}

	private static string GetAndroidOsVersionFromApiVersion(string apiVersion)
	{
		//IL_01bb: Expected I, but got Obj
		//IL_01d1: Expected Obj, but got I
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_01fc: Expected I, but got Obj
		//IL_00d7: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		System.Text.RegularExpressions.ExclusiveReference exclusiveReference = default;
		exclusiveReference.Release((object)"Android OS(?>[a-zA-Z]| |_|\\[|\\])+([0-9]{1,2}\\.[0-9]\\.[0-9]|[0-9]{1,2}\\.[0-9]).*\\/ API-([0-9]{2})");
		System.Text.RegularExpressions.CachedCodeEntry cachedCodeEntry = ((Regex)(object)exclusiveReference).CacheCode(apiVersion);
		if (cachedCodeEntry._capslist != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			GroupCollection groupCollection = default;
			Group obj = groupCollection.GetGroup(1);
			string osVersion = obj.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			GroupCollection groupCollection2 = default;
			Group obj2 = groupCollection2.GetGroup(2);
			string apiVersion2 = obj2.ToString();
			nint num = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S2_v13 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(AnalyticsHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S2_v18 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return ValidateAndroidOsVersionFromApiVersion(osVersion, apiVersion2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		System.Text.RegularExpressions.ExclusiveReference exclusiveReference2 = default;
		exclusiveReference2.Release((object)"\\/ API-([0-9]{2})");
		System.Text.RegularExpressions.CachedCodeEntry cachedCodeEntry2 = ((Regex)(object)exclusiveReference2).CacheCode(apiVersion);
		if (cachedCodeEntry2._capslist == null)
		{
			return "Android OS 0.0.0 / API-0";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		GroupCollection groupCollection3 = default;
		Group obj4 = groupCollection3.GetGroup(1);
		string text = obj4.ToString();
		nint num3 = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v24 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v31 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AnalyticsSettings debugSettings = ((AnalyticsIntegration)(object)text).DebugSettings;
		return ValidateAndroidOsVersionFromApiVersion((string)(object)debugSettings, text);
	}

	private static string ValidateAndroidOsVersionFromApiVersion(string osVersion, string apiVersion)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string menusBeforeString = ((AnalyticsIntegration)(object)osVersion).GetMenusBeforeString((byte)(int)apiVersion != 0);
		return string.Format((IFormatProvider)(object)"Android OS {0} / API-{1}", menusBeforeString, apiVersion);
	}

	static AnalyticsHelper()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		uint[] array = default;
		object obj = array + 20;
		obj = -1727483681;
		MTRandomGen.MAG01 = array;
	}
}
