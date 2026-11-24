using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Data.Managers;
using Data.Migration;
using Data.Save;
using InAppPurchase;
using InAppPurchase.Internal;
using Info;
using Info.VideoRewardCooldowns;
using Ionic.Zlib;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Serialization;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using SYBO.Subway.Level;
using SYBO.Subway.Level.Environments;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using UI;
using UI.Screens;
using UI.SlideIns;
using UnityEngine;

namespace InApp;

public class InAppManager : MonoBehaviour, IInAppManager
{
	public delegate void OnProductRequestDone();

	public delegate void OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult);

	public delegate void OnPurchaseFailure(string productId, PurchaseResult result);

	public delegate void OnPurchaseCanceled(string productId, PurchaseResult result);

	public delegate void OnPurchaseItemNotAvailable(string productId, PurchaseResult result);

	public delegate void OnInitializeFinished(bool success);

	public delegate void OnItemRestored(string productId);

	public delegate void OnItemRestoreFinished(RestoreFinishedResult result);

	public delegate void OnItemRefunded(string productId);

	public delegate void OnValidatedItemRestored();

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<InAppItemModel.BundleItem> _003C_003E9__96_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cooldowns._003C_003Ec obj = default;
			Cooldowns._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003CGetBoardItemFromBundleId_003Eb__96_0(InAppItemModel.BundleItem item)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
	}

	private const string ONLINESETTINGS_IAP_VALIDATION_URL_KEY = "iap_validation_url";

	private const string DEFAULT_IAP_VALIDATION_URL = "https://purchasevalidation.kiloo-games.com/";

	private const string ONLINESETTINGS_IAP_VALIDATION_ENABLED = "iap_validation_enabled";

	private const string ONLINESETTINGS_DISCOUNT_END_TIME_KEY = "discount_end_time";

	private const double DEFAULT_DISCOUNT_END_TIME = 0.0;

	private const bool DEFAULT_IAP_VALIDATION_ENABLED = true;

	private const string ONLINESETTINGS_DISCOUNT_SPECIAL_SALE_WINTER_HOLIDAY_ACTIVE = "winter_holiday_sale_active";

	private const string ONLINESETTINGS_DISCOUNT_SPECIAL_SALE_NEW_YEAR_ACTIVE = "new_year_sale_active";

	private const bool DEFAULT_DISCOUNT_SPECIAL_SALE_ACTIVE = false;

	private static readonly Dictionary<string, int> _debugDiscount;

	private OnProductRequestDone m_onProductRequestDone;

	private OnPurchaseSuccess m_onPurchaseSuccess;

	private OnPurchaseFailure m_onPurchaseFailure;

	private OnPurchaseCanceled m_onPurchaseCanceled;

	private OnPurchaseItemNotAvailable m_onPurchaseItemNotAvailable;

	private OnItemRestored m_onItemRestored;

	private OnValidatedItemRestored m_onValidatedItemRestored;

	private OnItemRefunded m_onItemRefunded;

	private OnItemRestoreFinished m_onItemRestoreFinished;

	private static OnInitializeFinished m_onInitializeFinished;

	private static InAppManager _instance;

	private static PurchaseHandler _purchaseHandler;

	private string _itemRequested;

	private string _inAppPurchaseKey;

	private bool _productRequestSucceeded;

	private static bool _isRestoredManually;

	private const string GAME_OBJECT_NAME = "InAppManager";

	private InAppManagerPopupData _popupData;

	[NonSerialized]
	public AudioClip purchaseSuccessSound;

	private IPurchaseValidationServer _purchaseValidationServer;

	private IPurchaseValidationServer _simulatedPurchaseValidationServer;

	private static bool _hasSuccessfullyInitialized;

	private static bool _applicationIsQuiting;

	private bool _isQueryingProductInfo;

	private static readonly int[] SEGMENT_78S9H5S6D78;

	private static readonly int[] SEGMENT_8865FHJ76FG;

	private static readonly int[] SEGMENT_8907SDFGF56;

	private static readonly int[] SEGMENT_0A8ASDF7EWF;

	private static readonly int[] SEGMENT_5S678DF5G6S;

	public string itemRequested => $"currencyItemModel:itemId->{(object[])(object)this.m_onPurchaseSuccess}";

	public static bool isInitialized
	{
		get
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
			StringBuilder sb = default;
			System.Text.StringBuilderCache.Release(sb);
			nint num = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v24 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v105 (Il2CppClass<InApp.InAppData>)+74]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			}
			object obj8 = obj5 + 4;
			object obj9 = obj8 + 1;
			obj8 = obj9;
			object obj10 = obj9 << 2;
			object obj11 = obj5 + obj10;
			obj11 = 71;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj12 = (nint)0 << 2;
				object obj13 = obj5 + obj12;
				if ((nint)obj13 == 71)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool result = default;
			return result;
		}
	}

	public static InAppManager instance
	{
		get
		{
			//IL_0145: Expected I, but got Obj
			//IL_015b: Expected Obj, but got I
			//IL_01a6: Expected I, but got Obj
			//IL_01bc: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0193: Expected Obj, but got I4
			//IL_00ee: Expected I, but got Obj
			nint num = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_instance).FindKernel((string)null) != 0)
			{
				nint num5 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool hasSuccessfullyInitialized = _hasSuccessfullyInitialized;
				return (InAppManager)hasSuccessfullyInitialized;
			}
			return null;
		}
	}

	public static bool IsAnyDiscountAvailable
	{
		get
		{
			//IL_08b2: Expected Obj, but got I
			//IL_08c2: Expected Obj, but got I
			//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d8: Expected Obj, but got Unknown
			//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e6: Expected Obj, but got Unknown
			//IL_08fe: Expected I, but got Obj
			//IL_0914: Expected Obj, but got I
			//IL_0944: Unknown result type (might be due to invalid IL or missing references)
			//IL_0949: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			//IL_0089: Expected I, but got Obj
			//IL_009f: Expected Obj, but got I
			//IL_00ca: Expected I, but got Obj
			//IL_0e02: Expected I, but got Obj
			//IL_0e18: Expected Obj, but got I
			//IL_09c9: Expected I4, but got Obj
			//IL_09c9: Expected I4, but got Obj
			//IL_013e: Expected I4, but got Obj
			//IL_0150: Expected I, but got Obj
			//IL_0166: Expected Obj, but got I
			//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8f: Expected Obj, but got Unknown
			//IL_01de: Expected I, but got Obj
			//IL_022b: Expected I, but got Obj
			//IL_0241: Expected Obj, but got I
			//IL_0191: Expected I, but got Obj
			//IL_026c: Expected I, but got Obj
			//IL_0e43: Expected I, but got Obj
			//IL_0e59: Expected Obj, but got I
			//IL_0a85: Expected I, but got Obj
			//IL_0a9b: Expected Obj, but got I
			//IL_02e0: Expected I4, but got Obj
			//IL_02f2: Expected I, but got Obj
			//IL_0308: Expected Obj, but got I
			//IL_0380: Expected I, but got Obj
			//IL_0af8: Expected Obj, but got I
			//IL_0b08: Expected Obj, but got I
			//IL_0b18: Expected Obj, but got I
			//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b26: Expected Obj, but got Unknown
			//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b34: Expected Obj, but got Unknown
			//IL_03cd: Expected I, but got Obj
			//IL_0333: Expected I, but got Obj
			//IL_041a: Expected I, but got Obj
			//IL_0430: Expected Obj, but got I
			//IL_045b: Expected I, but got Obj
			//IL_04a8: Expected I, but got Obj
			//IL_04be: Expected Obj, but got I
			//IL_0b7e: Expected I, but got Obj
			//IL_0b94: Expected Obj, but got I
			//IL_04e9: Expected I, but got Obj
			//IL_05e4: Expected I, but got Obj
			//IL_05fa: Expected Obj, but got I
			//IL_05b1: Expected I, but got Obj
			//IL_0bd1: Expected Obj, but got I4
			//IL_0c15: Expected I, but got Obj
			//IL_0c2b: Expected Obj, but got I
			//IL_055a: Expected I, but got Obj
			//IL_0625: Expected I, but got Obj
			//IL_0658: Expected I, but got Obj
			//IL_0693: Expected Obj, but got I
			//IL_06a3: Expected Obj, but got I
			//IL_06b3: Expected Obj, but got I
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Expected Obj, but got Unknown
			//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cf: Expected Obj, but got Unknown
			//IL_0d17: Expected Obj, but got I
			//IL_0d38: Expected Obj, but got I
			//IL_0d48: Expected Obj, but got I
			//IL_0d58: Expected Obj, but got I
			//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d66: Expected Obj, but got Unknown
			//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d74: Expected Obj, but got Unknown
			//IL_0713: Expected I4, but got Obj
			//IL_0725: Expected I, but got Obj
			//IL_073b: Expected Obj, but got I
			//IL_0cb4: Expected Obj, but got I
			//IL_0cc4: Expected Obj, but got I
			//IL_0cd4: Expected Obj, but got I
			//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce2: Expected Obj, but got Unknown
			//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf0: Expected Obj, but got Unknown
			//IL_0766: Expected I, but got Obj
			//IL_07f3: Expected Obj, but got I
			//IL_0827: Expected I, but got Obj
			//IL_083d: Expected Obj, but got I
			//IL_0da6: Expected Obj, but got I
			//IL_0db6: Expected Obj, but got I
			//IL_0dc6: Expected Obj, but got I
			//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd4: Expected Obj, but got Unknown
			//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de2: Expected Obj, but got Unknown
			//IL_0868: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S4_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S4_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S5_v6 (should have been resolved before IL gen)");
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v11 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num3 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v110 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A264");
			object obj8 = default;
			object obj9 = default;
			object obj44 = default;
			string text9 = default;
			for (object obj7 = obj8 + 12; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7); obj9 = obj44 + 1)
			{
				object obj10 = obj8 + 16;
				object obj11 = obj9 << 2;
				object obj12 = obj10 + obj11;
				nint num4 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v15 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num5 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v198 (Il2CppClass<InApp.InAppData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string discountIdForNormalOffer = InAppData.GetDiscountIdForNormalOffer((string)obj12);
				bool flag = discountIdForNormalOffer == null || discountIdForNormalOffer.m_stringLength == 0;
				bool flag2 = !flag;
				string text = discountIdForNormalOffer;
				if (!flag2)
				{
					string text2 = string.ConcatArray((string[])(object)"could not find an ignored inApp id for the pricepont: ", (int)obj12);
					nint num6 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v101 (Il2CppClass<InApp.InAppManager>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num7 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v106 (Il2CppClass<InApp.InAppManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
					text = string.Empty;
				}
				nint num8 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v24 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num9 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v183 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath = OnlineSettings.GetSaveDataPath();
				Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)text);
				if (outfitForCharacter != null)
				{
					continue;
				}
				nint num10 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v36 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num11 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v179 (Il2CppClass<InApp.InAppData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string ignoredInAppOnlineSettingsId = InAppData.GetIgnoredInAppOnlineSettingsId((string)obj12);
				bool flag3 = ignoredInAppOnlineSettingsId == null || ignoredInAppOnlineSettingsId.m_stringLength == 0;
				bool flag4 = !flag3;
				string text3 = ignoredInAppOnlineSettingsId;
				if (!flag4)
				{
					string text4 = string.ConcatArray((string[])(object)"could not find a discout id for the pricepont: ", (int)obj12);
					nint num12 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S1_v90 (Il2CppClass<InApp.InAppManager>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num13 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S1_v95 (Il2CppClass<InApp.InAppManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
					text3 = string.Empty;
				}
				nint num14 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v45 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num15 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v162 (Il2CppClass<InApp.InAppData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				InAppItemModel inAppItemModel = InAppData.inAppData.get_Item((string)obj12);
				string text5 = inAppItemModel.ToString();
				nint num16 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v55 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num17 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v158 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string contactingStoreOverlayText = ((InAppManager)(object)text3).GetContactingStoreOverlayText();
				if (contactingStoreOverlayText != null)
				{
					nint num18 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v65 (Il2CppClass<InApp.InAppManager>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num19 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S0_v154 (Il2CppClass<InApp.InAppManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (IsDoubleCoinsDiscountActive)
					{
						nint num20 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v72 (Il2CppClass<InApp.InAppManager>)+BA]");
						object obj21 = (nint)0 & (nint)0x200;
						if (obj21 != null)
						{
							nint num21 = (nint)typeof(InAppManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v150 (Il2CppClass<InApp.InAppManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool isWinterHolidaySpecialSaleActive = IsWinterHolidaySpecialSaleActive;
						nint num22 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S1_v42 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						bool flag5 = obj22 == null;
						string key;
						if (isWinterHolidaySpecialSaleActive)
						{
							if (!flag5)
							{
								nint num23 = (nint)typeof(InAppData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v147 (Il2CppClass<InApp.InAppData>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag6 = InAppData.InappidIsDynamicLimitedCharacterPurchase((string)obj12);
							key = (string)flag6;
						}
						else
						{
							if (!flag5)
							{
								nint num24 = (nint)typeof(InAppData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v139 (Il2CppClass<InApp.InAppData>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							key = InAppData.GetSpecialDiscountIdForNormalOffer((string)obj12);
						}
						nint num25 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v80 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj23 = (nint)0 & (nint)0x200;
						if (obj23 != null)
						{
							nint num26 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v129 (Il2CppClass<InApp.InAppData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item(key);
						string text6 = inAppItemModel2.ToString();
						nint num27 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v90 (Il2CppClass<InApp.InAppManager>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num28 = (nint)typeof(InAppManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S0_v126 (Il2CppClass<InApp.InAppManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag7 = TryAddTransactionToHistory(text3, null);
						if ((flag7 ? 1 : 0) <= -1)
						{
							nint num29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S4_v29 (Il2CppMethodInfo)+C]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S4_v30+60]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S4_v31+48]");
							obj3 = 0;
							object obj27 = obj3 & 0x7FF;
							obj5 = obj27 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S5_v6 (should have been resolved before IL gen)");
							continue;
						}
						if (!flag7)
						{
							string text7 = string.ConcatArray((string[])(object)"Invalid discount value for item: ", (int)obj12);
							nint num30 = (nint)typeof(InAppManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S1_v76 (Il2CppClass<InApp.InAppManager>)+BA]");
							object obj28 = (nint)0 & (nint)0x200;
							if (obj28 != null)
							{
								nint num31 = (nint)typeof(InAppManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S1_v82 (Il2CppClass<InApp.InAppManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
							nint num32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S4_v24 (Il2CppMethodInfo)+C]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S4_v25+60]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S4_v26+48]");
							obj3 = 0;
							object obj31 = obj3 & 0x7FF;
							obj5 = obj31 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S5_v6 (should have been resolved before IL gen)");
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v88 (System.String)+28]");
						if ((nint)0 != 6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v88 (System.String)+28]");
							if ((nint)0 != 5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v88 (System.String)+28]");
								object obj32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								string text8 = "Invalid item type: " + text9 + ". No sales are implemented for this item type.";
								nint num33 = (nint)typeof(InAppManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S1_v65 (Il2CppClass<InApp.InAppManager>)+BA]");
								object obj33 = (nint)0 & (nint)0x200;
								if (obj33 != null)
								{
									nint num34 = (nint)typeof(InAppManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S1_v71 (Il2CppClass<InApp.InAppManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
								nint num35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S4_v19 (Il2CppMethodInfo)+C]");
								object obj34 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S4_v20+60]");
								object obj35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S4_v21+48]");
								obj3 = 0;
								object obj36 = obj3 & 0x7FF;
								obj5 = obj36 + 39195;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S5_v6 (should have been resolved before IL gen)");
								continue;
							}
						}
						bool flag8 = flag7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v88 (System.String)+14]");
						object obj37 = (nint)(flag8 ? 1 : 0) + (nint)0;
						_ = 2;
						nint num36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S4_v14 (Il2CppMethodInfo)+C]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S4_v15+60]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S4_v16+48]");
						obj3 = 0;
						object obj40 = obj3 & 0x7FF;
						obj5 = obj40 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S5_v6 (should have been resolved before IL gen)");
						continue;
					}
				}
				nint num37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S4_v9 (Il2CppMethodInfo)+C]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S4_v10+60]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S4_v11+48]");
				obj3 = 0;
				object obj43 = obj3 & 0x7FF;
				obj5 = obj43 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S5_v6 (should have been resolved before IL gen)");
			}
			bool result = default;
			return result;
		}
	}

	public static bool IsDoubleCoinsDiscountActive
	{
		get
		{
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected Obj, but got Unknown
			//IL_0100: Expected Obj, but got I4
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected Obj, but got Unknown
			//IL_0117: Expected Obj, but got I4
			//IL_0125: Expected I, but got Obj
			//IL_013b: Expected Obj, but got I
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Expected Obj, but got Unknown
			//IL_01f5: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 32;
			obj = 0;
			object obj3 = obj2 + 24;
			obj3 = 0;
			nint num = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v47 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A292");
			object obj5 = obj2 + 16;
			obj5 = 0;
			throw new ArrayTypeMismatchException();
		}
	}

	public static bool IsAnyCurrencyDiscountActive
	{
		get
		{
			//IL_0273: Expected I, but got Obj
			//IL_0289: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_02e4: Expected I, but got Obj
			//IL_02fa: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			//IL_017c: Expected I, but got Obj
			//IL_01c9: Expected I, but got Obj
			//IL_01df: Expected Obj, but got I
			//IL_020a: Expected I, but got Obj
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v59 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
			if (hasCharacterBeenSeen == null)
			{
				nint num3 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v16 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v55 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (IsDoubleCoinsDiscountActive)
				{
					nint num5 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v24 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v51 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string ignoredInAppOnlineSettingsId = InAppData.GetIgnoredInAppOnlineSettingsId("com.kiloo.subwaysurfers.doublecoins");
					nint num7 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v9 (Il2CppClass<InApp.InAppManager>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v18 (Il2CppClass<InApp.InAppManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = TryAddTransactionToHistory(ignoredInAppOnlineSettingsId, null);
					if ((flag ? 1 : 0) < (false ? 1 : 0))
					{
						nint num9 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v34 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num10 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v45 (Il2CppClass<InApp.InAppData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						InAppItemModel inAppItemModel = InAppData.inAppData.get_Item("com.kiloo.subwaysurfers.doublecoinsdiscount");
						if (~(inAppItemModel.isValidated ? 1u : 0u) == 0)
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}

	public static bool IsSpecialSaleActive
	{
		get
		{
			//IL_0309: Expected I, but got Obj
			//IL_031f: Expected Obj, but got I
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Expected Obj, but got Unknown
			//IL_044d: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected Obj, but got Unknown
			//IL_0097: Expected I, but got Obj
			//IL_00ad: Expected Obj, but got I
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Expected Obj, but got Unknown
			//IL_00d8: Expected I, but got Obj
			//IL_0125: Expected I, but got Obj
			//IL_013b: Expected Obj, but got I
			//IL_0166: Expected I, but got Obj
			//IL_01da: Expected I, but got Obj
			//IL_01f0: Expected Obj, but got I
			//IL_021b: Expected I, but got Obj
			//IL_0268: Expected I, but got Obj
			//IL_027e: Expected Obj, but got I
			//IL_02a9: Expected I, but got Obj
			nint num = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v84 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A264");
			object obj3 = default;
			object obj2 = obj3 + 12;
			object obj4 = 0;
			while (true)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
				{
					return false;
				}
				object obj5 = obj3 + 16;
				object obj6 = obj4 << 2;
				object obj7 = obj5 + obj6;
				nint num3 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v24 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v79 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (IsDoubleCoinsDiscountActive)
				{
					nint num5 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v34 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num6 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v75 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string ignoredInAppOnlineSettingsId = InAppData.GetIgnoredInAppOnlineSettingsId((string)obj7);
					if (ignoredInAppOnlineSettingsId != null && ignoredInAppOnlineSettingsId.m_stringLength != 0)
					{
						nint num7 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v43 (Il2CppClass<InApp.InAppManager>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num8 = (nint)typeof(InAppManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v67 (Il2CppClass<InApp.InAppManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string contactingStoreOverlayText = ((InAppManager)(object)ignoredInAppOnlineSettingsId).GetContactingStoreOverlayText();
						if (contactingStoreOverlayText != null)
						{
							nint num9 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v50 (Il2CppClass<InApp.InAppData>)+BA]");
							object obj11 = (nint)0 & (nint)0x200;
							if (obj11 != null)
							{
								nint num10 = (nint)typeof(InAppData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v63 (Il2CppClass<InApp.InAppData>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string specialDiscountIdForNormalOffer = InAppData.GetSpecialDiscountIdForNormalOffer((string)obj7);
							InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(specialDiscountIdForNormalOffer);
							if (~(inAppItemModel.isValidated ? 1u : 0u) == 0)
							{
								break;
							}
						}
					}
				}
				object obj12 = obj4 + 1;
				obj4 = obj12;
			}
			return true;
		}
	}

	public static bool IsWinterHolidaySpecialSaleActive
	{
		get
		{
			//IL_0101: Expected I, but got Obj
			//IL_0117: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00af: Expected I, but got Obj
			nint num = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (IsNewYearSpecialSaleActive)
			{
				return true;
			}
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return AdsSave.behavioralAdsAllowed;
		}
	}

	public unsafe static bool IsNewYearSpecialSaleActive
	{
		get
		{
			//IL_0173: Expected I, but got Obj
			//IL_0189: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_01fd: Expected Obj, but got I
			//IL_01b4: Expected I, but got Obj
			//IL_01ca: Expected Obj, but got I
			//IL_00bd: Expected I, but got Obj
			//IL_00ed: Expected I, but got Obj
			//IL_025f: Expected Obj, but got I4
			//IL_0126: Expected I, but got Obj
			//IL_0113: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			bool flag;
			if (((OnlineSettings)(object)saveDataPath).TryGetValue("winter_holiday_sale_active", out *(string*)null))
			{
				flag = true;
			}
			else
			{
				nint num3 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<Globals>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag2 = obj2 == null;
				nint num4 = (nint)typeof(Globals);
				if (!flag2)
				{
					nint num5 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26 (Il2CppClass<Globals>)+74]");
					bool flag3 = (nint)0 == 0;
					bool flag4 = !flag3;
					num4 = (nint)typeof(Globals);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Globals);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ L0_v4 (Il2CppClass<Globals>)+5C]");
				object obj3 = -(-64);
				flag = obj3 != null;
			}
			nint num6 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v7 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isDoubleCoinsDiscountActive = IsDoubleCoinsDiscountActive;
			object obj5 = flag & isDoubleCoinsDiscountActive;
			return obj5 != null;
		}
	}

	public event OnProductRequestDone onProductRequestDone
	{
		add
		{
			//IL_0010: Expected I4, but got Obj
			string msg = string.ConcatArray((string[])(object)"[InAppItemModel] ", (int)this);
			SDebug.LogFormat(msg, (object[])(object)value);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onProductRequestDone;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event OnPurchaseSuccess onPurchaseSuccess
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onProductRequestDone;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPurchaseSuccess;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event OnPurchaseFailure onPurchaseFailure
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPurchaseSuccess;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPurchaseFailure;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event OnPurchaseCanceled onPurchaseCanceled
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPurchaseFailure;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPurchaseCanceled;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event OnPurchaseItemNotAvailable onPurchaseItemNotAvailable
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPurchaseCanceled;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPurchaseItemNotAvailable;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event OnItemRestored onItemRestored
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPurchaseItemNotAvailable;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onItemRestored;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event OnValidatedItemRestored onValidatedItemRestored
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onItemRestored;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onValidatedItemRestored;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 36;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event OnItemRefunded onItemRefunded
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onValidatedItemRestored;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 36;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onItemRefunded;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event OnItemRestoreFinished onItemRestoreFinished
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onItemRefunded;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onItemRestoreFinished;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 44;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event OnInitializeFinished onInitializeFinished
	{
		add
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			object obj = value + 8;
			obj = string.Empty;
			object obj2 = value + 12;
			obj2 = string.Empty;
			object obj3 = value + 16;
			obj3 = string.Empty;
			object obj4 = value + 28;
			obj4 = string.Empty;
			object obj5 = value + 32;
			obj5 = string.Empty;
			object obj6 = value + 48;
			obj6 = string.Empty;
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = InAppManager.m_onInitializeFinished;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(InAppManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<InApp.InAppManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(InAppManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(InAppManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<InApp.InAppManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	private InAppManager()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = InAppManager.m_onInitializeFinished;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(InAppManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<InApp.InAppManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(InAppManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(InAppManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<InApp.InAppManager>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	public static void Init()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_4f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f78: Expected Obj, but got Unknown
		//IL_4f81: Expected Obj, but got I4
		//IL_4f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f95: Expected Obj, but got Unknown
		//IL_4f9e: Expected Obj, but got I4
		//IL_4fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fb2: Expected Obj, but got Unknown
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private unsafe void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_040c: Expected I, but got Obj
		//IL_0422: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0494: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object obj3 = this + 48;
		obj3 = string.Empty;
		object obj4 = this + 52;
		obj4 = string.Empty;
		CancelInvoke();
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v219 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		if (!((OnlineSettings)(object)saveDataPath).TryGetValue("iap_validation_enabled", out *(string*)1))
		{
			return;
		}
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v215 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		bool value = ((OnlineSettings)(object)saveDataPath2).GetValue("iap_validation_url", (byte)(int)"https://purchasevalidation.kiloo-games.com/" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj8 = default;
		object obj7 = obj8;
		object obj10 = default;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj11 = default;
		if (obj9 == obj11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj13 = default;
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj15 = default;
			object obj14 = obj15;
		}
		else
		{
			object obj14 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void OnApplicationQuit()
	{
		//IL_01f4: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_016e: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_0266: Expected I4, but got Obj
		//IL_0266: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_018a: Expected I, but got Obj
		//IL_01ba: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_01e0: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v41 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_instance).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DontDestroyOnLoad(this);
			return;
		}
		nint num7 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v16 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag = obj4 == null;
		nint num8 = (nint)typeof(InAppManager);
		if (!flag)
		{
			nint num9 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v25 (Il2CppClass<InApp.InAppManager>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num8 = (nint)typeof(InAppManager);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num8 = (nint)typeof(InAppManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ L1_v6 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj5 = (nint)0 + (nint)8;
		obj5 = this;
		bool isValidationSupportedOnCurrentPlatform = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
		((InAppPurchaseProvider)isValidationSupportedOnCurrentPlatform).ProductInfoRequestCallback((byte)(int)this != 0, (ProductRequestResultInfo[])(object)_purchaseValidationServer);
	}

	public void RequestIAPInfo()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_applicationIsQuiting = true;
		nint num3 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj2 = (nint)0 + (nint)8;
		obj2 = 0;
	}

	public void StartPurchase(string productId)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_onItemRestoreFinished;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)productId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 44;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public unsafe bool RestoreNonConsumablePurchases(string[] productIds, bool calledManually = true)
	{
		//IL_0018: Expected Obj, but got I
		return ((Dictionary<string, string>)(nint)((UnityEngine.Object)this).m_CachedPtr).TryGetValue((string)(object)productIds, out *(calledManually ? ((string*)1) : ((string*)null)));
	}

	public bool ProductRequestSucceeded()
	{
		//IL_0007: Expected I4, but got Obj
		return (byte)(int)_itemRequested != 0;
	}

	public void InitFinishedCallback(bool success)
	{
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I4
		//IL_0282: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0237: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_014c: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I4
		//IL_0309: Expected I, but got Obj
		//IL_031f: Expected Obj, but got I
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_035c: Expected I4, but got Obj
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_03a7: Expected Obj, but got I4
		//IL_00be: Expected I, but got Obj
		//IL_01da: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = success;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Globals>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v55 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_FREE_INAPP_PURCHASE ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			NativePurchaseFinished(success: false);
			if (_simulatedPurchaseValidationServer == null)
			{
				object obj5 = this + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj6 = default;
				obj5 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			int num4 = default;
			object obj7 = num4 + 16;
			obj7 = obj2;
			nint num5 = (nint)typeof(PurchaseValidationExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S2_v17 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(PurchaseValidationExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v23 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IPurchaseValidationServer simulatedPurchaseValidationServer = _simulatedPurchaseValidationServer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			((DeflateManager)(object)simulatedPurchaseValidationServer).send_all_trees(0, (int)"DummyPurchaseReceipt", num4);
			return;
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Il2CppClass<UIScreenController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController != null)
		{
			nint num9 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num10 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			InAppManagerPopupData popupData = ((InAppManager)null).GetPopupData();
			((UIScreenController)flag).OnOverlayManuallyClosed += (Action)(object)popupData;
		}
		bool isValidationSupportedOnCurrentPlatform = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
		bool flag2 = isValidationSupportedOnCurrentPlatform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		bool flag3 = ((InAppPurchaseProvider)flag2).RestoreNonConsumablePurchases((string[])0);
	}

	public string getInAppAPIKey()
	{
		//IL_0019: Expected Obj, but got I4
		bool productRequestSucceeded = _productRequestSucceeded;
		return (string)productRequestSucceeded;
	}

	private unsafe void AddSegment(StringBuilder sb, int[] section)
	{
		//IL_01d4: Expected I, but got Obj
		//IL_01ea: Expected Obj, but got I
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected VT, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_026c: Expected I, but got Obj
		//IL_0282: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_02cc: Expected F4, but got Obj
		//IL_02c7: Expected native int or pointer, but got VT
		//IL_02e1: Expected F4, but got I
		//IL_02dc: Expected native int or pointer, but got VT
		//IL_02ff: Expected F4, but got Obj
		//IL_02fa: Expected native int or pointer, but got VT
		//IL_0314: Expected F4, but got I
		//IL_030f: Expected native int or pointer, but got VT
		//IL_031d: Expected Obj, but got VT
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Vector3 vector = (Vector3)(obj2 + 24);
		object obj3 = obj2 + 12;
		if ((UnityEngine.Object)(object)sb != null)
		{
			return;
		}
		nint num3 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v61 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool((Transform)(object)sb);
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v57 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 back = Vector3.back;
		nint num7 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v36 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v53 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		float num9 = (float)section;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v14 (System.Boolean)+10]");
		float num10 = num9 - 0f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = vector / num10;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 localPosition = ((Transform)vector).localPosition;
		GameObject parentInternal = gameObject;
		((Transform)(object)prefabPool).parentInternal = (Transform)(object)parentInternal;
		bool isRestricted2 = AgeRestriction.isRestricted;
		((GamePositionRoot)isRestricted2).RemoveOffsetTransform((Transform)(object)prefabPool);
		((Queue<Transform>)(object)this.m_onPurchaseFailure).Enqueue((Transform)(object)prefabPool);
	}

	public IsIAPConsumableValue IsProductConsumable(string productID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_026a: Expected Obj, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected I, but got Unknown
		//IL_0286: Expected I, but got Obj
		//IL_0383: Expected I4, but got Obj
		//IL_02cc: Expected Obj, but got I
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_00e6: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		nint num = (nint)(obj2 + 16);
		num = (nint)obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<int> list = default;
		list._002Ector();
		if (this.m_onValidatedItemRestored != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj4 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj4 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v76+11]");
				if ((nint)0 == 0)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num2 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v88 (Il2CppClass<HoverboardThemes>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v103 (Il2CppClass<HoverboardThemes>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj6 = num + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = num + obj8;
			obj9 = 87;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppMethodInfo)+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppMethodInfo)+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = num + obj10;
				if ((nint)obj11 == 87)
				{
					object obj12 = num + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					goto IL_037e;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_037e;
		IL_037e:
		return (IsIAPConsumableValue)list;
	}

	public void ProductInfoRequestCallback(bool success, ProductRequestResultInfo[] productInfo)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_00e2: Expected I4, but got Obj
		//IL_00f3: Expected Obj, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_007d: Expected I, but got Obj
		object obj = productInfo + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = productInfo + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v16 (Il2CppClass<System.Convert>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			char value = Convert.ToChar((uint)(int)obj5);
			StringBuilder stringBuilder = ((StringBuilder)success).Append((int)value);
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
	}

	public void PurchaseRequestCallback(string productId, string transactionId, string transactionIdBase64, string cookie, PurchaseResult result, IPurchaseValidationResult validationResult)
	{
		//IL_00df: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_00bf: Expected I4, but got Obj
		//IL_00bf: Expected I4, but got Obj
		//IL_00bf: Expected I4, but got Obj
		if (validationResult == null)
		{
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v16 (System.String)+A0]");
			object obj = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v16 (System.String)+A4]");
			object obj2 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InApp.InAppManager)+1D8]");
		if (!((Game)0).IsInPogostickMode)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InApp.InAppManager)+1D8]");
			if (!((Game)0).HasSuperSneakers)
			{
				((CharacterFXController)this).Character_OnStumble((Character.StumbleType)productId, (Character.StumbleHorizontalHit)transactionId, (Character.StumbleVerticalHit)transactionIdBase64, cookie, (byte)result != 0);
				((Character)this).NotifyOnCriticalHit((Character.CriticalHitType)result);
			}
		}
	}

	public unsafe void ItemRestoredCallback(string productId, string transactionId, string cookie)
	{
		//IL_0491: Expected Obj, but got I4
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00d6: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I
		//IL_0532: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I
		//IL_0551: Expected Obj, but got I4
		//IL_0117: Expected I, but got Obj
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I
		//IL_01b4: Expected I, but got Obj
		//IL_01ca: Expected Obj, but got I
		//IL_01f5: Expected I, but got Obj
		//IL_0322: Expected I, but got Obj
		//IL_0338: Expected Obj, but got I
		//IL_026d: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_0363: Expected I, but got Obj
		//IL_05c6: Expected Obj, but got I
		//IL_02ae: Expected I, but got Obj
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_03db: Expected I, but got Obj
		//IL_03f1: Expected Obj, but got I
		//IL_0674: Expected Obj, but got I
		//IL_041c: Expected I, but got Obj
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if ((nint)obj != 1)
		{
			return;
		}
		OnPurchaseSuccess onPurchaseSuccess = this.m_onPurchaseSuccess;
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v123 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((IntPtr)productId.m_stringLength == ((Delegate)onPurchaseSuccess).method_ptr && (IntPtr)(int)productId.m_firstChar == ((Delegate)onPurchaseSuccess).invoke_impl)
		{
			return;
		}
		nint num3 = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v27 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v115 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine gameStateMachine = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v32 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v33+18]");
		object obj5 = (nint)0 + (nint)12;
		object obj6 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v33+18]");
			object obj7 = (nint)0 + (nint)16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			KilooSerializer kilooSerializer = (KilooSerializer)obj9;
			KilooSerializer.Options options = kilooSerializer.options;
			OnPurchaseSuccess onPurchaseSuccess2 = this.m_onPurchaseSuccess;
			nint num5 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v50 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v111 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((IntPtr)(options.indent ? 1 : 0) == ((Delegate)onPurchaseSuccess2).method_ptr && (nint)options.formatProvider == (nint)((Delegate)onPurchaseSuccess2).invoke_impl)
			{
				nint num7 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v95 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num8 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v103 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated = Game.IsInstantiated;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S2_v10 (System.Boolean)+CC]");
				object obj12 = kilooSerializer.ConvertValue((Type)(object)productId, (object)0, text);
				if (obj12 != null)
				{
					AddSegment((StringBuilder)(object)text, (int[])(object)transactionId);
				}
			}
			else
			{
				KilooSerializer.Options options2 = kilooSerializer.options;
				nint num9 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v64 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num10 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v90 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((options2.indent ? 1 : 0) == productId.m_stringLength && (nint)options2.formatProvider == (int)productId.m_firstChar)
				{
					nint num11 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v75 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num12 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v82 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated2 = Game.IsInstantiated;
					OnPurchaseSuccess toEnvironment = this.m_onPurchaseSuccess;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S2_v6 (System.Boolean)+CC]");
					if (((TransitionConfig)(object)kilooSerializer).TryGetEndPrefab((EnvironmentKind)(object)toEnvironment, (SyboRandom)0, out *(Transform*)text))
					{
						AddSegment((StringBuilder)(object)text, (int[])(object)transactionId);
					}
				}
			}
			object obj15 = obj6 + 1;
			obj6 = obj15;
		}
		object obj16 = this + 16;
		obj16 = productId;
	}

	private void InvokeRestoreEvents(string productId)
	{
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasSuccessfullyInitialized = (byte)(productId & 1) != 0;
		_hasSuccessfullyInitialized = hasSuccessfullyInitialized;
		if (InAppManager.m_onInitializeFinished != null)
		{
			InAppManager.m_onInitializeFinished.EndInvoke((IAsyncResult)(object)productId);
		}
		if (productId != null)
		{
			PlayPurchaseSucessSound();
		}
	}

	public void CheckedItemRestoredCallback(string productId, string transactionId, string cookie, IPurchaseValidationResult validationResult)
	{
		PurchaseRequestCallback(productId, transactionId, cookie, (string)(object)validationResult, PurchaseResult.Failed, null);
		_ = 0;
	}

	public void ItemRefundedCallback(string productid, string transactionid, string cookie, IPurchaseValidationResult validationResult)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		if ((nint)obj != 1)
		{
			return;
		}
		nint num = (nint)typeof(PurchaseValidationExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v7 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(PurchaseValidationExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v14 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A283");
		object obj3 = default;
		if (obj3 != null)
		{
			return;
		}
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v22 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (this.m_onValidatedItemRestored != null)
		{
			this.m_onValidatedItemRestored();
		}
	}

	public void RestoreRequestFinishedCallback(RestoreFinishedResult result)
	{
		//IL_000a: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		PurchaseItemUnavailable((string)result);
		if (this.m_onItemRestored != null)
		{
			this.m_onItemRestored.EndInvoke((IAsyncResult)result);
		}
		if (this.m_onPurchaseSuccess != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
		}
	}

	private void PurchaseRestored(string productId)
	{
		//IL_059d: Expected I, but got Obj
		//IL_05b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0167: Expected I, but got Obj
		//IL_017d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_05e2: Expected Obj, but got I4
		//IL_01a8: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_01f5: Expected I, but got Obj
		//IL_020b: Expected Obj, but got I
		//IL_050f: Expected I, but got Obj
		//IL_0525: Expected Obj, but got I
		//IL_0635: Expected I, but got Obj
		//IL_064b: Expected Obj, but got I
		//IL_0384: Expected I, but got Obj
		//IL_039a: Expected Obj, but got I
		//IL_0683: Expected Obj, but got I4
		//IL_0236: Expected I, but got Obj
		//IL_0550: Expected I, but got Obj
		//IL_0283: Expected I, but got Obj
		//IL_04e8: Expected Obj, but got I4
		//IL_03c5: Expected I, but got Obj
		//IL_02da: Expected I, but got Obj
		//IL_02f0: Expected Obj, but got I
		//IL_0412: Expected I, but got Obj
		//IL_0428: Expected Obj, but got I
		//IL_06eb: Expected I, but got Obj
		//IL_0701: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I4
		//IL_031b: Expected I, but got Obj
		//IL_0739: Expected Obj, but got I4
		//IL_0453: Expected I, but got Obj
		//IL_0363: Expected Obj, but got I4
		//IL_04a0: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v103 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v93 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v99 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).DelayedHideInAppPurchaseOverlay();
		}
		string text = default;
		if (text != null)
		{
			if ((nint)text != 1)
			{
				if ((nint)text != 2)
				{
					if ((nint)text == 3)
					{
						nint num5 = (nint)typeof(PurchaseValidationExtensions);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v40 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num6 = (nint)typeof(PurchaseValidationExtensions);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v45 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A283");
						object obj4 = default;
						string text2 = ((obj4 == null) ? ((string)3) : ((string)1));
						text = text2;
					}
				}
				else
				{
					nint num7 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v60 (Il2CppClass<InApp.InAppManager>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num8 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v80 (Il2CppClass<InApp.InAppManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(_isRestoredManually ? 1u : 0u) == 0)
					{
						nint num9 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v70 (Il2CppClass<UIScreenController>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num10 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v76 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag2 = UIScreenController.ShouldShowOnlineScreen();
						nint num11 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v28 (Il2CppClass<Strings>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num12 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v35 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string slideIn = Strings.GetDefault("SLIDEIN_RESTORE_NO_PREVIOUS_PURCHASES");
						((UIScreenController)flag2).QueueSlideIn((SlideIn)(object)slideIn);
					}
					text = (string)2;
				}
			}
		}
		else
		{
			nint num13 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v33 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num14 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v53 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(_isRestoredManually ? 1u : 0u) == 0)
			{
				nint num15 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v43 (Il2CppClass<UIScreenController>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num16 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v49 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = UIScreenController.ShouldShowOnlineScreen();
				nint num17 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v13 (Il2CppClass<Strings>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num18 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v20 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string slideIn2 = Strings.GetDefault("SLIDEIN_RESTORE_NETWORK_PROBLEM");
				((UIScreenController)flag3).QueueSlideIn((SlideIn)(object)slideIn2);
			}
			text = null;
		}
		if (this.m_onItemRestoreFinished != null)
		{
			this.m_onItemRestoreFinished.EndInvoke((IAsyncResult)(object)text);
		}
		nint num19 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v19 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num20 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v25 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_isRestoredManually = false;
	}

	private bool IsBoardBundleUnlocked(string bundleId)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(bundleId);
		bool isConsumable = inAppItemModel.isConsumable;
		return (byte)((isConsumable ? 1u : 0u) ^ 1u) != 0;
	}

	private InAppItemModel.BundleItem GetBoardItemFromBundleId(string bundleId)
	{
		//IL_00b1: Expected I4, but got Obj
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I4
		//IL_005e: Expected I, but got Obj
		if (GetDiscountValue(null, (int)bundleId) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A23B");
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.BoardId boardId = default;
			bool flag = BoardManager.HasAllThemesBeenSeen(boardId);
			return (InAppItemModel.BundleItem)flag;
		}
		return null;
	}

	private void PurchaseItemUnavailable(string productId)
	{
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_07ad: Expected I, but got Obj
		//IL_07c3: Expected Obj, but got I
		//IL_0419: Expected I, but got Obj
		//IL_042f: Expected Obj, but got I
		//IL_0074: Expected I, but got Obj
		//IL_0b37: Expected I, but got Obj
		//IL_0b4d: Expected Obj, but got I
		//IL_07ee: Expected I, but got Obj
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_083b: Expected I, but got Obj
		//IL_0851: Expected Obj, but got I
		//IL_0544: Expected I, but got Obj
		//IL_055a: Expected Obj, but got I
		//IL_045a: Expected I, but got Obj
		//IL_0a7f: Expected I, but got Obj
		//IL_0df8: Expected Obj, but got I4
		//IL_0e06: Expected I, but got Obj
		//IL_0e1c: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I4
		//IL_04a8: Expected I4, but got Obj
		//IL_04b6: Expected I, but got Obj
		//IL_04cc: Expected Obj, but got I
		//IL_0102: Expected I, but got Obj
		//IL_087c: Expected I, but got Obj
		//IL_0d3b: Expected I, but got Obj
		//IL_0d51: Expected Obj, but got I
		//IL_0585: Expected I, but got Obj
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Expected Obj, but got Unknown
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_09f1: Expected I, but got Obj
		//IL_0a07: Expected Obj, but got I
		//IL_08c9: Expected I, but got Obj
		//IL_04f7: Expected I, but got Obj
		//IL_0b8e: Expected I4, but got Obj
		//IL_0b9c: Expected I, but got Obj
		//IL_0bb2: Expected Obj, but got I
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Expected Obj, but got Unknown
		//IL_0916: Expected I, but got Obj
		//IL_092c: Expected Obj, but got I
		//IL_0706: Expected I, but got Obj
		//IL_071c: Expected Obj, but got I
		//IL_06a5: Expected I, but got Obj
		//IL_0190: Expected I, but got Obj
		//IL_0a32: Expected I, but got Obj
		//IL_0e8e: Expected I, but got Obj
		//IL_0ea4: Expected Obj, but got I
		//IL_0d9c: Expected I4, but got Obj
		//IL_0609: Expected Obj, but got I4
		//IL_0609: Expected I4, but got Obj
		//IL_0617: Expected I, but got Obj
		//IL_062d: Expected Obj, but got I
		//IL_0386: Expected I, but got Obj
		//IL_039c: Expected Obj, but got I
		//IL_01dd: Expected I, but got Obj
		//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Expected Obj, but got Unknown
		//IL_0ef2: Expected Obj, but got I4
		//IL_0957: Expected I, but got Obj
		//IL_0747: Expected I, but got Obj
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d85: Expected Obj, but got Unknown
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Expected Obj, but got Unknown
		//IL_022a: Expected I, but got Obj
		//IL_0240: Expected Obj, but got I
		//IL_09a4: Expected I, but got Obj
		//IL_0795: Expected Obj, but got I4
		//IL_0658: Expected I, but got Obj
		//IL_03c7: Expected I, but got Obj
		//IL_0c23: Expected Obj, but got I4
		//IL_026b: Expected I, but got Obj
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_0c43: Expected Obj, but got I4
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_0373: Expected Obj, but got I4
		//IL_031f: Expected I, but got Obj
		if (productId == "com.kiloo.subwaysurfers.doublecoins" && productId == "com.kiloo.subwaysurfers.doublecoinsdiscount")
		{
			nint num = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v83 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v234 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A27F");
			IEnumerable<string> source = default;
			if (Enumerable.Contains(source, productId))
			{
				nint num3 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v170 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v230 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!UserSave.hasDoubleCoinsUpgrade)
				{
					nint num5 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v177 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v224 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(productId);
					InventorySave.IncreaseAmount((UpgradeType)inAppItemModel.payoutAmount, (int)productId);
					nint num7 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v187 (Il2CppClass<UIScreenController>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v220 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UIScreenController uIScreenController = UIScreenController.Instance;
					if ((object)uIScreenController != null)
					{
						nint num9 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v208 (Il2CppClass<UIScreenController>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num10 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S0_v216 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						string text = default;
						text.m_stringLength = 16;
						((UIScreenController)flag)._QueueMessage(text);
						bool flag2 = UIScreenController.ShouldShowOnlineScreen();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						string text2 = default;
						text2.m_stringLength = 17;
						nint num11 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S1_v76 (Il2CppClass<Strings>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num12 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S1_v87 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string format = Strings.GetDefault("GIFT_NUMBER_OF_KEYS");
						object obj7 = inAppItemModel.payoutAmount;
						object obj8 = text2 + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						object[] args = default;
						string text3 = string.Format(format, args);
						obj8 = text3;
						((UIScreenController)flag2)._QueueMessage(text2);
					}
					nint num13 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S0_v195 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num14 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v203 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Dictionary<string, string> inAppPurchaseHistory = UserSave.inAppPurchaseHistory;
					Dictionary<string, string> inAppPurchaseHistory2 = (Dictionary<string, string>)(inAppPurchaseHistory + 1);
					UserSave.inAppPurchaseHistory = inAppPurchaseHistory2;
					UserSave.hasDoubleCoinsUpgrade = true;
				}
			}
			else
			{
				nint num15 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v91 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num16 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v165 (Il2CppClass<InApp.InAppData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E59");
				IEnumerable<string> source2 = default;
				if (Enumerable.Contains(source2, productId))
				{
					InventorySave.DecreaseCoins((int)this, productId, (string)1);
					nint num17 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v154 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num18 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v161 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Dictionary<string, string> inAppPurchaseHistory3 = UserSave.inAppPurchaseHistory;
					Dictionary<string, string> inAppPurchaseHistory4 = (Dictionary<string, string>)(inAppPurchaseHistory3 + 1);
					UserSave.inAppPurchaseHistory = inAppPurchaseHistory4;
				}
				else
				{
					nint num19 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v99 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num20 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v148 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8526");
					IEnumerable<string> source3 = default;
					if (Enumerable.Contains(source3, productId))
					{
						InAppItemModel.BundleItem boardItemFromBundleId = GetBoardItemFromBundleId(productId);
						if (boardItemFromBundleId == null)
						{
							InventorySave.DecreaseCoins((int)this, productId, (string)1);
							nint num21 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v137 (Il2CppClass<Data.Save.UserSave>)+BA]");
							object obj13 = (nint)0 & (nint)0x200;
							if (obj13 != null)
							{
								nint num22 = (nint)typeof(UserSave);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S0_v144 (Il2CppClass<Data.Save.UserSave>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Dictionary<string, string> inAppPurchaseHistory5 = UserSave.inAppPurchaseHistory;
							Dictionary<string, string> inAppPurchaseHistory6 = (Dictionary<string, string>)(inAppPurchaseHistory5 + 1);
							UserSave.inAppPurchaseHistory = inAppPurchaseHistory6;
							goto IL_0b29;
						}
					}
					nint num23 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v108 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num24 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v128 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (InAppData.InappidIsDynamicLimitedBoardPurchase(productId))
					{
						((InAppManager)null).LimitedBoardPurchaseSuccesful(productId, true);
					}
					else
					{
						nint num25 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v115 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num26 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v123 (Il2CppClass<InApp.InAppData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text4 = InAppData.ConvertCharacterTypeToDynamicPurchaseId((Characters.CharacterId)productId);
						if (text4 != null)
						{
							BuyExpiredLimitedBoard(productId, (PurchaseHandler)1);
						}
					}
				}
			}
		}
		else
		{
			nint num27 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v24 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num28 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v76 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
			if (hasCharacterBeenSeen == null)
			{
				nint num29 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num30 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v72 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UserSave.hasCharacterBeenSeen = (Dictionary<Characters.CharacterId, bool>)1;
				nint num31 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v38 (Il2CppClass<UIScreenController>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num32 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v68 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIScreenController uIScreenController2 = UIScreenController.Instance;
				if ((object)uIScreenController2 != null)
				{
					nint num33 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v58 (Il2CppClass<UIScreenController>)+BA]");
					object obj19 = (nint)0 & (nint)0x200;
					if (obj19 != null)
					{
						nint num34 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v64 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag3 = UIScreenController.ShouldShowOnlineScreen();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					string text5 = default;
					text5.m_stringLength = 6;
					nint num35 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S1_v21 (Il2CppClass<Strings>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num36 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S1_v28 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj21 = text5 + 12;
					string text6 = Strings.GetDefault("INAPP_DATA_DOUBLE_COINS");
					obj21 = text6;
					((UIScreenController)flag3)._QueueMessage(text5);
				}
				nint num37 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v46 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num38 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v53 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, string> inAppPurchaseHistory7 = UserSave.inAppPurchaseHistory;
				Dictionary<string, string> inAppPurchaseHistory8 = (Dictionary<string, string>)(inAppPurchaseHistory7 + 1);
				UserSave.inAppPurchaseHistory = inAppPurchaseHistory8;
			}
		}
		goto IL_0b29;
		IL_0b29:
		nint num39 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v12 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num40 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v18 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
	}

	private void PurchaseCanceled(string productId)
	{
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0227: Expected I, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		((InAppManager)null).NativePurchaseErrorForReviveWithKeys();
		((InAppManager)null).NativePurchaseInappPack((string)null);
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v47 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v19 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v43 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 8;
		string text = Strings.GetDefault("PURCHASE_FAILED_TITLE");
		obj3 = text;
		object obj5 = obj4 + 12;
		string text2 = Strings.GetDefault("PURCHASE_FAILED_BODY");
		obj5 = text2;
		_ = 0;
		_ = 0;
		_ = 1;
		object obj6 = this + 60;
		obj6 = obj4;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v33 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v39 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("PurchaseErrorPopup");
	}

	private void PurchaseFailed(string productId)
	{
		((InAppManager)null).NativePurchaseErrorForReviveWithKeys();
		((InAppManager)null).NativePurchaseInappPack((string)null);
	}

	private void PayoutInAppPurchase(string productId)
	{
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		((InAppManager)null).NativePurchaseErrorForReviveWithKeys();
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v46 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v18 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v42 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 8;
		string text = Strings.GetDefault("PURCHASE_FAILED_TITLE");
		obj3 = text;
		object obj5 = obj4 + 12;
		string text2 = Strings.GetDefault("PURCHASE_FAILED_BODY");
		obj5 = text2;
		_ = 0;
		_ = 0;
		_ = 1;
		object obj6 = this + 60;
		obj6 = obj4;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("PurchaseErrorPopup");
	}

	public int GetItemPayoutAmount(string productId, string onlineSettingsDiscountId = null)
	{
		//IL_021a: Expected I, but got Obj
		//IL_0230: Expected Obj, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected I4, but got Unknown
		//IL_0203: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I4
		//IL_00e2: Expected I, but got Obj
		if (onlineSettingsDiscountId != null)
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v24 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIScreenController uIScreenController = UIScreenController.Instance;
			if ((object)uIScreenController != null)
			{
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31 (Il2CppClass<UIScreenController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v37 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				InAppManagerPopupData popupData = ((InAppManager)null).GetPopupData();
				((UIScreenController)flag).OnOverlayManuallyClosed += (Action)(object)popupData;
			}
		}
		nint num5 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v8 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v17 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestoredManually = (byte)(onlineSettingsDiscountId & 1) != 0;
		_isRestoredManually = isRestoredManually;
		bool isValidationSupportedOnCurrentPlatform = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
		return (int)((InAppPurchaseProvider)isValidationSupportedOnCurrentPlatform).IsProductConsumable(productId);
	}

	private void PlayPurchaseSucessSound()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02db: Expected Obj, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I4
		//IL_0407: Expected I, but got Obj
		//IL_041d: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_03eb: Expected I4, but got Obj
		//IL_03eb: Expected Obj, but got I4
		//IL_0261: Expected I, but got Obj
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
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
		if (~(_isQueryingProductInfo ? 1u : 0u) == 0)
		{
			return;
		}
		_isQueryingProductInfo = true;
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v27 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v98 (Il2CppClass<InApp.InAppData>)+74]");
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
			_ = 0;
		}
		object obj8 = obj5 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj5 + obj10;
		obj11 = 74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj5 + obj12;
			if ((nint)obj13 == 74)
			{
				object obj14 = obj5 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_03f0;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03f0;
		IL_03f0:
		bool isValidationSupportedOnCurrentPlatform = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v33 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v39 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = InAppData.OutputAllInapps();
		((InAppPurchaseProvider)isValidationSupportedOnCurrentPlatform).InitFinishedCallback((byte)(int)text != 0);
	}

	private void LimitedCharacterPurchaseSuccesful(string itemId, bool unlockedByRestore)
	{
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected Obj, but got Unknown
		//IL_05fa: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I4
		//IL_0099: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_0652: Expected Obj, but got I
		//IL_0662: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected Obj, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected Obj, but got Unknown
		//IL_00da: Expected I, but got Obj
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03f3: Expected Obj, but got I
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		//IL_0725: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_04ed: Expected I, but got Obj
		//IL_0503: Expected Obj, but got I
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected Obj, but got Unknown
		//IL_0452: Expected I, but got Obj
		//IL_0468: Expected Obj, but got I
		//IL_0815: Expected Obj, but got I4
		//IL_0823: Expected I, but got Obj
		//IL_0839: Expected Obj, but got I
		//IL_052e: Expected I, but got Obj
		//IL_0294: Expected I, but got Obj
		//IL_02aa: Expected Obj, but got I
		//IL_08cd: Expected Obj, but got I
		//IL_08dd: Expected Obj, but got I
		//IL_08ed: Expected Obj, but got I
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Obj, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Obj, but got Unknown
		//IL_0493: Expected I, but got Obj
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected Obj, but got Unknown
		//IL_057b: Expected I, but got Obj
		//IL_0322: Expected I, but got Obj
		//IL_0338: Expected Obj, but got I
		//IL_02d5: Expected I, but got Obj
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_0247: Expected I, but got Obj
		//IL_0363: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		if (itemId != null)
		{
			_productRequestSucceeded = true;
			object obj4 = (unlockedByRestore ? 1 : 0) + 12;
			object obj5 = default;
			object obj15 = default;
			OnInitializeFinished onInitializeFinished = default;
			object obj32 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				object obj6 = (unlockedByRestore ? 1 : 0) + 16;
				object obj7 = obj5 << 4;
				object obj8 = obj6 + obj7;
				obj = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v19+8]");
				_ = 0;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				nint num = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v37 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num2 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v164 (Il2CppClass<InApp.InAppData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S2_v7 (Il2CppMethodInfo)+C]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v8+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S2_v9+44]");
				object obj12 = 0;
				object obj13 = obj12 & 0x1FFF;
				object obj14 = obj13 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v166 @ S3_v7 (should have been resolved before IL gen)");
				if ((nint)obj15 > -1)
				{
					nint num4 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v106 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num5 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v158 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					InAppItemModel inAppItemModel = InAppData.inAppData.get_Item((string)obj2);
					inAppItemModel.isValidated = true;
					InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item((string)obj2);
					obj = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					object obj17 = inAppItemModel2 + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
					obj17 = 0;
					InAppItemModel objectToClone = InAppData.inAppData.get_Item((string)obj2);
					InAppItemModel inAppItemModel3 = InAppItemModel.Clone(objectToClone);
					if (inAppItemModel3 == null || inAppItemModel3.displayName == null)
					{
						nint num6 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v144 (Il2CppClass<InApp.InAppManager>)+BA]");
						object obj18 = (nint)0 & (nint)0x200;
						if (obj18 != null)
						{
							nint num7 = (nint)typeof(InAppManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v150 (Il2CppClass<InApp.InAppManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
					}
					else
					{
						nint num8 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v128 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num9 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v137 (Il2CppClass<InApp.InAppData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						InAppItemModel inAppItemModel4 = InAppData.inAppData.get_Item((string)obj2);
						InAppItemModel objectToClone2 = InAppData.inAppData.get_Item((string)obj2);
						InAppItemModel inAppItemModel5 = InAppItemModel.Clone(objectToClone2);
						nint num10 = (nint)typeof(Regex);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S1_v77 (Il2CppClass<System.Text.RegularExpressions.Regex>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num11 = (nint)typeof(Regex);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S1_v84 (Il2CppClass<System.Text.RegularExpressions.Regex>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj21 = inAppItemModel4 + 48;
						string text = ((Regex)(object)inAppItemModel5).Replace("\\u00A0", " ");
						obj21 = text;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					InAppManager.onInitializeFinished += onInitializeFinished;
					_ = 1;
					obj = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					object obj22 = onInitializeFinished + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
					obj22 = 0;
					InAppItemModel inAppItemModel6 = InAppItemModel.Clone((InAppItemModel)(object)onInitializeFinished);
					if (inAppItemModel6 == null || inAppItemModel6.displayName == null)
					{
						nint num12 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v91 (Il2CppClass<InApp.InAppManager>)+BA]");
						object obj23 = (nint)0 & (nint)0x200;
						if (obj23 != null)
						{
							nint num13 = (nint)typeof(InAppManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v97 (Il2CppClass<InApp.InAppManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
					}
					else
					{
						InAppItemModel inAppItemModel7 = InAppItemModel.Clone((InAppItemModel)(object)onInitializeFinished);
						nint num14 = (nint)typeof(Regex);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v80 (Il2CppClass<System.Text.RegularExpressions.Regex>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num15 = (nint)typeof(Regex);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v86 (Il2CppClass<System.Text.RegularExpressions.Regex>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj25 = onInitializeFinished + 48;
						string text2 = ((Regex)(object)inAppItemModel7).Replace("\\u00A0", " ");
						obj25 = text2;
					}
					((MulticastDelegate)onInitializeFinished).delegates = (Delegate[])1;
					nint num16 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S0_v63 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj26 = (nint)0 & (nint)0x200;
					if (obj26 != null)
					{
						nint num17 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v71 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S4_v8 (Il2CppMethodInfo)+C]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S4_v9+60]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S4_v10+48]");
					object obj29 = 0;
					object obj30 = obj29 & 0x7FF;
					object obj31 = obj30 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v3 (should have been resolved before IL gen)");
				}
				obj5 = obj32 + 1;
			}
		}
		else
		{
			_productRequestSucceeded = false;
		}
		if (this.m_onProductRequestDone != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		_isQueryingProductInfo = false;
	}

	private unsafe void LimitedBoardPurchaseSuccesful(string itemId, bool unlockedByRestore)
	{
		//IL_0612: Expected I, but got Obj
		//IL_0628: Expected Obj, but got I
		//IL_08d3: Expected I4, but got Obj
		//IL_0653: Expected I, but got Obj
		//IL_0669: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_09a2: Expected I, but got Obj
		//IL_09b8: Expected Obj, but got I
		//IL_09d5: Expected I, but got Obj
		//IL_04c0: Expected I, but got Obj
		//IL_098a: Expected Obj, but got I
		//IL_0993: Expected Obj, but got I4
		//IL_050d: Expected I, but got Obj
		//IL_0523: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_059b: Expected I, but got Obj
		//IL_05cb: Expected I, but got Obj
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_08c1: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_054e: Expected I, but got Obj
		//IL_06e1: Expected I, but got Obj
		//IL_06f7: Expected Obj, but got I
		//IL_05f1: Expected I, but got Obj
		//IL_0730: Expected I, but got Obj
		//IL_0746: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_0798: Expected I4, but got Obj
		//IL_0798: Expected Obj, but got I4
		//IL_0257: Expected I, but got Obj
		//IL_02fe: Expected I, but got Obj
		//IL_034b: Expected I, but got Obj
		//IL_0361: Expected Obj, but got I
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07f1: Expected I, but got Obj
		//IL_0807: Expected Obj, but got I
		//IL_083c: Expected I, but got Obj
		//IL_0852: Expected Obj, but got I
		//IL_038c: Expected I, but got Obj
		//IL_0941: Expected I, but got Obj
		//IL_0957: Expected Obj, but got I
		//IL_03d9: Expected I, but got Obj
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected Obj, but got Unknown
		//IL_08a4: Expected Obj, but got I4
		//IL_0426: Expected I, but got Obj
		//IL_0473: Expected I, but got Obj
		InAppItemModel.OfferType offerType = default;
		((InAppItemModel.OfferType*)(int)offerType)->value__ = 0;
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v178 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerable<InAppItemModel> allWithItemAndOfferType = InAppData.GetAllWithItemAndOfferType((InAppItemModel.ItemType)itemId, offerType);
		if (allWithItemAndOfferType != null)
		{
			nint num3 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v65 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v174 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!CharacterManager.IsCollectionComplete((Characters.CharacterId)((InAppItemModel.OfferType*)(int)offerType)->value__))
			{
				nint num5 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v73 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v168 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)((InAppItemModel.OfferType*)(int)offerType)->value__);
				nint num7 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v82 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v164 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterManager.LockCharacter((Characters.CharacterId)((InAppItemModel.OfferType*)(int)offerType)->value__);
				nint num9 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v88 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v158 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (_purchaseHandler != null)
				{
					nint num11 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v145 (Il2CppClass<InApp.InAppManager>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num12 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v152 (Il2CppClass<InApp.InAppManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					_purchaseHandler.OnPurchaseBoardWithInappSucceded((string)((InAppItemModel.OfferType*)(int)offerType)->value__, (Boards.BoardId)itemId);
				}
				if (unlockedByRestore)
				{
					nint num13 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v98 (Il2CppClass<UIScreenController>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num14 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v140 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UIScreenController uIScreenController = UIScreenController.Instance;
					if ((object)uIScreenController != null)
					{
						nint num15 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v105 (Il2CppClass<Data.Save.UserSave>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num16 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v136 (Il2CppClass<Data.Save.UserSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Dictionary<string, string> inAppPurchaseHistory = UserSave.inAppPurchaseHistory;
						Dictionary<string, string> inAppPurchaseHistory2 = (Dictionary<string, string>)(inAppPurchaseHistory + 1);
						UserSave.inAppPurchaseHistory = inAppPurchaseHistory2;
						nint num17 = (nint)typeof(CharacterScreen);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v113 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num18 = (nint)typeof(CharacterScreen);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v130 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CharacterScreen.forceRefreshOnCharacterScreen = true;
						nint num19 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v120 (Il2CppClass<UIScreenController>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num20 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v126 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						string text = default;
						text.m_stringLength = 6;
						nint num21 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S1_v36 (Il2CppClass<Strings>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num22 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S1_v43 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj12 = text + 12;
						string text2 = Strings.GetDefault(model.name);
						obj12 = text2;
						((UIScreenController)flag)._QueueMessage(text);
					}
				}
			}
		}
		nint num23 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v18 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num24 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v56 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_purchaseHandler != null)
		{
			nint num25 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v42 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num26 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v50 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj15 = _purchaseHandler + 16;
			obj15 = 0;
		}
		nint num27 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v27 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		bool flag2 = obj16 == null;
		nint num28 = (nint)typeof(InAppManager);
		if (!flag2)
		{
			nint num29 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v35 (Il2CppClass<InApp.InAppManager>)+74]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num28 = (nint)typeof(InAppManager);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num28 = (nint)typeof(InAppManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ L0_v7 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj17 = (nint)0 + (nint)12;
		obj17 = 0;
	}

	private void TriggerFailForPurchaseHandler()
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		object obj = this - -64;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj).FindKernel((string)null) == 0)
		{
			return;
		}
		object obj3 = this - -64;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v12 (Il2CppClass<NGUITools>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v17 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string hierarchy = NGUITools.GetHierarchy((GameObject)obj3);
	}

	public unsafe void NativePurchaseFinished(bool success)
	{
		//IL_126a: Unknown result type (might be due to invalid IL or missing references)
		//IL_126f: Expected Obj, but got Unknown
		//IL_1277: Expected Obj, but got I4
		//IL_1285: Expected I, but got Obj
		//IL_129b: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_0306: Expected I, but got Obj
		//IL_031c: Expected Obj, but got I
		//IL_12e9: Expected I, but got Obj
		//IL_12ff: Expected Obj, but got I
		//IL_08cf: Expected Obj, but got I
		//IL_13ee: Expected Obj, but got I
		//IL_1925: Expected Obj, but got I
		//IL_194b: Expected I, but got Obj
		//IL_1961: Expected Obj, but got I
		//IL_15e0: Expected I, but got Obj
		//IL_15f6: Expected Obj, but got I
		//IL_0615: Expected I, but got Obj
		//IL_062b: Expected Obj, but got I
		//IL_0347: Expected I, but got Obj
		//IL_00e7: Expected I, but got Obj
		//IL_090d: Expected Obj, but got I
		//IL_14eb: Expected Obj, but got I
		//IL_138a: Expected Obj, but got I
		//IL_1800: Expected I, but got Obj
		//IL_1816: Expected Obj, but got I
		//IL_0f2d: Expected I, but got Obj
		//IL_0656: Expected I, but got Obj
		//IL_0463: Expected I, but got Obj
		//IL_0479: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_01c9: Expected I, but got Obj
		//IL_1351: Expected Obj, but got I
		//IL_136f: Expected Obj, but got I
		//IL_0f7a: Expected I, but got Obj
		//IL_0f90: Expected Obj, but got I
		//IL_0943: Expected I, but got Obj
		//IL_0959: Expected Obj, but got I
		//IL_145f: Expected Obj, but got I
		//IL_148d: Expected Obj, but got I
		//IL_03d5: Expected I, but got Obj
		//IL_03eb: Expected Obj, but got I
		//IL_0158: Expected I, but got Obj
		//IL_11d6: Expected I, but got Obj
		//IL_11ec: Expected Obj, but got I
		//IL_1189: Expected I, but got Obj
		//IL_183d: Expected Obj, but got I4
		//IL_184b: Expected I, but got Obj
		//IL_1861: Expected Obj, but got I
		//IL_1632: Expected Obj, but got I
		//IL_0772: Expected I, but got Obj
		//IL_0788: Expected Obj, but got I
		//IL_04a4: Expected I, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_190a: Expected Obj, but got I4
		//IL_0fbb: Expected I, but got Obj
		//IL_0a7d: Expected I, but got Obj
		//IL_0a93: Expected Obj, but got I
		//IL_0984: Expected I, but got Obj
		//IL_155c: Expected Obj, but got I
		//IL_158a: Expected Obj, but got I
		//IL_06e4: Expected I, but got Obj
		//IL_06fa: Expected Obj, but got I
		//IL_0525: Expected I, but got Obj
		//IL_053b: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_0416: Expected I, but got Obj
		//IL_1217: Expected I, but got Obj
		//IL_1008: Expected I, but got Obj
		//IL_1685: Expected Obj, but got I
		//IL_09d6: Expected Obj, but got I
		//IL_09d6: Expected I4, but got Obj
		//IL_07b3: Expected I, but got Obj
		//IL_1055: Expected I, but got Obj
		//IL_106b: Expected Obj, but got I
		//IL_0bb0: Expected I, but got Obj
		//IL_0bc6: Expected Obj, but got I
		//IL_0abe: Expected I, but got Obj
		//IL_09ef: Expected I, but got Obj
		//IL_0a05: Expected Obj, but got I
		//IL_0834: Expected I, but got Obj
		//IL_084a: Expected Obj, but got I
		//IL_0807: Expected Obj, but got I
		//IL_0725: Expected I, but got Obj
		//IL_0566: Expected I, but got Obj
		//IL_18b6: Expected Obj, but got I4
		//IL_0b14: Expected Obj, but got I
		//IL_0b22: Expected I, but got Obj
		//IL_0b38: Expected Obj, but got I
		//IL_10fb: Expected I, but got Obj
		//IL_1111: Expected Obj, but got I
		//IL_1096: Expected I, but got Obj
		//IL_0cdf: Expected I, but got Obj
		//IL_0cf5: Expected Obj, but got I
		//IL_0bf1: Expected I, but got Obj
		//IL_0a30: Expected I, but got Obj
		//IL_0875: Expected I, but got Obj
		//IL_18cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d2: Expected Obj, but got Unknown
		//IL_18f5: Expected Obj, but got I4
		//IL_173d: Expected Obj, but got I
		//IL_0c43: Expected Obj, but got I
		//IL_0c51: Expected I, but got Obj
		//IL_0c67: Expected Obj, but got I
		//IL_0b63: Expected I, but got Obj
		//IL_113c: Expected I, but got Obj
		//IL_0e01: Expected I, but got Obj
		//IL_0e17: Expected Obj, but got I
		//IL_0d20: Expected I, but got Obj
		//IL_17aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_17af: Expected Obj, but got Unknown
		//IL_0d73: Expected I, but got Obj
		//IL_0d89: Expected Obj, but got I
		//IL_0c92: Expected I, but got Obj
		//IL_0e42: Expected I, but got Obj
		//IL_0db4: Expected I, but got Obj
		//IL_0eb9: Expected I, but got Obj
		//IL_0ecf: Expected Obj, but got I
		//IL_0efa: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = success;
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v444 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A264");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A215");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A217");
		object obj5 = default;
		object obj4 = obj5 + 12;
		object obj6 = 0;
		Func<string, bool> func = default;
		IEnumerable<string> source = default;
		Func<string, bool> func2 = default;
		IEnumerable<string> source2 = default;
		IEnumerable<string> source3 = default;
		IEnumerable<string> source4 = default;
		Func<string, bool> func3 = default;
		IEnumerable<string> source5 = default;
		string text4 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				object obj7 = obj5 + 16;
				object obj8 = obj6 << 2;
				object obj9 = obj7 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				if ((string)obj9 == (string)0)
				{
					object obj10 = obj6 + 1;
					obj6 = obj10;
					continue;
				}
				nint num3 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v384 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num4 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v436 (Il2CppClass<InApp.InAppData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, InAppItemModel> inAppData = InAppData.inAppData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				InAppItemModel inAppItemModel = inAppData.get_Item((string)0);
				bool flag = inAppItemModel.itemType == InAppItemModel.ItemType.Coins;
				nint num5 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v177 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				bool flag2 = obj12 == null;
				if (flag)
				{
					if (!flag2)
					{
						nint num6 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v430 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Dictionary<string, InAppItemModel> inAppData2 = InAppData.inAppData;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
					InAppItemModel inAppItemModel2 = inAppData2.get_Item((string)0);
					int payoutAmount = inAppItemModel2.payoutAmount;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
					InventorySave.IncreaseKeys(payoutAmount, (string)0);
				}
				else
				{
					if (!flag2)
					{
						nint num7 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v416 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Dictionary<string, InAppItemModel> inAppData3 = InAppData.inAppData;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
					InAppItemModel inAppItemModel3 = inAppData3.get_Item((string)0);
					int payoutAmount2 = inAppItemModel3.payoutAmount;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
					InventorySave.IncreaseAmount((UpgradeType)payoutAmount2, 0);
				}
				nint num8 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v396 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num9 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v404 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int inAppNonConsumablePurchaseCount = UserSave.inAppNonConsumablePurchaseCount;
				int inAppNonConsumablePurchaseCount2 = inAppNonConsumablePurchaseCount + 1;
				UserSave.inAppNonConsumablePurchaseCount = inAppNonConsumablePurchaseCount2;
				TriggerFailForPurchaseHandler();
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num10 = 0;
				_ = 0;
				object obj14 = func + 16;
				obj14 = obj2;
				if (Enumerable.Any(source, func))
				{
					nint num11 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v317 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num12 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v372 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Dictionary<string, InAppItemModel> inAppData4 = InAppData.inAppData;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
					InAppItemModel inAppItemModel4 = inAppData4.get_Item((string)0);
					string ignoredInAppOnlineSettingsId = InAppData.GetIgnoredInAppOnlineSettingsId(inAppItemModel4.normalOfferId);
					if (ignoredInAppOnlineSettingsId == null || ignoredInAppOnlineSettingsId.m_stringLength == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
						string text = string.ConcatArray((string[])(object)"Could not find a discout id for the pricepoint: ", 0);
						nint num13 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S1_v158 (Il2CppClass<InApp.InAppManager>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num14 = (nint)typeof(InAppManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S1_v163 (Il2CppClass<InApp.InAppManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
						return;
					}
					nint num15 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v329 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num16 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v355 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Dictionary<string, InAppItemModel> inAppData5 = InAppData.inAppData;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
					InAppItemModel inAppItemModel5 = inAppData5.get_Item((string)0);
					bool flag3 = inAppItemModel5.itemType == InAppItemModel.ItemType.Coins;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
					bool flag4 = PlayerInfoMigrator.InterstitialStatsTryGetValueNotNull((IDictionary<string, object>)null, (string)0, out *(object*)ignoredInAppOnlineSettingsId);
					if (flag3)
					{
						bool amount = flag4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
						InventorySave.IncreaseKeys(amount ? 1 : 0, (string)0);
					}
					else
					{
						bool type = flag4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
						InventorySave.IncreaseAmount(type ? UpgradeType.hoverboard : UpgradeType._notset, 0);
					}
					nint num17 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v341 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num18 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ S0_v349 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int inAppNonConsumablePurchaseCount3 = UserSave.inAppNonConsumablePurchaseCount;
					int inAppNonConsumablePurchaseCount4 = inAppNonConsumablePurchaseCount3 + 1;
					UserSave.inAppNonConsumablePurchaseCount = inAppNonConsumablePurchaseCount4;
					TriggerFailForPurchaseHandler();
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num19 = 0;
					_ = 0;
					object obj19 = func2 + 16;
					obj19 = obj2;
					if (Enumerable.Any(source2, func2))
					{
						nint num20 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v255 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num21 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v310 (Il2CppClass<InApp.InAppData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Dictionary<string, InAppItemModel> inAppData6 = InAppData.inAppData;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
						InAppItemModel inAppItemModel6 = inAppData6.get_Item((string)0);
						string ignoredInAppOnlineSettingsId2 = InAppData.GetIgnoredInAppOnlineSettingsId(inAppItemModel6.normalOfferId);
						if (ignoredInAppOnlineSettingsId2 == null || ignoredInAppOnlineSettingsId2.m_stringLength == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
							string text2 = string.ConcatArray((string[])(object)"Could not find a discount id for the pricepoint: ", 0);
							nint num22 = (nint)typeof(InAppManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ S1_v127 (Il2CppClass<InApp.InAppManager>)+BA]");
							object obj21 = (nint)0 & (nint)0x200;
							if (obj21 != null)
							{
								nint num23 = (nint)typeof(InAppManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S1_v132 (Il2CppClass<InApp.InAppManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							break;
						}
						nint num24 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v267 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							nint num25 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v293 (Il2CppClass<InApp.InAppData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Dictionary<string, InAppItemModel> inAppData7 = InAppData.inAppData;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
						InAppItemModel inAppItemModel7 = inAppData7.get_Item((string)0);
						bool flag5 = inAppItemModel7.itemType == InAppItemModel.ItemType.Coins;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
						bool flag6 = PlayerInfoMigrator.InterstitialStatsTryGetValueNotNull((IDictionary<string, object>)null, (string)0, out *(object*)ignoredInAppOnlineSettingsId2);
						if (flag5)
						{
							bool amount2 = flag6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
							InventorySave.IncreaseKeys(amount2 ? 1 : 0, (string)0);
						}
						else
						{
							bool type2 = flag6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
							InventorySave.IncreaseAmount(type2 ? UpgradeType.hoverboard : UpgradeType._notset, 0);
						}
						nint num26 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S0_v279 (Il2CppClass<Data.Save.UserSave>)+BA]");
						object obj23 = (nint)0 & (nint)0x200;
						if (obj23 != null)
						{
							nint num27 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ S0_v287 (Il2CppClass<Data.Save.UserSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int inAppNonConsumablePurchaseCount5 = UserSave.inAppNonConsumablePurchaseCount;
						int inAppNonConsumablePurchaseCount6 = inAppNonConsumablePurchaseCount5 + 1;
						UserSave.inAppNonConsumablePurchaseCount = inAppNonConsumablePurchaseCount6;
						TriggerFailForPurchaseHandler();
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
						if (!((string)0 != "com.kiloo.subwaysurfers.doublecoins"))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
							if (!((string)0 != "com.kiloo.subwaysurfers.doublecoinsdiscount"))
							{
								nint num28 = (nint)typeof(InAppData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v130 (Il2CppClass<InApp.InAppData>)+BA]");
								object obj24 = (nint)0 & (nint)0x200;
								if (obj24 != null)
								{
									nint num29 = (nint)typeof(InAppData);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v250 (Il2CppClass<InApp.InAppData>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E59");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
								if (Enumerable.Contains(source3, (string)0))
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
									InventorySave.DecreaseCoins((int)this, (string)0, null);
									TriggerFailForPurchaseHandler();
									nint num30 = (nint)typeof(UserSave);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ S0_v239 (Il2CppClass<Data.Save.UserSave>)+BA]");
									object obj25 = (nint)0 & (nint)0x200;
									if (obj25 != null)
									{
										nint num31 = (nint)typeof(UserSave);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ S0_v246 (Il2CppClass<Data.Save.UserSave>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									int inAppRestoredPurchaseCount = UserSave.inAppRestoredPurchaseCount;
									int inAppRestoredPurchaseCount2 = inAppRestoredPurchaseCount + 1;
									UserSave.inAppRestoredPurchaseCount = inAppRestoredPurchaseCount2;
								}
								else
								{
									nint num32 = (nint)typeof(InAppData);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S0_v138 (Il2CppClass<InApp.InAppData>)+BA]");
									object obj26 = (nint)0 & (nint)0x200;
									if (obj26 != null)
									{
										nint num33 = (nint)typeof(InAppData);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ S0_v232 (Il2CppClass<InApp.InAppData>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
									if (InAppData.InappidIsDynamicLimitedBoardPurchase((string)0))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
										((InAppManager)null).LimitedBoardPurchaseSuccesful((string)0, false);
										nint num34 = (nint)typeof(UserSave);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ S0_v221 (Il2CppClass<Data.Save.UserSave>)+BA]");
										object obj27 = (nint)0 & (nint)0x200;
										if (obj27 != null)
										{
											nint num35 = (nint)typeof(UserSave);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ S0_v228 (Il2CppClass<Data.Save.UserSave>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										int inAppRestoredPurchaseCount3 = UserSave.inAppRestoredPurchaseCount;
										int inAppRestoredPurchaseCount4 = inAppRestoredPurchaseCount3 + 1;
										UserSave.inAppRestoredPurchaseCount = inAppRestoredPurchaseCount4;
									}
									else
									{
										nint num36 = (nint)typeof(InAppData);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ S0_v145 (Il2CppClass<InApp.InAppData>)+BA]");
										object obj28 = (nint)0 & (nint)0x200;
										if (obj28 != null)
										{
											nint num37 = (nint)typeof(InAppData);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ S0_v215 (Il2CppClass<InApp.InAppData>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
										string text3 = InAppData.ConvertCharacterTypeToDynamicPurchaseId(Characters.CharacterId.slick);
										if (text3 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
											BuyExpiredLimitedBoard((string)0, null);
											nint num38 = (nint)typeof(UserSave);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S0_v204 (Il2CppClass<Data.Save.UserSave>)+BA]");
											object obj29 = (nint)0 & (nint)0x200;
											if (obj29 != null)
											{
												nint num39 = (nint)typeof(UserSave);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ S0_v211 (Il2CppClass<Data.Save.UserSave>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											int inAppRestoredPurchaseCount5 = UserSave.inAppRestoredPurchaseCount;
											int inAppRestoredPurchaseCount6 = inAppRestoredPurchaseCount5 + 1;
											UserSave.inAppRestoredPurchaseCount = inAppRestoredPurchaseCount6;
										}
										else
										{
											nint num40 = (nint)typeof(InAppData);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ S0_v152 (Il2CppClass<InApp.InAppData>)+BA]");
											object obj30 = (nint)0 & (nint)0x200;
											if (obj30 != null)
											{
												nint num41 = (nint)typeof(InAppData);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ S0_v198 (Il2CppClass<InApp.InAppData>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8526");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
											if (Enumerable.Contains(source4, (string)0))
											{
												TriggerFailForPurchaseHandler();
												nint num42 = (nint)typeof(UserSave);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ S0_v187 (Il2CppClass<Data.Save.UserSave>)+BA]");
												object obj31 = (nint)0 & (nint)0x200;
												if (obj31 != null)
												{
													nint num43 = (nint)typeof(UserSave);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ S0_v194 (Il2CppClass<Data.Save.UserSave>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												int inAppRestoredPurchaseCount7 = UserSave.inAppRestoredPurchaseCount;
												int inAppRestoredPurchaseCount8 = inAppRestoredPurchaseCount7 + 1;
												UserSave.inAppRestoredPurchaseCount = inAppRestoredPurchaseCount8;
											}
											else
											{
												nint num44 = (nint)typeof(InAppData);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ S0_v160 (Il2CppClass<InApp.InAppData>)+BA]");
												object obj32 = (nint)0 & (nint)0x200;
												if (obj32 != null)
												{
													nint num45 = (nint)typeof(InAppData);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ S0_v181 (Il2CppClass<InApp.InAppData>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76FE");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
												nint num46 = 0;
												_ = 0;
												object obj33 = func3 + 16;
												obj33 = obj2;
												if (Enumerable.Any(source5, func3))
												{
													((InAppManagerPopupData)null)._002Ector();
													TriggerFailForPurchaseHandler();
													nint num47 = (nint)typeof(UserSave);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ S0_v171 (Il2CppClass<Data.Save.UserSave>)+BA]");
													object obj34 = (nint)0 & (nint)0x200;
													if (obj34 != null)
													{
														nint num48 = (nint)typeof(UserSave);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ S0_v178 (Il2CppClass<Data.Save.UserSave>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													int inAppNonConsumablePurchaseCount7 = UserSave.inAppNonConsumablePurchaseCount;
													int inAppNonConsumablePurchaseCount8 = inAppNonConsumablePurchaseCount7 + 1;
													UserSave.inAppNonConsumablePurchaseCount = inAppNonConsumablePurchaseCount8;
												}
											}
										}
									}
								}
								goto IL_11c8;
							}
						}
						nint num49 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v67 (Il2CppClass<Data.Save.UserSave>)+BA]");
						object obj35 = (nint)0 & (nint)0x200;
						if (obj35 != null)
						{
							nint num50 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v121 (Il2CppClass<Data.Save.UserSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
						if (hasCharacterBeenSeen == null)
						{
							nint num51 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v88 (Il2CppClass<Data.Save.UserSave>)+BA]");
							object obj36 = (nint)0 & (nint)0x200;
							if (obj36 != null)
							{
								nint num52 = (nint)typeof(UserSave);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v117 (Il2CppClass<Data.Save.UserSave>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							UserSave.hasCharacterBeenSeen = (Dictionary<Characters.CharacterId, bool>)1;
							nint num53 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S0_v94 (Il2CppClass<UIScreenController>)+BA]");
							object obj37 = (nint)0 & (nint)0x200;
							if (obj37 != null)
							{
								nint num54 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S0_v113 (Il2CppClass<UIScreenController>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							UIScreenController uIScreenController = UIScreenController.Instance;
							if ((object)uIScreenController != null)
							{
								nint num55 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ S0_v101 (Il2CppClass<UIScreenController>)+BA]");
								object obj38 = (nint)0 & (nint)0x200;
								if (obj38 != null)
								{
									nint num56 = (nint)typeof(UIScreenController);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S0_v109 (Il2CppClass<UIScreenController>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag7 = UIScreenController.ShouldShowOnlineScreen();
								((UIScreenController)flag7).DelayedHideInAppPurchaseOverlay();
								bool flag8 = UIScreenController.ShouldShowOnlineScreen();
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								text4.m_stringLength = 6;
								nint num57 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ S1_v44 (Il2CppClass<Strings>)+BA]");
								object obj39 = (nint)0 & (nint)0x200;
								if (obj39 != null)
								{
									nint num58 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ S1_v51 (Il2CppClass<Strings>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								object obj40 = text4 + 12;
								string text5 = Strings.GetDefault("INAPP_DATA_DOUBLE_COINS");
								obj40 = text5;
								((UIScreenController)flag8)._QueueMessage(text4);
							}
						}
						nint num59 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S0_v76 (Il2CppClass<Data.Save.UserSave>)+BA]");
						object obj41 = (nint)0 & (nint)0x200;
						if (obj41 != null)
						{
							nint num60 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S0_v83 (Il2CppClass<Data.Save.UserSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int inAppRestoredPurchaseCount9 = UserSave.inAppRestoredPurchaseCount;
						int inAppRestoredPurchaseCount10 = inAppRestoredPurchaseCount9 + 1;
						UserSave.inAppRestoredPurchaseCount = inAppRestoredPurchaseCount10;
					}
				}
			}
			goto IL_11c8;
			IL_11c8:
			nint num61 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S0_v29 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj42 = (nint)0 & (nint)0x200;
			if (obj42 != null)
			{
				nint num62 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ S0_v35 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveManager.Load();
			((InAppManager)null).NativePurchaseInappPack((string)1);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
	}

	public void NativePurchaseErrorForReviveWithKeys()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_purchaseHandler == null)
		{
			return;
		}
		nint num3 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v26 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_purchaseHandler.ResetOnFailedToPurchaseEventItemWithInapp();
		nint num5 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v23 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj3 = (nint)0 + (nint)12;
		obj3 = 0;
	}

	public void NativePurchaseInappPack(string message)
	{
		//IL_020e: Expected I, but got Obj
		//IL_0224: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I4
		//IL_01c0: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_015a: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v35 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).DelayedHideInAppPurchaseOverlay();
		}
		nint num5 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v14 (Il2CppClass<SaveMeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag2 = obj3 != null;
		if (message != null)
		{
			if (flag2)
			{
				nint num6 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v30 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveMeManager.HandleOnMenuScreenShown();
			return;
		}
		if (flag2)
		{
			nint num7 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v23 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.SendReviveIfPurchaseSucceeded();
	}

	public void NativePurchaseFail(string message)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0027: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_00cc: Expected I4, but got Obj
		//IL_0068: Expected I, but got Obj
		if (message != "0")
		{
			object obj = this + 52;
			obj = string.Empty;
			nint num = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v16 (Il2CppClass<SaveMeManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveMeManager.SendReviveIfPurchaseSucceeded();
		}
		else if (~(_productRequestSucceeded ? 1u : 0u) == 0)
		{
			InitFinishedCallback((byte)(int)_inAppPurchaseKey != 0);
		}
		else
		{
			object obj3 = this + 52;
			obj3 = string.Empty;
		}
	}

	public void BuyExpiredLimitedCharacter(string inappId, string characterName, PurchaseHandler sender)
	{
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I4
		//IL_014b: Expected I4, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_0102: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			bool isValidationSupportedOnCurrentPlatform = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
			((InAppPurchaseProvider)isValidationSupportedOnCurrentPlatform).ItemRestoredCallback(inappId, characterName, null);
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v10 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v19 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v25 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).ShowAdsOverlay();
		}
		RestoreRequestFinishedCallback((RestoreFinishedResult)inappId);
	}

	public unsafe void BuyExpiredLimitedBoard(string inappId, PurchaseHandler sender)
	{
		//IL_052f: Expected I, but got Obj
		//IL_0545: Expected Obj, but got I
		//IL_0570: Expected I, but got Obj
		//IL_0586: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_07ab: Expected I, but got Obj
		//IL_07c1: Expected Obj, but got I
		//IL_07de: Expected I, but got Obj
		//IL_03dd: Expected I, but got Obj
		//IL_0793: Expected Obj, but got I
		//IL_079c: Expected Obj, but got I4
		//IL_042a: Expected I, but got Obj
		//IL_0440: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_04b8: Expected I, but got Obj
		//IL_04e8: Expected I, but got Obj
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_072c: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_046b: Expected I, but got Obj
		//IL_05f5: Expected I, but got Obj
		//IL_060b: Expected Obj, but got I
		//IL_050e: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_0274: Expected I, but got Obj
		//IL_028a: Expected Obj, but got I
		//IL_065d: Expected Obj, but got I4
		//IL_065d: Expected I4, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_02b5: Expected I, but got Obj
		//IL_0302: Expected I, but got Obj
		//IL_0318: Expected Obj, but got I
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06b6: Expected I, but got Obj
		//IL_06cc: Expected Obj, but got I
		//IL_070f: Expected Obj, but got I4
		//IL_0343: Expected I, but got Obj
		//IL_0390: Expected I, but got Obj
		Boards.BoardId boardId = default;
		((Boards.BoardId*)(int)boardId)->value__ = 0;
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v151 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<int> allThemesForBoard = ((InAppItemModel)(object)inappId).GetAllThemesForBoard(boardId);
		if (allThemesForBoard != null)
		{
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v65 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v147 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!BoardManager.HasAllThemesBeenSeen((Boards.BoardId)((Boards.BoardId*)(int)boardId)->value__))
			{
				nint num5 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v73 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v143 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BoardManager.LockBoard((Boards.BoardId)((Boards.BoardId*)(int)boardId)->value__);
				nint num7 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v79 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v137 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (_purchaseHandler != null)
				{
					nint num9 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v124 (Il2CppClass<InApp.InAppManager>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num10 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v131 (Il2CppClass<InApp.InAppManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					_purchaseHandler.StartPurchaseBoardWithInapp((Boards.BoardId)inappId, (BoardSelectButton)((Boards.BoardId*)(int)boardId)->value__);
				}
				if (sender != null)
				{
					nint num11 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v89 (Il2CppClass<UIScreenController>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num12 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v119 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UIScreenController uIScreenController = UIScreenController.Instance;
					if ((object)uIScreenController != null)
					{
						nint num13 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v96 (Il2CppClass<Data.Save.UserSave>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num14 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v115 (Il2CppClass<Data.Save.UserSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Dictionary<string, string> inAppPurchaseHistory = UserSave.inAppPurchaseHistory;
						Dictionary<string, string> inAppPurchaseHistory2 = (Dictionary<string, string>)(inAppPurchaseHistory + 1);
						UserSave.inAppPurchaseHistory = inAppPurchaseHistory2;
						nint num15 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v104 (Il2CppClass<BoardScreenManager>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num16 = (nint)typeof(BoardScreenManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v111 (Il2CppClass<BoardScreenManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						HoverboardModelPreviewFactory hoverboardModelPreviewFactory = HoverboardModelPreviewFactory.Instance;
						((UnityEngine.Object)hoverboardModelPreviewFactory).m_CachedPtr = (IntPtr)1;
						LogError(null, (UnityEngine.Object)((Boards.BoardId*)(int)boardId)->value__);
					}
				}
			}
		}
		nint num17 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v18 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num18 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v56 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_purchaseHandler != null)
		{
			nint num19 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v42 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num20 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v50 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj11 = _purchaseHandler + 16;
			obj11 = 0;
		}
		nint num21 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v27 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		bool flag = obj12 == null;
		nint num22 = (nint)typeof(InAppManager);
		if (!flag)
		{
			nint num23 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v35 (Il2CppClass<InApp.InAppManager>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num22 = (nint)typeof(InAppManager);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num22 = (nint)typeof(InAppManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ L0_v7 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj13 = (nint)0 + (nint)12;
		obj13 = 0;
	}

	private void DeliverBundle(string bundleId, bool unlockedByRestore)
	{
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_00e6: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_009f: Expected I4, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(InAppManager);
		if (!flag)
		{
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<InApp.InAppManager>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(InAppManager);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(InAppManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L3_v2 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = unlockedByRestore;
		if (bundleId != null && bundleId.m_stringLength != 0)
		{
			InitFinishedCallback((byte)(int)bundleId != 0);
		}
	}

	private void ShowSlideInForBoard(Boards.BoardId boardId)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		object obj = this + 52;
		obj = string.Empty;
		if ((string)boardId != "0")
		{
			((InAppManager)null).NativePurchaseInappPack((string)null);
		}
	}

	public void SuggestInAppPopup(int cost, string senderName, InAppItemModel.ItemType type)
	{
		//IL_00b6: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(InAppManager);
		if (!flag)
		{
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<InApp.InAppManager>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(InAppManager);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(InAppManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L2_v2 (Il2CppClass<InApp.InAppManager>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = type;
		bool flag4;
		if (cost != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cost @ L1 (System.Int32)+8]");
			flag4 = (nint)0 == 0;
		}
		else
		{
			flag4 = true;
		}
		if (!flag4)
		{
			InitFinishedCallback((byte)cost != 0);
		}
	}

	private static bool IsDiscountActive(string onlineSettingsId)
	{
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_00e7: Expected I4, but got Obj
		//IL_00f6: Expected I4, but got Obj
		//IL_0105: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0070: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v20 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((InAppManager)null).ProductInfoRequestCallback((byte)(int)stringBuilder != 0, (ProductRequestResultInfo[])(object)SEGMENT_0A8ASDF7EWF);
		((InAppManager)null).ProductInfoRequestCallback((byte)(int)stringBuilder != 0, (ProductRequestResultInfo[])(object)SEGMENT_78S9H5S6D78);
		((InAppManager)null).ProductInfoRequestCallback((byte)(int)stringBuilder != 0, (ProductRequestResultInfo[])(object)SEGMENT_8907SDFGF56);
		((InAppManager)null).ProductInfoRequestCallback((byte)(int)stringBuilder != 0, (ProductRequestResultInfo[])(object)SEGMENT_5S678DF5G6S);
		((InAppManager)null).ProductInfoRequestCallback((byte)(int)stringBuilder != 0, (ProductRequestResultInfo[])(object)SEGMENT_8865FHJ76FG);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	public static int GetDiscountValue(string onlineSettingsId, int defaultValue)
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		//IL_0217: Expected I, but got Obj
		//IL_022d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0258: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01d4: Expected I, but got Obj
		//IL_01ea: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item((string)defaultValue);
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v5 (Il2CppClass<InApp.InAppManager+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v42 (Il2CppClass<InApp.InAppManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_003C_003Ec._003C_003E9__96_0 == null)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v16 (Il2CppClass<InApp.InAppManager+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v36 (Il2CppClass<InApp.InAppManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			_ = 0;
			object obj5 = default;
			object obj4 = obj5 + 16;
			obj4 = _003C_003Ec._003C_003E9;
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v33 (Il2CppClass<InApp.InAppManager+<>c>)+5C]");
			object obj6 = (nint)0 + (nint)4;
			obj6 = obj5;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static Dictionary<string, InAppItemModel> GetActiveInAppOffers()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrintAllInappHistory();
		return (Dictionary<string, InAppItemModel>)(object)_instance;
	}

	public unsafe static double GetDiscountEndTime()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected VT, but got Unknown
		//IL_00a6: Expected I8, but got I4
		//IL_00a1: Expected native int or pointer, but got VT
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_00fd: Expected I8, but got VT
		//IL_00f8: Expected native int or pointer, but got VT
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0149: Expected Ref, but got VT
		//IL_005a: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		DateTime dateTime = (DateTime)(obj2 + 16);
		((DateTime*)(nint)dateTime)->dateData = 0uL;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v28 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime utcNow = DateTime.UtcNow;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)utcNow;
		object obj4 = obj2 + 8;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC87");
		obj2 = obj4;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
		formatProvider = (IFormatProvider)obj2;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num3;
		return (double)obj * 1E-07;
	}

	private string GetContactingStoreOverlayText()
	{
		//IL_018f: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0251: Expected I4, but got Obj
		//IL_0251: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_013d: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I4
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ENABLE_SALES ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v29 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v39 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v5 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v6+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v7+44]");
			object obj5 = 0;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v6 (should have been resolved before IL gen)");
			object obj8 = default;
			if ((nint)obj8 > -1)
			{
				return (string)1;
			}
		}
		nint num6 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v17 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v24 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (string)(object)Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)this);
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_01e5: Expected I, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_013b: Expected I4, but got Obj
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 6;
		nint num3 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v7 (Il2CppClass<Info.Boards>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v28 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)context);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v17 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v24 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = text + 12;
		string text2 = Strings.GetDefault(board.name);
		obj4 = text2;
		((UIScreenController)flag)._QueueMessage(text);
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public InAppManagerPopupData GetPopupData()
	{
		//IL_01ef: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0230: Expected I, but got Obj
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_02b1: Expected I, but got Obj
		//IL_02c7: Expected Obj, but got I
		//IL_00bb: Expected I, but got Obj
		//IL_019d: Expected I, but got Obj
		//IL_012c: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if (dataPath != null)
		{
			object obj = dataPath - 7;
			if ((nint)obj > 1)
			{
				if ((nint)dataPath != 11)
				{
					return (InAppManagerPopupData)(object)"";
				}
				nint num = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v28 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v55 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool iOSOtherAudioPlaying = DeviceUtility.GetIOSOtherAudioPlaying();
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v11 (Il2CppClass<Strings>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag = obj3 == null;
				if (iOSOtherAudioPlaying)
				{
					if (!flag)
					{
						nint num4 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v51 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return (InAppManagerPopupData)(object)Strings.GetDefault("INAPP_MANAGER_OVERLAY_TEXT_AMAZONSTORE");
				}
				if (!flag)
				{
					nint num5 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v41 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (InAppManagerPopupData)(object)Strings.GetDefault("INAPP_MANAGER_OVERLAY_TEXT_GOOGLEPLAY");
			}
		}
		nint num6 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (InAppManagerPopupData)(object)Strings.GetDefault("INAPP_MANAGER_OVERLAY_TEXT_APPSTORE");
	}

	public void SetPopupData(InAppManagerPopupData popupData)
	{
	}

	public void DeletePopupData()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.SendReviveIfPurchaseSucceeded();
	}

	private void UpdateLastPurchasedBundle()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 60;
		obj = 0;
	}

	public static bool TryAddTransactionToHistory(string orderId, string itemId)
	{
		//IL_020f: Expected I, but got Obj
		//IL_0225: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02f7: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_0258: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v59 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ENABLE_SALES ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v29 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v53 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v5 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v6+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v7+44]");
			object obj5 = 0;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S3_v7 (should have been resolved before IL gen)");
			object obj8 = default;
			if ((nint)obj8 > -1)
			{
				nint num6 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v39 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num7 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v47 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (byte)_debugDiscount.get_Item(orderId) != 0;
			}
		}
		nint num8 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v17 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num9 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v24 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (byte)((OnlineSettings)(object)saveDataPath).GetValue(orderId, (uint)(int)itemId) != 0;
	}

	public static bool RemoveTransactionFromHistory(string orderId)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [orderId @ L0 (System.String)+3C]");
		return false;
	}

	public static bool HasTransactionHistoryItemId(string itemId)
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isFreshInstall = UserSave.isFreshInstall;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isFreshInstall2 = UserSave.isFreshInstall;
			bool flag = ((Dictionary<string, string>)isFreshInstall2).Remove(itemId);
			return true;
		}
		return false;
	}

	public static bool IsTransactionInHistory(string orderId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02dd: Expected Obj, but got I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_0307: Expected I, but got Obj
		//IL_031d: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0192: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0126: Expected Obj, but got I4
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
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v114 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isFreshInstall = UserSave.isFreshInstall;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj8 != null)
				{
					object obj9 = obj5 + 4;
					object obj10 = obj9 + 1;
					obj9 = obj10;
					object obj11 = obj10 << 2;
					object obj12 = obj5 + obj11;
					obj12 = 75;
					break;
				}
				continue;
			}
			object obj13 = obj5 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj5 + obj15;
			obj16 = 75;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj5 + obj17;
			if ((nint)obj18 == 75)
			{
				object obj19 = obj5 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_03de;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03de;
		IL_03de:
		return true;
	}

	public static void PrintAllInappHistory()
	{
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_02af: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0153: Expected I4, but got Obj
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_01f4: Expected VT, but got I4
		//IL_01f4: Expected Obj, but got I4
		//IL_01a2: Expected I, but got Obj
		//IL_020f: Expected Obj, but got I4
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v50 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_instance != null))
		{
			return;
		}
		nint num5 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v44 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_applicationIsQuiting ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)stream, (byte)(int)"InAppManager" != 0);
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)stream).Exec();
		InAppManager inAppManager = ((GameObject)(object)stream).AddComponent<InAppManager>();
		int layer = ((GameObject)(object)stream).layer;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)layer, HierarchyPathType.Dynamic, (Vector3)0);
		int layer2 = ((GameObject)(object)stream).layer;
		((HierarchyUtility)layer2)._002Ector();
	}

	static InAppManager()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isFreshInstall = UserSave.isFreshInstall;
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v9 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int[] array = Globals.convertAllStringToInt((string[])isFreshInstall);
	}
}
