using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class HoverboardOverlayHelper : MonoBehaviour
{
	public Hoverboards.BoardType _cachedType;

	private int _placementIndex;

	private Transform _trackerTransform;

	private Camera _3DClipCam;

	private Camera _2DOverlayCam;

	private bool _hasInited;

	private Transform _cachedTransform;

	private Transform topOverlay;

	private Transform bottomOverlay;

	private Image newSprite;

	private Image limitedSprite;

	private Image SpriteHover;

	private Image ownedSprite;

	private Image selectedSprite;

	private Image trialSprite;

	private Image giftSprite;

	private Image eggHuntSprite;

	private Image eventSpriteBubble;

	private float _topOverlayMinX = 100f;

	private float _topOverlayMaxX;

	private float _currentDistFromCenter;

	private bool _dirtyDist = true;

	private bool _hasEventBeenTried;

	private Hoverboards.BoardType? _eventBoardType;

	private bool _eventFinished;

	public float currentDistFromCenter
	{
		set
		{
			if (value != _currentDistFromCenter)
			{
				_dirtyDist = true;
				_currentDistFromCenter = value;
			}
		}
	}

	private unsafe void OnEnable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(HoverboardOverlayHelper.SetEventSpriteState));
		SSEventsManagerController.OnSSEventStartedHandler += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(HoverboardOverlayHelper.DisableAllEventRelatedElements));
		SSEventsManagerController.OnSSEventFinishedHandler += action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(HoverboardOverlayHelper.SetEventSpriteState));
		UIScreenController.OnApplicationResumed += action3;
	}

	private unsafe void OnDisable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(HoverboardOverlayHelper.SetEventSpriteState));
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(HoverboardOverlayHelper.DisableAllEventRelatedElements));
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(HoverboardOverlayHelper.SetEventSpriteState));
		UIScreenController.OnApplicationResumed -= action3;
	}

	private void SetEventSpriteState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_018a: Expected VT, but got Obj
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = default;
		object obj4 = default;
		do
		{
			_ = 0;
			Hoverboards.BoardType? boardType = EventBoard();
			_eventBoardType = (Hoverboards.BoardType?)obj;
			bool eventFinished = (byte)((Nullable)_eventBoardType ^ 1) != 0;
			_eventFinished = eventFinished;
			SSEventsManagerController instance = SSEventsManagerController.instance;
			bool hasEventBeenTried = instance.HasTheCurrentEventBeenTried();
			_hasEventBeenTried = hasEventBeenTried;
			SSEventsManagerController instance2 = SSEventsManagerController.instance;
			IEventManager activeEventManager = instance2.GetActiveEventManager();
			if (~(_hasInited ? 1u : 0u) != 0 || _hasEventBeenTried)
			{
				break;
			}
			HoverboardManager instance3 = HoverboardManager.Instance;
			Hoverboards.BoardType currentlyShownHoverboard = instance3.GetCurrentlyShownHoverboard(HoverboardManager.ScreenContext.BoardScreen);
			if (currentlyShownHoverboard == _cachedType)
			{
				break;
			}
			_ = _eventBoardType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != (nint)_cachedType)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if ((nint)0 == 0 || activeEventManager == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			if ((nint)obj3 == 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		}
		while ((nint)obj4 == 6);
		eventSpriteBubble.enabled = true;
	}

	private void DisableAllEventRelatedElements()
	{
		_eventFinished = true;
		eventSpriteBubble.enabled = false;
		trialSprite.enabled = false;
	}

	public void SetUpHover(int id)
	{
		bool flag = _placementIndex == id;
		SpriteHover.enabled = flag;
	}

	public void Init(int index, Hoverboards.BoardType type, Transform transformToTrack, HoverboardSelectButton button)
	{
		_cachedType = type;
		_placementIndex = index;
		UIScreenController instance = UIScreenController.Instance;
		_3DClipCam = instance.Camera3DClip;
		UIScreenController instance2 = UIScreenController.Instance;
		_2DOverlayCam = instance2.CameraOverlay2dClipping;
		Transform cachedTransform = transform;
		_cachedTransform = cachedTransform;
		_trackerTransform = transformToTrack;
		_hasInited = true;
		RefreshBubbles(initialSetup: true);
	}

	public void RefreshBubbles(bool initialSetup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (!initialSetup)
		{
			SetEventSpriteState();
		}
		else
		{
			eventSpriteBubble.enabled = false;
		}
		bool flag = eventSpriteBubble.enabled;
		bool flag2 = false;
		if (!flag)
		{
			if (IsBoardFree(_cachedType))
			{
				bool flag3 = HoverboardStickerManager.IsHoverboardUnlocked(_cachedType);
				bool flag4 = !flag3;
				flag2 = true;
				if (flag4)
				{
					goto IL_00c8;
				}
			}
			flag2 = BoardHasFreeThemes(_cachedType);
		}
		goto IL_00c8;
		IL_00c8:
		giftSprite.enabled = flag2;
		bool flag5 = giftSprite.enabled;
		bool flag6 = false;
		if (!flag5)
		{
			bool flag7 = eventSpriteBubble.enabled;
			flag6 = false;
			if (!flag7)
			{
				Hoverboards.Board board = Hoverboards.boardData.get_Item(_cachedType);
				bool flag8 = (byte)(~(board.isNewInThisUpdate ? 1u : 0u)) != 0;
				flag6 = false;
				if (!flag8)
				{
					PlayerInfo instance = PlayerInfo.Instance;
					flag6 = false;
					if (!instance._isFreshInstall)
					{
						if (!HoverboardStickerManager.HasHoverboardBeenSeen(_cachedType))
						{
							goto IL_023d;
						}
						PlayerInfo instance2 = PlayerInfo.Instance;
						bool flag9 = instance2._hoverboardCustomizationData.DoesBoardHaveThemes(_cachedType);
						bool flag10 = !flag9;
						flag6 = false;
						if (!flag10)
						{
							PlayerInfo instance3 = PlayerInfo.Instance;
							bool flag11 = instance3._hoverboardCustomizationData.AreAllNewThemesSeenForBoard(_cachedType);
							flag6 = false;
							if (!flag11)
							{
								goto IL_023d;
							}
						}
					}
				}
			}
		}
		goto IL_042b;
		IL_042b:
		newSprite.enabled = flag6;
		if (_cachedType == Hoverboards.BoardType.chick)
		{
			bool flag12;
			if (HoverboardStickerManager.IsHoverboardUnlocked(Hoverboards.BoardType.chick))
			{
				flag12 = false;
			}
			else
			{
				bool flag13 = newSprite.enabled;
				flag12 = (byte)((flag13 ? 1u : 0u) ^ 1u) != 0;
			}
			eggHuntSprite.enabled = flag12;
			limitedSprite.enabled = false;
			return;
		}
		eggHuntSprite.enabled = false;
		Hoverboards.Board board2 = Hoverboards.boardData.get_Item(_cachedType);
		bool flag14 = (byte)(~(board2.hasOnlineTimeLimit ? 1u : 0u)) != 0;
		bool flag15 = false;
		if (!flag14)
		{
			bool flag16 = eventSpriteBubble.enabled;
			flag15 = false;
			if (!flag16)
			{
				bool flag17 = giftSprite.enabled;
				flag15 = false;
				if (!flag17)
				{
					bool flag18 = newSprite.enabled;
					flag15 = false;
					if (!flag18)
					{
						_ = _eventBoardType;
						Hoverboards.BoardType cachedType = _cachedType;
						Hoverboards.BoardType cachedType2 = _cachedType;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						if ((nint)cachedType2 == (nint)0)
						{
							flag15 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							if ((nint)0 != 0)
							{
								goto IL_0488;
							}
							cachedType = _cachedType;
						}
						bool flag19 = HoverboardStickerManager.IsHoverboardUnlocked(cachedType);
						bool flag20 = (byte)((flag19 ? 1u : 0u) ^ 1u) != 0;
						flag15 = flag20;
					}
				}
			}
		}
		goto IL_0488;
		IL_0488:
		limitedSprite.enabled = flag15;
		return;
		IL_023d:
		PlayerInfo instance4 = PlayerInfo.Instance;
		bool flag21 = instance4.IsHoverboardUnlocked(_cachedType);
		bool flag22 = (byte)((flag21 ? 1u : 0u) ^ 1u) != 0;
		flag6 = flag22;
		goto IL_042b;
	}

	private bool BoardHasFreeThemes(Hoverboards.BoardType boardType)
	{
		//IL_0074: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			Dictionary<Hoverboards.BoardType, List<HoverboardThemes.HoverboardTheme>> hoverboardCustomThemes = HoverboardThemes.hoverboardCustomThemes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			List<HoverboardThemes.HoverboardTheme> list = hoverboardCustomThemes.get_Item(Hoverboards.BoardType.normal);
			throw new ArgumentException();
		}
		return false;
	}

	private Hoverboards.BoardType? EventBoard()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I4
		//IL_00ce: Expected VT, but got Obj
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_00a9: Expected VT, but got I4
		//IL_00b2: Expected VT, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		obj = 0;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			bool flag = (nint)obj3 != 6;
			if ((nint)obj3 == 1)
			{
				flag = false;
			}
			if (!flag)
			{
				_ = 0;
				object obj4 = obj + 15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
				if ((nint)0 != 0)
				{
					Hoverboards.BoardType? boardType = (Hoverboards.BoardType?)(object)0;
					return (Hoverboards.BoardType?)(object)1;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		return (Hoverboards.BoardType?)obj;
	}

	public int GetIndex()
	{
		return _placementIndex;
	}

	public void SelectedInMenu()
	{
		if (!HoverboardStickerManager.HasHoverboardBeenSeen(_cachedType))
		{
			newSprite.enabled = false;
			if (_cachedType == Hoverboards.BoardType.chick)
			{
				eggHuntSprite.enabled = true;
			}
			PlayerInfo instance = PlayerInfo.Instance;
			instance.MarkHoverboardAsSeen(_cachedType);
		}
		if (limitedSprite.enabled)
		{
			limitedSprite.enabled = false;
		}
		if (giftSprite.enabled)
		{
			giftSprite.enabled = false;
		}
		if (eventSpriteBubble.enabled)
		{
			eventSpriteBubble.enabled = false;
		}
	}

	public Hoverboards.BoardType GetBoardType()
	{
		return _cachedType;
	}

	private void Update()
	{
		if (limitedSprite.enabled && HoverboardStickerManager.IsHoverboardUnlocked(_cachedType))
		{
			limitedSprite.enabled = false;
			eggHuntSprite.enabled = false;
		}
		if (!giftSprite.enabled)
		{
			return;
		}
		bool flag3;
		if (IsBoardFree(_cachedType))
		{
			bool flag = HoverboardStickerManager.IsHoverboardUnlocked(_cachedType);
			bool flag2 = !flag;
			flag3 = true;
			if (flag2)
			{
				goto IL_010c;
			}
		}
		flag3 = BoardHasFreeThemes(_cachedType);
		goto IL_010c;
		IL_010c:
		giftSprite.enabled = flag3;
	}

	public void UpdateSelected(bool select, bool active)
	{
		if (select)
		{
			BoardScreenManager instance = BoardScreenManager.Instance;
			instance.current = _cachedType;
		}
		selectedSprite.enabled = select;
		ownedSprite.enabled = active;
	}

	private bool IsBoardFree(Hoverboards.BoardType boardType)
	{
		//IL_00c2: Expected Obj, but got I4
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
		object obj = board.unlockType - 2;
		if (board.unlockType == PurchaseData.UnlockType.Coins)
		{
			goto IL_007c;
		}
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
					goto IL_007c;
				}
				result = false;
			}
		}
		goto IL_00e4;
		IL_00e4:
		return result;
		IL_007c:
		bool flag3 = board.price == 0;
		result = flag3;
		goto IL_00e4;
	}
}
