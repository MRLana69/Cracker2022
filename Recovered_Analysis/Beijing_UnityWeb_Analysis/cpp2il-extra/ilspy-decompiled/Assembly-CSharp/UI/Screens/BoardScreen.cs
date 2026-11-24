using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Data.Managers;
using InApp;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using SYBO.Components.Analytics;
using SYBO.Components.Utilities.Tickable;
using SYBO.Subway.Info;
using UI.Generic;
using UI.Popups.ConsumablesPopupInternal;
using UI.Popups.LimitedBoardPopupInternal;
using UI.Screens.BoardScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;
using WeeklyHunt;

namespace UI.Screens;

public class BoardScreen : UIScreen
{
	private class BoardState
	{
		public Quaternion defaultRotation;

		public GameObject boardRoot;

		public Transform boardTransform;

		public BoardState()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private sealed class _003CDelayedRefreshEventBoardAndUI_003Ed__50(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardScreen _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this.ShowHoverboardInScrollList();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDelayedInitCenterBoard_003Ed__62(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardScreen _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				//IL_0097: Expected I4, but got Obj
				//IL_00ae: Expected I, but got Obj
				//IL_00c4: Expected Obj, but got I
				//IL_0160: Expected I, but got Obj
				//IL_0176: Expected Obj, but got I
				//IL_00ef: Expected I, but got Obj
				//IL_0149: Expected Obj, but got I4
				//IL_01a1: Expected I, but got Obj
				BoardScreen boardScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						IEnumerator enumerator = ((CelebrationPopup)null).MoveNextBoxToFront();
						OverlayIndex overlayIndex = _003C_003E4__this.ElementToCenterOn(boardScreen.boardIndices, (Boards.BoardId)enumerator);
						nint num = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)overlayIndex).FindKernel((string)null) != 0)
						{
							GameObject gameObject = overlayIndex.gameObject;
							Vector2 vector = ((CoinBoxSizer)(object)gameObject).CalculateDistanceToBounds((UIWidget)1);
						}
						nint num3 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v29 (Il2CppClass<BoardScreenManager>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(BoardScreenManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v36 (Il2CppClass<BoardScreenManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
						((HoverboardBundle)(object)instance).Charactermodel = (CharacterModel)enumerator;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj4 = default;
				obj3 = obj4;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

		void IEnumerator.Reset()
		{
		}
	}

	private GameObject scrollAnchor;

	private UIGrid scrollGrid;

	private GameObject overlayParent;

	private UIPanel scrollPanel;

	private GameObject scroll2dElements;

	private GameObject _centerAnchor;

	private GameObject dummyObject;

	private UILabel nameLabel;

	private UILabel staticPowerupLabel;

	private UILabel descriptionLabel;

	private UISprite powerIcon;

	private UILabel themeLimitedLabel;

	private GameObject eventRibbon;

	private UILabel[] ribbonLabels;

	private GameObject _scrollHorizontalParent;

	public UIHoverboardThemeShifter _hoverboardThemeShifter;

	private GameObject _hoverboardSelectButtonPrefab;

	private AudioClip selectSound;

	private GameObject themePower;

	private UILabel themePowerStaticLabel;

	private UILabel themePowerLabel;

	private TimerHelper _timerPrefab;

	private UIWidget _timerContainer;

	private TimerHelper _timer;

	private bool _hasInited;

	private CenterOnChild _centerer;

	public BoardSelectButton _hoverboardSelectButton;

	private bool _refreshingThemeInScrollList;

	private SSEventType _cachedActiveEventType;

	private bool _hasSetupScroll;

	private float _cellWidth;

	private const float DEFAULT_SCALE_FACTOR = 7f;

	private const float FOCUSED_SCALE_FACTOR = 10f;

	private const int SCROLL_BOARD_VISIBILITY_COUNT = 4;

	private const int SCALE_MODEL_COUNT = 4;

	private const float SCALE_SCROLL_TOLERANCE = 1f;

	public List<KeyValuePair<Boards.BoardId, Boards.Board>> _boardList;

	private Quaternion[] _previousBoardQuaternions;

	private bool hasEnabledScrollElements;

	private float _cachedScaleScrollPosition;

	private float _cachedScrollPosition;

	private bool _hasSetiPhoneXOffsetsIfNecessary;

	private bool _refreshOnLastPopupClosed;

	private List<BoardState> scrollBoards;

	public List<HoverboardOverlayHelper> boardHelpers;

	public List<OverlayIndex> boardIndices;

	private bool _oldHoverboardOwned;

	private bool _inappOverlayActive;

	private bool _popupActive;

	private bool _modelsEnabled;

	public override void Init()
	{
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f0: Invalid comparison between I8 and VT
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0124: Expected I8, but got VT
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v25 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!CharacterManager.IsCharacterOwned(base._footerInited ? Characters.CharacterId.tricky : Characters.CharacterId.slick))
		{
			long boardBundleExpireTimestamp = ((BoardBundlePopupManager)(object)this).GetBoardBundleExpireTimestamp();
			TimeSpan timeLeft = ((BoardBundlePopupManager)(object)this).GetTimeLeft();
			long currentTimestamp = ((PromotionManager)null).GetCurrentTimestamp();
			CoroutineUtil.StopCoroutine((Coroutine)(object)screenName);
			CoroutineUtil.StopCoroutine((Coroutine)(object)base.parentScreen__BackingField);
			if (currentTimestamp < boardBundleExpireTimestamp)
			{
				object obj2 = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E4F");
				object obj3 = default;
				obj2 = obj3;
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)screenName);
			}
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)currentTimestamp) < System.Runtime.CompilerServices.Unsafe.As<TimeSpan, UIntPtr>(ref timeLeft))
			{
				object obj4 = this + 36;
				IEnumerator enumerator = ((PromotionManager)(object)this).StartTimer((long)timeLeft);
				obj4 = enumerator;
				Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)base.parentScreen__BackingField);
			}
		}
	}

	public override void Show()
	{
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_005c: Expected I, but got Obj
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_00e6: Expected I, but got Obj
		//IL_00fc: Expected Obj, but got I
		//IL_0127: Expected I, but got Obj
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_0369: Expected F4, but got I4
		//IL_0369: Expected Obj, but got I4
		//IL_0386: Expected F4, but got I4
		//IL_0386: Expected Obj, but got I4
		//IL_0244: Expected F4, but got I4
		//IL_0244: Expected Obj, but got I4
		//IL_01e8: Expected I, but got Obj
		ShowIfInactive();
		InitializeTimer();
		UIGrid uIGrid = scrollGrid;
		_cellWidth = uIGrid.cellWidth;
		object obj = this + 140;
		CenterOnChild component = scrollGrid.GetComponent<CenterOnChild>();
		obj = component;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v11 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v50 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		SSEventType cachedActiveEventType = default;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}
		else
		{
			cachedActiveEventType = SSEventType.None;
		}
		_cachedActiveEventType = cachedActiveEventType;
		UIHoverboardThemeShifter hoverboardThemeShifter = _hoverboardThemeShifter;
		hoverboardThemeShifter._context = BoardManager.ScreenContext.BoardScreen;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<int> action = default;
		object obj3 = action + 16;
		obj3 = this;
		_hoverboardThemeShifter.OnClickedTheme -= action;
		RefreshBoards();
		RefreshEventBoardAndUI();
		_hasInited = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
		nint num4 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v26 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v46 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice() || ~(_hasSetiPhoneXOffsetsIfNecessary ? 1u : 0u) == 0)
		{
			return;
		}
		int layer = scrollAnchor.layer;
		nint num6 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v35 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v53 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.OffsetLocalPosZ((Transform)layer, IPhoneXSupport.OFFSET_BOTTOM);
		int layer2 = overlayParent.layer;
		TransformExtensions.OffsetLocalPosZ((Transform)layer2, IPhoneXSupport.OFFSET_BOTTOM);
		int layer3 = _scrollHorizontalParent.layer;
		TransformExtensions.OffsetLocalPosZ((Transform)layer3, IPhoneXSupport.OFFSET_BOTTOM);
		_hasSetiPhoneXOffsetsIfNecessary = true;
	}

	public unsafe override void Hide()
	{
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_034f: Expected I, but got Obj
		//IL_0365: Expected Obj, but got I
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03d8: Expected I, but got Obj
		//IL_03ee: Expected Obj, but got I
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_04b6: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_021a: Expected I, but got Obj
		//IL_02c3: Expected Obj, but got I4
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(BoardScreen.RefreshIfPopupNotActive);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v94 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI);
		object obj3 = action2 + 16;
		obj3 = this;
		nint num3 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v90 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventStartedHandler -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI);
		object obj5 = action3 + 16;
		obj5 = this;
		SSEventsManagerController.OnSSEventFinishedHandler -= action3;
		nint num5 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v38 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v86 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI);
		object obj7 = action4 + 16;
		obj7 = this;
		((BoardBundlePopupManager)pageIndex).onBoardBundleStartedHandler -= action4;
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr5;
		((Delegate)action5).method = (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI);
		object obj8 = action5 + 16;
		obj8 = this;
		((BoardBundlePopupManager)pageIndex2).onBoardBundleExpiredHandler -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		Action action6 = default;
		((Delegate)action6).method_ptr = method_ptr6;
		((Delegate)action6).method = (nint)__ldftn(BoardScreen.UpdateUIElements);
		object obj9 = action6 + 16;
		obj9 = this;
		nint num7 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v53 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num8 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v82 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.boardSelected -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<Hoverboard.BoardAbility> action7 = default;
		object obj11 = action7 + 16;
		obj11 = this;
		BoardManager.themeActiveStateChanged -= action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr7 = 0;
		Action action8 = default;
		((Delegate)action8).method_ptr = method_ptr7;
		((Delegate)action8).method = (nint)__ldftn(BoardScreen.OnLastPopupClosed);
		object obj12 = action8 + 16;
		obj12 = this;
		UIScreenController.OnLastPopupClosed -= action8;
		SetupThemes();
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		if (((UIScreenController)flag).IsPopupQueueEmpty())
		{
			_refreshOnLastPopupClosed = true;
		}
		else
		{
			ShowHoverboardInScrollList();
		}
	}

	private unsafe void OnLastPopupClosed()
	{
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0365: Expected I, but got Obj
		//IL_037b: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03ee: Expected I, but got Obj
		//IL_0404: Expected Obj, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04cc: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01b9: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_0500: Expected Obj, but got I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_01fa: Expected I, but got Obj
		//IL_0280: Expected I, but got Obj
		//IL_0296: Expected Obj, but got I
		//IL_02c1: Expected I, but got Obj
		//IL_0325: Expected Obj, but got I4
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v102 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI);
		object obj3 = action2 + 16;
		obj3 = this;
		nint num4 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v98 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI);
		object obj5 = action3 + 16;
		obj5 = this;
		SSEventsManagerController.OnSSEventChangedHandler += action3;
		nint num6 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v38 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v94 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr3;
		((Delegate)action4).method = (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI);
		object obj7 = action4 + 16;
		obj7 = this;
		((BoardBundlePopupManager)pageIndex).onBoardBundleExpiredHandler += action4;
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		UnityEngine.Object obj8 = default;
		obj8.m_CachedPtr = cachedPtr;
		_ = 0;
		object obj9 = obj8 + 16;
		obj9 = this;
		BoardBundlePopupManager.LogErr((string)pageIndex2, obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<Hoverboard.BoardAbility> action5 = default;
		object obj10 = action5 + 16;
		obj10 = this;
		nint num9 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v53 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num10 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v90 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.themeActiveStateChanged += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		Boards.BoardId boardId = default;
		object obj12 = boardId + 16;
		obj12 = this;
		BoardManager.ResetDisplayedCustomSets(boardId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		_ = 0;
		Action<string> action6 = default;
		object obj13 = action6 + 16;
		obj13 = this;
		UIScreenController.OnPopupClosed += action6;
		nint num13 = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v76 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num14 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v86 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinMagnet instance = CoinMagnet.Instance;
		((HoverboardModelPreviewFactory)(object)instance).OpenGlider();
		CoinMagnet instance2 = CoinMagnet.Instance;
		((HoverboardModelPreviewFactory)(object)instance2).OnDestroy();
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.Boards);
	}

	private void RefreshIfPopupNotActive()
	{
		if (~(_refreshOnLastPopupClosed ? 1u : 0u) == 0)
		{
			ShowHoverboardInScrollList();
			_refreshOnLastPopupClosed = false;
		}
	}

	private void InitializeSelectButton()
	{
		//IL_004a: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I
		//IL_008b: Expected I, but got Obj
		if (!_inappOverlayActive && !_popupActive)
		{
			SetupThemes();
			IEnumerator list = DelayedInitCenterBoard();
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
			return;
		}
		nint num = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v16 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		_ = 1;
	}

	private void InitializeTimer()
	{
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0121: Expected I4, but got Obj
		//IL_012e: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got VT
		//IL_0143: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got F4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v24 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 144;
		int num3 = NGUITools.CalculateNextDepth(_centerAnchor, (byte)(int)_hoverboardSelectButtonPrefab != 0);
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)num3).GetComponentInChildren<T>();
		obj2 = componentInChildren;
		int layer = ((GameObject)num3).layer;
		object obj3 = 0;
		_ = 0;
		obj3 = 62f;
		_ = 0f;
		_ = 0f;
		Transform transform = (Transform)(obj3 + 12);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		_hoverboardSelectButton.rewardedBreakComplete(withReward: false);
	}

	private unsafe IEnumerator DelayedRefreshEventBoardAndUI()
	{
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		ref InAppItemModel reference = ref *(InAppItemModel*)null;
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v23 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (InAppData.inAppData.TryGetValue("com.kiloo.subwayboard.mumbai.bundletier1", out reference))
		{
			InAppItemModel inAppItemModel = reference;
			return (IEnumerator)(object)inAppItemModel.icon;
		}
		return null;
	}

	public void RefreshEventBoardAndUI()
	{
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		GameObject parent = _timerContainer.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 132;
		TimerHelper timerHelper = UnityEngine.Object.Instantiate(_timerPrefab, (Transform)(object)parent);
		obj2 = timerHelper;
	}

	private void OnThemeActiveStateChanged(Hoverboard.BoardAbility boardAbility)
	{
	}

	public unsafe void ShowHoverboardInMenu(bool willUpdateAnimation, bool willAllowSignatureAnimation, Hoverboard.BoardAbility ability = Hoverboard.BoardAbility.None)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1239: Unknown result type (might be due to invalid IL or missing references)
		//IL_123e: Expected I4, but got Unknown
		//IL_1255: Unknown result type (might be due to invalid IL or missing references)
		//IL_125a: Expected Obj, but got Unknown
		//IL_1263: Expected Obj, but got I4
		//IL_1272: Unknown result type (might be due to invalid IL or missing references)
		//IL_1277: Expected Obj, but got Unknown
		//IL_1280: Expected Obj, but got I4
		//IL_1289: Unknown result type (might be due to invalid IL or missing references)
		//IL_128e: Expected Obj, but got Unknown
		//IL_12aa: Expected I, but got Obj
		//IL_12c0: Expected Obj, but got I
		//IL_1625: Unknown result type (might be due to invalid IL or missing references)
		//IL_162a: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I4
		//IL_01cb: Expected I, but got Obj
		//IL_01e1: Expected Obj, but got I
		//IL_12f4: Expected Obj, but got I4
		//IL_1306: Expected I, but got Obj
		//IL_131c: Expected Obj, but got I
		//IL_020c: Expected I, but got Obj
		//IL_1430: Expected Obj, but got I4
		//IL_0e5c: Expected I, but got Obj
		//IL_1352: Expected Obj, but got I4
		//IL_137f: Expected Obj, but got I4
		//IL_0ea9: Expected I, but got Obj
		//IL_0ebf: Expected Obj, but got I
		//IL_027d: Expected I, but got Obj
		//IL_1475: Expected Obj, but got I4
		//IL_0f37: Expected I, but got Obj
		//IL_0f4d: Expected Obj, but got I
		//IL_0eea: Expected I, but got Obj
		//IL_1496: Expected Obj, but got I4
		//IL_1496: Expected Obj, but got I4
		//IL_02fb: Expected Obj, but got I4
		//IL_0fc5: Expected I, but got Obj
		//IL_0fdb: Expected Obj, but got I
		//IL_0f78: Expected I, but got Obj
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_14c0: Expected I, but got Obj
		//IL_14d6: Expected Obj, but got I
		//IL_1521: Expected I, but got Obj
		//IL_1537: Expected Obj, but got I
		//IL_1006: Expected I, but got Obj
		//IL_155d: Expected I4, but got Obj
		//IL_1569: Expected Obj, but got I4
		//IL_1053: Expected I, but got Obj
		//IL_038d: Expected I, but got Obj
		//IL_03a3: Expected Obj, but got I
		//IL_10ed: Expected Obj, but got I4
		//IL_10fe: Expected I4, but got Obj
		//IL_10a0: Expected I, but got Obj
		//IL_1115: Expected I, but got Obj
		//IL_112b: Expected Obj, but got I
		//IL_03ce: Expected I, but got Obj
		//IL_1598: Expected I, but got Obj
		//IL_15ae: Expected Obj, but got I
		//IL_16c4: Expected I, but got Obj
		//IL_16da: Expected Obj, but got I
		//IL_1156: Expected I, but got Obj
		//IL_167e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1683: Expected Obj, but got Unknown
		//IL_0b79: Expected Obj, but got I
		//IL_15e2: Expected Obj, but got I4
		//IL_11a3: Expected I, but got Obj
		//IL_11f0: Expected I, but got Obj
		//IL_05a6: Expected I, but got Obj
		//IL_05bc: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected Obj, but got Unknown
		//IL_0cec: Expected I4, but got Obj
		//IL_05e7: Expected I, but got Obj
		//IL_0da5: Expected I, but got Obj
		//IL_0dbb: Expected Obj, but got I
		//IL_0c5d: Expected I, but got Obj
		//IL_0c73: Expected Obj, but got I
		//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Expected Obj, but got Unknown
		//IL_1419: Expected I4, but got Obj
		//IL_1419: Expected Obj, but got I4
		//IL_1419: Expected Obj, but got I4
		//IL_0d17: Expected I, but got Obj
		//IL_0d2d: Expected Obj, but got I
		//IL_0de6: Expected I, but got Obj
		//IL_0c9e: Expected I, but got Obj
		//IL_0d58: Expected I, but got Obj
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Expected Obj, but got Unknown
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Expected Obj, but got Unknown
		//IL_0ae1: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		Boards.BoardId boardId = (Boards.BoardId)(obj2 + 40);
		((Boards.BoardId*)(int)boardId)->value__ = 0;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 44;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v371 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		InAppManager.OnPurchaseFailure onPurchaseFailure = default;
		((Delegate)onPurchaseFailure).method_ptr = method_ptr;
		((Delegate)onPurchaseFailure).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseSuccess);
		object obj7 = onPurchaseFailure + 16;
		obj7 = this;
		((InAppManager)(object)activeInAppOffers).onPurchaseFailure += onPurchaseFailure;
		Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		InAppManager.OnPurchaseItemNotAvailable onPurchaseItemNotAvailable = default;
		((Delegate)onPurchaseItemNotAvailable).method_ptr = method_ptr2;
		((Delegate)onPurchaseItemNotAvailable).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseFailedOrCancelled);
		object obj8 = onPurchaseItemNotAvailable + 16;
		obj8 = this;
		((InAppManager)(object)activeInAppOffers2).onPurchaseItemNotAvailable += onPurchaseItemNotAvailable;
		Dictionary<string, InAppItemModel> activeInAppOffers3 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		InAppManager.OnPurchaseCanceled onPurchaseCanceled = default;
		((Delegate)onPurchaseCanceled).method_ptr = method_ptr3;
		((Delegate)onPurchaseCanceled).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseFailedOrCancelled);
		object obj9 = onPurchaseCanceled + 16;
		obj9 = this;
		((InAppManager)(object)activeInAppOffers3).onPurchaseCanceled += onPurchaseCanceled;
		Dictionary<string, InAppItemModel> activeInAppOffers4 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		InAppManager.OnItemRestored onItemRestored = default;
		((Delegate)onItemRestored).method_ptr = method_ptr4;
		((Delegate)onItemRestored).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseFailedOrCancelled);
		object obj10 = onItemRestored + 16;
		obj10 = this;
		((InAppManager)(object)activeInAppOffers4).onItemRestored += onItemRestored;
		TransformExtensions.Reset((Transform)(object)scrollAnchor);
		object obj11 = this + 40;
		obj11 = 0;
		((Boards.BoardId*)(int)boardId)->value__ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<HoverboardThemes.ThemeIdentifier> list = default;
		list._002Ector();
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v43 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v367 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E59");
		IEnumerable<string> source = default;
		bool flag = Enumerable.Contains(source, (string)willUpdateAnimation);
		nint num5 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v52 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		bool flag2 = obj13 == null;
		object obj14;
		object obj28 = default;
		if (flag)
		{
			if (!flag2)
			{
				nint num6 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v361 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel inAppItemModel = InAppData.inAppData.get_Item((string)willUpdateAnimation);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			obj14 = 0;
			object obj15 = default;
			object obj16 = default;
			bool value__ = default;
			object obj19 = default;
			object obj21 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj15 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj18;
				if ((nint)obj16 == 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num7 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S0_v316 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num8 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ S0_v350 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					((Boards.BoardId*)(int)boardId)->value__ = (value__ ? 1 : 0);
					obj18 = 1;
				}
				else
				{
					obj18 = obj14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if ((nint)obj19 == 4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num9 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ S0_v289 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num10 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ S0_v298 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				}
				obj21 = obj18;
				obj14 = obj18;
			}
			object obj22 = 51;
			object obj23 = obj22 - 17;
			if ((nint)obj22 != 17 && (nint)obj23 != 1)
			{
				if ((nint)obj23 == 2 || (nint)obj23 == 3 || (nint)obj23 == 4 || (nint)obj23 == 5)
				{
					goto IL_1650;
				}
				if ((nint)obj23 != 6)
				{
					if ((nint)obj23 == 7 || (nint)obj23 == 8 || (nint)obj23 == 9 || (nint)obj23 == 10 || (nint)obj23 == 11 || (nint)obj23 == 12 || (nint)obj23 == 13 || (nint)obj23 == 14)
					{
						goto IL_1650;
					}
					if ((nint)obj23 != 15 && (nint)obj23 != 16 && (nint)obj23 != 17)
					{
						if ((nint)obj23 != 18)
						{
							if ((nint)obj23 == 19 || (nint)obj23 == 20 || (nint)obj23 == 21 || (nint)obj23 == 22 || (nint)obj23 == 23 || (nint)obj23 == 24 || (nint)obj23 == 25)
							{
								goto IL_1650;
							}
							if ((nint)obj23 != 26)
							{
								if ((nint)obj23 != 27)
								{
									if ((nint)obj23 != 28)
									{
										if ((nint)obj23 != 29 && (nint)obj23 != 30 && (nint)obj23 != 31 && (nint)obj23 != 32)
										{
											if ((nint)obj23 == 33)
											{
												goto IL_0aee;
											}
											if ((nint)obj23 == 34)
											{
												object obj24 = obj5 + 4;
												object obj25 = obj24 + 1;
												obj24 = obj25;
												object obj26 = obj25 << 2;
												object obj27 = obj5 + obj26;
												obj27 = 283;
												obj28 = obj14;
											}
										}
										goto IL_1650;
									}
									obj14 = obj21;
								}
								else
								{
									obj14 = obj21;
								}
							}
							else
							{
								obj14 = obj21;
							}
						}
						else
						{
							obj14 = obj21;
						}
					}
				}
			}
			goto IL_0aee;
		}
		if (!flag2)
		{
			nint num11 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v144 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<int> allThemesForBoard = ((InAppItemModel)willUpdateAnimation).GetAllThemesForBoard(boardId);
		if (allThemesForBoard == null)
		{
			return;
		}
		nint num12 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v87 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num13 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v97 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.BoardId? eventBoardType = BoardManager.GetEventBoardType();
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ActivateModelScreen((UIModelController.ModelScreen)((Boards.BoardId*)(int)boardId)->value__);
		nint num14 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v134 (Il2CppClass<UIScreenController>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num15 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S0_v140 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3).ShowRewardAnimationForBundlePurchase((List<InAppItemModel.BundleItem>)((Boards.BoardId*)(int)boardId)->value__, null);
		goto IL_0fb7;
		IL_0fb7:
		nint num16 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ S0_v62 (Il2CppClass<Info.Boards>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num17 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S0_v118 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)((Boards.BoardId*)(int)boardId)->value__);
		nint num18 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ S1_v59 (Il2CppClass<Strings>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num19 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S1_v81 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(board.name);
		string[] array = text.Split(null);
		nint num20 = (nint)typeof(char);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ S0_v74 (Il2CppClass<System.Char>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num21 = (nint)typeof(char);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ S0_v114 (Il2CppClass<System.Char>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		char c = char.ToUpperInvariant((char)(int)array);
		obj4 = c;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
		string text2 = Strings.GetDefault(board.name);
		string text3 = text2.Trim((char[])1);
		string[] values = default;
		string text4 = string.ConcatArray(values, (int)text3);
		nint num22 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ S0_v83 (Il2CppClass<Flurry>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num23 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S0_v110 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num24 = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ S0_v88 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num25 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ S0_v106 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
		_ = base._footerInited;
		_ = 1;
		nint num26 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ S0_v96 (Il2CppClass<UIScreenController>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num27 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ S0_v102 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag4)._ActivateNextPopup("LimitedBoardPopup");
		return;
		IL_1675:
		object obj37 = obj28 & 1;
		if (obj37 == null)
		{
			return;
		}
		if (list.Contains((HoverboardThemes.ThemeIdentifier)_selectedFooterButton))
		{
			nint num28 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ S0_v201 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num29 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ S0_v206 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BoardManager.SetThemeAcquired(Boards.BoardId.normal, HoverboardThemes.ThemeIdentifier.heroboardTheme01);
		}
		if (list.Contains((HoverboardThemes.ThemeIdentifier)_footerHandler))
		{
			nint num30 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ S0_v191 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num31 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ S0_v196 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BoardManager.SetThemeAcquired(Boards.BoardId.bouncer, HoverboardThemes.ThemeIdentifier.heroboardTheme01);
		}
		nint num32 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ S0_v180 (Il2CppClass<UIScreenController>)+BA]");
		object obj40 = (nint)0 & (nint)0x200;
		if (obj40 != null)
		{
			nint num33 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S0_v186 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag5).EnableBackButton((string)((Boards.BoardId*)(int)boardId)->value__, (byte)(int)list != 0);
		goto IL_0fb7;
		IL_1650:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+4]");
			object obj41 = (nint)0 << 2;
			object obj42 = obj5 + obj41;
			if ((nint)obj42 == 283)
			{
				object obj43 = obj5 + 4;
				if ((nint)obj43 > -1)
				{
					object obj44 = obj43 + -1;
					obj43 = obj44;
				}
				goto IL_1675;
			}
		}
		object obj45 = default;
		if (obj45 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_1675;
		IL_0aee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj46 = default;
		object obj47 = default;
		if (obj46 == obj47)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			obj28 = obj14;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_1650;
	}

	public void ShowHoverboardInScrollList()
	{
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		((SSEventsManagerController)(object)flurryUserId).CurrentEventHasBeenTriedNow();
		string flurryUserId2 = Flurry.flurryUserId;
		bool enable;
		if (((SSEventsManagerController)(object)flurryUserId2).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj2 = default;
			if ((nint)obj2 == 1)
			{
				enable = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj3 = default;
				enable = (nint)obj3 == 6;
			}
		}
		else
		{
			enable = false;
		}
		ToggleScrollElements(enable);
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SelectCurrentlyShownBoard(Boards.BoardId.surfboard);
		((CelebrationPopup)this).PayoutReward((CelebrationReward)1, false, false);
	}

	public void UpdateUIElements()
	{
		_refreshingThemeInScrollList = true;
		SetupThemes();
		_refreshingThemeInScrollList = false;
	}

	private void ActivateEventRibbon(bool active)
	{
		//IL_0014: Expected Obj, but got I4
		((CelebrationPopup)this).PayoutReward((CelebrationReward)1, true, active);
		UpdateUIElements();
	}

	private unsafe void InitBoards()
	{
		//IL_0d05: Expected VT, but got I4
		//IL_0d13: Expected I, but got Obj
		//IL_0d29: Expected Obj, but got I
		//IL_15a7: Expected I, but got Obj
		//IL_15bd: Expected Obj, but got I
		//IL_0d59: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0e58: Expected I, but got Obj
		//IL_0e6e: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_15fb: Expected I4, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_03c1: Expected I4, but got Obj
		//IL_0373: Expected I, but got Obj
		//IL_0df7: Expected I4, but got Obj
		//IL_03e7: Expected I4, but got Obj
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_020a: Expected I, but got Obj
		//IL_0409: Expected I4, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_0326: Expected I, but got Obj
		//IL_0298: Expected I, but got Obj
		//IL_0ebc: Expected Obj, but got I4
		//IL_0ef9: Expected Obj, but got I4
		//IL_0499: Expected I, but got Obj
		//IL_04af: Expected Obj, but got I
		//IL_055c: Expected Obj, but got I4
		//IL_04da: Expected I, but got Obj
		//IL_0588: Expected I, but got Obj
		//IL_059e: Expected Obj, but got I
		//IL_0f7e: Expected I4, but got Obj
		//IL_0f8c: Expected I, but got Obj
		//IL_0fa2: Expected Obj, but got I
		//IL_0547: Expected Obj, but got I4
		//IL_0fcd: Expected I, but got Obj
		//IL_0fe3: Expected Obj, but got I
		//IL_05c9: Expected I, but got Obj
		//IL_070f: Expected I, but got Obj
		//IL_0725: Expected Obj, but got I
		//IL_162e: Expected I4, but got Obj
		//IL_0616: Expected I, but got Obj
		//IL_1009: Unknown result type (might be due to invalid IL or missing references)
		//IL_100e: Expected I4, but got Unknown
		//IL_1024: Expected VT, but got I4
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected I4, but got Unknown
		//IL_0663: Expected I, but got Obj
		//IL_0750: Expected I, but got Obj
		//IL_06ec: Expected I4, but got Obj
		//IL_06fc: Expected I4, but got Obj
		//IL_1057: Expected I, but got Obj
		//IL_106d: Expected Obj, but got I
		//IL_0798: Expected Ref, but got VT
		//IL_164e: Expected I4, but got Obj
		//IL_1660: Expected I4, but got Obj
		//IL_1672: Expected I, but got Obj
		//IL_1688: Expected Obj, but got I
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_1098: Expected I4, but got Unknown
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a6: Expected Obj, but got Unknown
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Expected Obj, but got Unknown
		//IL_10bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c2: Expected Obj, but got Unknown
		//IL_10cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d0: Expected Obj, but got Unknown
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10de: Expected Obj, but got Unknown
		//IL_10e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ec: Expected Obj, but got Unknown
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Expected Obj, but got Unknown
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Expected Obj, but got Unknown
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected Obj, but got Unknown
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected Obj, but got Unknown
		//IL_113d: Expected I4, but got Obj
		//IL_1160: Expected I8, but got VT
		//IL_07d0: Expected I, but got Obj
		//IL_12c0: Expected I, but got Obj
		//IL_12d6: Expected Obj, but got I
		//IL_081d: Expected I, but got Obj
		//IL_16ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b3: Expected Obj, but got Unknown
		//IL_16bb: Expected Obj, but got I8
		//IL_16c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c9: Expected Obj, but got Unknown
		//IL_16d2: Expected Obj, but got VT
		//IL_16df: Expected I4, but got Obj
		//IL_16ec: Expected I4, but got Obj
		//IL_16ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1704: Expected Obj, but got Unknown
		//IL_170c: Expected Obj, but got I8
		//IL_1719: Expected I4, but got Obj
		//IL_1727: Expected Obj, but got I4
		//IL_1735: Expected I, but got Obj
		//IL_174b: Expected Obj, but got I
		//IL_0869: Expected Obj, but got I4
		//IL_158b: Expected I4, but got Obj
		//IL_158b: Expected I4, but got Obj
		//IL_0c69: Expected I, but got Obj
		//IL_0cb6: Expected I, but got Obj
		//IL_09cf: Expected I, but got Obj
		//IL_09e5: Expected Obj, but got I
		//IL_0894: Expected I, but got Obj
		//IL_08aa: Expected Obj, but got I
		//IL_1301: Expected I4, but got Obj
		//IL_1192: Expected I, but got Obj
		//IL_11a8: Expected Obj, but got I
		//IL_0a5b: Expected I8, but got VT
		//IL_0a10: Expected I, but got Obj
		//IL_11dd: Expected I, but got Obj
		//IL_11f3: Expected Obj, but got I
		//IL_08d5: Expected I, but got Obj
		//IL_1219: Expected Obj, but got VT
		//IL_122e: Expected I4, but got Obj
		//IL_1237: Expected VT, but got I4
		//IL_1244: Expected Obj, but got VT
		//IL_1259: Expected I4, but got Obj
		//IL_1262: Expected VT, but got I4
		//IL_1273: Expected I4, but got Obj
		//IL_128d: Expected I4, but got Obj
		//IL_0922: Expected I, but got Obj
		//IL_0a80: Expected I, but got Obj
		//IL_0a96: Expected Obj, but got I
		//IL_0b01: Expected I, but got Obj
		//IL_0b17: Expected Obj, but got I
		//IL_0955: Expected I, but got Obj
		//IL_1338: Expected Obj, but got VT
		//IL_134d: Expected I4, but got Obj
		//IL_1356: Expected VT, but got I4
		//IL_1363: Expected Obj, but got VT
		//IL_1378: Expected I4, but got Obj
		//IL_1381: Expected VT, but got I4
		//IL_1392: Expected I4, but got Obj
		//IL_13ac: Expected I4, but got Obj
		//IL_13df: Expected I4, but got Obj
		//IL_13f1: Expected I, but got Obj
		//IL_1407: Expected Obj, but got I
		//IL_0ac1: Expected I, but got Obj
		//IL_1432: Expected I4, but got Obj
		//IL_0b42: Expected I, but got Obj
		//IL_1469: Expected I, but got Obj
		//IL_147f: Expected Obj, but got I
		//IL_0b8f: Expected I, but got Obj
		//IL_14bb: Expected Obj, but got VT
		//IL_14d0: Expected I4, but got Obj
		//IL_14d9: Expected VT, but got I4
		//IL_14e6: Expected Obj, but got VT
		//IL_14fb: Expected I4, but got Obj
		//IL_1504: Expected VT, but got I4
		//IL_1515: Expected I4, but got Obj
		//IL_152f: Expected I4, but got Obj
		//IL_1557: Expected I8, but got VT
		//IL_0bc2: Expected I, but got Obj
		//IL_0bd8: Expected Obj, but got I
		//IL_0c36: Expected I, but got Obj
		//IL_0c03: Expected I, but got Obj
		Boards.BoardId? boardId = (Boards.BoardId?)(object)0;
		nint num = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v295 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		nint num3 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<Info.Boards>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v289 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)instance.jumperSignature);
		HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
		if (instance2.hoverboards != null)
		{
			nint num5 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v275 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v285 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance3 = HoverboardModelPreviewFactory.Instance;
			instance3.hoverboards = null;
			HoverboardModelPreviewFactory instance4 = HoverboardModelPreviewFactory.Instance;
			instance4.speederSignature = null;
			_hoverboardThemeShifter._002Ector();
		}
		nint num7 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v31 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v270 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance5 = HoverboardModelPreviewFactory.Instance;
		if ((object)instance5.speederSignature != null)
		{
			nint num9 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v233 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v266 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationReward celebrationReward = MysteryBox.Roll((MysteryBox.Type)instance.jumperSignature);
			if (celebrationReward != null)
			{
				nint num11 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v254 (Il2CppClass<BoardScreenManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num12 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v262 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardModelPreviewFactory instance6 = HoverboardModelPreviewFactory.Instance;
				if ((nint)instance6.speederSignature <= (nint)celebrationReward.rewardType)
				{
					goto IL_0e4a;
				}
			}
			nint num13 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v241 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num14 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v249 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance7 = HoverboardModelPreviewFactory.Instance;
			instance7.speederSignature = null;
			_hoverboardThemeShifter._002Ector();
		}
		goto IL_0e4a;
		IL_0a3a:
		int num15 = WelcomePackManager.ParseFirstInstalledVersion();
		bool flag = num15 == 0;
		long num16 = (long)TimeSpan.MinValue;
		Boards.BoardId boardId2;
		bool flag2;
		object obj13;
		object obj14;
		object obj10;
		object obj12;
		object obj9;
		object obj11;
		if (!flag)
		{
			long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
			nint num17 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S1_v108 (Il2CppClass<GlobalColorsGenerated>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num18 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ S1_v125 (Il2CppClass<GlobalColorsGenerated>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj9 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_TEXT;
			obj10 = obj9;
			((Boards.BoardId*)(int)boardId2)->value__ = (int)obj10;
			Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)boardId2);
			obj11 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_BG;
			obj12 = obj11;
			((Boards.BoardId*)(int)boardId2)->value__ = (int)obj12;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)boardId2);
			((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj13 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S1_v58+8]");
			_ = 0;
			((Boards.BoardId*)(int)boardId2)->value__ = (int)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S1_v64+8]");
			_ = 0;
			_timer.AnimateClock(flag2, (byte)boardId2 != 0);
			num16 = msTicksSinceDeviceStartup;
		}
		goto IL_12b2;
		IL_12b2:
		nint num19 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S0_v95 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num20 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S0_v118 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj16 = (Nullable)boardId + 24;
		obj16 = num16;
		object obj17 = (Nullable)boardId + 16;
		obj17 = TimeSpan.MinValue;
		((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj16 != 0;
		((Boards.BoardId*)(int)boardId2)->value__ = (int)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FA");
		object obj18 = (Nullable)boardId + 8;
		obj18 = num16;
		((Boards.BoardId*)(int)boardId2)->value__ = (int)obj18;
		Transform rewardTrans = default;
		((CelebrationPopup)this).StartIdleAnimCoroutine(rewardTrans, (CelebrationReward)boardId2);
		nint num21 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S1_v93 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num22 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ S1_v101 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance8 = HoverboardModelPreviewFactory.Instance;
		HoverboardModelPreviewFactory instance9 = HoverboardModelPreviewFactory.Instance;
		_hoverboardSelectButton.DeactivateTheme((Boards.BoardId)instance8.jumperSignature, (int)instance9.speederSignature);
		Update();
		return;
		IL_0e4a:
		nint num23 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S2_v4 (Il2CppClass<Strings>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num24 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v157 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(board.name);
		nameLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault(board.description);
		descriptionLabel.fontSize = (int)text2;
		string text3 = Strings.GetDefault(board.limitedDescription);
		themeLimitedLabel.fontSize = (int)text3;
		string text4 = Strings.GetDefault("BOARD_SCREEN_SPECIAL_POWER");
		staticPowerupLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault(board.limitedDescription);
		bool flag3 = text5 == null || text5.m_stringLength == 0;
		string text6 = (string)((flag3 ? 1 : 0) ^ 1);
		string text7 = Strings.GetDefault(board.description);
		bool flag4 = text7 == null || text7.m_stringLength == 0;
		string text8 = (string)((flag4 ? 1 : 0) ^ 1);
		powerIcon.tag = text8;
		staticPowerupLabel.tag = text8;
		themeLimitedLabel.tag = text6;
		nint num25 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v64 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num26 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v220 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance10 = HoverboardModelPreviewFactory.Instance;
		if ((object)instance10.speederSignature == null)
		{
			themePower.tag = null;
			string text9 = nameLabel.tag;
			((GameObject)(object)text9).tag = (string)1;
		}
		else
		{
			themePower.tag = (string)1;
			string text10 = nameLabel.tag;
			((GameObject)(object)text10).tag = null;
			nint num27 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S1_v213 (Il2CppClass<Strings>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num28 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S1_v240 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text11 = Strings.GetDefault("BOARD_SCREEN_SPECIAL_POWER");
			themePowerStaticLabel.fontSize = (int)text11;
			nint num29 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S1_v221 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num30 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S1_v234 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num31 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S2_v137 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num32 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S2_v151 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance11 = HoverboardModelPreviewFactory.Instance;
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)instance11.jumperSignature);
			HoverboardModelPreviewFactory instance12 = HoverboardModelPreviewFactory.Instance;
			int index = instance12.speederSignature - 1;
			HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
			string text12 = Strings.GetDefault(hoverboardTheme.title);
			themePowerLabel.fontSize = (int)text12;
			themeLimitedLabel.fontSize = (int)"";
		}
		nint num33 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v74 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num34 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S0_v202 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		boardId2 = (Boards.BoardId)((Nullable)boardId + 48);
		BoardManager.MarkHoverboardAsSeen(boardId2);
		boardId = (Boards.BoardId?)(object)((Boards.BoardId*)(int)boardId2)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.Nullable`1<Info.Boards+BoardId>)+4]");
		bool flag5;
		if ((nint)0 != 0)
		{
			Boards.BoardId value = ((Boards.BoardId?*)boardId)->Value;
			flag5 = (nint)instance.jumperSignature == (nint)value;
		}
		else
		{
			flag5 = false;
		}
		nint num35 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S1_v40 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num36 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S1_v203 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag6 = BoardManager.IsBoardEventLimitedExpiredBoard((Boards.BoardId)instance.jumperSignature);
		bool flag7 = BoardManager.IsBoardOwned((Boards.BoardId)instance.jumperSignature);
		nint num37 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v49 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num38 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S1_v197 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		flag2 = (byte)((Nullable)boardId + 32) != 0;
		obj9 = (Nullable)boardId + 104;
		obj13 = (Nullable)boardId + 88;
		object obj28 = (Nullable)boardId + 128;
		obj11 = (Nullable)boardId + 80;
		obj14 = (Nullable)boardId - -64;
		object obj29 = (Nullable)boardId + 124;
		object obj30 = (Nullable)boardId + 120;
		object obj31 = (Nullable)boardId + 116;
		obj10 = (Nullable)boardId + 112;
		obj12 = (Nullable)boardId + 108;
		bool flag8 = !flag5;
		bool flag9 = BoardManager.HasAllThemesBeenSeen((Boards.BoardId)instance.jumperSignature);
		bool flag10 = !flag9;
		bool flag11 = !flag10;
		num16 = (long)TimeSpan.MinValue;
		if (!flag11)
		{
			object obj32 = flag6 | flag7;
			if (obj32 != null)
			{
				nint num39 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S0_v185 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num40 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S0_v195 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string flurryUserId = Flurry.flurryUserId;
				long currentEventID = ((SSEventsManagerController)(object)flurryUserId).GetCurrentEventID();
				nint num41 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S1_v166 (Il2CppClass<System.TimeSpan>)+BA]");
				object obj34 = (nint)0 & (nint)0x200;
				if (obj34 != null)
				{
					nint num42 = (nint)typeof(TimeSpan);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S1_v194 (Il2CppClass<System.TimeSpan>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
				nint num43 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S1_v172 (Il2CppClass<GlobalColors>)+BA]");
				object obj35 = (nint)0 & (nint)0x200;
				if (obj35 != null)
				{
					nint num44 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ S1_v189 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj9 = GlobalColors.GIFT_LABEL_COLOR;
				obj28 = obj9;
				((Boards.BoardId*)(int)boardId2)->value__ = (int)obj28;
				Matrix4x4 matrix4x3 = Matrix4x4.Inverse((Matrix4x4)boardId2);
				obj11 = GlobalColors.GIFT_COLOR;
				obj29 = obj11;
				((Boards.BoardId*)(int)boardId2)->value__ = (int)obj29;
				Matrix4x4 matrix4x4 = Matrix4x4.Inverse((Matrix4x4)boardId2);
				((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj13 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S1_v58+8]");
				_ = 0;
				((Boards.BoardId*)(int)boardId2)->value__ = (int)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S1_v64+8]");
				_ = 0;
				_timer.AnimateClock(flag2, (byte)boardId2 != 0);
				long num45 = default;
				num16 = num45;
			}
			else
			{
				if (~(board.hasOnlineTimeLimit ? 1u : 0u) == 0)
				{
					if (!flag8)
					{
						goto IL_0a3a;
					}
				}
				else
				{
					nint num46 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ S0_v172 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
					object obj36 = (nint)0 & (nint)0x200;
					if (obj36 != null)
					{
						nint num47 = (nint)typeof(WeeklyHuntManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S0_v179 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num48 = WeeklyHuntManager.ItemsCollectedForBoardType((Boards.BoardId)instance.jumperSignature);
					if (((flag8 ? 1u : 0u) & (uint)num48) == 0)
					{
						goto IL_0a3a;
					}
				}
				nint num49 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ S0_v138 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj37 = (nint)0 & (nint)0x200;
				if (obj37 != null)
				{
					nint num50 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ S0_v167 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime dateTime = CharacterManager.DefaultExpirationDateForCharacter((Characters.CharacterId)instance.jumperSignature);
				nint num51 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ S0_v145 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num52 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ S0_v164 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num53 = WeeklyHuntManager.ItemsCollectedForBoardType((Boards.BoardId)instance.jumperSignature);
				bool flag12 = num53 == 0;
				DateTime dateTime2 = dateTime;
				if (!flag12)
				{
					nint num54 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ S0_v155 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
					object obj39 = (nint)0 & (nint)0x200;
					if (obj39 != null)
					{
						nint num55 = (nint)typeof(WeeklyHuntManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ S0_v161 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					DateTime endTimeForActivePeriod = WeeklyHuntManager.GetEndTimeForActivePeriod();
					dateTime2 = endTimeForActivePeriod;
				}
				nint num56 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ S1_v137 (Il2CppClass<GlobalColorsGenerated>)+BA]");
				object obj40 = (nint)0 & (nint)0x200;
				if (obj40 != null)
				{
					nint num57 = (nint)typeof(GlobalColorsGenerated);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ S1_v154 (Il2CppClass<GlobalColorsGenerated>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj9 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
				obj30 = obj9;
				((Boards.BoardId*)(int)boardId2)->value__ = (int)obj30;
				Matrix4x4 matrix4x5 = Matrix4x4.Inverse((Matrix4x4)boardId2);
				obj11 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
				obj31 = obj11;
				((Boards.BoardId*)(int)boardId2)->value__ = (int)obj31;
				Matrix4x4 matrix4x6 = Matrix4x4.Inverse((Matrix4x4)boardId2);
				((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj13 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S1_v58+8]");
				_ = 0;
				((Boards.BoardId*)(int)boardId2)->value__ = (int)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S1_v64+8]");
				_ = 0;
				_timer.AnimateClock(flag2, (byte)boardId2 != 0);
				num16 = (long)dateTime2;
			}
		}
		goto IL_12b2;
	}

	private IEnumerator DelayedInitCenterBoard()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void ToggleScrollElements(bool enable)
	{
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0601: Expected Obj, but got I4
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got Unknown
		//IL_0618: Expected Obj, but got I4
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected Obj, but got Unknown
		//IL_062f: Expected Obj, but got I4
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected Obj, but got Unknown
		//IL_0646: Expected Obj, but got I4
		//IL_065b: Expected Obj, but got I4
		//IL_0682: Expected I, but got Obj
		//IL_0698: Expected Obj, but got I
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_0472: Expected I, but got Obj
		//IL_04ce: Expected I, but got Obj
		//IL_04e4: Expected Obj, but got I
		//IL_006f: Expected I, but got Obj
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_050f: Expected I, but got Obj
		//IL_055c: Expected I, but got Obj
		//IL_0572: Expected Obj, but got I
		//IL_0895: Expected Obj, but got I4
		//IL_08a2: Expected Obj, but got I4
		//IL_08ab: Expected Obj, but got F4
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected Obj, but got Unknown
		//IL_08db: Expected VT, but got Obj
		//IL_059d: Expected I, but got Obj
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0285: Expected I4, but got Obj
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02a2: Expected I4, but got Obj
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c4: Expected I4, but got Obj
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02fb: Expected VT, but got Obj
		//IL_0791: Invalid comparison between Obj and F4
		//IL_039c: Invalid comparison between Obj and F4
		//IL_03d1: Expected Obj, but got F4
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_03c3: Expected F4, but got Obj
		//IL_03e4: Expected I, but got Obj
		//IL_03fa: Expected Obj, but got I
		//IL_085a: Expected Obj, but got F4
		//IL_0425: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 40);
		object obj2 = obj + 36;
		obj2 = 0;
		object obj3 = obj + 32;
		obj3 = 0;
		object obj4 = obj + 28;
		obj4 = 0;
		object obj5 = obj + 16;
		obj5 = 0;
		_ = 0;
		eventRibbon.tag = (string)enable;
		if (enable)
		{
			obj2 = string.Empty;
			obj3 = string.Empty;
			obj4 = string.Empty;
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v77 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v168 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
			bool flag2 = !flag;
			string text = string.Empty;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj8 = default;
				object obj7 = obj8 - 1;
				if ((nint)obj8 != 1 && ((nint)obj7 == 1 || (nint)obj7 == 2 || (nint)obj7 == 3 || (nint)obj7 == 4 || (nint)obj7 != 5))
				{
					text = string.Empty;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
					text = (string)obj2;
				}
			}
			if (text != null && text.m_stringLength != 0)
			{
				object obj9 = obj3;
				bool flag3;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v89+8]");
					flag3 = (nint)0 == 0;
				}
				else
				{
					flag3 = true;
				}
				if (!flag3)
				{
					object obj10 = obj4;
					bool flag4;
					if (obj4 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v93+8]");
						flag4 = (nint)0 == 0;
					}
					else
					{
						flag4 = true;
					}
					if (!flag4)
					{
						object obj11 = ribbonLabels + 16;
						((UILabel)obj11).fontSize = (int)obj2;
						object obj12 = ribbonLabels + 20;
						((UILabel)obj12).fontSize = (int)obj3;
						object obj13 = ribbonLabels + 24;
						((UILabel)obj13).fontSize = (int)obj4;
						object obj14 = ribbonLabels + 24;
						Component component = (Component)obj14;
						GameObject gameObject = ((Component)obj14).gameObject;
						transform.localPosition = (Vector3)gameObject;
						obj5 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v61 (UnityEngine.Component)+164]");
						if ((nint)0 != 2)
						{
							_ = 2;
							_ = 1;
							_ = 1;
						}
						Vector2 localSize = ((UILabel)obj14).localSize;
						float num3;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)155f))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v61 (UnityEngine.Component)+164]");
							if ((nint)0 != 0)
							{
								_ = 0;
								_ = 1;
								_ = 1;
							}
							int height = NumberExtensions.CeilToInt(155f);
							((UIWidget)obj14).height = height;
							num3 = 155f;
						}
						else
						{
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)136f))
							{
								obj5 = 0f;
								goto IL_07d9;
							}
							num3 = (float)obj;
						}
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v127 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num5 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v132 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float value = num3 - 136f;
						float num6 = Math.Abs(value);
						float num7 = num6 * 0.5f;
						obj5 = num7;
						goto IL_07d9;
					}
				}
			}
		}
		goto IL_0674;
		IL_07d9:
		object obj16 = ribbonLabels + 24;
		GameObject gameObject2 = ((Component)obj16).gameObject;
		transform = (Transform)obj5;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		goto IL_0674;
		IL_0674:
		nint num8 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v24 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num9 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v69 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj18 = obj + 8;
		if (!IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			return;
		}
		UIAnchor component2 = eventRibbon.GetComponent<UIAnchor>();
		nint num10 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num12 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v45 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num13 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v59 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = ((Range)IPhoneXSupport.OFFSET_TOP).ToString();
		obj = 0;
		obj = 10f;
		object obj21 = 0 - text2;
		obj18 = obj;
		transform = (Transform)obj18;
		component2.pixelOffset = (Vector2)transform;
	}

	public void ClickedHoverboardTheme(int index)
	{
		//IL_004b: Expected I, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_008c: Expected I, but got Obj
		//IL_0024: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		if (!_inappOverlayActive && !_popupActive)
		{
			scrollAnchor.tag = (string)index;
			overlayParent.tag = (string)index;
			return;
		}
		nint num = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v16 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		_ = 1;
	}

	public unsafe void UpdateDisplayedModelWithTheme(Boards.BoardId boardId, int themeIndex)
	{
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		InAppManager.OnPurchaseFailure onPurchaseFailure = default;
		((Delegate)onPurchaseFailure).method_ptr = method_ptr;
		((Delegate)onPurchaseFailure).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseSuccess);
		object obj2 = onPurchaseFailure + 16;
		obj2 = this;
		((InAppManager)(object)activeInAppOffers).onPurchaseFailure += onPurchaseFailure;
		Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		InAppManager.OnPurchaseItemNotAvailable onPurchaseItemNotAvailable = default;
		((Delegate)onPurchaseItemNotAvailable).method_ptr = method_ptr2;
		((Delegate)onPurchaseItemNotAvailable).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseFailedOrCancelled);
		object obj3 = onPurchaseItemNotAvailable + 16;
		obj3 = this;
		((InAppManager)(object)activeInAppOffers2).onPurchaseItemNotAvailable += onPurchaseItemNotAvailable;
		Dictionary<string, InAppItemModel> activeInAppOffers3 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		InAppManager.OnPurchaseCanceled onPurchaseCanceled = default;
		((Delegate)onPurchaseCanceled).method_ptr = method_ptr3;
		((Delegate)onPurchaseCanceled).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseFailedOrCancelled);
		object obj4 = onPurchaseCanceled + 16;
		obj4 = this;
		((InAppManager)(object)activeInAppOffers3).onPurchaseCanceled += onPurchaseCanceled;
		Dictionary<string, InAppItemModel> activeInAppOffers4 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		InAppManager.OnItemRestored onItemRestored = default;
		((Delegate)onItemRestored).method_ptr = method_ptr4;
		((Delegate)onItemRestored).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseFailedOrCancelled);
		object obj5 = onItemRestored + 16;
		obj5 = this;
		((InAppManager)(object)activeInAppOffers4).onItemRestored += onItemRestored;
	}

	public unsafe void RefreshBoards()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_289c: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a1: Expected Obj, but got Unknown
		//IL_28aa: Expected Obj, but got I4
		//IL_28b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_28be: Expected Obj, but got Unknown
		//IL_28c7: Expected Obj, but got I4
		//IL_28dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_28e1: Expected Obj, but got Unknown
		//IL_28ea: Expected Obj, but got I4
		//IL_28f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f8: Expected Obj, but got Unknown
		//IL_2901: Expected Obj, but got I4
		//IL_290a: Unknown result type (might be due to invalid IL or missing references)
		//IL_290f: Expected Obj, but got Unknown
		//IL_2936: Unknown result type (might be due to invalid IL or missing references)
		//IL_293b: Expected Obj, but got Unknown
		//IL_2951: Expected I, but got Obj
		//IL_2967: Expected Obj, but got I
		//IL_298d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2992: Expected I4, but got Unknown
		//IL_29a9: Expected I, but got Obj
		//IL_29bf: Expected Obj, but got I
		//IL_29e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ea: Expected Obj, but got Unknown
		//IL_29f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f8: Expected Obj, but got Unknown
		//IL_2a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a06: Expected Obj, but got Unknown
		//IL_2a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a14: Expected Obj, but got Unknown
		//IL_2a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a22: Expected Obj, but got Unknown
		//IL_2a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a30: Expected Obj, but got Unknown
		//IL_2a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3e: Expected Obj, but got Unknown
		//IL_2a55: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_01c6: Expected I, but got Obj
		//IL_01dc: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		//IL_0207: Expected I, but got Obj
		//IL_0408: Expected Obj, but got I4
		//IL_043a: Expected I4, but got Obj
		//IL_027e: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I
		//IL_02bf: Expected I, but got Obj
		//IL_0350: Expected I, but got Obj
		//IL_0366: Expected Obj, but got I
		//IL_2c53: Expected Obj, but got I4
		//IL_0964: Expected Obj, but got I
		//IL_2b12: Expected Obj, but got I4
		//IL_0391: Expected I, but got Obj
		//IL_0a26: Expected Obj, but got I4
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected Obj, but got Unknown
		//IL_2ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2abb: Expected Obj, but got Unknown
		//IL_0a47: Expected Obj, but got I4
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected Obj, but got Unknown
		//IL_0a59: Expected Obj, but got I4
		//IL_0a6c: Expected Obj, but got I4
		//IL_0a84: Expected Obj, but got I4
		//IL_0a97: Expected I, but got Obj
		//IL_0aad: Expected Obj, but got I
		//IL_2aeb: Expected Obj, but got I4
		//IL_0ad8: Expected I, but got Obj
		//IL_2c98: Expected Obj, but got I4
		//IL_2c98: Expected Obj, but got I4
		//IL_253d: Expected Obj, but got I
		//IL_0b50: Expected Obj, but got I4
		//IL_25f5: Expected Obj, but got I4
		//IL_25f5: Expected Obj, but got I4
		//IL_0b68: Expected Obj, but got I4
		//IL_0b1b: Expected Obj, but got I4
		//IL_2573: Unknown result type (might be due to invalid IL or missing references)
		//IL_2578: Expected Obj, but got Unknown
		//IL_0b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7b: Expected Obj, but got Unknown
		//IL_0b91: Expected I, but got Obj
		//IL_0ba7: Expected Obj, but got I
		//IL_27ca: Expected Obj, but got I4
		//IL_27ea: Expected Obj, but got I4
		//IL_2631: Expected I, but got Obj
		//IL_2647: Expected Obj, but got I
		//IL_25a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ae: Expected Obj, but got Unknown
		//IL_0bd2: Expected I, but got Obj
		//IL_2807: Expected I, but got Obj
		//IL_281d: Expected Obj, but got I
		//IL_2bbb: Expected I4, but got Obj
		//IL_26bf: Expected Obj, but got I4
		//IL_2672: Expected I, but got Obj
		//IL_0c3e: Expected Obj, but got I4
		//IL_0c51: Expected Obj, but got I4
		//IL_0c15: Expected Obj, but got I4
		//IL_2848: Expected I, but got Obj
		//IL_0c86: Expected Obj, but got I4
		//IL_27a1: Expected Obj, but got I4
		//IL_0c9e: Expected Obj, but got I4
		//IL_270f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2714: Expected Obj, but got Unknown
		//IL_272a: Unknown result type (might be due to invalid IL or missing references)
		//IL_272f: Expected Obj, but got Unknown
		//IL_2751: Expected I4, but got Obj
		//IL_2767: Expected Obj, but got I4
		//IL_0cb6: Expected Obj, but got I4
		//IL_0cce: Expected Obj, but got I4
		//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Expected Obj, but got Unknown
		//IL_0cf7: Expected I, but got Obj
		//IL_0d0d: Expected Obj, but got I
		//IL_2b2a: Expected Obj, but got I4
		//IL_0d38: Expected I, but got Obj
		//IL_0db0: Expected Obj, but got I4
		//IL_0dc2: Expected I4, but got Obj
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddd: Expected Obj, but got Unknown
		//IL_0dea: Expected Obj, but got I4
		//IL_0e0a: Expected Obj, but got I4
		//IL_0d7b: Expected Obj, but got I4
		//IL_0e22: Expected Obj, but got I4
		//IL_0e3a: Expected Obj, but got I4
		//IL_0e52: Expected Obj, but got I4
		//IL_0e60: Expected Obj, but got I4
		//IL_0e7f: Expected Obj, but got F4
		//IL_0e98: Expected I4, but got Obj
		//IL_0eb8: Expected Obj, but got I4
		//IL_0ecb: Expected I, but got Obj
		//IL_0ee1: Expected Obj, but got I
		//IL_2b42: Expected Obj, but got I4
		//IL_0f47: Expected I4, but got Obj
		//IL_0f62: Expected VT, but got I4
		//IL_0f73: Expected I4, but got Obj
		//IL_0f0c: Expected I, but got Obj
		//IL_0f98: Expected Obj, but got I4
		//IL_0fa6: Expected Obj, but got I4
		//IL_0fb5: Expected Obj, but got F4
		//IL_0fce: Expected I4, but got Obj
		//IL_0fee: Expected Obj, but got I4
		//IL_0f35: Expected Obj, but got I4
		//IL_1001: Expected I, but got Obj
		//IL_1017: Expected Obj, but got I
		//IL_2b5a: Expected Obj, but got I4
		//IL_1090: Expected Obj, but got I4
		//IL_1042: Expected I, but got Obj
		//IL_10c5: Expected Obj, but got I4
		//IL_106b: Expected Obj, but got I4
		//IL_10dd: Expected Obj, but got I4
		//IL_10f5: Expected Obj, but got I4
		//IL_110d: Expected Obj, but got I4
		//IL_1125: Expected Obj, but got I4
		//IL_113d: Expected Obj, but got I4
		//IL_1155: Expected Obj, but got I4
		//IL_116d: Expected Obj, but got I4
		//IL_1178: Unknown result type (might be due to invalid IL or missing references)
		//IL_117d: Expected Obj, but got Unknown
		//IL_1190: Expected Obj, but got I4
		//IL_11a8: Expected Obj, but got I4
		//IL_11c0: Expected Obj, but got I4
		//IL_11d8: Expected Obj, but got I4
		//IL_11f0: Expected Obj, but got I4
		//IL_11fd: Expected Obj, but got I4
		//IL_1210: Expected Obj, but got I4
		//IL_1228: Expected Obj, but got I4
		//IL_1248: Expected Obj, but got I4
		//IL_1260: Expected Obj, but got I4
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected Obj, but got Unknown
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected Obj, but got Unknown
		//IL_08a3: Expected Obj, but got I4
		//IL_08ac: Expected Obj, but got I4
		//IL_1278: Expected Obj, but got I4
		//IL_1298: Expected Obj, but got I4
		//IL_244a: Unknown result type (might be due to invalid IL or missing references)
		//IL_244f: Expected Obj, but got Unknown
		//IL_2458: Unknown result type (might be due to invalid IL or missing references)
		//IL_245d: Expected Obj, but got Unknown
		//IL_2489: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 176;
		object obj3 = obj2 + 152;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 132;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = 0;
		object obj6 = obj2 + 128;
		obj6 = 0;
		object obj7 = obj2 + 120;
		obj7 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<KeyValuePair<Boards.BoardId, Boards.Board>> list = default;
		list._002Ector();
		object obj8 = this + 164;
		obj8 = list;
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v886 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.BoardId boardId = (Boards.BoardId)(obj2 + 32);
		BoardManager.MarkHoverboardAsSeen(boardId);
		nint num3 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v38 (Il2CppClass<Info.Boards>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v880 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = obj2 + 24;
		object obj12 = obj2 + 104;
		object obj13 = obj2 + 92;
		object obj14 = obj2 + 80;
		object obj15 = obj2 + 68;
		object obj16 = obj2 + 56;
		object obj17 = obj2 + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = ((Boards.BoardId*)(int)boardId)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36 (Info.Boards+BoardId)+8]");
		_ = 0;
		object obj18 = default;
		object obj21 = default;
		object obj23 = default;
		object obj25 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj18 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num5 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v778 (Il2CppClass<Info.Boards>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num6 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v868 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			nint num7 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S0_v793 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num8 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S0_v859 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj21 == null)
			{
				nint num9 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S0_v825 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num10 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S0_v850 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj23 != null)
				{
					continue;
				}
				nint num11 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ S0_v835 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num12 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ S0_v842 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj25 == null)
				{
					continue;
				}
			}
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj11 = obj2;
			((Boards.BoardId*)(int)boardId)->value__ = (int)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj26 = 47;
		object obj27 = obj26 - 15;
		object obj32;
		if ((nint)obj26 != 15)
		{
			if ((nint)obj27 != 1 && (nint)obj27 != 2 && (nint)obj27 != 3 && (nint)obj27 != 4)
			{
				if ((nint)obj27 == 5 || (nint)obj27 == 6)
				{
					goto IL_08b6;
				}
				if ((nint)obj27 != 7 && (nint)obj27 != 8)
				{
					if ((nint)obj27 == 9)
					{
						goto IL_08b6;
					}
					if ((nint)obj27 != 10 && (nint)obj27 != 11 && (nint)obj27 != 12)
					{
						if ((nint)obj27 == 13)
						{
							goto IL_08b6;
						}
						if ((nint)obj27 != 14 && (nint)obj27 != 15)
						{
							if ((nint)obj27 == 16)
							{
								goto IL_08b6;
							}
							if ((nint)obj27 != 17 && (nint)obj27 != 18 && (nint)obj27 != 19)
							{
								if ((nint)obj27 == 20)
								{
									goto IL_08b6;
								}
								if ((nint)obj27 != 21 && (nint)obj27 != 22)
								{
									if ((nint)obj27 == 23)
									{
										goto IL_08b6;
									}
									if ((nint)obj27 != 24 && (nint)obj27 != 25 && (nint)obj27 != 26 && (nint)obj27 != 27 && (nint)obj27 != 28 && (nint)obj27 != 29)
									{
										if ((nint)obj27 == 30 || (nint)obj27 == 31)
										{
											goto IL_08b6;
										}
										if ((nint)obj27 == 32)
										{
											object obj28 = obj7 + 4;
											object obj29 = obj28 + 1;
											obj28 = obj29;
											object obj30 = obj29 << 2;
											object obj31 = obj7 + obj30;
											obj31 = 117;
											obj32 = 0;
											goto IL_0929;
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_2888;
		}
		goto IL_08b6;
		IL_2502:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+4]");
			object obj33 = (nint)0 << 2;
			object obj34 = obj7 + obj33;
			if ((nint)obj34 == 662)
			{
				object obj35 = obj7 + 4;
				if ((nint)obj35 > -1)
				{
					object obj36 = obj35 + -1;
					obj35 = obj36;
				}
				goto IL_2c7b;
			}
		}
		object obj37 = default;
		if (obj37 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_2c7b;
		IL_2496:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj39 = default;
		object obj38 = obj39;
		object obj41 = default;
		object obj40 = obj41;
		goto IL_2b64;
		IL_2c3c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77DB");
		obj4 = ((Boards.BoardId*)(int)boardId)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36 (Info.Boards+BoardId)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36 (Info.Boards+BoardId)+10]");
		_ = 0;
		int num13 = 0;
		object obj43 = default;
		object obj46 = default;
		object obj47 = default;
		object obj49 = default;
		object obj51 = default;
		object obj57 = default;
		object obj58 = default;
		object obj42;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 178;
			bool flag = obj43 == null;
			obj42 = 179;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 62;
			obj5 = ((Boards.BoardId*)(int)boardId)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj42 = 63;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj42 = 63;
			nint num14 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1327 @ S0_v318 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num15 = (nint)typeof(HoverboardModelPreviewFactory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ S0_v730 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj42 = 64;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj42 = 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 74;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj42 = 75;
			object obj45 = obj46 + 24;
			obj45 = obj47;
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ S0_v353 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj48 = (nint)0 & (nint)0x200;
			if (obj48 != null)
			{
				nint num17 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ S0_v721 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj42 = 76;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj49 != null)
			{
				continue;
			}
			obj2 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 90;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj42 = 92;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 92;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 93;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj42 = 94;
			object obj50 = obj46 + 28;
			obj50 = obj51;
			nint num18 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1699 @ S0_v407 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
			object obj52 = (nint)0 & (nint)0x200;
			if (obj52 != null)
			{
				nint num19 = (nint)typeof(HoverboardModelPreviewFactory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1707 @ S0_v711 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj42 = 95;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj42 = 107;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj42 = 109;
			((Boards.BoardId*)(int)boardId)->value__ = (int)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v45+8]");
			_ = 0;
			object obj53 = obj46 + 8;
			obj53 = ((Boards.BoardId*)(int)boardId)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36 (Info.Boards+BoardId)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 110;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 111;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 112;
			obj13 = 0;
			_ = 0;
			float num20 = (float)num13 * _cellWidth;
			obj13 = num20;
			_ = 0f;
			_ = 50f;
			((Boards.BoardId*)(int)boardId)->value__ = (int)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v47+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 113;
			nint num21 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1849 @ S0_v478 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj54 = (nint)0 & (nint)0x200;
			if (obj54 != null)
			{
				nint num22 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1856 @ S0_v703 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj42 = 114;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj42 = 121;
			((Boards.BoardId*)(int)boardId)->value__ = (int)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v49+8]");
			_ = 0;
			Vector3 vector = (Vector3)boardId / 7f;
			((Boards.BoardId*)(int)boardId)->value__ = (int)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v51+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 122;
			obj16 = 0;
			_ = 0;
			obj16 = 53f;
			_ = 183f;
			_ = 360f;
			((Boards.BoardId*)(int)boardId)->value__ = (int)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v53+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 123;
			nint num23 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1939 @ S0_v514 (Il2CppClass<NGUITools>)+BA]");
			object obj55 = (nint)0 & (nint)0x200;
			if (obj55 != null)
			{
				nint num24 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1944 @ S0_v696 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj42 = 124;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj42 = 152;
			((Boards.BoardId*)(int)boardId)->value__ = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 153;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj42 = 155;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 155;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj42 = 157;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 158;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
			obj42 = 159;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 160;
			object obj56 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj42 = 161;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 162;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 162;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj42 = 163;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 164;
			obj17 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 165;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 166;
			obj6 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 167;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj42 = 168;
			obj6 = obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj42 = 169;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			int num25 = num13 + 1;
			num13 = num25;
		}
		object obj59 = obj42 - 62;
		if ((nint)obj42 != 62 && (nint)obj59 != 1 && (nint)obj59 != 2)
		{
			if ((nint)obj59 != 3 && (nint)obj59 != 4 && (nint)obj59 != 5 && (nint)obj59 != 6 && (nint)obj59 != 7 && (nint)obj59 != 8 && (nint)obj59 != 9)
			{
				if ((nint)obj59 == 10 || (nint)obj59 == 11 || (nint)obj59 == 12 || (nint)obj59 == 13 || (nint)obj59 == 14)
				{
					goto IL_2496;
				}
				if ((nint)obj59 != 15 && (nint)obj59 != 16)
				{
					if ((nint)obj59 == 17)
					{
						goto IL_2496;
					}
					if ((nint)obj59 != 18 && (nint)obj59 != 19 && (nint)obj59 != 20 && (nint)obj59 != 21 && (nint)obj59 != 22 && (nint)obj59 != 23 && (nint)obj59 != 24 && (nint)obj59 != 25 && (nint)obj59 != 26 && (nint)obj59 != 27)
					{
						if ((nint)obj59 != 28)
						{
							if ((nint)obj59 != 29)
							{
								if ((nint)obj59 != 30)
								{
									if ((nint)obj59 != 31)
									{
										if ((nint)obj59 != 32)
										{
											if ((nint)obj59 != 33)
											{
												if ((nint)obj59 == 34 || (nint)obj59 == 35 || (nint)obj59 == 36 || (nint)obj59 == 37 || (nint)obj59 == 38 || (nint)obj59 == 39 || (nint)obj59 == 40 || (nint)obj59 == 41 || (nint)obj59 == 42 || (nint)obj59 == 43 || (nint)obj59 == 44)
												{
													goto IL_2502;
												}
												if ((nint)obj59 != 45)
												{
													if ((nint)obj59 != 46)
													{
														if ((nint)obj59 != 47)
														{
															if ((nint)obj59 != 48)
															{
																if ((nint)obj59 != 49)
																{
																	if ((nint)obj59 != 50)
																	{
																		if ((nint)obj59 != 51)
																		{
																			if ((nint)obj59 != 52)
																			{
																				if ((nint)obj59 == 53 || (nint)obj59 == 54 || (nint)obj59 == 55 || (nint)obj59 == 56 || (nint)obj59 == 57 || (nint)obj59 == 58)
																				{
																					goto IL_2502;
																				}
																				if ((nint)obj59 != 59)
																				{
																					if ((nint)obj59 != 60)
																					{
																						if ((nint)obj59 != 61)
																						{
																							if ((nint)obj59 != 62)
																							{
																								if ((nint)obj59 == 63 || (nint)obj59 == 64 || (nint)obj59 == 65 || (nint)obj59 == 66 || (nint)obj59 == 67 || (nint)obj59 == 68 || (nint)obj59 == 69 || (nint)obj59 == 70 || (nint)obj59 == 71 || (nint)obj59 == 72 || (nint)obj59 == 73 || (nint)obj59 == 74 || (nint)obj59 == 75 || (nint)obj59 == 76 || (nint)obj59 == 77 || (nint)obj59 == 78 || (nint)obj59 == 79 || (nint)obj59 == 80 || (nint)obj59 == 81 || (nint)obj59 == 82 || (nint)obj59 == 83 || (nint)obj59 == 84 || (nint)obj59 == 85 || (nint)obj59 == 86 || (nint)obj59 == 87 || (nint)obj59 == 88 || (nint)obj59 == 89)
																								{
																									goto IL_2502;
																								}
																								if ((nint)obj59 != 90)
																								{
																									if ((nint)obj59 != 91)
																									{
																										if ((nint)obj59 != 92)
																										{
																											if ((nint)obj59 != 93)
																											{
																												if ((nint)obj59 != 94)
																												{
																													if ((nint)obj59 != 95)
																													{
																														if ((nint)obj59 != 96)
																														{
																															if ((nint)obj59 != 97)
																															{
																																if ((nint)obj59 != 98)
																																{
																																	if ((nint)obj59 != 99)
																																	{
																																		if ((nint)obj59 != 100)
																																		{
																																			if ((nint)obj59 != 101)
																																			{
																																				if ((nint)obj59 != 102)
																																				{
																																					if ((nint)obj59 != 103 && (nint)obj59 != 104 && (nint)obj59 != 105 && (nint)obj59 != 106 && (nint)obj59 != 107)
																																					{
																																						if ((nint)obj59 != 108 && (nint)obj59 != 109 && (nint)obj59 != 110 && (nint)obj59 != 111 && (nint)obj59 != 112 && (nint)obj59 != 113 && (nint)obj59 != 114 && (nint)obj59 != 115)
																																						{
																																							if ((nint)obj59 == 116)
																																							{
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																								object obj60 = default;
																																								obj38 = obj60;
																																								obj40 = obj41;
																																								goto IL_2b64;
																																							}
																																							if ((nint)obj59 == 117)
																																							{
																																								object obj61 = obj7 + 4;
																																								object obj62 = obj61 + 1;
																																								obj61 = obj62;
																																								object obj63 = obj62 << 2;
																																								object obj64 = obj7 + obj63;
																																								obj64 = 662;
																																								obj37 = obj32;
																																							}
																																						}
																																						goto IL_2502;
																																					}
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																					object obj65 = default;
																																					obj38 = obj65;
																																					obj40 = obj41;
																																				}
																																				else
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																					object obj66 = default;
																																					obj38 = obj66;
																																					obj40 = obj41;
																																				}
																																			}
																																			else
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																				object obj67 = default;
																																				obj38 = obj67;
																																				obj40 = obj41;
																																			}
																																		}
																																		else
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																			object obj68 = default;
																																			obj38 = obj68;
																																			obj40 = obj41;
																																		}
																																	}
																																	else
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																		object obj69 = default;
																																		obj38 = obj69;
																																		obj40 = obj41;
																																	}
																																}
																																else
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																	object obj70 = default;
																																	obj38 = obj70;
																																	obj40 = obj41;
																																}
																															}
																															else
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																object obj71 = default;
																																obj38 = obj71;
																																obj40 = obj41;
																															}
																														}
																														else
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																															object obj72 = default;
																															obj38 = obj72;
																															obj40 = obj41;
																														}
																													}
																													else
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																														object obj73 = default;
																														obj38 = obj73;
																														obj40 = obj41;
																													}
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																													object obj74 = default;
																													obj38 = obj74;
																													obj40 = obj41;
																												}
																											}
																											else
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																												object obj75 = default;
																												obj38 = obj75;
																												obj40 = obj41;
																											}
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																											object obj76 = default;
																											obj38 = obj76;
																											obj40 = obj41;
																										}
																									}
																									else
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																										object obj77 = default;
																										obj38 = obj77;
																										obj40 = obj41;
																									}
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																									object obj78 = default;
																									obj38 = obj78;
																									obj40 = obj41;
																								}
																							}
																							else
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																								object obj79 = default;
																								obj38 = obj79;
																								obj40 = obj41;
																							}
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																							object obj80 = default;
																							obj38 = obj80;
																							obj40 = obj41;
																						}
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																						object obj81 = default;
																						obj38 = obj81;
																						obj40 = obj41;
																					}
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																					object obj82 = default;
																					obj38 = obj82;
																					obj40 = obj41;
																				}
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																				object obj83 = default;
																				obj38 = obj83;
																				obj40 = obj41;
																			}
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																			object obj84 = default;
																			obj38 = obj84;
																			obj40 = obj41;
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																		object obj85 = default;
																		obj38 = obj85;
																		obj40 = obj41;
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj86 = default;
																	obj38 = obj86;
																	obj40 = obj41;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																object obj87 = default;
																obj38 = obj87;
																obj40 = obj41;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj88 = default;
															obj38 = obj88;
															obj40 = obj41;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj89 = default;
														obj38 = obj89;
														obj40 = obj41;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj90 = default;
													obj38 = obj90;
													obj40 = obj41;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj91 = default;
												obj38 = obj91;
												obj40 = obj41;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj92 = default;
											obj38 = obj92;
											obj40 = obj41;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj93 = default;
										obj38 = obj93;
										obj40 = obj41;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj94 = default;
									obj38 = obj94;
									obj40 = obj41;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj95 = default;
								obj38 = obj95;
								obj40 = obj41;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj96 = default;
							obj38 = obj96;
							obj40 = obj41;
						}
						goto IL_2b64;
					}
				}
			}
			goto IL_2502;
		}
		goto IL_2496;
		IL_2b64:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj97 = default;
		object obj98;
		if (obj40 != obj97)
		{
			obj98 = obj38;
			goto IL_2888;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		object obj99 = default;
		obj37 = obj99;
		goto IL_2502;
		IL_2c7b:
		int layer = scrollAnchor.layer;
		((AssignTextureAndMaterial)layer)._003CAwake_003Eb__3_0((Material)29);
		int layer2 = overlayParent.layer;
		((AssignTextureAndMaterial)layer2)._003CAwake_003Eb__3_0((Material)26);
		scrollGrid.BroadcastMessage("Start");
		if (~(_refreshingThemeInScrollList ? 1u : 0u) == 0)
		{
			nint num26 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ S0_v138 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj100 = (nint)0 & (nint)0x200;
			if (obj100 != null)
			{
				nint num27 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1444 @ S0_v165 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			OverlayIndex overlayIndex = ElementToCenterOn(boardIndices, (Boards.BoardId)instance.jumperSignature);
			GameObject gameObject = overlayIndex.gameObject;
			Vector2 vector2 = ((CoinBoxSizer)(object)gameObject).CalculateDistanceToBounds((UIWidget)1);
			HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
			((HoverboardBundle)(object)instance2).Charactermodel = (CharacterModel)(object)instance.jumperSignature;
			int num28 = 0;
			while (true)
			{
				List<BoardState> list2 = scrollBoards;
				if (num28 >= list2._size)
				{
					break;
				}
				BoardState boardState = scrollBoards.get_Item(num28);
				object obj101 = _previousBoardQuaternions + 16;
				int num29 = num28 << 4;
				object obj102 = obj101 + num29;
				obj2 = obj102;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ S2_v39+8]");
				_ = 0;
				((Boards.BoardId*)(int)boardId)->value__ = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Quaternion localRotation = ((Transform)boardId).localRotation;
				int num30 = num28 + 1;
				num28 = num30;
			}
			ClickedHoverboardTheme(1);
			LogError((string)(object)this, (UnityEngine.Object)1);
			return;
		}
		hasEnabledScrollElements = false;
		Boards.BoardId boardId2 = BoardTypeToCenterOn();
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)boardId2);
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SelectCurrentlyShownBoard(Boards.BoardId.surfboard);
		IEnumerator jumperSignature = ((CelebrationPopup)null).MoveNextBoxToFront();
		nint num31 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ S0_v126 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj103 = (nint)0 & (nint)0x200;
		if (obj103 != null)
		{
			nint num32 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ S0_v133 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance3 = HoverboardModelPreviewFactory.Instance;
		instance3.jumperSignature = (AnimationClip)(object)jumperSignature;
		ClickedHoverboardTheme(0);
		return;
		IL_0929:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+4]");
			object obj104 = (nint)0 << 2;
			object obj105 = obj7 + obj104;
			if ((nint)obj105 == 117)
			{
				object obj106 = obj7 + 4;
				if ((nint)obj106 > -1)
				{
					object obj107 = obj106 + -1;
					obj106 = obj107;
				}
				goto IL_2c3c;
			}
		}
		if (obj32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_2c3c;
		IL_08b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj108 = default;
		if (obj41 == obj108)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj109 = default;
			obj32 = obj109;
			goto IL_0929;
		}
		object obj110 = default;
		obj98 = obj110;
		goto IL_2888;
		IL_2888:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void ShowTimer(bool showTimer, TimeSpan timeLeft)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0044: Expected I4, but got VT
		//IL_0022: Expected VT, but got Obj
		object obj = timeLeft + 2147483648L;
		if ((long)obj > 4294967295L)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex = default;
			ex.GetObjectData((SerializationInfo)(object)"index", (StreamingContext)"Arrays larger than 2GB are not supported.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			Array.Reverse((Array)(object)this, showTimer ? 1 : 0, (int)timeLeft);
		}
	}

	private unsafe void SetupThemes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_147c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1481: Expected Obj, but got Unknown
		//IL_148a: Expected Obj, but got I4
		//IL_1499: Unknown result type (might be due to invalid IL or missing references)
		//IL_149e: Expected Obj, but got Unknown
		//IL_14a7: Expected Obj, but got I4
		//IL_14b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b5: Expected Obj, but got Unknown
		//IL_14be: Expected Obj, but got I4
		//IL_14cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d2: Expected Obj, but got Unknown
		//IL_14db: Expected Obj, but got I4
		//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ef: Expected Obj, but got Unknown
		//IL_14f8: Expected Obj, but got I4
		//IL_1507: Unknown result type (might be due to invalid IL or missing references)
		//IL_150c: Expected Obj, but got Unknown
		//IL_1533: Unknown result type (might be due to invalid IL or missing references)
		//IL_1538: Expected Obj, but got Unknown
		//IL_154e: Expected I, but got Obj
		//IL_1564: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I4
		//IL_15ec: Expected I, but got Obj
		//IL_1602: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I4
		//IL_1641: Expected I, but got Obj
		//IL_1657: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_1994: Unknown result type (might be due to invalid IL or missing references)
		//IL_1999: Expected I4, but got Unknown
		//IL_19b0: Expected I, but got Obj
		//IL_19c6: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a7: Expected Obj, but got Unknown
		//IL_16b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b5: Expected Obj, but got Unknown
		//IL_16be: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c3: Expected Obj, but got Unknown
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Expected Obj, but got Unknown
		//IL_16da: Unknown result type (might be due to invalid IL or missing references)
		//IL_16df: Expected Obj, but got Unknown
		//IL_16e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected Obj, but got Unknown
		//IL_16f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fa: Expected Obj, but got Unknown
		//IL_1711: Expected Obj, but got I4
		//IL_018c: Expected I, but got Obj
		//IL_1694: Expected Obj, but got I4
		//IL_01d9: Expected I, but got Obj
		//IL_013f: Expected I, but got Obj
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_035b: Expected Obj, but got I4
		//IL_0364: Expected Obj, but got I4
		//IL_0252: Expected I, but got Obj
		//IL_0268: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected Obj, but got Unknown
		//IL_02db: Expected Obj, but got I4
		//IL_0293: Expected I, but got Obj
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_02ff: Expected I4, but got Obj
		//IL_07e2: Expected Obj, but got I4
		//IL_074f: Expected VT, but got Obj
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_0761: Expected I4, but got Obj
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected Obj, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected Obj, but got Unknown
		//IL_07a3: Expected Obj, but got I4
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected Obj, but got Unknown
		//IL_08fb: Expected Obj, but got I4
		//IL_058b: Expected I, but got Obj
		//IL_05a1: Expected Obj, but got I
		//IL_0526: Expected Obj, but got I4
		//IL_082e: Expected I, but got Obj
		//IL_0844: Expected Obj, but got I
		//IL_05cc: Expected I, but got Obj
		//IL_1a12: Expected Obj, but got I4
		//IL_09ac: Expected Obj, but got I
		//IL_13e8: Expected I, but got Obj
		//IL_13fe: Expected Obj, but got I
		//IL_0619: Expected I, but got Obj
		//IL_062f: Expected Obj, but got I
		//IL_086f: Expected I, but got Obj
		//IL_17d3: Expected I4, but got Obj
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Expected Obj, but got Unknown
		//IL_1429: Expected I, but got Obj
		//IL_065a: Expected I, but got Obj
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected Obj, but got Unknown
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected Obj, but got Unknown
		//IL_0b52: Expected Obj, but got I4
		//IL_06d0: Expected Obj, but got I4
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected Obj, but got Unknown
		//IL_1a45: Expected Obj, but got I4
		//IL_0c03: Expected Obj, but got I
		//IL_0a9f: Expected I, but got Obj
		//IL_0ab5: Expected Obj, but got I
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected Obj, but got Unknown
		//IL_0ae0: Expected I, but got Obj
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6f: Expected Obj, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7d: Expected Obj, but got Unknown
		//IL_0da9: Expected Obj, but got I4
		//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected Obj, but got Unknown
		//IL_0e5a: Expected Obj, but got I
		//IL_0cf6: Expected I, but got Obj
		//IL_0d0c: Expected Obj, but got I
		//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e95: Expected Obj, but got Unknown
		//IL_0d37: Expected I, but got Obj
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe4: Expected Obj, but got Unknown
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Expected Obj, but got Unknown
		//IL_101e: Expected Obj, but got I4
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Expected Obj, but got Unknown
		//IL_1aad: Expected VT, but got I4
		//IL_1105: Expected Obj, but got I
		//IL_11cb: Expected VT, but got I4
		//IL_0f6b: Expected I, but got Obj
		//IL_0f81: Expected Obj, but got I
		//IL_11d9: Expected Obj, but got I4
		//IL_11e8: Expected Obj, but got F4
		//IL_120c: Expected I4, but got Obj
		//IL_1222: Expected Obj, but got I4
		//IL_113b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected Obj, but got Unknown
		//IL_1248: Expected I, but got Obj
		//IL_125e: Expected Obj, but got I
		//IL_0fac: Expected I, but got Obj
		//IL_18b4: Expected I4, but got Obj
		//IL_18ca: Expected Obj, but got I4
		//IL_18d7: Expected Obj, but got I4
		//IL_18e0: Expected Obj, but got F4
		//IL_18fb: Expected I4, but got Obj
		//IL_190a: Expected Obj, but got I4
		//IL_1171: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Expected Obj, but got Unknown
		//IL_1289: Expected I, but got Obj
		//IL_12f5: Expected I, but got Obj
		//IL_130b: Expected Obj, but got I
		//IL_1336: Expected I, but got Obj
		//IL_1369: Expected I, but got Obj
		//IL_137f: Expected Obj, but got I
		//IL_13aa: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 176;
		object obj3 = obj2 + 160;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 40;
		obj4 = 0;
		object obj5 = obj2 + 144;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 128;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 112;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 104;
		obj8 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<KeyValuePair<Boards.BoardId, Boards.Board>> list = default;
		list._002Ector();
		object obj9 = this + 164;
		obj9 = list;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v34 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v657 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		SSEventType sSEventType = default;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}
		else
		{
			sSEventType = SSEventType.None;
		}
		object obj11;
		if (_cachedActiveEventType == sSEventType)
		{
			obj11 = 0;
		}
		else
		{
			_cachedActiveEventType = sSEventType;
			obj11 = 1;
		}
		nint num3 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v47 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v647 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		bool flag = ((UnityEngine.Object)instance).m_CachedPtr == (IntPtr)0;
		object obj13 = obj11;
		if (!flag)
		{
			nint num5 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v636 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num6 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v643 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
			((UnityEngine.Object)instance2).m_CachedPtr = (IntPtr)0;
			obj13 = 1;
		}
		bool refreshingThemeInScrollList = _refreshingThemeInScrollList;
		nint num7 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v59 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num8 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v631 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.BoardId boardId = (Boards.BoardId)(obj2 + 48);
		BoardManager.MarkHoverboardAsSeen(boardId);
		nint num9 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v66 (Il2CppClass<Info.Boards>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num10 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v625 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 8);
		object obj17 = obj2 + 32;
		Transform transform2 = (Transform)(obj2 + 88);
		object obj18 = obj2 + 76;
		object obj19 = obj2 - -64;
		object obj20 = obj2 + 24;
		object obj21 = obj13 | refreshingThemeInScrollList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = ((Boards.BoardId*)(int)boardId)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v64 (Info.Boards+BoardId)+8]");
		_ = 0;
		object obj22 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj22 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num11 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v583 (Il2CppClass<Info.Boards>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num12 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v615 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			transform = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj17 = transform;
			((Boards.BoardId*)(int)boardId)->value__ = (int)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj24 = obj8 + 4;
		object obj25 = obj24 + 1;
		obj24 = obj25;
		object obj26 = obj25 << 2;
		object obj27 = obj8 + obj26;
		obj27 = 178;
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
			object obj29 = (nint)0 << 2;
			object obj30 = obj8 + obj29;
			if ((nint)obj30 == 178)
			{
				object obj31 = obj8 + 4;
				if ((nint)obj31 > -1)
				{
					object obj32 = obj31 + -1;
					obj31 = obj32;
				}
				goto IL_19e3;
			}
		}
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_19e3;
		IL_06f5:
		object obj33 = this + 168;
		List<BoardState> list2 = scrollBoards;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj34 = default;
		obj33 = obj34;
		int num13 = 0;
		while (true)
		{
			List<BoardState> list3 = scrollBoards;
			if (num13 >= list3._size)
			{
				break;
			}
			BoardState boardState = scrollBoards.get_Item(num13);
			transform.rotation = (Quaternion)boardState.boardTransform;
			((Boards.BoardId*)(int)boardId)->value__ = (int)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj35 = _previousBoardQuaternions + 16;
			int num14 = num13 << 4;
			object obj36 = obj35 + num14;
			obj36 = ((Boards.BoardId*)(int)boardId)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v64 (Info.Boards+BoardId)+8]");
			_ = 0;
			int num15 = num13 + 1;
			num13 = num15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj5 = ((Boards.BoardId*)(int)boardId)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v64 (Info.Boards+BoardId)+8]");
		_ = 0;
		object obj37 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj37 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ S0_v462 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num17 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ S0_v471 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj39 = obj8 + 4;
		object obj40 = obj39 + 1;
		obj39 = obj40;
		object obj41 = obj40 << 2;
		object obj42 = obj8 + obj41;
		obj42 = 428;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
			object obj43 = (nint)0 << 2;
			object obj44 = obj8 + obj43;
			if ((nint)obj44 == 428)
			{
				object obj45 = obj8 + 4;
				if ((nint)obj45 > -1)
				{
					object obj46 = obj45 + -1;
					obj45 = obj46;
				}
				goto IL_19f1;
			}
		}
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_19f1;
		IL_1a57:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		GameObject gameObject = scrollGrid.gameObject;
		object current = ((Transform.Enumerator)(object)gameObject).Current;
		object obj47 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj47 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ S0_v288 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj48 = (nint)0 & (nint)0x200;
			if (obj48 != null)
			{
				nint num19 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1530 @ S0_v297 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj49 = obj8 + 4;
		object obj50 = obj49 + 1;
		obj49 = obj50;
		object obj51 = obj50 << 2;
		object obj52 = obj8 + obj51;
		obj52 = 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj53 = default;
		if (obj53 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
			object obj54 = (nint)0 << 2;
			object obj55 = obj8 + obj54;
			if ((nint)obj55 == 656)
			{
				object obj56 = obj8 + 4;
				if ((nint)obj56 > -1)
				{
					object obj57 = obj56 + -1;
					obj56 = obj57;
				}
				goto IL_1a82;
			}
		}
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_1a82;
		IL_19e3:
		if (obj21 == null)
		{
			List<HoverboardOverlayHelper> list4 = boardHelpers;
			List<KeyValuePair<Boards.BoardId, Boards.Board>> boardList = _boardList;
			int size = list4._size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S1_v325 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<Info.Boards+BoardId, Info.Boards+Board>>)+C]");
			if ((nint)size == 0)
			{
				int num20 = 0;
				while (true)
				{
					List<HoverboardOverlayHelper> list5 = boardHelpers;
					if (num20 >= list5._size)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77AA");
					obj4 = ((Boards.BoardId*)(int)boardId)->value__;
					HoverboardOverlayHelper hoverboardOverlayHelper = boardHelpers.get_Item(num20);
					if ((nint)obj4 == (nint)hoverboardOverlayHelper._cachedBoardId)
					{
						int num21 = num20 + 1;
						num20 = num21;
						continue;
					}
					goto IL_06f5;
				}
				nint num22 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v500 (Il2CppClass<BoardScreenManager>)+BA]");
				object obj58 = (nint)0 & (nint)0x200;
				if (obj58 != null)
				{
					nint num23 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ S0_v529 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardModelPreviewFactory instance3 = HoverboardModelPreviewFactory.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S0_v505 (HoverboardModelPreviewFactory)+9]");
				if ((nint)0 != 0)
				{
					nint num24 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ S0_v509 (Il2CppClass<BoardScreenManager>)+BA]");
					object obj59 = (nint)0 & (nint)0x200;
					if (obj59 != null)
					{
						nint num25 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ S0_v525 (Il2CppClass<BoardScreenManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardModelPreviewFactory instance4 = HoverboardModelPreviewFactory.Instance;
					_ = 0;
					IEnumerator enumerator = ((CelebrationPopup)null).MoveNextBoxToFront();
					OverlayIndex overlayIndex = ElementToCenterOn(boardIndices, (Boards.BoardId)enumerator);
					GameObject gameObject2 = overlayIndex.gameObject;
					Vector2 vector = ((CoinBoxSizer)(object)gameObject2).CalculateDistanceToBounds((UIWidget)null);
					bool isInstanced = UIScreenController.IsInstanced;
					((UIModelController)isInstanced).SelectCurrentlyShownBoard(Boards.BoardId.surfboard);
					HoverboardModelPreviewFactory instance5 = HoverboardModelPreviewFactory.Instance;
					((HoverboardBundle)(object)instance5).Charactermodel = (CharacterModel)enumerator;
				}
				goto IL_13da;
			}
		}
		goto IL_06f5;
		IL_1a24:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj7 = ((Boards.BoardId*)(int)boardId)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v64 (Info.Boards+BoardId)+8]");
		_ = 0;
		object obj60 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj60 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num26 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ S0_v348 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj61 = (nint)0 & (nint)0x200;
			if (obj61 != null)
			{
				nint num27 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1308 @ S0_v357 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj62 = obj8 + 4;
		object obj63 = obj62 + 1;
		obj62 = obj63;
		object obj64 = obj63 << 2;
		object obj65 = obj8 + obj64;
		obj65 = 564;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
			object obj66 = (nint)0 << 2;
			object obj67 = obj8 + obj66;
			if ((nint)obj67 == 564)
			{
				object obj68 = obj8 + 4;
				if ((nint)obj68 > -1)
				{
					object obj69 = obj68 + -1;
					obj68 = obj69;
				}
				goto IL_1a57;
			}
		}
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_1a57;
		IL_1a82:
		int layer = scrollAnchor.layer;
		int layer2 = scrollAnchor.layer;
		transform.localPosition = (Vector3)layer2;
		int layer3 = scrollAnchor.layer;
		transform2.localPosition = (Vector3)layer3;
		obj18 = 0;
		_ = 0;
		obj18 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v71 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		((Boards.BoardId*)(int)boardId)->value__ = (int)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v77+8]");
		_ = 0;
		Vector3 eulerAngles = ((Transform)boardId).eulerAngles;
		Camera anchorCamera = scrollPanel.anchorCamera;
		nint num28 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1574 @ S1_v145 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj70 = (nint)0 & (nint)0x200;
		if (obj70 != null)
		{
			nint num29 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1580 @ S1_v168 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		((Boards.BoardId*)(int)boardId)->value__ = (int)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v79+8]");
		_ = 0;
		Vector3 eulerAngles2 = ((Transform)boardId).eulerAngles;
		obj2 = 0;
		obj2 = 0f;
		_ = 0f;
		obj20 = obj2;
		((Boards.BoardId*)(int)boardId)->value__ = (int)obj20;
		scrollPanel.clipTexture = (Texture2D)boardId;
		_centerer.OnEnable();
		SpringPanel component = scrollPanel.GetComponent<SpringPanel>();
		nint num30 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ S0_v211 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj71 = (nint)0 & (nint)0x200;
		if (obj71 != null)
		{
			nint num31 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ S0_v228 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			nint num32 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ S0_v220 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj72 = (nint)0 & (nint)0x200;
			if (obj72 != null)
			{
				nint num33 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ S0_v225 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(component);
		}
		RefreshBoards();
		goto IL_13da;
		IL_19f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj6 = ((Boards.BoardId*)(int)boardId)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v64 (Info.Boards+BoardId)+8]");
		_ = 0;
		object obj73 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj73 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num34 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ S0_v408 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj74 = (nint)0 & (nint)0x200;
			if (obj74 != null)
			{
				nint num35 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1130 @ S0_v417 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj75 = obj8 + 4;
		object obj76 = obj75 + 1;
		obj75 = obj76;
		object obj77 = obj76 << 2;
		object obj78 = obj8 + obj77;
		obj78 = 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+4]");
			object obj79 = (nint)0 << 2;
			object obj80 = obj8 + obj79;
			if ((nint)obj80 == 496)
			{
				object obj81 = obj8 + 4;
				if ((nint)obj81 > -1)
				{
					object obj82 = obj81 + -1;
					obj81 = obj82;
				}
				goto IL_1a24;
			}
		}
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_1a24;
		IL_13da:
		nint num36 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ S0_v105 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj83 = (nint)0 & (nint)0x200;
		if (obj83 != null)
		{
			nint num37 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S0_v112 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance6 = HoverboardModelPreviewFactory.Instance;
		_ = 0;
	}

	public unsafe void ScrollClicked(Vector2 pos)
	{
		//IL_0678: Expected I, but got Obj
		//IL_068e: Expected Obj, but got I
		//IL_09fa: Expected I, but got Obj
		//IL_0a10: Expected Obj, but got I
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected Ref, but got Unknown
		//IL_06dd: Expected I, but got Obj
		//IL_06f3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0722: Expected I4, but got Obj
		//IL_073c: Invalid comparison between Obj and VT
		//IL_0060: Expected I, but got Obj
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_076a: Expected Obj, but got VT
		//IL_0186: Expected I, but got Obj
		//IL_011e: Invalid comparison between VT and I4
		//IL_01ea: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I4
		//IL_0240: Expected I, but got Obj
		//IL_0256: Expected Obj, but got I
		//IL_07ab: Expected Obj, but got I4
		//IL_0281: Expected I, but got Obj
		//IL_02c9: Expected Obj, but got I4
		//IL_02db: Expected I, but got Obj
		//IL_02f1: Expected Obj, but got I
		//IL_031c: Expected I, but got Obj
		//IL_0369: Expected I, but got Obj
		//IL_037f: Expected Obj, but got I
		//IL_0809: Expected Obj, but got I
		//IL_03aa: Expected I, but got Obj
		//IL_03f7: Expected I, but got Obj
		//IL_040d: Expected Obj, but got I
		//IL_0855: Expected I, but got Obj
		//IL_086b: Expected Obj, but got I
		//IL_0438: Expected I, but got Obj
		//IL_092f: Expected I, but got Obj
		//IL_0945: Expected Obj, but got I
		//IL_0979: Expected I, but got Obj
		//IL_098f: Expected Obj, but got I
		//IL_054d: Expected I, but got Obj
		//IL_08aa: Expected I, but got Obj
		//IL_08c0: Expected Obj, but got I
		//IL_09c8: Expected I4, but got Obj
		//IL_059a: Expected I, but got Obj
		//IL_0913: Expected Obj, but got I4
		//IL_0913: Expected Obj, but got I4
		//IL_0913: Expected Obj, but got I
		//IL_04a9: Expected I, but got Obj
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected I4, but got Unknown
		//IL_0665: Expected Obj, but got I4
		//IL_0665: Expected Obj, but got I4
		//IL_0665: Expected Obj, but got I4
		//IL_0665: Expected Obj, but got I
		//IL_05e7: Expected I, but got Obj
		//IL_04f6: Expected I, but got Obj
		nint num = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v117 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
		nint num3 = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v2 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S2_v42 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool themeId = ((NotificationsObserver)(object)instance2.jumperSignature).DidAppStartFromNotificationAndroid(out *(Notification*)(pos - 1));
		nint num5 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S2_v9 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v38 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = BoardManager.IsThemeActive((Boards.BoardId)instance.jumperSignature, themeId ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none);
		HoverboardModelPreviewFactory instance3 = HoverboardModelPreviewFactory.Instance;
		if ((object)instance3.speederSignature == (object)pos)
		{
			if (flag)
			{
				_hoverboardSelectButton.OnFinishedWatchingVideo();
			}
			else if (pos != (Vector2)(object)0)
			{
				return;
			}
		}
		nint num7 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v21 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v108 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance4 = HoverboardModelPreviewFactory.Instance;
		instance4.speederSignature = (AnimationClip)pos;
		_hoverboardSelectButton.OnEnable();
		bool oldHoverboardOwned = _oldHoverboardOwned;
		_oldHoverboardOwned = flag;
		HoverboardModelPreviewFactory instance5 = HoverboardModelPreviewFactory.Instance;
		HoverboardModelPreviewFactory instance6 = HoverboardModelPreviewFactory.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E7E");
		object obj5 = flag & oldHoverboardOwned;
		if (obj5 != null)
		{
			return;
		}
		bool isInstanced = UIScreenController.IsInstanced;
		Characters.CharacterId activeCharacterId = ((UIModelController)isInstanced).GetActiveCharacterId(UIModelController.ModelScreen.Boards);
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v104 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)activeCharacterId).FindKernel(null) == 0)
		{
			return;
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)activeCharacterId).AddEquippedHoverboard();
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v100 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)hoverboardBundle).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v96 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v39 (SYBO.Subway.Info.Characters+CharacterId)+A8]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			return;
		}
		nint num15 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v66 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num16 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v92 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance7 = HoverboardModelPreviewFactory.Instance;
		bool flag2 = (nint)instance7.speederSignature < 1;
		nint num17 = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S1_v31 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		bool flag3 = obj10 == null;
		if (flag2)
		{
			if (!flag3)
			{
				nint num18 = (nint)typeof(HoverboardModelPreviewFactory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v88 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CoinMagnet instance8 = CoinMagnet.Instance;
			nint num19 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S1_v48 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num20 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S1_v55 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance9 = HoverboardModelPreviewFactory.Instance;
			AnimationClip jumperSignature = instance9.jumperSignature;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v39 (SYBO.Subway.Info.Characters+CharacterId)+A8]");
			((TutorialMultilineLabelsHelper)(object)instance8).SetText((string)(object)jumperSignature, (string)(object)hoverboardBundle, (string)0, (string)1, (string)1, (string)null);
			return;
		}
		if (!flag3)
		{
			nint num21 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v79 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinMagnet instance10 = CoinMagnet.Instance;
		nint num22 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v36 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num23 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S1_v43 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance11 = HoverboardModelPreviewFactory.Instance;
		nint num24 = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S2_v26 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num25 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S2_v31 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance12 = HoverboardModelPreviewFactory.Instance;
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)instance12.jumperSignature);
		HoverboardModelPreviewFactory instance13 = HoverboardModelPreviewFactory.Instance;
		int index = instance13.speederSignature - 1;
		HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
		AnimationClip jumperSignature2 = instance11.jumperSignature;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v39 (SYBO.Subway.Info.Characters+CharacterId)+A8]");
		((TutorialMultilineLabelsHelper)(object)instance10).SetText((string)(object)jumperSignature2, (string)(object)hoverboardBundle, (string)0, (string)1, (string)1, (string)hoverboardTheme.power);
	}

	private Boards.BoardId BoardTypeToCenterOn()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		Boards.BoardId boardId = default;
		object obj = boardId + 16;
		obj = this;
		return boardId;
	}

	private T ElementToCenterOn<T>(List<T> elements, Boards.BoardId board)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_007a: Expected VT, but got Obj
		//IL_006d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x3FFF;
		object obj4 = obj3 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj5 = default;
		if (obj5 != null)
		{
			return (T)board;
		}
		return (T)elements;
	}

	private unsafe void ScaleScrollModels(bool forceUpdate = false)
	{
		//IL_01c8: Expected Obj, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected I4, but got Unknown
		//IL_01e3: Expected I4, but got Obj
		//IL_01f2: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0227: Expected I, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_0268: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0299: Expected I, but got Obj
		//IL_02af: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		object obj = ((bool*)(forceUpdate ? 1 : 0))->m_value;
		int num = obj + 8;
		((int*)num)->m_value = (int)obj;
		if (!CharacterStickerManager.HasThemeBeenSeenForCharacter((Characters.CharacterId)_centerer, num))
		{
			return;
		}
		nint num2 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v35 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		nint num4 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v10 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v27 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!BoardManager.HasAllThemesBeenSeen((Boards.BoardId)instance.jumperSignature))
		{
			return;
		}
		nint num6 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v23 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v31 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.boardSelected += null;
		nint num8 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v18 (Il2CppClass<NGUITools>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v23 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string hierarchy = NGUITools.GetHierarchy((GameObject)(object)selectSound);
	}

	private void Update()
	{
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_026f: Expected I4, but got Obj
		//IL_0282: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v41 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v20 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v3 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v4+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S2_v5+44]");
		object obj5 = 0;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v60 @ S3_v4 (should have been resolved before IL gen)");
		object obj8 = default;
		if ((nint)obj8 > -1)
		{
			nint num6 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v18 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num8 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v26 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v31 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)instance2.jumperSignature);
			_hoverboardThemeShifter.UpdateSelector((int)list);
		}
		else
		{
			_hoverboardThemeShifter.UpdateThemeStates();
		}
	}

	private unsafe void UpdateBoardEnabledState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Expected Ref, but got Unknown
		//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8f: Expected VT, but got Unknown
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Expected Obj, but got Unknown
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cab: Expected Obj, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected Obj, but got Unknown
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Expected Obj, but got Unknown
		//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Expected Obj, but got Unknown
		//IL_0cde: Expected Obj, but got I4
		//IL_0cec: Expected VT, but got I4
		//IL_0cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfa: Expected Obj, but got Unknown
		//IL_0d03: Expected Obj, but got I4
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected Obj, but got Unknown
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0d8a: Expected I, but got Obj
		//IL_0da0: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		//IL_01aa: Expected I, but got Obj
		//IL_1123: Expected I, but got Obj
		//IL_1139: Expected Obj, but got I
		//IL_1210: Expected Obj, but got I4
		//IL_0b9d: Expected Obj, but got I
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Expected I4, but got Unknown
		//IL_0b4d: Expected I, but got Obj
		//IL_0258: Expected Ref, but got F4
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_02a3: Expected I, but got Obj
		//IL_02b9: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		//IL_1045: Expected Obj, but got I4
		//IL_0e8a: Expected I, but got Obj
		//IL_0ea0: Expected Obj, but got I
		//IL_08bc: Expected I, but got Obj
		//IL_03ee: Expected I, but got Obj
		//IL_0404: Expected Obj, but got I
		//IL_0313: Expected I, but got Obj
		//IL_0c21: Expected Obj, but got I4
		//IL_0c31: Expected Obj, but got I4
		//IL_0909: Expected I, but got Obj
		//IL_0360: Expected I, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_050a: Expected I, but got Obj
		//IL_0520: Expected Obj, but got I
		//IL_042f: Expected I, but got Obj
		//IL_047c: Expected I, but got Obj
		//IL_0492: Expected Obj, but got I
		//IL_03a1: Expected I, but got Obj
		//IL_0613: Expected Obj, but got I4
		//IL_0621: Expected I, but got Obj
		//IL_0637: Expected Obj, but got I
		//IL_054b: Expected I, but got Obj
		//IL_0598: Expected I, but got Obj
		//IL_05ae: Expected Obj, but got I
		//IL_04bd: Expected I, but got Obj
		//IL_06b8: Expected Obj, but got VT
		//IL_06cd: Expected VT, but got I
		//IL_0662: Expected I, but got Obj
		//IL_0f71: Expected Obj, but got I4
		//IL_05d9: Expected I, but got Obj
		//IL_09e5: Expected VT, but got Obj
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Expected Obj, but got Unknown
		//IL_0a16: Expected I, but got Obj
		//IL_0a2c: Expected Obj, but got I
		//IL_107a: Expected F4, but got Obj
		//IL_1075: Expected native int or pointer, but got VT
		//IL_108c: Expected F4, but got I
		//IL_1087: Expected native int or pointer, but got VT
		//IL_10ae: Expected VT, but got Ref
		//IL_10d9: Expected VT, but got Obj
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb9: Expected Obj, but got Unknown
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Expected I4, but got Unknown
		//IL_0fcf: Expected Obj, but got I4
		//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected Obj, but got Unknown
		//IL_0ff3: Expected Obj, but got I4
		//IL_0aa3: Expected F4, but got Obj
		//IL_0a9e: Expected native int or pointer, but got VT
		//IL_0ab5: Expected F4, but got I
		//IL_0ab0: Expected native int or pointer, but got VT
		//IL_0adb: Expected VT, but got Ref
		//IL_0afd: Expected Obj, but got Ref
		//IL_0a57: Expected I4, but got Obj
		//IL_07f7: Expected Obj, but got I
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected Obj, but got Unknown
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 160;
		ref Vector3 reference = ref *(Vector3*)(obj2 + 136);
		Quaternion quaternion = (Quaternion)(obj2 + 120);
		Transform transform = (Transform)(obj2 - -64);
		object obj3 = obj2 + 48;
		object obj4 = obj2 + 32;
		Transform transform2 = (Transform)(obj2 + 16);
		BoardState boardState = (BoardState)(obj2 + 104);
		boardState = (BoardState)0;
		boardState.defaultRotation = (Quaternion)0;
		object obj5 = obj2 + 88;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 80;
		obj6 = obj;
		_ = -1;
		if (~(_hasInited ? 1u : 0u) != 0 || _boardList == null)
		{
			return;
		}
		nint num = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v39 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v351 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v44 (HoverboardModelPreviewFactory)+D]");
		if ((nint)0 != 0 && ~(_inappOverlayActive ? 1u : 0u) != 0 && ~(_popupActive ? 1u : 0u) != 0)
		{
			InitializeSelectButton();
			nint num3 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v341 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v347 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
			_ = 0;
		}
		VerifyBoardAmount();
		CenterOnChild centerer = _centerer;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v329 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)centerer._selectedObject).FindKernel((string)null) != 0)
		{
			CenterOnChild centerer2 = _centerer;
			OverlayIndex component = centerer2._selectedObject.GetComponent<OverlayIndex>();
			BoardState boardState2 = scrollBoards.get_Item(component._index);
			Vector3 up = boardState2.boardTransform.up;
			float unscaledTime = Time.unscaledTime;
			float angle = 0f - unscaledTime;
			reference = ref *(Vector3*)quaternion.x;
			_ = quaternion.z;
			boardState2.boardTransform.RotateAroundInternal_Injected(ref reference, angle);
			HoverboardOverlayHelper hoverboardOverlayHelper = boardHelpers.get_Item(component._index);
			nint num7 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v115 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			bool flag = obj10 == null;
			if (~(_hasSetupScroll ? 1u : 0u) == 0)
			{
				if (!flag)
				{
					nint num8 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v325 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardModelPreviewFactory instance3 = HoverboardModelPreviewFactory.Instance;
				bool flag3;
				if ((nint)instance3.jumperSignature == (nint)hoverboardOverlayHelper._cachedBoardId)
				{
					nint num9 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v313 (Il2CppClass<BoardScreenManager>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num10 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S0_v321 (Il2CppClass<BoardScreenManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardModelPreviewFactory instance4 = HoverboardModelPreviewFactory.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v318 (HoverboardModelPreviewFactory)+B]");
					bool flag2 = (nint)0 == 0;
					flag3 = false;
					if (flag2)
					{
						goto IL_0e72;
					}
				}
				nint num11 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v184 (Il2CppClass<BoardScreenManager>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num12 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v308 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardModelPreviewFactory instance5 = HoverboardModelPreviewFactory.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v189 (HoverboardModelPreviewFactory)+B]");
				if ((nint)0 == 0)
				{
					nint num13 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S0_v296 (Il2CppClass<BoardScreenManager>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num14 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v304 (Il2CppClass<BoardScreenManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardModelPreviewFactory instance6 = HoverboardModelPreviewFactory.Instance;
					instance6.speederSignature = null;
					_hoverboardSelectButton.OnEnable();
				}
				nint num15 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v194 (Il2CppClass<BoardScreenManager>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num16 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v291 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardModelPreviewFactory instance7 = HoverboardModelPreviewFactory.Instance;
				if ((nint)instance7.jumperSignature != (nint)hoverboardOverlayHelper._cachedBoardId)
				{
					nint num17 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ S0_v282 (Il2CppClass<BoardScreenManager>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num18 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S0_v288 (Il2CppClass<BoardScreenManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardModelPreviewFactory instance8 = HoverboardModelPreviewFactory.Instance;
					((HoverboardBundle)(object)instance8).Charactermodel = (CharacterModel)hoverboardOverlayHelper._cachedBoardId;
				}
				((CelebrationPopup)this).PayoutReward((CelebrationReward)1, true, false);
				nint num19 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S0_v205 (Il2CppClass<BoardScreenManager>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num20 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S0_v277 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardModelPreviewFactory instance9 = HoverboardModelPreviewFactory.Instance;
				_ = 0;
				HoverboardOverlayHelper hoverboardOverlayHelper2 = boardHelpers.get_Item(component._index);
				hoverboardOverlayHelper2.Update();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				boardState = (BoardState)reference;
				BoardState boardState3 = boardState;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
				boardState3.defaultRotation = (Quaternion)0;
				flag3 = false;
				object obj17 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj17 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ S0_v266+14]");
					bool flag4 = (nint)0 != component._index;
					bool flag5 = !flag4;
					bool flag6 = flag3;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						flag6 = false;
						flag3 = false;
					}
					flag3 = flag6;
				}
				object obj18 = obj6 + 4;
				int num21 = obj18 + 1;
				obj18 = num21;
				int num22 = num21 << 2;
				object obj19 = obj6 + num22;
				obj19 = 381;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30+4]");
					object obj20 = (nint)0 << 2;
					object obj21 = obj6 + obj20;
					if ((nint)obj21 == 381)
					{
						object obj22 = obj6 + 4;
						if ((nint)obj22 > -1)
						{
							object obj23 = obj22 + -1;
							obj22 = obj23;
						}
						goto IL_0e72;
					}
				}
				object obj24 = default;
				if (obj24 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
			else
			{
				if (!flag)
				{
					nint num23 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v171 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardModelPreviewFactory instance10 = HoverboardModelPreviewFactory.Instance;
				instance10.jumperSignature = (AnimationClip)hoverboardOverlayHelper._cachedBoardId;
				_hasSetupScroll = true;
				bool flag3 = false;
			}
			goto IL_0e72;
		}
		goto IL_11d3;
		IL_0e72:
		CenterOnChild centerer3 = _centerer;
		nint num24 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num25 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v111 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num26;
		if (((ComputeShader)(object)centerer3._selectedObject).FindKernel((string)null) != 0)
		{
			CenterOnChild centerer4 = _centerer;
			OverlayIndex component2 = centerer4._selectedObject.GetComponent<OverlayIndex>();
			num26 = component2._index;
		}
		else
		{
			num26 = -1;
		}
		int num27 = 0;
		while (true)
		{
			List<BoardState> list = scrollBoards;
			if (num27 >= list._size)
			{
				break;
			}
			if (num27 != num26)
			{
				BoardState boardState4 = scrollBoards.get_Item(num27);
				Transform parentInternal = boardState4.boardTransform.parentInternal;
				transform.rotation = (Quaternion)parentInternal;
				object obj26 = boardState4 + 8;
				obj3 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S1_v80+8]");
				_ = 0;
				nint num28 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ S0_v142 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					int num29 = (int)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S0_v155 (System.Int32)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Quaternion*)(nint)quaternion)->x = (float)transform;
				((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				reference = ref *(Vector3*)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				_ = 0;
				Vector3 vector = quaternion * (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				transform2.rotation = (Quaternion)boardState4.boardTransform;
				float unscaledTime2 = Time.unscaledTime;
				((Quaternion*)(nint)quaternion)->x = (float)transform2;
				((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				reference = ref *(Vector3*)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24+8]");
				_ = 0;
				Quaternion quaternion2 = Quaternion.RotateTowards(quaternion, (Quaternion)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), unscaledTime2);
				reference = ref *(Vector3*)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Quaternion localRotation = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localRotation;
			}
			int num30 = num27 + 1;
			num27 = num30;
		}
		goto IL_11d3;
		IL_11d3:
		LogError((string)(object)this);
		if (~(hasEnabledScrollElements ? 1u : 0u) != 0)
		{
			ClickedHoverboardTheme(1);
			hasEnabledScrollElements = true;
		}
		nint num31 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v65 (Il2CppClass<UIScreenController>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num32 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v92 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag7 = UIScreenController.ShouldShowOnlineScreen();
		bool popupActive = ((UIScreenController)flag7).IsPopupQueueEmpty();
		_popupActive = popupActive;
		bool flag8 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v34 (System.Boolean)+EC]");
		string text = ((GameObject)0).tag;
		bool inappOverlayActive = (byte)(text & 1) != 0;
		_inappOverlayActive = inappOverlayActive;
		if (~(_inappOverlayActive ? 1u : 0u) != 0 && ~(_popupActive ? 1u : 0u) != 0)
		{
			if (!_modelsEnabled)
			{
				scrollAnchor.tag = (string)1;
				overlayParent.tag = (string)1;
				_modelsEnabled = true;
			}
		}
		else if (~(_modelsEnabled ? 1u : 0u) == 0)
		{
			scrollAnchor.tag = null;
			overlayParent.tag = null;
			_modelsEnabled = false;
		}
	}

	private void VerifyBoardAmount()
	{
		//IL_014a: Expected VT, but got Obj
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_0194: Expected F4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I4
		GameObject gameObject = scrollPanel.gameObject;
		Transform transform = default;
		transform.localPosition = (Vector3)gameObject;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Math.Abs((float)transform);
		float width = num3 / _cellWidth;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		int num4 = 0;
		while (true)
		{
			List<BoardState> list = scrollBoards;
			if (num4 >= list._size)
			{
				break;
			}
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v22 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v40 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int[] values = (int[])(num4 - gUILayoutOption);
			int num7 = Mathf.Min(values);
			bool flag = num7 < 5;
			BoardState boardState = scrollBoards.get_Item(num4);
			boardState.boardRoot.tag = (string)flag;
			HoverboardOverlayHelper hoverboardOverlayHelper = boardHelpers.get_Item(num4);
			string text = hoverboardOverlayHelper.tag;
			((GameObject)(object)text).tag = (string)flag;
			int num8 = num4 + 1;
			num4 = num8;
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02f3: Expected Obj, but got I
		//IL_0304: Expected VT, but got Obj
		//IL_0312: Expected I, but got Obj
		//IL_0328: Expected Obj, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_035c: Expected F4, but got Obj
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03e4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected I4, but got Unknown
		//IL_0480: Expected Obj, but got I
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_04c2: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I
		//IL_014a: Expected I, but got Obj
		//IL_0608: Expected Obj, but got I
		//IL_0197: Expected I, but got Obj
		//IL_01ad: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I
		//IL_0225: Expected I, but got Obj
		//IL_023b: Expected Obj, but got I
		//IL_01d8: Expected I, but got Obj
		//IL_05c0: Expected VT, but got Obj
		//IL_05ee: Expected Obj, but got I4
		//IL_0266: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+34]");
		GameObject gameObject = ((Component)0).gameObject;
		transform.localPosition = (Vector3)gameObject;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v66 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj + 12;
		float num3 = Math.Abs((float)transform);
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+B4]");
		float num5 = num4 - 0f;
		float num6 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+B0]");
		float value = num6 - 0f;
		float num7 = Math.Abs(value);
		bool flag = num7 > 1f;
		object obj4 = flag | context;
		bool flag2 = num5 == num5;
		bool flag3 = num5 != 0f;
		object obj5 = flag2 & flag3;
		object obj6 = obj5 | (object)context;
		if (obj6 == null)
		{
			return;
		}
		nint num8 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v89 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num10 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+A0]");
		float width = num10 / 0f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		int num11 = gUILayoutOption - 4;
		bool flag4 = 0 > num11;
		bool flag5 = !flag4;
		int num12 = num11;
		if (!flag5)
		{
			num12 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+BC]");
		object obj8 = 0;
		object obj9 = gUILayoutOption + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v38+C]");
		bool flag6 = 0 >= (nint)obj9;
		bool flag7 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v38+C]");
		object obj10 = 0;
		if (!flag7)
		{
			obj10 = obj9;
		}
		while (num12 < (nint)obj10)
		{
			nint num13 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v47 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num14 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v83 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num15 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+A0]");
			object obj12 = (nint)num15 * (nint)0;
			float value2 = num3 - (float)obj12;
			float num16 = Math.Abs(value2);
			float num17 = 1.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+A0]");
			float num18 = num17 * 0f;
			float deltaTime;
			if (obj4 != null)
			{
				nint num19 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v67 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num20 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v79 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num21 = num16 / num18;
				float num22 = Mathf.InverseLerp(10f, 7f, num21);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+BC]");
				BoardState boardState = ((List<BoardState>)0).get_Item(num12);
				int layer = boardState.boardRoot.layer;
				nint num23 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v50 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num24 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v62 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 forward = Vector3.forward;
				transform = (Transform)obj3;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v13+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				Vector3 vector = (Vector3)transform / num22;
				transform = (Transform)obj;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				((Transform)layer).parent = transform;
				deltaTime = num21;
			}
			else
			{
				float num25 = num16 / num18;
				deltaTime = num25;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+C0]");
			HoverboardOverlayHelper hoverboardOverlayHelper = ((List<HoverboardOverlayHelper>)0).get_Item(num12);
			((TickableScheduler)(object)hoverboardOverlayHelper).Tick(deltaTime);
			int num26 = num12 + 1;
			num12 = num26;
		}
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}
}
