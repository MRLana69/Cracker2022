using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Info;
using Info.Localization;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Subway.Info;
using UnityEngine;

namespace InApp;

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

	private sealed class _003CGetAllWithItemAndOfferType_003Ed__97 : IEnumerable<InAppItemModel>, IEnumerable, IEnumerator<InAppItemModel>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private InAppItemModel _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private InAppItemModel.ItemType itemType;

		public InAppItemModel.ItemType _003C_003E3__itemType;

		private InAppItemModel.OfferType offerType;

		public InAppItemModel.OfferType _003C_003E3__offerType;

		private Dictionary<string, InAppItemModel>.ValueCollection.Enumerator _003C_003E7__wrap1;

		InAppItemModel IEnumerator<InAppItemModel>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dc: Expected Obj, but got Unknown
				//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ea: Expected Obj, but got Unknown
				//IL_0050: Expected I, but got Obj
				//IL_0066: Expected Obj, but got I
				//IL_0091: Expected I, but got Obj
				//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a9: Expected Obj, but got Unknown
				//IL_0360: Expected Obj, but got I4
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Expected Obj, but got Unknown
				//IL_017e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0183: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 + 48;
				object obj3 = obj2 + 24;
				object obj4 = obj2 + 16;
				obj4 = obj;
				_ = -1;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -3;
						object obj6 = default;
						while (true)
						{
							object obj5 = this + 36;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if (obj6 != null)
							{
								object obj7 = this + 36;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v57+28]");
								if ((nint)0 == (nint)itemType)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v57+2C]");
									if ((nint)0 == (nint)offerType)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
										_003C_003E1__state = 1;
										break;
									}
								}
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj8 = this + 36;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							break;
						}
					}
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v81 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num2 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v116 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj11 = default;
					object obj10 = obj11;
					object obj13 = default;
					object obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj14 = default;
					if (obj12 != obj14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					_003C_003Em__Finally1();
					object obj15 = default;
					if (obj15 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
				}
				return (InAppItemModel)1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetAllWithItemAndOfferType_003Ed__97(int _003C_003E1__state)
		{
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I4
			//IL_00d6: Expected Obj, but got I4
			//IL_002c: Expected I, but got Obj
			//IL_0042: Expected Obj, but got I
			//IL_006d: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 4;
			obj = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Enum obj3 = default;
			IFormatProvider provider = default;
			if (!obj3.System_002EIConvertible_002EToBoolean(provider))
			{
				return;
			}
			nint num = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Info.Settings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Settings.ToggleCurrentSfxOption();
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -3;
			if (_003C_003E1__state != -3 && ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4))
			{
				return;
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 26;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 26)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
		}

		IEnumerator<InAppItemModel> IEnumerable<InAppItemModel>.GetEnumerator()
		{
			return (IEnumerator<InAppItemModel>)_003C_003E2__current;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			_003CGetAllWithItemAndOfferType_003Ed__97 obj;
			if (_003C_003E1__state == -2)
			{
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				if (_003C_003El__initialThreadId == (hasShutdownStarted ? 1 : 0))
				{
					_003C_003E1__state = 0;
					obj = this;
					goto IL_0065;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
			_003CGetAllWithItemAndOfferType_003Ed__97 obj2 = default;
			obj = obj2;
			goto IL_0065;
			IL_0065:
			obj.itemType = _003C_003E3__itemType;
			obj.offerType = _003C_003E3__offerType;
			return obj;
		}
	}

	private const string IN_APP_PREFIX_DEFAULT = "com.kiloo.subwaysurfers.";

	private const string IN_APP_CHARACTER_PREFIX = "com.kiloo.subwaycharacter.";

	public const string IN_APP_BOARD_PREFIX = "com.kiloo.subwayboard.";

	private const string IN_APP_PREFIX_IOS = "com.kiloo.subwaysurfers.";

	private const string IN_APP_PREFIX_ANDROID = "com.kiloo.subways.";

	public const string IN_APP_PREFIX = "com.kiloo.subwaysurfers.";

	private const bool IS_PURE_ANDROID = false;

	private const bool IS_IOS = true;

	private static readonly string[] IN_APP_PREFIXES;

	public const string IN_APP_TIER1 = "com.kiloo.subwaysurfers.coinstier1";

	public const string IN_APP_TIER2 = "com.kiloo.subwaysurfers.coinstier2";

	public const string IN_APP_TIER2_5 = "com.kiloo.subwaysurfers.coinstier2.5";

	public const string IN_APP_TIER3 = "com.kiloo.subwaysurfers.coinstier3";

	public const string IN_APP_TIER4 = "com.kiloo.subwaysurfers.coinstier4";

	public const string IN_APP_TIER5 = "com.kiloo.subwaysurfers.coinstier5";

	public const string IN_APP_TIER6 = "com.kiloo.subwaysurfers.keystier1";

	public const string IN_APP_TIER6_5 = "com.kiloo.subwaysurfers.keystier1.5";

	public const string IN_APP_TIER7 = "com.kiloo.subwaysurfers.keystier2";

	public const string IN_APP_TIER8 = "com.kiloo.subwaysurfers.keystier3";

	public const string IN_APP_TIER9 = "com.kiloo.subwaysurfers.keystier_4";

	public const string IN_APP_TIER1_DISCOUNT = "com.kiloo.subwaysurfers.coinstier1discount";

	public const string IN_APP_TIER2_DISCOUNT = "com.kiloo.subwaysurfers.coinstier2discount";

	public const string IN_APP_TIER2_5_DISCOUNT = "com.kiloo.subwaysurfers.coinstier2.5discount";

	public const string IN_APP_TIER3_DISCOUNT = "com.kiloo.subwaysurfers.coinstier3discount";

	public const string IN_APP_TIER4_DISCOUNT = "com.kiloo.subwaysurfers.coinstier4discount";

	public const string IN_APP_TIER5_DISCOUNT = "com.kiloo.subwaysurfers.coinstier5discount";

	public const string IN_APP_TIER6_DISCOUNT = "com.kiloo.subwaysurfers.keystier1discount";

	public const string IN_APP_TIER6_5_DISCOUNT = "com.kiloo.subwaysurfers.keystier1.5discount";

	public const string IN_APP_TIER7_DISCOUNT = "com.kiloo.subwaysurfers.keystier2discount";

	public const string IN_APP_TIER8_DISCOUNT = "com.kiloo.subwaysurfers.keystier3discount";

	public const string IN_APP_TIER9_DISCOUNT = "com.kiloo.subwaysurfers.keystier4discount";

	public const string IN_APP_TIER1_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier1specialdiscount";

	public const string IN_APP_TIER2_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier2specialdiscount";

	public const string IN_APP_TIER2_5_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier2.5specialdiscount";

	public const string IN_APP_TIER3_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier3specialdiscount";

	public const string IN_APP_TIER4_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier4specialdiscount";

	public const string IN_APP_TIER5_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier5specialdiscount";

	public const string IN_APP_TIER6_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier1specialdiscount";

	public const string IN_APP_TIER6_5_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier1.5specialdiscount";

	public const string IN_APP_TIER7_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier2specialdiscount";

	public const string IN_APP_TIER8_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier3specialdiscount";

	public const string IN_APP_TIER9_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier4specialdiscount";

	public const string IN_APP_DOUBLE_COINS = "com.kiloo.subwaysurfers.doublecoins";

	public const string IN_APP_DOUBLE_COINS_DISCOUNT = "com.kiloo.subwaysurfers.doublecoinsdiscount";

	public const string IN_APP_BUNDLE_TIER1 = "com.kiloo.subwaysurfers.bundletier1";

	public const string IN_APP_BUNDLE_TIER2 = "com.kiloo.subwaysurfers.bundletier2";

	public const string IN_APP_BUNDLE_TIER3 = "com.kiloo.subwaysurfers.bundletier3";

	public const string IN_APP_BUNDLE_TIER4 = "com.kiloo.subwaysurfers.bundletier4";

	public const string IN_APP_BUNDLE_TIER5 = "com.kiloo.subwaysurfers.bundletier5";

	public const string IN_APP_AD_REMOVAL_TIER1 = "com.kiloo.subwaysurfers.adremovaltier1";

	public const string IN_APP_AD_REMOVAL_TIER2 = "com.kiloo.subwaysurfers.adremovaltier2";

	public const string IN_APP_AD_REMOVAL_TIER3 = "com.kiloo.subwaysurfers.adremovaltier3";

	public const string IN_APP_AD_REMOVAL_TIER4 = "com.kiloo.subwaysurfers.adremovaltier4";

	public const string IN_APP_CAIRO_BOARD_BUNDLE_TIER1 = "com.kiloo.subwayboard.cairoBoard02.bundletier1";

	public const string IN_APP_CAIRO_BOARD_BUNDLE_TIER2 = "com.kiloo.subwayboard.cairoBoard02.bundletier2";

	public const string IN_APP_MUMBAI_BOARD_BUNDLE_TIER1 = "com.kiloo.subwayboard.mumbai.bundletier1";

	public const string IN_APP_MUMBAI_BOARD_BUNDLE_TIER2 = "com.kiloo.subwayboard.mumbai.bundletier2";

	public const string IN_APP_CHICK_BOARD_BUNDLE_TIER1 = "com.kiloo.subwayboard.chick.bundletier1";

	public const string IN_APP_CHICK_BOARD_BUNDLE_TIER2 = "com.kiloo.subwayboard.chick.bundletier2";

	public const string IN_APP_WELCOME_PACK_TIER1 = "com.kiloo.subwaysurfers.welcomePackTier01";

	public const string IN_APP_WELCOME_PACK_TIER2 = "com.kiloo.subwaysurfers.welcomePackTier02";

	private static readonly string[] IN_APP_CURRENCY_TIERS;

	private static readonly string[] IN_APP_CURRENCY_DISCOUNT_TIERS;

	private static readonly string[] IN_APP_CURRENCY_SPECIAL_DISCOUNT_TIERS;

	private static readonly string[] IN_APP_AD_REMOVAL_TIERS;

	private static readonly string[] IN_APP_BUNDLE_TIERS;

	private static readonly string[] IN_APP_BOARD_BUNDLE_TIERS;

	private static readonly string[] inAppSpecialBundles;

	private static readonly Dictionary<string, string> IN_APP_TIERS_ONLINE_SETTINGS_IDS;

	private static readonly Dictionary<string, string> IGNORED_IN_APP_TIERS_ONLINE_SETTINGS_IDS;

	public static readonly List<string> LIST_OF_MANAGED_INAPP_IDS;

	public static Dictionary<string, InAppItemModel> inAppData;

	public static int inAppPurchaseCount
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (int)inAppSpecialBundles;
		}
	}

	public static string commaSeparatedProductIds
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> dictionary = inAppData;
			return (string)(dictionary.count - dictionary.freeCount);
		}
	}

	static InAppData()
	{
	}

	public static string StripProductPrefixes(string productID)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [productID @ L0 (System.String)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3+50]");
		return ((LocalizedOnlineSettings)(object)productID).FetchOrDefault<string>((IDictionary<string, string>)0);
	}

	public static string GetBundleId(BundleTier tier)
	{
		//IL_00c0: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_008e: Expected I4, but got Obj
		//IL_008e: Expected I4, but got Obj
		//IL_008e: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = IN_APP_PREFIXES + 12;
		object obj3 = 0;
		string result = default;
		BundleTier bundleTier = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = IN_APP_PREFIXES + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			result = ((string)bundleTier).Remove((int)obj6, (int)string.Empty);
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
		return result;
	}

	public static string GetInAppOnlineSettingsId(string inAppId)
	{
		//IL_00a4: Expected Obj, but got I4
		object obj;
		if (inAppId != null)
		{
			if ((nint)inAppId != 1)
			{
				if ((nint)inAppId != 2)
				{
					if ((nint)inAppId != 3)
					{
						if ((nint)inAppId != 4)
						{
							if ((nint)inAppId == 5)
							{
								return "com.kiloo.subwaysurfers.bundletier5";
							}
							obj = inAppId;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							string text = default;
							string msg = "Bundle ID could not be found. BundleTier: " + text;
							SDebug.LogFormat(msg, null);
							return "TierNotFound";
						}
						return "com.kiloo.subwaysurfers.bundletier4";
					}
					return "com.kiloo.subwaysurfers.bundletier3";
				}
				return "com.kiloo.subwaysurfers.bundletier2";
			}
			return "com.kiloo.subwaysurfers.bundletier1";
		}
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string msg2 = "Bundle ID could not be found. BundleTier: " + text2;
		SDebug.LogFormat(msg2, null);
		return "TierNotFound";
	}

	public static string GetIgnoredInAppOnlineSettingsId(string inAppId)
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v18 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return IN_APP_TIERS_ONLINE_SETTINGS_IDS.get_Item(inAppId);
		}
		return null;
	}

	public static string GetDiscountIdForNormalOffer(string normalOffer)
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v18 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return IGNORED_IN_APP_TIERS_ONLINE_SETTINGS_IDS.get_Item(normalOffer);
		}
		return null;
	}

	public static string GetSpecialDiscountIdForNormalOffer(string normalOffer)
	{
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00ca: Expected I, but got Obj
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A215");
		object obj3 = default;
		object obj2 = obj3 + 12;
		object obj4 = default;
		object obj9 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj5 = obj3 + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			nint num3 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v40 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel inAppItemModel = inAppData.get_Item((string)obj7);
			if (!(inAppItemModel.normalOfferId != normalOffer))
			{
				obj4 = obj9 + 1;
				continue;
			}
			return (string)obj7;
		}
		return string.Empty;
	}

	public static string[] GetInAppBundleTiers()
	{
		bool flag = CooldownManager._instance == null;
		bool flag2 = !flag;
		CooldownManager result = CooldownManager._instance;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CooldownManager cooldownManager = default;
			cooldownManager.LoadAndParseFromOnlineSettings();
			CooldownManager._instance = cooldownManager;
			result = cooldownManager;
		}
		return (string[])(object)result;
	}

	public static string[] GetInAppBoardBundleTiers()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return IN_APP_BUNDLE_TIERS;
	}

	public static string[] GetInAppSpecialBundles()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return IN_APP_BOARD_BUNDLE_TIERS;
	}

	public static bool InappidIsDynamicLimitedCharacterPurchase(string inappId)
	{
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_01e8: Expected I4, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00ca: Expected I, but got Obj
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A217");
		object obj3 = default;
		object obj2 = obj3 + 12;
		object obj4 = default;
		object obj9 = default;
		string text;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object obj5 = obj3 + 16;
				object obj6 = obj4 << 2;
				object obj7 = obj5 + obj6;
				nint num3 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v40 (Il2CppClass<InApp.InAppData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				InAppItemModel inAppItemModel = inAppData.get_Item((string)obj7);
				if (!(inAppItemModel.normalOfferId != inappId))
				{
					obj4 = obj9 + 1;
					continue;
				}
				text = (string)obj7;
				break;
			}
			text = string.Empty;
			break;
		}
		return (byte)(int)text != 0;
	}

	public static bool InappidIsDynamicLimitedBoardPurchase(string inappId)
	{
		//IL_0017: Expected I4, but got Obj
		return (byte)(int)inappId.ToLower((CultureInfo)(object)"com.kiloo.subwaycharacter.") != 0;
	}

	public static string[] GetCurrencyTiers()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_029e: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_0319: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v14 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v67 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		string text = string.Empty;
		object obj7 = default;
		object obj8 = default;
		string text2 = default;
		object obj9 = default;
		string text3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			if ((nint)obj8 >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				text = text2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj8 = obj9 + 1;
			text = text3;
		}
		object obj10 = obj5 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj5 + obj12;
		obj13 = 88;
		string[] result = (string[])(object)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj5 + obj14;
			if ((nint)obj15 == 88)
			{
				object obj16 = obj5 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_03a8;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03a8;
		IL_03a8:
		return result;
	}

	public static string[] GetCurrencyDiscountTiers()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return IN_APP_CURRENCY_TIERS;
	}

	public static string[] GetCurrencySpecialDiscountTiers()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return IN_APP_CURRENCY_DISCOUNT_TIERS;
	}

	public static string[] GetAdRemovalTiers()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return IN_APP_CURRENCY_SPECIAL_DISCOUNT_TIERS;
	}

	public static string[] GetAllProductIds()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return IN_APP_AD_REMOVAL_TIERS;
	}

	public unsafe static bool TryConvertDynamicPurchaseIdToCharacterType(string purchaseId, out Characters.CharacterId charReturned)
	{
		//IL_018b: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got Ref
		//IL_0017: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_00be: Expected Obj, but got Ref
		//IL_00be: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got Ref
		//IL_0130: Expected Obj, but got I4
		//IL_0141: Expected I4, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			Cooldown cooldown = ((Dictionary<string, Cooldown>)purchaseId.m_firstChar).get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref charReturned));
			return (byte)(int)cooldown != 0;
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v8 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v9+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v10+44]");
		object obj9 = 0;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S3_v9 (should have been resolved before IL gen)");
		object obj12 = default;
		if ((nint)obj12 > -1)
		{
			Cooldown cooldown2 = ((Dictionary<string, Cooldown>)purchaseId.m_stringLength).get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref charReturned));
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v7 (Il2CppMethodInfo)+C]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v8+60]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v9+48]");
			object obj15 = 0;
			object obj16 = obj15 & 0x7FF;
			object obj17 = obj16 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S5_v5 (should have been resolved before IL gen)");
			Cooldown cooldown3 = ((Dictionary<string, Cooldown>)purchaseId.m_firstChar).get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref charReturned));
			return (byte)(int)cooldown3 != 0;
		}
		string msg = string.ConcatArray((string[])(object)"[Cooldown] Could not find: ", (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref charReturned));
		SDebug.LogFormat(msg, null);
		return false;
	}

	public static string ConvertCharacterTypeToDynamicPurchaseId(Characters.CharacterId charId)
	{
		//IL_0013: Expected Obj, but got I4
		return ((string)charId).ToLower((CultureInfo)(object)"com.kiloo.subwayboard.");
	}

	private static bool IsUsingCustomIapIdForCharacter(Characters.Model model)
	{
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_0160: Expected I4, but got Obj
		//IL_0172: Expected I, but got Obj
		//IL_0188: Expected Obj, but got I
		//IL_0131: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00dd: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ac: Expected I4, but got Obj
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v38 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model2 = Characters.characterData.get_Item((Characters.CharacterId)model);
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v34 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ConvertBoardTypeToDynamicPurchaseId((Boards.BoardId)model2);
		if (text != null)
		{
			return (byte)(int)model2.dynamicIapId != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text3 = default;
		string text2 = "com.kiloo.subwaycharacter." + text3;
		return (byte)(int)text2 != 0;
	}

	public static IEnumerable<InAppItemModel> GetAllWithItemAndOfferType(InAppItemModel.ItemType itemType, InAppItemModel.OfferType offerType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aec: Expected Obj, but got Unknown
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected Obj, but got Unknown
		//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b08: Expected Obj, but got Unknown
		//IL_0b11: Expected Obj, but got I4
		//IL_0b26: Expected Obj, but got I4
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Expected Obj, but got Unknown
		//IL_0b55: Expected I4, but got Obj
		//IL_0b55: Expected I4, but got Obj
		//IL_0b55: Expected Obj, but got I4
		//IL_0b67: Expected I, but got Obj
		//IL_0b7d: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00ed: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 8;
		object obj4 = obj2 + 32;
		object obj5 = obj2 + 48;
		obj5 = 0;
		_ = 0;
		_ = 0;
		obj2 = 0;
		object obj6 = obj2 + 40;
		obj6 = obj;
		_ = -1;
		string text = ((string)itemType).Remove((int)"com.kiloo.subwaycharacter.", (int)"");
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<System.Type>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v292 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		obj4 = typeof(Characters.CharacterId);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		nint num3 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v252 (Il2CppClass<System.Enum>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v276 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj10 = default;
		object obj9 = obj10;
		object obj12 = default;
		object obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj13 = default;
		if (obj11 == obj13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj15 = default;
			object obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj17 = default;
			object obj16 = obj17;
		}
		else
		{
			object obj16 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		IEnumerable<InAppItemModel> result = default;
		return result;
	}

	public static void PrintDynamicIdsForCharacterTypeForAllPlatforms(Characters.CharacterId characterId)
	{
		//IL_02d4: Expected Obj, but got I
		//IL_02e4: Expected Obj, but got I
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0355: Expected Obj, but got I
		//IL_0365: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01de: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02ab: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj7 = default;
		object obj6 = obj7 + 8;
		obj6 = "hoverboard";
		_ = 2;
		_ = 28800;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S4_v7+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S4_v8+48]");
		object obj10 = 0;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj14 = default;
		object obj13 = obj14 + 8;
		obj13 = "doublecoinsvideo";
		_ = -1;
		_ = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v12+60]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v13+48]");
		object obj17 = 0;
		object obj18 = obj17 & 0x7FF;
		object obj19 = obj18 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S5_v10 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj21 = default;
		object obj20 = obj21 + 8;
		obj20 = "coins";
		_ = 2;
		_ = 28800;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S4_v17+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S4_v18+48]");
		object obj24 = 0;
		object obj25 = obj24 & 0x7FF;
		object obj26 = obj25 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v118 @ S5_v14 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj28 = default;
		object obj27 = obj28 + 8;
		obj27 = "score_booster";
		_ = 2;
		_ = 28800;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S4_v22+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S4_v23+48]");
		object obj31 = 0;
		object obj32 = obj31 & 0x7FF;
		object obj33 = obj32 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v148 @ S5_v18 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj35 = default;
		object obj34 = obj35 + 8;
		obj34 = "headstart";
		_ = 2;
		_ = 28800;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S4_v27+60]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S4_v28+48]");
		object obj38 = 0;
		object obj39 = obj38 & 0x7FF;
		object obj40 = obj39 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v178 @ S5_v22 (should have been resolved before IL gen)");
		object obj41 = characterId + 8;
		object obj42 = default;
		obj41 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S3_v12 (Il2CppMethodInfo)+C]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S3_v13+60]");
		object obj44 = 0;
		object obj45 = obj44;
		object obj46 = obj45 & 0x1FFF;
		object obj47 = obj46 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v202 @ S4_v33 (should have been resolved before IL gen)");
		object obj48 = characterId + 12;
		object obj49 = default;
		obj48 = obj49;
	}

	public static bool TryConvertDynamicBoardIdToBoardType(string purchaseId, out Boards.BoardId boardReturned)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
		bool result = default;
		return result;
	}

	public static string ConvertBoardTypeToDynamicPurchaseId(Boards.BoardId boardId)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I4
		//IL_00de: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I4
		string dataPath = Application.dataPath;
		object obj = dataPath - 8;
		if ((nint)dataPath != 8)
		{
			if ((nint)obj == 1 || (nint)obj == 2 || (nint)obj != 3)
			{
				return null;
			}
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v27 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (DeviceUtility.GetIOSOtherAudioPlaying())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L0 (Info.Boards+BoardId)+42]");
				bool flag = (nint)0 != 0;
				return (string)flag;
			}
			object obj3 = boardId - -64;
			bool flag2 = obj3 != null;
			return (string)flag2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L0 (Info.Boards+BoardId)+41]");
		bool flag3 = (nint)0 != 0;
		return (string)flag3;
	}

	private static bool IsUsingCustomIapIdForBoard(Boards.Board board)
	{
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_0160: Expected I4, but got Obj
		//IL_0172: Expected I, but got Obj
		//IL_0188: Expected Obj, but got I
		//IL_0131: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00dd: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ac: Expected I4, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v38 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board2 = Boards.boardData.get_Item((Boards.BoardId)board);
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v34 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (InAppItemModel.GetItemTypeFromPowerup((UpgradeType)board2) != InAppItemModel.ItemType.Undefined)
		{
			return (byte)(int)board2.dynamicIapId != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "com.kiloo.subwayboard." + text2;
		return (byte)(int)text != 0;
	}

	public static void PrintDynamicIdsForBoardTypeForAllPlatforms(Boards.BoardId boardId)
	{
		//IL_01ae: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I
		//IL_0201: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_028d: Expected I4, but got Obj
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_02d8: Expected I4, but got Obj
		//IL_02ff: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v38 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)boardId);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v27 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string type = Strings.GetDefault(model.name);
		object obj3 = boardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "com.kiloo.subwaycharacter." + text2;
		object format = ((IConvertible)"iOS Id for ").ToType((Type)(object)type, (IFormatProvider)(object)": {0}");
		object[] args = (object[])(object)((~(model.overrideDynamicIapIdiOS ? 1u : 0u) != 0) ? text : model.dynamicIapId);
		string text3 = string.Format((string)format, args);
		StringBuilder stringBuilder2 = stringBuilder.Append((char)(int)text3);
		object format2 = ((IConvertible)"Android Id for ").ToType((Type)(object)type, (IFormatProvider)(object)": {0}");
		object obj4 = model - -64;
		string text4 = ((obj4 == null) ? text : model.dynamicIapId);
		string args2 = text4.ToLowerInvariant();
		string text5 = string.Format((string)format2, (object[])(object)args2);
		StringBuilder stringBuilder3 = stringBuilder.Append((char)(int)text5);
		object format3 = ((IConvertible)"Kindle Id for ").ToType((Type)(object)type, (IFormatProvider)(object)": {0}");
		object[] args3 = (object[])(object)((~(model.overrideDynamicIapIdKindle ? 1u : 0u) != 0) ? text : model.dynamicIapId);
		string text6 = string.Format((string)format3, args3);
		StringBuilder stringBuilder4 = stringBuilder.Append((char)(int)text6);
	}

	public static string OutputAllInapps()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0269: Expected Obj, but got I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_02a6: Expected I, but got Obj
		//IL_02bc: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v104 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj8 = obj5 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj5 + obj10;
		obj11 = 65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj5 + obj12;
			if ((nint)obj13 == 65)
			{
				object obj14 = obj5 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0374;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0374;
		IL_0374:
		return (string)(object)list.ToArray();
	}
}
