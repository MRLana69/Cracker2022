using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using InAppPurchase;
using Kiloo.Common.Backend.PurchaseValidation;
using UI.Screens;
using UnityEngine;

public class BundlePurchaseButton : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<InAppItemModel.BundleItem> _003C_003E9__24_0;

		public static Predicate<InAppItemModel.BundleItem> _003C_003E9__24_1;

		public static Predicate<InAppItemModel.BundleItem> _003C_003E9__24_2;

		public static Predicate<InAppItemModel.BundleItem> _003C_003E9__24_3;

		public static Predicate<InAppItemModel.BundleItem> _003C_003E9__24_4;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SocialManagerIOS._003C_003Ec obj = default;
			SocialManagerIOS._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal bool _003CUpdateButton_003Eb__24_0(InAppItemModel.BundleItem x)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v7+8]");
				if ((nint)0 == 2)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
				if ((nint)0 == 1)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16+8]");
				if ((nint)0 == 4)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v20+8]");
				if ((nint)0 == 5)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v24+8]");
				if ((nint)0 == 6)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v28+8]");
				if ((nint)0 == 7)
				{
					return true;
				}
				return true;
			}
			return true;
		}

		internal bool _003CUpdateButton_003Eb__24_1(InAppItemModel.BundleItem x)
		{
			return x.type__BackingField == InAppItemModel.ItemType.Coins;
		}

		internal bool _003CUpdateButton_003Eb__24_2(InAppItemModel.BundleItem x)
		{
			return x.type__BackingField == InAppItemModel.ItemType.Hoverboards;
		}

		internal bool _003CUpdateButton_003Eb__24_3(InAppItemModel.BundleItem x)
		{
			return x.type__BackingField == InAppItemModel.ItemType.Keys;
		}

		internal bool _003CUpdateButton_003Eb__24_4(InAppItemModel.BundleItem x)
		{
			return x.type__BackingField == InAppItemModel.ItemType.Headstarts;
		}
	}

	private GameObject activeButtonContents;

	private GameObject inactiveButtonContents;

	private UILabel titleLabel;

	private UILabel priceLabel;

	private UISprite bundle1Icon;

	private UISprite bundle2Icon;

	private UISprite bundle3Icon;

	private UISprite bundle4Icon;

	private UISprite bundle5Icon;

	private BundleContentSlot coinsSlot;

	private BundleContentSlot hoverboardsSlot;

	private BundleContentSlot keysSlot;

	private BundleContentSlot headstartSlot;

	private BundleContentSlot scoreboosterSlot;

	private InAppData.BundleTier _lastPurchasedBundle;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void OnClick()
	{
		OnDisable();
		ShowBundleIcon();
	}

	private void InitializeButton()
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_00fb: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		bool visible = ((CelebrationBackgroundHelper)this).visible;
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v3 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S2_v9 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId((string)visible);
		((InAppManager)(object)activeInAppOffers).InitFinishedCallback((byte)(int)inAppOnlineSettingsId != 0);
		ShowBundleIcon();
	}

	private unsafe void OnDisable()
	{
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
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
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		InAppManager.OnProductRequestDone onProductRequestDone = default;
		((Delegate)onProductRequestDone).method_ptr = method_ptr;
		((Delegate)onProductRequestDone).method = (nint)__ldftn(BundlePurchaseButton.OnProductRequestDone);
		object obj2 = onProductRequestDone + 16;
		obj2 = this;
		((InAppManager)(object)activeInAppOffers).onProductRequestDone -= onProductRequestDone;
		Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
		((Delegate)onPurchaseSuccess).method_ptr = method_ptr2;
		((Delegate)onPurchaseSuccess).method = (nint)__ldftn(BundlePurchaseButton.OnPurchaseSuccess);
		object obj3 = onPurchaseSuccess + 16;
		obj3 = this;
		((InAppManager)(object)activeInAppOffers2).onPurchaseSuccess -= onPurchaseSuccess;
		Dictionary<string, InAppItemModel> activeInAppOffers3 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		InAppManager.OnPurchaseFailure onPurchaseFailure = default;
		((Delegate)onPurchaseFailure).method_ptr = method_ptr3;
		((Delegate)onPurchaseFailure).method = (nint)__ldftn(BundlePurchaseButton.OnPurchaseFailure);
		object obj4 = onPurchaseFailure + 16;
		obj4 = this;
		((InAppManager)(object)activeInAppOffers3).onPurchaseFailure -= onPurchaseFailure;
	}

	private unsafe void UpdatePrice()
	{
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)activeInAppOffers).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
			((Delegate)onPurchaseSuccess).method_ptr = method_ptr;
			((Delegate)onPurchaseSuccess).method = (nint)__ldftn(BundlePurchaseButton.OnProductRequestDone);
			object obj3 = onPurchaseSuccess + 16;
			obj3 = this;
			((InAppManager)(object)activeInAppOffers).onPurchaseSuccess += onPurchaseSuccess;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			InAppManager.OnPurchaseFailure onPurchaseFailure = default;
			((Delegate)onPurchaseFailure).method_ptr = method_ptr2;
			((Delegate)onPurchaseFailure).method = (nint)__ldftn(BundlePurchaseButton.OnPurchaseSuccess);
			object obj4 = onPurchaseFailure + 16;
			obj4 = this;
			((InAppManager)(object)activeInAppOffers).onPurchaseFailure += onPurchaseFailure;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			InAppManager.OnPurchaseCanceled onPurchaseCanceled = default;
			((Delegate)onPurchaseCanceled).method_ptr = method_ptr3;
			((Delegate)onPurchaseCanceled).method = (nint)__ldftn(BundlePurchaseButton.OnPurchaseFailure);
			object obj5 = onPurchaseCanceled + 16;
			obj5 = this;
			((InAppManager)(object)activeInAppOffers).onPurchaseCanceled += onPurchaseCanceled;
		}
	}

	private void OnProductRequestDone()
	{
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_0151: Expected I, but got Obj
		//IL_0167: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00bb: Expected I4, but got Obj
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
		bool hasPaidOutFacebookReward = UserSave.hasPaidOutFacebookReward;
		_lastPurchasedBundle = (hasPaidOutFacebookReward ? InAppData.BundleTier.BundleTier1 : InAppData.BundleTier.None);
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v15 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool visible = ((CelebrationBackgroundHelper)this).visible;
		string inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId((string)visible);
		InAppItemModel objectToClone = InAppData.inAppData.get_Item(inAppOnlineSettingsId);
		InAppItemModel inAppItemModel = InAppItemModel.Clone(objectToClone);
		priceLabel.fontSize = (int)inAppItemModel;
	}

	private void OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_008e: Expected Obj, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		object obj = this + 40;
		obj = wasRestored;
		object obj2 = this + 44;
		obj2 = validationResult;
		if (productId != null)
		{
			if ((nint)productId == 1)
			{
				((TopRunOfflineStateHelper)this).OnClick();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "No state found for " + text + ".";
			SDebug.LogFormat(msg, null);
		}
		else
		{
			((TopRunOfflineStateHelper)this).SetLoadingState();
		}
	}

	private unsafe void OnPurchaseFailure(string data, PurchaseResult ressult)
	{
		//IL_0092: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)data))
		{
			UIWidget.Pivot pivot = default;
			((UIWidget.Pivot*)(int)pivot)->value__ = ((PurchaseResult*)(int)ressult)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ressult @ L2 (InAppPurchase.PurchaseResult)+8]");
			_ = 0;
			((UIWidget)(object)data).rawPivot = pivot;
		}
	}

	private InAppData.BundleTier GetBundleToSell()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return InAppData.BundleTier.None;
	}

	private void UpdateButton()
	{
		OnProductRequestDone();
	}

	private void ShowActiveContents(bool active)
	{
		((UILabel)(object)activeButtonContents).fontSize = (active ? 1 : 0);
	}

	private void ShowBundleIcon()
	{
		//IL_097e: Expected I, but got Obj
		//IL_0994: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_09c4: Expected Obj, but got I4
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_00bc: Expected I, but got Obj
		//IL_0a00: Expected I4, but got Obj
		//IL_019d: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_014a: Expected I, but got Obj
		//IL_01de: Expected I, but got Obj
		//IL_022b: Expected I, but got Obj
		//IL_0241: Expected Obj, but got I
		//IL_0342: Expected I, but got Obj
		//IL_0358: Expected Obj, but got I
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Expected Obj, but got Unknown
		//IL_0a71: Expected I, but got Obj
		//IL_0a87: Expected Obj, but got I
		//IL_026c: Expected I, but got Obj
		//IL_0383: Expected I, but got Obj
		//IL_02ea: Expected Obj, but got I4
		//IL_03d0: Expected I, but got Obj
		//IL_03e6: Expected Obj, but got I
		//IL_02fe: Expected VT, but got Obj
		//IL_04e7: Expected I, but got Obj
		//IL_04fd: Expected Obj, but got I
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Expected Obj, but got Unknown
		//IL_0afa: Expected I, but got Obj
		//IL_0b10: Expected Obj, but got I
		//IL_0411: Expected I, but got Obj
		//IL_0528: Expected I, but got Obj
		//IL_048f: Expected Obj, but got I4
		//IL_0575: Expected I, but got Obj
		//IL_058b: Expected Obj, but got I
		//IL_04a3: Expected VT, but got Obj
		//IL_068c: Expected I, but got Obj
		//IL_06a2: Expected Obj, but got I
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected Obj, but got Unknown
		//IL_0b83: Expected I, but got Obj
		//IL_0b99: Expected Obj, but got I
		//IL_05b6: Expected I, but got Obj
		//IL_06cd: Expected I, but got Obj
		//IL_0634: Expected Obj, but got I4
		//IL_071a: Expected I, but got Obj
		//IL_0730: Expected Obj, but got I
		//IL_0648: Expected VT, but got Obj
		//IL_0817: Expected I, but got Obj
		//IL_082d: Expected Obj, but got I
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Expected Obj, but got Unknown
		//IL_0c0c: Expected I, but got Obj
		//IL_0c22: Expected Obj, but got I
		//IL_075b: Expected I, but got Obj
		//IL_0858: Expected I, but got Obj
		//IL_07bf: Expected Obj, but got I4
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected Obj, but got Unknown
		//IL_088b: Expected I, but got Obj
		//IL_08a1: Expected Obj, but got I
		//IL_07d3: Expected VT, but got Obj
		//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0c95: Expected I, but got Obj
		//IL_0cab: Expected Obj, but got I
		//IL_08cc: Expected I, but got Obj
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected Obj, but got Unknown
		//IL_0939: Expected Obj, but got I4
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got Unknown
		//IL_0958: Expected VT, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v339 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasPaidOutFacebookReward = UserSave.hasPaidOutFacebookReward;
		_lastPurchasedBundle = (hasPaidOutFacebookReward ? InAppData.BundleTier.BundleTier1 : InAppData.BundleTier.None);
		if (_lastPurchasedBundle == InAppData.BundleTier.BundleTier5)
		{
			((CelebrationBackgroundHelper)this).visible = false;
			return;
		}
		((CelebrationBackgroundHelper)this).visible = true;
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v332 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool visible = ((CelebrationBackgroundHelper)this).visible;
		string inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId((string)visible);
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(inAppOnlineSettingsId);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S2_v8 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S2_v53 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(inAppItemModel.displayName);
		titleLabel.fontSize = (int)text;
		this._002Ector();
		OnProductRequestDone();
		nint num7 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v32 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v326 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_003C_003Ec._003C_003E9__24_0 == null)
		{
			nint num9 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v300 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v320 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num11 = 0;
			_ = 0;
			object obj7 = default;
			object obj6 = obj7 + 16;
			obj6 = _003C_003Ec._003C_003E9;
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v317 (Il2CppClass<BundlePurchaseButton+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)4;
			obj8 = obj7;
		}
		NullReferenceException ex = new NullReferenceException();
		if (ex != null && (nint)((Exception)ex)._message >= 1)
		{
			string text2 = coinsSlot.tag;
			((GameObject)(object)text2).tag = (string)1;
			bool flag = ((CenterOnChild)null).CenterOnClosestChildAtPosition((Vector2)((Exception)ex)._message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
		}
		else
		{
			string text3 = coinsSlot.tag;
			((GameObject)(object)text3).tag = null;
		}
		nint num13 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v48 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v281 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_003C_003Ec._003C_003E9__24_1 == null)
		{
			nint num15 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v255 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num16 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v275 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num17 = 0;
			_ = 0;
			object obj12 = default;
			object obj11 = obj12 + 16;
			obj11 = _003C_003Ec._003C_003E9;
			nint num18 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v272 (Il2CppClass<BundlePurchaseButton+<>c>)+5C]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = obj12;
		}
		NullReferenceException ex2 = new NullReferenceException();
		if (ex2 != null && (nint)((Exception)ex2)._message >= 1)
		{
			string text4 = hoverboardsSlot.tag;
			((GameObject)(object)text4).tag = (string)1;
			bool flag2 = ((CenterOnChild)null).CenterOnClosestChildAtPosition((Vector2)((Exception)ex2)._message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
		}
		else
		{
			string text5 = hoverboardsSlot.tag;
			((GameObject)(object)text5).tag = null;
		}
		nint num19 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v64 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num20 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v236 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_003C_003Ec._003C_003E9__24_2 == null)
		{
			nint num21 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v210 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num22 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v230 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num23 = 0;
			_ = 0;
			object obj17 = default;
			object obj16 = obj17 + 16;
			obj16 = _003C_003Ec._003C_003E9;
			nint num24 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v227 (Il2CppClass<BundlePurchaseButton+<>c>)+5C]");
			object obj18 = (nint)0 + (nint)12;
			obj18 = obj17;
		}
		NullReferenceException ex3 = new NullReferenceException();
		if (ex3 != null && (nint)((Exception)ex3)._message >= 1)
		{
			string text6 = keysSlot.tag;
			((GameObject)(object)text6).tag = (string)1;
			bool flag3 = ((CenterOnChild)null).CenterOnClosestChildAtPosition((Vector2)((Exception)ex3)._message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
		}
		else
		{
			string text7 = keysSlot.tag;
			((GameObject)(object)text7).tag = null;
		}
		nint num25 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S0_v80 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num26 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v191 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_003C_003Ec._003C_003E9__24_3 == null)
		{
			nint num27 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v166 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num28 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S0_v186 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num29 = 0;
			_ = 0;
			object obj22 = default;
			object obj21 = obj22 + 16;
			obj21 = _003C_003Ec._003C_003E9;
			nint num30 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S0_v183 (Il2CppClass<BundlePurchaseButton+<>c>)+5C]");
			object obj23 = (nint)0 + (nint)16;
			obj23 = obj22;
		}
		NullReferenceException ex4 = new NullReferenceException();
		if (ex4 != null && (nint)((Exception)ex4)._message >= 1)
		{
			string text8 = headstartSlot.tag;
			((GameObject)(object)text8).tag = (string)1;
			bool flag4 = ((CenterOnChild)null).CenterOnClosestChildAtPosition((Vector2)((Exception)ex4)._message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
		}
		else
		{
			string text9 = headstartSlot.tag;
			((GameObject)(object)text9).tag = null;
		}
		nint num31 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ S0_v96 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num32 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S0_v148 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_003C_003Ec._003C_003E9__24_4 == null)
		{
			nint num33 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S0_v123 (Il2CppClass<BundlePurchaseButton+<>c>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num34 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v143 (Il2CppClass<BundlePurchaseButton+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num35 = 0;
			_ = 0;
			object obj27 = default;
			object obj26 = obj27 + 16;
			obj26 = _003C_003Ec._003C_003E9;
			nint num36 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S0_v140 (Il2CppClass<BundlePurchaseButton+<>c>)+5C]");
			object obj28 = (nint)0 + (nint)20;
			obj28 = obj27;
		}
		NullReferenceException ex5 = new NullReferenceException();
		if (ex5 != null && (nint)((Exception)ex5)._message >= 1)
		{
			object obj29 = this - -64;
			string text10 = ((Component)obj29).tag;
			((GameObject)(object)text10).tag = (string)1;
			object obj30 = this - -64;
			bool flag5 = ((CenterOnChild)null).CenterOnClosestChildAtPosition((Vector2)((Exception)ex5)._message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
		}
		else
		{
			object obj31 = this - -64;
			string text11 = ((Component)obj31).tag;
			((GameObject)(object)text11).tag = null;
		}
	}

	private string GetFormattedAmount(int amount)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = this;
		object obj2 = text + 20;
		obj2 = amount;
		return text;
	}

	public BundlePurchaseButton()
	{
		//IL_002d: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		string text = bundle1Icon.tag;
		bool flag = _lastPurchasedBundle == InAppData.BundleTier.None;
		((GameObject)(object)text).tag = (string)flag;
		string text2 = bundle2Icon.tag;
		bool flag2 = _lastPurchasedBundle == InAppData.BundleTier.BundleTier1;
		((GameObject)(object)text2).tag = (string)flag2;
		string text3 = bundle3Icon.tag;
		bool flag3 = _lastPurchasedBundle == InAppData.BundleTier.BundleTier2;
		((GameObject)(object)text3).tag = (string)flag3;
		string text4 = bundle4Icon.tag;
		bool flag4 = _lastPurchasedBundle == InAppData.BundleTier.BundleTier3;
		((GameObject)(object)text4).tag = (string)flag4;
		string text5 = bundle5Icon.tag;
		bool flag5 = _lastPurchasedBundle == InAppData.BundleTier.BundleTier4;
		((GameObject)(object)text5).tag = (string)flag5;
	}
}
