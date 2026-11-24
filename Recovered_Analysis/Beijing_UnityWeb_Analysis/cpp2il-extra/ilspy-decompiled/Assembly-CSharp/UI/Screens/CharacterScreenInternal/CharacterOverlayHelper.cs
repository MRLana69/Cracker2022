using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.DebugUtil;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using SYBO.Subway.Info;
using UnityEngine;

namespace UI.Screens.CharacterScreenInternal;

public class CharacterOverlayHelper : MonoBehaviour
{
	private Characters.CharacterId _cachedType;

	private int _placementIndex;

	private Camera _3DClipCam;

	private Camera _2DOverlayCam;

	private bool _hasInited;

	private Transform _cachedTransform;

	private Transform _headTransform;

	private Transform _chestTransform;

	private Transform _headTrack;

	private float _xOffset;

	private float _yOffset;

	private UISprite _newBubble;

	private UISprite _limitedBubble;

	private UISprite _limitedIcon;

	private UISprite _giftBubble;

	private UISprite _eventBubble;

	private UISprite _collectBubble;

	private Transform _feetTrack;

	private UISprite _ownedSprite;

	private UISprite _selectedSprite;

	private Characters.CharacterId? _eventCharType;

	public void Init(int index, Characters.CharacterId type, Transform transformToTrack, bool selected, int themeVersion = 0)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_0160: Expected I4, but got Obj
		//IL_0160: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_005f: Expected I, but got Obj
		_cachedType = (Characters.CharacterId)index;
		_placementIndex = (int)type;
		_3DClipCam = (Camera)(object)transformToTrack;
		object obj = this + 8;
		obj = selected;
		int num = themeVersion & 1;
		_2DOverlayCam = (Camera)num;
		_hasInited = true;
		if ((object)_2DOverlayCam != null)
		{
			OnEnable();
			return;
		}
		nint num2 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string assetBundlesCachePath = AssetBundleManager.GetAssetBundlesCachePath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		bool flag = default;
		object obj3 = (flag ? 1 : 0) + 16;
		obj3 = this;
		((CharacterCustomization)(object)assetBundlesCachePath).BuildProp((CharacterCustomizationBundle.OutfitInfo)_cachedType, (CharacterRig)_placementIndex, flag, (byte)(int)this != 0);
	}

	private void OnEnable()
	{
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_hasInited = true;
		nint num = (nint)typeof(CharacterModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<CharacterModelPreviewFactory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v13 (Il2CppClass<CharacterModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardScreenManager instance = BoardScreenManager.Instance;
		object obj2 = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private unsafe void OnDisable()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0081: Expected VT, but got Obj
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		CharacterThemeButton characterThemeButton = default;
		characterThemeButton.themeIndex = 0;
		object obj = characterThemeButton + 8;
		obj = characterThemeButton;
		_eventCharType = (Characters.CharacterId?)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CharacterOverlayHelper.EnableEventRelatedElements);
		object obj2 = action + 16;
		obj2 = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v32 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(CharacterOverlayHelper.EnableEventRelatedElements);
		object obj4 = action2 + 16;
		obj4 = this;
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
	}

	private unsafe void EnableEventRelatedElements()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CharacterOverlayHelper.EnableEventRelatedElements);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v24 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(CharacterOverlayHelper.EnableEventRelatedElements);
		object obj3 = action2 + 16;
		obj3 = this;
		SSEventsManagerController.OnSSEventChangedHandler += action2;
	}

	public int GetIndex()
	{
		return _hasInited ? 1 : 0;
	}

	public void RefreshOverlay()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_002e: Expected VT, but got Obj
		CharacterThemeButton characterThemeButton = default;
		characterThemeButton.themeIndex = 0;
		object obj = characterThemeButton + 8;
		obj = characterThemeButton;
		_eventCharType = (Characters.CharacterId?)obj;
		SelectedInMenu();
	}

	public void SelectedInMenu()
	{
		Characters.CharacterId? characterId = ((CharacterOverlayHelper)null).EventCharacter();
	}

	private void RefreshSelection(bool selected)
	{
	}

	public Characters.CharacterId GetCharacterType()
	{
		return (Characters.CharacterId)_placementIndex;
	}

	private Characters.CharacterId? EventCharacter()
	{
		//IL_0646: Expected Obj, but got I4
		//IL_0657: Expected Obj, but got I
		//IL_0676: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I4
		//IL_00ef: Expected I, but got Obj
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected Obj, but got Unknown
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I4
		//IL_0714: Expected I, but got Obj
		//IL_072a: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_01cd: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_02d7: Expected I, but got Obj
		//IL_02ed: Expected Obj, but got I
		//IL_027c: Expected I, but got Obj
		//IL_0318: Expected I, but got Obj
		//IL_0802: Expected I, but got Obj
		//IL_0818: Expected Obj, but got I
		//IL_04aa: Expected Obj, but got I4
		//IL_042c: Expected I, but got Obj
		//IL_039e: Expected I, but got Obj
		//IL_03b4: Expected Obj, but got I
		//IL_0858: Expected Obj, but got I
		//IL_087b: Expected Obj, but got I4
		//IL_088c: Expected Obj, but got I
		//IL_047c: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I4
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_04e9: Expected Obj, but got I4
		//IL_04fa: Expected Obj, but got I
		//IL_03df: Expected I, but got Obj
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected Obj, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_054a: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I4
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected Obj, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected Obj, but got Unknown
		//IL_08c1: Expected Obj, but got I4
		//IL_08d2: Expected Obj, but got I
		//IL_0586: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I4
		//IL_05c1: Expected VT, but got Obj
		//IL_05ca: Expected Obj, but got I4
		//IL_092e: Expected Obj, but got I4
		//IL_091b: Expected Obj, but got I4
		//IL_091b: Expected Obj, but got VT
		//IL_09fe: Expected VT, but got Obj
		//IL_0625: Expected VT, but got Obj
		//IL_0633: Expected Obj, but got I4
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+3C]");
		string text = ((Component)0).tag;
		((GameObject)(object)text).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+44]");
		string text2 = ((Component)0).tag;
		((GameObject)(object)text2).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+38]");
		string text3 = ((Component)0).tag;
		((GameObject)(object)text3).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+48]");
		string text4 = ((Component)0).tag;
		((GameObject)(object)text4).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+4C]");
		string text5 = ((Component)0).tag;
		((GameObject)(object)text5).tag = null;
		if ((object)this != null)
		{
			goto IL_0638;
		}
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v29 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v190 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, Characters.Model> characterData = Characters.characterData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
		Characters.Model model = characterData.get_Item(Characters.CharacterId.slick);
		object obj5;
		if (model.unlockType == PurchaseData.UnlockType.RewardForInApp)
		{
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v173 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v186 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.inAppLegacyPurchaseCount != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
				bool updateAutomatically = ((CoinBoxSizer)0).updateAutomatically;
				object obj4 = (updateAutomatically ? 1 : 0) ^ 1;
				obj5 = obj4 & 1;
			}
			else
			{
				obj5 = 0;
			}
		}
		else
		{
			obj5 = 0;
		}
		Characters.CharacterId? characterId = default;
		object obj6 = (Nullable)characterId + 92;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v43+4]");
		object obj8;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+5C]");
			obj = 0;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
			bool flag = obj7 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			bool flag2 = (nint)0 != 0;
			obj8 = flag & flag2;
		}
		else
		{
			obj8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
		bool flag3 = CharacterStickerManager.HasCharacterNewTheme(Characters.CharacterId.slick);
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v50 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v157 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4;
		if (UserSave.lastPurchasedBundle != InAppData.BundleTier.None)
		{
			flag4 = false;
		}
		else
		{
			nint num7 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v120 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v150 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Characters.CharacterId, Characters.Model> characterData2 = Characters.characterData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
			Characters.Model model2 = characterData2.get_Item(Characters.CharacterId.slick);
			if (~(model2.isNewInThisUpdate ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
				if (!CharacterStickerManager.IsCharacterUnlocked(Characters.CharacterId.slick))
				{
					nint num9 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v141 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num10 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v146 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
					bool flag5 = CharacterManager.IsCollectionComplete(Characters.CharacterId.slick);
					bool flag6 = !flag5;
					flag4 = true;
					if (flag6)
					{
						goto IL_07f4;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
			flag4 = CharacterStickerManager.HasCharacterBeenSeen(Characters.CharacterId.slick);
		}
		goto IL_07f4;
		IL_0638:
		return characterId;
		IL_07f4:
		nint num11 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v58 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num12 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v113 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, Characters.Model> characterData3 = Characters.characterData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
		Characters.Model model3 = characterData3.get_Item(Characters.CharacterId.slick);
		object obj14;
		if (~(model3.hasOnlineSettings ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
			bool updateAutomatically2 = ((CoinBoxSizer)0).updateAutomatically;
			object obj13 = (updateAutomatically2 ? 1 : 0) ^ 1;
			obj14 = obj13 & 1;
		}
		else
		{
			obj14 = 0;
		}
		bool flag7 = obj8 != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+4C]");
		string text6 = ((Component)0).tag;
		bool flag8 = obj5 != null;
		((GameObject)(object)text6).tag = (string)flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+48]");
		string text7 = ((Component)0).tag;
		object obj15 = obj5 ^ 1;
		object obj16 = obj8 & obj15;
		bool flag9 = obj16 != null;
		((GameObject)(object)text7).tag = (string)flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+44]");
		string text8 = ((Component)0).tag;
		object obj17 = obj8 | obj5;
		object obj18 = obj17 ^ 1;
		object obj19 = obj18 & flag3;
		bool flag10 = obj19 != null;
		((GameObject)(object)text8).tag = (string)flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+38]");
		string text9 = ((Component)0).tag;
		object obj20;
		if (flag8)
		{
			obj20 = 0;
		}
		else
		{
			object obj21 = flag7 | flag3;
			object obj22 = obj21 ^ 1;
			obj20 = obj22 & 1;
		}
		object obj23 = obj20 & flag4;
		bool flag11 = obj23 != null;
		((GameObject)(object)text9).tag = (string)flag11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+3C]");
		string text10 = ((Component)0).tag;
		object obj24;
		if (flag8)
		{
			characterId = (Characters.CharacterId?)(object)text10;
			obj24 = 0;
		}
		else
		{
			object obj25 = flag7 | flag3;
			string text11 = ((obj25 == null) ? null : text10);
			obj24 = (flag4 ? 1 : 0) ^ 1;
			bool flag12 = !flag3;
			bool flag13 = !flag12;
			string text12 = text11;
			if (!flag13)
			{
				text12 = text10;
			}
			bool flag14 = !flag7;
			bool flag15 = !flag14;
			characterId = (Characters.CharacterId?)(object)text10;
			if (!flag15)
			{
				characterId = (Characters.CharacterId?)(object)text12;
			}
			if (obj25 != null)
			{
				obj24 = 0;
			}
		}
		object obj26 = obj24 & obj14;
		bool flag16 = obj26 != null;
		((GameObject)characterId).tag = (string)flag16;
		goto IL_0638;
	}

	private void Update()
	{
		//IL_009d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		if (!CharacterStickerManager.IsCharacterUnlocked(_cachedType))
		{
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveGameDebug.lastLoadedSave = (string)_cachedType;
		}
		Characters.CharacterId? characterId = ((CharacterOverlayHelper)1).EventCharacter();
	}

	private void UpdateSelection()
	{
		//IL_004b: Expected Obj, but got I4
		LateUpdate();
		string text = _limitedBubble.tag;
		if (((GameObject)(object)text).activeInHierarchy && ((CoinBoxSizer)_cachedType).updateAutomatically)
		{
			string text2 = _limitedBubble.tag;
			((GameObject)(object)text2).tag = null;
		}
	}

	private void LateUpdate()
	{
		//IL_0024: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		bool flag = currentBoardId == (Boards.BoardId)_cachedType;
		bool updateAutomatically = ((CoinBoxSizer)_cachedType).updateAutomatically;
		string text = _selectedSprite.tag;
		((GameObject)(object)text).tag = (string)flag;
		string text2 = _ownedSprite.tag;
		object obj = (flag ? 1 : 0) ^ 1;
		string text3 = (string)(updateAutomatically & obj);
		((GameObject)(object)text2).tag = text3;
	}

	public unsafe CharacterOverlayHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got I4
		//IL_01e0: Expected VT, but got Obj
		//IL_01ef: Expected VT, but got Obj
		//IL_0203: Expected VT, but got Obj
		//IL_0240: Expected F4, but got Obj
		//IL_023b: Expected native int or pointer, but got VT
		//IL_0255: Expected F4, but got I
		//IL_0250: Expected native int or pointer, but got VT
		//IL_028f: Expected F4, but got Obj
		//IL_028a: Expected native int or pointer, but got VT
		//IL_02a4: Expected F4, but got I
		//IL_029f: Expected native int or pointer, but got VT
		//IL_02ed: Expected F4, but got Obj
		//IL_02e8: Expected native int or pointer, but got VT
		//IL_0302: Expected F4, but got I
		//IL_02fd: Expected native int or pointer, but got VT
		//IL_0313: Expected Ref, but got VT
		//IL_035e: Expected VT, but got Obj
		//IL_036c: Expected Obj, but got I4
		//IL_039e: Expected F4, but got Obj
		//IL_0399: Expected native int or pointer, but got VT
		//IL_03b3: Expected F4, but got I
		//IL_03ae: Expected native int or pointer, but got VT
		//IL_03bc: Expected Obj, but got VT
		//IL_03cf: Expected VT, but got Obj
		//IL_03e3: Expected VT, but got Obj
		//IL_03f2: Expected VT, but got Obj
		//IL_0410: Expected Obj, but got F4
		//IL_0434: Expected F4, but got Obj
		//IL_042f: Expected native int or pointer, but got VT
		//IL_0449: Expected F4, but got I
		//IL_0444: Expected native int or pointer, but got VT
		//IL_047e: Expected F4, but got Obj
		//IL_0479: Expected native int or pointer, but got VT
		//IL_0493: Expected F4, but got I
		//IL_048e: Expected native int or pointer, but got VT
		//IL_04dc: Expected F4, but got Obj
		//IL_04d7: Expected native int or pointer, but got VT
		//IL_04f1: Expected F4, but got I
		//IL_04ec: Expected native int or pointer, but got VT
		//IL_0502: Expected Ref, but got VT
		//IL_053a: Expected VT, but got Obj
		//IL_0549: Expected VT, but got Obj
		//IL_0566: Expected Obj, but got F4
		//IL_059a: Expected F4, but got Obj
		//IL_0595: Expected native int or pointer, but got VT
		//IL_05af: Expected F4, but got I
		//IL_05aa: Expected native int or pointer, but got VT
		//IL_05b8: Expected Obj, but got VT
		Transform transform = default;
		Vector3 vector = (Vector3)(transform + 300);
		Transform transform2 = (Transform)(transform + 216);
		Transform transform3 = (Transform)(transform + 204);
		Transform transform4 = (Transform)(transform + 192);
		object obj = transform + 180;
		object obj2 = transform + 168;
		Transform transform5 = (Transform)(transform + 156);
		object obj3 = transform + 144;
		object obj4 = transform + 132;
		Transform transform6 = (Transform)(transform + 120);
		object obj5 = transform + 108;
		Transform transform7 = (Transform)(transform + 96);
		Transform transform8 = (Transform)(transform + 84);
		Transform transform9 = (Transform)(transform + 72);
		object obj6 = transform + 60;
		object obj7 = transform + 48;
		Transform transform10 = (Transform)(transform + 36);
		object obj8 = transform + 24;
		Transform transform11 = (Transform)(transform + 12);
		object obj9 = transform + 288;
		obj9 = 0;
		_ = 0;
		object obj10 = transform + 276;
		obj10 = 0;
		_ = 0;
		object obj11 = transform + 264;
		obj11 = 0;
		_ = 0;
		object obj12 = transform + 252;
		obj12 = 0;
		_ = 0;
		object obj13 = transform + 240;
		obj13 = 0;
		_ = 0;
		object obj14 = transform + 228;
		obj14 = 0;
		_ = 0;
		if (~(_hasInited ? 1u : 0u) == 0)
		{
			transform2.position = (Vector3)_chestTransform;
			transform3.position = (Vector3)_headTransform;
			transform4.position = (Vector3)_chestTransform;
			obj9 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (UnityEngine.Transform)+4]");
			float num = 0f * _yOffset;
			_ = ((UnityEngine.Object)transform4).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v43+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = _3DClipCam.WorldToViewportPoint(vector);
			obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v46+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector3 = _2DOverlayCam.ScreenToViewportPoint(vector);
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15+8]");
			_ = 0;
			Transform parentInternal = _cachedTransform.parentInternal;
			((Vector3*)(nint)vector)->x = (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
			((Vector3*)(nint)vector)->z = 0f;
			transform5.Internal_LookAt_Injected(ref *(Vector3*)parentInternal, ref *(Vector3*)vector);
			obj11 = transform5;
			_ = ((UnityEngine.Object)transform5).m_CachedPtr;
			obj3 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
			_ = 0;
			obj4 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
			_ = 0;
			transform6.localPosition = (Vector3)_cachedTransform;
			obj5 = 0;
			_ = 0;
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform6).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v25+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 eulerAngles = ((Transform)vector).eulerAngles;
			transform7.position = (Vector3)_chestTransform;
			transform8.position = (Vector3)_chestTransform;
			transform9.position = (Vector3)_chestTransform;
			float num2 = (float)transform7 * _xOffset;
			obj12 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v29 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform9).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v52+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector4 = _3DClipCam.WorldToViewportPoint(vector);
			obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v33+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector5 = _2DOverlayCam.ScreenToViewportPoint(vector);
			obj14 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v35+8]");
			_ = 0;
			Transform parentInternal2 = _cachedTransform.parentInternal;
			((Vector3*)(nint)vector)->x = (float)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+8]");
			((Vector3*)(nint)vector)->z = 0f;
			transform10.Internal_LookAt_Injected(ref *(Vector3*)parentInternal2, ref *(Vector3*)vector);
			obj14 = transform10;
			_ = ((UnityEngine.Object)transform10).m_CachedPtr;
			obj8 = transform10;
			_ = ((UnityEngine.Object)transform10).m_CachedPtr;
			transform11.localPosition = (Vector3)_cachedTransform;
			transform.localPosition = (Vector3)_cachedTransform;
			float num3 = (float)obj8 + 20f;
			obj14 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v41 (UnityEngine.Transform)+4]");
			float num4 = 0f + 100f;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 eulerAngles2 = ((Transform)vector).eulerAngles;
		}
	}
}
