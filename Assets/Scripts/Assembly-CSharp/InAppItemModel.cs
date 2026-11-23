using System;
using System.Collections.Generic;
using Cpp2ILInjected;

public class InAppItemModel
{
	public enum ItemType
	{
		Undefined,
		Character,
		CharacterOutfit,
		Board,
		BoardAbility,
		Coins,
		Keys,
		Bundle,
		DoubleCoins,
		Hoverboards,
		Headstarts,
		Scoreboosters,
		Jetpack,
		SuperSneakers,
		CoinMagnet,
		DoubleMultiplier,
		Gachabox,
		SkipMission
	}

	public enum OfferType
	{
		Normal,
		Sale,
		Promotion
	}

	private static Dictionary<PowerupType, ItemType> _powerupTypeToItemTypeMap;

	private string _localizedPrize;

	private string DisplayName__BackingField;

	private string DisplayText__BackingField;

	private string ItemId__BackingField;

	private int PayoutAmount__BackingField;

	private bool IsConsumable__BackingField;

	private string StoreItemIdentifier__BackingField;

	private string Icon__BackingField;

	private string NormalOfferId__BackingField;

	private Dictionary<ItemType, int> BundleContents__BackingField;

	private ItemType InAppItemType__BackingField;

	private OfferType ItemOfferType__BackingField;

	private int CategoryOrderIndex__BackingField;

	private string StoreItemToken__BackingField;

	private bool IsValidated__BackingField;

	private bool IsDynamic__BackingField;

	public string DisplayName
	{
		get
		{
			return DisplayName__BackingField;
		}
		private set
		{
			DisplayName__BackingField = value;
		}
	}

	public string DisplayText
	{
		get
		{
			return DisplayText__BackingField;
		}
		private set
		{
			DisplayText__BackingField = value;
		}
	}

	public string ItemId
	{
		get
		{
			return ItemId__BackingField;
		}
		private set
		{
			ItemId__BackingField = value;
		}
	}

	public int PayoutAmount
	{
		get
		{
			return PayoutAmount__BackingField;
		}
		private set
		{
			PayoutAmount__BackingField = value;
		}
	}

	public bool IsConsumable
	{
		get
		{
			return IsConsumable__BackingField;
		}
		private set
		{
			IsConsumable__BackingField = value;
		}
	}

	public string StoreItemIdentifier
	{
		get
		{
			return StoreItemIdentifier__BackingField;
		}
		private set
		{
			StoreItemIdentifier__BackingField = value;
		}
	}

	public string Icon
	{
		get
		{
			return Icon__BackingField;
		}
		private set
		{
			Icon__BackingField = value;
		}
	}

	public string NormalOfferId
	{
		get
		{
			return NormalOfferId__BackingField;
		}
		private set
		{
			NormalOfferId__BackingField = value;
		}
	}

	public Dictionary<ItemType, int> BundleContents
	{
		get
		{
			return BundleContents__BackingField;
		}
		private set
		{
			BundleContents__BackingField = value;
		}
	}

	public ItemType InAppItemType
	{
		get
		{
			return InAppItemType__BackingField;
		}
		private set
		{
			InAppItemType__BackingField = value;
		}
	}

	public OfferType ItemOfferType
	{
		get
		{
			return ItemOfferType__BackingField;
		}
		private set
		{
			ItemOfferType__BackingField = value;
		}
	}

	public int CategoryOrderIndex
	{
		get
		{
			return CategoryOrderIndex__BackingField;
		}
		set
		{
			CategoryOrderIndex__BackingField = value;
		}
	}

	public string StoreItemToken
	{
		get
		{
			return StoreItemToken__BackingField;
		}
		set
		{
			StoreItemToken__BackingField = value;
		}
	}

	public string LocalizedPrice
	{
		get
		{
			if (~(IsValidated__BackingField ? 1u : 0u) == 0)
			{
				return _localizedPrize;
			}
			return Strings.Get(StringID.BUY_INAPP_NOPRICE_DEFAULT);
		}
		set
		{
			_localizedPrize = value;
		}
	}

	public bool IsValidated
	{
		get
		{
			return IsValidated__BackingField;
		}
		set
		{
			IsValidated__BackingField = value;
		}
	}

	public bool IsDynamic
	{
		get
		{
			return IsDynamic__BackingField;
		}
		set
		{
			IsDynamic__BackingField = value;
		}
	}

	private InAppItemModel()
	{
	}

	public InAppItemModel(string storeItemId, string storeItemToken, string itemId, string displayName, string displayText, string icon, int payoutAmount, bool isConsumable, ItemType itemType, OfferType offerType, Dictionary<ItemType, int> bundleContents = null, string normalOfferId = "")
	{
		DisplayName__BackingField = displayName;
		DisplayText__BackingField = displayText;
		ItemId__BackingField = itemId;
		StoreItemIdentifier__BackingField = storeItemId;
		IsConsumable__BackingField = isConsumable;
		PayoutAmount__BackingField = payoutAmount;
		Icon__BackingField = icon;
		NormalOfferId__BackingField = normalOfferId;
		StoreItemToken__BackingField = storeItemToken;
		ItemOfferType__BackingField = offerType;
		InAppItemType__BackingField = itemType;
		if (bundleContents != null)
		{
			BundleContents__BackingField = bundleContents;
		}
	}

	public InAppItemModel(string itemId, ItemType itemType)
	{
		ItemId__BackingField = itemId;
		PayoutAmount__BackingField = 1;
		InAppItemType__BackingField = itemType;
	}

	public unsafe static ItemType GetItemTypeFromPowerup(PowerupType powerupType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Ref, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (!_powerupTypeToItemTypeMap.TryGetValue(powerupType, out *(ItemType*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return ItemType.Undefined;
	}

	public void ConvertToPromotion(int payoutIncrement)
	{
		int num = payoutIncrement + PayoutAmount__BackingField;
		ItemOfferType__BackingField = OfferType.Promotion;
		PayoutAmount__BackingField = num;
	}

	public static InAppItemModel CreateEmpty()
	{
		InAppItemModel result = default;
		return result;
	}

	public static InAppItemModel Clone(InAppItemModel objectToClone)
	{
		InAppItemModel inAppItemModel = default;
		inAppItemModel.DisplayName__BackingField = objectToClone.DisplayName__BackingField;
		inAppItemModel.DisplayText__BackingField = objectToClone.DisplayText__BackingField;
		inAppItemModel.ItemId__BackingField = objectToClone.ItemId__BackingField;
		inAppItemModel.PayoutAmount__BackingField = objectToClone.PayoutAmount__BackingField;
		inAppItemModel.IsConsumable__BackingField = objectToClone.IsConsumable__BackingField;
		inAppItemModel.StoreItemIdentifier__BackingField = objectToClone.StoreItemIdentifier__BackingField;
		inAppItemModel.Icon__BackingField = objectToClone.Icon__BackingField;
		inAppItemModel.NormalOfferId__BackingField = objectToClone.NormalOfferId__BackingField;
		inAppItemModel.BundleContents__BackingField = objectToClone.BundleContents__BackingField;
		inAppItemModel.InAppItemType__BackingField = objectToClone.InAppItemType__BackingField;
		inAppItemModel.ItemOfferType__BackingField = objectToClone.ItemOfferType__BackingField;
		inAppItemModel.CategoryOrderIndex__BackingField = objectToClone.CategoryOrderIndex__BackingField;
		inAppItemModel.StoreItemToken__BackingField = objectToClone.StoreItemToken__BackingField;
		string localizedPrice = objectToClone.LocalizedPrice;
		inAppItemModel._localizedPrize = localizedPrice;
		inAppItemModel.IsValidated__BackingField = objectToClone.IsValidated__BackingField;
		inAppItemModel.IsDynamic__BackingField = objectToClone.IsDynamic__BackingField;
		return inAppItemModel;
	}

	public override string ToString()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	static InAppItemModel()
	{
		//IL_003f: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S5_v9+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S5_v14+4] (should have been resolved before IL gen)");
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S5_v19+4] (should have been resolved before IL gen)");
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v106 @ S5_v24+4] (should have been resolved before IL gen)");
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ S5_v29+4] (should have been resolved before IL gen)");
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v138 @ S5_v34+4] (should have been resolved before IL gen)");
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v154 @ S5_v39+4] (should have been resolved before IL gen)");
		nint num19 = 0;
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S5_v43 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ S5_v44+4] (should have been resolved before IL gen)");
		nint num21 = 0;
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S5_v48 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ S5_v49+4] (should have been resolved before IL gen)");
		nint num23 = 0;
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S5_v53 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, InAppItemModel+ItemType>>)+5C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ S5_v54+4] (should have been resolved before IL gen)");
		Dictionary<PowerupType, ItemType> powerupTypeToItemTypeMap = default;
		_powerupTypeToItemTypeMap = powerupTypeToItemTypeMap;
	}
}
