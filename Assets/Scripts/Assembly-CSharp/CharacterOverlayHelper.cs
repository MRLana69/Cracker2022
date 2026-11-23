using System;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;
using UnityEngine.UI;

public class CharacterOverlayHelper : MonoBehaviour
{
	public Characters.CharacterType _cachedType;

	private int _cachedThemeIndex;

	private int _placementIndex;

	private Transform headTrack;

	private Transform feetTrack;

	private Image newSprite;

	private Image limitedSprite;

	private Image SpriteHover;

	private Image ownedSprite;

	private Image selectedSprite;

	private Image giftSprite;

	private Image eventSpriteBubble;

	private Characters.CharacterType? _eventCharType;

	public void Init(int index, Characters.CharacterType type, bool showSprite, int themeVersion = 0)
	{
		_cachedThemeIndex = themeVersion;
		_cachedType = type;
		_placementIndex = index;
		enableOverlay(showSprite);
		UpdateSelected();
	}

	public void ChangeThemeIndex(int id)
	{
		_cachedThemeIndex = id;
	}

	private unsafe void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005c: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Characters.CharacterType? characterType = EventCharacter();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_eventCharType = (Characters.CharacterType?)(object)0;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CharacterOverlayHelper.EnableEventRelatedElements));
		SSEventsManagerController.OnSSEventStartedHandler += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(CharacterOverlayHelper.EnableEventRelatedElements));
		SSEventsManagerController.OnSSEventFinishedHandler += action2;
	}

	private unsafe void OnDisable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CharacterOverlayHelper.EnableEventRelatedElements));
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(CharacterOverlayHelper.EnableEventRelatedElements));
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
	}

	private void EnableEventRelatedElements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Expected VT, but got I
		object obj = default;
		CharacterOverlayHelper characterOverlayHelper = (CharacterOverlayHelper)(obj - 16);
		Characters.CharacterType? characterType = characterOverlayHelper.EventCharacter();
		_eventCharType = (Characters.CharacterType?)(object)(nint)((UnityEngine.Object)characterOverlayHelper).m_CachedPtr;
		RefreshOverlay();
	}

	public int GetIndex()
	{
		return _placementIndex;
	}

	public Characters.CharacterType getCharacterType()
	{
		return _cachedType;
	}

	public void RefreshOverlay()
	{
		enableOverlay(showSprite: true);
	}

	public void SelectedInMenu()
	{
		if (!CharacterStickerManager.HasCharacterBeenSeen(_cachedType))
		{
			PlayerInfo instance = PlayerInfo.Instance;
			instance.MarkCharacterAsSeen(_cachedType);
		}
		if (limitedSprite.enabled)
		{
			limitedSprite.enabled = false;
		}
		if (giftSprite.enabled)
		{
			giftSprite.enabled = false;
		}
		if (newSprite.enabled)
		{
			newSprite.enabled = false;
		}
		if (eventSpriteBubble.enabled)
		{
			eventSpriteBubble.enabled = false;
		}
	}

	public void enableOverlay(bool showSprite)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0357: Expected Obj, but got I4
		//IL_038f: Expected I4, but got Obj
		//IL_00ec: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		obj = 0;
		if (!(eventSpriteBubble != null) || !(giftSprite != null) || !(newSprite != null) || !(limitedSprite != null))
		{
			return;
		}
		if (showSprite)
		{
			_ = _eventCharType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if ((nint)0 != 0)
			{
				obj = _eventCharType;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if ((nint)0 == (nint)_cachedType)
				{
					goto IL_0110;
				}
			}
		}
		eventSpriteBubble.enabled = (byte)(int)obj != 0;
		bool flag = !showSprite;
		bool flag2 = false;
		if (!flag)
		{
			goto IL_0110;
		}
		goto IL_014a;
		IL_0110:
		bool flag3 = eventSpriteBubble.enabled;
		flag2 = false;
		if (!flag3)
		{
			flag2 = CharacterStickerManager.HasCharacterFreeTheme(_cachedType);
		}
		goto IL_014a;
		IL_03b1:
		bool flag4;
		newSprite.enabled = flag4;
		bool flag5 = !showSprite;
		bool flag6 = false;
		if (!flag5)
		{
			bool flag7 = eventSpriteBubble.enabled;
			flag6 = false;
			if (!flag7)
			{
				bool flag8 = giftSprite.enabled;
				flag6 = false;
				if (!flag8)
				{
					bool flag9 = newSprite.enabled;
					flag6 = false;
					if (!flag9)
					{
						Characters.Model model = Characters.characterData.get_Item(_cachedType);
						bool flag10 = (byte)(~(model.hasOnlineSettings ? 1u : 0u)) != 0;
						flag6 = false;
						if (!flag10)
						{
							bool flag11 = CharacterStickerManager.IsCharacterUnlocked(_cachedType);
							flag6 = (byte)((flag11 ? 1u : 0u) ^ 1u) != 0;
						}
					}
				}
			}
		}
		limitedSprite.enabled = flag6;
		return;
		IL_014a:
		giftSprite.enabled = flag2;
		bool flag12 = !showSprite;
		flag4 = false;
		if (!flag12)
		{
			bool flag13 = giftSprite.enabled;
			flag4 = false;
			if (!flag13)
			{
				bool flag14 = eventSpriteBubble.enabled;
				flag4 = false;
				if (!flag14)
				{
					PlayerInfo instance = PlayerInfo.Instance;
					flag4 = false;
					if (!instance._isFreshInstall)
					{
						if (!CharacterStickerManager.HasCharacterBeenSeen(_cachedType))
						{
							Characters.Model model2 = Characters.characterData.get_Item(_cachedType);
							flag4 = true;
							if (model2.isNewInThisUpdate)
							{
								goto IL_03b1;
							}
						}
						bool flag15 = CharacterStickerManager.HasCharacterNewTheme(_cachedType);
						flag4 = flag15;
					}
				}
			}
		}
		goto IL_03b1;
	}

	public Characters.CharacterType GetCharacterType()
	{
		return _cachedType;
	}

	public int GetCharacterThemeIndex()
	{
		return _cachedThemeIndex;
	}

	private Characters.CharacterType? EventCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_0132: Expected VT, but got Obj
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_010d: Expected VT, but got I4
		//IL_0116: Expected VT, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		obj = 0;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = default;
			object obj3 = obj4 - 3;
			if ((nint)obj4 == 3 || ((nint)obj3 != 1 && (nint)obj3 != 2 && (nint)obj3 != 3 && (nint)obj3 == 4))
			{
				_ = 0;
				object obj5 = obj + 15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
				if ((nint)0 != 0)
				{
					Characters.CharacterType? characterType = (Characters.CharacterType?)(object)0;
					return (Characters.CharacterType?)(object)1;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		return (Characters.CharacterType?)obj;
	}

	private void Update()
	{
		UpdateSelected();
		if (limitedSprite.enabled && CharacterStickerManager.IsCharacterUnlocked(_cachedType))
		{
			limitedSprite.enabled = false;
		}
	}

	private void UpdateSelected()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = instance._currentCharacter == (int)_cachedType;
		selectedSprite.enabled = flag;
		bool flag2 = !selectedSprite.enabled && CharacterStickerManager.IsCharacterUnlocked(_cachedType);
		ownedSprite.enabled = flag2;
		bool flag3 = _placementIndex == _cachedThemeIndex;
		SpriteHover.enabled = flag3;
	}

	private void LateUpdate()
	{
	}
}
