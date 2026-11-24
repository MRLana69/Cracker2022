using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cloud;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UI.Generic;
using UI.ModelCamera;
using UI.Screens.BoardScreenInternal;
using UI.Screens.CharacterScreenInternal;
using UI.VideoAdPrizes;
using UnityEngine;

namespace UI.Screens;

public class CharacterScreen : UIScreen
{
	public class RibbonPayload
	{
		public bool shouldShow;

		public string line1;

		public string line2;

		public string line3;

		public RibbonPayload()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private sealed class _003CEnableCamerasDelayed_003Ed__59(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterScreen _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Expected Obj, but got Unknown
				//IL_0073: Expected Obj, but got I4
				//IL_0091: Expected I, but got Obj
				//IL_00a7: Expected Obj, but got I
				//IL_0188: Expected Obj, but got I4
				//IL_0188: Expected Obj, but got I
				//IL_0127: Expected Obj, but got I4
				//IL_0127: Expected Obj, but got I
				//IL_00d2: Expected I, but got Obj
				CharacterScreen characterScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (System.Boolean)+20]");
						((Component)0).tag = (string)1;
						bool flag2 = UIScreenController.ShouldShowOnlineScreen();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v26 (System.Boolean)+38]");
						((Component)0).tag = (string)1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				characterScreen._firstShow = false;
				object obj2 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj3 = default;
				obj2 = obj3;
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

	private sealed class _003CDelayedInitCenterChar_003Ed__63(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterScreen _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				//IL_0094: Expected VT, but got I4
				CharacterScreen characterScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						CharacterScreenManager screenManagerInstance = characterScreen._screenManagerInstance;
						characterScreen.ScrollClicked((Vector2)screenManagerInstance.currentlyShownCharacter__BackingField);
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

	private UIGrid _characterGrid;

	private UIPanel _scrollPanel;

	private GameObject _scrollPlaceholderPrefab;

	private UILabel _nameTitle;

	private UILabel _nameSubtitle;

	private GameObject _eventRibbon;

	private UILabel[] _ribbonLabels;

	private AudioClip _selectSound;

	private UICharacterThemeShifter _characterThemeShifter;

	private GameObject _characterDayParticleSystem;

	private GameObject _characterSelectButtonPrefab;

	private GameObject _centerAnchor;

	private TimerHelper _timerPrefab;

	private UIWidget _timerContainer;

	private GameObject _scrollListParent;

	public static bool forceRefreshOnCharacterScreen;

	public static bool forceCenterOnEventCharacter;

	public static bool forceCenterOnCurrentlySelectedCharacter;

	public readonly Vector3 scrollCharacterPosition;

	public readonly Vector3 scrollCharacterRotation;

	private Characters.CharacterId _initiallyCenteredCharacterId;

	public const float DEFAULT_SCALE_FACTOR = 7f;

	public const float FOCUSED_SCALE_FACTOR = 10f;

	private const int SCROLL_CHARACTER_LOADED_RANGE = 4;

	private const int SCROLL_CHARACTER_VISIBILITY_COUNT = 4;

	private const int SCALE_MODEL_COUNT = 4;

	private const int SYNCHRONOUSLY_LOADED_MODELS = 5;

	private const float SCALE_MODEL_MAX_DISTANCE_FACTOR = 1.5f;

	private static readonly Vector3 SELECT_BUTTON_POSITION;

	private const string CHARACTER_SCREEN_DEBUG_LOG_TAG = "Character Screen: ";

	private const Characters.CharacterId DEFAULT_CHARACTER_TO_CENTER = Characters.CharacterId.slick;

	private List<KeyValuePair<Characters.CharacterId, Characters.Model>> _characterList;

	public CharacterListManager _characterListManager;

	private CharacterSelectButton _characterSelectButton;

	public CharacterScreenManager _screenManagerInstance;

	private float _cellWidth;

	private bool _hasShownModel;

	private SSEventType _cachedActiveEventType;

	private long _cachedActiveEventID;

	private bool _inappOverlayActive;

	private bool _popupActive;

	private bool _charactersEnabled;

	private bool _firstShow;

	private bool _hasInited;

	private TimerHelper _timer;

	private CenterOnChild _centerer;

	private bool _scrollListInitialized;

	private bool _initialCenteredCharacterSelected;

	public int _cachedCenteredIndex;

	private bool _hasSetiPhoneXOffsetsIfNecessary;

	public unsafe Characters.CharacterId initiallyCenteredCharacter
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			return ((OnlineSettings)(object)saveDataPath).TryGetValue("character_name_event_skip_with_ads", out *(string*)1) ? Characters.CharacterId.tricky : Characters.CharacterId.slick;
		}
		private set
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected Obj, but got Unknown
			//IL_00a3: Expected Obj, but got I4
			//IL_0030: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 8;
			obj = 0;
			((CharacterNameEventPopup)this).RefreshDescriptionBox();
			SSEventType cachedActiveEventType = _cachedActiveEventType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (SSEventType)+C]");
			if ((nint)0 >= (nint)value)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77C2");
				IEnumerator routine = default;
				Coroutine coroutine = StartCoroutine_Auto(routine);
				object obj3 = value - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77A9");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77C3");
				IEnumerator routine2 = default;
				Coroutine coroutine2 = StartCoroutine_Auto(routine2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77A9");
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77C3");
				IEnumerator routine3 = default;
				Coroutine coroutine3 = StartCoroutine_Auto(routine3);
			}
		}
	}

	public override void Init()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got F4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got F4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got F4
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01ca: Expected I, but got Obj
		//IL_01e0: Expected Obj, but got I
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got VT
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got VT
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 152;
		object obj2 = default;
		obj = obj2;
		object obj4 = default;
		object obj3 = obj4 + 40;
		obj3 = 0;
		_ = 0;
		obj3 = 0f;
		_ = 4f;
		_ = 0f;
		object obj5 = obj4 + 52;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
		_ = 0;
		object obj6 = this + 184;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+8]");
		_ = 0;
		object obj7 = obj4 + 24;
		obj7 = 0;
		_ = 0;
		obj7 = 0f;
		_ = 210f;
		_ = 17f;
		obj5 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26+8]");
		_ = 0;
		object obj8 = this + 196;
		obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+8]");
		_ = 0;
		object obj9 = obj4 + 8;
		obj9 = 0;
		_ = 0;
		obj9 = 4.8f;
		_ = 4.8f;
		_ = 4.8f;
		obj5 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v37+8]");
		_ = 0;
		object obj10 = this + 208;
		obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+8]");
		_ = 0;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v48 (Il2CppClass<GlobalColors>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v65 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = obj4 + 4;
		obj12 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR;
		object obj13 = obj4 + 36;
		obj13 = obj12;
		obj5 = obj13;
		obj4 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_CONTENT_COLOR;
		object obj14 = obj4 + 20;
		obj14 = obj4;
		obj5 = obj14;
		((UpgradeScreen)this).Start();
	}

	private void SelectInitialCenteredCharacter()
	{
		//IL_0234: Expected I, but got Obj
		//IL_024a: Expected Obj, but got I
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got I4
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_0120: Expected I, but got Obj
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_0385: Expected F4, but got I4
		//IL_0385: Expected Obj, but got I4
		//IL_01e1: Expected I, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v51 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 140;
		bool running = FirstPurchaseBonusManager.running;
		obj2 = running;
		UIGrid characterGrid = _characterGrid;
		_cellWidth = characterGrid.cellWidth;
		object obj3 = this + 180;
		CenterOnChild component = _characterGrid.GetComponent<CenterOnChild>();
		obj3 = component;
		nint num3 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v17 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v47 (Il2CppClass<SSEventsManagerController>)+74]");
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
		ClearScrollList();
		InitializeTimer();
		Show();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
		_hasInited = true;
		nint num5 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v29 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v43 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice() || ~(_hasSetiPhoneXOffsetsIfNecessary ? 1u : 0u) == 0)
		{
			return;
		}
		int layer = _scrollListParent.layer;
		nint num7 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v28 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v36 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.OffsetLocalPosZ((Transform)layer, IPhoneXSupport.OFFSET_BOTTOM);
		_hasSetiPhoneXOffsetsIfNecessary = true;
	}

	private void InitializeCentererIfNeeded()
	{
		//IL_031b: Expected Obj, but got I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0332: Expected Obj, but got I4
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_00e6: Expected I, but got Obj
		//IL_00fc: Expected Obj, but got I
		//IL_01b5: Expected I, but got Obj
		//IL_0127: Expected I, but got Obj
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_02d3: Expected I, but got Obj
		CoinScreen coinScreen = (CoinScreen)0;
		object obj = coinScreen + 8;
		obj = 0;
		if (~(_initialCenteredCharacterSelected ? 1u : 0u) == 0)
		{
			return;
		}
		_initialCenteredCharacterSelected = true;
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v82 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool running = FirstPurchaseBonusManager.running;
		coinScreen.coinScreenHasAppeared += null;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		_initiallyCenteredCharacterId = (Characters.CharacterId)currentBoardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UI.Screens.CoinScreen)+4]");
		if ((nint)0 == 0)
		{
			nint num3 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v70 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(CharacterScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v76 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			forceCenterOnCurrentlySelectedCharacter = true;
			return;
		}
		nint num5 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v32 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v65 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (!((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		if ((nint)obj5 != 7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj6 = default;
			if ((nint)obj6 != 3)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
		if (obj == null)
		{
			return;
		}
		Characters.CharacterId initiallyCenteredCharacterId = default;
		_initiallyCenteredCharacterId = initiallyCenteredCharacterId;
		nint num7 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v50 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v56 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		forceCenterOnEventCharacter = true;
	}

	private void InitializeSelectButton()
	{
		//IL_0283: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_02d7: Expected I, but got Obj
		//IL_02ed: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_012c: Expected I, but got Obj
		//IL_0338: Expected VT, but got I4
		//IL_0346: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_03de: Expected VT, but got I4
		//IL_0079: Expected I, but got Obj
		//IL_0214: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		InitializeCentererIfNeeded();
		nint num = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v82 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = forceCenterOnEventCharacter;
		nint num3 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag2 = obj2 != null;
		if (flag)
		{
			if (flag2)
			{
				nint num4 = (nint)typeof(CharacterScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v76 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			forceCenterOnEventCharacter = false;
			forceCenterOnCurrentlySelectedCharacter = false;
			ScrollClicked((Vector2)_initiallyCenteredCharacterId);
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v67 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v72 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool index = CharacterManager.HasCharacterBeenSeen(_initiallyCenteredCharacterId);
			UpdateThemeShifter(_initiallyCenteredCharacterId, index ? 1 : 0);
			return;
		}
		if (flag2)
		{
			nint num7 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v48 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(forceCenterOnCurrentlySelectedCharacter ? 1u : 0u) != 0)
		{
			if (~(_hasShownModel ? 1u : 0u) == 0)
			{
				CharacterScreenManager screenManagerInstance = _screenManagerInstance;
				CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
				UpdateThemeShifter(screenManagerInstance.currentlyShownCharacter__BackingField, screenManagerInstance2.currentlyShownThemeIndex__BackingField);
			}
			else
			{
				UpdateCharacterModelsState();
			}
			return;
		}
		nint num8 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v29 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num9 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v37 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		forceCenterOnCurrentlySelectedCharacter = false;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		ScrollClicked((Vector2)currentBoardId);
		Boards.BoardId currentBoardId2 = PlayerSave.currentBoardId;
		Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
		UpdateThemeShifter((Characters.CharacterId)currentBoardId2, (int)currentCharacterId);
	}

	private void InitializeTimer()
	{
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_01fe: Expected I4, but got Obj
		//IL_020b: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_00af: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_0105: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v25 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 136;
		int num3 = NGUITools.CalculateNextDepth(_centerAnchor, (byte)(int)_characterSelectButtonPrefab != 0);
		CharacterSelectButton component = ((GameObject)num3).GetComponent<CharacterSelectButton>();
		obj2 = component;
		int layer = ((GameObject)num3).layer;
		nint num4 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		nint num5 = (nint)typeof(CharacterScreen);
		if (!flag)
		{
			nint num6 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v24 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num5 = (nint)typeof(CharacterScreen);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num5 = (nint)typeof(CharacterScreen);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ L1_v4 (Il2CppClass<UI.Screens.CharacterScreen>)+5C]");
		object obj4 = (nint)0 + (nint)4;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v7+8]");
		_ = 0;
		Transform transform = (Transform)(obj5 + 12);
		transform = (Transform)obj5;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77D6");
		_characterSelectButton.SetSticker(CharacterSelectButton.StickerType.None);
	}

	public override void Show()
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
		object obj2 = this + 176;
		TimerHelper timerHelper = UnityEngine.Object.Instantiate(_timerPrefab, (Transform)(object)parent);
		obj2 = timerHelper;
	}

	private IEnumerator EnableCamerasDelayed()
	{
		//IL_0007: Expected Obj, but got I4
		return (IEnumerator)_initiallyCenteredCharacterId;
	}

	public unsafe override void Hide()
	{
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_06a2: Expected I, but got Obj
		//IL_06b8: Expected Obj, but got I
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0141: Expected I, but got Obj
		//IL_0511: Expected Obj, but got I
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_020e: Expected I, but got Obj
		//IL_00f4: Expected I, but got Obj
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_031d: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_035e: Expected I, but got Obj
		//IL_0408: Expected I, but got Obj
		//IL_041e: Expected Obj, but got I
		//IL_065e: Expected Obj, but got I4
		//IL_0449: Expected I, but got Obj
		if (~(_firstShow ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v118 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v141 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v123 (System.Boolean)+20]");
			((Component)0).tag = null;
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v126 (System.Boolean)+38]");
			((Component)0).tag = null;
			nint num3 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v129 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CharacterScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v135 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			forceRefreshOnCharacterScreen = false;
		}
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action = default;
		object obj3 = action + 16;
		obj3 = this;
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v19 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v113 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(CharacterScreen.OnLastPopupClosed);
		object obj5 = action2 + 16;
		obj5 = this;
		UIScreenController.OnLastPopupClosed -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(CharacterScreen.CharacterEventStarted);
		object obj6 = action3 + 16;
		obj6 = this;
		nint num8 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v38 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v109 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventStartedHandler -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr3;
		((Delegate)action4).method = (nint)__ldftn(CharacterScreen.CharacterEventFinished);
		object obj8 = action4 + 16;
		obj8 = this;
		SSEventsManagerController.OnSSEventFinishedHandler -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr4;
		((Delegate)action5).method = (nint)__ldftn(CharacterScreen.RefreshCharacterScreen);
		object obj9 = action5 + 16;
		obj9 = this;
		UIScreenController.OnApplicationResumed -= action5;
		OnInitialModelLoadingComplete();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		Action<int> action6 = default;
		object obj10 = action6 + 16;
		obj10 = this;
		_characterThemeShifter.OnThemeButtonPressed -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		Action<Characters.CharacterId, int> action7 = default;
		object obj11 = action7 + 16;
		obj11 = this;
		nint num12 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v70 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num13 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v105 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreenManager.characterUnlocked -= action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Action action8 = default;
		((Delegate)action8).method_ptr = method_ptr5;
		((Delegate)action8).method = (nint)__ldftn(CharacterScreen.UpdateSelectedCharacter);
		object obj13 = action8 + 16;
		obj13 = this;
		CharacterScreenManager.onCharacterSelected -= action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		Action action9 = default;
		((Delegate)action9).method_ptr = method_ptr6;
		((Delegate)action9).method = (nint)__ldftn(CharacterScreen.RefreshCharacterScreen);
		object obj14 = action9 + 16;
		obj14 = this;
		CharacterScreenManager.onFacebookStatusChanged -= action9;
		InitializeSelectButton();
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		nint num14 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S1_v76 (Il2CppClass<Info.Outfits>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num15 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S1_v89 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int themeCount = Outfits.GetThemeCount(screenManagerInstance.currentlyShownCharacter__BackingField);
		string text = _characterThemeShifter.tag;
		((GameObject)(object)text).tag = (string)themeCount;
		if (~(_firstShow ? 1u : 0u) == 0)
		{
			IEnumerator list = DelayedInitCenterChar();
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
		}
		UpdateSelectedCharacter();
		bool charId = ShouldEnableCharacterDayParticleSystem();
		CenterScrollOnCharacterType(charId ? Characters.CharacterId.tricky : Characters.CharacterId.slick);
	}

	private unsafe void InitializeScrollList()
	{
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_037e: Expected I, but got Obj
		//IL_0394: Expected Obj, but got I
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0405: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0271: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_02b2: Expected I, but got Obj
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CharacterScreen.OnPopupShown);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v97 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnLastPopupClosed += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		UIScreenController.OnPopupClosed += action2;
		nint num4 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v29 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v93 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool running = FirstPurchaseBonusManager.running;
		((CharacterScreenManager)running)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		List<Outfit> list = default;
		list._items = (Outfit[])num6;
		list._syncRoot = 0;
		object obj5 = list + 16;
		obj5 = this;
		_characterThemeShifter.MakeCustomThemesAvailable(list);
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(CharacterScreen.OnCharacterUnlocked);
		object obj6 = action3 + 16;
		obj6 = this;
		CharacterScreenManager.characterUnlockedFailure += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr3;
		((Delegate)action4).method = (nint)__ldftn(CharacterScreen.UpdateSelectedCharacter);
		object obj7 = action4 + 16;
		obj7 = this;
		CharacterScreenManager.onFacebookStatusChanged += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		CharacterScreenManager characterScreenManager = default;
		characterScreenManager._purchaseInProgress = (byte)num7 != 0;
		characterScreenManager.currentlyShownThemeIndex__BackingField = 0;
		object obj8 = characterScreenManager + 16;
		obj8 = this;
		characterScreenManager.StartLoginToFacebook();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr4;
		((Delegate)action5).method = (nint)__ldftn(CharacterScreen.CharacterEventStarted);
		object obj9 = action5 + 16;
		obj9 = this;
		nint num8 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v70 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num9 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v89 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Action action6 = default;
		((Delegate)action6).method_ptr = method_ptr5;
		((Delegate)action6).method = (nint)__ldftn(CharacterScreen.CharacterEventFinished);
		object obj11 = action6 + 16;
		obj11 = this;
		SSEventsManagerController.OnSSEventChangedHandler += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		Action<string> action7 = default;
		object obj12 = action7 + 16;
		obj12 = this;
		UIScreenController.OnPopupShown += action7;
	}

	private void ClearScrollList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected Obj, but got Unknown
		//IL_08cd: Expected Obj, but got I4
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected Obj, but got Unknown
		//IL_08f0: Expected Obj, but got I4
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected Obj, but got Unknown
		//IL_0907: Expected Obj, but got I4
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected Obj, but got Unknown
		//IL_095e: Expected Obj, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_0a1d: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I4
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_09ed: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I4
		//IL_01bb: Expected I, but got Obj
		//IL_07ee: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I4
		//IL_08ac: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I4
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_029b: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I
		//IL_0a05: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_02dc: Expected I, but got Obj
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_031f: Expected Obj, but got I4
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0787: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 44;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 40;
		obj5 = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		_initialCenteredCharacterSelected = false;
		InitializeCentererIfNeeded();
		RefreshCharacterListIfNeeded();
		bool flag = DetectChangeInCharacterList();
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v239 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = this + 128;
		IEnumerator enumerator = CloudSave.LoginAsync((Action)1);
		obj8 = enumerator;
		_scrollListInitialized = false;
		_cachedCenteredIndex = -1;
		List<KeyValuePair<Characters.CharacterId, Characters.Model>> characterList = _characterList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v39 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<SYBO.Subway.Info.Characters+CharacterId, SYBO.Subway.Info.Characters+Model>>)+C]");
		CharacterListManager characterListManager = default;
		characterListManager.set_Item(0, (CharacterScrollListSlot)(object)this);
		object obj9 = this + 132;
		obj9 = characterListManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77DB");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj10 = 0;
		object obj12 = default;
		object obj13 = default;
		object obj15 = default;
		object obj11;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 41;
			bool flag2 = obj12 == null;
			obj11 = 42;
			if (flag2)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj11 = 13;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 14;
			obj5 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 15;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v141 (Il2CppClass<NGUITools>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v231 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj11 = 16;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj11 = 26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj11 = 28;
			obj5 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj11 = 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 29;
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S0_v190 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num6 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v223 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj11 = 30;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 37;
			CharacterScreenManager screenManagerInstance = _screenManagerInstance;
			bool flag3 = (nint)screenManagerInstance.currentlyShownCharacter__BackingField == (nint)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
			obj11 = 38;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			object obj17 = obj10 + 1;
			obj10 = obj17;
		}
		object obj18 = obj11 - 13;
		object obj21;
		object obj22 = default;
		object obj19;
		if ((nint)obj11 != 13 && (nint)obj18 != 1 && (nint)obj18 != 2 && (nint)obj18 != 3)
		{
			if ((nint)obj18 != 4 && (nint)obj18 != 5 && (nint)obj18 != 6 && (nint)obj18 != 7 && (nint)obj18 != 8 && (nint)obj18 != 9 && (nint)obj18 != 10 && (nint)obj18 != 11 && (nint)obj18 != 12)
			{
				if ((nint)obj18 == 13 || (nint)obj18 == 14 || (nint)obj18 == 15 || (nint)obj18 == 16 || (nint)obj18 == 17)
				{
					goto IL_078c;
				}
				if ((nint)obj18 != 18 && (nint)obj18 != 19 && (nint)obj18 != 20 && (nint)obj18 != 21 && (nint)obj18 != 22 && (nint)obj18 != 23)
				{
					if ((nint)obj18 == 24 || (nint)obj18 == 25 || (nint)obj18 == 26)
					{
						goto IL_078c;
					}
					if ((nint)obj18 != 27)
					{
						if ((nint)obj18 == 28)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj20 = default;
							obj19 = obj20;
							obj21 = obj22;
							goto IL_0a27;
						}
						if ((nint)obj18 == 29)
						{
							object obj23 = obj6 + 4;
							object obj24 = obj23 + 1;
							obj23 = obj24;
							object obj25 = obj24 << 2;
							object obj26 = obj6 + obj25;
							obj26 = 261;
						}
					}
				}
			}
			goto IL_0a5d;
		}
		goto IL_078c;
		IL_0a82:
		_characterListManager.OnInitialModelLoadingComplete();
		_characterGrid.BroadcastMessage("Start");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		bool flag4 = CacheActiveEventType();
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag4);
		return;
		IL_0a5d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj27 = (nint)0 << 2;
			object obj28 = obj6 + obj27;
			if ((nint)obj28 == 261)
			{
				object obj29 = obj6 + 4;
				if ((nint)obj29 > -1)
				{
					object obj30 = obj29 + -1;
					obj29 = obj30;
				}
				goto IL_0a82;
			}
		}
		object obj31 = default;
		if (obj31 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0a82;
		IL_0a27:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj32 = default;
		if (obj21 == obj32)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0a5d;
		IL_078c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj33 = default;
		obj19 = obj33;
		obj21 = obj22;
		goto IL_0a27;
	}

	private IEnumerator DelayedInitCenterChar()
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

	private void RefreshCharacterListIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_034e: Expected VT, but got Obj
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I4
		//IL_037d: Expected VT, but got Obj
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_0394: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got F4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_0414: Expected I, but got Obj
		//IL_042a: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I4
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected Obj, but got Unknown
		//IL_069f: Expected Obj, but got I4
		//IL_06a8: Expected Obj, but got F4
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_0455: Expected I, but got Obj
		//IL_04c1: Expected I, but got Obj
		//IL_04d7: Expected Obj, but got I
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected Obj, but got Unknown
		//IL_076d: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I
		//IL_0502: Expected I, but got Obj
		//IL_054f: Expected I, but got Obj
		//IL_0565: Expected Obj, but got I
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0590: Expected I, but got Obj
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 - -64;
		obj3 = obj;
		_ = -1;
		if (_characterListManager == null)
		{
			goto IL_0719;
		}
		Characters.CharacterId characterId = ((CharacterModelRequest)(object)_characterListManager).characterId;
		object obj4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj4 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v152 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v161 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj6 = obj3 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj3 + obj8;
		obj9 = 94;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj3 + obj11;
			if ((nint)obj12 == 94)
			{
				object obj13 = obj3 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0759;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0759;
		IL_0759:
		object obj16 = this + 132;
		obj16 = 0;
		goto IL_0719;
		IL_0719:
		string text = _characterGrid.tag;
		if (!((GameObject)(object)text).activeInHierarchy)
		{
			string text2 = _characterGrid.tag;
			((GameObject)(object)text2).tag = (string)1;
		}
		GameObject gameObject = _characterGrid.gameObject;
		Transform transform = (Transform)(obj2 + 52);
		GameObject gameObject2 = _characterGrid.gameObject;
		transform.localPosition = (Vector3)gameObject2;
		Transform transform2 = (Transform)(obj2 + 40);
		GameObject gameObject3 = _characterGrid.gameObject;
		transform2.localPosition = (Vector3)gameObject3;
		object obj17 = obj2 + 28;
		obj17 = 0;
		_ = 0;
		obj17 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v13 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		Transform transform3 = (Transform)(obj2 + 72);
		transform3 = (Transform)obj17;
		Transform transform4 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v21+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform3.eulerAngles;
		Camera anchorCamera = _scrollPanel.anchorCamera;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S1_v56 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj19 = obj2 + 16;
		Vector3 one = Vector3.one;
		transform3 = (Transform)obj19;
		Transform transform5 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v37+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform3.eulerAngles;
		obj2 = 0;
		obj2 = 0f;
		_ = 0f;
		object obj20 = obj2 + 8;
		obj20 = obj2;
		transform3 = (Transform)obj20;
		_scrollPanel.clipTexture = (Texture2D)(object)transform3;
		_centerer.OnEnable();
		SpringPanel component = _scrollPanel.GetComponent<SpringPanel>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(component);
	}

	public void OnInitialModelLoadingComplete()
	{
		if (~(_scrollListInitialized ? 1u : 0u) == 0 && ~(_charactersEnabled ? 1u : 0u) == 0 && GetCenterIndex() != 0)
		{
			ClearScrollList();
		}
	}

	public void OnSingleModelLoaded(Characters.CharacterId characterId)
	{
		_initiallyCenteredCharacterId = characterId;
	}

	private bool CacheActiveEventType()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	private bool DetectChangeInCharacterList()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_008a: Expected I8, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		SSEventType sSEventType;
		long num3 = default;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			SSEventType sSEventType2 = default;
			sSEventType = sSEventType2;
		}
		else
		{
			sSEventType = SSEventType.None;
			num3 = -1L;
		}
		if (_cachedActiveEventType == sSEventType && _cachedActiveEventID == num3)
		{
			return false;
		}
		_cachedActiveEventType = sSEventType;
		_cachedActiveEventID = num3;
		return true;
	}

	private void Update()
	{
		_scrollListInitialized = true;
	}

	private unsafe int GetCenterIndex()
	{
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_0294: Expected Obj, but got I4
		//IL_02ac: Expected I, but got Obj
		//IL_02c2: Expected Obj, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_01c9: Invalid comparison between VT and I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		bool flag = DetectChangeInCharacterList();
		nint num = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v80 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 8;
		if (~(forceRefreshOnCharacterScreen ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v67 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(CharacterScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v74 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			forceRefreshOnCharacterScreen = false;
			return 1;
		}
		if (flag)
		{
			return 1;
		}
		nint num5 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v61 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerator enumerator = CloudSave.LoginAsync();
		List<KeyValuePair<Characters.CharacterId, Characters.Model>> characterList = _characterList;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v32 (System.Collections.IEnumerator)+C]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v16 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<SYBO.Subway.Info.Characters+CharacterId, SYBO.Subway.Info.Characters+Model>>)+C]");
		if (num7 == 0)
		{
			ref bool reference = ref *(bool*)null;
			while (true)
			{
				ref bool reference2 = ref reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v32 (System.Collections.IEnumerator)+C]");
				if ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) >= unchecked((nint)null))
				{
					return 0;
				}
				_0021_00210 eventValue = (_0021_00210)((ExpiredLimitedBoardEventManager)(object)_characterList).GetEventValue<T>(out reference);
				if (eventValue == (_0021_00210)(object)0)
				{
					return 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77A9");
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77A9");
				obj = obj2;
				if (obj != obj)
				{
					break;
				}
				reference = ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 1);
			}
			return 1;
		}
		return 1;
	}

	private void RefreshScrollListUiOverlay(int centerIndex)
	{
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		if (screenManagerInstance.currentlyShownCharacter__BackingField == (Characters.CharacterId)centerIndex)
		{
			CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
			CharacterScreenManager screenManagerInstance3 = _screenManagerInstance;
			UpdateThemeShifter(screenManagerInstance2.currentlyShownCharacter__BackingField, screenManagerInstance3.currentlyShownThemeIndex__BackingField);
		}
	}

	private void UpdateCharacterModelsState()
	{
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_04da: Expected I, but got Obj
		//IL_04f0: Expected Obj, but got I
		//IL_0064: Expected I, but got Obj
		//IL_05cc: Expected Obj, but got I4
		//IL_027b: Expected I, but got Obj
		//IL_060b: Expected I, but got Obj
		//IL_0621: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_065e: Expected Obj, but got I
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_034e: Expected I, but got Obj
		//IL_013d: Expected I, but got Obj
		//IL_0218: Expected I, but got Obj
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			return;
		}
		UpdateUIElements();
		CenterOnChild centerer = _centerer;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)centerer._selectedObject).FindKernel((string)null) != 0)
		{
			CenterOnChild centerer2 = _centerer;
			CharacterScrollListSlot component = centerer2._selectedObject.GetComponent<CharacterScrollListSlot>();
			if (~(_hasShownModel ? 1u : 0u) != 0)
			{
				_hasShownModel = true;
				nint num3 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v117 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v124 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool index = CharacterManager.HasCharacterBeenSeen(component.characterId);
				UpdateThemeShifter(component.characterId, index ? 1 : 0);
				component.ui.Update();
			}
			CharacterScreenManager screenManagerInstance = _screenManagerInstance;
			if (screenManagerInstance.currentlyShownCharacter__BackingField != component.characterId)
			{
				CenterScrollOnCharacterType((Characters.CharacterId)component.index);
				nint num5 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v97 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v111 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = CharacterManager.HasCharacterBeenSeen(component.characterId);
				Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
				bool flag2 = component.characterId == (Characters.CharacterId)currentBoardId;
				bool flag3 = !flag2;
				Characters.CharacterId index2 = (flag ? Characters.CharacterId.tricky : Characters.CharacterId.slick);
				if (!flag3)
				{
					Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
					index2 = currentCharacterId;
				}
				UpdateThemeShifter(component.characterId, (int)index2);
				component.ui.Update();
			}
		}
		((CharacterScreenManager)(object)this).PurchaseCharacterWithInapp(CharacterScreenManager.CharacterPurchaseInitiator.none, Characters.CharacterId.slick);
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v76 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		bool flag5 = ((UIScreenController)flag4).IsPopupQueueEmpty();
		bool popupActive = _popupActive;
		if (flag5)
		{
			if (!popupActive || !_inappOverlayActive)
			{
				_popupActive = true;
			}
		}
		else if (popupActive && ~(_inappOverlayActive ? 1u : 0u) != 0)
		{
			_popupActive = false;
		}
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v29 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v62 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag6 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v34 (System.Boolean)+EC]");
		string text = ((GameObject)0).tag;
		bool inappOverlayActive = _inappOverlayActive;
		if (text != null)
		{
			if (!inappOverlayActive)
			{
				_inappOverlayActive = true;
			}
		}
		else if (inappOverlayActive)
		{
			_inappOverlayActive = false;
		}
		if (~(_inappOverlayActive ? 1u : 0u) != 0 && ~(_popupActive ? 1u : 0u) != 0)
		{
			if (!_charactersEnabled)
			{
				_characterListManager.RefreshCharacter(Characters.CharacterId.tricky, 1);
				_charactersEnabled = true;
				SetEventRibbonActive();
			}
		}
		else if (~(_charactersEnabled ? 1u : 0u) == 0)
		{
			_characterListManager.RefreshCharacter(Characters.CharacterId.slick, 0);
			_charactersEnabled = false;
		}
	}

	public unsafe void ChangeCurrentlyShownCharacter(Characters.CharacterId charId, int index)
	{
		//IL_04c1: Expected Obj, but got I4
		//IL_04cf: Expected I, but got Obj
		//IL_04e5: Expected Obj, but got I
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_0519: Expected Obj, but got VT
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected VT, but got Unknown
		//IL_054a: Expected F4, but got Obj
		//IL_0545: Expected native int or pointer, but got VT
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0573: Expected I, but got Obj
		//IL_0589: Expected Obj, but got I
		//IL_05b3: Expected F4, but got Obj
		//IL_05ae: Expected native int or pointer, but got VT
		//IL_05c8: Expected F4, but got I
		//IL_05c3: Expected native int or pointer, but got VT
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_05ec: Expected Obj, but got VT
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		//IL_060f: Expected F4, but got Obj
		//IL_060a: Expected native int or pointer, but got VT
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_0637: Expected F4, but got Obj
		//IL_0632: Expected native int or pointer, but got VT
		//IL_064c: Expected F4, but got I
		//IL_0647: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got VT
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00d9: Expected F4, but got Obj
		//IL_00d4: Expected native int or pointer, but got VT
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0101: Expected F4, but got Obj
		//IL_00fc: Expected native int or pointer, but got VT
		//IL_0116: Expected F4, but got I
		//IL_0111: Expected native int or pointer, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got VT
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0162: Expected F4, but got Obj
		//IL_015d: Expected native int or pointer, but got VT
		//IL_017c: Expected F4, but got Obj
		//IL_0177: Expected native int or pointer, but got VT
		//IL_0191: Expected F4, but got I
		//IL_018c: Expected native int or pointer, but got VT
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I4
		//IL_01f2: Expected I, but got Obj
		//IL_0747: Expected Obj, but got I4
		//IL_0759: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I4
		//IL_02c7: Expected I4, but got Obj
		//IL_0453: Expected I4, but got Obj
		//IL_0490: Expected I4, but got Obj
		//IL_0490: Expected Obj, but got VT
		//IL_038a: Expected I4, but got Obj
		//IL_038a: Expected I4, but got Obj
		//IL_038a: Expected I4, but got Obj
		//IL_03a5: Expected I4, but got Obj
		//IL_03a5: Expected I4, but got Obj
		//IL_03a5: Expected I4, but got Obj
		//IL_03b2: Expected Obj, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I4
		//IL_0341: Expected I4, but got Obj
		//IL_0341: Expected I4, but got Obj
		//IL_0341: Expected I4, but got Obj
		//IL_035c: Expected I4, but got Obj
		//IL_035c: Expected I4, but got Obj
		//IL_035c: Expected I4, but got Obj
		//IL_06a4: Expected Obj, but got I4
		//IL_06ed: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I4
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		_characterDayParticleSystem.tag = null;
		_centerAnchor.tag = (string)1;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<GlobalColors>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v130 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 88;
		obj2 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_ACTIVE;
		object obj4 = obj3 + 96;
		obj4 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 104);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		object obj5 = obj3 + 72;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v26 (Il2CppClass<NGUIText>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v126 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v24+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		string text = NGUIText.EncodeColor24((Color)matrix4x);
		object obj7 = obj3 - -64;
		obj7 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_INACTIVE;
		object obj8 = obj3 + 92;
		obj8 = obj7;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		object obj9 = obj3 + 48;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v40+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		string text2 = NGUIText.EncodeColor24((Color)matrix4x);
		object obj10 = obj3 + 40;
		obj10 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_ACTIVE;
		object obj11 = obj3 + 68;
		obj11 = obj10;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
		object obj12 = obj3 + 24;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v51+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		string text3 = NGUIText.EncodeColor24((Color)matrix4x);
		object obj13 = obj3 + 16;
		obj13 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_INACTIVE;
		object obj14 = obj3 + 44;
		obj14 = obj13;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
		Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		string text4 = NGUIText.EncodeColor24((Color)matrix4x);
		nint num5 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v67 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num6 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v122 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		CharacterNameEventManager typeOfActiveEventManager = ((SSEventsManagerController)(object)flurryUserId).GetTypeOfActiveEventManager<CharacterNameEventManager>();
		object obj16;
		if (typeOfActiveEventManager != null)
		{
			if (typeOfActiveEventManager._eventProgressData != null)
			{
				CharacterNameEventData eventProgressData = typeOfActiveEventManager._eventProgressData;
				obj16 = eventProgressData.collectedLetterIndex + 1;
			}
			else
			{
				obj16 = 0;
			}
		}
		else
		{
			obj16 = 0;
		}
		bool flag = string.IsNullOrEmpty((string)index);
		object obj17 = (flag ? 1 : 0) + 12;
		object obj18 = obj16;
		string text5 = string.Empty;
		string text6 = string.Empty;
		object obj19 = default;
		Type type = default;
		Type type2 = default;
		object obj32 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
		{
			object obj20 = (flag ? 1 : 0) + 16;
			object obj21 = obj19 << 1;
			object obj22 = obj20 + obj21;
			if (((CharacterScreenManager)null).GetLastSelectedThemeForCharacterType((Characters.CharacterId)obj22) != 0)
			{
				object obj23 = obj18 + 1;
				obj18 = obj23;
			}
			else
			{
				int num8;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
				{
					int num7 = text6.IndexOf((char)(int)"[", (int)text, (int)"]");
					num8 = text5.IndexOf((char)(int)"[", (int)text3, (int)"]");
					text6 = (string)num7;
				}
				else
				{
					int num9 = text6.IndexOf((char)(int)"[", (int)text2, (int)"]");
					num8 = text5.IndexOf((char)(int)"[", (int)text4, (int)"]");
					text6 = (string)num9;
				}
				text5 = (string)num8;
			}
			object obj24 = (flag ? 1 : 0) + 16;
			object obj25 = obj19 << 1;
			object obj26 = obj24 + obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			object obj27 = ((IConvertible)text6).ToType(type, (IFormatProvider)(object)" ");
			object obj28 = (flag ? 1 : 0) + 16;
			object obj29 = obj19 << 1;
			object obj30 = obj28 + obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			object obj31 = ((IConvertible)text5).ToType(type2, (IFormatProvider)(object)" ");
			obj19 = obj32 + 1;
			text5 = (string)obj31;
			text6 = (string)obj27;
		}
		if (obj17 != null)
		{
			int length = text6.m_stringLength - 1;
			string text7 = text6.InternalSubString(0, length);
			((UILabel)(object)_scrollListParent).fontSize = (int)text7;
			int length2 = text5.m_stringLength - 1;
			string text8 = text5.InternalSubString(0, length2);
			((UILabel)scrollCharacterPosition).fontSize = (int)text8;
		}
		((UILabel)_timerContainer).fontSize = (int)charId;
	}

	public void UpdateThemeShifter(Characters.CharacterId charId, int index)
	{
		//IL_0127: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I4
		//IL_0067: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I4
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		if (currentBoardId != (Boards.BoardId)charId)
		{
			bool flag = ((HoverboardOverlayHelper)(object)_characterListManager).BoardHasFreeThemes((Boards.BoardId)charId);
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				bool flag2 = ((HoverboardOverlayHelper)(object)_characterListManager).BoardHasFreeThemes((Boards.BoardId)charId);
				if (!((CharacterSelectButton)flag2).CurrentlyShownCharacterMatchesEventItem())
				{
					return;
				}
			}
		}
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		screenManagerInstance.currentlyShownCharacter__BackingField = charId;
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		screenManagerInstance2.currentlyShownThemeIndex__BackingField = index;
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SetupModelScreen((UIModelController.ModelScreen)charId, (ModelScreenSetup)index, (ModelScreenData)null);
		UpdateSelectedCharacter();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77D6");
	}

	public void UpdateUIElements()
	{
		//IL_009c: Expected Obj, but got I4
		if (~(_scrollListInitialized ? 1u : 0u) != 0)
		{
			return;
		}
		int characterVisibilityCount = GetCharacterVisibilityCount();
		bool flag = characterVisibilityCount <= 0;
		bool flag2 = !flag;
		int num = characterVisibilityCount;
		if (!flag2)
		{
			num = 0;
		}
		if (_cachedCenteredIndex != num)
		{
			_cachedCenteredIndex = num;
			if (_characterListManager != null)
			{
				CharacterListManager.Log((string)(object)_characterListManager, (UnityEngine.Object)num);
			}
		}
	}

	private void ShowTimer(bool showTimer, TimeSpan timeLeft)
	{
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_0081: Expected VT, but got Obj
		//IL_0176: Invalid comparison between VT and I8
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_019f: Expected Obj, but got VT
		_selectedFooterButton = 2;
		object obj = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		if (!showTimer)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex = default;
			ex._002Ector("address");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [showTimer @ L1 (System.Boolean)+C]");
		if ((nint)0 != 16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentException ex2 = default;
			ex2._002Ector((SerializationInfo)(object)"An invalid IP address was specified.", (StreamingContext)"address");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		_selectedFooterButton = 23;
		object obj3 = 0;
		while ((nint)obj3 <= 7)
		{
			object obj4 = _footerHandler + 16;
			object obj5 = obj3 << 1;
			object obj6 = obj4 + obj5;
			object obj7 = obj3 << 1;
			object obj8 = showTimer + obj7;
			object obj9 = obj8 + 17;
			object obj10 = (showTimer ? 1 : 0) + 16;
			object obj11 = obj3 << 1;
			object obj12 = obj10 + obj11;
			object obj13 = obj12 << 8;
			object obj14 = obj9 + obj13;
			obj6 = obj14;
			object obj15 = obj3 + 1;
			obj3 = obj15;
		}
		if (timeLeft < (object)4294967296L)
		{
			screenName = (string)timeLeft;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ArithmeticException ex3 = default;
		ex3._002Ector("scopeid");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	private unsafe void UpdateSelectedCharacter()
	{
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected Obj, but got Unknown
		//IL_06a3: Expected Obj, but got I4
		//IL_06b6: Expected Obj, but got I4
		//IL_06c8: Expected I, but got Obj
		//IL_06de: Expected Obj, but got I
		//IL_0709: Expected I4, but got Obj
		//IL_0725: Expected I, but got Obj
		//IL_073b: Expected Obj, but got I
		//IL_076a: Expected Obj, but got I4
		//IL_077c: Expected I, but got Obj
		//IL_0792: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected VT, but got Unknown
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected I4, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected Obj, but got Unknown
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got Unknown
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected Obj, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected Obj, but got Unknown
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected Obj, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_0828: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_0124: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_088c: Expected Obj, but got VT
		//IL_089a: Expected I, but got Obj
		//IL_08b0: Expected Obj, but got I
		//IL_0cc5: Expected I, but got Obj
		//IL_0cdb: Expected Obj, but got I
		//IL_08d6: Expected Obj, but got VT
		//IL_08eb: Expected F4, but got Obj
		//IL_08e6: Expected native int or pointer, but got VT
		//IL_0901: Expected Obj, but got VT
		//IL_0916: Expected F4, but got Obj
		//IL_0911: Expected native int or pointer, but got VT
		//IL_0930: Expected I4, but got Obj
		//IL_094a: Expected F4, but got Obj
		//IL_0945: Expected native int or pointer, but got VT
		//IL_095f: Expected F4, but got I
		//IL_095a: Expected native int or pointer, but got VT
		//IL_0972: Expected I4, but got VT
		//IL_0165: Expected I, but got Obj
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected Obj, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected Obj, but got Unknown
		//IL_09d2: Expected Obj, but got I4
		//IL_01b2: Expected I, but got Obj
		//IL_0a0c: Expected F4, but got Obj
		//IL_0a07: Expected native int or pointer, but got VT
		//IL_0a1a: Expected I4, but got VT
		//IL_0a2e: Expected I, but got Obj
		//IL_0a44: Expected Obj, but got I
		//IL_0277: Expected I, but got Obj
		//IL_0bd6: Expected I4, but got Obj
		//IL_043d: Expected I, but got Obj
		//IL_0307: Expected I, but got Obj
		//IL_031d: Expected Obj, but got I
		//IL_0a85: Expected I, but got Obj
		//IL_0a9b: Expected Obj, but got I
		//IL_0ad8: Expected I, but got Obj
		//IL_0aee: Expected Obj, but got I
		//IL_0348: Expected I, but got Obj
		//IL_04dc: Expected I, but got Obj
		//IL_04f2: Expected Obj, but got I
		//IL_0b14: Expected Obj, but got VT
		//IL_0b29: Expected F4, but got Obj
		//IL_0b24: Expected native int or pointer, but got VT
		//IL_0b3f: Expected Obj, but got VT
		//IL_0b54: Expected F4, but got Obj
		//IL_0b4f: Expected native int or pointer, but got VT
		//IL_0b6e: Expected I4, but got Obj
		//IL_0b88: Expected F4, but got Obj
		//IL_0b83: Expected native int or pointer, but got VT
		//IL_0b9d: Expected F4, but got I
		//IL_0b98: Expected native int or pointer, but got VT
		//IL_0bb0: Expected I4, but got VT
		//IL_0395: Expected I, but got Obj
		//IL_0c20: Expected I4, but got Obj
		//IL_04c9: Expected I4, but got Obj
		//IL_03e2: Expected I, but got Obj
		//IL_051d: Expected I, but got Obj
		//IL_0c3e: Expected Obj, but got I4
		//IL_0592: Expected I, but got Obj
		//IL_05a8: Expected Obj, but got I
		//IL_0c72: Expected Obj, but got I
		//IL_05d3: Expected I, but got Obj
		//IL_0648: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		bool isInstanced = UIScreenController.IsInstanced;
		IEnumerator enumerator = ((UIModelController)isInstanced).AnimateRunningCharacterForBragCelebration((GameObject)null);
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v170 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)enumerator);
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		nint num3 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26 (Il2CppClass<Info.Outfits>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v166 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((OutfitSet)enumerator).HasOutfitWithName((string)screenManagerInstance.currentlyShownThemeIndex__BackingField);
		nint num5 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v33 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v162 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 16);
		bool flag2 = (byte)(obj2 + 96) != 0;
		object obj6 = obj2 + 72;
		object obj7 = obj2 + 56;
		object obj8 = obj2 + 88;
		object obj9 = obj2 + 48;
		object obj10 = obj2 + 32;
		object obj11 = obj2 + 84;
		bool flag3 = CharacterManager.IsCollectionComplete((Characters.CharacterId)enumerator);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		Characters.CharacterId characterId;
		if (flag3)
		{
			characterId = Characters.CharacterId.slick;
		}
		else if (~(model.hasOnlineSettings ? 1u : 0u) == 0)
		{
			nint num7 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v149 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num8 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v157 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime lastModifiedMine = ((CloudSaveConflictResolver)enumerator).lastModifiedMine;
			obj = lastModifiedMine;
			nint num9 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v114 (Il2CppClass<GlobalColorsGenerated>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num10 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v131 (Il2CppClass<GlobalColorsGenerated>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj6 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
			obj8 = obj6;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			obj9 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
			obj11 = obj9;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj7 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v44+8]");
			_ = 0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v50+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_timer.AnimateClock(flag2, (byte)(int)matrix4x != 0);
			characterId = Characters.CharacterId.tricky;
		}
		else
		{
			characterId = Characters.CharacterId.slick;
		}
		bool flag4 = ((CoinButtonHelper)(object)_characterSelectButton).SupportsSpecialSale() && (_cachedActiveEventType == SSEventType.CharacterDay || _cachedActiveEventType == SSEventType.ExpiredLimitedCharacter);
		nint num11 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v63 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num12 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v132 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj15 = obj2 + 80;
		object obj16 = obj2 + 76;
		string flurryUserId = Flurry.flurryUserId;
		bool flag5 = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		bool flag6 = flag5;
		object obj17 = flag4 & flag6;
		bool flag7 = obj17 == null;
		Characters.CharacterId charId = characterId;
		if (!flag7)
		{
			if (flag3)
			{
				bool flag8 = _cachedActiveEventType != SSEventType.CharacterDay;
				charId = characterId;
				if (flag8)
				{
					goto IL_09f7;
				}
			}
			nint num13 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v105 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num14 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v125 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId2 = Flurry.flurryUserId;
			long currentEventID = ((SSEventsManagerController)(object)flurryUserId2).GetCurrentEventID();
			nint num15 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v113 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num16 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v121 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
			object obj20 = default;
			obj = obj20;
			nint num17 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S1_v83 (Il2CppClass<GlobalColors>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num18 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S1_v100 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj6 = GlobalColors.GIFT_LABEL_COLOR;
			obj15 = obj6;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
			Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
			obj9 = GlobalColors.GIFT_COLOR;
			obj16 = obj9;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
			Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
			((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj7 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v44+8]");
			_ = 0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v50+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_timer.AnimateClock(flag2, (byte)(int)matrix4x != 0);
			charId = Characters.CharacterId.tricky;
		}
		goto IL_09f7;
		IL_09f7:
		obj2 = obj;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		RefreshCharacterModelInScrollList(charId, (int)matrix4x);
		OnLastPopupClosed();
		nint num19 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S2_v11 (Il2CppClass<Strings>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num20 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S2_v42 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(model.name);
		_nameTitle.fontSize = (int)text;
		string text2 = Strings.GetDefault(model.characterLimitedDescription);
		int fontSize;
		if (text2 == null || text2.m_stringLength == 0)
		{
			fontSize = (int)"";
		}
		else
		{
			nint num21 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S2_v33 (Il2CppClass<Strings>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num22 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S2_v38 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = Strings.GetDefault(model.characterLimitedDescription);
			fontSize = (int)text3;
		}
		_nameSubtitle.fontSize = fontSize;
		if (flag)
		{
			nint num23 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S1_v57 (Il2CppClass<Strings>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num24 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S1_v63 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v31 (System.Boolean)+20]");
			string text4 = Strings.GetDefault((string)0);
			if (text4 != null && text4.m_stringLength != 0)
			{
				_nameSubtitle.fontSize = (int)text4;
			}
		}
		int centeredSlotIndex = GetCenteredSlotIndex();
		_characterDayParticleSystem.tag = (string)centeredSlotIndex;
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		CharacterScreenManager screenManagerInstance3 = _screenManagerInstance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77D6");
		CharacterScreenManager screenManagerInstance4 = _screenManagerInstance;
		CharacterScreenManager screenManagerInstance5 = _screenManagerInstance;
		ScaleScrollModels((byte)screenManagerInstance4.currentlyShownCharacter__BackingField != 0, screenManagerInstance5.currentlyShownThemeIndex__BackingField);
		((DiscountButton)(object)_characterSelectButton).ShowOnSale((string)null, (string)null);
	}

	private unsafe void RefreshCharacterModelInScrollList(Characters.CharacterId charId, int themeIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		string text = _timer.tag;
		((GameObject)(object)text).tag = (string)charId;
		if (charId != Characters.CharacterId.slick)
		{
			obj2 = ((int*)themeIndex)->m_value;
			obj = obj2;
			throw new ArrayTypeMismatchException();
		}
		_timer.HideIcon();
	}

	private void CharacterEventStarted()
	{
		//IL_0124: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		bool isInstanced = UIScreenController.IsInstanced;
		bool isInstanced2 = UIScreenController.IsInstanced;
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v12 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v35 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+84]");
		bool flag = CharacterManager.IsCollectionComplete(Characters.CharacterId.slick);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+84]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (System.Boolean)+80]");
		bool flag2 = ((UserData)num3).StrictlyBetterThan((UserData)0);
		object obj2 = flag & flag2;
		if (obj2 == null)
		{
			return;
		}
		nint num4 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v31 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+84]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (System.Boolean)+80]");
		CharacterManager.UnlockOutfit((Characters.CharacterId)num6, 0);
		UICharacterThemeShifter characterThemeShifter = _characterThemeShifter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+84]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (System.Boolean)+80]");
		((UIMessageHelper)(object)characterThemeShifter).ShowMessage((string)num7, false);
		((DiscountButton)(object)_characterSelectButton).ShowOnSale((string)null, (string)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+84]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (System.Boolean)+80]");
		OnCharacterUnlocked((Characters.CharacterId)num8, 0);
	}

	private unsafe void CharacterEventFinished()
	{
		//IL_01a6: Expected VT, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00e1: Expected Ref, but got VT
		//IL_0105: Expected Ref, but got VT
		//IL_00c9: Expected VT, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		Characters.CharacterId? characterId = (Characters.CharacterId?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj = (Nullable)characterId + 8;
		obj = 0;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v45 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = default;
			if ((nint)obj3 != 7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj4 = default;
				if ((nint)obj4 != 3)
				{
					goto IL_023c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
			_ = 1;
			object obj5 = default;
			characterId = (Characters.CharacterId?)obj5;
		}
		goto IL_023c;
		IL_023c:
		if (obj == null)
		{
			return;
		}
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		Characters.CharacterId value = ((Characters.CharacterId?*)characterId)->Value;
		screenManagerInstance.currentlyShownCharacter__BackingField = value;
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		Characters.CharacterId value2 = ((Characters.CharacterId?*)characterId)->Value;
		nint num3 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S2_v9 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S2_v17 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = CharacterManager.HasCharacterBeenSeen(value2);
		screenManagerInstance2.currentlyShownThemeIndex__BackingField = (flag ? 1 : 0);
		OnInitialModelLoadingComplete();
		CharacterScreenManager screenManagerInstance3 = _screenManagerInstance;
		CharacterScreenManager screenManagerInstance4 = _screenManagerInstance;
		UpdateThemeShifter(screenManagerInstance3.currentlyShownCharacter__BackingField, screenManagerInstance4.currentlyShownThemeIndex__BackingField);
	}

	private void RefreshCharacterScreen()
	{
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		screenManagerInstance.currentlyShownCharacter__BackingField = (Characters.CharacterId)currentBoardId;
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		CharacterScreenManager screenManagerInstance3 = _screenManagerInstance;
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v2 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S2_v10 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = CharacterManager.HasCharacterBeenSeen(screenManagerInstance3.currentlyShownCharacter__BackingField);
		screenManagerInstance2.currentlyShownThemeIndex__BackingField = (flag ? 1 : 0);
		OnInitialModelLoadingComplete();
		CharacterScreenManager screenManagerInstance4 = _screenManagerInstance;
		CharacterScreenManager screenManagerInstance5 = _screenManagerInstance;
		UpdateThemeShifter(screenManagerInstance4.currentlyShownCharacter__BackingField, screenManagerInstance5.currentlyShownThemeIndex__BackingField);
	}

	public void CenterScrollOnCharacterType(Characters.CharacterId charId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Characters.CharacterId characterId = ((CharacterModelRequest)(object)_characterListManager).characterId;
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v75+C]");
			if ((nint)0 != (nint)charId)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 73;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 73)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void OnCharacterUnlocked(Characters.CharacterId charId, int version)
	{
		if (~(_scrollListInitialized ? 1u : 0u) == 0)
		{
			((CharacterThemeButton)(object)_characterListManager).SetActiveBubbles((byte)charId != 0, (byte)version != 0);
		}
	}

	public void ScrollClicked(Vector2 pos)
	{
		//IL_02e5: Expected I4, but got VT
		//IL_02f7: Expected I, but got Obj
		//IL_030d: Expected Obj, but got I
		//IL_0334: Expected Obj, but got I4
		//IL_0146: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0178: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_01b9: Expected I, but got Obj
		//IL_035b: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_00c2: Expected I, but got Obj
		//IL_0247: Expected I, but got Obj
		bool flag = ((HoverboardOverlayHelper)(object)_characterListManager).BoardHasFreeThemes((Boards.BoardId)pos);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)flag != null)
		{
			Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
			bool flag2 = ((HoverboardOverlayHelper)(object)_characterListManager).BoardHasFreeThemes(currentBoardId);
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)flag2 != null)
			{
				bool flag3 = ((HoverboardOverlayHelper)(object)_characterListManager).BoardHasFreeThemes(Boards.BoardId.normal);
			}
			else
			{
				bool flag3 = ((HoverboardOverlayHelper)(object)_characterListManager).BoardHasFreeThemes(currentBoardId);
			}
		}
		else
		{
			bool flag3 = ((HoverboardOverlayHelper)(object)_characterListManager).BoardHasFreeThemes((Boards.BoardId)pos);
		}
		CharacterListManager characterListManager = _characterListManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v9 (System.Boolean)+C]");
		CharacterScrollListSlot characterScrollListSlot = characterListManager.get_Item(Characters.CharacterId.slick);
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (characterScrollListSlot != null)
		{
			nint num7 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v21 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(CharacterScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v27 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((CharacterScreenManager)(object)"Could not find character to center on. Aborting centering.").OnFacebookLoginResult(false);
		}
		else
		{
			CharacterListManager characterListManager2 = _characterListManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v9 (System.Boolean)+C]");
			CharacterScrollListSlot characterScrollListSlot2 = characterListManager2.get_Item(Characters.CharacterId.slick);
			GameObject gameObject = characterScrollListSlot2.gameObject;
			Vector2 vector = ((CoinBoxSizer)(object)gameObject).CalculateDistanceToBounds((UIWidget)1);
			_centerer.CharacterFocusedFromClick();
		}
	}

	private unsafe void OnThemeButtonClicked(int index)
	{
		//IL_029f: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_0422: Expected Obj, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected I4, but got Unknown
		//IL_043d: Expected I4, but got Obj
		//IL_044c: Expected I4, but got Obj
		//IL_045e: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I4
		//IL_0247: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v75 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(screenManagerInstance.currentlyShownCharacter__BackingField);
		object obj2 = ((int*)index)->m_value;
		int num3 = obj2 + 8;
		((int*)num3)->m_value = (int)obj2;
		bool flag = CharacterStickerManager.HasThemeBeenSeenForCharacter((Characters.CharacterId)_centerer, num3);
		nint num4 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v71 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = CharacterManager.IsCollectionComplete(screenManagerInstance.currentlyShownCharacter__BackingField);
		bool flag3 = CharacterManager.HasCharacterBeenSeen(screenManagerInstance.currentlyShownCharacter__BackingField);
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		bool flag4 = (flag3 ? 1 : 0) == screenManagerInstance2.currentlyShownThemeIndex__BackingField;
		object obj6;
		if (model.unlockType == PurchaseData.UnlockType.Facebook)
		{
			nint num6 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v48 (Il2CppClass<SocialManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v67 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
			{
				nint num8 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v58 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v63 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool running = FirstPurchaseBonusManager.running;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v38 (System.Boolean)+9]");
				bool flag5 = (nint)0 == 0;
				obj6 = 1;
				if (flag5)
				{
					goto IL_03a6;
				}
			}
			obj6 = 0;
		}
		else
		{
			obj6 = 1;
		}
		goto IL_03a6;
		IL_03a6:
		object obj7 = flag & flag2;
		object obj8 = obj7 & flag4;
		object obj9 = obj6 & obj8;
		if (obj9 == null)
		{
			return;
		}
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ActivateHoverboardModel(flag3 ? UIModelController.ModelScreen.GameOver : UIModelController.ModelScreen.Character);
		CharacterEventStarted();
		nint num10 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v24 (Il2CppClass<NGUITools>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num11 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v29 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string hierarchy = NGUITools.GetHierarchy((GameObject)(object)_selectSound);
	}

	private void UpdateCharacterSticker(Characters.CharacterId charId, int index)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01f2: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		UpdateThemeShifter(charId, index);
		if (index <= 0)
		{
			return;
		}
		nint num = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<Info.Outfits>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v27 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!((OutfitSet)charId).HasOutfitWithName((string)index))
		{
			return;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v8 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v14 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (System.Boolean)+20]");
		string text = Strings.GetDefault((string)0);
		nint num5 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v20 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v23 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void SetEventRibbonActive()
	{
		OnInitialModelLoadingComplete();
		UpdateSelectedCharacter();
	}

	private void SetRibbonInfo(RibbonPayload payload)
	{
		//IL_0017: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		screenManagerInstance.currentlyShownThemeIndex__BackingField = (int)payload;
		bool isInstanced = UIScreenController.IsInstanced;
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		((UIModelController)isInstanced).SetupModelScreen((UIModelController.ModelScreen)screenManagerInstance2.currentlyShownCharacter__BackingField, (ModelScreenSetup)(object)payload, (ModelScreenData)null);
		UpdateSelectedCharacter();
	}

	private void OnPopupShown(string popupName)
	{
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0376: Expected Obj, but got I4
		//IL_03a2: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01e8: Expected VT, but got Obj
		//IL_0447: Invalid comparison between Obj and F4
		//IL_0289: Invalid comparison between Obj and F4
		//IL_02be: Expected Obj, but got F4
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_02b0: Expected F4, but got Obj
		//IL_02d1: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I
		//IL_0519: Expected Obj, but got F4
		//IL_0312: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 20);
		object obj2 = obj + 8;
		obj2 = 0;
		_ = 0;
		bool flag = popupName.m_stringLength != 0;
		_eventRibbon.tag = (string)flag;
		if (popupName.m_stringLength == 0)
		{
			return;
		}
		char firstChar = popupName.m_firstChar;
		bool flag2;
		if (popupName.m_firstChar != '\0')
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (System.Char)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (flag2)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+10]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+10]");
		bool flag3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v24+8]");
			flag3 = (nint)0 == 0;
		}
		else
		{
			flag3 = true;
		}
		if (flag3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+14]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+14]");
		bool flag4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v28+8]");
			flag4 = (nint)0 == 0;
		}
		else
		{
			flag4 = true;
		}
		if (flag4)
		{
			return;
		}
		object obj5 = this - -64;
		object obj6 = obj5 + 16;
		((UILabel)obj6).fontSize = popupName.m_firstChar;
		object obj7 = this - -64;
		object obj8 = obj7 + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+10]");
		((UILabel)obj8).fontSize = 0;
		object obj9 = this - -64;
		object obj10 = obj9 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+14]");
		((UILabel)obj10).fontSize = 0;
		object obj11 = this - -64;
		object obj12 = obj11 + 24;
		Component component = (Component)obj12;
		GameObject gameObject = ((Component)obj12).gameObject;
		transform.localPosition = (Vector3)gameObject;
		obj2 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v27 (UnityEngine.Component)+164]");
		if ((nint)0 != 2)
		{
			_ = 2;
			_ = 1;
			_ = 1;
		}
		Vector2 localSize = ((UILabel)obj12).localSize;
		float num;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)155f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v27 (UnityEngine.Component)+164]");
			if ((nint)0 != 0)
			{
				_ = 0;
				_ = 1;
				_ = 1;
			}
			int height = NumberExtensions.CeilToInt(155f);
			((UIWidget)obj12).height = height;
			num = 155f;
		}
		else
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)136f))
			{
				obj2 = 0f;
				goto IL_048f;
			}
			num = (float)obj;
		}
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v66 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v71 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float value = num - 136f;
		float num4 = Math.Abs(value);
		float num5 = num4 * 0.5f;
		obj2 = num5;
		goto IL_048f;
		IL_048f:
		object obj14 = this - -64;
		object obj15 = obj14 + 24;
		GameObject gameObject2 = ((Component)obj15).gameObject;
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	private void OnLastPopupClosed()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0305: Expected Obj, but got I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0333: Expected Obj, but got I4
		//IL_0341: Expected I, but got Obj
		//IL_0357: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_0184: Expected I, but got Obj
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0221: Expected I, but got Obj
		//IL_026e: Expected I, but got Obj
		//IL_0284: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got F4
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_0433: Expected VT, but got Obj
		//IL_02af: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		object obj3 = obj2 + 20;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v100 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj6 = default;
			if ((nint)obj6 == 7)
			{
				flag = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj7 = default;
				flag = (nint)obj7 == 3;
			}
		}
		else
		{
			flag = false;
		}
		obj = string.Empty;
		obj3 = string.Empty;
		obj4 = string.Empty;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = (flag ? 1 : 0);
		object obj8 = text + 12;
		obj8 = obj;
		object obj9 = text + 16;
		obj9 = obj3;
		object obj10 = text + 20;
		obj10 = obj4;
		OnPopupShown(text);
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v39 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v86 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = obj2 + 32;
		object obj13 = obj2 + 8;
		if (!IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			return;
		}
		UIAnchor component = _eventRibbon.GetComponent<UIAnchor>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v82 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num7 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v62 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num8 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v76 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = ((Range)IPhoneXSupport.OFFSET_TOP).ToString();
		obj13 = 0;
		obj13 = 10f;
		object obj16 = 0 - text2;
		obj2 = obj13;
		obj12 = obj2;
		component.pixelOffset = (Vector2)obj12;
	}

	private bool ShouldEnableCharacterDayParticleSystem()
	{
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		CenterOnChild centerer = _centerer;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)centerer._selectedObject).FindKernel((string)null) != 0)
		{
			CenterOnChild centerer2 = _centerer;
			CharacterScrollListSlot component = centerer2._selectedObject.GetComponent<CharacterScrollListSlot>();
			return (byte)component.index != 0;
		}
		return false;
	}

	public void ScaleScrollModels(bool forceScaleSingleCharacter = false, int scrollIndex = 0)
	{
		//IL_026b: Expected I, but got Obj
		//IL_0281: Expected Obj, but got I
		//IL_03b2: Expected I, but got Obj
		//IL_03c8: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I4
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v73 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(forceScaleSingleCharacter ? Characters.CharacterId.tricky : Characters.CharacterId.slick);
		nint num3 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15 (Il2CppClass<Info.Outfits>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v69 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((OutfitSet)forceScaleSingleCharacter).HasOutfitWithName((string)scrollIndex);
		nint num5 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v65 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = CharacterManager.IsCollectionComplete(forceScaleSingleCharacter ? Characters.CharacterId.tricky : Characters.CharacterId.slick);
		string text;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20 (System.Boolean)+1C]");
			text = (((nint)0 == 0) ? ((CoinEarnerVideoAds)forceScaleSingleCharacter).GetTitleForVideoAdPrize((VideoAdPrizeType)scrollIndex) : ((string)1));
		}
		else
		{
			text = (string)1;
		}
		bool flag3 = scrollIndex == 0;
		object obj4 = (flag2 ? 1 : 0) ^ 1;
		object obj5 = flag3 & obj4;
		bool hasOnlineSettings = model.hasOnlineSettings;
		object obj6 = obj5 & hasOnlineSettings;
		bool flag6;
		if (((CoinButtonHelper)(object)_characterSelectButton).SupportsSpecialSale())
		{
			bool flag4 = _cachedActiveEventType != SSEventType.CharacterDay;
			bool flag5 = !flag4;
			flag6 = flag3;
			if (!flag5)
			{
				bool flag7 = _cachedActiveEventType != SSEventType.ExpiredLimitedCharacter;
				bool flag8 = !flag7;
				flag6 = flag3;
				if (!flag8)
				{
					flag6 = false;
				}
			}
		}
		else
		{
			flag6 = false;
		}
		if (text != null)
		{
			if (flag6)
			{
				_characterSelectButton.ShowLockedTokenContent(true);
			}
			else if (obj6 != null)
			{
				_characterSelectButton.ShowLockedTokenContent(true);
			}
			else
			{
				_characterSelectButton.ShowLockedTokenContent(false);
			}
		}
		else
		{
			_characterSelectButton.ShowLockedTokenContent(true);
		}
	}

	private int GetCenteredSlotIndex()
	{
		//IL_012b: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.king))
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			if (((UIScreenController)flag).IsPopupQueueEmpty())
			{
				return 0;
			}
			return ((CoinButtonHelper)(object)_characterSelectButton).SupportsSpecialSale() ? 1 : 0;
		}
		return 0;
	}

	public int GetCharacterVisibilityCount()
	{
		//IL_01de: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0114: Expected I, but got Obj
		//IL_012a: Expected Obj, but got I
		//IL_0155: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_centerer).FindKernel((string)null) != 0)
		{
			CenterOnChild centerer = _centerer;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)centerer._selectedObject).FindKernel((string)null) != 0)
			{
				CenterOnChild centerer2 = _centerer;
				CharacterScrollListSlot component = centerer2._selectedObject.GetComponent<CharacterScrollListSlot>();
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
				{
					return component.index;
				}
				return -1;
			}
			return -1;
		}
		return -1;
	}

	public int GetCharacterLoadRange()
	{
		return 4;
	}

	public bool AreCharactersEnabled()
	{
		return true;
	}

	public int GetAmountOfSyncModelsLoaded()
	{
		return _charactersEnabled ? 1 : 0;
	}

	private void VerifyCharacterAmount()
	{
		//IL_0019: Expected Obj, but got I4
		int centeredSlotIndex = GetCenteredSlotIndex();
		_characterDayParticleSystem.tag = (string)centeredSlotIndex;
		if (~(_hasShownModel ? 1u : 0u) == 0)
		{
			CharacterScreenManager screenManagerInstance = _screenManagerInstance;
			CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
			UpdateThemeShifter(screenManagerInstance.currentlyShownCharacter__BackingField, screenManagerInstance2.currentlyShownThemeIndex__BackingField);
		}
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4C]");
		if (((GameObject)0).activeInHierarchy)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4C]");
			((GameObject)0).tag = null;
		}
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}
}
