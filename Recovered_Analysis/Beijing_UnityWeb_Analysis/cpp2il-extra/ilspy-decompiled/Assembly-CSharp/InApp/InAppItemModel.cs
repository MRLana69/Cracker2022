using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.HTTP;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Subway;
using SYBO.Subway.Characters;
using UnityEngine;

namespace InApp;

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
		SkipMission,
		CharacterToken,
		Trophy,
		AdRemoval,
		CharacterSkip
	}

	public enum OfferType
	{
		Normal,
		Sale,
		Promotion
	}

	public class BundleItem
	{
		private ItemType type__BackingField;

		private int amount__BackingField;

		private bool isBoardTypeValid__BackingField;

		private bool isThemeIdentifierValid__BackingField;

		private Boards.BoardId _boardId;

		private HoverboardThemes.ThemeIdentifier _themeIdentifier;

		public ItemType type
		{
			get
			{
				//IL_000a: Expected I4, but got Obj
				return (ItemType)((IEnumerable)this).GetEnumerator();
			}
			private set
			{
				type__BackingField = value;
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				isBoardTypeValid__BackingField = hasShutdownStarted;
			}
		}

		public int amount
		{
			get
			{
				return (int)type__BackingField;
			}
			private set
			{
				type__BackingField = (ItemType)value;
			}
		}

		public bool isBoardTypeValid
		{
			get
			{
				return (byte)amount__BackingField != 0;
			}
			private set
			{
				amount__BackingField = (value ? 1 : 0);
			}
		}

		public bool isThemeIdentifierValid
		{
			get
			{
				return isBoardTypeValid__BackingField;
			}
			private set
			{
				isBoardTypeValid__BackingField = value;
			}
		}

		public Boards.BoardId boardId => isThemeIdentifierValid__BackingField ? Boards.BoardId.bouncer : Boards.BoardId.normal;

		public HoverboardThemes.ThemeIdentifier themeIdentifier
		{
			get
			{
				if (~(isBoardTypeValid__BackingField ? 1u : 0u) != 0)
				{
					((InAppManager)(object)"Invalid board type requested.").onProductRequestDone += null;
				}
				return (HoverboardThemes.ThemeIdentifier)_boardId;
			}
		}

		public BundleItem(ItemType type, int amount)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0026: Expected Obj, but got I4
			object obj = this + 8;
			obj = type;
			object obj2 = this + 12;
			obj2 = amount;
		}

		public BundleItem(ItemType type, Boards.BoardId boardId)
		{
			this.type__BackingField = type;
			amount__BackingField = (int)boardId;
		}

		public unsafe BundleItem(ItemType type, Boards.BoardId boardId, HoverboardThemes.ThemeIdentifier themeIdentifier)
		{
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected Obj, but got Unknown
			//IL_00b2: Expected Obj, but got I4
			//IL_00bf: Expected Obj, but got I4
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_00fa: Expected I, but got Obj
			//IL_0110: Expected Obj, but got I
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected Obj, but got Unknown
			//IL_017e: Expected Obj, but got I4
			//IL_018c: Expected I, but got Obj
			//IL_01a2: Expected Obj, but got I
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			object obj = this + 20;
			obj = type;
			object obj2 = ((Boards.BoardId*)(int)boardId)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L2 (Info.Boards+BoardId)+8]");
			_ = 0;
			object obj3 = this + 40;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v35 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = this + 12;
			bool isInstantiated = Game.IsInstantiated;
			obj5 = isInstantiated;
			nint num3 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v23 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(Character);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v31 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj7 = this + 16;
			CharacterRendering instance = CharacterRendering.Instance;
			obj7 = instance;
			HoverboardThemes.ThemeIdentifier themeIdentifier2 = themeIdentifier & HoverboardThemes.ThemeIdentifier.heroboardTheme01;
			_themeIdentifier = themeIdentifier2;
		}
	}

	public string displayName;

	public string displayText;

	public string itemId;

	public int payoutAmount;

	public bool isConsumable;

	public string icon;

	public string normalOfferId;

	public List<BundleItem> bundleContents;

	public ItemType itemType;

	public OfferType itemOfferType;

	private string _localizedPrize;

	public bool isValidated;

	public bool isDynamic;

	public string localizedPrice
	{
		get
		{
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Expected Obj, but got Unknown
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b4: Expected Obj, but got Unknown
			//IL_01a9: Expected Obj, but got I4
			//IL_01c5: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got I4
			//IL_01ef: Expected Obj, but got I4
			//IL_01fd: Expected Obj, but got I4
			//IL_020b: Expected Obj, but got I4
			//IL_01e1: Expected Obj, but got I4
			//IL_01b7: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 4;
			object obj3 = this - 1;
			if ((nint)this != 1)
			{
				if ((nint)obj3 != 1)
				{
					if ((nint)obj3 == 2)
					{
						return (string)10;
					}
					if ((nint)obj3 == 3)
					{
						return (string)16;
					}
					if ((nint)obj3 != 4)
					{
						if ((nint)obj3 == 5)
						{
							return (string)12;
						}
						if ((nint)obj3 == 6)
						{
							return (string)13;
						}
						if ((nint)obj3 == 7)
						{
							return (string)14;
						}
						if ((nint)obj3 != 8)
						{
							if ((nint)obj3 == 9)
							{
								return (string)15;
							}
							if ((nint)obj3 != 10 && (nint)obj3 != 11 && (nint)obj3 != 12 && (nint)obj3 != 13 && (nint)obj3 == 14)
							{
								return (string)11;
							}
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				obj = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
			return (string)9;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00b8: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected Obj, but got Unknown
			//IL_0105: Expected Obj, but got I
			//IL_011d: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5+8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v6+18]");
			obj2 = 0;
			object obj4 = this + 16;
			obj4 = value;
			object obj5 = this + 8;
			X509Certificate2Collection x509Certificate2Collection = TrustedRoots.LoadTrusted();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v12 (System.Security.Cryptography.X509Certificates.X509Certificate2Collection)+C]");
			object obj6 = (nint)0 + (nint)16;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v15+18]");
			obj5 = 0;
		}
	}

	public static ItemType GetItemTypeFromPowerup(UpgradeType upgradeType)
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		string dataPath = Application.dataPath;
		object obj = dataPath - 8;
		if ((nint)dataPath != 8)
		{
			if ((nint)obj == 1 || (nint)obj == 2 || (nint)obj != 3)
			{
				return ItemType.Undefined;
			}
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v26 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (DeviceUtility.GetIOSOtherAudioPlaying())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [upgradeType @ L0 (Info.UpgradeType)+3A]");
				return ((nint)0 != 0) ? ItemType.Character : ItemType.Undefined;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [upgradeType @ L0 (Info.UpgradeType)+38]");
			return ((nint)0 != 0) ? ItemType.Character : ItemType.Undefined;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [upgradeType @ L0 (Info.UpgradeType)+39]");
		return ((nint)0 != 0) ? ItemType.Character : ItemType.Undefined;
	}

	public void ConvertToPromotion(int payoutIncrement)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 48;
		obj = payoutIncrement;
	}

	public List<int> GetAllThemesForBoard(Boards.BoardId boardId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Expected Obj, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b32: Expected Obj, but got I4
		//IL_0b47: Expected Obj, but got I4
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Expected Obj, but got Unknown
		//IL_0b73: Expected I4, but got Obj
		//IL_0b73: Expected I4, but got Obj
		//IL_0b85: Expected I, but got Obj
		//IL_0b9b: Expected Obj, but got I
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
		string text = ((string)this).Remove((int)"com.kiloo.subwayboard.", (int)"");
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<System.Type>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v295 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		obj4 = typeof(Boards.BoardId);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		nint num3 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v255 (Il2CppClass<System.Enum>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v279 (Il2CppClass<System.Enum>)+74]");
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
			object obj14 = default;
			string text2 = (string)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj16 = default;
			object obj15 = obj16;
		}
		else
		{
			object obj15 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		List<int> result = default;
		return result;
	}

	public static InAppItemModel Clone(InAppItemModel objectToClone)
	{
		//IL_0025: Expected I, but got Obj
		//IL_003b: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		if (~(objectToClone.isValidated ? 1u : 0u) == 0)
		{
			return (InAppItemModel)(object)objectToClone._localizedPrize;
		}
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (InAppItemModel)(object)Strings.GetDefault("BUY_INAPP_NOPRICE_DEFAULT");
	}

	public override string ToString()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InAppManager.OnInitializeFinished onInitializeFinished = default;
		InAppManager.onInitializeFinished += onInitializeFinished;
		object obj = onInitializeFinished + 8;
		obj = displayName;
		object obj2 = onInitializeFinished + 12;
		obj2 = displayText;
		object obj3 = onInitializeFinished + 16;
		obj3 = itemId;
		((Delegate)onInitializeFinished).method = (IntPtr)payoutAmount;
		bool flag = isConsumable;
		((Delegate)onInitializeFinished).delegate_trampoline = (IntPtr)(flag ? 1 : 0);
		object obj4 = onInitializeFinished + 28;
		obj4 = icon;
		object obj5 = onInitializeFinished + 32;
		obj5 = normalOfferId;
		object obj6 = onInitializeFinished + 36;
		obj6 = bundleContents;
		((Delegate)onInitializeFinished).original_method_info = (MethodInfo)itemType;
		((Delegate)onInitializeFinished).data = (System.DelegateData)itemOfferType;
		object obj7 = onInitializeFinished + 48;
		InAppItemModel inAppItemModel = Clone(this);
		obj7 = inAppItemModel;
		bool flag2 = isValidated;
		((MulticastDelegate)onInitializeFinished).delegates = (Delegate[])flag2;
		bool flag3 = isDynamic;
		return (string)(object)onInitializeFinished;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+14]");
		object obj = context + 0;
		_ = 2;
	}

	public InAppItemModel()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
