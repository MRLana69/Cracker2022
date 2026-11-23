using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Subway.Info;
using UnityEngine;

public static class InAppData
{
	public enum BundleTier
	{
		None,
		BundleTier1,
		BundleTier2,
		BundleTier3,
		BundleTier4,
		BundleTier5
	}

	public const string inAppCharacterPrefix = "com.kiloo.subwaycharacter.";

	public const string inAppBoardPrefix = "com.kiloo.subwayboard.";

	public const string inAppPrefix = "com.kiloo.subways.";

	public const string inAppTier1 = "com.kiloo.subways.coinstier1";

	public const string inAppTier2 = "com.kiloo.subways.coinstier2";

	public const string inAppTier3 = "com.kiloo.subways.coinstier3";

	public const string inAppTier4 = "com.kiloo.subways.coinstier4";

	public const string inAppTier5 = "com.kiloo.subways.coinstier5";

	public const string inAppTier6 = "com.kiloo.subways.keystier1";

	public const string inAppTier7 = "com.kiloo.subways.keystier2";

	public const string inAppTier8 = "com.kiloo.subways.keystier3";

	public const string inAppTier9 = "com.kiloo.subways.keystier4";

	public const string inAppDoubleCoins = "com.kiloo.subways.doublecoins";

	public const string inAppDoubleCoinsDiscount = "com.kiloo.subways.doublecoinsdiscount";

	public const string inAppTier1Discount = "com.kiloo.subways.coinstier1discount";

	public const string inAppTier2Discount = "com.kiloo.subways.coinstier2_discount";

	public const string inAppTier3Discount = "com.kiloo.subways.coinstier3discount";

	public const string inAppTier4Discount = "com.kiloo.subways.coinstier4discount";

	public const string inAppTier5Discount = "com.kiloo.subways.coinstier5discount";

	public const string inAppTier6Discount = "com.kiloo.subways.keystier1discount";

	public const string inAppTier7Discount = "com.kiloo.subways.keystier2discount";

	public const string inAppTier8Discount = "com.kiloo.subways.keystier3discount";

	public const string inAppTier9Discount = "com.kiloo.subways.keystier4discount";

	public const string inAppBundleTier1 = "com.kiloo.subways.bundletier1";

	public const string inAppBundleTier2 = "com.kiloo.subways.bundletier2";

	public const string inAppBundleTier3 = "com.kiloo.subways.bundletier3";

	public const string inAppBundleTier4 = "com.kiloo.subways.bundletier4";

	public const string inAppBundleTier5 = "com.kiloo.subways.bundletier5";

	private static readonly string[] inAppCurrencyTiers;

	private static readonly string[] inAppCurrencyDiscountTiers;

	private static readonly string[] inAppBundleTiers;

	private static readonly Dictionary<string, string> inAppTiersOnlineSettingsIds;

	private static readonly Dictionary<string, string> ignoredInAppTiersOnlineSettingsIds;

	public static readonly List<string> LIST_OF_MANAGED_INAPP_IDS;

	public static Dictionary<string, InAppItemModel> inAppData;

	public static int InAppPurchaseCount
	{
		get
		{
			Dictionary<string, InAppItemModel> dictionary = inAppData;
			return dictionary._count - dictionary._freeCount;
		}
	}

	public static string CommaSeparatedProductIds
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Expected Obj, but got Unknown
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_036b: Expected Obj, but got Unknown
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a0: Expected Obj, but got Unknown
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Expected Obj, but got Unknown
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Expected Obj, but got Unknown
			//IL_0046: Expected Obj, but got I
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + -64;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj4 = obj + 40;
			obj = obj4;
			_ = 0;
			string text = string.Empty;
			object obj6 = default;
			object obj7 = default;
			string text3 = default;
			object obj8 = default;
			string text4 = default;
			object obj10 = default;
			object obj11 = default;
			object obj12 = default;
			object obj13 = default;
			object obj15 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj9;
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						goto IL_025b;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					obj = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						string text2;
						if ((nint)obj7 < 1)
						{
							text2 = text;
						}
						else
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag = (nint)0 == 1;
							text2 = text3;
							if (flag)
							{
								goto IL_01c2;
							}
						}
						_ = 0;
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
								obj7 = obj8 + 1;
								text = text4;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						obj9 = obj10;
						text = text2;
						goto IL_01e3;
					}
				}
				goto IL_01c2;
				IL_01e3:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				if (obj11 != obj12)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_025b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj13;
				break;
				IL_025b:
				object obj14 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142C");
				return text;
				IL_01c2:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj15;
				goto IL_01e3;
			}
			_ = 0;
			object obj16 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			string result = default;
			return result;
		}
	}

	static InAppData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public static string GetBundleId(BundleTier tier)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		switch (tier)
		{
		case BundleTier.None:
		{
			_ = -1;
			obj = (Enum)(object)typeof(BundleTier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text3 = obj.ToString();
			string text4 = "Bundle ID could not be found. BundleTier: " + text3;
			return "TierNotFound";
		}
		case BundleTier.BundleTier1:
			return "com.kiloo.subways.bundletier1";
		case BundleTier.BundleTier2:
			return "com.kiloo.subways.bundletier2";
		case BundleTier.BundleTier3:
			return "com.kiloo.subways.bundletier3";
		case BundleTier.BundleTier4:
			return "com.kiloo.subways.bundletier4";
		case BundleTier.BundleTier5:
			return "com.kiloo.subways.bundletier5";
		default:
		{
			_ = -1;
			obj = (Enum)(object)typeof(BundleTier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string text2 = "Bundle ID could not be found. BundleTier: " + text;
			return "TierNotFound";
		}
		}
	}

	public static string GetInAppOnlineSettingsId(string inAppId)
	{
		//IL_0047: Expected Obj, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return inAppTiersOnlineSettingsIds.get_Item(inAppId);
		}
		return null;
	}

	public static string GetIgnoredInAppOnlineSettingsId(string inAppId)
	{
		//IL_0047: Expected Obj, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return ignoredInAppTiersOnlineSettingsIds.get_Item(inAppId);
		}
		return null;
	}

	public static string GetDiscountIdForNormalOffer(string normalOffer)
	{
		//IL_00b3: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		string[] array = inAppCurrencyDiscountTiers;
		object obj = 0;
		string result;
		while (true)
		{
			if (array.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)array + obj2;
				Dictionary<string, InAppItemModel> dictionary = inAppData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v29+10]");
				InAppItemModel inAppItemModel = dictionary.get_Item((string)0);
				bool flag = inAppItemModel.NormalOfferId__BackingField != normalOffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v29+10]");
				result = (string)0;
				if (!flag)
				{
					break;
				}
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			result = string.Empty;
			break;
		}
		return result;
	}

	public static string[] getInAppBundleTiers()
	{
		return inAppBundleTiers;
	}

	public static bool InappidIsDynamicLimitedCharacterPurchase(string inappId)
	{
		return inappId.StartsWith("com.kiloo.subwaycharacter.");
	}

	public static bool InappidIsDynamicLimitedBoardPurchase(string inappId)
	{
		return inappId.StartsWith("com.kiloo.subwayboard.");
	}

	public static string[] GetCurrencyTiers()
	{
		return inAppCurrencyTiers;
	}

	public static string[] GetCurrencyDiscountTiers()
	{
		return inAppCurrencyDiscountTiers;
	}

	public static string[] GetAllProductIds()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		List<string> list = default;
		list._002Ector();
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		string[] array = default;
		string[] array2 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
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
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			string[] result = array;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = array2;
			}
			_ = 0;
			object obj10 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		object obj11 = obj7 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142C");
		return list.ToArray();
	}

	public unsafe static bool TryConvertDynamicPurchaseIdToCharacterType(string purchaseId, out Characters.CharacterType charReturned)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected Obj, but got Unknown
		//IL_0a4b: Expected Obj, but got I4
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected Obj, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_08d4: Expected Obj, but got I
		//IL_049a: Expected Obj, but got I
		//IL_04d5: Expected Obj, but got I
		//IL_0528: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I4
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj + 40;
		_ = 0;
		string text = purchaseId.Replace("com.kiloo.subwaycharacter.", string.Empty);
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
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj5 = default;
							ref Characters.CharacterType reference = ref *(Characters.CharacterType*)obj5;
							return true;
						}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag = obj6 != obj7;
		object obj9 = default;
		object obj8 = obj9;
		bool flag4 = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj11 = default;
				object obj10 = obj11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = default;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj4 + obj13;
						obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						object obj16 = obj + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S1_v55+5C]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
						_ = 0;
						object obj18 = obj - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						_ = 0;
						object obj19 = obj + 56;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						object obj21 = default;
						object obj25 = default;
						object obj26 = default;
						object obj28 = default;
						object obj29 = default;
						object obj30 = default;
						while (true)
						{
							_ = 0;
							bool flag2 = ((Dictionary<Characters.CharacterType, Characters.Model>.Enumerator*)1136)->MoveNext();
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							object obj24;
							if ((nint)0 != 1)
							{
								_ = 0;
								object obj20 = obj + 56;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj21 != null)
									{
										_ = 0;
										KeyValuePair<Characters.CharacterType, Characters.Model> current = ((Dictionary<Characters.CharacterType, Characters.Model>.Enumerator*)1136)->Current;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
												_ = 0;
												_ = 0;
												Characters.Model value = ((KeyValuePair<Characters.CharacterType, Characters.Model>*)1136)->Value;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
													object obj22 = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S0_v187+44]");
														object obj23 = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S0_v187+44]");
														if ((nint)0 != 0)
														{
															obj24 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S0_v194+8]");
															if ((nint)0 != 0)
															{
																goto IL_0acb;
															}
														}
														obj24 = 1;
														goto IL_0acb;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												goto IL_0826;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										goto IL_0826;
									}
									goto IL_08a6;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_0826;
							IL_0acb:
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							ref Characters.CharacterType reference;
							if ((nint)0 != 1)
							{
								if (obj24 != null)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											if (obj25 == null)
											{
												continue;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
														if (obj26 == null)
														{
															continue;
														}
														_ = 0;
														Characters.CharacterType key = ((KeyValuePair<Characters.CharacterType, Characters.Model>*)1136)->Key;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
																reference = ref *(Characters.CharacterType*)null;
																object obj27 = obj + 16;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @575E");
																return true;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
													goto IL_0826;
												}
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
							goto IL_0826;
							IL_0826:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							bool flag3 = obj28 != obj6;
							obj8 = obj29;
							if (flag3)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_08a6;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							obj8 = obj30;
							break;
							IL_08a6:
							object obj31 = obj + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @575E");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
							object obj32 = -1;
							reference = ref *(Characters.CharacterType*)null;
							return false;
						}
						_ = 0;
						object obj33 = obj + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_0a18;
						}
						goto IL_0b43;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj34 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					flag4 = (nint)0 != 1;
					if (flag4)
					{
						goto IL_0a28;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 == 1;
			object obj35 = default;
			obj8 = obj35;
			if (flag5)
			{
				goto IL_0b43;
			}
		}
		goto IL_0a18;
		IL_0a28:
		return flag4;
		IL_0a18:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0b43;
		IL_0b43:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_0a28;
	}

	public static string ConvertCharacterTypeToDynamicPurchaseId(Characters.CharacterType charType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		Characters.Model model = Characters.characterData.get_Item(charType);
		string text;
		if (IsUsingCustomIapIdForCharacter(model))
		{
			text = model.dynamicIapId;
		}
		else
		{
			_ = -1;
			obj = (Enum)(object)typeof(Characters.CharacterType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text2 = obj.ToString();
			text = "com.kiloo.subwaycharacter." + text2;
		}
		RuntimePlatform platform = Application.platform;
		bool flag = platform != RuntimePlatform.Android;
		string result = text;
		if (!flag)
		{
			bool isKindleDevice = DeviceUtility.isKindleDevice;
			result = text;
			if (!isKindleDevice)
			{
				string text3 = text.ToLower();
				result = text3;
			}
		}
		return result;
	}

	private static bool IsUsingCustomIapIdForCharacter(Characters.Model model)
	{
		//IL_0017: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		object obj = platform - 8;
		if (platform != RuntimePlatform.IPhonePlayer)
		{
			bool flag = (nint)obj == 1;
			bool result = false;
			if (!flag)
			{
				bool flag2 = (nint)obj == 2;
				result = false;
				if (!flag2)
				{
					if ((nint)obj == 3)
					{
						if (DeviceUtility.isKindleDevice)
						{
							return model.overrideDynamicIapIdKindle;
						}
						return model.overrideDynamicIapIdAndroid;
					}
					bool flag3 = platform != RuntimePlatform.MetroPlayerARM;
					result = false;
					if (!flag3)
					{
						bool overrideDynamicIapIdWSA = model.overrideDynamicIapIdWSA;
						result = overrideDynamicIapIdWSA;
					}
				}
			}
			return result;
		}
		return model.overrideDynamicIapIdiOS;
	}

	public static void PrintDynamicIdsForCharacterTypeForAllPlatforms(Characters.CharacterType characterType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		Characters.Model model = Characters.characterData.get_Item(characterType);
		string text = Strings.Get(model.name);
		_ = -1;
		obj = (Enum)(object)typeof(Characters.CharacterType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text2 = obj.ToString();
		string text3 = "com.kiloo.subwaycharacter." + text2;
		string format = "iOS Id for " + text + ": {0}";
		object arg = model.dynamicIapId;
		if (!model.overrideDynamicIapIdiOS)
		{
			arg = text3;
		}
		string value = string.Format(format, arg);
		StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
		string format2 = "Android Id for " + text + ": {0}";
		string text4 = model.dynamicIapId;
		if (!model.overrideDynamicIapIdAndroid)
		{
			text4 = text3;
		}
		string arg2 = text4.ToLower();
		string value2 = string.Format(format2, arg2);
		StringBuilder stringBuilder3 = stringBuilder.AppendLine(value2);
		string format3 = "Kindle Id for " + text + ": {0}";
		object arg3 = model.dynamicIapId;
		if (!model.overrideDynamicIapIdKindle)
		{
			arg3 = text3;
		}
		string value3 = string.Format(format3, arg3);
		StringBuilder stringBuilder4 = stringBuilder.AppendLine(value3);
		string format4 = "Windows Phone8 Id for " + text + ": {0}";
		object arg4 = model.dynamicIapId;
		if (!model.overrideDynamicIapIdWSA)
		{
			arg4 = text3;
		}
		string value4 = string.Format(format4, arg4);
		StringBuilder stringBuilder5 = stringBuilder.AppendLine(value4);
	}

	public unsafe static bool TryConvertDynamicBoardIdToBoardType(string purchaseId, out Hoverboards.BoardType boardReturned)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected Obj, but got Unknown
		//IL_0aad: Expected Obj, but got I4
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0329: Expected Obj, but got I
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_036d: Expected Obj, but got I
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected Obj, but got Unknown
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected Obj, but got Unknown
		//IL_0936: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got I
		//IL_0537: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_056b: Expected Obj, but got I4
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj + 40;
		_ = 0;
		string text = purchaseId.Replace("com.kiloo.subwayboard.", string.Empty);
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
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj5 = default;
							ref Hoverboards.BoardType reference = ref *(Hoverboards.BoardType*)obj5;
							return true;
						}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag = obj6 != obj7;
		object obj9 = default;
		object obj8 = obj9;
		bool flag4 = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj11 = default;
				object obj10 = obj11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = default;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj4 + obj13;
						obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj16 = (nint)0 << 2;
						object obj17 = obj16 + obj4;
						object obj18 = obj17 - 4;
						object obj19 = obj18;
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ S1_v54+D4] (should have been resolved before IL gen)");
						string text3 = default;
						string text2 = "InAppData: ConvertDynamicBoardIdToBoardType conversion failed. Must be a custom dynamic ID: " + text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						object obj21 = obj + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S1_v59+5C]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
						_ = 0;
						object obj23 = obj - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						_ = 0;
						object obj24 = obj + 56;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						object obj26 = default;
						object obj30 = default;
						object obj31 = default;
						object obj33 = default;
						object obj34 = default;
						object obj35 = default;
						while (true)
						{
							_ = 0;
							bool flag2 = ((Dictionary<Hoverboards.BoardType, Hoverboards.Board>.Enumerator*)1136)->MoveNext();
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							object obj29;
							if ((nint)0 != 1)
							{
								_ = 0;
								object obj25 = obj + 56;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj26 != null)
									{
										_ = 0;
										KeyValuePair<Hoverboards.BoardType, Hoverboards.Board> current = ((Dictionary<Hoverboards.BoardType, Hoverboards.Board>.Enumerator*)1136)->Current;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
												_ = 0;
												_ = 0;
												Hoverboards.Board value = ((KeyValuePair<Hoverboards.BoardType, Hoverboards.Board>*)1136)->Value;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
													object obj27 = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ S0_v191+3C]");
														object obj28 = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ S0_v191+3C]");
														if ((nint)0 != 0)
														{
															obj29 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S0_v198+8]");
															if ((nint)0 != 0)
															{
																goto IL_0b2d;
															}
														}
														obj29 = 1;
														goto IL_0b2d;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												goto IL_0888;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										goto IL_0888;
									}
									goto IL_0908;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_0888;
							IL_0b2d:
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							ref Hoverboards.BoardType reference;
							if ((nint)0 != 1)
							{
								if (obj29 != null)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											if (obj30 == null)
											{
												continue;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
														if (obj31 == null)
														{
															continue;
														}
														_ = 0;
														Hoverboards.BoardType key = ((KeyValuePair<Hoverboards.BoardType, Hoverboards.Board>*)1136)->Key;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
																reference = ref *(Hoverboards.BoardType*)null;
																object obj32 = obj + 16;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @575D");
																return true;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
													goto IL_0888;
												}
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
							goto IL_0888;
							IL_0888:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							bool flag3 = obj33 != obj6;
							obj8 = obj34;
							if (flag3)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_0908;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							obj8 = obj35;
							break;
							IL_0908:
							object obj36 = obj + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @575D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
							object obj37 = -1;
							reference = ref *(Hoverboards.BoardType*)null;
							return false;
						}
						_ = 0;
						object obj38 = obj + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_0a7a;
						}
						goto IL_0ba5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj39 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					flag4 = (nint)0 != 1;
					if (flag4)
					{
						goto IL_0a8a;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 == 1;
			object obj40 = default;
			obj8 = obj40;
			if (flag5)
			{
				goto IL_0ba5;
			}
		}
		goto IL_0a7a;
		IL_0a8a:
		return flag4;
		IL_0a7a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0ba5;
		IL_0ba5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_0a8a;
	}

	public static string ConvertBoardTypeToDynamicPurchaseId(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
		string text;
		if (IsUsingCustomIapIdForBoard(board))
		{
			text = board.dynamicIapId;
		}
		else
		{
			_ = -1;
			obj = (Enum)(object)typeof(Hoverboards.BoardType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text2 = obj.ToString();
			text = "com.kiloo.subwayboard." + text2;
		}
		RuntimePlatform platform = Application.platform;
		bool flag = platform != RuntimePlatform.Android;
		string result = text;
		if (!flag)
		{
			bool isKindleDevice = DeviceUtility.isKindleDevice;
			result = text;
			if (!isKindleDevice)
			{
				string text3 = text.ToLower();
				result = text3;
			}
		}
		return result;
	}

	private static bool IsUsingCustomIapIdForBoard(Hoverboards.Board board)
	{
		//IL_0017: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		object obj = platform - 8;
		if (platform != RuntimePlatform.IPhonePlayer)
		{
			bool flag = (nint)obj == 1;
			bool result = false;
			if (!flag)
			{
				bool flag2 = (nint)obj == 2;
				result = false;
				if (!flag2)
				{
					if ((nint)obj == 3)
					{
						if (DeviceUtility.isKindleDevice)
						{
							return board.overrideDynamicIapIdKindle;
						}
						return board.overrideDynamicIapIdAndroid;
					}
					bool flag3 = platform != RuntimePlatform.MetroPlayerARM;
					result = false;
					if (!flag3)
					{
						bool overrideDynamicIapIdWP = board.overrideDynamicIapIdWP8;
						result = overrideDynamicIapIdWP;
					}
				}
			}
			return result;
		}
		return board.overrideDynamicIapIdiOS;
	}

	public static void PrintDynamicIdsForBoardTypeForAllPlatforms(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
		string text = Strings.Get(board.name);
		_ = -1;
		obj = (Enum)(object)typeof(Hoverboards.BoardType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text2 = obj.ToString();
		string text3 = "com.kiloo.subwayboard." + text2;
		string format = "iOS Id for " + text + ": {0}";
		object arg = board.dynamicIapId;
		if (!board.overrideDynamicIapIdiOS)
		{
			arg = text3;
		}
		string value = string.Format(format, arg);
		StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
		string format2 = "Android Id for " + text + ": {0}";
		string text4 = board.dynamicIapId;
		if (!board.overrideDynamicIapIdAndroid)
		{
			text4 = text3;
		}
		string arg2 = text4.ToLower();
		string value2 = string.Format(format2, arg2);
		StringBuilder stringBuilder3 = stringBuilder.AppendLine(value2);
		string format3 = "Kindle Id for " + text + ": {0}";
		object arg3 = board.dynamicIapId;
		if (!board.overrideDynamicIapIdKindle)
		{
			arg3 = text3;
		}
		string value3 = string.Format(format3, arg3);
		StringBuilder stringBuilder4 = stringBuilder.AppendLine(value3);
		string format4 = "Windows Phone8 Id for " + text + ": {0}";
		object arg4 = board.dynamicIapId;
		if (!board.overrideDynamicIapIdWP8)
		{
			arg4 = text3;
		}
		string value4 = string.Format(format4, arg4);
		StringBuilder stringBuilder5 = stringBuilder.AppendLine(value4);
	}
}
